using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class AssignedTasks
    {
        private int id;
        private int employeeId;
        private int taskId;
        private string task;
        private int time;
        public AssignedTasks() { }

        public AssignedTasks(int id, int employeeId, int taskId, string task, int time)
        {
            Id = id;
            EmployeeId = employeeId;
            TaskId = taskId;
            Task = task;
            Time = time;
        }

        public int Id { get => id; set => id = value; }
        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public int TaskId { get => taskId; set => taskId = value; }
        public string Task { get => task; set => task = value; }
        public int Time { get => time; set => time = value; }
    }
}
