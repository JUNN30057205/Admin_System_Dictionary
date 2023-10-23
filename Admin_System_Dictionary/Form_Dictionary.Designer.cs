﻿namespace Admin_System_Dictionary
{
    partial class Form_Dictionary
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
            this.ListBox_AllStaff = new System.Windows.Forms.ListBox();
            this.ListBox_Filtered = new System.Windows.Forms.ListBox();
            this.label_StaffID = new System.Windows.Forms.Label();
            this.label_StaffName = new System.Windows.Forms.Label();
            this.TextBox_StaffID = new System.Windows.Forms.TextBox();
            this.TextBox_StaffName = new System.Windows.Forms.TextBox();
            this.GBox_KeyboardControl = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_StaffList = new System.Windows.Forms.Label();
            this.label_Filtered = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.GBox_KeyboardControl.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBox_AllStaff
            // 
            this.ListBox_AllStaff.FormattingEnabled = true;
            this.ListBox_AllStaff.ItemHeight = 20;
            this.ListBox_AllStaff.Location = new System.Drawing.Point(60, 71);
            this.ListBox_AllStaff.Name = "ListBox_AllStaff";
            this.ListBox_AllStaff.Size = new System.Drawing.Size(248, 404);
            this.ListBox_AllStaff.TabIndex = 0;
            // 
            // ListBox_Filtered
            // 
            this.ListBox_Filtered.FormattingEnabled = true;
            this.ListBox_Filtered.ItemHeight = 20;
            this.ListBox_Filtered.Location = new System.Drawing.Point(338, 71);
            this.ListBox_Filtered.Name = "ListBox_Filtered";
            this.ListBox_Filtered.Size = new System.Drawing.Size(282, 404);
            this.ListBox_Filtered.TabIndex = 1;
            // 
            // label_StaffID
            // 
            this.label_StaffID.AutoSize = true;
            this.label_StaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_StaffID.Location = new System.Drawing.Point(647, 71);
            this.label_StaffID.Name = "label_StaffID";
            this.label_StaffID.Size = new System.Drawing.Size(78, 20);
            this.label_StaffID.TabIndex = 2;
            this.label_StaffID.Text = "Staff ID:";
            // 
            // label_StaffName
            // 
            this.label_StaffName.AutoSize = true;
            this.label_StaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_StaffName.Location = new System.Drawing.Point(647, 153);
            this.label_StaffName.Name = "label_StaffName";
            this.label_StaffName.Size = new System.Drawing.Size(105, 20);
            this.label_StaffName.TabIndex = 3;
            this.label_StaffName.Text = "Staff Name:";
            // 
            // TextBox_StaffID
            // 
            this.TextBox_StaffID.Location = new System.Drawing.Point(651, 109);
            this.TextBox_StaffID.Name = "TextBox_StaffID";
            this.TextBox_StaffID.Size = new System.Drawing.Size(246, 26);
            this.TextBox_StaffID.TabIndex = 4;
            // 
            // TextBox_StaffName
            // 
            this.TextBox_StaffName.Location = new System.Drawing.Point(651, 191);
            this.TextBox_StaffName.Name = "TextBox_StaffName";
            this.TextBox_StaffName.Size = new System.Drawing.Size(246, 26);
            this.TextBox_StaffName.TabIndex = 5;
            // 
            // GBox_KeyboardControl
            // 
            this.GBox_KeyboardControl.Controls.Add(this.label4);
            this.GBox_KeyboardControl.Controls.Add(this.label3);
            this.GBox_KeyboardControl.Controls.Add(this.label2);
            this.GBox_KeyboardControl.Controls.Add(this.label1);
            this.GBox_KeyboardControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBox_KeyboardControl.Location = new System.Drawing.Point(651, 250);
            this.GBox_KeyboardControl.Name = "GBox_KeyboardControl";
            this.GBox_KeyboardControl.Size = new System.Drawing.Size(314, 225);
            this.GBox_KeyboardControl.TabIndex = 6;
            this.GBox_KeyboardControl.TabStop = false;
            this.GBox_KeyboardControl.Text = "KeyBoard Control";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "* Close Admin Form: Alt + \"L\"";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "* Clear Staff Name: Alt + \"S\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "* Clear Staff ID: Alt + \"K\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "* Open Admin Form: Alt + \"A\"";
            // 
            // label_StaffList
            // 
            this.label_StaffList.AutoSize = true;
            this.label_StaffList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_StaffList.Location = new System.Drawing.Point(56, 48);
            this.label_StaffList.Name = "label_StaffList";
            this.label_StaffList.Size = new System.Drawing.Size(83, 20);
            this.label_StaffList.TabIndex = 7;
            this.label_StaffList.Text = "Staff List";
            // 
            // label_Filtered
            // 
            this.label_Filtered.AutoSize = true;
            this.label_Filtered.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Filtered.Location = new System.Drawing.Point(334, 48);
            this.label_Filtered.Name = "label_Filtered";
            this.label_Filtered.Size = new System.Drawing.Size(104, 20);
            this.label_Filtered.TabIndex = 8;
            this.label_Filtered.Text = "Filtered List";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 537);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1007, 32);
            this.statusStrip.TabIndex = 9;
            this.statusStrip.Text = "statusStrip";
            // 
            // ToolStripStatusLabel
            // 
            this.ToolStripStatusLabel.Name = "ToolStripStatusLabel";
            this.ToolStripStatusLabel.Size = new System.Drawing.Size(139, 25);
            this.ToolStripStatusLabel.Text = "Status Message:";
            // 
            // Form_Dictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 569);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.label_Filtered);
            this.Controls.Add(this.label_StaffList);
            this.Controls.Add(this.GBox_KeyboardControl);
            this.Controls.Add(this.TextBox_StaffName);
            this.Controls.Add(this.TextBox_StaffID);
            this.Controls.Add(this.label_StaffName);
            this.Controls.Add(this.label_StaffID);
            this.Controls.Add(this.ListBox_Filtered);
            this.Controls.Add(this.ListBox_AllStaff);
            this.Name = "Form_Dictionary";
            this.Text = "Main Dictionary Form";
            this.Load += new System.EventHandler(this.Form_Dictionary_Load);
            this.GBox_KeyboardControl.ResumeLayout(false);
            this.GBox_KeyboardControl.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox_AllStaff;
        private System.Windows.Forms.ListBox ListBox_Filtered;
        private System.Windows.Forms.Label label_StaffID;
        private System.Windows.Forms.Label label_StaffName;
        private System.Windows.Forms.TextBox TextBox_StaffID;
        private System.Windows.Forms.TextBox TextBox_StaffName;
        private System.Windows.Forms.GroupBox GBox_KeyboardControl;
        private System.Windows.Forms.Label label_StaffList;
        private System.Windows.Forms.Label label_Filtered;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

