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
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtColor;
		private System.Windows.Forms.Button btnRegistraJugador;
		private System.Windows.Forms.Button btnCancaleRegJugador;
		
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
			this.label2 = new System.Windows.Forms.Label();
			this.txtColor = new System.Windows.Forms.TextBox();
			this.btnRegistraJugador = new System.Windows.Forms.Button();
			this.btnCancaleRegJugador = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(18, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre:";
			// 
			// txtNombreJugador
			// 
			this.txtNombreJugador.Location = new System.Drawing.Point(124, 67);
			this.txtNombreJugador.Name = "txtNombreJugador";
			this.txtNombreJugador.Size = new System.Drawing.Size(161, 20);
			this.txtNombreJugador.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 118);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Color";
			// 
			// txtColor
			// 
			this.txtColor.Location = new System.Drawing.Point(68, 144);
			this.txtColor.Name = "txtColor";
			this.txtColor.Size = new System.Drawing.Size(161, 20);
			this.txtColor.TabIndex = 3;
			// 
			// btnRegistraJugador
			// 
			this.btnRegistraJugador.Location = new System.Drawing.Point(86, 212);
			this.btnRegistraJugador.Name = "btnRegistraJugador";
			this.btnRegistraJugador.Size = new System.Drawing.Size(75, 23);
			this.btnRegistraJugador.TabIndex = 4;
			this.btnRegistraJugador.Text = "Registrar";
			this.btnRegistraJugador.UseVisualStyleBackColor = true;
			this.btnRegistraJugador.Click += new System.EventHandler(this.BtnRegistraJugadorClick);
			// 
			// btnCancaleRegJugador
			// 
			this.btnCancaleRegJugador.Location = new System.Drawing.Point(192, 212);
			this.btnCancaleRegJugador.Name = "btnCancaleRegJugador";
			this.btnCancaleRegJugador.Size = new System.Drawing.Size(75, 23);
			this.btnCancaleRegJugador.TabIndex = 5;
			this.btnCancaleRegJugador.Text = "Cancelar";
			this.btnCancaleRegJugador.UseVisualStyleBackColor = true;
			this.btnCancaleRegJugador.Click += new System.EventHandler(this.BtnCancaleRegJugadorClick);
			// 
			// RegistroJugadorFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(461, 353);
			this.Controls.Add(this.btnCancaleRegJugador);
			this.Controls.Add(this.btnRegistraJugador);
			this.Controls.Add(this.txtColor);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtNombreJugador);
			this.Controls.Add(this.label1);
			this.Name = "RegistroJugadorFrm";
			this.Text = "RegistroUsuario";
			this.Load += new System.EventHandler(this.RegistroJugadorFrmLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
