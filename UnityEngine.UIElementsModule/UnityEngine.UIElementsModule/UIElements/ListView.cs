using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200006F RID: 111
	public class ListView : BaseListView
	{
		// Token: 0x06000A4D RID: 2637 RVA: 0x000413F4 File Offset: 0x0003F5F4
		// Note: this type is marked as 'beforefieldinit'.
		static ListView()
		{
			Il2CppClassPointerStore<ListView>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ListView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListView>.NativeClassPtr);
			ListView.NativeFieldInfoPtr_m_MakeItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListView>.NativeClassPtr, "m_MakeItem");
			ListView.NativeFieldInfoPtr_m_BindItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListView>.NativeClassPtr, "m_BindItem");
			ListView.NativeFieldInfoPtr__unbindItem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListView>.NativeClassPtr, "<unbindItem>k__BackingField");
			ListView.NativeFieldInfoPtr__destroyItem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListView>.NativeClassPtr, "<destroyItem>k__BackingField");
			ListView.NativeMethodInfoPtr_get_makeItem_Public_get_Func_1_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListView>.NativeClassPtr, 100664789);
			ListView.NativeMethodInfoPtr_get_bindItem_Public_get_Action_2_VisualElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListView>.NativeClassPtr, 100664790);
			ListView.NativeMethodInfoPtr_get_unbindItem_Public_get_Action_2_VisualElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListView>.NativeClassPtr, 100664791);
			ListView.NativeMethodInfoPtr_get_destroyItem_Public_get_Action_1_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListView>.NativeClassPtr, 100664792);
			ListView.NativeMethodInfoPtr_HasValidDataAndBindings_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListView>.NativeClassPtr, 100664793);
			ListView.NativeMethodInfoPtr_CreateViewController_Protected_Virtual_CollectionViewController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListView>.NativeClassPtr, 100664794);
			ListView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListView>.NativeClassPtr, 100664795);
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000A4E RID: 2638 RVA: 0x00041500 File Offset: 0x0003F700
		// (set) Token: 0x06000A5E RID: 2654 RVA: 0x00041790 File Offset: 0x0003F990
		public new unsafe Func<VisualElement> makeItem
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListView.NativeMethodInfoPtr_get_makeItem_Public_get_Func_1_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<VisualElement>>(intPtr3) : null;
			}
			set
			{
				bool flag = value != this.m_MakeItem;
				if (flag)
				{
					this.m_MakeItem = value;
					base.Rebuild();
				}
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000A4F RID: 2639 RVA: 0x00041540 File Offset: 0x0003F740
		// (set) Token: 0x06000A60 RID: 2656 RVA: 0x000417C0 File Offset: 0x0003F9C0
		public new unsafe Action<VisualElement, int> bindItem
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListView.NativeMethodInfoPtr_get_bindItem_Public_get_Action_2_VisualElement_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<VisualElement, int>>(intPtr3) : null;
			}
			set
			{
				bool flag = value != this.m_BindItem;
				if (flag)
				{
					this.m_BindItem = value;
					base.RefreshItems();
				}
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000A50 RID: 2640 RVA: 0x00041580 File Offset: 0x0003F780
		// (set) Token: 0x06000A62 RID: 2658 RVA: 0x00005C1B File Offset: 0x00003E1B
		public new unsafe Action<VisualElement, int> unbindItem
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListView.NativeMethodInfoPtr_get_unbindItem_Public_get_Action_2_VisualElement_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<VisualElement, int>>(intPtr3) : null;
			}
			set
			{
				this._unbindItem_k__BackingField = value;
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000A51 RID: 2641 RVA: 0x000415C0 File Offset: 0x0003F7C0
		// (set) Token: 0x06000A63 RID: 2659 RVA: 0x00005C24 File Offset: 0x00003E24
		public new unsafe Action<VisualElement> destroyItem
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListView.NativeMethodInfoPtr_get_destroyItem_Public_get_Action_1_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<VisualElement>>(intPtr3) : null;
			}
			set
			{
				this._destroyItem_k__BackingField = value;
			}
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00041600 File Offset: 0x0003F800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299434, XrefRangeEnd = 299435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool HasValidDataAndBindings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ListView.NativeMethodInfoPtr_HasValidDataAndBindings_Internal_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x00041648 File Offset: 0x0003F848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299435, XrefRangeEnd = 299439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override CollectionViewController CreateViewController()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ListView.NativeMethodInfoPtr_CreateViewController_Protected_Virtual_CollectionViewController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CollectionViewController>(intPtr3) : null;
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x00041694 File Offset: 0x0003F894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299439, XrefRangeEnd = 299445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x00005B82 File Offset: 0x00003D82
		public ListView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000A56 RID: 2646 RVA: 0x000416D0 File Offset: 0x0003F8D0
		// (set) Token: 0x06000A57 RID: 2647 RVA: 0x00005B8B File Offset: 0x00003D8B
		public unsafe Func<VisualElement> m_MakeItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListView.NativeFieldInfoPtr_m_MakeItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<VisualElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListView.NativeFieldInfoPtr_m_MakeItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000A58 RID: 2648 RVA: 0x00041700 File Offset: 0x0003F900
		// (set) Token: 0x06000A59 RID: 2649 RVA: 0x00005BAA File Offset: 0x00003DAA
		public unsafe Action<VisualElement, int> m_BindItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListView.NativeFieldInfoPtr_m_BindItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<VisualElement, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListView.NativeFieldInfoPtr_m_BindItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000A5A RID: 2650 RVA: 0x00041730 File Offset: 0x0003F930
		// (set) Token: 0x06000A5B RID: 2651 RVA: 0x00005BC9 File Offset: 0x00003DC9
		public unsafe Action<VisualElement, int> _unbindItem_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListView.NativeFieldInfoPtr__unbindItem_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<VisualElement, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListView.NativeFieldInfoPtr__unbindItem_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000A5C RID: 2652 RVA: 0x00041760 File Offset: 0x0003F960
		// (set) Token: 0x06000A5D RID: 2653 RVA: 0x00005BE8 File Offset: 0x00003DE8
		public unsafe Action<VisualElement> _destroyItem_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListView.NativeFieldInfoPtr__destroyItem_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<VisualElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListView.NativeFieldInfoPtr__destroyItem_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x00005C07 File Offset: 0x00003E07
		public void SetMakeItemWithoutNotify(Func<VisualElement> func)
		{
			this.m_MakeItem = func;
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x00005C11 File Offset: 0x00003E11
		public void SetBindItemWithoutNotify(Action<VisualElement, int> callback)
		{
			this.m_BindItem = callback;
		}

		// Token: 0x04000719 RID: 1817
		private static readonly IntPtr NativeFieldInfoPtr_m_MakeItem;

		// Token: 0x0400071A RID: 1818
		private static readonly IntPtr NativeFieldInfoPtr_m_BindItem;

		// Token: 0x0400071B RID: 1819
		private static readonly IntPtr NativeFieldInfoPtr__unbindItem_k__BackingField;

		// Token: 0x0400071C RID: 1820
		private static readonly IntPtr NativeFieldInfoPtr__destroyItem_k__BackingField;

		// Token: 0x0400071D RID: 1821
		private static readonly IntPtr NativeMethodInfoPtr_get_makeItem_Public_get_Func_1_VisualElement_0;

		// Token: 0x0400071E RID: 1822
		private static readonly IntPtr NativeMethodInfoPtr_get_bindItem_Public_get_Action_2_VisualElement_Int32_0;

		// Token: 0x0400071F RID: 1823
		private static readonly IntPtr NativeMethodInfoPtr_get_unbindItem_Public_get_Action_2_VisualElement_Int32_0;

		// Token: 0x04000720 RID: 1824
		private static readonly IntPtr NativeMethodInfoPtr_get_destroyItem_Public_get_Action_1_VisualElement_0;

		// Token: 0x04000721 RID: 1825
		private static readonly IntPtr NativeMethodInfoPtr_HasValidDataAndBindings_Internal_Virtual_Boolean_0;

		// Token: 0x04000722 RID: 1826
		private static readonly IntPtr NativeMethodInfoPtr_CreateViewController_Protected_Virtual_CollectionViewController_0;

		// Token: 0x04000723 RID: 1827
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000391 RID: 913
		public new class UxmlFactory : UxmlFactory<ListView, ListView.UxmlTraits>
		{
			// Token: 0x06003870 RID: 14448 RVA: 0x0001776E File Offset: 0x0001596E
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<ListView.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListView>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListView.UxmlFactory>.NativeClassPtr);
				ListView.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListView.UxmlFactory>.NativeClassPtr, 100664796);
			}

			// Token: 0x06003871 RID: 14449 RVA: 0x000E671C File Offset: 0x000E491C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 299432, RefRangeEnd = 299433, XrefRangeStart = 299429, XrefRangeEnd = 299432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListView.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListView.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003872 RID: 14450 RVA: 0x000177A2 File Offset: 0x000159A2
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400281A RID: 10266
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000392 RID: 914
		public new class UxmlTraits : BaseListView.UxmlTraits
		{
			// Token: 0x06003873 RID: 14451 RVA: 0x000177AB File Offset: 0x000159AB
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<ListView.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListView>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListView.UxmlTraits>.NativeClassPtr);
				ListView.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListView.UxmlTraits>.NativeClassPtr, 100664797);
			}

			// Token: 0x06003874 RID: 14452 RVA: 0x000E6758 File Offset: 0x000E4958
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299433, XrefRangeEnd = 299434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListView.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListView.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003875 RID: 14453 RVA: 0x000177DF File Offset: 0x000159DF
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400281B RID: 10267
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
