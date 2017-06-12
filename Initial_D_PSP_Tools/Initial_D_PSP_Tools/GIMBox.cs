using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Initial_D_PSP_Tools
{
    public partial class GIMBox : Form
    {
        public GIMBox(Image image)
        {
            InitializeComponent();
            this.gimPicture.Image = image;
            this.Size = new Size(Convert.ToInt32(image.Width * 1.5), Convert.ToInt32(image.Height * 1.5));

        }

        private void gimPicture_Click(object sender, EventArgs e)
        {

        }
    }
}
