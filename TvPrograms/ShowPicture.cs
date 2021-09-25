using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TvPrograms
{
    public partial class ShowPicture : Form
    {
        public int HostId;
        public string HostName;
        public string Surname;
        public int Age;
        public ShowPicture()
        {
            InitializeComponent();
        }
        public ShowPicture(int hostId,string name,string surname,int age )
        {
            this.HostId = hostId;
            this.HostName = name;
            this.Surname = surname;
            this.Age = age;
            InitializeComponent();
        }

        private void ShowPicture_Load(object sender, EventArgs e)
        {
            SqlPartController controller = new SqlPartController();
            string filePath = controller.GetHostPicture(HostId);
            hostPicture.Image = Image.FromFile(filePath);
            hostPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            lblNameText.Text = HostName;
            lblSurnameText.Text = Surname;
            lblAgeText.Text = Age.ToString();
        }
    }
}
