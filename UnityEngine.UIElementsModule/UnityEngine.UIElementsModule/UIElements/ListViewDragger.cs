using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000B1 RID: 177
	public class ListViewDragger : DragEventsProcessor
	{
		// Token: 0x060010A5 RID: 4261 RVA: 0x00057650 File Offset: 0x00055850
		// Note: this type is marked as 'beforefieldinit'.
		static ListViewDragger()
		{
			Il2CppClassPointerStore<ListViewDragger>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ListViewDragger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListViewDragger>.NativeClassPtr);
			ListViewDragger.NativeFieldInfoPtr_m_LastDragPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListViewDragger>.NativeClassPtr, "m_LastDragPosition");
			ListViewDragger.NativeFieldInfoPtr_m_DragHoverBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListViewDragger>.NativeClassPtr, "m_DragHoverBar");
			ListViewDragger.NativeFieldInfoPtr_m_DragHoverItemMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListViewDragger>.NativeClassPtr, "m_DragHoverItemMarker");
			ListViewDragger.NativeFieldInfoPtr_m_DragHoverSiblingMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListViewDragger>.NativeClassPtr, "m_DragHoverSiblingMarker");
			ListViewDragger.NativeFieldInfoPtr_m_LeftIndentation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListViewDragger>.NativeClassPtr, "m_LeftIndentation");
			ListViewDragger.NativeFieldInfoPtr_m_SiblingBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListViewDragger>.NativeClassPtr, "m_SiblingBottom");
			ListViewDragger.NativeFieldInfoPtr__dragAndDropController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListViewDragger>.NativeClassPtr, "<dragAndDropController>k__BackingField");
			ListViewDragger.NativeMethodInfoPtr_get_targetView_Protected_get_BaseVerticalCollectionView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewDragger>.NativeClassPtr, 100665673);
			ListViewDragger.NativeMethodInfoPtr_get_targetScrollView_Protected_get_ScrollView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewDragger>.NativeClassPtr, 100665674);
			ListViewDragger.NativeMethodInfoPtr_get_dragAndDropController_Public_get_ICollectionDragAndDropController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewDragger>.NativeClassPtr, 100665675);
			ListViewDragger.NativeMethodInfoPtr_set_dragAndDropController_Public_set_Void_ICollectionDragAndDropController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewDragger>.NativeClassPtr, 100665676);
			ListViewDragger.NativeMethodInfoPtr__ctor_Public_Void_BaseVerticalCollectionView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewDragger>.NativeClassPtr, 100665677);
			ListViewDragger.NativeMethodInfoPtr_CanStartDrag_Protected_Virtual_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewDragger>.NativeClassPtr, 100665678);
			ListViewDragger.NativeMethodInfoPtr_StartDrag_FamOrAssem_Virtual_StartDragArgs_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewDragger>.NativeClassPtr, 100665679);
			ListViewDragger.NativeMethodInfoPtr_UpdateDrag_FamOrAssem_Virtual_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewDragger>.NativeClassPtr, 100665680);
			ListViewDragger.NativeMethodInfoPtr_GetVisualMode_Private_DragVisualMode_Vector3_byref_DragPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewDragger>.NativeClassPtr, 100665681);
			ListViewDragger.NativeMethodInfoPtr_OnDrop_FamOrAssem_Virtual_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewDragger>.NativeClassPtr, 100665682);
			ListViewDragger.NativeMethodInfoPtr_HandleDragAndScroll_Internal_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewDragger>.NativeClassPtr, 100665683);
			ListViewDragger.NativeMethodInfoPtr_HandleAutoExpansion_Private_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewDragger>.NativeClassPtr, 100665684);
			ListViewDragger.NativeMethodInfoPtr_ApplyDragAndDropUI_Private_Void_DragPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewDragger>.NativeClassPtr, 100665685);
			ListViewDragger.NativeMethodInfoPtr_TryGetDragPosition_Protected_Virtual_New_Boolean_Vector2_byref_DragPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewDragger>.NativeClassPtr, 100665686);
			ListViewDragger.NativeMethodInfoPtr_HandleTreePosition_Private_Void_Vector2_byref_DragPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewDragger>.NativeClassPtr, 100665687);
			ListViewDragger.NativeMethodInfoPtr_HandleSiblingInsertionAtAvailableDepthsAndChangeTargetIfNeeded_Private_Void_byref_DragPosition_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewDragger>.NativeClassPtr, 100665688);
			ListViewDragger.NativeMethodInfoPtr_GetPreviousAndNextItemsIgnoringDraggedItems_Private_Void_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewDragger>.NativeClassPtr, 100665689);
			ListViewDragger.NativeMethodInfoPtr_MakeDragAndDropArgs_Protected_DragAndDropArgs_DragPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewDragger>.NativeClassPtr, 100665690);
			ListViewDragger.NativeMethodInfoPtr_GetHoverBarTopPosition_Private_Single_ReusableCollectionItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewDragger>.NativeClassPtr, 100665691);
			ListViewDragger.NativeMethodInfoPtr_PlaceHoverBarAtElement_Private_Void_ReusableCollectionItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewDragger>.NativeClassPtr, 100665692);
			ListViewDragger.NativeMethodInfoPtr_PlaceHoverBarAt_Private_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewDragger>.NativeClassPtr, 100665693);
			ListViewDragger.NativeMethodInfoPtr_ClearDragAndDropUI_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewDragger>.NativeClassPtr, 100665694);
			ListViewDragger.NativeMethodInfoPtr_GetRecycledItem_Protected_ReusableCollectionItem_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewDragger>.NativeClassPtr, 100665695);
			ListViewDragger.NativeMethodInfoPtr_Method_Private_Void_GeometryChangedEvent_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewDragger>.NativeClassPtr, 100665696);
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x060010A6 RID: 4262 RVA: 0x000578EC File Offset: 0x00055AEC
		public unsafe BaseVerticalCollectionView targetView
		{
			[CallerCount(68)]
			[CachedScanResults(RefRangeStart = 310379, RefRangeEnd = 310447, XrefRangeStart = 310378, XrefRangeEnd = 310379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListViewDragger.NativeMethodInfoPtr_get_targetView_Protected_get_BaseVerticalCollectionView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseVerticalCollectionView>(intPtr3) : null;
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x060010A7 RID: 4263 RVA: 0x0005792C File Offset: 0x00055B2C
		public unsafe ScrollView targetScrollView
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310447, XrefRangeEnd = 310448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListViewDragger.NativeMethodInfoPtr_get_targetScrollView_Protected_get_ScrollView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScrollView>(intPtr3) : null;
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x060010A8 RID: 4264 RVA: 0x0005796C File Offset: 0x00055B6C
		// (set) Token: 0x060010A9 RID: 4265 RVA: 0x000579AC File Offset: 0x00055BAC
		public unsafe ICollectionDragAndDropController dragAndDropController
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListViewDragger.NativeMethodInfoPtr_get_dragAndDropController_Public_get_ICollectionDragAndDropController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollectionDragAndDropController>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListViewDragger.NativeMethodInfoPtr_set_dragAndDropController_Public_set_Void_ICollectionDragAndDropController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x000579F0 File Offset: 0x00055BF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 310470, RefRangeEnd = 310472, XrefRangeStart = 310448, XrefRangeEnd = 310470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListViewDragger(BaseVerticalCollectionView listView)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListViewDragger>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listView);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListViewDragger.NativeMethodInfoPtr__ctor_Public_Void_BaseVerticalCollectionView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x00057A3C File Offset: 0x00055C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310472, XrefRangeEnd = 310499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanStartDrag(Vector3 pointerPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerPosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ListViewDragger.NativeMethodInfoPtr_CanStartDrag_Protected_Virtual_Boolean_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x00057A90 File Offset: 0x00055C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310499, XrefRangeEnd = 310536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override StartDragArgs StartDrag(Vector3 pointerPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerPosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ListViewDragger.NativeMethodInfoPtr_StartDrag_FamOrAssem_Virtual_StartDragArgs_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new StartDragArgs(intPtr);
			}
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x00057AE0 File Offset: 0x00055CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310536, XrefRangeEnd = 310563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateDrag(Vector3 pointerPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerPosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ListViewDragger.NativeMethodInfoPtr_UpdateDrag_FamOrAssem_Virtual_Void_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x00057B2C File Offset: 0x00055D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310563, XrefRangeEnd = 310573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DragVisualMode GetVisualMode(Vector3 pointerPosition, ref ListViewDragger.DragPosition dragPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(dragPosition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListViewDragger.NativeMethodInfoPtr_GetVisualMode_Private_DragVisualMode_Vector3_byref_DragPosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x00057B88 File Offset: 0x00055D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310573, XrefRangeEnd = 310585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDrop(Vector3 pointerPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerPosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ListViewDragger.NativeMethodInfoPtr_OnDrop_FamOrAssem_Virtual_Void_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x00057BD4 File Offset: 0x00055DD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 310603, RefRangeEnd = 310605, XrefRangeStart = 310585, XrefRangeEnd = 310603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleDragAndScroll(Vector2 pointerPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerPosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListViewDragger.NativeMethodInfoPtr_HandleDragAndScroll_Internal_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x00057C14 File Offset: 0x00055E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310605, XrefRangeEnd = 310609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleAutoExpansion(Vector2 pointerPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerPosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListViewDragger.NativeMethodInfoPtr_HandleAutoExpansion_Private_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x00057C54 File Offset: 0x00055E54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 310690, RefRangeEnd = 310691, XrefRangeStart = 310609, XrefRangeEnd = 310690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyDragAndDropUI(ListViewDragger.DragPosition dragPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dragPosition));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListViewDragger.NativeMethodInfoPtr_ApplyDragAndDropUI_Private_Void_DragPosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x00057C9C File Offset: 0x00055E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310691, XrefRangeEnd = 310708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryGetDragPosition(Vector2 pointerPosition, ref ListViewDragger.DragPosition dragPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(dragPosition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ListViewDragger.NativeMethodInfoPtr_TryGetDragPosition_Protected_Virtual_New_Boolean_Vector2_byref_DragPosition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010B4 RID: 4276 RVA: 0x00057D04 File Offset: 0x00055F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310708, XrefRangeEnd = 310714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleTreePosition(Vector2 pointerPosition, ref ListViewDragger.DragPosition dragPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(dragPosition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListViewDragger.NativeMethodInfoPtr_HandleTreePosition_Private_Void_Vector2_byref_DragPosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010B5 RID: 4277 RVA: 0x00057D58 File Offset: 0x00055F58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 310764, RefRangeEnd = 310765, XrefRangeStart = 310714, XrefRangeEnd = 310764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleSiblingInsertionAtAvailableDepthsAndChangeTargetIfNeeded(ref ListViewDragger.DragPosition dragPosition, Vector2 pointerPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(dragPosition);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListViewDragger.NativeMethodInfoPtr_HandleSiblingInsertionAtAvailableDepthsAndChangeTargetIfNeeded_Private_Void_byref_DragPosition_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x00057DAC File Offset: 0x00055FAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 310785, RefRangeEnd = 310786, XrefRangeStart = 310765, XrefRangeEnd = 310785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetPreviousAndNextItemsIgnoringDraggedItems(int insertAtIndex, out int previousItemId, out int nextItemId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref insertAtIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &previousItemId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &nextItemId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListViewDragger.NativeMethodInfoPtr_GetPreviousAndNextItemsIgnoringDraggedItems_Private_Void_Int32_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x00057E08 File Offset: 0x00056008
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 310794, RefRangeEnd = 310798, XrefRangeStart = 310786, XrefRangeEnd = 310794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DragAndDropArgs MakeDragAndDropArgs(ListViewDragger.DragPosition dragPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dragPosition));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListViewDragger.NativeMethodInfoPtr_MakeDragAndDropArgs_Protected_DragAndDropArgs_DragPosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new DragAndDropArgs(intPtr);
			}
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x00057E58 File Offset: 0x00056058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310798, XrefRangeEnd = 310802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetHoverBarTopPosition(ReusableCollectionItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListViewDragger.NativeMethodInfoPtr_GetHoverBarTopPosition_Private_Single_ReusableCollectionItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x00057EA8 File Offset: 0x000560A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 310807, RefRangeEnd = 310808, XrefRangeStart = 310802, XrefRangeEnd = 310807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlaceHoverBarAtElement(ReusableCollectionItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListViewDragger.NativeMethodInfoPtr_PlaceHoverBarAtElement_Private_Void_ReusableCollectionItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x00057EEC File Offset: 0x000560EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 310834, RefRangeEnd = 310835, XrefRangeStart = 310808, XrefRangeEnd = 310834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlaceHoverBarAt(float top, float indentationPadding = -1f, float siblingBottom = -1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref top;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indentationPadding;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref siblingBottom;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListViewDragger.NativeMethodInfoPtr_PlaceHoverBarAt_Private_Void_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x00057F48 File Offset: 0x00056148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310835, XrefRangeEnd = 310883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearDragAndDropUI(bool dragCancelled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dragCancelled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ListViewDragger.NativeMethodInfoPtr_ClearDragAndDropUI_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x00057F94 File Offset: 0x00056194
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 310905, RefRangeEnd = 310911, XrefRangeStart = 310883, XrefRangeEnd = 310905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReusableCollectionItem GetRecycledItem(Vector3 pointerPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerPosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListViewDragger.NativeMethodInfoPtr_GetRecycledItem_Protected_ReusableCollectionItem_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReusableCollectionItem>(intPtr3) : null;
			}
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x00057FE0 File Offset: 0x000561E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310911, XrefRangeEnd = 310918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_GeometryChangedEvent_PDM_0(GeometryChangedEvent e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListViewDragger.NativeMethodInfoPtr_Method_Private_Void_GeometryChangedEvent_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x000085F5 File Offset: 0x000067F5
		public ListViewDragger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x060010BF RID: 4287 RVA: 0x00058024 File Offset: 0x00056224
		// (set) Token: 0x060010C0 RID: 4288 RVA: 0x000085FE File Offset: 0x000067FE
		public ListViewDragger.DragPosition m_LastDragPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListViewDragger.NativeFieldInfoPtr_m_LastDragPosition);
				return new ListViewDragger.DragPosition(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ListViewDragger.DragPosition>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListViewDragger.NativeFieldInfoPtr_m_LastDragPosition), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ListViewDragger.DragPosition>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x060010C1 RID: 4289 RVA: 0x00058054 File Offset: 0x00056254
		// (set) Token: 0x060010C2 RID: 4290 RVA: 0x0000862C File Offset: 0x0000682C
		public unsafe VisualElement m_DragHoverBar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListViewDragger.NativeFieldInfoPtr_m_DragHoverBar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListViewDragger.NativeFieldInfoPtr_m_DragHoverBar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x060010C3 RID: 4291 RVA: 0x00058084 File Offset: 0x00056284
		// (set) Token: 0x060010C4 RID: 4292 RVA: 0x0000864B File Offset: 0x0000684B
		public unsafe VisualElement m_DragHoverItemMarker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListViewDragger.NativeFieldInfoPtr_m_DragHoverItemMarker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListViewDragger.NativeFieldInfoPtr_m_DragHoverItemMarker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x060010C5 RID: 4293 RVA: 0x000580B4 File Offset: 0x000562B4
		// (set) Token: 0x060010C6 RID: 4294 RVA: 0x0000866A File Offset: 0x0000686A
		public unsafe VisualElement m_DragHoverSiblingMarker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListViewDragger.NativeFieldInfoPtr_m_DragHoverSiblingMarker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListViewDragger.NativeFieldInfoPtr_m_DragHoverSiblingMarker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x060010C7 RID: 4295 RVA: 0x000580E4 File Offset: 0x000562E4
		// (set) Token: 0x060010C8 RID: 4296 RVA: 0x00008689 File Offset: 0x00006889
		public unsafe float m_LeftIndentation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListViewDragger.NativeFieldInfoPtr_m_LeftIndentation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListViewDragger.NativeFieldInfoPtr_m_LeftIndentation)) = value;
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x060010C9 RID: 4297 RVA: 0x0005810C File Offset: 0x0005630C
		// (set) Token: 0x060010CA RID: 4298 RVA: 0x000086A4 File Offset: 0x000068A4
		public unsafe float m_SiblingBottom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListViewDragger.NativeFieldInfoPtr_m_SiblingBottom);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListViewDragger.NativeFieldInfoPtr_m_SiblingBottom)) = value;
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x060010CB RID: 4299 RVA: 0x00058134 File Offset: 0x00056334
		// (set) Token: 0x060010CC RID: 4300 RVA: 0x000086BF File Offset: 0x000068BF
		public unsafe ICollectionDragAndDropController _dragAndDropController_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListViewDragger.NativeFieldInfoPtr__dragAndDropController_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICollectionDragAndDropController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListViewDragger.NativeFieldInfoPtr__dragAndDropController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B78 RID: 2936
		private static readonly IntPtr NativeFieldInfoPtr_m_LastDragPosition;

		// Token: 0x04000B79 RID: 2937
		private static readonly IntPtr NativeFieldInfoPtr_m_DragHoverBar;

		// Token: 0x04000B7A RID: 2938
		private static readonly IntPtr NativeFieldInfoPtr_m_DragHoverItemMarker;

		// Token: 0x04000B7B RID: 2939
		private static readonly IntPtr NativeFieldInfoPtr_m_DragHoverSiblingMarker;

		// Token: 0x04000B7C RID: 2940
		private static readonly IntPtr NativeFieldInfoPtr_m_LeftIndentation;

		// Token: 0x04000B7D RID: 2941
		private static readonly IntPtr NativeFieldInfoPtr_m_SiblingBottom;

		// Token: 0x04000B7E RID: 2942
		private static readonly IntPtr NativeFieldInfoPtr__dragAndDropController_k__BackingField;

		// Token: 0x04000B7F RID: 2943
		private static readonly IntPtr NativeMethodInfoPtr_get_targetView_Protected_get_BaseVerticalCollectionView_0;

		// Token: 0x04000B80 RID: 2944
		private static readonly IntPtr NativeMethodInfoPtr_get_targetScrollView_Protected_get_ScrollView_0;

		// Token: 0x04000B81 RID: 2945
		private static readonly IntPtr NativeMethodInfoPtr_get_dragAndDropController_Public_get_ICollectionDragAndDropController_0;

		// Token: 0x04000B82 RID: 2946
		private static readonly IntPtr NativeMethodInfoPtr_set_dragAndDropController_Public_set_Void_ICollectionDragAndDropController_0;

		// Token: 0x04000B83 RID: 2947
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BaseVerticalCollectionView_0;

		// Token: 0x04000B84 RID: 2948
		private static readonly IntPtr NativeMethodInfoPtr_CanStartDrag_Protected_Virtual_Boolean_Vector3_0;

		// Token: 0x04000B85 RID: 2949
		private static readonly IntPtr NativeMethodInfoPtr_StartDrag_FamOrAssem_Virtual_StartDragArgs_Vector3_0;

		// Token: 0x04000B86 RID: 2950
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDrag_FamOrAssem_Virtual_Void_Vector3_0;

		// Token: 0x04000B87 RID: 2951
		private static readonly IntPtr NativeMethodInfoPtr_GetVisualMode_Private_DragVisualMode_Vector3_byref_DragPosition_0;

		// Token: 0x04000B88 RID: 2952
		private static readonly IntPtr NativeMethodInfoPtr_OnDrop_FamOrAssem_Virtual_Void_Vector3_0;

		// Token: 0x04000B89 RID: 2953
		private static readonly IntPtr NativeMethodInfoPtr_HandleDragAndScroll_Internal_Void_Vector2_0;

		// Token: 0x04000B8A RID: 2954
		private static readonly IntPtr NativeMethodInfoPtr_HandleAutoExpansion_Private_Void_Vector2_0;

		// Token: 0x04000B8B RID: 2955
		private static readonly IntPtr NativeMethodInfoPtr_ApplyDragAndDropUI_Private_Void_DragPosition_0;

		// Token: 0x04000B8C RID: 2956
		private static readonly IntPtr NativeMethodInfoPtr_TryGetDragPosition_Protected_Virtual_New_Boolean_Vector2_byref_DragPosition_0;

		// Token: 0x04000B8D RID: 2957
		private static readonly IntPtr NativeMethodInfoPtr_HandleTreePosition_Private_Void_Vector2_byref_DragPosition_0;

		// Token: 0x04000B8E RID: 2958
		private static readonly IntPtr NativeMethodInfoPtr_HandleSiblingInsertionAtAvailableDepthsAndChangeTargetIfNeeded_Private_Void_byref_DragPosition_Vector2_0;

		// Token: 0x04000B8F RID: 2959
		private static readonly IntPtr NativeMethodInfoPtr_GetPreviousAndNextItemsIgnoringDraggedItems_Private_Void_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x04000B90 RID: 2960
		private static readonly IntPtr NativeMethodInfoPtr_MakeDragAndDropArgs_Protected_DragAndDropArgs_DragPosition_0;

		// Token: 0x04000B91 RID: 2961
		private static readonly IntPtr NativeMethodInfoPtr_GetHoverBarTopPosition_Private_Single_ReusableCollectionItem_0;

		// Token: 0x04000B92 RID: 2962
		private static readonly IntPtr NativeMethodInfoPtr_PlaceHoverBarAtElement_Private_Void_ReusableCollectionItem_0;

		// Token: 0x04000B93 RID: 2963
		private static readonly IntPtr NativeMethodInfoPtr_PlaceHoverBarAt_Private_Void_Single_Single_Single_0;

		// Token: 0x04000B94 RID: 2964
		private static readonly IntPtr NativeMethodInfoPtr_ClearDragAndDropUI_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04000B95 RID: 2965
		private static readonly IntPtr NativeMethodInfoPtr_GetRecycledItem_Protected_ReusableCollectionItem_Vector3_0;

		// Token: 0x04000B96 RID: 2966
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_GeometryChangedEvent_PDM_0;

		// Token: 0x04000B97 RID: 2967
		public const int k_AutoScrollAreaSize = 5;

		// Token: 0x04000B98 RID: 2968
		public const int k_BetweenElementsAreaSize = 5;

		// Token: 0x04000B99 RID: 2969
		public const int k_PanSpeed = 20;

		// Token: 0x04000B9A RID: 2970
		public const int k_DragHoverBarHeight = 2;

		// Token: 0x020003E1 RID: 993
		public sealed class DragPosition : ValueType
		{
			// Token: 0x06003A56 RID: 14934 RVA: 0x000EC740 File Offset: 0x000EA940
			// Note: this type is marked as 'beforefieldinit'.
			static DragPosition()
			{
				Il2CppClassPointerStore<ListViewDragger.DragPosition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListViewDragger>.NativeClassPtr, "DragPosition");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListViewDragger.DragPosition>.NativeClassPtr);
				ListViewDragger.DragPosition.NativeFieldInfoPtr_insertAtIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListViewDragger.DragPosition>.NativeClassPtr, "insertAtIndex");
				ListViewDragger.DragPosition.NativeFieldInfoPtr_parentId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListViewDragger.DragPosition>.NativeClassPtr, "parentId");
				ListViewDragger.DragPosition.NativeFieldInfoPtr_childIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListViewDragger.DragPosition>.NativeClassPtr, "childIndex");
				ListViewDragger.DragPosition.NativeFieldInfoPtr_recycledItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListViewDragger.DragPosition>.NativeClassPtr, "recycledItem");
				ListViewDragger.DragPosition.NativeFieldInfoPtr_dropPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListViewDragger.DragPosition>.NativeClassPtr, "dropPosition");
				ListViewDragger.DragPosition.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DragPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewDragger.DragPosition>.NativeClassPtr, 100665697);
				ListViewDragger.DragPosition.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewDragger.DragPosition>.NativeClassPtr, 100665698);
				ListViewDragger.DragPosition.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewDragger.DragPosition>.NativeClassPtr, 100665699);
			}

			// Token: 0x06003A57 RID: 14935 RVA: 0x000EC80C File Offset: 0x000EAA0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310372, XrefRangeEnd = 310373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Equals(ListViewDragger.DragPosition other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListViewDragger.DragPosition.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DragPosition_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003A58 RID: 14936 RVA: 0x000EC864 File Offset: 0x000EAA64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310373, XrefRangeEnd = 310377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Equals(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListViewDragger.DragPosition.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003A59 RID: 14937 RVA: 0x000EC8B8 File Offset: 0x000EAAB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310377, XrefRangeEnd = 310378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetHashCode()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListViewDragger.DragPosition.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003A5A RID: 14938 RVA: 0x000189AC File Offset: 0x00016BAC
			public DragPosition(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003A5B RID: 14939 RVA: 0x000189B5 File Offset: 0x00016BB5
			public DragPosition()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListViewDragger.DragPosition>.NativeClassPtr))
			{
			}

			// Token: 0x170011E4 RID: 4580
			// (get) Token: 0x06003A5C RID: 14940 RVA: 0x000EC8FC File Offset: 0x000EAAFC
			// (set) Token: 0x06003A5D RID: 14941 RVA: 0x000189C7 File Offset: 0x00016BC7
			public unsafe int insertAtIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListViewDragger.DragPosition.NativeFieldInfoPtr_insertAtIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListViewDragger.DragPosition.NativeFieldInfoPtr_insertAtIndex)) = value;
				}
			}

			// Token: 0x170011E5 RID: 4581
			// (get) Token: 0x06003A5E RID: 14942 RVA: 0x000EC924 File Offset: 0x000EAB24
			// (set) Token: 0x06003A5F RID: 14943 RVA: 0x000189E2 File Offset: 0x00016BE2
			public unsafe int parentId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListViewDragger.DragPosition.NativeFieldInfoPtr_parentId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListViewDragger.DragPosition.NativeFieldInfoPtr_parentId)) = value;
				}
			}

			// Token: 0x170011E6 RID: 4582
			// (get) Token: 0x06003A60 RID: 14944 RVA: 0x000EC94C File Offset: 0x000EAB4C
			// (set) Token: 0x06003A61 RID: 14945 RVA: 0x000189FD File Offset: 0x00016BFD
			public unsafe int childIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListViewDragger.DragPosition.NativeFieldInfoPtr_childIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListViewDragger.DragPosition.NativeFieldInfoPtr_childIndex)) = value;
				}
			}

			// Token: 0x170011E7 RID: 4583
			// (get) Token: 0x06003A62 RID: 14946 RVA: 0x000EC974 File Offset: 0x000EAB74
			// (set) Token: 0x06003A63 RID: 14947 RVA: 0x00018A18 File Offset: 0x00016C18
			public unsafe ReusableCollectionItem recycledItem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListViewDragger.DragPosition.NativeFieldInfoPtr_recycledItem);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReusableCollectionItem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListViewDragger.DragPosition.NativeFieldInfoPtr_recycledItem), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011E8 RID: 4584
			// (get) Token: 0x06003A64 RID: 14948 RVA: 0x000EC9A4 File Offset: 0x000EABA4
			// (set) Token: 0x06003A65 RID: 14949 RVA: 0x00018A37 File Offset: 0x00016C37
			public unsafe DragAndDropPosition dropPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListViewDragger.DragPosition.NativeFieldInfoPtr_dropPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListViewDragger.DragPosition.NativeFieldInfoPtr_dropPosition)) = value;
				}
			}

			// Token: 0x04002942 RID: 10562
			private static readonly IntPtr NativeFieldInfoPtr_insertAtIndex;

			// Token: 0x04002943 RID: 10563
			private static readonly IntPtr NativeFieldInfoPtr_parentId;

			// Token: 0x04002944 RID: 10564
			private static readonly IntPtr NativeFieldInfoPtr_childIndex;

			// Token: 0x04002945 RID: 10565
			private static readonly IntPtr NativeFieldInfoPtr_recycledItem;

			// Token: 0x04002946 RID: 10566
			private static readonly IntPtr NativeFieldInfoPtr_dropPosition;

			// Token: 0x04002947 RID: 10567
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DragPosition_0;

			// Token: 0x04002948 RID: 10568
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

			// Token: 0x04002949 RID: 10569
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
		}
	}
}
