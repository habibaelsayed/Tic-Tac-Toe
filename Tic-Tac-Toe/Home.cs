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
    public partial class Home : UserControl
    {
        public event EventHandler<EventArgs> StartButtonClick;
        public event EventHandler<EventArgs> AboutButtonClick;
        public Home()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            StartButtonClick?.Invoke(this, EventArgs.Empty);

        }

        private void radio_p1x_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_p1x.Checked)
            {
                radio_p2o.Checked = true;
            }
        }

        private void radio_p1o_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_p1o.Checked)
            {
                radio_p2x.Checked = true;
            }
        }

        private void radio_p2x_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_p2x.Checked)
            {
                radio_p1o.Checked = true;
            }
        }

        private void radio_p2o_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_p2o.Checked)
            {
                radio_p1x.Checked = true;
            }
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            AboutButtonClick?.Invoke(this, EventArgs.Empty);
        }

        public string Txt_firstname
        {
            set { txt_firstname.Text = value; }
            get { return txt_firstname.Text; }
        }

        public string Txt_secondname
        {
            set { txt_secondname.Text = value; }
            get { return txt_secondname.Text; }
        }

        public bool Radio_p1x
        {
            set { radio_p1x.Checked = value; }
            get { return radio_p1x.Checked; }
        }

        public bool Radio_p1o
        {
            set { radio_p1o.Checked = value; }
            get { return radio_p1o.Checked; }
        }

        public bool Radio_p2x
        {
            set { radio_p2x.Checked = value; }
            get { return radio_p2x.Checked; }
        }

        public bool Radio_p2o
        {
            set { radio_p2o.Checked = value; }
            get { return radio_p2o.Checked; }
        }


    }
}
