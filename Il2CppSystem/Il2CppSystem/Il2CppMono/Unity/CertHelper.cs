using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Unity
{
	// Token: 0x02000008 RID: 8
	public static class CertHelper : Object
	{
		// Token: 0x0600003C RID: 60 RVA: 0x0001B604 File Offset: 0x00019804
		// Note: this type is marked as 'beforefieldinit'.
		static CertHelper()
		{
			Il2CppClassPointerStore<CertHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Unity", "CertHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CertHelper>.NativeClassPtr);
			CertHelper.NativeMethodInfoPtr_AddCertificatesToNativeChain_Public_Static_Void_ptr_unitytls_x509list_X509CertificateCollection_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CertHelper>.NativeClassPtr, 100663331);
			CertHelper.NativeMethodInfoPtr_AddCertificateToNativeChain_Public_Static_Void_ptr_unitytls_x509list_X509Certificate_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CertHelper>.NativeClassPtr, 100663332);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0001B65C File Offset: 0x0001985C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 426902, RefRangeEnd = 426904, XrefRangeStart = 426890, XrefRangeEnd = 426902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddCertificatesToNativeChain(UnityTls.unitytls_x509list* nativeCertificateChain, X509CertificateCollection certificates, UnityTls.unitytls_errorstate* errorState)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = nativeCertificateChain;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(certificates);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CertHelper.NativeMethodInfoPtr_AddCertificatesToNativeChain_Public_Static_Void_ptr_unitytls_x509list_X509CertificateCollection_ptr_unitytls_errorstate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0001B6AC File Offset: 0x000198AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 426919, RefRangeEnd = 426922, XrefRangeStart = 426904, XrefRangeEnd = 426919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddCertificateToNativeChain(UnityTls.unitytls_x509list* nativeCertificateChain, X509Certificate certificate, UnityTls.unitytls_errorstate* errorState)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = nativeCertificateChain;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(certificate);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CertHelper.NativeMethodInfoPtr_AddCertificateToNativeChain_Public_Static_Void_ptr_unitytls_x509list_X509Certificate_ptr_unitytls_errorstate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002191 File Offset: 0x00000391
		public CertHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_AddCertificatesToNativeChain_Public_Static_Void_ptr_unitytls_x509list_X509CertificateCollection_ptr_unitytls_errorstate_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_AddCertificateToNativeChain_Public_Static_Void_ptr_unitytls_x509list_X509Certificate_ptr_unitytls_errorstate_0;
	}
}
