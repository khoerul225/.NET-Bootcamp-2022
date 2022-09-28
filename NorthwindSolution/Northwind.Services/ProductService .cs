using AutoMapper;
using Northwind.Contracts.Dto.Category;
using Northwind.Contracts.Dto.Product;
using Northwind.Domain.Base;
using Northwind.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Northwind.Services
{
    public class ProductService : IProductService
    {
        //2 private dibawah kemudian di block kemudian ctrl + . (dot) generate constructor
        private IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        
        //defedency injection
        public ProductService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public void Edit(ProductDto productDto)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductDto>> GetAllProduct(bool trackChanges)
        {
            var productModel = await _repositoryManager.ProductRepository.GetAllProduct(trackChanges);
            //source = Product model, target Product Dto
            var productDto = _mapper.Map<IEnumerable<ProductDto>>(productModel);
            return productDto;
        }

        public Task<ProductDto> GetProductById(int productId, bool trackChanges)
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<ProductDto>> GetProductPaged(int pageIndex, int pageSize, bool trackChanges)
        {
            var productModel = await _repositoryManager
                .ProductRepository.GetProductPaged(pageIndex,pageSize,trackChanges);
                //source = Product model, target Product Dto
            var productDto = _mapper.Map<IEnumerable<ProductDto>>(productModel);
            return productDto;
        }
        public void Remove(ProductDto productDto)
        {
            throw new NotImplementedException();
        }

        public void Insert(ProductForCreateDto productForCreateDto)
        {
            throw new NotImplementedException();
        }
    }
}
