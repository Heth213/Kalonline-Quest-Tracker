namespace Kal_Quests_Tracker
{
    partial class Form1
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


        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelQuestDetails;
        private System.Windows.Forms.RichTextBox richTextBoxQuestDetails;
        private System.Windows.Forms.Panel panelQuestHeader;
        private System.Windows.Forms.CheckBox checkBoxQuestCompleted;
        private System.Windows.Forms.Label labelQuestTitle;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.ListBox listBoxQuests;
        private System.Windows.Forms.Panel panelQuestFilters;
        private System.Windows.Forms.CheckBox checkBoxShowCompleted;
        private System.Windows.Forms.ComboBox comboBoxQuestType;
        private System.Windows.Forms.Label labelQuestType;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button buttonSaveProfile;
        private System.Windows.Forms.Button buttonLoadProfile;
        private System.Windows.Forms.TextBox textBoxCharacterName;
        private System.Windows.Forms.Label labelCharacterName;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelQuestDetails = new System.Windows.Forms.Panel();
            this.richTextBoxQuestDetails = new System.Windows.Forms.RichTextBox();
            this.panelQuestHeader = new System.Windows.Forms.Panel();
            this.mapBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxQuestCompleted = new System.Windows.Forms.CheckBox();
            this.labelQuestTitle = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.listBoxQuests = new System.Windows.Forms.ListBox();
            this.panelQuestFilters = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxShowCompleted = new System.Windows.Forms.CheckBox();
            this.comboBoxQuestType = new System.Windows.Forms.ComboBox();
            this.labelQuestType = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonReset = new System.Windows.Forms.Button();
            this.lblCredit = new System.Windows.Forms.Label();
            this.buttonSaveProfile = new System.Windows.Forms.Button();
            this.buttonLoadProfile = new System.Windows.Forms.Button();
            this.textBoxCharacterName = new System.Windows.Forms.TextBox();
            this.labelCharacterName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelQuestDetails.SuspendLayout();
            this.panelQuestHeader.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelQuestFilters.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelRight);
            this.panelMain.Controls.Add(this.panelLeft);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 60);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1084, 702);
            this.panelMain.TabIndex = 0;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panelRight.Controls.Add(this.label3);
            this.panelRight.Controls.Add(this.panelQuestDetails);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(260, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(10);
            this.panelRight.Size = new System.Drawing.Size(824, 702);
            this.panelRight.TabIndex = 1;
            // 
            // panelQuestDetails
            // 
            this.panelQuestDetails.Controls.Add(this.richTextBoxQuestDetails);
            this.panelQuestDetails.Controls.Add(this.panelQuestHeader);
            this.panelQuestDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQuestDetails.Location = new System.Drawing.Point(10, 10);
            this.panelQuestDetails.Name = "panelQuestDetails";
            this.panelQuestDetails.Size = new System.Drawing.Size(804, 682);
            this.panelQuestDetails.TabIndex = 0;
            // 
            // richTextBoxQuestDetails
            // 
            this.richTextBoxQuestDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.richTextBoxQuestDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxQuestDetails.CausesValidation = false;
            this.richTextBoxQuestDetails.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBoxQuestDetails.DetectUrls = false;
            this.richTextBoxQuestDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxQuestDetails.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxQuestDetails.ForeColor = System.Drawing.Color.White;
            this.richTextBoxQuestDetails.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.richTextBoxQuestDetails.Location = new System.Drawing.Point(0, 50);
            this.richTextBoxQuestDetails.Name = "richTextBoxQuestDetails";
            this.richTextBoxQuestDetails.ReadOnly = true;
            this.richTextBoxQuestDetails.Size = new System.Drawing.Size(804, 632);
            this.richTextBoxQuestDetails.TabIndex = 1;
            this.richTextBoxQuestDetails.Text = "Select a quest to view details...";
            this.richTextBoxQuestDetails.WordWrap = false;
            this.richTextBoxQuestDetails.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.RichTextBoxQuestDetails_MouseDoubleClick);
            // 
            // panelQuestHeader
            // 
            this.panelQuestHeader.Controls.Add(this.button5);
            this.panelQuestHeader.Controls.Add(this.button4);
            this.panelQuestHeader.Controls.Add(this.button3);
            this.panelQuestHeader.Controls.Add(this.button2);
            this.panelQuestHeader.Controls.Add(this.button1);
            this.panelQuestHeader.Controls.Add(this.mapBTN);
            this.panelQuestHeader.Controls.Add(this.label2);
            this.panelQuestHeader.Controls.Add(this.checkBoxQuestCompleted);
            this.panelQuestHeader.Controls.Add(this.labelQuestTitle);
            this.panelQuestHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuestHeader.Location = new System.Drawing.Point(0, 0);
            this.panelQuestHeader.Name = "panelQuestHeader";
            this.panelQuestHeader.Size = new System.Drawing.Size(804, 50);
            this.panelQuestHeader.TabIndex = 2;
            // 
            // mapBTN
            // 
            this.mapBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mapBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.mapBTN.FlatAppearance.BorderSize = 0;
            this.mapBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mapBTN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mapBTN.ForeColor = System.Drawing.Color.White;
            this.mapBTN.Location = new System.Drawing.Point(506, 8);
            this.mapBTN.Name = "mapBTN";
            this.mapBTN.Size = new System.Drawing.Size(120, 30);
            this.mapBTN.TabIndex = 6;
            this.mapBTN.Text = "Out of Town";
            this.mapBTN.UseVisualStyleBackColor = false;
            this.mapBTN.Click += new System.EventHandler(this.mapBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "(Double click STEPS to cross-out)";
            // 
            // checkBoxQuestCompleted
            // 
            this.checkBoxQuestCompleted.AutoSize = true;
            this.checkBoxQuestCompleted.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBoxQuestCompleted.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxQuestCompleted.ForeColor = System.Drawing.Color.RosyBrown;
            this.checkBoxQuestCompleted.Location = new System.Drawing.Point(647, 0);
            this.checkBoxQuestCompleted.Name = "checkBoxQuestCompleted";
            this.checkBoxQuestCompleted.Size = new System.Drawing.Size(157, 50);
            this.checkBoxQuestCompleted.TabIndex = 1;
            this.checkBoxQuestCompleted.Text = "Completed";
            this.checkBoxQuestCompleted.UseVisualStyleBackColor = true;
            this.checkBoxQuestCompleted.CheckedChanged += new System.EventHandler(this.checkBoxQuestCompleted_CheckedChanged);
            // 
            // labelQuestTitle
            // 
            this.labelQuestTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.labelQuestTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelQuestTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelQuestTitle.ForeColor = System.Drawing.Color.White;
            this.labelQuestTitle.Location = new System.Drawing.Point(0, 0);
            this.labelQuestTitle.Name = "labelQuestTitle";
            this.labelQuestTitle.Padding = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.labelQuestTitle.Size = new System.Drawing.Size(804, 50);
            this.labelQuestTitle.TabIndex = 0;
            this.labelQuestTitle.Text = "Quest Details";
            this.labelQuestTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.listBoxQuests);
            this.panelLeft.Controls.Add(this.panelQuestFilters);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(260, 702);
            this.panelLeft.TabIndex = 0;
            // 
            // listBoxQuests
            // 
            this.listBoxQuests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.listBoxQuests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxQuests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxQuests.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxQuests.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.listBoxQuests.ForeColor = System.Drawing.Color.White;
            this.listBoxQuests.ItemHeight = 30;
            this.listBoxQuests.Location = new System.Drawing.Point(0, 60);
            this.listBoxQuests.Name = "listBoxQuests";
            this.listBoxQuests.Size = new System.Drawing.Size(260, 642);
            this.listBoxQuests.TabIndex = 1;
            this.listBoxQuests.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxQuests_DrawItem);
            this.listBoxQuests.SelectedIndexChanged += new System.EventHandler(this.listBoxQuests_SelectedIndexChanged);
            this.listBoxQuests.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxQuests_MouseDoubleClick);
            // 
            // panelQuestFilters
            // 
            this.panelQuestFilters.Controls.Add(this.label1);
            this.panelQuestFilters.Controls.Add(this.checkBoxShowCompleted);
            this.panelQuestFilters.Controls.Add(this.comboBoxQuestType);
            this.panelQuestFilters.Controls.Add(this.labelQuestType);
            this.panelQuestFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuestFilters.Location = new System.Drawing.Point(0, 0);
            this.panelQuestFilters.Name = "panelQuestFilters";
            this.panelQuestFilters.Padding = new System.Windows.Forms.Padding(10);
            this.panelQuestFilters.Size = new System.Drawing.Size(260, 60);
            this.panelQuestFilters.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(124, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "(Double click to complete)";
            // 
            // checkBoxShowCompleted
            // 
            this.checkBoxShowCompleted.AutoSize = true;
            this.checkBoxShowCompleted.Checked = true;
            this.checkBoxShowCompleted.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowCompleted.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBoxShowCompleted.ForeColor = System.Drawing.Color.White;
            this.checkBoxShowCompleted.Location = new System.Drawing.Point(137, 29);
            this.checkBoxShowCompleted.Name = "checkBoxShowCompleted";
            this.checkBoxShowCompleted.Size = new System.Drawing.Size(117, 19);
            this.checkBoxShowCompleted.TabIndex = 2;
            this.checkBoxShowCompleted.Text = "Show Completed";
            this.checkBoxShowCompleted.UseVisualStyleBackColor = true;
            this.checkBoxShowCompleted.CheckedChanged += new System.EventHandler(this.checkBoxShowCompleted_CheckedChanged);
            // 
            // comboBoxQuestType
            // 
            this.comboBoxQuestType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.comboBoxQuestType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQuestType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxQuestType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBoxQuestType.ForeColor = System.Drawing.Color.White;
            this.comboBoxQuestType.FormattingEnabled = true;
            this.comboBoxQuestType.Items.AddRange(new object[] {
            "All Types",
            "QUEST",
            "EVENT"});
            this.comboBoxQuestType.Location = new System.Drawing.Point(17, 25);
            this.comboBoxQuestType.Name = "comboBoxQuestType";
            this.comboBoxQuestType.Size = new System.Drawing.Size(100, 23);
            this.comboBoxQuestType.TabIndex = 1;
            this.comboBoxQuestType.SelectedIndexChanged += new System.EventHandler(this.comboBoxQuestType_SelectedIndexChanged);
            // 
            // labelQuestType
            // 
            this.labelQuestType.AutoSize = true;
            this.labelQuestType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelQuestType.ForeColor = System.Drawing.Color.White;
            this.labelQuestType.Location = new System.Drawing.Point(13, 3);
            this.labelQuestType.Name = "labelQuestType";
            this.labelQuestType.Size = new System.Drawing.Size(43, 19);
            this.labelQuestType.TabIndex = 0;
            this.labelQuestType.Text = "Filter";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.panelTop.Controls.Add(this.buttonReset);
            this.panelTop.Controls.Add(this.lblCredit);
            this.panelTop.Controls.Add(this.buttonSaveProfile);
            this.panelTop.Controls.Add(this.buttonLoadProfile);
            this.panelTop.Controls.Add(this.textBoxCharacterName);
            this.panelTop.Controls.Add(this.labelCharacterName);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(10);
            this.panelTop.Size = new System.Drawing.Size(1084, 60);
            this.panelTop.TabIndex = 1;
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.IndianRed;
            this.buttonReset.FlatAppearance.BorderSize = 0;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonReset.ForeColor = System.Drawing.Color.White;
            this.buttonReset.Location = new System.Drawing.Point(701, 15);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(51, 30);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCredit.ForeColor = System.Drawing.Color.White;
            this.lblCredit.Location = new System.Drawing.Point(1028, 10);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(46, 13);
            this.lblCredit.TabIndex = 4;
            this.lblCredit.Text = "By Heth";
            // 
            // buttonSaveProfile
            // 
            this.buttonSaveProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonSaveProfile.FlatAppearance.BorderSize = 0;
            this.buttonSaveProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveProfile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSaveProfile.ForeColor = System.Drawing.Color.White;
            this.buttonSaveProfile.Location = new System.Drawing.Point(463, 15);
            this.buttonSaveProfile.Name = "buttonSaveProfile";
            this.buttonSaveProfile.Size = new System.Drawing.Size(100, 30);
            this.buttonSaveProfile.TabIndex = 3;
            this.buttonSaveProfile.Text = "Save Profile";
            this.buttonSaveProfile.UseVisualStyleBackColor = false;
            this.buttonSaveProfile.Click += new System.EventHandler(this.buttonSaveProfile_Click);
            // 
            // buttonLoadProfile
            // 
            this.buttonLoadProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.buttonLoadProfile.FlatAppearance.BorderSize = 0;
            this.buttonLoadProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadProfile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonLoadProfile.ForeColor = System.Drawing.Color.White;
            this.buttonLoadProfile.Location = new System.Drawing.Point(583, 15);
            this.buttonLoadProfile.Name = "buttonLoadProfile";
            this.buttonLoadProfile.Size = new System.Drawing.Size(100, 30);
            this.buttonLoadProfile.TabIndex = 2;
            this.buttonLoadProfile.Text = "Load Profile";
            this.buttonLoadProfile.UseVisualStyleBackColor = false;
            this.buttonLoadProfile.Click += new System.EventHandler(this.buttonLoadProfile_Click);
            // 
            // textBoxCharacterName
            // 
            this.textBoxCharacterName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.textBoxCharacterName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCharacterName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxCharacterName.ForeColor = System.Drawing.Color.White;
            this.textBoxCharacterName.Location = new System.Drawing.Point(163, 18);
            this.textBoxCharacterName.Name = "textBoxCharacterName";
            this.textBoxCharacterName.Size = new System.Drawing.Size(280, 25);
            this.textBoxCharacterName.TabIndex = 1;
            this.textBoxCharacterName.TextChanged += new System.EventHandler(this.textBoxCharacterName_TextChanged);
            this.textBoxCharacterName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCharacterName_KeyPress);
            // 
            // labelCharacterName
            // 
            this.labelCharacterName.AutoSize = true;
            this.labelCharacterName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelCharacterName.ForeColor = System.Drawing.Color.White;
            this.labelCharacterName.Location = new System.Drawing.Point(26, 20);
            this.labelCharacterName.Name = "labelCharacterName";
            this.labelCharacterName.Size = new System.Drawing.Size(122, 19);
            this.labelCharacterName.TabIndex = 0;
            this.labelCharacterName.Text = "Character Name:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(460, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Bird";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(415, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 30);
            this.button2.TabIndex = 8;
            this.button2.Text = "Fort";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(364, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 30);
            this.button3.TabIndex = 9;
            this.button3.Text = "Mine";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(310, 8);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 30);
            this.button4.TabIndex = 10;
            this.button4.Text = "Cargo";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(236, 8);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(68, 30);
            this.button5.TabIndex = 11;
            this.button5.Text = "Narootuh";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(246, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Maps:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1084, 762);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1100, 800);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KalOnline Quest Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMain.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.panelQuestDetails.ResumeLayout(false);
            this.panelQuestHeader.ResumeLayout(false);
            this.panelQuestHeader.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelQuestFilters.ResumeLayout(false);
            this.panelQuestFilters.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button mapBTN;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }

}