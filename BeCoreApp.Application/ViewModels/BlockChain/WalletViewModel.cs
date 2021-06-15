using System;
using System.Collections.Generic;
using System.Text;

namespace BeCoreApp.Application.ViewModels.BlockChain
{
    public class WalletViewModel
    {

        public string USDTTRC20PublishKey { get; set; }
        public decimal? WalletUSDTTRC20 { get; set; }
        public string TRXPublishKey { get; set; }
        public decimal? WalletTRX { get; set; }
    }
}
