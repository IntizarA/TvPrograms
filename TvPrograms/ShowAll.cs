using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TvPrograms
{
    public partial class ShowAll : Form
    {
        public ShowAll()
        {
            InitializeComponent();
        }

        private void btnChannels_Click(object sender, EventArgs e)
        {
            Channels channels = new Channels();
            this.Hide();
            channels.ShowDialog();
        }

        private void btnPrograms_Click(object sender, EventArgs e)
        {
            FormPrograms pr = new FormPrograms();
            this.Hide();
            pr.ShowDialog();
        }

        private void btnHostes_Click(object sender, EventArgs e)
        {
            Hostes host = new Hostes();
            this.Hide();
            host.ShowDialog();
        }

        private void btnHostProgram_Click(object sender, EventArgs e)
        {
            HostProgram hostprogram = new HostProgram("add",null);
            this.Hide();
            hostprogram.ShowDialog();
        }

        private void ShowAll_Load(object sender, EventArgs e)
        {

        }
    }
}
