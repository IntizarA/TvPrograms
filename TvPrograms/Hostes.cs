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
    public partial class Hostes : Form
    {
        public Hostes()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ShowAll shower = new ShowAll();
            this.Hide();
            shower.ShowDialog();
        }

        private void Hostes_Load(object sender, EventArgs e)
        {
            SqlPartController controller = new SqlPartController();
            gridHostes.DataSource = controller.GetHostes();



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index = gridHostes.SelectedRows[0].Index;
            int id = (int)gridHostes.Rows[index].Cells["HostId"].Value;
            SqlPartController controller = new SqlPartController();
            controller.DeleteHost(id);
            gridHostes.Rows.RemoveAt(index);
        }

        private void btnAddOrUpdate_Click(object sender, EventArgs e)
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

       
    }
}
