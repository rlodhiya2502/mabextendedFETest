using mabextendedFETest.Manager.Interfaces;
using mabextendedFETest.Model;
using mabextendedFETest.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace mabextendedFETest.Manager.Implementation
{
    internal class PlayersManager : IPlayersManager
    {
        public APIResponse AddPlayers(PlayersModel model)
        {
            throw new NotImplementedException();
        }

        public APIResponse DeletePlayers(int playerid)
        {
            throw new NotImplementedException();
        }

        public APIResponse GetPlayers(int page, int itemsPerPage)
        {
            throw new NotImplementedException();
        }

        public APIResponse GetPlayersByID(int playerid)
        {
            throw new NotImplementedException();
        }

        public APIResponse SearchPlayers(string searchKey, int page, int itemsPerPage)
        {
            throw new NotImplementedException();
        }

        public APIResponse UpdatePlayers(int playerid, PlayersModel model)
        {
            throw new NotImplementedException();
        }
    }
}
