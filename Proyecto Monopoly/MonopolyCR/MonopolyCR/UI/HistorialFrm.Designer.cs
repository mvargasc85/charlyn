/*
 * Creado por SharpDevelop.
 * Usuario: Charlyn Avila
 * Fecha: 22/05/2016
 * Hora: 11:59 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace MonopolyCR.UI
{
	partial class HistorialFrm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnNombre;
		private System.Windows.Forms.ColumnHeader columnFecha;
		private System.Windows.Forms.ColumnHeader columnPuntos;
		private System.Windows.Forms.ColumnHeader columnGanador;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		
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
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnNombre = new System.Windows.Forms.ColumnHeader();
			this.columnFecha = new System.Windows.Forms.ColumnHeader();
			this.columnPuntos = new System.Windows.Forms.ColumnHeader();
			this.columnGanador = new System.Windows.Forms.ColumnHeader();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.BackColor = System.Drawing.SystemColors.Menu;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.columnNombre,
			this.columnFecha,
			this.columnPuntos,
			this.columnGanador});
			this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listView1.Location = new System.Drawing.Point(40, 78);
			this.listView1.Name = "listView1";
			this.listView1.Scrollable = false;
			this.listView1.Size = new System.Drawing.Size(568, 274);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnNombre
			// 
			this.columnNombre.Text = "Nombre";
			this.columnNombre.Width = 144;
			// 
			// columnFecha
			// 
			this.columnFecha.Text = "Fecha";
			this.columnFecha.Width = 141;
			// 
			// columnPuntos
			// 
			this.columnPuntos.Text = "Puntos";
			this.columnPuntos.Width = 102;
			// 
			// columnGanador
			// 
			this.columnGanador.Text = "Ganador";
			this.columnGanador.Width = 147;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Location = new System.Drawing.Point(445, 379);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Salir";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(210, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(295, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Historial de los jugadores";
			// 
			// label2
			// 
			this.label2.Image = global::MonopolyCR.Recursos.monopoly_run;
			this.label2.Location = new System.Drawing.Point(526, 355);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(99, 82);
			this.label2.TabIndex = 3;
			// 
			// HistorialFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(649, 433);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.listView1);
			this.ForeColor = System.Drawing.Color.Black;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "HistorialFrm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Historial de los jugadores";
			this.ResumeLayout(false);

		}
	}
}
