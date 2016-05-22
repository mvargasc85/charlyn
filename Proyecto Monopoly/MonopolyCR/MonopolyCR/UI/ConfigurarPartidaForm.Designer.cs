/*
 * Creado por SharpDevelop.
 * Usuario: Charlyn Avila
 * Fecha: 21/05/2016
 * Hora: 12:54 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace MonopolyCR.UI
{
	partial class ConfigurarPartidaForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ComboBox Jugador1Cbx;
		private System.Windows.Forms.ComboBox Jugador2Cbx;
		private System.Windows.Forms.Label lblJugador;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.Jugador1Cbx = new System.Windows.Forms.ComboBox();
			this.Jugador2Cbx = new System.Windows.Forms.ComboBox();
			this.lblJugador = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// Jugador1Cbx
			// 
			this.Jugador1Cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Jugador1Cbx.FormattingEnabled = true;
			this.Jugador1Cbx.Location = new System.Drawing.Point(162, 93);
			this.Jugador1Cbx.Name = "Jugador1Cbx";
			this.Jugador1Cbx.Size = new System.Drawing.Size(121, 21);
			this.Jugador1Cbx.TabIndex = 0;
			this.Jugador1Cbx.SelectedIndexChanged += new System.EventHandler(this.Jugador1CbxSelectedIndexChanged);
			// 
			// Jugador2Cbx
			// 
			this.Jugador2Cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Jugador2Cbx.FormattingEnabled = true;
			this.Jugador2Cbx.Location = new System.Drawing.Point(162, 179);
			this.Jugador2Cbx.Name = "Jugador2Cbx";
			this.Jugador2Cbx.Size = new System.Drawing.Size(121, 21);
			this.Jugador2Cbx.TabIndex = 1;
			// 
			// lblJugador
			// 
			this.lblJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblJugador.Location = new System.Drawing.Point(162, 55);
			this.lblJugador.Name = "lblJugador";
			this.lblJugador.Size = new System.Drawing.Size(146, 23);
			this.lblJugador.TabIndex = 2;
			this.lblJugador.Text = "Primer Jugador ";
			this.lblJugador.Click += new System.EventHandler(this.LblJugadorClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(162, 143);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(156, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Segundo Jugador";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(358, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Monto Inicial";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(473, 94);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown1.TabIndex = 5;
			// 
			// ConfigurarPartidaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MediumSpringGreen;
			this.ClientSize = new System.Drawing.Size(660, 369);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblJugador);
			this.Controls.Add(this.Jugador2Cbx);
			this.Controls.Add(this.Jugador1Cbx);
			this.Name = "ConfigurarPartidaForm";
			this.Text = "ConfigurarPartidaForm";
			this.Load += new System.EventHandler(this.ConfigurarPartidaFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
