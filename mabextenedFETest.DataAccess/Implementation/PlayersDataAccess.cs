using MySql.Data.MySqlClient;
using mabextendedFETest.Model;
using mabextenedFETest.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using mabextendedFETest.Utility;

namespace mabextenedFETest.DataAccess.Implementation
{
    public class PlayersDataAccess : IPlayersDataAccess
    {
        private MySqlDatabase MySqlDatabase { get; set; }

        public PlayersDataAccess(MySqlDatabase mySqlDatabase)
        {
            MySqlDatabase = mySqlDatabase;
        }

        public long AddPlayers(PlayersModel model)
        {
            throw new NotImplementedException();
        }

        public bool DeletePlayers(int playerid)
        {
            throw new NotImplementedException();
        }

        public List<PlayersModel> GetAllPlayers(int page, int itemsPerPage)
        {
            var ret = new List<PlayersModel>();
            int offset = (page - 1) * itemsPerPage;
            var cmd = this.MySqlDatabase.Connection.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"SELECT  t.* FROM players t  LIMIT @Offset, @ItemsPerPage";
            cmd.Parameters.AddWithValue("@Offset", offset);
            cmd.Parameters.AddWithValue("@ItemsPerPage", itemsPerPage);
            using (var reader = cmd.ExecuteReader())
                while (reader.Read())
                {
                    var t = new PlayersModel()
                    {
                        playerid = reader.GetValue<Int32>("playerid"),
                        name = reader.GetValue<String>("name"),
                    };

                    ret.Add(t);
                }
            return ret;

        }

        public int GetAllTotalRecordPlayers()
        {
            var cmd = this.MySqlDatabase.Connection.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"SELECT count(*) as TotalRecord FROM players t";
            using (var reader = cmd.ExecuteReader())
                while (reader.Read())
                {
                    return reader.GetInt32("TotalRecord");
                }
            return 0;
        }

        public PlayersModel GetPlayersByID(int playerid)
        {
            var cmd = this.MySqlDatabase.Connection.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"SELECT  t.* FROM players t  WHERE t.playerid= @playerid LIMIT 0,1";
            cmd.Parameters.AddWithValue("@playerid", playerid);

            using (var reader = cmd.ExecuteReader())
                while (reader.Read())
                {
                    return new PlayersModel()
                    {
                        playerid = reader.GetValue<Int32>("playerid"),
                        name = reader.GetValue<String>("name"),
                    };
                }
            return null;
        }

        public int GetSearchTotalRecordPlayers(string searchKey)
        {
            throw new NotImplementedException();
        }

        public List<PlayersModel> SearchPlayers(string searchKey, int page = 1, int itemsPerPage = 100)
        {
            var ret = new List<PlayersModel>();
            int offset = (page - 1) * itemsPerPage;
            var cmd = this.MySqlDatabase.Connection.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"SELECT  t.* FROM players t  WHERE  t.name LIKE CONCAT('%',@SearchKey,'%') LIMIT @Offset, @ItemsPerPage";
            cmd.Parameters.AddWithValue("@SearchKey", searchKey);
            cmd.Parameters.AddWithValue("@Offset", offset);
            cmd.Parameters.AddWithValue("@ItemsPerPage", itemsPerPage);
            using (var reader = cmd.ExecuteReader())
                while (reader.Read())
                {
                    var t = new PlayersModel()
                    {
                        playerid = reader.GetValue<Int32>("playerid"),
                        name = reader.GetValue<String>("name"),
                    };

                    ret.Add(t);
                }
            return ret;
        }

        public bool UpdatePlayers(PlayersModel model)
        {
            throw new NotImplementedException();
        }
    }
}
