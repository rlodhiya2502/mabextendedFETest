using mabextendedFETest.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace mabextenedFETest.DataAccess.Interfaces
{
    public interface IPlayersDataAccess
    {
        List<PlayersModel> GetAllPlayers(int page, int itemsPerPage);
        List<PlayersModel> SearchPlayers(string searchKey, int page = 1, int itemsPerPage = 100);
        PlayersModel GetPlayersByID(int playerid);
        int GetAllTotalRecordPlayers();
        int GetSearchTotalRecordPlayers(string searchKey);
        bool UpdatePlayers(PlayersModel model);
        long AddPlayers(PlayersModel model);
        bool DeletePlayers(int playerid);

    }
}
