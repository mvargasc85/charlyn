/*
 * Created by SharpDevelop.
 * User: Charlyn Avila
 * Date: 08/05/2016
 * Time: 05:49 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MonopolyCR.UI
{
	partial class AcercadeFrm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label5;
		
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(286, 54);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(200, 42);
			this.label1.TabIndex = 0;
			this.label1.Text = "Programacion II";
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(261, 107);
			this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(255, 42);
			this.label2.TabIndex = 1;
			this.label2.Text = "Charlyn Avila Corrales";
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(261, 159);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(255, 34);
			this.label3.TabIndex = 2;
			this.label3.Text = "Josue Naranjo Cordero";
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(310, 213);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(167, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "I ciclo 2016";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(395, 308);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(91, 32);
			this.button1.TabIndex = 5;
			this.button1.Text = "Salir";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label5
			// 
			this.label5.Image = global::MonopolyCR.Recursos.ima;
			this.label5.Location = new System.Drawing.Point(19, 21);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(233, 331);
			this.label5.TabIndex = 6;
			// 
			// AcercadeFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(514, 371);
			this.ControlBox = false;
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AcercadeFrm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Acerca de MonopolyCR";
			this.Load += new System.EventHandler(this.AcercadeFrmLoad);
			this.ResumeLayout(false);

		}
	}
}
