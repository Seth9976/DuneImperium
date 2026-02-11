using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000061 RID: 97
	public class DeveloperMetadataLocation : Object
	{
		// Token: 0x060006F6 RID: 1782 RVA: 0x0002568C File Offset: 0x0002388C
		// Note: this type is marked as 'beforefieldinit'.
		static DeveloperMetadataLocation()
		{
			Il2CppClassPointerStore<DeveloperMetadataLocation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "DeveloperMetadataLocation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeveloperMetadataLocation>.NativeClassPtr);
			DeveloperMetadataLocation.NativeFieldInfoPtr__DimensionRange_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeveloperMetadataLocation>.NativeClassPtr, "<DimensionRange>k__BackingField");
			DeveloperMetadataLocation.NativeFieldInfoPtr__LocationType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeveloperMetadataLocation>.NativeClassPtr, "<LocationType>k__BackingField");
			DeveloperMetadataLocation.NativeFieldInfoPtr__SheetId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeveloperMetadataLocation>.NativeClassPtr, "<SheetId>k__BackingField");
			DeveloperMetadataLocation.NativeFieldInfoPtr__Spreadsheet_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeveloperMetadataLocation>.NativeClassPtr, "<Spreadsheet>k__BackingField");
			DeveloperMetadataLocation.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeveloperMetadataLocation>.NativeClassPtr, "<ETag>k__BackingField");
			DeveloperMetadataLocation.NativeMethodInfoPtr_get_DimensionRange_Public_Virtual_New_get_DimensionRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeveloperMetadataLocation>.NativeClassPtr, 100664363);
			DeveloperMetadataLocation.NativeMethodInfoPtr_set_DimensionRange_Public_Virtual_New_set_Void_DimensionRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeveloperMetadataLocation>.NativeClassPtr, 100664364);
			DeveloperMetadataLocation.NativeMethodInfoPtr_get_LocationType_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeveloperMetadataLocation>.NativeClassPtr, 100664365);
			DeveloperMetadataLocation.NativeMethodInfoPtr_set_LocationType_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeveloperMetadataLocation>.NativeClassPtr, 100664366);
			DeveloperMetadataLocation.NativeMethodInfoPtr_get_SheetId_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeveloperMetadataLocation>.NativeClassPtr, 100664367);
			DeveloperMetadataLocation.NativeMethodInfoPtr_set_SheetId_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeveloperMetadataLocation>.NativeClassPtr, 100664368);
			DeveloperMetadataLocation.NativeMethodInfoPtr_get_Spreadsheet_Public_Virtual_New_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeveloperMetadataLocation>.NativeClassPtr, 100664369);
			DeveloperMetadataLocation.NativeMethodInfoPtr_set_Spreadsheet_Public_Virtual_New_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeveloperMetadataLocation>.NativeClassPtr, 100664370);
			DeveloperMetadataLocation.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeveloperMetadataLocation>.NativeClassPtr, 100664371);
			DeveloperMetadataLocation.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeveloperMetadataLocation>.NativeClassPtr, 100664372);
			DeveloperMetadataLocation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeveloperMetadataLocation>.NativeClassPtr, 100664373);
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x060006F7 RID: 1783 RVA: 0x000257FC File Offset: 0x000239FC
		// (set) Token: 0x060006F8 RID: 1784 RVA: 0x00025848 File Offset: 0x00023A48
		public unsafe virtual DimensionRange DimensionRange
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeveloperMetadataLocation.NativeMethodInfoPtr_get_DimensionRange_Public_Virtual_New_get_DimensionRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DimensionRange>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeveloperMetadataLocation.NativeMethodInfoPtr_set_DimensionRange_Public_Virtual_New_set_Void_DimensionRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x060006F9 RID: 1785 RVA: 0x00025898 File Offset: 0x00023A98
		// (set) Token: 0x060006FA RID: 1786 RVA: 0x000258DC File Offset: 0x00023ADC
		public unsafe virtual string LocationType
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeveloperMetadataLocation.NativeMethodInfoPtr_get_LocationType_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeveloperMetadataLocation.NativeMethodInfoPtr_set_LocationType_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x060006FB RID: 1787 RVA: 0x0002592C File Offset: 0x00023B2C
		// (set) Token: 0x060006FC RID: 1788 RVA: 0x00025970 File Offset: 0x00023B70
		public unsafe virtual Nullable<int> SheetId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeveloperMetadataLocation.NativeMethodInfoPtr_get_SheetId_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeveloperMetadataLocation.NativeMethodInfoPtr_set_SheetId_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x060006FD RID: 1789 RVA: 0x000259C4 File Offset: 0x00023BC4
		// (set) Token: 0x060006FE RID: 1790 RVA: 0x00025A08 File Offset: 0x00023C08
		public unsafe virtual Nullable<bool> Spreadsheet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeveloperMetadataLocation.NativeMethodInfoPtr_get_Spreadsheet_Public_Virtual_New_get_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<bool>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeveloperMetadataLocation.NativeMethodInfoPtr_set_Spreadsheet_Public_Virtual_New_set_Void_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x060006FF RID: 1791 RVA: 0x00025A5C File Offset: 0x00023C5C
		// (set) Token: 0x06000700 RID: 1792 RVA: 0x00025AA0 File Offset: 0x00023CA0
		public unsafe virtual string ETag
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeveloperMetadataLocation.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeveloperMetadataLocation.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x00025AF0 File Offset: 0x00023CF0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeveloperMetadataLocation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeveloperMetadataLocation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeveloperMetadataLocation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x000053B4 File Offset: 0x000035B4
		public DeveloperMetadataLocation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000703 RID: 1795 RVA: 0x00025B2C File Offset: 0x00023D2C
		// (set) Token: 0x06000704 RID: 1796 RVA: 0x000053BD File Offset: 0x000035BD
		public unsafe DimensionRange _DimensionRange_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperMetadataLocation.NativeFieldInfoPtr__DimensionRange_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DimensionRange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperMetadataLocation.NativeFieldInfoPtr__DimensionRange_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000705 RID: 1797 RVA: 0x00025B5C File Offset: 0x00023D5C
		// (set) Token: 0x06000706 RID: 1798 RVA: 0x000053DC File Offset: 0x000035DC
		public unsafe string _LocationType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperMetadataLocation.NativeFieldInfoPtr__LocationType_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperMetadataLocation.NativeFieldInfoPtr__LocationType_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000707 RID: 1799 RVA: 0x00025B84 File Offset: 0x00023D84
		// (set) Token: 0x06000708 RID: 1800 RVA: 0x000053FB File Offset: 0x000035FB
		public Nullable<int> _SheetId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperMetadataLocation.NativeFieldInfoPtr__SheetId_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperMetadataLocation.NativeFieldInfoPtr__SheetId_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000709 RID: 1801 RVA: 0x00025BB4 File Offset: 0x00023DB4
		// (set) Token: 0x0600070A RID: 1802 RVA: 0x00005429 File Offset: 0x00003629
		public Nullable<bool> _Spreadsheet_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperMetadataLocation.NativeFieldInfoPtr__Spreadsheet_k__BackingField);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperMetadataLocation.NativeFieldInfoPtr__Spreadsheet_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x0600070B RID: 1803 RVA: 0x00025BE4 File Offset: 0x00023DE4
		// (set) Token: 0x0600070C RID: 1804 RVA: 0x00005457 File Offset: 0x00003657
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperMetadataLocation.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperMetadataLocation.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040004C2 RID: 1218
		private static readonly IntPtr NativeFieldInfoPtr__DimensionRange_k__BackingField;

		// Token: 0x040004C3 RID: 1219
		private static readonly IntPtr NativeFieldInfoPtr__LocationType_k__BackingField;

		// Token: 0x040004C4 RID: 1220
		private static readonly IntPtr NativeFieldInfoPtr__SheetId_k__BackingField;

		// Token: 0x040004C5 RID: 1221
		private static readonly IntPtr NativeFieldInfoPtr__Spreadsheet_k__BackingField;

		// Token: 0x040004C6 RID: 1222
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x040004C7 RID: 1223
		private static readonly IntPtr NativeMethodInfoPtr_get_DimensionRange_Public_Virtual_New_get_DimensionRange_0;

		// Token: 0x040004C8 RID: 1224
		private static readonly IntPtr NativeMethodInfoPtr_set_DimensionRange_Public_Virtual_New_set_Void_DimensionRange_0;

		// Token: 0x040004C9 RID: 1225
		private static readonly IntPtr NativeMethodInfoPtr_get_LocationType_Public_Virtual_New_get_String_0;

		// Token: 0x040004CA RID: 1226
		private static readonly IntPtr NativeMethodInfoPtr_set_LocationType_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040004CB RID: 1227
		private static readonly IntPtr NativeMethodInfoPtr_get_SheetId_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x040004CC RID: 1228
		private static readonly IntPtr NativeMethodInfoPtr_set_SheetId_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x040004CD RID: 1229
		private static readonly IntPtr NativeMethodInfoPtr_get_Spreadsheet_Public_Virtual_New_get_Nullable_1_Boolean_0;

		// Token: 0x040004CE RID: 1230
		private static readonly IntPtr NativeMethodInfoPtr_set_Spreadsheet_Public_Virtual_New_set_Void_Nullable_1_Boolean_0;

		// Token: 0x040004CF RID: 1231
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x040004D0 RID: 1232
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040004D1 RID: 1233
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
