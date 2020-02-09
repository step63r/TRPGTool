namespace TRPGTool
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.プレイヤーPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新規作成NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.読み込みLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pLの管理MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tRPGToolの終了XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ロールRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nDmロールNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.抵抗ロールRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.一時的狂気ロールTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.長期一時的狂気ロールLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ビューVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.探索者情報IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.コンソールCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.PLStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.POWStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MPStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SANStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.cmbNumber = new System.Windows.Forms.ComboBox();
            this.txtD = new System.Windows.Forms.Label();
            this.cmbDice = new System.Windows.Forms.ComboBox();
            this.nDmRollButton = new System.Windows.Forms.Button();
            this.txtSubResult = new System.Windows.Forms.TextBox();
            this.grpnDm = new System.Windows.Forms.GroupBox();
            this.grpRes = new System.Windows.Forms.GroupBox();
            this.ResRollButton = new System.Windows.Forms.Button();
            this.cmbJudou = new System.Windows.Forms.ComboBox();
            this.cmbNoudou = new System.Windows.Forms.ComboBox();
            this.txtJudou = new System.Windows.Forms.Label();
            this.txtNoudou = new System.Windows.Forms.Label();
            this.grpBasis = new System.Windows.Forms.GroupBox();
            this.BasicValue = new System.Windows.Forms.NumericUpDown();
            this.BasicRoll = new System.Windows.Forms.Button();
            this.BasicName = new System.Windows.Forms.ComboBox();
            this.grpSkill = new System.Windows.Forms.GroupBox();
            this.SkillRoll = new System.Windows.Forms.Button();
            this.SkillValue = new System.Windows.Forms.NumericUpDown();
            this.SkillName = new System.Windows.Forms.ComboBox();
            this.grpBattle = new System.Windows.Forms.GroupBox();
            this.BattleRoll = new System.Windows.Forms.Button();
            this.BattleValue = new System.Windows.Forms.NumericUpDown();
            this.BattleName = new System.Windows.Forms.ComboBox();
            this.grpAll = new System.Windows.Forms.GroupBox();
            this.AllRoll = new System.Windows.Forms.Button();
            this.AllValue = new System.Windows.Forms.NumericUpDown();
            this.AllName = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.grpnDm.SuspendLayout();
            this.grpRes.SuspendLayout();
            this.grpBasis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BasicValue)).BeginInit();
            this.grpSkill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SkillValue)).BeginInit();
            this.grpBattle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BattleValue)).BeginInit();
            this.grpAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllValue)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.プレイヤーPToolStripMenuItem,
            this.ロールRToolStripMenuItem,
            this.ビューVToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(577, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // プレイヤーPToolStripMenuItem
            // 
            this.プレイヤーPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新規作成NToolStripMenuItem,
            this.読み込みLToolStripMenuItem,
            this.pLの管理MToolStripMenuItem,
            this.toolStripSeparator1,
            this.tRPGToolの終了XToolStripMenuItem});
            this.プレイヤーPToolStripMenuItem.Name = "プレイヤーPToolStripMenuItem";
            this.プレイヤーPToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.プレイヤーPToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 新規作成NToolStripMenuItem
            // 
            this.新規作成NToolStripMenuItem.Name = "新規作成NToolStripMenuItem";
            this.新規作成NToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.新規作成NToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.新規作成NToolStripMenuItem.Text = "PLの新規作成(&N)...";
            this.新規作成NToolStripMenuItem.Click += new System.EventHandler(this.新規作成NToolStripMenuItem_Click);
            // 
            // 読み込みLToolStripMenuItem
            // 
            this.読み込みLToolStripMenuItem.Name = "読み込みLToolStripMenuItem";
            this.読み込みLToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.読み込みLToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.読み込みLToolStripMenuItem.Text = "PLの読み込み(&L)...";
            this.読み込みLToolStripMenuItem.Click += new System.EventHandler(this.読み込みLToolStripMenuItem_Click);
            // 
            // pLの管理MToolStripMenuItem
            // 
            this.pLの管理MToolStripMenuItem.Name = "pLの管理MToolStripMenuItem";
            this.pLの管理MToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.pLの管理MToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.pLの管理MToolStripMenuItem.Text = "PLの保存(&A)...";
            this.pLの管理MToolStripMenuItem.Click += new System.EventHandler(this.pLの管理MToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(235, 6);
            // 
            // tRPGToolの終了XToolStripMenuItem
            // 
            this.tRPGToolの終了XToolStripMenuItem.Name = "tRPGToolの終了XToolStripMenuItem";
            this.tRPGToolの終了XToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.tRPGToolの終了XToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.tRPGToolの終了XToolStripMenuItem.Text = "TRPG Toolの終了(&X)";
            this.tRPGToolの終了XToolStripMenuItem.Click += new System.EventHandler(this.tRPGToolの終了XToolStripMenuItem_Click);
            // 
            // ロールRToolStripMenuItem
            // 
            this.ロールRToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nDmロールNToolStripMenuItem,
            this.抵抗ロールRToolStripMenuItem,
            this.toolStripSeparator2,
            this.一時的狂気ロールTToolStripMenuItem,
            this.長期一時的狂気ロールLToolStripMenuItem});
            this.ロールRToolStripMenuItem.Name = "ロールRToolStripMenuItem";
            this.ロールRToolStripMenuItem.Size = new System.Drawing.Size(74, 22);
            this.ロールRToolStripMenuItem.Text = "ロール(&R)";
            // 
            // nDmロールNToolStripMenuItem
            // 
            this.nDmロールNToolStripMenuItem.Enabled = false;
            this.nDmロールNToolStripMenuItem.Name = "nDmロールNToolStripMenuItem";
            this.nDmロールNToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.nDmロールNToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.nDmロールNToolStripMenuItem.Text = "nDmロール(&N)...";
            this.nDmロールNToolStripMenuItem.Click += new System.EventHandler(this.nDmロールNToolStripMenuItem_Click);
            // 
            // 抵抗ロールRToolStripMenuItem
            // 
            this.抵抗ロールRToolStripMenuItem.Enabled = false;
            this.抵抗ロールRToolStripMenuItem.Name = "抵抗ロールRToolStripMenuItem";
            this.抵抗ロールRToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.抵抗ロールRToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.抵抗ロールRToolStripMenuItem.Text = "抵抗ロール(&R)...";
            this.抵抗ロールRToolStripMenuItem.Click += new System.EventHandler(this.抵抗ロールRToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(216, 6);
            // 
            // 一時的狂気ロールTToolStripMenuItem
            // 
            this.一時的狂気ロールTToolStripMenuItem.Name = "一時的狂気ロールTToolStripMenuItem";
            this.一時的狂気ロールTToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.一時的狂気ロールTToolStripMenuItem.Text = "短期一時的狂気ロール(&S)";
            this.一時的狂気ロールTToolStripMenuItem.Click += new System.EventHandler(this.一時的狂気ロールTToolStripMenuItem_Click);
            // 
            // 長期一時的狂気ロールLToolStripMenuItem
            // 
            this.長期一時的狂気ロールLToolStripMenuItem.Name = "長期一時的狂気ロールLToolStripMenuItem";
            this.長期一時的狂気ロールLToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.長期一時的狂気ロールLToolStripMenuItem.Text = "長期一時的狂気ロール(&L)";
            this.長期一時的狂気ロールLToolStripMenuItem.Click += new System.EventHandler(this.長期一時的狂気ロールLToolStripMenuItem_Click);
            // 
            // ビューVToolStripMenuItem
            // 
            this.ビューVToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.探索者情報IToolStripMenuItem,
            this.コンソールCToolStripMenuItem});
            this.ビューVToolStripMenuItem.Name = "ビューVToolStripMenuItem";
            this.ビューVToolStripMenuItem.Size = new System.Drawing.Size(74, 22);
            this.ビューVToolStripMenuItem.Text = "ビュー(&V)";
            // 
            // 探索者情報IToolStripMenuItem
            // 
            this.探索者情報IToolStripMenuItem.Enabled = false;
            this.探索者情報IToolStripMenuItem.Name = "探索者情報IToolStripMenuItem";
            this.探索者情報IToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.探索者情報IToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.探索者情報IToolStripMenuItem.Text = "探索者情報(&I)";
            this.探索者情報IToolStripMenuItem.Click += new System.EventHandler(this.探索者情報IToolStripMenuItem_Click);
            // 
            // コンソールCToolStripMenuItem
            // 
            this.コンソールCToolStripMenuItem.Name = "コンソールCToolStripMenuItem";
            this.コンソールCToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.コンソールCToolStripMenuItem.Text = "コンソール(&C)";
            this.コンソールCToolStripMenuItem.Click += new System.EventHandler(this.コンソールCToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PLStatusLabel,
            this.POWStatusLabel,
            this.MPStatusLabel,
            this.SANStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 379);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(577, 23);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // PLStatusLabel
            // 
            this.PLStatusLabel.Name = "PLStatusLabel";
            this.PLStatusLabel.Size = new System.Drawing.Size(68, 18);
            this.PLStatusLabel.Text = "string PL |";
            // 
            // POWStatusLabel
            // 
            this.POWStatusLabel.Name = "POWStatusLabel";
            this.POWStatusLabel.Size = new System.Drawing.Size(52, 18);
            this.POWStatusLabel.Text = "int HP |";
            // 
            // MPStatusLabel
            // 
            this.MPStatusLabel.Name = "MPStatusLabel";
            this.MPStatusLabel.Size = new System.Drawing.Size(53, 18);
            this.MPStatusLabel.Text = "int MP |";
            // 
            // SANStatusLabel
            // 
            this.SANStatusLabel.Name = "SANStatusLabel";
            this.SANStatusLabel.Size = new System.Drawing.Size(129, 18);
            this.SANStatusLabel.Text = "int SAN = POW * 5 |";
            // 
            // txtResult
            // 
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResult.Font = new System.Drawing.Font("Meiryo UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtResult.Location = new System.Drawing.Point(253, 332);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(312, 44);
            this.txtResult.TabIndex = 2;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbNumber
            // 
            this.cmbNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumber.FormattingEnabled = true;
            this.cmbNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbNumber.Location = new System.Drawing.Point(6, 37);
            this.cmbNumber.Name = "cmbNumber";
            this.cmbNumber.Size = new System.Drawing.Size(54, 25);
            this.cmbNumber.TabIndex = 3;
            // 
            // txtD
            // 
            this.txtD.AutoSize = true;
            this.txtD.Font = new System.Drawing.Font("Meiryo UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtD.Location = new System.Drawing.Point(66, 20);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(42, 41);
            this.txtD.TabIndex = 4;
            this.txtD.Text = "D";
            // 
            // cmbDice
            // 
            this.cmbDice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDice.FormattingEnabled = true;
            this.cmbDice.Items.AddRange(new object[] {
            "3",
            "4",
            "6",
            "8",
            "10",
            "12",
            "20",
            "100"});
            this.cmbDice.Location = new System.Drawing.Point(114, 37);
            this.cmbDice.Name = "cmbDice";
            this.cmbDice.Size = new System.Drawing.Size(54, 25);
            this.cmbDice.TabIndex = 5;
            // 
            // nDmRollButton
            // 
            this.nDmRollButton.Location = new System.Drawing.Point(6, 68);
            this.nDmRollButton.Name = "nDmRollButton";
            this.nDmRollButton.Size = new System.Drawing.Size(162, 25);
            this.nDmRollButton.TabIndex = 6;
            this.nDmRollButton.Text = "Roll";
            this.nDmRollButton.UseVisualStyleBackColor = true;
            this.nDmRollButton.Click += new System.EventHandler(this.nDmRollButton_Click);
            // 
            // txtSubResult
            // 
            this.txtSubResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubResult.Location = new System.Drawing.Point(330, 302);
            this.txtSubResult.Name = "txtSubResult";
            this.txtSubResult.Size = new System.Drawing.Size(235, 24);
            this.txtSubResult.TabIndex = 7;
            this.txtSubResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpnDm
            // 
            this.grpnDm.Controls.Add(this.cmbNumber);
            this.grpnDm.Controls.Add(this.txtD);
            this.grpnDm.Controls.Add(this.nDmRollButton);
            this.grpnDm.Controls.Add(this.cmbDice);
            this.grpnDm.Location = new System.Drawing.Point(12, 31);
            this.grpnDm.Name = "grpnDm";
            this.grpnDm.Size = new System.Drawing.Size(180, 112);
            this.grpnDm.TabIndex = 8;
            this.grpnDm.TabStop = false;
            this.grpnDm.Text = "nDmロール";
            // 
            // grpRes
            // 
            this.grpRes.Controls.Add(this.ResRollButton);
            this.grpRes.Controls.Add(this.cmbJudou);
            this.grpRes.Controls.Add(this.cmbNoudou);
            this.grpRes.Controls.Add(this.txtJudou);
            this.grpRes.Controls.Add(this.txtNoudou);
            this.grpRes.Location = new System.Drawing.Point(12, 149);
            this.grpRes.Name = "grpRes";
            this.grpRes.Size = new System.Drawing.Size(180, 130);
            this.grpRes.TabIndex = 9;
            this.grpRes.TabStop = false;
            this.grpRes.Text = "抵抗ロール";
            // 
            // ResRollButton
            // 
            this.ResRollButton.Location = new System.Drawing.Point(6, 85);
            this.ResRollButton.Name = "ResRollButton";
            this.ResRollButton.Size = new System.Drawing.Size(162, 25);
            this.ResRollButton.TabIndex = 7;
            this.ResRollButton.Text = "Roll";
            this.ResRollButton.UseVisualStyleBackColor = true;
            this.ResRollButton.Click += new System.EventHandler(this.ResRollButton_Click);
            // 
            // cmbJudou
            // 
            this.cmbJudou.DropDownHeight = 140;
            this.cmbJudou.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJudou.FormattingEnabled = true;
            this.cmbJudou.IntegralHeight = false;
            this.cmbJudou.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.cmbJudou.Location = new System.Drawing.Point(69, 54);
            this.cmbJudou.Name = "cmbJudou";
            this.cmbJudou.Size = new System.Drawing.Size(99, 25);
            this.cmbJudou.TabIndex = 3;
            // 
            // cmbNoudou
            // 
            this.cmbNoudou.DropDownHeight = 140;
            this.cmbNoudou.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNoudou.FormattingEnabled = true;
            this.cmbNoudou.IntegralHeight = false;
            this.cmbNoudou.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.cmbNoudou.Location = new System.Drawing.Point(69, 23);
            this.cmbNoudou.Name = "cmbNoudou";
            this.cmbNoudou.Size = new System.Drawing.Size(99, 25);
            this.cmbNoudou.TabIndex = 2;
            // 
            // txtJudou
            // 
            this.txtJudou.AutoSize = true;
            this.txtJudou.Location = new System.Drawing.Point(6, 57);
            this.txtJudou.Name = "txtJudou";
            this.txtJudou.Size = new System.Drawing.Size(57, 17);
            this.txtJudou.TabIndex = 1;
            this.txtJudou.Text = "受動側: ";
            // 
            // txtNoudou
            // 
            this.txtNoudou.AutoSize = true;
            this.txtNoudou.Location = new System.Drawing.Point(6, 26);
            this.txtNoudou.Name = "txtNoudou";
            this.txtNoudou.Size = new System.Drawing.Size(57, 17);
            this.txtNoudou.TabIndex = 0;
            this.txtNoudou.Text = "能動側: ";
            // 
            // grpBasis
            // 
            this.grpBasis.Controls.Add(this.BasicValue);
            this.grpBasis.Controls.Add(this.BasicRoll);
            this.grpBasis.Controls.Add(this.BasicName);
            this.grpBasis.Enabled = false;
            this.grpBasis.Location = new System.Drawing.Point(198, 31);
            this.grpBasis.Name = "grpBasis";
            this.grpBasis.Size = new System.Drawing.Size(180, 112);
            this.grpBasis.TabIndex = 10;
            this.grpBasis.TabStop = false;
            this.grpBasis.Text = "基本値";
            // 
            // BasicValue
            // 
            this.BasicValue.Location = new System.Drawing.Point(119, 25);
            this.BasicValue.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.BasicValue.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.BasicValue.Name = "BasicValue";
            this.BasicValue.Size = new System.Drawing.Size(55, 24);
            this.BasicValue.TabIndex = 2;
            // 
            // BasicRoll
            // 
            this.BasicRoll.Location = new System.Drawing.Point(6, 68);
            this.BasicRoll.Name = "BasicRoll";
            this.BasicRoll.Size = new System.Drawing.Size(168, 25);
            this.BasicRoll.TabIndex = 1;
            this.BasicRoll.Text = "Roll";
            this.BasicRoll.UseVisualStyleBackColor = true;
            this.BasicRoll.Click += new System.EventHandler(this.BasicRoll_Click);
            // 
            // BasicName
            // 
            this.BasicName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BasicName.FormattingEnabled = true;
            this.BasicName.Location = new System.Drawing.Point(6, 24);
            this.BasicName.Name = "BasicName";
            this.BasicName.Size = new System.Drawing.Size(107, 25);
            this.BasicName.TabIndex = 0;
            // 
            // grpSkill
            // 
            this.grpSkill.Controls.Add(this.SkillRoll);
            this.grpSkill.Controls.Add(this.SkillValue);
            this.grpSkill.Controls.Add(this.SkillName);
            this.grpSkill.Enabled = false;
            this.grpSkill.Location = new System.Drawing.Point(198, 149);
            this.grpSkill.Name = "grpSkill";
            this.grpSkill.Size = new System.Drawing.Size(180, 130);
            this.grpSkill.TabIndex = 11;
            this.grpSkill.TabStop = false;
            this.grpSkill.Text = "職業";
            // 
            // SkillRoll
            // 
            this.SkillRoll.Location = new System.Drawing.Point(6, 85);
            this.SkillRoll.Name = "SkillRoll";
            this.SkillRoll.Size = new System.Drawing.Size(168, 25);
            this.SkillRoll.TabIndex = 3;
            this.SkillRoll.Text = "Roll";
            this.SkillRoll.UseVisualStyleBackColor = true;
            this.SkillRoll.Click += new System.EventHandler(this.SkillRoll_Click);
            // 
            // SkillValue
            // 
            this.SkillValue.Location = new System.Drawing.Point(119, 27);
            this.SkillValue.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.SkillValue.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.SkillValue.Name = "SkillValue";
            this.SkillValue.Size = new System.Drawing.Size(55, 24);
            this.SkillValue.TabIndex = 3;
            // 
            // SkillName
            // 
            this.SkillName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SkillName.FormattingEnabled = true;
            this.SkillName.Location = new System.Drawing.Point(6, 26);
            this.SkillName.Name = "SkillName";
            this.SkillName.Size = new System.Drawing.Size(107, 25);
            this.SkillName.TabIndex = 3;
            // 
            // grpBattle
            // 
            this.grpBattle.Controls.Add(this.BattleRoll);
            this.grpBattle.Controls.Add(this.BattleValue);
            this.grpBattle.Controls.Add(this.BattleName);
            this.grpBattle.Enabled = false;
            this.grpBattle.Location = new System.Drawing.Point(384, 31);
            this.grpBattle.Name = "grpBattle";
            this.grpBattle.Size = new System.Drawing.Size(180, 112);
            this.grpBattle.TabIndex = 11;
            this.grpBattle.TabStop = false;
            this.grpBattle.Text = "戦闘";
            // 
            // BattleRoll
            // 
            this.BattleRoll.Location = new System.Drawing.Point(6, 68);
            this.BattleRoll.Name = "BattleRoll";
            this.BattleRoll.Size = new System.Drawing.Size(168, 25);
            this.BattleRoll.TabIndex = 3;
            this.BattleRoll.Text = "Roll";
            this.BattleRoll.UseVisualStyleBackColor = true;
            this.BattleRoll.Click += new System.EventHandler(this.BattleRoll_Click);
            // 
            // BattleValue
            // 
            this.BattleValue.Location = new System.Drawing.Point(119, 26);
            this.BattleValue.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.BattleValue.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.BattleValue.Name = "BattleValue";
            this.BattleValue.Size = new System.Drawing.Size(55, 24);
            this.BattleValue.TabIndex = 3;
            // 
            // BattleName
            // 
            this.BattleName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BattleName.FormattingEnabled = true;
            this.BattleName.Location = new System.Drawing.Point(6, 25);
            this.BattleName.Name = "BattleName";
            this.BattleName.Size = new System.Drawing.Size(107, 25);
            this.BattleName.TabIndex = 4;
            // 
            // grpAll
            // 
            this.grpAll.Controls.Add(this.AllRoll);
            this.grpAll.Controls.Add(this.AllValue);
            this.grpAll.Controls.Add(this.AllName);
            this.grpAll.Enabled = false;
            this.grpAll.Location = new System.Drawing.Point(384, 149);
            this.grpAll.Name = "grpAll";
            this.grpAll.Size = new System.Drawing.Size(180, 130);
            this.grpAll.TabIndex = 12;
            this.grpAll.TabStop = false;
            this.grpAll.Text = "全て";
            // 
            // AllRoll
            // 
            this.AllRoll.Location = new System.Drawing.Point(6, 85);
            this.AllRoll.Name = "AllRoll";
            this.AllRoll.Size = new System.Drawing.Size(168, 25);
            this.AllRoll.TabIndex = 4;
            this.AllRoll.Text = "Roll";
            this.AllRoll.UseVisualStyleBackColor = true;
            this.AllRoll.Click += new System.EventHandler(this.AllRoll_Click);
            // 
            // AllValue
            // 
            this.AllValue.Location = new System.Drawing.Point(119, 28);
            this.AllValue.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.AllValue.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.AllValue.Name = "AllValue";
            this.AllValue.Size = new System.Drawing.Size(55, 24);
            this.AllValue.TabIndex = 4;
            // 
            // AllName
            // 
            this.AllName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AllName.FormattingEnabled = true;
            this.AllName.Location = new System.Drawing.Point(6, 27);
            this.AllName.Name = "AllName";
            this.AllName.Size = new System.Drawing.Size(107, 25);
            this.AllName.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 402);
            this.Controls.Add(this.grpAll);
            this.Controls.Add(this.grpBattle);
            this.Controls.Add(this.grpSkill);
            this.Controls.Add(this.grpBasis);
            this.Controls.Add(this.grpRes);
            this.Controls.Add(this.grpnDm);
            this.Controls.Add(this.txtSubResult);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::TRPGTool.Properties.Settings.Default, "Form1Default", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = global::TRPGTool.Properties.Settings.Default.Form1Default;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "TRPG Tool";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grpnDm.ResumeLayout(false);
            this.grpnDm.PerformLayout();
            this.grpRes.ResumeLayout(false);
            this.grpRes.PerformLayout();
            this.grpBasis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BasicValue)).EndInit();
            this.grpSkill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SkillValue)).EndInit();
            this.grpBattle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BattleValue)).EndInit();
            this.grpAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AllValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem プレイヤーPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新規作成NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 読み込みLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pLの管理MToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tRPGToolの終了XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ロールRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nDmロールNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 抵抗ロールRToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 一時的狂気ロールTToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbNumber;
        private System.Windows.Forms.Label txtD;
        private System.Windows.Forms.ComboBox cmbDice;
        private System.Windows.Forms.Button nDmRollButton;
        private System.Windows.Forms.TextBox txtSubResult;
        private System.Windows.Forms.GroupBox grpnDm;
        private System.Windows.Forms.GroupBox grpRes;
        private System.Windows.Forms.ComboBox cmbJudou;
        private System.Windows.Forms.ComboBox cmbNoudou;
        private System.Windows.Forms.Label txtJudou;
        private System.Windows.Forms.Label txtNoudou;
        private System.Windows.Forms.Button ResRollButton;
        public System.Windows.Forms.ToolStripStatusLabel PLStatusLabel;
        public System.Windows.Forms.ToolStripStatusLabel POWStatusLabel;
        public System.Windows.Forms.ToolStripStatusLabel SANStatusLabel;
        public System.Windows.Forms.ToolStripStatusLabel MPStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem ビューVToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown BasicValue;
        private System.Windows.Forms.Button BasicRoll;
        private System.Windows.Forms.Button SkillRoll;
        private System.Windows.Forms.NumericUpDown SkillValue;
        private System.Windows.Forms.Button BattleRoll;
        private System.Windows.Forms.NumericUpDown BattleValue;
        private System.Windows.Forms.Button AllRoll;
        private System.Windows.Forms.NumericUpDown AllValue;
        public System.Windows.Forms.GroupBox grpBasis;
        public System.Windows.Forms.GroupBox grpSkill;
        public System.Windows.Forms.GroupBox grpBattle;
        public System.Windows.Forms.GroupBox grpAll;
        public System.Windows.Forms.ComboBox BasicName;
        public System.Windows.Forms.ComboBox SkillName;
        public System.Windows.Forms.ComboBox BattleName;
        public System.Windows.Forms.ComboBox AllName;
        public System.Windows.Forms.ToolStripMenuItem 探索者情報IToolStripMenuItem;
        public System.Windows.Forms.TextBox txtResult;
        public System.Windows.Forms.ToolStripMenuItem コンソールCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 長期一時的狂気ロールLToolStripMenuItem;
    }
}

