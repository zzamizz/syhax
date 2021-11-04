using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Memory;

namespace syhax
{
    public partial class syhax3 : Form
    {
        public syhax3()
        {
            InitializeComponent();
            timer1.Start();
        }
        public Mem m = new Mem();

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

        private void syhax3_FormClosed(object sender, FormClosedEventArgs e) //kill process from ruksi
        {
            Application.Exit();
        }

        public string gameCRC;

        public string targetEntity;

        public string charIDAddr;
        string hatCharIDPAL = "203DC26C";
        string hatCharIDNTSC = "203D4A6C";
        string hatCharIDNTSCJ = "20000000"; //placeholder
        string hatCharIDNTSCK = "20000000"; //placeholder

        public string actStructBase;
        string hatActBasePAL = "202E55A0";
        string hatActBaseNTSC = "202DE2F0";
        string hatActBaseNTSCJ = "20000000"; //placeholder
        string hatActBaseNTSCK = "20000000"; //placeholder

        public string slyStructBase;
        string hatSlyBasePAL = "20000000"; //placeholder
        string hatSlyBaseNTSC = "202E1E40";
        string hatSlyBaseNTSCJ = "20000000"; //placeholder
        string hatSlyBaseNTSCK = "20000000"; //placeholder

        public string bentleyStructBase;
        string hatBentleyBasePAL = "20000000"; //placeholder
        string hatBentleyBaseNTSC = "20000000"; //placeholder
        string hatBentleyBaseNTSCJ = "20000000"; //placeholder
        string hatBentleyBaseNTSCK = "20000000"; //placeholder

        public string murrayStructBase;
        string hatMurrayBasePAL = "20000000"; //placeholder
        string hatMurrayBaseNTSC = "20000000"; //placeholder
        string hatMurrayBaseNTSCJ = "20000000"; //placeholder
        string hatMurrayBaseNTSCK = "20000000"; //placeholder

        public string reloadAddr;

        public static class ReloadAddress
        {
            public const string reloadPAL = "2047AE44";
            public const string reloadNTSC = "204797C4";
        }

        public string currentSelectedStruct;

        public string activeStruct;

        public static class TransformOffset
        {
            public const string scaleOffsetX = ",0x20000058,0x20000000";
            public const string scaleOffsetY = ",0x20000058,0x20000004";
            public const string scaleOffsetZ = ",0x20000058,0x20000008";

            public const string coordOffsetX = ",0x20000058,0x20000030";
            public const string coordOffsetY = ",0x20000058,0x20000034";
            public const string coordOffsetZ = ",0x20000058,0x20000038";
        }

        bool toggleEntFreezeX;
        bool toggleEntFreezeY;
        bool toggleEntFreezeZ;
        bool toggleActFreezeX;
        bool toggleActFreezeY;
        bool toggleActFreezeZ;

        bool foundCRC = false;

        public int actCharIndex;

        public int currentTab;

        public string oldCRC;
        bool oldCheck = true;

        public static class Sly3CRC
        {
            public const string Sly3PAL = "8164C614";
            public const string Sly3NTSC = "8BC95883";
            public const string Sly3NTSCJ = "20000000"; //placeholder
            public const string Sly3NTSCK = "20000000"; //placeholder
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
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

                    if (gameCRC != null && oldCheck && gameCRC.Length > 6)
                    {
                        oldCRC = gameCRC;
                        oldCheck = false;
                    }

                    labelAttached.Invoke((MethodInvoker)delegate
                    {
                        labelAttached.Text = "ATTACHED";
                        labelAttached.ForeColor = Color.Green;
                    }); //attach label

                    debugCRC.Invoke((MethodInvoker)delegate
                    {
                        debugCRC.Text = gameCRC;
                        debugOldCRC.Text = oldCRC;
                    }); //debug labels

                    if (gameCRC.Length > 6)
                    {
                        foundCRC = true;
                    }

