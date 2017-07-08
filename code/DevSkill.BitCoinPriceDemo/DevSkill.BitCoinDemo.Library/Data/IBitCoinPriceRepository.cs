using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill.BitCoinDemo.Library.Data
{
    public interface IBitCoinPriceRepository : IGenericRepository<BitCoinPrice>
    {
        IEnumerable<BitCoinPrice> GetLastHourPrices();
    }
}
