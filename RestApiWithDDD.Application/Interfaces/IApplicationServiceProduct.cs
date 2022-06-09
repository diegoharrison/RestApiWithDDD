using RestApiWithDDD.Application.Dtos;

namespace RestApiWithDDD.Application.Interfaces
{
    public interface IApplicationServiceProduct
    {
        void Add(ProductDto clientDto);
        void Update(ProductDto clientDto);
        void Remove(ProductDto clientDto);
        IEnumerable<ProductDto> GetAll();
        ProductDto GetById(int id);
    }
}
