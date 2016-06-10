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
using System.Linq;

namespace MonopolyCR.UI
{
    /// <summary>
    /// Description of HistorialFrm.
    /// </summary>
    public partial class HistorialFrm : Form
    {

        Juego juego;
        List<HistoricoPartidas> historico;
        int partidaSeleccionada;
        public Partida PartidaGuardada { get; set; }

        public HistorialFrm()
        {

            InitializeComponent();
            juego = new Juego();
            CargarPartidas();
        }

        private void CargarPartidas()
        {
            historico = juego.CargarHistorialList();

            foreach (var h in historico)
            {

                var item = listView1.Items.Add(h.Idpartida.ToString());
                item.SubItems.Add(h.NombrePartida.ToString());
                item.SubItems.Add(h.Fecha.ToString());
                item.SubItems.Add(h.Jugador.IdJugador.ToString());
                item.SubItems.Add(h.Jugador.Nombre);
                item.SubItems.Add(h.Jugador.NombreColor);
                item.SubItems.Add(h.Jugador.Saldo.ToString());
                item.SubItems.Add(h.Jugador.PosicionActual.ToString());
                item.SubItems.Add(h.Ganador.ToString());
            }

        }




        void Button1Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            partidaSeleccionada = Convert.ToInt32(listView1.FocusedItem.Text);
        }

        private void cargarpartidabtn_Click(object sender, EventArgs e)
        {
            var partidas = historico.Where(h => h.Idpartida == partidaSeleccionada).ToList();
            var propiedades = juego.CargarHistoricoPropiedades(partidas[0].Idpartida);
            var partida = new Partida();
            partida.Idpartida = partidas[0].Idpartida;
            partida.Nombre = partidas[0].NombrePartida;
            partida.Fecha = partidas[0].Fecha;
            var jug1 = partidas[0].Jugador;
            var jug2 = partidas[1].Jugador;                    
            
            partida.Jugador1 = CargarColores(jug1);
            partida.Jugador2 = CargarColores(jug2);
            partida.HistoricoPropiedades = propiedades;

            PartidaGuardada = partida;

            this.DialogResult = DialogResult.OK;
            Hide();
        }

        public Jugador CargarColores(Jugador jugador)
        {
            if (jugador.NombreColor == "Azul")
            {
                jugador.Color = Color.Blue;
                jugador.ImagenFicha = Recursos.fichaAzul;
            }
            if (jugador.NombreColor == "Naranja")
            {
                jugador.Color = Color.Orange;
                jugador.ImagenFicha = Recursos.fichaNaranja;
            }
            if (jugador.NombreColor == "Verde")
            {
                jugador.Color = Color.LimeGreen;
                jugador.ImagenFicha = Recursos.fichaVerde;
            }
            if (jugador.NombreColor == "Rojo")
            {
                jugador.Color = Color.Red;
                jugador.ImagenFicha = Recursos.fichaRoja;
            }
            if (jugador.NombreColor == "Morado")
            {
                jugador.Color = Color.Purple;
                jugador.ImagenFicha = Recursos.fichaMorada;
            }
            else
            {
                jugador.Color = Color.Turquoise;
                jugador.ImagenFicha = Recursos.fichaTurqueza;
            }

            return jugador;
            
        }
    }
}

