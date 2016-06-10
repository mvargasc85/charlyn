/*
 * Created by SharpDevelop.
 * User: Charlyn Avila
 * Date: 07/05/2016
 * Time: 09:40 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using MonopolyCR.Datos;
using System.Data;

namespace MonopolyCR
{
	/// <summary>
	/// Description of Juego.
	/// </summary>
	public class Juego
	{
		public Jugador jugador { get; set; }
		public Propiedad propiedad { get; set; }
		private Conexion conexion;
		
		public Juego()
		{
			conexion = new Conexion();
		}
		
		
		public String CrearNuevoJugador(String nombre){
			jugador = new Jugador(nombre);
			var result = RegistrarJugador(jugador);
			return result;	
			
		}
		public String CrearNuevaPropiedad(){
			propiedad = new Propiedad();
			var result = RegistrarPropiedad(propiedad);
			return result;
			
		
		}
        public String RegistrarPropiedad(Propiedad propiedad)
        {
            try
            {
                var result = conexion.InsertarPropiedad(propiedad);
                if (result > -1)
                    return "Propiedad registrado con exito";
                else
                    return "Error al registrar la propiedad";
            }
            catch (Exception e)
            {
                return "Error al registrar la propiedad";
            }

        }
		
		public String RegistrarJugador(Jugador jugador){
			try{
			var result = conexion.InsertarJugador(jugador);
			if(result=="0")
				return "Jugador registrado con exito";
			else if (result =="-1") {
				return "Error al registrar al jugador";
			}
			else
				return "Error al registrar al jugador. Detalle: " + result;
			}catch (Exception e){
				return "Error al registrar al jugador";
			}
			
		}
		
		public List<Jugador> CargarJugadoresCbx(){
			return conexion.ObtenerJugadores();
		
		}
		
		public List<HistoricoPartidas> CargarHistorialList(){
			return conexion.ObtenerHistorial();
		}

        public List<HistoricoPropiedades> CargarHistoricoPropiedades(int idpartida)
        {
            return conexion.ObtenerHistoricoPropiedades(idpartida);
        }


        public Jugador ObtenerJugador(int jugadorId)
        {
            return conexion.ObtenerJugador(jugadorId);
        }

        public void GuardarPartida(Partida partida)
        {
            conexion.InsertarPartida(partida);
        }

        public void GuardarPartida(Partida partidaActual, List<Propiedad> propiedades)
        {
            // guardar partida
            var idpartida = conexion.InsertarPartida(partidaActual);

            //guardar propiedades
            if (idpartida > -1)
                foreach (var prop in propiedades)
                {
                    conexion.RegistrarPropiedad(prop.IdPropiedad, idpartida, prop.IdPropietario);
                }

            //guardar informacion historica para su recuperacion
            var jug1 = partidaActual.Jugador1;
            var jug2 = partidaActual.Jugador2;
            conexion.GuardarHistorialPartida(idpartida, jug1.IdJugador, jug1.Saldo, jug1.PosicionActual);
            conexion.GuardarHistorialPartida(idpartida, jug2.IdJugador, jug2.Saldo, jug2.PosicionActual);
        }
    }
}
