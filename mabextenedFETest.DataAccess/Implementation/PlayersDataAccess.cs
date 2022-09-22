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
            throw new NotImplementedException();
        }

        public int GetAllTotalRecordPlayers()
        {
            throw new NotImplementedException();
        }

        public PlayersModel GetPlayersByID(int playerid)
        {
            throw new NotImplementedException();
        }

        public int GetSearchTotalRecordPlayers(string searchKey)
        {
            throw new NotImplementedException();
        }

        public List<PlayersModel> SearchPlayers(string searchKey, int page = 1, int itemsPerPage = 100)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePlayers(PlayersModel model)
        {
            throw new NotImplementedException();
        }
    }
}
