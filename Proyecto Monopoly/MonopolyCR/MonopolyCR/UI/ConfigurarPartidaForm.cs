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
        List<ColorFicha> colores;

        // estructura para cargar valores de los combos de colores
        public class ColorFicha
        {
            public int Id { get; set; }
            public string Texto { get; set; }
            public Color NombreColor { get; set; }
            public Image ImagenFicha { get; set; }
        }


        public ConfigurarPartidaForm()
        {

            InitializeComponent();

            juego = new Juego();
            CargarJugadoresCbx();

            colores = new List<ColorFicha>();
            colores.Add(new ColorFicha { Id = -1, Texto = "Seleccione..." });
            colores.Add(new ColorFicha { Id = 1, Texto = "Azul", NombreColor = Color.Blue, ImagenFicha = Recursos.fichaAzul });
            colores.Add(new ColorFicha { Id = 2, Texto = "Naranja", NombreColor = Color.Orange, ImagenFicha = Recursos.fichaNaranja });
            colores.Add(new ColorFicha { Id = 3, Texto = "Verde", NombreColor = Color.LimeGreen, ImagenFicha = Recursos.fichaVerde });
            colores.Add(new ColorFicha { Id = 4, Texto = "Rojo", NombreColor = Color.Red, ImagenFicha = Recursos.fichaRoja });
            colores.Add(new ColorFicha { Id = 5, Texto = "Morado", NombreColor = Color.Purple, ImagenFicha = Recursos.fichaMorada });
            colores.Add(new ColorFicha { Id = 6, Texto = "Turqueza", NombreColor = Color.Turquoise, ImagenFicha = Recursos.fichaTurqueza });

            CargarColoresCbx();
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

        private void CargarColoresCbx()
        {
            colorJug1cbx.DisplayMember = "Texto";
            colorJug1cbx.ValueMember = "Id";
            colorJug1cbx.DataSource = colores;

            var colores2 = new List<ColorFicha>();
            colores2.Add(new ColorFicha { Id = 0, Texto = "Seleccione..." });

            colorjug2cbx.DisplayMember = "Texto";
            colorjug2cbx.ValueMember = "Id";
            colorjug2cbx.DataSource = colores2;

            colorjug2cbx.Enabled = false;
        }


        private void colorJug1cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seleccion = Convert.ToInt32(colorJug1cbx.SelectedValue);
            if (seleccion == 0) return;
            var colores2 = colores;
            colores2 = colores2.Where(x => x.Id != seleccion).ToList();
            colorjug2cbx.DisplayMember = "Texto";
            colorjug2cbx.ValueMember = "Id";
            colorjug2cbx.DataSource = colores2;
            colorjug2cbx.Enabled = true;
        }



        void LblJugadorClick(object sender, EventArgs e)
        {

        }

        void BtnJugarClick(object sender, EventArgs e)
        {
            ConfigurarPartida();
            if (PartidaActual.Jugador1.IdJugador == 0 || PartidaActual.Jugador2.IdJugador == 0 || PartidaActual.Jugador1.NombreColor == "Seleccione..." || PartidaActual.Jugador2.NombreColor == "Seleccione...")
                MessageBox.Show("Debe seleccionar Nombre y Color de ficha para cada jugador");
            else
            {
                this.DialogResult = DialogResult.OK;
                Hide();
            }
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
            var colorJug1 = (ColorFicha)colorJug1cbx.SelectedItem;
            var jugador1 = (Jugador)Jugador1Cbx.SelectedItem;
            jugador1.Saldo = (int)montoInicialNud.Value;
            jugador1.Color = colorJug1.NombreColor;
            jugador1.NombreColor = colorJug1.Texto;
            jugador1.ImagenFicha = colorJug1.ImagenFicha;

            var colorJug2 = (ColorFicha)colorjug2cbx.SelectedItem;
            var jugador2 = (Jugador)Jugador2Cbx.SelectedItem;
            jugador2.Saldo = (int)montoInicialNud.Value;
            jugador2.Color = colorJug2.NombreColor;
            jugador2.NombreColor = colorJug2.Texto;
            jugador2.ImagenFicha = colorJug2.ImagenFicha;

            PartidaActual = new Partida()
            {
                Nombre = "Partida de prueba",
                Fecha = DateTime.Now,
                Jugador1 = jugador1,
                Jugador2 = jugador2,
            };

        }
    }
}
