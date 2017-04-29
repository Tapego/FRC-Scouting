using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scouting
{
    public partial class EventView : Form
    {
        public EventView frcEvent;
        public DataTable Rankings;
        public DataTable Matches;
        public EventView()
        {
            InitializeComponent();
        }

        private async void RequestTBA_click(object sender, EventArgs e)
        {
            try
            {
                await TBAHTTP.RequestTBA(Program.client, TBAHTTP.RequestType.EventRanking, Year.Text + EventCode.Text, this);
                await TBAHTTP.RequestTBA(Program.client, TBAHTTP.RequestType.Matches, Year.Text + EventCode.Text, this);
            }
            catch (Exception error)
            {
                MessageBox.Show("Hmmm, something went wrong. Check to see if the code is right for that year. Here's some technical stuff: \n" + error.Message) ;
            }
            dataGridView1.DataSource = Rankings;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int year = 1992; year <= DateTime.Now.Year; year++)
            {
                Year.Items.Add(year);
            }
            Year.SelectedIndex = Year.Items.Count-1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("That's okay, so am I. \nThe second box is for the 'event code', which can be found either on here (https://docs.google.com/spreadsheets/d/1HqsReMjr5uBuyZjqv14t6bQF2n038GfMmWi3B6vFGiA/edit#gid=0) or just by looking at the url of any regional/district (https://www.thebluealliance.com/event/2017ausc) <- ausc. \n \n I'll make it easier later. Later is a long time.");
        }

        private void Matchview_btn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Matches;
        }

        private void RankingView_btn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Rankings;
        }
    }
}
