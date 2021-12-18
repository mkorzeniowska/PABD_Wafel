using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PABD.UserInterface.Forms.Configuration
{
    public partial class ConfigurationForm : Form
    {
        private static ConfigurationForm _instance = null;

        public static ConfigurationForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ConfigurationForm();
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

        public ConfigurationForm()
        {
            InitializeComponent();
        }

        private void ConfigDataBase_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPasswd_Click(object sender, EventArgs e)
        {

        }

        private void lblServerName_Click(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

        }
    }
}