                    if (gameCRC == Sly3CRC.Sly3PAL)
                    {
                        currentGame.Invoke((MethodInvoker)delegate
                        {
                            currentGame.Text = "Sly 3: Honor Among Thieves (PAL)";
                            currentGame.ForeColor = Color.Green;

                            charIDAddr = hatCharIDPAL;
                            actStructBase = hatActBasePAL;
                            slyStructBase = hatSlyBasePAL;
                            bentleyStructBase = hatBentleyBasePAL;
                            murrayStructBase = hatMurrayBasePAL;
                            reloadAddr = ReloadAddress.reloadPAL;
                        });
                    }
                    if (gameCRC == Sly3CRC.Sly3NTSC)
                    {
                        currentGame.Invoke((MethodInvoker)delegate
                        {
                            currentGame.Text = "Sly 3: Honor Among Thieves (NTSC-U)";
                            currentGame.ForeColor = Color.Green;

                            charIDAddr = hatCharIDNTSC;
                            actStructBase = hatActBaseNTSC;
                            slyStructBase = hatSlyBaseNTSC;
                            bentleyStructBase = hatBentleyBaseNTSC;
                            murrayStructBase = hatMurrayBaseNTSC;
                            reloadAddr = ReloadAddress.reloadNTSC;
                        });
                    }
                    if (gameCRC == Sly3CRC.Sly3NTSCJ)
                    {
                        currentGame.Invoke((MethodInvoker)delegate
                        {
                            currentGame.Text = "Sly 3: Honor Among Thieves (NTSC-J)";
                            currentGame.ForeColor = Color.Green;

                            charIDAddr = hatCharIDNTSCJ;
                            actStructBase = hatActBaseNTSCJ;
                            slyStructBase = hatSlyBaseNTSCJ;
                            bentleyStructBase = hatBentleyBaseNTSCJ;
                            murrayStructBase = hatMurrayBaseNTSCJ;
                        });
                    }
                    if (gameCRC == Sly3CRC.Sly3NTSCK)
                    {
                        currentGame.Invoke((MethodInvoker)delegate
                        {
                            currentGame.Text = "Sly 3: Honor Among Thieves (NTSC-K)";
                            currentGame.ForeColor = Color.Green;

                            charIDAddr = hatCharIDNTSCK;
                            actStructBase = hatActBaseNTSCK;
                            slyStructBase = hatSlyBaseNTSCK;
                            bentleyStructBase = hatBentleyBaseNTSCK;
                            murrayStructBase = hatMurrayBaseNTSCK;
                        });
                    }

                    if (gameCRC != Sly3CRC.Sly3PAL && gameCRC != Sly3CRC.Sly3NTSC && gameCRC != Sly3CRC.Sly3NTSCJ && gameCRC != Sly3CRC.Sly3NTSCK)
                    {
                        Application.Restart();
                    }

                    if (oldCRC != null && oldCRC != gameCRC && gameCRC.Length > 6 && oldCRC.Length > 6)
                    {
                        Application.Restart();
                    }

                    if (foundCRC && gameCRC == "0")
                    {
                        Application.Restart();
                    }

                    actChar.Invoke((MethodInvoker)delegate
                    {
                        actCharIndex = m.ReadByte(charIDAddr);
                        if (actCharIndex == 24)
                        {
                            actChar.Text = "Sly";
                            activeStruct = slyStructBase;
                        }
                        else if (actCharIndex == 25)
                        {
                            actChar.Text = "Bentley";
                            activeStruct = bentleyStructBase;
                        }
                        else if (actCharIndex == 26)
                        {
                            actChar.Text = "Murray";
                            activeStruct = murrayStructBase;
                        }
                        else if (actCharIndex == 29)
                        {
                            actChar.Text = "Guru";
                            activeStruct = murrayStructBase;
                        }
                        else if (actCharIndex == 30)
                        {
                            actChar.Text = "Panda King";
                            activeStruct = murrayStructBase;
                        }
                        else if (actCharIndex == 31)
                        {
                            actChar.Text = "Penelope";
                            activeStruct = murrayStructBase;
                        }
                        else if (actCharIndex == 15063)
                        {
                            actChar.Text = "RC Car";
                            activeStruct = murrayStructBase;
                        }
                        else if (actCharIndex == 16018)
                        {
                            actChar.Text = "Biplane";
                            activeStruct = murrayStructBase;
                        }
                    });

                    if (currentTab == 0)
                    {
                        float actConvertX = m.ReadFloat(actStructBase + TransformOffset.coordOffsetX, round: false);
                        DelegateThisShit(actEntX, actConvertX);

                        float actConvertY = m.ReadFloat(actStructBase + TransformOffset.coordOffsetY, round: false);
                        DelegateThisShit(actEntY, actConvertY);

                        float actConvertZ = m.ReadFloat(actStructBase + TransformOffset.coordOffsetZ, round: false);
                        DelegateThisShit(actEntZ, actConvertZ);

                    } //Active character tab

