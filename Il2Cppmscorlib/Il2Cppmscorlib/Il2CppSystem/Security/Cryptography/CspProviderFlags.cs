using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200023C RID: 572
	[OriginalName("mscorlib.dll", "System.Security.Cryptography", "CspProviderFlags")]
	[Flags]
	[Serializable]
	public enum CspProviderFlags
	{
		// Token: 0x040020B7 RID: 8375
		NoFlags = 0,
		// Token: 0x040020B8 RID: 8376
		UseMachineKeyStore = 1,
		// Token: 0x040020B9 RID: 8377
		UseDefaultKeyContainer = 2,
		// Token: 0x040020BA RID: 8378
		UseNonExportableKey = 4,
		// Token: 0x040020BB RID: 8379
		UseExistingKey = 8,
		// Token: 0x040020BC RID: 8380
		UseArchivableKey = 16,
		// Token: 0x040020BD RID: 8381
		UseUserProtectedKey = 32,
		// Token: 0x040020BE RID: 8382
		NoPrompt = 64,
		// Token: 0x040020BF RID: 8383
		CreateEphemeralKey = 128
	}
}
