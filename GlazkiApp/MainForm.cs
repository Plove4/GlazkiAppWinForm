using GlazkiApp.Models;
using GlazkiApp.Views.PartialView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GlazkiApp.Utilities;

namespace GlazkiApp
{
    public partial class MainForm : Form
    {
        public static List<Agent> agents = new List<Agent>();
        public MainForm()
        {
            InitializeComponent();
            agents = DBContext.Context.Agent.ToList();
        }

        private void GenerateAgentCardList(List<Agent> agent)
        {
            foreach (var a in agent)
            {
                AgentCard card = new AgentCard();

                card.GenerateDataToAgentCard(a);
                flowLayoutPanel1.Controls.Add(card); 

                
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GenerateAgentCardList(agents);
        }
    }
}
