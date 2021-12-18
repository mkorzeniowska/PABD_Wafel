using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PABD.UserInterface.Forms.Recipies
{
    partial class RecipiesForm
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
        string tmpQerry = "SELECT * FROM receptura ";

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
                dgvRecipies.DataSource = dtsZestaw.Tables[0];
            }


            dgvRecipies.Refresh();
            rozlacz();
        }
        private void StorageForm_Load(object sender, EventArgs e)
        {

            //Uruchomienie funkcji odświeżającej 
            wypelniSiatke(tmpQerry);
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
            this.tlpRecipies = new System.Windows.Forms.TableLayoutPanel();
            this.pRecipies = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dgvRecipies = new System.Windows.Forms.DataGridView();
            this.tlpRecipies.SuspendLayout();
            this.pRecipies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipies)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpRecipies
            // 
            this.tlpRecipies.ColumnCount = 1;
            this.tlpRecipies.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRecipies.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpRecipies.Controls.Add(this.pRecipies, 0, 0);
            this.tlpRecipies.Controls.Add(this.dgvRecipies, 0, 1);
            this.tlpRecipies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRecipies.Location = new System.Drawing.Point(0, 0);
            this.tlpRecipies.Name = "tlpRecipies";
            this.tlpRecipies.RowCount = 2;
            this.tlpRecipies.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpRecipies.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRecipies.Size = new System.Drawing.Size(800, 450);
            this.tlpRecipies.TabIndex = 0;
            // 
            // pRecipies
            // 
            this.pRecipies.Controls.Add(this.btnRefresh);
            this.pRecipies.Controls.Add(this.btnRemove);
            this.pRecipies.Controls.Add(this.btnModify);
            this.pRecipies.Controls.Add(this.btnCreate);
            this.pRecipies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pRecipies.Location = new System.Drawing.Point(3, 3);
            this.pRecipies.Name = "pRecipies";
            this.pRecipies.Size = new System.Drawing.Size(794, 34);
            this.pRecipies.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefresh.Image = global::PABD.UserInterface.Properties.Resources.refresh_24;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(285, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 34);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Odśwież";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRemove.Image = global::PABD.UserInterface.Properties.Resources.delete_24;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(195, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(90, 34);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Usuń";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnModify
            // 
            this.btnModify.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnModify.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModify.Image = global::PABD.UserInterface.Properties.Resources.edit_24;
            this.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModify.Location = new System.Drawing.Point(90, 0);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(105, 34);
            this.btnModify.TabIndex = 1;
            this.btnModify.Text = "Modyfikuj";
            this.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCreate.Image = global::PABD.UserInterface.Properties.Resources.add_24;
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.Location = new System.Drawing.Point(0, 0);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(90, 34);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Dodaj";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dgvRecipies
            // 
            this.dgvRecipies.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecipies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecipies.Location = new System.Drawing.Point(3, 43);
            this.dgvRecipies.Name = "dgvRecipies";
            this.dgvRecipies.Size = new System.Drawing.Size(794, 404);
            this.dgvRecipies.TabIndex = 1;
            // 
            // RecipiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpRecipies);
            this.Name = "RecipiesForm";
            this.Text = "Receptury";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RecipiesForm_FormClosed);
            this.Load += new System.EventHandler(this.StorageForm_Load);
            this.tlpRecipies.ResumeLayout(false);
            this.pRecipies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Data.DataSet dtsZestaw;
        private System.Windows.Forms.TableLayoutPanel tlpRecipies;
        private System.Windows.Forms.Panel pRecipies;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.DataGridView dgvRecipies;
    }
}