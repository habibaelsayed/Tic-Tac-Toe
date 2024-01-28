namespace Tic_Tac_Toe
{
    partial class Home
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
            label1 = new Label();
            lbl_firstname = new Label();
            lbl_secondname = new Label();
            txt_firstname = new TextBox();
            txt_secondname = new TextBox();
            btn_start = new Button();
            panel1 = new Panel();
            radio_p1o = new RadioButton();
            radio_p1x = new RadioButton();
            panel2 = new Panel();
            radio_p2o = new RadioButton();
            radio_p2x = new RadioButton();
            pictureBox1 = new PictureBox();
            btn_about = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(270, 20);
            label1.Name = "label1";
            label1.Size = new Size(303, 28);
            label1.TabIndex = 0;
            label1.Text = "Welcome To Tic-Tac-Toe Game";
            // 
            // lbl_firstname
            // 
            lbl_firstname.AutoSize = true;
            lbl_firstname.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic);
            lbl_firstname.ForeColor = SystemColors.ButtonHighlight;
            lbl_firstname.Location = new Point(3, 20);
            lbl_firstname.Name = "lbl_firstname";
            lbl_firstname.Size = new Size(100, 23);
            lbl_firstname.TabIndex = 1;
            lbl_firstname.Text = "First Player";
            // 
            // lbl_secondname
            // 
            lbl_secondname.AutoSize = true;
            lbl_secondname.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic);
            lbl_secondname.ForeColor = SystemColors.ButtonHighlight;
            lbl_secondname.Location = new Point(4, 20);
            lbl_secondname.Name = "lbl_secondname";
            lbl_secondname.Size = new Size(122, 23);
            lbl_secondname.TabIndex = 2;
            lbl_secondname.Text = "Second Player";
            // 
            // txt_firstname
            // 
            txt_firstname.Location = new Point(124, 19);
            txt_firstname.Name = "txt_firstname";
            txt_firstname.Size = new Size(135, 27);
            txt_firstname.TabIndex = 3;
            // 
            // txt_secondname
            // 
            txt_secondname.Location = new Point(132, 20);
            txt_secondname.Name = "txt_secondname";
            txt_secondname.Size = new Size(137, 27);
            txt_secondname.TabIndex = 4;
            // 
            // btn_start
            // 
            btn_start.BackColor = Color.Silver;
            btn_start.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_start.ForeColor = SystemColors.ButtonHighlight;
            btn_start.Location = new Point(286, 433);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(255, 55);
            btn_start.TabIndex = 5;
            btn_start.Text = "Start Game";
            btn_start.UseVisualStyleBackColor = false;
            btn_start.Click += btn_start_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(radio_p1o);
            panel1.Controls.Add(radio_p1x);
            panel1.Controls.Add(txt_firstname);
            panel1.Controls.Add(lbl_firstname);
            panel1.Location = new Point(24, 232);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 135);
            panel1.TabIndex = 6;
            // 
            // radio_p1o
            // 
            radio_p1o.AutoSize = true;
            radio_p1o.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            radio_p1o.ForeColor = SystemColors.ButtonHighlight;
            radio_p1o.Location = new Point(139, 85);
            radio_p1o.Name = "radio_p1o";
            radio_p1o.Size = new Size(44, 27);
            radio_p1o.TabIndex = 5;
            radio_p1o.TabStop = true;
            radio_p1o.Text = "O";
            radio_p1o.UseVisualStyleBackColor = true;
            radio_p1o.CheckedChanged += radio_p1o_CheckedChanged;
            // 
            // radio_p1x
            // 
            radio_p1x.AutoSize = true;
            radio_p1x.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            radio_p1x.ForeColor = SystemColors.ButtonHighlight;
            radio_p1x.Location = new Point(53, 85);
            radio_p1x.Name = "radio_p1x";
            radio_p1x.Size = new Size(42, 27);
            radio_p1x.TabIndex = 4;
            radio_p1x.TabStop = true;
            radio_p1x.Text = "X";
            radio_p1x.UseVisualStyleBackColor = true;
            radio_p1x.CheckedChanged += radio_p1x_CheckedChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(radio_p2o);
            panel2.Controls.Add(radio_p2x);
            panel2.Controls.Add(txt_secondname);
            panel2.Controls.Add(lbl_secondname);
            panel2.Location = new Point(542, 92);
            panel2.Name = "panel2";
            panel2.Size = new Size(277, 135);
            panel2.TabIndex = 7;
            // 
            // radio_p2o
            // 
            radio_p2o.AutoSize = true;
            radio_p2o.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            radio_p2o.ForeColor = SystemColors.ButtonHighlight;
            radio_p2o.Location = new Point(157, 85);
            radio_p2o.Name = "radio_p2o";
            radio_p2o.Size = new Size(44, 27);
            radio_p2o.TabIndex = 7;
            radio_p2o.TabStop = true;
            radio_p2o.Text = "O";
            radio_p2o.UseVisualStyleBackColor = true;
            radio_p2o.CheckedChanged += radio_p2o_CheckedChanged;
            // 
            // radio_p2x
            // 
            radio_p2x.AutoSize = true;
            radio_p2x.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            radio_p2x.ForeColor = SystemColors.ButtonHighlight;
            radio_p2x.Location = new Point(67, 85);
            radio_p2x.Name = "radio_p2x";
            radio_p2x.Size = new Size(42, 27);
            radio_p2x.TabIndex = 6;
            radio_p2x.TabStop = true;
            radio_p2x.Text = "X";
            radio_p2x.UseVisualStyleBackColor = true;
            radio_p2x.CheckedChanged += radio_p2x_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.xo;
            pictureBox1.Location = new Point(333, 135);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btn_about
            // 
            btn_about.BackColor = Color.Silver;
            btn_about.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_about.ForeColor = SystemColors.ButtonHighlight;
            btn_about.Location = new Point(24, 20);
            btn_about.Name = "btn_about";
            btn_about.Size = new Size(121, 39);
            btn_about.TabIndex = 9;
            btn_about.Text = "How to play";
            btn_about.UseVisualStyleBackColor = false;
            btn_about.Click += btn_about_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            Controls.Add(btn_about);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn_start);
            Controls.Add(label1);
            Name = "Home";
            Size = new Size(847, 534);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl_firstname;
        private Label lbl_secondname;
        private TextBox txt_firstname;
        private TextBox txt_secondname;
        private Button btn_start;
        private Panel panel1;
        private Panel panel2;
        private RadioButton radio_p1o;
        private RadioButton radio_p1x;
        private RadioButton radio_p2o;
        private RadioButton radio_p2x;
        private PictureBox pictureBox1;
        private Button btn_about;
    }
}
