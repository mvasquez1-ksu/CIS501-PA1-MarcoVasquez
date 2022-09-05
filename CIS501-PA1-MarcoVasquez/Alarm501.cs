using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace CIS501_PA1_MarcoVasquez
{
    public partial class Alarm501 : Form
    {
        private AddEditAlarm addEditForm { get; set; }

        private BindingList<Alarm> alarmList { get; set; }

        private Alarm selectedAlarm { get; set; }

        private bool editMode { get; set; }

        private System.Timers.Timer timer { get; set; }

        public Alarm501()
        {
            InitializeComponent();
            addEditForm = new AddEditAlarm();
            alarmList = new BindingList<Alarm>();
            readAlarmTxt();
            alarmBox.DataSource = alarmList;
            alarmBox.DisplayMember = "alarmString";
            alarmBox.ValueMember = "alarmString";
            addEditForm.setParentForm(this);
            selectedAlarm = null;
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += timerElapsed;
            timer.Start();
        }

        private void timerElapsed(object sender, ElapsedEventArgs e)
        {
            alarmBox.Invoke((Action)delegate
            {
                if (alarmBox.SelectedIndex != -1 && selectedAlarm != null)
                {
                    if (selectedAlarm.WentOff)
                    {
                        alarmStatusLabel.Text = "Alarm Went OFF";
                        snoozeButton.Enabled = true;
                        stopButton.Enabled = true;
                    }
                    else
                    {
                        alarmStatusLabel.Text = "Stopped";
                        snoozeButton.Enabled = false;
                        stopButton.Enabled = false;
                    }
                }
            });
        }

        public Alarm SelectedAlarm
        {
            get
            {
                return selectedAlarm;
            }
        }

        public bool EditMode
        {
            get
            {
                return editMode;
            }
        }

        private void refreshListBox()
        {
            alarmBox.DataSource = null;
            alarmBox.DataSource = alarmList;
            alarmBox.DisplayMember = "alarmString";
            alarmBox.ValueMember = "alarmString";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            editMode = false;
            addEditForm.Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            editMode = true;
            addEditForm.Show();
        }

        private void alarmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            editButton.Enabled = (alarmBox.SelectedIndex != -1);
            if (alarmBox.SelectedIndex != -1)
            {
                selectedAlarm = (Alarm)alarmBox.SelectedItem;
                if (selectedAlarm.WentOff)
                {
                    alarmStatusLabel.Text = "Alarm Went OFF";
                    snoozeButton.Enabled = true;
                    stopButton.Enabled = true;
                }
                else
                {
                    alarmStatusLabel.Text = "Stopped";
                    snoozeButton.Enabled = false;
                    stopButton.Enabled = false;
                }
            }
        }

        public void addAlarm(DateTime t, bool o)
        {
            Alarm alarm = new Alarm(t, o);
            alarmList.Add(alarm);
            //alarmBox.Items.Add(alarm);
            if (alarmList.Count == 5)
            {
                addButton.Enabled = false;
            }
        }

        public void editAlarm(DateTime t, bool o)
        {
            int index = alarmList.IndexOf(selectedAlarm);
            alarmList[index].setTime(t);
            alarmList[index].setOnOff(o);
            //alarmBox.Items.Add(selectedAlarm);
            //selectedAlarm = null;
            refreshListBox();
        }

        private async Task writeAlarmTxtAsync()
        {
            string alarmText = "";
            foreach (Alarm a in alarmList)
            {
                alarmText += a.alarmStringLong + "\n";
            }
            await File.WriteAllTextAsync("alarms.txt", alarmText);
        }

        private void readAlarmTxt()
        {
            string[] alarmText = File.ReadAllLines("alarms.txt");
            string[] alarmLine = { "" };
            bool alarmOnOff = false;
            foreach (string line in alarmText)
            {
                alarmLine = line.Split();
                DateTime t = DateTime.Parse(alarmLine[0]);
                if (alarmLine[2].ToLower() == "on")
                {
                    alarmOnOff = true;
                }
                else
                {
                    alarmOnOff = false;
                }
                Alarm a = new Alarm(t, alarmOnOff);
                alarmList.Add(a);
            }
            if (alarmList.Count >= 5)
            {
                addButton.Enabled = false;
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            selectedAlarm.setWentOff(false);
            selectedAlarm.setOnOff(false);
            snoozeButton.Enabled = false;
            stopButton.Enabled = false;
            refreshListBox();
        }

        private void snoozeButton_Click(object sender, EventArgs e)
        {
            selectedAlarm.setWentOff(false);
            selectedAlarm.snooze();
            snoozeButton.Enabled = false;
            stopButton.Enabled = false;
            refreshListBox();
        }

        private async void Alarm501_FormClosed(object sender, FormClosedEventArgs e)
        {
            await writeAlarmTxtAsync();
        }
    }
}
