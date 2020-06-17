using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class FrmMain : Form
    {
        private Employee employee;
        private Tasks task;
        private List<Employee> employees;
        private List<Tasks> tasks;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            SetupEmployeeGrid();
            PopulateEmployeeGrid();

            SetupTasksGrid();
            PopulateTasksGrid();

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

        private void PopulateTasksGrid()
        {
            task = new Tasks();

            try
            {
                // Aufgaben in die Liste laden
                tasks = task.GetList();

                // Festlegen der Zeilenanzahl des Grids.
                grdTasks.RowCount = tasks.Count;

                // Mitarbeiten auslesen zuweisen
                foreach (Tasks task in tasks)
                {
                    int index = tasks.IndexOf(task);
                    // Id wird im Tag der Zeile gespeichert.
                    grdTasks.Rows[index].Tag = employee.Id;
                    grdTasks.Rows[index].Cells["Aufgabe"].Value = task.Task;
                    grdTasks.Rows[index].Cells["Dauer"].Value = task.Time;
                }



            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void PopulateTasksComboBox()
        {
            foreach(Tasks task in tasks)
            {
                cbTasks.Items.Add(task.Task);
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
        private void SetupTasksGrid()
        {
            // Grid anzeigen
            grpbTasks.Controls.Add(grdTasks);

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
            grdTasks.Columns.AddRange(task, time);
            grdTasks.RowCount = 1;
            grdTasks.Width = 300 + 20;
            grdTasks.RowHeadersVisible = false;
            grdTasks.AllowUserToAddRows = false;
            grdTasks.ReadOnly = true;
            grdTasks.Visible = true;
            grdTasks.AllowUserToAddRows = false;
            grdTasks.AllowUserToResizeColumns = false;
            grdTasks.AllowUserToResizeRows = false;
            grdTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdTasks.MultiSelect = false;
            grdTasks.SelectionChanged += new EventHandler(GridTasksRow_Click);

        }

        private void GridTasksRow_Click(object sender, EventArgs e)
        {

        }

        private void GridEmployeeRow_Click(object sender, EventArgs e)
        {
            if(grdEmployee.SelectedRows[0].Cells[0].Value != null)
            {
                int id = (int)grdEmployee.SelectedRows[0].Tag;
                Employee employee = employees.Find(data => data.Id == id);
                tbEditEmployeeFirstName.Text = employee.FirstName;
                tbEditEmployeeLastName.Text = employee.LastName;
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
    }
}
