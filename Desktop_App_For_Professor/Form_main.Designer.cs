﻿using System.Windows.Forms;

namespace Desktop_App_For_Professor
{
    partial class Form_main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sTUDENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentInfomationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edittempToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailTempToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_classection = new System.Windows.Forms.Label();
            this.comboBoxClasses = new System.Windows.Forms.ComboBox();
            this.button_refrash = new System.Windows.Forms.Button();
            this.button_stdlist = new System.Windows.Forms.Button();
            this.button_read = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sTUDENTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(62, 35);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(93, 42);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // sTUDENTToolStripMenuItem
            // 
            this.sTUDENTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentInfomationToolStripMenuItem,
            this.edittempToolStripMenuItem,
            this.mailTempToolStripMenuItem});
            this.sTUDENTToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sTUDENTToolStripMenuItem.Name = "sTUDENTToolStripMenuItem";
            this.sTUDENTToolStripMenuItem.Size = new System.Drawing.Size(80, 38);
            this.sTUDENTToolStripMenuItem.Text = "Edit";
            // 
            // studentInfomationToolStripMenuItem
            // 
            this.studentInfomationToolStripMenuItem.Name = "studentInfomationToolStripMenuItem";
            this.studentInfomationToolStripMenuItem.Size = new System.Drawing.Size(270, 38);
            this.studentInfomationToolStripMenuItem.Text = "Hours(temp)";
            this.studentInfomationToolStripMenuItem.Click += new System.EventHandler(this.studentInfomationToolStripMenuItem_Click);
            // 
            // edittempToolStripMenuItem
            // 
            this.edittempToolStripMenuItem.Name = "edittempToolStripMenuItem";
            this.edittempToolStripMenuItem.Size = new System.Drawing.Size(270, 38);
            this.edittempToolStripMenuItem.Text = "Edit(temp)";
            this.edittempToolStripMenuItem.Click += new System.EventHandler(this.edittempToolStripMenuItem_Click);
            // 
            // mailTempToolStripMenuItem
            // 
            this.mailTempToolStripMenuItem.Name = "mailTempToolStripMenuItem";
            this.mailTempToolStripMenuItem.Size = new System.Drawing.Size(270, 38);
            this.mailTempToolStripMenuItem.Text = "Add(temp)";
            this.mailTempToolStripMenuItem.Click += new System.EventHandler(this.mailTempToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_classection);
            this.panel1.Controls.Add(this.comboBoxClasses);
            this.panel1.Controls.Add(this.button_refrash);
            this.panel1.Controls.Add(this.button_stdlist);
            this.panel1.Controls.Add(this.button_read);
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 593);
            this.panel1.TabIndex = 7;
            // 
            // label_classection
            // 
            this.label_classection.AutoSize = true;
            this.label_classection.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_classection.Location = new System.Drawing.Point(18, 33);
            this.label_classection.Name = "label_classection";
            this.label_classection.Size = new System.Drawing.Size(111, 23);
            this.label_classection.TabIndex = 11;
            this.label_classection.Text = "Your Class";
            this.label_classection.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxClasses
            // 
            this.comboBoxClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClasses.FormattingEnabled = true;
            this.comboBoxClasses.Location = new System.Drawing.Point(22, 59);
            this.comboBoxClasses.Name = "comboBoxClasses";
            this.comboBoxClasses.Size = new System.Drawing.Size(160, 24);
            this.comboBoxClasses.TabIndex = 10;
            this.comboBoxClasses.SelectedIndexChanged += new System.EventHandler(this.LoadProfessorClasses_SelectedIndexChanged);
            // 
            // button_refrash
            // 
            this.button_refrash.Location = new System.Drawing.Point(42, 251);
            this.button_refrash.Name = "button_refrash";
            this.button_refrash.Size = new System.Drawing.Size(113, 56);
            this.button_refrash.TabIndex = 1;
            this.button_refrash.Text = "button1";
            this.button_refrash.UseVisualStyleBackColor = true;
            // 
            // button_stdlist
            // 
            this.button_stdlist.Location = new System.Drawing.Point(42, 129);
            this.button_stdlist.Name = "button_stdlist";
            this.button_stdlist.Size = new System.Drawing.Size(113, 56);
            this.button_stdlist.TabIndex = 1;
            this.button_stdlist.Text = "Student List";
            this.button_stdlist.UseVisualStyleBackColor = true;
            this.button_stdlist.Click += new System.EventHandler(this.button_stdlist_Click);
            // 
            // button_read
            // 
            this.button_read.Location = new System.Drawing.Point(42, 191);
            this.button_read.Name = "button_read";
            this.button_read.Size = new System.Drawing.Size(113, 54);
            this.button_read.TabIndex = 0;
            this.button_read.Text = "read";
            this.button_read.UseVisualStyleBackColor = true;
            this.button_read.Click += new System.EventHandler(this.button_read_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(22, 9);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(2, 25);
            this.labelUsername.TabIndex = 9;
            this.labelUsername.Click += new System.EventHandler(this.labelUsername_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Controls.Add(this.labelUsername);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1262, 84);
            this.panel2.TabIndex = 10;
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.AllowUserToOrderColumns = true;
            this.dataGridViewStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewStudents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewStudents.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStudents.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewStudents.Location = new System.Drawing.Point(242, 113);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.ReadOnly = true;
            this.dataGridViewStudents.RowHeadersWidth = 51;
            this.dataGridViewStudents.RowTemplate.Height = 24;
            this.dataGridViewStudents.Size = new System.Drawing.Size(974, 493);
            this.dataGridViewStudents.TabIndex = 12;
            this.dataGridViewStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudents_CellContentClick);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.dataGridViewStudents);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_main";
            this.Load += new System.EventHandler(this.Form_main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sTUDENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentInfomationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edittempToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mailTempToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_read;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_refrash;
        private System.Windows.Forms.Button button_stdlist;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.ComboBox comboBoxClasses;
        private System.Windows.Forms.Label label_classection;
    }
}