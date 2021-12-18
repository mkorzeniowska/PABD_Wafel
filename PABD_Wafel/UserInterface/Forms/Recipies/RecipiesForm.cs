using PABD.UserInterface.Forms.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PABD.UserInterface.Forms.Recipies
{
    public partial class RecipiesForm : BaseForm
    {
        private static RecipiesForm _instance = null;

        public static RecipiesForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RecipiesForm();
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

        public RecipiesForm()
        {
            InitializeComponent();
        }

        private void RecipiesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            RecipiesAddForm frm = new RecipiesAddForm();
            frm.ShowDialog();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            //otwiera okno modyfikowania z wybraną wcześniej recepturą
            RecipiesEditForm frm = new RecipiesEditForm();
            frm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            wypelniSiatke(tmpQerry);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
