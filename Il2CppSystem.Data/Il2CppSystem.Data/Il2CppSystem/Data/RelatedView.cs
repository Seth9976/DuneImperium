using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Data
{
	// Token: 0x02000071 RID: 113
	public sealed class RelatedView : DataView
	{
		// Token: 0x06000A8E RID: 2702 RVA: 0x000369B4 File Offset: 0x00034BB4
		// Note: this type is marked as 'beforefieldinit'.
		static RelatedView()
		{
			Il2CppClassPointerStore<RelatedView>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "RelatedView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RelatedView>.NativeClassPtr);
			RelatedView.NativeFieldInfoPtr__parentKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelatedView>.NativeClassPtr, "_parentKey");
			RelatedView.NativeFieldInfoPtr__childKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelatedView>.NativeClassPtr, "_childKey");
			RelatedView.NativeFieldInfoPtr__parentRowView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelatedView>.NativeClassPtr, "_parentRowView");
			RelatedView.NativeFieldInfoPtr__filterValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelatedView>.NativeClassPtr, "_filterValues");
			RelatedView.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_DataColumn_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelatedView>.NativeClassPtr, 100665048);
			RelatedView.NativeMethodInfoPtr__ctor_Public_Void_DataRowView_DataKey_Il2CppReferenceArray_1_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelatedView>.NativeClassPtr, 100665049);
			RelatedView.NativeMethodInfoPtr_GetParentValues_Private_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelatedView>.NativeClassPtr, 100665050);
			RelatedView.NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Boolean_DataRow_DataRowVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelatedView>.NativeClassPtr, 100665051);
			RelatedView.NativeMethodInfoPtr_GetFilter_Internal_Virtual_IFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelatedView>.NativeClassPtr, 100665052);
			RelatedView.NativeMethodInfoPtr_AddNew_Public_Virtual_DataRowView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelatedView>.NativeClassPtr, 100665053);
			RelatedView.NativeMethodInfoPtr_SetIndex_Internal_Virtual_Void_String_DataViewRowState_IFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelatedView>.NativeClassPtr, 100665054);
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x00036AC0 File Offset: 0x00034CC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 906261, RefRangeEnd = 906262, XrefRangeStart = 906250, XrefRangeEnd = 906261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RelatedView(Il2CppReferenceArray<DataColumn> columns, Il2CppReferenceArray<Object> values)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RelatedView>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(columns);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelatedView.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_DataColumn_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x00036B20 File Offset: 0x00034D20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 906275, RefRangeEnd = 906276, XrefRangeStart = 906262, XrefRangeEnd = 906275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RelatedView(DataRowView parentRowView, DataKey parentKey, Il2CppReferenceArray<DataColumn> childKeyColumns)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RelatedView>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentRowView);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(parentKey));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(childKeyColumns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelatedView.NativeMethodInfoPtr__ctor_Public_Void_DataRowView_DataKey_Il2CppReferenceArray_1_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x00036B94 File Offset: 0x00034D94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 906282, RefRangeEnd = 906284, XrefRangeStart = 906276, XrefRangeEnd = 906282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Object> GetParentValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelatedView.NativeMethodInfoPtr_GetParentValues_Private_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x00036BD4 File Offset: 0x00034DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 906284, XrefRangeEnd = 906290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Invoke(DataRow row, DataRowVersion version)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref version;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelatedView.NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Boolean_DataRow_DataRowVersion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x00036C30 File Offset: 0x00034E30
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IFilter GetFilter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelatedView.NativeMethodInfoPtr_GetFilter_Internal_Virtual_IFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFilter>(intPtr3) : null;
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x00036C70 File Offset: 0x00034E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 906290, XrefRangeEnd = 906293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DataRowView AddNew()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelatedView.NativeMethodInfoPtr_AddNew_Public_Virtual_DataRowView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataRowView>(intPtr3) : null;
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x00036CB0 File Offset: 0x00034EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 906293, XrefRangeEnd = 906295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(newSort);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newRowStates;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newRowFilter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelatedView.NativeMethodInfoPtr_SetIndex_Internal_Virtual_Void_String_DataViewRowState_IFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x00005294 File Offset: 0x00003494
		public RelatedView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x00036D14 File Offset: 0x00034F14
		// (set) Token: 0x06000A98 RID: 2712 RVA: 0x0000529D File Offset: 0x0000349D
		public Nullable<DataKey> _parentKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelatedView.NativeFieldInfoPtr__parentKey);
				return new Nullable<DataKey>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<DataKey>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelatedView.NativeFieldInfoPtr__parentKey), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<DataKey>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x00036D44 File Offset: 0x00034F44
		// (set) Token: 0x06000A9A RID: 2714 RVA: 0x000052CB File Offset: 0x000034CB
		public DataKey _childKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelatedView.NativeFieldInfoPtr__childKey);
				return new DataKey(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DataKey>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelatedView.NativeFieldInfoPtr__childKey), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DataKey>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x00036D74 File Offset: 0x00034F74
		// (set) Token: 0x06000A9C RID: 2716 RVA: 0x000052F9 File Offset: 0x000034F9
		public unsafe DataRowView _parentRowView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelatedView.NativeFieldInfoPtr__parentRowView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataRowView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelatedView.NativeFieldInfoPtr__parentRowView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x00036DA4 File Offset: 0x00034FA4
		// (set) Token: 0x06000A9E RID: 2718 RVA: 0x00005318 File Offset: 0x00003518
		public unsafe Il2CppReferenceArray<Object> _filterValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelatedView.NativeFieldInfoPtr__filterValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelatedView.NativeFieldInfoPtr__filterValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008DA RID: 2266
		private static readonly IntPtr NativeFieldInfoPtr__parentKey;

		// Token: 0x040008DB RID: 2267
		private static readonly IntPtr NativeFieldInfoPtr__childKey;

		// Token: 0x040008DC RID: 2268
		private static readonly IntPtr NativeFieldInfoPtr__parentRowView;

		// Token: 0x040008DD RID: 2269
		private static readonly IntPtr NativeFieldInfoPtr__filterValues;

		// Token: 0x040008DE RID: 2270
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_DataColumn_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040008DF RID: 2271
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataRowView_DataKey_Il2CppReferenceArray_1_DataColumn_0;

		// Token: 0x040008E0 RID: 2272
		private static readonly IntPtr NativeMethodInfoPtr_GetParentValues_Private_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040008E1 RID: 2273
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Boolean_DataRow_DataRowVersion_0;

		// Token: 0x040008E2 RID: 2274
		private static readonly IntPtr NativeMethodInfoPtr_GetFilter_Internal_Virtual_IFilter_0;

		// Token: 0x040008E3 RID: 2275
		private static readonly IntPtr NativeMethodInfoPtr_AddNew_Public_Virtual_DataRowView_0;

		// Token: 0x040008E4 RID: 2276
		private static readonly IntPtr NativeMethodInfoPtr_SetIndex_Internal_Virtual_Void_String_DataViewRowState_IFilter_0;
	}
}
