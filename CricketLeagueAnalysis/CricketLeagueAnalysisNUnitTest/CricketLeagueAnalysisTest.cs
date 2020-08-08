using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System;

namespace CricketLeagueAnalysisNUnitTest
{
    public class Tests
    {
        string FILE_PATH_IPL_BATSMAN = @"C:\Users\Admin\Documents\CricketLeagueAnalysis\CricketLeagueAnalysis\CricketLeagueAnalysis\Resources\Day12 Data_01 IPL2019FactsheetMostRuns.csv";
        string FILE_PAth_IPL_BOWLERS = @"C:\Users\Admin\Documents\CricketLeagueAnalysis\CricketLeagueAnalysis\CricketLeagueAnalysis\Resources\Day12 Data_02 IPL2019FactsheetMostWkts.csv";

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
            Assert.AreEqual("Andre Russell:52", PlayerName+":"+firstValueFromCsv);
        }

        [Test]
        public void GivenIPlMostRunCsvFile_WhenAnalysis_ShouldReturnPlayerNameWithMaximumFoursHit()
        {
            CricketLeagueAnalysis.CricketLeagueCsv maximumfours = new CricketLeagueAnalysis.CricketLeagueCsv(FILE_PATH_IPL_BATSMAN);
            string maximumfoursData = maximumfours.MaximumFours();
            JArray jArray = JArray.Parse(maximumfoursData);
            string firstValueFromCsv = jArray[0]["Fours"].ToString();
            string PlayerName = jArray[0]["PLAYER"].ToString();
            Assert.AreEqual("64:Shikhar Dhawan", firstValueFromCsv+":"+PlayerName);
        }

        [Test]
        public void GivenIPlMostRunCsvFile_WhenAnalysis_ShouldReturnPlayerNameWithMaximumFoursAndhisStrikingRates()
        {
            CricketLeagueAnalysis.CricketLeagueCsv maximumfours = new CricketLeagueAnalysis.CricketLeagueCsv(FILE_PATH_IPL_BATSMAN);
            string maximumfoursData = maximumfours.MaximumFours();
            JArray jArray = JArray.Parse(maximumfoursData);
            string firstValueFromCsv = jArray[0]["SR"].ToString();
            string PlayerName = jArray[0]["PLAYER"].ToString();
            Assert.AreEqual("135.67:Shikhar Dhawan", firstValueFromCsv+":"+PlayerName);
        }

        [Test]
        public void GivenIPlMostRunCsvFile_WhenAnalysis_ShouldReturnPlayerNameWithMaximumSixesAndHisStrikRate()
        {
            CricketLeagueAnalysis.CricketLeagueCsv maximumSix = new CricketLeagueAnalysis.CricketLeagueCsv(FILE_PATH_IPL_BATSMAN);
            string maximumSixData = maximumSix.MaximumSixes();
            JArray jArray = JArray.Parse(maximumSixData);
            string firstValueFromCsv = jArray[0]["SR"].ToString();
            string PlayerName = jArray[0]["PLAYER"].ToString();
            Assert.AreEqual("Andre Russell:204.81", PlayerName+":"+firstValueFromCsv);
        }

        [Test]
        public void GivenIPlMostRunCsvFile_WhenAnalysis_ShouldReturnPlayerAerageAndHisStrikRate()
        {
            CricketLeagueAnalysis.CricketLeagueCsv batttingAverage = new CricketLeagueAnalysis.CricketLeagueCsv(FILE_PATH_IPL_BATSMAN);
            string battingAverageData = batttingAverage.BattingAverage();
            JArray jArray = JArray.Parse(battingAverageData);
            string firstValueFromCsv = jArray[0]["Avg"].ToString();
            string playerStrikingRates = jArray[0]["SR"].ToString();
            Assert.AreEqual("83.2:134.62", firstValueFromCsv+":"+playerStrikingRates);
        }

