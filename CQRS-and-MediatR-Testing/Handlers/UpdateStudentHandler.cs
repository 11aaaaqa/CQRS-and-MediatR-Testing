using CQRS_and_MediatR_Testing.Commands;
using CQRS_and_MediatR_Testing.Models;
using CQRS_and_MediatR_Testing.Repositories;
using MediatR;

namespace CQRS_and_MediatR_Testing.Handlers
{
    public class UpdateStudentHandler : IRequestHandler<UpdateStudentCommand>
    {
        private readonly IRepository<StudentDetails> repository;

        public UpdateStudentHandler(IRepository<StudentDetails> repository)
        {
            this.repository = repository;
        }
        public async Task Handle(UpdateStudentCommand command, CancellationToken token)
        {
            var updatedStudent = new StudentDetails
            { 
                Id = command.Id,
                StudentName = command.StudentName, 
                StudentEmail = command.StudentEmail,
                StudentAddress = command.StudentAddress,
                StudentAge = command.StudentAge
            };

            await repository.UpdateStudentAsync(updatedStudent);
        }
    }
}
