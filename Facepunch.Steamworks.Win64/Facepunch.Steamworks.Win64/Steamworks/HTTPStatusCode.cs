using System;

namespace Steamworks
{
	// Token: 0x0200006C RID: 108
	public enum HTTPStatusCode
	{
		// Token: 0x04000A82 RID: 2690
		Invalid,
		// Token: 0x04000A83 RID: 2691
		Code100Continue = 100,
		// Token: 0x04000A84 RID: 2692
		Code101SwitchingProtocols,
		// Token: 0x04000A85 RID: 2693
		Code200OK = 200,
		// Token: 0x04000A86 RID: 2694
		Code201Created,
		// Token: 0x04000A87 RID: 2695
		Code202Accepted,
		// Token: 0x04000A88 RID: 2696
		Code203NonAuthoritative,
		// Token: 0x04000A89 RID: 2697
		Code204NoContent,
		// Token: 0x04000A8A RID: 2698
		Code205ResetContent,
		// Token: 0x04000A8B RID: 2699
		Code206PartialContent,
		// Token: 0x04000A8C RID: 2700
		Code300MultipleChoices = 300,
		// Token: 0x04000A8D RID: 2701
		Code301MovedPermanently,
		// Token: 0x04000A8E RID: 2702
		Code302Found,
		// Token: 0x04000A8F RID: 2703
		Code303SeeOther,
		// Token: 0x04000A90 RID: 2704
		Code304NotModified,
		// Token: 0x04000A91 RID: 2705
		Code305UseProxy,
		// Token: 0x04000A92 RID: 2706
		Code307TemporaryRedirect = 307,
		// Token: 0x04000A93 RID: 2707
		Code400BadRequest = 400,
		// Token: 0x04000A94 RID: 2708
		Code401Unauthorized,
		// Token: 0x04000A95 RID: 2709
		Code402PaymentRequired,
		// Token: 0x04000A96 RID: 2710
		Code403Forbidden,
		// Token: 0x04000A97 RID: 2711
		Code404NotFound,
		// Token: 0x04000A98 RID: 2712
		Code405MethodNotAllowed,
		// Token: 0x04000A99 RID: 2713
		Code406NotAcceptable,
		// Token: 0x04000A9A RID: 2714
		Code407ProxyAuthRequired,
		// Token: 0x04000A9B RID: 2715
		Code408RequestTimeout,
		// Token: 0x04000A9C RID: 2716
		Code409Conflict,
		// Token: 0x04000A9D RID: 2717
		Code410Gone,
		// Token: 0x04000A9E RID: 2718
		Code411LengthRequired,
		// Token: 0x04000A9F RID: 2719
		Code412PreconditionFailed,
		// Token: 0x04000AA0 RID: 2720
		Code413RequestEntityTooLarge,
		// Token: 0x04000AA1 RID: 2721
		Code414RequestURITooLong,
		// Token: 0x04000AA2 RID: 2722
		Code415UnsupportedMediaType,
		// Token: 0x04000AA3 RID: 2723
		Code416RequestedRangeNotSatisfiable,
		// Token: 0x04000AA4 RID: 2724
		Code417ExpectationFailed,
		// Token: 0x04000AA5 RID: 2725
		Code4xxUnknown,
		// Token: 0x04000AA6 RID: 2726
		Code429TooManyRequests = 429,
		// Token: 0x04000AA7 RID: 2727
		Code444ConnectionClosed = 444,
		// Token: 0x04000AA8 RID: 2728
		Code500InternalServerError = 500,
		// Token: 0x04000AA9 RID: 2729
		Code501NotImplemented,
		// Token: 0x04000AAA RID: 2730
		Code502BadGateway,
		// Token: 0x04000AAB RID: 2731
		Code503ServiceUnavailable,
		// Token: 0x04000AAC RID: 2732
		Code504GatewayTimeout,
		// Token: 0x04000AAD RID: 2733
		Code505HTTPVersionNotSupported,
		// Token: 0x04000AAE RID: 2734
		Code5xxUnknown = 599
	}
}
