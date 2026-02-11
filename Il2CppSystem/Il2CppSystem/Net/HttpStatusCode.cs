using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net
{
	// Token: 0x02000193 RID: 403
	[OriginalName("System.dll", "System.Net", "HttpStatusCode")]
	public enum HttpStatusCode
	{
		// Token: 0x04001318 RID: 4888
		Continue = 100,
		// Token: 0x04001319 RID: 4889
		SwitchingProtocols,
		// Token: 0x0400131A RID: 4890
		Processing,
		// Token: 0x0400131B RID: 4891
		EarlyHints,
		// Token: 0x0400131C RID: 4892
		OK = 200,
		// Token: 0x0400131D RID: 4893
		Created,
		// Token: 0x0400131E RID: 4894
		Accepted,
		// Token: 0x0400131F RID: 4895
		NonAuthoritativeInformation,
		// Token: 0x04001320 RID: 4896
		NoContent,
		// Token: 0x04001321 RID: 4897
		ResetContent,
		// Token: 0x04001322 RID: 4898
		PartialContent,
		// Token: 0x04001323 RID: 4899
		MultiStatus,
		// Token: 0x04001324 RID: 4900
		AlreadyReported,
		// Token: 0x04001325 RID: 4901
		IMUsed = 226,
		// Token: 0x04001326 RID: 4902
		MultipleChoices = 300,
		// Token: 0x04001327 RID: 4903
		Ambiguous = 300,
		// Token: 0x04001328 RID: 4904
		MovedPermanently,
		// Token: 0x04001329 RID: 4905
		Moved = 301,
		// Token: 0x0400132A RID: 4906
		Found,
		// Token: 0x0400132B RID: 4907
		Redirect = 302,
		// Token: 0x0400132C RID: 4908
		SeeOther,
		// Token: 0x0400132D RID: 4909
		RedirectMethod = 303,
		// Token: 0x0400132E RID: 4910
		NotModified,
		// Token: 0x0400132F RID: 4911
		UseProxy,
		// Token: 0x04001330 RID: 4912
		Unused,
		// Token: 0x04001331 RID: 4913
		TemporaryRedirect,
		// Token: 0x04001332 RID: 4914
		RedirectKeepVerb = 307,
		// Token: 0x04001333 RID: 4915
		PermanentRedirect,
		// Token: 0x04001334 RID: 4916
		BadRequest = 400,
		// Token: 0x04001335 RID: 4917
		Unauthorized,
		// Token: 0x04001336 RID: 4918
		PaymentRequired,
		// Token: 0x04001337 RID: 4919
		Forbidden,
		// Token: 0x04001338 RID: 4920
		NotFound,
		// Token: 0x04001339 RID: 4921
		MethodNotAllowed,
		// Token: 0x0400133A RID: 4922
		NotAcceptable,
		// Token: 0x0400133B RID: 4923
		ProxyAuthenticationRequired,
		// Token: 0x0400133C RID: 4924
		RequestTimeout,
		// Token: 0x0400133D RID: 4925
		Conflict,
		// Token: 0x0400133E RID: 4926
		Gone,
		// Token: 0x0400133F RID: 4927
		LengthRequired,
		// Token: 0x04001340 RID: 4928
		PreconditionFailed,
		// Token: 0x04001341 RID: 4929
		RequestEntityTooLarge,
		// Token: 0x04001342 RID: 4930
		RequestUriTooLong,
		// Token: 0x04001343 RID: 4931
		UnsupportedMediaType,
		// Token: 0x04001344 RID: 4932
		RequestedRangeNotSatisfiable,
		// Token: 0x04001345 RID: 4933
		ExpectationFailed,
		// Token: 0x04001346 RID: 4934
		MisdirectedRequest = 421,
		// Token: 0x04001347 RID: 4935
		UnprocessableEntity,
		// Token: 0x04001348 RID: 4936
		Locked,
		// Token: 0x04001349 RID: 4937
		FailedDependency,
		// Token: 0x0400134A RID: 4938
		UpgradeRequired = 426,
		// Token: 0x0400134B RID: 4939
		PreconditionRequired = 428,
		// Token: 0x0400134C RID: 4940
		TooManyRequests,
		// Token: 0x0400134D RID: 4941
		RequestHeaderFieldsTooLarge = 431,
		// Token: 0x0400134E RID: 4942
		UnavailableForLegalReasons = 451,
		// Token: 0x0400134F RID: 4943
		InternalServerError = 500,
		// Token: 0x04001350 RID: 4944
		NotImplemented,
		// Token: 0x04001351 RID: 4945
		BadGateway,
		// Token: 0x04001352 RID: 4946
		ServiceUnavailable,
		// Token: 0x04001353 RID: 4947
		GatewayTimeout,
		// Token: 0x04001354 RID: 4948
		HttpVersionNotSupported,
		// Token: 0x04001355 RID: 4949
		VariantAlsoNegotiates,
		// Token: 0x04001356 RID: 4950
		InsufficientStorage,
		// Token: 0x04001357 RID: 4951
		LoopDetected,
		// Token: 0x04001358 RID: 4952
		NotExtended = 510,
		// Token: 0x04001359 RID: 4953
		NetworkAuthenticationRequired
	}
}
