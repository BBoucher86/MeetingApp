﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetingApp.Pages
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenNext();
        }
        private void OpenNext()
        {
            Meeting MeetingForm = new Meeting();
            MeetingForm.ShowDialog();
        }

    }
}
