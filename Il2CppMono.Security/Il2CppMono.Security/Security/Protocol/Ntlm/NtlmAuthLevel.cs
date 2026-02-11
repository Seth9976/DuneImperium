using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppMono.Security.Protocol.Ntlm
{
	// Token: 0x0200001A RID: 26
	[OriginalName("Mono.Security.dll", "Mono.Security.Protocol.Ntlm", "NtlmAuthLevel")]
	public enum NtlmAuthLevel
	{
		// Token: 0x04000148 RID: 328
		LM_and_NTLM,
		// Token: 0x04000149 RID: 329
		LM_and_NTLM_and_try_NTLMv2_Session,
		// Token: 0x0400014A RID: 330
		NTLM_only,
		// Token: 0x0400014B RID: 331
		NTLMv2_only
	}
}
