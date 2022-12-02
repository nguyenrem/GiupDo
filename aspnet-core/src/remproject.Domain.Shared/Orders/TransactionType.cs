using System;
using System.Collections.Generic;
using System.Text;

namespace remproject.Orders
{
    public enum TransactionType
    {
        ConfirmOrder,
        StartProcessing,
        FinishOrder,
        CancelOrder
    }
}
