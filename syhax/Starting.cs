using System;
using System.Windows.Forms;
using Memory;

namespace syhax
{
    public partial class Starting : Form
    {
        public Starting()
        {
            InitializeComponent();
        }

        public Mem m = new Mem();

        public string gameCRC;

        public static class Sly1CRC
        {
            public const string Sly1PAL = "DA3DD765";
            public const string Sly1NTSC = "C77AF2CA";
            public const string Sly1NTSCJ = "15C88C7B";
            public const string Sly1NTSCK = "65969595"; //placeholder
        }
        public static class Sly2CRC
        {
            public const string Sly2PAL = "FDA1CBF6";
            public const string Sly2NTSC = "07652DD9";
            public const string Sly2NTSCJ = "615EA2DB";
            public const string Sly2NTSCK = "518DD841";
            public const string Sly2Mar17 = "DD0B5E6C";
            public const string Sly2Jul12 = "A480549C";
        }
        public static class Sly3CRC
        {
            public const string Sly3PAL = "8164C614";
            public const string Sly3NTSC = "8BC95883";
            public const string Sly3NTSCJ = "65969598"; //placeholder
            public const string Sly3NTSCK = "65969591"; //placeholder
        }

        public bool check = true;

        private void Starting_Load(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy && check)
                backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (true)
            {
                int pID = m.GetProcIdFromName("pcsx2"); //get process ID
                bool openProc = false; //is process running?

                if (pID > 0)
                {
                    openProc = m.OpenProcess(pID);
                }

                if (openProc && check)
                {
                    gameCRC = m.ReadInt("pcsx2.exe+0x0106C780").ToString("X8");

                    // Sly 1
                    if (gameCRC == Sly1CRC.Sly1PAL && check)
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            syhax1 Sly1 = new syhax1();
                            this.Hide();
                            Sly1.Show();
                            check = false;
                        });
                    }
                    else if (gameCRC == Sly1CRC.Sly1NTSC && check)
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            syhax1 Sly1 = new syhax1();
                            this.Hide();
                            Sly1.Show();
                            check = false;
                        });
                    }
                    else if (gameCRC == Sly1CRC.Sly1NTSCJ && check)
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            syhax1 Sly1 = new syhax1();
                            this.Hide();
                            Sly1.Show();
                            check = false;
                        });
                    }
                    else if (gameCRC == Sly1CRC.Sly1NTSCK && check)
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            syhax1 Sly1 = new syhax1();
                            this.Hide();
                            Sly1.Show();
                            check = false;
                        });
                    }

                    // Sly 2
                    if (gameCRC == Sly2CRC.Sly2PAL && check)
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            syhax2 Sly2 = new syhax2();
                            this.Hide();
                            Sly2.Show();
                            check = false;
                        });
                    }
                    else if (gameCRC == Sly2CRC.Sly2NTSC && check)
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            syhax2 Sly2 = new syhax2();
                            this.Hide();
                            Sly2.Show();
                            check = false;
                        });
                    }
                    else if (gameCRC == Sly2CRC.Sly2NTSCK && check)
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            syhax2 Sly2 = new syhax2();
                            this.Hide();
                            Sly2.Show();
                            check = false;
                        });
                    }
                    else if (gameCRC == Sly2CRC.Sly2NTSCJ && check)
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            syhax2 Sly2 = new syhax2();
                            this.Hide();
                            Sly2.Show();
                            check = false;
                        });
                    }
                    else if (gameCRC == Sly2CRC.Sly2Mar17 && check)
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            syhax2 Sly2 = new syhax2();
                            this.Hide();
                            Sly2.Show();
                            check = false;
                        });
                    }
                    else if (gameCRC == Sly2CRC.Sly2Jul12 && check)
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            syhax2 Sly2 = new syhax2();
                            this.Hide();
                            Sly2.Show();
                            check = false;
                        });
                    }

                    // Sly 3
                    if (gameCRC == Sly3CRC.Sly3PAL && check)
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            syhax3 Sly3 = new syhax3();
                            this.Hide();
                            Sly3.Show();
                            check = false;
                        });
                    }
                    else if (gameCRC == Sly3CRC.Sly3NTSC && check)
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            syhax3 Sly3 = new syhax3();
                            this.Hide();
                            Sly3.Show();
                            check = false;
                        });
                    }
                    else if (gameCRC == Sly3CRC.Sly3NTSCK && check)
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            syhax3 Sly3 = new syhax3();
                            this.Hide();
                            Sly3.Show();
                            check = false;
                        });
                    }
                    else if (gameCRC == Sly3CRC.Sly3NTSCJ && check)
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            syhax3 Sly3 = new syhax3();
                            this.Hide();
                            Sly3.Show();
                            check = false;
                        });
                    }
                }
            }
        }
    }
}
