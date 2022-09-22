using mabextendedFETest.Manager.Interfaces;
using mabextendedFETest.Utility;
using mabextenedFETest.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace mabextendedFETest.Manager.Implementation
{
    public class ScoreCardsManager : IScoreCardsManager
    {
        private readonly IScoreCardsDataAccess DataAccess = null;
        public ScoreCardsManager(IScoreCardsDataAccess dataAccess)
        {
            DataAccess = dataAccess;

        }
        public APIResponse GetScoreCards(int page, int itemsPerPage)
        {
            var result = DataAccess.GetAllScoreCards(page, itemsPerPage);
            if (result != null && result.Count > 0)
            {
                var totalRecords = DataAccess.GetAllScoreCards(page, itemsPerPage);
                var response = new { records = result, pageNumber = page, pageSize = itemsPerPage, totalRecords = totalRecords };
                return new APIResponse(ResponseCode.SUCCESS, "Record Found", response);
            }
            else
            {
                return new APIResponse(ResponseCode.ERROR, "No Record Found");
            }
        }

        public APIResponse SearchScoreCards(string searchKey, int page, int itemsPerPage)
        {
            throw new NotImplementedException();
        }
    }
}
