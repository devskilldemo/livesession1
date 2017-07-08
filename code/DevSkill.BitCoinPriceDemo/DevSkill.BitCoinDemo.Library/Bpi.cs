using DevSkill.BitCoinDemo.Library.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill.BitCoinDemo.Library
{
    public class Bpi : Entity
    {
        public virtual USD USD { get; set; }
        public virtual GBP GBP { get; set; }
        public  virtual EUR EUR { get; set; }
    }
}
