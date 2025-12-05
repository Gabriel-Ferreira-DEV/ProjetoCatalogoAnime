

using AnimeApi.Infrastructure.Context;
using AnimeApi.Infrastructure.Repositories;
using AnimesApi.Domain.Interfaces;

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