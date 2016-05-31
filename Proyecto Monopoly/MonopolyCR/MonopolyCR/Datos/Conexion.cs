/*
 * Created by SharpDevelop.
 * User: Charlyn Avila
 * Date: 07/05/2016
 * Time: 08:21 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
 

namespace MonopolyCR.Datos
{
	/// <summary>
	/// Description of Conexion.
	/// </summary>
	public class Conexion
	
	{


        //connect c# to Mysql database
        readonly MySqlConnection conexion = new MySqlConnection("datasource=localhost;port=3306;username=root;password=1234;database=monopoly");
        MySqlCommand comando;
        public Conexion()
        {
        }
        


//        //button insert data to mysql database
//        private void btnInsert_Click(object sender, EventArgs e)
//        {
//            string q = "insert into test_db.users (fname,lname,age) values('"+textFname.Text+"','"+textLname.Text+"',"+textAge.Text+")";
//            ExecuteQuery(q);
//        }
         
public String InsertarJugador(Jugador jugador){
	var fechaActual = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
	String q = string.Format("INSERT INTO Jugador (nombre,fecha,puntuacion,color) values ('{0}','{1}',{2},'{3}')",
	                         jugador.Nombre,fechaActual,0,jugador.Color);
	return ExecuteQuery(q);
}


public String InsertarPropiedad(Propiedad propiedad){
	String q = string.Format("INSERT INTO Propiedad (nombre,valorCompra,valorPeaje,propietario) values ('{0}','{1}',{2},'{3}')",
	                         propiedad.Nombre,propiedad.ValorCompra,propiedad.ValorPeaje);
	return ExecuteQuery(q);
}

//        //button update data from mysql database
//        private void btnUpdate_Click(object sender, EventArgs e)
//        {
//            string q = "update test_db.users set fname='" + textFname.Text + "',lname='" + textLname.Text + "',age=" + textAge.Text + " where id =" + textID.Text;
//            ExecuteQuery(q);
//        }
        


//       //button delete data from mysql database
//        private void btnDelete_Click(object sender, EventArgs e)
//        {
//            string q = "delete from test_db.users where id = " + textID.Text;
//            ExecuteQuery(q);
//            textID.Text = "";
//            textFname.Text = "";
//            textLname.Text = "";
//            textAge.Text = "";
//        }
//         


        //function to open connection
        public void openCon()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
        }
        


        //function to Close connection
        public void  closeCon()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }
  


        //function to execute the insert update and delete query
        public String ExecuteQuery(String q)
        {
            try
            {
                openCon();
                comando = new MySqlCommand(q, conexion);
                if (comando.ExecuteNonQuery() == 1)
                {
                	return "0";
                }
                else
                {
                	return "-1";
                }
            }
            catch (Exception ex)
            {
            	return ex.Message;
            }finally{
                closeCon();
            }
        }        

        
        public List<Jugador> ObtenerJugadores(){
        	
        	var jugadores = new List<Jugador>();
        try {
        		openCon();
				const string query = "SELECT idjugador, nombre FROM jugador";
        		comando = new MySqlCommand(query,conexion);
        		var reader = comando.ExecuteReader();
        		
        		while (reader.Read()) {
        			jugadores.Add(ConvertirJugador(reader));
        		}	
        		
        		return jugadores;
        		
        } catch (Exception ex) {
        	
		MessageBox.Show("Error al obtener jugadores. Error: "+ex.Message);
		return null;
		}finally{
		closeCon();
	}
	
        }
	
        
        private Jugador ConvertirJugador(IDataReader reader){
        	
        		var jugador = new Jugador();
        		jugador.Nombre = Convert.ToString(reader["nombre"]);
        		jugador.IdJugador = Convert.ToInt32(reader["idjugador"]);       		 	
        	
        	return jugador;
        }
      
         
        public List<Partida> ObtenerHistorial(){
        	
        	var partidas = new List<Partida>();
        try {
        		openCon();
				const string query = "select j.nombre,p.fecha,h.puntuacion,p.ganador " +
					"from jugador j inner join historicopartida h " +
					"on j.idjugador= h.idjugador " +
					"inner join partida p " +
					"on h.idpartida = p.idpartida" ;
				
        		comando = new MySqlCommand(query,conexion);
        		var reader = comando.ExecuteReader();
        		
        		while (reader.Read()) {
        			partidas.Add(ConvertirHistorial(reader));
        		}	
        		
        		return partidas;
        		
        } catch (Exception ex) {
        	
		MessageBox.Show("Error al obtener historial. Error: "+ex.Message);
		return null;
		}finally{
		closeCon();
	}
	
        }
	
    
	private Partida ConvertirHistorial(IDataReader reader){
        	
        		var Partidas = new Partida();
        		Partidas.Nombre = Convert.ToString(reader["nombre"]);
        		Partidas.Fecha = Convert.ToDateTime(reader["fecha"]);
        		Partidas.Puntuacion= Convert.ToInt32(reader["puntuacion"]);
        		Partidas.Ganador= Convert.ToInt32(reader["ganador"]);
        	
        	return Partidas;
        }
      
        
        }
        
        
       
        }
        



