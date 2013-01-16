using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGUIComponents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<string> files = new List<string>();
            files.Add("test1");
            files.Add("test2");
            files.Add("test3");
            files.Add("test4");
            files.Add("test5");

            this.recentFileTextBox1.RecentFiles = files;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.recentFileTextBox1.AppendRecentFile("test5");
        }
    }
}
