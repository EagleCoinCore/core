using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BeCoreApp.Data.Enums
{
    public enum TransactionType
    {
        [Description("Withdraw ELC")]
        WithdrawELC = 1,
        [Description("Withdraw TRX")]
        WithdrawTRX = 2,
        [Description("Swap")]
        Swap = 3,
        [Description("Buy TRX")]
        Buy = 4,
        [Description("Affiliate Withdraw")]
        AffiliateWithdraw = 5,
        [Description("Affiliate Buy")]
        AffiliateBuy = 6,
        [Description("Withdraw USDT TRC20")]
        WithdrawUSDTTRC20 = 7,
        [Description("Buy USDT")]
        BuyUSDT = 8,
    }
}
