namespace RestApiModeloDDD.Domain.Entitys
{
    public class ProdutoEntity : BaseEntity
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }
    }
}