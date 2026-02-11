using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Net.Security;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace dwd.core.platform.security
{
	// Token: 0x02000045 RID: 69
	public static class CertificateValidation : Object
	{
		// Token: 0x06000263 RID: 611 RVA: 0x0000CB78 File Offset: 0x0000AD78
		// Note: this type is marked as 'beforefieldinit'.
		static CertificateValidation()
		{
			Il2CppClassPointerStore<CertificateValidation>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.security", "CertificateValidation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CertificateValidation>.NativeClassPtr);
			CertificateValidation.NativeMethodInfoPtr_Init_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CertificateValidation>.NativeClassPtr, 100663646);
			CertificateValidation.NativeMethodInfoPtr_RemoteCertificateValidationCallback_Private_Static_Boolean_Object_X509Certificate_X509Chain_SslPolicyErrors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CertificateValidation>.NativeClassPtr, 100663647);
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0000CBD0 File Offset: 0x0000ADD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168191, XrefRangeEnd = 1168205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Init()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CertificateValidation.NativeMethodInfoPtr_Init_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0000CBF8 File Offset: 0x0000ADF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168205, XrefRangeEnd = 1168222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RemoteCertificateValidationCallback(Object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(certificate);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chain);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sslPolicyErrors;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CertificateValidation.NativeMethodInfoPtr_RemoteCertificateValidationCallback_Private_Static_Boolean_Object_X509Certificate_X509Chain_SslPolicyErrors_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00003385 File Offset: 0x00001585
		public CertificateValidation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Static_Void_0;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeMethodInfoPtr_RemoteCertificateValidationCallback_Private_Static_Boolean_Object_X509Certificate_X509Chain_SslPolicyErrors_0;
	}
}
