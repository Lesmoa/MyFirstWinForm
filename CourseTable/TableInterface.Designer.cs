using System;
using System.Collections.Generic;
using System.Collections;

namespace CourseTable
{
    partial class TableInterface
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboCourse = new System.Windows.Forms.ComboBox();
            this.cboStartTime = new System.Windows.Forms.ComboBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.cboMemberID = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEcport = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dgvTimeTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCourse
            // 
            this.cboCourse.AccessibleName = "Course";
            this.cboCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCourse.FormattingEnabled = true;
            this.cboCourse.Location = new System.Drawing.Point(358, 45);
            this.cboCourse.Name = "cboCourse";
            this.cboCourse.Size = new System.Drawing.Size(223, 23);
            this.cboCourse.TabIndex = 0;
            this.cboCourse.SelectedIndexChanged += new System.EventHandler(this.cboCourse_SelectedIndexChanged);
            // 
            // cboStartTime
            // 
            this.cboStartTime.AccessibleName = "StartTime";
            this.cboStartTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStartTime.FormattingEnabled = true;
            this.cboStartTime.Location = new System.Drawing.Point(358, 91);
            this.cboStartTime.Name = "cboStartTime";
            this.cboStartTime.Size = new System.Drawing.Size(223, 23);
            this.cboStartTime.TabIndex = 1;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(278, 48);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(55, 15);
            this.lblCourse.TabIndex = 2;
            this.lblCourse.Text = "Course";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(267, 94);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(79, 15);
            this.lblStartTime.TabIndex = 3;
            this.lblStartTime.Text = "StartTime";
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Location = new System.Drawing.Point(21, 45);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(71, 15);
            this.lblMemberID.TabIndex = 4;
            this.lblMemberID.Text = "MemberID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(36, 91);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // cboMemberID
            // 
            this.cboMemberID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMemberID.FormattingEnabled = true;
            this.cboMemberID.Location = new System.Drawing.Point(98, 42);
            this.cboMemberID.Name = "cboMemberID";
            this.cboMemberID.Size = new System.Drawing.Size(121, 23);
            this.cboMemberID.TabIndex = 6;
            this.cboMemberID.SelectedIndexChanged += new System.EventHandler(this.cboMemberID_SelectedIndexChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(766, 136);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnEcport
            // 
            this.btnEcport.Location = new System.Drawing.Point(870, 136);
            this.btnEcport.Name = "btnEcport";
            this.btnEcport.Size = new System.Drawing.Size(143, 23);
            this.btnEcport.TabIndex = 14;
            this.btnEcport.Text = "Export_To_Excel";
            this.btnEcport.Click += new System.EventHandler(this.btnEcport_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(506, 136);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 11;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(98, 91);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(121, 25);
            this.txtName.TabIndex = 12;
            // 
            // dgvTimeTable
            // 
            this.dgvTimeTable.AllowUserToAddRows = false;
            this.dgvTimeTable.AllowUserToDeleteRows = false;
            this.dgvTimeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimeTable.Location = new System.Drawing.Point(24, 184);
            this.dgvTimeTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTimeTable.Name = "dgvTimeTable";
            this.dgvTimeTable.ReadOnly = true;
            this.dgvTimeTable.RowTemplate.Height = 30;
            this.dgvTimeTable.Size = new System.Drawing.Size(1015, 514);
            this.dgvTimeTable.TabIndex = 13;
            this.dgvTimeTable.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvTimeTable_CellPainting);
            // 
            // TableInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvTimeTable);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnEcport);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cboMemberID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblMemberID);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.cboStartTime);
            this.Controls.Add(this.cboCourse);
            this.Name = "TableInterface";
            this.Size = new System.Drawing.Size(1068, 726);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCourse;
        private System.Windows.Forms.ComboBox cboStartTime;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cboMemberID;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEcport;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dgvTimeTable;
    }
}
