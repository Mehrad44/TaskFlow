
using TaskFlow.Domain.Common;
using TaskFlow.Domain.Enums;
namespace TaskFlow.Domain.Entities
{

     public class TaskItem : BaseEntity
    {
        public string Title { get; private set; } = null!;
        public string Description { get; private set; } = null!;
        public WorkStatus Status { get; private set; }
        public Guid ProjectId { get; private set; }

        private TaskItem() { }

        public TaskItem(string title, string description, Guid projectId)
        {
            Title = title;
            Description = description;
            ProjectId = projectId;
            Status = WorkStatus.Todo;
        }

        public void MoveTo(WorkStatus status)
        {
            Status = status;
        }
    }
}