                    if (targetEntity == "Sly")
                    {
                        float convertX = m.ReadFloat(slyStructBase + TransformOffset.coordOffsetX, round: false);
                        DelegateThisShit(entX, convertX);

                        float convertY = m.ReadFloat(slyStructBase + TransformOffset.coordOffsetY, round: false);
                        DelegateThisShit(entY, convertY);

                        float convertZ = m.ReadFloat(slyStructBase + TransformOffset.coordOffsetZ, round: false);
                        DelegateThisShit(entZ, convertZ);
                    } // Sly Location
                    if (targetEntity == "Bentley")
                    {
                        float convertX = m.ReadFloat(bentleyStructBase + TransformOffset.coordOffsetX, round: false);
                        DelegateThisShit(entX, convertX);

                        float convertY = m.ReadFloat(bentleyStructBase + TransformOffset.coordOffsetY, round: false);
                        DelegateThisShit(entY, convertY);

                        float convertZ = m.ReadFloat(bentleyStructBase + TransformOffset.coordOffsetZ, round: false);
                        DelegateThisShit(entZ, convertZ);
                    } // Bentley Location
                    if (targetEntity == "Murray")
                    {
                        float convertX = m.ReadFloat(murrayStructBase + TransformOffset.coordOffsetX, round: false);
                        DelegateThisShit(entX, convertX);

                        float convertY = m.ReadFloat(murrayStructBase + TransformOffset.coordOffsetY, round: false);
                        DelegateThisShit(entY, convertY);

                        float convertZ = m.ReadFloat(murrayStructBase + TransformOffset.coordOffsetZ, round: false);
                        DelegateThisShit(entZ, convertZ);
                    } // Murray Location
                }
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //click syhax logo
        {
            MessageBox.Show("sus man!", "hello");
        }

        private void reloadLvl_Click(object sender, EventArgs e) // Reload Level
        {
            m.WriteMemory(reloadAddr, "int", "1");
        }

        void ChangeEntityCoords(string xyz, float amount, string entitystruct, string offset)
        {
            if (xyz == "x")
            {
                m.WriteMemory(entitystruct + offset, "float", amount.ToString());

            }
            if (xyz == "y")
            {
                m.WriteMemory(entitystruct + offset, "float", amount.ToString());

            }
            if (xyz == "z")
            {
                m.WriteMemory(entitystruct + offset, "float", amount.ToString());

            }
        }

        void ChangeActiveCoords(string xyz, float amount, string entitystruct, string offset)
        {
            if (xyz == "x")
            {
                m.WriteMemory(entitystruct + offset, "float", amount.ToString());

            }
            if (xyz == "y")
            {
                m.WriteMemory(entitystruct + offset, "float", amount.ToString());

            }
            if (xyz == "z")
            {
                m.WriteMemory(entitystruct + offset, "float", amount.ToString());

            }
        }

        private void entitySelector_SelectedIndexChanged(object sender, EventArgs e) //Entity selector
        {
            if (entitySelector.SelectedIndex == 0)
            {
                targetEntity = "Sly";
                currentSelectedStruct = slyStructBase;
            }
            else if (entitySelector.SelectedIndex == 1)
            {
                targetEntity = "Bentley";
                currentSelectedStruct = bentleyStructBase;
            }
            else if (entitySelector.SelectedIndex == 2)
            {
                targetEntity = "Murray";
                currentSelectedStruct = murrayStructBase;
            }
            entScale.Invoke((MethodInvoker)delegate
            {
                entScale.Text = m.ReadFloat(currentSelectedStruct + TransformOffset.scaleOffsetX, round: false).ToString("f1"); //update entscale text
            });
            entScaleTrackbar.Value = int.Parse((m.ReadFloat(currentSelectedStruct + TransformOffset.scaleOffsetX, round: true) * 100).ToString()); //update entscale trackbar
        }

