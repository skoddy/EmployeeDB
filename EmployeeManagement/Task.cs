using System.Collections.Generic;

namespace EmployeeManagement
{

    public class Task
    {
        private protected Database db = new Database();

        public Task() { }

        public Task(int id, string name, int time)
        {
            Id = id;
            Name = name;
            Time = time;
        }

        public int Id { get; set; }
        public string Name { get; set ; }
        public System.Int64 Time { get ; set; }


        public void DeleteAssignedTask(int id)
        {
            db.Hide("employee_task", id);
        }

        public void Insert()
        {

        }

        public List<Task> GetAllTasks()
        {
            string query = "SELECT id, name, time FROM tasks ORDER BY id";

            List<Task> list = db.GetList<Task>(query);

            return list;
        }

        public List<Task> GetAssignedTasksList(int id )
        {
            string query = string.Format(
                "SELECT employee_task.id, tasks.name, CAST(SUM(tasks.time) AS SIGNED) time " +
                "FROM employees, tasks, employee_task " +
                "WHERE employee_task.employeeId = employees.id " +
                "AND tasks.id = employee_task.taskId " +
                "AND employees.id = {0} " +
                "AND employee_task.deleted = 0 " +
                "GROUP BY tasks.name;", id);

            List<Task> list = db.GetList<Task>(query);

            return list;
        }
        public void Update()
        {

        }

    }
}
