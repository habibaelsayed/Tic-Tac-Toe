namespace Tic_Tac_Toe
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btn_new_game = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(21, 177);
            label2.Name = "label2";
            label2.Size = new Size(760, 179);
            label2.TabIndex = 11;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(317, 20);
            label1.Name = "label1";
            label1.Size = new Size(182, 28);
            label1.TabIndex = 12;
            label1.Text = "Tic-Tac-Toe Game";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.xo2;
            pictureBox1.Location = new Point(609, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // btn_new_game
            // 
            btn_new_game.BackColor = Color.Silver;
            btn_new_game.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_new_game.ForeColor = SystemColors.ButtonHighlight;
            btn_new_game.Location = new Point(301, 416);
            btn_new_game.Name = "btn_new_game";
            btn_new_game.Size = new Size(238, 58);
            btn_new_game.TabIndex = 15;
            btn_new_game.Text = "Back To Game";
            btn_new_game.UseVisualStyleBackColor = false;
            btn_new_game.Click += btn_new_game_Click;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            Controls.Add(btn_new_game);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "About";
            Size = new Size(847, 534);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btn_new_game;
    }
}
