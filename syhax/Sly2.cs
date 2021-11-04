using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Memory;

namespace syhax
{
    public partial class syhax2 : Form
    {
        public syhax2()
        {
            InitializeComponent();
            timer1.Start();
        }
        public Mem m = new Mem();

        private void syhax2_Load(object sender, EventArgs e)
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

        public static void DelgeateThisShit(Label Label, string text)
        {
            Label.Invoke((MethodInvoker)delegate
            {
                Label.Text = text;
            });
        }

        private void syhax2_FormClosed(object sender, FormClosedEventArgs e) //kill process from ruksi
        {
            Application.Exit();
        }

        public string gameCRC;

        public string targetEntity;

        public int langIndex;
        string langAddr = "202E9254";

        public string indicatorL2;
        string L2NTSC = "202DFC12";

        public string indicatorR2;
        string R2NTSC = "202DFC13";

        public string gameClock;
        string clockPAL = "202E52D8";
        string clockNTSC = "202DDED8";

        public string toggleBattleMus;
        public string toggleSneakMus;
        string botBattleMusNTSC = "203DD09C";
        string botSneakMusNTSC = "203DD0A0";

        public string slyGadget; //gadget power
        string botSlyGadgetPAL = "203DC2B4";
        string botSlyGadgetNTSC = "203D4AB4";
        public string bentleyGadget;
        string botBentleyGadgetPAL = "203DC2E4";
        string botBentleyGadgetNTSC = "203D4ACC";
        public string murrayGadget;
        string botMurrayGadgetPAL = "203DC2CC";
        string botMurrayGadgetNTSC = "203D4AE4";

        public string unlockGadgets1;
        public string unlockGadgets2;
        string botUnlockGadgets1PAL = "203DC2F8";
        string botUnlockGadgets2PAL = "203DC2FC";
        string botUnlockGadgets1NTSC = "203D4AF8";
        string botUnlockGadgets2NTSC = "203D4AFC";
        string botUnlockGadgets1NTSCJ = "203DE2F8";
        string botUnlockGadgets2NTSCJ = "203DE2FC";

        public string disableGuardAI;
        string botDisableGuardAIPAL = "203E8A14";
        string botDisableGuardAINTSC = "203E1214";

        public string charIDAddr;
        string botCharIDPAL = "203DC26C";
        string botCharIDNTSC = "203D4A6C";
        string botCharIDNTSCJ = "20000000"; //placeholder
        string botCharIDNTSCK = "20000000"; //placeholder
        string botCharIDMar17 = "20000000"; //placeholder
        string botCharIDJul12 = "20000000"; //placeholder

        public string slyHP;
        public string slyHPAmount;
        string botSlyHPPAL = "203DC2B0";
        string botSlyHPNTSC = "203D4AB0";
        string botSlyHPNTSCJ = "203DE2B0";
        string botSlyHPNTSCK = "203DD930";

        public string bentleyHP;
        public string bentleyHPAmount;
        string botBentleyHPPAL = "203DC2C8";
        string botBentleyHPNTSC = "203D4AC8";
        string botBentleyHPNTSCJ = "203DE2C8";

        public string murrayHP;
        public string murrayHPAmount;
        string botMurrayHPPAL = "203DC2E0";
        string botMurrayHPNTSC = "203D4AE0";
        string botMurrayHPNTSCJ = "203DE2E0";

        public string actStructBase; //active character pointer
        string botActBasePAL = "202E55A0";
        string botActBaseNTSC = "202DE2F0";
        string botActBaseNTSCJ = "20000000"; //placeholder
        string botActBaseNTSCK = "20000000"; //placeholder
        string botActBaseMar17 = "20000000"; //placeholder
        string botActBaseJul12 = "20000000"; //placeholder

        public string slyStructBase;
        string botSlyBasePAL = "202E9240";
        string botSlyBaseNTSC = "202E1E40";
        string botSlyBaseNTSCJ = "20000000"; //placeholder
        string botSlyBaseNTSCK = "20000000"; //placeholder
        string botSlyBaseMar17 = "20000000"; //placeholder
        string botSlyBaseJul12 = "20000000"; //placeholder

        public string bentleyStructBase;
        string botBentleyBasePAL = "20000000"; //placeholder
        string botBentleyBaseNTSC = "202DD5BC";
        string botBentleyBaseNTSCJ = "20000000"; //placeholder
        string botBentleyBaseNTSCK = "20000000"; //placeholder
        string botBentleyBaseMar17 = "20000000"; //placeholder
        string botBentleyBaseJul12 = "20000000"; //placeholder

        public string murrayStructBase;
        string botMurrayBasePAL = "20000000"; //placeholder
        string botMurrayBaseNTSC = "202F7900";
        string botMurrayBaseNTSCJ = "20000000"; //placeholder
        string botMurrayBaseNTSCK = "20000000"; //placeholder
        string botMurrayBaseMar17 = "20000000"; //placeholder
        string botMurrayBaseJul12 = "20000000"; //placeholder

        public string neylaStructBase;
        string botNeylaBasePAL = "20000000"; //placeholder
        string botNeylaBaseNTSC = "203E0798";
        string botNeylaBaseNTSCJ = "20000000"; //placeholder
        string botNeylaBaseNTSCK = "20000000"; //placeholder
        string botNeylaBaseMar17 = "20000000"; //placeholder
        string botNeylaBaseJul12 = "20000000"; //placeholder

        public string dimitriStructBase;
        string botDimitriBasePAL = "20000000"; //placeholder
        string botDimitriBaseNTSC = "203E078C";
        string botDimitriBaseNTSCJ = "20000000"; //placeholder
        string botDimitriBaseNTSCK = "20000000"; //placeholder
        string botDimitriBaseMar17 = "20000000"; //placeholder
        string botDimitriBaseJul12 = "20000000"; //placeholder

        public string carmStructBase;
        string botCarmBasePAL = "20000000"; //placeholder
        string botCarmBaseNTSC = "20000000"; //placeholder
        string botCarmBaseNTSCJ = "20000000"; //placeholder
        string botCarmBaseNTSCK = "20000000"; //placeholder
        string botCarmBaseMar17 = "20000000"; //placeholder
        string botCarmBaseJul12 = "20000000"; //placeholder

        public string gangHPGUI;
        string botGangHPGUIPAL = "203E16B8";
        string botGangHPGUINTSC = "203D9EB8";

        public string coinGUI;
        string botCoinGUIPAL = "203E883C";

        public string bottleGUI;
        string botBottleGUIPAL = "203E8848";
        string botBottleGUINTSC = "203E1048";

        public string ejectGUI;
        string botEjectGUIPAL = "203E1D14";

        public string blackbarsGUI;
        string botBlackbarsGUIPAL = "202E9260";
        string botBlackbarsGUINTSC = "202E1E60";

        public string infoboxGUI;
        string botInfoboxGUIPAL = "203E18E8";
        string botInfoboxGUINTSC = "203DA0E8";

        public string slymaskGUI;
        string botSlyMaskGUIPAL = "2044AF94";

        public string failGUI;
        string botFailGUIPAL = "203E82BC";
        string botFailGUINTSC = "203E0ABC";

        public string thiefNetGUI;
        string botThiefNetGUINTSC = "203DA174";

        public string currentSelectedStruct;
        public string activeStruct;

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

        public static class GUIStruct
        {
            public const string guiActivate = ",0x20000064"; //Activate
            public const string guiHPos = ",0x2000009C"; //Horizontal Position
            public const string guiVPos = ",0x200000A0"; //Vertical Position
        }

        public string currentSelectedGUI;
        public int guiState;

        public static class GuardAOB
        {
            public const string swarmer = "?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 46 4B 24 58 6E 70 63 5F 73 77 61 72 6D 65 72 5F";
            public const string moose = "?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 46 4B 24 58 6E 70 63 5F 6D 6F 6F 73 65 5F 67 75 61 72 64";
        }

        bool toggleEntFreezeX;
        bool toggleEntFreezeY;
        bool toggleEntFreezeZ;
        bool toggleActFreezeX;
        bool toggleActFreezeY;
        bool toggleActFreezeZ;
        bool toggleHPFreeze;

        bool toggleInfGadget;
        bool toggleWeed;

        public string mooseScan;

        bool foundCRC = false;

        public int actCharIndex;

        public int currentMapIndex;

        public int currentTab;

        public static class Sly2CRC
        {
            public const string Sly2PAL = "FDA1CBF6";
            public const string Sly2NTSC = "07652DD9";
            public const string Sly2NTSCJ = "615EA2DB";
            public const string Sly2NTSCK = "518DD841";
            public const string Sly2Mar17 = "DD0B5E6C";
            public const string Sly2Jul12 = "A480549C";
        }

        public string reloadFunc;
        string botReloadFuncPAL = "0x203E8880";
        string botReloadFuncNTSC = "0x203E1080";

        public string guardSize;
        string botGuardSizePAL = "0x203E9270";
        string botGuardSizeNTSC = "0x203E1A70";

        public string resetCam;
        string botResetCamPAL = "0x202E5640";
        string botResetCamNTSC = "0x202DE240";

        public string reloadAOB;
        string botReloadAOBPAL = "0x203E8888";
        string botReloadAOBNTSC = "0x203E1088";

        public string mapID;
        string botMapIDPAL = "0x203E8910";
        string botMapIDNTSC = "0x203E1110";

        // Episode 0
        public string mapCairo;

        // Main Menu
        public string mapMenu;

        // Episode 1
        public string mapParis;
        public string mapWineDoor;
        public string mapWineLasers;
        public string mapDiscoBackdoor;
        public string mapDiscoWindow;
        public string mapPrintRecon;
        public string mapPrintBoss;
        public string mapTheater;
        public string mapWaterPump;

        // Episode 2
        public string mapIndia;
        public string mapHotelFront;
        public string mapHotelEnt2;
        public string mapHotelEnt3;
        public string mapHotelEnt4;
        public string mapBasement;
        public string mapBalls;

        // Episode 3
        public string mapIndia2;
        public string mapSpiceBottom;
        public string mapSpiceTop;
        public string mapSpice;
        public string mapRajan;

        // Episode 4
        public string mapPrague;
        public string mapPrisonMurray;
        public string mapPrison;
        public string mapVaultRoom;

        // Episode 5
        public string mapPrague2;
        public string mapCrypt1;
        public string mapCrypt2;
        public string mapCrypt3;
        public string mapGhost;
        public string mapReeducation;
        public string mapCryptHack;
        public string mapCryptMojo1;
        public string mapCryptMojo2;
        public string mapCryptMojo3;
        public string mapCryptMojo4;

        // Episode 6
        public string mapCanada;
        public string mapCabin1;
        public string mapCabin2;
        public string mapCabin3;
        public string mapTrainAerial;
        public string mapTrainTheft;
        public string mapTrainRide;
        public string mapTrainOP;

        // Episode 7
        public string mapCanada2;
        public string mapRC;
        public string mapSawmill;
        public string mapLighthouse;
        public string mapBear;
        public string mapSawmillBoss;

        // Episode 8
        public string mapBlimp;
        public string mapBlimpHQ;
        public string mapEngine1;
        public string mapEngine2;
        public string mapEngine3;
        public string mapParisFinale;

        public static class LevelAOB
        {
            public const string cairoPAL = "C0 E1 04 00 6F 93 99 00 5B 00 00 02 00 00 00 00 00 00 00 00 00 00 02 00 00 00 00 00 00 00 00 00 00 00 00 00 00 02 00 00 00 00 00 00 00 00 02 00 00 00 00 00 00 00 00 00 00 00 00 02 02 00 00 00 89 01 00 00 FF FF FF FF C0 E1 04 00 6F 93 99 00 5B 00 00 02 00 00 00 00 00 00 00 00 00 00 02 00 00 00 00 00 00 00 00 00 00 00 00 00 00 02 00 00 00 00 00 00 00 00 02 00 00 00 00 00 00 00 00 00 00 00 00 02 02 00 00 00";
            public const string cairoNTSC = "4E A8 89 61 7A 56 E3 D1 1C 6C 04 FB 2D 05 A9 A1 B5 7C 6F 59 3A 10 EB FC F7 1B 3C 01 32 5E E4 77 3D 6B 28 BB B8 72 FE 3B 68 2A 84 67 79 9F 7E 0E F3 FF D7 A8 AE B9 8C 61 41 6C 04 FB DC 76 7B D1 89 01 00 00 FF FF FF FF 4E A8 89 61 7A 56 E3 D1 1C 6C 04 FB 2D 05 A9 A1 B5 7C 6F 59 3A 10 EB FC F7 1B 3C 01 32 5E E4 77 3D 6B 28 BB B8 72 FE 3B 68 2A 84 67 79 9F 7E 0E F3 FF D7 A8 AE B9 8C 61 41 6C 04 FB DC 76 7B D1";
            public const string cairoNTSCJ = "00 C5 04 00 48 31 99 00 55 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 02 00 00 00 00 00 00 00 00 00 02 02 02 00 04 4C 02 00 FF FF FF FF 00 C5 04 00 48 31 99 00 55 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 02 00 00 00 00 00 00 00 00 00 02 02 02 00 00 00 00 00 00 00 00 00 04 4C 02 00 FF FF FF FF";
            public const string cairoNTSCK = "";
            public const string cairoJul12 = "";

            public const string menuPAL = "C3 D3 07 0E 2E AD E2 B6 E3 F0 4D C6 D6 1D 81 F6 9B EA 62 ED AD 1A 8A 6B A6 98 23 46 06 91 0A C0 19 AC 66 43 F7 16 BD A5 36 87 56 12 F3 50 F4 58 89 60 C9 6E E3 C8 02 0E D4 F0 4D C6 2D 03 FC B6 89 01 00 00 FF FF FF FF C3 D3 07 0E 2E AD E2 B6 E3 F0 4D C6 D6 1D 81 F6 9B EA 62 ED AD 1A 8A 6B A6 98 23 46 06 91 0A C0 19 AC 66 43 F7 16 BD A5 36 87 56 12 F3 50 F4 58 89 60 C9 6E E3 C8 02 0E D4 F0 4D C6 2D 03 FC B6";
            public const string menuNTSC = "8F 1B 8D AE A1 9F 15 6B C9 55 34 93 EA 14 1C B0 9D FA DC 0B D9 67 91 21 2C AA B3 DF F9 A5 0A D0 82 D3 41 35 EC BF 73 F2 38 D1 7C BA C1 06 77 96 BD 97 7E 22 AF 50 88 AE F0 55 34 93 9E 5F 08 6B 89 01 00 00 FF FF FF FF 8F 1B 8D AE A1 9F 15 6B C9 55 34 93 EA 14 1C B0 9D FA DC 0B D9 67 91 21 2C AA B3 DF F9 A5 0A D0 82 D3 41 35 EC BF 73 F2 38 D1 7C BA C1 06 77 96 BD 97 7E 22 AF 50 88 AE F0 55 34 93 9E 5F 08 6B";
            public const string menuNTSCJ = "9F BE 9A AF BA 82 6F 33 A7 DE F8 97 AC 21 8E A9 1D E3 94 24 48 FA 2E B2 F3 7F 4C 79 CE C6 52 D2 04 19 76 6D E1 F9 15 2D 3B B0 C9 CB 7C DC 0C A0 7E 91 51 8F 3F 40 9E AF 96 DE F8 97 72 74 4F 33 89 01 00 00 FF FF FF FF 9F BE 9A AF BA 82 6F 33 A7 DE F8 97 AC 21 8E A9 1D E3 94 24 48 FA 2E B2 F3 7F 4C 79 CE C6 52 D2 04 19 76 6D E1 F9 15 2D 3B B0 C9 CB 7C DC 0C A0 7E 91 51 8F 3F 40 9E AF 96 DE F8 97 72 74 4F 33";
            public const string menuNTSCK = "";
            public const string menuMar17 = "46 4B 24 5A 73 70 6C 61 73 68 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 71 01 00 00 FF FF FF FF 46 4B 24 5A 73 70 6C 61 73 68 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00";

            public const string parisPAL = "C0 29 05 00 12 98 AA 00 3F 00 00 00 02 00 00 00 00 00 00 00 00 00 02 02 02 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 89 01 00 00 FF FF FF FF C0 29 05 00 12 98 AA 00 3F 00 00 00 02 00 00 00 00 00 00 00 00 00 02 02 02 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00";
            public const string parisNTSC = "C1 79 68 65 6F 8F CA 64 2C 6F 20 66 73 20 74 6F 20 66 6F 72 63 65 20 77 6F 72 64 20 74 6F 20 74 72 65 61 74 20 74 68 69 73 20 63 6F 6C 75 6D 6E 20 61 73 20 61 20 6D 65 6D 6F 20 66 69 65 6C 64 89 01 00 00 FF FF FF FF C1 79 68 65 6F 8F CA 64 2C 6F 20 66 73 20 74 6F 20 66 6F 72 63 65 20 77 6F 72 64 20 74 6F 20 74 72 65 61 74 20 74 68 69 73 20 63 6F 6C 75 6D 6E 20 61 73 20 61 20 6D 65 6D 6F 20 66 69 65 6C 64 02 00 00 00 00 00 00 00 89 01 00 00 FF FF FF FF";
            public const string parisNTSCJ = "80 0D CD 02 04 F3 A9 9C 9E 10 00 00 10 00 00 00 00 00 A4 04 80 10 00 00 00 00 00 ED 03 A4 10 00 00 00 00 00 E8 03 9C 10 00 00 00 00 00 FC 02 A4 10 00 00 00 00 00 C8 02 A7 10 00 00 00 00 00 9C 89 01 00 00 FF FF FF FF 80 0D CD 02 04 F3 A9 9C 9E 10 00 00 10 00 00 00 00 00 A4 04 80 10 00 00 00 00 00 ED 03 A4 10 00 00 00 00 00 E8 03 9C 10 00 00 00 00 00 FC 02 A4 10 00 00 00 00 00 C8 02 A7 10 00 00 00 00 00 9C 02 00 00 00 00 00 00 00 89 01 00 00 FF FF FF FF";
            public const string parisNTSCK = "";
            public const string parisMar17 = "46 4B 24 5A 66 5F 6E 69 67 68 74 63 6C 75 62 5F 65 78 74 65 72 69 6F 72 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 71 01 00 00 FF FF FF FF 46 4B 24 5A 66 5F 6E 69 67 68 74 63 6C 75 62 5F 65 78 74 65 72 69 6F 72 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00";
            public const string parisJul12 = "";

            public const string wineDoorPAL = "E0 86 05 00 C6 2C 68 00 39 00 00 00 FF 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 8D 01 00 00 FF FF FF FF E0 86 05 00 C6 2C 68 00 39 00 00 00 FF 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00";
            public const string wineDoorNTSC = "4A B5 05 00 12 7D 65 00 C4 FF 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03 00 00 FF FF 00 00 00 00 00 00 8D 01 00 00 FF FF FF FF 4A B5 05 00 12 7D 65 00 C4 FF 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03 00 00 FF FF 00 00 00 00 00 00";
            public const string wineDoorNTSCJ = "80 31 05 5C 75 CA 68 60 33 5D 00 5E 00 47 00 48 00 49 00 4A 00 4B 00 4C 00 4D 00 4E 00 4F 00 50 00 51 00 52 00 53 00 54 00 55 00 56 00 57 00 58 00 59 00 5A 00 5B 00 5C 00 5D 00 5E 00 5F 00 60 8D 01 00 00 FF FF FF FF 80 31 05 5C 75 CA 68 60 33 5D 00 5E 00 47 00 48 00 49 00 4A 00 4B 00 4C 00 4D 00 4E 00 4F 00 50 00 51 00 52 00 53 00 54 00 55 00 56 00 57 00 58 00 59 00 5A 00 5B 00 5C 00 5D 00 5E 00 5F 00 60 03 00 00 00 00 00 00 00 8D 01 00 00 FF FF FF FF";
            public const string wineDoorNTSCK = "";
            public const string wineDoorMar17 = "46 4B 24 5A 66 5F 6E 69 67 68 74 63 6C 75 62 5F 63 65 6C 6C 61 72 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 71 01 00 00 FF FF FF FF 46 4B 24 5A 66 5F 6E 69 67 68 74 63 6C 75 62 5F 63 65 6C 6C 61 72 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00";

