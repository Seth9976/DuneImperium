using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020000B5 RID: 181
	public class TreeViewReorderableDragAndDropController : BaseReorderableDragAndDropController
	{
		// Token: 0x060010F5 RID: 4341 RVA: 0x00058A40 File Offset: 0x00056C40
		// Note: this type is marked as 'beforefieldinit'.
		static TreeViewReorderableDragAndDropController()
		{
			Il2CppClassPointerStore<TreeViewReorderableDragAndDropController>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TreeViewReorderableDragAndDropController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TreeViewReorderableDragAndDropController>.NativeClassPtr);
			TreeViewReorderableDragAndDropController.NativeFieldInfoPtr_m_DropData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeViewReorderableDragAndDropController>.NativeClassPtr, "m_DropData");
			TreeViewReorderableDragAndDropController.NativeFieldInfoPtr_m_TreeView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeViewReorderableDragAndDropController>.NativeClassPtr, "m_TreeView");
			TreeViewReorderableDragAndDropController.NativeFieldInfoPtr_m_ExpandDropItemScheduledItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeViewReorderableDragAndDropController>.NativeClassPtr, "m_ExpandDropItemScheduledItem");
			TreeViewReorderableDragAndDropController.NativeFieldInfoPtr_m_ExpandDropItemCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeViewReorderableDragAndDropController>.NativeClassPtr, "m_ExpandDropItemCallback");
			TreeViewReorderableDragAndDropController.NativeMethodInfoPtr__ctor_Public_Void_BaseTreeView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeViewReorderableDragAndDropController>.NativeClassPtr, 100665716);
			TreeViewReorderableDragAndDropController.NativeMethodInfoPtr_CompareId_Protected_Virtual_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeViewReorderableDragAndDropController>.NativeClassPtr, 100665717);
			TreeViewReorderableDragAndDropController.NativeMethodInfoPtr_SetupDragAndDrop_Public_Virtual_StartDragArgs_IEnumerable_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeViewReorderableDragAndDropController>.NativeClassPtr, 100665718);
			TreeViewReorderableDragAndDropController.NativeMethodInfoPtr_HandleDragAndDrop_Public_Virtual_DragVisualMode_IListDragAndDropArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeViewReorderableDragAndDropController>.NativeClassPtr, 100665719);
			TreeViewReorderableDragAndDropController.NativeMethodInfoPtr_OnDrop_Public_Virtual_Void_IListDragAndDropArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeViewReorderableDragAndDropController>.NativeClassPtr, 100665720);
			TreeViewReorderableDragAndDropController.NativeMethodInfoPtr_DragCleanup_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeViewReorderableDragAndDropController>.NativeClassPtr, 100665721);
			TreeViewReorderableDragAndDropController.NativeMethodInfoPtr_RestoreExpanded_Private_Void_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeViewReorderableDragAndDropController>.NativeClassPtr, 100665722);
			TreeViewReorderableDragAndDropController.NativeMethodInfoPtr_HandleAutoExpand_Public_Virtual_Void_ReusableCollectionItem_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeViewReorderableDragAndDropController>.NativeClassPtr, 100665723);
			TreeViewReorderableDragAndDropController.NativeMethodInfoPtr_DelayExpandDropItem_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeViewReorderableDragAndDropController>.NativeClassPtr, 100665724);
			TreeViewReorderableDragAndDropController.NativeMethodInfoPtr_ExpandDropItem_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeViewReorderableDragAndDropController>.NativeClassPtr, 100665725);
		}

		// Token: 0x060010F6 RID: 4342 RVA: 0x00058B88 File Offset: 0x00056D88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 311205, RefRangeEnd = 311206, XrefRangeStart = 311191, XrefRangeEnd = 311205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TreeViewReorderableDragAndDropController(BaseTreeView view)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TreeViewReorderableDragAndDropController>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeViewReorderableDragAndDropController.NativeMethodInfoPtr__ctor_Public_Void_BaseTreeView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010F7 RID: 4343 RVA: 0x00058BD4 File Offset: 0x00056DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311206, XrefRangeEnd = 311268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int CompareId(int id1, int id2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TreeViewReorderableDragAndDropController.NativeMethodInfoPtr_CompareId_Protected_Virtual_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x00058C38 File Offset: 0x00056E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311268, XrefRangeEnd = 311273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override StartDragArgs SetupDragAndDrop(IEnumerable<int> itemIds, bool skipText = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemIds);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipText;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TreeViewReorderableDragAndDropController.NativeMethodInfoPtr_SetupDragAndDrop_Public_Virtual_StartDragArgs_IEnumerable_1_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new StartDragArgs(intPtr);
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x00058C9C File Offset: 0x00056E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311273, XrefRangeEnd = 311276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TreeViewReorderableDragAndDropController.NativeMethodInfoPtr_HandleDragAndDrop_Public_Virtual_DragVisualMode_IListDragAndDropArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x00058CF4 File Offset: 0x00056EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311276, XrefRangeEnd = 311335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDrop(IListDragAndDropArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TreeViewReorderableDragAndDropController.NativeMethodInfoPtr_OnDrop_Public_Virtual_Void_IListDragAndDropArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x00058D44 File Offset: 0x00056F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311335, XrefRangeEnd = 311350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DragCleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TreeViewReorderableDragAndDropController.NativeMethodInfoPtr_DragCleanup_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010FC RID: 4348 RVA: 0x00058D80 File Offset: 0x00056F80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 311372, RefRangeEnd = 311373, XrefRangeStart = 311350, XrefRangeEnd = 311372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RestoreExpanded(List<int> ids)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ids);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeViewReorderableDragAndDropController.NativeMethodInfoPtr_RestoreExpanded_Private_Void_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010FD RID: 4349 RVA: 0x00058DC4 File Offset: 0x00056FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311373, XrefRangeEnd = 311380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HandleAutoExpand(ReusableCollectionItem item, Vector2 pointerPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TreeViewReorderableDragAndDropController.NativeMethodInfoPtr_HandleAutoExpand_Public_Virtual_Void_ReusableCollectionItem_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010FE RID: 4350 RVA: 0x00058E20 File Offset: 0x00057020
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 311386, RefRangeEnd = 311387, XrefRangeStart = 311380, XrefRangeEnd = 311386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DelayExpandDropItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeViewReorderableDragAndDropController.NativeMethodInfoPtr_DelayExpandDropItem_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010FF RID: 4351 RVA: 0x00058E54 File Offset: 0x00057054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311387, XrefRangeEnd = 311403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExpandDropItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeViewReorderableDragAndDropController.NativeMethodInfoPtr_ExpandDropItem_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001100 RID: 4352 RVA: 0x000087F8 File Offset: 0x000069F8
		public TreeViewReorderableDragAndDropController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06001101 RID: 4353 RVA: 0x00058E88 File Offset: 0x00057088
		// (set) Token: 0x06001102 RID: 4354 RVA: 0x00008801 File Offset: 0x00006A01
		public unsafe TreeViewReorderableDragAndDropController.DropData m_DropData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeViewReorderableDragAndDropController.NativeFieldInfoPtr_m_DropData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TreeViewReorderableDragAndDropController.DropData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeViewReorderableDragAndDropController.NativeFieldInfoPtr_m_DropData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06001103 RID: 4355 RVA: 0x00058EB8 File Offset: 0x000570B8
		// (set) Token: 0x06001104 RID: 4356 RVA: 0x00008820 File Offset: 0x00006A20
		public unsafe BaseTreeView m_TreeView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeViewReorderableDragAndDropController.NativeFieldInfoPtr_m_TreeView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseTreeView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeViewReorderableDragAndDropController.NativeFieldInfoPtr_m_TreeView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06001105 RID: 4357 RVA: 0x00058EE8 File Offset: 0x000570E8
		// (set) Token: 0x06001106 RID: 4358 RVA: 0x0000883F File Offset: 0x00006A3F
		public unsafe IVisualElementScheduledItem m_ExpandDropItemScheduledItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeViewReorderableDragAndDropController.NativeFieldInfoPtr_m_ExpandDropItemScheduledItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IVisualElementScheduledItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeViewReorderableDragAndDropController.NativeFieldInfoPtr_m_ExpandDropItemScheduledItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06001107 RID: 4359 RVA: 0x00058F18 File Offset: 0x00057118
		// (set) Token: 0x06001108 RID: 4360 RVA: 0x0000885E File Offset: 0x00006A5E
		public unsafe Action m_ExpandDropItemCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeViewReorderableDragAndDropController.NativeFieldInfoPtr_m_ExpandDropItemCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeViewReorderableDragAndDropController.NativeFieldInfoPtr_m_ExpandDropItemCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BB4 RID: 2996
		private static readonly IntPtr NativeFieldInfoPtr_m_DropData;

		// Token: 0x04000BB5 RID: 2997
		private static readonly IntPtr NativeFieldInfoPtr_m_TreeView;

		// Token: 0x04000BB6 RID: 2998
		private static readonly IntPtr NativeFieldInfoPtr_m_ExpandDropItemScheduledItem;

		// Token: 0x04000BB7 RID: 2999
		private static readonly IntPtr NativeFieldInfoPtr_m_ExpandDropItemCallback;

		// Token: 0x04000BB8 RID: 3000
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BaseTreeView_0;

		// Token: 0x04000BB9 RID: 3001
		private static readonly IntPtr NativeMethodInfoPtr_CompareId_Protected_Virtual_Int32_Int32_Int32_0;

		// Token: 0x04000BBA RID: 3002
		private static readonly IntPtr NativeMethodInfoPtr_SetupDragAndDrop_Public_Virtual_StartDragArgs_IEnumerable_1_Int32_Boolean_0;

		// Token: 0x04000BBB RID: 3003
		private static readonly IntPtr NativeMethodInfoPtr_HandleDragAndDrop_Public_Virtual_DragVisualMode_IListDragAndDropArgs_0;

		// Token: 0x04000BBC RID: 3004
		private static readonly IntPtr NativeMethodInfoPtr_OnDrop_Public_Virtual_Void_IListDragAndDropArgs_0;

		// Token: 0x04000BBD RID: 3005
		private static readonly IntPtr NativeMethodInfoPtr_DragCleanup_Public_Virtual_Void_0;

		// Token: 0x04000BBE RID: 3006
		private static readonly IntPtr NativeMethodInfoPtr_RestoreExpanded_Private_Void_List_1_Int32_0;

		// Token: 0x04000BBF RID: 3007
		private static readonly IntPtr NativeMethodInfoPtr_HandleAutoExpand_Public_Virtual_Void_ReusableCollectionItem_Vector2_0;

		// Token: 0x04000BC0 RID: 3008
		private static readonly IntPtr NativeMethodInfoPtr_DelayExpandDropItem_Private_Void_0;

		// Token: 0x04000BC1 RID: 3009
		private static readonly IntPtr NativeMethodInfoPtr_ExpandDropItem_Private_Void_0;

		// Token: 0x04000BC2 RID: 3010
		public const long k_ExpandUpdateIntervalMs = 10L;

		// Token: 0x04000BC3 RID: 3011
		public const float k_DropExpandTimeoutMs = 700f;

		// Token: 0x04000BC4 RID: 3012
		public const float k_DropDeltaPosition = 100f;

		// Token: 0x04000BC5 RID: 3013
		public const float k_HalfDropBetweenHeight = 4f;

		// Token: 0x020003E2 RID: 994
		public class DropData : Object
		{
			// Token: 0x06003A66 RID: 14950 RVA: 0x000EC9CC File Offset: 0x000EABCC
			// Note: this type is marked as 'beforefieldinit'.
			static DropData()
			{
				Il2CppClassPointerStore<TreeViewReorderableDragAndDropController.DropData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TreeViewReorderableDragAndDropController>.NativeClassPtr, "DropData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TreeViewReorderableDragAndDropController.DropData>.NativeClassPtr);
				TreeViewReorderableDragAndDropController.DropData.NativeFieldInfoPtr_expandedIdsBeforeDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeViewReorderableDragAndDropController.DropData>.NativeClassPtr, "expandedIdsBeforeDrag");
				TreeViewReorderableDragAndDropController.DropData.NativeFieldInfoPtr_draggedIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeViewReorderableDragAndDropController.DropData>.NativeClassPtr, "draggedIds");
				TreeViewReorderableDragAndDropController.DropData.NativeFieldInfoPtr_lastItemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeViewReorderableDragAndDropController.DropData>.NativeClassPtr, "lastItemId");
				TreeViewReorderableDragAndDropController.DropData.NativeFieldInfoPtr_expandItemBeginTimerMs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeViewReorderableDragAndDropController.DropData>.NativeClassPtr, "expandItemBeginTimerMs");
				TreeViewReorderableDragAndDropController.DropData.NativeFieldInfoPtr_expandItemBeginPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeViewReorderableDragAndDropController.DropData>.NativeClassPtr, "expandItemBeginPosition");
				TreeViewReorderableDragAndDropController.DropData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeViewReorderableDragAndDropController.DropData>.NativeClassPtr, 100665726);
			}

			// Token: 0x06003A67 RID: 14951 RVA: 0x000ECA70 File Offset: 0x000EAC70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311190, XrefRangeEnd = 311191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DropData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TreeViewReorderableDragAndDropController.DropData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeViewReorderableDragAndDropController.DropData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003A68 RID: 14952 RVA: 0x00018A52 File Offset: 0x00016C52
			public DropData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011E9 RID: 4585
			// (get) Token: 0x06003A69 RID: 14953 RVA: 0x000ECAAC File Offset: 0x000EACAC
			// (set) Token: 0x06003A6A RID: 14954 RVA: 0x00018A5B File Offset: 0x00016C5B
			public unsafe Il2CppStructArray<int> expandedIdsBeforeDrag
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeViewReorderableDragAndDropController.DropData.NativeFieldInfoPtr_expandedIdsBeforeDrag);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeViewReorderableDragAndDropController.DropData.NativeFieldInfoPtr_expandedIdsBeforeDrag), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011EA RID: 4586
			// (get) Token: 0x06003A6B RID: 14955 RVA: 0x000ECADC File Offset: 0x000EACDC
			// (set) Token: 0x06003A6C RID: 14956 RVA: 0x00018A7A File Offset: 0x00016C7A
			public unsafe Il2CppStructArray<int> draggedIds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeViewReorderableDragAndDropController.DropData.NativeFieldInfoPtr_draggedIds);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeViewReorderableDragAndDropController.DropData.NativeFieldInfoPtr_draggedIds), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011EB RID: 4587
			// (get) Token: 0x06003A6D RID: 14957 RVA: 0x000ECB0C File Offset: 0x000EAD0C
			// (set) Token: 0x06003A6E RID: 14958 RVA: 0x00018A99 File Offset: 0x00016C99
			public unsafe int lastItemId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeViewReorderableDragAndDropController.DropData.NativeFieldInfoPtr_lastItemId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeViewReorderableDragAndDropController.DropData.NativeFieldInfoPtr_lastItemId)) = value;
				}
			}

			// Token: 0x170011EC RID: 4588
			// (get) Token: 0x06003A6F RID: 14959 RVA: 0x000ECB34 File Offset: 0x000EAD34
			// (set) Token: 0x06003A70 RID: 14960 RVA: 0x00018AB4 File Offset: 0x00016CB4
			public unsafe float expandItemBeginTimerMs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeViewReorderableDragAndDropController.DropData.NativeFieldInfoPtr_expandItemBeginTimerMs);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeViewReorderableDragAndDropController.DropData.NativeFieldInfoPtr_expandItemBeginTimerMs)) = value;
				}
			}

			// Token: 0x170011ED RID: 4589
			// (get) Token: 0x06003A71 RID: 14961 RVA: 0x000ECB5C File Offset: 0x000EAD5C
			// (set) Token: 0x06003A72 RID: 14962 RVA: 0x00018ACF File Offset: 0x00016CCF
			public unsafe Vector2 expandItemBeginPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeViewReorderableDragAndDropController.DropData.NativeFieldInfoPtr_expandItemBeginPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeViewReorderableDragAndDropController.DropData.NativeFieldInfoPtr_expandItemBeginPosition)) = value;
				}
			}

			// Token: 0x0400294A RID: 10570
			private static readonly IntPtr NativeFieldInfoPtr_expandedIdsBeforeDrag;

			// Token: 0x0400294B RID: 10571
			private static readonly IntPtr NativeFieldInfoPtr_draggedIds;

			// Token: 0x0400294C RID: 10572
			private static readonly IntPtr NativeFieldInfoPtr_lastItemId;

			// Token: 0x0400294D RID: 10573
			private static readonly IntPtr NativeFieldInfoPtr_expandItemBeginTimerMs;

			// Token: 0x0400294E RID: 10574
			private static readonly IntPtr NativeFieldInfoPtr_expandItemBeginPosition;

			// Token: 0x0400294F RID: 10575
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
