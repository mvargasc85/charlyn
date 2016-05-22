/*
 * Created by SharpDevelop.
 * User: Charlyn Avila
 * Date: 07/05/2016
 * Time: 10:47 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MonopolyCR.UI
{
	/// <summary>
	/// Description of RegistroUsuario.
	/// </summary>
	public partial class RegistroJugadorFrm : Form
	{
		Juego juego;
		
		public RegistroJugadorFrm()		
		{
			InitializeComponent();
			juego = new Juego();
			
		}
		void BtnRegistraJugadorClick(object sender, EventArgs e)
		{
			var nombre = txtNombreJugador.Text;
			var color = txtColor.Text;
			var mensaje =	juego.CrearNuevoJugador(nombre,color);
			MessageBox.Show(mensaje);
	
		}
		void BtnCancaleRegJugadorClick(object sender, EventArgs e)
		{
			this.Close();
	
		}
		void RegistroJugadorFrmLoad(object sender, EventArgs e)
		{
	
		}
	}
}
