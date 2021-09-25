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
    public partial class Channels : Form
    {
        public Channels()
        {
            InitializeComponent();
        }

        private void Channels_Load(object sender, EventArgs e)
        {
            SqlPartController controller = new SqlPartController();

            gridChannels.DataSource = controller.GetChannels();
            //gridChannels.SelectedRows[0].Cells["UserId"].Value;
        }

        private void gridChannels_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ShowAll shower = new ShowAll();

            this.Hide();

            shower.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = gridChannels.SelectedRows[0].Index;
            // MessageBox.Show("index:" + index.ToString());
            int id = (int)gridChannels.Rows[index].Cells["ChannelId"].Value;
            // MessageBox.Show("id:"+id.ToString());
            SqlPartController controller = new SqlPartController();
            controller.DeleteChannel(id);
            gridChannels.Rows.RemoveAt(index);
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            int count = gridChannels.SelectedRows.Count;
            if (count > 0)
            {
                int index = gridChannels.SelectedRows[0].Index;
                int id = (int)gridChannels.Rows[index].Cells["ChannelId"].Value;
                string channelName = gridChannels.Rows[index].Cells["ChannelName"].Value.ToString();
                ChannelAddOrUpdate addupdate = new ChannelAddOrUpdate("update", id);
               
                addupdate.ShowDialog();
            }
            else
            {
                ChannelAddOrUpdate addupdate = new ChannelAddOrUpdate("add", null);
                addupdate.ShowDialog();
            }
        }

        private void Show_Click(object sender, EventArgs e)
        {
            int count = gridChannels.SelectedRows.Count;
            Channel channel = new Channel();
            int index=gridChannels.SelectedRows[0].Index;
            int channelid = (int)gridChannels.Rows[index].Cells["ChannelId"].Value;
            
            if(count > 0)
            {
                ShowChannelInfo info = new ShowChannelInfo(channelid);
                this.Hide();
                info.ShowDialog();
            }
            else
            {
                MessageBox.Show("select a channel");
            }
        }
    }
}
