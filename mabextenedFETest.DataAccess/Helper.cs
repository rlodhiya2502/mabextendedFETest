using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace mabextenedFETest.DataAccess
{
    public static class Helper
    {
        public static int GetColumnOrder(MySqlDataReader reader, string name)
        {
            int columnOrdinal = reader.GetOrdinal(name);
            return columnOrdinal;
        }
        public static T GetValue<T>(this MySqlDataReader sqlDataReader, string columnName)
        {
            var value = sqlDataReader[columnName];

            return value == System.DBNull.Value ? default(T) : (T)value;
        }

    }
}
