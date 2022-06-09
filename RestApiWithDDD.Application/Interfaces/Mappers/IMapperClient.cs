using RestApiWithDDD.Application.Dtos;
using RestApiWithDDD.Domain;

namespace RestApiWithDDD.Application.Interfaces.Mappers
{
    public interface IMapperClient
    {
        Client MapperDtoToEntity(ClientDto clientDto);
        IEnumerable<ClientDto> MapperListClientsDto(IEnumerable<Client> clients);
        ClientDto MapperEntityToDto(Client client);
    }
}
