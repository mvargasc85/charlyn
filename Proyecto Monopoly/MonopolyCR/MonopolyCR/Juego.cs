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
		
		public List<Partida> CargarHistorialList(){
			return conexion.ObtenerHistorial();
		}
	}
}
