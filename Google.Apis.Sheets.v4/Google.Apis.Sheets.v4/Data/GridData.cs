using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000076 RID: 118
	public class GridData : Object
	{
		// Token: 0x060008C5 RID: 2245 RVA: 0x0002C548 File Offset: 0x0002A748
		// Note: this type is marked as 'beforefieldinit'.
		static GridData()
		{
			Il2CppClassPointerStore<GridData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "GridData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GridData>.NativeClassPtr);
			GridData.NativeFieldInfoPtr__ColumnMetadata_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridData>.NativeClassPtr, "<ColumnMetadata>k__BackingField");
			GridData.NativeFieldInfoPtr__RowData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridData>.NativeClassPtr, "<RowData>k__BackingField");
			GridData.NativeFieldInfoPtr__RowMetadata_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridData>.NativeClassPtr, "<RowMetadata>k__BackingField");
			GridData.NativeFieldInfoPtr__StartColumn_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridData>.NativeClassPtr, "<StartColumn>k__BackingField");
			GridData.NativeFieldInfoPtr__StartRow_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridData>.NativeClassPtr, "<StartRow>k__BackingField");
			GridData.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridData>.NativeClassPtr, "<ETag>k__BackingField");
			GridData.NativeMethodInfoPtr_get_ColumnMetadata_Public_Virtual_New_get_IList_1_DimensionProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridData>.NativeClassPtr, 100664584);
			GridData.NativeMethodInfoPtr_set_ColumnMetadata_Public_Virtual_New_set_Void_IList_1_DimensionProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridData>.NativeClassPtr, 100664585);
			GridData.NativeMethodInfoPtr_get_RowData_Public_Virtual_New_get_IList_1_RowData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridData>.NativeClassPtr, 100664586);
			GridData.NativeMethodInfoPtr_set_RowData_Public_Virtual_New_set_Void_IList_1_RowData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridData>.NativeClassPtr, 100664587);
			GridData.NativeMethodInfoPtr_get_RowMetadata_Public_Virtual_New_get_IList_1_DimensionProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridData>.NativeClassPtr, 100664588);
			GridData.NativeMethodInfoPtr_set_RowMetadata_Public_Virtual_New_set_Void_IList_1_DimensionProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridData>.NativeClassPtr, 100664589);
			GridData.NativeMethodInfoPtr_get_StartColumn_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridData>.NativeClassPtr, 100664590);
			GridData.NativeMethodInfoPtr_set_StartColumn_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridData>.NativeClassPtr, 100664591);
			GridData.NativeMethodInfoPtr_get_StartRow_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridData>.NativeClassPtr, 100664592);
			GridData.NativeMethodInfoPtr_set_StartRow_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridData>.NativeClassPtr, 100664593);
			GridData.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridData>.NativeClassPtr, 100664594);
			GridData.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridData>.NativeClassPtr, 100664595);
			GridData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridData>.NativeClassPtr, 100664596);
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x060008C6 RID: 2246 RVA: 0x0002C6F4 File Offset: 0x0002A8F4
		// (set) Token: 0x060008C7 RID: 2247 RVA: 0x0002C740 File Offset: 0x0002A940
		public unsafe virtual IList<DimensionProperties> ColumnMetadata
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridData.NativeMethodInfoPtr_get_ColumnMetadata_Public_Virtual_New_get_IList_1_DimensionProperties_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<DimensionProperties>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridData.NativeMethodInfoPtr_set_ColumnMetadata_Public_Virtual_New_set_Void_IList_1_DimensionProperties_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x060008C8 RID: 2248 RVA: 0x0002C790 File Offset: 0x0002A990
		// (set) Token: 0x060008C9 RID: 2249 RVA: 0x0002C7DC File Offset: 0x0002A9DC
		public unsafe virtual IList<RowData> RowData
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridData.NativeMethodInfoPtr_get_RowData_Public_Virtual_New_get_IList_1_RowData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<RowData>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridData.NativeMethodInfoPtr_set_RowData_Public_Virtual_New_set_Void_IList_1_RowData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x0002C82C File Offset: 0x0002AA2C
		// (set) Token: 0x060008CB RID: 2251 RVA: 0x0002C878 File Offset: 0x0002AA78
		public unsafe virtual IList<DimensionProperties> RowMetadata
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridData.NativeMethodInfoPtr_get_RowMetadata_Public_Virtual_New_get_IList_1_DimensionProperties_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<DimensionProperties>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridData.NativeMethodInfoPtr_set_RowMetadata_Public_Virtual_New_set_Void_IList_1_DimensionProperties_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x060008CC RID: 2252 RVA: 0x0002C8C8 File Offset: 0x0002AAC8
		// (set) Token: 0x060008CD RID: 2253 RVA: 0x0002C90C File Offset: 0x0002AB0C
		public unsafe virtual Nullable<int> StartColumn
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridData.NativeMethodInfoPtr_get_StartColumn_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridData.NativeMethodInfoPtr_set_StartColumn_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x060008CE RID: 2254 RVA: 0x0002C960 File Offset: 0x0002AB60
		// (set) Token: 0x060008CF RID: 2255 RVA: 0x0002C9A4 File Offset: 0x0002ABA4
		public unsafe virtual Nullable<int> StartRow
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridData.NativeMethodInfoPtr_get_StartRow_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridData.NativeMethodInfoPtr_set_StartRow_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x060008D0 RID: 2256 RVA: 0x0002C9F8 File Offset: 0x0002ABF8
		// (set) Token: 0x060008D1 RID: 2257 RVA: 0x0002CA3C File Offset: 0x0002AC3C
		public unsafe virtual string ETag
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridData.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridData.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x0002CA8C File Offset: 0x0002AC8C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GridData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GridData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x000062B8 File Offset: 0x000044B8
		public GridData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x060008D4 RID: 2260 RVA: 0x0002CAC8 File Offset: 0x0002ACC8
		// (set) Token: 0x060008D5 RID: 2261 RVA: 0x000062C1 File Offset: 0x000044C1
		public unsafe IList<DimensionProperties> _ColumnMetadata_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridData.NativeFieldInfoPtr__ColumnMetadata_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<DimensionProperties>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridData.NativeFieldInfoPtr__ColumnMetadata_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x060008D6 RID: 2262 RVA: 0x0002CAF8 File Offset: 0x0002ACF8
		// (set) Token: 0x060008D7 RID: 2263 RVA: 0x000062E0 File Offset: 0x000044E0
		public unsafe IList<RowData> _RowData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridData.NativeFieldInfoPtr__RowData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<RowData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridData.NativeFieldInfoPtr__RowData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x060008D8 RID: 2264 RVA: 0x0002CB28 File Offset: 0x0002AD28
		// (set) Token: 0x060008D9 RID: 2265 RVA: 0x000062FF File Offset: 0x000044FF
		public unsafe IList<DimensionProperties> _RowMetadata_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridData.NativeFieldInfoPtr__RowMetadata_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<DimensionProperties>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridData.NativeFieldInfoPtr__RowMetadata_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x060008DA RID: 2266 RVA: 0x0002CB58 File Offset: 0x0002AD58
		// (set) Token: 0x060008DB RID: 2267 RVA: 0x0000631E File Offset: 0x0000451E
		public Nullable<int> _StartColumn_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridData.NativeFieldInfoPtr__StartColumn_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridData.NativeFieldInfoPtr__StartColumn_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x060008DC RID: 2268 RVA: 0x0002CB88 File Offset: 0x0002AD88
		// (set) Token: 0x060008DD RID: 2269 RVA: 0x0000634C File Offset: 0x0000454C
		public Nullable<int> _StartRow_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridData.NativeFieldInfoPtr__StartRow_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridData.NativeFieldInfoPtr__StartRow_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x060008DE RID: 2270 RVA: 0x0002CBB8 File Offset: 0x0002ADB8
		// (set) Token: 0x060008DF RID: 2271 RVA: 0x0000637A File Offset: 0x0000457A
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridData.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridData.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000603 RID: 1539
		private static readonly IntPtr NativeFieldInfoPtr__ColumnMetadata_k__BackingField;

		// Token: 0x04000604 RID: 1540
		private static readonly IntPtr NativeFieldInfoPtr__RowData_k__BackingField;

		// Token: 0x04000605 RID: 1541
		private static readonly IntPtr NativeFieldInfoPtr__RowMetadata_k__BackingField;

		// Token: 0x04000606 RID: 1542
		private static readonly IntPtr NativeFieldInfoPtr__StartColumn_k__BackingField;

		// Token: 0x04000607 RID: 1543
		private static readonly IntPtr NativeFieldInfoPtr__StartRow_k__BackingField;

		// Token: 0x04000608 RID: 1544
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000609 RID: 1545
		private static readonly IntPtr NativeMethodInfoPtr_get_ColumnMetadata_Public_Virtual_New_get_IList_1_DimensionProperties_0;

		// Token: 0x0400060A RID: 1546
		private static readonly IntPtr NativeMethodInfoPtr_set_ColumnMetadata_Public_Virtual_New_set_Void_IList_1_DimensionProperties_0;

		// Token: 0x0400060B RID: 1547
		private static readonly IntPtr NativeMethodInfoPtr_get_RowData_Public_Virtual_New_get_IList_1_RowData_0;

		// Token: 0x0400060C RID: 1548
		private static readonly IntPtr NativeMethodInfoPtr_set_RowData_Public_Virtual_New_set_Void_IList_1_RowData_0;

		// Token: 0x0400060D RID: 1549
		private static readonly IntPtr NativeMethodInfoPtr_get_RowMetadata_Public_Virtual_New_get_IList_1_DimensionProperties_0;

		// Token: 0x0400060E RID: 1550
		private static readonly IntPtr NativeMethodInfoPtr_set_RowMetadata_Public_Virtual_New_set_Void_IList_1_DimensionProperties_0;

		// Token: 0x0400060F RID: 1551
		private static readonly IntPtr NativeMethodInfoPtr_get_StartColumn_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x04000610 RID: 1552
		private static readonly IntPtr NativeMethodInfoPtr_set_StartColumn_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000611 RID: 1553
		private static readonly IntPtr NativeMethodInfoPtr_get_StartRow_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x04000612 RID: 1554
		private static readonly IntPtr NativeMethodInfoPtr_set_StartRow_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000613 RID: 1555
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000614 RID: 1556
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000615 RID: 1557
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
