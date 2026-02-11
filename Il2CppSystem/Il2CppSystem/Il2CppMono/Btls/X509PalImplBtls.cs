using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;
using Il2CppMono.Security.Interface;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Btls
{
	// Token: 0x0200004E RID: 78
	public class X509PalImplBtls : X509PalImpl
	{
		// Token: 0x06000497 RID: 1175 RVA: 0x0002DB84 File Offset: 0x0002BD84
		// Note: this type is marked as 'beforefieldinit'.
		static X509PalImplBtls()
		{
			Il2CppClassPointerStore<X509PalImplBtls>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Btls", "X509PalImplBtls");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509PalImplBtls>.NativeClassPtr);
			X509PalImplBtls.NativeFieldInfoPtr__Provider_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509PalImplBtls>.NativeClassPtr, "<Provider>k__BackingField");
			X509PalImplBtls.NativeMethodInfoPtr__ctor_Public_Void_MonoTlsProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509PalImplBtls>.NativeClassPtr, 100664124);
			X509PalImplBtls.NativeMethodInfoPtr_get_Provider_Private_get_MonoBtlsProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509PalImplBtls>.NativeClassPtr, 100664125);
			X509PalImplBtls.NativeMethodInfoPtr_Import_Public_Virtual_X509CertificateImpl_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509PalImplBtls>.NativeClassPtr, 100664126);
			X509PalImplBtls.NativeMethodInfoPtr_Import_Public_Virtual_X509Certificate2Impl_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509PalImplBtls>.NativeClassPtr, 100664127);
			X509PalImplBtls.NativeMethodInfoPtr_Import_Public_Virtual_X509Certificate2Impl_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509PalImplBtls>.NativeClassPtr, 100664128);
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x0002DC2C File Offset: 0x0002BE2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 432998, RefRangeEnd = 432999, XrefRangeStart = 432983, XrefRangeEnd = 432998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509PalImplBtls(MonoTlsProvider provider)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509PalImplBtls>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509PalImplBtls.NativeMethodInfoPtr__ctor_Public_Void_MonoTlsProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x0002DC78 File Offset: 0x0002BE78
		public unsafe MonoBtlsProvider Provider
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509PalImplBtls.NativeMethodInfoPtr_get_Provider_Private_get_MonoBtlsProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsProvider>(intPtr3) : null;
			}
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x0002DCB8 File Offset: 0x0002BEB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432999, XrefRangeEnd = 433000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override X509CertificateImpl Import(Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509PalImplBtls.NativeMethodInfoPtr_Import_Public_Virtual_X509CertificateImpl_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr3) : null;
			}
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x0002DD14 File Offset: 0x0002BF14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 433000, XrefRangeEnd = 433002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509PalImplBtls.NativeMethodInfoPtr_Import_Public_Virtual_X509Certificate2Impl_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate2Impl>(intPtr3) : null;
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x0002DD90 File Offset: 0x0002BF90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 433002, XrefRangeEnd = 433004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override X509Certificate2Impl Import(X509Certificate cert)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cert);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509PalImplBtls.NativeMethodInfoPtr_Import_Public_Virtual_X509Certificate2Impl_X509Certificate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate2Impl>(intPtr3) : null;
			}
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00003724 File Offset: 0x00001924
		public X509PalImplBtls(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x0002DDEC File Offset: 0x0002BFEC
		// (set) Token: 0x0600049F RID: 1183 RVA: 0x0000372D File Offset: 0x0000192D
		public unsafe MonoBtlsProvider _Provider_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509PalImplBtls.NativeFieldInfoPtr__Provider_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoBtlsProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509PalImplBtls.NativeFieldInfoPtr__Provider_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeFieldInfoPtr__Provider_k__BackingField;

		// Token: 0x040003DD RID: 989
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MonoTlsProvider_0;

		// Token: 0x040003DE RID: 990
		private static readonly IntPtr NativeMethodInfoPtr_get_Provider_Private_get_MonoBtlsProvider_0;

		// Token: 0x040003DF RID: 991
		private static readonly IntPtr NativeMethodInfoPtr_Import_Public_Virtual_X509CertificateImpl_Il2CppStructArray_1_Byte_0;

		// Token: 0x040003E0 RID: 992
		private static readonly IntPtr NativeMethodInfoPtr_Import_Public_Virtual_X509Certificate2Impl_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_0;

		// Token: 0x040003E1 RID: 993
		private static readonly IntPtr NativeMethodInfoPtr_Import_Public_Virtual_X509Certificate2Impl_X509Certificate_0;
	}
}
