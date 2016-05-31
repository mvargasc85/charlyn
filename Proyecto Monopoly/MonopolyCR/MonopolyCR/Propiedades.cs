/*
 * Creado por SharpDevelop.
 * Usuario: Charlyn Avila
 * Fecha: 27/05/2016
 * Hora: 07:50 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace MonopolyCR
{
	/// <summary>
	/// Description of Propiedades.
	/// </summary>
	public class Propiedades
	{
		public int idpropiedad { get; set; }
		public string nombre { get; set; }		
		public float valorCompra { get; set; }
		public float valorPeaje { get; set; }
		public int propietario { get; set; }
		
		
		public Propiedades()
		{
						
		}
		public Propiedades(String Nombre){
			nombre = Nombre;
			
		}
	}
}
