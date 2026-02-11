using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Net.Security;
using Il2CppMono.Security.Interface;
using Il2CppSystem;
using Il2CppSystem.Runtime.InteropServices;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Unity
{
	// Token: 0x0200000B RID: 11
	public class UnityTlsContext : MobileTlsContext
	{
		// Token: 0x0600004B RID: 75 RVA: 0x0001B944 File Offset: 0x00019B44
		// Note: this type is marked as 'beforefieldinit'.
		static UnityTlsContext()
		{
			Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Unity", "UnityTlsContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr);
			UnityTlsContext.NativeFieldInfoPtr_tlsContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, "tlsContext");
			UnityTlsContext.NativeFieldInfoPtr_requestedClientCertChain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, "requestedClientCertChain");
			UnityTlsContext.NativeFieldInfoPtr_requestedClientKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, "requestedClientKey");
			UnityTlsContext.NativeFieldInfoPtr_readCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, "readCallback");
			UnityTlsContext.NativeFieldInfoPtr_writeCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, "writeCallback");
			UnityTlsContext.NativeFieldInfoPtr_certificateCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, "certificateCallback");
			UnityTlsContext.NativeFieldInfoPtr_verifyCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, "verifyCallback");
			UnityTlsContext.NativeFieldInfoPtr_localClientCertificate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, "localClientCertificate");
			UnityTlsContext.NativeFieldInfoPtr_remoteCertificate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, "remoteCertificate");
			UnityTlsContext.NativeFieldInfoPtr_connectioninfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, "connectioninfo");
			UnityTlsContext.NativeFieldInfoPtr_isAuthenticated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, "isAuthenticated");
			UnityTlsContext.NativeFieldInfoPtr_hasContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, "hasContext");
			UnityTlsContext.NativeFieldInfoPtr_closedGraceful = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, "closedGraceful");
			UnityTlsContext.NativeFieldInfoPtr_writeBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, "writeBuffer");
			UnityTlsContext.NativeFieldInfoPtr_readBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, "readBuffer");
			UnityTlsContext.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, "handle");
			UnityTlsContext.NativeFieldInfoPtr_lastException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, "lastException");
			UnityTlsContext.NativeMethodInfoPtr__ctor_Public_Void_MobileAuthenticatedStream_MonoSslAuthenticationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, 100663411);
			UnityTlsContext.NativeMethodInfoPtr_ExtractNativeKeyAndChainFromManagedCertificate_Private_Static_Void_X509Certificate_ptr_unitytls_errorstate_byref_ptr_unitytls_x509list_byref_ptr_unitytls_key_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, 100663412);
			UnityTlsContext.NativeMethodInfoPtr_get_IsAuthenticated_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, 100663413);
			UnityTlsContext.NativeMethodInfoPtr_get_LocalClientCertificate_Internal_Virtual_get_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, 100663414);
			UnityTlsContext.NativeMethodInfoPtr_get_RemoteCertificate_Public_Virtual_get_X509Certificate2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, 100663415);
			UnityTlsContext.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, 100663416);
			UnityTlsContext.NativeMethodInfoPtr_Read_Public_Virtual_ValueTuple_2_Int32_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, 100663417);
			UnityTlsContext.NativeMethodInfoPtr_Write_Public_Virtual_ValueTuple_2_Int32_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, 100663418);
			UnityTlsContext.NativeMethodInfoPtr_Renegotiate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, 100663419);
			UnityTlsContext.NativeMethodInfoPtr_PendingRenegotiation_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, 100663420);
			UnityTlsContext.NativeMethodInfoPtr_Shutdown_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, 100663421);
			UnityTlsContext.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, 100663422);
			UnityTlsContext.NativeMethodInfoPtr_StartHandshake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, 100663423);
			UnityTlsContext.NativeMethodInfoPtr_ProcessHandshake_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, 100663424);
			UnityTlsContext.NativeMethodInfoPtr_FinishHandshake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, 100663425);
			UnityTlsContext.NativeMethodInfoPtr_WriteCallback_Private_Static_IntPtr_ptr_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, 100663426);
			UnityTlsContext.NativeMethodInfoPtr_WriteCallback_Private_IntPtr_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, 100663427);
			UnityTlsContext.NativeMethodInfoPtr_ReadCallback_Private_Static_IntPtr_ptr_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, 100663428);
			UnityTlsContext.NativeMethodInfoPtr_ReadCallback_Private_IntPtr_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, 100663429);
			UnityTlsContext.NativeMethodInfoPtr_VerifyCallback_Private_Static_unitytls_x509verify_result_ptr_Void_unitytls_x509list_ref_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, 100663430);
			UnityTlsContext.NativeMethodInfoPtr_VerifyCallback_Private_unitytls_x509verify_result_unitytls_x509list_ref_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, 100663431);
			UnityTlsContext.NativeMethodInfoPtr_CertificateCallback_Private_Static_Void_ptr_Void_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_x509name_IntPtr_ptr_unitytls_x509list_ref_ptr_unitytls_key_ref_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, 100663432);
			UnityTlsContext.NativeMethodInfoPtr_CertificateCallback_Private_Void_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_x509name_IntPtr_ptr_unitytls_x509list_ref_ptr_unitytls_key_ref_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr, 100663433);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0001BC94 File Offset: 0x00019E94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 427188, RefRangeEnd = 427189, XrefRangeStart = 427115, XrefRangeEnd = 427188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityTlsContext(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTlsContext>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTlsContext.NativeMethodInfoPtr__ctor_Public_Void_MobileAuthenticatedStream_MonoSslAuthenticationOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0001BCF4 File Offset: 0x00019EF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 427202, RefRangeEnd = 427204, XrefRangeStart = 427189, XrefRangeEnd = 427202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExtractNativeKeyAndChainFromManagedCertificate(X509Certificate cert, UnityTls.unitytls_errorstate* errorState, out UnityTls.unitytls_x509list* nativeCertChain, out UnityTls.unitytls_key* nativeKey)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cert);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(UnityTlsContext.NativeMethodInfoPtr_ExtractNativeKeyAndChainFromManagedCertificate_Private_Static_Void_X509Certificate_ptr_unitytls_errorstate_byref_ptr_unitytls_x509list_byref_ptr_unitytls_key_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			nativeCertChain = ((intPtr5 == 0) ? null : new UnityTls.unitytls_x509list*(intPtr5));
			IntPtr intPtr6 = intPtr2;
			nativeKey = ((intPtr6 == 0) ? null : new UnityTls.unitytls_key*(intPtr6));
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600004E RID: 78 RVA: 0x0001BD7C File Offset: 0x00019F7C
		public unsafe override bool IsAuthenticated
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityTlsContext.NativeMethodInfoPtr_get_IsAuthenticated_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600004F RID: 79 RVA: 0x0001BDC4 File Offset: 0x00019FC4
		public unsafe override X509Certificate LocalClientCertificate
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityTlsContext.NativeMethodInfoPtr_get_LocalClientCertificate_Internal_Virtual_get_X509Certificate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000050 RID: 80 RVA: 0x0001BE10 File Offset: 0x0001A010
		public unsafe override X509Certificate2 RemoteCertificate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityTlsContext.NativeMethodInfoPtr_get_RemoteCertificate_Public_Virtual_get_X509Certificate2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate2>(intPtr3) : null;
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0001BE5C File Offset: 0x0001A05C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityTlsContext.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0001BE98 File Offset: 0x0001A098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427204, XrefRangeEnd = 427214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ValueTuple<int, bool> Read(Il2CppStructArray<byte> buffer, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityTlsContext.NativeMethodInfoPtr_Read_Public_Virtual_ValueTuple_2_Int32_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTuple<int, bool>(intPtr);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0001BF08 File Offset: 0x0001A108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427214, XrefRangeEnd = 427224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ValueTuple<int, bool> Write(Il2CppStructArray<byte> buffer, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityTlsContext.NativeMethodInfoPtr_Write_Public_Virtual_ValueTuple_2_Int32_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTuple<int, bool>(intPtr);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0001BF78 File Offset: 0x0001A178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427224, XrefRangeEnd = 427229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Renegotiate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityTlsContext.NativeMethodInfoPtr_Renegotiate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0001BFB4 File Offset: 0x0001A1B4
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool PendingRenegotiation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityTlsContext.NativeMethodInfoPtr_PendingRenegotiation_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0001BFFC File Offset: 0x0001A1FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427229, XrefRangeEnd = 427234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Shutdown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityTlsContext.NativeMethodInfoPtr_Shutdown_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0001C038 File Offset: 0x0001A238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427234, XrefRangeEnd = 427243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityTlsContext.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0001C084 File Offset: 0x0001A284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427243, XrefRangeEnd = 427251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartHandshake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityTlsContext.NativeMethodInfoPtr_StartHandshake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0001C0C0 File Offset: 0x0001A2C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427251, XrefRangeEnd = 427260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ProcessHandshake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityTlsContext.NativeMethodInfoPtr_ProcessHandshake_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0001C108 File Offset: 0x0001A308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427260, XrefRangeEnd = 427272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FinishHandshake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityTlsContext.NativeMethodInfoPtr_FinishHandshake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0001C144 File Offset: 0x0001A344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427272, XrefRangeEnd = 427278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr WriteCallback(void* userData, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = userData;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTlsContext.NativeMethodInfoPtr_WriteCallback_Private_Static_IntPtr_ptr_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0001C1A8 File Offset: 0x0001A3A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 427299, RefRangeEnd = 427300, XrefRangeStart = 427278, XrefRangeEnd = 427299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr WriteCallback(byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = data;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTlsContext.NativeMethodInfoPtr_WriteCallback_Private_IntPtr_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0001C20C File Offset: 0x0001A40C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427300, XrefRangeEnd = 427306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ReadCallback(void* userData, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = userData;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTlsContext.NativeMethodInfoPtr_ReadCallback_Private_Static_IntPtr_ptr_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0001C270 File Offset: 0x0001A470
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 427331, RefRangeEnd = 427332, XrefRangeStart = 427306, XrefRangeEnd = 427331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr ReadCallback(byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTlsContext.NativeMethodInfoPtr_ReadCallback_Private_IntPtr_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0001C2D4 File Offset: 0x0001A4D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427332, XrefRangeEnd = 427338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityTls.unitytls_x509verify_result VerifyCallback(void* userData, UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = userData;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref chain;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTlsContext.NativeMethodInfoPtr_VerifyCallback_Private_Static_unitytls_x509verify_result_ptr_Void_unitytls_x509list_ref_ptr_unitytls_errorstate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0001C32C File Offset: 0x0001A52C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 427372, RefRangeEnd = 427373, XrefRangeStart = 427338, XrefRangeEnd = 427372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityTls.unitytls_x509verify_result VerifyCallback(UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref chain;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTlsContext.NativeMethodInfoPtr_VerifyCallback_Private_unitytls_x509verify_result_unitytls_x509list_ref_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0001C384 File Offset: 0x0001A584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427373, XrefRangeEnd = 427379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CertificateCallback(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = userData;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ctx;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = cn;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cnLen;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = caList;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref caListLen;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = chain;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = key;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTlsContext.NativeMethodInfoPtr_CertificateCallback_Private_Static_Void_ptr_Void_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_x509name_IntPtr_ptr_unitytls_x509list_ref_ptr_unitytls_key_ref_ptr_unitytls_errorstate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0001C424 File Offset: 0x0001A624
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 427393, RefRangeEnd = 427394, XrefRangeStart = 427379, XrefRangeEnd = 427393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CertificateCallback(UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ctx;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = cn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cnLen;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = caList;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref caListLen;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = chain;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = key;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTlsContext.NativeMethodInfoPtr_CertificateCallback_Private_Void_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_x509name_IntPtr_ptr_unitytls_x509list_ref_ptr_unitytls_key_ref_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000021BE File Offset: 0x000003BE
		public UnityTlsContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000064 RID: 100 RVA: 0x0001C4C4 File Offset: 0x0001A6C4
		// (set) Token: 0x06000065 RID: 101 RVA: 0x000021C7 File Offset: 0x000003C7
		public unsafe UnityTls.unitytls_tlsctx* tlsContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_tlsContext);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_tlsContext)) = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000066 RID: 102 RVA: 0x0001C4E8 File Offset: 0x0001A6E8
		// (set) Token: 0x06000067 RID: 103 RVA: 0x000021E2 File Offset: 0x000003E2
		public unsafe UnityTls.unitytls_x509list* requestedClientCertChain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_requestedClientCertChain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_requestedClientCertChain)) = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000068 RID: 104 RVA: 0x0001C50C File Offset: 0x0001A70C
		// (set) Token: 0x06000069 RID: 105 RVA: 0x000021FD File Offset: 0x000003FD
		public unsafe UnityTls.unitytls_key* requestedClientKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_requestedClientKey);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_requestedClientKey)) = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600006A RID: 106 RVA: 0x0001C530 File Offset: 0x0001A730
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00002218 File Offset: 0x00000418
		public unsafe UnityTls.unitytls_tlsctx_read_callback readCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_readCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_tlsctx_read_callback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_readCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600006C RID: 108 RVA: 0x0001C560 File Offset: 0x0001A760
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00002237 File Offset: 0x00000437
		public unsafe UnityTls.unitytls_tlsctx_write_callback writeCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_writeCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_tlsctx_write_callback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_writeCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600006E RID: 110 RVA: 0x0001C590 File Offset: 0x0001A790
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00002256 File Offset: 0x00000456
		public unsafe UnityTls.unitytls_tlsctx_certificate_callback certificateCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_certificateCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_tlsctx_certificate_callback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_certificateCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000070 RID: 112 RVA: 0x0001C5C0 File Offset: 0x0001A7C0
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00002275 File Offset: 0x00000475
		public unsafe UnityTls.unitytls_tlsctx_x509verify_callback verifyCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_verifyCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_tlsctx_x509verify_callback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_verifyCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000072 RID: 114 RVA: 0x0001C5F0 File Offset: 0x0001A7F0
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00002294 File Offset: 0x00000494
		public unsafe X509Certificate localClientCertificate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_localClientCertificate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_localClientCertificate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000074 RID: 116 RVA: 0x0001C620 File Offset: 0x0001A820
		// (set) Token: 0x06000075 RID: 117 RVA: 0x000022B3 File Offset: 0x000004B3
		public unsafe X509Certificate2 remoteCertificate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_remoteCertificate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Certificate2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_remoteCertificate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000076 RID: 118 RVA: 0x0001C650 File Offset: 0x0001A850
		// (set) Token: 0x06000077 RID: 119 RVA: 0x000022D2 File Offset: 0x000004D2
		public unsafe MonoTlsConnectionInfo connectioninfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_connectioninfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoTlsConnectionInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_connectioninfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000078 RID: 120 RVA: 0x0001C680 File Offset: 0x0001A880
		// (set) Token: 0x06000079 RID: 121 RVA: 0x000022F1 File Offset: 0x000004F1
		public unsafe bool isAuthenticated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_isAuthenticated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_isAuthenticated)) = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600007A RID: 122 RVA: 0x0001C6A8 File Offset: 0x0001A8A8
		// (set) Token: 0x0600007B RID: 123 RVA: 0x0000230C File Offset: 0x0000050C
		public unsafe bool hasContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_hasContext);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_hasContext)) = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600007C RID: 124 RVA: 0x0001C6D0 File Offset: 0x0001A8D0
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00002327 File Offset: 0x00000527
		public unsafe bool closedGraceful
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_closedGraceful);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_closedGraceful)) = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600007E RID: 126 RVA: 0x0001C6F8 File Offset: 0x0001A8F8
		// (set) Token: 0x0600007F RID: 127 RVA: 0x00002342 File Offset: 0x00000542
		public unsafe Il2CppStructArray<byte> writeBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_writeBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_writeBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000080 RID: 128 RVA: 0x0001C728 File Offset: 0x0001A928
		// (set) Token: 0x06000081 RID: 129 RVA: 0x00002361 File Offset: 0x00000561
		public unsafe Il2CppStructArray<byte> readBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_readBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_readBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000082 RID: 130 RVA: 0x0001C758 File Offset: 0x0001A958
		// (set) Token: 0x06000083 RID: 131 RVA: 0x00002380 File Offset: 0x00000580
		public unsafe GCHandle handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_handle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_handle)) = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000084 RID: 132 RVA: 0x0001C780 File Offset: 0x0001A980
		// (set) Token: 0x06000085 RID: 133 RVA: 0x0000239B File Offset: 0x0000059B
		public unsafe Exception lastException
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_lastException);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTlsContext.NativeFieldInfoPtr_lastException), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeFieldInfoPtr_tlsContext;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeFieldInfoPtr_requestedClientCertChain;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeFieldInfoPtr_requestedClientKey;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeFieldInfoPtr_readCallback;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeFieldInfoPtr_writeCallback;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeFieldInfoPtr_certificateCallback;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeFieldInfoPtr_verifyCallback;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeFieldInfoPtr_localClientCertificate;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeFieldInfoPtr_remoteCertificate;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeFieldInfoPtr_connectioninfo;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeFieldInfoPtr_isAuthenticated;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeFieldInfoPtr_hasContext;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeFieldInfoPtr_closedGraceful;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeFieldInfoPtr_writeBuffer;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeFieldInfoPtr_readBuffer;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeFieldInfoPtr_handle;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeFieldInfoPtr_lastException;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MobileAuthenticatedStream_MonoSslAuthenticationOptions_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_ExtractNativeKeyAndChainFromManagedCertificate_Private_Static_Void_X509Certificate_ptr_unitytls_errorstate_byref_ptr_unitytls_x509list_byref_ptr_unitytls_key_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAuthenticated_Public_Virtual_get_Boolean_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalClientCertificate_Internal_Virtual_get_X509Certificate_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_get_RemoteCertificate_Public_Virtual_get_X509Certificate2_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_Void_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_ValueTuple_2_Int32_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_ValueTuple_2_Int32_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_Renegotiate_Public_Virtual_Void_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_PendingRenegotiation_Public_Virtual_Boolean_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_Shutdown_Public_Virtual_Void_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_StartHandshake_Public_Virtual_Void_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_ProcessHandshake_Public_Virtual_Boolean_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_FinishHandshake_Public_Virtual_Void_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_WriteCallback_Private_Static_IntPtr_ptr_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_WriteCallback_Private_IntPtr_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_ReadCallback_Private_Static_IntPtr_ptr_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_ReadCallback_Private_IntPtr_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_VerifyCallback_Private_Static_unitytls_x509verify_result_ptr_Void_unitytls_x509list_ref_ptr_unitytls_errorstate_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_VerifyCallback_Private_unitytls_x509verify_result_unitytls_x509list_ref_ptr_unitytls_errorstate_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_CertificateCallback_Private_Static_Void_ptr_Void_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_x509name_IntPtr_ptr_unitytls_x509list_ref_ptr_unitytls_key_ref_ptr_unitytls_errorstate_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_CertificateCallback_Private_Void_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_x509name_IntPtr_ptr_unitytls_x509list_ref_ptr_unitytls_key_ref_ptr_unitytls_errorstate_0;
	}
}
