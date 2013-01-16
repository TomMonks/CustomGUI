using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CustomGUI
{

    /// <summary>
    /// Stores a list of recent strings up to a specified capacity (oldest items are dropped).  When a item is selected#
    /// it is put at the top of menu.  If a user attempts to add the same text to a menu 
    /// the duplicate item is put at the top of the list.
    /// </summary>
    public class RecentFileContextMenuStrip : ContextMenuStrip 
    {

        protected const int DEFAULT_CAPACITY = 5;
        protected int capacity;

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            set
            {
                this.capacity = value;
            }
        }


        public List<string> RecentFiles
        {
            get
            {
                var files = new List<string>();

                foreach (ToolStripMenuItem item in this.Items)
                {
                    files.Add(item.Text);
                }

                return files;
            }
            set
            {
               
                foreach(var file in value)
                {
                    var item = new ToolStripMenuItem(file);
                    item.Click += this.RecentFileClick;
                    this.Items.Add(item);
                }
            }
        }


        /// <summary>
        /// Constructor. Default capacity of recent file list is 5.
        /// </summary>
        public RecentFileContextMenuStrip()
        {
            this.capacity = DEFAULT_CAPACITY;
        }

        /// <summary>
        /// Overloaded constructor
        /// </summary>
        /// <param name="capacity">The number of recent files to store.</param>
        public RecentFileContextMenuStrip(int capacity)
        {
            this.capacity = capacity;
        }


        public ToolStripMenuItem AppendFile(string toAdd)
        {
            ToolStripMenuItem item = new ToolStripMenuItem(toAdd);

            item.Click += this.RecentFileClick;

            foreach (ToolStripMenuItem i in this.Items)
            {
                if (i.Text == toAdd)
                {
                    RecentFileClick(i, new EventArgs());
                    return i;
                }
            }
            
            this.Items.Insert(0, item);

            if (this.Items.Count > this.Capacity)
            {
                this.Items.RemoveAt(this.Items.Count - 1);
            }

            return item;
        }

        private void RecentFileClick(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;

            //want to push this item to the top.
            this.Items.Remove(clickedItem);
            this.Items.Insert(0, clickedItem);

        }


    }
}
