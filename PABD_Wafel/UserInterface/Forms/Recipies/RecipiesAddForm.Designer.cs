namespace PABD.UserInterface.Forms.Recipies
{
    partial class RecipiesAddForm
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
            this.lblRecipies = new System.Windows.Forms.Label();
            this.gbRecipies1 = new System.Windows.Forms.GroupBox();
            this.dgvRecipies = new System.Windows.Forms.DataGridView();
            this.gbRecipies2 = new System.Windows.Forms.GroupBox();
            this.tbRecipiesDescription = new System.Windows.Forms.TextBox();
            this.tbRecipiesName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbRecipiesTime = new System.Windows.Forms.TextBox();
            this.lblRecipiesTime = new System.Windows.Forms.Label();
            this.NameIngridient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityIngridient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unity = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.gbRecipies1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipies)).BeginInit();
            this.gbRecipies2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRecipies
            // 
            this.lblRecipies.AutoSize = true;
            this.lblRecipies.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRecipies.Location = new System.Drawing.Point(33, 29);
            this.lblRecipies.Name = "lblRecipies";
            this.lblRecipies.Size = new System.Drawing.Size(140, 21);
            this.lblRecipies.TabIndex = 0;
            this.lblRecipies.Text = "Nazwa receptury";
            // 
            // gbRecipies1
            // 
            this.gbRecipies1.Controls.Add(this.dgvRecipies);
            this.gbRecipies1.Location = new System.Drawing.Point(37, 83);
            this.gbRecipies1.Name = "gbRecipies1";
            this.gbRecipies1.Size = new System.Drawing.Size(330, 265);
            this.gbRecipies1.TabIndex = 1;
            this.gbRecipies1.TabStop = false;
            this.gbRecipies1.Text = "Składniki";
            // 
            // dgvRecipies
            // 
            this.dgvRecipies.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecipies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameIngridient,
            this.QuantityIngridient,
            this.Unity});
            this.dgvRecipies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecipies.Location = new System.Drawing.Point(3, 16);
            this.dgvRecipies.Name = "dgvRecipies";
            this.dgvRecipies.Size = new System.Drawing.Size(324, 246);
            this.dgvRecipies.TabIndex = 0;
            this.dgvRecipies.UseWaitCursor = true;
            this.dgvRecipies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecipies_CellContentClick);
            // 
            // gbRecipies2
            // 
            this.gbRecipies2.Controls.Add(this.tbRecipiesDescription);
            this.gbRecipies2.Location = new System.Drawing.Point(437, 83);
            this.gbRecipies2.Name = "gbRecipies2";
            this.gbRecipies2.Size = new System.Drawing.Size(318, 265);
            this.gbRecipies2.TabIndex = 2;
            this.gbRecipies2.TabStop = false;
            this.gbRecipies2.Text = "Opis";
            // 
            // tbRecipiesDescription
            // 
            this.tbRecipiesDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRecipiesDescription.Location = new System.Drawing.Point(3, 16);
            this.tbRecipiesDescription.Multiline = true;
            this.tbRecipiesDescription.Name = "tbRecipiesDescription";
            this.tbRecipiesDescription.Size = new System.Drawing.Size(312, 246);
            this.tbRecipiesDescription.TabIndex = 0;
            // 
            // tbRecipiesName
            // 
            this.tbRecipiesName.Location = new System.Drawing.Point(210, 29);
            this.tbRecipiesName.Name = "tbRecipiesName";
            this.tbRecipiesName.Size = new System.Drawing.Size(227, 20);
            this.tbRecipiesName.TabIndex = 3;
            this.tbRecipiesName.TextChanged += new System.EventHandler(this.tbRecipiesName_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.Location = new System.Drawing.Point(679, 468);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.Location = new System.Drawing.Point(584, 468);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbRecipiesTime
            // 
            this.tbRecipiesTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbRecipiesTime.Location = new System.Drawing.Point(151, 383);
            this.tbRecipiesTime.Name = "tbRecipiesTime";
            this.tbRecipiesTime.Size = new System.Drawing.Size(115, 23);
            this.tbRecipiesTime.TabIndex = 6;
            // 
            // lblRecipiesTime
            // 
            this.lblRecipiesTime.AutoSize = true;
            this.lblRecipiesTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRecipiesTime.Location = new System.Drawing.Point(43, 391);
            this.lblRecipiesTime.Name = "lblRecipiesTime";
            this.lblRecipiesTime.Size = new System.Drawing.Size(93, 15);
            this.lblRecipiesTime.TabIndex = 7;
            this.lblRecipiesTime.Text = "Czas wykonania";
            // 
            // NameIngridient
            // 
            this.NameIngridient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameIngridient.HeaderText = "Nazwa składnika";
            this.NameIngridient.Name = "NameIngridient";
            // 
            // QuantityIngridient
            // 
            this.QuantityIngridient.HeaderText = "Ilość";
            this.QuantityIngridient.Name = "QuantityIngridient";
            // 
            // Unity
            // 
            this.Unity.HeaderText = "Jednostka";
            this.Unity.Items.AddRange(new object[] {
            "kg",
            "szt"});
            this.Unity.Name = "Unity";
            // 
            // RecipiesAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(847, 563);
            this.Controls.Add(this.lblRecipiesTime);
            this.Controls.Add(this.tbRecipiesTime);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbRecipiesName);
            this.Controls.Add(this.gbRecipies2);
            this.Controls.Add(this.gbRecipies1);
            this.Controls.Add(this.lblRecipies);
            this.Name = "RecipiesAddForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj recepturę";
            this.gbRecipies1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipies)).EndInit();
            this.gbRecipies2.ResumeLayout(false);
            this.gbRecipies2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecipies;
        private System.Windows.Forms.GroupBox gbRecipies1;
        private System.Windows.Forms.GroupBox gbRecipies2;
        private System.Windows.Forms.TextBox tbRecipiesDescription;
        private System.Windows.Forms.TextBox tbRecipiesName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvRecipies;
        private System.Windows.Forms.TextBox tbRecipiesTime;
        private System.Windows.Forms.Label lblRecipiesTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameIngridient;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityIngridient;
        private System.Windows.Forms.DataGridViewComboBoxColumn Unity;
    }
}