using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppSystem.Net.Security
{
	// Token: 0x0200025E RID: 606
	public static class CertificateHelper : Object
	{
		// Token: 0x06002886 RID: 10374 RVA: 0x000B8B4C File Offset: 0x000B6D4C
		// Note: this type is marked as 'beforefieldinit'.
		static CertificateHelper()
		{
			Il2CppClassPointerStore<CertificateHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Security", "CertificateHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CertificateHelper>.NativeClassPtr);
			CertificateHelper.NativeMethodInfoPtr_GetEligibleClientCertificate_Internal_Static_X509Certificate2_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CertificateHelper>.NativeClassPtr, 100669354);
			CertificateHelper.NativeMethodInfoPtr_GetEligibleClientCertificate_Internal_Static_X509Certificate2_X509Certificate2Collection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CertificateHelper>.NativeClassPtr, 100669355);
			CertificateHelper.NativeMethodInfoPtr_IsValidClientCertificate_Private_Static_Boolean_X509Certificate2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CertificateHelper>.NativeClassPtr, 100669356);
			CertificateHelper.NativeMethodInfoPtr_IsValidForClientAuthenticationEKU_Private_Static_Boolean_X509EnhancedKeyUsageExtension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CertificateHelper>.NativeClassPtr, 100669357);
			CertificateHelper.NativeMethodInfoPtr_IsValidForDigitalSignatureUsage_Private_Static_Boolean_X509KeyUsageExtension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CertificateHelper>.NativeClassPtr, 100669358);
			CertificateHelper.NativeMethodInfoPtr_GetEligibleClientCertificate_Internal_Static_X509Certificate2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CertificateHelper>.NativeClassPtr, 100669359);
		}

		// Token: 0x06002887 RID: 10375 RVA: 0x000B8BF4 File Offset: 0x000B6DF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 493815, RefRangeEnd = 493816, XrefRangeStart = 493803, XrefRangeEnd = 493815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static X509Certificate2 GetEligibleClientCertificate(X509CertificateCollection candidateCerts)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(candidateCerts);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CertificateHelper.NativeMethodInfoPtr_GetEligibleClientCertificate_Internal_Static_X509Certificate2_X509CertificateCollection_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate2>(intPtr3) : null;
			}
		}

		// Token: 0x06002888 RID: 10376 RVA: 0x000B8C38 File Offset: 0x000B6E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493816, XrefRangeEnd = 493822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static X509Certificate2 GetEligibleClientCertificate(X509Certificate2Collection candidateCerts)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(candidateCerts);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CertificateHelper.NativeMethodInfoPtr_GetEligibleClientCertificate_Internal_Static_X509Certificate2_X509Certificate2Collection_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate2>(intPtr3) : null;
			}
		}

		// Token: 0x06002889 RID: 10377 RVA: 0x000B8C7C File Offset: 0x000B6E7C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 493832, RefRangeEnd = 493835, XrefRangeStart = 493822, XrefRangeEnd = 493832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidClientCertificate(X509Certificate2 cert)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cert);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CertificateHelper.NativeMethodInfoPtr_IsValidClientCertificate_Private_Static_Boolean_X509Certificate2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600288A RID: 10378 RVA: 0x000B8CC0 File Offset: 0x000B6EC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 493842, RefRangeEnd = 493843, XrefRangeStart = 493835, XrefRangeEnd = 493842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidForClientAuthenticationEKU(X509EnhancedKeyUsageExtension eku)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eku);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CertificateHelper.NativeMethodInfoPtr_IsValidForClientAuthenticationEKU_Private_Static_Boolean_X509EnhancedKeyUsageExtension_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600288B RID: 10379 RVA: 0x000B8D04 File Offset: 0x000B6F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493843, XrefRangeEnd = 493844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidForDigitalSignatureUsage(X509KeyUsageExtension ku)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ku);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CertificateHelper.NativeMethodInfoPtr_IsValidForDigitalSignatureUsage_Private_Static_Boolean_X509KeyUsageExtension_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600288C RID: 10380 RVA: 0x000B8D48 File Offset: 0x000B6F48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 493862, RefRangeEnd = 493863, XrefRangeStart = 493844, XrefRangeEnd = 493862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static X509Certificate2 GetEligibleClientCertificate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CertificateHelper.NativeMethodInfoPtr_GetEligibleClientCertificate_Internal_Static_X509Certificate2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate2>(intPtr3) : null;
		}

		// Token: 0x0600288D RID: 10381 RVA: 0x0001174E File Offset: 0x0000F94E
		public CertificateHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002041 RID: 8257
		private static readonly IntPtr NativeMethodInfoPtr_GetEligibleClientCertificate_Internal_Static_X509Certificate2_X509CertificateCollection_0;

		// Token: 0x04002042 RID: 8258
		private static readonly IntPtr NativeMethodInfoPtr_GetEligibleClientCertificate_Internal_Static_X509Certificate2_X509Certificate2Collection_0;

		// Token: 0x04002043 RID: 8259
		private static readonly IntPtr NativeMethodInfoPtr_IsValidClientCertificate_Private_Static_Boolean_X509Certificate2_0;

		// Token: 0x04002044 RID: 8260
		private static readonly IntPtr NativeMethodInfoPtr_IsValidForClientAuthenticationEKU_Private_Static_Boolean_X509EnhancedKeyUsageExtension_0;

		// Token: 0x04002045 RID: 8261
		private static readonly IntPtr NativeMethodInfoPtr_IsValidForDigitalSignatureUsage_Private_Static_Boolean_X509KeyUsageExtension_0;

		// Token: 0x04002046 RID: 8262
		private static readonly IntPtr NativeMethodInfoPtr_GetEligibleClientCertificate_Internal_Static_X509Certificate2_0;
	}
}
