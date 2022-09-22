using mabextendedFETest.Manager.Interfaces;
using mabextendedFETest.Model;
using mabextendedFETest.Utility;
using mabextenedFETest.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace mabextendedFETest.Manager.Implementation
{
    public class PlayersManager : IPlayersManager
    {
        private readonly IPlayersDataAccess DataAccess = null;
        public PlayersManager(IPlayersDataAccess dataAccess)
        {
            DataAccess = dataAccess;
        }
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
            var result = DataAccess.GetAllPlayers(page, itemsPerPage);
            if (result != null && result.Count > 0)
            {
                var totalRecords = DataAccess.GetAllTotalRecordPlayers();
                var response = new { records = result, pageNumber = page, pageSize = itemsPerPage, totalRecords = totalRecords };
                return new APIResponse(ResponseCode.SUCCESS, "Record Found", response);
            }
            else
            {
                return new APIResponse(ResponseCode.ERROR, "No Record Found");
            }
        }

        public APIResponse GetPlayersByID(int playerid)
        {
            var result = DataAccess.GetPlayersByID(playerid);
            if (result != null)
            {
                return new APIResponse(ResponseCode.SUCCESS, "Record Found", result);
            }
            else
            {
                return new APIResponse(ResponseCode.ERROR, "No Record Found");
            }
        }

        public APIResponse SearchPlayers(string searchKey, int page, int itemsPerPage)
        {
            var result = DataAccess.SearchPlayers(searchKey, page, itemsPerPage);
            if (result != null && result.Count > 0)
            {
                var totalRecords = DataAccess.GetSearchTotalRecordPlayers(searchKey);
                var response = new { records = result, pageNumber = page, pageSize = itemsPerPage, totalRecords = totalRecords };
                return new APIResponse(ResponseCode.SUCCESS, "Record Found", response);
            }
            else
            {
                return new APIResponse(ResponseCode.ERROR, "No Record Found");
            }
        }

        public APIResponse UpdatePlayers(int playerid, PlayersModel model)
        {
            throw new NotImplementedException();
        }
    }
}
