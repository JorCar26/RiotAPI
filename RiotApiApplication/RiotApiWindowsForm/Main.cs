using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.Enums;
using MingweiSamuel.Camille.MatchV4;
using MingweiSamuel.Camille.MatchV5;
using MingweiSamuel.Camille.SummonerV4;
using MingweiSamuel.Camille.ChampionMasteryV4;

namespace RiotApiWindowsForm
{
    public partial class Main : Form
    {
        private string summonerName;
        public Main()
        {
            InitializeComponent();

        }

        private void summonerNameSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            summonerName = summonerNameSearchTextBox.Text;
        }

        private void apiKeyTextBox_TextChanged(object sender, EventArgs e)
        {
            var riotAPI = RiotApi.NewInstance(apiKeyTextBox.Text);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var riotAPI = RiotApi.NewInstance(apiKeyTextBox.Text);
            Summoner summoner = riotAPI.SummonerV4.GetBySummonerName(MingweiSamuel.Camille.Enums.Region.NA, summonerName);
            ChampionMastery[] masteries = riotAPI.ChampionMasteryV4.GetAllChampionMasteries(MingweiSamuel.Camille.Enums.Region.NA, summoner.Id);

            Convert.ToInt32(masteries[0].ChampionId);
            Convert.ToInt32(masteries[1].ChampionId);
            Convert.ToInt32(masteries[2].ChampionId);
            var ChampionName1 = (Champion)masteries[0].ChampionId;
            var ChampionName2 = (Champion)masteries[1].ChampionId;
            var ChampionName3 = (Champion)masteries[2].ChampionId;

            List<string[]> Results = new List<string[]>();
            Results.Add(riotAPI.MatchV5.GetMatchIdsByPUUID(MingweiSamuel.Camille.Enums.Region.Americas, summoner.Puuid, 0, 5));
            Results[0].ToString();

            var MatchID1 = Results[0][0];
            var MatchID2 = Results[0][1];
            var MatchID3 = Results[0][2];
            var MatchID4 = Results[0][3];
            var MatchID5 = Results[0][4];

            List<string> Matches = new List<string>();
            Matches.Add(MatchID1.ToString());
            Matches.Add(MatchID2.ToString());
            Matches.Add(MatchID3.ToString());
            Matches.Add(MatchID4.ToString());
            Matches.Add(MatchID5.ToString());

            matchIDsBindingSource.DataSource = Matches;
            

            summonerNameReadOnlyTextBox.Text = summoner.Name;
            summonerLevelReadOnlyTextBox.Text = summoner.SummonerLevel.ToString();

            championNameReadOnlyTextBox1.Text = ChampionName1.ToString();
            championLevelReadOnlyTextBox1.Text = masteries[0].ChampionLevel.ToString();

            championNameReadOnlyTextBox2.Text = ChampionName2.ToString();
            championLevelReadOnlyTextBox2.Text = masteries[1].ChampionLevel.ToString();

            championNameReadOnlyTextBox3.Text = ChampionName3.ToString();
            championLevelReadOnlyTextBox3.Text = masteries[2].ChampionLevel.ToString();

            selectedMatchReadOnlyTextBox.Text = summonerMatchHistory.SelectedItem.ToString();
            
            
            var SelectedMatchID = selectedMatchReadOnlyTextBox.Text;
            var SelectedMatch = riotAPI.MatchV5.GetMatch(MingweiSamuel.Camille.Enums.Region.Americas, SelectedMatchID);
            
        }

        private void matchParticipants_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedParticipantReadOnlyTextBox.Text = matchParticipants.SelectedIndex.ToString();
            var riotAPI = RiotApi.NewInstance(apiKeyTextBox.Text);
            Summoner matchPlayer = riotAPI.SummonerV4.GetBySummonerName(MingweiSamuel.Camille.Enums.Region.NA, summonerName);
            matchStatsSummonerLevelReadOnlyTextBox.Text = matchPlayer.SummonerLevel.ToString();


        }

        private void summonerMatchHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMatchReadOnlyTextBox.Text = summonerMatchHistory.SelectedItem.ToString();
        }
    }
}
