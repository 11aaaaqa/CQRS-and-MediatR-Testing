using CQRS_and_MediatR_Testing.Models;
using CQRS_and_MediatR_Testing.Queries;
using CQRS_and_MediatR_Testing.Repositories;
using MediatR;

namespace CQRS_and_MediatR_Testing.Handlers
{
    public class GetStudentByIdHandler : IRequestHandler<GetStudentByIdQuery,StudentDetails>
    {
        private readonly IRepository<StudentDetails> repository;

        public GetStudentByIdHandler(IRepository<StudentDetails> repository)
        {
            this.repository = repository;
        }
        public async Task<StudentDetails> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken) => await repository.GetByIdAsync(request.Id);
        
    }
}
