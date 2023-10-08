using CQRS_and_MediatR_Testing.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentDetails = CQRS_and_MediatR_Testing.Models.StudentDetails;

namespace CQRS_and_MediatR_Testing.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<StudentDetails> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<StudentDetails>().HasData(new StudentDetails
            {
                Id = new Guid("4d8fcf42-6539-4286-a9cf-3cbc8063fa10"),
                StudentAddress = "testAddress",
                StudentAge = 20,
                StudentEmail = "mail@mail.com",
                StudentName = "Aleksandr"
            });
        }
    }
}
