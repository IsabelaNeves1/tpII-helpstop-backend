using AutoMapper;
using HelpApp.Application.DTOs;
using HelpApp.Application.Interfaces;
using HelpApp.Domain.Entities;
using HelpApp.Domain.Interfaces;
using HelpApp.Infra.Data.Repositories;

namespace HelpApp.Application.Services
{
    public class ProductServices : IProductService
    {
        private IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductServices(IProductRepository productRepository, IMapper mapper)
        {
            ProductRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductDTO>> GetProducts()
        {
            var productsEntity = await _productRepository.GetProducts();
            return _mapper.Map<IEnumerable<ProductDTO>>(productsEntity);
        }

        public async Task<ProductDTO> GetById(int? id)
        {
            var productsEntity = await _productRepository.GetById(id);
            return _mapper.Map<ProductDTO>(productsEntity);
        }

        public async Task Add(ProductDTO productDTO)
        {
            var productsEntity = _mapper.Map<Product>(productDTO);
            await _productRepository.Create(productsEntity);
        }

        public async Task Update(ProductDTO categoryDTO)
        {
            var productsEntity = _mapper.Map<Product>(categoryDTO);
            await _productRepository.Update(productsEntity);
        }

        public async Task Remove(int? id)
        {
            var productsEntity = _productRepository.GetById(id).Result;
            await _productRepository.Remove(productsEntity);
        }
    }
}

