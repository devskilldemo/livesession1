using DevSkill.BitCoinDemo.Library;
using DevSkill.BitCoinDemo.Library.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill.BitCoinPriceDemo.Service
{
    public partial class BitCoinBroker : ServiceBase
    {
        private static System.Timers.Timer _callTimer;
        private static BitCoinUnitOfWork _unitOfWork;
        private static BitCoinServiceBroker _broker;

        public BitCoinBroker()
        {
            InitializeComponent();
            OnStart(null);
        }

        protected override void OnStart(string[] args)
        {
            int time = 60000;
            try
            {
                _unitOfWork = new BitCoinUnitOfWork(new BitCoinContext());
                _broker = new BitCoinServiceBroker();
                _callTimer = new System.Timers.Timer(time);
                _callTimer.Elapsed += _callTimer_Elapsed;
                _callTimer.Enabled = true;
            }
            catch
            { }
        }

        private void _callTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            var price = _broker.GetBitCoinPrices();
            _unitOfWork.BitCoinPriceRepository.Add(price);
            _unitOfWork.Save();
        }

        protected override void OnStop()
        {
        }
    }
}
