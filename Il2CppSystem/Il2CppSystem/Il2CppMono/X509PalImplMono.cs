using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono
{
	// Token: 0x02000005 RID: 5
	public class X509PalImplMono : X509PalImpl
	{
		// Token: 0x06000025 RID: 37 RVA: 0x0001AF3C File Offset: 0x0001913C
		// Note: this type is marked as 'beforefieldinit'.
		static X509PalImplMono()
		{
			Il2CppClassPointerStore<X509PalImplMono>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono", "X509PalImplMono");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509PalImplMono>.NativeClassPtr);
			X509PalImplMono.NativeMethodInfoPtr_Import_Public_Virtual_X509CertificateImpl_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509PalImplMono>.NativeClassPtr, 100663315);
			X509PalImplMono.NativeMethodInfoPtr_Import_Public_Virtual_X509Certificate2Impl_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509PalImplMono>.NativeClassPtr, 100663316);
			X509PalImplMono.NativeMethodInfoPtr_Import_Public_Virtual_X509Certificate2Impl_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509PalImplMono>.NativeClassPtr, 100663317);
			X509PalImplMono.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509PalImplMono>.NativeClassPtr, 100663318);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0001AFBC File Offset: 0x000191BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426798, XrefRangeEnd = 426799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override X509CertificateImpl Import(Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509PalImplMono.NativeMethodInfoPtr_Import_Public_Virtual_X509CertificateImpl_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr3) : null;
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0001B018 File Offset: 0x00019218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426799, XrefRangeEnd = 426800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override X509Certificate2Impl Import(Il2CppStructArray<byte> data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509PalImplMono.NativeMethodInfoPtr_Import_Public_Virtual_X509Certificate2Impl_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate2Impl>(intPtr3) : null;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0001B094 File Offset: 0x00019294
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override X509Certificate2Impl Import(X509Certificate cert)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cert);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509PalImplMono.NativeMethodInfoPtr_Import_Public_Virtual_X509Certificate2Impl_X509Certificate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate2Impl>(intPtr3) : null;
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0001B0F0 File Offset: 0x000192F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426800, XrefRangeEnd = 426804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509PalImplMono()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509PalImplMono>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509PalImplMono.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000212B File Offset: 0x0000032B
		public X509PalImplMono(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_Import_Public_Virtual_X509CertificateImpl_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_Import_Public_Virtual_X509Certificate2Impl_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_Import_Public_Virtual_X509Certificate2Impl_X509Certificate_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
