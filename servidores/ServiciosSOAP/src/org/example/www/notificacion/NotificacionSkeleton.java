
/**
 * NotificacionSkeleton.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis2 version: 1.6.3  Built on : Jun 27, 2015 (11:17:49 BST)
 */
package org.example.www.notificacion;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.Date;

import org.example.www.MysqlConnect;

/**
 * NotificacionSkeleton java skeleton for the axisService
 */
public class NotificacionSkeleton {

	/**
	 * Auto generated method signature
	 * 
	 * @param notificarInscripcion
	 * @return notificarInscripcionResponse
	 */

	public org.example.www.notificacion.NotificarInscripcionResponse notificarInscripcion(
			org.example.www.notificacion.NotificarInscripcion notificarInscripcion) {
		NotificarInscripcionResponse response = new NotificarInscripcionResponse();
		FormatoNotificacion resp = new FormatoNotificacion();
		MysqlConnect mysqlConnect = new MysqlConnect();
		try {
			String sql = String.format("SELECT d.nombre AS userName, d.apellidos, o.nombre AS cursoName FROM lista_curso AS c JOIN oferta_curso AS o ON o.id = '%d' JOIN demandante AS d ON d.dni = '%s'", notificarInscripcion.getId_oferta(), notificarInscripcion.getDni());
			PreparedStatement statement = mysqlConnect.connect().prepareStatement(sql);
		    ResultSet rs = statement.executeQuery( sql );
		    //System.out.println(sql);
		    String nombre = null, apellidos = null, curso = null;
		    while (rs.next()) {
		    	nombre = rs.getString("userName");
		    	apellidos = rs.getString("apellidos");
		    	curso = rs.getString("cursoName");
		    }
		    String fullName = nombre + " " + apellidos;
		    
		    resp.setTipo(true);
			resp.setTitulo("Notificación de inscripción en un Curso de Formación");
			resp.setDescripcion(String.format("Hola %s, le informamos que su inscripción para el curso %s ha sido registrada correctamente.", fullName, curso));
			resp.setFecha(new Date());
			response.setRespuesta(resp);
		} catch (SQLException e) {
			e.printStackTrace();
		} finally {
			mysqlConnect.disconnect();
		}
		
		return response;
	}

	/**
	 * Auto generated method signature
	 * 
	 * @param notificarError
	 * @return notificarErrorResponse
	 */

	public org.example.www.notificacion.NotificarErrorResponse notificarError(
			org.example.www.notificacion.NotificarError notificarError) {
		NotificarErrorResponse response = new NotificarErrorResponse();
		FormatoNotificacion resp = new FormatoNotificacion();
		
		resp.setFecha(new Date());
		resp.setTipo(false);
		switch (notificarError.getCod_error()) {
		case 1:
			resp.setTitulo("Notificación de error de inicio de sesión");
			resp.setDescripcion("Las credenciales que ha suministrado no son correctas.");
			break;
		case 2:
			resp.setTitulo("Notificación de error de plazo de inscripción");
			resp.setDescripcion("El plazo de inscripción para dicha oferta de formación ha concluido.");
			break;
		case 3:
			resp.setTitulo("Notificación de error de número de plazas");
			resp.setDescripcion("El número de plazas para dicha oferta de formación ha sido completado.");
			break;
		default:
			resp.setTitulo("Notificación de error");
			resp.setDescripcion("Se ha producido un error");
			break;
		}
		
		response.setResponse(resp);
		return response;
	}

}
