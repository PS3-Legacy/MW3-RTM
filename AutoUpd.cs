using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


    class AutoUpd
    {
        static WebClient Web = new WebClient();
        static string Dstr = "";
        public static string thisVerLbl;
        public static void ChForUpd(string currentVersion)
        {
            try
            {
                string[] GetInfo = (Web.DownloadString(Dstr).Split("|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries));
                decimal Nupd = decimal.Parse(GetInfo[0].Replace(".", ""), NumberStyles.Number);
                string NewUpdateInfo = GetInfo[0];
                string NewUpdate = NewUpdateInfo[0] + "." + NewUpdateInfo[2];
                    if (Nupd > decimal.Parse(currentVersion))
                    {
                        if (MessageBox.Show("New Update Available !!\nOld ver : " + currentVersion[0] + "." + currentVersion[1] + "\nNew ver : " + NewUpdate + "\n\nChangelog :\n" + GetInfo[1] + "\n\nWould you like to update ?", "New update", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                        {
                            SaveFileDialog SpF = new SaveFileDialog();
                            SpF.Filter = "rar File|*.rar";
                            SpF.FileName = "MW3 RTM " + NewUpdate;
                            SpF.Title = "MW3 RTM Tool";
                            if (SpF.ShowDialog() == DialogResult.OK)
                            {
                                Web.DownloadFile(GetInfo[2], SpF.FileName);
                                Process.Start(SpF.FileName);
                            }
                        }
                        else
                        {
                            MessageBox.Show("You Should Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("You Have latest version " + currentVersion[0] + "." + currentVersion[1],"MW3 RTM",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    }
                }
            catch 
            {
                MessageBox.Show("There Was an Error ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            thisVerLbl = currentVersion[0] + "." + currentVersion[1];
        }
    }

