namespace arraylist3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSave = new Button();
            btnDelete = new Button();
            txtEmpName = new TextBox();
            txtSalary = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblMsg = new Label();
            ddlDept = new ComboBox();
            dgvEmployee = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(769, 33);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(769, 105);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtEmpName
            // 
            txtEmpName.Location = new Point(154, 36);
            txtEmpName.Name = "txtEmpName";
            txtEmpName.Size = new Size(246, 31);
            txtEmpName.TabIndex = 2;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(494, 36);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(223, 31);
            txtSalary.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 36);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 5;
            label1.Text = "Emp Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(429, 39);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 6;
            label2.Text = "Salary";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 112);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 7;
            label3.Text = "Department";
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.Location = new Point(27, 170);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(0, 25);
            lblMsg.TabIndex = 8;
            // 
            // ddlDept
            // 
            ddlDept.FormattingEnabled = true;
            ddlDept.Location = new Point(154, 107);
            ddlDept.Name = "ddlDept";
            ddlDept.Size = new Size(246, 33);
            ddlDept.TabIndex = 9;
            // 
            // dgvEmployee
            // 
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Location = new Point(1, 209);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowHeadersWidth = 62;
            dgvEmployee.RowTemplate.Height = 33;
            dgvEmployee.Size = new Size(937, 364);
            dgvEmployee.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 575);
            Controls.Add(dgvEmployee);
            Controls.Add(ddlDept);
            Controls.Add(lblMsg);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSalary);
            Controls.Add(txtEmpName);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnDelete;
        private TextBox txtEmpName;
        private TextBox txtSalary;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblMsg;
        private ComboBox ddlDept;
        private DataGridView dgvEmployee;
    }
}