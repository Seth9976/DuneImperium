using System;
using boardgames.data;
using Canis.messages;
using Canis.utils.ids;
using dbgclient.commands;
using dwd.core.account;
using dwd.core.data.composition;
using dwd.core.ui.prompt.behaviours;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lotus;
using Networking.lobby.responses;
using UnityEngine;
using UnityEngine.UI;

namespace boardgames.menus.prompts
{
	// Token: 0x020001E0 RID: 480
	public class WaitingForPlayersPromptBehaviour : PromptBehaviour<WaitingForPlayersPrompt>
	{
		// Token: 0x0600163A RID: 5690 RVA: 0x000653A8 File Offset: 0x000635A8
		// Note: this type is marked as 'beforefieldinit'.
		static WaitingForPlayersPromptBehaviour()
		{
			Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "WaitingForPlayersPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr);
			WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_backButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, "backButton");
			WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_startEarlyButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, "startEarlyButton");
			WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_joinButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, "joinButton");
			WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_leaveButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, "leaveButton");
			WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_purchaseButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, "purchaseButton");
			WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_purchaseMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, "purchaseMessage");
			WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_gameJoinedMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, "gameJoinedMessage");
			WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_playerSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, "playerSlots");
			WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_chat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, "chat");
			WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_playerConfigurationModalScope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, "playerConfigurationModalScope");
			WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_validColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, "validColors");
			WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_validAvatars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, "validAvatars");
			WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_avatarPrefKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, "avatarPrefKey");
			WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_colorPrefKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, "colorPrefKey");
			WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_configurePlayerPromptCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, "configurePlayerPromptCommand");
			WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_gameData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, "gameData");
			WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_cachedGameDataVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, "cachedGameDataVersion");
			WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_accountProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, "accountProvider");
			WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_get_HasJoined_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, 100666544);
			WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_get_CanStartEarly_Protected_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, 100666545);
			WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_get_OwnershipRequirementsMet_Protected_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, 100666546);
			WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, 100666547);
			WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, 100666548);
			WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_getActiveLocalPlayer_Protected_SubscriptionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, 100666549);
			WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_gameDataUpdated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, 100666550);
			WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_Event_Removed_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, 100666551);
			WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_Event_LeaveGame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, 100666552);
			WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_Event_JoinGame_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, 100666553);
			WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_Event_JoinGame_Public_Void_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, 100666554);
			WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_Event_Purchase_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, 100666555);
			WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_purchase_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, 100666556);
			WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_Event_ConfigurePlayer_Public_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, 100666557);
			WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_runConfigurePlayer_Protected_Virtual_New_IEnumerator_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, 100666558);
			WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_GetPrefValue_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, 100666559);
			WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_SetPrefValue_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, 100666560);
			WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_getPlayerColor_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, 100666561);
			WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_getPlayerAvatar_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, 100666562);
			WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_Event_UpdatePlayerMetadata_Public_Void_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, 100666563);
			WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_Event_StartEarly_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, 100666564);
			WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_Event_Back_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, 100666565);
			WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_PopulateDefaultMetadata_Public_Virtual_New_Void_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, 100666566);
			WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_colorDataConflicts_Protected_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, 100666567);
			WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_avatarDataConflicts_Protected_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, 100666568);
			WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_avatarRestricted_Protected_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, 100666569);
			WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_getRandomAvailableColor_Protected_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, 100666570);
			WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_getRandomAvailableAvatar_Protected_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, 100666571);
			WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_handleLobbyGameRemoved_Private_Void_LobbyGameRemoved_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, 100666572);
			WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_handlePlayerMetaDataUpdated_Private_Void_LobbyGamePlayerMetadataUpdated_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, 100666573);
			WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, 100666574);
			WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, 100666575);
			WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr__getRandomAvailableColor_b__47_0_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, 100666576);
			WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr__getRandomAvailableAvatar_b__48_0_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, 100666577);
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x0600163B RID: 5691 RVA: 0x000657E8 File Offset: 0x000639E8
		public unsafe bool HasJoined
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 523992, RefRangeEnd = 523993, XrefRangeStart = 523992, XrefRangeEnd = 523992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_get_HasJoined_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x0600163C RID: 5692 RVA: 0x00065824 File Offset: 0x00063A24
		public unsafe virtual bool CanStartEarly
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523993, XrefRangeEnd = 523994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_get_CanStartEarly_Protected_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x0600163D RID: 5693 RVA: 0x0006586C File Offset: 0x00063A6C
		public unsafe virtual bool OwnershipRequirementsMet
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_get_OwnershipRequirementsMet_Protected_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x000658B4 File Offset: 0x00063AB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 524086, RefRangeEnd = 524087, XrefRangeStart = 523994, XrefRangeEnd = 524086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x000658F0 File Offset: 0x00063AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524087, XrefRangeEnd = 524208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x0006592C File Offset: 0x00063B2C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 524226, RefRangeEnd = 524231, XrefRangeStart = 524208, XrefRangeEnd = 524226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SubscriptionProvider getActiveLocalPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_getActiveLocalPlayer_Protected_SubscriptionProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr3) : null;
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x0006596C File Offset: 0x00063B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524231, XrefRangeEnd = 524233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void gameDataUpdated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_gameDataUpdated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x000659A8 File Offset: 0x00063BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524233, XrefRangeEnd = 524236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Event_Removed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_Event_Removed_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x000659E4 File Offset: 0x00063BE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 524245, RefRangeEnd = 524246, XrefRangeStart = 524236, XrefRangeEnd = 524245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_LeaveGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_Event_LeaveGame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x00065A18 File Offset: 0x00063C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524246, XrefRangeEnd = 524253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Event_JoinGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_Event_JoinGame_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x00065A54 File Offset: 0x00063C54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 524283, RefRangeEnd = 524284, XrefRangeStart = 524253, XrefRangeEnd = 524283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_JoinGame(Dictionary<string, string> joinMetadata)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(joinMetadata);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_Event_JoinGame_Public_Void_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x00065A98 File Offset: 0x00063C98
		[CallerCount(0)]
		public unsafe void Event_Purchase()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_Event_Purchase_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001647 RID: 5703 RVA: 0x00065ACC File Offset: 0x00063CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524284, XrefRangeEnd = 524287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void purchase()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_purchase_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x00065B08 File Offset: 0x00063D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524287, XrefRangeEnd = 524288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ConfigurePlayer(DataComposition data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_Event_ConfigurePlayer_Public_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x00065B4C File Offset: 0x00063D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524288, XrefRangeEnd = 524294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator runConfigurePlayer(DataComposition data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_runConfigurePlayer_Protected_Virtual_New_IEnumerator_DataComposition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x0600164A RID: 5706 RVA: 0x00065BA8 File Offset: 0x00063DA8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 524309, RefRangeEnd = 524313, XrefRangeStart = 524294, XrefRangeEnd = 524309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetPrefValue(string prefKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_GetPrefValue_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600164B RID: 5707 RVA: 0x00065BF0 File Offset: 0x00063DF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 524326, RefRangeEnd = 524328, XrefRangeStart = 524313, XrefRangeEnd = 524326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPrefValue(string prefKey, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_SetPrefValue_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x00065C44 File Offset: 0x00063E44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 524337, RefRangeEnd = 524339, XrefRangeStart = 524328, XrefRangeEnd = 524337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string getPlayerColor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_getPlayerColor_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x00065C7C File Offset: 0x00063E7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 524348, RefRangeEnd = 524350, XrefRangeStart = 524339, XrefRangeEnd = 524348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string getPlayerAvatar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_getPlayerAvatar_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x00065CB4 File Offset: 0x00063EB4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 524363, RefRangeEnd = 524366, XrefRangeStart = 524350, XrefRangeEnd = 524363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_UpdatePlayerMetadata(Dictionary<string, string> joinMetadata)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(joinMetadata);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_Event_UpdatePlayerMetadata_Public_Void_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x00065CF8 File Offset: 0x00063EF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524366, XrefRangeEnd = 524369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_StartEarly()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_Event_StartEarly_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x00065D2C File Offset: 0x00063F2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524369, XrefRangeEnd = 524378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Back()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_Event_Back_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x00065D60 File Offset: 0x00063F60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 524419, RefRangeEnd = 524420, XrefRangeStart = 524378, XrefRangeEnd = 524419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PopulateDefaultMetadata(Dictionary<string, string> joinMetadata)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(joinMetadata);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_PopulateDefaultMetadata_Public_Virtual_New_Void_Dictionary_2_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x00065DB0 File Offset: 0x00063FB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 524432, RefRangeEnd = 524434, XrefRangeStart = 524420, XrefRangeEnd = 524432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool colorDataConflicts(string color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_colorDataConflicts_Protected_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x00065E00 File Offset: 0x00064000
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 524445, RefRangeEnd = 524447, XrefRangeStart = 524434, XrefRangeEnd = 524445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool avatarDataConflicts(string avatar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(avatar);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_avatarDataConflicts_Protected_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x00065E50 File Offset: 0x00064050
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool avatarRestricted(string avatar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(avatar);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_avatarRestricted_Protected_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x00065EA8 File Offset: 0x000640A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 524470, RefRangeEnd = 524471, XrefRangeStart = 524447, XrefRangeEnd = 524470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string getRandomAvailableColor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_getRandomAvailableColor_Protected_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x00065EE0 File Offset: 0x000640E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 524494, RefRangeEnd = 524495, XrefRangeStart = 524471, XrefRangeEnd = 524494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string getRandomAvailableAvatar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_getRandomAvailableAvatar_Protected_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x00065F18 File Offset: 0x00064118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524495, XrefRangeEnd = 524499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handleLobbyGameRemoved(LobbyGameRemoved message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_handleLobbyGameRemoved_Private_Void_LobbyGameRemoved_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x00065F5C File Offset: 0x0006415C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524499, XrefRangeEnd = 524501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handlePlayerMetaDataUpdated(LobbyGamePlayerMetadataUpdated message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_handlePlayerMetaDataUpdated_Private_Void_LobbyGamePlayerMetadataUpdated_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x00065FA0 File Offset: 0x000641A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524501, XrefRangeEnd = 524522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600165A RID: 5722 RVA: 0x00065FD4 File Offset: 0x000641D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 524537, RefRangeEnd = 524538, XrefRangeStart = 524522, XrefRangeEnd = 524537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaitingForPlayersPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x00066010 File Offset: 0x00064210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524538, XrefRangeEnd = 524552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _getRandomAvailableColor_b__47_0(string c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr__getRandomAvailableColor_b__47_0_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x00066060 File Offset: 0x00064260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524552, XrefRangeEnd = 524566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _getRandomAvailableAvatar_b__48_0(string a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPromptBehaviour.NativeMethodInfoPtr__getRandomAvailableAvatar_b__48_0_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x0000C95C File Offset: 0x0000AB5C
		public WaitingForPlayersPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x0600165E RID: 5726 RVA: 0x000660B0 File Offset: 0x000642B0
		// (set) Token: 0x0600165F RID: 5727 RVA: 0x0000C965 File Offset: 0x0000AB65
		public unsafe Button backButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_backButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_backButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06001660 RID: 5728 RVA: 0x000660E0 File Offset: 0x000642E0
		// (set) Token: 0x06001661 RID: 5729 RVA: 0x0000C984 File Offset: 0x0000AB84
		public unsafe Button startEarlyButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_startEarlyButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_startEarlyButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06001662 RID: 5730 RVA: 0x00066110 File Offset: 0x00064310
		// (set) Token: 0x06001663 RID: 5731 RVA: 0x0000C9A3 File Offset: 0x0000ABA3
		public unsafe Button joinButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_joinButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_joinButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06001664 RID: 5732 RVA: 0x00066140 File Offset: 0x00064340
		// (set) Token: 0x06001665 RID: 5733 RVA: 0x0000C9C2 File Offset: 0x0000ABC2
		public unsafe Button leaveButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_leaveButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_leaveButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06001666 RID: 5734 RVA: 0x00066170 File Offset: 0x00064370
		// (set) Token: 0x06001667 RID: 5735 RVA: 0x0000C9E1 File Offset: 0x0000ABE1
		public unsafe Button purchaseButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_purchaseButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_purchaseButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06001668 RID: 5736 RVA: 0x000661A0 File Offset: 0x000643A0
		// (set) Token: 0x06001669 RID: 5737 RVA: 0x0000CA00 File Offset: 0x0000AC00
		public unsafe GameObject purchaseMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_purchaseMessage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_purchaseMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x0600166A RID: 5738 RVA: 0x000661D0 File Offset: 0x000643D0
		// (set) Token: 0x0600166B RID: 5739 RVA: 0x0000CA1F File Offset: 0x0000AC1F
		public unsafe GameObject gameJoinedMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_gameJoinedMessage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_gameJoinedMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x0600166C RID: 5740 RVA: 0x00066200 File Offset: 0x00064400
		// (set) Token: 0x0600166D RID: 5741 RVA: 0x0000CA3E File Offset: 0x0000AC3E
		public unsafe Il2CppReferenceArray<SubscriptionProvider> playerSlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_playerSlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SubscriptionProvider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_playerSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x0600166E RID: 5742 RVA: 0x00066230 File Offset: 0x00064430
		// (set) Token: 0x0600166F RID: 5743 RVA: 0x0000CA5D File Offset: 0x0000AC5D
		public unsafe ChatView chat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_chat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChatView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_chat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06001670 RID: 5744 RVA: 0x00066260 File Offset: 0x00064460
		// (set) Token: 0x06001671 RID: 5745 RVA: 0x0000CA7C File Offset: 0x0000AC7C
		public unsafe ModalScope playerConfigurationModalScope
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_playerConfigurationModalScope);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ModalScope>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_playerConfigurationModalScope), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06001672 RID: 5746 RVA: 0x00066290 File Offset: 0x00064490
		// (set) Token: 0x06001673 RID: 5747 RVA: 0x0000CA9B File Offset: 0x0000AC9B
		public unsafe ValidStringsScriptableObject validColors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_validColors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidStringsScriptableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_validColors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06001674 RID: 5748 RVA: 0x000662C0 File Offset: 0x000644C0
		// (set) Token: 0x06001675 RID: 5749 RVA: 0x0000CABA File Offset: 0x0000ACBA
		public unsafe ValidStringsScriptableObject validAvatars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_validAvatars);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidStringsScriptableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_validAvatars), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06001676 RID: 5750 RVA: 0x000662F0 File Offset: 0x000644F0
		// (set) Token: 0x06001677 RID: 5751 RVA: 0x0000CAD9 File Offset: 0x0000ACD9
		public unsafe string avatarPrefKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_avatarPrefKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_avatarPrefKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06001678 RID: 5752 RVA: 0x00066318 File Offset: 0x00064518
		// (set) Token: 0x06001679 RID: 5753 RVA: 0x0000CAF8 File Offset: 0x0000ACF8
		public unsafe string colorPrefKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_colorPrefKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_colorPrefKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x0600167A RID: 5754 RVA: 0x00066340 File Offset: 0x00064540
		// (set) Token: 0x0600167B RID: 5755 RVA: 0x0000CB17 File Offset: 0x0000AD17
		public unsafe DisplayConfigurePlayerPrompt configurePlayerPromptCommand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_configurePlayerPromptCommand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DisplayConfigurePlayerPrompt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_configurePlayerPromptCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x0600167C RID: 5756 RVA: 0x00066370 File Offset: 0x00064570
		// (set) Token: 0x0600167D RID: 5757 RVA: 0x0000CB36 File Offset: 0x0000AD36
		public unsafe PendingGameData gameData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_gameData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PendingGameData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_gameData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x0600167E RID: 5758 RVA: 0x000663A0 File Offset: 0x000645A0
		// (set) Token: 0x0600167F RID: 5759 RVA: 0x0000CB55 File Offset: 0x0000AD55
		public unsafe ulong cachedGameDataVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_cachedGameDataVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_cachedGameDataVersion)) = value;
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06001680 RID: 5760 RVA: 0x000663C8 File Offset: 0x000645C8
		// (set) Token: 0x06001681 RID: 5761 RVA: 0x0000CB70 File Offset: 0x0000AD70
		public unsafe AccountProvider accountProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_accountProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.NativeFieldInfoPtr_accountProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DC2 RID: 3522
		private static readonly IntPtr NativeFieldInfoPtr_backButton;

		// Token: 0x04000DC3 RID: 3523
		private static readonly IntPtr NativeFieldInfoPtr_startEarlyButton;

		// Token: 0x04000DC4 RID: 3524
		private static readonly IntPtr NativeFieldInfoPtr_joinButton;

		// Token: 0x04000DC5 RID: 3525
		private static readonly IntPtr NativeFieldInfoPtr_leaveButton;

		// Token: 0x04000DC6 RID: 3526
		private static readonly IntPtr NativeFieldInfoPtr_purchaseButton;

		// Token: 0x04000DC7 RID: 3527
		private static readonly IntPtr NativeFieldInfoPtr_purchaseMessage;

		// Token: 0x04000DC8 RID: 3528
		private static readonly IntPtr NativeFieldInfoPtr_gameJoinedMessage;

		// Token: 0x04000DC9 RID: 3529
		private static readonly IntPtr NativeFieldInfoPtr_playerSlots;

		// Token: 0x04000DCA RID: 3530
		private static readonly IntPtr NativeFieldInfoPtr_chat;

		// Token: 0x04000DCB RID: 3531
		private static readonly IntPtr NativeFieldInfoPtr_playerConfigurationModalScope;

		// Token: 0x04000DCC RID: 3532
		private static readonly IntPtr NativeFieldInfoPtr_validColors;

		// Token: 0x04000DCD RID: 3533
		private static readonly IntPtr NativeFieldInfoPtr_validAvatars;

		// Token: 0x04000DCE RID: 3534
		private static readonly IntPtr NativeFieldInfoPtr_avatarPrefKey;

		// Token: 0x04000DCF RID: 3535
		private static readonly IntPtr NativeFieldInfoPtr_colorPrefKey;

		// Token: 0x04000DD0 RID: 3536
		private static readonly IntPtr NativeFieldInfoPtr_configurePlayerPromptCommand;

		// Token: 0x04000DD1 RID: 3537
		private static readonly IntPtr NativeFieldInfoPtr_gameData;

		// Token: 0x04000DD2 RID: 3538
		private static readonly IntPtr NativeFieldInfoPtr_cachedGameDataVersion;

		// Token: 0x04000DD3 RID: 3539
		private static readonly IntPtr NativeFieldInfoPtr_accountProvider;

		// Token: 0x04000DD4 RID: 3540
		private static readonly IntPtr NativeMethodInfoPtr_get_HasJoined_Public_get_Boolean_0;

		// Token: 0x04000DD5 RID: 3541
		private static readonly IntPtr NativeMethodInfoPtr_get_CanStartEarly_Protected_Virtual_New_get_Boolean_0;

		// Token: 0x04000DD6 RID: 3542
		private static readonly IntPtr NativeMethodInfoPtr_get_OwnershipRequirementsMet_Protected_Virtual_New_get_Boolean_0;

		// Token: 0x04000DD7 RID: 3543
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x04000DD8 RID: 3544
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04000DD9 RID: 3545
		private static readonly IntPtr NativeMethodInfoPtr_getActiveLocalPlayer_Protected_SubscriptionProvider_0;

		// Token: 0x04000DDA RID: 3546
		private static readonly IntPtr NativeMethodInfoPtr_gameDataUpdated_Protected_Virtual_New_Void_0;

		// Token: 0x04000DDB RID: 3547
		private static readonly IntPtr NativeMethodInfoPtr_Event_Removed_Public_Virtual_New_Void_0;

		// Token: 0x04000DDC RID: 3548
		private static readonly IntPtr NativeMethodInfoPtr_Event_LeaveGame_Public_Void_0;

		// Token: 0x04000DDD RID: 3549
		private static readonly IntPtr NativeMethodInfoPtr_Event_JoinGame_Public_Virtual_New_Void_0;

		// Token: 0x04000DDE RID: 3550
		private static readonly IntPtr NativeMethodInfoPtr_Event_JoinGame_Public_Void_Dictionary_2_String_String_0;

		// Token: 0x04000DDF RID: 3551
		private static readonly IntPtr NativeMethodInfoPtr_Event_Purchase_Public_Void_0;

		// Token: 0x04000DE0 RID: 3552
		private static readonly IntPtr NativeMethodInfoPtr_purchase_Protected_Virtual_New_Void_0;

		// Token: 0x04000DE1 RID: 3553
		private static readonly IntPtr NativeMethodInfoPtr_Event_ConfigurePlayer_Public_Void_DataComposition_0;

		// Token: 0x04000DE2 RID: 3554
		private static readonly IntPtr NativeMethodInfoPtr_runConfigurePlayer_Protected_Virtual_New_IEnumerator_DataComposition_0;

		// Token: 0x04000DE3 RID: 3555
		private static readonly IntPtr NativeMethodInfoPtr_GetPrefValue_Private_String_String_0;

		// Token: 0x04000DE4 RID: 3556
		private static readonly IntPtr NativeMethodInfoPtr_SetPrefValue_Private_Void_String_String_0;

		// Token: 0x04000DE5 RID: 3557
		private static readonly IntPtr NativeMethodInfoPtr_getPlayerColor_Private_String_0;

		// Token: 0x04000DE6 RID: 3558
		private static readonly IntPtr NativeMethodInfoPtr_getPlayerAvatar_Private_String_0;

		// Token: 0x04000DE7 RID: 3559
		private static readonly IntPtr NativeMethodInfoPtr_Event_UpdatePlayerMetadata_Public_Void_Dictionary_2_String_String_0;

		// Token: 0x04000DE8 RID: 3560
		private static readonly IntPtr NativeMethodInfoPtr_Event_StartEarly_Public_Void_0;

		// Token: 0x04000DE9 RID: 3561
		private static readonly IntPtr NativeMethodInfoPtr_Event_Back_Public_Void_0;

		// Token: 0x04000DEA RID: 3562
		private static readonly IntPtr NativeMethodInfoPtr_PopulateDefaultMetadata_Public_Virtual_New_Void_Dictionary_2_String_String_0;

		// Token: 0x04000DEB RID: 3563
		private static readonly IntPtr NativeMethodInfoPtr_colorDataConflicts_Protected_Boolean_String_0;

		// Token: 0x04000DEC RID: 3564
		private static readonly IntPtr NativeMethodInfoPtr_avatarDataConflicts_Protected_Boolean_String_0;

		// Token: 0x04000DED RID: 3565
		private static readonly IntPtr NativeMethodInfoPtr_avatarRestricted_Protected_Virtual_New_Boolean_String_0;

		// Token: 0x04000DEE RID: 3566
		private static readonly IntPtr NativeMethodInfoPtr_getRandomAvailableColor_Protected_String_0;

		// Token: 0x04000DEF RID: 3567
		private static readonly IntPtr NativeMethodInfoPtr_getRandomAvailableAvatar_Protected_String_0;

		// Token: 0x04000DF0 RID: 3568
		private static readonly IntPtr NativeMethodInfoPtr_handleLobbyGameRemoved_Private_Void_LobbyGameRemoved_0;

		// Token: 0x04000DF1 RID: 3569
		private static readonly IntPtr NativeMethodInfoPtr_handlePlayerMetaDataUpdated_Private_Void_LobbyGamePlayerMetadataUpdated_0;

		// Token: 0x04000DF2 RID: 3570
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000DF3 RID: 3571
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000DF4 RID: 3572
		private static readonly IntPtr NativeMethodInfoPtr__getRandomAvailableColor_b__47_0_Private_Boolean_String_0;

		// Token: 0x04000DF5 RID: 3573
		private static readonly IntPtr NativeMethodInfoPtr__getRandomAvailableAvatar_b__48_0_Private_Boolean_String_0;

		// Token: 0x020003CE RID: 974
		[ObfuscatedName("boardgames.menus.prompts.WaitingForPlayersPromptBehaviour+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06002D61 RID: 11617 RVA: 0x000B0050 File Offset: 0x000AE250
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour.__c>.NativeClassPtr);
				WaitingForPlayersPromptBehaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour.__c>.NativeClassPtr, "<>9");
				WaitingForPlayersPromptBehaviour.__c.NativeFieldInfoPtr___9__26_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour.__c>.NativeClassPtr, "<>9__26_0");
				WaitingForPlayersPromptBehaviour.__c.NativeFieldInfoPtr___9__35_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour.__c>.NativeClassPtr, "<>9__35_0");
				WaitingForPlayersPromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour.__c>.NativeClassPtr, 100666579);
				WaitingForPlayersPromptBehaviour.__c.NativeMethodInfoPtr__getActiveLocalPlayer_b__26_0_Internal_Boolean_SubscriptionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour.__c>.NativeClassPtr, 100666580);
				WaitingForPlayersPromptBehaviour.__c.NativeMethodInfoPtr__runConfigurePlayer_b__35_0_Internal_DataComposition_SubscriptionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour.__c>.NativeClassPtr, 100666581);
			}

			// Token: 0x06002D62 RID: 11618 RVA: 0x000B00F4 File Offset: 0x000AE2F4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D63 RID: 11619 RVA: 0x000B0130 File Offset: 0x000AE330
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523900, XrefRangeEnd = 523905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _getActiveLocalPlayer_b__26_0(SubscriptionProvider player)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPromptBehaviour.__c.NativeMethodInfoPtr__getActiveLocalPlayer_b__26_0_Internal_Boolean_SubscriptionProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002D64 RID: 11620 RVA: 0x000B0180 File Offset: 0x000AE380
			[CallerCount(0)]
			public unsafe DataComposition _runConfigurePlayer_b__35_0(SubscriptionProvider slot)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPromptBehaviour.__c.NativeMethodInfoPtr__runConfigurePlayer_b__35_0_Internal_DataComposition_SubscriptionProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
				}
			}

			// Token: 0x06002D65 RID: 11621 RVA: 0x000177B4 File Offset: 0x000159B4
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CE4 RID: 3300
			// (get) Token: 0x06002D66 RID: 11622 RVA: 0x000B01D0 File Offset: 0x000AE3D0
			// (set) Token: 0x06002D67 RID: 11623 RVA: 0x000177BD File Offset: 0x000159BD
			public unsafe static WaitingForPlayersPromptBehaviour.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WaitingForPlayersPromptBehaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitingForPlayersPromptBehaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WaitingForPlayersPromptBehaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CE5 RID: 3301
			// (get) Token: 0x06002D68 RID: 11624 RVA: 0x000B01F8 File Offset: 0x000AE3F8
			// (set) Token: 0x06002D69 RID: 11625 RVA: 0x000177CF File Offset: 0x000159CF
			public unsafe static Func<SubscriptionProvider, bool> __9__26_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WaitingForPlayersPromptBehaviour.__c.NativeFieldInfoPtr___9__26_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SubscriptionProvider, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WaitingForPlayersPromptBehaviour.__c.NativeFieldInfoPtr___9__26_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CE6 RID: 3302
			// (get) Token: 0x06002D6A RID: 11626 RVA: 0x000B0220 File Offset: 0x000AE420
			// (set) Token: 0x06002D6B RID: 11627 RVA: 0x000177E1 File Offset: 0x000159E1
			public unsafe static Func<SubscriptionProvider, DataComposition> __9__35_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WaitingForPlayersPromptBehaviour.__c.NativeFieldInfoPtr___9__35_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SubscriptionProvider, DataComposition>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WaitingForPlayersPromptBehaviour.__c.NativeFieldInfoPtr___9__35_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001C23 RID: 7203
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001C24 RID: 7204
			private static readonly IntPtr NativeFieldInfoPtr___9__26_0;

			// Token: 0x04001C25 RID: 7205
			private static readonly IntPtr NativeFieldInfoPtr___9__35_0;

			// Token: 0x04001C26 RID: 7206
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001C27 RID: 7207
			private static readonly IntPtr NativeMethodInfoPtr__getActiveLocalPlayer_b__26_0_Internal_Boolean_SubscriptionProvider_0;

			// Token: 0x04001C28 RID: 7208
			private static readonly IntPtr NativeMethodInfoPtr__runConfigurePlayer_b__35_0_Internal_DataComposition_SubscriptionProvider_0;
		}

		// Token: 0x020003CF RID: 975
		[ObfuscatedName("boardgames.menus.prompts.WaitingForPlayersPromptBehaviour+<>c__DisplayClass25_0")]
		public sealed class __c__DisplayClass25_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002D6C RID: 11628 RVA: 0x000B0248 File Offset: 0x000AE448
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_0()
			{
				Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass25_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour.__c__DisplayClass25_0>.NativeClassPtr);
				WaitingForPlayersPromptBehaviour.__c__DisplayClass25_0.NativeFieldInfoPtr_localAccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour.__c__DisplayClass25_0>.NativeClassPtr, "localAccountID");
				WaitingForPlayersPromptBehaviour.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour.__c__DisplayClass25_0>.NativeClassPtr, "<>4__this");
				WaitingForPlayersPromptBehaviour.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour.__c__DisplayClass25_0>.NativeClassPtr, 100666582);
				WaitingForPlayersPromptBehaviour.__c__DisplayClass25_0.NativeMethodInfoPtr__Update_b__0_Internal_Boolean_AccountIDUsernameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour.__c__DisplayClass25_0>.NativeClassPtr, 100666583);
			}

			// Token: 0x06002D6D RID: 11629 RVA: 0x000B02C4 File Offset: 0x000AE4C4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour.__c__DisplayClass25_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPromptBehaviour.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D6E RID: 11630 RVA: 0x000B0300 File Offset: 0x000AE500
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523905, XrefRangeEnd = 523917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Update_b__0(AccountIDUsernameMetadata f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPromptBehaviour.__c__DisplayClass25_0.NativeMethodInfoPtr__Update_b__0_Internal_Boolean_AccountIDUsernameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002D6F RID: 11631 RVA: 0x000177F3 File Offset: 0x000159F3
			public __c__DisplayClass25_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CE7 RID: 3303
			// (get) Token: 0x06002D70 RID: 11632 RVA: 0x000B0350 File Offset: 0x000AE550
			// (set) Token: 0x06002D71 RID: 11633 RVA: 0x000177FC File Offset: 0x000159FC
			public unsafe AccountID localAccountID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.__c__DisplayClass25_0.NativeFieldInfoPtr_localAccountID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.__c__DisplayClass25_0.NativeFieldInfoPtr_localAccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CE8 RID: 3304
			// (get) Token: 0x06002D72 RID: 11634 RVA: 0x000B0380 File Offset: 0x000AE580
			// (set) Token: 0x06002D73 RID: 11635 RVA: 0x0001781B File Offset: 0x00015A1B
			public unsafe WaitingForPlayersPromptBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitingForPlayersPromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001C29 RID: 7209
			private static readonly IntPtr NativeFieldInfoPtr_localAccountID;

			// Token: 0x04001C2A RID: 7210
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001C2B RID: 7211
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001C2C RID: 7212
			private static readonly IntPtr NativeMethodInfoPtr__Update_b__0_Internal_Boolean_AccountIDUsernameMetadata_0;
		}

		// Token: 0x020003D0 RID: 976
		[ObfuscatedName("boardgames.menus.prompts.WaitingForPlayersPromptBehaviour+<>c__DisplayClass25_1")]
		public sealed class __c__DisplayClass25_1 : global::Il2CppSystem.Object
		{
			// Token: 0x06002D74 RID: 11636 RVA: 0x000B03B0 File Offset: 0x000AE5B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_1()
			{
				Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour.__c__DisplayClass25_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass25_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour.__c__DisplayClass25_1>.NativeClassPtr);
				WaitingForPlayersPromptBehaviour.__c__DisplayClass25_1.NativeFieldInfoPtr_f = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour.__c__DisplayClass25_1>.NativeClassPtr, "f");
				WaitingForPlayersPromptBehaviour.__c__DisplayClass25_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour.__c__DisplayClass25_1>.NativeClassPtr, 100666584);
				WaitingForPlayersPromptBehaviour.__c__DisplayClass25_1.NativeMethodInfoPtr__Update_b__1_Internal_Boolean_AccountIDUsernameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour.__c__DisplayClass25_1>.NativeClassPtr, 100666585);
			}

			// Token: 0x06002D75 RID: 11637 RVA: 0x000B0418 File Offset: 0x000AE618
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour.__c__DisplayClass25_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPromptBehaviour.__c__DisplayClass25_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D76 RID: 11638 RVA: 0x000B0454 File Offset: 0x000AE654
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523917, XrefRangeEnd = 523922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Update_b__1(AccountIDUsernameMetadata p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPromptBehaviour.__c__DisplayClass25_1.NativeMethodInfoPtr__Update_b__1_Internal_Boolean_AccountIDUsernameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002D77 RID: 11639 RVA: 0x0001783A File Offset: 0x00015A3A
			public __c__DisplayClass25_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CE9 RID: 3305
			// (get) Token: 0x06002D78 RID: 11640 RVA: 0x000B04A4 File Offset: 0x000AE6A4
			// (set) Token: 0x06002D79 RID: 11641 RVA: 0x00017843 File Offset: 0x00015A43
			public unsafe AccountIDUsernameMetadata f
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.__c__DisplayClass25_1.NativeFieldInfoPtr_f);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountIDUsernameMetadata>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.__c__DisplayClass25_1.NativeFieldInfoPtr_f), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001C2D RID: 7213
			private static readonly IntPtr NativeFieldInfoPtr_f;

			// Token: 0x04001C2E RID: 7214
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001C2F RID: 7215
			private static readonly IntPtr NativeMethodInfoPtr__Update_b__1_Internal_Boolean_AccountIDUsernameMetadata_0;
		}

		// Token: 0x020003D1 RID: 977
		[ObfuscatedName("boardgames.menus.prompts.WaitingForPlayersPromptBehaviour+<>c__DisplayClass47_0")]
		public sealed class __c__DisplayClass47_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002D7A RID: 11642 RVA: 0x000B04D4 File Offset: 0x000AE6D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass47_0()
			{
				Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour.__c__DisplayClass47_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass47_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour.__c__DisplayClass47_0>.NativeClassPtr);
				WaitingForPlayersPromptBehaviour.__c__DisplayClass47_0.NativeFieldInfoPtr_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour.__c__DisplayClass47_0>.NativeClassPtr, "c");
				WaitingForPlayersPromptBehaviour.__c__DisplayClass47_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour.__c__DisplayClass47_0>.NativeClassPtr, 100666586);
				WaitingForPlayersPromptBehaviour.__c__DisplayClass47_0.NativeMethodInfoPtr__getRandomAvailableColor_b__1_Internal_Boolean_SubscriptionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour.__c__DisplayClass47_0>.NativeClassPtr, 100666587);
			}

			// Token: 0x06002D7B RID: 11643 RVA: 0x000B053C File Offset: 0x000AE73C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass47_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour.__c__DisplayClass47_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPromptBehaviour.__c__DisplayClass47_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D7C RID: 11644 RVA: 0x000B0578 File Offset: 0x000AE778
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523922, XrefRangeEnd = 523925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _getRandomAvailableColor_b__1(SubscriptionProvider s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPromptBehaviour.__c__DisplayClass47_0.NativeMethodInfoPtr__getRandomAvailableColor_b__1_Internal_Boolean_SubscriptionProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002D7D RID: 11645 RVA: 0x00017862 File Offset: 0x00015A62
			public __c__DisplayClass47_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CEA RID: 3306
			// (get) Token: 0x06002D7E RID: 11646 RVA: 0x000B05C8 File Offset: 0x000AE7C8
			// (set) Token: 0x06002D7F RID: 11647 RVA: 0x0001786B File Offset: 0x00015A6B
			public unsafe string c
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.__c__DisplayClass47_0.NativeFieldInfoPtr_c);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.__c__DisplayClass47_0.NativeFieldInfoPtr_c), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04001C30 RID: 7216
			private static readonly IntPtr NativeFieldInfoPtr_c;

			// Token: 0x04001C31 RID: 7217
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001C32 RID: 7218
			private static readonly IntPtr NativeMethodInfoPtr__getRandomAvailableColor_b__1_Internal_Boolean_SubscriptionProvider_0;
		}

		// Token: 0x020003D2 RID: 978
		[ObfuscatedName("boardgames.menus.prompts.WaitingForPlayersPromptBehaviour+<>c__DisplayClass48_0")]
		public sealed class __c__DisplayClass48_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002D80 RID: 11648 RVA: 0x000B05F0 File Offset: 0x000AE7F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass48_0()
			{
				Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour.__c__DisplayClass48_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass48_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour.__c__DisplayClass48_0>.NativeClassPtr);
				WaitingForPlayersPromptBehaviour.__c__DisplayClass48_0.NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour.__c__DisplayClass48_0>.NativeClassPtr, "a");
				WaitingForPlayersPromptBehaviour.__c__DisplayClass48_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour.__c__DisplayClass48_0>.NativeClassPtr, 100666588);
				WaitingForPlayersPromptBehaviour.__c__DisplayClass48_0.NativeMethodInfoPtr__getRandomAvailableAvatar_b__1_Internal_Boolean_SubscriptionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour.__c__DisplayClass48_0>.NativeClassPtr, 100666589);
			}

			// Token: 0x06002D81 RID: 11649 RVA: 0x000B0658 File Offset: 0x000AE858
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass48_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour.__c__DisplayClass48_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPromptBehaviour.__c__DisplayClass48_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D82 RID: 11650 RVA: 0x000B0694 File Offset: 0x000AE894
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523925, XrefRangeEnd = 523928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _getRandomAvailableAvatar_b__1(SubscriptionProvider s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPromptBehaviour.__c__DisplayClass48_0.NativeMethodInfoPtr__getRandomAvailableAvatar_b__1_Internal_Boolean_SubscriptionProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002D83 RID: 11651 RVA: 0x0001788A File Offset: 0x00015A8A
			public __c__DisplayClass48_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CEB RID: 3307
			// (get) Token: 0x06002D84 RID: 11652 RVA: 0x000B06E4 File Offset: 0x000AE8E4
			// (set) Token: 0x06002D85 RID: 11653 RVA: 0x00017893 File Offset: 0x00015A93
			public unsafe string a
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.__c__DisplayClass48_0.NativeFieldInfoPtr_a);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour.__c__DisplayClass48_0.NativeFieldInfoPtr_a), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04001C33 RID: 7219
			private static readonly IntPtr NativeFieldInfoPtr_a;

			// Token: 0x04001C34 RID: 7220
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001C35 RID: 7221
			private static readonly IntPtr NativeMethodInfoPtr__getRandomAvailableAvatar_b__1_Internal_Boolean_SubscriptionProvider_0;
		}

		// Token: 0x020003D3 RID: 979
		[ObfuscatedName("boardgames.menus.prompts.WaitingForPlayersPromptBehaviour+<runConfigurePlayer>d__35")]
		public sealed class _runConfigurePlayer_d__35 : global::Il2CppSystem.Object
		{
			// Token: 0x06002D86 RID: 11654 RVA: 0x000B070C File Offset: 0x000AE90C
			// Note: this type is marked as 'beforefieldinit'.
			static _runConfigurePlayer_d__35()
			{
				Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour._runConfigurePlayer_d__35>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour>.NativeClassPtr, "<runConfigurePlayer>d__35");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour._runConfigurePlayer_d__35>.NativeClassPtr);
				WaitingForPlayersPromptBehaviour._runConfigurePlayer_d__35.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour._runConfigurePlayer_d__35>.NativeClassPtr, "<>1__state");
				WaitingForPlayersPromptBehaviour._runConfigurePlayer_d__35.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour._runConfigurePlayer_d__35>.NativeClassPtr, "<>2__current");
				WaitingForPlayersPromptBehaviour._runConfigurePlayer_d__35.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour._runConfigurePlayer_d__35>.NativeClassPtr, "<>4__this");
				WaitingForPlayersPromptBehaviour._runConfigurePlayer_d__35.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour._runConfigurePlayer_d__35>.NativeClassPtr, "data");
				WaitingForPlayersPromptBehaviour._runConfigurePlayer_d__35.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour._runConfigurePlayer_d__35>.NativeClassPtr, 100666590);
				WaitingForPlayersPromptBehaviour._runConfigurePlayer_d__35.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour._runConfigurePlayer_d__35>.NativeClassPtr, 100666591);
				WaitingForPlayersPromptBehaviour._runConfigurePlayer_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour._runConfigurePlayer_d__35>.NativeClassPtr, 100666592);
				WaitingForPlayersPromptBehaviour._runConfigurePlayer_d__35.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour._runConfigurePlayer_d__35>.NativeClassPtr, 100666593);
				WaitingForPlayersPromptBehaviour._runConfigurePlayer_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour._runConfigurePlayer_d__35>.NativeClassPtr, 100666594);
				WaitingForPlayersPromptBehaviour._runConfigurePlayer_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour._runConfigurePlayer_d__35>.NativeClassPtr, 100666595);
			}

			// Token: 0x06002D87 RID: 11655 RVA: 0x000B0800 File Offset: 0x000AEA00
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _runConfigurePlayer_d__35(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitingForPlayersPromptBehaviour._runConfigurePlayer_d__35>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPromptBehaviour._runConfigurePlayer_d__35.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002D88 RID: 11656 RVA: 0x000B0848 File Offset: 0x000AEA48
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPromptBehaviour._runConfigurePlayer_d__35.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D89 RID: 11657 RVA: 0x000B087C File Offset: 0x000AEA7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523928, XrefRangeEnd = 523987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPromptBehaviour._runConfigurePlayer_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000CF0 RID: 3312
			// (get) Token: 0x06002D8A RID: 11658 RVA: 0x000B08B8 File Offset: 0x000AEAB8
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPromptBehaviour._runConfigurePlayer_d__35.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002D8B RID: 11659 RVA: 0x000B08F8 File Offset: 0x000AEAF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523987, XrefRangeEnd = 523992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPromptBehaviour._runConfigurePlayer_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000CF1 RID: 3313
			// (get) Token: 0x06002D8C RID: 11660 RVA: 0x000B092C File Offset: 0x000AEB2C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPromptBehaviour._runConfigurePlayer_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002D8D RID: 11661 RVA: 0x000178B2 File Offset: 0x00015AB2
			public _runConfigurePlayer_d__35(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CEC RID: 3308
			// (get) Token: 0x06002D8E RID: 11662 RVA: 0x000B096C File Offset: 0x000AEB6C
			// (set) Token: 0x06002D8F RID: 11663 RVA: 0x000178BB File Offset: 0x00015ABB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour._runConfigurePlayer_d__35.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour._runConfigurePlayer_d__35.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000CED RID: 3309
			// (get) Token: 0x06002D90 RID: 11664 RVA: 0x000B0994 File Offset: 0x000AEB94
			// (set) Token: 0x06002D91 RID: 11665 RVA: 0x000178D6 File Offset: 0x00015AD6
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour._runConfigurePlayer_d__35.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour._runConfigurePlayer_d__35.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CEE RID: 3310
			// (get) Token: 0x06002D92 RID: 11666 RVA: 0x000B09C4 File Offset: 0x000AEBC4
			// (set) Token: 0x06002D93 RID: 11667 RVA: 0x000178F5 File Offset: 0x00015AF5
			public unsafe WaitingForPlayersPromptBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour._runConfigurePlayer_d__35.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitingForPlayersPromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour._runConfigurePlayer_d__35.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CEF RID: 3311
			// (get) Token: 0x06002D94 RID: 11668 RVA: 0x000B09F4 File Offset: 0x000AEBF4
			// (set) Token: 0x06002D95 RID: 11669 RVA: 0x00017914 File Offset: 0x00015B14
			public unsafe DataComposition data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour._runConfigurePlayer_d__35.NativeFieldInfoPtr_data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPromptBehaviour._runConfigurePlayer_d__35.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001C36 RID: 7222
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001C37 RID: 7223
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001C38 RID: 7224
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001C39 RID: 7225
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x04001C3A RID: 7226
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001C3B RID: 7227
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001C3C RID: 7228
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001C3D RID: 7229
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001C3E RID: 7230
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001C3F RID: 7231
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
