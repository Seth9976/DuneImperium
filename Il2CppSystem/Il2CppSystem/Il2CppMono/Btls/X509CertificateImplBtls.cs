using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;
using Il2CppSystem.Security.Cryptography;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Btls
{
	// Token: 0x0200004C RID: 76
	public class X509CertificateImplBtls : X509Certificate2ImplUnix
	{
		// Token: 0x0600045E RID: 1118 RVA: 0x0002CC94 File Offset: 0x0002AE94
		// Note: this type is marked as 'beforefieldinit'.
		static X509CertificateImplBtls()
		{
			Il2CppClassPointerStore<X509CertificateImplBtls>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Btls", "X509CertificateImplBtls");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509CertificateImplBtls>.NativeClassPtr);
			X509CertificateImplBtls.NativeFieldInfoPtr_x509 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509CertificateImplBtls>.NativeClassPtr, "x509");
			X509CertificateImplBtls.NativeFieldInfoPtr_nativePrivateKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509CertificateImplBtls>.NativeClassPtr, "nativePrivateKey");
			X509CertificateImplBtls.NativeFieldInfoPtr_intermediateCerts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509CertificateImplBtls>.NativeClassPtr, "intermediateCerts");
			X509CertificateImplBtls.NativeMethodInfoPtr__ctor_Internal_Void_MonoBtlsX509_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplBtls>.NativeClassPtr, 100664093);
			X509CertificateImplBtls.NativeMethodInfoPtr__ctor_Private_Void_X509CertificateImplBtls_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplBtls>.NativeClassPtr, 100664094);
			X509CertificateImplBtls.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_MonoBtlsX509Format_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplBtls>.NativeClassPtr, 100664095);
			X509CertificateImplBtls.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplBtls>.NativeClassPtr, 100664096);
			X509CertificateImplBtls.NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplBtls>.NativeClassPtr, 100664097);
			X509CertificateImplBtls.NativeMethodInfoPtr_get_X509_Internal_get_MonoBtlsX509_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplBtls>.NativeClassPtr, 100664098);
			X509CertificateImplBtls.NativeMethodInfoPtr_get_NativePrivateKey_Internal_get_MonoBtlsKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplBtls>.NativeClassPtr, 100664099);
			X509CertificateImplBtls.NativeMethodInfoPtr_Clone_Public_Virtual_X509CertificateImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplBtls>.NativeClassPtr, 100664100);
			X509CertificateImplBtls.NativeMethodInfoPtr_GetRawCertData_Protected_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplBtls>.NativeClassPtr, 100664101);
			X509CertificateImplBtls.NativeMethodInfoPtr_get_IntermediateCertificates_Internal_Virtual_get_X509CertificateImplCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplBtls>.NativeClassPtr, 100664102);
			X509CertificateImplBtls.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplBtls>.NativeClassPtr, 100664103);
			X509CertificateImplBtls.NativeMethodInfoPtr_get_HasPrivateKey_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplBtls>.NativeClassPtr, 100664104);
			X509CertificateImplBtls.NativeMethodInfoPtr_get_PrivateKey_Public_Virtual_get_AsymmetricAlgorithm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplBtls>.NativeClassPtr, 100664105);
			X509CertificateImplBtls.NativeMethodInfoPtr_set_PrivateKey_Public_Virtual_set_Void_AsymmetricAlgorithm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplBtls>.NativeClassPtr, 100664106);
			X509CertificateImplBtls.NativeMethodInfoPtr_GetRSAPrivateKey_Public_Virtual_RSA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplBtls>.NativeClassPtr, 100664107);
			X509CertificateImplBtls.NativeMethodInfoPtr_GetDSAPrivateKey_Public_Virtual_DSA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplBtls>.NativeClassPtr, 100664108);
			X509CertificateImplBtls.NativeMethodInfoPtr_Import_Private_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplBtls>.NativeClassPtr, 100664109);
			X509CertificateImplBtls.NativeMethodInfoPtr_ImportPkcs12_Private_Void_Il2CppStructArray_1_Byte_SafePasswordHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplBtls>.NativeClassPtr, 100664110);
			X509CertificateImplBtls.NativeMethodInfoPtr_ImportAuthenticode_Private_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplBtls>.NativeClassPtr, 100664111);
			X509CertificateImplBtls.NativeMethodInfoPtr_Verify_Public_Virtual_Boolean_X509Certificate2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplBtls>.NativeClassPtr, 100664112);
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0002CE90 File Offset: 0x0002B090
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 432641, RefRangeEnd = 432642, XrefRangeStart = 432637, XrefRangeEnd = 432641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509CertificateImplBtls(MonoBtlsX509 x509)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509CertificateImplBtls>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x509);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImplBtls.NativeMethodInfoPtr__ctor_Internal_Void_MonoBtlsX509_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0002CEDC File Offset: 0x0002B0DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432642, XrefRangeEnd = 432650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509CertificateImplBtls(X509CertificateImplBtls other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509CertificateImplBtls>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImplBtls.NativeMethodInfoPtr__ctor_Private_Void_X509CertificateImplBtls_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x0002CF28 File Offset: 0x0002B128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432650, XrefRangeEnd = 432653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509CertificateImplBtls(Il2CppStructArray<byte> data, MonoBtlsX509Format format)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509CertificateImplBtls>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImplBtls.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_MonoBtlsX509Format_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x0002CF84 File Offset: 0x0002B184
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 432673, RefRangeEnd = 432675, XrefRangeStart = 432653, XrefRangeEnd = 432673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509CertificateImplBtls(Il2CppStructArray<byte> data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509CertificateImplBtls>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(password);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyStorageFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImplBtls.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x0002CFF0 File Offset: 0x0002B1F0
		public unsafe override bool IsValid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImplBtls.NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x0002D038 File Offset: 0x0002B238
		public unsafe MonoBtlsX509 X509
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 432676, RefRangeEnd = 432681, XrefRangeStart = 432675, XrefRangeEnd = 432676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImplBtls.NativeMethodInfoPtr_get_X509_Internal_get_MonoBtlsX509_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509>(intPtr3) : null;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x0002D078 File Offset: 0x0002B278
		public unsafe MonoBtlsKey NativePrivateKey
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 432682, RefRangeEnd = 432683, XrefRangeStart = 432681, XrefRangeEnd = 432682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImplBtls.NativeMethodInfoPtr_get_NativePrivateKey_Internal_get_MonoBtlsKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsKey>(intPtr3) : null;
			}
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x0002D0B8 File Offset: 0x0002B2B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432683, XrefRangeEnd = 432695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override X509CertificateImpl Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImplBtls.NativeMethodInfoPtr_Clone_Public_Virtual_X509CertificateImpl_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr3) : null;
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x0002D104 File Offset: 0x0002B304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432695, XrefRangeEnd = 432699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> GetRawCertData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImplBtls.NativeMethodInfoPtr_GetRawCertData_Protected_Virtual_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x0002D150 File Offset: 0x0002B350
		public unsafe override X509CertificateImplCollection IntermediateCertificates
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImplBtls.NativeMethodInfoPtr_get_IntermediateCertificates_Internal_Virtual_get_X509CertificateImplCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateImplCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x0002D19C File Offset: 0x0002B39C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432699, XrefRangeEnd = 432701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImplBtls.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x0002D1E8 File Offset: 0x0002B3E8
		public unsafe override bool HasPrivateKey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImplBtls.NativeMethodInfoPtr_get_HasPrivateKey_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x0002D230 File Offset: 0x0002B430
		// (set) Token: 0x0600046C RID: 1132 RVA: 0x0002D27C File Offset: 0x0002B47C
		public unsafe override AsymmetricAlgorithm PrivateKey
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432701, XrefRangeEnd = 432703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImplBtls.NativeMethodInfoPtr_get_PrivateKey_Public_Virtual_get_AsymmetricAlgorithm_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsymmetricAlgorithm>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432703, XrefRangeEnd = 432710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImplBtls.NativeMethodInfoPtr_set_PrivateKey_Public_Virtual_set_Void_AsymmetricAlgorithm_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x0002D2CC File Offset: 0x0002B4CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override RSA GetRSAPrivateKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImplBtls.NativeMethodInfoPtr_GetRSAPrivateKey_Public_Virtual_RSA_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RSA>(intPtr3) : null;
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x0002D318 File Offset: 0x0002B518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432710, XrefRangeEnd = 432715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DSA GetDSAPrivateKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImplBtls.NativeMethodInfoPtr_GetDSAPrivateKey_Public_Virtual_DSA_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DSA>(intPtr3) : null;
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x0002D364 File Offset: 0x0002B564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432715, XrefRangeEnd = 432717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Import(Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImplBtls.NativeMethodInfoPtr_Import_Private_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x0002D3A8 File Offset: 0x0002B5A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 432769, RefRangeEnd = 432771, XrefRangeStart = 432717, XrefRangeEnd = 432769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ImportPkcs12(Il2CppStructArray<byte> data, SafePasswordHandle password)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(password);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImplBtls.NativeMethodInfoPtr_ImportPkcs12_Private_Void_Il2CppStructArray_1_Byte_SafePasswordHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x0002D3FC File Offset: 0x0002B5FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 432777, RefRangeEnd = 432779, XrefRangeStart = 432771, XrefRangeEnd = 432777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ImportAuthenticode(Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImplBtls.NativeMethodInfoPtr_ImportAuthenticode_Private_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x0002D440 File Offset: 0x0002B640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432779, XrefRangeEnd = 432805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Verify(X509Certificate2 thisCertificate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisCertificate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImplBtls.NativeMethodInfoPtr_Verify_Public_Virtual_Boolean_X509Certificate2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x000035BD File Offset: 0x000017BD
		public X509CertificateImplBtls(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x0002D498 File Offset: 0x0002B698
		// (set) Token: 0x06000475 RID: 1141 RVA: 0x000035C6 File Offset: 0x000017C6
		public unsafe MonoBtlsX509 x509
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509CertificateImplBtls.NativeFieldInfoPtr_x509);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509CertificateImplBtls.NativeFieldInfoPtr_x509), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x0002D4C8 File Offset: 0x0002B6C8
		// (set) Token: 0x06000477 RID: 1143 RVA: 0x000035E5 File Offset: 0x000017E5
		public unsafe MonoBtlsKey nativePrivateKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509CertificateImplBtls.NativeFieldInfoPtr_nativePrivateKey);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoBtlsKey>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509CertificateImplBtls.NativeFieldInfoPtr_nativePrivateKey), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x0002D4F8 File Offset: 0x0002B6F8
		// (set) Token: 0x06000479 RID: 1145 RVA: 0x00003604 File Offset: 0x00001804
		public unsafe X509CertificateImplCollection intermediateCerts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509CertificateImplBtls.NativeFieldInfoPtr_intermediateCerts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509CertificateImplCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509CertificateImplBtls.NativeFieldInfoPtr_intermediateCerts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003B2 RID: 946
		private static readonly IntPtr NativeFieldInfoPtr_x509;

		// Token: 0x040003B3 RID: 947
		private static readonly IntPtr NativeFieldInfoPtr_nativePrivateKey;

		// Token: 0x040003B4 RID: 948
		private static readonly IntPtr NativeFieldInfoPtr_intermediateCerts;

		// Token: 0x040003B5 RID: 949
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_MonoBtlsX509_0;

		// Token: 0x040003B6 RID: 950
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_X509CertificateImplBtls_0;

		// Token: 0x040003B7 RID: 951
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_MonoBtlsX509Format_0;

		// Token: 0x040003B8 RID: 952
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_0;

		// Token: 0x040003B9 RID: 953
		private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0;

		// Token: 0x040003BA RID: 954
		private static readonly IntPtr NativeMethodInfoPtr_get_X509_Internal_get_MonoBtlsX509_0;

		// Token: 0x040003BB RID: 955
		private static readonly IntPtr NativeMethodInfoPtr_get_NativePrivateKey_Internal_get_MonoBtlsKey_0;

		// Token: 0x040003BC RID: 956
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_X509CertificateImpl_0;

		// Token: 0x040003BD RID: 957
		private static readonly IntPtr NativeMethodInfoPtr_GetRawCertData_Protected_Virtual_Il2CppStructArray_1_Byte_0;

		// Token: 0x040003BE RID: 958
		private static readonly IntPtr NativeMethodInfoPtr_get_IntermediateCertificates_Internal_Virtual_get_X509CertificateImplCollection_0;

		// Token: 0x040003BF RID: 959
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x040003C0 RID: 960
		private static readonly IntPtr NativeMethodInfoPtr_get_HasPrivateKey_Public_Virtual_get_Boolean_0;

		// Token: 0x040003C1 RID: 961
		private static readonly IntPtr NativeMethodInfoPtr_get_PrivateKey_Public_Virtual_get_AsymmetricAlgorithm_0;

		// Token: 0x040003C2 RID: 962
		private static readonly IntPtr NativeMethodInfoPtr_set_PrivateKey_Public_Virtual_set_Void_AsymmetricAlgorithm_0;

		// Token: 0x040003C3 RID: 963
		private static readonly IntPtr NativeMethodInfoPtr_GetRSAPrivateKey_Public_Virtual_RSA_0;

		// Token: 0x040003C4 RID: 964
		private static readonly IntPtr NativeMethodInfoPtr_GetDSAPrivateKey_Public_Virtual_DSA_0;

		// Token: 0x040003C5 RID: 965
		private static readonly IntPtr NativeMethodInfoPtr_Import_Private_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x040003C6 RID: 966
		private static readonly IntPtr NativeMethodInfoPtr_ImportPkcs12_Private_Void_Il2CppStructArray_1_Byte_SafePasswordHandle_0;

		// Token: 0x040003C7 RID: 967
		private static readonly IntPtr NativeMethodInfoPtr_ImportAuthenticode_Private_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x040003C8 RID: 968
		private static readonly IntPtr NativeMethodInfoPtr_Verify_Public_Virtual_Boolean_X509Certificate2_0;
	}
}
