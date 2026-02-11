using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine;

namespace dbgclient.voodoo.layout
{
	// Token: 0x02000088 RID: 136
	public class FixedSlottedLayout : MonoBehaviour
	{
		// Token: 0x06000540 RID: 1344 RVA: 0x0002E200 File Offset: 0x0002C400
		// Note: this type is marked as 'beforefieldinit'.
		static FixedSlottedLayout()
		{
			Il2CppClassPointerStore<FixedSlottedLayout>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.voodoo.layout", "FixedSlottedLayout");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FixedSlottedLayout>.NativeClassPtr);
			FixedSlottedLayout.NativeFieldInfoPtr_slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedSlottedLayout>.NativeClassPtr, "slots");
			FixedSlottedLayout.NativeFieldInfoPtr_invalidSlotPile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedSlottedLayout>.NativeClassPtr, "invalidSlotPile");
			FixedSlottedLayout.NativeFieldInfoPtr_collapseEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedSlottedLayout>.NativeClassPtr, "collapseEmpty");
			FixedSlottedLayout.NativeFieldInfoPtr_emptyStandins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedSlottedLayout>.NativeClassPtr, "emptyStandins");
			FixedSlottedLayout.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedSlottedLayout>.NativeClassPtr, 100664102);
			FixedSlottedLayout.NativeMethodInfoPtr_Layout_Public_Virtual_Final_New_Void_List_1_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedSlottedLayout>.NativeClassPtr, 100664103);
			FixedSlottedLayout.NativeMethodInfoPtr_GetSlotFor_Public_Virtual_Final_New_Transform_UnitView_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedSlottedLayout>.NativeClassPtr, 100664104);
			FixedSlottedLayout.NativeMethodInfoPtr_OnViewsRemoved_Public_Virtual_Final_New_Void_List_1_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedSlottedLayout>.NativeClassPtr, 100664105);
			FixedSlottedLayout.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedSlottedLayout>.NativeClassPtr, 100664106);
			FixedSlottedLayout.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedSlottedLayout>.NativeClassPtr, 100664107);
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x0002E2F8 File Offset: 0x0002C4F8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixedSlottedLayout.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x0002E32C File Offset: 0x0002C52C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501625, XrefRangeEnd = 501661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Layout(List<UnitView> views)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(views);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixedSlottedLayout.NativeMethodInfoPtr_Layout_Public_Virtual_Final_New_Void_List_1_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x0002E370 File Offset: 0x0002C570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501661, XrefRangeEnd = 501668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixedSlottedLayout.NativeMethodInfoPtr_GetSlotFor_Public_Virtual_Final_New_Transform_UnitView_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x0002E3D0 File Offset: 0x0002C5D0
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixedSlottedLayout.NativeMethodInfoPtr_OnViewsRemoved_Public_Virtual_Final_New_Void_List_1_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x0002E414 File Offset: 0x0002C614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501668, XrefRangeEnd = 501685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixedSlottedLayout.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x0002E448 File Offset: 0x0002C648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501685, XrefRangeEnd = 501694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FixedSlottedLayout()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FixedSlottedLayout>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixedSlottedLayout.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x0000461B File Offset: 0x0000281B
		public FixedSlottedLayout(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000548 RID: 1352 RVA: 0x0002E484 File Offset: 0x0002C684
		// (set) Token: 0x06000549 RID: 1353 RVA: 0x00004624 File Offset: 0x00002824
		public unsafe Il2CppReferenceArray<Transform> slots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedSlottedLayout.NativeFieldInfoPtr_slots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedSlottedLayout.NativeFieldInfoPtr_slots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600054A RID: 1354 RVA: 0x0002E4B4 File Offset: 0x0002C6B4
		// (set) Token: 0x0600054B RID: 1355 RVA: 0x00004643 File Offset: 0x00002843
		public unsafe Transform invalidSlotPile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedSlottedLayout.NativeFieldInfoPtr_invalidSlotPile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedSlottedLayout.NativeFieldInfoPtr_invalidSlotPile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x0600054C RID: 1356 RVA: 0x0002E4E4 File Offset: 0x0002C6E4
		// (set) Token: 0x0600054D RID: 1357 RVA: 0x00004662 File Offset: 0x00002862
		public unsafe bool collapseEmpty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedSlottedLayout.NativeFieldInfoPtr_collapseEmpty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedSlottedLayout.NativeFieldInfoPtr_collapseEmpty)) = value;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x0600054E RID: 1358 RVA: 0x0002E50C File Offset: 0x0002C70C
		// (set) Token: 0x0600054F RID: 1359 RVA: 0x0000467D File Offset: 0x0000287D
		public unsafe Il2CppReferenceArray<GameObject> emptyStandins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedSlottedLayout.NativeFieldInfoPtr_emptyStandins);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedSlottedLayout.NativeFieldInfoPtr_emptyStandins), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400033B RID: 827
		private static readonly IntPtr NativeFieldInfoPtr_slots;

		// Token: 0x0400033C RID: 828
		private static readonly IntPtr NativeFieldInfoPtr_invalidSlotPile;

		// Token: 0x0400033D RID: 829
		private static readonly IntPtr NativeFieldInfoPtr_collapseEmpty;

		// Token: 0x0400033E RID: 830
		private static readonly IntPtr NativeFieldInfoPtr_emptyStandins;

		// Token: 0x0400033F RID: 831
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000340 RID: 832
		private static readonly IntPtr NativeMethodInfoPtr_Layout_Public_Virtual_Final_New_Void_List_1_UnitView_0;

		// Token: 0x04000341 RID: 833
		private static readonly IntPtr NativeMethodInfoPtr_GetSlotFor_Public_Virtual_Final_New_Transform_UnitView_Int32_0;

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeMethodInfoPtr_OnViewsRemoved_Public_Virtual_Final_New_Void_List_1_UnitView_0;

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04000344 RID: 836
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
