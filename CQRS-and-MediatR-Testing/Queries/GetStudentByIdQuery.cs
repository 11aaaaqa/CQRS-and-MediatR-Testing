using CQRS_and_MediatR_Testing.Models;
using MediatR;

namespace CQRS_and_MediatR_Testing.Queries
{
    public class GetStudentByIdQuery : IRequest<StudentDetails>
    {
        public Guid Id { get; set; }
    }
}
