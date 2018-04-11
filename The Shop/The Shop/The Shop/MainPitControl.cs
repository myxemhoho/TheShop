using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Shop
{
    public partial class MainPitControl : UserControl
    {
        //start here
        private static MainPitControl instance;
        public static MainPitControl Instance
        {
            get
            {
                if (instance == null)
                    instance = new MainPitControl();
                return instance;
            }
        }
        //end here
        public MainPitControl()
        {
            InitializeComponent();
        }

        private void btnCraps_Click(object sender, EventArgs e)
        {
            Item_Order io = new Item_Order();
            io.Show();

        }
    }
}
