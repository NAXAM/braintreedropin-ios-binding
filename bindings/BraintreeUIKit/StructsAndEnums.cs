using System;
using ObjCRuntime;

namespace BraintreeUIKit
{
	[Native]
	public enum BTUIKCardNumberFormFieldState : nint
	{
		Default = 0,
		Validate,
		Loading
	}

	[Native]
	public enum BTUIKPaymentOptionType : nint
	{
		Unknown = 0,
		Amex,
		DinersClub,
		Discover,
		MasterCard,
		Visa,
		Jcb,
		Laser,
		Maestro,
		UnionPay,
		Solo,
		Switch,
		UKMaestro,
		PayPal,
		Coinbase,
		Venmo,
		ApplePay
	}

	[Native]
	public enum BTUIKVisualAssetType : nint
	{
		Unknown = 0,
		CVVBack,
		CVVFront
	}

	[Native]
	public enum BTUIKVectorArtSize : nint
	{
		Regular,
		Large
	}
}
