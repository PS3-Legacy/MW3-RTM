
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MW3_Tool_By_BISOON
{
    class MW3
    {
        static uint Pramirey1 = 0x1C19803;
        static uint Sec = Pramirey1 + 0xd;
        static uint Client0Name = 0x0110D694;
        static uint Client1Name = 0x01111014;
        static uint Client2Name = 0x01114994;
        static uint Client3Name = 0x01118314;
        static uint Client4Name = 0x0111BC94;
        static uint Client5Name = 0x0111F614;
        static uint Client6Name = 0x01122F94;
        static uint Client7Name = 0x01126914;
        static uint Client8Name = 0x0112A294;
        static uint Client9Name = 0x0112DC14;
        static uint Client10Name = 0x01131594;
        static uint Client11Name = 0x01134F14;


        public static void ClassNmae(int Class, string name)
        {
            frmMain.PS3.Extension.WriteString(0x01c1982c + 0x62 * (uint)Class, name);
        }

        public static void ClassGodMode(int Class)
        {
            frmMain.PS3.SetMemory(0x01c1985f + 62 * (uint)Class, new byte[]{0x4F}); //need update
        }

        public static void ClientsPrestigeInGame(int Client, byte prestigeNum)
        {
            frmMain.PS3.Extension.WriteByte(0x0110d6bf + 0x3980 * (uint)Client, prestigeNum);
        }

        public static void ClientNameChanger(int Client, string name)
        {
            frmMain.PS3.Extension.WriteString(0x0110D694 + 0x3980 * (uint)Client, name);
        }
        public static string GetClient(int Client)
        {
            return frmMain.PS3.Extension.ReadString(Client0Name + 0x3980 * (uint)Client);
        }
        public static string GetClient0()
        {
            return frmMain.PS3.Extension.ReadString(Client0Name);
        }
        public static string GetClient1()
        {
            return frmMain.PS3.Extension.ReadString(Client1Name);
        }
        public static string GetClient2()
        {
            return frmMain.PS3.Extension.ReadString(Client2Name);
        }
        public static string GetClient3()
        {
            return frmMain.PS3.Extension.ReadString(Client3Name);
        }
        public static string GetClient4()
        {
            return frmMain.PS3.Extension.ReadString(Client4Name);
        }
        public static string GetClient5()
        {
            return frmMain.PS3.Extension.ReadString(Client5Name);
        }
        public static string GetClient6()
        {
            return frmMain.PS3.Extension.ReadString(Client6Name);
        }
        public static string GetClient7()
        {
            return frmMain.PS3.Extension.ReadString(Client7Name);
        }
        public static string GetClient8()
        {
            return frmMain.PS3.Extension.ReadString(Client8Name);
        }
        public static string GetClient9()
        {
            return frmMain.PS3.Extension.ReadString(Client9Name);
        }
        public static string GetClient10()
        {
            return frmMain.PS3.Extension.ReadString(Client10Name);
        }
        public static string GetClient11()
        {
            return frmMain.PS3.Extension.ReadString(Client11Name);
        }
        public static string UserName()
        {
            return frmMain.PS3.Extension.ReadString(0x001bbbc2c);
        }
        public static void NameCHanger(string name)
        {
            frmMain.PS3.Extension.WriteString(0x001bbbc2c, name);
        }

        public static void ClanChanger(string Clan)
        {
            frmMain.PS3.Extension.WriteString(0x892c0e, Clan);
        }
        public static void RedBoxOn( bool tr)
        {
            if (tr)
            {
                frmMain.PS3.SetMemory(0x65D14, new byte[] { 0x60, 0x00, 0x00, 0x00 });
            }
            else
            {
                frmMain.PS3.SetMemory(0x65D14, new byte[] { 0x00, 0x00, 0x00, 0x00 });
            }
            
        }
        public static void SuperUAV(bool ua)
        {
            if (ua)
            {
                frmMain.PS3.SetMemory(0x5F067, new byte[] { 0x02 });
            }
            else
            {
                frmMain.PS3.SetMemory(0x5F067, new byte[] { 0x01 });
            }
        }
        public static void GodModClass(int Class)
        {
            frmMain.PS3.SetMemory(0x1C19803 + 0x62 * (uint)Class, new byte[] { 
                1, 0x27, 0, 9, 0, 0, 0, 0, 0, 0x86, 0, 0, 0, 7, 0, 9, 
                0, 0, 0, 0, 0, 0x86, 0, 0, 0, 0x6a, 0, 0x15, 0, 0x11, 0, 8, 
                0, 0, 0, 0x61, 0, 0x83, 0, 0, 0, 0x73, 0x77, 0x61, 0x67, 0x2e, 0x63, 0x6c, 
                0x61, 0x73, 0x73, 0, 0x73, 0x73, 0x20, 80, 0, 0x54, 0x20, 0x31, 0, 0, 0x76, 0, 
                0x20, 0, 0x20, 0, 0x20, 0, 0x13, 0, 0x20, 0, 0x19, 0, 0x2d, 0, 0x26, 0, 
                0x27, 0, 2, 0, 0, 0, 4, 0, 0, 0, 6, 0, 0x6b, 0, 0, 0, 
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x37
             });
        }

        public static void GodMod(int client , bool gd)
        {
            if (gd)
            {
                frmMain.PS3.SetMemory(0x0FCA41E + 0x280 * (uint)client, new byte[] { 0xFF});
            }
            else
            {
                frmMain.PS3.SetMemory(0x0FCA41E + 0x280 * (uint)client, new byte[] { 0x00 });
            }
            
        }
        public static void KillAllLobby()
        {
            frmMain.PS3.SetMemory(0x00173b82, new byte[] { 0 });
            Thread.Sleep(1000);
            frmMain.PS3.SetMemory(0x00173b82, new byte[] { 0x18 });
        }

        public static void KillPlayer(int Client)
        {
            frmMain.PS3.SetMemory(0x0110a2a5 + 0x3980 * (uint)Client, new byte[] { 0xff, 0xff });
        }
        public static void UFO(int client, bool U)
        {
            if (U)
            {
                frmMain.PS3.SetMemory(0x0110d87f + 0x3980 * (uint)client, new byte[] { 0x02 });
            }
            else
            {
                frmMain.PS3.SetMemory(0x0110d87f + 0x3980 * (uint)client, new byte[] { 0x00 });
            }
            
        }
        public static void WeaponAmmo(int client)
        {
            frmMain.PS3.SetMemory((uint)((0x110a280 + 0x428 + (client * 0x3980))), new byte[] { 15, 0xff, 0xff, 0xff, 15, 0xff, 0xff, 0xff });
            frmMain.PS3.SetMemory((uint)((0x110a280 + 0x3a8 + (client * 0x3980))), new byte[] { 15, 0xff, 0xff, 0xff, 15, 0xff, 0xff, 0xff });
            frmMain.PS3.SetMemory((uint)((0x110a280 + 0x920 + (client * 0x3980))), new byte[] { 15, 0xff, 0xff, 0xff, 15, 0xff, 0xff, 0xff });
            frmMain.PS3.SetMemory((uint)((0x110a280 + 0x410 + (client * 0x3980))), new byte[] { 15, 0xff, 0xff, 0xff, 15, 0xff, 0xff, 0xff });
            frmMain.PS3.SetMemory((uint)((0x110a280 + 0x434 + (client * 0x3980))), new byte[] { 15, 0xff, 0xff, 0xff, 15, 0xff, 0xff, 0xff });
            frmMain.PS3.SetMemory((uint)((0x110a280 + 0x41c + (client * 0x3980))), new byte[] { 15, 0xff, 0xff, 0xff, 15, 0xff, 0xff, 0xff });
        }

        public static void AdvancedUAV4Client(int Client, bool yes)
        {
            if (yes)
            {
                frmMain.PS3.SetMemory(0x5F067 + 0x3980 * (uint)Client, new byte[] { 0x02 });
            }
            else
            {
                frmMain.PS3.SetMemory(0x5F067 + 0x3980 * (uint)Client, new byte[] { 0x01 });
            }
            
        }
        public static void JumpLoppy( byte[] jl)
        {
            frmMain.PS3.SetMemory(0x000019780, jl);
        }
       public static byte[] jumpHigh = new byte[] { 0x43, 0xf5, 0xb0, };
       public static byte[] jumpNormal = new byte[] { 0x42, 0x9c, 0x00 };

       public static void SpeedLobby(bool tru)
       {
           if (tru)
           {
               frmMain.PS3.SetMemory(0x000173bb0, new byte[] { 0x38, 0xa0, 0x01, 0xd0 });
           }
           else
           {
               frmMain.PS3.SetMemory(0x000173bb0, new byte[] { 0x38, 0xa0, 0x00, 0xbe });
           }
       }

        public static void FREEZEPLAYER(int client, bool FR)
       {
            if (FR)
            {
                frmMain.PS3.SetMemory(0x0110d87f + 0x3980 * (uint)client, new byte[] { 0x07 });
            }
            else
            {
                frmMain.PS3.SetMemory(0x0110d87f + 0x3980 * (uint)client, new byte[] { 0x00 });
            } 
       }

        public static void REDBOXK(int Clint, bool Red)
        {
            if (Red)
            {
                frmMain.PS3.SetMemory(0x0110A293 + 0x3980 * (uint)Clint, new byte[] { 0x10 });
            }
            else
            {
                frmMain.PS3.SetMemory(0x0110A293 + 0x3980 * (uint)Clint, new byte[] { 0x00 });
            }
            
        }

        public static void WALLHACKK(int Clint, byte[] WALL)
        {
            frmMain.PS3.SetMemory(0x00173b62 + 0x3980 * (uint)Clint, WALL);
        }
        public static byte[] WALLHACKKOn = new byte[] { 0x01, 0x2C };
        public static byte[] WALLHACKKOff = new byte[] { 0x02, 0x81 };

        //public static void ClanChanger(string txt)
        //{
        //    Form1.PS3.Extension.WriteString(0x00892C34, txt);
        //}
        public static void ClanIsOn(byte[]C)
        {
            frmMain.PS3.SetMemory(0x00892C15, C);
            frmMain.PS3.SetMemory(0x00892C14, C);
        }
        public static byte[] ClanByteOn = new byte[] {0x01 };
        public static byte[] ClanByteOff = new byte[] { 0x00 };

        public static void GoldenClan(byte[]Go)
        {
            frmMain.PS3.SetMemory(0x00892C13, Go);
        }
        public static byte[] GoldenClanOn= new byte[] { 0x01 };
        public static byte[] GoldenClanOff = new byte[] { 0x00 };

        public static void ExplosiveBullets(int Client, bool Ex)
        {
            if (Ex)
            {
                frmMain.PS3.SetMemory(0x0110A773 + 0x3980 * (uint)Client, new byte[] { 0xC5, 0xFF });
            }
            else
            {
                frmMain.PS3.SetMemory(0x0110A773 + 0x3980 * (uint)Client, new byte[] { 0x00, 0x00 });
            }
        }
        

        public static void DolphinDiv(int Client, bool Do)
        {
            if (Do)
            {
                frmMain.PS3.SetMemory(0x0110A773 + 0x3980 * (uint)Client, new byte[] { 0xFF, 0x00 });
            }
            else
            {
                frmMain.PS3.SetMemory(0x0110A773 + 0x3980 * (uint)Client, new byte[] { 0xC5, 0xFF });
            }
        }

        public static void NightVision(int Client, bool tr)
        {
            if (tr)
            {
                //Form1.PS3.SetMemory(0x0110a5f7 + 0x3980 * (uint)Client, new byte[] { 0xFF });
                frmMain.PS3.SetMemory((uint)(0x110a7a3 + (Client * 0x3980)), new byte[] { 0xff });
                RPC.SV_GameSendServerCommand(0, "c \"^7Press [{+actionslot 3}] for ^2Night ^2Vision\"");
            }
            else
            {
                //Form1.PS3.SetMemory(0x0110a5f7 + 0x3980 * (uint)Client, new byte[] { 0x00 });
                frmMain.PS3.SetMemory((uint)(0x110a7a3 + (Client * 0x3980)), new byte[] { 0x00 });
            }
        }


        public static void  AllPerks(int Client)
        {
            frmMain.PS3.SetMemory((uint)(0x110a73f + (Client * 0x3980)), new byte[] { 
                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
                        0, 0, 0, 0, 0, 0, 12, 0x30, 0x8e, 0, 0, 0, 0, 0, 0, 0, 
                        0, 0, 0, 0, 0, 0, 0, 7, 0xff, 0, 0, 0, 0, 0, 0xff, 0xff, 
                        0xff, 0xff, 0xff, 0xff
                     });
        }


        public static void SpeedPlayer(int Client, bool yes)
        {
            if (yes)
            {
                frmMain.PS3.SetMemory((uint)(0x110d62c + (Client * 0x3980)), new byte[] { 
                    0, 0, 0, 100, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
                    0, 0, 0, 0, 0x3f, 0xff});
            }
            else
            {
                frmMain.PS3.SetMemory((uint)(0x110d62c + (Client * 0x3980)), new byte[] { 
                    0, 0, 0, 100, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
                    0, 0, 0, 0, 0x3f, 0x80
                 });
            }
        }

        public static void WallHack(int Client, bool Wa)
        {
            if (Wa)
            {
                //Form1.PS3.SetMemory((uint)(0x0110A292 + (3980*Client)), new byte[] { 0x10, 0x00, 0x00, 0x00, 0x00, 0x09 });
                frmMain.PS3.SetMemory(0x0110A292 + 640 * (uint)Client, new byte[] { 0x10, 0x00, 0x00, 0x00, 0x00, 0x09 });
            }
            else
            {
                frmMain.PS3.SetMemory((uint)(0x018C6476 + (Client * 3980)), new byte[] { 0x58, 0x40, 0x00, 0x56, 0x76, 0x14, 0x00, 0x04, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            }
        }

        public static void RemoveWeapon(int Client)
        {

                frmMain.PS3.SetMemory(0x0110a4fd + (0x3980 * (uint)Client), new byte[] { 0x00, 0x00, 0x00 });
                frmMain.PS3.SetMemory(0x0110a5f1 + (0x3980 * (uint)Client), new byte[] { 0x00, 0x00, 0x00 });
                frmMain.PS3.SetMemory(0x0110a6a5 + (0x3980 * (uint)Client), new byte[] { 0x00, 0x00, 0x00 });
                frmMain.PS3.SetMemory(0x0110a4f5 + (0x3980 * (uint)Client), new byte[] { 0x00, 0x00, 0x00 });
                frmMain.PS3.SetMemory(0x0110a5f1 + (0x3980 * (uint)Client), new byte[] { 0x00, 0x00, 0x00 });
                frmMain.PS3.SetMemory(0x0110a68d + (0x3980 * (uint)Client), new byte[] { 0x00, 0x00, 0x00 });
        }

        public static void PS3Freeze(int Client)
        {
            frmMain.PS3.SetMemory(0x0110A4FF + (((uint)Client * 0x3980)), new byte[] { 0x80 });
            frmMain.PS3.SetMemory(0x0110a4f7 + (((uint)Client * 0x3980)), new byte[] { 0x80 });
            frmMain.PS3.SetMemory(0x0110a503 + (((uint)Client * 0x3980)), new byte[] { 0x80 });
            frmMain.PS3.SetMemory(0x0110a69b + (((uint)Client * 0x3980)), new byte[] { 0x80 });
        }


        public static void Teleport(int client, int Client)
        {
            byte[] TELEP1 = new byte[12];
            frmMain.PS3.GetMemory(0x0110A29C + 0x3980 * (uint)client, TELEP1);
            //for (UInt32 i = 0; i < 18; i++)
            frmMain.PS3.SetMemory(0x0110A29C + 0x3980 * (uint)Client, TELEP1);
        }

        public static void PlayerDie(uint Client)
        {
            frmMain.PS3.Extension.WriteByte(0xFCA381 + (Client * 0x280), 1);
            Thread.Sleep(500);
            frmMain.PS3.Extension.WriteByte(0xFCA381 + (Client * 0x280), 0);
        }
        public static void ClientSpin(uint Client, double Speed = 1)
        {//Thanks To //GMTPS3\\
            for (float X = -180; X < 180; )
            {
                frmMain.PS3.Extension.WriteFloat(0x0110a2e4 + (Client * 0x3980), X);
                X += (float)Speed;
            }
        }
        public static void SkipTimer(int Client)
        {
            frmMain.PS3.SetMemory(0x0110d87F + 0x3980 * (uint)Client, new byte[] { 0x00 });
        }

        public static void VSAT(bool tru)
        {
            if (tru)
            {
                frmMain.PS3.SetMemory(0x5F067, new byte[] { 0x02 });
            }
            else
            {
                frmMain.PS3.SetMemory(0x5F067, new byte[] { 0x01 });
            }
        }

        public static void REDBOXNonHost(bool tru)
        {
            if (tru)
            {
                frmMain.PS3.SetMemory(0x65D14, new byte[] { 0x60, 0x00, 0x00, 0x00 });
            }
            else
            {
                frmMain.PS3.SetMemory(0x65D14, new byte[] { 0x41, 0x82, 0x00, 0x0c });
            }
        }


        public static void ChromePlayer(bool tru)
        {
            if (tru)
            {
                frmMain.PS3.SetMemory(0x3984DF, new byte[] { 0x01 });
                frmMain.PS3.SetMemory(0x3984F2, new byte[] { 0x05, 0x70 });
            }
            else
            {
                frmMain.PS3.SetMemory(0x3984DF, new byte[] { 0x00 });
                frmMain.PS3.SetMemory(0x3984F2, new byte[] { 0x05, 0x6A });
            }
        }

        public static void WallBreak(bool tru)
        {
            if (tru)
            {
                frmMain.PS3.SetMemory(0x00173b62, new byte[] { 0x01, 0x2C });
            }
            else
            {
                frmMain.PS3.SetMemory(0x00173b62, new byte[] { 0x02 , 0x81 });
            }
        }

        public static void _5La6(int Num)
        {
            frmMain.PS3.SetMemory(Pramirey1 + 0x62 * (uint)Num, new byte[] { 0x0b, 0x5A });
        }
        public static void MP4Sec(int Num)
        {
            frmMain.PS3.SetMemory(Sec + 0x62 * (uint)Num, new byte[] { 0x02, 0x00 , 0x12 });
        }
        public static void MagnomSec(int Num)
        {
            frmMain.PS3.SetMemory(Sec + 0x62 * (uint)Num, new byte[] { 0x03, 0x00, 0x12 });
        }
        public static void Laser(bool yes)
        {
            if (yes)
            {
                frmMain.PS3.SetMemory(0x000b6703, new byte[] { 0x01 });
            }
            else
            {
                frmMain.PS3.SetMemory(0x000b6703, new byte[] { 0x00 });
            }
        }

        public static void NoRecoil(bool yes)
        {
            if (yes)
            {
                frmMain.PS3.SetMemory(0xBE6D0, new byte[] { 0x60, 0x00, 0x00, 0x00 });
            }
            else
            {
                frmMain.PS3.SetMemory(0xBE6D0, new byte[] {0x4B, 0xF8, 0x15, 0x01 });
            }
        }

        public static void ThirdPerson(bool third)
        {
            if (third)
            {
                frmMain.PS3.SetMemory(0x18CCE7C, new byte[] { 0x01 });
            }
            else
            {
                frmMain.PS3.SetMemory(0x18CCE7C, new byte[] { 0x00 });
            }
        }

        public static void LeftMessageFromCollofDuty(string text)
        {
            frmMain.PS3.Extension.WriteString(0x008930c4, text);
        }

        public static void FPS(bool tru)
        {
            if (tru)
            {
                frmMain.PS3.SetMemory(0x277208, new byte[] { 0x41, 0x00 });
            }
            else
            {
                frmMain.PS3.SetMemory(0x277208, new byte[] { 0x41, 0x82 });
            }
        }


        public static void ReadyClassSniper()
        {
            frmMain.PS3.SetMemory(Pramirey1 , new byte[]{0x0B, 0x28, 0x00, 0x09, 0x00, 0x00, 0x00, 0x0D, 0x00, 0x84, 0x00, 0x00, 0x00, 0x03, 0x00, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x65, 0x00, 0x09, 0x00, 0x4E,
            0x00, 0x0C, 0x00, 0x00, 0x00, 0x5E, 0x00, 0x6E, 0x00, 0x00, 0x00, 0x43, 0x75, 0x73, 0x74, 0x6F, 0x6D, 0x20, 0x43, 0x6C,
            0x61, 0x73, 0x73, 0x20, 0x31, 0x00, 0x6C, 0x61, 0x73, 0x73 ,0x00, 0x00, 0x7E});
        }

        public static void MP5_1()
        {
            frmMain.PS3.SetMemory(0x1C19866, new byte[]{0x16, 0x00, 0x0A, 0x00, 0x11, 0x00, 0x0D, 0x00, 0x39, 0x00, 0x00, 0x00, 0x35,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x65, 0x00, 0x09, 0x00, 0x4E, 0x00,
            0x4A, 0x00, 0x00, 0x00, 0x00, 0x5E, 0x6E, 0x00, 0x00, 0x00, 0x5E, 0x31, 0x42, 0x49, 0x53, 0x4F, 0x4F, 0x4E, 0x20, 0x20 ,0x20, 0x20 ,0x00});
        }

        public static byte[] SaveLocation(uint Client)
        {
           return frmMain.PS3.GetBytes(0x0110A29C + 0x3980 * Client, 12);
        }
        public static void LoadLocation(uint Client, byte[] Locations)
        {
            frmMain.PS3.SetMemory(0x0110A29C + 0x3980 * Client, Locations);
        }
        #region All Xp Total
        public static uint[] XP = new uint[] { 
800 , 1900, 3100, 4900, 7100, 9600, 12400, 15600,
19200,23100,27500,32400,37800,43700,50100,57000,
64400,72300,80700,89600,99000,108900,119300,130200,
141600,153500,165900,178800,192200,206200,220800,
236000,251800,268200,285200,302800,321000,339800,
359200,379200,399800,421000,442800,465200,488200,
511800,536000,560800,586200,612350,639250,666900,
695300,724450,754350,785000,816400,848550,881450,
915100,949500,984650,1020550,1057200,1094600,1132750,1171650,
1211300,1251700,1292850,1334500,1377150,1420300,1464450,
1509100,1554750,1600900,1648050,1695700,1746200
        };

        public static void SetXP(int Level)
        {
            byte[] bis = BitConverter.GetBytes((int)XP[Level - 2]);
            if (Level <= 80)
                frmMain.PS3.Extension.WriteBytes(0x01C1926C, bis);
            else
                Console.Write("Value is greater than 55");
        }
        #endregion

        public class MapInfo
        {
            static string GetMap()
            {
                return frmMain.PS3.Extension.ReadString(0x17D7ECD);
            }
            public static string MapName()
            {
                switch (GetMap())
                {
                    default: return "Unknown Map";
                case "mp_alpha": return "Lockdown";
                case "mp_bootleg": return "Bootleg";
                case "mp_bravo": return "Mission";
                case "mp_carbon": return "Carbon";
                case "mp_dome": return "Dome";
                case "mp_exchange": return "Downturn";
                case "mp_hardhat": return "Hardhat";
                case "mp_interchange": return "Interchange";
                case "mp_lambeth": return "Fallen";
                case "mp_mogadishu": return "Bakaara";
                case "mp_paris": return "Resistance";
                case "mp_plaza2": return "Arkaden";
                case "mp_radar": return "Outpost";
                case "mp_seatown": return "Seatown";
                case "mp_underground": return "Underground";
                case "mp_village": return "Village";
                case "mp_aground_ss": return "Aground";
                case "mp_cement": return "Foundation";
                case "mp_hillside_ss": return "Getaway";
                case "mp_italy": return "Piazza";
                case "mp_meteora": return "Sanctuary";
                case "mp_morningwood": return "Black Box";
                case "mp_overwatch": return "Overwatch";
                case "mp_park": return "Liberation";
                case "mp_qadeem": return "Oasis";
                case "mp_restrepo_ss": return "Lookout";
                case "mp_terminal_cls": return "Terminal";
                }
            }
            public static bool SetUp1 = (((((((MapName() == "Seatown") | (MapName() == "Arkaden")) |
                         (MapName() == "Downturn")) | (MapName() == "Bootleg")) | (MapName() == "Lockdown")) |
                         (MapName() == "Village")) | (MapName() == "Mission"));
        }

        public static class Primary
        {
            public static uint
                Weapon1 = 0x0110a4fd,
                Weapon2 = 0x0110a5f1,
                Weapon3 = 0x0110a6a5,
                AmmoClip = 0x0110a628,
                AmmoBullets = Primary.Weapon3 + 0x3,// = 0x0110a6a8,
                AkimboAmmo = 0x0110a6ac;
        }
        public static class Secondary
        {
            public static uint
                Weapon1 = 0x0110a4f5,
                Weapon2 = 0x0110a5f1,
                Weapon3 = 0x0110a68d,
                AmmoClip = 0x0110a618,
                AmmoBullets = Secondary.Weapon3 + 0x3,// = 0x0110a690
                AkimboAmmo = 0x0110a694;
        }
        public static uint Akimbo_Secondary = 0x0110a531;
        public static uint Akimbo_Primary = 0x0110a549;
        public static uint GrandeLuncherBullets = 0x0110a6b4;
        public static uint GrandeLuncherClip = 0x0110a630;
        public static void ChangeWeapon(int Client, byte Weapon)
        {
            byte[] IndexChangeWeapon = new byte[3];
            IndexChangeWeapon[2] = Weapon;
            frmMain.PS3.SetMemory((Akimbo_Primary + ((uint)Client * 0x3980)), new byte[] { 0x00 });
            frmMain.PS3.SetMemory(Primary.Weapon1 + (0x3980 * (uint)Client), IndexChangeWeapon);
            frmMain.PS3.SetMemory(Primary.Weapon2 + (0x3980 * (uint)Client), IndexChangeWeapon);
            frmMain.PS3.SetMemory(Primary.Weapon3 + (0x3980 * (uint)Client), IndexChangeWeapon);
            byte[] UltimateAmmo = new byte[] { 0x0F, 0xFF, 0xFF, 0xFF };
            frmMain.PS3.SetMemory(Primary.AkimboAmmo + (0x3980 * (uint)Client), UltimateAmmo);
            frmMain.PS3.SetMemory(Primary.AmmoBullets + (0x3980 * (uint)Client), UltimateAmmo);
            frmMain.PS3.SetMemory(Primary.AmmoClip + (0x3980 * (uint)Client), UltimateAmmo);
        }
    }
}
