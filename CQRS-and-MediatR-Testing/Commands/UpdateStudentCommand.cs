using MediatR;

namespace CQRS_and_MediatR_Testing.Commands
{
    public class UpdateStudentCommand : IRequest
    {
        public Guid Id { get; set; }
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }
        public string StudentAddress { get; set; }
        public uint StudentAge { get; set; }

        public UpdateStudentCommand(Guid id, string studentName, string studentEmail, string studentAddress, uint studentAge)
        {
            Id = id;
            StudentName = studentName;
            StudentEmail = studentEmail;
            StudentAddress = studentAddress;
            StudentAge = studentAge;
        }
    }
}
