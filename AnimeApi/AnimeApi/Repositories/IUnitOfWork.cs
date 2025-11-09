namespace AnimesApi.Repositories
{
    public interface IUnitOfWork
    {
        IAnimesRepository AnimesRepository{ get; }

        Task CommitAsync();
    }
}
