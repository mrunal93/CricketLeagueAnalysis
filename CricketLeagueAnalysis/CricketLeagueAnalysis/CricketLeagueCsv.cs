using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Serialization;

namespace CricketLeagueAnalysis
{
    public class CricketLeagueCsv
    {
        string path;
        public CricketLeagueCsv(string path)
        {
            this.path = path;
        }
        public string CsvToJSON()
        {
            var csv = new List<string[]>();
            var csvData = File.ReadAllLines(path);

            foreach (string line in csvData)
                csv.Add(line.Split(','));

            var properties = csvData[0].Split(',');

            var listIplCensus = new List<Dictionary<string, string>>();

            for (int rows = 1; rows < csvData.Length; rows++)
            {
                var objResult = new Dictionary<string, string>();
                for (int columns = 0; columns < properties.Length; columns++)
                    objResult.Add(properties[columns], csv[rows][columns]);

                listIplCensus.Add(objResult);
            }
            return JsonConvert.SerializeObject(listIplCensus);
        }
        
        public string BattingAverage()
        {
            var listObject = JsonConvert.DeserializeObject<List<CensusDAO>>(CsvToJSON());
            var descendinglistObjectject = listObject.OrderByDescending(variable => variable.Avg);
            return JsonConvert.SerializeObject(descendinglistObjectject);
        }

        public string TopStrikingRates()
        {
            var listObject = JsonConvert.DeserializeObject<List<CensusDAO>>(CsvToJSON());
            var descendinglistObjectject = listObject.OrderByDescending(variable => variable.SR);
            return JsonConvert.SerializeObject(descendinglistObjectject);
        }

        public string MaximumSixes()
        {
            var listObject = JsonConvert.DeserializeObject<List<CensusDAO>>(CsvToJSON());
            var descendinglistObjectject = listObject.OrderByDescending(variable => variable.Sixs);
            return JsonConvert.SerializeObject(descendinglistObjectject);
        }

        public string MaximumFours()
        {
            var listObject = JsonConvert.DeserializeObject<List<CensusDAO>>(CsvToJSON());
            var descendinglistObjectject = listObject.OrderByDescending(variable => variable.Fours);
            return JsonConvert.SerializeObject(descendinglistObjectject);
        }

        public string MaximumPlayerRuns()
        {
            var listObject = JsonConvert.DeserializeObject<List<CensusDAO>>(CsvToJSON());
            var descendinglistObjectject = listObject.OrderByDescending(variable => variable.Runs);
            return JsonConvert.SerializeObject(descendinglistObjectject);
        }

        public string BowlingAverage()
        {
            var listObject = JsonConvert.DeserializeObject<List<AnalysisDAOBowling>>(CsvToJSON());
            var ascendinglistObjectject = listObject.OrderBy(variable => variable.Avg);
            return JsonConvert.SerializeObject(ascendinglistObjectject);
        }

        public string BowlingTopStrikingRate()
        {
            var listObject = JsonConvert.DeserializeObject<List<AnalysisDAOBowling>>(CsvToJSON());
            var ascendinglistObjectject = listObject.OrderBy(variable => variable.SR);
            return JsonConvert.SerializeObject(ascendinglistObjectject);
        }
    }
}
