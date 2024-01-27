using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Game : UserControl
    {

        public event EventHandler<EventArgs> ButtonClick;

        string player1, player2;
        int p1_score = 0, p2_score = 0;
        bool turn;
        string[] scores = new string[9];

        public Game()
        {
            InitializeComponent();
        }

        public string Lbl_firstName
        {
            set { lbl_outfirstname.Text = value; }
            get { return lbl_outfirstname.Text; }
        }
        public string Lbl_secondName
        {
            set { lbl_outsecondname.Text = value; }
            get { return lbl_outsecondname.Text; }
        }

        public string Player1
        {
            get { return player1; }
            set { player1 = value; }
        }

        public string Player2
        {
            get { return player2; }
            set { player2 = value; }
        }

        public bool Turn
        {
            set { turn = value; }
            get { return turn; }
        }

        public string Lbl_p1
        {
            set
            {
                lbl_p1.Text = value;
            }
            get
            {
                return lbl_p1.Text;
            }

        }

        public string Lbl_p2
        {
            set
            {
                lbl_p2.Text = value;
            }
            get
            {
                return lbl_p2.Text;
            }

        }

        public string Lbl_p1score
        {
            set { lbl_p1score.Text = value; }
            get { return lbl_p1score.Text; }
        }

        public string Lbl_p2score
        {
            set { lbl_p2score.Text = value; }
            get { return lbl_p2score.Text; }
        }

        public int P1_score
        {
            set { p1_score = value;}
            get { return p1_score; }
        }

        public int P2_score
        {
            set { p2_score = value; }
            get { return p2_score; }
        }

        public string Lbl_turn
        {
            set { lbl_turn.Text = value; }
            get { return lbl_turn.Text; }
        }

        public bool isWinner()
        {
            for (int i = 0; i < 9; i += 3)
            {
                if (scores[i] == Player1 || scores[i] == Player2)
                {
                    if (scores[i] == scores[i + 1] && scores[i + 1] == scores[i + 2])
                        return true;
                }
            }

            // Check columns
            for (int i = 0; i < 3; i++)
            {
                if (scores[i] == Player1 || scores[i] == Player2)
                {
                    if (scores[i] == scores[i + 3] && scores[i + 3] == scores[i + 6])
                        return true;
                }
            }

            // Check diagonals
            if (scores[0] == Player1 || scores[0] == Player2)
            {
                if (scores[0] == scores[4] && scores[4] == scores[8])
                    return true;
            }
            if (scores[2] == Player1 || scores[2] == Player2)
            {
                if (scores[2] == scores[4] && scores[4] == scores[6])
                    return true;
            }

            return false;

        }



        public void checkTheWinner(Button button)
        {
            if (isWinner())
            {
                string winner;
                if (Player1 == button.Text)
                {
                    winner = Lbl_firstName;
                    lbl_p1score.Text = Convert.ToString(++p1_score);
                }
                else
                {
                    winner = Lbl_secondName;
                    lbl_p2score.Text = Convert.ToString(++p2_score);
                }
                MessageBox.Show($"{winner} is the Winner!");
                Reset();
            }
        }

        public void checkTurn(Button button, int index)
        {

            if (button.Enabled)
            {
                if (Turn)
                {
                    button.Text = Player2;
                    lbl_turn.Text = $"{Lbl_firstName} turn!";
                    Turn = false;
                }
                else
                {
                    button.Text = Player1;
                    lbl_turn.Text = $"{Lbl_secondName} turn!";
                    Turn = true;
                }
                scores[index] = button.Text;
                button.Enabled = false;

            }
            checkTheWinner(button);
            Tied();
        }


        public void Reset()
        {
            btn_00.Text = ""; btn_00.Enabled = true;
            btn_01.Text = ""; btn_01.Enabled = true;
            btn_02.Text = ""; btn_02.Enabled = true;
            btn_10.Text = ""; btn_10.Enabled = true;
            btn_11.Text = ""; btn_11.Enabled = true;
            btn_12.Text = ""; btn_12.Enabled = true;
            btn_20.Text = ""; btn_20.Enabled = true;
            btn_21.Text = ""; btn_21.Enabled = true;
            btn_22.Text = ""; btn_22.Enabled = true;

            for (int i = 0; i < scores.Length; i++) scores[i] = "";
        }

        public void Tied()
        {
            if (!btn_00.Enabled && !btn_01.Enabled && !btn_02.Enabled && !btn_10.Enabled && !btn_11.Enabled && !btn_20.Enabled && !btn_21.Enabled && !btn_22.Enabled)
            {
                MessageBox.Show("Tied!");
                Reset();
            }
        }
        private void btn_00_Click(object sender, EventArgs e)
        {
            checkTurn((Button)sender, 0);
        }

        private void btn_01_Click(object sender, EventArgs e)
        {
            checkTurn((Button)sender, 1);
        }

        private void btn_02_Click(object sender, EventArgs e)
        {
            checkTurn((Button)sender, 2);
        }

        private void btn_10_Click(object sender, EventArgs e)
        {
            checkTurn((Button)sender, 3);
        }

        private void btn_11_Click(object sender, EventArgs e)
        {
            checkTurn((Button)sender, 4);
        }

        private void btn_12_Click(object sender, EventArgs e)
        {
            checkTurn((Button)sender, 5);
        }

        private void btn_20_Click(object sender, EventArgs e)
        {
            checkTurn((Button)sender, 6);
        }

        private void btn_21_Click(object sender, EventArgs e)
        {
            checkTurn((Button)sender, 7);
        }

        private void btn_22_Click(object sender, EventArgs e)
        {
            checkTurn((Button)sender, 8);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Reset();
            p1_score = 0;
            p2_score = 0;
            lbl_p1score.Text = p1_score.ToString();
            lbl_p2score.Text = p2_score.ToString();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            ButtonClick?.Invoke(this, EventArgs.Empty);
        }

    
    }
}
