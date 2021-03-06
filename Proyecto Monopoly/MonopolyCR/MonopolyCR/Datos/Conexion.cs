﻿/*
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
        readonly MySqlConnection conexion = new MySqlConnection("datasource=localhost;port=3306;username=root;password=Admin;database=monopoly");
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


        //para ejecutar comandos insert,update, delete y devolver el id del script afectado
        public int ExecuteScalar(String q)
        {
            try
            {
                openCon();
                comando = new MySqlCommand(q, conexion);
               var result = comando.ExecuteScalar() ;
               return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                return -1;
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
            jugador.NombreColor = Convert.ToString(reader["color"]);

            return jugador;
        }





        public List<HistoricoPartidas> ObtenerHistorial()
        {

            var historico = new List<HistoricoPartidas>();
            try
            {
                openCon();
                const string query = "SELECT p.idpartida, p.nombrepartida,p.fecha,j.idjugador,j.nombre,h.color,h.puntuacion as saldo,p.ganador,h.posicionActual " +
                "FROM historicopartida h " +
                "join partida p on h.idpartida = p.idpartida " +
                "join jugador j on h.idjugador= j.idjugador";
                comando = new MySqlCommand(query, conexion);

                var reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    historico.Add(ConvertirHistorial(reader));
                }

                return historico;

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

        public HistoricoPartidas ConvertirHistorial(IDataReader reader)
        {
            var jugador = new Jugador();
            jugador.IdJugador = Convert.ToInt32(reader["idjugador"]);
            jugador.Nombre = Convert.ToString(reader["nombre"]);
            jugador.NombreColor = Convert.ToString(reader["color"]);
            jugador.Saldo = Convert.ToDouble(reader["saldo"]);
            jugador.PosicionActual = Convert.ToInt32(reader["posicionActual"]);

            var historico = new HistoricoPartidas();
            historico.Idpartida = Convert.ToInt32(reader["idpartida"]);
            historico.NombrePartida = Convert.ToString(reader["nombrepartida"]);
            historico.Fecha = Convert.ToDateTime(reader["fecha"]);
            historico.Ganador = Convert.ToInt32(reader["ganador"]);
            historico.Jugador = jugador;


            return historico;
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
        public int InsertarPropiedad(Propiedad propiedad)
        {
            String q = string.Format("INSERT INTO Propiedad (nombre,valorCompra,valorPeaje,propietario) values ('{0}','{1}',{2},'{3}')",
                                     propiedad.Nombre, propiedad.ValorCompra, propiedad.ValorPeaje);
            return ExecuteScalar(q);
        }


        public int InsertarPartida(Partida partida)
        {
            var fecha = partida.Fecha.ToString("yyyy-MM-dd HH:mm:ss");
            String q = string.Format("INSERT INTO Partida (nombrepartida,ganador,fecha) values ('{0}',{1},'{2}')",
                                     partida.Nombre, partida.Ganador,fecha );

            var result = ExecuteQuery(q);
            if (result == "0")
                return UltimoRegistroId("idpartida", "partida");
            return -1;
        }

        public int RegistrarPropiedad(int idPropiedad, int idPartida, int idPropietario)
        {
            String q = string.Format("INSERT INTO RegistroPropiedad (idjugador,idpropiedad,idpartida) values ('{0}',{1},'{2}')",
                                   idPropietario, idPropiedad, idPartida);
            return  int.Parse(ExecuteQuery(q));
            
        }

        public int UltimoRegistroId(string campo, string tabla) {
            String q = string.Format("Select {0} from {1} order by {0} desc Limit 1", campo, tabla);
            return ExecuteScalar(q);
        }

        public int GuardarHistorialPartida(int idPartida,int idJugador,double saldo,int posicion,string color)
        {
            String q = string.Format("INSERT INTO HistoricoPartida (idpartida,idjugador,puntuacion,posicionActual,color) values ({0},{1},{2},{3},'{4}')",
                idPartida, idJugador, saldo, posicion, color);
            return int.Parse(ExecuteQuery(q));

        }



        public List<HistoricoPropiedades> ObtenerHistoricoPropiedades(int idpartida)
        {

            var historico = new List<HistoricoPropiedades>();
            try
            {
                openCon();
                string query = string.Format("SELECT p.idpartida, p.idjugador, p.idpropiedad from registropropiedad p where idpartida = {0}", idpartida);
                comando = new MySqlCommand(query, conexion);
                
                var reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    historico.Add(ConvertirHistoricoProp(reader));
                }

                return historico;

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

        public HistoricoPropiedades ConvertirHistoricoProp(IDataReader reader)
        {
            var historico = new HistoricoPropiedades();
            historico.Idpartida = Convert.ToInt32(reader["idpartida"]);
            historico.Idjugador = Convert.ToInt32(reader["idjugador"]);
            historico.Idpropiedad = Convert.ToInt32(reader["Idpropiedad"]);
            return historico;
        }





    }
}




        



