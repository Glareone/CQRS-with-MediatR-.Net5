namespace CQRS_using_MediatR.Repository.Domain
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsCompleted { get; set; }
    }
}
