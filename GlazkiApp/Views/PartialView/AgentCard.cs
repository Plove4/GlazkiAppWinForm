using GlazkiApp.Models;
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
            IDlbl.Text = Convert.ToString(agent.ID);
            if (agent.Logo == "не указано" || agent.Logo == "отсутствует")
            {
                agent.Logo = string.Empty;
            }
            if (!string.IsNullOrEmpty(agent.Logo))
            {
                pictureBox1.ImageLocation = agent.Logo.Remove(0,1);
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
            presentLbl.Text = $"{agent.diskaunt}%";
            if (agent.diskaunt > 19)
            {
                presentLbl.BackColor = Color.LightGreen;
            }
        }

        private void AgentCard_Load(object sender, EventArgs e)
        {

        }
    }
}