            public const string wineLasersPAL = "A0 87 47 01 83 D2 2E 01 7A 01 44 01 1B 01 1C 01 1D 01 1E 01 1F 01 20 01 26 01 2F 01 30 01 31 01 35 01 36 01 37 01 39 01 3A 01 3B 01 3C 01 3D 01 3E 01 3F 01 40 01 42 01 43 01 44 01 45 01 46 01 66 E4 01 00 FF FF FF FF A0 87 47 01 83 D2 2E 01 7A 01 44 01 1B 01 1C 01 1D 01 1E 01 1F 01 20 01 26 01 2F 01 30 01 31 01 35 01 36 01 37 01 39 01 3A 01 3B 01 3C 01 3D 01 3E 01 3F 01 40 01 42 01 43 01 44 01 45 01 46 01";
            public const string wineLasersNTSC = "34 DE 6C 73 67 10 0B 20 1B 63 6F 6C 72 20 32 35 35 20 63 68 61 72 61 63 74 65 72 73 20 74 6F 20 66 6F 72 63 65 20 77 6F 72 64 20 74 6F 20 74 72 65 61 74 20 74 68 69 73 20 63 6F 6C 75 6D 6E 20 66 E4 01 00 FF FF FF FF 34 DE 6C 73 67 10 0B 20 1B 63 6F 6C 72 20 32 35 35 20 63 68 61 72 61 63 74 65 72 73 20 74 6F 20 66 6F 72 63 65 20 77 6F 72 64 20 74 6F 20 74 72 65 61 74 20 74 68 69 73 20 63 6F 6C 75 6D 6E 20";
            public const string wineLasersNTSCJ = "80 31 05 5C 75 CA 68 60 33 5D 00 5E 00 47 00 48 00 49 00 4A 00 4B 00 4C 00 4D 00 4E 00 4F 00 50 00 51 00 52 00 53 00 54 00 55 00 56 00 57 00 58 00 59 00 5A 00 5B 00 5C 00 5D 00 5E 00 5F 00 60 6E E4 01 00 FF FF FF FF 80 31 05 5C 75 CA 68 60 33 5D 00 5E 00 47 00 48 00 49 00 4A 00 4B 00 4C 00 4D 00 4E 00 4F 00 50 00 51 00 52 00 53 00 54 00 55 00 56 00 57 00 58 00 59 00 5A 00 5B 00 5C 00 5D 00 5E 00 5F 00 60 03 00 00 00 00 00 00 00 6E E4 01 00 FF FF FF FF";
            public const string wineLasersNTSCK = "";
            public const string wineLasersMar17 = "";
            public const string wineLasersJul12 = "";

            public const string discoBackdoorPAL = "00 B3 05 00 70 02 78 00 3C 00 00 00 1A 00 C7 06 00 00 FF FF 91 00 00 00 FF FF 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 8E 01 00 00 FF FF FF FF 00 B3 05 00 70 02 78 00 3C 00 00 00 1A 00 C7 06 00 00 FF FF 91 00 00 00 FF FF 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00";
            public const string discoBackdoorNTSC = "00 E2 05 00 98 A7 74 00 3E 00 80 3F C7 06 00 00 FF FF 91 00 00 00 FF FF 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 91 01 00 00 FF FF FF FF 00 E2 05 00 98 A7 74 00 3E 00 80 3F C7 06 00 00 FF FF 91 00 00 00 FF FF 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00";
            public const string discoBackdoorNTSCJ = "A0 96 05 00 92 C2 77 00 36 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03 00 00 FF FF 00 00 00 00 00 00 00 00 00 00 00 00 00 00 91 01 00 00 FF FF FF FF A0 96 05 00 92 C2 77 00 36 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03 00 00 FF FF 00 00 00 00 00 00 00 00 00 00 00 00 00 00";
            public const string discoBackdoorNTSCK = "";
            public const string discoBackdoorMar17 = "46 4B 24 5A 66 5F 6E 69 67 68 74 63 6C 75 62 5F 64 69 73 63 6F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 71 01 00 00 FF FF FF FF 46 4B 24 5A 66 5F 6E 69 67 68 74 63 6C 75 62 5F 64 69 73 63 6F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00";
            public const string discoBackdoorJul12 = "";

            public const string discoWindowPAL = "00 B3 05 00 70 02 78 00 3C 00 00 00 1A 00 C7 06 00 00 FF FF 91 00 00 00 FF FF 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 91 01 00 00 FF FF FF FF 00 B3 05 00 70 02 78 00 3C 00 00 00 1A 00 C7 06 00 00 FF FF 91 00 00 00 FF FF 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00";
            public const string discoWindowNTSC = "00 E2 05 00 98 A7 74 00 3E 00 80 3F C7 06 00 00 FF FF 91 00 00 00 FF FF 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 8E 01 00 00 FF FF FF FF 00 E2 05 00 98 A7 74 00 3E 00 80 3F C7 06 00 00 FF FF 91 00 00 00 FF FF 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00";
            public const string discoWindowNTSCJ = "A0 96 05 00 92 C2 77 00 36 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03 00 00 FF FF 00 00 00 00 00 00 00 00 00 00 00 00 00 00 8E 01 00 00 FF FF FF FF A0 96 05 00 92 C2 77 00 36 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03 00 00 FF FF 00 00 00 00 00 00 00 00 00 00 00 00 00 00";
            public const string discoWindowNTSCK = "";
            public const string discoWindowMar17 = "";
            public const string discoWindowJul12 = "";

            public const string printReconPAL = "AE 1B 06 00 25 2D 53 00 42 00 00 00 43 FF 00 00 00 FF FF 00 03 00 17 16 02 00 FF FF 38 00 00 00 FF FF 21 FF 6E 3F FD 7B B7 BE 00 00 00 00 FD 7B B7 3E 21 FF 6E 3F 00 00 00 00 00 00 00 00 00 00 92 01 00 00 FF FF FF FF AE 1B 06 00 25 2D 53 00 42 00 00 00 43 FF 00 00 00 FF FF 00 03 00 17 16 02 00 FF FF 38 00 00 00 FF FF 21 FF 6E 3F FD 7B B7 BE 00 00 00 00 FD 7B B7 3E 21 FF 6E 3F 00 00 00 00 00 00 00 00 00 00";
            public const string printReconNTSC = "BF C6 04 01 3E C3 4F FF 44 CD CC 4C 00 17 16 02 00 06 00 07 00 00 00 7D 02 06 00 1B 16 02 00 8E 02 06 00 57 44 00 00 06 00 FF FF FF FF 7D 02 06 00 FF FF FF FF 94 02 01 00 CD CC 4C 3E 06 00 FF 92 01 00 00 FF FF FF FF BF C6 04 01 3E C3 4F FF 44 CD CC 4C 00 17 16 02 00 06 00 07 00 00 00 7D 02 06 00 1B 16 02 00 8E 02 06 00 57 44 00 00 06 00 FF FF FF FF 7D 02 06 00 FF FF FF FF 94 02 01 00 CD CC 4C 3E 06 00 FF";
            public const string printReconNTSCJ = "A0 37 A8 34 EC 2B 5B A4 5A 46 74 61 38 00 00 00 FF FF 21 FF 6E 3F FD 7B B7 BE 00 00 00 00 FD 7B B7 3E 21 FF 6E 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F AE 34 66 46 74 61 D7 C5 09 A4 92 01 00 00 FF FF FF FF A0 37 A8 34 EC 2B 5B A4 5A 46 74 61 38 00 00 00 FF FF 21 FF 6E 3F FD 7B B7 BE 00 00 00 00 FD 7B B7 3E 21 FF 6E 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F AE 34 66 46 74 61 D7 C5 09 A4 05 00 00 00 00 00 00 00 92 01 00 00 FF FF FF FF";
            public const string printReconNTSCK = "";
            public const string printReconMar17 = "46 4B 24 59 66 5F 6E 69 67 68 74 63 6C 75 62 5F 68 65 69 73 74 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 7A 01 00 00 FF FF FF FF 46 4B 24 59 66 5F 6E 69 67 68 74 63 6C 75 62 5F 68 65 69 73 74 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00";
            public const string printReconJul12 = "";

            public const string printBossPAL = "58 24 9F 00 B9 2D CE 00 D8 00 9B 00 84 00 85 00 86 00 87 00 88 00 89 00 8A 00 8B 00 8C 00 8D 00 8E 00 8F 00 90 00 91 00 92 00 93 00 94 00 95 00 96 00 97 00 98 00 99 00 9A 00 9B 00 9C 00 9D 00 AE DF 01 00 FF FF FF FF 58 24 9F 00 B9 2D CE 00 D8 00 9B 00 84 00 85 00 86 00 87 00 88 00 89 00 8A 00 8B 00 8C 00 8D 00 8E 00 8F 00 90 00 91 00 92 00 93 00 94 00 95 00 96 00 97 00 98 00 99 00 9A 00 9B 00 9C 00 9D 00";
            public const string printBossNTSC = "40 52 06 00 00 C5 4F 00 44 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 09 03 00 00 FF FF 00 00 00 00 00 00 00 00 00 00 00 00 00 00 AE DF 01 00 FF FF FF FF 40 52 06 00 00 C5 4F 00 44 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 09 03 00 00 FF FF 00 00 00 00 00 00 00 00 00 00 00 00 00 00";
            public const string printBossNTSCJ = "20 08 06 00 3B EE 52 00 3C 00 80 3F CB 06 00 00 FF FF 91 00 00 00 FF FF 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 B6 DF 01 00 FF FF FF FF 20 08 06 00 3B EE 52 00 3C 00 80 3F CB 06 00 00 FF FF 91 00 00 00 FF FF 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00";
            public const string printBossNTSCK = "";
            public const string printBossMar17 = "46 4B 24 5A 66 5F 6E 69 67 68 74 63 6C 75 62 5F 68 65 69 73 74 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 71 01 00 00 FF FF FF FF 46 4B 24 5A 66 5F 6E 69 67 68 74 63 6C 75 62 5F 68 65 69 73 74 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00";
            public const string printBossJul12 = "";

            public const string theaterPAL = "00 EB 05 00 0B 14 5B 00 45 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03 00 00 FF FF 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 90 01 00 00 FF FF FF FF 00 EB 05 00 0B 14 5B 00 45 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03 00 00 FF FF 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00";
            public const string theaterNTSC = "80 E6 F9 00 DF C1 57 00 47 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03 00 00 FF FF 00 00 00 00 00 00 00 00 00 90 01 00 00 FF FF FF FF 80 E6 F9 00 DF C1 57 00 47 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03 00 00 FF FF 00 00 00 00 00 00 00 00 00";
            public const string theaterNTSCJ = "00 F1 05 00 21 D7 5A 00 3F 00 00 00 91 00 00 00 FF FF 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 90 01 00 00 FF FF FF FF 00 F1 05 00 21 D7 5A 00 3F 00 00 00 91 00 00 00 FF FF 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00";
            public const string theaterNTSCK = "";
            public const string theaterMar17 = "46 4B 24 5A 66 5F 6E 69 67 68 74 63 6C 75 62 5F 6D 6F 75 6C 69 6E 72 6F 75 67 65 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 71 01 00 00 FF FF FF FF 46 4B 24 5A 66 5F 6E 69 67 68 74 63 6C 75 62 5F 6D 6F 75 6C 69 6E 72 6F 75 67 65 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00";
            public const string theaterJul12 = "";

            public const string waterPumpPAL = "40 04 06 00 24 43 4E 00 47 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03 00 00 FF FF 00 00 00 00 00 00 00 00 00 00 00 00 00 8F 01 00 00 FF FF FF FF 40 04 06 00 24 43 4E 00 47 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03 00 00 FF FF 00 00 00 00 00 00 00 00 00 00 00 00 00";
            public const string waterPumpNTSC = "40 3E 05 0A A3 E6 4A 00 4A 00 00 FF 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03 00 00 FF FF 00 00 00 8F 01 00 00 FF FF FF FF 40 3E 05 0A A3 E6 4A 00 4A 00 00 FF 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03 00 00 FF FF 00 00 00";
            public const string waterPumpNTSCJ = "A0 E7 05 00 C7 0A 4E 00 41 00 80 3F C9 06 00 00 FF FF 91 00 00 00 FF FF 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 8F 01 00 00 FF FF FF FF A0 E7 05 00 C7 0A 4E 00 41 00 80 3F C9 06 00 00 FF FF 91 00 00 00 FF FF 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00";
            public const string waterPumpNTSCK = "";
            public const string waterPumpMar17 = "46 4B 24 5A 66 5F 6E 69 67 68 74 63 6C 75 62 5F 77 61 74 65 72 70 75 6D 70 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 71 01 00 00 FF FF FF FF 46 4B 24 5A 66 5F 6E 69 67 68 74 63 6C 75 62 5F 77 61 74 65 72 70 75 6D 70 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00";
            public const string waterPumpJul12 = "";

            public const string indiaPAL = "A0 4B 06 00 2F 39 B5 00 52 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 02 00 00 00 00 00 00 00 89 01 00 00 FF FF FF FF A0 4B 06 00 2F 39 B5 00 52 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 02 00 00 00 00 00 00 00";
            public const string indiaNTSC = "95 4D 26 63 6B 2A D7 72 3A 61 72 61 75 72 69 6E 67 20 6D 65 72 67 65 73 2E 20 53 6F 72 72 79 2E 20 54 68 69 73 20 74 65 78 74 20 69 73 20 6F 76 65 72 20 32 35 35 20 63 68 61 72 61 63 74 65 72 89 01 00 00 FF FF FF FF 95 4D 26 63 6B 2A D7 72 3A 61 72 61 75 72 69 6E 67 20 6D 65 72 67 65 73 2E 20 53 6F 72 72 79 2E 20 54 68 69 73 20 74 65 78 74 20 69 73 20 6F 76 65 72 20 32 35 35 20 63 68 61 72 61 63 74 65 72";
            public const string indiaNTSCJ = "28 6C 06 00 73 76 B7 01 4A 00 00 00 00 00 00 C8 42 00 00 00 00 03 05 00 04 00 03 00 04 00 02 00 05 00 03 00 05 00 02 00 01 00 05 00 03 00 DE 6B 0D 43 00 00 C8 42 00 00 00 00 00 00 00 00 02 01 89 01 00 00 FF FF FF FF 28 6C 06 00 73 76 B7 01 4A 00 00 00 00 00 00 C8 42 00 00 00 00 03 05 00 04 00 03 00 04 00 02 00 05 00 03 00 05 00 02 00 01 00 05 00 03 00 DE 6B 0D 43 00 00 C8 42 00 00 00 00 00 00 00 00 02 01";
            public const string indiaNTSCK = "";
            public const string indiaMar17 = "46 4B 24 5A 69 5F 70 61 6C 61 63 65 5F 65 78 74 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 71 01 00 00 FF FF FF FF 46 4B 24 5A 69 5F 70 61 6C 61 63 65 5F 65 78 74 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00";
            public const string indiaJul12 = "";

            public const string hotelFrontPAL = "A0 90 06 00 69 7F 79 FF 53 00 00 00 00 FF FF 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF BA A1 01 00 FF FF FF FF A0 90 06 00 69 7F 79 FF 53 00 00 00 00 FF FF 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF";
            public const string hotelFrontNTSC = "40 BD 06 00 8E D3 7C 03 AA 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03 BA A1 01 00 FF FF FF FF 40 BD 06 00 8E D3 7C 03 AA 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03";
            public const string hotelFrontNTSCJ = "E0 8C F9 00 5E E8 79 00 4D 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03 00 00 FF FF 00 00 00 00 00 00 00 00 00 C2 A1 01 00 FF FF FF FF E0 8C F9 00 5E E8 79 00 4D 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03 00 00 FF FF 00 00 00 00 00 00 00 00 00";
            public const string hotelFrontNTSCK = "";
            public const string hotelFrontMar17 = "46 4B 24 5A 69 5F 70 61 6C 61 63 65 5F 69 6E 74 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 71 01 00 00 FF FF FF FF 46 4B 24 5A 69 5F 70 61 6C 61 63 65 5F 69 6E 74 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00";
            public const string hotelFrontJul12 = "";

            public const string hotelEnt2PAL = "A0 90 06 00 69 7F 79 FF 53 00 00 00 00 FF FF 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 90 01 00 00 FF FF FF FF A0 90 06 00 69 7F 79 FF 53 00 00 00 00 FF FF 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF";
            public const string hotelEnt2NTSC = "40 BD 06 00 8E D3 7C 03 AA 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03 91 01 00 00 FF FF FF FF 40 BD 06 00 8E D3 7C 03 AA 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03";
            public const string hotelEnt2NTSCJ = "";
            public const string hotelEnt2NTSCK = "";
            public const string hotelEnt2Mar17 = "";
            public const string hotelEnt2Jul12 = "";

            public const string hotelEnt3PAL = "A0 90 06 00 69 7F 79 FF 53 00 00 00 00 FF FF 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 8E 01 00 00 FF FF FF FF A0 90 06 00 69 7F 79 FF 53 00 00 00 00 FF FF 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF";
            public const string hotelEnt3NTSC = "40 BD 06 00 8E D3 7C 03 AA 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03 8E 01 00 00 FF FF FF FF 40 BD 06 00 8E D3 7C 03 AA 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03";
            public const string hotelEnt3NTSCJ = "";
            public const string hotelEnt3NTSCK = "";
            public const string hotelEnt3Mar17 = "";
            public const string hotelEnt3Jul12 = "";

            public const string hotelEnt4PAL = "A0 90 06 00 69 7F 79 FF 53 00 00 00 00 FF FF 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 8D 01 00 00 FF FF FF FF A0 90 06 00 69 7F 79 FF 53 00 00 00 00 FF FF 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF";
            public const string hotelEnt4NTSC = "40 BD 06 00 8E D3 7C 03 AA 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03 8D 01 00 00 FF FF FF FF 40 BD 06 00 8E D3 7C 03 AA 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03";
            public const string hotelEnt4NTSCJ = "";
            public const string hotelEnt4NTSCK = "";
            public const string hotelEnt4Mar17 = "";
            public const string hotelEnt4Jul12 = "";

            public const string basementPAL = "A0 B3 06 00 D2 26 60 00 4D 00 00 80 FF 06 00 FF FF FF FF AC 02 00 00 01 FF FF 00 23 00 D4 A0 01 00 FF FF 44 00 00 00 FF FF 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 8D A1 01 00 FF FF FF FF A0 B3 06 00 D2 26 60 00 4D 00 00 80 FF 06 00 FF FF FF FF AC 02 00 00 01 FF FF 00 23 00 D4 A0 01 00 FF FF 44 00 00 00 FF FF 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00";
            public const string basementNTSC = "96 D2 C0 6C 87 24 5D 2D C4 DF C3 FF 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 1C 9B 5C 45 AC 76 0D C6 6C 8B DF C3 FF 00 00 00 2D 8D A1 01 00 FF FF FF FF 96 D2 C0 6C 87 24 5D 2D C4 DF C3 FF 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 1C 9B 5C 45 AC 76 0D C6 6C 8B DF C3 FF 00 00 00 2D";
            public const string basementNTSCJ = "";
            public const string basementNTSCK = "";
            public const string basementMar17 = "46 4B 24 5A 69 5F 70 61 6C 61 63 65 5F 62 61 73 65 6D 65 6E 74 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 71 01 00 00 FF FF FF FF 46 4B 24 5A 69 5F 70 61 6C 61 63 65 5F 62 61 73 65 6D 65 6E 74 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00";
            public const string basementJul12 = "";

            public const string ballsPAL = "20 E0 06 00 46 C4 63 00 4A 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 02 02 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 88 9D 01 00 FF FF FF FF 20 E0 06 00 46 C4 63 00 4A 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 02 02 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00";
            public const string ballsNTSC = "CD 92 06 00 61 F7 60 00 B3 FF 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03 00 00 0B 03 CD 9E 01 00 FF FF 00 00 00 00 00 00 88 9D 01 00 FF FF FF FF CD 92 06 00 61 F7 60 00 B3 FF 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03 00 00 0B 03 CD 9E 01 00 FF FF 00 00 00 00 00 00";
            public const string ballsNTSCJ = "60 C3 06 00 CB 12 64 00 44 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03 00 00 0B 03 D5 9E 01 00 FF FF 00 00 00 00 00 00 00 00 00 00 00 00 90 9D 01 00 FF FF FF FF 60 C3 06 00 CB 12 64 00 44 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03 00 00 0B 03 D5 9E 01 00 FF FF 00 00 00 00 00 00 00 00 00 00 00 00";
            public const string ballsNTSCK = "";
            public const string ballsMar17 = "46 4B 24 5A 69 5F 70 61 6C 61 63 65 5F 62 61 6C 6C 72 6F 6F 6D 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 71 01 00 00 FF FF FF FF 46 4B 24 5A 69 5F 70 61 6C 61 63 65 5F 62 61 6C 6C 72 6F 6F 6D 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00";
            public const string ballsJul12 = "";

