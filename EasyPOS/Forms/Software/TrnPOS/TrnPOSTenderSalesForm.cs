﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPOS.Forms.Software.TrnPOS
{
    public partial class TrnPOSTenderSalesForm : Form
    {
        public TrnPOSBarcodeDetailForm trnSalesDetailForm;
        public TrnPOSTenderForm trnSalesDetailTenderForm;
        public Entities.TrnSalesEntity trnSalesEntity;

        public String customerName = "";

        public TrnPOSTenderSalesForm(TrnPOSBarcodeDetailForm salesDetailForm, TrnPOSTenderForm salesDetailTenderForm, Entities.TrnSalesEntity salesEntity)
        {
            InitializeComponent();

            trnSalesDetailForm = salesDetailForm;
            trnSalesDetailTenderForm = salesDetailTenderForm;
            trnSalesEntity = salesEntity;

            GetTermList();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void GetTermList()
        {
            Controllers.TrnSalesController trnPOSSalesController = new Controllers.TrnSalesController();
            if (trnPOSSalesController.TenderSalesDropdownListTerm().Any())
            {
                comboBoxTenderSalesTerms.DataSource = trnPOSSalesController.TenderSalesDropdownListTerm();
                comboBoxTenderSalesTerms.ValueMember = "Id";
                comboBoxTenderSalesTerms.DisplayMember = "Term";

                GetCustomerList();
            }
        }

        public void GetCustomerList()
        {
            Controllers.TrnSalesController trnPOSSalesController = new Controllers.TrnSalesController();
            if (trnPOSSalesController.TenderSalesDropdownListCustomer().Any())
            {
                comboBoxTenderSalesCustomer.DataSource = trnPOSSalesController.TenderSalesDropdownListCustomer();
                comboBoxTenderSalesCustomer.ValueMember = "Id";
                comboBoxTenderSalesCustomer.DisplayMember = "Customer";

                comboBoxTenderSalesCustomer.SelectedValue = trnSalesEntity.CustomerId;

                GetUserList();
            }
        }

        public void GetUserList()
        {
            Controllers.TrnSalesController trnPOSSalesController = new Controllers.TrnSalesController();
            if (trnPOSSalesController.TenderSalesDropdownListUser().Any())
            {
                comboBoxTenderSalesUsers.DataSource = trnPOSSalesController.TenderSalesDropdownListUser();
                comboBoxTenderSalesUsers.ValueMember = "Id";
                comboBoxTenderSalesUsers.DisplayMember = "FullName";

                var currentUserId = Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId;
                comboBoxTenderSalesUsers.SelectedValue = Convert.ToInt32(currentUserId);
            }
        }

        private void comboBoxTenderSalesCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTenderSalesCustomer.SelectedItem == null)
            {
                return;
            }

            var selectedItemCustomer = (Entities.MstCustomerEntity)comboBoxTenderSalesCustomer.SelectedItem;
            if (selectedItemCustomer != null)
            {
                customerName = selectedItemCustomer.Customer;
                textBoxTenderSalesRewardAvailable.Text = selectedItemCustomer.AvailableReward.ToString("#,##0.00");
                comboBoxTenderSalesTerms.SelectedValue = selectedItemCustomer.TermId;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Entities.TrnSalesEntity newSalesEntity = new Entities.TrnSalesEntity()
            {
                CustomerId = Convert.ToInt32(comboBoxTenderSalesCustomer.SelectedValue),
                TermId = Convert.ToInt32(comboBoxTenderSalesTerms.SelectedValue),
                Remarks = textBoxTenderSalesRemarks.Text,
                SalesAgent = Convert.ToInt32(comboBoxTenderSalesUsers.SelectedValue)
            };

            Controllers.TrnSalesController trnPOSSalesController = new Controllers.TrnSalesController();
            String[] updateSales = trnPOSSalesController.TenderUpdateSales(trnSalesEntity.Id, newSalesEntity);
            if (updateSales[1].Equals("0") == false)
            {
                if (trnSalesDetailForm != null)
                {
                    trnSalesDetailTenderForm.trnSalesEntity.Customer = customerName;
                    trnSalesDetailTenderForm.GetSalesDetail();

                    trnSalesDetailForm.trnSalesEntity.Customer = customerName;
                    trnSalesDetailForm.GetSalesDetail();
                }
                else
                {
                    trnSalesDetailTenderForm.trnSalesEntity.Customer = customerName;
                    trnSalesDetailTenderForm.GetSalesDetail();
                }

                Close();
            }
            else
            {
                MessageBox.Show(updateSales[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxCustomerCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                List<Entities.MstCustomerEntity> customers = (List<Entities.MstCustomerEntity>)comboBoxTenderSalesCustomer.DataSource;
                var customer = from d in customers
                               where d.CustomerCode == textBoxCustomerCode.Text
                               select d;

                if (customer.Any())
                {
                    comboBoxTenderSalesCustomer.SelectedValue = customer.FirstOrDefault().Id;
                }
                else
                {
                    MessageBox.Show("Invalid customer code.", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}