namespace _4_2_LMS_login
{
    partial class StudentCRUD
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
            dataGridView1 = new DataGridView();
            btnAddStudent = new Button();
            btnDeleteStudent = new Button();
            txtFirst = new TextBox();
            txtGPA = new TextBox();
            txtLast = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnSortGPA = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(65, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(673, 493);
            dataGridView1.TabIndex = 0;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(183, 758);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(150, 34);
            btnAddStudent.TabIndex = 1;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnDeleteStudent
            // 
            btnDeleteStudent.Location = new Point(355, 758);
            btnDeleteStudent.Name = "btnDeleteStudent";
            btnDeleteStudent.Size = new Size(172, 34);
            btnDeleteStudent.TabIndex = 2;
            btnDeleteStudent.Text = "Delete Student";
            btnDeleteStudent.UseVisualStyleBackColor = true;
            btnDeleteStudent.Click += btnDeleteStudent_Click;
            // 
            // txtFirst
            // 
            txtFirst.Location = new Point(183, 564);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(150, 31);
            txtFirst.TabIndex = 4;
            // 
            // txtGPA
            // 
            txtGPA.Location = new Point(183, 689);
            txtGPA.Name = "txtGPA";
            txtGPA.Size = new Size(150, 31);
            txtGPA.TabIndex = 5;
            // 
            // txtLast
            // 
            txtLast.Location = new Point(183, 628);
            txtLast.Name = "txtLast";
            txtLast.Size = new Size(150, 31);
            txtLast.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 570);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 7;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 695);
            label2.Name = "label2";
            label2.Size = new Size(45, 25);
            label2.TabIndex = 8;
            label2.Text = "GPA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 634);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 9;
            label3.Text = "Last Name";
            // 
            // btnSortGPA
            // 
            btnSortGPA.Location = new Point(397, 570);
            btnSortGPA.Name = "btnSortGPA";
            btnSortGPA.Size = new Size(112, 34);
            btnSortGPA.TabIndex = 10;
            btnSortGPA.Text = "GPA sort";
            btnSortGPA.UseVisualStyleBackColor = true;
            btnSortGPA.Click += btnSortGPA_Click;
            // 
            // StudentCRUD
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 822);
            Controls.Add(btnSortGPA);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLast);
            Controls.Add(txtGPA);
            Controls.Add(txtFirst);
            Controls.Add(btnDeleteStudent);
            Controls.Add(btnAddStudent);
            Controls.Add(dataGridView1);
            Name = "StudentCRUD";
            Text = "StudentCRUD";
            Load += StudentCRUD_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAddStudent;
        private Button btnDeleteStudent;
        private TextBox txtFirst;
        private TextBox txtGPA;
        private TextBox txtLast;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSortGPA;
    }
}