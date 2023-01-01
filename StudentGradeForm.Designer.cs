namespace StudentGradeTracker
{
    partial class StudentGradeForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.mainButton1 = new StudentGradeTracker.Components.MainButton();
            this.studentGradeTable = new System.Windows.Forms.DataGridView();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mids = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Finals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarksPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QualityPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.studentGradeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(86, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBox2.Location = new System.Drawing.Point(231, 82);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 1;
            // 
            // mainButton1
            // 
            this.mainButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(95)))));
            this.mainButton1.FlatAppearance.BorderSize = 0;
            this.mainButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(146)))), ((int)(((byte)(60)))));
            this.mainButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainButton1.ForeColor = System.Drawing.Color.White;
            this.mainButton1.Location = new System.Drawing.Point(418, 82);
            this.mainButton1.Name = "mainButton1";
            this.mainButton1.Size = new System.Drawing.Size(75, 23);
            this.mainButton1.TabIndex = 2;
            this.mainButton1.Text = "Fetch";
            this.mainButton1.UseVisualStyleBackColor = false;
            this.mainButton1.Click += new System.EventHandler(this.mainButton1_Click);
            // 
            // studentGradeTable
            // 
            this.studentGradeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGradeTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Course,
            this.MaxMarks,
            this.Mids,
            this.Finals,
            this.MarksPercentage,
            this.QualityPoints});
            this.studentGradeTable.Location = new System.Drawing.Point(86, 157);
            this.studentGradeTable.Name = "studentGradeTable";
            this.studentGradeTable.RowTemplate.Height = 25;
            this.studentGradeTable.Size = new System.Drawing.Size(643, 228);
            this.studentGradeTable.TabIndex = 3;
            // 
            // Course
            // 
            this.Course.HeaderText = "Course";
            this.Course.Name = "Course";
            // 
            // MaxMarks
            // 
            this.MaxMarks.HeaderText = "Max Marks";
            this.MaxMarks.Name = "MaxMarks";
            // 
            // Mids
            // 
            this.Mids.HeaderText = "Mids";
            this.Mids.Name = "Mids";
            // 
            // Finals
            // 
            this.Finals.HeaderText = "Finals";
            this.Finals.Name = "Finals";
            // 
            // MarksPercentage
            // 
            this.MarksPercentage.HeaderText = "Marks%";
            this.MarksPercentage.Name = "MarksPercentage";
            // 
            // QualityPoints
            // 
            this.QualityPoints.HeaderText = "Quality Points";
            this.QualityPoints.Name = "QualityPoints";
            // 
            // StudentGradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.studentGradeTable);
            this.Controls.Add(this.mainButton1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "StudentGradeForm";
            this.Text = "StudentGradeForm";
            this.Load += new System.EventHandler(this.StudentGradeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentGradeTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Components.MainButton mainButton1;
        private DataGridView studentGradeTable;
        private DataGridViewTextBoxColumn Course;
        private DataGridViewTextBoxColumn MaxMarks;
        private DataGridViewTextBoxColumn Mids;
        private DataGridViewTextBoxColumn Finals;
        private DataGridViewTextBoxColumn MarksPercentage;
        private DataGridViewTextBoxColumn QualityPoints;
    }
}