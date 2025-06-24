namespace UnicomTic_Management.View
{
    partial class ExamForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtExamID = new System.Windows.Forms.TextBox();
            this.txtExamName = new System.Windows.Forms.TextBox();
            this.dtpExamDate = new System.Windows.Forms.DateTimePicker();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.dgvExams = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExams)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Exam ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Exam Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Exam Date  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Course  :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Subject  :";
            // 
            // txtExamID
            // 
            this.txtExamID.Location = new System.Drawing.Point(191, 68);
            this.txtExamID.Name = "txtExamID";
            this.txtExamID.ReadOnly = true;
            this.txtExamID.Size = new System.Drawing.Size(268, 20);
            this.txtExamID.TabIndex = 6;
            // 
            // txtExamName
            // 
            this.txtExamName.Location = new System.Drawing.Point(191, 94);
            this.txtExamName.Name = "txtExamName";
            this.txtExamName.Size = new System.Drawing.Size(268, 20);
            this.txtExamName.TabIndex = 7;
            // 
            // dtpExamDate
            // 
            this.dtpExamDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExamDate.Location = new System.Drawing.Point(191, 138);
            this.dtpExamDate.Name = "dtpExamDate";
            this.dtpExamDate.Size = new System.Drawing.Size(139, 20);
            this.dtpExamDate.TabIndex = 8;
            // 
            // cmbCourse
            // 
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(191, 173);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(121, 21);
            this.cmbCourse.TabIndex = 9;
            // 
            // cmbSubject
            // 
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(191, 211);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(121, 21);
            this.cmbSubject.TabIndex = 10;
            // 
            // dgvExams
            // 
            this.dgvExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExams.Location = new System.Drawing.Point(349, 138);
            this.dgvExams.Name = "dgvExams";
            this.dgvExams.Size = new System.Drawing.Size(240, 94);
            this.dgvExams.TabIndex = 11;
            this.dgvExams.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExams_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(97, 277);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 34);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(233, 277);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 34);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(374, 277);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 34);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(492, 277);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 34);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(631, 333);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvExams);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.dtpExamDate);
            this.Controls.Add(this.txtExamName);
            this.Controls.Add(this.txtExamID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExamForm";
            this.Text = "ExamForm";
            this.Load += new System.EventHandler(this.ExamForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtExamID;
        private System.Windows.Forms.TextBox txtExamName;
        private System.Windows.Forms.DateTimePicker dtpExamDate;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.DataGridView dgvExams;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
    }
}