using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000092 RID: 146
	public sealed class TreeViewItemWrapper : ValueType
	{
		// Token: 0x06000EAE RID: 3758 RVA: 0x00050B64 File Offset: 0x0004ED64
		// Note: this type is marked as 'beforefieldinit'.
		static TreeViewItemWrapper()
		{
			Il2CppClassPointerStore<TreeViewItemWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TreeViewItemWrapper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TreeViewItemWrapper>.NativeClassPtr);
			TreeViewItemWrapper.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeViewItemWrapper>.NativeClassPtr, "item");
			TreeViewItemWrapper.NativeFieldInfoPtr_depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeViewItemWrapper>.NativeClassPtr, "depth");
			TreeViewItemWrapper.NativeMethodInfoPtr_get_id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeViewItemWrapper>.NativeClassPtr, 100665385);
			TreeViewItemWrapper.NativeMethodInfoPtr_get_childrenIds_Public_get_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeViewItemWrapper>.NativeClassPtr, 100665386);
			TreeViewItemWrapper.NativeMethodInfoPtr_get_hasChildren_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeViewItemWrapper>.NativeClassPtr, 100665387);
			TreeViewItemWrapper.NativeMethodInfoPtr__ctor_Public_Void_TreeItem_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeViewItemWrapper>.NativeClassPtr, 100665388);
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000EAF RID: 3759 RVA: 0x00050C0C File Offset: 0x0004EE0C
		public unsafe int id
		{
			[CallerCount(200)]
			[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeViewItemWrapper.NativeMethodInfoPtr_get_id_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000EB0 RID: 3760 RVA: 0x00050C50 File Offset: 0x0004EE50
		public unsafe IEnumerable<int> childrenIds
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeViewItemWrapper.NativeMethodInfoPtr_get_childrenIds_Public_get_IEnumerable_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000EB1 RID: 3761 RVA: 0x00050C94 File Offset: 0x0004EE94
		public unsafe bool hasChildren
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 306631, RefRangeEnd = 306633, XrefRangeStart = 306631, XrefRangeEnd = 306633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeViewItemWrapper.NativeMethodInfoPtr_get_hasChildren_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x00050CD8 File Offset: 0x0004EED8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 306641, RefRangeEnd = 306642, XrefRangeStart = 306640, XrefRangeEnd = 306641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TreeViewItemWrapper(TreeItem item, int depth)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TreeViewItemWrapper>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeViewItemWrapper.NativeMethodInfoPtr__ctor_Public_Void_TreeItem_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x00007838 File Offset: 0x00005A38
		public TreeViewItemWrapper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x00007841 File Offset: 0x00005A41
		public TreeViewItemWrapper()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TreeViewItemWrapper>.NativeClassPtr))
		{
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000EB5 RID: 3765 RVA: 0x00050D3C File Offset: 0x0004EF3C
		// (set) Token: 0x06000EB6 RID: 3766 RVA: 0x00007853 File Offset: 0x00005A53
		public TreeItem item
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeViewItemWrapper.NativeFieldInfoPtr_item);
				return new TreeItem(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TreeItem>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeViewItemWrapper.NativeFieldInfoPtr_item), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TreeItem>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000EB7 RID: 3767 RVA: 0x00050D6C File Offset: 0x0004EF6C
		// (set) Token: 0x06000EB8 RID: 3768 RVA: 0x00007881 File Offset: 0x00005A81
		public unsafe int depth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeViewItemWrapper.NativeFieldInfoPtr_depth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeViewItemWrapper.NativeFieldInfoPtr_depth)) = value;
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000EB9 RID: 3769 RVA: 0x0000789C File Offset: 0x00005A9C
		public int parentId
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x04000A34 RID: 2612
		private static readonly IntPtr NativeFieldInfoPtr_item;

		// Token: 0x04000A35 RID: 2613
		private static readonly IntPtr NativeFieldInfoPtr_depth;

		// Token: 0x04000A36 RID: 2614
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_get_Int32_0;

		// Token: 0x04000A37 RID: 2615
		private static readonly IntPtr NativeMethodInfoPtr_get_childrenIds_Public_get_IEnumerable_1_Int32_0;

		// Token: 0x04000A38 RID: 2616
		private static readonly IntPtr NativeMethodInfoPtr_get_hasChildren_Public_get_Boolean_0;

		// Token: 0x04000A39 RID: 2617
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TreeItem_Int32_0;
	}
}
