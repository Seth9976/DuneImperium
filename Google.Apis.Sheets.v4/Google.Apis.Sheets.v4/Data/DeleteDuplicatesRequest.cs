using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000058 RID: 88
	public class DeleteDuplicatesRequest : Object
	{
		// Token: 0x0600067B RID: 1659 RVA: 0x00023A44 File Offset: 0x00021C44
		// Note: this type is marked as 'beforefieldinit'.
		static DeleteDuplicatesRequest()
		{
			Il2CppClassPointerStore<DeleteDuplicatesRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "DeleteDuplicatesRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeleteDuplicatesRequest>.NativeClassPtr);
			DeleteDuplicatesRequest.NativeFieldInfoPtr__ComparisonColumns_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteDuplicatesRequest>.NativeClassPtr, "<ComparisonColumns>k__BackingField");
			DeleteDuplicatesRequest.NativeFieldInfoPtr__Range_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteDuplicatesRequest>.NativeClassPtr, "<Range>k__BackingField");
			DeleteDuplicatesRequest.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteDuplicatesRequest>.NativeClassPtr, "<ETag>k__BackingField");
			DeleteDuplicatesRequest.NativeMethodInfoPtr_get_ComparisonColumns_Public_Virtual_New_get_IList_1_DimensionRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDuplicatesRequest>.NativeClassPtr, 100664306);
			DeleteDuplicatesRequest.NativeMethodInfoPtr_set_ComparisonColumns_Public_Virtual_New_set_Void_IList_1_DimensionRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDuplicatesRequest>.NativeClassPtr, 100664307);
			DeleteDuplicatesRequest.NativeMethodInfoPtr_get_Range_Public_Virtual_New_get_GridRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDuplicatesRequest>.NativeClassPtr, 100664308);
			DeleteDuplicatesRequest.NativeMethodInfoPtr_set_Range_Public_Virtual_New_set_Void_GridRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDuplicatesRequest>.NativeClassPtr, 100664309);
			DeleteDuplicatesRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDuplicatesRequest>.NativeClassPtr, 100664310);
			DeleteDuplicatesRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDuplicatesRequest>.NativeClassPtr, 100664311);
			DeleteDuplicatesRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDuplicatesRequest>.NativeClassPtr, 100664312);
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x0600067C RID: 1660 RVA: 0x00023B3C File Offset: 0x00021D3C
		// (set) Token: 0x0600067D RID: 1661 RVA: 0x00023B88 File Offset: 0x00021D88
		public unsafe virtual IList<DimensionRange> ComparisonColumns
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeleteDuplicatesRequest.NativeMethodInfoPtr_get_ComparisonColumns_Public_Virtual_New_get_IList_1_DimensionRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<DimensionRange>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeleteDuplicatesRequest.NativeMethodInfoPtr_set_ComparisonColumns_Public_Virtual_New_set_Void_IList_1_DimensionRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x0600067E RID: 1662 RVA: 0x00023BD8 File Offset: 0x00021DD8
		// (set) Token: 0x0600067F RID: 1663 RVA: 0x00023C24 File Offset: 0x00021E24
		public unsafe virtual GridRange Range
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeleteDuplicatesRequest.NativeMethodInfoPtr_get_Range_Public_Virtual_New_get_GridRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeleteDuplicatesRequest.NativeMethodInfoPtr_set_Range_Public_Virtual_New_set_Void_GridRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000680 RID: 1664 RVA: 0x00023C74 File Offset: 0x00021E74
		// (set) Token: 0x06000681 RID: 1665 RVA: 0x00023CB8 File Offset: 0x00021EB8
		public unsafe virtual string ETag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeleteDuplicatesRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeleteDuplicatesRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00023D08 File Offset: 0x00021F08
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeleteDuplicatesRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeleteDuplicatesRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteDuplicatesRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x00005021 File Offset: 0x00003221
		public DeleteDuplicatesRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000684 RID: 1668 RVA: 0x00023D44 File Offset: 0x00021F44
		// (set) Token: 0x06000685 RID: 1669 RVA: 0x0000502A File Offset: 0x0000322A
		public unsafe IList<DimensionRange> _ComparisonColumns_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteDuplicatesRequest.NativeFieldInfoPtr__ComparisonColumns_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<DimensionRange>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteDuplicatesRequest.NativeFieldInfoPtr__ComparisonColumns_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000686 RID: 1670 RVA: 0x00023D74 File Offset: 0x00021F74
		// (set) Token: 0x06000687 RID: 1671 RVA: 0x00005049 File Offset: 0x00003249
		public unsafe GridRange _Range_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteDuplicatesRequest.NativeFieldInfoPtr__Range_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridRange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteDuplicatesRequest.NativeFieldInfoPtr__Range_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000688 RID: 1672 RVA: 0x00023DA4 File Offset: 0x00021FA4
		// (set) Token: 0x06000689 RID: 1673 RVA: 0x00005068 File Offset: 0x00003268
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteDuplicatesRequest.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteDuplicatesRequest.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000471 RID: 1137
		private static readonly IntPtr NativeFieldInfoPtr__ComparisonColumns_k__BackingField;

		// Token: 0x04000472 RID: 1138
		private static readonly IntPtr NativeFieldInfoPtr__Range_k__BackingField;

		// Token: 0x04000473 RID: 1139
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000474 RID: 1140
		private static readonly IntPtr NativeMethodInfoPtr_get_ComparisonColumns_Public_Virtual_New_get_IList_1_DimensionRange_0;

		// Token: 0x04000475 RID: 1141
		private static readonly IntPtr NativeMethodInfoPtr_set_ComparisonColumns_Public_Virtual_New_set_Void_IList_1_DimensionRange_0;

		// Token: 0x04000476 RID: 1142
		private static readonly IntPtr NativeMethodInfoPtr_get_Range_Public_Virtual_New_get_GridRange_0;

		// Token: 0x04000477 RID: 1143
		private static readonly IntPtr NativeMethodInfoPtr_set_Range_Public_Virtual_New_set_Void_GridRange_0;

		// Token: 0x04000478 RID: 1144
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000479 RID: 1145
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400047A RID: 1146
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
