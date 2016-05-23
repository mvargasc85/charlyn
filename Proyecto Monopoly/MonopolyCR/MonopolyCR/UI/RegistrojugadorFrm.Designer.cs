/*
 * Created by SharpDevelop.
 * User: Charlyn Avila
 * Date: 07/05/2016
 * Time: 10:47 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MonopolyCR.UI
{
	partial class RegistroJugadorFrm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNombreJugador;
		private System.Windows.Forms.Button btnRegistraJugador;
		private System.Windows.Forms.Button btnCancaleRegJugador;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtNombreJugador = new System.Windows.Forms.TextBox();
			this.btnRegistraJugador = new System.Windows.Forms.Button();
			this.btnCancaleRegJugador = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(50, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre:";
			// 
			// txtNombreJugador
			// 
			this.txtNombreJugador.Location = new System.Drawing.Point(136, 92);
			this.txtNombreJugador.Name = "txtNombreJugador";
			this.txtNombreJugador.Size = new System.Drawing.Size(136, 20);
			this.txtNombreJugador.TabIndex = 1;
			// 
			// btnRegistraJugador
			// 
			this.btnRegistraJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistraJugador.Location = new System.Drawing.Point(76, 157);
			this.btnRegistraJugador.Name = "btnRegistraJugador";
			this.btnRegistraJugador.Size = new System.Drawing.Size(91, 31);
			this.btnRegistraJugador.TabIndex = 4;
			this.btnRegistraJugador.Text = "Registrar";
			this.btnRegistraJugador.UseVisualStyleBackColor = true;
			this.btnRegistraJugador.Click += new System.EventHandler(this.BtnRegistraJugadorClick);
			// 
			// btnCancaleRegJugador
			// 
			this.btnCancaleRegJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancaleRegJugador.Location = new System.Drawing.Point(173, 157);
			this.btnCancaleRegJugador.Name = "btnCancaleRegJugador";
			this.btnCancaleRegJugador.Size = new System.Drawing.Size(85, 31);
			this.btnCancaleRegJugador.TabIndex = 5;
			this.btnCancaleRegJugador.Text = "Cancelar";
			this.btnCancaleRegJugador.UseVisualStyleBackColor = true;
			this.btnCancaleRegJugador.Click += new System.EventHandler(this.BtnCancaleRegJugadorClick);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(50, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(198, 30);
			this.label2.TabIndex = 6;
			this.label2.Text = "Registrar nuevo usuario";
			// 
			// label3
			// 
			this.label3.Image = global::MonopolyCR.Recursos.Ima2;
			this.label3.Location = new System.Drawing.Point(289, 26);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(152, 211);
			this.label3.TabIndex = 7;
			// 
			// RegistroJugadorFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(463, 310);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnCancaleRegJugador);
			this.Controls.Add(this.btnRegistraJugador);
			this.Controls.Add(this.txtNombreJugador);
			this.Controls.Add(this.label1);
			this.Name = "RegistroJugadorFrm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Nuevo Usuario";
			this.Load += new System.EventHandler(this.RegistroJugadorFrmLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
