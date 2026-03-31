using System;
using System.Windows.Forms;

namespace Radio_GonzalesProject
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize(); // Starts WinForms settings
            Application.Run(new frmRadioStar());   // Opens frmRadioStar
        }
    }
}