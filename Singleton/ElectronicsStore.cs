using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class ElectronicsStore
    {
        public Payment PaymentId { get; set; }
        public void Purchase(int paymentId)
        {
            PaymentId = Payment.GetInstance(paymentId);
        }
    }
}
