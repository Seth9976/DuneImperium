using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine;

namespace boardgames.match.voodoo
{
	// Token: 0x020000A5 RID: 165
	public class OnDemandSlottedLayout : MonoBehaviour
	{
		// Token: 0x06000978 RID: 2424 RVA: 0x00028FCC File Offset: 0x000271CC
		// Note: this type is marked as 'beforefieldinit'.
		static OnDemandSlottedLayout()
		{
			Il2CppClassPointerStore<OnDemandSlottedLayout>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "boardgames.match.voodoo", "OnDemandSlottedLayout");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnDemandSlottedLayout>.NativeClassPtr);
			OnDemandSlottedLayout.NativeFieldInfoPtr_slotPrototype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDemandSlottedLayout>.NativeClassPtr, "slotPrototype");
			OnDemandSlottedLayout.NativeFieldInfoPtr_reverse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDemandSlottedLayout>.NativeClassPtr, "reverse");
			OnDemandSlottedLayout.NativeFieldInfoPtr_hideSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDemandSlottedLayout>.NativeClassPtr, "hideSlots");
			OnDemandSlottedLayout.NativeFieldInfoPtr_viewSiblingIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDemandSlottedLayout>.NativeClassPtr, "viewSiblingIndex");
			OnDemandSlottedLayout.NativeFieldInfoPtr_slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDemandSlottedLayout>.NativeClassPtr, "slots");
			OnDemandSlottedLayout.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDemandSlottedLayout>.NativeClassPtr, 100664672);
			OnDemandSlottedLayout.NativeMethodInfoPtr_Layout_Public_Virtual_Final_New_Void_List_1_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDemandSlottedLayout>.NativeClassPtr, 100664673);
			OnDemandSlottedLayout.NativeMethodInfoPtr_GetSlotFor_Public_Virtual_Final_New_Transform_UnitView_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDemandSlottedLayout>.NativeClassPtr, 100664674);
			OnDemandSlottedLayout.NativeMethodInfoPtr_OnViewsRemoved_Public_Virtual_Final_New_Void_List_1_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDemandSlottedLayout>.NativeClassPtr, 100664675);
			OnDemandSlottedLayout.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDemandSlottedLayout>.NativeClassPtr, 100664676);
			OnDemandSlottedLayout.NativeMethodInfoPtr_preLayout_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDemandSlottedLayout>.NativeClassPtr, 100664677);
			OnDemandSlottedLayout.NativeMethodInfoPtr_postLayout_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDemandSlottedLayout>.NativeClassPtr, 100664678);
			OnDemandSlottedLayout.NativeMethodInfoPtr_getSlotPrototype_Protected_Virtual_New_Transform_EntityView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDemandSlottedLayout>.NativeClassPtr, 100664679);
			OnDemandSlottedLayout.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDemandSlottedLayout>.NativeClassPtr, 100664680);
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x00029114 File Offset: 0x00027314
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnDemandSlottedLayout.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x00029148 File Offset: 0x00027348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117441, XrefRangeEnd = 1117511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Layout(List<UnitView> views)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(views);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnDemandSlottedLayout.NativeMethodInfoPtr_Layout_Public_Virtual_Final_New_Void_List_1_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x0002918C File Offset: 0x0002738C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117511, XrefRangeEnd = 1117531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnDemandSlottedLayout.NativeMethodInfoPtr_GetSlotFor_Public_Virtual_Final_New_Transform_UnitView_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x000291EC File Offset: 0x000273EC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnViewsRemoved(List<UnitView> views)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(views);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnDemandSlottedLayout.NativeMethodInfoPtr_OnViewsRemoved_Public_Virtual_Final_New_Void_List_1_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x00029230 File Offset: 0x00027430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117531, XrefRangeEnd = 1117558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnDemandSlottedLayout.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x00029264 File Offset: 0x00027464
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void preLayout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OnDemandSlottedLayout.NativeMethodInfoPtr_preLayout_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x000292A0 File Offset: 0x000274A0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void postLayout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OnDemandSlottedLayout.NativeMethodInfoPtr_postLayout_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x000292DC File Offset: 0x000274DC
		[CallerCount(0)]
		public unsafe virtual Transform getSlotPrototype(EntityView view)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OnDemandSlottedLayout.NativeMethodInfoPtr_getSlotPrototype_Protected_Virtual_New_Transform_EntityView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x00029338 File Offset: 0x00027538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117558, XrefRangeEnd = 1117566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnDemandSlottedLayout()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnDemandSlottedLayout>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnDemandSlottedLayout.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x00006984 File Offset: 0x00004B84
		public OnDemandSlottedLayout(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000983 RID: 2435 RVA: 0x00029374 File Offset: 0x00027574
		// (set) Token: 0x06000984 RID: 2436 RVA: 0x0000698D File Offset: 0x00004B8D
		public unsafe Transform slotPrototype
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnDemandSlottedLayout.NativeFieldInfoPtr_slotPrototype);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnDemandSlottedLayout.NativeFieldInfoPtr_slotPrototype), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000985 RID: 2437 RVA: 0x000293A4 File Offset: 0x000275A4
		// (set) Token: 0x06000986 RID: 2438 RVA: 0x000069AC File Offset: 0x00004BAC
		public unsafe bool reverse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnDemandSlottedLayout.NativeFieldInfoPtr_reverse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnDemandSlottedLayout.NativeFieldInfoPtr_reverse)) = value;
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000987 RID: 2439 RVA: 0x000293CC File Offset: 0x000275CC
		// (set) Token: 0x06000988 RID: 2440 RVA: 0x000069C7 File Offset: 0x00004BC7
		public unsafe bool hideSlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnDemandSlottedLayout.NativeFieldInfoPtr_hideSlots);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnDemandSlottedLayout.NativeFieldInfoPtr_hideSlots)) = value;
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000989 RID: 2441 RVA: 0x000293F4 File Offset: 0x000275F4
		// (set) Token: 0x0600098A RID: 2442 RVA: 0x000069E2 File Offset: 0x00004BE2
		public unsafe int viewSiblingIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnDemandSlottedLayout.NativeFieldInfoPtr_viewSiblingIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnDemandSlottedLayout.NativeFieldInfoPtr_viewSiblingIndex)) = value;
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x0600098B RID: 2443 RVA: 0x0002941C File Offset: 0x0002761C
		// (set) Token: 0x0600098C RID: 2444 RVA: 0x000069FD File Offset: 0x00004BFD
		public unsafe List<Transform> slots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnDemandSlottedLayout.NativeFieldInfoPtr_slots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnDemandSlottedLayout.NativeFieldInfoPtr_slots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005EA RID: 1514
		private static readonly IntPtr NativeFieldInfoPtr_slotPrototype;

		// Token: 0x040005EB RID: 1515
		private static readonly IntPtr NativeFieldInfoPtr_reverse;

		// Token: 0x040005EC RID: 1516
		private static readonly IntPtr NativeFieldInfoPtr_hideSlots;

		// Token: 0x040005ED RID: 1517
		private static readonly IntPtr NativeFieldInfoPtr_viewSiblingIndex;

		// Token: 0x040005EE RID: 1518
		private static readonly IntPtr NativeFieldInfoPtr_slots;

		// Token: 0x040005EF RID: 1519
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_0;

		// Token: 0x040005F0 RID: 1520
		private static readonly IntPtr NativeMethodInfoPtr_Layout_Public_Virtual_Final_New_Void_List_1_UnitView_0;

		// Token: 0x040005F1 RID: 1521
		private static readonly IntPtr NativeMethodInfoPtr_GetSlotFor_Public_Virtual_Final_New_Transform_UnitView_Int32_0;

		// Token: 0x040005F2 RID: 1522
		private static readonly IntPtr NativeMethodInfoPtr_OnViewsRemoved_Public_Virtual_Final_New_Void_List_1_UnitView_0;

		// Token: 0x040005F3 RID: 1523
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x040005F4 RID: 1524
		private static readonly IntPtr NativeMethodInfoPtr_preLayout_Protected_Virtual_New_Void_0;

		// Token: 0x040005F5 RID: 1525
		private static readonly IntPtr NativeMethodInfoPtr_postLayout_Protected_Virtual_New_Void_0;

		// Token: 0x040005F6 RID: 1526
		private static readonly IntPtr NativeMethodInfoPtr_getSlotPrototype_Protected_Virtual_New_Transform_EntityView_0;

		// Token: 0x040005F7 RID: 1527
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
