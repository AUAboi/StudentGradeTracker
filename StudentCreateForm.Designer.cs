namespace StudentGradeTracker
{
    partial class StudentCreateForm
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
            this.nameField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phoneField = new System.Windows.Forms.TextBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(60, 56);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(100, 23);
            this.nameField.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // emailField
            // 
            this.emailField.Location = new System.Drawing.Point(166, 56);
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(100, 23);
            this.emailField.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone";
            // 
            // phoneField
            // 
            this.phoneField.Location = new System.Drawing.Point(60, 114);
            this.phoneField.Name = "phoneField";
            this.phoneField.Size = new System.Drawing.Size(100, 23);
            this.phoneField.TabIndex = 4;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(127, 162);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 6;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // StudentCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 369);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phoneField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameField);
            this.Name = "StudentCreateForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nameField;
        private Label label1;
        private Label label2;
        private TextBox emailField;
        private Label label3;
        private TextBox phoneField;
        private Button createBtn;
    }
}