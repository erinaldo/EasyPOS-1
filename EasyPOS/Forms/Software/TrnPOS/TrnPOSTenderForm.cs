﻿using OpenCvSharp.CPlusPlus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPOS.Forms.Software.TrnPOS
{
    public partial class TrnPOSTenderForm : Form
    {
        public SysSoftwareForm sysSoftwareForm;

        public TrnPOSBarcodeForm trnSalesListForm;
        public TrnPOSBarcodeDetailForm trnSalesDetailForm;

        public TrnPOSTouchForm trnPOSTouchForm;
        public TrnPOSTouchDetailForm trnPOSTouchDetailForm;

        public Entities.TrnSalesEntity trnSalesEntity;
        public String collectionNumber = "";

        public TrnPOSTenderForm(SysSoftwareForm softwareForm, TrnPOSBarcodeForm salesListForm, TrnPOSBarcodeDetailForm salesDetailForm, TrnPOSTouchForm POSTouchForm, TrnPOSTouchDetailForm POSTouchDetailForm, Entities.TrnSalesEntity salesEntity)
        {
            InitializeComponent();

            sysSoftwareForm = softwareForm;

            trnSalesListForm = salesListForm;
            trnSalesDetailForm = salesDetailForm;

            trnPOSTouchForm = POSTouchForm;
            trnPOSTouchDetailForm = POSTouchDetailForm;

            trnSalesEntity = salesEntity;

            GetSalesDetail();
        }

        public void GetSalesDetail()
        {
            textBoxTotalSalesAmount.Text = trnSalesEntity.Amount.ToString("#,##0.00");
            labelInvoiceNumber.Text = trnSalesEntity.SalesNumber;
            labelInvoiceDate.Text = trnSalesEntity.SalesDate;
            labelCustomer.Text = trnSalesEntity.Customer;

            GetPayTypeList();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonTender_Click(object sender, EventArgs e)
        {
            TenderSales();
        }

        public void TenderSales()
        {
            if (Convert.ToDecimal(textBoxChangeAmount.Text) < 0)
            {
                buttonTender.Enabled = false;
                //MessageBox.Show("Change amount must be non-negative value.", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<Entities.DgvTrnSalesTenderPayTypeListEntity> payTypes = new List<Entities.DgvTrnSalesTenderPayTypeListEntity>();
                foreach (DataGridViewRow row in dataGridViewTenderPayType.Rows)
                {
                    payTypes.Add(new Entities.DgvTrnSalesTenderPayTypeListEntity()
                    {
                        Code = row.Cells[1].Value.ToString(),
                        PayType = row.Cells[2].Value.ToString(),
                        Amount = Convert.ToDecimal(row.Cells[4].Value),
                        OtherInformation = row.Cells[5].Value.ToString()
                    });
                }

                Decimal salesAmount = Convert.ToDecimal(textBoxTotalSalesAmount.Text);
                Decimal cashAmount = 0;
                Decimal nonCashAmount = 0;
                Decimal changeAmount = Convert.ToDecimal(textBoxChangeAmount.Text);

                var cashPayType = from d in payTypes where d.Code.Equals("Cash") == true select d;
                if (cashPayType.Any())
                {
                    cashAmount = cashPayType.FirstOrDefault().Amount;
                }

                var nonCashPayType = from d in payTypes where d.Code.Equals("Cash") == false select d;
                if (nonCashPayType.Any())
                {
                    nonCashAmount = nonCashPayType.Sum(d => d.Amount);
                }

                Boolean isValidTender = false;
                String invalidTenderMessage = "";

                if (cashAmount > 0)
                {
                    if (cashAmount >= changeAmount)
                    {
                        isValidTender = true;
                    }
                    else
                    {
                        invalidTenderMessage = "Cash amount must be greater than the change amount.";
                    }
                }
                else
                {
                    if (cashAmount == 0)
                    {
                        if (nonCashAmount == salesAmount)
                        {
                            isValidTender = true;
                        }
                        else
                        {
                            invalidTenderMessage = "Non-cash amount must be equal to the sales amount.";
                        }
                    }
                    else
                    {
                        invalidTenderMessage = "Cash amount must not below zero.";
                    }
                }

                if (isValidTender == true)
                {
                    buttonTender.Enabled = true;
                    CreateCollection(null);
                }
                else
                {
                    buttonTender.Enabled = false;
                    //MessageBox.Show(invalidTenderMessage, "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void CreateCollection(Image facepayCapturedImage)
        {
            List<Entities.TrnCollectionLineEntity> listCollectionLine = new List<Entities.TrnCollectionLineEntity>();
            if (dataGridViewTenderPayType.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewTenderPayType.Rows)
                {
                    if (Convert.ToDecimal(row.Cells[4].Value) > 0)
                    {
                        listCollectionLine.Add(new Entities.TrnCollectionLineEntity()
                        {
                            Amount = Convert.ToDecimal(row.Cells[4].Value),
                            PayTypeId = Convert.ToInt32(row.Cells[0].Value),
                            CheckNumber = "NA",
                            CheckDate = null,
                            CheckBank = "NA",
                            CreditCardVerificationCode = "NA",
                            CreditCardNumber = "NA",
                            CreditCardType = "NA",
                            CreditCardBank = "NA",
                            GiftCertificateNumber = "NA",
                            OtherInformation = row.Cells[4].Value.ToString(),
                            CreditCardReferenceNumber = "NA",
                            CreditCardHolderName = "NA",
                            CreditCardExpiry = "NA"
                        });
                    }
                }
            }

            if (listCollectionLine.Any())
            {
                Entities.TrnCollectionEntity newCollection = new Entities.TrnCollectionEntity()
                {
                    TenderAmount = Convert.ToDecimal(textBoxTenderAmount.Text),
                    ChangeAmount = Convert.ToDecimal(textBoxChangeAmount.Text),
                    CollectionLines = listCollectionLine
                };

                Controllers.TrnSalesController trnPOSSalesController = new Controllers.TrnSalesController();
                String[] tenderSales = trnPOSSalesController.TenderSales(trnSalesEntity.Id, newCollection);
                if (tenderSales[1].Equals("0") == false)
                {
                    if (Modules.SysCurrentModule.GetCurrentSettings().IsTenderPrint == "True")
                    {
                        DialogResult tenderPrinterReadyDialogResult = MessageBox.Show("Is printer ready?", "Easy POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (tenderPrinterReadyDialogResult == DialogResult.Yes)
                        {
                            if (Modules.SysCurrentModule.GetCurrentSettings().CollectionReport == "Official Receipt")
                            {
                                new TrnPOSOfficialReceiptReportForm(trnSalesEntity.Id, Convert.ToInt32(tenderSales[1]), false, "");
                            }
                            else if (Modules.SysCurrentModule.GetCurrentSettings().CollectionReport == "Delivery Receipt")
                            {
                                //new Reports.RepDeliveryReceiptReportForm(trnSalesEntity.Id, Convert.ToInt32(tenderSales[1]), false, "");

                                new TrnPOSDeliveryReceiptReportForm("", StockWithdrawalReport(trnSalesEntity.Id), true, true);
                                //MessageBox.Show("Generate PDF Successful!", "Generate CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {

                            }
                        }
                    }

                    if (facepayCapturedImage != null)
                    {
                        SaveImageCaptured(facepayCapturedImage);
                    }
                    else
                    {
                        Close();
                    }

                    if (trnSalesDetailForm != null)
                    {
                        trnSalesDetailForm.Close();
                        sysSoftwareForm.RemoveTabPage();

                        if (trnSalesListForm != null)
                        {
                            trnSalesDetailForm.trnSalesListForm.newSales();
                        }
                    }
                    else
                    {
                        if (trnSalesListForm != null)
                        {
                            trnSalesListForm.UpdateSalesListGridDataSource();
                        }
                    }

                    if (trnPOSTouchDetailForm != null)
                    {
                        trnPOSTouchDetailForm.Close();
                        sysSoftwareForm.RemoveTabPage();

                        if (trnPOSTouchForm != null)
                        {
                            trnPOSTouchForm.NewWalkInSales();
                        }
                    }
                    else
                    {
                        if (trnPOSTouchForm != null)
                        {
                            bool isPOSTouchActivityFormOpen = false;

                            FormCollection fc = Application.OpenForms;
                            foreach (Form frm in fc)
                            {
                                if (frm.Name == "TrnPOSTouchActivityForm")
                                {
                                    isPOSTouchActivityFormOpen = true;
                                }
                            }

                            if (isPOSTouchActivityFormOpen == true)
                            {
                                trnPOSTouchForm.ClosePOSTouchActivity();
                            }

                            trnPOSTouchForm.UpdateSalesListGridDataSource();
                        }
                    }
                }
                else
                {
                    MessageBox.Show(tenderSales[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Cannot tender zero amount.", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===============================================
        // Stock Withdrawal Report (Copied) To be modified
        // ===============================================
        public List<Entities.RepSalesReportTrnCollectionEntity> StockWithdrawalReport(Int32 salesId)
        {
            Data.easyposdbDataContext db = new Data.easyposdbDataContext(Modules.SysConnectionStringModule.GetConnectionString());

            var stockWithdrawalReports = from d in db.TrnCollections
                                         where d.SalesId == salesId
                                         select new Entities.RepSalesReportTrnCollectionEntity
                                         {
                                             Id = d.Id,
                                             SalesId = d.SalesId,
                                             CollectionNumber = d.CollectionNumber
                                         };

            return stockWithdrawalReports.ToList();
        }

        public void SaveImageCaptured(Image facepayCapturedImage)
        {
            try
            {
                Controllers.TrnSalesController trnPOSSalesController = new Controllers.TrnSalesController();
                Entities.TrnSalesEntity salesEntity = trnPOSSalesController.DetailSales(trnSalesEntity.Id);

                if (salesEntity != null && String.IsNullOrEmpty(salesEntity.CollectionNumber) == false)
                {
                    String imageName = salesEntity.CollectionNumber;
                    String facepayImagePath = Modules.SysCurrentModule.GetCurrentSettings().FacepayImagePath;

                    if (Directory.Exists(facepayImagePath) == false)
                    {
                        Directory.CreateDirectory(facepayImagePath);
                    }

                    facepayCapturedImage.Save(facepayImagePath + "\\" + imageName + ".jpeg", ImageFormat.Jpeg);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GetPayTypeList()
        {
            dataGridViewTenderPayType.Rows.Clear();
            dataGridViewTenderPayType.Refresh();

            Controllers.TrnSalesController trnPOSSalesController = new Controllers.TrnSalesController();

            var payTypeList = trnPOSSalesController.TenderListPayType();
            if (payTypeList.Any())
            {
                dataGridViewTenderPayType.Columns[2].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#7FBC00");
                dataGridViewTenderPayType.Columns[2].DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#7FBC00");
                dataGridViewTenderPayType.Columns[2].DefaultCellStyle.ForeColor = Color.White;

                dataGridViewTenderPayType.Columns[3].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#01A6F0");
                dataGridViewTenderPayType.Columns[3].DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#01A6F0");
                dataGridViewTenderPayType.Columns[3].DefaultCellStyle.ForeColor = Color.White;

                foreach (var objPayTypeList in payTypeList)
                {
                    dataGridViewTenderPayType.Rows.Add(
                        objPayTypeList.Id,
                        objPayTypeList.PayTypeCode,
                        objPayTypeList.PayType,
                        "#",
                        "0.00",
                        ""
                    );
                }
            }

            dataGridViewTenderPayType.Rows[0].Cells[4].Selected = true;
            ComputeAmount();
        }

        private void dataGridViewTenderPayType_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && dataGridViewTenderPayType.CurrentCell.ColumnIndex == dataGridViewTenderPayType.Columns["ColumnTenderListPayTypeAmount"].Index)
                {
                    Decimal amount = Convert.ToDecimal(dataGridViewTenderPayType.CurrentCell.Value);
                    dataGridViewTenderPayType.CurrentCell.Value = amount.ToString("#,##0.00");
                }

                ComputeAmount();
                TenderSales();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridViewTenderPayType.CurrentCell.Value = "0.00";
            }
        }

        public void ComputeAmount()
        {
            Decimal totalTenderAmount = 0;

            if (dataGridViewTenderPayType.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewTenderPayType.Rows)
                {
                    totalTenderAmount += Convert.ToDecimal(row.Cells[4].Value);
                }
            }

            textBoxTenderAmount.Text = totalTenderAmount.ToString("#,##0.00");

            Decimal changeAmount = totalTenderAmount - Convert.ToDecimal(textBoxTotalSalesAmount.Text);
            textBoxChangeAmount.Text = changeAmount.ToString("#,##0.00");
        }

        private void buttonSales_Click(object sender, EventArgs e)
        {
            TrnPOSTenderSalesForm trnSalesDetailTenderSalesForm = new TrnPOSTenderSalesForm(trnSalesDetailForm, this, trnSalesEntity);
            trnSalesDetailTenderSalesForm.ShowDialog();
        }

        private void dataGridViewTenderPayType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && dataGridViewTenderPayType.CurrentCell.ColumnIndex == dataGridViewTenderPayType.Columns["ColumnTenderListPayTypePayType"].Index)
            {
                String payTypeCode = dataGridViewTenderPayType.Rows[dataGridViewTenderPayType.CurrentCell.RowIndex].Cells[dataGridViewTenderPayType.Columns["ColumnTenderListPayTypePayTypeCode"].Index].Value.ToString();
                if (payTypeCode == "EASYPAY")
                {
                    Decimal totalTenderAmount = 0;

                    if (dataGridViewTenderPayType.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow row in dataGridViewTenderPayType.Rows)
                        {
                            totalTenderAmount += Convert.ToDecimal(row.Cells[4].Value);
                        }
                    }

                    Decimal easypayAmount = trnSalesEntity.Amount - totalTenderAmount;

                    TrnPOSTenderEasypayInformationForm trnSalesDetailTenderEasypayInformationForm = new TrnPOSTenderEasypayInformationForm(this, dataGridViewTenderPayType, easypayAmount);
                    trnSalesDetailTenderEasypayInformationForm.ShowDialog();
                }
                else if (payTypeCode == "FACEPAY")
                {
                    Decimal totalTenderAmount = 0;

                    if (dataGridViewTenderPayType.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow row in dataGridViewTenderPayType.Rows)
                        {
                            totalTenderAmount += Convert.ToDecimal(row.Cells[4].Value);
                        }
                    }

                    Decimal facepayAmount = trnSalesEntity.Amount - totalTenderAmount;

                    TrnPOSTenderFacepayCameraForm trnSalesDetailTenderFacepayCameraForm = new TrnPOSTenderFacepayCameraForm(this, dataGridViewTenderPayType, facepayAmount);
                    trnSalesDetailTenderFacepayCameraForm.ShowDialog();
                }
                else if (payTypeCode == "CHARGE")
                {
                    dataGridViewTenderPayType.CurrentRow.Cells[4].Value = trnSalesEntity.Amount.ToString("#,##0.00");
                    ComputeAmount();
                }
                else
                {
                    TrnPOSTenderMoreInformationForm trnSalesDetailTenderMoreInfoForm = new TrnPOSTenderMoreInformationForm(this, dataGridViewTenderPayType);
                    trnSalesDetailTenderMoreInfoForm.ShowDialog();
                }
            }

            if (e.RowIndex > -1 && dataGridViewTenderPayType.CurrentCell.ColumnIndex == dataGridViewTenderPayType.Columns["ColumnTenderListNumpad"].Index)
            {
                SysKeyboard.SysNumpadForm sysKeyboardNumpadForm = new SysKeyboard.SysNumpadForm(this, dataGridViewTenderPayType);
                sysKeyboardNumpadForm.ShowDialog();
            }
        }

        private void TrnSalesDetailTenderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Modules.SysSerialPortModule.CloseSerialPort();
        }
    }
}