using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Task
    {
        #region Backing Fields

        private string _summary;
        private string _details;
        private DateTime _dueDate;
        private bool _completed;

        #endregion

        #region Properties

        public string Summary
        {
            get { return _summary; }
            set
            {
                if(value == null || value == "")
                {
                    throw new ArgumentNullException("The value was not set.","value");
                }
                else
                {
                    this._summary = value;
                }
                    
            }

        }

        public string Details
        {
            get { return _details; }
            set
            {
                if (value == null)
                    this._details = "";

            }
            
        }

        public DateTime DueDate
        {
            get { return _dueDate; }
            set
            {
                if (value < DateTime.Now.AddDays(-30))
                {
                    throw new ArgumentException("The object cannot older than a month", "Due Date");
                }
                else
                {
                    this.DueDate = value;
                }
            }
        }

        public bool IsCompleted
        {
            get { return _completed; }
            set
            {
                this._completed = value;
            }

        }

        public bool IsOverdue
        {
            get { return (DateTime.Now > DueDate); } 
        }

        public string Info
        {
            get { return $"Task: {Summary} - Due Date: {DueDate} - {IsCompleted} - {IsOverdue}"; }
        }

        #endregion

        #region Constructors

        // there is no need for a default constructor because the summary cannot be empty or null,
        // therefore the summary must have an inputted value. with the following construction below.
        public Task(string summary) // sets the summary data field and sets details to a default value.
        {
            _summary = summary;
            _details = Details;
        }

        public Task(string summary, DateTime dueDate) // sets summary and details field with inputs
        {
            this._summary = summary;
            this._dueDate = dueDate;
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return Info;
        }

        #endregion

    }
}
