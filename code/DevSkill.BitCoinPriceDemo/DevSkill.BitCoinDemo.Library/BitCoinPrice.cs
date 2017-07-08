using DevSkill.BitCoinDemo.Library.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill.BitCoinDemo.Library
{
    public class BitCoinPrice : Entity
    {
        public virtual Time time { get; set; }
        public string disclaimer { get; set; }
        public string chartName { get; set; }
        public virtual Bpi bpi { get; set; }
    }
}
