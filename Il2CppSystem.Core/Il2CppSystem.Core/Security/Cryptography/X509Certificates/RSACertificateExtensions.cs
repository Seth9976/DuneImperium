using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x02000016 RID: 22
	public static class RSACertificateExtensions : Object
	{
		// Token: 0x06000098 RID: 152 RVA: 0x0000224C File Offset: 0x0000044C
		// Note: this type is marked as 'beforefieldinit'.
		static RSACertificateExtensions()
		{
			Il2CppClassPointerStore<RSACertificateExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Security.Cryptography.X509Certificates", "RSACertificateExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RSACertificateExtensions>.NativeClassPtr);
			RSACertificateExtensions.NativeMethodInfoPtr_GetRSAPublicKey_Public_Static_RSA_X509Certificate2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSACertificateExtensions>.NativeClassPtr, 100663378);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00011F48 File Offset: 0x00010148
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1002486, RefRangeEnd = 1002487, XrefRangeStart = 1002483, XrefRangeEnd = 1002486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RSA GetRSAPublicKey(this X509Certificate2 certificate)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSACertificateExtensions.NativeMethodInfoPtr_GetRSAPublicKey_Public_Static_RSA_X509Certificate2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RSA>(intPtr3) : null;
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002285 File Offset: 0x00000485
		public RSACertificateExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_GetRSAPublicKey_Public_Static_RSA_X509Certificate2_0;
	}
}
