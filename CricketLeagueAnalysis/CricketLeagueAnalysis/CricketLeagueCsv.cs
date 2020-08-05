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
            var listOb = JsonConvert.DeserializeObject<List<CensusDAO>>(CsvToJSON());
            var descListOb = listOb.OrderBy(x => x.Avg);
            return JsonConvert.SerializeObject(descListOb);
        }

        public string TopStrikingRates()
        {
            var listOb = JsonConvert.DeserializeObject<List<CensusDAO>>(CsvToJSON());
            var descListOb = listOb.OrderBy(x => x.SR);
            return JsonConvert.SerializeObject(descListOb);
        }

        public string MaximumSixes()
        {
            var listOb = JsonConvert.DeserializeObject<List<CensusDAO>>(CsvToJSON());
            var descListOb = listOb.OrderByDescending(x => x.Sixs);
            return JsonConvert.SerializeObject(descListOb);
        }

        public string MaximumFours()
        {
            var listOb = JsonConvert.DeserializeObject<List<CensusDAO>>(CsvToJSON());
            var descListOb = listOb.OrderByDescending(x => x.Fours);
            return JsonConvert.SerializeObject(descListOb);
        }
    }
}
