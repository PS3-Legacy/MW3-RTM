using PS3Lib;
using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;
namespace MW3_Tool_By_BISOON
{
	public static class RPC
	{
		public static class Offsets
		{
			public static class Addresses
			{
				public static uint PlayerCMD_ClonePlayer = 1576776u;
				public static uint G_Client = 17867392u;
				public static uint g_client = 17867392u;
				public static uint PlayerDie = 1587016u;
				public static uint G_ClientIndex = 14720u;
				public static uint EntityIndex = 640u;
				public static uint G_Entity = 16556672u;
				public static uint MapBrushModel = 32640u;
				public static uint BG_GetPerkIndexForName = 135344u;
				public static uint BG_GetNumWeapons = 249788u;
				public static uint BG_FindWeaponIndexForName = 249808u;
				public static uint BG_GetWeaponIndexForName = 250932u;
				public static uint BG_GetViewModelWeaponIndex = 251864u;
				public static uint Cmd_ExecuteSingleCommand = 1946176u;
				public static uint BG_WeaponFireRecoil = 261072u;
				public static uint CG_FireWeapon = 779416u;
				public static uint Key_IsDown = 859352u;
				public static uint Key_StringToKeynum = 859416u;
				public static uint Key_IsValidGamePadChar = 859748u;
				public static uint Key_KeyNumToString = 859812u;
				public static uint Key_Unbind_f = 861032u;
				public static uint Key_Bind_f = 861308u;
				public static uint BG_TakePlayerWeapon = 1851548u;
				public static uint G_GivePlayerWeapon = 1847348u;
				public static uint SV_GameSendServerCommand = 2265000u;
				public static uint SV_GetConfigString = 2270376u;
				public static uint SV_SetConfigString = 2269704u;
				public static uint va = 2725008u;
				public static uint G_SetModel = 1830748u;
				public static uint G_LocalizedStringIndex = 1828556u;
				public static uint G_MaterialIndex = 1828676u;
				public static uint G_ModelIndex = 1828776u;
				public static uint G_ModelName = 1829024u;
				public static uint Add_Ammo = 1614492u;
				public static uint PlayerCmd_SetPerk = 1567720u;
				public static uint G_Damage = 1588760u;
				public static uint G_RadiusDamage = 1594880u;
				public static uint G_GetClientScore = 1632884u;
				public static uint G_GetClientDeaths = 1632920u;
				public static uint Cmd_AddCommandInternal = 1950972u;
				public static uint CBuf_AddText = 1946176u;
				public static uint SV_SendDisconnect = 2246444u;
				public static uint SV_SendClientGameState = 2262264u;
				public static uint SV_KickClient = 2243536u;
				public static uint G_CallSpawnEntity = 1812272u;
				public static uint Player_Die = 1587016u;
				public static uint SV_DropClient = 2247164u;
				public static uint SV_SendServerCommand = 2281148u;
				public static uint Scr_Notify = 1814960u;
				public static uint Sv_SetGametype = 2268188u;
				public static uint Sv_Maprestart = 2242420u;
				public static uint sv_maprestart_f = 2243360u;
				public static uint sv_spawnsever = 2272760u;
				public static uint sv_map_f = 2241952u;
				public static uint sv_matchend = 2291624u;
				public static uint R_AddCmdDrawText = 3749440u;
				public static uint R_RegisterFont = 3672248u;
				public static uint R_AddCmdDrawStretchPic = 3747192u;
				public static uint CL_DrawTextHook = 889768u;
				public static uint R_AddCmdDrawTextWithEffects = 3749824u;
				public static uint CG_BoldGameMessage = 501192u;
				public static uint UI_FillRectPhysical = 2336784u;
				public static uint UI_DrawLoadBar = 2336560u;
				public static uint Scr_MakeGameMessage = 1771504u;
				public static uint Scr_ConstructMessageString = 1770740u;
				public static uint R_NormalizedTextScale = 3672304u;
				public static uint TeleportPlayer = 1645312u;
				public static uint Origin = 1645312u;
				public static uint CL_DrawText = 890000u;
				public static uint CL_DrawTextRotate = 890196u;
				public static uint SV_GameDropClient = 2265120u;
				public static uint Dvar_GetBool = 2691168u;
				public static uint Dvar_GetInt = 2691292u;
				public static uint Dvar_GetFloat = 2691400u;
				public static uint Dvar_RegisterBool = 2700272u;
				public static uint Dvar_IsValidName = 2687388u;
				public static uint Material_RegisterHandle = 3715140u;
				public static uint CL_RegisterFont = 890676u;
				public static uint SetClientViewAngle = 1533920u;
				public static uint R_RegisterDvars = 3662880u;
				public static uint PlayerCmd_SetClientDvar = 1559372u;
				public static uint Jump_RegisterDvars = 101920u;
				public static uint AimTarget_RegisterDvars = 73880u;
				public static uint G_FreeEntity = 1837120u;
				public static uint G_EntUnlink = 1854044u;
				public static uint SV_DObjGetTree = 2267752u;
				public static uint BG_GetEntityTypeName = 119280u;
				public static uint CL_GetClientState = 927400u;
				public static uint CL_GetConfigString = 810620u;
				public static uint Info_ValueForKey = 2725380u;
				public static uint Scr_GetInt = 2228676u;
				public static uint ClientSpawn = 1537128u;
				public static uint Sv_ClientCommand = 2261368u;
				public static uint Sv_ExecuteClientMessage = 2263888u;
				public static uint Sv_ExecuteClientCommand = 1584620u;
				public static uint ClientCommand = 1582144u;
				public static uint CalculateRanks = 1639196u;
				public static uint ClientScr_SetScore = 1532240u;
				public static uint ClientScr_SetMaxHealth = 1532052u;
				public static uint Sv_ReceiveStats = 2245856u;
				public static uint ClientConnect = 1536416u;
				public static uint Sv_DirectConnect = 2448308u;
				public static uint Sv_SetConfigstring = 2269704u;
				public static uint Sv_AddServerCommand = 2280352u;
				public static uint IntermissionClientEndFrame = 1525240u;
				public static uint memset = 4831528u;
				public static uint str_pointer = 5389104u;
				public static uint g_gametype = 8610005u;
			}
		}

