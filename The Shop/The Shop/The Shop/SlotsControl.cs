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
    public partial class SlotsControl : UserControl
    {
        //start here
        private static SlotsControl instance;
        public static SlotsControl Instance
        {
            get
            {
                if (instance == null)
                    instance = new SlotsControl();
                return instance;
            }
        }
        //end here
        public SlotsControl()
        {
            InitializeComponent();
        }
    }
}
