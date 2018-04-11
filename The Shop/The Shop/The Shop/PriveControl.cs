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
    public partial class PriveControl : UserControl
    {
        //start here
        private static PriveControl instance;
        public static PriveControl Instance
        {
            get
            {
                if (instance == null)
                    instance = new PriveControl();
                return instance;
            }
        }
        //end here
        public PriveControl()
        {
            InitializeComponent();
        }
    }
}
