using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppMono.Btls
{
	// Token: 0x0200003B RID: 59
	public class MonoBtlsX509 : MonoBtlsObject
	{
		// Token: 0x0600039F RID: 927 RVA: 0x000298EC File Offset: 0x00027AEC
		// Note: this type is marked as 'beforefieldinit'.
		static MonoBtlsX509()
		{
			Il2CppClassPointerStore<MonoBtlsX509>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Btls", "MonoBtlsX509");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsX509>.NativeClassPtr);
			MonoBtlsX509.NativeMethodInfoPtr_get_Handle_Internal_get_BoringX509Handle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509>.NativeClassPtr, 100663945);
			MonoBtlsX509.NativeMethodInfoPtr__ctor_Internal_Void_BoringX509Handle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509>.NativeClassPtr, 100663946);
			MonoBtlsX509.NativeMethodInfoPtr_mono_btls_x509_up_ref_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509>.NativeClassPtr, 100663947);
			MonoBtlsX509.NativeMethodInfoPtr_mono_btls_x509_from_data_Private_Static_IntPtr_IntPtr_Int32_MonoBtlsX509Format_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509>.NativeClassPtr, 100663948);
			MonoBtlsX509.NativeMethodInfoPtr_mono_btls_x509_get_subject_name_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509>.NativeClassPtr, 100663949);
			MonoBtlsX509.NativeMethodInfoPtr_mono_btls_x509_get_raw_data_Private_Static_Int32_IntPtr_IntPtr_MonoBtlsX509Format_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509>.NativeClassPtr, 100663950);
			MonoBtlsX509.NativeMethodInfoPtr_mono_btls_x509_cmp_Private_Static_Int32_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509>.NativeClassPtr, 100663951);
			MonoBtlsX509.NativeMethodInfoPtr_mono_btls_x509_free_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509>.NativeClassPtr, 100663952);
			MonoBtlsX509.NativeMethodInfoPtr_mono_btls_x509_add_explicit_trust_Private_Static_Int32_IntPtr_MonoBtlsX509TrustKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509>.NativeClassPtr, 100663953);
			MonoBtlsX509.NativeMethodInfoPtr_Copy_Internal_MonoBtlsX509_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509>.NativeClassPtr, 100663954);
			MonoBtlsX509.NativeMethodInfoPtr_LoadFromData_Public_Static_MonoBtlsX509_Il2CppStructArray_1_Byte_MonoBtlsX509Format_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509>.NativeClassPtr, 100663955);
			MonoBtlsX509.NativeMethodInfoPtr_GetSubjectName_Public_MonoBtlsX509Name_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509>.NativeClassPtr, 100663956);
			MonoBtlsX509.NativeMethodInfoPtr_GetSubjectNameHash_Public_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509>.NativeClassPtr, 100663957);
			MonoBtlsX509.NativeMethodInfoPtr_GetRawData_Public_Il2CppStructArray_1_Byte_MonoBtlsX509Format_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509>.NativeClassPtr, 100663958);
			MonoBtlsX509.NativeMethodInfoPtr_Compare_Public_Static_Int32_MonoBtlsX509_MonoBtlsX509_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509>.NativeClassPtr, 100663959);
			MonoBtlsX509.NativeMethodInfoPtr_AddExplicitTrust_Public_Void_MonoBtlsX509TrustKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509>.NativeClassPtr, 100663960);
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x00029A5C File Offset: 0x00027C5C
		public new unsafe MonoBtlsX509.BoringX509Handle Handle
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 431482, RefRangeEnd = 431497, XrefRangeStart = 431479, XrefRangeEnd = 431482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509.NativeMethodInfoPtr_get_Handle_Internal_get_BoringX509Handle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509.BoringX509Handle>(intPtr3) : null;
			}
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00029A9C File Offset: 0x00027C9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 373450, RefRangeEnd = 373451, XrefRangeStart = 373450, XrefRangeEnd = 373451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsX509(MonoBtlsX509.BoringX509Handle handle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsX509>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509.NativeMethodInfoPtr__ctor_Internal_Void_BoringX509Handle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00029AE8 File Offset: 0x00027CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431497, XrefRangeEnd = 431499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr mono_btls_x509_up_ref(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509.NativeMethodInfoPtr_mono_btls_x509_up_ref_Private_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00029B28 File Offset: 0x00027D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431499, XrefRangeEnd = 431501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr mono_btls_x509_from_data(IntPtr data, int len, MonoBtlsX509Format format)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref data;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509.NativeMethodInfoPtr_mono_btls_x509_from_data_Private_Static_IntPtr_IntPtr_Int32_MonoBtlsX509Format_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00029B84 File Offset: 0x00027D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431501, XrefRangeEnd = 431503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr mono_btls_x509_get_subject_name(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509.NativeMethodInfoPtr_mono_btls_x509_get_subject_name_Private_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00029BC4 File Offset: 0x00027DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431503, XrefRangeEnd = 431505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_x509_get_raw_data(IntPtr handle, IntPtr bio, MonoBtlsX509Format format)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bio;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509.NativeMethodInfoPtr_mono_btls_x509_get_raw_data_Private_Static_Int32_IntPtr_IntPtr_MonoBtlsX509Format_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00029C20 File Offset: 0x00027E20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431505, XrefRangeEnd = 431507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_x509_cmp(IntPtr a, IntPtr b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509.NativeMethodInfoPtr_mono_btls_x509_cmp_Private_Static_Int32_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00029C6C File Offset: 0x00027E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431507, XrefRangeEnd = 431509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void mono_btls_x509_free(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509.NativeMethodInfoPtr_mono_btls_x509_free_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00029CA0 File Offset: 0x00027EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431509, XrefRangeEnd = 431511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_x509_add_explicit_trust(IntPtr handle, MonoBtlsX509TrustKind kind)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kind;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509.NativeMethodInfoPtr_mono_btls_x509_add_explicit_trust_Private_Static_Int32_IntPtr_MonoBtlsX509TrustKind_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00029CEC File Offset: 0x00027EEC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 431526, RefRangeEnd = 431536, XrefRangeStart = 431511, XrefRangeEnd = 431526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsX509 Copy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509.NativeMethodInfoPtr_Copy_Internal_MonoBtlsX509_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509>(intPtr3) : null;
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00029D2C File Offset: 0x00027F2C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 431562, RefRangeEnd = 431573, XrefRangeStart = 431536, XrefRangeEnd = 431562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoBtlsX509 LoadFromData(Il2CppStructArray<byte> buffer, MonoBtlsX509Format format)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509.NativeMethodInfoPtr_LoadFromData_Public_Static_MonoBtlsX509_Il2CppStructArray_1_Byte_MonoBtlsX509Format_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509>(intPtr3) : null;
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00029D80 File Offset: 0x00027F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431573, XrefRangeEnd = 431588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsX509Name GetSubjectName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509.NativeMethodInfoPtr_GetSubjectName_Public_MonoBtlsX509Name_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509Name>(intPtr3) : null;
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00029DC0 File Offset: 0x00027FC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 431611, RefRangeEnd = 431612, XrefRangeStart = 431588, XrefRangeEnd = 431611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long GetSubjectNameHash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509.NativeMethodInfoPtr_GetSubjectNameHash_Public_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00029DFC File Offset: 0x00027FFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 431630, RefRangeEnd = 431632, XrefRangeStart = 431612, XrefRangeEnd = 431630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetRawData(MonoBtlsX509Format format)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509.NativeMethodInfoPtr_GetRawData_Public_Il2CppStructArray_1_Byte_MonoBtlsX509Format_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00029E48 File Offset: 0x00028048
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 431636, RefRangeEnd = 431637, XrefRangeStart = 431632, XrefRangeEnd = 431636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Compare(MonoBtlsX509 a, MonoBtlsX509 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509.NativeMethodInfoPtr_Compare_Public_Static_Int32_MonoBtlsX509_MonoBtlsX509_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00029E9C File Offset: 0x0002809C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431637, XrefRangeEnd = 431645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddExplicitTrust(MonoBtlsX509TrustKind kind)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref kind;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509.NativeMethodInfoPtr_AddExplicitTrust_Public_Void_MonoBtlsX509TrustKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0000333C File Offset: 0x0000153C
		public MonoBtlsX509(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Internal_get_BoringX509Handle_0;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BoringX509Handle_0;

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_up_ref_Private_Static_IntPtr_IntPtr_0;

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_from_data_Private_Static_IntPtr_IntPtr_Int32_MonoBtlsX509Format_0;

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_get_subject_name_Private_Static_IntPtr_IntPtr_0;

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_get_raw_data_Private_Static_Int32_IntPtr_IntPtr_MonoBtlsX509Format_0;

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_cmp_Private_Static_Int32_IntPtr_IntPtr_0;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_free_Private_Static_Void_IntPtr_0;

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_add_explicit_trust_Private_Static_Int32_IntPtr_MonoBtlsX509TrustKind_0;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Internal_MonoBtlsX509_0;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeMethodInfoPtr_LoadFromData_Public_Static_MonoBtlsX509_Il2CppStructArray_1_Byte_MonoBtlsX509Format_0;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeMethodInfoPtr_GetSubjectName_Public_MonoBtlsX509Name_0;

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeMethodInfoPtr_GetSubjectNameHash_Public_Int64_0;

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeMethodInfoPtr_GetRawData_Public_Il2CppStructArray_1_Byte_MonoBtlsX509Format_0;

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Int32_MonoBtlsX509_MonoBtlsX509_0;

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeMethodInfoPtr_AddExplicitTrust_Public_Void_MonoBtlsX509TrustKind_0;

		// Token: 0x020002B5 RID: 693
		public class BoringX509Handle : MonoBtlsObject.MonoBtlsHandle
		{
			// Token: 0x06002B0D RID: 11021 RVA: 0x000BF890 File Offset: 0x000BDA90
			// Note: this type is marked as 'beforefieldinit'.
			static BoringX509Handle()
			{
				Il2CppClassPointerStore<MonoBtlsX509.BoringX509Handle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoBtlsX509>.NativeClassPtr, "BoringX509Handle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsX509.BoringX509Handle>.NativeClassPtr);
				MonoBtlsX509.BoringX509Handle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509.BoringX509Handle>.NativeClassPtr, 100663962);
				MonoBtlsX509.BoringX509Handle.NativeMethodInfoPtr_StealHandle_Public_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509.BoringX509Handle>.NativeClassPtr, 100663963);
			}

			// Token: 0x06002B0E RID: 11022 RVA: 0x000BF8E4 File Offset: 0x000BDAE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431475, XrefRangeEnd = 431478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool ReleaseHandle()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsX509.BoringX509Handle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002B0F RID: 11023 RVA: 0x000BF92C File Offset: 0x000BDB2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431478, XrefRangeEnd = 431479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IntPtr StealHandle()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509.BoringX509Handle.NativeMethodInfoPtr_StealHandle_Public_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002B10 RID: 11024 RVA: 0x000133B9 File Offset: 0x000115B9
			public BoringX509Handle(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040021D5 RID: 8661
			private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0;

			// Token: 0x040021D6 RID: 8662
			private static readonly IntPtr NativeMethodInfoPtr_StealHandle_Public_IntPtr_0;
		}
	}
}
