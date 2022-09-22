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
        public Agent agent { get; set; } = null;
        public EditAgentForm(Agent agent)
        {
            InitializeComponent();
        }

        private void CancleButn_Click(object sender, EventArgs e)
        {
            Application.Restart();
            DialogResult = DialogResult.Cancel;
        }

        private void EditAgentForm_Load(object sender, EventArgs e)
        {
            agentTypeBindingSource.DataSource = DBContext.db.AgentType.ToList();
            foreach (AgentCard agentCard in MainForm.selectrdAgentCards)
            {
                Agent agent = DBContext.db.Agent.First(x => x.ID.ToString() == agentCard.IDlbl.Text);
                agentBindingSource.DataSource = agent;
                if (!string.IsNullOrEmpty(agent.Logo))
                {
                    LogoPicBox.ImageLocation = agent.Logo.Remove(0, 1);
                }
                else
                {
                    LogoPicBox.ImageLocation = null;
                }
            }
        }

        private void SaveButn_Click(object sender, EventArgs e)
        {
            agent = (Agent)agentBindingSource.Current;

            if (agent.ID == 0)
            {
                DBContext.db.Agent.Add(agent);
            }

            try
            {
                DBContext.db.SaveChanges();
                MessageBox.Show("Данные сохранены");
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void ChangeImageButn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "";
        }
    }
}
