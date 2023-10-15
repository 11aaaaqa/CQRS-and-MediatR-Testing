using CQRS_and_MediatR_Testing.Commands;
using CQRS_and_MediatR_Testing.Models;
using CQRS_and_MediatR_Testing.Repositories;
using MediatR;

namespace CQRS_and_MediatR_Testing.Handlers
{
    public class DeleteStudentHandler : IRequestHandler<DeleteStudentCommand>
    {
        private readonly IRepository<StudentDetails> repository;

        public DeleteStudentHandler(IRepository<StudentDetails> repository)
        {
            this.repository = repository;
        }
        public async Task Handle(DeleteStudentCommand command, CancellationToken cancellationToken)
        {
            await repository.DeleteStudentAsync(command.Id);
        }
    }
}
