using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x0200008F RID: 143
	public class TreeView : BaseTreeView
	{
		// Token: 0x06000E6B RID: 3691 RVA: 0x0004FC78 File Offset: 0x0004DE78
		// Note: this type is marked as 'beforefieldinit'.
		static TreeView()
		{
			Il2CppClassPointerStore<TreeView>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TreeView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TreeView>.NativeClassPtr);
			TreeView.NativeFieldInfoPtr_m_MakeItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeView>.NativeClassPtr, "m_MakeItem");
			TreeView.NativeFieldInfoPtr_m_BindItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeView>.NativeClassPtr, "m_BindItem");
			TreeView.NativeFieldInfoPtr__unbindItem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeView>.NativeClassPtr, "<unbindItem>k__BackingField");
			TreeView.NativeFieldInfoPtr__destroyItem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeView>.NativeClassPtr, "<destroyItem>k__BackingField");
			TreeView.NativeMethodInfoPtr_get_makeItem_Public_get_Func_1_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeView>.NativeClassPtr, 100665357);
			TreeView.NativeMethodInfoPtr_set_makeItem_Public_set_Void_Func_1_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeView>.NativeClassPtr, 100665358);
			TreeView.NativeMethodInfoPtr_get_bindItem_Public_get_Action_2_VisualElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeView>.NativeClassPtr, 100665359);
			TreeView.NativeMethodInfoPtr_set_bindItem_Public_set_Void_Action_2_VisualElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeView>.NativeClassPtr, 100665360);
			TreeView.NativeMethodInfoPtr_get_unbindItem_Public_get_Action_2_VisualElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeView>.NativeClassPtr, 100665361);
			TreeView.NativeMethodInfoPtr_get_destroyItem_Public_get_Action_1_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeView>.NativeClassPtr, 100665362);
			TreeView.NativeMethodInfoPtr_HasValidDataAndBindings_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeView>.NativeClassPtr, 100665363);
			TreeView.NativeMethodInfoPtr_CreateViewController_Protected_Virtual_CollectionViewController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeView>.NativeClassPtr, 100665364);
			TreeView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeView>.NativeClassPtr, 100665365);
			TreeView.NativeMethodInfoPtr__ctor_Public_Void_Func_1_VisualElement_Action_2_VisualElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeView>.NativeClassPtr, 100665366);
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06000E6C RID: 3692 RVA: 0x0004FDC0 File Offset: 0x0004DFC0
		// (set) Token: 0x06000E6D RID: 3693 RVA: 0x0004FE00 File Offset: 0x0004E000
		public new unsafe Func<VisualElement> makeItem
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeView.NativeMethodInfoPtr_get_makeItem_Public_get_Func_1_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<VisualElement>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306084, XrefRangeEnd = 306087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeView.NativeMethodInfoPtr_set_makeItem_Public_set_Void_Func_1_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06000E6E RID: 3694 RVA: 0x0004FE44 File Offset: 0x0004E044
		// (set) Token: 0x06000E6F RID: 3695 RVA: 0x0004FE84 File Offset: 0x0004E084
		public new unsafe Action<VisualElement, int> bindItem
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeView.NativeMethodInfoPtr_get_bindItem_Public_get_Action_2_VisualElement_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<VisualElement, int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306087, XrefRangeEnd = 306090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeView.NativeMethodInfoPtr_set_bindItem_Public_set_Void_Action_2_VisualElement_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06000E70 RID: 3696 RVA: 0x0004FEC8 File Offset: 0x0004E0C8
		// (set) Token: 0x06000E7F RID: 3711 RVA: 0x000076D1 File Offset: 0x000058D1
		public new unsafe Action<VisualElement, int> unbindItem
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeView.NativeMethodInfoPtr_get_unbindItem_Public_get_Action_2_VisualElement_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<VisualElement, int>>(intPtr3) : null;
			}
			set
			{
				this._unbindItem_k__BackingField = value;
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06000E71 RID: 3697 RVA: 0x0004FF08 File Offset: 0x0004E108
		// (set) Token: 0x06000E80 RID: 3712 RVA: 0x000076DA File Offset: 0x000058DA
		public new unsafe Action<VisualElement> destroyItem
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeView.NativeMethodInfoPtr_get_destroyItem_Public_get_Action_1_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<VisualElement>>(intPtr3) : null;
			}
			set
			{
				this._destroyItem_k__BackingField = value;
			}
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x0004FF48 File Offset: 0x0004E148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306090, XrefRangeEnd = 306091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool HasValidDataAndBindings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TreeView.NativeMethodInfoPtr_HasValidDataAndBindings_Internal_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x0004FF90 File Offset: 0x0004E190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306091, XrefRangeEnd = 306097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override CollectionViewController CreateViewController()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TreeView.NativeMethodInfoPtr_CreateViewController_Protected_Virtual_CollectionViewController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CollectionViewController>(intPtr3) : null;
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x0004FFDC File Offset: 0x0004E1DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306097, XrefRangeEnd = 306107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TreeView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TreeView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x00050018 File Offset: 0x0004E218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306107, XrefRangeEnd = 306117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TreeView(Func<VisualElement> makeItem, Action<VisualElement, int> bindItem)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TreeView>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(makeItem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bindItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeView.NativeMethodInfoPtr__ctor_Public_Void_Func_1_VisualElement_Action_2_VisualElement_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x0000764C File Offset: 0x0000584C
		public TreeView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06000E77 RID: 3703 RVA: 0x00050078 File Offset: 0x0004E278
		// (set) Token: 0x06000E78 RID: 3704 RVA: 0x00007655 File Offset: 0x00005855
		public unsafe Func<VisualElement> m_MakeItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeView.NativeFieldInfoPtr_m_MakeItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<VisualElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeView.NativeFieldInfoPtr_m_MakeItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000E79 RID: 3705 RVA: 0x000500A8 File Offset: 0x0004E2A8
		// (set) Token: 0x06000E7A RID: 3706 RVA: 0x00007674 File Offset: 0x00005874
		public unsafe Action<VisualElement, int> m_BindItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeView.NativeFieldInfoPtr_m_BindItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<VisualElement, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeView.NativeFieldInfoPtr_m_BindItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06000E7B RID: 3707 RVA: 0x000500D8 File Offset: 0x0004E2D8
		// (set) Token: 0x06000E7C RID: 3708 RVA: 0x00007693 File Offset: 0x00005893
		public unsafe Action<VisualElement, int> _unbindItem_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeView.NativeFieldInfoPtr__unbindItem_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<VisualElement, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeView.NativeFieldInfoPtr__unbindItem_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06000E7D RID: 3709 RVA: 0x00050108 File Offset: 0x0004E308
		// (set) Token: 0x06000E7E RID: 3710 RVA: 0x000076B2 File Offset: 0x000058B2
		public unsafe Action<VisualElement> _destroyItem_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeView.NativeFieldInfoPtr__destroyItem_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<VisualElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeView.NativeFieldInfoPtr__destroyItem_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x000076E3 File Offset: 0x000058E3
		public override void SetRootItemsInternal<T>(IList<TreeViewItemData<T>> rootItems)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06000E82 RID: 3714 RVA: 0x000076F0 File Offset: 0x000058F0
		public new TreeViewController viewController
		{
			get
			{
				return base.viewController.TryCast<TreeViewController>();
			}
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x000076FD File Offset: 0x000058FD
		public override IEnumerable<TreeViewItemData<T>> GetSelectedItemsInternal<T>()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x0000770A File Offset: 0x0000590A
		public override T GetItemDataForIndexInternal<T>(int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x00007717 File Offset: 0x00005917
		public override T GetItemDataForIdInternal<T>(int id)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x00007724 File Offset: 0x00005924
		public override void AddItemInternal<T>(TreeViewItemData<T> item, int parentId, int childIndex, bool rebuildTree)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04000A0E RID: 2574
		private static readonly IntPtr NativeFieldInfoPtr_m_MakeItem;

		// Token: 0x04000A0F RID: 2575
		private static readonly IntPtr NativeFieldInfoPtr_m_BindItem;

		// Token: 0x04000A10 RID: 2576
		private static readonly IntPtr NativeFieldInfoPtr__unbindItem_k__BackingField;

		// Token: 0x04000A11 RID: 2577
		private static readonly IntPtr NativeFieldInfoPtr__destroyItem_k__BackingField;

		// Token: 0x04000A12 RID: 2578
		private static readonly IntPtr NativeMethodInfoPtr_get_makeItem_Public_get_Func_1_VisualElement_0;

		// Token: 0x04000A13 RID: 2579
		private static readonly IntPtr NativeMethodInfoPtr_set_makeItem_Public_set_Void_Func_1_VisualElement_0;

		// Token: 0x04000A14 RID: 2580
		private static readonly IntPtr NativeMethodInfoPtr_get_bindItem_Public_get_Action_2_VisualElement_Int32_0;

		// Token: 0x04000A15 RID: 2581
		private static readonly IntPtr NativeMethodInfoPtr_set_bindItem_Public_set_Void_Action_2_VisualElement_Int32_0;

		// Token: 0x04000A16 RID: 2582
		private static readonly IntPtr NativeMethodInfoPtr_get_unbindItem_Public_get_Action_2_VisualElement_Int32_0;

		// Token: 0x04000A17 RID: 2583
		private static readonly IntPtr NativeMethodInfoPtr_get_destroyItem_Public_get_Action_1_VisualElement_0;

		// Token: 0x04000A18 RID: 2584
		private static readonly IntPtr NativeMethodInfoPtr_HasValidDataAndBindings_Internal_Virtual_Boolean_0;

		// Token: 0x04000A19 RID: 2585
		private static readonly IntPtr NativeMethodInfoPtr_CreateViewController_Protected_Virtual_CollectionViewController_0;

		// Token: 0x04000A1A RID: 2586
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000A1B RID: 2587
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_1_VisualElement_Action_2_VisualElement_Int32_0;

		// Token: 0x020003CB RID: 971
		public new class UxmlFactory : UxmlFactory<TreeView, TreeView.UxmlTraits>
		{
			// Token: 0x060039BF RID: 14783 RVA: 0x000185FB File Offset: 0x000167FB
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<TreeView.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TreeView>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TreeView.UxmlFactory>.NativeClassPtr);
				TreeView.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeView.UxmlFactory>.NativeClassPtr, 100665367);
			}

			// Token: 0x060039C0 RID: 14784 RVA: 0x000EA38C File Offset: 0x000E858C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 306082, RefRangeEnd = 306083, XrefRangeStart = 306079, XrefRangeEnd = 306082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TreeView.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeView.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039C1 RID: 14785 RVA: 0x0001862F File Offset: 0x0001682F
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040028D4 RID: 10452
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020003CC RID: 972
		public new class UxmlTraits : BaseTreeView.UxmlTraits
		{
			// Token: 0x060039C2 RID: 14786 RVA: 0x00018638 File Offset: 0x00016838
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<TreeView.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TreeView>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TreeView.UxmlTraits>.NativeClassPtr);
				TreeView.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeView.UxmlTraits>.NativeClassPtr, 100665368);
			}

			// Token: 0x060039C3 RID: 14787 RVA: 0x000EA3C8 File Offset: 0x000E85C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306083, XrefRangeEnd = 306084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TreeView.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeView.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039C4 RID: 14788 RVA: 0x0001866C File Offset: 0x0001686C
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040028D5 RID: 10453
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
