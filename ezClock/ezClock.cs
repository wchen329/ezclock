using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ezClock
{
    public partial class Form_ezClock : Form
    {
        bool unsavedClocks;

        public Form_ezClock()
        {
            InitializeComponent();
            this.unsavedClocks = false;
        }

        public DialogResult ConfirmDiscardUnsavedTimestamps()
        {
            DialogResult dialogconf = MessageBox.Show("Some timestamps have not yet been saved. Would you like to save first?",
                    "Unsaved Timestamps",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Information);
            return dialogconf;
        }

        public DialogResult SaveUnsavedTimestampsOnExit()
        {
            DialogResult dialogconf = MessageBox.Show("Some timestamps have not yet been saved. Would you like to save them?",
                    "Unsaved Timestamps",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);
            return dialogconf;
        }

        private void button_Clock_Click(object sender, EventArgs e)
        {
            this.unsavedClocks = true;
            listBox_ClockEntries.Items.Add(System.DateTime.Now.ToString());
        }

        private void button_Import_Click(object sender, EventArgs e)
        {
            if (this.unsavedClocks)
            {
                DialogResult unsavedclock_yesno = ConfirmDiscardUnsavedTimestamps();

                if (unsavedclock_yesno == DialogResult.Cancel)
                {
                    return;
                }

                else if (unsavedclock_yesno == DialogResult.Yes)
                {
                    this.button_Export_Click(sender, e);
                }
            }

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ezClock Files (*.ezclock)|*.ezclock";
            DialogResult open_result = ofd.ShowDialog();

            if (open_result != DialogResult.OK)
            {
                return;
            }

            try
            {
                    string import_file = ofd.FileName;
                    this.listBox_ClockEntries.Items.Clear();
                    FileStream fs = new FileStream(import_file, FileMode.Open);
                    StreamReader open_file_reader = new StreamReader(fs);

                    while (!open_file_reader.EndOfStream)
                    {
                        string data = open_file_reader.ReadLine();
                        this.listBox_ClockEntries.Items.Add(data);
                    }

                    open_file_reader.Close();
                    this.unsavedClocks = false;
            }
            catch(IOException)
            {
                MessageBox.Show("An error occurred while importing a timesheet: I/O error", "Error", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (ArgumentException)
            {
                MessageBox.Show("An error occurred while importing a timesheet: invalid file name.", "Error", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button_Export_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "ezClock Files (*.ezclock)|*.ezclock";
            DialogResult save_result = sfd.ShowDialog();

            if (save_result != DialogResult.OK)
            {
                return;
            }

            try
            {
                string export_file = sfd.FileName;
                StreamWriter save_file_reader = new StreamWriter(sfd.FileName);

                for (int count = 0; count < this.listBox_ClockEntries.Items.Count; count++)
                {
                    string writing_text = (string)this.listBox_ClockEntries.Items[count];
                    save_file_reader.WriteLine(writing_text);
                }

                save_file_reader.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("An error occurred while exporting a timesheet: I/O error", "Error", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (ArgumentException)
            {
                MessageBox.Show("An error occurred while exporting a timesheet: invalid file name.", "Error", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.unsavedClocks = false;
        }

        private void Form_ezClock_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.unsavedClocks)
            {
                DialogResult dialog_result = this.SaveUnsavedTimestampsOnExit();
                if (dialog_result == DialogResult.Yes)
                {
                    this.button_Export_Click(sender, e);
                }
            }
        }

        private void toolStripMenuItem_delEntry_Click(object sender, EventArgs e)
        {
            if (this.listBox_ClockEntries.SelectedIndex >= 0)
            {
                this.listBox_ClockEntries.Items.RemoveAt(this.listBox_ClockEntries.SelectedIndex);
            }
        }
    }
}
