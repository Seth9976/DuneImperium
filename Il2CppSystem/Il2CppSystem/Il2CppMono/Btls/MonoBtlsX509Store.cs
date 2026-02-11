using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Btls
{
	// Token: 0x02000046 RID: 70
	public class MonoBtlsX509Store : MonoBtlsObject
	{
		// Token: 0x0600040C RID: 1036 RVA: 0x0002B72C File Offset: 0x0002992C
		// Note: this type is marked as 'beforefieldinit'.
		static MonoBtlsX509Store()
		{
			Il2CppClassPointerStore<MonoBtlsX509Store>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Btls", "MonoBtlsX509Store");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsX509Store>.NativeClassPtr);
			MonoBtlsX509Store.NativeFieldInfoPtr_lookupHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsX509Store>.NativeClassPtr, "lookupHash");
			MonoBtlsX509Store.NativeMethodInfoPtr_get_Handle_Internal_get_BoringX509StoreHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Store>.NativeClassPtr, 100664031);
			MonoBtlsX509Store.NativeMethodInfoPtr_mono_btls_x509_store_new_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Store>.NativeClassPtr, 100664032);
			MonoBtlsX509Store.NativeMethodInfoPtr_mono_btls_x509_store_from_ssl_ctx_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Store>.NativeClassPtr, 100664033);
			MonoBtlsX509Store.NativeMethodInfoPtr_mono_btls_x509_store_add_cert_Private_Static_Int32_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Store>.NativeClassPtr, 100664034);
			MonoBtlsX509Store.NativeMethodInfoPtr_mono_btls_x509_store_free_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Store>.NativeClassPtr, 100664035);
			MonoBtlsX509Store.NativeMethodInfoPtr_Create_internal_Private_Static_BoringX509StoreHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Store>.NativeClassPtr, 100664036);
			MonoBtlsX509Store.NativeMethodInfoPtr_Create_internal_Private_Static_BoringX509StoreHandle_BoringSslCtxHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Store>.NativeClassPtr, 100664037);
			MonoBtlsX509Store.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Store>.NativeClassPtr, 100664038);
			MonoBtlsX509Store.NativeMethodInfoPtr__ctor_Internal_Void_BoringSslCtxHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Store>.NativeClassPtr, 100664039);
			MonoBtlsX509Store.NativeMethodInfoPtr_AddCertificate_Public_Void_MonoBtlsX509_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Store>.NativeClassPtr, 100664040);
			MonoBtlsX509Store.NativeMethodInfoPtr_AddLookup_Public_MonoBtlsX509Lookup_MonoBtlsX509LookupType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Store>.NativeClassPtr, 100664041);
			MonoBtlsX509Store.NativeMethodInfoPtr_AddDirectoryLookup_Public_Void_String_MonoBtlsX509FileType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Store>.NativeClassPtr, 100664042);
			MonoBtlsX509Store.NativeMethodInfoPtr_AddCollection_Public_Void_X509CertificateCollection_MonoBtlsX509TrustKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Store>.NativeClassPtr, 100664043);
			MonoBtlsX509Store.NativeMethodInfoPtr_Close_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Store>.NativeClassPtr, 100664044);
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x0002B888 File Offset: 0x00029A88
		public new unsafe MonoBtlsX509Store.BoringX509StoreHandle Handle
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 432083, RefRangeEnd = 432089, XrefRangeStart = 432080, XrefRangeEnd = 432083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Store.NativeMethodInfoPtr_get_Handle_Internal_get_BoringX509StoreHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509Store.BoringX509StoreHandle>(intPtr3) : null;
			}
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0002B8C8 File Offset: 0x00029AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432089, XrefRangeEnd = 432091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr mono_btls_x509_store_new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Store.NativeMethodInfoPtr_mono_btls_x509_store_new_Private_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x0002B8F8 File Offset: 0x00029AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432091, XrefRangeEnd = 432093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr mono_btls_x509_store_from_ssl_ctx(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Store.NativeMethodInfoPtr_mono_btls_x509_store_from_ssl_ctx_Private_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0002B938 File Offset: 0x00029B38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432093, XrefRangeEnd = 432095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_x509_store_add_cert(IntPtr handle, IntPtr x509)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x509;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Store.NativeMethodInfoPtr_mono_btls_x509_store_add_cert_Private_Static_Int32_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x0002B984 File Offset: 0x00029B84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432095, XrefRangeEnd = 432097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void mono_btls_x509_store_free(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Store.NativeMethodInfoPtr_mono_btls_x509_store_free_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x0002B9B8 File Offset: 0x00029BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432097, XrefRangeEnd = 432104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoBtlsX509Store.BoringX509StoreHandle Create_internal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Store.NativeMethodInfoPtr_Create_internal_Private_Static_BoringX509StoreHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509Store.BoringX509StoreHandle>(intPtr3) : null;
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x0002B9EC File Offset: 0x00029BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432104, XrefRangeEnd = 432111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoBtlsX509Store.BoringX509StoreHandle Create_internal(MonoBtlsSslCtx.BoringSslCtxHandle ctx)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctx);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Store.NativeMethodInfoPtr_Create_internal_Private_Static_BoringX509StoreHandle_BoringSslCtxHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509Store.BoringX509StoreHandle>(intPtr3) : null;
			}
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0002BA30 File Offset: 0x00029C30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 432124, RefRangeEnd = 432125, XrefRangeStart = 432111, XrefRangeEnd = 432124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsX509Store()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsX509Store>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Store.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0002BA6C File Offset: 0x00029C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432125, XrefRangeEnd = 432139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsX509Store(MonoBtlsSslCtx.BoringSslCtxHandle ctx)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsX509Store>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctx);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Store.NativeMethodInfoPtr__ctor_Internal_Void_BoringSslCtxHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x0002BAB8 File Offset: 0x00029CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432139, XrefRangeEnd = 432147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCertificate(MonoBtlsX509 x509)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x509);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Store.NativeMethodInfoPtr_AddCertificate_Public_Void_MonoBtlsX509_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0002BAFC File Offset: 0x00029CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432147, XrefRangeEnd = 432168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsX509Lookup AddLookup(MonoBtlsX509LookupType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Store.NativeMethodInfoPtr_AddLookup_Public_MonoBtlsX509Lookup_MonoBtlsX509LookupType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509Lookup>(intPtr3) : null;
			}
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x0002BB48 File Offset: 0x00029D48
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 432195, RefRangeEnd = 432214, XrefRangeStart = 432168, XrefRangeEnd = 432195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDirectoryLookup(string dir, MonoBtlsX509FileType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(dir);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Store.NativeMethodInfoPtr_AddDirectoryLookup_Public_Void_String_MonoBtlsX509FileType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x0002BB98 File Offset: 0x00029D98
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 432225, RefRangeEnd = 432235, XrefRangeStart = 432214, XrefRangeEnd = 432225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCollection(X509CertificateCollection collection, MonoBtlsX509TrustKind trust)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trust;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Store.NativeMethodInfoPtr_AddCollection_Public_Void_X509CertificateCollection_MonoBtlsX509TrustKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x0002BBE8 File Offset: 0x00029DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432235, XrefRangeEnd = 432257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsX509Store.NativeMethodInfoPtr_Close_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x000034D2 File Offset: 0x000016D2
		public MonoBtlsX509Store(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x0002BC24 File Offset: 0x00029E24
		// (set) Token: 0x0600041D RID: 1053 RVA: 0x000034DB File Offset: 0x000016DB
		public unsafe Dictionary<IntPtr, MonoBtlsX509Lookup> lookupHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsX509Store.NativeFieldInfoPtr_lookupHash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<IntPtr, MonoBtlsX509Lookup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsX509Store.NativeFieldInfoPtr_lookupHash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000361 RID: 865
		private static readonly IntPtr NativeFieldInfoPtr_lookupHash;

		// Token: 0x04000362 RID: 866
		private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Internal_get_BoringX509StoreHandle_0;

		// Token: 0x04000363 RID: 867
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_store_new_Private_Static_IntPtr_0;

		// Token: 0x04000364 RID: 868
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_store_from_ssl_ctx_Private_Static_IntPtr_IntPtr_0;

		// Token: 0x04000365 RID: 869
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_store_add_cert_Private_Static_Int32_IntPtr_IntPtr_0;

		// Token: 0x04000366 RID: 870
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_store_free_Private_Static_Void_IntPtr_0;

		// Token: 0x04000367 RID: 871
		private static readonly IntPtr NativeMethodInfoPtr_Create_internal_Private_Static_BoringX509StoreHandle_0;

		// Token: 0x04000368 RID: 872
		private static readonly IntPtr NativeMethodInfoPtr_Create_internal_Private_Static_BoringX509StoreHandle_BoringSslCtxHandle_0;

		// Token: 0x04000369 RID: 873
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x0400036A RID: 874
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BoringSslCtxHandle_0;

		// Token: 0x0400036B RID: 875
		private static readonly IntPtr NativeMethodInfoPtr_AddCertificate_Public_Void_MonoBtlsX509_0;

		// Token: 0x0400036C RID: 876
		private static readonly IntPtr NativeMethodInfoPtr_AddLookup_Public_MonoBtlsX509Lookup_MonoBtlsX509LookupType_0;

		// Token: 0x0400036D RID: 877
		private static readonly IntPtr NativeMethodInfoPtr_AddDirectoryLookup_Public_Void_String_MonoBtlsX509FileType_0;

		// Token: 0x0400036E RID: 878
		private static readonly IntPtr NativeMethodInfoPtr_AddCollection_Public_Void_X509CertificateCollection_MonoBtlsX509TrustKind_0;

		// Token: 0x0400036F RID: 879
		private static readonly IntPtr NativeMethodInfoPtr_Close_Protected_Virtual_Void_0;

		// Token: 0x020002BB RID: 699
		public class BoringX509StoreHandle : MonoBtlsObject.MonoBtlsHandle
		{
			// Token: 0x06002B24 RID: 11044 RVA: 0x000134E4 File Offset: 0x000116E4
			// Note: this type is marked as 'beforefieldinit'.
			static BoringX509StoreHandle()
			{
				Il2CppClassPointerStore<MonoBtlsX509Store.BoringX509StoreHandle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoBtlsX509Store>.NativeClassPtr, "BoringX509StoreHandle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsX509Store.BoringX509StoreHandle>.NativeClassPtr);
				MonoBtlsX509Store.BoringX509StoreHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Store.BoringX509StoreHandle>.NativeClassPtr, 100664046);
			}

			// Token: 0x06002B25 RID: 11045 RVA: 0x000BFC34 File Offset: 0x000BDE34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432078, XrefRangeEnd = 432080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool ReleaseHandle()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsX509Store.BoringX509StoreHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002B26 RID: 11046 RVA: 0x00013518 File Offset: 0x00011718
			public BoringX509StoreHandle(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040021DF RID: 8671
			private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0;
		}
	}
}
