using System;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using worm.canis.data.enums;

namespace worm.canis.entities
{
	// Token: 0x02000028 RID: 40
	public static class WormEntityExtensions : Object
	{
		// Token: 0x06000354 RID: 852 RVA: 0x00076308 File Offset: 0x00074508
		// Note: this type is marked as 'beforefieldinit'.
		static WormEntityExtensions()
		{
			Il2CppClassPointerStore<WormEntityExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.entities", "WormEntityExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEntityExtensions>.NativeClassPtr);
			WormEntityExtensions.NativeMethodInfoPtr_ArchID_Public_Static_ArchetypeID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityExtensions>.NativeClassPtr, 100664023);
			WormEntityExtensions.NativeMethodInfoPtr_VictoryPoints_Public_Static_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityExtensions>.NativeClassPtr, 100664024);
			WormEntityExtensions.NativeMethodInfoPtr_Faction_Public_Static_Factions_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityExtensions>.NativeClassPtr, 100664025);
			WormEntityExtensions.NativeMethodInfoPtr_FactionsList_Public_Static_List_1_Factions_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityExtensions>.NativeClassPtr, 100664026);
			WormEntityExtensions.NativeMethodInfoPtr_ActionIcon_Public_Static_AgentIcons_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityExtensions>.NativeClassPtr, 100664027);
			WormEntityExtensions.NativeMethodInfoPtr_IconList_Public_Static_List_1_AgentIcons_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityExtensions>.NativeClassPtr, 100664028);
			WormEntityExtensions.NativeMethodInfoPtr_Color_Public_Static_PieceColor_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityExtensions>.NativeClassPtr, 100664029);
			WormEntityExtensions.NativeMethodInfoPtr_IsExhausted_Public_Static_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityExtensions>.NativeClassPtr, 100664030);
			WormEntityExtensions.NativeMethodInfoPtr_IsDisabled_Public_Static_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityExtensions>.NativeClassPtr, 100664031);
			WormEntityExtensions.NativeMethodInfoPtr_IsCombatSpace_Public_Static_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityExtensions>.NativeClassPtr, 100664032);
			WormEntityExtensions.NativeMethodInfoPtr_Spice_Public_Static_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityExtensions>.NativeClassPtr, 100664033);
			WormEntityExtensions.NativeMethodInfoPtr_BonusSpice_Public_Static_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityExtensions>.NativeClassPtr, 100664034);
			WormEntityExtensions.NativeMethodInfoPtr_SpiceCost_Public_Static_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityExtensions>.NativeClassPtr, 100664035);
			WormEntityExtensions.NativeMethodInfoPtr_Water_Public_Static_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityExtensions>.NativeClassPtr, 100664036);
			WormEntityExtensions.NativeMethodInfoPtr_WaterCost_Public_Static_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityExtensions>.NativeClassPtr, 100664037);
			WormEntityExtensions.NativeMethodInfoPtr_Solari_Public_Static_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityExtensions>.NativeClassPtr, 100664038);
			WormEntityExtensions.NativeMethodInfoPtr_SolariCost_Public_Static_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityExtensions>.NativeClassPtr, 100664039);
			WormEntityExtensions.NativeMethodInfoPtr_SolariDiscount_Public_Static_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityExtensions>.NativeClassPtr, 100664040);
			WormEntityExtensions.NativeMethodInfoPtr_Troops_Public_Static_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityExtensions>.NativeClassPtr, 100664041);
			WormEntityExtensions.NativeMethodInfoPtr_AgentTroops_Public_Static_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityExtensions>.NativeClassPtr, 100664042);
			WormEntityExtensions.NativeMethodInfoPtr_Persuasion_Public_Static_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityExtensions>.NativeClassPtr, 100664043);
			WormEntityExtensions.NativeMethodInfoPtr_Strength_Public_Static_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityExtensions>.NativeClassPtr, 100664044);
			WormEntityExtensions.NativeMethodInfoPtr_Specimens_Public_Static_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityExtensions>.NativeClassPtr, 100664045);
			WormEntityExtensions.NativeMethodInfoPtr_AgentSpecimens_Public_Static_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityExtensions>.NativeClassPtr, 100664046);
			WormEntityExtensions.NativeMethodInfoPtr_SpecimenCost_Public_Static_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityExtensions>.NativeClassPtr, 100664047);
			WormEntityExtensions.NativeMethodInfoPtr_IsImperiumType_Public_Static_Boolean_Entity_ImperiumTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityExtensions>.NativeClassPtr, 100664048);
			WormEntityExtensions.NativeMethodInfoPtr_IsMakerSpace_Public_Static_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityExtensions>.NativeClassPtr, 100664049);
			WormEntityExtensions.NativeMethodInfoPtr_Tags_Public_Static_List_1_CardTags_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityExtensions>.NativeClassPtr, 100664050);
			WormEntityExtensions.NativeMethodInfoPtr_NameForCheats_Public_Static_String_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityExtensions>.NativeClassPtr, 100664051);
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0007657C File Offset: 0x0007477C
		[CallerCount(543)]
		[CachedScanResults(RefRangeStart = 36005, RefRangeEnd = 36548, XrefRangeStart = 35993, XrefRangeEnd = 36005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ArchetypeID ArchID(this Entity ent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntityExtensions.NativeMethodInfoPtr_ArchID_Public_Static_ArchetypeID_Entity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
			}
		}

		// Token: 0x06000356 RID: 854 RVA: 0x000765C0 File Offset: 0x000747C0
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 36556, RefRangeEnd = 36588, XrefRangeStart = 36548, XrefRangeEnd = 36556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int VictoryPoints(this Entity ent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntityExtensions.NativeMethodInfoPtr_VictoryPoints_Public_Static_Int32_Entity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00076604 File Offset: 0x00074804
		[CallerCount(166)]
		[CachedScanResults(RefRangeStart = 36596, RefRangeEnd = 36762, XrefRangeStart = 36588, XrefRangeEnd = 36596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Factions Faction(this Entity ent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntityExtensions.NativeMethodInfoPtr_Faction_Public_Static_Factions_Entity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00076648 File Offset: 0x00074848
		[CallerCount(71)]
		[CachedScanResults(RefRangeStart = 36776, RefRangeEnd = 36847, XrefRangeStart = 36762, XrefRangeEnd = 36776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Factions> FactionsList(this Entity ent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntityExtensions.NativeMethodInfoPtr_FactionsList_Public_Static_List_1_Factions_Entity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Factions>>(intPtr3) : null;
			}
		}

		// Token: 0x06000359 RID: 857 RVA: 0x0007668C File Offset: 0x0007488C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 36855, RefRangeEnd = 36869, XrefRangeStart = 36847, XrefRangeEnd = 36855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AgentIcons ActionIcon(this Entity ent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntityExtensions.NativeMethodInfoPtr_ActionIcon_Public_Static_AgentIcons_Entity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600035A RID: 858 RVA: 0x000766D0 File Offset: 0x000748D0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 36883, RefRangeEnd = 36895, XrefRangeStart = 36869, XrefRangeEnd = 36883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<AgentIcons> IconList(this Entity ent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntityExtensions.NativeMethodInfoPtr_IconList_Public_Static_List_1_AgentIcons_Entity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<AgentIcons>>(intPtr3) : null;
			}
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00076714 File Offset: 0x00074914
		[CallerCount(57)]
		[CachedScanResults(RefRangeStart = 36903, RefRangeEnd = 36960, XrefRangeStart = 36895, XrefRangeEnd = 36903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PieceColor Color(this Entity ent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntityExtensions.NativeMethodInfoPtr_Color_Public_Static_PieceColor_Entity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00076758 File Offset: 0x00074958
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 36968, RefRangeEnd = 36997, XrefRangeStart = 36960, XrefRangeEnd = 36968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsExhausted(this Entity ent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntityExtensions.NativeMethodInfoPtr_IsExhausted_Public_Static_Boolean_Entity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0007679C File Offset: 0x0007499C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 37005, RefRangeEnd = 37006, XrefRangeStart = 36997, XrefRangeEnd = 37005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDisabled(this Entity ent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntityExtensions.NativeMethodInfoPtr_IsDisabled_Public_Static_Boolean_Entity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600035E RID: 862 RVA: 0x000767E0 File Offset: 0x000749E0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 37014, RefRangeEnd = 37025, XrefRangeStart = 37006, XrefRangeEnd = 37014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsCombatSpace(this Entity ent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntityExtensions.NativeMethodInfoPtr_IsCombatSpace_Public_Static_Boolean_Entity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00076824 File Offset: 0x00074A24
		[CallerCount(58)]
		[CachedScanResults(RefRangeStart = 37033, RefRangeEnd = 37091, XrefRangeStart = 37025, XrefRangeEnd = 37033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Spice(this Entity ent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntityExtensions.NativeMethodInfoPtr_Spice_Public_Static_Int32_Entity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00076868 File Offset: 0x00074A68
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 37099, RefRangeEnd = 37106, XrefRangeStart = 37091, XrefRangeEnd = 37099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int BonusSpice(this Entity ent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntityExtensions.NativeMethodInfoPtr_BonusSpice_Public_Static_Int32_Entity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000361 RID: 865 RVA: 0x000768AC File Offset: 0x00074AAC
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 37114, RefRangeEnd = 37136, XrefRangeStart = 37106, XrefRangeEnd = 37114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SpiceCost(this Entity ent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntityExtensions.NativeMethodInfoPtr_SpiceCost_Public_Static_Int32_Entity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000362 RID: 866 RVA: 0x000768F0 File Offset: 0x00074AF0
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 37144, RefRangeEnd = 37160, XrefRangeStart = 37136, XrefRangeEnd = 37144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Water(this Entity ent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntityExtensions.NativeMethodInfoPtr_Water_Public_Static_Int32_Entity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00076934 File Offset: 0x00074B34
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 37168, RefRangeEnd = 37172, XrefRangeStart = 37160, XrefRangeEnd = 37168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int WaterCost(this Entity ent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntityExtensions.NativeMethodInfoPtr_WaterCost_Public_Static_Int32_Entity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00076978 File Offset: 0x00074B78
		[CallerCount(46)]
		[CachedScanResults(RefRangeStart = 37180, RefRangeEnd = 37226, XrefRangeStart = 37172, XrefRangeEnd = 37180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Solari(this Entity ent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntityExtensions.NativeMethodInfoPtr_Solari_Public_Static_Int32_Entity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000365 RID: 869 RVA: 0x000769BC File Offset: 0x00074BBC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 37234, RefRangeEnd = 37239, XrefRangeStart = 37226, XrefRangeEnd = 37234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SolariCost(this Entity ent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntityExtensions.NativeMethodInfoPtr_SolariCost_Public_Static_Int32_Entity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00076A00 File Offset: 0x00074C00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 37247, RefRangeEnd = 37249, XrefRangeStart = 37239, XrefRangeEnd = 37247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SolariDiscount(this Entity ent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntityExtensions.NativeMethodInfoPtr_SolariDiscount_Public_Static_Int32_Entity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00076A44 File Offset: 0x00074C44
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 37257, RefRangeEnd = 37268, XrefRangeStart = 37249, XrefRangeEnd = 37257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Troops(this Entity ent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntityExtensions.NativeMethodInfoPtr_Troops_Public_Static_Int32_Entity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00076A88 File Offset: 0x00074C88
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 37276, RefRangeEnd = 37282, XrefRangeStart = 37268, XrefRangeEnd = 37276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int AgentTroops(this Entity ent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntityExtensions.NativeMethodInfoPtr_AgentTroops_Public_Static_Int32_Entity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00076ACC File Offset: 0x00074CCC
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 37290, RefRangeEnd = 37307, XrefRangeStart = 37282, XrefRangeEnd = 37290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Persuasion(this Entity ent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntityExtensions.NativeMethodInfoPtr_Persuasion_Public_Static_Int32_Entity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00076B10 File Offset: 0x00074D10
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 37315, RefRangeEnd = 37327, XrefRangeStart = 37307, XrefRangeEnd = 37315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Strength(this Entity ent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntityExtensions.NativeMethodInfoPtr_Strength_Public_Static_Int32_Entity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00076B54 File Offset: 0x00074D54
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 37342, RefRangeEnd = 37354, XrefRangeStart = 37327, XrefRangeEnd = 37342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Specimens(this Entity ent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntityExtensions.NativeMethodInfoPtr_Specimens_Public_Static_Int32_Entity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00076B98 File Offset: 0x00074D98
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 37362, RefRangeEnd = 37367, XrefRangeStart = 37354, XrefRangeEnd = 37362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int AgentSpecimens(this Entity ent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntityExtensions.NativeMethodInfoPtr_AgentSpecimens_Public_Static_Int32_Entity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00076BDC File Offset: 0x00074DDC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 37375, RefRangeEnd = 37381, XrefRangeStart = 37367, XrefRangeEnd = 37375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SpecimenCost(this Entity ent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntityExtensions.NativeMethodInfoPtr_SpecimenCost_Public_Static_Int32_Entity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00076C20 File Offset: 0x00074E20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 37393, RefRangeEnd = 37394, XrefRangeStart = 37381, XrefRangeEnd = 37393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsImperiumType(this Entity ent, ImperiumTypes type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntityExtensions.NativeMethodInfoPtr_IsImperiumType_Public_Static_Boolean_Entity_ImperiumTypes_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00076C70 File Offset: 0x00074E70
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 37405, RefRangeEnd = 37410, XrefRangeStart = 37394, XrefRangeEnd = 37405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsMakerSpace(this Entity ent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntityExtensions.NativeMethodInfoPtr_IsMakerSpace_Public_Static_Boolean_Entity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00076CB4 File Offset: 0x00074EB4
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 37424, RefRangeEnd = 37438, XrefRangeStart = 37410, XrefRangeEnd = 37424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<CardTags> Tags(this Entity ent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntityExtensions.NativeMethodInfoPtr_Tags_Public_Static_List_1_CardTags_Entity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<CardTags>>(intPtr3) : null;
			}
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00076CF8 File Offset: 0x00074EF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37438, XrefRangeEnd = 37450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string NameForCheats(this Entity ent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntityExtensions.NativeMethodInfoPtr_NameForCheats_Public_Static_String_Entity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000372 RID: 882 RVA: 0x000036BB File Offset: 0x000018BB
		public WormEntityExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000255 RID: 597
		private static readonly IntPtr NativeMethodInfoPtr_ArchID_Public_Static_ArchetypeID_Entity_0;

		// Token: 0x04000256 RID: 598
		private static readonly IntPtr NativeMethodInfoPtr_VictoryPoints_Public_Static_Int32_Entity_0;

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeMethodInfoPtr_Faction_Public_Static_Factions_Entity_0;

		// Token: 0x04000258 RID: 600
		private static readonly IntPtr NativeMethodInfoPtr_FactionsList_Public_Static_List_1_Factions_Entity_0;

		// Token: 0x04000259 RID: 601
		private static readonly IntPtr NativeMethodInfoPtr_ActionIcon_Public_Static_AgentIcons_Entity_0;

		// Token: 0x0400025A RID: 602
		private static readonly IntPtr NativeMethodInfoPtr_IconList_Public_Static_List_1_AgentIcons_Entity_0;

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeMethodInfoPtr_Color_Public_Static_PieceColor_Entity_0;

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeMethodInfoPtr_IsExhausted_Public_Static_Boolean_Entity_0;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeMethodInfoPtr_IsDisabled_Public_Static_Boolean_Entity_0;

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeMethodInfoPtr_IsCombatSpace_Public_Static_Boolean_Entity_0;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeMethodInfoPtr_Spice_Public_Static_Int32_Entity_0;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeMethodInfoPtr_BonusSpice_Public_Static_Int32_Entity_0;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeMethodInfoPtr_SpiceCost_Public_Static_Int32_Entity_0;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeMethodInfoPtr_Water_Public_Static_Int32_Entity_0;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeMethodInfoPtr_WaterCost_Public_Static_Int32_Entity_0;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeMethodInfoPtr_Solari_Public_Static_Int32_Entity_0;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeMethodInfoPtr_SolariCost_Public_Static_Int32_Entity_0;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeMethodInfoPtr_SolariDiscount_Public_Static_Int32_Entity_0;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeMethodInfoPtr_Troops_Public_Static_Int32_Entity_0;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeMethodInfoPtr_AgentTroops_Public_Static_Int32_Entity_0;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeMethodInfoPtr_Persuasion_Public_Static_Int32_Entity_0;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeMethodInfoPtr_Strength_Public_Static_Int32_Entity_0;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeMethodInfoPtr_Specimens_Public_Static_Int32_Entity_0;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeMethodInfoPtr_AgentSpecimens_Public_Static_Int32_Entity_0;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeMethodInfoPtr_SpecimenCost_Public_Static_Int32_Entity_0;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeMethodInfoPtr_IsImperiumType_Public_Static_Boolean_Entity_ImperiumTypes_0;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeMethodInfoPtr_IsMakerSpace_Public_Static_Boolean_Entity_0;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeMethodInfoPtr_Tags_Public_Static_List_1_CardTags_Entity_0;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeMethodInfoPtr_NameForCheats_Public_Static_String_Entity_0;
	}
}