        [Test]
        public void GivenIPlMostRunCsvFile_WhenAnalysis_ShouldReturnPlayerMaximumRunsScoreAndHisBestAverage()
        {
            CricketLeagueAnalysis.CricketLeagueCsv maximumRuns = new CricketLeagueAnalysis.CricketLeagueCsv(FILE_PATH_IPL_BATSMAN);
            string maximumRunsData = maximumRuns.MaximumPlayerRuns();
            JArray jArray = JArray.Parse(maximumRunsData);
            string firstValueFromCsv = jArray[0]["Runs"].ToString();
            string playerStrikingRates = jArray[0]["Avg"].ToString();
            Assert.AreEqual("692:69.2", firstValueFromCsv+":"+playerStrikingRates);
        }

        [Test]
        public void GivenIPlMostWicketCsvFile_WhenAnalysis_ShouldReturnBolwingAverage()
        {
            CricketLeagueAnalysis.CricketLeagueCsv bolwingAverage = new CricketLeagueAnalysis.CricketLeagueCsv(FILE_PAth_IPL_BOWLERS);
            string bolwingAverageData = bolwingAverage.BowlingAverage();
            JArray jArray = JArray.Parse(bolwingAverageData);
            string playerBlowingAverage = jArray[13]["Avg"].ToString();
            Assert.AreEqual("11", playerBlowingAverage);
        }

        [Test]
        public void GivenIPlMostWicketCsvFile_WhenAnalysis_ShouldReturnBolwingStrikingRate()
        {
            CricketLeagueAnalysis.CricketLeagueCsv bolwingAverage = new CricketLeagueAnalysis.CricketLeagueCsv(FILE_PAth_IPL_BOWLERS);
            string bolwingAverageData = bolwingAverage.BowlingTopStrikingRate();
            JArray jArray = JArray.Parse(bolwingAverageData);
            string playerBlowingAverage = jArray[13]["SR"].ToString();
            Assert.AreEqual("8.66", playerBlowingAverage);
        }

        [Test]
        public void GivenIPlMostWicketCsvFile_WhenAnalysis_ShouldReturnBolwingBestEconomy()
        {
            CricketLeagueAnalysis.CricketLeagueCsv bolwingAverage = new CricketLeagueAnalysis.CricketLeagueCsv(FILE_PAth_IPL_BOWLERS);
            string bolwingAverageData = bolwingAverage.BowlingBestEconomy();
            JArray jArray = JArray.Parse(bolwingAverageData);
            string playerBlowingAverage = jArray[0]["Econ"].ToString();
            Assert.AreEqual("4.8", playerBlowingAverage);
        }

        [Test]
        public void GivenIPlMostWicketCsvFile_WhenAnalysis_ShouldReturnBolwingStrikingRateWith5WicketAnd4Wicket()
        {
            CricketLeagueAnalysis.CricketLeagueCsv bolwingAverage = new CricketLeagueAnalysis.CricketLeagueCsv(FILE_PAth_IPL_BOWLERS);
            string bolwingAverageData = bolwingAverage.BowlingTopStrikingRate();
            JArray jArray = JArray.Parse(bolwingAverageData);
            string playerBlowingAverage = jArray[13]["SR"].ToString();
            string playerBlowingAverageForFive = jArray[13]["FiveW"].ToString();
            string playerBlowingAverageForFour = jArray[13]["FourW"].ToString();
            Assert.AreEqual("8.66:1:0", playerBlowingAverage+":"+playerBlowingAverageForFive+":"+playerBlowingAverageForFour);
        }

        [Test]
        public void GivenIPlMostWicketCsvFile_WhenAnalysis_ShouldReturnBolwingAverageWithBestStrikingRates()
        {
            CricketLeagueAnalysis.CricketLeagueCsv bolwingAverage = new CricketLeagueAnalysis.CricketLeagueCsv(FILE_PAth_IPL_BOWLERS);
            string bolwingAverageData = bolwingAverage.BowlingAverage();
            JArray jArray = JArray.Parse(bolwingAverageData);
            string playerBlowingAverage = jArray[13]["SR"].ToString();
            Assert.AreEqual("12", playerBlowingAverage);
        }

