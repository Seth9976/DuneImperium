using System;
using System.Runtime.InteropServices;
using Canis.attributes;
using Canis.entities;
using Canis.gameLogs;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using worm.canis.archetypes;
using worm.canis.data.enums;
using worm.canis.entities;

namespace worm.canis.gameLogs
{
	// Token: 0x0200001D RID: 29
	public static class WormGameLogBuilder : Object
	{
		// Token: 0x06000261 RID: 609 RVA: 0x000718BC File Offset: 0x0006FABC
		// Note: this type is marked as 'beforefieldinit'.
		static WormGameLogBuilder()
		{
			Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.gameLogs", "WormGameLogBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr);
			WormGameLogBuilder.NativeFieldInfoPtr_spiceAttrKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, "spiceAttrKeys");
			WormGameLogBuilder.NativeFieldInfoPtr_waterAttrKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, "waterAttrKeys");
			WormGameLogBuilder.NativeFieldInfoPtr_solariAttrKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, "solariAttrKeys");
			WormGameLogBuilder.NativeFieldInfoPtr_persuasionAttrKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, "persuasionAttrKeys");
			WormGameLogBuilder.NativeFieldInfoPtr_strengthAttrKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, "strengthAttrKeys");
			WormGameLogBuilder.NativeMethodInfoPtr_GetResourceString_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, 100663807);
			WormGameLogBuilder.NativeMethodInfoPtr_GetColorString_Private_Static_String_PieceColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, 100663808);
			WormGameLogBuilder.NativeMethodInfoPtr_GetColorString_Private_Static_String_AgentIcons_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, 100663809);
			WormGameLogBuilder.NativeMethodInfoPtr_GetControlMarkerString_Private_Static_String_PieceColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, 100663810);
			WormGameLogBuilder.NativeMethodInfoPtr_GetAgentIconString_Private_Static_String_AgentIcons_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, 100663811);
			WormGameLogBuilder.NativeMethodInfoPtr_GetLeaderString_Public_Static_String_WormLeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, 100663812);
			WormGameLogBuilder.NativeMethodInfoPtr_GetFactionString_Private_Static_String_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, 100663813);
			WormGameLogBuilder.NativeMethodInfoPtr_GetFactionStringWithIcon_Private_Static_String_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, 100663814);
			WormGameLogBuilder.NativeMethodInfoPtr_WithLeader_Public_Static_GameLogBuilder_GameLogBuilder_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, 100663815);
			WormGameLogBuilder.NativeMethodInfoPtr_WithColor_Public_Static_GameLogBuilder_GameLogBuilder_PieceColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, 100663816);
			WormGameLogBuilder.NativeMethodInfoPtr_WithColor_Public_Static_GameLogBuilder_GameLogBuilder_AgentIcons_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, 100663817);
			WormGameLogBuilder.NativeMethodInfoPtr_WithLeader_Public_Static_GameLogBuilder_GameLogBuilder_WormLeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, 100663818);
			WormGameLogBuilder.NativeMethodInfoPtr_WithLeaderTextOnly_Public_Static_GameLogBuilder_GameLogBuilder_WormLeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, 100663819);
			WormGameLogBuilder.NativeMethodInfoPtr_WithArchetypeID_Public_Static_GameLogBuilder_GameLogBuilder_ArchetypeID_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, 100663820);
			WormGameLogBuilder.NativeMethodInfoPtr_UpsertArchetypeIDAttr_Private_Static_GameLogBuilder_GameLogBuilder_Entity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, 100663821);
			WormGameLogBuilder.NativeMethodInfoPtr_UpsertArchetypeIDAttr_Private_Static_GameLogBuilder_GameLogBuilder_WormArchetype_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, 100663822);
			WormGameLogBuilder.NativeMethodInfoPtr_WithCard_Public_Static_GameLogBuilder_GameLogBuilder_WormPlayable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, 100663823);
			WormGameLogBuilder.NativeMethodInfoPtr_WithCardByArchetype_Public_Static_GameLogBuilder_GameLogBuilder_WormArchetype_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, 100663824);
			WormGameLogBuilder.NativeMethodInfoPtr_WithSpace_Public_Static_GameLogBuilder_GameLogBuilder_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, 100663825);
			WormGameLogBuilder.NativeMethodInfoPtr_WithSpaceInternal_Private_Static_GameLogBuilder_GameLogBuilder_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, 100663826);
			WormGameLogBuilder.NativeMethodInfoPtr_WithAgentIcon_Public_Static_GameLogBuilder_GameLogBuilder_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, 100663827);
			WormGameLogBuilder.NativeMethodInfoPtr_WithAgentIcon_Public_Static_GameLogBuilder_GameLogBuilder_AgentIcons_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, 100663828);
			WormGameLogBuilder.NativeMethodInfoPtr_WithAmount_Public_Static_GameLogBuilder_GameLogBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, 100663829);
			WormGameLogBuilder.NativeMethodInfoPtr_WithFaction_Public_Static_GameLogBuilder_GameLogBuilder_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, 100663830);
			WormGameLogBuilder.NativeMethodInfoPtr_WithFactionForSprite_Public_Static_GameLogBuilder_GameLogBuilder_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, 100663831);
			WormGameLogBuilder.NativeMethodInfoPtr_WithPlace_Public_Static_GameLogBuilder_GameLogBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, 100663832);
			WormGameLogBuilder.NativeMethodInfoPtr_WithControlMarker_Public_Static_GameLogBuilder_GameLogBuilder_WormEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, 100663833);
			WormGameLogBuilder.NativeMethodInfoPtr_AsTopLevel_Public_Static_GameLogBuilder_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, 100663834);
			WormGameLogBuilder.NativeMethodInfoPtr_ReplaceToken_Public_Static_GameLogBuilder_GameLogBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, 100663835);
			WormGameLogBuilder.NativeMethodInfoPtr_WithSignetRing_Public_Static_GameLogBuilder_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, 100663836);
			WormGameLogBuilder.NativeMethodInfoPtr_WithResourceAmount_Public_Static_GameLogBuilder_GameLogBuilder_AttributeDefinition_1_Nullable_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, 100663837);
			WormGameLogBuilder.NativeMethodInfoPtr_WithLogTemplate_Public_Static_GameLogBuilder_GameLogBuilder_LogTemplates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, 100663838);
			WormGameLogBuilder.NativeMethodInfoPtr_WithLogTemplateByPlayerTurn_Public_Static_GameLogBuilder_GameLogBuilder_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, 100663839);
			WormGameLogBuilder.NativeMethodInfoPtr_WithImage_Public_Static_GameLogBuilder_GameLogBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, 100663840);
			WormGameLogBuilder.NativeMethodInfoPtr_WithCurrentTurnPlayer_Public_Static_GameLogBuilder_GameLogBuilder_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, 100663841);
			WormGameLogBuilder.NativeMethodInfoPtr_WithFactionSpriteList_Public_Static_GameLogBuilder_GameLogBuilder_List_1_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, 100663842);
			WormGameLogBuilder.NativeMethodInfoPtr_WithLeaderList_Public_Static_GameLogBuilder_GameLogBuilder_List_1_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, 100663843);
			WormGameLogBuilder.NativeMethodInfoPtr_Method_Internal_Static_String_byref___c__DisplayClass35_0_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, 100663845);
			WormGameLogBuilder.NativeMethodInfoPtr_Method_Internal_Static_String_byref___c__DisplayClass41_0_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, 100663846);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00071C5C File Offset: 0x0006FE5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31991, XrefRangeEnd = 31996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetResourceString(string resource)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(resource);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameLogBuilder.NativeMethodInfoPtr_GetResourceString_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00071C98 File Offset: 0x0006FE98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31996, XrefRangeEnd = 32003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetColorString(PieceColor color)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameLogBuilder.NativeMethodInfoPtr_GetColorString_Private_Static_String_PieceColor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00071CD0 File Offset: 0x0006FED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32003, XrefRangeEnd = 32012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetColorString(AgentIcons color)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameLogBuilder.NativeMethodInfoPtr_GetColorString_Private_Static_String_AgentIcons_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00071D08 File Offset: 0x0006FF08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32012, XrefRangeEnd = 32019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetControlMarkerString(PieceColor color)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameLogBuilder.NativeMethodInfoPtr_GetControlMarkerString_Private_Static_String_PieceColor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00071D40 File Offset: 0x0006FF40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32019, XrefRangeEnd = 32025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetAgentIconString(AgentIcons icon)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref icon;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameLogBuilder.NativeMethodInfoPtr_GetAgentIconString_Private_Static_String_AgentIcons_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00071D78 File Offset: 0x0006FF78
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 32047, RefRangeEnd = 32051, XrefRangeStart = 32025, XrefRangeEnd = 32047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetLeaderString(WormLeader leader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(leader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameLogBuilder.NativeMethodInfoPtr_GetLeaderString_Public_Static_String_WormLeader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00071DB4 File Offset: 0x0006FFB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32051, XrefRangeEnd = 32058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFactionString(Factions faction)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref faction;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameLogBuilder.NativeMethodInfoPtr_GetFactionString_Private_Static_String_Factions_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00071DEC File Offset: 0x0006FFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32058, XrefRangeEnd = 32067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFactionStringWithIcon(Factions faction)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref faction;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameLogBuilder.NativeMethodInfoPtr_GetFactionStringWithIcon_Private_Static_String_Factions_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00071E24 File Offset: 0x00070024
		[CallerCount(109)]
		[CachedScanResults(RefRangeStart = 32118, RefRangeEnd = 32227, XrefRangeStart = 32067, XrefRangeEnd = 32118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameLogBuilder WithLeader(this GameLogBuilder gameLogBuilder, WormPlayer player)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameLogBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameLogBuilder.NativeMethodInfoPtr_WithLeader_Public_Static_GameLogBuilder_GameLogBuilder_WormPlayer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00071E7C File Offset: 0x0007007C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32227, XrefRangeEnd = 32240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameLogBuilder WithColor(this GameLogBuilder gameLogBuilder, PieceColor color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameLogBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameLogBuilder.NativeMethodInfoPtr_WithColor_Public_Static_GameLogBuilder_GameLogBuilder_PieceColor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00071ED0 File Offset: 0x000700D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32240, XrefRangeEnd = 32255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameLogBuilder WithColor(this GameLogBuilder gameLogBuilder, AgentIcons color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameLogBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameLogBuilder.NativeMethodInfoPtr_WithColor_Public_Static_GameLogBuilder_GameLogBuilder_AgentIcons_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00071F24 File Offset: 0x00070124
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 32284, RefRangeEnd = 32285, XrefRangeStart = 32255, XrefRangeEnd = 32284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameLogBuilder WithLeader(this GameLogBuilder gameLogBuilder, WormLeader leader)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameLogBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(leader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameLogBuilder.NativeMethodInfoPtr_WithLeader_Public_Static_GameLogBuilder_GameLogBuilder_WormLeader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00071F7C File Offset: 0x0007017C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 32293, RefRangeEnd = 32302, XrefRangeStart = 32285, XrefRangeEnd = 32293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameLogBuilder WithLeaderTextOnly(this GameLogBuilder gameLogBuilder, WormLeader leader)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameLogBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(leader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameLogBuilder.NativeMethodInfoPtr_WithLeaderTextOnly_Public_Static_GameLogBuilder_GameLogBuilder_WormLeader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00071FD4 File Offset: 0x000701D4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 32336, RefRangeEnd = 32347, XrefRangeStart = 32302, XrefRangeEnd = 32336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameLogBuilder WithArchetypeID(this GameLogBuilder gameLogBuilder, ArchetypeID archID, bool first = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameLogBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(archID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref first;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameLogBuilder.NativeMethodInfoPtr_WithArchetypeID_Public_Static_GameLogBuilder_GameLogBuilder_ArchetypeID_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00072038 File Offset: 0x00070238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32347, XrefRangeEnd = 32352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameLogBuilder UpsertArchetypeIDAttr(this GameLogBuilder gameLogBuilder, Entity entity, bool first = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameLogBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entity);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref first;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameLogBuilder.NativeMethodInfoPtr_UpsertArchetypeIDAttr_Private_Static_GameLogBuilder_GameLogBuilder_Entity_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0007209C File Offset: 0x0007029C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32352, XrefRangeEnd = 32356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameLogBuilder UpsertArchetypeIDAttr(this GameLogBuilder gameLogBuilder, WormArchetype archetype, bool first = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameLogBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(archetype);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref first;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameLogBuilder.NativeMethodInfoPtr_UpsertArchetypeIDAttr_Private_Static_GameLogBuilder_GameLogBuilder_WormArchetype_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00072100 File Offset: 0x00070300
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 32378, RefRangeEnd = 32526, XrefRangeStart = 32356, XrefRangeEnd = 32378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameLogBuilder WithCard(this GameLogBuilder gameLogBuilder, WormPlayable card, bool first = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameLogBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(card);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref first;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameLogBuilder.NativeMethodInfoPtr_WithCard_Public_Static_GameLogBuilder_GameLogBuilder_WormPlayable_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00072164 File Offset: 0x00070364
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 32547, RefRangeEnd = 32548, XrefRangeStart = 32526, XrefRangeEnd = 32547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameLogBuilder WithCardByArchetype(this GameLogBuilder gameLogBuilder, WormArchetype archetype, bool first = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameLogBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(archetype);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref first;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameLogBuilder.NativeMethodInfoPtr_WithCardByArchetype_Public_Static_GameLogBuilder_GameLogBuilder_WormArchetype_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
		}

		// Token: 0x06000274 RID: 628 RVA: 0x000721C8 File Offset: 0x000703C8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 32565, RefRangeEnd = 32579, XrefRangeStart = 32548, XrefRangeEnd = 32565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameLogBuilder WithSpace(this GameLogBuilder gameLogBuilder, WormSpace space)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameLogBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(space);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameLogBuilder.NativeMethodInfoPtr_WithSpace_Public_Static_GameLogBuilder_GameLogBuilder_WormSpace_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00072220 File Offset: 0x00070420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32579, XrefRangeEnd = 32593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameLogBuilder WithSpaceInternal(this GameLogBuilder gameLogBuilder, WormSpace space)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameLogBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(space);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameLogBuilder.NativeMethodInfoPtr_WithSpaceInternal_Private_Static_GameLogBuilder_GameLogBuilder_WormSpace_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00072278 File Offset: 0x00070478
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 32621, RefRangeEnd = 32622, XrefRangeStart = 32593, XrefRangeEnd = 32621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameLogBuilder WithAgentIcon(this GameLogBuilder gameLogBuilder, WormSpace space)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameLogBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(space);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameLogBuilder.NativeMethodInfoPtr_WithAgentIcon_Public_Static_GameLogBuilder_GameLogBuilder_WormSpace_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
		}

		// Token: 0x06000277 RID: 631 RVA: 0x000722D0 File Offset: 0x000704D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32622, XrefRangeEnd = 32634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameLogBuilder WithAgentIcon(this GameLogBuilder gameLogBuilder, AgentIcons icon)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameLogBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref icon;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameLogBuilder.NativeMethodInfoPtr_WithAgentIcon_Public_Static_GameLogBuilder_GameLogBuilder_AgentIcons_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00072324 File Offset: 0x00070524
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 32640, RefRangeEnd = 32692, XrefRangeStart = 32634, XrefRangeEnd = 32640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameLogBuilder WithAmount(this GameLogBuilder gameLogBuilder, int amount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameLogBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameLogBuilder.NativeMethodInfoPtr_WithAmount_Public_Static_GameLogBuilder_GameLogBuilder_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00072378 File Offset: 0x00070578
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 32705, RefRangeEnd = 32730, XrefRangeStart = 32692, XrefRangeEnd = 32705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameLogBuilder WithFaction(this GameLogBuilder gameLogBuilder, Factions faction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameLogBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref faction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameLogBuilder.NativeMethodInfoPtr_WithFaction_Public_Static_GameLogBuilder_GameLogBuilder_Factions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x000723CC File Offset: 0x000705CC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 32736, RefRangeEnd = 32741, XrefRangeStart = 32730, XrefRangeEnd = 32736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameLogBuilder WithFactionForSprite(this GameLogBuilder gameLogBuilder, Factions faction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameLogBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref faction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameLogBuilder.NativeMethodInfoPtr_WithFactionForSprite_Public_Static_GameLogBuilder_GameLogBuilder_Factions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00072420 File Offset: 0x00070620
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 32747, RefRangeEnd = 32748, XrefRangeStart = 32741, XrefRangeEnd = 32747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameLogBuilder WithPlace(this GameLogBuilder gameLogBuilder, int place)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameLogBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref place;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameLogBuilder.NativeMethodInfoPtr_WithPlace_Public_Static_GameLogBuilder_GameLogBuilder_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00072474 File Offset: 0x00070674
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 32773, RefRangeEnd = 32774, XrefRangeStart = 32748, XrefRangeEnd = 32773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameLogBuilder WithControlMarker(this GameLogBuilder gameLogBuilder, WormEntity marker)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameLogBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(marker);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameLogBuilder.NativeMethodInfoPtr_WithControlMarker_Public_Static_GameLogBuilder_GameLogBuilder_WormEntity_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x000724CC File Offset: 0x000706CC
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 32774, RefRangeEnd = 32810, XrefRangeStart = 32774, XrefRangeEnd = 32774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameLogBuilder AsTopLevel(this GameLogBuilder gameLogBuilder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameLogBuilder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameLogBuilder.NativeMethodInfoPtr_AsTopLevel_Public_Static_GameLogBuilder_GameLogBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00072510 File Offset: 0x00070710
		[CallerCount(45)]
		[CachedScanResults(RefRangeStart = 32811, RefRangeEnd = 32856, XrefRangeStart = 32810, XrefRangeEnd = 32811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameLogBuilder ReplaceToken(this GameLogBuilder gameLogBuilder, string logToken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameLogBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(logToken);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameLogBuilder.NativeMethodInfoPtr_ReplaceToken_Public_Static_GameLogBuilder_GameLogBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00072568 File Offset: 0x00070768
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 32862, RefRangeEnd = 32876, XrefRangeStart = 32856, XrefRangeEnd = 32862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameLogBuilder WithSignetRing(this GameLogBuilder gameLogBuilder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameLogBuilder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameLogBuilder.NativeMethodInfoPtr_WithSignetRing_Public_Static_GameLogBuilder_GameLogBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x000725AC File Offset: 0x000707AC
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 32960, RefRangeEnd = 32996, XrefRangeStart = 32876, XrefRangeEnd = 32960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameLogBuilder WithResourceAmount(this GameLogBuilder gameLogBuilder, AttributeDefinition<Nullable<int>> resourceAttr, int amount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameLogBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resourceAttr);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameLogBuilder.NativeMethodInfoPtr_WithResourceAmount_Public_Static_GameLogBuilder_GameLogBuilder_AttributeDefinition_1_Nullable_1_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00072610 File Offset: 0x00070810
		[CallerCount(191)]
		[CachedScanResults(RefRangeStart = 33009, RefRangeEnd = 33200, XrefRangeStart = 32996, XrefRangeEnd = 33009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameLogBuilder WithLogTemplate(this GameLogBuilder gameLogBuilder, LogTemplates template = LogTemplates.Generic)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameLogBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref template;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameLogBuilder.NativeMethodInfoPtr_WithLogTemplate_Public_Static_GameLogBuilder_GameLogBuilder_LogTemplates_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00072664 File Offset: 0x00070864
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 33214, RefRangeEnd = 33219, XrefRangeStart = 33200, XrefRangeEnd = 33214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameLogBuilder WithLogTemplateByPlayerTurn(this GameLogBuilder gameLogBuilder, WormPlayer player)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameLogBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameLogBuilder.NativeMethodInfoPtr_WithLogTemplateByPlayerTurn_Public_Static_GameLogBuilder_GameLogBuilder_WormPlayer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x000726BC File Offset: 0x000708BC
		[CallerCount(84)]
		[CachedScanResults(RefRangeStart = 33229, RefRangeEnd = 33313, XrefRangeStart = 33219, XrefRangeEnd = 33229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameLogBuilder WithImage(this GameLogBuilder gameLogBuilder, string imageStr = "")
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameLogBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(imageStr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameLogBuilder.NativeMethodInfoPtr_WithImage_Public_Static_GameLogBuilder_GameLogBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00072714 File Offset: 0x00070914
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 33323, RefRangeEnd = 33341, XrefRangeStart = 33313, XrefRangeEnd = 33323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameLogBuilder WithCurrentTurnPlayer(this GameLogBuilder gameLogBuilder, WormPlayer player)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameLogBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameLogBuilder.NativeMethodInfoPtr_WithCurrentTurnPlayer_Public_Static_GameLogBuilder_GameLogBuilder_WormPlayer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0007276C File Offset: 0x0007096C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33376, RefRangeEnd = 33377, XrefRangeStart = 33341, XrefRangeEnd = 33376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameLogBuilder WithFactionSpriteList(this GameLogBuilder gameLogBuilder, List<Factions> factionList)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameLogBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(factionList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameLogBuilder.NativeMethodInfoPtr_WithFactionSpriteList_Public_Static_GameLogBuilder_GameLogBuilder_List_1_Factions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x000727C4 File Offset: 0x000709C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 33437, RefRangeEnd = 33440, XrefRangeStart = 33377, XrefRangeEnd = 33437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameLogBuilder WithLeaderList(this GameLogBuilder gameLogBuilder, List<WormPlayer> playerList)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameLogBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameLogBuilder.NativeMethodInfoPtr_WithLeaderList_Public_Static_GameLogBuilder_GameLogBuilder_List_1_WormPlayer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0007281C File Offset: 0x00070A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33440, XrefRangeEnd = 33446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Method_Internal_Static_String_byref___c__DisplayClass35_0_PDM_0(ref WormGameLogBuilder.__c__DisplayClass35_0 A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &A_0;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameLogBuilder.NativeMethodInfoPtr_Method_Internal_Static_String_byref___c__DisplayClass35_0_PDM_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00072854 File Offset: 0x00070A54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33446, XrefRangeEnd = 33452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Method_Internal_Static_String_byref___c__DisplayClass41_0_PDM_0(ref WormGameLogBuilder.__c__DisplayClass41_0 A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &A_0;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameLogBuilder.NativeMethodInfoPtr_Method_Internal_Static_String_byref___c__DisplayClass41_0_PDM_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0000344F File Offset: 0x0000164F
		public WormGameLogBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600028A RID: 650 RVA: 0x0007288C File Offset: 0x00070A8C
		// (set) Token: 0x0600028B RID: 651 RVA: 0x00003458 File Offset: 0x00001658
		public unsafe static HashSet<int> spiceAttrKeys
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormGameLogBuilder.NativeFieldInfoPtr_spiceAttrKeys, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormGameLogBuilder.NativeFieldInfoPtr_spiceAttrKeys, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600028C RID: 652 RVA: 0x000728B4 File Offset: 0x00070AB4
		// (set) Token: 0x0600028D RID: 653 RVA: 0x0000346A File Offset: 0x0000166A
		public unsafe static HashSet<int> waterAttrKeys
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormGameLogBuilder.NativeFieldInfoPtr_waterAttrKeys, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormGameLogBuilder.NativeFieldInfoPtr_waterAttrKeys, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600028E RID: 654 RVA: 0x000728DC File Offset: 0x00070ADC
		// (set) Token: 0x0600028F RID: 655 RVA: 0x0000347C File Offset: 0x0000167C
		public unsafe static HashSet<int> solariAttrKeys
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormGameLogBuilder.NativeFieldInfoPtr_solariAttrKeys, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormGameLogBuilder.NativeFieldInfoPtr_solariAttrKeys, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000290 RID: 656 RVA: 0x00072904 File Offset: 0x00070B04
		// (set) Token: 0x06000291 RID: 657 RVA: 0x0000348E File Offset: 0x0000168E
		public unsafe static HashSet<int> persuasionAttrKeys
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormGameLogBuilder.NativeFieldInfoPtr_persuasionAttrKeys, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormGameLogBuilder.NativeFieldInfoPtr_persuasionAttrKeys, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000292 RID: 658 RVA: 0x0007292C File Offset: 0x00070B2C
		// (set) Token: 0x06000293 RID: 659 RVA: 0x000034A0 File Offset: 0x000016A0
		public unsafe static HashSet<int> strengthAttrKeys
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormGameLogBuilder.NativeFieldInfoPtr_strengthAttrKeys, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormGameLogBuilder.NativeFieldInfoPtr_strengthAttrKeys, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeFieldInfoPtr_spiceAttrKeys;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeFieldInfoPtr_waterAttrKeys;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeFieldInfoPtr_solariAttrKeys;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeFieldInfoPtr_persuasionAttrKeys;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeFieldInfoPtr_strengthAttrKeys;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeMethodInfoPtr_GetResourceString_Private_Static_String_String_0;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeMethodInfoPtr_GetColorString_Private_Static_String_PieceColor_0;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeMethodInfoPtr_GetColorString_Private_Static_String_AgentIcons_0;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeMethodInfoPtr_GetControlMarkerString_Private_Static_String_PieceColor_0;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeMethodInfoPtr_GetAgentIconString_Private_Static_String_AgentIcons_0;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeMethodInfoPtr_GetLeaderString_Public_Static_String_WormLeader_0;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeMethodInfoPtr_GetFactionString_Private_Static_String_Factions_0;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeMethodInfoPtr_GetFactionStringWithIcon_Private_Static_String_Factions_0;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeMethodInfoPtr_WithLeader_Public_Static_GameLogBuilder_GameLogBuilder_WormPlayer_0;

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeMethodInfoPtr_WithColor_Public_Static_GameLogBuilder_GameLogBuilder_PieceColor_0;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeMethodInfoPtr_WithColor_Public_Static_GameLogBuilder_GameLogBuilder_AgentIcons_0;

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeMethodInfoPtr_WithLeader_Public_Static_GameLogBuilder_GameLogBuilder_WormLeader_0;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeMethodInfoPtr_WithLeaderTextOnly_Public_Static_GameLogBuilder_GameLogBuilder_WormLeader_0;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeMethodInfoPtr_WithArchetypeID_Public_Static_GameLogBuilder_GameLogBuilder_ArchetypeID_Boolean_0;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeMethodInfoPtr_UpsertArchetypeIDAttr_Private_Static_GameLogBuilder_GameLogBuilder_Entity_Boolean_0;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeMethodInfoPtr_UpsertArchetypeIDAttr_Private_Static_GameLogBuilder_GameLogBuilder_WormArchetype_Boolean_0;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr_WithCard_Public_Static_GameLogBuilder_GameLogBuilder_WormPlayable_Boolean_0;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeMethodInfoPtr_WithCardByArchetype_Public_Static_GameLogBuilder_GameLogBuilder_WormArchetype_Boolean_0;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeMethodInfoPtr_WithSpace_Public_Static_GameLogBuilder_GameLogBuilder_WormSpace_0;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeMethodInfoPtr_WithSpaceInternal_Private_Static_GameLogBuilder_GameLogBuilder_WormSpace_0;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeMethodInfoPtr_WithAgentIcon_Public_Static_GameLogBuilder_GameLogBuilder_WormSpace_0;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeMethodInfoPtr_WithAgentIcon_Public_Static_GameLogBuilder_GameLogBuilder_AgentIcons_0;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeMethodInfoPtr_WithAmount_Public_Static_GameLogBuilder_GameLogBuilder_Int32_0;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeMethodInfoPtr_WithFaction_Public_Static_GameLogBuilder_GameLogBuilder_Factions_0;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeMethodInfoPtr_WithFactionForSprite_Public_Static_GameLogBuilder_GameLogBuilder_Factions_0;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeMethodInfoPtr_WithPlace_Public_Static_GameLogBuilder_GameLogBuilder_Int32_0;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeMethodInfoPtr_WithControlMarker_Public_Static_GameLogBuilder_GameLogBuilder_WormEntity_0;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeMethodInfoPtr_AsTopLevel_Public_Static_GameLogBuilder_GameLogBuilder_0;

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceToken_Public_Static_GameLogBuilder_GameLogBuilder_String_0;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeMethodInfoPtr_WithSignetRing_Public_Static_GameLogBuilder_GameLogBuilder_0;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeMethodInfoPtr_WithResourceAmount_Public_Static_GameLogBuilder_GameLogBuilder_AttributeDefinition_1_Nullable_1_Int32_Int32_0;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeMethodInfoPtr_WithLogTemplate_Public_Static_GameLogBuilder_GameLogBuilder_LogTemplates_0;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeMethodInfoPtr_WithLogTemplateByPlayerTurn_Public_Static_GameLogBuilder_GameLogBuilder_WormPlayer_0;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeMethodInfoPtr_WithImage_Public_Static_GameLogBuilder_GameLogBuilder_String_0;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeMethodInfoPtr_WithCurrentTurnPlayer_Public_Static_GameLogBuilder_GameLogBuilder_WormPlayer_0;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeMethodInfoPtr_WithFactionSpriteList_Public_Static_GameLogBuilder_GameLogBuilder_List_1_Factions_0;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeMethodInfoPtr_WithLeaderList_Public_Static_GameLogBuilder_GameLogBuilder_List_1_WormPlayer_0;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_String_byref___c__DisplayClass35_0_PDM_0;

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_String_byref___c__DisplayClass41_0_PDM_0;

		// Token: 0x0200058A RID: 1418
		[ObfuscatedName("worm.canis.gameLogs.WormGameLogBuilder+<>c__DisplayClass35_0")]
		[StructLayout(2)]
		public struct __c__DisplayClass35_0
		{
			// Token: 0x06004419 RID: 17433 RVA: 0x0001659A File Offset: 0x0001479A
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_0()
			{
				Il2CppClassPointerStore<WormGameLogBuilder.__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, "<>c__DisplayClass35_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormGameLogBuilder.__c__DisplayClass35_0>.NativeClassPtr);
				WormGameLogBuilder.__c__DisplayClass35_0.NativeFieldInfoPtr_suffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameLogBuilder.__c__DisplayClass35_0>.NativeClassPtr, "suffix");
			}

			// Token: 0x0600441A RID: 17434 RVA: 0x000165CE File Offset: 0x000147CE
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WormGameLogBuilder.__c__DisplayClass35_0>.NativeClassPtr, ref this));
			}

			// Token: 0x04002CFF RID: 11519
			private static readonly IntPtr NativeFieldInfoPtr_suffix;

			// Token: 0x04002D00 RID: 11520
			[FieldOffset(0)]
			public int suffix;
		}

		// Token: 0x0200058B RID: 1419
		[ObfuscatedName("worm.canis.gameLogs.WormGameLogBuilder+<>c__DisplayClass41_0")]
		[StructLayout(2)]
		public struct __c__DisplayClass41_0
		{
			// Token: 0x0600441B RID: 17435 RVA: 0x000165E0 File Offset: 0x000147E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass41_0()
			{
				Il2CppClassPointerStore<WormGameLogBuilder.__c__DisplayClass41_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormGameLogBuilder>.NativeClassPtr, "<>c__DisplayClass41_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormGameLogBuilder.__c__DisplayClass41_0>.NativeClassPtr);
				WormGameLogBuilder.__c__DisplayClass41_0.NativeFieldInfoPtr_suffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameLogBuilder.__c__DisplayClass41_0>.NativeClassPtr, "suffix");
			}

			// Token: 0x0600441C RID: 17436 RVA: 0x00016614 File Offset: 0x00014814
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WormGameLogBuilder.__c__DisplayClass41_0>.NativeClassPtr, ref this));
			}

			// Token: 0x04002D01 RID: 11521
			private static readonly IntPtr NativeFieldInfoPtr_suffix;

			// Token: 0x04002D02 RID: 11522
			[FieldOffset(0)]
			public int suffix;
		}
	}
}
