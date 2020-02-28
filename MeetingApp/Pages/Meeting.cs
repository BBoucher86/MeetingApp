using MeetingApp.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace MeetingApp.Pages
{
    public partial class Meeting : Form
    {
        public Meeting()
        {
            InitializeComponent();
        }

        private void Meeting_Load(object sender, EventArgs e)
        {
            FillDgv();
        }
        private void FillDgv()
        {
            try
            {
                DataTable table = ApiCalls.FillAgenda();
                AgendaDgv.DataSource = null;
                AgendaDgv.DataSource = table;
                AgendaDgv.Columns.Remove("Id");
            }
            catch (Exception)
            {

            }
            try
            {
                DataTable table2 = ApiCalls.FillGood();
                GoodDgv.DataSource = null;
                GoodDgv.DataSource = table2;
                GoodDgv.Columns.Remove("Id");

            }
            catch (Exception)
            {

            }
            try
            {
                DataTable table3 = ApiCalls.FillSprint();
                SprintDgv.DataSource = null;
                SprintDgv.DataSource = table3;
                SprintDgv.Columns.Remove("Id");
            }
            catch (Exception)
            {

            }
            try
            {
                DataTable table4 = ApiCalls.FillRocks();
                RocksDgv.DataSource = null;
                RocksDgv.DataSource = table4;
                RocksDgv.Columns.Remove("Id");

            }
            catch (Exception)
            {

            }
            try
            {
                DataTable table5 = ApiCalls.FillHeadlines();
                HeadlinesDgv.DataSource = null;
                HeadlinesDgv.DataSource = table5;
                HeadlinesDgv.Columns.Remove("Id");
            }
            catch (Exception)
            {

            }
            try
            {
                DataTable table6 = ApiCalls.FillToDo();
                ToDoDgv.DataSource = null;
                ToDoDgv.DataSource = table6;
                ToDoDgv.Columns.Remove("Id");
            }
            catch (Exception)
            {

            }
            try
            {
                DataTable table7 = ApiCalls.FillIssues();
                IssuesDgv.DataSource = null;
                IssuesDgv.DataSource = table7;
                IssuesDgv.Columns.Remove("Id");
            }
            catch (Exception)
            {

            }
            try
            {
                DataTable table8 = ApiCalls.FillConclusiion();
                ConclusionsDgv.DataSource = null;
                ConclusionsDgv.DataSource = table8;
                ConclusionsDgv.Columns.Remove("Id");
            }
            catch (Exception)
            {

            }
            try
            {
                DataTable table9 = ApiCalls.FillContacts();
                ContactsDgv.DataSource = null;
                ContactsDgv.DataSource = table9;
                ContactsDgv.Columns.Remove("Id");
            }
            catch (Exception)
            {

            }
        }
        private void OpenNext()
        {
            AddEdit AddForm = new AddEdit();
            AddForm.ShowDialog();
        }
        private void Meeting_Activated(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        #region Buttons
        private void AddBtn_Click(object sender, EventArgs e)
        {
            Alpha.MeetingTabSelection = TabControl.SelectedIndex;
            this.Opacity = .5;
            this.Update();
            OpenNext();
            Refresher();
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            ApiCalls.Update(DgvDataCurrent(), TableNameTabselection());
            Refresher();
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            switch (Alpha.MeetingTabSelection)
            {
                case 0:
                    Delete(AgendaDgv);
                    break;
                case 1:
                    Delete(GoodDgv);
                    break;
                case 2:
                    Delete(SprintDgv);
                    break;
                case 3:
                    Delete(RocksDgv);
                    break;
                case 4:
                    Delete(HeadlinesDgv);
                    break;
                case 5:
                    Delete(ToDoDgv);
                    break;
                case 6:
                    Delete(IssuesDgv);
                    break;
                case 7:
                    Delete(ConclusionsDgv);
                    break;
                case 8:
                    Delete(ContactsDgv);
                    break;
                default:
                    break;
            }
            ApiCalls.Update(DgvDataCurrent(), TableNameTabselection());

        }
        private string TableNameTabselection()
        {
            switch (Alpha.MeetingTabSelection)
            {
                case 0:
                    return "Agenda";
                case 1:    
                    return "Good";
                case 2:    
                    return "Sprint";
                case 3:    
                    return "Rocks";
                case 4:    
                    return "Headlines";
                case 5:    
                    return "Todo";
                case 6:    
                    return "Issues";
                case 7:    
                    return "Conclusion";
                case 8:    
                    return "Contacts";
                default:
                    return null;
            }
        }
        private DataTable DgvDataCurrent()
        {
            switch (Alpha.MeetingTabSelection)
            {
                case 0:
                    return (DataTable)AgendaDgv.DataSource;
                case 1:
                    return (DataTable)GoodDgv.DataSource;
                case 2:                
                    return (DataTable)SprintDgv.DataSource;
                case 3:                
                    return (DataTable)RocksDgv.DataSource;
                case 4:                
                    return (DataTable)HeadlinesDgv.DataSource;
                case 5:                
                    return (DataTable)ToDoDgv.DataSource;
                case 6:                
                    return (DataTable)IssuesDgv.DataSource;
                case 7:                
                    return (DataTable)ConclusionsDgv.DataSource;
                case 8:                
                    return (DataTable)ContactsDgv.DataSource;
                default:
                    return null;
            }
        }

        private void Delete(DataGridView dgv)
        {
            {
                foreach (DataGridViewRow item in dgv.SelectedRows)
                {
                    dgv.Rows.RemoveAt(item.Index);
                }
            }
        }
        #endregion

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            Refresher();
        }
        private void Refresher()
        {
            FillDgv();
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Alpha.MeetingTabSelection = TabControl.SelectedIndex;
        }
    }
}
