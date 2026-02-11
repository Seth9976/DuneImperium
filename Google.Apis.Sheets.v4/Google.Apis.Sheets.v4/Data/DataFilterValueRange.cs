using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x0200004D RID: 77
	public class DataFilterValueRange : Object
	{
		// Token: 0x060005EA RID: 1514 RVA: 0x000218D8 File Offset: 0x0001FAD8
		// Note: this type is marked as 'beforefieldinit'.
		static DataFilterValueRange()
		{
			Il2CppClassPointerStore<DataFilterValueRange>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "DataFilterValueRange");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataFilterValueRange>.NativeClassPtr);
			DataFilterValueRange.NativeFieldInfoPtr__DataFilter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataFilterValueRange>.NativeClassPtr, "<DataFilter>k__BackingField");
			DataFilterValueRange.NativeFieldInfoPtr__MajorDimension_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataFilterValueRange>.NativeClassPtr, "<MajorDimension>k__BackingField");
			DataFilterValueRange.NativeFieldInfoPtr__Values_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataFilterValueRange>.NativeClassPtr, "<Values>k__BackingField");
			DataFilterValueRange.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataFilterValueRange>.NativeClassPtr, "<ETag>k__BackingField");
			DataFilterValueRange.NativeMethodInfoPtr_get_DataFilter_Public_Virtual_New_get_DataFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataFilterValueRange>.NativeClassPtr, 100664239);
			DataFilterValueRange.NativeMethodInfoPtr_set_DataFilter_Public_Virtual_New_set_Void_DataFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataFilterValueRange>.NativeClassPtr, 100664240);
			DataFilterValueRange.NativeMethodInfoPtr_get_MajorDimension_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataFilterValueRange>.NativeClassPtr, 100664241);
			DataFilterValueRange.NativeMethodInfoPtr_set_MajorDimension_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataFilterValueRange>.NativeClassPtr, 100664242);
			DataFilterValueRange.NativeMethodInfoPtr_get_Values_Public_Virtual_New_get_IList_1_IList_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataFilterValueRange>.NativeClassPtr, 100664243);
			DataFilterValueRange.NativeMethodInfoPtr_set_Values_Public_Virtual_New_set_Void_IList_1_IList_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataFilterValueRange>.NativeClassPtr, 100664244);
			DataFilterValueRange.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataFilterValueRange>.NativeClassPtr, 100664245);
			DataFilterValueRange.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataFilterValueRange>.NativeClassPtr, 100664246);
			DataFilterValueRange.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataFilterValueRange>.NativeClassPtr, 100664247);
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x00021A0C File Offset: 0x0001FC0C
		// (set) Token: 0x060005EC RID: 1516 RVA: 0x00021A58 File Offset: 0x0001FC58
		public unsafe virtual DataFilter DataFilter
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataFilterValueRange.NativeMethodInfoPtr_get_DataFilter_Public_Virtual_New_get_DataFilter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataFilter>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataFilterValueRange.NativeMethodInfoPtr_set_DataFilter_Public_Virtual_New_set_Void_DataFilter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x00021AA8 File Offset: 0x0001FCA8
		// (set) Token: 0x060005EE RID: 1518 RVA: 0x00021AEC File Offset: 0x0001FCEC
		public unsafe virtual string MajorDimension
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataFilterValueRange.NativeMethodInfoPtr_get_MajorDimension_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataFilterValueRange.NativeMethodInfoPtr_set_MajorDimension_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x060005EF RID: 1519 RVA: 0x00021B3C File Offset: 0x0001FD3C
		// (set) Token: 0x060005F0 RID: 1520 RVA: 0x00021B88 File Offset: 0x0001FD88
		public unsafe virtual IList<IList<Object>> Values
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataFilterValueRange.NativeMethodInfoPtr_get_Values_Public_Virtual_New_get_IList_1_IList_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<IList<Object>>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataFilterValueRange.NativeMethodInfoPtr_set_Values_Public_Virtual_New_set_Void_IList_1_IList_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x060005F1 RID: 1521 RVA: 0x00021BD8 File Offset: 0x0001FDD8
		// (set) Token: 0x060005F2 RID: 1522 RVA: 0x00021C1C File Offset: 0x0001FE1C
		public unsafe virtual string ETag
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataFilterValueRange.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataFilterValueRange.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00021C6C File Offset: 0x0001FE6C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataFilterValueRange()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataFilterValueRange>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataFilterValueRange.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00004C0F File Offset: 0x00002E0F
		public DataFilterValueRange(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x00021CA8 File Offset: 0x0001FEA8
		// (set) Token: 0x060005F6 RID: 1526 RVA: 0x00004C18 File Offset: 0x00002E18
		public unsafe DataFilter _DataFilter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataFilterValueRange.NativeFieldInfoPtr__DataFilter_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataFilterValueRange.NativeFieldInfoPtr__DataFilter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x00021CD8 File Offset: 0x0001FED8
		// (set) Token: 0x060005F8 RID: 1528 RVA: 0x00004C37 File Offset: 0x00002E37
		public unsafe string _MajorDimension_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataFilterValueRange.NativeFieldInfoPtr__MajorDimension_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataFilterValueRange.NativeFieldInfoPtr__MajorDimension_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x060005F9 RID: 1529 RVA: 0x00021D00 File Offset: 0x0001FF00
		// (set) Token: 0x060005FA RID: 1530 RVA: 0x00004C56 File Offset: 0x00002E56
		public unsafe IList<IList<Object>> _Values_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataFilterValueRange.NativeFieldInfoPtr__Values_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<IList<Object>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataFilterValueRange.NativeFieldInfoPtr__Values_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x00021D30 File Offset: 0x0001FF30
		// (set) Token: 0x060005FC RID: 1532 RVA: 0x00004C75 File Offset: 0x00002E75
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataFilterValueRange.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataFilterValueRange.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000412 RID: 1042
		private static readonly IntPtr NativeFieldInfoPtr__DataFilter_k__BackingField;

		// Token: 0x04000413 RID: 1043
		private static readonly IntPtr NativeFieldInfoPtr__MajorDimension_k__BackingField;

		// Token: 0x04000414 RID: 1044
		private static readonly IntPtr NativeFieldInfoPtr__Values_k__BackingField;

		// Token: 0x04000415 RID: 1045
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000416 RID: 1046
		private static readonly IntPtr NativeMethodInfoPtr_get_DataFilter_Public_Virtual_New_get_DataFilter_0;

		// Token: 0x04000417 RID: 1047
		private static readonly IntPtr NativeMethodInfoPtr_set_DataFilter_Public_Virtual_New_set_Void_DataFilter_0;

		// Token: 0x04000418 RID: 1048
		private static readonly IntPtr NativeMethodInfoPtr_get_MajorDimension_Public_Virtual_New_get_String_0;

		// Token: 0x04000419 RID: 1049
		private static readonly IntPtr NativeMethodInfoPtr_set_MajorDimension_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400041A RID: 1050
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_Virtual_New_get_IList_1_IList_1_Object_0;

		// Token: 0x0400041B RID: 1051
		private static readonly IntPtr NativeMethodInfoPtr_set_Values_Public_Virtual_New_set_Void_IList_1_IList_1_Object_0;

		// Token: 0x0400041C RID: 1052
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x0400041D RID: 1053
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400041E RID: 1054
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
