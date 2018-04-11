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
    public partial class StaffControl : UserControl
    {

        //start here
        private static StaffControl instance;
        public static StaffControl Instance
        {
            get
            {
                if (instance == null)
                    instance = new StaffControl();
                return instance;
            }
        }
        //end here
        public StaffControl()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
