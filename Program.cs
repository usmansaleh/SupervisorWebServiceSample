using System;

using System.Collections.Generic;
using System.ServiceModel.Description;
using System.ServiceModel;
using System.Windows.Forms;

namespace SupervisorWebService
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
