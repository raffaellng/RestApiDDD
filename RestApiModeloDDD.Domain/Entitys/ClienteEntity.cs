namespace RestApiModeloDDD.Domain.Entitys
{
    public class ClienteEntity : BaseEntity
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataNacimento { get; set; }
    }
}