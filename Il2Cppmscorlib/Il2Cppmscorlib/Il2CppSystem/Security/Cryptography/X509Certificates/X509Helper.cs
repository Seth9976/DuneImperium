using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;
using Il2CppMono;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x02000280 RID: 640
	public static class X509Helper : Object
	{
		// Token: 0x0600294D RID: 10573 RVA: 0x000DD52C File Offset: 0x000DB72C
		// Note: this type is marked as 'beforefieldinit'.
		static X509Helper()
		{
			Il2CppClassPointerStore<X509Helper>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography.X509Certificates", "X509Helper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Helper>.NativeClassPtr);
			X509Helper.NativeMethodInfoPtr_get_CertificateProvider_Private_Static_get_ISystemCertificateProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper>.NativeClassPtr, 100670055);
			X509Helper.NativeMethodInfoPtr_InitFromCertificate_Public_Static_X509CertificateImpl_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper>.NativeClassPtr, 100670056);
			X509Helper.NativeMethodInfoPtr_InitFromCertificate_Public_Static_X509CertificateImpl_X509CertificateImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper>.NativeClassPtr, 100670057);
			X509Helper.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_X509CertificateImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper>.NativeClassPtr, 100670058);
			X509Helper.NativeMethodInfoPtr_ThrowIfContextInvalid_Internal_Static_Void_X509CertificateImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper>.NativeClassPtr, 100670059);
			X509Helper.NativeMethodInfoPtr_GetInvalidContextException_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper>.NativeClassPtr, 100670060);
			X509Helper.NativeMethodInfoPtr_Import_Public_Static_X509CertificateImpl_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper>.NativeClassPtr, 100670061);
			X509Helper.NativeMethodInfoPtr_Import_Public_Static_X509CertificateImpl_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper>.NativeClassPtr, 100670062);
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x0600294E RID: 10574 RVA: 0x000DD5FC File Offset: 0x000DB7FC
		public unsafe static ISystemCertificateProvider CertificateProvider
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1375573, RefRangeEnd = 1375578, XrefRangeStart = 1375562, XrefRangeEnd = 1375573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper.NativeMethodInfoPtr_get_CertificateProvider_Private_Static_get_ISystemCertificateProvider_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISystemCertificateProvider>(intPtr3) : null;
			}
		}

		// Token: 0x0600294F RID: 10575 RVA: 0x000DD630 File Offset: 0x000DB830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375578, XrefRangeEnd = 1375584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static X509CertificateImpl InitFromCertificate(X509Certificate cert)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cert);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper.NativeMethodInfoPtr_InitFromCertificate_Public_Static_X509CertificateImpl_X509Certificate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr3) : null;
			}
		}

		// Token: 0x06002950 RID: 10576 RVA: 0x000DD674 File Offset: 0x000DB874
		[CallerCount(0)]
		public unsafe static X509CertificateImpl InitFromCertificate(X509CertificateImpl impl)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(impl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper.NativeMethodInfoPtr_InitFromCertificate_Public_Static_X509CertificateImpl_X509CertificateImpl_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr3) : null;
			}
		}

		// Token: 0x06002951 RID: 10577 RVA: 0x000DD6B8 File Offset: 0x000DB8B8
		[CallerCount(0)]
		public unsafe static bool IsValid(X509CertificateImpl impl)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(impl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_X509CertificateImpl_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002952 RID: 10578 RVA: 0x000DD6FC File Offset: 0x000DB8FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1375584, RefRangeEnd = 1375585, XrefRangeStart = 1375584, XrefRangeEnd = 1375584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowIfContextInvalid(X509CertificateImpl impl)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(impl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper.NativeMethodInfoPtr_ThrowIfContextInvalid_Internal_Static_Void_X509CertificateImpl_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002953 RID: 10579 RVA: 0x000DD734 File Offset: 0x000DB934
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1375592, RefRangeEnd = 1375601, XrefRangeStart = 1375585, XrefRangeEnd = 1375592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception GetInvalidContextException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper.NativeMethodInfoPtr_GetInvalidContextException_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06002954 RID: 10580 RVA: 0x000DD768 File Offset: 0x000DB968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375601, XrefRangeEnd = 1375607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static X509CertificateImpl Import(Il2CppStructArray<byte> rawData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper.NativeMethodInfoPtr_Import_Public_Static_X509CertificateImpl_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr3) : null;
			}
		}

		// Token: 0x06002955 RID: 10581 RVA: 0x000DD7AC File Offset: 0x000DB9AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1375611, RefRangeEnd = 1375614, XrefRangeStart = 1375607, XrefRangeEnd = 1375611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static X509CertificateImpl Import(Il2CppStructArray<byte> rawData, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(password);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyStorageFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper.NativeMethodInfoPtr_Import_Public_Static_X509CertificateImpl_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr3) : null;
		}

		// Token: 0x06002956 RID: 10582 RVA: 0x0000DA2F File Offset: 0x0000BC2F
		public X509Helper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002348 RID: 9032
		private static readonly IntPtr NativeMethodInfoPtr_get_CertificateProvider_Private_Static_get_ISystemCertificateProvider_0;

		// Token: 0x04002349 RID: 9033
		private static readonly IntPtr NativeMethodInfoPtr_InitFromCertificate_Public_Static_X509CertificateImpl_X509Certificate_0;

		// Token: 0x0400234A RID: 9034
		private static readonly IntPtr NativeMethodInfoPtr_InitFromCertificate_Public_Static_X509CertificateImpl_X509CertificateImpl_0;

		// Token: 0x0400234B RID: 9035
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Static_Boolean_X509CertificateImpl_0;

		// Token: 0x0400234C RID: 9036
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfContextInvalid_Internal_Static_Void_X509CertificateImpl_0;

		// Token: 0x0400234D RID: 9037
		private static readonly IntPtr NativeMethodInfoPtr_GetInvalidContextException_Internal_Static_Exception_0;

		// Token: 0x0400234E RID: 9038
		private static readonly IntPtr NativeMethodInfoPtr_Import_Public_Static_X509CertificateImpl_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400234F RID: 9039
		private static readonly IntPtr NativeMethodInfoPtr_Import_Public_Static_X509CertificateImpl_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_0;
	}
}
