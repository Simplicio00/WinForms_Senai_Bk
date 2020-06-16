namespace WindowsFormsApp1.Views
{
	partial class _6ListaUsuario
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.gridviewUsuario = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.gridviewUsuario)).BeginInit();
			this.SuspendLayout();
			// 
			// gridviewUsuario
			// 
			this.gridviewUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridviewUsuario.Location = new System.Drawing.Point(12, 12);
			this.gridviewUsuario.Name = "gridviewUsuario";
			this.gridviewUsuario.Size = new System.Drawing.Size(613, 228);
			this.gridviewUsuario.TabIndex = 0;
			this.gridviewUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewUsuarioCellClick);
			this.gridviewUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewUsuario_CellContentClick);
			this.gridviewUsuario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewUsuario_CellDoubleClick);
			// 
			// _6ListaUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuText;
			this.ClientSize = new System.Drawing.Size(637, 261);
			this.Controls.Add(this.gridviewUsuario);
			this.Name = "_6ListaUsuario";
			this.Text = "_6ListaUsuario";
			this.Load += new System.EventHandler(this._6ListaUsuario_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridviewUsuario)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView gridviewUsuario;
	}
}