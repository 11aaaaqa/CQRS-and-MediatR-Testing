using MediatR;

namespace CQRS_and_MediatR_Testing.Commands
{
    public class DeleteStudentCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
