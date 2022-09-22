using mabextendedFETest.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace mabextendedFETest.Manager.Interfaces
{
    public interface IScoreCardsManager
    {
        APIResponse GetScoreCards(int page, int itemsPerPage);

        APIResponse SearchScoreCards(string searchKey, int page, int itemsPerPage);
    }
}
