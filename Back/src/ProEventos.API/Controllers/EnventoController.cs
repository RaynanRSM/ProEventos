using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EnventoController : ControllerBase
    {
        public IEnumerable <Evento> _evento = new Evento[]{
                new Evento() {

                EnventoId = 1,
                Tema = "ANGULA E .NET",
                Local = "BELO HORIZONTE",
                Lote = "1º LOTE",
                QtdPessoas =  250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemURL = "Fota.png"               
            },
                 new Evento(){

                EnventoId = 2,
                Tema = "ANGULA E E SUAS NOVIDADES",
                Local = "SÃO PAULO",
                Lote = "2º LOTE",
                QtdPessoas =  350,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                ImagemURL = "Fota.png"
            }
       
        };

        public EnventoController()
        {
           
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
         return _evento;
    }

    public class Envento
    {
    }
    }
}

