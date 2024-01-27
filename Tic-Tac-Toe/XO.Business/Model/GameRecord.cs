using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.XO.Business.Model
{
    public class GameRecord
    {
        public string Player1 { get; set; } = string.Empty;
        public string Player2 { get; set; } = string.Empty;
        public int P1Score { get; set; }
        public int P2Score { get; set;}
    }
}
