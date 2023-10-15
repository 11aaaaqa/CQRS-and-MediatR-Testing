using CQRS_and_MediatR_Testing.Commands;
using CQRS_and_MediatR_Testing.Models;
using CQRS_and_MediatR_Testing.Repositories;
using MediatR;

namespace CQRS_and_MediatR_Testing.Queries
{
    public class CreateStudentHandler : IRequestHandler<CreateStudentCommand>
    {
        private readonly IRepository<StudentDetails> repository;

        public CreateStudentHandler(IRepository<StudentDetails> repository)
        {
            this.repository = repository;
        }
        public async Task Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            return await repository.AddAsync(new StudentDetails { StudentAddress = request.StudentAddress, StudentAge = request.StudentAge, StudentEmail = request.StudentEmail, StudentName = request.StudentName });
        }
    }
}
