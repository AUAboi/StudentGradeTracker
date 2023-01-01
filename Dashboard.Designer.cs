namespace StudentGradeTracker
{
    partial class Dashboard
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsGridView = new System.Windows.Forms.DataGridView();
            this.viewAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsToolStripMenuItem,
            this.gradesToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(813, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem});
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.studentsToolStripMenuItem.Text = "Students";
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.addNewToolStripMenuItem.Text = "Add new";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // gradesToolStripMenuItem
            // 
            this.gradesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem1,
            this.viewAllToolStripMenuItem});
            this.gradesToolStripMenuItem.Name = "gradesToolStripMenuItem";
            this.gradesToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.gradesToolStripMenuItem.Text = "Grades";
            // 
            // addNewToolStripMenuItem1
            // 
            this.addNewToolStripMenuItem1.Name = "addNewToolStripMenuItem1";
            this.addNewToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.addNewToolStripMenuItem1.Text = "Add New";
            this.addNewToolStripMenuItem1.Click += new System.EventHandler(this.addNewToolStripMenuItem1_Click);
            // 
            // studentsGridView
            // 
            this.studentsGridView.AllowUserToAddRows = false;
            this.studentsGridView.BackgroundColor = System.Drawing.Color.White;
            this.studentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsGridView.Location = new System.Drawing.Point(12, 76);
            this.studentsGridView.Name = "studentsGridView";
            this.studentsGridView.RowTemplate.Height = 25;
            this.studentsGridView.Size = new System.Drawing.Size(494, 250);
            this.studentsGridView.TabIndex = 3;
            this.studentsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentsGridView_CellClick);
            this.studentsGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentsGridView_CellEndEdit);
            this.studentsGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.studentsGridView_CellValidating);
            // 
            // viewAllToolStripMenuItem
            // 
            this.viewAllToolStripMenuItem.Name = "viewAllToolStripMenuItem";
            this.viewAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewAllToolStripMenuItem.Text = "View All";
            this.viewAllToolStripMenuItem.Click += new System.EventHandler(this.viewAllToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 423);
            this.Controls.Add(this.studentsGridView);
            this.Controls.Add(this.mainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip mainMenu;
        private ToolStripMenuItem studentsToolStripMenuItem;
        private ToolStripMenuItem addNewToolStripMenuItem;
        private DataGridView studentsGridView;
      
        private ToolStripMenuItem gradesToolStripMenuItem;
        private ToolStripMenuItem addNewToolStripMenuItem1;
        private ToolStripMenuItem viewAllToolStripMenuItem;
    }
}