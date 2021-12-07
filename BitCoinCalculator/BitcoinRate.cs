using System;
using System.Collections.Generic;
using System.Text;

namespace BitCoinCalculator
{
    public class BitcoinRate
    {
        public bpi bpi { get; set; }
    }
    public class bpi
    {
        public EUR EUR { get; set; }
        public Dollar Dollar { get; set; }
        public GBP GBP { get; set; }
    }
    public class EUR
    {
        public string code { get; set; }

        public float rate_float { get; set; }
    }
    public class Dollar
    { 
        public string code { get; set; }

        public float rate_float { get; set; }

    }
    public class GBP
    {
        public string code { get; set; }

        public float rate_float { get; set; }
    }
}
