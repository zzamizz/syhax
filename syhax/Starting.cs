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

        public static class Sly2CRC
        {
            public const string Sly2PAL = "FDA1CBF6";
            public const string Sly2NTSC = "07652DD9";
            public const string Sly2NTSCJ = "615EA2DB";
            public const string Sly2NTSCK = "518DD841";
            public const string Sly2Mar17 = "DD0B5E6C";
            public const string Sly2Jul12 = "A480549C";
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
                }
            }
        }
    }
}
