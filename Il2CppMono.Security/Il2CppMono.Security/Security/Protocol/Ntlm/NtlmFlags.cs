using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppMono.Security.Protocol.Ntlm
{
	// Token: 0x0200001B RID: 27
	[OriginalName("Mono.Security.dll", "Mono.Security.Protocol.Ntlm", "NtlmFlags")]
	[Flags]
	public enum NtlmFlags
	{
		// Token: 0x0400014D RID: 333
		NegotiateUnicode = 1,
		// Token: 0x0400014E RID: 334
		NegotiateOem = 2,
		// Token: 0x0400014F RID: 335
		RequestTarget = 4,
		// Token: 0x04000150 RID: 336
		NegotiateNtlm = 512,
		// Token: 0x04000151 RID: 337
		NegotiateDomainSupplied = 4096,
		// Token: 0x04000152 RID: 338
		NegotiateWorkstationSupplied = 8192,
		// Token: 0x04000153 RID: 339
		NegotiateAlwaysSign = 32768,
		// Token: 0x04000154 RID: 340
		NegotiateNtlm2Key = 524288,
		// Token: 0x04000155 RID: 341
		Negotiate128 = 536870912,
		// Token: 0x04000156 RID: 342
		Negotiate56 = -2147483648
	}
}
