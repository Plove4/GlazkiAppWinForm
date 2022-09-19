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

        private void SearchBox_Click(object sender, EventArgs e)
        {
            SearchBox.Text = "";
        }

        private void SortListView()
        {
            flowLayoutPanel1.Controls.Clear();
            var listUpdate = DBContext.Context.Agent.ToList();

            if(!string.IsNullOrEmpty(SearchBox.Text) && SearchBox.Text != "Введите для поиска")
            {
                listUpdate = listUpdate
                    .Where(p => p.Title.ToLower().Contains(SearchBox.Text.ToLower())
                    || p.Phone.Contains(SearchBox.Text)
                    || p.Email.ToLower().Contains(SearchBox.Text.ToLower()))
                    .ToList();
            }

            GenerateAgentCardList(listUpdate);
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            SortListView();
        }

        private void FiltrTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortListView();
        }

        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortListView();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SortListView();
        }
    }
}
