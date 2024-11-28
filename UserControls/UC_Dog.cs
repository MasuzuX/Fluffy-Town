using Fluffy_Town.UserControls.PetProfiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fluffy_Town.UserControls
{
    public partial class UC_Dog : UserControl
    {
        public UC_Dog()
        {
            InitializeComponent();
            Load += UC_Dog_Load;
        }

        private void UC_Dog_Load(object sender, EventArgs e)
        {
            brownyHeart.Visible = Properties.Settings.Default.fBrowny;
            bruceHeart.Visible = Properties.Settings.Default.fBruce;
            cliffordHeart.Visible = Properties.Settings.Default.fClifford;
            kurtHeart.Visible = Properties.Settings.Default.fKurt;
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void allButton_Click(object sender, EventArgs e)
        {
            UC_Pets uc = new UC_Pets();
            addUserControl(uc);
        }

        private void catButton_Click(object sender, EventArgs e)
        {
            UC_Cat uc = new UC_Cat();
            addUserControl(uc);
        }

        private void Bruce_Click(object sender, EventArgs e)
        {
            Bruce_Profile uc = new Bruce_Profile();
            addUserControl(uc);
        }

        private void Browny_Click(object sender, EventArgs e)
        {
            Browny_Profile uc = new Browny_Profile();
            addUserControl(uc);
        }

        private void Kurt_Click(object sender, EventArgs e)
        {
            Kurt_Profile uc = new Kurt_Profile();
            addUserControl(uc);
        }

        private void Clifford_Click(object sender, EventArgs e)
        {
            Clifford_Profile uc = new Clifford_Profile();
            addUserControl(uc);
        }
    }
}
