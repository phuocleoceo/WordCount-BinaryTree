using System;
using System.Windows.Forms;

namespace CountWord
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }        
        private void btncontinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main a = new Main();
            a.Closed += (s, args) => this.Close();
            a.Show();           
        }
        
    }
}
