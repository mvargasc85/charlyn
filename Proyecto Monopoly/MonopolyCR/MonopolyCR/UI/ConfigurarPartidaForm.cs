/*
 * Creado por SharpDevelop.
 * Usuario: Charlyn Avila
 * Fecha: 21/05/2016
 * Hora: 12:54 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MonopolyCR.UI
{
	/// <summary>
	/// Description of ConfigurarPartidaForm.
	/// </summary>
	public partial class ConfigurarPartidaForm : Form
	{
		Juego juego;
		List<Jugador> jugadores;
		
		public ConfigurarPartidaForm()
		{
			
			InitializeComponent();
			
			juego = new Juego();
			CargarJugadoresCbx();
		}
		
		private void CargarJugadoresCbx(){
			
			jugadores = juego.CargarJugadoresCbx ();
						
			Jugador1Cbx.DisplayMember= "Nombre";
			Jugador1Cbx.ValueMember = "IdJugador";
			Jugador1Cbx.DataSource = jugadores;
					
		}
		
		
		
		private void CargarJugador2Cbx(){
		
			
//			Jugador2Cbx.DisplayMember= "Nombre";
//			Jugador2Cbx.ValueMember = "IdJugador";
//			Jugador2Cbx.DataSource = dataSource2;
		}
		
		
		void Jugador1CbxSelectedIndexChanged(object sender, EventArgs e)
		{
			var seleccion = Convert.ToInt32(Jugador1Cbx.SelectedValue);
			var jugadores2 = jugadores;
			jugadores2 = jugadores2.Where(x=>x.IdJugador != seleccion).ToList();
			Jugador2Cbx.DisplayMember= "Nombre";
			Jugador2Cbx.ValueMember = "IdJugador";
			Jugador2Cbx.DataSource = jugadores2;
	
		}
		void LblJugadorClick(object sender, EventArgs e)
		{
	
		}
		void ConfigurarPartidaFormLoad(object sender, EventArgs e)
		{
	
		}
		void BtnJugarClick(object sender, EventArgs e)
		{
	
		}
		void NumericUpDown1ValueChanged(object sender, EventArgs e)
		{
	
		}
		
	}
}
