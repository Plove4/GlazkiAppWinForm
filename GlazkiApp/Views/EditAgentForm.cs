using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GlazkiApp.Models;
using GlazkiApp.Utilities;
using GlazkiApp.Views;
using GlazkiApp.Views.PartialView;

namespace GlazkiApp.Views
{
    public partial class EditAgentForm : Form
    {
        public Agent Agent { get; set; } = null;
        public EditAgentForm()
        {
            InitializeComponent();
        }

        private void CancleButn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void EditAgentForm_Load(object sender, EventArgs e)
        {
            foreach  (AgentCard agentCard in MainForm.selectrdAgentCards)
            {
                Agent agent = DBContext.Context.Agent.First(x => x.Phone == agentCard.phoneLbl.Text) as Agent;
                agentBindingSource.DataSource = agent;
                logoPictureBox.ImageLocation = agent.Logo;
            }
            agentTypeBindingSource.DataSource = DBContext.Context.AgentType.ToList();
            //ComboxTypeAgent.DataSource = DBContext.Context.AgentType.ToList();
        }
    }
}
