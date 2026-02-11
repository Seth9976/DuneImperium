using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppMono.Btls
{
	// Token: 0x02000044 RID: 68
	public class MonoBtlsX509Name : MonoBtlsObject
	{
		// Token: 0x060003F9 RID: 1017 RVA: 0x0002B09C File Offset: 0x0002929C
		// Note: this type is marked as 'beforefieldinit'.
		static MonoBtlsX509Name()
		{
			Il2CppClassPointerStore<MonoBtlsX509Name>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Btls", "MonoBtlsX509Name");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsX509Name>.NativeClassPtr);
			MonoBtlsX509Name.NativeMethodInfoPtr_mono_btls_x509_name_hash_Private_Static_Int64_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Name>.NativeClassPtr, 100664012);
			MonoBtlsX509Name.NativeMethodInfoPtr_mono_btls_x509_name_get_entry_count_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Name>.NativeClassPtr, 100664013);
			MonoBtlsX509Name.NativeMethodInfoPtr_mono_btls_x509_name_get_entry_type_Private_Static_MonoBtlsX509NameEntryType_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Name>.NativeClassPtr, 100664014);
			MonoBtlsX509Name.NativeMethodInfoPtr_mono_btls_x509_name_get_entry_oid_Private_Static_Int32_IntPtr_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Name>.NativeClassPtr, 100664015);
			MonoBtlsX509Name.NativeMethodInfoPtr_mono_btls_x509_name_get_entry_oid_data_Private_Static_Int32_IntPtr_Int32_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Name>.NativeClassPtr, 100664016);
			MonoBtlsX509Name.NativeMethodInfoPtr_mono_btls_x509_name_get_entry_value_Private_Static_Int32_IntPtr_Int32_byref_Int32_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Name>.NativeClassPtr, 100664017);
			MonoBtlsX509Name.NativeMethodInfoPtr_mono_btls_x509_name_from_data_Private_Static_IntPtr_ptr_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Name>.NativeClassPtr, 100664018);
			MonoBtlsX509Name.NativeMethodInfoPtr_mono_btls_x509_name_free_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Name>.NativeClassPtr, 100664019);
			MonoBtlsX509Name.NativeMethodInfoPtr_get_Handle_Internal_get_BoringX509NameHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Name>.NativeClassPtr, 100664020);
			MonoBtlsX509Name.NativeMethodInfoPtr__ctor_Internal_Void_BoringX509NameHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Name>.NativeClassPtr, 100664021);
			MonoBtlsX509Name.NativeMethodInfoPtr_GetHash_Public_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Name>.NativeClassPtr, 100664022);
			MonoBtlsX509Name.NativeMethodInfoPtr_GetEntryCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Name>.NativeClassPtr, 100664023);
			MonoBtlsX509Name.NativeMethodInfoPtr_GetEntryType_Public_MonoBtlsX509NameEntryType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Name>.NativeClassPtr, 100664024);
			MonoBtlsX509Name.NativeMethodInfoPtr_GetEntryOid_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Name>.NativeClassPtr, 100664025);
			MonoBtlsX509Name.NativeMethodInfoPtr_GetEntryOidData_Public_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Name>.NativeClassPtr, 100664026);
			MonoBtlsX509Name.NativeMethodInfoPtr_GetEntryValue_Public_String_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Name>.NativeClassPtr, 100664027);
			MonoBtlsX509Name.NativeMethodInfoPtr_CreateFromData_Public_Static_MonoBtlsX509Name_Il2CppStructArray_1_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Name>.NativeClassPtr, 100664028);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0002B220 File Offset: 0x00029420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431972, XrefRangeEnd = 431974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long mono_btls_x509_name_hash(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Name.NativeMethodInfoPtr_mono_btls_x509_name_hash_Private_Static_Int64_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0002B260 File Offset: 0x00029460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431974, XrefRangeEnd = 431976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_x509_name_get_entry_count(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Name.NativeMethodInfoPtr_mono_btls_x509_name_get_entry_count_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0002B2A0 File Offset: 0x000294A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431976, XrefRangeEnd = 431978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoBtlsX509NameEntryType mono_btls_x509_name_get_entry_type(IntPtr name, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Name.NativeMethodInfoPtr_mono_btls_x509_name_get_entry_type_Private_Static_MonoBtlsX509NameEntryType_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x0002B2EC File Offset: 0x000294EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431978, XrefRangeEnd = 431980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_x509_name_get_entry_oid(IntPtr name, int index, IntPtr buffer, int size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buffer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Name.NativeMethodInfoPtr_mono_btls_x509_name_get_entry_oid_Private_Static_Int32_IntPtr_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0002B354 File Offset: 0x00029554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431980, XrefRangeEnd = 431982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_x509_name_get_entry_oid_data(IntPtr name, int index, out IntPtr data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Name.NativeMethodInfoPtr_mono_btls_x509_name_get_entry_oid_data_Private_Static_Int32_IntPtr_Int32_byref_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0002B3B0 File Offset: 0x000295B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431982, XrefRangeEnd = 431984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_x509_name_get_entry_value(IntPtr name, int index, out int tag, out IntPtr str)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &tag;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &str;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Name.NativeMethodInfoPtr_mono_btls_x509_name_get_entry_value_Private_Static_Int32_IntPtr_Int32_byref_Int32_byref_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x0002B418 File Offset: 0x00029618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431984, XrefRangeEnd = 431986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr mono_btls_x509_name_from_data(void* data, int len, int use_canon_enc)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = data;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref use_canon_enc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Name.NativeMethodInfoPtr_mono_btls_x509_name_from_data_Private_Static_IntPtr_ptr_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0002B470 File Offset: 0x00029670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431986, XrefRangeEnd = 431988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void mono_btls_x509_name_free(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Name.NativeMethodInfoPtr_mono_btls_x509_name_free_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x0002B4A4 File Offset: 0x000296A4
		public new unsafe MonoBtlsX509Name.BoringX509NameHandle Handle
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 431991, RefRangeEnd = 431999, XrefRangeStart = 431988, XrefRangeEnd = 431991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Name.NativeMethodInfoPtr_get_Handle_Internal_get_BoringX509NameHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509Name.BoringX509NameHandle>(intPtr3) : null;
			}
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0002B4E4 File Offset: 0x000296E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 373450, RefRangeEnd = 373451, XrefRangeStart = 373450, XrefRangeEnd = 373451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsX509Name(MonoBtlsX509Name.BoringX509NameHandle handle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsX509Name>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Name.NativeMethodInfoPtr__ctor_Internal_Void_BoringX509NameHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x0002B530 File Offset: 0x00029730
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 432002, RefRangeEnd = 432004, XrefRangeStart = 431999, XrefRangeEnd = 432002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long GetHash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Name.NativeMethodInfoPtr_GetHash_Public_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0002B56C File Offset: 0x0002976C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 432007, RefRangeEnd = 432012, XrefRangeStart = 432004, XrefRangeEnd = 432007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetEntryCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Name.NativeMethodInfoPtr_GetEntryCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0002B5A8 File Offset: 0x000297A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432012, XrefRangeEnd = 432016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsX509NameEntryType GetEntryType(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Name.NativeMethodInfoPtr_GetEntryType_Public_MonoBtlsX509NameEntryType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x0002B5F4 File Offset: 0x000297F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 432037, RefRangeEnd = 432038, XrefRangeStart = 432016, XrefRangeEnd = 432037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetEntryOid(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Name.NativeMethodInfoPtr_GetEntryOid_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x0002B638 File Offset: 0x00029838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432038, XrefRangeEnd = 432051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetEntryOidData(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Name.NativeMethodInfoPtr_GetEntryOidData_Public_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x0002B684 File Offset: 0x00029884
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 432065, RefRangeEnd = 432066, XrefRangeStart = 432051, XrefRangeEnd = 432065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetEntryValue(int index, out int tag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &tag;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Name.NativeMethodInfoPtr_GetEntryValue_Public_String_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0002B6D8 File Offset: 0x000298D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432066, XrefRangeEnd = 432078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoBtlsX509Name CreateFromData(Il2CppStructArray<byte> data, bool use_canon_enc)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref use_canon_enc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Name.NativeMethodInfoPtr_CreateFromData_Public_Static_MonoBtlsX509Name_Il2CppStructArray_1_Byte_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509Name>(intPtr3) : null;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x000034C9 File Offset: 0x000016C9
		public MonoBtlsX509Name(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400033E RID: 830
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_name_hash_Private_Static_Int64_IntPtr_0;

		// Token: 0x0400033F RID: 831
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_name_get_entry_count_Private_Static_Int32_IntPtr_0;

		// Token: 0x04000340 RID: 832
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_name_get_entry_type_Private_Static_MonoBtlsX509NameEntryType_IntPtr_Int32_0;

		// Token: 0x04000341 RID: 833
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_name_get_entry_oid_Private_Static_Int32_IntPtr_Int32_IntPtr_Int32_0;

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_name_get_entry_oid_data_Private_Static_Int32_IntPtr_Int32_byref_IntPtr_0;

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_name_get_entry_value_Private_Static_Int32_IntPtr_Int32_byref_Int32_byref_IntPtr_0;

		// Token: 0x04000344 RID: 836
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_name_from_data_Private_Static_IntPtr_ptr_Void_Int32_Int32_0;

		// Token: 0x04000345 RID: 837
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_name_free_Private_Static_Void_IntPtr_0;

		// Token: 0x04000346 RID: 838
		private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Internal_get_BoringX509NameHandle_0;

		// Token: 0x04000347 RID: 839
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BoringX509NameHandle_0;

		// Token: 0x04000348 RID: 840
		private static readonly IntPtr NativeMethodInfoPtr_GetHash_Public_Int64_0;

		// Token: 0x04000349 RID: 841
		private static readonly IntPtr NativeMethodInfoPtr_GetEntryCount_Public_Int32_0;

		// Token: 0x0400034A RID: 842
		private static readonly IntPtr NativeMethodInfoPtr_GetEntryType_Public_MonoBtlsX509NameEntryType_Int32_0;

		// Token: 0x0400034B RID: 843
		private static readonly IntPtr NativeMethodInfoPtr_GetEntryOid_Public_String_Int32_0;

		// Token: 0x0400034C RID: 844
		private static readonly IntPtr NativeMethodInfoPtr_GetEntryOidData_Public_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400034D RID: 845
		private static readonly IntPtr NativeMethodInfoPtr_GetEntryValue_Public_String_Int32_byref_Int32_0;

		// Token: 0x0400034E RID: 846
		private static readonly IntPtr NativeMethodInfoPtr_CreateFromData_Public_Static_MonoBtlsX509Name_Il2CppStructArray_1_Byte_Boolean_0;

		// Token: 0x020002BA RID: 698
		public class BoringX509NameHandle : MonoBtlsObject.MonoBtlsHandle
		{
			// Token: 0x06002B1E RID: 11038 RVA: 0x000BFB04 File Offset: 0x000BDD04
			// Note: this type is marked as 'beforefieldinit'.
			static BoringX509NameHandle()
			{
				Il2CppClassPointerStore<MonoBtlsX509Name.BoringX509NameHandle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoBtlsX509Name>.NativeClassPtr, "BoringX509NameHandle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsX509Name.BoringX509NameHandle>.NativeClassPtr);
				MonoBtlsX509Name.BoringX509NameHandle.NativeFieldInfoPtr_dontFree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsX509Name.BoringX509NameHandle>.NativeClassPtr, "dontFree");
				MonoBtlsX509Name.BoringX509NameHandle.NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Name.BoringX509NameHandle>.NativeClassPtr, 100664029);
				MonoBtlsX509Name.BoringX509NameHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Name.BoringX509NameHandle>.NativeClassPtr, 100664030);
			}

			// Token: 0x06002B1F RID: 11039 RVA: 0x000BFB6C File Offset: 0x000BDD6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431969, XrefRangeEnd = 431970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BoringX509NameHandle(IntPtr handle, bool ownsHandle)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsX509Name.BoringX509NameHandle>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref handle;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ownsHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Name.BoringX509NameHandle.NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B20 RID: 11040 RVA: 0x000BFBC4 File Offset: 0x000BDDC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431970, XrefRangeEnd = 431972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool ReleaseHandle()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsX509Name.BoringX509NameHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002B21 RID: 11041 RVA: 0x000134C0 File Offset: 0x000116C0
			public BoringX509NameHandle(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D8C RID: 3468
			// (get) Token: 0x06002B22 RID: 11042 RVA: 0x000BFC0C File Offset: 0x000BDE0C
			// (set) Token: 0x06002B23 RID: 11043 RVA: 0x000134C9 File Offset: 0x000116C9
			public unsafe bool dontFree
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsX509Name.BoringX509NameHandle.NativeFieldInfoPtr_dontFree);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsX509Name.BoringX509NameHandle.NativeFieldInfoPtr_dontFree)) = value;
				}
			}

			// Token: 0x040021DC RID: 8668
			private static readonly IntPtr NativeFieldInfoPtr_dontFree;

			// Token: 0x040021DD RID: 8669
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_Boolean_0;

			// Token: 0x040021DE RID: 8670
			private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0;
		}
	}
}
