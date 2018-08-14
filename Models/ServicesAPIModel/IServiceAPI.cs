using AgendaTelefonicaAPI.Models.ContatoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaTelefonicaAPI.Models.ServicesAPIModel
{
    public interface IServiceAPI
    {
		void Add(Contato contato);

		IEnumerable<Contato> GetAll();

		Contato Find(int id);

		void Remove(string nome);

		void Update(Contato contato);
	}
}
