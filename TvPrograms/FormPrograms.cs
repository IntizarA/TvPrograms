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
    public partial class FormPrograms : Form
    {
        public FormPrograms()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ShowAll shower = new ShowAll();
            this.Hide();
            shower.ShowDialog();
        }

        private void Programs_Load(object sender, EventArgs e)
        {
            //GetProgramData
            SqlPartController controller = new SqlPartController();
            gridPrograms.DataSource = controller.GetPrograms();
            //GetChannelData
            cmbChannels.DataSource = controller.GetChannels();
            cmbChannels.ValueMember = "ChannelId";
            cmbChannels.DisplayMember = "ChannelName";

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            int id = (int)cmbChannels.SelectedValue;
            SqlPartController controller = new SqlPartController();
            gridPrograms.DataSource = controller.GetByChannelId(id);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlPartController controller = new SqlPartController();
            int index = gridPrograms.SelectedRows[0].Index;
            int id = (int)gridPrograms.Rows[index].Cells["ProgramId"].Value;
            controller.DeleteProgram(id);
            gridPrograms.Rows.RemoveAt(index);
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            int count = gridPrograms.SelectedRows.Count;

            if (count > 0)
            {
                int index = gridPrograms.SelectedRows[0].Index;
                int programId = (int)gridPrograms.Rows[index].Cells["ProgramId"].Value;
                ProgramsAddOrUpdate addOrUpdate = new ProgramsAddOrUpdate("update",programId);
                addOrUpdate.ShowDialog();

            }
            else
            {
                ProgramsAddOrUpdate addOrUpdate = new ProgramsAddOrUpdate("add", null);
                addOrUpdate.ShowDialog();


            }
        }

        private void cmbChannels_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gridPrograms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
