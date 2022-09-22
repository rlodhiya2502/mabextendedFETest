using mabextendedFETest.Model;
using mabextendedFETest.Utility;
using mabextenedFETest.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace mabextenedFETest.DataAccess.Implementation
{
    public class GamesDataAccess : IGamesDataAccess
    {
        private MySqlDatabase MySqlDatabase { get; set; }
        public GamesDataAccess(MySqlDatabase mySqlDatabase)
        {
            MySqlDatabase = mySqlDatabase;
        }

        public long AddGames(GamesModel model)
        {
            throw new NotImplementedException();
        }

        public bool DeleteGames(int gamesid)
        {
            throw new NotImplementedException();
        }

        public List<GamesModel> GetAllGames(int page, int itemsPerPage)
        {
            throw new NotImplementedException();
        }

        public int GetAllTotalRecordGames()
        {
            throw new NotImplementedException();
        }

        public GamesModel GetGamesByID(int gamesid)
        {
            throw new NotImplementedException();
        }

        public int GetSearchTotalRecordGames(string searchKey)
        {
            throw new NotImplementedException();
        }

        public List<GamesModel> SearchGames(string searchKey, int page = 1, int itemsPerPage = 100)
        {
            throw new NotImplementedException();
        }

        public bool UpdateGames(GamesModel model)
        {
            throw new NotImplementedException();
        }
    }
}
