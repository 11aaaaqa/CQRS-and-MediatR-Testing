using CQRS_and_MediatR_Testing.Commands;
using CQRS_and_MediatR_Testing.Models;
using CQRS_and_MediatR_Testing.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CQRS_and_MediatR_Testing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IMediator mediator;

        public StudentController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<StudentDetails>>> GetAllStudentsAsync()
        {
            var students = await mediator.Send(new GetStudentListQuery());
            return Ok(students);
        }

        [HttpGet("id")]
        public async Task<ActionResult<StudentDetails>> GetStudentByIdAsync(Guid id)
        {
            if (ModelState.IsValid)
            {
                var student = await mediator.Send(new GetStudentByIdQuery(id));
                return Ok(student);
            }
            return BadRequest();
        }

        [HttpPost]
        public async Task<ActionResult> AddStudentAsync(StudentDetails student)
        {
            if (ModelState.IsValid)
            {
                await mediator.Send(new CreateStudentCommand(student.StudentName, student.StudentEmail,
                    student.StudentAddress, student.StudentAge));
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteStudentAsync(Guid id)
        {
            if (ModelState.IsValid)
            {
                await mediator.Send(new DeleteStudentCommand(id));
                return Ok();
            }

            return BadRequest();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateStudentAsync(StudentDetails student)
        {
            if (ModelState.IsValid)
            {
                await mediator.Send(new UpdateStudentCommand(student.Id,student.StudentName,student.StudentEmail,student.StudentAddress,student.StudentAge));
                return Ok();
            }
            return BadRequest();
        }
    }
}
