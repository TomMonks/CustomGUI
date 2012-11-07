using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace CustomGUI
{
    public class ExtendedTabControl : TabControl 
    {
        protected ContextMenuStrip contextMenu;
        protected Point lastClickedPos;

        public ExtendedTabControl() 
        {
            contextMenu = GetContextMenu();
        }

        protected ContextMenuStrip GetContextMenu()
        {
            var cms = new ContextMenuStrip();
            cms.Items.Add("Close", null, CloseItemClicked);
            return cms;
        }

        public void CloseItemClicked(object sender, EventArgs e)
        {
            for (int i = 0; i < this.TabCount; i++)
            {
                var rect = this.GetTabRect(i);

                if(rect.Contains(this.PointToClient(this.lastClickedPos)))
                {
                    this.TabPages.RemoveAt(i);
                }
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                this.lastClickedPos = Cursor.Position;
                this.contextMenu.Show(Cursor.Position);
            }

        }

    }
}
