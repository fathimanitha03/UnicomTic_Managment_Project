namespace UnicomTic_Management.View
{
    partial class TimetableForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimetableID = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.dgvTimetables = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetables)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "TimeTable";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "TimeTable ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time :";
            // 
            // txtTimetableID
            // 
            this.txtTimetableID.Location = new System.Drawing.Point(164, 84);
            this.txtTimetableID.Name = "txtTimetableID";
            this.txtTimetableID.ReadOnly = true;
            this.txtTimetableID.Size = new System.Drawing.Size(367, 20);
            this.txtTimetableID.TabIndex = 3;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(164, 115);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(367, 20);
            this.txtTime.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Day  :";
            // 
            // cmbDay
            // 
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Location = new System.Drawing.Point(164, 147);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(121, 21);
            this.cmbDay.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Subject :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Course :";
            // 
            // cmbSubject
            // 
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(164, 181);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(121, 21);
            this.cmbSubject.TabIndex = 9;
            // 
            // cmbCourse
            // 
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(164, 219);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(121, 21);
            this.cmbCourse.TabIndex = 10;
            // 
            // dgvTimetables
            // 
            this.dgvTimetables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimetables.Location = new System.Drawing.Point(291, 147);
            this.dgvTimetables.Name = "dgvTimetables";
            this.dgvTimetables.Size = new System.Drawing.Size(240, 93);
            this.dgvTimetables.TabIndex = 11;
            this.dgvTimetables.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimetables_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(91, 269);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 30);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(226, 269);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 30);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(355, 269);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 30);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(482, 269);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 30);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // TimetableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(641, 350);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvTimetables);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbDay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtTimetableID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimetableForm";
            this.Text = "TimetableForm";
            this.Load += new System.EventHandler(this.TimetableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTimetableID;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.DataGridView dgvTimetables;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
    }
}