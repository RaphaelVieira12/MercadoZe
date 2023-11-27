using MercadoZe.Model;
using MercadoZe.View.TelasCliente;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoZe.Controller
{
	internal class ManipulaCliente
	{
	 public void  AdicionaCliente()
		{
			SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
			SqlCommand cmd = new SqlCommand("P_InserirClientes", cn);
			cmd.CommandType = System.Data.CommandType.StoredProcedure;

			try
			{
				cmd.Parameters.AddWithValue("@NomeCliente", Cliente.NomeCliente);
				cmd.Parameters.AddWithValue("@EmailCliente", Cliente.EmailCliente);
				cmd.Parameters.AddWithValue("@foneCliente", Cliente.FoneCliente);

				cn.Open();
				cmd.ExecuteNonQuery();

				MessageBox.Show("Cliente Cadastrado Com Sucesso.");
			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}
