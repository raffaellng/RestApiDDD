namespace RestApiModeloDDD.Application.Dtos
{
    public class ClienteDto : BaseDtos
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
    }
}