namespace RestApiModeloDDD.Application.Dtos
{
    public class ProdutoDto : BaseDtos
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }
    }
}