using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UnitTestingSamples
{
    public class ChampionsLoader : IChampionsLoader
    {
        public XElement LoadChampions()
        {
            return XElement.Load(F1Addresses.RacersUrl);
        }
    }
}
