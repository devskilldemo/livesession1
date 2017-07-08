using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill.BitCoinDemo.Library.Data
{
    public class BitCoinUnitOfWork : IDisposable
    {
        private BitCoinContext _context;
        private IBitCoinPriceRepository _bitCoinPriceRepository;

        public BitCoinUnitOfWork(BitCoinContext context)
        {
            _context = context;
            _bitCoinPriceRepository = new BitCoinPriceRepository(_context);
        }

        public IBitCoinPriceRepository BitCoinPriceRepository
        {
            get
            {
                return _bitCoinPriceRepository;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
