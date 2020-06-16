namespace WindowsFormsApp1
{
	partial class Form1
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
			this.nomelogin = new System.Windows.Forms.Label();
			this.textlogin = new System.Windows.Forms.TextBox();
			this.titulologin = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.linkCadastro = new System.Windows.Forms.LinkLabel();
			this.lblcaps = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.lblSenha = new System.Windows.Forms.Label();
			this.btnLang = new System.Windows.Forms.Button();
			this.btnLang2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// nomelogin
			// 
			this.nomelogin.AutoSize = true;
			this.nomelogin.Location = new System.Drawing.Point(29, 117);
			this.nomelogin.Name = "nomelogin";
			this.nomelogin.Size = new System.Drawing.Size(43, 13);
			this.nomelogin.TabIndex = 0;
			this.nomelogin.Text = "Usuário";
			this.nomelogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.nomelogin.Click += new System.EventHandler(this.label1_Click);
			// 
			// textlogin
			// 
			this.textlogin.Location = new System.Drawing.Point(95, 114);
			this.textlogin.Name = "textlogin";
			this.textlogin.Size = new System.Drawing.Size(220, 20);
			this.textlogin.TabIndex = 3;
			this.textlogin.TextChanged += new System.EventHandler(this.textlogin_TextChanged);
			// 
			// titulologin
			// 
			this.titulologin.AutoSize = true;
			this.titulologin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.titulologin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titulologin.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.titulologin.Location = new System.Drawing.Point(165, 9);
			this.titulologin.Name = "titulologin";
			this.titulologin.Size = new System.Drawing.Size(65, 25);
			this.titulologin.TabIndex = 4;
			this.titulologin.Text = "Login";
			this.titulologin.Click += new System.EventHandler(this.label1_Click_1);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.button1.ForeColor = System.Drawing.SystemColors.MenuText;
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(159, 192);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(86, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Entrar";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// linkCadastro
			// 
			this.linkCadastro.AutoSize = true;
			this.linkCadastro.Location = new System.Drawing.Point(178, 218);
			this.linkCadastro.Name = "linkCadastro";
			this.linkCadastro.Size = new System.Drawing.Size(52, 13);
			this.linkCadastro.TabIndex = 6;
			this.linkCadastro.TabStop = true;
			this.linkCadastro.Text = "Cadastrar";
			this.linkCadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCadastro_LinkClicked);
			// 
			// lblcaps
			// 
			this.lblcaps.AutoSize = true;
			this.lblcaps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.lblcaps.Location = new System.Drawing.Point(279, 37);
			this.lblcaps.Name = "lblcaps";
			this.lblcaps.Size = new System.Drawing.Size(89, 13);
			this.lblcaps.TabIndex = 7;
			this.lblcaps.Text = "Capslock ativado";
			this.lblcaps.Click += new System.EventHandler(this.lblcaps_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.some;
			this.pictureBox1.Location = new System.Drawing.Point(130, 37);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(131, 71);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(95, 157);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(220, 20);
			this.textBox1.TabIndex = 12;
			// 
			// lblSenha
			// 
			this.lblSenha.AutoSize = true;
			this.lblSenha.Location = new System.Drawing.Point(29, 160);
			this.lblSenha.Name = "lblSenha";
			this.lblSenha.Size = new System.Drawing.Size(38, 13);
			this.lblSenha.TabIndex = 11;
			this.lblSenha.Text = "Senha";
			// 
			// btnLang
			// 
			this.btnLang.BackColor = System.Drawing.SystemColors.Info;
			this.btnLang.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLang.ForeColor = System.Drawing.Color.Maroon;
			this.btnLang.Location = new System.Drawing.Point(12, 13);
			this.btnLang.Name = "btnLang";
			this.btnLang.Size = new System.Drawing.Size(75, 23);
			this.btnLang.TabIndex = 13;
			this.btnLang.Text = "ENGLISH";
			this.btnLang.UseVisualStyleBackColor = false;
			this.btnLang.Click += new System.EventHandler(this.btnLang_Click);
			// 
			// btnLang2
			// 
			this.btnLang2.BackColor = System.Drawing.SystemColors.Info;
			this.btnLang2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLang2.ForeColor = System.Drawing.Color.Maroon;
			this.btnLang2.Location = new System.Drawing.Point(10, 42);
			this.btnLang2.Name = "btnLang2";
			this.btnLang2.Size = new System.Drawing.Size(75, 23);
			this.btnLang2.TabIndex = 14;
			this.btnLang2.Text = "PT BR";
			this.btnLang2.UseVisualStyleBackColor = false;
			this.btnLang2.Click += new System.EventHandler(this.btnLang2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(380, 240);
			this.Controls.Add(this.btnLang2);
			this.Controls.Add(this.btnLang);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.lblSenha);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblcaps);
			this.Controls.Add(this.linkCadastro);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.titulologin);
			this.Controls.Add(this.textlogin);
			this.Controls.Add(this.nomelogin);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label nomelogin;
		private System.Windows.Forms.TextBox textlogin;
		private System.Windows.Forms.Label titulologin;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.LinkLabel linkCadastro;
		private System.Windows.Forms.Label lblcaps;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label lblSenha;
		private System.Windows.Forms.Button btnLang;
		private System.Windows.Forms.Button btnLang2;
	}
}