using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public EventoController()
        {
            
        }

        public IEnumerable<Evento> _evento = new Evento[]
        {
            new()
            {
                EventoId = 1,
                Tema = "Angular 11 e .NET 5",
                Local = "Araguaína - Tocantins",
                Lote = "1° Lote",
                QtdPessoas = 100,
                DataEvento = DateTime.Now.AddDays(5)
            },
            new()
            {
                EventoId = 2,
                Tema = "EF Core 5",
                Local = "Araguaína - Tocantins",
                Lote = "1° Lote",
                QtdPessoas = 50,
                DataEvento = DateTime.Now.AddDays(10)
            }
        };

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public Evento Get(int id)
        {
            return _evento
                        .Where(evento => evento.EventoId == id)
                        .First();
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de POST";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de PUT (id = {id})";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de DELETE (id = {id})";
        }
    }
}
