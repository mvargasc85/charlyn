/*
 * Created by SharpDevelop.
 * User: Charlyn Avila
 * Date: 07/05/2016
 * Time: 09:25 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MonopolyCR.UI
{
	/// <summary>
	/// Description of MonopolyCRFrm.
	/// </summary>
	public partial class MonopolyCRFrm : Form
	{
		Juego juego;
		Dado dado;
		
		public MonopolyCRFrm()
		{
			
			juego = new Juego();
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MonopolyCRFrmLoad(object sender, EventArgs e)
		{
	
		}
		
		void TerminarJuegoToolStripMenuItemClick(object sender, EventArgs e)
		{
	
		}
		void NuevoJugadorToolStripMenuItemClick(object sender, EventArgs e)
		{
			var registroJugadorFrm = new RegistroJugadorFrm();
			
			registroJugadorFrm.Show();
						
		}
		void Panel2Paint(object sender, PaintEventArgs e)
		{
	
		}
		void Panel1Paint(object sender, PaintEventArgs e)
		{
	
		}
		void Panel36Paint(object sender, PaintEventArgs e)
		{
	
		}
		void MenuStrip1ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
	
		}
		void Dado2PbxClick(object sender, EventArgs e)
		{
	
		}
		void LanzarDadosBtnClick(object sender, EventArgs e)
		{
			dado=new Dado();
			dado.LanzarDados(dado1Pbx,dado2Pbx);			
		
			var posiciones = dado.SumaDados;
			avanzaPosicionLbl.Text = String.Format("Jugador {0} ¡Avanza {1} posiones!","Charlyn",posiciones);
	
		}
		void Panel4Paint(object sender, PaintEventArgs e)
		{
	
		}
		void Label3Click(object sender, EventArgs e)
		{
	
		}
		void Panel8Paint(object sender, PaintEventArgs e)
		{
	
		}
		void AcerdaDeToolStripMenuItemClick(object sender, EventArgs e)
		{
			var acercadefrm = new AcercadeFrm();
			acercadefrm.Show();
			
			
		}
	}
}
