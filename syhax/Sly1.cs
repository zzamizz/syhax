using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using Memory;

namespace syhax
{
    public partial class syhax1 : Form
    {
        public syhax1()
        {
            InitializeComponent();
            timer1.Start();
        }
        public Mem m = new Mem();

        private void syhax1_Load(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        public static void DelegateThisShit(TextBox TextBox, float value) //niv
        {
            TextBox.Invoke((MethodInvoker)delegate
            {
                TextBox.Text = value.ToString("f5");
            });
        }
        public static void DelegateThisShit(Label Label, float value) //niv
        {
            Label.Invoke((MethodInvoker)delegate
            {
                Label.Text = value.ToString("f5");
            });
        }

        private void syhax1_FormClosed(object sender, FormClosedEventArgs e) //kill process from ruksi
        {
            Application.Exit();
        }

        public string gameCRC;

        public string targetEntity;

        public int langIndex;
        string langAddr = "";

        public string gameClock;
        string clockPAL = "";
        string clockNTSC = "";
        string clockNTSCJ = "";
        string clockNTSCK = "";

        public string toggleBattleMus;
        public string toggleSneakMus;
        string trBattleMusNTSC = "";
        string trSneakMusNTSC = "";
        string trBattleMusPAL = "";
        string trSneakMusPAL = "";
        string trBattleMusNTSCJ = "";
        string trSneakMusNTSCJ = "";
        string trBattleMusNTSCK = "";
        string trSneakMusNTSCK = "";

        public string unlockMoves;
        string trUnlockMovesPAL = "";
        string trUnlockMovesNTSC = "";
        string trUnlockMovesNTSCJ = "";
        string trUnlockMovesNTSCK = "";

        public string disableGuardAI;
        string trDisableGuardAIPAL = "";
        string trDisableGuardAINTSC = "";
        string trDisableGuardAINTSCJ = "";
        string trDisableGuardAINTSCK = "";

        public string slyHP;
        public string slyHPAmount;
        string trSlyHPPAL = "";
        string trSlyHPNTSC = "";
        string trSlyHPNTSCJ = "";
        string trSlyHPNTSCK = "";

        public string slyStructBase;
        string trSlyBasePAL = "";
        string trSlyBaseNTSC = "";
        string trSlyBaseNTSCJ = ""; //placeholder
        string trSlyBaseNTSCK = ""; //placeholder

        public static class TransformOffset
        {
            public const string scaleOffsetX = ",0x20000058,0x20000000";
            public const string scaleOffsetY = ",0x20000058,0x20000014";
            public const string scaleOffsetZ = ",0x20000058,0x20000028";

            public const string coordOffsetX = ",0x20000058,0x20000030";
            public const string coordOffsetY = ",0x20000058,0x20000034";
            public const string coordOffsetZ = ",0x20000058,0x20000038";
        }

        public static class EntityStruct
        {
            public const string entityTimer = ",0x20000084"; //Active Timer
            public const string entityInvis = ",0x2000012C"; //Invis Value
            public const string entityID = ",0x20000018"; //Entity ID
            public const string entityJump = ",0x200002E8"; //infinite jumps / jump bool
            public const string entityIgnore = ",0x200011AC"; //guards ignore flag
            public const string entityGod = ",0x20000298"; //invulnerability
            public const string entityAnim = ",0x200021F8"; //animation state
        }

        bool toggleActFreezeX;
        bool toggleActFreezeY;
        bool toggleActFreezeZ;
        bool toggleHPFreeze;

        bool toggleWeed;

        bool foundCRC = false;

        public int currentMapIndex;

        public int currentTab;

        public static class Sly1CRC
        {
            public const string Sly1PAL = "DA3DD765";
            public const string Sly1NTSC = "C77AF2CA";
            public const string Sly1NTSCJ = "15C88C7B";
            public const string Sly1NTSCK = "65969595"; //placeholder
        }

        public string reloadFunc;
        string trReloadFuncPAL = "";
        string trReloadFuncNTSC = "";
        string trReloadFuncNTSCJ = "";
        string trReloadFuncNTSCK = "";

        public string guardSize;
        string trGuardSizePAL = "";
        string trGuardSizeNTSC = "";
        string trGuardSizeNTSCJ = "";
        string trGuardSizeNTSCK = "";

        public string resetCam;
        string trResetCamPAL = "";
        string trResetCamNTSC = "";
        string trResetCamNTSCJ = "";
        string trResetCamNTSCK = "";

        public string reloadAOB;
        string trReloadAOBPAL = "";
        string trReloadAOBNTSC = "";
        string trReloadAOBNTSCJ = "";
        string trReloadAOBNTSCK = "";

        public string mapID;
        string trMapIDPAL = "";
        string trMapIDNTSC = "";
        string trMapIDNTSCJ = "";
        string trMapIDNTSCK = "";

        public static class LevelAOB
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                Starting starting = new Starting();
                starting.Close();

                int pID = m.GetProcIdFromName("pcsx2"); //get process ID
                bool openProc = false; //is process running?

                if (pID > 0)
                {
                    openProc = m.OpenProcess(pID);
                }
                else
                {
                    labelAttached.Invoke((MethodInvoker)delegate
                    {
                        labelAttached.Text = "NOT ATTACHED";
                        labelAttached.ForeColor = Color.Red;
                    });
                } //attach label

                if (openProc)
                {
                    gameCRC = m.ReadInt("pcsx2.exe+0x0106C780").ToString("X8");

                    labelAttached.Invoke((MethodInvoker)delegate
                    {
                        labelAttached.Text = "ATTACHED";
                        labelAttached.ForeColor = Color.Green;
                    }); //attach label

                    if (gameCRC.Length > 6)
                    {
                        foundCRC = true;
                    }

                    if (gameCRC == Sly1CRC.Sly1PAL)
                    {
                        currentGame.Invoke((MethodInvoker)delegate
                        {
                            currentGame.Text = "Sly Raccoon " + "[" + gameCRC + "]";
                            currentGame.ForeColor = Color.Green;

                            gameClock = clockPAL;

                            unlockMoves = trUnlockMovesPAL;

                            disableGuardAI = trDisableGuardAIPAL;

                            resetCam = trResetCamPAL;

                            slyStructBase = trSlyBasePAL;
                            slyHP = trSlyHPPAL;

                            reloadAOB = trReloadAOBPAL;
                            reloadFunc = trReloadFuncPAL;
                            mapID = trMapIDPAL;
                        });
                    }
                    if (gameCRC == Sly1CRC.Sly1NTSC)
                    {
                        currentGame.Invoke((MethodInvoker)delegate
                        {
                            currentGame.Text = "Sly Cooper and the Thievius Raccoonus " + "[" + gameCRC + "]";
                            currentGame.ForeColor = Color.Green;

                            gameClock = clockNTSC;

                            unlockMoves = trUnlockMovesNTSC;

                            disableGuardAI = trDisableGuardAINTSC;

                            resetCam = trResetCamNTSC;

                            slyStructBase = trSlyBaseNTSC;
                            slyHP = trSlyHPNTSC;

                            reloadAOB = trReloadAOBNTSC;
                            reloadFunc = trReloadFuncNTSC;
                            mapID = trMapIDNTSC;
                        });
                    }
                    if (gameCRC == Sly1CRC.Sly1NTSCJ)
                    {
                        currentGame.Invoke((MethodInvoker)delegate
                        {
                            currentGame.Text = "Kaitou Sly Cooper " + "[" + gameCRC + "]";
                            currentGame.ForeColor = Color.Green;

                            gameClock = clockNTSCJ;

                            unlockMoves = trUnlockMovesNTSCJ;

                            disableGuardAI = trDisableGuardAINTSCJ;

                            resetCam = trResetCamNTSCJ;

                            slyStructBase = trSlyBaseNTSCJ;
                            slyHP = trSlyHPNTSCJ;

                            reloadAOB = trReloadAOBNTSCJ;
                            reloadFunc = trReloadFuncNTSCJ;
                            mapID = trMapIDNTSCJ;
                        });
                    }
                    if (gameCRC == Sly1CRC.Sly1NTSCK)
                    {
                        currentGame.Invoke((MethodInvoker)delegate
                        {
                            currentGame.Text = "슬라이 쿠퍼: 전설의 비법서를 찾아서 " + "[" + gameCRC + "]";
                            currentGame.ForeColor = Color.Green;

                            gameClock = clockNTSCK;

                            unlockMoves = trUnlockMovesNTSCK;

                            disableGuardAI = trDisableGuardAINTSCK;

                            resetCam = trResetCamNTSCK;

                            slyStructBase = trSlyBaseNTSCK;
                            slyHP = trSlyHPNTSCK;

                            reloadAOB = trReloadAOBNTSCK;
                            reloadFunc = trReloadFuncNTSCK;
                            mapID = trMapIDNTSCK;
                        });
                    }

                    if (gameCRC != Sly1CRC.Sly1PAL && gameCRC != Sly1CRC.Sly1NTSC && gameCRC != Sly1CRC.Sly1NTSCJ && gameCRC != Sly1CRC.Sly1NTSCK)
                    {
                        Application.Restart();
                    }

                    if (foundCRC && gameCRC == "0")
                    {
                        Application.Restart();
                    }

                    currentMap.Invoke((MethodInvoker)delegate
                    {
                        currentMapIndex = m.ReadByte(mapID);
                    }); // level strings

                    if (gameCRC != Sly1CRC.Sly1PAL)
                    {
                        langSelector.Enabled = false;
                        reloadLang.Enabled = false;
                        currentLang.Invoke((MethodInvoker)delegate
                        {
                            currentLang.Text = "PAL only!";
                            currentLang.ForeColor = Color.Red;
                            currentLang.Font = new Font("Consolas", 14, FontStyle.Bold | FontStyle.Italic);
                        });
                    } // disable langselector for other regions
                    else if (gameCRC == Sly1CRC.Sly1PAL)
                    {
                        currentLang.Invoke((MethodInvoker)delegate
                        {
                            langIndex = m.ReadByte(langAddr);
                            if (langIndex == 0)
                            {
                                currentLang.Text = "English";
                            }
                        });
                    } // language strings
                    // Warps
                    warpComboBox.Invoke((MethodInvoker)delegate
                    {
                        if (currentMapIndex == 0) // map id
                        {
                            if (warpComboBox.Items.Count != 1) //stop from adding infinite items: count = location count
                            {
                                warpComboBox.Items.Add("place");
                            }
                        }
                    });

                    Thread.Sleep(10);
                }

                Thread.Sleep(10);
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //click syhax logo
        {
            MessageBox.Show("sus man!", "hello");
        }

        private void reloadLvl_Click(object sender, EventArgs e) // Reload Level + Levelselector
        {
            m.WriteMemory(reloadFunc, "int", "1"); //reload function

            if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "map name in collection")
            {
                //m.WriteMemory(reloadAOB, "bytes", mapName); //reload values
            }
        }

