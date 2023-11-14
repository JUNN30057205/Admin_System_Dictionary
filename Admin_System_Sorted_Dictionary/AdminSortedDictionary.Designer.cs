namespace Admin_System_Sorted_Dictionary
{
    partial class AdminSortedDictionary
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
            this.TextBox_StaffName = new System.Windows.Forms.TextBox();
            this.TextBox_StaffID = new System.Windows.Forms.TextBox();
            this.LabelStaffName = new System.Windows.Forms.Label();
            this.LabelStaffID = new System.Windows.Forms.Label();
            this.LabelUpdate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelRemove = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox_StaffName
            // 
            this.TextBox_StaffName.Location = new System.Drawing.Point(27, 135);
            this.TextBox_StaffName.Name = "TextBox_StaffName";
            this.TextBox_StaffName.Size = new System.Drawing.Size(218, 26);
            this.TextBox_StaffName.TabIndex = 8;
            this.TextBox_StaffName.Text = "Text box";
            // 
            // TextBox_StaffID
            // 
            this.TextBox_StaffID.Location = new System.Drawing.Point(27, 55);
            this.TextBox_StaffID.Name = "TextBox_StaffID";
            this.TextBox_StaffID.Size = new System.Drawing.Size(218, 26);
            this.TextBox_StaffID.TabIndex = 7;
            this.TextBox_StaffID.Text = "Text box";
            // 
            // LabelStaffName
            // 
            this.LabelStaffName.AutoSize = true;
            this.LabelStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStaffName.Location = new System.Drawing.Point(22, 102);
            this.LabelStaffName.Name = "LabelStaffName";
            this.LabelStaffName.Size = new System.Drawing.Size(105, 20);
            this.LabelStaffName.TabIndex = 6;
            this.LabelStaffName.Text = "Staff Name:";
            // 
            // LabelStaffID
            // 
            this.LabelStaffID.AutoSize = true;
            this.LabelStaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStaffID.Location = new System.Drawing.Point(22, 26);
            this.LabelStaffID.Name = "LabelStaffID";
            this.LabelStaffID.Size = new System.Drawing.Size(78, 20);
            this.LabelStaffID.TabIndex = 5;
            this.LabelStaffID.Text = "Staff ID:";
            // 
            // LabelUpdate
            // 
            this.LabelUpdate.AutoSize = true;
            this.LabelUpdate.Location = new System.Drawing.Point(22, 67);
            this.LabelUpdate.Name = "LabelUpdate";
            this.LabelUpdate.Size = new System.Drawing.Size(248, 20);
            this.LabelUpdate.TabIndex = 0;
            this.LabelUpdate.Text = "* Update Staff Data: Alt + \"U\"";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LabelRemove);
            this.groupBox1.Controls.Add(this.LabelUpdate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(278, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 223);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KeyBoard Control";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "* Save & Close Admin GUI: Alt + \"L\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "* Create New Staff Record: Alt + \"C\"";
            // 
            // LabelRemove
            // 
            this.LabelRemove.AutoSize = true;
            this.LabelRemove.Location = new System.Drawing.Point(22, 109);
            this.LabelRemove.Name = "LabelRemove";
            this.LabelRemove.Size = new System.Drawing.Size(254, 20);
            this.LabelRemove.TabIndex = 1;
            this.LabelRemove.Text = "* Remove Staff Data: Alt + \"R\"";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 298);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.statusStrip1.Size = new System.Drawing.Size(710, 32);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(135, 25);
            this.toolStripStatusLabel.Text = "Status Message";
            // 
            // AdminSortedDictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 330);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.TextBox_StaffName);
            this.Controls.Add(this.TextBox_StaffID);
            this.Controls.Add(this.LabelStaffName);
            this.Controls.Add(this.LabelStaffID);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "AdminSortedDictionary";
            this.Text = "Admin Sorted Dictionary";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AdminSortedDictionary_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_StaffName;
        private System.Windows.Forms.TextBox TextBox_StaffID;
        private System.Windows.Forms.Label LabelStaffName;
        private System.Windows.Forms.Label LabelStaffID;
        private System.Windows.Forms.Label LabelUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelRemove;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}