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
    public partial class BingoControl : UserControl
    {

        //start here
        private static BingoControl instance;
        public static BingoControl Instance
        {
            get
            {
                if (instance == null)
                    instance = new BingoControl();
                return instance;
            }
        }
        //end here
        public BingoControl()
        {
            InitializeComponent();
        }
    }
}
