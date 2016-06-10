/*
 * Created by SharpDevelop.
 * User: Charlyn Avila
 * Date: 07/05/2016
 * Time: 09:02 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;

namespace MonopolyCR
{
    /// <summary>
    /// Description of Jugador.
    /// </summary>
    public class Jugador
    {
        public int IdJugador { get; set; }
        public String Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public int Puntuacion { get; set; }
        public String NombreColor { get; set; }
        public int PosicionActual { get; set; }
        public double Saldo { get; set; }
        public Color Color { get; set; }
        public Image ImagenFicha { get; set; }



        public Jugador()
        {

        }

        public Jugador(String nombre)
        {
            Nombre = nombre;

        }


    }
}
