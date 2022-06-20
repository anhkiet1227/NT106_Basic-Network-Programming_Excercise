using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleServer
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            server simpleServer = new server("127.0.0.1", 2222); // 1111, 2222, 3333, 4444, 5555
            simpleServer.start();
            simpleServer.stop();
        }
    }
}
