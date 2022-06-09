using RestApiWithDDD.Application.Dtos;
using RestApiWithDDD.Application.Interfaces.Mappers;
using RestApiWithDDD.Domain;

namespace RestApiWithDDD.Application.Mappers
{
    public class MapperClient : IMapperClient
    {
        public Client MapperDtoToEntity(ClientDto clientDto)
        {
            var client = new Client()
            {
                Id = clientDto.Id,
                Name = clientDto.Name,
                LastName = clientDto.LastName,
                Email = clientDto.Email,
            };

            return client;
        }

        public ClientDto MapperEntityToDto(Client client)
        {
            var clientDto = new ClientDto()
            {
                Id = client.Id,
                Name = client.Name,
                LastName = client.LastName,
                Email = client.Email
            };

            return clientDto;
        }

        public IEnumerable<ClientDto> MapperListClientsDto(IEnumerable<Client> clients)
        {
            var dto = clients.Select(c => new ClientDto
            {
                Id = c.Id,
                Name = c.Name,
                LastName = c.LastName,
                Email = c.Email
            });

            return dto;
        }   
    }
}
