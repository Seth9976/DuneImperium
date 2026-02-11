using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000068 RID: 104
	public class DuplicateSheetRequest : Object
	{
		// Token: 0x06000787 RID: 1927 RVA: 0x000278F4 File Offset: 0x00025AF4
		// Note: this type is marked as 'beforefieldinit'.
		static DuplicateSheetRequest()
		{
			Il2CppClassPointerStore<DuplicateSheetRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "DuplicateSheetRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DuplicateSheetRequest>.NativeClassPtr);
			DuplicateSheetRequest.NativeFieldInfoPtr__InsertSheetIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuplicateSheetRequest>.NativeClassPtr, "<InsertSheetIndex>k__BackingField");
			DuplicateSheetRequest.NativeFieldInfoPtr__NewSheetId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuplicateSheetRequest>.NativeClassPtr, "<NewSheetId>k__BackingField");
			DuplicateSheetRequest.NativeFieldInfoPtr__NewSheetName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuplicateSheetRequest>.NativeClassPtr, "<NewSheetName>k__BackingField");
			DuplicateSheetRequest.NativeFieldInfoPtr__SourceSheetId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuplicateSheetRequest>.NativeClassPtr, "<SourceSheetId>k__BackingField");
			DuplicateSheetRequest.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuplicateSheetRequest>.NativeClassPtr, "<ETag>k__BackingField");
			DuplicateSheetRequest.NativeMethodInfoPtr_get_InsertSheetIndex_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuplicateSheetRequest>.NativeClassPtr, 100664432);
			DuplicateSheetRequest.NativeMethodInfoPtr_set_InsertSheetIndex_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuplicateSheetRequest>.NativeClassPtr, 100664433);
			DuplicateSheetRequest.NativeMethodInfoPtr_get_NewSheetId_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuplicateSheetRequest>.NativeClassPtr, 100664434);
			DuplicateSheetRequest.NativeMethodInfoPtr_set_NewSheetId_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuplicateSheetRequest>.NativeClassPtr, 100664435);
			DuplicateSheetRequest.NativeMethodInfoPtr_get_NewSheetName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuplicateSheetRequest>.NativeClassPtr, 100664436);
			DuplicateSheetRequest.NativeMethodInfoPtr_set_NewSheetName_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuplicateSheetRequest>.NativeClassPtr, 100664437);
			DuplicateSheetRequest.NativeMethodInfoPtr_get_SourceSheetId_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuplicateSheetRequest>.NativeClassPtr, 100664438);
			DuplicateSheetRequest.NativeMethodInfoPtr_set_SourceSheetId_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuplicateSheetRequest>.NativeClassPtr, 100664439);
			DuplicateSheetRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuplicateSheetRequest>.NativeClassPtr, 100664440);
			DuplicateSheetRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuplicateSheetRequest>.NativeClassPtr, 100664441);
			DuplicateSheetRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuplicateSheetRequest>.NativeClassPtr, 100664442);
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000788 RID: 1928 RVA: 0x00027A64 File Offset: 0x00025C64
		// (set) Token: 0x06000789 RID: 1929 RVA: 0x00027AA8 File Offset: 0x00025CA8
		public unsafe virtual Nullable<int> InsertSheetIndex
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DuplicateSheetRequest.NativeMethodInfoPtr_get_InsertSheetIndex_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DuplicateSheetRequest.NativeMethodInfoPtr_set_InsertSheetIndex_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x0600078A RID: 1930 RVA: 0x00027AFC File Offset: 0x00025CFC
		// (set) Token: 0x0600078B RID: 1931 RVA: 0x00027B40 File Offset: 0x00025D40
		public unsafe virtual Nullable<int> NewSheetId
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DuplicateSheetRequest.NativeMethodInfoPtr_get_NewSheetId_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DuplicateSheetRequest.NativeMethodInfoPtr_set_NewSheetId_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x0600078C RID: 1932 RVA: 0x00027B94 File Offset: 0x00025D94
		// (set) Token: 0x0600078D RID: 1933 RVA: 0x00027BD8 File Offset: 0x00025DD8
		public unsafe virtual string NewSheetName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DuplicateSheetRequest.NativeMethodInfoPtr_get_NewSheetName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DuplicateSheetRequest.NativeMethodInfoPtr_set_NewSheetName_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x00027C28 File Offset: 0x00025E28
		// (set) Token: 0x0600078F RID: 1935 RVA: 0x00027C6C File Offset: 0x00025E6C
		public unsafe virtual Nullable<int> SourceSheetId
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DuplicateSheetRequest.NativeMethodInfoPtr_get_SourceSheetId_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 312312, RefRangeEnd = 312313, XrefRangeStart = 312312, XrefRangeEnd = 312313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DuplicateSheetRequest.NativeMethodInfoPtr_set_SourceSheetId_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x00027CC0 File Offset: 0x00025EC0
		// (set) Token: 0x06000791 RID: 1937 RVA: 0x00027D04 File Offset: 0x00025F04
		public unsafe virtual string ETag
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DuplicateSheetRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DuplicateSheetRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x00027D54 File Offset: 0x00025F54
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DuplicateSheetRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DuplicateSheetRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DuplicateSheetRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00005868 File Offset: 0x00003A68
		public DuplicateSheetRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000794 RID: 1940 RVA: 0x00027D90 File Offset: 0x00025F90
		// (set) Token: 0x06000795 RID: 1941 RVA: 0x00005871 File Offset: 0x00003A71
		public Nullable<int> _InsertSheetIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DuplicateSheetRequest.NativeFieldInfoPtr__InsertSheetIndex_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DuplicateSheetRequest.NativeFieldInfoPtr__InsertSheetIndex_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000796 RID: 1942 RVA: 0x00027DC0 File Offset: 0x00025FC0
		// (set) Token: 0x06000797 RID: 1943 RVA: 0x0000589F File Offset: 0x00003A9F
		public Nullable<int> _NewSheetId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DuplicateSheetRequest.NativeFieldInfoPtr__NewSheetId_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DuplicateSheetRequest.NativeFieldInfoPtr__NewSheetId_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000798 RID: 1944 RVA: 0x00027DF0 File Offset: 0x00025FF0
		// (set) Token: 0x06000799 RID: 1945 RVA: 0x000058CD File Offset: 0x00003ACD
		public unsafe string _NewSheetName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DuplicateSheetRequest.NativeFieldInfoPtr__NewSheetName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DuplicateSheetRequest.NativeFieldInfoPtr__NewSheetName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x0600079A RID: 1946 RVA: 0x00027E18 File Offset: 0x00026018
		// (set) Token: 0x0600079B RID: 1947 RVA: 0x000058EC File Offset: 0x00003AEC
		public Nullable<int> _SourceSheetId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DuplicateSheetRequest.NativeFieldInfoPtr__SourceSheetId_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DuplicateSheetRequest.NativeFieldInfoPtr__SourceSheetId_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x0600079C RID: 1948 RVA: 0x00027E48 File Offset: 0x00026048
		// (set) Token: 0x0600079D RID: 1949 RVA: 0x0000591A File Offset: 0x00003B1A
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DuplicateSheetRequest.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DuplicateSheetRequest.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000526 RID: 1318
		private static readonly IntPtr NativeFieldInfoPtr__InsertSheetIndex_k__BackingField;

		// Token: 0x04000527 RID: 1319
		private static readonly IntPtr NativeFieldInfoPtr__NewSheetId_k__BackingField;

		// Token: 0x04000528 RID: 1320
		private static readonly IntPtr NativeFieldInfoPtr__NewSheetName_k__BackingField;

		// Token: 0x04000529 RID: 1321
		private static readonly IntPtr NativeFieldInfoPtr__SourceSheetId_k__BackingField;

		// Token: 0x0400052A RID: 1322
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x0400052B RID: 1323
		private static readonly IntPtr NativeMethodInfoPtr_get_InsertSheetIndex_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x0400052C RID: 1324
		private static readonly IntPtr NativeMethodInfoPtr_set_InsertSheetIndex_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x0400052D RID: 1325
		private static readonly IntPtr NativeMethodInfoPtr_get_NewSheetId_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x0400052E RID: 1326
		private static readonly IntPtr NativeMethodInfoPtr_set_NewSheetId_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x0400052F RID: 1327
		private static readonly IntPtr NativeMethodInfoPtr_get_NewSheetName_Public_Virtual_New_get_String_0;

		// Token: 0x04000530 RID: 1328
		private static readonly IntPtr NativeMethodInfoPtr_set_NewSheetName_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000531 RID: 1329
		private static readonly IntPtr NativeMethodInfoPtr_get_SourceSheetId_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x04000532 RID: 1330
		private static readonly IntPtr NativeMethodInfoPtr_set_SourceSheetId_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000533 RID: 1331
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000534 RID: 1332
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000535 RID: 1333
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
