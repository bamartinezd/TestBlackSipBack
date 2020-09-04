using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestBlackSip.Domain.Contracts;
using TestBlackSipBack.Domain.Entities;
using TestBlackSipBack.Services.Dto;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestBlackSipBack.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroController : ControllerBase
    {
        private readonly IGenericCUDRepository<Registro> _registroRepository;
        private readonly IMapper _mapper;

        public RegistroController(IGenericCUDRepository<Registro> registroRepository, IMapper mapper) {
            this._registroRepository = registroRepository;
            this._mapper = mapper;
        }

        /// <summary>
        /// Insert a new record
        /// </summary>
        /// <param name="value"></param>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<RegistroDTO> Post([FromBody] RegistroDTO registro)
        {
            try
            {
                var newReg = _registroRepository.Add(_mapper.Map<Registro>(registro));
                if (newReg == null)
                {
                    return BadRequest();
                }

                return CreatedAtAction(nameof(Post), _mapper.Map<RegistroDTO>(newReg));
            }
            catch (Exception e)
            {
                return BadRequest(new { error= e.Message});
            }
        }
    }
}
