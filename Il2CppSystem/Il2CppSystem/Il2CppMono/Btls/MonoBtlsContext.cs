using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Net.Security;
using Il2CppMono.Security.Interface;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Btls
{
	// Token: 0x0200002B RID: 43
	public class MonoBtlsContext : MobileTlsContext
	{
		// Token: 0x06000277 RID: 631 RVA: 0x000246C8 File Offset: 0x000228C8
		// Note: this type is marked as 'beforefieldinit'.
		static MonoBtlsContext()
		{
			Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Btls", "MonoBtlsContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr);
			MonoBtlsContext.NativeFieldInfoPtr_remoteCertificate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr, "remoteCertificate");
			MonoBtlsContext.NativeFieldInfoPtr_clientCertificate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr, "clientCertificate");
			MonoBtlsContext.NativeFieldInfoPtr_nativeServerCertificate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr, "nativeServerCertificate");
			MonoBtlsContext.NativeFieldInfoPtr_nativeClientCertificate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr, "nativeClientCertificate");
			MonoBtlsContext.NativeFieldInfoPtr_ctx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr, "ctx");
			MonoBtlsContext.NativeFieldInfoPtr_ssl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr, "ssl");
			MonoBtlsContext.NativeFieldInfoPtr_bio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr, "bio");
			MonoBtlsContext.NativeFieldInfoPtr_errbio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr, "errbio");
			MonoBtlsContext.NativeFieldInfoPtr_connectionInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr, "connectionInfo");
			MonoBtlsContext.NativeFieldInfoPtr_certificateValidated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr, "certificateValidated");
			MonoBtlsContext.NativeFieldInfoPtr_isAuthenticated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr, "isAuthenticated");
			MonoBtlsContext.NativeFieldInfoPtr_connected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr, "connected");
			MonoBtlsContext.NativeMethodInfoPtr__ctor_Public_Void_MobileAuthenticatedStream_MonoSslAuthenticationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr, 100663730);
			MonoBtlsContext.NativeMethodInfoPtr_GetPrivateCertificate_Private_Static_X509CertificateImplBtls_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr, 100663731);
			MonoBtlsContext.NativeMethodInfoPtr_VerifyCallback_Private_Int32_MonoBtlsX509StoreCtx_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr, 100663732);
			MonoBtlsContext.NativeMethodInfoPtr_SelectCallback_Private_Int32_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr, 100663733);
			MonoBtlsContext.NativeMethodInfoPtr_ServerNameCallback_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr, 100663734);
			MonoBtlsContext.NativeMethodInfoPtr_StartHandshake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr, 100663735);
			MonoBtlsContext.NativeMethodInfoPtr_SetPrivateCertificate_Private_Void_X509CertificateImplBtls_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr, 100663736);
			MonoBtlsContext.NativeMethodInfoPtr_GetException_Private_Static_Exception_MonoBtlsSslError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr, 100663737);
			MonoBtlsContext.NativeMethodInfoPtr_ProcessHandshake_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr, 100663738);
			MonoBtlsContext.NativeMethodInfoPtr_DoProcessHandshake_Private_MonoBtlsSslError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr, 100663739);
			MonoBtlsContext.NativeMethodInfoPtr_FinishHandshake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr, 100663740);
			MonoBtlsContext.NativeMethodInfoPtr_InitializeConnection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr, 100663741);
			MonoBtlsContext.NativeMethodInfoPtr_GetPeerCertificate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr, 100663742);
			MonoBtlsContext.NativeMethodInfoPtr_InitializeSession_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr, 100663743);
			MonoBtlsContext.NativeMethodInfoPtr_GetProtocol_Private_Static_TlsProtocols_TlsProtocolCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr, 100663744);
			MonoBtlsContext.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr, 100663745);
			MonoBtlsContext.NativeMethodInfoPtr_Read_Public_Virtual_ValueTuple_2_Int32_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr, 100663746);
			MonoBtlsContext.NativeMethodInfoPtr_Write_Public_Virtual_ValueTuple_2_Int32_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr, 100663747);
			MonoBtlsContext.NativeMethodInfoPtr_Renegotiate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr, 100663748);
			MonoBtlsContext.NativeMethodInfoPtr_Shutdown_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr, 100663749);
			MonoBtlsContext.NativeMethodInfoPtr_PendingRenegotiation_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr, 100663750);
			MonoBtlsContext.NativeMethodInfoPtr_Dispose_Private_Void_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr, 100663751);
			MonoBtlsContext.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr, 100663752);
			MonoBtlsContext.NativeMethodInfoPtr_Mono_Btls_IMonoBtlsBioMono_Read_Private_Virtual_Final_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr, 100663753);
			MonoBtlsContext.NativeMethodInfoPtr_Mono_Btls_IMonoBtlsBioMono_Write_Private_Virtual_Final_New_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr, 100663754);
			MonoBtlsContext.NativeMethodInfoPtr_Mono_Btls_IMonoBtlsBioMono_Flush_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr, 100663755);
			MonoBtlsContext.NativeMethodInfoPtr_Mono_Btls_IMonoBtlsBioMono_Close_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr, 100663756);
			MonoBtlsContext.NativeMethodInfoPtr_get_IsAuthenticated_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr, 100663757);
			MonoBtlsContext.NativeMethodInfoPtr_get_LocalClientCertificate_Internal_Virtual_get_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr, 100663758);
			MonoBtlsContext.NativeMethodInfoPtr_get_RemoteCertificate_Public_Virtual_get_X509Certificate2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr, 100663759);
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00024A40 File Offset: 0x00022C40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 429538, RefRangeEnd = 429539, XrefRangeStart = 429535, XrefRangeEnd = 429538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsContext(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsContext.NativeMethodInfoPtr__ctor_Public_Void_MobileAuthenticatedStream_MonoSslAuthenticationOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00024AA0 File Offset: 0x00022CA0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 429545, RefRangeEnd = 429548, XrefRangeStart = 429539, XrefRangeEnd = 429545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static X509CertificateImplBtls GetPrivateCertificate(X509Certificate certificate)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsContext.NativeMethodInfoPtr_GetPrivateCertificate_Private_Static_X509CertificateImplBtls_X509Certificate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateImplBtls>(intPtr3) : null;
			}
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00024AE4 File Offset: 0x00022CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429548, XrefRangeEnd = 429569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int VerifyCallback(MonoBtlsX509StoreCtx storeCtx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(storeCtx);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsContext.NativeMethodInfoPtr_VerifyCallback_Private_Int32_MonoBtlsX509StoreCtx_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00024B34 File Offset: 0x00022D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429569, XrefRangeEnd = 429579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int SelectCallback(Il2CppStringArray acceptableIssuers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(acceptableIssuers);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsContext.NativeMethodInfoPtr_SelectCallback_Private_Int32_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00024B84 File Offset: 0x00022D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429579, XrefRangeEnd = 429584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ServerNameCallback()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsContext.NativeMethodInfoPtr_ServerNameCallback_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00024BC0 File Offset: 0x00022DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429584, XrefRangeEnd = 429600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartHandshake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsContext.NativeMethodInfoPtr_StartHandshake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00024BFC File Offset: 0x00022DFC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 429638, RefRangeEnd = 429641, XrefRangeStart = 429600, XrefRangeEnd = 429638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPrivateCertificate(X509CertificateImplBtls privateCert)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(privateCert);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsContext.NativeMethodInfoPtr_SetPrivateCertificate_Private_Void_X509CertificateImplBtls_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00024C40 File Offset: 0x00022E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429641, XrefRangeEnd = 429698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception GetException(MonoBtlsSslError status)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref status;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsContext.NativeMethodInfoPtr_GetException_Private_Static_Exception_MonoBtlsSslError_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00024C80 File Offset: 0x00022E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429698, XrefRangeEnd = 429707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ProcessHandshake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsContext.NativeMethodInfoPtr_ProcessHandshake_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00024CC8 File Offset: 0x00022EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429707, XrefRangeEnd = 429711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsSslError DoProcessHandshake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsContext.NativeMethodInfoPtr_DoProcessHandshake_Private_MonoBtlsSslError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00024D04 File Offset: 0x00022F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429711, XrefRangeEnd = 429712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FinishHandshake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsContext.NativeMethodInfoPtr_FinishHandshake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00024D40 File Offset: 0x00022F40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 429807, RefRangeEnd = 429808, XrefRangeStart = 429712, XrefRangeEnd = 429807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeConnection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsContext.NativeMethodInfoPtr_InitializeConnection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00024D74 File Offset: 0x00022F74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 429817, RefRangeEnd = 429819, XrefRangeStart = 429808, XrefRangeEnd = 429817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetPeerCertificate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsContext.NativeMethodInfoPtr_GetPeerCertificate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00024DA8 File Offset: 0x00022FA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 429843, RefRangeEnd = 429844, XrefRangeStart = 429819, XrefRangeEnd = 429843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeSession()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsContext.NativeMethodInfoPtr_InitializeSession_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00024DDC File Offset: 0x00022FDC
		[CallerCount(0)]
		public unsafe static TlsProtocols GetProtocol(TlsProtocolCode protocol)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref protocol;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsContext.NativeMethodInfoPtr_GetProtocol_Private_Static_TlsProtocols_TlsProtocolCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00024E1C File Offset: 0x0002301C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429844, XrefRangeEnd = 429849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsContext.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00024E58 File Offset: 0x00023058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429849, XrefRangeEnd = 429881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ValueTuple<int, bool> Read(Il2CppStructArray<byte> buffer, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsContext.NativeMethodInfoPtr_Read_Public_Virtual_ValueTuple_2_Int32_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTuple<int, bool>(intPtr);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00024EC8 File Offset: 0x000230C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429881, XrefRangeEnd = 429907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ValueTuple<int, bool> Write(Il2CppStructArray<byte> buffer, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsContext.NativeMethodInfoPtr_Write_Public_Virtual_ValueTuple_2_Int32_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTuple<int, bool>(intPtr);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00024F38 File Offset: 0x00023138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429907, XrefRangeEnd = 429912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Renegotiate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsContext.NativeMethodInfoPtr_Renegotiate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00024F74 File Offset: 0x00023174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429912, XrefRangeEnd = 429915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Shutdown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsContext.NativeMethodInfoPtr_Shutdown_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00024FB0 File Offset: 0x000231B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429915, XrefRangeEnd = 429917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool PendingRenegotiation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsContext.NativeMethodInfoPtr_PendingRenegotiation_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00024FF8 File Offset: 0x000231F8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 429922, RefRangeEnd = 429930, XrefRangeStart = 429917, XrefRangeEnd = 429922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose<T>(ref T disposable) where T : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(disposable);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MonoBtlsContext.MethodInfoStoreGeneric_Dispose_Private_Void_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				disposable = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			}
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00025054 File Offset: 0x00023254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429930, XrefRangeEnd = 429953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsContext.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600028F RID: 655 RVA: 0x000250A0 File Offset: 0x000232A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429953, XrefRangeEnd = 429955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Mono_Btls_IMonoBtlsBioMono_Read(Il2CppStructArray<byte> buffer, int offset, int size, out bool wantMore)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &wantMore;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsContext.NativeMethodInfoPtr_Mono_Btls_IMonoBtlsBioMono_Read_Private_Virtual_Final_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00025118 File Offset: 0x00023318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429955, XrefRangeEnd = 429957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Mono_Btls_IMonoBtlsBioMono_Write(Il2CppStructArray<byte> buffer, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsContext.NativeMethodInfoPtr_Mono_Btls_IMonoBtlsBioMono_Write_Private_Virtual_Final_New_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00025184 File Offset: 0x00023384
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Mono_Btls_IMonoBtlsBioMono_Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsContext.NativeMethodInfoPtr_Mono_Btls_IMonoBtlsBioMono_Flush_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x000251B8 File Offset: 0x000233B8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Mono_Btls_IMonoBtlsBioMono_Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsContext.NativeMethodInfoPtr_Mono_Btls_IMonoBtlsBioMono_Close_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000293 RID: 659 RVA: 0x000251EC File Offset: 0x000233EC
		public unsafe override bool IsAuthenticated
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsContext.NativeMethodInfoPtr_get_IsAuthenticated_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000294 RID: 660 RVA: 0x00025234 File Offset: 0x00023434
		public unsafe override X509Certificate LocalClientCertificate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsContext.NativeMethodInfoPtr_get_LocalClientCertificate_Internal_Virtual_get_X509Certificate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000295 RID: 661 RVA: 0x00025280 File Offset: 0x00023480
		public unsafe override X509Certificate2 RemoteCertificate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsContext.NativeMethodInfoPtr_get_RemoteCertificate_Public_Virtual_get_X509Certificate2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate2>(intPtr3) : null;
			}
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00002EAA File Offset: 0x000010AA
		public MonoBtlsContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000297 RID: 663 RVA: 0x000252CC File Offset: 0x000234CC
		// (set) Token: 0x06000298 RID: 664 RVA: 0x00002EB3 File Offset: 0x000010B3
		public unsafe X509Certificate2 remoteCertificate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsContext.NativeFieldInfoPtr_remoteCertificate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Certificate2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsContext.NativeFieldInfoPtr_remoteCertificate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000299 RID: 665 RVA: 0x000252FC File Offset: 0x000234FC
		// (set) Token: 0x0600029A RID: 666 RVA: 0x00002ED2 File Offset: 0x000010D2
		public unsafe X509Certificate clientCertificate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsContext.NativeFieldInfoPtr_clientCertificate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsContext.NativeFieldInfoPtr_clientCertificate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600029B RID: 667 RVA: 0x0002532C File Offset: 0x0002352C
		// (set) Token: 0x0600029C RID: 668 RVA: 0x00002EF1 File Offset: 0x000010F1
		public unsafe X509CertificateImplBtls nativeServerCertificate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsContext.NativeFieldInfoPtr_nativeServerCertificate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509CertificateImplBtls>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsContext.NativeFieldInfoPtr_nativeServerCertificate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600029D RID: 669 RVA: 0x0002535C File Offset: 0x0002355C
		// (set) Token: 0x0600029E RID: 670 RVA: 0x00002F10 File Offset: 0x00001110
		public unsafe X509CertificateImplBtls nativeClientCertificate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsContext.NativeFieldInfoPtr_nativeClientCertificate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509CertificateImplBtls>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsContext.NativeFieldInfoPtr_nativeClientCertificate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600029F RID: 671 RVA: 0x0002538C File Offset: 0x0002358C
		// (set) Token: 0x060002A0 RID: 672 RVA: 0x00002F2F File Offset: 0x0000112F
		public unsafe MonoBtlsSslCtx ctx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsContext.NativeFieldInfoPtr_ctx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoBtlsSslCtx>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsContext.NativeFieldInfoPtr_ctx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x000253BC File Offset: 0x000235BC
		// (set) Token: 0x060002A2 RID: 674 RVA: 0x00002F4E File Offset: 0x0000114E
		public unsafe MonoBtlsSsl ssl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsContext.NativeFieldInfoPtr_ssl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoBtlsSsl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsContext.NativeFieldInfoPtr_ssl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x000253EC File Offset: 0x000235EC
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x00002F6D File Offset: 0x0000116D
		public unsafe MonoBtlsBio bio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsContext.NativeFieldInfoPtr_bio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoBtlsBio>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsContext.NativeFieldInfoPtr_bio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x0002541C File Offset: 0x0002361C
		// (set) Token: 0x060002A6 RID: 678 RVA: 0x00002F8C File Offset: 0x0000118C
		public unsafe MonoBtlsBio errbio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsContext.NativeFieldInfoPtr_errbio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoBtlsBio>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsContext.NativeFieldInfoPtr_errbio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x0002544C File Offset: 0x0002364C
		// (set) Token: 0x060002A8 RID: 680 RVA: 0x00002FAB File Offset: 0x000011AB
		public unsafe MonoTlsConnectionInfo connectionInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsContext.NativeFieldInfoPtr_connectionInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoTlsConnectionInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsContext.NativeFieldInfoPtr_connectionInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x0002547C File Offset: 0x0002367C
		// (set) Token: 0x060002AA RID: 682 RVA: 0x00002FCA File Offset: 0x000011CA
		public unsafe bool certificateValidated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsContext.NativeFieldInfoPtr_certificateValidated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsContext.NativeFieldInfoPtr_certificateValidated)) = value;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060002AB RID: 683 RVA: 0x000254A4 File Offset: 0x000236A4
		// (set) Token: 0x060002AC RID: 684 RVA: 0x00002FE5 File Offset: 0x000011E5
		public unsafe bool isAuthenticated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsContext.NativeFieldInfoPtr_isAuthenticated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsContext.NativeFieldInfoPtr_isAuthenticated)) = value;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060002AD RID: 685 RVA: 0x000254CC File Offset: 0x000236CC
		// (set) Token: 0x060002AE RID: 686 RVA: 0x00003000 File Offset: 0x00001200
		public unsafe bool connected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsContext.NativeFieldInfoPtr_connected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsContext.NativeFieldInfoPtr_connected)) = value;
			}
		}

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeFieldInfoPtr_remoteCertificate;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeFieldInfoPtr_clientCertificate;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeFieldInfoPtr_nativeServerCertificate;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeFieldInfoPtr_nativeClientCertificate;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeFieldInfoPtr_ctx;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeFieldInfoPtr_ssl;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeFieldInfoPtr_bio;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeFieldInfoPtr_errbio;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeFieldInfoPtr_connectionInfo;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeFieldInfoPtr_certificateValidated;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeFieldInfoPtr_isAuthenticated;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeFieldInfoPtr_connected;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MobileAuthenticatedStream_MonoSslAuthenticationOptions_0;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeMethodInfoPtr_GetPrivateCertificate_Private_Static_X509CertificateImplBtls_X509Certificate_0;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeMethodInfoPtr_VerifyCallback_Private_Int32_MonoBtlsX509StoreCtx_0;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeMethodInfoPtr_SelectCallback_Private_Int32_Il2CppStringArray_0;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeMethodInfoPtr_ServerNameCallback_Private_Int32_0;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeMethodInfoPtr_StartHandshake_Public_Virtual_Void_0;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeMethodInfoPtr_SetPrivateCertificate_Private_Void_X509CertificateImplBtls_0;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeMethodInfoPtr_GetException_Private_Static_Exception_MonoBtlsSslError_0;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeMethodInfoPtr_ProcessHandshake_Public_Virtual_Boolean_0;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeMethodInfoPtr_DoProcessHandshake_Private_MonoBtlsSslError_0;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeMethodInfoPtr_FinishHandshake_Public_Virtual_Void_0;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeMethodInfoPtr_InitializeConnection_Private_Void_0;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeMethodInfoPtr_GetPeerCertificate_Private_Void_0;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSession_Private_Void_0;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeMethodInfoPtr_GetProtocol_Private_Static_TlsProtocols_TlsProtocolCode_0;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_Void_0;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_ValueTuple_2_Int32_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_ValueTuple_2_Int32_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeMethodInfoPtr_Renegotiate_Public_Virtual_Void_0;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeMethodInfoPtr_Shutdown_Public_Virtual_Void_0;

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeMethodInfoPtr_PendingRenegotiation_Public_Virtual_Boolean_0;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_byref_T_0;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeMethodInfoPtr_Mono_Btls_IMonoBtlsBioMono_Read_Private_Virtual_Final_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_byref_Boolean_0;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeMethodInfoPtr_Mono_Btls_IMonoBtlsBioMono_Write_Private_Virtual_Final_New_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeMethodInfoPtr_Mono_Btls_IMonoBtlsBioMono_Flush_Private_Virtual_Final_New_Void_0;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeMethodInfoPtr_Mono_Btls_IMonoBtlsBioMono_Close_Private_Virtual_Final_New_Void_0;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAuthenticated_Public_Virtual_get_Boolean_0;

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalClientCertificate_Internal_Virtual_get_X509Certificate_0;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeMethodInfoPtr_get_RemoteCertificate_Public_Virtual_get_X509Certificate2_0;

		// Token: 0x020002AB RID: 683
		private sealed class MethodInfoStoreGeneric_Dispose_Private_Void_byref_T_0<T>
		{
			// Token: 0x040021C6 RID: 8646
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MonoBtlsContext.NativeMethodInfoPtr_Dispose_Private_Void_byref_T_0, Il2CppClassPointerStore<MonoBtlsContext>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
