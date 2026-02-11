using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Models
{
    public class TaskItem
    {
        public int TaskId { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; } = string.Empty;
        public bool IsCompleted { get; set; }
        public DateTime CreatedOn { get; set; } 
        public DateTime UpdatedOn { get; set; }
    }
}
