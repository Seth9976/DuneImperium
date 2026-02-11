using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;
using Il2CppMono.Security.X509;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000CD RID: 205
	public class X509Certificate2ImplMono : X509Certificate2ImplUnix
	{
		// Token: 0x06000D86 RID: 3462 RVA: 0x0004EC68 File Offset: 0x0004CE68
		// Note: this type is marked as 'beforefieldinit'.
		static X509Certificate2ImplMono()
		{
			Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509Certificate2ImplMono");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr);
			X509Certificate2ImplMono.NativeFieldInfoPtr_intermediateCerts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, "intermediateCerts");
			X509Certificate2ImplMono.NativeFieldInfoPtr__cert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, "_cert");
			X509Certificate2ImplMono.NativeFieldInfoPtr_empty_error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, "empty_error");
			X509Certificate2ImplMono.NativeFieldInfoPtr_signedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, "signedData");
			X509Certificate2ImplMono.NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, 100665246);
			X509Certificate2ImplMono.NativeMethodInfoPtr__ctor_Public_Void_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, 100665247);
			X509Certificate2ImplMono.NativeMethodInfoPtr__ctor_Private_Void_X509Certificate2ImplMono_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, 100665248);
			X509Certificate2ImplMono.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, 100665249);
			X509Certificate2ImplMono.NativeMethodInfoPtr_Clone_Public_Virtual_X509CertificateImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, 100665250);
			X509Certificate2ImplMono.NativeMethodInfoPtr_get_Cert_Private_get_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, 100665251);
			X509Certificate2ImplMono.NativeMethodInfoPtr_GetRawCertData_Protected_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, 100665252);
			X509Certificate2ImplMono.NativeMethodInfoPtr_get_HasPrivateKey_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, 100665253);
			X509Certificate2ImplMono.NativeMethodInfoPtr_get_PrivateKey_Public_Virtual_get_AsymmetricAlgorithm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, 100665254);
			X509Certificate2ImplMono.NativeMethodInfoPtr_set_PrivateKey_Public_Virtual_set_Void_AsymmetricAlgorithm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, 100665255);
			X509Certificate2ImplMono.NativeMethodInfoPtr_GetRSAPrivateKey_Public_Virtual_RSA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, 100665256);
			X509Certificate2ImplMono.NativeMethodInfoPtr_GetDSAPrivateKey_Public_Virtual_DSA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, 100665257);
			X509Certificate2ImplMono.NativeMethodInfoPtr_ImportPkcs12_Private_X509Certificate_Il2CppStructArray_1_Byte_SafePasswordHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, 100665258);
			X509Certificate2ImplMono.NativeMethodInfoPtr_ImportPkcs12_Private_X509Certificate_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, 100665259);
			X509Certificate2ImplMono.NativeMethodInfoPtr_Verify_Public_Virtual_Boolean_X509Certificate2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, 100665260);
			X509Certificate2ImplMono.NativeMethodInfoPtr_get_IntermediateCertificates_Internal_Virtual_get_X509CertificateImplCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, 100665261);
			X509Certificate2ImplMono.NativeMethodInfoPtr_get_MonoCertificate_Internal_get_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, 100665262);
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000D87 RID: 3463 RVA: 0x0004EE3C File Offset: 0x0004D03C
		public unsafe override bool IsValid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2ImplMono.NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x0004EE84 File Offset: 0x0004D084
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 453920, RefRangeEnd = 453921, XrefRangeStart = 453918, XrefRangeEnd = 453920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate2ImplMono(X509Certificate cert)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cert);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2ImplMono.NativeMethodInfoPtr__ctor_Public_Void_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x0004EED0 File Offset: 0x0004D0D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453921, XrefRangeEnd = 453928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate2ImplMono(X509Certificate2ImplMono other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2ImplMono.NativeMethodInfoPtr__ctor_Private_Void_X509Certificate2ImplMono_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x0004EF1C File Offset: 0x0004D11C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 453937, RefRangeEnd = 453939, XrefRangeStart = 453928, XrefRangeEnd = 453937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate2ImplMono(Il2CppStructArray<byte> rawData, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2ImplMono.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x0004EF88 File Offset: 0x0004D188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453939, XrefRangeEnd = 453950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override X509CertificateImpl Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2ImplMono.NativeMethodInfoPtr_Clone_Public_Virtual_X509CertificateImpl_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr3) : null;
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000D8C RID: 3468 RVA: 0x0004EFD4 File Offset: 0x0004D1D4
		public unsafe X509Certificate Cert
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 432682, RefRangeEnd = 432683, XrefRangeStart = 432682, XrefRangeEnd = 432683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2ImplMono.NativeMethodInfoPtr_get_Cert_Private_get_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
			}
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x0004F014 File Offset: 0x0004D214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453950, XrefRangeEnd = 453953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> GetRawCertData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2ImplMono.NativeMethodInfoPtr_GetRawCertData_Protected_Virtual_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000D8E RID: 3470 RVA: 0x0004F060 File Offset: 0x0004D260
		public unsafe override bool HasPrivateKey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2ImplMono.NativeMethodInfoPtr_get_HasPrivateKey_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000D8F RID: 3471 RVA: 0x0004F0A8 File Offset: 0x0004D2A8
		// (set) Token: 0x06000D90 RID: 3472 RVA: 0x0004F0F4 File Offset: 0x0004D2F4
		public unsafe override AsymmetricAlgorithm PrivateKey
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453953, XrefRangeEnd = 453979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2ImplMono.NativeMethodInfoPtr_get_PrivateKey_Public_Virtual_get_AsymmetricAlgorithm_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsymmetricAlgorithm>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453979, XrefRangeEnd = 454002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2ImplMono.NativeMethodInfoPtr_set_PrivateKey_Public_Virtual_set_Void_AsymmetricAlgorithm_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x0004F144 File Offset: 0x0004D344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454002, XrefRangeEnd = 454003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override RSA GetRSAPrivateKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2ImplMono.NativeMethodInfoPtr_GetRSAPrivateKey_Public_Virtual_RSA_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RSA>(intPtr3) : null;
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x0004F190 File Offset: 0x0004D390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454003, XrefRangeEnd = 454004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DSA GetDSAPrivateKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2ImplMono.NativeMethodInfoPtr_GetDSAPrivateKey_Public_Virtual_DSA_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DSA>(intPtr3) : null;
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x0004F1DC File Offset: 0x0004D3DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454004, XrefRangeEnd = 454007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate ImportPkcs12(Il2CppStructArray<byte> rawData, SafePasswordHandle password)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(password);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2ImplMono.NativeMethodInfoPtr_ImportPkcs12_Private_X509Certificate_Il2CppStructArray_1_Byte_SafePasswordHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x0004F240 File Offset: 0x0004D440
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 454085, RefRangeEnd = 454087, XrefRangeStart = 454007, XrefRangeEnd = 454085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate ImportPkcs12(Il2CppStructArray<byte> rawData, string password)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2ImplMono.NativeMethodInfoPtr_ImportPkcs12_Private_X509Certificate_Il2CppStructArray_1_Byte_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x0004F2A4 File Offset: 0x0004D4A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454087, XrefRangeEnd = 454096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Verify(X509Certificate2 thisCertificate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisCertificate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2ImplMono.NativeMethodInfoPtr_Verify_Public_Virtual_Boolean_X509Certificate2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000D96 RID: 3478 RVA: 0x0004F2FC File Offset: 0x0004D4FC
		public unsafe override X509CertificateImplCollection IntermediateCertificates
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2ImplMono.NativeMethodInfoPtr_get_IntermediateCertificates_Internal_Virtual_get_X509CertificateImplCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateImplCollection>(intPtr3) : null;
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000D97 RID: 3479 RVA: 0x0004F348 File Offset: 0x0004D548
		public unsafe X509Certificate MonoCertificate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2ImplMono.NativeMethodInfoPtr_get_MonoCertificate_Internal_get_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
			}
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x00006F5B File Offset: 0x0000515B
		public X509Certificate2ImplMono(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000D99 RID: 3481 RVA: 0x0004F388 File Offset: 0x0004D588
		// (set) Token: 0x06000D9A RID: 3482 RVA: 0x00006F64 File Offset: 0x00005164
		public unsafe X509CertificateImplCollection intermediateCerts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2ImplMono.NativeFieldInfoPtr_intermediateCerts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509CertificateImplCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2ImplMono.NativeFieldInfoPtr_intermediateCerts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000D9B RID: 3483 RVA: 0x0004F3B8 File Offset: 0x0004D5B8
		// (set) Token: 0x06000D9C RID: 3484 RVA: 0x00006F83 File Offset: 0x00005183
		public unsafe X509Certificate _cert
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2ImplMono.NativeFieldInfoPtr__cert);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2ImplMono.NativeFieldInfoPtr__cert), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000D9D RID: 3485 RVA: 0x0004F3E8 File Offset: 0x0004D5E8
		// (set) Token: 0x06000D9E RID: 3486 RVA: 0x00006FA2 File Offset: 0x000051A2
		public unsafe static string empty_error
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X509Certificate2ImplMono.NativeFieldInfoPtr_empty_error, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509Certificate2ImplMono.NativeFieldInfoPtr_empty_error, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000D9F RID: 3487 RVA: 0x0004F408 File Offset: 0x0004D608
		// (set) Token: 0x06000DA0 RID: 3488 RVA: 0x00006FB4 File Offset: 0x000051B4
		public unsafe static Il2CppStructArray<byte> signedData
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X509Certificate2ImplMono.NativeFieldInfoPtr_signedData, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509Certificate2ImplMono.NativeFieldInfoPtr_signedData, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B2A RID: 2858
		private static readonly IntPtr NativeFieldInfoPtr_intermediateCerts;

		// Token: 0x04000B2B RID: 2859
		private static readonly IntPtr NativeFieldInfoPtr__cert;

		// Token: 0x04000B2C RID: 2860
		private static readonly IntPtr NativeFieldInfoPtr_empty_error;

		// Token: 0x04000B2D RID: 2861
		private static readonly IntPtr NativeFieldInfoPtr_signedData;

		// Token: 0x04000B2E RID: 2862
		private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0;

		// Token: 0x04000B2F RID: 2863
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_X509Certificate_0;

		// Token: 0x04000B30 RID: 2864
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_X509Certificate2ImplMono_0;

		// Token: 0x04000B31 RID: 2865
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_0;

		// Token: 0x04000B32 RID: 2866
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_X509CertificateImpl_0;

		// Token: 0x04000B33 RID: 2867
		private static readonly IntPtr NativeMethodInfoPtr_get_Cert_Private_get_X509Certificate_0;

		// Token: 0x04000B34 RID: 2868
		private static readonly IntPtr NativeMethodInfoPtr_GetRawCertData_Protected_Virtual_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000B35 RID: 2869
		private static readonly IntPtr NativeMethodInfoPtr_get_HasPrivateKey_Public_Virtual_get_Boolean_0;

		// Token: 0x04000B36 RID: 2870
		private static readonly IntPtr NativeMethodInfoPtr_get_PrivateKey_Public_Virtual_get_AsymmetricAlgorithm_0;

		// Token: 0x04000B37 RID: 2871
		private static readonly IntPtr NativeMethodInfoPtr_set_PrivateKey_Public_Virtual_set_Void_AsymmetricAlgorithm_0;

		// Token: 0x04000B38 RID: 2872
		private static readonly IntPtr NativeMethodInfoPtr_GetRSAPrivateKey_Public_Virtual_RSA_0;

		// Token: 0x04000B39 RID: 2873
		private static readonly IntPtr NativeMethodInfoPtr_GetDSAPrivateKey_Public_Virtual_DSA_0;

		// Token: 0x04000B3A RID: 2874
		private static readonly IntPtr NativeMethodInfoPtr_ImportPkcs12_Private_X509Certificate_Il2CppStructArray_1_Byte_SafePasswordHandle_0;

		// Token: 0x04000B3B RID: 2875
		private static readonly IntPtr NativeMethodInfoPtr_ImportPkcs12_Private_X509Certificate_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x04000B3C RID: 2876
		private static readonly IntPtr NativeMethodInfoPtr_Verify_Public_Virtual_Boolean_X509Certificate2_0;

		// Token: 0x04000B3D RID: 2877
		private static readonly IntPtr NativeMethodInfoPtr_get_IntermediateCertificates_Internal_Virtual_get_X509CertificateImplCollection_0;

		// Token: 0x04000B3E RID: 2878
		private static readonly IntPtr NativeMethodInfoPtr_get_MonoCertificate_Internal_get_X509Certificate_0;
	}
}
