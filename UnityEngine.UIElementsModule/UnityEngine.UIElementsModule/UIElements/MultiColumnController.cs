using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.UIElements.Internal;

namespace UnityEngine.UIElements
{
	// Token: 0x02000077 RID: 119
	public class MultiColumnController : Object
	{
		// Token: 0x06000BCF RID: 3023 RVA: 0x00046D94 File Offset: 0x00044F94
		// Note: this type is marked as 'beforefieldinit'.
		static MultiColumnController()
		{
			Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "MultiColumnController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr);
			MultiColumnController.NativeFieldInfoPtr_k_BoundColumnVePropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr, "k_BoundColumnVePropertyName");
			MultiColumnController.NativeFieldInfoPtr_bindableElementPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr, "bindableElementPropertyName");
			MultiColumnController.NativeFieldInfoPtr_baseUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr, "baseUssClassName");
			MultiColumnController.NativeFieldInfoPtr_k_HeaderContainerViewDataKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr, "k_HeaderContainerViewDataKey");
			MultiColumnController.NativeFieldInfoPtr_headerContainerUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr, "headerContainerUssClassName");
			MultiColumnController.NativeFieldInfoPtr_rowContainerUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr, "rowContainerUssClassName");
			MultiColumnController.NativeFieldInfoPtr_cellUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr, "cellUssClassName");
			MultiColumnController.NativeFieldInfoPtr_cellLabelUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr, "cellLabelUssClassName");
			MultiColumnController.NativeFieldInfoPtr_k_HeaderViewDataKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr, "k_HeaderViewDataKey");
			MultiColumnController.NativeFieldInfoPtr_columnSortingChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr, "columnSortingChanged");
			MultiColumnController.NativeFieldInfoPtr_headerContextMenuPopulateEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr, "headerContextMenuPopulateEvent");
			MultiColumnController.NativeFieldInfoPtr_m_View = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr, "m_View");
			MultiColumnController.NativeFieldInfoPtr_m_HeaderContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr, "m_HeaderContainer");
			MultiColumnController.NativeFieldInfoPtr_m_MultiColumnHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr, "m_MultiColumnHeader");
			MultiColumnController.NativeMethodInfoPtr_add_columnSortingChanged_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr, 100665009);
			MultiColumnController.NativeMethodInfoPtr_remove_columnSortingChanged_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr, 100665010);
			MultiColumnController.NativeMethodInfoPtr_add_headerContextMenuPopulateEvent_Public_add_Void_Action_2_ContextualMenuPopulateEvent_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr, 100665011);
			MultiColumnController.NativeMethodInfoPtr_remove_headerContextMenuPopulateEvent_Public_rem_Void_Action_2_ContextualMenuPopulateEvent_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr, 100665012);
			MultiColumnController.NativeMethodInfoPtr_get_header_Internal_get_MultiColumnCollectionHeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr, 100665013);
			MultiColumnController.NativeMethodInfoPtr__ctor_Public_Void_Columns_SortColumnDescriptions_List_1_SortColumnDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr, 100665014);
			MultiColumnController.NativeMethodInfoPtr_BindCellItem_Private_Static_Void_VisualElement_Int32_Column_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr, 100665015);
			MultiColumnController.NativeMethodInfoPtr_UnbindCellItem_Private_Static_Void_VisualElement_Int32_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr, 100665016);
			MultiColumnController.NativeMethodInfoPtr_DefaultMakeCellItem_Private_Static_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr, 100665017);
			MultiColumnController.NativeMethodInfoPtr_DefaultBindCellItem_Private_Static_Void_VisualElement_Column_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr, 100665018);
			MultiColumnController.NativeMethodInfoPtr_MakeItem_Public_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr, 100665019);
			MultiColumnController.NativeMethodInfoPtr_BindItem_Public_Void_VisualElement_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr, 100665020);
			MultiColumnController.NativeMethodInfoPtr_UnbindItem_Public_Void_VisualElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr, 100665021);
			MultiColumnController.NativeMethodInfoPtr_DestroyItem_Public_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr, 100665022);
			MultiColumnController.NativeMethodInfoPtr_PrepareView_Public_Void_BaseVerticalCollectionView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr, 100665023);
			MultiColumnController.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr, 100665024);
			MultiColumnController.NativeMethodInfoPtr_OnHorizontalScrollerValueChanged_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr, 100665025);
			MultiColumnController.NativeMethodInfoPtr_OnViewportGeometryChanged_Private_Void_GeometryChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr, 100665026);
			MultiColumnController.NativeMethodInfoPtr_OnColumnContainerGeometryChanged_Private_Void_GeometryChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr, 100665027);
			MultiColumnController.NativeMethodInfoPtr_UpdateContentContainer_Private_Void_BaseVerticalCollectionView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr, 100665028);
			MultiColumnController.NativeMethodInfoPtr_OnColumnSortingChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr, 100665029);
			MultiColumnController.NativeMethodInfoPtr_OnContextMenuPopulateEvent_Private_Void_ContextualMenuPopulateEvent_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr, 100665030);
			MultiColumnController.NativeMethodInfoPtr_OnColumnResized_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr, 100665031);
			MultiColumnController.NativeMethodInfoPtr_OnColumnAdded_Private_Void_Column_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr, 100665032);
			MultiColumnController.NativeMethodInfoPtr_OnColumnRemoved_Private_Void_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr, 100665033);
			MultiColumnController.NativeMethodInfoPtr_OnColumnReordered_Private_Void_Column_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr, 100665034);
			MultiColumnController.NativeMethodInfoPtr_OnColumnsChanged_Private_Void_Column_ColumnDataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr, 100665035);
			MultiColumnController.NativeMethodInfoPtr_OnColumnChanged_Private_Void_ColumnsDataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr, 100665036);
			MultiColumnController.NativeMethodInfoPtr_OnViewDataRestored_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr, 100665037);
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x00047120 File Offset: 0x00045320
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 301637, RefRangeEnd = 301639, XrefRangeStart = 301633, XrefRangeEnd = 301637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_columnSortingChanged(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnController.NativeMethodInfoPtr_add_columnSortingChanged_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x00047164 File Offset: 0x00045364
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 301643, RefRangeEnd = 301645, XrefRangeStart = 301639, XrefRangeEnd = 301643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_columnSortingChanged(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnController.NativeMethodInfoPtr_remove_columnSortingChanged_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x000471A8 File Offset: 0x000453A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 301650, RefRangeEnd = 301652, XrefRangeStart = 301645, XrefRangeEnd = 301650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_headerContextMenuPopulateEvent(Action<ContextualMenuPopulateEvent, Column> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnController.NativeMethodInfoPtr_add_headerContextMenuPopulateEvent_Public_add_Void_Action_2_ContextualMenuPopulateEvent_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x000471EC File Offset: 0x000453EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 301657, RefRangeEnd = 301659, XrefRangeStart = 301652, XrefRangeEnd = 301657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_headerContextMenuPopulateEvent(Action<ContextualMenuPopulateEvent, Column> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnController.NativeMethodInfoPtr_remove_headerContextMenuPopulateEvent_Public_rem_Void_Action_2_ContextualMenuPopulateEvent_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000BD4 RID: 3028 RVA: 0x00047230 File Offset: 0x00045430
		public unsafe UnityEngine.UIElements.Internal.MultiColumnCollectionHeader header
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnController.NativeMethodInfoPtr_get_header_Internal_get_MultiColumnCollectionHeader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEngine.UIElements.Internal.MultiColumnCollectionHeader>(intPtr3) : null;
			}
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x00047270 File Offset: 0x00045470
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 301740, RefRangeEnd = 301742, XrefRangeStart = 301659, XrefRangeEnd = 301740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MultiColumnController(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(columns);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sortDescriptions);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sortedColumns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnController.NativeMethodInfoPtr__ctor_Public_Void_Columns_SortColumnDescriptions_List_1_SortColumnDescription_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x000472E0 File Offset: 0x000454E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301742, XrefRangeEnd = 301749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BindCellItem<T>(VisualElement ve, int rowIndex, Column column, T item)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rowIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(column);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = item;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref item;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MultiColumnController.MethodInfoStoreGeneric_BindCellItem_Private_Static_Void_VisualElement_Int32_Column_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x00047380 File Offset: 0x00045580
		[CallerCount(0)]
		public unsafe static void UnbindCellItem(VisualElement ve, int rowIndex, Column column)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rowIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(column);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnController.NativeMethodInfoPtr_UnbindCellItem_Private_Static_Void_VisualElement_Int32_Column_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x000473D8 File Offset: 0x000455D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 301758, RefRangeEnd = 301759, XrefRangeStart = 301749, XrefRangeEnd = 301758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VisualElement DefaultMakeCellItem()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnController.NativeMethodInfoPtr_DefaultMakeCellItem_Private_Static_VisualElement_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x0004740C File Offset: 0x0004560C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301759, XrefRangeEnd = 301762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DefaultBindCellItem<T>(VisualElement ve, Column column, T item)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(column);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = item;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref item;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MultiColumnController.MethodInfoStoreGeneric_DefaultBindCellItem_Private_Static_Void_VisualElement_Column_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x0004749C File Offset: 0x0004569C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 301807, RefRangeEnd = 301809, XrefRangeStart = 301762, XrefRangeEnd = 301807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisualElement MakeItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnController.NativeMethodInfoPtr_MakeItem_Public_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x000474DC File Offset: 0x000456DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 301854, RefRangeEnd = 301856, XrefRangeStart = 301809, XrefRangeEnd = 301854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BindItem<T>(VisualElement element, int index, T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = item;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref item;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MultiColumnController.MethodInfoStoreGeneric_BindItem_Public_Void_VisualElement_Int32_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x00047574 File Offset: 0x00045774
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 301890, RefRangeEnd = 301892, XrefRangeStart = 301856, XrefRangeEnd = 301890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnbindItem(VisualElement element, int index)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnController.NativeMethodInfoPtr_UnbindItem_Public_Void_VisualElement_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x000475C4 File Offset: 0x000457C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 301930, RefRangeEnd = 301932, XrefRangeStart = 301892, XrefRangeEnd = 301930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyItem(VisualElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnController.NativeMethodInfoPtr_DestroyItem_Public_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x00047608 File Offset: 0x00045808
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 301974, RefRangeEnd = 301976, XrefRangeStart = 301932, XrefRangeEnd = 301974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrepareView(BaseVerticalCollectionView collectionView)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collectionView);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnController.NativeMethodInfoPtr_PrepareView_Public_Void_BaseVerticalCollectionView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x0004764C File Offset: 0x0004584C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 302093, RefRangeEnd = 302095, XrefRangeStart = 301976, XrefRangeEnd = 302093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnController.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x00047680 File Offset: 0x00045880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302095, XrefRangeEnd = 302097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnHorizontalScrollerValueChanged(float v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnController.NativeMethodInfoPtr_OnHorizontalScrollerValueChanged_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x000476C0 File Offset: 0x000458C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302097, XrefRangeEnd = 302117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnViewportGeometryChanged(GeometryChangedEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnController.NativeMethodInfoPtr_OnViewportGeometryChanged_Private_Void_GeometryChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x00047704 File Offset: 0x00045904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302117, XrefRangeEnd = 302118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnColumnContainerGeometryChanged(GeometryChangedEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnController.NativeMethodInfoPtr_OnColumnContainerGeometryChanged_Private_Void_GeometryChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x00047748 File Offset: 0x00045948
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 302128, RefRangeEnd = 302130, XrefRangeStart = 302118, XrefRangeEnd = 302128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateContentContainer(BaseVerticalCollectionView collectionView)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collectionView);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnController.NativeMethodInfoPtr_UpdateContentContainer_Private_Void_BaseVerticalCollectionView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x0004778C File Offset: 0x0004598C
		[CallerCount(0)]
		public unsafe void OnColumnSortingChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnController.NativeMethodInfoPtr_OnColumnSortingChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x000477C0 File Offset: 0x000459C0
		[CallerCount(0)]
		public unsafe void OnContextMenuPopulateEvent(ContextualMenuPopulateEvent evt, Column column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(column);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnController.NativeMethodInfoPtr_OnContextMenuPopulateEvent_Private_Void_ContextualMenuPopulateEvent_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x00047814 File Offset: 0x00045A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302130, XrefRangeEnd = 302155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnColumnResized(int index, float width)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnController.NativeMethodInfoPtr_OnColumnResized_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x00047860 File Offset: 0x00045A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302155, XrefRangeEnd = 302157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnColumnAdded(Column column, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnController.NativeMethodInfoPtr_OnColumnAdded_Private_Void_Column_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x000478B0 File Offset: 0x00045AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnColumnRemoved(Column column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnController.NativeMethodInfoPtr_OnColumnRemoved_Private_Void_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x000478F4 File Offset: 0x00045AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302157, XrefRangeEnd = 302158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnColumnReordered(Column column, int from, int to)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref from;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnController.NativeMethodInfoPtr_OnColumnReordered_Private_Void_Column_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x00047954 File Offset: 0x00045B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302158, XrefRangeEnd = 302159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnColumnsChanged(Column column, ColumnDataType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnController.NativeMethodInfoPtr_OnColumnsChanged_Private_Void_Column_ColumnDataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x000479A4 File Offset: 0x00045BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302159, XrefRangeEnd = 302160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnColumnChanged(ColumnsDataType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnController.NativeMethodInfoPtr_OnColumnChanged_Private_Void_ColumnsDataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x000479E4 File Offset: 0x00045BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnViewDataRestored()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnController.NativeMethodInfoPtr_OnViewDataRestored_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x00006573 File Offset: 0x00004773
		public MultiColumnController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x00047A18 File Offset: 0x00045C18
		// (set) Token: 0x06000BEF RID: 3055 RVA: 0x0000657C File Offset: 0x0000477C
		public unsafe static PropertyName k_BoundColumnVePropertyName
		{
			get
			{
				PropertyName propertyName;
				IL2CPP.il2cpp_field_static_get_value(MultiColumnController.NativeFieldInfoPtr_k_BoundColumnVePropertyName, (void*)(&propertyName));
				return propertyName;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultiColumnController.NativeFieldInfoPtr_k_BoundColumnVePropertyName, (void*)(&value));
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000BF0 RID: 3056 RVA: 0x00047A34 File Offset: 0x00045C34
		// (set) Token: 0x06000BF1 RID: 3057 RVA: 0x0000658A File Offset: 0x0000478A
		public unsafe static PropertyName bindableElementPropertyName
		{
			get
			{
				PropertyName propertyName;
				IL2CPP.il2cpp_field_static_get_value(MultiColumnController.NativeFieldInfoPtr_bindableElementPropertyName, (void*)(&propertyName));
				return propertyName;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultiColumnController.NativeFieldInfoPtr_bindableElementPropertyName, (void*)(&value));
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000BF2 RID: 3058 RVA: 0x00047A50 File Offset: 0x00045C50
		// (set) Token: 0x06000BF3 RID: 3059 RVA: 0x00006598 File Offset: 0x00004798
		public unsafe static string baseUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MultiColumnController.NativeFieldInfoPtr_baseUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultiColumnController.NativeFieldInfoPtr_baseUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000BF4 RID: 3060 RVA: 0x00047A70 File Offset: 0x00045C70
		// (set) Token: 0x06000BF5 RID: 3061 RVA: 0x000065AA File Offset: 0x000047AA
		public unsafe static string k_HeaderContainerViewDataKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MultiColumnController.NativeFieldInfoPtr_k_HeaderContainerViewDataKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultiColumnController.NativeFieldInfoPtr_k_HeaderContainerViewDataKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000BF6 RID: 3062 RVA: 0x00047A90 File Offset: 0x00045C90
		// (set) Token: 0x06000BF7 RID: 3063 RVA: 0x000065BC File Offset: 0x000047BC
		public unsafe static string headerContainerUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MultiColumnController.NativeFieldInfoPtr_headerContainerUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultiColumnController.NativeFieldInfoPtr_headerContainerUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000BF8 RID: 3064 RVA: 0x00047AB0 File Offset: 0x00045CB0
		// (set) Token: 0x06000BF9 RID: 3065 RVA: 0x000065CE File Offset: 0x000047CE
		public unsafe static string rowContainerUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MultiColumnController.NativeFieldInfoPtr_rowContainerUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultiColumnController.NativeFieldInfoPtr_rowContainerUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000BFA RID: 3066 RVA: 0x00047AD0 File Offset: 0x00045CD0
		// (set) Token: 0x06000BFB RID: 3067 RVA: 0x000065E0 File Offset: 0x000047E0
		public unsafe static string cellUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MultiColumnController.NativeFieldInfoPtr_cellUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultiColumnController.NativeFieldInfoPtr_cellUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000BFC RID: 3068 RVA: 0x00047AF0 File Offset: 0x00045CF0
		// (set) Token: 0x06000BFD RID: 3069 RVA: 0x000065F2 File Offset: 0x000047F2
		public unsafe static string cellLabelUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MultiColumnController.NativeFieldInfoPtr_cellLabelUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultiColumnController.NativeFieldInfoPtr_cellLabelUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000BFE RID: 3070 RVA: 0x00047B10 File Offset: 0x00045D10
		// (set) Token: 0x06000BFF RID: 3071 RVA: 0x00006604 File Offset: 0x00004804
		public unsafe static string k_HeaderViewDataKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MultiColumnController.NativeFieldInfoPtr_k_HeaderViewDataKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultiColumnController.NativeFieldInfoPtr_k_HeaderViewDataKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000C00 RID: 3072 RVA: 0x00047B30 File Offset: 0x00045D30
		// (set) Token: 0x06000C01 RID: 3073 RVA: 0x00006616 File Offset: 0x00004816
		public unsafe Action columnSortingChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnController.NativeFieldInfoPtr_columnSortingChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnController.NativeFieldInfoPtr_columnSortingChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000C02 RID: 3074 RVA: 0x00047B60 File Offset: 0x00045D60
		// (set) Token: 0x06000C03 RID: 3075 RVA: 0x00006635 File Offset: 0x00004835
		public unsafe Action<ContextualMenuPopulateEvent, Column> headerContextMenuPopulateEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnController.NativeFieldInfoPtr_headerContextMenuPopulateEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ContextualMenuPopulateEvent, Column>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnController.NativeFieldInfoPtr_headerContextMenuPopulateEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000C04 RID: 3076 RVA: 0x00047B90 File Offset: 0x00045D90
		// (set) Token: 0x06000C05 RID: 3077 RVA: 0x00006654 File Offset: 0x00004854
		public unsafe BaseVerticalCollectionView m_View
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnController.NativeFieldInfoPtr_m_View);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseVerticalCollectionView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnController.NativeFieldInfoPtr_m_View), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000C06 RID: 3078 RVA: 0x00047BC0 File Offset: 0x00045DC0
		// (set) Token: 0x06000C07 RID: 3079 RVA: 0x00006673 File Offset: 0x00004873
		public unsafe VisualElement m_HeaderContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnController.NativeFieldInfoPtr_m_HeaderContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnController.NativeFieldInfoPtr_m_HeaderContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000C08 RID: 3080 RVA: 0x00047BF0 File Offset: 0x00045DF0
		// (set) Token: 0x06000C09 RID: 3081 RVA: 0x00006692 File Offset: 0x00004892
		public unsafe UnityEngine.UIElements.Internal.MultiColumnCollectionHeader m_MultiColumnHeader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnController.NativeFieldInfoPtr_m_MultiColumnHeader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEngine.UIElements.Internal.MultiColumnCollectionHeader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnController.NativeFieldInfoPtr_m_MultiColumnHeader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400083E RID: 2110
		private static readonly IntPtr NativeFieldInfoPtr_k_BoundColumnVePropertyName;

		// Token: 0x0400083F RID: 2111
		private static readonly IntPtr NativeFieldInfoPtr_bindableElementPropertyName;

		// Token: 0x04000840 RID: 2112
		private static readonly IntPtr NativeFieldInfoPtr_baseUssClassName;

		// Token: 0x04000841 RID: 2113
		private static readonly IntPtr NativeFieldInfoPtr_k_HeaderContainerViewDataKey;

		// Token: 0x04000842 RID: 2114
		private static readonly IntPtr NativeFieldInfoPtr_headerContainerUssClassName;

		// Token: 0x04000843 RID: 2115
		private static readonly IntPtr NativeFieldInfoPtr_rowContainerUssClassName;

		// Token: 0x04000844 RID: 2116
		private static readonly IntPtr NativeFieldInfoPtr_cellUssClassName;

		// Token: 0x04000845 RID: 2117
		private static readonly IntPtr NativeFieldInfoPtr_cellLabelUssClassName;

		// Token: 0x04000846 RID: 2118
		private static readonly IntPtr NativeFieldInfoPtr_k_HeaderViewDataKey;

		// Token: 0x04000847 RID: 2119
		private static readonly IntPtr NativeFieldInfoPtr_columnSortingChanged;

		// Token: 0x04000848 RID: 2120
		private static readonly IntPtr NativeFieldInfoPtr_headerContextMenuPopulateEvent;

		// Token: 0x04000849 RID: 2121
		private static readonly IntPtr NativeFieldInfoPtr_m_View;

		// Token: 0x0400084A RID: 2122
		private static readonly IntPtr NativeFieldInfoPtr_m_HeaderContainer;

		// Token: 0x0400084B RID: 2123
		private static readonly IntPtr NativeFieldInfoPtr_m_MultiColumnHeader;

		// Token: 0x0400084C RID: 2124
		private static readonly IntPtr NativeMethodInfoPtr_add_columnSortingChanged_Public_add_Void_Action_0;

		// Token: 0x0400084D RID: 2125
		private static readonly IntPtr NativeMethodInfoPtr_remove_columnSortingChanged_Public_rem_Void_Action_0;

		// Token: 0x0400084E RID: 2126
		private static readonly IntPtr NativeMethodInfoPtr_add_headerContextMenuPopulateEvent_Public_add_Void_Action_2_ContextualMenuPopulateEvent_Column_0;

		// Token: 0x0400084F RID: 2127
		private static readonly IntPtr NativeMethodInfoPtr_remove_headerContextMenuPopulateEvent_Public_rem_Void_Action_2_ContextualMenuPopulateEvent_Column_0;

		// Token: 0x04000850 RID: 2128
		private static readonly IntPtr NativeMethodInfoPtr_get_header_Internal_get_MultiColumnCollectionHeader_0;

		// Token: 0x04000851 RID: 2129
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Columns_SortColumnDescriptions_List_1_SortColumnDescription_0;

		// Token: 0x04000852 RID: 2130
		private static readonly IntPtr NativeMethodInfoPtr_BindCellItem_Private_Static_Void_VisualElement_Int32_Column_T_0;

		// Token: 0x04000853 RID: 2131
		private static readonly IntPtr NativeMethodInfoPtr_UnbindCellItem_Private_Static_Void_VisualElement_Int32_Column_0;

		// Token: 0x04000854 RID: 2132
		private static readonly IntPtr NativeMethodInfoPtr_DefaultMakeCellItem_Private_Static_VisualElement_0;

		// Token: 0x04000855 RID: 2133
		private static readonly IntPtr NativeMethodInfoPtr_DefaultBindCellItem_Private_Static_Void_VisualElement_Column_T_0;

		// Token: 0x04000856 RID: 2134
		private static readonly IntPtr NativeMethodInfoPtr_MakeItem_Public_VisualElement_0;

		// Token: 0x04000857 RID: 2135
		private static readonly IntPtr NativeMethodInfoPtr_BindItem_Public_Void_VisualElement_Int32_T_0;

		// Token: 0x04000858 RID: 2136
		private static readonly IntPtr NativeMethodInfoPtr_UnbindItem_Public_Void_VisualElement_Int32_0;

		// Token: 0x04000859 RID: 2137
		private static readonly IntPtr NativeMethodInfoPtr_DestroyItem_Public_Void_VisualElement_0;

		// Token: 0x0400085A RID: 2138
		private static readonly IntPtr NativeMethodInfoPtr_PrepareView_Public_Void_BaseVerticalCollectionView_0;

		// Token: 0x0400085B RID: 2139
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400085C RID: 2140
		private static readonly IntPtr NativeMethodInfoPtr_OnHorizontalScrollerValueChanged_Private_Void_Single_0;

		// Token: 0x0400085D RID: 2141
		private static readonly IntPtr NativeMethodInfoPtr_OnViewportGeometryChanged_Private_Void_GeometryChangedEvent_0;

		// Token: 0x0400085E RID: 2142
		private static readonly IntPtr NativeMethodInfoPtr_OnColumnContainerGeometryChanged_Private_Void_GeometryChangedEvent_0;

		// Token: 0x0400085F RID: 2143
		private static readonly IntPtr NativeMethodInfoPtr_UpdateContentContainer_Private_Void_BaseVerticalCollectionView_0;

		// Token: 0x04000860 RID: 2144
		private static readonly IntPtr NativeMethodInfoPtr_OnColumnSortingChanged_Private_Void_0;

		// Token: 0x04000861 RID: 2145
		private static readonly IntPtr NativeMethodInfoPtr_OnContextMenuPopulateEvent_Private_Void_ContextualMenuPopulateEvent_Column_0;

		// Token: 0x04000862 RID: 2146
		private static readonly IntPtr NativeMethodInfoPtr_OnColumnResized_Private_Void_Int32_Single_0;

		// Token: 0x04000863 RID: 2147
		private static readonly IntPtr NativeMethodInfoPtr_OnColumnAdded_Private_Void_Column_Int32_0;

		// Token: 0x04000864 RID: 2148
		private static readonly IntPtr NativeMethodInfoPtr_OnColumnRemoved_Private_Void_Column_0;

		// Token: 0x04000865 RID: 2149
		private static readonly IntPtr NativeMethodInfoPtr_OnColumnReordered_Private_Void_Column_Int32_Int32_0;

		// Token: 0x04000866 RID: 2150
		private static readonly IntPtr NativeMethodInfoPtr_OnColumnsChanged_Private_Void_Column_ColumnDataType_0;

		// Token: 0x04000867 RID: 2151
		private static readonly IntPtr NativeMethodInfoPtr_OnColumnChanged_Private_Void_ColumnsDataType_0;

		// Token: 0x04000868 RID: 2152
		private static readonly IntPtr NativeMethodInfoPtr_OnViewDataRestored_Private_Void_0;

		// Token: 0x020003A4 RID: 932
		private sealed class MethodInfoStoreGeneric_BindCellItem_Private_Static_Void_VisualElement_Int32_Column_T_0<T>
		{
			// Token: 0x04002859 RID: 10329
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MultiColumnController.NativeMethodInfoPtr_BindCellItem_Private_Static_Void_VisualElement_Int32_Column_T_0, Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003A5 RID: 933
		private sealed class MethodInfoStoreGeneric_DefaultBindCellItem_Private_Static_Void_VisualElement_Column_T_0<T>
		{
			// Token: 0x0400285A RID: 10330
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MultiColumnController.NativeMethodInfoPtr_DefaultBindCellItem_Private_Static_Void_VisualElement_Column_T_0, Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003A6 RID: 934
		private sealed class MethodInfoStoreGeneric_BindItem_Public_Void_VisualElement_Int32_T_0<T>
		{
			// Token: 0x0400285B RID: 10331
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MultiColumnController.NativeMethodInfoPtr_BindItem_Public_Void_VisualElement_Int32_T_0, Il2CppClassPointerStore<MultiColumnController>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
