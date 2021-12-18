using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PABD.UserInterface.Forms.Storage
{
    public partial class StorageForm : Form
    {
            private static StorageForm _instance = null;

            public static StorageForm Instance
            {
                get
                {
                    if (_instance == null)
                    {
                        _instance = new StorageForm();
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
            public StorageForm()
        {
            InitializeComponent();
        }

        private void StorageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
                _instance = null;
        }

        private void tbStorageSearch1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStorageCreate_Click(object sender, EventArgs e)
        {
            StorageAddForm frm = new StorageAddForm();
            frm.ShowDialog();
        }

        private void btnStorageRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnStorageRemove_Click(object sender, EventArgs e)
        {
            string q = "DELETE FROM[dbo].[Magazyn] WHERE ID=";
            try
            {
                q += dgvStorageComponents.SelectedRows[0].Cells[0].Value.ToString(); //wyłuskanie wskazanego indeksu
                MessageBox.Show(q);
                delete(q);
               
            }
            catch (Exception ex)
            {
                //Wyświetlenie informacji o ewentualnym wyjątku
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
