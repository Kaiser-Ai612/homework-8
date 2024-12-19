using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_8_1.@class
{
    internal class Task1
    {
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public Employee Initiator { get; set; }
        //public string d;
        public Employee AssignedTo { get; private set; }
        public TaskStat Status { get; private set; }
        public List<Report> Reports { get; set; }

        public Task1(string description, DateTime deadline, Employee initiator)
        {
            Description = description;
            Deadline = deadline;
            Initiator = initiator;
            Reports = new List<Report>();
            Status = TaskStat.No;
            AssignedTo = null;
        }
        public void AssignTo(Employee employee)
        {
            AssignedTo = employee;
        }
        //я не помню зачем я это написала 
        //public void DelegateTo(Employee newAssignedTo)
        //{
        //    Status = TaskStat.Done;
        //}

        public void Complete()
        {
            if (AssignedTo != null && Status == TaskStat.No)
            {
                Status = TaskStat.Done;
            }
        }

        //public void AddReport(Report report)
        //{
        //    Reports.Add(report);
        //}
    }    
}
