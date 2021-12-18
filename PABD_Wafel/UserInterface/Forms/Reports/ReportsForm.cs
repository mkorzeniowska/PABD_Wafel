using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PABD.UserInterface.Forms.Reports
{
    public partial class ReportsForm : Form
    {
        private static ReportsForm _instance = null;

        public static ReportsForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ReportsForm();
                }
                return _instance;
            }

        }

        public static bool IsNull
        {
            get
            {
                if (_instance == null)
                {
                    return true;
                }
                return false;
            }

        }
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void ReportsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
    }
}
