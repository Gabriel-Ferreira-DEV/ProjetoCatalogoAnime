namespace AnimesApi.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IAnimesRepository AnimesRepository{ get; }

        Task CommitAsync();
    }
}
