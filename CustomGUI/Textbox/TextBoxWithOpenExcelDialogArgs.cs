using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGUI.Textbox
{
    public class TextBoxWithOpenExcelDialogArgs : ITextBoxWithOpenFileDialogArgs
    {
        protected string title;
        protected string filter;


        public TextBoxWithOpenExcelDialogArgs()
        {
            this.title = "Open Excel Workbook";
            this.filter = "Excel Workbooks (.xls, .xlxs)|*.xls,*.xlsx";

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
