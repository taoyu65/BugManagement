using System;
using System.Collections.Generic;
using System.Text;

namespace BugManagement.Core.Tools
{
    internal static class SqlExceptionMessage
    {
        public static string GetSqlExceptionMessage(int number)
        {
            string msg = string.Empty;
            switch (number)
            {
                case 2:
                    msg = "Database connection timeout, please check the network connection or check the server side is connected";
                    break;
                case 17:
                    msg = "The server of SqlServer does not exist or deny the request.";
                    break;
                case 17142:
                    msg = "The server of SqlServer has been stopped.";
                    break;
                case 2812:
                    msg = "The stored procedure does not exist.";
                    break;
                case 208:
                    msg = "The table name does not exist.";
                    break;
                case 4060:
                    msg = "The connected database is invalid.";
                    break;
                case 18456:
                    msg = "Failed to login the database.";
                    break;
                case 547:
                    msg = "Foreign key constrain, cannot save the changes of data.";
                    break;
                case 2627:
                    msg = "Duplicated primary key, cannot insert data.";
                    break;
                case 2601:
                    msg = "Unknown error.";
                    break;
            }
            return msg;
        }
    }
}