        [Test]
        public void GivenIPlMostWicketCsvFile_WhenAnalysis_ShouldReturnBolwingMaximumWicketsWithBestBowlingAverages()
        {
            CricketLeagueAnalysis.CricketLeagueCsv bolwingAverage = new CricketLeagueAnalysis.CricketLeagueCsv(FILE_PAth_IPL_BOWLERS);
            string bolwingAverageData = bolwingAverage.TopMaximumWickets();
            JArray jArray = JArray.Parse(bolwingAverageData);
            string playerMaximumWicket = jArray[0]["Wkts"].ToString();
            string playerBowlingAverages = jArray[0]["Avg"].ToString();
            Assert.AreEqual("26:16.57", playerMaximumWicket+":" +playerBowlingAverages);
        }

        [Test]
        public void GivenIplMostWicketAndMostRunCsvFile_WhenAnalysis_ShouldReturnBestBattingANdBowlingAverage()
        {
            CricketLeagueAnalysis.CricketLeagueCsv bolwingAverage = new CricketLeagueAnalysis.CricketLeagueCsv(FILE_PAth_IPL_BOWLERS);
            CricketLeagueAnalysis.CricketLeagueCsv battingAverage = new CricketLeagueAnalysis.CricketLeagueCsv(FILE_PATH_IPL_BATSMAN);
            string battingAverageData = battingAverage.BattingAverage();
            string bolwingAverageData = bolwingAverage.BowlingAverage();
            JArray jArrayBatting = JArray.Parse(bolwingAverageData);
            JArray jArrayBowling = JArray.Parse(battingAverageData);
            string playerBattingAverage = jArrayBatting[13]["Avg"].ToString();
            string playerBowlingAverages = jArrayBowling[0]["Avg"].ToString();
            Assert.AreEqual("11:83.2", playerBattingAverage+":" +playerBowlingAverages);
        }

        [Test]
        public void GivenIplMostWicketAndMostRunCsvFile_WhenAnalysis_ShouldReturnMostRunsANdWickets()
        {
            CricketLeagueAnalysis.CricketLeagueCsv bolwingAverage = new CricketLeagueAnalysis.CricketLeagueCsv(FILE_PAth_IPL_BOWLERS);
            CricketLeagueAnalysis.CricketLeagueCsv battingAverage = new CricketLeagueAnalysis.CricketLeagueCsv(FILE_PATH_IPL_BATSMAN);
            string battingAverageData = battingAverage.MaximumPlayerRuns();
            string bolwingAverageData = bolwingAverage.TopMaximumWickets();
            JArray jArrayBatting = JArray.Parse(bolwingAverageData);
            JArray jArrayBowling = JArray.Parse(battingAverageData);
            string playerBattingAverage = jArrayBatting[0]["Wkts"].ToString();
            string playerBowlingAverages = jArrayBowling[0]["Runs"].ToString();
            Assert.AreEqual("26:692", playerBattingAverage + ":" + playerBowlingAverages);
        }

        [Test]
        public void GivenIPlMostBattingCsvFile_WhenAnalysis_ShouldReturnMaximumHundredsAndBestBattingAverages()
        {
            CricketLeagueAnalysis.CricketLeagueCsv maximumHundreds = new CricketLeagueAnalysis.CricketLeagueCsv(FILE_PATH_IPL_BATSMAN);
            string maximumHundredsData = maximumHundreds.PlayersMaximumHundreds();
            JArray jArray = JArray.Parse(maximumHundredsData);
            string playerMaximumHundred = jArray[0]["Hundreds"].ToString();
            string playerBattingAverages = jArray[0]["Avg"].ToString();
            Assert.AreEqual("1:69.2", playerMaximumHundred + ":" + playerBattingAverages);
        }

        [Test]
        public void GivenIPlMostBattingCsvFile_WhenAnalysis_ShouldReturnBattingAverageWithHundredsANdFifties()
        {
            CricketLeagueAnalysis.CricketLeagueCsv battingAverage = new CricketLeagueAnalysis.CricketLeagueCsv(FILE_PATH_IPL_BATSMAN);
            string battingAverageData = battingAverage.PlayersWithHundredsAndFifties();
            JArray jArray = JArray.Parse(battingAverageData);
            string playerBattingAverage = jArray[0]["Avg"].ToString();
            Assert.AreEqual("69.2", playerBattingAverage);
        }
    }
}