
namespace RiotApiWindowsForm
{
    partial class Main
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
            this.summonerInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.summonerLevelReadOnlyTextBox = new System.Windows.Forms.TextBox();
            this.summonerLevelLabel = new System.Windows.Forms.Label();
            this.summonerNameReadOnlyTextBox = new System.Windows.Forms.TextBox();
            this.summonerNameLabel = new System.Windows.Forms.Label();
            this.searchUsingSummonersNameLabel = new System.Windows.Forms.Label();
            this.summonerNameSearchTextBox = new System.Windows.Forms.TextBox();
            this.apiKeyLabel = new System.Windows.Forms.Label();
            this.apiKeyTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.top3ChampionsGroupBox = new System.Windows.Forms.GroupBox();
            this.championLevelReadOnlyTextBox3 = new System.Windows.Forms.TextBox();
            this.championLevelLabel3 = new System.Windows.Forms.Label();
            this.championNameReadOnlyTextBox3 = new System.Windows.Forms.TextBox();
            this.championNameLabel3 = new System.Windows.Forms.Label();
            this.championLevelReadOnlyTextBox2 = new System.Windows.Forms.TextBox();
            this.championLevelLabel2 = new System.Windows.Forms.Label();
            this.championNameReadOnlyTextBox2 = new System.Windows.Forms.TextBox();
            this.championNameLabel2 = new System.Windows.Forms.Label();
            this.championLevelReadOnlyTextBox1 = new System.Windows.Forms.TextBox();
            this.championLevelLabel1 = new System.Windows.Forms.Label();
            this.championNameReadOnlyTextBox1 = new System.Windows.Forms.TextBox();
            this.championNameLabel1 = new System.Windows.Forms.Label();
            this.summonerMatchHistory = new System.Windows.Forms.ListBox();
            this.matchIDsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.matchParticipants = new System.Windows.Forms.ListBox();
            this.matchStatsGroupBox = new System.Windows.Forms.GroupBox();
            this.timeDeadReadOnlyTextBox = new System.Windows.Forms.TextBox();
            this.timeSpentDeadLabel = new System.Windows.Forms.Label();
            this.totalDeathReadOnlyTextBox = new System.Windows.Forms.TextBox();
            this.totalDeathsLabel = new System.Windows.Forms.Label();
            this.totalHealsReadOnlyTextBox = new System.Windows.Forms.TextBox();
            this.totalHealsLabel = new System.Windows.Forms.Label();
            this.minionsKilledReadOnlyTextBox = new System.Windows.Forms.TextBox();
            this.minionsKilledLabel = new System.Windows.Forms.Label();
            this.teamPositionReadOnlyTextBox = new System.Windows.Forms.TextBox();
            this.teamPositionLabel = new System.Windows.Forms.Label();
            this.assistReadOnlyTextBox = new System.Windows.Forms.TextBox();
            this.assistsLabel = new System.Windows.Forms.Label();
            this.killsReadOnlyTextBox = new System.Windows.Forms.TextBox();
            this.killsLabel = new System.Windows.Forms.Label();
            this.totalDamageReadOnlyTextBox = new System.Windows.Forms.TextBox();
            this.totalDamageDealtLabel = new System.Windows.Forms.Label();
            this.matchStatsChampionLevelReadOnlyTextBox = new System.Windows.Forms.TextBox();
            this.matchStatsChampionLevelLabel = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.matchStatsChampionNameLabel = new System.Windows.Forms.Label();
            this.matchStatsSummonerLevelReadOnlyTextBox = new System.Windows.Forms.TextBox();
            this.matchStatsSummonerLevelLabel = new System.Windows.Forms.Label();
            this.selectedParticipantReadOnlyTextBox = new System.Windows.Forms.TextBox();
            this.selectedParticipantLabel = new System.Windows.Forms.Label();
            this.selectedMatchLabel = new System.Windows.Forms.Label();
            this.selectedMatchReadOnlyTextBox = new System.Windows.Forms.TextBox();
            this.summonerInformationGroupBox.SuspendLayout();
            this.top3ChampionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matchIDsBindingSource)).BeginInit();
            this.matchStatsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // summonerInformationGroupBox
            // 
            this.summonerInformationGroupBox.Controls.Add(this.summonerLevelReadOnlyTextBox);
            this.summonerInformationGroupBox.Controls.Add(this.summonerLevelLabel);
            this.summonerInformationGroupBox.Controls.Add(this.summonerNameReadOnlyTextBox);
            this.summonerInformationGroupBox.Controls.Add(this.summonerNameLabel);
            this.summonerInformationGroupBox.Location = new System.Drawing.Point(13, 61);
            this.summonerInformationGroupBox.Name = "summonerInformationGroupBox";
            this.summonerInformationGroupBox.Size = new System.Drawing.Size(246, 126);
            this.summonerInformationGroupBox.TabIndex = 3;
            this.summonerInformationGroupBox.TabStop = false;
            this.summonerInformationGroupBox.Text = "Summoner Information";
            // 
            // summonerLevelReadOnlyTextBox
            // 
            this.summonerLevelReadOnlyTextBox.Location = new System.Drawing.Point(6, 85);
            this.summonerLevelReadOnlyTextBox.Name = "summonerLevelReadOnlyTextBox";
            this.summonerLevelReadOnlyTextBox.ReadOnly = true;
            this.summonerLevelReadOnlyTextBox.Size = new System.Drawing.Size(234, 22);
            this.summonerLevelReadOnlyTextBox.TabIndex = 3;
            // 
            // summonerLevelLabel
            // 
            this.summonerLevelLabel.AutoSize = true;
            this.summonerLevelLabel.Location = new System.Drawing.Point(66, 64);
            this.summonerLevelLabel.Name = "summonerLevelLabel";
            this.summonerLevelLabel.Size = new System.Drawing.Size(114, 17);
            this.summonerLevelLabel.TabIndex = 2;
            this.summonerLevelLabel.Text = "Summoner Level";
            // 
            // summonerNameReadOnlyTextBox
            // 
            this.summonerNameReadOnlyTextBox.Location = new System.Drawing.Point(6, 39);
            this.summonerNameReadOnlyTextBox.Name = "summonerNameReadOnlyTextBox";
            this.summonerNameReadOnlyTextBox.ReadOnly = true;
            this.summonerNameReadOnlyTextBox.Size = new System.Drawing.Size(234, 22);
            this.summonerNameReadOnlyTextBox.TabIndex = 1;
            // 
            // summonerNameLabel
            // 
            this.summonerNameLabel.AutoSize = true;
            this.summonerNameLabel.Location = new System.Drawing.Point(65, 18);
            this.summonerNameLabel.Name = "summonerNameLabel";
            this.summonerNameLabel.Size = new System.Drawing.Size(117, 17);
            this.summonerNameLabel.TabIndex = 0;
            this.summonerNameLabel.Text = "Summoner Name";
            // 
            // searchUsingSummonersNameLabel
            // 
            this.searchUsingSummonersNameLabel.AutoSize = true;
            this.searchUsingSummonersNameLabel.Location = new System.Drawing.Point(10, 13);
            this.searchUsingSummonersNameLabel.Name = "searchUsingSummonersNameLabel";
            this.searchUsingSummonersNameLabel.Size = new System.Drawing.Size(217, 17);
            this.searchUsingSummonersNameLabel.TabIndex = 4;
            this.searchUsingSummonersNameLabel.Text = "Search Using Summoners Name:";
            // 
            // summonerNameSearchTextBox
            // 
            this.summonerNameSearchTextBox.Location = new System.Drawing.Point(13, 34);
            this.summonerNameSearchTextBox.Name = "summonerNameSearchTextBox";
            this.summonerNameSearchTextBox.Size = new System.Drawing.Size(246, 22);
            this.summonerNameSearchTextBox.TabIndex = 5;
            this.summonerNameSearchTextBox.TextChanged += new System.EventHandler(this.summonerNameSearchTextBox_TextChanged);
            // 
            // apiKeyLabel
            // 
            this.apiKeyLabel.AutoSize = true;
            this.apiKeyLabel.Location = new System.Drawing.Point(276, 13);
            this.apiKeyLabel.Name = "apiKeyLabel";
            this.apiKeyLabel.Size = new System.Drawing.Size(61, 17);
            this.apiKeyLabel.TabIndex = 6;
            this.apiKeyLabel.Text = "API Key:";
            // 
            // apiKeyTextBox
            // 
            this.apiKeyTextBox.Location = new System.Drawing.Point(279, 33);
            this.apiKeyTextBox.Name = "apiKeyTextBox";
            this.apiKeyTextBox.Size = new System.Drawing.Size(585, 22);
            this.apiKeyTextBox.TabIndex = 7;
            this.apiKeyTextBox.TextChanged += new System.EventHandler(this.apiKeyTextBox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(871, 33);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(139, 23);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // top3ChampionsGroupBox
            // 
            this.top3ChampionsGroupBox.Controls.Add(this.championLevelReadOnlyTextBox3);
            this.top3ChampionsGroupBox.Controls.Add(this.championLevelLabel3);
            this.top3ChampionsGroupBox.Controls.Add(this.championNameReadOnlyTextBox3);
            this.top3ChampionsGroupBox.Controls.Add(this.championNameLabel3);
            this.top3ChampionsGroupBox.Controls.Add(this.championLevelReadOnlyTextBox2);
            this.top3ChampionsGroupBox.Controls.Add(this.championLevelLabel2);
            this.top3ChampionsGroupBox.Controls.Add(this.championNameReadOnlyTextBox2);
            this.top3ChampionsGroupBox.Controls.Add(this.championNameLabel2);
            this.top3ChampionsGroupBox.Controls.Add(this.championLevelReadOnlyTextBox1);
            this.top3ChampionsGroupBox.Controls.Add(this.championLevelLabel1);
            this.top3ChampionsGroupBox.Controls.Add(this.championNameReadOnlyTextBox1);
            this.top3ChampionsGroupBox.Controls.Add(this.championNameLabel1);
            this.top3ChampionsGroupBox.Location = new System.Drawing.Point(13, 193);
            this.top3ChampionsGroupBox.Name = "top3ChampionsGroupBox";
            this.top3ChampionsGroupBox.Size = new System.Drawing.Size(246, 245);
            this.top3ChampionsGroupBox.TabIndex = 4;
            this.top3ChampionsGroupBox.TabStop = false;
            this.top3ChampionsGroupBox.Text = "Top 3 Champions";
            // 
            // championLevelReadOnlyTextBox3
            // 
            this.championLevelReadOnlyTextBox3.Location = new System.Drawing.Point(127, 202);
            this.championLevelReadOnlyTextBox3.Name = "championLevelReadOnlyTextBox3";
            this.championLevelReadOnlyTextBox3.ReadOnly = true;
            this.championLevelReadOnlyTextBox3.Size = new System.Drawing.Size(108, 22);
            this.championLevelReadOnlyTextBox3.TabIndex = 13;
            // 
            // championLevelLabel3
            // 
            this.championLevelLabel3.AutoSize = true;
            this.championLevelLabel3.Location = new System.Drawing.Point(10, 202);
            this.championLevelLabel3.Name = "championLevelLabel3";
            this.championLevelLabel3.Size = new System.Drawing.Size(109, 17);
            this.championLevelLabel3.TabIndex = 12;
            this.championLevelLabel3.Text = "Champion Level";
            // 
            // championNameReadOnlyTextBox3
            // 
            this.championNameReadOnlyTextBox3.Location = new System.Drawing.Point(127, 178);
            this.championNameReadOnlyTextBox3.Name = "championNameReadOnlyTextBox3";
            this.championNameReadOnlyTextBox3.ReadOnly = true;
            this.championNameReadOnlyTextBox3.Size = new System.Drawing.Size(108, 22);
            this.championNameReadOnlyTextBox3.TabIndex = 11;
            // 
            // championNameLabel3
            // 
            this.championNameLabel3.AutoSize = true;
            this.championNameLabel3.Location = new System.Drawing.Point(9, 181);
            this.championNameLabel3.Name = "championNameLabel3";
            this.championNameLabel3.Size = new System.Drawing.Size(112, 17);
            this.championNameLabel3.TabIndex = 10;
            this.championNameLabel3.Text = "Champion Name";
            // 
            // championLevelReadOnlyTextBox2
            // 
            this.championLevelReadOnlyTextBox2.Location = new System.Drawing.Point(127, 129);
            this.championLevelReadOnlyTextBox2.Name = "championLevelReadOnlyTextBox2";
            this.championLevelReadOnlyTextBox2.ReadOnly = true;
            this.championLevelReadOnlyTextBox2.Size = new System.Drawing.Size(108, 22);
            this.championLevelReadOnlyTextBox2.TabIndex = 9;
            // 
            // championLevelLabel2
            // 
            this.championLevelLabel2.AutoSize = true;
            this.championLevelLabel2.Location = new System.Drawing.Point(10, 129);
            this.championLevelLabel2.Name = "championLevelLabel2";
            this.championLevelLabel2.Size = new System.Drawing.Size(109, 17);
            this.championLevelLabel2.TabIndex = 8;
            this.championLevelLabel2.Text = "Champion Level";
            // 
            // championNameReadOnlyTextBox2
            // 
            this.championNameReadOnlyTextBox2.Location = new System.Drawing.Point(127, 105);
            this.championNameReadOnlyTextBox2.Name = "championNameReadOnlyTextBox2";
            this.championNameReadOnlyTextBox2.ReadOnly = true;
            this.championNameReadOnlyTextBox2.Size = new System.Drawing.Size(108, 22);
            this.championNameReadOnlyTextBox2.TabIndex = 7;
            // 
            // championNameLabel2
            // 
            this.championNameLabel2.AutoSize = true;
            this.championNameLabel2.Location = new System.Drawing.Point(9, 108);
            this.championNameLabel2.Name = "championNameLabel2";
            this.championNameLabel2.Size = new System.Drawing.Size(112, 17);
            this.championNameLabel2.TabIndex = 6;
            this.championNameLabel2.Text = "Champion Name";
            // 
            // championLevelReadOnlyTextBox1
            // 
            this.championLevelReadOnlyTextBox1.Location = new System.Drawing.Point(127, 57);
            this.championLevelReadOnlyTextBox1.Name = "championLevelReadOnlyTextBox1";
            this.championLevelReadOnlyTextBox1.ReadOnly = true;
            this.championLevelReadOnlyTextBox1.Size = new System.Drawing.Size(108, 22);
            this.championLevelReadOnlyTextBox1.TabIndex = 5;
            // 
            // championLevelLabel1
            // 
            this.championLevelLabel1.AutoSize = true;
            this.championLevelLabel1.Location = new System.Drawing.Point(10, 57);
            this.championLevelLabel1.Name = "championLevelLabel1";
            this.championLevelLabel1.Size = new System.Drawing.Size(109, 17);
            this.championLevelLabel1.TabIndex = 4;
            this.championLevelLabel1.Text = "Champion Level";
            // 
            // championNameReadOnlyTextBox1
            // 
            this.championNameReadOnlyTextBox1.Location = new System.Drawing.Point(127, 33);
            this.championNameReadOnlyTextBox1.Name = "championNameReadOnlyTextBox1";
            this.championNameReadOnlyTextBox1.ReadOnly = true;
            this.championNameReadOnlyTextBox1.Size = new System.Drawing.Size(108, 22);
            this.championNameReadOnlyTextBox1.TabIndex = 1;
            // 
            // championNameLabel1
            // 
            this.championNameLabel1.AutoSize = true;
            this.championNameLabel1.Location = new System.Drawing.Point(9, 36);
            this.championNameLabel1.Name = "championNameLabel1";
            this.championNameLabel1.Size = new System.Drawing.Size(112, 17);
            this.championNameLabel1.TabIndex = 0;
            this.championNameLabel1.Text = "Champion Name";
            // 
            // summonerMatchHistory
            // 
            this.summonerMatchHistory.DataSource = this.matchIDsBindingSource;
            this.summonerMatchHistory.DisplayMember = "IsFixedSize";
            this.summonerMatchHistory.FormattingEnabled = true;
            this.summonerMatchHistory.ItemHeight = 16;
            this.summonerMatchHistory.Location = new System.Drawing.Point(279, 87);
            this.summonerMatchHistory.Name = "summonerMatchHistory";
            this.summonerMatchHistory.Size = new System.Drawing.Size(240, 100);
            this.summonerMatchHistory.TabIndex = 9;
            this.summonerMatchHistory.ValueMember = "IsFixedSize";
            this.summonerMatchHistory.SelectedIndexChanged += new System.EventHandler(this.summonerMatchHistory_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(276, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Match History";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(767, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 17);
            this.label12.TabIndex = 12;
            this.label12.Text = "Participants";
            // 
            // matchParticipants
            // 
            this.matchParticipants.FormattingEnabled = true;
            this.matchParticipants.ItemHeight = 16;
            this.matchParticipants.Location = new System.Drawing.Point(770, 87);
            this.matchParticipants.Name = "matchParticipants";
            this.matchParticipants.Size = new System.Drawing.Size(240, 100);
            this.matchParticipants.TabIndex = 11;
            this.matchParticipants.SelectedIndexChanged += new System.EventHandler(this.matchParticipants_SelectedIndexChanged);
            // 
            // matchStatsGroupBox
            // 
            this.matchStatsGroupBox.Controls.Add(this.timeDeadReadOnlyTextBox);
            this.matchStatsGroupBox.Controls.Add(this.timeSpentDeadLabel);
            this.matchStatsGroupBox.Controls.Add(this.totalDeathReadOnlyTextBox);
            this.matchStatsGroupBox.Controls.Add(this.totalDeathsLabel);
            this.matchStatsGroupBox.Controls.Add(this.totalHealsReadOnlyTextBox);
            this.matchStatsGroupBox.Controls.Add(this.totalHealsLabel);
            this.matchStatsGroupBox.Controls.Add(this.minionsKilledReadOnlyTextBox);
            this.matchStatsGroupBox.Controls.Add(this.minionsKilledLabel);
            this.matchStatsGroupBox.Controls.Add(this.teamPositionReadOnlyTextBox);
            this.matchStatsGroupBox.Controls.Add(this.teamPositionLabel);
            this.matchStatsGroupBox.Controls.Add(this.assistReadOnlyTextBox);
            this.matchStatsGroupBox.Controls.Add(this.assistsLabel);
            this.matchStatsGroupBox.Controls.Add(this.killsReadOnlyTextBox);
            this.matchStatsGroupBox.Controls.Add(this.killsLabel);
            this.matchStatsGroupBox.Controls.Add(this.totalDamageReadOnlyTextBox);
            this.matchStatsGroupBox.Controls.Add(this.totalDamageDealtLabel);
            this.matchStatsGroupBox.Controls.Add(this.matchStatsChampionLevelReadOnlyTextBox);
            this.matchStatsGroupBox.Controls.Add(this.matchStatsChampionLevelLabel);
            this.matchStatsGroupBox.Controls.Add(this.textBox14);
            this.matchStatsGroupBox.Controls.Add(this.matchStatsChampionNameLabel);
            this.matchStatsGroupBox.Controls.Add(this.matchStatsSummonerLevelReadOnlyTextBox);
            this.matchStatsGroupBox.Controls.Add(this.matchStatsSummonerLevelLabel);
            this.matchStatsGroupBox.Controls.Add(this.selectedParticipantReadOnlyTextBox);
            this.matchStatsGroupBox.Controls.Add(this.selectedParticipantLabel);
            this.matchStatsGroupBox.Location = new System.Drawing.Point(265, 193);
            this.matchStatsGroupBox.Name = "matchStatsGroupBox";
            this.matchStatsGroupBox.Size = new System.Drawing.Size(745, 245);
            this.matchStatsGroupBox.TabIndex = 14;
            this.matchStatsGroupBox.TabStop = false;
            this.matchStatsGroupBox.Text = "Match Stats";
            // 
            // timeDeadReadOnlyTextBox
            // 
            this.timeDeadReadOnlyTextBox.Location = new System.Drawing.Point(505, 130);
            this.timeDeadReadOnlyTextBox.Name = "timeDeadReadOnlyTextBox";
            this.timeDeadReadOnlyTextBox.ReadOnly = true;
            this.timeDeadReadOnlyTextBox.Size = new System.Drawing.Size(218, 22);
            this.timeDeadReadOnlyTextBox.TabIndex = 25;
            // 
            // timeSpentDeadLabel
            // 
            this.timeSpentDeadLabel.AutoSize = true;
            this.timeSpentDeadLabel.Location = new System.Drawing.Point(565, 110);
            this.timeSpentDeadLabel.Name = "timeSpentDeadLabel";
            this.timeSpentDeadLabel.Size = new System.Drawing.Size(118, 17);
            this.timeSpentDeadLabel.TabIndex = 24;
            this.timeSpentDeadLabel.Text = "Time Spent Dead";
            // 
            // totalDeathReadOnlyTextBox
            // 
            this.totalDeathReadOnlyTextBox.Location = new System.Drawing.Point(555, 198);
            this.totalDeathReadOnlyTextBox.Name = "totalDeathReadOnlyTextBox";
            this.totalDeathReadOnlyTextBox.ReadOnly = true;
            this.totalDeathReadOnlyTextBox.Size = new System.Drawing.Size(108, 22);
            this.totalDeathReadOnlyTextBox.TabIndex = 23;
            // 
            // totalDeathsLabel
            // 
            this.totalDeathsLabel.AutoSize = true;
            this.totalDeathsLabel.Location = new System.Drawing.Point(565, 178);
            this.totalDeathsLabel.Name = "totalDeathsLabel";
            this.totalDeathsLabel.Size = new System.Drawing.Size(89, 17);
            this.totalDeathsLabel.TabIndex = 22;
            this.totalDeathsLabel.Text = "Total Deaths";
            // 
            // totalHealsReadOnlyTextBox
            // 
            this.totalHealsReadOnlyTextBox.Location = new System.Drawing.Point(355, 197);
            this.totalHealsReadOnlyTextBox.Name = "totalHealsReadOnlyTextBox";
            this.totalHealsReadOnlyTextBox.ReadOnly = true;
            this.totalHealsReadOnlyTextBox.Size = new System.Drawing.Size(108, 22);
            this.totalHealsReadOnlyTextBox.TabIndex = 21;
            // 
            // totalHealsLabel
            // 
            this.totalHealsLabel.AutoSize = true;
            this.totalHealsLabel.Location = new System.Drawing.Point(369, 177);
            this.totalHealsLabel.Name = "totalHealsLabel";
            this.totalHealsLabel.Size = new System.Drawing.Size(80, 17);
            this.totalHealsLabel.TabIndex = 20;
            this.totalHealsLabel.Text = "Total Heals";
            // 
            // minionsKilledReadOnlyTextBox
            // 
            this.minionsKilledReadOnlyTextBox.Location = new System.Drawing.Point(184, 197);
            this.minionsKilledReadOnlyTextBox.Name = "minionsKilledReadOnlyTextBox";
            this.minionsKilledReadOnlyTextBox.ReadOnly = true;
            this.minionsKilledReadOnlyTextBox.Size = new System.Drawing.Size(108, 22);
            this.minionsKilledReadOnlyTextBox.TabIndex = 19;
            // 
            // minionsKilledLabel
            // 
            this.minionsKilledLabel.AutoSize = true;
            this.minionsKilledLabel.Location = new System.Drawing.Point(191, 177);
            this.minionsKilledLabel.Name = "minionsKilledLabel";
            this.minionsKilledLabel.Size = new System.Drawing.Size(94, 17);
            this.minionsKilledLabel.TabIndex = 18;
            this.minionsKilledLabel.Text = "Minions Killed";
            // 
            // teamPositionReadOnlyTextBox
            // 
            this.teamPositionReadOnlyTextBox.Location = new System.Drawing.Point(505, 85);
            this.teamPositionReadOnlyTextBox.Name = "teamPositionReadOnlyTextBox";
            this.teamPositionReadOnlyTextBox.ReadOnly = true;
            this.teamPositionReadOnlyTextBox.Size = new System.Drawing.Size(218, 22);
            this.teamPositionReadOnlyTextBox.TabIndex = 17;
            // 
            // teamPositionLabel
            // 
            this.teamPositionLabel.AutoSize = true;
            this.teamPositionLabel.Location = new System.Drawing.Point(565, 65);
            this.teamPositionLabel.Name = "teamPositionLabel";
            this.teamPositionLabel.Size = new System.Drawing.Size(98, 17);
            this.teamPositionLabel.TabIndex = 16;
            this.teamPositionLabel.Text = "Team Position";
            // 
            // assistReadOnlyTextBox
            // 
            this.assistReadOnlyTextBox.Location = new System.Drawing.Point(355, 130);
            this.assistReadOnlyTextBox.Name = "assistReadOnlyTextBox";
            this.assistReadOnlyTextBox.ReadOnly = true;
            this.assistReadOnlyTextBox.Size = new System.Drawing.Size(108, 22);
            this.assistReadOnlyTextBox.TabIndex = 15;
            // 
            // assistsLabel
            // 
            this.assistsLabel.AutoSize = true;
            this.assistsLabel.Location = new System.Drawing.Point(383, 110);
            this.assistsLabel.Name = "assistsLabel";
            this.assistsLabel.Size = new System.Drawing.Size(52, 17);
            this.assistsLabel.TabIndex = 14;
            this.assistsLabel.Text = "Assists";
            // 
            // killsReadOnlyTextBox
            // 
            this.killsReadOnlyTextBox.Location = new System.Drawing.Point(184, 130);
            this.killsReadOnlyTextBox.Name = "killsReadOnlyTextBox";
            this.killsReadOnlyTextBox.ReadOnly = true;
            this.killsReadOnlyTextBox.Size = new System.Drawing.Size(108, 22);
            this.killsReadOnlyTextBox.TabIndex = 13;
            // 
            // killsLabel
            // 
            this.killsLabel.AutoSize = true;
            this.killsLabel.Location = new System.Drawing.Point(222, 110);
            this.killsLabel.Name = "killsLabel";
            this.killsLabel.Size = new System.Drawing.Size(33, 17);
            this.killsLabel.TabIndex = 12;
            this.killsLabel.Text = "Kills";
            // 
            // totalDamageReadOnlyTextBox
            // 
            this.totalDamageReadOnlyTextBox.Location = new System.Drawing.Point(184, 85);
            this.totalDamageReadOnlyTextBox.Name = "totalDamageReadOnlyTextBox";
            this.totalDamageReadOnlyTextBox.ReadOnly = true;
            this.totalDamageReadOnlyTextBox.Size = new System.Drawing.Size(279, 22);
            this.totalDamageReadOnlyTextBox.TabIndex = 11;
            // 
            // totalDamageDealtLabel
            // 
            this.totalDamageDealtLabel.AutoSize = true;
            this.totalDamageDealtLabel.Location = new System.Drawing.Point(256, 65);
            this.totalDamageDealtLabel.Name = "totalDamageDealtLabel";
            this.totalDamageDealtLabel.Size = new System.Drawing.Size(134, 17);
            this.totalDamageDealtLabel.TabIndex = 10;
            this.totalDamageDealtLabel.Text = "Total Damage Dealt";
            // 
            // matchStatsChampionLevelReadOnlyTextBox
            // 
            this.matchStatsChampionLevelReadOnlyTextBox.Location = new System.Drawing.Point(505, 38);
            this.matchStatsChampionLevelReadOnlyTextBox.Name = "matchStatsChampionLevelReadOnlyTextBox";
            this.matchStatsChampionLevelReadOnlyTextBox.ReadOnly = true;
            this.matchStatsChampionLevelReadOnlyTextBox.Size = new System.Drawing.Size(218, 22);
            this.matchStatsChampionLevelReadOnlyTextBox.TabIndex = 9;
            // 
            // matchStatsChampionLevelLabel
            // 
            this.matchStatsChampionLevelLabel.AutoSize = true;
            this.matchStatsChampionLevelLabel.Location = new System.Drawing.Point(560, 18);
            this.matchStatsChampionLevelLabel.Name = "matchStatsChampionLevelLabel";
            this.matchStatsChampionLevelLabel.Size = new System.Drawing.Size(109, 17);
            this.matchStatsChampionLevelLabel.TabIndex = 8;
            this.matchStatsChampionLevelLabel.Text = "Champion Level";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(184, 38);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(280, 22);
            this.textBox14.TabIndex = 7;
            // 
            // matchStatsChampionNameLabel
            // 
            this.matchStatsChampionNameLabel.AutoSize = true;
            this.matchStatsChampionNameLabel.Location = new System.Drawing.Point(268, 18);
            this.matchStatsChampionNameLabel.Name = "matchStatsChampionNameLabel";
            this.matchStatsChampionNameLabel.Size = new System.Drawing.Size(112, 17);
            this.matchStatsChampionNameLabel.TabIndex = 6;
            this.matchStatsChampionNameLabel.Text = "Champion Name";
            // 
            // matchStatsSummonerLevelReadOnlyTextBox
            // 
            this.matchStatsSummonerLevelReadOnlyTextBox.Location = new System.Drawing.Point(14, 85);
            this.matchStatsSummonerLevelReadOnlyTextBox.Name = "matchStatsSummonerLevelReadOnlyTextBox";
            this.matchStatsSummonerLevelReadOnlyTextBox.ReadOnly = true;
            this.matchStatsSummonerLevelReadOnlyTextBox.Size = new System.Drawing.Size(131, 22);
            this.matchStatsSummonerLevelReadOnlyTextBox.TabIndex = 5;
            // 
            // matchStatsSummonerLevelLabel
            // 
            this.matchStatsSummonerLevelLabel.AutoSize = true;
            this.matchStatsSummonerLevelLabel.Location = new System.Drawing.Point(22, 65);
            this.matchStatsSummonerLevelLabel.Name = "matchStatsSummonerLevelLabel";
            this.matchStatsSummonerLevelLabel.Size = new System.Drawing.Size(114, 17);
            this.matchStatsSummonerLevelLabel.TabIndex = 4;
            this.matchStatsSummonerLevelLabel.Text = "Summoner Level";
            // 
            // selectedParticipantReadOnlyTextBox
            // 
            this.selectedParticipantReadOnlyTextBox.Location = new System.Drawing.Point(14, 38);
            this.selectedParticipantReadOnlyTextBox.Name = "selectedParticipantReadOnlyTextBox";
            this.selectedParticipantReadOnlyTextBox.ReadOnly = true;
            this.selectedParticipantReadOnlyTextBox.Size = new System.Drawing.Size(131, 22);
            this.selectedParticipantReadOnlyTextBox.TabIndex = 1;
            // 
            // selectedParticipantLabel
            // 
            this.selectedParticipantLabel.AutoSize = true;
            this.selectedParticipantLabel.Location = new System.Drawing.Point(10, 18);
            this.selectedParticipantLabel.Name = "selectedParticipantLabel";
            this.selectedParticipantLabel.Size = new System.Drawing.Size(138, 17);
            this.selectedParticipantLabel.TabIndex = 0;
            this.selectedParticipantLabel.Text = "Selected Participant:";
            // 
            // selectedMatchLabel
            // 
            this.selectedMatchLabel.AutoSize = true;
            this.selectedMatchLabel.Location = new System.Drawing.Point(588, 87);
            this.selectedMatchLabel.Name = "selectedMatchLabel";
            this.selectedMatchLabel.Size = new System.Drawing.Size(105, 17);
            this.selectedMatchLabel.TabIndex = 15;
            this.selectedMatchLabel.Text = "Selected Match";
            // 
            // selectedMatchReadOnlyTextBox
            // 
            this.selectedMatchReadOnlyTextBox.Location = new System.Drawing.Point(563, 107);
            this.selectedMatchReadOnlyTextBox.Name = "selectedMatchReadOnlyTextBox";
            this.selectedMatchReadOnlyTextBox.ReadOnly = true;
            this.selectedMatchReadOnlyTextBox.Size = new System.Drawing.Size(154, 22);
            this.selectedMatchReadOnlyTextBox.TabIndex = 16;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 450);
            this.Controls.Add(this.selectedMatchReadOnlyTextBox);
            this.Controls.Add(this.selectedMatchLabel);
            this.Controls.Add(this.matchStatsGroupBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.matchParticipants);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.summonerMatchHistory);
            this.Controls.Add(this.top3ChampionsGroupBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.apiKeyTextBox);
            this.Controls.Add(this.apiKeyLabel);
            this.Controls.Add(this.summonerNameSearchTextBox);
            this.Controls.Add(this.searchUsingSummonersNameLabel);
            this.Controls.Add(this.summonerInformationGroupBox);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "League of Legends API";
            this.summonerInformationGroupBox.ResumeLayout(false);
            this.summonerInformationGroupBox.PerformLayout();
            this.top3ChampionsGroupBox.ResumeLayout(false);
            this.top3ChampionsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matchIDsBindingSource)).EndInit();
            this.matchStatsGroupBox.ResumeLayout(false);
            this.matchStatsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox summonerInformationGroupBox;
        private System.Windows.Forms.TextBox summonerLevelReadOnlyTextBox;
        private System.Windows.Forms.Label summonerLevelLabel;
        private System.Windows.Forms.TextBox summonerNameReadOnlyTextBox;
        private System.Windows.Forms.Label summonerNameLabel;
        private System.Windows.Forms.Label searchUsingSummonersNameLabel;
        private System.Windows.Forms.TextBox summonerNameSearchTextBox;
        private System.Windows.Forms.Label apiKeyLabel;
        private System.Windows.Forms.TextBox apiKeyTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox top3ChampionsGroupBox;
        private System.Windows.Forms.TextBox championLevelReadOnlyTextBox3;
        private System.Windows.Forms.Label championLevelLabel3;
        private System.Windows.Forms.TextBox championNameReadOnlyTextBox3;
        private System.Windows.Forms.Label championNameLabel3;
        private System.Windows.Forms.TextBox championLevelReadOnlyTextBox2;
        private System.Windows.Forms.Label championLevelLabel2;
        private System.Windows.Forms.TextBox championNameReadOnlyTextBox2;
        private System.Windows.Forms.Label championNameLabel2;
        private System.Windows.Forms.TextBox championLevelReadOnlyTextBox1;
        private System.Windows.Forms.Label championLevelLabel1;
        private System.Windows.Forms.TextBox championNameReadOnlyTextBox1;
        private System.Windows.Forms.Label championNameLabel1;
        private System.Windows.Forms.ListBox summonerMatchHistory;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox matchParticipants;
        private System.Windows.Forms.GroupBox matchStatsGroupBox;
        private System.Windows.Forms.TextBox killsReadOnlyTextBox;
        private System.Windows.Forms.Label killsLabel;
        private System.Windows.Forms.TextBox totalDamageReadOnlyTextBox;
        private System.Windows.Forms.Label totalDamageDealtLabel;
        private System.Windows.Forms.TextBox matchStatsChampionLevelReadOnlyTextBox;
        private System.Windows.Forms.Label matchStatsChampionLevelLabel;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label matchStatsChampionNameLabel;
        private System.Windows.Forms.TextBox matchStatsSummonerLevelReadOnlyTextBox;
        private System.Windows.Forms.Label matchStatsSummonerLevelLabel;
        private System.Windows.Forms.TextBox selectedParticipantReadOnlyTextBox;
        private System.Windows.Forms.Label selectedParticipantLabel;
        private System.Windows.Forms.TextBox teamPositionReadOnlyTextBox;
        private System.Windows.Forms.Label teamPositionLabel;
        private System.Windows.Forms.TextBox assistReadOnlyTextBox;
        private System.Windows.Forms.Label assistsLabel;
        private System.Windows.Forms.Label selectedMatchLabel;
        private System.Windows.Forms.TextBox selectedMatchReadOnlyTextBox;
        private System.Windows.Forms.TextBox timeDeadReadOnlyTextBox;
        private System.Windows.Forms.Label timeSpentDeadLabel;
        private System.Windows.Forms.TextBox totalDeathReadOnlyTextBox;
        private System.Windows.Forms.Label totalDeathsLabel;
        private System.Windows.Forms.TextBox totalHealsReadOnlyTextBox;
        private System.Windows.Forms.Label totalHealsLabel;
        private System.Windows.Forms.TextBox minionsKilledReadOnlyTextBox;
        private System.Windows.Forms.Label minionsKilledLabel;
        private System.Windows.Forms.BindingSource matchIDsBindingSource;
    }
}

