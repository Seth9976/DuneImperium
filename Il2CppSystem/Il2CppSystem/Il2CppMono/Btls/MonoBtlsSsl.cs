using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Btls
{
	// Token: 0x02000035 RID: 53
	public class MonoBtlsSsl : MonoBtlsObject
	{
		// Token: 0x06000323 RID: 803 RVA: 0x000275FC File Offset: 0x000257FC
		// Note: this type is marked as 'beforefieldinit'.
		static MonoBtlsSsl()
		{
			Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Btls", "MonoBtlsSsl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr);
			MonoBtlsSsl.NativeFieldInfoPtr_bio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, "bio");
			MonoBtlsSsl.NativeFieldInfoPtr_printErrorsFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, "printErrorsFunc");
			MonoBtlsSsl.NativeFieldInfoPtr_printErrorsFuncPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, "printErrorsFuncPtr");
			MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_destroy_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663848);
			MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_new_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663849);
			MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_use_certificate_Private_Static_Int32_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663850);
			MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_use_private_key_Private_Static_Int32_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663851);
			MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_add_chain_certificate_Private_Static_Int32_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663852);
			MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_accept_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663853);
			MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_connect_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663854);
			MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_handshake_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663855);
			MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_close_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663856);
			MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_shutdown_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663857);
			MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_set_quiet_shutdown_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663858);
			MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_set_bio_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663859);
			MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_read_Private_Static_Int32_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663860);
			MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_write_Private_Static_Int32_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663861);
			MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_get_error_Private_Static_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663862);
			MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_get_version_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663863);
			MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_get_cipher_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663864);
			MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_get_peer_certificate_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663865);
			MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_print_errors_cb_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663866);
			MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_set_server_name_Private_Static_Int32_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663867);
			MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_get_server_name_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663868);
			MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_set_renegotiate_mode_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663869);
			MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_renegotiate_pending_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663870);
			MonoBtlsSsl.NativeMethodInfoPtr_Create_internal_Private_Static_BoringSslHandle_MonoBtlsSslCtx_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663871);
			MonoBtlsSsl.NativeMethodInfoPtr__ctor_Public_Void_MonoBtlsSslCtx_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663872);
			MonoBtlsSsl.NativeMethodInfoPtr_get_Handle_Internal_get_BoringSslHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663873);
			MonoBtlsSsl.NativeMethodInfoPtr_SetBio_Public_Void_MonoBtlsBio_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663874);
			MonoBtlsSsl.NativeMethodInfoPtr_ThrowError_Private_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663875);
			MonoBtlsSsl.NativeMethodInfoPtr_GetError_Private_MonoBtlsSslError_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663876);
			MonoBtlsSsl.NativeMethodInfoPtr_SetCertificate_Public_Void_MonoBtlsX509_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663877);
			MonoBtlsSsl.NativeMethodInfoPtr_SetPrivateKey_Public_Void_MonoBtlsKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663878);
			MonoBtlsSsl.NativeMethodInfoPtr_AddIntermediateCertificate_Public_Void_MonoBtlsX509_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663879);
			MonoBtlsSsl.NativeMethodInfoPtr_Accept_Public_MonoBtlsSslError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663880);
			MonoBtlsSsl.NativeMethodInfoPtr_Connect_Public_MonoBtlsSslError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663881);
			MonoBtlsSsl.NativeMethodInfoPtr_Handshake_Public_MonoBtlsSslError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663882);
			MonoBtlsSsl.NativeMethodInfoPtr_PrintErrorsCallback_Private_Static_Int32_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663883);
			MonoBtlsSsl.NativeMethodInfoPtr_GetErrors_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663884);
			MonoBtlsSsl.NativeMethodInfoPtr_PrintErrors_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663885);
			MonoBtlsSsl.NativeMethodInfoPtr_Read_Public_MonoBtlsSslError_IntPtr_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663886);
			MonoBtlsSsl.NativeMethodInfoPtr_Write_Public_MonoBtlsSslError_IntPtr_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663887);
			MonoBtlsSsl.NativeMethodInfoPtr_GetVersion_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663888);
			MonoBtlsSsl.NativeMethodInfoPtr_GetCipher_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663889);
			MonoBtlsSsl.NativeMethodInfoPtr_GetPeerCertificate_Public_MonoBtlsX509_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663890);
			MonoBtlsSsl.NativeMethodInfoPtr_SetServerName_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663891);
			MonoBtlsSsl.NativeMethodInfoPtr_GetServerName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663892);
			MonoBtlsSsl.NativeMethodInfoPtr_Shutdown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663893);
			MonoBtlsSsl.NativeMethodInfoPtr_SetQuietShutdown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663894);
			MonoBtlsSsl.NativeMethodInfoPtr_Close_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663895);
			MonoBtlsSsl.NativeMethodInfoPtr_SetRenegotiateMode_Public_Void_MonoBtlsSslRenegotiateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663896);
			MonoBtlsSsl.NativeMethodInfoPtr_RenegotiatePending_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, 100663897);
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00027A50 File Offset: 0x00025C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430705, XrefRangeEnd = 430707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void mono_btls_ssl_destroy(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_destroy_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00027A84 File Offset: 0x00025C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430707, XrefRangeEnd = 430709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr mono_btls_ssl_new(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_new_Private_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00027AC4 File Offset: 0x00025CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430709, XrefRangeEnd = 430711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_ssl_use_certificate(IntPtr handle, IntPtr x509)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x509;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_use_certificate_Private_Static_Int32_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00027B10 File Offset: 0x00025D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430711, XrefRangeEnd = 430713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_ssl_use_private_key(IntPtr handle, IntPtr key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_use_private_key_Private_Static_Int32_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00027B5C File Offset: 0x00025D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430713, XrefRangeEnd = 430715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_ssl_add_chain_certificate(IntPtr handle, IntPtr x509)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x509;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_add_chain_certificate_Private_Static_Int32_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00027BA8 File Offset: 0x00025DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430715, XrefRangeEnd = 430717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_ssl_accept(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_accept_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00027BE8 File Offset: 0x00025DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430717, XrefRangeEnd = 430719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_ssl_connect(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_connect_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00027C28 File Offset: 0x00025E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430719, XrefRangeEnd = 430721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_ssl_handshake(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_handshake_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00027C68 File Offset: 0x00025E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430721, XrefRangeEnd = 430723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void mono_btls_ssl_close(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_close_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00027C9C File Offset: 0x00025E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430723, XrefRangeEnd = 430725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_ssl_shutdown(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_shutdown_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00027CDC File Offset: 0x00025EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430725, XrefRangeEnd = 430727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void mono_btls_ssl_set_quiet_shutdown(IntPtr handle, int mode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_set_quiet_shutdown_Private_Static_Void_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00027D1C File Offset: 0x00025F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430727, XrefRangeEnd = 430729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void mono_btls_ssl_set_bio(IntPtr handle, IntPtr bio)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bio;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_set_bio_Private_Static_Void_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00027D5C File Offset: 0x00025F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430729, XrefRangeEnd = 430731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_ssl_read(IntPtr handle, IntPtr data, int len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_read_Private_Static_Int32_IntPtr_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00027DB8 File Offset: 0x00025FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430731, XrefRangeEnd = 430733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_ssl_write(IntPtr handle, IntPtr data, int len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_write_Private_Static_Int32_IntPtr_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00027E14 File Offset: 0x00026014
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 430735, RefRangeEnd = 430737, XrefRangeStart = 430733, XrefRangeEnd = 430735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_ssl_get_error(IntPtr handle, int ret_code)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ret_code;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_get_error_Private_Static_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00027E60 File Offset: 0x00026060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430737, XrefRangeEnd = 430739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_ssl_get_version(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_get_version_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00027EA0 File Offset: 0x000260A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430739, XrefRangeEnd = 430741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_ssl_get_cipher(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_get_cipher_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00027EE0 File Offset: 0x000260E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430741, XrefRangeEnd = 430743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr mono_btls_ssl_get_peer_certificate(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_get_peer_certificate_Private_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00027F20 File Offset: 0x00026120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430743, XrefRangeEnd = 430745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void mono_btls_ssl_print_errors_cb(IntPtr func, IntPtr ctx)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref func;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ctx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_print_errors_cb_Private_Static_Void_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00027F60 File Offset: 0x00026160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430745, XrefRangeEnd = 430747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_ssl_set_server_name(IntPtr handle, IntPtr name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref name;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_set_server_name_Private_Static_Int32_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00027FAC File Offset: 0x000261AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430747, XrefRangeEnd = 430749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr mono_btls_ssl_get_server_name(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_get_server_name_Private_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00027FEC File Offset: 0x000261EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430749, XrefRangeEnd = 430751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void mono_btls_ssl_set_renegotiate_mode(IntPtr handle, int mode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_set_renegotiate_mode_Private_Static_Void_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600033A RID: 826 RVA: 0x0002802C File Offset: 0x0002622C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430751, XrefRangeEnd = 430753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_ssl_renegotiate_pending(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_mono_btls_ssl_renegotiate_pending_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0002806C File Offset: 0x0002626C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430753, XrefRangeEnd = 430761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoBtlsSsl.BoringSslHandle Create_internal(MonoBtlsSslCtx ctx)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctx);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_Create_internal_Private_Static_BoringSslHandle_MonoBtlsSslCtx_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsSsl.BoringSslHandle>(intPtr3) : null;
			}
		}

		// Token: 0x0600033C RID: 828 RVA: 0x000280B0 File Offset: 0x000262B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 430785, RefRangeEnd = 430786, XrefRangeStart = 430761, XrefRangeEnd = 430785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsSsl(MonoBtlsSslCtx ctx)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctx);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr__ctor_Public_Void_MonoBtlsSslCtx_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600033D RID: 829 RVA: 0x000280FC File Offset: 0x000262FC
		public new unsafe MonoBtlsSsl.BoringSslHandle Handle
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 430789, RefRangeEnd = 430811, XrefRangeStart = 430786, XrefRangeEnd = 430789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_get_Handle_Internal_get_BoringSslHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsSsl.BoringSslHandle>(intPtr3) : null;
			}
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0002813C File Offset: 0x0002633C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 430817, RefRangeEnd = 430818, XrefRangeStart = 430811, XrefRangeEnd = 430817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBio(MonoBtlsBio bio)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bio);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_SetBio_Public_Void_MonoBtlsBio_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00028180 File Offset: 0x00026380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430818, XrefRangeEnd = 430846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception ThrowError(string callerName = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(callerName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_ThrowError_Private_Exception_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06000340 RID: 832 RVA: 0x000281D0 File Offset: 0x000263D0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 430853, RefRangeEnd = 430857, XrefRangeStart = 430846, XrefRangeEnd = 430853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsSslError GetError(int ret_code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ret_code;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_GetError_Private_MonoBtlsSslError_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0002821C File Offset: 0x0002641C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 430862, RefRangeEnd = 430863, XrefRangeStart = 430857, XrefRangeEnd = 430862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCertificate(MonoBtlsX509 x509)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x509);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_SetCertificate_Public_Void_MonoBtlsX509_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00028260 File Offset: 0x00026460
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 430868, RefRangeEnd = 430869, XrefRangeStart = 430863, XrefRangeEnd = 430868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPrivateKey(MonoBtlsKey key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_SetPrivateKey_Public_Void_MonoBtlsKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000343 RID: 835 RVA: 0x000282A4 File Offset: 0x000264A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 430874, RefRangeEnd = 430876, XrefRangeStart = 430869, XrefRangeEnd = 430874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddIntermediateCertificate(MonoBtlsX509 x509)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x509);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_AddIntermediateCertificate_Public_Void_MonoBtlsX509_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000344 RID: 836 RVA: 0x000282E8 File Offset: 0x000264E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 430882, RefRangeEnd = 430884, XrefRangeStart = 430876, XrefRangeEnd = 430882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsSslError Accept()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_Accept_Public_MonoBtlsSslError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00028324 File Offset: 0x00026524
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 430890, RefRangeEnd = 430892, XrefRangeStart = 430884, XrefRangeEnd = 430890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsSslError Connect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_Connect_Public_MonoBtlsSslError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00028360 File Offset: 0x00026560
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 430898, RefRangeEnd = 430900, XrefRangeStart = 430892, XrefRangeEnd = 430898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsSslError Handshake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_Handshake_Public_MonoBtlsSslError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0002839C File Offset: 0x0002659C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430900, XrefRangeEnd = 430911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int PrintErrorsCallback(IntPtr str, IntPtr len, IntPtr ctx)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref str;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ctx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_PrintErrorsCallback_Private_Static_Int32_IntPtr_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000348 RID: 840 RVA: 0x000283F8 File Offset: 0x000265F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 430924, RefRangeEnd = 430926, XrefRangeStart = 430911, XrefRangeEnd = 430924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetErrors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_GetErrors_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00028430 File Offset: 0x00026630
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 430935, RefRangeEnd = 430936, XrefRangeStart = 430926, XrefRangeEnd = 430935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrintErrors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_PrintErrors_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00028464 File Offset: 0x00026664
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 430941, RefRangeEnd = 430942, XrefRangeStart = 430936, XrefRangeEnd = 430941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsSslError Read(IntPtr data, ref int dataSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref data;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dataSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_Read_Public_MonoBtlsSslError_IntPtr_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x000284BC File Offset: 0x000266BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 430948, RefRangeEnd = 430949, XrefRangeStart = 430942, XrefRangeEnd = 430948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsSslError Write(IntPtr data, ref int dataSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref data;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dataSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_Write_Public_MonoBtlsSslError_IntPtr_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00028514 File Offset: 0x00026714
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 430953, RefRangeEnd = 430954, XrefRangeStart = 430949, XrefRangeEnd = 430953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetVersion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_GetVersion_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00028550 File Offset: 0x00026750
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 430961, RefRangeEnd = 430962, XrefRangeStart = 430954, XrefRangeEnd = 430961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCipher()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_GetCipher_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0002858C File Offset: 0x0002678C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 430975, RefRangeEnd = 430976, XrefRangeStart = 430962, XrefRangeEnd = 430975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsX509 GetPeerCertificate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_GetPeerCertificate_Public_MonoBtlsX509_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509>(intPtr3) : null;
		}

		// Token: 0x0600034F RID: 847 RVA: 0x000285CC File Offset: 0x000267CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 430993, RefRangeEnd = 430994, XrefRangeStart = 430976, XrefRangeEnd = 430993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetServerName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_SetServerName_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00028610 File Offset: 0x00026810
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 431003, RefRangeEnd = 431005, XrefRangeStart = 430994, XrefRangeEnd = 431003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetServerName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_GetServerName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00028648 File Offset: 0x00026848
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 431009, RefRangeEnd = 431010, XrefRangeStart = 431005, XrefRangeEnd = 431009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Shutdown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_Shutdown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0002867C File Offset: 0x0002687C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 431014, RefRangeEnd = 431015, XrefRangeStart = 431010, XrefRangeEnd = 431014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetQuietShutdown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_SetQuietShutdown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000353 RID: 851 RVA: 0x000286B0 File Offset: 0x000268B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431015, XrefRangeEnd = 431019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsSsl.NativeMethodInfoPtr_Close_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000354 RID: 852 RVA: 0x000286EC File Offset: 0x000268EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 431023, RefRangeEnd = 431024, XrefRangeStart = 431019, XrefRangeEnd = 431023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRenegotiateMode(MonoBtlsSslRenegotiateMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_SetRenegotiateMode_Public_Void_MonoBtlsSslRenegotiateMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0002872C File Offset: 0x0002692C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 431027, RefRangeEnd = 431028, XrefRangeStart = 431024, XrefRangeEnd = 431027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RenegotiatePending()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.NativeMethodInfoPtr_RenegotiatePending_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0000314D File Offset: 0x0000134D
		public MonoBtlsSsl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000357 RID: 855 RVA: 0x00028768 File Offset: 0x00026968
		// (set) Token: 0x06000358 RID: 856 RVA: 0x00003156 File Offset: 0x00001356
		public unsafe MonoBtlsBio bio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsSsl.NativeFieldInfoPtr_bio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoBtlsBio>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsSsl.NativeFieldInfoPtr_bio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000359 RID: 857 RVA: 0x00028798 File Offset: 0x00026998
		// (set) Token: 0x0600035A RID: 858 RVA: 0x00003175 File Offset: 0x00001375
		public unsafe MonoBtlsSsl.PrintErrorsCallbackFunc printErrorsFunc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsSsl.NativeFieldInfoPtr_printErrorsFunc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoBtlsSsl.PrintErrorsCallbackFunc>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsSsl.NativeFieldInfoPtr_printErrorsFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600035B RID: 859 RVA: 0x000287C8 File Offset: 0x000269C8
		// (set) Token: 0x0600035C RID: 860 RVA: 0x00003194 File Offset: 0x00001394
		public unsafe IntPtr printErrorsFuncPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsSsl.NativeFieldInfoPtr_printErrorsFuncPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsSsl.NativeFieldInfoPtr_printErrorsFuncPtr)) = value;
			}
		}

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeFieldInfoPtr_bio;

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeFieldInfoPtr_printErrorsFunc;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeFieldInfoPtr_printErrorsFuncPtr;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_ssl_destroy_Private_Static_Void_IntPtr_0;

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_ssl_new_Private_Static_IntPtr_IntPtr_0;

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_ssl_use_certificate_Private_Static_Int32_IntPtr_IntPtr_0;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_ssl_use_private_key_Private_Static_Int32_IntPtr_IntPtr_0;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_ssl_add_chain_certificate_Private_Static_Int32_IntPtr_IntPtr_0;

		// Token: 0x0400023F RID: 575
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_ssl_accept_Private_Static_Int32_IntPtr_0;

		// Token: 0x04000240 RID: 576
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_ssl_connect_Private_Static_Int32_IntPtr_0;

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_ssl_handshake_Private_Static_Int32_IntPtr_0;

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_ssl_close_Private_Static_Void_IntPtr_0;

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_ssl_shutdown_Private_Static_Int32_IntPtr_0;

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_ssl_set_quiet_shutdown_Private_Static_Void_IntPtr_Int32_0;

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_ssl_set_bio_Private_Static_Void_IntPtr_IntPtr_0;

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_ssl_read_Private_Static_Int32_IntPtr_IntPtr_Int32_0;

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_ssl_write_Private_Static_Int32_IntPtr_IntPtr_Int32_0;

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_ssl_get_error_Private_Static_Int32_IntPtr_Int32_0;

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_ssl_get_version_Private_Static_Int32_IntPtr_0;

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_ssl_get_cipher_Private_Static_Int32_IntPtr_0;

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_ssl_get_peer_certificate_Private_Static_IntPtr_IntPtr_0;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_ssl_print_errors_cb_Private_Static_Void_IntPtr_IntPtr_0;

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_ssl_set_server_name_Private_Static_Int32_IntPtr_IntPtr_0;

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_ssl_get_server_name_Private_Static_IntPtr_IntPtr_0;

		// Token: 0x0400024F RID: 591
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_ssl_set_renegotiate_mode_Private_Static_Void_IntPtr_Int32_0;

		// Token: 0x04000250 RID: 592
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_ssl_renegotiate_pending_Private_Static_Int32_IntPtr_0;

		// Token: 0x04000251 RID: 593
		private static readonly IntPtr NativeMethodInfoPtr_Create_internal_Private_Static_BoringSslHandle_MonoBtlsSslCtx_0;

		// Token: 0x04000252 RID: 594
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MonoBtlsSslCtx_0;

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Internal_get_BoringSslHandle_0;

		// Token: 0x04000254 RID: 596
		private static readonly IntPtr NativeMethodInfoPtr_SetBio_Public_Void_MonoBtlsBio_0;

		// Token: 0x04000255 RID: 597
		private static readonly IntPtr NativeMethodInfoPtr_ThrowError_Private_Exception_String_0;

		// Token: 0x04000256 RID: 598
		private static readonly IntPtr NativeMethodInfoPtr_GetError_Private_MonoBtlsSslError_Int32_0;

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeMethodInfoPtr_SetCertificate_Public_Void_MonoBtlsX509_0;

		// Token: 0x04000258 RID: 600
		private static readonly IntPtr NativeMethodInfoPtr_SetPrivateKey_Public_Void_MonoBtlsKey_0;

		// Token: 0x04000259 RID: 601
		private static readonly IntPtr NativeMethodInfoPtr_AddIntermediateCertificate_Public_Void_MonoBtlsX509_0;

		// Token: 0x0400025A RID: 602
		private static readonly IntPtr NativeMethodInfoPtr_Accept_Public_MonoBtlsSslError_0;

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeMethodInfoPtr_Connect_Public_MonoBtlsSslError_0;

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeMethodInfoPtr_Handshake_Public_MonoBtlsSslError_0;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeMethodInfoPtr_PrintErrorsCallback_Private_Static_Int32_IntPtr_IntPtr_IntPtr_0;

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeMethodInfoPtr_GetErrors_Public_String_0;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeMethodInfoPtr_PrintErrors_Public_Void_0;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_MonoBtlsSslError_IntPtr_byref_Int32_0;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_MonoBtlsSslError_IntPtr_byref_Int32_0;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeMethodInfoPtr_GetVersion_Public_Int32_0;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeMethodInfoPtr_GetCipher_Public_Int32_0;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeMethodInfoPtr_GetPeerCertificate_Public_MonoBtlsX509_0;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeMethodInfoPtr_SetServerName_Public_Void_String_0;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeMethodInfoPtr_GetServerName_Public_String_0;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeMethodInfoPtr_Shutdown_Public_Void_0;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeMethodInfoPtr_SetQuietShutdown_Public_Void_0;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeMethodInfoPtr_Close_Protected_Virtual_Void_0;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeMethodInfoPtr_SetRenegotiateMode_Public_Void_MonoBtlsSslRenegotiateMode_0;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeMethodInfoPtr_RenegotiatePending_Public_Boolean_0;

		// Token: 0x020002AF RID: 687
		public class BoringSslHandle : MonoBtlsObject.MonoBtlsHandle
		{
			// Token: 0x06002AEB RID: 10987 RVA: 0x00013187 File Offset: 0x00011387
			// Note: this type is marked as 'beforefieldinit'.
			static BoringSslHandle()
			{
				Il2CppClassPointerStore<MonoBtlsSsl.BoringSslHandle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, "BoringSslHandle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsSsl.BoringSslHandle>.NativeClassPtr);
				MonoBtlsSsl.BoringSslHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl.BoringSslHandle>.NativeClassPtr, 100663899);
			}

			// Token: 0x06002AEC RID: 10988 RVA: 0x000BF500 File Offset: 0x000BD700
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430700, XrefRangeEnd = 430702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool ReleaseHandle()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsSsl.BoringSslHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002AED RID: 10989 RVA: 0x000131BB File Offset: 0x000113BB
			public BoringSslHandle(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040021CB RID: 8651
			private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0;
		}

		// Token: 0x020002B0 RID: 688
		public sealed class PrintErrorsCallbackFunc : MulticastDelegate
		{
			// Token: 0x06002AEE RID: 10990 RVA: 0x000131C4 File Offset: 0x000113C4
			// Note: this type is marked as 'beforefieldinit'.
			static PrintErrorsCallbackFunc()
			{
				Il2CppClassPointerStore<MonoBtlsSsl.PrintErrorsCallbackFunc>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoBtlsSsl>.NativeClassPtr, "PrintErrorsCallbackFunc");
				MonoBtlsSsl.PrintErrorsCallbackFunc.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl.PrintErrorsCallbackFunc>.NativeClassPtr, 100663900);
				MonoBtlsSsl.PrintErrorsCallbackFunc.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSsl.PrintErrorsCallbackFunc>.NativeClassPtr, 100663901);
			}

			// Token: 0x06002AEF RID: 10991 RVA: 0x000BF548 File Offset: 0x000BD748
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430702, XrefRangeEnd = 430705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PrintErrorsCallbackFunc(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsSsl.PrintErrorsCallbackFunc>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.PrintErrorsCallbackFunc.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002AF0 RID: 10992 RVA: 0x000BF5A4 File Offset: 0x000BD7A4
			[CallerCount(0)]
			public unsafe int Invoke(IntPtr str, IntPtr len, IntPtr ctx)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref str;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ctx;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSsl.PrintErrorsCallbackFunc.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_IntPtr_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002AF1 RID: 10993 RVA: 0x00013202 File Offset: 0x00011402
			public PrintErrorsCallbackFunc(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002AF2 RID: 10994 RVA: 0x0001320B File Offset: 0x0001140B
			public static implicit operator MonoBtlsSsl.PrintErrorsCallbackFunc(Func<IntPtr, IntPtr, IntPtr, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<MonoBtlsSsl.PrintErrorsCallbackFunc>(A_0);
			}

			// Token: 0x06002AF3 RID: 10995 RVA: 0x00013213 File Offset: 0x00011413
			public static MonoBtlsSsl.PrintErrorsCallbackFunc operator +(MonoBtlsSsl.PrintErrorsCallbackFunc A_0, MonoBtlsSsl.PrintErrorsCallbackFunc A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<MonoBtlsSsl.PrintErrorsCallbackFunc>();
			}

			// Token: 0x06002AF4 RID: 10996 RVA: 0x00013221 File Offset: 0x00011421
			public static MonoBtlsSsl.PrintErrorsCallbackFunc operator -(MonoBtlsSsl.PrintErrorsCallbackFunc A_0, MonoBtlsSsl.PrintErrorsCallbackFunc A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<MonoBtlsSsl.PrintErrorsCallbackFunc>();
				}
				return delegate2;
			}

			// Token: 0x040021CC RID: 8652
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040021CD RID: 8653
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_IntPtr_IntPtr_0;
		}
	}
}
