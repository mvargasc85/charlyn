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
using System.Threading;

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
        public  Partida partidaActual;
        int jugadorEnTurno = 0;
        Panel panelFinal;
        Propiedad propiedadActual;
       

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

        private static void PlaySimpleSound(System.IO.UnmanagedMemoryStream sonido)
        {
            var simpleSound = new SoundPlayer(sonido);
            simpleSound.Play();
        }

        void NuevaPartidaToolStripMenuItemClick(object sender, EventArgs e)
        {

        }
        void ConfiguraciónToolStripMenuItemClick(object sender, EventArgs e)
        {
            var configurarPartidafrm = new ConfigurarPartidaForm();
          
            configurarPartidafrm.ShowDialog();
                       
            if (configurarPartidafrm.DialogResult == DialogResult.OK)
            {
                partidaActual = configurarPartidafrm.PartidaActual;
                DefinirTurnoInicial();
                
            }
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

             
        public void MoverFicha() {
                   
            var ficha = jugadorEnTurno == 2 ? ficha1Pbx : ficha2Pbx;
            var posicion = ObtenerPosicionActual();
            var sumaDados = dado.SumaDados;
            if (sumaDados > 2) sumaDados = 2;
            if (posActual < sumaDados)
            {
                PlaySimpleSound(Recursos.sonido_ficha);

                var panelActual = (Panel)propiedades[posicion].MainPanel;

                panelActual.Controls.Remove(ficha);
                var panelSgte = (Panel)propiedades[posicion + 1].MainPanel;
                panelSgte.Controls.Add(ficha);
                ficha.Location = jugadorEnTurno == 1 ? new Point(17, 5) : new Point(4, 33);
                EstablecerPosicionActual(posicion + 1);
                posActual += 1;
            }
            else
            {                               
                var propiedad = propiedades[posicion];
                MostrarFichaPropiedad(propiedad);
                propiedadActual = propiedad;
                timerMueveFicha.Stop();
                posActual = 0;
            } 
            //jugadorEnTurno = jugadorEnTurno == 1 ? 2 : 1;
            //AsignarTurno();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoverFicha();
        }



        public void MostrarFichaPropiedad(Propiedad propiedad)
        {
            nombrePropiedadLbl.Text = propiedad.Nombre;
            precioCasaLbl.Text = string.Format("₡{0}", propiedad.ValorCompra);
            peajeLbl.Text = string.Format("₡{0}", propiedad.ValorPeaje);
            valorHipotecaLbl.Text = string.Format("₡{0}", propiedad.ValorHipoteca);
            imagenCiudadPbx.Image = propiedad.ImagenCiudad;

            fichaPropiedadPnl.Visible = true;
        }

        void Prop32HdrPnlPaint(object sender, PaintEventArgs e)
        {

        }
        void Button1Click(object sender, EventArgs e)
        {
            var ganadorfrm = new GanadorFrm();
            ganadorfrm.Show();
        }

        public void DefinirTurnoInicial()
        {
            var p = new Random();
            jugadorEnTurno = p.Next(1, 2);
            AsignarTurno();
        }

        public int ObtenerPosicionActual()
        {
            return jugadorEnTurno == 1 ? partidaActual.Jugador1.PosicionActual : partidaActual.Jugador2.PosicionActual;
        }

        public void EstablecerPosicionActual(int posicion)
        {
            if (jugadorEnTurno == 1)
                partidaActual.Jugador1.PosicionActual = posicion;
            else
                partidaActual.Jugador2.PosicionActual = posicion;
        }

        
        public void AsignarTurno()
        {  
            jugador1gbx.Text = partidaActual.Jugador1.Nombre; 
            jugador2gbx.Text = partidaActual.Jugador2.Nombre;
            saldoJug1lbl.Text = partidaActual.Jugador1.Saldo.ToString();
            saldoJug2lbl.Text = partidaActual.Jugador2.Saldo.ToString();

            if (jugadorEnTurno == 1)
            {
              
                lanzaJgdr1btn.Enabled = true;
                lanzaJgdr2btn.Enabled = false;
                lanzaJgdr1btn.Visible = true;
                lanzaJgdr2btn.Visible = false;
                
            }
            else
            {               
                lanzaJgdr2btn.Enabled = true;
                lanzaJgdr1btn.Enabled = false;
                lanzaJgdr2btn.Visible = true;
                lanzaJgdr1btn.Visible = false;
            }

          
        }

        private void LanzarDados()
        {
            PlaySimpleSound(Recursos.dados);
            dado = new Dado();
            dado.LanzarDados(dado1Pbx, dado2Pbx);

            var posiciones = dado.SumaDados;
            avanzaPosicionLbl.Text = String.Format("Jugador {0} ¡Avanza {1} posiones!", "Charlyn", posiciones);
            //MoverFicha2();
            timerMueveFicha.Interval = 1000;
            timerMueveFicha.Start();
        }

        private void lanzaJgdr1btn_Click(object sender, EventArgs e)
        {
            LanzarDados();
        }

        private void lanzaJgdr2btn_Click(object sender, EventArgs e)
        {
            LanzarDados();
        }

        private void comprarBtn_Click(object sender, EventArgs e)
        {

            if (jugadorEnTurno == 1)
                ComprarPropiedad(partidaActual.Jugador1);
            else
                ComprarPropiedad(partidaActual.Jugador2);

        }

        public void ComprarPropiedad(Jugador jugador)
        {
            var precioProp = propiedadActual.ValorCompra;
            if (precioProp <= jugador.Saldo)
            {
                PlaySimpleSound(Recursos.compra_propiedad);
                jugador.Saldo -= precioProp;
                operacioneslbl.Text = string.Format("₡{0}", precioProp);
                operacioneslbl.ForeColor = Color.Red;
                
               
                if (jugadorEnTurno == 1) saldoJug1lbl.Text = string.Format("₡{0}", jugador.Saldo);
                else saldoJug1lbl.Text = string.Format("₡{0}", jugador.Saldo);
                var panel = propiedadActual.MainPanel as Panel;
                panel.BackColor = jugadorEnTurno == 1 ? Color.Orange : Color.LimeGreen;
                operacioneslbl.Visible = true;                
              
            }
            operacioneslbl.Visible = false;
            fichaPropiedadPnl.Visible = false;
            jugadorEnTurno = jugadorEnTurno == 1 ? 2 : 1;
            AsignarTurno();
        }

    




       




    }
}
