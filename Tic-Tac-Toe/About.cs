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
    public partial class About : UserControl
    {
        public event EventHandler<EventArgs> ButtonClick;
        public About()
        {
            InitializeComponent();
        }

        private void btn_new_game_Click(object sender, EventArgs e)
        {
            ButtonClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
