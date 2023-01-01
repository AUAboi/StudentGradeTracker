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
            ((System.ComponentModel.ISupportInitialize)(this.gradeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // gradeTable
            // 
            this.gradeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradeTable.Location = new System.Drawing.Point(101, 132);
            this.gradeTable.Name = "gradeTable";
            this.gradeTable.RowTemplate.Height = 25;
            this.gradeTable.Size = new System.Drawing.Size(240, 150);
            this.gradeTable.TabIndex = 0;
            // 
            // ViewAllGradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gradeTable);
            this.Name = "ViewAllGradesForm";
            this.Text = "ViewAllGradesForm";
            this.Load += new System.EventHandler(this.ViewAllGradesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gradeTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView gradeTable;
    }
}