using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationAPI.Business.Repository;
using WebApplicationAPI.Model.Domain;

namespace WebApplicationAPI.Controllers
{
    [ApiController]
    //[Route("api/[controller]")]
    public class ProductController
    {
        IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        [Route("GetListProduct")]
        public async Task<IEnumerable<Product>> Get()
        {
            var result = _productRepository.GetListProduct();
            return await Task.FromResult(result);
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> GetAll()
        {
            var result = _productRepository.GetListProduct();
            return await Task.FromResult(result);
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> GetAllList()
        {
            var result = _productRepository.GetListProduct();
            return await Task.FromResult(result);
        }


    }
}
