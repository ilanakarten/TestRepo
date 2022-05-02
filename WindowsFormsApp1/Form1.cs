using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public ConcurrentDictionary<string, int> _tmp = new ConcurrentDictionary<string, int>();

        public Form1()
        {
            InitializeComponent();

            _tmp["dd"] = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool s = false;
            var tmp = string.IsNullOrEmpty(s.ToString());
            //value = string.Join(";", col.Cast<string>().Where(s => !string.IsNullOrEmpty(s)).Distinct());

        }
    }
}
 