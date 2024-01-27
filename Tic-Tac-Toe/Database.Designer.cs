namespace Tic_Tac_Toe
{
    partial class Database
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
            dgv_records = new DataGridView();
            label2 = new Label();
            btn_delete = new Button();
            label1 = new Label();
            btn_new_game = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_records).BeginInit();
            SuspendLayout();
            // 
            // dgv_records
            // 
            dgv_records.BackgroundColor = Color.WhiteSmoke;
            dgv_records.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_records.Location = new Point(31, 67);
            dgv_records.Name = "dgv_records";
            dgv_records.RowHeadersWidth = 51;
            dgv_records.Size = new Size(784, 327);
            dgv_records.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(330, 19);
            label2.Name = "label2";
            label2.Size = new Size(167, 31);
            label2.TabIndex = 2;
            label2.Text = "Game Records";
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Silver;
            btn_delete.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_delete.ForeColor = SystemColors.ButtonHighlight;
            btn_delete.Location = new Point(439, 440);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(238, 58);
            btn_delete.TabIndex = 10;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(46, 397);
            label1.Name = "label1";
            label1.Size = new Size(250, 23);
            label1.TabIndex = 11;
            label1.Text = "Double select one row to delete...";
            // 
            // btn_new_game
            // 
            btn_new_game.BackColor = Color.Silver;
            btn_new_game.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_new_game.ForeColor = SystemColors.ButtonHighlight;
            btn_new_game.Location = new Point(138, 440);
            btn_new_game.Name = "btn_new_game";
            btn_new_game.Size = new Size(238, 58);
            btn_new_game.TabIndex = 12;
            btn_new_game.Text = "New Game";
            btn_new_game.UseVisualStyleBackColor = false;
            btn_new_game.Click += btn_new_game_Click;
            // 
            // Database
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            Controls.Add(btn_new_game);
            Controls.Add(label1);
            Controls.Add(btn_delete);
            Controls.Add(label2);
            Controls.Add(dgv_records);
            Name = "Database";
            Size = new Size(847, 534);
            ((System.ComponentModel.ISupportInitialize)dgv_records).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_records;
        private Label label2;
        private Button btn_delete;
        private Label label1;
        private Button btn_new_game;
    }
}
