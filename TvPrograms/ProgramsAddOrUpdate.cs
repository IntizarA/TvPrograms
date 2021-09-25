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
    public partial class ProgramsAddOrUpdate : Form
    {
        public string OpType;
        public int? ProgramId;
        public ProgramsAddOrUpdate(string opType, int? programId)
        {
            this.OpType = opType;
            this.ProgramId = programId;
            InitializeComponent();
        }

        private void ProgramsAddOrUpdate_Load(object sender, EventArgs e)
        {
            SqlPartController controller = new SqlPartController();
            cmbChannels.DataSource = controller.GetChannels();
            cmbChannels.DisplayMember = "ChannelName";
            cmbChannels.ValueMember = "ChannelId";

            if (OpType == "add")
            {
                btnSave.Text = "Add";
            }
            else
            {
                btnSave.Text = "Update";
                TVPrograms pr = new TVPrograms();
                pr = controller.GetProgramForUpdate(Convert.ToInt32(ProgramId));
                txtName.Text = pr.ProgramName;
                txtStartedAt.Text = pr.StartedAt.ToString();
                txtFinishedAt.Text = pr.FinishedAt.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlPartController controller = new SqlPartController();


            if (btnSave.Text == "Add")
            {
                int programId = (int)cmbChannels.SelectedValue;
                controller.InsertTVProgram(txtName.Text, TimeSpan.Parse(txtStartedAt.Text), TimeSpan.Parse(txtFinishedAt.Text), programId);
               // MessageBox.Show("added");
                this.Hide();
            }
            else
            {
                int programId = (int)cmbChannels.SelectedValue;
                controller.UpdateTVProgram(Convert.ToInt32(ProgramId),txtName.Text, TimeSpan.Parse(txtStartedAt.Text), TimeSpan.Parse(txtFinishedAt.Text),programId);
               // MessageBox.Show("updated");
                this.Hide();
            }
        }
    }
}
