﻿/*
 * Creado por SharpDevelop.
 * Usuario: Charlyn Avila
 * Fecha: 22/05/2016
 * Hora: 01:03 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace MonopolyCR
{
	/// <summary>
	/// Description of Partida.
	/// </summary>
	public class Partida
	{
		public int Idjugador { get; set; }
		public int Idpartida{get; set; }
		public String Nombre { get; set; }
		public DateTime Fecha { get; set; }
		public int Puntuacion  { get; set; }
		public	int Ganador { get; set; } 


		public Partida()
		{
		
		}
		
		
		
	}
}