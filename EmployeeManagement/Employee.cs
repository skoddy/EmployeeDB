using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace EmployeeManagement
{
    public class Employee
    {
        private protected Database db = new Database();

        public Employee() { }

        public Employee(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Delete(int id)
        {
            db.Hide("employees", id);
        }

        public void Insert(string firstName, string lastName)
        {
            MySqlParameter[] parameters = {
                new MySqlParameter("@firstName", firstName),
                new MySqlParameter("@lastName", lastName)};

            db.Insert("employees", parameters);
        }

        public List<Employee> GetList()
        {
            string query = "SELECT id, firstName, lastName FROM employees WHERE deleted=0 ORDER BY lastName";

            List<Employee> list = db.GetList<Employee>(query);

            return list;
        }


        public void Update(int id, string firstName, string lastName)
        {
            MySqlParameter[] parameters = {
                new MySqlParameter("@firstName", firstName),
                new MySqlParameter("@lastName", lastName)};

            db.Update("employees", parameters, id);
        }
    }
}