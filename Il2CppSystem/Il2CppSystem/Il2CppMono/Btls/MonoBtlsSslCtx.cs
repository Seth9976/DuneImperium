using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppMono.Btls
{
	// Token: 0x02000036 RID: 54
	public class MonoBtlsSslCtx : MonoBtlsObject
	{
		// Token: 0x0600035D RID: 861 RVA: 0x000287F0 File Offset: 0x000269F0
		// Note: this type is marked as 'beforefieldinit'.
		static MonoBtlsSslCtx()
		{
			Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Btls", "MonoBtlsSslCtx");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr);
			MonoBtlsSslCtx.NativeFieldInfoPtr_verifyFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, "verifyFunc");
			MonoBtlsSslCtx.NativeFieldInfoPtr_selectFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, "selectFunc");
			MonoBtlsSslCtx.NativeFieldInfoPtr_serverNameFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, "serverNameFunc");
			MonoBtlsSslCtx.NativeFieldInfoPtr_verifyFuncPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, "verifyFuncPtr");
			MonoBtlsSslCtx.NativeFieldInfoPtr_selectFuncPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, "selectFuncPtr");
			MonoBtlsSslCtx.NativeFieldInfoPtr_serverNameFuncPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, "serverNameFuncPtr");
			MonoBtlsSslCtx.NativeFieldInfoPtr_verifyCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, "verifyCallback");
			MonoBtlsSslCtx.NativeFieldInfoPtr_selectCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, "selectCallback");
			MonoBtlsSslCtx.NativeFieldInfoPtr_serverNameCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, "serverNameCallback");
			MonoBtlsSslCtx.NativeFieldInfoPtr_store = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, "store");
			MonoBtlsSslCtx.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, "instance");
			MonoBtlsSslCtx.NativeFieldInfoPtr_instancePtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, "instancePtr");
			MonoBtlsSslCtx.NativeMethodInfoPtr_get_Handle_Internal_get_BoringSslCtxHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, 100663902);
			MonoBtlsSslCtx.NativeMethodInfoPtr_mono_btls_ssl_ctx_new_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, 100663903);
			MonoBtlsSslCtx.NativeMethodInfoPtr_mono_btls_ssl_ctx_free_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, 100663904);
			MonoBtlsSslCtx.NativeMethodInfoPtr_mono_btls_ssl_ctx_initialize_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, 100663905);
			MonoBtlsSslCtx.NativeMethodInfoPtr_mono_btls_ssl_ctx_set_cert_verify_callback_Private_Static_Void_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, 100663906);
			MonoBtlsSslCtx.NativeMethodInfoPtr_mono_btls_ssl_ctx_set_cert_select_callback_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, 100663907);
			MonoBtlsSslCtx.NativeMethodInfoPtr_mono_btls_ssl_ctx_set_min_version_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, 100663908);
			MonoBtlsSslCtx.NativeMethodInfoPtr_mono_btls_ssl_ctx_set_max_version_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, 100663909);
			MonoBtlsSslCtx.NativeMethodInfoPtr_mono_btls_ssl_ctx_set_ciphers_Private_Static_Int32_IntPtr_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, 100663910);
			MonoBtlsSslCtx.NativeMethodInfoPtr_mono_btls_ssl_ctx_set_verify_param_Private_Static_Int32_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, 100663911);
			MonoBtlsSslCtx.NativeMethodInfoPtr_mono_btls_ssl_ctx_set_client_ca_list_Private_Static_Int32_IntPtr_Int32_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, 100663912);
			MonoBtlsSslCtx.NativeMethodInfoPtr_mono_btls_ssl_ctx_set_server_name_callback_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, 100663913);
			MonoBtlsSslCtx.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, 100663914);
			MonoBtlsSslCtx.NativeMethodInfoPtr__ctor_Internal_Void_BoringSslCtxHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, 100663915);
			MonoBtlsSslCtx.NativeMethodInfoPtr_get_CertificateStore_Public_get_MonoBtlsX509Store_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, 100663916);
			MonoBtlsSslCtx.NativeMethodInfoPtr_VerifyCallback_Private_Int32_Boolean_MonoBtlsX509StoreCtx_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, 100663917);
			MonoBtlsSslCtx.NativeMethodInfoPtr_NativeVerifyCallback_Private_Static_Int32_IntPtr_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, 100663918);
			MonoBtlsSslCtx.NativeMethodInfoPtr_NativeSelectCallback_Private_Static_Int32_IntPtr_Int32_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, 100663919);
			MonoBtlsSslCtx.NativeMethodInfoPtr_CopyIssuers_Private_Static_Il2CppStringArray_Int32_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, 100663920);
			MonoBtlsSslCtx.NativeMethodInfoPtr_SetVerifyCallback_Public_Void_MonoBtlsVerifyCallback_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, 100663921);
			MonoBtlsSslCtx.NativeMethodInfoPtr_SetSelectCallback_Public_Void_MonoBtlsSelectCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, 100663922);
			MonoBtlsSslCtx.NativeMethodInfoPtr_SetMinVersion_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, 100663923);
			MonoBtlsSslCtx.NativeMethodInfoPtr_SetMaxVersion_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, 100663924);
			MonoBtlsSslCtx.NativeMethodInfoPtr_SetCiphers_Public_Void_Il2CppStructArray_1_Int16_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, 100663925);
			MonoBtlsSslCtx.NativeMethodInfoPtr_SetVerifyParam_Public_Void_MonoBtlsX509VerifyParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, 100663926);
			MonoBtlsSslCtx.NativeMethodInfoPtr_SetClientCertificateIssuers_Public_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, 100663927);
			MonoBtlsSslCtx.NativeMethodInfoPtr_SetServerNameCallback_Public_Void_MonoBtlsServerNameCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, 100663928);
			MonoBtlsSslCtx.NativeMethodInfoPtr_NativeServerNameCallback_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, 100663929);
			MonoBtlsSslCtx.NativeMethodInfoPtr_Close_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, 100663930);
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600035E RID: 862 RVA: 0x00028B54 File Offset: 0x00026D54
		public new unsafe MonoBtlsSslCtx.BoringSslCtxHandle Handle
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 431042, RefRangeEnd = 431052, XrefRangeStart = 431039, XrefRangeEnd = 431042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSslCtx.NativeMethodInfoPtr_get_Handle_Internal_get_BoringSslCtxHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsSslCtx.BoringSslCtxHandle>(intPtr3) : null;
			}
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00028B94 File Offset: 0x00026D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431052, XrefRangeEnd = 431054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr mono_btls_ssl_ctx_new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSslCtx.NativeMethodInfoPtr_mono_btls_ssl_ctx_new_Private_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00028BC4 File Offset: 0x00026DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431054, XrefRangeEnd = 431056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_ssl_ctx_free(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSslCtx.NativeMethodInfoPtr_mono_btls_ssl_ctx_free_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00028C04 File Offset: 0x00026E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431056, XrefRangeEnd = 431058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void mono_btls_ssl_ctx_initialize(IntPtr handle, IntPtr instance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSslCtx.NativeMethodInfoPtr_mono_btls_ssl_ctx_initialize_Private_Static_Void_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00028C44 File Offset: 0x00026E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431058, XrefRangeEnd = 431060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void mono_btls_ssl_ctx_set_cert_verify_callback(IntPtr handle, IntPtr func, int cert_required)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref func;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cert_required;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSslCtx.NativeMethodInfoPtr_mono_btls_ssl_ctx_set_cert_verify_callback_Private_Static_Void_IntPtr_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00028C94 File Offset: 0x00026E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431060, XrefRangeEnd = 431062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void mono_btls_ssl_ctx_set_cert_select_callback(IntPtr handle, IntPtr func)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref func;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSslCtx.NativeMethodInfoPtr_mono_btls_ssl_ctx_set_cert_select_callback_Private_Static_Void_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00028CD4 File Offset: 0x00026ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431062, XrefRangeEnd = 431064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void mono_btls_ssl_ctx_set_min_version(IntPtr handle, int version)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref version;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSslCtx.NativeMethodInfoPtr_mono_btls_ssl_ctx_set_min_version_Private_Static_Void_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00028D14 File Offset: 0x00026F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431064, XrefRangeEnd = 431066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void mono_btls_ssl_ctx_set_max_version(IntPtr handle, int version)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref version;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSslCtx.NativeMethodInfoPtr_mono_btls_ssl_ctx_set_max_version_Private_Static_Void_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00028D54 File Offset: 0x00026F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431066, XrefRangeEnd = 431068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_ssl_ctx_set_ciphers(IntPtr handle, int count, IntPtr data, int allow_unsupported)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allow_unsupported;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSslCtx.NativeMethodInfoPtr_mono_btls_ssl_ctx_set_ciphers_Private_Static_Int32_IntPtr_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00028DBC File Offset: 0x00026FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431068, XrefRangeEnd = 431070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_ssl_ctx_set_verify_param(IntPtr handle, IntPtr param)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref param;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSslCtx.NativeMethodInfoPtr_mono_btls_ssl_ctx_set_verify_param_Private_Static_Int32_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00028E08 File Offset: 0x00027008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431070, XrefRangeEnd = 431072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_ssl_ctx_set_client_ca_list(IntPtr handle, int count, IntPtr sizes, IntPtr data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizes;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSslCtx.NativeMethodInfoPtr_mono_btls_ssl_ctx_set_client_ca_list_Private_Static_Int32_IntPtr_Int32_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00028E70 File Offset: 0x00027070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431072, XrefRangeEnd = 431074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void mono_btls_ssl_ctx_set_server_name_callback(IntPtr handle, IntPtr func)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref func;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSslCtx.NativeMethodInfoPtr_mono_btls_ssl_ctx_set_server_name_callback_Private_Static_Void_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00028EB0 File Offset: 0x000270B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 431081, RefRangeEnd = 431082, XrefRangeStart = 431074, XrefRangeEnd = 431081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsSslCtx()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSslCtx.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00028EEC File Offset: 0x000270EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 431151, RefRangeEnd = 431152, XrefRangeStart = 431082, XrefRangeEnd = 431151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsSslCtx(MonoBtlsSslCtx.BoringSslCtxHandle handle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSslCtx.NativeMethodInfoPtr__ctor_Internal_Void_BoringSslCtxHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x0600036C RID: 876 RVA: 0x00028F38 File Offset: 0x00027138
		public unsafe MonoBtlsX509Store CertificateStore
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSslCtx.NativeMethodInfoPtr_get_CertificateStore_Public_get_MonoBtlsX509Store_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509Store>(intPtr3) : null;
			}
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00028F78 File Offset: 0x00027178
		[CallerCount(0)]
		public unsafe int VerifyCallback(bool preverify_ok, MonoBtlsX509StoreCtx ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref preverify_ok;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ctx);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSslCtx.NativeMethodInfoPtr_VerifyCallback_Private_Int32_Boolean_MonoBtlsX509StoreCtx_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00028FD4 File Offset: 0x000271D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431152, XrefRangeEnd = 431174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int NativeVerifyCallback(IntPtr instance, int preverify_ok, IntPtr store_ctx)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instance;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preverify_ok;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref store_ctx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSslCtx.NativeMethodInfoPtr_NativeVerifyCallback_Private_Static_Int32_IntPtr_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00029030 File Offset: 0x00027230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431174, XrefRangeEnd = 431182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int NativeSelectCallback(IntPtr instance, int count, IntPtr sizes, IntPtr data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instance;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizes;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSslCtx.NativeMethodInfoPtr_NativeSelectCallback_Private_Static_Int32_IntPtr_Int32_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00029098 File Offset: 0x00027298
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 431231, RefRangeEnd = 431232, XrefRangeStart = 431182, XrefRangeEnd = 431231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray CopyIssuers(int count, IntPtr sizesPtr, IntPtr dataPtr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizesPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSslCtx.NativeMethodInfoPtr_CopyIssuers_Private_Static_Il2CppStringArray_Int32_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06000371 RID: 881 RVA: 0x000290F4 File Offset: 0x000272F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 431237, RefRangeEnd = 431238, XrefRangeStart = 431232, XrefRangeEnd = 431237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVerifyCallback(MonoBtlsVerifyCallback callback, bool client_cert_required)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref client_cert_required;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSslCtx.NativeMethodInfoPtr_SetVerifyCallback_Public_Void_MonoBtlsVerifyCallback_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00029144 File Offset: 0x00027344
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 431243, RefRangeEnd = 431244, XrefRangeStart = 431238, XrefRangeEnd = 431243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelectCallback(MonoBtlsSelectCallback callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSslCtx.NativeMethodInfoPtr_SetSelectCallback_Public_Void_MonoBtlsSelectCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00029188 File Offset: 0x00027388
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 431248, RefRangeEnd = 431249, XrefRangeStart = 431244, XrefRangeEnd = 431248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMinVersion(int version)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref version;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSslCtx.NativeMethodInfoPtr_SetMinVersion_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000374 RID: 884 RVA: 0x000291C8 File Offset: 0x000273C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 431253, RefRangeEnd = 431254, XrefRangeStart = 431249, XrefRangeEnd = 431253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaxVersion(int version)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref version;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSslCtx.NativeMethodInfoPtr_SetMaxVersion_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00029208 File Offset: 0x00027408
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 431275, RefRangeEnd = 431276, XrefRangeStart = 431254, XrefRangeEnd = 431275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCiphers(Il2CppStructArray<short> ciphers, bool allow_unsupported)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ciphers);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allow_unsupported;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSslCtx.NativeMethodInfoPtr_SetCiphers_Public_Void_Il2CppStructArray_1_Int16_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00029258 File Offset: 0x00027458
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 431285, RefRangeEnd = 431286, XrefRangeStart = 431276, XrefRangeEnd = 431285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVerifyParam(MonoBtlsX509VerifyParam param)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(param);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSslCtx.NativeMethodInfoPtr_SetVerifyParam_Public_Void_MonoBtlsX509VerifyParam_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000377 RID: 887 RVA: 0x0002929C File Offset: 0x0002749C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 431323, RefRangeEnd = 431324, XrefRangeStart = 431286, XrefRangeEnd = 431323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetClientCertificateIssuers(Il2CppStringArray acceptableIssuers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(acceptableIssuers);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSslCtx.NativeMethodInfoPtr_SetClientCertificateIssuers_Public_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000378 RID: 888 RVA: 0x000292E0 File Offset: 0x000274E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 431329, RefRangeEnd = 431330, XrefRangeStart = 431324, XrefRangeEnd = 431329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetServerNameCallback(MonoBtlsServerNameCallback callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSslCtx.NativeMethodInfoPtr_SetServerNameCallback_Public_Void_MonoBtlsServerNameCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00029324 File Offset: 0x00027524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431330, XrefRangeEnd = 431336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int NativeServerNameCallback(IntPtr instance)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instance;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSslCtx.NativeMethodInfoPtr_NativeServerNameCallback_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00029364 File Offset: 0x00027564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431336, XrefRangeEnd = 431341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsSslCtx.NativeMethodInfoPtr_Close_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600037B RID: 891 RVA: 0x000031AF File Offset: 0x000013AF
		public MonoBtlsSslCtx(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600037C RID: 892 RVA: 0x000293A0 File Offset: 0x000275A0
		// (set) Token: 0x0600037D RID: 893 RVA: 0x000031B8 File Offset: 0x000013B8
		public unsafe MonoBtlsSslCtx.NativeVerifyFunc verifyFunc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsSslCtx.NativeFieldInfoPtr_verifyFunc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoBtlsSslCtx.NativeVerifyFunc>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsSslCtx.NativeFieldInfoPtr_verifyFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600037E RID: 894 RVA: 0x000293D0 File Offset: 0x000275D0
		// (set) Token: 0x0600037F RID: 895 RVA: 0x000031D7 File Offset: 0x000013D7
		public unsafe MonoBtlsSslCtx.NativeSelectFunc selectFunc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsSslCtx.NativeFieldInfoPtr_selectFunc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoBtlsSslCtx.NativeSelectFunc>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsSslCtx.NativeFieldInfoPtr_selectFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000380 RID: 896 RVA: 0x00029400 File Offset: 0x00027600
		// (set) Token: 0x06000381 RID: 897 RVA: 0x000031F6 File Offset: 0x000013F6
		public unsafe MonoBtlsSslCtx.NativeServerNameFunc serverNameFunc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsSslCtx.NativeFieldInfoPtr_serverNameFunc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoBtlsSslCtx.NativeServerNameFunc>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsSslCtx.NativeFieldInfoPtr_serverNameFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000382 RID: 898 RVA: 0x00029430 File Offset: 0x00027630
		// (set) Token: 0x06000383 RID: 899 RVA: 0x00003215 File Offset: 0x00001415
		public unsafe IntPtr verifyFuncPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsSslCtx.NativeFieldInfoPtr_verifyFuncPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsSslCtx.NativeFieldInfoPtr_verifyFuncPtr)) = value;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000384 RID: 900 RVA: 0x00029458 File Offset: 0x00027658
		// (set) Token: 0x06000385 RID: 901 RVA: 0x00003230 File Offset: 0x00001430
		public unsafe IntPtr selectFuncPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsSslCtx.NativeFieldInfoPtr_selectFuncPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsSslCtx.NativeFieldInfoPtr_selectFuncPtr)) = value;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000386 RID: 902 RVA: 0x00029480 File Offset: 0x00027680
		// (set) Token: 0x06000387 RID: 903 RVA: 0x0000324B File Offset: 0x0000144B
		public unsafe IntPtr serverNameFuncPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsSslCtx.NativeFieldInfoPtr_serverNameFuncPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsSslCtx.NativeFieldInfoPtr_serverNameFuncPtr)) = value;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000388 RID: 904 RVA: 0x000294A8 File Offset: 0x000276A8
		// (set) Token: 0x06000389 RID: 905 RVA: 0x00003266 File Offset: 0x00001466
		public unsafe MonoBtlsVerifyCallback verifyCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsSslCtx.NativeFieldInfoPtr_verifyCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoBtlsVerifyCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsSslCtx.NativeFieldInfoPtr_verifyCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x0600038A RID: 906 RVA: 0x000294D8 File Offset: 0x000276D8
		// (set) Token: 0x0600038B RID: 907 RVA: 0x00003285 File Offset: 0x00001485
		public unsafe MonoBtlsSelectCallback selectCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsSslCtx.NativeFieldInfoPtr_selectCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoBtlsSelectCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsSslCtx.NativeFieldInfoPtr_selectCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600038C RID: 908 RVA: 0x00029508 File Offset: 0x00027708
		// (set) Token: 0x0600038D RID: 909 RVA: 0x000032A4 File Offset: 0x000014A4
		public unsafe MonoBtlsServerNameCallback serverNameCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsSslCtx.NativeFieldInfoPtr_serverNameCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoBtlsServerNameCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsSslCtx.NativeFieldInfoPtr_serverNameCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x0600038E RID: 910 RVA: 0x00029538 File Offset: 0x00027738
		// (set) Token: 0x0600038F RID: 911 RVA: 0x000032C3 File Offset: 0x000014C3
		public unsafe MonoBtlsX509Store store
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsSslCtx.NativeFieldInfoPtr_store);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509Store>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsSslCtx.NativeFieldInfoPtr_store), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000390 RID: 912 RVA: 0x00029568 File Offset: 0x00027768
		// (set) Token: 0x06000391 RID: 913 RVA: 0x000032E2 File Offset: 0x000014E2
		public unsafe GCHandle instance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsSslCtx.NativeFieldInfoPtr_instance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsSslCtx.NativeFieldInfoPtr_instance)) = value;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000392 RID: 914 RVA: 0x00029590 File Offset: 0x00027790
		// (set) Token: 0x06000393 RID: 915 RVA: 0x000032FD File Offset: 0x000014FD
		public unsafe IntPtr instancePtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsSslCtx.NativeFieldInfoPtr_instancePtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsSslCtx.NativeFieldInfoPtr_instancePtr)) = value;
			}
		}

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeFieldInfoPtr_verifyFunc;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeFieldInfoPtr_selectFunc;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeFieldInfoPtr_serverNameFunc;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeFieldInfoPtr_verifyFuncPtr;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeFieldInfoPtr_selectFuncPtr;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeFieldInfoPtr_serverNameFuncPtr;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeFieldInfoPtr_verifyCallback;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeFieldInfoPtr_selectCallback;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeFieldInfoPtr_serverNameCallback;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeFieldInfoPtr_store;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeFieldInfoPtr_instance;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeFieldInfoPtr_instancePtr;

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Internal_get_BoringSslCtxHandle_0;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_ssl_ctx_new_Private_Static_IntPtr_0;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_ssl_ctx_free_Private_Static_Int32_IntPtr_0;

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_ssl_ctx_initialize_Private_Static_Void_IntPtr_IntPtr_0;

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_ssl_ctx_set_cert_verify_callback_Private_Static_Void_IntPtr_IntPtr_Int32_0;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_ssl_ctx_set_cert_select_callback_Private_Static_Void_IntPtr_IntPtr_0;

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_ssl_ctx_set_min_version_Private_Static_Void_IntPtr_Int32_0;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_ssl_ctx_set_max_version_Private_Static_Void_IntPtr_Int32_0;

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_ssl_ctx_set_ciphers_Private_Static_Int32_IntPtr_Int32_IntPtr_Int32_0;

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_ssl_ctx_set_verify_param_Private_Static_Int32_IntPtr_IntPtr_0;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_ssl_ctx_set_client_ca_list_Private_Static_Int32_IntPtr_Int32_IntPtr_IntPtr_0;

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_ssl_ctx_set_server_name_callback_Private_Static_Void_IntPtr_IntPtr_0;

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BoringSslCtxHandle_0;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeMethodInfoPtr_get_CertificateStore_Public_get_MonoBtlsX509Store_0;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeMethodInfoPtr_VerifyCallback_Private_Int32_Boolean_MonoBtlsX509StoreCtx_0;

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeMethodInfoPtr_NativeVerifyCallback_Private_Static_Int32_IntPtr_Int32_IntPtr_0;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeMethodInfoPtr_NativeSelectCallback_Private_Static_Int32_IntPtr_Int32_IntPtr_IntPtr_0;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeMethodInfoPtr_CopyIssuers_Private_Static_Il2CppStringArray_Int32_IntPtr_IntPtr_0;

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeMethodInfoPtr_SetVerifyCallback_Public_Void_MonoBtlsVerifyCallback_Boolean_0;

		// Token: 0x0400028C RID: 652
		private static readonly IntPtr NativeMethodInfoPtr_SetSelectCallback_Public_Void_MonoBtlsSelectCallback_0;

		// Token: 0x0400028D RID: 653
		private static readonly IntPtr NativeMethodInfoPtr_SetMinVersion_Public_Void_Int32_0;

		// Token: 0x0400028E RID: 654
		private static readonly IntPtr NativeMethodInfoPtr_SetMaxVersion_Public_Void_Int32_0;

		// Token: 0x0400028F RID: 655
		private static readonly IntPtr NativeMethodInfoPtr_SetCiphers_Public_Void_Il2CppStructArray_1_Int16_Boolean_0;

		// Token: 0x04000290 RID: 656
		private static readonly IntPtr NativeMethodInfoPtr_SetVerifyParam_Public_Void_MonoBtlsX509VerifyParam_0;

		// Token: 0x04000291 RID: 657
		private static readonly IntPtr NativeMethodInfoPtr_SetClientCertificateIssuers_Public_Void_Il2CppStringArray_0;

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeMethodInfoPtr_SetServerNameCallback_Public_Void_MonoBtlsServerNameCallback_0;

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeMethodInfoPtr_NativeServerNameCallback_Private_Static_Int32_IntPtr_0;

		// Token: 0x04000294 RID: 660
		private static readonly IntPtr NativeMethodInfoPtr_Close_Protected_Virtual_Void_0;

		// Token: 0x020002B1 RID: 689
		public class BoringSslCtxHandle : MonoBtlsObject.MonoBtlsHandle
		{
			// Token: 0x06002AF5 RID: 10997 RVA: 0x00013232 File Offset: 0x00011432
			// Note: this type is marked as 'beforefieldinit'.
			static BoringSslCtxHandle()
			{
				Il2CppClassPointerStore<MonoBtlsSslCtx.BoringSslCtxHandle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, "BoringSslCtxHandle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsSslCtx.BoringSslCtxHandle>.NativeClassPtr);
				MonoBtlsSslCtx.BoringSslCtxHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSslCtx.BoringSslCtxHandle>.NativeClassPtr, 100663932);
			}

			// Token: 0x06002AF6 RID: 10998 RVA: 0x000BF60C File Offset: 0x000BD80C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431028, XrefRangeEnd = 431030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool ReleaseHandle()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsSslCtx.BoringSslCtxHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002AF7 RID: 10999 RVA: 0x00013266 File Offset: 0x00011466
			public BoringSslCtxHandle(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040021CE RID: 8654
			private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0;
		}

		// Token: 0x020002B2 RID: 690
		public sealed class NativeVerifyFunc : MulticastDelegate
		{
			// Token: 0x06002AF8 RID: 11000 RVA: 0x0001326F File Offset: 0x0001146F
			// Note: this type is marked as 'beforefieldinit'.
			static NativeVerifyFunc()
			{
				Il2CppClassPointerStore<MonoBtlsSslCtx.NativeVerifyFunc>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, "NativeVerifyFunc");
				MonoBtlsSslCtx.NativeVerifyFunc.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSslCtx.NativeVerifyFunc>.NativeClassPtr, 100663933);
				MonoBtlsSslCtx.NativeVerifyFunc.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSslCtx.NativeVerifyFunc>.NativeClassPtr, 100663934);
			}

			// Token: 0x06002AF9 RID: 11001 RVA: 0x000BF654 File Offset: 0x000BD854
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431030, XrefRangeEnd = 431033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NativeVerifyFunc(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsSslCtx.NativeVerifyFunc>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSslCtx.NativeVerifyFunc.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002AFA RID: 11002 RVA: 0x000BF6B0 File Offset: 0x000BD8B0
			[CallerCount(0)]
			public unsafe int Invoke(IntPtr instance, int preverify_ok, IntPtr ctx)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref instance;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preverify_ok;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ctx;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSslCtx.NativeVerifyFunc.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_Int32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002AFB RID: 11003 RVA: 0x000132AD File Offset: 0x000114AD
			public NativeVerifyFunc(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002AFC RID: 11004 RVA: 0x000132B6 File Offset: 0x000114B6
			public static implicit operator MonoBtlsSslCtx.NativeVerifyFunc(Func<IntPtr, int, IntPtr, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<MonoBtlsSslCtx.NativeVerifyFunc>(A_0);
			}

			// Token: 0x06002AFD RID: 11005 RVA: 0x000132BE File Offset: 0x000114BE
			public static MonoBtlsSslCtx.NativeVerifyFunc operator +(MonoBtlsSslCtx.NativeVerifyFunc A_0, MonoBtlsSslCtx.NativeVerifyFunc A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<MonoBtlsSslCtx.NativeVerifyFunc>();
			}

			// Token: 0x06002AFE RID: 11006 RVA: 0x000132CC File Offset: 0x000114CC
			public static MonoBtlsSslCtx.NativeVerifyFunc operator -(MonoBtlsSslCtx.NativeVerifyFunc A_0, MonoBtlsSslCtx.NativeVerifyFunc A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<MonoBtlsSslCtx.NativeVerifyFunc>();
				}
				return delegate2;
			}

			// Token: 0x040021CF RID: 8655
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040021D0 RID: 8656
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_Int32_IntPtr_0;
		}

		// Token: 0x020002B3 RID: 691
		public sealed class NativeSelectFunc : MulticastDelegate
		{
			// Token: 0x06002AFF RID: 11007 RVA: 0x000132DD File Offset: 0x000114DD
			// Note: this type is marked as 'beforefieldinit'.
			static NativeSelectFunc()
			{
				Il2CppClassPointerStore<MonoBtlsSslCtx.NativeSelectFunc>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, "NativeSelectFunc");
				MonoBtlsSslCtx.NativeSelectFunc.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSslCtx.NativeSelectFunc>.NativeClassPtr, 100663935);
				MonoBtlsSslCtx.NativeSelectFunc.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_Int32_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSslCtx.NativeSelectFunc>.NativeClassPtr, 100663936);
			}

			// Token: 0x06002B00 RID: 11008 RVA: 0x000BF718 File Offset: 0x000BD918
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431033, XrefRangeEnd = 431036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NativeSelectFunc(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsSslCtx.NativeSelectFunc>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSslCtx.NativeSelectFunc.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B01 RID: 11009 RVA: 0x000BF774 File Offset: 0x000BD974
			[CallerCount(0)]
			public unsafe int Invoke(IntPtr instance, int count, IntPtr sizes, IntPtr data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref instance;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizes;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSslCtx.NativeSelectFunc.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_Int32_IntPtr_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002B02 RID: 11010 RVA: 0x0001331B File Offset: 0x0001151B
			public NativeSelectFunc(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002B03 RID: 11011 RVA: 0x00013324 File Offset: 0x00011524
			public static implicit operator MonoBtlsSslCtx.NativeSelectFunc(Func<IntPtr, int, IntPtr, IntPtr, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<MonoBtlsSslCtx.NativeSelectFunc>(A_0);
			}

			// Token: 0x06002B04 RID: 11012 RVA: 0x0001332C File Offset: 0x0001152C
			public static MonoBtlsSslCtx.NativeSelectFunc operator +(MonoBtlsSslCtx.NativeSelectFunc A_0, MonoBtlsSslCtx.NativeSelectFunc A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<MonoBtlsSslCtx.NativeSelectFunc>();
			}

			// Token: 0x06002B05 RID: 11013 RVA: 0x0001333A File Offset: 0x0001153A
			public static MonoBtlsSslCtx.NativeSelectFunc operator -(MonoBtlsSslCtx.NativeSelectFunc A_0, MonoBtlsSslCtx.NativeSelectFunc A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<MonoBtlsSslCtx.NativeSelectFunc>();
				}
				return delegate2;
			}

			// Token: 0x040021D1 RID: 8657
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040021D2 RID: 8658
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_Int32_IntPtr_IntPtr_0;
		}

		// Token: 0x020002B4 RID: 692
		public sealed class NativeServerNameFunc : MulticastDelegate
		{
			// Token: 0x06002B06 RID: 11014 RVA: 0x0001334B File Offset: 0x0001154B
			// Note: this type is marked as 'beforefieldinit'.
			static NativeServerNameFunc()
			{
				Il2CppClassPointerStore<MonoBtlsSslCtx.NativeServerNameFunc>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoBtlsSslCtx>.NativeClassPtr, "NativeServerNameFunc");
				MonoBtlsSslCtx.NativeServerNameFunc.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSslCtx.NativeServerNameFunc>.NativeClassPtr, 100663937);
				MonoBtlsSslCtx.NativeServerNameFunc.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSslCtx.NativeServerNameFunc>.NativeClassPtr, 100663938);
			}

			// Token: 0x06002B07 RID: 11015 RVA: 0x000BF7E8 File Offset: 0x000BD9E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431036, XrefRangeEnd = 431039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NativeServerNameFunc(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsSslCtx.NativeServerNameFunc>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSslCtx.NativeServerNameFunc.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B08 RID: 11016 RVA: 0x000BF844 File Offset: 0x000BDA44
			[CallerCount(0)]
			public unsafe int Invoke(IntPtr instance)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref instance;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSslCtx.NativeServerNameFunc.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002B09 RID: 11017 RVA: 0x00013389 File Offset: 0x00011589
			public NativeServerNameFunc(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002B0A RID: 11018 RVA: 0x00013392 File Offset: 0x00011592
			public static implicit operator MonoBtlsSslCtx.NativeServerNameFunc(Func<IntPtr, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<MonoBtlsSslCtx.NativeServerNameFunc>(A_0);
			}

			// Token: 0x06002B0B RID: 11019 RVA: 0x0001339A File Offset: 0x0001159A
			public static MonoBtlsSslCtx.NativeServerNameFunc operator +(MonoBtlsSslCtx.NativeServerNameFunc A_0, MonoBtlsSslCtx.NativeServerNameFunc A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<MonoBtlsSslCtx.NativeServerNameFunc>();
			}

			// Token: 0x06002B0C RID: 11020 RVA: 0x000133A8 File Offset: 0x000115A8
			public static MonoBtlsSslCtx.NativeServerNameFunc operator -(MonoBtlsSslCtx.NativeServerNameFunc A_0, MonoBtlsSslCtx.NativeServerNameFunc A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<MonoBtlsSslCtx.NativeServerNameFunc>();
				}
				return delegate2;
			}

			// Token: 0x040021D3 RID: 8659
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040021D4 RID: 8660
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_0;
		}
	}
}
