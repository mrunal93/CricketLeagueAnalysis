using System;
using System.Collections.Generic;
using System.Text;

namespace CricketLeagueAnalysis
{
    public class AnalysisBowlingModel
    {
        public int POS { get; set; }
        public string PLAYER { get; set; }
        public int Mat { get; set; }
        public int Inns { get; set; }
        public double Ov { get; set; }
        public int Runs { get; set; }
        public int Wkts { get; set; }
        public int BBI { get; set; }
        public double Avg { get; set; }
        public double Econ { get; set; }
        public double SR { get; set; }
        public int FourW { get; set; }
        public int FiveW { get; set; }
    }
}
