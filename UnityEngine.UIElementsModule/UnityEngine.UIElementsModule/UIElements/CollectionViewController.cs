using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace UnityEngine.UIElements
{
	// Token: 0x02000029 RID: 41
	public class CollectionViewController : Object
	{
		// Token: 0x060002E5 RID: 741 RVA: 0x00027628 File Offset: 0x00025828
		// Note: this type is marked as 'beforefieldinit'.
		static CollectionViewController()
		{
			Il2CppClassPointerStore<CollectionViewController>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "CollectionViewController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectionViewController>.NativeClassPtr);
			CollectionViewController.NativeFieldInfoPtr_m_View = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectionViewController>.NativeClassPtr, "m_View");
			CollectionViewController.NativeFieldInfoPtr_m_ItemsSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectionViewController>.NativeClassPtr, "m_ItemsSource");
			CollectionViewController.NativeFieldInfoPtr_itemsSourceChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectionViewController>.NativeClassPtr, "itemsSourceChanged");
			CollectionViewController.NativeFieldInfoPtr_itemIndexChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectionViewController>.NativeClassPtr, "itemIndexChanged");
			CollectionViewController.NativeMethodInfoPtr_add_itemsSourceChanged_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionViewController>.NativeClassPtr, 100663696);
			CollectionViewController.NativeMethodInfoPtr_remove_itemsSourceChanged_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionViewController>.NativeClassPtr, 100663697);
			CollectionViewController.NativeMethodInfoPtr_add_itemIndexChanged_Public_add_Void_Action_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionViewController>.NativeClassPtr, 100663698);
			CollectionViewController.NativeMethodInfoPtr_remove_itemIndexChanged_Public_rem_Void_Action_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionViewController>.NativeClassPtr, 100663699);
			CollectionViewController.NativeMethodInfoPtr_get_itemsSource_Public_Virtual_New_get_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionViewController>.NativeClassPtr, 100663700);
			CollectionViewController.NativeMethodInfoPtr_set_itemsSource_Public_Virtual_New_set_Void_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionViewController>.NativeClassPtr, 100663701);
			CollectionViewController.NativeMethodInfoPtr_SetItemsSourceWithoutNotify_Protected_Void_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionViewController>.NativeClassPtr, 100663702);
			CollectionViewController.NativeMethodInfoPtr_get_view_Protected_get_BaseVerticalCollectionView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionViewController>.NativeClassPtr, 100663703);
			CollectionViewController.NativeMethodInfoPtr_SetView_Public_Void_BaseVerticalCollectionView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionViewController>.NativeClassPtr, 100663704);
			CollectionViewController.NativeMethodInfoPtr_PrepareView_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionViewController>.NativeClassPtr, 100663705);
			CollectionViewController.NativeMethodInfoPtr_Dispose_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionViewController>.NativeClassPtr, 100663706);
			CollectionViewController.NativeMethodInfoPtr_GetItemsCount_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionViewController>.NativeClassPtr, 100663707);
			CollectionViewController.NativeMethodInfoPtr_GetItemsMinCount_Internal_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionViewController>.NativeClassPtr, 100663708);
			CollectionViewController.NativeMethodInfoPtr_GetIndexForId_Public_Virtual_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionViewController>.NativeClassPtr, 100663709);
			CollectionViewController.NativeMethodInfoPtr_GetIdForIndex_Public_Virtual_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionViewController>.NativeClassPtr, 100663710);
			CollectionViewController.NativeMethodInfoPtr_GetItemForIndex_Public_Virtual_New_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionViewController>.NativeClassPtr, 100663711);
			CollectionViewController.NativeMethodInfoPtr_InvokeMakeItem_Internal_Virtual_New_Void_ReusableCollectionItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionViewController>.NativeClassPtr, 100663712);
			CollectionViewController.NativeMethodInfoPtr_InvokeBindItem_Internal_Virtual_New_Void_ReusableCollectionItem_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionViewController>.NativeClassPtr, 100663713);
			CollectionViewController.NativeMethodInfoPtr_InvokeUnbindItem_Internal_Virtual_New_Void_ReusableCollectionItem_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionViewController>.NativeClassPtr, 100663714);
			CollectionViewController.NativeMethodInfoPtr_InvokeDestroyItem_Internal_Virtual_New_Void_ReusableCollectionItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionViewController>.NativeClassPtr, 100663715);
			CollectionViewController.NativeMethodInfoPtr_MakeItem_Protected_Abstract_Virtual_New_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionViewController>.NativeClassPtr, 100663716);
			CollectionViewController.NativeMethodInfoPtr_BindItem_Protected_Abstract_Virtual_New_Void_VisualElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionViewController>.NativeClassPtr, 100663717);
			CollectionViewController.NativeMethodInfoPtr_UnbindItem_Protected_Abstract_Virtual_New_Void_VisualElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionViewController>.NativeClassPtr, 100663718);
			CollectionViewController.NativeMethodInfoPtr_DestroyItem_Protected_Abstract_Virtual_New_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionViewController>.NativeClassPtr, 100663719);
			CollectionViewController.NativeMethodInfoPtr_RaiseItemsSourceChanged_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionViewController>.NativeClassPtr, 100663720);
			CollectionViewController.NativeMethodInfoPtr_RaiseItemIndexChanged_Protected_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionViewController>.NativeClassPtr, 100663721);
			CollectionViewController.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionViewController>.NativeClassPtr, 100663722);
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x000278C4 File Offset: 0x00025AC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 285909, RefRangeEnd = 285911, XrefRangeStart = 285905, XrefRangeEnd = 285909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_itemsSourceChanged(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionViewController.NativeMethodInfoPtr_add_itemsSourceChanged_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00027908 File Offset: 0x00025B08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 285915, RefRangeEnd = 285917, XrefRangeStart = 285911, XrefRangeEnd = 285915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_itemsSourceChanged(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionViewController.NativeMethodInfoPtr_remove_itemsSourceChanged_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0002794C File Offset: 0x00025B4C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 285922, RefRangeEnd = 285925, XrefRangeStart = 285917, XrefRangeEnd = 285922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_itemIndexChanged(Action<int, int> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionViewController.NativeMethodInfoPtr_add_itemIndexChanged_Public_add_Void_Action_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00027990 File Offset: 0x00025B90
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 285930, RefRangeEnd = 285933, XrefRangeStart = 285925, XrefRangeEnd = 285930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_itemIndexChanged(Action<int, int> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionViewController.NativeMethodInfoPtr_remove_itemIndexChanged_Public_rem_Void_Action_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060002EA RID: 746 RVA: 0x000279D4 File Offset: 0x00025BD4
		// (set) Token: 0x060002EB RID: 747 RVA: 0x00027A20 File Offset: 0x00025C20
		public unsafe virtual IList itemsSource
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionViewController.NativeMethodInfoPtr_get_itemsSource_Public_Virtual_New_get_IList_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285933, XrefRangeEnd = 285939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionViewController.NativeMethodInfoPtr_set_itemsSource_Public_Virtual_New_set_Void_IList_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00027A70 File Offset: 0x00025C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285939, XrefRangeEnd = 285940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetItemsSourceWithoutNotify(IList source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionViewController.NativeMethodInfoPtr_SetItemsSourceWithoutNotify_Protected_Void_IList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060002ED RID: 749 RVA: 0x00027AB4 File Offset: 0x00025CB4
		public unsafe BaseVerticalCollectionView view
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionViewController.NativeMethodInfoPtr_get_view_Protected_get_BaseVerticalCollectionView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseVerticalCollectionView>(intPtr3) : null;
			}
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00027AF4 File Offset: 0x00025CF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 285949, RefRangeEnd = 285951, XrefRangeStart = 285940, XrefRangeEnd = 285949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetView(BaseVerticalCollectionView collectionView)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collectionView);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionViewController.NativeMethodInfoPtr_SetView_Public_Void_BaseVerticalCollectionView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00027B38 File Offset: 0x00025D38
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PrepareView()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionViewController.NativeMethodInfoPtr_PrepareView_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00027B74 File Offset: 0x00025D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285951, XrefRangeEnd = 285954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionViewController.NativeMethodInfoPtr_Dispose_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00027BB0 File Offset: 0x00025DB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285954, XrefRangeEnd = 285957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetItemsCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionViewController.NativeMethodInfoPtr_GetItemsCount_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00027BF8 File Offset: 0x00025DF8
		[CallerCount(41)]
		[CachedScanResults(RefRangeStart = 285957, RefRangeEnd = 285998, XrefRangeStart = 285957, XrefRangeEnd = 285957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetItemsMinCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionViewController.NativeMethodInfoPtr_GetItemsMinCount_Internal_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00027C40 File Offset: 0x00025E40
		[CallerCount(0)]
		public unsafe virtual int GetIndexForId(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionViewController.NativeMethodInfoPtr_GetIndexForId_Public_Virtual_New_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00027C94 File Offset: 0x00025E94
		[CallerCount(0)]
		public unsafe virtual int GetIdForIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionViewController.NativeMethodInfoPtr_GetIdForIndex_Public_Virtual_New_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00027CE8 File Offset: 0x00025EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285998, XrefRangeEnd = 286004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetItemForIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionViewController.NativeMethodInfoPtr_GetItemForIndex_Public_Virtual_New_Object_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00027D40 File Offset: 0x00025F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286004, XrefRangeEnd = 286005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InvokeMakeItem(ReusableCollectionItem reusableItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reusableItem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionViewController.NativeMethodInfoPtr_InvokeMakeItem_Internal_Virtual_New_Void_ReusableCollectionItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00027D90 File Offset: 0x00025F90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 286011, RefRangeEnd = 286013, XrefRangeStart = 286005, XrefRangeEnd = 286011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InvokeBindItem(ReusableCollectionItem reusableItem, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reusableItem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionViewController.NativeMethodInfoPtr_InvokeBindItem_Internal_Virtual_New_Void_ReusableCollectionItem_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00027DEC File Offset: 0x00025FEC
		[CallerCount(0)]
		public unsafe virtual void InvokeUnbindItem(ReusableCollectionItem reusableItem, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reusableItem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionViewController.NativeMethodInfoPtr_InvokeUnbindItem_Internal_Virtual_New_Void_ReusableCollectionItem_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00027E48 File Offset: 0x00026048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286013, XrefRangeEnd = 286014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InvokeDestroyItem(ReusableCollectionItem reusableItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reusableItem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionViewController.NativeMethodInfoPtr_InvokeDestroyItem_Internal_Virtual_New_Void_ReusableCollectionItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00027E98 File Offset: 0x00026098
		[CallerCount(0)]
		public unsafe virtual VisualElement MakeItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionViewController.NativeMethodInfoPtr_MakeItem_Protected_Abstract_Virtual_New_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00027EE4 File Offset: 0x000260E4
		[CallerCount(0)]
		public unsafe virtual void BindItem(VisualElement element, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionViewController.NativeMethodInfoPtr_BindItem_Protected_Abstract_Virtual_New_Void_VisualElement_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00027F40 File Offset: 0x00026140
		[CallerCount(0)]
		public unsafe virtual void UnbindItem(VisualElement element, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionViewController.NativeMethodInfoPtr_UnbindItem_Protected_Abstract_Virtual_New_Void_VisualElement_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00027F9C File Offset: 0x0002619C
		[CallerCount(0)]
		public unsafe virtual void DestroyItem(VisualElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionViewController.NativeMethodInfoPtr_DestroyItem_Protected_Abstract_Virtual_New_Void_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00027FEC File Offset: 0x000261EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 286014, RefRangeEnd = 286016, XrefRangeStart = 286014, XrefRangeEnd = 286014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RaiseItemsSourceChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionViewController.NativeMethodInfoPtr_RaiseItemsSourceChanged_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00028020 File Offset: 0x00026220
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 285866, RefRangeEnd = 285869, XrefRangeStart = 285866, XrefRangeEnd = 285869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RaiseItemIndexChanged(int srcIndex, int dstIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref srcIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionViewController.NativeMethodInfoPtr_RaiseItemIndexChanged_Protected_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x0002806C File Offset: 0x0002626C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CollectionViewController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CollectionViewController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionViewController.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00002D06 File Offset: 0x00000F06
		public CollectionViewController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000302 RID: 770 RVA: 0x000280A8 File Offset: 0x000262A8
		// (set) Token: 0x06000303 RID: 771 RVA: 0x00002D0F File Offset: 0x00000F0F
		public unsafe BaseVerticalCollectionView m_View
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectionViewController.NativeFieldInfoPtr_m_View);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseVerticalCollectionView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectionViewController.NativeFieldInfoPtr_m_View), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000304 RID: 772 RVA: 0x000280D8 File Offset: 0x000262D8
		// (set) Token: 0x06000305 RID: 773 RVA: 0x00002D2E File Offset: 0x00000F2E
		public unsafe IList m_ItemsSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectionViewController.NativeFieldInfoPtr_m_ItemsSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectionViewController.NativeFieldInfoPtr_m_ItemsSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000306 RID: 774 RVA: 0x00028108 File Offset: 0x00026308
		// (set) Token: 0x06000307 RID: 775 RVA: 0x00002D4D File Offset: 0x00000F4D
		public unsafe Action itemsSourceChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectionViewController.NativeFieldInfoPtr_itemsSourceChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectionViewController.NativeFieldInfoPtr_itemsSourceChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000308 RID: 776 RVA: 0x00028138 File Offset: 0x00026338
		// (set) Token: 0x06000309 RID: 777 RVA: 0x00002D6C File Offset: 0x00000F6C
		public unsafe Action<int, int> itemIndexChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectionViewController.NativeFieldInfoPtr_itemIndexChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectionViewController.NativeFieldInfoPtr_itemIndexChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00028168 File Offset: 0x00026368
		public virtual Object GetItemForId(int id)
		{
			bool flag = this.m_ItemsSource == null;
			Object @object;
			if (flag)
			{
				@object = null;
			}
			else
			{
				int indexForId = this.GetIndexForId(id);
				bool flag2 = indexForId < 0 || indexForId >= this.m_ItemsSource.Count;
				if (flag2)
				{
					@object = null;
				}
				else
				{
					@object = this.m_ItemsSource[indexForId];
				}
			}
			return @object;
		}

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeFieldInfoPtr_m_View;

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeFieldInfoPtr_m_ItemsSource;

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeFieldInfoPtr_itemsSourceChanged;

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeFieldInfoPtr_itemIndexChanged;

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeMethodInfoPtr_add_itemsSourceChanged_Public_add_Void_Action_0;

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeMethodInfoPtr_remove_itemsSourceChanged_Public_rem_Void_Action_0;

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeMethodInfoPtr_add_itemIndexChanged_Public_add_Void_Action_2_Int32_Int32_0;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeMethodInfoPtr_remove_itemIndexChanged_Public_rem_Void_Action_2_Int32_Int32_0;

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeMethodInfoPtr_get_itemsSource_Public_Virtual_New_get_IList_0;

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeMethodInfoPtr_set_itemsSource_Public_Virtual_New_set_Void_IList_0;

		// Token: 0x0400024F RID: 591
		private static readonly IntPtr NativeMethodInfoPtr_SetItemsSourceWithoutNotify_Protected_Void_IList_0;

		// Token: 0x04000250 RID: 592
		private static readonly IntPtr NativeMethodInfoPtr_get_view_Protected_get_BaseVerticalCollectionView_0;

		// Token: 0x04000251 RID: 593
		private static readonly IntPtr NativeMethodInfoPtr_SetView_Public_Void_BaseVerticalCollectionView_0;

		// Token: 0x04000252 RID: 594
		private static readonly IntPtr NativeMethodInfoPtr_PrepareView_Protected_Virtual_New_Void_0;

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_New_Void_0;

		// Token: 0x04000254 RID: 596
		private static readonly IntPtr NativeMethodInfoPtr_GetItemsCount_Public_Virtual_New_Int32_0;

		// Token: 0x04000255 RID: 597
		private static readonly IntPtr NativeMethodInfoPtr_GetItemsMinCount_Internal_Virtual_New_Int32_0;

		// Token: 0x04000256 RID: 598
		private static readonly IntPtr NativeMethodInfoPtr_GetIndexForId_Public_Virtual_New_Int32_Int32_0;

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeMethodInfoPtr_GetIdForIndex_Public_Virtual_New_Int32_Int32_0;

		// Token: 0x04000258 RID: 600
		private static readonly IntPtr NativeMethodInfoPtr_GetItemForIndex_Public_Virtual_New_Object_Int32_0;

		// Token: 0x04000259 RID: 601
		private static readonly IntPtr NativeMethodInfoPtr_InvokeMakeItem_Internal_Virtual_New_Void_ReusableCollectionItem_0;

		// Token: 0x0400025A RID: 602
		private static readonly IntPtr NativeMethodInfoPtr_InvokeBindItem_Internal_Virtual_New_Void_ReusableCollectionItem_Int32_0;

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUnbindItem_Internal_Virtual_New_Void_ReusableCollectionItem_Int32_0;

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeMethodInfoPtr_InvokeDestroyItem_Internal_Virtual_New_Void_ReusableCollectionItem_0;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeMethodInfoPtr_MakeItem_Protected_Abstract_Virtual_New_VisualElement_0;

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeMethodInfoPtr_BindItem_Protected_Abstract_Virtual_New_Void_VisualElement_Int32_0;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeMethodInfoPtr_UnbindItem_Protected_Abstract_Virtual_New_Void_VisualElement_Int32_0;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeMethodInfoPtr_DestroyItem_Protected_Abstract_Virtual_New_Void_VisualElement_0;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeMethodInfoPtr_RaiseItemsSourceChanged_Protected_Void_0;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeMethodInfoPtr_RaiseItemIndexChanged_Protected_Void_Int32_Int32_0;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
