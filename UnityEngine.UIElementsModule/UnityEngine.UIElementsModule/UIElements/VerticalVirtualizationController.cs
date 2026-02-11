using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Pool;

namespace UnityEngine.UIElements
{
	// Token: 0x02000039 RID: 57
	public class VerticalVirtualizationController<T> : CollectionVirtualizationController where T : ReusableCollectionItem, new()
	{
		// Token: 0x06000464 RID: 1124 RVA: 0x0002DCA8 File Offset: 0x0002BEA8
		// Note: this type is marked as 'beforefieldinit'.
		static VerticalVirtualizationController()
		{
			Il2CppClassPointerStore<VerticalVirtualizationController<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "VerticalVirtualizationController`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VerticalVirtualizationController<T>>.NativeClassPtr);
			VerticalVirtualizationController<T>.NativeFieldInfoPtr_m_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalVirtualizationController<T>>.NativeClassPtr, "m_Pool");
			VerticalVirtualizationController<T>.NativeFieldInfoPtr_m_CollectionView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalVirtualizationController<T>>.NativeClassPtr, "m_CollectionView");
			VerticalVirtualizationController<T>.NativeFieldInfoPtr_m_ActiveItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalVirtualizationController<T>>.NativeClassPtr, "m_ActiveItems");
			VerticalVirtualizationController<T>.NativeFieldInfoPtr_m_DraggedItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalVirtualizationController<T>>.NativeClassPtr, "m_DraggedItem");
			VerticalVirtualizationController<T>.NativeFieldInfoPtr_m_LastFocusedElementIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalVirtualizationController<T>>.NativeClassPtr, "m_LastFocusedElementIndex");
			VerticalVirtualizationController<T>.NativeFieldInfoPtr_m_LastFocusedElementTreeChildIndexes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalVirtualizationController<T>>.NativeClassPtr, "m_LastFocusedElementTreeChildIndexes");
			VerticalVirtualizationController<T>.NativeFieldInfoPtr_m_VisibleItemPredicateDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalVirtualizationController<T>>.NativeClassPtr, "m_VisibleItemPredicateDelegate");
			VerticalVirtualizationController<T>.NativeFieldInfoPtr_m_ScrollInsertionList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalVirtualizationController<T>>.NativeClassPtr, "m_ScrollInsertionList");
			VerticalVirtualizationController<T>.NativeFieldInfoPtr_m_EmptyRows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalVirtualizationController<T>>.NativeClassPtr, "m_EmptyRows");
			VerticalVirtualizationController<T>.NativeMethodInfoPtr_get_activeItems_Public_Virtual_get_IEnumerable_1_ReusableCollectionItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalVirtualizationController<T>>.NativeClassPtr, 100663937);
			VerticalVirtualizationController<T>.NativeMethodInfoPtr_get_itemsCount_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalVirtualizationController<T>>.NativeClassPtr, 100663938);
			VerticalVirtualizationController<T>.NativeMethodInfoPtr_VisibleItemPredicate_Protected_Virtual_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalVirtualizationController<T>>.NativeClassPtr, 100663939);
			VerticalVirtualizationController<T>.NativeMethodInfoPtr_get_firstVisibleItem_Internal_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalVirtualizationController<T>>.NativeClassPtr, 100663940);
			VerticalVirtualizationController<T>.NativeMethodInfoPtr_get_lastVisibleItem_Internal_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalVirtualizationController<T>>.NativeClassPtr, 100663941);
			VerticalVirtualizationController<T>.NativeMethodInfoPtr_get_visibleItemCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalVirtualizationController<T>>.NativeClassPtr, 100663942);
			VerticalVirtualizationController<T>.NativeMethodInfoPtr_get_serializedData_Protected_get_SerializedVirtualizationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalVirtualizationController<T>>.NativeClassPtr, 100663943);
			VerticalVirtualizationController<T>.NativeMethodInfoPtr_get_firstVisibleIndex_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalVirtualizationController<T>>.NativeClassPtr, 100663944);
			VerticalVirtualizationController<T>.NativeMethodInfoPtr_set_firstVisibleIndex_Protected_Virtual_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalVirtualizationController<T>>.NativeClassPtr, 100663945);
			VerticalVirtualizationController<T>.NativeMethodInfoPtr_get_lastHeight_Protected_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalVirtualizationController<T>>.NativeClassPtr, 100663946);
			VerticalVirtualizationController<T>.NativeMethodInfoPtr_get_alwaysRebindOnRefresh_Protected_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalVirtualizationController<T>>.NativeClassPtr, 100663947);
			VerticalVirtualizationController<T>.NativeMethodInfoPtr__ctor_Protected_Void_BaseVerticalCollectionView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalVirtualizationController<T>>.NativeClassPtr, 100663948);
			VerticalVirtualizationController<T>.NativeMethodInfoPtr_Refresh_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalVirtualizationController<T>>.NativeClassPtr, 100663949);
			VerticalVirtualizationController<T>.NativeMethodInfoPtr_Setup_Protected_Void_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalVirtualizationController<T>>.NativeClassPtr, 100663950);
			VerticalVirtualizationController<T>.NativeMethodInfoPtr_OnFocus_Public_Virtual_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalVirtualizationController<T>>.NativeClassPtr, 100663951);
			VerticalVirtualizationController<T>.NativeMethodInfoPtr_OnBlur_Public_Virtual_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalVirtualizationController<T>>.NativeClassPtr, 100663952);
			VerticalVirtualizationController<T>.NativeMethodInfoPtr_HandleFocus_Private_Void_ReusableCollectionItem_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalVirtualizationController<T>>.NativeClassPtr, 100663953);
			VerticalVirtualizationController<T>.NativeMethodInfoPtr_UpdateBackground_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalVirtualizationController<T>>.NativeClassPtr, 100663954);
			VerticalVirtualizationController<T>.NativeMethodInfoPtr_StartDragItem_Internal_Virtual_Void_ReusableCollectionItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalVirtualizationController<T>>.NativeClassPtr, 100663955);
			VerticalVirtualizationController<T>.NativeMethodInfoPtr_EndDrag_Internal_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalVirtualizationController<T>>.NativeClassPtr, 100663956);
			VerticalVirtualizationController<T>.NativeMethodInfoPtr_GetOrMakeItemAtIndex_Internal_Virtual_New_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalVirtualizationController<T>>.NativeClassPtr, 100663957);
			VerticalVirtualizationController<T>.NativeMethodInfoPtr_ReleaseItem_Internal_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalVirtualizationController<T>>.NativeClassPtr, 100663958);
			VerticalVirtualizationController<T>.NativeMethodInfoPtr_OnDestroyItem_Private_Void_ReusableCollectionItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalVirtualizationController<T>>.NativeClassPtr, 100663959);
			VerticalVirtualizationController<T>.NativeMethodInfoPtr_GetDraggedIndex_Protected_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalVirtualizationController<T>>.NativeClassPtr, 100663960);
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x0002DFA8 File Offset: 0x0002C1A8
		public unsafe override IEnumerable<ReusableCollectionItem> activeItems
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VerticalVirtualizationController<T>.NativeMethodInfoPtr_get_activeItems_Public_Virtual_get_IEnumerable_1_ReusableCollectionItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ReusableCollectionItem>>(intPtr3) : null;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x0002DFF4 File Offset: 0x0002C1F4
		public unsafe int itemsCount
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 287734, RefRangeEnd = 287744, XrefRangeStart = 287729, XrefRangeEnd = 287734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerticalVirtualizationController<T>.NativeMethodInfoPtr_get_itemsCount_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x0002E030 File Offset: 0x0002C230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287744, XrefRangeEnd = 287755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool VisibleItemPredicate(T i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = i;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref i;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VerticalVirtualizationController<T>.NativeMethodInfoPtr_VisibleItemPredicate_Protected_Virtual_New_Boolean_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x0002E0C0 File Offset: 0x0002C2C0
		public unsafe T firstVisibleItem
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 287756, RefRangeEnd = 287757, XrefRangeStart = 287755, XrefRangeEnd = 287756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerticalVirtualizationController<T>.NativeMethodInfoPtr_get_firstVisibleItem_Internal_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x0002E0FC File Offset: 0x0002C2FC
		public unsafe T lastVisibleItem
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 287758, RefRangeEnd = 287759, XrefRangeStart = 287757, XrefRangeEnd = 287758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerticalVirtualizationController<T>.NativeMethodInfoPtr_get_lastVisibleItem_Internal_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x0002E138 File Offset: 0x0002C338
		public unsafe override int visibleItemCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287759, XrefRangeEnd = 287760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VerticalVirtualizationController<T>.NativeMethodInfoPtr_get_visibleItemCount_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x0002E180 File Offset: 0x0002C380
		public unsafe SerializedVirtualizationData serializedData
		{
			[CallerCount(64)]
			[CachedScanResults(RefRangeStart = 287760, RefRangeEnd = 287824, XrefRangeStart = 287760, XrefRangeEnd = 287760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerticalVirtualizationController<T>.NativeMethodInfoPtr_get_serializedData_Protected_get_SerializedVirtualizationData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedVirtualizationData>(intPtr3) : null;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x0002E1C0 File Offset: 0x0002C3C0
		// (set) Token: 0x0600046D RID: 1133 RVA: 0x0002E208 File Offset: 0x0002C408
		public unsafe override int firstVisibleIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VerticalVirtualizationController<T>.NativeMethodInfoPtr_get_firstVisibleIndex_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VerticalVirtualizationController<T>.NativeMethodInfoPtr_set_firstVisibleIndex_Protected_Virtual_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x0002E254 File Offset: 0x0002C454
		public unsafe float lastHeight
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287824, RefRangeEnd = 287826, XrefRangeStart = 287824, XrefRangeEnd = 287824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerticalVirtualizationController<T>.NativeMethodInfoPtr_get_lastHeight_Protected_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x0002E290 File Offset: 0x0002C490
		public unsafe virtual bool alwaysRebindOnRefresh
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VerticalVirtualizationController<T>.NativeMethodInfoPtr_get_alwaysRebindOnRefresh_Protected_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x0002E2D8 File Offset: 0x0002C4D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287889, RefRangeEnd = 287891, XrefRangeStart = 287826, XrefRangeEnd = 287889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VerticalVirtualizationController(BaseVerticalCollectionView collectionView)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VerticalVirtualizationController<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collectionView);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerticalVirtualizationController<T>.NativeMethodInfoPtr__ctor_Protected_Void_BaseVerticalCollectionView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x0002E324 File Offset: 0x0002C524
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 287913, RefRangeEnd = 287914, XrefRangeStart = 287891, XrefRangeEnd = 287913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Refresh(bool rebuild)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rebuild;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VerticalVirtualizationController<T>.NativeMethodInfoPtr_Refresh_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x0002E370 File Offset: 0x0002C570
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 287942, RefRangeEnd = 287950, XrefRangeStart = 287914, XrefRangeEnd = 287942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup(T recycledItem, int newIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = recycledItem;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref recycledItem;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newIndex;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(VerticalVirtualizationController<T>.NativeMethodInfoPtr_Setup_Protected_Void_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x0002E3F8 File Offset: 0x0002C5F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287950, XrefRangeEnd = 287958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnFocus(VisualElement leafTarget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(leafTarget);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VerticalVirtualizationController<T>.NativeMethodInfoPtr_OnFocus_Public_Virtual_Void_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x0002E448 File Offset: 0x0002C648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287958, XrefRangeEnd = 287959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBlur(VisualElement willFocus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(willFocus);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VerticalVirtualizationController<T>.NativeMethodInfoPtr_OnBlur_Public_Virtual_Void_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x0002E498 File Offset: 0x0002C698
		[CallerCount(0)]
		public unsafe void HandleFocus(ReusableCollectionItem recycledItem, int previousIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(recycledItem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref previousIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerticalVirtualizationController<T>.NativeMethodInfoPtr_HandleFocus_Private_Void_ReusableCollectionItem_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x0002E4E8 File Offset: 0x0002C6E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287959, XrefRangeEnd = 288009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateBackground()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VerticalVirtualizationController<T>.NativeMethodInfoPtr_UpdateBackground_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x0002E524 File Offset: 0x0002C724
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 288025, RefRangeEnd = 288026, XrefRangeStart = 288009, XrefRangeEnd = 288025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartDragItem(ReusableCollectionItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VerticalVirtualizationController<T>.NativeMethodInfoPtr_StartDragItem_Internal_Virtual_Void_ReusableCollectionItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x0002E574 File Offset: 0x0002C774
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 288051, RefRangeEnd = 288053, XrefRangeStart = 288026, XrefRangeEnd = 288051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EndDrag(int dropIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dropIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VerticalVirtualizationController<T>.NativeMethodInfoPtr_EndDrag_Internal_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0002E5C0 File Offset: 0x0002C7C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 288065, RefRangeEnd = 288067, XrefRangeStart = 288053, XrefRangeEnd = 288065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual T GetOrMakeItemAtIndex(int activeItemIndex = -1, int scrollViewIndex = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref activeItemIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scrollViewIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VerticalVirtualizationController<T>.NativeMethodInfoPtr_GetOrMakeItemAtIndex_Internal_Virtual_New_T_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x0002E620 File Offset: 0x0002C820
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 288071, RefRangeEnd = 288072, XrefRangeStart = 288067, XrefRangeEnd = 288071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ReleaseItem(int activeItemsIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref activeItemsIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VerticalVirtualizationController<T>.NativeMethodInfoPtr_ReleaseItem_Internal_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x0002E66C File Offset: 0x0002C86C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288072, XrefRangeEnd = 288078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroyItem(ReusableCollectionItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerticalVirtualizationController<T>.NativeMethodInfoPtr_OnDestroyItem_Private_Void_ReusableCollectionItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x0002E6B0 File Offset: 0x0002C8B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 288081, RefRangeEnd = 288083, XrefRangeStart = 288078, XrefRangeEnd = 288081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetDraggedIndex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerticalVirtualizationController<T>.NativeMethodInfoPtr_GetDraggedIndex_Protected_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00003454 File Offset: 0x00001654
		public VerticalVirtualizationController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x0002E6EC File Offset: 0x0002C8EC
		// (set) Token: 0x0600047F RID: 1151 RVA: 0x0000345D File Offset: 0x0000165D
		public unsafe ObjectPool<T> m_Pool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalVirtualizationController<T>.NativeFieldInfoPtr_m_Pool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalVirtualizationController<T>.NativeFieldInfoPtr_m_Pool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x0002E71C File Offset: 0x0002C91C
		// (set) Token: 0x06000481 RID: 1153 RVA: 0x0000347C File Offset: 0x0000167C
		public unsafe BaseVerticalCollectionView m_CollectionView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalVirtualizationController<T>.NativeFieldInfoPtr_m_CollectionView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseVerticalCollectionView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalVirtualizationController<T>.NativeFieldInfoPtr_m_CollectionView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x0002E74C File Offset: 0x0002C94C
		// (set) Token: 0x06000483 RID: 1155 RVA: 0x0000349B File Offset: 0x0000169B
		public unsafe List<T> m_ActiveItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalVirtualizationController<T>.NativeFieldInfoPtr_m_ActiveItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalVirtualizationController<T>.NativeFieldInfoPtr_m_ActiveItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x0002E77C File Offset: 0x0002C97C
		// (set) Token: 0x06000485 RID: 1157 RVA: 0x0002E7A4 File Offset: 0x0002C9A4
		public unsafe T m_DraggedItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalVirtualizationController<T>.NativeFieldInfoPtr_m_DraggedItem);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalVirtualizationController<T>.NativeFieldInfoPtr_m_DraggedItem);
				Type typeFromHandle = typeof(T);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x0002E84C File Offset: 0x0002CA4C
		// (set) Token: 0x06000487 RID: 1159 RVA: 0x000034BA File Offset: 0x000016BA
		public unsafe int m_LastFocusedElementIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalVirtualizationController<T>.NativeFieldInfoPtr_m_LastFocusedElementIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalVirtualizationController<T>.NativeFieldInfoPtr_m_LastFocusedElementIndex)) = value;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000488 RID: 1160 RVA: 0x0002E874 File Offset: 0x0002CA74
		// (set) Token: 0x06000489 RID: 1161 RVA: 0x000034D5 File Offset: 0x000016D5
		public unsafe List<int> m_LastFocusedElementTreeChildIndexes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalVirtualizationController<T>.NativeFieldInfoPtr_m_LastFocusedElementTreeChildIndexes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalVirtualizationController<T>.NativeFieldInfoPtr_m_LastFocusedElementTreeChildIndexes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x0600048A RID: 1162 RVA: 0x0002E8A4 File Offset: 0x0002CAA4
		// (set) Token: 0x0600048B RID: 1163 RVA: 0x000034F4 File Offset: 0x000016F4
		public unsafe Func<T, bool> m_VisibleItemPredicateDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalVirtualizationController<T>.NativeFieldInfoPtr_m_VisibleItemPredicateDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalVirtualizationController<T>.NativeFieldInfoPtr_m_VisibleItemPredicateDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x0002E8D4 File Offset: 0x0002CAD4
		// (set) Token: 0x0600048D RID: 1165 RVA: 0x00003513 File Offset: 0x00001713
		public unsafe List<T> m_ScrollInsertionList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalVirtualizationController<T>.NativeFieldInfoPtr_m_ScrollInsertionList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalVirtualizationController<T>.NativeFieldInfoPtr_m_ScrollInsertionList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x0002E904 File Offset: 0x0002CB04
		// (set) Token: 0x0600048F RID: 1167 RVA: 0x00003532 File Offset: 0x00001732
		public unsafe VisualElement m_EmptyRows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalVirtualizationController<T>.NativeFieldInfoPtr_m_EmptyRows);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalVirtualizationController<T>.NativeFieldInfoPtr_m_EmptyRows), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400035B RID: 859
		private static readonly IntPtr NativeFieldInfoPtr_m_Pool;

		// Token: 0x0400035C RID: 860
		private static readonly IntPtr NativeFieldInfoPtr_m_CollectionView;

		// Token: 0x0400035D RID: 861
		private static readonly IntPtr NativeFieldInfoPtr_m_ActiveItems;

		// Token: 0x0400035E RID: 862
		private static readonly IntPtr NativeFieldInfoPtr_m_DraggedItem;

		// Token: 0x0400035F RID: 863
		private static readonly IntPtr NativeFieldInfoPtr_m_LastFocusedElementIndex;

		// Token: 0x04000360 RID: 864
		private static readonly IntPtr NativeFieldInfoPtr_m_LastFocusedElementTreeChildIndexes;

		// Token: 0x04000361 RID: 865
		private static readonly IntPtr NativeFieldInfoPtr_m_VisibleItemPredicateDelegate;

		// Token: 0x04000362 RID: 866
		private static readonly IntPtr NativeFieldInfoPtr_m_ScrollInsertionList;

		// Token: 0x04000363 RID: 867
		private static readonly IntPtr NativeFieldInfoPtr_m_EmptyRows;

		// Token: 0x04000364 RID: 868
		private static readonly IntPtr NativeMethodInfoPtr_get_activeItems_Public_Virtual_get_IEnumerable_1_ReusableCollectionItem_0;

		// Token: 0x04000365 RID: 869
		private static readonly IntPtr NativeMethodInfoPtr_get_itemsCount_Internal_get_Int32_0;

		// Token: 0x04000366 RID: 870
		private static readonly IntPtr NativeMethodInfoPtr_VisibleItemPredicate_Protected_Virtual_New_Boolean_T_0;

		// Token: 0x04000367 RID: 871
		private static readonly IntPtr NativeMethodInfoPtr_get_firstVisibleItem_Internal_get_T_0;

		// Token: 0x04000368 RID: 872
		private static readonly IntPtr NativeMethodInfoPtr_get_lastVisibleItem_Internal_get_T_0;

		// Token: 0x04000369 RID: 873
		private static readonly IntPtr NativeMethodInfoPtr_get_visibleItemCount_Public_Virtual_get_Int32_0;

		// Token: 0x0400036A RID: 874
		private static readonly IntPtr NativeMethodInfoPtr_get_serializedData_Protected_get_SerializedVirtualizationData_0;

		// Token: 0x0400036B RID: 875
		private static readonly IntPtr NativeMethodInfoPtr_get_firstVisibleIndex_Public_Virtual_get_Int32_0;

		// Token: 0x0400036C RID: 876
		private static readonly IntPtr NativeMethodInfoPtr_set_firstVisibleIndex_Protected_Virtual_set_Void_Int32_0;

		// Token: 0x0400036D RID: 877
		private static readonly IntPtr NativeMethodInfoPtr_get_lastHeight_Protected_get_Single_0;

		// Token: 0x0400036E RID: 878
		private static readonly IntPtr NativeMethodInfoPtr_get_alwaysRebindOnRefresh_Protected_Virtual_New_get_Boolean_0;

		// Token: 0x0400036F RID: 879
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_BaseVerticalCollectionView_0;

		// Token: 0x04000370 RID: 880
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Virtual_Void_Boolean_0;

		// Token: 0x04000371 RID: 881
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Protected_Void_T_Int32_0;

		// Token: 0x04000372 RID: 882
		private static readonly IntPtr NativeMethodInfoPtr_OnFocus_Public_Virtual_Void_VisualElement_0;

		// Token: 0x04000373 RID: 883
		private static readonly IntPtr NativeMethodInfoPtr_OnBlur_Public_Virtual_Void_VisualElement_0;

		// Token: 0x04000374 RID: 884
		private static readonly IntPtr NativeMethodInfoPtr_HandleFocus_Private_Void_ReusableCollectionItem_Int32_0;

		// Token: 0x04000375 RID: 885
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBackground_Public_Virtual_Void_0;

		// Token: 0x04000376 RID: 886
		private static readonly IntPtr NativeMethodInfoPtr_StartDragItem_Internal_Virtual_Void_ReusableCollectionItem_0;

		// Token: 0x04000377 RID: 887
		private static readonly IntPtr NativeMethodInfoPtr_EndDrag_Internal_Virtual_Void_Int32_0;

		// Token: 0x04000378 RID: 888
		private static readonly IntPtr NativeMethodInfoPtr_GetOrMakeItemAtIndex_Internal_Virtual_New_T_Int32_Int32_0;

		// Token: 0x04000379 RID: 889
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseItem_Internal_Virtual_New_Void_Int32_0;

		// Token: 0x0400037A RID: 890
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroyItem_Private_Void_ReusableCollectionItem_0;

		// Token: 0x0400037B RID: 891
		private static readonly IntPtr NativeMethodInfoPtr_GetDraggedIndex_Protected_Int32_0;

		// Token: 0x0400037C RID: 892
		public const int k_ExtraVisibleItems = 2;

		// Token: 0x0200032E RID: 814
		[ObfuscatedName("UnityEngine.UIElements.VerticalVirtualizationController`1+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600357D RID: 13693 RVA: 0x000DDC10 File Offset: 0x000DBE10
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<VerticalVirtualizationController<T>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VerticalVirtualizationController<T>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VerticalVirtualizationController<T>.__c>.NativeClassPtr);
				VerticalVirtualizationController<T>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalVirtualizationController<T>.__c>.NativeClassPtr, "<>9");
				VerticalVirtualizationController<T>.__c.NativeFieldInfoPtr___9__30_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalVirtualizationController<T>.__c>.NativeClassPtr, "<>9__30_0");
				VerticalVirtualizationController<T>.__c.NativeFieldInfoPtr___9__30_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalVirtualizationController<T>.__c>.NativeClassPtr, "<>9__30_1");
				VerticalVirtualizationController<T>.__c.NativeFieldInfoPtr___9__30_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalVirtualizationController<T>.__c>.NativeClassPtr, "<>9__30_2");
				VerticalVirtualizationController<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalVirtualizationController<T>.__c>.NativeClassPtr, 100663962);
				VerticalVirtualizationController<T>.__c.NativeMethodInfoPtr___ctor_b__30_0_Internal_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalVirtualizationController<T>.__c>.NativeClassPtr, 100663963);
				VerticalVirtualizationController<T>.__c.NativeMethodInfoPtr___ctor_b__30_1_Internal_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalVirtualizationController<T>.__c>.NativeClassPtr, 100663964);
				VerticalVirtualizationController<T>.__c.NativeMethodInfoPtr___ctor_b__30_2_Internal_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalVirtualizationController<T>.__c>.NativeClassPtr, 100663965);
			}

			// Token: 0x0600357E RID: 13694 RVA: 0x000DDD18 File Offset: 0x000DBF18
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VerticalVirtualizationController<T>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerticalVirtualizationController<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600357F RID: 13695 RVA: 0x000DDD54 File Offset: 0x000DBF54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287715, XrefRangeEnd = 287727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T __ctor_b__30_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerticalVirtualizationController<T>.__c.NativeMethodInfoPtr___ctor_b__30_0_Internal_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}

			// Token: 0x06003580 RID: 13696 RVA: 0x000DDD90 File Offset: 0x000DBF90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287727, XrefRangeEnd = 287728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__30_1(T i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = i;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref i;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(VerticalVirtualizationController<T>.__c.NativeMethodInfoPtr___ctor_b__30_1_Internal_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}

			// Token: 0x06003581 RID: 13697 RVA: 0x000DDE08 File Offset: 0x000DC008
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287728, XrefRangeEnd = 287729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__30_2(T i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = i;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref i;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(VerticalVirtualizationController<T>.__c.NativeMethodInfoPtr___ctor_b__30_2_Internal_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}

			// Token: 0x06003582 RID: 13698 RVA: 0x00015C2E File Offset: 0x00013E2E
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700109A RID: 4250
			// (get) Token: 0x06003583 RID: 13699 RVA: 0x000DDE80 File Offset: 0x000DC080
			// (set) Token: 0x06003584 RID: 13700 RVA: 0x00015C37 File Offset: 0x00013E37
			public unsafe static VerticalVirtualizationController<T>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VerticalVirtualizationController<T>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VerticalVirtualizationController<T>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VerticalVirtualizationController<T>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700109B RID: 4251
			// (get) Token: 0x06003585 RID: 13701 RVA: 0x000DDEA8 File Offset: 0x000DC0A8
			// (set) Token: 0x06003586 RID: 13702 RVA: 0x00015C49 File Offset: 0x00013E49
			public unsafe static Func<T> __9__30_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VerticalVirtualizationController<T>.__c.NativeFieldInfoPtr___9__30_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VerticalVirtualizationController<T>.__c.NativeFieldInfoPtr___9__30_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700109C RID: 4252
			// (get) Token: 0x06003587 RID: 13703 RVA: 0x000DDED0 File Offset: 0x000DC0D0
			// (set) Token: 0x06003588 RID: 13704 RVA: 0x00015C5B File Offset: 0x00013E5B
			public unsafe static Action<T> __9__30_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VerticalVirtualizationController<T>.__c.NativeFieldInfoPtr___9__30_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VerticalVirtualizationController<T>.__c.NativeFieldInfoPtr___9__30_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700109D RID: 4253
			// (get) Token: 0x06003589 RID: 13705 RVA: 0x000DDEF8 File Offset: 0x000DC0F8
			// (set) Token: 0x0600358A RID: 13706 RVA: 0x00015C6D File Offset: 0x00013E6D
			public unsafe static Action<T> __9__30_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VerticalVirtualizationController<T>.__c.NativeFieldInfoPtr___9__30_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VerticalVirtualizationController<T>.__c.NativeFieldInfoPtr___9__30_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002672 RID: 9842
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002673 RID: 9843
			private static readonly IntPtr NativeFieldInfoPtr___9__30_0;

			// Token: 0x04002674 RID: 9844
			private static readonly IntPtr NativeFieldInfoPtr___9__30_1;

			// Token: 0x04002675 RID: 9845
			private static readonly IntPtr NativeFieldInfoPtr___9__30_2;

			// Token: 0x04002676 RID: 9846
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002677 RID: 9847
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__30_0_Internal_T_0;

			// Token: 0x04002678 RID: 9848
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__30_1_Internal_Void_T_0;

			// Token: 0x04002679 RID: 9849
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__30_2_Internal_Void_T_0;
		}
	}
}
