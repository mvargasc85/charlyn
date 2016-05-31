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
using System.Media;
using System.Collections.Generic;
using Microsoft.DirectX;
using Microsoft.DirectX.DirectSound;

namespace MonopolyCR.UI
{
    /// <summary>
    /// Description of MonopolyCRFrm.
    /// </summary>
    public partial class MonopolyCRFrm : Form
    {
        Juego juego;
        Dado dado;
        List<Propiedad> propiedades;
        int posActual = 0;
        private Device dSound;

        private SecondaryBuffer sound;
        private BufferDescription d;

       

        public MonopolyCRFrm()
        {
            juego = new Juego();
            InitializeComponent();
            CargarPropiedades();
           
        }

        public void CargarPropiedades()
        {
            propiedades = new List<Propiedad>();
            propiedades.Add(new Propiedad { IdPropiedad = 0, Nombre = "Parqueo", ValorCompra = 1000, ValorPeaje = 0, ValorHipoteca = 1000, MainPanel = prop0MainPnl, HeaderPanel = null,ImagenCiudad=null });
            propiedades.Add(new Propiedad { IdPropiedad = 1, Nombre = "San Jose", ValorCompra = 2000, ValorPeaje = 200, ValorHipoteca = 2000, MainPanel = prop1MainPnl, HeaderPanel = prop1HdrPnl, ImagenCiudad = Recursos.sanJose });
            propiedades.Add(new Propiedad { IdPropiedad = 2, Nombre = "Alajuela", ValorCompra = 3000, ValorPeaje = 300, ValorHipoteca = 3000, MainPanel = prop2MainPnl, HeaderPanel = prop2HdrPnl, ImagenCiudad = Recursos.alajuela });
            propiedades.Add(new Propiedad { IdPropiedad = 3, Nombre = "Heredia", ValorCompra = 4000, ValorPeaje = 400, ValorHipoteca = 4000, MainPanel = prop3MainPnl, HeaderPanel = prop3HdrPnl, ImagenCiudad = Recursos.heredia});
            propiedades.Add(new Propiedad { IdPropiedad = 4, Nombre = "Cartago", ValorCompra = 5000, ValorPeaje = 500, ValorHipoteca = 5000, MainPanel = prop4MainPnl, HeaderPanel = prop4HdrPnl, ImagenCiudad = Recursos.cartago});
            propiedades.Add(new Propiedad { IdPropiedad = 5, Nombre = "Guanacaste", ValorCompra = 6000, ValorPeaje = 600, ValorHipoteca = 6000, MainPanel = prop5MainPnl, HeaderPanel = prop5HdrPnl, ImagenCiudad = Recursos.guanacasteLiberia });
            propiedades.Add(new Propiedad { IdPropiedad = 6, Nombre = "Puntarenas", ValorCompra = 7000, ValorPeaje = 700, ValorHipoteca = 7000, MainPanel = prop6MainPnl, HeaderPanel = prop6HdrPnl, ImagenCiudad = Recursos.puntarenas });
            propiedades.Add(new Propiedad { IdPropiedad = 7, Nombre = "Limon", ValorCompra = 8000, ValorPeaje = 800, ValorHipoteca = 8000, MainPanel = prop7MainPnl, HeaderPanel = prop7HdrPnl, ImagenCiudad = Recursos.limonRuta });
            propiedades.Add(new Propiedad { IdPropiedad = 8, Nombre = "Guapiles", ValorCompra = 9000, ValorPeaje = 900, ValorHipoteca = 9000, MainPanel = prop8MainPnl, HeaderPanel = prop8HdrPnl, ImagenCiudad = Recursos.limonTortuguero });
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
            playSimpleSound(Recursos.dados);
            //d = new BufferDescription();
            //dSound = new Device();
            //dSound.SetCooperativeLevel(this.Handle, CooperativeLevel.Normal);
            //// Set descriptor’s flags
            //d.ControlPan = true;
            //d.ControlVolume = true;
            //d.ControlFrequency = true;
            //d.ControlEffects = true;
            //sound = new SecondaryBuffer(Recursos.dados, d, dSound);

            //sound.Play(0, BufferPlayFlags.Default);

            dado = new Dado();
            dado.LanzarDados(dado1Pbx, dado2Pbx);

            var posiciones = dado.SumaDados;
            avanzaPosicionLbl.Text = String.Format("Jugador {0} ¡Avanza {1} posiones!", "Charlyn", posiciones);
            MoverFicha2();

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

        private void playSimpleSound(System.IO.UnmanagedMemoryStream sonido)
        {
            SoundPlayer simpleSound = new SoundPlayer(sonido);
            simpleSound.Play();
        }

        void NuevaPartidaToolStripMenuItemClick(object sender, EventArgs e)
        {

        }
        void ConfiguraciónToolStripMenuItemClick(object sender, EventArgs e)
        {
            var configurarPartidafrm = new ConfigurarPartidaForm();
            configurarPartidafrm.Show();
        }
        void SalirToolStripMenuItemClick(object sender, EventArgs e)
        {
            this.Close();
        }
        void HistorialJugadoresToolStripMenuItemClick(object sender, EventArgs e)
        {
            var historialfrm = new HistorialFrm();
            historialfrm.Show();
        }

        public void MoverFicha2()
        {
            playSimpleSound(Recursos.sonido_ficha);

            int sumaDados = dado.SumaDados;
            if (sumaDados > 2) sumaDados = 2;
            for (int i = 0; i < sumaDados; i++)
            {
                var panelActual = (Panel)propiedades[posActual].MainPanel;
                var ficha = ficha1Pbx;
                panelActual.Controls.Remove(ficha1Pbx);
                var panelSgte = (Panel)propiedades[posActual + 1].MainPanel;
                panelSgte.Controls.Add(ficha1Pbx);
                posActual = posActual + 1;
            }

            var propiedad = propiedades[posActual];
            MostrarFichaPropiedad(propiedad);
        }

        public void MostrarFichaPropiedad(Propiedad propiedad)
        {
            nombrePropiedadLbl.Text = propiedad.Nombre;
            precioCasaLbl.Text = propiedad.ValorCompra.ToString();
            peajeLbl.Text = propiedad.ValorPeaje.ToString();
            valorHipotecaLbl.Text = propiedad.ValorHipoteca.ToString();
            imagenCiudadPbx.Image = propiedad.ImagenCiudad;

            fichaPropiedadPnl.Visible = true;
        }

        void Prop32HdrPnlPaint(object sender, PaintEventArgs e)
        {

        }
        void Button1Click(object sender, EventArgs e)
        {
            var Ganadorfrm = new GanadorFrm();

            Ganadorfrm.Show();

        }


    }
}
