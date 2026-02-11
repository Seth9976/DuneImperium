using System;
using Canis;
using Canis.entities;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using worm.canis.abilities.SpaceAbilities;
using worm.canis.data.enums;

namespace worm.canis.entities
{
	// Token: 0x02000023 RID: 35
	public class WormBoard : WormEntity
	{
		// Token: 0x060002FD RID: 765 RVA: 0x00074AEC File Offset: 0x00072CEC
		// Note: this type is marked as 'beforefieldinit'.
		static WormBoard()
		{
			Il2CppClassPointerStore<WormBoard>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.entities", "WormBoard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormBoard>.NativeClassPtr);
			WormBoard.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBoard>.NativeClassPtr, "wormMatch");
			WormBoard.NativeFieldInfoPtr__ConflictDeck_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBoard>.NativeClassPtr, "<ConflictDeck>k__BackingField");
			WormBoard.NativeFieldInfoPtr__ConflictPile_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBoard>.NativeClassPtr, "<ConflictPile>k__BackingField");
			WormBoard.NativeFieldInfoPtr__ConflictArea_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBoard>.NativeClassPtr, "<ConflictArea>k__BackingField");
			WormBoard.NativeFieldInfoPtr__FactionTracks_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBoard>.NativeClassPtr, "<FactionTracks>k__BackingField");
			WormBoard.NativeFieldInfoPtr__ShippingTrack_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBoard>.NativeClassPtr, "<ShippingTrack>k__BackingField");
			WormBoard.NativeFieldInfoPtr__TechTileStacks_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBoard>.NativeClassPtr, "<TechTileStacks>k__BackingField");
			WormBoard.NativeFieldInfoPtr__TechNegotiationArea_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBoard>.NativeClassPtr, "<TechNegotiationArea>k__BackingField");
			WormBoard.NativeFieldInfoPtr__TleilaxuTrack_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBoard>.NativeClassPtr, "<TleilaxuTrack>k__BackingField");
			WormBoard.NativeFieldInfoPtr__TleilaxuTank_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBoard>.NativeClassPtr, "<TleilaxuTank>k__BackingField");
			WormBoard.NativeFieldInfoPtr__ResearchTrack_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBoard>.NativeClassPtr, "<ResearchTrack>k__BackingField");
			WormBoard.NativeMethodInfoPtr_get_ConflictDeck_Public_get_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoard>.NativeClassPtr, 100663938);
			WormBoard.NativeMethodInfoPtr_set_ConflictDeck_Public_set_Void_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoard>.NativeClassPtr, 100663939);
			WormBoard.NativeMethodInfoPtr_get_ConflictPile_Public_get_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoard>.NativeClassPtr, 100663940);
			WormBoard.NativeMethodInfoPtr_set_ConflictPile_Public_set_Void_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoard>.NativeClassPtr, 100663941);
			WormBoard.NativeMethodInfoPtr_get_ConflictArea_Public_get_WormConflictArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoard>.NativeClassPtr, 100663942);
			WormBoard.NativeMethodInfoPtr_set_ConflictArea_Public_set_Void_WormConflictArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoard>.NativeClassPtr, 100663943);
			WormBoard.NativeMethodInfoPtr_get_FactionTracks_Public_get_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoard>.NativeClassPtr, 100663944);
			WormBoard.NativeMethodInfoPtr_set_FactionTracks_Public_set_Void_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoard>.NativeClassPtr, 100663945);
			WormBoard.NativeMethodInfoPtr_get_ShippingTrack_Public_get_WormShippingTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoard>.NativeClassPtr, 100663946);
			WormBoard.NativeMethodInfoPtr_set_ShippingTrack_Public_set_Void_WormShippingTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoard>.NativeClassPtr, 100663947);
			WormBoard.NativeMethodInfoPtr_get_TechTileStacks_Public_get_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoard>.NativeClassPtr, 100663948);
			WormBoard.NativeMethodInfoPtr_set_TechTileStacks_Public_set_Void_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoard>.NativeClassPtr, 100663949);
			WormBoard.NativeMethodInfoPtr_get_TechNegotiationArea_Public_get_WormTechNegotiationArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoard>.NativeClassPtr, 100663950);
			WormBoard.NativeMethodInfoPtr_set_TechNegotiationArea_Public_set_Void_WormTechNegotiationArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoard>.NativeClassPtr, 100663951);
			WormBoard.NativeMethodInfoPtr_get_TleilaxuTrack_Public_get_WormTleilaxuTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoard>.NativeClassPtr, 100663952);
			WormBoard.NativeMethodInfoPtr_set_TleilaxuTrack_Public_set_Void_WormTleilaxuTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoard>.NativeClassPtr, 100663953);
			WormBoard.NativeMethodInfoPtr_get_TleilaxuTank_Public_get_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoard>.NativeClassPtr, 100663954);
			WormBoard.NativeMethodInfoPtr_set_TleilaxuTank_Public_set_Void_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoard>.NativeClassPtr, 100663955);
			WormBoard.NativeMethodInfoPtr_get_ResearchTrack_Public_get_WormResearchTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoard>.NativeClassPtr, 100663956);
			WormBoard.NativeMethodInfoPtr_set_ResearchTrack_Public_set_Void_WormResearchTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoard>.NativeClassPtr, 100663957);
			WormBoard.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoard>.NativeClassPtr, 100663958);
			WormBoard.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoard>.NativeClassPtr, 100663959);
			WormBoard.NativeMethodInfoPtr_get_Spaces_Public_get_IEnumerable_1_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoard>.NativeClassPtr, 100663960);
			WormBoard.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoard>.NativeClassPtr, 100663961);
			WormBoard.NativeMethodInfoPtr_FindSpace_Public_WormSpace_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoard>.NativeClassPtr, 100663962);
			WormBoard.NativeMethodInfoPtr_ValidSpaces_Public_IEnumerable_1_WormSpace_WormImperiumPlayable_WormPlayer_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoard>.NativeClassPtr, 100663963);
			WormBoard.NativeMethodInfoPtr_GetTrackForFaction_Public_WormFactionTrack_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoard>.NativeClassPtr, 100663964);
			WormBoard.NativeMethodInfoPtr_get_CurrentConflict_Public_get_WormConflictPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoard>.NativeClassPtr, 100663965);
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060002FE RID: 766 RVA: 0x00074E28 File Offset: 0x00073028
		// (set) Token: 0x060002FF RID: 767 RVA: 0x00074E68 File Offset: 0x00073068
		public unsafe WormPlayArea ConflictDeck
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoard.NativeMethodInfoPtr_get_ConflictDeck_Public_get_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34747, XrefRangeEnd = 34748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoard.NativeMethodInfoPtr_set_ConflictDeck_Public_set_Void_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000300 RID: 768 RVA: 0x00074EAC File Offset: 0x000730AC
		// (set) Token: 0x06000301 RID: 769 RVA: 0x00074EEC File Offset: 0x000730EC
		public unsafe WormPlayArea ConflictPile
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoard.NativeMethodInfoPtr_get_ConflictPile_Public_get_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34748, XrefRangeEnd = 34749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoard.NativeMethodInfoPtr_set_ConflictPile_Public_set_Void_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000302 RID: 770 RVA: 0x00074F30 File Offset: 0x00073130
		// (set) Token: 0x06000303 RID: 771 RVA: 0x00074F70 File Offset: 0x00073170
		public unsafe WormConflictArea ConflictArea
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoard.NativeMethodInfoPtr_get_ConflictArea_Public_get_WormConflictArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormConflictArea>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34749, XrefRangeEnd = 34750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoard.NativeMethodInfoPtr_set_ConflictArea_Public_set_Void_WormConflictArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000304 RID: 772 RVA: 0x00074FB4 File Offset: 0x000731B4
		// (set) Token: 0x06000305 RID: 773 RVA: 0x00074FF4 File Offset: 0x000731F4
		public unsafe WormPlayArea FactionTracks
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoard.NativeMethodInfoPtr_get_FactionTracks_Public_get_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34750, XrefRangeEnd = 34751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoard.NativeMethodInfoPtr_set_FactionTracks_Public_set_Void_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000306 RID: 774 RVA: 0x00075038 File Offset: 0x00073238
		// (set) Token: 0x06000307 RID: 775 RVA: 0x00075078 File Offset: 0x00073278
		public unsafe WormShippingTrack ShippingTrack
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoard.NativeMethodInfoPtr_get_ShippingTrack_Public_get_WormShippingTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormShippingTrack>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34758, XrefRangeEnd = 34759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoard.NativeMethodInfoPtr_set_ShippingTrack_Public_set_Void_WormShippingTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000308 RID: 776 RVA: 0x000750BC File Offset: 0x000732BC
		// (set) Token: 0x06000309 RID: 777 RVA: 0x000750FC File Offset: 0x000732FC
		public unsafe WormPlayArea TechTileStacks
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoard.NativeMethodInfoPtr_get_TechTileStacks_Public_get_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34759, XrefRangeEnd = 34760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoard.NativeMethodInfoPtr_set_TechTileStacks_Public_set_Void_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600030A RID: 778 RVA: 0x00075140 File Offset: 0x00073340
		// (set) Token: 0x0600030B RID: 779 RVA: 0x00075180 File Offset: 0x00073380
		public unsafe WormTechNegotiationArea TechNegotiationArea
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoard.NativeMethodInfoPtr_get_TechNegotiationArea_Public_get_WormTechNegotiationArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormTechNegotiationArea>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34760, XrefRangeEnd = 34761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoard.NativeMethodInfoPtr_set_TechNegotiationArea_Public_set_Void_WormTechNegotiationArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x0600030C RID: 780 RVA: 0x000751C4 File Offset: 0x000733C4
		// (set) Token: 0x0600030D RID: 781 RVA: 0x00075204 File Offset: 0x00073404
		public unsafe WormTleilaxuTrack TleilaxuTrack
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoard.NativeMethodInfoPtr_get_TleilaxuTrack_Public_get_WormTleilaxuTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormTleilaxuTrack>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34761, XrefRangeEnd = 34762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoard.NativeMethodInfoPtr_set_TleilaxuTrack_Public_set_Void_WormTleilaxuTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600030E RID: 782 RVA: 0x00075248 File Offset: 0x00073448
		// (set) Token: 0x0600030F RID: 783 RVA: 0x00075288 File Offset: 0x00073488
		public unsafe WormPlayArea TleilaxuTank
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoard.NativeMethodInfoPtr_get_TleilaxuTank_Public_get_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34762, XrefRangeEnd = 34764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoard.NativeMethodInfoPtr_set_TleilaxuTank_Public_set_Void_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000310 RID: 784 RVA: 0x000752CC File Offset: 0x000734CC
		// (set) Token: 0x06000311 RID: 785 RVA: 0x0007530C File Offset: 0x0007350C
		public unsafe WormResearchTrack ResearchTrack
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoard.NativeMethodInfoPtr_get_ResearchTrack_Public_get_WormResearchTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormResearchTrack>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34764, XrefRangeEnd = 34765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoard.NativeMethodInfoPtr_set_ResearchTrack_Public_set_Void_WormResearchTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00075350 File Offset: 0x00073550
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34924, RefRangeEnd = 34925, XrefRangeStart = 34765, XrefRangeEnd = 34924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormBoard(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormBoard>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoard.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0007539C File Offset: 0x0007359C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34970, RefRangeEnd = 34971, XrefRangeStart = 34925, XrefRangeEnd = 34970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormBoard(SerializedEntity se, Match m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormBoard>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoard.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000314 RID: 788 RVA: 0x0007540C File Offset: 0x0007360C
		public unsafe IEnumerable<WormSpace> Spaces
		{
			[CallerCount(34)]
			[CachedScanResults(RefRangeStart = 34974, RefRangeEnd = 35008, XrefRangeStart = 34971, XrefRangeEnd = 34974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoard.NativeMethodInfoPtr_get_Spaces_Public_get_IEnumerable_1_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormSpace>>(intPtr3) : null;
			}
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0007544C File Offset: 0x0007364C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35075, RefRangeEnd = 35076, XrefRangeStart = 35008, XrefRangeEnd = 35075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoard.NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00075480 File Offset: 0x00073680
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 35094, RefRangeEnd = 35123, XrefRangeStart = 35076, XrefRangeEnd = 35094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSpace FindSpace(ArchetypeID archetypeID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(archetypeID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoard.NativeMethodInfoPtr_FindSpace_Public_WormSpace_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormSpace>(intPtr3) : null;
			}
		}

		// Token: 0x06000317 RID: 791 RVA: 0x000754D0 File Offset: 0x000736D0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 35144, RefRangeEnd = 35154, XrefRangeStart = 35123, XrefRangeEnd = 35144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<WormSpace> ValidSpaces(WormImperiumPlayable agentCard, WormPlayer player, WormImperiumPlayable graftedCard = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(agentCard);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(graftedCard);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoard.NativeMethodInfoPtr_ValidSpaces_Public_IEnumerable_1_WormSpace_WormImperiumPlayable_WormPlayer_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormSpace>>(intPtr3) : null;
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00075544 File Offset: 0x00073744
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 35171, RefRangeEnd = 35176, XrefRangeStart = 35154, XrefRangeEnd = 35171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormFactionTrack GetTrackForFaction(Factions faction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref faction;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoard.NativeMethodInfoPtr_GetTrackForFaction_Public_WormFactionTrack_Factions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormFactionTrack>(intPtr3) : null;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000319 RID: 793 RVA: 0x00075590 File Offset: 0x00073790
		public unsafe WormConflictPlayable CurrentConflict
		{
			[CallerCount(30)]
			[CachedScanResults(RefRangeStart = 35183, RefRangeEnd = 35213, XrefRangeStart = 35176, XrefRangeEnd = 35183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoard.NativeMethodInfoPtr_get_CurrentConflict_Public_get_WormConflictPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormConflictPlayable>(intPtr3) : null;
			}
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0000351A File Offset: 0x0000171A
		public WormBoard(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600031B RID: 795 RVA: 0x000755D0 File Offset: 0x000737D0
		// (set) Token: 0x0600031C RID: 796 RVA: 0x00003523 File Offset: 0x00001723
		public unsafe WormMatch wormMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoard.NativeFieldInfoPtr_wormMatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoard.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600031D RID: 797 RVA: 0x00075600 File Offset: 0x00073800
		// (set) Token: 0x0600031E RID: 798 RVA: 0x00003542 File Offset: 0x00001742
		public unsafe WormPlayArea _ConflictDeck_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoard.NativeFieldInfoPtr__ConflictDeck_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoard.NativeFieldInfoPtr__ConflictDeck_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600031F RID: 799 RVA: 0x00075630 File Offset: 0x00073830
		// (set) Token: 0x06000320 RID: 800 RVA: 0x00003561 File Offset: 0x00001761
		public unsafe WormPlayArea _ConflictPile_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoard.NativeFieldInfoPtr__ConflictPile_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoard.NativeFieldInfoPtr__ConflictPile_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000321 RID: 801 RVA: 0x00075660 File Offset: 0x00073860
		// (set) Token: 0x06000322 RID: 802 RVA: 0x00003580 File Offset: 0x00001780
		public unsafe WormConflictArea _ConflictArea_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoard.NativeFieldInfoPtr__ConflictArea_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormConflictArea>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoard.NativeFieldInfoPtr__ConflictArea_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000323 RID: 803 RVA: 0x00075690 File Offset: 0x00073890
		// (set) Token: 0x06000324 RID: 804 RVA: 0x0000359F File Offset: 0x0000179F
		public unsafe WormPlayArea _FactionTracks_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoard.NativeFieldInfoPtr__FactionTracks_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoard.NativeFieldInfoPtr__FactionTracks_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000325 RID: 805 RVA: 0x000756C0 File Offset: 0x000738C0
		// (set) Token: 0x06000326 RID: 806 RVA: 0x000035BE File Offset: 0x000017BE
		public unsafe WormShippingTrack _ShippingTrack_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoard.NativeFieldInfoPtr__ShippingTrack_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormShippingTrack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoard.NativeFieldInfoPtr__ShippingTrack_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000327 RID: 807 RVA: 0x000756F0 File Offset: 0x000738F0
		// (set) Token: 0x06000328 RID: 808 RVA: 0x000035DD File Offset: 0x000017DD
		public unsafe WormPlayArea _TechTileStacks_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoard.NativeFieldInfoPtr__TechTileStacks_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoard.NativeFieldInfoPtr__TechTileStacks_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000329 RID: 809 RVA: 0x00075720 File Offset: 0x00073920
		// (set) Token: 0x0600032A RID: 810 RVA: 0x000035FC File Offset: 0x000017FC
		public unsafe WormTechNegotiationArea _TechNegotiationArea_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoard.NativeFieldInfoPtr__TechNegotiationArea_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTechNegotiationArea>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoard.NativeFieldInfoPtr__TechNegotiationArea_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600032B RID: 811 RVA: 0x00075750 File Offset: 0x00073950
		// (set) Token: 0x0600032C RID: 812 RVA: 0x0000361B File Offset: 0x0000181B
		public unsafe WormTleilaxuTrack _TleilaxuTrack_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoard.NativeFieldInfoPtr__TleilaxuTrack_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTleilaxuTrack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoard.NativeFieldInfoPtr__TleilaxuTrack_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600032D RID: 813 RVA: 0x00075780 File Offset: 0x00073980
		// (set) Token: 0x0600032E RID: 814 RVA: 0x0000363A File Offset: 0x0000183A
		public unsafe WormPlayArea _TleilaxuTank_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoard.NativeFieldInfoPtr__TleilaxuTank_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoard.NativeFieldInfoPtr__TleilaxuTank_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600032F RID: 815 RVA: 0x000757B0 File Offset: 0x000739B0
		// (set) Token: 0x06000330 RID: 816 RVA: 0x00003659 File Offset: 0x00001859
		public unsafe WormResearchTrack _ResearchTrack_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoard.NativeFieldInfoPtr__ResearchTrack_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormResearchTrack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoard.NativeFieldInfoPtr__ResearchTrack_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeFieldInfoPtr__ConflictDeck_k__BackingField;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeFieldInfoPtr__ConflictPile_k__BackingField;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeFieldInfoPtr__ConflictArea_k__BackingField;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeFieldInfoPtr__FactionTracks_k__BackingField;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeFieldInfoPtr__ShippingTrack_k__BackingField;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeFieldInfoPtr__TechTileStacks_k__BackingField;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeFieldInfoPtr__TechNegotiationArea_k__BackingField;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeFieldInfoPtr__TleilaxuTrack_k__BackingField;

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeFieldInfoPtr__TleilaxuTank_k__BackingField;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeFieldInfoPtr__ResearchTrack_k__BackingField;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeMethodInfoPtr_get_ConflictDeck_Public_get_WormPlayArea_0;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeMethodInfoPtr_set_ConflictDeck_Public_set_Void_WormPlayArea_0;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeMethodInfoPtr_get_ConflictPile_Public_get_WormPlayArea_0;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeMethodInfoPtr_set_ConflictPile_Public_set_Void_WormPlayArea_0;

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeMethodInfoPtr_get_ConflictArea_Public_get_WormConflictArea_0;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeMethodInfoPtr_set_ConflictArea_Public_set_Void_WormConflictArea_0;

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeMethodInfoPtr_get_FactionTracks_Public_get_WormPlayArea_0;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeMethodInfoPtr_set_FactionTracks_Public_set_Void_WormPlayArea_0;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeMethodInfoPtr_get_ShippingTrack_Public_get_WormShippingTrack_0;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeMethodInfoPtr_set_ShippingTrack_Public_set_Void_WormShippingTrack_0;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeMethodInfoPtr_get_TechTileStacks_Public_get_WormPlayArea_0;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeMethodInfoPtr_set_TechTileStacks_Public_set_Void_WormPlayArea_0;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeMethodInfoPtr_get_TechNegotiationArea_Public_get_WormTechNegotiationArea_0;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeMethodInfoPtr_set_TechNegotiationArea_Public_set_Void_WormTechNegotiationArea_0;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeMethodInfoPtr_get_TleilaxuTrack_Public_get_WormTleilaxuTrack_0;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeMethodInfoPtr_set_TleilaxuTrack_Public_set_Void_WormTleilaxuTrack_0;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeMethodInfoPtr_get_TleilaxuTank_Public_get_WormPlayArea_0;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeMethodInfoPtr_set_TleilaxuTank_Public_set_Void_WormPlayArea_0;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeMethodInfoPtr_get_ResearchTrack_Public_get_WormResearchTrack_0;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeMethodInfoPtr_set_ResearchTrack_Public_set_Void_WormResearchTrack_0;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeMethodInfoPtr_get_Spaces_Public_get_IEnumerable_1_WormSpace_0;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeMethodInfoPtr_FindSpace_Public_WormSpace_ArchetypeID_0;

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeMethodInfoPtr_ValidSpaces_Public_IEnumerable_1_WormSpace_WormImperiumPlayable_WormPlayer_WormImperiumPlayable_0;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeMethodInfoPtr_GetTrackForFaction_Public_WormFactionTrack_Factions_0;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentConflict_Public_get_WormConflictPlayable_0;

		// Token: 0x0200058C RID: 1420
		[ObfuscatedName("worm.canis.entities.WormBoard+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600441D RID: 17437 RVA: 0x001814D0 File Offset: 0x0017F6D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormBoard.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormBoard>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormBoard.__c>.NativeClassPtr);
				WormBoard.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBoard.__c>.NativeClassPtr, "<>9");
				WormBoard.__c.NativeFieldInfoPtr___9__45_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBoard.__c>.NativeClassPtr, "<>9__45_0");
				WormBoard.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoard.__c>.NativeClassPtr, 100663967);
				WormBoard.__c.NativeMethodInfoPtr__Initialize_b__45_0_Internal_Boolean_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoard.__c>.NativeClassPtr, 100663968);
			}

			// Token: 0x0600441E RID: 17438 RVA: 0x0018154C File Offset: 0x0017F74C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormBoard.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoard.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600441F RID: 17439 RVA: 0x00181588 File Offset: 0x0017F788
			[CallerCount(0)]
			public unsafe bool _Initialize_b__45_0(Factions _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref _;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoard.__c.NativeMethodInfoPtr__Initialize_b__45_0_Internal_Boolean_Factions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004420 RID: 17440 RVA: 0x00016626 File Offset: 0x00014826
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700102B RID: 4139
			// (get) Token: 0x06004421 RID: 17441 RVA: 0x001815D4 File Offset: 0x0017F7D4
			// (set) Token: 0x06004422 RID: 17442 RVA: 0x0001662F File Offset: 0x0001482F
			public unsafe static WormBoard.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormBoard.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormBoard.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormBoard.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700102C RID: 4140
			// (get) Token: 0x06004423 RID: 17443 RVA: 0x001815FC File Offset: 0x0017F7FC
			// (set) Token: 0x06004424 RID: 17444 RVA: 0x00016641 File Offset: 0x00014841
			public unsafe static Func<Factions, bool> __9__45_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormBoard.__c.NativeFieldInfoPtr___9__45_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Factions, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormBoard.__c.NativeFieldInfoPtr___9__45_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002D03 RID: 11523
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002D04 RID: 11524
			private static readonly IntPtr NativeFieldInfoPtr___9__45_0;

			// Token: 0x04002D05 RID: 11525
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002D06 RID: 11526
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__45_0_Internal_Boolean_Factions_0;
		}

		// Token: 0x0200058D RID: 1421
		[ObfuscatedName("worm.canis.entities.WormBoard+<>c__DisplayClass46_0")]
		public sealed class __c__DisplayClass46_0 : Object
		{
			// Token: 0x06004425 RID: 17445 RVA: 0x00181624 File Offset: 0x0017F824
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass46_0()
			{
				Il2CppClassPointerStore<WormBoard.__c__DisplayClass46_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormBoard>.NativeClassPtr, "<>c__DisplayClass46_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormBoard.__c__DisplayClass46_0>.NativeClassPtr);
				WormBoard.__c__DisplayClass46_0.NativeFieldInfoPtr_archetypeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBoard.__c__DisplayClass46_0>.NativeClassPtr, "archetypeID");
				WormBoard.__c__DisplayClass46_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoard.__c__DisplayClass46_0>.NativeClassPtr, 100663969);
				WormBoard.__c__DisplayClass46_0.NativeMethodInfoPtr__FindSpace_b__0_Internal_Boolean_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoard.__c__DisplayClass46_0>.NativeClassPtr, 100663970);
			}

			// Token: 0x06004426 RID: 17446 RVA: 0x0018168C File Offset: 0x0017F88C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass46_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormBoard.__c__DisplayClass46_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoard.__c__DisplayClass46_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004427 RID: 17447 RVA: 0x001816C8 File Offset: 0x0017F8C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34697, XrefRangeEnd = 34702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _FindSpace_b__0(WormSpace _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoard.__c__DisplayClass46_0.NativeMethodInfoPtr__FindSpace_b__0_Internal_Boolean_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004428 RID: 17448 RVA: 0x00016653 File Offset: 0x00014853
			public __c__DisplayClass46_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700102D RID: 4141
			// (get) Token: 0x06004429 RID: 17449 RVA: 0x00181718 File Offset: 0x0017F918
			// (set) Token: 0x0600442A RID: 17450 RVA: 0x0001665C File Offset: 0x0001485C
			public unsafe ArchetypeID archetypeID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoard.__c__DisplayClass46_0.NativeFieldInfoPtr_archetypeID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoard.__c__DisplayClass46_0.NativeFieldInfoPtr_archetypeID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002D07 RID: 11527
			private static readonly IntPtr NativeFieldInfoPtr_archetypeID;

			// Token: 0x04002D08 RID: 11528
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002D09 RID: 11529
			private static readonly IntPtr NativeMethodInfoPtr__FindSpace_b__0_Internal_Boolean_WormSpace_0;
		}

		// Token: 0x0200058E RID: 1422
		[ObfuscatedName("worm.canis.entities.WormBoard+<>c__DisplayClass47_0")]
		public sealed class __c__DisplayClass47_0 : Object
		{
			// Token: 0x0600442B RID: 17451 RVA: 0x00181748 File Offset: 0x0017F948
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass47_0()
			{
				Il2CppClassPointerStore<WormBoard.__c__DisplayClass47_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormBoard>.NativeClassPtr, "<>c__DisplayClass47_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormBoard.__c__DisplayClass47_0>.NativeClassPtr);
				WormBoard.__c__DisplayClass47_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBoard.__c__DisplayClass47_0>.NativeClassPtr, "player");
				WormBoard.__c__DisplayClass47_0.NativeFieldInfoPtr_agentCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBoard.__c__DisplayClass47_0>.NativeClassPtr, "agentCard");
				WormBoard.__c__DisplayClass47_0.NativeFieldInfoPtr_graftedCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBoard.__c__DisplayClass47_0>.NativeClassPtr, "graftedCard");
				WormBoard.__c__DisplayClass47_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBoard.__c__DisplayClass47_0>.NativeClassPtr, "<>4__this");
				WormBoard.__c__DisplayClass47_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBoard.__c__DisplayClass47_0>.NativeClassPtr, "<>9__1");
				WormBoard.__c__DisplayClass47_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoard.__c__DisplayClass47_0>.NativeClassPtr, 100663971);
				WormBoard.__c__DisplayClass47_0.NativeMethodInfoPtr__ValidSpaces_b__0_Internal_Boolean_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoard.__c__DisplayClass47_0>.NativeClassPtr, 100663972);
				WormBoard.__c__DisplayClass47_0.NativeMethodInfoPtr__ValidSpaces_b__1_Internal_Boolean_SpaceAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoard.__c__DisplayClass47_0>.NativeClassPtr, 100663973);
			}

			// Token: 0x0600442C RID: 17452 RVA: 0x00181814 File Offset: 0x0017FA14
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass47_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormBoard.__c__DisplayClass47_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoard.__c__DisplayClass47_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600442D RID: 17453 RVA: 0x00181850 File Offset: 0x0017FA50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34702, XrefRangeEnd = 34729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ValidSpaces_b__0(WormSpace space)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(space);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoard.__c__DisplayClass47_0.NativeMethodInfoPtr__ValidSpaces_b__0_Internal_Boolean_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600442E RID: 17454 RVA: 0x001818A0 File Offset: 0x0017FAA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34729, XrefRangeEnd = 34739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ValidSpaces_b__1(SpaceAbility spaceAbility)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(spaceAbility);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoard.__c__DisplayClass47_0.NativeMethodInfoPtr__ValidSpaces_b__1_Internal_Boolean_SpaceAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600442F RID: 17455 RVA: 0x0001667B File Offset: 0x0001487B
			public __c__DisplayClass47_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700102E RID: 4142
			// (get) Token: 0x06004430 RID: 17456 RVA: 0x001818F0 File Offset: 0x0017FAF0
			// (set) Token: 0x06004431 RID: 17457 RVA: 0x00016684 File Offset: 0x00014884
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoard.__c__DisplayClass47_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoard.__c__DisplayClass47_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700102F RID: 4143
			// (get) Token: 0x06004432 RID: 17458 RVA: 0x00181920 File Offset: 0x0017FB20
			// (set) Token: 0x06004433 RID: 17459 RVA: 0x000166A3 File Offset: 0x000148A3
			public unsafe WormImperiumPlayable agentCard
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoard.__c__DisplayClass47_0.NativeFieldInfoPtr_agentCard);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoard.__c__DisplayClass47_0.NativeFieldInfoPtr_agentCard), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001030 RID: 4144
			// (get) Token: 0x06004434 RID: 17460 RVA: 0x00181950 File Offset: 0x0017FB50
			// (set) Token: 0x06004435 RID: 17461 RVA: 0x000166C2 File Offset: 0x000148C2
			public unsafe WormImperiumPlayable graftedCard
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoard.__c__DisplayClass47_0.NativeFieldInfoPtr_graftedCard);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoard.__c__DisplayClass47_0.NativeFieldInfoPtr_graftedCard), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001031 RID: 4145
			// (get) Token: 0x06004436 RID: 17462 RVA: 0x00181980 File Offset: 0x0017FB80
			// (set) Token: 0x06004437 RID: 17463 RVA: 0x000166E1 File Offset: 0x000148E1
			public unsafe WormBoard __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoard.__c__DisplayClass47_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormBoard>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoard.__c__DisplayClass47_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001032 RID: 4146
			// (get) Token: 0x06004438 RID: 17464 RVA: 0x001819B0 File Offset: 0x0017FBB0
			// (set) Token: 0x06004439 RID: 17465 RVA: 0x00016700 File Offset: 0x00014900
			public unsafe Func<SpaceAbility, bool> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoard.__c__DisplayClass47_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpaceAbility, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoard.__c__DisplayClass47_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002D0A RID: 11530
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04002D0B RID: 11531
			private static readonly IntPtr NativeFieldInfoPtr_agentCard;

			// Token: 0x04002D0C RID: 11532
			private static readonly IntPtr NativeFieldInfoPtr_graftedCard;

			// Token: 0x04002D0D RID: 11533
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002D0E RID: 11534
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x04002D0F RID: 11535
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002D10 RID: 11536
			private static readonly IntPtr NativeMethodInfoPtr__ValidSpaces_b__0_Internal_Boolean_WormSpace_0;

			// Token: 0x04002D11 RID: 11537
			private static readonly IntPtr NativeMethodInfoPtr__ValidSpaces_b__1_Internal_Boolean_SpaceAbility_0;
		}

		// Token: 0x0200058F RID: 1423
		[ObfuscatedName("worm.canis.entities.WormBoard+<>c__DisplayClass48_0")]
		public sealed class __c__DisplayClass48_0 : Object
		{
			// Token: 0x0600443A RID: 17466 RVA: 0x001819E0 File Offset: 0x0017FBE0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass48_0()
			{
				Il2CppClassPointerStore<WormBoard.__c__DisplayClass48_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormBoard>.NativeClassPtr, "<>c__DisplayClass48_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormBoard.__c__DisplayClass48_0>.NativeClassPtr);
				WormBoard.__c__DisplayClass48_0.NativeFieldInfoPtr_faction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBoard.__c__DisplayClass48_0>.NativeClassPtr, "faction");
				WormBoard.__c__DisplayClass48_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoard.__c__DisplayClass48_0>.NativeClassPtr, 100663974);
				WormBoard.__c__DisplayClass48_0.NativeMethodInfoPtr__GetTrackForFaction_b__0_Internal_Boolean_WormFactionTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoard.__c__DisplayClass48_0>.NativeClassPtr, 100663975);
			}

			// Token: 0x0600443B RID: 17467 RVA: 0x00181A48 File Offset: 0x0017FC48
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass48_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormBoard.__c__DisplayClass48_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoard.__c__DisplayClass48_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600443C RID: 17468 RVA: 0x00181A84 File Offset: 0x0017FC84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34739, XrefRangeEnd = 34746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetTrackForFaction_b__0(WormFactionTrack _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoard.__c__DisplayClass48_0.NativeMethodInfoPtr__GetTrackForFaction_b__0_Internal_Boolean_WormFactionTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600443D RID: 17469 RVA: 0x0001671F File Offset: 0x0001491F
			public __c__DisplayClass48_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001033 RID: 4147
			// (get) Token: 0x0600443E RID: 17470 RVA: 0x00181AD4 File Offset: 0x0017FCD4
			// (set) Token: 0x0600443F RID: 17471 RVA: 0x00016728 File Offset: 0x00014928
			public unsafe Factions faction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoard.__c__DisplayClass48_0.NativeFieldInfoPtr_faction);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoard.__c__DisplayClass48_0.NativeFieldInfoPtr_faction)) = value;
				}
			}

			// Token: 0x04002D12 RID: 11538
			private static readonly IntPtr NativeFieldInfoPtr_faction;

			// Token: 0x04002D13 RID: 11539
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002D14 RID: 11540
			private static readonly IntPtr NativeMethodInfoPtr__GetTrackForFaction_b__0_Internal_Boolean_WormFactionTrack_0;
		}
	}
}
