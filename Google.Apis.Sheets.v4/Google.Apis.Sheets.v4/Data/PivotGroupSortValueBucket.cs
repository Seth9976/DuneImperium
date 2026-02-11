using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000092 RID: 146
	public class PivotGroupSortValueBucket : Object
	{
		// Token: 0x06000B0D RID: 2829 RVA: 0x000350C4 File Offset: 0x000332C4
		// Note: this type is marked as 'beforefieldinit'.
		static PivotGroupSortValueBucket()
		{
			Il2CppClassPointerStore<PivotGroupSortValueBucket>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "PivotGroupSortValueBucket");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PivotGroupSortValueBucket>.NativeClassPtr);
			PivotGroupSortValueBucket.NativeFieldInfoPtr__Buckets_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotGroupSortValueBucket>.NativeClassPtr, "<Buckets>k__BackingField");
			PivotGroupSortValueBucket.NativeFieldInfoPtr__ValuesIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotGroupSortValueBucket>.NativeClassPtr, "<ValuesIndex>k__BackingField");
			PivotGroupSortValueBucket.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotGroupSortValueBucket>.NativeClassPtr, "<ETag>k__BackingField");
			PivotGroupSortValueBucket.NativeMethodInfoPtr_get_Buckets_Public_Virtual_New_get_IList_1_ExtendedValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotGroupSortValueBucket>.NativeClassPtr, 100664862);
			PivotGroupSortValueBucket.NativeMethodInfoPtr_set_Buckets_Public_Virtual_New_set_Void_IList_1_ExtendedValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotGroupSortValueBucket>.NativeClassPtr, 100664863);
			PivotGroupSortValueBucket.NativeMethodInfoPtr_get_ValuesIndex_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotGroupSortValueBucket>.NativeClassPtr, 100664864);
			PivotGroupSortValueBucket.NativeMethodInfoPtr_set_ValuesIndex_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotGroupSortValueBucket>.NativeClassPtr, 100664865);
			PivotGroupSortValueBucket.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotGroupSortValueBucket>.NativeClassPtr, 100664866);
			PivotGroupSortValueBucket.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotGroupSortValueBucket>.NativeClassPtr, 100664867);
			PivotGroupSortValueBucket.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotGroupSortValueBucket>.NativeClassPtr, 100664868);
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000B0E RID: 2830 RVA: 0x000351BC File Offset: 0x000333BC
		// (set) Token: 0x06000B0F RID: 2831 RVA: 0x00035208 File Offset: 0x00033408
		public unsafe virtual IList<ExtendedValue> Buckets
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotGroupSortValueBucket.NativeMethodInfoPtr_get_Buckets_Public_Virtual_New_get_IList_1_ExtendedValue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<ExtendedValue>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotGroupSortValueBucket.NativeMethodInfoPtr_set_Buckets_Public_Virtual_New_set_Void_IList_1_ExtendedValue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06000B10 RID: 2832 RVA: 0x00035258 File Offset: 0x00033458
		// (set) Token: 0x06000B11 RID: 2833 RVA: 0x0003529C File Offset: 0x0003349C
		public unsafe virtual Nullable<int> ValuesIndex
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotGroupSortValueBucket.NativeMethodInfoPtr_get_ValuesIndex_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotGroupSortValueBucket.NativeMethodInfoPtr_set_ValuesIndex_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06000B12 RID: 2834 RVA: 0x000352F0 File Offset: 0x000334F0
		// (set) Token: 0x06000B13 RID: 2835 RVA: 0x00035334 File Offset: 0x00033534
		public unsafe virtual string ETag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotGroupSortValueBucket.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotGroupSortValueBucket.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x00035384 File Offset: 0x00033584
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PivotGroupSortValueBucket()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PivotGroupSortValueBucket>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PivotGroupSortValueBucket.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x00007520 File Offset: 0x00005720
		public PivotGroupSortValueBucket(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06000B16 RID: 2838 RVA: 0x000353C0 File Offset: 0x000335C0
		// (set) Token: 0x06000B17 RID: 2839 RVA: 0x00007529 File Offset: 0x00005729
		public unsafe IList<ExtendedValue> _Buckets_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotGroupSortValueBucket.NativeFieldInfoPtr__Buckets_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<ExtendedValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotGroupSortValueBucket.NativeFieldInfoPtr__Buckets_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000B18 RID: 2840 RVA: 0x000353F0 File Offset: 0x000335F0
		// (set) Token: 0x06000B19 RID: 2841 RVA: 0x00007548 File Offset: 0x00005748
		public Nullable<int> _ValuesIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotGroupSortValueBucket.NativeFieldInfoPtr__ValuesIndex_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotGroupSortValueBucket.NativeFieldInfoPtr__ValuesIndex_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000B1A RID: 2842 RVA: 0x00035420 File Offset: 0x00033620
		// (set) Token: 0x06000B1B RID: 2843 RVA: 0x00007576 File Offset: 0x00005776
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotGroupSortValueBucket.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotGroupSortValueBucket.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000796 RID: 1942
		private static readonly IntPtr NativeFieldInfoPtr__Buckets_k__BackingField;

		// Token: 0x04000797 RID: 1943
		private static readonly IntPtr NativeFieldInfoPtr__ValuesIndex_k__BackingField;

		// Token: 0x04000798 RID: 1944
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000799 RID: 1945
		private static readonly IntPtr NativeMethodInfoPtr_get_Buckets_Public_Virtual_New_get_IList_1_ExtendedValue_0;

		// Token: 0x0400079A RID: 1946
		private static readonly IntPtr NativeMethodInfoPtr_set_Buckets_Public_Virtual_New_set_Void_IList_1_ExtendedValue_0;

		// Token: 0x0400079B RID: 1947
		private static readonly IntPtr NativeMethodInfoPtr_get_ValuesIndex_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x0400079C RID: 1948
		private static readonly IntPtr NativeMethodInfoPtr_set_ValuesIndex_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x0400079D RID: 1949
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x0400079E RID: 1950
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400079F RID: 1951
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
