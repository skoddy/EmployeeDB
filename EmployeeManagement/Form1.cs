using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class FrmMain : Form
    {
        private Employee employee;
        private Task task;
        private List<Employee> employees;
        private List<Task> tasks;
        private List<Task> assignedTasks;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            SetupEmployeeGrid();
            PopulateEmployeeGrid();

            SetupAssignedTasksGrid();
            // Da das Grid Standartmässig einen Focus hat,
            // werden hier die dazugehörigen Aufgaben geladen.
            if (grdEmployee.SelectedRows[0].Cells[0].Value != null)
            {
                int employeeId = (int)grdEmployee.SelectedRows[0].Tag;
                PopulateAssignedTasksGrid(employeeId);
            }
            PopulateTasksComboBox();
        }

        private void PopulateEmployeeGrid()
        {
            employee = new Employee();

            try
            {
                // Mitarbeiter in die Liste laden
                employees = employee.GetList();

                // Festlegen der Zeilenanzahl des Grids.
                grdEmployee.RowCount = employees.Count;

                // Mitarbeiten auslesen zuweisen
                foreach (Employee employee in employees)
                {
                    int index = employees.IndexOf(employee);
                    // Id wird im Tag der Zeile gespeichert.
                    grdEmployee.Rows[index].Tag = employee.Id;
                    grdEmployee.Rows[index].Cells["Vorname"].Value = employee.FirstName;
                    grdEmployee.Rows[index].Cells["Nachname"].Value = employee.LastName;
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

          
        }

        private void PopulateAssignedTasksGrid(int id)
        {
            task = new Task();

            try
            {
                // Aufgaben in die Liste laden
                assignedTasks = task.GetAssignedTasksList(id);

                grdAssignedTasks.Rows.Clear();
                // Festlegen der Zeilenanzahl des Grids.
                grdAssignedTasks.RowCount = assignedTasks.Count;

                // Mitarbeiten auslesen zuweisen
                foreach (Task task in assignedTasks)
                {
                    int index = assignedTasks.IndexOf(task);
                    // Id wird im Tag der Zeile gespeichert.
                    grdAssignedTasks.Rows[index].Tag = task.Id;
                    grdAssignedTasks.Rows[index].Cells["Aufgabe"].Value = task.Name;
                    grdAssignedTasks.Rows[index].Cells["Dauer"].Value = task.Time;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PopulateTasksComboBox()
        {
            task = new Task();
            tasks = task.GetAllTasks();

            if (tasks.Count != 0)
            {
                foreach(Task task in tasks)
                {
                    cbTasks.Items.Add(task.Name);
                }
            }
        }

        private void SetupEmployeeGrid()
        {
            // Grid anzeigen
            grpbEmployees.Controls.Add(grdEmployee);

            DataGridViewTextBoxColumn firstName = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn lastName = new DataGridViewTextBoxColumn();

            // Spaltenaufbau
            firstName.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            firstName.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            firstName.Width = 150;
            firstName.Name = "Vorname";

            lastName.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            lastName.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            lastName.Width = 150;
            lastName.Name = "Nachname";

            // Gridaufbau
            grdEmployee.Columns.AddRange(lastName, firstName);
            grdEmployee.RowCount = 1;
            grdEmployee.Width = 300 + 20;
            grdEmployee.RowHeadersVisible = false;
            grdEmployee.AllowUserToAddRows = false;
            grdEmployee.ReadOnly = true;
            grdEmployee.Visible = true;
            grdEmployee.AllowUserToAddRows = false;
            grdEmployee.AllowUserToResizeColumns = false;
            grdEmployee.AllowUserToResizeRows = false;
            grdEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdEmployee.MultiSelect = false;
            grdEmployee.SelectionChanged += new EventHandler(GridEmployeeRow_Click);

        }

        private void SetupAssignedTasksGrid()
        {
            // Grid anzeigen
            grpbAssignedTasks.Controls.Add(grdAssignedTasks);

            DataGridViewTextBoxColumn task = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn time = new DataGridViewTextBoxColumn();

            // Spaltenaufbau
            task.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            task.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            task.Width = 150;
            task.Name = "Aufgabe";

            time.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            time.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            time.Width = 150;
            time.Name = "Dauer";

            // Gridaufbau
            grdAssignedTasks.Columns.AddRange(task, time);
            grdAssignedTasks.RowCount = 1;
            grdAssignedTasks.Width = 300 + 20;
            grdAssignedTasks.RowHeadersVisible = false;
            grdAssignedTasks.AllowUserToAddRows = false;
            grdAssignedTasks.ReadOnly = true;
            grdAssignedTasks.Visible = true;
            grdAssignedTasks.AllowUserToAddRows = false;
            grdAssignedTasks.AllowUserToResizeColumns = false;
            grdAssignedTasks.AllowUserToResizeRows = false;
            grdAssignedTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdAssignedTasks.MultiSelect = false;

        }

        private void GridEmployeeRow_Click(object sender, EventArgs e)
        {
            if(grdEmployee.SelectedRows[0].Cells[0].Value != null)
            {
                int id = (int)grdEmployee.SelectedRows[0].Tag;
                Employee employee = employees.Find(data => data.Id == id);
                tbEditEmployeeFirstName.Text = employee.FirstName;
                tbEditEmployeeLastName.Text = employee.LastName;

                PopulateAssignedTasksGrid(id);
            }
        }

        private void btnAddNewEmployee_Click(object sender, EventArgs e)
        {
            string firstName = tbNewEmployeeFirstName.Text;
            string lastName = tbNewEmployeeLastName.Text;
            try
            {
                employee.Insert(firstName, lastName);
                tbNewEmployeeFirstName.Clear();
                tbNewEmployeeLastName.Clear();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            PopulateEmployeeGrid();
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            int id = (int)grdEmployee.SelectedRows[0].Tag;
            try
            {
                employee.Delete(id);
                tbEditEmployeeFirstName.Clear();
                tbEditEmployeeLastName.Clear();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            PopulateEmployeeGrid();
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            int id = (int)grdEmployee.SelectedRows[0].Tag;
            string firstName = tbEditEmployeeFirstName.Text;
            string lastName = tbEditEmployeeLastName.Text;
            try
            {
                employee.Update(id, firstName, lastName);
                tbEditEmployeeFirstName.Clear();
                tbEditEmployeeLastName.Clear();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            PopulateEmployeeGrid();

        }

        private void btnAssignTask_Click(object sender, EventArgs e)
        {
            if(cbTasks.SelectedIndex != -1 && grdEmployee.SelectedRows[0].Cells[0].Value != null)
            {
                int taskId = cbTasks.SelectedIndex + 1;
                int employeeId = (int)grdEmployee.SelectedRows[0].Tag;
                try
                {
                    employee.AssignTask(taskId, employeeId);
                    PopulateAssignedTasksGrid(employeeId);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDeleteAssignedTask_Click(object sender, EventArgs e)
        {
            if(grdAssignedTasks.SelectedRows[0].Cells[0].Value != null)
            {
                int assignedTaskId = (int)grdAssignedTasks.SelectedRows[0].Tag;
                int employeeId = (int)grdEmployee.SelectedRows[0].Tag;
                try
                {
                    task.DeleteAssignedTask(assignedTaskId);
                    PopulateAssignedTasksGrid(employeeId);
                }
                catch(MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