            public const string india2PAL = "5F 26 07 02 6B 6D 40 01 55 00 00 FF 02 00 DE 6B 0D 43 00 00 C8 C2 00 00 00 00 00 00 00 00 00 06 00 00 00 06 00 00 00 00 00 00 00 00 00 01 00 00 00 FF FF FF FF 03 00 02 00 00 00 FF FF FF FF 01 89 01 00 00 FF FF FF FF 5F 26 07 02 6B 6D 40 01 55 00 00 FF 02 00 DE 6B 0D 43 00 00 C8 C2 00 00 00 00 00 00 00 00 00 06 00 00 00 06 00 00 00 00 00 00 00 00 00 01 00 00 00 FF FF FF FF 03 00 02 00 00 00 FF FF FF FF 01";
            public const string india2NTSC = "2A 1D 36 3A B8 B1 B6 4C 77 26 32 4C 72 63 6C 65 3A 20 26 32 4F 26 2E 0A 58 3A 20 26 32 58 26 2E 0A 52 31 3A 20 26 32 52 26 2E 0A 52 32 3A 20 26 32 72 26 2E 0A 4C 31 3A 20 26 32 4C 26 2E 0A 4C 89 01 00 00 FF FF FF FF 2A 1D 36 3A B8 B1 B6 4C 77 26 32 4C 72 63 6C 65 3A 20 26 32 4F 26 2E 0A 58 3A 20 26 32 58 26 2E 0A 52 31 3A 20 26 32 52 26 2E 0A 52 32 3A 20 26 32 72 26 2E 0A 4C 31 3A 20 26 32 4C 26 2E 0A 4C";
            public const string india2NTSCJ = "";
            public const string india2NTSCK = "";
            public const string india2Mar17 = "46 4B 24 5A 69 5F 74 65 6D 70 6C 65 5F 65 78 74 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 71 01 00 00 FF FF FF FF 46 4B 24 5A 69 5F 74 65 6D 70 6C 65 5F 65 78 74 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00";
            public const string india2Jul12 = "";

            public const string spiceBottomPAL = "25 8E 07 00 DC 4D 79 00 5F 00 03 00 04 00 00 00 02 00 05 00 09 00 00 00 06 00 03 00 00 00 00 00 00 00 7F 66 00 7F 00 00 08 42 CD CC 2C 42 66 86 BC 43 01 01 E5 02 00 00 07 00 03 00 00 00 00 00 8E 01 00 00 FF FF FF FF 25 8E 07 00 DC 4D 79 00 5F 00 03 00 04 00 00 00 02 00 05 00 09 00 00 00 06 00 03 00 00 00 00 00 00 00 7F 66 00 7F 00 00 08 42 CD CC 2C 42 66 86 BC 43 01 01 E5 02 00 00 07 00 03 00 00 00 00 00";
            public const string spiceBottomNTSC = "86 37 07 40 56 5F F6 00 40 20 00 33 00 01 00 00 00 0D 00 01 00 01 00 00 00 01 00 04 00 02 01 00 33 4C 66 80 00 61 F0 20 00 33 4C 66 80 00 61 F0 E0 FF 33 4C 66 80 00 40 1A 20 00 33 4C 66 80 00 8E 01 00 00 FF FF FF FF 86 37 07 40 56 5F F6 00 40 20 00 33 00 01 00 00 00 0D 00 01 00 01 00 00 00 01 00 04 00 02 01 00 33 4C 66 80 00 61 F0 20 00 33 4C 66 80 00 61 F0 E0 FF 33 4C 66 80 00 40 1A 20 00 33 4C 66 80 00";
            public const string spiceBottomNTSCJ = "";
            public const string spiceBottomNTSCK = "";
            public const string spiceBottomMar17 = "46 4B 24 5A 69 5F 74 65 6D 70 6C 65 5F 69 6E 74 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 71 01 00 00 FF FF FF FF 46 4B 24 5A 69 5F 74 65 6D 70 6C 65 5F 69 6E 74 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00";
            public const string spiceBottomJul12 = "";

            public const string spiceTopPAL = "25 8E 07 00 DC 4D 79 00 5F 00 03 00 04 00 00 00 02 00 05 00 09 00 00 00 06 00 03 00 00 00 00 00 00 00 7F 66 00 7F 00 00 08 42 CD CC 2C 42 66 86 BC 43 01 01 E5 02 00 00 07 00 03 00 00 00 00 00 8F 01 00 00 FF FF FF FF 25 8E 07 00 DC 4D 79 00 5F 00 03 00 04 00 00 00 02 00 05 00 09 00 00 00 06 00 03 00 00 00 00 00 00 00 7F 66 00 7F 00 00 08 42 CD CC 2C 42 66 86 BC 43 01 01 E5 02 00 00 07 00 03 00 00 00 00 00";
            public const string spiceTopNTSC = "86 37 07 40 56 5F F6 00 40 20 00 33 00 01 00 00 00 0D 00 01 00 01 00 00 00 01 00 04 00 02 01 00 33 4C 66 80 00 61 F0 20 00 33 4C 66 80 00 61 F0 E0 FF 33 4C 66 80 00 40 1A 20 00 33 4C 66 80 00 8F 01 00 00 FF FF FF FF 86 37 07 40 56 5F F6 00 40 20 00 33 00 01 00 00 00 0D 00 01 00 01 00 00 00 01 00 04 00 02 01 00 33 4C 66 80 00 61 F0 20 00 33 4C 66 80 00 61 F0 E0 FF 33 4C 66 80 00 40 1A 20 00 33 4C 66 80 00";
            public const string spiceTopNTSCJ = "";
            public const string spiceTopNTSCK = "";
            public const string spiceTopMar17 = "";
            public const string spiceTopJul12 = "";

            public const string spicePAL = "25 8E 07 00 DC 4D 79 00 5F 00 03 00 04 00 00 00 02 00 05 00 09 00 00 00 06 00 03 00 00 00 00 00 00 00 7F 66 00 7F 00 00 08 42 CD CC 2C 42 66 86 BC 43 01 01 E5 02 00 00 07 00 03 00 00 00 00 00 90 01 00 00 FF FF FF FF 25 8E 07 00 DC 4D 79 00 5F 00 03 00 04 00 00 00 02 00 05 00 09 00 00 00 06 00 03 00 00 00 00 00 00 00 7F 66 00 7F 00 00 08 42 CD CC 2C 42 66 86";
            public const string spiceNTSC = "86 37 07 40 56 5F F6 00 40 20 00 33 00 01 00 00 00 0D 00 01 00 01 00 00 00 01 00 04 00 02 01 00 33 4C 66 80 00 61 F0 20 00 33 4C 66 80 00 61 F0 E0 FF 33 4C 66 80 00 40 1A 20 00 33 4C 66 80 00 90 01 00 00 FF FF FF FF 86 37 07 40 56 5F F6 00 40 20 00 33 00 01 00 00 00 0D 00 01 00 01 00 00 00 01 00 04 00 02 01 00 33 4C 66 80 00 61 F0 20 00 33 4C 66 80 00 61 F0 E0 FF 33 4C 66 80 00 40 1A 20 00 33 4C 66 80 00";
            public const string spiceNTSCJ = "";
            public const string spiceNTSCK = "";
            public const string spiceMar17 = "";
            public const string spiceJul12 = "";

            public const string rajanPAL = "25 8E 07 00 DC 4D 79 00 5F 00 03 00 04 00 00 00 02 00 05 00 09 00 00 00 06 00 03 00 00 00 00 00 00 00 7F 66 00 7F 00 00 08 42 CD CC 2C 42 66 86 BC 43 01 01 E5 02 00 00 07 00 03 00 00 00 00 00 8D 01 00 00 FF FF FF FF 25 8E 07 00 DC 4D 79 00 5F 00 03 00 04 00 00 00 02 00 05 00 09 00 00 00 06 00 03 00 00 00 00 00 00 00 7F 66 00 7F 00 00 08 42 CD CC 2C 42 66 86";
            public const string rajanNTSC = "86 37 07 40 56 5F F6 00 40 20 00 33 00 01 00 00 00 0D 00 01 00 01 00 00 00 01 00 04 00 02 01 00 33 4C 66 80 00 61 F0 20 00 33 4C 66 80 00 61 F0 E0 FF 33 4C 66 80 00 40 1A 20 00 33 4C 66 80 00 8D 01 00 00 FF FF FF FF 86 37 07 40 56 5F F6 00 40 20 00 33 00 01 00 00 00 0D 00 01 00 01 00 00 00 01 00 04 00 02 01 00 33 4C 66 80 00 61 F0 20 00 33 4C 66 80 00 61 F0 E0 FF 33 4C 66 80 00 40 1A 20 00 33 4C 66 80 00";
            public const string rajanNTSCJ = "";
            public const string rajanNTSCK = "";
            public const string rajanMar17 = "";
            public const string rajanJul12 = "";

            public const string praguePAL = "20 BA 07 05 59 01 B1 07 80 03 00 04 04 00 02 00 05 00 03 00 05 00 02 00 01 00 05 00 03 00 DE 6B 0D 43 00 00 C8 42 00 00 00 00 00 00 00 00 02 01 00 07 00 04 00 07 00 05 00 03 00 04 00 05 00 07 89 01 00 00 FF FF FF FF 20 BA 07 05 59 01 B1 07 80 03 00 04 04 00 02 00 05 00 03 00 05 00 02 00 01 00 05 00 03 00 DE 6B 0D 43 00 00 C8 42 00 00 00 00 00 00 00 00 02 01 00 07 00 04 00 07 00 05 00 03 00 04 00 05 00 07";
            public const string pragueNTSC = "88 86 75 61 5E 94 D9 6F E1 74 65 72 67 20 6D 65 72 67 65 73 2E 20 53 6F 72 72 79 2E 20 54 68 69 73 20 74 65 78 74 20 69 73 20 6F 76 65 72 20 32 35 35 20 63 68 61 72 61 63 74 65 72 73 20 74 6F 89 01 00 00 FF FF FF FF 88 86 75 61 5E 94 D9 6F E1 74 65 72 67 20 6D 65 72 67 65 73 2E 20 53 6F 72 72 79 2E 20 54 68 69 73 20 74 65 78 74 20 69 73 20 6F 76 65 72 20 32 35 35 20 63 68 61 72 61 63 74 65 72 73 20 74 6F";
            public const string pragueNTSCJ = "";
            public const string pragueNTSCK = "";
            public const string pragueJul12 = "";

            public const string prisonMurrayPAL = "20 07 08 00 A5 E2 6F 00 83 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03 00 00 FF FF 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 89 01 00 00 FF FF FF FF 20 07 08 00 A5 E2 6F 00 83 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03 00 00 FF FF 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00";
            public const string prisonMurrayNTSC = "5F 31 08 00 13 A2 6C 00 85 00 00 00 00 00 00 FF FF 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 34 3C 01 00 FF FF FF FF 5F 31 08 00 13 A2 6C 00 85 00 00 00 00 00 00 FF FF 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00";
            public const string prisonMurrayNTSCJ = "";
            public const string prisonMurrayNTSCK = "";
            public const string prisonMurrayJul12 = "";

            public const string prisonPAL = "20 07 08 00 A5 E2 6F 00 83 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03 00 00 FF FF 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 34 3C 01 00 FF FF FF FF 20 07 08 00 A5 E2 6F 00 83 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03 00 00 FF FF";
            public const string prisonNTSC = "5F 31 08 00 13 A2 6C 00 85 00 00 00 00 00 00 FF FF 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 2C 2E 01 00 FF FF FF FF 5F 31 08 00 13 A2 6C 00 85 00 00 00 00 00 00 FF FF 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00";
            public const string prisonNTSCJ = "";
            public const string prisonNTSCK = "";
            public const string prisonJul12 = "";

            public const string vaultRoomPAL = "CC 3B 01 03 31 80 3C 00 86 00 FF FF 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 09 03 00 00 FF FF 00 00 00 00 34 2D 01 00 FF FF FF FF CC 3B 01 03 31 80 3C 00 86 00 FF FF 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 09 03 00 00 FF FF 00 00 00 00";
            public const string vaultRoomNTSC = "A0 62 08 00 C2 06 39 00 88 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 09 03 00 00 FF FF 00 00 00 00 00 00 00 00 00 00 00 00 00 00 34 2D 01 00 FF FF FF FF A0 62 08 00 C2 06 39 00 88 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 09 03 00 00 FF FF 00 00 00 00 00 00 00 00 00 00 00 00 00 00";
            public const string vaultRoomNTSCJ = "";
            public const string vaultRoomNTSCK = "";
            public const string vaultRoomJul12 = "";

            public const string prague2PAL = "80 5A 08 0C 0C 78 52 08 72 0A 03 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03 00 00 FF FF 08 89 01 00 00 FF FF FF FF 80 5A 08 0C 0C 78 52 08 72 0A 03 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03 00 00 FF FF 08";
            public const string prague2NTSC = "31 BE 28 26 FB C7 9B 3A 41 4C 26 2E 6C 65 3A 20 26 32 4F 26 2E 0A 58 3A 20 26 32 58 26 2E 0A 52 31 3A 20 26 32 52 26 2E 0A 52 32 3A 20 26 32 72 26 2E 0A 4C 31 3A 20 26 32 4C 26 2E 0A 4C 32 3A 89 01 00 00 FF FF FF FF 31 BE 28 26 FB C7 9B 3A 41 4C 26 2E 6C 65 3A 20 26 32 4F 26 2E 0A 58 3A 20 26 32 58 26 2E 0A 52 31 3A 20 26 32 52 26 2E 0A 52 32 3A 20 26 32 72 26 2E 0A 4C 31 3A 20 26 32 4C 26 2E 0A 4C 32 3A";
            public const string prague2NTSCJ = "";
            public const string prague2NTSCK = "";
            public const string prague2Jul12 = "";

            public const string crypt1PAL = "BF FE 0F 00 E0 9D FF 02 8B FF FF FF DB 25 01 00 00 00 00 06 00 FF FF FF FF 96 02 06 00 D9 25 01 00 01 00 00 00 40 3F 01 00 00 00 C8 41 00 00 00 06 00 FF FF FF FF 06 00 FF FF FF FF 72 02 AA 02 ED EB 00 00 FF FF FF FF BF FE 0F 00 E0 9D FF 02 8B FF FF FF DB 25 01 00 00 00 00 06 00 FF FF FF FF 96 02 06 00 D9 25 01 00 01 00 00 00 40 3F 01 00 00 00 C8 41 00 00 00";
            public const string crypt1NTSC = "60 29 09 06 5F 2A AE 42 76 E7 EA 00 1D 1C 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F D7 7F 17 C5 A2 97 3E 45 50 2F 8E 42 FF 00 00 00 00 02 00 00 00 00 00 00 06 00 E7 EA 00 00 FF FF 42 ED EB 00 00 FF FF FF FF 60 29 09 06 5F 2A AE 42 76 E7 EA 00 1D 1C 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F D7 7F 17 C5 A2 97 3E 45 50 2F 8E 42 FF 00 00 00 00 02 00 00 00 00 00 00 06 00 E7 EA 00 00 FF FF 42";
            public const string crypt1NTSCJ = "";
            public const string crypt1NTSCK = "";
            public const string crypt1Jul12 = "46 4B 24 59 70 5F 63 61 73 74 6C 65 5F 67 75 61 72 64 62 72 65 61 6B 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 C5 8F 00 00 FF FF FF FF 46 4B 24 59 70 5F 63 61 73 74 6C 65 5F 67 75 61 72 64 62 72 65 61 6B 00 00 00 00 00 00 00 00 00";

            public const string crypt2PAL = "05 4D B5 31 5C 8F 91 55 8B 7D 3F 04 EB 00 00 03 00 52 00 00 00 FF FF F5 FE 7D 3F 58 F2 38 BC 42 B6 FE BD 9E E7 50 3C BB F6 7F 3F EC B1 33 3C 20 6C FE 3D 1E 45 4C BC 31 FF 7D 3F 04 CE 10 C4 55 F8 EB 00 00 FF FF FF FF 05 4D B5 31 5C 8F 91 55 8B 7D 3F 04 EB 00 00 03 00 52 00 00 00 FF FF F5 FE 7D 3F 58 F2 38 BC 42 B6 FE BD 9E E7 50 3C BB F6 7F 3F EC B1 33 3C 20 6C FE 3D 1E 45 4C BC 31 FF 7D 3F 04 CE 10 C4 55";
            public const string crypt2NTSC = "A2 29 09 C8 1D D5 51 C8 34 00 00 C8 3F 66 94 7E C5 E7 46 DD 44 7D D6 43 45 FF 00 00 00 0B 03 ED EB 00 00 0C 03 0A 03 00 00 FF FF 08 00 00 00 C8 C2 00 00 C8 C2 00 00 C8 42 00 00 C8 42 00 00 C8 F8 EB 00 00 FF FF FF FF A2 29 09 C8 1D D5 51 C8 34 00 00 C8 3F 66 94 7E C5 E7 46 DD 44 7D D6 43 45 FF 00 00 00 0B 03 ED EB 00 00 0C 03 0A 03 00 00 FF FF 08 00 00 00 C8 C2 00 00 C8 C2 00 00 C8 42 00 00 C8 42 00 00 C8";
            public const string crypt2NTSCJ = "";
            public const string crypt2NTSCK = "";
            public const string crypt2Jul12 = "46 4B 24 59 70 5F 63 61 73 74 6C 65 5F 67 75 61 72 64 62 72 65 61 6B 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 CD 8F 00 00 FF FF FF FF 46 4B 24 59 70 5F 63 61 73 74 6C 65 5F 67 75 61 72 64 62 72 65 61 6B 00 00 00 00 00 00 00 00 00";

            public const string crypt3PAL = "80 9F 9E 02 FC BD 42 00 7C 00 C0 25 00 00 50 10 04 00 00 00 7A 02 06 00 0A 44 00 00 7E 02 06 00 84 F9 00 00 06 00 1A 44 00 00 06 00 1B 44 00 00 00 00 01 00 00 00 96 02 06 00 C0 25 01 00 01 00 A1 83 00 00 FF FF FF FF 80 9F 9E 02 FC BD 42 00 7C 00 C0 25 00 00 50 10 04 00 00 00 7A 02 06 00 0A 44 00 00 7E 02 06 00 84 F9 00 00 06 00 1A 44 00 00 06 00 1B 44 00 00 00 00 01 00 00 00 96 02 06 00 C0 25 01 00 01 00";
            public const string crypt3NTSC = "F2 A7 65 5F FE 47 21 69 0B 61 74 65 8C BC 9E 67 84 3D 37 6D 7F 3F 5D 4F 00 46 6E A4 01 45 E5 03 0D C4 FF 00 00 00 FF FF 18 00 65 6E 74 72 61 6E 63 65 5F 66 72 6F 6D 5F 77 61 74 65 72 72 61 69 A1 83 00 00 FF FF FF FF F2 A7 65 5F FE 47 21 69 0B 61 74 65 8C BC 9E 67 84 3D 37 6D 7F 3F 5D 4F 00 46 6E A4 01 45 E5 03 0D C4 FF 00 00 00 FF FF 18 00 65 6E 74 72 61 6E 63 65 5F 66 72 6F 6D 5F 77 61 74 65 72 72 61 69";
            public const string crypt3NTSCJ = "";
            public const string crypt3NTSCK = "";
            public const string crypt3Jul12 = "";

            public const string ghostPAL = "80 2F 09 00 FB 90 49 02 7D 00 00 00 06 00 D6 24 01 00 FF FF 42 00 00 00 0A F7 00 00 FF 01 10 02 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 02 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 02 A1 83 00 00 FF FF FF FF 80 2F 09 00 FB 90 49 02 7D 00 00 00 06 00 D6 24 01 00 FF FF 42 00 00 00 0A F7 00 00 FF 01 10 02 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 02 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 02";
            public const string ghostNTSC = "9D C7 C8 30 4D 46 05 FF 0A A9 C5 83 00 FF FF 7C 18 24 BF A2 7D 44 BF 00 00 00 00 A2 7D 44 3F 7C 18 24 BF 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 76 BD 90 C1 30 75 A9 C5 83 49 43 43 FF A1 83 00 00 FF FF FF FF 9D C7 C8 30 4D 46 05 FF 0A A9 C5 83 00 FF FF 7C 18 24 BF A2 7D 44 BF 00 00 00 00 A2 7D 44 3F 7C 18 24 BF 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 76 BD 90 C1 30 75 A9 C5 83 49 43 43 FF";
            public const string ghostNTSCJ = "";
            public const string ghostNTSCK = "";
            public const string ghostJul12 = "";

            public const string reeducationPAL = "01 CB 08 00 20 04 6D 81 77 15 38 04 80 9F 82 98 D2 04 00 00 1F 92 1F 95 0A 00 00 00 15 07 00 00 00 9F 87 9F 99 6F 00 00 00 9F 99 70 00 00 00 95 52 0A 00 00 21 00 00 00 00 15 38 04 00 00 1F 81 A1 83 00 00 FF FF FF FF 01 CB 08 00 20 04 6D 81 77 15 38 04 80 9F 82 98 D2 04 00 00 1F 92 1F 95 0A 00 00 00 15 07 00 00 00 9F 87 9F 99 6F 00 00 00 9F 99 70 00 00 00 95 52 0A 00 00 21 00 00 00 00 15 38 04 00 00 1F 81";
            public const string reeducationNTSC = "3F 0C C1 46 65 5D 6E 00 19 3F 6A DE 00 00 00 FF FF 14 00 65 6E 74 72 61 6E 63 65 5F 72 65 63 6F 6E 5F 72 65 74 72 79 00 18 00 8D EB 00 00 02 00 C0 01 00 00 FF FF C9 46 60 3F 6A DE F6 3E 00 00 A1 83 00 00 FF FF FF FF 3F 0C C1 46 65 5D 6E 00 19 3F 6A DE 00 00 00 FF FF 14 00 65 6E 74 72 61 6E 63 65 5F 72 65 63 6F 6E 5F 72 65 74 72 79 00 18 00 8D EB 00 00 02 00 C0 01 00 00 FF FF C9 46 60 3F 6A DE F6 3E 00 00";
            public const string reeducationNTSCJ = "";
            public const string reeducationNTSCK = "";
            public const string reeducationJul12 = "46 4B 24 59 70 5F 63 61 73 74 6C 65 5F 68 65 69 73 74 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 E8 24 00 00 FF FF FF FF 46 4B 24 59 70 5F 63 61 73 74 6C 65 5F 68 65 69 73 74 00 00 00 00 00 00 00 00 00 00 00 00 00 00";

