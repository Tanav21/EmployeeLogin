using System;
using System.ComponentModel;

namespace WinFormsApp1.Models
{
    public class TaskItem : INotifyPropertyChanged
    {
        private int _taskId;
        private int _userId;
        private string _description = string.Empty;
        private bool _isCompleted;
        private DateTime _createdOn;
        private DateTime _updatedOn;

        public int TaskId
        {
            get => _taskId;
            set
            {
                if (_taskId != value)
                {
                    _taskId = value;
                    OnPropertyChanged(nameof(TaskId));
                }
            }
        }

        public int UserId
        {
            get => _userId;
           
        }

        public string Description
        {
            get => _description;
            set
            {
                if (_description != value)
                {
                    _description = value;
                    OnPropertyChanged(nameof(Description));
                }
            }
        }

        public bool IsCompleted
        {
            get => _isCompleted;
            set
            {
                if (_isCompleted != value)
                {
                    _isCompleted = value;
                    OnPropertyChanged(nameof(IsCompleted));
                }
            }
        }

        public DateTime CreatedOn
        {
            get => _createdOn;
            set
            {
                if (_createdOn != value)
                {
                    _createdOn = value;
                    OnPropertyChanged(nameof(CreatedOn));
                }
            }
        }

        public DateTime UpdatedOn
        {
            get => _updatedOn;
            set
            {
                if (_updatedOn != value)
                {
                    _updatedOn = value;
                    OnPropertyChanged(nameof(UpdatedOn));
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
