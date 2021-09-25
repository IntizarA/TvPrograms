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
    public partial class HostesAddOrUpdate : Form
    {
        public string OpType;
        public int? HostId;
        public HostesAddOrUpdate(string optype,int? hostid)
        {
            this.OpType = optype;
            this.HostId = hostid;
            InitializeComponent();
        }

        private void HostesAddOrUpdate_Load(object sender, EventArgs e)
        {
            if (OpType == "add")
            {
                btnSave.Text = "Add";


            }
            else
            {
                btnSave.Text = "Update";

                SqlPartController controller = new SqlPartController();
                Host host = new Host();
                host = controller.GetByHostId(Convert.ToInt32(HostId));
                txtHostName.Text = host.HostName;
                txtSurname.Text = host.HostSurname;
               txtAge.Text= host.HostAge.ToString();
               
                txtImage.Text = host.HostPicture;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Add")
            {
                SqlPartController controller = new SqlPartController();
                int age = int.Parse(txtAge.Text);
                controller.InsertHost(txtHostName.Text,txtSurname.Text,age,txtImage.Text);
            //    MessageBox.Show("Host added");
                this.Hide();
            }
            else
            {
                SqlPartController controller = new SqlPartController();
                int age = int.Parse(txtAge.Text);
                controller.UpdateHost(Convert.ToInt32(HostId), txtHostName.Text,txtSurname.Text,age,txtImage.Text);
              //  MessageBox.Show("Host updated");
                this.Hide();
            }
        }
    }
}
