using System;
using boardgames.match;
using Canis.attributes;
using Canis.utils.ids;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using lib.canis.boardgames.src.match;
using worm.client.match.render;

namespace worm.match.dataRenderers
{
	// Token: 0x020000F5 RID: 245
	public class WormAcquiredThisTurnRenderer : VersionedView<IAttribute<List<EntityID>>>
	{
		// Token: 0x06000AC0 RID: 2752 RVA: 0x00038CF8 File Offset: 0x00036EF8
		// Note: this type is marked as 'beforefieldinit'.
		static WormAcquiredThisTurnRenderer()
		{
			Il2CppClassPointerStore<WormAcquiredThisTurnRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormAcquiredThisTurnRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAcquiredThisTurnRenderer>.NativeClassPtr);
			WormAcquiredThisTurnRenderer.NativeFieldInfoPtr_pileRefresher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquiredThisTurnRenderer>.NativeClassPtr, "pileRefresher");
			WormAcquiredThisTurnRenderer.NativeFieldInfoPtr_displayEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquiredThisTurnRenderer>.NativeClassPtr, "displayEntities");
			WormAcquiredThisTurnRenderer.NativeFieldInfoPtr_tempEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquiredThisTurnRenderer>.NativeClassPtr, "tempEntities");
			WormAcquiredThisTurnRenderer.NativeFieldInfoPtr_acquiredArchetypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquiredThisTurnRenderer>.NativeClassPtr, "acquiredArchetypes");
			WormAcquiredThisTurnRenderer.NativeFieldInfoPtr_archetypeProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquiredThisTurnRenderer>.NativeClassPtr, "archetypeProvider");
			WormAcquiredThisTurnRenderer.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquiredThisTurnRenderer>.NativeClassPtr, "entities");
			WormAcquiredThisTurnRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquiredThisTurnRenderer>.NativeClassPtr, 100664785);
			WormAcquiredThisTurnRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquiredThisTurnRenderer>.NativeClassPtr, 100664786);
			WormAcquiredThisTurnRenderer.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquiredThisTurnRenderer>.NativeClassPtr, 100664787);
			WormAcquiredThisTurnRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquiredThisTurnRenderer>.NativeClassPtr, 100664788);
			WormAcquiredThisTurnRenderer.NativeMethodInfoPtr__dirtyUpdate_b__7_0_Private_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquiredThisTurnRenderer>.NativeClassPtr, 100664789);
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x00038E04 File Offset: 0x00037004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701929, XrefRangeEnd = 701953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAcquiredThisTurnRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x00038E40 File Offset: 0x00037040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701953, XrefRangeEnd = 702010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAcquiredThisTurnRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x00038E7C File Offset: 0x0003707C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702010, XrefRangeEnd = 702042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAcquiredThisTurnRenderer.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x00038EB0 File Offset: 0x000370B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702042, XrefRangeEnd = 702059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormAcquiredThisTurnRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAcquiredThisTurnRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAcquiredThisTurnRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x00038EEC File Offset: 0x000370EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702059, XrefRangeEnd = 702062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _dirtyUpdate_b__7_0(EntityComponent e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAcquiredThisTurnRenderer.NativeMethodInfoPtr__dirtyUpdate_b__7_0_Private_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x000079D7 File Offset: 0x00005BD7
		public WormAcquiredThisTurnRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000AC7 RID: 2759 RVA: 0x00038F3C File Offset: 0x0003713C
		// (set) Token: 0x06000AC8 RID: 2760 RVA: 0x000079E0 File Offset: 0x00005BE0
		public unsafe AnimatedPileRefresher pileRefresher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquiredThisTurnRenderer.NativeFieldInfoPtr_pileRefresher);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimatedPileRefresher>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquiredThisTurnRenderer.NativeFieldInfoPtr_pileRefresher), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000AC9 RID: 2761 RVA: 0x00038F6C File Offset: 0x0003716C
		// (set) Token: 0x06000ACA RID: 2762 RVA: 0x000079FF File Offset: 0x00005BFF
		public unsafe List<EntityComponent> displayEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquiredThisTurnRenderer.NativeFieldInfoPtr_displayEntities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquiredThisTurnRenderer.NativeFieldInfoPtr_displayEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000ACB RID: 2763 RVA: 0x00038F9C File Offset: 0x0003719C
		// (set) Token: 0x06000ACC RID: 2764 RVA: 0x00007A1E File Offset: 0x00005C1E
		public unsafe Dictionary<ArchetypeID, List<EntityComponent>> tempEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquiredThisTurnRenderer.NativeFieldInfoPtr_tempEntities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ArchetypeID, List<EntityComponent>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquiredThisTurnRenderer.NativeFieldInfoPtr_tempEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000ACD RID: 2765 RVA: 0x00038FCC File Offset: 0x000371CC
		// (set) Token: 0x06000ACE RID: 2766 RVA: 0x00007A3D File Offset: 0x00005C3D
		public unsafe IAttribute<List<ArchetypeID>> acquiredArchetypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquiredThisTurnRenderer.NativeFieldInfoPtr_acquiredArchetypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<List<ArchetypeID>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquiredThisTurnRenderer.NativeFieldInfoPtr_acquiredArchetypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000ACF RID: 2767 RVA: 0x00038FFC File Offset: 0x000371FC
		// (set) Token: 0x06000AD0 RID: 2768 RVA: 0x00007A5C File Offset: 0x00005C5C
		public unsafe ArchetypeProvider archetypeProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquiredThisTurnRenderer.NativeFieldInfoPtr_archetypeProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquiredThisTurnRenderer.NativeFieldInfoPtr_archetypeProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x0003902C File Offset: 0x0003722C
		// (set) Token: 0x06000AD2 RID: 2770 RVA: 0x00007A7B File Offset: 0x00005C7B
		public unsafe DBGEntities entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquiredThisTurnRenderer.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquiredThisTurnRenderer.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000635 RID: 1589
		private static readonly IntPtr NativeFieldInfoPtr_pileRefresher;

		// Token: 0x04000636 RID: 1590
		private static readonly IntPtr NativeFieldInfoPtr_displayEntities;

		// Token: 0x04000637 RID: 1591
		private static readonly IntPtr NativeFieldInfoPtr_tempEntities;

		// Token: 0x04000638 RID: 1592
		private static readonly IntPtr NativeFieldInfoPtr_acquiredArchetypes;

		// Token: 0x04000639 RID: 1593
		private static readonly IntPtr NativeFieldInfoPtr_archetypeProvider;

		// Token: 0x0400063A RID: 1594
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x0400063B RID: 1595
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400063C RID: 1596
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400063D RID: 1597
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400063E RID: 1598
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400063F RID: 1599
		private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__7_0_Private_Boolean_EntityComponent_0;
	}
}
