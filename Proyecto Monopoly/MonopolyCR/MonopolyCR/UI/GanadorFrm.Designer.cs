/*
 * Creado por SharpDevelop.
 * Usuario: Charlyn Avila
 * Fecha: 25/05/2016
 * Hora: 03:46 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace MonopolyCR.UI
{
	partial class GanadorFrm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
        private System.ComponentModel.IContainer components = null;
		
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
            this.ganadorLeyendlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.efectivoGanLbl = new System.Windows.Forms.Label();
            this.valorpropganLbl = new System.Windows.Forms.Label();
            this.labeltoal = new System.Windows.Forms.Label();
            this.ganadortotalbl = new System.Windows.Forms.Label();
            this.ganadorgbx = new System.Windows.Forms.GroupBox();
            this.perdedorgbx = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.perdedortotalbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.valorpropperdLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.efectivoPerdLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.salirbtn = new System.Windows.Forms.Button();
            this.ganadorgbx.SuspendLayout();
            this.perdedorgbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // ganadorLeyendlbl
            // 
            this.ganadorLeyendlbl.AutoSize = true;
            this.ganadorLeyendlbl.BackColor = System.Drawing.Color.Transparent;
            this.ganadorLeyendlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ganadorLeyendlbl.Location = new System.Drawing.Point(93, 117);
            this.ganadorLeyendlbl.Name = "ganadorLeyendlbl";
            this.ganadorLeyendlbl.Size = new System.Drawing.Size(489, 52);
            this.ganadorLeyendlbl.TabIndex = 1;
            this.ganadorLeyendlbl.Text = "Felicidades Jugador has demostrato dominar\r\n             el antiguo arte del come" +
                "rcio!!!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "En Efectivo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Por propiedades:";
            // 
            // efectivoGanLbl
            // 
            this.efectivoGanLbl.AutoSize = true;
            this.efectivoGanLbl.BackColor = System.Drawing.Color.Transparent;
            this.efectivoGanLbl.Location = new System.Drawing.Point(111, 20);
            this.efectivoGanLbl.Name = "efectivoGanLbl";
            this.efectivoGanLbl.Size = new System.Drawing.Size(13, 13);
            this.efectivoGanLbl.TabIndex = 5;
            this.efectivoGanLbl.Text = "0";
            // 
            // valorpropganLbl
            // 
            this.valorpropganLbl.AutoSize = true;
            this.valorpropganLbl.BackColor = System.Drawing.Color.Transparent;
            this.valorpropganLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorpropganLbl.Location = new System.Drawing.Point(111, 41);
            this.valorpropganLbl.Name = "valorpropganLbl";
            this.valorpropganLbl.Size = new System.Drawing.Size(13, 13);
            this.valorpropganLbl.TabIndex = 6;
            this.valorpropganLbl.Text = "0";
            // 
            // labeltoal
            // 
            this.labeltoal.AutoSize = true;
            this.labeltoal.BackColor = System.Drawing.Color.Transparent;
            this.labeltoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltoal.Location = new System.Drawing.Point(53, 61);
            this.labeltoal.Name = "labeltoal";
            this.labeltoal.Size = new System.Drawing.Size(40, 13);
            this.labeltoal.TabIndex = 7;
            this.labeltoal.Text = "Total:";
            // 
            // ganadortotalbl
            // 
            this.ganadortotalbl.AutoSize = true;
            this.ganadortotalbl.BackColor = System.Drawing.Color.Transparent;
            this.ganadortotalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ganadortotalbl.Location = new System.Drawing.Point(112, 61);
            this.ganadortotalbl.Name = "ganadortotalbl";
            this.ganadortotalbl.Size = new System.Drawing.Size(14, 13);
            this.ganadortotalbl.TabIndex = 8;
            this.ganadortotalbl.Text = "0";
            // 
            // ganadorgbx
            // 
            this.ganadorgbx.BackColor = System.Drawing.Color.Transparent;
            this.ganadorgbx.Controls.Add(this.label1);
            this.ganadorgbx.Controls.Add(this.ganadortotalbl);
            this.ganadorgbx.Controls.Add(this.label2);
            this.ganadorgbx.Controls.Add(this.valorpropganLbl);
            this.ganadorgbx.Controls.Add(this.labeltoal);
            this.ganadorgbx.Controls.Add(this.efectivoGanLbl);
            this.ganadorgbx.Location = new System.Drawing.Point(112, 178);
            this.ganadorgbx.Name = "ganadorgbx";
            this.ganadorgbx.Size = new System.Drawing.Size(200, 85);
            this.ganadorgbx.TabIndex = 9;
            this.ganadorgbx.TabStop = false;
            this.ganadorgbx.Text = "Ganador";
            // 
            // perdedorgbx
            // 
            this.perdedorgbx.BackColor = System.Drawing.Color.Transparent;
            this.perdedorgbx.Controls.Add(this.label3);
            this.perdedorgbx.Controls.Add(this.perdedortotalbl);
            this.perdedorgbx.Controls.Add(this.label5);
            this.perdedorgbx.Controls.Add(this.valorpropperdLbl);
            this.perdedorgbx.Controls.Add(this.label7);
            this.perdedorgbx.Controls.Add(this.efectivoPerdLbl);
            this.perdedorgbx.Location = new System.Drawing.Point(382, 178);
            this.perdedorgbx.Name = "perdedorgbx";
            this.perdedorgbx.Size = new System.Drawing.Size(200, 85);
            this.perdedorgbx.TabIndex = 10;
            this.perdedorgbx.TabStop = false;
            this.perdedorgbx.Text = "Perdedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(28, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "En Efectivo:";
            // 
            // perdedortotalbl
            // 
            this.perdedortotalbl.AutoSize = true;
            this.perdedortotalbl.BackColor = System.Drawing.Color.Transparent;
            this.perdedortotalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perdedortotalbl.Location = new System.Drawing.Point(112, 61);
            this.perdedortotalbl.Name = "perdedortotalbl";
            this.perdedortotalbl.Size = new System.Drawing.Size(14, 13);
            this.perdedortotalbl.TabIndex = 8;
            this.perdedortotalbl.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(6, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Por propiedades:";
            // 
            // valorpropperdLbl
            // 
            this.valorpropperdLbl.AutoSize = true;
            this.valorpropperdLbl.BackColor = System.Drawing.Color.Transparent;
            this.valorpropperdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorpropperdLbl.Location = new System.Drawing.Point(111, 41);
            this.valorpropperdLbl.Name = "valorpropperdLbl";
            this.valorpropperdLbl.Size = new System.Drawing.Size(13, 13);
            this.valorpropperdLbl.TabIndex = 6;
            this.valorpropperdLbl.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(53, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Total:";
            // 
            // efectivoPerdLbl
            // 
            this.efectivoPerdLbl.AutoSize = true;
            this.efectivoPerdLbl.BackColor = System.Drawing.Color.Transparent;
            this.efectivoPerdLbl.Location = new System.Drawing.Point(111, 20);
            this.efectivoPerdLbl.Name = "efectivoPerdLbl";
            this.efectivoPerdLbl.Size = new System.Drawing.Size(13, 13);
            this.efectivoPerdLbl.TabIndex = 5;
            this.efectivoPerdLbl.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(332, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 24);
            this.label9.TabIndex = 11;
            this.label9.Text = "Vs";
            // 
            // salirbtn
            // 
            this.salirbtn.BackColor = System.Drawing.Color.Gold;
            this.salirbtn.Location = new System.Drawing.Point(739, 324);
            this.salirbtn.Name = "salirbtn";
            this.salirbtn.Size = new System.Drawing.Size(50, 23);
            this.salirbtn.TabIndex = 12;
            this.salirbtn.Text = "Salir";
            this.salirbtn.UseVisualStyleBackColor = false;
            this.salirbtn.Click += new System.EventHandler(this.salirbtn_Click);
            // 
            // GanadorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::MonopolyCR.Recursos.fondo_programa;
            this.ClientSize = new System.Drawing.Size(794, 349);
            this.ControlBox = false;
            this.Controls.Add(this.salirbtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.perdedorgbx);
            this.Controls.Add(this.ganadorgbx);
            this.Controls.Add(this.ganadorLeyendlbl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GanadorFrm";
            this.Text = "Has ganado esta partida!";
            this.Load += new System.EventHandler(this.GanadorFrmLoad);
            this.ganadorgbx.ResumeLayout(false);
            this.ganadorgbx.PerformLayout();
            this.perdedorgbx.ResumeLayout(false);
            this.perdedorgbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.Label ganadorLeyendlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label efectivoGanLbl;
        private System.Windows.Forms.Label valorpropganLbl;
        private System.Windows.Forms.Label labeltoal;
        private System.Windows.Forms.Label ganadortotalbl;
        private System.Windows.Forms.GroupBox ganadorgbx;
        private System.Windows.Forms.GroupBox perdedorgbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label perdedortotalbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label valorpropperdLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label efectivoPerdLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button salirbtn;
	}
}
