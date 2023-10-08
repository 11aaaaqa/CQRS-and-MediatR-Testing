namespace CQRS_and_MediatR_Testing.Models
{
    public class StudentDetails
    {
        public Guid Id { get; set; }
        public string StudentName { get; set; }
        public string StudentEmail { get; set;}
        public string StudentAddress { get; set;}
        public uint StudentAge { get; set; }
    }
}