            public const string cryptHackPAL = "20 43 A7 C3 DF 04 72 00 94 13 D6 C3 87 C6 7E BF 6F 06 8F BD 83 E6 8B 3D 23 11 8E 3D 59 5F 7F BF F9 BC 16 BC 95 DF 8C 3D 55 C2 90 BB 22 64 7F 3F EB 10 88 C5 00 88 AF C3 E3 13 D6 C3 FF 00 00 00 1B EC 00 00 FF FF FF FF 20 43 A7 C3 DF 04 72 00 94 13 D6 C3 87 C6 7E BF 6F 06 8F BD 83 E6 8B 3D 23 11 8E 3D 59 5F 7F BF F9 BC 16 BC 95 DF 8C 3D 55 C2 90 BB 22 64 7F 3F";
            public const string cryptHackNTSC = "03 0C 08 00 93 63 6E 00 79 00 02 00 BD 83 E6 8B 3D 23 11 8E 3D 59 5F 7F BF F9 BC 16 BC 95 DF 8C 3D 55 C2 90 BB 22 64 7F 3F EB 10 88 C5 00 88 AF C3 E3 13 D6 C3 FF 00 00 00 00 02 00 00 00 00 00 1B EC 00 00 FF FF FF FF 03 0C 08 00 93 63 6E 00 79 00 02 00 BD 83 E6 8B 3D 23 11 8E 3D 59 5F 7F BF F9 BC 16 BC 95 DF 8C 3D 55 C2 90 BB 22 64 7F 3F EB 10 88 C5 00 88 AF C3 E3 13 D6 C3 FF 00 00 00 00 02 00 00 00 00 00";
            public const string cryptHackNTSCJ = "";
            public const string cryptHackNTSCK = "";
            public const string cryptHackJul12 = "46 4B 24 59 70 5F 63 61 73 74 6C 65 5F 68 65 69 73 74 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 40 90 00 00 FF FF FF FF 46 4B 24 59 70 5F 63 61 73 74 6C 65 5F 68 65 69 73 74 00 00 00 00 00 00 00 00 00 00 00 00 00 00";

            public const string cryptMojo1PAL = "20 79 E0 00 7F 72 B8 FF 6B 01 43 01 00 00 00 10 00 01 00 40 00 00 00 01 00 75 12 00 00 01 00 00 00 20 00 20 00 14 02 02 00 00 02 00 00 80 00 00 00 00 00 01 00 25 E9 00 00 01 43 01 00 FF FF FF A1 83 00 00 FF FF FF FF 20 79 E0 00 7F 72 B8 FF 6B 01 43 01 00 00 00 10 00 01 00 40 00 00 00 01 00 75 12 00 00 01 00 00 00 20 00 20 00 14 02 02 00 00 02 00 00 80 00 00";
            public const string cryptMojo1NTSC = "9F 7C 4B 00 60 00 BB FF 6D 00 49 E7 FF 00 00 00 FF FF 19 00 65 6E 74 72 61 6E 63 65 5F 66 72 6F 6D 5F 65 77 6F 6B 74 72 61 69 6E 65 72 00 06 00 92 24 01 00 FF FF 42 00 00 00 49 E7 00 00 FF FF A1 83 00 00 FF FF FF FF 9F 7C 4B 00 60 00 BB FF 6D 00 49 E7 FF 00 00 00 FF FF 19 00 65 6E 74 72 61 6E 63 65 5F 66 72 6F 6D 5F 65 77 6F 6B 74 72 61 69 6E 65 72 00 06 00 92 24 01 00 FF FF 42 00 00 00 49 E7 00 00 FF FF";
            public const string cryptMojo1NTSCJ = "";
            public const string cryptMojo1NTSCK = "";
            public const string cryptMojo1Jul12 = "";

            public const string cryptMojo2PAL = "60 ED 67 74 96 9D 22 72 17 61 6E 63 BF 1D 95 67 BD DE FA 82 B4 FF 33 81 B4 54 54 8C B3 00 00 80 3F B3 6E 97 C5 E2 BC 81 45 C4 5E B5 44 FF 00 00 00 FF FF 16 00 65 6E 74 72 61 6E 63 65 5F 66 72 A1 83 00 00 FF FF FF FF 60 ED 67 74 96 9D 22 72 17 61 6E 63 BF 1D 95 67 BD DE FA 82 B4 FF 33 81 B4 54 54 8C B3 00 00 80 3F B3 6E 97 C5 E2 BC 81 45 C4 5E B5 44 FF 00 00";
            public const string cryptMojo2NTSC = "5F 2A 92 41 C1 35 41 00 E2 EB 2D 43 41 00 00 00 06 00 FF FF FF FF 06 00 FF FF FF FF 72 02 AA 02 02 00 3D C6 86 C5 D7 83 81 45 D7 B3 D0 44 02 00 00 00 00 00 1F 85 9B 41 85 EB 2D 43 01 00 00 00 A1 83 00 00 FF FF FF FF 5F 2A 92 41 C1 35 41 00 E2 EB 2D 43 41 00 00 00 06 00 FF FF FF FF 06 00 FF FF FF FF 72 02 AA 02 02 00 3D C6 86 C5 D7 83 81 45 D7 B3 D0 44 02 00 00 00 00 00 1F 85 9B 41 85 EB 2D 43 01 00 00 00";
            public const string cryptMojo2NTSCJ = "";
            public const string cryptMojo2NTSCK = "";
            public const string cryptMojo2Jul12 = "";

            public const string cryptMojo3PAL = "40 B4 F6 FF 00 3A C8 BF BD 16 05 35 B2 65 B4 02 35 94 B4 00 00 80 3F C5 10 97 C5 23 5B 6E 45 DC B5 A6 44 FF 00 00 00 FF FF 00 03 00 6F 24 01 00 FF FF 38 00 00 00 FF FF D5 16 05 35 00 00 80 BF A1 83 00 00 FF FF FF FF 40 B4 F6 FF 00 3A C8 BF BD 16 05 35 B2 65 B4 02 35 94 B4 00 00 80 3F C5 10 97 C5 23 5B 6E 45 DC B5 A6 44 FF 00 00 00 FF FF 00 03 00 6F 24 01 00";
            public const string cryptMojo3NTSC = "C0 DA 09 00 5C AB 44 FF 6A 06 00 D4 3F BB 6B 4C 3F 8C EA 5D 3A 56 FB DA BC A9 66 9C 3C A2 DC 7F 3F 15 09 3E C1 33 1F AA C5 00 00 C0 C3 FF 00 00 00 00 02 00 00 00 00 00 00 06 00 D4 EB 00 00 FF A1 83 00 00 FF FF FF FF C0 DA 09 00 5C AB 44 FF 6A 06 00 D4 3F BB 6B 4C 3F 8C EA 5D 3A 56 FB DA BC A9 66 9C 3C A2 DC 7F 3F 15 09 3E C1 33 1F AA C5 00 00 C0 C3 FF 00 00 00 00 02 00 00 00 00 00 00 06 00 D4 EB 00 00 FF";
            public const string cryptMojo3NTSCJ = "";
            public const string cryptMojo3NTSCK = "";
            public const string cryptMojo3Jul12 = "";

            public const string cryptMojo4PAL = "3F D8 09 00 38 88 7D 6C 6E FF FF 8C 00 3C D9 9A BD BD 34 3C BE BA 78 E6 7E 3F 3A C7 9C 43 70 41 24 C2 1A 69 2F C4 FF 00 00 00 FF FF 00 03 00 49 24 01 00 FF FF 38 00 00 00 FF FF 8C 49 7E 3F 6C A1 83 00 00 FF FF FF FF 3F D8 09 00 38 88 7D 6C 6E FF FF 8C 00 3C D9 9A BD BD 34 3C BE BA 78 E6 7E 3F 3A C7 9C 43 70 41 24 C2 1A 69 2F C4 FF 00 00 00 FF FF 00 03 00 49";
            public const string cryptMojo4NTSC = "FF 07 0A 00 9F 67 39 00 70 C8 41 00 00 00 71 02 06 00 FF FF FF FF 87 02 06 00 49 24 01 00 00 00 00 06 00 FF FF FF FF 96 02 06 00 47 24 01 00 01 00 00 00 40 3F 01 00 00 00 C8 41 00 00 00 06 00 A1 83 00 00 FF FF FF FF FF 07 0A 00 9F 67 39 00 70 C8 41 00 00 00 71 02 06 00 FF FF FF FF 87 02 06 00 49 24 01 00 00 00 00 06 00 FF FF FF FF 96 02 06 00 47 24 01 00 01 00 00 00 40 3F 01 00 00 00 C8 41 00 00 00 06 00";
            public const string cryptMojo4NTSCJ = "";
            public const string cryptMojo4NTSCK = "";
            public const string cryptMojo4Jul12 = "";

            public const string canadaPAL = "60 F3 F5 08 E1 97 97 C8 34 00 00 C8 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03 00 00 FF FF 08 00 00 00 C8 C2 00 00 C8 89 01 00 00 FF FF FF FF 60 F3 F5 08 E1 97 97 C8 34 00 00 C8 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03 00 00 FF FF 08 00 00 00 C8 C2 00 00 C8";
            public const string canadaNTSC = "6E 55 2A 6D 90 A7 B4 53 53 72 67 65 6F 20 74 72 65 61 74 20 74 68 69 73 20 63 6F 6C 75 6D 6E 20 61 73 20 61 20 6D 65 6D 6F 20 66 69 65 6C 64 20 64 75 72 69 6E 67 20 6D 65 72 67 65 73 2E 20 53 89 01 00 00 FF FF FF FF 6E 55 2A 6D 90 A7 B4 53 53 72 67 65 6F 20 74 72 65 61 74 20 74 68 69 73 20 63 6F 6C 75 6D 6E 20 61 73 20 61 20 6D 65 6D 6F 20 66 69 65 6C 64 20 64 75 72 69 6E 67 20 6D 65 72 67 65 73 2E 20 53";
            public const string canadaNTSCJ = "";
            public const string canadaNTSCK = "";
            public const string canadaJul12 = "";

            public const string cabin1PAL = "A0 4B C2 C2 BC 53 99 C2 31 00 C8 42 00 00 00 00 FF 00 00 00 0B 03 28 C2 00 00 0C 03 0A 03 00 00 FF FF 08 00 00 00 C8 C2 00 00 C8 C2 00 00 C8 42 00 00 C8 42 00 00 C8 C2 00 00 C8 42 00 00 C8 C2 1B C2 00 00 FF FF FF FF A0 4B C2 C2 BC 53 99 C2 31 00 C8 42 00 00 00 00 FF 00 00 00 0B 03 28 C2 00 00 0C 03 0A 03 00 00 FF FF 08 00 00 00 C8 C2 00 00 C8 C2 00 00 C8 42";
            public const string cabin1NTSC = "E1 70 08 00 23 15 4F 00 33 00 05 00 42 00 00 C8 C2 00 00 C8 C2 06 00 0C 00 00 00 01 00 03 00 DE 6B 0D 43 00 00 00 00 00 00 00 00 00 00 C8 42 04 03 00 02 00 01 00 02 00 00 00 05 00 00 00 01 00 1B C2 00 00 FF FF FF FF E1 70 08 00 23 15 4F 00 33 00 05 00 42 00 00 C8 C2 00 00 C8 C2 06 00 0C 00 00 00 01 00 03 00 DE 6B 0D 43 00 00 00 00 00 00 00 00 00 00 C8 42 04 03 00 02 00 01 00 02 00 00 00 05 00 00 00 01 00";
            public const string cabin1NTSCJ = "";
            public const string cabin1NTSCK = "";
            public const string cabin1Jul12 = "46 4B 24 59 63 5F 74 72 61 69 6E 5F 63 61 62 69 6E 73 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 8B 69 00 00 FF FF FF FF 46 4B 24 59 63 5F 74 72 61 69 6E 5F 63 61 62 69 6E 73 00 00 00 00 00 00 00 00 00 00 00 00 00 00";

            public const string cabin2PAL = "A2 4D 0A 69 BC 49 15 00 A8 00 00 06 00 CD CC CC 3E 06 00 FF FF FF FF 06 00 FF FF FF FF 8E 02 06 00 FF FF FF FF 06 00 FF FF FF FF 7D 02 06 00 A3 CF 00 00 7E 02 06 00 69 99 00 00 06 00 1A 44 00 28 C2 00 00 FF FF FF FF A2 4D 0A 69 BC 49 15 00 A8 00 00 06 00 CD CC CC 3E 06 00 FF FF FF FF 06 00 FF FF FF FF 8E 02 06 00 FF FF FF FF 06 00 FF FF FF FF 7D 02 06 00 A3 CF 00 00 7E 02 06 00 69 99 00 00 06 00 1A 44 00";
            public const string cabin2NTSC = "E0 71 0F 00 DC EA 4A 00 33 00 02 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F A6 10 3E C6 95 92 66 C5 85 1F F4 44 FF 00 00 00 01 05 00 00 00 02 00 FF FF 04 00 28 C2 00 00 FF FF FF FF E0 71 0F 00 DC EA 4A 00 33 00 02 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F A6 10 3E C6 95 92 66 C5 85 1F F4 44 FF 00 00 00 01 05 00 00 00 02 00 FF FF 04 00";
            public const string cabin2NTSCJ = "";
            public const string cabin2NTSCK = "";
            public const string cabin2Jul12 = "46 4B 24 59 63 5F 74 72 61 69 6E 5F 63 61 62 69 6E 73 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 93 69 00 00 FF FF FF FF 46 4B 24 59 63 5F 74 72 61 69 6E 5F 63 61 62 69 6E 73 00 00 00 00 00 00 00 00 00 00 00 00 00 00";

            public const string cabin3PAL = "A0 49 0A 02 BC 8D 3A 0D 31 03 00 05 03 00 DE 6B 0D 43 17 B7 D1 B9 17 B7 D1 B8 00 00 C8 42 04 03 00 02 00 01 00 02 00 00 00 05 00 00 00 01 00 04 00 01 00 03 00 02 00 02 00 03 00 05 00 DE 6B 0D 2F C2 00 00 FF FF FF FF A0 49 0A 02 BC 8D 3A 0D 31 03 00 05 03 00 DE 6B 0D 43 17 B7 D1 B9 17 B7 D1 B8 00 00 C8 42 04 03 00 02 00 01 00 02 00 00 00 05 00 00 00 01 00 04";
            public const string cabin3NTSC = "58 70 0A 00 24 15 4A 00 33 02 01 00 00 00 00 00 03 05 00 04 00 03 00 04 00 02 00 05 00 03 00 05 00 02 00 01 00 05 00 03 00 DE 6B 0D 43 CC FF C7 42 17 B7 D1 B8 00 00 00 00 02 01 00 07 00 04 00 2F C2 00 00 FF FF FF FF 58 70 0A 00 24 15 4A 00 33 02 01 00 00 00 00 00 03 05 00 04 00 03 00 04 00 02 00 05 00 03 00 05 00 02 00 01 00 05 00 03 00 DE 6B 0D 43 CC FF C7 42 17 B7 D1 B8 00 00 00 00 02 01 00 07 00 04 00";
            public const string cabin3NTSCJ = "";
            public const string cabin3NTSCK = "";
            public const string cabin3Jul12 = "46 4B 24 59 63 5F 74 72 61 69 6E 5F 63 61 62 69 6E 73 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 98 69 00 00 FF FF FF FF 46 4B 24 59 63 5F 74 72 61 69 6E 5F 63 61 62 69 6E 73 00 00 00 00 00 00 00 00 00 00 00 00 00 00";

            public const string trainAerialPAL = "D0 45 CC 6D C3 77 65 99 13 EE 40 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F D0 54 0F C7 E0 70 3D C6 6D 38 EE 40 00 00 06 00 99 6B C2 00 00 FF FF FF FF D0 45 CC 6D C3 77 65 99 13 EE 40 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F D0";
            public const string trainAerialNTSC = "29 BE 48 01 B3 4E 62 20 2D 06 00 F1 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 50 60 A6 43 E8 F7 6B 40 1C A9 23 42 01 00 06 00 F1 B9 00 00 20 6B C2 00 00 FF FF FF FF 29 BE 48 01 B3 4E 62 20 2D 06 00 F1 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 50 60 A6 43 E8 F7 6B 40 1C A9 23 42 01 00 06 00 F1 B9 00 00 20";
            public const string trainAerialNTSCJ = "";
            public const string trainAerialNTSCK = "";
            public const string trainAerialJul12 = "46 4B 24 59 63 5F 74 72 61 69 6E 5F 61 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 C8 69 00 00 FF FF FF FF 46 4B 24 59 63 5F 74 72 61 69 6E 5F 61 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00";

            public const string trainTheftPAL = "E3 DE F2 9E 00 17 EE D9 E8 4D DA D7 C3 66 8B D9 43 A6 F8 9E 43 4D DA D7 43 66 8B D9 43 A6 F8 9E 43 4D DA D7 C3 66 8B D9 43 A6 F8 9E C3 4D DA D7 43 66 8B D9 43 A6 F8 9E C3 4D DA D7 C3 66 8B D9 89 01 00 00 FF FF FF FF E3 DE F2 9E 00 17 EE D9 E8 4D DA D7 C3 66 8B D9 43 A6 F8 9E 43 4D DA D7 43 66 8B D9 43 A6 F8 9E 43 4D DA D7 C3 66 8B D9 43 A6 F8 9E C3 4D DA D7";
            public const string trainTheftNTSC = "E1 39 4E FF F5 4E 7A 00 2D 00 00 FF 0F A1 B4 00 00 00 00 AD B8 9F 34 CC DE 7D BF 67 CF 03 BE 06 DB 25 33 67 CF 03 BE CC DE 7D 3F D8 AD 9A C1 23 22 08 C3 DC 61 A4 44 FF 00 00 00 FF FF 00 18 00 89 01 00 00 FF FF FF FF E1 39 4E FF F5 4E 7A 00 2D 00 00 FF 0F A1 B4 00 00 00 00 AD B8 9F 34 CC DE 7D BF 67 CF 03 BE 06 DB 25 33 67 CF 03 BE CC DE 7D 3F D8 AD 9A C1 23 22 08 C3 DC 61 A4 44 FF 00 00 00 FF FF 00 18 00";
            public const string trainTheftNTSCJ = "";
            public const string trainTheftNTSCK = "";
            public const string trainTheftJul12 = "46 4B 24 59 63 5F 74 72 61 69 6E 5F 61 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 93 01 00 00 FF FF FF FF 46 4B 24 59 63 5F 74 72 61 69 6E 5F 61 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00";

            public const string trainRidePAL = "AB 17 C9 A6 D6 5F 21 66 D7 9E 43 4D 00 00 00 00 00 00 00 80 3F 51 5C 48 C5 5A B3 EF 45 67 6C C7 C1 FF 00 00 00 B0 01 E0 C1 00 00 FF FF 08 00 4D DA D7 C3 66 8B D9 C3 A6 F8 9E 43 4D DA D7 43 66 89 01 00 00 FF FF FF FF AB 17 C9 A6 D6 5F 21 66 D7 9E 43 4D 00 00 00 00 00 00 00 80 3F 51 5C 48 C5 5A B3 EF 45 67 6C C7 C1 FF 00 00 00 B0 01 E0 C1 00 00 FF FF 08 00 4D";
            public const string trainRideNTSC = "41 F2 09 00 16 79 5B 00 31 00 FF FF 00 00 00 00 00 00 00 00 06 00 00 00 06 00 00 00 00 00 00 00 00 00 01 00 00 00 FF FF FF FF 03 00 02 00 00 00 FF FF FF FF 01 00 03 00 00 00 FF FF FF FF 04 00 89 01 00 00 FF FF FF FF 41 F2 09 00 16 79 5B 00 31 00 FF FF 00 00 00 00 00 00 00 00 06 00 00 00 06 00 00 00 00 00 00 00 00 00 01 00 00 00 FF FF FF FF 03 00 02 00 00 00 FF FF FF FF 01 00 03 00 00 00 FF FF FF FF 04 00";
            public const string trainRideNTSCJ = "";
            public const string trainRideNTSCK = "";
            public const string trainRideJul12 = "46 4B 24 59 63 5F 74 72 61 69 6E 5F 63 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 93 01 00 00 FF FF FF FF 46 4B 24 59 63 5F 74 72 61 69 6E 5F 63 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00";

