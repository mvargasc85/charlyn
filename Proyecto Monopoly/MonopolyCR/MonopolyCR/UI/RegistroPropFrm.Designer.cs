/*
 * Creado por SharpDevelop.
 * Usuario: Charlyn Avila
 * Fecha: 27/05/2016
 * Hora: 08:52 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace MonopolyCR.UI
{
	partial class RegistroPropFrm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Label lblValorCompra;
		private System.Windows.Forms.Label lblValorPeaje;
		private System.Windows.Forms.Label lblPropietario;
		private System.Windows.Forms.Button btnRegistrar;
		private System.Windows.Forms.TextBox txtNombreProp;
		private System.Windows.Forms.TextBox txtPropietarioProp;
		private System.Windows.Forms.TextBox txtValorCompProp;
		private System.Windows.Forms.TextBox txtValorPeajeProp;
		
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
			this.lblNombre = new System.Windows.Forms.Label();
			this.lblValorCompra = new System.Windows.Forms.Label();
			this.lblValorPeaje = new System.Windows.Forms.Label();
			this.lblPropietario = new System.Windows.Forms.Label();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.txtNombreProp = new System.Windows.Forms.TextBox();
			this.txtPropietarioProp = new System.Windows.Forms.TextBox();
			this.txtValorCompProp = new System.Windows.Forms.TextBox();
			this.txtValorPeajeProp = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblNombre
			// 
			this.lblNombre.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombre.Location = new System.Drawing.Point(66, 58);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(100, 23);
			this.lblNombre.TabIndex = 0;
			this.lblNombre.Text = "Nombre";
			// 
			// lblValorCompra
			// 
			this.lblValorCompra.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblValorCompra.Location = new System.Drawing.Point(66, 186);
			this.lblValorCompra.Name = "lblValorCompra";
			this.lblValorCompra.Size = new System.Drawing.Size(169, 23);
			this.lblValorCompra.TabIndex = 1;
			this.lblValorCompra.Text = "Valor Compra";
			// 
			// lblValorPeaje
			// 
			this.lblValorPeaje.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblValorPeaje.Location = new System.Drawing.Point(66, 250);
			this.lblValorPeaje.Name = "lblValorPeaje";
			this.lblValorPeaje.Size = new System.Drawing.Size(140, 23);
			this.lblValorPeaje.TabIndex = 2;
			this.lblValorPeaje.Text = "Valor Peaje";
			// 
			// lblPropietario
			// 
			this.lblPropietario.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPropietario.Location = new System.Drawing.Point(66, 120);
			this.lblPropietario.Name = "lblPropietario";
			this.lblPropietario.Size = new System.Drawing.Size(100, 23);
			this.lblPropietario.TabIndex = 3;
			this.lblPropietario.Text = "Propietario";
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.Location = new System.Drawing.Point(381, 339);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(106, 23);
			this.btnRegistrar.TabIndex = 4;
			this.btnRegistrar.Text = "Registrar";
			this.btnRegistrar.UseVisualStyleBackColor = true;
			this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrarClick);
			// 
			// txtNombreProp
			// 
			this.txtNombreProp.Location = new System.Drawing.Point(172, 58);
			this.txtNombreProp.Name = "txtNombreProp";
			this.txtNombreProp.Size = new System.Drawing.Size(100, 20);
			this.txtNombreProp.TabIndex = 5;
			// 
			// txtPropietarioProp
			// 
			this.txtPropietarioProp.Location = new System.Drawing.Point(193, 120);
			this.txtPropietarioProp.Name = "txtPropietarioProp";
			this.txtPropietarioProp.Size = new System.Drawing.Size(100, 20);
			this.txtPropietarioProp.TabIndex = 6;
			// 
			// txtValorCompProp
			// 
			this.txtValorCompProp.Location = new System.Drawing.Point(241, 186);
			this.txtValorCompProp.Name = "txtValorCompProp";
			this.txtValorCompProp.Size = new System.Drawing.Size(100, 20);
			this.txtValorCompProp.TabIndex = 7;
			// 
			// txtValorPeajeProp
			// 
			this.txtValorPeajeProp.Location = new System.Drawing.Point(212, 253);
			this.txtValorPeajeProp.Name = "txtValorPeajeProp";
			this.txtValorPeajeProp.Size = new System.Drawing.Size(100, 20);
			this.txtValorPeajeProp.TabIndex = 8;
			// 
			// RegistroPropFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(614, 405);
			this.Controls.Add(this.txtValorPeajeProp);
			this.Controls.Add(this.txtValorCompProp);
			this.Controls.Add(this.txtPropietarioProp);
			this.Controls.Add(this.txtNombreProp);
			this.Controls.Add(this.btnRegistrar);
			this.Controls.Add(this.lblPropietario);
			this.Controls.Add(this.lblValorPeaje);
			this.Controls.Add(this.lblValorCompra);
			this.Controls.Add(this.lblNombre);
			this.Name = "RegistroPropFrm";
			this.Text = "Registrar Propiedad";
			this.Load += new System.EventHandler(this.RegistroPropFrmLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
