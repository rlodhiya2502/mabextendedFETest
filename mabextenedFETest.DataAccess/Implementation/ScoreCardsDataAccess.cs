using mabextendedFETest.Model;
using mabextendedFETest.Utility;
using mabextenedFETest.DataAccess.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace mabextenedFETest.DataAccess.Implementation
{
    public class ScoreCardsDataAccess : IScoreCardsDataAccess
    {
        private MySqlDatabase MySqlDatabase { get; set; }

        public ScoreCardsDataAccess(MySqlDatabase mySqlDatabase)
        {
            MySqlDatabase = mySqlDatabase;
        }

        public List<ScoreCardsModel> SearchScoreCards(string searchKey, int page = 1, int itemsPerPage = 10)
        {
            var ret = new List<ScoreCardsModel>();
            int offset = (page - 1) * itemsPerPage;
            var cmd = this.MySqlDatabase.Connection.CreateCommand() as MySqlCommand;
            //TODO: Verify CommandText with various inputs. 
            cmd.CommandText = @"SELECT games.playerid as playerid, players.name, SUM(games.score) as totalscore, COUNT(*) as gamesplayed  FROM games INNER JOIN players ON players.playerid = games.playerid WHERE players.name like CONCAT('%',@SearchKey, '%') GROUP BY games.playerid ORDER BY `score` DESC LIMIT @Offset, @ItemsPerPage";
            cmd.Parameters.AddWithValue("@SearchKey", searchKey);
            cmd.Parameters.AddWithValue("@Offset", offset);
            cmd.Parameters.AddWithValue("@ItemsPerPage", itemsPerPage);
            using (var reader = cmd.ExecuteReader())
                while (reader.Read())
                {
                    var t = new ScoreCardsModel()
                    {
                        playerid = reader.GetValue<Int32>("playerid"),
                        name = reader.GetValue<String>("name"),
                        totalscore = (int)reader.GetValue<Decimal>("totalscore"),
                        gamesplayed = (int)reader.GetValue<Int64>("gamesplayed"),
                    };

                    ret.Add(t);
                }
            return ret;
        }

        public List<ScoreCardsModel> GetAllScoreCards(int page, int itemsPerPage)
        {
            var ret = new List<ScoreCardsModel>();
            int offset = (page - 1) * itemsPerPage;
            var cmd = this.MySqlDatabase.Connection.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"SELECT games.playerid as playerid, players.name , SUM(games.score) as totalscore, COUNT(*) as gamesplayed  FROM games INNER JOIN players ON players.playerid = games.playerid GROUP BY games.playerid ORDER BY `score` DESC LIMIT @Offset, @ItemsPerPage";
            cmd.Parameters.AddWithValue("@Offset", offset);
            cmd.Parameters.AddWithValue("@ItemsPerPage", itemsPerPage);
            using (var reader = cmd.ExecuteReader())
                while (reader.Read())
                {
                    var t = new ScoreCardsModel()
                    {
                        playerid = reader.GetValue<Int32>("playerid"),
                        name = reader.GetValue<String>("name"),
                        totalscore = (int)reader.GetValue<Decimal>("totalscore"),
                        gamesplayed = (int)reader.GetValue<Int64>("gamesplayed"),
                    };

                    ret.Add(t);
                }
            return ret;
        }

        public int GetTotalScoreCardsRecords()
        {
            var cmd = this.MySqlDatabase.Connection.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"SELECT count(*) as TotalRecord FROM players";
            using (var reader = cmd.ExecuteReader())
                while (reader.Read())
                {
                    return reader.GetInt32("TotalRecord");
                }
            return 0;
        }
    }
}
