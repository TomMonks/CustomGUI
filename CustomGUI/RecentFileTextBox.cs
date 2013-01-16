using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CustomGUI
{
    public class RecentFileTextBox : TextBox  
    {
        protected RecentFileContextMenuStrip menu;

        public List<string> RecentFiles
        {
            get
            {
                return this.menu.RecentFiles;
            }
            set
            {
                this.menu.RecentFiles = value;

                foreach (ToolStripMenuItem item in menu.Items)
                {
                    item.Click += this.ShowRecentFile;
                }

            }
        }

        public RecentFileTextBox()
        {
            menu = new RecentFileContextMenuStrip();
            this.ContextMenuStrip = menu;
        }

        public void AppendRecentFile(string toAdd)
        {
            var item = this.menu.AppendFile(toAdd);
            item.Click += this.ShowRecentFile;

        }


        private void ShowRecentFile(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            this.Text = clickedItem.Text;
        }

    }
}
