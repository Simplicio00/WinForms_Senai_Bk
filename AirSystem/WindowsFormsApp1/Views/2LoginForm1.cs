using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Repository;
using WindowsFormsApp1.Views;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		URepository rep = new URepository();
		bool status = false;
		public Form1()
		{
			InitializeComponent();
			textlogin.ShortcutsEnabled = false;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click_1(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			lblcaps.Visible = false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (rep.GetAll().Contains(rep.GetAll().FirstOrDefault(valor => valor.usr == textlogin.Text && valor.Senha == textBox1.Text && valor.IsAdmin == true)))
			{
				if (status == true)
				{
					MessageBox.Show($"Welcome, {textlogin.Text}");
				}
				else
				{
					MessageBox.Show($"Bem vindo, {textlogin.Text}");
				}
				_5Principal principal = new _5Principal();
				principal.ShowDialog();
			}
			else if (rep.GetAll().Contains(rep.GetAll().FirstOrDefault(valor => valor.Email == textlogin.Text && valor.Senha == textBox1.Text && valor.IsAdmin == false)))
			{
				MessageBox.Show($"Bem vindo, {textlogin.Text}");
				PainelUsr painel = new PainelUsr();
				painel.Show();
			}
			else
			{
				if (status == true)
				{
					MessageBox.Show("You cannot log in. Check your data and try again.");
				}
				else
				{
					MessageBox.Show("Dados inválidos! Verifique os seus dados e tente novamente");
				}
			}
		}

		private void linkCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			new Cadastro().Show();
		}


		private void textlogin_TextChanged(object sender, EventArgs e)
		{
			if (Control.IsKeyLocked(Keys.CapsLock) == true)
			{
				lblcaps.Visible = true;
			}
			else
			{
				lblcaps.Visible = false;
			}

		}

		private void tecladoVirtual_Click(object sender, EventArgs e)
		{
		}

		private void lblcaps_Click(object sender, EventArgs e)
		{

		}

		private void btnLang_Click(object sender, EventArgs e)
		{
			status = true;
			nomelogin.Text = "Nickname";
			lblSenha.Text = "Password";
			button1.Text = "Sign In";
			linkCadastro.Text = "Sign up";
		}

		private void btnLang2_Click(object sender, EventArgs e)
		{
			status = false;
			nomelogin.Text = "Usuário";
			lblSenha.Text = "Senha";
			button1.Text = "Entrar";
			linkCadastro.Text = "Cadastrar";
		}
	}
}
