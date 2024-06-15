namespace ClienteApi.Application.Queries
{
    public class GetClienteByIdQuery
    {
        public int Id { get; set; }

        public GetClienteByIdQuery(int id)
        {
            Id = id;
        }
    }
}