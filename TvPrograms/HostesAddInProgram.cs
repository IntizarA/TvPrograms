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
    public partial class HostesAddInProgram : Form
    {
        public string OpType;
        public int? HostId;
        public HostesAddInProgram(string optype, int? hostid)
        {
            this.OpType = optype;
            this.HostId = hostid;
            InitializeComponent();
        }

        private void HostesAddInProgram_Load(object sender, EventArgs e)
        {
            SqlPartController controller = new SqlPartController();
            cmbHostNames.DataSource = controller.GetHostes();
            cmbHostNames.DisplayMember = "HostName";
            cmbHostNames.ValueMember = "HostId";

            cmbProgramNames.DataSource = controller.GetPrograms();
            cmbProgramNames.DisplayMember = "ProgramName";
            cmbProgramNames.ValueMember = "ProgramId";
        }
    }
}
