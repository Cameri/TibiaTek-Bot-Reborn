using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TibiaTekBot
{
    public partial class MainForm : Form
    {
        Kernel kernel;

        public MainForm()
        {
            kernel = new Kernel();
            kernel.Start();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //mmg funciona
            MessageBox.Show(String.Format("{0:X}", kernel.Client.LocalPlayer.ID));
            
            BattleList bl = kernel.Client.GetBattlelist();
            MessageBox.Show(bl.BattlelistBegin.ToString());
            bl.Reset();
            int c = 0;
            do
            {
                MessageBox.Show(String.Format("{0:X} {1}", bl.ID, bl.Name));
                c++;
            } while (bl.Next() && c < 5);

            //MessageBox.Show(String.Format("{0:X} {1:X} {2:X}", kernel.Client.LocalPlayer.debug[0], kernel.Client.LocalPlayer.debug[1], kernel.Client.LocalPlayer.debug[2]));
        }

        private void ExpCheckerTrigger_CheckedChanged(object sender, EventArgs e)
        {
            kernel.ExperienceChecker.Active = ((CheckBox)sender).Checked;
        }
    }
}
