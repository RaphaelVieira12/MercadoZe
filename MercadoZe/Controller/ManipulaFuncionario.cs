using MercadoZe.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MercadoZe.Controller
{
	internal class ManipulaFuncionario
	{
		public void AdicionarFuncionario()
		{
			SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
			SqlCommand cmd = new SqlCommand("P_InserirClientes", cn);
			cmd.CommandType = System.Data.CommandType.StoredProcedure;

			try
			{
				cmd.Parameters.AddWithValue("@NomeFuncionario", Funcionario.NomeFunci);
				cmd.Parameters.AddWithValue("@EmailFuncionario", Funcionario.EmailFunci);
				cmd.Parameters.AddWithValue("@FoneFuncionario", Funcionario.FoneFunci);


			
			}
			catch (Exception) {

				throw;
			}
		}
	}
}
