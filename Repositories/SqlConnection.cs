using System.Security;

namespace WPF_UI.Repositories
{
    public class SqlConnection
    {
        private SecureString connectionString;

        public SqlConnection(string _connectionString)
        {
        }

        public SqlConnection(SecureString connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}