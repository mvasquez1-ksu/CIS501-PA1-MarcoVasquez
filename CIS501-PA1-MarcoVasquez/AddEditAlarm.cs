using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS501_PA1_MarcoVasquez
{
    public partial class AddEditAlarm : Form
    {
        private Alarm501 parentForm { get; set; }

        public AddEditAlarm()
        {
            InitializeComponent();
        }

        private void timePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void alarmOnOffCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            if (!parentForm.EditMode)
            {
                parentForm.addAlarm(timePicker.Value, alarmOnOffCheckBox.Checked);
            }
            else
            {
                parentForm.editAlarm(timePicker.Value, alarmOnOffCheckBox.Checked);
            }
            Hide();
        }

        public void setParentForm(Alarm501 pForm)
        {
            this.parentForm = pForm;
        }
    }
}
