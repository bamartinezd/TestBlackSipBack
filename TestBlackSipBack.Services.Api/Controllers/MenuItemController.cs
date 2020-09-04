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
    public class MenuItemController : ControllerBase
    {
        private readonly IGenericGetRepository<MenuItem> _menuItemRepository;
        private readonly IMapper _mapper;

        public MenuItemController(IGenericGetRepository<MenuItem> menuItemRepository, IMapper mapper)
        {
            this._menuItemRepository = menuItemRepository;
            this._mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<MenuItemDTO>>> Get()
        {
            try
            {
                var menuItems = await _menuItemRepository.GetAllAsync();
                return Ok(_mapper.Map<List<MenuItemDTO>>(menuItems));
            }
            catch (Exception e)
            {
                return BadRequest(new { error = e.Message });
            }
            
        }
    }
}
