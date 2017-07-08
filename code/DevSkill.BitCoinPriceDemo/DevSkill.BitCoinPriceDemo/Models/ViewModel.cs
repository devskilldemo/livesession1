using DevSkill.BitCoinDemo.Library;
using DevSkill.BitCoinDemo.Library.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevSkill.BitCoinPriceDemo.Models
{
    public class ViewModel
    {
        private BitCoinUnitOfWork _unitOfWork;
        public ViewModel()
        {
            _unitOfWork = new BitCoinUnitOfWork(new BitCoinContext());
        }

        public IEnumerable<BitCoinPrice> GetAllPrice()
        {
            return _unitOfWork.BitCoinPriceRepository.GetAll().OrderByDescending(x => x.time.updatedISO);
        }
    }
}