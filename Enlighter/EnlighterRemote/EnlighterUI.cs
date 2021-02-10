using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnlighterRemote
{
    class EnlighterUI : Form
    {

        private EnlightmentUtils engine;

        private void InitializeComponent()
        {
            this.engine = new EnlightmentUtils();

            this.SuspendLayout();
            // 
            // EnlighterUI
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "EnlighterUI";
            this.ResumeLayout(false);
        }
    }
}
