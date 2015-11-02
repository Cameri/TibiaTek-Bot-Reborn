using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TibiaTekBot
{
    public partial class HelerForm : Form
    {
        public Tibia client;
        public HelerForm(Tibia client)
        {
            this.client = client;
            InitializeComponent();
        }

        private void HelerForm_Load(object sender, EventArgs e)
        {

        }

        private void HideButtom_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
