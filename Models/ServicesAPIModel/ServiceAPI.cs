using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgendaTelefonicaAPI.Models.ContatoModel;

namespace AgendaTelefonicaAPI.Models.ServicesAPIModel
{
	public class ServiceAPI : IServiceAPI {

		private readonly ContatoDbContext _context;

		public ServiceAPI(ContatoDbContext context) {
			_context = context;
		}

		public void Add(Contato contato) {
			_context.Contatos.Add(contato);
			_context.SaveChanges();
		}

		public Contato Find(string nome) {
			return _context.Contatos.FirstOrDefault(u => u.Nome == nome);
		}

		public IEnumerable<Contato> GetAll() {
			return _context.Contatos.ToList();
		}

		public void Remove(string nome) {
			var contato = _context.Contatos.First(u => u.Nome == nome);
			_context.Contatos.Remove(contato);
			_context.SaveChanges();
		}

		public void Update(Contato contato) {
			_context.Contatos.Update(contato);
			_context.SaveChanges();
		}
	}
}
