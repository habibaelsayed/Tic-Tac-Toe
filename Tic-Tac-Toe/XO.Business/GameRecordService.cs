using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_Toe.XO.Business.Model;
using Tic_Tac_Toe.XO.DataAccess;

namespace Tic_Tac_Toe.XO.Business
{
    public class GameRecordService
    {
        public static string connectionString = "Server=.;Database=XO_Game;Trusted_Connection=True;TrustServerCertificate=True";

        //create [insert]
        public static int Create(GameRecord record)
        {
            string createCommand = $"insert into Records ([Player1], [Player1Score], [Player2], [Player2Score], [DateTime]) values ('{record.Player1}', {record.P1Score}, '{record.Player2}', {record.P2Score}, getdate());";
            int result = DBContext.ExecuteNonQuery(createCommand, connectionString);
            
            return result;
        }

        //read [select]
        public static DataTable Read()
        {
            DataTable dt = new DataTable();
            string readCommand = "SELECT * FROM Records";

            dt = DBContext.Select(readCommand, connectionString);

            return dt;
        }


        //delete [delete]
        public static int Delete(int gameId)
        {
            string deleteCommand = $"delete from Records where gameId = {gameId}";

            int result = DBContext.ExecuteNonQuery(deleteCommand, connectionString);
            return result;
        }
    }
}
