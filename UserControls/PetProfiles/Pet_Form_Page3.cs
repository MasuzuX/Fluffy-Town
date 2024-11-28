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
    public partial class Pet_Form_Page3 : UserControl
    {
        public Pet_Form_Page3()
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
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //next
            // walapa
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //back
            Pet_Form_Page2 uc = new Pet_Form_Page2();
            addUserControl(uc);
        }
    }
}
