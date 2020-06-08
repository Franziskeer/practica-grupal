
/**
 * InscripcionSkeleton.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis2 version: 1.6.3  Built on : Jun 27, 2015 (11:17:49 BST)
 */
package org.example.www.inscripcion;

import java.sql.PreparedStatement;
import java.sql.SQLException;

import org.example.www.MysqlConnect;

/**
 * InscripcionSkeleton java skeleton for the axisService
 */
public class InscripcionSkeleton {

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
			String sql = String.format("INSERT INTO lista_curso (id_oferta, id_demandante) VALUES ('%d', '%d')", inscribirDemandante.getId_oferta(), inscribirDemandante.getId_demandante());
			PreparedStatement statement = mysqlConnect.connect().prepareStatement(sql);
		    Integer rows = statement.executeUpdate( sql );
		    
		    if (rows == 1) {
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
