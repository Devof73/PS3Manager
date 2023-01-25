

using System.Drawing;
using PSS3;
using ChangableMenuListView = PSS3.ChangableMenuListView;
namespace PSS3.Forms
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.TextBoxComment = new System.Windows.Forms.TextBox();
            this.ButtonOptions = new Guna.UI2.WinForms.Guna2Button();
            this.LabelLogMessage = new System.Windows.Forms.Label();
            this.ProgressBar = new MetroFramework.Controls.MetroProgressSpinner();
            this.ButtonStore = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonImgSignOut = new Guna.UI2.WinForms.Guna2ImageButton();
            this.LabelPsnId = new System.Windows.Forms.Label();
            this.IconAvatar = new System.Windows.Forms.PictureBox();
            this.ContextStripOptions = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.pS3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sysInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.privateInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discordOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tESTMSGFORMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.TopperPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.ButtonPower = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.NumericRefreshInterval = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this._TC_MainContainer = new Guna.UI2.WinForms.Guna2TabControl();
            this._TC_DASHBOARD_STATUS = new System.Windows.Forms.TabPage();
            this.LabelInfoFirmType = new System.Windows.Forms.Label();
            this.LabelSysName = new System.Windows.Forms.Label();
            this.PB_PS3ICON = new Guna.UI2.WinForms.Guna2PictureBox();
            this.LabelInfoHdd = new System.Windows.Forms.Label();
            this.LabelInfoMem = new System.Windows.Forms.Label();
            this.XmbImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.LabelInfoTemp = new System.Windows.Forms.Label();
            this.guna2Separator8 = new Guna.UI2.WinForms.Guna2Separator();
            this.LabelInfoLife = new System.Windows.Forms.Label();
            this.LabelInfoFan = new System.Windows.Forms.Label();
            this.ButtonUpdate = new Guna.UI2.WinForms.Guna2ImageButton();
            this.LabelInfoFirmware = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelGameTitle = new System.Windows.Forms.Label();
            this.LabelGameElapsed = new System.Windows.Forms.Label();
            this.LabelSysTime = new System.Windows.Forms.Label();
            this._TC_DASHBOARD_GAMELIST = new System.Windows.Forms.TabPage();
            this._TC_DASHBOARD_FRIENDLIST = new System.Windows.Forms.TabPage();
            this.ListViewFriends = new System.Windows.Forms.ListView();
            this.StatusStripFriendsMenu = new System.Windows.Forms.StatusStrip();
            this.TTSL_FriendCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.TTSL_SelDat = new System.Windows.Forms.ToolStripStatusLabel();
            this.TTSL_DumpFriendAvatar = new System.Windows.Forms.ToolStripStatusLabel();
            this._TC_DASHBOARD_SAVEGAMELIST = new System.Windows.Forms.TabPage();
            this.SC_SAVDAT_CONTAINER = new System.Windows.Forms.SplitContainer();
            this.ListViewSaves = new System.Windows.Forms.ListView();
            this.SaveDatInfoPanel = new System.Windows.Forms.Panel();
            this.PB_SAVDATICO = new System.Windows.Forms.PictureBox();
            this.RTB_SAVDATINFO = new System.Windows.Forms.RichTextBox();
            this._TC_DASHBOARD_MAPI = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_prx_1 = new Guna.UI2.WinForms.Guna2Button();
            this.LBL_PRX6 = new System.Windows.Forms.Label();
            this.LBL_PRX5 = new System.Windows.Forms.Label();
            this.LBL_PRX4 = new System.Windows.Forms.Label();
            this.LBL_PRX3 = new System.Windows.Forms.Label();
            this.LBL_PRX2 = new System.Windows.Forms.Label();
            this.LBL_PRX1 = new System.Windows.Forms.Label();
            this.txt_prx_6 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_prx_5 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_prx_4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_prx_3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_prx_2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_prx_1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Separator4 = new Guna.UI2.WinForms.Guna2Separator();
            this.LabelHeader3 = new System.Windows.Forms.Label();
            this.guna2Separator5 = new Guna.UI2.WinForms.Guna2Separator();
            this.ContextStripPower = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.powerOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartFullACToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.GameListSelectedContextMenuStrip = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.GameListSelectedGameTitleToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameCoverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nPMountWBMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestUninstallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPARAMSFOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TXT_MAPI_NOTIFY = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label10 = new System.Windows.Forms.Label();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.ButtonSendNotify = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ListViewGames = new PSS3.ChangableMenuListView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IconAvatar)).BeginInit();
            this.ContextStripOptions.SuspendLayout();
            this.TopperPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericRefreshInterval)).BeginInit();
            this._TC_MainContainer.SuspendLayout();
            this._TC_DASHBOARD_STATUS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_PS3ICON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XmbImage)).BeginInit();
            this._TC_DASHBOARD_GAMELIST.SuspendLayout();
            this._TC_DASHBOARD_FRIENDLIST.SuspendLayout();
            this.StatusStripFriendsMenu.SuspendLayout();
            this._TC_DASHBOARD_SAVEGAMELIST.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SC_SAVDAT_CONTAINER)).BeginInit();
            this.SC_SAVDAT_CONTAINER.Panel1.SuspendLayout();
            this.SC_SAVDAT_CONTAINER.Panel2.SuspendLayout();
            this.SC_SAVDAT_CONTAINER.SuspendLayout();
            this.SaveDatInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_SAVDATICO)).BeginInit();
            this._TC_DASHBOARD_MAPI.SuspendLayout();
            this.panel4.SuspendLayout();
            this.ContextStripPower.SuspendLayout();
            this.GameListSelectedContextMenuStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxComment
            // 
            this.TextBoxComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.TextBoxComment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxComment.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxComment.ForeColor = System.Drawing.Color.White;
            this.TextBoxComment.Location = new System.Drawing.Point(103, 47);
            this.TextBoxComment.Name = "TextBoxComment";
            this.TextBoxComment.Size = new System.Drawing.Size(171, 20);
            this.TextBoxComment.TabIndex = 21;
            this.TextBoxComment.Text = "...";
            this.TextBoxComment.TextChanged += new System.EventHandler(this.TextBoxComment_TextChanged);
            this.TextBoxComment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxComment_KeyPress);
            // 
            // ButtonOptions
            // 
            this.ButtonOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOptions.Animated = true;
            this.ButtonOptions.BackColor = System.Drawing.Color.Transparent;
            this.ButtonOptions.BorderColor = System.Drawing.Color.White;
            this.ButtonOptions.BorderRadius = 5;
            this.ButtonOptions.BorderThickness = 2;
            this.ButtonOptions.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonOptions.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonOptions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonOptions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonOptions.FillColor = System.Drawing.Color.Black;
            this.ButtonOptions.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonOptions.ForeColor = System.Drawing.Color.White;
            this.ButtonOptions.Image = global::PSS3.Properties.Resources.menu_48px1;
            this.ButtonOptions.Location = new System.Drawing.Point(770, 12);
            this.ButtonOptions.Name = "ButtonOptions";
            this.ButtonOptions.Size = new System.Drawing.Size(72, 68);
            this.ButtonOptions.TabIndex = 20;
            this.ButtonOptions.UseTransparentBackground = true;
            this.ButtonOptions.Click += new System.EventHandler(this.ButtonOptions_Click);
            this.ButtonOptions.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonOptions_MouseClick);
            // 
            // LabelLogMessage
            // 
            this.LabelLogMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelLogMessage.AutoSize = true;
            this.LabelLogMessage.BackColor = System.Drawing.Color.Black;
            this.LabelLogMessage.Font = new System.Drawing.Font("SST", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLogMessage.ForeColor = System.Drawing.Color.White;
            this.LabelLogMessage.Location = new System.Drawing.Point(48, 15);
            this.LabelLogMessage.Name = "LabelLogMessage";
            this.LabelLogMessage.Size = new System.Drawing.Size(99, 20);
            this.LabelLogMessage.TabIndex = 16;
            this.LabelLogMessage.Text = "Initializing...";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProgressBar.BackColor = System.Drawing.Color.Black;
            this.ProgressBar.CustomBackground = true;
            this.ProgressBar.Location = new System.Drawing.Point(12, 10);
            this.ProgressBar.Maximum = 100;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(30, 28);
            this.ProgressBar.Speed = 2F;
            this.ProgressBar.Style = MetroFramework.MetroColorStyle.White;
            this.ProgressBar.StyleManager = null;
            this.ProgressBar.TabIndex = 15;
            this.ProgressBar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ProgressBar.Value = 10;
            // 
            // ButtonStore
            // 
            this.ButtonStore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonStore.Animated = true;
            this.ButtonStore.BackColor = System.Drawing.Color.Transparent;
            this.ButtonStore.BorderColor = System.Drawing.Color.White;
            this.ButtonStore.BorderRadius = 5;
            this.ButtonStore.BorderThickness = 2;
            this.ButtonStore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonStore.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonStore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonStore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonStore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonStore.FillColor = System.Drawing.Color.Black;
            this.ButtonStore.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 8.999999F, System.Drawing.FontStyle.Bold);
            this.ButtonStore.ForeColor = System.Drawing.Color.White;
            this.ButtonStore.Image = global::PSS3.Properties.Resources.psns;
            this.ButtonStore.ImageSize = new System.Drawing.Size(40, 45);
            this.ButtonStore.Location = new System.Drawing.Point(507, 12);
            this.ButtonStore.Name = "ButtonStore";
            this.ButtonStore.Size = new System.Drawing.Size(120, 68);
            this.ButtonStore.TabIndex = 14;
            this.ButtonStore.Text = "Store";
            this.ButtonStore.UseTransparentBackground = true;
            // 
            // ButtonImgSignOut
            // 
            this.ButtonImgSignOut.BackColor = System.Drawing.Color.Transparent;
            this.ButtonImgSignOut.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ButtonImgSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonImgSignOut.HoverState.ImageRotate = 20F;
            this.ButtonImgSignOut.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.ButtonImgSignOut.Image = global::PSS3.Properties.Resources.tex_indi_Sign_out;
            this.ButtonImgSignOut.ImageOffset = new System.Drawing.Point(0, 0);
            this.ButtonImgSignOut.ImageRotate = 0F;
            this.ButtonImgSignOut.ImageSize = new System.Drawing.Size(20, 20);
            this.ButtonImgSignOut.IndicateFocus = true;
            this.ButtonImgSignOut.Location = new System.Drawing.Point(463, 26);
            this.ButtonImgSignOut.Name = "ButtonImgSignOut";
            this.ButtonImgSignOut.PressedState.ImageSize = new System.Drawing.Size(29, 29);
            this.ButtonImgSignOut.Size = new System.Drawing.Size(38, 41);
            this.ButtonImgSignOut.TabIndex = 5;
            this.ButtonImgSignOut.UseTransparentBackground = true;
            this.ButtonImgSignOut.Click += new System.EventHandler(this.ButtonImgSignOut_Click);
            // 
            // LabelPsnId
            // 
            this.LabelPsnId.AutoSize = true;
            this.LabelPsnId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.LabelPsnId.Font = new System.Drawing.Font("SSTW20-Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPsnId.ForeColor = System.Drawing.Color.White;
            this.LabelPsnId.Location = new System.Drawing.Point(98, 19);
            this.LabelPsnId.Name = "LabelPsnId";
            this.LabelPsnId.Size = new System.Drawing.Size(61, 25);
            this.LabelPsnId.TabIndex = 3;
            this.LabelPsnId.Text = "User";
            // 
            // IconAvatar
            // 
            this.IconAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.IconAvatar.Image = global::PSS3.Properties.Resources.tex_Avatar_Default;
            this.IconAvatar.Location = new System.Drawing.Point(19, 12);
            this.IconAvatar.Name = "IconAvatar";
            this.IconAvatar.Size = new System.Drawing.Size(73, 68);
            this.IconAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconAvatar.TabIndex = 2;
            this.IconAvatar.TabStop = false;
            // 
            // ContextStripOptions
            // 
            this.ContextStripOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pS3ToolStripMenuItem,
            this.debugToolStripMenuItem});
            this.ContextStripOptions.Name = "guna2ContextMenuStrip1";
            this.ContextStripOptions.RenderStyle.ArrowColor = System.Drawing.Color.Blue;
            this.ContextStripOptions.RenderStyle.BorderColor = System.Drawing.Color.Gray;
            this.ContextStripOptions.RenderStyle.ColorTable = null;
            this.ContextStripOptions.RenderStyle.RoundedEdges = true;
            this.ContextStripOptions.RenderStyle.SelectionArrowColor = System.Drawing.Color.Gray;
            this.ContextStripOptions.RenderStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.ContextStripOptions.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.ContextStripOptions.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.ContextStripOptions.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.ContextStripOptions.ShowItemToolTips = false;
            this.ContextStripOptions.Size = new System.Drawing.Size(110, 48);
            this.ContextStripOptions.Opening += new System.ComponentModel.CancelEventHandler(this.ContextStripOptions_Opening);
            // 
            // pS3ToolStripMenuItem
            // 
            this.pS3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sysInformationToolStripMenuItem,
            this.privateInformationToolStripMenuItem,
            this.commandToolStripMenuItem,
            this.managerToolStripMenuItem,
            this.discordOptionsToolStripMenuItem});
            this.pS3ToolStripMenuItem.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pS3ToolStripMenuItem.Image = global::PSS3.Properties.Resources.PS3;
            this.pS3ToolStripMenuItem.Name = "pS3ToolStripMenuItem";
            this.pS3ToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.pS3ToolStripMenuItem.Text = "PS3";
            // 
            // sysInformationToolStripMenuItem
            // 
            this.sysInformationToolStripMenuItem.Name = "sysInformationToolStripMenuItem";
            this.sysInformationToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.sysInformationToolStripMenuItem.Text = "Information and Status";
            // 
            // privateInformationToolStripMenuItem
            // 
            this.privateInformationToolStripMenuItem.Name = "privateInformationToolStripMenuItem";
            this.privateInformationToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.privateInformationToolStripMenuItem.Text = "Private Information ";
            this.privateInformationToolStripMenuItem.Click += new System.EventHandler(this.privateInformationToolStripMenuItem_Click);
            // 
            // commandToolStripMenuItem
            // 
            this.commandToolStripMenuItem.Name = "commandToolStripMenuItem";
            this.commandToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.commandToolStripMenuItem.Text = "webMAN commands";
            // 
            // managerToolStripMenuItem
            // 
            this.managerToolStripMenuItem.Name = "managerToolStripMenuItem";
            this.managerToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.managerToolStripMenuItem.Text = "Data Manager";
            // 
            // discordOptionsToolStripMenuItem
            // 
            this.discordOptionsToolStripMenuItem.Name = "discordOptionsToolStripMenuItem";
            this.discordOptionsToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.discordOptionsToolStripMenuItem.Text = "Discord Options";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cWToolStripMenuItem,
            this.regToolStripMenuItem,
            this.foutToolStripMenuItem,
            this.tESTMSGFORMToolStripMenuItem});
            this.debugToolStripMenuItem.Image = global::PSS3.Properties.Resources.bug_48px;
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.debugToolStripMenuItem.Text = "Debug";
            this.debugToolStripMenuItem.DropDownOpening += new System.EventHandler(this.debugToolStripMenuItem_DropDownOpening);
            // 
            // cWToolStripMenuItem
            // 
            this.cWToolStripMenuItem.Name = "cWToolStripMenuItem";
            this.cWToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.cWToolStripMenuItem.Text = "cw";
            this.cWToolStripMenuItem.Click += new System.EventHandler(this.cWToolStripMenuItem_Click);
            // 
            // regToolStripMenuItem
            // 
            this.regToolStripMenuItem.Name = "regToolStripMenuItem";
            this.regToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.regToolStripMenuItem.Text = "reg";
            this.regToolStripMenuItem.Click += new System.EventHandler(this.regToolStripMenuItem_Click);
            // 
            // foutToolStripMenuItem
            // 
            this.foutToolStripMenuItem.Name = "foutToolStripMenuItem";
            this.foutToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.foutToolStripMenuItem.Text = "fout";
            this.foutToolStripMenuItem.Click += new System.EventHandler(this.foutToolStripMenuItem_Click);
            // 
            // tESTMSGFORMToolStripMenuItem
            // 
            this.tESTMSGFORMToolStripMenuItem.Name = "tESTMSGFORMToolStripMenuItem";
            this.tESTMSGFORMToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.tESTMSGFORMToolStripMenuItem.Text = "TEST MSG FORM";
            this.tESTMSGFORMToolStripMenuItem.Click += new System.EventHandler(this.tESTMSGFORMToolStripMenuItem_Click);
            // 
            // _Tooltip
            // 
            this._Tooltip.AutomaticDelay = 200;
            this._Tooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this._Tooltip.ToolTipTitle = "INFO";
            // 
            // TopperPanel
            // 
            this.TopperPanel.BackColor = System.Drawing.Color.Black;
            this.TopperPanel.Controls.Add(this.ButtonPower);
            this.TopperPanel.Controls.Add(this.TextBoxComment);
            this.TopperPanel.Controls.Add(this.ButtonImgSignOut);
            this.TopperPanel.Controls.Add(this.ButtonOptions);
            this.TopperPanel.Controls.Add(this.LabelPsnId);
            this.TopperPanel.Controls.Add(this.ButtonStore);
            this.TopperPanel.Controls.Add(this.IconAvatar);
            this.TopperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopperPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.TopperPanel.Location = new System.Drawing.Point(0, 0);
            this.TopperPanel.Name = "TopperPanel";
            this.TopperPanel.ShadowColor = System.Drawing.Color.Black;
            this.TopperPanel.Size = new System.Drawing.Size(846, 95);
            this.TopperPanel.TabIndex = 22;
            // 
            // ButtonPower
            // 
            this.ButtonPower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPower.Animated = true;
            this.ButtonPower.BackColor = System.Drawing.Color.Transparent;
            this.ButtonPower.BorderColor = System.Drawing.Color.White;
            this.ButtonPower.BorderRadius = 5;
            this.ButtonPower.BorderThickness = 2;
            this.ButtonPower.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonPower.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonPower.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonPower.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonPower.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonPower.FillColor = System.Drawing.Color.Black;
            this.ButtonPower.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPower.ForeColor = System.Drawing.Color.White;
            this.ButtonPower.Image = global::PSS3.Properties.Resources.shutdown_48px;
            this.ButtonPower.ImageSize = new System.Drawing.Size(30, 30);
            this.ButtonPower.Location = new System.Drawing.Point(633, 12);
            this.ButtonPower.Name = "ButtonPower";
            this.ButtonPower.Size = new System.Drawing.Size(131, 68);
            this.ButtonPower.TabIndex = 22;
            this.ButtonPower.Text = "Power Menu";
            this.ButtonPower.UseTransparentBackground = true;
            this.ButtonPower.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonPower_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.NumericRefreshInterval);
            this.panel1.Controls.Add(this.LabelLogMessage);
            this.panel1.Controls.Add(this.ProgressBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 436);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 47);
            this.panel1.TabIndex = 23;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("SST", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(609, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Refresh Interval";
            // 
            // NumericRefreshInterval
            // 
            this.NumericRefreshInterval.BackColor = System.Drawing.Color.Transparent;
            this.NumericRefreshInterval.BorderColor = System.Drawing.Color.Gray;
            this.NumericRefreshInterval.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumericRefreshInterval.FillColor = System.Drawing.Color.Black;
            this.NumericRefreshInterval.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumericRefreshInterval.ForeColor = System.Drawing.Color.White;
            this.NumericRefreshInterval.Location = new System.Drawing.Point(740, 4);
            this.NumericRefreshInterval.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NumericRefreshInterval.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericRefreshInterval.Name = "NumericRefreshInterval";
            this.NumericRefreshInterval.Size = new System.Drawing.Size(100, 36);
            this.NumericRefreshInterval.TabIndex = 23;
            this.NumericRefreshInterval.UpDownButtonFillColor = System.Drawing.Color.Gray;
            this.NumericRefreshInterval.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.NumericRefreshInterval.ValueChanged += new System.EventHandler(this.NumericRefreshInterval_ValueChanged);
            // 
            // _TC_MainContainer
            // 
            this._TC_MainContainer.Alignment = System.Windows.Forms.TabAlignment.Left;
            this._TC_MainContainer.Controls.Add(this._TC_DASHBOARD_STATUS);
            this._TC_MainContainer.Controls.Add(this._TC_DASHBOARD_GAMELIST);
            this._TC_MainContainer.Controls.Add(this._TC_DASHBOARD_FRIENDLIST);
            this._TC_MainContainer.Controls.Add(this._TC_DASHBOARD_SAVEGAMELIST);
            this._TC_MainContainer.Controls.Add(this._TC_DASHBOARD_MAPI);
            this._TC_MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._TC_MainContainer.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TC_MainContainer.ItemSize = new System.Drawing.Size(180, 60);
            this._TC_MainContainer.Location = new System.Drawing.Point(0, 95);
            this._TC_MainContainer.Name = "_TC_MainContainer";
            this._TC_MainContainer.SelectedIndex = 0;
            this._TC_MainContainer.Size = new System.Drawing.Size(846, 341);
            this._TC_MainContainer.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this._TC_MainContainer.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this._TC_MainContainer.TabButtonHoverState.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TC_MainContainer.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this._TC_MainContainer.TabButtonHoverState.InnerColor = System.Drawing.Color.Black;
            this._TC_MainContainer.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this._TC_MainContainer.TabButtonIdleState.FillColor = System.Drawing.Color.DimGray;
            this._TC_MainContainer.TabButtonIdleState.Font = new System.Drawing.Font("SST", 12F);
            this._TC_MainContainer.TabButtonIdleState.ForeColor = System.Drawing.Color.DarkGray;
            this._TC_MainContainer.TabButtonIdleState.InnerColor = System.Drawing.Color.Silver;
            this._TC_MainContainer.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this._TC_MainContainer.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this._TC_MainContainer.TabButtonSelectedState.Font = new System.Drawing.Font("SST", 12F);
            this._TC_MainContainer.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this._TC_MainContainer.TabButtonSelectedState.InnerColor = System.Drawing.Color.Black;
            this._TC_MainContainer.TabButtonSize = new System.Drawing.Size(180, 60);
            this._TC_MainContainer.TabIndex = 23;
            this._TC_MainContainer.TabMenuBackColor = System.Drawing.Color.DimGray;
            // 
            // _TC_DASHBOARD_STATUS
            // 
            this._TC_DASHBOARD_STATUS.AutoScroll = true;
            this._TC_DASHBOARD_STATUS.BackColor = System.Drawing.Color.White;
            this._TC_DASHBOARD_STATUS.Controls.Add(this.LabelInfoFirmType);
            this._TC_DASHBOARD_STATUS.Controls.Add(this.LabelSysName);
            this._TC_DASHBOARD_STATUS.Controls.Add(this.PB_PS3ICON);
            this._TC_DASHBOARD_STATUS.Controls.Add(this.LabelInfoHdd);
            this._TC_DASHBOARD_STATUS.Controls.Add(this.LabelInfoMem);
            this._TC_DASHBOARD_STATUS.Controls.Add(this.XmbImage);
            this._TC_DASHBOARD_STATUS.Controls.Add(this.LabelInfoTemp);
            this._TC_DASHBOARD_STATUS.Controls.Add(this.guna2Separator8);
            this._TC_DASHBOARD_STATUS.Controls.Add(this.LabelInfoLife);
            this._TC_DASHBOARD_STATUS.Controls.Add(this.LabelInfoFan);
            this._TC_DASHBOARD_STATUS.Controls.Add(this.ButtonUpdate);
            this._TC_DASHBOARD_STATUS.Controls.Add(this.LabelInfoFirmware);
            this._TC_DASHBOARD_STATUS.Controls.Add(this.label2);
            this._TC_DASHBOARD_STATUS.Controls.Add(this.label1);
            this._TC_DASHBOARD_STATUS.Controls.Add(this.LabelGameTitle);
            this._TC_DASHBOARD_STATUS.Controls.Add(this.LabelGameElapsed);
            this._TC_DASHBOARD_STATUS.Controls.Add(this.LabelSysTime);
            this._TC_DASHBOARD_STATUS.Font = new System.Drawing.Font("SST", 12F);
            this._TC_DASHBOARD_STATUS.ImageIndex = 0;
            this._TC_DASHBOARD_STATUS.Location = new System.Drawing.Point(184, 4);
            this._TC_DASHBOARD_STATUS.Name = "_TC_DASHBOARD_STATUS";
            this._TC_DASHBOARD_STATUS.Padding = new System.Windows.Forms.Padding(3);
            this._TC_DASHBOARD_STATUS.Size = new System.Drawing.Size(658, 333);
            this._TC_DASHBOARD_STATUS.TabIndex = 5;
            this._TC_DASHBOARD_STATUS.Text = "Status";
            // 
            // LabelInfoFirmType
            // 
            this.LabelInfoFirmType.AutoSize = true;
            this.LabelInfoFirmType.BackColor = System.Drawing.Color.White;
            this.LabelInfoFirmType.Font = new System.Drawing.Font("SSTW20-Medium", 12.75F);
            this.LabelInfoFirmType.ForeColor = System.Drawing.Color.Black;
            this.LabelInfoFirmType.Location = new System.Drawing.Point(141, 98);
            this.LabelInfoFirmType.Name = "LabelInfoFirmType";
            this.LabelInfoFirmType.Size = new System.Drawing.Size(58, 20);
            this.LabelInfoFirmType.TabIndex = 112;
            this.LabelInfoFirmType.Text = "FWT: -";
            // 
            // LabelSysName
            // 
            this.LabelSysName.AutoEllipsis = true;
            this.LabelSysName.BackColor = System.Drawing.Color.White;
            this.LabelSysName.Font = new System.Drawing.Font("SSTW20-Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSysName.ForeColor = System.Drawing.Color.Black;
            this.LabelSysName.Location = new System.Drawing.Point(140, 15);
            this.LabelSysName.Name = "LabelSysName";
            this.LabelSysName.Size = new System.Drawing.Size(152, 35);
            this.LabelSysName.TabIndex = 111;
            this.LabelSysName.Text = "PS3-0000";
            // 
            // PB_PS3ICON
            // 
            this.PB_PS3ICON.BackColor = System.Drawing.Color.White;
            this.PB_PS3ICON.Image = global::PSS3.Properties.Resources.slim;
            this.PB_PS3ICON.ImageRotate = 0F;
            this.PB_PS3ICON.Location = new System.Drawing.Point(17, 19);
            this.PB_PS3ICON.Name = "PB_PS3ICON";
            this.PB_PS3ICON.Size = new System.Drawing.Size(130, 130);
            this.PB_PS3ICON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_PS3ICON.TabIndex = 105;
            this.PB_PS3ICON.TabStop = false;
            // 
            // LabelInfoHdd
            // 
            this.LabelInfoHdd.AutoSize = true;
            this.LabelInfoHdd.BackColor = System.Drawing.Color.White;
            this.LabelInfoHdd.Font = new System.Drawing.Font("SSTW20-Medium", 12.75F);
            this.LabelInfoHdd.ForeColor = System.Drawing.Color.Black;
            this.LabelInfoHdd.Location = new System.Drawing.Point(371, 102);
            this.LabelInfoHdd.Name = "LabelInfoHdd";
            this.LabelInfoHdd.Size = new System.Drawing.Size(61, 20);
            this.LabelInfoHdd.TabIndex = 108;
            this.LabelInfoHdd.Text = "HDD: -";
            // 
            // LabelInfoMem
            // 
            this.LabelInfoMem.AutoSize = true;
            this.LabelInfoMem.BackColor = System.Drawing.Color.White;
            this.LabelInfoMem.Font = new System.Drawing.Font("SSTW20-Medium", 12.75F);
            this.LabelInfoMem.ForeColor = System.Drawing.Color.Black;
            this.LabelInfoMem.Location = new System.Drawing.Point(141, 52);
            this.LabelInfoMem.Name = "LabelInfoMem";
            this.LabelInfoMem.Size = new System.Drawing.Size(54, 20);
            this.LabelInfoMem.TabIndex = 110;
            this.LabelInfoMem.Text = "MEM:";
            // 
            // XmbImage
            // 
            this.XmbImage.BackColor = System.Drawing.Color.DimGray;
            this.XmbImage.Image = global::PSS3.Properties.Resources.tex_game;
            this.XmbImage.ImageRotate = 0F;
            this.XmbImage.Location = new System.Drawing.Point(18, 180);
            this.XmbImage.Name = "XmbImage";
            this.XmbImage.Size = new System.Drawing.Size(163, 95);
            this.XmbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.XmbImage.TabIndex = 96;
            this.XmbImage.TabStop = false;
            // 
            // LabelInfoTemp
            // 
            this.LabelInfoTemp.AutoSize = true;
            this.LabelInfoTemp.BackColor = System.Drawing.Color.White;
            this.LabelInfoTemp.Font = new System.Drawing.Font("SSTW20-Medium", 12.75F);
            this.LabelInfoTemp.ForeColor = System.Drawing.Color.Black;
            this.LabelInfoTemp.Location = new System.Drawing.Point(141, 75);
            this.LabelInfoTemp.Name = "LabelInfoTemp";
            this.LabelInfoTemp.Size = new System.Drawing.Size(69, 20);
            this.LabelInfoTemp.TabIndex = 107;
            this.LabelInfoTemp.Text = "TEMP: -";
            // 
            // guna2Separator8
            // 
            this.guna2Separator8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator8.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator8.FillColor = System.Drawing.Color.Black;
            this.guna2Separator8.Location = new System.Drawing.Point(17, 150);
            this.guna2Separator8.Name = "guna2Separator8";
            this.guna2Separator8.Size = new System.Drawing.Size(633, 15);
            this.guna2Separator8.TabIndex = 104;
            this.guna2Separator8.UseTransparentBackground = true;
            // 
            // LabelInfoLife
            // 
            this.LabelInfoLife.AutoSize = true;
            this.LabelInfoLife.BackColor = System.Drawing.Color.White;
            this.LabelInfoLife.Font = new System.Drawing.Font("SSTW20-Medium", 12.75F);
            this.LabelInfoLife.ForeColor = System.Drawing.Color.Black;
            this.LabelInfoLife.Location = new System.Drawing.Point(141, 121);
            this.LabelInfoLife.Name = "LabelInfoLife";
            this.LabelInfoLife.Size = new System.Drawing.Size(56, 20);
            this.LabelInfoLife.TabIndex = 106;
            this.LabelInfoLife.Text = "LIF:  - ";
            // 
            // LabelInfoFan
            // 
            this.LabelInfoFan.AutoSize = true;
            this.LabelInfoFan.BackColor = System.Drawing.Color.White;
            this.LabelInfoFan.Font = new System.Drawing.Font("SSTW20-Medium", 12.75F);
            this.LabelInfoFan.ForeColor = System.Drawing.Color.Black;
            this.LabelInfoFan.Location = new System.Drawing.Point(371, 77);
            this.LabelInfoFan.Name = "LabelInfoFan";
            this.LabelInfoFan.Size = new System.Drawing.Size(57, 20);
            this.LabelInfoFan.TabIndex = 109;
            this.LabelInfoFan.Text = "FAN: -";
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonUpdate.BackColor = System.Drawing.Color.Transparent;
            this.ButtonUpdate.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ButtonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonUpdate.HoverState.ImageRotate = 20F;
            this.ButtonUpdate.HoverState.ImageSize = new System.Drawing.Size(65, 65);
            this.ButtonUpdate.Image = global::PSS3.Properties.Resources.tex_temporary_icon;
            this.ButtonUpdate.ImageOffset = new System.Drawing.Point(0, 0);
            this.ButtonUpdate.ImageRotate = 0F;
            this.ButtonUpdate.ImageSize = new System.Drawing.Size(55, 55);
            this.ButtonUpdate.IndicateFocus = true;
            this.ButtonUpdate.Location = new System.Drawing.Point(612, 6);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.PressedState.ImageSize = new System.Drawing.Size(29, 29);
            this.ButtonUpdate.Size = new System.Drawing.Size(38, 41);
            this.ButtonUpdate.TabIndex = 100;
            this.ButtonUpdate.UseTransparentBackground = true;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // LabelInfoFirmware
            // 
            this.LabelInfoFirmware.AutoSize = true;
            this.LabelInfoFirmware.BackColor = System.Drawing.Color.White;
            this.LabelInfoFirmware.Font = new System.Drawing.Font("SSTW20-Medium", 12.75F);
            this.LabelInfoFirmware.ForeColor = System.Drawing.Color.Black;
            this.LabelInfoFirmware.Location = new System.Drawing.Point(371, 52);
            this.LabelInfoFirmware.Name = "LabelInfoFirmware";
            this.LabelInfoFirmware.Size = new System.Drawing.Size(50, 20);
            this.LabelInfoFirmware.TabIndex = 103;
            this.LabelInfoFirmware.Text = "FW: -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("SSTW20-Medium", 12.75F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(198, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 99;
            this.label2.Text = "Systime: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("SSTW20-Medium", 12.75F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(198, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 98;
            this.label1.Text = "Playtime: ";
            // 
            // LabelGameTitle
            // 
            this.LabelGameTitle.AutoEllipsis = true;
            this.LabelGameTitle.BackColor = System.Drawing.Color.White;
            this.LabelGameTitle.Font = new System.Drawing.Font("SST", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGameTitle.ForeColor = System.Drawing.Color.Black;
            this.LabelGameTitle.Location = new System.Drawing.Point(197, 180);
            this.LabelGameTitle.Name = "LabelGameTitle";
            this.LabelGameTitle.Size = new System.Drawing.Size(327, 35);
            this.LabelGameTitle.TabIndex = 94;
            this.LabelGameTitle.Text = "XMB";
            // 
            // LabelGameElapsed
            // 
            this.LabelGameElapsed.AutoEllipsis = true;
            this.LabelGameElapsed.BackColor = System.Drawing.Color.White;
            this.LabelGameElapsed.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGameElapsed.ForeColor = System.Drawing.Color.Black;
            this.LabelGameElapsed.Location = new System.Drawing.Point(291, 221);
            this.LabelGameElapsed.Name = "LabelGameElapsed";
            this.LabelGameElapsed.Size = new System.Drawing.Size(87, 20);
            this.LabelGameElapsed.TabIndex = 97;
            this.LabelGameElapsed.Text = "00:00:00";
            // 
            // LabelSysTime
            // 
            this.LabelSysTime.AutoEllipsis = true;
            this.LabelSysTime.BackColor = System.Drawing.Color.White;
            this.LabelSysTime.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSysTime.ForeColor = System.Drawing.Color.Black;
            this.LabelSysTime.Location = new System.Drawing.Point(291, 243);
            this.LabelSysTime.Name = "LabelSysTime";
            this.LabelSysTime.Size = new System.Drawing.Size(87, 20);
            this.LabelSysTime.TabIndex = 95;
            this.LabelSysTime.Text = "00:00:00";
            // 
            // _TC_DASHBOARD_GAMELIST
            // 
            this._TC_DASHBOARD_GAMELIST.Controls.Add(this.ListViewGames);
            this._TC_DASHBOARD_GAMELIST.Font = new System.Drawing.Font("SST", 12F);
            this._TC_DASHBOARD_GAMELIST.ImageIndex = 1;
            this._TC_DASHBOARD_GAMELIST.Location = new System.Drawing.Point(184, 4);
            this._TC_DASHBOARD_GAMELIST.Name = "_TC_DASHBOARD_GAMELIST";
            this._TC_DASHBOARD_GAMELIST.Padding = new System.Windows.Forms.Padding(3);
            this._TC_DASHBOARD_GAMELIST.Size = new System.Drawing.Size(658, 333);
            this._TC_DASHBOARD_GAMELIST.TabIndex = 2;
            this._TC_DASHBOARD_GAMELIST.Text = "Games";
            this._TC_DASHBOARD_GAMELIST.UseVisualStyleBackColor = true;
            // 
            // _TC_DASHBOARD_FRIENDLIST
            // 
            this._TC_DASHBOARD_FRIENDLIST.Controls.Add(this.ListViewFriends);
            this._TC_DASHBOARD_FRIENDLIST.Controls.Add(this.StatusStripFriendsMenu);
            this._TC_DASHBOARD_FRIENDLIST.Font = new System.Drawing.Font("SST", 12F);
            this._TC_DASHBOARD_FRIENDLIST.ImageIndex = 2;
            this._TC_DASHBOARD_FRIENDLIST.Location = new System.Drawing.Point(184, 4);
            this._TC_DASHBOARD_FRIENDLIST.Name = "_TC_DASHBOARD_FRIENDLIST";
            this._TC_DASHBOARD_FRIENDLIST.Padding = new System.Windows.Forms.Padding(3);
            this._TC_DASHBOARD_FRIENDLIST.Size = new System.Drawing.Size(658, 333);
            this._TC_DASHBOARD_FRIENDLIST.TabIndex = 1;
            this._TC_DASHBOARD_FRIENDLIST.Text = "Friends";
            this._TC_DASHBOARD_FRIENDLIST.UseVisualStyleBackColor = true;
            // 
            // ListViewFriends
            // 
            this.ListViewFriends.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListViewFriends.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewFriends.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListViewFriends.HideSelection = false;
            this.ListViewFriends.Location = new System.Drawing.Point(3, 3);
            this.ListViewFriends.Name = "ListViewFriends";
            this.ListViewFriends.Size = new System.Drawing.Size(652, 305);
            this.ListViewFriends.TabIndex = 26;
            this.ListViewFriends.TileSize = new System.Drawing.Size(65, 65);
            this.ListViewFriends.UseCompatibleStateImageBehavior = false;
            this.ListViewFriends.SelectedIndexChanged += new System.EventHandler(this.ListViewFriends_SelectedIndexChanged);
            // 
            // StatusStripFriendsMenu
            // 
            this.StatusStripFriendsMenu.BackColor = System.Drawing.Color.White;
            this.StatusStripFriendsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TTSL_FriendCount,
            this.TTSL_SelDat,
            this.TTSL_DumpFriendAvatar});
            this.StatusStripFriendsMenu.Location = new System.Drawing.Point(3, 308);
            this.StatusStripFriendsMenu.Name = "StatusStripFriendsMenu";
            this.StatusStripFriendsMenu.Size = new System.Drawing.Size(652, 22);
            this.StatusStripFriendsMenu.TabIndex = 27;
            this.StatusStripFriendsMenu.Text = "_";
            // 
            // TTSL_FriendCount
            // 
            this.TTSL_FriendCount.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTSL_FriendCount.Name = "TTSL_FriendCount";
            this.TTSL_FriendCount.Size = new System.Drawing.Size(69, 17);
            this.TTSL_FriendCount.Text = "Friends: 0";
            // 
            // TTSL_SelDat
            // 
            this.TTSL_SelDat.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTSL_SelDat.IsLink = true;
            this.TTSL_SelDat.Name = "TTSL_SelDat";
            this.TTSL_SelDat.Size = new System.Drawing.Size(119, 17);
            this.TTSL_SelDat.Text = "Selected Data Url: ";
            // 
            // TTSL_DumpFriendAvatar
            // 
            this.TTSL_DumpFriendAvatar.IsLink = true;
            this.TTSL_DumpFriendAvatar.Name = "TTSL_DumpFriendAvatar";
            this.TTSL_DumpFriendAvatar.Size = new System.Drawing.Size(86, 17);
            this.TTSL_DumpFriendAvatar.Text = "Dump Avatar...";
            this.TTSL_DumpFriendAvatar.Click += new System.EventHandler(this.TTSL_DumpFriendAvatar_Click);
            // 
            // _TC_DASHBOARD_SAVEGAMELIST
            // 
            this._TC_DASHBOARD_SAVEGAMELIST.Controls.Add(this.SC_SAVDAT_CONTAINER);
            this._TC_DASHBOARD_SAVEGAMELIST.Font = new System.Drawing.Font("SST", 12F);
            this._TC_DASHBOARD_SAVEGAMELIST.ImageIndex = 3;
            this._TC_DASHBOARD_SAVEGAMELIST.Location = new System.Drawing.Point(184, 4);
            this._TC_DASHBOARD_SAVEGAMELIST.Name = "_TC_DASHBOARD_SAVEGAMELIST";
            this._TC_DASHBOARD_SAVEGAMELIST.Padding = new System.Windows.Forms.Padding(3);
            this._TC_DASHBOARD_SAVEGAMELIST.Size = new System.Drawing.Size(658, 333);
            this._TC_DASHBOARD_SAVEGAMELIST.TabIndex = 3;
            this._TC_DASHBOARD_SAVEGAMELIST.Text = "SaveGames";
            this._TC_DASHBOARD_SAVEGAMELIST.UseVisualStyleBackColor = true;
            // 
            // SC_SAVDAT_CONTAINER
            // 
            this.SC_SAVDAT_CONTAINER.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SC_SAVDAT_CONTAINER.Location = new System.Drawing.Point(3, 3);
            this.SC_SAVDAT_CONTAINER.Name = "SC_SAVDAT_CONTAINER";
            // 
            // SC_SAVDAT_CONTAINER.Panel1
            // 
            this.SC_SAVDAT_CONTAINER.Panel1.Controls.Add(this.ListViewSaves);
            // 
            // SC_SAVDAT_CONTAINER.Panel2
            // 
            this.SC_SAVDAT_CONTAINER.Panel2.Controls.Add(this.SaveDatInfoPanel);
            this.SC_SAVDAT_CONTAINER.Size = new System.Drawing.Size(652, 327);
            this.SC_SAVDAT_CONTAINER.SplitterDistance = 391;
            this.SC_SAVDAT_CONTAINER.TabIndex = 28;
            // 
            // ListViewSaves
            // 
            this.ListViewSaves.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListViewSaves.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewSaves.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListViewSaves.HideSelection = false;
            this.ListViewSaves.Location = new System.Drawing.Point(0, 0);
            this.ListViewSaves.Name = "ListViewSaves";
            this.ListViewSaves.Size = new System.Drawing.Size(391, 327);
            this.ListViewSaves.TabIndex = 27;
            this.ListViewSaves.TileSize = new System.Drawing.Size(65, 65);
            this.ListViewSaves.UseCompatibleStateImageBehavior = false;
            this.ListViewSaves.SelectedIndexChanged += new System.EventHandler(this.ListViewSaves_SelectedIndexChanged);
            // 
            // SaveDatInfoPanel
            // 
            this.SaveDatInfoPanel.Controls.Add(this.PB_SAVDATICO);
            this.SaveDatInfoPanel.Controls.Add(this.RTB_SAVDATINFO);
            this.SaveDatInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveDatInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.SaveDatInfoPanel.Name = "SaveDatInfoPanel";
            this.SaveDatInfoPanel.Size = new System.Drawing.Size(257, 327);
            this.SaveDatInfoPanel.TabIndex = 0;
            // 
            // PB_SAVDATICO
            // 
            this.PB_SAVDATICO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_SAVDATICO.Location = new System.Drawing.Point(53, 28);
            this.PB_SAVDATICO.Name = "PB_SAVDATICO";
            this.PB_SAVDATICO.Size = new System.Drawing.Size(147, 67);
            this.PB_SAVDATICO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_SAVDATICO.TabIndex = 2;
            this.PB_SAVDATICO.TabStop = false;
            // 
            // RTB_SAVDATINFO
            // 
            this.RTB_SAVDATINFO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB_SAVDATINFO.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RTB_SAVDATINFO.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 8.95F, System.Drawing.FontStyle.Bold);
            this.RTB_SAVDATINFO.Location = new System.Drawing.Point(0, 117);
            this.RTB_SAVDATINFO.Name = "RTB_SAVDATINFO";
            this.RTB_SAVDATINFO.Size = new System.Drawing.Size(257, 210);
            this.RTB_SAVDATINFO.TabIndex = 1;
            this.RTB_SAVDATINFO.Text = "...";
            // 
            // _TC_DASHBOARD_MAPI
            // 
            this._TC_DASHBOARD_MAPI.AutoScroll = true;
            this._TC_DASHBOARD_MAPI.Controls.Add(this.panel2);
            this._TC_DASHBOARD_MAPI.Controls.Add(this.panel4);
            this._TC_DASHBOARD_MAPI.Location = new System.Drawing.Point(184, 4);
            this._TC_DASHBOARD_MAPI.Name = "_TC_DASHBOARD_MAPI";
            this._TC_DASHBOARD_MAPI.Padding = new System.Windows.Forms.Padding(3);
            this._TC_DASHBOARD_MAPI.Size = new System.Drawing.Size(658, 333);
            this._TC_DASHBOARD_MAPI.TabIndex = 4;
            this._TC_DASHBOARD_MAPI.Text = "Manager API";
            this._TC_DASHBOARD_MAPI.UseVisualStyleBackColor = true;
            this._TC_DASHBOARD_MAPI.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.guna2Button5);
            this.panel4.Controls.Add(this.guna2Button4);
            this.panel4.Controls.Add(this.guna2Button3);
            this.panel4.Controls.Add(this.guna2Button2);
            this.panel4.Controls.Add(this.guna2Button1);
            this.panel4.Controls.Add(this.btn_prx_1);
            this.panel4.Controls.Add(this.LBL_PRX6);
            this.panel4.Controls.Add(this.LBL_PRX5);
            this.panel4.Controls.Add(this.LBL_PRX4);
            this.panel4.Controls.Add(this.LBL_PRX3);
            this.panel4.Controls.Add(this.LBL_PRX2);
            this.panel4.Controls.Add(this.LBL_PRX1);
            this.panel4.Controls.Add(this.txt_prx_6);
            this.panel4.Controls.Add(this.txt_prx_5);
            this.panel4.Controls.Add(this.txt_prx_4);
            this.panel4.Controls.Add(this.txt_prx_3);
            this.panel4.Controls.Add(this.txt_prx_2);
            this.panel4.Controls.Add(this.txt_prx_1);
            this.panel4.Controls.Add(this.guna2Separator4);
            this.panel4.Controls.Add(this.LabelHeader3);
            this.panel4.Controls.Add(this.guna2Separator5);
            this.panel4.Location = new System.Drawing.Point(17, 235);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(581, 262);
            this.panel4.TabIndex = 67;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // guna2Button5
            // 
            this.guna2Button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button5.Animated = true;
            this.guna2Button5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button5.BorderColor = System.Drawing.Color.White;
            this.guna2Button5.BorderRadius = 5;
            this.guna2Button5.BorderThickness = 2;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.Black;
            this.guna2Button5.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Image = global::PSS3.Properties.Resources.tex_arrow_down;
            this.guna2Button5.Location = new System.Drawing.Point(346, 211);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(91, 27);
            this.guna2Button5.TabIndex = 90;
            this.guna2Button5.Text = "Load";
            this.guna2Button5.UseTransparentBackground = true;
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button4.Animated = true;
            this.guna2Button4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button4.BorderColor = System.Drawing.Color.White;
            this.guna2Button4.BorderRadius = 5;
            this.guna2Button4.BorderThickness = 2;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.Black;
            this.guna2Button4.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Image = global::PSS3.Properties.Resources.tex_arrow_down;
            this.guna2Button4.Location = new System.Drawing.Point(346, 178);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(91, 27);
            this.guna2Button4.TabIndex = 89;
            this.guna2Button4.Text = "Load";
            this.guna2Button4.UseTransparentBackground = true;
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button3.Animated = true;
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderColor = System.Drawing.Color.White;
            this.guna2Button3.BorderRadius = 5;
            this.guna2Button3.BorderThickness = 2;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Black;
            this.guna2Button3.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Image = global::PSS3.Properties.Resources.tex_arrow_down;
            this.guna2Button3.Location = new System.Drawing.Point(346, 145);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(91, 27);
            this.guna2Button3.TabIndex = 88;
            this.guna2Button3.Text = "Load";
            this.guna2Button3.UseTransparentBackground = true;
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button2.Animated = true;
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderColor = System.Drawing.Color.White;
            this.guna2Button2.BorderRadius = 5;
            this.guna2Button2.BorderThickness = 2;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Black;
            this.guna2Button2.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = global::PSS3.Properties.Resources.tex_arrow_down;
            this.guna2Button2.Location = new System.Drawing.Point(346, 112);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(91, 27);
            this.guna2Button2.TabIndex = 87;
            this.guna2Button2.Text = "Load";
            this.guna2Button2.UseTransparentBackground = true;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.Animated = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.White;
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Black;
            this.guna2Button1.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::PSS3.Properties.Resources.tex_arrow_down;
            this.guna2Button1.Location = new System.Drawing.Point(346, 79);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(91, 27);
            this.guna2Button1.TabIndex = 86;
            this.guna2Button1.Text = "Load";
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btn_prx_1
            // 
            this.btn_prx_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_prx_1.Animated = true;
            this.btn_prx_1.BackColor = System.Drawing.Color.Transparent;
            this.btn_prx_1.BorderColor = System.Drawing.Color.White;
            this.btn_prx_1.BorderRadius = 5;
            this.btn_prx_1.BorderThickness = 2;
            this.btn_prx_1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_prx_1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_prx_1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_prx_1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_prx_1.FillColor = System.Drawing.Color.Black;
            this.btn_prx_1.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prx_1.ForeColor = System.Drawing.Color.White;
            this.btn_prx_1.Image = global::PSS3.Properties.Resources.tex_arrow_down;
            this.btn_prx_1.Location = new System.Drawing.Point(346, 46);
            this.btn_prx_1.Name = "btn_prx_1";
            this.btn_prx_1.Size = new System.Drawing.Size(91, 27);
            this.btn_prx_1.TabIndex = 23;
            this.btn_prx_1.Text = "Load";
            this.btn_prx_1.UseTransparentBackground = true;
            this.btn_prx_1.Click += new System.EventHandler(this.btn_prx_1_Click);
            // 
            // LBL_PRX6
            // 
            this.LBL_PRX6.AutoSize = true;
            this.LBL_PRX6.Location = new System.Drawing.Point(459, 214);
            this.LBL_PRX6.Name = "LBL_PRX6";
            this.LBL_PRX6.Size = new System.Drawing.Size(20, 19);
            this.LBL_PRX6.TabIndex = 85;
            this.LBL_PRX6.Text = "6";
            // 
            // LBL_PRX5
            // 
            this.LBL_PRX5.AutoSize = true;
            this.LBL_PRX5.Location = new System.Drawing.Point(460, 181);
            this.LBL_PRX5.Name = "LBL_PRX5";
            this.LBL_PRX5.Size = new System.Drawing.Size(20, 19);
            this.LBL_PRX5.TabIndex = 84;
            this.LBL_PRX5.Text = "5";
            // 
            // LBL_PRX4
            // 
            this.LBL_PRX4.AutoSize = true;
            this.LBL_PRX4.Location = new System.Drawing.Point(460, 148);
            this.LBL_PRX4.Name = "LBL_PRX4";
            this.LBL_PRX4.Size = new System.Drawing.Size(20, 19);
            this.LBL_PRX4.TabIndex = 83;
            this.LBL_PRX4.Text = "4";
            // 
            // LBL_PRX3
            // 
            this.LBL_PRX3.AutoSize = true;
            this.LBL_PRX3.Location = new System.Drawing.Point(460, 115);
            this.LBL_PRX3.Name = "LBL_PRX3";
            this.LBL_PRX3.Size = new System.Drawing.Size(20, 19);
            this.LBL_PRX3.TabIndex = 82;
            this.LBL_PRX3.Text = "3";
            // 
            // LBL_PRX2
            // 
            this.LBL_PRX2.AutoSize = true;
            this.LBL_PRX2.Location = new System.Drawing.Point(460, 82);
            this.LBL_PRX2.Name = "LBL_PRX2";
            this.LBL_PRX2.Size = new System.Drawing.Size(20, 19);
            this.LBL_PRX2.TabIndex = 81;
            this.LBL_PRX2.Text = "2";
            // 
            // LBL_PRX1
            // 
            this.LBL_PRX1.AutoSize = true;
            this.LBL_PRX1.Location = new System.Drawing.Point(460, 49);
            this.LBL_PRX1.Name = "LBL_PRX1";
            this.LBL_PRX1.Size = new System.Drawing.Size(20, 19);
            this.LBL_PRX1.TabIndex = 80;
            this.LBL_PRX1.Text = "1";
            // 
            // txt_prx_6
            // 
            this.txt_prx_6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_prx_6.DefaultText = "";
            this.txt_prx_6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_prx_6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_prx_6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_prx_6.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_prx_6.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_prx_6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_prx_6.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_prx_6.Location = new System.Drawing.Point(9, 211);
            this.txt_prx_6.Name = "txt_prx_6";
            this.txt_prx_6.PasswordChar = '\0';
            this.txt_prx_6.PlaceholderText = "";
            this.txt_prx_6.SelectedText = "";
            this.txt_prx_6.Size = new System.Drawing.Size(348, 27);
            this.txt_prx_6.TabIndex = 79;
            // 
            // txt_prx_5
            // 
            this.txt_prx_5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_prx_5.DefaultText = "";
            this.txt_prx_5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_prx_5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_prx_5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_prx_5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_prx_5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_prx_5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_prx_5.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_prx_5.Location = new System.Drawing.Point(9, 178);
            this.txt_prx_5.Name = "txt_prx_5";
            this.txt_prx_5.PasswordChar = '\0';
            this.txt_prx_5.PlaceholderText = "";
            this.txt_prx_5.SelectedText = "";
            this.txt_prx_5.Size = new System.Drawing.Size(348, 27);
            this.txt_prx_5.TabIndex = 78;
            // 
            // txt_prx_4
            // 
            this.txt_prx_4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_prx_4.DefaultText = "";
            this.txt_prx_4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_prx_4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_prx_4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_prx_4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_prx_4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_prx_4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_prx_4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_prx_4.Location = new System.Drawing.Point(9, 145);
            this.txt_prx_4.Name = "txt_prx_4";
            this.txt_prx_4.PasswordChar = '\0';
            this.txt_prx_4.PlaceholderText = "";
            this.txt_prx_4.SelectedText = "";
            this.txt_prx_4.Size = new System.Drawing.Size(348, 27);
            this.txt_prx_4.TabIndex = 77;
            // 
            // txt_prx_3
            // 
            this.txt_prx_3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_prx_3.DefaultText = "";
            this.txt_prx_3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_prx_3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_prx_3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_prx_3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_prx_3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_prx_3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_prx_3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_prx_3.Location = new System.Drawing.Point(9, 112);
            this.txt_prx_3.Name = "txt_prx_3";
            this.txt_prx_3.PasswordChar = '\0';
            this.txt_prx_3.PlaceholderText = "";
            this.txt_prx_3.SelectedText = "";
            this.txt_prx_3.Size = new System.Drawing.Size(348, 27);
            this.txt_prx_3.TabIndex = 76;
            // 
            // txt_prx_2
            // 
            this.txt_prx_2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_prx_2.DefaultText = "";
            this.txt_prx_2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_prx_2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_prx_2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_prx_2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_prx_2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_prx_2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_prx_2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_prx_2.Location = new System.Drawing.Point(9, 79);
            this.txt_prx_2.Name = "txt_prx_2";
            this.txt_prx_2.PasswordChar = '\0';
            this.txt_prx_2.PlaceholderText = "";
            this.txt_prx_2.SelectedText = "";
            this.txt_prx_2.Size = new System.Drawing.Size(348, 27);
            this.txt_prx_2.TabIndex = 75;
            // 
            // txt_prx_1
            // 
            this.txt_prx_1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_prx_1.DefaultText = "";
            this.txt_prx_1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_prx_1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_prx_1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_prx_1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_prx_1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_prx_1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_prx_1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_prx_1.Location = new System.Drawing.Point(9, 46);
            this.txt_prx_1.Name = "txt_prx_1";
            this.txt_prx_1.PasswordChar = '\0';
            this.txt_prx_1.PlaceholderText = "";
            this.txt_prx_1.SelectedText = "";
            this.txt_prx_1.Size = new System.Drawing.Size(348, 27);
            this.txt_prx_1.TabIndex = 74;
            // 
            // guna2Separator4
            // 
            this.guna2Separator4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator4.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Separator4.FillColor = System.Drawing.Color.Black;
            this.guna2Separator4.Location = new System.Drawing.Point(0, 30);
            this.guna2Separator4.Name = "guna2Separator4";
            this.guna2Separator4.Size = new System.Drawing.Size(579, 10);
            this.guna2Separator4.TabIndex = 73;
            this.guna2Separator4.UseTransparentBackground = true;
            // 
            // LabelHeader3
            // 
            this.LabelHeader3.AutoSize = true;
            this.LabelHeader3.BackColor = System.Drawing.Color.White;
            this.LabelHeader3.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelHeader3.Font = new System.Drawing.Font("SSTW20-Medium", 12.75F);
            this.LabelHeader3.ForeColor = System.Drawing.Color.Black;
            this.LabelHeader3.Location = new System.Drawing.Point(0, 10);
            this.LabelHeader3.Name = "LabelHeader3";
            this.LabelHeader3.Size = new System.Drawing.Size(104, 20);
            this.LabelHeader3.TabIndex = 45;
            this.LabelHeader3.Text = "PRX STATUS";
            // 
            // guna2Separator5
            // 
            this.guna2Separator5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator5.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Separator5.FillColor = System.Drawing.Color.Black;
            this.guna2Separator5.Location = new System.Drawing.Point(0, 0);
            this.guna2Separator5.Name = "guna2Separator5";
            this.guna2Separator5.Size = new System.Drawing.Size(579, 10);
            this.guna2Separator5.TabIndex = 44;
            this.guna2Separator5.UseTransparentBackground = true;
            // 
            // ContextStripPower
            // 
            this.ContextStripPower.BackColor = System.Drawing.Color.White;
            this.ContextStripPower.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.powerOffToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.restartFullACToolStripMenuItem});
            this.ContextStripPower.Name = "guna2ContextMenuStrip1";
            this.ContextStripPower.RenderStyle.ArrowColor = System.Drawing.Color.Blue;
            this.ContextStripPower.RenderStyle.BorderColor = System.Drawing.Color.Gray;
            this.ContextStripPower.RenderStyle.ColorTable = null;
            this.ContextStripPower.RenderStyle.RoundedEdges = true;
            this.ContextStripPower.RenderStyle.SelectionArrowColor = System.Drawing.Color.Gray;
            this.ContextStripPower.RenderStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.ContextStripPower.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.ContextStripPower.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.ContextStripPower.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.ContextStripPower.ShowItemToolTips = false;
            this.ContextStripPower.Size = new System.Drawing.Size(152, 70);
            // 
            // powerOffToolStripMenuItem
            // 
            this.powerOffToolStripMenuItem.Image = global::PSS3.Properties.Resources.shutdown_88px;
            this.powerOffToolStripMenuItem.Name = "powerOffToolStripMenuItem";
            this.powerOffToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.powerOffToolStripMenuItem.Text = "PowerOff";
            this.powerOffToolStripMenuItem.Click += new System.EventHandler(this.powerOffToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Image = global::PSS3.Properties.Resources.restart_88px;
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // restartFullACToolStripMenuItem
            // 
            this.restartFullACToolStripMenuItem.Image = global::PSS3.Properties.Resources.flash_on_88px;
            this.restartFullACToolStripMenuItem.Name = "restartFullACToolStripMenuItem";
            this.restartFullACToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.restartFullACToolStripMenuItem.Text = "Restart Full AC";
            this.restartFullACToolStripMenuItem.Click += new System.EventHandler(this.restartFullACToolStripMenuItem_Click);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 175);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(150, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(150, 25);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightToolStripPanel.Location = new System.Drawing.Point(150, 25);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 150);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 25);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 150);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 150);
            // 
            // GameListSelectedContextMenuStrip
            // 
            this.GameListSelectedContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GameListSelectedGameTitleToolStrip,
            this.toolStripSeparator1,
            this.openPathToolStripMenuItem,
            this.saveGameCoverToolStripMenuItem,
            this.nPMountWBMToolStripMenuItem,
            this.requestUninstallToolStripMenuItem,
            this.openPARAMSFOToolStripMenuItem});
            this.GameListSelectedContextMenuStrip.Name = "guna2ContextMenuStrip1";
            this.GameListSelectedContextMenuStrip.RenderStyle.ArrowColor = System.Drawing.Color.Blue;
            this.GameListSelectedContextMenuStrip.RenderStyle.BorderColor = System.Drawing.Color.Gray;
            this.GameListSelectedContextMenuStrip.RenderStyle.ColorTable = null;
            this.GameListSelectedContextMenuStrip.RenderStyle.RoundedEdges = true;
            this.GameListSelectedContextMenuStrip.RenderStyle.SelectionArrowColor = System.Drawing.Color.Gray;
            this.GameListSelectedContextMenuStrip.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GameListSelectedContextMenuStrip.RenderStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.GameListSelectedContextMenuStrip.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.GameListSelectedContextMenuStrip.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.GameListSelectedContextMenuStrip.ShowItemToolTips = false;
            this.GameListSelectedContextMenuStrip.Size = new System.Drawing.Size(206, 142);
            // 
            // GameListSelectedGameTitleToolStrip
            // 
            this.GameListSelectedGameTitleToolStrip.Name = "GameListSelectedGameTitleToolStrip";
            this.GameListSelectedGameTitleToolStrip.Size = new System.Drawing.Size(205, 22);
            this.GameListSelectedGameTitleToolStrip.Text = "[Title]";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
            // 
            // openPathToolStripMenuItem
            // 
            this.openPathToolStripMenuItem.Name = "openPathToolStripMenuItem";
            this.openPathToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.openPathToolStripMenuItem.Text = "Open Path...";
            // 
            // saveGameCoverToolStripMenuItem
            // 
            this.saveGameCoverToolStripMenuItem.Name = "saveGameCoverToolStripMenuItem";
            this.saveGameCoverToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.saveGameCoverToolStripMenuItem.Text = "Save Game Cover";
            // 
            // nPMountWBMToolStripMenuItem
            // 
            this.nPMountWBMToolStripMenuItem.Name = "nPMountWBMToolStripMenuItem";
            this.nPMountWBMToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.nPMountWBMToolStripMenuItem.Text = "NP Mount (WBM)";
            // 
            // requestUninstallToolStripMenuItem
            // 
            this.requestUninstallToolStripMenuItem.Name = "requestUninstallToolStripMenuItem";
            this.requestUninstallToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.requestUninstallToolStripMenuItem.Text = "Request Uninstall (WBM)";
            // 
            // openPARAMSFOToolStripMenuItem
            // 
            this.openPARAMSFOToolStripMenuItem.Name = "openPARAMSFOToolStripMenuItem";
            this.openPARAMSFOToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.openPARAMSFOToolStripMenuItem.Text = "Open PARAM.SFO";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ButtonSendNotify);
            this.panel2.Controls.Add(this.TXT_MAPI_NOTIFY);
            this.panel2.Controls.Add(this.guna2Separator1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.guna2Separator2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(16, 503);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(581, 262);
            this.panel2.TabIndex = 91;
            // 
            // TXT_MAPI_NOTIFY
            // 
            this.TXT_MAPI_NOTIFY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXT_MAPI_NOTIFY.DefaultText = "";
            this.TXT_MAPI_NOTIFY.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TXT_MAPI_NOTIFY.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TXT_MAPI_NOTIFY.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXT_MAPI_NOTIFY.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXT_MAPI_NOTIFY.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXT_MAPI_NOTIFY.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXT_MAPI_NOTIFY.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXT_MAPI_NOTIFY.Location = new System.Drawing.Point(64, 46);
            this.TXT_MAPI_NOTIFY.Name = "TXT_MAPI_NOTIFY";
            this.TXT_MAPI_NOTIFY.PasswordChar = '\0';
            this.TXT_MAPI_NOTIFY.PlaceholderText = "";
            this.TXT_MAPI_NOTIFY.SelectedText = "";
            this.TXT_MAPI_NOTIFY.Size = new System.Drawing.Size(395, 27);
            this.TXT_MAPI_NOTIFY.TabIndex = 74;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Separator1.FillColor = System.Drawing.Color.Black;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 30);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(579, 10);
            this.guna2Separator1.TabIndex = 73;
            this.guna2Separator1.UseTransparentBackground = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("SSTW20-Medium", 12.75F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(0, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 45;
            this.label10.Text = "MISC";
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Separator2.FillColor = System.Drawing.Color.Black;
            this.guna2Separator2.Location = new System.Drawing.Point(0, 0);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(579, 10);
            this.guna2Separator2.TabIndex = 44;
            this.guna2Separator2.UseTransparentBackground = true;
            // 
            // ButtonSendNotify
            // 
            this.ButtonSendNotify.Animated = true;
            this.ButtonSendNotify.BackColor = System.Drawing.Color.Transparent;
            this.ButtonSendNotify.BorderColor = System.Drawing.Color.White;
            this.ButtonSendNotify.BorderRadius = 5;
            this.ButtonSendNotify.BorderThickness = 2;
            this.ButtonSendNotify.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonSendNotify.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonSendNotify.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonSendNotify.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonSendNotify.FillColor = System.Drawing.Color.Black;
            this.ButtonSendNotify.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSendNotify.ForeColor = System.Drawing.Color.White;
            this.ButtonSendNotify.Location = new System.Drawing.Point(465, 46);
            this.ButtonSendNotify.Name = "ButtonSendNotify";
            this.ButtonSendNotify.Size = new System.Drawing.Size(91, 27);
            this.ButtonSendNotify.TabIndex = 23;
            this.ButtonSendNotify.Text = "Send";
            this.ButtonSendNotify.UseTransparentBackground = true;
            this.ButtonSendNotify.Click += new System.EventHandler(this.ButtonSendNotify_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 85;
            this.label4.Text = "Notify";
            // 
            // ListViewGames
            // 
            this.ListViewGames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListViewGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewGames.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListViewGames.HideSelection = false;
            this.ListViewGames.Location = new System.Drawing.Point(3, 3);
            this.ListViewGames.MultiSelectedContextMenuStrip = null;
            this.ListViewGames.Name = "ListViewGames";
            this.ListViewGames.SingleSelectedContextMenuStrip = null;
            this.ListViewGames.Size = new System.Drawing.Size(652, 327);
            this.ListViewGames.TabIndex = 37;
            this.ListViewGames.TileSize = new System.Drawing.Size(80, 40);
            this.ListViewGames.UseCompatibleStateImageBehavior = false;
            this.ListViewGames.SelectedIndexChanged += new System.EventHandler(this.ListViewGames_SelectedIndexChanged);
            this.ListViewGames.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListViewGames_MouseClick);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("SST", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(393, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Developed by D.s.j.";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(846, 483);
            this.Controls.Add(this._TC_MainContainer);
            this.Controls.Add(this.TopperPanel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(862, 522);
            this.Name = "DashboardForm";
            this.Text = "PSS3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DashboardForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.IconAvatar)).EndInit();
            this.ContextStripOptions.ResumeLayout(false);
            this.TopperPanel.ResumeLayout(false);
            this.TopperPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericRefreshInterval)).EndInit();
            this._TC_MainContainer.ResumeLayout(false);
            this._TC_DASHBOARD_STATUS.ResumeLayout(false);
            this._TC_DASHBOARD_STATUS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_PS3ICON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XmbImage)).EndInit();
            this._TC_DASHBOARD_GAMELIST.ResumeLayout(false);
            this._TC_DASHBOARD_FRIENDLIST.ResumeLayout(false);
            this._TC_DASHBOARD_FRIENDLIST.PerformLayout();
            this.StatusStripFriendsMenu.ResumeLayout(false);
            this.StatusStripFriendsMenu.PerformLayout();
            this._TC_DASHBOARD_SAVEGAMELIST.ResumeLayout(false);
            this.SC_SAVDAT_CONTAINER.Panel1.ResumeLayout(false);
            this.SC_SAVDAT_CONTAINER.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SC_SAVDAT_CONTAINER)).EndInit();
            this.SC_SAVDAT_CONTAINER.ResumeLayout(false);
            this.SaveDatInfoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_SAVDATICO)).EndInit();
            this._TC_DASHBOARD_MAPI.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ContextStripPower.ResumeLayout(false);
            this.GameListSelectedContextMenuStrip.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox IconAvatar;
        private System.Windows.Forms.Label LabelPsnId;
        private Guna.UI2.WinForms.Guna2ImageButton ButtonImgSignOut;
        private Guna.UI2.WinForms.Guna2Button ButtonStore;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip ContextStripOptions;
        private System.Windows.Forms.ToolStripMenuItem pS3ToolStripMenuItem;
        private MetroFramework.Controls.MetroProgressSpinner ProgressBar;
        private System.Windows.Forms.Label LabelLogMessage;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cWToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button ButtonOptions;
        private System.Windows.Forms.TextBox TextBoxComment;
        private System.Windows.Forms.ToolTip _Tooltip;
        private System.Windows.Forms.ToolStripMenuItem sysInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discordOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem privateInformationToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ShadowPanel TopperPanel;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TabControl _TC_MainContainer;
        private System.Windows.Forms.TabPage _TC_DASHBOARD_GAMELIST;
        private System.Windows.Forms.TabPage _TC_DASHBOARD_SAVEGAMELIST;
        private ChangableMenuListView ListViewGames;
        private System.Windows.Forms.TabPage _TC_DASHBOARD_FRIENDLIST;
        private System.Windows.Forms.ListView ListViewSaves;
        private Guna.UI2.WinForms.Guna2Button ButtonPower;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip ContextStripPower;
        private System.Windows.Forms.ToolStripMenuItem powerOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartFullACToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tESTMSGFORMToolStripMenuItem;
        private System.Windows.Forms.TabPage _TC_DASHBOARD_MAPI;
        private System.Windows.Forms.ListView ListViewFriends;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.StatusStrip StatusStripFriendsMenu;
        private System.Windows.Forms.ToolStripStatusLabel TTSL_FriendCount;
        private System.Windows.Forms.ToolStripStatusLabel TTSL_SelDat;
        private System.Windows.Forms.ToolStripStatusLabel TTSL_DumpFriendAvatar;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2TextBox txt_prx_4;
        private Guna.UI2.WinForms.Guna2TextBox txt_prx_3;
        private Guna.UI2.WinForms.Guna2TextBox txt_prx_2;
        private Guna.UI2.WinForms.Guna2TextBox txt_prx_1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator4;
        private System.Windows.Forms.Label LabelHeader3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator5;
        private System.Windows.Forms.Label LBL_PRX6;
        private System.Windows.Forms.Label LBL_PRX5;
        private System.Windows.Forms.Label LBL_PRX4;
        private System.Windows.Forms.Label LBL_PRX3;
        private System.Windows.Forms.Label LBL_PRX2;
        private System.Windows.Forms.Label LBL_PRX1;
        private Guna.UI2.WinForms.Guna2TextBox txt_prx_6;
        private Guna.UI2.WinForms.Guna2TextBox txt_prx_5;
        private Guna.UI2.WinForms.Guna2Button btn_prx_1;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.SplitContainer SC_SAVDAT_CONTAINER;
        private System.Windows.Forms.Panel SaveDatInfoPanel;
        private System.Windows.Forms.PictureBox PB_SAVDATICO;
        private System.Windows.Forms.RichTextBox RTB_SAVDATINFO;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip GameListSelectedContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem openPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nPMountWBMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestUninstallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPARAMSFOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGameCoverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GameListSelectedGameTitleToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TabPage _TC_DASHBOARD_STATUS;
        private System.Windows.Forms.Label LabelInfoFirmType;
        private System.Windows.Forms.Label LabelSysName;
        private Guna.UI2.WinForms.Guna2PictureBox PB_PS3ICON;
        private System.Windows.Forms.Label LabelInfoHdd;
        private System.Windows.Forms.Label LabelInfoMem;
        private Guna.UI2.WinForms.Guna2PictureBox XmbImage;
        private System.Windows.Forms.Label LabelInfoTemp;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator8;
        private System.Windows.Forms.Label LabelInfoLife;
        private System.Windows.Forms.Label LabelInfoFan;
        private Guna.UI2.WinForms.Guna2ImageButton ButtonUpdate;
        private System.Windows.Forms.Label LabelInfoFirmware;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelGameTitle;
        private System.Windows.Forms.Label LabelGameElapsed;
        private System.Windows.Forms.Label LabelSysTime;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericRefreshInterval;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button ButtonSendNotify;
        private Guna.UI2.WinForms.Guna2TextBox TXT_MAPI_NOTIFY;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}