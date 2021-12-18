using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace PABD.UserInterface.Forms.Storage
{
    partial class StorageForm
    {
        protected static string sConnectionString = "Data Source=DESKTOP-V5O7J68;Initial Catalog=Produkcja;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

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


        private void StorageForm_Load(object sender, EventArgs e)
        {

            //Uruchomienie funkcji odświeżającej ekranową tabelę z danymi
            wypelnijKomponenty();
            wypelnijProdukty();

        }
        //Definicja głównego stringu połączeniowego

        //Zmienna realizująca proces połączenia
        private SqlConnection polaczenie;
        //funkcja służąca do nawiązywania połączenia
        private void wypelnijKomponenty()
        {

            polacz();
            dtsZestaw = select("SELECT * FROM[Produkcja].[dbo].[Magazyn] WHERE Kategoria = 3 ");
            dgvStorageProducts.DataSource = dtsZestaw.Tables[0];
            dgvStorageComponents.Refresh();
            rozlacz();
        }
        private void wypelnijProdukty()
        {

            polacz();
            dtsZestaw = select("SELECT * FROM[Produkcja].[dbo].[Magazyn] WHERE Kategoria != 3 ");
            dgvStorageComponents.DataSource = dtsZestaw.Tables[0];
            dgvStorageComponents.Refresh();
            rozlacz();
        }
        public bool delete(string query)
        {
            try
            {
                polacz();
                SqlCommand Command = new SqlCommand(query, polaczenie);
                Command.ExecuteNonQuery();
                rozlacz(); 
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;

            }
            return true;

        }

        public bool rozlacz()
        {
            try
            {
                //zamknięcie połączenia
                polaczenie.Close();
                return true;
            }
            catch
            {
                //w przypadku niepowodzenia zwrócenie wartości false
                return false;
            }
        }
        
        public bool polacz()
        {
            try
            {
                //inicjalizacja połączenia wartością stringu połączeniowego
                polaczenie = new SqlConnection(sConnectionString);

                //otwarcie połączenia z bazą danych
                polaczenie.Open();
                return true;

            }
            catch
            {
                //w przypadku niepowodzenia zwrócenie kodu błędu
                MessageBox.Show("Błąd 02 - połączenia");
                return false;
            }
        }
        public DataSet select(string query)
        {
            //Wykonanie zapytania sql
            SqlCommand xquery = new SqlCommand(query, polaczenie);
            //Zapisanie otrzymanych danych w obiekcie SqlDataAdapter
            SqlDataAdapter xdata = new SqlDataAdapter(xquery);
            //Utworzenie obiektu DataSet
            DataSet res = new DataSet();

            try
            {
                //Wpełnienie obiektu DataSet danymi
                xdata.Fill(res);
            }
            catch


            {
                return null;
            }
            return res;
        }

        




        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pStorage = new System.Windows.Forms.Panel();
            this.btnStorageRefresh = new System.Windows.Forms.Button();
            this.btnStorageRemove = new System.Windows.Forms.Button();
            this.btnStorageModify = new System.Windows.Forms.Button();
            this.btnStorageCreate = new System.Windows.Forms.Button();
            this.tbStorage = new System.Windows.Forms.TabControl();
            this.tbStorageComponents = new System.Windows.Forms.TabPage();
            this.dgvStorageComponents = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStorageSearch = new System.Windows.Forms.Button();
            this.tbStorageSearch1 = new System.Windows.Forms.TextBox();
            this.tpStorageProducts = new System.Windows.Forms.TabPage();
            this.dgvStorageProducts = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tbStorageSearch2 = new System.Windows.Forms.TextBox();
            this.pStorage.SuspendLayout();
            this.tbStorage.SuspendLayout();
            this.tbStorageComponents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorageComponents)).BeginInit();
            this.panel1.SuspendLayout();
            this.tpStorageProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorageProducts)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pStorage
            // 
            this.pStorage.Controls.Add(this.btnStorageRefresh);
            this.pStorage.Controls.Add(this.btnStorageRemove);
            this.pStorage.Controls.Add(this.btnStorageModify);
            this.pStorage.Controls.Add(this.btnStorageCreate);
            this.pStorage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pStorage.Location = new System.Drawing.Point(0, 0);
            this.pStorage.Name = "pStorage";
            this.pStorage.Size = new System.Drawing.Size(800, 34);
            this.pStorage.TabIndex = 0;
            // 
            // btnStorageRefresh
            // 
            this.btnStorageRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStorageRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStorageRefresh.Image = global::PABD.UserInterface.Properties.Resources.refresh_24;
            this.btnStorageRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStorageRefresh.Location = new System.Drawing.Point(285, 0);
            this.btnStorageRefresh.Name = "btnStorageRefresh";
            this.btnStorageRefresh.Size = new System.Drawing.Size(90, 34);
            this.btnStorageRefresh.TabIndex = 4;
            this.btnStorageRefresh.Text = "Odśwież";
            this.btnStorageRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStorageRefresh.UseVisualStyleBackColor = true;
            this.btnStorageRefresh.Click += new System.EventHandler(this.StorageForm_Load);
            // 
            // btnStorageRemove
            // 
            this.btnStorageRemove.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStorageRemove.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStorageRemove.Image = global::PABD.UserInterface.Properties.Resources.delete_24;
            this.btnStorageRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStorageRemove.Location = new System.Drawing.Point(195, 0);
            this.btnStorageRemove.Name = "btnStorageRemove";
            this.btnStorageRemove.Size = new System.Drawing.Size(90, 34);
            this.btnStorageRemove.TabIndex = 3;
            this.btnStorageRemove.Text = "Usuń";
            this.btnStorageRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStorageRemove.UseVisualStyleBackColor = true;
            this.btnStorageRemove.Click += new System.EventHandler(this.btnStorageRemove_Click);
            // 
            // btnStorageModify
            // 
            this.btnStorageModify.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStorageModify.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStorageModify.Image = global::PABD.UserInterface.Properties.Resources.edit_24;
            this.btnStorageModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStorageModify.Location = new System.Drawing.Point(90, 0);
            this.btnStorageModify.Name = "btnStorageModify";
            this.btnStorageModify.Size = new System.Drawing.Size(105, 34);
            this.btnStorageModify.TabIndex = 2;
            this.btnStorageModify.Text = "Modyfikuj";
            this.btnStorageModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStorageModify.UseVisualStyleBackColor = true;
            // 
            // btnStorageCreate
            // 
            this.btnStorageCreate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStorageCreate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStorageCreate.Image = global::PABD.UserInterface.Properties.Resources.add_24;
            this.btnStorageCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStorageCreate.Location = new System.Drawing.Point(0, 0);
            this.btnStorageCreate.Name = "btnStorageCreate";
            this.btnStorageCreate.Size = new System.Drawing.Size(90, 34);
            this.btnStorageCreate.TabIndex = 1;
            this.btnStorageCreate.Text = "Dodaj";
            this.btnStorageCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStorageCreate.UseVisualStyleBackColor = true;
            this.btnStorageCreate.Click += new System.EventHandler(this.btnStorageCreate_Click);
            // 
            // tbStorage
            // 
            this.tbStorage.Controls.Add(this.tbStorageComponents);
            this.tbStorage.Controls.Add(this.tpStorageProducts);
            this.tbStorage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbStorage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbStorage.Location = new System.Drawing.Point(0, 34);
            this.tbStorage.Name = "tbStorage";
            this.tbStorage.SelectedIndex = 0;
            this.tbStorage.Size = new System.Drawing.Size(800, 416);
            this.tbStorage.TabIndex = 1;
            // 
            // tbStorageComponents
            // 
            this.tbStorageComponents.Controls.Add(this.dgvStorageComponents);
            this.tbStorageComponents.Controls.Add(this.panel1);
            this.tbStorageComponents.Location = new System.Drawing.Point(4, 26);
            this.tbStorageComponents.Name = "tbStorageComponents";
            this.tbStorageComponents.Padding = new System.Windows.Forms.Padding(3);
            this.tbStorageComponents.Size = new System.Drawing.Size(792, 386);
            this.tbStorageComponents.TabIndex = 0;
            this.tbStorageComponents.Text = "Surowce";
            this.tbStorageComponents.UseVisualStyleBackColor = true;
            // 
            // dgvStorageComponents
            // 
            this.dgvStorageComponents.BackgroundColor = System.Drawing.Color.White;
            this.dgvStorageComponents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStorageComponents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStorageComponents.Location = new System.Drawing.Point(3, 41);
            this.dgvStorageComponents.Name = "dgvStorageComponents";
            this.dgvStorageComponents.Size = new System.Drawing.Size(786, 342);
            this.dgvStorageComponents.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStorageSearch);
            this.panel1.Controls.Add(this.tbStorageSearch1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 38);
            this.panel1.TabIndex = 0;
            // 
            // btnStorageSearch
            // 
            this.btnStorageSearch.Location = new System.Drawing.Point(293, 3);
            this.btnStorageSearch.Name = "btnStorageSearch";
            this.btnStorageSearch.Size = new System.Drawing.Size(75, 32);
            this.btnStorageSearch.TabIndex = 1;
            this.btnStorageSearch.Text = "Wyszukaj";
            this.btnStorageSearch.UseVisualStyleBackColor = true;
            // 
            // tbStorageSearch1
            // 
            this.tbStorageSearch1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbStorageSearch1.Location = new System.Drawing.Point(9, 10);
            this.tbStorageSearch1.Name = "tbStorageSearch1";
            this.tbStorageSearch1.Size = new System.Drawing.Size(278, 22);
            this.tbStorageSearch1.TabIndex = 0;
            this.tbStorageSearch1.Text = "Znajdź produkt";
            this.tbStorageSearch1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbStorageSearch1.TextChanged += new System.EventHandler(this.tbStorageSearch1_TextChanged);
            // 
            // tpStorageProducts
            // 
            this.tpStorageProducts.Controls.Add(this.dgvStorageProducts);
            this.tpStorageProducts.Controls.Add(this.panel2);
            this.tpStorageProducts.Location = new System.Drawing.Point(4, 26);
            this.tpStorageProducts.Name = "tpStorageProducts";
            this.tpStorageProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tpStorageProducts.Size = new System.Drawing.Size(792, 386);
            this.tpStorageProducts.TabIndex = 1;
            this.tpStorageProducts.Text = "Produkty gotowe";
            this.tpStorageProducts.UseVisualStyleBackColor = true;
            // 
            // dgvStorageProducts
            // 
            this.dgvStorageProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvStorageProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStorageProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStorageProducts.Location = new System.Drawing.Point(3, 41);
            this.dgvStorageProducts.Name = "dgvStorageProducts";
            this.dgvStorageProducts.Size = new System.Drawing.Size(786, 342);
            this.dgvStorageProducts.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.tbStorageSearch2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 38);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Wyszukaj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbStorageSearch2
            // 
            this.tbStorageSearch2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbStorageSearch2.Location = new System.Drawing.Point(9, 10);
            this.tbStorageSearch2.Name = "tbStorageSearch2";
            this.tbStorageSearch2.Size = new System.Drawing.Size(278, 22);
            this.tbStorageSearch2.TabIndex = 0;
            this.tbStorageSearch2.Text = "Znajdź produkt";
            this.tbStorageSearch2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StorageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbStorage);
            this.Controls.Add(this.pStorage);
            this.Name = "StorageForm";
            this.Text = "Magazyn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StorageForm_FormClosed);
            this.Load += new System.EventHandler(this.StorageForm_Load);
            this.pStorage.ResumeLayout(false);
            this.tbStorage.ResumeLayout(false);
            this.tbStorageComponents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorageComponents)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tpStorageProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorageProducts)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Data.DataSet dtsZestaw;
        private System.Windows.Forms.Panel pStorage;
        private System.Windows.Forms.Button btnStorageCreate;
        private System.Windows.Forms.Button btnStorageModify;
        private System.Windows.Forms.Button btnStorageRemove;
        private System.Windows.Forms.Button btnStorageRefresh;
        private System.Windows.Forms.TabControl tbStorage;
        private System.Windows.Forms.TabPage tbStorageComponents;
        private System.Windows.Forms.DataGridView dgvStorageComponents;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStorageSearch;
        private System.Windows.Forms.TextBox tbStorageSearch1;
        private System.Windows.Forms.TabPage tpStorageProducts;
        private DataGridView dgvStorageProducts;
        private Panel panel2;
        private Button button1;
        private TextBox tbStorageSearch2;
    }
}