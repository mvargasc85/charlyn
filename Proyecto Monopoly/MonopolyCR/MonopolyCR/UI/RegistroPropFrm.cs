/*
 * Creado por SharpDevelop.
 * Usuario: Charlyn Avila
 * Fecha: 27/05/2016
 * Hora: 08:52 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MonopolyCR.UI
{
	/// <summary>
	/// Description of RegistroPropFrm.
	/// </summary>
	public partial class RegistroPropFrm : Form
	{
		
//		Juego juego();
		
		public RegistroPropFrm()
		{
			
			InitializeComponent();
//			juego = new Juego();
			
			
		}
		void RegistroPropFrmLoad(object sender, EventArgs e)
		{
	
		}
		void BtnRegistrarClick(object sender, EventArgs e)
		{
			var nombre = txtNombreProp.Text;
			var valorPeaje = txtValorPeajeProp.Text;
			var valorCompra = txtValorCompProp.Text;
			var propietario = txtPropietarioProp.Text;
//			var mensaje = juego.CrearNuevaPropiedad;
//			MessageBox.Show(mensaje);
		}
	}
}
