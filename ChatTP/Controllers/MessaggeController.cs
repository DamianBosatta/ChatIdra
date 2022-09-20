using AutoMapper;
using ChatTP.DTO.Request;
using ChatTP.DTO.Response;
using ChatTP.Models;
using ChatTP.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ChatTP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessaggeController : Controller
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public MessaggeController(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Messagge>>> GetMessages()
        {
            if (_uow.MessaggeRepository == null)
            {
                return NotFound();
            }

           var aux = _uow.MessaggeRepository.GetAll();
          
            return Ok(aux);
        }

     
        [HttpGet("{id}")]
        public async Task<ActionResult<Messagge>> GetMessage(int id)
        {
            if (_uow.MessaggeRepository == null)
            {
                return NotFound();
            }
            var message = _uow.MessaggeRepository.GetById(id);

            if (message == null)
            {
                return NotFound();
            }

            return message;
        }
        [HttpPost]
        public ActionResult PostMessagge([FromBody] MessaggeRequest msj)
        {
            Messagge mensaje = _mapper.Map<Messagge>(msj);
            _uow.MessaggeRepository.Insert(mensaje);
            _uow.Save();
            return Ok();
        }





    
    }
}
