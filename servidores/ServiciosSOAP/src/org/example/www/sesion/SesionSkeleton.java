
/**
 * SesionSkeleton.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis2 version: 1.6.3  Built on : Jun 27, 2015 (11:17:49 BST)
 */
package org.example.www.sesion;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

import org.example.www.MysqlConnect;

/**
 * SesionSkeleton java skeleton for the axisService
 */
public class SesionSkeleton {

	/**
	 * Auto generated method signature
	 * 
	 * @param login
	 * @return loginResponse
	 */

	public org.example.www.sesion.LoginResponse login(org.example.www.sesion.Login login) {
		LoginResponse response = new LoginResponse();
		MysqlConnect mysqlConnect = new MysqlConnect();
		response.setAutorizado(false);
		
		try {
			String sql = "SELECT * FROM demandante WHERE dni = '" + login.getDni() + "' AND pass = '" + login.getPassword() + "'";
			PreparedStatement statement = mysqlConnect.connect().prepareStatement(sql);
		    ResultSet rs = statement.executeQuery( sql );
		    if (rs.next()) {
		    	response.setAutorizado(true);
		    }
		} catch (SQLException e) {
			e.printStackTrace();
		} finally {
		    mysqlConnect.disconnect();
		}
		
		return response;
	}

}
