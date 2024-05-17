using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Interfaces;
using RestApiModeloDDD.Application.Interfaces.Mappers;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using RestApiModeloDDD.Domain.Entitys;

namespace RestApiModeloDDD.Application
{
    public class ApplicationServiceCliente : IApplicationServiceClientes
    {
        private readonly IServiceCliente _serviceCliente;
        private readonly IMapperCliente _mapperCliente;

        public ApplicationServiceCliente(IServiceCliente serviceCliente, IMapperCliente mapperCliente)
        {
            this._serviceCliente = serviceCliente;
            this._mapperCliente = mapperCliente;
        }

        public void Add(ClienteDto clienteDto)
        {
            ClienteEntity clienteEntity = _mapperCliente.MapperDtoToEntity(clienteDto);
            _serviceCliente.Add(clienteEntity);
        }

        public ClienteDto Get(int id)
        {
            ClienteEntity cliente = _serviceCliente.GetById(id);
            return _mapperCliente.MapperEntityToDto(cliente);
        }

        public IEnumerable<ClienteDto> GetAll()
        {
            IEnumerable<ClienteEntity> clientes = _serviceCliente.GetAll();
            return _mapperCliente.MapperListClienteDto(clientes);
        }

        public void Remove(ClienteDto clienteDto)
        {
            ClienteEntity clienteEntity = _mapperCliente.MapperDtoToEntity(clienteDto);
            _serviceCliente.Delete(clienteEntity);
        }

        public void Update(ClienteDto clienteDto)
        {
            ClienteEntity clienteEntity = _mapperCliente.MapperDtoToEntity(clienteDto);
            _serviceCliente.Update(clienteEntity);
        }
    }
}