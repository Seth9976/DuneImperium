using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020001A9 RID: 425
	public class CredentialCache : Object
	{
		// Token: 0x06001AA2 RID: 6818 RVA: 0x00084B4C File Offset: 0x00082D4C
		// Note: this type is marked as 'beforefieldinit'.
		static CredentialCache()
		{
			Il2CppClassPointerStore<CredentialCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "CredentialCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CredentialCache>.NativeClassPtr);
			CredentialCache.NativeMethodInfoPtr_get_DefaultCredentials_Public_Static_get_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CredentialCache>.NativeClassPtr, 100667443);
			CredentialCache.NativeMethodInfoPtr_get_DefaultNetworkCredentials_Public_Static_get_NetworkCredential_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CredentialCache>.NativeClassPtr, 100667444);
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x06001AA3 RID: 6819 RVA: 0x00084BA4 File Offset: 0x00082DA4
		public unsafe static ICredentials DefaultCredentials
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474033, XrefRangeEnd = 474037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CredentialCache.NativeMethodInfoPtr_get_DefaultCredentials_Public_Static_get_ICredentials_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr3) : null;
			}
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x06001AA4 RID: 6820 RVA: 0x00084BD8 File Offset: 0x00082DD8
		public unsafe static NetworkCredential DefaultNetworkCredentials
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474037, XrefRangeEnd = 474041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CredentialCache.NativeMethodInfoPtr_get_DefaultNetworkCredentials_Public_Static_get_NetworkCredential_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkCredential>(intPtr3) : null;
			}
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x0000B698 File Offset: 0x00009898
		public CredentialCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040014FD RID: 5373
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultCredentials_Public_Static_get_ICredentials_0;

		// Token: 0x040014FE RID: 5374
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultNetworkCredentials_Public_Static_get_NetworkCredential_0;
	}
}
