namespace arraylist3
{
    partial class Departments
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
            btnDelete = new Button();
            txtDept = new TextBox();
            label1 = new Label();
            button1 = new Button();
            dgvDepartment = new DataGridView();
            lblMsg = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDepartment).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(421, 92);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Close";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtDept
            // 
            txtDept.Location = new Point(184, 37);
            txtDept.Name = "txtDept";
            txtDept.Size = new Size(190, 31);
            txtDept.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 37);
            label1.Name = "label1";
            label1.Size = new Size(159, 25);
            label1.TabIndex = 4;
            label1.Text = "Department Name";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(421, 35);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvDepartment
            // 
            dgvDepartment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartment.Location = new Point(-1, 153);
            dgvDepartment.Name = "dgvDepartment";
            dgvDepartment.RowHeadersWidth = 62;
            dgvDepartment.RowTemplate.Height = 33;
            dgvDepartment.Size = new Size(629, 306);
            dgvDepartment.TabIndex = 11;
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.Location = new Point(28, 97);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(0, 25);
            lblMsg.TabIndex = 12;
            // 
            // Departments
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 450);
            Controls.Add(lblMsg);
            Controls.Add(dgvDepartment);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtDept);
            Controls.Add(btnDelete);
            Name = "Departments";
            Text = "Departments";
            Load += Departments_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDepartment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private TextBox txtDept;
        private Label label1;
        private Button button1;
        private DataGridView dgvDepartment;
        private Label lblMsg;
    }
}