using Tic_Tac_Toe.XO.Business;
using Tic_Tac_Toe.XO.Business.Model;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void home2_btnClicked(object sender, EventArgs e)
        {
            string firstName = home2.Txt_firstname;
            string secondName = home2.Txt_secondname;
            if (firstName == "" || secondName == "")
                MessageBox.Show("Enter Players names!");
            else if (!(home2.Radio_p1o || home2.Radio_p1x))
                MessageBox.Show("Please Choose X or O!");
            else
            {
                game2.Lbl_firstName = firstName;
                game2.Lbl_secondName = secondName;
                home2.Visible = false;
                database1.Visible = false;
                game2.Visible = true;
                if(home2.Radio_p1o)
                {
                    game2.Player1 = "O";
                    game2.Player2 = "X";
                    
                }
                else
                {
                    game2.Player1 = "X";
                    game2.Player2 = "O";
                }
                game2.Lbl_p1 = game2.Player1;
                game2.Lbl_p2 = game2.Player2;
                
            }
            // database1.Visible = false;


        }
        private void game2_btn_save_click(object sender, EventArgs e)
        {
            GameRecord game = new GameRecord
            {
                Player1 = game2.Lbl_firstName,
                Player2 = game2.Lbl_secondName,
                P1Score = int.Parse(game2.Lbl_p1score),
                P2Score = int.Parse(game2.Lbl_p2score)
            };

            database1.Visible = true;
            game2.Visible = false;
            home2.Visible = false;
            int effectedRow = GameRecordService.Create(game);

            //MessageBox.Show($"{effectedRow}");

            database1.Dgv_records.DataSource = GameRecordService.Read();

            
        }


        private void btn_delete_row(object sender, EventArgs e)
        {
            try
            {
                int gameId = (int)database1.Dgv_records.SelectedRows[0].Cells[0].Value;
                int effectedRow = GameRecordService.Delete(gameId);

                if (effectedRow < 1)
                    MessageBox.Show("Select a row first");
                else
                    MessageBox.Show($"Record deleted!");

                database1.Dgv_records.DataSource = GameRecordService.Read();
            }
            catch
            {
                MessageBox.Show("Select a row first");
            }

        }
        private void NewGame()
        {
            home2.Visible = true;
            game2.Visible = false;
            database1.Visible = false;
            about1.Visible = false;
            home2.Txt_firstname = "";
            home2.Txt_secondname = "";
            home2.Radio_p1o = false;
            home2.Radio_p2o = false;
            home2.Radio_p1x = false;
            home2.Radio_p2x = false;
            game2.Lbl_p1score = "0";
            game2.Lbl_p2score = "0";
            game2.P1_score = 0;
            game2.P2_score = 0;
            game2.Lbl_turn = "Enjoy The game!";

        }

        private void btn_new_game_click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void btn_about_click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void btn_about_page_click(object sender, EventArgs e)
        {
            about1.Visible = true;
            home2.Visible=false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            NewGame();
            about1.ButtonClick += btn_about_click;
            home2.StartButtonClick += home2_btnClicked;
            game2.ButtonClick += game2_btn_save_click;
            database1.DeleteButtonClick += btn_delete_row;
            database1.NewButtonClick += btn_new_game_click;
            home2.AboutButtonClick += btn_about_page_click;
        }

        
    }
}
