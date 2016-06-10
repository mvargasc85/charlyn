/*
 * Creado por SharpDevelop.
 * Usuario: Charlyn Avila
 * Fecha: 25/05/2016
 * Hora: 03:46 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MonopolyCR.UI
{
    /// <summary>
    /// Description of GanadorFrm.
    /// </summary>
    public partial class GanadorFrm : Form
    {
        public string NombreGanador { get; set; }
        public string NombrePerdedor { get; set; }
        public double EfectivoGanador { get; set; }
        public double EfectivoPerdedor { get; set; }
        public double ValorPropiedadesGanador { get; set; }
        public double ValorPropiedadesPerdedor { get; set; }
        public double TotalGanador { get; set; }
        public double TotalPerdedor { get; set; }

        public GanadorFrm()
        {
            InitializeComponent();
        }

        public void InicializarValores()
        {
            ganadorgbx.Text = NombreGanador;
            perdedorgbx.Text = NombrePerdedor;
            efectivoGanLbl.Text = string.Format("₡{0}", EfectivoGanador);
            efectivoPerdLbl.Text = string.Format("₡{0}", EfectivoPerdedor);
            valorpropganLbl.Text = string.Format("₡{0}", ValorPropiedadesGanador);
            valorpropperdLbl.Text = string.Format("₡{0}", ValorPropiedadesPerdedor);
            ganadortotalbl.Text = string.Format("₡{0}", TotalGanador);
            perdedortotalbl.Text = string.Format("₡{0}", TotalPerdedor);
            ganadorLeyendlbl.Text = string.Format("Felicidades {0} has demostrato dominar\n             el antiguo arte del comercio!!!", NombreGanador);

        }
        void Label5Click(object sender, EventArgs e)
        {

        }
        void TxtGanadorClick(object sender, EventArgs e)
        {

        }
        void GanadorFrmLoad(object sender, EventArgs e)
        {

        }

        private void nombreGanLbl_Click(object sender, EventArgs e)
        {

        }

        private void salirbtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Hide();
        }

    }
}

