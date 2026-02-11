using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono
{
	// Token: 0x02000007 RID: 7
	public class ISystemCertificateProvider : Il2CppObjectBase
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00025C18 File Offset: 0x00023E18
		// Note: this type is marked as 'beforefieldinit'.
		static ISystemCertificateProvider()
		{
			Il2CppClassPointerStore<ISystemCertificateProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono", "ISystemCertificateProvider");
			ISystemCertificateProvider.NativeMethodInfoPtr_Import_Public_Abstract_Virtual_New_X509CertificateImpl_Il2CppStructArray_1_Byte_CertificateImportFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISystemCertificateProvider>.NativeClassPtr, 100663380);
			ISystemCertificateProvider.NativeMethodInfoPtr_Import_Public_Abstract_Virtual_New_X509CertificateImpl_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_CertificateImportFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISystemCertificateProvider>.NativeClassPtr, 100663381);
			ISystemCertificateProvider.NativeMethodInfoPtr_Import_Public_Abstract_Virtual_New_X509CertificateImpl_X509Certificate_CertificateImportFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISystemCertificateProvider>.NativeClassPtr, 100663382);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00025C7C File Offset: 0x00023E7C
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISystemCertificateProvider.NativeMethodInfoPtr_Import_Public_Abstract_Virtual_New_X509CertificateImpl_Il2CppStructArray_1_Byte_CertificateImportFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr3) : null;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00025CE8 File Offset: 0x00023EE8
		[CallerCount(0)]
		public unsafe virtual X509CertificateImpl Import(Il2CppStructArray<byte> data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags = CertificateImportFlags.None)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISystemCertificateProvider.NativeMethodInfoPtr_Import_Public_Abstract_Virtual_New_X509CertificateImpl_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_CertificateImportFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr3) : null;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00025D74 File Offset: 0x00023F74
		[CallerCount(0)]
		public unsafe virtual X509CertificateImpl Import(X509Certificate cert, CertificateImportFlags importFlags = CertificateImportFlags.None)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISystemCertificateProvider.NativeMethodInfoPtr_Import_Public_Abstract_Virtual_New_X509CertificateImpl_X509Certificate_CertificateImportFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr3) : null;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000210A File Offset: 0x0000030A
		public ISystemCertificateProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_Import_Public_Abstract_Virtual_New_X509CertificateImpl_Il2CppStructArray_1_Byte_CertificateImportFlags_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_Import_Public_Abstract_Virtual_New_X509CertificateImpl_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_CertificateImportFlags_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_Import_Public_Abstract_Virtual_New_X509CertificateImpl_X509Certificate_CertificateImportFlags_0;
	}
}
