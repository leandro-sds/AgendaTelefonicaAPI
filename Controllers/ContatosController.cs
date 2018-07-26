using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgendaTelefonicaAPI.Models.ContatoModel;
using AgendaTelefonicaAPI.Models.ServicesAPIModel;
using Microsoft.AspNetCore.Mvc;

namespace AgendaTelefonicaAPI.Controllers
{
	 [Route("api/[Controller]")]
    public class ContatosController : Controller
    {
		private readonly IServiceAPI _service;

		public ContatosController(IServiceAPI serviceAPI) {
			_service = serviceAPI;
		}

	   [HttpGet]
		public IEnumerable<Contato> GetAll() {
			return _service.GetAll();
		}

    }
}