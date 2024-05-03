using Convey.CQRS.Commands;

namespace MiniSpace.Services.MediaFiles.Application.Commands
{
    public class DeleteStudent : ICommand
    {
        public Guid StudentId { get; }

        public DeleteStudent(Guid studentId) => StudentId = studentId;
    }    
}
