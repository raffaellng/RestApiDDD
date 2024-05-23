using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Interfaces.Mappers;
using RestApiModeloDDD.Domain.Entitys;

namespace RestApiModeloDDD.Application.Mappers
{
    public class MapperProduto : IMapperProduto
    {
        public ProdutoEntity MapperDtoToEntity(ProdutoDto produtoDto)
        {
            ProdutoEntity produtoEntity = new ProdutoEntity()
            {
                Id = produtoDto.Id,
                Nome = produtoDto.Nome,
                Quantidade = produtoDto.Quantidade,
                Valor = produtoDto.Valor,
                Disponivel = produtoDto.Disponivel
            };
            return produtoEntity;
        }

        public ProdutoDto MapperEntityToDto(ProdutoEntity produtoEntity)
        {
            ProdutoDto produtoDto = new ProdutoDto()
            {
                Id = produtoEntity.Id,
                Nome = produtoEntity.Nome,
                Quantidade = produtoEntity.Quantidade,
                Valor = produtoEntity.Valor,
                Disponivel = produtoEntity.Disponivel
            };

            return produtoDto;
        }

        public IEnumerable<ProdutoDto> MapperListProdutoDto(IEnumerable<ProdutoEntity> listProdutos)
        {
            var dto = listProdutos.Select(x => new ProdutoDto()
            {
                Id = x.Id,
                Nome = x.Nome,
                Quantidade = x.Quantidade,
                Valor = x.Valor,
                Disponivel = x.Disponivel
            });

            return dto;
        }
    }
}