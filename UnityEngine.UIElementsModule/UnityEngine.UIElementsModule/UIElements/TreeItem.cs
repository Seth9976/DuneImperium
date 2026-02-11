using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000091 RID: 145
	public sealed class TreeItem : ValueType
	{
		// Token: 0x06000EA0 RID: 3744 RVA: 0x00050898 File Offset: 0x0004EA98
		// Note: this type is marked as 'beforefieldinit'.
		static TreeItem()
		{
			Il2CppClassPointerStore<TreeItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TreeItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TreeItem>.NativeClassPtr);
			TreeItem.NativeFieldInfoPtr__id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeItem>.NativeClassPtr, "<id>k__BackingField");
			TreeItem.NativeFieldInfoPtr__parentId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeItem>.NativeClassPtr, "<parentId>k__BackingField");
			TreeItem.NativeFieldInfoPtr__childrenIds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeItem>.NativeClassPtr, "<childrenIds>k__BackingField");
			TreeItem.NativeMethodInfoPtr_get_id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeItem>.NativeClassPtr, 100665380);
			TreeItem.NativeMethodInfoPtr_get_parentId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeItem>.NativeClassPtr, 100665381);
			TreeItem.NativeMethodInfoPtr_get_childrenIds_Public_get_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeItem>.NativeClassPtr, 100665382);
			TreeItem.NativeMethodInfoPtr_get_hasChildren_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeItem>.NativeClassPtr, 100665383);
			TreeItem.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeItem>.NativeClassPtr, 100665384);
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06000EA1 RID: 3745 RVA: 0x00050968 File Offset: 0x0004EB68
		public unsafe int id
		{
			[CallerCount(200)]
			[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeItem.NativeMethodInfoPtr_get_id_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000EA2 RID: 3746 RVA: 0x000509AC File Offset: 0x0004EBAC
		public unsafe int parentId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeItem.NativeMethodInfoPtr_get_parentId_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06000EA3 RID: 3747 RVA: 0x000509F0 File Offset: 0x0004EBF0
		public unsafe IEnumerable<int> childrenIds
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeItem.NativeMethodInfoPtr_get_childrenIds_Public_get_IEnumerable_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000EA4 RID: 3748 RVA: 0x00050A34 File Offset: 0x0004EC34
		public unsafe bool hasChildren
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 306631, RefRangeEnd = 306633, XrefRangeStart = 306630, XrefRangeEnd = 306631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeItem.NativeMethodInfoPtr_get_hasChildren_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x00050A78 File Offset: 0x0004EC78
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 306634, RefRangeEnd = 306640, XrefRangeStart = 306633, XrefRangeEnd = 306634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TreeItem(int id, int parentId = -1, IEnumerable<int> childrenIds = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TreeItem>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parentId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(childrenIds);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeItem.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_IEnumerable_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x000077C8 File Offset: 0x000059C8
		public TreeItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x000077D1 File Offset: 0x000059D1
		public TreeItem()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TreeItem>.NativeClassPtr))
		{
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06000EA8 RID: 3752 RVA: 0x00050AE4 File Offset: 0x0004ECE4
		// (set) Token: 0x06000EA9 RID: 3753 RVA: 0x000077E3 File Offset: 0x000059E3
		public unsafe int _id_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeItem.NativeFieldInfoPtr__id_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeItem.NativeFieldInfoPtr__id_k__BackingField)) = value;
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06000EAA RID: 3754 RVA: 0x00050B0C File Offset: 0x0004ED0C
		// (set) Token: 0x06000EAB RID: 3755 RVA: 0x000077FE File Offset: 0x000059FE
		public unsafe int _parentId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeItem.NativeFieldInfoPtr__parentId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeItem.NativeFieldInfoPtr__parentId_k__BackingField)) = value;
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06000EAC RID: 3756 RVA: 0x00050B34 File Offset: 0x0004ED34
		// (set) Token: 0x06000EAD RID: 3757 RVA: 0x00007819 File Offset: 0x00005A19
		public unsafe IEnumerable<int> _childrenIds_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeItem.NativeFieldInfoPtr__childrenIds_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeItem.NativeFieldInfoPtr__childrenIds_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A2B RID: 2603
		private static readonly IntPtr NativeFieldInfoPtr__id_k__BackingField;

		// Token: 0x04000A2C RID: 2604
		private static readonly IntPtr NativeFieldInfoPtr__parentId_k__BackingField;

		// Token: 0x04000A2D RID: 2605
		private static readonly IntPtr NativeFieldInfoPtr__childrenIds_k__BackingField;

		// Token: 0x04000A2E RID: 2606
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_get_Int32_0;

		// Token: 0x04000A2F RID: 2607
		private static readonly IntPtr NativeMethodInfoPtr_get_parentId_Public_get_Int32_0;

		// Token: 0x04000A30 RID: 2608
		private static readonly IntPtr NativeMethodInfoPtr_get_childrenIds_Public_get_IEnumerable_1_Int32_0;

		// Token: 0x04000A31 RID: 2609
		private static readonly IntPtr NativeMethodInfoPtr_get_hasChildren_Public_get_Boolean_0;

		// Token: 0x04000A32 RID: 2610
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_IEnumerable_1_Int32_0;

		// Token: 0x04000A33 RID: 2611
		public const int invalidId = -1;
	}
}
