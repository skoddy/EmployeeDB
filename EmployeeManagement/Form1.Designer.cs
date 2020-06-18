namespace EmployeeManagement
{
    partial class FrmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdEmployee = new System.Windows.Forms.DataGridView();
            this.grpbNewEmployee = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNewEmployeeLastName = new System.Windows.Forms.TextBox();
            this.tbNewEmployeeFirstName = new System.Windows.Forms.TextBox();
            this.btnAddNewEmployee = new System.Windows.Forms.Button();
            this.grpbEditEmployee = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEditEmployeeLastName = new System.Windows.Forms.TextBox();
            this.tbEditEmployeeFirstName = new System.Windows.Forms.TextBox();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAssignTask = new System.Windows.Forms.Button();
            this.cbTasks = new System.Windows.Forms.ComboBox();
            this.grdAssignedTasks = new System.Windows.Forms.DataGridView();
            this.btnDeleteAssignedTask = new System.Windows.Forms.Button();
            this.grpbEmployees = new System.Windows.Forms.GroupBox();
            this.grpbAssignedTasks = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployee)).BeginInit();
            this.grpbNewEmployee.SuspendLayout();
            this.grpbEditEmployee.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAssignedTasks)).BeginInit();
            this.grpbEmployees.SuspendLayout();
            this.grpbAssignedTasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdEmployee
            // 
            this.grdEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmployee.Location = new System.Drawing.Point(6, 19);
            this.grdEmployee.Name = "grdEmployee";
            this.grdEmployee.Size = new System.Drawing.Size(320, 165);
            this.grdEmployee.TabIndex = 0;
            // 
            // grpbNewEmployee
            // 
            this.grpbNewEmployee.Controls.Add(this.label2);
            this.grpbNewEmployee.Controls.Add(this.label1);
            this.grpbNewEmployee.Controls.Add(this.tbNewEmployeeLastName);
            this.grpbNewEmployee.Controls.Add(this.tbNewEmployeeFirstName);
            this.grpbNewEmployee.Controls.Add(this.btnAddNewEmployee);
            this.grpbNewEmployee.Location = new System.Drawing.Point(10, 266);
            this.grpbNewEmployee.Name = "grpbNewEmployee";
            this.grpbNewEmployee.Size = new System.Drawing.Size(200, 160);
            this.grpbNewEmployee.TabIndex = 1;
            this.grpbNewEmployee.TabStop = false;
            this.grpbNewEmployee.Text = "Neuer Mitarbeiter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nachname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vorname";
            // 
            // tbNewEmployeeLastName
            // 
            this.tbNewEmployeeLastName.Location = new System.Drawing.Point(79, 56);
            this.tbNewEmployeeLastName.Name = "tbNewEmployeeLastName";
            this.tbNewEmployeeLastName.Size = new System.Drawing.Size(115, 20);
            this.tbNewEmployeeLastName.TabIndex = 2;
            // 
            // tbNewEmployeeFirstName
            // 
            this.tbNewEmployeeFirstName.Location = new System.Drawing.Point(79, 30);
            this.tbNewEmployeeFirstName.Name = "tbNewEmployeeFirstName";
            this.tbNewEmployeeFirstName.Size = new System.Drawing.Size(115, 20);
            this.tbNewEmployeeFirstName.TabIndex = 1;
            // 
            // btnAddNewEmployee
            // 
            this.btnAddNewEmployee.Location = new System.Drawing.Point(6, 131);
            this.btnAddNewEmployee.Name = "btnAddNewEmployee";
            this.btnAddNewEmployee.Size = new System.Drawing.Size(188, 23);
            this.btnAddNewEmployee.TabIndex = 0;
            this.btnAddNewEmployee.Text = "Speichern";
            this.btnAddNewEmployee.UseVisualStyleBackColor = true;
            this.btnAddNewEmployee.Click += new System.EventHandler(this.btnAddNewEmployee_Click);
            // 
            // grpbEditEmployee
            // 
            this.grpbEditEmployee.Controls.Add(this.label4);
            this.grpbEditEmployee.Controls.Add(this.label3);
            this.grpbEditEmployee.Controls.Add(this.tbEditEmployeeLastName);
            this.grpbEditEmployee.Controls.Add(this.tbEditEmployeeFirstName);
            this.grpbEditEmployee.Controls.Add(this.btnEditEmployee);
            this.grpbEditEmployee.Location = new System.Drawing.Point(221, 266);
            this.grpbEditEmployee.Name = "grpbEditEmployee";
            this.grpbEditEmployee.Size = new System.Drawing.Size(200, 160);
            this.grpbEditEmployee.TabIndex = 2;
            this.grpbEditEmployee.TabStop = false;
            this.grpbEditEmployee.Text = "Mitarbeiter Bearbeiten";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nachname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vorname";
            // 
            // tbEditEmployeeLastName
            // 
            this.tbEditEmployeeLastName.Location = new System.Drawing.Point(75, 56);
            this.tbEditEmployeeLastName.Name = "tbEditEmployeeLastName";
            this.tbEditEmployeeLastName.Size = new System.Drawing.Size(115, 20);
            this.tbEditEmployeeLastName.TabIndex = 4;
            // 
            // tbEditEmployeeFirstName
            // 
            this.tbEditEmployeeFirstName.Location = new System.Drawing.Point(75, 30);
            this.tbEditEmployeeFirstName.Name = "tbEditEmployeeFirstName";
            this.tbEditEmployeeFirstName.Size = new System.Drawing.Size(115, 20);
            this.tbEditEmployeeFirstName.TabIndex = 3;
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Location = new System.Drawing.Point(9, 131);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(181, 23);
            this.btnEditEmployee.TabIndex = 2;
            this.btnEditEmployee.Text = "Änderungen speichern";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(6, 190);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(181, 23);
            this.btnDeleteEmployee.TabIndex = 6;
            this.btnDeleteEmployee.Text = "Mitarbeiter Löschen";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAssignTask);
            this.groupBox1.Controls.Add(this.cbTasks);
            this.groupBox1.Location = new System.Drawing.Point(427, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 158);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aufgaben";
            // 
            // btnAssignTask
            // 
            this.btnAssignTask.Location = new System.Drawing.Point(6, 129);
            this.btnAssignTask.Name = "btnAssignTask";
            this.btnAssignTask.Size = new System.Drawing.Size(188, 23);
            this.btnAssignTask.TabIndex = 1;
            this.btnAssignTask.Text = "Aufgabe zuweisen";
            this.btnAssignTask.UseVisualStyleBackColor = true;
            this.btnAssignTask.Click += new System.EventHandler(this.btnAssignTask_Click);
            // 
            // cbTasks
            // 
            this.cbTasks.FormattingEnabled = true;
            this.cbTasks.Location = new System.Drawing.Point(6, 30);
            this.cbTasks.Name = "cbTasks";
            this.cbTasks.Size = new System.Drawing.Size(188, 21);
            this.cbTasks.TabIndex = 0;
            // 
            // grdAssignedTasks
            // 
            this.grdAssignedTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAssignedTasks.Location = new System.Drawing.Point(6, 19);
            this.grdAssignedTasks.Name = "grdAssignedTasks";
            this.grdAssignedTasks.Size = new System.Drawing.Size(320, 165);
            this.grdAssignedTasks.TabIndex = 4;
            // 
            // btnDeleteAssignedTask
            // 
            this.btnDeleteAssignedTask.Location = new System.Drawing.Point(6, 190);
            this.btnDeleteAssignedTask.Name = "btnDeleteAssignedTask";
            this.btnDeleteAssignedTask.Size = new System.Drawing.Size(181, 23);
            this.btnDeleteAssignedTask.TabIndex = 7;
            this.btnDeleteAssignedTask.Text = "Aufgabe Löschen";
            this.btnDeleteAssignedTask.UseVisualStyleBackColor = true;
            this.btnDeleteAssignedTask.Click += new System.EventHandler(this.btnDeleteAssignedTask_Click);
            // 
            // grpbEmployees
            // 
            this.grpbEmployees.Controls.Add(this.grdEmployee);
            this.grpbEmployees.Controls.Add(this.btnDeleteEmployee);
            this.grpbEmployees.Location = new System.Drawing.Point(10, 12);
            this.grpbEmployees.Name = "grpbEmployees";
            this.grpbEmployees.Size = new System.Drawing.Size(334, 219);
            this.grpbEmployees.TabIndex = 8;
            this.grpbEmployees.TabStop = false;
            this.grpbEmployees.Text = "Mitarbeiter";
            // 
            // grpbAssignedTasks
            // 
            this.grpbAssignedTasks.Controls.Add(this.grdAssignedTasks);
            this.grpbAssignedTasks.Controls.Add(this.btnDeleteAssignedTask);
            this.grpbAssignedTasks.Location = new System.Drawing.Point(350, 12);
            this.grpbAssignedTasks.Name = "grpbAssignedTasks";
            this.grpbAssignedTasks.Size = new System.Drawing.Size(333, 219);
            this.grpbAssignedTasks.TabIndex = 9;
            this.grpbAssignedTasks.TabStop = false;
            this.grpbAssignedTasks.Text = "Aufgaben";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 437);
            this.Controls.Add(this.grpbAssignedTasks);
            this.Controls.Add(this.grpbEmployees);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbEditEmployee);
            this.Controls.Add(this.grpbNewEmployee);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mitarbeiter Verwaltung";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployee)).EndInit();
            this.grpbNewEmployee.ResumeLayout(false);
            this.grpbNewEmployee.PerformLayout();
            this.grpbEditEmployee.ResumeLayout(false);
            this.grpbEditEmployee.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAssignedTasks)).EndInit();
            this.grpbEmployees.ResumeLayout(false);
            this.grpbAssignedTasks.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView grdEmployee;
        private System.Windows.Forms.GroupBox grpbEditEmployee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEditEmployeeLastName;
        private System.Windows.Forms.TextBox tbEditEmployeeFirstName;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.GroupBox grpbNewEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNewEmployeeLastName;
        private System.Windows.Forms.TextBox tbNewEmployeeFirstName;
        private System.Windows.Forms.Button btnAddNewEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAssignTask;
        private System.Windows.Forms.ComboBox cbTasks;
        private System.Windows.Forms.DataGridView grdAssignedTasks;
        private System.Windows.Forms.Button btnDeleteAssignedTask;
        private System.Windows.Forms.GroupBox grpbEmployees;
        private System.Windows.Forms.GroupBox grpbAssignedTasks;
    }
}

