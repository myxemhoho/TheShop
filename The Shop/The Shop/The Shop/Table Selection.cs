using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Shop
{
    public partial class Table_Selection : Form
    {
        public Table_Selection()
        {
            InitializeComponent();
        }

        private void btnMainPit_Click(object sender, EventArgs e)
        {
            //begin if statement
            if (!panelMain.Controls.Contains(MainPitControl.Instance))
            {
                panelMain.Controls.Add(MainPitControl.Instance);
                MainPitControl.Instance.Dock = DockStyle.Fill;
                MainPitControl.Instance.BringToFront();
            }
            else
                MainPitControl.Instance.BringToFront();
           //end if statement
        }

        private void btnPrive_Click(object sender, EventArgs e)
        {
            //begin if statement
            if (!panelMain.Controls.Contains(PriveControl.Instance))
            {
                panelMain.Controls.Add(PriveControl.Instance);
                PriveControl.Instance.Dock = DockStyle.Fill;
                PriveControl.Instance.BringToFront();
            }
            else
                PriveControl.Instance.BringToFront();
            //end if statement
        }

        private void btnSlots_Click(object sender, EventArgs e)
        {
            //begin if statement
            if (!panelMain.Controls.Contains(SlotsControl.Instance))
            {
                panelMain.Controls.Add(SlotsControl.Instance);
                SlotsControl.Instance.Dock = DockStyle.Fill;
                SlotsControl.Instance.BringToFront();
            }
            else
                SlotsControl.Instance.BringToFront();
            //end if statement
        }

        private void btnBingo_Click(object sender, EventArgs e)
        {
            //begin if statement
            if (!panelMain.Controls.Contains(BingoControl.Instance))
            {
                panelMain.Controls.Add(BingoControl.Instance);
                BingoControl.Instance.Dock = DockStyle.Fill;
                BingoControl.Instance.BringToFront();
            }
            else
                BingoControl.Instance.BringToFront();
            //end if statement
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            //begin if statement
            if (!panelMain.Controls.Contains(StaffControl.Instance))
            {
                panelMain.Controls.Add(StaffControl.Instance);
                StaffControl.Instance.Dock = DockStyle.Fill;
                StaffControl.Instance.BringToFront();
            }
            else
                StaffControl.Instance.BringToFront();
            //end if statement
        }
    }
}
