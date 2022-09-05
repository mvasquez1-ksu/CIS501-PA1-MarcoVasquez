
namespace CIS501_PA1_MarcoVasquez
{
    partial class Alarm501
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
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.snoozeButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.alarmBox = new System.Windows.Forms.ListBox();
            this.alarmStatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // editButton
            // 
            this.editButton.Enabled = false;
            this.editButton.Location = new System.Drawing.Point(34, 32);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(90, 46);
            this.editButton.TabIndex = 0;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(187, 32);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(90, 46);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // snoozeButton
            // 
            this.snoozeButton.Enabled = false;
            this.snoozeButton.Location = new System.Drawing.Point(34, 360);
            this.snoozeButton.Name = "snoozeButton";
            this.snoozeButton.Size = new System.Drawing.Size(90, 46);
            this.snoozeButton.TabIndex = 2;
            this.snoozeButton.Text = "Snooze";
            this.snoozeButton.UseVisualStyleBackColor = true;
            this.snoozeButton.Click += new System.EventHandler(this.snoozeButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(187, 360);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(90, 46);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // alarmBox
            // 
            this.alarmBox.FormattingEnabled = true;
            this.alarmBox.ItemHeight = 15;
            this.alarmBox.Location = new System.Drawing.Point(34, 111);
            this.alarmBox.Name = "alarmBox";
            this.alarmBox.Size = new System.Drawing.Size(243, 214);
            this.alarmBox.TabIndex = 4;
            this.alarmBox.SelectedIndexChanged += new System.EventHandler(this.alarmBox_SelectedIndexChanged);
            // 
            // alarmStatusLabel
            // 
            this.alarmStatusLabel.AutoSize = true;
            this.alarmStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.alarmStatusLabel.Location = new System.Drawing.Point(134, 338);
            this.alarmStatusLabel.Name = "alarmStatusLabel";
            this.alarmStatusLabel.Size = new System.Drawing.Size(0, 15);
            this.alarmStatusLabel.TabIndex = 5;
            // 
            // Alarm501
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 450);
            this.Controls.Add(this.alarmStatusLabel);
            this.Controls.Add(this.alarmBox);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.snoozeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.editButton);
            this.Name = "Alarm501";
            this.Text = "Alarm501";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Alarm501_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button snoozeButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.ListBox alarmBox;
        private System.Windows.Forms.Label alarmStatusLabel;
    }
}

