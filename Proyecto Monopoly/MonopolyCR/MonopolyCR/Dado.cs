/*
 * Created by SharpDevelop.
 * User: Charlyn Avila
 * Date: 08/05/2016
 * Time: 01:48 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MonopolyCR
{
	/// <summary>
	/// Description of Dado.
	/// </summary>
	public class Dado
	{
		public int Dado1 { get; set; }
		public int Dado2 { get; set; }
		public int SumaDados { get; set; }


        public Dado()
        {
        }


        public int LanzarDados(PictureBox dado1pbx, PictureBox dado2pbx)
        {
            var p = new Random();
            Dado1 = p.Next(1, 7);
            Dado2 = p.Next(1, 7);
            //SumaDados=Dado1+Dado2;
            SumaDados = Dado1;
            dado1pbx.Image = CargarImageDado(Dado1);
            dado2pbx.Image = CargarImageDado(Dado2);
            return SumaDados;
        }
		
		
		public static Image CargarImageDado(int dado )
        {
            switch (dado)
            {
                case 1:
            		return Recursos.dado1;
            	case 2:
            		return Recursos.dado2;
                case 3:
            		return Recursos.dado3;
                case 4:
            		return Recursos.dado4;                
                case 5:
            		return Recursos.dado5;                  
                   default:
            		return Recursos.dado6;                  
            }
		}

        


        
    }
}
