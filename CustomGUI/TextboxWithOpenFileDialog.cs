using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CustomGUI.Textbox;

namespace CustomGUI
{
    public partial class TextboxWithOpenFileDialog : UserControl
    {
       
        protected ITextBoxWithOpenFileDialogArgs args;

        public TextboxWithOpenFileDialog()
        {
            InitializeComponent();
            this.Args = new TextBoxWithOpenExcelDialogArgs();
            this.openFileDialog1.FileName = "";
        }

        public ITextBoxWithOpenFileDialogArgs Args { get; set; }


        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Title = this.Args.Title;
            this.openFileDialog1.Filter = this.Args.Filter;
            if (this.openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.recentFileTextBox1.Text = this.openFileDialog1.FileName;
                this.recentFileTextBox1.AppendRecentFile(this.openFileDialog1.FileName);
            }
        }
    }
}
