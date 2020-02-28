using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingApp.Classes
{
    class Alpha
    {
        internal static string API = "http://localhost:58480/";
        // internal static string = "https://atlasregistration.healthrise.com/";
        public static int MeetingTabSelection { get; set; }
        public static DateTime CurrentDate { get; set; }
        public static string TableNameGlobal;

        public static void TableNameSwitcher()
        {
            switch (Alpha.MeetingTabSelection)
            {
                case 0:
                    TableNameGlobal = "Agenda";
                    break;
                case 1:
                    TableNameGlobal = "Good";
                    break;
                case 2:
                    TableNameGlobal = "Sprint";
                    break;
                case 3:
                    TableNameGlobal = "Rocks";
                    break;
                case 4:
                    TableNameGlobal = "Headlines";
                    break;
                case 5:
                    TableNameGlobal = "Todo";
                    break;
                case 6:
                    TableNameGlobal = "Issues";
                    break;
                case 7:
                    TableNameGlobal = "Conclusion";
                    break;
                case 8:
                    TableNameGlobal = "Contacts";
                    break;
            }
        }

    }
}
