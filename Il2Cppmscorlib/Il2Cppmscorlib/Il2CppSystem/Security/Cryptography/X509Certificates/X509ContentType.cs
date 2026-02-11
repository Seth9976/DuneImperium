using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x0200027C RID: 636
	[OriginalName("mscorlib.dll", "System.Security.Cryptography.X509Certificates", "X509ContentType")]
	public enum X509ContentType
	{
		// Token: 0x040022ED RID: 8941
		Unknown,
		// Token: 0x040022EE RID: 8942
		Cert,
		// Token: 0x040022EF RID: 8943
		SerializedCert,
		// Token: 0x040022F0 RID: 8944
		Pfx,
		// Token: 0x040022F1 RID: 8945
		Pkcs12 = 3,
		// Token: 0x040022F2 RID: 8946
		SerializedStore,
		// Token: 0x040022F3 RID: 8947
		Pkcs7,
		// Token: 0x040022F4 RID: 8948
		Authenticode
	}
}
