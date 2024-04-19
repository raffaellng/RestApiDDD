using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Interfaces.Mappers;
using RestApiModeloDDD.Domain.Entitys;

namespace RestApiModeloDDD.Application.Mappers
{
    public class MapperCliente : IMapperCliente
    {
        public ClienteEntity MapperDtoToEntity(ClienteDto clienteDto)
        {
            ClienteEntity clienteEntity = new ClienteEntity()
            {
                Id = clienteDto.Id,
                Nome = clienteDto.Nome,
                Sobrenome = clienteDto.Sobrenome,
                Email = clienteDto.Email
            };

            return clienteEntity;
        }

        public ClienteDto MapperEntityToDto(ClienteEntity clienteEntity)
        {
            ClienteDto clienteDtos = new ClienteDto()
            {
                Id = clienteEntity.Id,
                Nome = clienteEntity.Nome,
                Sobrenome = clienteEntity.Sobrenome,
                Email = clienteEntity.Email
            };
            return clienteDtos;
        }

        public IEnumerable<ClienteDto> MapperListClienteDto(IEnumerable<ClienteEntity> listClientes)
        {
            var dto = listClientes.Select(x => new ClienteDto
            {
                Id = x.Id,
                Nome = x.Nome,
                Sobrenome = x.Sobrenome,
                Email = x.Email
            });

            return dto;
        }
    }
}