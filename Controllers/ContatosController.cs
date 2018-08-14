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

		[HttpGet("{id}", Name = "GetContato")]
		public IActionResult GetById(int id) {
			var contato = _service.Find(id);
			if(contato.Equals(null)) {
				return NotFound();
			}

			return new ObjectResult(contato);
		}

		[HttpPost]
		public IActionResult AddContato([FromBody] Contato contato) {
			if(contato.Equals(null)) {
				return BadRequest();
			} else {
				_service.Add(contato);

				return CreatedAtRoute("GetContato", new { contato.id }, contato);
			}
		}

    }
}