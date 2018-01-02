namespace HallManagementSystem
{
    partial class Department
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.departView = new System.Windows.Forms.TabPage();
            this.deptViewDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.deptViewBtn = new System.Windows.Forms.Button();
            this.comDeptName = new System.Windows.Forms.ComboBox();
            this.batchView = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.comBatchName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.batchViewDataGridView = new System.Windows.Forms.DataGridView();
            this.comBatchDeptName = new System.Windows.Forms.ComboBox();
            this.batchViewBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.departView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deptViewDataGridView)).BeginInit();
            this.batchView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batchViewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.departView);
            this.tabControl1.Controls.Add(this.batchView);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(610, 476);
            this.tabControl1.TabIndex = 0;
            // 
            // departView
            // 
            this.departView.Controls.Add(this.deptViewDataGridView);
            this.departView.Controls.Add(this.label1);
            this.departView.Controls.Add(this.deptViewBtn);
            this.departView.Controls.Add(this.comDeptName);
            this.departView.Location = new System.Drawing.Point(4, 24);
            this.departView.Name = "departView";
            this.departView.Padding = new System.Windows.Forms.Padding(3);
            this.departView.Size = new System.Drawing.Size(602, 448);
            this.departView.TabIndex = 0;
            this.departView.Text = "Department Wise View";
            this.departView.UseVisualStyleBackColor = true;
            // 
            // deptViewDataGridView
            // 
            this.deptViewDataGridView.AllowUserToAddRows = false;
            this.deptViewDataGridView.AllowUserToDeleteRows = false;
            this.deptViewDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.deptViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deptViewDataGridView.Location = new System.Drawing.Point(3, 73);
            this.deptViewDataGridView.Name = "deptViewDataGridView";
            this.deptViewDataGridView.RowHeadersVisible = false;
            this.deptViewDataGridView.Size = new System.Drawing.Size(597, 365);
            this.deptViewDataGridView.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(90, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Depart Name :";
            // 
            // deptViewBtn
            // 
            this.deptViewBtn.Location = new System.Drawing.Point(421, 23);
            this.deptViewBtn.Name = "deptViewBtn";
            this.deptViewBtn.Size = new System.Drawing.Size(87, 27);
            this.deptViewBtn.TabIndex = 1;
            this.deptViewBtn.Text = "View";
            this.deptViewBtn.UseVisualStyleBackColor = true;
            this.deptViewBtn.Click += new System.EventHandler(this.deptViewBtn_Click);
            // 
            // comDeptName
            // 
            this.comDeptName.FormattingEnabled = true;
            this.comDeptName.Location = new System.Drawing.Point(201, 27);
            this.comDeptName.Name = "comDeptName";
            this.comDeptName.Size = new System.Drawing.Size(195, 23);
            this.comDeptName.TabIndex = 0;
            // 
            // batchView
            // 
            this.batchView.Controls.Add(this.label3);
            this.batchView.Controls.Add(this.comBatchName);
            this.batchView.Controls.Add(this.label2);
            this.batchView.Controls.Add(this.batchViewDataGridView);
            this.batchView.Controls.Add(this.comBatchDeptName);
            this.batchView.Controls.Add(this.batchViewBtn);
            this.batchView.Location = new System.Drawing.Point(4, 24);
            this.batchView.Name = "batchView";
            this.batchView.Padding = new System.Windows.Forms.Padding(3);
            this.batchView.Size = new System.Drawing.Size(602, 448);
            this.batchView.TabIndex = 1;
            this.batchView.Text = "Batch Wise View";
            this.batchView.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(284, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Batch :";
            // 
            // comBatchName
            // 
            this.comBatchName.FormattingEnabled = true;
            this.comBatchName.Items.AddRange(new object[] {
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015"});
            this.comBatchName.Location = new System.Drawing.Point(341, 36);
            this.comBatchName.Name = "comBatchName";
            this.comBatchName.Size = new System.Drawing.Size(140, 23);
            this.comBatchName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Department Name :";
            // 
            // batchViewDataGridView
            // 
            this.batchViewDataGridView.AllowUserToAddRows = false;
            this.batchViewDataGridView.AllowUserToDeleteRows = false;
            this.batchViewDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.batchViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.batchViewDataGridView.Location = new System.Drawing.Point(7, 137);
            this.batchViewDataGridView.Name = "batchViewDataGridView";
            this.batchViewDataGridView.RowHeadersVisible = false;
            this.batchViewDataGridView.Size = new System.Drawing.Size(678, 375);
            this.batchViewDataGridView.TabIndex = 2;
            // 
            // comBatchDeptName
            // 
            this.comBatchDeptName.FormattingEnabled = true;
            this.comBatchDeptName.Location = new System.Drawing.Point(135, 36);
            this.comBatchDeptName.Name = "comBatchDeptName";
            this.comBatchDeptName.Size = new System.Drawing.Size(133, 23);
            this.comBatchDeptName.TabIndex = 1;
            // 
            // batchViewBtn
            // 
            this.batchViewBtn.Location = new System.Drawing.Point(499, 33);
            this.batchViewBtn.Name = "batchViewBtn";
            this.batchViewBtn.Size = new System.Drawing.Size(81, 27);
            this.batchViewBtn.TabIndex = 0;
            this.batchViewBtn.Text = "View";
            this.batchViewBtn.UseVisualStyleBackColor = true;
            this.batchViewBtn.Click += new System.EventHandler(this.batchViewBtn_Click);
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 491);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Department";
            this.Text = "Department";
            this.Load += new System.EventHandler(this.Department_Load);
            this.tabControl1.ResumeLayout(false);
            this.departView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deptViewDataGridView)).EndInit();
            this.batchView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.batchViewDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage departView;
        private System.Windows.Forms.DataGridView deptViewDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deptViewBtn;
        private System.Windows.Forms.ComboBox comDeptName;
        private System.Windows.Forms.TabPage batchView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comBatchName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView batchViewDataGridView;
        private System.Windows.Forms.ComboBox comBatchDeptName;
        private System.Windows.Forms.Button batchViewBtn;
    }
}