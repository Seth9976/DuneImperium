using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000032 RID: 50
	public class DynamicHeightVirtualizationController<T> : VerticalVirtualizationController<T> where T : ReusableCollectionItem, new()
	{
		// Token: 0x0600038E RID: 910 RVA: 0x0002A870 File Offset: 0x00028A70
		// Note: this type is marked as 'beforefieldinit'.
		static DynamicHeightVirtualizationController()
		{
			Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "DynamicHeightVirtualizationController`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr);
			DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_HighestCachedIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, "m_HighestCachedIndex");
			DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_ItemHeightCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, "m_ItemHeightCache");
			DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_ContentHeightCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, "m_ContentHeightCache");
			DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_WaitingCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, "m_WaitingCache");
			DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_ForcedFirstVisibleItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, "m_ForcedFirstVisibleItem");
			DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_ForcedLastVisibleItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, "m_ForcedLastVisibleItem");
			DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_StickToBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, "m_StickToBottom");
			DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_LastChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, "m_LastChange");
			DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_ScrollDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, "m_ScrollDirection");
			DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_DelayedScrollOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, "m_DelayedScrollOffset");
			DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_AccumulatedHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, "m_AccumulatedHeight");
			DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_MinimumItemHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, "m_MinimumItemHeight");
			DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_FillCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, "m_FillCallback");
			DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_ScrollCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, "m_ScrollCallback");
			DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_ScrollResetCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, "m_ScrollResetCallback");
			DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_GeometryChangedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, "m_GeometryChangedCallback");
			DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_ScheduledItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, "m_ScheduledItem");
			DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_ScrollScheduledItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, "m_ScrollScheduledItem");
			DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_ScrollResetScheduledItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, "m_ScrollResetScheduledItem");
			DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_IndexOutOfBoundsPredicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, "m_IndexOutOfBoundsPredicate");
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_get_defaultExpectedHeight_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663824);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_get_contentPadding_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663825);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_set_contentPadding_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663826);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_get_contentHeight_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663827);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_set_contentHeight_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663828);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_get_anchoredIndex_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663829);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_set_anchoredIndex_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663830);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_get_anchorOffset_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663831);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_set_anchorOffset_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663832);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_get_viewportMaxOffset_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663833);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_get_alwaysRebindOnRefresh_Protected_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663834);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr__ctor_Public_Void_BaseVerticalCollectionView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663835);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_Refresh_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663836);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_ScrollToItem_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663837);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_Resize_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663838);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_OnScroll_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663839);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_OnScrollUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663840);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_CycleItems_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663841);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_NeedsFill_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663842);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_Fill_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663843);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_UpdateScrollViewContainer_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663844);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_ApplyScrollViewUpdate_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663845);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_UpdateAnchor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663846);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_ScheduleFill_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663847);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_ScheduleScroll_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663848);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_ScheduleScrollDirectionReset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663849);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_ResetScroll_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663850);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_GetIndexFromPosition_Public_Virtual_Int32_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663851);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_GetExpectedItemHeight_Public_Virtual_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663852);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_GetFirstVisibleItem_Private_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663853);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_GetExpectedContentHeight_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663854);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_GetContentHeightForIndex_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663855);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_GetCachedContentHeight_Private_ContentHeightCacheInfo_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663856);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_RegisterItemHeight_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663857);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_UnregisterItemHeight_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663858);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_CleanItemHeightCache_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663859);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_OnRecycledItemGeometryChanged_Private_Void_ReusableCollectionItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663860);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_UpdateRegisteredHeight_Private_Boolean_ReusableCollectionItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663861);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_GetOrMakeItemAtIndex_Internal_Virtual_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663862);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_ReleaseItem_Internal_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663863);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_StartDragItem_Internal_Virtual_Void_ReusableCollectionItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663864);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_EndDrag_Internal_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663865);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_HideItem_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663866);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_MarkWaitingForLayout_Private_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663867);
			DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_IsIndexOutOfBounds_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, 100663868);
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600038F RID: 911 RVA: 0x0002ADF0 File Offset: 0x00028FF0
		public unsafe float defaultExpectedHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286597, XrefRangeEnd = 286598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_get_defaultExpectedHeight_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000390 RID: 912 RVA: 0x0002AE2C File Offset: 0x0002902C
		// (set) Token: 0x06000391 RID: 913 RVA: 0x0002AE68 File Offset: 0x00029068
		public unsafe float contentPadding
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286598, XrefRangeEnd = 286599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_get_contentPadding_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286599, XrefRangeEnd = 286608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_set_contentPadding_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000392 RID: 914 RVA: 0x0002AEA8 File Offset: 0x000290A8
		// (set) Token: 0x06000393 RID: 915 RVA: 0x0002AEE4 File Offset: 0x000290E4
		public unsafe float contentHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286608, XrefRangeEnd = 286609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_get_contentHeight_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286609, XrefRangeEnd = 286618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_set_contentHeight_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000394 RID: 916 RVA: 0x0002AF24 File Offset: 0x00029124
		// (set) Token: 0x06000395 RID: 917 RVA: 0x0002AF60 File Offset: 0x00029160
		public unsafe int anchoredIndex
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286618, XrefRangeEnd = 286619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_get_anchoredIndex_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286619, XrefRangeEnd = 286622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_set_anchoredIndex_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000396 RID: 918 RVA: 0x0002AFA0 File Offset: 0x000291A0
		// (set) Token: 0x06000397 RID: 919 RVA: 0x0002AFDC File Offset: 0x000291DC
		public unsafe float anchorOffset
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286622, XrefRangeEnd = 286623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_get_anchorOffset_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286623, XrefRangeEnd = 286626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_set_anchorOffset_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000398 RID: 920 RVA: 0x0002B01C File Offset: 0x0002921C
		public unsafe float viewportMaxOffset
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286626, XrefRangeEnd = 286628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_get_viewportMaxOffset_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000399 RID: 921 RVA: 0x0002B058 File Offset: 0x00029258
		public unsafe override bool alwaysRebindOnRefresh
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_get_alwaysRebindOnRefresh_Protected_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0002B0A0 File Offset: 0x000292A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286628, XrefRangeEnd = 286672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicHeightVirtualizationController(BaseVerticalCollectionView collectionView)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collectionView);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr__ctor_Public_Void_BaseVerticalCollectionView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0002B0EC File Offset: 0x000292EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286672, XrefRangeEnd = 286692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Refresh(bool rebuild)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rebuild;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_Refresh_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600039C RID: 924 RVA: 0x0002B138 File Offset: 0x00029338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286692, XrefRangeEnd = 286701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ScrollToItem(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_ScrollToItem_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0002B184 File Offset: 0x00029384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286701, XrefRangeEnd = 286728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resize(Vector2 size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_Resize_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0002B1D0 File Offset: 0x000293D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286728, XrefRangeEnd = 286741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnScroll(Vector2 scrollOffset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scrollOffset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_OnScroll_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0002B21C File Offset: 0x0002941C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286741, XrefRangeEnd = 286766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnScrollUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_OnScrollUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0002B250 File Offset: 0x00029450
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 286817, RefRangeEnd = 286819, XrefRangeStart = 286766, XrefRangeEnd = 286817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CycleItems(int firstIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref firstIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_CycleItems_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0002B290 File Offset: 0x00029490
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286831, RefRangeEnd = 286832, XrefRangeStart = 286819, XrefRangeEnd = 286831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool NeedsFill()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_NeedsFill_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0002B2CC File Offset: 0x000294CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286875, RefRangeEnd = 286876, XrefRangeStart = 286832, XrefRangeEnd = 286875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Fill()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_Fill_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0002B300 File Offset: 0x00029500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286876, XrefRangeEnd = 286878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateScrollViewContainer(float previousHeight, float newHeight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref previousHeight;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_UpdateScrollViewContainer_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0002B34C File Offset: 0x0002954C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 286935, RefRangeEnd = 286937, XrefRangeStart = 286878, XrefRangeEnd = 286935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyScrollViewUpdate(bool dimensionsOnly = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dimensionsOnly;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_ApplyScrollViewUpdate_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0002B38C File Offset: 0x0002958C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286937, XrefRangeEnd = 286944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAnchor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_UpdateAnchor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0002B3C0 File Offset: 0x000295C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286944, XrefRangeEnd = 286950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScheduleFill()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_ScheduleFill_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0002B3F4 File Offset: 0x000295F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286950, XrefRangeEnd = 286956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScheduleScroll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_ScheduleScroll_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0002B428 File Offset: 0x00029628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286956, XrefRangeEnd = 286962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScheduleScrollDirectionReset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_ScheduleScrollDirectionReset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0002B45C File Offset: 0x0002965C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286962, XrefRangeEnd = 286966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetScroll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_ResetScroll_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0002B490 File Offset: 0x00029690
		[CallerCount(0)]
		public unsafe override int GetIndexFromPosition(Vector2 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_GetIndexFromPosition_Public_Virtual_Int32_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0002B4E4 File Offset: 0x000296E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286966, XrefRangeEnd = 286972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float GetExpectedItemHeight(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_GetExpectedItemHeight_Public_Virtual_Single_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0002B538 File Offset: 0x00029738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286972, XrefRangeEnd = 286973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetFirstVisibleItem(float offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_GetFirstVisibleItem_Private_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0002B584 File Offset: 0x00029784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286973, XrefRangeEnd = 286978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float GetExpectedContentHeight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_GetExpectedContentHeight_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0002B5CC File Offset: 0x000297CC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 286987, RefRangeEnd = 286995, XrefRangeStart = 286978, XrefRangeEnd = 286987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetContentHeightForIndex(int lastIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lastIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_GetContentHeightForIndex_Private_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0002B618 File Offset: 0x00029818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286995, XrefRangeEnd = 286996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicHeightVirtualizationController<T>.ContentHeightCacheInfo GetCachedContentHeight(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_GetCachedContentHeight_Private_ContentHeightCacheInfo_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new DynamicHeightVirtualizationController<T>.ContentHeightCacheInfo(intPtr);
			}
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0002B65C File Offset: 0x0002985C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 287026, RefRangeEnd = 287029, XrefRangeStart = 286996, XrefRangeEnd = 287026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterItemHeight(int index, float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_RegisterItemHeight_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0002B6A8 File Offset: 0x000298A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287054, RefRangeEnd = 287056, XrefRangeStart = 287029, XrefRangeEnd = 287054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterItemHeight(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_UnregisterItemHeight_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0002B6E8 File Offset: 0x000298E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 287108, RefRangeEnd = 287109, XrefRangeStart = 287056, XrefRangeEnd = 287108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanItemHeightCache()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_CleanItemHeightCache_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0002B71C File Offset: 0x0002991C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287109, XrefRangeEnd = 287113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRecycledItemGeometryChanged(ReusableCollectionItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_OnRecycledItemGeometryChanged_Private_Void_ReusableCollectionItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0002B760 File Offset: 0x00029960
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 287153, RefRangeEnd = 287154, XrefRangeStart = 287113, XrefRangeEnd = 287153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UpdateRegisteredHeight(ReusableCollectionItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_UpdateRegisteredHeight_Private_Boolean_ReusableCollectionItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0002B7B0 File Offset: 0x000299B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287154, XrefRangeEnd = 287156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override T GetOrMakeItemAtIndex(int activeItemIndex = -1, int scrollViewIndex = -1)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_GetOrMakeItemAtIndex_Internal_Virtual_T_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0002B810 File Offset: 0x00029A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287156, XrefRangeEnd = 287164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ReleaseItem(int activeItemsIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref activeItemsIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_ReleaseItem_Internal_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0002B85C File Offset: 0x00029A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287164, XrefRangeEnd = 287170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartDragItem(ReusableCollectionItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_StartDragItem_Internal_Virtual_Void_ReusableCollectionItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0002B8AC File Offset: 0x00029AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287170, XrefRangeEnd = 287180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EndDrag(int dropIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dropIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_EndDrag_Internal_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0002B8F8 File Offset: 0x00029AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287180, XrefRangeEnd = 287193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideItem(int activeItemsIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref activeItemsIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_HideItem_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0002B938 File Offset: 0x00029B38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287193, XrefRangeEnd = 287199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkWaitingForLayout(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_MarkWaitingForLayout_Private_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0002B9B0 File Offset: 0x00029BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287199, XrefRangeEnd = 287200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsIndexOutOfBounds(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicHeightVirtualizationController<T>.NativeMethodInfoPtr_IsIndexOutOfBounds_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00002EE2 File Offset: 0x000010E2
		public DynamicHeightVirtualizationController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060003BD RID: 957 RVA: 0x0002B9FC File Offset: 0x00029BFC
		// (set) Token: 0x060003BE RID: 958 RVA: 0x00002EEB File Offset: 0x000010EB
		public unsafe int m_HighestCachedIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_HighestCachedIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_HighestCachedIndex)) = value;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060003BF RID: 959 RVA: 0x0002BA24 File Offset: 0x00029C24
		// (set) Token: 0x060003C0 RID: 960 RVA: 0x00002F06 File Offset: 0x00001106
		public unsafe Dictionary<int, float> m_ItemHeightCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_ItemHeightCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_ItemHeightCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x0002BA54 File Offset: 0x00029C54
		// (set) Token: 0x060003C2 RID: 962 RVA: 0x00002F25 File Offset: 0x00001125
		public unsafe Dictionary<int, DynamicHeightVirtualizationController<T>.ContentHeightCacheInfo> m_ContentHeightCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_ContentHeightCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, DynamicHeightVirtualizationController<T>.ContentHeightCacheInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_ContentHeightCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x0002BA84 File Offset: 0x00029C84
		// (set) Token: 0x060003C4 RID: 964 RVA: 0x00002F44 File Offset: 0x00001144
		public unsafe HashSet<int> m_WaitingCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_WaitingCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_WaitingCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x0002BAB4 File Offset: 0x00029CB4
		// (set) Token: 0x060003C6 RID: 966 RVA: 0x00002F63 File Offset: 0x00001163
		public unsafe int m_ForcedFirstVisibleItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_ForcedFirstVisibleItem);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_ForcedFirstVisibleItem)) = value;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x0002BADC File Offset: 0x00029CDC
		// (set) Token: 0x060003C8 RID: 968 RVA: 0x00002F7E File Offset: 0x0000117E
		public unsafe int m_ForcedLastVisibleItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_ForcedLastVisibleItem);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_ForcedLastVisibleItem)) = value;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x0002BB04 File Offset: 0x00029D04
		// (set) Token: 0x060003CA RID: 970 RVA: 0x00002F99 File Offset: 0x00001199
		public unsafe bool m_StickToBottom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_StickToBottom);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_StickToBottom)) = value;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060003CB RID: 971 RVA: 0x0002BB2C File Offset: 0x00029D2C
		// (set) Token: 0x060003CC RID: 972 RVA: 0x00002FB4 File Offset: 0x000011B4
		public unsafe DynamicHeightVirtualizationController<T>.VirtualizationChange m_LastChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_LastChange);
				return *intPtr;
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_LastChange), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>.VirtualizationChange>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060003CD RID: 973 RVA: 0x0002BB54 File Offset: 0x00029D54
		// (set) Token: 0x060003CE RID: 974 RVA: 0x00002FE2 File Offset: 0x000011E2
		public unsafe DynamicHeightVirtualizationController<T>.ScrollDirection m_ScrollDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_ScrollDirection);
				return *intPtr;
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_ScrollDirection), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>.ScrollDirection>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060003CF RID: 975 RVA: 0x0002BB7C File Offset: 0x00029D7C
		// (set) Token: 0x060003D0 RID: 976 RVA: 0x00003010 File Offset: 0x00001210
		public unsafe Vector2 m_DelayedScrollOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_DelayedScrollOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_DelayedScrollOffset)) = value;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x0002BBA4 File Offset: 0x00029DA4
		// (set) Token: 0x060003D2 RID: 978 RVA: 0x0000302B File Offset: 0x0000122B
		public unsafe float m_AccumulatedHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_AccumulatedHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_AccumulatedHeight)) = value;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x0002BBCC File Offset: 0x00029DCC
		// (set) Token: 0x060003D4 RID: 980 RVA: 0x00003046 File Offset: 0x00001246
		public unsafe float m_MinimumItemHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_MinimumItemHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_MinimumItemHeight)) = value;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x0002BBF4 File Offset: 0x00029DF4
		// (set) Token: 0x060003D6 RID: 982 RVA: 0x00003061 File Offset: 0x00001261
		public unsafe Action m_FillCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_FillCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_FillCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x0002BC24 File Offset: 0x00029E24
		// (set) Token: 0x060003D8 RID: 984 RVA: 0x00003080 File Offset: 0x00001280
		public unsafe Action m_ScrollCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_ScrollCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_ScrollCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x0002BC54 File Offset: 0x00029E54
		// (set) Token: 0x060003DA RID: 986 RVA: 0x0000309F File Offset: 0x0000129F
		public unsafe Action m_ScrollResetCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_ScrollResetCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_ScrollResetCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060003DB RID: 987 RVA: 0x0002BC84 File Offset: 0x00029E84
		// (set) Token: 0x060003DC RID: 988 RVA: 0x000030BE File Offset: 0x000012BE
		public unsafe Action<ReusableCollectionItem> m_GeometryChangedCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_GeometryChangedCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ReusableCollectionItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_GeometryChangedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060003DD RID: 989 RVA: 0x0002BCB4 File Offset: 0x00029EB4
		// (set) Token: 0x060003DE RID: 990 RVA: 0x000030DD File Offset: 0x000012DD
		public unsafe IVisualElementScheduledItem m_ScheduledItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_ScheduledItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IVisualElementScheduledItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_ScheduledItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060003DF RID: 991 RVA: 0x0002BCE4 File Offset: 0x00029EE4
		// (set) Token: 0x060003E0 RID: 992 RVA: 0x000030FC File Offset: 0x000012FC
		public unsafe IVisualElementScheduledItem m_ScrollScheduledItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_ScrollScheduledItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IVisualElementScheduledItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_ScrollScheduledItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x0002BD14 File Offset: 0x00029F14
		// (set) Token: 0x060003E2 RID: 994 RVA: 0x0000311B File Offset: 0x0000131B
		public unsafe IVisualElementScheduledItem m_ScrollResetScheduledItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_ScrollResetScheduledItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IVisualElementScheduledItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_ScrollResetScheduledItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x0002BD44 File Offset: 0x00029F44
		// (set) Token: 0x060003E4 RID: 996 RVA: 0x0000313A File Offset: 0x0000133A
		public unsafe Predicate<int> m_IndexOutOfBoundsPredicate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_IndexOutOfBoundsPredicate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.NativeFieldInfoPtr_m_IndexOutOfBoundsPredicate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x00003159 File Offset: 0x00001359
		public IReadOnlyDictionary<int, float> itemHeightCache
		{
			get
			{
				return this.m_ItemHeightCache;
			}
		}

		// Token: 0x040002BF RID: 703
		private static readonly IntPtr NativeFieldInfoPtr_m_HighestCachedIndex;

		// Token: 0x040002C0 RID: 704
		private static readonly IntPtr NativeFieldInfoPtr_m_ItemHeightCache;

		// Token: 0x040002C1 RID: 705
		private static readonly IntPtr NativeFieldInfoPtr_m_ContentHeightCache;

		// Token: 0x040002C2 RID: 706
		private static readonly IntPtr NativeFieldInfoPtr_m_WaitingCache;

		// Token: 0x040002C3 RID: 707
		private static readonly IntPtr NativeFieldInfoPtr_m_ForcedFirstVisibleItem;

		// Token: 0x040002C4 RID: 708
		private static readonly IntPtr NativeFieldInfoPtr_m_ForcedLastVisibleItem;

		// Token: 0x040002C5 RID: 709
		private static readonly IntPtr NativeFieldInfoPtr_m_StickToBottom;

		// Token: 0x040002C6 RID: 710
		private static readonly IntPtr NativeFieldInfoPtr_m_LastChange;

		// Token: 0x040002C7 RID: 711
		private static readonly IntPtr NativeFieldInfoPtr_m_ScrollDirection;

		// Token: 0x040002C8 RID: 712
		private static readonly IntPtr NativeFieldInfoPtr_m_DelayedScrollOffset;

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr NativeFieldInfoPtr_m_AccumulatedHeight;

		// Token: 0x040002CA RID: 714
		private static readonly IntPtr NativeFieldInfoPtr_m_MinimumItemHeight;

		// Token: 0x040002CB RID: 715
		private static readonly IntPtr NativeFieldInfoPtr_m_FillCallback;

		// Token: 0x040002CC RID: 716
		private static readonly IntPtr NativeFieldInfoPtr_m_ScrollCallback;

		// Token: 0x040002CD RID: 717
		private static readonly IntPtr NativeFieldInfoPtr_m_ScrollResetCallback;

		// Token: 0x040002CE RID: 718
		private static readonly IntPtr NativeFieldInfoPtr_m_GeometryChangedCallback;

		// Token: 0x040002CF RID: 719
		private static readonly IntPtr NativeFieldInfoPtr_m_ScheduledItem;

		// Token: 0x040002D0 RID: 720
		private static readonly IntPtr NativeFieldInfoPtr_m_ScrollScheduledItem;

		// Token: 0x040002D1 RID: 721
		private static readonly IntPtr NativeFieldInfoPtr_m_ScrollResetScheduledItem;

		// Token: 0x040002D2 RID: 722
		private static readonly IntPtr NativeFieldInfoPtr_m_IndexOutOfBoundsPredicate;

		// Token: 0x040002D3 RID: 723
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultExpectedHeight_Private_get_Single_0;

		// Token: 0x040002D4 RID: 724
		private static readonly IntPtr NativeMethodInfoPtr_get_contentPadding_Private_get_Single_0;

		// Token: 0x040002D5 RID: 725
		private static readonly IntPtr NativeMethodInfoPtr_set_contentPadding_Private_set_Void_Single_0;

		// Token: 0x040002D6 RID: 726
		private static readonly IntPtr NativeMethodInfoPtr_get_contentHeight_Private_get_Single_0;

		// Token: 0x040002D7 RID: 727
		private static readonly IntPtr NativeMethodInfoPtr_set_contentHeight_Private_set_Void_Single_0;

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeMethodInfoPtr_get_anchoredIndex_Private_get_Int32_0;

		// Token: 0x040002D9 RID: 729
		private static readonly IntPtr NativeMethodInfoPtr_set_anchoredIndex_Private_set_Void_Int32_0;

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeMethodInfoPtr_get_anchorOffset_Private_get_Single_0;

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeMethodInfoPtr_set_anchorOffset_Private_set_Void_Single_0;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeMethodInfoPtr_get_viewportMaxOffset_Private_get_Single_0;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeMethodInfoPtr_get_alwaysRebindOnRefresh_Protected_Virtual_get_Boolean_0;

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BaseVerticalCollectionView_0;

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Virtual_Void_Boolean_0;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeMethodInfoPtr_ScrollToItem_Public_Virtual_Void_Int32_0;

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeMethodInfoPtr_Resize_Public_Virtual_Void_Vector2_0;

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeMethodInfoPtr_OnScroll_Public_Virtual_Void_Vector2_0;

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeMethodInfoPtr_OnScrollUpdate_Private_Void_0;

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeMethodInfoPtr_CycleItems_Private_Void_Int32_0;

		// Token: 0x040002E5 RID: 741
		private static readonly IntPtr NativeMethodInfoPtr_NeedsFill_Private_Boolean_0;

		// Token: 0x040002E6 RID: 742
		private static readonly IntPtr NativeMethodInfoPtr_Fill_Private_Void_0;

		// Token: 0x040002E7 RID: 743
		private static readonly IntPtr NativeMethodInfoPtr_UpdateScrollViewContainer_Private_Void_Single_Single_0;

		// Token: 0x040002E8 RID: 744
		private static readonly IntPtr NativeMethodInfoPtr_ApplyScrollViewUpdate_Private_Void_Boolean_0;

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAnchor_Private_Void_0;

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleFill_Private_Void_0;

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleScroll_Private_Void_0;

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleScrollDirectionReset_Private_Void_0;

		// Token: 0x040002ED RID: 749
		private static readonly IntPtr NativeMethodInfoPtr_ResetScroll_Private_Void_0;

		// Token: 0x040002EE RID: 750
		private static readonly IntPtr NativeMethodInfoPtr_GetIndexFromPosition_Public_Virtual_Int32_Vector2_0;

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeMethodInfoPtr_GetExpectedItemHeight_Public_Virtual_Single_Int32_0;

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstVisibleItem_Private_Int32_Single_0;

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeMethodInfoPtr_GetExpectedContentHeight_Public_Virtual_Single_0;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeMethodInfoPtr_GetContentHeightForIndex_Private_Single_Int32_0;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeMethodInfoPtr_GetCachedContentHeight_Private_ContentHeightCacheInfo_T_Int32_0;

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeMethodInfoPtr_RegisterItemHeight_Private_Void_Int32_Single_0;

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterItemHeight_Private_Void_Int32_0;

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeMethodInfoPtr_CleanItemHeightCache_Private_Void_0;

		// Token: 0x040002F7 RID: 759
		private static readonly IntPtr NativeMethodInfoPtr_OnRecycledItemGeometryChanged_Private_Void_ReusableCollectionItem_0;

		// Token: 0x040002F8 RID: 760
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRegisteredHeight_Private_Boolean_ReusableCollectionItem_0;

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeMethodInfoPtr_GetOrMakeItemAtIndex_Internal_Virtual_T_Int32_Int32_0;

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseItem_Internal_Virtual_Void_Int32_0;

		// Token: 0x040002FB RID: 763
		private static readonly IntPtr NativeMethodInfoPtr_StartDragItem_Internal_Virtual_Void_ReusableCollectionItem_0;

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeMethodInfoPtr_EndDrag_Internal_Virtual_Void_Int32_0;

		// Token: 0x040002FD RID: 765
		private static readonly IntPtr NativeMethodInfoPtr_HideItem_Private_Void_Int32_0;

		// Token: 0x040002FE RID: 766
		private static readonly IntPtr NativeMethodInfoPtr_MarkWaitingForLayout_Private_Void_T_0;

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeMethodInfoPtr_IsIndexOutOfBounds_Private_Boolean_Int32_0;

		// Token: 0x0200032B RID: 811
		public sealed class ContentHeightCacheInfo : ValueType
		{
			// Token: 0x06003575 RID: 13685 RVA: 0x000DDAC0 File Offset: 0x000DBCC0
			// Note: this type is marked as 'beforefieldinit'.
			static ContentHeightCacheInfo()
			{
				Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>.ContentHeightCacheInfo>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>>.NativeClassPtr, "ContentHeightCacheInfo"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>.ContentHeightCacheInfo>.NativeClassPtr);
				DynamicHeightVirtualizationController<T>.ContentHeightCacheInfo.NativeFieldInfoPtr_sum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>.ContentHeightCacheInfo>.NativeClassPtr, "sum");
				DynamicHeightVirtualizationController<T>.ContentHeightCacheInfo.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>.ContentHeightCacheInfo>.NativeClassPtr, "count");
				DynamicHeightVirtualizationController<T>.ContentHeightCacheInfo.NativeMethodInfoPtr__ctor_Public_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>.ContentHeightCacheInfo>.NativeClassPtr, 100663869);
			}

			// Token: 0x06003576 RID: 13686 RVA: 0x000DDB64 File Offset: 0x000DBD64
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 286583, RefRangeEnd = 286597, XrefRangeStart = 286583, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ContentHeightCacheInfo(float sum, int count)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>.ContentHeightCacheInfo>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref sum;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicHeightVirtualizationController<T>.ContentHeightCacheInfo.NativeMethodInfoPtr__ctor_Public_Void_Single_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003577 RID: 13687 RVA: 0x00015BDD File Offset: 0x00013DDD
			public ContentHeightCacheInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003578 RID: 13688 RVA: 0x00015BE6 File Offset: 0x00013DE6
			public ContentHeightCacheInfo()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicHeightVirtualizationController<T>.ContentHeightCacheInfo>.NativeClassPtr))
			{
			}

			// Token: 0x17001098 RID: 4248
			// (get) Token: 0x06003579 RID: 13689 RVA: 0x000DDBC0 File Offset: 0x000DBDC0
			// (set) Token: 0x0600357A RID: 13690 RVA: 0x00015BF8 File Offset: 0x00013DF8
			public unsafe float sum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.ContentHeightCacheInfo.NativeFieldInfoPtr_sum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.ContentHeightCacheInfo.NativeFieldInfoPtr_sum)) = value;
				}
			}

			// Token: 0x17001099 RID: 4249
			// (get) Token: 0x0600357B RID: 13691 RVA: 0x000DDBE8 File Offset: 0x000DBDE8
			// (set) Token: 0x0600357C RID: 13692 RVA: 0x00015C13 File Offset: 0x00013E13
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.ContentHeightCacheInfo.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicHeightVirtualizationController<T>.ContentHeightCacheInfo.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x04002666 RID: 9830
			private static readonly IntPtr NativeFieldInfoPtr_sum;

			// Token: 0x04002667 RID: 9831
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x04002668 RID: 9832
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Int32_0;
		}

		// Token: 0x0200032C RID: 812
		public enum VirtualizationChange
		{
			// Token: 0x0400266A RID: 9834
			None,
			// Token: 0x0400266B RID: 9835
			Resize,
			// Token: 0x0400266C RID: 9836
			Scroll,
			// Token: 0x0400266D RID: 9837
			ForcedScroll
		}

		// Token: 0x0200032D RID: 813
		public enum ScrollDirection
		{
			// Token: 0x0400266F RID: 9839
			Idle,
			// Token: 0x04002670 RID: 9840
			Up,
			// Token: 0x04002671 RID: 9841
			Down
		}
	}
}
