using System;
using Foundation;
using BraintreeUnionPay;

namespace BraintreeDropIn
{
    [Preserve(AllMembers = true)]
    public static class Linker
    {
        public static void Init() {
			new BraintreeCard.BTCard();
			new BTCardCapabilities();
        }
    }
}
