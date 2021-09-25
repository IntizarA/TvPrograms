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
    public partial class ShowChannelInfo : Form
    {
        public int Channelid;
        public ShowChannelInfo()
        {
            InitializeComponent();
        }
        public ShowChannelInfo(int channelId)
        {
            this.Channelid = channelId;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
        }

        private void ShowChannelInfo_Load(object sender, EventArgs e)
        {
            SqlPartController controller = new SqlPartController();
            gridChannelInfo.AutoGenerateColumns = false;
            gridChannelInfo.DataSource = controller.GetByDoubleClickChannel(Channelid);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ShowAllTabs st = new ShowAllTabs();
            this.Hide();
            st.ShowDialog();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
