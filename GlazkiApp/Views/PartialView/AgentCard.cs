﻿using GlazkiApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlazkiApp.Views.PartialView
{
    public partial class AgentCard : UserControl
    {
        public AgentCard()
        {
            InitializeComponent();
        }

        public void GenerateDataToAgentCard(Agent agent)
        {
            if (!string.IsNullOrEmpty(agent.Logo) || agent.Logo == "не указано")
            {
                pictureBox1.ImageLocation = agent.Logo.Remove(0,1);
            }
            else
            {
                pictureBox1.ImageLocation = agent.Logo;
            }    
            TypeNameLbl.Text = agent.AgentType.Title + " | " + agent.Title;
            int qty = 0;
            decimal sum = 0;
            foreach (ProductSale sale in agent.ProductSale)
            {
                if (sale.SaleDate.Year == 2019)
                {
                    qty += sale.ProductCount;
                }
                sum += qty * sale.Product.MinCostForAgent;
            }

            qtyLbl.Text = qty + " Продаж за год";
            phoneLbl.Text = agent.Phone;
            priotityValueLbl.Text = agent.Priority.ToString();

            if(sum < 10000)
            {
                presentLbl.Text = "0%";
            }    
            else if(sum >= 10000 && sum <= 50000)
            {
                presentLbl.Text = "5%";
            }
            else if (sum >= 50000 && sum <= 150000)
            {
                presentLbl.Text = "10%";
            }
            else if (sum >= 150000 && sum <= 500000)
            {
                presentLbl.Text = "20%";
            }
            else
            {
                presentLbl.Text = "25%";
            }
        }

        private void AgentCard_Load(object sender, EventArgs e)
        {

        }
    }
}
