using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000090 RID: 144
	public class PivotGroup : Object
	{
		// Token: 0x06000AD3 RID: 2771 RVA: 0x000342A8 File Offset: 0x000324A8
		// Note: this type is marked as 'beforefieldinit'.
		static PivotGroup()
		{
			Il2CppClassPointerStore<PivotGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "PivotGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PivotGroup>.NativeClassPtr);
			PivotGroup.NativeFieldInfoPtr__GroupRule_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotGroup>.NativeClassPtr, "<GroupRule>k__BackingField");
			PivotGroup.NativeFieldInfoPtr__Label_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotGroup>.NativeClassPtr, "<Label>k__BackingField");
			PivotGroup.NativeFieldInfoPtr__RepeatHeadings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotGroup>.NativeClassPtr, "<RepeatHeadings>k__BackingField");
			PivotGroup.NativeFieldInfoPtr__ShowTotals_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotGroup>.NativeClassPtr, "<ShowTotals>k__BackingField");
			PivotGroup.NativeFieldInfoPtr__SortOrder_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotGroup>.NativeClassPtr, "<SortOrder>k__BackingField");
			PivotGroup.NativeFieldInfoPtr__SourceColumnOffset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotGroup>.NativeClassPtr, "<SourceColumnOffset>k__BackingField");
			PivotGroup.NativeFieldInfoPtr__ValueBucket_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotGroup>.NativeClassPtr, "<ValueBucket>k__BackingField");
			PivotGroup.NativeFieldInfoPtr__ValueMetadata_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotGroup>.NativeClassPtr, "<ValueMetadata>k__BackingField");
			PivotGroup.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotGroup>.NativeClassPtr, "<ETag>k__BackingField");
			PivotGroup.NativeMethodInfoPtr_get_GroupRule_Public_Virtual_New_get_PivotGroupRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotGroup>.NativeClassPtr, 100664834);
			PivotGroup.NativeMethodInfoPtr_set_GroupRule_Public_Virtual_New_set_Void_PivotGroupRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotGroup>.NativeClassPtr, 100664835);
			PivotGroup.NativeMethodInfoPtr_get_Label_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotGroup>.NativeClassPtr, 100664836);
			PivotGroup.NativeMethodInfoPtr_set_Label_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotGroup>.NativeClassPtr, 100664837);
			PivotGroup.NativeMethodInfoPtr_get_RepeatHeadings_Public_Virtual_New_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotGroup>.NativeClassPtr, 100664838);
			PivotGroup.NativeMethodInfoPtr_set_RepeatHeadings_Public_Virtual_New_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotGroup>.NativeClassPtr, 100664839);
			PivotGroup.NativeMethodInfoPtr_get_ShowTotals_Public_Virtual_New_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotGroup>.NativeClassPtr, 100664840);
			PivotGroup.NativeMethodInfoPtr_set_ShowTotals_Public_Virtual_New_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotGroup>.NativeClassPtr, 100664841);
			PivotGroup.NativeMethodInfoPtr_get_SortOrder_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotGroup>.NativeClassPtr, 100664842);
			PivotGroup.NativeMethodInfoPtr_set_SortOrder_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotGroup>.NativeClassPtr, 100664843);
			PivotGroup.NativeMethodInfoPtr_get_SourceColumnOffset_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotGroup>.NativeClassPtr, 100664844);
			PivotGroup.NativeMethodInfoPtr_set_SourceColumnOffset_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotGroup>.NativeClassPtr, 100664845);
			PivotGroup.NativeMethodInfoPtr_get_ValueBucket_Public_Virtual_New_get_PivotGroupSortValueBucket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotGroup>.NativeClassPtr, 100664846);
			PivotGroup.NativeMethodInfoPtr_set_ValueBucket_Public_Virtual_New_set_Void_PivotGroupSortValueBucket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotGroup>.NativeClassPtr, 100664847);
			PivotGroup.NativeMethodInfoPtr_get_ValueMetadata_Public_Virtual_New_get_IList_1_PivotGroupValueMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotGroup>.NativeClassPtr, 100664848);
			PivotGroup.NativeMethodInfoPtr_set_ValueMetadata_Public_Virtual_New_set_Void_IList_1_PivotGroupValueMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotGroup>.NativeClassPtr, 100664849);
			PivotGroup.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotGroup>.NativeClassPtr, 100664850);
			PivotGroup.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotGroup>.NativeClassPtr, 100664851);
			PivotGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotGroup>.NativeClassPtr, 100664852);
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06000AD4 RID: 2772 RVA: 0x00034508 File Offset: 0x00032708
		// (set) Token: 0x06000AD5 RID: 2773 RVA: 0x00034554 File Offset: 0x00032754
		public unsafe virtual PivotGroupRule GroupRule
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotGroup.NativeMethodInfoPtr_get_GroupRule_Public_Virtual_New_get_PivotGroupRule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PivotGroupRule>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotGroup.NativeMethodInfoPtr_set_GroupRule_Public_Virtual_New_set_Void_PivotGroupRule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000AD6 RID: 2774 RVA: 0x000345A4 File Offset: 0x000327A4
		// (set) Token: 0x06000AD7 RID: 2775 RVA: 0x000345E8 File Offset: 0x000327E8
		public unsafe virtual string Label
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotGroup.NativeMethodInfoPtr_get_Label_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotGroup.NativeMethodInfoPtr_set_Label_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000AD8 RID: 2776 RVA: 0x00034638 File Offset: 0x00032838
		// (set) Token: 0x06000AD9 RID: 2777 RVA: 0x0003467C File Offset: 0x0003287C
		public unsafe virtual Nullable<bool> RepeatHeadings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotGroup.NativeMethodInfoPtr_get_RepeatHeadings_Public_Virtual_New_get_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotGroup.NativeMethodInfoPtr_set_RepeatHeadings_Public_Virtual_New_set_Void_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06000ADA RID: 2778 RVA: 0x000346D0 File Offset: 0x000328D0
		// (set) Token: 0x06000ADB RID: 2779 RVA: 0x00034714 File Offset: 0x00032914
		public unsafe virtual Nullable<bool> ShowTotals
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotGroup.NativeMethodInfoPtr_get_ShowTotals_Public_Virtual_New_get_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotGroup.NativeMethodInfoPtr_set_ShowTotals_Public_Virtual_New_set_Void_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06000ADC RID: 2780 RVA: 0x00034768 File Offset: 0x00032968
		// (set) Token: 0x06000ADD RID: 2781 RVA: 0x000347AC File Offset: 0x000329AC
		public unsafe virtual string SortOrder
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotGroup.NativeMethodInfoPtr_get_SortOrder_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotGroup.NativeMethodInfoPtr_set_SortOrder_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06000ADE RID: 2782 RVA: 0x000347FC File Offset: 0x000329FC
		// (set) Token: 0x06000ADF RID: 2783 RVA: 0x00034840 File Offset: 0x00032A40
		public unsafe virtual Nullable<int> SourceColumnOffset
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotGroup.NativeMethodInfoPtr_get_SourceColumnOffset_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotGroup.NativeMethodInfoPtr_set_SourceColumnOffset_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x00034894 File Offset: 0x00032A94
		// (set) Token: 0x06000AE1 RID: 2785 RVA: 0x000348E0 File Offset: 0x00032AE0
		public unsafe virtual PivotGroupSortValueBucket ValueBucket
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotGroup.NativeMethodInfoPtr_get_ValueBucket_Public_Virtual_New_get_PivotGroupSortValueBucket_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PivotGroupSortValueBucket>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotGroup.NativeMethodInfoPtr_set_ValueBucket_Public_Virtual_New_set_Void_PivotGroupSortValueBucket_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x00034930 File Offset: 0x00032B30
		// (set) Token: 0x06000AE3 RID: 2787 RVA: 0x0003497C File Offset: 0x00032B7C
		public unsafe virtual IList<PivotGroupValueMetadata> ValueMetadata
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotGroup.NativeMethodInfoPtr_get_ValueMetadata_Public_Virtual_New_get_IList_1_PivotGroupValueMetadata_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<PivotGroupValueMetadata>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotGroup.NativeMethodInfoPtr_set_ValueMetadata_Public_Virtual_New_set_Void_IList_1_PivotGroupValueMetadata_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000AE4 RID: 2788 RVA: 0x000349CC File Offset: 0x00032BCC
		// (set) Token: 0x06000AE5 RID: 2789 RVA: 0x00034A10 File Offset: 0x00032C10
		public unsafe virtual string ETag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotGroup.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotGroup.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x00034A60 File Offset: 0x00032C60
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PivotGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PivotGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PivotGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x0000734E File Offset: 0x0000554E
		public PivotGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000AE8 RID: 2792 RVA: 0x00034A9C File Offset: 0x00032C9C
		// (set) Token: 0x06000AE9 RID: 2793 RVA: 0x00007357 File Offset: 0x00005557
		public unsafe PivotGroupRule _GroupRule_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotGroup.NativeFieldInfoPtr__GroupRule_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PivotGroupRule>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotGroup.NativeFieldInfoPtr__GroupRule_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06000AEA RID: 2794 RVA: 0x00034ACC File Offset: 0x00032CCC
		// (set) Token: 0x06000AEB RID: 2795 RVA: 0x00007376 File Offset: 0x00005576
		public unsafe string _Label_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotGroup.NativeFieldInfoPtr__Label_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotGroup.NativeFieldInfoPtr__Label_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000AEC RID: 2796 RVA: 0x00034AF4 File Offset: 0x00032CF4
		// (set) Token: 0x06000AED RID: 2797 RVA: 0x00007395 File Offset: 0x00005595
		public Nullable<bool> _RepeatHeadings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotGroup.NativeFieldInfoPtr__RepeatHeadings_k__BackingField);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotGroup.NativeFieldInfoPtr__RepeatHeadings_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000AEE RID: 2798 RVA: 0x00034B24 File Offset: 0x00032D24
		// (set) Token: 0x06000AEF RID: 2799 RVA: 0x000073C3 File Offset: 0x000055C3
		public Nullable<bool> _ShowTotals_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotGroup.NativeFieldInfoPtr__ShowTotals_k__BackingField);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotGroup.NativeFieldInfoPtr__ShowTotals_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000AF0 RID: 2800 RVA: 0x00034B54 File Offset: 0x00032D54
		// (set) Token: 0x06000AF1 RID: 2801 RVA: 0x000073F1 File Offset: 0x000055F1
		public unsafe string _SortOrder_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotGroup.NativeFieldInfoPtr__SortOrder_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotGroup.NativeFieldInfoPtr__SortOrder_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06000AF2 RID: 2802 RVA: 0x00034B7C File Offset: 0x00032D7C
		// (set) Token: 0x06000AF3 RID: 2803 RVA: 0x00007410 File Offset: 0x00005610
		public Nullable<int> _SourceColumnOffset_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotGroup.NativeFieldInfoPtr__SourceColumnOffset_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotGroup.NativeFieldInfoPtr__SourceColumnOffset_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06000AF4 RID: 2804 RVA: 0x00034BAC File Offset: 0x00032DAC
		// (set) Token: 0x06000AF5 RID: 2805 RVA: 0x0000743E File Offset: 0x0000563E
		public unsafe PivotGroupSortValueBucket _ValueBucket_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotGroup.NativeFieldInfoPtr__ValueBucket_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PivotGroupSortValueBucket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotGroup.NativeFieldInfoPtr__ValueBucket_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06000AF6 RID: 2806 RVA: 0x00034BDC File Offset: 0x00032DDC
		// (set) Token: 0x06000AF7 RID: 2807 RVA: 0x0000745D File Offset: 0x0000565D
		public unsafe IList<PivotGroupValueMetadata> _ValueMetadata_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotGroup.NativeFieldInfoPtr__ValueMetadata_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<PivotGroupValueMetadata>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotGroup.NativeFieldInfoPtr__ValueMetadata_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000AF8 RID: 2808 RVA: 0x00034C0C File Offset: 0x00032E0C
		// (set) Token: 0x06000AF9 RID: 2809 RVA: 0x0000747C File Offset: 0x0000567C
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotGroup.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotGroup.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400076D RID: 1901
		private static readonly IntPtr NativeFieldInfoPtr__GroupRule_k__BackingField;

		// Token: 0x0400076E RID: 1902
		private static readonly IntPtr NativeFieldInfoPtr__Label_k__BackingField;

		// Token: 0x0400076F RID: 1903
		private static readonly IntPtr NativeFieldInfoPtr__RepeatHeadings_k__BackingField;

		// Token: 0x04000770 RID: 1904
		private static readonly IntPtr NativeFieldInfoPtr__ShowTotals_k__BackingField;

		// Token: 0x04000771 RID: 1905
		private static readonly IntPtr NativeFieldInfoPtr__SortOrder_k__BackingField;

		// Token: 0x04000772 RID: 1906
		private static readonly IntPtr NativeFieldInfoPtr__SourceColumnOffset_k__BackingField;

		// Token: 0x04000773 RID: 1907
		private static readonly IntPtr NativeFieldInfoPtr__ValueBucket_k__BackingField;

		// Token: 0x04000774 RID: 1908
		private static readonly IntPtr NativeFieldInfoPtr__ValueMetadata_k__BackingField;

		// Token: 0x04000775 RID: 1909
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000776 RID: 1910
		private static readonly IntPtr NativeMethodInfoPtr_get_GroupRule_Public_Virtual_New_get_PivotGroupRule_0;

		// Token: 0x04000777 RID: 1911
		private static readonly IntPtr NativeMethodInfoPtr_set_GroupRule_Public_Virtual_New_set_Void_PivotGroupRule_0;

		// Token: 0x04000778 RID: 1912
		private static readonly IntPtr NativeMethodInfoPtr_get_Label_Public_Virtual_New_get_String_0;

		// Token: 0x04000779 RID: 1913
		private static readonly IntPtr NativeMethodInfoPtr_set_Label_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400077A RID: 1914
		private static readonly IntPtr NativeMethodInfoPtr_get_RepeatHeadings_Public_Virtual_New_get_Nullable_1_Boolean_0;

		// Token: 0x0400077B RID: 1915
		private static readonly IntPtr NativeMethodInfoPtr_set_RepeatHeadings_Public_Virtual_New_set_Void_Nullable_1_Boolean_0;

		// Token: 0x0400077C RID: 1916
		private static readonly IntPtr NativeMethodInfoPtr_get_ShowTotals_Public_Virtual_New_get_Nullable_1_Boolean_0;

		// Token: 0x0400077D RID: 1917
		private static readonly IntPtr NativeMethodInfoPtr_set_ShowTotals_Public_Virtual_New_set_Void_Nullable_1_Boolean_0;

		// Token: 0x0400077E RID: 1918
		private static readonly IntPtr NativeMethodInfoPtr_get_SortOrder_Public_Virtual_New_get_String_0;

		// Token: 0x0400077F RID: 1919
		private static readonly IntPtr NativeMethodInfoPtr_set_SortOrder_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000780 RID: 1920
		private static readonly IntPtr NativeMethodInfoPtr_get_SourceColumnOffset_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x04000781 RID: 1921
		private static readonly IntPtr NativeMethodInfoPtr_set_SourceColumnOffset_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000782 RID: 1922
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueBucket_Public_Virtual_New_get_PivotGroupSortValueBucket_0;

		// Token: 0x04000783 RID: 1923
		private static readonly IntPtr NativeMethodInfoPtr_set_ValueBucket_Public_Virtual_New_set_Void_PivotGroupSortValueBucket_0;

		// Token: 0x04000784 RID: 1924
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueMetadata_Public_Virtual_New_get_IList_1_PivotGroupValueMetadata_0;

		// Token: 0x04000785 RID: 1925
		private static readonly IntPtr NativeMethodInfoPtr_set_ValueMetadata_Public_Virtual_New_set_Void_IList_1_PivotGroupValueMetadata_0;

		// Token: 0x04000786 RID: 1926
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000787 RID: 1927
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000788 RID: 1928
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
