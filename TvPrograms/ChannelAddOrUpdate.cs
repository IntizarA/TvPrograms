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
    public partial class ChannelAddOrUpdate : Form
    {
        public string Optype;
        public int? Id;
        public ChannelAddOrUpdate(string opType, int? id)
        {
            this.Optype = opType;
            this.Id = id;
            InitializeComponent();
        }

        private void AddOrUpdate_Load(object sender, EventArgs e)
        {
            if (Optype == "add")
            {
                btnSave.Text = "Add";
            }
            else
            {
                btnSave.Text = "Update";
                SqlPartController controller = new SqlPartController();
                Channel channel = new Channel();
                channel = controller.GetChannelForUpdate(Convert.ToInt32(Id));
                txtChannelName.Text = channel.ChannelName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlPartController sqlPartController = new SqlPartController();

            if (btnSave.Text == "Add") 
            {
                sqlPartController.InsertChannel(txtChannelName.Text);
                //MessageBox.Show("Channel Added");
                this.Hide();
            }
            else
            {
                sqlPartController.UpdateChannel(Convert.ToInt32(Id), txtChannelName.Text);
              //  MessageBox.Show("Channel updated");
                this.Hide();
            }
        }
    }
}
