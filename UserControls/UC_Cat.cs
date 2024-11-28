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
    public partial class UC_Cat : UserControl
    {
        public UC_Cat()
        {
            InitializeComponent();
            Load += UC_Cat_Load;
        }

        private void UC_Cat_Load(object sender, EventArgs e)
        {
            BonitaHeart.Visible = Properties.Settings.Default.fBonita;
            GigiHeart.Visible = Properties.Settings.Default.fGigi;
            LornaHeart.Visible = Properties.Settings.Default.fLorna;
            poppyHeart.Visible = Properties.Settings.Default.fPoppy;
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

        private void dogButton_Click(object sender, EventArgs e)
        {
            UC_Dog uc = new UC_Dog();
            addUserControl(uc);
        }

        private void Lorna_Click(object sender, EventArgs e)
        {
            Lorna_Profile uc = new Lorna_Profile();
            addUserControl(uc);
        }

        private void Gigi_Click(object sender, EventArgs e)
        {
            Gigi_Profile uc = new Gigi_Profile();
            addUserControl(uc);
        }

        private void Bonita_Click(object sender, EventArgs e)
        {
            Bonita_Profile uc = new Bonita_Profile();
            addUserControl(uc);
        }

        private void Poppy_Click(object sender, EventArgs e)
        {
            Poppy_Profile uc = new Poppy_Profile();
            addUserControl(uc);
        }
    }
}
