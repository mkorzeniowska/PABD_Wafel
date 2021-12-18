using PABD.UserInterface.Forms.Storage;
using PABD.UserInterface.Forms.Orders;
using PABD.UserInterface.Forms.Production;
using PABD.UserInterface.Forms.Recipies;
using PABD.UserInterface.Forms.Reports;
using PABD.UserInterface.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PABD.UserInterface.Forms.Configuration;

namespace PABD.UserInterface.Forms
{
    public partial class MainForms : Form
    {
        
        public MainForms()
        {
            InitializeComponent();
        }


        #region Events
        private void loadConfiguration(object sender, EventArgs e)
        {
            if (ConfigurationForm.IsNull)
            {
                ShowFormInTabPage(ConfigurationForm.Instance);
            }
        }

        private void btnProduction_Click(object sender, EventArgs e)
        {
            if (ProductionForm.IsNull)
            {
                ShowFormInTabPage(ProductionForm.Instance);
            }
           
        }

        private void btnStorage_Click(object sender, EventArgs e)
        {
            if (StorageForm.IsNull)
            {
                ShowFormInTabPage(StorageForm.Instance);
            }
        }

        private void btnRecipies_Click(object sender, EventArgs e)
        {
            if (RecipiesForm.IsNull)
            {
                ShowFormInTabPage(RecipiesForm.Instance);
            }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            if (ReportsForm.IsNull)
            {
                ShowFormInTabPage(ReportsForm.Instance);
            }
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            if (OrdersForm.IsNull)
            {
                ShowFormInTabPage(OrdersForm.Instance);
            }
        }

        private void tcTabs_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                var tabPage = this.tcTabs.TabPages[e.Index];
                var tabRect = this.tcTabs.GetTabRect(e.Index);
               
                var closeImage = new Bitmap($"{ResourcesHelpers.ResourcesFilePath}\\{ResourcesHelpers.closeButton}");
                e.Graphics.DrawImage(closeImage,
                        (tabRect.Right - closeImage.Width),
                        tabRect.Top + (tabRect.Height - closeImage.Height) / 2);
                TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font,
                        tabRect, tabPage.ForeColor, TextFormatFlags.Left);
               
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void tcTabs_MouseDown(object sender, MouseEventArgs e)
        {
            // Process MouseDown event only till (tabControl.TabPages.Count - 1) excluding the last TabPage
            for (var i = 0; i < this.tcTabs.TabPages.Count; i++)
            {
                var tabRect = this.tcTabs.GetTabRect(i);
                tabRect.Inflate(-2, -2);
                var closeImage = new Bitmap($"{ResourcesHelpers.ResourcesFilePath}\\{ResourcesHelpers.closeButton}");
                var imageRect = new Rectangle(
                    (tabRect.Right - closeImage.Width),
                    tabRect.Top + (tabRect.Height - closeImage.Height) / 2,
                    closeImage.Width,
                    closeImage.Height);
                if (imageRect.Contains(e.Location))
                {
                    var frm = tcTabs.TabPages[i].Controls[0] as Form;
                    frm.Close();
                    this.tcTabs.TabPages.RemoveAt(i);
                    break;
                }
            }
        }
        #endregion

        #region PrivateMetods
        private void ShowFormInTabPage(Form frm)
        {
            TabPage tpTab = new TabPage();
            tcTabs.Controls.Add(tpTab);

            tpTab.Text = frm.Text;
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            tpTab.Controls.Add(frm);
            tcTabs.SelectedTab = tpTab;
        }
        #endregion


    }
}
