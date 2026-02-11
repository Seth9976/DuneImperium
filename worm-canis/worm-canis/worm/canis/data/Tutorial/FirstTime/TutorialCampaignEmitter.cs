using System;
using System.Runtime.InteropServices;
using Canis.actions;
using Canis.context;
using Canis.entities;
using Canis.tutorialScripts;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.data.Tutorial.FirstTime
{
	// Token: 0x0200004F RID: 79
	public static class TutorialCampaignEmitter : Object
	{
		// Token: 0x06000A9E RID: 2718 RVA: 0x0008A060 File Offset: 0x00088260
		// Note: this type is marked as 'beforefieldinit'.
		static TutorialCampaignEmitter()
		{
			Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.Tutorial.FirstTime", "TutorialCampaignEmitter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr);
			TutorialCampaignEmitter.NativeMethodInfoPtr_ConditionalIconCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665166);
			TutorialCampaignEmitter.NativeMethodInfoPtr_ConditionalIconFTT_Private_Static_IEnumerable_1_TutorialAction_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665167);
			TutorialCampaignEmitter.NativeMethodInfoPtr_ControlBonusCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665168);
			TutorialCampaignEmitter.NativeMethodInfoPtr_ControlBonusFTT_Private_Static_IEnumerable_1_TutorialAction_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665169);
			TutorialCampaignEmitter.NativeMethodInfoPtr_DiscardCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665170);
			TutorialCampaignEmitter.NativeMethodInfoPtr_DiscardFTT_Private_Static_IEnumerable_1_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665171);
			TutorialCampaignEmitter.NativeMethodInfoPtr_EndgameCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665172);
			TutorialCampaignEmitter.NativeMethodInfoPtr_EndgameFTT_Private_Static_IEnumerable_1_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665173);
			TutorialCampaignEmitter.NativeMethodInfoPtr_EndgameIntrigueCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665174);
			TutorialCampaignEmitter.NativeMethodInfoPtr_EndgameIntrigueFTT_Private_Static_IEnumerable_1_TutorialAction_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665175);
			TutorialCampaignEmitter.NativeMethodInfoPtr_FactionBonusCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665176);
			TutorialCampaignEmitter.NativeMethodInfoPtr_FactionBonusFTT_Private_Static_IEnumerable_1_TutorialAction_WormMatch_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665177);
			TutorialCampaignEmitter.NativeMethodInfoPtr_FirstGeneticCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665178);
			TutorialCampaignEmitter.NativeMethodInfoPtr_FirstGeneticFTT_Private_Static_IEnumerable_1_TutorialAction_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665179);
			TutorialCampaignEmitter.NativeMethodInfoPtr_FirstLiveGameCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665180);
			TutorialCampaignEmitter.NativeMethodInfoPtr_FirstLiveGameFTT_Private_Static_IEnumerable_1_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665181);
			TutorialCampaignEmitter.NativeMethodInfoPtr_FoldspaceCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665182);
			TutorialCampaignEmitter.NativeMethodInfoPtr_FoldspaceFTT_Private_Static_IEnumerable_1_TutorialAction_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665183);
			TutorialCampaignEmitter.NativeMethodInfoPtr_FremenBondCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665184);
			TutorialCampaignEmitter.NativeMethodInfoPtr_FremenBondFTT_Private_Static_IEnumerable_1_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665185);
			TutorialCampaignEmitter.NativeMethodInfoPtr_GraftCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665186);
			TutorialCampaignEmitter.NativeMethodInfoPtr_GraftFTT_Private_Static_IEnumerable_1_TutorialAction_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665187);
			TutorialCampaignEmitter.NativeMethodInfoPtr_GraftRevealCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665188);
			TutorialCampaignEmitter.NativeMethodInfoPtr_GraftRevealFTT_Private_Static_IEnumerable_1_TutorialAction_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665189);
			TutorialCampaignEmitter.NativeMethodInfoPtr_HagalImmortalityCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665190);
			TutorialCampaignEmitter.NativeMethodInfoPtr_HagalImmortalityFTT_Private_Static_IEnumerable_1_TutorialAction_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665191);
			TutorialCampaignEmitter.NativeMethodInfoPtr_RetreatCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665192);
			TutorialCampaignEmitter.NativeMethodInfoPtr_RetreatFTT_Private_Static_IEnumerable_1_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665193);
			TutorialCampaignEmitter.NativeMethodInfoPtr_SecondGeneticCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665194);
			TutorialCampaignEmitter.NativeMethodInfoPtr_SecondGeneticFTT_Private_Static_IEnumerable_1_TutorialAction_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665195);
			TutorialCampaignEmitter.NativeMethodInfoPtr_SpecimenCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665196);
			TutorialCampaignEmitter.NativeMethodInfoPtr_SpecimenFTT_Private_Static_IEnumerable_1_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665197);
			TutorialCampaignEmitter.NativeMethodInfoPtr_TleilaxuCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665198);
			TutorialCampaignEmitter.NativeMethodInfoPtr_TleilaxuFTT_Private_Static_IEnumerable_1_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665199);
			TutorialCampaignEmitter.NativeMethodInfoPtr_TrashingCardCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665200);
			TutorialCampaignEmitter.NativeMethodInfoPtr_TrashingCardFTT_Private_Static_IEnumerable_1_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665201);
			TutorialCampaignEmitter.NativeMethodInfoPtr_EmitBaseSetFirstTimeTrigger_Private_Static_Action_WormMatch_PlayerEntity_String_IEnumerable_1_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665202);
			TutorialCampaignEmitter.NativeMethodInfoPtr_EmitImmortalityFirstTimeTrigger_Private_Static_Action_WormMatch_PlayerEntity_String_IEnumerable_1_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665203);
			TutorialCampaignEmitter.NativeMethodInfoPtr_EmitFirstTimeTrigger_Private_Static_Action_WormMatch_PlayerEntity_String_IEnumerable_1_TutorialAction_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665204);
			TutorialCampaignEmitter.NativeMethodInfoPtr_EmitFirstTimeTrigger_Private_Static_Action_WormMatch_String_PlayerEntity_Boolean_Il2CppReferenceArray_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665205);
			TutorialCampaignEmitter.NativeMethodInfoPtr_BuildDialog_Private_Static_WormTutorialAction_String_Int32_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665206);
			TutorialCampaignEmitter.NativeMethodInfoPtr_ThufirSay_Private_Static_WormTutorialAction_String_Int32_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665207);
			TutorialCampaignEmitter.NativeMethodInfoPtr_HintAction_Private_Static_WormTutorialAction_Int32_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665208);
			TutorialCampaignEmitter.NativeMethodInfoPtr_VisualHighlight_Private_Static_WormTutorialAction_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665209);
			TutorialCampaignEmitter.NativeMethodInfoPtr_VisualHighlight_Private_Static_WormTutorialAction_Int32_String_byref_WormTutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665210);
			TutorialCampaignEmitter.NativeMethodInfoPtr_ArrowWithLabel_Private_Static_WormTutorialAction_Int32_String_String_byref_WormTutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665211);
			TutorialCampaignEmitter.NativeMethodInfoPtr_HideTutorialAction_Private_Static_WormTutorialAction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665212);
			TutorialCampaignEmitter.NativeMethodInfoPtr_ShouldNoop_Private_Static_Boolean_WormMatch_PlayerEntity_byref_NoopAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, 100665213);
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x0008A450 File Offset: 0x00088650
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 71915, RefRangeEnd = 71916, XrefRangeStart = 71904, XrefRangeEnd = 71915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Canis.actions.Action ConditionalIconCampaignEmitter(WormMatch wormMatch, PlayerEntity player)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_ConditionalIconCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x0008A4A8 File Offset: 0x000886A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71916, XrefRangeEnd = 71922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TutorialAction> ConditionalIconFTT(WormMatch wormMatch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_ConditionalIconFTT_Private_Static_IEnumerable_1_TutorialAction_WormMatch_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TutorialAction>>(intPtr3) : null;
			}
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x0008A4EC File Offset: 0x000886EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 71933, RefRangeEnd = 71934, XrefRangeStart = 71922, XrefRangeEnd = 71933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Canis.actions.Action ControlBonusCampaignEmitter(WormMatch wormMatch, PlayerEntity player)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_ControlBonusCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x0008A544 File Offset: 0x00088744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71934, XrefRangeEnd = 71940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TutorialAction> ControlBonusFTT(WormMatch wormMatch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_ControlBonusFTT_Private_Static_IEnumerable_1_TutorialAction_WormMatch_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TutorialAction>>(intPtr3) : null;
			}
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x0008A588 File Offset: 0x00088788
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 71970, RefRangeEnd = 71971, XrefRangeStart = 71940, XrefRangeEnd = 71970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Canis.actions.Action DiscardCampaignEmitter(WormMatch wormMatch, PlayerEntity player)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_DiscardCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x0008A5E0 File Offset: 0x000887E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71971, XrefRangeEnd = 71976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TutorialAction> DiscardFTT()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_DiscardFTT_Private_Static_IEnumerable_1_TutorialAction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TutorialAction>>(intPtr3) : null;
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x0008A614 File Offset: 0x00088814
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 71986, RefRangeEnd = 71987, XrefRangeStart = 71976, XrefRangeEnd = 71986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Canis.actions.Action EndgameCampaignEmitter(WormMatch wormMatch, PlayerEntity player)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_EndgameCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x0008A66C File Offset: 0x0008886C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71987, XrefRangeEnd = 71992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TutorialAction> EndgameFTT()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_EndgameFTT_Private_Static_IEnumerable_1_TutorialAction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TutorialAction>>(intPtr3) : null;
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x0008A6A0 File Offset: 0x000888A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 72003, RefRangeEnd = 72005, XrefRangeStart = 71992, XrefRangeEnd = 72003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Canis.actions.Action EndgameIntrigueCampaignEmitter(WormMatch wormMatch, PlayerEntity player, EntityID entityID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entityID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_EndgameIntrigueCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_EntityID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x0008A708 File Offset: 0x00088908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72005, XrefRangeEnd = 72011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TutorialAction> EndgameIntrigueFTT(EntityID entityID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_EndgameIntrigueFTT_Private_Static_IEnumerable_1_TutorialAction_EntityID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TutorialAction>>(intPtr3) : null;
			}
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x0008A74C File Offset: 0x0008894C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72023, RefRangeEnd = 72024, XrefRangeStart = 72011, XrefRangeEnd = 72023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Canis.actions.Action FactionBonusCampaignEmitter(WormMatch wormMatch, PlayerEntity player)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_FactionBonusCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x0008A7A4 File Offset: 0x000889A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72024, XrefRangeEnd = 72031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TutorialAction> FactionBonusFTT(WormMatch wormMatch, PlayerEntity player)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_FactionBonusFTT_Private_Static_IEnumerable_1_TutorialAction_WormMatch_PlayerEntity_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TutorialAction>>(intPtr3) : null;
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x0008A7FC File Offset: 0x000889FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72042, RefRangeEnd = 72043, XrefRangeStart = 72031, XrefRangeEnd = 72042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Canis.actions.Action FirstGeneticCampaignEmitter(WormMatch wormMatch, PlayerEntity player)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_FirstGeneticCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x0008A854 File Offset: 0x00088A54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72043, XrefRangeEnd = 72049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TutorialAction> FirstGeneticFTT(WormMatch wormMatch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_FirstGeneticFTT_Private_Static_IEnumerable_1_TutorialAction_WormMatch_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TutorialAction>>(intPtr3) : null;
			}
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x0008A898 File Offset: 0x00088A98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72057, RefRangeEnd = 72058, XrefRangeStart = 72049, XrefRangeEnd = 72057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Canis.actions.Action FirstLiveGameCampaignEmitter(WormMatch wormMatch, PlayerEntity player)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_FirstLiveGameCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x0008A8F0 File Offset: 0x00088AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72058, XrefRangeEnd = 72063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TutorialAction> FirstLiveGameFTT()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_FirstLiveGameFTT_Private_Static_IEnumerable_1_TutorialAction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TutorialAction>>(intPtr3) : null;
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x0008A924 File Offset: 0x00088B24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72074, RefRangeEnd = 72075, XrefRangeStart = 72063, XrefRangeEnd = 72074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Canis.actions.Action FoldspaceCampaignEmitter(WormMatch wormMatch, PlayerEntity player)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_FoldspaceCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x0008A97C File Offset: 0x00088B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72075, XrefRangeEnd = 72081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TutorialAction> FoldspaceFTT(PlayerEntity player)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_FoldspaceFTT_Private_Static_IEnumerable_1_TutorialAction_PlayerEntity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TutorialAction>>(intPtr3) : null;
			}
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x0008A9C0 File Offset: 0x00088BC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72111, RefRangeEnd = 72112, XrefRangeStart = 72081, XrefRangeEnd = 72111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Canis.actions.Action FremenBondCampaignEmitter(WormMatch wormMatch, PlayerEntity player)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_FremenBondCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x0008AA18 File Offset: 0x00088C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72112, XrefRangeEnd = 72117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TutorialAction> FremenBondFTT()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_FremenBondFTT_Private_Static_IEnumerable_1_TutorialAction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TutorialAction>>(intPtr3) : null;
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x0008AA4C File Offset: 0x00088C4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72128, RefRangeEnd = 72129, XrefRangeStart = 72117, XrefRangeEnd = 72128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Canis.actions.Action GraftCampaignEmitter(WormMatch wormMatch, PlayerEntity player)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_GraftCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x0008AAA4 File Offset: 0x00088CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72129, XrefRangeEnd = 72135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TutorialAction> GraftFTT(PlayerEntity player)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_GraftFTT_Private_Static_IEnumerable_1_TutorialAction_PlayerEntity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TutorialAction>>(intPtr3) : null;
			}
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x0008AAE8 File Offset: 0x00088CE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72146, RefRangeEnd = 72147, XrefRangeStart = 72135, XrefRangeEnd = 72146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Canis.actions.Action GraftRevealCampaignEmitter(WormMatch wormMatch, PlayerEntity player)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_GraftRevealCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x0008AB40 File Offset: 0x00088D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72147, XrefRangeEnd = 72153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TutorialAction> GraftRevealFTT(PlayerEntity player)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_GraftRevealFTT_Private_Static_IEnumerable_1_TutorialAction_PlayerEntity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TutorialAction>>(intPtr3) : null;
			}
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x0008AB84 File Offset: 0x00088D84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72164, RefRangeEnd = 72165, XrefRangeStart = 72153, XrefRangeEnd = 72164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Canis.actions.Action HagalImmortalityCampaignEmitter(WormMatch wormMatch, PlayerEntity player)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_HagalImmortalityCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x0008ABDC File Offset: 0x00088DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72165, XrefRangeEnd = 72171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TutorialAction> HagalImmortalityFTT(WormMatch wormMatch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_HagalImmortalityFTT_Private_Static_IEnumerable_1_TutorialAction_WormMatch_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TutorialAction>>(intPtr3) : null;
			}
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x0008AC20 File Offset: 0x00088E20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 72181, RefRangeEnd = 72183, XrefRangeStart = 72171, XrefRangeEnd = 72181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Canis.actions.Action RetreatCampaignEmitter(WormMatch wormMatch, PlayerEntity player)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_RetreatCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x0008AC78 File Offset: 0x00088E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72183, XrefRangeEnd = 72188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TutorialAction> RetreatFTT()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_RetreatFTT_Private_Static_IEnumerable_1_TutorialAction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TutorialAction>>(intPtr3) : null;
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x0008ACAC File Offset: 0x00088EAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72199, RefRangeEnd = 72200, XrefRangeStart = 72188, XrefRangeEnd = 72199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Canis.actions.Action SecondGeneticCampaignEmitter(WormMatch wormMatch, PlayerEntity player)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_SecondGeneticCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x0008AD04 File Offset: 0x00088F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72200, XrefRangeEnd = 72206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TutorialAction> SecondGeneticFTT(WormMatch wormMatch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_SecondGeneticFTT_Private_Static_IEnumerable_1_TutorialAction_WormMatch_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TutorialAction>>(intPtr3) : null;
			}
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x0008AD48 File Offset: 0x00088F48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72214, RefRangeEnd = 72215, XrefRangeStart = 72206, XrefRangeEnd = 72214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Canis.actions.Action SpecimenCampaignEmitter(WormMatch wormMatch, PlayerEntity player)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_SpecimenCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x0008ADA0 File Offset: 0x00088FA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72215, XrefRangeEnd = 72220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TutorialAction> SpecimenFTT()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_SpecimenFTT_Private_Static_IEnumerable_1_TutorialAction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TutorialAction>>(intPtr3) : null;
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x0008ADD4 File Offset: 0x00088FD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72230, RefRangeEnd = 72231, XrefRangeStart = 72220, XrefRangeEnd = 72230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Canis.actions.Action TleilaxuCampaignEmitter(WormMatch wormMatch, PlayerEntity player)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_TleilaxuCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x0008AE2C File Offset: 0x0008902C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72231, XrefRangeEnd = 72236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TutorialAction> TleilaxuFTT()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_TleilaxuFTT_Private_Static_IEnumerable_1_TutorialAction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TutorialAction>>(intPtr3) : null;
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x0008AE60 File Offset: 0x00089060
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72246, RefRangeEnd = 72247, XrefRangeStart = 72236, XrefRangeEnd = 72246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Canis.actions.Action TrashingCardCampaignEmitter(WormMatch wormMatch, PlayerEntity player)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_TrashingCardCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x0008AEB8 File Offset: 0x000890B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72247, XrefRangeEnd = 72252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TutorialAction> TrashingCardFTT()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_TrashingCardFTT_Private_Static_IEnumerable_1_TutorialAction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TutorialAction>>(intPtr3) : null;
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x0008AEEC File Offset: 0x000890EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72252, XrefRangeEnd = 72255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Canis.actions.Action EmitBaseSetFirstTimeTrigger(WormMatch wormMatch, PlayerEntity player, string key, IEnumerable<TutorialAction> actions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_EmitBaseSetFirstTimeTrigger_Private_Static_Action_WormMatch_PlayerEntity_String_IEnumerable_1_TutorialAction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x0008AF68 File Offset: 0x00089168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72255, XrefRangeEnd = 72258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Canis.actions.Action EmitImmortalityFirstTimeTrigger(WormMatch wormMatch, PlayerEntity player, string key, IEnumerable<TutorialAction> actions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_EmitImmortalityFirstTimeTrigger_Private_Static_Action_WormMatch_PlayerEntity_String_IEnumerable_1_TutorialAction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x0008AFE4 File Offset: 0x000891E4
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 72283, RefRangeEnd = 72301, XrefRangeStart = 72258, XrefRangeEnd = 72283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Canis.actions.Action EmitFirstTimeTrigger(WormMatch wormMatch, PlayerEntity player, string key, IEnumerable<TutorialAction> actions, string requiredTutorial = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actions);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(requiredTutorial);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_EmitFirstTimeTrigger_Private_Static_Action_WormMatch_PlayerEntity_String_IEnumerable_1_TutorialAction_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x0008B074 File Offset: 0x00089274
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 72331, RefRangeEnd = 72333, XrefRangeStart = 72301, XrefRangeEnd = 72331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Canis.actions.Action EmitFirstTimeTrigger(WormMatch wormMatch, string key, PlayerEntity player, bool force = false, [Optional] Il2CppReferenceArray<Canis.actions.Action> actions)
		{
			if (actions == null)
			{
				actions = new Il2CppReferenceArray<Canis.actions.Action>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref force;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_EmitFirstTimeTrigger_Private_Static_Action_WormMatch_String_PlayerEntity_Boolean_Il2CppReferenceArray_1_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x0008B10C File Offset: 0x0008930C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72333, XrefRangeEnd = 72336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WormTutorialAction BuildDialog(string text, int id = 0, bool blocking = true, string dialogType = "ClickToContinue")
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_BuildDialog_Private_Static_WormTutorialAction_String_Int32_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormTutorialAction>(intPtr3) : null;
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x0008B180 File Offset: 0x00089380
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 72349, RefRangeEnd = 72362, XrefRangeStart = 72336, XrefRangeEnd = 72349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WormTutorialAction ThufirSay(string text, int id = 0, bool blocking = true, string dialogType = "ClickToContinue")
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_ThufirSay_Private_Static_WormTutorialAction_String_Int32_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormTutorialAction>(intPtr3) : null;
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x0008B1F4 File Offset: 0x000893F4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 72365, RefRangeEnd = 72369, XrefRangeStart = 72362, XrefRangeEnd = 72365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WormTutorialAction HintAction(int id, [Optional] Il2CppStringArray vfxTags)
		{
			if (vfxTags == null)
			{
				vfxTags = new Il2CppStringArray(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vfxTags);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_HintAction_Private_Static_WormTutorialAction_Int32_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormTutorialAction>(intPtr3) : null;
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x0008B254 File Offset: 0x00089454
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 72374, RefRangeEnd = 72386, XrefRangeStart = 72369, XrefRangeEnd = 72374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WormTutorialAction VisualHighlight(int id, string identifier)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(identifier);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_VisualHighlight_Private_Static_WormTutorialAction_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormTutorialAction>(intPtr3) : null;
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x0008B2A8 File Offset: 0x000894A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72386, XrefRangeEnd = 72391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WormTutorialAction VisualHighlight(int id, string identifier, out WormTutorialAction hide)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(identifier);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_VisualHighlight_Private_Static_WormTutorialAction_Int32_String_byref_WormTutorialAction_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			hide = ((intPtr4 == 0) ? null : new WormTutorialAction(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<WormTutorialAction>(intPtr5) : null;
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x0008B320 File Offset: 0x00089520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72391, XrefRangeEnd = 72410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WormTutorialAction ArrowWithLabel(int id, string identifier, string label, out WormTutorialAction hide)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(identifier);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_ArrowWithLabel_Private_Static_WormTutorialAction_Int32_String_String_byref_WormTutorialAction_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			hide = ((intPtr4 == 0) ? null : new WormTutorialAction(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<WormTutorialAction>(intPtr5) : null;
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x0008B3A8 File Offset: 0x000895A8
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 72415, RefRangeEnd = 72431, XrefRangeStart = 72410, XrefRangeEnd = 72415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WormTutorialAction HideTutorialAction(int id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_HideTutorialAction_Private_Static_WormTutorialAction_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormTutorialAction>(intPtr3) : null;
			}
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x0008B3E8 File Offset: 0x000895E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72431, XrefRangeEnd = 72434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShouldNoop(WormMatch wormMatch, PlayerEntity player, out NoopAction noop)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.NativeMethodInfoPtr_ShouldNoop_Private_Static_Boolean_WormMatch_PlayerEntity_byref_NoopAction_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			noop = ((intPtr4 == 0) ? null : new NoopAction(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x00006BB3 File Offset: 0x00004DB3
		public static Canis.actions.Action EmitFirstTimeTrigger(WormMatch wormMatch, string key, PlayerEntity player, [Optional] bool force, params Canis.actions.Action[] actions)
		{
			return TutorialCampaignEmitter.EmitFirstTimeTrigger(wormMatch, key, player, force, new Il2CppReferenceArray<Canis.actions.Action>(actions));
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x00006BC5 File Offset: 0x00004DC5
		public static WormTutorialAction HintAction(int id, params string[] vfxTags)
		{
			return TutorialCampaignEmitter.HintAction(id, new Il2CppStringArray(vfxTags));
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x00006BD3 File Offset: 0x00004DD3
		public TutorialCampaignEmitter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006A3 RID: 1699
		private static readonly IntPtr NativeMethodInfoPtr_ConditionalIconCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0;

		// Token: 0x040006A4 RID: 1700
		private static readonly IntPtr NativeMethodInfoPtr_ConditionalIconFTT_Private_Static_IEnumerable_1_TutorialAction_WormMatch_0;

		// Token: 0x040006A5 RID: 1701
		private static readonly IntPtr NativeMethodInfoPtr_ControlBonusCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0;

		// Token: 0x040006A6 RID: 1702
		private static readonly IntPtr NativeMethodInfoPtr_ControlBonusFTT_Private_Static_IEnumerable_1_TutorialAction_WormMatch_0;

		// Token: 0x040006A7 RID: 1703
		private static readonly IntPtr NativeMethodInfoPtr_DiscardCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0;

		// Token: 0x040006A8 RID: 1704
		private static readonly IntPtr NativeMethodInfoPtr_DiscardFTT_Private_Static_IEnumerable_1_TutorialAction_0;

		// Token: 0x040006A9 RID: 1705
		private static readonly IntPtr NativeMethodInfoPtr_EndgameCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0;

		// Token: 0x040006AA RID: 1706
		private static readonly IntPtr NativeMethodInfoPtr_EndgameFTT_Private_Static_IEnumerable_1_TutorialAction_0;

		// Token: 0x040006AB RID: 1707
		private static readonly IntPtr NativeMethodInfoPtr_EndgameIntrigueCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_EntityID_0;

		// Token: 0x040006AC RID: 1708
		private static readonly IntPtr NativeMethodInfoPtr_EndgameIntrigueFTT_Private_Static_IEnumerable_1_TutorialAction_EntityID_0;

		// Token: 0x040006AD RID: 1709
		private static readonly IntPtr NativeMethodInfoPtr_FactionBonusCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0;

		// Token: 0x040006AE RID: 1710
		private static readonly IntPtr NativeMethodInfoPtr_FactionBonusFTT_Private_Static_IEnumerable_1_TutorialAction_WormMatch_PlayerEntity_0;

		// Token: 0x040006AF RID: 1711
		private static readonly IntPtr NativeMethodInfoPtr_FirstGeneticCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0;

		// Token: 0x040006B0 RID: 1712
		private static readonly IntPtr NativeMethodInfoPtr_FirstGeneticFTT_Private_Static_IEnumerable_1_TutorialAction_WormMatch_0;

		// Token: 0x040006B1 RID: 1713
		private static readonly IntPtr NativeMethodInfoPtr_FirstLiveGameCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0;

		// Token: 0x040006B2 RID: 1714
		private static readonly IntPtr NativeMethodInfoPtr_FirstLiveGameFTT_Private_Static_IEnumerable_1_TutorialAction_0;

		// Token: 0x040006B3 RID: 1715
		private static readonly IntPtr NativeMethodInfoPtr_FoldspaceCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0;

		// Token: 0x040006B4 RID: 1716
		private static readonly IntPtr NativeMethodInfoPtr_FoldspaceFTT_Private_Static_IEnumerable_1_TutorialAction_PlayerEntity_0;

		// Token: 0x040006B5 RID: 1717
		private static readonly IntPtr NativeMethodInfoPtr_FremenBondCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0;

		// Token: 0x040006B6 RID: 1718
		private static readonly IntPtr NativeMethodInfoPtr_FremenBondFTT_Private_Static_IEnumerable_1_TutorialAction_0;

		// Token: 0x040006B7 RID: 1719
		private static readonly IntPtr NativeMethodInfoPtr_GraftCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0;

		// Token: 0x040006B8 RID: 1720
		private static readonly IntPtr NativeMethodInfoPtr_GraftFTT_Private_Static_IEnumerable_1_TutorialAction_PlayerEntity_0;

		// Token: 0x040006B9 RID: 1721
		private static readonly IntPtr NativeMethodInfoPtr_GraftRevealCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0;

		// Token: 0x040006BA RID: 1722
		private static readonly IntPtr NativeMethodInfoPtr_GraftRevealFTT_Private_Static_IEnumerable_1_TutorialAction_PlayerEntity_0;

		// Token: 0x040006BB RID: 1723
		private static readonly IntPtr NativeMethodInfoPtr_HagalImmortalityCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0;

		// Token: 0x040006BC RID: 1724
		private static readonly IntPtr NativeMethodInfoPtr_HagalImmortalityFTT_Private_Static_IEnumerable_1_TutorialAction_WormMatch_0;

		// Token: 0x040006BD RID: 1725
		private static readonly IntPtr NativeMethodInfoPtr_RetreatCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0;

		// Token: 0x040006BE RID: 1726
		private static readonly IntPtr NativeMethodInfoPtr_RetreatFTT_Private_Static_IEnumerable_1_TutorialAction_0;

		// Token: 0x040006BF RID: 1727
		private static readonly IntPtr NativeMethodInfoPtr_SecondGeneticCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0;

		// Token: 0x040006C0 RID: 1728
		private static readonly IntPtr NativeMethodInfoPtr_SecondGeneticFTT_Private_Static_IEnumerable_1_TutorialAction_WormMatch_0;

		// Token: 0x040006C1 RID: 1729
		private static readonly IntPtr NativeMethodInfoPtr_SpecimenCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0;

		// Token: 0x040006C2 RID: 1730
		private static readonly IntPtr NativeMethodInfoPtr_SpecimenFTT_Private_Static_IEnumerable_1_TutorialAction_0;

		// Token: 0x040006C3 RID: 1731
		private static readonly IntPtr NativeMethodInfoPtr_TleilaxuCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0;

		// Token: 0x040006C4 RID: 1732
		private static readonly IntPtr NativeMethodInfoPtr_TleilaxuFTT_Private_Static_IEnumerable_1_TutorialAction_0;

		// Token: 0x040006C5 RID: 1733
		private static readonly IntPtr NativeMethodInfoPtr_TrashingCardCampaignEmitter_Public_Static_Action_WormMatch_PlayerEntity_0;

		// Token: 0x040006C6 RID: 1734
		private static readonly IntPtr NativeMethodInfoPtr_TrashingCardFTT_Private_Static_IEnumerable_1_TutorialAction_0;

		// Token: 0x040006C7 RID: 1735
		private static readonly IntPtr NativeMethodInfoPtr_EmitBaseSetFirstTimeTrigger_Private_Static_Action_WormMatch_PlayerEntity_String_IEnumerable_1_TutorialAction_0;

		// Token: 0x040006C8 RID: 1736
		private static readonly IntPtr NativeMethodInfoPtr_EmitImmortalityFirstTimeTrigger_Private_Static_Action_WormMatch_PlayerEntity_String_IEnumerable_1_TutorialAction_0;

		// Token: 0x040006C9 RID: 1737
		private static readonly IntPtr NativeMethodInfoPtr_EmitFirstTimeTrigger_Private_Static_Action_WormMatch_PlayerEntity_String_IEnumerable_1_TutorialAction_String_0;

		// Token: 0x040006CA RID: 1738
		private static readonly IntPtr NativeMethodInfoPtr_EmitFirstTimeTrigger_Private_Static_Action_WormMatch_String_PlayerEntity_Boolean_Il2CppReferenceArray_1_Action_0;

		// Token: 0x040006CB RID: 1739
		private static readonly IntPtr NativeMethodInfoPtr_BuildDialog_Private_Static_WormTutorialAction_String_Int32_Boolean_String_0;

		// Token: 0x040006CC RID: 1740
		private static readonly IntPtr NativeMethodInfoPtr_ThufirSay_Private_Static_WormTutorialAction_String_Int32_Boolean_String_0;

		// Token: 0x040006CD RID: 1741
		private static readonly IntPtr NativeMethodInfoPtr_HintAction_Private_Static_WormTutorialAction_Int32_Il2CppStringArray_0;

		// Token: 0x040006CE RID: 1742
		private static readonly IntPtr NativeMethodInfoPtr_VisualHighlight_Private_Static_WormTutorialAction_Int32_String_0;

		// Token: 0x040006CF RID: 1743
		private static readonly IntPtr NativeMethodInfoPtr_VisualHighlight_Private_Static_WormTutorialAction_Int32_String_byref_WormTutorialAction_0;

		// Token: 0x040006D0 RID: 1744
		private static readonly IntPtr NativeMethodInfoPtr_ArrowWithLabel_Private_Static_WormTutorialAction_Int32_String_String_byref_WormTutorialAction_0;

		// Token: 0x040006D1 RID: 1745
		private static readonly IntPtr NativeMethodInfoPtr_HideTutorialAction_Private_Static_WormTutorialAction_Int32_0;

		// Token: 0x040006D2 RID: 1746
		private static readonly IntPtr NativeMethodInfoPtr_ShouldNoop_Private_Static_Boolean_WormMatch_PlayerEntity_byref_NoopAction_0;

		// Token: 0x020005FC RID: 1532
		[ObfuscatedName("worm.canis.data.Tutorial.FirstTime.TutorialCampaignEmitter+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06004C8F RID: 19599 RVA: 0x0019C904 File Offset: 0x0019AB04
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TutorialCampaignEmitter.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialCampaignEmitter.__c>.NativeClassPtr);
				TutorialCampaignEmitter.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter.__c>.NativeClassPtr, "<>9");
				TutorialCampaignEmitter.__c.NativeFieldInfoPtr___9__1_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter.__c>.NativeClassPtr, "<>9__1_1");
				TutorialCampaignEmitter.__c.NativeFieldInfoPtr___9__13_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter.__c>.NativeClassPtr, "<>9__13_1");
				TutorialCampaignEmitter.__c.NativeFieldInfoPtr___9__21_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter.__c>.NativeClassPtr, "<>9__21_1");
				TutorialCampaignEmitter.__c.NativeFieldInfoPtr___9__23_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter.__c>.NativeClassPtr, "<>9__23_1");
				TutorialCampaignEmitter.__c.NativeFieldInfoPtr___9__29_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter.__c>.NativeClassPtr, "<>9__29_1");
				TutorialCampaignEmitter.__c.NativeFieldInfoPtr___9__31_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter.__c>.NativeClassPtr, "<>9__31_0");
				TutorialCampaignEmitter.__c.NativeFieldInfoPtr___9__31_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter.__c>.NativeClassPtr, "<>9__31_1");
				TutorialCampaignEmitter.__c.NativeFieldInfoPtr___9__31_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter.__c>.NativeClassPtr, "<>9__31_2");
				TutorialCampaignEmitter.__c.NativeFieldInfoPtr___9__33_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter.__c>.NativeClassPtr, "<>9__33_0");
				TutorialCampaignEmitter.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter.__c>.NativeClassPtr, 100665215);
				TutorialCampaignEmitter.__c.NativeMethodInfoPtr__ConditionalIconFTT_b__1_1_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter.__c>.NativeClassPtr, 100665216);
				TutorialCampaignEmitter.__c.NativeMethodInfoPtr__FirstGeneticFTT_b__13_1_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter.__c>.NativeClassPtr, 100665217);
				TutorialCampaignEmitter.__c.NativeMethodInfoPtr__GraftFTT_b__21_1_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter.__c>.NativeClassPtr, 100665218);
				TutorialCampaignEmitter.__c.NativeMethodInfoPtr__GraftRevealFTT_b__23_1_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter.__c>.NativeClassPtr, 100665219);
				TutorialCampaignEmitter.__c.NativeMethodInfoPtr__SecondGeneticFTT_b__29_1_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter.__c>.NativeClassPtr, 100665220);
				TutorialCampaignEmitter.__c.NativeMethodInfoPtr__SpecimenFTT_b__31_0_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter.__c>.NativeClassPtr, 100665221);
				TutorialCampaignEmitter.__c.NativeMethodInfoPtr__SpecimenFTT_b__31_1_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter.__c>.NativeClassPtr, 100665222);
				TutorialCampaignEmitter.__c.NativeMethodInfoPtr__SpecimenFTT_b__31_2_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter.__c>.NativeClassPtr, 100665223);
				TutorialCampaignEmitter.__c.NativeMethodInfoPtr__TleilaxuFTT_b__33_0_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter.__c>.NativeClassPtr, 100665224);
			}

			// Token: 0x06004C90 RID: 19600 RVA: 0x0019CAC0 File Offset: 0x0019ACC0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialCampaignEmitter.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004C91 RID: 19601 RVA: 0x0019CAFC File Offset: 0x0019ACFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70842, XrefRangeEnd = 70856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ConditionalIconFTT_b__1_1(Entity card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.__c.NativeMethodInfoPtr__ConditionalIconFTT_b__1_1_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004C92 RID: 19602 RVA: 0x0019CB4C File Offset: 0x0019AD4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70856, XrefRangeEnd = 70863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _FirstGeneticFTT_b__13_1(Entity space)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(space);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.__c.NativeMethodInfoPtr__FirstGeneticFTT_b__13_1_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004C93 RID: 19603 RVA: 0x0019CB9C File Offset: 0x0019AD9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70863, XrefRangeEnd = 70880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GraftFTT_b__21_1(Entity card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.__c.NativeMethodInfoPtr__GraftFTT_b__21_1_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004C94 RID: 19604 RVA: 0x0019CBEC File Offset: 0x0019ADEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70880, XrefRangeEnd = 70897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GraftRevealFTT_b__23_1(Entity card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.__c.NativeMethodInfoPtr__GraftRevealFTT_b__23_1_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004C95 RID: 19605 RVA: 0x0019CC3C File Offset: 0x0019AE3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70897, XrefRangeEnd = 70904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SecondGeneticFTT_b__29_1(Entity space)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(space);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.__c.NativeMethodInfoPtr__SecondGeneticFTT_b__29_1_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004C96 RID: 19606 RVA: 0x0019CC8C File Offset: 0x0019AE8C
			[CallerCount(0)]
			public unsafe Entity _SpecimenFTT_b__31_0(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.__c.NativeMethodInfoPtr__SpecimenFTT_b__31_0_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004C97 RID: 19607 RVA: 0x0019CCDC File Offset: 0x0019AEDC
			[CallerCount(0)]
			public unsafe Entity _SpecimenFTT_b__31_1(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.__c.NativeMethodInfoPtr__SpecimenFTT_b__31_1_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004C98 RID: 19608 RVA: 0x0019CD2C File Offset: 0x0019AF2C
			[CallerCount(0)]
			public unsafe Entity _SpecimenFTT_b__31_2(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.__c.NativeMethodInfoPtr__SpecimenFTT_b__31_2_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004C99 RID: 19609 RVA: 0x0019CD7C File Offset: 0x0019AF7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70904, XrefRangeEnd = 70906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _TleilaxuFTT_b__33_0(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.__c.NativeMethodInfoPtr__TleilaxuFTT_b__33_0_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004C9A RID: 19610 RVA: 0x0001A3DE File Offset: 0x000185DE
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012B5 RID: 4789
			// (get) Token: 0x06004C9B RID: 19611 RVA: 0x0019CDCC File Offset: 0x0019AFCC
			// (set) Token: 0x06004C9C RID: 19612 RVA: 0x0001A3E7 File Offset: 0x000185E7
			public unsafe static TutorialCampaignEmitter.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TutorialCampaignEmitter.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialCampaignEmitter.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TutorialCampaignEmitter.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012B6 RID: 4790
			// (get) Token: 0x06004C9D RID: 19613 RVA: 0x0019CDF4 File Offset: 0x0019AFF4
			// (set) Token: 0x06004C9E RID: 19614 RVA: 0x0001A3F9 File Offset: 0x000185F9
			public unsafe static Func<Entity, bool> __9__1_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TutorialCampaignEmitter.__c.NativeFieldInfoPtr___9__1_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TutorialCampaignEmitter.__c.NativeFieldInfoPtr___9__1_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012B7 RID: 4791
			// (get) Token: 0x06004C9F RID: 19615 RVA: 0x0019CE1C File Offset: 0x0019B01C
			// (set) Token: 0x06004CA0 RID: 19616 RVA: 0x0001A40B File Offset: 0x0001860B
			public unsafe static Func<Entity, bool> __9__13_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TutorialCampaignEmitter.__c.NativeFieldInfoPtr___9__13_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TutorialCampaignEmitter.__c.NativeFieldInfoPtr___9__13_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012B8 RID: 4792
			// (get) Token: 0x06004CA1 RID: 19617 RVA: 0x0019CE44 File Offset: 0x0019B044
			// (set) Token: 0x06004CA2 RID: 19618 RVA: 0x0001A41D File Offset: 0x0001861D
			public unsafe static Func<Entity, bool> __9__21_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TutorialCampaignEmitter.__c.NativeFieldInfoPtr___9__21_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TutorialCampaignEmitter.__c.NativeFieldInfoPtr___9__21_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012B9 RID: 4793
			// (get) Token: 0x06004CA3 RID: 19619 RVA: 0x0019CE6C File Offset: 0x0019B06C
			// (set) Token: 0x06004CA4 RID: 19620 RVA: 0x0001A42F File Offset: 0x0001862F
			public unsafe static Func<Entity, bool> __9__23_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TutorialCampaignEmitter.__c.NativeFieldInfoPtr___9__23_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TutorialCampaignEmitter.__c.NativeFieldInfoPtr___9__23_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012BA RID: 4794
			// (get) Token: 0x06004CA5 RID: 19621 RVA: 0x0019CE94 File Offset: 0x0019B094
			// (set) Token: 0x06004CA6 RID: 19622 RVA: 0x0001A441 File Offset: 0x00018641
			public unsafe static Func<Entity, bool> __9__29_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TutorialCampaignEmitter.__c.NativeFieldInfoPtr___9__29_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TutorialCampaignEmitter.__c.NativeFieldInfoPtr___9__29_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012BB RID: 4795
			// (get) Token: 0x06004CA7 RID: 19623 RVA: 0x0019CEBC File Offset: 0x0019B0BC
			// (set) Token: 0x06004CA8 RID: 19624 RVA: 0x0001A453 File Offset: 0x00018653
			public unsafe static Func<WormPlaymat, Entity> __9__31_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TutorialCampaignEmitter.__c.NativeFieldInfoPtr___9__31_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TutorialCampaignEmitter.__c.NativeFieldInfoPtr___9__31_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012BC RID: 4796
			// (get) Token: 0x06004CA9 RID: 19625 RVA: 0x0019CEE4 File Offset: 0x0019B0E4
			// (set) Token: 0x06004CAA RID: 19626 RVA: 0x0001A465 File Offset: 0x00018665
			public unsafe static Func<WormPlaymat, Entity> __9__31_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TutorialCampaignEmitter.__c.NativeFieldInfoPtr___9__31_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TutorialCampaignEmitter.__c.NativeFieldInfoPtr___9__31_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012BD RID: 4797
			// (get) Token: 0x06004CAB RID: 19627 RVA: 0x0019CF0C File Offset: 0x0019B10C
			// (set) Token: 0x06004CAC RID: 19628 RVA: 0x0001A477 File Offset: 0x00018677
			public unsafe static Func<WormPlaymat, Entity> __9__31_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TutorialCampaignEmitter.__c.NativeFieldInfoPtr___9__31_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TutorialCampaignEmitter.__c.NativeFieldInfoPtr___9__31_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012BE RID: 4798
			// (get) Token: 0x06004CAD RID: 19629 RVA: 0x0019CF34 File Offset: 0x0019B134
			// (set) Token: 0x06004CAE RID: 19630 RVA: 0x0001A489 File Offset: 0x00018689
			public unsafe static Func<WormPlaymat, Entity> __9__33_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TutorialCampaignEmitter.__c.NativeFieldInfoPtr___9__33_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TutorialCampaignEmitter.__c.NativeFieldInfoPtr___9__33_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003249 RID: 12873
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400324A RID: 12874
			private static readonly IntPtr NativeFieldInfoPtr___9__1_1;

			// Token: 0x0400324B RID: 12875
			private static readonly IntPtr NativeFieldInfoPtr___9__13_1;

			// Token: 0x0400324C RID: 12876
			private static readonly IntPtr NativeFieldInfoPtr___9__21_1;

			// Token: 0x0400324D RID: 12877
			private static readonly IntPtr NativeFieldInfoPtr___9__23_1;

			// Token: 0x0400324E RID: 12878
			private static readonly IntPtr NativeFieldInfoPtr___9__29_1;

			// Token: 0x0400324F RID: 12879
			private static readonly IntPtr NativeFieldInfoPtr___9__31_0;

			// Token: 0x04003250 RID: 12880
			private static readonly IntPtr NativeFieldInfoPtr___9__31_1;

			// Token: 0x04003251 RID: 12881
			private static readonly IntPtr NativeFieldInfoPtr___9__31_2;

			// Token: 0x04003252 RID: 12882
			private static readonly IntPtr NativeFieldInfoPtr___9__33_0;

			// Token: 0x04003253 RID: 12883
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003254 RID: 12884
			private static readonly IntPtr NativeMethodInfoPtr__ConditionalIconFTT_b__1_1_Internal_Boolean_Entity_0;

			// Token: 0x04003255 RID: 12885
			private static readonly IntPtr NativeMethodInfoPtr__FirstGeneticFTT_b__13_1_Internal_Boolean_Entity_0;

			// Token: 0x04003256 RID: 12886
			private static readonly IntPtr NativeMethodInfoPtr__GraftFTT_b__21_1_Internal_Boolean_Entity_0;

			// Token: 0x04003257 RID: 12887
			private static readonly IntPtr NativeMethodInfoPtr__GraftRevealFTT_b__23_1_Internal_Boolean_Entity_0;

			// Token: 0x04003258 RID: 12888
			private static readonly IntPtr NativeMethodInfoPtr__SecondGeneticFTT_b__29_1_Internal_Boolean_Entity_0;

			// Token: 0x04003259 RID: 12889
			private static readonly IntPtr NativeMethodInfoPtr__SpecimenFTT_b__31_0_Internal_Entity_WormPlaymat_0;

			// Token: 0x0400325A RID: 12890
			private static readonly IntPtr NativeMethodInfoPtr__SpecimenFTT_b__31_1_Internal_Entity_WormPlaymat_0;

			// Token: 0x0400325B RID: 12891
			private static readonly IntPtr NativeMethodInfoPtr__SpecimenFTT_b__31_2_Internal_Entity_WormPlaymat_0;

			// Token: 0x0400325C RID: 12892
			private static readonly IntPtr NativeMethodInfoPtr__TleilaxuFTT_b__33_0_Internal_Entity_WormPlaymat_0;
		}

		// Token: 0x020005FD RID: 1533
		[ObfuscatedName("worm.canis.data.Tutorial.FirstTime.TutorialCampaignEmitter+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Object
		{
			// Token: 0x06004CAF RID: 19631 RVA: 0x0019CF5C File Offset: 0x0019B15C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<TutorialCampaignEmitter.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialCampaignEmitter.__c__DisplayClass11_0>.NativeClassPtr);
				TutorialCampaignEmitter.__c__DisplayClass11_0.NativeFieldInfoPtr_wormPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter.__c__DisplayClass11_0>.NativeClassPtr, "wormPlayer");
				TutorialCampaignEmitter.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter.__c__DisplayClass11_0>.NativeClassPtr, 100665225);
				TutorialCampaignEmitter.__c__DisplayClass11_0.NativeMethodInfoPtr__FactionBonusFTT_b__0_Internal_Boolean_WormFactionTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter.__c__DisplayClass11_0>.NativeClassPtr, 100665226);
			}

			// Token: 0x06004CB0 RID: 19632 RVA: 0x0019CFC4 File Offset: 0x0019B1C4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialCampaignEmitter.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004CB1 RID: 19633 RVA: 0x0019D000 File Offset: 0x0019B200
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70906, XrefRangeEnd = 70908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _FactionBonusFTT_b__0(WormFactionTrack t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.__c__DisplayClass11_0.NativeMethodInfoPtr__FactionBonusFTT_b__0_Internal_Boolean_WormFactionTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004CB2 RID: 19634 RVA: 0x0001A49B File Offset: 0x0001869B
			public __c__DisplayClass11_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012BF RID: 4799
			// (get) Token: 0x06004CB3 RID: 19635 RVA: 0x0019D050 File Offset: 0x0019B250
			// (set) Token: 0x06004CB4 RID: 19636 RVA: 0x0001A4A4 File Offset: 0x000186A4
			public unsafe WormPlayer wormPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter.__c__DisplayClass11_0.NativeFieldInfoPtr_wormPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter.__c__DisplayClass11_0.NativeFieldInfoPtr_wormPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400325D RID: 12893
			private static readonly IntPtr NativeFieldInfoPtr_wormPlayer;

			// Token: 0x0400325E RID: 12894
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400325F RID: 12895
			private static readonly IntPtr NativeMethodInfoPtr__FactionBonusFTT_b__0_Internal_Boolean_WormFactionTrack_0;
		}

		// Token: 0x020005FE RID: 1534
		[ObfuscatedName("worm.canis.data.Tutorial.FirstTime.TutorialCampaignEmitter+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Object
		{
			// Token: 0x06004CB5 RID: 19637 RVA: 0x0019D080 File Offset: 0x0019B280
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<TutorialCampaignEmitter.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialCampaignEmitter.__c__DisplayClass13_0>.NativeClassPtr);
				TutorialCampaignEmitter.__c__DisplayClass13_0.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter.__c__DisplayClass13_0>.NativeClassPtr, "wormMatch");
				TutorialCampaignEmitter.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter.__c__DisplayClass13_0>.NativeClassPtr, 100665227);
				TutorialCampaignEmitter.__c__DisplayClass13_0.NativeMethodInfoPtr__FirstGeneticFTT_b__0_Internal_Il2CppReferenceArray_1_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter.__c__DisplayClass13_0>.NativeClassPtr, 100665228);
			}

			// Token: 0x06004CB6 RID: 19638 RVA: 0x0019D0E8 File Offset: 0x0019B2E8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialCampaignEmitter.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004CB7 RID: 19639 RVA: 0x0019D124 File Offset: 0x0019B324
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70908, XrefRangeEnd = 70931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppReferenceArray<Entity> _FirstGeneticFTT_b__0(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.__c__DisplayClass13_0.NativeMethodInfoPtr__FirstGeneticFTT_b__0_Internal_Il2CppReferenceArray_1_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x06004CB8 RID: 19640 RVA: 0x0001A4C3 File Offset: 0x000186C3
			public __c__DisplayClass13_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012C0 RID: 4800
			// (get) Token: 0x06004CB9 RID: 19641 RVA: 0x0019D174 File Offset: 0x0019B374
			// (set) Token: 0x06004CBA RID: 19642 RVA: 0x0001A4CC File Offset: 0x000186CC
			public unsafe WormMatch wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter.__c__DisplayClass13_0.NativeFieldInfoPtr_wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter.__c__DisplayClass13_0.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003260 RID: 12896
			private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

			// Token: 0x04003261 RID: 12897
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003262 RID: 12898
			private static readonly IntPtr NativeMethodInfoPtr__FirstGeneticFTT_b__0_Internal_Il2CppReferenceArray_1_Entity_Context_0;
		}

		// Token: 0x020005FF RID: 1535
		[ObfuscatedName("worm.canis.data.Tutorial.FirstTime.TutorialCampaignEmitter+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x06004CBB RID: 19643 RVA: 0x0019D1A4 File Offset: 0x0019B3A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<TutorialCampaignEmitter.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialCampaignEmitter.__c__DisplayClass1_0>.NativeClassPtr);
				TutorialCampaignEmitter.__c__DisplayClass1_0.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter.__c__DisplayClass1_0>.NativeClassPtr, "wormMatch");
				TutorialCampaignEmitter.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter.__c__DisplayClass1_0>.NativeClassPtr, 100665229);
				TutorialCampaignEmitter.__c__DisplayClass1_0.NativeMethodInfoPtr_Method_Internal_Entity_Context_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter.__c__DisplayClass1_0>.NativeClassPtr, 100665230);
			}

			// Token: 0x06004CBC RID: 19644 RVA: 0x0019D20C File Offset: 0x0019B40C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialCampaignEmitter.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004CBD RID: 19645 RVA: 0x0019D248 File Offset: 0x0019B448
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70931, XrefRangeEnd = 70951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity Method_Internal_Entity_Context_PDM_0(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.__c__DisplayClass1_0.NativeMethodInfoPtr_Method_Internal_Entity_Context_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004CBE RID: 19646 RVA: 0x0001A4EB File Offset: 0x000186EB
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012C1 RID: 4801
			// (get) Token: 0x06004CBF RID: 19647 RVA: 0x0019D298 File Offset: 0x0019B498
			// (set) Token: 0x06004CC0 RID: 19648 RVA: 0x0001A4F4 File Offset: 0x000186F4
			public unsafe WormMatch wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter.__c__DisplayClass1_0.NativeFieldInfoPtr_wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter.__c__DisplayClass1_0.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003263 RID: 12899
			private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

			// Token: 0x04003264 RID: 12900
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003265 RID: 12901
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Entity_Context_PDM_0;
		}

		// Token: 0x02000600 RID: 1536
		[ObfuscatedName("worm.canis.data.Tutorial.FirstTime.TutorialCampaignEmitter+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : Object
		{
			// Token: 0x06004CC1 RID: 19649 RVA: 0x0019D2C8 File Offset: 0x0019B4C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<TutorialCampaignEmitter.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialCampaignEmitter.__c__DisplayClass21_0>.NativeClassPtr);
				TutorialCampaignEmitter.__c__DisplayClass21_0.NativeFieldInfoPtr_wormPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter.__c__DisplayClass21_0>.NativeClassPtr, "wormPlayer");
				TutorialCampaignEmitter.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter.__c__DisplayClass21_0>.NativeClassPtr, 100665231);
				TutorialCampaignEmitter.__c__DisplayClass21_0.NativeMethodInfoPtr__GraftFTT_b__0_Internal_Il2CppReferenceArray_1_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter.__c__DisplayClass21_0>.NativeClassPtr, 100665232);
			}

			// Token: 0x06004CC2 RID: 19650 RVA: 0x0019D330 File Offset: 0x0019B530
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialCampaignEmitter.__c__DisplayClass21_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004CC3 RID: 19651 RVA: 0x0019D36C File Offset: 0x0019B56C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70951, XrefRangeEnd = 70973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppReferenceArray<Entity> _GraftFTT_b__0(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.__c__DisplayClass21_0.NativeMethodInfoPtr__GraftFTT_b__0_Internal_Il2CppReferenceArray_1_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x06004CC4 RID: 19652 RVA: 0x0001A513 File Offset: 0x00018713
			public __c__DisplayClass21_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012C2 RID: 4802
			// (get) Token: 0x06004CC5 RID: 19653 RVA: 0x0019D3BC File Offset: 0x0019B5BC
			// (set) Token: 0x06004CC6 RID: 19654 RVA: 0x0001A51C File Offset: 0x0001871C
			public unsafe WormPlayer wormPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter.__c__DisplayClass21_0.NativeFieldInfoPtr_wormPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter.__c__DisplayClass21_0.NativeFieldInfoPtr_wormPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003266 RID: 12902
			private static readonly IntPtr NativeFieldInfoPtr_wormPlayer;

			// Token: 0x04003267 RID: 12903
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003268 RID: 12904
			private static readonly IntPtr NativeMethodInfoPtr__GraftFTT_b__0_Internal_Il2CppReferenceArray_1_Entity_Context_0;
		}

		// Token: 0x02000601 RID: 1537
		[ObfuscatedName("worm.canis.data.Tutorial.FirstTime.TutorialCampaignEmitter+<>c__DisplayClass23_0")]
		public sealed class __c__DisplayClass23_0 : Object
		{
			// Token: 0x06004CC7 RID: 19655 RVA: 0x0019D3EC File Offset: 0x0019B5EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_0()
			{
				Il2CppClassPointerStore<TutorialCampaignEmitter.__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, "<>c__DisplayClass23_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialCampaignEmitter.__c__DisplayClass23_0>.NativeClassPtr);
				TutorialCampaignEmitter.__c__DisplayClass23_0.NativeFieldInfoPtr_wormPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter.__c__DisplayClass23_0>.NativeClassPtr, "wormPlayer");
				TutorialCampaignEmitter.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter.__c__DisplayClass23_0>.NativeClassPtr, 100665233);
				TutorialCampaignEmitter.__c__DisplayClass23_0.NativeMethodInfoPtr__GraftRevealFTT_b__0_Internal_Il2CppReferenceArray_1_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter.__c__DisplayClass23_0>.NativeClassPtr, 100665234);
			}

			// Token: 0x06004CC8 RID: 19656 RVA: 0x0019D454 File Offset: 0x0019B654
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialCampaignEmitter.__c__DisplayClass23_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004CC9 RID: 19657 RVA: 0x0019D490 File Offset: 0x0019B690
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70973, XrefRangeEnd = 70995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppReferenceArray<Entity> _GraftRevealFTT_b__0(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.__c__DisplayClass23_0.NativeMethodInfoPtr__GraftRevealFTT_b__0_Internal_Il2CppReferenceArray_1_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x06004CCA RID: 19658 RVA: 0x0001A53B File Offset: 0x0001873B
			public __c__DisplayClass23_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012C3 RID: 4803
			// (get) Token: 0x06004CCB RID: 19659 RVA: 0x0019D4E0 File Offset: 0x0019B6E0
			// (set) Token: 0x06004CCC RID: 19660 RVA: 0x0001A544 File Offset: 0x00018744
			public unsafe WormPlayer wormPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter.__c__DisplayClass23_0.NativeFieldInfoPtr_wormPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter.__c__DisplayClass23_0.NativeFieldInfoPtr_wormPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003269 RID: 12905
			private static readonly IntPtr NativeFieldInfoPtr_wormPlayer;

			// Token: 0x0400326A RID: 12906
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400326B RID: 12907
			private static readonly IntPtr NativeMethodInfoPtr__GraftRevealFTT_b__0_Internal_Il2CppReferenceArray_1_Entity_Context_0;
		}

		// Token: 0x02000602 RID: 1538
		[ObfuscatedName("worm.canis.data.Tutorial.FirstTime.TutorialCampaignEmitter+<>c__DisplayClass25_0")]
		public sealed class __c__DisplayClass25_0 : Object
		{
			// Token: 0x06004CCD RID: 19661 RVA: 0x0019D510 File Offset: 0x0019B710
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_0()
			{
				Il2CppClassPointerStore<TutorialCampaignEmitter.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, "<>c__DisplayClass25_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialCampaignEmitter.__c__DisplayClass25_0>.NativeClassPtr);
				TutorialCampaignEmitter.__c__DisplayClass25_0.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter.__c__DisplayClass25_0>.NativeClassPtr, "wormMatch");
				TutorialCampaignEmitter.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter.__c__DisplayClass25_0>.NativeClassPtr, 100665235);
				TutorialCampaignEmitter.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_Entity_Context_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter.__c__DisplayClass25_0>.NativeClassPtr, 100665236);
			}

			// Token: 0x06004CCE RID: 19662 RVA: 0x0019D578 File Offset: 0x0019B778
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialCampaignEmitter.__c__DisplayClass25_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004CCF RID: 19663 RVA: 0x0019D5B4 File Offset: 0x0019B7B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70995, XrefRangeEnd = 71000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity Method_Internal_Entity_Context_PDM_0(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_Entity_Context_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004CD0 RID: 19664 RVA: 0x0001A563 File Offset: 0x00018763
			public __c__DisplayClass25_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012C4 RID: 4804
			// (get) Token: 0x06004CD1 RID: 19665 RVA: 0x0019D604 File Offset: 0x0019B804
			// (set) Token: 0x06004CD2 RID: 19666 RVA: 0x0001A56C File Offset: 0x0001876C
			public unsafe WormMatch wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter.__c__DisplayClass25_0.NativeFieldInfoPtr_wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter.__c__DisplayClass25_0.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400326C RID: 12908
			private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

			// Token: 0x0400326D RID: 12909
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400326E RID: 12910
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Entity_Context_PDM_0;
		}

		// Token: 0x02000603 RID: 1539
		[ObfuscatedName("worm.canis.data.Tutorial.FirstTime.TutorialCampaignEmitter+<>c__DisplayClass29_0")]
		public sealed class __c__DisplayClass29_0 : Object
		{
			// Token: 0x06004CD3 RID: 19667 RVA: 0x0019D634 File Offset: 0x0019B834
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_0()
			{
				Il2CppClassPointerStore<TutorialCampaignEmitter.__c__DisplayClass29_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, "<>c__DisplayClass29_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialCampaignEmitter.__c__DisplayClass29_0>.NativeClassPtr);
				TutorialCampaignEmitter.__c__DisplayClass29_0.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter.__c__DisplayClass29_0>.NativeClassPtr, "wormMatch");
				TutorialCampaignEmitter.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter.__c__DisplayClass29_0>.NativeClassPtr, 100665237);
				TutorialCampaignEmitter.__c__DisplayClass29_0.NativeMethodInfoPtr__SecondGeneticFTT_b__0_Internal_Il2CppReferenceArray_1_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter.__c__DisplayClass29_0>.NativeClassPtr, 100665238);
			}

			// Token: 0x06004CD4 RID: 19668 RVA: 0x0019D69C File Offset: 0x0019B89C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialCampaignEmitter.__c__DisplayClass29_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004CD5 RID: 19669 RVA: 0x0019D6D8 File Offset: 0x0019B8D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71000, XrefRangeEnd = 71023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppReferenceArray<Entity> _SecondGeneticFTT_b__0(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter.__c__DisplayClass29_0.NativeMethodInfoPtr__SecondGeneticFTT_b__0_Internal_Il2CppReferenceArray_1_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x06004CD6 RID: 19670 RVA: 0x0001A58B File Offset: 0x0001878B
			public __c__DisplayClass29_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012C5 RID: 4805
			// (get) Token: 0x06004CD7 RID: 19671 RVA: 0x0019D728 File Offset: 0x0019B928
			// (set) Token: 0x06004CD8 RID: 19672 RVA: 0x0001A594 File Offset: 0x00018794
			public unsafe WormMatch wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter.__c__DisplayClass29_0.NativeFieldInfoPtr_wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter.__c__DisplayClass29_0.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400326F RID: 12911
			private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

			// Token: 0x04003270 RID: 12912
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003271 RID: 12913
			private static readonly IntPtr NativeMethodInfoPtr__SecondGeneticFTT_b__0_Internal_Il2CppReferenceArray_1_Entity_Context_0;
		}

		// Token: 0x02000604 RID: 1540
		[ObfuscatedName("worm.canis.data.Tutorial.FirstTime.TutorialCampaignEmitter+<ConditionalIconFTT>d__1")]
		public sealed class _ConditionalIconFTT_d__1 : Object
		{
			// Token: 0x06004CD9 RID: 19673 RVA: 0x0019D758 File Offset: 0x0019B958
			// Note: this type is marked as 'beforefieldinit'.
			static _ConditionalIconFTT_d__1()
			{
				Il2CppClassPointerStore<TutorialCampaignEmitter._ConditionalIconFTT_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, "<ConditionalIconFTT>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialCampaignEmitter._ConditionalIconFTT_d__1>.NativeClassPtr);
				TutorialCampaignEmitter._ConditionalIconFTT_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._ConditionalIconFTT_d__1>.NativeClassPtr, "<>1__state");
				TutorialCampaignEmitter._ConditionalIconFTT_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._ConditionalIconFTT_d__1>.NativeClassPtr, "<>2__current");
				TutorialCampaignEmitter._ConditionalIconFTT_d__1.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._ConditionalIconFTT_d__1>.NativeClassPtr, "<>l__initialThreadId");
				TutorialCampaignEmitter._ConditionalIconFTT_d__1.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._ConditionalIconFTT_d__1>.NativeClassPtr, "wormMatch");
				TutorialCampaignEmitter._ConditionalIconFTT_d__1.NativeFieldInfoPtr___3__wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._ConditionalIconFTT_d__1>.NativeClassPtr, "<>3__wormMatch");
				TutorialCampaignEmitter._ConditionalIconFTT_d__1.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._ConditionalIconFTT_d__1>.NativeClassPtr, "<>8__1");
				TutorialCampaignEmitter._ConditionalIconFTT_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._ConditionalIconFTT_d__1>.NativeClassPtr, 100665239);
				TutorialCampaignEmitter._ConditionalIconFTT_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._ConditionalIconFTT_d__1>.NativeClassPtr, 100665240);
				TutorialCampaignEmitter._ConditionalIconFTT_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._ConditionalIconFTT_d__1>.NativeClassPtr, 100665241);
				TutorialCampaignEmitter._ConditionalIconFTT_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._ConditionalIconFTT_d__1>.NativeClassPtr, 100665242);
				TutorialCampaignEmitter._ConditionalIconFTT_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._ConditionalIconFTT_d__1>.NativeClassPtr, 100665243);
				TutorialCampaignEmitter._ConditionalIconFTT_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._ConditionalIconFTT_d__1>.NativeClassPtr, 100665244);
				TutorialCampaignEmitter._ConditionalIconFTT_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._ConditionalIconFTT_d__1>.NativeClassPtr, 100665245);
				TutorialCampaignEmitter._ConditionalIconFTT_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._ConditionalIconFTT_d__1>.NativeClassPtr, 100665246);
			}

			// Token: 0x06004CDA RID: 19674 RVA: 0x0019D89C File Offset: 0x0019BA9C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ConditionalIconFTT_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialCampaignEmitter._ConditionalIconFTT_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._ConditionalIconFTT_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004CDB RID: 19675 RVA: 0x0019D8E4 File Offset: 0x0019BAE4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._ConditionalIconFTT_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004CDC RID: 19676 RVA: 0x0019D918 File Offset: 0x0019BB18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71023, XrefRangeEnd = 71101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._ConditionalIconFTT_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170012CC RID: 4812
			// (get) Token: 0x06004CDD RID: 19677 RVA: 0x0019D954 File Offset: 0x0019BB54
			public unsafe TutorialAction System.Collections.Generic.IEnumerator<Canis.tutorialScripts.TutorialAction>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._ConditionalIconFTT_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr3) : null;
				}
			}

			// Token: 0x06004CDE RID: 19678 RVA: 0x0019D994 File Offset: 0x0019BB94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71101, XrefRangeEnd = 71106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._ConditionalIconFTT_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170012CD RID: 4813
			// (get) Token: 0x06004CDF RID: 19679 RVA: 0x0019D9C8 File Offset: 0x0019BBC8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._ConditionalIconFTT_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004CE0 RID: 19680 RVA: 0x0019DA08 File Offset: 0x0019BC08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71106, XrefRangeEnd = 71114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TutorialAction> System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._ConditionalIconFTT_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TutorialAction>>(intPtr3) : null;
			}

			// Token: 0x06004CE1 RID: 19681 RVA: 0x0019DA48 File Offset: 0x0019BC48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._ConditionalIconFTT_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06004CE2 RID: 19682 RVA: 0x0001A5B3 File Offset: 0x000187B3
			public _ConditionalIconFTT_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012C6 RID: 4806
			// (get) Token: 0x06004CE3 RID: 19683 RVA: 0x0019DA88 File Offset: 0x0019BC88
			// (set) Token: 0x06004CE4 RID: 19684 RVA: 0x0001A5BC File Offset: 0x000187BC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._ConditionalIconFTT_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._ConditionalIconFTT_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170012C7 RID: 4807
			// (get) Token: 0x06004CE5 RID: 19685 RVA: 0x0019DAB0 File Offset: 0x0019BCB0
			// (set) Token: 0x06004CE6 RID: 19686 RVA: 0x0001A5D7 File Offset: 0x000187D7
			public unsafe TutorialAction __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._ConditionalIconFTT_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._ConditionalIconFTT_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012C8 RID: 4808
			// (get) Token: 0x06004CE7 RID: 19687 RVA: 0x0019DAE0 File Offset: 0x0019BCE0
			// (set) Token: 0x06004CE8 RID: 19688 RVA: 0x0001A5F6 File Offset: 0x000187F6
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._ConditionalIconFTT_d__1.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._ConditionalIconFTT_d__1.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170012C9 RID: 4809
			// (get) Token: 0x06004CE9 RID: 19689 RVA: 0x0019DB08 File Offset: 0x0019BD08
			// (set) Token: 0x06004CEA RID: 19690 RVA: 0x0001A611 File Offset: 0x00018811
			public unsafe WormMatch wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._ConditionalIconFTT_d__1.NativeFieldInfoPtr_wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._ConditionalIconFTT_d__1.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012CA RID: 4810
			// (get) Token: 0x06004CEB RID: 19691 RVA: 0x0019DB38 File Offset: 0x0019BD38
			// (set) Token: 0x06004CEC RID: 19692 RVA: 0x0001A630 File Offset: 0x00018830
			public unsafe WormMatch __3__wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._ConditionalIconFTT_d__1.NativeFieldInfoPtr___3__wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._ConditionalIconFTT_d__1.NativeFieldInfoPtr___3__wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012CB RID: 4811
			// (get) Token: 0x06004CED RID: 19693 RVA: 0x0019DB68 File Offset: 0x0019BD68
			// (set) Token: 0x06004CEE RID: 19694 RVA: 0x0001A64F File Offset: 0x0001884F
			public unsafe TutorialCampaignEmitter.__c__DisplayClass1_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._ConditionalIconFTT_d__1.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialCampaignEmitter.__c__DisplayClass1_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._ConditionalIconFTT_d__1.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003272 RID: 12914
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003273 RID: 12915
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003274 RID: 12916
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003275 RID: 12917
			private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

			// Token: 0x04003276 RID: 12918
			private static readonly IntPtr NativeFieldInfoPtr___3__wormMatch;

			// Token: 0x04003277 RID: 12919
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04003278 RID: 12920
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003279 RID: 12921
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400327A RID: 12922
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400327B RID: 12923
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0;

			// Token: 0x0400327C RID: 12924
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400327D RID: 12925
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400327E RID: 12926
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0;

			// Token: 0x0400327F RID: 12927
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000605 RID: 1541
		[ObfuscatedName("worm.canis.data.Tutorial.FirstTime.TutorialCampaignEmitter+<ControlBonusFTT>d__3")]
		public sealed class _ControlBonusFTT_d__3 : Object
		{
			// Token: 0x06004CEF RID: 19695 RVA: 0x0019DB98 File Offset: 0x0019BD98
			// Note: this type is marked as 'beforefieldinit'.
			static _ControlBonusFTT_d__3()
			{
				Il2CppClassPointerStore<TutorialCampaignEmitter._ControlBonusFTT_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, "<ControlBonusFTT>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialCampaignEmitter._ControlBonusFTT_d__3>.NativeClassPtr);
				TutorialCampaignEmitter._ControlBonusFTT_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._ControlBonusFTT_d__3>.NativeClassPtr, "<>1__state");
				TutorialCampaignEmitter._ControlBonusFTT_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._ControlBonusFTT_d__3>.NativeClassPtr, "<>2__current");
				TutorialCampaignEmitter._ControlBonusFTT_d__3.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._ControlBonusFTT_d__3>.NativeClassPtr, "<>l__initialThreadId");
				TutorialCampaignEmitter._ControlBonusFTT_d__3.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._ControlBonusFTT_d__3>.NativeClassPtr, "wormMatch");
				TutorialCampaignEmitter._ControlBonusFTT_d__3.NativeFieldInfoPtr___3__wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._ControlBonusFTT_d__3>.NativeClassPtr, "<>3__wormMatch");
				TutorialCampaignEmitter._ControlBonusFTT_d__3.NativeFieldInfoPtr__conflictCard_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._ControlBonusFTT_d__3>.NativeClassPtr, "<conflictCard>5__2");
				TutorialCampaignEmitter._ControlBonusFTT_d__3.NativeFieldInfoPtr__space_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._ControlBonusFTT_d__3>.NativeClassPtr, "<space>5__3");
				TutorialCampaignEmitter._ControlBonusFTT_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._ControlBonusFTT_d__3>.NativeClassPtr, 100665247);
				TutorialCampaignEmitter._ControlBonusFTT_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._ControlBonusFTT_d__3>.NativeClassPtr, 100665248);
				TutorialCampaignEmitter._ControlBonusFTT_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._ControlBonusFTT_d__3>.NativeClassPtr, 100665249);
				TutorialCampaignEmitter._ControlBonusFTT_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._ControlBonusFTT_d__3>.NativeClassPtr, 100665250);
				TutorialCampaignEmitter._ControlBonusFTT_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._ControlBonusFTT_d__3>.NativeClassPtr, 100665251);
				TutorialCampaignEmitter._ControlBonusFTT_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._ControlBonusFTT_d__3>.NativeClassPtr, 100665252);
				TutorialCampaignEmitter._ControlBonusFTT_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._ControlBonusFTT_d__3>.NativeClassPtr, 100665253);
				TutorialCampaignEmitter._ControlBonusFTT_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._ControlBonusFTT_d__3>.NativeClassPtr, 100665254);
			}

			// Token: 0x06004CF0 RID: 19696 RVA: 0x0019DCF0 File Offset: 0x0019BEF0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ControlBonusFTT_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialCampaignEmitter._ControlBonusFTT_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._ControlBonusFTT_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004CF1 RID: 19697 RVA: 0x0019DD38 File Offset: 0x0019BF38
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._ControlBonusFTT_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004CF2 RID: 19698 RVA: 0x0019DD6C File Offset: 0x0019BF6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71114, XrefRangeEnd = 71175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._ControlBonusFTT_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170012D5 RID: 4821
			// (get) Token: 0x06004CF3 RID: 19699 RVA: 0x0019DDA8 File Offset: 0x0019BFA8
			public unsafe TutorialAction System.Collections.Generic.IEnumerator<Canis.tutorialScripts.TutorialAction>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._ControlBonusFTT_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr3) : null;
				}
			}

			// Token: 0x06004CF4 RID: 19700 RVA: 0x0019DDE8 File Offset: 0x0019BFE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71175, XrefRangeEnd = 71180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._ControlBonusFTT_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170012D6 RID: 4822
			// (get) Token: 0x06004CF5 RID: 19701 RVA: 0x0019DE1C File Offset: 0x0019C01C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._ControlBonusFTT_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004CF6 RID: 19702 RVA: 0x0019DE5C File Offset: 0x0019C05C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71180, XrefRangeEnd = 71188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TutorialAction> System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._ControlBonusFTT_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TutorialAction>>(intPtr3) : null;
			}

			// Token: 0x06004CF7 RID: 19703 RVA: 0x0019DE9C File Offset: 0x0019C09C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._ControlBonusFTT_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06004CF8 RID: 19704 RVA: 0x0001A66E File Offset: 0x0001886E
			public _ControlBonusFTT_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012CE RID: 4814
			// (get) Token: 0x06004CF9 RID: 19705 RVA: 0x0019DEDC File Offset: 0x0019C0DC
			// (set) Token: 0x06004CFA RID: 19706 RVA: 0x0001A677 File Offset: 0x00018877
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._ControlBonusFTT_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._ControlBonusFTT_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170012CF RID: 4815
			// (get) Token: 0x06004CFB RID: 19707 RVA: 0x0019DF04 File Offset: 0x0019C104
			// (set) Token: 0x06004CFC RID: 19708 RVA: 0x0001A692 File Offset: 0x00018892
			public unsafe TutorialAction __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._ControlBonusFTT_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._ControlBonusFTT_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012D0 RID: 4816
			// (get) Token: 0x06004CFD RID: 19709 RVA: 0x0019DF34 File Offset: 0x0019C134
			// (set) Token: 0x06004CFE RID: 19710 RVA: 0x0001A6B1 File Offset: 0x000188B1
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._ControlBonusFTT_d__3.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._ControlBonusFTT_d__3.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170012D1 RID: 4817
			// (get) Token: 0x06004CFF RID: 19711 RVA: 0x0019DF5C File Offset: 0x0019C15C
			// (set) Token: 0x06004D00 RID: 19712 RVA: 0x0001A6CC File Offset: 0x000188CC
			public unsafe WormMatch wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._ControlBonusFTT_d__3.NativeFieldInfoPtr_wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._ControlBonusFTT_d__3.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012D2 RID: 4818
			// (get) Token: 0x06004D01 RID: 19713 RVA: 0x0019DF8C File Offset: 0x0019C18C
			// (set) Token: 0x06004D02 RID: 19714 RVA: 0x0001A6EB File Offset: 0x000188EB
			public unsafe WormMatch __3__wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._ControlBonusFTT_d__3.NativeFieldInfoPtr___3__wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._ControlBonusFTT_d__3.NativeFieldInfoPtr___3__wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012D3 RID: 4819
			// (get) Token: 0x06004D03 RID: 19715 RVA: 0x0019DFBC File Offset: 0x0019C1BC
			// (set) Token: 0x06004D04 RID: 19716 RVA: 0x0001A70A File Offset: 0x0001890A
			public unsafe WormConflictPlayable _conflictCard_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._ControlBonusFTT_d__3.NativeFieldInfoPtr__conflictCard_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormConflictPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._ControlBonusFTT_d__3.NativeFieldInfoPtr__conflictCard_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012D4 RID: 4820
			// (get) Token: 0x06004D05 RID: 19717 RVA: 0x0019DFEC File Offset: 0x0019C1EC
			// (set) Token: 0x06004D06 RID: 19718 RVA: 0x0001A729 File Offset: 0x00018929
			public unsafe WormSpace _space_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._ControlBonusFTT_d__3.NativeFieldInfoPtr__space_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSpace>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._ControlBonusFTT_d__3.NativeFieldInfoPtr__space_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003280 RID: 12928
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003281 RID: 12929
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003282 RID: 12930
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003283 RID: 12931
			private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

			// Token: 0x04003284 RID: 12932
			private static readonly IntPtr NativeFieldInfoPtr___3__wormMatch;

			// Token: 0x04003285 RID: 12933
			private static readonly IntPtr NativeFieldInfoPtr__conflictCard_5__2;

			// Token: 0x04003286 RID: 12934
			private static readonly IntPtr NativeFieldInfoPtr__space_5__3;

			// Token: 0x04003287 RID: 12935
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003288 RID: 12936
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003289 RID: 12937
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400328A RID: 12938
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0;

			// Token: 0x0400328B RID: 12939
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400328C RID: 12940
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400328D RID: 12941
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0;

			// Token: 0x0400328E RID: 12942
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000606 RID: 1542
		[ObfuscatedName("worm.canis.data.Tutorial.FirstTime.TutorialCampaignEmitter+<DiscardFTT>d__5")]
		public sealed class _DiscardFTT_d__5 : Object
		{
			// Token: 0x06004D07 RID: 19719 RVA: 0x0019E01C File Offset: 0x0019C21C
			// Note: this type is marked as 'beforefieldinit'.
			static _DiscardFTT_d__5()
			{
				Il2CppClassPointerStore<TutorialCampaignEmitter._DiscardFTT_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, "<DiscardFTT>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialCampaignEmitter._DiscardFTT_d__5>.NativeClassPtr);
				TutorialCampaignEmitter._DiscardFTT_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._DiscardFTT_d__5>.NativeClassPtr, "<>1__state");
				TutorialCampaignEmitter._DiscardFTT_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._DiscardFTT_d__5>.NativeClassPtr, "<>2__current");
				TutorialCampaignEmitter._DiscardFTT_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._DiscardFTT_d__5>.NativeClassPtr, "<>l__initialThreadId");
				TutorialCampaignEmitter._DiscardFTT_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._DiscardFTT_d__5>.NativeClassPtr, 100665255);
				TutorialCampaignEmitter._DiscardFTT_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._DiscardFTT_d__5>.NativeClassPtr, 100665256);
				TutorialCampaignEmitter._DiscardFTT_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._DiscardFTT_d__5>.NativeClassPtr, 100665257);
				TutorialCampaignEmitter._DiscardFTT_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._DiscardFTT_d__5>.NativeClassPtr, 100665258);
				TutorialCampaignEmitter._DiscardFTT_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._DiscardFTT_d__5>.NativeClassPtr, 100665259);
				TutorialCampaignEmitter._DiscardFTT_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._DiscardFTT_d__5>.NativeClassPtr, 100665260);
				TutorialCampaignEmitter._DiscardFTT_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._DiscardFTT_d__5>.NativeClassPtr, 100665261);
				TutorialCampaignEmitter._DiscardFTT_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._DiscardFTT_d__5>.NativeClassPtr, 100665262);
			}

			// Token: 0x06004D08 RID: 19720 RVA: 0x0019E124 File Offset: 0x0019C324
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DiscardFTT_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialCampaignEmitter._DiscardFTT_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._DiscardFTT_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004D09 RID: 19721 RVA: 0x0019E16C File Offset: 0x0019C36C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._DiscardFTT_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D0A RID: 19722 RVA: 0x0019E1A0 File Offset: 0x0019C3A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71188, XrefRangeEnd = 71198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._DiscardFTT_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170012DA RID: 4826
			// (get) Token: 0x06004D0B RID: 19723 RVA: 0x0019E1DC File Offset: 0x0019C3DC
			public unsafe TutorialAction System.Collections.Generic.IEnumerator<Canis.tutorialScripts.TutorialAction>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._DiscardFTT_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr3) : null;
				}
			}

			// Token: 0x06004D0C RID: 19724 RVA: 0x0019E21C File Offset: 0x0019C41C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71198, XrefRangeEnd = 71203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._DiscardFTT_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170012DB RID: 4827
			// (get) Token: 0x06004D0D RID: 19725 RVA: 0x0019E250 File Offset: 0x0019C450
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._DiscardFTT_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004D0E RID: 19726 RVA: 0x0019E290 File Offset: 0x0019C490
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71203, XrefRangeEnd = 71205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TutorialAction> System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._DiscardFTT_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TutorialAction>>(intPtr3) : null;
			}

			// Token: 0x06004D0F RID: 19727 RVA: 0x0019E2D0 File Offset: 0x0019C4D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._DiscardFTT_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06004D10 RID: 19728 RVA: 0x0001A748 File Offset: 0x00018948
			public _DiscardFTT_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012D7 RID: 4823
			// (get) Token: 0x06004D11 RID: 19729 RVA: 0x0019E310 File Offset: 0x0019C510
			// (set) Token: 0x06004D12 RID: 19730 RVA: 0x0001A751 File Offset: 0x00018951
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._DiscardFTT_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._DiscardFTT_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170012D8 RID: 4824
			// (get) Token: 0x06004D13 RID: 19731 RVA: 0x0019E338 File Offset: 0x0019C538
			// (set) Token: 0x06004D14 RID: 19732 RVA: 0x0001A76C File Offset: 0x0001896C
			public unsafe TutorialAction __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._DiscardFTT_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._DiscardFTT_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012D9 RID: 4825
			// (get) Token: 0x06004D15 RID: 19733 RVA: 0x0019E368 File Offset: 0x0019C568
			// (set) Token: 0x06004D16 RID: 19734 RVA: 0x0001A78B File Offset: 0x0001898B
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._DiscardFTT_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._DiscardFTT_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x0400328F RID: 12943
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003290 RID: 12944
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003291 RID: 12945
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003292 RID: 12946
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003293 RID: 12947
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003294 RID: 12948
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003295 RID: 12949
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0;

			// Token: 0x04003296 RID: 12950
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003297 RID: 12951
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003298 RID: 12952
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0;

			// Token: 0x04003299 RID: 12953
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000607 RID: 1543
		[ObfuscatedName("worm.canis.data.Tutorial.FirstTime.TutorialCampaignEmitter+<EndgameFTT>d__7")]
		public sealed class _EndgameFTT_d__7 : Object
		{
			// Token: 0x06004D17 RID: 19735 RVA: 0x0019E390 File Offset: 0x0019C590
			// Note: this type is marked as 'beforefieldinit'.
			static _EndgameFTT_d__7()
			{
				Il2CppClassPointerStore<TutorialCampaignEmitter._EndgameFTT_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, "<EndgameFTT>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialCampaignEmitter._EndgameFTT_d__7>.NativeClassPtr);
				TutorialCampaignEmitter._EndgameFTT_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._EndgameFTT_d__7>.NativeClassPtr, "<>1__state");
				TutorialCampaignEmitter._EndgameFTT_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._EndgameFTT_d__7>.NativeClassPtr, "<>2__current");
				TutorialCampaignEmitter._EndgameFTT_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._EndgameFTT_d__7>.NativeClassPtr, "<>l__initialThreadId");
				TutorialCampaignEmitter._EndgameFTT_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._EndgameFTT_d__7>.NativeClassPtr, 100665263);
				TutorialCampaignEmitter._EndgameFTT_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._EndgameFTT_d__7>.NativeClassPtr, 100665264);
				TutorialCampaignEmitter._EndgameFTT_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._EndgameFTT_d__7>.NativeClassPtr, 100665265);
				TutorialCampaignEmitter._EndgameFTT_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._EndgameFTT_d__7>.NativeClassPtr, 100665266);
				TutorialCampaignEmitter._EndgameFTT_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._EndgameFTT_d__7>.NativeClassPtr, 100665267);
				TutorialCampaignEmitter._EndgameFTT_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._EndgameFTT_d__7>.NativeClassPtr, 100665268);
				TutorialCampaignEmitter._EndgameFTT_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._EndgameFTT_d__7>.NativeClassPtr, 100665269);
				TutorialCampaignEmitter._EndgameFTT_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._EndgameFTT_d__7>.NativeClassPtr, 100665270);
			}

			// Token: 0x06004D18 RID: 19736 RVA: 0x0019E498 File Offset: 0x0019C698
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _EndgameFTT_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialCampaignEmitter._EndgameFTT_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._EndgameFTT_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004D19 RID: 19737 RVA: 0x0019E4E0 File Offset: 0x0019C6E0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._EndgameFTT_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D1A RID: 19738 RVA: 0x0019E514 File Offset: 0x0019C714
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71205, XrefRangeEnd = 71210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._EndgameFTT_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170012DF RID: 4831
			// (get) Token: 0x06004D1B RID: 19739 RVA: 0x0019E550 File Offset: 0x0019C750
			public unsafe TutorialAction System.Collections.Generic.IEnumerator<Canis.tutorialScripts.TutorialAction>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._EndgameFTT_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr3) : null;
				}
			}

			// Token: 0x06004D1C RID: 19740 RVA: 0x0019E590 File Offset: 0x0019C790
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71210, XrefRangeEnd = 71215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._EndgameFTT_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170012E0 RID: 4832
			// (get) Token: 0x06004D1D RID: 19741 RVA: 0x0019E5C4 File Offset: 0x0019C7C4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._EndgameFTT_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004D1E RID: 19742 RVA: 0x0019E604 File Offset: 0x0019C804
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71215, XrefRangeEnd = 71217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TutorialAction> System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._EndgameFTT_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TutorialAction>>(intPtr3) : null;
			}

			// Token: 0x06004D1F RID: 19743 RVA: 0x0019E644 File Offset: 0x0019C844
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._EndgameFTT_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06004D20 RID: 19744 RVA: 0x0001A7A6 File Offset: 0x000189A6
			public _EndgameFTT_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012DC RID: 4828
			// (get) Token: 0x06004D21 RID: 19745 RVA: 0x0019E684 File Offset: 0x0019C884
			// (set) Token: 0x06004D22 RID: 19746 RVA: 0x0001A7AF File Offset: 0x000189AF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._EndgameFTT_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._EndgameFTT_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170012DD RID: 4829
			// (get) Token: 0x06004D23 RID: 19747 RVA: 0x0019E6AC File Offset: 0x0019C8AC
			// (set) Token: 0x06004D24 RID: 19748 RVA: 0x0001A7CA File Offset: 0x000189CA
			public unsafe TutorialAction __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._EndgameFTT_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._EndgameFTT_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012DE RID: 4830
			// (get) Token: 0x06004D25 RID: 19749 RVA: 0x0019E6DC File Offset: 0x0019C8DC
			// (set) Token: 0x06004D26 RID: 19750 RVA: 0x0001A7E9 File Offset: 0x000189E9
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._EndgameFTT_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._EndgameFTT_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x0400329A RID: 12954
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400329B RID: 12955
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400329C RID: 12956
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400329D RID: 12957
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400329E RID: 12958
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400329F RID: 12959
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040032A0 RID: 12960
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0;

			// Token: 0x040032A1 RID: 12961
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040032A2 RID: 12962
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040032A3 RID: 12963
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0;

			// Token: 0x040032A4 RID: 12964
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000608 RID: 1544
		[ObfuscatedName("worm.canis.data.Tutorial.FirstTime.TutorialCampaignEmitter+<EndgameIntrigueFTT>d__9")]
		public sealed class _EndgameIntrigueFTT_d__9 : Object
		{
			// Token: 0x06004D27 RID: 19751 RVA: 0x0019E704 File Offset: 0x0019C904
			// Note: this type is marked as 'beforefieldinit'.
			static _EndgameIntrigueFTT_d__9()
			{
				Il2CppClassPointerStore<TutorialCampaignEmitter._EndgameIntrigueFTT_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, "<EndgameIntrigueFTT>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialCampaignEmitter._EndgameIntrigueFTT_d__9>.NativeClassPtr);
				TutorialCampaignEmitter._EndgameIntrigueFTT_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._EndgameIntrigueFTT_d__9>.NativeClassPtr, "<>1__state");
				TutorialCampaignEmitter._EndgameIntrigueFTT_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._EndgameIntrigueFTT_d__9>.NativeClassPtr, "<>2__current");
				TutorialCampaignEmitter._EndgameIntrigueFTT_d__9.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._EndgameIntrigueFTT_d__9>.NativeClassPtr, "<>l__initialThreadId");
				TutorialCampaignEmitter._EndgameIntrigueFTT_d__9.NativeFieldInfoPtr_entityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._EndgameIntrigueFTT_d__9>.NativeClassPtr, "entityID");
				TutorialCampaignEmitter._EndgameIntrigueFTT_d__9.NativeFieldInfoPtr___3__entityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._EndgameIntrigueFTT_d__9>.NativeClassPtr, "<>3__entityID");
				TutorialCampaignEmitter._EndgameIntrigueFTT_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._EndgameIntrigueFTT_d__9>.NativeClassPtr, 100665271);
				TutorialCampaignEmitter._EndgameIntrigueFTT_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._EndgameIntrigueFTT_d__9>.NativeClassPtr, 100665272);
				TutorialCampaignEmitter._EndgameIntrigueFTT_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._EndgameIntrigueFTT_d__9>.NativeClassPtr, 100665273);
				TutorialCampaignEmitter._EndgameIntrigueFTT_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._EndgameIntrigueFTT_d__9>.NativeClassPtr, 100665274);
				TutorialCampaignEmitter._EndgameIntrigueFTT_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._EndgameIntrigueFTT_d__9>.NativeClassPtr, 100665275);
				TutorialCampaignEmitter._EndgameIntrigueFTT_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._EndgameIntrigueFTT_d__9>.NativeClassPtr, 100665276);
				TutorialCampaignEmitter._EndgameIntrigueFTT_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._EndgameIntrigueFTT_d__9>.NativeClassPtr, 100665277);
				TutorialCampaignEmitter._EndgameIntrigueFTT_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._EndgameIntrigueFTT_d__9>.NativeClassPtr, 100665278);
			}

			// Token: 0x06004D28 RID: 19752 RVA: 0x0019E834 File Offset: 0x0019CA34
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _EndgameIntrigueFTT_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialCampaignEmitter._EndgameIntrigueFTT_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._EndgameIntrigueFTT_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004D29 RID: 19753 RVA: 0x0019E87C File Offset: 0x0019CA7C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._EndgameIntrigueFTT_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D2A RID: 19754 RVA: 0x0019E8B0 File Offset: 0x0019CAB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71217, XrefRangeEnd = 71224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._EndgameIntrigueFTT_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170012E6 RID: 4838
			// (get) Token: 0x06004D2B RID: 19755 RVA: 0x0019E8EC File Offset: 0x0019CAEC
			public unsafe TutorialAction System.Collections.Generic.IEnumerator<Canis.tutorialScripts.TutorialAction>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._EndgameIntrigueFTT_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr3) : null;
				}
			}

			// Token: 0x06004D2C RID: 19756 RVA: 0x0019E92C File Offset: 0x0019CB2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71224, XrefRangeEnd = 71229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._EndgameIntrigueFTT_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170012E7 RID: 4839
			// (get) Token: 0x06004D2D RID: 19757 RVA: 0x0019E960 File Offset: 0x0019CB60
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._EndgameIntrigueFTT_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004D2E RID: 19758 RVA: 0x0019E9A0 File Offset: 0x0019CBA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71229, XrefRangeEnd = 71237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TutorialAction> System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._EndgameIntrigueFTT_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TutorialAction>>(intPtr3) : null;
			}

			// Token: 0x06004D2F RID: 19759 RVA: 0x0019E9E0 File Offset: 0x0019CBE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._EndgameIntrigueFTT_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06004D30 RID: 19760 RVA: 0x0001A804 File Offset: 0x00018A04
			public _EndgameIntrigueFTT_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012E1 RID: 4833
			// (get) Token: 0x06004D31 RID: 19761 RVA: 0x0019EA20 File Offset: 0x0019CC20
			// (set) Token: 0x06004D32 RID: 19762 RVA: 0x0001A80D File Offset: 0x00018A0D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._EndgameIntrigueFTT_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._EndgameIntrigueFTT_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170012E2 RID: 4834
			// (get) Token: 0x06004D33 RID: 19763 RVA: 0x0019EA48 File Offset: 0x0019CC48
			// (set) Token: 0x06004D34 RID: 19764 RVA: 0x0001A828 File Offset: 0x00018A28
			public unsafe TutorialAction __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._EndgameIntrigueFTT_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._EndgameIntrigueFTT_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012E3 RID: 4835
			// (get) Token: 0x06004D35 RID: 19765 RVA: 0x0019EA78 File Offset: 0x0019CC78
			// (set) Token: 0x06004D36 RID: 19766 RVA: 0x0001A847 File Offset: 0x00018A47
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._EndgameIntrigueFTT_d__9.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._EndgameIntrigueFTT_d__9.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170012E4 RID: 4836
			// (get) Token: 0x06004D37 RID: 19767 RVA: 0x0019EAA0 File Offset: 0x0019CCA0
			// (set) Token: 0x06004D38 RID: 19768 RVA: 0x0001A862 File Offset: 0x00018A62
			public unsafe EntityID entityID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._EndgameIntrigueFTT_d__9.NativeFieldInfoPtr_entityID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._EndgameIntrigueFTT_d__9.NativeFieldInfoPtr_entityID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012E5 RID: 4837
			// (get) Token: 0x06004D39 RID: 19769 RVA: 0x0019EAD0 File Offset: 0x0019CCD0
			// (set) Token: 0x06004D3A RID: 19770 RVA: 0x0001A881 File Offset: 0x00018A81
			public unsafe EntityID __3__entityID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._EndgameIntrigueFTT_d__9.NativeFieldInfoPtr___3__entityID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._EndgameIntrigueFTT_d__9.NativeFieldInfoPtr___3__entityID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040032A5 RID: 12965
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040032A6 RID: 12966
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040032A7 RID: 12967
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040032A8 RID: 12968
			private static readonly IntPtr NativeFieldInfoPtr_entityID;

			// Token: 0x040032A9 RID: 12969
			private static readonly IntPtr NativeFieldInfoPtr___3__entityID;

			// Token: 0x040032AA RID: 12970
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040032AB RID: 12971
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040032AC RID: 12972
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040032AD RID: 12973
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0;

			// Token: 0x040032AE RID: 12974
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040032AF RID: 12975
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040032B0 RID: 12976
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0;

			// Token: 0x040032B1 RID: 12977
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000609 RID: 1545
		[ObfuscatedName("worm.canis.data.Tutorial.FirstTime.TutorialCampaignEmitter+<FactionBonusFTT>d__11")]
		public sealed class _FactionBonusFTT_d__11 : Object
		{
			// Token: 0x06004D3B RID: 19771 RVA: 0x0019EB00 File Offset: 0x0019CD00
			// Note: this type is marked as 'beforefieldinit'.
			static _FactionBonusFTT_d__11()
			{
				Il2CppClassPointerStore<TutorialCampaignEmitter._FactionBonusFTT_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, "<FactionBonusFTT>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialCampaignEmitter._FactionBonusFTT_d__11>.NativeClassPtr);
				TutorialCampaignEmitter._FactionBonusFTT_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._FactionBonusFTT_d__11>.NativeClassPtr, "<>1__state");
				TutorialCampaignEmitter._FactionBonusFTT_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._FactionBonusFTT_d__11>.NativeClassPtr, "<>2__current");
				TutorialCampaignEmitter._FactionBonusFTT_d__11.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._FactionBonusFTT_d__11>.NativeClassPtr, "<>l__initialThreadId");
				TutorialCampaignEmitter._FactionBonusFTT_d__11.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._FactionBonusFTT_d__11>.NativeClassPtr, "player");
				TutorialCampaignEmitter._FactionBonusFTT_d__11.NativeFieldInfoPtr___3__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._FactionBonusFTT_d__11>.NativeClassPtr, "<>3__player");
				TutorialCampaignEmitter._FactionBonusFTT_d__11.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._FactionBonusFTT_d__11>.NativeClassPtr, "wormMatch");
				TutorialCampaignEmitter._FactionBonusFTT_d__11.NativeFieldInfoPtr___3__wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._FactionBonusFTT_d__11>.NativeClassPtr, "<>3__wormMatch");
				TutorialCampaignEmitter._FactionBonusFTT_d__11.NativeFieldInfoPtr__space_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._FactionBonusFTT_d__11>.NativeClassPtr, "<space>5__2");
				TutorialCampaignEmitter._FactionBonusFTT_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._FactionBonusFTT_d__11>.NativeClassPtr, 100665279);
				TutorialCampaignEmitter._FactionBonusFTT_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._FactionBonusFTT_d__11>.NativeClassPtr, 100665280);
				TutorialCampaignEmitter._FactionBonusFTT_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._FactionBonusFTT_d__11>.NativeClassPtr, 100665281);
				TutorialCampaignEmitter._FactionBonusFTT_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._FactionBonusFTT_d__11>.NativeClassPtr, 100665282);
				TutorialCampaignEmitter._FactionBonusFTT_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._FactionBonusFTT_d__11>.NativeClassPtr, 100665283);
				TutorialCampaignEmitter._FactionBonusFTT_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._FactionBonusFTT_d__11>.NativeClassPtr, 100665284);
				TutorialCampaignEmitter._FactionBonusFTT_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._FactionBonusFTT_d__11>.NativeClassPtr, 100665285);
				TutorialCampaignEmitter._FactionBonusFTT_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._FactionBonusFTT_d__11>.NativeClassPtr, 100665286);
			}

			// Token: 0x06004D3C RID: 19772 RVA: 0x0019EC6C File Offset: 0x0019CE6C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _FactionBonusFTT_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialCampaignEmitter._FactionBonusFTT_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._FactionBonusFTT_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004D3D RID: 19773 RVA: 0x0019ECB4 File Offset: 0x0019CEB4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._FactionBonusFTT_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D3E RID: 19774 RVA: 0x0019ECE8 File Offset: 0x0019CEE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71237, XrefRangeEnd = 71305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._FactionBonusFTT_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170012F0 RID: 4848
			// (get) Token: 0x06004D3F RID: 19775 RVA: 0x0019ED24 File Offset: 0x0019CF24
			public unsafe TutorialAction System.Collections.Generic.IEnumerator<Canis.tutorialScripts.TutorialAction>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._FactionBonusFTT_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr3) : null;
				}
			}

			// Token: 0x06004D40 RID: 19776 RVA: 0x0019ED64 File Offset: 0x0019CF64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71305, XrefRangeEnd = 71310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._FactionBonusFTT_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170012F1 RID: 4849
			// (get) Token: 0x06004D41 RID: 19777 RVA: 0x0019ED98 File Offset: 0x0019CF98
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._FactionBonusFTT_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004D42 RID: 19778 RVA: 0x0019EDD8 File Offset: 0x0019CFD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71310, XrefRangeEnd = 71319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TutorialAction> System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._FactionBonusFTT_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TutorialAction>>(intPtr3) : null;
			}

			// Token: 0x06004D43 RID: 19779 RVA: 0x0019EE18 File Offset: 0x0019D018
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._FactionBonusFTT_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06004D44 RID: 19780 RVA: 0x0001A8A0 File Offset: 0x00018AA0
			public _FactionBonusFTT_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012E8 RID: 4840
			// (get) Token: 0x06004D45 RID: 19781 RVA: 0x0019EE58 File Offset: 0x0019D058
			// (set) Token: 0x06004D46 RID: 19782 RVA: 0x0001A8A9 File Offset: 0x00018AA9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FactionBonusFTT_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FactionBonusFTT_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170012E9 RID: 4841
			// (get) Token: 0x06004D47 RID: 19783 RVA: 0x0019EE80 File Offset: 0x0019D080
			// (set) Token: 0x06004D48 RID: 19784 RVA: 0x0001A8C4 File Offset: 0x00018AC4
			public unsafe TutorialAction __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FactionBonusFTT_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FactionBonusFTT_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012EA RID: 4842
			// (get) Token: 0x06004D49 RID: 19785 RVA: 0x0019EEB0 File Offset: 0x0019D0B0
			// (set) Token: 0x06004D4A RID: 19786 RVA: 0x0001A8E3 File Offset: 0x00018AE3
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FactionBonusFTT_d__11.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FactionBonusFTT_d__11.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170012EB RID: 4843
			// (get) Token: 0x06004D4B RID: 19787 RVA: 0x0019EED8 File Offset: 0x0019D0D8
			// (set) Token: 0x06004D4C RID: 19788 RVA: 0x0001A8FE File Offset: 0x00018AFE
			public unsafe PlayerEntity player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FactionBonusFTT_d__11.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FactionBonusFTT_d__11.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012EC RID: 4844
			// (get) Token: 0x06004D4D RID: 19789 RVA: 0x0019EF08 File Offset: 0x0019D108
			// (set) Token: 0x06004D4E RID: 19790 RVA: 0x0001A91D File Offset: 0x00018B1D
			public unsafe PlayerEntity __3__player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FactionBonusFTT_d__11.NativeFieldInfoPtr___3__player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FactionBonusFTT_d__11.NativeFieldInfoPtr___3__player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012ED RID: 4845
			// (get) Token: 0x06004D4F RID: 19791 RVA: 0x0019EF38 File Offset: 0x0019D138
			// (set) Token: 0x06004D50 RID: 19792 RVA: 0x0001A93C File Offset: 0x00018B3C
			public unsafe WormMatch wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FactionBonusFTT_d__11.NativeFieldInfoPtr_wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FactionBonusFTT_d__11.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012EE RID: 4846
			// (get) Token: 0x06004D51 RID: 19793 RVA: 0x0019EF68 File Offset: 0x0019D168
			// (set) Token: 0x06004D52 RID: 19794 RVA: 0x0001A95B File Offset: 0x00018B5B
			public unsafe WormMatch __3__wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FactionBonusFTT_d__11.NativeFieldInfoPtr___3__wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FactionBonusFTT_d__11.NativeFieldInfoPtr___3__wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012EF RID: 4847
			// (get) Token: 0x06004D53 RID: 19795 RVA: 0x0019EF98 File Offset: 0x0019D198
			// (set) Token: 0x06004D54 RID: 19796 RVA: 0x0001A97A File Offset: 0x00018B7A
			public unsafe WormSpace _space_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FactionBonusFTT_d__11.NativeFieldInfoPtr__space_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSpace>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FactionBonusFTT_d__11.NativeFieldInfoPtr__space_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040032B2 RID: 12978
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040032B3 RID: 12979
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040032B4 RID: 12980
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040032B5 RID: 12981
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x040032B6 RID: 12982
			private static readonly IntPtr NativeFieldInfoPtr___3__player;

			// Token: 0x040032B7 RID: 12983
			private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

			// Token: 0x040032B8 RID: 12984
			private static readonly IntPtr NativeFieldInfoPtr___3__wormMatch;

			// Token: 0x040032B9 RID: 12985
			private static readonly IntPtr NativeFieldInfoPtr__space_5__2;

			// Token: 0x040032BA RID: 12986
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040032BB RID: 12987
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040032BC RID: 12988
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040032BD RID: 12989
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0;

			// Token: 0x040032BE RID: 12990
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040032BF RID: 12991
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040032C0 RID: 12992
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0;

			// Token: 0x040032C1 RID: 12993
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200060A RID: 1546
		[ObfuscatedName("worm.canis.data.Tutorial.FirstTime.TutorialCampaignEmitter+<FirstGeneticFTT>d__13")]
		public sealed class _FirstGeneticFTT_d__13 : Object
		{
			// Token: 0x06004D55 RID: 19797 RVA: 0x0019EFC8 File Offset: 0x0019D1C8
			// Note: this type is marked as 'beforefieldinit'.
			static _FirstGeneticFTT_d__13()
			{
				Il2CppClassPointerStore<TutorialCampaignEmitter._FirstGeneticFTT_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, "<FirstGeneticFTT>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialCampaignEmitter._FirstGeneticFTT_d__13>.NativeClassPtr);
				TutorialCampaignEmitter._FirstGeneticFTT_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._FirstGeneticFTT_d__13>.NativeClassPtr, "<>1__state");
				TutorialCampaignEmitter._FirstGeneticFTT_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._FirstGeneticFTT_d__13>.NativeClassPtr, "<>2__current");
				TutorialCampaignEmitter._FirstGeneticFTT_d__13.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._FirstGeneticFTT_d__13>.NativeClassPtr, "<>l__initialThreadId");
				TutorialCampaignEmitter._FirstGeneticFTT_d__13.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._FirstGeneticFTT_d__13>.NativeClassPtr, "wormMatch");
				TutorialCampaignEmitter._FirstGeneticFTT_d__13.NativeFieldInfoPtr___3__wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._FirstGeneticFTT_d__13>.NativeClassPtr, "<>3__wormMatch");
				TutorialCampaignEmitter._FirstGeneticFTT_d__13.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._FirstGeneticFTT_d__13>.NativeClassPtr, "<>8__1");
				TutorialCampaignEmitter._FirstGeneticFTT_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._FirstGeneticFTT_d__13>.NativeClassPtr, 100665287);
				TutorialCampaignEmitter._FirstGeneticFTT_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._FirstGeneticFTT_d__13>.NativeClassPtr, 100665288);
				TutorialCampaignEmitter._FirstGeneticFTT_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._FirstGeneticFTT_d__13>.NativeClassPtr, 100665289);
				TutorialCampaignEmitter._FirstGeneticFTT_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._FirstGeneticFTT_d__13>.NativeClassPtr, 100665290);
				TutorialCampaignEmitter._FirstGeneticFTT_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._FirstGeneticFTT_d__13>.NativeClassPtr, 100665291);
				TutorialCampaignEmitter._FirstGeneticFTT_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._FirstGeneticFTT_d__13>.NativeClassPtr, 100665292);
				TutorialCampaignEmitter._FirstGeneticFTT_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._FirstGeneticFTT_d__13>.NativeClassPtr, 100665293);
				TutorialCampaignEmitter._FirstGeneticFTT_d__13.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._FirstGeneticFTT_d__13>.NativeClassPtr, 100665294);
			}

			// Token: 0x06004D56 RID: 19798 RVA: 0x0019F10C File Offset: 0x0019D30C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _FirstGeneticFTT_d__13(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialCampaignEmitter._FirstGeneticFTT_d__13>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._FirstGeneticFTT_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004D57 RID: 19799 RVA: 0x0019F154 File Offset: 0x0019D354
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._FirstGeneticFTT_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D58 RID: 19800 RVA: 0x0019F188 File Offset: 0x0019D388
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71319, XrefRangeEnd = 71371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._FirstGeneticFTT_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170012F8 RID: 4856
			// (get) Token: 0x06004D59 RID: 19801 RVA: 0x0019F1C4 File Offset: 0x0019D3C4
			public unsafe TutorialAction System.Collections.Generic.IEnumerator<Canis.tutorialScripts.TutorialAction>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._FirstGeneticFTT_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr3) : null;
				}
			}

			// Token: 0x06004D5A RID: 19802 RVA: 0x0019F204 File Offset: 0x0019D404
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71371, XrefRangeEnd = 71376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._FirstGeneticFTT_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170012F9 RID: 4857
			// (get) Token: 0x06004D5B RID: 19803 RVA: 0x0019F238 File Offset: 0x0019D438
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._FirstGeneticFTT_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004D5C RID: 19804 RVA: 0x0019F278 File Offset: 0x0019D478
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71376, XrefRangeEnd = 71384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TutorialAction> System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._FirstGeneticFTT_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TutorialAction>>(intPtr3) : null;
			}

			// Token: 0x06004D5D RID: 19805 RVA: 0x0019F2B8 File Offset: 0x0019D4B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._FirstGeneticFTT_d__13.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06004D5E RID: 19806 RVA: 0x0001A999 File Offset: 0x00018B99
			public _FirstGeneticFTT_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012F2 RID: 4850
			// (get) Token: 0x06004D5F RID: 19807 RVA: 0x0019F2F8 File Offset: 0x0019D4F8
			// (set) Token: 0x06004D60 RID: 19808 RVA: 0x0001A9A2 File Offset: 0x00018BA2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FirstGeneticFTT_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FirstGeneticFTT_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170012F3 RID: 4851
			// (get) Token: 0x06004D61 RID: 19809 RVA: 0x0019F320 File Offset: 0x0019D520
			// (set) Token: 0x06004D62 RID: 19810 RVA: 0x0001A9BD File Offset: 0x00018BBD
			public unsafe TutorialAction __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FirstGeneticFTT_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FirstGeneticFTT_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012F4 RID: 4852
			// (get) Token: 0x06004D63 RID: 19811 RVA: 0x0019F350 File Offset: 0x0019D550
			// (set) Token: 0x06004D64 RID: 19812 RVA: 0x0001A9DC File Offset: 0x00018BDC
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FirstGeneticFTT_d__13.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FirstGeneticFTT_d__13.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170012F5 RID: 4853
			// (get) Token: 0x06004D65 RID: 19813 RVA: 0x0019F378 File Offset: 0x0019D578
			// (set) Token: 0x06004D66 RID: 19814 RVA: 0x0001A9F7 File Offset: 0x00018BF7
			public unsafe WormMatch wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FirstGeneticFTT_d__13.NativeFieldInfoPtr_wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FirstGeneticFTT_d__13.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012F6 RID: 4854
			// (get) Token: 0x06004D67 RID: 19815 RVA: 0x0019F3A8 File Offset: 0x0019D5A8
			// (set) Token: 0x06004D68 RID: 19816 RVA: 0x0001AA16 File Offset: 0x00018C16
			public unsafe WormMatch __3__wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FirstGeneticFTT_d__13.NativeFieldInfoPtr___3__wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FirstGeneticFTT_d__13.NativeFieldInfoPtr___3__wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012F7 RID: 4855
			// (get) Token: 0x06004D69 RID: 19817 RVA: 0x0019F3D8 File Offset: 0x0019D5D8
			// (set) Token: 0x06004D6A RID: 19818 RVA: 0x0001AA35 File Offset: 0x00018C35
			public unsafe TutorialCampaignEmitter.__c__DisplayClass13_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FirstGeneticFTT_d__13.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialCampaignEmitter.__c__DisplayClass13_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FirstGeneticFTT_d__13.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040032C2 RID: 12994
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040032C3 RID: 12995
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040032C4 RID: 12996
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040032C5 RID: 12997
			private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

			// Token: 0x040032C6 RID: 12998
			private static readonly IntPtr NativeFieldInfoPtr___3__wormMatch;

			// Token: 0x040032C7 RID: 12999
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040032C8 RID: 13000
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040032C9 RID: 13001
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040032CA RID: 13002
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040032CB RID: 13003
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0;

			// Token: 0x040032CC RID: 13004
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040032CD RID: 13005
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040032CE RID: 13006
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0;

			// Token: 0x040032CF RID: 13007
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200060B RID: 1547
		[ObfuscatedName("worm.canis.data.Tutorial.FirstTime.TutorialCampaignEmitter+<FirstLiveGameFTT>d__15")]
		public sealed class _FirstLiveGameFTT_d__15 : Object
		{
			// Token: 0x06004D6B RID: 19819 RVA: 0x0019F408 File Offset: 0x0019D608
			// Note: this type is marked as 'beforefieldinit'.
			static _FirstLiveGameFTT_d__15()
			{
				Il2CppClassPointerStore<TutorialCampaignEmitter._FirstLiveGameFTT_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, "<FirstLiveGameFTT>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialCampaignEmitter._FirstLiveGameFTT_d__15>.NativeClassPtr);
				TutorialCampaignEmitter._FirstLiveGameFTT_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._FirstLiveGameFTT_d__15>.NativeClassPtr, "<>1__state");
				TutorialCampaignEmitter._FirstLiveGameFTT_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._FirstLiveGameFTT_d__15>.NativeClassPtr, "<>2__current");
				TutorialCampaignEmitter._FirstLiveGameFTT_d__15.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._FirstLiveGameFTT_d__15>.NativeClassPtr, "<>l__initialThreadId");
				TutorialCampaignEmitter._FirstLiveGameFTT_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._FirstLiveGameFTT_d__15>.NativeClassPtr, 100665295);
				TutorialCampaignEmitter._FirstLiveGameFTT_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._FirstLiveGameFTT_d__15>.NativeClassPtr, 100665296);
				TutorialCampaignEmitter._FirstLiveGameFTT_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._FirstLiveGameFTT_d__15>.NativeClassPtr, 100665297);
				TutorialCampaignEmitter._FirstLiveGameFTT_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._FirstLiveGameFTT_d__15>.NativeClassPtr, 100665298);
				TutorialCampaignEmitter._FirstLiveGameFTT_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._FirstLiveGameFTT_d__15>.NativeClassPtr, 100665299);
				TutorialCampaignEmitter._FirstLiveGameFTT_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._FirstLiveGameFTT_d__15>.NativeClassPtr, 100665300);
				TutorialCampaignEmitter._FirstLiveGameFTT_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._FirstLiveGameFTT_d__15>.NativeClassPtr, 100665301);
				TutorialCampaignEmitter._FirstLiveGameFTT_d__15.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._FirstLiveGameFTT_d__15>.NativeClassPtr, 100665302);
			}

			// Token: 0x06004D6C RID: 19820 RVA: 0x0019F510 File Offset: 0x0019D710
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _FirstLiveGameFTT_d__15(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialCampaignEmitter._FirstLiveGameFTT_d__15>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._FirstLiveGameFTT_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004D6D RID: 19821 RVA: 0x0019F558 File Offset: 0x0019D758
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._FirstLiveGameFTT_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D6E RID: 19822 RVA: 0x0019F58C File Offset: 0x0019D78C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71384, XrefRangeEnd = 71395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._FirstLiveGameFTT_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170012FD RID: 4861
			// (get) Token: 0x06004D6F RID: 19823 RVA: 0x0019F5C8 File Offset: 0x0019D7C8
			public unsafe TutorialAction System.Collections.Generic.IEnumerator<Canis.tutorialScripts.TutorialAction>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._FirstLiveGameFTT_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr3) : null;
				}
			}

			// Token: 0x06004D70 RID: 19824 RVA: 0x0019F608 File Offset: 0x0019D808
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71395, XrefRangeEnd = 71400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._FirstLiveGameFTT_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170012FE RID: 4862
			// (get) Token: 0x06004D71 RID: 19825 RVA: 0x0019F63C File Offset: 0x0019D83C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._FirstLiveGameFTT_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004D72 RID: 19826 RVA: 0x0019F67C File Offset: 0x0019D87C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71400, XrefRangeEnd = 71402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TutorialAction> System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._FirstLiveGameFTT_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TutorialAction>>(intPtr3) : null;
			}

			// Token: 0x06004D73 RID: 19827 RVA: 0x0019F6BC File Offset: 0x0019D8BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._FirstLiveGameFTT_d__15.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06004D74 RID: 19828 RVA: 0x0001AA54 File Offset: 0x00018C54
			public _FirstLiveGameFTT_d__15(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012FA RID: 4858
			// (get) Token: 0x06004D75 RID: 19829 RVA: 0x0019F6FC File Offset: 0x0019D8FC
			// (set) Token: 0x06004D76 RID: 19830 RVA: 0x0001AA5D File Offset: 0x00018C5D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FirstLiveGameFTT_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FirstLiveGameFTT_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170012FB RID: 4859
			// (get) Token: 0x06004D77 RID: 19831 RVA: 0x0019F724 File Offset: 0x0019D924
			// (set) Token: 0x06004D78 RID: 19832 RVA: 0x0001AA78 File Offset: 0x00018C78
			public unsafe TutorialAction __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FirstLiveGameFTT_d__15.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FirstLiveGameFTT_d__15.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012FC RID: 4860
			// (get) Token: 0x06004D79 RID: 19833 RVA: 0x0019F754 File Offset: 0x0019D954
			// (set) Token: 0x06004D7A RID: 19834 RVA: 0x0001AA97 File Offset: 0x00018C97
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FirstLiveGameFTT_d__15.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FirstLiveGameFTT_d__15.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x040032D0 RID: 13008
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040032D1 RID: 13009
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040032D2 RID: 13010
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040032D3 RID: 13011
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040032D4 RID: 13012
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040032D5 RID: 13013
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040032D6 RID: 13014
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0;

			// Token: 0x040032D7 RID: 13015
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040032D8 RID: 13016
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040032D9 RID: 13017
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0;

			// Token: 0x040032DA RID: 13018
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200060C RID: 1548
		[ObfuscatedName("worm.canis.data.Tutorial.FirstTime.TutorialCampaignEmitter+<FoldspaceFTT>d__17")]
		public sealed class _FoldspaceFTT_d__17 : Object
		{
			// Token: 0x06004D7B RID: 19835 RVA: 0x0019F77C File Offset: 0x0019D97C
			// Note: this type is marked as 'beforefieldinit'.
			static _FoldspaceFTT_d__17()
			{
				Il2CppClassPointerStore<TutorialCampaignEmitter._FoldspaceFTT_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, "<FoldspaceFTT>d__17");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialCampaignEmitter._FoldspaceFTT_d__17>.NativeClassPtr);
				TutorialCampaignEmitter._FoldspaceFTT_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._FoldspaceFTT_d__17>.NativeClassPtr, "<>1__state");
				TutorialCampaignEmitter._FoldspaceFTT_d__17.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._FoldspaceFTT_d__17>.NativeClassPtr, "<>2__current");
				TutorialCampaignEmitter._FoldspaceFTT_d__17.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._FoldspaceFTT_d__17>.NativeClassPtr, "<>l__initialThreadId");
				TutorialCampaignEmitter._FoldspaceFTT_d__17.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._FoldspaceFTT_d__17>.NativeClassPtr, "player");
				TutorialCampaignEmitter._FoldspaceFTT_d__17.NativeFieldInfoPtr___3__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._FoldspaceFTT_d__17>.NativeClassPtr, "<>3__player");
				TutorialCampaignEmitter._FoldspaceFTT_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._FoldspaceFTT_d__17>.NativeClassPtr, 100665303);
				TutorialCampaignEmitter._FoldspaceFTT_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._FoldspaceFTT_d__17>.NativeClassPtr, 100665304);
				TutorialCampaignEmitter._FoldspaceFTT_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._FoldspaceFTT_d__17>.NativeClassPtr, 100665305);
				TutorialCampaignEmitter._FoldspaceFTT_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._FoldspaceFTT_d__17>.NativeClassPtr, 100665306);
				TutorialCampaignEmitter._FoldspaceFTT_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._FoldspaceFTT_d__17>.NativeClassPtr, 100665307);
				TutorialCampaignEmitter._FoldspaceFTT_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._FoldspaceFTT_d__17>.NativeClassPtr, 100665308);
				TutorialCampaignEmitter._FoldspaceFTT_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._FoldspaceFTT_d__17>.NativeClassPtr, 100665309);
				TutorialCampaignEmitter._FoldspaceFTT_d__17.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._FoldspaceFTT_d__17>.NativeClassPtr, 100665310);
			}

			// Token: 0x06004D7C RID: 19836 RVA: 0x0019F8AC File Offset: 0x0019DAAC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _FoldspaceFTT_d__17(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialCampaignEmitter._FoldspaceFTT_d__17>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._FoldspaceFTT_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004D7D RID: 19837 RVA: 0x0019F8F4 File Offset: 0x0019DAF4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._FoldspaceFTT_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D7E RID: 19838 RVA: 0x0019F928 File Offset: 0x0019DB28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71402, XrefRangeEnd = 71410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._FoldspaceFTT_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001304 RID: 4868
			// (get) Token: 0x06004D7F RID: 19839 RVA: 0x0019F964 File Offset: 0x0019DB64
			public unsafe TutorialAction System.Collections.Generic.IEnumerator<Canis.tutorialScripts.TutorialAction>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._FoldspaceFTT_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr3) : null;
				}
			}

			// Token: 0x06004D80 RID: 19840 RVA: 0x0019F9A4 File Offset: 0x0019DBA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71410, XrefRangeEnd = 71415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._FoldspaceFTT_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001305 RID: 4869
			// (get) Token: 0x06004D81 RID: 19841 RVA: 0x0019F9D8 File Offset: 0x0019DBD8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._FoldspaceFTT_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004D82 RID: 19842 RVA: 0x0019FA18 File Offset: 0x0019DC18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71415, XrefRangeEnd = 71423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TutorialAction> System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._FoldspaceFTT_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TutorialAction>>(intPtr3) : null;
			}

			// Token: 0x06004D83 RID: 19843 RVA: 0x0019FA58 File Offset: 0x0019DC58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._FoldspaceFTT_d__17.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06004D84 RID: 19844 RVA: 0x0001AAB2 File Offset: 0x00018CB2
			public _FoldspaceFTT_d__17(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012FF RID: 4863
			// (get) Token: 0x06004D85 RID: 19845 RVA: 0x0019FA98 File Offset: 0x0019DC98
			// (set) Token: 0x06004D86 RID: 19846 RVA: 0x0001AABB File Offset: 0x00018CBB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FoldspaceFTT_d__17.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FoldspaceFTT_d__17.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001300 RID: 4864
			// (get) Token: 0x06004D87 RID: 19847 RVA: 0x0019FAC0 File Offset: 0x0019DCC0
			// (set) Token: 0x06004D88 RID: 19848 RVA: 0x0001AAD6 File Offset: 0x00018CD6
			public unsafe TutorialAction __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FoldspaceFTT_d__17.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FoldspaceFTT_d__17.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001301 RID: 4865
			// (get) Token: 0x06004D89 RID: 19849 RVA: 0x0019FAF0 File Offset: 0x0019DCF0
			// (set) Token: 0x06004D8A RID: 19850 RVA: 0x0001AAF5 File Offset: 0x00018CF5
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FoldspaceFTT_d__17.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FoldspaceFTT_d__17.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001302 RID: 4866
			// (get) Token: 0x06004D8B RID: 19851 RVA: 0x0019FB18 File Offset: 0x0019DD18
			// (set) Token: 0x06004D8C RID: 19852 RVA: 0x0001AB10 File Offset: 0x00018D10
			public unsafe PlayerEntity player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FoldspaceFTT_d__17.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FoldspaceFTT_d__17.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001303 RID: 4867
			// (get) Token: 0x06004D8D RID: 19853 RVA: 0x0019FB48 File Offset: 0x0019DD48
			// (set) Token: 0x06004D8E RID: 19854 RVA: 0x0001AB2F File Offset: 0x00018D2F
			public unsafe PlayerEntity __3__player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FoldspaceFTT_d__17.NativeFieldInfoPtr___3__player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FoldspaceFTT_d__17.NativeFieldInfoPtr___3__player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040032DB RID: 13019
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040032DC RID: 13020
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040032DD RID: 13021
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040032DE RID: 13022
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x040032DF RID: 13023
			private static readonly IntPtr NativeFieldInfoPtr___3__player;

			// Token: 0x040032E0 RID: 13024
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040032E1 RID: 13025
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040032E2 RID: 13026
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040032E3 RID: 13027
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0;

			// Token: 0x040032E4 RID: 13028
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040032E5 RID: 13029
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040032E6 RID: 13030
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0;

			// Token: 0x040032E7 RID: 13031
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200060D RID: 1549
		[ObfuscatedName("worm.canis.data.Tutorial.FirstTime.TutorialCampaignEmitter+<FremenBondFTT>d__19")]
		public sealed class _FremenBondFTT_d__19 : Object
		{
			// Token: 0x06004D8F RID: 19855 RVA: 0x0019FB78 File Offset: 0x0019DD78
			// Note: this type is marked as 'beforefieldinit'.
			static _FremenBondFTT_d__19()
			{
				Il2CppClassPointerStore<TutorialCampaignEmitter._FremenBondFTT_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, "<FremenBondFTT>d__19");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialCampaignEmitter._FremenBondFTT_d__19>.NativeClassPtr);
				TutorialCampaignEmitter._FremenBondFTT_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._FremenBondFTT_d__19>.NativeClassPtr, "<>1__state");
				TutorialCampaignEmitter._FremenBondFTT_d__19.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._FremenBondFTT_d__19>.NativeClassPtr, "<>2__current");
				TutorialCampaignEmitter._FremenBondFTT_d__19.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._FremenBondFTT_d__19>.NativeClassPtr, "<>l__initialThreadId");
				TutorialCampaignEmitter._FremenBondFTT_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._FremenBondFTT_d__19>.NativeClassPtr, 100665311);
				TutorialCampaignEmitter._FremenBondFTT_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._FremenBondFTT_d__19>.NativeClassPtr, 100665312);
				TutorialCampaignEmitter._FremenBondFTT_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._FremenBondFTT_d__19>.NativeClassPtr, 100665313);
				TutorialCampaignEmitter._FremenBondFTT_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._FremenBondFTT_d__19>.NativeClassPtr, 100665314);
				TutorialCampaignEmitter._FremenBondFTT_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._FremenBondFTT_d__19>.NativeClassPtr, 100665315);
				TutorialCampaignEmitter._FremenBondFTT_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._FremenBondFTT_d__19>.NativeClassPtr, 100665316);
				TutorialCampaignEmitter._FremenBondFTT_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._FremenBondFTT_d__19>.NativeClassPtr, 100665317);
				TutorialCampaignEmitter._FremenBondFTT_d__19.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._FremenBondFTT_d__19>.NativeClassPtr, 100665318);
			}

			// Token: 0x06004D90 RID: 19856 RVA: 0x0019FC80 File Offset: 0x0019DE80
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _FremenBondFTT_d__19(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialCampaignEmitter._FremenBondFTT_d__19>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._FremenBondFTT_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004D91 RID: 19857 RVA: 0x0019FCC8 File Offset: 0x0019DEC8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._FremenBondFTT_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D92 RID: 19858 RVA: 0x0019FCFC File Offset: 0x0019DEFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71423, XrefRangeEnd = 71438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._FremenBondFTT_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001309 RID: 4873
			// (get) Token: 0x06004D93 RID: 19859 RVA: 0x0019FD38 File Offset: 0x0019DF38
			public unsafe TutorialAction System.Collections.Generic.IEnumerator<Canis.tutorialScripts.TutorialAction>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._FremenBondFTT_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr3) : null;
				}
			}

			// Token: 0x06004D94 RID: 19860 RVA: 0x0019FD78 File Offset: 0x0019DF78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71438, XrefRangeEnd = 71443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._FremenBondFTT_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700130A RID: 4874
			// (get) Token: 0x06004D95 RID: 19861 RVA: 0x0019FDAC File Offset: 0x0019DFAC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._FremenBondFTT_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004D96 RID: 19862 RVA: 0x0019FDEC File Offset: 0x0019DFEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71443, XrefRangeEnd = 71445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TutorialAction> System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._FremenBondFTT_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TutorialAction>>(intPtr3) : null;
			}

			// Token: 0x06004D97 RID: 19863 RVA: 0x0019FE2C File Offset: 0x0019E02C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._FremenBondFTT_d__19.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06004D98 RID: 19864 RVA: 0x0001AB4E File Offset: 0x00018D4E
			public _FremenBondFTT_d__19(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001306 RID: 4870
			// (get) Token: 0x06004D99 RID: 19865 RVA: 0x0019FE6C File Offset: 0x0019E06C
			// (set) Token: 0x06004D9A RID: 19866 RVA: 0x0001AB57 File Offset: 0x00018D57
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FremenBondFTT_d__19.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FremenBondFTT_d__19.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001307 RID: 4871
			// (get) Token: 0x06004D9B RID: 19867 RVA: 0x0019FE94 File Offset: 0x0019E094
			// (set) Token: 0x06004D9C RID: 19868 RVA: 0x0001AB72 File Offset: 0x00018D72
			public unsafe TutorialAction __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FremenBondFTT_d__19.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FremenBondFTT_d__19.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001308 RID: 4872
			// (get) Token: 0x06004D9D RID: 19869 RVA: 0x0019FEC4 File Offset: 0x0019E0C4
			// (set) Token: 0x06004D9E RID: 19870 RVA: 0x0001AB91 File Offset: 0x00018D91
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FremenBondFTT_d__19.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._FremenBondFTT_d__19.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x040032E8 RID: 13032
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040032E9 RID: 13033
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040032EA RID: 13034
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040032EB RID: 13035
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040032EC RID: 13036
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040032ED RID: 13037
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040032EE RID: 13038
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0;

			// Token: 0x040032EF RID: 13039
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040032F0 RID: 13040
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040032F1 RID: 13041
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0;

			// Token: 0x040032F2 RID: 13042
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200060E RID: 1550
		[ObfuscatedName("worm.canis.data.Tutorial.FirstTime.TutorialCampaignEmitter+<GraftFTT>d__21")]
		public sealed class _GraftFTT_d__21 : Object
		{
			// Token: 0x06004D9F RID: 19871 RVA: 0x0019FEEC File Offset: 0x0019E0EC
			// Note: this type is marked as 'beforefieldinit'.
			static _GraftFTT_d__21()
			{
				Il2CppClassPointerStore<TutorialCampaignEmitter._GraftFTT_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, "<GraftFTT>d__21");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialCampaignEmitter._GraftFTT_d__21>.NativeClassPtr);
				TutorialCampaignEmitter._GraftFTT_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._GraftFTT_d__21>.NativeClassPtr, "<>1__state");
				TutorialCampaignEmitter._GraftFTT_d__21.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._GraftFTT_d__21>.NativeClassPtr, "<>2__current");
				TutorialCampaignEmitter._GraftFTT_d__21.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._GraftFTT_d__21>.NativeClassPtr, "<>l__initialThreadId");
				TutorialCampaignEmitter._GraftFTT_d__21.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._GraftFTT_d__21>.NativeClassPtr, "player");
				TutorialCampaignEmitter._GraftFTT_d__21.NativeFieldInfoPtr___3__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._GraftFTT_d__21>.NativeClassPtr, "<>3__player");
				TutorialCampaignEmitter._GraftFTT_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._GraftFTT_d__21>.NativeClassPtr, 100665319);
				TutorialCampaignEmitter._GraftFTT_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._GraftFTT_d__21>.NativeClassPtr, 100665320);
				TutorialCampaignEmitter._GraftFTT_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._GraftFTT_d__21>.NativeClassPtr, 100665321);
				TutorialCampaignEmitter._GraftFTT_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._GraftFTT_d__21>.NativeClassPtr, 100665322);
				TutorialCampaignEmitter._GraftFTT_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._GraftFTT_d__21>.NativeClassPtr, 100665323);
				TutorialCampaignEmitter._GraftFTT_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._GraftFTT_d__21>.NativeClassPtr, 100665324);
				TutorialCampaignEmitter._GraftFTT_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._GraftFTT_d__21>.NativeClassPtr, 100665325);
				TutorialCampaignEmitter._GraftFTT_d__21.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._GraftFTT_d__21>.NativeClassPtr, 100665326);
			}

			// Token: 0x06004DA0 RID: 19872 RVA: 0x001A001C File Offset: 0x0019E21C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GraftFTT_d__21(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialCampaignEmitter._GraftFTT_d__21>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._GraftFTT_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004DA1 RID: 19873 RVA: 0x001A0064 File Offset: 0x0019E264
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._GraftFTT_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004DA2 RID: 19874 RVA: 0x001A0098 File Offset: 0x0019E298
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71445, XrefRangeEnd = 71508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._GraftFTT_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001310 RID: 4880
			// (get) Token: 0x06004DA3 RID: 19875 RVA: 0x001A00D4 File Offset: 0x0019E2D4
			public unsafe TutorialAction System.Collections.Generic.IEnumerator<Canis.tutorialScripts.TutorialAction>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._GraftFTT_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr3) : null;
				}
			}

			// Token: 0x06004DA4 RID: 19876 RVA: 0x001A0114 File Offset: 0x0019E314
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71508, XrefRangeEnd = 71513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._GraftFTT_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001311 RID: 4881
			// (get) Token: 0x06004DA5 RID: 19877 RVA: 0x001A0148 File Offset: 0x0019E348
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._GraftFTT_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004DA6 RID: 19878 RVA: 0x001A0188 File Offset: 0x0019E388
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71513, XrefRangeEnd = 71521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TutorialAction> System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._GraftFTT_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TutorialAction>>(intPtr3) : null;
			}

			// Token: 0x06004DA7 RID: 19879 RVA: 0x001A01C8 File Offset: 0x0019E3C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._GraftFTT_d__21.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06004DA8 RID: 19880 RVA: 0x0001ABAC File Offset: 0x00018DAC
			public _GraftFTT_d__21(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700130B RID: 4875
			// (get) Token: 0x06004DA9 RID: 19881 RVA: 0x001A0208 File Offset: 0x0019E408
			// (set) Token: 0x06004DAA RID: 19882 RVA: 0x0001ABB5 File Offset: 0x00018DB5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._GraftFTT_d__21.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._GraftFTT_d__21.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700130C RID: 4876
			// (get) Token: 0x06004DAB RID: 19883 RVA: 0x001A0230 File Offset: 0x0019E430
			// (set) Token: 0x06004DAC RID: 19884 RVA: 0x0001ABD0 File Offset: 0x00018DD0
			public unsafe TutorialAction __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._GraftFTT_d__21.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._GraftFTT_d__21.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700130D RID: 4877
			// (get) Token: 0x06004DAD RID: 19885 RVA: 0x001A0260 File Offset: 0x0019E460
			// (set) Token: 0x06004DAE RID: 19886 RVA: 0x0001ABEF File Offset: 0x00018DEF
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._GraftFTT_d__21.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._GraftFTT_d__21.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700130E RID: 4878
			// (get) Token: 0x06004DAF RID: 19887 RVA: 0x001A0288 File Offset: 0x0019E488
			// (set) Token: 0x06004DB0 RID: 19888 RVA: 0x0001AC0A File Offset: 0x00018E0A
			public unsafe PlayerEntity player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._GraftFTT_d__21.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._GraftFTT_d__21.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700130F RID: 4879
			// (get) Token: 0x06004DB1 RID: 19889 RVA: 0x001A02B8 File Offset: 0x0019E4B8
			// (set) Token: 0x06004DB2 RID: 19890 RVA: 0x0001AC29 File Offset: 0x00018E29
			public unsafe PlayerEntity __3__player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._GraftFTT_d__21.NativeFieldInfoPtr___3__player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._GraftFTT_d__21.NativeFieldInfoPtr___3__player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040032F3 RID: 13043
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040032F4 RID: 13044
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040032F5 RID: 13045
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040032F6 RID: 13046
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x040032F7 RID: 13047
			private static readonly IntPtr NativeFieldInfoPtr___3__player;

			// Token: 0x040032F8 RID: 13048
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040032F9 RID: 13049
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040032FA RID: 13050
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040032FB RID: 13051
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0;

			// Token: 0x040032FC RID: 13052
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040032FD RID: 13053
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040032FE RID: 13054
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0;

			// Token: 0x040032FF RID: 13055
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200060F RID: 1551
		[ObfuscatedName("worm.canis.data.Tutorial.FirstTime.TutorialCampaignEmitter+<GraftRevealFTT>d__23")]
		public sealed class _GraftRevealFTT_d__23 : Object
		{
			// Token: 0x06004DB3 RID: 19891 RVA: 0x001A02E8 File Offset: 0x0019E4E8
			// Note: this type is marked as 'beforefieldinit'.
			static _GraftRevealFTT_d__23()
			{
				Il2CppClassPointerStore<TutorialCampaignEmitter._GraftRevealFTT_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, "<GraftRevealFTT>d__23");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialCampaignEmitter._GraftRevealFTT_d__23>.NativeClassPtr);
				TutorialCampaignEmitter._GraftRevealFTT_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._GraftRevealFTT_d__23>.NativeClassPtr, "<>1__state");
				TutorialCampaignEmitter._GraftRevealFTT_d__23.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._GraftRevealFTT_d__23>.NativeClassPtr, "<>2__current");
				TutorialCampaignEmitter._GraftRevealFTT_d__23.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._GraftRevealFTT_d__23>.NativeClassPtr, "<>l__initialThreadId");
				TutorialCampaignEmitter._GraftRevealFTT_d__23.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._GraftRevealFTT_d__23>.NativeClassPtr, "player");
				TutorialCampaignEmitter._GraftRevealFTT_d__23.NativeFieldInfoPtr___3__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._GraftRevealFTT_d__23>.NativeClassPtr, "<>3__player");
				TutorialCampaignEmitter._GraftRevealFTT_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._GraftRevealFTT_d__23>.NativeClassPtr, 100665327);
				TutorialCampaignEmitter._GraftRevealFTT_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._GraftRevealFTT_d__23>.NativeClassPtr, 100665328);
				TutorialCampaignEmitter._GraftRevealFTT_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._GraftRevealFTT_d__23>.NativeClassPtr, 100665329);
				TutorialCampaignEmitter._GraftRevealFTT_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._GraftRevealFTT_d__23>.NativeClassPtr, 100665330);
				TutorialCampaignEmitter._GraftRevealFTT_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._GraftRevealFTT_d__23>.NativeClassPtr, 100665331);
				TutorialCampaignEmitter._GraftRevealFTT_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._GraftRevealFTT_d__23>.NativeClassPtr, 100665332);
				TutorialCampaignEmitter._GraftRevealFTT_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._GraftRevealFTT_d__23>.NativeClassPtr, 100665333);
				TutorialCampaignEmitter._GraftRevealFTT_d__23.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._GraftRevealFTT_d__23>.NativeClassPtr, 100665334);
			}

			// Token: 0x06004DB4 RID: 19892 RVA: 0x001A0418 File Offset: 0x0019E618
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GraftRevealFTT_d__23(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialCampaignEmitter._GraftRevealFTT_d__23>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._GraftRevealFTT_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004DB5 RID: 19893 RVA: 0x001A0460 File Offset: 0x0019E660
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._GraftRevealFTT_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004DB6 RID: 19894 RVA: 0x001A0494 File Offset: 0x0019E694
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71521, XrefRangeEnd = 71537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._GraftRevealFTT_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001317 RID: 4887
			// (get) Token: 0x06004DB7 RID: 19895 RVA: 0x001A04D0 File Offset: 0x0019E6D0
			public unsafe TutorialAction System.Collections.Generic.IEnumerator<Canis.tutorialScripts.TutorialAction>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._GraftRevealFTT_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr3) : null;
				}
			}

			// Token: 0x06004DB8 RID: 19896 RVA: 0x001A0510 File Offset: 0x0019E710
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71537, XrefRangeEnd = 71542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._GraftRevealFTT_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001318 RID: 4888
			// (get) Token: 0x06004DB9 RID: 19897 RVA: 0x001A0544 File Offset: 0x0019E744
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._GraftRevealFTT_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004DBA RID: 19898 RVA: 0x001A0584 File Offset: 0x0019E784
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71542, XrefRangeEnd = 71550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TutorialAction> System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._GraftRevealFTT_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TutorialAction>>(intPtr3) : null;
			}

			// Token: 0x06004DBB RID: 19899 RVA: 0x001A05C4 File Offset: 0x0019E7C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._GraftRevealFTT_d__23.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06004DBC RID: 19900 RVA: 0x0001AC48 File Offset: 0x00018E48
			public _GraftRevealFTT_d__23(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001312 RID: 4882
			// (get) Token: 0x06004DBD RID: 19901 RVA: 0x001A0604 File Offset: 0x0019E804
			// (set) Token: 0x06004DBE RID: 19902 RVA: 0x0001AC51 File Offset: 0x00018E51
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._GraftRevealFTT_d__23.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._GraftRevealFTT_d__23.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001313 RID: 4883
			// (get) Token: 0x06004DBF RID: 19903 RVA: 0x001A062C File Offset: 0x0019E82C
			// (set) Token: 0x06004DC0 RID: 19904 RVA: 0x0001AC6C File Offset: 0x00018E6C
			public unsafe TutorialAction __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._GraftRevealFTT_d__23.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._GraftRevealFTT_d__23.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001314 RID: 4884
			// (get) Token: 0x06004DC1 RID: 19905 RVA: 0x001A065C File Offset: 0x0019E85C
			// (set) Token: 0x06004DC2 RID: 19906 RVA: 0x0001AC8B File Offset: 0x00018E8B
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._GraftRevealFTT_d__23.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._GraftRevealFTT_d__23.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001315 RID: 4885
			// (get) Token: 0x06004DC3 RID: 19907 RVA: 0x001A0684 File Offset: 0x0019E884
			// (set) Token: 0x06004DC4 RID: 19908 RVA: 0x0001ACA6 File Offset: 0x00018EA6
			public unsafe PlayerEntity player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._GraftRevealFTT_d__23.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._GraftRevealFTT_d__23.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001316 RID: 4886
			// (get) Token: 0x06004DC5 RID: 19909 RVA: 0x001A06B4 File Offset: 0x0019E8B4
			// (set) Token: 0x06004DC6 RID: 19910 RVA: 0x0001ACC5 File Offset: 0x00018EC5
			public unsafe PlayerEntity __3__player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._GraftRevealFTT_d__23.NativeFieldInfoPtr___3__player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._GraftRevealFTT_d__23.NativeFieldInfoPtr___3__player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003300 RID: 13056
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003301 RID: 13057
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003302 RID: 13058
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003303 RID: 13059
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04003304 RID: 13060
			private static readonly IntPtr NativeFieldInfoPtr___3__player;

			// Token: 0x04003305 RID: 13061
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003306 RID: 13062
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003307 RID: 13063
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003308 RID: 13064
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0;

			// Token: 0x04003309 RID: 13065
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400330A RID: 13066
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400330B RID: 13067
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0;

			// Token: 0x0400330C RID: 13068
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000610 RID: 1552
		[ObfuscatedName("worm.canis.data.Tutorial.FirstTime.TutorialCampaignEmitter+<HagalImmortalityFTT>d__25")]
		public sealed class _HagalImmortalityFTT_d__25 : Object
		{
			// Token: 0x06004DC7 RID: 19911 RVA: 0x001A06E4 File Offset: 0x0019E8E4
			// Note: this type is marked as 'beforefieldinit'.
			static _HagalImmortalityFTT_d__25()
			{
				Il2CppClassPointerStore<TutorialCampaignEmitter._HagalImmortalityFTT_d__25>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, "<HagalImmortalityFTT>d__25");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialCampaignEmitter._HagalImmortalityFTT_d__25>.NativeClassPtr);
				TutorialCampaignEmitter._HagalImmortalityFTT_d__25.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._HagalImmortalityFTT_d__25>.NativeClassPtr, "<>1__state");
				TutorialCampaignEmitter._HagalImmortalityFTT_d__25.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._HagalImmortalityFTT_d__25>.NativeClassPtr, "<>2__current");
				TutorialCampaignEmitter._HagalImmortalityFTT_d__25.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._HagalImmortalityFTT_d__25>.NativeClassPtr, "<>l__initialThreadId");
				TutorialCampaignEmitter._HagalImmortalityFTT_d__25.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._HagalImmortalityFTT_d__25>.NativeClassPtr, "wormMatch");
				TutorialCampaignEmitter._HagalImmortalityFTT_d__25.NativeFieldInfoPtr___3__wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._HagalImmortalityFTT_d__25>.NativeClassPtr, "<>3__wormMatch");
				TutorialCampaignEmitter._HagalImmortalityFTT_d__25.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._HagalImmortalityFTT_d__25>.NativeClassPtr, "<>8__1");
				TutorialCampaignEmitter._HagalImmortalityFTT_d__25.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._HagalImmortalityFTT_d__25>.NativeClassPtr, 100665335);
				TutorialCampaignEmitter._HagalImmortalityFTT_d__25.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._HagalImmortalityFTT_d__25>.NativeClassPtr, 100665336);
				TutorialCampaignEmitter._HagalImmortalityFTT_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._HagalImmortalityFTT_d__25>.NativeClassPtr, 100665337);
				TutorialCampaignEmitter._HagalImmortalityFTT_d__25.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._HagalImmortalityFTT_d__25>.NativeClassPtr, 100665338);
				TutorialCampaignEmitter._HagalImmortalityFTT_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._HagalImmortalityFTT_d__25>.NativeClassPtr, 100665339);
				TutorialCampaignEmitter._HagalImmortalityFTT_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._HagalImmortalityFTT_d__25>.NativeClassPtr, 100665340);
				TutorialCampaignEmitter._HagalImmortalityFTT_d__25.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._HagalImmortalityFTT_d__25>.NativeClassPtr, 100665341);
				TutorialCampaignEmitter._HagalImmortalityFTT_d__25.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._HagalImmortalityFTT_d__25>.NativeClassPtr, 100665342);
			}

			// Token: 0x06004DC8 RID: 19912 RVA: 0x001A0828 File Offset: 0x0019EA28
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _HagalImmortalityFTT_d__25(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialCampaignEmitter._HagalImmortalityFTT_d__25>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._HagalImmortalityFTT_d__25.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004DC9 RID: 19913 RVA: 0x001A0870 File Offset: 0x0019EA70
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._HagalImmortalityFTT_d__25.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004DCA RID: 19914 RVA: 0x001A08A4 File Offset: 0x0019EAA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71550, XrefRangeEnd = 71603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._HagalImmortalityFTT_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700131F RID: 4895
			// (get) Token: 0x06004DCB RID: 19915 RVA: 0x001A08E0 File Offset: 0x0019EAE0
			public unsafe TutorialAction System.Collections.Generic.IEnumerator<Canis.tutorialScripts.TutorialAction>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._HagalImmortalityFTT_d__25.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr3) : null;
				}
			}

			// Token: 0x06004DCC RID: 19916 RVA: 0x001A0920 File Offset: 0x0019EB20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71603, XrefRangeEnd = 71608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._HagalImmortalityFTT_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001320 RID: 4896
			// (get) Token: 0x06004DCD RID: 19917 RVA: 0x001A0954 File Offset: 0x0019EB54
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._HagalImmortalityFTT_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004DCE RID: 19918 RVA: 0x001A0994 File Offset: 0x0019EB94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71608, XrefRangeEnd = 71616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TutorialAction> System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._HagalImmortalityFTT_d__25.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TutorialAction>>(intPtr3) : null;
			}

			// Token: 0x06004DCF RID: 19919 RVA: 0x001A09D4 File Offset: 0x0019EBD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._HagalImmortalityFTT_d__25.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06004DD0 RID: 19920 RVA: 0x0001ACE4 File Offset: 0x00018EE4
			public _HagalImmortalityFTT_d__25(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001319 RID: 4889
			// (get) Token: 0x06004DD1 RID: 19921 RVA: 0x001A0A14 File Offset: 0x0019EC14
			// (set) Token: 0x06004DD2 RID: 19922 RVA: 0x0001ACED File Offset: 0x00018EED
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._HagalImmortalityFTT_d__25.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._HagalImmortalityFTT_d__25.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700131A RID: 4890
			// (get) Token: 0x06004DD3 RID: 19923 RVA: 0x001A0A3C File Offset: 0x0019EC3C
			// (set) Token: 0x06004DD4 RID: 19924 RVA: 0x0001AD08 File Offset: 0x00018F08
			public unsafe TutorialAction __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._HagalImmortalityFTT_d__25.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._HagalImmortalityFTT_d__25.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700131B RID: 4891
			// (get) Token: 0x06004DD5 RID: 19925 RVA: 0x001A0A6C File Offset: 0x0019EC6C
			// (set) Token: 0x06004DD6 RID: 19926 RVA: 0x0001AD27 File Offset: 0x00018F27
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._HagalImmortalityFTT_d__25.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._HagalImmortalityFTT_d__25.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700131C RID: 4892
			// (get) Token: 0x06004DD7 RID: 19927 RVA: 0x001A0A94 File Offset: 0x0019EC94
			// (set) Token: 0x06004DD8 RID: 19928 RVA: 0x0001AD42 File Offset: 0x00018F42
			public unsafe WormMatch wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._HagalImmortalityFTT_d__25.NativeFieldInfoPtr_wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._HagalImmortalityFTT_d__25.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700131D RID: 4893
			// (get) Token: 0x06004DD9 RID: 19929 RVA: 0x001A0AC4 File Offset: 0x0019ECC4
			// (set) Token: 0x06004DDA RID: 19930 RVA: 0x0001AD61 File Offset: 0x00018F61
			public unsafe WormMatch __3__wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._HagalImmortalityFTT_d__25.NativeFieldInfoPtr___3__wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._HagalImmortalityFTT_d__25.NativeFieldInfoPtr___3__wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700131E RID: 4894
			// (get) Token: 0x06004DDB RID: 19931 RVA: 0x001A0AF4 File Offset: 0x0019ECF4
			// (set) Token: 0x06004DDC RID: 19932 RVA: 0x0001AD80 File Offset: 0x00018F80
			public unsafe TutorialCampaignEmitter.__c__DisplayClass25_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._HagalImmortalityFTT_d__25.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialCampaignEmitter.__c__DisplayClass25_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._HagalImmortalityFTT_d__25.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400330D RID: 13069
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400330E RID: 13070
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400330F RID: 13071
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003310 RID: 13072
			private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

			// Token: 0x04003311 RID: 13073
			private static readonly IntPtr NativeFieldInfoPtr___3__wormMatch;

			// Token: 0x04003312 RID: 13074
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04003313 RID: 13075
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003314 RID: 13076
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003315 RID: 13077
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003316 RID: 13078
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0;

			// Token: 0x04003317 RID: 13079
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003318 RID: 13080
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003319 RID: 13081
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0;

			// Token: 0x0400331A RID: 13082
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000611 RID: 1553
		[ObfuscatedName("worm.canis.data.Tutorial.FirstTime.TutorialCampaignEmitter+<RetreatFTT>d__27")]
		public sealed class _RetreatFTT_d__27 : Object
		{
			// Token: 0x06004DDD RID: 19933 RVA: 0x001A0B24 File Offset: 0x0019ED24
			// Note: this type is marked as 'beforefieldinit'.
			static _RetreatFTT_d__27()
			{
				Il2CppClassPointerStore<TutorialCampaignEmitter._RetreatFTT_d__27>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, "<RetreatFTT>d__27");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialCampaignEmitter._RetreatFTT_d__27>.NativeClassPtr);
				TutorialCampaignEmitter._RetreatFTT_d__27.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._RetreatFTT_d__27>.NativeClassPtr, "<>1__state");
				TutorialCampaignEmitter._RetreatFTT_d__27.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._RetreatFTT_d__27>.NativeClassPtr, "<>2__current");
				TutorialCampaignEmitter._RetreatFTT_d__27.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._RetreatFTT_d__27>.NativeClassPtr, "<>l__initialThreadId");
				TutorialCampaignEmitter._RetreatFTT_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._RetreatFTT_d__27>.NativeClassPtr, 100665343);
				TutorialCampaignEmitter._RetreatFTT_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._RetreatFTT_d__27>.NativeClassPtr, 100665344);
				TutorialCampaignEmitter._RetreatFTT_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._RetreatFTT_d__27>.NativeClassPtr, 100665345);
				TutorialCampaignEmitter._RetreatFTT_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._RetreatFTT_d__27>.NativeClassPtr, 100665346);
				TutorialCampaignEmitter._RetreatFTT_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._RetreatFTT_d__27>.NativeClassPtr, 100665347);
				TutorialCampaignEmitter._RetreatFTT_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._RetreatFTT_d__27>.NativeClassPtr, 100665348);
				TutorialCampaignEmitter._RetreatFTT_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._RetreatFTT_d__27>.NativeClassPtr, 100665349);
				TutorialCampaignEmitter._RetreatFTT_d__27.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._RetreatFTT_d__27>.NativeClassPtr, 100665350);
			}

			// Token: 0x06004DDE RID: 19934 RVA: 0x001A0C2C File Offset: 0x0019EE2C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RetreatFTT_d__27(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialCampaignEmitter._RetreatFTT_d__27>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._RetreatFTT_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004DDF RID: 19935 RVA: 0x001A0C74 File Offset: 0x0019EE74
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._RetreatFTT_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004DE0 RID: 19936 RVA: 0x001A0CA8 File Offset: 0x0019EEA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71616, XrefRangeEnd = 71629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._RetreatFTT_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001324 RID: 4900
			// (get) Token: 0x06004DE1 RID: 19937 RVA: 0x001A0CE4 File Offset: 0x0019EEE4
			public unsafe TutorialAction System.Collections.Generic.IEnumerator<Canis.tutorialScripts.TutorialAction>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._RetreatFTT_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr3) : null;
				}
			}

			// Token: 0x06004DE2 RID: 19938 RVA: 0x001A0D24 File Offset: 0x0019EF24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71629, XrefRangeEnd = 71634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._RetreatFTT_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001325 RID: 4901
			// (get) Token: 0x06004DE3 RID: 19939 RVA: 0x001A0D58 File Offset: 0x0019EF58
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._RetreatFTT_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004DE4 RID: 19940 RVA: 0x001A0D98 File Offset: 0x0019EF98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71634, XrefRangeEnd = 71636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TutorialAction> System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._RetreatFTT_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TutorialAction>>(intPtr3) : null;
			}

			// Token: 0x06004DE5 RID: 19941 RVA: 0x001A0DD8 File Offset: 0x0019EFD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._RetreatFTT_d__27.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06004DE6 RID: 19942 RVA: 0x0001AD9F File Offset: 0x00018F9F
			public _RetreatFTT_d__27(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001321 RID: 4897
			// (get) Token: 0x06004DE7 RID: 19943 RVA: 0x001A0E18 File Offset: 0x0019F018
			// (set) Token: 0x06004DE8 RID: 19944 RVA: 0x0001ADA8 File Offset: 0x00018FA8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._RetreatFTT_d__27.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._RetreatFTT_d__27.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001322 RID: 4898
			// (get) Token: 0x06004DE9 RID: 19945 RVA: 0x001A0E40 File Offset: 0x0019F040
			// (set) Token: 0x06004DEA RID: 19946 RVA: 0x0001ADC3 File Offset: 0x00018FC3
			public unsafe TutorialAction __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._RetreatFTT_d__27.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._RetreatFTT_d__27.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001323 RID: 4899
			// (get) Token: 0x06004DEB RID: 19947 RVA: 0x001A0E70 File Offset: 0x0019F070
			// (set) Token: 0x06004DEC RID: 19948 RVA: 0x0001ADE2 File Offset: 0x00018FE2
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._RetreatFTT_d__27.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._RetreatFTT_d__27.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x0400331B RID: 13083
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400331C RID: 13084
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400331D RID: 13085
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400331E RID: 13086
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400331F RID: 13087
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003320 RID: 13088
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003321 RID: 13089
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0;

			// Token: 0x04003322 RID: 13090
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003323 RID: 13091
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003324 RID: 13092
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0;

			// Token: 0x04003325 RID: 13093
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000612 RID: 1554
		[ObfuscatedName("worm.canis.data.Tutorial.FirstTime.TutorialCampaignEmitter+<SecondGeneticFTT>d__29")]
		public sealed class _SecondGeneticFTT_d__29 : Object
		{
			// Token: 0x06004DED RID: 19949 RVA: 0x001A0E98 File Offset: 0x0019F098
			// Note: this type is marked as 'beforefieldinit'.
			static _SecondGeneticFTT_d__29()
			{
				Il2CppClassPointerStore<TutorialCampaignEmitter._SecondGeneticFTT_d__29>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, "<SecondGeneticFTT>d__29");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialCampaignEmitter._SecondGeneticFTT_d__29>.NativeClassPtr);
				TutorialCampaignEmitter._SecondGeneticFTT_d__29.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._SecondGeneticFTT_d__29>.NativeClassPtr, "<>1__state");
				TutorialCampaignEmitter._SecondGeneticFTT_d__29.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._SecondGeneticFTT_d__29>.NativeClassPtr, "<>2__current");
				TutorialCampaignEmitter._SecondGeneticFTT_d__29.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._SecondGeneticFTT_d__29>.NativeClassPtr, "<>l__initialThreadId");
				TutorialCampaignEmitter._SecondGeneticFTT_d__29.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._SecondGeneticFTT_d__29>.NativeClassPtr, "wormMatch");
				TutorialCampaignEmitter._SecondGeneticFTT_d__29.NativeFieldInfoPtr___3__wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._SecondGeneticFTT_d__29>.NativeClassPtr, "<>3__wormMatch");
				TutorialCampaignEmitter._SecondGeneticFTT_d__29.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._SecondGeneticFTT_d__29>.NativeClassPtr, "<>8__1");
				TutorialCampaignEmitter._SecondGeneticFTT_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._SecondGeneticFTT_d__29>.NativeClassPtr, 100665351);
				TutorialCampaignEmitter._SecondGeneticFTT_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._SecondGeneticFTT_d__29>.NativeClassPtr, 100665352);
				TutorialCampaignEmitter._SecondGeneticFTT_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._SecondGeneticFTT_d__29>.NativeClassPtr, 100665353);
				TutorialCampaignEmitter._SecondGeneticFTT_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._SecondGeneticFTT_d__29>.NativeClassPtr, 100665354);
				TutorialCampaignEmitter._SecondGeneticFTT_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._SecondGeneticFTT_d__29>.NativeClassPtr, 100665355);
				TutorialCampaignEmitter._SecondGeneticFTT_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._SecondGeneticFTT_d__29>.NativeClassPtr, 100665356);
				TutorialCampaignEmitter._SecondGeneticFTT_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._SecondGeneticFTT_d__29>.NativeClassPtr, 100665357);
				TutorialCampaignEmitter._SecondGeneticFTT_d__29.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._SecondGeneticFTT_d__29>.NativeClassPtr, 100665358);
			}

			// Token: 0x06004DEE RID: 19950 RVA: 0x001A0FDC File Offset: 0x0019F1DC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SecondGeneticFTT_d__29(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialCampaignEmitter._SecondGeneticFTT_d__29>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._SecondGeneticFTT_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004DEF RID: 19951 RVA: 0x001A1024 File Offset: 0x0019F224
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._SecondGeneticFTT_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004DF0 RID: 19952 RVA: 0x001A1058 File Offset: 0x0019F258
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71636, XrefRangeEnd = 71688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._SecondGeneticFTT_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700132C RID: 4908
			// (get) Token: 0x06004DF1 RID: 19953 RVA: 0x001A1094 File Offset: 0x0019F294
			public unsafe TutorialAction System.Collections.Generic.IEnumerator<Canis.tutorialScripts.TutorialAction>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._SecondGeneticFTT_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr3) : null;
				}
			}

			// Token: 0x06004DF2 RID: 19954 RVA: 0x001A10D4 File Offset: 0x0019F2D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71688, XrefRangeEnd = 71693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._SecondGeneticFTT_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700132D RID: 4909
			// (get) Token: 0x06004DF3 RID: 19955 RVA: 0x001A1108 File Offset: 0x0019F308
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._SecondGeneticFTT_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004DF4 RID: 19956 RVA: 0x001A1148 File Offset: 0x0019F348
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71693, XrefRangeEnd = 71701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TutorialAction> System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._SecondGeneticFTT_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TutorialAction>>(intPtr3) : null;
			}

			// Token: 0x06004DF5 RID: 19957 RVA: 0x001A1188 File Offset: 0x0019F388
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._SecondGeneticFTT_d__29.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06004DF6 RID: 19958 RVA: 0x0001ADFD File Offset: 0x00018FFD
			public _SecondGeneticFTT_d__29(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001326 RID: 4902
			// (get) Token: 0x06004DF7 RID: 19959 RVA: 0x001A11C8 File Offset: 0x0019F3C8
			// (set) Token: 0x06004DF8 RID: 19960 RVA: 0x0001AE06 File Offset: 0x00019006
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._SecondGeneticFTT_d__29.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._SecondGeneticFTT_d__29.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001327 RID: 4903
			// (get) Token: 0x06004DF9 RID: 19961 RVA: 0x001A11F0 File Offset: 0x0019F3F0
			// (set) Token: 0x06004DFA RID: 19962 RVA: 0x0001AE21 File Offset: 0x00019021
			public unsafe TutorialAction __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._SecondGeneticFTT_d__29.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._SecondGeneticFTT_d__29.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001328 RID: 4904
			// (get) Token: 0x06004DFB RID: 19963 RVA: 0x001A1220 File Offset: 0x0019F420
			// (set) Token: 0x06004DFC RID: 19964 RVA: 0x0001AE40 File Offset: 0x00019040
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._SecondGeneticFTT_d__29.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._SecondGeneticFTT_d__29.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001329 RID: 4905
			// (get) Token: 0x06004DFD RID: 19965 RVA: 0x001A1248 File Offset: 0x0019F448
			// (set) Token: 0x06004DFE RID: 19966 RVA: 0x0001AE5B File Offset: 0x0001905B
			public unsafe WormMatch wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._SecondGeneticFTT_d__29.NativeFieldInfoPtr_wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._SecondGeneticFTT_d__29.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700132A RID: 4906
			// (get) Token: 0x06004DFF RID: 19967 RVA: 0x001A1278 File Offset: 0x0019F478
			// (set) Token: 0x06004E00 RID: 19968 RVA: 0x0001AE7A File Offset: 0x0001907A
			public unsafe WormMatch __3__wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._SecondGeneticFTT_d__29.NativeFieldInfoPtr___3__wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._SecondGeneticFTT_d__29.NativeFieldInfoPtr___3__wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700132B RID: 4907
			// (get) Token: 0x06004E01 RID: 19969 RVA: 0x001A12A8 File Offset: 0x0019F4A8
			// (set) Token: 0x06004E02 RID: 19970 RVA: 0x0001AE99 File Offset: 0x00019099
			public unsafe TutorialCampaignEmitter.__c__DisplayClass29_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._SecondGeneticFTT_d__29.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialCampaignEmitter.__c__DisplayClass29_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._SecondGeneticFTT_d__29.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003326 RID: 13094
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003327 RID: 13095
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003328 RID: 13096
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003329 RID: 13097
			private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

			// Token: 0x0400332A RID: 13098
			private static readonly IntPtr NativeFieldInfoPtr___3__wormMatch;

			// Token: 0x0400332B RID: 13099
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400332C RID: 13100
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400332D RID: 13101
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400332E RID: 13102
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400332F RID: 13103
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0;

			// Token: 0x04003330 RID: 13104
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003331 RID: 13105
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003332 RID: 13106
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0;

			// Token: 0x04003333 RID: 13107
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000613 RID: 1555
		[ObfuscatedName("worm.canis.data.Tutorial.FirstTime.TutorialCampaignEmitter+<SpecimenFTT>d__31")]
		public sealed class _SpecimenFTT_d__31 : Object
		{
			// Token: 0x06004E03 RID: 19971 RVA: 0x001A12D8 File Offset: 0x0019F4D8
			// Note: this type is marked as 'beforefieldinit'.
			static _SpecimenFTT_d__31()
			{
				Il2CppClassPointerStore<TutorialCampaignEmitter._SpecimenFTT_d__31>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, "<SpecimenFTT>d__31");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialCampaignEmitter._SpecimenFTT_d__31>.NativeClassPtr);
				TutorialCampaignEmitter._SpecimenFTT_d__31.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._SpecimenFTT_d__31>.NativeClassPtr, "<>1__state");
				TutorialCampaignEmitter._SpecimenFTT_d__31.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._SpecimenFTT_d__31>.NativeClassPtr, "<>2__current");
				TutorialCampaignEmitter._SpecimenFTT_d__31.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._SpecimenFTT_d__31>.NativeClassPtr, "<>l__initialThreadId");
				TutorialCampaignEmitter._SpecimenFTT_d__31.NativeFieldInfoPtr__hideArrow_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._SpecimenFTT_d__31>.NativeClassPtr, "<hideArrow>5__2");
				TutorialCampaignEmitter._SpecimenFTT_d__31.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._SpecimenFTT_d__31>.NativeClassPtr, 100665359);
				TutorialCampaignEmitter._SpecimenFTT_d__31.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._SpecimenFTT_d__31>.NativeClassPtr, 100665360);
				TutorialCampaignEmitter._SpecimenFTT_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._SpecimenFTT_d__31>.NativeClassPtr, 100665361);
				TutorialCampaignEmitter._SpecimenFTT_d__31.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._SpecimenFTT_d__31>.NativeClassPtr, 100665362);
				TutorialCampaignEmitter._SpecimenFTT_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._SpecimenFTT_d__31>.NativeClassPtr, 100665363);
				TutorialCampaignEmitter._SpecimenFTT_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._SpecimenFTT_d__31>.NativeClassPtr, 100665364);
				TutorialCampaignEmitter._SpecimenFTT_d__31.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._SpecimenFTT_d__31>.NativeClassPtr, 100665365);
				TutorialCampaignEmitter._SpecimenFTT_d__31.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._SpecimenFTT_d__31>.NativeClassPtr, 100665366);
			}

			// Token: 0x06004E04 RID: 19972 RVA: 0x001A13F4 File Offset: 0x0019F5F4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SpecimenFTT_d__31(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialCampaignEmitter._SpecimenFTT_d__31>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._SpecimenFTT_d__31.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004E05 RID: 19973 RVA: 0x001A143C File Offset: 0x0019F63C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._SpecimenFTT_d__31.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E06 RID: 19974 RVA: 0x001A1470 File Offset: 0x0019F670
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71701, XrefRangeEnd = 71824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._SpecimenFTT_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001332 RID: 4914
			// (get) Token: 0x06004E07 RID: 19975 RVA: 0x001A14AC File Offset: 0x0019F6AC
			public unsafe TutorialAction System.Collections.Generic.IEnumerator<Canis.tutorialScripts.TutorialAction>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._SpecimenFTT_d__31.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr3) : null;
				}
			}

			// Token: 0x06004E08 RID: 19976 RVA: 0x001A14EC File Offset: 0x0019F6EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71824, XrefRangeEnd = 71829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._SpecimenFTT_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001333 RID: 4915
			// (get) Token: 0x06004E09 RID: 19977 RVA: 0x001A1520 File Offset: 0x0019F720
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._SpecimenFTT_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004E0A RID: 19978 RVA: 0x001A1560 File Offset: 0x0019F760
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71829, XrefRangeEnd = 71831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TutorialAction> System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._SpecimenFTT_d__31.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TutorialAction>>(intPtr3) : null;
			}

			// Token: 0x06004E0B RID: 19979 RVA: 0x001A15A0 File Offset: 0x0019F7A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._SpecimenFTT_d__31.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06004E0C RID: 19980 RVA: 0x0001AEB8 File Offset: 0x000190B8
			public _SpecimenFTT_d__31(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700132E RID: 4910
			// (get) Token: 0x06004E0D RID: 19981 RVA: 0x001A15E0 File Offset: 0x0019F7E0
			// (set) Token: 0x06004E0E RID: 19982 RVA: 0x0001AEC1 File Offset: 0x000190C1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._SpecimenFTT_d__31.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._SpecimenFTT_d__31.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700132F RID: 4911
			// (get) Token: 0x06004E0F RID: 19983 RVA: 0x001A1608 File Offset: 0x0019F808
			// (set) Token: 0x06004E10 RID: 19984 RVA: 0x0001AEDC File Offset: 0x000190DC
			public unsafe TutorialAction __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._SpecimenFTT_d__31.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._SpecimenFTT_d__31.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001330 RID: 4912
			// (get) Token: 0x06004E11 RID: 19985 RVA: 0x001A1638 File Offset: 0x0019F838
			// (set) Token: 0x06004E12 RID: 19986 RVA: 0x0001AEFB File Offset: 0x000190FB
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._SpecimenFTT_d__31.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._SpecimenFTT_d__31.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001331 RID: 4913
			// (get) Token: 0x06004E13 RID: 19987 RVA: 0x001A1660 File Offset: 0x0019F860
			// (set) Token: 0x06004E14 RID: 19988 RVA: 0x0001AF16 File Offset: 0x00019116
			public unsafe WormTutorialAction _hideArrow_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._SpecimenFTT_d__31.NativeFieldInfoPtr__hideArrow_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTutorialAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._SpecimenFTT_d__31.NativeFieldInfoPtr__hideArrow_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003334 RID: 13108
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003335 RID: 13109
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003336 RID: 13110
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003337 RID: 13111
			private static readonly IntPtr NativeFieldInfoPtr__hideArrow_5__2;

			// Token: 0x04003338 RID: 13112
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003339 RID: 13113
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400333A RID: 13114
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400333B RID: 13115
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0;

			// Token: 0x0400333C RID: 13116
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400333D RID: 13117
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400333E RID: 13118
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0;

			// Token: 0x0400333F RID: 13119
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000614 RID: 1556
		[ObfuscatedName("worm.canis.data.Tutorial.FirstTime.TutorialCampaignEmitter+<TleilaxuFTT>d__33")]
		public sealed class _TleilaxuFTT_d__33 : Object
		{
			// Token: 0x06004E15 RID: 19989 RVA: 0x001A1690 File Offset: 0x0019F890
			// Note: this type is marked as 'beforefieldinit'.
			static _TleilaxuFTT_d__33()
			{
				Il2CppClassPointerStore<TutorialCampaignEmitter._TleilaxuFTT_d__33>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, "<TleilaxuFTT>d__33");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialCampaignEmitter._TleilaxuFTT_d__33>.NativeClassPtr);
				TutorialCampaignEmitter._TleilaxuFTT_d__33.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._TleilaxuFTT_d__33>.NativeClassPtr, "<>1__state");
				TutorialCampaignEmitter._TleilaxuFTT_d__33.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._TleilaxuFTT_d__33>.NativeClassPtr, "<>2__current");
				TutorialCampaignEmitter._TleilaxuFTT_d__33.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._TleilaxuFTT_d__33>.NativeClassPtr, "<>l__initialThreadId");
				TutorialCampaignEmitter._TleilaxuFTT_d__33.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._TleilaxuFTT_d__33>.NativeClassPtr, 100665367);
				TutorialCampaignEmitter._TleilaxuFTT_d__33.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._TleilaxuFTT_d__33>.NativeClassPtr, 100665368);
				TutorialCampaignEmitter._TleilaxuFTT_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._TleilaxuFTT_d__33>.NativeClassPtr, 100665369);
				TutorialCampaignEmitter._TleilaxuFTT_d__33.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._TleilaxuFTT_d__33>.NativeClassPtr, 100665370);
				TutorialCampaignEmitter._TleilaxuFTT_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._TleilaxuFTT_d__33>.NativeClassPtr, 100665371);
				TutorialCampaignEmitter._TleilaxuFTT_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._TleilaxuFTT_d__33>.NativeClassPtr, 100665372);
				TutorialCampaignEmitter._TleilaxuFTT_d__33.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._TleilaxuFTT_d__33>.NativeClassPtr, 100665373);
				TutorialCampaignEmitter._TleilaxuFTT_d__33.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._TleilaxuFTT_d__33>.NativeClassPtr, 100665374);
			}

			// Token: 0x06004E16 RID: 19990 RVA: 0x001A1798 File Offset: 0x0019F998
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _TleilaxuFTT_d__33(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialCampaignEmitter._TleilaxuFTT_d__33>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._TleilaxuFTT_d__33.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004E17 RID: 19991 RVA: 0x001A17E0 File Offset: 0x0019F9E0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._TleilaxuFTT_d__33.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E18 RID: 19992 RVA: 0x001A1814 File Offset: 0x0019FA14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71831, XrefRangeEnd = 71885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._TleilaxuFTT_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001337 RID: 4919
			// (get) Token: 0x06004E19 RID: 19993 RVA: 0x001A1850 File Offset: 0x0019FA50
			public unsafe TutorialAction System.Collections.Generic.IEnumerator<Canis.tutorialScripts.TutorialAction>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._TleilaxuFTT_d__33.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr3) : null;
				}
			}

			// Token: 0x06004E1A RID: 19994 RVA: 0x001A1890 File Offset: 0x0019FA90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71885, XrefRangeEnd = 71890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._TleilaxuFTT_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001338 RID: 4920
			// (get) Token: 0x06004E1B RID: 19995 RVA: 0x001A18C4 File Offset: 0x0019FAC4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._TleilaxuFTT_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004E1C RID: 19996 RVA: 0x001A1904 File Offset: 0x0019FB04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71890, XrefRangeEnd = 71892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TutorialAction> System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._TleilaxuFTT_d__33.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TutorialAction>>(intPtr3) : null;
			}

			// Token: 0x06004E1D RID: 19997 RVA: 0x001A1944 File Offset: 0x0019FB44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._TleilaxuFTT_d__33.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06004E1E RID: 19998 RVA: 0x0001AF35 File Offset: 0x00019135
			public _TleilaxuFTT_d__33(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001334 RID: 4916
			// (get) Token: 0x06004E1F RID: 19999 RVA: 0x001A1984 File Offset: 0x0019FB84
			// (set) Token: 0x06004E20 RID: 20000 RVA: 0x0001AF3E File Offset: 0x0001913E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._TleilaxuFTT_d__33.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._TleilaxuFTT_d__33.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001335 RID: 4917
			// (get) Token: 0x06004E21 RID: 20001 RVA: 0x001A19AC File Offset: 0x0019FBAC
			// (set) Token: 0x06004E22 RID: 20002 RVA: 0x0001AF59 File Offset: 0x00019159
			public unsafe TutorialAction __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._TleilaxuFTT_d__33.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._TleilaxuFTT_d__33.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001336 RID: 4918
			// (get) Token: 0x06004E23 RID: 20003 RVA: 0x001A19DC File Offset: 0x0019FBDC
			// (set) Token: 0x06004E24 RID: 20004 RVA: 0x0001AF78 File Offset: 0x00019178
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._TleilaxuFTT_d__33.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._TleilaxuFTT_d__33.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x04003340 RID: 13120
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003341 RID: 13121
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003342 RID: 13122
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003343 RID: 13123
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003344 RID: 13124
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003345 RID: 13125
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003346 RID: 13126
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0;

			// Token: 0x04003347 RID: 13127
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003348 RID: 13128
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003349 RID: 13129
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0;

			// Token: 0x0400334A RID: 13130
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000615 RID: 1557
		[ObfuscatedName("worm.canis.data.Tutorial.FirstTime.TutorialCampaignEmitter+<TrashingCardFTT>d__35")]
		public sealed class _TrashingCardFTT_d__35 : Object
		{
			// Token: 0x06004E25 RID: 20005 RVA: 0x001A1A04 File Offset: 0x0019FC04
			// Note: this type is marked as 'beforefieldinit'.
			static _TrashingCardFTT_d__35()
			{
				Il2CppClassPointerStore<TutorialCampaignEmitter._TrashingCardFTT_d__35>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialCampaignEmitter>.NativeClassPtr, "<TrashingCardFTT>d__35");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialCampaignEmitter._TrashingCardFTT_d__35>.NativeClassPtr);
				TutorialCampaignEmitter._TrashingCardFTT_d__35.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._TrashingCardFTT_d__35>.NativeClassPtr, "<>1__state");
				TutorialCampaignEmitter._TrashingCardFTT_d__35.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._TrashingCardFTT_d__35>.NativeClassPtr, "<>2__current");
				TutorialCampaignEmitter._TrashingCardFTT_d__35.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCampaignEmitter._TrashingCardFTT_d__35>.NativeClassPtr, "<>l__initialThreadId");
				TutorialCampaignEmitter._TrashingCardFTT_d__35.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._TrashingCardFTT_d__35>.NativeClassPtr, 100665375);
				TutorialCampaignEmitter._TrashingCardFTT_d__35.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._TrashingCardFTT_d__35>.NativeClassPtr, 100665376);
				TutorialCampaignEmitter._TrashingCardFTT_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._TrashingCardFTT_d__35>.NativeClassPtr, 100665377);
				TutorialCampaignEmitter._TrashingCardFTT_d__35.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._TrashingCardFTT_d__35>.NativeClassPtr, 100665378);
				TutorialCampaignEmitter._TrashingCardFTT_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._TrashingCardFTT_d__35>.NativeClassPtr, 100665379);
				TutorialCampaignEmitter._TrashingCardFTT_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._TrashingCardFTT_d__35>.NativeClassPtr, 100665380);
				TutorialCampaignEmitter._TrashingCardFTT_d__35.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._TrashingCardFTT_d__35>.NativeClassPtr, 100665381);
				TutorialCampaignEmitter._TrashingCardFTT_d__35.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCampaignEmitter._TrashingCardFTT_d__35>.NativeClassPtr, 100665382);
			}

			// Token: 0x06004E26 RID: 20006 RVA: 0x001A1B0C File Offset: 0x0019FD0C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _TrashingCardFTT_d__35(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialCampaignEmitter._TrashingCardFTT_d__35>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._TrashingCardFTT_d__35.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004E27 RID: 20007 RVA: 0x001A1B54 File Offset: 0x0019FD54
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._TrashingCardFTT_d__35.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E28 RID: 20008 RVA: 0x001A1B88 File Offset: 0x0019FD88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71892, XrefRangeEnd = 71897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._TrashingCardFTT_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700133C RID: 4924
			// (get) Token: 0x06004E29 RID: 20009 RVA: 0x001A1BC4 File Offset: 0x0019FDC4
			public unsafe TutorialAction System.Collections.Generic.IEnumerator<Canis.tutorialScripts.TutorialAction>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._TrashingCardFTT_d__35.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr3) : null;
				}
			}

			// Token: 0x06004E2A RID: 20010 RVA: 0x001A1C04 File Offset: 0x0019FE04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71897, XrefRangeEnd = 71902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._TrashingCardFTT_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700133D RID: 4925
			// (get) Token: 0x06004E2B RID: 20011 RVA: 0x001A1C38 File Offset: 0x0019FE38
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._TrashingCardFTT_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004E2C RID: 20012 RVA: 0x001A1C78 File Offset: 0x0019FE78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71902, XrefRangeEnd = 71904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TutorialAction> System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._TrashingCardFTT_d__35.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TutorialAction>>(intPtr3) : null;
			}

			// Token: 0x06004E2D RID: 20013 RVA: 0x001A1CB8 File Offset: 0x0019FEB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCampaignEmitter._TrashingCardFTT_d__35.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06004E2E RID: 20014 RVA: 0x0001AF93 File Offset: 0x00019193
			public _TrashingCardFTT_d__35(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001339 RID: 4921
			// (get) Token: 0x06004E2F RID: 20015 RVA: 0x001A1CF8 File Offset: 0x0019FEF8
			// (set) Token: 0x06004E30 RID: 20016 RVA: 0x0001AF9C File Offset: 0x0001919C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._TrashingCardFTT_d__35.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._TrashingCardFTT_d__35.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700133A RID: 4922
			// (get) Token: 0x06004E31 RID: 20017 RVA: 0x001A1D20 File Offset: 0x0019FF20
			// (set) Token: 0x06004E32 RID: 20018 RVA: 0x0001AFB7 File Offset: 0x000191B7
			public unsafe TutorialAction __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._TrashingCardFTT_d__35.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._TrashingCardFTT_d__35.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700133B RID: 4923
			// (get) Token: 0x06004E33 RID: 20019 RVA: 0x001A1D50 File Offset: 0x0019FF50
			// (set) Token: 0x06004E34 RID: 20020 RVA: 0x0001AFD6 File Offset: 0x000191D6
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._TrashingCardFTT_d__35.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCampaignEmitter._TrashingCardFTT_d__35.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x0400334B RID: 13131
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400334C RID: 13132
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400334D RID: 13133
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400334E RID: 13134
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400334F RID: 13135
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003350 RID: 13136
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003351 RID: 13137
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_tutorialScripts_TutorialAction__get_Current_Private_Virtual_Final_New_get_TutorialAction_0;

			// Token: 0x04003352 RID: 13138
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003353 RID: 13139
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003354 RID: 13140
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_tutorialScripts_TutorialAction__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TutorialAction_0;

			// Token: 0x04003355 RID: 13141
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
