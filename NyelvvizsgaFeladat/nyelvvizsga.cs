using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyelvvizsgaFeladat
{
    internal class Nyelvvizsga
    {
        //nyelv;2009;2010;2011;2012;2013;2014;2015;2016;2017;2018
        string eredmeny;
        string nyelv;
        int _2009;
        int _2010;
        int _2011;
        int _2012;
        int _2013;
        int _2014;
        int _2015;
        int _2016;
        int _2017;
        int _2018;


        public Nyelvvizsga(string csvSor, string eredmeny)
        {
            string[] mezok = csvSor.Split(";");

            nyelv = mezok[0];
            _2009 = Convert.ToInt32(mezok[1]);
            _2010 = Convert.ToInt32(mezok[2]);
            _2011 = Convert.ToInt32(mezok[3]);
            _2012 = Convert.ToInt32(mezok[4]);
            _2013 = Convert.ToInt32(mezok[5]);
            _2014 = Convert.ToInt32(mezok[6]);
            _2015 = Convert.ToInt32(mezok[7]);
            _2016 = Convert.ToInt32(mezok[8]);
            _2017 = Convert.ToInt32(mezok[9]);
            _2018 = Convert.ToInt32(mezok[10]);
            this.eredmeny = eredmeny;
        }

        public string Eredmeny { get => eredmeny;}
        public string Nyelv { get => nyelv; }
        public int K2009 { get => _2009; }
        public int K2010 { get => _2010;  }
        public int K2011 { get => _2011; }
        public int K2012 { get => _2012; }
        public int K2013 { get => _2013; }
        public int K2014 { get => _2014; }
        public int K2015 { get => _2015; }
        public int K2016 { get => _2016; }
        public int K2017 { get => _2017; }
        public int K2018 { get => _2018; }
    }
}
