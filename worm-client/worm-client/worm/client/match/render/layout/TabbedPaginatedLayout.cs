using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine;
using UnityEngine.UI;

namespace worm.client.match.render.layout
{
	// Token: 0x020002A5 RID: 677
	public class TabbedPaginatedLayout : MonoBehaviour
	{
		// Token: 0x06001B77 RID: 7031 RVA: 0x0006C860 File Offset: 0x0006AA60
		// Note: this type is marked as 'beforefieldinit'.
		static TabbedPaginatedLayout()
		{
			Il2CppClassPointerStore<TabbedPaginatedLayout>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.client.match.render.layout", "TabbedPaginatedLayout");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TabbedPaginatedLayout>.NativeClassPtr);
			TabbedPaginatedLayout.NativeFieldInfoPtr_slotPrototype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabbedPaginatedLayout>.NativeClassPtr, "slotPrototype");
			TabbedPaginatedLayout.NativeFieldInfoPtr_reverse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabbedPaginatedLayout>.NativeClassPtr, "reverse");
			TabbedPaginatedLayout.NativeFieldInfoPtr_hideSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabbedPaginatedLayout>.NativeClassPtr, "hideSlots");
			TabbedPaginatedLayout.NativeFieldInfoPtr_countPerPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabbedPaginatedLayout>.NativeClassPtr, "countPerPage");
			TabbedPaginatedLayout.NativeFieldInfoPtr_tabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabbedPaginatedLayout>.NativeClassPtr, "tabs");
			TabbedPaginatedLayout.NativeFieldInfoPtr_views = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabbedPaginatedLayout>.NativeClassPtr, "views");
			TabbedPaginatedLayout.NativeFieldInfoPtr_tabViews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabbedPaginatedLayout>.NativeClassPtr, "tabViews");
			TabbedPaginatedLayout.NativeFieldInfoPtr_currentPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabbedPaginatedLayout>.NativeClassPtr, "currentPage");
			TabbedPaginatedLayout.NativeFieldInfoPtr__Version_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabbedPaginatedLayout>.NativeClassPtr, "<Version>k__BackingField");
			TabbedPaginatedLayout.NativeFieldInfoPtr_currentPile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabbedPaginatedLayout>.NativeClassPtr, "currentPile");
			TabbedPaginatedLayout.NativeFieldInfoPtr_pileView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabbedPaginatedLayout>.NativeClassPtr, "pileView");
			TabbedPaginatedLayout.NativeFieldInfoPtr_slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabbedPaginatedLayout>.NativeClassPtr, "slots");
			TabbedPaginatedLayout.NativeMethodInfoPtr_get_StartingIndex_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabbedPaginatedLayout>.NativeClassPtr, 100667302);
			TabbedPaginatedLayout.NativeMethodInfoPtr_get_EndingIndex_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabbedPaginatedLayout>.NativeClassPtr, 100667303);
			TabbedPaginatedLayout.NativeMethodInfoPtr_get_PagesLength_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabbedPaginatedLayout>.NativeClassPtr, 100667304);
			TabbedPaginatedLayout.NativeMethodInfoPtr_get_CanDecrementDisplay_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabbedPaginatedLayout>.NativeClassPtr, 100667305);
			TabbedPaginatedLayout.NativeMethodInfoPtr_get_CanIncrementDisplay_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabbedPaginatedLayout>.NativeClassPtr, 100667306);
			TabbedPaginatedLayout.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabbedPaginatedLayout>.NativeClassPtr, 100667307);
			TabbedPaginatedLayout.NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabbedPaginatedLayout>.NativeClassPtr, 100667308);
			TabbedPaginatedLayout.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabbedPaginatedLayout>.NativeClassPtr, 100667309);
			TabbedPaginatedLayout.NativeMethodInfoPtr_Event_DecrementDisplay_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabbedPaginatedLayout>.NativeClassPtr, 100667310);
			TabbedPaginatedLayout.NativeMethodInfoPtr_Event_IncrementDisplay_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabbedPaginatedLayout>.NativeClassPtr, 100667311);
			TabbedPaginatedLayout.NativeMethodInfoPtr_CanShowPile_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabbedPaginatedLayout>.NativeClassPtr, 100667312);
			TabbedPaginatedLayout.NativeMethodInfoPtr_Event_ShowPile_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabbedPaginatedLayout>.NativeClassPtr, 100667313);
			TabbedPaginatedLayout.NativeMethodInfoPtr_Layout_Public_Virtual_Final_New_Void_List_1_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabbedPaginatedLayout>.NativeClassPtr, 100667314);
			TabbedPaginatedLayout.NativeMethodInfoPtr_UpdatePosition_Public_Void_UnitView_UnitPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabbedPaginatedLayout>.NativeClassPtr, 100667315);
			TabbedPaginatedLayout.NativeMethodInfoPtr_GetSlotFor_Public_Virtual_Final_New_Transform_UnitView_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabbedPaginatedLayout>.NativeClassPtr, 100667316);
			TabbedPaginatedLayout.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabbedPaginatedLayout>.NativeClassPtr, 100667317);
			TabbedPaginatedLayout.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabbedPaginatedLayout>.NativeClassPtr, 100667318);
			TabbedPaginatedLayout.NativeMethodInfoPtr__Layout_b__31_0_Private_Boolean_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabbedPaginatedLayout>.NativeClassPtr, 100667319);
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06001B78 RID: 7032 RVA: 0x0006CAE8 File Offset: 0x0006ACE8
		public unsafe int StartingIndex
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 724950, RefRangeEnd = 724956, XrefRangeStart = 724944, XrefRangeEnd = 724950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabbedPaginatedLayout.NativeMethodInfoPtr_get_StartingIndex_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06001B79 RID: 7033 RVA: 0x0006CB24 File Offset: 0x0006AD24
		public unsafe int EndingIndex
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724956, XrefRangeEnd = 724963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabbedPaginatedLayout.NativeMethodInfoPtr_get_EndingIndex_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06001B7A RID: 7034 RVA: 0x0006CB60 File Offset: 0x0006AD60
		public unsafe int PagesLength
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 724968, RefRangeEnd = 724973, XrefRangeStart = 724963, XrefRangeEnd = 724968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabbedPaginatedLayout.NativeMethodInfoPtr_get_PagesLength_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06001B7B RID: 7035 RVA: 0x0006CB9C File Offset: 0x0006AD9C
		public unsafe virtual bool CanDecrementDisplay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabbedPaginatedLayout.NativeMethodInfoPtr_get_CanDecrementDisplay_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06001B7C RID: 7036 RVA: 0x0006CBD8 File Offset: 0x0006ADD8
		public unsafe virtual bool CanIncrementDisplay
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724973, XrefRangeEnd = 724974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabbedPaginatedLayout.NativeMethodInfoPtr_get_CanIncrementDisplay_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x06001B7D RID: 7037 RVA: 0x0006CC14 File Offset: 0x0006AE14
		// (set) Token: 0x06001B7E RID: 7038 RVA: 0x0006CC50 File Offset: 0x0006AE50
		public unsafe virtual ulong Version
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabbedPaginatedLayout.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabbedPaginatedLayout.NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001B7F RID: 7039 RVA: 0x0006CC90 File Offset: 0x0006AE90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724974, XrefRangeEnd = 724978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabbedPaginatedLayout.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x0006CCC4 File Offset: 0x0006AEC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724978, XrefRangeEnd = 724979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Event_DecrementDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabbedPaginatedLayout.NativeMethodInfoPtr_Event_DecrementDisplay_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B81 RID: 7041 RVA: 0x0006CCF8 File Offset: 0x0006AEF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724979, XrefRangeEnd = 724982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Event_IncrementDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabbedPaginatedLayout.NativeMethodInfoPtr_Event_IncrementDisplay_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x0006CD2C File Offset: 0x0006AF2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 724997, RefRangeEnd = 724999, XrefRangeStart = 724982, XrefRangeEnd = 724997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanShowPile(string pile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pile);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabbedPaginatedLayout.NativeMethodInfoPtr_CanShowPile_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x0006CD7C File Offset: 0x0006AF7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724999, XrefRangeEnd = 725019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ShowPile(string pile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pile);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabbedPaginatedLayout.NativeMethodInfoPtr_Event_ShowPile_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B84 RID: 7044 RVA: 0x0006CDC0 File Offset: 0x0006AFC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725019, XrefRangeEnd = 725135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Layout(List<UnitView> newViews)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newViews);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabbedPaginatedLayout.NativeMethodInfoPtr_Layout_Public_Virtual_Final_New_Void_List_1_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x0006CE04 File Offset: 0x0006B004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725135, XrefRangeEnd = 725156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePosition(UnitView view, UnitPosition position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(position);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabbedPaginatedLayout.NativeMethodInfoPtr_UpdatePosition_Public_Void_UnitView_UnitPosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x0006CE58 File Offset: 0x0006B058
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 725175, RefRangeEnd = 725176, XrefRangeStart = 725156, XrefRangeEnd = 725175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Transform GetSlotFor(UnitView view, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabbedPaginatedLayout.NativeMethodInfoPtr_GetSlotFor_Public_Virtual_Final_New_Transform_UnitView_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x0006CEB8 File Offset: 0x0006B0B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725176, XrefRangeEnd = 725203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabbedPaginatedLayout.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x0006CEEC File Offset: 0x0006B0EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725203, XrefRangeEnd = 725230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TabbedPaginatedLayout()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TabbedPaginatedLayout>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabbedPaginatedLayout.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x0006CF28 File Offset: 0x0006B128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725230, XrefRangeEnd = 725235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Layout_b__31_0(UnitView view)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabbedPaginatedLayout.NativeMethodInfoPtr__Layout_b__31_0_Private_Boolean_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x0000FDE1 File Offset: 0x0000DFE1
		public TabbedPaginatedLayout(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06001B8B RID: 7051 RVA: 0x0006CF78 File Offset: 0x0006B178
		// (set) Token: 0x06001B8C RID: 7052 RVA: 0x0000FDEA File Offset: 0x0000DFEA
		public unsafe Transform slotPrototype
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabbedPaginatedLayout.NativeFieldInfoPtr_slotPrototype);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabbedPaginatedLayout.NativeFieldInfoPtr_slotPrototype), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06001B8D RID: 7053 RVA: 0x0006CFA8 File Offset: 0x0006B1A8
		// (set) Token: 0x06001B8E RID: 7054 RVA: 0x0000FE09 File Offset: 0x0000E009
		public unsafe bool reverse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabbedPaginatedLayout.NativeFieldInfoPtr_reverse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabbedPaginatedLayout.NativeFieldInfoPtr_reverse)) = value;
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06001B8F RID: 7055 RVA: 0x0006CFD0 File Offset: 0x0006B1D0
		// (set) Token: 0x06001B90 RID: 7056 RVA: 0x0000FE24 File Offset: 0x0000E024
		public unsafe bool hideSlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabbedPaginatedLayout.NativeFieldInfoPtr_hideSlots);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabbedPaginatedLayout.NativeFieldInfoPtr_hideSlots)) = value;
			}
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06001B91 RID: 7057 RVA: 0x0006CFF8 File Offset: 0x0006B1F8
		// (set) Token: 0x06001B92 RID: 7058 RVA: 0x0000FE3F File Offset: 0x0000E03F
		public unsafe int countPerPage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabbedPaginatedLayout.NativeFieldInfoPtr_countPerPage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabbedPaginatedLayout.NativeFieldInfoPtr_countPerPage)) = value;
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06001B93 RID: 7059 RVA: 0x0006D020 File Offset: 0x0006B220
		// (set) Token: 0x06001B94 RID: 7060 RVA: 0x0000FE5A File Offset: 0x0000E05A
		public unsafe List<TabbedPaginatedLayout.Tab> tabs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabbedPaginatedLayout.NativeFieldInfoPtr_tabs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TabbedPaginatedLayout.Tab>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabbedPaginatedLayout.NativeFieldInfoPtr_tabs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06001B95 RID: 7061 RVA: 0x0006D050 File Offset: 0x0006B250
		// (set) Token: 0x06001B96 RID: 7062 RVA: 0x0000FE79 File Offset: 0x0000E079
		public unsafe List<UnitView> views
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabbedPaginatedLayout.NativeFieldInfoPtr_views);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UnitView>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabbedPaginatedLayout.NativeFieldInfoPtr_views), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06001B97 RID: 7063 RVA: 0x0006D080 File Offset: 0x0006B280
		// (set) Token: 0x06001B98 RID: 7064 RVA: 0x0000FE98 File Offset: 0x0000E098
		public unsafe List<UnitView> tabViews
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabbedPaginatedLayout.NativeFieldInfoPtr_tabViews);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UnitView>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabbedPaginatedLayout.NativeFieldInfoPtr_tabViews), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06001B99 RID: 7065 RVA: 0x0006D0B0 File Offset: 0x0006B2B0
		// (set) Token: 0x06001B9A RID: 7066 RVA: 0x0000FEB7 File Offset: 0x0000E0B7
		public unsafe int currentPage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabbedPaginatedLayout.NativeFieldInfoPtr_currentPage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabbedPaginatedLayout.NativeFieldInfoPtr_currentPage)) = value;
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06001B9B RID: 7067 RVA: 0x0006D0D8 File Offset: 0x0006B2D8
		// (set) Token: 0x06001B9C RID: 7068 RVA: 0x0000FED2 File Offset: 0x0000E0D2
		public unsafe ulong _Version_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabbedPaginatedLayout.NativeFieldInfoPtr__Version_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabbedPaginatedLayout.NativeFieldInfoPtr__Version_k__BackingField)) = value;
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x06001B9D RID: 7069 RVA: 0x0006D100 File Offset: 0x0006B300
		// (set) Token: 0x06001B9E RID: 7070 RVA: 0x0000FEED File Offset: 0x0000E0ED
		public unsafe string currentPile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabbedPaginatedLayout.NativeFieldInfoPtr_currentPile);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabbedPaginatedLayout.NativeFieldInfoPtr_currentPile), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06001B9F RID: 7071 RVA: 0x0006D128 File Offset: 0x0006B328
		// (set) Token: 0x06001BA0 RID: 7072 RVA: 0x0000FF0C File Offset: 0x0000E10C
		public unsafe LayoutPileView pileView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabbedPaginatedLayout.NativeFieldInfoPtr_pileView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LayoutPileView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabbedPaginatedLayout.NativeFieldInfoPtr_pileView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06001BA1 RID: 7073 RVA: 0x0006D158 File Offset: 0x0006B358
		// (set) Token: 0x06001BA2 RID: 7074 RVA: 0x0000FF2B File Offset: 0x0000E12B
		public unsafe List<Transform> slots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabbedPaginatedLayout.NativeFieldInfoPtr_slots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabbedPaginatedLayout.NativeFieldInfoPtr_slots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FD8 RID: 4056
		private static readonly IntPtr NativeFieldInfoPtr_slotPrototype;

		// Token: 0x04000FD9 RID: 4057
		private static readonly IntPtr NativeFieldInfoPtr_reverse;

		// Token: 0x04000FDA RID: 4058
		private static readonly IntPtr NativeFieldInfoPtr_hideSlots;

		// Token: 0x04000FDB RID: 4059
		private static readonly IntPtr NativeFieldInfoPtr_countPerPage;

		// Token: 0x04000FDC RID: 4060
		private static readonly IntPtr NativeFieldInfoPtr_tabs;

		// Token: 0x04000FDD RID: 4061
		private static readonly IntPtr NativeFieldInfoPtr_views;

		// Token: 0x04000FDE RID: 4062
		private static readonly IntPtr NativeFieldInfoPtr_tabViews;

		// Token: 0x04000FDF RID: 4063
		private static readonly IntPtr NativeFieldInfoPtr_currentPage;

		// Token: 0x04000FE0 RID: 4064
		private static readonly IntPtr NativeFieldInfoPtr__Version_k__BackingField;

		// Token: 0x04000FE1 RID: 4065
		private static readonly IntPtr NativeFieldInfoPtr_currentPile;

		// Token: 0x04000FE2 RID: 4066
		private static readonly IntPtr NativeFieldInfoPtr_pileView;

		// Token: 0x04000FE3 RID: 4067
		private static readonly IntPtr NativeFieldInfoPtr_slots;

		// Token: 0x04000FE4 RID: 4068
		private static readonly IntPtr NativeMethodInfoPtr_get_StartingIndex_Private_get_Int32_0;

		// Token: 0x04000FE5 RID: 4069
		private static readonly IntPtr NativeMethodInfoPtr_get_EndingIndex_Private_get_Int32_0;

		// Token: 0x04000FE6 RID: 4070
		private static readonly IntPtr NativeMethodInfoPtr_get_PagesLength_Private_get_Int32_0;

		// Token: 0x04000FE7 RID: 4071
		private static readonly IntPtr NativeMethodInfoPtr_get_CanDecrementDisplay_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000FE8 RID: 4072
		private static readonly IntPtr NativeMethodInfoPtr_get_CanIncrementDisplay_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000FE9 RID: 4073
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

		// Token: 0x04000FEA RID: 4074
		private static readonly IntPtr NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0;

		// Token: 0x04000FEB RID: 4075
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000FEC RID: 4076
		private static readonly IntPtr NativeMethodInfoPtr_Event_DecrementDisplay_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000FED RID: 4077
		private static readonly IntPtr NativeMethodInfoPtr_Event_IncrementDisplay_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000FEE RID: 4078
		private static readonly IntPtr NativeMethodInfoPtr_CanShowPile_Private_Boolean_String_0;

		// Token: 0x04000FEF RID: 4079
		private static readonly IntPtr NativeMethodInfoPtr_Event_ShowPile_Public_Void_String_0;

		// Token: 0x04000FF0 RID: 4080
		private static readonly IntPtr NativeMethodInfoPtr_Layout_Public_Virtual_Final_New_Void_List_1_UnitView_0;

		// Token: 0x04000FF1 RID: 4081
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePosition_Public_Void_UnitView_UnitPosition_0;

		// Token: 0x04000FF2 RID: 4082
		private static readonly IntPtr NativeMethodInfoPtr_GetSlotFor_Public_Virtual_Final_New_Transform_UnitView_Int32_0;

		// Token: 0x04000FF3 RID: 4083
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04000FF4 RID: 4084
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000FF5 RID: 4085
		private static readonly IntPtr NativeMethodInfoPtr__Layout_b__31_0_Private_Boolean_UnitView_0;

		// Token: 0x02000441 RID: 1089
		[Serializable]
		public sealed class Tab : ValueType
		{
			// Token: 0x06002D45 RID: 11589 RVA: 0x000A1458 File Offset: 0x0009F658
			// Note: this type is marked as 'beforefieldinit'.
			static Tab()
			{
				Il2CppClassPointerStore<TabbedPaginatedLayout.Tab>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TabbedPaginatedLayout>.NativeClassPtr, "Tab");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TabbedPaginatedLayout.Tab>.NativeClassPtr);
				TabbedPaginatedLayout.Tab.NativeFieldInfoPtr_pileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabbedPaginatedLayout.Tab>.NativeClassPtr, "pileName");
				TabbedPaginatedLayout.Tab.NativeFieldInfoPtr_toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabbedPaginatedLayout.Tab>.NativeClassPtr, "toggle");
			}

			// Token: 0x06002D46 RID: 11590 RVA: 0x00018892 File Offset: 0x00016A92
			public Tab(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002D47 RID: 11591 RVA: 0x0001889B File Offset: 0x00016A9B
			public Tab()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TabbedPaginatedLayout.Tab>.NativeClassPtr))
			{
			}

			// Token: 0x17000CFF RID: 3327
			// (get) Token: 0x06002D48 RID: 11592 RVA: 0x000A14AC File Offset: 0x0009F6AC
			// (set) Token: 0x06002D49 RID: 11593 RVA: 0x000188AD File Offset: 0x00016AAD
			public unsafe string pileName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabbedPaginatedLayout.Tab.NativeFieldInfoPtr_pileName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabbedPaginatedLayout.Tab.NativeFieldInfoPtr_pileName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000D00 RID: 3328
			// (get) Token: 0x06002D4A RID: 11594 RVA: 0x000A14D4 File Offset: 0x0009F6D4
			// (set) Token: 0x06002D4B RID: 11595 RVA: 0x000188CC File Offset: 0x00016ACC
			public unsafe Toggle toggle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabbedPaginatedLayout.Tab.NativeFieldInfoPtr_toggle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabbedPaginatedLayout.Tab.NativeFieldInfoPtr_toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001A53 RID: 6739
			private static readonly IntPtr NativeFieldInfoPtr_pileName;

			// Token: 0x04001A54 RID: 6740
			private static readonly IntPtr NativeFieldInfoPtr_toggle;
		}

		// Token: 0x02000442 RID: 1090
		[ObfuscatedName("worm.client.match.render.layout.TabbedPaginatedLayout+<>c__DisplayClass29_0")]
		public sealed class __c__DisplayClass29_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002D4C RID: 11596 RVA: 0x000A1504 File Offset: 0x0009F704
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_0()
			{
				Il2CppClassPointerStore<TabbedPaginatedLayout.__c__DisplayClass29_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TabbedPaginatedLayout>.NativeClassPtr, "<>c__DisplayClass29_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TabbedPaginatedLayout.__c__DisplayClass29_0>.NativeClassPtr);
				TabbedPaginatedLayout.__c__DisplayClass29_0.NativeFieldInfoPtr_pile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabbedPaginatedLayout.__c__DisplayClass29_0>.NativeClassPtr, "pile");
				TabbedPaginatedLayout.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabbedPaginatedLayout.__c__DisplayClass29_0>.NativeClassPtr, 100667320);
				TabbedPaginatedLayout.__c__DisplayClass29_0.NativeMethodInfoPtr__CanShowPile_b__0_Internal_Boolean_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabbedPaginatedLayout.__c__DisplayClass29_0>.NativeClassPtr, 100667321);
			}

			// Token: 0x06002D4D RID: 11597 RVA: 0x000A156C File Offset: 0x0009F76C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TabbedPaginatedLayout.__c__DisplayClass29_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabbedPaginatedLayout.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D4E RID: 11598 RVA: 0x000A15A8 File Offset: 0x0009F7A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724933, XrefRangeEnd = 724938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CanShowPile_b__0(UnitView view)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabbedPaginatedLayout.__c__DisplayClass29_0.NativeMethodInfoPtr__CanShowPile_b__0_Internal_Boolean_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002D4F RID: 11599 RVA: 0x000188EB File Offset: 0x00016AEB
			public __c__DisplayClass29_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D01 RID: 3329
			// (get) Token: 0x06002D50 RID: 11600 RVA: 0x000A15F8 File Offset: 0x0009F7F8
			// (set) Token: 0x06002D51 RID: 11601 RVA: 0x000188F4 File Offset: 0x00016AF4
			public unsafe string pile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabbedPaginatedLayout.__c__DisplayClass29_0.NativeFieldInfoPtr_pile);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabbedPaginatedLayout.__c__DisplayClass29_0.NativeFieldInfoPtr_pile), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04001A55 RID: 6741
			private static readonly IntPtr NativeFieldInfoPtr_pile;

			// Token: 0x04001A56 RID: 6742
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001A57 RID: 6743
			private static readonly IntPtr NativeMethodInfoPtr__CanShowPile_b__0_Internal_Boolean_UnitView_0;
		}

		// Token: 0x02000443 RID: 1091
		[ObfuscatedName("worm.client.match.render.layout.TabbedPaginatedLayout+<>c__DisplayClass30_0")]
		public sealed class __c__DisplayClass30_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002D52 RID: 11602 RVA: 0x000A1620 File Offset: 0x0009F820
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass30_0()
			{
				Il2CppClassPointerStore<TabbedPaginatedLayout.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TabbedPaginatedLayout>.NativeClassPtr, "<>c__DisplayClass30_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TabbedPaginatedLayout.__c__DisplayClass30_0>.NativeClassPtr);
				TabbedPaginatedLayout.__c__DisplayClass30_0.NativeFieldInfoPtr_pile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabbedPaginatedLayout.__c__DisplayClass30_0>.NativeClassPtr, "pile");
				TabbedPaginatedLayout.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabbedPaginatedLayout.__c__DisplayClass30_0>.NativeClassPtr, 100667322);
				TabbedPaginatedLayout.__c__DisplayClass30_0.NativeMethodInfoPtr__Event_ShowPile_b__0_Internal_Boolean_Tab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabbedPaginatedLayout.__c__DisplayClass30_0>.NativeClassPtr, 100667323);
			}

			// Token: 0x06002D53 RID: 11603 RVA: 0x000A1688 File Offset: 0x0009F888
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass30_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TabbedPaginatedLayout.__c__DisplayClass30_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabbedPaginatedLayout.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D54 RID: 11604 RVA: 0x000A16C4 File Offset: 0x0009F8C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724938, XrefRangeEnd = 724939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Event_ShowPile_b__0(TabbedPaginatedLayout.Tab tab)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tab));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabbedPaginatedLayout.__c__DisplayClass30_0.NativeMethodInfoPtr__Event_ShowPile_b__0_Internal_Boolean_Tab_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002D55 RID: 11605 RVA: 0x00018913 File Offset: 0x00016B13
			public __c__DisplayClass30_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D02 RID: 3330
			// (get) Token: 0x06002D56 RID: 11606 RVA: 0x000A1718 File Offset: 0x0009F918
			// (set) Token: 0x06002D57 RID: 11607 RVA: 0x0001891C File Offset: 0x00016B1C
			public unsafe string pile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabbedPaginatedLayout.__c__DisplayClass30_0.NativeFieldInfoPtr_pile);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabbedPaginatedLayout.__c__DisplayClass30_0.NativeFieldInfoPtr_pile), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04001A58 RID: 6744
			private static readonly IntPtr NativeFieldInfoPtr_pile;

			// Token: 0x04001A59 RID: 6745
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001A5A RID: 6746
			private static readonly IntPtr NativeMethodInfoPtr__Event_ShowPile_b__0_Internal_Boolean_Tab_0;
		}

		// Token: 0x02000444 RID: 1092
		[ObfuscatedName("worm.client.match.render.layout.TabbedPaginatedLayout+<>c__DisplayClass31_0")]
		public sealed class __c__DisplayClass31_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002D58 RID: 11608 RVA: 0x000A1740 File Offset: 0x0009F940
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass31_0()
			{
				Il2CppClassPointerStore<TabbedPaginatedLayout.__c__DisplayClass31_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TabbedPaginatedLayout>.NativeClassPtr, "<>c__DisplayClass31_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TabbedPaginatedLayout.__c__DisplayClass31_0>.NativeClassPtr);
				TabbedPaginatedLayout.__c__DisplayClass31_0.NativeFieldInfoPtr_tab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabbedPaginatedLayout.__c__DisplayClass31_0>.NativeClassPtr, "tab");
				TabbedPaginatedLayout.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabbedPaginatedLayout.__c__DisplayClass31_0>.NativeClassPtr, 100667324);
				TabbedPaginatedLayout.__c__DisplayClass31_0.NativeMethodInfoPtr__Layout_b__1_Internal_Boolean_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabbedPaginatedLayout.__c__DisplayClass31_0>.NativeClassPtr, 100667325);
			}

			// Token: 0x06002D59 RID: 11609 RVA: 0x000A17A8 File Offset: 0x0009F9A8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass31_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TabbedPaginatedLayout.__c__DisplayClass31_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabbedPaginatedLayout.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D5A RID: 11610 RVA: 0x000A17E4 File Offset: 0x0009F9E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724939, XrefRangeEnd = 724944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Layout_b__1(UnitView view)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabbedPaginatedLayout.__c__DisplayClass31_0.NativeMethodInfoPtr__Layout_b__1_Internal_Boolean_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002D5B RID: 11611 RVA: 0x0001893B File Offset: 0x00016B3B
			public __c__DisplayClass31_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D03 RID: 3331
			// (get) Token: 0x06002D5C RID: 11612 RVA: 0x000A1834 File Offset: 0x0009FA34
			// (set) Token: 0x06002D5D RID: 11613 RVA: 0x00018944 File Offset: 0x00016B44
			public TabbedPaginatedLayout.Tab tab
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabbedPaginatedLayout.__c__DisplayClass31_0.NativeFieldInfoPtr_tab);
					return new TabbedPaginatedLayout.Tab(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TabbedPaginatedLayout.Tab>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabbedPaginatedLayout.__c__DisplayClass31_0.NativeFieldInfoPtr_tab), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TabbedPaginatedLayout.Tab>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001A5B RID: 6747
			private static readonly IntPtr NativeFieldInfoPtr_tab;

			// Token: 0x04001A5C RID: 6748
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001A5D RID: 6749
			private static readonly IntPtr NativeMethodInfoPtr__Layout_b__1_Internal_Boolean_UnitView_0;
		}
	}
}
