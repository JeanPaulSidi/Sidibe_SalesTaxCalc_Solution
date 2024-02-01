using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sidibe_SalesTaxCalc_Project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public void DisplayDefaultView() 
        {
            txtPriceInput.Clear();
            cboWarrantyChoice.Text = "No Warranty";
            cboStateSoldChoice.Text = "WA";
            lblTotalCost.Text = string.Empty;
        }

        public decimal CalculateWarranteeCost() 
        {
            if (cboWarrantyChoice.Text == "One Year")
            {
                return 1000;
            }
            else if (cboWarrantyChoice.Text == "Two Years")
            {
                return 2000;
            }
            else if (cboWarrantyChoice.Text == "Three Years")
            {
                return 3000;
            }
            else 
            {
                return 0;
            }
        }

        public decimal CalculateTaxAmount(decimal BasePrice) 
        {
            if (cboStateSoldChoice.Text == "WA") 
            {
                return (decimal)(8.6 / 100) * BasePrice;
            }
            else 
            {
                return 0;
            }
        }

        private void txtPriceInput_TextChanged(object sender, EventArgs e)
        {
            btnCalculate.Enabled = txtPriceInput.Text.Length > 3;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal VehicleBasePrice;
            decimal TaxAmount;
            decimal WarranteeCost;
            decimal VehicleTotalCost;
            string UserInput;

            UserInput = txtPriceInput.Text;
            VehicleBasePrice = decimal.Parse(UserInput);

            TaxAmount = CalculateTaxAmount(VehicleBasePrice);
            WarranteeCost = CalculateWarranteeCost();

            VehicleTotalCost = VehicleBasePrice + TaxAmount + WarranteeCost;
            lblTotalCost.Text = "Total Vehicle Cost is :" + VehicleTotalCost.ToString("C");

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DisplayDefaultView();
            this.ActiveControl = txtPriceInput;
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DisplayDefaultView();
            btnCalculate.Enabled = false;
            
        }
    }
}
