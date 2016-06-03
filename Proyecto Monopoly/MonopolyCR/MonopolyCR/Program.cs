/*
 * Created by SharpDevelop.
 * User: Charlyn Avila
 * Date: 07/05/2016
 * Time: 06:00 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using MonopolyCR.UI;

namespace MonopolyCR
{
    /// <summary>
    /// Class with program entry point.
    /// </summary>
    internal sealed class Program
    {
        /// <summary>
        /// Program entry point.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var configurarPartidaFrm = new ConfigurarPartidaForm();

            if (configurarPartidaFrm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var partida = configurarPartidaFrm.PartidaActual;
                configurarPartidaFrm.Close();
                Application.Run(new MonopolyCRFrm(partida));
            }
        }

    }
}
