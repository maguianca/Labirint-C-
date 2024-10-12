using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_game
{
    public partial class Generic : Form
    {
        public Generic()
        {
            InitializeComponent();
        }

        private void Generic_Load(object sender, EventArgs e)
        {
            
        }

        private void start_Click(object sender, EventArgs e)
        {
              Form x = new Form1();
              this.Visible = false;
              x.ShowDialog();
           
               
        }

        
    }
}
