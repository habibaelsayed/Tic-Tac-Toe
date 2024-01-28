namespace Tic_Tac_Toe
{
    partial class Game
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_turn = new Label();
            lbl_outfirstname = new Label();
            lbl_outsecondname = new Label();
            label2 = new Label();
            panel1 = new Panel();
            btn_22 = new Button();
            btn_21 = new Button();
            btn_20 = new Button();
            btn_12 = new Button();
            btn_11 = new Button();
            btn_10 = new Button();
            btn_02 = new Button();
            btn_01 = new Button();
            btn_00 = new Button();
            lbl_p1score = new Label();
            lbl_p2score = new Label();
            lbl_p1 = new Label();
            lbl_p2 = new Label();
            btn_reset = new Button();
            btn_save = new Button();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lbl_turn
            // 
            lbl_turn.AutoSize = true;
            lbl_turn.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_turn.ForeColor = SystemColors.ButtonHighlight;
            lbl_turn.Location = new Point(309, 23);
            lbl_turn.Name = "lbl_turn";
            lbl_turn.Size = new Size(170, 28);
            lbl_turn.TabIndex = 0;
            lbl_turn.Text = "Enjoy The Game!";
            // 
            // lbl_outfirstname
            // 
            lbl_outfirstname.AutoSize = true;
            lbl_outfirstname.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic);
            lbl_outfirstname.ForeColor = SystemColors.ButtonHighlight;
            lbl_outfirstname.Location = new Point(37, 44);
            lbl_outfirstname.Name = "lbl_outfirstname";
            lbl_outfirstname.Size = new Size(95, 23);
            lbl_outfirstname.TabIndex = 1;
            lbl_outfirstname.Text = "First Name";
            // 
            // lbl_outsecondname
            // 
            lbl_outsecondname.AutoSize = true;
            lbl_outsecondname.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic);
            lbl_outsecondname.ForeColor = SystemColors.ButtonHighlight;
            lbl_outsecondname.Location = new Point(30, 44);
            lbl_outsecondname.Name = "lbl_outsecondname";
            lbl_outsecondname.Size = new Size(117, 23);
            lbl_outsecondname.TabIndex = 2;
            lbl_outsecondname.Text = "Second Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Broadway", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(615, 173);
            label2.Name = "label2";
            label2.Size = new Size(55, 32);
            label2.TabIndex = 3;
            label2.Text = "VS";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btn_22);
            panel1.Controls.Add(btn_21);
            panel1.Controls.Add(btn_20);
            panel1.Controls.Add(btn_12);
            panel1.Controls.Add(btn_11);
            panel1.Controls.Add(btn_10);
            panel1.Controls.Add(btn_02);
            panel1.Controls.Add(btn_01);
            panel1.Controls.Add(btn_00);
            panel1.Location = new Point(32, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(376, 346);
            panel1.TabIndex = 4;
            // 
            // btn_22
            // 
            btn_22.Font = new Font("MV Boli", 18F, FontStyle.Bold);
            btn_22.Location = new Point(241, 234);
            btn_22.Name = "btn_22";
            btn_22.Size = new Size(117, 93);
            btn_22.TabIndex = 8;
            btn_22.UseVisualStyleBackColor = true;
            btn_22.Click += btn_22_Click;
            // 
            // btn_21
            // 
            btn_21.Font = new Font("MV Boli", 18F, FontStyle.Bold);
            btn_21.Location = new Point(125, 234);
            btn_21.Name = "btn_21";
            btn_21.Size = new Size(110, 93);
            btn_21.TabIndex = 7;
            btn_21.UseVisualStyleBackColor = true;
            btn_21.Click += btn_21_Click;
            // 
            // btn_20
            // 
            btn_20.Font = new Font("MV Boli", 18F, FontStyle.Bold);
            btn_20.Location = new Point(12, 234);
            btn_20.Name = "btn_20";
            btn_20.Size = new Size(107, 93);
            btn_20.TabIndex = 6;
            btn_20.UseVisualStyleBackColor = true;
            btn_20.Click += btn_20_Click;
            // 
            // btn_12
            // 
            btn_12.Font = new Font("MV Boli", 18F, FontStyle.Bold);
            btn_12.Location = new Point(241, 123);
            btn_12.Name = "btn_12";
            btn_12.Size = new Size(117, 92);
            btn_12.TabIndex = 5;
            btn_12.UseVisualStyleBackColor = true;
            btn_12.Click += btn_12_Click;
            // 
            // btn_11
            // 
            btn_11.Font = new Font("MV Boli", 18F, FontStyle.Bold);
            btn_11.Location = new Point(125, 123);
            btn_11.Name = "btn_11";
            btn_11.Size = new Size(110, 92);
            btn_11.TabIndex = 4;
            btn_11.UseVisualStyleBackColor = true;
            btn_11.Click += btn_11_Click;
            // 
            // btn_10
            // 
            btn_10.Font = new Font("MV Boli", 18F, FontStyle.Bold);
            btn_10.Location = new Point(12, 123);
            btn_10.Name = "btn_10";
            btn_10.Size = new Size(107, 92);
            btn_10.TabIndex = 3;
            btn_10.UseVisualStyleBackColor = true;
            btn_10.Click += btn_10_Click;
            // 
            // btn_02
            // 
            btn_02.Font = new Font("MV Boli", 18F, FontStyle.Bold);
            btn_02.Location = new Point(241, 16);
            btn_02.Name = "btn_02";
            btn_02.Size = new Size(117, 90);
            btn_02.TabIndex = 2;
            btn_02.UseVisualStyleBackColor = true;
            btn_02.Click += btn_02_Click;
            // 
            // btn_01
            // 
            btn_01.Font = new Font("MV Boli", 18F, FontStyle.Bold);
            btn_01.Location = new Point(125, 16);
            btn_01.Name = "btn_01";
            btn_01.Size = new Size(110, 90);
            btn_01.TabIndex = 1;
            btn_01.UseVisualStyleBackColor = true;
            btn_01.Click += btn_01_Click;
            // 
            // btn_00
            // 
            btn_00.Font = new Font("MV Boli", 18F, FontStyle.Bold);
            btn_00.Location = new Point(12, 16);
            btn_00.Name = "btn_00";
            btn_00.Size = new Size(107, 90);
            btn_00.TabIndex = 0;
            btn_00.UseVisualStyleBackColor = true;
            btn_00.Click += btn_00_Click;
            // 
            // lbl_p1score
            // 
            lbl_p1score.AutoSize = true;
            lbl_p1score.BackColor = Color.SlateGray;
            lbl_p1score.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lbl_p1score.ForeColor = SystemColors.ButtonHighlight;
            lbl_p1score.Location = new Point(67, 210);
            lbl_p1score.Name = "lbl_p1score";
            lbl_p1score.Size = new Size(19, 23);
            lbl_p1score.TabIndex = 5;
            lbl_p1score.Text = "0";
            // 
            // lbl_p2score
            // 
            lbl_p2score.AutoSize = true;
            lbl_p2score.BackColor = Color.SlateGray;
            lbl_p2score.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lbl_p2score.ForeColor = SystemColors.ButtonHighlight;
            lbl_p2score.Location = new Point(70, 210);
            lbl_p2score.Name = "lbl_p2score";
            lbl_p2score.Size = new Size(19, 23);
            lbl_p2score.TabIndex = 6;
            lbl_p2score.Text = "0";
            // 
            // lbl_p1
            // 
            lbl_p1.AutoSize = true;
            lbl_p1.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_p1.ForeColor = Color.Yellow;
            lbl_p1.Location = new Point(67, 4);
            lbl_p1.Name = "lbl_p1";
            lbl_p1.Size = new Size(34, 40);
            lbl_p1.TabIndex = 7;
            lbl_p1.Text = "X";
            // 
            // lbl_p2
            // 
            lbl_p2.AutoSize = true;
            lbl_p2.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_p2.ForeColor = Color.Yellow;
            lbl_p2.Location = new Point(70, 4);
            lbl_p2.Name = "lbl_p2";
            lbl_p2.Size = new Size(35, 40);
            lbl_p2.TabIndex = 8;
            lbl_p2.Text = "O";
            // 
            // btn_reset
            // 
            btn_reset.BackColor = Color.Silver;
            btn_reset.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_reset.ForeColor = SystemColors.ButtonHighlight;
            btn_reset.Location = new Point(504, 368);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(269, 58);
            btn_reset.TabIndex = 9;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = false;
            btn_reset.Click += btn_reset_Click;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.Silver;
            btn_save.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_save.ForeColor = SystemColors.ButtonHighlight;
            btn_save.Location = new Point(504, 448);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(269, 58);
            btn_save.TabIndex = 10;
            btn_save.Text = "Save Records";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(lbl_outfirstname);
            panel2.Controls.Add(lbl_p1);
            panel2.Controls.Add(lbl_p1score);
            panel2.Location = new Point(449, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(160, 262);
            panel2.TabIndex = 11;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.player;
            pictureBox3.Location = new Point(22, 81);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(117, 116);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(lbl_outsecondname);
            panel3.Controls.Add(lbl_p2);
            panel3.Controls.Add(lbl_p2score);
            panel3.Location = new Point(676, 68);
            panel3.Name = "panel3";
            panel3.Size = new Size(160, 262);
            panel3.TabIndex = 12;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.player;
            pictureBox2.Location = new Point(20, 81);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(117, 116);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(btn_save);
            Controls.Add(btn_reset);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(lbl_turn);
            Name = "Game";
            Size = new Size(847, 534);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_turn;
        private Label lbl_outfirstname;
        private Label lbl_outsecondname;
        private Label label2;
        private Panel panel1;
        private Label lbl_p1score;
        private Label lbl_p2score;
        private Button btn_22;
        private Button btn_21;
        private Button btn_20;
        private Button btn_12;
        private Button btn_11;
        private Button btn_10;
        private Button btn_02;
        private Button btn_01;
        private Button btn_00;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label lbl_p1;
        private Label lbl_p2;
        private Button btn_reset;
        private Button btn_save;
    }
}
