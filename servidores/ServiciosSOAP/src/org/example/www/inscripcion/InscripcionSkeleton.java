
/**
 * InscripcionSkeleton.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis2 version: 1.6.3  Built on : Jun 27, 2015 (11:17:49 BST)
 */
package org.example.www.inscripcion;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

import org.example.www.MysqlConnect;

/**
 * InscripcionSkeleton java skeleton for the axisService
 */
public class InscripcionSkeleton {

	public Integer getDemandanteId(String dni) {
		Integer id_demandante = null;
		
		MysqlConnect mysqlConnect = new MysqlConnect();
		try {
			String sql = String.format("SELECT id FROM demandante WHERE dni = '%s'", dni);
			PreparedStatement statement = mysqlConnect.connect().prepareStatement(sql);
		    ResultSet rs = statement.executeQuery( sql );
		    
		    while (rs.next()) {
		    	id_demandante = rs.getInt("id");
		    }		    	
		} catch (SQLException e) {
			e.printStackTrace();
		} finally {
			mysqlConnect.disconnect();
		}
		
		return id_demandante;
	}
	
	/**
	 * Auto generated method signature
	 * 
	 * @param inscribirDemandante
	 * @return inscribirDemandanteResponse
	 */

	public org.example.www.inscripcion.InscribirDemandanteResponse inscribirDemandante(
			org.example.www.inscripcion.InscribirDemandante inscribirDemandante) {
		InscribirDemandanteResponse response = new InscribirDemandanteResponse();
		response.setInscrito(false);
		response.setMessage("El demandante no ha sido inscrito en el curso");
		
		MysqlConnect mysqlConnect = new MysqlConnect();
		try {
			Integer id_demandante = getDemandanteId(inscribirDemandante.getDni());
			String sql = String.format("INSERT INTO lista_curso (id_oferta, id_demandante) VALUES ('%d', '%d')", inscribirDemandante.getId_oferta(), id_demandante);
			PreparedStatement statement = mysqlConnect.connect().prepareStatement(sql);
		    Integer rows = statement.executeUpdate( sql );
		    
		    if (rows > 0) {
		    	response.setInscrito(true);
		    	response.setMessage("El demandante ha sido inscrito correctamente en el curso");
		    }
		} catch (SQLException e) {
			//e.printStackTrace();
			response.setMessage(e.getMessage());
		} finally {
			mysqlConnect.disconnect();
		}
		
		return response;
	}

}
