using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A20_Ex01
{
     // $G$ THE-001 (-20) your grade on diagrams document - 80. please see comments inside the document. 50% of your grade).
     public static class Program
    {
        ////[MTAThread]
        [STAThread]
        public static void Main()
        {                        
            Application.EnableVisualStyles();
            Application.Run(FormFactory.CreateForm(typeof(FormMain)));
        }
    }
}
