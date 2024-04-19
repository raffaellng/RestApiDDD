using RestApiModeloDDD.Application.Dtos;

namespace RestApiModeloDDD.Application.Interfaces
{
    public interface IApplicationServiceClientes
    {
        void Add(ClienteDto clienteDto);

        void Update(ClienteDto clienteDto);

        void Remove(ClienteDto clienteDto);

        IEnumerable<ClienteDto> GetAll();

        ClienteDto Get(int id);
    }
}