        private void entIncreaseX_Click(object sender, EventArgs e) //entity tab increase X
        {
            float targetValue = float.Parse(entX.Text) + entIncSlider.Value; //increment
            ChangeEntityCoords("x", targetValue, currentSelectedStruct, TransformOffset.coordOffsetX);
        }
        private void entDecreaseX_Click(object sender, EventArgs e) //entity tab decrease X
        {
            float targetValue = float.Parse(entX.Text) + entIncSlider.Value * -1; //decrement
            ChangeEntityCoords("x", targetValue, currentSelectedStruct, TransformOffset.coordOffsetX);
        }
        private void entIncreaseY_Click(object sender, EventArgs e) //entity tab increase Y
        {
            float targetValue = float.Parse(entY.Text) + entIncSlider.Value; //increment
            ChangeEntityCoords("y", targetValue, currentSelectedStruct, TransformOffset.coordOffsetY);
        }
        private void entDecreaseY_Click(object sender, EventArgs e) //entity tab decrease Y
        {
            float targetValue = float.Parse(entY.Text) + entIncSlider.Value * -1; //decrement
            ChangeEntityCoords("y", targetValue, currentSelectedStruct, TransformOffset.coordOffsetY);
        }
        private void entIncreaseZ_Click(object sender, EventArgs e) //entity tab increase Z
        {
            float targetValue = float.Parse(entZ.Text) + entIncSlider.Value; //increment
            ChangeEntityCoords("z", targetValue, currentSelectedStruct, TransformOffset.coordOffsetZ);
        }
        private void entDecreaseZ_Click(object sender, EventArgs e) //entity tab decrease Z
        {
            float targetValue = float.Parse(entZ.Text) + entIncSlider.Value * -1; //decrement
            ChangeEntityCoords("z", targetValue, currentSelectedStruct, TransformOffset.coordOffsetZ);
        }
        private void actEntIncreaseX_Click(object sender, EventArgs e)
        {
            float targetValue = float.Parse(actEntX.Text) + xyzTrackBar.Value; //increment
            ChangeActiveCoords("x", targetValue, activeStruct, TransformOffset.coordOffsetX);
        }//active increase X
        private void actEntDecreaseX_Click(object sender, EventArgs e)
        {
            float targetValue = float.Parse(actEntX.Text) + xyzTrackBar.Value * -1; //decrement
            ChangeActiveCoords("x", targetValue, activeStruct, TransformOffset.coordOffsetX);
        }//active decrease X
        private void actEntIncreaseY_Click(object sender, EventArgs e)
        {
            float targetValue = float.Parse(actEntY.Text) + xyzTrackBar.Value; //decrement
            ChangeActiveCoords("y", targetValue, activeStruct, TransformOffset.coordOffsetY);
        }//active increase Y
        private void actEntDecreaseY_Click(object sender, EventArgs e)
        {
            float targetValue = float.Parse(actEntY.Text) + xyzTrackBar.Value * -1; //decrement
            ChangeActiveCoords("y", targetValue, activeStruct, TransformOffset.coordOffsetY);
        }//active decrease Y
        private void actEntIncreaseZ_Click(object sender, EventArgs e)
        {
            float targetValue = float.Parse(actEntZ.Text) + xyzTrackBar.Value; //decrement
            ChangeActiveCoords("z", targetValue, activeStruct, TransformOffset.coordOffsetZ);
        }//active increase Z
        private void actEntDecreaseZ_Click(object sender, EventArgs e)
        {
            float targetValue = float.Parse(actEntZ.Text) + xyzTrackBar.Value * -1; //decrement
            ChangeActiveCoords("z", targetValue, activeStruct, TransformOffset.coordOffsetZ);
        }//active decrease Z

