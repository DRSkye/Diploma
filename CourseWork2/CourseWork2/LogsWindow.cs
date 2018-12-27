using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork2
{
    public partial class LogsWindow : Form
    {
        public LogsWindow(List<string> logs)
        {
            InitializeComponent();
            foreach(var log in logs)
            {
                logsList.Items.Add(log);
            }
        }
    }
}
