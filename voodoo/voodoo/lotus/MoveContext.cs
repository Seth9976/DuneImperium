using System;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using lib.voodoo.src.voodoo;

namespace lotus
{
	// Token: 0x02000064 RID: 100
	public class MoveContext : Object
	{
		// Token: 0x060005E3 RID: 1507 RVA: 0x0001CE7C File Offset: 0x0001B07C
		// Note: this type is marked as 'beforefieldinit'.
		static MoveContext()
		{
			Il2CppClassPointerStore<MoveContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "MoveContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveContext>.NativeClassPtr);
			MoveContext.NativeFieldInfoPtr_views = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveContext>.NativeClassPtr, "views");
			MoveContext.NativeFieldInfoPtr_newSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveContext>.NativeClassPtr, "newSize");
			MoveContext.NativeFieldInfoPtr_slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveContext>.NativeClassPtr, "slots");
			MoveContext.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveContext>.NativeClassPtr, "start");
			MoveContext.NativeFieldInfoPtr_dest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveContext>.NativeClassPtr, "dest");
			MoveContext.NativeFieldInfoPtr_sequenceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveContext>.NativeClassPtr, "sequenceName");
			MoveContext.NativeFieldInfoPtr_MoveLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveContext>.NativeClassPtr, "MoveLayer");
			MoveContext.NativeFieldInfoPtr_Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveContext>.NativeClassPtr, "Next");
			MoveContext.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveContext>.NativeClassPtr, "attributes");
			MoveContext.NativeFieldInfoPtr_staggerGenerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveContext>.NativeClassPtr, "staggerGenerator");
			MoveContext.NativeFieldInfoPtr_stagger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveContext>.NativeClassPtr, "stagger");
			MoveContext.NativeFieldInfoPtr__Path_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveContext>.NativeClassPtr, "<Path>k__BackingField");
			MoveContext.NativeMethodInfoPtr_get_Attributes_Public_get_ReadOnlyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveContext>.NativeClassPtr, 100664113);
			MoveContext.NativeMethodInfoPtr_get_Path_Public_get_PathAnimator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveContext>.NativeClassPtr, 100664114);
			MoveContext.NativeMethodInfoPtr_set_Path_Private_set_Void_PathAnimator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveContext>.NativeClassPtr, 100664115);
			MoveContext.NativeMethodInfoPtr_GetStagger_Public_Virtual_Final_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveContext>.NativeClassPtr, 100664116);
			MoveContext.NativeMethodInfoPtr_HasStagger_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveContext>.NativeClassPtr, 100664117);
			MoveContext.NativeMethodInfoPtr_AddView_Public_Void_Int32_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveContext>.NativeClassPtr, 100664118);
			MoveContext.NativeMethodInfoPtr_SetPath_Public_Void_PathAnimator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveContext>.NativeClassPtr, 100664119);
			MoveContext.NativeMethodInfoPtr_SetPath_Public_Void_PathAnimator_IStaggerGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveContext>.NativeClassPtr, 100664120);
			MoveContext.NativeMethodInfoPtr_SetAttributes_Public_Void_ReadOnlyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveContext>.NativeClassPtr, 100664121);
			MoveContext.NativeMethodInfoPtr_GetKey_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveContext>.NativeClassPtr, 100664122);
			MoveContext.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveContext>.NativeClassPtr, 100664123);
			MoveContext.NativeMethodInfoPtr__ctor_Public_Void_List_1_UnitView_List_1_Int32_ContainerView_ContainerView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveContext>.NativeClassPtr, 100664124);
			MoveContext.NativeMethodInfoPtr_HasMoreMovesFromPileAfterThis_Public_Boolean_ContainerView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveContext>.NativeClassPtr, 100664125);
			MoveContext.NativeMethodInfoPtr_Overlaps_Public_Boolean_MoveContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveContext>.NativeClassPtr, 100664126);
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060005E4 RID: 1508 RVA: 0x0001D0B4 File Offset: 0x0001B2B4
		public unsafe ReadOnlyAttributes Attributes
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveContext.NativeMethodInfoPtr_get_Attributes_Public_get_ReadOnlyAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060005E5 RID: 1509 RVA: 0x0001D0F4 File Offset: 0x0001B2F4
		// (set) Token: 0x060005E6 RID: 1510 RVA: 0x0001D134 File Offset: 0x0001B334
		public unsafe PathAnimator Path
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveContext.NativeMethodInfoPtr_get_Path_Public_get_PathAnimator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PathAnimator>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveContext.NativeMethodInfoPtr_set_Path_Private_set_Void_PathAnimator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x0001D178 File Offset: 0x0001B378
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1112637, RefRangeEnd = 1112641, XrefRangeStart = 1112633, XrefRangeEnd = 1112637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float GetStagger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveContext.NativeMethodInfoPtr_GetStagger_Public_Virtual_Final_New_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x0001D1B4 File Offset: 0x0001B3B4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1112644, RefRangeEnd = 1112648, XrefRangeStart = 1112641, XrefRangeEnd = 1112644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool HasStagger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveContext.NativeMethodInfoPtr_HasStagger_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x0001D1F0 File Offset: 0x0001B3F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1112658, RefRangeEnd = 1112661, XrefRangeStart = 1112648, XrefRangeEnd = 1112658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddView(int s, UnitView v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref s;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(v);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveContext.NativeMethodInfoPtr_AddView_Public_Void_Int32_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x0001D240 File Offset: 0x0001B440
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1112662, RefRangeEnd = 1112663, XrefRangeStart = 1112661, XrefRangeEnd = 1112662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPath(PathAnimator path, float stagger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stagger;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveContext.NativeMethodInfoPtr_SetPath_Public_Void_PathAnimator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x0001D290 File Offset: 0x0001B490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112663, XrefRangeEnd = 1112665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPath(PathAnimator path, IStaggerGenerator staggerGenerator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(staggerGenerator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveContext.NativeMethodInfoPtr_SetPath_Public_Void_PathAnimator_IStaggerGenerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x0001D2E4 File Offset: 0x0001B4E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAttributes(ReadOnlyAttributes attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveContext.NativeMethodInfoPtr_SetAttributes_Public_Void_ReadOnlyAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x0001D328 File Offset: 0x0001B528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112665, XrefRangeEnd = 1112667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveContext.NativeMethodInfoPtr_GetKey_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x0001D360 File Offset: 0x0001B560
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1112690, RefRangeEnd = 1112697, XrefRangeStart = 1112667, XrefRangeEnd = 1112690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoveContext()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveContext>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveContext.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x0001D39C File Offset: 0x0001B59C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1112710, RefRangeEnd = 1112711, XrefRangeStart = 1112697, XrefRangeEnd = 1112710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoveContext(List<UnitView> v, List<int> sl, ContainerView s, ContainerView d)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveContext>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sl);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(s);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(d);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveContext.NativeMethodInfoPtr__ctor_Public_Void_List_1_UnitView_List_1_Int32_ContainerView_ContainerView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x0001D420 File Offset: 0x0001B620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112711, XrefRangeEnd = 1112715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasMoreMovesFromPileAfterThis(ContainerView startPile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(startPile);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveContext.NativeMethodInfoPtr_HasMoreMovesFromPileAfterThis_Public_Boolean_ContainerView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x0001D470 File Offset: 0x0001B670
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1112728, RefRangeEnd = 1112729, XrefRangeStart = 1112715, XrefRangeEnd = 1112728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Overlaps(MoveContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveContext.NativeMethodInfoPtr_Overlaps_Public_Boolean_MoveContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00004E6B File Offset: 0x0000306B
		public MoveContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060005F3 RID: 1523 RVA: 0x0001D4C0 File Offset: 0x0001B6C0
		// (set) Token: 0x060005F4 RID: 1524 RVA: 0x00004E74 File Offset: 0x00003074
		public unsafe List<UnitView> views
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveContext.NativeFieldInfoPtr_views);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UnitView>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveContext.NativeFieldInfoPtr_views), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x0001D4F0 File Offset: 0x0001B6F0
		// (set) Token: 0x060005F6 RID: 1526 RVA: 0x00004E93 File Offset: 0x00003093
		public unsafe int newSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveContext.NativeFieldInfoPtr_newSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveContext.NativeFieldInfoPtr_newSize)) = value;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x0001D518 File Offset: 0x0001B718
		// (set) Token: 0x060005F8 RID: 1528 RVA: 0x00004EAE File Offset: 0x000030AE
		public unsafe List<int> slots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveContext.NativeFieldInfoPtr_slots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveContext.NativeFieldInfoPtr_slots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060005F9 RID: 1529 RVA: 0x0001D548 File Offset: 0x0001B748
		// (set) Token: 0x060005FA RID: 1530 RVA: 0x00004ECD File Offset: 0x000030CD
		public unsafe ContainerView start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveContext.NativeFieldInfoPtr_start);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveContext.NativeFieldInfoPtr_start), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x0001D578 File Offset: 0x0001B778
		// (set) Token: 0x060005FC RID: 1532 RVA: 0x00004EEC File Offset: 0x000030EC
		public unsafe ContainerView dest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveContext.NativeFieldInfoPtr_dest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveContext.NativeFieldInfoPtr_dest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060005FD RID: 1533 RVA: 0x0001D5A8 File Offset: 0x0001B7A8
		// (set) Token: 0x060005FE RID: 1534 RVA: 0x00004F0B File Offset: 0x0000310B
		public unsafe string sequenceName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveContext.NativeFieldInfoPtr_sequenceName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveContext.NativeFieldInfoPtr_sequenceName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060005FF RID: 1535 RVA: 0x0001D5D0 File Offset: 0x0001B7D0
		// (set) Token: 0x06000600 RID: 1536 RVA: 0x00004F2A File Offset: 0x0000312A
		public unsafe int MoveLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveContext.NativeFieldInfoPtr_MoveLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveContext.NativeFieldInfoPtr_MoveLayer)) = value;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000601 RID: 1537 RVA: 0x0001D5F8 File Offset: 0x0001B7F8
		// (set) Token: 0x06000602 RID: 1538 RVA: 0x00004F45 File Offset: 0x00003145
		public unsafe MoveContext Next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveContext.NativeFieldInfoPtr_Next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveContext.NativeFieldInfoPtr_Next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x0001D628 File Offset: 0x0001B828
		// (set) Token: 0x06000604 RID: 1540 RVA: 0x00004F64 File Offset: 0x00003164
		public unsafe ReadOnlyAttributes attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveContext.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveContext.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000605 RID: 1541 RVA: 0x0001D658 File Offset: 0x0001B858
		// (set) Token: 0x06000606 RID: 1542 RVA: 0x00004F83 File Offset: 0x00003183
		public unsafe IStaggerGenerator staggerGenerator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveContext.NativeFieldInfoPtr_staggerGenerator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IStaggerGenerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveContext.NativeFieldInfoPtr_staggerGenerator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x0001D688 File Offset: 0x0001B888
		// (set) Token: 0x06000608 RID: 1544 RVA: 0x00004FA2 File Offset: 0x000031A2
		public unsafe float stagger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveContext.NativeFieldInfoPtr_stagger);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveContext.NativeFieldInfoPtr_stagger)) = value;
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x0001D6B0 File Offset: 0x0001B8B0
		// (set) Token: 0x0600060A RID: 1546 RVA: 0x00004FBD File Offset: 0x000031BD
		public unsafe PathAnimator _Path_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveContext.NativeFieldInfoPtr__Path_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathAnimator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveContext.NativeFieldInfoPtr__Path_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003B1 RID: 945
		private static readonly IntPtr NativeFieldInfoPtr_views;

		// Token: 0x040003B2 RID: 946
		private static readonly IntPtr NativeFieldInfoPtr_newSize;

		// Token: 0x040003B3 RID: 947
		private static readonly IntPtr NativeFieldInfoPtr_slots;

		// Token: 0x040003B4 RID: 948
		private static readonly IntPtr NativeFieldInfoPtr_start;

		// Token: 0x040003B5 RID: 949
		private static readonly IntPtr NativeFieldInfoPtr_dest;

		// Token: 0x040003B6 RID: 950
		private static readonly IntPtr NativeFieldInfoPtr_sequenceName;

		// Token: 0x040003B7 RID: 951
		private static readonly IntPtr NativeFieldInfoPtr_MoveLayer;

		// Token: 0x040003B8 RID: 952
		private static readonly IntPtr NativeFieldInfoPtr_Next;

		// Token: 0x040003B9 RID: 953
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x040003BA RID: 954
		private static readonly IntPtr NativeFieldInfoPtr_staggerGenerator;

		// Token: 0x040003BB RID: 955
		private static readonly IntPtr NativeFieldInfoPtr_stagger;

		// Token: 0x040003BC RID: 956
		private static readonly IntPtr NativeFieldInfoPtr__Path_k__BackingField;

		// Token: 0x040003BD RID: 957
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_get_ReadOnlyAttributes_0;

		// Token: 0x040003BE RID: 958
		private static readonly IntPtr NativeMethodInfoPtr_get_Path_Public_get_PathAnimator_0;

		// Token: 0x040003BF RID: 959
		private static readonly IntPtr NativeMethodInfoPtr_set_Path_Private_set_Void_PathAnimator_0;

		// Token: 0x040003C0 RID: 960
		private static readonly IntPtr NativeMethodInfoPtr_GetStagger_Public_Virtual_Final_New_Single_0;

		// Token: 0x040003C1 RID: 961
		private static readonly IntPtr NativeMethodInfoPtr_HasStagger_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x040003C2 RID: 962
		private static readonly IntPtr NativeMethodInfoPtr_AddView_Public_Void_Int32_UnitView_0;

		// Token: 0x040003C3 RID: 963
		private static readonly IntPtr NativeMethodInfoPtr_SetPath_Public_Void_PathAnimator_Single_0;

		// Token: 0x040003C4 RID: 964
		private static readonly IntPtr NativeMethodInfoPtr_SetPath_Public_Void_PathAnimator_IStaggerGenerator_0;

		// Token: 0x040003C5 RID: 965
		private static readonly IntPtr NativeMethodInfoPtr_SetAttributes_Public_Void_ReadOnlyAttributes_0;

		// Token: 0x040003C6 RID: 966
		private static readonly IntPtr NativeMethodInfoPtr_GetKey_Public_String_0;

		// Token: 0x040003C7 RID: 967
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040003C8 RID: 968
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_UnitView_List_1_Int32_ContainerView_ContainerView_0;

		// Token: 0x040003C9 RID: 969
		private static readonly IntPtr NativeMethodInfoPtr_HasMoreMovesFromPileAfterThis_Public_Boolean_ContainerView_0;

		// Token: 0x040003CA RID: 970
		private static readonly IntPtr NativeMethodInfoPtr_Overlaps_Public_Boolean_MoveContext_0;
	}
}
