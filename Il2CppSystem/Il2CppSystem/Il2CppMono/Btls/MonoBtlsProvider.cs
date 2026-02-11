using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;
using Il2CppMono.Net.Security;
using Il2CppMono.Security.Interface;
using Il2CppSystem;
using Il2CppSystem.IO;
using Il2CppSystem.Net.Security;
using Il2CppSystem.Security.Authentication;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Btls
{
	// Token: 0x02000031 RID: 49
	public class MonoBtlsProvider : MobileTlsProvider
	{
		// Token: 0x060002F2 RID: 754 RVA: 0x000267D8 File Offset: 0x000249D8
		// Note: this type is marked as 'beforefieldinit'.
		static MonoBtlsProvider()
		{
			Il2CppClassPointerStore<MonoBtlsProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Btls", "MonoBtlsProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsProvider>.NativeClassPtr);
			MonoBtlsProvider.NativeMethodInfoPtr_get_ID_Public_Virtual_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsProvider>.NativeClassPtr, 100663816);
			MonoBtlsProvider.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsProvider>.NativeClassPtr, 100663817);
			MonoBtlsProvider.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsProvider>.NativeClassPtr, 100663818);
			MonoBtlsProvider.NativeMethodInfoPtr_get_SupportsSslStream_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsProvider>.NativeClassPtr, 100663819);
			MonoBtlsProvider.NativeMethodInfoPtr_get_SupportsMonoExtensions_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsProvider>.NativeClassPtr, 100663820);
			MonoBtlsProvider.NativeMethodInfoPtr_get_SupportsConnectionInfo_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsProvider>.NativeClassPtr, 100663821);
			MonoBtlsProvider.NativeMethodInfoPtr_get_SupportsCleanShutdown_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsProvider>.NativeClassPtr, 100663822);
			MonoBtlsProvider.NativeMethodInfoPtr_get_SupportedProtocols_Public_Virtual_get_SslProtocols_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsProvider>.NativeClassPtr, 100663823);
			MonoBtlsProvider.NativeMethodInfoPtr_CreateSslStream_Internal_Virtual_MobileAuthenticatedStream_SslStream_Stream_Boolean_MonoTlsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsProvider>.NativeClassPtr, 100663824);
			MonoBtlsProvider.NativeMethodInfoPtr_GetNativeCertificate_Internal_X509Certificate2Impl_Il2CppStructArray_1_Byte_String_X509KeyStorageFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsProvider>.NativeClassPtr, 100663825);
			MonoBtlsProvider.NativeMethodInfoPtr_GetNativeCertificate_Internal_X509Certificate2Impl_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsProvider>.NativeClassPtr, 100663826);
			MonoBtlsProvider.NativeMethodInfoPtr_GetNativeCertificate_Internal_X509Certificate2Impl_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsProvider>.NativeClassPtr, 100663827);
			MonoBtlsProvider.NativeMethodInfoPtr_GetVerifyParam_Internal_Static_MonoBtlsX509VerifyParam_MonoTlsSettings_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsProvider>.NativeClassPtr, 100663828);
			MonoBtlsProvider.NativeMethodInfoPtr_ValidateCertificate_Internal_Virtual_Boolean_ChainValidationHelper_String_Boolean_X509CertificateCollection_Boolean_byref_X509Chain_byref_SslPolicyErrors_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsProvider>.NativeClassPtr, 100663829);
			MonoBtlsProvider.NativeMethodInfoPtr_ValidateCertificate_Internal_Static_Boolean_MonoBtlsX509Chain_MonoBtlsX509VerifyParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsProvider>.NativeClassPtr, 100663830);
			MonoBtlsProvider.NativeMethodInfoPtr_CheckValidationResult_Private_Void_ChainValidationHelper_String_Boolean_X509CertificateCollection_Boolean_X509Chain_MonoBtlsX509StoreCtx_Boolean_byref_SslPolicyErrors_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsProvider>.NativeClassPtr, 100663831);
			MonoBtlsProvider.NativeMethodInfoPtr_MapVerifyErrorToChainStatus_Internal_Static_X509ChainStatusFlags_MonoBtlsX509Error_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsProvider>.NativeClassPtr, 100663832);
			MonoBtlsProvider.NativeMethodInfoPtr_SetupCertificateStore_Internal_Static_Void_MonoBtlsX509Store_MonoTlsSettings_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsProvider>.NativeClassPtr, 100663833);
			MonoBtlsProvider.NativeMethodInfoPtr_SetupDefaultCertificateStore_Private_Static_Void_MonoBtlsX509Store_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsProvider>.NativeClassPtr, 100663834);
			MonoBtlsProvider.NativeMethodInfoPtr_AddUserStore_Private_Static_Void_MonoBtlsX509Store_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsProvider>.NativeClassPtr, 100663835);
			MonoBtlsProvider.NativeMethodInfoPtr_AddMachineStore_Private_Static_Void_MonoBtlsX509Store_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsProvider>.NativeClassPtr, 100663836);
			MonoBtlsProvider.NativeMethodInfoPtr_AddTrustedRoots_Private_Static_Void_MonoBtlsX509Store_MonoTlsSettings_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsProvider>.NativeClassPtr, 100663837);
			MonoBtlsProvider.NativeMethodInfoPtr_CreateCertificate_Public_Static_X509Certificate2_MonoBtlsX509_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsProvider>.NativeClassPtr, 100663838);
			MonoBtlsProvider.NativeMethodInfoPtr_GetManagedChain_Public_Static_X509Chain_MonoBtlsX509Chain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsProvider>.NativeClassPtr, 100663839);
			MonoBtlsProvider.NativeMethodInfoPtr_GetBtlsCertificate_Public_Static_MonoBtlsX509_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsProvider>.NativeClassPtr, 100663840);
			MonoBtlsProvider.NativeMethodInfoPtr_GetNativeChain_Public_Static_MonoBtlsX509Chain_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsProvider>.NativeClassPtr, 100663841);
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x00026A10 File Offset: 0x00024C10
		public unsafe override Guid ID
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430359, XrefRangeEnd = 430363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsProvider.NativeMethodInfoPtr_get_ID_Public_Virtual_get_Guid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x00026A58 File Offset: 0x00024C58
		public unsafe override string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430363, XrefRangeEnd = 430365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsProvider.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00026A9C File Offset: 0x00024C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430365, XrefRangeEnd = 430370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsProvider.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x00026AD8 File Offset: 0x00024CD8
		public unsafe override bool SupportsSslStream
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsProvider.NativeMethodInfoPtr_get_SupportsSslStream_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x00026B20 File Offset: 0x00024D20
		public unsafe override bool SupportsMonoExtensions
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsProvider.NativeMethodInfoPtr_get_SupportsMonoExtensions_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x00026B68 File Offset: 0x00024D68
		public unsafe override bool SupportsConnectionInfo
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsProvider.NativeMethodInfoPtr_get_SupportsConnectionInfo_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x00026BB0 File Offset: 0x00024DB0
		public unsafe override bool SupportsCleanShutdown
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsProvider.NativeMethodInfoPtr_get_SupportsCleanShutdown_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060002FA RID: 762 RVA: 0x00026BF8 File Offset: 0x00024DF8
		public unsafe override SslProtocols SupportedProtocols
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsProvider.NativeMethodInfoPtr_get_SupportedProtocols_Public_Virtual_get_SslProtocols_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00026C40 File Offset: 0x00024E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430370, XrefRangeEnd = 430374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sslStream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerStream);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leaveInnerStreamOpen;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsProvider.NativeMethodInfoPtr_CreateSslStream_Internal_Virtual_MobileAuthenticatedStream_SslStream_Stream_Boolean_MonoTlsSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MobileAuthenticatedStream>(intPtr3) : null;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00026CD0 File Offset: 0x00024ED0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 430388, RefRangeEnd = 430389, XrefRangeStart = 430374, XrefRangeEnd = 430388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate2Impl GetNativeCertificate(Il2CppStructArray<byte> data, string password, X509KeyStorageFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsProvider.NativeMethodInfoPtr_GetNativeCertificate_Internal_X509Certificate2Impl_Il2CppStructArray_1_Byte_String_X509KeyStorageFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate2Impl>(intPtr3) : null;
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00026D40 File Offset: 0x00024F40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 430394, RefRangeEnd = 430395, XrefRangeStart = 430389, XrefRangeEnd = 430394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate2Impl GetNativeCertificate(X509Certificate certificate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsProvider.NativeMethodInfoPtr_GetNativeCertificate_Internal_X509Certificate2Impl_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate2Impl>(intPtr3) : null;
			}
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00026D90 File Offset: 0x00024F90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 430399, RefRangeEnd = 430400, XrefRangeStart = 430395, XrefRangeEnd = 430399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate2Impl GetNativeCertificate(Il2CppStructArray<byte> data, SafePasswordHandle password, X509KeyStorageFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(password);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsProvider.NativeMethodInfoPtr_GetNativeCertificate_Internal_X509Certificate2Impl_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate2Impl>(intPtr3) : null;
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00026E00 File Offset: 0x00025000
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 430405, RefRangeEnd = 430406, XrefRangeStart = 430400, XrefRangeEnd = 430405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoBtlsX509VerifyParam GetVerifyParam(MonoTlsSettings settings, string targetHost, bool serverMode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetHost);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref serverMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsProvider.NativeMethodInfoPtr_GetVerifyParam_Internal_Static_MonoBtlsX509VerifyParam_MonoTlsSettings_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509VerifyParam>(intPtr3) : null;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00026E64 File Offset: 0x00025064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430406, XrefRangeEnd = 430414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref SslPolicyErrors errors, ref int status11)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(validator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetHost);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref serverMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(certificates);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wantsChain;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(chain);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errors;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &status11;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsProvider.NativeMethodInfoPtr_ValidateCertificate_Internal_Virtual_Boolean_ChainValidationHelper_String_Boolean_X509CertificateCollection_Boolean_byref_X509Chain_byref_SslPolicyErrors_byref_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			chain = ((intPtr4 == 0) ? null : new X509Chain(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00026F48 File Offset: 0x00025148
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 430486, RefRangeEnd = 430487, XrefRangeStart = 430414, XrefRangeEnd = 430486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ValidateCertificate(MonoBtlsX509Chain chain, MonoBtlsX509VerifyParam param)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chain);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(param);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsProvider.NativeMethodInfoPtr_ValidateCertificate_Internal_Static_Boolean_MonoBtlsX509Chain_MonoBtlsX509VerifyParam_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00026F9C File Offset: 0x0002519C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430487, XrefRangeEnd = 430490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckValidationResult(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, X509Chain chain, MonoBtlsX509StoreCtx storeCtx, bool success, ref SslPolicyErrors errors, ref int status11)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(validator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetHost);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref serverMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(certificates);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wantsChain;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chain);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(storeCtx);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref success;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errors;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &status11;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsProvider.NativeMethodInfoPtr_CheckValidationResult_Private_Void_ChainValidationHelper_String_Boolean_X509CertificateCollection_Boolean_X509Chain_MonoBtlsX509StoreCtx_Boolean_byref_SslPolicyErrors_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00027074 File Offset: 0x00025274
		[CallerCount(0)]
		public unsafe static X509ChainStatusFlags MapVerifyErrorToChainStatus(MonoBtlsX509Error code)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsProvider.NativeMethodInfoPtr_MapVerifyErrorToChainStatus_Internal_Static_X509ChainStatusFlags_MonoBtlsX509Error_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000304 RID: 772 RVA: 0x000270B4 File Offset: 0x000252B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430490, XrefRangeEnd = 430534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetupCertificateStore(MonoBtlsX509Store store, MonoTlsSettings settings, bool server)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(store);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref server;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsProvider.NativeMethodInfoPtr_SetupCertificateStore_Internal_Static_Void_MonoBtlsX509Store_MonoTlsSettings_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000305 RID: 773 RVA: 0x0002710C File Offset: 0x0002530C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430534, XrefRangeEnd = 430540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetupDefaultCertificateStore(MonoBtlsX509Store store)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(store);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsProvider.NativeMethodInfoPtr_SetupDefaultCertificateStore_Private_Static_Void_MonoBtlsX509Store_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00027144 File Offset: 0x00025344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430540, XrefRangeEnd = 430543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddUserStore(MonoBtlsX509Store store)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(store);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsProvider.NativeMethodInfoPtr_AddUserStore_Private_Static_Void_MonoBtlsX509Store_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0002717C File Offset: 0x0002537C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430543, XrefRangeEnd = 430546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddMachineStore(MonoBtlsX509Store store)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(store);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsProvider.NativeMethodInfoPtr_AddMachineStore_Private_Static_Void_MonoBtlsX509Store_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000308 RID: 776 RVA: 0x000271B4 File Offset: 0x000253B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430546, XrefRangeEnd = 430547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddTrustedRoots(MonoBtlsX509Store store, MonoTlsSettings settings, bool server)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(store);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref server;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsProvider.NativeMethodInfoPtr_AddTrustedRoots_Private_Static_Void_MonoBtlsX509Store_MonoTlsSettings_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0002720C File Offset: 0x0002540C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 430561, RefRangeEnd = 430562, XrefRangeStart = 430547, XrefRangeEnd = 430561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static X509Certificate2 CreateCertificate(MonoBtlsX509 x509)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x509);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsProvider.NativeMethodInfoPtr_CreateCertificate_Public_Static_X509Certificate2_MonoBtlsX509_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate2>(intPtr3) : null;
			}
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00027250 File Offset: 0x00025450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430562, XrefRangeEnd = 430570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static X509Chain GetManagedChain(MonoBtlsX509Chain chain)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chain);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsProvider.NativeMethodInfoPtr_GetManagedChain_Public_Static_X509Chain_MonoBtlsX509Chain_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Chain>(intPtr3) : null;
			}
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00027294 File Offset: 0x00025494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430570, XrefRangeEnd = 430577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoBtlsX509 GetBtlsCertificate(X509Certificate certificate)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsProvider.NativeMethodInfoPtr_GetBtlsCertificate_Public_Static_MonoBtlsX509_X509Certificate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509>(intPtr3) : null;
			}
		}

		// Token: 0x0600030C RID: 780 RVA: 0x000272D8 File Offset: 0x000254D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430577, XrefRangeEnd = 430605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoBtlsX509Chain GetNativeChain(X509CertificateCollection certificates)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificates);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsProvider.NativeMethodInfoPtr_GetNativeChain_Public_Static_MonoBtlsX509Chain_X509CertificateCollection_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509Chain>(intPtr3) : null;
			}
		}

		// Token: 0x0600030D RID: 781 RVA: 0x000030B4 File Offset: 0x000012B4
		public MonoBtlsProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeMethodInfoPtr_get_ID_Public_Virtual_get_Guid_0;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportsSslStream_Public_Virtual_get_Boolean_0;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportsMonoExtensions_Public_Virtual_get_Boolean_0;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportsConnectionInfo_Public_Virtual_get_Boolean_0;

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportsCleanShutdown_Internal_Virtual_get_Boolean_0;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportedProtocols_Public_Virtual_get_SslProtocols_0;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeMethodInfoPtr_CreateSslStream_Internal_Virtual_MobileAuthenticatedStream_SslStream_Stream_Boolean_MonoTlsSettings_0;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeMethodInfoPtr_GetNativeCertificate_Internal_X509Certificate2Impl_Il2CppStructArray_1_Byte_String_X509KeyStorageFlags_0;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeMethodInfoPtr_GetNativeCertificate_Internal_X509Certificate2Impl_X509Certificate_0;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeMethodInfoPtr_GetNativeCertificate_Internal_X509Certificate2Impl_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_0;

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeMethodInfoPtr_GetVerifyParam_Internal_Static_MonoBtlsX509VerifyParam_MonoTlsSettings_String_Boolean_0;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeMethodInfoPtr_ValidateCertificate_Internal_Virtual_Boolean_ChainValidationHelper_String_Boolean_X509CertificateCollection_Boolean_byref_X509Chain_byref_SslPolicyErrors_byref_Int32_0;

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeMethodInfoPtr_ValidateCertificate_Internal_Static_Boolean_MonoBtlsX509Chain_MonoBtlsX509VerifyParam_0;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeMethodInfoPtr_CheckValidationResult_Private_Void_ChainValidationHelper_String_Boolean_X509CertificateCollection_Boolean_X509Chain_MonoBtlsX509StoreCtx_Boolean_byref_SslPolicyErrors_byref_Int32_0;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeMethodInfoPtr_MapVerifyErrorToChainStatus_Internal_Static_X509ChainStatusFlags_MonoBtlsX509Error_0;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeMethodInfoPtr_SetupCertificateStore_Internal_Static_Void_MonoBtlsX509Store_MonoTlsSettings_Boolean_0;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeMethodInfoPtr_SetupDefaultCertificateStore_Private_Static_Void_MonoBtlsX509Store_0;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeMethodInfoPtr_AddUserStore_Private_Static_Void_MonoBtlsX509Store_0;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeMethodInfoPtr_AddMachineStore_Private_Static_Void_MonoBtlsX509Store_0;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeMethodInfoPtr_AddTrustedRoots_Private_Static_Void_MonoBtlsX509Store_MonoTlsSettings_Boolean_0;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeMethodInfoPtr_CreateCertificate_Public_Static_X509Certificate2_MonoBtlsX509_0;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeMethodInfoPtr_GetManagedChain_Public_Static_X509Chain_MonoBtlsX509Chain_0;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeMethodInfoPtr_GetBtlsCertificate_Public_Static_MonoBtlsX509_X509Certificate_0;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeMethodInfoPtr_GetNativeChain_Public_Static_MonoBtlsX509Chain_X509CertificateCollection_0;
	}
}
