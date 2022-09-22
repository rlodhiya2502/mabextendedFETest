using mabextendedFETest.Model;
using mabextendedFETest.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace mabextendedFETest.Manager.Interfaces
{
    public interface IGamesManager
    {
        APIResponse GetGames(int page, int itemsPerPage);
        APIResponse SearchGames(string searchKey, int page, int itemsPerPage);
        APIResponse GetGamesByID(int gamesid);
        APIResponse UpdateGames(int gamesid, GamesModel model);
        APIResponse AddGames(GamesModel model);
        APIResponse DeleteGames(int gamesid);
    }
}