            public const string trainOPPAL = "60 99 0A 00 A4 29 6F 00 2C 00 00 01 00 00 00 00 00 00 AB 02 02 00 C3 15 94 43 66 61 13 C6 9A 59 9B 43 02 00 00 00 00 00 F6 28 44 41 48 E1 02 C3 01 00 00 00 00 3F 00 00 01 00 00 01 BA 02 06 00 89 01 00 00 FF FF FF FF 60 99 0A 00 A4 29 6F 00 2C 00 00 01 00 00 00 00 00 00 AB 02 02 00 C3 15 94 43 66 61 13 C6 9A 59 9B 43 02 00 00 00 00 00 F6 28 44 41 48 E1 02 C3 01 00 00 00 00 3F 00 00 01 00 00 01 BA 02 06 00";
            public const string trainOPNTSC = "E0 CA 6C 10 62 11 67 B9 10 00 00 00 01 00 00 00 00 00 00 00 01 78 02 06 00 07 00 00 00 87 02 06 00 9B C2 00 00 00 00 00 06 00 07 00 00 00 B9 02 06 00 07 00 00 00 66 10 3F 00 00 00 00 00 01 B9 89 01 00 00 FF FF FF FF E0 CA 6C 10 62 11 67 B9 10 00 00 00 01 00 00 00 00 00 00 00 01 78 02 06 00 07 00 00 00 87 02 06 00 9B C2 00 00 00 00 00 06 00 07 00 00 00 B9 02 06 00 07 00 00 00 66 10 3F 00 00 00 00 00 01 B9";
            public const string trainOPNTSCJ = "";
            public const string trainOPNTSCK = "";
            public const string trainOPJul12 = "46 4B 24 59 63 5F 74 72 61 69 6E 5F 62 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 93 01 00 00 FF FF FF FF 46 4B 24 59 63 5F 74 72 61 69 6E 5F 62 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00";

            public const string canada2PAL = "00 F5 F5 FF CA C3 AB 00 DD FF 03 00 00 06 00 00 00 02 00 DE 6B 0D 43 00 00 C8 C2 00 00 00 00 00 00 00 00 00 06 00 00 00 06 00 00 00 00 00 00 00 00 00 01 00 00 00 FF FF FF FF 03 00 02 00 00 00 89 01 00 00 FF FF FF FF 00 F5 F5 FF CA C3 AB 00 DD FF 03 00 00 06 00 00 00 02 00 DE 6B 0D 43 00 00 C8 C2 00 00 00 00 00 00 00 00 00 06 00 00 00 06 00 00 00 00 00 00 00 00 00 01 00 00 00 FF FF FF FF 03 00 02 00 00 00";
            public const string canada2NTSC = "A1 6A 6A 63 7A 24 C8 20 50 65 72 73 20 6D 65 72 67 65 73 2E 20 53 6F 72 72 79 2E 20 54 68 69 73 20 74 65 78 74 20 69 73 20 6F 76 65 72 20 32 35 35 20 63 68 61 72 61 63 74 65 72 73 20 74 6F 20 89 01 00 00 FF FF FF FF A1 6A 6A 63 7A 24 C8 20 50 65 72 73 20 6D 65 72 67 65 73 2E 20 53 6F 72 72 79 2E 20 54 68 69 73 20 74 65 78 74 20 69 73 20 6F 76 65 72 20 32 35 35 20 63 68 61 72 61 63 74 65 72 73 20 74 6F 20";
            public const string canada2NTSCJ = "";
            public const string canada2NTSCK = "";
            public const string canada2Jul12 = "";

            public const string RCPAL = "20 C0 0B 00 D8 A9 4C FF 28 0C 03 0A 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03 00 00 FF 89 01 00 00 FF FF FF FF 20 C0 0B 00 D8 A9 4C FF 28 0C 03 0A 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03 00 00 FF";
            public const string RCNTSC = "60 62 0B 00 E4 0F 77 00 2A 00 00 00 00 1A 00 C7 0B 00 00 FF FF 91 00 00 00 FF FF 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 89 01 00 00 FF FF FF FF 60 62 0B 00 E4 0F 77 00 2A 00 00 00 00 1A 00 C7 0B 00 00 FF FF 91 00 00 00 FF FF 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00";
            public const string RCNTSCJ = "";
            public const string RCNTSCK = "";
            public const string RCJul12 = "46 4B 24 59 63 5F 73 61 77 6D 69 6C 6C 5F 6D 75 6C 63 68 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 93 01 00 00 FF FF FF FF 46 4B 24 59 63 5F 73 61 77 6D 69 6C 6C 5F 6D 75 6C 63 68 00 00 00 00 00 00 00 00 00 00 00 00 00";

            public const string sawmillPAL = "E0 6F F4 FF 53 AE 51 00 1F 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03 00 00 FF FF 00 00 00 00 00 00 00 00 89 01 00 00 FF FF FF FF E0 6F F4 FF 53 AE 51 00 1F 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03 00 00 FF FF 00 00 00 00 00 00 00 00";
            public const string sawmillNTSC = "A0 92 0B 00 D5 6D 4D 00 21 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 89 01 00 00 FF FF FF FF A0 92 0B 00 D5 6D 4D 00 21 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00";
            public const string sawmillNTSCJ = "";
            public const string sawmillNTSCK = "";
            public const string sawmillJul12 = "46 4B 24 59 63 5F 73 61 77 6D 69 6C 6C 5F 62 75 72 6E 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 93 01 00 00 FF FF FF FF 46 4B 24 59 63 5F 73 61 77 6D 69 6C 6C 5F 62 75 72 6E 00 00 00 00 00 00 00 00 00 00 00 00 00 00";

            public const string lighthousePAL = "DF 9D 28 00 B9 02 07 00 83 82 00 00 00 B8 02 56 C6 F6 18 8C C5 F6 44 5A 45 02 00 00 00 00 00 66 66 80 41 8F 42 AF 42 01 00 00 00 80 3F 00 00 01 00 00 01 FF FF 00 23 00 A6 82 00 00 FF FF 48 00 D6 82 00 00 FF FF FF FF DF 9D 28 00 B9 02 07 00 83 82 00 00 00 B8 02 56 C6 F6 18 8C C5 F6 44 5A 45 02 00 00 00 00 00 66 66 80 41 8F 42 AF 42 01 00 00 00 80 3F 00 00 01 00 00 01 FF FF 00 23 00 A6 82 00 00 FF FF 48 00";
            public const string lighthouseNTSC = "60 40 F4 FF 38 4A 5D BF DD F3 4E 3F 00 FF FF 13 00 65 6E 74 72 61 6E 63 65 5F 6C 69 67 68 74 68 6F 75 73 65 00 06 00 13 84 00 00 FF FF 42 00 00 00 BF 69 00 00 FF FF FF FA F3 4E 3F C3 AF 16 BF D6 82 00 00 FF FF FF FF 60 40 F4 FF 38 4A 5D BF DD F3 4E 3F 00 FF FF 13 00 65 6E 74 72 61 6E 63 65 5F 6C 69 67 68 74 68 6F 75 73 65 00 06 00 13 84 00 00 FF FF 42 00 00 00 BF 69 00 00 FF FF FF FA F3 4E 3F C3 AF 16 BF";
            public const string lighthouseNTSCJ = "";
            public const string lighthouseNTSCK = "";
            public const string lighthouseJul12 = "46 4B 24 59 63 5F 73 61 77 6D 69 6C 6C 5F 6C 69 67 68 74 68 6F 75 73 65 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 DC 24 00 00 FF FF FF FF 46 4B 24 59 63 5F 73 61 77 6D 69 6C 6C 5F 6C 69 67 68 74 68 6F 75 73 65 00 00 00 00 00 00 00 00";

            public const string bearPAL = "40 CA F4 FF F6 BD 3C 00 19 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03 00 00 FF FF 00 00 00 00 00 00 00 00 A1 83 00 00 FF FF FF FF 40 CA F4 FF F6 BD 3C 00 19 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03 00 00 FF FF 00 00 00 00 00 00 00 00";
            public const string bearNTSC = "00 EC 0B 00 56 BE 3B 0A 1B FF 00 00 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A A1 83 00 00 FF FF FF FF 00 EC 0B 00 56 BE 3B 0A 1B FF 00 00 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A";
            public const string bearNTSCJ = "";
            public const string bearNTSCK = "";
            public const string bearJul12 = "46 4B 24 59 63 5F 73 61 77 6D 69 6C 6C 5F 62 65 61 72 63 61 76 65 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 E8 24 00 00 FF FF FF FF 46 4B 24 59 63 5F 73 61 77 6D 69 6C 6C 5F 62 65 61 72 63 61 76 65 00 00 00 00 00 00 00 00 00 00";

            public const string sawmillBossPAL = "C0 F4 0B 00 13 88 45 03 E3 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 09 03 89 01 00 00 FF FF FF FF C0 F4 0B 00 13 88 45 03 E3 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 09 03";
            public const string sawmillBossNTSC = "03 1F 0F 00 33 84 48 00 1E FF FF 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 09 03 00 00 FF FF 00 00 00 00 00 89 01 00 00 FF FF FF FF 03 1F 0F 00 33 84 48 00 1E FF FF 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 09 03 00 00 FF FF 00 00 00 00 00";
            public const string sawmillBossNTSCJ = "";
            public const string sawmillBossNTSCK = "";
            public const string sawmillBossJul12 = "46 4B 24 59 63 5F 73 61 77 6D 69 6C 6C 5F 62 6F 73 73 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 E9 24 00 00 FF FF FF FF 46 4B 24 59 63 5F 73 61 77 6D 69 6C 6C 5F 62 6F 73 73 00 00 00 00 00 00 00 00 00 00 00 00 00 00";

            public const string blimpPAL = "50 27 FD 00 5B 2C 05 02 F8 00 FA 00 8E 00 8F 00 90 00 91 00 92 00 9B 00 A3 00 A5 00 AB 00 AC 00 AD 00 AE 00 AF 00 B0 00 B1 00 B2 00 B3 00 B4 00 B5 00 EF 00 F0 00 F1 00 F5 00 FA 00 6D 02 9D 02 89 01 00 00 FF FF FF FF 50 27 FD 00 5B 2C 05 02 F8 00 FA 00 8E 00 8F 00 90 00 91 00 92 00 9B 00 A3 00 A5 00 AB 00 AC 00 AD 00 AE 00 AF 00 B0 00 B1 00 B2 00 B3 00 B4 00 B5 00 EF 00 F0 00 F1 00 F5 00 FA 00 6D 02 9D 02";
            public const string blimpNTSC = "03 24 69 3A 76 40 9F 58 2F 26 32 4F 74 63 68 03 00 9C 00 53 71 75 61 72 65 3A 20 26 32 53 26 2E 0A 54 72 69 61 6E 67 6C 65 3A 20 26 32 54 26 2E 0A 43 69 72 63 6C 65 3A 20 26 32 4F 26 2E 0A 58 89 01 00 00 FF FF FF FF 03 24 69 3A 76 40 9F 58 2F 26 32 4F 74 63 68 03 00 9C 00 53 71 75 61 72 65 3A 20 26 32 53 26 2E 0A 54 72 69 61 6E 67 6C 65 3A 20 26 32 54 26 2E 0A 43 69 72 63 6C 65 3A 20 26 32 4F 26 2E 0A 58";
            public const string blimpNTSCJ = "";
            public const string blimpNTSCK = "";

            public const string blimpHQPAL = "40 22 0C 00 4C 6F 10 98 10 41 00 00 60 45 02 00 00 00 00 00 0A 00 00 00 00 00 00 00 80 3F 00 00 00 40 00 00 40 40 00 00 80 40 00 00 A0 40 00 00 C0 40 00 00 E0 40 00 00 00 41 00 00 10 41 71 98 45 44 00 00 FF FF FF FF 40 22 0C 00 4C 6F 10 98 10 41 00 00 60 45 02 00 00 00 00 00 0A 00 00 00 00 00 00 00 80 3F 00 00 00 40 00 00 40 40 00 00 80 40 00 00 A0 40 00 00 C0 40 00 00 E0 40 00 00 00 41 00 00 10 41 71 98";
            public const string blimpHQNTSC = "58 88 C8 EE 43 E5 9D F3 C3 6B 43 05 00 A0 40 00 00 C0 40 00 00 E0 40 00 00 00 41 00 00 10 41 71 98 D6 43 1A 7A D6 C3 E7 76 4A C4 63 A7 CF 43 7E E3 AB C3 FD 58 0B C4 EE D1 6B 43 05 37 80 C3 F3 45 44 00 00 FF FF FF FF 58 88 C8 EE 43 E5 9D F3 C3 6B 43 05 00 A0 40 00 00 C0 40 00 00 E0 40 00 00 00 41 00 00 10 41 71 98 D6 43 1A 7A D6 C3 E7 76 4A C4 63 A7 CF 43 7E E3 AB C3 FD 58 0B C4 EE D1 6B 43 05 37 80 C3 F3";
            public const string blimpHQNTSCJ = "";
            public const string blimpHQNTSCK = "";

            public const string engine1PAL = "60 BB 0C 00 C8 26 72 00 0A 00 00 00 00 1A 00 04 0D 00 00 FF FF 91 00 00 00 FF FF 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 89 01 00 00 FF FF FF FF 60 BB 0C 00 C8 26 72 00 0A 00 00 00 00 1A 00 04 0D 00 00 FF FF 91 00 00 00 FF FF 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00";
            public const string engine1NTSC = "00 DB 0C 00 5A 2A 4A 00 0C 00 00 00 FF 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 89 01 00 00 FF FF FF FF 00 DB 0C 00 5A 2A 4A 00 0C 00 00 00 FF 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00";
            public const string engine1NTSCJ = "";
            public const string engine1NTSCK = "";

            public const string engine2PAL = "FF 91 0C 00 D8 B7 BB FF 08 03 0A 03 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03 00 00 FF FF 89 01 00 00 FF FF FF FF FF 91 0C 00 D8 B7 BB FF 08 03 0A 03 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00";
            public const string engine2NTSC = "00 4E F3 00 22 E3 41 00 06 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03 00 00 FF FF 00 00 00 00 00 00 00 00 00 89 01 00 00 FF FF FF FF 00 4E F3 00 22 E3 41 00 06 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 0C 03 0A 03 00 00 FF FF 00 00 00 00 00 00 00 00 00";
            public const string engine2NTSCJ = "";
            public const string engine2NTSCK = "";

            public const string engine3PAL = "60 E7 8C 3F 89 2C 44 00 07 00 00 00 FF FF 91 00 00 00 FF FF 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 89 01 00 00 FF FF FF FF 60 E7 8C 3F 89 2C 44 00 07 00 00 00 FF FF 91 00 00 00 FF FF 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00";
            public const string engine3NTSC = "A0 06 0D 00 05 11 41 00 09 00 00 00 1A 00 02 0D 00 00 FF FF 91 00 00 00 FF FF 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 89 01 00 00 FF FF FF FF A0 06 0D 00 05 11 41 00 09 00 00 00 1A 00 02 0D 00 00 FF FF 91 00 00 00 FF FF 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 00 00";
            public const string engine3NTSCJ = "";
            public const string engine3NTSCK = "";

            public const string parisFinalePAL = "8A 11 46 00 00 5F C0 00 4D 00 4D 00 36 00 37 00 38 00 39 00 3A 00 3B 00 3C 00 3D 00 3E 00 3F 00 40 00 41 00 42 00 43 00 44 00 45 00 46 00 47 00 48 00 49 00 4A 00 4B 00 4C 00 4D 00 4E 00 4F 00 ED 33 00 00 FF FF FF FF 8A 11 46 00 00 5F C0 00 4D 00 4D 00 36 00 37 00 38 00 39 00 3A 00 3B 00 3C 00 3D 00 3E 00 3F 00 40 00 41 00 42 00 43 00 44 00 45 00 46 00 47 00 48 00 49 00 4A 00 4B 00 4C 00 4D 00 4E 00 4F 00";
            public const string parisFinaleNTSC = "CF 46 68 72 2C E5 E4 61 23 32 35 35 69 65 6C 64 20 64 75 72 69 6E 67 20 6D 65 72 67 65 73 2E 20 53 6F 72 72 79 2E 20 54 68 69 73 20 74 65 78 74 20 69 73 20 6F 76 65 72 20 32 35 35 20 63 68 61 ED 33 00 00 FF FF FF FF CF 46 68 72 2C E5 E4 61 23 32 35 35 69 65 6C 64 20 64 75 72 69 6E 67 20 6D 65 72 67 65 73 2E 20 53 6F 72 72 79 2E 20 54 68 69 73 20 74 65 78 74 20 69 73 20 6F 76 65 72 20 32 35 35 20 63 68 61";
            public const string parisFinaleNTSCJ = "";
            public const string parisFinaleNTSCK = "";
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
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

