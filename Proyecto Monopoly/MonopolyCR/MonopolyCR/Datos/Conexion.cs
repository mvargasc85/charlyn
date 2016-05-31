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
        public Conexion() { }



         //abre la conexion
        public void openCon()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
        }

        //cierra la conexion
        public void closeCon()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }


        //para ejecutar comandos insert,update, delete
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
            }
            finally
            {
                closeCon();
            }
        }

        public String InsertarJugador(Jugador jugador)
        {
            var fechaActual = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            String q = string.Format("INSERT INTO Jugador (nombre,fecha,puntuacion, color) values ('{0}','{1}',{2},'{3}')",
                                     jugador.Nombre, fechaActual, 0, jugador.Color);
            return ExecuteQuery(q);
        }

        public List<Jugador> ObtenerJugadores()
        {

            var jugadores = new List<Jugador>();
            jugadores.Add(new Jugador { IdJugador = 0, Nombre = "Seleccione..." });
            try
            {
                openCon();
                const string query = "SELECT * FROM jugador";
                comando = new MySqlCommand(query, conexion);
                var reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    jugadores.Add(ConvertirJugador(reader));
                }

                return jugadores;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al obtener jugadores. Error: " + ex.Message);
                return null;
            }
            finally
            {
                closeCon();
            }

        }


        private Jugador ConvertirJugador(IDataReader reader)
        {

            var jugador = new Jugador();
            jugador.Nombre = Convert.ToString(reader["nombre"]);
            jugador.IdJugador = Convert.ToInt32(reader["idjugador"]);
            jugador.Color = Convert.ToString(reader["color"]);

            return jugador;
        }


        public List<Partida> ObtenerHistorial()
        {

            var partidas = new List<Partida>();
            try
            {
                openCon();
                const string query = "select j.nombre,p.fecha,h.puntuacion,p.ganador " +
                    "from jugador j inner join historicopartida h " +
                    "on j.idjugador= h.idjugador " +
                    "inner join partida p " +
                    "on h.idpartida = p.idpartida";

                comando = new MySqlCommand(query, conexion);
                var reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    partidas.Add(ConvertirHistorial(reader));
                }

                return partidas;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al obtener historial. Error: " + ex.Message);
                return null;
            }
            finally
            {
                closeCon();
            }

        }


        private Partida ConvertirHistorial(IDataReader reader)
        {

            var Partidas = new Partida();
            Partidas.Nombre = Convert.ToString(reader["nombre"]);
            Partidas.Fecha = Convert.ToDateTime(reader["fecha"]);
            Partidas.Puntuacion = Convert.ToInt32(reader["puntuacion"]);
            Partidas.Ganador = Convert.ToInt32(reader["ganador"]);

            return Partidas;
        }



        public Jugador ObtenerJugador(int jugadorId)
        {
            Jugador jugador = null;
            try
            {
                openCon();
                var query = string.Format("SELECT * FROM jugador where jugadorid ={0}", jugadorId);
                comando = new MySqlCommand(query, conexion);
                var reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    jugador = ConvertirJugador(reader);
                }

                return jugador;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al obtener jugadores. Error: " + ex.Message);
                return null;
            }
            finally
            {
                closeCon();
            }

        }
        public String InsertarPropiedad(Propiedad propiedad){
	String q = string.Format("INSERT INTO Propiedad (nombre,valorCompra,valorPeaje,propietario) values ('{0}','{1}',{2},'{3}')",
	                         propiedad.Nombre,propiedad.ValorCompra,propiedad.ValorPeaje);
	return ExecuteQuery(q);
}

    }
}




        



