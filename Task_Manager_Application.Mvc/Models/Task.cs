using Task_Manager_Application.Mvc.Enums;

namespace Task_Manager_Application.Mvc.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public PriorityEnum Priority { get; set; }
        public StatusEnum Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime DateCompleted { get; set; }
        public string PersonNames { get; set; }
    }
}
