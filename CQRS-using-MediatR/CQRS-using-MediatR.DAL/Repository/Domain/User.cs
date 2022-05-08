namespace CQRS_using_MediatR.Repository.Domain
{
    public class User
    {
        public int Id { get; init; }

        public string Name { get; init; }

        public bool IsDeleted { get; init; }
    }
}
