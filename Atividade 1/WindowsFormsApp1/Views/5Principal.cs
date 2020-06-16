using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views
{
	public partial class _5Principal : Form
	{
		public _5Principal()
		{
			InitializeComponent();
		}

		private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new _6ListaUsuario().Show();
		}

		private void sairToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult resultado  = MessageBox.Show("Deseja sair?","Confirme", MessageBoxButtons.YesNo);
			if (resultado == DialogResult.Yes)
			{
				Close();
				Application.Exit();
			}
		}

		private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new Cadastro().Show();
		}
	}
}
