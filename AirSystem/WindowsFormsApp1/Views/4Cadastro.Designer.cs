namespace WindowsFormsApp1
{
	partial class Cadastro
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
			this.nomelbl = new System.Windows.Forms.Label();
			this.lbltxtNome = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.inputMail = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblUsuario = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.lblDataNascimento = new System.Windows.Forms.DateTimePicker();
			this.lblNaoValido = new System.Windows.Forms.Label();
			this.lblSenha = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.lblConfirmarSenha = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.lblEndereco = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.checkAdmin = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// nomelbl
			// 
			this.nomelbl.AutoSize = true;
			this.nomelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nomelbl.Location = new System.Drawing.Point(7, 16);
			this.nomelbl.Name = "nomelbl";
			this.nomelbl.Size = new System.Drawing.Size(35, 13);
			this.nomelbl.TabIndex = 0;
			this.nomelbl.Text = "Nome";
			// 
			// lbltxtNome
			// 
			this.lbltxtNome.Location = new System.Drawing.Point(48, 13);
			this.lbltxtNome.Name = "lbltxtNome";
			this.lbltxtNome.Size = new System.Drawing.Size(124, 20);
			this.lbltxtNome.TabIndex = 1;
			this.lbltxtNome.TextChanged += new System.EventHandler(this.lbltxtNome_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(7, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "E-Mail";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// inputMail
			// 
			this.inputMail.Location = new System.Drawing.Point(48, 54);
			this.inputMail.Name = "inputMail";
			this.inputMail.Size = new System.Drawing.Size(124, 20);
			this.inputMail.TabIndex = 3;
			this.inputMail.TextChanged += new System.EventHandler(this.inputMail_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(7, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Usuario";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(163, 173);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Data nascimento";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(293, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 25);
			this.label4.TabIndex = 6;
			this.label4.Text = "Foto";
			// 
			// lblUsuario
			// 
			this.lblUsuario.Location = new System.Drawing.Point(48, 89);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(124, 20);
			this.lblUsuario.TabIndex = 7;
			this.lblUsuario.TextChanged += new System.EventHandler(this.lblUsuario_TextChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.pictureBox1.Location = new System.Drawing.Point(256, 37);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(129, 110);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(256, 231);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(129, 43);
			this.button1.TabIndex = 10;
			this.button1.Text = "Cadastrar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(181, 89);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(41, 20);
			this.button2.TabIndex = 11;
			this.button2.Text = "Gerar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// lblDataNascimento
			// 
			this.lblDataNascimento.Location = new System.Drawing.Point(256, 167);
			this.lblDataNascimento.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
			this.lblDataNascimento.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
			this.lblDataNascimento.Name = "lblDataNascimento";
			this.lblDataNascimento.Size = new System.Drawing.Size(132, 20);
			this.lblDataNascimento.TabIndex = 13;
			// 
			// lblNaoValido
			// 
			this.lblNaoValido.AutoSize = true;
			this.lblNaoValido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNaoValido.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.lblNaoValido.Location = new System.Drawing.Point(178, 57);
			this.lblNaoValido.Name = "lblNaoValido";
			this.lblNaoValido.Size = new System.Drawing.Size(75, 13);
			this.lblNaoValido.TabIndex = 14;
			this.lblNaoValido.Text = "E-Mail inválido";
			// 
			// lblSenha
			// 
			this.lblSenha.Location = new System.Drawing.Point(48, 127);
			this.lblSenha.Name = "lblSenha";
			this.lblSenha.Size = new System.Drawing.Size(124, 20);
			this.lblSenha.TabIndex = 16;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(7, 130);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(38, 13);
			this.label5.TabIndex = 15;
			this.label5.Text = "Senha";
			// 
			// lblConfirmarSenha
			// 
			this.lblConfirmarSenha.Location = new System.Drawing.Point(10, 204);
			this.lblConfirmarSenha.Name = "lblConfirmarSenha";
			this.lblConfirmarSenha.Size = new System.Drawing.Size(132, 20);
			this.lblConfirmarSenha.TabIndex = 18;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(7, 188);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(89, 13);
			this.label6.TabIndex = 17;
			this.label6.Text = "Confirme a senha";
			// 
			// lblEndereco
			// 
			this.lblEndereco.Location = new System.Drawing.Point(10, 254);
			this.lblEndereco.Name = "lblEndereco";
			this.lblEndereco.Size = new System.Drawing.Size(132, 20);
			this.lblEndereco.TabIndex = 19;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(7, 238);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(53, 13);
			this.label7.TabIndex = 20;
			this.label7.Text = "Endereço";
			// 
			// checkAdmin
			// 
			this.checkAdmin.AutoSize = true;
			this.checkAdmin.Location = new System.Drawing.Point(281, 208);
			this.checkAdmin.Name = "checkAdmin";
			this.checkAdmin.Size = new System.Drawing.Size(89, 17);
			this.checkAdmin.TabIndex = 21;
			this.checkAdmin.Text = "Administrador";
			this.checkAdmin.UseVisualStyleBackColor = true;
			// 
			// Cadastro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(397, 286);
			this.Controls.Add(this.checkAdmin);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lblEndereco);
			this.Controls.Add(this.lblConfirmarSenha);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.lblSenha);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lblNaoValido);
			this.Controls.Add(this.lblDataNascimento);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblUsuario);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.inputMail);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbltxtNome);
			this.Controls.Add(this.nomelbl);
			this.Name = "Cadastro";
			this.Text = "Cadastro";
			this.Load += new System.EventHandler(this.Cadastro_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label nomelbl;
		private System.Windows.Forms.TextBox lbltxtNome;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox inputMail;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox lblUsuario;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DateTimePicker lblDataNascimento;
		private System.Windows.Forms.Label lblNaoValido;
		private System.Windows.Forms.TextBox lblSenha;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox lblConfirmarSenha;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox lblEndereco;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.CheckBox checkAdmin;
	}
}