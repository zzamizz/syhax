namespace syhax
{
    partial class syhax1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.slyTab = new System.Windows.Forms.TabPage();
            this.groupTransform = new System.Windows.Forms.GroupBox();
            this.charMovementBox = new System.Windows.Forms.GroupBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.xyzTrackBar = new System.Windows.Forms.TrackBar();
            this.setActZ = new System.Windows.Forms.Button();
            this.actEntFreezeX = new System.Windows.Forms.Button();
            this.setActY = new System.Windows.Forms.Button();
            this.labelActEntX = new System.Windows.Forms.Label();
            this.setActX = new System.Windows.Forms.Button();
            this.labelActEntY = new System.Windows.Forms.Label();
            this.textBoxActZ = new System.Windows.Forms.TextBox();
            this.labelActEntZ = new System.Windows.Forms.Label();
            this.textBoxActY = new System.Windows.Forms.TextBox();
            this.actEntX = new System.Windows.Forms.Label();
            this.textBoxActX = new System.Windows.Forms.TextBox();
            this.actEntY = new System.Windows.Forms.Label();
            this.actEntZ = new System.Windows.Forms.Label();
            this.actEntFreezeZ = new System.Windows.Forms.Button();
            this.actEntIncreaseX = new System.Windows.Forms.Button();
            this.actEntFreezeY = new System.Windows.Forms.Button();
            this.actEntIncreaseY = new System.Windows.Forms.Button();
            this.actEntIncreaseZ = new System.Windows.Forms.Button();
            this.actEntDecreaseZ = new System.Windows.Forms.Button();
            this.actEntDecreaseX = new System.Windows.Forms.Button();
            this.actEntDecreaseY = new System.Windows.Forms.Button();
            this.groupPowers = new System.Windows.Forms.GroupBox();
            this.charmGold = new System.Windows.Forms.Button();
            this.charmSilver = new System.Windows.Forms.Button();
            this.guardIgnore = new System.Windows.Forms.CheckBox();
            this.godMode = new System.Windows.Forms.CheckBox();
            this.checkBoxInfJumps = new System.Windows.Forms.CheckBox();
            this.charmNone = new System.Windows.Forms.Button();
            this.labelCharms = new System.Windows.Forms.Label();
            this.buttonMoves = new System.Windows.Forms.Button();
            this.engineTab = new System.Windows.Forms.TabPage();
            this.checkGuardAI = new System.Windows.Forms.CheckBox();
            this.reloadLang = new System.Windows.Forms.Button();
            this.currentLang = new System.Windows.Forms.Label();
            this.labelLang = new System.Windows.Forms.Label();
            this.langSelector = new System.Windows.Forms.ComboBox();
            this.drawFreeze = new System.Windows.Forms.CheckBox();
            this.fovFreeze = new System.Windows.Forms.CheckBox();
            this.warpComboBox = new System.Windows.Forms.ComboBox();
            this.resetDraw = new System.Windows.Forms.Button();
            this.labelDraw = new System.Windows.Forms.Label();
            this.trackBarDraw = new System.Windows.Forms.TrackBar();
            this.resetFOV = new System.Windows.Forms.Button();
            this.labelFOV = new System.Windows.Forms.Label();
            this.trackBarFOV = new System.Windows.Forms.TrackBar();
            this.resetGameClock = new System.Windows.Forms.Button();
            this.labelFieldClock = new System.Windows.Forms.Label();
            this.trackBarGameClock = new System.Windows.Forms.TrackBar();
            this.currentMap = new System.Windows.Forms.Label();
            this.labelMap = new System.Windows.Forms.Label();
            this.levelComboBox = new System.Windows.Forms.ComboBox();
            this.warpButton = new System.Windows.Forms.Button();
            this.reloadLvl = new System.Windows.Forms.Button();
            this.miscTab = new System.Windows.Forms.TabPage();
            this.clueScriptButton = new System.Windows.Forms.Button();
            this.miscBox = new System.Windows.Forms.GroupBox();
            this.groupMusic = new System.Windows.Forms.GroupBox();
            this.labelMusicState = new System.Windows.Forms.Label();
            this.labelMusicVol = new System.Windows.Forms.Label();
            this.musicVolume = new System.Windows.Forms.TrackBar();
            this.normalMusic = new System.Windows.Forms.RadioButton();
            this.sneakMusic = new System.Windows.Forms.RadioButton();
            this.battleMusic = new System.Windows.Forms.RadioButton();
            this.disableTextures = new System.Windows.Forms.CheckBox();
            this.weedButton = new System.Windows.Forms.PictureBox();
            this.labelAttached = new System.Windows.Forms.Label();
            this.currentGame = new System.Windows.Forms.Label();
            this.syhaxLogo = new System.Windows.Forms.LinkLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.slyTab.SuspendLayout();
            this.groupTransform.SuspendLayout();
            this.charMovementBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xyzTrackBar)).BeginInit();
            this.groupPowers.SuspendLayout();
            this.engineTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDraw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFOV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGameClock)).BeginInit();
            this.miscTab.SuspendLayout();
            this.miscBox.SuspendLayout();
            this.groupMusic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weedButton)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.slyTab);
            this.tabControl1.Controls.Add(this.engineTab);
            this.tabControl1.Controls.Add(this.miscTab);
            this.tabControl1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(13, 38);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 370);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // slyTab
            // 
            this.slyTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.slyTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.slyTab.Controls.Add(this.groupTransform);
            this.slyTab.Controls.Add(this.groupPowers);
            this.slyTab.Controls.Add(this.buttonMoves);
            this.slyTab.Location = new System.Drawing.Point(4, 4);
            this.slyTab.Name = "slyTab";
            this.slyTab.Padding = new System.Windows.Forms.Padding(3);
            this.slyTab.Size = new System.Drawing.Size(793, 342);
            this.slyTab.TabIndex = 0;
            this.slyTab.Text = "Sly";
            this.slyTab.ToolTipText = "Playable character";
            // 
            // groupTransform
            // 
            this.groupTransform.Controls.Add(this.charMovementBox);
            this.groupTransform.Controls.Add(this.xyzTrackBar);
            this.groupTransform.Controls.Add(this.setActZ);
            this.groupTransform.Controls.Add(this.actEntFreezeX);
            this.groupTransform.Controls.Add(this.setActY);
            this.groupTransform.Controls.Add(this.labelActEntX);
            this.groupTransform.Controls.Add(this.setActX);
            this.groupTransform.Controls.Add(this.labelActEntY);
            this.groupTransform.Controls.Add(this.textBoxActZ);
            this.groupTransform.Controls.Add(this.labelActEntZ);
            this.groupTransform.Controls.Add(this.textBoxActY);
            this.groupTransform.Controls.Add(this.actEntX);
            this.groupTransform.Controls.Add(this.textBoxActX);
            this.groupTransform.Controls.Add(this.actEntY);
            this.groupTransform.Controls.Add(this.actEntZ);
            this.groupTransform.Controls.Add(this.actEntFreezeZ);
            this.groupTransform.Controls.Add(this.actEntIncreaseX);
            this.groupTransform.Controls.Add(this.actEntFreezeY);
            this.groupTransform.Controls.Add(this.actEntIncreaseY);
            this.groupTransform.Controls.Add(this.actEntIncreaseZ);
            this.groupTransform.Controls.Add(this.actEntDecreaseZ);
            this.groupTransform.Controls.Add(this.actEntDecreaseX);
            this.groupTransform.Controls.Add(this.actEntDecreaseY);
            this.groupTransform.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupTransform.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupTransform.Location = new System.Drawing.Point(17, 6);
            this.groupTransform.Name = "groupTransform";
            this.groupTransform.Size = new System.Drawing.Size(443, 319);
            this.groupTransform.TabIndex = 58;
            this.groupTransform.TabStop = false;
            this.groupTransform.Text = "Transform";
            // 
            // charMovementBox
            // 
            this.charMovementBox.Controls.Add(this.vScrollBar1);
            this.charMovementBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charMovementBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.charMovementBox.Location = new System.Drawing.Point(10, 185);
            this.charMovementBox.Name = "charMovementBox";
            this.charMovementBox.Size = new System.Drawing.Size(418, 128);
            this.charMovementBox.TabIndex = 51;
            this.charMovementBox.TabStop = false;
            this.charMovementBox.Text = "Movement Values";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(400, 12);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 114);
            this.vScrollBar1.TabIndex = 0;
            // 
            // xyzTrackBar
            // 
            this.xyzTrackBar.AutoSize = false;
            this.xyzTrackBar.Location = new System.Drawing.Point(418, 29);
            this.xyzTrackBar.Maximum = 700;
            this.xyzTrackBar.Minimum = 50;
            this.xyzTrackBar.Name = "xyzTrackBar";
            this.xyzTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.xyzTrackBar.Size = new System.Drawing.Size(22, 82);
            this.xyzTrackBar.TabIndex = 46;
            this.xyzTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.xyzTrackBar.Value = 50;
            // 
            // setActZ
            // 
            this.setActZ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setActZ.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setActZ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.setActZ.Location = new System.Drawing.Point(290, 83);
            this.setActZ.Name = "setActZ";
            this.setActZ.Size = new System.Drawing.Size(33, 21);
            this.setActZ.TabIndex = 43;
            this.setActZ.Text = "Set";
            this.setActZ.UseVisualStyleBackColor = true;
            this.setActZ.Click += new System.EventHandler(this.setActZ_Click);
            // 
            // actEntFreezeX
            // 
            this.actEntFreezeX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.actEntFreezeX.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actEntFreezeX.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.actEntFreezeX.Location = new System.Drawing.Point(210, 35);
            this.actEntFreezeX.Name = "actEntFreezeX";
            this.actEntFreezeX.Size = new System.Drawing.Size(56, 21);
            this.actEntFreezeX.TabIndex = 34;
            this.actEntFreezeX.Text = "Freeze";
            this.actEntFreezeX.UseVisualStyleBackColor = true;
            this.actEntFreezeX.Click += new System.EventHandler(this.actEntFreezeX_Click);
            // 
            // setActY
            // 
            this.setActY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setActY.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setActY.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.setActY.Location = new System.Drawing.Point(290, 59);
            this.setActY.Name = "setActY";
            this.setActY.Size = new System.Drawing.Size(33, 21);
            this.setActY.TabIndex = 42;
            this.setActY.Text = "Set";
            this.setActY.UseVisualStyleBackColor = true;
            this.setActY.Click += new System.EventHandler(this.setActY_Click);
            // 
            // labelActEntX
            // 
            this.labelActEntX.AutoSize = true;
            this.labelActEntX.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActEntX.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelActEntX.Location = new System.Drawing.Point(6, 35);
            this.labelActEntX.Name = "labelActEntX";
            this.labelActEntX.Size = new System.Drawing.Size(30, 22);
            this.labelActEntX.TabIndex = 22;
            this.labelActEntX.Text = "X:";
            // 
            // setActX
            // 
            this.setActX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setActX.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setActX.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.setActX.Location = new System.Drawing.Point(290, 35);
            this.setActX.Name = "setActX";
            this.setActX.Size = new System.Drawing.Size(33, 21);
            this.setActX.TabIndex = 41;
            this.setActX.Text = "Set";
            this.setActX.UseVisualStyleBackColor = true;
            this.setActX.Click += new System.EventHandler(this.setActX_Click);
            // 
            // labelActEntY
            // 
            this.labelActEntY.AutoSize = true;
            this.labelActEntY.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActEntY.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelActEntY.Location = new System.Drawing.Point(7, 59);
            this.labelActEntY.Name = "labelActEntY";
            this.labelActEntY.Size = new System.Drawing.Size(30, 22);
            this.labelActEntY.TabIndex = 23;
            this.labelActEntY.Text = "Y:";
            // 
            // textBoxActZ
            // 
            this.textBoxActZ.BackColor = System.Drawing.Color.White;
            this.textBoxActZ.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxActZ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxActZ.Location = new System.Drawing.Point(327, 84);
            this.textBoxActZ.Name = "textBoxActZ";
            this.textBoxActZ.Size = new System.Drawing.Size(87, 20);
            this.textBoxActZ.TabIndex = 40;
            // 
            // labelActEntZ
            // 
            this.labelActEntZ.AutoSize = true;
            this.labelActEntZ.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActEntZ.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelActEntZ.Location = new System.Drawing.Point(7, 83);
            this.labelActEntZ.Name = "labelActEntZ";
            this.labelActEntZ.Size = new System.Drawing.Size(30, 22);
            this.labelActEntZ.TabIndex = 24;
            this.labelActEntZ.Text = "Z:";
            // 
            // textBoxActY
            // 
            this.textBoxActY.BackColor = System.Drawing.Color.White;
            this.textBoxActY.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxActY.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxActY.Location = new System.Drawing.Point(327, 60);
            this.textBoxActY.Name = "textBoxActY";
            this.textBoxActY.Size = new System.Drawing.Size(87, 20);
            this.textBoxActY.TabIndex = 39;
            // 
            // actEntX
            // 
            this.actEntX.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.actEntX.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actEntX.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.actEntX.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.actEntX.Location = new System.Drawing.Point(43, 35);
            this.actEntX.Name = "actEntX";
            this.actEntX.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.actEntX.Size = new System.Drawing.Size(140, 22);
            this.actEntX.TabIndex = 25;
            this.actEntX.Text = "???";
            this.actEntX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxActX
            // 
            this.textBoxActX.BackColor = System.Drawing.Color.White;
            this.textBoxActX.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxActX.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxActX.Location = new System.Drawing.Point(327, 36);
            this.textBoxActX.Name = "textBoxActX";
            this.textBoxActX.Size = new System.Drawing.Size(87, 20);
            this.textBoxActX.TabIndex = 38;
            // 
            // actEntY
            // 
            this.actEntY.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.actEntY.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actEntY.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.actEntY.Location = new System.Drawing.Point(43, 59);
            this.actEntY.Name = "actEntY";
            this.actEntY.Size = new System.Drawing.Size(140, 22);
            this.actEntY.TabIndex = 26;
            this.actEntY.Text = "???";
            this.actEntY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // actEntZ
            // 
            this.actEntZ.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.actEntZ.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actEntZ.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.actEntZ.Location = new System.Drawing.Point(43, 83);
            this.actEntZ.Name = "actEntZ";
            this.actEntZ.Size = new System.Drawing.Size(140, 22);
            this.actEntZ.TabIndex = 27;
            this.actEntZ.Text = "???";
            this.actEntZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // actEntFreezeZ
            // 
            this.actEntFreezeZ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.actEntFreezeZ.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actEntFreezeZ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.actEntFreezeZ.Location = new System.Drawing.Point(210, 83);
            this.actEntFreezeZ.Name = "actEntFreezeZ";
            this.actEntFreezeZ.Size = new System.Drawing.Size(56, 21);
            this.actEntFreezeZ.TabIndex = 36;
            this.actEntFreezeZ.Text = "Freeze";
            this.actEntFreezeZ.UseVisualStyleBackColor = true;
            this.actEntFreezeZ.Click += new System.EventHandler(this.actEntFreezeZ_Click);
            // 
            // actEntIncreaseX
            // 
            this.actEntIncreaseX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.actEntIncreaseX.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actEntIncreaseX.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.actEntIncreaseX.Location = new System.Drawing.Point(189, 35);
            this.actEntIncreaseX.Name = "actEntIncreaseX";
            this.actEntIncreaseX.Size = new System.Drawing.Size(18, 21);
            this.actEntIncreaseX.TabIndex = 28;
            this.actEntIncreaseX.Text = "+";
            this.actEntIncreaseX.UseVisualStyleBackColor = true;
            this.actEntIncreaseX.Click += new System.EventHandler(this.actEntIncreaseX_Click);
            // 
            // actEntFreezeY
            // 
            this.actEntFreezeY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.actEntFreezeY.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actEntFreezeY.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.actEntFreezeY.Location = new System.Drawing.Point(210, 59);
            this.actEntFreezeY.Name = "actEntFreezeY";
            this.actEntFreezeY.Size = new System.Drawing.Size(56, 21);
            this.actEntFreezeY.TabIndex = 35;
            this.actEntFreezeY.Text = "Freeze";
            this.actEntFreezeY.UseVisualStyleBackColor = true;
            this.actEntFreezeY.Click += new System.EventHandler(this.actEntFreezeY_Click);
            // 
            // actEntIncreaseY
            // 
            this.actEntIncreaseY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.actEntIncreaseY.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actEntIncreaseY.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.actEntIncreaseY.Location = new System.Drawing.Point(189, 59);
            this.actEntIncreaseY.Name = "actEntIncreaseY";
            this.actEntIncreaseY.Size = new System.Drawing.Size(18, 21);
            this.actEntIncreaseY.TabIndex = 29;
            this.actEntIncreaseY.Text = "+";
            this.actEntIncreaseY.UseVisualStyleBackColor = true;
            this.actEntIncreaseY.Click += new System.EventHandler(this.actEntIncreaseY_Click);
            // 
            // actEntIncreaseZ
            // 
            this.actEntIncreaseZ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.actEntIncreaseZ.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actEntIncreaseZ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.actEntIncreaseZ.Location = new System.Drawing.Point(189, 83);
            this.actEntIncreaseZ.Name = "actEntIncreaseZ";
            this.actEntIncreaseZ.Size = new System.Drawing.Size(18, 21);
            this.actEntIncreaseZ.TabIndex = 30;
            this.actEntIncreaseZ.Text = "+";
            this.actEntIncreaseZ.UseVisualStyleBackColor = true;
            this.actEntIncreaseZ.Click += new System.EventHandler(this.actEntIncreaseZ_Click);
            // 
            // actEntDecreaseZ
            // 
            this.actEntDecreaseZ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.actEntDecreaseZ.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actEntDecreaseZ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.actEntDecreaseZ.Location = new System.Drawing.Point(269, 83);
            this.actEntDecreaseZ.Name = "actEntDecreaseZ";
            this.actEntDecreaseZ.Size = new System.Drawing.Size(18, 21);
            this.actEntDecreaseZ.TabIndex = 33;
            this.actEntDecreaseZ.Text = "-";
            this.actEntDecreaseZ.UseVisualStyleBackColor = true;
            this.actEntDecreaseZ.Click += new System.EventHandler(this.actEntDecreaseZ_Click);
            // 
            // actEntDecreaseX
            // 
            this.actEntDecreaseX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.actEntDecreaseX.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actEntDecreaseX.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.actEntDecreaseX.Location = new System.Drawing.Point(269, 35);
            this.actEntDecreaseX.Name = "actEntDecreaseX";
            this.actEntDecreaseX.Size = new System.Drawing.Size(18, 21);
            this.actEntDecreaseX.TabIndex = 31;
            this.actEntDecreaseX.Text = "-";
            this.actEntDecreaseX.UseVisualStyleBackColor = true;
            this.actEntDecreaseX.Click += new System.EventHandler(this.actEntDecreaseX_Click);
            // 
            // actEntDecreaseY
            // 
            this.actEntDecreaseY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.actEntDecreaseY.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actEntDecreaseY.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.actEntDecreaseY.Location = new System.Drawing.Point(269, 59);
            this.actEntDecreaseY.Name = "actEntDecreaseY";
            this.actEntDecreaseY.Size = new System.Drawing.Size(18, 21);
            this.actEntDecreaseY.TabIndex = 32;
            this.actEntDecreaseY.Text = "-";
            this.actEntDecreaseY.UseVisualStyleBackColor = true;
            this.actEntDecreaseY.Click += new System.EventHandler(this.actEntDecreaseY_Click);
            // 
            // groupPowers
            // 
            this.groupPowers.Controls.Add(this.charmGold);
            this.groupPowers.Controls.Add(this.charmSilver);
            this.groupPowers.Controls.Add(this.guardIgnore);
            this.groupPowers.Controls.Add(this.godMode);
            this.groupPowers.Controls.Add(this.checkBoxInfJumps);
            this.groupPowers.Controls.Add(this.charmNone);
            this.groupPowers.Controls.Add(this.labelCharms);
            this.groupPowers.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPowers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupPowers.Location = new System.Drawing.Point(471, 110);
            this.groupPowers.Name = "groupPowers";
            this.groupPowers.Size = new System.Drawing.Size(310, 215);
            this.groupPowers.TabIndex = 57;
            this.groupPowers.TabStop = false;
            this.groupPowers.Text = "Powers";
            // 
            // charmGold
            // 
            this.charmGold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.charmGold.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charmGold.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.charmGold.Location = new System.Drawing.Point(231, 30);
            this.charmGold.Name = "charmGold";
            this.charmGold.Size = new System.Drawing.Size(57, 26);
            this.charmGold.TabIndex = 61;
            this.charmGold.Text = "Gold";
            this.charmGold.UseVisualStyleBackColor = true;
            // 
            // charmSilver
            // 
            this.charmSilver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.charmSilver.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charmSilver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.charmSilver.Location = new System.Drawing.Point(153, 30);
            this.charmSilver.Name = "charmSilver";
            this.charmSilver.Size = new System.Drawing.Size(72, 26);
            this.charmSilver.TabIndex = 60;
            this.charmSilver.Text = "Silver";
            this.charmSilver.UseVisualStyleBackColor = true;
            // 
            // guardIgnore
            // 
            this.guardIgnore.AutoSize = true;
            this.guardIgnore.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardIgnore.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guardIgnore.Location = new System.Drawing.Point(14, 81);
            this.guardIgnore.Name = "guardIgnore";
            this.guardIgnore.Size = new System.Drawing.Size(145, 23);
            this.guardIgnore.TabIndex = 59;
            this.guardIgnore.Text = "Guards Ignore";
            this.guardIgnore.UseVisualStyleBackColor = true;
            this.guardIgnore.CheckedChanged += new System.EventHandler(this.guardIgnore_CheckedChanged);
            // 
            // godMode
            // 
            this.godMode.AutoSize = true;
            this.godMode.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.godMode.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.godMode.Location = new System.Drawing.Point(14, 57);
            this.godMode.Name = "godMode";
            this.godMode.Size = new System.Drawing.Size(100, 23);
            this.godMode.TabIndex = 58;
            this.godMode.Text = "God Mode";
            this.godMode.UseVisualStyleBackColor = true;
            this.godMode.CheckedChanged += new System.EventHandler(this.godMode_CheckedChanged);
            // 
            // checkBoxInfJumps
            // 
            this.checkBoxInfJumps.AutoSize = true;
            this.checkBoxInfJumps.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxInfJumps.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBoxInfJumps.Location = new System.Drawing.Point(14, 105);
            this.checkBoxInfJumps.Name = "checkBoxInfJumps";
            this.checkBoxInfJumps.Size = new System.Drawing.Size(154, 23);
            this.checkBoxInfJumps.TabIndex = 48;
            this.checkBoxInfJumps.Text = "Infinite Jumps";
            this.checkBoxInfJumps.UseVisualStyleBackColor = true;
            this.checkBoxInfJumps.CheckedChanged += new System.EventHandler(this.checkBoxInfJumps_CheckedChanged);
            // 
            // charmNone
            // 
            this.charmNone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.charmNone.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charmNone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.charmNone.Location = new System.Drawing.Point(86, 30);
            this.charmNone.Name = "charmNone";
            this.charmNone.Size = new System.Drawing.Size(61, 26);
            this.charmNone.TabIndex = 53;
            this.charmNone.Text = "None";
            this.charmNone.UseVisualStyleBackColor = true;
            // 
            // labelCharms
            // 
            this.labelCharms.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCharms.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCharms.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelCharms.Location = new System.Drawing.Point(10, 32);
            this.labelCharms.Name = "labelCharms";
            this.labelCharms.Size = new System.Drawing.Size(70, 22);
            this.labelCharms.TabIndex = 52;
            this.labelCharms.Text = "Charm";
            this.labelCharms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonMoves
            // 
            this.buttonMoves.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMoves.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoves.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonMoves.Location = new System.Drawing.Point(652, 12);
            this.buttonMoves.Name = "buttonMoves";
            this.buttonMoves.Size = new System.Drawing.Size(129, 29);
            this.buttonMoves.TabIndex = 56;
            this.buttonMoves.Text = "Unlock Moves";
            this.buttonMoves.UseVisualStyleBackColor = true;
            this.buttonMoves.Click += new System.EventHandler(this.buttonMoves_Click);
            // 
            // engineTab
            // 
            this.engineTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.engineTab.Controls.Add(this.checkGuardAI);
            this.engineTab.Controls.Add(this.reloadLang);
            this.engineTab.Controls.Add(this.currentLang);
            this.engineTab.Controls.Add(this.labelLang);
            this.engineTab.Controls.Add(this.langSelector);
            this.engineTab.Controls.Add(this.drawFreeze);
            this.engineTab.Controls.Add(this.fovFreeze);
            this.engineTab.Controls.Add(this.warpComboBox);
            this.engineTab.Controls.Add(this.resetDraw);
            this.engineTab.Controls.Add(this.labelDraw);
            this.engineTab.Controls.Add(this.trackBarDraw);
            this.engineTab.Controls.Add(this.resetFOV);
            this.engineTab.Controls.Add(this.labelFOV);
            this.engineTab.Controls.Add(this.trackBarFOV);
            this.engineTab.Controls.Add(this.resetGameClock);
            this.engineTab.Controls.Add(this.labelFieldClock);
            this.engineTab.Controls.Add(this.trackBarGameClock);
            this.engineTab.Controls.Add(this.currentMap);
            this.engineTab.Controls.Add(this.labelMap);
            this.engineTab.Controls.Add(this.levelComboBox);
            this.engineTab.Controls.Add(this.warpButton);
            this.engineTab.Controls.Add(this.reloadLvl);
            this.engineTab.Location = new System.Drawing.Point(4, 4);
            this.engineTab.Name = "engineTab";
            this.engineTab.Size = new System.Drawing.Size(793, 342);
            this.engineTab.TabIndex = 2;
            this.engineTab.Text = "Engine";
            // 
            // checkGuardAI
            // 
            this.checkGuardAI.AutoSize = true;
            this.checkGuardAI.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkGuardAI.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkGuardAI.Location = new System.Drawing.Point(19, 299);
            this.checkGuardAI.Name = "checkGuardAI";
            this.checkGuardAI.Size = new System.Drawing.Size(100, 23);
            this.checkGuardAI.TabIndex = 58;
            this.checkGuardAI.Text = "Guard AI";
            this.checkGuardAI.UseVisualStyleBackColor = true;
            this.checkGuardAI.CheckedChanged += new System.EventHandler(this.checkGuardAI_CheckedChanged);
            // 
            // reloadLang
            // 
            this.reloadLang.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reloadLang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reloadLang.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloadLang.Location = new System.Drawing.Point(694, 299);
            this.reloadLang.Name = "reloadLang";
            this.reloadLang.Size = new System.Drawing.Size(81, 29);
            this.reloadLang.TabIndex = 50;
            this.reloadLang.Text = "Apply";
            this.reloadLang.UseVisualStyleBackColor = true;
            this.reloadLang.Click += new System.EventHandler(this.reloadLang_Click);
            // 
            // currentLang
            // 
            this.currentLang.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLang.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.currentLang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.currentLang.Location = new System.Drawing.Point(553, 274);
            this.currentLang.Name = "currentLang";
            this.currentLang.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.currentLang.Size = new System.Drawing.Size(225, 22);
            this.currentLang.TabIndex = 49;
            this.currentLang.Text = "???";
            this.currentLang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelLang
            // 
            this.labelLang.AutoSize = true;
            this.labelLang.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLang.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLang.Location = new System.Drawing.Point(436, 273);
            this.labelLang.Name = "labelLang";
            this.labelLang.Size = new System.Drawing.Size(90, 22);
            this.labelLang.TabIndex = 48;
            this.labelLang.Text = "Language";
            // 
            // langSelector
            // 
            this.langSelector.DropDownHeight = 160;
            this.langSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.langSelector.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.langSelector.FormattingEnabled = true;
            this.langSelector.IntegralHeight = false;
            this.langSelector.Items.AddRange(new object[] {
            "English",
            "Français",
            "Deutsch",
            "Español",
            "Italiano",
            "Nederlands",
            "Português",
            "Dansk",
            "Suomalainen",
            "Norsk",
            "Svensk"});
            this.langSelector.Location = new System.Drawing.Point(440, 302);
            this.langSelector.Name = "langSelector";
            this.langSelector.Size = new System.Drawing.Size(248, 23);
            this.langSelector.TabIndex = 47;
            // 
            // drawFreeze
            // 
            this.drawFreeze.AutoSize = true;
            this.drawFreeze.BackColor = System.Drawing.Color.Transparent;
            this.drawFreeze.Location = new System.Drawing.Point(661, 58);
            this.drawFreeze.Name = "drawFreeze";
            this.drawFreeze.Size = new System.Drawing.Size(15, 14);
            this.drawFreeze.TabIndex = 45;
            this.drawFreeze.UseVisualStyleBackColor = false;
            // 
            // fovFreeze
            // 
            this.fovFreeze.AutoSize = true;
            this.fovFreeze.BackColor = System.Drawing.Color.Transparent;
            this.fovFreeze.Location = new System.Drawing.Point(661, 28);
            this.fovFreeze.Name = "fovFreeze";
            this.fovFreeze.Size = new System.Drawing.Size(15, 14);
            this.fovFreeze.TabIndex = 44;
            this.fovFreeze.UseVisualStyleBackColor = false;
            // 
            // warpComboBox
            // 
            this.warpComboBox.DropDownHeight = 160;
            this.warpComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.warpComboBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warpComboBox.FormattingEnabled = true;
            this.warpComboBox.IntegralHeight = false;
            this.warpComboBox.Location = new System.Drawing.Point(19, 75);
            this.warpComboBox.Name = "warpComboBox";
            this.warpComboBox.Size = new System.Drawing.Size(248, 23);
            this.warpComboBox.TabIndex = 42;
            // 
            // resetDraw
            // 
            this.resetDraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetDraw.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetDraw.Location = new System.Drawing.Point(610, 54);
            this.resetDraw.Name = "resetDraw";
            this.resetDraw.Size = new System.Drawing.Size(46, 20);
            this.resetDraw.TabIndex = 36;
            this.resetDraw.Text = "Reset";
            this.resetDraw.UseVisualStyleBackColor = true;
            // 
            // labelDraw
            // 
            this.labelDraw.AutoSize = true;
            this.labelDraw.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDraw.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDraw.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelDraw.Location = new System.Drawing.Point(438, 54);
            this.labelDraw.Name = "labelDraw";
            this.labelDraw.Size = new System.Drawing.Size(140, 22);
            this.labelDraw.TabIndex = 35;
            this.labelDraw.Text = "Draw Distance";
            this.labelDraw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trackBarDraw
            // 
            this.trackBarDraw.Location = new System.Drawing.Point(672, 52);
            this.trackBarDraw.Name = "trackBarDraw";
            this.trackBarDraw.Size = new System.Drawing.Size(104, 45);
            this.trackBarDraw.TabIndex = 34;
            // 
            // resetFOV
            // 
            this.resetFOV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetFOV.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetFOV.Location = new System.Drawing.Point(610, 24);
            this.resetFOV.Name = "resetFOV";
            this.resetFOV.Size = new System.Drawing.Size(46, 20);
            this.resetFOV.TabIndex = 33;
            this.resetFOV.Text = "Reset";
            this.resetFOV.UseVisualStyleBackColor = true;
            // 
            // labelFOV
            // 
            this.labelFOV.AutoSize = true;
            this.labelFOV.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFOV.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelFOV.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelFOV.Location = new System.Drawing.Point(438, 24);
            this.labelFOV.Name = "labelFOV";
            this.labelFOV.Size = new System.Drawing.Size(40, 22);
            this.labelFOV.TabIndex = 32;
            this.labelFOV.Text = "FOV";
            this.labelFOV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trackBarFOV
            // 
            this.trackBarFOV.Location = new System.Drawing.Point(672, 22);
            this.trackBarFOV.Name = "trackBarFOV";
            this.trackBarFOV.Size = new System.Drawing.Size(104, 45);
            this.trackBarFOV.TabIndex = 31;
            // 
            // resetGameClock
            // 
            this.resetGameClock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetGameClock.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetGameClock.Location = new System.Drawing.Point(230, 114);
            this.resetGameClock.Name = "resetGameClock";
            this.resetGameClock.Size = new System.Drawing.Size(46, 20);
            this.resetGameClock.TabIndex = 27;
            this.resetGameClock.Text = "Reset";
            this.resetGameClock.UseVisualStyleBackColor = true;
            // 
            // labelFieldClock
            // 
            this.labelFieldClock.AutoSize = true;
            this.labelFieldClock.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFieldClock.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelFieldClock.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelFieldClock.Location = new System.Drawing.Point(15, 113);
            this.labelFieldClock.Name = "labelFieldClock";
            this.labelFieldClock.Size = new System.Drawing.Size(110, 22);
            this.labelFieldClock.TabIndex = 26;
            this.labelFieldClock.Text = "Game Clock";
            this.labelFieldClock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trackBarGameClock
            // 
            this.trackBarGameClock.Location = new System.Drawing.Point(122, 113);
            this.trackBarGameClock.Maximum = 500;
            this.trackBarGameClock.Minimum = 50;
            this.trackBarGameClock.Name = "trackBarGameClock";
            this.trackBarGameClock.Size = new System.Drawing.Size(104, 45);
            this.trackBarGameClock.TabIndex = 25;
            this.trackBarGameClock.Value = 50;
            this.trackBarGameClock.ValueChanged += new System.EventHandler(this.trackBarGameClock_ValueChanged);
            // 
            // currentMap
            // 
            this.currentMap.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentMap.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.currentMap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.currentMap.Location = new System.Drawing.Point(132, 14);
            this.currentMap.Name = "currentMap";
            this.currentMap.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.currentMap.Size = new System.Drawing.Size(225, 22);
            this.currentMap.TabIndex = 23;
            this.currentMap.Text = "???";
            this.currentMap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMap
            // 
            this.labelMap.AutoSize = true;
            this.labelMap.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMap.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelMap.Location = new System.Drawing.Point(15, 13);
            this.labelMap.Name = "labelMap";
            this.labelMap.Size = new System.Drawing.Size(120, 22);
            this.labelMap.TabIndex = 22;
            this.labelMap.Text = "Current Map";
            // 
            // levelComboBox
            // 
            this.levelComboBox.DropDownHeight = 160;
            this.levelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.levelComboBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelComboBox.FormattingEnabled = true;
            this.levelComboBox.IntegralHeight = false;
            this.levelComboBox.Items.AddRange(new object[] {
            "Cairo",
            "Main Menu",
            "Paris Hub",
            "    Wine Cellar (Door)",
            "    Wine Cellar (Lasers)",
            "    Nightclub (Back Door)",
            "    Nightclub (Window)",
            "    Print Room (Recon)",
            "    Print Room (Bossfight)",
            "    Theater",
            "    Water Pump Room",
            "India Hub",
            "    Hotel (Front Door)",
            "    Hotel (Entrance 2)",
            "    Hotel (Entrance 3)",
            "    Hotel (Entrance 4)",
            "    Palace Basement",
            "    Ballroom",
            "India 2 Hub",
            "    Spice Factory (Bottom)",
            "    Spice Factory (Top)",
            "    Spice Factory (Grinder)",
            "    Spice Factory (Rajan\'s Office)",
            "Prague Hub",
            "    Prison (Murray\'s Cell)",
            "    Prison",
            "    Vault Room",
            "Prague 2 Hub",
            "    Crypt 1 (Stealing Voices)",
            "    Crypt 2 (Stealing Voices)",
            "    Crypt 3 (Stealing Voices)",
            "    Crypt (Ghost Capture)",
            "    Re-education Tower",
            "    Crypt Hack",
            "    Crypt 1 (Mojo Trap)",
            "    Crypt 2 (Mojo Trap)",
            "    Crypt 3 (Mojo Trap)",
            "    Crypt 4 (Mojo Trap)",
            "Canada Hub",
            "    Cabin 1",
            "    Cabin 2",
            "    Cabin 3",
            "    Train (Aerial Assault)",
            "    Train (Theft on Rails)",
            "    Train (Ride the Iron Horse)",
            "    Train (Operation)",
            "Canada 2 Hub",
            "    RC Combat Club",
            "    Sawmill",
            "    Lighthouse",
            "    Bear Cave",
            "    Sawmill (Bossfight)",
            "Blimp Hub",
            "    Blimp Headquarters",
            "    Engine Room 1",
            "    Engine Room 2",
            "    Engine Room 3",
            "    Paris (Finale)"});
            this.levelComboBox.Location = new System.Drawing.Point(19, 42);
            this.levelComboBox.Name = "levelComboBox";
            this.levelComboBox.Size = new System.Drawing.Size(248, 23);
            this.levelComboBox.TabIndex = 2;
            // 
            // warpButton
            // 
            this.warpButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.warpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.warpButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warpButton.Location = new System.Drawing.Point(272, 73);
            this.warpButton.Name = "warpButton";
            this.warpButton.Size = new System.Drawing.Size(81, 27);
            this.warpButton.TabIndex = 1;
            this.warpButton.Text = "Warp";
            this.warpButton.UseVisualStyleBackColor = true;
            this.warpButton.Click += new System.EventHandler(this.warpButton_Click);
            // 
            // reloadLvl
            // 
            this.reloadLvl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reloadLvl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reloadLvl.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloadLvl.Location = new System.Drawing.Point(272, 39);
            this.reloadLvl.Name = "reloadLvl";
            this.reloadLvl.Size = new System.Drawing.Size(81, 29);
            this.reloadLvl.TabIndex = 0;
            this.reloadLvl.Text = "Load";
            this.reloadLvl.UseVisualStyleBackColor = true;
            this.reloadLvl.Click += new System.EventHandler(this.reloadLvl_Click);
            // 
            // miscTab
            // 
            this.miscTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.miscTab.Controls.Add(this.clueScriptButton);
            this.miscTab.Controls.Add(this.miscBox);
            this.miscTab.Controls.Add(this.weedButton);
            this.miscTab.Location = new System.Drawing.Point(4, 4);
            this.miscTab.Margin = new System.Windows.Forms.Padding(8);
            this.miscTab.Name = "miscTab";
            this.miscTab.Size = new System.Drawing.Size(793, 342);
            this.miscTab.TabIndex = 4;
            this.miscTab.Text = "Misc.";
            // 
            // clueScriptButton
            // 
            this.clueScriptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clueScriptButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clueScriptButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clueScriptButton.Location = new System.Drawing.Point(630, 14);
            this.clueScriptButton.Name = "clueScriptButton";
            this.clueScriptButton.Size = new System.Drawing.Size(155, 29);
            this.clueScriptButton.TabIndex = 44;
            this.clueScriptButton.Text = "Clue Script";
            this.clueScriptButton.UseVisualStyleBackColor = true;
            this.clueScriptButton.Click += new System.EventHandler(this.clueScriptButton_Click);
            // 
            // miscBox
            // 
            this.miscBox.Controls.Add(this.groupMusic);
            this.miscBox.Controls.Add(this.disableTextures);
            this.miscBox.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miscBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.miscBox.Location = new System.Drawing.Point(12, 14);
            this.miscBox.Name = "miscBox";
            this.miscBox.Size = new System.Drawing.Size(612, 317);
            this.miscBox.TabIndex = 43;
            this.miscBox.TabStop = false;
            this.miscBox.Text = "Miscellanenous";
            // 
            // groupMusic
            // 
            this.groupMusic.Controls.Add(this.labelMusicState);
            this.groupMusic.Controls.Add(this.labelMusicVol);
            this.groupMusic.Controls.Add(this.musicVolume);
            this.groupMusic.Controls.Add(this.normalMusic);
            this.groupMusic.Controls.Add(this.sneakMusic);
            this.groupMusic.Controls.Add(this.battleMusic);
            this.groupMusic.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupMusic.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupMusic.Location = new System.Drawing.Point(433, 18);
            this.groupMusic.Name = "groupMusic";
            this.groupMusic.Size = new System.Drawing.Size(163, 196);
            this.groupMusic.TabIndex = 52;
            this.groupMusic.TabStop = false;
            this.groupMusic.Text = "Music";
            // 
            // labelMusicState
            // 
            this.labelMusicState.AutoSize = true;
            this.labelMusicState.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMusicState.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelMusicState.Location = new System.Drawing.Point(12, 28);
            this.labelMusicState.Name = "labelMusicState";
            this.labelMusicState.Size = new System.Drawing.Size(60, 22);
            this.labelMusicState.TabIndex = 54;
            this.labelMusicState.Text = "State";
            // 
            // labelMusicVol
            // 
            this.labelMusicVol.AutoSize = true;
            this.labelMusicVol.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMusicVol.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelMusicVol.Location = new System.Drawing.Point(12, 137);
            this.labelMusicVol.Name = "labelMusicVol";
            this.labelMusicVol.Size = new System.Drawing.Size(70, 22);
            this.labelMusicVol.TabIndex = 53;
            this.labelMusicVol.Text = "Volume";
            // 
            // musicVolume
            // 
            this.musicVolume.AutoSize = false;
            this.musicVolume.Location = new System.Drawing.Point(7, 162);
            this.musicVolume.Name = "musicVolume";
            this.musicVolume.Size = new System.Drawing.Size(143, 24);
            this.musicVolume.TabIndex = 52;
            this.musicVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // normalMusic
            // 
            this.normalMusic.AutoSize = true;
            this.normalMusic.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalMusic.Location = new System.Drawing.Point(16, 53);
            this.normalMusic.Name = "normalMusic";
            this.normalMusic.Size = new System.Drawing.Size(81, 23);
            this.normalMusic.TabIndex = 50;
            this.normalMusic.TabStop = true;
            this.normalMusic.Text = "Normal";
            this.normalMusic.UseVisualStyleBackColor = true;
            // 
            // sneakMusic
            // 
            this.sneakMusic.AutoSize = true;
            this.sneakMusic.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sneakMusic.Location = new System.Drawing.Point(16, 103);
            this.sneakMusic.Name = "sneakMusic";
            this.sneakMusic.Size = new System.Drawing.Size(72, 23);
            this.sneakMusic.TabIndex = 51;
            this.sneakMusic.TabStop = true;
            this.sneakMusic.Text = "Sneak";
            this.sneakMusic.UseVisualStyleBackColor = true;
            // 
            // battleMusic
            // 
            this.battleMusic.AutoSize = true;
            this.battleMusic.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.battleMusic.Location = new System.Drawing.Point(16, 78);
            this.battleMusic.Name = "battleMusic";
            this.battleMusic.Size = new System.Drawing.Size(81, 23);
            this.battleMusic.TabIndex = 49;
            this.battleMusic.TabStop = true;
            this.battleMusic.Text = "Battle";
            this.battleMusic.UseVisualStyleBackColor = true;
            // 
            // disableTextures
            // 
            this.disableTextures.AutoSize = true;
            this.disableTextures.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disableTextures.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.disableTextures.Location = new System.Drawing.Point(16, 35);
            this.disableTextures.Name = "disableTextures";
            this.disableTextures.Size = new System.Drawing.Size(172, 23);
            this.disableTextures.TabIndex = 48;
            this.disableTextures.Text = "Disable Textures";
            this.disableTextures.UseVisualStyleBackColor = true;
            // 
            // weedButton
            // 
            this.weedButton.BackColor = System.Drawing.Color.Transparent;
            this.weedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.weedButton.Image = global::syhax.Properties.Resources.weed;
            this.weedButton.InitialImage = null;
            this.weedButton.Location = new System.Drawing.Point(714, 270);
            this.weedButton.Name = "weedButton";
            this.weedButton.Size = new System.Drawing.Size(68, 61);
            this.weedButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.weedButton.TabIndex = 42;
            this.weedButton.TabStop = false;
            this.weedButton.Click += new System.EventHandler(this.weedButton_Click);
            // 
            // labelAttached
            // 
            this.labelAttached.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAttached.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAttached.ForeColor = System.Drawing.Color.Red;
            this.labelAttached.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelAttached.Location = new System.Drawing.Point(586, 12);
            this.labelAttached.Name = "labelAttached";
            this.labelAttached.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelAttached.Size = new System.Drawing.Size(230, 22);
            this.labelAttached.TabIndex = 38;
            this.labelAttached.Text = "NOT ATTACHED";
            this.labelAttached.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // currentGame
            // 
            this.currentGame.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentGame.ForeColor = System.Drawing.Color.Red;
            this.currentGame.Location = new System.Drawing.Point(12, 12);
            this.currentGame.Name = "currentGame";
            this.currentGame.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.currentGame.Size = new System.Drawing.Size(640, 22);
            this.currentGame.TabIndex = 40;
            this.currentGame.Text = "No Game";
            this.currentGame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // syhaxLogo
            // 
            this.syhaxLogo.ActiveLinkColor = System.Drawing.Color.MediumTurquoise;
            this.syhaxLogo.AutoSize = true;
            this.syhaxLogo.BackColor = System.Drawing.Color.Transparent;
            this.syhaxLogo.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.syhaxLogo.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.syhaxLogo.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.syhaxLogo.LinkColor = System.Drawing.SystemColors.InactiveCaption;
            this.syhaxLogo.Location = new System.Drawing.Point(754, 386);
            this.syhaxLogo.Name = "syhaxLogo";
            this.syhaxLogo.Size = new System.Drawing.Size(60, 22);
            this.syhaxLogo.TabIndex = 43;
            this.syhaxLogo.TabStop = true;
            this.syhaxLogo.Text = "syhax";
            this.syhaxLogo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // syhax1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(822, 412);
            this.Controls.Add(this.syhaxLogo);
            this.Controls.Add(this.currentGame);
            this.Controls.Add(this.labelAttached);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(842, 455);
            this.MinimumSize = new System.Drawing.Size(842, 455);
            this.Name = "syhax1";
            this.Text = "syhax";
            this.Load += new System.EventHandler(this.syhax1_Load);
            this.tabControl1.ResumeLayout(false);
            this.slyTab.ResumeLayout(false);
            this.groupTransform.ResumeLayout(false);
            this.groupTransform.PerformLayout();
            this.charMovementBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xyzTrackBar)).EndInit();
            this.groupPowers.ResumeLayout(false);
            this.groupPowers.PerformLayout();
            this.engineTab.ResumeLayout(false);
            this.engineTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDraw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFOV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGameClock)).EndInit();
            this.miscTab.ResumeLayout(false);
            this.miscBox.ResumeLayout(false);
            this.miscBox.PerformLayout();
            this.groupMusic.ResumeLayout(false);
            this.groupMusic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weedButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage slyTab;
        private System.Windows.Forms.TabPage engineTab;
        private System.Windows.Forms.Button reloadLvl;
        private System.Windows.Forms.Button actEntFreezeZ;
        private System.Windows.Forms.Button actEntFreezeY;
        private System.Windows.Forms.Button actEntFreezeX;
        private System.Windows.Forms.Button actEntDecreaseZ;
        private System.Windows.Forms.Button actEntDecreaseY;
        private System.Windows.Forms.Button actEntDecreaseX;
        private System.Windows.Forms.Button actEntIncreaseZ;
        private System.Windows.Forms.Button actEntIncreaseY;
        private System.Windows.Forms.Button actEntIncreaseX;
        private System.Windows.Forms.Label actEntZ;
        private System.Windows.Forms.Label actEntY;
        private System.Windows.Forms.Label actEntX;
        private System.Windows.Forms.Label labelActEntZ;
        private System.Windows.Forms.Label labelActEntY;
        private System.Windows.Forms.Label labelActEntX;
        private System.Windows.Forms.Button warpButton;
        private System.Windows.Forms.ComboBox levelComboBox;
        private System.Windows.Forms.Label currentMap;
        private System.Windows.Forms.Label labelMap;
        private System.Windows.Forms.Label labelAttached;
        private System.Windows.Forms.Label currentGame;
        private System.Windows.Forms.TextBox textBoxActX;
        private System.Windows.Forms.TextBox textBoxActZ;
        private System.Windows.Forms.TextBox textBoxActY;
        private System.Windows.Forms.Button setActZ;
        private System.Windows.Forms.Button setActY;
        private System.Windows.Forms.Button setActX;
        private System.Windows.Forms.TrackBar xyzTrackBar;
        private System.Windows.Forms.CheckBox checkBoxInfJumps;
        private System.Windows.Forms.Button resetGameClock;
        private System.Windows.Forms.Label labelFieldClock;
        private System.Windows.Forms.TrackBar trackBarGameClock;
        private System.Windows.Forms.Button resetFOV;
        private System.Windows.Forms.Label labelFOV;
        private System.Windows.Forms.TrackBar trackBarFOV;
        private System.Windows.Forms.Button resetDraw;
        private System.Windows.Forms.Label labelDraw;
        private System.Windows.Forms.TrackBar trackBarDraw;
        private System.Windows.Forms.TabPage miscTab;
        private System.Windows.Forms.ComboBox warpComboBox;
        private System.Windows.Forms.LinkLabel syhaxLogo;
        private System.Windows.Forms.CheckBox drawFreeze;
        private System.Windows.Forms.CheckBox fovFreeze;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox charMovementBox;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.PictureBox weedButton;
        private System.Windows.Forms.GroupBox miscBox;
        private System.Windows.Forms.Label currentLang;
        private System.Windows.Forms.Label labelLang;
        private System.Windows.Forms.ComboBox langSelector;
        private System.Windows.Forms.CheckBox disableTextures;
        private System.Windows.Forms.Button reloadLang;
        private System.Windows.Forms.CheckBox checkGuardAI;
        private System.Windows.Forms.GroupBox groupMusic;
        private System.Windows.Forms.Label labelMusicVol;
        private System.Windows.Forms.TrackBar musicVolume;
        private System.Windows.Forms.RadioButton normalMusic;
        private System.Windows.Forms.RadioButton sneakMusic;
        private System.Windows.Forms.RadioButton battleMusic;
        private System.Windows.Forms.Label labelMusicState;
        private System.Windows.Forms.Label labelCharms;
        private System.Windows.Forms.Button charmNone;
        private System.Windows.Forms.Button buttonMoves;
        private System.Windows.Forms.Button clueScriptButton;
        private System.Windows.Forms.GroupBox groupPowers;
        private System.Windows.Forms.GroupBox groupTransform;
        private System.Windows.Forms.CheckBox godMode;
        private System.Windows.Forms.CheckBox guardIgnore;
        private System.Windows.Forms.Button charmGold;
        private System.Windows.Forms.Button charmSilver;
    }
}

