using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Search:" + txtSearch.Text);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Profile");
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cart");
        }
    }
}
