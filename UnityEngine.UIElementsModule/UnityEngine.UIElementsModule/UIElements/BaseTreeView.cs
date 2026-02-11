using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000043 RID: 67
	public class BaseTreeView : BaseVerticalCollectionView
	{
		// Token: 0x06000604 RID: 1540 RVA: 0x00033AB8 File Offset: 0x00031CB8
		// Note: this type is marked as 'beforefieldinit'.
		static BaseTreeView()
		{
			Il2CppClassPointerStore<BaseTreeView>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "BaseTreeView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseTreeView>.NativeClassPtr);
			BaseTreeView.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseTreeView>.NativeClassPtr, "ussClassName");
			BaseTreeView.NativeFieldInfoPtr_itemUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseTreeView>.NativeClassPtr, "itemUssClassName");
			BaseTreeView.NativeFieldInfoPtr_itemToggleUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseTreeView>.NativeClassPtr, "itemToggleUssClassName");
			BaseTreeView.NativeFieldInfoPtr_itemIndentsContainerUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseTreeView>.NativeClassPtr, "itemIndentsContainerUssClassName");
			BaseTreeView.NativeFieldInfoPtr_itemIndentUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseTreeView>.NativeClassPtr, "itemIndentUssClassName");
			BaseTreeView.NativeFieldInfoPtr_itemContentContainerUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseTreeView>.NativeClassPtr, "itemContentContainerUssClassName");
			BaseTreeView.NativeFieldInfoPtr_m_AutoExpand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseTreeView>.NativeClassPtr, "m_AutoExpand");
			BaseTreeView.NativeFieldInfoPtr_m_ExpandedItemIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseTreeView>.NativeClassPtr, "m_ExpandedItemIds");
			BaseTreeView.NativeMethodInfoPtr_get_itemsSource_Public_get_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeView>.NativeClassPtr, 100664130);
			BaseTreeView.NativeMethodInfoPtr_get_viewController_Public_get_BaseTreeViewController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeView>.NativeClassPtr, 100664131);
			BaseTreeView.NativeMethodInfoPtr_CreateVirtualizationController_FamAndAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeView>.NativeClassPtr, 100664132);
			BaseTreeView.NativeMethodInfoPtr_SetViewController_Public_Virtual_Void_CollectionViewController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeView>.NativeClassPtr, 100664133);
			BaseTreeView.NativeMethodInfoPtr_OnItemIndexChanged_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeView>.NativeClassPtr, 100664134);
			BaseTreeView.NativeMethodInfoPtr_CreateDragAndDropController_Internal_Virtual_ICollectionDragAndDropController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeView>.NativeClassPtr, 100664135);
			BaseTreeView.NativeMethodInfoPtr_get_autoExpand_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeView>.NativeClassPtr, 100664136);
			BaseTreeView.NativeMethodInfoPtr_set_autoExpand_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeView>.NativeClassPtr, 100664137);
			BaseTreeView.NativeMethodInfoPtr_get_expandedItemIds_Internal_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeView>.NativeClassPtr, 100664138);
			BaseTreeView.NativeMethodInfoPtr_set_expandedItemIds_Internal_set_Void_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeView>.NativeClassPtr, 100664139);
			BaseTreeView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeView>.NativeClassPtr, 100664140);
			BaseTreeView.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeView>.NativeClassPtr, 100664141);
			BaseTreeView.NativeMethodInfoPtr_OnViewDataReady_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeView>.NativeClassPtr, 100664142);
			BaseTreeView.NativeMethodInfoPtr_HandleItemNavigation_FamAndAssem_Virtual_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeView>.NativeClassPtr, 100664143);
			BaseTreeView.NativeMethodInfoPtr_SetSelectionById_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeView>.NativeClassPtr, 100664144);
			BaseTreeView.NativeMethodInfoPtr_SetSelectionById_Public_Void_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeView>.NativeClassPtr, 100664145);
			BaseTreeView.NativeMethodInfoPtr_SetSelectionInternalById_Internal_Void_IEnumerable_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeView>.NativeClassPtr, 100664146);
			BaseTreeView.NativeMethodInfoPtr_GetItemIndex_Private_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeView>.NativeClassPtr, 100664147);
			BaseTreeView.NativeMethodInfoPtr_IsExpanded_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeView>.NativeClassPtr, 100664148);
			BaseTreeView.NativeMethodInfoPtr_CollapseItem_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeView>.NativeClassPtr, 100664149);
			BaseTreeView.NativeMethodInfoPtr_ExpandItem_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeView>.NativeClassPtr, 100664150);
			BaseTreeView.NativeMethodInfoPtr_OnTreeViewPointerUp_Private_Void_PointerUpEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeView>.NativeClassPtr, 100664151);
			BaseTreeView.NativeMethodInfoPtr_IsExpandedByIndex_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeView>.NativeClassPtr, 100664152);
			BaseTreeView.NativeMethodInfoPtr_CollapseItemByIndex_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeView>.NativeClassPtr, 100664153);
			BaseTreeView.NativeMethodInfoPtr_ExpandItemByIndex_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeView>.NativeClassPtr, 100664154);
			BaseTreeView.NativeMethodInfoPtr__SetSelectionInternalById_b__47_0_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeView>.NativeClassPtr, 100664156);
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000605 RID: 1541 RVA: 0x00033D90 File Offset: 0x00031F90
		// (set) Token: 0x06000630 RID: 1584 RVA: 0x00003FCD File Offset: 0x000021CD
		public new unsafe IList itemsSource
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289938, XrefRangeEnd = 289940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeView.NativeMethodInfoPtr_get_itemsSource_Public_get_IList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList>(intPtr3) : null;
			}
			set
			{
				base.GetOrCreateViewController().itemsSource = value;
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000606 RID: 1542 RVA: 0x00033DD0 File Offset: 0x00031FD0
		public new unsafe BaseTreeViewController viewController
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 289941, RefRangeEnd = 289989, XrefRangeStart = 289940, XrefRangeEnd = 289941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeView.NativeMethodInfoPtr_get_viewController_Public_get_BaseTreeViewController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseTreeViewController>(intPtr3) : null;
			}
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00033E10 File Offset: 0x00032010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289989, XrefRangeEnd = 289992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CreateVirtualizationController()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseTreeView.NativeMethodInfoPtr_CreateVirtualizationController_FamAndAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00033E4C File Offset: 0x0003204C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290018, RefRangeEnd = 290019, XrefRangeStart = 289992, XrefRangeEnd = 290018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetViewController(CollectionViewController controller)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseTreeView.NativeMethodInfoPtr_SetViewController_Public_Virtual_Void_CollectionViewController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00033E9C File Offset: 0x0003209C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290019, XrefRangeEnd = 290020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void OnItemIndexChanged(int srcIndex, int dstIndex)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeView.NativeMethodInfoPtr_OnItemIndexChanged_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00033EE8 File Offset: 0x000320E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290020, XrefRangeEnd = 290024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ICollectionDragAndDropController CreateDragAndDropController()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseTreeView.NativeMethodInfoPtr_CreateDragAndDropController_Internal_Virtual_ICollectionDragAndDropController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollectionDragAndDropController>(intPtr3) : null;
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600060B RID: 1547 RVA: 0x00033F34 File Offset: 0x00032134
		// (set) Token: 0x0600060C RID: 1548 RVA: 0x00033F70 File Offset: 0x00032170
		public unsafe bool autoExpand
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeView.NativeMethodInfoPtr_get_autoExpand_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290024, XrefRangeEnd = 290027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeView.NativeMethodInfoPtr_set_autoExpand_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600060D RID: 1549 RVA: 0x00033FB0 File Offset: 0x000321B0
		// (set) Token: 0x0600060E RID: 1550 RVA: 0x00033FF0 File Offset: 0x000321F0
		public unsafe List<int> expandedItemIds
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeView.NativeMethodInfoPtr_get_expandedItemIds_Internal_get_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290027, XrefRangeEnd = 290028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeView.NativeMethodInfoPtr_set_expandedItemIds_Internal_set_Void_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00034034 File Offset: 0x00032234
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290056, RefRangeEnd = 290057, XrefRangeStart = 290028, XrefRangeEnd = 290056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseTreeView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseTreeView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00034070 File Offset: 0x00032270
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 290085, RefRangeEnd = 290087, XrefRangeStart = 290057, XrefRangeEnd = 290085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseTreeView(int itemHeight)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseTreeView>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref itemHeight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeView.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x000340B8 File Offset: 0x000322B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290087, XrefRangeEnd = 290095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnViewDataReady()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseTreeView.NativeMethodInfoPtr_OnViewDataReady_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x000340F4 File Offset: 0x000322F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290095, XrefRangeEnd = 290130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool HandleItemNavigation(bool moveIn, bool altPressed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref moveIn;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref altPressed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseTreeView.NativeMethodInfoPtr_HandleItemNavigation_FamAndAssem_Virtual_Boolean_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00034158 File Offset: 0x00032358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290130, XrefRangeEnd = 290146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelectionById(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeView.NativeMethodInfoPtr_SetSelectionById_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00034198 File Offset: 0x00032398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290146, XrefRangeEnd = 290159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelectionById(IEnumerable<int> ids)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ids);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeView.NativeMethodInfoPtr_SetSelectionById_Public_Void_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x000341DC File Offset: 0x000323DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290159, XrefRangeEnd = 290172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelectionInternalById(IEnumerable<int> ids, bool sendNotification)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ids);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendNotification;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeView.NativeMethodInfoPtr_SetSelectionInternalById_Internal_Void_IEnumerable_1_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x0003422C File Offset: 0x0003242C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290172, XrefRangeEnd = 290183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetItemIndex(int id, bool expand = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expand;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeView.NativeMethodInfoPtr_GetItemIndex_Private_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00034284 File Offset: 0x00032484
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 290186, RefRangeEnd = 290188, XrefRangeStart = 290183, XrefRangeEnd = 290186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsExpanded(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeView.NativeMethodInfoPtr_IsExpanded_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x000342D0 File Offset: 0x000324D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290192, RefRangeEnd = 290193, XrefRangeStart = 290188, XrefRangeEnd = 290192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CollapseItem(int id, bool collapseAllChildren = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref collapseAllChildren;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeView.NativeMethodInfoPtr_CollapseItem_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x0003431C File Offset: 0x0003251C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290195, RefRangeEnd = 290196, XrefRangeStart = 290193, XrefRangeEnd = 290195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExpandItem(int id, bool expandAllChildren = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expandAllChildren;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeView.NativeMethodInfoPtr_ExpandItem_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00034368 File Offset: 0x00032568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290196, XrefRangeEnd = 290197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTreeViewPointerUp(PointerUpEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeView.NativeMethodInfoPtr_OnTreeViewPointerUp_Private_Void_PointerUpEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x000343AC File Offset: 0x000325AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290197, XrefRangeEnd = 290200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsExpandedByIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeView.NativeMethodInfoPtr_IsExpandedByIndex_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x000343F8 File Offset: 0x000325F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290206, RefRangeEnd = 290207, XrefRangeStart = 290200, XrefRangeEnd = 290206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CollapseItemByIndex(int index, bool collapseAll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref collapseAll;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeView.NativeMethodInfoPtr_CollapseItemByIndex_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00034444 File Offset: 0x00032644
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290213, RefRangeEnd = 290214, XrefRangeStart = 290207, XrefRangeEnd = 290213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExpandItemByIndex(int index, bool expandAll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expandAll;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeView.NativeMethodInfoPtr_ExpandItemByIndex_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00034490 File Offset: 0x00032690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290214, XrefRangeEnd = 290267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _SetSelectionInternalById_b__47_0(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeView.NativeMethodInfoPtr__SetSelectionInternalById_b__47_0_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00003F1E File Offset: 0x0000211E
		public BaseTreeView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000620 RID: 1568 RVA: 0x000344DC File Offset: 0x000326DC
		// (set) Token: 0x06000621 RID: 1569 RVA: 0x00003F27 File Offset: 0x00002127
		public new unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseTreeView.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseTreeView.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000622 RID: 1570 RVA: 0x000344FC File Offset: 0x000326FC
		// (set) Token: 0x06000623 RID: 1571 RVA: 0x00003F39 File Offset: 0x00002139
		public new unsafe static string itemUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseTreeView.NativeFieldInfoPtr_itemUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseTreeView.NativeFieldInfoPtr_itemUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000624 RID: 1572 RVA: 0x0003451C File Offset: 0x0003271C
		// (set) Token: 0x06000625 RID: 1573 RVA: 0x00003F4B File Offset: 0x0000214B
		public unsafe static string itemToggleUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseTreeView.NativeFieldInfoPtr_itemToggleUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseTreeView.NativeFieldInfoPtr_itemToggleUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000626 RID: 1574 RVA: 0x0003453C File Offset: 0x0003273C
		// (set) Token: 0x06000627 RID: 1575 RVA: 0x00003F5D File Offset: 0x0000215D
		public unsafe static string itemIndentsContainerUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseTreeView.NativeFieldInfoPtr_itemIndentsContainerUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseTreeView.NativeFieldInfoPtr_itemIndentsContainerUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000628 RID: 1576 RVA: 0x0003455C File Offset: 0x0003275C
		// (set) Token: 0x06000629 RID: 1577 RVA: 0x00003F6F File Offset: 0x0000216F
		public unsafe static string itemIndentUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseTreeView.NativeFieldInfoPtr_itemIndentUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseTreeView.NativeFieldInfoPtr_itemIndentUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x0600062A RID: 1578 RVA: 0x0003457C File Offset: 0x0003277C
		// (set) Token: 0x0600062B RID: 1579 RVA: 0x00003F81 File Offset: 0x00002181
		public unsafe static string itemContentContainerUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseTreeView.NativeFieldInfoPtr_itemContentContainerUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseTreeView.NativeFieldInfoPtr_itemContentContainerUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x0003459C File Offset: 0x0003279C
		// (set) Token: 0x0600062D RID: 1581 RVA: 0x00003F93 File Offset: 0x00002193
		public unsafe bool m_AutoExpand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseTreeView.NativeFieldInfoPtr_m_AutoExpand);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseTreeView.NativeFieldInfoPtr_m_AutoExpand)) = value;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x0600062E RID: 1582 RVA: 0x000345C4 File Offset: 0x000327C4
		// (set) Token: 0x0600062F RID: 1583 RVA: 0x00003FAE File Offset: 0x000021AE
		public unsafe List<int> m_ExpandedItemIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseTreeView.NativeFieldInfoPtr_m_ExpandedItemIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseTreeView.NativeFieldInfoPtr_m_ExpandedItemIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00003FDC File Offset: 0x000021DC
		public void SetRootItems<T>(IList<TreeViewItemData<T>> rootItems)
		{
			this.SetRootItemsInternal<T>(rootItems);
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x000345F4 File Offset: 0x000327F4
		public IEnumerable<int> GetRootIds()
		{
			return this.viewController.GetRootItemIds();
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00034614 File Offset: 0x00032814
		public int GetTreeCount()
		{
			return this.viewController.GetTreeItemsCount();
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x00034634 File Offset: 0x00032834
		public int GetIdForIndex(int index)
		{
			return this.viewController.GetIdForIndex(index);
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x00034654 File Offset: 0x00032854
		public int GetParentIdForIndex(int index)
		{
			return this.viewController.GetParentId(this.GetIdForIndex(index));
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00034678 File Offset: 0x00032878
		public IEnumerable<int> GetChildrenIdsForIndex(int index)
		{
			return this.viewController.GetChildrenIdsByIndex(index);
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x00034698 File Offset: 0x00032898
		public IEnumerable<TreeViewItemData<T>> GetSelectedItems<T>()
		{
			return this.GetSelectedItemsInternal<T>();
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x000346B0 File Offset: 0x000328B0
		public T GetItemDataForIndex<T>(int index)
		{
			return this.GetItemDataForIndexInternal<T>(index);
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x000346CC File Offset: 0x000328CC
		public T GetItemDataForId<T>(int id)
		{
			return this.GetItemDataForIdInternal<T>(id);
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00003FE7 File Offset: 0x000021E7
		public void AddItem<T>(TreeViewItemData<T> item, [Optional] int parentId, [Optional] int childIndex, [Optional] bool rebuildTree)
		{
			this.AddItemInternal<T>(item, parentId, childIndex, rebuildTree);
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x000346E8 File Offset: 0x000328E8
		public bool TryRemoveItem(int id)
		{
			bool flag = this.viewController.TryRemoveItem(id, true);
			bool flag2;
			if (flag)
			{
				base.RefreshItems();
				flag2 = true;
			}
			else
			{
				flag2 = false;
			}
			return flag2;
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00003FF6 File Offset: 0x000021F6
		public void SetSelectionByIdWithoutNotify(IEnumerable<int> ids)
		{
			this.SetSelectionInternalById(ids, false);
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00034718 File Offset: 0x00032918
		public void AddToSelectionById(int id)
		{
			int itemIndex = this.GetItemIndex(id, true);
			base.Rebuild();
			base.AddToSelection(itemIndex);
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00034740 File Offset: 0x00032940
		public void RemoveFromSelectionById(int id)
		{
			int itemIndex = this.GetItemIndex(id, false);
			base.RemoveFromSelection(itemIndex);
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00004002 File Offset: 0x00002202
		public void CopyExpandedStates(int sourceId, int targetId)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00034760 File Offset: 0x00032960
		public void ExpandRootItems()
		{
			foreach (int num in this.viewController.GetRootItemIds())
			{
				this.viewController.ExpandItem(num, false, false);
			}
			base.RefreshItems();
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x0000400F File Offset: 0x0000220F
		public void ExpandAll()
		{
			this.viewController.ExpandAll();
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x0000401E File Offset: 0x0000221E
		public void CollapseAll()
		{
			this.viewController.CollapseAll();
		}

		// Token: 0x0400047A RID: 1146
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x0400047B RID: 1147
		private static readonly IntPtr NativeFieldInfoPtr_itemUssClassName;

		// Token: 0x0400047C RID: 1148
		private static readonly IntPtr NativeFieldInfoPtr_itemToggleUssClassName;

		// Token: 0x0400047D RID: 1149
		private static readonly IntPtr NativeFieldInfoPtr_itemIndentsContainerUssClassName;

		// Token: 0x0400047E RID: 1150
		private static readonly IntPtr NativeFieldInfoPtr_itemIndentUssClassName;

		// Token: 0x0400047F RID: 1151
		private static readonly IntPtr NativeFieldInfoPtr_itemContentContainerUssClassName;

		// Token: 0x04000480 RID: 1152
		private static readonly IntPtr NativeFieldInfoPtr_m_AutoExpand;

		// Token: 0x04000481 RID: 1153
		private static readonly IntPtr NativeFieldInfoPtr_m_ExpandedItemIds;

		// Token: 0x04000482 RID: 1154
		private static readonly IntPtr NativeMethodInfoPtr_get_itemsSource_Public_get_IList_0;

		// Token: 0x04000483 RID: 1155
		private static readonly IntPtr NativeMethodInfoPtr_get_viewController_Public_get_BaseTreeViewController_0;

		// Token: 0x04000484 RID: 1156
		private static readonly IntPtr NativeMethodInfoPtr_CreateVirtualizationController_FamAndAssem_Virtual_Void_0;

		// Token: 0x04000485 RID: 1157
		private static readonly IntPtr NativeMethodInfoPtr_SetViewController_Public_Virtual_Void_CollectionViewController_0;

		// Token: 0x04000486 RID: 1158
		private static readonly IntPtr NativeMethodInfoPtr_OnItemIndexChanged_Private_Void_Int32_Int32_0;

		// Token: 0x04000487 RID: 1159
		private static readonly IntPtr NativeMethodInfoPtr_CreateDragAndDropController_Internal_Virtual_ICollectionDragAndDropController_0;

		// Token: 0x04000488 RID: 1160
		private static readonly IntPtr NativeMethodInfoPtr_get_autoExpand_Public_get_Boolean_0;

		// Token: 0x04000489 RID: 1161
		private static readonly IntPtr NativeMethodInfoPtr_set_autoExpand_Public_set_Void_Boolean_0;

		// Token: 0x0400048A RID: 1162
		private static readonly IntPtr NativeMethodInfoPtr_get_expandedItemIds_Internal_get_List_1_Int32_0;

		// Token: 0x0400048B RID: 1163
		private static readonly IntPtr NativeMethodInfoPtr_set_expandedItemIds_Internal_set_Void_List_1_Int32_0;

		// Token: 0x0400048C RID: 1164
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400048D RID: 1165
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400048E RID: 1166
		private static readonly IntPtr NativeMethodInfoPtr_OnViewDataReady_Internal_Virtual_Void_0;

		// Token: 0x0400048F RID: 1167
		private static readonly IntPtr NativeMethodInfoPtr_HandleItemNavigation_FamAndAssem_Virtual_Boolean_Boolean_Boolean_0;

		// Token: 0x04000490 RID: 1168
		private static readonly IntPtr NativeMethodInfoPtr_SetSelectionById_Public_Void_Int32_0;

		// Token: 0x04000491 RID: 1169
		private static readonly IntPtr NativeMethodInfoPtr_SetSelectionById_Public_Void_IEnumerable_1_Int32_0;

		// Token: 0x04000492 RID: 1170
		private static readonly IntPtr NativeMethodInfoPtr_SetSelectionInternalById_Internal_Void_IEnumerable_1_Int32_Boolean_0;

		// Token: 0x04000493 RID: 1171
		private static readonly IntPtr NativeMethodInfoPtr_GetItemIndex_Private_Int32_Int32_Boolean_0;

		// Token: 0x04000494 RID: 1172
		private static readonly IntPtr NativeMethodInfoPtr_IsExpanded_Public_Boolean_Int32_0;

		// Token: 0x04000495 RID: 1173
		private static readonly IntPtr NativeMethodInfoPtr_CollapseItem_Public_Void_Int32_Boolean_0;

		// Token: 0x04000496 RID: 1174
		private static readonly IntPtr NativeMethodInfoPtr_ExpandItem_Public_Void_Int32_Boolean_0;

		// Token: 0x04000497 RID: 1175
		private static readonly IntPtr NativeMethodInfoPtr_OnTreeViewPointerUp_Private_Void_PointerUpEvent_0;

		// Token: 0x04000498 RID: 1176
		private static readonly IntPtr NativeMethodInfoPtr_IsExpandedByIndex_Private_Boolean_Int32_0;

		// Token: 0x04000499 RID: 1177
		private static readonly IntPtr NativeMethodInfoPtr_CollapseItemByIndex_Private_Void_Int32_Boolean_0;

		// Token: 0x0400049A RID: 1178
		private static readonly IntPtr NativeMethodInfoPtr_ExpandItemByIndex_Private_Void_Int32_Boolean_0;

		// Token: 0x0400049B RID: 1179
		private static readonly IntPtr NativeMethodInfoPtr__SetSelectionInternalById_b__47_0_Private_Int32_Int32_0;

		// Token: 0x02000337 RID: 823
		public new class UxmlTraits : BaseVerticalCollectionView.UxmlTraits
		{
			// Token: 0x060035C0 RID: 13760 RVA: 0x000DEAD8 File Offset: 0x000DCCD8
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<BaseTreeView.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BaseTreeView>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseTreeView.UxmlTraits>.NativeClassPtr);
				BaseTreeView.UxmlTraits.NativeFieldInfoPtr_m_AutoExpand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseTreeView.UxmlTraits>.NativeClassPtr, "m_AutoExpand");
				BaseTreeView.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeView.UxmlTraits>.NativeClassPtr, 100664157);
				BaseTreeView.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeView.UxmlTraits>.NativeClassPtr, 100664158);
			}

			// Token: 0x060035C1 RID: 13761 RVA: 0x000DEB40 File Offset: 0x000DCD40
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 289924, RefRangeEnd = 289925, XrefRangeStart = 289916, XrefRangeEnd = 289924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bag);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cc));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseTreeView.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060035C2 RID: 13762 RVA: 0x000DEBB8 File Offset: 0x000DCDB8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 289936, RefRangeEnd = 289938, XrefRangeStart = 289925, XrefRangeEnd = 289936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseTreeView.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeView.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060035C3 RID: 13763 RVA: 0x00015E4F File Offset: 0x0001404F
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010AC RID: 4268
			// (get) Token: 0x060035C4 RID: 13764 RVA: 0x000DEBF4 File Offset: 0x000DCDF4
			// (set) Token: 0x060035C5 RID: 13765 RVA: 0x00015E58 File Offset: 0x00014058
			public unsafe UxmlBoolAttributeDescription m_AutoExpand
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseTreeView.UxmlTraits.NativeFieldInfoPtr_m_AutoExpand);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlBoolAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseTreeView.UxmlTraits.NativeFieldInfoPtr_m_AutoExpand), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400269C RID: 9884
			private static readonly IntPtr NativeFieldInfoPtr_m_AutoExpand;

			// Token: 0x0400269D RID: 9885
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0;

			// Token: 0x0400269E RID: 9886
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000587 RID: 1415
			public sealed class <get_uxmlChildElementsDescription>d__2
			{
			}
		}
	}
}
