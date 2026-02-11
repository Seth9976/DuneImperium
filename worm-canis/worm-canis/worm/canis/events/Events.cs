using System;
using Canis.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace worm.canis.events
{
	// Token: 0x0200001E RID: 30
	public static class Events : Object
	{
		// Token: 0x06000294 RID: 660 RVA: 0x00072954 File Offset: 0x00070B54
		// Note: this type is marked as 'beforefieldinit'.
		static Events()
		{
			Il2CppClassPointerStore<Events>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.events", "Events");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Events>.NativeClassPtr);
			Events.NativeMethodInfoPtr_get_GameStarted_Public_Static_get_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100663847);
			Events.NativeMethodInfoPtr_get_RoundStarted_Public_Static_get_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100663848);
			Events.NativeMethodInfoPtr_get_RoundSetupFinished_Public_Static_get_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100663849);
			Events.NativeMethodInfoPtr_get_RoundSetupFinishedIlesa_Public_Static_get_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100663850);
			Events.NativeMethodInfoPtr_get_RoundEnded_Public_Static_get_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100663851);
			Events.NativeMethodInfoPtr_get_TurnStarted_Public_Static_get_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100663852);
			Events.NativeMethodInfoPtr_get_PreRevealTurnStarted_Public_Static_get_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100663853);
			Events.NativeMethodInfoPtr_get_RevealTurnStarted_Public_Static_get_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100663854);
			Events.NativeMethodInfoPtr_get_TurnEnded_Public_Static_get_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100663855);
			Events.NativeMethodInfoPtr_get_ConflictStarted_Public_Static_get_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100663856);
			Events.NativeMethodInfoPtr_get_ImperiumPlayed_Public_Static_get_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100663857);
			Events.NativeMethodInfoPtr_get_ImperiumTrashed_Public_Static_get_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100663858);
			Events.NativeMethodInfoPtr_get_ImperiumDiscardedForUnload_Public_Static_get_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100663859);
			Events.NativeMethodInfoPtr_get_IntriguePlayed_Public_Static_get_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100663860);
			Events.NativeMethodInfoPtr_get_HighCouncilSeatTaken_Public_Static_get_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100663861);
			Events.NativeMethodInfoPtr_get_SolariPaidForSpace_Public_Static_get_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100663862);
			Events.NativeMethodInfoPtr_get_WaterPaid_Public_Static_get_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100663863);
			Events.NativeMethodInfoPtr_get_DeployedUnits_Public_Static_get_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100663864);
			Events.NativeMethodInfoPtr_get_HarvestedSpice_Public_Static_get_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100663865);
			Events.NativeMethodInfoPtr_get_AcquireImperium_Public_Static_get_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100663866);
			Events.NativeMethodInfoPtr_get_AcquireIntrigue_Public_Static_get_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100663867);
			Events.NativeMethodInfoPtr_get_SignetActivated_Public_Static_get_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100663868);
			Events.NativeMethodInfoPtr_get_ConflictRewardsAssigned_Public_Static_get_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100663869);
			Events.NativeMethodInfoPtr_get_InfluenceGained_Public_Static_get_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100663870);
			Events.NativeMethodInfoPtr_get_PreImperiumReplaced_Public_Static_get_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100663871);
			Events.NativeMethodInfoPtr_get_PlayerDeckChanged_Public_Static_get_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100663872);
			Events.NativeMethodInfoPtr_get_AfterCardsRevealed_Public_Static_get_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100663873);
			Events.NativeMethodInfoPtr_get_SolariGained_Public_Static_get_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100663874);
			Events.NativeMethodInfoPtr_get_WaterGained_Public_Static_get_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100663875);
			Events.NativeMethodInfoPtr_get_LeaderSetupBaron_Public_Static_get_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100663876);
			Events.NativeMethodInfoPtr_get_LeaderSetupHundro_Public_Static_get_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100663877);
			Events.NativeMethodInfoPtr_get_SpaceInfiltrated_Public_Static_get_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100663878);
			Events.NativeMethodInfoPtr_get_SwordmasterAcquired_Public_Static_get_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100663879);
			Events.NativeMethodInfoPtr_get_AllianceGained_Public_Static_get_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100663880);
			Events.NativeMethodInfoPtr_get_TechTileAcquired_Public_Static_get_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100663881);
			Events.NativeMethodInfoPtr_get_FamilyAtomicsUsed_Public_Static_get_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100663882);
			Events.NativeMethodInfoPtr_get_ResearchGained_Public_Static_get_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100663883);
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000295 RID: 661 RVA: 0x00072C68 File Offset: 0x00070E68
		public unsafe static SerializableEvent GameStarted
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 33458, RefRangeEnd = 33506, XrefRangeStart = 33452, XrefRangeEnd = 33458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_get_GameStarted_Public_Static_get_SerializableEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000296 RID: 662 RVA: 0x00072C9C File Offset: 0x00070E9C
		public unsafe static SerializableEvent RoundStarted
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 33512, RefRangeEnd = 33518, XrefRangeStart = 33506, XrefRangeEnd = 33512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_get_RoundStarted_Public_Static_get_SerializableEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000297 RID: 663 RVA: 0x00072CD0 File Offset: 0x00070ED0
		public unsafe static SerializableEvent RoundSetupFinished
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 33524, RefRangeEnd = 33527, XrefRangeStart = 33518, XrefRangeEnd = 33524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_get_RoundSetupFinished_Public_Static_get_SerializableEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000298 RID: 664 RVA: 0x00072D04 File Offset: 0x00070F04
		public unsafe static SerializableEvent RoundSetupFinishedIlesa
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 33533, RefRangeEnd = 33534, XrefRangeStart = 33527, XrefRangeEnd = 33533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_get_RoundSetupFinishedIlesa_Public_Static_get_SerializableEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000299 RID: 665 RVA: 0x00072D38 File Offset: 0x00070F38
		public unsafe static SerializableEvent RoundEnded
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 33540, RefRangeEnd = 33547, XrefRangeStart = 33534, XrefRangeEnd = 33540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_get_RoundEnded_Public_Static_get_SerializableEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600029A RID: 666 RVA: 0x00072D6C File Offset: 0x00070F6C
		public unsafe static SerializableEvent TurnStarted
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 33553, RefRangeEnd = 33556, XrefRangeStart = 33547, XrefRangeEnd = 33553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_get_TurnStarted_Public_Static_get_SerializableEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600029B RID: 667 RVA: 0x00072DA0 File Offset: 0x00070FA0
		public unsafe static SerializableEvent PreRevealTurnStarted
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 33562, RefRangeEnd = 33563, XrefRangeStart = 33556, XrefRangeEnd = 33562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_get_PreRevealTurnStarted_Public_Static_get_SerializableEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600029C RID: 668 RVA: 0x00072DD4 File Offset: 0x00070FD4
		public unsafe static SerializableEvent RevealTurnStarted
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 33569, RefRangeEnd = 33577, XrefRangeStart = 33563, XrefRangeEnd = 33569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_get_RevealTurnStarted_Public_Static_get_SerializableEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600029D RID: 669 RVA: 0x00072E08 File Offset: 0x00071008
		public unsafe static SerializableEvent TurnEnded
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 33583, RefRangeEnd = 33586, XrefRangeStart = 33577, XrefRangeEnd = 33583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_get_TurnEnded_Public_Static_get_SerializableEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600029E RID: 670 RVA: 0x00072E3C File Offset: 0x0007103C
		public unsafe static SerializableEvent ConflictStarted
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 33592, RefRangeEnd = 33596, XrefRangeStart = 33586, XrefRangeEnd = 33592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_get_ConflictStarted_Public_Static_get_SerializableEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600029F RID: 671 RVA: 0x00072E70 File Offset: 0x00071070
		public unsafe static SerializableEvent ImperiumPlayed
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 33602, RefRangeEnd = 33612, XrefRangeStart = 33596, XrefRangeEnd = 33602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_get_ImperiumPlayed_Public_Static_get_SerializableEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x00072EA4 File Offset: 0x000710A4
		public unsafe static SerializableEvent ImperiumTrashed
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 33618, RefRangeEnd = 33626, XrefRangeStart = 33612, XrefRangeEnd = 33618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_get_ImperiumTrashed_Public_Static_get_SerializableEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x00072ED8 File Offset: 0x000710D8
		public unsafe static SerializableEvent ImperiumDiscardedForUnload
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 33632, RefRangeEnd = 33638, XrefRangeStart = 33626, XrefRangeEnd = 33632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_get_ImperiumDiscardedForUnload_Public_Static_get_SerializableEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x00072F0C File Offset: 0x0007110C
		public unsafe static SerializableEvent IntriguePlayed
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 33644, RefRangeEnd = 33650, XrefRangeStart = 33638, XrefRangeEnd = 33644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_get_IntriguePlayed_Public_Static_get_SerializableEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x00072F40 File Offset: 0x00071140
		public unsafe static SerializableEvent HighCouncilSeatTaken
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 33656, RefRangeEnd = 33657, XrefRangeStart = 33650, XrefRangeEnd = 33656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_get_HighCouncilSeatTaken_Public_Static_get_SerializableEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x00072F74 File Offset: 0x00071174
		public unsafe static SerializableEvent SolariPaidForSpace
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 33663, RefRangeEnd = 33664, XrefRangeStart = 33657, XrefRangeEnd = 33663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_get_SolariPaidForSpace_Public_Static_get_SerializableEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x00072FA8 File Offset: 0x000711A8
		public unsafe static SerializableEvent WaterPaid
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 33670, RefRangeEnd = 33671, XrefRangeStart = 33664, XrefRangeEnd = 33670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_get_WaterPaid_Public_Static_get_SerializableEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x00072FDC File Offset: 0x000711DC
		public unsafe static SerializableEvent DeployedUnits
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 33677, RefRangeEnd = 33681, XrefRangeStart = 33671, XrefRangeEnd = 33677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_get_DeployedUnits_Public_Static_get_SerializableEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x00073010 File Offset: 0x00071210
		public unsafe static SerializableEvent HarvestedSpice
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 33687, RefRangeEnd = 33688, XrefRangeStart = 33681, XrefRangeEnd = 33687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_get_HarvestedSpice_Public_Static_get_SerializableEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x00073044 File Offset: 0x00071244
		public unsafe static SerializableEvent AcquireImperium
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 33694, RefRangeEnd = 33702, XrefRangeStart = 33688, XrefRangeEnd = 33694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_get_AcquireImperium_Public_Static_get_SerializableEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x00073078 File Offset: 0x00071278
		public unsafe static SerializableEvent AcquireIntrigue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33702, XrefRangeEnd = 33708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_get_AcquireIntrigue_Public_Static_get_SerializableEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060002AA RID: 682 RVA: 0x000730AC File Offset: 0x000712AC
		public unsafe static SerializableEvent SignetActivated
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 33714, RefRangeEnd = 33715, XrefRangeStart = 33708, XrefRangeEnd = 33714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_get_SignetActivated_Public_Static_get_SerializableEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060002AB RID: 683 RVA: 0x000730E0 File Offset: 0x000712E0
		public unsafe static SerializableEvent ConflictRewardsAssigned
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 33721, RefRangeEnd = 33723, XrefRangeStart = 33715, XrefRangeEnd = 33721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_get_ConflictRewardsAssigned_Public_Static_get_SerializableEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060002AC RID: 684 RVA: 0x00073114 File Offset: 0x00071314
		public unsafe static SerializableEvent InfluenceGained
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 33729, RefRangeEnd = 33734, XrefRangeStart = 33723, XrefRangeEnd = 33729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_get_InfluenceGained_Public_Static_get_SerializableEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060002AD RID: 685 RVA: 0x00073148 File Offset: 0x00071348
		public unsafe static SerializableEvent PreImperiumReplaced
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 33740, RefRangeEnd = 33741, XrefRangeStart = 33734, XrefRangeEnd = 33740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_get_PreImperiumReplaced_Public_Static_get_SerializableEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060002AE RID: 686 RVA: 0x0007317C File Offset: 0x0007137C
		public unsafe static SerializableEvent PlayerDeckChanged
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 33747, RefRangeEnd = 33748, XrefRangeStart = 33741, XrefRangeEnd = 33747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_get_PlayerDeckChanged_Public_Static_get_SerializableEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060002AF RID: 687 RVA: 0x000731B0 File Offset: 0x000713B0
		public unsafe static SerializableEvent AfterCardsRevealed
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 33754, RefRangeEnd = 33758, XrefRangeStart = 33748, XrefRangeEnd = 33754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_get_AfterCardsRevealed_Public_Static_get_SerializableEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x000731E4 File Offset: 0x000713E4
		public unsafe static SerializableEvent SolariGained
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33758, XrefRangeEnd = 33764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_get_SolariGained_Public_Static_get_SerializableEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x00073218 File Offset: 0x00071418
		public unsafe static SerializableEvent WaterGained
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33764, XrefRangeEnd = 33770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_get_WaterGained_Public_Static_get_SerializableEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x0007324C File Offset: 0x0007144C
		public unsafe static SerializableEvent LeaderSetupBaron
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 33776, RefRangeEnd = 33777, XrefRangeStart = 33770, XrefRangeEnd = 33776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_get_LeaderSetupBaron_Public_Static_get_SerializableEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x00073280 File Offset: 0x00071480
		public unsafe static SerializableEvent LeaderSetupHundro
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 33783, RefRangeEnd = 33784, XrefRangeStart = 33777, XrefRangeEnd = 33783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_get_LeaderSetupHundro_Public_Static_get_SerializableEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x000732B4 File Offset: 0x000714B4
		public unsafe static SerializableEvent SpaceInfiltrated
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 33790, RefRangeEnd = 33792, XrefRangeStart = 33784, XrefRangeEnd = 33790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_get_SpaceInfiltrated_Public_Static_get_SerializableEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x000732E8 File Offset: 0x000714E8
		public unsafe static SerializableEvent SwordmasterAcquired
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 33798, RefRangeEnd = 33799, XrefRangeStart = 33792, XrefRangeEnd = 33798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_get_SwordmasterAcquired_Public_Static_get_SerializableEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x0007331C File Offset: 0x0007151C
		public unsafe static SerializableEvent AllianceGained
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 33805, RefRangeEnd = 33808, XrefRangeStart = 33799, XrefRangeEnd = 33805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_get_AllianceGained_Public_Static_get_SerializableEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x00073350 File Offset: 0x00071550
		public unsafe static SerializableEvent TechTileAcquired
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 33814, RefRangeEnd = 33816, XrefRangeStart = 33808, XrefRangeEnd = 33814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_get_TechTileAcquired_Public_Static_get_SerializableEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x00073384 File Offset: 0x00071584
		public unsafe static SerializableEvent FamilyAtomicsUsed
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 33822, RefRangeEnd = 33824, XrefRangeStart = 33816, XrefRangeEnd = 33822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_get_FamilyAtomicsUsed_Public_Static_get_SerializableEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x000733B8 File Offset: 0x000715B8
		public unsafe static SerializableEvent ResearchGained
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 33830, RefRangeEnd = 33832, XrefRangeStart = 33824, XrefRangeEnd = 33830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_get_ResearchGained_Public_Static_get_SerializableEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x060002BA RID: 698 RVA: 0x000034B2 File Offset: 0x000016B2
		public Events(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeMethodInfoPtr_get_GameStarted_Public_Static_get_SerializableEvent_0;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeMethodInfoPtr_get_RoundStarted_Public_Static_get_SerializableEvent_0;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeMethodInfoPtr_get_RoundSetupFinished_Public_Static_get_SerializableEvent_0;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeMethodInfoPtr_get_RoundSetupFinishedIlesa_Public_Static_get_SerializableEvent_0;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeMethodInfoPtr_get_RoundEnded_Public_Static_get_SerializableEvent_0;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeMethodInfoPtr_get_TurnStarted_Public_Static_get_SerializableEvent_0;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeMethodInfoPtr_get_PreRevealTurnStarted_Public_Static_get_SerializableEvent_0;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeMethodInfoPtr_get_RevealTurnStarted_Public_Static_get_SerializableEvent_0;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeMethodInfoPtr_get_TurnEnded_Public_Static_get_SerializableEvent_0;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeMethodInfoPtr_get_ConflictStarted_Public_Static_get_SerializableEvent_0;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeMethodInfoPtr_get_ImperiumPlayed_Public_Static_get_SerializableEvent_0;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeMethodInfoPtr_get_ImperiumTrashed_Public_Static_get_SerializableEvent_0;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeMethodInfoPtr_get_ImperiumDiscardedForUnload_Public_Static_get_SerializableEvent_0;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeMethodInfoPtr_get_IntriguePlayed_Public_Static_get_SerializableEvent_0;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeMethodInfoPtr_get_HighCouncilSeatTaken_Public_Static_get_SerializableEvent_0;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeMethodInfoPtr_get_SolariPaidForSpace_Public_Static_get_SerializableEvent_0;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeMethodInfoPtr_get_WaterPaid_Public_Static_get_SerializableEvent_0;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeMethodInfoPtr_get_DeployedUnits_Public_Static_get_SerializableEvent_0;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeMethodInfoPtr_get_HarvestedSpice_Public_Static_get_SerializableEvent_0;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeMethodInfoPtr_get_AcquireImperium_Public_Static_get_SerializableEvent_0;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeMethodInfoPtr_get_AcquireIntrigue_Public_Static_get_SerializableEvent_0;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeMethodInfoPtr_get_SignetActivated_Public_Static_get_SerializableEvent_0;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeMethodInfoPtr_get_ConflictRewardsAssigned_Public_Static_get_SerializableEvent_0;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeMethodInfoPtr_get_InfluenceGained_Public_Static_get_SerializableEvent_0;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeMethodInfoPtr_get_PreImperiumReplaced_Public_Static_get_SerializableEvent_0;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerDeckChanged_Public_Static_get_SerializableEvent_0;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeMethodInfoPtr_get_AfterCardsRevealed_Public_Static_get_SerializableEvent_0;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeMethodInfoPtr_get_SolariGained_Public_Static_get_SerializableEvent_0;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeMethodInfoPtr_get_WaterGained_Public_Static_get_SerializableEvent_0;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeMethodInfoPtr_get_LeaderSetupBaron_Public_Static_get_SerializableEvent_0;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeMethodInfoPtr_get_LeaderSetupHundro_Public_Static_get_SerializableEvent_0;

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeMethodInfoPtr_get_SpaceInfiltrated_Public_Static_get_SerializableEvent_0;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeMethodInfoPtr_get_SwordmasterAcquired_Public_Static_get_SerializableEvent_0;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeMethodInfoPtr_get_AllianceGained_Public_Static_get_SerializableEvent_0;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeMethodInfoPtr_get_TechTileAcquired_Public_Static_get_SerializableEvent_0;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeMethodInfoPtr_get_FamilyAtomicsUsed_Public_Static_get_SerializableEvent_0;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeMethodInfoPtr_get_ResearchGained_Public_Static_get_SerializableEvent_0;
	}
}
