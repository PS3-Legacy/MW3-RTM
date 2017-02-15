using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW3_Tool_By_BISOON
{
    class BIS
    {
        public static int[] WeaponIndex ={1,4,6,7,9,11,13,15,16,17,18,19,20,21,22,23,24,25,
         26,27,28,29,30,31,32,33,35,36,37,38,39,40,41,42,
         43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,
         60,63};
        public static int[] WeaponIndex1 ={1,4,6,7,9,11,13,15,16,17,18,19,20,21,22,23,24,25,
         26,27,28,29,30,31,32,33,35,36,37,38,39,40,41,42,
         43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,
         60,63};

        public static int[] ChangeWeaponIndex_SeatDown = { 0x04,0x05,0x06,0x08,0x0a,0x0b,0x0c,0x0d,0x0e,0x0f,0x10,
                                                           0x11,0x12,0x13,0x14,0x15,0x16,0x17,0x18,0x19,0x1a,0x1b,0x1c,0x1d,
                                                           0x1e,0x1f,0x20,0x21,0x22,0x23,0x24,0x25,0x26,0x27,0x28,0x29,0x2a,
                                                           0x2b,0x2c,0x2d,0x2e,0x2f,0x30,0x31,0x32,0x33,0x34,0x36,0x37,
                                                           0x38,0x39,0x3a,0x3b,0x3c,0x3d,0x3f,0x41,0x42,0x43,0x44,0x45,0x46,
                                                           0x47,0x48,0x49,0x4b,0x4e,0x60,0x61,0x67,0x68,0x69,0x70,0x72,0x7d};

        public static int[] ChangeWeaponIndex_Dome = { 0x04 + 1,0x05+ 1,0x06+ 1,0x08+ 1,0x0a+ 1,0x0b+ 1,0x0c+ 1,0x0d+ 1,0x0e+ 1,0x0f+ 1,0x10+ 1,
                                                                   0x11+ 1,0x12+ 1,0x13+ 1,0x14+ 1,0x15+ 1,0x16+ 1,0x17+ 1,0x18+ 1,0x19+ 1,0x1a+ 1,0x1b+ 1,0x1c+ 1,0x1d+ 1,
                                                                   0x1e+ 1,0x1f+ 1,0x20+ 1,0x21+ 1,0x22+ 1,0x23+ 1,0x24+ 1,0x25+ 1,0x26+ 1,0x27+ 1,0x28+ 1,0x29+ 1,0x2a+ 1,
                                                                   0x2b+ 1,0x2c+ 1,0x2d+ 1,0x2e+ 1,0x2f+ 1,0x30+ 1,0x31+ 1,0x32+ 1,0x33+ 1,0x34+ 1,0x36+ 1,0x37+ 1,
                                                                   0x38+ 1,0x39+ 1,0x3a+ 1,0x3b+ 1,0x3c+ 1,0x3d+ 1,0x3f+ 1,0x41+ 1,0x42+ 1,0x43+ 1,0x44+ 1,0x45+ 1,0x46+ 1,
                                                                   0x47+ 1,0x48+ 1,0x49+ 1,0x4b+ 1,0x4e+ 1,0x60+ 1,0x61+ 1,0x67+ 1,0x68+ 1,0x69+ 1,0x70+ 1,0x72+ 1,0x7d+ 1};

        public static string[] Model = {"", "vehicle_av8b_harrier_jet_mp","com_plasticcase_green_big_us_dirt", "prop_flag_neutral", "com_bomb_objective_d", "com_bomb_objective",
                                           "mil_tntbomb_mp",
                                           "com_plasticcase_beige_big", "com_laptop_2_open", "com_cellphone_on", "machinery_oxygen_tank02", "machinery_windmill",
                                           "com_ex_airconditioner", "com_barrel_benzin",
                                       "com_pipe_8x96_gas","com_pipe_4x64_metal","me_electricbox4","com_pipe_8x128_metal",
                                       "com_pipe_4x96_metal","com_pipe_4x128_gas","fence_tarp_130x56","fence_tarp_107x56","fence_tarp_151x56",
                                       "fence_tarp_134x56","fence_tarp_140x56","fence_tarp_167x56","fence_tarp_134x76",
                                       "vehicle_hummer_destructible","foliage_pacific_bushtree01_animated","foliage_desertbrush_3_animated",
                                       "foliage_pacific_flowers06_animated","oil_pump_jack01","oil_pump_jack02","accessories_windsock_large",
                                       "c130_zoomrig","vehicle_ac130_coop","tag_origin","","com_plasticcase_green_big_us_dirt","com_plasticcase_beige_big","com_laptop_2_open",
                                       "com_cellphone_on","com_bomb_objective_d","com_bomb_objective","seatown_canopy_stand_01","seatown_canopy_stand_02",
                                       "seatown_canopy_3section_01","me_electricbox4","com_ex_airconditioner","me_electricbox2",
                                       "seatown_lrg_wiregrp","chicken_black_white","me_fanceil1","seatown_canopy_1section_01",
                                       "seatown_canopy_1section_02","seatown_wire_flags1","com_trashcan_metal_closed",
                                       "seatown_wire_flags2","utility_transformer_ratnest01","seatown_mid01_wiregrp","chicken","hanging_sheet",
                                       "hanging_long_sleeve","hanging_apron","hanging_short_sleeve","vehicle_80s_hatch2_tan_destructible_mp",
                                       "vehicle_moving_truck_destructible","com_trashbin02","utility_transformer_small01","vehicle_80s_sedan1_green_destructible_mp",
                                       "mil_tntbomb_mp","prop_flag_neutral","c130_zoomrig","vehicle_ac130_coop","tag_origin","","com_plasticcase_green_big_us_dirt","com_bomb_objective",
                                       "com_bomb_objective_d","prop_flag_neutral","mil_tntbomb_mp","com_plasticcase_beige_big","com_laptop_2_open",
                                       "com_cellphone_on","com_security_camera_tilt_animated","uk_police_estate_destructible","vehicle_van_white_destructible","vehicle_london_cab_black_destructible",
                                       "vehicle_moving_truck_destructible","me_electricbox4","com_locker_double","me_electricbox2","com_locker_open","com_trashcan_metal_closed",
                                       "machinery_oxygen_tank01","machinery_oxygen_tank02","com_tv1","com_filecabinetblackclosed","prop_photocopier_destructible_02",
                                       "com_ex_airconditioner","me_electricbox4_dest","c130_zoomrig","vehicle_ac130_coop","tag_origin","","com_plasticcase_green_big_us_dirt",
                                       "prop_flag_neutral","com_bomb_objective_d","com_bomb_objective","mil_tntbomb_mp",
                                       "com_plasticcase_beige_big","com_laptop_2_open","com_cellphone_on","hanging_sheet","me_electricbox4",
                                       "vehicle_bm21_cover_destructible_dusty","com_trashcan_metal_closed","chicken_black_white",
                                       "vehicle_80s_wagon1_green_destructible_mp","vehicle_pickup_destructible_mp","c130_zoomrig","vehicle_ac130_coop",
                                       "tag_origin","","com_bomb_objective_d","com_bomb_objective",
                                       "com_plasticcase_green_big_us_dirt","prop_flag_neutral","com_plasticcase_beige_big","com_laptop_2_open",
                                       "com_cellphone_on","mil_tntbomb_mp","vehicle_uaz_winter_destructible","com_wall_fan_blade",
                                       "me_electricbox4","me_electricbox2","machinery_oxygen_tank01","com_locker_double","machinery_oxygen_tank02",
                                       "com_barrel_benzin","vehicle_bm21_mobile_bed_castle_destructible","com_filecabinetblackclosed",
                                       "machinery_generator","com_tv1","fence_tarp_126x76","com_wall_fan_blade_2x","rus_radar_dish_animated",
                                       "fence_tarp_124x52_a","com_propane_tank02_small","fence_tarp_124x52_b","me_rooftop_tank_01",
                                       "com_gas_pipes01","com_gas_pipes02","com_pipe_4_coupling_gas","com_pipe_4_90angle_gas","com_pipe_4x96_gas",
                                       "com_pipe_4_fit_gas","com_propane_tank02_valve",
                                       "com_pipe_coupling_metal","machinery_hose01","com_square_flag","com_steel_ladder",
                                       "c130_zoomrig","vehicle_ac130_coop","tag_origin","","com_plasticcase_green_big_us_dirt",
                                       "prop_flag_neutral","com_bomb_objective_d","com_bomb_objective","mil_tntbomb_mp","com_plasticcase_beige_big",
                                       "com_laptop_2_open","com_cellphone_on",
                                       "vehicle_subcompact_mica_destructible","vehicle_taxi_yellow_destructible_dusty","vehicle_bus_destructible_mp",
                                       "vehicle_taxi_yellow_destructible","com_ex_airconditioner","me_electricbox4",
                                       "vehicle_moving_truck_destructible","com_wall_fan_blade","vehicle_jeep_destructible",
                                       "vehicle_taxi_rooftop_ad_base","vehicle_taxi_rooftop_ad_3","vehicle_taxi_rooftop_ad_2","vehicle_taxi_rooftop_ad_1",
                                       "vehicle_taxi_rooftop_ad_4","c130_zoomrig","vehicle_ac130_coop","tag_origin",
                                       "","com_plasticcase_green_big_us_dirt","prop_flag_neutral","com_bomb_objective_d",
                                       "com_bomb_objective","mil_tntbomb_mp","com_plasticcase_beige_big","com_laptop_2_open",
                                       "com_cellphone_on","com_barrel_benzin","machinery_oxygen_tank02","machinery_oxygen_tank01",
                                       "machinery_generator","fence_tarp_208x42","hanging_dead_paratrooper01",
                                       "com_trashcan_metal_closed","concrete_sewer_pipe_large",
                                       "com_ex_airconditioner","fence_tarp_196x56","fence_tarp_192x84_a","fence_tarp_128x84",
                                       "fence_tarp_draping_224x116","fence_tarp_draping_98x94_01","fence_tarp_196x36","plastic_fence_528x88",
                                       "plastic_fence_232x88","plastic_fence_264x40","plastic_fence_234x88","plastic_fence_400x88","plastic_fence_300x88","plastic_fence_256x48","fence_tarp_192x50",
                                       "fx_wood_beam","payback_sstorm_debris_wood_5",
                                       "fence_tarp_196x146","fence_tarp_352x88","fence_tarp_draping_98x94_02",
                                       "vehicle_jeep_destructible","c130_zoomrig","vehicle_ac130_coop","tag_origin","","com_plasticcase_green_big_us_dirt",
                                       "prop_flag_neutral","com_bomb_objective_d","com_bomb_objective","mil_tntbomb_mp",
                                       "com_plasticcase_beige_big","com_laptop_2_open","com_cellphone_on","india_vehicle_rksw",
                                       "me_electricbox4","utility_transformer_ratnest01","com_ex_airconditioner","com_tv1",
                                       "me_lightfluohang_double_on","cs_wallfan1","vehicle_moving_truck_destructible",
                                       "chicken","vehicle_uaz_van_destructible","vehicle_80s_sedan1_red_destructible_mp",
                                       "c130_zoomrig","me_chainlink_fence_pole","me_corrugated_metal8x8","vehicle_ac130_coop","tag_origin"
                                       };

        public static string[] Vision = { "killhouse", "ac130_inverted", "ac130_thermal_mp",
                                            "aftermath", "airport_death", "airport_green",
                                            "armada", "berlin", "black_bw", "blackout_nvg", 
                                            "cargoship", "cargoship_blast",
                                        "cargoship_indoor2","cheat_bw","cheat_bw_contrast",
                                        "cheat_bw_invert","cheat_bw_invert_contrast","cheat_invert_contrast",
                                        "cheat_invert","cheat_chaplinnight","cheat_contrast",
                                        "cobra_sunset1","coup_sunblind","dcemp_emp","end_game","icbm","icbm_launch","sepia",
                                        "sniperescape","default"};

        public static int[] ClientIndex = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

        public static byte[] TeamByte ={ 0x01, 0x02, 0x07 };


        public static string[] Sounds = {"ui_mp_nukebomb_timer","mp_level_up","plr_new_rank","mp_card_slide",
                                         "mp_bonus_end","mp_bonus_start","mp_capture_flag","mp_challenge_complete","mp_defcon_down",
                                        "mp_ingame_summary","mp_enemy_obj_taken","mp_enemy_obj_captured",
                                        "mouse_over","mp_killstreak_ac130","mp_killstreak_airdrop","mp_killstreak_carepackage",
                                        "mp_killstreak_choppergunner","mp_killstreak_counteruav","mp_killstreak_emp",
                                        "mp_killstreak_harrier","mp_killstreak_heli","mp_killstreak_hellfire",
                                        "mp_killstreak_jet","mp_killstreak_nuclearstrike","mp_killstreak_pavelow",
                                        "mp_killstreak_radar","mp_killstreak_sentrygun","mp_killstreak_stealthbomber"
                                        };

        public static byte[] prestige = new byte[] {0x00, 0x01,0x02,0x03,0x04,0x05,0x06,0x07,0x08,0x09,0x0a, 0x0b, 0xc, 0x0d,
        0x0e,0x0f,0x10,0x11,0x12,0x13,0x14,0x15};


        public static string[] GameMods ={"g_gametype gun","g_gametype war","g_gametype ffa","g_gametype conf","g_gametype dom",
                                             "g_gametype sd","g_gametype koth","g_gametype sab","g_gametype infect",
                                         "g_gametype ctf","g_gametype tjugg","g_gametype jugg","g_gametype tdef"};
    }
}
