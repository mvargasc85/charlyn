/*
 * Creado por SharpDevelop.
 * Usuario: Charlyn Avila
 * Fecha: 22/05/2016
 * Hora: 11:59 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MonopolyCR.UI
{
	/// <summary>
	/// Description of HistorialFrm.
	/// </summary>
	public partial class HistorialFrm : Form
	{
		
		Juego juego;
		List<Partida> partidas;
		
		
		public HistorialFrm()
		{
			
			InitializeComponent();
			juego = new Juego();
			CargarPartidas();
		}
		
		private void CargarPartidas(){
			partidas = juego.CargarHistorialList();
			
			foreach (var partida in partidas) {
				
				var item= listView1.Items.Add(partida.Nombre);
				item.SubItems.Add(partida.Fecha.ToString());
				item.SubItems.Add(partida.Puntuacion.ToString());
				item.SubItems.Add(partida.Ganador.ToString());
			}
		
		}
		void Button1Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
