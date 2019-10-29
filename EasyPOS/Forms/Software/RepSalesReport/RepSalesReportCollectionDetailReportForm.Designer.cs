﻿namespace EasyPOS.Forms.Software.RepSalesReport
{
    partial class RepSalesReportCollectionDetailReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepSalesReportCollectionDetailReportForm));
            this.textBoxTotalAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPageListFirst = new System.Windows.Forms.Button();
            this.dataGridViewCollectionDetailReport = new System.Windows.Forms.DataGridView();
            this.buttonPageListNext = new System.Windows.Forms.Button();
            this.buttonPageListPrevious = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonPageListLast = new System.Windows.Forms.Button();
            this.textBoxPageNumber = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonView = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ColumnCollectionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCollectionNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTerminal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnManualORNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSalesNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPayType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCheckNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCheckDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCheckBank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCreditCardVerificationCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCreditCardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCreditCardType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCreditCardBank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCreditCardReferenceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCreditCardHolderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCreditCardExpiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGiftCertificateNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOtherInformation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCollectionDetailReport)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxTotalAmount
            // 
            this.textBoxTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotalAmount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalAmount.Location = new System.Drawing.Point(1112, 14);
            this.textBoxTotalAmount.Name = "textBoxTotalAmount";
            this.textBoxTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxTotalAmount.Size = new System.Drawing.Size(308, 23);
            this.textBoxTotalAmount.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(973, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Total Amount:";
            // 
            // buttonPageListFirst
            // 
            this.buttonPageListFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPageListFirst.Enabled = false;
            this.buttonPageListFirst.FlatAppearance.BorderSize = 0;
            this.buttonPageListFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPageListFirst.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.buttonPageListFirst.Location = new System.Drawing.Point(12, 9);
            this.buttonPageListFirst.Name = "buttonPageListFirst";
            this.buttonPageListFirst.Size = new System.Drawing.Size(82, 32);
            this.buttonPageListFirst.TabIndex = 8;
            this.buttonPageListFirst.Text = "First";
            this.buttonPageListFirst.UseVisualStyleBackColor = false;
            this.buttonPageListFirst.Click += new System.EventHandler(this.buttonCollectionListPageListFirst_Click);
            // 
            // dataGridViewCollectionDetailReport
            // 
            this.dataGridViewCollectionDetailReport.AllowUserToAddRows = false;
            this.dataGridViewCollectionDetailReport.AllowUserToDeleteRows = false;
            this.dataGridViewCollectionDetailReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCollectionDetailReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCollectionDetailReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCollectionDetailReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCollectionDate,
            this.ColumnCollectionNumber,
            this.ColumnTerminal,
            this.ColumnManualORNumber,
            this.ColumnCustomer,
            this.ColumnSalesNumber,
            this.ColumnAmount,
            this.ColumnPayType,
            this.ColumnCheckNumber,
            this.ColumnCheckDate,
            this.ColumnCheckBank,
            this.ColumnCreditCardVerificationCode,
            this.ColumnCreditCardNumber,
            this.ColumnCreditCardType,
            this.ColumnCreditCardBank,
            this.ColumnCreditCardReferenceNumber,
            this.ColumnCreditCardHolderName,
            this.ColumnCreditCardExpiry,
            this.ColumnGiftCertificateNumber,
            this.ColumnOtherInformation});
            this.dataGridViewCollectionDetailReport.Location = new System.Drawing.Point(0, 1);
            this.dataGridViewCollectionDetailReport.Name = "dataGridViewCollectionDetailReport";
            this.dataGridViewCollectionDetailReport.ReadOnly = true;
            this.dataGridViewCollectionDetailReport.RowHeadersVisible = false;
            this.dataGridViewCollectionDetailReport.RowTemplate.Height = 24;
            this.dataGridViewCollectionDetailReport.ShowEditingIcon = false;
            this.dataGridViewCollectionDetailReport.Size = new System.Drawing.Size(1479, 581);
            this.dataGridViewCollectionDetailReport.TabIndex = 0;
            // 
            // buttonPageListNext
            // 
            this.buttonPageListNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPageListNext.FlatAppearance.BorderSize = 0;
            this.buttonPageListNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPageListNext.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.buttonPageListNext.Location = new System.Drawing.Point(337, 9);
            this.buttonPageListNext.Name = "buttonPageListNext";
            this.buttonPageListNext.Size = new System.Drawing.Size(82, 32);
            this.buttonPageListNext.TabIndex = 10;
            this.buttonPageListNext.Text = "Next";
            this.buttonPageListNext.UseVisualStyleBackColor = false;
            this.buttonPageListNext.Click += new System.EventHandler(this.buttonCollectionListPageListNext_Click);
            // 
            // buttonPageListPrevious
            // 
            this.buttonPageListPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPageListPrevious.Enabled = false;
            this.buttonPageListPrevious.FlatAppearance.BorderSize = 0;
            this.buttonPageListPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPageListPrevious.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.buttonPageListPrevious.Location = new System.Drawing.Point(100, 9);
            this.buttonPageListPrevious.Name = "buttonPageListPrevious";
            this.buttonPageListPrevious.Size = new System.Drawing.Size(82, 32);
            this.buttonPageListPrevious.TabIndex = 9;
            this.buttonPageListPrevious.Text = "Previous";
            this.buttonPageListPrevious.UseVisualStyleBackColor = false;
            this.buttonPageListPrevious.Click += new System.EventHandler(this.buttonCollectionListPageListPrevious_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.textBoxTotalAmount);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.buttonPageListFirst);
            this.panel4.Controls.Add(this.buttonPageListNext);
            this.panel4.Controls.Add(this.buttonPageListLast);
            this.panel4.Controls.Add(this.buttonPageListPrevious);
            this.panel4.Controls.Add(this.textBoxPageNumber);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 587);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1482, 53);
            this.panel4.TabIndex = 20;
            // 
            // buttonPageListLast
            // 
            this.buttonPageListLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPageListLast.FlatAppearance.BorderSize = 0;
            this.buttonPageListLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPageListLast.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.buttonPageListLast.Location = new System.Drawing.Point(422, 9);
            this.buttonPageListLast.Name = "buttonPageListLast";
            this.buttonPageListLast.Size = new System.Drawing.Size(82, 32);
            this.buttonPageListLast.TabIndex = 11;
            this.buttonPageListLast.Text = "Last";
            this.buttonPageListLast.UseVisualStyleBackColor = false;
            this.buttonPageListLast.Click += new System.EventHandler(this.buttonCollectionListPageListLast_Click);
            // 
            // textBoxPageNumber
            // 
            this.textBoxPageNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxPageNumber.BackColor = System.Drawing.Color.White;
            this.textBoxPageNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPageNumber.Location = new System.Drawing.Point(231, 14);
            this.textBoxPageNumber.Name = "textBoxPageNumber";
            this.textBoxPageNumber.ReadOnly = true;
            this.textBoxPageNumber.Size = new System.Drawing.Size(69, 23);
            this.textBoxPageNumber.TabIndex = 12;
            this.textBoxPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.dataGridViewCollectionDetailReport);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1482, 640);
            this.panel2.TabIndex = 15;
            // 
            // buttonView
            // 
            this.buttonView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonView.FlatAppearance.BorderSize = 0;
            this.buttonView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonView.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonView.ForeColor = System.Drawing.Color.White;
            this.buttonView.Location = new System.Drawing.Point(1287, 11);
            this.buttonView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(88, 40);
            this.buttonView.TabIndex = 5;
            this.buttonView.TabStop = false;
            this.buttonView.Text = "CSV";
            this.buttonView.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EasyPOS.Properties.Resources.Reports;
            this.pictureBox1.Location = new System.Drawing.Point(14, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(71, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Collection Detail Report";
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(79)))), ((int)(((byte)(28)))));
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(79)))), ((int)(((byte)(28)))));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(1381, 11);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(88, 40);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonView);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1482, 63);
            this.panel1.TabIndex = 14;
            // 
            // ColumnCollectionDate
            // 
            this.ColumnCollectionDate.DataPropertyName = "ColumnCollectionDate";
            this.ColumnCollectionDate.HeaderText = "Date";
            this.ColumnCollectionDate.Name = "ColumnCollectionDate";
            this.ColumnCollectionDate.ReadOnly = true;
            // 
            // ColumnCollectionNumber
            // 
            this.ColumnCollectionNumber.DataPropertyName = "ColumnCollectionNumber";
            this.ColumnCollectionNumber.HeaderText = "Collection No.";
            this.ColumnCollectionNumber.Name = "ColumnCollectionNumber";
            this.ColumnCollectionNumber.ReadOnly = true;
            this.ColumnCollectionNumber.Width = 120;
            // 
            // ColumnTerminal
            // 
            this.ColumnTerminal.DataPropertyName = "ColumnTerminal";
            this.ColumnTerminal.HeaderText = "Terminal";
            this.ColumnTerminal.Name = "ColumnTerminal";
            this.ColumnTerminal.ReadOnly = true;
            // 
            // ColumnManualORNumber
            // 
            this.ColumnManualORNumber.DataPropertyName = "ColumnManualORNumber";
            this.ColumnManualORNumber.HeaderText = "Manual OR No.";
            this.ColumnManualORNumber.Name = "ColumnManualORNumber";
            this.ColumnManualORNumber.ReadOnly = true;
            this.ColumnManualORNumber.Width = 140;
            // 
            // ColumnCustomer
            // 
            this.ColumnCustomer.DataPropertyName = "ColumnCustomer";
            this.ColumnCustomer.HeaderText = "Customer";
            this.ColumnCustomer.Name = "ColumnCustomer";
            this.ColumnCustomer.ReadOnly = true;
            // 
            // ColumnSalesNumber
            // 
            this.ColumnSalesNumber.DataPropertyName = "ColumnSalesNumber";
            this.ColumnSalesNumber.HeaderText = "Sales No.";
            this.ColumnSalesNumber.Name = "ColumnSalesNumber";
            this.ColumnSalesNumber.ReadOnly = true;
            // 
            // ColumnAmount
            // 
            this.ColumnAmount.DataPropertyName = "ColumnAmount";
            this.ColumnAmount.HeaderText = "Amount";
            this.ColumnAmount.Name = "ColumnAmount";
            this.ColumnAmount.ReadOnly = true;
            // 
            // ColumnPayType
            // 
            this.ColumnPayType.DataPropertyName = "ColumnPayType";
            this.ColumnPayType.HeaderText = "PayType";
            this.ColumnPayType.Name = "ColumnPayType";
            this.ColumnPayType.ReadOnly = true;
            // 
            // ColumnCheckNumber
            // 
            this.ColumnCheckNumber.DataPropertyName = "ColumnCheckNumber";
            this.ColumnCheckNumber.HeaderText = "Check No.";
            this.ColumnCheckNumber.Name = "ColumnCheckNumber";
            this.ColumnCheckNumber.ReadOnly = true;
            // 
            // ColumnCheckDate
            // 
            this.ColumnCheckDate.DataPropertyName = "ColumnCheckDate";
            this.ColumnCheckDate.HeaderText = "Check Date";
            this.ColumnCheckDate.Name = "ColumnCheckDate";
            this.ColumnCheckDate.ReadOnly = true;
            this.ColumnCheckDate.Width = 150;
            // 
            // ColumnCheckBank
            // 
            this.ColumnCheckBank.DataPropertyName = "ColumnCheckBank";
            this.ColumnCheckBank.HeaderText = "Check Bank";
            this.ColumnCheckBank.Name = "ColumnCheckBank";
            this.ColumnCheckBank.ReadOnly = true;
            this.ColumnCheckBank.Width = 150;
            // 
            // ColumnCreditCardVerificationCode
            // 
            this.ColumnCreditCardVerificationCode.DataPropertyName = "ColumnCreditCardVerificationCode";
            this.ColumnCreditCardVerificationCode.HeaderText = "Credit Card Verification Code";
            this.ColumnCreditCardVerificationCode.Name = "ColumnCreditCardVerificationCode";
            this.ColumnCreditCardVerificationCode.ReadOnly = true;
            this.ColumnCreditCardVerificationCode.Width = 280;
            // 
            // ColumnCreditCardNumber
            // 
            this.ColumnCreditCardNumber.DataPropertyName = "ColumnCreditCardNumber";
            this.ColumnCreditCardNumber.HeaderText = "Credit Card No.";
            this.ColumnCreditCardNumber.Name = "ColumnCreditCardNumber";
            this.ColumnCreditCardNumber.ReadOnly = true;
            this.ColumnCreditCardNumber.Width = 150;
            // 
            // ColumnCreditCardType
            // 
            this.ColumnCreditCardType.DataPropertyName = "ColumnCreditCardType";
            this.ColumnCreditCardType.HeaderText = "Credit Card Type";
            this.ColumnCreditCardType.Name = "ColumnCreditCardType";
            this.ColumnCreditCardType.ReadOnly = true;
            this.ColumnCreditCardType.Width = 150;
            // 
            // ColumnCreditCardBank
            // 
            this.ColumnCreditCardBank.DataPropertyName = "ColumnCreditCardBank";
            this.ColumnCreditCardBank.HeaderText = "CreditCard Bank";
            this.ColumnCreditCardBank.Name = "ColumnCreditCardBank";
            this.ColumnCreditCardBank.ReadOnly = true;
            this.ColumnCreditCardBank.Width = 150;
            // 
            // ColumnCreditCardReferenceNumber
            // 
            this.ColumnCreditCardReferenceNumber.DataPropertyName = "ColumnCreditCardReferenceNumber";
            this.ColumnCreditCardReferenceNumber.HeaderText = "Credit Card Reference No.";
            this.ColumnCreditCardReferenceNumber.Name = "ColumnCreditCardReferenceNumber";
            this.ColumnCreditCardReferenceNumber.ReadOnly = true;
            this.ColumnCreditCardReferenceNumber.Width = 250;
            // 
            // ColumnCreditCardHolderName
            // 
            this.ColumnCreditCardHolderName.DataPropertyName = "ColumnCreditCardHolderName";
            this.ColumnCreditCardHolderName.HeaderText = "Credit Card Holder Name";
            this.ColumnCreditCardHolderName.Name = "ColumnCreditCardHolderName";
            this.ColumnCreditCardHolderName.ReadOnly = true;
            this.ColumnCreditCardHolderName.Width = 250;
            // 
            // ColumnCreditCardExpiry
            // 
            this.ColumnCreditCardExpiry.DataPropertyName = "ColumnCreditCardExpiry";
            this.ColumnCreditCardExpiry.HeaderText = "Credit Card Expiry";
            this.ColumnCreditCardExpiry.Name = "ColumnCreditCardExpiry";
            this.ColumnCreditCardExpiry.ReadOnly = true;
            this.ColumnCreditCardExpiry.Width = 150;
            // 
            // ColumnGiftCertificateNumber
            // 
            this.ColumnGiftCertificateNumber.DataPropertyName = "ColumnGiftCertificateNumber";
            this.ColumnGiftCertificateNumber.HeaderText = "Gift Certificate No.";
            this.ColumnGiftCertificateNumber.Name = "ColumnGiftCertificateNumber";
            this.ColumnGiftCertificateNumber.ReadOnly = true;
            this.ColumnGiftCertificateNumber.Width = 150;
            // 
            // ColumnOtherInformation
            // 
            this.ColumnOtherInformation.DataPropertyName = "ColumnOtherInformation";
            this.ColumnOtherInformation.HeaderText = "Other Information";
            this.ColumnOtherInformation.Name = "ColumnOtherInformation";
            this.ColumnOtherInformation.ReadOnly = true;
            this.ColumnOtherInformation.Width = 150;
            // 
            // RepSalesReportCollectionDetailReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1482, 703);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RepSalesReportCollectionDetailReportForm";
            this.Text = "Collection Detail Report";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCollectionDetailReport)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxTotalAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPageListFirst;
        private System.Windows.Forms.DataGridView dataGridViewCollectionDetailReport;
        private System.Windows.Forms.Button buttonPageListNext;
        private System.Windows.Forms.Button buttonPageListPrevious;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonPageListLast;
        private System.Windows.Forms.TextBox textBoxPageNumber;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCollectionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCollectionNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTerminal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnManualORNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalesNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPayType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCheckNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCheckDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCheckBank;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCreditCardVerificationCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCreditCardNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCreditCardType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCreditCardBank;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCreditCardReferenceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCreditCardHolderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCreditCardExpiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGiftCertificateNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOtherInformation;
    }
}