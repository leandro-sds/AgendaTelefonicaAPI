using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaTelefonicaAPI.Models.ContatoModel
{
    public class Contato
    {
		public int id { get; set; }
		public string Nome { get; set; }
		public string Telefone { get; set; }
		public string Email { get; set; }
	}
}
