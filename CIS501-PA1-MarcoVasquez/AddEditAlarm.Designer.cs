
namespace CIS501_PA1_MarcoVasquez
{
    partial class AddEditAlarm
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
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.alarmOnOffCheckBox = new System.Windows.Forms.CheckBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.setButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "\"hh:mm:ss tt\"";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(12, 25);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(217, 23);
            this.timePicker.TabIndex = 0;
            this.timePicker.ValueChanged += new System.EventHandler(this.timePicker_ValueChanged);
            // 
            // alarmOnOffCheckBox
            // 
            this.alarmOnOffCheckBox.AutoSize = true;
            this.alarmOnOffCheckBox.Location = new System.Drawing.Point(249, 25);
            this.alarmOnOffCheckBox.Name = "alarmOnOffCheckBox";
            this.alarmOnOffCheckBox.Size = new System.Drawing.Size(42, 19);
            this.alarmOnOffCheckBox.TabIndex = 1;
            this.alarmOnOffCheckBox.Text = "On";
            this.alarmOnOffCheckBox.UseVisualStyleBackColor = true;
            this.alarmOnOffCheckBox.CheckedChanged += new System.EventHandler(this.alarmOnOffCheckBox_CheckedChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(12, 65);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // setButton
            // 
            this.setButton.Location = new System.Drawing.Point(230, 65);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(75, 23);
            this.setButton.TabIndex = 3;
            this.setButton.Text = "Set";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // AddEditAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 111);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.alarmOnOffCheckBox);
            this.Controls.Add(this.timePicker);
            this.Name = "AddEditAlarm";
            this.Text = "AddEditAlarm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.CheckBox alarmOnOffCheckBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button setButton;
    }
}