using mabextendedFETest.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace mabextenedFETest.DataAccess.Interfaces
{
    public interface IScoreCardsDataAccess
    {
        List<ScoreCardsModel> GetAllScoreCards(int page, int itemsPerPage);

        List<ScoreCardsModel> SearchScoreCards(string searchKey, int page =1, int itemsPerPage = 10);

        int GetTotalScoreCardsRecords();
    }
}
