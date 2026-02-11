using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Btls
{
	// Token: 0x02000047 RID: 71
	public class MonoBtlsX509StoreCtx : MonoBtlsObject
	{
		// Token: 0x0600041E RID: 1054 RVA: 0x0002BC54 File Offset: 0x00029E54
		// Note: this type is marked as 'beforefieldinit'.
		static MonoBtlsX509StoreCtx()
		{
			Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Btls", "MonoBtlsX509StoreCtx");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr);
			MonoBtlsX509StoreCtx.NativeFieldInfoPtr_verifyResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, "verifyResult");
			MonoBtlsX509StoreCtx.NativeMethodInfoPtr_get_Handle_Internal_get_BoringX509StoreCtxHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664047);
			MonoBtlsX509StoreCtx.NativeMethodInfoPtr_mono_btls_x509_store_ctx_new_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664048);
			MonoBtlsX509StoreCtx.NativeMethodInfoPtr_mono_btls_x509_store_ctx_from_ptr_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664049);
			MonoBtlsX509StoreCtx.NativeMethodInfoPtr_mono_btls_x509_store_ctx_get_error_Private_Static_MonoBtlsX509Error_IntPtr_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664050);
			MonoBtlsX509StoreCtx.NativeMethodInfoPtr_mono_btls_x509_store_ctx_get_chain_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664051);
			MonoBtlsX509StoreCtx.NativeMethodInfoPtr_mono_btls_x509_store_ctx_init_Private_Static_Int32_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664052);
			MonoBtlsX509StoreCtx.NativeMethodInfoPtr_mono_btls_x509_store_ctx_set_param_Private_Static_Int32_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664053);
			MonoBtlsX509StoreCtx.NativeMethodInfoPtr_mono_btls_x509_store_ctx_verify_cert_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664054);
			MonoBtlsX509StoreCtx.NativeMethodInfoPtr_mono_btls_x509_store_ctx_get_untrusted_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664055);
			MonoBtlsX509StoreCtx.NativeMethodInfoPtr_mono_btls_x509_store_ctx_up_ref_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664056);
			MonoBtlsX509StoreCtx.NativeMethodInfoPtr_mono_btls_x509_store_ctx_free_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664057);
			MonoBtlsX509StoreCtx.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664058);
			MonoBtlsX509StoreCtx.NativeMethodInfoPtr_Create_internal_Private_Static_BoringX509StoreCtxHandle_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664059);
			MonoBtlsX509StoreCtx.NativeMethodInfoPtr__ctor_Internal_Void_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664060);
			MonoBtlsX509StoreCtx.NativeMethodInfoPtr__ctor_Internal_Void_BoringX509StoreCtxHandle_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664061);
			MonoBtlsX509StoreCtx.NativeMethodInfoPtr_GetError_Public_MonoBtlsX509Error_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664062);
			MonoBtlsX509StoreCtx.NativeMethodInfoPtr_GetChain_Public_MonoBtlsX509Chain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664063);
			MonoBtlsX509StoreCtx.NativeMethodInfoPtr_GetUntrusted_Public_MonoBtlsX509Chain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664064);
			MonoBtlsX509StoreCtx.NativeMethodInfoPtr_Initialize_Public_Void_MonoBtlsX509Store_MonoBtlsX509Chain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664065);
			MonoBtlsX509StoreCtx.NativeMethodInfoPtr_SetVerifyParam_Public_Void_MonoBtlsX509VerifyParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664066);
			MonoBtlsX509StoreCtx.NativeMethodInfoPtr_get_VerifyResult_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664067);
			MonoBtlsX509StoreCtx.NativeMethodInfoPtr_Verify_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664068);
			MonoBtlsX509StoreCtx.NativeMethodInfoPtr_Copy_Public_MonoBtlsX509StoreCtx_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664069);
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x0600041F RID: 1055 RVA: 0x0002BE64 File Offset: 0x0002A064
		public new unsafe MonoBtlsX509StoreCtx.BoringX509StoreCtxHandle Handle
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 432262, RefRangeEnd = 432272, XrefRangeStart = 432259, XrefRangeEnd = 432262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509StoreCtx.NativeMethodInfoPtr_get_Handle_Internal_get_BoringX509StoreCtxHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509StoreCtx.BoringX509StoreCtxHandle>(intPtr3) : null;
			}
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x0002BEA4 File Offset: 0x0002A0A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432272, XrefRangeEnd = 432274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr mono_btls_x509_store_ctx_new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509StoreCtx.NativeMethodInfoPtr_mono_btls_x509_store_ctx_new_Private_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0002BED4 File Offset: 0x0002A0D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432274, XrefRangeEnd = 432276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr mono_btls_x509_store_ctx_from_ptr(IntPtr ctx)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ctx;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509StoreCtx.NativeMethodInfoPtr_mono_btls_x509_store_ctx_from_ptr_Private_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x0002BF14 File Offset: 0x0002A114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432276, XrefRangeEnd = 432278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoBtlsX509Error mono_btls_x509_store_ctx_get_error(IntPtr handle, out IntPtr error_string)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error_string;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509StoreCtx.NativeMethodInfoPtr_mono_btls_x509_store_ctx_get_error_Private_Static_MonoBtlsX509Error_IntPtr_byref_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x0002BF60 File Offset: 0x0002A160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432278, XrefRangeEnd = 432280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr mono_btls_x509_store_ctx_get_chain(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509StoreCtx.NativeMethodInfoPtr_mono_btls_x509_store_ctx_get_chain_Private_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0002BFA0 File Offset: 0x0002A1A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432280, XrefRangeEnd = 432282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_x509_store_ctx_init(IntPtr handle, IntPtr store, IntPtr chain)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref store;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref chain;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509StoreCtx.NativeMethodInfoPtr_mono_btls_x509_store_ctx_init_Private_Static_Int32_IntPtr_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0002BFFC File Offset: 0x0002A1FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432282, XrefRangeEnd = 432284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_x509_store_ctx_set_param(IntPtr handle, IntPtr param)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref param;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509StoreCtx.NativeMethodInfoPtr_mono_btls_x509_store_ctx_set_param_Private_Static_Int32_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0002C048 File Offset: 0x0002A248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432284, XrefRangeEnd = 432286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_x509_store_ctx_verify_cert(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509StoreCtx.NativeMethodInfoPtr_mono_btls_x509_store_ctx_verify_cert_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x0002C088 File Offset: 0x0002A288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432286, XrefRangeEnd = 432288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr mono_btls_x509_store_ctx_get_untrusted(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509StoreCtx.NativeMethodInfoPtr_mono_btls_x509_store_ctx_get_untrusted_Private_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x0002C0C8 File Offset: 0x0002A2C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432288, XrefRangeEnd = 432290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr mono_btls_x509_store_ctx_up_ref(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509StoreCtx.NativeMethodInfoPtr_mono_btls_x509_store_ctx_up_ref_Private_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0002C108 File Offset: 0x0002A308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432290, XrefRangeEnd = 432292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void mono_btls_x509_store_ctx_free(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509StoreCtx.NativeMethodInfoPtr_mono_btls_x509_store_ctx_free_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x0002C13C File Offset: 0x0002A33C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 432299, RefRangeEnd = 432300, XrefRangeStart = 432292, XrefRangeEnd = 432299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsX509StoreCtx()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509StoreCtx.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x0002C178 File Offset: 0x0002A378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432300, XrefRangeEnd = 432307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoBtlsX509StoreCtx.BoringX509StoreCtxHandle Create_internal(IntPtr store_ctx)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref store_ctx;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509StoreCtx.NativeMethodInfoPtr_Create_internal_Private_Static_BoringX509StoreCtxHandle_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509StoreCtx.BoringX509StoreCtxHandle>(intPtr3) : null;
			}
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x0002C1B8 File Offset: 0x0002A3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432307, XrefRangeEnd = 432318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsX509StoreCtx(int preverify_ok, IntPtr store_ctx)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref preverify_ok;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref store_ctx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509StoreCtx.NativeMethodInfoPtr__ctor_Internal_Void_Int32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x0002C210 File Offset: 0x0002A410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432318, XrefRangeEnd = 432319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsX509StoreCtx(MonoBtlsX509StoreCtx.BoringX509StoreCtxHandle ptr, Nullable<int> verifyResult)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr))
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = IL2CPP.Il2CppObjectBaseToPtr(ptr);
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(verifyResult));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509StoreCtx.NativeMethodInfoPtr__ctor_Internal_Void_BoringX509StoreCtxHandle_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x0002C274 File Offset: 0x0002A474
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 432322, RefRangeEnd = 432323, XrefRangeStart = 432319, XrefRangeEnd = 432322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsX509Error GetError()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509StoreCtx.NativeMethodInfoPtr_GetError_Public_MonoBtlsX509Error_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0002C2B0 File Offset: 0x0002A4B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432323, XrefRangeEnd = 432338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsX509Chain GetChain()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509StoreCtx.NativeMethodInfoPtr_GetChain_Public_MonoBtlsX509Chain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509Chain>(intPtr3) : null;
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x0002C2F0 File Offset: 0x0002A4F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432338, XrefRangeEnd = 432353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsX509Chain GetUntrusted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509StoreCtx.NativeMethodInfoPtr_GetUntrusted_Public_MonoBtlsX509Chain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509Chain>(intPtr3) : null;
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x0002C330 File Offset: 0x0002A530
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 432362, RefRangeEnd = 432363, XrefRangeStart = 432353, XrefRangeEnd = 432362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(MonoBtlsX509Store store, MonoBtlsX509Chain chain)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(store);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chain);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509StoreCtx.NativeMethodInfoPtr_Initialize_Public_Void_MonoBtlsX509Store_MonoBtlsX509Chain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x0002C384 File Offset: 0x0002A584
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 432371, RefRangeEnd = 432372, XrefRangeStart = 432363, XrefRangeEnd = 432371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVerifyParam(MonoBtlsX509VerifyParam param)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(param);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509StoreCtx.NativeMethodInfoPtr_SetVerifyParam_Public_Void_MonoBtlsX509VerifyParam_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x0002C3C8 File Offset: 0x0002A5C8
		public unsafe int VerifyResult
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432372, XrefRangeEnd = 432381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509StoreCtx.NativeMethodInfoPtr_get_VerifyResult_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x0002C404 File Offset: 0x0002A604
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 432390, RefRangeEnd = 432391, XrefRangeStart = 432381, XrefRangeEnd = 432390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Verify()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509StoreCtx.NativeMethodInfoPtr_Verify_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0002C440 File Offset: 0x0002A640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432391, XrefRangeEnd = 432406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsX509StoreCtx Copy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509StoreCtx.NativeMethodInfoPtr_Copy_Public_MonoBtlsX509StoreCtx_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509StoreCtx>(intPtr3) : null;
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x000034FA File Offset: 0x000016FA
		public MonoBtlsX509StoreCtx(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x0002C480 File Offset: 0x0002A680
		// (set) Token: 0x06000438 RID: 1080 RVA: 0x00003503 File Offset: 0x00001703
		public Nullable<int> verifyResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsX509StoreCtx.NativeFieldInfoPtr_verifyResult);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsX509StoreCtx.NativeFieldInfoPtr_verifyResult), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000370 RID: 880
		private static readonly IntPtr NativeFieldInfoPtr_verifyResult;

		// Token: 0x04000371 RID: 881
		private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Internal_get_BoringX509StoreCtxHandle_0;

		// Token: 0x04000372 RID: 882
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_store_ctx_new_Private_Static_IntPtr_0;

		// Token: 0x04000373 RID: 883
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_store_ctx_from_ptr_Private_Static_IntPtr_IntPtr_0;

		// Token: 0x04000374 RID: 884
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_store_ctx_get_error_Private_Static_MonoBtlsX509Error_IntPtr_byref_IntPtr_0;

		// Token: 0x04000375 RID: 885
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_store_ctx_get_chain_Private_Static_IntPtr_IntPtr_0;

		// Token: 0x04000376 RID: 886
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_store_ctx_init_Private_Static_Int32_IntPtr_IntPtr_IntPtr_0;

		// Token: 0x04000377 RID: 887
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_store_ctx_set_param_Private_Static_Int32_IntPtr_IntPtr_0;

		// Token: 0x04000378 RID: 888
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_store_ctx_verify_cert_Private_Static_Int32_IntPtr_0;

		// Token: 0x04000379 RID: 889
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_store_ctx_get_untrusted_Private_Static_IntPtr_IntPtr_0;

		// Token: 0x0400037A RID: 890
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_store_ctx_up_ref_Private_Static_IntPtr_IntPtr_0;

		// Token: 0x0400037B RID: 891
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_store_ctx_free_Private_Static_Void_IntPtr_0;

		// Token: 0x0400037C RID: 892
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x0400037D RID: 893
		private static readonly IntPtr NativeMethodInfoPtr_Create_internal_Private_Static_BoringX509StoreCtxHandle_IntPtr_0;

		// Token: 0x0400037E RID: 894
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_IntPtr_0;

		// Token: 0x0400037F RID: 895
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BoringX509StoreCtxHandle_Nullable_1_Int32_0;

		// Token: 0x04000380 RID: 896
		private static readonly IntPtr NativeMethodInfoPtr_GetError_Public_MonoBtlsX509Error_0;

		// Token: 0x04000381 RID: 897
		private static readonly IntPtr NativeMethodInfoPtr_GetChain_Public_MonoBtlsX509Chain_0;

		// Token: 0x04000382 RID: 898
		private static readonly IntPtr NativeMethodInfoPtr_GetUntrusted_Public_MonoBtlsX509Chain_0;

		// Token: 0x04000383 RID: 899
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_MonoBtlsX509Store_MonoBtlsX509Chain_0;

		// Token: 0x04000384 RID: 900
		private static readonly IntPtr NativeMethodInfoPtr_SetVerifyParam_Public_Void_MonoBtlsX509VerifyParam_0;

		// Token: 0x04000385 RID: 901
		private static readonly IntPtr NativeMethodInfoPtr_get_VerifyResult_Public_get_Int32_0;

		// Token: 0x04000386 RID: 902
		private static readonly IntPtr NativeMethodInfoPtr_Verify_Public_Int32_0;

		// Token: 0x04000387 RID: 903
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_MonoBtlsX509StoreCtx_0;

		// Token: 0x020002BC RID: 700
		public class BoringX509StoreCtxHandle : MonoBtlsObject.MonoBtlsHandle
		{
			// Token: 0x06002B27 RID: 11047 RVA: 0x000BFC7C File Offset: 0x000BDE7C
			// Note: this type is marked as 'beforefieldinit'.
			static BoringX509StoreCtxHandle()
			{
				Il2CppClassPointerStore<MonoBtlsX509StoreCtx.BoringX509StoreCtxHandle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, "BoringX509StoreCtxHandle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsX509StoreCtx.BoringX509StoreCtxHandle>.NativeClassPtr);
				MonoBtlsX509StoreCtx.BoringX509StoreCtxHandle.NativeFieldInfoPtr_dontFree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsX509StoreCtx.BoringX509StoreCtxHandle>.NativeClassPtr, "dontFree");
				MonoBtlsX509StoreCtx.BoringX509StoreCtxHandle.NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx.BoringX509StoreCtxHandle>.NativeClassPtr, 100664070);
				MonoBtlsX509StoreCtx.BoringX509StoreCtxHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx.BoringX509StoreCtxHandle>.NativeClassPtr, 100664071);
			}

			// Token: 0x06002B28 RID: 11048 RVA: 0x000BFCE4 File Offset: 0x000BDEE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BoringX509StoreCtxHandle(IntPtr handle, bool ownsHandle = true)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsX509StoreCtx.BoringX509StoreCtxHandle>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref handle;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ownsHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509StoreCtx.BoringX509StoreCtxHandle.NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B29 RID: 11049 RVA: 0x000BFD3C File Offset: 0x000BDF3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432257, XrefRangeEnd = 432259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool ReleaseHandle()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsX509StoreCtx.BoringX509StoreCtxHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002B2A RID: 11050 RVA: 0x00013521 File Offset: 0x00011721
			public BoringX509StoreCtxHandle(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D8D RID: 3469
			// (get) Token: 0x06002B2B RID: 11051 RVA: 0x000BFD84 File Offset: 0x000BDF84
			// (set) Token: 0x06002B2C RID: 11052 RVA: 0x0001352A File Offset: 0x0001172A
			public unsafe bool dontFree
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsX509StoreCtx.BoringX509StoreCtxHandle.NativeFieldInfoPtr_dontFree);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsX509StoreCtx.BoringX509StoreCtxHandle.NativeFieldInfoPtr_dontFree)) = value;
				}
			}

			// Token: 0x040021E0 RID: 8672
			private static readonly IntPtr NativeFieldInfoPtr_dontFree;

			// Token: 0x040021E1 RID: 8673
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_Boolean_0;

			// Token: 0x040021E2 RID: 8674
			private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0;
		}
	}
}
