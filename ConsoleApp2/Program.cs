using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();

            var fileExtension = Path.GetExtension(dlg.FileName);
        }
    }
}
