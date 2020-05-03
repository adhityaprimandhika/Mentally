namespace Mentally_DB_Library
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.SqlClient;
    using System.Data;

    public partial class AccountModel : DbContext
    {
        public AccountModel()
            : base("name=AccountModel")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<History> Histories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        SqlConnection connection = new SqlConnection(@"data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\account_db.mdf;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
        //MSSQLLocalDb itu adalah sql server local
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return connection;
        }

        public DataTable Read()
        {
            DataTable table = new DataTable();
            //Mengambil data dari database Account_DB di table History
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM History", connection);

            adapter.Fill(table);
            return table;
        }
    }
}
