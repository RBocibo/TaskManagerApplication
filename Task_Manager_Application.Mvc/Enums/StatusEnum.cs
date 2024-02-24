using System.ComponentModel.DataAnnotations;

namespace Task_Manager_Application.Mvc.Enums
{
    public enum StatusEnum
    {
        [Display(Name = "To Do")]
        To_Do = 1,
        [Display(Name = "In Progress")]
        In_Progress = 2,
        [Display(Name = "Blocked")]
        Blocked = 3,
        [Display(Name = "Completed")]
        Complete = 4,
    }
}
