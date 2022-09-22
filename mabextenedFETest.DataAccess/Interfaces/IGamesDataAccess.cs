using mabextendedFETest.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace mabextenedFETest.DataAccess.Interfaces
{
    public interface IGamesDataAccess
    {
        List<GamesModel> GetAllGames(int page, int itemsPerPage);
        List<GamesModel> SearchGames(string searchKey, int page = 1, int itemsPerPage = 100);
        GamesModel GetGamesByID(int gamesid);
        int GetAllTotalRecordGames();
        int GetSearchTotalRecordGames(string searchKey);
        bool UpdateGames(GamesModel model);
        long AddGames(GamesModel model);
        bool DeleteGames(int gamesid);

    }
}
