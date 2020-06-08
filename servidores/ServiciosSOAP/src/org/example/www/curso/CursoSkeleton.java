
/**
 * CursoSkeleton.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis2 version: 1.6.3  Built on : Jun 27, 2015 (11:17:49 BST)
 */
package org.example.www.curso;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.Date;

import org.example.www.MysqlConnect;

/**
 * CursoSkeleton java skeleton for the axisService
 */
public class CursoSkeleton {

	/**
	 * Auto generated method signature
	 * 
	 * @param comprobarFecha
	 * @return comprobarFechaResponse
	 */

	public org.example.www.curso.ComprobarFechaResponse comprobarFecha(
			org.example.www.curso.ComprobarFecha comprobarFecha) {
		ComprobarFechaResponse response = new ComprobarFechaResponse();
		response.setDisponible(false);
		response.setMessage("El plazo de inscripción para este curso ha acabado");
		
		MysqlConnect mysqlConnect = new MysqlConnect();
		try {
			String sql = String.format("SELECT * FROM oferta_curso WHERE id = '%d'", comprobarFecha.getId_oferta());
			PreparedStatement statement = mysqlConnect.connect().prepareStatement(sql);
		    ResultSet rs = statement.executeQuery( sql );
		    
		    Date fecha = new Date();
		    Date now = fecha;
		    while (rs.next()) {
		    	fecha = rs.getDate("fecha");
		    }		    	
		    		    
		    if (fecha.getTime() > now.getTime()) {
		    	response.setDisponible(true);
		    	response.setMessage("Aún queda tiempo para inscribirse en este curso");
		    }
		} catch (SQLException e) {
			response.setMessage(e.getMessage());
		} finally {
			mysqlConnect.disconnect();
		}
		return response;
	}

	/**
	 * Auto generated method signature
	 * 
	 * @param comprobarPlazas
	 * @return comprobarPlazasResponse
	 */

	public org.example.www.curso.ComprobarPlazasResponse comprobarPlazas(
			org.example.www.curso.ComprobarPlazas comprobarPlazas) {
		ComprobarPlazasResponse response = new ComprobarPlazasResponse();
		response.setDisponible(false);
		response.setMessage("Lamentablemente el número de plazas para este curso está lleno");
		
		MysqlConnect mysqlConnect = new MysqlConnect();
		try {
			String sql = String.format("SELECT COUNT(*) AS filas, plazas  FROM lista_curso JOIN oferta_curso ON id_oferta = id WHERE id_oferta = '%d';", comprobarPlazas.getId_oferta());
			PreparedStatement statement = mysqlConnect.connect().prepareStatement(sql);
		    ResultSet rs = statement.executeQuery( sql );
		    
		    Integer plazas = 0, count = 0;
		    while (rs.next()) {
		    	count = rs.getInt("filas");
		    	plazas = rs.getInt("plazas");
		    }		    	
		    
		    if (count < plazas) {
		    	response.setDisponible(true);
		    	response.setMessage( (plazas - count == 1) ? "Última plaza disponible" : "Todavía quedan plazas disponibles");
		    }
		} catch (SQLException e) {
			response.setMessage(e.getMessage());
		} finally {
			mysqlConnect.disconnect();
		}
		return response;
	}

}
