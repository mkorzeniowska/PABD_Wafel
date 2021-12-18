namespace PABD.UserInterface.Forms
{
    partial class MainForms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpMenu = new System.Windows.Forms.TabPage();
            this.btnOrders = new System.Windows.Forms.Button();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.btnReports = new System.Windows.Forms.Button();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.btnRecipies = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.btnStorage = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnProduction = new System.Windows.Forms.Button();
            this.tpConfiguration = new System.Windows.Forms.TabPage();
            this.tbHelp = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDataBase = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tcTabs = new System.Windows.Forms.TabControl();
            this.tcMain.SuspendLayout();
            this.tpMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpMenu);
            this.tcMain.Controls.Add(this.tpConfiguration);
            this.tcMain.Controls.Add(this.tbHelp);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcMain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1020, 74);
            this.tcMain.TabIndex = 0;
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.loadConfiguration);
            // 
            // tpMenu
            // 
            this.tpMenu.Controls.Add(this.btnOrders);
            this.tpMenu.Controls.Add(this.splitter4);
            this.tpMenu.Controls.Add(this.btnReports);
            this.tpMenu.Controls.Add(this.splitter3);
            this.tpMenu.Controls.Add(this.btnRecipies);
            this.tpMenu.Controls.Add(this.splitter2);
            this.tpMenu.Controls.Add(this.btnStorage);
            this.tpMenu.Controls.Add(this.splitter1);
            this.tpMenu.Controls.Add(this.btnProduction);
            this.tpMenu.Location = new System.Drawing.Point(4, 30);
            this.tpMenu.Name = "tpMenu";
            this.tpMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tpMenu.Size = new System.Drawing.Size(1012, 40);
            this.tpMenu.TabIndex = 0;
            this.tpMenu.Text = "Menu";
            this.tpMenu.UseVisualStyleBackColor = true;
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.White;
            this.btnOrders.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOrders.Image = global::PABD.UserInterface.Properties.Resources.orders_32;
            this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.Location = new System.Drawing.Point(453, 3);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(120, 34);
            this.btnOrders.TabIndex = 8;
            this.btnOrders.Text = "Zamówienia";
            this.btnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // splitter4
            // 
            this.splitter4.Location = new System.Drawing.Point(448, 3);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(5, 34);
            this.splitter4.TabIndex = 7;
            this.splitter4.TabStop = false;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.White;
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReports.Image = global::PABD.UserInterface.Properties.Resources.reports_32;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(348, 3);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(100, 34);
            this.btnReports.TabIndex = 6;
            this.btnReports.Text = "Raporty";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(343, 3);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(5, 34);
            this.splitter3.TabIndex = 5;
            this.splitter3.TabStop = false;
            // 
            // btnRecipies
            // 
            this.btnRecipies.BackColor = System.Drawing.Color.White;
            this.btnRecipies.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRecipies.Image = global::PABD.UserInterface.Properties.Resources.Contracts_32;
            this.btnRecipies.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecipies.Location = new System.Drawing.Point(233, 3);
            this.btnRecipies.Name = "btnRecipies";
            this.btnRecipies.Size = new System.Drawing.Size(110, 34);
            this.btnRecipies.TabIndex = 4;
            this.btnRecipies.Text = "Receptury";
            this.btnRecipies.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecipies.UseVisualStyleBackColor = false;
            this.btnRecipies.Click += new System.EventHandler(this.btnRecipies_Click);
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(228, 3);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(5, 34);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // btnStorage
            // 
            this.btnStorage.BackColor = System.Drawing.Color.White;
            this.btnStorage.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStorage.Image = global::PABD.UserInterface.Properties.Resources.storage;
            this.btnStorage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStorage.Location = new System.Drawing.Point(118, 3);
            this.btnStorage.Name = "btnStorage";
            this.btnStorage.Size = new System.Drawing.Size(110, 34);
            this.btnStorage.TabIndex = 2;
            this.btnStorage.Text = "Magazyn";
            this.btnStorage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStorage.UseVisualStyleBackColor = false;
            this.btnStorage.Click += new System.EventHandler(this.btnStorage_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(113, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 34);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // btnProduction
            // 
            this.btnProduction.BackColor = System.Drawing.Color.White;
            this.btnProduction.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnProduction.Image = global::PABD.UserInterface.Properties.Resources.production_32;
            this.btnProduction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduction.Location = new System.Drawing.Point(3, 3);
            this.btnProduction.Name = "btnProduction";
            this.btnProduction.Size = new System.Drawing.Size(110, 34);
            this.btnProduction.TabIndex = 0;
            this.btnProduction.Text = "Produkcja";
            this.btnProduction.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProduction.UseVisualStyleBackColor = false;
            this.btnProduction.Click += new System.EventHandler(this.btnProduction_Click);
            // 
            // tpConfiguration
            // 
            this.tpConfiguration.Location = new System.Drawing.Point(4, 30);
            this.tpConfiguration.Name = "tpConfiguration";
            this.tpConfiguration.Padding = new System.Windows.Forms.Padding(3);
            this.tpConfiguration.Size = new System.Drawing.Size(1012, 40);
            this.tpConfiguration.TabIndex = 2;
            this.tpConfiguration.Text = "Konfiguracja";
            this.tpConfiguration.UseVisualStyleBackColor = true;
            // 
            // tbHelp
            // 
            this.tbHelp.Location = new System.Drawing.Point(4, 30);
            this.tbHelp.Name = "tbHelp";
            this.tbHelp.Padding = new System.Windows.Forms.Padding(3);
            this.tbHelp.Size = new System.Drawing.Size(1012, 40);
            this.tbHelp.TabIndex = 3;
            this.tbHelp.Text = "Pomoc";
            this.tbHelp.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslVersion,
            this.tsslDataBase});
            this.statusStrip1.Location = new System.Drawing.Point(0, 621);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1020, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "ssMain";
            // 
            // tsslVersion
            // 
            this.tsslVersion.Name = "tsslVersion";
            this.tsslVersion.Size = new System.Drawing.Size(98, 20);
            this.tsslVersion.Text = "Wersja 1.0.0.0";
            // 
            // tsslDataBase
            // 
            this.tsslDataBase.Name = "tsslDataBase";
            this.tsslDataBase.Size = new System.Drawing.Size(94, 20);
            this.tsslDataBase.Text = "Baza:Główna";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tcTabs);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 547);
            this.panel1.TabIndex = 2;
            // 
            // tcTabs
            // 
            this.tcTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tcTabs.ItemSize = new System.Drawing.Size(105, 20);
            this.tcTabs.Location = new System.Drawing.Point(0, 0);
            this.tcTabs.Name = "tcTabs";
            this.tcTabs.SelectedIndex = 0;
            this.tcTabs.Size = new System.Drawing.Size(1020, 547);
            this.tcTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcTabs.TabIndex = 0;
            this.tcTabs.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tcTabs_DrawItem);
            this.tcTabs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tcTabs_MouseDown);
            // 
            // MainForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 647);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tcMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForms";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wafel i Spółka";
            this.tcMain.ResumeLayout(false);
            this.tpMenu.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpMenu;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Button btnRecipies;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button btnStorage;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnProduction;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslVersion;
        private System.Windows.Forms.ToolStripStatusLabel tsslDataBase;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.TabPage tpConfiguration;
        private System.Windows.Forms.TabPage tbHelp;
        private System.Windows.Forms.TabControl tcTabs;
    }
}