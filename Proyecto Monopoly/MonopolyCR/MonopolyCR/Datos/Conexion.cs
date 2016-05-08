/*
 * Created by SharpDevelop.
 * User: Charlyn Avila
 * Date: 07/05/2016
 * Time: 08:21 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
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
	String q = string.Format("INSERT INTO Jugador (nombre,fecha,puntuacion, color) values ('{0}','{1}',{2},'{3}')",
	                         jugador.Nombre,fechaActual,0,jugador.Color);
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
       
        }
}


