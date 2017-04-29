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
    public partial class Form1 : Form
    {
        public Event frcEvent;
        public DataTable Rankings;
        public Form1()
        {
            InitializeComponent();
        }

        private async void RequestTBA_click(object sender, EventArgs e)
        {
            try
            {
                await TBAHTTP.RequestTBA(Program.client, TBAHTTP.RequestType.EventRanking, Year.Text + EventCode.Text, this);
            }
            catch
            {
                
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
    }
}
