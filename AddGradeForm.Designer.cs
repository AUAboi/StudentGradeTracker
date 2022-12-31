namespace StudentGradeTracker
{
    partial class AddGradeForm
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
            this.midTerm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.finalTerm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.semester = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mainButton1 = new StudentGradeTracker.Components.MainButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(218, 138);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // midTerm
            // 
            this.midTerm.Location = new System.Drawing.Point(167, 193);
            this.midTerm.Name = "midTerm";
            this.midTerm.Size = new System.Drawing.Size(100, 23);
            this.midTerm.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mid Term";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Final Term";
            // 
            // finalTerm
            // 
            this.finalTerm.Location = new System.Drawing.Point(301, 193);
            this.finalTerm.Name = "finalTerm";
            this.finalTerm.Size = new System.Drawing.Size(100, 23);
            this.finalTerm.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Semester";
            // 
            // semester
            // 
            this.semester.Location = new System.Drawing.Point(301, 250);
            this.semester.Name = "semester";
            this.semester.Size = new System.Drawing.Size(100, 23);
            this.semester.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Subject";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(167, 295);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(234, 23);
            this.date.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Student";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 44F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(137, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(314, 78);
            this.label7.TabIndex = 13;
            this.label7.Text = "Add Grade";
            // 
            // mainButton1
            // 
            this.mainButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(95)))));
            this.mainButton1.FlatAppearance.BorderSize = 0;
            this.mainButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(146)))), ((int)(((byte)(60)))));
            this.mainButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainButton1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainButton1.ForeColor = System.Drawing.Color.White;
            this.mainButton1.Location = new System.Drawing.Point(218, 339);
            this.mainButton1.Name = "mainButton1";
            this.mainButton1.Size = new System.Drawing.Size(120, 50);
            this.mainButton1.TabIndex = 14;
            this.mainButton1.Text = "Create";
            this.mainButton1.UseVisualStyleBackColor = false;
            this.mainButton1.Click += new System.EventHandler(this.mainButton1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(167, 250);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 23);
            this.comboBox2.TabIndex = 15;
            // 
            // AddGradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 491);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.mainButton1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.semester);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.finalTerm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.midTerm);
            this.Controls.Add(this.comboBox1);
            this.Name = "AddGradeForm";
            this.Text = "AddGradeForm";
            this.Load += new System.EventHandler(this.AddGradeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox1;
        private TextBox midTerm;
        private Label label1;
        private Label label2;
        private TextBox finalTerm;
        private Label label3;
        private TextBox semester;
        private Label label4;
        private DateTimePicker date;
        private Label label6;
        private Label label7;
        private Components.MainButton mainButton1;
        private ComboBox comboBox2;
    }
}