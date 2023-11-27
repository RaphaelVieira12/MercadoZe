using MercadoZe.Controller;
using MercadoZe.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadoZe.View.TelasCliente
{
	public partial class CadastroCliente : Form
	{
		public CadastroCliente()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void Bnt_Cadastro_Click(object sender, EventArgs e)
		{
			Cliente.NomeCliente = txtNomeCliente.Text;
			Cliente.EmailCliente = TxtEmailCliente.Text;
			Cliente.FoneCliente = NumeroCelular.Text;

			ManipulaCliente manipulaCliente = new ManipulaCliente();
			manipulaCliente.AdicionaCliente();
		}
	}
}
