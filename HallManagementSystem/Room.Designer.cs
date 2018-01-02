namespace HallManagementSystem
{
    partial class Room
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
            this.allotOfStudent = new System.Windows.Forms.TabPage();
            this.txtRoomStuId = new System.Windows.Forms.ComboBox();
            this.txtRoomStuRoom = new System.Windows.Forms.ComboBox();
            this.addStudentBtn = new System.Windows.Forms.Button();
            this.txtRoomDateOfAllot = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addRoom = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addRoomBtn = new System.Windows.Forms.Button();
            this.txtaBlock = new System.Windows.Forms.ComboBox();
            this.txtaFloor = new System.Windows.Forms.ComboBox();
            this.txtaRoomNo = new System.Windows.Forms.TextBox();
            this.stuRoomSearch = new System.Windows.Forms.TabPage();
            this.Search = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.searchRoomStuDataGridView = new System.Windows.Forms.DataGridView();
            this.comsrRoomSearch = new System.Windows.Forms.ComboBox();
            this.roomSearch = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchRoom = new System.Windows.Forms.ComboBox();
            this.roomSearchBtn = new System.Windows.Forms.Button();
            this.roomDataGridView = new System.Windows.Forms.DataGridView();
            this.roomUpdate = new System.Windows.Forms.TabPage();
            this.updateRoom = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comruNewRoom = new System.Windows.Forms.ComboBox();
            this.comruOldRoom = new System.Windows.Forms.ComboBox();
            this.comruStudentId = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.allotOfStudent.SuspendLayout();
            this.addRoom.SuspendLayout();
            this.stuRoomSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchRoomStuDataGridView)).BeginInit();
            this.roomSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomDataGridView)).BeginInit();
            this.roomUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.allotOfStudent);
            this.tabControl1.Controls.Add(this.addRoom);
            this.tabControl1.Controls.Add(this.stuRoomSearch);
            this.tabControl1.Controls.Add(this.roomSearch);
            this.tabControl1.Controls.Add(this.roomUpdate);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(613, 494);
            this.tabControl1.TabIndex = 0;
            // 
            // allotOfStudent
            // 
            this.allotOfStudent.Controls.Add(this.txtRoomStuId);
            this.allotOfStudent.Controls.Add(this.txtRoomStuRoom);
            this.allotOfStudent.Controls.Add(this.addStudentBtn);
            this.allotOfStudent.Controls.Add(this.txtRoomDateOfAllot);
            this.allotOfStudent.Controls.Add(this.label3);
            this.allotOfStudent.Controls.Add(this.label2);
            this.allotOfStudent.Controls.Add(this.label1);
            this.allotOfStudent.Location = new System.Drawing.Point(4, 24);
            this.allotOfStudent.Name = "allotOfStudent";
            this.allotOfStudent.Padding = new System.Windows.Forms.Padding(3);
            this.allotOfStudent.Size = new System.Drawing.Size(692, 532);
            this.allotOfStudent.TabIndex = 0;
            this.allotOfStudent.Text = "Allot Student At Room";
            this.allotOfStudent.UseVisualStyleBackColor = true;
            // 
            // txtRoomStuId
            // 
            this.txtRoomStuId.FormattingEnabled = true;
            this.txtRoomStuId.Location = new System.Drawing.Point(178, 57);
            this.txtRoomStuId.Name = "txtRoomStuId";
            this.txtRoomStuId.Size = new System.Drawing.Size(233, 23);
            this.txtRoomStuId.TabIndex = 9;
            // 
            // txtRoomStuRoom
            // 
            this.txtRoomStuRoom.FormattingEnabled = true;
            this.txtRoomStuRoom.Location = new System.Drawing.Point(178, 105);
            this.txtRoomStuRoom.Name = "txtRoomStuRoom";
            this.txtRoomStuRoom.Size = new System.Drawing.Size(233, 23);
            this.txtRoomStuRoom.TabIndex = 8;
            this.txtRoomStuRoom.SelectedIndexChanged += new System.EventHandler(this.txtRoomStuRoom_SelectedIndexChanged);
            // 
            // addStudentBtn
            // 
            this.addStudentBtn.Location = new System.Drawing.Point(288, 230);
            this.addStudentBtn.Name = "addStudentBtn";
            this.addStudentBtn.Size = new System.Drawing.Size(134, 27);
            this.addStudentBtn.TabIndex = 7;
            this.addStudentBtn.Text = "Add Student";
            this.addStudentBtn.UseVisualStyleBackColor = true;
            this.addStudentBtn.Click += new System.EventHandler(this.addStudentBtn_Click);
            // 
            // txtRoomDateOfAllot
            // 
            this.txtRoomDateOfAllot.Location = new System.Drawing.Point(178, 159);
            this.txtRoomDateOfAllot.Name = "txtRoomDateOfAllot";
            this.txtRoomDateOfAllot.Size = new System.Drawing.Size(233, 22);
            this.txtRoomDateOfAllot.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(34, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date Of Allotment :";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(34, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Room No :";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(34, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID :";
            // 
            // addRoom
            // 
            this.addRoom.Controls.Add(this.label6);
            this.addRoom.Controls.Add(this.label5);
            this.addRoom.Controls.Add(this.label4);
            this.addRoom.Controls.Add(this.addRoomBtn);
            this.addRoom.Controls.Add(this.txtaBlock);
            this.addRoom.Controls.Add(this.txtaFloor);
            this.addRoom.Controls.Add(this.txtaRoomNo);
            this.addRoom.Location = new System.Drawing.Point(4, 24);
            this.addRoom.Name = "addRoom";
            this.addRoom.Size = new System.Drawing.Size(692, 532);
            this.addRoom.TabIndex = 2;
            this.addRoom.Text = "Add Room";
            this.addRoom.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(61, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Block :";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(61, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Floor :";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(61, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Room No :";
            // 
            // addRoomBtn
            // 
            this.addRoomBtn.Location = new System.Drawing.Point(289, 204);
            this.addRoomBtn.Name = "addRoomBtn";
            this.addRoomBtn.Size = new System.Drawing.Size(87, 27);
            this.addRoomBtn.TabIndex = 3;
            this.addRoomBtn.Text = "Add";
            this.addRoomBtn.UseVisualStyleBackColor = true;
            this.addRoomBtn.Click += new System.EventHandler(this.addRoomBtn_Click);
            // 
            // txtaBlock
            // 
            this.txtaBlock.FormattingEnabled = true;
            this.txtaBlock.Items.AddRange(new object[] {
            "A",
            "B"});
            this.txtaBlock.Location = new System.Drawing.Point(167, 141);
            this.txtaBlock.Name = "txtaBlock";
            this.txtaBlock.Size = new System.Drawing.Size(210, 23);
            this.txtaBlock.TabIndex = 2;
            // 
            // txtaFloor
            // 
            this.txtaFloor.FormattingEnabled = true;
            this.txtaFloor.Items.AddRange(new object[] {
            "Ground",
            "1st",
            "2nd",
            "3rd"});
            this.txtaFloor.Location = new System.Drawing.Point(167, 90);
            this.txtaFloor.Name = "txtaFloor";
            this.txtaFloor.Size = new System.Drawing.Size(210, 23);
            this.txtaFloor.TabIndex = 1;
            // 
            // txtaRoomNo
            // 
            this.txtaRoomNo.Location = new System.Drawing.Point(167, 42);
            this.txtaRoomNo.Name = "txtaRoomNo";
            this.txtaRoomNo.Size = new System.Drawing.Size(210, 22);
            this.txtaRoomNo.TabIndex = 0;
            // 
            // stuRoomSearch
            // 
            this.stuRoomSearch.Controls.Add(this.Search);
            this.stuRoomSearch.Controls.Add(this.label8);
            this.stuRoomSearch.Controls.Add(this.searchRoomStuDataGridView);
            this.stuRoomSearch.Controls.Add(this.comsrRoomSearch);
            this.stuRoomSearch.Location = new System.Drawing.Point(4, 24);
            this.stuRoomSearch.Name = "stuRoomSearch";
            this.stuRoomSearch.Size = new System.Drawing.Size(605, 466);
            this.stuRoomSearch.TabIndex = 3;
            this.stuRoomSearch.Text = "Student\'s Room Search";
            this.stuRoomSearch.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(443, 30);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(87, 27);
            this.Search.TabIndex = 3;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(72, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 27);
            this.label8.TabIndex = 2;
            this.label8.Text = "Student_ID :";
            // 
            // searchRoomStuDataGridView
            // 
            this.searchRoomStuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchRoomStuDataGridView.Location = new System.Drawing.Point(7, 99);
            this.searchRoomStuDataGridView.Name = "searchRoomStuDataGridView";
            this.searchRoomStuDataGridView.Size = new System.Drawing.Size(595, 353);
            this.searchRoomStuDataGridView.TabIndex = 1;
            // 
            // comsrRoomSearch
            // 
            this.comsrRoomSearch.FormattingEnabled = true;
            this.comsrRoomSearch.Location = new System.Drawing.Point(182, 30);
            this.comsrRoomSearch.Name = "comsrRoomSearch";
            this.comsrRoomSearch.Size = new System.Drawing.Size(161, 23);
            this.comsrRoomSearch.TabIndex = 0;
            // 
            // roomSearch
            // 
            this.roomSearch.Controls.Add(this.label7);
            this.roomSearch.Controls.Add(this.txtSearchRoom);
            this.roomSearch.Controls.Add(this.roomSearchBtn);
            this.roomSearch.Controls.Add(this.roomDataGridView);
            this.roomSearch.Location = new System.Drawing.Point(4, 24);
            this.roomSearch.Name = "roomSearch";
            this.roomSearch.Padding = new System.Windows.Forms.Padding(3);
            this.roomSearch.Size = new System.Drawing.Size(605, 466);
            this.roomSearch.TabIndex = 1;
            this.roomSearch.Text = "Student Search By Room_No";
            this.roomSearch.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(143, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 27);
            this.label7.TabIndex = 4;
            this.label7.Text = "Room No:";
            // 
            // txtSearchRoom
            // 
            this.txtSearchRoom.FormattingEnabled = true;
            this.txtSearchRoom.Location = new System.Drawing.Point(249, 36);
            this.txtSearchRoom.Name = "txtSearchRoom";
            this.txtSearchRoom.Size = new System.Drawing.Size(140, 23);
            this.txtSearchRoom.TabIndex = 3;
            // 
            // roomSearchBtn
            // 
            this.roomSearchBtn.Location = new System.Drawing.Point(426, 33);
            this.roomSearchBtn.Name = "roomSearchBtn";
            this.roomSearchBtn.Size = new System.Drawing.Size(87, 27);
            this.roomSearchBtn.TabIndex = 2;
            this.roomSearchBtn.Text = "Search";
            this.roomSearchBtn.UseVisualStyleBackColor = true;
            this.roomSearchBtn.Click += new System.EventHandler(this.roomSearchBtn_Click);
            // 
            // roomDataGridView
            // 
            this.roomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomDataGridView.Location = new System.Drawing.Point(7, 99);
            this.roomDataGridView.Name = "roomDataGridView";
            this.roomDataGridView.Size = new System.Drawing.Size(677, 402);
            this.roomDataGridView.TabIndex = 0;
            // 
            // roomUpdate
            // 
            this.roomUpdate.Controls.Add(this.updateRoom);
            this.roomUpdate.Controls.Add(this.label11);
            this.roomUpdate.Controls.Add(this.label10);
            this.roomUpdate.Controls.Add(this.label9);
            this.roomUpdate.Controls.Add(this.comruNewRoom);
            this.roomUpdate.Controls.Add(this.comruOldRoom);
            this.roomUpdate.Controls.Add(this.comruStudentId);
            this.roomUpdate.Location = new System.Drawing.Point(4, 24);
            this.roomUpdate.Name = "roomUpdate";
            this.roomUpdate.Size = new System.Drawing.Size(692, 532);
            this.roomUpdate.TabIndex = 4;
            this.roomUpdate.Text = "Room Update";
            this.roomUpdate.UseVisualStyleBackColor = true;
            // 
            // updateRoom
            // 
            this.updateRoom.Location = new System.Drawing.Point(359, 225);
            this.updateRoom.Name = "updateRoom";
            this.updateRoom.Size = new System.Drawing.Size(87, 27);
            this.updateRoom.TabIndex = 6;
            this.updateRoom.Text = "Update";
            this.updateRoom.UseVisualStyleBackColor = true;
            this.updateRoom.Click += new System.EventHandler(this.updateRoom_Click);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(49, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 24);
            this.label11.TabIndex = 5;
            this.label11.Text = "New Room Number :";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(49, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 24);
            this.label10.TabIndex = 4;
            this.label10.Text = "Old Room Number :";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(49, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 27);
            this.label9.TabIndex = 3;
            this.label9.Text = "Student ID :";
            // 
            // comruNewRoom
            // 
            this.comruNewRoom.FormattingEnabled = true;
            this.comruNewRoom.Location = new System.Drawing.Point(201, 144);
            this.comruNewRoom.Name = "comruNewRoom";
            this.comruNewRoom.Size = new System.Drawing.Size(210, 23);
            this.comruNewRoom.TabIndex = 2;
            // 
            // comruOldRoom
            // 
            this.comruOldRoom.FormattingEnabled = true;
            this.comruOldRoom.Location = new System.Drawing.Point(201, 91);
            this.comruOldRoom.Name = "comruOldRoom";
            this.comruOldRoom.Size = new System.Drawing.Size(210, 23);
            this.comruOldRoom.TabIndex = 1;
            // 
            // comruStudentId
            // 
            this.comruStudentId.FormattingEnabled = true;
            this.comruStudentId.Location = new System.Drawing.Point(201, 44);
            this.comruStudentId.Name = "comruStudentId";
            this.comruStudentId.Size = new System.Drawing.Size(210, 23);
            this.comruStudentId.TabIndex = 0;
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 482);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Room";
            this.Text = "Room";
            this.Load += new System.EventHandler(this.Room_Load);
            this.tabControl1.ResumeLayout(false);
            this.allotOfStudent.ResumeLayout(false);
            this.addRoom.ResumeLayout(false);
            this.addRoom.PerformLayout();
            this.stuRoomSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchRoomStuDataGridView)).EndInit();
            this.roomSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomDataGridView)).EndInit();
            this.roomUpdate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage allotOfStudent;
        private System.Windows.Forms.TabPage roomSearch;
        private System.Windows.Forms.Button addStudentBtn;
        private System.Windows.Forms.DateTimePicker txtRoomDateOfAllot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button roomSearchBtn;
        private System.Windows.Forms.DataGridView roomDataGridView;
        private System.Windows.Forms.TabPage addRoom;
        private System.Windows.Forms.ComboBox txtaBlock;
        private System.Windows.Forms.ComboBox txtaFloor;
        private System.Windows.Forms.TextBox txtaRoomNo;
        private System.Windows.Forms.ComboBox txtRoomStuRoom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addRoomBtn;
        private System.Windows.Forms.ComboBox txtSearchRoom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox txtRoomStuId;
        private System.Windows.Forms.TabPage stuRoomSearch;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView searchRoomStuDataGridView;
        private System.Windows.Forms.ComboBox comsrRoomSearch;
        private System.Windows.Forms.TabPage roomUpdate;
        private System.Windows.Forms.Button updateRoom;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comruNewRoom;
        private System.Windows.Forms.ComboBox comruOldRoom;
        private System.Windows.Forms.ComboBox comruStudentId;
    }
}