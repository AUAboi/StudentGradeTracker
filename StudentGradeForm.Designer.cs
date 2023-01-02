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
            this.LetterGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QualityPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.gpaText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cgpaText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentGradeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 100);
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
            this.comboBox2.Location = new System.Drawing.Point(157, 100);
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
            this.mainButton1.Location = new System.Drawing.Point(297, 99);
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
            this.LetterGrade,
            this.QualityPoints});
            this.studentGradeTable.Location = new System.Drawing.Point(12, 148);
            this.studentGradeTable.Name = "studentGradeTable";
            this.studentGradeTable.RowTemplate.Height = 25;
            this.studentGradeTable.Size = new System.Drawing.Size(744, 249);
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
            // LetterGrade
            // 
            this.LetterGrade.HeaderText = "Letter Grade";
            this.LetterGrade.Name = "LetterGrade";
            // 
            // QualityPoints
            // 
            this.QualityPoints.HeaderText = "Quality Points";
            this.QualityPoints.Name = "QualityPoints";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 52);
            this.label1.TabIndex = 4;
            this.label1.Text = "GPA:";
            // 
            // gpaText
            // 
            this.gpaText.AutoSize = true;
            this.gpaText.Font = new System.Drawing.Font("Segoe UI", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpaText.Location = new System.Drawing.Point(133, 413);
            this.gpaText.Name = "gpaText";
            this.gpaText.Size = new System.Drawing.Size(0, 52);
            this.gpaText.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Student";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Semester";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 465);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 52);
            this.label5.TabIndex = 9;
            this.label5.Text = "CGPA:";
            // 
            // cgpaText
            // 
            this.cgpaText.AutoSize = true;
            this.cgpaText.Font = new System.Drawing.Font("Segoe UI", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cgpaText.Location = new System.Drawing.Point(133, 465);
            this.cgpaText.Name = "cgpaText";
            this.cgpaText.Size = new System.Drawing.Size(0, 52);
            this.cgpaText.TabIndex = 10;
            // 
            // StudentGradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 526);
            this.Controls.Add(this.cgpaText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gpaText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentGradeTable);
            this.Controls.Add(this.mainButton1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "StudentGradeForm";
            this.Text = "StudentGradeForm";
            this.Load += new System.EventHandler(this.StudentGradeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentGradeTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Components.MainButton mainButton1;
        private DataGridView studentGradeTable;
        private Label label1;
        private Label gpaText;
        private DataGridViewTextBoxColumn Course;
        private DataGridViewTextBoxColumn MaxMarks;
        private DataGridViewTextBoxColumn Mids;
        private DataGridViewTextBoxColumn Finals;
        private DataGridViewTextBoxColumn MarksPercentage;
        private DataGridViewTextBoxColumn LetterGrade;
        private DataGridViewTextBoxColumn QualityPoints;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label cgpaText;
    }
}