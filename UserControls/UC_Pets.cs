using Fluffy_Town.UserControls.PetProfiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;

namespace Fluffy_Town.UserControls
{
    public partial class UC_Pets : UserControl
    {
        UC_Dog dog = new UC_Dog();
        UC_Cat cat = new UC_Cat();

        public UC_Pets()
        {
            InitializeComponent();

            Load += UC_Pets_Load;
            

        }

        private void UC_Pets_Load(object sender, EventArgs e)
        {

            //add to favorite 
            BonitaHeart.Visible = Properties.Settings.Default.fBonita;
            brownyHeart.Visible = Properties.Settings.Default.fBrowny;
            bruceHeart.Visible = Properties.Settings.Default.fBruce;
            cliffordHeart.Visible = Properties.Settings.Default.fClifford;
            GigiHeart.Visible = Properties.Settings.Default.fGigi;
            kurtHeart.Visible = Properties.Settings.Default.fKurt;
            LornaHeart.Visible = Properties.Settings.Default.fLorna;
            poppyHeart.Visible = Properties.Settings.Default.fPoppy;

            //reserved


        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void dogButton_Click(object sender, EventArgs e)
        {
            UC_Dog uc = new UC_Dog();
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

        private void Bonita_Click(object sender, EventArgs e)
        {
            Bonita_Profile uc = new Bonita_Profile();
            addUserControl(uc);
        }

        private void Clifford_Click(object sender, EventArgs e)
        {
            Clifford_Profile uc = new Clifford_Profile();
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

        private void Kurt_Click(object sender, EventArgs e)
        {
            Kurt_Profile uc = new Kurt_Profile();
            addUserControl(uc);
        }

        private void Poppy_Click(object sender, EventArgs e)
        {
            Poppy_Profile uc = new Poppy_Profile();
            addUserControl(uc);
        }
    }
}
    