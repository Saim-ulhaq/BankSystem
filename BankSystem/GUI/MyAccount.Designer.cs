﻿using System.Drawing;
namespace BankSystem
{
    partial class MyAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyAccount));
            this.FirName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Ag = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Country = new System.Windows.Forms.Label();
            this.PhNumber = new System.Windows.Forms.Label();
            this.Phon = new System.Windows.Forms.Label();
            this.Card = new System.Windows.Forms.Label();
            this.Cardn = new System.Windows.Forms.Label();
            this.Am = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Deposit = new System.Windows.Forms.Button();
            this.Withdrawal = new System.Windows.Forms.Button();
            this.Transfer = new System.Windows.Forms.Button();
            this.Payment = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // FirName
            // 
            this.FirName.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirName.Location = new System.Drawing.Point(20, 46);
            this.FirName.Name = "FirName";
            this.FirName.Size = new System.Drawing.Size(195, 19);
            this.FirName.TabIndex = 0;
            this.FirName.Text = "label1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.94595F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.05405F));
            this.tableLayoutPanel1.Controls.Add(this.Ag, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Age, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Country, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.PhNumber, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Phon, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Card, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Cardn, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Am, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Amount, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 68);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(291, 174);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // Ag
            // 
            this.Ag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Ag.AutoSize = true;
            this.Ag.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ag.Location = new System.Drawing.Point(3, 8);
            this.Ag.Name = "Ag";
            this.Ag.Size = new System.Drawing.Size(48, 19);
            this.Ag.TabIndex = 2;
            this.Ag.Text = "Age :";
            // 
            // Age
            // 
            this.Age.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Age.AutoSize = true;
            this.Age.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age.Location = new System.Drawing.Point(136, 8);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(59, 19);
            this.Age.TabIndex = 3;
            this.Age.Text = "label1";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Country :";
            // 
            // Country
            // 
            this.Country.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Country.AutoSize = true;
            this.Country.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Country.Location = new System.Drawing.Point(136, 43);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(59, 19);
            this.Country.TabIndex = 4;
            this.Country.Text = "label1";
            // 
            // PhNumber
            // 
            this.PhNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PhNumber.AutoSize = true;
            this.PhNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhNumber.Location = new System.Drawing.Point(3, 78);
            this.PhNumber.Name = "PhNumber";
            this.PhNumber.Size = new System.Drawing.Size(126, 19);
            this.PhNumber.TabIndex = 4;
            this.PhNumber.Text = "Phone Number :";
            // 
            // Phon
            // 
            this.Phon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Phon.AutoSize = true;
            this.Phon.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phon.Location = new System.Drawing.Point(136, 78);
            this.Phon.Name = "Phon";
            this.Phon.Size = new System.Drawing.Size(59, 19);
            this.Phon.TabIndex = 9;
            this.Phon.Text = "label1";
            // 
            // Card
            // 
            this.Card.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Card.AutoSize = true;
            this.Card.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Card.Location = new System.Drawing.Point(3, 113);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(115, 19);
            this.Card.TabIndex = 7;
            this.Card.Text = "Crad Number :";
            // 
            // Cardn
            // 
            this.Cardn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Cardn.AutoSize = true;
            this.Cardn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cardn.Location = new System.Drawing.Point(136, 113);
            this.Cardn.Name = "Cardn";
            this.Cardn.Size = new System.Drawing.Size(59, 19);
            this.Cardn.TabIndex = 9;
            this.Cardn.Text = "label1";
            // 
            // Am
            // 
            this.Am.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Am.AutoSize = true;
            this.Am.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Am.Location = new System.Drawing.Point(3, 148);
            this.Am.Name = "Am";
            this.Am.Size = new System.Drawing.Size(77, 19);
            this.Am.TabIndex = 9;
            this.Am.Text = "Amount :";
            // 
            // Amount
            // 
            this.Amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Amount.AutoSize = true;
            this.Amount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.Location = new System.Drawing.Point(136, 148);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(59, 19);
            this.Amount.TabIndex = 10;
            this.Amount.Text = "label1";
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(12, 9);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(299, 19);
            this.Email.TabIndex = 9;
            this.Email.Text = "label1";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.Deposit, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Withdrawal, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Transfer, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.Payment, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(329, 46);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(175, 204);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // Deposit
            // 
            this.Deposit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deposit.Location = new System.Drawing.Point(22, 6);
            this.Deposit.Name = "Deposit";
            this.Deposit.Size = new System.Drawing.Size(130, 38);
            this.Deposit.TabIndex = 0;
            this.Deposit.Text = "Deposit";
            this.Deposit.UseVisualStyleBackColor = true;
            this.Deposit.Click += new System.EventHandler(this.Deposit_Click);
            // 
            // Withdrawal
            // 
            this.Withdrawal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Withdrawal.Location = new System.Drawing.Point(22, 57);
            this.Withdrawal.Name = "Withdrawal";
            this.Withdrawal.Size = new System.Drawing.Size(130, 38);
            this.Withdrawal.TabIndex = 1;
            this.Withdrawal.Text = "Withdrawal";
            this.Withdrawal.UseVisualStyleBackColor = true;
            this.Withdrawal.Click += new System.EventHandler(this.Withdrawal_Click);
            // 
            // Transfer
            // 
            this.Transfer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Transfer.Location = new System.Drawing.Point(22, 108);
            this.Transfer.Name = "Transfer";
            this.Transfer.Size = new System.Drawing.Size(130, 38);
            this.Transfer.TabIndex = 2;
            this.Transfer.Text = "Transfer Money";
            this.Transfer.UseVisualStyleBackColor = true;
            this.Transfer.Click += new System.EventHandler(this.Transfer_Click);
            // 
            // Payment
            // 
            this.Payment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Payment.Location = new System.Drawing.Point(22, 159);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(130, 38);
            this.Payment.TabIndex = 3;
            this.Payment.Text = "Payment Service";
            this.Payment.UseVisualStyleBackColor = true;
            this.Payment.Click += new System.EventHandler(this.Payment_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Value});
            this.dataGridView1.Location = new System.Drawing.Point(11, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(480, 230);
            this.dataGridView1.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Log";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 310;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Value.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Value.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "Delete My Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MyAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BankSystem.Properties.Resources.AccountWall;
            this.ClientSize = new System.Drawing.Size(503, 508);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.FirName);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MyAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Account";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label FirName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Am;
        private System.Windows.Forms.Label Ag;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PhNumber;
        private System.Windows.Forms.Label Card;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label Cardn;
        private System.Windows.Forms.Label Phon;
        private System.Windows.Forms.Label Country;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Deposit;
        private System.Windows.Forms.Button Withdrawal;
        private System.Windows.Forms.Button Transfer;
        private System.Windows.Forms.Button Payment;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.Button button1;



    }
}