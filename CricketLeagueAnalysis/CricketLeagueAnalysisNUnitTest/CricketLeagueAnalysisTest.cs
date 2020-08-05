using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System;

namespace CricketLeagueAnalysisNUnitTest
{
    public class Tests
    {
        string FILE_PATH_IPL_BATSMAN = @"C:\Users\Admin\Documents\CricketLeagueAnalysis\CricketLeagueAnalysis\CricketLeagueAnalysis\Resources\Day12 Data_01 IPL2019FactsheetMostRuns.csv";


        [Test]
        public void GivenIPlMostRunCsvFile_WhenAnalysis_ShouldReturnBattingAverage()
        {
            CricketLeagueAnalysis.CricketLeagueCsv batttingAverage = new CricketLeagueAnalysis.CricketLeagueCsv(FILE_PATH_IPL_BATSMAN);
            string battingAverageData = batttingAverage.BattingAverage();
            JArray jArray = JArray.Parse(battingAverageData);
            string firstValueFromCsv = jArray[0]["Avg"].ToString();
            Assert.AreEqual("83.2", firstValueFromCsv);
        }

        [Test]
        public void GivenIPlMostRunCsvFile_WhenAnalysis_ShouldReturnTopStrikingRate()
        {
            CricketLeagueAnalysis.CricketLeagueCsv  strikRate= new CricketLeagueAnalysis.CricketLeagueCsv(FILE_PATH_IPL_BATSMAN);
            string strikRateData = strikRate.TopStrikingRates();
            JArray jArray = JArray.Parse(strikRateData);
            string firstValueFromCsv = jArray[0]["SR"].ToString();
            Assert.AreEqual("333.33", firstValueFromCsv);
        }

        [Test]
        public void GivenIPlMostRunCsvFile_WhenAnalysis_ShouldReturnPlayerNameWithMaximumSixesHit()
        {
            CricketLeagueAnalysis.CricketLeagueCsv maximumSix = new CricketLeagueAnalysis.CricketLeagueCsv(FILE_PATH_IPL_BATSMAN);
            string maximumSixData = maximumSix.MaximumSixes();
            JArray jArray = JArray.Parse(maximumSixData);
            string firstValueFromCsv = jArray[0]["Sixs"].ToString();
            string PlayerName = jArray[0]["PLAYER"].ToString();
            Assert.AreEqual("Andre Russell", PlayerName);
            Assert.AreEqual("52", firstValueFromCsv);
        }

        [Test]
        public void GivenIPlMostRunCsvFile_WhenAnalysis_ShouldReturnPlayerNameWithMaximumFoursHit()
        {
            CricketLeagueAnalysis.CricketLeagueCsv maximumfours = new CricketLeagueAnalysis.CricketLeagueCsv(FILE_PATH_IPL_BATSMAN);
            string maximumfoursData = maximumfours.MaximumFours();
            JArray jArray = JArray.Parse(maximumfoursData);
            string firstValueFromCsv = jArray[0]["Fours"].ToString();
            string PlayerName = jArray[0]["PLAYER"].ToString();
            Assert.AreEqual("64", firstValueFromCsv);
            Assert.AreEqual("Shikhar Dhawan", PlayerName);
        }

        [Test]
        public void GivenIPlMostRunCsvFile_WhenAnalysis_ShouldReturnPlayerNameWithMaximumFoursAndhisStrikingRates()
        {
            CricketLeagueAnalysis.CricketLeagueCsv maximumfours = new CricketLeagueAnalysis.CricketLeagueCsv(FILE_PATH_IPL_BATSMAN);
            string maximumfoursData = maximumfours.MaximumFours();
            JArray jArray = JArray.Parse(maximumfoursData);
            string firstValueFromCsv = jArray[0]["SR"].ToString();
            string PlayerName = jArray[0]["PLAYER"].ToString();
            Assert.AreEqual("135.67", firstValueFromCsv);
            Assert.AreEqual("Shikhar Dhawan", PlayerName);
        }

        [Test]
        public void GivenIPlMostRunCsvFile_WhenAnalysis_ShouldReturnPlayerNameWithMaximumSixesAndHisStrikRate()
        {
            CricketLeagueAnalysis.CricketLeagueCsv maximumSix = new CricketLeagueAnalysis.CricketLeagueCsv(FILE_PATH_IPL_BATSMAN);
            string maximumSixData = maximumSix.MaximumSixes();
            JArray jArray = JArray.Parse(maximumSixData);
            string firstValueFromCsv = jArray[0]["SR"].ToString();
            string PlayerName = jArray[0]["PLAYER"].ToString();
            Assert.AreEqual("Andre Russell", PlayerName);
            Assert.AreEqual("204.81", firstValueFromCsv);
        }

        [Test]
        public void GivenIPlMostRunCsvFile_WhenAnalysis_ShouldReturnPlayerAerageAndHisStrikRate()
        {
            CricketLeagueAnalysis.CricketLeagueCsv batttingAverage = new CricketLeagueAnalysis.CricketLeagueCsv(FILE_PATH_IPL_BATSMAN);
            string battingAverageData = batttingAverage.BattingAverage();
            JArray jArray = JArray.Parse(battingAverageData);
            string firstValueFromCsv = jArray[0]["Avg"].ToString();
            string playerStrikingRates = jArray[0]["SR"].ToString();
            Assert.AreEqual("83.2", firstValueFromCsv);
            Assert.AreEqual("134.62", playerStrikingRates);
        }

    }
}