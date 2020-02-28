using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingApp.Classes
{
    class AddEntry
    {
        public static DataTable Table()
        {
            DataTable Table = new DataTable();
            List<string> Columns = AddEntry.Columns();
            Table.Columns.Add("Topic");
            Table.Columns.Add("Entry");
            foreach (string st in Columns)
            {
                Table.Rows.Add(st);
            }
            Table.Rows.Remove(Table.Rows[0]);
            return Table;
        }
        public static List<string> Columns()
        {
            switch (Alpha.MeetingTabSelection)
            {
                case 0:
                   return ApiCalls.GetAgendaColumns();
                case 1:
                    return ApiCalls.GetGoodColumns();
                case 2:
                    return ApiCalls.GetSprintColumns();
                case 3:
                    return ApiCalls.GetRocksColumns();
                case 4:
                    return ApiCalls.GetHeadlinesColumns();
                case 5:
                    return ApiCalls.GetToDoColumns();
                case 6:
                    return ApiCalls.GetIssuesColumns();
                case 7:
                    return ApiCalls.GetConclusiionColumns();
                case 8:
                    return ApiCalls.GetContantsColumns();
                default:
                    return null;
            }
        }
    }
}
