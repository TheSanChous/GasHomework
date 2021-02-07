using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
    class GasInfo
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public GasInfo(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name;
        }

        public static List<GasInfo> GetGasInfos()
        {
            return new List<GasInfo>()
            {
                new GasInfo("A-95", 27.9m),
                new GasInfo("A-92", 26.3m)
            };
        }
    }
}
