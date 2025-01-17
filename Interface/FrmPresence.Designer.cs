﻿namespace CourseManagement
{
    partial class FrmPresence
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPresence));
            this.dgvListPresence = new System.Windows.Forms.DataGridView();
            this.presence = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.imageCheck = new System.Windows.Forms.DataGridViewImageColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonForAbsence = new System.Windows.Forms.DataGridViewImageColumn();
            this.descriptionReasonForAbsence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonForAbsenceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listAttendance_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirmPresence = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtDatePresence = new System.Windows.Forms.DateTimePicker();
            this.lblQuantityAbove = new System.Windows.Forms.Label();
            this.lblQUantityBellows = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPresence)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListPresence
            // 
            this.dgvListPresence.AllowUserToAddRows = false;
            this.dgvListPresence.AllowUserToDeleteRows = false;
            this.dgvListPresence.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListPresence.BackgroundColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListPresence.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListPresence.ColumnHeadersHeight = 40;
            this.dgvListPresence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListPresence.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.presence,
            this.imageCheck,
            this.id,
            this.name,
            this.gender,
            this.classStudent,
            this.shift,
            this.reasonForAbsence,
            this.descriptionReasonForAbsence,
            this.reasonForAbsenceId,
            this.listAttendance_id});
            this.dgvListPresence.EnableHeadersVisualStyles = false;
            this.dgvListPresence.Location = new System.Drawing.Point(14, 101);
            this.dgvListPresence.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListPresence.Name = "dgvListPresence";
            this.dgvListPresence.RowHeadersVisible = false;
            this.dgvListPresence.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvListPresence.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListPresence.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListPresence.Size = new System.Drawing.Size(942, 325);
            this.dgvListPresence.TabIndex = 4;
            this.dgvListPresence.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListPresence_CellClick);
            this.dgvListPresence.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListPresence_CellMouseEnter);
            // 
            // presence
            // 
            this.presence.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.NullValue = false;
            this.presence.DefaultCellStyle = dataGridViewCellStyle2;
            this.presence.HeaderText = "";
            this.presence.MinimumWidth = 50;
            this.presence.Name = "presence";
            this.presence.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.presence.Visible = false;
            this.presence.Width = 50;
            // 
            // imageCheck
            // 
            this.imageCheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.imageCheck.HeaderText = "";
            this.imageCheck.MinimumWidth = 50;
            this.imageCheck.Name = "imageCheck";
            this.imageCheck.Width = 50;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.DataPropertyName = "id";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.id.DefaultCellStyle = dataGridViewCellStyle3;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id.Visible = false;
            this.id.Width = 32;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Nome";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gender
            // 
            this.gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gender.DefaultCellStyle = dataGridViewCellStyle4;
            this.gender.HeaderText = "Gênero";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gender.Width = 69;
            // 
            // classStudent
            // 
            this.classStudent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.classStudent.DataPropertyName = "class";
            this.classStudent.HeaderText = "Turma";
            this.classStudent.MinimumWidth = 6;
            this.classStudent.Name = "classStudent";
            this.classStudent.ReadOnly = true;
            this.classStudent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.classStudent.Width = 60;
            // 
            // shift
            // 
            this.shift.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.shift.HeaderText = "Turno";
            this.shift.MinimumWidth = 6;
            this.shift.Name = "shift";
            this.shift.ReadOnly = true;
            this.shift.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.shift.Width = 56;
            // 
            // reasonForAbsence
            // 
            this.reasonForAbsence.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.reasonForAbsence.HeaderText = "M. F.";
            this.reasonForAbsence.MinimumWidth = 50;
            this.reasonForAbsence.Name = "reasonForAbsence";
            this.reasonForAbsence.ToolTipText = "Motivo da falta";
            this.reasonForAbsence.Width = 50;
            // 
            // descriptionReasonForAbsence
            // 
            this.descriptionReasonForAbsence.HeaderText = "Motivo da Falta";
            this.descriptionReasonForAbsence.Name = "descriptionReasonForAbsence";
            this.descriptionReasonForAbsence.Visible = false;
            // 
            // reasonForAbsenceId
            // 
            this.reasonForAbsenceId.HeaderText = "reasonForAbsenceId";
            this.reasonForAbsenceId.Name = "reasonForAbsenceId";
            this.reasonForAbsenceId.Visible = false;
            // 
            // listAttendance_id
            // 
            this.listAttendance_id.HeaderText = "listAttendance_id";
            this.listAttendance_id.MinimumWidth = 6;
            this.listAttendance_id.Name = "listAttendance_id";
            this.listAttendance_id.Visible = false;
            this.listAttendance_id.Width = 125;
            // 
            // cbClass
            // 
            this.cbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(14, 41);
            this.cbClass.Margin = new System.Windows.Forms.Padding(4);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(419, 28);
            this.cbClass.TabIndex = 5;
            this.cbClass.SelectedIndexChanged += new System.EventHandler(this.cbClass_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Turma";
            // 
            // btnConfirmPresence
            // 
            this.btnConfirmPresence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmPresence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmPresence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmPresence.ForeColor = System.Drawing.Color.White;
            this.btnConfirmPresence.Location = new System.Drawing.Point(709, 434);
            this.btnConfirmPresence.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmPresence.Name = "btnConfirmPresence";
            this.btnConfirmPresence.Size = new System.Drawing.Size(247, 55);
            this.btnConfirmPresence.TabIndex = 7;
            this.btnConfirmPresence.Text = "Confirmar Presença";
            this.btnConfirmPresence.UseVisualStyleBackColor = true;
            this.btnConfirmPresence.Click += new System.EventHandler(this.btnConfirmPresence_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Data";
            // 
            // dtDatePresence
            // 
            this.dtDatePresence.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDatePresence.Location = new System.Drawing.Point(446, 42);
            this.dtDatePresence.Margin = new System.Windows.Forms.Padding(4);
            this.dtDatePresence.Name = "dtDatePresence";
            this.dtDatePresence.Size = new System.Drawing.Size(135, 26);
            this.dtDatePresence.TabIndex = 10;
            this.dtDatePresence.ValueChanged += new System.EventHandler(this.dtDatePresence_ValueChanged);
            // 
            // lblQuantityAbove
            // 
            this.lblQuantityAbove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblQuantityAbove.AutoSize = true;
            this.lblQuantityAbove.Location = new System.Drawing.Point(15, 434);
            this.lblQuantityAbove.Name = "lblQuantityAbove";
            this.lblQuantityAbove.Size = new System.Drawing.Size(0, 20);
            this.lblQuantityAbove.TabIndex = 11;
            this.lblQuantityAbove.Visible = false;
            // 
            // lblQUantityBellows
            // 
            this.lblQUantityBellows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblQUantityBellows.AutoSize = true;
            this.lblQUantityBellows.Location = new System.Drawing.Point(15, 469);
            this.lblQUantityBellows.Name = "lblQUantityBellows";
            this.lblQUantityBellows.Size = new System.Drawing.Size(0, 20);
            this.lblQUantityBellows.TabIndex = 12;
            this.lblQUantityBellows.Visible = false;
            // 
            // FrmPresence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(976, 504);
            this.Controls.Add(this.lblQUantityBellows);
            this.Controls.Add(this.lblQuantityAbove);
            this.Controls.Add(this.dtDatePresence);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirmPresence);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvListPresence);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimizeBox = false;
            this.Name = "FrmPresence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Presença";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPresence_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPresence_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPresence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListPresence;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirmPresence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtDatePresence;
        private System.Windows.Forms.Label lblQuantityAbove;
        private System.Windows.Forms.Label lblQUantityBellows;
        private System.Windows.Forms.DataGridViewCheckBoxColumn presence;
        private System.Windows.Forms.DataGridViewImageColumn imageCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn classStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn shift;
        private System.Windows.Forms.DataGridViewImageColumn reasonForAbsence;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionReasonForAbsence;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonForAbsenceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn listAttendance_id;
    }
}