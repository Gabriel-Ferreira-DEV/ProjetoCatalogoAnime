using AnimeApi.Context;
using AnimesApi.Repositories;

namespace AlunosApi.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {

        private IAnimesRepository? _animesRepositoryRepo;

        private readonly AppDbContext _context;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public IAnimesRepository AnimesRepository
        { 
            get => _animesRepositoryRepo = _animesRepositoryRepo ?? new AnimesRepository(_context);
        }

    
        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }

}