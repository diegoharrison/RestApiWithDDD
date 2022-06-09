using RestApiWithDDD.Application.Dtos;
using RestApiWithDDD.Domain;

namespace RestApiWithDDD.Application.Interfaces.Mappers
{
    public interface IMapperProduct
    {
        Product MapperDtoToEntity(ProductDto productDto);
        IEnumerable<ProductDto> MapperListProductDto(IEnumerable<Product> products);
        ProductDto MapperEntityToDto(Product product);
    }
}
