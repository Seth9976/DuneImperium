using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x0200004C RID: 76
	public class DataFilter : Object
	{
		// Token: 0x060005D7 RID: 1495 RVA: 0x00021458 File Offset: 0x0001F658
		// Note: this type is marked as 'beforefieldinit'.
		static DataFilter()
		{
			Il2CppClassPointerStore<DataFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "DataFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataFilter>.NativeClassPtr);
			DataFilter.NativeFieldInfoPtr__A1Range_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataFilter>.NativeClassPtr, "<A1Range>k__BackingField");
			DataFilter.NativeFieldInfoPtr__DeveloperMetadataLookup_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataFilter>.NativeClassPtr, "<DeveloperMetadataLookup>k__BackingField");
			DataFilter.NativeFieldInfoPtr__GridRange_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataFilter>.NativeClassPtr, "<GridRange>k__BackingField");
			DataFilter.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataFilter>.NativeClassPtr, "<ETag>k__BackingField");
			DataFilter.NativeMethodInfoPtr_get_A1Range_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataFilter>.NativeClassPtr, 100664230);
			DataFilter.NativeMethodInfoPtr_set_A1Range_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataFilter>.NativeClassPtr, 100664231);
			DataFilter.NativeMethodInfoPtr_get_DeveloperMetadataLookup_Public_Virtual_New_get_DeveloperMetadataLookup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataFilter>.NativeClassPtr, 100664232);
			DataFilter.NativeMethodInfoPtr_set_DeveloperMetadataLookup_Public_Virtual_New_set_Void_DeveloperMetadataLookup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataFilter>.NativeClassPtr, 100664233);
			DataFilter.NativeMethodInfoPtr_get_GridRange_Public_Virtual_New_get_GridRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataFilter>.NativeClassPtr, 100664234);
			DataFilter.NativeMethodInfoPtr_set_GridRange_Public_Virtual_New_set_Void_GridRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataFilter>.NativeClassPtr, 100664235);
			DataFilter.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataFilter>.NativeClassPtr, 100664236);
			DataFilter.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataFilter>.NativeClassPtr, 100664237);
			DataFilter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataFilter>.NativeClassPtr, 100664238);
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x060005D8 RID: 1496 RVA: 0x0002158C File Offset: 0x0001F78C
		// (set) Token: 0x060005D9 RID: 1497 RVA: 0x000215D0 File Offset: 0x0001F7D0
		public unsafe virtual string A1Range
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataFilter.NativeMethodInfoPtr_get_A1Range_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataFilter.NativeMethodInfoPtr_set_A1Range_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x060005DA RID: 1498 RVA: 0x00021620 File Offset: 0x0001F820
		// (set) Token: 0x060005DB RID: 1499 RVA: 0x0002166C File Offset: 0x0001F86C
		public unsafe virtual DeveloperMetadataLookup DeveloperMetadataLookup
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataFilter.NativeMethodInfoPtr_get_DeveloperMetadataLookup_Public_Virtual_New_get_DeveloperMetadataLookup_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeveloperMetadataLookup>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataFilter.NativeMethodInfoPtr_set_DeveloperMetadataLookup_Public_Virtual_New_set_Void_DeveloperMetadataLookup_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x060005DC RID: 1500 RVA: 0x000216BC File Offset: 0x0001F8BC
		// (set) Token: 0x060005DD RID: 1501 RVA: 0x00021708 File Offset: 0x0001F908
		public unsafe virtual GridRange GridRange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataFilter.NativeMethodInfoPtr_get_GridRange_Public_Virtual_New_get_GridRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GridRange>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataFilter.NativeMethodInfoPtr_set_GridRange_Public_Virtual_New_set_Void_GridRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x060005DE RID: 1502 RVA: 0x00021758 File Offset: 0x0001F958
		// (set) Token: 0x060005DF RID: 1503 RVA: 0x0002179C File Offset: 0x0001F99C
		public unsafe virtual string ETag
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataFilter.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataFilter.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x000217EC File Offset: 0x0001F9EC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataFilter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataFilter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataFilter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00004B8A File Offset: 0x00002D8A
		public DataFilter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x060005E2 RID: 1506 RVA: 0x00021828 File Offset: 0x0001FA28
		// (set) Token: 0x060005E3 RID: 1507 RVA: 0x00004B93 File Offset: 0x00002D93
		public unsafe string _A1Range_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataFilter.NativeFieldInfoPtr__A1Range_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataFilter.NativeFieldInfoPtr__A1Range_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x060005E4 RID: 1508 RVA: 0x00021850 File Offset: 0x0001FA50
		// (set) Token: 0x060005E5 RID: 1509 RVA: 0x00004BB2 File Offset: 0x00002DB2
		public unsafe DeveloperMetadataLookup _DeveloperMetadataLookup_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataFilter.NativeFieldInfoPtr__DeveloperMetadataLookup_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeveloperMetadataLookup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataFilter.NativeFieldInfoPtr__DeveloperMetadataLookup_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x060005E6 RID: 1510 RVA: 0x00021880 File Offset: 0x0001FA80
		// (set) Token: 0x060005E7 RID: 1511 RVA: 0x00004BD1 File Offset: 0x00002DD1
		public unsafe GridRange _GridRange_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataFilter.NativeFieldInfoPtr__GridRange_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridRange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataFilter.NativeFieldInfoPtr__GridRange_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x000218B0 File Offset: 0x0001FAB0
		// (set) Token: 0x060005E9 RID: 1513 RVA: 0x00004BF0 File Offset: 0x00002DF0
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataFilter.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataFilter.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000405 RID: 1029
		private static readonly IntPtr NativeFieldInfoPtr__A1Range_k__BackingField;

		// Token: 0x04000406 RID: 1030
		private static readonly IntPtr NativeFieldInfoPtr__DeveloperMetadataLookup_k__BackingField;

		// Token: 0x04000407 RID: 1031
		private static readonly IntPtr NativeFieldInfoPtr__GridRange_k__BackingField;

		// Token: 0x04000408 RID: 1032
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000409 RID: 1033
		private static readonly IntPtr NativeMethodInfoPtr_get_A1Range_Public_Virtual_New_get_String_0;

		// Token: 0x0400040A RID: 1034
		private static readonly IntPtr NativeMethodInfoPtr_set_A1Range_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400040B RID: 1035
		private static readonly IntPtr NativeMethodInfoPtr_get_DeveloperMetadataLookup_Public_Virtual_New_get_DeveloperMetadataLookup_0;

		// Token: 0x0400040C RID: 1036
		private static readonly IntPtr NativeMethodInfoPtr_set_DeveloperMetadataLookup_Public_Virtual_New_set_Void_DeveloperMetadataLookup_0;

		// Token: 0x0400040D RID: 1037
		private static readonly IntPtr NativeMethodInfoPtr_get_GridRange_Public_Virtual_New_get_GridRange_0;

		// Token: 0x0400040E RID: 1038
		private static readonly IntPtr NativeMethodInfoPtr_set_GridRange_Public_Virtual_New_set_Void_GridRange_0;

		// Token: 0x0400040F RID: 1039
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000410 RID: 1040
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000411 RID: 1041
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
