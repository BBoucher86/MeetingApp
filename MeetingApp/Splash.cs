using MeetingApp.Classes;
using MeetingApp.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetingApp
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            Alpha.CurrentDate = DateTime.Now;
        }

        private void Gif_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenNext();
            CloseProgram();
        }
        private void OpenNext()
        {
            Login LoginForm = new Login();
            LoginForm.ShowDialog();
        }
        private void CloseProgram()
        {
            this.Close();
        }
    }
}
