using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UnitTestingSamples
{
    public class Formula1
    {
        //依赖注入 通过构造函数依赖注入 接口与具体类
        private IChampionsLoader _loader;

        public Formula1(IChampionsLoader loader)
        {
            //依赖注入模式，有利于创建独立于数据源的单元测试
            _loader = loader;
        }

        public Formula1()
        { }

        public XElement ChampionsByCountry(string country)
        {
            XElement champions = XElement.Load(F1Addresses.RacersUrl);
            var q = from r in champions.Elements("Racer")
                    where r.Element("Country").Value == country
                    orderby int.Parse(r.Element("Wins").Value) descending
                    select new XElement("Racer",
                      new XAttribute("Name", r.Element("Firstname").Value + " " +
                        r.Element("Lastname").Value),
                      new XAttribute("Country", r.Element("Country").Value),
                      new XAttribute("Wins", r.Element("Wins").Value));
            return new XElement("Racers", q.ToArray());
        }

        //重构ChampionsByCountry方法
        public XElement ChampionsByCountry2(string country)
        {
            XElement champions = _loader.LoadChampions();
            var q = from r in champions.Elements("Racer")
                    where r.Element("Country").Value == country
                    orderby int.Parse(r.Element("Wins").Value) descending
                    select new XElement("Racer",
                      new XAttribute("Name", r.Element("Firstname").Value + " " +
                        r.Element("Lastname").Value),
                      new XAttribute("Country", r.Element("Country").Value),
                      new XAttribute("Wins", r.Element("Wins").Value));
            return new XElement("Racers", q.ToArray());
        }
    }
}
