/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package br.com.conexao;
import java.sql.*;

public class Conexao {
    String driver, urlBanco, usuarioBanco, senhaBanco;
    Connection con;
    
    public Connection Conetor(){
        driver = "com.mysql.jdbc.Driver";
        urlBanco = "jdbc:mysql://localhost:3306/escola";
        usuarioBanco = "root";
        senhaBanco = "";
        
        try{
            Class.forName(driver);
            con = DriverManager.getConnection(urlBanco, usuarioBanco, senhaBanco);
        
        } catch(ClassNotFoundException e){
            e.printStackTrace();
        } catch(SQLException sqle){
            sqle.printStackTrace();
        }
        return con;
    }
    
}
