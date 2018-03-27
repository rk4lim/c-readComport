using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Configurator1
{
    static class Program
    {
        public static SerialPort sPort;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>

       
        [STAThread]

        static void Main()
        {
            sPort = new SerialPort();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