        private void warpButton_Click(object sender, EventArgs e)
        {
            m.WriteMemory(resetCam, "int", "1");
            m.WriteMemory(slyStructBase + EntityStruct.entityAnim, "int", "2"); //reset animation, probably not in sly 1
            // Cairo
            if (warpComboBox.GetItemText(warpComboBox.SelectedItem) == "warp name")
            {
                m.WriteMemory(slyStructBase + TransformOffset.coordOffsetX, "float", "4915");
                m.WriteMemory(slyStructBase + TransformOffset.coordOffsetY, "float", "-5211");
                m.WriteMemory(slyStructBase + TransformOffset.coordOffsetZ, "float", "750");
            }
        }

        private void reloadLang_Click(object sender, EventArgs e)
        {
            string English = "0x0";
            string French = "0x1";
            string Italian = "0x2";
            string German = "0x3";
            string Spanish = "0x4";
            string Dutch = "0x5";
            string Portuguese = "0x6";
            string Danish = "0x7";
            string Finnish = "0x8";
            string Norwegian = "0x9";
            string Swedish = "0xA";

            m.WriteMemory(reloadFunc, "int", "1");

            if (langSelector.GetItemText(langSelector.SelectedItem) == "English")
            {
                m.WriteMemory(langAddr, "byte", English);
            }
            else if (langSelector.GetItemText(langSelector.SelectedItem) == "Français")
            {
                m.WriteMemory(langAddr, "byte", French);
            }
            else if (langSelector.GetItemText(langSelector.SelectedItem) == "Deutsch")
            {
                m.WriteMemory(langAddr, "byte", German);
            }
            else if (langSelector.GetItemText(langSelector.SelectedItem) == "Español")
            {
                m.WriteMemory(langAddr, "byte", Spanish);
            }
            else if (langSelector.GetItemText(langSelector.SelectedItem) == "Italiano")
            {
                m.WriteMemory(langAddr, "byte", Italian);
            }
            else if (langSelector.GetItemText(langSelector.SelectedItem) == "Nederlands")
            {
                m.WriteMemory(langAddr, "byte", Dutch);
            }
            else if (langSelector.GetItemText(langSelector.SelectedItem) == "Português")
            {
                m.WriteMemory(langAddr, "byte", Portuguese);
            }
            else if (langSelector.GetItemText(langSelector.SelectedItem) == "Dansk")
            {
                m.WriteMemory(langAddr, "byte", Danish);
            }
            else if (langSelector.GetItemText(langSelector.SelectedItem) == "Suomalainen")
            {
                m.WriteMemory(langAddr, "byte", Finnish);
            }
            else if (langSelector.GetItemText(langSelector.SelectedItem) == "Norsk")
            {
                m.WriteMemory(langAddr, "byte", Norwegian);
            }
            else if (langSelector.GetItemText(langSelector.SelectedItem) == "Svensk")
            {
                m.WriteMemory(langAddr, "byte", Swedish);
            }
        } //language

