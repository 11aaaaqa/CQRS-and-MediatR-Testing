using CQRS_and_MediatR_Testing.Models;
using MediatR;

namespace CQRS_and_MediatR_Testing.Commands
{
    public class CreateStudentCommand : IRequest
    {
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }
        public string StudentAddress { get; set; }
        public uint StudentAge { get; set; }
        public CreateStudentCommand(string studentName, string studentEmail, string studentAddress, uint studentAge)
        {
            StudentName = studentName;
            StudentEmail = studentEmail;
            StudentAddress = studentAddress;
            StudentAge = studentAge;
        }
    }
}
