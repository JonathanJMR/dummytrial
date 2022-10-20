using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class TaskScheduler
    {
        private readonly List<Task> _tasks;

        #region Properties

        public List<Task> Tasks
        {
            get { return _tasks; }
        }

        public int Count
        {
            get
            {
                return _tasks.Count;
            }
        }

        #endregion

        #region Constructors

        public TaskScheduler()
        {
            _tasks = new List<Task>(); 
        }

        public TaskScheduler(List<Task>task)
        {
            _tasks = task;
        }

        #endregion

        #region Methods

        public List<Task> AddTask(Task newTask)
        {
            if(newTask == null)
            {
                return Tasks;
            }
            else
            {
                Tasks.Add(newTask);
                return Tasks;
            }
        }
        

        public void ClearScheduler()
        {
            this._tasks.Clear();
        }

        #endregion
    }
}
