using System;
using boardgames.data;
using Canis.utils.ids;
using dwd.core.data.composition;
using dwd.core.platform.websocket.incoming;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace boardgames.menus.prompts
{
	// Token: 0x020001C9 RID: 457
	public class ConfigureGamePromptBehaviour : ConfigureGameOptionsPromptBehaviour<ConfigureGamePrompt>
	{
		// Token: 0x060014B0 RID: 5296 RVA: 0x0006089C File Offset: 0x0005EA9C
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigureGamePromptBehaviour()
		{
			Il2CppClassPointerStore<ConfigureGamePromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "ConfigureGamePromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigureGamePromptBehaviour>.NativeClassPtr);
			ConfigureGamePromptBehaviour.NativeFieldInfoPtr_playerSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureGamePromptBehaviour>.NativeClassPtr, "playerSlots");
			ConfigureGamePromptBehaviour.NativeFieldInfoPtr_DisableForOnlineGames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureGamePromptBehaviour>.NativeClassPtr, "DisableForOnlineGames");
			ConfigureGamePromptBehaviour.NativeFieldInfoPtr_DisableForOfflineGames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureGamePromptBehaviour>.NativeClassPtr, "DisableForOfflineGames");
			ConfigureGamePromptBehaviour.NativeFieldInfoPtr_playerConfigurationModalScope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureGamePromptBehaviour>.NativeClassPtr, "playerConfigurationModalScope");
			ConfigureGamePromptBehaviour.NativeFieldInfoPtr_validColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureGamePromptBehaviour>.NativeClassPtr, "validColors");
			ConfigureGamePromptBehaviour.NativeFieldInfoPtr_validAvatars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureGamePromptBehaviour>.NativeClassPtr, "validAvatars");
			ConfigureGamePromptBehaviour.NativeFieldInfoPtr_lobbyGameProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureGamePromptBehaviour>.NativeClassPtr, "lobbyGameProvider");
			ConfigureGamePromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGamePromptBehaviour>.NativeClassPtr, 100666335);
			ConfigureGamePromptBehaviour.NativeMethodInfoPtr_setOfflinePlayerPrefs_Protected_Virtual_New_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGamePromptBehaviour>.NativeClassPtr, 100666336);
			ConfigureGamePromptBehaviour.NativeMethodInfoPtr_setOnlinePlayerPrefs_Protected_Virtual_New_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGamePromptBehaviour>.NativeClassPtr, 100666337);
			ConfigureGamePromptBehaviour.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGamePromptBehaviour>.NativeClassPtr, 100666338);
			ConfigureGamePromptBehaviour.NativeMethodInfoPtr_IsConfiguringOfflineGame_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGamePromptBehaviour>.NativeClassPtr, 100666339);
			ConfigureGamePromptBehaviour.NativeMethodInfoPtr_CheckCanCreateGame_Protected_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGamePromptBehaviour>.NativeClassPtr, 100666340);
			ConfigureGamePromptBehaviour.NativeMethodInfoPtr_Event_Back_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGamePromptBehaviour>.NativeClassPtr, 100666341);
			ConfigureGamePromptBehaviour.NativeMethodInfoPtr_Event_CreateGame_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGamePromptBehaviour>.NativeClassPtr, 100666342);
			ConfigureGamePromptBehaviour.NativeMethodInfoPtr_Event_DecrementPlayerType_Public_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGamePromptBehaviour>.NativeClassPtr, 100666343);
			ConfigureGamePromptBehaviour.NativeMethodInfoPtr_Event_IncrementPlayerType_Public_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGamePromptBehaviour>.NativeClassPtr, 100666344);
			ConfigureGamePromptBehaviour.NativeMethodInfoPtr_IncrementPlayerType_Protected_Virtual_New_Void_DataComposition_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGamePromptBehaviour>.NativeClassPtr, 100666345);
			ConfigureGamePromptBehaviour.NativeMethodInfoPtr_SetPlayerType_Public_Void_DataComposition_PlayerType_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGamePromptBehaviour>.NativeClassPtr, 100666346);
			ConfigureGamePromptBehaviour.NativeMethodInfoPtr_GetAvailablePlayerTypes_Protected_Virtual_New_List_1_PlayerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGamePromptBehaviour>.NativeClassPtr, 100666347);
			ConfigureGamePromptBehaviour.NativeMethodInfoPtr_GetFriendRosterEntry_Protected_RosterEntry_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGamePromptBehaviour>.NativeClassPtr, 100666348);
			ConfigureGamePromptBehaviour.NativeMethodInfoPtr_LoadRequiredFriend_Protected_Void_PlayerTypeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGamePromptBehaviour>.NativeClassPtr, 100666349);
			ConfigureGamePromptBehaviour.NativeMethodInfoPtr_GetBlockedPlayers_Protected_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGamePromptBehaviour>.NativeClassPtr, 100666350);
			ConfigureGamePromptBehaviour.NativeMethodInfoPtr_AllSlots_Public_List_1_SubscriptionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGamePromptBehaviour>.NativeClassPtr, 100666351);
			ConfigureGamePromptBehaviour.NativeMethodInfoPtr_Event_ConfigurePlayer_Public_Virtual_New_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGamePromptBehaviour>.NativeClassPtr, 100666352);
			ConfigureGamePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGamePromptBehaviour>.NativeClassPtr, 100666353);
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x00060AD4 File Offset: 0x0005ECD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 521035, RefRangeEnd = 521036, XrefRangeStart = 520970, XrefRangeEnd = 521035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigureGamePromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x00060B10 File Offset: 0x0005ED10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 521036, XrefRangeEnd = 521083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void setOfflinePlayerPrefs(DataComposition data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigureGamePromptBehaviour.NativeMethodInfoPtr_setOfflinePlayerPrefs_Protected_Virtual_New_Void_DataComposition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x00060B60 File Offset: 0x0005ED60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 521083, XrefRangeEnd = 521130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void setOnlinePlayerPrefs(DataComposition data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigureGamePromptBehaviour.NativeMethodInfoPtr_setOnlinePlayerPrefs_Protected_Virtual_New_Void_DataComposition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x00060BB0 File Offset: 0x0005EDB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 521175, RefRangeEnd = 521176, XrefRangeStart = 521130, XrefRangeEnd = 521175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigureGamePromptBehaviour.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x00060BEC File Offset: 0x0005EDEC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 521177, RefRangeEnd = 521181, XrefRangeStart = 521176, XrefRangeEnd = 521177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsConfiguringOfflineGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGamePromptBehaviour.NativeMethodInfoPtr_IsConfiguringOfflineGame_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x00060C28 File Offset: 0x0005EE28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 521181, XrefRangeEnd = 521226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CheckCanCreateGame(string matchType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(matchType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigureGamePromptBehaviour.NativeMethodInfoPtr_CheckCanCreateGame_Protected_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x00060C80 File Offset: 0x0005EE80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 521226, XrefRangeEnd = 521236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Event_Back()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigureGamePromptBehaviour.NativeMethodInfoPtr_Event_Back_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x00060CBC File Offset: 0x0005EEBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 521236, XrefRangeEnd = 521264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Event_CreateGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigureGamePromptBehaviour.NativeMethodInfoPtr_Event_CreateGame_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x00060CF8 File Offset: 0x0005EEF8
		[CallerCount(0)]
		public unsafe void Event_DecrementPlayerType(DataComposition data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGamePromptBehaviour.NativeMethodInfoPtr_Event_DecrementPlayerType_Public_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x00060D3C File Offset: 0x0005EF3C
		[CallerCount(0)]
		public unsafe void Event_IncrementPlayerType(DataComposition data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGamePromptBehaviour.NativeMethodInfoPtr_Event_IncrementPlayerType_Public_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x00060D80 File Offset: 0x0005EF80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 521264, XrefRangeEnd = 521302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void IncrementPlayerType(DataComposition data, int direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigureGamePromptBehaviour.NativeMethodInfoPtr_IncrementPlayerType_Protected_Virtual_New_Void_DataComposition_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x00060DDC File Offset: 0x0005EFDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 521302, XrefRangeEnd = 521365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlayerType(DataComposition data, PlayerTypeData.PlayerType type, AccountID friendID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(friendID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGamePromptBehaviour.NativeMethodInfoPtr_SetPlayerType_Public_Void_DataComposition_PlayerType_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x00060E40 File Offset: 0x0005F040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 521365, XrefRangeEnd = 521369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<PlayerTypeData.PlayerType> GetAvailablePlayerTypes(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigureGamePromptBehaviour.NativeMethodInfoPtr_GetAvailablePlayerTypes_Protected_Virtual_New_List_1_PlayerType_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<PlayerTypeData.PlayerType>>(intPtr3) : null;
			}
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x00060E98 File Offset: 0x0005F098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 521369, XrefRangeEnd = 521387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RosterEntry GetFriendRosterEntry(AccountID id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGamePromptBehaviour.NativeMethodInfoPtr_GetFriendRosterEntry_Protected_RosterEntry_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RosterEntry>(intPtr3) : null;
			}
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x00060EE8 File Offset: 0x0005F0E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 521409, RefRangeEnd = 521410, XrefRangeStart = 521387, XrefRangeEnd = 521409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadRequiredFriend(PlayerTypeData friendSlotTypeData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(friendSlotTypeData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGamePromptBehaviour.NativeMethodInfoPtr_LoadRequiredFriend_Protected_Void_PlayerTypeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x00060F2C File Offset: 0x0005F12C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 521410, XrefRangeEnd = 521422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetBlockedPlayers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGamePromptBehaviour.NativeMethodInfoPtr_GetBlockedPlayers_Protected_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x00060F64 File Offset: 0x0005F164
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<SubscriptionProvider> AllSlots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGamePromptBehaviour.NativeMethodInfoPtr_AllSlots_Public_List_1_SubscriptionProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SubscriptionProvider>>(intPtr3) : null;
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x00060FA4 File Offset: 0x0005F1A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 521422, XrefRangeEnd = 521463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Event_ConfigurePlayer(DataComposition data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigureGamePromptBehaviour.NativeMethodInfoPtr_Event_ConfigurePlayer_Public_Virtual_New_Void_DataComposition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x00060FF4 File Offset: 0x0005F1F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 521473, RefRangeEnd = 521474, XrefRangeStart = 521463, XrefRangeEnd = 521473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigureGamePromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigureGamePromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGamePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x0000BB72 File Offset: 0x00009D72
		public ConfigureGamePromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x060014C5 RID: 5317 RVA: 0x00061030 File Offset: 0x0005F230
		// (set) Token: 0x060014C6 RID: 5318 RVA: 0x0000BB7B File Offset: 0x00009D7B
		public unsafe List<SubscriptionProvider> playerSlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGamePromptBehaviour.NativeFieldInfoPtr_playerSlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SubscriptionProvider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGamePromptBehaviour.NativeFieldInfoPtr_playerSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x060014C7 RID: 5319 RVA: 0x00061060 File Offset: 0x0005F260
		// (set) Token: 0x060014C8 RID: 5320 RVA: 0x0000BB9A File Offset: 0x00009D9A
		public unsafe Il2CppReferenceArray<GameObject> DisableForOnlineGames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGamePromptBehaviour.NativeFieldInfoPtr_DisableForOnlineGames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGamePromptBehaviour.NativeFieldInfoPtr_DisableForOnlineGames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x060014C9 RID: 5321 RVA: 0x00061090 File Offset: 0x0005F290
		// (set) Token: 0x060014CA RID: 5322 RVA: 0x0000BBB9 File Offset: 0x00009DB9
		public unsafe Il2CppReferenceArray<GameObject> DisableForOfflineGames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGamePromptBehaviour.NativeFieldInfoPtr_DisableForOfflineGames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGamePromptBehaviour.NativeFieldInfoPtr_DisableForOfflineGames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x060014CB RID: 5323 RVA: 0x000610C0 File Offset: 0x0005F2C0
		// (set) Token: 0x060014CC RID: 5324 RVA: 0x0000BBD8 File Offset: 0x00009DD8
		public unsafe ModalScope playerConfigurationModalScope
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGamePromptBehaviour.NativeFieldInfoPtr_playerConfigurationModalScope);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ModalScope>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGamePromptBehaviour.NativeFieldInfoPtr_playerConfigurationModalScope), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x060014CD RID: 5325 RVA: 0x000610F0 File Offset: 0x0005F2F0
		// (set) Token: 0x060014CE RID: 5326 RVA: 0x0000BBF7 File Offset: 0x00009DF7
		public unsafe ValidStringsScriptableObject validColors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGamePromptBehaviour.NativeFieldInfoPtr_validColors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidStringsScriptableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGamePromptBehaviour.NativeFieldInfoPtr_validColors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x060014CF RID: 5327 RVA: 0x00061120 File Offset: 0x0005F320
		// (set) Token: 0x060014D0 RID: 5328 RVA: 0x0000BC16 File Offset: 0x00009E16
		public unsafe ValidStringsScriptableObject validAvatars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGamePromptBehaviour.NativeFieldInfoPtr_validAvatars);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidStringsScriptableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGamePromptBehaviour.NativeFieldInfoPtr_validAvatars), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x060014D1 RID: 5329 RVA: 0x00061150 File Offset: 0x0005F350
		// (set) Token: 0x060014D2 RID: 5330 RVA: 0x0000BC35 File Offset: 0x00009E35
		public unsafe DBGLobbyGameProvider lobbyGameProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGamePromptBehaviour.NativeFieldInfoPtr_lobbyGameProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGLobbyGameProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGamePromptBehaviour.NativeFieldInfoPtr_lobbyGameProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CCF RID: 3279
		private static readonly IntPtr NativeFieldInfoPtr_playerSlots;

		// Token: 0x04000CD0 RID: 3280
		private static readonly IntPtr NativeFieldInfoPtr_DisableForOnlineGames;

		// Token: 0x04000CD1 RID: 3281
		private static readonly IntPtr NativeFieldInfoPtr_DisableForOfflineGames;

		// Token: 0x04000CD2 RID: 3282
		private static readonly IntPtr NativeFieldInfoPtr_playerConfigurationModalScope;

		// Token: 0x04000CD3 RID: 3283
		private static readonly IntPtr NativeFieldInfoPtr_validColors;

		// Token: 0x04000CD4 RID: 3284
		private static readonly IntPtr NativeFieldInfoPtr_validAvatars;

		// Token: 0x04000CD5 RID: 3285
		private static readonly IntPtr NativeFieldInfoPtr_lobbyGameProvider;

		// Token: 0x04000CD6 RID: 3286
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x04000CD7 RID: 3287
		private static readonly IntPtr NativeMethodInfoPtr_setOfflinePlayerPrefs_Protected_Virtual_New_Void_DataComposition_0;

		// Token: 0x04000CD8 RID: 3288
		private static readonly IntPtr NativeMethodInfoPtr_setOnlinePlayerPrefs_Protected_Virtual_New_Void_DataComposition_0;

		// Token: 0x04000CD9 RID: 3289
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0;

		// Token: 0x04000CDA RID: 3290
		private static readonly IntPtr NativeMethodInfoPtr_IsConfiguringOfflineGame_Public_Boolean_0;

		// Token: 0x04000CDB RID: 3291
		private static readonly IntPtr NativeMethodInfoPtr_CheckCanCreateGame_Protected_Virtual_New_Boolean_String_0;

		// Token: 0x04000CDC RID: 3292
		private static readonly IntPtr NativeMethodInfoPtr_Event_Back_Public_Virtual_New_Void_0;

		// Token: 0x04000CDD RID: 3293
		private static readonly IntPtr NativeMethodInfoPtr_Event_CreateGame_Public_Virtual_New_Void_0;

		// Token: 0x04000CDE RID: 3294
		private static readonly IntPtr NativeMethodInfoPtr_Event_DecrementPlayerType_Public_Void_DataComposition_0;

		// Token: 0x04000CDF RID: 3295
		private static readonly IntPtr NativeMethodInfoPtr_Event_IncrementPlayerType_Public_Void_DataComposition_0;

		// Token: 0x04000CE0 RID: 3296
		private static readonly IntPtr NativeMethodInfoPtr_IncrementPlayerType_Protected_Virtual_New_Void_DataComposition_Int32_0;

		// Token: 0x04000CE1 RID: 3297
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerType_Public_Void_DataComposition_PlayerType_AccountID_0;

		// Token: 0x04000CE2 RID: 3298
		private static readonly IntPtr NativeMethodInfoPtr_GetAvailablePlayerTypes_Protected_Virtual_New_List_1_PlayerType_Int32_0;

		// Token: 0x04000CE3 RID: 3299
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendRosterEntry_Protected_RosterEntry_AccountID_0;

		// Token: 0x04000CE4 RID: 3300
		private static readonly IntPtr NativeMethodInfoPtr_LoadRequiredFriend_Protected_Void_PlayerTypeData_0;

		// Token: 0x04000CE5 RID: 3301
		private static readonly IntPtr NativeMethodInfoPtr_GetBlockedPlayers_Protected_String_0;

		// Token: 0x04000CE6 RID: 3302
		private static readonly IntPtr NativeMethodInfoPtr_AllSlots_Public_List_1_SubscriptionProvider_0;

		// Token: 0x04000CE7 RID: 3303
		private static readonly IntPtr NativeMethodInfoPtr_Event_ConfigurePlayer_Public_Virtual_New_Void_DataComposition_0;

		// Token: 0x04000CE8 RID: 3304
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003B6 RID: 950
		[ObfuscatedName("boardgames.menus.prompts.ConfigureGamePromptBehaviour+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06002C5A RID: 11354 RVA: 0x000AD158 File Offset: 0x000AB358
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ConfigureGamePromptBehaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfigureGamePromptBehaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigureGamePromptBehaviour.__c>.NativeClassPtr);
				ConfigureGamePromptBehaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureGamePromptBehaviour.__c>.NativeClassPtr, "<>9");
				ConfigureGamePromptBehaviour.__c.NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureGamePromptBehaviour.__c>.NativeClassPtr, "<>9__24_0");
				ConfigureGamePromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGamePromptBehaviour.__c>.NativeClassPtr, 100666355);
				ConfigureGamePromptBehaviour.__c.NativeMethodInfoPtr__Event_ConfigurePlayer_b__24_0_Internal_DataComposition_SubscriptionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGamePromptBehaviour.__c>.NativeClassPtr, 100666356);
			}

			// Token: 0x06002C5B RID: 11355 RVA: 0x000AD1D4 File Offset: 0x000AB3D4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigureGamePromptBehaviour.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGamePromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C5C RID: 11356 RVA: 0x000AD210 File Offset: 0x000AB410
			[CallerCount(0)]
			public unsafe DataComposition _Event_ConfigurePlayer_b__24_0(SubscriptionProvider slot)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGamePromptBehaviour.__c.NativeMethodInfoPtr__Event_ConfigurePlayer_b__24_0_Internal_DataComposition_SubscriptionProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
				}
			}

			// Token: 0x06002C5D RID: 11357 RVA: 0x00016F1E File Offset: 0x0001511E
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C94 RID: 3220
			// (get) Token: 0x06002C5E RID: 11358 RVA: 0x000AD260 File Offset: 0x000AB460
			// (set) Token: 0x06002C5F RID: 11359 RVA: 0x00016F27 File Offset: 0x00015127
			public unsafe static ConfigureGamePromptBehaviour.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigureGamePromptBehaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigureGamePromptBehaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigureGamePromptBehaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C95 RID: 3221
			// (get) Token: 0x06002C60 RID: 11360 RVA: 0x000AD288 File Offset: 0x000AB488
			// (set) Token: 0x06002C61 RID: 11361 RVA: 0x00016F39 File Offset: 0x00015139
			public unsafe static Func<SubscriptionProvider, DataComposition> __9__24_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigureGamePromptBehaviour.__c.NativeFieldInfoPtr___9__24_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SubscriptionProvider, DataComposition>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigureGamePromptBehaviour.__c.NativeFieldInfoPtr___9__24_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B92 RID: 7058
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001B93 RID: 7059
			private static readonly IntPtr NativeFieldInfoPtr___9__24_0;

			// Token: 0x04001B94 RID: 7060
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001B95 RID: 7061
			private static readonly IntPtr NativeMethodInfoPtr__Event_ConfigurePlayer_b__24_0_Internal_DataComposition_SubscriptionProvider_0;
		}

		// Token: 0x020003B7 RID: 951
		[ObfuscatedName("boardgames.menus.prompts.ConfigureGamePromptBehaviour+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002C62 RID: 11362 RVA: 0x000AD2B0 File Offset: 0x000AB4B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<ConfigureGamePromptBehaviour.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfigureGamePromptBehaviour>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigureGamePromptBehaviour.__c__DisplayClass17_0>.NativeClassPtr);
				ConfigureGamePromptBehaviour.__c__DisplayClass17_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureGamePromptBehaviour.__c__DisplayClass17_0>.NativeClassPtr, "data");
				ConfigureGamePromptBehaviour.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGamePromptBehaviour.__c__DisplayClass17_0>.NativeClassPtr, 100666357);
				ConfigureGamePromptBehaviour.__c__DisplayClass17_0.NativeMethodInfoPtr__IncrementPlayerType_b__0_Internal_Boolean_SubscriptionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGamePromptBehaviour.__c__DisplayClass17_0>.NativeClassPtr, 100666358);
			}

			// Token: 0x06002C63 RID: 11363 RVA: 0x000AD318 File Offset: 0x000AB518
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigureGamePromptBehaviour.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGamePromptBehaviour.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C64 RID: 11364 RVA: 0x000AD354 File Offset: 0x000AB554
			[CallerCount(0)]
			public unsafe bool _IncrementPlayerType_b__0(SubscriptionProvider slot)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGamePromptBehaviour.__c__DisplayClass17_0.NativeMethodInfoPtr__IncrementPlayerType_b__0_Internal_Boolean_SubscriptionProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002C65 RID: 11365 RVA: 0x00016F4B File Offset: 0x0001514B
			public __c__DisplayClass17_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C96 RID: 3222
			// (get) Token: 0x06002C66 RID: 11366 RVA: 0x000AD3A4 File Offset: 0x000AB5A4
			// (set) Token: 0x06002C67 RID: 11367 RVA: 0x00016F54 File Offset: 0x00015154
			public unsafe DataComposition data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGamePromptBehaviour.__c__DisplayClass17_0.NativeFieldInfoPtr_data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGamePromptBehaviour.__c__DisplayClass17_0.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B96 RID: 7062
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x04001B97 RID: 7063
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001B98 RID: 7064
			private static readonly IntPtr NativeMethodInfoPtr__IncrementPlayerType_b__0_Internal_Boolean_SubscriptionProvider_0;
		}

		// Token: 0x020003B8 RID: 952
		[ObfuscatedName("boardgames.menus.prompts.ConfigureGamePromptBehaviour+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002C68 RID: 11368 RVA: 0x000AD3D4 File Offset: 0x000AB5D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<ConfigureGamePromptBehaviour.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfigureGamePromptBehaviour>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigureGamePromptBehaviour.__c__DisplayClass18_0>.NativeClassPtr);
				ConfigureGamePromptBehaviour.__c__DisplayClass18_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureGamePromptBehaviour.__c__DisplayClass18_0>.NativeClassPtr, "data");
				ConfigureGamePromptBehaviour.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGamePromptBehaviour.__c__DisplayClass18_0>.NativeClassPtr, 100666359);
				ConfigureGamePromptBehaviour.__c__DisplayClass18_0.NativeMethodInfoPtr__SetPlayerType_b__0_Internal_Boolean_SubscriptionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGamePromptBehaviour.__c__DisplayClass18_0>.NativeClassPtr, 100666360);
			}

			// Token: 0x06002C69 RID: 11369 RVA: 0x000AD43C File Offset: 0x000AB63C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigureGamePromptBehaviour.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGamePromptBehaviour.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C6A RID: 11370 RVA: 0x000AD478 File Offset: 0x000AB678
			[CallerCount(0)]
			public unsafe bool _SetPlayerType_b__0(SubscriptionProvider slot)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGamePromptBehaviour.__c__DisplayClass18_0.NativeMethodInfoPtr__SetPlayerType_b__0_Internal_Boolean_SubscriptionProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002C6B RID: 11371 RVA: 0x00016F73 File Offset: 0x00015173
			public __c__DisplayClass18_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C97 RID: 3223
			// (get) Token: 0x06002C6C RID: 11372 RVA: 0x000AD4C8 File Offset: 0x000AB6C8
			// (set) Token: 0x06002C6D RID: 11373 RVA: 0x00016F7C File Offset: 0x0001517C
			public unsafe DataComposition data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGamePromptBehaviour.__c__DisplayClass18_0.NativeFieldInfoPtr_data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGamePromptBehaviour.__c__DisplayClass18_0.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B99 RID: 7065
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x04001B9A RID: 7066
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001B9B RID: 7067
			private static readonly IntPtr NativeMethodInfoPtr__SetPlayerType_b__0_Internal_Boolean_SubscriptionProvider_0;
		}

		// Token: 0x020003B9 RID: 953
		[ObfuscatedName("boardgames.menus.prompts.ConfigureGamePromptBehaviour+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002C6E RID: 11374 RVA: 0x000AD4F8 File Offset: 0x000AB6F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<ConfigureGamePromptBehaviour.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfigureGamePromptBehaviour>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigureGamePromptBehaviour.__c__DisplayClass20_0>.NativeClassPtr);
				ConfigureGamePromptBehaviour.__c__DisplayClass20_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureGamePromptBehaviour.__c__DisplayClass20_0>.NativeClassPtr, "id");
				ConfigureGamePromptBehaviour.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGamePromptBehaviour.__c__DisplayClass20_0>.NativeClassPtr, 100666361);
				ConfigureGamePromptBehaviour.__c__DisplayClass20_0.NativeMethodInfoPtr__GetFriendRosterEntry_b__0_Internal_Boolean_RosterEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGamePromptBehaviour.__c__DisplayClass20_0>.NativeClassPtr, 100666362);
			}

			// Token: 0x06002C6F RID: 11375 RVA: 0x000AD560 File Offset: 0x000AB760
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigureGamePromptBehaviour.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGamePromptBehaviour.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C70 RID: 11376 RVA: 0x000AD59C File Offset: 0x000AB79C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520968, XrefRangeEnd = 520969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetFriendRosterEntry_b__0(RosterEntry f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGamePromptBehaviour.__c__DisplayClass20_0.NativeMethodInfoPtr__GetFriendRosterEntry_b__0_Internal_Boolean_RosterEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002C71 RID: 11377 RVA: 0x00016F9B File Offset: 0x0001519B
			public __c__DisplayClass20_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C98 RID: 3224
			// (get) Token: 0x06002C72 RID: 11378 RVA: 0x000AD5EC File Offset: 0x000AB7EC
			// (set) Token: 0x06002C73 RID: 11379 RVA: 0x00016FA4 File Offset: 0x000151A4
			public unsafe AccountID id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGamePromptBehaviour.__c__DisplayClass20_0.NativeFieldInfoPtr_id);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGamePromptBehaviour.__c__DisplayClass20_0.NativeFieldInfoPtr_id), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B9C RID: 7068
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04001B9D RID: 7069
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001B9E RID: 7070
			private static readonly IntPtr NativeMethodInfoPtr__GetFriendRosterEntry_b__0_Internal_Boolean_RosterEntry_0;
		}

		// Token: 0x020003BA RID: 954
		[ObfuscatedName("boardgames.menus.prompts.ConfigureGamePromptBehaviour+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002C74 RID: 11380 RVA: 0x000AD61C File Offset: 0x000AB81C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<ConfigureGamePromptBehaviour.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfigureGamePromptBehaviour>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigureGamePromptBehaviour.__c__DisplayClass21_0>.NativeClassPtr);
				ConfigureGamePromptBehaviour.__c__DisplayClass21_0.NativeFieldInfoPtr_friendID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureGamePromptBehaviour.__c__DisplayClass21_0>.NativeClassPtr, "friendID");
				ConfigureGamePromptBehaviour.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGamePromptBehaviour.__c__DisplayClass21_0>.NativeClassPtr, 100666363);
				ConfigureGamePromptBehaviour.__c__DisplayClass21_0.NativeMethodInfoPtr__LoadRequiredFriend_b__0_Internal_Boolean_RosterEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGamePromptBehaviour.__c__DisplayClass21_0>.NativeClassPtr, 100666364);
			}

			// Token: 0x06002C75 RID: 11381 RVA: 0x000AD684 File Offset: 0x000AB884
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigureGamePromptBehaviour.__c__DisplayClass21_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGamePromptBehaviour.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C76 RID: 11382 RVA: 0x000AD6C0 File Offset: 0x000AB8C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520969, XrefRangeEnd = 520970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadRequiredFriend_b__0(RosterEntry f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGamePromptBehaviour.__c__DisplayClass21_0.NativeMethodInfoPtr__LoadRequiredFriend_b__0_Internal_Boolean_RosterEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002C77 RID: 11383 RVA: 0x00016FC3 File Offset: 0x000151C3
			public __c__DisplayClass21_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C99 RID: 3225
			// (get) Token: 0x06002C78 RID: 11384 RVA: 0x000AD710 File Offset: 0x000AB910
			// (set) Token: 0x06002C79 RID: 11385 RVA: 0x00016FCC File Offset: 0x000151CC
			public unsafe string friendID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGamePromptBehaviour.__c__DisplayClass21_0.NativeFieldInfoPtr_friendID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGamePromptBehaviour.__c__DisplayClass21_0.NativeFieldInfoPtr_friendID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04001B9F RID: 7071
			private static readonly IntPtr NativeFieldInfoPtr_friendID;

			// Token: 0x04001BA0 RID: 7072
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001BA1 RID: 7073
			private static readonly IntPtr NativeMethodInfoPtr__LoadRequiredFriend_b__0_Internal_Boolean_RosterEntry_0;
		}
	}
}
