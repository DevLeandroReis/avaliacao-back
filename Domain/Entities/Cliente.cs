namespace ClienteApi.Domain.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Porte { get; set; } // Pequena, Média, Grande
    }
}