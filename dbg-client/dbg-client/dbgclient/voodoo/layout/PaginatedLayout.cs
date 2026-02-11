using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine;

namespace dbgclient.voodoo.layout
{
	// Token: 0x0200008A RID: 138
	public class PaginatedLayout : MonoBehaviour
	{
		// Token: 0x06000557 RID: 1367 RVA: 0x0002E728 File Offset: 0x0002C928
		// Note: this type is marked as 'beforefieldinit'.
		static PaginatedLayout()
		{
			Il2CppClassPointerStore<PaginatedLayout>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.voodoo.layout", "PaginatedLayout");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PaginatedLayout>.NativeClassPtr);
			PaginatedLayout.NativeFieldInfoPtr_slotPrototype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaginatedLayout>.NativeClassPtr, "slotPrototype");
			PaginatedLayout.NativeFieldInfoPtr_reverse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaginatedLayout>.NativeClassPtr, "reverse");
			PaginatedLayout.NativeFieldInfoPtr_hideSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaginatedLayout>.NativeClassPtr, "hideSlots");
			PaginatedLayout.NativeFieldInfoPtr_countPerPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaginatedLayout>.NativeClassPtr, "countPerPage");
			PaginatedLayout.NativeFieldInfoPtr_localViews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaginatedLayout>.NativeClassPtr, "localViews");
			PaginatedLayout.NativeFieldInfoPtr_currentPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaginatedLayout>.NativeClassPtr, "currentPage");
			PaginatedLayout.NativeFieldInfoPtr__Version_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaginatedLayout>.NativeClassPtr, "<Version>k__BackingField");
			PaginatedLayout.NativeFieldInfoPtr_slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaginatedLayout>.NativeClassPtr, "slots");
			PaginatedLayout.NativeMethodInfoPtr_get_StartingIndex_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaginatedLayout>.NativeClassPtr, 100664113);
			PaginatedLayout.NativeMethodInfoPtr_get_EndingIndex_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaginatedLayout>.NativeClassPtr, 100664114);
			PaginatedLayout.NativeMethodInfoPtr_get_PagesLength_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaginatedLayout>.NativeClassPtr, 100664115);
			PaginatedLayout.NativeMethodInfoPtr_get_CanDecrementDisplay_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaginatedLayout>.NativeClassPtr, 100664116);
			PaginatedLayout.NativeMethodInfoPtr_get_CanIncrementDisplay_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaginatedLayout>.NativeClassPtr, 100664117);
			PaginatedLayout.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaginatedLayout>.NativeClassPtr, 100664118);
			PaginatedLayout.NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaginatedLayout>.NativeClassPtr, 100664119);
			PaginatedLayout.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaginatedLayout>.NativeClassPtr, 100664120);
			PaginatedLayout.NativeMethodInfoPtr_Event_SetPage_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaginatedLayout>.NativeClassPtr, 100664121);
			PaginatedLayout.NativeMethodInfoPtr_Event_DecrementDisplay_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaginatedLayout>.NativeClassPtr, 100664122);
			PaginatedLayout.NativeMethodInfoPtr_Event_IncrementDisplay_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaginatedLayout>.NativeClassPtr, 100664123);
			PaginatedLayout.NativeMethodInfoPtr_UpdateVisibleSlots_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaginatedLayout>.NativeClassPtr, 100664124);
			PaginatedLayout.NativeMethodInfoPtr_Layout_Public_Virtual_Final_New_Void_List_1_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaginatedLayout>.NativeClassPtr, 100664125);
			PaginatedLayout.NativeMethodInfoPtr_GetSlotFor_Public_Virtual_Final_New_Transform_UnitView_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaginatedLayout>.NativeClassPtr, 100664126);
			PaginatedLayout.NativeMethodInfoPtr_OnViewsRemoved_Public_Virtual_Final_New_Void_List_1_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaginatedLayout>.NativeClassPtr, 100664127);
			PaginatedLayout.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaginatedLayout>.NativeClassPtr, 100664128);
			PaginatedLayout.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaginatedLayout>.NativeClassPtr, 100664129);
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000558 RID: 1368 RVA: 0x0002E94C File Offset: 0x0002CB4C
		public unsafe int StartingIndex
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 501724, RefRangeEnd = 501725, XrefRangeStart = 501718, XrefRangeEnd = 501724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PaginatedLayout.NativeMethodInfoPtr_get_StartingIndex_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000559 RID: 1369 RVA: 0x0002E988 File Offset: 0x0002CB88
		public unsafe int EndingIndex
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 501732, RefRangeEnd = 501733, XrefRangeStart = 501725, XrefRangeEnd = 501732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PaginatedLayout.NativeMethodInfoPtr_get_EndingIndex_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x0600055A RID: 1370 RVA: 0x0002E9C4 File Offset: 0x0002CBC4
		public unsafe int PagesLength
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 501738, RefRangeEnd = 501743, XrefRangeStart = 501733, XrefRangeEnd = 501738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PaginatedLayout.NativeMethodInfoPtr_get_PagesLength_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x0600055B RID: 1371 RVA: 0x0002EA00 File Offset: 0x0002CC00
		public unsafe virtual bool CanDecrementDisplay
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 501743, RefRangeEnd = 501744, XrefRangeStart = 501743, XrefRangeEnd = 501743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PaginatedLayout.NativeMethodInfoPtr_get_CanDecrementDisplay_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x0600055C RID: 1372 RVA: 0x0002EA3C File Offset: 0x0002CC3C
		public unsafe virtual bool CanIncrementDisplay
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501744, XrefRangeEnd = 501745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PaginatedLayout.NativeMethodInfoPtr_get_CanIncrementDisplay_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600055D RID: 1373 RVA: 0x0002EA78 File Offset: 0x0002CC78
		// (set) Token: 0x0600055E RID: 1374 RVA: 0x0002EAB4 File Offset: 0x0002CCB4
		public unsafe virtual ulong Version
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PaginatedLayout.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PaginatedLayout.NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x0002EAF4 File Offset: 0x0002CCF4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PaginatedLayout.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x0002EB28 File Offset: 0x0002CD28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 501746, RefRangeEnd = 501747, XrefRangeStart = 501745, XrefRangeEnd = 501746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SetPage(int page)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref page;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PaginatedLayout.NativeMethodInfoPtr_Event_SetPage_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x0002EB68 File Offset: 0x0002CD68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501747, XrefRangeEnd = 501749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Event_DecrementDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PaginatedLayout.NativeMethodInfoPtr_Event_DecrementDisplay_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x0002EB9C File Offset: 0x0002CD9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501749, XrefRangeEnd = 501753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Event_IncrementDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PaginatedLayout.NativeMethodInfoPtr_Event_IncrementDisplay_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x0002EBD0 File Offset: 0x0002CDD0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 501769, RefRangeEnd = 501773, XrefRangeStart = 501753, XrefRangeEnd = 501769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVisibleSlots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PaginatedLayout.NativeMethodInfoPtr_UpdateVisibleSlots_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x0002EC04 File Offset: 0x0002CE04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501773, XrefRangeEnd = 501825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Layout(List<UnitView> views)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(views);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PaginatedLayout.NativeMethodInfoPtr_Layout_Public_Virtual_Final_New_Void_List_1_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x0002EC48 File Offset: 0x0002CE48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501825, XrefRangeEnd = 501844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PaginatedLayout.NativeMethodInfoPtr_GetSlotFor_Public_Virtual_Final_New_Transform_UnitView_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x0002ECA8 File Offset: 0x0002CEA8
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PaginatedLayout.NativeMethodInfoPtr_OnViewsRemoved_Public_Virtual_Final_New_Void_List_1_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x0002ECEC File Offset: 0x0002CEEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501844, XrefRangeEnd = 501871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PaginatedLayout.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x0002ED20 File Offset: 0x0002CF20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501871, XrefRangeEnd = 501886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PaginatedLayout()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PaginatedLayout>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PaginatedLayout.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x000046A5 File Offset: 0x000028A5
		public PaginatedLayout(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x0002ED5C File Offset: 0x0002CF5C
		// (set) Token: 0x0600056B RID: 1387 RVA: 0x000046AE File Offset: 0x000028AE
		public unsafe Transform slotPrototype
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PaginatedLayout.NativeFieldInfoPtr_slotPrototype);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PaginatedLayout.NativeFieldInfoPtr_slotPrototype), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x0002ED8C File Offset: 0x0002CF8C
		// (set) Token: 0x0600056D RID: 1389 RVA: 0x000046CD File Offset: 0x000028CD
		public unsafe bool reverse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PaginatedLayout.NativeFieldInfoPtr_reverse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PaginatedLayout.NativeFieldInfoPtr_reverse)) = value;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x0002EDB4 File Offset: 0x0002CFB4
		// (set) Token: 0x0600056F RID: 1391 RVA: 0x000046E8 File Offset: 0x000028E8
		public unsafe bool hideSlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PaginatedLayout.NativeFieldInfoPtr_hideSlots);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PaginatedLayout.NativeFieldInfoPtr_hideSlots)) = value;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x0002EDDC File Offset: 0x0002CFDC
		// (set) Token: 0x06000571 RID: 1393 RVA: 0x00004703 File Offset: 0x00002903
		public unsafe int countPerPage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PaginatedLayout.NativeFieldInfoPtr_countPerPage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PaginatedLayout.NativeFieldInfoPtr_countPerPage)) = value;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000572 RID: 1394 RVA: 0x0002EE04 File Offset: 0x0002D004
		// (set) Token: 0x06000573 RID: 1395 RVA: 0x0000471E File Offset: 0x0000291E
		public unsafe List<UnitView> localViews
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PaginatedLayout.NativeFieldInfoPtr_localViews);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UnitView>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PaginatedLayout.NativeFieldInfoPtr_localViews), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000574 RID: 1396 RVA: 0x0002EE34 File Offset: 0x0002D034
		// (set) Token: 0x06000575 RID: 1397 RVA: 0x0000473D File Offset: 0x0000293D
		public unsafe int currentPage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PaginatedLayout.NativeFieldInfoPtr_currentPage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PaginatedLayout.NativeFieldInfoPtr_currentPage)) = value;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000576 RID: 1398 RVA: 0x0002EE5C File Offset: 0x0002D05C
		// (set) Token: 0x06000577 RID: 1399 RVA: 0x00004758 File Offset: 0x00002958
		public unsafe ulong _Version_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PaginatedLayout.NativeFieldInfoPtr__Version_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PaginatedLayout.NativeFieldInfoPtr__Version_k__BackingField)) = value;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000578 RID: 1400 RVA: 0x0002EE84 File Offset: 0x0002D084
		// (set) Token: 0x06000579 RID: 1401 RVA: 0x00004773 File Offset: 0x00002973
		public unsafe List<Transform> slots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PaginatedLayout.NativeFieldInfoPtr_slots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PaginatedLayout.NativeFieldInfoPtr_slots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400034A RID: 842
		private static readonly IntPtr NativeFieldInfoPtr_slotPrototype;

		// Token: 0x0400034B RID: 843
		private static readonly IntPtr NativeFieldInfoPtr_reverse;

		// Token: 0x0400034C RID: 844
		private static readonly IntPtr NativeFieldInfoPtr_hideSlots;

		// Token: 0x0400034D RID: 845
		private static readonly IntPtr NativeFieldInfoPtr_countPerPage;

		// Token: 0x0400034E RID: 846
		private static readonly IntPtr NativeFieldInfoPtr_localViews;

		// Token: 0x0400034F RID: 847
		private static readonly IntPtr NativeFieldInfoPtr_currentPage;

		// Token: 0x04000350 RID: 848
		private static readonly IntPtr NativeFieldInfoPtr__Version_k__BackingField;

		// Token: 0x04000351 RID: 849
		private static readonly IntPtr NativeFieldInfoPtr_slots;

		// Token: 0x04000352 RID: 850
		private static readonly IntPtr NativeMethodInfoPtr_get_StartingIndex_Private_get_Int32_0;

		// Token: 0x04000353 RID: 851
		private static readonly IntPtr NativeMethodInfoPtr_get_EndingIndex_Private_get_Int32_0;

		// Token: 0x04000354 RID: 852
		private static readonly IntPtr NativeMethodInfoPtr_get_PagesLength_Private_get_Int32_0;

		// Token: 0x04000355 RID: 853
		private static readonly IntPtr NativeMethodInfoPtr_get_CanDecrementDisplay_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000356 RID: 854
		private static readonly IntPtr NativeMethodInfoPtr_get_CanIncrementDisplay_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000357 RID: 855
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

		// Token: 0x04000358 RID: 856
		private static readonly IntPtr NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0;

		// Token: 0x04000359 RID: 857
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400035A RID: 858
		private static readonly IntPtr NativeMethodInfoPtr_Event_SetPage_Public_Void_Int32_0;

		// Token: 0x0400035B RID: 859
		private static readonly IntPtr NativeMethodInfoPtr_Event_DecrementDisplay_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400035C RID: 860
		private static readonly IntPtr NativeMethodInfoPtr_Event_IncrementDisplay_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400035D RID: 861
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisibleSlots_Private_Void_0;

		// Token: 0x0400035E RID: 862
		private static readonly IntPtr NativeMethodInfoPtr_Layout_Public_Virtual_Final_New_Void_List_1_UnitView_0;

		// Token: 0x0400035F RID: 863
		private static readonly IntPtr NativeMethodInfoPtr_GetSlotFor_Public_Virtual_Final_New_Transform_UnitView_Int32_0;

		// Token: 0x04000360 RID: 864
		private static readonly IntPtr NativeMethodInfoPtr_OnViewsRemoved_Public_Virtual_Final_New_Void_List_1_UnitView_0;

		// Token: 0x04000361 RID: 865
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04000362 RID: 866
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
