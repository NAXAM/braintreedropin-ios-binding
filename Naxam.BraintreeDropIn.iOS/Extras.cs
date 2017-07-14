using System;
using Foundation;

using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using ModelIO;
using SceneKit;
using Security;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace BraintreeDropIn
{
    [Preserve(AllMembers = true)]
    public static class BraintreeDropInLinker
    {
        public static void Init()
        {
            BraintreeApplePay.BraintreeApplePayLinker.Init();
            BraintreeCard.BraintreeCardLinker.Init();
            BraintreeUnionPay.BraintreeUnionPayLinker.Init();

            new BraintreeCard.BTCard();
        }
    }

    //partial class BTDropInController
    //{
    //    public virtual BTPaymentSelectionViewController PaymentSelectionViewController
    //    {
    //        [Export("paymentSelectionViewController", ArgumentSemantic.Retain)]
    //        get
    //        {
    //            BTPaymentSelectionViewController ret;
    //            if (IsDirectBinding)
    //            {
    //                ret = Runtime.GetNSObject<BTPaymentSelectionViewController>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend(this.Handle, Selector.GetHandle("paymentSelectionViewController")));
    //            }
    //            else
    //            {
    //                ret = Runtime.GetNSObject<BTPaymentSelectionViewController>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper(this.SuperHandle, Selector.GetHandle("paymentSelectionViewController")));
    //            }
    //            return ret;
    //        }
    //    }
    //}

    //partial class BTPaymentSelectionViewController
    //{
    //    public virtual NSArray PaymentOptionsData
    //    {
    //        [Export("paymentOptionsData", ArgumentSemantic.Retain)]
    //        get
    //        {
    //            NSArray ret;
    //            if (IsDirectBinding)
    //            {
    //                ret = Runtime.GetNSObject<NSArray>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend(this.Handle, Selector.GetHandle("paymentOptionsData")));
    //            }
    //            else
    //            {
    //                ret = Runtime.GetNSObject<NSArray>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper(this.SuperHandle, Selector.GetHandle("paymentOptionsData")));
    //            }
    //            return ret;
    //        }
    //    }
    //}
}