        private void entFreezeX_Click(object sender, EventArgs e) //entity freeze X
        {
            toggleEntFreezeX = !toggleEntFreezeX;
            if (toggleEntFreezeX)
            {
                if (targetEntity == "Sly")
                {
                    m.FreezeValue(slyStructBase + TransformOffset.coordOffsetX, "float", entX.Text);
                }
                if (targetEntity == "Bentley")
                {
                    m.FreezeValue(bentleyStructBase + TransformOffset.coordOffsetX, "float", entX.Text);
                }
                if (targetEntity == "Murray")
                {
                    m.FreezeValue(murrayStructBase + TransformOffset.coordOffsetX, "float", entX.Text);
                }
            }
            else
            {
                if (targetEntity == "Sly")
                {
                    m.UnfreezeValue(slyStructBase + TransformOffset.coordOffsetX);
                }
                if (targetEntity == "Bentley")
                {
                    m.UnfreezeValue(bentleyStructBase + TransformOffset.coordOffsetX);
                }
                if (targetEntity == "Murray")
                {
                    m.UnfreezeValue(murrayStructBase + TransformOffset.coordOffsetX);
                }
            }
        }
        private void entFreezeY_Click(object sender, EventArgs e) //entity freeze Y
        {
            toggleEntFreezeY = !toggleEntFreezeY;
            if (toggleEntFreezeY)
            {
                if (targetEntity == "Sly")
                {
                    m.FreezeValue(slyStructBase + TransformOffset.coordOffsetY, "float", entY.Text);
                }
                if (targetEntity == "Bentley")
                {
                    m.FreezeValue(bentleyStructBase + TransformOffset.coordOffsetY, "float", entY.Text);
                }
                if (targetEntity == "Murray")
                {
                    m.FreezeValue(murrayStructBase + TransformOffset.coordOffsetY, "float", entY.Text);
                }
            }
            else
            {
                if (targetEntity == "Sly")
                {
                    m.UnfreezeValue(slyStructBase + TransformOffset.coordOffsetY);
                }
                if (targetEntity == "Bentley")
                {
                    m.UnfreezeValue(bentleyStructBase + TransformOffset.coordOffsetY);
                }
                if (targetEntity == "Murray")
                {
                    m.UnfreezeValue(murrayStructBase + TransformOffset.coordOffsetY);
                }
            }
        }
        private void entFreezeZ_Click(object sender, EventArgs e) //entity freeze Z
        {
            toggleEntFreezeZ = !toggleEntFreezeZ;
            if (toggleEntFreezeZ)
            {
                if (targetEntity == "Sly")
                {
                    m.FreezeValue(slyStructBase + TransformOffset.coordOffsetZ, "float", entZ.Text);
                }
                if (targetEntity == "Bentley")
                {
                    m.FreezeValue(bentleyStructBase + TransformOffset.coordOffsetZ, "float", entZ.Text);
                }
                if (targetEntity == "Murray")
                {
                    m.FreezeValue(murrayStructBase + TransformOffset.coordOffsetZ, "float", entZ.Text);
                }
            }
            else
            {
                if (targetEntity == "Sly")
                {
                    m.UnfreezeValue(slyStructBase + TransformOffset.coordOffsetZ);
                }
                if (targetEntity == "Bentley")
                {
                    m.UnfreezeValue(bentleyStructBase + TransformOffset.coordOffsetZ);
                }
                if (targetEntity == "Murray")
                {
                    m.UnfreezeValue(murrayStructBase + TransformOffset.coordOffsetZ);
                }
            }
        }
        private void actEntFreezeX_Click(object sender, EventArgs e) //active freeze X
        {
            toggleActFreezeX = !toggleActFreezeX;
            if (toggleActFreezeX)
            {
                m.FreezeValue(actStructBase + TransformOffset.coordOffsetX, "float", actEntX.Text);
            }
            else
            {
                m.UnfreezeValue(actStructBase + TransformOffset.coordOffsetX);
            }
        }
        private void actEntFreezeY_Click(object sender, EventArgs e) //active freeze Y
        {
            toggleActFreezeY = !toggleActFreezeY;
            if (toggleActFreezeY)
            {
                m.FreezeValue(actStructBase + TransformOffset.coordOffsetY, "float", actEntY.Text);
            }
            else
            {
                m.UnfreezeValue(actStructBase + TransformOffset.coordOffsetY);
            }
        }
        private void actEntFreezeZ_Click(object sender, EventArgs e) //active freeze Z
        {
            toggleActFreezeZ = !toggleActFreezeZ;
            if (toggleActFreezeZ)
            {
                m.FreezeValue(actStructBase + TransformOffset.coordOffsetZ, "float", actEntZ.Text);
            }
            else
            {
                m.UnfreezeValue(actStructBase + TransformOffset.coordOffsetZ);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentTab = tabControl1.SelectedIndex;
        } //active character shit

        private void entScaleTrackbar_ValueChanged(object sender, EventArgs e)
        {
            m.WriteMemory(currentSelectedStruct + TransformOffset.scaleOffsetX, "float", (entScaleTrackbar.Value / 100f).ToString("f1"));
            m.WriteMemory(currentSelectedStruct + TransformOffset.scaleOffsetY, "float", (entScaleTrackbar.Value / 100f).ToString("f1"));
            m.WriteMemory(currentSelectedStruct + TransformOffset.scaleOffsetZ, "float", (entScaleTrackbar.Value / 100f).ToString("f1"));
            entScale.Invoke((MethodInvoker)delegate
            {
                entScale.Text = (entScaleTrackbar.Value / 100f).ToString("f1");
            });
        } //entity scale 
    }
}