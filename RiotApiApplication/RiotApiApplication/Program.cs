using System;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.Enums;
using MingweiSamuel.Camille.SummonerV4;
using MingweiSamuel.Camille.MatchV5;
using MingweiSamuel.Camille.ChampionMasteryV4;
using Newtonsoft.Json;
using MingweiSamuel.Camille.ChampionV3;
using System.Collections.Generic;

namespace RiotApiApplication
{
	class Program
	{
		public ChampionMastery[] masteries { get; set; }
		public List<string> matches { get; set; }
		static void Main(string[] args)
		{
			var riotApi = RiotApi.NewInstance("RGAPI-b813aa6e-db94-4b90-ac1a-a3fd01acfb4e");
			Summoner summoner = riotApi.SummonerV4.GetBySummonerName(Region.NA, "MetaRight");
			var summonerPUiD = summoner.Puuid;
			var summonerID = summoner.Id;
			ChampionMastery[] masteries = riotApi.ChampionMasteryV4.GetAllChampionMasteries(Region.NA, summonerID);
			var firstchampion = masteries[0].ChampionId; 
			Convert.ToInt32(masteries[0].ChampionId);
			var ChampionName = (Champion)masteries[0].ChampionId;


			var SelectedMatchID = "NA1_4132485256";
			var SelectedMatch = riotApi.MatchV5.GetMatch(MingweiSamuel.Camille.Enums.Region.Americas, SelectedMatchID);

			JsonConvert.DeserializeObject(SelectedMatch.ToString());
			string players = SelectedMatch._AdditionalProperties.Values("Particpants", particpants);


			Console.WriteLine(SelectedMatch);
			List<string[]> list = new List<string[]>();
			list.Add(riotApi.MatchV5.GetMatchIdsByPUUID(Region.Americas, summoner.Puuid, 0, 5));
			var matchid1 = list[0][0]; 
			
			Console.WriteLine(list[0]);
			Console.WriteLine(matchid1);
			
			
			
			
			
			
			
			
			
			
			
			
			
			Console.WriteLine(firstchampion);
			Console.WriteLine(ChampionName);
			//Console.WriteLine(riotApi.MatchV4.GetMatchlist(Region.NA, summonerPUiD));
			
			Console.WriteLine($"Summoner: {summoner.Name}  Level: {summoner.SummonerLevel}");
        }
	}
}
