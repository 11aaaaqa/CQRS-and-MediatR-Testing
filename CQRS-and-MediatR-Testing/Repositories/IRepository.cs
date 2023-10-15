using CQRS_and_MediatR_Testing.Models;

namespace CQRS_and_MediatR_Testing.Repositories
{
    public interface IRepository<T>
    {
        public Task<List<T>> GetAllAsync();
        public Task<T> GetByIdAsync(Guid id);
        public Task AddAsync(T entity);
        public Task UpdateStudentAsync(T entity);
        public Task DeleteStudentAsync(Guid id);
    }
}
