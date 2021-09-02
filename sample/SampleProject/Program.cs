using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SampleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program(); 
        }

        public Program()
        {
            YahooWeather();
        }

        public void YahooWeather()
        {
            GetWeatherReportFromYahoo();
            
        }

        private static void GetWeatherReportFromYahoo()
        {
            using (var wc = new WebClient())
            {
                var url = new Uri(@"https://news.yahoo.co.jp/rss/topics/top-picks.xml");
                var stream = wc.OpenRead(url);

                XDocument xdoc = XDocument.Load(stream);
                var xElements = xdoc.Root.Descendants("item");
                foreach ( var item in 
                    xElements.Select(x => new
                    {
                        Title = x.Element("title").Value,
                        Link = x.Element("description").Value
                    })){
                    Console.WriteLine("{0}\n {1}",item.Title,item.Link);
                    Console.WriteLine();
                }
            }       
        }
    }
}
