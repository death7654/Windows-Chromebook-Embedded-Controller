using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EC_Controller
{
    public partial class UserControl1 : UserControl
    {
        public int fanSpeed = 0;

        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fanSpeed += 20;
            string strCmdLine = "/C cd C:\\Program Files\\crosec && ectool fanduty " + fanSpeed;

            System.Diagnostics.Process.Start("CMD.exe", strCmdLine);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fanSpeed -= 20;
            string strCmdLine = "/C cd C:\\Program Files\\crosec && ectool fanduty " + fanSpeed;

            System.Diagnostics.Process.Start("CMD.exe", strCmdLine);
        }
    }
}
