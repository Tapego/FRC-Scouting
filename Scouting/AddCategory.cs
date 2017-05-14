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
    public partial class AddCategory : Form
    {
        EventView parentForm;
        public AddCategory(EventView form)
        {
            parentForm = form;
            InitializeComponent();

            RefreshTable();
        }

        void RefreshTable()
        {
            DataTable categories = new DataTable();

            categories.Columns.Add("Name");
            categories.Columns.Add("Type");

            foreach (DataColumn column in parentForm.scoutingView.Columns)
            {
                DataRow row = categories.NewRow();
                row["Name"] = column.ColumnName;
                row["Type"] = column.DataType;
                categories.Rows.Add(row);
            }

            Categories.DataSource = categories;
        }
        private void Add_btn_Click(object sender, EventArgs e)
        {
            Type type = null;
            switch(Type_combobox.Text)
            {
                case "Integer":
                    {
                        type = typeof(int);
                        break;
                    }
                case "Text":
                    {
                        type = typeof(string);
                        break;
                    }
                case "Double":
                    {
                        type = typeof(double);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            if (Name_txtbox.Text != "" && type != null)
            {
                Program.db.AddColumn(Name_txtbox.Text, type);
                RefreshTable();
            }
            if (Name_txtbox.Text == "")
            {
                MessageBox.Show("Please enter a name for the column.");
            } else if (type == null)
            {
                MessageBox.Show("Please select a type.");
                Console.Write(Type_combobox.Text);
            }
        }

        private void AddCategory_Load(object sender, EventArgs e)
        {

        }

        private void Remove_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Currently doesn't work. SQLite doesn't like removing columns. For now you may have to delete the whole table.");
            /*
            if (Categories.SelectedCells.Count > 0)
            {
                Program.db.RemoveColumn(Categories.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            }
            RefreshTable();
            */
        }
    }
}
