using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Domain.Entitys;

namespace RestApiModeloDDD.Application.Interfaces.Mappers
{
    public interface IMapperProduto
    {
        ProdutoEntity MapperDtoToEntity(ProdutoDto produtoDto);

        IEnumerable<ProdutoDto> MapperListProdutoDto(IEnumerable<ProdutoEntity> listProdutos);

        ProdutoDto MapperEntityToDto(ProdutoEntity produtoEntity);
    }
}