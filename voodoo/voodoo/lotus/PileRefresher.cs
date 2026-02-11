using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace lotus
{
	// Token: 0x0200006F RID: 111
	public class PileRefresher : Observer
	{
		// Token: 0x0600066E RID: 1646 RVA: 0x0001E9AC File Offset: 0x0001CBAC
		// Note: this type is marked as 'beforefieldinit'.
		static PileRefresher()
		{
			Il2CppClassPointerStore<PileRefresher>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "PileRefresher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PileRefresher>.NativeClassPtr);
			PileRefresher.NativeFieldInfoPtr_knownViews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PileRefresher>.NativeClassPtr, "knownViews");
			PileRefresher.NativeFieldInfoPtr_temp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PileRefresher>.NativeClassPtr, "temp");
			PileRefresher.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PileRefresher>.NativeClassPtr, "container");
			PileRefresher.NativeFieldInfoPtr_viewsToRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PileRefresher>.NativeClassPtr, "viewsToRemove");
			PileRefresher.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PileRefresher>.NativeClassPtr, 100664175);
			PileRefresher.NativeMethodInfoPtr_OnDespawn_Private_Void_PoolableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PileRefresher>.NativeClassPtr, 100664176);
			PileRefresher.NativeMethodInfoPtr_onUnitDespawn_Private_Void_PoolableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PileRefresher>.NativeClassPtr, 100664177);
			PileRefresher.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PileRefresher>.NativeClassPtr, 100664178);
			PileRefresher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PileRefresher>.NativeClassPtr, 100664179);
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x0001EA90 File Offset: 0x0001CC90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112969, XrefRangeEnd = 1112987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PileRefresher.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x0001EACC File Offset: 0x0001CCCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112987, XrefRangeEnd = 1112993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDespawn(PoolableItem pi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pi);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PileRefresher.NativeMethodInfoPtr_OnDespawn_Private_Void_PoolableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x0001EB10 File Offset: 0x0001CD10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112993, XrefRangeEnd = 1113003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void onUnitDespawn(PoolableItem pi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pi);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PileRefresher.NativeMethodInfoPtr_onUnitDespawn_Private_Void_PoolableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x0001EB54 File Offset: 0x0001CD54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113003, XrefRangeEnd = 1113057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PileRefresher.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x0001EB90 File Offset: 0x0001CD90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113057, XrefRangeEnd = 1113075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PileRefresher()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PileRefresher>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PileRefresher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x000052DE File Offset: 0x000034DE
		public PileRefresher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000675 RID: 1653 RVA: 0x0001EBCC File Offset: 0x0001CDCC
		// (set) Token: 0x06000676 RID: 1654 RVA: 0x000052E7 File Offset: 0x000034E7
		public unsafe HashSet<UnitView> knownViews
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileRefresher.NativeFieldInfoPtr_knownViews);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<UnitView>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileRefresher.NativeFieldInfoPtr_knownViews), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000677 RID: 1655 RVA: 0x0001EBFC File Offset: 0x0001CDFC
		// (set) Token: 0x06000678 RID: 1656 RVA: 0x00005306 File Offset: 0x00003506
		public unsafe HashSet<UnitView> temp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileRefresher.NativeFieldInfoPtr_temp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<UnitView>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileRefresher.NativeFieldInfoPtr_temp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000679 RID: 1657 RVA: 0x0001EC2C File Offset: 0x0001CE2C
		// (set) Token: 0x0600067A RID: 1658 RVA: 0x00005325 File Offset: 0x00003525
		public unsafe ContainerView container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileRefresher.NativeFieldInfoPtr_container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileRefresher.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x0600067B RID: 1659 RVA: 0x0001EC5C File Offset: 0x0001CE5C
		// (set) Token: 0x0600067C RID: 1660 RVA: 0x00005344 File Offset: 0x00003544
		public unsafe HashSet<UnitView> viewsToRemove
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileRefresher.NativeFieldInfoPtr_viewsToRemove);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<UnitView>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileRefresher.NativeFieldInfoPtr_viewsToRemove), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000403 RID: 1027
		private static readonly IntPtr NativeFieldInfoPtr_knownViews;

		// Token: 0x04000404 RID: 1028
		private static readonly IntPtr NativeFieldInfoPtr_temp;

		// Token: 0x04000405 RID: 1029
		private static readonly IntPtr NativeFieldInfoPtr_container;

		// Token: 0x04000406 RID: 1030
		private static readonly IntPtr NativeFieldInfoPtr_viewsToRemove;

		// Token: 0x04000407 RID: 1031
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000408 RID: 1032
		private static readonly IntPtr NativeMethodInfoPtr_OnDespawn_Private_Void_PoolableItem_0;

		// Token: 0x04000409 RID: 1033
		private static readonly IntPtr NativeMethodInfoPtr_onUnitDespawn_Private_Void_PoolableItem_0;

		// Token: 0x0400040A RID: 1034
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x0400040B RID: 1035
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
