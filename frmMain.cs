using PS3Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MW3_Tool_By_BISOON
{
    public partial class frmMain : Form
    {
        public static PS3API PS3 = new PS3API();
        string thisver = "11";
        public frmMain()
        {
            InitializeComponent();
            verLbl.Text = "Ver : " + thisver[0] + "." + thisver[1];
        }

        private void connectCex_Click(object sender, EventArgs e)
        {
            PS3.ChangeAPI(SelectAPI.ControlConsole);
            if (connectCex.Text == "Connect [ CEX ]")
            {
                if (PS3.ConnectTarget())
                {
                    flatLabel2.ForeColor = Color.White;
                    flatLabel2.Text = "Connected";
                    connectCex.Text = "Attach";
                }
                else
                {
                    flatLabel2.Text = "Can't Connect";
                    flatLabel2.ForeColor = Color.Red;
                }
            }
            else if (connectCex.Text == "Attach")
            {
                if (PS3.AttachProcess())
                {
                    flatLabel3.ForeColor = Color.White;
                    flatLabel3.Text = "Attached";
                    RPC.Enable();
                }
                else
                {
                    flatLabel3.Text = "Can't Attach";
                    flatLabel3.ForeColor = Color.Red;
                }
            }
        }
        private void connectDex_Click(object sender, EventArgs e)
        {
            if (connectDex.Text == "Connect [ DEX ]")
            {
                if (PS3.ConnectTarget())
                {
                    flatLabel2.ForeColor = Color.White;
                    flatLabel2.Text = "Connected";
                    connectDex.Text = "Attach";
                }
                else
                {
                    flatLabel2.Text = "Can't Connect";
                    flatLabel2.ForeColor = Color.Red;
                }
            }
            else if (connectDex.Text == "Attach")
            {
                if (PS3.AttachProcess())
                {
                    flatLabel3.ForeColor = Color.White;
                    flatLabel3.Text = "Attached";
                    RPC.Enable();
                }
                else
                {
                    flatLabel3.Text = "Can't Attach";
                    flatLabel3.ForeColor = Color.Red;
                }
            }
        }

        private void rtmFrm_Click(object sender, EventArgs e)
        {
            frmRTM frm2 = new frmRTM();
            frm2.Show();
        }

        private void check4Upd_Click(object sender, EventArgs e)
        {
            AutoUpd.ChForUpd(thisver);
        }
    }
}
