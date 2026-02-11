using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;
using Il2CppSystem;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono
{
	// Token: 0x02000006 RID: 6
	public class X509PalImpl : Object
	{
		// Token: 0x0600002B RID: 43 RVA: 0x0001B12C File Offset: 0x0001932C
		// Note: this type is marked as 'beforefieldinit'.
		static X509PalImpl()
		{
			Il2CppClassPointerStore<X509PalImpl>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono", "X509PalImpl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509PalImpl>.NativeClassPtr);
			X509PalImpl.NativeFieldInfoPtr_signedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509PalImpl>.NativeClassPtr, "signedData");
			X509PalImpl.NativeMethodInfoPtr_Import_Public_Abstract_Virtual_New_X509CertificateImpl_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509PalImpl>.NativeClassPtr, 100663319);
			X509PalImpl.NativeMethodInfoPtr_Import_Public_Abstract_Virtual_New_X509Certificate2Impl_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509PalImpl>.NativeClassPtr, 100663320);
			X509PalImpl.NativeMethodInfoPtr_Import_Public_Abstract_Virtual_New_X509Certificate2Impl_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509PalImpl>.NativeClassPtr, 100663321);
			X509PalImpl.NativeMethodInfoPtr_PEM_Private_Static_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509PalImpl>.NativeClassPtr, 100663322);
			X509PalImpl.NativeMethodInfoPtr_ConvertData_Protected_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509PalImpl>.NativeClassPtr, 100663323);
			X509PalImpl.NativeMethodInfoPtr_ImportFallback_Internal_X509Certificate2Impl_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509PalImpl>.NativeClassPtr, 100663324);
			X509PalImpl.NativeMethodInfoPtr_ImportFallback_Internal_X509Certificate2Impl_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509PalImpl>.NativeClassPtr, 100663325);
			X509PalImpl.NativeMethodInfoPtr_get_SupportsLegacyBasicConstraintsExtension_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509PalImpl>.NativeClassPtr, 100663326);
			X509PalImpl.NativeMethodInfoPtr_GetCertContentType_Public_X509ContentType_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509PalImpl>.NativeClassPtr, 100663327);
			X509PalImpl.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509PalImpl>.NativeClassPtr, 100663328);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0001B238 File Offset: 0x00019438
		[CallerCount(0)]
		public unsafe virtual X509CertificateImpl Import(Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509PalImpl.NativeMethodInfoPtr_Import_Public_Abstract_Virtual_New_X509CertificateImpl_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr3) : null;
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0001B294 File Offset: 0x00019494
		[CallerCount(0)]
		public unsafe virtual X509Certificate2Impl Import(Il2CppStructArray<byte> data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(password);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyStorageFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509PalImpl.NativeMethodInfoPtr_Import_Public_Abstract_Virtual_New_X509Certificate2Impl_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate2Impl>(intPtr3) : null;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0001B310 File Offset: 0x00019510
		[CallerCount(0)]
		public unsafe virtual X509Certificate2Impl Import(X509Certificate cert)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cert);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509PalImpl.NativeMethodInfoPtr_Import_Public_Abstract_Virtual_New_X509Certificate2Impl_X509Certificate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate2Impl>(intPtr3) : null;
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0001B36C File Offset: 0x0001956C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426804, XrefRangeEnd = 426829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> PEM(string type, Il2CppStructArray<byte> data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509PalImpl.NativeMethodInfoPtr_PEM_Private_Static_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0001B3C4 File Offset: 0x000195C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 426848, RefRangeEnd = 426849, XrefRangeStart = 426829, XrefRangeEnd = 426848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> ConvertData(Il2CppStructArray<byte> data)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509PalImpl.NativeMethodInfoPtr_ConvertData_Protected_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0001B408 File Offset: 0x00019608
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 426867, RefRangeEnd = 426870, XrefRangeStart = 426849, XrefRangeEnd = 426867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate2Impl ImportFallback(Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509PalImpl.NativeMethodInfoPtr_ImportFallback_Internal_X509Certificate2Impl_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate2Impl>(intPtr3) : null;
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0001B458 File Offset: 0x00019658
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 426874, RefRangeEnd = 426877, XrefRangeStart = 426870, XrefRangeEnd = 426874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate2Impl ImportFallback(Il2CppStructArray<byte> data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(password);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyStorageFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509PalImpl.NativeMethodInfoPtr_ImportFallback_Internal_X509Certificate2Impl_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate2Impl>(intPtr3) : null;
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000033 RID: 51 RVA: 0x0001B4C8 File Offset: 0x000196C8
		public unsafe bool SupportsLegacyBasicConstraintsExtension
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509PalImpl.NativeMethodInfoPtr_get_SupportsLegacyBasicConstraintsExtension_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0001B504 File Offset: 0x00019704
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 426888, RefRangeEnd = 426890, XrefRangeStart = 426877, XrefRangeEnd = 426888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509ContentType GetCertContentType(Il2CppStructArray<byte> rawData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509PalImpl.NativeMethodInfoPtr_GetCertContentType_Public_X509ContentType_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0001B554 File Offset: 0x00019754
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509PalImpl()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509PalImpl>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509PalImpl.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002134 File Offset: 0x00000334
		public X509PalImpl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000037 RID: 55 RVA: 0x0001B590 File Offset: 0x00019790
		// (set) Token: 0x06000038 RID: 56 RVA: 0x0000213D File Offset: 0x0000033D
		public unsafe static Il2CppStructArray<byte> signedData
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X509PalImpl.NativeFieldInfoPtr_signedData, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509PalImpl.NativeFieldInfoPtr_signedData, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeFieldInfoPtr_signedData;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_Import_Public_Abstract_Virtual_New_X509CertificateImpl_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_Import_Public_Abstract_Virtual_New_X509Certificate2Impl_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_Import_Public_Abstract_Virtual_New_X509Certificate2Impl_X509Certificate_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_PEM_Private_Static_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_ConvertData_Protected_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_ImportFallback_Internal_X509Certificate2Impl_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_ImportFallback_Internal_X509Certificate2Impl_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportsLegacyBasicConstraintsExtension_Public_get_Boolean_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_GetCertContentType_Public_X509ContentType_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
