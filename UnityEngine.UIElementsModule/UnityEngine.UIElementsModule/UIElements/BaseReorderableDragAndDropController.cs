using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020000A0 RID: 160
	public class BaseReorderableDragAndDropController : Object
	{
		// Token: 0x06000FDB RID: 4059 RVA: 0x00054AF4 File Offset: 0x00052CF4
		// Note: this type is marked as 'beforefieldinit'.
		static BaseReorderableDragAndDropController()
		{
			Il2CppClassPointerStore<BaseReorderableDragAndDropController>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "BaseReorderableDragAndDropController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseReorderableDragAndDropController>.NativeClassPtr);
			BaseReorderableDragAndDropController.NativeFieldInfoPtr_m_View = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseReorderableDragAndDropController>.NativeClassPtr, "m_View");
			BaseReorderableDragAndDropController.NativeFieldInfoPtr_m_SortedSelectedIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseReorderableDragAndDropController>.NativeClassPtr, "m_SortedSelectedIds");
			BaseReorderableDragAndDropController.NativeFieldInfoPtr__enableReordering_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseReorderableDragAndDropController>.NativeClassPtr, "<enableReordering>k__BackingField");
			BaseReorderableDragAndDropController.NativeMethodInfoPtr_GetSortedSelectedIds_Public_Virtual_Final_New_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseReorderableDragAndDropController>.NativeClassPtr, 100665586);
			BaseReorderableDragAndDropController.NativeMethodInfoPtr__ctor_Protected_Void_BaseVerticalCollectionView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseReorderableDragAndDropController>.NativeClassPtr, 100665587);
			BaseReorderableDragAndDropController.NativeMethodInfoPtr_get_enableReordering_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseReorderableDragAndDropController>.NativeClassPtr, 100665588);
			BaseReorderableDragAndDropController.NativeMethodInfoPtr_set_enableReordering_Public_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseReorderableDragAndDropController>.NativeClassPtr, 100665589);
			BaseReorderableDragAndDropController.NativeMethodInfoPtr_CanStartDrag_Public_Virtual_New_Boolean_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseReorderableDragAndDropController>.NativeClassPtr, 100665590);
			BaseReorderableDragAndDropController.NativeMethodInfoPtr_SetupDragAndDrop_Public_Virtual_New_StartDragArgs_IEnumerable_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseReorderableDragAndDropController>.NativeClassPtr, 100665591);
			BaseReorderableDragAndDropController.NativeMethodInfoPtr_CompareId_Protected_Virtual_New_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseReorderableDragAndDropController>.NativeClassPtr, 100665592);
			BaseReorderableDragAndDropController.NativeMethodInfoPtr_HandleDragAndDrop_Public_Abstract_Virtual_New_DragVisualMode_IListDragAndDropArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseReorderableDragAndDropController>.NativeClassPtr, 100665593);
			BaseReorderableDragAndDropController.NativeMethodInfoPtr_OnDrop_Public_Abstract_Virtual_New_Void_IListDragAndDropArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseReorderableDragAndDropController>.NativeClassPtr, 100665594);
			BaseReorderableDragAndDropController.NativeMethodInfoPtr_DragCleanup_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseReorderableDragAndDropController>.NativeClassPtr, 100665595);
			BaseReorderableDragAndDropController.NativeMethodInfoPtr_HandleAutoExpand_Public_Virtual_New_Void_ReusableCollectionItem_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseReorderableDragAndDropController>.NativeClassPtr, 100665596);
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x00054C3C File Offset: 0x00052E3C
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<int> GetSortedSelectedIds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseReorderableDragAndDropController.NativeMethodInfoPtr_GetSortedSelectedIds_Public_Virtual_Final_New_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
		}

		// Token: 0x06000FDD RID: 4061 RVA: 0x00054C7C File Offset: 0x00052E7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 308623, RefRangeEnd = 308625, XrefRangeStart = 308614, XrefRangeEnd = 308623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseReorderableDragAndDropController(BaseVerticalCollectionView view)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseReorderableDragAndDropController>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseReorderableDragAndDropController.NativeMethodInfoPtr__ctor_Protected_Void_BaseVerticalCollectionView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06000FDE RID: 4062 RVA: 0x00054CC8 File Offset: 0x00052EC8
		// (set) Token: 0x06000FDF RID: 4063 RVA: 0x00054D10 File Offset: 0x00052F10
		public unsafe virtual bool enableReordering
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseReorderableDragAndDropController.NativeMethodInfoPtr_get_enableReordering_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseReorderableDragAndDropController.NativeMethodInfoPtr_set_enableReordering_Public_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000FE0 RID: 4064 RVA: 0x00054D5C File Offset: 0x00052F5C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 308626, RefRangeEnd = 308638, XrefRangeStart = 308626, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanStartDrag(IEnumerable<int> itemIds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemIds);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseReorderableDragAndDropController.NativeMethodInfoPtr_CanStartDrag_Public_Virtual_New_Boolean_IEnumerable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x00054DB4 File Offset: 0x00052FB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308690, RefRangeEnd = 308691, XrefRangeStart = 308638, XrefRangeEnd = 308690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual StartDragArgs SetupDragAndDrop(IEnumerable<int> itemIds, bool skipText = false)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseReorderableDragAndDropController.NativeMethodInfoPtr_SetupDragAndDrop_Public_Virtual_New_StartDragArgs_IEnumerable_1_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new StartDragArgs(intPtr);
		}

		// Token: 0x06000FE2 RID: 4066 RVA: 0x00054E18 File Offset: 0x00053018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308691, XrefRangeEnd = 308692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int CompareId(int id1, int id2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseReorderableDragAndDropController.NativeMethodInfoPtr_CompareId_Protected_Virtual_New_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FE3 RID: 4067 RVA: 0x00054E7C File Offset: 0x0005307C
		[CallerCount(0)]
		public unsafe virtual DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseReorderableDragAndDropController.NativeMethodInfoPtr_HandleDragAndDrop_Public_Abstract_Virtual_New_DragVisualMode_IListDragAndDropArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x00054ED4 File Offset: 0x000530D4
		[CallerCount(0)]
		public unsafe virtual void OnDrop(IListDragAndDropArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseReorderableDragAndDropController.NativeMethodInfoPtr_OnDrop_Public_Abstract_Virtual_New_Void_IListDragAndDropArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x00054F24 File Offset: 0x00053124
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DragCleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseReorderableDragAndDropController.NativeMethodInfoPtr_DragCleanup_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x00054F60 File Offset: 0x00053160
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HandleAutoExpand(ReusableCollectionItem item, Vector2 pointerPosition)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseReorderableDragAndDropController.NativeMethodInfoPtr_HandleAutoExpand_Public_Virtual_New_Void_ReusableCollectionItem_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x0000809C File Offset: 0x0000629C
		public BaseReorderableDragAndDropController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06000FE8 RID: 4072 RVA: 0x00054FBC File Offset: 0x000531BC
		// (set) Token: 0x06000FE9 RID: 4073 RVA: 0x000080A5 File Offset: 0x000062A5
		public unsafe BaseVerticalCollectionView m_View
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseReorderableDragAndDropController.NativeFieldInfoPtr_m_View);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseVerticalCollectionView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseReorderableDragAndDropController.NativeFieldInfoPtr_m_View), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06000FEA RID: 4074 RVA: 0x00054FEC File Offset: 0x000531EC
		// (set) Token: 0x06000FEB RID: 4075 RVA: 0x000080C4 File Offset: 0x000062C4
		public unsafe List<int> m_SortedSelectedIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseReorderableDragAndDropController.NativeFieldInfoPtr_m_SortedSelectedIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseReorderableDragAndDropController.NativeFieldInfoPtr_m_SortedSelectedIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06000FEC RID: 4076 RVA: 0x0005501C File Offset: 0x0005321C
		// (set) Token: 0x06000FED RID: 4077 RVA: 0x000080E3 File Offset: 0x000062E3
		public unsafe bool _enableReordering_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseReorderableDragAndDropController.NativeFieldInfoPtr__enableReordering_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseReorderableDragAndDropController.NativeFieldInfoPtr__enableReordering_k__BackingField)) = value;
			}
		}

		// Token: 0x04000AF7 RID: 2807
		private static readonly IntPtr NativeFieldInfoPtr_m_View;

		// Token: 0x04000AF8 RID: 2808
		private static readonly IntPtr NativeFieldInfoPtr_m_SortedSelectedIds;

		// Token: 0x04000AF9 RID: 2809
		private static readonly IntPtr NativeFieldInfoPtr__enableReordering_k__BackingField;

		// Token: 0x04000AFA RID: 2810
		private static readonly IntPtr NativeMethodInfoPtr_GetSortedSelectedIds_Public_Virtual_Final_New_IEnumerable_1_Int32_0;

		// Token: 0x04000AFB RID: 2811
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_BaseVerticalCollectionView_0;

		// Token: 0x04000AFC RID: 2812
		private static readonly IntPtr NativeMethodInfoPtr_get_enableReordering_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000AFD RID: 2813
		private static readonly IntPtr NativeMethodInfoPtr_set_enableReordering_Public_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04000AFE RID: 2814
		private static readonly IntPtr NativeMethodInfoPtr_CanStartDrag_Public_Virtual_New_Boolean_IEnumerable_1_Int32_0;

		// Token: 0x04000AFF RID: 2815
		private static readonly IntPtr NativeMethodInfoPtr_SetupDragAndDrop_Public_Virtual_New_StartDragArgs_IEnumerable_1_Int32_Boolean_0;

		// Token: 0x04000B00 RID: 2816
		private static readonly IntPtr NativeMethodInfoPtr_CompareId_Protected_Virtual_New_Int32_Int32_Int32_0;

		// Token: 0x04000B01 RID: 2817
		private static readonly IntPtr NativeMethodInfoPtr_HandleDragAndDrop_Public_Abstract_Virtual_New_DragVisualMode_IListDragAndDropArgs_0;

		// Token: 0x04000B02 RID: 2818
		private static readonly IntPtr NativeMethodInfoPtr_OnDrop_Public_Abstract_Virtual_New_Void_IListDragAndDropArgs_0;

		// Token: 0x04000B03 RID: 2819
		private static readonly IntPtr NativeMethodInfoPtr_DragCleanup_Public_Virtual_New_Void_0;

		// Token: 0x04000B04 RID: 2820
		private static readonly IntPtr NativeMethodInfoPtr_HandleAutoExpand_Public_Virtual_New_Void_ReusableCollectionItem_Vector2_0;
	}
}
