using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MW3_Tool_By_BISOON
{
    public partial class frmRTM : Form
    {
        byte[] LocationBytes;
        public frmRTM()
        {
            InitializeComponent();
        }

        private void flatButton14_Click(object sender, EventArgs e)
        {
            MW3.ClassNmae((int)classNum.Value - 1, classBox.Text);
        }

        private void flatNumeric14_Click(object sender, EventArgs e)
        {

        }

        private void flatButton15_Click(object sender, EventArgs e)
        {
            for (int bis = 0; bis < 20; bis++)
            MW3.ClassNmae((int)bis, classBox.Text);
        }
        #region Stats
        private void flatButton1_Click(object sender, EventArgs e)
        {
            byte[] prestigeNum = BitConverter.GetBytes(Convert.ToInt32(this.prestigeNum.Value));
            frmMain.PS3.SetMemory(0x01C1947C, prestigeNum);
        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            if (levelNum.Value == 1)
            {
                byte[] prestigeNum = BitConverter.GetBytes(Convert.ToInt32(0));
                frmMain.PS3.SetMemory(0x01C1926C, prestigeNum);
            }
            else if (levelNum.Value >= 2)
            {
                MW3.SetXP((int)levelNum.Value);
            }
        }

        private void flatButton3_Click(object sender, EventArgs e)
        {
            byte[] prestigeNum = BitConverter.GetBytes(Convert.ToInt32(scoreNum.Value));
            frmMain.PS3.SetMemory(0x01C19484, prestigeNum);
        }

        private void flatButton4_Click(object sender, EventArgs e)
        {
            byte[] prestigeNum = BitConverter.GetBytes(Convert.ToInt32(killsNum.Value));
            frmMain.PS3.SetMemory(0x01C194AC, prestigeNum);
        }

        private void flatButton5_Click(object sender, EventArgs e)
        {
            byte[] prestigeNum = BitConverter.GetBytes(Convert.ToInt32(deathsNum.Value));
            frmMain.PS3.SetMemory(0x01C194B4, prestigeNum);
        }

        private void flatButton6_Click(object sender, EventArgs e)
        {
            byte[] prestigeNum = BitConverter.GetBytes(Convert.ToInt32(winsNum.Value));
            frmMain.PS3.SetMemory(0x01C194E0, prestigeNum);
        }

        private void flatButton7_Click(object sender, EventArgs e)
        {
            byte[] prestigeNum = BitConverter.GetBytes(Convert.ToInt32(lossesNum.Value));
            frmMain.PS3.SetMemory(0x01C194E4, prestigeNum);
        }

        private void flatButton8_Click(object sender, EventArgs e)
        {
            byte[] prestigeNum = BitConverter.GetBytes(Convert.ToInt32(tiesNum.Value));
            frmMain.PS3.SetMemory(0x01C194E8, prestigeNum);
        }

        private void flatButton9_Click(object sender, EventArgs e)
        {
            byte[] prestigeNum = BitConverter.GetBytes(Convert.ToInt32(winstreakNum.Value));
            frmMain.PS3.SetMemory(0x01C194EC, prestigeNum);
        }

        private void flatButton10_Click(object sender, EventArgs e)
        {
            byte[] prestigeNum = BitConverter.GetBytes(Convert.ToInt32(killstreakNum.Value));
            frmMain.PS3.SetMemory(0x01C194B0, prestigeNum);
        }

        private void flatButton11_Click(object sender, EventArgs e)
        {
            byte[] prestigeNum = BitConverter.GetBytes(Convert.ToInt32(headshotsNum.Value));
            frmMain.PS3.SetMemory(0x01C194C0, prestigeNum);
        }

        private void flatButton12_Click(object sender, EventArgs e)
        {
            byte[] prestigeNum = BitConverter.GetBytes(Convert.ToInt32(hitsNum.Value));
            frmMain.PS3.SetMemory(0x01C194F8, prestigeNum);
        }

        private void flatButton13_Click(object sender, EventArgs e)
        {
            byte[] prestigeNum = BitConverter.GetBytes(Convert.ToInt32(missesNum.Value));
            frmMain.PS3.SetMemory(0x01C194FC, prestigeNum);
        }

        private void flatButton16_Click(object sender, EventArgs e)
        {
            byte[] prestigeNum = BitConverter.GetBytes(Convert.ToInt32(ratioNum.Value));
            frmMain.PS3.SetMemory(0x01C19500, prestigeNum);
        }

        private void flatButton17_Click(object sender, EventArgs e)
        {
            byte[] prestigeNum = BitConverter.GetBytes(Convert.ToInt32(accNum.Value));
            frmMain.PS3.SetMemory(0x01C19504, prestigeNum);
        }

        private void flatButton18_Click(object sender, EventArgs e)
        {
            byte[] prestigeNum = BitConverter.GetBytes(Convert.ToInt32(tokensNum.Value));
            frmMain.PS3.SetMemory(0x01C1B2DB, prestigeNum);
        }

        private void flatButton19_Click(object sender, EventArgs e)
        {
            byte[] prestigeNum = BitConverter.GetBytes(Convert.ToInt32(assistNum.Value));
            frmMain.PS3.SetMemory(0x01C194BC, prestigeNum);
        }

        private void flatButton20_Click(object sender, EventArgs e)
        {
            byte[] prestigeNum = BitConverter.GetBytes(Convert.ToInt32(dxpNum.Value));
            frmMain.PS3.SetMemory(0x01C1B331, prestigeNum);
        }

        private void flatButton21_Click(object sender, EventArgs e)
        {
            byte[] prestigeNum = BitConverter.GetBytes(Convert.ToInt32(dxpweaponNum.Value));
            frmMain.PS3.SetMemory(0x01C1B339, prestigeNum);
        }

        private void flatButton22_Click(object sender, EventArgs e)
        {
            byte[] prestigeNum = BitConverter.GetBytes(Convert.ToInt32(mwNum.Value));
            frmMain.PS3.SetMemory(0x01C1B376, prestigeNum);
        }

        private void flatButton23_Click(object sender, EventArgs e)
        {
            byte[] prestigeNum = BitConverter.GetBytes(Convert.ToInt32(wawNum.Value));
            frmMain.PS3.SetMemory(0x01C1B37B, prestigeNum);
        }
        

        private void flatButton24_Click(object sender, EventArgs e)
        {
            byte[] prestigeNum = BitConverter.GetBytes(Convert.ToInt32(mw2Num.Value));
            frmMain.PS3.SetMemory(0x01C1B381, prestigeNum);
        }

        private void flatButton25_Click(object sender, EventArgs e)
        {
            byte[] prestigeNum = BitConverter.GetBytes(Convert.ToInt32(boNum.Value));
            frmMain.PS3.SetMemory(0x01C1B388, prestigeNum);
        }

        private void flatButton26_Click(object sender, EventArgs e)
        {
            UnlockAll.Unlock_All();
        }
        private void flatButton27_Click(object sender, EventArgs e)
        {
            UnlockAll.Unlock_All();
        }

        private void flatButton28_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[]
			{
				0xFF
			};
            frmMain.PS3.SetMemory(29471468u, buffer);
        }
        #endregion

        private void flatButton30_Click(object sender, EventArgs e)
        {
            //MW3.ClassGodMode((int)classgodmodeNum.Value);
            MW3.GodModClass((int)classgodmodeNum.Value - 1);
            MW3.ClassNmae((int)classgodmodeNum.Value - 1, " ^5God Mode ^3Class");
        }
        #region  God Mod Clients
        private void flatCheckBox1_CheckedChanged(object sender)
        {
            if (flatCheckBox1.Checked)
            {
                MW3.GodMod(0, true);
            }
            else
            {
                MW3.GodMod(0, false);
            }
        }

        private void flatCheckBox2_CheckedChanged(object sender)
        {
            if (flatCheckBox2.Checked)
            {
                MW3.GodMod(1, true);
            }
            else
            {
                MW3.GodMod(1, false);
            }
        }

        private void flatCheckBox3_CheckedChanged(object sender)
        {
            if (flatCheckBox3.Checked)
            {
                MW3.GodMod(2, true);
            }
            else
            {
                MW3.GodMod(2, false);
            }
        }

        private void flatCheckBox4_CheckedChanged(object sender)
        {
            if (flatCheckBox4.Checked)
            {
                MW3.GodMod(3, true);
            }
            else
            {
                MW3.GodMod(3, false);
            }
        }

        private void flatCheckBox5_CheckedChanged(object sender)
        {
            if (flatCheckBox5.Checked)
            {
                MW3.GodMod(4, true);
            }
            else
            {
                MW3.GodMod(4, false);
            }
        }

        private void flatCheckBox6_CheckedChanged(object sender)
        {
            if (flatCheckBox6.Checked)
            {
                MW3.GodMod(5, true);
            }
            else
            {
                MW3.GodMod(5, false);
            }
        }

        private void flatCheckBox7_CheckedChanged(object sender)
        {
            if (flatCheckBox7.Checked)
            {
                MW3.GodMod(6, true);
            }
            else
            {
                MW3.GodMod(6, false);
            }
        }

        private void flatCheckBox8_CheckedChanged(object sender)
        {
            if (flatCheckBox8.Checked)
            {
                MW3.GodMod(7, true);
            }
            else
            {
                MW3.GodMod(7, false);
            }
        }

        private void flatCheckBox9_CheckedChanged(object sender)
        {
            if (flatCheckBox9.Checked)
            {
                MW3.GodMod(8, true);
            }
            else
            {
                MW3.GodMod(8, false);
            }
        }

        private void flatCheckBox10_CheckedChanged(object sender)
        {
            if (flatCheckBox10.Checked)
            {
                MW3.GodMod(9, true);
            }
            else
            {
                MW3.GodMod(9, false);
            }
        }

        private void flatCheckBox11_CheckedChanged(object sender)
        {
            if (flatCheckBox11.Checked)
            {
                MW3.GodMod(10, true);
            }
            else
            {
                MW3.GodMod(10, false);
            }
        }

        private void flatCheckBox12_CheckedChanged(object sender)
        {
            if (flatCheckBox12.Checked)
            {
                MW3.GodMod(11, true);
            }
            else
            {
                MW3.GodMod(11, false);
            }
        }
        #endregion

        #region Ammo
        private void flatCheckBox24_CheckedChanged(object sender)
        {
            MW3.WeaponAmmo(0);
        }

        private void flatCheckBox23_CheckedChanged(object sender)
        {
            MW3.WeaponAmmo(1);
        }

        private void flatCheckBox22_CheckedChanged(object sender)
        {
            MW3.WeaponAmmo(2);
        }

        private void flatCheckBox21_CheckedChanged(object sender)
        {
            MW3.WeaponAmmo(3);
        }

        private void flatCheckBox20_CheckedChanged(object sender)
        {
            MW3.WeaponAmmo(4);
        }

        private void flatCheckBox19_CheckedChanged(object sender)
        {
            MW3.WeaponAmmo(5);
        }

        private void flatCheckBox18_CheckedChanged(object sender)
        {
            MW3.WeaponAmmo(6);
        }

        private void flatCheckBox17_CheckedChanged(object sender)
        {
            MW3.WeaponAmmo(7);
        }

        private void flatCheckBox16_CheckedChanged(object sender)
        {
            MW3.WeaponAmmo(8);
        }

        private void flatCheckBox15_CheckedChanged(object sender)
        {
            MW3.WeaponAmmo(9);
        }

        private void flatCheckBox14_CheckedChanged(object sender)
        {
            MW3.WeaponAmmo(10);
        }

        private void flatCheckBox13_CheckedChanged(object sender)
        {
            MW3.WeaponAmmo(11);
        }
        #endregion

        #region RedBox
        private void flatCheckBox36_CheckedChanged(object sender)
        {
            if (flatCheckBox36.Checked)
            {
                MW3.REDBOXK(0, true);
            }
            else
            {
                MW3.REDBOXK(0, false);
            }
        }

        private void flatCheckBox35_CheckedChanged(object sender)
        {
            if (flatCheckBox35.Checked)
            {
                MW3.REDBOXK(1, true);
            }
            else
            {
                MW3.REDBOXK(1, false);
            }
        }

        private void flatCheckBox34_CheckedChanged(object sender)
        {
            if (flatCheckBox34.Checked)
            {
                MW3.REDBOXK(2, true);
            }
            else
            {
                MW3.REDBOXK(2, false);
            }
        }

        private void flatCheckBox33_CheckedChanged(object sender)
        {
            if (flatCheckBox33.Checked)
            {
                MW3.REDBOXK(3, true);
            }
            else
            {
                MW3.REDBOXK(3, false);
            }
        }

        private void flatCheckBox32_CheckedChanged(object sender)
        {
            if (flatCheckBox32.Checked)
            {
                MW3.REDBOXK(4, true);
            }
            else
            {
                MW3.REDBOXK(4, false);
            }
        }

        private void flatCheckBox31_CheckedChanged(object sender)
        {
            if (flatCheckBox31.Checked)
            {
                MW3.REDBOXK(5, true);
            }
            else
            {
                MW3.REDBOXK(5, false);
            }
        }

        private void flatCheckBox30_CheckedChanged(object sender)
        {
            if (flatCheckBox30.Checked)
            {
                MW3.REDBOXK(6, true);
            }
            else
            {
                MW3.REDBOXK(6, false);
            }
        }

        private void flatCheckBox29_CheckedChanged(object sender)
        {
            if (flatCheckBox29.Checked)
            {
                MW3.REDBOXK(7, true);
            }
            else
            {
                MW3.REDBOXK(7, false);
            }
        }

        private void flatCheckBox28_CheckedChanged(object sender)
        {
            if (flatCheckBox28.Checked)
            {
                MW3.REDBOXK(8, true);
            }
            else
            {
                MW3.REDBOXK(8, false);
            }
        }

        private void flatCheckBox27_CheckedChanged(object sender)
        {
            if (flatCheckBox27.Checked)
            {
                MW3.REDBOXK(9, true);
            }
            else
            {
                MW3.REDBOXK(9, false);
            }
        }

        private void flatCheckBox26_CheckedChanged(object sender)
        {
            if (flatCheckBox26.Checked)
            {
                MW3.REDBOXK(10, true);
            }
            else
            {
                MW3.REDBOXK(10, false);

            }
        }

        private void flatCheckBox25_CheckedChanged(object sender)
        {
            if (flatCheckBox25.Checked)
            {
                MW3.REDBOXK(11, true);
            }
            else
            {
                MW3.REDBOXK(11, false);
            }
        }
        #endregion

        #region UFO
        private void flatCheckBox48_CheckedChanged(object sender)
        {
            if (flatCheckBox48.Checked)
            {
                MW3.UFO(0, true);
            }
            else
            {
                MW3.UFO(0, false);
            }
        }

        private void flatCheckBox47_CheckedChanged(object sender)
        {
            if (flatCheckBox47.Checked)
            {
                MW3.UFO(1, true);
            }
            else
            {
                MW3.UFO(1, false);
            }
        }

        private void flatCheckBox46_CheckedChanged(object sender)
        {
            if (flatCheckBox46.Checked)
            {
                MW3.UFO(2, true);
            }
            else
            {
                MW3.UFO(2, false);
            }
        }

        private void flatCheckBox45_CheckedChanged(object sender)
        {
            if (flatCheckBox45.Checked)
            {
                MW3.UFO(3, true);
            }
            else
            {
                MW3.UFO(3, false);
            }
        }

        private void flatCheckBox44_CheckedChanged(object sender)
        {
            if (flatCheckBox44.Checked)
            {
                MW3.UFO(4, true);
            }
            else
            {
                MW3.UFO(4, false);
            }
        }

        private void flatCheckBox43_CheckedChanged(object sender)
        {
            if (flatCheckBox43.Checked)
            {
                MW3.UFO(5, true);
            }
            else
            {
                MW3.UFO(5, false);
            }
        }

        private void flatCheckBox42_CheckedChanged(object sender)
        {
            if (flatCheckBox42.Checked)
            {
                MW3.UFO(6, true);
            }
            else
            {
                MW3.UFO(6, false);
            }
        }

        private void flatCheckBox41_CheckedChanged(object sender)
        {
            if (flatCheckBox41.Checked)
            {
                MW3.UFO(7, true);
            }
            else
            {
                MW3.UFO(7, false);
            }
        }

        private void flatCheckBox40_CheckedChanged(object sender)
        {
            if (flatCheckBox40.Checked)
            {
                MW3.UFO(8, true);
            }
            else
            {
                MW3.UFO(8, false);
            }
        }

        private void flatCheckBox39_CheckedChanged(object sender)
        {
            if (flatCheckBox39.Checked)
            {
                MW3.UFO(9, true);
            }
            else
            {
                MW3.UFO(9, false);
            }
        }

        private void flatCheckBox38_CheckedChanged(object sender)
        {
            if (flatCheckBox38.Checked)
            {
                MW3.UFO(10, true);
            }
            else
            {
                MW3.UFO(10, false);
            }
        }

        private void flatCheckBox37_CheckedChanged(object sender)
        {
            if (flatCheckBox37.Checked)
            {
                MW3.UFO(11, true);
            }
            else
            {
                MW3.UFO(11, false);
            }
        }

        #endregion

        #region ExplosiveBullets
        private void flatCheckBox60_CheckedChanged(object sender)
        {
            if (flatCheckBox60.Checked)
            {
                MW3.ExplosiveBullets(0, true);
            }
            else
            {
                MW3.ExplosiveBullets(0, false);
            }
        }

        private void flatCheckBox59_CheckedChanged(object sender)
        {
            if (flatCheckBox59.Checked)
            {
                MW3.ExplosiveBullets(1, true);
            }
            else
            {
                MW3.ExplosiveBullets(1, false);
            }
        }

        private void flatCheckBox58_CheckedChanged(object sender)
        {
            if (flatCheckBox58.Checked)
            {
                MW3.ExplosiveBullets(2, true);
            }
            else
            {
                MW3.ExplosiveBullets(2, false);
            }
        }

        private void flatCheckBox57_CheckedChanged(object sender)
        {
            if (flatCheckBox57.Checked)
            {
                MW3.ExplosiveBullets(3, true);
            }
            else
            {
                MW3.ExplosiveBullets(3, false);
            }
        }

        private void flatCheckBox56_CheckedChanged(object sender)
        {
            if (flatCheckBox56.Checked)
            {
                MW3.ExplosiveBullets(4, true);
            }
            else
            {
                MW3.ExplosiveBullets(4, false);
            }
        }

        private void flatCheckBox55_CheckedChanged(object sender)
        {
            if (flatCheckBox55.Checked)
            {
                MW3.ExplosiveBullets(5, true);
            }
            else
            {
                MW3.ExplosiveBullets(5, false);
            }
        }

        private void flatCheckBox54_CheckedChanged(object sender)
        {
            if (flatCheckBox54.Checked)
            {
                MW3.ExplosiveBullets(6, true);
            }
            else
            {
                MW3.ExplosiveBullets(6, false);
            }
        }

        private void flatCheckBox53_CheckedChanged(object sender)
        {
            if (flatCheckBox53.Checked)
            {
                MW3.ExplosiveBullets(7, true);
            }
            else
            {
                MW3.ExplosiveBullets(7, false);
            }
        }

        private void flatCheckBox52_CheckedChanged(object sender)
        {
            if (flatCheckBox52.Checked)
            {
                MW3.ExplosiveBullets(8, true);
            }
            else
            {
                MW3.ExplosiveBullets(8, false);
            }
        }

        private void flatCheckBox51_CheckedChanged(object sender)
        {
            if (flatCheckBox51.Checked)
            {
                MW3.ExplosiveBullets(9, true);
            }
            else
            {
                MW3.ExplosiveBullets(9, false);
            }
        }

        private void flatCheckBox50_CheckedChanged(object sender)
        {
            if (flatCheckBox50.Checked)
            {
                MW3.ExplosiveBullets(10, true);
            }
            else
            {
                MW3.ExplosiveBullets(10, false);
            }
        }

        private void flatCheckBox49_CheckedChanged(object sender)
        {
            if (flatCheckBox49.Checked)
            {
                MW3.ExplosiveBullets(11, true);
            }
            else
            {
                MW3.ExplosiveBullets(11, false);
            }
        }
        #endregion

        #region DolphinDiv
        private void flatCheckBox72_CheckedChanged(object sender)
        {
            if (flatCheckBox72.Checked)
            {
                MW3.DolphinDiv(0, true);
            }
            else
            {
                MW3.DolphinDiv(0, false);
            }
        }

        private void flatCheckBox71_CheckedChanged(object sender)
        {
            if (flatCheckBox71.Checked)
            {
                MW3.DolphinDiv(1, true);
            }
            else
            {
                MW3.DolphinDiv(1, false);
            }
        }

        private void flatCheckBox70_CheckedChanged(object sender)
        {
            if (flatCheckBox70.Checked)
            {
                MW3.DolphinDiv(2, true);
            }
            else
            {
                MW3.DolphinDiv(2, false);
            }
        }

        private void flatCheckBox69_CheckedChanged(object sender)
        {
            if (flatCheckBox69.Checked)
            {
                MW3.DolphinDiv(3, true);
            }
            else
            {
                MW3.DolphinDiv(3, false);
            }
        }

        private void flatCheckBox68_CheckedChanged(object sender)
        {
            if (flatCheckBox68.Checked)
            {
                MW3.DolphinDiv(4, true);
            }
            else
            {
                MW3.DolphinDiv(4, false);
            }
        }

        private void flatCheckBox67_CheckedChanged(object sender)
        {
            if (flatCheckBox67.Checked)
            {
                MW3.DolphinDiv(5, true);
            }
            else
            {
                MW3.DolphinDiv(5, false);
            }
        }

        private void flatCheckBox66_CheckedChanged(object sender)
        {
            if (flatCheckBox66.Checked)
            {
                MW3.DolphinDiv(6, true);
            }
            else
            {
                MW3.DolphinDiv(6, false);
            }
        }

        private void flatCheckBox65_CheckedChanged(object sender)
        {
            if (flatCheckBox65.Checked)
            {
                MW3.DolphinDiv(7, true);
            }
            else
            {
                MW3.DolphinDiv(7, false);
            }
        }

        private void flatCheckBox64_CheckedChanged(object sender)
        {
            if (flatCheckBox64.Checked)
            {
                MW3.DolphinDiv(8, true);
            }
            else
            {
                MW3.DolphinDiv(8, false);
            }
        }

        private void flatCheckBox63_CheckedChanged(object sender)
        {
            if (flatCheckBox63.Checked)
            {
                MW3.DolphinDiv(9, true);
            }
            else
            {
                MW3.DolphinDiv(9, false);
            }
        }

        private void flatCheckBox62_CheckedChanged(object sender)
        {
            if (flatCheckBox62.Checked)
            {
                MW3.DolphinDiv(10, true);
            }
            else
            {
                MW3.DolphinDiv(10, false);
            }
        }

        private void flatCheckBox61_CheckedChanged(object sender)
        {
            if (flatCheckBox61.Checked)
            {
                MW3.DolphinDiv(11, true);
            }
            else
            {
                MW3.DolphinDiv(11, false);
            }
        }
        #endregion

        #region FreezePlayer
        private void flatCheckBox84_CheckedChanged(object sender)
        {
            if (flatCheckBox84.Checked)
            {
                MW3.FREEZEPLAYER(0, true);
            }
            else
            {
                MW3.FREEZEPLAYER(0, false);
            }
        }

        private void flatCheckBox83_CheckedChanged(object sender)
        {
            if (flatCheckBox83.Checked)
            {
                MW3.FREEZEPLAYER(1, true);
            }
            else
            {
                MW3.FREEZEPLAYER(1, false);
            }
        }

        private void flatCheckBox82_CheckedChanged(object sender)
        {
            if (flatCheckBox82.Checked)
            {
                MW3.FREEZEPLAYER(2, true);
            }
            else
            {
                MW3.FREEZEPLAYER(2, false);
            }
        }

        private void flatCheckBox81_CheckedChanged(object sender)
        {
            if (flatCheckBox81.Checked)
            {
                MW3.FREEZEPLAYER(3, true);
            }
            else
            {
                MW3.FREEZEPLAYER(3, false);
            }
        }

        private void flatCheckBox80_CheckedChanged(object sender)
        {
            if (flatCheckBox80.Checked)
            {
                MW3.FREEZEPLAYER(4, true);
            }
            else
            {
                MW3.FREEZEPLAYER(4, false);
            }
        }

        private void flatCheckBox79_CheckedChanged(object sender)
        {
            if (flatCheckBox79.Checked)
            {
                MW3.FREEZEPLAYER(5, true);
            }
            else
            {
                MW3.FREEZEPLAYER(5, false);
            }
        }

        private void flatCheckBox78_CheckedChanged(object sender)
        {
            if (flatCheckBox78.Checked)
            {
                MW3.FREEZEPLAYER(6, true);
            }
            else
            {
                MW3.FREEZEPLAYER(6, false);
            }
        }

        private void flatCheckBox77_CheckedChanged(object sender)
        {
            if (flatCheckBox77.Checked)
            {
                MW3.FREEZEPLAYER(7, true);
            }
            else
            {
                MW3.FREEZEPLAYER(7, false);
            }
        }

        private void flatCheckBox76_CheckedChanged(object sender)
        {
            if (flatCheckBox76.Checked)
            {
                MW3.FREEZEPLAYER(8, true);
            }
            else
            {
                MW3.FREEZEPLAYER(8, false);
            }
        }

        private void flatCheckBox75_CheckedChanged(object sender)
        {
            if (flatCheckBox75.Checked)
            {
                MW3.FREEZEPLAYER(9, true);
            }
            else
            {
                MW3.FREEZEPLAYER(9, false);
            }
        }

        private void flatCheckBox74_CheckedChanged(object sender)
        {
            if (flatCheckBox74.Checked)
            {
                MW3.FREEZEPLAYER(10, true);
            }
            else
            {
                MW3.FREEZEPLAYER(10, false);
            }
        }

        private void flatCheckBox73_CheckedChanged(object sender)
        {
            if (flatCheckBox73.Checked)
            {
                MW3.FREEZEPLAYER(11, true);
            }
            else
            {
                MW3.FREEZEPLAYER(11, false);
            }
        }
        #endregion
        #region Night Vision

        private void flatCheckBox96_CheckedChanged(object sender)
        {
            if (flatCheckBox96.Checked)
            {
                MW3.NightVision(0, true);
            }
            else
            {
                MW3.NightVision(0, false);
            }
        }

        private void flatCheckBox95_CheckedChanged(object sender)
        {
            if (flatCheckBox95.Checked)
            {
                MW3.NightVision(1, true);
            }
            else
            {
                MW3.NightVision(1, false);
            }
        }

        private void flatCheckBox94_CheckedChanged(object sender)
        {
            if (flatCheckBox94.Checked)
            {
                MW3.NightVision(2, true);
            }
            else
            {
                MW3.NightVision(2, false);
            }
        }

        private void flatCheckBox93_CheckedChanged(object sender)
        {
            if (flatCheckBox93.Checked)
            {
                MW3.NightVision(3, true);
            }
            else
            {
                MW3.NightVision(3, false);
            }
        }

        private void flatCheckBox92_CheckedChanged(object sender)
        {
            if (flatCheckBox92.Checked)
            {
                MW3.NightVision(4, true);
            }
            else
            {
                MW3.NightVision(4, false);
            }
        }

        private void flatCheckBox91_CheckedChanged(object sender)
        {
            if (flatCheckBox91.Checked)
            {
                MW3.NightVision(5, true);
            }
            else
            {
                MW3.NightVision(5, false);
            }
        }

        private void flatCheckBox90_CheckedChanged(object sender)
        {
            if (flatCheckBox90.Checked)
            {
                MW3.NightVision(6, true);
            }
            else
            {
                MW3.NightVision(6, false);
            }
        }

        private void flatCheckBox89_CheckedChanged(object sender)
        {
            if (flatCheckBox89.Checked)
            {
                MW3.NightVision(7, true);
            }
            else
            {
                MW3.NightVision(7, false);
            }
        }

        private void flatCheckBox88_CheckedChanged(object sender)
        {
            if (flatCheckBox88.Checked)
            {
                MW3.NightVision(8, true);
            }
            else
            {
                MW3.NightVision(8, false);
            }
        }

        private void flatCheckBox87_CheckedChanged(object sender)
        {
            if (flatCheckBox87.Checked)
            {
                MW3.NightVision(9, true);
            }
            else
            {
                MW3.NightVision(9, false);
            }
        }

        private void flatCheckBox86_CheckedChanged(object sender)
        {
            if (flatCheckBox86.Checked)
            {
                MW3.NightVision(10, true);
            }
            else
            {
                MW3.NightVision(10, false);
            }
        }

        private void flatCheckBox85_CheckedChanged(object sender)
        {
            if (flatCheckBox85.Checked)
            {
                MW3.NightVision(11, true);
            }
            else
            {
                MW3.NightVision(11, false);
            }
        }
        #endregion

        private void flatCheckBox108_CheckedChanged(object sender)
        {
            if (flatCheckBox108.Checked)
            {
                RPC.PressStart(0);
            }
        }

        private void flatCheckBox107_CheckedChanged(object sender)
        {
            if (flatCheckBox107.Checked)
            {
                RPC.PressStart(1);
            }
        }

        private void flatCheckBox106_CheckedChanged(object sender)
        {
            if (flatCheckBox106.Checked)
            {
                RPC.PressStart(2);
            }
        }

        private void flatCheckBox105_CheckedChanged(object sender)
        {
            if (flatCheckBox105.Checked)
            {
                RPC.PressStart(3);
            }
        }

        private void flatCheckBox104_CheckedChanged(object sender)
        {
            if (flatCheckBox104.Checked)
            {
                RPC.PressStart(4);
            }
        }

        private void flatCheckBox103_CheckedChanged(object sender)
        {
            if (flatCheckBox103.Checked)
            {
                RPC.PressStart(5);
            }
        }

        private void flatCheckBox102_CheckedChanged(object sender)
        {
            if (flatCheckBox102.Checked)
            {
                RPC.PressStart(6);
            }
        }

        private void flatCheckBox101_CheckedChanged(object sender)
        {
            if (flatCheckBox101.Checked)
            {
                RPC.PressStart(7);
            }
        }

        private void flatCheckBox100_CheckedChanged(object sender)
        {
            if (flatCheckBox100.Checked)
            {
                RPC.PressStart(8);
            }
        }

        private void flatCheckBox99_CheckedChanged(object sender)
        {
            if (flatCheckBox99.Checked)
            {
                RPC.PressStart(9);
            }
        }

        private void flatCheckBox98_CheckedChanged(object sender)
        {
            if (flatCheckBox98.Checked)
            {
                RPC.PressStart(10);
            }
        }

        private void flatCheckBox97_CheckedChanged(object sender)
        {
            if (flatCheckBox97.Checked)
            {
                RPC.PressStart(11);
            }
        }
        private void flatButton31_Click(object sender, EventArgs e)
        {
            textBox1.Text = MW3.GetClient(0);
            textBox2.Text = MW3.GetClient(1);
            textBox3.Text = MW3.GetClient(2);
            textBox4.Text = MW3.GetClient(3);
            textBox5.Text = MW3.GetClient(4);
            textBox6.Text = MW3.GetClient(5);
            textBox7.Text = MW3.GetClient(6);
            textBox8.Text = MW3.GetClient(7);
            textBox9.Text = MW3.GetClient(8);
            textBox10.Text = MW3.GetClient(9);
            textBox11.Text = MW3.GetClient(10);
            textBox12.Text = MW3.GetClient(11);
            textBox24.Text = MW3.GetClient(0);
            textBox23.Text = MW3.GetClient(1);
            textBox22.Text = MW3.GetClient(2);
            textBox21.Text = MW3.GetClient(3);
            textBox20.Text = MW3.GetClient(4);
            textBox19.Text = MW3.GetClient(5);
            textBox18.Text = MW3.GetClient(6);
            textBox17.Text = MW3.GetClient(7);
            textBox16.Text = MW3.GetClient(8);
            textBox15.Text = MW3.GetClient(9);
            textBox14.Text = MW3.GetClient(10);
            textBox13.Text = MW3.GetClient(11);
            textBox49.Text = MW3.GetClient(0);
            textBox48.Text = MW3.GetClient(1);
            textBox47.Text = MW3.GetClient(2);
            textBox46.Text = MW3.GetClient(3);
            textBox45.Text = MW3.GetClient(4);
            textBox44.Text = MW3.GetClient(5);
            textBox43.Text = MW3.GetClient(6);
            textBox42.Text = MW3.GetClient(7);
            textBox41.Text = MW3.GetClient(8);
            textBox40.Text = MW3.GetClient(9);
            textBox39.Text = MW3.GetClient(10);
            textBox38.Text = MW3.GetClient(11);
            textBox36.Text = MW3.GetClient(0);
            textBox35.Text = MW3.GetClient(1);
            textBox34.Text = MW3.GetClient(2);
            textBox33.Text = MW3.GetClient(3);
            textBox32.Text = MW3.GetClient(4);
            textBox31.Text = MW3.GetClient(5);
            textBox30.Text = MW3.GetClient(6);
            textBox29.Text = MW3.GetClient(7);
            textBox28.Text = MW3.GetClient(8);
            textBox27.Text = MW3.GetClient(9);
            textBox26.Text = MW3.GetClient(10);
            textBox25.Text = MW3.GetClient(11);
            textBox60.Text = MW3.GetClient(0);
            textBox59.Text = MW3.GetClient(1);
            textBox58.Text = MW3.GetClient(2);
            textBox57.Text = MW3.GetClient(3);
            textBox56.Text = MW3.GetClient(4);
            textBox55.Text = MW3.GetClient(5);
            textBox54.Text = MW3.GetClient(6);
            textBox53.Text = MW3.GetClient(7);
            textBox52.Text = MW3.GetClient(8);
            textBox51.Text = MW3.GetClient(9);
            textBox50.Text = MW3.GetClient(10);
            textBox37.Text = MW3.GetClient(11);
            textBox72.Text = MW3.GetClient(0);
            textBox71.Text = MW3.GetClient(1);
            textBox70.Text = MW3.GetClient(2);
            textBox69.Text = MW3.GetClient(3);
            textBox68.Text = MW3.GetClient(4);
            textBox67.Text = MW3.GetClient(5);
            textBox66.Text = MW3.GetClient(6);
            textBox65.Text = MW3.GetClient(7);
            textBox64.Text = MW3.GetClient(8);
            textBox63.Text = MW3.GetClient(9);
            textBox62.Text = MW3.GetClient(10);
            textBox61.Text = MW3.GetClient(11);
        }
        #region All Perks
        private void flatCheckBox120_CheckedChanged(object sender)
        {
            if (flatCheckBox120.Checked ==true)
            {
                MW3.AllPerks(0);
            }
        }

        private void flatCheckBox119_CheckedChanged(object sender)
        {
            if (flatCheckBox119.Checked == true)
            {
                MW3.AllPerks(1);
            }
        }

        private void flatCheckBox118_CheckedChanged(object sender)
        {
            if (flatCheckBox118.Checked == true)
            {
                MW3.AllPerks(2);
            }
        }

        private void flatCheckBox117_CheckedChanged(object sender)
        {
            if (flatCheckBox117.Checked == true)
            {
                MW3.AllPerks(3);
            }
        }

        private void flatCheckBox116_CheckedChanged(object sender)
        {
            if (flatCheckBox116.Checked == true)
            {
                MW3.AllPerks(4);
            }
        }

        private void flatCheckBox115_CheckedChanged(object sender)
        {
            if (flatCheckBox115.Checked == true)
            {
                MW3.AllPerks(5);
            }
        }

        private void flatCheckBox114_CheckedChanged(object sender)
        {
            if (flatCheckBox114.Checked == true)
            {
                MW3.AllPerks(6);
            }
        }

        private void flatCheckBox113_CheckedChanged(object sender)
        {
            if (flatCheckBox113.Checked == true)
            {
                MW3.AllPerks(7);
            }
        }

        private void flatCheckBox112_CheckedChanged(object sender)
        {
            if (flatCheckBox112.Checked == true)
            {
                MW3.AllPerks(8);
            }
        }

        private void flatCheckBox111_CheckedChanged(object sender)
        {
            if (flatCheckBox111.Checked == true)
            {
                MW3.AllPerks(9);
            }
        }

        private void flatCheckBox110_CheckedChanged(object sender)
        {
            if (flatCheckBox110.Checked == true)
            {
                MW3.AllPerks(10);
            }
        }

        private void flatCheckBox109_CheckedChanged(object sender)
        {
            if (flatCheckBox109.Checked == true)
            {
                MW3.AllPerks(11);
            }
        }
        #endregion

        private void flatCheckBox132_CheckedChanged(object sender)
        {
            if (flatCheckBox132.Checked == true)
            {
                MW3.SpeedPlayer(0,true);
            }
            else
            {
                MW3.SpeedPlayer(0, false);
            }
        }

        private void flatCheckBox131_CheckedChanged(object sender)
        {
            if (flatCheckBox131.Checked == true)
            {
                MW3.SpeedPlayer(1, true);
            }
            else
            {
                MW3.SpeedPlayer(1, false);
            }
        }

        private void flatCheckBox130_CheckedChanged(object sender)
        {
            if (flatCheckBox130.Checked == true)
            {
                MW3.SpeedPlayer(2, true);
            }
            else
            {
                MW3.SpeedPlayer(2, false);
            }
        }

        private void flatCheckBox129_CheckedChanged(object sender)
        {
            if (flatCheckBox129.Checked == true)
            {
                MW3.SpeedPlayer(3, true);
            }
            else
            {
                MW3.SpeedPlayer(3, false);
            }
        }

        private void flatCheckBox128_CheckedChanged(object sender)
        {
            if (flatCheckBox128.Checked == true)
            {
                MW3.SpeedPlayer(4, true);
            }
            else
            {
                MW3.SpeedPlayer(4, false);
            }
        }

        private void flatCheckBox127_CheckedChanged(object sender)
        {
            if (flatCheckBox127.Checked == true)
            {
                MW3.SpeedPlayer(5, true);
            }
            else
            {
                MW3.SpeedPlayer(5, false);
            }
        }

        private void flatCheckBox126_CheckedChanged(object sender)
        {
            if (flatCheckBox126.Checked == true)
            {
                MW3.SpeedPlayer(6, true);
            }
            else
            {
                MW3.SpeedPlayer(6, false);
            }
        }

        private void flatCheckBox125_CheckedChanged(object sender)
        {
            if (flatCheckBox125.Checked == true)
            {
                MW3.SpeedPlayer(7, true);
            }
            else
            {
                MW3.SpeedPlayer(7, false);
            }
        }

        private void flatCheckBox124_CheckedChanged(object sender)
        {
            if (flatCheckBox124.Checked == true)
            {
                MW3.SpeedPlayer(8, true);
            }
            else
            {
                MW3.SpeedPlayer(8, false);
            }
        }

        private void flatCheckBox123_CheckedChanged(object sender)
        {
            if (flatCheckBox123.Checked == true)
            {
                MW3.SpeedPlayer(9, true);
            }
            else
            {
                MW3.SpeedPlayer(9, false);
            }
        }

        private void flatCheckBox122_CheckedChanged(object sender)
        {
            if (flatCheckBox122.Checked == true)
            {
                MW3.SpeedPlayer(10, true);
            }
            else
            {
                MW3.SpeedPlayer(10, false);
            }
        }

        private void flatCheckBox121_CheckedChanged(object sender)
        {
            if (flatCheckBox121.Checked == true)
            {
                MW3.SpeedPlayer(11, true);
            }
            else
            {
                MW3.SpeedPlayer(11, false);
            }
        }

        private void flatCheckBox144_CheckedChanged(object sender)
        {
            if (flatCheckBox144.Checked == true)
            {
                timer1.Start();
            }
        }

        private void flatCheckBox143_CheckedChanged(object sender)
        {
            if (flatCheckBox143.Checked == true)
            {
                timer1.Start();
            }
        }

        private void flatCheckBox142_CheckedChanged(object sender)
        {
            if (flatCheckBox142.Checked == true)
            {
                timer1.Start();
            }
        }

        private void flatCheckBox141_CheckedChanged(object sender)
        {
            if (flatCheckBox141.Checked == true)
            {
                timer1.Start();
            }
        }

        private void flatCheckBox140_CheckedChanged(object sender)
        {
            if (flatCheckBox140.Checked == true)
            {
                timer1.Start();
            }
        }

        private void flatCheckBox139_CheckedChanged(object sender)
        {
            if (flatCheckBox139.Checked == true)
            {
                timer1.Start();
            }
        }

        private void flatCheckBox138_CheckedChanged(object sender)
        {
            if (flatCheckBox138.Checked == true)
            {
                timer1.Start();
            }
        }

        private void flatCheckBox137_CheckedChanged(object sender)
        {
            if (flatCheckBox137.Checked == true)
            {
                timer1.Start();
            }
        }

        private void flatCheckBox136_CheckedChanged(object sender)
        {
            if (flatCheckBox136.Checked == true)
            {
                timer1.Start();
            }
        }

        private void flatCheckBox135_CheckedChanged(object sender)
        {
            if (flatCheckBox135.Checked == true)
            {
                timer1.Start();
            }
        }

        private void flatCheckBox134_CheckedChanged(object sender)
        {
            if (flatCheckBox134.Checked == true)
            {
                timer1.Start();
            }
        }

        private void flatCheckBox133_CheckedChanged(object sender)
        {
            if (flatCheckBox133.Checked == true)
            {
                timer1.Start();
            }
        }

        private void flatButton79_Click(object sender, EventArgs e)
        {
            MW3.RemoveWeapon(0);
        }

        private void flatButton78_Click(object sender, EventArgs e)
        {
            MW3.RemoveWeapon(1);
        }

        private void flatButton77_Click(object sender, EventArgs e)
        {
            MW3.RemoveWeapon(2);
        }

        private void flatButton76_Click(object sender, EventArgs e)
        {
            MW3.RemoveWeapon(3);
        }

        private void flatButton75_Click(object sender, EventArgs e)
        {
            MW3.RemoveWeapon(4);
        }

        private void flatButton74_Click(object sender, EventArgs e)
        {
            MW3.RemoveWeapon(5);
        }

        private void flatButton73_Click(object sender, EventArgs e)
        {
            MW3.RemoveWeapon(6);
        }

        private void flatButton72_Click(object sender, EventArgs e)
        {
            MW3.RemoveWeapon(7);
        }

        private void flatButton71_Click(object sender, EventArgs e)
        {
            MW3.RemoveWeapon(8);
        }

        private void flatButton70_Click(object sender, EventArgs e)
        {
            MW3.RemoveWeapon(9);
        }

        private void flatButton69_Click(object sender, EventArgs e)
        {
            MW3.RemoveWeapon(10);
        }

        private void flatButton68_Click(object sender, EventArgs e)
        {
            MW3.RemoveWeapon(11);
        }

        private void flatCheckBox168_CheckedChanged(object sender)
        {
            if (flatCheckBox168.Checked)
            {
                RPC.BlackScreen(0, true);
            }
            else
            {
                RPC.BlackScreen(0, false);
            }
        }

        private void flatCheckBox167_CheckedChanged(object sender)
        {
            if (flatCheckBox167.Checked)
            {
                RPC.BlackScreen(1, true);
            }
            else
            {
                RPC.BlackScreen(1, false);
            }
        }

        private void flatCheckBox166_CheckedChanged(object sender)
        {
            if (flatCheckBox166.Checked)
            {
                RPC.BlackScreen(2, true);
            }
            else
            {
                RPC.BlackScreen(2, false);
            }
        }

        private void flatCheckBox165_CheckedChanged(object sender)
        {
            if (flatCheckBox165.Checked)
            {
                RPC.BlackScreen(3, true);
            }
            else
            {
                RPC.BlackScreen(3, false);
            }
        }

        private void flatCheckBox164_CheckedChanged(object sender)
        {
            if (flatCheckBox164.Checked)
            {
                RPC.BlackScreen(4, true);
            }
            else
            {
                RPC.BlackScreen(4, false);
            }
        }

        private void flatCheckBox163_CheckedChanged(object sender)
        {
            if (flatCheckBox163.Checked)
            {
                RPC.BlackScreen(5, true);
            }
            else
            {
                RPC.BlackScreen(5, false);
            }
        }

        private void flatCheckBox162_CheckedChanged(object sender)
        {
            if (flatCheckBox162.Checked)
            {
                RPC.BlackScreen(6, true);
            }
            else
            {
                RPC.BlackScreen(6, false);
            }
        }

        private void flatCheckBox161_CheckedChanged(object sender)
        {
            if (flatCheckBox161.Checked)
            {
                RPC.BlackScreen(7, true);
            }
            else
            {
                RPC.BlackScreen(7, false);
            }
        }

        private void flatCheckBox160_CheckedChanged(object sender)
        {
            if (flatCheckBox160.Checked)
            {
                RPC.BlackScreen(8, true);
            }
            else
            {
                RPC.BlackScreen(8, false);
            }
        }

        private void flatCheckBox159_CheckedChanged(object sender)
        {
            if (flatCheckBox159.Checked)
            {
                RPC.BlackScreen(9, true);
            }
            else
            {
                RPC.BlackScreen(9, false);
            }
        }

        private void flatCheckBox158_CheckedChanged(object sender)
        {
            if (flatCheckBox158.Checked)
            {
                RPC.BlackScreen(10, true);
            }
            else
            {
                RPC.BlackScreen(10, false);
            }
        }

        private void flatCheckBox157_CheckedChanged(object sender)
        {
            if (flatCheckBox157.Checked)
            {
                RPC.BlackScreen(11, true);
            }
            else
            {
                RPC.BlackScreen(11, false);
            }
        }

        private void flatCheckBox180_CheckedChanged(object sender)
        {
            if (flatCheckBox180.Checked)
            {
                RPC.AntiQuit(0, true);
            }
            else
            {
                RPC.AntiQuit(0, false);
            }
        }

        private void flatCheckBox179_CheckedChanged(object sender)
        {
            if (flatCheckBox179.Checked)
            {
                RPC.AntiQuit(1, true);
            }
            else
            {
                RPC.AntiQuit(1, false);
            }
        }

        private void flatCheckBox178_CheckedChanged(object sender)
        {
            if (flatCheckBox178.Checked)
            {
                RPC.AntiQuit(2, true);
            }
            else
            {
                RPC.AntiQuit(2, false);
            }
        }

        private void flatCheckBox177_CheckedChanged(object sender)
        {
            if (flatCheckBox177.Checked)
            {
                RPC.AntiQuit(3, true);
            }
            else
            {
                RPC.AntiQuit(3, false);
            }
        }

        private void flatCheckBox176_CheckedChanged(object sender)
        {
            if (flatCheckBox176.Checked)
            {
                RPC.AntiQuit(4, true);
            }
            else
            {
                RPC.AntiQuit(4, false);
            }
        }

        private void flatCheckBox175_CheckedChanged(object sender)
        {
            if (flatCheckBox175.Checked)
            {
                RPC.AntiQuit(5, true);
            }
            else
            {
                RPC.AntiQuit(5, false);
            }
        }

        private void flatCheckBox174_CheckedChanged(object sender)
        {
            if (flatCheckBox174.Checked)
            {
                RPC.AntiQuit(6, true);
            }
            else
            {
                RPC.AntiQuit(6, false);
            }
        }

        private void flatCheckBox173_CheckedChanged(object sender)
        {
            if (flatCheckBox173.Checked)
            {
                RPC.AntiQuit(7, true);
            }
            else
            {
                RPC.AntiQuit(7, false);
            }
        }

        private void flatCheckBox172_CheckedChanged(object sender)
        {
            if (flatCheckBox172.Checked)
            {
                RPC.AntiQuit(8, true);
            }
            else
            {
                RPC.AntiQuit(8, false);
            }
        }

        private void flatCheckBox171_CheckedChanged(object sender)
        {
            if (flatCheckBox171.Checked)
            {
                RPC.AntiQuit(9, true);
            }
            else
            {
                RPC.AntiQuit(9, false);
            }
        }

        private void flatCheckBox170_CheckedChanged(object sender)
        {
            if (flatCheckBox170.Checked)
            {
                RPC.AntiQuit(10, true);
            }
            else
            {
                RPC.AntiQuit(10, false);
            }
        }

        private void flatCheckBox169_CheckedChanged(object sender)
        {
            if (flatCheckBox169.Checked)
            {
                RPC.AntiQuit(11, true);
            }
            else
            {
                RPC.AntiQuit(11, false);
            }
        }

        private void flatButton55_Click(object sender, EventArgs e)
        {
            RPC.SV_KickClient(0,  "^1Kicked ^2By ^5 Using ^3BISOON's ^5 Tool");
        }

        private void flatButton54_Click(object sender, EventArgs e)
        {
            RPC.SV_KickClient(1,  "^1Kicked ^2By ^5 Using ^3BISOON's ^5 Tool");
        }

        private void flatButton53_Click(object sender, EventArgs e)
        {
            RPC.SV_KickClient(2,  "^1Kicked ^2By ^5 Using ^3BISOON's ^5 Tool");
        }

        private void flatButton52_Click(object sender, EventArgs e)
        {
            RPC.SV_KickClient(3,  "^1Kicked ^2By ^5 Using ^3BISOON's ^5 Tool");
        }

        private void flatButton51_Click(object sender, EventArgs e)
        {
            RPC.SV_KickClient(4,  "^1Kicked ^2By ^5 Using ^3BISOON's ^5 Tool");
        }

        private void flatButton50_Click(object sender, EventArgs e)
        {
            RPC.SV_KickClient(5,  "^1Kicked ^2By ^5 Using ^3BISOON's ^5 Tool");
        }

        private void flatButton49_Click(object sender, EventArgs e)
        {
            RPC.SV_KickClient(6, "^1Kicked ^2By ^5 Using ^3BISOON's ^5 Tool");
        }

        private void flatButton48_Click(object sender, EventArgs e)
        {
            RPC.SV_KickClient(7, "^1Kicked ^2By ^5 Using ^3BISOON's ^5 Tool");
        }

        private void flatButton47_Click(object sender, EventArgs e)
        {
            RPC.SV_KickClient(8,  "^1Kicked ^2By ^5 Using ^3BISOON's ^5 Tool");
        }

        private void flatButton46_Click(object sender, EventArgs e)
        {
            RPC.SV_KickClient(9,  "^1Kicked ^2By ^5 Using ^3BISOON's ^5 Tool");
        }

        private void flatButton45_Click(object sender, EventArgs e)
        {
            RPC.SV_KickClient(10,  "^1Kicked ^2By ^5 Using ^3BISOON's ^5 Tool");
        }

        private void flatButton44_Click(object sender, EventArgs e)
        {
            RPC.SV_KickClient(11,  "^1Kicked ^2By ^5 Using ^3BISOON's ^5 Tool");
        }

        private void flatButton43_Click(object sender, EventArgs e)
        {
            RPC.iPrintln(0, "^1Warning : ^8Your ^4System ^3Froze By ^5BISOON's ^9Tool");
            Thread.Sleep(2500);
            MW3.PS3Freeze(0);
        }

        private void flatButton42_Click(object sender, EventArgs e)
        {
            RPC.iPrintln(1, "^1Warning : ^8Your ^4System ^3Froze By ^5BISOON's ^9Tool");
            Thread.Sleep(2500);
            MW3.PS3Freeze(1);
        }

        private void flatButton41_Click(object sender, EventArgs e)
        {
            RPC.iPrintln(2, "^1Warning : ^8Your ^4System ^3Froze By ^5BISOON's ^9Tool");
            Thread.Sleep(2500);
            MW3.PS3Freeze(2);
        }

        private void flatButton40_Click(object sender, EventArgs e)
        {
            RPC.iPrintln(3, "^1Warning : ^8Your ^4System ^3Froze By ^5BISOON's ^9Tool");
            Thread.Sleep(2500);
            MW3.PS3Freeze(3);
        }

        private void flatButton39_Click(object sender, EventArgs e)
        {
            RPC.iPrintln(4, "^1Warning : ^8Your ^4System ^3Froze By ^5BISOON's ^9Tool");
            Thread.Sleep(2500);
            MW3.PS3Freeze(4);
        }

        private void flatButton38_Click(object sender, EventArgs e)
        {
            RPC.iPrintln(5, "^1Warning : ^8Your ^4System ^3Froze By ^5BISOON's ^9Tool");
            Thread.Sleep(2500);
            MW3.PS3Freeze(5);
        }

        private void flatButton37_Click(object sender, EventArgs e)
        {
            RPC.iPrintln(6, "^1Warning : ^8Your ^4System ^3Froze By ^5BISOON's ^9Tool");
            Thread.Sleep(2500);
            MW3.PS3Freeze(6);
        }

        private void flatButton36_Click(object sender, EventArgs e)
        {
            RPC.iPrintln(7, "^1Warning : ^8Your ^4System ^3Froze By ^5BISOON's ^9Tool");
            Thread.Sleep(2500);
            MW3.PS3Freeze(7);
        }

        private void flatButton35_Click(object sender, EventArgs e)
        {
            RPC.iPrintln(8, "^1Warning : ^8Your ^4System ^3Froze By ^5BISOON's ^9Tool");
            Thread.Sleep(2500);
            MW3.PS3Freeze(8);
        }

        private void flatButton34_Click(object sender, EventArgs e)
        {
            RPC.iPrintln(9, "^1Warning : ^8Your ^4System ^3Froze By ^5BISOON's ^9Tool");
            Thread.Sleep(2500);
            MW3.PS3Freeze(9);
        }

        private void flatButton33_Click(object sender, EventArgs e)
        {
            RPC.iPrintln(10, "^1Warning : ^8Your ^4System ^3Froze By ^5BISOON's ^9Tool");
            Thread.Sleep(2500);
            MW3.PS3Freeze(10);
        }

        private void flatButton32_Click(object sender, EventArgs e)
        {
            RPC.iPrintln(11, "^1Warning : ^8Your ^4System ^3Froze By ^5BISOON's ^9Tool");
            Thread.Sleep(2500);
            MW3.PS3Freeze(11);
        }

        private void flatButton67_Click(object sender, EventArgs e)
        {
            RPC.Kick(0, kickTextBox.Text);
        }

        private void flatButton66_Click(object sender, EventArgs e)
        {
            RPC.Kick(1, kickTextBox.Text);
        }

        private void flatButton65_Click(object sender, EventArgs e)
        {
            RPC.Kick(2, kickTextBox.Text);
        }

        private void flatButton64_Click(object sender, EventArgs e)
        {
            RPC.Kick(3, kickTextBox.Text);
        }

        private void flatButton63_Click(object sender, EventArgs e)
        {
            RPC.Kick(4, kickTextBox.Text);
        }

        private void flatButton62_Click(object sender, EventArgs e)
        {
            RPC.Kick(5, kickTextBox.Text);
        }

        private void flatButton61_Click(object sender, EventArgs e)
        {
            RPC.Kick(6, kickTextBox.Text);
        }

        private void flatButton60_Click(object sender, EventArgs e)
        {
            RPC.Kick(7, kickTextBox.Text);
        }

        private void flatButton59_Click(object sender, EventArgs e)
        {
            RPC.Kick(8, kickTextBox.Text);
        }

        private void flatButton58_Click(object sender, EventArgs e)
        {
            RPC.Kick(9, kickTextBox.Text);
        }

        private void flatButton57_Click(object sender, EventArgs e)
        {
            RPC.Kick(10, kickTextBox.Text);
        }

        private void flatButton56_Click(object sender, EventArgs e)
        {
            RPC.Kick(11, kickTextBox.Text);
        }

        private void flatComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.Vision(0, BIS.Vision[flatComboBox1.SelectedIndex]);
        }

        private void flatComboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.Vision(1, BIS.Vision[flatComboBox8.SelectedIndex]);
        }

        private void flatComboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.Vision(2, BIS.Vision[flatComboBox9.SelectedIndex]);
        }

        private void flatComboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.Vision(3, BIS.Vision[flatComboBox10.SelectedIndex]);
        }

        private void flatComboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.Vision(4, BIS.Vision[flatComboBox11.SelectedIndex]);
        }

        private void flatComboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.Vision(5, BIS.Vision[flatComboBox12.SelectedIndex]);
        }

        private void flatComboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.Vision(6, BIS.Vision[flatComboBox13.SelectedIndex]);
        }

        private void flatComboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.Vision(7, BIS.Vision[flatComboBox14.SelectedIndex]);
        }

        private void flatComboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.Vision(8, BIS.Vision[flatComboBox15.SelectedIndex]);
        }

        private void flatComboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.Vision(9, BIS.Vision[flatComboBox16.SelectedIndex]);
        }

        private void flatComboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.Vision(10, BIS.Vision[flatComboBox17.SelectedIndex]);
        }

        private void flatComboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.Vision(11, BIS.Vision[flatComboBox1.SelectedIndex]);
        }

        private void flatComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.SetModel(0, BIS.Model[flatComboBox2.SelectedIndex]);
        }

        private void flatComboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.SetModel(1, BIS.Model[flatComboBox19.SelectedIndex]);
        }

        private void flatComboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.SetModel(2, BIS.Model[flatComboBox20.SelectedIndex]);
        }

        private void flatComboBox21_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.SetModel(3, BIS.Model[flatComboBox21.SelectedIndex]);
        }

        private void flatComboBox22_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.SetModel(4, BIS.Model[flatComboBox22.SelectedIndex]);
        }

        private void flatComboBox23_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.SetModel(5, BIS.Model[flatComboBox23.SelectedIndex]);
        }

        private void flatComboBox24_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.SetModel(6, BIS.Model[flatComboBox24.SelectedIndex]);
        }

        private void flatComboBox25_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.SetModel(7, BIS.Model[flatComboBox25.SelectedIndex]);
        }

        private void flatComboBox26_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.SetModel(8, BIS.Model[flatComboBox26.SelectedIndex]);
        }

        private void flatComboBox27_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.SetModel(9, BIS.Model[flatComboBox27.SelectedIndex]);
        }

        private void flatComboBox28_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.SetModel(10, BIS.Model[flatComboBox28.SelectedIndex]);
        }

        private void flatComboBox29_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.SetModel(11, BIS.Model[flatComboBox29.SelectedIndex]);
        }

        private void flatComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool SetUp1 = (((((((MW3.MapInfo.MapName() == "Seatown") | (MW3.MapInfo.MapName() == "Arkaden")) |
                        (MW3.MapInfo.MapName() == "Downturn")) | (MW3.MapInfo.MapName() == "Bootleg")) | (MW3.MapInfo.MapName() == "Lockdown")) |
                        (MW3.MapInfo.MapName() == "Village")) | (MW3.MapInfo.MapName() == "Mission"));
            if (SetUp1)
            {
                MW3.ChangeWeapon(0, (byte)BIS.ChangeWeaponIndex_SeatDown[flatComboBox3.SelectedIndex]);
            }
            else
            {
                MW3.ChangeWeapon(0, (byte)BIS.ChangeWeaponIndex_Dome[flatComboBox3.SelectedIndex]);
            }
        }

        private void flatComboBox30_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool SetUp1 = (((((((MW3.MapInfo.MapName() == "Seatown") | (MW3.MapInfo.MapName() == "Arkaden")) |
                        (MW3.MapInfo.MapName() == "Downturn")) | (MW3.MapInfo.MapName() == "Bootleg")) | (MW3.MapInfo.MapName() == "Lockdown")) |
                        (MW3.MapInfo.MapName() == "Village")) | (MW3.MapInfo.MapName() == "Mission"));
            if (SetUp1)
            {
                MW3.ChangeWeapon(1, (byte)BIS.ChangeWeaponIndex_SeatDown[flatComboBox30.SelectedIndex]);
            }
            else
            {
                MW3.ChangeWeapon(1, (byte)BIS.ChangeWeaponIndex_Dome[flatComboBox30.SelectedIndex]);
            }
        }

        private void flatComboBox31_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool SetUp1 = (((((((MW3.MapInfo.MapName() == "Seatown") | (MW3.MapInfo.MapName() == "Arkaden")) |
                        (MW3.MapInfo.MapName() == "Downturn")) | (MW3.MapInfo.MapName() == "Bootleg")) | (MW3.MapInfo.MapName() == "Lockdown")) |
                        (MW3.MapInfo.MapName() == "Village")) | (MW3.MapInfo.MapName() == "Mission"));
            if (SetUp1)
            {
                MW3.ChangeWeapon(2, (byte)BIS.ChangeWeaponIndex_SeatDown[flatComboBox31.SelectedIndex]);
            }
            else
            {
                MW3.ChangeWeapon(2, (byte)BIS.ChangeWeaponIndex_Dome[flatComboBox31.SelectedIndex]);
            }
        }

        private void flatComboBox32_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool SetUp1 = (((((((MW3.MapInfo.MapName() == "Seatown") | (MW3.MapInfo.MapName() == "Arkaden")) |
                        (MW3.MapInfo.MapName() == "Downturn")) | (MW3.MapInfo.MapName() == "Bootleg")) | (MW3.MapInfo.MapName() == "Lockdown")) |
                        (MW3.MapInfo.MapName() == "Village")) | (MW3.MapInfo.MapName() == "Mission"));
            if (SetUp1)
            {
                MW3.ChangeWeapon(3, (byte)BIS.ChangeWeaponIndex_SeatDown[flatComboBox32.SelectedIndex]);
            }
            else
            {
                MW3.ChangeWeapon(3, (byte)BIS.ChangeWeaponIndex_Dome[flatComboBox32.SelectedIndex]);
            }
        }

        private void flatComboBox33_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool SetUp1 = (((((((MW3.MapInfo.MapName() == "Seatown") | (MW3.MapInfo.MapName() == "Arkaden")) |
                        (MW3.MapInfo.MapName() == "Downturn")) | (MW3.MapInfo.MapName() == "Bootleg")) | (MW3.MapInfo.MapName() == "Lockdown")) |
                        (MW3.MapInfo.MapName() == "Village")) | (MW3.MapInfo.MapName() == "Mission"));
            if (SetUp1)
            {
                MW3.ChangeWeapon(4, (byte)BIS.ChangeWeaponIndex_SeatDown[flatComboBox33.SelectedIndex]);
            }
            else
            {
                MW3.ChangeWeapon(4, (byte)BIS.ChangeWeaponIndex_Dome[flatComboBox33.SelectedIndex]);
            }
        }

        private void flatComboBox34_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool SetUp1 = (((((((MW3.MapInfo.MapName() == "Seatown") | (MW3.MapInfo.MapName() == "Arkaden")) |
                        (MW3.MapInfo.MapName() == "Downturn")) | (MW3.MapInfo.MapName() == "Bootleg")) | (MW3.MapInfo.MapName() == "Lockdown")) |
                        (MW3.MapInfo.MapName() == "Village")) | (MW3.MapInfo.MapName() == "Mission"));
            if (MW3.MapInfo.SetUp1)
            {
                MW3.ChangeWeapon(5, (byte)BIS.ChangeWeaponIndex_SeatDown[flatComboBox34.SelectedIndex]);
            }
            else
            {
                MW3.ChangeWeapon(5, (byte)BIS.ChangeWeaponIndex_Dome[flatComboBox34.SelectedIndex]);
            }
        }

        private void flatComboBox35_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool SetUp1 = (((((((MW3.MapInfo.MapName() == "Seatown") | (MW3.MapInfo.MapName() == "Arkaden")) |
                        (MW3.MapInfo.MapName() == "Downturn")) | (MW3.MapInfo.MapName() == "Bootleg")) | (MW3.MapInfo.MapName() == "Lockdown")) |
                        (MW3.MapInfo.MapName() == "Village")) | (MW3.MapInfo.MapName() == "Mission"));
            if (MW3.MapInfo.SetUp1)
            {
                MW3.ChangeWeapon(6, (byte)BIS.ChangeWeaponIndex_SeatDown[flatComboBox35.SelectedIndex]);
            }
            else
            {
                MW3.ChangeWeapon(6, (byte)BIS.ChangeWeaponIndex_Dome[flatComboBox35.SelectedIndex]);
            }
        }

        private void flatComboBox36_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool SetUp1 = (((((((MW3.MapInfo.MapName() == "Seatown") | (MW3.MapInfo.MapName() == "Arkaden")) |
                        (MW3.MapInfo.MapName() == "Downturn")) | (MW3.MapInfo.MapName() == "Bootleg")) | (MW3.MapInfo.MapName() == "Lockdown")) |
                        (MW3.MapInfo.MapName() == "Village")) | (MW3.MapInfo.MapName() == "Mission"));
            if (MW3.MapInfo.SetUp1)
            {
                MW3.ChangeWeapon(7, (byte)BIS.ChangeWeaponIndex_SeatDown[flatComboBox36.SelectedIndex]);
            }
            else
            {
                MW3.ChangeWeapon(7, (byte)BIS.ChangeWeaponIndex_Dome[flatComboBox36.SelectedIndex]);
            }
        }

        private void flatComboBox37_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool SetUp1 = (((((((MW3.MapInfo.MapName() == "Seatown") | (MW3.MapInfo.MapName() == "Arkaden")) |
                        (MW3.MapInfo.MapName() == "Downturn")) | (MW3.MapInfo.MapName() == "Bootleg")) | (MW3.MapInfo.MapName() == "Lockdown")) |
                        (MW3.MapInfo.MapName() == "Village")) | (MW3.MapInfo.MapName() == "Mission"));
            if (MW3.MapInfo.SetUp1)
            {
                MW3.ChangeWeapon(8, (byte)BIS.ChangeWeaponIndex_SeatDown[flatComboBox37.SelectedIndex]);
            }
            else
            {
                MW3.ChangeWeapon(8, (byte)BIS.ChangeWeaponIndex_Dome[flatComboBox37.SelectedIndex]);
            }
        }

        private void flatComboBox38_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool SetUp1 = (((((((MW3.MapInfo.MapName() == "Seatown") | (MW3.MapInfo.MapName() == "Arkaden")) |
                        (MW3.MapInfo.MapName() == "Downturn")) | (MW3.MapInfo.MapName() == "Bootleg")) | (MW3.MapInfo.MapName() == "Lockdown")) |
                        (MW3.MapInfo.MapName() == "Village")) | (MW3.MapInfo.MapName() == "Mission"));
            if (MW3.MapInfo.SetUp1)
            {
                MW3.ChangeWeapon(9, (byte)BIS.ChangeWeaponIndex_SeatDown[flatComboBox38.SelectedIndex]);
            }
            else
            {
                MW3.ChangeWeapon(9, (byte)BIS.ChangeWeaponIndex_Dome[flatComboBox38.SelectedIndex]);
            }
        }

        private void flatComboBox39_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool SetUp1 = (((((((MW3.MapInfo.MapName() == "Seatown") | (MW3.MapInfo.MapName() == "Arkaden")) |
                        (MW3.MapInfo.MapName() == "Downturn")) | (MW3.MapInfo.MapName() == "Bootleg")) | (MW3.MapInfo.MapName() == "Lockdown")) |
                        (MW3.MapInfo.MapName() == "Village")) | (MW3.MapInfo.MapName() == "Mission"));
            if (MW3.MapInfo.SetUp1)
            {
                MW3.ChangeWeapon(10, (byte)BIS.ChangeWeaponIndex_SeatDown[flatComboBox39.SelectedIndex]);
            }
            else
            {
                MW3.ChangeWeapon(10, (byte)BIS.ChangeWeaponIndex_Dome[flatComboBox39.SelectedIndex]);
            }
        }

        private void flatComboBox40_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool SetUp1 = (((((((MW3.MapInfo.MapName() == "Seatown") | (MW3.MapInfo.MapName() == "Arkaden")) |
                        (MW3.MapInfo.MapName() == "Downturn")) | (MW3.MapInfo.MapName() == "Bootleg")) | (MW3.MapInfo.MapName() == "Lockdown")) |
                        (MW3.MapInfo.MapName() == "Village")) | (MW3.MapInfo.MapName() == "Mission"));
            if (MW3.MapInfo.SetUp1)
            {
                MW3.ChangeWeapon(11, (byte)BIS.ChangeWeaponIndex_SeatDown[flatComboBox40.SelectedIndex]);
            }
            else
            {
                MW3.ChangeWeapon(11, (byte)BIS.ChangeWeaponIndex_Dome[flatComboBox40.SelectedIndex]);
            }
        }

        private void flatComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            MW3.Teleport(0, BIS.ClientIndex[flatComboBox6.SelectedIndex]);
        }

        private void flatComboBox41_SelectedIndexChanged(object sender, EventArgs e)
        {
            MW3.Teleport(1, BIS.ClientIndex[flatComboBox41.SelectedIndex]);
        }

        private void flatComboBox42_SelectedIndexChanged(object sender, EventArgs e)
        {
            MW3.Teleport(2, BIS.ClientIndex[flatComboBox42.SelectedIndex]);
        }

        private void flatComboBox43_SelectedIndexChanged(object sender, EventArgs e)
        {
            MW3.Teleport(3, BIS.ClientIndex[flatComboBox43.SelectedIndex]);
        }

        private void flatComboBox44_SelectedIndexChanged(object sender, EventArgs e)
        {
            MW3.Teleport(4, BIS.ClientIndex[flatComboBox44.SelectedIndex]);
        }

        private void flatComboBox45_SelectedIndexChanged(object sender, EventArgs e)
        {
            MW3.Teleport(5, BIS.ClientIndex[flatComboBox45.SelectedIndex]);
        }

        private void flatComboBox46_SelectedIndexChanged(object sender, EventArgs e)
        {
            MW3.Teleport(6, BIS.ClientIndex[flatComboBox46.SelectedIndex]);
        }

        private void flatComboBox47_SelectedIndexChanged(object sender, EventArgs e)
        {
            MW3.Teleport(7, BIS.ClientIndex[flatComboBox47.SelectedIndex]);
        }

        private void flatComboBox48_SelectedIndexChanged(object sender, EventArgs e)
        {
            MW3.Teleport(8, BIS.ClientIndex[flatComboBox48.SelectedIndex]);
        }

        private void flatComboBox49_SelectedIndexChanged(object sender, EventArgs e)
        {
            MW3.Teleport(9, BIS.ClientIndex[flatComboBox49.SelectedIndex]);
        }

        private void flatComboBox50_SelectedIndexChanged(object sender, EventArgs e)
        {
            MW3.Teleport(10, BIS.ClientIndex[flatComboBox50.SelectedIndex]);
        }

        private void flatComboBox51_SelectedIndexChanged(object sender, EventArgs e)
        {
            MW3.Teleport(11, BIS.ClientIndex[flatComboBox51.SelectedIndex]);
        }

        private void flatComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            MW3.Teleport(BIS.ClientIndex[flatComboBox7.SelectedIndex], 0);
        }

        private void flatComboBox52_SelectedIndexChanged(object sender, EventArgs e)
        {
            MW3.Teleport(BIS.ClientIndex[flatComboBox52.SelectedIndex], 1);
        }

        private void flatComboBox53_SelectedIndexChanged(object sender, EventArgs e)
        {
            MW3.Teleport(BIS.ClientIndex[flatComboBox53.SelectedIndex], 2);
        }

        private void flatComboBox54_SelectedIndexChanged(object sender, EventArgs e)
        {
            MW3.Teleport(BIS.ClientIndex[flatComboBox54.SelectedIndex], 3);
        }

        private void flatComboBox55_SelectedIndexChanged(object sender, EventArgs e)
        {
            MW3.Teleport(BIS.ClientIndex[flatComboBox55.SelectedIndex], 4);
        }

        private void flatComboBox56_SelectedIndexChanged(object sender, EventArgs e)
        {
            MW3.Teleport(BIS.ClientIndex[flatComboBox56.SelectedIndex], 5);
        }

        private void flatComboBox57_SelectedIndexChanged(object sender, EventArgs e)
        {
            MW3.Teleport(BIS.ClientIndex[flatComboBox57.SelectedIndex], 6);
        }

        private void flatComboBox58_SelectedIndexChanged(object sender, EventArgs e)
        {
            MW3.Teleport(BIS.ClientIndex[flatComboBox58.SelectedIndex], 7);
        }

        private void flatComboBox59_SelectedIndexChanged(object sender, EventArgs e)
        {
            MW3.Teleport(BIS.ClientIndex[flatComboBox59.SelectedIndex], 8);
        }

        private void flatComboBox60_SelectedIndexChanged(object sender, EventArgs e)
        {
            MW3.Teleport(BIS.ClientIndex[flatComboBox60.SelectedIndex], 9);
        }

        private void flatComboBox61_SelectedIndexChanged(object sender, EventArgs e)
        {
            MW3.Teleport(BIS.ClientIndex[flatComboBox61.SelectedIndex], 10);
        }

        private void flatComboBox62_SelectedIndexChanged(object sender, EventArgs e)
        {
            MW3.Teleport(BIS.ClientIndex[flatComboBox62.SelectedIndex], 11);
        }

        private void flatButton80_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 13; i++)
            {
                MW3.Teleport(0, i);
            }
        }

        private void flatButton82_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 13; i++)
            {
                MW3.Teleport(1, i);
            }
        }

        private void flatButton83_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 13; i++)
            {
                MW3.Teleport(2, i);
            }
        }

        private void flatButton84_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 13; i++)
            {
                MW3.Teleport(3, i);
            }
        }

        private void flatButton85_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 13; i++)
            {
                MW3.Teleport(4, i);
            }
        }

        private void flatButton87_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 13; i++)
            {
                MW3.Teleport(5, i);
            }
        }

        private void flatButton86_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 13; i++)
            {
                MW3.Teleport(6, i);
            }
        }

        private void flatButton88_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 13; i++)
            {
                MW3.Teleport(7, i);
            }
        }

        private void flatButton89_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 13; i++)
            {
                MW3.Teleport(8, i);
            }
        }

        private void flatButton90_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 13; i++)
            {
                MW3.Teleport(9, i);
            }
        }

        private void flatButton91_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 13; i++)
            {
                MW3.Teleport(10, i);
            }
        }

        private void flatButton92_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 13; i++)
            {
                MW3.Teleport(11, i);
            }
        }

        private void allPlayerVision_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                RPC.Vision(i, BIS.Vision[allPlayerVision.SelectedIndex]);
            }
        }

        private void allPlayerModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                RPC.SetModel(i, BIS.Model[allPlayerModel.SelectedIndex]);
            }
        }

        private void allPlayerGiveWeapon_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                RPC.GiveWeapon(i, BIS.WeaponIndex[allPlayerGiveWeapon.SelectedIndex], 0);
            }
        }

        private void flatButton81_Click(object sender, EventArgs e)
        {
            MW3.PlayerDie(0);
        }

        private void flatButton93_Click(object sender, EventArgs e)
        {
            MW3.PlayerDie(1);
        }

        private void flatButton94_Click(object sender, EventArgs e)
        {
            MW3.PlayerDie(2);
        }

        private void flatButton95_Click(object sender, EventArgs e)
        {
            MW3.PlayerDie(3);
        }

        private void flatButton96_Click(object sender, EventArgs e)
        {
            MW3.PlayerDie(4);
        }

        private void flatButton97_Click(object sender, EventArgs e)
        {
            MW3.PlayerDie(5);
        }

        private void flatButton98_Click(object sender, EventArgs e)
        {
            MW3.PlayerDie(6);
        }

        private void flatButton99_Click(object sender, EventArgs e)
        {
            MW3.PlayerDie(7);
        }

        private void flatButton100_Click(object sender, EventArgs e)
        {
            MW3.PlayerDie(8);
        }

        private void flatButton101_Click(object sender, EventArgs e)
        {
            MW3.PlayerDie(9);
        }

        private void flatButton102_Click(object sender, EventArgs e)
        {
            MW3.PlayerDie(10);
        }

        private void flatButton103_Click(object sender, EventArgs e)
        {
            MW3.PlayerDie(11);
        }

        private void flatButton104_Click(object sender, EventArgs e)
        {
            //MW3.KillAllLobby();
            for (uint i = 0; i < 12; i++)
            {
                MW3.PlayerDie(i);
            }
        }

        private void flatComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmMain.PS3.Extension.WriteByte(0x0110d657 + 0x3980 * 0, BIS.TeamByte[flatComboBox5.SelectedIndex]);
        }

        private void flatComboBox63_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmMain.PS3.Extension.WriteByte(0x0110d657 + 0x3980 * 1, BIS.TeamByte[flatComboBox63.SelectedIndex]);
        }

        private void flatComboBox64_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmMain.PS3.Extension.WriteByte(0x0110d657 + 0x3980 * 2, BIS.TeamByte[flatComboBox64.SelectedIndex]);
        }

        private void flatComboBox65_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmMain.PS3.Extension.WriteByte(0x0110d657 + 0x3980 * 3, BIS.TeamByte[flatComboBox65.SelectedIndex]);
        }

        private void flatComboBox66_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmMain.PS3.Extension.WriteByte(0x0110d657 + 0x3980 * 4, BIS.TeamByte[flatComboBox66.SelectedIndex]);
        }

        private void flatComboBox67_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmMain.PS3.Extension.WriteByte(0x0110d657 + 0x3980 * 5, BIS.TeamByte[flatComboBox67.SelectedIndex]);
        }

        private void flatComboBox68_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmMain.PS3.Extension.WriteByte(0x0110d657 + 0x3980 * 6, BIS.TeamByte[flatComboBox68.SelectedIndex]);
        }

        private void flatComboBox69_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmMain.PS3.Extension.WriteByte(0x0110d657 + 0x3980 * 7, BIS.TeamByte[flatComboBox69.SelectedIndex]);
        }

        private void flatComboBox70_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmMain.PS3.Extension.WriteByte(0x0110d657 + 0x3980 * 8, BIS.TeamByte[flatComboBox70.SelectedIndex]);
        }

        private void flatComboBox71_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmMain.PS3.Extension.WriteByte(0x0110d657 + 0x3980 * 9, BIS.TeamByte[flatComboBox71.SelectedIndex]);
        }

        private void flatComboBox72_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmMain.PS3.Extension.WriteByte(0x0110d657 + 0x3980 * 10, BIS.TeamByte[flatComboBox72.SelectedIndex]);
        }

        private void flatComboBox73_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmMain.PS3.Extension.WriteByte(0x0110d657 + 0x3980 * 11, BIS.TeamByte[flatComboBox73.SelectedIndex]);
        }

        private void flatComboBox74_SelectedIndexChanged(object sender, EventArgs e)
        {
                frmMain.PS3.Extension.WriteByte(0x0110d657 + 0x3980 * 0, BIS.TeamByte[flatComboBox74.SelectedIndex]);
                frmMain.PS3.Extension.WriteByte(0x0110d657 + 0x3980 * 1, BIS.TeamByte[flatComboBox74.SelectedIndex]);
                frmMain.PS3.Extension.WriteByte(0x0110d657 + 0x3980 * 2, BIS.TeamByte[flatComboBox74.SelectedIndex]);
                frmMain.PS3.Extension.WriteByte(0x0110d657 + 0x3980 * 3, BIS.TeamByte[flatComboBox74.SelectedIndex]);
                frmMain.PS3.Extension.WriteByte(0x0110d657 + 0x3980 * 4, BIS.TeamByte[flatComboBox74.SelectedIndex]);
                frmMain.PS3.Extension.WriteByte(0x0110d657 + 0x3980 * 5, BIS.TeamByte[flatComboBox74.SelectedIndex]);
                frmMain.PS3.Extension.WriteByte(0x0110d657 + 0x3980 * 6, BIS.TeamByte[flatComboBox74.SelectedIndex]);
                frmMain.PS3.Extension.WriteByte(0x0110d657 + 0x3980 * 7, BIS.TeamByte[flatComboBox74.SelectedIndex]);
                frmMain.PS3.Extension.WriteByte(0x0110d657 + 0x3980 * 8, BIS.TeamByte[flatComboBox74.SelectedIndex]);
                frmMain.PS3.Extension.WriteByte(0x0110d657 + 0x3980 * 9, BIS.TeamByte[flatComboBox74.SelectedIndex]);
                frmMain.PS3.Extension.WriteByte(0x0110d657 + 0x3980 * 10, BIS.TeamByte[flatComboBox74.SelectedIndex]);
                frmMain.PS3.Extension.WriteByte(0x0110d657 + 0x3980 * 11, BIS.TeamByte[flatComboBox74.SelectedIndex]);
        }

        private void flatButton116_Click(object sender, EventArgs e)
        {
            RPC.ClonePlayer(0);
        }

        private void flatButton115_Click(object sender, EventArgs e)
        {
            RPC.ClonePlayer(1);
        }

        private void flatButton114_Click(object sender, EventArgs e)
        {
            RPC.ClonePlayer(2);
        }

        private void flatButton113_Click(object sender, EventArgs e)
        {
            RPC.ClonePlayer(3);
        }

        private void flatButton112_Click(object sender, EventArgs e)
        {
            RPC.ClonePlayer(4);
        }

        private void flatButton111_Click(object sender, EventArgs e)
        {
            RPC.ClonePlayer(5);
        }

        private void flatButton110_Click(object sender, EventArgs e)
        {
            RPC.ClonePlayer(6);
        }

        private void flatButton109_Click(object sender, EventArgs e)
        {
            RPC.ClonePlayer(7);
        }

        private void flatButton108_Click(object sender, EventArgs e)
        {
            RPC.ClonePlayer(8);
        }

        private void flatButton107_Click(object sender, EventArgs e)
        {
            RPC.ClonePlayer(9);
        }

        private void flatButton106_Click(object sender, EventArgs e)
        {
            RPC.ClonePlayer(10);
        }

        private void flatButton105_Click(object sender, EventArgs e)
        {
            RPC.ClonePlayer(11);
        }

        private void flatButton128_Click(object sender, EventArgs e)
        {
            RPC.PronePlayer(0);
        }

        private void flatButton127_Click(object sender, EventArgs e)
        {
            RPC.PronePlayer(1);
        }

        private void flatButton126_Click(object sender, EventArgs e)
        {
            RPC.PronePlayer(2);
        }

        private void flatButton125_Click(object sender, EventArgs e)
        {
            RPC.PronePlayer(3);
        }

        private void flatButton124_Click(object sender, EventArgs e)
        {
            RPC.PronePlayer(4);
        }

        private void flatButton123_Click(object sender, EventArgs e)
        {
            RPC.PronePlayer(5);
        }

        private void flatButton122_Click(object sender, EventArgs e)
        {
            RPC.PronePlayer(6);
        }

        private void flatButton121_Click(object sender, EventArgs e)
        {
            RPC.PronePlayer(7);
        }

        private void flatButton120_Click(object sender, EventArgs e)
        {
            RPC.PronePlayer(8);
        }

        private void flatButton119_Click(object sender, EventArgs e)
        {
            RPC.PronePlayer(9);
        }

        private void flatButton118_Click(object sender, EventArgs e)
        {
            RPC.PronePlayer(10);
        }

        private void flatButton117_Click(object sender, EventArgs e)
        {
            RPC.PronePlayer(11);
        }

        private void flatButton140_Click(object sender, EventArgs e)
        {
            RPC.SmallEarthQuake(0);
        }

        private void flatButton139_Click(object sender, EventArgs e)
        {
            RPC.SmallEarthQuake(1);
        }

        private void flatButton138_Click(object sender, EventArgs e)
        {
            RPC.SmallEarthQuake(2);
        }

        private void flatButton137_Click(object sender, EventArgs e)
        {
            RPC.SmallEarthQuake(3);
        }

        private void flatButton136_Click(object sender, EventArgs e)
        {
            RPC.SmallEarthQuake(4);
        }

        private void flatButton135_Click(object sender, EventArgs e)
        {
            RPC.SmallEarthQuake(5);
        }

        private void flatButton134_Click(object sender, EventArgs e)
        {
            RPC.SmallEarthQuake(6);
        }

        private void flatButton133_Click(object sender, EventArgs e)
        {
            RPC.SmallEarthQuake(7);
        }

        private void flatButton132_Click(object sender, EventArgs e)
        {
            RPC.SmallEarthQuake(8);
        }

        private void flatButton131_Click(object sender, EventArgs e)
        {
            RPC.SmallEarthQuake(9);
        }

        private void flatButton130_Click(object sender, EventArgs e)
        {
            RPC.SmallEarthQuake(10);
        }

        private void flatButton129_Click(object sender, EventArgs e)
        {
            RPC.SmallEarthQuake(11);
        }

        private void flatButton152_Click(object sender, EventArgs e)
        {
            RPC.LeaveGameOption(0);
        }

        private void flatButton151_Click(object sender, EventArgs e)
        {
            RPC.LeaveGameOption(1);
        }

        private void flatButton150_Click(object sender, EventArgs e)
        {
            RPC.LeaveGameOption(2);
        }

        private void flatButton149_Click(object sender, EventArgs e)
        {
            RPC.LeaveGameOption(3);
        }

        private void flatButton148_Click(object sender, EventArgs e)
        {
            RPC.LeaveGameOption(4);
        }

        private void flatButton147_Click(object sender, EventArgs e)
        {
            RPC.LeaveGameOption(5);
        }

        private void flatButton146_Click(object sender, EventArgs e)
        {
            RPC.LeaveGameOption(6);
        }

        private void flatButton145_Click(object sender, EventArgs e)
        {
            RPC.LeaveGameOption(7);
        }

        private void flatButton144_Click(object sender, EventArgs e)
        {
            RPC.LeaveGameOption(8);
        }

        private void flatButton143_Click(object sender, EventArgs e)
        {
            RPC.LeaveGameOption(9);
        }

        private void flatButton142_Click(object sender, EventArgs e)
        {
            RPC.LeaveGameOption(10);
        }

        private void flatButton141_Click(object sender, EventArgs e)
        {
            RPC.LeaveGameOption(11);
        }

        private void flatComboBox75_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.PlaySound(0, BIS.Sounds[flatComboBox75.SelectedIndex]);
        }

        private void flatComboBox76_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.PlaySound(1, BIS.Sounds[flatComboBox76.SelectedIndex]);
        }

        private void flatComboBox77_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.PlaySound(2, BIS.Sounds[flatComboBox77.SelectedIndex]);
        }

        private void flatComboBox78_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.PlaySound(3, BIS.Sounds[flatComboBox78.SelectedIndex]);
        }

        private void flatComboBox79_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.PlaySound(4, BIS.Sounds[flatComboBox79.SelectedIndex]);
        }

        private void flatComboBox80_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.PlaySound(5, BIS.Sounds[flatComboBox80.SelectedIndex]);
        }

        private void flatComboBox81_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.PlaySound(6, BIS.Sounds[flatComboBox81.SelectedIndex]);
        }

        private void flatComboBox82_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.PlaySound(7, BIS.Sounds[flatComboBox82.SelectedIndex]);
        }

        private void flatComboBox83_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.PlaySound(8, BIS.Sounds[flatComboBox83.SelectedIndex]);
        }

        private void flatComboBox84_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.PlaySound(9, BIS.Sounds[flatComboBox84.SelectedIndex]);
        }

        private void flatComboBox85_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.PlaySound(10, BIS.Sounds[flatComboBox85.SelectedIndex]);
        }

        private void flatComboBox86_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.PlaySound(11, BIS.Sounds[flatComboBox86.SelectedIndex]);
        }

        private void flatComboBox87_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.PlaySound(0, BIS.Sounds[flatComboBox87.SelectedIndex]);
            RPC.PlaySound(1, BIS.Sounds[flatComboBox87.SelectedIndex]);
            RPC.PlaySound(2, BIS.Sounds[flatComboBox87.SelectedIndex]);
            RPC.PlaySound(3, BIS.Sounds[flatComboBox87.SelectedIndex]);
            RPC.PlaySound(4, BIS.Sounds[flatComboBox87.SelectedIndex]);
            RPC.PlaySound(5, BIS.Sounds[flatComboBox87.SelectedIndex]);
            RPC.PlaySound(6, BIS.Sounds[flatComboBox87.SelectedIndex]);
            RPC.PlaySound(7, BIS.Sounds[flatComboBox87.SelectedIndex]);
            RPC.PlaySound(8, BIS.Sounds[flatComboBox87.SelectedIndex]);
            RPC.PlaySound(9, BIS.Sounds[flatComboBox87.SelectedIndex]);
            RPC.PlaySound(10, BIS.Sounds[flatComboBox87.SelectedIndex]);
            RPC.PlaySound(11, BIS.Sounds[flatComboBox87.SelectedIndex]);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (flatCheckBox144.Checked)
            {
                MW3.SkipTimer(0);
            }
            if (flatCheckBox143.Checked)
            {
                MW3.SkipTimer(1);
            }
            if (flatCheckBox142.Checked)
            {
                MW3.SkipTimer(2);
            }
            if (flatCheckBox141.Checked)
            {
                MW3.SkipTimer(3);
            }
            if (flatCheckBox140.Checked)
            {
                MW3.SkipTimer(4);
            }
            if (flatCheckBox139.Checked)
            {
                MW3.SkipTimer(5);
            }
            if (flatCheckBox138.Checked)
            {
                MW3.SkipTimer(6);
            }
            if (flatCheckBox137.Checked)
            {
                MW3.SkipTimer(7);
            }
            if (flatCheckBox136.Checked)
            {
                MW3.SkipTimer(8);
            }
            if (flatCheckBox135.Checked)
            {
                MW3.SkipTimer(9);
            }
            if (flatCheckBox134.Checked)
            {
                MW3.SkipTimer(10);
            }
            if (flatCheckBox133.Checked)
            {
                MW3.SkipTimer(11);
            }
        }

        private void flatButton165_Click(object sender, EventArgs e)
        {
            MW3.ClientNameChanger(0, textBox85.Text);
        }

        private void flatButton164_Click(object sender, EventArgs e)
        {
            MW3.ClientNameChanger(1, textBox73.Text);
        }

        private void flatButton163_Click(object sender, EventArgs e)
        {
            MW3.ClientNameChanger(2, textBox74.Text);
        }

        private void flatButton162_Click(object sender, EventArgs e)
        {
            MW3.ClientNameChanger(3, textBox75.Text);
        }

        private void flatButton161_Click(object sender, EventArgs e)
        {
            MW3.ClientNameChanger(4, textBox76.Text);
        }

        private void flatButton160_Click(object sender, EventArgs e)
        {
            MW3.ClientNameChanger(5, textBox77.Text);
        }

        private void flatButton159_Click(object sender, EventArgs e)
        {
            MW3.ClientNameChanger(6, textBox78.Text);
        }

        private void flatButton158_Click(object sender, EventArgs e)
        {
            MW3.ClientNameChanger(7, textBox79.Text);
        }

        private void flatButton157_Click(object sender, EventArgs e)
        {
            MW3.ClientNameChanger(8, textBox80.Text);
        }

        private void flatButton156_Click(object sender, EventArgs e)
        {
            MW3.ClientNameChanger(9, textBox81.Text);
        }

        private void flatButton155_Click(object sender, EventArgs e)
        {
            MW3.ClientNameChanger(10, textBox82.Text);
        }

        private void flatButton154_Click(object sender, EventArgs e)
        {
            MW3.ClientNameChanger(11, textBox83.Text);
        }

        private void flatButton153_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 13; i++)
            {
                 MW3.ClientNameChanger(i, textBox84.Text);
            }
        }

        private void flatButton178_Click(object sender, EventArgs e)
        {
            if (center.Checked)
            {
                RPC.iPrintln(0, textBox98.Text);
            }
            else if (bold1.Checked)
            {
                RPC.iPrintlnBold(0, textBox98.Text);
            }
        }

        private void flatButton177_Click(object sender, EventArgs e)
        {
            if (center.Checked)
            {
                RPC.iPrintln(1, textBox97.Text);
            }
            else if (bold1.Checked)
            {
                RPC.iPrintlnBold(1, textBox97.Text);
            }
        }

        private void flatButton176_Click(object sender, EventArgs e)
        {
            if (center.Checked)
            {
                RPC.iPrintln(2, textBox96.Text);
            }
            else if (bold1.Checked)
            {
                RPC.iPrintlnBold(2, textBox96.Text);
            }
        }

        private void flatButton175_Click(object sender, EventArgs e)
        {
            if (center.Checked)
            {
                RPC.iPrintln(3, textBox95.Text);
            }
            else if (bold1.Checked)
            {
                RPC.iPrintlnBold(3, textBox95.Text);
            }
        }

        private void flatButton174_Click(object sender, EventArgs e)
        {
            if (center.Checked)
            {
                RPC.iPrintln(4, textBox94.Text);
            }
            else if (bold1.Checked)
            {
                RPC.iPrintlnBold(4, textBox94.Text);
            }
        }

        private void flatButton173_Click(object sender, EventArgs e)
        {
            if (center.Checked)
            {
                RPC.iPrintln(5, textBox93.Text);
            }
            else if (bold1.Checked)
            {
                RPC.iPrintlnBold(5, textBox93.Text);
            }
        }

        private void flatButton172_Click(object sender, EventArgs e)
        {
            if (center.Checked)
            {
                RPC.iPrintln(6, textBox92.Text);
            }
            else if (bold1.Checked)
            {
                RPC.iPrintlnBold(6, textBox92.Text);
            }
        }

        private void flatButton171_Click(object sender, EventArgs e)
        {
            if (center.Checked)
            {
                RPC.iPrintln(7, textBox91.Text);
            }
            else if (bold1.Checked)
            {
                RPC.iPrintlnBold(7, textBox91.Text);
            }
        }

        private void flatButton170_Click(object sender, EventArgs e)
        {
            if (center.Checked)
            {
                RPC.iPrintln(8, textBox90.Text);
            }
            else if (bold1.Checked)
            {
                RPC.iPrintlnBold(8, textBox90.Text);
            }
        }

        private void flatButton169_Click(object sender, EventArgs e)
        {
            if (center.Checked)
            {
                RPC.iPrintln(9, textBox89.Text);
            }
            else if (bold1.Checked)
            {
                RPC.iPrintlnBold(9, textBox89.Text);
            }
        }

        private void flatButton168_Click(object sender, EventArgs e)
        {
            if (center.Checked)
            {
                RPC.iPrintln(10, textBox88.Text);
            }
            else if (bold1.Checked)
            {
                RPC.iPrintlnBold(10, textBox88.Text);
            }
        }

        private void flatButton167_Click(object sender, EventArgs e)
        {
            if (center.Checked)
            {
                RPC.iPrintln(11, textBox87.Text);
            }
            else if (bold1.Checked)
            {
                RPC.iPrintlnBold(11, textBox87.Text);
            }
        }

        private void flatButton166_Click(object sender, EventArgs e)
        {
            if (center.Checked)
            {
                RPC.iPrintln(-1, textBox86.Text);
            }
            else if (bold1.Checked)
            {
                RPC.iPrintlnBold(-1, textBox86.Text);
            }
        }

        private void flatButton179_Click(object sender, EventArgs e)
        {
            #region OtherWay
            //Form1.PS3.Extension.WriteByte(0x0110d6bf + 0x3980 * (uint) clientNum.Value, BIS.prestige[prestigeBox.SelectedIndex]);
            #endregion
            MW3.ClientsPrestigeInGame((int)clientNum.Value, BIS.prestige[prestigeBox.SelectedIndex]);
        }

        private void flatButton182_Click(object sender, EventArgs e)
        {
            textBox1.Text = MW3.GetClient(0);
            textBox2.Text = MW3.GetClient(1);
            textBox3.Text = MW3.GetClient(2);
            textBox4.Text = MW3.GetClient(3);
            textBox5.Text = MW3.GetClient(4);
            textBox6.Text = MW3.GetClient(5);
            textBox7.Text = MW3.GetClient(6);
            textBox8.Text = MW3.GetClient(7);
            textBox9.Text = MW3.GetClient(8);
            textBox10.Text = MW3.GetClient(9);
            textBox11.Text = MW3.GetClient(10);
            textBox12.Text = MW3.GetClient(11);
            textBox24.Text = MW3.GetClient(0);
            textBox23.Text = MW3.GetClient(1);
            textBox22.Text = MW3.GetClient(2);
            textBox21.Text = MW3.GetClient(3);
            textBox20.Text = MW3.GetClient(4);
            textBox19.Text = MW3.GetClient(5);
            textBox18.Text = MW3.GetClient(6);
            textBox17.Text = MW3.GetClient(7);
            textBox16.Text = MW3.GetClient(8);
            textBox15.Text = MW3.GetClient(9);
            textBox14.Text = MW3.GetClient(10);
            textBox13.Text = MW3.GetClient(11);
            textBox49.Text = MW3.GetClient(0);
            textBox48.Text = MW3.GetClient(1);
            textBox47.Text = MW3.GetClient(2);
            textBox46.Text = MW3.GetClient(3);
            textBox45.Text = MW3.GetClient(4);
            textBox44.Text = MW3.GetClient(5);
            textBox43.Text = MW3.GetClient(6);
            textBox42.Text = MW3.GetClient(7);
            textBox41.Text = MW3.GetClient(8);
            textBox40.Text = MW3.GetClient(9);
            textBox39.Text = MW3.GetClient(10);
            textBox38.Text = MW3.GetClient(11);
            textBox36.Text = MW3.GetClient(0);
            textBox35.Text = MW3.GetClient(1);
            textBox34.Text = MW3.GetClient(2);
            textBox33.Text = MW3.GetClient(3);
            textBox32.Text = MW3.GetClient(4);
            textBox31.Text = MW3.GetClient(5);
            textBox30.Text = MW3.GetClient(6);
            textBox29.Text = MW3.GetClient(7);
            textBox28.Text = MW3.GetClient(8);
            textBox27.Text = MW3.GetClient(9);
            textBox26.Text = MW3.GetClient(10);
            textBox25.Text = MW3.GetClient(11);
            textBox60.Text = MW3.GetClient(0);
            textBox59.Text = MW3.GetClient(1);
            textBox58.Text = MW3.GetClient(2);
            textBox57.Text = MW3.GetClient(3);
            textBox56.Text = MW3.GetClient(4);
            textBox55.Text = MW3.GetClient(5);
            textBox54.Text = MW3.GetClient(6);
            textBox53.Text = MW3.GetClient(7);
            textBox52.Text = MW3.GetClient(8);
            textBox51.Text = MW3.GetClient(9);
            textBox50.Text = MW3.GetClient(10);
            textBox37.Text = MW3.GetClient(11);
            textBox72.Text = MW3.GetClient(0);
            textBox71.Text = MW3.GetClient(1);
            textBox70.Text = MW3.GetClient(2);
            textBox69.Text = MW3.GetClient(3);
            textBox68.Text = MW3.GetClient(4);
            textBox67.Text = MW3.GetClient(5);
            textBox66.Text = MW3.GetClient(6);
            textBox65.Text = MW3.GetClient(7);
            textBox64.Text = MW3.GetClient(8);
            textBox63.Text = MW3.GetClient(9);
            textBox62.Text = MW3.GetClient(10);
            textBox61.Text = MW3.GetClient(11);
        }

        private void flatButton181_Click(object sender, EventArgs e)
        {
            textBox1.Text = MW3.GetClient(0);
            textBox2.Text = MW3.GetClient(1);
            textBox3.Text = MW3.GetClient(2);
            textBox4.Text = MW3.GetClient(3);
            textBox5.Text = MW3.GetClient(4);
            textBox6.Text = MW3.GetClient(5);
            textBox7.Text = MW3.GetClient(6);
            textBox8.Text = MW3.GetClient(7);
            textBox9.Text = MW3.GetClient(8);
            textBox10.Text = MW3.GetClient(9);
            textBox11.Text = MW3.GetClient(10);
            textBox12.Text = MW3.GetClient(11);
            textBox24.Text = MW3.GetClient(0);
            textBox23.Text = MW3.GetClient(1);
            textBox22.Text = MW3.GetClient(2);
            textBox21.Text = MW3.GetClient(3);
            textBox20.Text = MW3.GetClient(4);
            textBox19.Text = MW3.GetClient(5);
            textBox18.Text = MW3.GetClient(6);
            textBox17.Text = MW3.GetClient(7);
            textBox16.Text = MW3.GetClient(8);
            textBox15.Text = MW3.GetClient(9);
            textBox14.Text = MW3.GetClient(10);
            textBox13.Text = MW3.GetClient(11);
            textBox49.Text = MW3.GetClient(0);
            textBox48.Text = MW3.GetClient(1);
            textBox47.Text = MW3.GetClient(2);
            textBox46.Text = MW3.GetClient(3);
            textBox45.Text = MW3.GetClient(4);
            textBox44.Text = MW3.GetClient(5);
            textBox43.Text = MW3.GetClient(6);
            textBox42.Text = MW3.GetClient(7);
            textBox41.Text = MW3.GetClient(8);
            textBox40.Text = MW3.GetClient(9);
            textBox39.Text = MW3.GetClient(10);
            textBox38.Text = MW3.GetClient(11);
            textBox36.Text = MW3.GetClient(0);
            textBox35.Text = MW3.GetClient(1);
            textBox34.Text = MW3.GetClient(2);
            textBox33.Text = MW3.GetClient(3);
            textBox32.Text = MW3.GetClient(4);
            textBox31.Text = MW3.GetClient(5);
            textBox30.Text = MW3.GetClient(6);
            textBox29.Text = MW3.GetClient(7);
            textBox28.Text = MW3.GetClient(8);
            textBox27.Text = MW3.GetClient(9);
            textBox26.Text = MW3.GetClient(10);
            textBox25.Text = MW3.GetClient(11);
            textBox60.Text = MW3.GetClient(0);
            textBox59.Text = MW3.GetClient(1);
            textBox58.Text = MW3.GetClient(2);
            textBox57.Text = MW3.GetClient(3);
            textBox56.Text = MW3.GetClient(4);
            textBox55.Text = MW3.GetClient(5);
            textBox54.Text = MW3.GetClient(6);
            textBox53.Text = MW3.GetClient(7);
            textBox52.Text = MW3.GetClient(8);
            textBox51.Text = MW3.GetClient(9);
            textBox50.Text = MW3.GetClient(10);
            textBox37.Text = MW3.GetClient(11);
            textBox72.Text = MW3.GetClient(0);
            textBox71.Text = MW3.GetClient(1);
            textBox70.Text = MW3.GetClient(2);
            textBox69.Text = MW3.GetClient(3);
            textBox68.Text = MW3.GetClient(4);
            textBox67.Text = MW3.GetClient(5);
            textBox66.Text = MW3.GetClient(6);
            textBox65.Text = MW3.GetClient(7);
            textBox64.Text = MW3.GetClient(8);
            textBox63.Text = MW3.GetClient(9);
            textBox62.Text = MW3.GetClient(10);
            textBox61.Text = MW3.GetClient(11);
        }

        private void flatButton183_Click(object sender, EventArgs e)
        {
            textBox1.Text = MW3.GetClient(0);
            textBox2.Text = MW3.GetClient(1);
            textBox3.Text = MW3.GetClient(2);
            textBox4.Text = MW3.GetClient(3);
            textBox5.Text = MW3.GetClient(4);
            textBox6.Text = MW3.GetClient(5);
            textBox7.Text = MW3.GetClient(6);
            textBox8.Text = MW3.GetClient(7);
            textBox9.Text = MW3.GetClient(8);
            textBox10.Text = MW3.GetClient(9);
            textBox11.Text = MW3.GetClient(10);
            textBox12.Text = MW3.GetClient(11);
            textBox24.Text = MW3.GetClient(0);
            textBox23.Text = MW3.GetClient(1);
            textBox22.Text = MW3.GetClient(2);
            textBox21.Text = MW3.GetClient(3);
            textBox20.Text = MW3.GetClient(4);
            textBox19.Text = MW3.GetClient(5);
            textBox18.Text = MW3.GetClient(6);
            textBox17.Text = MW3.GetClient(7);
            textBox16.Text = MW3.GetClient(8);
            textBox15.Text = MW3.GetClient(9);
            textBox14.Text = MW3.GetClient(10);
            textBox13.Text = MW3.GetClient(11);
            textBox49.Text = MW3.GetClient(0);
            textBox48.Text = MW3.GetClient(1);
            textBox47.Text = MW3.GetClient(2);
            textBox46.Text = MW3.GetClient(3);
            textBox45.Text = MW3.GetClient(4);
            textBox44.Text = MW3.GetClient(5);
            textBox43.Text = MW3.GetClient(6);
            textBox42.Text = MW3.GetClient(7);
            textBox41.Text = MW3.GetClient(8);
            textBox40.Text = MW3.GetClient(9);
            textBox39.Text = MW3.GetClient(10);
            textBox38.Text = MW3.GetClient(11);
            textBox36.Text = MW3.GetClient(0);
            textBox35.Text = MW3.GetClient(1);
            textBox34.Text = MW3.GetClient(2);
            textBox33.Text = MW3.GetClient(3);
            textBox32.Text = MW3.GetClient(4);
            textBox31.Text = MW3.GetClient(5);
            textBox30.Text = MW3.GetClient(6);
            textBox29.Text = MW3.GetClient(7);
            textBox28.Text = MW3.GetClient(8);
            textBox27.Text = MW3.GetClient(9);
            textBox26.Text = MW3.GetClient(10);
            textBox25.Text = MW3.GetClient(11);
            textBox60.Text = MW3.GetClient(0);
            textBox59.Text = MW3.GetClient(1);
            textBox58.Text = MW3.GetClient(2);
            textBox57.Text = MW3.GetClient(3);
            textBox56.Text = MW3.GetClient(4);
            textBox55.Text = MW3.GetClient(5);
            textBox54.Text = MW3.GetClient(6);
            textBox53.Text = MW3.GetClient(7);
            textBox52.Text = MW3.GetClient(8);
            textBox51.Text = MW3.GetClient(9);
            textBox50.Text = MW3.GetClient(10);
            textBox37.Text = MW3.GetClient(11);
            textBox72.Text = MW3.GetClient(0);
            textBox71.Text = MW3.GetClient(1);
            textBox70.Text = MW3.GetClient(2);
            textBox69.Text = MW3.GetClient(3);
            textBox68.Text = MW3.GetClient(4);
            textBox67.Text = MW3.GetClient(5);
            textBox66.Text = MW3.GetClient(6);
            textBox65.Text = MW3.GetClient(7);
            textBox64.Text = MW3.GetClient(8);
            textBox63.Text = MW3.GetClient(9);
            textBox62.Text = MW3.GetClient(10);
            textBox61.Text = MW3.GetClient(11);
        }

        private void flatButton180_Click(object sender, EventArgs e)
        {
            textBox1.Text = MW3.GetClient(0);
            textBox2.Text = MW3.GetClient(1);
            textBox3.Text = MW3.GetClient(2);
            textBox4.Text = MW3.GetClient(3);
            textBox5.Text = MW3.GetClient(4);
            textBox6.Text = MW3.GetClient(5);
            textBox7.Text = MW3.GetClient(6);
            textBox8.Text = MW3.GetClient(7);
            textBox9.Text = MW3.GetClient(8);
            textBox10.Text = MW3.GetClient(9);
            textBox11.Text = MW3.GetClient(10);
            textBox12.Text = MW3.GetClient(11);
            textBox24.Text = MW3.GetClient(0);
            textBox23.Text = MW3.GetClient(1);
            textBox22.Text = MW3.GetClient(2);
            textBox21.Text = MW3.GetClient(3);
            textBox20.Text = MW3.GetClient(4);
            textBox19.Text = MW3.GetClient(5);
            textBox18.Text = MW3.GetClient(6);
            textBox17.Text = MW3.GetClient(7);
            textBox16.Text = MW3.GetClient(8);
            textBox15.Text = MW3.GetClient(9);
            textBox14.Text = MW3.GetClient(10);
            textBox13.Text = MW3.GetClient(11);
            textBox49.Text = MW3.GetClient(0);
            textBox48.Text = MW3.GetClient(1);
            textBox47.Text = MW3.GetClient(2);
            textBox46.Text = MW3.GetClient(3);
            textBox45.Text = MW3.GetClient(4);
            textBox44.Text = MW3.GetClient(5);
            textBox43.Text = MW3.GetClient(6);
            textBox42.Text = MW3.GetClient(7);
            textBox41.Text = MW3.GetClient(8);
            textBox40.Text = MW3.GetClient(9);
            textBox39.Text = MW3.GetClient(10);
            textBox38.Text = MW3.GetClient(11);
            textBox36.Text = MW3.GetClient(0);
            textBox35.Text = MW3.GetClient(1);
            textBox34.Text = MW3.GetClient(2);
            textBox33.Text = MW3.GetClient(3);
            textBox32.Text = MW3.GetClient(4);
            textBox31.Text = MW3.GetClient(5);
            textBox30.Text = MW3.GetClient(6);
            textBox29.Text = MW3.GetClient(7);
            textBox28.Text = MW3.GetClient(8);
            textBox27.Text = MW3.GetClient(9);
            textBox26.Text = MW3.GetClient(10);
            textBox25.Text = MW3.GetClient(11);
            textBox60.Text = MW3.GetClient(0);
            textBox59.Text = MW3.GetClient(1);
            textBox58.Text = MW3.GetClient(2);
            textBox57.Text = MW3.GetClient(3);
            textBox56.Text = MW3.GetClient(4);
            textBox55.Text = MW3.GetClient(5);
            textBox54.Text = MW3.GetClient(6);
            textBox53.Text = MW3.GetClient(7);
            textBox52.Text = MW3.GetClient(8);
            textBox51.Text = MW3.GetClient(9);
            textBox50.Text = MW3.GetClient(10);
            textBox37.Text = MW3.GetClient(11);
            textBox72.Text = MW3.GetClient(0);
            textBox71.Text = MW3.GetClient(1);
            textBox70.Text = MW3.GetClient(2);
            textBox69.Text = MW3.GetClient(3);
            textBox68.Text = MW3.GetClient(4);
            textBox67.Text = MW3.GetClient(5);
            textBox66.Text = MW3.GetClient(6);
            textBox65.Text = MW3.GetClient(7);
            textBox64.Text = MW3.GetClient(8);
            textBox63.Text = MW3.GetClient(9);
            textBox62.Text = MW3.GetClient(10);
            textBox61.Text = MW3.GetClient(11);
        }

        private void flatButton184_Click(object sender, EventArgs e)
        {
            MW3.NameCHanger(nameBox1.Text);
        }

        private void vsatToggle_CheckedChanged(object sender)
        {
            if (vsatToggle.Checked)
            {
                MW3.VSAT(true);
            }
            else
            {
                MW3.VSAT(false);
            }
        }

        private void wallbreakToggle_CheckedChanged(object sender)
        {
            if (wallbreakToggle.Checked)
            {
                MW3.WallBreak(true);
            }
            else
            {
                MW3.WallBreak(false);
            }
        }

        private void chromeToggle_CheckedChanged(object sender)
        {
            if (chromeToggle.Checked)
            {
                MW3.ChromePlayer(true);
            }
            else
            {
                MW3.ChromePlayer(false);
            }
        }

        private void redboxToggle_CheckedChanged(object sender)
        {
            if (redboxToggle.Checked)
            {
                MW3.REDBOXNonHost(true);
            }
            else
            {
                MW3.REDBOXNonHost(false);
            }
        }

        private void flatButton188_Click(object sender, EventArgs e)
        {
            RPC.RestartGame();
        }

        private void flatButton185_Click(object sender, EventArgs e)
        {
            RPC.TimeLimit((int)timeBox.Value);
        }

        private void flatButton187_Click(object sender, EventArgs e)
        {
            RPC.ScoreLimit((int)scoreBox.Value);
        }

        private void flatButton189_Click(object sender, EventArgs e)
        {
            RPC.CBuf_AddText(0, BIS.GameMods[gamemodBox.SelectedIndex]);
            RPC.RestartGame();
        }

        private void flatButton190_Click(object sender, EventArgs e)
        {
            RPC.LifeNum((int)lifeNum.Value);
        }

        private void flatButton29_Click(object sender, EventArgs e)
        {
            MW3._5La6((int)_5la6Num.Value - 1); 
        }

        private void flatButton191_Click(object sender, EventArgs e)
        {
            MW3.MP4Sec((int)mp4Num.Value - 1);
        }

        private void flatButton192_Click(object sender, EventArgs e)
        {
            MW3.MagnomSec((int)magnumNum.Value - 1);
        }

        private void laserCheck_CheckedChanged(object sender)
        {
            if (laserCheck.Checked)
            {
                MW3.Laser(true);
            }
            else
            {
                MW3.Laser(false);
            }
        }

        private void noRecoil_CheckedChanged(object sender)
        {
            if (noRecoil.Checked)
            {
                MW3.NoRecoil(true);
            }
            else
            {
                MW3.NoRecoil(false);
            }
        }

        private void thirdPerson_CheckedChanged(object sender)
        {
            if (thirdPerson.Checked)
            {
                MW3.ThirdPerson(true);
            }
            else
            {
                MW3.ThirdPerson(false);
            }
        }

        private void flatButton193_Click(object sender, EventArgs e)
        {
            MW3.LeftMessageFromCollofDuty(leftMessageBox.Text);
        }

        private void flatButton206_Click(object sender, EventArgs e)
        {
            LocationBytes =  MW3.SaveLocation((uint)clientLocation.Value);
        }

        private void flatButton205_Click(object sender, EventArgs e)
        {
            MW3.LoadLocation(0, LocationBytes);
        }

        private void flatButton204_Click(object sender, EventArgs e)
        {
            MW3.LoadLocation(1, LocationBytes);
        }

        private void flatButton203_Click(object sender, EventArgs e)
        {
            MW3.LoadLocation(2, LocationBytes);
        }

        private void flatButton202_Click(object sender, EventArgs e)
        {
            MW3.LoadLocation(3, LocationBytes);
        }

        private void flatButton201_Click(object sender, EventArgs e)
        {
            MW3.LoadLocation(4, LocationBytes);
        }

        private void flatButton199_Click(object sender, EventArgs e)
        {
            MW3.LoadLocation(5, LocationBytes);
        }

        private void flatButton200_Click(object sender, EventArgs e)
        {
            MW3.LoadLocation(6, LocationBytes);
        }

        private void flatButton198_Click(object sender, EventArgs e)
        {
            MW3.LoadLocation(7, LocationBytes);
        }

        private void flatButton197_Click(object sender, EventArgs e)
        {
            MW3.LoadLocation(8, LocationBytes);
        }

        private void flatButton196_Click(object sender, EventArgs e)
        {
            MW3.LoadLocation(9, LocationBytes);
        }

        private void flatButton195_Click(object sender, EventArgs e)
        {
            MW3.LoadLocation(10, LocationBytes);
        }

        private void flatButton194_Click(object sender, EventArgs e)
        {
            MW3.LoadLocation(11, LocationBytes);
        }

        private void autTeleportTi_Tick(object sender, EventArgs e)
        {
            if (flatCheckBox156.Checked)
            {
                MW3.LoadLocation(0, LocationBytes);
            }
            if (flatCheckBox155.Checked)
            {
                MW3.LoadLocation(1, LocationBytes);
            }
            if (flatCheckBox154.Checked)
            {
                MW3.LoadLocation(2, LocationBytes);
            }
            if (flatCheckBox153.Checked)
            {
                MW3.LoadLocation(3, LocationBytes);
            }
            if (flatCheckBox152.Checked)
            {
                MW3.LoadLocation(4, LocationBytes);
            }
            if (flatCheckBox151.Checked)
            {
                MW3.LoadLocation(5, LocationBytes);
            }
            if (flatCheckBox150.Checked)
            {
                MW3.LoadLocation(6, LocationBytes);
            }
            if (flatCheckBox149.Checked)
            {
                MW3.LoadLocation(7, LocationBytes);
            }
            if (flatCheckBox148.Checked)
            {
                MW3.LoadLocation(8, LocationBytes);
            }
            if (flatCheckBox147.Checked)
            {
                MW3.LoadLocation(9, LocationBytes);
            }
            if (flatCheckBox146.Checked)
            {
                MW3.LoadLocation(10, LocationBytes);
            }
            if (flatCheckBox145.Checked)
            {
                MW3.LoadLocation(11, LocationBytes);
            }
        }

        private void flatCheckBox156_CheckedChanged(object sender)
        {
            if (flatCheckBox156.Checked)
            {
                autTeleportTi.Start();
            }
        }

        private void flatCheckBox155_CheckedChanged(object sender)
        {
            if (flatCheckBox155.Checked)
            {
                autTeleportTi.Start();
            }
        }

        private void flatCheckBox154_CheckedChanged(object sender)
        {
            if (flatCheckBox154.Checked)
            {
                autTeleportTi.Start();
            }
        }

        private void flatCheckBox153_CheckedChanged(object sender)
        {
            if (flatCheckBox153.Checked)
            {
                autTeleportTi.Start();
            }
        }

        private void flatCheckBox152_CheckedChanged(object sender)
        {
            if (flatCheckBox152.Checked)
            {
                autTeleportTi.Start();
            }
        }

        private void flatCheckBox151_CheckedChanged(object sender)
        {
            if (flatCheckBox151.Checked)
            {
                autTeleportTi.Start();
            }
        }

        private void flatCheckBox150_CheckedChanged(object sender)
        {
            if (flatCheckBox150.Checked)
            {
                autTeleportTi.Start();
            }
        }

        private void flatCheckBox149_CheckedChanged(object sender)
        {
            if (flatCheckBox149.Checked)
            {
                autTeleportTi.Start();
            }
        }

        private void flatCheckBox148_CheckedChanged(object sender)
        {
            if (flatCheckBox148.Checked)
            {
                autTeleportTi.Start();
            }
        }

        private void flatCheckBox147_CheckedChanged(object sender)
        {
            if (flatCheckBox147.Checked)
            {
                autTeleportTi.Start();
            }
        }

        private void flatCheckBox146_CheckedChanged(object sender)
        {
            if (flatCheckBox146.Checked)
            {
                autTeleportTi.Start();
            }
        }

        private void flatCheckBox145_CheckedChanged(object sender)
        {
            if (flatCheckBox145.Checked)
            {
                autTeleportTi.Start();
            }
        }

        private void rainbowName_Tick(object sender, EventArgs e)
        {

        }

        private void rainBowNameBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void setClanBtn_Click(object sender, EventArgs e)
        {
            MW3.ClanChanger(clanBox1.Text);
        }

        private void flatToggle1_CheckedChanged(object sender)
        {
            if (flatToggle1.Checked)
            {
                MW3.JumpLoppy(MW3.jumpHigh);
            }
            else
            {
                MW3.JumpLoppy(MW3.jumpNormal);
            }
        }

        private void flatToggle5_CheckedChanged(object sender)
        {
            if (flatToggle1.Checked)
            {
                MW3.JumpLoppy(MW3.jumpHigh);
            }
            else
            {
                MW3.JumpLoppy(MW3.jumpNormal);
            }
        }

        private void flatToggle2_CheckedChanged(object sender)
        {
            if (flatToggle2.Checked)
            {
                MW3.SpeedLobby(true);
            }
            else
            {
                MW3.SpeedLobby(false);
            }
        }
        // uint offs = 0x001bbbc2c;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            timer2.Start();
        }
        void DiscoLetters(uint offset, string Text)
        {

                for (int i = 0; i < Text.Length; i++)
                {
                    int flash = new Random().Next(0, 9);
                    char[] chr = Text.ToCharArray(0, Text.Length);
                    frmMain.PS3.Extension.WriteString(offset, "^" + flash + chr[i]);
                    //if (offset == (offset + 30))
                    //    offset = 0x001bbbc2c;
                    offset += 3;
                   
                    Application.DoEvents();
                }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DiscoLetters(0x001bbbc2c, nameBox1.Text);
        }
    }
}
