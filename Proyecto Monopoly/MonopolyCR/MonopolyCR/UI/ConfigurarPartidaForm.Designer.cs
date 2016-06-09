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
		private System.Windows.Forms.NumericUpDown montoInicialNud;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Button button1;
		
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
            this.montoInicialNud = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnJugar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.colorJug1cbx = new System.Windows.Forms.ComboBox();
            this.colorjug2cbx = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.montoInicialNud)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Jugador1Cbx
            // 
            this.Jugador1Cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Jugador1Cbx.FormattingEnabled = true;
            this.Jugador1Cbx.Location = new System.Drawing.Point(127, 60);
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
            this.Jugador2Cbx.Location = new System.Drawing.Point(127, 49);
            this.Jugador2Cbx.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Jugador2Cbx.Name = "Jugador2Cbx";
            this.Jugador2Cbx.Size = new System.Drawing.Size(179, 24);
            this.Jugador2Cbx.TabIndex = 1;
            // 
            // lblJugador
            // 
            this.lblJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugador.ForeColor = System.Drawing.Color.White;
            this.lblJugador.Location = new System.Drawing.Point(373, 25);
            this.lblJugador.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblJugador.Name = "lblJugador";
            this.lblJugador.Size = new System.Drawing.Size(109, 28);
            this.lblJugador.TabIndex = 2;
            this.lblJugador.Text = "Color de Ficha";
            this.lblJugador.Click += new System.EventHandler(this.LblJugadorClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(373, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Color de Ficha";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 340);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Monto Inicial";
            // 
            // montoInicialNud
            // 
            this.montoInicialNud.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.montoInicialNud.Location = new System.Drawing.Point(170, 338);
            this.montoInicialNud.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.montoInicialNud.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.montoInicialNud.Name = "montoInicialNud";
            this.montoInicialNud.Size = new System.Drawing.Size(179, 22);
            this.montoInicialNud.TabIndex = 5;
            this.montoInicialNud.Value = new decimal(new int[] {
            40000,
            0,
            0,
            0});
            this.montoInicialNud.ValueChanged += new System.EventHandler(this.NumericUpDown1ValueChanged);
            // 
            // label3
            // 
            this.label3.Image = global::MonopolyCR.Recursos.Jugador1;
            this.label3.Location = new System.Drawing.Point(8, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 89);
            this.label3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Image = global::MonopolyCR.Recursos.Jugador2;
            this.label4.Location = new System.Drawing.Point(28, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 92);
            this.label4.TabIndex = 7;
            // 
            // btnJugar
            // 
            this.btnJugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugar.ForeColor = System.Drawing.Color.Black;
            this.btnJugar.Location = new System.Drawing.Point(383, 340);
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
            this.button1.Location = new System.Drawing.Point(484, 340);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 26);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.colorJug1cbx);
            this.groupBox1.Controls.Add(this.Jugador1Cbx);
            this.groupBox1.Controls.Add(this.lblJugador);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(43, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 116);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Primer Jugador";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.colorjug2cbx);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Jugador2Cbx);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(43, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(536, 116);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Segundo Jugador";
            // 
            // colorJug1cbx
            // 
            this.colorJug1cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorJug1cbx.FormattingEnabled = true;
            this.colorJug1cbx.Location = new System.Drawing.Point(340, 60);
            this.colorJug1cbx.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.colorJug1cbx.Name = "colorJug1cbx";
            this.colorJug1cbx.Size = new System.Drawing.Size(179, 24);
            this.colorJug1cbx.TabIndex = 7;
            this.colorJug1cbx.SelectedIndexChanged += new System.EventHandler(this.colorJug1cbx_SelectedIndexChanged);
            // 
            // colorjug2cbx
            // 
            this.colorjug2cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorjug2cbx.FormattingEnabled = true;
            this.colorjug2cbx.Location = new System.Drawing.Point(340, 50);
            this.colorjug2cbx.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.colorjug2cbx.Name = "colorjug2cbx";
            this.colorjug2cbx.Size = new System.Drawing.Size(179, 24);
            this.colorjug2cbx.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(179, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(179, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nombre";
            // 
            // ConfigurarPartidaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(642, 386);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.montoInicialNud);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ConfigurarPartidaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion de los Jugadores";
            ((System.ComponentModel.ISupportInitialize)(this.montoInicialNud)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox colorJug1cbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox colorjug2cbx;
	}
}
