using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Net.Security;
using Il2CppMono.Security.Interface;
using Il2CppSystem;
using Il2CppSystem.IO;
using Il2CppSystem.Net.Security;
using Il2CppSystem.Security.Authentication;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Unity
{
	// Token: 0x0200000D RID: 13
	public class UnityTlsProvider : MobileTlsProvider
	{
		// Token: 0x0600008E RID: 142 RVA: 0x0001C9E4 File Offset: 0x0001ABE4
		// Note: this type is marked as 'beforefieldinit'.
		static UnityTlsProvider()
		{
			Il2CppClassPointerStore<UnityTlsProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Unity", "UnityTlsProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTlsProvider>.NativeClassPtr);
			UnityTlsProvider.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsProvider>.NativeClassPtr, 100663440);
			UnityTlsProvider.NativeMethodInfoPtr_get_ID_Public_Virtual_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsProvider>.NativeClassPtr, 100663441);
			UnityTlsProvider.NativeMethodInfoPtr_get_SupportsSslStream_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsProvider>.NativeClassPtr, 100663442);
			UnityTlsProvider.NativeMethodInfoPtr_get_SupportsMonoExtensions_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsProvider>.NativeClassPtr, 100663443);
			UnityTlsProvider.NativeMethodInfoPtr_get_SupportsConnectionInfo_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsProvider>.NativeClassPtr, 100663444);
			UnityTlsProvider.NativeMethodInfoPtr_get_SupportsCleanShutdown_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsProvider>.NativeClassPtr, 100663445);
			UnityTlsProvider.NativeMethodInfoPtr_get_SupportedProtocols_Public_Virtual_get_SslProtocols_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsProvider>.NativeClassPtr, 100663446);
			UnityTlsProvider.NativeMethodInfoPtr_CreateSslStream_Internal_Virtual_MobileAuthenticatedStream_SslStream_Stream_Boolean_MonoTlsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsProvider>.NativeClassPtr, 100663447);
			UnityTlsProvider.NativeMethodInfoPtr_x509verify_callback_Private_Static_unitytls_x509verify_result_ptr_Void_unitytls_x509_ref_unitytls_x509verify_result_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsProvider>.NativeClassPtr, 100663448);
			UnityTlsProvider.NativeMethodInfoPtr_ValidateCertificate_Internal_Virtual_Boolean_ChainValidationHelper_String_Boolean_X509CertificateCollection_Boolean_byref_X509Chain_byref_SslPolicyErrors_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsProvider>.NativeClassPtr, 100663449);
			UnityTlsProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsProvider>.NativeClassPtr, 100663450);
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600008F RID: 143 RVA: 0x0001CAF0 File Offset: 0x0001ACF0
		public unsafe override string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427394, XrefRangeEnd = 427396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityTlsProvider.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000090 RID: 144 RVA: 0x0001CB34 File Offset: 0x0001AD34
		public unsafe override Guid ID
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427396, XrefRangeEnd = 427400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityTlsProvider.NativeMethodInfoPtr_get_ID_Public_Virtual_get_Guid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000091 RID: 145 RVA: 0x0001CB7C File Offset: 0x0001AD7C
		public unsafe override bool SupportsSslStream
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityTlsProvider.NativeMethodInfoPtr_get_SupportsSslStream_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0001CBC4 File Offset: 0x0001ADC4
		public unsafe override bool SupportsMonoExtensions
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityTlsProvider.NativeMethodInfoPtr_get_SupportsMonoExtensions_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000093 RID: 147 RVA: 0x0001CC0C File Offset: 0x0001AE0C
		public unsafe override bool SupportsConnectionInfo
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityTlsProvider.NativeMethodInfoPtr_get_SupportsConnectionInfo_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000094 RID: 148 RVA: 0x0001CC54 File Offset: 0x0001AE54
		public unsafe override bool SupportsCleanShutdown
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityTlsProvider.NativeMethodInfoPtr_get_SupportsCleanShutdown_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000095 RID: 149 RVA: 0x0001CC9C File Offset: 0x0001AE9C
		public unsafe override SslProtocols SupportedProtocols
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityTlsProvider.NativeMethodInfoPtr_get_SupportedProtocols_Public_Virtual_get_SslProtocols_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0001CCE4 File Offset: 0x0001AEE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427400, XrefRangeEnd = 427428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityTlsProvider.NativeMethodInfoPtr_CreateSslStream_Internal_Virtual_MobileAuthenticatedStream_SslStream_Stream_Boolean_MonoTlsSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MobileAuthenticatedStream>(intPtr3) : null;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0001CD74 File Offset: 0x0001AF74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427428, XrefRangeEnd = 427429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityTls.unitytls_x509verify_result x509verify_callback(void* userData, UnityTls.unitytls_x509_ref cert, UnityTls.unitytls_x509verify_result result, UnityTls.unitytls_errorstate* errorState)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = userData;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cert;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref result;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTlsProvider.NativeMethodInfoPtr_x509verify_callback_Private_Static_unitytls_x509verify_result_ptr_Void_unitytls_x509_ref_unitytls_x509verify_result_ptr_unitytls_errorstate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0001CDDC File Offset: 0x0001AFDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427429, XrefRangeEnd = 427496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityTlsProvider.NativeMethodInfoPtr_ValidateCertificate_Internal_Virtual_Boolean_ChainValidationHelper_String_Boolean_X509CertificateCollection_Boolean_byref_X509Chain_byref_SslPolicyErrors_byref_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			chain = ((intPtr4 == 0) ? null : new X509Chain(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0001CEC0 File Offset: 0x0001B0C0
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityTlsProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTlsProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTlsProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000023C3 File Offset: 0x000005C3
		public UnityTlsProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_get_ID_Public_Virtual_get_Guid_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportsSslStream_Public_Virtual_get_Boolean_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportsMonoExtensions_Public_Virtual_get_Boolean_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportsConnectionInfo_Public_Virtual_get_Boolean_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportsCleanShutdown_Internal_Virtual_get_Boolean_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportedProtocols_Public_Virtual_get_SslProtocols_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_CreateSslStream_Internal_Virtual_MobileAuthenticatedStream_SslStream_Stream_Boolean_MonoTlsSettings_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_x509verify_callback_Private_Static_unitytls_x509verify_result_ptr_Void_unitytls_x509_ref_unitytls_x509verify_result_ptr_unitytls_errorstate_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_ValidateCertificate_Internal_Virtual_Boolean_ChainValidationHelper_String_Boolean_X509CertificateCollection_Boolean_byref_X509Chain_byref_SslPolicyErrors_byref_Int32_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
