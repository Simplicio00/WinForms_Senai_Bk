using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.Repository;

namespace WindowsFormsApp1
{
	public partial class Cadastro : Form
	{
		URepository rep = new URepository();

		public Cadastro()
		{
			InitializeComponent();
		}

		public bool valido;
		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void lbltxtNome_TextChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (lbltxtNome.TextLength > 0)
			{
				string usuario = lbltxtNome.Text.ToString() + "." + lblDataNascimento.Value.ToString("yy");
				lblUsuario.Text = usuario;
			}
			else
			{
				MessageBox.Show("Insira um nome válido para gerar o usuário");
			}
			
			
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog();
			open.Filter = " jpeps |*.jpg";
			if (open.ShowDialog() == DialogResult.OK)
			{
				pictureBox1.ImageLocation = open.FileName;
			}
		}


		private void inputMail_TextChanged(object sender, EventArgs e)
		{
			string condicao = "[a-z]{3,}[.][a-z]{3,}[@][a-z]{3,}[.][a-z]{2,3}";
			if (Regex.IsMatch(inputMail.Text, condicao) == true)
			{
				lblNaoValido.Visible = false;
			}
			else
			{
				lblNaoValido.Visible = true;
			}
		}

		private void Cadastro_Load(object sender, EventArgs se)
		{
			lblNaoValido.Visible = false;

		}

		private void lblUsuario_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			bool adm;
			
			if (lblNaoValido.Visible == false && inputMail.Text != null)
			{

				adm = checkAdmin.Checked ? true : false;

				Usuario usuario = new Usuario()
				{
					Nome = lbltxtNome.Text,
					Email = inputMail.Text,
					usr = lblUsuario.Text,
					DataNascimento = lblDataNascimento.Value.Date,
					IsAdmin = adm,
					Senha = lblSenha.Text,
					Endereco = lblEndereco.Text,
					IdUsuario = rep.GetAll().Count + 1
				};

				if (usuario.Nome != null && 
					lblSenha.Text == lblConfirmarSenha.Text && 
					usuario.Email != null && usuario.Endereco != null && 
					usuario.usr != null)
				{
					rep.CadastroUsuario(usuario);
					MessageBox.Show($"O usuário {usuario.Nome} foi cadastrado com sucesso");
					this.Close();
				}
				else
				{
					MessageBox.Show("As senhas dos campos não coincidem");
				}

			}
			else
			{
				MessageBox.Show("Ocorreu um erro na hora de cadastrar, verifique as informações no formulário");
			}

		}
	}
}
