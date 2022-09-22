using System;
using System.ComponentModel.DataAnnotations;

namespace mabextendedFETest.Model
{
    public class PlayersModel
    {
        public int playerid { get; set; }
        [Required]
        public string name { get; set; }
    }
}
