using System.Data.SQLite;

namespace TutorSever
{
    internal class SqlHelper
    {
        private readonly string _dbPath;
        public SqlHelper(string dbPath)
        {
            _dbPath = dbPath;
            _sql.ConnectionString = $"Data Source={_dbPath};";
        }

        private readonly SQLiteConnection _sql = new SQLiteConnection();
        public void Commit(string command)
        {
            SQLiteCommand cmd = new SQLiteCommand(command, _sql);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
    }
}
