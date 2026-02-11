using System;
using boardgames.data;
using boardgames.menus.prompts;
using Canis.messages;
using Canis.utils.ids;
using dwd.core.platform.websocket.incoming;
using dwd.core.settings;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;
using worm.canis.data.enums;
using worm.canis.data.Skirmish.RulesModifiers;
using worm.match.data;

// Token: 0x02000020 RID: 32
public class WormConfigureGamePromptBehaviour : ConfigureGamePromptBehaviour
{
	// Token: 0x0600013B RID: 315 RVA: 0x0001C994 File Offset: 0x0001AB94
	// Note: this type is marked as 'beforefieldinit'.
	static WormConfigureGamePromptBehaviour()
	{
		Il2CppClassPointerStore<WormConfigureGamePromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "", "WormConfigureGamePromptBehaviour");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConfigureGamePromptBehaviour>.NativeClassPtr);
		WormConfigureGamePromptBehaviour.NativeFieldInfoPtr_colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConfigureGamePromptBehaviour>.NativeClassPtr, "colors");
		WormConfigureGamePromptBehaviour.NativeFieldInfoPtr_passwordInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConfigureGamePromptBehaviour>.NativeClassPtr, "passwordInputField");
		WormConfigureGamePromptBehaviour.NativeFieldInfoPtr_hagalAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConfigureGamePromptBehaviour>.NativeClassPtr, "hagalAnimator");
		WormConfigureGamePromptBehaviour.NativeFieldInfoPtr_HagalAnimatorValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConfigureGamePromptBehaviour>.NativeClassPtr, "HagalAnimatorValue");
		WormConfigureGamePromptBehaviour.NativeFieldInfoPtr_aiColorsDisabledData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConfigureGamePromptBehaviour>.NativeClassPtr, "aiColorsDisabledData");
		WormConfigureGamePromptBehaviour.NativeFieldInfoPtr_startingRuleModifierAbilityIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConfigureGamePromptBehaviour>.NativeClassPtr, "startingRuleModifierAbilityIDs");
		WormConfigureGamePromptBehaviour.NativeFieldInfoPtr_preferredLeaderArchetypeIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConfigureGamePromptBehaviour>.NativeClassPtr, "preferredLeaderArchetypeIDs");
		WormConfigureGamePromptBehaviour.NativeFieldInfoPtr_skirmishRuleModID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConfigureGamePromptBehaviour>.NativeClassPtr, "skirmishRuleModID");
		WormConfigureGamePromptBehaviour.NativeFieldInfoPtr_skirmishScoreIDList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConfigureGamePromptBehaviour>.NativeClassPtr, "skirmishScoreIDList");
		WormConfigureGamePromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureGamePromptBehaviour>.NativeClassPtr, 100663492);
		WormConfigureGamePromptBehaviour.NativeMethodInfoPtr_LoadPlayerType_Private_Void_SubscriptionProvider_PlayerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureGamePromptBehaviour>.NativeClassPtr, 100663493);
		WormConfigureGamePromptBehaviour.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureGamePromptBehaviour>.NativeClassPtr, 100663494);
		WormConfigureGamePromptBehaviour.NativeMethodInfoPtr_Event_CreateGame_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureGamePromptBehaviour>.NativeClassPtr, 100663495);
		WormConfigureGamePromptBehaviour.NativeMethodInfoPtr_LoadPlayerTypeFromPref_Private_Void_SubscriptionProvider_ISettingDefinition_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureGamePromptBehaviour>.NativeClassPtr, 100663496);
		WormConfigureGamePromptBehaviour.NativeMethodInfoPtr_SavePlayerTypePref_Private_Static_Void_SubscriptionProvider_IWritableSetting_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureGamePromptBehaviour>.NativeClassPtr, 100663497);
		WormConfigureGamePromptBehaviour.NativeMethodInfoPtr_Event_IncrementDifficulty_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureGamePromptBehaviour>.NativeClassPtr, 100663498);
		WormConfigureGamePromptBehaviour.NativeMethodInfoPtr_UpdateDifficultyState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureGamePromptBehaviour>.NativeClassPtr, 100663499);
		WormConfigureGamePromptBehaviour.NativeMethodInfoPtr_Event_IncrementAIType_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureGamePromptBehaviour>.NativeClassPtr, 100663500);
		WormConfigureGamePromptBehaviour.NativeMethodInfoPtr_UpdateAITypeState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureGamePromptBehaviour>.NativeClassPtr, 100663501);
		WormConfigureGamePromptBehaviour.NativeMethodInfoPtr_IsHagalType_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureGamePromptBehaviour>.NativeClassPtr, 100663502);
		WormConfigureGamePromptBehaviour.NativeMethodInfoPtr_Event_IncrementDraftType_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureGamePromptBehaviour>.NativeClassPtr, 100663503);
		WormConfigureGamePromptBehaviour.NativeMethodInfoPtr_Event_IncrementTurnTimers_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureGamePromptBehaviour>.NativeClassPtr, 100663504);
		WormConfigureGamePromptBehaviour.NativeMethodInfoPtr_UpdateExpansionOptionsState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureGamePromptBehaviour>.NativeClassPtr, 100663505);
		WormConfigureGamePromptBehaviour.NativeMethodInfoPtr_IsVariantAllowed_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureGamePromptBehaviour>.NativeClassPtr, 100663506);
		WormConfigureGamePromptBehaviour.NativeMethodInfoPtr_UpdateTurnTimerState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureGamePromptBehaviour>.NativeClassPtr, 100663507);
		WormConfigureGamePromptBehaviour.NativeMethodInfoPtr_AddToRuleModifiers_Public_Void_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureGamePromptBehaviour>.NativeClassPtr, 100663508);
		WormConfigureGamePromptBehaviour.NativeMethodInfoPtr_SetSkirmishRuleModID_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureGamePromptBehaviour>.NativeClassPtr, 100663509);
		WormConfigureGamePromptBehaviour.NativeMethodInfoPtr_AddToPreferredLeaders_Public_Void_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureGamePromptBehaviour>.NativeClassPtr, 100663510);
		WormConfigureGamePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureGamePromptBehaviour>.NativeClassPtr, 100663511);
		WormConfigureGamePromptBehaviour.NativeMethodInfoPtr__Event_CreateGame_b__12_0_Private_Boolean_Set_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureGamePromptBehaviour>.NativeClassPtr, 100663513);
		WormConfigureGamePromptBehaviour.NativeMethodInfoPtr__Event_CreateGame_b__12_1_Private_Boolean_RulesModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureGamePromptBehaviour>.NativeClassPtr, 100663514);
	}

	// Token: 0x0600013C RID: 316 RVA: 0x0001CC30 File Offset: 0x0001AE30
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 688278, XrefRangeEnd = 688345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormConfigureGamePromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600013D RID: 317 RVA: 0x0001CC6C File Offset: 0x0001AE6C
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 688363, RefRangeEnd = 688371, XrefRangeStart = 688345, XrefRangeEnd = 688363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadPlayerType(SubscriptionProvider playerSlot, PlayerTypeData.PlayerType playerType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerSlot);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerType;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureGamePromptBehaviour.NativeMethodInfoPtr_LoadPlayerType_Private_Void_SubscriptionProvider_PlayerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600013E RID: 318 RVA: 0x0001CCBC File Offset: 0x0001AEBC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 688371, XrefRangeEnd = 688398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormConfigureGamePromptBehaviour.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600013F RID: 319 RVA: 0x0001CCF8 File Offset: 0x0001AEF8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 688398, XrefRangeEnd = 688672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Event_CreateGame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormConfigureGamePromptBehaviour.NativeMethodInfoPtr_Event_CreateGame_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000140 RID: 320 RVA: 0x0001CD34 File Offset: 0x0001AF34
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 688672, XrefRangeEnd = 688680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadPlayerTypeFromPref(SubscriptionProvider playerSlot, ISettingDefinition<int> playerTypePref)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerSlot);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerTypePref);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureGamePromptBehaviour.NativeMethodInfoPtr_LoadPlayerTypeFromPref_Private_Void_SubscriptionProvider_ISettingDefinition_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000141 RID: 321 RVA: 0x0001CD88 File Offset: 0x0001AF88
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 688680, XrefRangeEnd = 688687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SavePlayerTypePref(SubscriptionProvider playerSlot, IWritableSetting<int> playerTypePref)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerSlot);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerTypePref);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureGamePromptBehaviour.NativeMethodInfoPtr_SavePlayerTypePref_Private_Static_Void_SubscriptionProvider_IWritableSetting_1_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000142 RID: 322 RVA: 0x0001CDD0 File Offset: 0x0001AFD0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 688687, XrefRangeEnd = 688693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Event_IncrementDifficulty(int direction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref direction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureGamePromptBehaviour.NativeMethodInfoPtr_Event_IncrementDifficulty_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000143 RID: 323 RVA: 0x0001CE10 File Offset: 0x0001B010
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 688706, RefRangeEnd = 688708, XrefRangeStart = 688693, XrefRangeEnd = 688706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateDifficultyState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureGamePromptBehaviour.NativeMethodInfoPtr_UpdateDifficultyState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000144 RID: 324 RVA: 0x0001CE44 File Offset: 0x0001B044
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 688708, XrefRangeEnd = 688715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Event_IncrementAIType(int direction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref direction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureGamePromptBehaviour.NativeMethodInfoPtr_Event_IncrementAIType_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000145 RID: 325 RVA: 0x0001CE84 File Offset: 0x0001B084
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 688779, RefRangeEnd = 688781, XrefRangeStart = 688715, XrefRangeEnd = 688779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateAITypeState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureGamePromptBehaviour.NativeMethodInfoPtr_UpdateAITypeState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000146 RID: 326 RVA: 0x0001CEB8 File Offset: 0x0001B0B8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 688786, RefRangeEnd = 688788, XrefRangeStart = 688781, XrefRangeEnd = 688786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsHagalType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureGamePromptBehaviour.NativeMethodInfoPtr_IsHagalType_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000147 RID: 327 RVA: 0x0001CEF4 File Offset: 0x0001B0F4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 688788, XrefRangeEnd = 688793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Event_IncrementDraftType(int direction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref direction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureGamePromptBehaviour.NativeMethodInfoPtr_Event_IncrementDraftType_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000148 RID: 328 RVA: 0x0001CF34 File Offset: 0x0001B134
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 688793, XrefRangeEnd = 688799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Event_IncrementTurnTimers(int direction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref direction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureGamePromptBehaviour.NativeMethodInfoPtr_Event_IncrementTurnTimers_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000149 RID: 329 RVA: 0x0001CF74 File Offset: 0x0001B174
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 688807, RefRangeEnd = 688809, XrefRangeStart = 688799, XrefRangeEnd = 688807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateExpansionOptionsState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureGamePromptBehaviour.NativeMethodInfoPtr_UpdateExpansionOptionsState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600014A RID: 330 RVA: 0x0001CFA8 File Offset: 0x0001B1A8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 688828, RefRangeEnd = 688830, XrefRangeStart = 688809, XrefRangeEnd = 688828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsVariantAllowed(string variant)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(variant);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureGamePromptBehaviour.NativeMethodInfoPtr_IsVariantAllowed_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600014B RID: 331 RVA: 0x0001CFF8 File Offset: 0x0001B1F8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 688863, RefRangeEnd = 688865, XrefRangeStart = 688830, XrefRangeEnd = 688863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateTurnTimerState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureGamePromptBehaviour.NativeMethodInfoPtr_UpdateTurnTimerState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600014C RID: 332 RVA: 0x0001D02C File Offset: 0x0001B22C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 688865, XrefRangeEnd = 688871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddToRuleModifiers(AbilityID id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureGamePromptBehaviour.NativeMethodInfoPtr_AddToRuleModifiers_Public_Void_AbilityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600014D RID: 333 RVA: 0x0001D070 File Offset: 0x0001B270
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 688871, XrefRangeEnd = 688880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSkirmishRuleModID(int ruleID, int scoreA, int scoreB)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref ruleID;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scoreA;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scoreB;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureGamePromptBehaviour.NativeMethodInfoPtr_SetSkirmishRuleModID_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600014E RID: 334 RVA: 0x0001D0CC File Offset: 0x0001B2CC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 688880, XrefRangeEnd = 688886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddToPreferredLeaders(ArchetypeID leaderArchID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(leaderArchID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureGamePromptBehaviour.NativeMethodInfoPtr_AddToPreferredLeaders_Public_Void_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600014F RID: 335 RVA: 0x0001D110 File Offset: 0x0001B310
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 688886, XrefRangeEnd = 688908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WormConfigureGamePromptBehaviour()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConfigureGamePromptBehaviour>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureGamePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000150 RID: 336 RVA: 0x0001D14C File Offset: 0x0001B34C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 688908, XrefRangeEnd = 688914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool _Event_CreateGame_b__12_0(Set s)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref s;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureGamePromptBehaviour.NativeMethodInfoPtr__Event_CreateGame_b__12_0_Private_Boolean_Set_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000151 RID: 337 RVA: 0x0001D198 File Offset: 0x0001B398
	[CallerCount(0)]
	public unsafe bool _Event_CreateGame_b__12_1(RulesModifier m)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureGamePromptBehaviour.NativeMethodInfoPtr__Event_CreateGame_b__12_1_Private_Boolean_RulesModifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000152 RID: 338 RVA: 0x00002959 File Offset: 0x00000B59
	public WormConfigureGamePromptBehaviour(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000053 RID: 83
	// (get) Token: 0x06000153 RID: 339 RVA: 0x0001D1E8 File Offset: 0x0001B3E8
	// (set) Token: 0x06000154 RID: 340 RVA: 0x00002962 File Offset: 0x00000B62
	public unsafe WormConfigureGameColorsPromptBehaviour colors
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureGamePromptBehaviour.NativeFieldInfoPtr_colors);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormConfigureGameColorsPromptBehaviour>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureGamePromptBehaviour.NativeFieldInfoPtr_colors), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000054 RID: 84
	// (get) Token: 0x06000155 RID: 341 RVA: 0x0001D218 File Offset: 0x0001B418
	// (set) Token: 0x06000156 RID: 342 RVA: 0x00002981 File Offset: 0x00000B81
	public unsafe TMP_InputField passwordInputField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureGamePromptBehaviour.NativeFieldInfoPtr_passwordInputField);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureGamePromptBehaviour.NativeFieldInfoPtr_passwordInputField), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000055 RID: 85
	// (get) Token: 0x06000157 RID: 343 RVA: 0x0001D248 File Offset: 0x0001B448
	// (set) Token: 0x06000158 RID: 344 RVA: 0x000029A0 File Offset: 0x00000BA0
	public unsafe Animator hagalAnimator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureGamePromptBehaviour.NativeFieldInfoPtr_hagalAnimator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureGamePromptBehaviour.NativeFieldInfoPtr_hagalAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000056 RID: 86
	// (get) Token: 0x06000159 RID: 345 RVA: 0x0001D278 File Offset: 0x0001B478
	// (set) Token: 0x0600015A RID: 346 RVA: 0x000029BF File Offset: 0x00000BBF
	public unsafe static int HagalAnimatorValue
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(WormConfigureGamePromptBehaviour.NativeFieldInfoPtr_HagalAnimatorValue, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(WormConfigureGamePromptBehaviour.NativeFieldInfoPtr_HagalAnimatorValue, (void*)(&value));
		}
	}

	// Token: 0x17000057 RID: 87
	// (get) Token: 0x0600015B RID: 347 RVA: 0x0001D294 File Offset: 0x0001B494
	// (set) Token: 0x0600015C RID: 348 RVA: 0x000029CD File Offset: 0x00000BCD
	public unsafe WormDisabledData aiColorsDisabledData
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureGamePromptBehaviour.NativeFieldInfoPtr_aiColorsDisabledData);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormDisabledData>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureGamePromptBehaviour.NativeFieldInfoPtr_aiColorsDisabledData), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000058 RID: 88
	// (get) Token: 0x0600015D RID: 349 RVA: 0x0001D2C4 File Offset: 0x0001B4C4
	// (set) Token: 0x0600015E RID: 350 RVA: 0x000029EC File Offset: 0x00000BEC
	public unsafe List<AbilityID> startingRuleModifierAbilityIDs
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureGamePromptBehaviour.NativeFieldInfoPtr_startingRuleModifierAbilityIDs);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AbilityID>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureGamePromptBehaviour.NativeFieldInfoPtr_startingRuleModifierAbilityIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000059 RID: 89
	// (get) Token: 0x0600015F RID: 351 RVA: 0x0001D2F4 File Offset: 0x0001B4F4
	// (set) Token: 0x06000160 RID: 352 RVA: 0x00002A0B File Offset: 0x00000C0B
	public unsafe List<ArchetypeID> preferredLeaderArchetypeIDs
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureGamePromptBehaviour.NativeFieldInfoPtr_preferredLeaderArchetypeIDs);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureGamePromptBehaviour.NativeFieldInfoPtr_preferredLeaderArchetypeIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700005A RID: 90
	// (get) Token: 0x06000161 RID: 353 RVA: 0x0001D324 File Offset: 0x0001B524
	// (set) Token: 0x06000162 RID: 354 RVA: 0x00002A2A File Offset: 0x00000C2A
	public unsafe int skirmishRuleModID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureGamePromptBehaviour.NativeFieldInfoPtr_skirmishRuleModID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureGamePromptBehaviour.NativeFieldInfoPtr_skirmishRuleModID)) = value;
		}
	}

	// Token: 0x1700005B RID: 91
	// (get) Token: 0x06000163 RID: 355 RVA: 0x0001D34C File Offset: 0x0001B54C
	// (set) Token: 0x06000164 RID: 356 RVA: 0x00002A45 File Offset: 0x00000C45
	public unsafe List<int> skirmishScoreIDList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureGamePromptBehaviour.NativeFieldInfoPtr_skirmishScoreIDList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureGamePromptBehaviour.NativeFieldInfoPtr_skirmishScoreIDList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040000BD RID: 189
	private static readonly IntPtr NativeFieldInfoPtr_colors;

	// Token: 0x040000BE RID: 190
	private static readonly IntPtr NativeFieldInfoPtr_passwordInputField;

	// Token: 0x040000BF RID: 191
	private static readonly IntPtr NativeFieldInfoPtr_hagalAnimator;

	// Token: 0x040000C0 RID: 192
	private static readonly IntPtr NativeFieldInfoPtr_HagalAnimatorValue;

	// Token: 0x040000C1 RID: 193
	private static readonly IntPtr NativeFieldInfoPtr_aiColorsDisabledData;

	// Token: 0x040000C2 RID: 194
	private static readonly IntPtr NativeFieldInfoPtr_startingRuleModifierAbilityIDs;

	// Token: 0x040000C3 RID: 195
	private static readonly IntPtr NativeFieldInfoPtr_preferredLeaderArchetypeIDs;

	// Token: 0x040000C4 RID: 196
	private static readonly IntPtr NativeFieldInfoPtr_skirmishRuleModID;

	// Token: 0x040000C5 RID: 197
	private static readonly IntPtr NativeFieldInfoPtr_skirmishScoreIDList;

	// Token: 0x040000C6 RID: 198
	private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

	// Token: 0x040000C7 RID: 199
	private static readonly IntPtr NativeMethodInfoPtr_LoadPlayerType_Private_Void_SubscriptionProvider_PlayerType_0;

	// Token: 0x040000C8 RID: 200
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

	// Token: 0x040000C9 RID: 201
	private static readonly IntPtr NativeMethodInfoPtr_Event_CreateGame_Public_Virtual_Void_0;

	// Token: 0x040000CA RID: 202
	private static readonly IntPtr NativeMethodInfoPtr_LoadPlayerTypeFromPref_Private_Void_SubscriptionProvider_ISettingDefinition_1_Int32_0;

	// Token: 0x040000CB RID: 203
	private static readonly IntPtr NativeMethodInfoPtr_SavePlayerTypePref_Private_Static_Void_SubscriptionProvider_IWritableSetting_1_Int32_0;

	// Token: 0x040000CC RID: 204
	private static readonly IntPtr NativeMethodInfoPtr_Event_IncrementDifficulty_Public_Void_Int32_0;

	// Token: 0x040000CD RID: 205
	private static readonly IntPtr NativeMethodInfoPtr_UpdateDifficultyState_Private_Void_0;

	// Token: 0x040000CE RID: 206
	private static readonly IntPtr NativeMethodInfoPtr_Event_IncrementAIType_Public_Void_Int32_0;

	// Token: 0x040000CF RID: 207
	private static readonly IntPtr NativeMethodInfoPtr_UpdateAITypeState_Private_Void_0;

	// Token: 0x040000D0 RID: 208
	private static readonly IntPtr NativeMethodInfoPtr_IsHagalType_Public_Boolean_0;

	// Token: 0x040000D1 RID: 209
	private static readonly IntPtr NativeMethodInfoPtr_Event_IncrementDraftType_Public_Void_Int32_0;

	// Token: 0x040000D2 RID: 210
	private static readonly IntPtr NativeMethodInfoPtr_Event_IncrementTurnTimers_Public_Void_Int32_0;

	// Token: 0x040000D3 RID: 211
	private static readonly IntPtr NativeMethodInfoPtr_UpdateExpansionOptionsState_Public_Void_0;

	// Token: 0x040000D4 RID: 212
	private static readonly IntPtr NativeMethodInfoPtr_IsVariantAllowed_Public_Boolean_String_0;

	// Token: 0x040000D5 RID: 213
	private static readonly IntPtr NativeMethodInfoPtr_UpdateTurnTimerState_Private_Void_0;

	// Token: 0x040000D6 RID: 214
	private static readonly IntPtr NativeMethodInfoPtr_AddToRuleModifiers_Public_Void_AbilityID_0;

	// Token: 0x040000D7 RID: 215
	private static readonly IntPtr NativeMethodInfoPtr_SetSkirmishRuleModID_Public_Void_Int32_Int32_Int32_0;

	// Token: 0x040000D8 RID: 216
	private static readonly IntPtr NativeMethodInfoPtr_AddToPreferredLeaders_Public_Void_ArchetypeID_0;

	// Token: 0x040000D9 RID: 217
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x040000DA RID: 218
	private static readonly IntPtr NativeMethodInfoPtr__Event_CreateGame_b__12_0_Private_Boolean_Set_0;

	// Token: 0x040000DB RID: 219
	private static readonly IntPtr NativeMethodInfoPtr__Event_CreateGame_b__12_1_Private_Boolean_RulesModifier_0;

	// Token: 0x020002BD RID: 701
	[ObfuscatedName("WormConfigureGamePromptBehaviour+<>c")]
	[Serializable]
	public new sealed class __c : global::Il2CppSystem.Object
	{
		// Token: 0x06001C95 RID: 7317 RVA: 0x0006FE80 File Offset: 0x0006E080
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<WormConfigureGamePromptBehaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormConfigureGamePromptBehaviour>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConfigureGamePromptBehaviour.__c>.NativeClassPtr);
			WormConfigureGamePromptBehaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConfigureGamePromptBehaviour.__c>.NativeClassPtr, "<>9");
			WormConfigureGamePromptBehaviour.__c.NativeFieldInfoPtr___9__12_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConfigureGamePromptBehaviour.__c>.NativeClassPtr, "<>9__12_2");
			WormConfigureGamePromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureGamePromptBehaviour.__c>.NativeClassPtr, 100663516);
			WormConfigureGamePromptBehaviour.__c.NativeMethodInfoPtr__Event_CreateGame_b__12_2_Internal_AccountIDUsernameMetadata_RosterEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureGamePromptBehaviour.__c>.NativeClassPtr, 100663517);
		}

		// Token: 0x06001C96 RID: 7318 RVA: 0x0006FEFC File Offset: 0x0006E0FC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConfigureGamePromptBehaviour.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureGamePromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C97 RID: 7319 RVA: 0x0006FF38 File Offset: 0x0006E138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 688260, XrefRangeEnd = 688278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AccountIDUsernameMetadata _Event_CreateGame_b__12_2(RosterEntry f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureGamePromptBehaviour.__c.NativeMethodInfoPtr__Event_CreateGame_b__12_2_Internal_AccountIDUsernameMetadata_RosterEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountIDUsernameMetadata>(intPtr3) : null;
			}
		}

		// Token: 0x06001C98 RID: 7320 RVA: 0x0001065F File Offset: 0x0000E85F
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06001C99 RID: 7321 RVA: 0x0006FF88 File Offset: 0x0006E188
		// (set) Token: 0x06001C9A RID: 7322 RVA: 0x00010668 File Offset: 0x0000E868
		public unsafe static WormConfigureGamePromptBehaviour.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormConfigureGamePromptBehaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormConfigureGamePromptBehaviour.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormConfigureGamePromptBehaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06001C9B RID: 7323 RVA: 0x0006FFB0 File Offset: 0x0006E1B0
		// (set) Token: 0x06001C9C RID: 7324 RVA: 0x0001067A File Offset: 0x0000E87A
		public unsafe static Func<RosterEntry, AccountIDUsernameMetadata> __9__12_2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormConfigureGamePromptBehaviour.__c.NativeFieldInfoPtr___9__12_2, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RosterEntry, AccountIDUsernameMetadata>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormConfigureGamePromptBehaviour.__c.NativeFieldInfoPtr___9__12_2, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001080 RID: 4224
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x04001081 RID: 4225
		private static readonly IntPtr NativeFieldInfoPtr___9__12_2;

		// Token: 0x04001082 RID: 4226
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001083 RID: 4227
		private static readonly IntPtr NativeMethodInfoPtr__Event_CreateGame_b__12_2_Internal_AccountIDUsernameMetadata_RosterEntry_0;
	}
}
