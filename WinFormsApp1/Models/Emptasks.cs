using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WinFormsApp1.Models
{
    public class Emptasks
    {
        public int Id { get; set; }
        public BindingList<TaskItem> tasks { get; set; }
    }
}
