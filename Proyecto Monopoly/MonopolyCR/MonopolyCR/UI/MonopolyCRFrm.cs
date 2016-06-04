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
using System.Linq;

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
        public Partida partidaActual;
        int jugadorEnTurno = 0;
        Propiedad propiedadActual;
        private System.Windows.Forms.Timer timerLanzaDados, timerOperaciones;
        int giros;

        enum Movimiento
        {
            Compra,
            Peaje,
            Retribucion,
            Penalizacion
        }

        
        public MonopolyCRFrm(Partida partida)
        {
            this.partidaActual = partida;
            juego = new Juego();
            InitializeComponent();
            CargarPropiedades();
            DefinirTurnoInicial();
        }

        //public void CargarPropiedades()
        //{
        //    propiedades = new List<Propiedad>();
        //    propiedades.Add(new Propiedad { IdPropiedad = 0, Nombre = "Parqueo", ValorCompra = 1000, ValorPeaje = 0, ValorHipoteca = 1000, MainPanel = prop0MainPnl, HeaderPanel = null, ImagenCiudad = null });
        //    propiedades.Add(new Propiedad { IdPropiedad = 1, Nombre = "San Jose", ValorCompra = 2000, ValorPeaje = 200, ValorHipoteca = 2000, MainPanel = prop1MainPnl, HeaderPanel = prop1HdrPnl, ImagenCiudad = Recursos.sanJose });
        //    propiedades.Add(new Propiedad { IdPropiedad = 2, Nombre = "Alajuela", ValorCompra = 3000, ValorPeaje = 300, ValorHipoteca = 3000, MainPanel = prop2MainPnl, HeaderPanel = prop2HdrPnl, ImagenCiudad = Recursos.alajuela });
        //    propiedades.Add(new Propiedad { IdPropiedad = 3, Nombre = "Heredia", ValorCompra = 4000, ValorPeaje = 400, ValorHipoteca = 4000, MainPanel = prop3MainPnl, HeaderPanel = prop3HdrPnl, ImagenCiudad = Recursos.heredia });
        //    propiedades.Add(new Propiedad { IdPropiedad = 4, Nombre = "Cartago", ValorCompra = 5000, ValorPeaje = 500, ValorHipoteca = 5000, MainPanel = prop4MainPnl, HeaderPanel = prop4HdrPnl, ImagenCiudad = Recursos.cartago });
        //    propiedades.Add(new Propiedad { IdPropiedad = 5, Nombre = "Guanacaste", ValorCompra = 6000, ValorPeaje = 600, ValorHipoteca = 6000, MainPanel = prop5MainPnl, HeaderPanel = prop5HdrPnl, ImagenCiudad = Recursos.guanacasteLiberia });
        //    propiedades.Add(new Propiedad { IdPropiedad = 6, Nombre = "Puntarenas", ValorCompra = 7000, ValorPeaje = 700, ValorHipoteca = 7000, MainPanel = prop6MainPnl, HeaderPanel = prop6HdrPnl, ImagenCiudad = Recursos.puntarenas });
        //    propiedades.Add(new Propiedad { IdPropiedad = 7, Nombre = "Limon", ValorCompra = 8000, ValorPeaje = 800, ValorHipoteca = 8000, MainPanel = prop7MainPnl, HeaderPanel = prop7HdrPnl, ImagenCiudad = Recursos.limonRuta });
        //    propiedades.Add(new Propiedad { IdPropiedad = 8, Nombre = "Guapiles", ValorCompra = 9000, ValorPeaje = 900, ValorHipoteca = 9000, MainPanel = prop8MainPnl, HeaderPanel = prop8HdrPnl, ImagenCiudad = Recursos.limonTortuguero });
        //}


        public void CargarPropiedades()
        {
            propiedades = new List<Propiedad>();
            propiedades.Add(new Propiedad { IdPropiedad = 0, Nombre = "Salida", ValorCompra = 0, ValorPeaje = 0, ValorHipoteca = 0, MainPanel = prop0MainPnl, HeaderPanel = null, ImagenCiudad = null });
            propiedades.Add(new Propiedad { IdPropiedad = 1, Nombre = "Los Sueños", ValorCompra = 15000, ValorPeaje = 1500, ValorHipoteca = 7500, MainPanel = prop1MainPnl, HeaderPanel = prop1HdrPnl, ImagenCiudad = Recursos.LosSuenosJaco });
            propiedades.Add(new Propiedad { IdPropiedad = 2, Nombre = "Jacó", ValorCompra = 12000, ValorPeaje = 1200, ValorHipoteca = 6000, MainPanel = prop2MainPnl, HeaderPanel = prop2HdrPnl, ImagenCiudad = Recursos.puntarenasJaco });
            propiedades.Add(new Propiedad { IdPropiedad = 3, Nombre = "Puntarenas", ValorCompra = 8000, ValorPeaje = 800, ValorHipoteca = 4000, MainPanel = prop3MainPnl, HeaderPanel = prop3HdrPnl, ImagenCiudad = Recursos.puntarenas });
            propiedades.Add(new Propiedad { IdPropiedad = 4, Nombre = "ICE", ValorCompra = 20000, ValorPeaje = 2000, ValorHipoteca = 10000, MainPanel = prop4MainPnl, HeaderPanel = prop4HdrPnl, ImagenCiudad = Recursos.compIce });
            propiedades.Add(new Propiedad { IdPropiedad = 5, Nombre = "Tortuguero", ValorCompra = 5000, ValorPeaje = 500, ValorHipoteca = 2500, MainPanel = prop5MainPnl, HeaderPanel = prop5HdrPnl, ImagenCiudad = Recursos.limonTortuguero });
            propiedades.Add(new Propiedad { IdPropiedad = 6, Nombre = "Puerto Limón", ValorCompra = 7000, ValorPeaje = 700, ValorHipoteca = 3500, MainPanel = prop6MainPnl, HeaderPanel = prop6HdrPnl, ImagenCiudad = Recursos.puertoLimon });
            propiedades.Add(new Propiedad { IdPropiedad = 7, Nombre = "Braulio Carrillo", ValorCompra = 3500, ValorPeaje = 300, ValorHipoteca = 1700, MainPanel = prop7MainPnl, HeaderPanel = prop7HdrPnl, ImagenCiudad = Recursos.limonRuta });
            propiedades.Add(new Propiedad { IdPropiedad = 8, Nombre = "Aeropuerto Limón", ValorCompra = 4000, ValorPeaje = 400, ValorHipoteca = 2000, MainPanel = prop8MainPnl, HeaderPanel = prop8HdrPnl, ImagenCiudad = Recursos.limonAeropuerto });

            propiedades.Add(new Propiedad { IdPropiedad = 9, Nombre = "Carcel", ValorCompra = 0, ValorPeaje = 0, ValorHipoteca = 0, MainPanel = prop9MainPnl, HeaderPanel = null, ImagenCiudad = null });
            propiedades.Add(new Propiedad { IdPropiedad = 10, Nombre = "San Rafael", ValorCompra = 2000, ValorPeaje = 200, ValorHipoteca = 1000, MainPanel = prop10MainPnl, HeaderPanel = prop10HdrPnl, ImagenCiudad = Recursos.herediaSanRafael });
            propiedades.Add(new Propiedad { IdPropiedad = 11, Nombre = "Belen", ValorCompra = 4000, ValorPeaje = 400, ValorHipoteca = 2000, MainPanel = prop11MainPnl, HeaderPanel = prop11HdrPnl, ImagenCiudad = Recursos.herediaBelen });
            propiedades.Add(new Propiedad { IdPropiedad = 12, Nombre = "Heredia", ValorCompra = 3000, ValorPeaje = 300, ValorHipoteca = 1500, MainPanel = prop12MainPnl, HeaderPanel = prop12HdrPnl, ImagenCiudad = Recursos.heredia });
            propiedades.Add(new Propiedad { IdPropiedad = 13, Nombre = "Intel", ValorCompra = 0, ValorPeaje = 0, ValorHipoteca = 0, MainPanel = prop13MainPnl, HeaderPanel = prop13HdrPnl, ImagenCiudad = Recursos.compIce });
            propiedades.Add(new Propiedad { IdPropiedad = 14, Nombre = "Liberia", ValorCompra = 5000, ValorPeaje = 500, ValorHipoteca = 2500, MainPanel = prop14MainPnl, HeaderPanel = prop14HdrPnl, ImagenCiudad = Recursos.guanacasteLiberia });
            propiedades.Add(new Propiedad { IdPropiedad = 15, Nombre = "Tempisque", ValorCompra = 6000, ValorPeaje = 600, ValorHipoteca = 6000, MainPanel = prop15MainPnl, HeaderPanel = prop15HdrPnl, ImagenCiudad = Recursos.guanacasteTempisque });
            propiedades.Add(new Propiedad { IdPropiedad = 16, Nombre = "Nicoya", ValorCompra = 7000, ValorPeaje = 700, ValorHipoteca = 7000, MainPanel = prop16MainPnl, HeaderPanel = prop16HdrPnl, ImagenCiudad = Recursos.guanacasteNicoya });
            propiedades.Add(new Propiedad { IdPropiedad = 17, Nombre = "Odube", ValorCompra = 2000, ValorPeaje = 200, ValorHipoteca = 2000, MainPanel = prop17MainPnl, HeaderPanel = prop17HdrPnl, ImagenCiudad = Recursos.guanacasteOduber });

            propiedades.Add(new Propiedad { IdPropiedad = 18, Nombre = "Parqueo Libre", ValorCompra = 0, ValorPeaje = 0, ValorHipoteca = 0, MainPanel = prop18MainPnl, HeaderPanel = null, ImagenCiudad = null });
            propiedades.Add(new Propiedad { IdPropiedad = 19, Nombre = "San José", ValorCompra = 2000, ValorPeaje = 200, ValorHipoteca = 1000, MainPanel = prop19MainPnl, HeaderPanel = prop19HdrPnl, ImagenCiudad = Recursos.sanJose });
            propiedades.Add(new Propiedad { IdPropiedad = 20, Nombre = "Santa Ana", ValorCompra = 4000, ValorPeaje = 400, ValorHipoteca = 2000, MainPanel = prop20MainPnl, HeaderPanel = prop20HdrPnl, ImagenCiudad = Recursos.sanJoseSantaAna });
            propiedades.Add(new Propiedad { IdPropiedad = 21, Nombre = "Aeropuerto T. B.", ValorCompra = 9000, ValorPeaje = 900, ValorHipoteca = 4500, MainPanel = prop21MainPnl, HeaderPanel = prop21HdrPnl, ImagenCiudad = Recursos.SanJoseTobias });
            propiedades.Add(new Propiedad { IdPropiedad = 22, Nombre = "Turrialba", ValorCompra = 3000, ValorPeaje = 300, ValorHipoteca = 1500, MainPanel = prop22MainPnl, HeaderPanel = prop22HdrPnl, ImagenCiudad = Recursos.SanJoseTurrialba });
            propiedades.Add(new Propiedad { IdPropiedad = 23, Nombre = "AyA", ValorCompra = 20000, ValorPeaje = 2000, ValorHipoteca = 10000, MainPanel = prop23MainPnl, HeaderPanel = prop23HdrPnl, ImagenCiudad = Recursos.compAyA });
            propiedades.Add(new Propiedad { IdPropiedad = 24, Nombre = "Aeropuerto J.S.M", ValorCompra = 5000, ValorPeaje = 500, ValorHipoteca = 2500, MainPanel = prop24MainPnl, HeaderPanel = prop24HdrPnl, ImagenCiudad = Recursos.alajuelaJuan_santa_maria });
            propiedades.Add(new Propiedad { IdPropiedad = 25, Nombre = "La Guacima", ValorCompra = 6000, ValorPeaje = 600, ValorHipoteca = 3000, MainPanel = prop25MainPnl, HeaderPanel = prop25HdrPnl, ImagenCiudad = Recursos.alajuelaGuacima });
            propiedades.Add(new Propiedad { IdPropiedad = 26, Nombre = "Alajuela", ValorCompra = 7000, ValorPeaje = 700, ValorHipoteca = 3500, MainPanel = prop26MainPnl, HeaderPanel = prop26HdrPnl, ImagenCiudad = Recursos.alajuela });

            propiedades.Add(new Propiedad { IdPropiedad = 27, Nombre = "Carcel", ValorCompra = 0, ValorPeaje = 0, ValorHipoteca = 0, MainPanel = prop27MainPnl, HeaderPanel = null, ImagenCiudad = null });
            propiedades.Add(new Propiedad { IdPropiedad = 28, Nombre = "Grecia", ValorCompra = 7000, ValorPeaje = 700, ValorHipoteca = 3500, MainPanel = prop28MainPnl, HeaderPanel = prop28HdrPnl, ImagenCiudad = Recursos.alajuelaGrecia });
            propiedades.Add(new Propiedad { IdPropiedad = 29, Nombre = "Poás", ValorCompra = 15000, ValorPeaje = 1500, ValorHipoteca = 7500, MainPanel = prop30MainPnl, HeaderPanel = prop29HdrPnl, ImagenCiudad = Recursos.alajuelaPoas });
            propiedades.Add(new Propiedad { IdPropiedad = 30, Nombre = "Cartago", ValorCompra = 4000, ValorPeaje = 400, ValorHipoteca = 2000, MainPanel = prop30MainPnl, HeaderPanel = prop30HdrPnl, ImagenCiudad = Recursos.cartago });
            propiedades.Add(new Propiedad { IdPropiedad = 31, Nombre = "Las Ruinas", ValorCompra = 5000, ValorPeaje = 500, ValorHipoteca = 2500, MainPanel = prop31MainPnl, HeaderPanel = prop31HdrPnl, ImagenCiudad = Recursos.cartagoRuina });
            propiedades.Add(new Propiedad { IdPropiedad = 32, Nombre = "SKY", ValorCompra = 15000, ValorPeaje = 1500, ValorHipoteca = 7500, MainPanel = prop32MainPnl, HeaderPanel = prop32HdrPnl, ImagenCiudad = Recursos.compsky });
            propiedades.Add(new Propiedad { IdPropiedad = 33, Nombre = "El Guarco", ValorCompra = 7000, ValorPeaje = 700, ValorHipoteca = 3500, MainPanel = prop33MainPnl, HeaderPanel = prop30HdrPnl, ImagenCiudad = Recursos.CartagoGuarco });
            propiedades.Add(new Propiedad { IdPropiedad = 34, Nombre = "El Sanatorio", ValorCompra = 10000, ValorPeaje = 1000, ValorHipoteca = 5000, MainPanel = prop34MainPnl, HeaderPanel = prop31HdrPnl, ImagenCiudad = Recursos.cartagoTren });
            propiedades.Add(new Propiedad { IdPropiedad = 35, Nombre = "Orosi", ValorCompra = 12000, ValorPeaje = 1200, ValorHipoteca = 6000, MainPanel = prop35MainPnl, HeaderPanel = prop32HdrPnl, ImagenCiudad = Recursos.cartagoOrosi });

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
                //partidaActual = configurarPartidafrm.PartidaActual;
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


        public void MoverFicha()
        {

            var ficha = jugadorEnTurno == 2 ? ficha1Pbx : ficha2Pbx;
            var posicion = ObtenerPosicionActual();
            var sumaDados = dado.SumaDados;
            //if (sumaDados > 2) sumaDados = 2;
            if (posActual < sumaDados)
            {
                PlaySimpleSound(Recursos.sonido_ficha);

                var panelActual = (Panel)propiedades[posicion].MainPanel;

                panelActual.Controls.Remove(ficha);
                if (posicion + 1 > 35)
                    posicion = -1;
                var panelSgte = (Panel)propiedades[posicion + 1].MainPanel;
                panelSgte.Controls.Add(ficha);
                ficha.Location = jugadorEnTurno == 1 ? new Point(17, 5) : new Point(4, 33);
                EstablecerPosicionActual(posicion + 1);
                posActual += 1;
            }
            else
            {
                timerMueveFicha.Stop();
                var propiedad = propiedades[posicion];
                propiedadActual = propiedad;
                if (propiedadActual.IdPropietario == 0) MostrarFichaPropiedad(propiedad);
                else
                {
                    if (jugadorEnTurno == 1)
                        PagarPeaje(partidaActual.Jugador2, partidaActual.Jugador1);
                    else
                        PagarPeaje(partidaActual.Jugador1, partidaActual.Jugador2);
                }

                posActual = 0;
            }
        }

        private void TimerMueveFicha_Tick(object sender, EventArgs e)
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
        
        //genera un num aleatorio de 1 a 8, si es par inicia el jugador #1 de lo contrario el #2
        public void DefinirTurnoInicial()
        {

            var num = new Random().Next(1, 8);
            jugadorEnTurno = num % 2 == 0 ? 1 : 2;
            avanzaPosicionLbl.Text = String.Format("Inicia {0}!", jugadorEnTurno == 1 ? partidaActual.Jugador1.Nombre : partidaActual.Jugador2.Nombre);
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
            saldoJug1lbl.Text = string.Format("₡{0}", partidaActual.Jugador1.Saldo);
            saldoJug2lbl.Text = string.Format("₡{0}", partidaActual.Jugador2.Saldo);

            if (jugadorEnTurno == 1)
                CederTurno(lanzaJgdr2btn, lanzaJgdr1btn);
            else
                CederTurno(lanzaJgdr1btn, lanzaJgdr2btn);

        }


        public void CederTurno(Button botonActivo, Button botonInactivo)
        {
            botonActivo.Enabled = false;
            botonActivo.Visible = false;
            botonInactivo.Enabled = true;
            botonInactivo.Visible = true;
        }

        private void LanzarDados()
        {
            PlaySimpleSound(Recursos.dados);
            dado = new Dado();
            giros = new Random().Next(3, 7);
            timerLanzaDados = new System.Windows.Forms.Timer();
            timerLanzaDados.Interval = 100;
            timerLanzaDados.Tick += new EventHandler(timerLanzaDados_Tick);
            timerLanzaDados.Start();
        }


        private void timerLanzaDados_Tick(object sender, EventArgs e)
        {
            if (giros > 0)
            {
                dado.LanzarDados(dado1Pbx, dado2Pbx);
                giros--;
            }
            else
            {
                timerLanzaDados.Stop();
                var posiciones = dado.SumaDados;
                avanzaPosicionLbl.Text = String.Format("Jugador {0} ¡Avanza {1} posiones!", jugadorEnTurno == 1 ? partidaActual.Jugador1.Nombre : partidaActual.Jugador2.Nombre, posiciones);
                IniciarMovimiento();
            }
        }



        public void IniciarMovimiento()
        {
            timerMueveFicha.Interval = 500;
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
            if (propiedadActual.IdPropietario == 0)
            {
                if (jugadorEnTurno == 1)
                    ComprarPropiedad(partidaActual.Jugador1);
                else
                    ComprarPropiedad(partidaActual.Jugador2);
            }

        }

        public void ComprarPropiedad(Jugador jugador)
        {

            var precioProp = propiedadActual.ValorCompra;
            if (precioProp <= jugador.Saldo)
            {
                PlaySimpleSound(Recursos.compra_propiedad);
                jugador.Saldo -= precioProp;
                propiedadActual.IdPropietario = jugador.IdJugador;
                avanzaPosicionLbl.Text = String.Format("{0} compra {1} por ₡{2}!", jugador.Nombre, propiedadActual.Nombre, precioProp);
                MostrarMovientoSaldo(precioProp, Color.Red, null, jugadorEnTurno == 1 ? operacionesJug1lbl : operacionesJug2lbl);
                var panel = propiedadActual.MainPanel as Panel;
                panel.BackColor = jugadorEnTurno == 1 ? Color.Orange : Color.LimeGreen;


            }

            fichaPropiedadPnl.Visible = false;
            jugadorEnTurno = jugadorEnTurno == 1 ? 2 : 1;
            AsignarTurno();
        }


        public void PagarPeaje(Jugador jugadorCobra, Jugador jugadorPaga)
        {
            var valorPeaje = propiedadActual.ValorPeaje;
            if (valorPeaje > jugadorPaga.Saldo)
                MessageBox.Show(String.Format("Jugador {0} no tiene dinero para pagar el peaje, debe hipotecar o declararse en banca rota", jugadorPaga.Nombre));
            else
            {
                PlaySimpleSound(Recursos.salida_dinero);
                jugadorPaga.Saldo -= valorPeaje;
                jugadorCobra.Saldo += valorPeaje;
                avanzaPosicionLbl.Text = String.Format("{0} paga ₡{1} a {2}, por pasar por {3}!", jugadorPaga.Nombre, valorPeaje, jugadorCobra.Nombre, propiedadActual.Nombre);
                MostrarMovientoSaldo(valorPeaje, Color.Red, jugadorEnTurno == 1 ? operacionesJug2lbl : operacionesJug1lbl, jugadorEnTurno == 1 ? operacionesJug1lbl : operacionesJug2lbl);
                ActualizarEtiquetasdeSaldos();
            }

            jugadorEnTurno = jugadorEnTurno == 1 ? 2 : 1;
            AsignarTurno();
        }

        public void ActualizarEtiquetasdeSaldos()
        {
            saldoJug1lbl.Text = string.Format("₡{0}", partidaActual.Jugador1.Saldo);
            saldoJug2lbl.Text = string.Format("₡{0}", partidaActual.Jugador2.Saldo);
        }        

        public void MostrarMovientoSaldo(double monto, Color color, Label operacionAcredita, Label operacionDebita)
        {
            if (operacionAcredita != null)
            {
                operacionAcredita.ForeColor = Color.Green;
                operacionAcredita.Text = string.Format("+ ₡{0}", monto);
                operacionAcredita.Visible = true;
            }

            if (operacionDebita != null)
            {
                operacionDebita.ForeColor = Color.Red;
                operacionDebita.Text = string.Format("- ₡{0}", monto);
                operacionDebita.Visible = true;
            }


            timerOperaciones = new System.Windows.Forms.Timer();
            timerOperaciones.Interval = 1000;
            timerOperaciones.Tick += new EventHandler(TimerOperaciones_Tick);
            timerOperaciones.Start();
        }

        private void TimerOperaciones_Tick(object sender, EventArgs e)
        {
            if (operacionesJug1lbl.Visible)
                operacionesJug1lbl.Visible = false;

            if (operacionesJug2lbl.Visible)
                operacionesJug2lbl.Visible = false;

            timerOperaciones.Stop();

        }

    }
}
