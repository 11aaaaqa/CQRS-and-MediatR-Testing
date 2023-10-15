using CQRS_and_MediatR_Testing.Commands;
using CQRS_and_MediatR_Testing.Models;
using CQRS_and_MediatR_Testing.Repositories;
using MediatR;

namespace CQRS_and_MediatR_Testing.Handlers
{
    public class CreateStudentHandler : IRequestHandler<CreateStudentCommand>
    {
        private readonly IRepository<StudentDetails> repository;

        public CreateStudentHandler(IRepository<StudentDetails> repository)
        {
            this.repository = repository;
        }
        public async Task Handle(CreateStudentCommand command, CancellationToken cancellationToken)
        {
            var student = new StudentDetails
            {
                StudentAddress = command.StudentAddress,
                StudentAge = command.StudentAge,
                StudentEmail = command.StudentEmail,
                StudentName = command.StudentName
            };

            await repository.AddAsync(student);
        }
    }
}