            while (true)
            {
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

                    if (gameCRC == Sly2CRC.Sly2PAL)
                    {
                        currentGame.Invoke((MethodInvoker)delegate
                        {
                            currentGame.Text = "Sly 2: Band of Thieves (PAL) " + "[" + gameCRC + "]";
                            currentGame.ForeColor = Color.Green;

                            gameClock = clockPAL;

                            slyGadget = botSlyGadgetPAL;
                            bentleyGadget = botBentleyGadgetPAL;
                            murrayGadget = botMurrayGadgetPAL;

                            unlockGadgets1 = botUnlockGadgets1PAL;
                            unlockGadgets2 = botUnlockGadgets2PAL;

                            disableGuardAI = botDisableGuardAIPAL;

                            resetCam = botResetCamPAL;

                            charIDAddr = botCharIDPAL;
                            actStructBase = botActBasePAL;
                            slyStructBase = botSlyBasePAL;
                            bentleyStructBase = botBentleyBasePAL;
                            murrayStructBase = botMurrayBasePAL;
                            neylaStructBase = botNeylaBasePAL;
                            dimitriStructBase = botDimitriBasePAL;
                            carmStructBase = botCarmBasePAL;

                            gangHPGUI = botGangHPGUIPAL;
                            coinGUI = botCoinGUIPAL;
                            bottleGUI = botBottleGUIPAL;
                            ejectGUI = botEjectGUIPAL;
                            blackbarsGUI = botBlackbarsGUIPAL;
                            infoboxGUI = botInfoboxGUIPAL;
                            slymaskGUI = botSlyMaskGUIPAL;
                            failGUI = botFailGUIPAL;
                            //thiefNetGUI = botThiefNetGUIPAL;

                            slyHP = botSlyHPPAL;
                            bentleyHP = botBentleyHPPAL;
                            murrayHP = botMurrayHPPAL;

                            reloadAOB = botReloadAOBPAL;
                            reloadFunc = botReloadFuncPAL;
                            mapID = botMapIDPAL;

                            mapCairo = LevelAOB.cairoPAL; //Maps
                            mapMenu = LevelAOB.menuPAL;
                            mapParis = LevelAOB.parisPAL;
                            mapWineDoor = LevelAOB.wineDoorPAL;
                            mapWineLasers = LevelAOB.wineLasersPAL;
                            mapDiscoBackdoor = LevelAOB.discoBackdoorPAL;
                            mapDiscoWindow = LevelAOB.discoWindowPAL;
                            mapPrintRecon = LevelAOB.printReconPAL;
                            mapPrintBoss = LevelAOB.printBossPAL;
                            mapTheater = LevelAOB.theaterPAL;
                            mapWaterPump = LevelAOB.waterPumpPAL;
                            mapIndia = LevelAOB.indiaPAL;
                            mapHotelFront = LevelAOB.hotelFrontPAL;
                            mapHotelEnt2 = LevelAOB.hotelEnt2PAL;
                            mapHotelEnt3 = LevelAOB.hotelEnt3PAL;
                            mapHotelEnt4 = LevelAOB.hotelEnt4PAL;
                            mapBasement = LevelAOB.basementPAL;
                            mapBalls = LevelAOB.ballsPAL;
                            mapIndia2 = LevelAOB.india2PAL;
                            mapSpiceBottom = LevelAOB.spiceBottomPAL;
                            mapSpiceTop = LevelAOB.spiceTopPAL;
                            mapSpice = LevelAOB.spicePAL;
                            mapRajan = LevelAOB.rajanPAL;
                            mapPrague2 = LevelAOB.prague2PAL;
                            mapCrypt1 = LevelAOB.crypt1PAL;
                            mapCrypt2 = LevelAOB.crypt2PAL;
                            mapCrypt3 = LevelAOB.crypt3PAL;
                            mapGhost = LevelAOB.ghostPAL;
                            mapReeducation = LevelAOB.reeducationPAL;
                            mapCryptHack = LevelAOB.cryptHackPAL;
                            mapCryptMojo1 = LevelAOB.cryptMojo1PAL;
                            mapCryptMojo2 = LevelAOB.cryptMojo2PAL;
                            mapCryptMojo3 = LevelAOB.cryptMojo3PAL;
                            mapCryptMojo4 = LevelAOB.cryptMojo4PAL;
                            mapCanada = LevelAOB.canadaPAL;
                            mapCabin1 = LevelAOB.cabin1PAL;
                            mapCabin2 = LevelAOB.cabin2PAL;
                            mapCabin3 = LevelAOB.cabin3PAL;
                            mapTrainAerial = LevelAOB.trainAerialPAL;
                            mapTrainTheft = LevelAOB.trainTheftPAL;
                            mapTrainRide = LevelAOB.trainRidePAL;
                            mapTrainOP = LevelAOB.trainOPPAL;
                            mapCanada2 = LevelAOB.canada2PAL;
                            mapRC = LevelAOB.RCPAL;
                            mapSawmill = LevelAOB.sawmillPAL;
                            mapLighthouse = LevelAOB.lighthousePAL;
                            mapBear = LevelAOB.bearPAL;
                            mapSawmillBoss = LevelAOB.sawmillBossPAL;
                            mapBlimp = LevelAOB.blimpPAL;
                            mapBlimpHQ = LevelAOB.blimpHQPAL;
                            mapEngine1 = LevelAOB.engine1PAL;
                            mapEngine2 = LevelAOB.engine2PAL;
                            mapEngine3 = LevelAOB.engine3PAL;
                            mapParisFinale = LevelAOB.parisFinalePAL;

                        });
                    }
                    if (gameCRC == Sly2CRC.Sly2NTSC)
                    {
                        currentGame.Invoke((MethodInvoker)delegate
                        {
                            currentGame.Text = "Sly 2: Band of Thieves (NTSC-U) " + "[" + gameCRC + "]";
                            currentGame.ForeColor = Color.Green;

                            gameClock = clockNTSC; //Clock
                            slyGadget = botSlyGadgetNTSC; //Gadgets
                            bentleyGadget = botBentleyGadgetNTSC;
                            murrayGadget = botMurrayGadgetNTSC;
                            unlockGadgets1 = botUnlockGadgets1NTSC;
                            unlockGadgets2 = botUnlockGadgets2NTSC;
                            disableGuardAI = botDisableGuardAINTSC; //Guards
                            guardSize = botGuardSizeNTSC;
                            indicatorL2 = L2NTSC; //Indicators
                            indicatorR2 = R2NTSC;
                            toggleBattleMus = botBattleMusNTSC; //Music
                            toggleSneakMus = botSneakMusNTSC;
                            charIDAddr = botCharIDNTSC; //Structs
                            resetCam = botResetCamNTSC;
                            actStructBase = botActBaseNTSC;
                            slyStructBase = botSlyBaseNTSC;
                            bentleyStructBase = botBentleyBaseNTSC;
                            murrayStructBase = botMurrayBaseNTSC;
                            neylaStructBase = botNeylaBaseNTSC;
                            dimitriStructBase = botDimitriBaseNTSC;
                            carmStructBase = botCarmBaseNTSC;
                            gangHPGUI = botGangHPGUINTSC; //GUI
                            //coinGUI = botCoinGUINTSC;
                            bottleGUI = botBottleGUINTSC;
                            //ejectGUI = botEjectGUINTSC;
                            blackbarsGUI = botBlackbarsGUINTSC;
                            infoboxGUI = botInfoboxGUINTSC;
                            //slymaskGUI = botSlyMaskGUINTSC;
                            failGUI = botFailGUINTSC;
                            thiefNetGUI = botThiefNetGUINTSC;
                            slyHP = botSlyHPNTSC; //Health
                            bentleyHP = botBentleyHPNTSC;
                            murrayHP = botMurrayHPNTSC;
                            reloadAOB = botReloadAOBNTSC; //Map loading
                            reloadFunc = botReloadFuncNTSC;
                            mapID = botMapIDNTSC;
                            mapCairo = LevelAOB.cairoNTSC; //Maps
                            mapMenu = LevelAOB.menuNTSC;
                            mapParis = LevelAOB.parisNTSC;
                            mapWineDoor = LevelAOB.wineDoorNTSC;
                            mapWineLasers = LevelAOB.wineLasersNTSC;
                            mapDiscoBackdoor = LevelAOB.discoBackdoorNTSC;
                            mapDiscoWindow = LevelAOB.discoWindowNTSC;
                            mapPrintRecon = LevelAOB.printReconNTSC;
                            mapPrintBoss = LevelAOB.printBossNTSC;
                            mapTheater = LevelAOB.theaterNTSC;
                            mapWaterPump = LevelAOB.waterPumpNTSC;
                            mapIndia = LevelAOB.indiaNTSC;
                            mapHotelFront = LevelAOB.hotelFrontNTSC;
                            mapHotelEnt2 = LevelAOB.hotelEnt2NTSC;
                            mapHotelEnt3 = LevelAOB.hotelEnt3NTSC;
                            mapHotelEnt4 = LevelAOB.hotelEnt4NTSC;
                            mapBasement = LevelAOB.basementNTSC;
                            mapBalls = LevelAOB.ballsNTSC;
                            mapIndia2 = LevelAOB.india2NTSC;
                            mapSpiceBottom = LevelAOB.spiceBottomNTSC;
                            mapSpiceTop = LevelAOB.spiceTopNTSC;
                            mapSpice = LevelAOB.spiceNTSC;
                            mapRajan = LevelAOB.rajanNTSC;
                            mapPrague = LevelAOB.pragueNTSC;
                            mapPrisonMurray = LevelAOB.prisonMurrayNTSC;
                            mapPrison = LevelAOB.prisonNTSC;
                            mapVaultRoom = LevelAOB.vaultRoomNTSC;
                            mapPrague2 = LevelAOB.prague2NTSC;
                            mapCrypt1 = LevelAOB.crypt1NTSC;
                            mapCrypt2 = LevelAOB.crypt2NTSC;
                            mapCrypt3 = LevelAOB.crypt3NTSC;
                            mapGhost = LevelAOB.ghostNTSC;
                            mapReeducation = LevelAOB.reeducationNTSC;
                            mapCryptHack = LevelAOB.cryptHackNTSC;
                            mapCryptMojo1 = LevelAOB.cryptMojo1NTSC;
                            mapCryptMojo2 = LevelAOB.cryptMojo2NTSC;
                            mapCryptMojo3 = LevelAOB.cryptMojo3NTSC;
                            mapCryptMojo4 = LevelAOB.cryptMojo4NTSC;
                            mapCanada = LevelAOB.canadaNTSC;
                            mapCabin1 = LevelAOB.cabin1NTSC;
                            mapCabin2 = LevelAOB.cabin2NTSC;
                            mapCabin3 = LevelAOB.cabin3NTSC;
                            mapTrainAerial = LevelAOB.trainAerialNTSC;
                            mapTrainTheft = LevelAOB.trainTheftNTSC;
                            mapTrainRide = LevelAOB.trainRideNTSC;
                            mapTrainOP = LevelAOB.trainOPNTSC;
                            mapCanada2 = LevelAOB.canada2NTSC;
                            mapRC = LevelAOB.RCNTSC;
                            mapSawmill = LevelAOB.sawmillNTSC;
                            mapLighthouse = LevelAOB.lighthouseNTSC;
                            mapBear = LevelAOB.bearNTSC;
                            mapSawmillBoss = LevelAOB.sawmillBossNTSC;
                            mapBlimp = LevelAOB.blimpNTSC;
                            mapBlimpHQ = LevelAOB.blimpHQNTSC;
                            mapEngine1 = LevelAOB.engine1NTSC;
                            mapEngine2 = LevelAOB.engine2NTSC;
                            mapEngine3 = LevelAOB.engine3NTSC;
                            mapParisFinale = LevelAOB.parisFinaleNTSC;
                        });
                    }
                    if (gameCRC == Sly2CRC.Sly2NTSCJ)
                    {
                        currentGame.Invoke((MethodInvoker)delegate
                        {
                            currentGame.Text = "Sly 2: Band of Thieves (NTSC-J) " + "[" + gameCRC + "]";
                            currentGame.ForeColor = Color.Green;

                            unlockGadgets1 = botUnlockGadgets1NTSCJ;
                            unlockGadgets2 = botUnlockGadgets2NTSCJ;

                            charIDAddr = botCharIDNTSCJ;
                            actStructBase = botActBaseNTSCJ;
                            slyStructBase = botSlyBaseNTSCJ;
                            bentleyStructBase = botBentleyBaseNTSCJ;
                            murrayStructBase = botMurrayBaseNTSCJ;
                            neylaStructBase = botNeylaBaseNTSCJ;
                            dimitriStructBase = botDimitriBaseNTSCJ;
                            carmStructBase = botCarmBaseNTSCJ;

                            slyHP = botSlyHPNTSCJ; //Health
                            bentleyHP = botBentleyHPNTSCJ;
                            murrayHP = botMurrayHPNTSCJ;

                            mapCairo = LevelAOB.cairoNTSCJ; //Maps
                            mapMenu = LevelAOB.menuNTSCJ;
                            mapParis = LevelAOB.parisNTSCJ;
                            mapWineDoor = LevelAOB.wineDoorNTSCJ;
                            mapWineLasers = LevelAOB.wineLasersNTSCJ;
                            mapDiscoBackdoor = LevelAOB.discoBackdoorNTSCJ;
                            mapDiscoWindow = LevelAOB.discoWindowNTSCJ;
                            mapPrintRecon = LevelAOB.printReconNTSCJ;
                            mapPrintBoss = LevelAOB.printBossNTSCJ;
                            mapTheater = LevelAOB.theaterNTSCJ;
                            mapWaterPump = LevelAOB.waterPumpNTSCJ;
                            mapIndia = LevelAOB.indiaNTSCJ;
                            mapHotelFront = LevelAOB.hotelFrontNTSCJ;
                            mapHotelEnt2 = LevelAOB.hotelEnt2NTSCJ;
                            mapHotelEnt3 = LevelAOB.hotelEnt3NTSCJ;
                            mapHotelEnt4 = LevelAOB.hotelEnt4NTSCJ;
                            mapBasement = LevelAOB.basementNTSCJ;
                            mapBalls = LevelAOB.ballsNTSCJ;
                            mapIndia2 = LevelAOB.india2NTSCJ;
                            mapSpiceBottom = LevelAOB.spiceBottomNTSCJ;
                            mapSpiceTop = LevelAOB.spiceTopNTSCJ;
                            mapSpice = LevelAOB.spiceNTSCJ;
                            mapRajan = LevelAOB.rajanNTSCJ;
                            mapPrague2 = LevelAOB.prague2NTSCJ;
                            mapCrypt1 = LevelAOB.crypt1NTSCJ;
                            mapCrypt2 = LevelAOB.crypt2NTSCJ;
                            mapCrypt3 = LevelAOB.crypt3NTSCJ;
                            mapGhost = LevelAOB.ghostNTSCJ;
                            mapReeducation = LevelAOB.reeducationNTSCJ;
                            mapCryptHack = LevelAOB.cryptHackNTSCJ;
                            mapCryptMojo1 = LevelAOB.cryptMojo1NTSCJ;
                            mapCryptMojo2 = LevelAOB.cryptMojo2NTSCJ;
                            mapCryptMojo3 = LevelAOB.cryptMojo3NTSCJ;
                            mapCryptMojo4 = LevelAOB.cryptMojo4NTSCJ;
                            mapCanada = LevelAOB.canadaNTSCJ;
                            mapCabin1 = LevelAOB.cabin1NTSCJ;
                            mapCabin2 = LevelAOB.cabin2NTSCJ;
                            mapCabin3 = LevelAOB.cabin3NTSCJ;
                            mapTrainAerial = LevelAOB.trainAerialNTSCJ;
                            mapTrainTheft = LevelAOB.trainTheftNTSCJ;
                            mapTrainRide = LevelAOB.trainRideNTSCJ;
                            mapTrainOP = LevelAOB.trainOPNTSCJ;
                            mapCanada2 = LevelAOB.canada2NTSCJ;
                            mapRC = LevelAOB.RCNTSCJ;
                            mapSawmill = LevelAOB.sawmillNTSCJ;
                            mapLighthouse = LevelAOB.lighthouseNTSCJ;
                            mapBear = LevelAOB.bearNTSCJ;
                            mapSawmillBoss = LevelAOB.sawmillBossNTSCJ;
                            mapBlimp = LevelAOB.blimpNTSCJ;
                            mapBlimpHQ = LevelAOB.blimpHQNTSCJ;
                            mapEngine1 = LevelAOB.engine1NTSCJ;
                            mapEngine2 = LevelAOB.engine2NTSCJ;
                            mapEngine3 = LevelAOB.engine3NTSCJ;
                            mapParisFinale = LevelAOB.parisFinaleNTSCJ;
                        });
                    }
                    if (gameCRC == Sly2CRC.Sly2NTSCK)
                    {
                        currentGame.Invoke((MethodInvoker)delegate
                        {
                            currentGame.Text = "Sly 2: Band of Thieves (NTSC-K) " + "[" + gameCRC + "]";
                            currentGame.ForeColor = Color.Green;

                            charIDAddr = botCharIDNTSCK;
                            actStructBase = botActBaseNTSCK;
                            slyStructBase = botSlyBaseNTSCK;
                            bentleyStructBase = botBentleyBaseNTSCK;
                            murrayStructBase = botMurrayBaseNTSCK;
                            neylaStructBase = botNeylaBaseNTSCK;
                            dimitriStructBase = botDimitriBaseNTSCK;
                            carmStructBase = botCarmBaseNTSCK;

                            slyHP = botSlyHPNTSCK; //Health

                            mapCairo = LevelAOB.cairoNTSCK; //Maps
                            mapMenu = LevelAOB.menuNTSCK;
                            mapParis = LevelAOB.parisNTSCK;
                            mapWineDoor = LevelAOB.wineDoorNTSCK;
                            mapWineLasers = LevelAOB.wineLasersNTSCK;
                            mapDiscoBackdoor = LevelAOB.discoBackdoorNTSCK;
                            mapDiscoWindow = LevelAOB.discoWindowNTSCK;
                            mapPrintRecon = LevelAOB.printReconNTSCK;
                            mapPrintBoss = LevelAOB.printBossNTSCK;
                            mapTheater = LevelAOB.theaterNTSCK;
                            mapWaterPump = LevelAOB.waterPumpNTSCK;
                            mapIndia = LevelAOB.indiaNTSCK;
                            mapHotelFront = LevelAOB.hotelFrontNTSCK;
                            mapHotelEnt2 = LevelAOB.hotelEnt2NTSCK;
                            mapHotelEnt3 = LevelAOB.hotelEnt3NTSCK;
                            mapHotelEnt4 = LevelAOB.hotelEnt4NTSCK;
                            mapBasement = LevelAOB.basementNTSCK;
                            mapBalls = LevelAOB.ballsNTSCK;
                            mapIndia2 = LevelAOB.india2NTSCK;
                            mapSpiceBottom = LevelAOB.spiceBottomNTSCK;
                            mapSpiceTop = LevelAOB.spiceTopNTSCK;
                            mapSpice = LevelAOB.spiceNTSCK;
                            mapRajan = LevelAOB.rajanNTSCK;
                            mapPrague2 = LevelAOB.prague2NTSCK;
                            mapCrypt1 = LevelAOB.crypt1NTSCK;
                            mapCrypt2 = LevelAOB.crypt2NTSCK;
                            mapCrypt3 = LevelAOB.crypt3NTSCK;
                            mapGhost = LevelAOB.ghostNTSCK;
                            mapReeducation = LevelAOB.reeducationNTSCK;
                            mapCryptHack = LevelAOB.cryptHackNTSCK;
                            mapCryptMojo1 = LevelAOB.cryptMojo1NTSCK;
                            mapCryptMojo2 = LevelAOB.cryptMojo2NTSCK;
                            mapCryptMojo3 = LevelAOB.cryptMojo3NTSCK;
                            mapCryptMojo4 = LevelAOB.cryptMojo4NTSCK;
                            mapCanada = LevelAOB.canadaNTSCK;
                            mapCabin1 = LevelAOB.cabin1NTSCK;
                            mapCabin2 = LevelAOB.cabin2NTSCK;
                            mapCabin3 = LevelAOB.cabin3NTSCK;
                            mapTrainAerial = LevelAOB.trainAerialNTSCK;
                            mapTrainTheft = LevelAOB.trainTheftNTSCK;
                            mapTrainRide = LevelAOB.trainRideNTSCK;
                            mapTrainOP = LevelAOB.trainOPNTSCK;
                            mapCanada2 = LevelAOB.canada2NTSCK;
                            mapRC = LevelAOB.RCNTSCK;
                            mapSawmill = LevelAOB.sawmillNTSCK;
                            mapLighthouse = LevelAOB.lighthouseNTSCK;
                            mapBear = LevelAOB.bearNTSCK;
                            mapSawmillBoss = LevelAOB.sawmillBossNTSCK;
                            mapBlimp = LevelAOB.blimpNTSCK;
                            mapBlimpHQ = LevelAOB.blimpHQNTSCK;
                            mapEngine1 = LevelAOB.engine1NTSCK;
                            mapEngine2 = LevelAOB.engine2NTSCK;
                            mapEngine3 = LevelAOB.engine3NTSCK;
                            mapParisFinale = LevelAOB.parisFinaleNTSCK;
                        });
                    }
                    if (gameCRC == Sly2CRC.Sly2Mar17)
                    {
                        currentGame.Invoke((MethodInvoker)delegate
                        {
                            currentGame.Text = "Sly 2: Band of Thieves (March 17 Prototype) " + "[" + gameCRC + "]";
                            currentGame.ForeColor = Color.Green;

                            charIDAddr = botCharIDMar17;
                            actStructBase = botActBaseMar17;
                            slyStructBase = botSlyBaseMar17;
                            bentleyStructBase = botBentleyBaseMar17;
                            murrayStructBase = botMurrayBaseMar17;
                            neylaStructBase = botNeylaBaseMar17;
                            dimitriStructBase = botDimitriBaseMar17;
                            carmStructBase = botCarmBaseMar17;

                            mapMenu = LevelAOB.menuMar17; //Maps
                            mapParis = LevelAOB.parisMar17;
                            mapWineDoor = LevelAOB.wineDoorMar17;
                            mapWineLasers = LevelAOB.wineLasersMar17;
                            mapDiscoBackdoor = LevelAOB.discoBackdoorMar17;
                            mapDiscoWindow = LevelAOB.discoWindowMar17;
                            mapPrintRecon = LevelAOB.printReconMar17;
                            mapPrintBoss = LevelAOB.printBossMar17;
                            mapTheater = LevelAOB.theaterMar17;
                            mapWaterPump = LevelAOB.waterPumpMar17;
                            mapIndia = LevelAOB.indiaMar17;
                            mapHotelFront = LevelAOB.hotelFrontMar17;
                            mapHotelEnt2 = LevelAOB.hotelEnt2Mar17;
                            mapHotelEnt3 = LevelAOB.hotelEnt3Mar17;
                            mapHotelEnt4 = LevelAOB.hotelEnt4Mar17;
                            mapBasement = LevelAOB.basementMar17;
                            mapBalls = LevelAOB.ballsMar17;
                            mapIndia2 = LevelAOB.india2Mar17;
                            mapSpiceBottom = LevelAOB.spiceBottomMar17;
                            mapSpiceTop = LevelAOB.spiceTopMar17;
                            mapSpice = LevelAOB.spiceMar17;
                            mapRajan = LevelAOB.rajanMar17;
                        });
                    }
                    if (gameCRC == Sly2CRC.Sly2Jul12)
                    {
                        currentGame.Invoke((MethodInvoker)delegate
                        {
                            currentGame.Text = "Sly 2: Band of Thieves (July 12 Prototype) " + "[" + gameCRC + "]";
                            currentGame.ForeColor = Color.Green;

                            charIDAddr = botCharIDJul12;
                            actStructBase = botActBaseJul12;
                            slyStructBase = botSlyBaseJul12;
                            bentleyStructBase = botBentleyBaseJul12;
                            murrayStructBase = botMurrayBaseJul12;
                            neylaStructBase = botNeylaBaseJul12;
                            dimitriStructBase = botDimitriBaseJul12;
                            carmStructBase = botCarmBaseJul12;

                            mapCairo = LevelAOB.cairoJul12; //Maps
                            mapParis = LevelAOB.parisJul12;
                            mapWineLasers = LevelAOB.wineLasersJul12;
                            mapDiscoBackdoor = LevelAOB.discoBackdoorJul12;
                            mapDiscoWindow = LevelAOB.discoWindowJul12;
                            mapPrintRecon = LevelAOB.printReconJul12;
                            mapPrintBoss = LevelAOB.printBossJul12;
                            mapTheater = LevelAOB.theaterJul12;
                            mapWaterPump = LevelAOB.waterPumpJul12;
                            mapIndia = LevelAOB.indiaJul12;
                            mapHotelFront = LevelAOB.hotelFrontJul12;
                            mapHotelEnt2 = LevelAOB.hotelEnt2Jul12;
                            mapHotelEnt3 = LevelAOB.hotelEnt3Jul12;
                            mapHotelEnt4 = LevelAOB.hotelEnt4Jul12;
                            mapBasement = LevelAOB.basementJul12;
                            mapBalls = LevelAOB.ballsJul12;
                            mapIndia2 = LevelAOB.india2Jul12;
                            mapSpiceBottom = LevelAOB.spiceBottomJul12;
                            mapSpiceTop = LevelAOB.spiceTopJul12;
                            mapSpice = LevelAOB.spiceJul12;
                            mapRajan = LevelAOB.rajanJul12;
                            mapPrague2 = LevelAOB.prague2Jul12;
                            mapCrypt1 = LevelAOB.crypt1Jul12;
                            mapCrypt2 = LevelAOB.crypt2Jul12;
                            mapCrypt3 = LevelAOB.crypt3Jul12;
                            mapGhost = LevelAOB.ghostJul12;
                            mapReeducation = LevelAOB.reeducationJul12;
                            mapCryptHack = LevelAOB.cryptHackJul12;
                            mapCryptMojo1 = LevelAOB.cryptMojo1Jul12;
                            mapCryptMojo2 = LevelAOB.cryptMojo2Jul12;
                            mapCryptMojo3 = LevelAOB.cryptMojo3Jul12;
                            mapCryptMojo4 = LevelAOB.cryptMojo4Jul12;
                            mapCanada = LevelAOB.canadaJul12;
                            mapCabin1 = LevelAOB.cabin1Jul12;
                            mapCabin2 = LevelAOB.cabin2Jul12;
                            mapCabin3 = LevelAOB.cabin3Jul12;
                            mapTrainAerial = LevelAOB.trainAerialJul12;
                            mapTrainTheft = LevelAOB.trainTheftJul12;
                            mapTrainRide = LevelAOB.trainRideJul12;
                            mapTrainOP = LevelAOB.trainOPJul12;
                            mapCanada2 = LevelAOB.canada2Jul12;
                            mapRC = LevelAOB.RCJul12;
                            mapSawmill = LevelAOB.sawmillJul12;
                            mapLighthouse = LevelAOB.lighthouseJul12;
                            mapBear = LevelAOB.bearJul12;
                            mapSawmillBoss = LevelAOB.sawmillBossJul12;
                        });
                    }

                    if (gameCRC != Sly2CRC.Sly2PAL && gameCRC != Sly2CRC.Sly2NTSC && gameCRC != Sly2CRC.Sly2NTSCJ && gameCRC != Sly2CRC.Sly2NTSCK && gameCRC != Sly2CRC.Sly2Mar17 && gameCRC != Sly2CRC.Sly2Jul12)
                    {
                        Application.Restart();
                    }

                    if (foundCRC && gameCRC == "0")
                    {
                        Application.Restart();
                    }

                    actChar.Invoke((MethodInvoker)delegate
                    {
                        actCharIndex = m.ReadByte(actStructBase + EntityStruct.entityID);
                        if (actCharIndex == 7)
                        {
                            actChar.Text = "Sly";
                            actChar.ForeColor = ColorTranslator.FromHtml("#4683B5");
                            activeStruct = slyStructBase;
                        }
                        else if (actCharIndex == 8)
                        {
                            actChar.Text = "Bentley";
                            actChar.ForeColor = ColorTranslator.FromHtml("#40B369");
                            activeStruct = bentleyStructBase;
                        }
                        else if (actCharIndex == 9)
                        {
                            actChar.Text = "Murray";
                            actChar.ForeColor = ColorTranslator.FromHtml("#A25F89");
                            activeStruct = murrayStructBase;
                        }
                        else if (actCharIndex == 0)
                        {
                            actChar.Text = "???";
                            actChar.ForeColor = Color.White;
                        }
                    }); //active character text + color

                    if (currentTab == 0)
                    {
                        float actConvertX;
                        float actConvertY;
                        float actConvertZ;
                        while (currentTab == 0)
                        {
                            slyHPAmount = m.ReadInt(slyHP).ToString();
                            bentleyHPAmount = m.ReadInt(bentleyHP).ToString();
                            murrayHPAmount = m.ReadInt(murrayHP).ToString();

                            actConvertX = m.ReadFloat(actStructBase + TransformOffset.coordOffsetX, round: false);
                            DelegateThisShit(actEntX, actConvertX);

                            actConvertY = m.ReadFloat(actStructBase + TransformOffset.coordOffsetY, round: false);
                            DelegateThisShit(actEntY, actConvertY);

                            actConvertZ = m.ReadFloat(actStructBase + TransformOffset.coordOffsetZ, round: false);
                            DelegateThisShit(actEntZ, actConvertZ);

                            if (actCharIndex == 7)
                            {
                                DelgeateThisShit(actHealth, slyHPAmount);
                            }
                            else if (actCharIndex == 8)
                            {
                                DelgeateThisShit(actHealth, bentleyHPAmount);
                            }
                            else if (actCharIndex == 9)
                            {
                                DelgeateThisShit(actHealth, murrayHPAmount);
                            }
                            else if (actCharIndex < 7)
                            {
                                DelgeateThisShit(actHealth, "???");
                            }
                            Thread.Sleep(100);
                        }
                    } //Active character tab

                    if (currentTab == 2)
                    {
                        float convertX;
                        float convertY;
                        float convertZ;
                        while (currentTab == 2)
                        {
                            if (targetEntity == "Sly")
                            {
                                convertX = m.ReadFloat(slyStructBase + TransformOffset.coordOffsetX, round: false);
                                DelegateThisShit(entX, convertX);

                                convertY = m.ReadFloat(slyStructBase + TransformOffset.coordOffsetY, round: false);
                                DelegateThisShit(entY, convertY);

                                convertZ = m.ReadFloat(slyStructBase + TransformOffset.coordOffsetZ, round: false);
                                DelegateThisShit(entZ, convertZ);

                                entActTimer.Invoke((MethodInvoker)delegate
                                {
                                    entActTimer.Text = Math.Round(m.ReadFloat(slyStructBase + EntityStruct.entityTimer, round: true)).ToString();
                                });

                                entID.Invoke((MethodInvoker)delegate
                                {
                                    entID.Text = m.ReadByte(slyStructBase + EntityStruct.entityID).ToString();
                                }); // Entity ID
                            }
                            else if (targetEntity == "Bentley")
                            {
                                convertX = m.ReadFloat(bentleyStructBase + TransformOffset.coordOffsetX, round: false);
                                DelegateThisShit(entX, convertX);

                                convertY = m.ReadFloat(bentleyStructBase + TransformOffset.coordOffsetY, round: false);
                                DelegateThisShit(entY, convertY);

                                convertZ = m.ReadFloat(bentleyStructBase + TransformOffset.coordOffsetZ, round: false);
                                DelegateThisShit(entZ, convertZ);

                                entActTimer.Invoke((MethodInvoker)delegate
                                {
                                    entActTimer.Text = Math.Round(m.ReadFloat(bentleyStructBase + EntityStruct.entityTimer, round: true)).ToString();
                                });

                                entID.Invoke((MethodInvoker)delegate
                                {
                                    entID.Text = m.ReadByte(bentleyStructBase + EntityStruct.entityID).ToString();
                                });
                            }
                            else if (targetEntity == "Murray")
                            {
                                convertX = m.ReadFloat(murrayStructBase + TransformOffset.coordOffsetX, round: false);
                                DelegateThisShit(entX, convertX);

                                convertY = m.ReadFloat(murrayStructBase + TransformOffset.coordOffsetY, round: false);
                                DelegateThisShit(entY, convertY);

                                convertZ = m.ReadFloat(murrayStructBase + TransformOffset.coordOffsetZ, round: false);
                                DelegateThisShit(entZ, convertZ);

                                entActTimer.Invoke((MethodInvoker)delegate
                                {
                                    entActTimer.Text = Math.Round(m.ReadFloat(murrayStructBase + EntityStruct.entityTimer, round: true)).ToString();
                                });

                                entID.Invoke((MethodInvoker)delegate
                                {
                                    entID.Text = m.ReadByte(murrayStructBase + EntityStruct.entityID).ToString();
                                });
                            } // Murray Location
                            else if (targetEntity == "Neyla")
                            {
                                convertX = m.ReadFloat(neylaStructBase + TransformOffset.coordOffsetX, round: false);
                                DelegateThisShit(entX, convertX);

                                convertY = m.ReadFloat(neylaStructBase + TransformOffset.coordOffsetY, round: false);
                                DelegateThisShit(entY, convertY);

                                convertZ = m.ReadFloat(neylaStructBase + TransformOffset.coordOffsetZ, round: false);
                                DelegateThisShit(entZ, convertZ);

                                entActTimer.Invoke((MethodInvoker)delegate
                                {
                                    entActTimer.Text = Math.Round(m.ReadFloat(neylaStructBase + EntityStruct.entityTimer, round: true)).ToString();
                                });

                                entID.Invoke((MethodInvoker)delegate
                                {
                                    entID.Text = m.ReadByte(neylaStructBase + EntityStruct.entityID).ToString();
                                });
                            } // Neyla Location
                            else if (targetEntity == "Dimitri")
                            {
                                convertX = m.ReadFloat(dimitriStructBase + TransformOffset.coordOffsetX, round: false);
                                DelegateThisShit(entX, convertX);

                                convertY = m.ReadFloat(dimitriStructBase + TransformOffset.coordOffsetY, round: false);
                                DelegateThisShit(entY, convertY);

                                convertZ = m.ReadFloat(dimitriStructBase + TransformOffset.coordOffsetZ, round: false);
                                DelegateThisShit(entZ, convertZ);

                                entActTimer.Invoke((MethodInvoker)delegate
                                {
                                    entActTimer.Text = Math.Round(m.ReadFloat(dimitriStructBase + EntityStruct.entityTimer, round: true)).ToString();
                                });

                                entID.Invoke((MethodInvoker)delegate
                                {
                                    entID.Text = m.ReadByte(dimitriStructBase + EntityStruct.entityID).ToString();
                                });
                            } // Dimitri Location
                            else if (targetEntity == "Carmelita")
                            {
                                convertX = m.ReadFloat(carmStructBase + TransformOffset.coordOffsetX, round: false);
                                DelegateThisShit(entX, convertX);

                                convertY = m.ReadFloat(carmStructBase + TransformOffset.coordOffsetY, round: false);
                                DelegateThisShit(entY, convertY);

                                convertZ = m.ReadFloat(carmStructBase + TransformOffset.coordOffsetZ, round: false);
                                DelegateThisShit(entZ, convertZ);

                                entActTimer.Invoke((MethodInvoker)delegate
                                {
                                    entActTimer.Text = Math.Round(m.ReadFloat(carmStructBase + EntityStruct.entityTimer, round: true)).ToString();
                                });

                                entID.Invoke((MethodInvoker)delegate
                                {
                                    entID.Text = m.ReadByte(carmStructBase + EntityStruct.entityID).ToString();
                                });
                            } // Carmelita Location
                            Thread.Sleep(100);
                        }
                    }

                    actHealth.Invoke((MethodInvoker)delegate
                    {
                        actCharIndex = m.ReadByte(actStructBase + EntityStruct.entityID);
                        if (actCharIndex == 7)
                        {

                        }
                    }); //active character health

                    currentMap.Invoke((MethodInvoker)delegate
                    {
                        currentMapIndex = m.ReadByte(mapID);


                        if (currentMapIndex == 0)
                        {
                            currentMap.Text = "Cairo";
                        }
                        else if (currentMapIndex == 1)
                        {
                            currentMap.Text = "Main Menu";
                        }
                        else if (currentMapIndex == 2)
                        {
                            currentMap.Text = "Paris Hub";
                        }
                        else if (currentMapIndex == 3)
                        {
                            currentMap.Text = "Wine Cellar";
                        }
                        else if (currentMapIndex == 4)
                        {
                            currentMap.Text = "Nightclub";
                        }
                        else if (currentMapIndex == 5)
                        {
                            currentMap.Text = "Print Room";
                        }
                        else if (currentMapIndex == 6)
                        {
                            currentMap.Text = "Theater";
                        }
                        else if (currentMapIndex == 7)
                        {
                            currentMap.Text = "Pump Room";
                        }
                        else if (currentMapIndex == 8)
                        {
                            currentMap.Text = "India Hub";
                        }
                        else if (currentMapIndex == 9)
                        {
                            currentMap.Text = "Hotel";
                        }
                        else if (currentMapIndex == 10)
                        {
                            currentMap.Text = "Palace Basement";
                        }
                        else if (currentMapIndex == 11)
                        {
                            currentMap.Text = "Ballroom";
                        }
                        else if (currentMapIndex == 12)
                        {
                            currentMap.Text = "India 2 Hub";
                        }
                        else if (currentMapIndex == 13)
                        {
                            currentMap.Text = "Spice Grinder";
                        }
                        else if (currentMapIndex == 14)
                        {
                            currentMap.Text = "Prague Hub";
                        }
                        else if (currentMapIndex == 15)
                        {
                            currentMap.Text = "Prison";
                        }
                        else if (currentMapIndex == 16)
                        {
                            currentMap.Text = "Vault Room";
                        }
                        else if (currentMapIndex == 17)
                        {
                            currentMap.Text = "Prague 2 Hub";
                        }
                        else if (currentMapIndex == 18)
                        {
                            currentMap.Text = "secret map wtf weed weed wewed weedddd cocaine";
                        }
                        else if (currentMapIndex == 19)
                        {
                            currentMap.Text = "Crypt 3 (Stealing Voices)";
                        }
                        else if (currentMapIndex == 20)
                        {
                            currentMap.Text = "Crypt 1/2 (Stealing Voices)";
                        }
                        else if (currentMapIndex == 21)
                        {
                            currentMap.Text = "Crypt (Ghost Capture)";
                        }
                        else if (currentMapIndex == 22)
                        {
                            currentMap.Text = "Re-education Tower / Crypt Hack";
                        }
                        else if (currentMapIndex == 23)
                        {
                            currentMap.Text = "Crypt 1 (Mojo Trap)";
                        }
                        else if (currentMapIndex == 24)
                        {
                            currentMap.Text = "Crypt 3 (Mojo Trap)";
                        }
                        else if (currentMapIndex == 25)
                        {
                            currentMap.Text = "Crypt 2 (Mojo Trap)";
                        }
                        else if (currentMapIndex == 26)
                        {
                            currentMap.Text = "Crypt 4 (Mojo Trap)";
                        }
                        else if (currentMapIndex == 27)
                        {
                            currentMap.Text = "Canada Hub";
                        }
                        else if (currentMapIndex == 28)
                        {
                            currentMap.Text = "Cabins";
                        }
                        else if (currentMapIndex == 29)
                        {
                            currentMap.Text = "Train (Aerial Assault)";
                        }
                        else if (currentMapIndex == 30)
                        {
                            currentMap.Text = "Train (Operation)";
                        }
                        else if (currentMapIndex == 31)
                        {
                            currentMap.Text = "Train (Ride The Iron Horse)";
                        }
                        else if (currentMapIndex == 32)
                        {
                            currentMap.Text = "Canada 2 Hub";
                        }
                        else if (currentMapIndex == 33)
                        {
                            currentMap.Text = "RC Combat Club";
                        }
                        else if (currentMapIndex == 34)
                        {
                            currentMap.Text = "Sawmill";
                        }
                        else if (currentMapIndex == 35)
                        {
                            currentMap.Text = "Lighthouse";
                        }
                        else if (currentMapIndex == 36)
                        {
                            currentMap.Text = "Bear Cave";
                        }
                        else if (currentMapIndex == 37)
                        {
                            currentMap.Text = "Sawmill (Bossfight)";
                        }
                        else if (currentMapIndex == 38)
                        {
                            currentMap.Text = "Blimp Hub";
                        }
                        else if (currentMapIndex == 39)
                        {
                            currentMap.Text = "Blimp Headquarters";
                        }
                        else if (currentMapIndex == 40)
                        {
                            currentMap.Text = "Engine Room 1";
                        }
                        else if (currentMapIndex == 41)
                        {
                            currentMap.Text = "Engine Room 2";
                        }
                        else if (currentMapIndex == 42)
                        {
                            currentMap.Text = "Engine Room 3";
                        }
                        else if (currentMapIndex == 43)
                        {
                            currentMap.Text = "Paris (Finale)";
                        }
                    }); // level strings

                    if (gameCRC != Sly2CRC.Sly2PAL)
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
                    else if (gameCRC == Sly2CRC.Sly2PAL)
                    {
                        currentLang.Invoke((MethodInvoker)delegate
                        {
                            langIndex = m.ReadByte(langAddr);
                            if (langIndex == 0)
                            {
                                currentLang.Text = "English";
                            }
                            if (langIndex == 1)
                            {
                                currentLang.Text = "Français";
                            }
                            if (langIndex == 2)
                            {
                                currentLang.Text = "Italiano";
                            }
                            if (langIndex == 3)
                            {
                                currentLang.Text = "Deutsch";
                            }
                            if (langIndex == 4)
                            {
                                currentLang.Text = "Español";
                            }
                            if (langIndex == 5)
                            {
                                currentLang.Text = "Nederlands";
                            }
                            if (langIndex == 6)
                            {
                                currentLang.Text = "Português";
                            }
                            if (langIndex == 7)
                            {
                                currentLang.Text = "Dansk";
                            }
                            if (langIndex == 8)
                            {
                                currentLang.Text = "Suomalainen";
                            }
                            if (langIndex == 9)
                            {
                                currentLang.Text = "Norsk";
                            }
                            if (langIndex == 10)
                            {
                                currentLang.Text = "Svensk";
                            }
                        });
                    } // language strings



                    /* if (checkBoxFly.Checked)
                    {
                        float targetValue = 0F;
                        int L2FlagIndicator = m.ReadByte(indicatorL2, "byte");
                        int R2FlagIndicator = m.ReadByte(indicatorR2, "byte");

                        while (L2FlagIndicator != 0x00)
                        {
                            actEntZ.Invoke((MethodInvoker)delegate
                            {
                                targetValue = float.Parse(actEntZ.Text) + xyzTrackBar.Value; //increment
                            });
                            ChangeActiveCoords("z", targetValue, activeStruct, TransformOffset.coordOffsetZ);
                        }
                    } */

                    // Warps
                    warpComboBox.Invoke((MethodInvoker)delegate
                    {
                        if (currentMapIndex == 0) // Cairo
                        {
                            if (warpComboBox.Items.Count != 7)
                            {
                                warpComboBox.Items.Add("Start");
                                warpComboBox.Items.Add("Balcony 1");
                                warpComboBox.Items.Add("Cobra");
                                warpComboBox.Items.Add("Rendezvous Point");
                                warpComboBox.Items.Add("Carmelita Chase");
                                warpComboBox.Items.Add("Balcony 2");
                                warpComboBox.Items.Add("Finish");
                            }
                        }
                        else if (currentMapIndex == 1) // Main Menu
                        {
                            if (warpComboBox.Items.Count != 1)
                            {
                                warpComboBox.Items.Add("No warps available for this level");
                                warpComboBox.SelectedItem = "No warps available for this level";
                                warpButton.Enabled = false;
                                warpComboBox.Enabled = false;
                            }
                        }
                        else if (currentMapIndex == 2) // Paris
                        {
                            if (warpComboBox.Items.Count != 7)
                            {
                                warpComboBox.Items.Add("Start");
                                warpComboBox.Items.Add("Balcony 1");
                                warpComboBox.Items.Add("Cobra");
                                warpComboBox.Items.Add("Rendezvous Point");
                                warpComboBox.Items.Add("Carmelita Chase");
                                warpComboBox.Items.Add("Balcony 2");
                                warpComboBox.Items.Add("Finish");
                            }
                        }
                    });

                    Thread.Sleep(700);
                }