		public static uint func_address = 2585096u;
		private static void WriteSingle(uint address, float input)
		{
			byte[] array = new byte[4];
			BitConverter.GetBytes(input).CopyTo(array, 0);
			Array.Reverse(array, 0, 4);
			frmMain.PS3.SetMemory(address, array);
		}
		public static byte[] ReverseBytes(byte[] inArray)
		{
			Array.Reverse(inArray);
			return inArray;
		}
		public static void WriteSingle(uint address, float[] input)
		{
			int num = input.Length;
			byte[] array = new byte[num * 4];
			for (int i = 0; i < num; i++)
			{
				RPC.ReverseBytes(BitConverter.GetBytes(input[i])).CopyTo(array, i * 4);
			}
			frmMain.PS3.SetMemory(address, array);
		}
		public static void GetMemoryR(uint Address, ref byte[] Bytes)
		{
			frmMain.PS3.GetMemory(Address, Bytes);
		}
		public static uint GetFuncReturn()
		{
			byte[] array = new byte[4];
			RPC.GetMemoryR(18132580u, ref array);
			Array.Reverse(array);
			return BitConverter.ToUInt32(array, 0);
		}
		public static void Enable()
		{
			byte[] buffer = new byte[]
			{
				63,
				128,
				16,
				5,
				129,
				156,
				0,
				72,
				44,
				12,
				0,
				0,
				65,
				130,
				0,
				120,
				128,
				124,
				0,
				0,
				128,
				156,
				0,
				4,
				128,
				188,
				0,
				8,
				128,
				220,
				0,
				12,
				128,
				252,
				0,
				16,
				129,
				28,
				0,
				20,
				129,
				60,
				0,
				24,
				129,
				92,
				0,
				28,
				129,
				124,
				0,
				32,
				192,
				60,
				0,
				36,
				192,
				92,
				0,
				40,
				192,
				124,
				0,
				44,
				192,
				156,
				0,
				48,
				192,
				188,
				0,
				52,
				192,
				220,
				0,
				56,
				192,
				252,
				0,
				60,
				193,
				28,
				0,
				64,
				193,
				60,
				0,
				68,
				125,
				137,
				3,
				166,
				78,
				128,
				4,
				33,
				56,
				128,
				0,
				0,
				144,
				156,
				0,
				72,
				144,
				124,
				0,
				76,
				208,
				60,
				0,
				80,
				72,
				0,
				0,
				20
			};
			frmMain.PS3.SetMemory(RPC.func_address, new byte[]
			{
				65
			});
			frmMain.PS3.SetMemory(RPC.func_address + 4u, buffer);
			frmMain.PS3.SetMemory(RPC.func_address, new byte[]
			{
				64
			});
			Thread.Sleep(10);
			RPC.DestroyAll();
		}
		public static int Call(uint address, params object[] parameters)
		{
			int num = parameters.Length;
			int i = 0;
			uint num2 = 0u;
			uint num3 = 0u;
			uint num4 = 0u;
			uint num5 = 0u;
			while (i < num)
			{
				if (parameters[i] is int)
				{
					frmMain.PS3.Extension.WriteInt32(268763136u + num2 * 4u, (int)parameters[i]);
					num2 += 1u;
				}
				else
				{
					if (parameters[i] is uint)
					{
						frmMain.PS3.Extension.WriteUInt32(268763136u + num2 * 4u, (uint)parameters[i]);
						num2 += 1u;
					}
					else
					{
						if (parameters[i] is short)
						{
							frmMain.PS3.Extension.WriteInt16(268763136u + num2 * 4u, (short)parameters[i]);
							num2 += 1u;
						}
						else
						{
							if (parameters[i] is ushort)
							{
								frmMain.PS3.Extension.WriteUInt16(268763136u + num2 * 4u, (ushort)parameters[i]);
								num2 += 1u;
							}
							else
							{
								if (parameters[i] is byte)
								{
									frmMain.PS3.Extension.WriteByte(268763136u + num2 * 4u, (byte)parameters[i]);
									num2 += 1u;
								}
								else
								{
									if (parameters[i] is string)
									{
										uint num6 = 268771328u + num3 * 1024u;
										frmMain.PS3.Extension.WriteString(num6, Convert.ToString(parameters[i]));
										frmMain.PS3.Extension.WriteUInt32(268763136u + num2 * 4u, num6);
										num2 += 1u;
										num3 += 1u;
									}
									else
									{
										if (parameters[i] is float)
										{
											RPC.WriteSingle(268763172u + num4 * 4u, (float)parameters[i]);
											num4 += 1u;
										}
										else
										{
											if (parameters[i] is float[])
											{
												float[] array = (float[])parameters[i];
												uint num6 = 268767232u + num5 * 4u;
												RPC.WriteSingle(num6, array);
												frmMain.PS3.Extension.WriteUInt32(268763136u + num2 * 4u, num6);
												num2 += 1u;
												num5 += (uint)array.Length;
											}
										}
									}
								}
							}
						}
					}
				}
				i++;
			}
			frmMain.PS3.Extension.WriteUInt32(268763208u, address);
			Thread.Sleep(20);
			return frmMain.PS3.Extension.ReadInt32(268763212u);
		}
		public static void DestroyAll()
		{
			byte[] buffer = new byte[184320];
			frmMain.PS3.SetMemory(15786252u, buffer);
		}
		private static byte[] ReadBytes(uint address, int length)
		{
			return RPC.GetMemory(address, length);
		}
		public static byte[] GetMemory(uint offset, int length)
		{
			byte[] array = new byte[length];
			frmMain.PS3.GetMemory(offset, array);
			return array;
		}
		public static float[] ReadSingle(uint address, int length)
		{
			byte[] array = RPC.ReadBytes(address, length * 4);
			Array.Reverse(array);
			float[] array2 = new float[length];
			for (int i = 0; i < length; i++)
			{
				array2[i] = BitConverter.ToSingle(array, (length - 1 - i) * 4);
			}
			return array2;
		}
		public static void SV_KickClient(int client, string text)
		{
			uint address = 2243536u;
			RPC.Call(address, new object[]
			{
				client,
				text
			});
		}
		public static void CBuf_AddText(int client, string command)
		{
			RPC.Call(RPC.Offsets.Addresses.CBuf_AddText, new object[]
			{
				(uint)client,
				command,
				0,
				0,
				0
			});
		}  
		public static void SV_GameSendServerCommand(int client, string command)
		{
			RPC.Call(RPC.Offsets.Addresses.SV_GameSendServerCommand, new object[]
			{
				(uint)client,
				0,
				command,
				0,
				0
			});
		}
		public static void iPrintln(int client, string Text)
		{
			string text = Text.Replace("[X]", "\u0001").Replace("[O]", "\u0002").Replace("[]", "\u0003").Replace("[Y]", "\u0004").Replace("[L1]", "\u0005").Replace("[R1]", "\u0006").Replace("[L3]", "\u0010").Replace("[R3]", "\u0011").Replace("[L2]", "\u0012").Replace("[R2]", "\u0013").Replace("[UP]", "\u0014").Replace("[DOWN]", "\u0015").Replace("[LEFT]", "\u0016").Replace("[RIGHT]", "\u0017").Replace("[START]", "\u000e").Replace("[SELECT]", "\u000f").Replace("[LINE]", "\n");
			RPC.SV_GameSendServerCommand(client, "c \"" + Text + "\"");
			Thread.Sleep(20);
		}
		public static void iPrintlnBold(int client, string Text)
		{
			string text = Text.Replace("[X]", "\u0001").Replace("[O]", "\u0002").Replace("[]", "\u0003").Replace("[Y]", "\u0004").Replace("[L1]", "\u0005").Replace("[R1]", "\u0006").Replace("[L3]", "\u0010").Replace("[R3]", "\u0011").Replace("[L2]", "\u0012").Replace("[R2]", "\u0013").Replace("[UP]", "\u0014").Replace("[DOWN]", "\u0015").Replace("[LEFT]", "\u0016").Replace("[RIGHT]", "\u0017").Replace("[START]", "\u000e").Replace("[SELECT]", "\u000f").Replace("[LINE]", "\n");
			RPC.SV_GameSendServerCommand(client, "f \"" + Text + "\"");
			Thread.Sleep(20);
		}
		public static void Set_ClientDvar(int client, string Text)
		{
			RPC.SV_GameSendServerCommand(client, "q " + Text);
			Thread.Sleep(20);
		}
		public static string Key_IsDown(uint ClientNum)
		{
			byte[] value = new byte[3];
			RPC.GetMemoryR(17880545u + 14720u * ClientNum, ref value);
			string text = BitConverter.ToString(value);
			string text2 = text.Replace("-", "");
			string text3 = text2.Replace(" ", "");
			string text4 = text3;
			string result;
			if (text4 == "000000")
			{
				result = "Stand";
			}
			else
			{
				if (text4 == "080C20")
				{
					result = "[ ] + X + L1";
				}
				else
				{
					if (text4 == "000224")
					{
						result = "Crouch + R3 + [ ]";
					}
					else
					{
						if (text4 == "008001")
						{
							result = "R1 + L2";
						}
						else
						{
							if (text4 == "082802")
							{
								result = "L1 + L3";
							}
							else
							{
								if (text4 == "002402")
								{
									result = "X + L3";
								}
								else
								{
									if (text4 == "000020")
									{
										result = "[  ]";
									}
									else
									{
										if (text4 == "000200")
										{
											result = "Crouch";
										}
										else
										{
											if (text4 == "004020")
											{
												result = "R2 + [ ]";
											}
											else
											{
												if (text4 == "000220")
												{
													result = "[ ] + Crouch";
												}
												else
												{
													if (text4 == "000100")
													{
														result = "Prone";
													}
													else
													{
														if (text4 == "400100")
														{
															result = "Left + Prone";
														}
														else
														{
															if (text4 == "000400")
															{
																result = "X";
															}
															else
															{
																if (text4 == "000004")
																{
																	result = "R3";
																}
																else
																{
																	if (text4 == "002002")
																	{
																		result = "L3";
																	}
																	else
																	{
																		if (text4 == "004000")
																		{
																			result = "R2";
																		}
																		else
																		{
																			if (text4 == "008000")
																			{
																				result = "L2";
																			}
																			else
																			{
																				if (text4 == "080800")
																				{
																					result = "L1";
																				}
																				else
																				{
																					if (text4 == "000001")
																					{
																						result = "R1";
																					}
																					else
																					{
																						if (text4 == "002006")
																						{
																							result = "R3 + L3";
																						}
																						else
																						{
																							if (text4 == "000204")
																							{
																								result = "R3";
																							}
																							else
																							{
																								if (text4 == "002202")
																								{
																									result = "L3";
																								}
																								else
																								{
																									if (text4 == "004200")
																									{
																										result = "R2";
																									}
																									else
																									{
																										if (text4 == "008004")
																										{
																											result = "R3 + L2";
																										}
																										else
																										{
																											if (text4 == "008200")
																											{
																												result = "L2";
																											}
																											else
																											{
																												if (text4 == "082902")
																												{
																													result = "Prone + L1 + L3";
																												}
																												else
																												{
																													if (text4 == "082906")
																													{
																														result = "Prone + L1 + L3 + R3";
																													}
																													else
																													{
																														if (text4 == "00C100")
																														{
																															result = "Prone + R2 + L2";
																														}
																														else
																														{
																															if (text4 == "00C000")
																															{
																																result = "R2 + L2";
																															}
																															else
																															{
																																if (text4 == "002206")
																																{
																																	result = "Crouch L3 + R3";
																																}
																																else
																																{
																																	if (text4 == "002222")
																																	{
																																		result = "Crouch L3 + [ ]";
																																	}
																																	else
																																	{
																																		if (text4 == "Up")
																																		{
																																			result = "R2 + L2";
																																		}
																																		else
																																		{
																																			if (text4 == "002122")
																																			{
																																				result = "Prone + L3 + [ ]";
																																			}
																																			else
																																			{
																																				if (text4 == "000420")
																																				{
																																					result = "X + [ ]";
																																				}
																																				else
																																				{
																																					if (text4 == "002106")
																																					{
																																						result = "Prone + R3 + L3";
																																					}
																																					else
																																					{
																																						result = text4;
																																					}
																																				}
																																			}
																																		}
																																	}
																																}
																															}
																														}
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return result;
		}
		public static string GetNames(int clientNum)
		{
			byte[] bytes = new byte[18];
			RPC.GetMemoryR((uint)(17880588 + clientNum * 14720), ref bytes);
			string @string = Encoding.ASCII.GetString(bytes);
			@string.Replace(Convert.ToChar(0).ToString(), string.Empty);
			return @string;
		}
		public static void Fov(int client, string Text)
		{
			RPC.SV_GameSendServerCommand(client, "q cg_fov " + Text);
			Thread.Sleep(20);
		}
		public static void Vision(int client, string Text)
		{
			RPC.SV_GameSendServerCommand(client, "J \"" + Text + "\"");
			Thread.Sleep(20);
		}
		public static void Kick(int client, string Text)
		{
			RPC.SV_GameSendServerCommand(client, "r \"" + Text + "\"");
			Thread.Sleep(20);
		}
		public static void GiveWeapon(int client, int weapon, int akimbo)
		{
			RPC.Call(RPC.Offsets.Addresses.G_GivePlayerWeapon, new object[]
			{
				RPC.G_ClientFunction(client),
				(uint)weapon,
				0
			});
			RPC.Call(RPC.Offsets.Addresses.Add_Ammo, new object[]
			{
				(uint)((ulong)RPC.Offsets.Addresses.G_Entity + (ulong)((long)(client * 640))),
				(uint)weapon,
				0,
				9999,
				1
			});
		}
		public static uint G_ClientFunction(int client)
		{
			return RPC.Offsets.Addresses.G_Client + (uint)(client * 14720);
		}
		public static void SetModel(int client, string model)
		{
			RPC.Call(RPC.Offsets.Addresses.G_SetModel, new object[]
			{
				(uint)((ulong)RPC.Offsets.Addresses.G_Entity + (ulong)((long)(client * 640))),
				model,
				0,
				0,
				0
			});
		}
		public static void Cmd_ExecuteSingleCommand(uint client, string command)
		{
			RPC.Call(RPC.Offsets.Addresses.Cmd_ExecuteSingleCommand, new object[]
			{
				client,
				command,
				0,
				0,
				0
			});
		}

        public static void PressStart(int Client)
        {
            RPC.SV_GameSendServerCommand(Client, "o");
        }
    
        public static void BlackScreen(int Client , bool tr)
        {
            if (tr)
            {
                RPC.Vision(Client, "black_bw");
            }
            else
            {
                RPC.Vision(Client, "default");
            }
        }

        public static void AntiQuit(int Client, bool A)
        {
            if (A)
            {
                RPC.SV_GameSendServerCommand(1 * Client, "q g_scriptmainmenu \"bykiwimodz\"");
               
            }
            else
            {
                RPC.SV_GameSendServerCommand(1 * Client, "q g_scriptmainmenu \"class\"");
            }
        }

        public static void  ClonePlayer(int client)
        {
            RPC.Call(0x180F48, new Object[] { client << 16 });
        }
        public static void G_AddEvent(uint G_Entity, int Event, int EventParam = 0)
        {
            RPC.Call(0x1C0C64, G_Entity, Event, EventParam);
        }
        public static void PronePlayer(uint Client)
        {
            G_AddEvent(0xFCA280 + (Client * 0x280), 8);
        }
        public static void SmallEarthQuake(uint Client)
        {
            G_AddEvent(0xFCA280 + (Client * 0x280), 67);
        }

        public static void LeaveGameOption(int Client)
        {
            RPC.SV_GameSendServerCommand(Client, "o 1");
        }
        public static void PlaySound(int client, String Sound)
        {//Thanks To \\OLDSCHOOLMODZHD//
            int SoundIndex = RPC.Call(0x001BEBDC, Sound);
            RPC.SV_GameSendServerCommand(client, "n " + SoundIndex);
        }
        public static void RestartGame()
        {
            RPC.Call(0x00223B20, 0, 0, "sv_maprestart_f"); 
        }

        public static void TimeLimit(int Time)
        {
            CBuf_AddText(0, "scr_war_timelimit " + Time);
            CBuf_AddText(0, "scr_ffa_timelimit " + Time);
            CBuf_AddText(0, "scr_conf_timelimit " + Time);
            CBuf_AddText(0, "scr_dom_timelimit " + Time);
            CBuf_AddText(0, "scr_dm_timelimit " + Time);
            CBuf_AddText(0, "scr_ctf_timelimit " + Time);
            CBuf_AddText(0, "scr_sd_timelimit " + Time);
            CBuf_AddText(0, "scr_koth_timelimit " + Time);
            CBuf_AddText(0, "scr_sab_timelimit " + Time);
            CBuf_AddText(0, "scr_infect_timelimit " + Time);
            CBuf_AddText(0, "scr_tjugg_timelimit " + Time);
            CBuf_AddText(0, "scr_jugg_timelimit " + Time);
            CBuf_AddText(0, "scr_tdef_timelimit " + Time);
            //CBuf_AddText(0, "scr_sas_timelimit " + Time);
            //CBuf_AddText(0, "scr_gun_timelimit " + Time);
            //CBuf_AddText(0, "scr_shrp_timelimit " + Time);
        }

        public static void ScoreLimit(int Limit)
        {
            CBuf_AddText(0, "scr_sd_scorelimit " + Limit);
            CBuf_AddText(0, "scr_war_scorelimit " + Limit);
            CBuf_AddText(0, "scr_dom_scorelimit " + Limit);
            CBuf_AddText(0, "scr_dm_scorelimit " + Limit);
            CBuf_AddText(0, "scr_ctf_scorelimit " + Limit);
            CBuf_AddText(0, "scr_koth_scorelimit " + Limit);
            CBuf_AddText(0, "scr_sab_scorelimit " + Limit);
            CBuf_AddText(0, "scr_infect_scorelimit " + Limit);
            CBuf_AddText(0, "scr_tjugg_scorelimit " + Limit);
            CBuf_AddText(0, "scr_jugg_scorelimit " + Limit);
            CBuf_AddText(0, "scr_tdef_scorelimit " + Limit);
            //CBuf_AddText(0, "scr_conf_scorelimit " + Limit);
            //CBuf_AddText(0, "scr_oic_scorelimit " + Limit);
            //CBuf_AddText(0, "scr_sas_scorelimit " + Limit);
            //CBuf_AddText(0, "scr_gun_scorelimit " + Limit);
            //CBuf_AddText(0, "scr_shrp_scorelimit " + Limit);
        }

        public static void LifeNum(int Life)
        {
            CBuf_AddText(0, "scr_sd_numlives " + Life);
        }
	}
}
