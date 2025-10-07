using System;
using System.Windows.Forms;
using ThucHanh2;
namespace LAB3
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form2());
        }
    }
}
