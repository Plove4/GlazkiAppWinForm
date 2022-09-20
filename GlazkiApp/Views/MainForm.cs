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
using GlazkiApp.Views;

namespace GlazkiApp
{
    public partial class MainForm : Form
    {
        public static List<Agent> agents = new List<Agent>();
        public static List<AgentCard> selectrdAgentCards = new List<AgentCard>();
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

                card.DoubleClick += new System.EventHandler(this.Card_doubleClick);
            }
        }

        private void Card_doubleClick(object sender, EventArgs e)
        {
            AgentCard card = sender as AgentCard;
            selectrdAgentCards.Add(card);
            EditAgentForm editAgent = new EditAgentForm();
            DialogResult result = editAgent.ShowDialog();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GenerateAgentCardList(agents);
            var allTipe = DBContext.Context.AgentType.Select(Type => Type.Title).ToList();
            allTipe.Insert(0, "Все типы");
            FiltrTypeComboBox.DataSource = allTipe;
            FiltrTypeComboBox.SelectedIndex = 0;
            SortComboBox.SelectedIndex = 0;

        }

        private void SortListView()
        {
            flowLayoutPanel1.Controls.Clear();
            var listUpdate = DBContext.Context.Agent.ToList();

            if(!string.IsNullOrEmpty(SearchBox.Text) && SearchBox.Text != "Введите текст")
            {
                listUpdate = listUpdate
                    .Where(p => p.Title.ToLower().Contains(SearchBox.Text.ToLower())
                    || p.Phone.Contains(SearchBox.Text)
                    || p.Email.ToLower().Contains(SearchBox.Text.ToLower()))
                    .ToList();
            }

            if(FiltrTypeComboBox.SelectedIndex > 0)
            {
                listUpdate = listUpdate
                    .Where(p => p.AgentType.Title == FiltrTypeComboBox.SelectedItem.ToString())
                    .ToList();
            }

            switch (SortComboBox.Text)
            {
                case "Наименование":
                    if (!checkBox1.Checked)
                        listUpdate = listUpdate.OrderBy(p => p.Title).ToList();
                    else
                        listUpdate = listUpdate.OrderByDescending(p => p.Title).ToList();
                break;
                case "Приоритет":
                    if(!checkBox1.Checked)
                        listUpdate= listUpdate.OrderBy(p => p.Priority).ToList();
                    else
                        listUpdate= listUpdate.OrderByDescending(p => p.Priority).ToList();
                    break;
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

        private void SearchBox_Enter(object sender, EventArgs e)
        {
            if (SearchBox.Text == "Введите текст")
                SearchBox.Text = "";

            SearchBox.ForeColor = Color.Black;
        }

        private void SearchBox_Leave(object sender, EventArgs e)
        {
            if (SearchBox.Text == "")
                SearchBox.Text = "Введите текст";
            if (string.IsNullOrEmpty(SearchBox.Text) || SearchBox.Text == "Введите текст")
                SearchBox.ForeColor = Color.Silver;
        }
    }
}
