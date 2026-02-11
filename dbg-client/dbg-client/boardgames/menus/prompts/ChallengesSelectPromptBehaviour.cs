using System;
using boardgames.data;
using boardgames.menus.commands;
using boardgames.utils;
using Canis;
using dwd.core.commands;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace boardgames.menus.prompts
{
	// Token: 0x020001C6 RID: 454
	public class ChallengesSelectPromptBehaviour : PromptBehaviour<ChallengesSelectPrompt>
	{
		// Token: 0x0600146D RID: 5229 RVA: 0x0005F834 File Offset: 0x0005DA34
		// Note: this type is marked as 'beforefieldinit'.
		static ChallengesSelectPromptBehaviour()
		{
			Il2CppClassPointerStore<ChallengesSelectPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "ChallengesSelectPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour>.NativeClassPtr);
			ChallengesSelectPromptBehaviour.NativeFieldInfoPtr_provider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour>.NativeClassPtr, "provider");
			ChallengesSelectPromptBehaviour.NativeFieldInfoPtr_challengeEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour>.NativeClassPtr, "challengeEntryPrefab");
			ChallengesSelectPromptBehaviour.NativeFieldInfoPtr_challengeEntryParentTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour>.NativeClassPtr, "challengeEntryParentTransform");
			ChallengesSelectPromptBehaviour.NativeFieldInfoPtr_activeScrollView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour>.NativeClassPtr, "activeScrollView");
			ChallengesSelectPromptBehaviour.NativeFieldInfoPtr__autoSelectChallenge_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour>.NativeClassPtr, "<autoSelectChallenge>k__BackingField");
			ChallengesSelectPromptBehaviour.NativeMethodInfoPtr_get_autoSelectChallenge_Protected_get_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour>.NativeClassPtr, 100666283);
			ChallengesSelectPromptBehaviour.NativeMethodInfoPtr_set_autoSelectChallenge_Private_set_Void_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour>.NativeClassPtr, 100666284);
			ChallengesSelectPromptBehaviour.NativeMethodInfoPtr_entryRoot_Protected_Virtual_New_RectTransform_ChallengeEntryMatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour>.NativeClassPtr, 100666285);
			ChallengesSelectPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour>.NativeClassPtr, 100666286);
			ChallengesSelectPromptBehaviour.NativeMethodInfoPtr_GetChallengeMatches_Protected_Virtual_New_List_1_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour>.NativeClassPtr, 100666287);
			ChallengesSelectPromptBehaviour.NativeMethodInfoPtr_createChallengePrefabs_Protected_Virtual_New_Void_Dictionary_2_String_List_1_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour>.NativeClassPtr, 100666288);
			ChallengesSelectPromptBehaviour.NativeMethodInfoPtr_createChallengePrefab_Protected_SubscriptionProvider_String_List_1_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour>.NativeClassPtr, 100666289);
			ChallengesSelectPromptBehaviour.NativeMethodInfoPtr_AutoSelectChallenge_Protected_Virtual_New_Void_SubscriptionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour>.NativeClassPtr, 100666290);
			ChallengesSelectPromptBehaviour.NativeMethodInfoPtr_scrollToChallenge_Protected_IEnumerator_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour>.NativeClassPtr, 100666291);
			ChallengesSelectPromptBehaviour.NativeMethodInfoPtr_Event_ScrollToSection_Protected_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour>.NativeClassPtr, 100666292);
			ChallengesSelectPromptBehaviour.NativeMethodInfoPtr_GetPromptDataProvider_Public_SubscriptionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour>.NativeClassPtr, 100666293);
			ChallengesSelectPromptBehaviour.NativeMethodInfoPtr_Event_Play_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour>.NativeClassPtr, 100666294);
			ChallengesSelectPromptBehaviour.NativeMethodInfoPtr_challengesByDifficulty_Private_Dictionary_2_ChallengeDifficulties_MatchInitData_List_1_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour>.NativeClassPtr, 100666295);
			ChallengesSelectPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour>.NativeClassPtr, 100666296);
			ChallengesSelectPromptBehaviour.NativeMethodInfoPtr__Event_Play_b__17_0_Private_IFailable_RunConfigureOfflineMatchFlow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour>.NativeClassPtr, 100666297);
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x0600146E RID: 5230 RVA: 0x0005F9F4 File Offset: 0x0005DBF4
		// (set) Token: 0x0600146F RID: 5231 RVA: 0x0005FA34 File Offset: 0x0005DC34
		public unsafe MatchInitData autoSelectChallenge
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengesSelectPromptBehaviour.NativeMethodInfoPtr_get_autoSelectChallenge_Protected_get_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MatchInitData>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengesSelectPromptBehaviour.NativeMethodInfoPtr_set_autoSelectChallenge_Private_set_Void_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x0005FA78 File Offset: 0x0005DC78
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual RectTransform entryRoot(ChallengeEntryMatchInitData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChallengesSelectPromptBehaviour.NativeMethodInfoPtr_entryRoot_Protected_Virtual_New_RectTransform_ChallengeEntryMatchInitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x0005FAD4 File Offset: 0x0005DCD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520423, XrefRangeEnd = 520555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChallengesSelectPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x0005FB10 File Offset: 0x0005DD10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520555, XrefRangeEnd = 520564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<MatchInitData> GetChallengeMatches()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChallengesSelectPromptBehaviour.NativeMethodInfoPtr_GetChallengeMatches_Protected_Virtual_New_List_1_MatchInitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<MatchInitData>>(intPtr3) : null;
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x0005FB5C File Offset: 0x0005DD5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520564, XrefRangeEnd = 520581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void createChallengePrefabs(Dictionary<string, List<MatchInitData>> groupedChallenges)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(groupedChallenges);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChallengesSelectPromptBehaviour.NativeMethodInfoPtr_createChallengePrefabs_Protected_Virtual_New_Void_Dictionary_2_String_List_1_MatchInitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001474 RID: 5236 RVA: 0x0005FBAC File Offset: 0x0005DDAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 520623, RefRangeEnd = 520624, XrefRangeStart = 520581, XrefRangeEnd = 520623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SubscriptionProvider createChallengePrefab(string challengeName, List<MatchInitData> matchInitDatas)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(challengeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(matchInitDatas);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengesSelectPromptBehaviour.NativeMethodInfoPtr_createChallengePrefab_Protected_SubscriptionProvider_String_List_1_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr3) : null;
		}

		// Token: 0x06001475 RID: 5237 RVA: 0x0005FC10 File Offset: 0x0005DE10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 520635, RefRangeEnd = 520636, XrefRangeStart = 520624, XrefRangeEnd = 520635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AutoSelectChallenge(SubscriptionProvider challengeEntryInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(challengeEntryInstance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChallengesSelectPromptBehaviour.NativeMethodInfoPtr_AutoSelectChallenge_Protected_Virtual_New_Void_SubscriptionProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x0005FC60 File Offset: 0x0005DE60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520636, XrefRangeEnd = 520642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator scrollToChallenge(RectTransform challengeTransform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(challengeTransform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengesSelectPromptBehaviour.NativeMethodInfoPtr_scrollToChallenge_Protected_IEnumerator_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x0005FCB0 File Offset: 0x0005DEB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520642, XrefRangeEnd = 520647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ScrollToSection(RectTransform sectionHeader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sectionHeader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengesSelectPromptBehaviour.NativeMethodInfoPtr_Event_ScrollToSection_Protected_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x0005FCF4 File Offset: 0x0005DEF4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SubscriptionProvider GetPromptDataProvider()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengesSelectPromptBehaviour.NativeMethodInfoPtr_GetPromptDataProvider_Public_SubscriptionProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr3) : null;
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x0005FD34 File Offset: 0x0005DF34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520647, XrefRangeEnd = 520680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Event_Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChallengesSelectPromptBehaviour.NativeMethodInfoPtr_Event_Play_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600147A RID: 5242 RVA: 0x0005FD70 File Offset: 0x0005DF70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 520733, RefRangeEnd = 520734, XrefRangeStart = 520680, XrefRangeEnd = 520733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<DBGConstants.ChallengeDifficulties, MatchInitData> challengesByDifficulty(List<MatchInitData> challenges)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(challenges);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengesSelectPromptBehaviour.NativeMethodInfoPtr_challengesByDifficulty_Private_Dictionary_2_ChallengeDifficulties_MatchInitData_List_1_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<DBGConstants.ChallengeDifficulties, MatchInitData>>(intPtr3) : null;
			}
		}

		// Token: 0x0600147B RID: 5243 RVA: 0x0005FDC0 File Offset: 0x0005DFC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 520737, RefRangeEnd = 520738, XrefRangeStart = 520734, XrefRangeEnd = 520737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChallengesSelectPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengesSelectPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x0005FDFC File Offset: 0x0005DFFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520738, XrefRangeEnd = 520748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IFailable _Event_Play_b__17_0(RunConfigureOfflineMatchFlow _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengesSelectPromptBehaviour.NativeMethodInfoPtr__Event_Play_b__17_0_Private_IFailable_RunConfigureOfflineMatchFlow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
			}
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x0000B9A5 File Offset: 0x00009BA5
		public ChallengesSelectPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x0600147E RID: 5246 RVA: 0x0005FE4C File Offset: 0x0005E04C
		// (set) Token: 0x0600147F RID: 5247 RVA: 0x0000B9AE File Offset: 0x00009BAE
		public unsafe SubscriptionProvider provider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengesSelectPromptBehaviour.NativeFieldInfoPtr_provider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengesSelectPromptBehaviour.NativeFieldInfoPtr_provider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06001480 RID: 5248 RVA: 0x0005FE7C File Offset: 0x0005E07C
		// (set) Token: 0x06001481 RID: 5249 RVA: 0x0000B9CD File Offset: 0x00009BCD
		public unsafe SubscriptionProvider challengeEntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengesSelectPromptBehaviour.NativeFieldInfoPtr_challengeEntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengesSelectPromptBehaviour.NativeFieldInfoPtr_challengeEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06001482 RID: 5250 RVA: 0x0005FEAC File Offset: 0x0005E0AC
		// (set) Token: 0x06001483 RID: 5251 RVA: 0x0000B9EC File Offset: 0x00009BEC
		public unsafe RectTransform challengeEntryParentTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengesSelectPromptBehaviour.NativeFieldInfoPtr_challengeEntryParentTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengesSelectPromptBehaviour.NativeFieldInfoPtr_challengeEntryParentTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06001484 RID: 5252 RVA: 0x0005FEDC File Offset: 0x0005E0DC
		// (set) Token: 0x06001485 RID: 5253 RVA: 0x0000BA0B File Offset: 0x00009C0B
		public unsafe ScrollRect activeScrollView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengesSelectPromptBehaviour.NativeFieldInfoPtr_activeScrollView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengesSelectPromptBehaviour.NativeFieldInfoPtr_activeScrollView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06001486 RID: 5254 RVA: 0x0005FF0C File Offset: 0x0005E10C
		// (set) Token: 0x06001487 RID: 5255 RVA: 0x0000BA2A File Offset: 0x00009C2A
		public unsafe MatchInitData _autoSelectChallenge_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengesSelectPromptBehaviour.NativeFieldInfoPtr__autoSelectChallenge_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MatchInitData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengesSelectPromptBehaviour.NativeFieldInfoPtr__autoSelectChallenge_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CA0 RID: 3232
		private static readonly IntPtr NativeFieldInfoPtr_provider;

		// Token: 0x04000CA1 RID: 3233
		private static readonly IntPtr NativeFieldInfoPtr_challengeEntryPrefab;

		// Token: 0x04000CA2 RID: 3234
		private static readonly IntPtr NativeFieldInfoPtr_challengeEntryParentTransform;

		// Token: 0x04000CA3 RID: 3235
		private static readonly IntPtr NativeFieldInfoPtr_activeScrollView;

		// Token: 0x04000CA4 RID: 3236
		private static readonly IntPtr NativeFieldInfoPtr__autoSelectChallenge_k__BackingField;

		// Token: 0x04000CA5 RID: 3237
		private static readonly IntPtr NativeMethodInfoPtr_get_autoSelectChallenge_Protected_get_MatchInitData_0;

		// Token: 0x04000CA6 RID: 3238
		private static readonly IntPtr NativeMethodInfoPtr_set_autoSelectChallenge_Private_set_Void_MatchInitData_0;

		// Token: 0x04000CA7 RID: 3239
		private static readonly IntPtr NativeMethodInfoPtr_entryRoot_Protected_Virtual_New_RectTransform_ChallengeEntryMatchInitData_0;

		// Token: 0x04000CA8 RID: 3240
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x04000CA9 RID: 3241
		private static readonly IntPtr NativeMethodInfoPtr_GetChallengeMatches_Protected_Virtual_New_List_1_MatchInitData_0;

		// Token: 0x04000CAA RID: 3242
		private static readonly IntPtr NativeMethodInfoPtr_createChallengePrefabs_Protected_Virtual_New_Void_Dictionary_2_String_List_1_MatchInitData_0;

		// Token: 0x04000CAB RID: 3243
		private static readonly IntPtr NativeMethodInfoPtr_createChallengePrefab_Protected_SubscriptionProvider_String_List_1_MatchInitData_0;

		// Token: 0x04000CAC RID: 3244
		private static readonly IntPtr NativeMethodInfoPtr_AutoSelectChallenge_Protected_Virtual_New_Void_SubscriptionProvider_0;

		// Token: 0x04000CAD RID: 3245
		private static readonly IntPtr NativeMethodInfoPtr_scrollToChallenge_Protected_IEnumerator_RectTransform_0;

		// Token: 0x04000CAE RID: 3246
		private static readonly IntPtr NativeMethodInfoPtr_Event_ScrollToSection_Protected_Void_RectTransform_0;

		// Token: 0x04000CAF RID: 3247
		private static readonly IntPtr NativeMethodInfoPtr_GetPromptDataProvider_Public_SubscriptionProvider_0;

		// Token: 0x04000CB0 RID: 3248
		private static readonly IntPtr NativeMethodInfoPtr_Event_Play_Public_Virtual_New_Void_0;

		// Token: 0x04000CB1 RID: 3249
		private static readonly IntPtr NativeMethodInfoPtr_challengesByDifficulty_Private_Dictionary_2_ChallengeDifficulties_MatchInitData_List_1_MatchInitData_0;

		// Token: 0x04000CB2 RID: 3250
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000CB3 RID: 3251
		private static readonly IntPtr NativeMethodInfoPtr__Event_Play_b__17_0_Private_IFailable_RunConfigureOfflineMatchFlow_0;

		// Token: 0x020003AF RID: 943
		[ObfuscatedName("boardgames.menus.prompts.ChallengesSelectPromptBehaviour+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06002C24 RID: 11300 RVA: 0x000AC6D4 File Offset: 0x000AA8D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ChallengesSelectPromptBehaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour.__c>.NativeClassPtr);
				ChallengesSelectPromptBehaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour.__c>.NativeClassPtr, "<>9");
				ChallengesSelectPromptBehaviour.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour.__c>.NativeClassPtr, "<>9__9_0");
				ChallengesSelectPromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour.__c>.NativeClassPtr, 100666299);
				ChallengesSelectPromptBehaviour.__c.NativeMethodInfoPtr__initialize_b__9_0_Internal_Boolean_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour.__c>.NativeClassPtr, 100666300);
			}

			// Token: 0x06002C25 RID: 11301 RVA: 0x000AC750 File Offset: 0x000AA950
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengesSelectPromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C26 RID: 11302 RVA: 0x000AC78C File Offset: 0x000AA98C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520365, XrefRangeEnd = 520366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _initialize_b__9_0(MatchInitData m)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengesSelectPromptBehaviour.__c.NativeMethodInfoPtr__initialize_b__9_0_Internal_Boolean_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002C27 RID: 11303 RVA: 0x00016DA8 File Offset: 0x00014FA8
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C87 RID: 3207
			// (get) Token: 0x06002C28 RID: 11304 RVA: 0x000AC7DC File Offset: 0x000AA9DC
			// (set) Token: 0x06002C29 RID: 11305 RVA: 0x00016DB1 File Offset: 0x00014FB1
			public unsafe static ChallengesSelectPromptBehaviour.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ChallengesSelectPromptBehaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChallengesSelectPromptBehaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ChallengesSelectPromptBehaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C88 RID: 3208
			// (get) Token: 0x06002C2A RID: 11306 RVA: 0x000AC804 File Offset: 0x000AAA04
			// (set) Token: 0x06002C2B RID: 11307 RVA: 0x00016DC3 File Offset: 0x00014FC3
			public unsafe static Func<MatchInitData, bool> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ChallengesSelectPromptBehaviour.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MatchInitData, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ChallengesSelectPromptBehaviour.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B75 RID: 7029
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001B76 RID: 7030
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04001B77 RID: 7031
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001B78 RID: 7032
			private static readonly IntPtr NativeMethodInfoPtr__initialize_b__9_0_Internal_Boolean_MatchInitData_0;
		}

		// Token: 0x020003B0 RID: 944
		[ObfuscatedName("boardgames.menus.prompts.ChallengesSelectPromptBehaviour+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002C2C RID: 11308 RVA: 0x000AC82C File Offset: 0x000AAA2C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<ChallengesSelectPromptBehaviour.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour.__c__DisplayClass9_0>.NativeClassPtr);
				ChallengesSelectPromptBehaviour.__c__DisplayClass9_0.NativeFieldInfoPtr_previousChallenge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour.__c__DisplayClass9_0>.NativeClassPtr, "previousChallenge");
				ChallengesSelectPromptBehaviour.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour.__c__DisplayClass9_0>.NativeClassPtr, 100666301);
				ChallengesSelectPromptBehaviour.__c__DisplayClass9_0.NativeMethodInfoPtr__initialize_b__1_Internal_Boolean_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour.__c__DisplayClass9_0>.NativeClassPtr, 100666302);
			}

			// Token: 0x06002C2D RID: 11309 RVA: 0x000AC894 File Offset: 0x000AAA94
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengesSelectPromptBehaviour.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C2E RID: 11310 RVA: 0x000AC8D0 File Offset: 0x000AAAD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520366, XrefRangeEnd = 520410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _initialize_b__1(MatchInitData m)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengesSelectPromptBehaviour.__c__DisplayClass9_0.NativeMethodInfoPtr__initialize_b__1_Internal_Boolean_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002C2F RID: 11311 RVA: 0x00016DD5 File Offset: 0x00014FD5
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C89 RID: 3209
			// (get) Token: 0x06002C30 RID: 11312 RVA: 0x000AC920 File Offset: 0x000AAB20
			// (set) Token: 0x06002C31 RID: 11313 RVA: 0x00016DDE File Offset: 0x00014FDE
			public unsafe string previousChallenge
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengesSelectPromptBehaviour.__c__DisplayClass9_0.NativeFieldInfoPtr_previousChallenge);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengesSelectPromptBehaviour.__c__DisplayClass9_0.NativeFieldInfoPtr_previousChallenge), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04001B79 RID: 7033
			private static readonly IntPtr NativeFieldInfoPtr_previousChallenge;

			// Token: 0x04001B7A RID: 7034
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001B7B RID: 7035
			private static readonly IntPtr NativeMethodInfoPtr__initialize_b__1_Internal_Boolean_MatchInitData_0;
		}

		// Token: 0x020003B1 RID: 945
		[ObfuscatedName("boardgames.menus.prompts.ChallengesSelectPromptBehaviour+<>c__DisplayClass9_1")]
		public sealed class __c__DisplayClass9_1 : global::Il2CppSystem.Object
		{
			// Token: 0x06002C32 RID: 11314 RVA: 0x000AC948 File Offset: 0x000AAB48
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_1()
			{
				Il2CppClassPointerStore<ChallengesSelectPromptBehaviour.__c__DisplayClass9_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass9_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour.__c__DisplayClass9_1>.NativeClassPtr);
				ChallengesSelectPromptBehaviour.__c__DisplayClass9_1.NativeFieldInfoPtr_previousChallengeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour.__c__DisplayClass9_1>.NativeClassPtr, "previousChallengeData");
				ChallengesSelectPromptBehaviour.__c__DisplayClass9_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour.__c__DisplayClass9_1>.NativeClassPtr, 100666303);
				ChallengesSelectPromptBehaviour.__c__DisplayClass9_1.NativeMethodInfoPtr_Method_Internal_Boolean_MatchInitData_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour.__c__DisplayClass9_1>.NativeClassPtr, 100666304);
			}

			// Token: 0x06002C33 RID: 11315 RVA: 0x000AC9B0 File Offset: 0x000AABB0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour.__c__DisplayClass9_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengesSelectPromptBehaviour.__c__DisplayClass9_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C34 RID: 11316 RVA: 0x000AC9EC File Offset: 0x000AABEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520410, XrefRangeEnd = 520412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Method_Internal_Boolean_MatchInitData_PDM_0(MatchInitData m)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengesSelectPromptBehaviour.__c__DisplayClass9_1.NativeMethodInfoPtr_Method_Internal_Boolean_MatchInitData_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002C35 RID: 11317 RVA: 0x00016DFD File Offset: 0x00014FFD
			public __c__DisplayClass9_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C8A RID: 3210
			// (get) Token: 0x06002C36 RID: 11318 RVA: 0x000ACA3C File Offset: 0x000AAC3C
			// (set) Token: 0x06002C37 RID: 11319 RVA: 0x00016E06 File Offset: 0x00015006
			public unsafe MatchInitData previousChallengeData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengesSelectPromptBehaviour.__c__DisplayClass9_1.NativeFieldInfoPtr_previousChallengeData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MatchInitData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengesSelectPromptBehaviour.__c__DisplayClass9_1.NativeFieldInfoPtr_previousChallengeData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B7C RID: 7036
			private static readonly IntPtr NativeFieldInfoPtr_previousChallengeData;

			// Token: 0x04001B7D RID: 7037
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001B7E RID: 7038
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Boolean_MatchInitData_PDM_0;
		}

		// Token: 0x020003B2 RID: 946
		[ObfuscatedName("boardgames.menus.prompts.ChallengesSelectPromptBehaviour+<scrollToChallenge>d__14")]
		public sealed class _scrollToChallenge_d__14 : global::Il2CppSystem.Object
		{
			// Token: 0x06002C38 RID: 11320 RVA: 0x000ACA6C File Offset: 0x000AAC6C
			// Note: this type is marked as 'beforefieldinit'.
			static _scrollToChallenge_d__14()
			{
				Il2CppClassPointerStore<ChallengesSelectPromptBehaviour._scrollToChallenge_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour>.NativeClassPtr, "<scrollToChallenge>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour._scrollToChallenge_d__14>.NativeClassPtr);
				ChallengesSelectPromptBehaviour._scrollToChallenge_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour._scrollToChallenge_d__14>.NativeClassPtr, "<>1__state");
				ChallengesSelectPromptBehaviour._scrollToChallenge_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour._scrollToChallenge_d__14>.NativeClassPtr, "<>2__current");
				ChallengesSelectPromptBehaviour._scrollToChallenge_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour._scrollToChallenge_d__14>.NativeClassPtr, "<>4__this");
				ChallengesSelectPromptBehaviour._scrollToChallenge_d__14.NativeFieldInfoPtr_challengeTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour._scrollToChallenge_d__14>.NativeClassPtr, "challengeTransform");
				ChallengesSelectPromptBehaviour._scrollToChallenge_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour._scrollToChallenge_d__14>.NativeClassPtr, 100666305);
				ChallengesSelectPromptBehaviour._scrollToChallenge_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour._scrollToChallenge_d__14>.NativeClassPtr, 100666306);
				ChallengesSelectPromptBehaviour._scrollToChallenge_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour._scrollToChallenge_d__14>.NativeClassPtr, 100666307);
				ChallengesSelectPromptBehaviour._scrollToChallenge_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour._scrollToChallenge_d__14>.NativeClassPtr, 100666308);
				ChallengesSelectPromptBehaviour._scrollToChallenge_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour._scrollToChallenge_d__14>.NativeClassPtr, 100666309);
				ChallengesSelectPromptBehaviour._scrollToChallenge_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour._scrollToChallenge_d__14>.NativeClassPtr, 100666310);
			}

			// Token: 0x06002C39 RID: 11321 RVA: 0x000ACB60 File Offset: 0x000AAD60
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _scrollToChallenge_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengesSelectPromptBehaviour._scrollToChallenge_d__14>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengesSelectPromptBehaviour._scrollToChallenge_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002C3A RID: 11322 RVA: 0x000ACBA8 File Offset: 0x000AADA8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengesSelectPromptBehaviour._scrollToChallenge_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C3B RID: 11323 RVA: 0x000ACBDC File Offset: 0x000AADDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520412, XrefRangeEnd = 520418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengesSelectPromptBehaviour._scrollToChallenge_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000C8F RID: 3215
			// (get) Token: 0x06002C3C RID: 11324 RVA: 0x000ACC18 File Offset: 0x000AAE18
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengesSelectPromptBehaviour._scrollToChallenge_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002C3D RID: 11325 RVA: 0x000ACC58 File Offset: 0x000AAE58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520418, XrefRangeEnd = 520423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengesSelectPromptBehaviour._scrollToChallenge_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000C90 RID: 3216
			// (get) Token: 0x06002C3E RID: 11326 RVA: 0x000ACC8C File Offset: 0x000AAE8C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengesSelectPromptBehaviour._scrollToChallenge_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002C3F RID: 11327 RVA: 0x00016E25 File Offset: 0x00015025
			public _scrollToChallenge_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C8B RID: 3211
			// (get) Token: 0x06002C40 RID: 11328 RVA: 0x000ACCCC File Offset: 0x000AAECC
			// (set) Token: 0x06002C41 RID: 11329 RVA: 0x00016E2E File Offset: 0x0001502E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengesSelectPromptBehaviour._scrollToChallenge_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengesSelectPromptBehaviour._scrollToChallenge_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000C8C RID: 3212
			// (get) Token: 0x06002C42 RID: 11330 RVA: 0x000ACCF4 File Offset: 0x000AAEF4
			// (set) Token: 0x06002C43 RID: 11331 RVA: 0x00016E49 File Offset: 0x00015049
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengesSelectPromptBehaviour._scrollToChallenge_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengesSelectPromptBehaviour._scrollToChallenge_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C8D RID: 3213
			// (get) Token: 0x06002C44 RID: 11332 RVA: 0x000ACD24 File Offset: 0x000AAF24
			// (set) Token: 0x06002C45 RID: 11333 RVA: 0x00016E68 File Offset: 0x00015068
			public unsafe ChallengesSelectPromptBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengesSelectPromptBehaviour._scrollToChallenge_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChallengesSelectPromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengesSelectPromptBehaviour._scrollToChallenge_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C8E RID: 3214
			// (get) Token: 0x06002C46 RID: 11334 RVA: 0x000ACD54 File Offset: 0x000AAF54
			// (set) Token: 0x06002C47 RID: 11335 RVA: 0x00016E87 File Offset: 0x00015087
			public unsafe RectTransform challengeTransform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengesSelectPromptBehaviour._scrollToChallenge_d__14.NativeFieldInfoPtr_challengeTransform);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengesSelectPromptBehaviour._scrollToChallenge_d__14.NativeFieldInfoPtr_challengeTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B7F RID: 7039
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001B80 RID: 7040
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001B81 RID: 7041
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001B82 RID: 7042
			private static readonly IntPtr NativeFieldInfoPtr_challengeTransform;

			// Token: 0x04001B83 RID: 7043
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001B84 RID: 7044
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B85 RID: 7045
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001B86 RID: 7046
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001B87 RID: 7047
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B88 RID: 7048
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
