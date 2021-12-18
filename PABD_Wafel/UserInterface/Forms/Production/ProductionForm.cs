using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PABD.UserInterface.Forms.Production
{
    public partial class ProductionForm : Form
    {
        private static ProductionForm _instance = null;

        public static ProductionForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ProductionForm();
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

        private void ProductionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private ProductionForm()
        {
            InitializeComponent();
        }

    }
}
