using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PABD.UserInterface.Forms.Orders
{
    public partial class OrdersForm : Form
    {
        private static OrdersForm _instance = null;

        public static OrdersForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new OrdersForm();
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


        public OrdersForm()
        {
            InitializeComponent();
        }

        private void OrdersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {

        }

        private void Filtruj_Click(object sender, EventArgs e)
        {
            tmpQerry = "SELECT * FROM[Produkcja].[dbo].[Zlecenia] where Nr_zlecenia =" + tbID.Text + " OR Nazwa_produktu ='" + tbName.Text + "'";
            wypelniSiatke(tmpQerry);
        }
    }
}
