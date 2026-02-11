using System;
using System.Runtime.InteropServices;
using Canis.actions;
using Canis.context;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using worm.canis.data.enums;
using worm.canis.entities;

namespace worm.canis.events
{
	// Token: 0x0200001F RID: 31
	public static class Fire : Object
	{
		// Token: 0x060002BB RID: 699 RVA: 0x000733EC File Offset: 0x000715EC
		// Note: this type is marked as 'beforefieldinit'.
		static Fire()
		{
			Il2CppClassPointerStore<Fire>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.events", "Fire");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Fire>.NativeClassPtr);
			Fire.NativeMethodInfoPtr_GameStarted_Public_Static_FireEventV2_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fire>.NativeClassPtr, 100663884);
			Fire.NativeMethodInfoPtr_RoundStarted_Public_Static_FireEventV2_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fire>.NativeClassPtr, 100663885);
			Fire.NativeMethodInfoPtr_RoundSetupFinished_Public_Static_FireEventV2_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fire>.NativeClassPtr, 100663886);
			Fire.NativeMethodInfoPtr_RoundSetupFinishedIlesa_Public_Static_FireEventV2_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fire>.NativeClassPtr, 100663887);
			Fire.NativeMethodInfoPtr_RoundEnded_Public_Static_FireEventV2_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fire>.NativeClassPtr, 100663888);
			Fire.NativeMethodInfoPtr_TurnStarted_Public_Static_FireEventV2_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fire>.NativeClassPtr, 100663889);
			Fire.NativeMethodInfoPtr_PreRevealTurnStarted_Public_Static_FireEventV2_WormPlayer_UndoNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fire>.NativeClassPtr, 100663890);
			Fire.NativeMethodInfoPtr_RevealTurnStarted_Public_Static_FireEventV2_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fire>.NativeClassPtr, 100663891);
			Fire.NativeMethodInfoPtr_TurnEnded_Public_Static_FireEventV2_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fire>.NativeClassPtr, 100663892);
			Fire.NativeMethodInfoPtr_ConflictStarted_Public_Static_FireEventV2_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fire>.NativeClassPtr, 100663893);
			Fire.NativeMethodInfoPtr_ImperiumPlayed_Private_Static_FireEventV2_WormPlayer_Il2CppReferenceArray_1_WormImperiumPlayable_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fire>.NativeClassPtr, 100663894);
			Fire.NativeMethodInfoPtr_ImperiumPlayed_Public_Static_FireEventV2_WormPlayer_Il2CppReferenceArray_1_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fire>.NativeClassPtr, 100663895);
			Fire.NativeMethodInfoPtr_ImperiumPlayed_Public_Static_FireEventV2_WormPlayer_Context_Il2CppReferenceArray_1_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fire>.NativeClassPtr, 100663896);
			Fire.NativeMethodInfoPtr_ImperiumTrashed_Public_Static_FireEventV2_WormPlayer_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fire>.NativeClassPtr, 100663897);
			Fire.NativeMethodInfoPtr_ImperiumDiscardedForUnload_Public_Static_FireEventV2_WormPlayer_WormImperiumPlayable_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fire>.NativeClassPtr, 100663898);
			Fire.NativeMethodInfoPtr_IntriguePlayed_Public_Static_FireEventV2_WormPlayer_WormIntriguePlayable_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fire>.NativeClassPtr, 100663899);
			Fire.NativeMethodInfoPtr_HighCouncilSeatTaken_Public_Static_FireEventV2_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fire>.NativeClassPtr, 100663900);
			Fire.NativeMethodInfoPtr_SolariPaidForSpace_Public_Static_FireEventV2_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fire>.NativeClassPtr, 100663901);
			Fire.NativeMethodInfoPtr_WaterPaid_Public_Static_FireEventV2_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fire>.NativeClassPtr, 100663902);
			Fire.NativeMethodInfoPtr_DeployedUnits_Public_Static_FireEventV2_WormPlayer_Il2CppReferenceArray_1_WormUnit_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fire>.NativeClassPtr, 100663903);
			Fire.NativeMethodInfoPtr_HarvestedSpice_Public_Static_FireEventV2_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fire>.NativeClassPtr, 100663904);
			Fire.NativeMethodInfoPtr_AcquireImperium_Public_Static_FireEventV2_WormPlayer_Il2CppReferenceArray_1_WormImperiumPlayable_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fire>.NativeClassPtr, 100663905);
			Fire.NativeMethodInfoPtr_AcquireImperium_Public_Static_FireEventV2_WormPlayer_Context_Il2CppReferenceArray_1_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fire>.NativeClassPtr, 100663906);
			Fire.NativeMethodInfoPtr_AcquireIntrigue_Public_Static_FireEventV2_WormPlayer_Il2CppReferenceArray_1_WormIntriguePlayable_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fire>.NativeClassPtr, 100663907);
			Fire.NativeMethodInfoPtr_AcquireIntrigue_Public_Static_FireEventV2_WormPlayer_Context_Il2CppReferenceArray_1_WormIntriguePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fire>.NativeClassPtr, 100663908);
			Fire.NativeMethodInfoPtr_SignetActivated_Public_Static_FireEventV2_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fire>.NativeClassPtr, 100663909);
			Fire.NativeMethodInfoPtr_ConflictRewardsAssigned_Public_Static_FireEventV2_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fire>.NativeClassPtr, 100663910);
			Fire.NativeMethodInfoPtr_InfluenceGained_Public_Static_FireEventV2_WormPlayer_Factions_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fire>.NativeClassPtr, 100663911);
			Fire.NativeMethodInfoPtr_PreImperiumReplaced_Public_Static_FireEventV2_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fire>.NativeClassPtr, 100663912);
			Fire.NativeMethodInfoPtr_PreTleilaxuReplaced_Public_Static_FireEventV2_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fire>.NativeClassPtr, 100663913);
			Fire.NativeMethodInfoPtr_PlayerDeckChanged_Public_Static_FireEventV2_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fire>.NativeClassPtr, 100663914);
			Fire.NativeMethodInfoPtr_AfterCardsRevealed_Public_Static_FireEventV2_WormPlayer_UndoNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fire>.NativeClassPtr, 100663915);
			Fire.NativeMethodInfoPtr_SolariGained_Public_Static_FireEventV2_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fire>.NativeClassPtr, 100663916);
			Fire.NativeMethodInfoPtr_WaterGained_Public_Static_FireEventV2_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fire>.NativeClassPtr, 100663917);
			Fire.NativeMethodInfoPtr_LeaderSetupBaron_Public_Static_FireEventV2_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fire>.NativeClassPtr, 100663918);
			Fire.NativeMethodInfoPtr_LeaderSetupHundro_Public_Static_FireEventV2_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fire>.NativeClassPtr, 100663919);
			Fire.NativeMethodInfoPtr_SpaceInfiltrated_Public_Static_FireEventV2_WormPlayer_WormSpace_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fire>.NativeClassPtr, 100663920);
			Fire.NativeMethodInfoPtr_SwordmasterAcquired_Public_Static_FireEventV2_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fire>.NativeClassPtr, 100663921);
			Fire.NativeMethodInfoPtr_AllianceGained_Public_Static_FireEventV2_WormPlayer_Factions_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fire>.NativeClassPtr, 100663922);
			Fire.NativeMethodInfoPtr_TechTileAcquired_Public_Static_FireEventV2_WormPlayer_WormTechTilePlayable_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fire>.NativeClassPtr, 100663923);
			Fire.NativeMethodInfoPtr_FamilyAtomicsUsed_Public_Static_FireEventV2_WormPlayer_Il2CppReferenceArray_1_WormImperiumPlayable_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fire>.NativeClassPtr, 100663924);
			Fire.NativeMethodInfoPtr_ResearchGained_Public_Static_FireEventV2_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fire>.NativeClassPtr, 100663925);
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00073764 File Offset: 0x00071964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33832, XrefRangeEnd = 33842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FireEventV2 GameStarted(WormMatch match)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fire.NativeMethodInfoPtr_GameStarted_Public_Static_FireEventV2_WormMatch_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FireEventV2>(intPtr3) : null;
			}
		}

		// Token: 0x060002BD RID: 701 RVA: 0x000737A8 File Offset: 0x000719A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33852, RefRangeEnd = 33853, XrefRangeStart = 33842, XrefRangeEnd = 33852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FireEventV2 RoundStarted(WormMatch match)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fire.NativeMethodInfoPtr_RoundStarted_Public_Static_FireEventV2_WormMatch_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FireEventV2>(intPtr3) : null;
			}
		}

		// Token: 0x060002BE RID: 702 RVA: 0x000737EC File Offset: 0x000719EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33863, RefRangeEnd = 33864, XrefRangeStart = 33853, XrefRangeEnd = 33863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FireEventV2 RoundSetupFinished(WormMatch match)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fire.NativeMethodInfoPtr_RoundSetupFinished_Public_Static_FireEventV2_WormMatch_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FireEventV2>(intPtr3) : null;
			}
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00073830 File Offset: 0x00071A30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33874, RefRangeEnd = 33875, XrefRangeStart = 33864, XrefRangeEnd = 33874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FireEventV2 RoundSetupFinishedIlesa(WormMatch match)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fire.NativeMethodInfoPtr_RoundSetupFinishedIlesa_Public_Static_FireEventV2_WormMatch_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FireEventV2>(intPtr3) : null;
			}
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00073874 File Offset: 0x00071A74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33885, RefRangeEnd = 33886, XrefRangeStart = 33875, XrefRangeEnd = 33885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FireEventV2 RoundEnded(WormMatch match)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fire.NativeMethodInfoPtr_RoundEnded_Public_Static_FireEventV2_WormMatch_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FireEventV2>(intPtr3) : null;
			}
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x000738B8 File Offset: 0x00071AB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 33901, RefRangeEnd = 33903, XrefRangeStart = 33886, XrefRangeEnd = 33901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FireEventV2 TurnStarted(WormPlayer player)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fire.NativeMethodInfoPtr_TurnStarted_Public_Static_FireEventV2_WormPlayer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FireEventV2>(intPtr3) : null;
			}
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x000738FC File Offset: 0x00071AFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33923, RefRangeEnd = 33924, XrefRangeStart = 33903, XrefRangeEnd = 33923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FireEventV2 PreRevealTurnStarted(WormPlayer player, UndoNode undoNode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(undoNode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fire.NativeMethodInfoPtr_PreRevealTurnStarted_Public_Static_FireEventV2_WormPlayer_UndoNode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FireEventV2>(intPtr3) : null;
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00073954 File Offset: 0x00071B54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 33939, RefRangeEnd = 33941, XrefRangeStart = 33924, XrefRangeEnd = 33939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FireEventV2 RevealTurnStarted(WormPlayer player)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fire.NativeMethodInfoPtr_RevealTurnStarted_Public_Static_FireEventV2_WormPlayer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FireEventV2>(intPtr3) : null;
			}
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00073998 File Offset: 0x00071B98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33956, RefRangeEnd = 33957, XrefRangeStart = 33941, XrefRangeEnd = 33956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FireEventV2 TurnEnded(WormPlayer player)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fire.NativeMethodInfoPtr_TurnEnded_Public_Static_FireEventV2_WormPlayer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FireEventV2>(intPtr3) : null;
			}
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x000739DC File Offset: 0x00071BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33957, XrefRangeEnd = 33967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FireEventV2 ConflictStarted(WormMatch match)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fire.NativeMethodInfoPtr_ConflictStarted_Public_Static_FireEventV2_WormMatch_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FireEventV2>(intPtr3) : null;
			}
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00073A20 File Offset: 0x00071C20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 33986, RefRangeEnd = 33988, XrefRangeStart = 33967, XrefRangeEnd = 33986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FireEventV2 ImperiumPlayed(WormPlayer player, Il2CppReferenceArray<WormImperiumPlayable> playedCards, Context paramContext)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playedCards);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fire.NativeMethodInfoPtr_ImperiumPlayed_Private_Static_FireEventV2_WormPlayer_Il2CppReferenceArray_1_WormImperiumPlayable_Context_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FireEventV2>(intPtr3) : null;
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00073A88 File Offset: 0x00071C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33988, XrefRangeEnd = 33989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FireEventV2 ImperiumPlayed(WormPlayer player, [Optional] Il2CppReferenceArray<WormImperiumPlayable> playedCards)
		{
			if (playedCards == null)
			{
				playedCards = new Il2CppReferenceArray<WormImperiumPlayable>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playedCards);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fire.NativeMethodInfoPtr_ImperiumPlayed_Public_Static_FireEventV2_WormPlayer_Il2CppReferenceArray_1_WormImperiumPlayable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FireEventV2>(intPtr3) : null;
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00073AEC File Offset: 0x00071CEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 33990, RefRangeEnd = 33992, XrefRangeStart = 33989, XrefRangeEnd = 33990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FireEventV2 ImperiumPlayed(WormPlayer player, Context paramContext, [Optional] Il2CppReferenceArray<WormImperiumPlayable> playedCards)
		{
			if (playedCards == null)
			{
				playedCards = new Il2CppReferenceArray<WormImperiumPlayable>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramContext);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playedCards);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fire.NativeMethodInfoPtr_ImperiumPlayed_Public_Static_FireEventV2_WormPlayer_Context_Il2CppReferenceArray_1_WormImperiumPlayable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FireEventV2>(intPtr3) : null;
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00073B64 File Offset: 0x00071D64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34015, RefRangeEnd = 34016, XrefRangeStart = 33992, XrefRangeEnd = 34015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FireEventV2 ImperiumTrashed(WormPlayer player, WormImperiumPlayable trashedCard)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trashedCard);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fire.NativeMethodInfoPtr_ImperiumTrashed_Public_Static_FireEventV2_WormPlayer_WormImperiumPlayable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FireEventV2>(intPtr3) : null;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00073BBC File Offset: 0x00071DBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34040, RefRangeEnd = 34041, XrefRangeStart = 34016, XrefRangeEnd = 34040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FireEventV2 ImperiumDiscardedForUnload(WormPlayer player, WormImperiumPlayable discardedCard, Context paramContext = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(discardedCard);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fire.NativeMethodInfoPtr_ImperiumDiscardedForUnload_Public_Static_FireEventV2_WormPlayer_WormImperiumPlayable_Context_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FireEventV2>(intPtr3) : null;
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00073C24 File Offset: 0x00071E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34041, XrefRangeEnd = 34065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FireEventV2 IntriguePlayed(WormPlayer player, WormIntriguePlayable intrigueCard, Context paramContext = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(intrigueCard);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fire.NativeMethodInfoPtr_IntriguePlayed_Public_Static_FireEventV2_WormPlayer_WormIntriguePlayable_Context_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FireEventV2>(intPtr3) : null;
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00073C8C File Offset: 0x00071E8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34080, RefRangeEnd = 34081, XrefRangeStart = 34065, XrefRangeEnd = 34080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FireEventV2 HighCouncilSeatTaken(WormPlayer player)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fire.NativeMethodInfoPtr_HighCouncilSeatTaken_Public_Static_FireEventV2_WormPlayer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FireEventV2>(intPtr3) : null;
			}
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00073CD0 File Offset: 0x00071ED0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34096, RefRangeEnd = 34097, XrefRangeStart = 34081, XrefRangeEnd = 34096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FireEventV2 SolariPaidForSpace(WormPlayer player)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fire.NativeMethodInfoPtr_SolariPaidForSpace_Public_Static_FireEventV2_WormPlayer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FireEventV2>(intPtr3) : null;
			}
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00073D14 File Offset: 0x00071F14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34112, RefRangeEnd = 34113, XrefRangeStart = 34097, XrefRangeEnd = 34112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FireEventV2 WaterPaid(WormPlayer player)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fire.NativeMethodInfoPtr_WaterPaid_Public_Static_FireEventV2_WormPlayer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FireEventV2>(intPtr3) : null;
			}
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00073D58 File Offset: 0x00071F58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34132, RefRangeEnd = 34133, XrefRangeStart = 34113, XrefRangeEnd = 34132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FireEventV2 DeployedUnits(WormPlayer player, Il2CppReferenceArray<WormUnit> units, Context paramContext = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(units);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fire.NativeMethodInfoPtr_DeployedUnits_Public_Static_FireEventV2_WormPlayer_Il2CppReferenceArray_1_WormUnit_Context_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FireEventV2>(intPtr3) : null;
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00073DC0 File Offset: 0x00071FC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34148, RefRangeEnd = 34149, XrefRangeStart = 34133, XrefRangeEnd = 34148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FireEventV2 HarvestedSpice(WormPlayer player)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fire.NativeMethodInfoPtr_HarvestedSpice_Public_Static_FireEventV2_WormPlayer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FireEventV2>(intPtr3) : null;
			}
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00073E04 File Offset: 0x00072004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34149, XrefRangeEnd = 34168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FireEventV2 AcquireImperium(WormPlayer player, Il2CppReferenceArray<WormImperiumPlayable> acquiredCards, Context paramContext = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(acquiredCards);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fire.NativeMethodInfoPtr_AcquireImperium_Public_Static_FireEventV2_WormPlayer_Il2CppReferenceArray_1_WormImperiumPlayable_Context_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FireEventV2>(intPtr3) : null;
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00073E6C File Offset: 0x0007206C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 34187, RefRangeEnd = 34194, XrefRangeStart = 34168, XrefRangeEnd = 34187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FireEventV2 AcquireImperium(WormPlayer player, Context paramContext, [Optional] Il2CppReferenceArray<WormImperiumPlayable> acquiredCards)
		{
			if (acquiredCards == null)
			{
				acquiredCards = new Il2CppReferenceArray<WormImperiumPlayable>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramContext);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(acquiredCards);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fire.NativeMethodInfoPtr_AcquireImperium_Public_Static_FireEventV2_WormPlayer_Context_Il2CppReferenceArray_1_WormImperiumPlayable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FireEventV2>(intPtr3) : null;
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00073EE4 File Offset: 0x000720E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34194, XrefRangeEnd = 34213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FireEventV2 AcquireIntrigue(WormPlayer player, Il2CppReferenceArray<WormIntriguePlayable> acquiredCards, Context paramContext = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(acquiredCards);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fire.NativeMethodInfoPtr_AcquireIntrigue_Public_Static_FireEventV2_WormPlayer_Il2CppReferenceArray_1_WormIntriguePlayable_Context_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FireEventV2>(intPtr3) : null;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00073F4C File Offset: 0x0007214C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 34232, RefRangeEnd = 34235, XrefRangeStart = 34213, XrefRangeEnd = 34232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FireEventV2 AcquireIntrigue(WormPlayer player, Context paramContext, [Optional] Il2CppReferenceArray<WormIntriguePlayable> acquiredCards)
		{
			if (acquiredCards == null)
			{
				acquiredCards = new Il2CppReferenceArray<WormIntriguePlayable>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramContext);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(acquiredCards);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fire.NativeMethodInfoPtr_AcquireIntrigue_Public_Static_FireEventV2_WormPlayer_Context_Il2CppReferenceArray_1_WormIntriguePlayable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FireEventV2>(intPtr3) : null;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00073FC4 File Offset: 0x000721C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34235, XrefRangeEnd = 34250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FireEventV2 SignetActivated(WormPlayer player)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fire.NativeMethodInfoPtr_SignetActivated_Public_Static_FireEventV2_WormPlayer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FireEventV2>(intPtr3) : null;
			}
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00074008 File Offset: 0x00072208
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34260, RefRangeEnd = 34261, XrefRangeStart = 34250, XrefRangeEnd = 34260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FireEventV2 ConflictRewardsAssigned(WormMatch match)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fire.NativeMethodInfoPtr_ConflictRewardsAssigned_Public_Static_FireEventV2_WormMatch_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FireEventV2>(intPtr3) : null;
			}
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0007404C File Offset: 0x0007224C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34261, XrefRangeEnd = 34283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FireEventV2 InfluenceGained(WormPlayer player, Factions forFaction, Context paramContext = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forFaction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fire.NativeMethodInfoPtr_InfluenceGained_Public_Static_FireEventV2_WormPlayer_Factions_Context_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FireEventV2>(intPtr3) : null;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x000740B0 File Offset: 0x000722B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34293, RefRangeEnd = 34294, XrefRangeStart = 34283, XrefRangeEnd = 34293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FireEventV2 PreImperiumReplaced(WormMatch match)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fire.NativeMethodInfoPtr_PreImperiumReplaced_Public_Static_FireEventV2_WormMatch_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FireEventV2>(intPtr3) : null;
			}
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x000740F4 File Offset: 0x000722F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34294, XrefRangeEnd = 34304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FireEventV2 PreTleilaxuReplaced(WormMatch match)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fire.NativeMethodInfoPtr_PreTleilaxuReplaced_Public_Static_FireEventV2_WormMatch_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FireEventV2>(intPtr3) : null;
			}
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00074138 File Offset: 0x00072338
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 34319, RefRangeEnd = 34327, XrefRangeStart = 34304, XrefRangeEnd = 34319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FireEventV2 PlayerDeckChanged(WormPlayer player)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fire.NativeMethodInfoPtr_PlayerDeckChanged_Public_Static_FireEventV2_WormPlayer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FireEventV2>(intPtr3) : null;
			}
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0007417C File Offset: 0x0007237C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34347, RefRangeEnd = 34348, XrefRangeStart = 34327, XrefRangeEnd = 34347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FireEventV2 AfterCardsRevealed(WormPlayer player, UndoNode undoNode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(undoNode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fire.NativeMethodInfoPtr_AfterCardsRevealed_Public_Static_FireEventV2_WormPlayer_UndoNode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FireEventV2>(intPtr3) : null;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x000741D4 File Offset: 0x000723D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34348, XrefRangeEnd = 34363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FireEventV2 SolariGained(WormPlayer player)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fire.NativeMethodInfoPtr_SolariGained_Public_Static_FireEventV2_WormPlayer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FireEventV2>(intPtr3) : null;
			}
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00074218 File Offset: 0x00072418
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34378, RefRangeEnd = 34379, XrefRangeStart = 34363, XrefRangeEnd = 34378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FireEventV2 WaterGained(WormPlayer player)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fire.NativeMethodInfoPtr_WaterGained_Public_Static_FireEventV2_WormPlayer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FireEventV2>(intPtr3) : null;
			}
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0007425C File Offset: 0x0007245C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34379, XrefRangeEnd = 34389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FireEventV2 LeaderSetupBaron(WormMatch match)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fire.NativeMethodInfoPtr_LeaderSetupBaron_Public_Static_FireEventV2_WormMatch_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FireEventV2>(intPtr3) : null;
			}
		}

		// Token: 0x060002DF RID: 735 RVA: 0x000742A0 File Offset: 0x000724A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34399, RefRangeEnd = 34400, XrefRangeStart = 34389, XrefRangeEnd = 34399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FireEventV2 LeaderSetupHundro(WormMatch match)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fire.NativeMethodInfoPtr_LeaderSetupHundro_Public_Static_FireEventV2_WormMatch_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FireEventV2>(intPtr3) : null;
			}
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x000742E4 File Offset: 0x000724E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34419, RefRangeEnd = 34420, XrefRangeStart = 34400, XrefRangeEnd = 34419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FireEventV2 SpaceInfiltrated(WormPlayer player, WormSpace space, Context paramContext = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(space);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fire.NativeMethodInfoPtr_SpaceInfiltrated_Public_Static_FireEventV2_WormPlayer_WormSpace_Context_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FireEventV2>(intPtr3) : null;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0007434C File Offset: 0x0007254C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34435, RefRangeEnd = 34436, XrefRangeStart = 34420, XrefRangeEnd = 34435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FireEventV2 SwordmasterAcquired(WormPlayer player)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fire.NativeMethodInfoPtr_SwordmasterAcquired_Public_Static_FireEventV2_WormPlayer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FireEventV2>(intPtr3) : null;
			}
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00074390 File Offset: 0x00072590
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34458, RefRangeEnd = 34459, XrefRangeStart = 34436, XrefRangeEnd = 34458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FireEventV2 AllianceGained(WormPlayer player, Factions forFaction, Context paramContext = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forFaction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fire.NativeMethodInfoPtr_AllianceGained_Public_Static_FireEventV2_WormPlayer_Factions_Context_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FireEventV2>(intPtr3) : null;
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x000743F4 File Offset: 0x000725F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34478, RefRangeEnd = 34479, XrefRangeStart = 34459, XrefRangeEnd = 34478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FireEventV2 TechTileAcquired(WormPlayer player, WormTechTilePlayable techTile, Context paramContext = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(techTile);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fire.NativeMethodInfoPtr_TechTileAcquired_Public_Static_FireEventV2_WormPlayer_WormTechTilePlayable_Context_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FireEventV2>(intPtr3) : null;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0007445C File Offset: 0x0007265C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34498, RefRangeEnd = 34499, XrefRangeStart = 34479, XrefRangeEnd = 34498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FireEventV2 FamilyAtomicsUsed(WormPlayer player, Il2CppReferenceArray<WormImperiumPlayable> cards, Context paramContext = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cards);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fire.NativeMethodInfoPtr_FamilyAtomicsUsed_Public_Static_FireEventV2_WormPlayer_Il2CppReferenceArray_1_WormImperiumPlayable_Context_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FireEventV2>(intPtr3) : null;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x000744C4 File Offset: 0x000726C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34514, RefRangeEnd = 34515, XrefRangeStart = 34499, XrefRangeEnd = 34514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FireEventV2 ResearchGained(WormPlayer player)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fire.NativeMethodInfoPtr_ResearchGained_Public_Static_FireEventV2_WormPlayer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FireEventV2>(intPtr3) : null;
			}
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x000034BB File Offset: 0x000016BB
		public static FireEventV2 ImperiumPlayed(WormPlayer player, params WormImperiumPlayable[] playedCards)
		{
			return Fire.ImperiumPlayed(player, new Il2CppReferenceArray<WormImperiumPlayable>(playedCards));
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x000034C9 File Offset: 0x000016C9
		public static FireEventV2 ImperiumPlayed(WormPlayer player, Context paramContext, params WormImperiumPlayable[] playedCards)
		{
			return Fire.ImperiumPlayed(player, paramContext, new Il2CppReferenceArray<WormImperiumPlayable>(playedCards));
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x000034D8 File Offset: 0x000016D8
		public static FireEventV2 AcquireImperium(WormPlayer player, Context paramContext, params WormImperiumPlayable[] acquiredCards)
		{
			return Fire.AcquireImperium(player, paramContext, new Il2CppReferenceArray<WormImperiumPlayable>(acquiredCards));
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x000034E7 File Offset: 0x000016E7
		public static FireEventV2 AcquireIntrigue(WormPlayer player, Context paramContext, params WormIntriguePlayable[] acquiredCards)
		{
			return Fire.AcquireIntrigue(player, paramContext, new Il2CppReferenceArray<WormIntriguePlayable>(acquiredCards));
		}

		// Token: 0x060002EA RID: 746 RVA: 0x000034F6 File Offset: 0x000016F6
		public Fire(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeMethodInfoPtr_GameStarted_Public_Static_FireEventV2_WormMatch_0;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeMethodInfoPtr_RoundStarted_Public_Static_FireEventV2_WormMatch_0;

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeMethodInfoPtr_RoundSetupFinished_Public_Static_FireEventV2_WormMatch_0;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeMethodInfoPtr_RoundSetupFinishedIlesa_Public_Static_FireEventV2_WormMatch_0;

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeMethodInfoPtr_RoundEnded_Public_Static_FireEventV2_WormMatch_0;

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeMethodInfoPtr_TurnStarted_Public_Static_FireEventV2_WormPlayer_0;

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeMethodInfoPtr_PreRevealTurnStarted_Public_Static_FireEventV2_WormPlayer_UndoNode_0;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeMethodInfoPtr_RevealTurnStarted_Public_Static_FireEventV2_WormPlayer_0;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeMethodInfoPtr_TurnEnded_Public_Static_FireEventV2_WormPlayer_0;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeMethodInfoPtr_ConflictStarted_Public_Static_FireEventV2_WormMatch_0;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeMethodInfoPtr_ImperiumPlayed_Private_Static_FireEventV2_WormPlayer_Il2CppReferenceArray_1_WormImperiumPlayable_Context_0;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeMethodInfoPtr_ImperiumPlayed_Public_Static_FireEventV2_WormPlayer_Il2CppReferenceArray_1_WormImperiumPlayable_0;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeMethodInfoPtr_ImperiumPlayed_Public_Static_FireEventV2_WormPlayer_Context_Il2CppReferenceArray_1_WormImperiumPlayable_0;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeMethodInfoPtr_ImperiumTrashed_Public_Static_FireEventV2_WormPlayer_WormImperiumPlayable_0;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeMethodInfoPtr_ImperiumDiscardedForUnload_Public_Static_FireEventV2_WormPlayer_WormImperiumPlayable_Context_0;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeMethodInfoPtr_IntriguePlayed_Public_Static_FireEventV2_WormPlayer_WormIntriguePlayable_Context_0;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeMethodInfoPtr_HighCouncilSeatTaken_Public_Static_FireEventV2_WormPlayer_0;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeMethodInfoPtr_SolariPaidForSpace_Public_Static_FireEventV2_WormPlayer_0;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeMethodInfoPtr_WaterPaid_Public_Static_FireEventV2_WormPlayer_0;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeMethodInfoPtr_DeployedUnits_Public_Static_FireEventV2_WormPlayer_Il2CppReferenceArray_1_WormUnit_Context_0;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeMethodInfoPtr_HarvestedSpice_Public_Static_FireEventV2_WormPlayer_0;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeMethodInfoPtr_AcquireImperium_Public_Static_FireEventV2_WormPlayer_Il2CppReferenceArray_1_WormImperiumPlayable_Context_0;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeMethodInfoPtr_AcquireImperium_Public_Static_FireEventV2_WormPlayer_Context_Il2CppReferenceArray_1_WormImperiumPlayable_0;

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeMethodInfoPtr_AcquireIntrigue_Public_Static_FireEventV2_WormPlayer_Il2CppReferenceArray_1_WormIntriguePlayable_Context_0;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeMethodInfoPtr_AcquireIntrigue_Public_Static_FireEventV2_WormPlayer_Context_Il2CppReferenceArray_1_WormIntriguePlayable_0;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeMethodInfoPtr_SignetActivated_Public_Static_FireEventV2_WormPlayer_0;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeMethodInfoPtr_ConflictRewardsAssigned_Public_Static_FireEventV2_WormMatch_0;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeMethodInfoPtr_InfluenceGained_Public_Static_FireEventV2_WormPlayer_Factions_Context_0;

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeMethodInfoPtr_PreImperiumReplaced_Public_Static_FireEventV2_WormMatch_0;

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeMethodInfoPtr_PreTleilaxuReplaced_Public_Static_FireEventV2_WormMatch_0;

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeMethodInfoPtr_PlayerDeckChanged_Public_Static_FireEventV2_WormPlayer_0;

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeMethodInfoPtr_AfterCardsRevealed_Public_Static_FireEventV2_WormPlayer_UndoNode_0;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeMethodInfoPtr_SolariGained_Public_Static_FireEventV2_WormPlayer_0;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeMethodInfoPtr_WaterGained_Public_Static_FireEventV2_WormPlayer_0;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeMethodInfoPtr_LeaderSetupBaron_Public_Static_FireEventV2_WormMatch_0;

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeMethodInfoPtr_LeaderSetupHundro_Public_Static_FireEventV2_WormMatch_0;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeMethodInfoPtr_SpaceInfiltrated_Public_Static_FireEventV2_WormPlayer_WormSpace_Context_0;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeMethodInfoPtr_SwordmasterAcquired_Public_Static_FireEventV2_WormPlayer_0;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeMethodInfoPtr_AllianceGained_Public_Static_FireEventV2_WormPlayer_Factions_Context_0;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeMethodInfoPtr_TechTileAcquired_Public_Static_FireEventV2_WormPlayer_WormTechTilePlayable_Context_0;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeMethodInfoPtr_FamilyAtomicsUsed_Public_Static_FireEventV2_WormPlayer_Il2CppReferenceArray_1_WormImperiumPlayable_Context_0;

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeMethodInfoPtr_ResearchGained_Public_Static_FireEventV2_WormPlayer_0;
	}
}
