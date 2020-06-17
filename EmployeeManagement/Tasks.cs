using System.Collections.Generic;

namespace EmployeeManagement
{

    public class Tasks
    {
        private protected Database db = new Database();

        public Tasks() { }

        public Tasks(int id, string task, int time)
        {
            Id = id;
            Task = task;
            Time = time;
        }

        public int Id { get; set; }
        public string Task { get; set ; }
        public int Time { get ; set; }


        public void Delete(int id)
        {

        }

        public void Insert()
        {

        }

        public List<Tasks> GetList()
        {
            string query = "SELECT id, task, time FROM tasks WHERE deleted=0 ORDER BY task";

            List<Tasks> list = db.GetList<Tasks>(query);

            return list;
        }


        public void Update()
        {

        }

    }
}
