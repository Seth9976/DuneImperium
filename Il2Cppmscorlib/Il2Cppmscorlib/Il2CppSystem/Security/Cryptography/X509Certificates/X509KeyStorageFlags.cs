using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x0200027D RID: 637
	[OriginalName("mscorlib.dll", "System.Security.Cryptography.X509Certificates", "X509KeyStorageFlags")]
	[Flags]
	public enum X509KeyStorageFlags
	{
		// Token: 0x040022F6 RID: 8950
		DefaultKeySet = 0,
		// Token: 0x040022F7 RID: 8951
		UserKeySet = 1,
		// Token: 0x040022F8 RID: 8952
		MachineKeySet = 2,
		// Token: 0x040022F9 RID: 8953
		Exportable = 4,
		// Token: 0x040022FA RID: 8954
		UserProtected = 8,
		// Token: 0x040022FB RID: 8955
		PersistKeySet = 16,
		// Token: 0x040022FC RID: 8956
		EphemeralKeySet = 32
	}
}
