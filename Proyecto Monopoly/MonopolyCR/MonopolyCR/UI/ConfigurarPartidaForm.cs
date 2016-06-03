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
        public Partida PartidaActual { get; set; }


        public ConfigurarPartidaForm()
        {

            InitializeComponent();

            juego = new Juego();
            CargarJugadoresCbx();
        }

        private void CargarJugadoresCbx()
        {

            jugadores = juego.CargarJugadoresCbx();

            Jugador1Cbx.DisplayMember = "Nombre";
            Jugador1Cbx.ValueMember = "IdJugador";
            Jugador1Cbx.DataSource = jugadores;

            var jugadores2 = new List<Jugador>();
            jugadores2.Add(new Jugador { IdJugador = 0, Nombre = "Seleccione..." });

            Jugador2Cbx.DisplayMember = "Nombre";
            Jugador2Cbx.ValueMember = "IdJugador";
            Jugador2Cbx.DataSource = jugadores2;

            Jugador2Cbx.Enabled = false;

        }


        void Jugador1CbxSelectedIndexChanged(object sender, EventArgs e)
        {
            var seleccion = Convert.ToInt32(Jugador1Cbx.SelectedValue);
            if (seleccion == 0) return;
            var jugadores2 = jugadores;
            jugadores2 = jugadores2.Where(x => x.IdJugador != seleccion).ToList();
            Jugador2Cbx.DisplayMember = "Nombre";
            Jugador2Cbx.ValueMember = "IdJugador";
            Jugador2Cbx.DataSource = jugadores2;
            Jugador2Cbx.Enabled = true;

        }
        void LblJugadorClick(object sender, EventArgs e)
        {

        }

        void BtnJugarClick(object sender, EventArgs e)
        {
            ConfigurarPartida();
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
        void NumericUpDown1ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void ConfigurarPartida()
        {
            var jugador1 = (Jugador)Jugador1Cbx.SelectedItem;           
            jugador1.Saldo = (int)montoInicialNud.Value;
            jugador1.Color = ObtenerColorFicha(1);

            var jugador2 = (Jugador)Jugador2Cbx.SelectedItem;
            jugador2.Saldo = (int)montoInicialNud.Value;
            jugador2.Color = ObtenerColorFicha(2);

            PartidaActual = new Partida()
            {
                Nombre = "Partida de prueba",
                Fecha = DateTime.Now,
                Jugador1 = jugador1,
                Jugador2 = jugador2,               
            };

        }

        public string ObtenerColorFicha(int jugador)
        {
            if (jugador == 1)
            {
                if (radioButton1.Checked)
                    return "Azul";
                if (radioButton2.Checked)
                    return "Amarillo";
            }
            else
            {
                if (radioButton3.Checked)
                    return "Rojo";
                if (radioButton4.Checked)
                    return "Verde";
            }
            return "Morado";
        }
    }
}
