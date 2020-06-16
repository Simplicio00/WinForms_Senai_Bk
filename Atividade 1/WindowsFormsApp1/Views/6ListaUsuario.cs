using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.Repository;

namespace WindowsFormsApp1.Views
{
	public partial class _6ListaUsuario : Form
	{
		URepository rep = new URepository();
		public _6ListaUsuario()
		{
			InitializeComponent();
		}

		private void gridviewUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		private void _6ListaUsuario_Load(object sender, EventArgs e)
		{
			CarregarLista();
		}

		private void CarregarLista()
		{
			gridviewUsuario.DataSource = rep.GetAll();
		}

		private void gridviewUsuarioCellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow linha = gridviewUsuario.Rows[e.RowIndex];
			int idusuario = Convert.ToInt32(linha.Cells[0].Value.ToString());
			string nome = linha.Cells[1].Value.ToString();
			Usuario usuario = new Usuario()
			{
				IdUsuario = idusuario,
				Nome = nome
			};
			rep.Editar(usuario);
			Refresh();

			rep.GetAll();
		}

		private void gridviewUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			DialogResult dialog = MessageBox.Show("Deseja excluir?", "Excluir usuário", MessageBoxButtons.YesNo);
			if (dialog == DialogResult.Yes)
			{
				DataGridViewRow linha = gridviewUsuario.Rows[e.RowIndex];

				var usr = rep.BuscarPorId(Convert.ToInt32(linha.Cells[0].Value.ToString()));

				if (usr.IsAdmin == true)
				{
					MessageBox.Show("Você não pode excluir um Administrador!");
				}
				else
				{
					rep.Excluir(Convert.ToInt32(linha.Cells[0].Value.ToString()));
					Update();
					rep.GetAll();
					MessageBox.Show("Excluído com sucesso");
					this.Close();
				}

				
			}
		}
	}
}
