using AutoMapper;
using BestPracticeProject.Core.Models;
using BestPracticeProject.Core.Service;
using BestPracticesProject.API.DTO;
using BestPracticesProject.API.Filter;
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
    public class ProductsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IProductService _productService;


        public ProductsController(IProductService productService, IMapper mapper)

        {
            _productService = productService;
            _mapper = mapper;
        }
      
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _productService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<ProductDto>>(products));
        
        }
        [ServiceFilter(typeof(NotFoundFilter))]
        [HttpGet("{id}")]

        public async Task<IActionResult> GetById(int id)
        {
            var products = await _productService.GetByIdAsync(id);
            return Ok(_mapper.Map<ProductDto>(products));
          
        }
        [ServiceFilter(typeof(NotFoundFilter))]
        [HttpGet("{id}/katagori")]
        public async Task<IActionResult> GetWihtKatagoriById(int id)
        {
            var product = await _productService.GetWihtKatagoriByIdAsync(id);

            return Ok(_mapper.Map<ProductWithKatagoriDto>(product));
            
            
        }


        [ValidationFilter]
        [HttpPost]
        public async Task<IActionResult> Save(ProductDto productDto)
        {
            var newproduct = await _productService.AddAsync(_mapper.Map<Product>(productDto));
            return Created(string.Empty,_mapper.Map<ProductDto>(newproduct)); 

        }
        [HttpPut]
        public IActionResult Update(ProductDto productDto)
        {
            var product = _productService.Update(_mapper.Map<Product>(productDto));
            return NoContent();
        }
        [ServiceFilter(typeof(NotFoundFilter))]
        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var product = _productService.GetByIdAsync(id).Result;
            return NoContent();
        }
           

        

    }
}
