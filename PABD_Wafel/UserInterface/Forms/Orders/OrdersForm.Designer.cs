using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PABD.UserInterface.Forms.Orders
{
    partial class OrdersForm
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

        protected static string sConnectionString = "Data Source=DESKTOP-V5O7J68;Initial Catalog=Produkcja;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private SqlConnection polaczenie;
        string tmpQerry = " ";

        private void wypelniSiatke(string querry)
        {

            polacz();
            dtsZestaw = select(querry);

            if (dtsZestaw == null) //jeśli zestaw pusty
            {
                MessageBox.Show("Nie znaleziono wyników!");
            }
            
            else
            {
                dgvWorkorders.DataSource = dtsZestaw.Tables[0];
            }
                

            dgvWorkorders.Refresh();
            rozlacz();
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
                MessageBox.Show("Błąd 02");
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
            this.dgvWorkorders = new System.Windows.Forms.DataGridView();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.Filtruj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkorders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWorkorders
            // 
            this.dgvWorkorders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkorders.Location = new System.Drawing.Point(157, 24);
            this.dgvWorkorders.Name = "dgvWorkorders";
            this.dgvWorkorders.Size = new System.Drawing.Size(631, 414);
            this.dgvWorkorders.TabIndex = 0;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(12, 24);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(127, 20);
            this.tbID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nazwa";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 69);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(127, 20);
            this.tbName.TabIndex = 3;
            // 
            // Filtruj
            // 
            this.Filtruj.Location = new System.Drawing.Point(12, 171);
            this.Filtruj.Name = "Filtruj";
            this.Filtruj.Size = new System.Drawing.Size(127, 20);
            this.Filtruj.TabIndex = 5;
            this.Filtruj.Text = "Filtruj";
            this.Filtruj.UseVisualStyleBackColor = true;
            this.Filtruj.Click += new System.EventHandler(this.Filtruj_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(12, 118);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(127, 20);
            this.tbDate.TabIndex = 6;
            this.tbDate.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.Filtruj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.dgvWorkorders);
            this.Name = "OrdersForm";
            this.Text = "Zamówienia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrdersForm_FormClosed);
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkorders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Data.DataSet dtsZestaw;
        private System.Windows.Forms.DataGridView dgvWorkorders;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button Filtruj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDate;
    }
}