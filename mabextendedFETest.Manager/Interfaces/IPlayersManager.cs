using mabextendedFETest.Model;
using mabextendedFETest.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace mabextendedFETest.Manager.Interfaces
{
    public interface IPlayersManager
    {
        APIResponse GetPlayers(int page, int itemsPerPage);
        APIResponse SearchPlayers(string searchKey, int page, int itemsPerPage);
        APIResponse GetPlayersByID(int playerid);
        APIResponse UpdatePlayers(int playerid, PlayersModel model);
        APIResponse AddPlayers(PlayersModel model);
        APIResponse DeletePlayers(int playerid);
    }
}
