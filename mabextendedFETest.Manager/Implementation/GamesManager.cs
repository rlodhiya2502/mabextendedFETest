using mabextendedFETest.Manager.Interfaces;
using mabextendedFETest.Model;
using mabextendedFETest.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace mabextendedFETest.Manager.Implementation
{
    public class GamesManager : IGamesManager
    {
        public APIResponse AddGames(GamesModel model)
        {
            throw new NotImplementedException();
        }

        public APIResponse DeleteGames(int gamesid)
        {
            throw new NotImplementedException();
        }

        public APIResponse GetGames(int page, int itemsPerPage)
        {
            throw new NotImplementedException();
        }

        public APIResponse GetGamesByID(int gamesid)
        {
            throw new NotImplementedException();
        }

        public APIResponse SearchGames(string searchKey, int page, int itemsPerPage)
        {
            throw new NotImplementedException();
        }

        public APIResponse UpdateGames(int gamesid, GamesModel model)
        {
            throw new NotImplementedException();
        }
    }
}
