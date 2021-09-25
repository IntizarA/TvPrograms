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
    public partial class ShowAllTabs : Form
    {
        public ShowAllTabs()
        {
            InitializeComponent();
        }

        private void gridChannels_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowAllTabs_Load(object sender, EventArgs e)
        {
            //Channels
            SqlPartController controller = new SqlPartController();

            gridChannels.DataSource = controller.GetChannels();


            //Programs

            //GetProgramData
            controller = new SqlPartController();
            gridPrograms.DataSource = controller.GetPrograms();
            //GetChannelData
            cmbChannels.DataSource = controller.GetChannels();
            cmbChannels.ValueMember = "ChannelId";
            cmbChannels.DisplayMember = "ChannelName";



            //Hostes
            controller = new SqlPartController();
            gridHostes.DataSource = controller.GetHostes();

            //HostProgram

            controller = new SqlPartController();
            gridHostProgram.DataSource = controller.GetHostProgram();



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

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void Show_Click(object sender, EventArgs e)
        {

        }



        private void btnSelect_Click(object sender, EventArgs e)
        {

        }

        private void Programs_Click(object sender, EventArgs e)
        {


        }

        private void btnSelect_Click_1(object sender, EventArgs e)
        {

            //int id = (int)cmbChannels.SelectedValue;
            //SqlPartController controller = new SqlPartController();
            //gridPrograms.DataSource = controller.GetByChannelId(id);
        }

        private void btnAddOrUpdate_Click(object sender, EventArgs e)
        {
            int count = gridPrograms.SelectedRows.Count;

            if (count > 0)
            {
                int index = gridPrograms.SelectedRows[0].Index;
                int programId = (int)gridPrograms.Rows[index].Cells["ProgramId"].Value;
                ProgramsAddOrUpdate addOrUpdate = new ProgramsAddOrUpdate("update", programId);
                addOrUpdate.ShowDialog();
                SqlPartController controller = new SqlPartController();
                gridPrograms.DataSource = controller.GetPrograms();

            }

            else
            {
                ProgramsAddOrUpdate addOrUpdate = new ProgramsAddOrUpdate("add", null);
                addOrUpdate.ShowDialog();
                SqlPartController controller = new SqlPartController();
                gridPrograms.DataSource = controller.GetPrograms();

            }
        }

        private void btnDeletePr_Click(object sender, EventArgs e)
        {
            SqlPartController controller = new SqlPartController();
            int index = gridPrograms.SelectedRows[0].Index;
            int id = (int)gridPrograms.Rows[index].Cells["ProgramId"].Value;
            controller.DeleteProgram(id);
            gridPrograms.Rows.RemoveAt(index);
            controller.DeleteHostProgramIfProgramDelete(id);
            gridHostProgram.DataSource = controller.GetHostProgram();

        }

        private void Channels_Click(object sender, EventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            int count = gridHostes.SelectedRows.Count;
            if (count > 0)
            {
                int index = gridHostes.SelectedRows[0].Index;
                int id = (int)gridHostes.Rows[index].Cells["HostId"].Value;
                HostesAddOrUpdate addOrUpdate = new HostesAddOrUpdate("update", id);
                addOrUpdate.ShowDialog();
                SqlPartController controller = new SqlPartController();
                gridHostes.DataSource = controller.GetHostes();
            }
            else
            {
                SqlPartController controller = new SqlPartController();
                HostesAddOrUpdate addOrUpdate = new HostesAddOrUpdate("add", null);
                addOrUpdate.ShowDialog();
                gridHostes.DataSource = controller.GetHostes();
            }
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            int index = gridHostes.SelectedRows[0].Index;
            int id = (int)gridHostes.Rows[index].Cells["HostId"].Value;
            SqlPartController controller = new SqlPartController();
            controller.DeleteHost(id);
            gridHostes.Rows.RemoveAt(index);
        }

        private void buttonAddUpdate_Click(object sender, EventArgs e)
        {
            SqlPartController controller = new SqlPartController();
            int count = gridChannels.SelectedRows.Count;
            if (count > 0)
            {
                int index = gridChannels.SelectedRows[0].Index;
                int id = (int)gridChannels.Rows[index].Cells["ChannelId"].Value;
                string channelName = gridChannels.Rows[index].Cells["ChannelName"].Value.ToString();
                ChannelAddOrUpdate addupdate = new ChannelAddOrUpdate("update", id);
                addupdate.ShowDialog();
                gridChannels.DataSource = controller.GetChannels();

            }
            else
            {
                ChannelAddOrUpdate addupdate = new ChannelAddOrUpdate("add", null);
                addupdate.ShowDialog();
                gridChannels.DataSource = controller.GetChannels();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = gridChannels.SelectedRows[0].Index;
            int id = (int)gridChannels.Rows[index].Cells["ChannelId"].Value;
            SqlPartController controller = new SqlPartController();
            controller.DeleteChannel(id);
            gridChannels.Rows.RemoveAt(index);
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void btnUptAdd_Click(object sender, EventArgs e)
        {
            int count = gridHostProgram.SelectedRows.Count;
            if (count > 0)
            {
                SqlPartController controller = new SqlPartController();

                int index1 = gridHostProgram.SelectedRows[0].Index;
                int id1 = (int)gridHostProgram.Rows[index1].Cells["Id"].Value;
                int index2 = gridHostProgram.SelectedRows[0].Index;
                int id2 = (int)gridHostProgram.Rows[index2].Cells["PrId"].Value;
                HostProgramAddUpdate addorupdate = new HostProgramAddUpdate("update", id1, id2);
                addorupdate.ShowDialog();
                gridHostProgram.DataSource = controller.GetHostProgram();

            }
            else
            {
                SqlPartController controller = new SqlPartController();

                HostProgramAddUpdate addorupdate = new HostProgramAddUpdate("add", null, null);
                addorupdate.ShowDialog();
                gridHostProgram.DataSource = controller.GetHostProgram();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int index1 = gridHostProgram.SelectedRows[0].Index;
            int id1 = (int)gridHostProgram.Rows[index1].Cells["Id"].Value;
            int index2 = gridHostProgram.SelectedRows[0].Index;
            int id2 = (int)gridHostProgram.Rows[index2].Cells["PrId"].Value;
            SqlPartController controller = new SqlPartController();
            controller.DeleteHostProgram(id1, id2);
            gridHostProgram.Rows.RemoveAt(index1);
        }

        private void cmbChannels_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbChannels_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void cmbChannels_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbChannels_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int id = (int)cmbChannels.SelectedValue;
            SqlPartController controller = new SqlPartController();
            gridPrograms.DataSource = controller.GetByChannelId(id);
        }

        private void Hostes_Click(object sender, EventArgs e)
        {

        }

        private void TemporaryButton_Click(object sender, EventArgs e)
        {


        }

        private void gridHostes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridHostes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = gridHostes.SelectedRows[0].Index;
            int hostId = (int)gridHostes.Rows[index].Cells["HostId"].Value;
            int hostAge = (int)gridHostes.Rows[index].Cells["HostAge"].Value;
            string hostName = gridHostes.Rows[index].Cells["HostName"].Value.ToString();
            string hostSurname = gridHostes.Rows[index].Cells["HostSurname"].Value.ToString();
            ShowPicture pic = new ShowPicture(hostId, hostName, hostSurname, hostAge);
            pic.ShowDialog();
        }

        private void gridChannels_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int count = gridChannels.SelectedRows.Count;
            Channel channel = new Channel();
            int index = gridChannels.SelectedRows[0].Index;
            int channelid = (int)gridChannels.Rows[index].Cells["ChannelId"].Value;

            if (count > 0)
            {
                ShowChannelInfo info = new ShowChannelInfo(channelid);
                info.ShowDialog();
            }
            else
            {
                MessageBox.Show("select a channel");
            }
        }
    }
}
