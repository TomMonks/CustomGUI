using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGUI.Textbox
{
    public interface ITextBoxWithOpenFileDialogArgs
    {
        string Title { get; set; }
        string Filter { get; set; }


    }
}
