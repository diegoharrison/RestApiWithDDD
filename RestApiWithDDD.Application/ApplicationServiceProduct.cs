using RestApiWithDDD.Application.Dtos;
using RestApiWithDDD.Application.Interfaces;
using RestApiWithDDD.Application.Interfaces.Mappers;
using RestApiWithDDD.Domain.Core.Interfaces.Services;

public class ApplicationServiceProduct : IApplicationServiceProduct
{
    private readonly IServiceProduct serviceProduct;
    private readonly IMapperProduct mapperProduct;

    public ApplicationServiceProduct(IServiceProduct serviceProduct, IMapperProduct mapperProduct)
    {
        this.serviceProduct = serviceProduct;
        this.mapperProduct = mapperProduct;
    }

    public void Add(ProductDto productDto)
    {
        var product = mapperProduct.MapperDtoToEntity(productDto);
        serviceProduct.Add(product);
    }

    public IEnumerable<ProductDto> GetAll()
    {
        var products = serviceProduct.GetAll();
        return mapperProduct.MapperListProductDto(products);
    }

    public ProductDto GetById(int id)
    {
        var product = serviceProduct.GetById(id);
        return mapperProduct.MapperEntityToDto(product);
    }

    public void Remove(ProductDto productDto)
    {
        var product = mapperProduct.MapperDtoToEntity(productDto);
        serviceProduct.Remove(product);
    }   

    public void Update(ProductDto productDto)
    {
        var product = mapperProduct.MapperDtoToEntity(productDto);
        serviceProduct.Update(product);
    }
}