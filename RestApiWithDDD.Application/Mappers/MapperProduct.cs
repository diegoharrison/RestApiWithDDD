using RestApiWithDDD.Application.Dtos;
using RestApiWithDDD.Application.Interfaces.Mappers;
using RestApiWithDDD.Domain;

namespace RestApiWithDDD.Application.Mappers
{
    public class MapperProduct : IMapperProduct
    {
        IEnumerable<ProductDto> productsDto = new List<ProductDto>();

        public Product MapperDtoToEntity(ProductDto productDto)
        {
            var product = new Product()
            {
                Id = productDto.Id,
                Name = productDto.Name,
                Value = productDto.Value,
            };

            return product;
        }

        public ProductDto MapperEntityToDto(Product product)
        {
            var productDto = new ProductDto()
            {
                Id = product.Id,
                Name = product.Name,
                Value = product.Value
            };

            return productDto;
        }

        public IEnumerable<ProductDto> MapperListProductDto(IEnumerable<Product> products)
        {
            var dto = products.Select(c => new ProductDto
            {
                Id = c.Id,
                Name = c.Name,
                Value = c.Value
            });

            return dto;
        }
    }
}