        void ChangeActiveCoords(string xyz, float amount, string entitystruct, string offset)
        {
            if (xyz == "x")
            {
                m.WriteMemory(entitystruct + offset, "float", amount.ToString());
                if (toggleActFreezeX)
                {
                    m.FreezeValue(entitystruct + offset, "float", amount.ToString());
                }
            }
            if (xyz == "y")
            {
                m.WriteMemory(entitystruct + offset, "float", amount.ToString());
                if (toggleActFreezeY)
                {
                    m.FreezeValue(entitystruct + offset, "float", amount.ToString());
                }
            }
            if (xyz == "z")
            {
                m.WriteMemory(entitystruct + offset, "float", amount.ToString());
                if (toggleActFreezeZ)
                {
                    m.FreezeValue(entitystruct + offset, "float", amount.ToString());
                }
            }
        }

        private void setActX_Click(object sender, EventArgs e)
        {

        }
        private void setActY_Click(object sender, EventArgs e)
        {

        }
        private void setActZ_Click(object sender, EventArgs e)
        {

        }

        private void actEntIncreaseX_Click(object sender, EventArgs e)
        {
            float targetValue = float.Parse(actEntX.Text) + xyzTrackBar.Value; //increment
            ChangeActiveCoords("x", targetValue, slyStructBase, TransformOffset.coordOffsetX);
        }//active increase X
        private void actEntDecreaseX_Click(object sender, EventArgs e)
        {
            float targetValue = float.Parse(actEntX.Text) + xyzTrackBar.Value * -1; //decrement
            ChangeActiveCoords("x", targetValue, slyStructBase, TransformOffset.coordOffsetX);
        }//active decrease X
        private void actEntIncreaseY_Click(object sender, EventArgs e)
        {
            float targetValue = float.Parse(actEntY.Text) + xyzTrackBar.Value; //decrement
            ChangeActiveCoords("y", targetValue, slyStructBase, TransformOffset.coordOffsetY);
        }//active increase Y
        private void actEntDecreaseY_Click(object sender, EventArgs e)
        {
            float targetValue = float.Parse(actEntY.Text) + xyzTrackBar.Value * -1; //decrement
            ChangeActiveCoords("y", targetValue, slyStructBase, TransformOffset.coordOffsetY);
        }//active decrease Y
        private void actEntIncreaseZ_Click(object sender, EventArgs e)
        {
            float targetValue = float.Parse(actEntZ.Text) + xyzTrackBar.Value; //increment
            ChangeActiveCoords("z", targetValue, slyStructBase, TransformOffset.coordOffsetZ);
        }//active increase Z
        private void actEntDecreaseZ_Click(object sender, EventArgs e)
        {
            float targetValue = float.Parse(actEntZ.Text) + xyzTrackBar.Value * -1; //decrement
            ChangeActiveCoords("z", targetValue, slyStructBase, TransformOffset.coordOffsetZ);
        }//active decrease Z

