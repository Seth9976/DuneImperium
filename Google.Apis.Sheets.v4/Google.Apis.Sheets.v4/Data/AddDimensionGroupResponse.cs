using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x0200000B RID: 11
	public class AddDimensionGroupResponse : Object
	{
		// Token: 0x0600009C RID: 156 RVA: 0x0000D514 File Offset: 0x0000B714
		// Note: this type is marked as 'beforefieldinit'.
		static AddDimensionGroupResponse()
		{
			Il2CppClassPointerStore<AddDimensionGroupResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "AddDimensionGroupResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddDimensionGroupResponse>.NativeClassPtr);
			AddDimensionGroupResponse.NativeFieldInfoPtr__DimensionGroups_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddDimensionGroupResponse>.NativeClassPtr, "<DimensionGroups>k__BackingField");
			AddDimensionGroupResponse.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddDimensionGroupResponse>.NativeClassPtr, "<ETag>k__BackingField");
			AddDimensionGroupResponse.NativeMethodInfoPtr_get_DimensionGroups_Public_Virtual_New_get_IList_1_DimensionGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddDimensionGroupResponse>.NativeClassPtr, 100663593);
			AddDimensionGroupResponse.NativeMethodInfoPtr_set_DimensionGroups_Public_Virtual_New_set_Void_IList_1_DimensionGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddDimensionGroupResponse>.NativeClassPtr, 100663594);
			AddDimensionGroupResponse.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddDimensionGroupResponse>.NativeClassPtr, 100663595);
			AddDimensionGroupResponse.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddDimensionGroupResponse>.NativeClassPtr, 100663596);
			AddDimensionGroupResponse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddDimensionGroupResponse>.NativeClassPtr, 100663597);
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600009D RID: 157 RVA: 0x0000D5D0 File Offset: 0x0000B7D0
		// (set) Token: 0x0600009E RID: 158 RVA: 0x0000D61C File Offset: 0x0000B81C
		public unsafe virtual IList<DimensionGroup> DimensionGroups
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddDimensionGroupResponse.NativeMethodInfoPtr_get_DimensionGroups_Public_Virtual_New_get_IList_1_DimensionGroup_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<DimensionGroup>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddDimensionGroupResponse.NativeMethodInfoPtr_set_DimensionGroups_Public_Virtual_New_set_Void_IList_1_DimensionGroup_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600009F RID: 159 RVA: 0x0000D66C File Offset: 0x0000B86C
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x0000D6B0 File Offset: 0x0000B8B0
		public unsafe virtual string ETag
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddDimensionGroupResponse.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddDimensionGroupResponse.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000D700 File Offset: 0x0000B900
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddDimensionGroupResponse()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddDimensionGroupResponse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddDimensionGroupResponse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002492 File Offset: 0x00000692
		public AddDimensionGroupResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x0000D73C File Offset: 0x0000B93C
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x0000249B File Offset: 0x0000069B
		public unsafe IList<DimensionGroup> _DimensionGroups_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddDimensionGroupResponse.NativeFieldInfoPtr__DimensionGroups_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<DimensionGroup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddDimensionGroupResponse.NativeFieldInfoPtr__DimensionGroups_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x0000D76C File Offset: 0x0000B96C
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x000024BA File Offset: 0x000006BA
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddDimensionGroupResponse.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddDimensionGroupResponse.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeFieldInfoPtr__DimensionGroups_k__BackingField;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_get_DimensionGroups_Public_Virtual_New_get_IList_1_DimensionGroup_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_set_DimensionGroups_Public_Virtual_New_set_Void_IList_1_DimensionGroup_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
