using MeetingApp.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetingApp.Pages
{
    public partial class AddEdit : Form
    {
        public AddEdit()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        private void AddEdit_Load(object sender, EventArgs e)
        {
            table = AddEntry.Table();
            AddEntryDgv.DataSource = table;
            AddEntryDgv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            AddEntryDgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Alpha.TableNameSwitcher();
            NextMeetingDateTxt.Text = Alpha.CurrentDate.ToString();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            int x = 1;
            DataTable tableIn = new DataTable();
            tableIn.Rows.Add();
            tableIn.Columns.Add("Id");
            foreach (DataGridViewRow row in AddEntryDgv.Rows)
            {
                string Column = row.Cells[0].Value.ToString();
                tableIn.Columns.Add(Column);
                string NewValue = row.Cells[1].Value.ToString();
                tableIn.Rows[0][x] = NewValue;
                x++;
            }
            tableIn.Rows[0][0] = Alpha.TableNameGlobal;

            try
            {
                string ApiFinal = Alpha.API + "MeetingApi/Receiver/Add";
                WebClient client2 = new WebClient();
                client2.Headers["Content-type"] = "application/json";
                client2.Encoding = Encoding.UTF8;
                string inputJson = JsonConvert.SerializeObject(tableIn);
                string json = client2.UploadString(ApiFinal, inputJson);
            }
            catch (Exception ex)
            {

                throw;
            }
            this.Close();
        }
    }
}
