namespace StudentGradeTracker
{
    partial class ViewAllGradesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gradeTable = new System.Windows.Forms.DataGridView();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Midterm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Finalterm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gradeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // gradeTable
            // 
            this.gradeTable.AllowUserToAddRows = false;
            this.gradeTable.AllowUserToDeleteRows = false;
            this.gradeTable.AllowUserToOrderColumns = true;
            this.gradeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradeTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentName,
            this.CourseName,
            this.Midterm,
            this.Finalterm,
            this.Semester,
            this.Date});
            this.gradeTable.Location = new System.Drawing.Point(1, 0);
            this.gradeTable.Name = "gradeTable";
            this.gradeTable.RowTemplate.Height = 25;
            this.gradeTable.Size = new System.Drawing.Size(644, 450);
            this.gradeTable.TabIndex = 0;
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "Name";
            this.StudentName.Name = "StudentName";
            // 
            // CourseName
            // 
            this.CourseName.HeaderText = "Course Name";
            this.CourseName.Name = "CourseName";
            // 
            // Midterm
            // 
            this.Midterm.HeaderText = "Mid Terms";
            this.Midterm.Name = "Midterm";
            // 
            // Finalterm
            // 
            this.Finalterm.HeaderText = "Final Term";
            this.Finalterm.Name = "Finalterm";
            // 
            // Semester
            // 
            this.Semester.HeaderText = "Semester";
            this.Semester.Name = "Semester";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // ViewAllGradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 450);
            this.Controls.Add(this.gradeTable);
            this.Name = "ViewAllGradesForm";
            this.Text = "ViewAllGradesForm";
            this.Load += new System.EventHandler(this.ViewAllGradesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gradeTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView gradeTable;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn CourseName;
        private DataGridViewTextBoxColumn Midterm;
        private DataGridViewTextBoxColumn Finalterm;
        private DataGridViewTextBoxColumn Semester;
        private DataGridViewTextBoxColumn Date;
    }
}