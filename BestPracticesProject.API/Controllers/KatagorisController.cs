using AutoMapper;
using BestPracticeProject.Core.Models;
using BestPracticeProject.Core.Service;
using BestPracticesProject.API.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestPracticesProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KatagorisController : ControllerBase
    {
        private readonly IKatagoriService _katagoriService;
        private readonly IMapper _mapper;
        public KatagorisController(IKatagoriService katagoriService, IMapper mapper)
        {
            _katagoriService = katagoriService;
            _mapper = mapper;

        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var katagoris = await _katagoriService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<KatagoriDto>>(katagoris));
        }

        [HttpGet("{id}")]
            
        public async Task<IActionResult>GetById(int id)
        {
            var katagori = await _katagoriService.GetByIdAsync(id);
            return Ok(_mapper.Map<KatagoriDto>(katagori));
        }

        [HttpGet("{id}/products")]
        public async Task<IActionResult> GetWithProductsById(int id)
        {
            var katagori = await _katagoriService.GetWithProductsByIdAsync(id);

            return Ok(_mapper.Map<KatagoriWithProductDto>(katagori));

        }


        [HttpPost]

        public async Task<IActionResult> Save(KatagoriDto katagoriDto)
        {
            var newKatagori = await _katagoriService.AddAsync(_mapper.Map<Katagori>(katagoriDto));

            return Created(string.Empty, _mapper.Map<KatagoriDto>(newKatagori));
        }
        [HttpPut]
        public IActionResult Update(KatagoriDto katagoriDto)
        {
            var katagori = _katagoriService.Update(_mapper.Map<Katagori>(katagoriDto));
            return NoContent();

        }

        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var katagori = _katagoriService.GetByIdAsync(id).Result;
            _katagoriService.Remove(katagori);

            return NoContent();
        }


        



    }

  
}
