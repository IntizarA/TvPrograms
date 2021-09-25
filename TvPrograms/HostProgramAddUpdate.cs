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
    public partial class HostProgramAddUpdate : Form
    {
        public string OpType;
        public int? HostId;
        public int? ProgramId;
        public HostProgramAddUpdate(string optype, int? hostid, int? programid)
        {

            this.OpType = optype;
            this.HostId = hostid;
            this.ProgramId = programid;
            InitializeComponent();
        }

        private void HostProgramAddUpdate_Load(object sender, EventArgs e)
        {
            SqlPartController controller = new SqlPartController();

            cmbHostNames.DataSource = controller.GetHostesSurname();
            
            cmbHostNames.DisplayMember = "HostSurname";
            cmbHostNames.ValueMember = "HostId";

            //cmbHostNames.DataSource = controller.GetHostesName();
            //cmbHostNames.DisplayMember = "HostName";
            

            cmbProgramNames.DataSource = controller.GetPrograms();
            cmbProgramNames.DisplayMember = "ProgramName";

            cmbProgramNames.ValueMember = "ProgramId";
            if (OpType == "add")
            {
                btnSave.Text = "Add";
                this.txtHoatName.Visible = false;
                this.txtProgramName.Visible = false;
            }
            else
            {
                btnSave.Text = "Update";
                HostTVProgram hostpr = new HostTVProgram();
                hostpr = controller.GetByHostIdProgramId(Convert.ToInt32(HostId), Convert.ToInt32(ProgramId));
                txtHoatName.Text = hostpr.HostName;
                txtProgramName.Text = hostpr.ProgramName;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlPartController controller = new SqlPartController();
            if (btnSave.Text == "Update")
            {

                int hostId = (int)cmbHostNames.SelectedValue;

                int programId = (int)cmbProgramNames.SelectedValue;
                controller.UpdateHostProgram(Convert.ToInt32(HostId), Convert.ToInt32(ProgramId), hostId, programId);
                //   MessageBox.Show("Host TvProgram updated");

                this.Hide();

            }

            else
            {
                int hostId = (int)cmbHostNames.SelectedValue;
                int programId = (int)cmbProgramNames.SelectedValue;
                controller.InsertHostProgram(hostId, programId);
                // MessageBox.Show("Host TVProgram added");
                this.Hide();
            }
        }

        private void cmbHostNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmbHostNames.Items.Add("HostName" + "HostSurname");
        }
    }
}
