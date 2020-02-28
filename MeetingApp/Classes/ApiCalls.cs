using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MeetingApp.Classes
{
    class ApiCalls
    {
        public static void Update(DataTable TableOut, string Tablename)
        {
            try
            {
                string ApiFinal = Alpha.API + "MeetingApi/Receiver/Update";
                WebClient client2 = new WebClient();
                client2.Headers["Content-type"] = "application/json";
                client2.Encoding = Encoding.UTF8;
                object input = new
                {
                    tableNamePass= Tablename,
                    TableOutPass= TableOut
                };
                string inputJson = JsonConvert.SerializeObject(input);
                string json = client2.UploadString(ApiFinal, inputJson);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public static DataTable FillAgenda()
        {
            try
            {
                string ApiFinal = Alpha.API + "MeetingApi/Receiver/Agenda";
                WebClient client2 = new WebClient();
                client2.Headers["Content-type"] = "application/json";
                client2.Encoding = Encoding.UTF8;
                object input = new
                {
                };
                string inputJson = JsonConvert.SerializeObject(input);
                string json = client2.UploadString(ApiFinal, inputJson);
                DataTable table = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));

                return table;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public static List<string> GetAgendaColumns()
        {
            try
            {
                string ApiFinal = Alpha.API + "MeetingApi/Receiver/AgendaColumns";
                WebClient client2 = new WebClient();
                client2.Headers["Content-type"] = "application/json";
                client2.Encoding = Encoding.UTF8;
                object input = new
                {
                };
                string inputJson = JsonConvert.SerializeObject(input);
                string json = client2.UploadString(ApiFinal, inputJson);
                List<string> Columns = (List<string>)JsonConvert.DeserializeObject(json, (typeof(List<string>)));

                return Columns;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static DataTable FillGood()
        {
            try
            {
                string ApiFinal = Alpha.API + "MeetingApi/Receiver/Good";
                WebClient client2 = new WebClient();
                client2.Headers["Content-type"] = "application/json";
                client2.Encoding = Encoding.UTF8;
                object input = new
                {
                };
                string inputJson = JsonConvert.SerializeObject(input);
                string json = client2.UploadString(ApiFinal, inputJson);
                DataTable table = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));

                return table;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public static List<string> GetGoodColumns()
        {
            try
            {
                string ApiFinal = Alpha.API + "MeetingApi/Receiver/GoodColumns";
                WebClient client2 = new WebClient();
                client2.Headers["Content-type"] = "application/json";
                client2.Encoding = Encoding.UTF8;
                object input = new
                {
                };
                string inputJson = JsonConvert.SerializeObject(input);
                string json = client2.UploadString(ApiFinal, inputJson);
                List<string> Columns = (List<string>)JsonConvert.DeserializeObject(json, (typeof(List<string>)));

                return Columns;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static DataTable FillSprint()
        {
            try
            {
                string ApiFinal = Alpha.API + "MeetingApi/Receiver/Sprint";
                WebClient client2 = new WebClient();
                client2.Headers["Content-type"] = "application/json";
                client2.Encoding = Encoding.UTF8;
                object input = new
                {
                };
                string inputJson = JsonConvert.SerializeObject(input);
                string json = client2.UploadString(ApiFinal, inputJson);
                DataTable table = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));

                return table;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public static List<string> GetSprintColumns()
        {
            try
            {
                string ApiFinal = Alpha.API + "MeetingApi/Receiver/SprintColumns";
                WebClient client2 = new WebClient();
                client2.Headers["Content-type"] = "application/json";
                client2.Encoding = Encoding.UTF8;
                object input = new
                {
                };
                string inputJson = JsonConvert.SerializeObject(input);
                string json = client2.UploadString(ApiFinal, inputJson);
                List<string> Columns = (List<string>)JsonConvert.DeserializeObject(json, (typeof(List<string>)));

                return Columns;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static DataTable FillRocks()
        {
            try
            {
                string ApiFinal = Alpha.API + "MeetingApi/Receiver/Rocks";
                WebClient client2 = new WebClient();
                client2.Headers["Content-type"] = "application/json";
                client2.Encoding = Encoding.UTF8;
                object input = new
                {
                };
                string inputJson = JsonConvert.SerializeObject(input);
                string json = client2.UploadString(ApiFinal, inputJson);
                DataTable table = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));

                return table;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public static List<string> GetRocksColumns()
        {
            try
            {
                string ApiFinal = Alpha.API + "MeetingApi/Receiver/RocksColumns";
                WebClient client2 = new WebClient();
                client2.Headers["Content-type"] = "application/json";
                client2.Encoding = Encoding.UTF8;
                object input = new
                {
                };
                string inputJson = JsonConvert.SerializeObject(input);
                string json = client2.UploadString(ApiFinal, inputJson);
                List<string> Columns = (List<string>)JsonConvert.DeserializeObject(json, (typeof(List<string>)));

                return Columns;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static DataTable FillHeadlines()
        {
            try
            {
                string ApiFinal = Alpha.API + "MeetingApi/Receiver/Headlines";
                WebClient client2 = new WebClient();
                client2.Headers["Content-type"] = "application/json";
                client2.Encoding = Encoding.UTF8;
                object input = new
                {
                };
                string inputJson = JsonConvert.SerializeObject(input);
                string json = client2.UploadString(ApiFinal, inputJson);
                DataTable table = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));

                return table;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public static List<string> GetHeadlinesColumns()
        {
            try
            {
                string ApiFinal = Alpha.API + "MeetingApi/Receiver/HeadLinesColumns";
                WebClient client2 = new WebClient();
                client2.Headers["Content-type"] = "application/json";
                client2.Encoding = Encoding.UTF8;
                object input = new
                {
                };
                string inputJson = JsonConvert.SerializeObject(input);
                string json = client2.UploadString(ApiFinal, inputJson);
                List<string> Columns = (List<string>)JsonConvert.DeserializeObject(json, (typeof(List<string>)));

                return Columns;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static DataTable FillToDo()
        {
            try
            {
                string ApiFinal = Alpha.API + "MeetingApi/Receiver/Todo";
                WebClient client2 = new WebClient();
                client2.Headers["Content-type"] = "application/json";
                client2.Encoding = Encoding.UTF8;
                object input = new
                {
                };
                string inputJson = JsonConvert.SerializeObject(input);
                string json = client2.UploadString(ApiFinal, inputJson);
                DataTable table = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));

                return table;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public static List<string> GetToDoColumns()
        {
            try
            {
                string ApiFinal = Alpha.API + "MeetingApi/Receiver/ToDoColumns";
                WebClient client2 = new WebClient();
                client2.Headers["Content-type"] = "application/json";
                client2.Encoding = Encoding.UTF8;
                object input = new
                {
                };
                string inputJson = JsonConvert.SerializeObject(input);
                string json = client2.UploadString(ApiFinal, inputJson);
                List<string> Columns = (List<string>)JsonConvert.DeserializeObject(json, (typeof(List<string>)));

                return Columns;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static DataTable FillIssues()
        {
            try
            {
                string ApiFinal = Alpha.API + "MeetingApi/Receiver/Issues";
                WebClient client2 = new WebClient();
                client2.Headers["Content-type"] = "application/json";
                client2.Encoding = Encoding.UTF8;
                object input = new
                {
                };
                string inputJson = JsonConvert.SerializeObject(input);
                string json = client2.UploadString(ApiFinal, inputJson);
                DataTable table = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));

                return table;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public static List<string> GetIssuesColumns()
        {
            try
            {
                string ApiFinal = Alpha.API + "MeetingApi/Receiver/IssuesColumns";
                WebClient client2 = new WebClient();
                client2.Headers["Content-type"] = "application/json";
                client2.Encoding = Encoding.UTF8;
                object input = new
                {
                };
                string inputJson = JsonConvert.SerializeObject(input);
                string json = client2.UploadString(ApiFinal, inputJson);
                List<string> Columns = (List<string>)JsonConvert.DeserializeObject(json, (typeof(List<string>)));

                return Columns;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static DataTable FillConclusiion()
        {
            try
            {
                string ApiFinal = Alpha.API + "MeetingApi/Receiver/Conclusion";
                WebClient client2 = new WebClient();
                client2.Headers["Content-type"] = "application/json";
                client2.Encoding = Encoding.UTF8;
                object input = new
                {
                };
                string inputJson = JsonConvert.SerializeObject(input);
                string json = client2.UploadString(ApiFinal, inputJson);
                DataTable table = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));

                return table;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public static List<string> GetConclusiionColumns()
        {
            try
            {
                string ApiFinal = Alpha.API + "MeetingApi/Receiver/ConclusionColumns";
                WebClient client2 = new WebClient();
                client2.Headers["Content-type"] = "application/json";
                client2.Encoding = Encoding.UTF8;
                object input = new
                {
                };
                string inputJson = JsonConvert.SerializeObject(input);
                string json = client2.UploadString(ApiFinal, inputJson);
                List<string> Columns = (List<string>)JsonConvert.DeserializeObject(json, (typeof(List<string>)));

                return Columns;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static DataTable FillContacts()
        {
            try
            {
                string ApiFinal = Alpha.API + "MeetingApi/Receiver/Contacts";
                WebClient client2 = new WebClient();
                client2.Headers["Content-type"] = "application/json";
                client2.Encoding = Encoding.UTF8;
                object input = new
                {
                };
                string inputJson = JsonConvert.SerializeObject(input);
                string json = client2.UploadString(ApiFinal, inputJson);
                DataTable table = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));

                return table;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public static List<string> GetContantsColumns()
        {
            try
            {
                string ApiFinal = Alpha.API + "MeetingApi/Receiver/ContactsColumns";
                WebClient client2 = new WebClient();
                client2.Headers["Content-type"] = "application/json";
                client2.Encoding = Encoding.UTF8;
                object input = new
                {
                };
                string inputJson = JsonConvert.SerializeObject(input);
                string json = client2.UploadString(ApiFinal, inputJson);
                List<string> Columns = (List<string>)JsonConvert.DeserializeObject(json, (typeof(List<string>)));

                return Columns;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
