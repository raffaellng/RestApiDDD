namespace RestApiModeloDDD.Domain.Entitys
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool IsAtivo { get; set; } = true;
    }
}