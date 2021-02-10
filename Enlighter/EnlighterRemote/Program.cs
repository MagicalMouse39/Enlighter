using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnlighterRemote
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            EnlighterUI ui = new EnlighterUI();

            Application.EnableVisualStyles();
            Application.Run(ui);
        }
    }
}
