using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EventViewerApp
{
    public partial class EventViewer : Form
    {
        public EventViewer()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                string strLogName = "";
                if (rbtnApplication.Checked)
                    strLogName = "Application";
                else if (rbtnSeccurity.Checked)
                    strLogName = "Security";
                if (rbtnSystem.Checked)
                    strLogName = "System";

                string strMachineName = txtSystemName.Text;
                int iHours = int.Parse(txtHours.Text);

                EventLog aLog = new EventLog(strLogName, strMachineName);
                EventLogEntryCollection entries = aLog.Entries;

                DateTime dtDateTimeLimit = DateTime.Now.AddHours(-iHours);

                DataTable dtELog = new DataTable("tblEventLog");
                dtELog.Columns.Add("Source", typeof(string));
                dtELog.Columns.Add("EventID", typeof(string));
                dtELog.Columns.Add("Type", typeof(string));
                dtELog.Columns.Add("TimeWritten", typeof(string));
                dtELog.Columns.Add("Message", typeof(string));

                progressBar.Minimum = 1;
                progressBar.Maximum = aLog.Entries.Count;
                progressBar.Value = 1;
                progressBar.Step = 1;

                for (int i = aLog.Entries.Count - 1; i >= 0; i--)
                {
                    EventLogEntry entry = aLog.Entries[i];
                    if (entry.TimeGenerated > dtDateTimeLimit)
                    {
                        if (checkSelectedItems(entry.Source))
                            dtELog.Rows.Add(entry.Source, entry.InstanceId, entry.EntryType, entry.TimeWritten, entry.Message);
                    }
                    else
                    {
                        progressBar.Value = aLog.Entries.Count;
                        break;
                    }
                    progressBar.PerformStep();
                }
                dgEventViewer.DataSource = dtELog;
                dgEventViewer.Columns[1].Width = 60;
                dgEventViewer.Columns[2].Width = 80;
                dgEventViewer.Columns[3].Width = 120;

                lblTotalRecords.Text = "Total Records: " + dtELog.Rows.Count;
                dgEventViewer.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool checkSelectedItems(string strSource)
        {
            foreach (var item in lstSourceList.SelectedItems)
            {
                if (item.Equals(strSource))
                    return true;
            }
            return false;
        }


        private void EventViewer_Load(object sender, EventArgs e)
        {
            try
            {
                txtSystemName.Text = ".";
                txtHours.Text = "10";
                btnReLoadSourceList_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadSourceList(string strMachineName, string strLogName, int iHours)
        {

            EventLog aLog = new EventLog(strLogName, strMachineName);
            EventLogEntryCollection entries = aLog.Entries;

            List<string> strSourceList = new List<string>();
            DateTime dtDateTimeLimit = DateTime.Now.AddHours(-iHours);

            progressBar.Minimum = 1;
            progressBar.Maximum = aLog.Entries.Count;
            progressBar.Value = 1;
            progressBar.Step = 1;


            for (int i = aLog.Entries.Count - 1; i >= 0; i--)
            {
                EventLogEntry entry = aLog.Entries[i];
                if (entry.TimeGenerated > dtDateTimeLimit)
                    strSourceList.Add(entry.Source);
                else
                {
                    progressBar.Value = aLog.Entries.Count;
                    break;
                }
                progressBar.PerformStep();
            }
            //foreach (EventLogEntry entry in aLog.Entries)
            //{
            //}
            List<string> strDistinctSource = strSourceList.Distinct().ToList();
            strDistinctSource.Sort();
            lstSourceList.DataSource = strDistinctSource;

        }

        private void btnReLoadSourceList_Click(object sender, EventArgs e)
        {
            try
            {
                string strLogName = "";
                if (rbtnApplication.Checked)
                    strLogName = "Application";
                else if (rbtnSeccurity.Checked)
                    strLogName = "Security";
                if (rbtnSystem.Checked)
                    strLogName = "System";

                int iHours = int.Parse(txtHours.Text);
                LoadSourceList(txtSystemName.Text, strLogName, iHours);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgEventViewer_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtSource.Text = dgEventViewer[0, e.RowIndex].Value.ToString();
            txtEventID.Text = dgEventViewer[1, e.RowIndex].Value.ToString();
            txtType.Text = dgEventViewer[2, e.RowIndex].Value.ToString();
            txtDateTime.Text = dgEventViewer[3, e.RowIndex].Value.ToString();
            txtMessage.Text = dgEventViewer[4, e.RowIndex].Value.ToString();
            lblView.Text = "Viewing Record No.: " + (e.RowIndex + 1).ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            txtMessage.Copy();
        }
    }
}
