using mabextendedFETest.Model;
using mabextendedFETest.Utility;
using mabextenedFETest.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace mabextenedFETest.DataAccess.Implementation
{
    public class ScoreCardsDataAccess : IScoreCardsDataAccess
    {
        private MySqlDatabase MySqlDatabase { get; set; }

        public ScoreCardsDataAccess(MySqlDatabase mySqlDatabase)
        {
            MySqlDatabase = mySqlDatabase;
        }

        public List<ScoreCardsModel> GetScoreCardsModels(int page, int itemsPerPage)
        {
            throw new NotImplementedException();
        }

        public List<ScoreCardsModel> SearchScoreCards(string searchKey, int page = 1, int itemsPerPage = 10)
        {
            throw new NotImplementedException();
        }
    }
}
