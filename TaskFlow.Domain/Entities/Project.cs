using TaskFlow.Domain.Common;

namespace TaskFlow.Domain.Entities
{
    public class Project : BaseEntity
    {
        public string Name { get; private set; }
        public Guid OwnerId { get; private set; }

        private Project() { }

        public Project(string name, Guid ownerId)
        {
            Name = name;
            OwnerId = ownerId;
        }
    }
}