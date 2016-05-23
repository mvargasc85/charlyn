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
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnJugar;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton4;
		
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
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnJugar = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// Jugador1Cbx
			// 
			this.Jugador1Cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Jugador1Cbx.FormattingEnabled = true;
			this.Jugador1Cbx.Location = new System.Drawing.Point(158, 124);
			this.Jugador1Cbx.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Jugador1Cbx.Name = "Jugador1Cbx";
			this.Jugador1Cbx.Size = new System.Drawing.Size(179, 24);
			this.Jugador1Cbx.TabIndex = 0;
			this.Jugador1Cbx.SelectedIndexChanged += new System.EventHandler(this.Jugador1CbxSelectedIndexChanged);
			// 
			// Jugador2Cbx
			// 
			this.Jugador2Cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Jugador2Cbx.FormattingEnabled = true;
			this.Jugador2Cbx.Location = new System.Drawing.Point(158, 230);
			this.Jugador2Cbx.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Jugador2Cbx.Name = "Jugador2Cbx";
			this.Jugador2Cbx.Size = new System.Drawing.Size(179, 24);
			this.Jugador2Cbx.TabIndex = 1;
			// 
			// lblJugador
			// 
			this.lblJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblJugador.ForeColor = System.Drawing.Color.White;
			this.lblJugador.Location = new System.Drawing.Point(158, 70);
			this.lblJugador.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lblJugador.Name = "lblJugador";
			this.lblJugador.Size = new System.Drawing.Size(220, 28);
			this.lblJugador.TabIndex = 2;
			this.lblJugador.Text = "Primer Jugador ";
			this.lblJugador.Click += new System.EventHandler(this.LblJugadorClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(158, 182);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(234, 28);
			this.label1.TabIndex = 3;
			this.label1.Text = "Segundo Jugador";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(40, 307);
			this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 28);
			this.label2.TabIndex = 4;
			this.label2.Text = "Monto Inicial";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(158, 305);
			this.numericUpDown1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(180, 22);
			this.numericUpDown1.TabIndex = 5;
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.NumericUpDown1ValueChanged);
			// 
			// label3
			// 
			this.label3.Image = global::MonopolyCR.Recursos.Jugador1;
			this.label3.Location = new System.Drawing.Point(5, 75);
			this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(143, 89);
			this.label3.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.Image = global::MonopolyCR.Recursos.Jugador2;
			this.label4.Location = new System.Drawing.Point(5, 182);
			this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(136, 92);
			this.label4.TabIndex = 7;
			// 
			// btnJugar
			// 
			this.btnJugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnJugar.ForeColor = System.Drawing.Color.Black;
			this.btnJugar.Location = new System.Drawing.Point(400, 379);
			this.btnJugar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.btnJugar.Name = "btnJugar";
			this.btnJugar.Size = new System.Drawing.Size(87, 26);
			this.btnJugar.TabIndex = 8;
			this.btnJugar.Text = "Jugar";
			this.btnJugar.UseVisualStyleBackColor = true;
			this.btnJugar.Click += new System.EventHandler(this.BtnJugarClick);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Location = new System.Drawing.Point(496, 379);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(95, 26);
			this.button1.TabIndex = 9;
			this.button1.Text = "Cancelar";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(400, 75);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(154, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "Seleccionar color";
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(400, 182);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(154, 23);
			this.label6.TabIndex = 11;
			this.label6.Text = "Seleccionar color";
			// 
			// radioButton1
			// 
			this.radioButton1.ForeColor = System.Drawing.Color.Blue;
			this.radioButton1.Location = new System.Drawing.Point(402, 123);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(104, 24);
			this.radioButton1.TabIndex = 12;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Azul";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.ForeColor = System.Drawing.Color.Yellow;
			this.radioButton2.Location = new System.Drawing.Point(502, 124);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(104, 24);
			this.radioButton2.TabIndex = 13;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Amarillo";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			this.radioButton3.ForeColor = System.Drawing.Color.Red;
			this.radioButton3.Location = new System.Drawing.Point(400, 230);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(104, 24);
			this.radioButton3.TabIndex = 14;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Rojo";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// radioButton4
			// 
			this.radioButton4.ForeColor = System.Drawing.Color.Green;
			this.radioButton4.Location = new System.Drawing.Point(502, 230);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(104, 24);
			this.radioButton4.TabIndex = 15;
			this.radioButton4.TabStop = true;
			this.radioButton4.Text = "Verde";
			this.radioButton4.UseVisualStyleBackColor = true;
			// 
			// ConfigurarPartidaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(642, 464);
			this.Controls.Add(this.radioButton4);
			this.Controls.Add(this.radioButton3);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnJugar);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblJugador);
			this.Controls.Add(this.Jugador2Cbx);
			this.Controls.Add(this.Jugador1Cbx);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "ConfigurarPartidaForm";
			this.Text = "Configuracion de los Jugadores";
			this.Load += new System.EventHandler(this.ConfigurarPartidaFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
