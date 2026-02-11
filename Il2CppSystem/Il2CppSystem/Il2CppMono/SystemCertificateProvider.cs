using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;
using Il2CppMono.Security.Interface;
using Il2CppSystem;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono
{
	// Token: 0x02000002 RID: 2
	public class SystemCertificateProvider : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x0001A78C File Offset: 0x0001898C
		// Note: this type is marked as 'beforefieldinit'.
		static SystemCertificateProvider()
		{
			Il2CppClassPointerStore<SystemCertificateProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono", "SystemCertificateProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemCertificateProvider>.NativeClassPtr);
			SystemCertificateProvider.NativeFieldInfoPtr_provider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemCertificateProvider>.NativeClassPtr, "provider");
			SystemCertificateProvider.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemCertificateProvider>.NativeClassPtr, "initialized");
			SystemCertificateProvider.NativeFieldInfoPtr_x509pal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemCertificateProvider>.NativeClassPtr, "x509pal");
			SystemCertificateProvider.NativeFieldInfoPtr_syncRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemCertificateProvider>.NativeClassPtr, "syncRoot");
			SystemCertificateProvider.NativeMethodInfoPtr_GetX509Pal_Private_Static_X509PalImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemCertificateProvider>.NativeClassPtr, 100663297);
			SystemCertificateProvider.NativeMethodInfoPtr_EnsureInitialized_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemCertificateProvider>.NativeClassPtr, 100663298);
			SystemCertificateProvider.NativeMethodInfoPtr_get_X509Pal_Public_get_X509PalImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemCertificateProvider>.NativeClassPtr, 100663299);
			SystemCertificateProvider.NativeMethodInfoPtr_Import_Public_Virtual_Final_New_X509CertificateImpl_Il2CppStructArray_1_Byte_CertificateImportFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemCertificateProvider>.NativeClassPtr, 100663300);
			SystemCertificateProvider.NativeMethodInfoPtr_Mono_ISystemCertificateProvider_Import_Private_Virtual_Final_New_X509CertificateImpl_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_CertificateImportFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemCertificateProvider>.NativeClassPtr, 100663301);
			SystemCertificateProvider.NativeMethodInfoPtr_Import_Public_X509Certificate2Impl_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_CertificateImportFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemCertificateProvider>.NativeClassPtr, 100663302);
			SystemCertificateProvider.NativeMethodInfoPtr_Mono_ISystemCertificateProvider_Import_Private_Virtual_Final_New_X509CertificateImpl_X509Certificate_CertificateImportFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemCertificateProvider>.NativeClassPtr, 100663303);
			SystemCertificateProvider.NativeMethodInfoPtr_Import_Public_X509Certificate2Impl_X509Certificate_CertificateImportFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemCertificateProvider>.NativeClassPtr, 100663304);
			SystemCertificateProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemCertificateProvider>.NativeClassPtr, 100663305);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0001A8C0 File Offset: 0x00018AC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 426662, RefRangeEnd = 426663, XrefRangeStart = 426639, XrefRangeEnd = 426662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static X509PalImpl GetX509Pal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemCertificateProvider.NativeMethodInfoPtr_GetX509Pal_Private_Static_X509PalImpl_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509PalImpl>(intPtr3) : null;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0001A8F4 File Offset: 0x00018AF4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 426687, RefRangeEnd = 426690, XrefRangeStart = 426663, XrefRangeEnd = 426687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnsureInitialized()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemCertificateProvider.NativeMethodInfoPtr_EnsureInitialized_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000004 RID: 4 RVA: 0x0001A91C File Offset: 0x00018B1C
		public unsafe X509PalImpl X509Pal
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 426695, RefRangeEnd = 426703, XrefRangeStart = 426690, XrefRangeEnd = 426695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemCertificateProvider.NativeMethodInfoPtr_get_X509Pal_Public_get_X509PalImpl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509PalImpl>(intPtr3) : null;
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0001A95C File Offset: 0x00018B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426703, XrefRangeEnd = 426706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual X509CertificateImpl Import(Il2CppStructArray<byte> data, CertificateImportFlags importFlags = CertificateImportFlags.None)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref importFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemCertificateProvider.NativeMethodInfoPtr_Import_Public_Virtual_Final_New_X509CertificateImpl_Il2CppStructArray_1_Byte_CertificateImportFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr3) : null;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0001A9BC File Offset: 0x00018BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426706, XrefRangeEnd = 426710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual X509CertificateImpl Mono_ISystemCertificateProvider_Import(Il2CppStructArray<byte> data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(password);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyStorageFlags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref importFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemCertificateProvider.NativeMethodInfoPtr_Mono_ISystemCertificateProvider_Import_Private_Virtual_Final_New_X509CertificateImpl_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_CertificateImportFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr3) : null;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0001AA3C File Offset: 0x00018C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426710, XrefRangeEnd = 426714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate2Impl Import(Il2CppStructArray<byte> data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags = CertificateImportFlags.None)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(password);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyStorageFlags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref importFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemCertificateProvider.NativeMethodInfoPtr_Import_Public_X509Certificate2Impl_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_CertificateImportFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate2Impl>(intPtr3) : null;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0001AABC File Offset: 0x00018CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426714, XrefRangeEnd = 426723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual X509CertificateImpl Mono_ISystemCertificateProvider_Import(X509Certificate cert, CertificateImportFlags importFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cert);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref importFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemCertificateProvider.NativeMethodInfoPtr_Mono_ISystemCertificateProvider_Import_Private_Virtual_Final_New_X509CertificateImpl_X509Certificate_CertificateImportFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr3) : null;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0001AB1C File Offset: 0x00018D1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 426729, RefRangeEnd = 426730, XrefRangeStart = 426723, XrefRangeEnd = 426729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate2Impl Import(X509Certificate cert, CertificateImportFlags importFlags = CertificateImportFlags.None)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cert);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref importFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemCertificateProvider.NativeMethodInfoPtr_Import_Public_X509Certificate2Impl_X509Certificate_CertificateImportFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate2Impl>(intPtr3) : null;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0001AB7C File Offset: 0x00018D7C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SystemCertificateProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SystemCertificateProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemCertificateProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
		public SystemCertificateProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000C RID: 12 RVA: 0x0001ABB8 File Offset: 0x00018DB8
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00002059 File Offset: 0x00000259
		public unsafe static MonoTlsProvider provider
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SystemCertificateProvider.NativeFieldInfoPtr_provider, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoTlsProvider>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SystemCertificateProvider.NativeFieldInfoPtr_provider, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000E RID: 14 RVA: 0x0001ABE0 File Offset: 0x00018DE0
		// (set) Token: 0x0600000F RID: 15 RVA: 0x0000206B File Offset: 0x0000026B
		public unsafe static int initialized
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SystemCertificateProvider.NativeFieldInfoPtr_initialized, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SystemCertificateProvider.NativeFieldInfoPtr_initialized, (void*)(&value));
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000010 RID: 16 RVA: 0x0001ABFC File Offset: 0x00018DFC
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002079 File Offset: 0x00000279
		public unsafe static X509PalImpl x509pal
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SystemCertificateProvider.NativeFieldInfoPtr_x509pal, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509PalImpl>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SystemCertificateProvider.NativeFieldInfoPtr_x509pal, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000012 RID: 18 RVA: 0x0001AC24 File Offset: 0x00018E24
		// (set) Token: 0x06000013 RID: 19 RVA: 0x0000208B File Offset: 0x0000028B
		public unsafe static Object syncRoot
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SystemCertificateProvider.NativeFieldInfoPtr_syncRoot, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SystemCertificateProvider.NativeFieldInfoPtr_syncRoot, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeFieldInfoPtr_provider;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeFieldInfoPtr_x509pal;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeFieldInfoPtr_syncRoot;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_GetX509Pal_Private_Static_X509PalImpl_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_EnsureInitialized_Private_Static_Void_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_get_X509Pal_Public_get_X509PalImpl_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_Import_Public_Virtual_Final_New_X509CertificateImpl_Il2CppStructArray_1_Byte_CertificateImportFlags_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_Mono_ISystemCertificateProvider_Import_Private_Virtual_Final_New_X509CertificateImpl_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_CertificateImportFlags_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_Import_Public_X509Certificate2Impl_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_CertificateImportFlags_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_Mono_ISystemCertificateProvider_Import_Private_Virtual_Final_New_X509CertificateImpl_X509Certificate_CertificateImportFlags_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_Import_Public_X509Certificate2Impl_X509Certificate_CertificateImportFlags_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
