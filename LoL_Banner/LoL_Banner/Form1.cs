using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoL_Banner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Process LoL = new Process();
                LoL.StartInfo.FileName = "C:\\Riot Games\\League of Legends\\lol.launcher.admin.exe";
                LoL.StartInfo.WorkingDirectory = "C:\\Riot Games\\League of Legends";
                LoL.EnableRaisingEvents = true;
                LoL.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to launch LoL");
            }
        }
    }
}
