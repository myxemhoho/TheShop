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
    public partial class AddonControl : UserControl
    {
        //start here
        private static AddonControl instance;
        public static AddonControl Instance
        {
            get
            {
                if (instance == null)
                    instance = new AddonControl();
                return instance;
            }
        }
        //end here

        public AddonControl()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
