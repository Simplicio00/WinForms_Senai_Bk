using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class SplashForm : Form
	{
		public SplashForm()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
		}

		private void SplashForm_Load(object sender, EventArgs e)
		{

		}

		private int contador = 0;


		private void label1_Click(object sender, EventArgs e)
		{
			
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			contador++;
			labelContagem.Text = contador.ToString();
			if (contador == 5)
			{
				labelContagem.Enabled = false;
				Hide();
				new Form1().ShowDialog();
				Close();
			}
		}
	}
}
