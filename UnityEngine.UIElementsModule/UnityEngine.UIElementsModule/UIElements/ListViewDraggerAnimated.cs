using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x020000B3 RID: 179
	public class ListViewDraggerAnimated : ListViewDragger
	{
		// Token: 0x060010D1 RID: 4305 RVA: 0x00058264 File Offset: 0x00056464
		// Note: this type is marked as 'beforefieldinit'.
		static ListViewDraggerAnimated()
		{
			Il2CppClassPointerStore<ListViewDraggerAnimated>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ListViewDraggerAnimated");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListViewDraggerAnimated>.NativeClassPtr);
			ListViewDraggerAnimated.NativeFieldInfoPtr_m_DragStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListViewDraggerAnimated>.NativeClassPtr, "m_DragStartIndex");
			ListViewDraggerAnimated.NativeFieldInfoPtr_m_CurrentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListViewDraggerAnimated>.NativeClassPtr, "m_CurrentIndex");
			ListViewDraggerAnimated.NativeFieldInfoPtr_m_SelectionHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListViewDraggerAnimated>.NativeClassPtr, "m_SelectionHeight");
			ListViewDraggerAnimated.NativeFieldInfoPtr_m_LocalOffsetOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListViewDraggerAnimated>.NativeClassPtr, "m_LocalOffsetOnStart");
			ListViewDraggerAnimated.NativeFieldInfoPtr_m_CurrentPointerPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListViewDraggerAnimated>.NativeClassPtr, "m_CurrentPointerPosition");
			ListViewDraggerAnimated.NativeFieldInfoPtr_m_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListViewDraggerAnimated>.NativeClassPtr, "m_Item");
			ListViewDraggerAnimated.NativeFieldInfoPtr_m_OffsetItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListViewDraggerAnimated>.NativeClassPtr, "m_OffsetItem");
			ListViewDraggerAnimated.NativeFieldInfoPtr__isDragging_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListViewDraggerAnimated>.NativeClassPtr, "<isDragging>k__BackingField");
			ListViewDraggerAnimated.NativeMethodInfoPtr_get_isDragging_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewDraggerAnimated>.NativeClassPtr, 100665702);
			ListViewDraggerAnimated.NativeMethodInfoPtr_set_isDragging_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewDraggerAnimated>.NativeClassPtr, 100665703);
			ListViewDraggerAnimated.NativeMethodInfoPtr_get_draggedItem_Public_get_ReusableCollectionItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewDraggerAnimated>.NativeClassPtr, 100665704);
			ListViewDraggerAnimated.NativeMethodInfoPtr_get_supportsDragEvents_Protected_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewDraggerAnimated>.NativeClassPtr, 100665705);
			ListViewDraggerAnimated.NativeMethodInfoPtr__ctor_Public_Void_BaseVerticalCollectionView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewDraggerAnimated>.NativeClassPtr, 100665706);
			ListViewDraggerAnimated.NativeMethodInfoPtr_StartDrag_FamOrAssem_Virtual_StartDragArgs_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewDraggerAnimated>.NativeClassPtr, 100665707);
			ListViewDraggerAnimated.NativeMethodInfoPtr_UpdateDrag_FamOrAssem_Virtual_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewDraggerAnimated>.NativeClassPtr, 100665708);
			ListViewDraggerAnimated.NativeMethodInfoPtr_Animate_Private_Void_ReusableCollectionItem_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewDraggerAnimated>.NativeClassPtr, 100665709);
			ListViewDraggerAnimated.NativeMethodInfoPtr_OnDrop_FamOrAssem_Virtual_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewDraggerAnimated>.NativeClassPtr, 100665710);
			ListViewDraggerAnimated.NativeMethodInfoPtr_ClearDragAndDropUI_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewDraggerAnimated>.NativeClassPtr, 100665711);
			ListViewDraggerAnimated.NativeMethodInfoPtr_TryGetDragPosition_Protected_Virtual_Boolean_Vector2_byref_DragPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewDraggerAnimated>.NativeClassPtr, 100665712);
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x060010D2 RID: 4306 RVA: 0x00058410 File Offset: 0x00056610
		// (set) Token: 0x060010D3 RID: 4307 RVA: 0x0005844C File Offset: 0x0005664C
		public unsafe bool isDragging
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListViewDraggerAnimated.NativeMethodInfoPtr_get_isDragging_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListViewDraggerAnimated.NativeMethodInfoPtr_set_isDragging_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x060010D4 RID: 4308 RVA: 0x0005848C File Offset: 0x0005668C
		public unsafe ReusableCollectionItem draggedItem
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListViewDraggerAnimated.NativeMethodInfoPtr_get_draggedItem_Public_get_ReusableCollectionItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReusableCollectionItem>(intPtr3) : null;
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x060010D5 RID: 4309 RVA: 0x000584CC File Offset: 0x000566CC
		public unsafe override bool supportsDragEvents
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ListViewDraggerAnimated.NativeMethodInfoPtr_get_supportsDragEvents_Protected_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x00058514 File Offset: 0x00056714
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 310470, RefRangeEnd = 310472, XrefRangeStart = 310470, XrefRangeEnd = 310472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListViewDraggerAnimated(BaseVerticalCollectionView listView)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListViewDraggerAnimated>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listView);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListViewDraggerAnimated.NativeMethodInfoPtr__ctor_Public_Void_BaseVerticalCollectionView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x00058560 File Offset: 0x00056760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310962, XrefRangeEnd = 311026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override StartDragArgs StartDrag(Vector3 pointerPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerPosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ListViewDraggerAnimated.NativeMethodInfoPtr_StartDrag_FamOrAssem_Virtual_StartDragArgs_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new StartDragArgs(intPtr);
			}
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x000585B0 File Offset: 0x000567B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311026, XrefRangeEnd = 311091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateDrag(Vector3 pointerPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerPosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ListViewDraggerAnimated.NativeMethodInfoPtr_UpdateDrag_FamOrAssem_Virtual_Void_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x000585FC File Offset: 0x000567FC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 311126, RefRangeEnd = 311130, XrefRangeStart = 311091, XrefRangeEnd = 311126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Animate(ReusableCollectionItem element, float paddingTop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paddingTop;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListViewDraggerAnimated.NativeMethodInfoPtr_Animate_Private_Void_ReusableCollectionItem_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x0005864C File Offset: 0x0005684C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311130, XrefRangeEnd = 311167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDrop(Vector3 pointerPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerPosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ListViewDraggerAnimated.NativeMethodInfoPtr_OnDrop_FamOrAssem_Virtual_Void_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x00058698 File Offset: 0x00056898
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearDragAndDropUI(bool dragCancelled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dragCancelled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ListViewDraggerAnimated.NativeMethodInfoPtr_ClearDragAndDropUI_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x000586E4 File Offset: 0x000568E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311167, XrefRangeEnd = 311168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool TryGetDragPosition(Vector2 pointerPosition, ref ListViewDragger.DragPosition dragPosition)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ListViewDraggerAnimated.NativeMethodInfoPtr_TryGetDragPosition_Protected_Virtual_Boolean_Vector2_byref_DragPosition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x000086E7 File Offset: 0x000068E7
		public ListViewDraggerAnimated(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x060010DE RID: 4318 RVA: 0x0005874C File Offset: 0x0005694C
		// (set) Token: 0x060010DF RID: 4319 RVA: 0x000086F0 File Offset: 0x000068F0
		public unsafe int m_DragStartIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListViewDraggerAnimated.NativeFieldInfoPtr_m_DragStartIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListViewDraggerAnimated.NativeFieldInfoPtr_m_DragStartIndex)) = value;
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x060010E0 RID: 4320 RVA: 0x00058774 File Offset: 0x00056974
		// (set) Token: 0x060010E1 RID: 4321 RVA: 0x0000870B File Offset: 0x0000690B
		public unsafe int m_CurrentIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListViewDraggerAnimated.NativeFieldInfoPtr_m_CurrentIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListViewDraggerAnimated.NativeFieldInfoPtr_m_CurrentIndex)) = value;
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x060010E2 RID: 4322 RVA: 0x0005879C File Offset: 0x0005699C
		// (set) Token: 0x060010E3 RID: 4323 RVA: 0x00008726 File Offset: 0x00006926
		public unsafe float m_SelectionHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListViewDraggerAnimated.NativeFieldInfoPtr_m_SelectionHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListViewDraggerAnimated.NativeFieldInfoPtr_m_SelectionHeight)) = value;
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x060010E4 RID: 4324 RVA: 0x000587C4 File Offset: 0x000569C4
		// (set) Token: 0x060010E5 RID: 4325 RVA: 0x00008741 File Offset: 0x00006941
		public unsafe float m_LocalOffsetOnStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListViewDraggerAnimated.NativeFieldInfoPtr_m_LocalOffsetOnStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListViewDraggerAnimated.NativeFieldInfoPtr_m_LocalOffsetOnStart)) = value;
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x060010E6 RID: 4326 RVA: 0x000587EC File Offset: 0x000569EC
		// (set) Token: 0x060010E7 RID: 4327 RVA: 0x0000875C File Offset: 0x0000695C
		public unsafe Vector3 m_CurrentPointerPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListViewDraggerAnimated.NativeFieldInfoPtr_m_CurrentPointerPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListViewDraggerAnimated.NativeFieldInfoPtr_m_CurrentPointerPosition)) = value;
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x060010E8 RID: 4328 RVA: 0x00058814 File Offset: 0x00056A14
		// (set) Token: 0x060010E9 RID: 4329 RVA: 0x00008777 File Offset: 0x00006977
		public unsafe ReusableCollectionItem m_Item
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListViewDraggerAnimated.NativeFieldInfoPtr_m_Item);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReusableCollectionItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListViewDraggerAnimated.NativeFieldInfoPtr_m_Item), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x060010EA RID: 4330 RVA: 0x00058844 File Offset: 0x00056A44
		// (set) Token: 0x060010EB RID: 4331 RVA: 0x00008796 File Offset: 0x00006996
		public unsafe ReusableCollectionItem m_OffsetItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListViewDraggerAnimated.NativeFieldInfoPtr_m_OffsetItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReusableCollectionItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListViewDraggerAnimated.NativeFieldInfoPtr_m_OffsetItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x060010EC RID: 4332 RVA: 0x00058874 File Offset: 0x00056A74
		// (set) Token: 0x060010ED RID: 4333 RVA: 0x000087B5 File Offset: 0x000069B5
		public unsafe bool _isDragging_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListViewDraggerAnimated.NativeFieldInfoPtr__isDragging_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListViewDraggerAnimated.NativeFieldInfoPtr__isDragging_k__BackingField)) = value;
			}
		}

		// Token: 0x04000B9D RID: 2973
		private static readonly IntPtr NativeFieldInfoPtr_m_DragStartIndex;

		// Token: 0x04000B9E RID: 2974
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentIndex;

		// Token: 0x04000B9F RID: 2975
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectionHeight;

		// Token: 0x04000BA0 RID: 2976
		private static readonly IntPtr NativeFieldInfoPtr_m_LocalOffsetOnStart;

		// Token: 0x04000BA1 RID: 2977
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentPointerPosition;

		// Token: 0x04000BA2 RID: 2978
		private static readonly IntPtr NativeFieldInfoPtr_m_Item;

		// Token: 0x04000BA3 RID: 2979
		private static readonly IntPtr NativeFieldInfoPtr_m_OffsetItem;

		// Token: 0x04000BA4 RID: 2980
		private static readonly IntPtr NativeFieldInfoPtr__isDragging_k__BackingField;

		// Token: 0x04000BA5 RID: 2981
		private static readonly IntPtr NativeMethodInfoPtr_get_isDragging_Public_get_Boolean_0;

		// Token: 0x04000BA6 RID: 2982
		private static readonly IntPtr NativeMethodInfoPtr_set_isDragging_Private_set_Void_Boolean_0;

		// Token: 0x04000BA7 RID: 2983
		private static readonly IntPtr NativeMethodInfoPtr_get_draggedItem_Public_get_ReusableCollectionItem_0;

		// Token: 0x04000BA8 RID: 2984
		private static readonly IntPtr NativeMethodInfoPtr_get_supportsDragEvents_Protected_Virtual_get_Boolean_0;

		// Token: 0x04000BA9 RID: 2985
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BaseVerticalCollectionView_0;

		// Token: 0x04000BAA RID: 2986
		private static readonly IntPtr NativeMethodInfoPtr_StartDrag_FamOrAssem_Virtual_StartDragArgs_Vector3_0;

		// Token: 0x04000BAB RID: 2987
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDrag_FamOrAssem_Virtual_Void_Vector3_0;

		// Token: 0x04000BAC RID: 2988
		private static readonly IntPtr NativeMethodInfoPtr_Animate_Private_Void_ReusableCollectionItem_Single_0;

		// Token: 0x04000BAD RID: 2989
		private static readonly IntPtr NativeMethodInfoPtr_OnDrop_FamOrAssem_Virtual_Void_Vector3_0;

		// Token: 0x04000BAE RID: 2990
		private static readonly IntPtr NativeMethodInfoPtr_ClearDragAndDropUI_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04000BAF RID: 2991
		private static readonly IntPtr NativeMethodInfoPtr_TryGetDragPosition_Protected_Virtual_Boolean_Vector2_byref_DragPosition_0;
	}
}
