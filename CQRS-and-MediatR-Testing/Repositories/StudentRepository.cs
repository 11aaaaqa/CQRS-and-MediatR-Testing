using CQRS_and_MediatR_Testing.Data;
using CQRS_and_MediatR_Testing.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRS_and_MediatR_Testing.Repositories
{
    public class StudentRepository : IRepository<StudentDetails>
    {
        private readonly AppDbContext context;

        public StudentRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<List<StudentDetails>> GetAllAsync() => await context.Students.ToListAsync();

        public async Task<StudentDetails?> GetByIdAsync(Guid id)
        {
            var student = await context.Students.SingleOrDefaultAsync(x => x.Id == id);
            if (student == null) throw new ArgumentException("Incorrect student ID");
            return student;
        } 

        public async Task AddAsync(StudentDetails entity)
        {
            if (await context.Students.FirstOrDefaultAsync(x => x.Id == entity.Id) == null)
            {
                context.Students.Add(entity);
                await context.SaveChangesAsync();
            }
        }

        public async Task UpdateStudentAsync(StudentDetails entity)
        {
            context.Students.Update(entity);
            await context.SaveChangesAsync();
        }

        public async Task DeleteStudentAsync(Guid id)
        {
            context.Students.Remove(new StudentDetails { Id = id });
            await context.SaveChangesAsync();
        }
    }
}
