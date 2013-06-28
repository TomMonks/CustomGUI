using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGUI.Textbox
{
    public class TextBoxWithOpenAccessDialogArgs : ITextBoxWithOpenFileDialogArgs
    {
        protected string title;
        protected string filter;


        public TextBoxWithOpenAccessDialogArgs()
        {
            this.title = "Open MS Access Database";       
            this.filter = "Access Database Files (.accdb)|*.accdb";
        
        }

        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                this.title = value;
            }
        }

        public string Filter
        {
            get
            {
                return this.filter;
            }
            set
            {
                this.filter = value;
            }
        }
    }
}
