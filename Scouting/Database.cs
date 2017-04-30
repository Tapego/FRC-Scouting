using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data;

namespace Scouting
{
    class Database
    {
        private string _db_file;
        private bool _is_open = false;
        private SQLiteConnection _conn;

        public Database(string db_file)
        {
            _db_file = ".scouting/" + db_file + ".db";
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
                DataTable table = new DataTable();
                SQLiteDataAdapter adp = new SQLiteDataAdapter(r);
                adp.Fill(table);
                return (table);
            }
        }

    }
}
