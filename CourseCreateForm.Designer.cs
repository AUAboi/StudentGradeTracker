namespace StudentGradeTracker
{
    partial class CourseCreateForm
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
            this.courseNameField = new System.Windows.Forms.TextBox();
            this.practicalField = new System.Windows.Forms.TextBox();
            this.mainButton1 = new StudentGradeTracker.Components.MainButton();
            this.theoryField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.depCodeField = new System.Windows.Forms.TextBox();
            this.courseCodeField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // courseNameField
            // 
            this.courseNameField.Location = new System.Drawing.Point(39, 64);
            this.courseNameField.Name = "courseNameField";
            this.courseNameField.Size = new System.Drawing.Size(270, 23);
            this.courseNameField.TabIndex = 0;
            // 
            // practicalField
            // 
            this.practicalField.Location = new System.Drawing.Point(39, 121);
            this.practicalField.Name = "practicalField";
            this.practicalField.Size = new System.Drawing.Size(122, 23);
            this.practicalField.TabIndex = 3;
            this.practicalField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.field_KeyPress);
            // 
            // mainButton1
            // 
            this.mainButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(95)))));
            this.mainButton1.FlatAppearance.BorderSize = 0;
            this.mainButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(146)))), ((int)(((byte)(60)))));
            this.mainButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainButton1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainButton1.ForeColor = System.Drawing.Color.White;
            this.mainButton1.Location = new System.Drawing.Point(111, 224);
            this.mainButton1.Name = "mainButton1";
            this.mainButton1.Size = new System.Drawing.Size(137, 46);
            this.mainButton1.TabIndex = 4;
            this.mainButton1.Text = "Create";
            this.mainButton1.UseVisualStyleBackColor = false;
            this.mainButton1.Click += new System.EventHandler(this.mainButton1_Click);
            // 
            // theoryField
            // 
            this.theoryField.Location = new System.Drawing.Point(196, 121);
            this.theoryField.Name = "theoryField";
            this.theoryField.Size = new System.Drawing.Size(113, 23);
            this.theoryField.TabIndex = 5;
            this.theoryField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.field_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Course Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Practical Credit Hours";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Theory Credit Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Department Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Course Code";
            // 
            // depCodeField
            // 
            this.depCodeField.Location = new System.Drawing.Point(196, 176);
            this.depCodeField.Name = "depCodeField";
            this.depCodeField.Size = new System.Drawing.Size(113, 23);
            this.depCodeField.TabIndex = 12;
            // 
            // courseCodeField
            // 
            this.courseCodeField.Location = new System.Drawing.Point(39, 176);
            this.courseCodeField.Name = "courseCodeField";
            this.courseCodeField.Size = new System.Drawing.Size(122, 23);
            this.courseCodeField.TabIndex = 11;
            this.courseCodeField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.field_KeyPress);
            // 
            // CourseCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 312);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.depCodeField);
            this.Controls.Add(this.courseCodeField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.theoryField);
            this.Controls.Add(this.mainButton1);
            this.Controls.Add(this.practicalField);
            this.Controls.Add(this.courseNameField);
            this.Name = "CourseCreateForm";
            this.Text = "CourseCreateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox courseNameField;
        private TextBox practicalField;
        private Components.MainButton mainButton1;
        private TextBox theoryField;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label2;
        private Label label3;
        private TextBox depCodeField;
        private TextBox courseCodeField;
    }
}