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
    public partial class HostProgram : Form
    {
        public string OpType;
        public int? HostId;
        public HostProgram(string optype, int? hostid)
        {
            this.OpType = optype;
            this.HostId = hostid;
            InitializeComponent();
        }

        private void HostProgram_Load(object sender, EventArgs e)
        {
            gridHostProgram.AutoGenerateColumns = false;
            SqlPartController controller = new SqlPartController();
            gridHostProgram.DataSource = controller.GetHostProgram();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ShowAll shower = new ShowAll();
            this.Hide();
            shower.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index1 = gridHostProgram.SelectedRows[0].Index;
            int id1 = (int)gridHostProgram.Rows[index1].Cells["Id"].Value;
            int index2 = gridHostProgram.SelectedRows[0].Index;
            int id2 = (int)gridHostProgram.Rows[index2].Cells["ProgramId"].Value;
            SqlPartController controller = new SqlPartController();
            controller.DeleteHostProgram(id1,id2);
            gridHostProgram.Rows.RemoveAt(index1);
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            int count = gridHostProgram.SelectedRows.Count;
            if (count > 0)
            {
                int index1 = gridHostProgram.SelectedRows[0].Index;
                int id1 = (int)gridHostProgram.Rows[index1].Cells["Id"].Value;
                int index2 = gridHostProgram.SelectedRows[0].Index;
                int id2 = (int)gridHostProgram.Rows[index2].Cells["ProgramId"].Value;
                HostProgramAddUpdate addorupdate = new HostProgramAddUpdate("update",id1,id2);
                addorupdate.ShowDialog();

            }
            else
            {
                HostProgramAddUpdate addorupdate = new HostProgramAddUpdate("add", null,null);
                addorupdate.ShowDialog();

            }
        }
    }
}
