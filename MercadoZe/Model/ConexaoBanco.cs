using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoZe.Model
{
	internal class ConexaoBanco
	{
		public static string conectar()
		{
			return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\henrique.afsilva1\source\repos\MercadoZe\MercadoZe\BancoDeDados\mercadobd.mdf;Integrated Security=True";
		}
	}
}