        private void actEntFreezeX_Click(object sender, EventArgs e) //active freeze X
        {
            toggleActFreezeX = !toggleActFreezeX;
            if (toggleActFreezeX)
            {
                actEntX.ForeColor = Color.Red;

                m.FreezeValue(slyStructBase + TransformOffset.coordOffsetX, "float", actEntX.Text);
            }
            else
            {
                actEntX.ForeColor = Color.White;

                m.UnfreezeValue(slyStructBase + TransformOffset.coordOffsetX);
            }
        }
        private void actEntFreezeY_Click(object sender, EventArgs e) //active freeze Y
        {
            toggleActFreezeY = !toggleActFreezeY;
            if (toggleActFreezeY)
            {
                actEntY.ForeColor = Color.Red;

                m.FreezeValue(slyStructBase + TransformOffset.coordOffsetY, "float", actEntY.Text);
            }
            else
            {
                actEntY.ForeColor = Color.Red;

                m.UnfreezeValue(slyStructBase + TransformOffset.coordOffsetY);
            }
        }
        private void actEntFreezeZ_Click(object sender, EventArgs e) //active freeze Z
        {
            toggleActFreezeZ = !toggleActFreezeZ;
            if (toggleActFreezeZ)
            {
                actEntZ.ForeColor = Color.Red;

                m.FreezeValue(slyStructBase + TransformOffset.coordOffsetZ, "float", actEntZ.Text);
            }
            else
            {
                actEntZ.ForeColor = Color.Red;

                m.UnfreezeValue(slyStructBase + TransformOffset.coordOffsetZ);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentTab = tabControl1.SelectedIndex;

            if (currentTab == 0)
            {
                while (true)
                {
                    slyHPAmount = m.ReadInt(slyHP).ToString();

                    float actConvertX = m.ReadFloat(slyStructBase + TransformOffset.coordOffsetX, round: false);
                    DelegateThisShit(actEntX, actConvertX);

                    float actConvertY = m.ReadFloat(slyStructBase + TransformOffset.coordOffsetY, round: false);
                    DelegateThisShit(actEntY, actConvertY);

                    float actConvertZ = m.ReadFloat(slyStructBase + TransformOffset.coordOffsetZ, round: false);
                    DelegateThisShit(actEntZ, actConvertZ);
                }
            } //Active character tab
        }

        private void checkBoxInfJumps_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxInfJumps.Checked)
            {
                m.FreezeValue(slyStructBase + EntityStruct.entityJump, "byte", "1");
            }
            else if (!checkBoxInfJumps.Checked)
            {
                m.UnfreezeValue(slyStructBase + EntityStruct.entityJump);
                m.WriteMemory(slyStructBase + EntityStruct.entityJump, "int", "0");
            }
        } //Infinite Jumps

