namespace Tic_Tac_Toe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            home2 = new Home();
            game2 = new Game();
            database1 = new Database();
            SuspendLayout();
            // 
            // home2
            // 
            home2.BackColor = Color.CadetBlue;
            home2.Location = new Point(1, -1);
            home2.Name = "home2";
            home2.Size = new Size(882, 557);
            home2.TabIndex = 0;
            home2.Txt_firstname = "";
            home2.Txt_secondname = "";
            // 
            // game2
            // 
            game2.BackColor = Color.CadetBlue;
            game2.BorderStyle = BorderStyle.FixedSingle;
            game2.Lbl_firstName = "First Name";
            game2.Lbl_p1 = "X";
            game2.Lbl_p1score = "0";
            game2.Lbl_p2 = "O";
            game2.Lbl_p2score = "0";
            game2.Lbl_secondName = "Second Name";
            game2.Location = new Point(1, -1);
            game2.Name = "game2";
            game2.Player1 = null;
            game2.Player2 = null;
            game2.Size = new Size(885, 558);
            game2.TabIndex = 1;
            game2.Turn = false;
            // 
            // database1
            // 
            database1.BackColor = Color.CadetBlue;
            database1.Location = new Point(1, -1);
            database1.Name = "database1";
            database1.Size = new Size(882, 557);
            database1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 556);
            Controls.Add(database1);
            Controls.Add(game2);
            Controls.Add(home2);
            Name = "Form1";
            Text = "Tic-Tac-Teo Game";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_start;
        private Button btn_save;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Home home2;
        private Game game2;
        private Database database1;
    }
}
