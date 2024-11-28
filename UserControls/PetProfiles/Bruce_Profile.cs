using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fluffy_Town.UserControls.PetProfiles
{
    public partial class Bruce_Profile : UserControl
    {
        public Bruce_Profile()
        {
            InitializeComponent();
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Pet_Form_Page1 uc = new Pet_Form_Page1();
            addUserControl(uc);
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            UC_Pets uc = new UC_Pets();
            addUserControl(uc);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.fBruce = false;
            Properties.Settings.Default.Save();


            FavoritoAlert elpaborfavorito = new FavoritoAlert();
            elpaborfavorito.Show();


            UC_Pets uc = new UC_Pets();
            addUserControl(uc);
        }
    }
}
