using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace mabextendedFETest.Model
{
    public class GamesModel
    {
        public int gamesid { get; set; }
        [Range(int.MinValue, int.MaxValue)]
        public int playerid { get; set; }
        [Range(int.MinValue, int.MaxValue)]
        public int score { get; set; }
        [Required]
        public DateTime gamedatetime { get; set; }
    }
}
}
