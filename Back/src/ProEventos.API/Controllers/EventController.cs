using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        private readonly DataContext _context;

        public EventController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Events> Get()
        {
            return _context.Events;
        }


        [HttpGet]
        [Route("/GetById")]
        public Events GetById(int id)
        {
            return _context.Events.FirstOrDefault(x => x.EventId == id);

        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }

        [HttpPut]
        [Route("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Post com id = {id}";
        }

        [HttpDelete]
        [Route("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete com id = {id}";
        }
    }
}
