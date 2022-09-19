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
                qty += sale.ProductCount;
                sum += qty * sale.Product.MinCostForAgent;
            }

            qtyLbl.Text = qty + " Продаж за год";
        }

        private void AgentCard_Load(object sender, EventArgs e)
        {

        }
    }
}
