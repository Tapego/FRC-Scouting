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
        public List<Match> Matches;
        public DataTable MatchesDataTable;
        public DataTable scoutingView;

        public EventView()
        {
            InitializeComponent();
            MatchesGridView.DataBindingComplete += GetWinner;
            RankingsGridView.DataBindingComplete += ChangeDecimals;

            RefreshScoutingTable();
            ScoutingView.DataError += ScoutingView_DataError;
        }

        private void ScoutingView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Incorrect datatype. ");
        }

        void RefreshScoutingTable()
        {
            scoutingView = Program.db.GetTable();

            ScoutingView.DataSource = scoutingView;
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
            RankingsGridView.DataSource = Rankings;
            MatchesGridView.DataSource = MatchesDataTable;
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
            MessageBox.Show("The second box is for the 'event code', which can be found either on here (https://docs.google.com/spreadsheets/d/1HqsReMjr5uBuyZjqv14t6bQF2n038GfMmWi3B6vFGiA/edit#gid=0) or just by looking at the url of any regional/district (https://www.thebluealliance.com/event/2017ausc) <- ausc. \n \n I'll make it easier later. Later is a long time.");
        }

        private void GetWinner(object sender, EventArgs e)
        {
            DataGridView view = sender as DataGridView;
            foreach(DataGridViewRow row in view.Rows)
            {
                int red = Convert.ToInt32(row.Cells["Red Score"].Value);
                int blue = Convert.ToInt32(row.Cells["Blue Score"].Value);
                DataGridViewCellStyle style = new DataGridViewCellStyle();
                style.Font = new Font(view.Font, FontStyle.Bold);
                if (blue > red)
                {
                    for (int i = 1; i <= 3; i++)
                    {
                        row.Cells["Blue " + i].Style = style;
                        row.Cells["Blue " + i].Style.BackColor = Color.LightSkyBlue;
                    }
                }
                else if (red > blue)
                {
                    for (int i = 1; i <= 3; i++)
                    {
                        row.Cells["Red " + i].Style = style;
                        row.Cells["Red " + i].Style.BackColor = Color.LightSalmon;
                    }
                }
                else
                    if (red == blue)
                {
                    for (int i = 1; i <= 3; i++)
                    {
                        row.Cells["Blue " + i].Style = style;
                        row.Cells["Blue " + i].Style.BackColor = Color.LightGray;
                        row.Cells["Red " + i].Style = style;
                        row.Cells["Red " + i].Style.BackColor = Color.LightGray;
                    }
                }
            }
        }
        private void ChangeDecimals(object sender, EventArgs e)
        {
            /*DataGridView view = sender as DataGridView;
            DataTable table = (DataTable)view.DataSource;
            foreach (DataRow row in table.Rows)
            {
                row[3] = double.Parse((string)row["Ranking Score"]).ToString("G2");
                //row["Ranking Score"].Value = cell;
            }*/
        }

        private void RankingsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Console.WriteLine(Rankings.Columns[e.ColumnIndex].DataType);
        }

        private void AddScoutingColumn_btn_Click(object sender, EventArgs e)
        {
            AddCategory category = new AddCategory(this);
            category.ShowDialog();
        }

        private void NewEntry_btn_Click(object sender, EventArgs e)
        {
            Program.db.NewEntry();
            RefreshScoutingTable();
        }

        private void ScoutingView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = ScoutingView.Rows[e.RowIndex];
            DataGridViewCell cell = row.Cells[e.ColumnIndex];
            if (row.Cells["EntryID"].Value.ToString() == "")
            {
                row.Cells["EntryID"].Value = Program.db.NewEntry();
            }
            if (row.Cells["EntryID"].Value.ToString() != "1")
            {
                if (cell.Value != null && cell.Value.ToString() != "")
                {
                    switch (cell.ValueType.ToString())
                    {
                        case "System.String":
                            {
                                Program.db.UpdateString(int.Parse(row.Cells["EntryID"].Value.ToString()), cell.OwningColumn.Name, cell.Value.ToString());
                                break;
                            }
                        case "System.Double":
                        case "System.Int32":
                        case "System.Int64":
                            {
                                Program.db.UpdateIntOrDouble(int.Parse(row.Cells["EntryID"].Value.ToString()), cell.OwningColumn.Name, cell.Value.ToString());
                                break;
                            }
                        default:
                            {
                                throw new ArgumentException("Unsupported type.");
                            }
                    }
                }
            }
            else
            {
                MessageBox.Show("Can't edit the weights row ID.");
            }
        }

        private void ScoutingView_NewRowNeeded(object sender, DataGridViewRowEventArgs e)
        {
            //e.Row.Cells["EntryID"].Value = Program.db.NewEntry();
        }

        private void ScoutingView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        { 
            if (e.Row.Cells["EntryID"].Value.ToString() != "1")
            {
                Program.db.DeleteEntry(int.Parse(e.Row.Cells["EntryID"].Value.ToString()));
            }
            else
            {
                MessageBox.Show("Can't delete the weights row.");
                e.Cancel = true;
            }
        }
        
    }
}