                Thread.Sleep(700);
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //click syhax logo
        {
            MessageBox.Show("sus man!", "hello");
        }

        private void reloadLvl_Click(object sender, EventArgs e) // Reload Level + Levelselector
        {
            m.WriteMemory(reloadFunc, "int", "1"); //reload function

            if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "Cairo")
            {
                m.WriteMemory(reloadAOB, "bytes", mapCairo); //reload values
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "Main Menu")
            {
                m.WriteMemory(reloadAOB, "bytes", mapMenu);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "Paris Hub")
            {
                m.WriteMemory(reloadAOB, "bytes", mapParis);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Wine Cellar (Door)")
            {
                m.WriteMemory(reloadAOB, "bytes", mapWineDoor);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Wine Cellar (Lasers)")
            {
                m.WriteMemory(reloadAOB, "bytes", mapWineLasers);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Nightclub (Back Door)")
            {
                m.WriteMemory(reloadAOB, "bytes", mapDiscoBackdoor);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Nightclub (Window)")
            {
                m.WriteMemory(reloadAOB, "bytes", mapDiscoWindow);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Print Room (Recon)")
            {
                m.WriteMemory(reloadAOB, "bytes", mapPrintRecon);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Print Room (Bossfight)")
            {
                m.WriteMemory(reloadAOB, "bytes", mapPrintBoss);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Theater")
            {
                m.WriteMemory(reloadAOB, "bytes", mapTheater);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Water Pump Room")
            {
                m.WriteMemory(reloadAOB, "bytes", mapWaterPump);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "India Hub")
            {
                m.WriteMemory(reloadAOB, "bytes", mapIndia);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Hotel (Front Door)")
            {
                m.WriteMemory(reloadAOB, "bytes", mapHotelFront);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Hotel (Entrance 2)")
            {
                m.WriteMemory(reloadAOB, "bytes", mapHotelEnt2);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Hotel (Entrance 3)")
            {
                m.WriteMemory(reloadAOB, "bytes", mapHotelEnt3);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Hotel (Entrance 4)")
            {
                m.WriteMemory(reloadAOB, "bytes", mapHotelEnt4);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Palace Basement")
            {
                m.WriteMemory(reloadAOB, "bytes", mapBasement);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Ballroom")
            {
                m.WriteMemory(reloadAOB, "bytes", mapBalls);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "India 2 Hub")
            {
                m.WriteMemory(reloadAOB, "bytes", mapIndia2);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Spice Factory (Bottom)")
            {
                m.WriteMemory(reloadAOB, "bytes", mapSpiceBottom);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Spice Factory (Top)")
            {
                m.WriteMemory(reloadAOB, "bytes", mapSpiceTop);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Spice Factory (Grinder)")
            {
                m.WriteMemory(reloadAOB, "bytes", mapSpice);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Spice Factory (Rajan's Office)")
            {
                m.WriteMemory(reloadAOB, "bytes", mapRajan);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "Prague Hub")
            {
                m.WriteMemory(reloadAOB, "bytes", mapPrague);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Prison (Murray's Cell)")
            {
                m.WriteMemory(reloadAOB, "bytes", mapPrisonMurray);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Prison")
            {
                m.WriteMemory(reloadAOB, "bytes", mapPrison);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Vault Room")
            {
                m.WriteMemory(reloadAOB, "bytes", mapVaultRoom);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "Prague 2 Hub")
            {
                m.WriteMemory(reloadAOB, "bytes", mapPrague2);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Crypt 1 (Stealing Voices)")
            {
                m.WriteMemory(reloadAOB, "bytes", mapCrypt1);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Crypt 2 (Stealing Voices)")
            {
                m.WriteMemory(reloadAOB, "bytes", mapCrypt2);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Crypt 3 (Stealing Voices)")
            {
                m.WriteMemory(reloadAOB, "bytes", mapCrypt3);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Crypt (Ghost Capture)")
            {
                m.WriteMemory(reloadAOB, "bytes", mapGhost);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Re-education Tower")
            {
                m.WriteMemory(reloadAOB, "bytes", mapReeducation);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Crypt Hack")
            {
                m.WriteMemory(reloadAOB, "bytes", mapCryptHack);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Crypt 1 (Mojo Trap)")
            {
                m.WriteMemory(reloadAOB, "bytes", mapCryptMojo1);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Crypt 2 (Mojo Trap)")
            {
                m.WriteMemory(reloadAOB, "bytes", mapCryptMojo2);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Crypt 3 (Mojo Trap)")
            {
                m.WriteMemory(reloadAOB, "bytes", mapCryptMojo3);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Crypt 4 (Mojo Trap)")
            {
                m.WriteMemory(reloadAOB, "bytes", mapCryptMojo4);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "Canada Hub")
            {
                m.WriteMemory(reloadAOB, "bytes", mapCanada);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Cabin 1")
            {
                m.WriteMemory(reloadAOB, "bytes", mapCabin1);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Cabin 2")
            {
                m.WriteMemory(reloadAOB, "bytes", mapCabin2);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Cabin 3")
            {
                m.WriteMemory(reloadAOB, "bytes", mapCabin3);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Train (Aerial Assault)")
            {
                m.WriteMemory(reloadAOB, "bytes", mapTrainAerial);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Train (Theft on Rails)")
            {
                m.WriteMemory(reloadAOB, "bytes", mapTrainTheft);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Train (Ride the Iron Horse)")
            {
                m.WriteMemory(reloadAOB, "bytes", mapTrainRide);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Train (Operation)")
            {
                m.WriteMemory(reloadAOB, "bytes", mapTrainOP);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "Canada 2 Hub")
            {
                m.WriteMemory(reloadAOB, "bytes", mapCanada2);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    RC Combat Club")
            {
                m.WriteMemory(reloadAOB, "bytes", mapRC);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Sawmill")
            {
                m.WriteMemory(reloadAOB, "bytes", mapSawmill);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Lighthouse")
            {
                m.WriteMemory(reloadAOB, "bytes", mapLighthouse);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Bear Cave")
            {
                m.WriteMemory(reloadAOB, "bytes", mapBear);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Sawmill (Bossfight)")
            {
                m.WriteMemory(reloadAOB, "bytes", mapSawmillBoss);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "Blimp Hub")
            {
                m.WriteMemory(reloadAOB, "bytes", mapBlimp);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Blimp Headquarters")
            {
                m.WriteMemory(reloadAOB, "bytes", mapBlimpHQ);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Engine Room 1")
            {
                m.WriteMemory(reloadAOB, "bytes", mapEngine1);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Engine Room 2")
            {
                m.WriteMemory(reloadAOB, "bytes", mapEngine2);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Engine Room 3")
            {
                m.WriteMemory(reloadAOB, "bytes", mapEngine3);
            }
            else if (levelComboBox.GetItemText(levelComboBox.SelectedItem) == "    Paris (Finale)")
            {
                m.WriteMemory(reloadAOB, "bytes", mapParisFinale);
            }
        }

        private void warpButton_Click(object sender, EventArgs e)
        {
            m.WriteMemory(resetCam, "int", "1");
            m.WriteMemory(activeStruct + EntityStruct.entityAnim, "int", "2");
            // Cairo
            if (warpComboBox.GetItemText(warpComboBox.SelectedItem) == "Start")
            {
                m.WriteMemory(activeStruct + TransformOffset.coordOffsetX, "float", "4915");
                m.WriteMemory(activeStruct + TransformOffset.coordOffsetY, "float", "-5211");
                m.WriteMemory(activeStruct + TransformOffset.coordOffsetZ, "float", "750");
            }
            else if (warpComboBox.GetItemText(warpComboBox.SelectedItem) == "Balcony 1")
            {
                m.WriteMemory(activeStruct + TransformOffset.coordOffsetX, "float", "11671");
                m.WriteMemory(activeStruct + TransformOffset.coordOffsetY, "float", "-1112");
                m.WriteMemory(activeStruct + TransformOffset.coordOffsetZ, "float", "1300");
            }
            else if (warpComboBox.GetItemText(warpComboBox.SelectedItem) == "Cobra")
            {
                m.WriteMemory(activeStruct + TransformOffset.coordOffsetX, "float", "18757");
                m.WriteMemory(activeStruct + TransformOffset.coordOffsetY, "float", "-1265");
                m.WriteMemory(activeStruct + TransformOffset.coordOffsetZ, "float", "1620");
            }
            else if (warpComboBox.GetItemText(warpComboBox.SelectedItem) == "Rendezvous Point")
            {
                m.WriteMemory(activeStruct + TransformOffset.coordOffsetX, "float", "12492");
                m.WriteMemory(activeStruct + TransformOffset.coordOffsetY, "float", "5805");
                m.WriteMemory(activeStruct + TransformOffset.coordOffsetZ, "float", "1780");
            }
            else if (warpComboBox.GetItemText(warpComboBox.SelectedItem) == "Carmelita Chase")
            {
                m.WriteMemory(activeStruct + TransformOffset.coordOffsetX, "float", "10354");
                m.WriteMemory(activeStruct + TransformOffset.coordOffsetY, "float", "8107");
                m.WriteMemory(activeStruct + TransformOffset.coordOffsetZ, "float", "2053");
            }
            else if (warpComboBox.GetItemText(warpComboBox.SelectedItem) == "Balcony 2")
            {
                m.WriteMemory(activeStruct + TransformOffset.coordOffsetX, "float", "-12865");
                m.WriteMemory(activeStruct + TransformOffset.coordOffsetY, "float", "15509");
                m.WriteMemory(activeStruct + TransformOffset.coordOffsetZ, "float", "1570");
            }
            else if (warpComboBox.GetItemText(warpComboBox.SelectedItem) == "Finish")
            {
                m.WriteMemory(activeStruct + TransformOffset.coordOffsetX, "float", "-26361");
                m.WriteMemory(activeStruct + TransformOffset.coordOffsetY, "float", "4366");
                m.WriteMemory(activeStruct + TransformOffset.coordOffsetZ, "float", "275");
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

        void ChangeEntityCoords(string xyz, float amount, string entitystruct, string offset)
        {
            if (xyz == "x")
            {
                m.WriteMemory(entitystruct + offset, "float", amount.ToString());
                if (toggleEntFreezeX)
                {
                    m.FreezeValue(entitystruct + offset, "float", amount.ToString());
                }
            }
            if (xyz == "y")
            {
                m.WriteMemory(entitystruct + offset, "float", amount.ToString());
                if (toggleEntFreezeY)
                {
                    m.FreezeValue(entitystruct + offset, "float", amount.ToString());
                }
            }
            if (xyz == "z")
            {
                m.WriteMemory(entitystruct + offset, "float", amount.ToString());
                if (toggleEntFreezeZ)
                {
                    m.FreezeValue(entitystruct + offset, "float", amount.ToString());
                }
            }
        }
        void ChangeActiveCoords(float amount, string entitystruct, string offset)
        {
            if (toggleActFreezeZ)
            {
                m.UnfreezeValue(entitystruct + offset);
            }
            m.WriteMemory(entitystruct + offset, "float", amount.ToString());
            if (toggleActFreezeZ)
            {
                m.FreezeValue(entitystruct + offset, "float", amount.ToString());
            }
        }
        /*
        void SetActiveCoords(string xyz, float target, string entitystruct, string offset)
        {
            m.WriteMemory(entitystruct + offset, "float", target.ToString());
        }
        */
        private void setActX_Click(object sender, EventArgs e)
        {
            float targetValue;
            if (textBoxActX.Text == "")
            {
                targetValue = 0;
            }
            else
            {
                targetValue = float.Parse(textBoxActX.Text);
            }
            ChangeActiveCoords(targetValue, activeStruct, TransformOffset.coordOffsetX);
        }
        private void setActY_Click(object sender, EventArgs e)
        {

        }
        private void setActZ_Click(object sender, EventArgs e)
        {

        }

        private void entitySelector_SelectedIndexChanged(object sender, EventArgs e) //Entity selector
        {
            if (entitySelector.GetItemText(entitySelector.SelectedItem) == "Sly")
            {
                targetEntity = "Sly";
                currentSelectedStruct = slyStructBase;
            }
            else if (entitySelector.GetItemText(entitySelector.SelectedItem) == "Bentley")
            {
                targetEntity = "Bentley";
                currentSelectedStruct = bentleyStructBase;
            }
            else if (entitySelector.GetItemText(entitySelector.SelectedItem) == "Murray")
            {
                targetEntity = "Murray";
                currentSelectedStruct = murrayStructBase;
            }
            else if (entitySelector.GetItemText(entitySelector.SelectedItem) == "Neyla")
            {
                targetEntity = "Neyla";
                currentSelectedStruct = neylaStructBase;
            }
            else if (entitySelector.GetItemText(entitySelector.SelectedItem) == "Dimitri")
            {
                targetEntity = "Dimitri";
                currentSelectedStruct = dimitriStructBase;
            }
            else if (entitySelector.GetItemText(entitySelector.SelectedItem) == "Carmelita")
            {
                targetEntity = "Carmelita";
                currentSelectedStruct = carmStructBase;
            }

            float convertScale = m.ReadFloat(currentSelectedStruct + TransformOffset.scaleOffsetX, round: false); //update entscale text
            DelegateThisShit(entScale, convertScale);

            // entScaleTrackbar.Value = int.Parse((m.ReadFloat(currentSelectedStruct + TransformOffset.scaleOffsetX, round: true) * 100).ToString()); //update entscale trackbar
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
            ChangeActiveCoords(targetValue, activeStruct, TransformOffset.coordOffsetX);
        }//active increase X
        private void actEntDecreaseX_Click(object sender, EventArgs e)
        {
            float targetValue = float.Parse(actEntX.Text) + xyzTrackBar.Value * -1; //decrement
            ChangeActiveCoords(targetValue, activeStruct, TransformOffset.coordOffsetX);
        }//active decrease X
        private void actEntIncreaseY_Click(object sender, EventArgs e)
        {
            float targetValue = float.Parse(actEntY.Text) + xyzTrackBar.Value; //decrement
            ChangeActiveCoords(targetValue, activeStruct, TransformOffset.coordOffsetY);
        }//active increase Y
        private void actEntDecreaseY_Click(object sender, EventArgs e)
        {
            float targetValue = float.Parse(actEntY.Text) + xyzTrackBar.Value * -1; //decrement
            ChangeActiveCoords(targetValue, activeStruct, TransformOffset.coordOffsetY);
        }//active decrease Y
        private void actEntIncreaseZ_Click(object sender, EventArgs e)
        {
            float targetValue = float.Parse(actEntZ.Text) + xyzTrackBar.Value; //increment
            ChangeActiveCoords(targetValue, activeStruct, TransformOffset.coordOffsetZ);
        }//active increase Z
        private void actEntDecreaseZ_Click(object sender, EventArgs e)
        {
            float targetValue = float.Parse(actEntZ.Text) + xyzTrackBar.Value * -1; //decrement
            ChangeActiveCoords(targetValue, activeStruct, TransformOffset.coordOffsetZ);
        }//active decrease Z

        private void entFreezeX_Click(object sender, EventArgs e) //entity freeze X
        {
            toggleEntFreezeX = !toggleEntFreezeX;
            if (toggleEntFreezeX)
            {
                entX.ForeColor = Color.Red;

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
                entX.ForeColor = Color.White;

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
                entY.ForeColor = Color.Red;

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
                entY.ForeColor = Color.White;

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
                entZ.ForeColor = Color.Red;

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
                entZ.ForeColor = Color.White;

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
                actEntX.ForeColor = Color.Red;

                m.FreezeValue(actStructBase + TransformOffset.coordOffsetX, "float", actEntX.Text);
            }
            else
            {
                actEntX.ForeColor = Color.White;

                m.UnfreezeValue(actStructBase + TransformOffset.coordOffsetX);
            }
        }
        private void actEntFreezeY_Click(object sender, EventArgs e) //active freeze Y
        {
            toggleActFreezeY = !toggleActFreezeY;
            if (toggleActFreezeY)
            {
                actEntY.ForeColor = Color.Red;

                m.FreezeValue(actStructBase + TransformOffset.coordOffsetY, "float", actEntY.Text);
            }
            else
            {
                actEntY.ForeColor = Color.Red;

                m.UnfreezeValue(actStructBase + TransformOffset.coordOffsetY);
            }
        }
        private void actEntFreezeZ_Click(object sender, EventArgs e) //active freeze Z
        {
            toggleActFreezeZ = !toggleActFreezeZ;
            if (toggleActFreezeZ)
            {
                actEntZ.ForeColor = Color.Red;

                m.FreezeValue(actStructBase + TransformOffset.coordOffsetZ, "float", actEntZ.Text);
            }
            else
            {
                actEntZ.ForeColor = Color.Red;

                m.UnfreezeValue(actStructBase + TransformOffset.coordOffsetZ);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentTab = tabControl1.SelectedIndex;
        }

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

        private void checkBoxInfJumps_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxInfJumps.Checked)
            {
                m.FreezeValue(activeStruct + EntityStruct.entityJump, "byte", "1");
            }
            else if (!checkBoxInfJumps.Checked)
            {
                m.UnfreezeValue(activeStruct + EntityStruct.entityJump);
                m.WriteMemory(activeStruct + EntityStruct.entityJump, "int", "0");
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

        private void infGadget_CheckedChanged(object sender, EventArgs e)
        {
            toggleInfGadget = !toggleInfGadget;
            if (infGadget.Checked)
            {
                m.FreezeValue(slyGadget, "int", "100");
                m.FreezeValue(bentleyGadget, "int", "100");
                m.FreezeValue(murrayGadget, "int", "100");
            }
            else
            {
                m.UnfreezeValue(slyGadget);
                m.UnfreezeValue(bentleyGadget);
                m.UnfreezeValue(murrayGadget);
            }
        }//infinite gadget power

        private void buttonGadgets_Click(object sender, EventArgs e)
        {
            m.WriteMemory(unlockGadgets1, "bytes", "FF FF FF FF");
            m.WriteMemory(unlockGadgets2, "bytes", "FF FF FF FF");
        } //unlock gadgets

        private void clueScriptButton_Click(object sender, EventArgs e)
        {

        } //button that makes sly go around all bottles very fast wow

        private void trackBarGameClock_ValueChanged(object sender, EventArgs e)
        {
            m.WriteMemory(gameClock, "float", (trackBarGameClock.Value / 100f).ToString("f1"));
        } //game clock

        private void godMode_CheckedChanged(object sender, EventArgs e)
        {
            if (godMode.Checked)
            {
                m.WriteMemory(activeStruct + EntityStruct.entityGod, "int", "1");
            }
            else
            {
                m.WriteMemory(activeStruct + EntityStruct.entityGod, "int", "0");
            }
        }

        private void guardIgnore_CheckedChanged(object sender, EventArgs e)
        {
            if (guardIgnore.Checked)
            {
                m.WriteMemory(activeStruct + EntityStruct.entityIgnore, "int", "1");
            }
            else
            {
                m.WriteMemory(activeStruct + EntityStruct.entityIgnore, "int", "0");
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

        private void checkSPFreeze_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSPFreeze.Checked)
            {
                m.FreezeValue(activeStruct + EntityStruct.entityAnim, "byte", "0");
            }
            else
            {
                m.UnfreezeValue(activeStruct + EntityStruct.entityAnim);
            }
        }

        private void actHPIncrease_Click(object sender, EventArgs e)
        {

        }

        private void actHPDecrease_Click(object sender, EventArgs e)
        {

        }

        private void actHPFreeze_Click(object sender, EventArgs e)
        {
            toggleHPFreeze = !toggleHPFreeze;
            if (toggleHPFreeze)
            {
                actHealth.ForeColor = Color.Red;
                if (actCharIndex == 7)
                {
                    m.FreezeValue(slyHPAmount, "int", actHealth.Text);
                }
                else if (actCharIndex == 8)
                {
                    m.FreezeValue(bentleyHPAmount, "int", actHealth.Text);
                }
                else if (actCharIndex == 9)
                {
                    m.FreezeValue(murrayHPAmount, "int", actHealth.Text);
                }
            }
            else
            {
                actHealth.ForeColor = Color.White;
                m.UnfreezeValue(slyHPAmount);
                m.UnfreezeValue(bentleyHPAmount);
                m.UnfreezeValue(murrayHPAmount);
            }
        }

        /* async void ScanAOBs(string guard)
        {
            IEnumerable<long> scanResults = await m.AoBScan(0x20400000, 0x20500000, guard, true, true);

            long topresult = scanResults.FirstOrDefault();
            m.FreezeValue(topresult.ToString("X"), "int", "0");
            //MessageBox.Show(topresult.ToString("X8"));
            m.WriteMemory(reloadFunc, "int", "1");
        } */
        private void despawnReload_Click(object sender, EventArgs e)
        {
            if (despawnFlashlight.Checked)
            {
                //ScanAOBs(GuardAOB.moose);
            }
            if (despawnSwarmers.Checked)
            {
                //ScanAOBs(GuardAOB.swarmer);
            }
        }

        private void guiSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guiSelector.GetItemText(guiSelector.SelectedItem) == "Gang Health Meter")
            {
                currentSelectedGUI = gangHPGUI;
            }
            else if (guiSelector.GetItemText(guiSelector.SelectedItem) == "Coin Count")
            {
                currentSelectedGUI = coinGUI;
            }
            else if (guiSelector.GetItemText(guiSelector.SelectedItem) == "Bottle Count")
            {
                currentSelectedGUI = bottleGUI;
            }
            else if (guiSelector.GetItemText(guiSelector.SelectedItem) == "Failscreen")
            {
                currentSelectedGUI = failGUI;
            }
        }

        private void activateGUI_Click(object sender, EventArgs e)
        {
            guiState = m.ReadByte(currentSelectedGUI + GUIStruct.guiActivate);

            if (guiState == 0 || guiState == 1)
            {
                m.WriteMemory(currentSelectedGUI, "byte", "2");
            }
            else if (guiState == 2)
            {
                m.WriteMemory(currentSelectedGUI, "byte", "1");
            }
        }
    }
}