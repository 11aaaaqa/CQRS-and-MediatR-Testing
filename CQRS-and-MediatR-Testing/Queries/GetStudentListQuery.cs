using CQRS_and_MediatR_Testing.Models;
using MediatR;

namespace CQRS_and_MediatR_Testing.Queries
{
    public class GetStudentListQuery : IRequest<List<StudentDetails>>
    {
    }
}
