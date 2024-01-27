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
    public partial class Database : UserControl
    {

        public event EventHandler<EventArgs> DeleteButtonClick;

        public event EventHandler<EventArgs> NewButtonClick;
        public Database()
        {
            InitializeComponent();
        }

        public DataGridView Dgv_records
        {
            get { return dgv_records; }
            set { dgv_records = value; }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DeleteButtonClick?.Invoke(this, EventArgs.Empty);
        }

        private void btn_new_game_Click(object sender, EventArgs e)
        {
            NewButtonClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
