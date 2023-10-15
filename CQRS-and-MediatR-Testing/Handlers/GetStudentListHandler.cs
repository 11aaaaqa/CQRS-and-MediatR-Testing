using CQRS_and_MediatR_Testing.Models;
using CQRS_and_MediatR_Testing.Queries;
using CQRS_and_MediatR_Testing.Repositories;
using MediatR;

namespace CQRS_and_MediatR_Testing.Handlers
{
    public class GetStudentListHandler : IRequestHandler<GetStudentListQuery,List<StudentDetails>>
    {
        private readonly IRepository<StudentDetails> repository;

        public GetStudentListHandler(IRepository<StudentDetails> repository)
        {
            this.repository = repository;
        }
        public async Task<List<StudentDetails>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            return await repository.GetAllAsync();
        }
    }
}