        private void weedButton_Click(object sender, EventArgs e)
        {
            toggleWeed = !toggleWeed;
            if (toggleWeed)
            {
                m.WriteMemory(toggleBattleMus, "byte", "1");
            }
            else
            {
                m.WriteMemory(toggleBattleMus, "byte", "0");
            }
        } //weedbutton

        private void buttonMoves_Click(object sender, EventArgs e)
        {
            m.WriteMemory(unlockMoves, "bytes", "FF FF FF FF");
        } //unlock gadgets

        private void clueScriptButton_Click(object sender, EventArgs e)
        {

        } //button that makes sly go around all trtles very fast wow

        private void trackBarGameClock_ValueChanged(object sender, EventArgs e)
        {
            m.WriteMemory(gameClock, "float", (trackBarGameClock.Value / 100f).ToString("f1"));
        } //game clock

        private void godMode_CheckedChanged(object sender, EventArgs e)
        {
            if (godMode.Checked)
            {
                m.WriteMemory(slyStructBase + EntityStruct.entityGod, "int", "1");
            }
            else
            {
                m.WriteMemory(slyStructBase + EntityStruct.entityGod, "int", "0");
            }
        }

        private void guardIgnore_CheckedChanged(object sender, EventArgs e)
        {
            if (guardIgnore.Checked)
            {
                m.WriteMemory(slyStructBase + EntityStruct.entityIgnore, "int", "1");
            }
            else
            {
                m.WriteMemory(slyStructBase + EntityStruct.entityIgnore, "int", "0");
            }
        } //guards ignore

        private void checkGuardAI_CheckedChanged(object sender, EventArgs e)
        {
            if (checkGuardAI.Checked)
            {
                m.WriteMemory(disableGuardAI, "byte", "1");
            }
            else
            {
                m.WriteMemory(disableGuardAI, "byte", "0");
            }
        } //disable guard ai
    }
}
