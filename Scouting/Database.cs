using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data;
using System.Windows.Forms;

namespace Scouting
{
    class Database
    {
        private string _db_file;
        private bool _is_open = false;
        private SQLiteConnection _conn;

        public Database(string db_file)
        {
            _db_file = ".scoutingsheet/" + db_file + ".db";
        }

        public void Open()
        {
            _is_open = true;
            if (!File.Exists(_db_file))
            {
                if (!Directory.Exists(".scoutingsheet")) Directory.CreateDirectory(".scoutingsheet");
                SQLiteConnection.CreateFile(_db_file);
            }
            _conn = new SQLiteConnection("Data Source=" + _db_file);
            _conn.Open();
        }

        public void Close()
        {
            if (_is_open) _conn.Close();
            _is_open = false;
        }

        private SQLiteCommand FileCommand(string file, params object[] data)
        {
            return Command(EmbeddedResources.sql(file), data);
        }

        private SQLiteCommand Command(string cmd, params object[] data)
        {
            SQLiteCommand c = new SQLiteCommand(cmd, _conn);
            for (int i = 0; i < data.Length; i++)
            {
                c.Parameters.AddWithValue(i.ToString(), data[i]);
            }
            return c;
        }

        public void InitializeTables()
        {
            FileCommand("create").ExecuteNonQuery();
        }

        public DataTable GetSheetCategories()
        {
            using (var r = Command("PRAGMA table_info(Scouting);"))
            {
                DataTable table = new DataTable(), filtered = new DataTable();
                SQLiteDataAdapter adp = new SQLiteDataAdapter(r);
                adp.Fill(table);
                foreach (DataRow row in table.Rows)
                {
                    switch (row["type"].ToString())
                    {
                        case "INTEGER":
                        case "INT":
                            {
                                filtered.Columns.Add(row["name"].ToString(), typeof(int));
                                break;
                            }

                        case "TEXT":
                            {
                                filtered.Columns.Add(row["name"].ToString(), typeof(string));
                                break;
                            }
                        case "DOUBLE PRECISION":
                            {
                                filtered.Columns.Add(row["name"].ToString(), typeof(double));
                                break;
                            }
                    }
                }
                return (filtered);
            }
        }

        public DataTable GetTable()
        {
            DataTable table = new DataTable();
            using (var r = Command("SELECT * FROM Scouting").ExecuteReader())
            {
                table.Load(r);
                return table;
            }
        }

        public void UpdateIntOrDouble(int id, string column, string value)
        {
            string commandString = "UPDATE Scouting SET " + column + " = " + value + " WHERE EntryID = " + id + ";";
            var r = Command(commandString).ExecuteNonQuery();
            Console.WriteLine(commandString);

        }

        public void UpdateString(int id, string column, string value)
        {
            string commandString = "UPDATE Scouting SET " + column + " = '" + value + "' WHERE EntryID = " + id + ";";
            var r = Command(commandString).ExecuteNonQuery();
            Console.WriteLine(commandString);

        }

        public long NewEntry()
        {
            var r = FileCommand("insert.newentry").ExecuteReader();
            r.Read();
            return r.GetInt64(0);
        }

        public void AddColumn(string name, Type type)
        {
            string commandString = "ALTER TABLE Scouting ADD " + name + " ";
            switch (type.ToString())
            {
                case "System.String":
                    {
                        commandString += "TEXT;";
                        break;
                    }
                case "System.Double":
                    {
                        commandString += "DOUBLE PRECISION;";
                        break;
                    }
                case "System.Int32":
                    {
                        commandString += "INTEGER;";
                        break;
                    }
                default:
                    {
                        throw new ArgumentException("Unsupported type.");
                    }
            }
            try
            {
                var r = Command(commandString).ExecuteNonQuery();
            }
            catch (SQLiteException exception)
            {
                if (exception.ErrorCode == 1)
                {
                    Console.WriteLine("Column already exists in SQLite Table");
                }
            }
        }

        public void RemoveColumn(string name)
        {
            string commandString = "ALTER TABLE Scouting DROP COLUMN " + name + ";";
            try
            {
                Command(commandString).ExecuteNonQuery();
            }
            catch (SQLiteException exception)
            {
                if (exception.ErrorCode == 1)
                {
                    Console.WriteLine("Need to find an alternative that actually works here.");
                }
            }
        }

        internal void DeleteEntry(int EntryID)
        {
            string commandString = "DELETE FROM Scouting WHERE EntryID = " + EntryID + ";";
            Command(commandString).ExecuteNonQuery();
        }
    }
}
