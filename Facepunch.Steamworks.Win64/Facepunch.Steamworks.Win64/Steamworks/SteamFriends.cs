using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x0200009F RID: 159
	public class SteamFriends : SteamClientClass<SteamFriends>
	{
		// Token: 0x060008B8 RID: 2232 RVA: 0x00043EA0 File Offset: 0x000420A0
		// Note: this type is marked as 'beforefieldinit'.
		static SteamFriends()
		{
			Il2CppClassPointerStore<SteamFriends>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "SteamFriends");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr);
			SteamFriends.NativeFieldInfoPtr_richPresence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, "richPresence");
			SteamFriends.NativeFieldInfoPtr_OnChatMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, "OnChatMessage");
			SteamFriends.NativeFieldInfoPtr_OnClanChatMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, "OnClanChatMessage");
			SteamFriends.NativeFieldInfoPtr_OnPersonaStateChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, "OnPersonaStateChange");
			SteamFriends.NativeFieldInfoPtr_OnGameRichPresenceJoinRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, "OnGameRichPresenceJoinRequested");
			SteamFriends.NativeFieldInfoPtr_OnGameOverlayActivated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, "OnGameOverlayActivated");
			SteamFriends.NativeFieldInfoPtr_OnGameServerChangeRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, "OnGameServerChangeRequested");
			SteamFriends.NativeFieldInfoPtr_OnGameLobbyJoinRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, "OnGameLobbyJoinRequested");
			SteamFriends.NativeFieldInfoPtr_OnFriendRichPresenceUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, "OnFriendRichPresenceUpdate");
			SteamFriends.NativeFieldInfoPtr_OnOverlayBrowserProtocol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, "OnOverlayBrowserProtocol");
			SteamFriends.NativeFieldInfoPtr__listenForFriendsMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, "_listenForFriendsMessages");
			SteamFriends.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamFriends_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665388);
			SteamFriends.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665389);
			SteamFriends.NativeMethodInfoPtr_InstallEvents_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665390);
			SteamFriends.NativeMethodInfoPtr_add_OnChatMessage_Public_Static_add_Void_Action_3_Friend_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665391);
			SteamFriends.NativeMethodInfoPtr_remove_OnChatMessage_Public_Static_rem_Void_Action_3_Friend_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665392);
			SteamFriends.NativeMethodInfoPtr_add_OnClanChatMessage_Public_Static_add_Void_Action_3_Friend_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665393);
			SteamFriends.NativeMethodInfoPtr_remove_OnClanChatMessage_Public_Static_rem_Void_Action_3_Friend_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665394);
			SteamFriends.NativeMethodInfoPtr_add_OnPersonaStateChange_Public_Static_add_Void_Action_1_Friend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665395);
			SteamFriends.NativeMethodInfoPtr_remove_OnPersonaStateChange_Public_Static_rem_Void_Action_1_Friend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665396);
			SteamFriends.NativeMethodInfoPtr_add_OnGameRichPresenceJoinRequested_Public_Static_add_Void_Action_2_Friend_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665397);
			SteamFriends.NativeMethodInfoPtr_remove_OnGameRichPresenceJoinRequested_Public_Static_rem_Void_Action_2_Friend_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665398);
			SteamFriends.NativeMethodInfoPtr_add_OnGameOverlayActivated_Public_Static_add_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665399);
			SteamFriends.NativeMethodInfoPtr_remove_OnGameOverlayActivated_Public_Static_rem_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665400);
			SteamFriends.NativeMethodInfoPtr_add_OnGameServerChangeRequested_Public_Static_add_Void_Action_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665401);
			SteamFriends.NativeMethodInfoPtr_remove_OnGameServerChangeRequested_Public_Static_rem_Void_Action_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665402);
			SteamFriends.NativeMethodInfoPtr_add_OnGameLobbyJoinRequested_Public_Static_add_Void_Action_2_Lobby_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665403);
			SteamFriends.NativeMethodInfoPtr_remove_OnGameLobbyJoinRequested_Public_Static_rem_Void_Action_2_Lobby_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665404);
			SteamFriends.NativeMethodInfoPtr_add_OnFriendRichPresenceUpdate_Public_Static_add_Void_Action_1_Friend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665405);
			SteamFriends.NativeMethodInfoPtr_remove_OnFriendRichPresenceUpdate_Public_Static_rem_Void_Action_1_Friend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665406);
			SteamFriends.NativeMethodInfoPtr_add_OnOverlayBrowserProtocol_Public_Static_add_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665407);
			SteamFriends.NativeMethodInfoPtr_remove_OnOverlayBrowserProtocol_Public_Static_rem_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665408);
			SteamFriends.NativeMethodInfoPtr_OnFriendChatMessage_Private_Static_Void_GameConnectedFriendChatMsg_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665409);
			SteamFriends.NativeMethodInfoPtr_OnGameConnectedClanChatMessage_Private_Static_Void_GameConnectedClanChatMsg_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665410);
			SteamFriends.NativeMethodInfoPtr_GetFriendsWithFlag_Private_Static_IEnumerable_1_Friend_FriendFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665411);
			SteamFriends.NativeMethodInfoPtr_GetFriends_Public_Static_IEnumerable_1_Friend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665412);
			SteamFriends.NativeMethodInfoPtr_GetBlocked_Public_Static_IEnumerable_1_Friend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665413);
			SteamFriends.NativeMethodInfoPtr_GetFriendsRequested_Public_Static_IEnumerable_1_Friend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665414);
			SteamFriends.NativeMethodInfoPtr_GetFriendsClanMembers_Public_Static_IEnumerable_1_Friend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665415);
			SteamFriends.NativeMethodInfoPtr_GetFriendsOnGameServer_Public_Static_IEnumerable_1_Friend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665416);
			SteamFriends.NativeMethodInfoPtr_GetFriendsRequestingFriendship_Public_Static_IEnumerable_1_Friend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665417);
			SteamFriends.NativeMethodInfoPtr_GetPlayedWith_Public_Static_IEnumerable_1_Friend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665418);
			SteamFriends.NativeMethodInfoPtr_GetFromSource_Public_Static_IEnumerable_1_Friend_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665419);
			SteamFriends.NativeMethodInfoPtr_GetClans_Public_Static_IEnumerable_1_Clan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665420);
			SteamFriends.NativeMethodInfoPtr_OpenOverlay_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665421);
			SteamFriends.NativeMethodInfoPtr_OpenUserOverlay_Public_Static_Void_SteamId_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665422);
			SteamFriends.NativeMethodInfoPtr_OpenStoreOverlay_Public_Static_Void_AppId_OverlayToStoreFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665423);
			SteamFriends.NativeMethodInfoPtr_OpenWebOverlay_Public_Static_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665424);
			SteamFriends.NativeMethodInfoPtr_OpenGameInviteOverlay_Public_Static_Void_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665425);
			SteamFriends.NativeMethodInfoPtr_SetPlayedWith_Public_Static_Void_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665426);
			SteamFriends.NativeMethodInfoPtr_RequestUserInformation_Public_Static_Boolean_SteamId_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665427);
			SteamFriends.NativeMethodInfoPtr_CacheUserInformationAsync_Internal_Static_Task_SteamId_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665428);
			SteamFriends.NativeMethodInfoPtr_GetSmallAvatarAsync_Public_Static_Task_1_Nullable_1_Image_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665429);
			SteamFriends.NativeMethodInfoPtr_GetMediumAvatarAsync_Public_Static_Task_1_Nullable_1_Image_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665430);
			SteamFriends.NativeMethodInfoPtr_GetLargeAvatarAsync_Public_Static_Task_1_Nullable_1_Image_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665431);
			SteamFriends.NativeMethodInfoPtr_GetRichPresence_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665432);
			SteamFriends.NativeMethodInfoPtr_SetRichPresence_Public_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665433);
			SteamFriends.NativeMethodInfoPtr_ClearRichPresence_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665434);
			SteamFriends.NativeMethodInfoPtr_get_ListenForFriendsMessages_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665435);
			SteamFriends.NativeMethodInfoPtr_set_ListenForFriendsMessages_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665436);
			SteamFriends.NativeMethodInfoPtr_IsFollowing_Public_Static_Task_1_Boolean_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665437);
			SteamFriends.NativeMethodInfoPtr_GetFollowerCount_Public_Static_Task_1_Int32_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665438);
			SteamFriends.NativeMethodInfoPtr_GetFollowingList_Public_Static_Task_1_Il2CppStructArray_1_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665439);
			SteamFriends.NativeMethodInfoPtr_RegisterProtocolInOverlayBrowser_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665440);
			SteamFriends.NativeMethodInfoPtr_JoinClanChatRoom_Public_Static_Task_1_Boolean_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665441);
			SteamFriends.NativeMethodInfoPtr_SendClanChatRoomMessage_Public_Static_Boolean_SteamId_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665442);
			SteamFriends.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100665443);
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060008B9 RID: 2233 RVA: 0x0004440C File Offset: 0x0004260C
		public unsafe static ISteamFriends Internal
		{
			[CallerCount(60)]
			[CachedScanResults(RefRangeStart = 938080, RefRangeEnd = 938140, XrefRangeStart = 938077, XrefRangeEnd = 938080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamFriends_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISteamFriends>(intPtr3) : null;
			}
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x00044440 File Offset: 0x00042640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938140, XrefRangeEnd = 938155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeInterface(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref server;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamFriends.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x0004448C File Offset: 0x0004268C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 938308, RefRangeEnd = 938309, XrefRangeStart = 938155, XrefRangeEnd = 938308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InstallEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_InstallEvents_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x000444C0 File Offset: 0x000426C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938309, XrefRangeEnd = 938318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnChatMessage(Action<Friend, string, string> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_add_OnChatMessage_Public_Static_add_Void_Action_3_Friend_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x000444F8 File Offset: 0x000426F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938318, XrefRangeEnd = 938327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnChatMessage(Action<Friend, string, string> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_remove_OnChatMessage_Public_Static_rem_Void_Action_3_Friend_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x00044530 File Offset: 0x00042730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938327, XrefRangeEnd = 938336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnClanChatMessage(Action<Friend, string, string> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_add_OnClanChatMessage_Public_Static_add_Void_Action_3_Friend_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x00044568 File Offset: 0x00042768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938336, XrefRangeEnd = 938345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnClanChatMessage(Action<Friend, string, string> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_remove_OnClanChatMessage_Public_Static_rem_Void_Action_3_Friend_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x000445A0 File Offset: 0x000427A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938345, XrefRangeEnd = 938354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnPersonaStateChange(Action<Friend> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_add_OnPersonaStateChange_Public_Static_add_Void_Action_1_Friend_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x000445D8 File Offset: 0x000427D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938354, XrefRangeEnd = 938363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnPersonaStateChange(Action<Friend> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_remove_OnPersonaStateChange_Public_Static_rem_Void_Action_1_Friend_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x00044610 File Offset: 0x00042810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938363, XrefRangeEnd = 938372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnGameRichPresenceJoinRequested(Action<Friend, string> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_add_OnGameRichPresenceJoinRequested_Public_Static_add_Void_Action_2_Friend_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x00044648 File Offset: 0x00042848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938372, XrefRangeEnd = 938381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnGameRichPresenceJoinRequested(Action<Friend, string> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_remove_OnGameRichPresenceJoinRequested_Public_Static_rem_Void_Action_2_Friend_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00044680 File Offset: 0x00042880
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 938390, RefRangeEnd = 938391, XrefRangeStart = 938381, XrefRangeEnd = 938390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnGameOverlayActivated(Action<bool> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_add_OnGameOverlayActivated_Public_Static_add_Void_Action_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x000446B8 File Offset: 0x000428B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 938400, RefRangeEnd = 938401, XrefRangeStart = 938391, XrefRangeEnd = 938400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnGameOverlayActivated(Action<bool> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_remove_OnGameOverlayActivated_Public_Static_rem_Void_Action_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x000446F0 File Offset: 0x000428F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938401, XrefRangeEnd = 938410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnGameServerChangeRequested(Action<string, string> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_add_OnGameServerChangeRequested_Public_Static_add_Void_Action_2_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00044728 File Offset: 0x00042928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938410, XrefRangeEnd = 938419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnGameServerChangeRequested(Action<string, string> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_remove_OnGameServerChangeRequested_Public_Static_rem_Void_Action_2_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00044760 File Offset: 0x00042960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938419, XrefRangeEnd = 938428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnGameLobbyJoinRequested(Action<Lobby, SteamId> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_add_OnGameLobbyJoinRequested_Public_Static_add_Void_Action_2_Lobby_SteamId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x00044798 File Offset: 0x00042998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938428, XrefRangeEnd = 938437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnGameLobbyJoinRequested(Action<Lobby, SteamId> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_remove_OnGameLobbyJoinRequested_Public_Static_rem_Void_Action_2_Lobby_SteamId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x000447D0 File Offset: 0x000429D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938437, XrefRangeEnd = 938446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnFriendRichPresenceUpdate(Action<Friend> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_add_OnFriendRichPresenceUpdate_Public_Static_add_Void_Action_1_Friend_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x00044808 File Offset: 0x00042A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938446, XrefRangeEnd = 938455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnFriendRichPresenceUpdate(Action<Friend> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_remove_OnFriendRichPresenceUpdate_Public_Static_rem_Void_Action_1_Friend_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00044840 File Offset: 0x00042A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938455, XrefRangeEnd = 938464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnOverlayBrowserProtocol(Action<string> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_add_OnOverlayBrowserProtocol_Public_Static_add_Void_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00044878 File Offset: 0x00042A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938464, XrefRangeEnd = 938473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnOverlayBrowserProtocol(Action<string> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_remove_OnOverlayBrowserProtocol_Public_Static_rem_Void_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x000448B0 File Offset: 0x00042AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938473, XrefRangeEnd = 938508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnFriendChatMessage(GameConnectedFriendChatMsg_t data)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref data;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_OnFriendChatMessage_Private_Static_Void_GameConnectedFriendChatMsg_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x000448E4 File Offset: 0x00042AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938508, XrefRangeEnd = 938544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnGameConnectedClanChatMessage(GameConnectedClanChatMsg_t data)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref data;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_OnGameConnectedClanChatMessage_Private_Static_Void_GameConnectedClanChatMsg_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x00044918 File Offset: 0x00042B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938544, XrefRangeEnd = 938549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Friend> GetFriendsWithFlag(FriendFlags flag)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flag;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetFriendsWithFlag_Private_Static_IEnumerable_1_Friend_FriendFlags_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Friend>>(intPtr3) : null;
			}
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00044958 File Offset: 0x00042B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938549, XrefRangeEnd = 938554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Friend> GetFriends()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetFriends_Public_Static_IEnumerable_1_Friend_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Friend>>(intPtr3) : null;
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x0004498C File Offset: 0x00042B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938554, XrefRangeEnd = 938559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Friend> GetBlocked()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetBlocked_Public_Static_IEnumerable_1_Friend_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Friend>>(intPtr3) : null;
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x000449C0 File Offset: 0x00042BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938559, XrefRangeEnd = 938564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Friend> GetFriendsRequested()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetFriendsRequested_Public_Static_IEnumerable_1_Friend_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Friend>>(intPtr3) : null;
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x000449F4 File Offset: 0x00042BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938564, XrefRangeEnd = 938569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Friend> GetFriendsClanMembers()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetFriendsClanMembers_Public_Static_IEnumerable_1_Friend_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Friend>>(intPtr3) : null;
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x00044A28 File Offset: 0x00042C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938569, XrefRangeEnd = 938574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Friend> GetFriendsOnGameServer()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetFriendsOnGameServer_Public_Static_IEnumerable_1_Friend_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Friend>>(intPtr3) : null;
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x00044A5C File Offset: 0x00042C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938574, XrefRangeEnd = 938579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Friend> GetFriendsRequestingFriendship()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetFriendsRequestingFriendship_Public_Static_IEnumerable_1_Friend_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Friend>>(intPtr3) : null;
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x00044A90 File Offset: 0x00042C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938579, XrefRangeEnd = 938584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Friend> GetPlayedWith()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetPlayedWith_Public_Static_IEnumerable_1_Friend_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Friend>>(intPtr3) : null;
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x00044AC4 File Offset: 0x00042CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938584, XrefRangeEnd = 938589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Friend> GetFromSource(SteamId steamid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetFromSource_Public_Static_IEnumerable_1_Friend_SteamId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Friend>>(intPtr3) : null;
			}
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00044B04 File Offset: 0x00042D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938589, XrefRangeEnd = 938594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Clan> GetClans()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetClans_Public_Static_IEnumerable_1_Clan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Clan>>(intPtr3) : null;
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x00044B38 File Offset: 0x00042D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938594, XrefRangeEnd = 938597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OpenOverlay(string type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_OpenOverlay_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x00044B70 File Offset: 0x00042D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938597, XrefRangeEnd = 938600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OpenUserOverlay(SteamId id, string type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_OpenUserOverlay_Public_Static_Void_SteamId_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x00044BB4 File Offset: 0x00042DB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 938604, RefRangeEnd = 938605, XrefRangeStart = 938600, XrefRangeEnd = 938604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OpenStoreOverlay(AppId id, OverlayToStoreFlag overlayToStoreFlag = OverlayToStoreFlag.None)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overlayToStoreFlag;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_OpenStoreOverlay_Public_Static_Void_AppId_OverlayToStoreFlag_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x00044BF4 File Offset: 0x00042DF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 938608, RefRangeEnd = 938609, XrefRangeStart = 938605, XrefRangeEnd = 938608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OpenWebOverlay(string url, bool modal = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref modal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_OpenWebOverlay_Public_Static_Void_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x00044C38 File Offset: 0x00042E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938609, XrefRangeEnd = 938612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OpenGameInviteOverlay(SteamId lobby)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lobby;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_OpenGameInviteOverlay_Public_Static_Void_SteamId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x00044C6C File Offset: 0x00042E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938612, XrefRangeEnd = 938615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetPlayedWith(SteamId steamid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_SetPlayedWith_Public_Static_Void_SteamId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x00044CA0 File Offset: 0x00042EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938615, XrefRangeEnd = 938618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RequestUserInformation(SteamId steamid, bool nameonly = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamid;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameonly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_RequestUserInformation_Public_Static_Boolean_SteamId_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x00044CEC File Offset: 0x00042EEC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 938627, RefRangeEnd = 938631, XrefRangeStart = 938618, XrefRangeEnd = 938627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task CacheUserInformationAsync(SteamId steamid, bool nameonly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamid;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameonly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_CacheUserInformationAsync_Internal_Static_Task_SteamId_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x00044D3C File Offset: 0x00042F3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 938644, RefRangeEnd = 938645, XrefRangeStart = 938631, XrefRangeEnd = 938644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Nullable<Image>> GetSmallAvatarAsync(SteamId steamid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetSmallAvatarAsync_Public_Static_Task_1_Nullable_1_Image_SteamId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<Image>>>(intPtr3) : null;
			}
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x00044D7C File Offset: 0x00042F7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 938658, RefRangeEnd = 938659, XrefRangeStart = 938645, XrefRangeEnd = 938658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Nullable<Image>> GetMediumAvatarAsync(SteamId steamid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetMediumAvatarAsync_Public_Static_Task_1_Nullable_1_Image_SteamId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<Image>>>(intPtr3) : null;
			}
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x00044DBC File Offset: 0x00042FBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 938672, RefRangeEnd = 938673, XrefRangeStart = 938659, XrefRangeEnd = 938672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Nullable<Image>> GetLargeAvatarAsync(SteamId steamid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetLargeAvatarAsync_Public_Static_Task_1_Nullable_1_Image_SteamId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<Image>>>(intPtr3) : null;
			}
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x00044DFC File Offset: 0x00042FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938673, XrefRangeEnd = 938678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetRichPresence(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetRichPresence_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x00044E38 File Offset: 0x00043038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938678, XrefRangeEnd = 938682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetRichPresence(string key, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_SetRichPresence_Public_Static_Boolean_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x00044E8C File Offset: 0x0004308C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938682, XrefRangeEnd = 938690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearRichPresence()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_ClearRichPresence_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060008E8 RID: 2280 RVA: 0x00044EB4 File Offset: 0x000430B4
		// (set) Token: 0x060008E9 RID: 2281 RVA: 0x00044EE4 File Offset: 0x000430E4
		public unsafe static bool ListenForFriendsMessages
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938690, XrefRangeEnd = 938692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_get_ListenForFriendsMessages_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938692, XrefRangeEnd = 938701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_set_ListenForFriendsMessages_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x00044F18 File Offset: 0x00043118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938701, XrefRangeEnd = 938714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<bool> IsFollowing(SteamId steamID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_IsFollowing_Public_Static_Task_1_Boolean_SteamId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x00044F58 File Offset: 0x00043158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938714, XrefRangeEnd = 938727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<int> GetFollowerCount(SteamId steamID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetFollowerCount_Public_Static_Task_1_Int32_SteamId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
			}
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x00044F98 File Offset: 0x00043198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938727, XrefRangeEnd = 938740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Il2CppStructArray<SteamId>> GetFollowingList()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetFollowingList_Public_Static_Task_1_Il2CppStructArray_1_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Il2CppStructArray<SteamId>>>(intPtr3) : null;
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00044FCC File Offset: 0x000431CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938740, XrefRangeEnd = 938743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RegisterProtocolInOverlayBrowser(string protocol)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(protocol);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_RegisterProtocolInOverlayBrowser_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x00045010 File Offset: 0x00043210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938743, XrefRangeEnd = 938756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<bool> JoinClanChatRoom(SteamId chatId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref chatId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_JoinClanChatRoom_Public_Static_Task_1_Boolean_SteamId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x00045050 File Offset: 0x00043250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938756, XrefRangeEnd = 938759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SendClanChatRoomMessage(SteamId chatId, string message)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref chatId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_SendClanChatRoomMessage_Public_Static_Boolean_SteamId_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x000450A0 File Offset: 0x000432A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938759, XrefRangeEnd = 938762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamFriends()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x000026E0 File Offset: 0x000008E0
		public SteamFriends(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060008F2 RID: 2290 RVA: 0x000450DC File Offset: 0x000432DC
		// (set) Token: 0x060008F3 RID: 2291 RVA: 0x000026E9 File Offset: 0x000008E9
		public unsafe static Dictionary<string, string> richPresence
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamFriends.NativeFieldInfoPtr_richPresence, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamFriends.NativeFieldInfoPtr_richPresence, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060008F4 RID: 2292 RVA: 0x00045104 File Offset: 0x00043304
		// (set) Token: 0x060008F5 RID: 2293 RVA: 0x000026FB File Offset: 0x000008FB
		public unsafe static Action<Friend, string, string> OnChatMessage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamFriends.NativeFieldInfoPtr_OnChatMessage, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Friend, string, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamFriends.NativeFieldInfoPtr_OnChatMessage, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060008F6 RID: 2294 RVA: 0x0004512C File Offset: 0x0004332C
		// (set) Token: 0x060008F7 RID: 2295 RVA: 0x0000270D File Offset: 0x0000090D
		public unsafe static Action<Friend, string, string> OnClanChatMessage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamFriends.NativeFieldInfoPtr_OnClanChatMessage, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Friend, string, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamFriends.NativeFieldInfoPtr_OnClanChatMessage, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060008F8 RID: 2296 RVA: 0x00045154 File Offset: 0x00043354
		// (set) Token: 0x060008F9 RID: 2297 RVA: 0x0000271F File Offset: 0x0000091F
		public unsafe static Action<Friend> OnPersonaStateChange
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamFriends.NativeFieldInfoPtr_OnPersonaStateChange, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Friend>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamFriends.NativeFieldInfoPtr_OnPersonaStateChange, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060008FA RID: 2298 RVA: 0x0004517C File Offset: 0x0004337C
		// (set) Token: 0x060008FB RID: 2299 RVA: 0x00002731 File Offset: 0x00000931
		public unsafe static Action<Friend, string> OnGameRichPresenceJoinRequested
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamFriends.NativeFieldInfoPtr_OnGameRichPresenceJoinRequested, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Friend, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamFriends.NativeFieldInfoPtr_OnGameRichPresenceJoinRequested, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060008FC RID: 2300 RVA: 0x000451A4 File Offset: 0x000433A4
		// (set) Token: 0x060008FD RID: 2301 RVA: 0x00002743 File Offset: 0x00000943
		public unsafe static Action<bool> OnGameOverlayActivated
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamFriends.NativeFieldInfoPtr_OnGameOverlayActivated, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamFriends.NativeFieldInfoPtr_OnGameOverlayActivated, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060008FE RID: 2302 RVA: 0x000451CC File Offset: 0x000433CC
		// (set) Token: 0x060008FF RID: 2303 RVA: 0x00002755 File Offset: 0x00000955
		public unsafe static Action<string, string> OnGameServerChangeRequested
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamFriends.NativeFieldInfoPtr_OnGameServerChangeRequested, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamFriends.NativeFieldInfoPtr_OnGameServerChangeRequested, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000900 RID: 2304 RVA: 0x000451F4 File Offset: 0x000433F4
		// (set) Token: 0x06000901 RID: 2305 RVA: 0x00002767 File Offset: 0x00000967
		public unsafe static Action<Lobby, SteamId> OnGameLobbyJoinRequested
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamFriends.NativeFieldInfoPtr_OnGameLobbyJoinRequested, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Lobby, SteamId>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamFriends.NativeFieldInfoPtr_OnGameLobbyJoinRequested, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000902 RID: 2306 RVA: 0x0004521C File Offset: 0x0004341C
		// (set) Token: 0x06000903 RID: 2307 RVA: 0x00002779 File Offset: 0x00000979
		public unsafe static Action<Friend> OnFriendRichPresenceUpdate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamFriends.NativeFieldInfoPtr_OnFriendRichPresenceUpdate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Friend>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamFriends.NativeFieldInfoPtr_OnFriendRichPresenceUpdate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000904 RID: 2308 RVA: 0x00045244 File Offset: 0x00043444
		// (set) Token: 0x06000905 RID: 2309 RVA: 0x0000278B File Offset: 0x0000098B
		public unsafe static Action<string> OnOverlayBrowserProtocol
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamFriends.NativeFieldInfoPtr_OnOverlayBrowserProtocol, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamFriends.NativeFieldInfoPtr_OnOverlayBrowserProtocol, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000906 RID: 2310 RVA: 0x0004526C File Offset: 0x0004346C
		// (set) Token: 0x06000907 RID: 2311 RVA: 0x0000279D File Offset: 0x0000099D
		public unsafe static bool _listenForFriendsMessages
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(SteamFriends.NativeFieldInfoPtr__listenForFriendsMessages, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamFriends.NativeFieldInfoPtr__listenForFriendsMessages, (void*)(&value));
			}
		}

		// Token: 0x04000FDC RID: 4060
		private static readonly IntPtr NativeFieldInfoPtr_richPresence;

		// Token: 0x04000FDD RID: 4061
		private static readonly IntPtr NativeFieldInfoPtr_OnChatMessage;

		// Token: 0x04000FDE RID: 4062
		private static readonly IntPtr NativeFieldInfoPtr_OnClanChatMessage;

		// Token: 0x04000FDF RID: 4063
		private static readonly IntPtr NativeFieldInfoPtr_OnPersonaStateChange;

		// Token: 0x04000FE0 RID: 4064
		private static readonly IntPtr NativeFieldInfoPtr_OnGameRichPresenceJoinRequested;

		// Token: 0x04000FE1 RID: 4065
		private static readonly IntPtr NativeFieldInfoPtr_OnGameOverlayActivated;

		// Token: 0x04000FE2 RID: 4066
		private static readonly IntPtr NativeFieldInfoPtr_OnGameServerChangeRequested;

		// Token: 0x04000FE3 RID: 4067
		private static readonly IntPtr NativeFieldInfoPtr_OnGameLobbyJoinRequested;

		// Token: 0x04000FE4 RID: 4068
		private static readonly IntPtr NativeFieldInfoPtr_OnFriendRichPresenceUpdate;

		// Token: 0x04000FE5 RID: 4069
		private static readonly IntPtr NativeFieldInfoPtr_OnOverlayBrowserProtocol;

		// Token: 0x04000FE6 RID: 4070
		private static readonly IntPtr NativeFieldInfoPtr__listenForFriendsMessages;

		// Token: 0x04000FE7 RID: 4071
		private static readonly IntPtr NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamFriends_0;

		// Token: 0x04000FE8 RID: 4072
		private static readonly IntPtr NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0;

		// Token: 0x04000FE9 RID: 4073
		private static readonly IntPtr NativeMethodInfoPtr_InstallEvents_Internal_Void_0;

		// Token: 0x04000FEA RID: 4074
		private static readonly IntPtr NativeMethodInfoPtr_add_OnChatMessage_Public_Static_add_Void_Action_3_Friend_String_String_0;

		// Token: 0x04000FEB RID: 4075
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnChatMessage_Public_Static_rem_Void_Action_3_Friend_String_String_0;

		// Token: 0x04000FEC RID: 4076
		private static readonly IntPtr NativeMethodInfoPtr_add_OnClanChatMessage_Public_Static_add_Void_Action_3_Friend_String_String_0;

		// Token: 0x04000FED RID: 4077
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnClanChatMessage_Public_Static_rem_Void_Action_3_Friend_String_String_0;

		// Token: 0x04000FEE RID: 4078
		private static readonly IntPtr NativeMethodInfoPtr_add_OnPersonaStateChange_Public_Static_add_Void_Action_1_Friend_0;

		// Token: 0x04000FEF RID: 4079
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnPersonaStateChange_Public_Static_rem_Void_Action_1_Friend_0;

		// Token: 0x04000FF0 RID: 4080
		private static readonly IntPtr NativeMethodInfoPtr_add_OnGameRichPresenceJoinRequested_Public_Static_add_Void_Action_2_Friend_String_0;

		// Token: 0x04000FF1 RID: 4081
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnGameRichPresenceJoinRequested_Public_Static_rem_Void_Action_2_Friend_String_0;

		// Token: 0x04000FF2 RID: 4082
		private static readonly IntPtr NativeMethodInfoPtr_add_OnGameOverlayActivated_Public_Static_add_Void_Action_1_Boolean_0;

		// Token: 0x04000FF3 RID: 4083
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnGameOverlayActivated_Public_Static_rem_Void_Action_1_Boolean_0;

		// Token: 0x04000FF4 RID: 4084
		private static readonly IntPtr NativeMethodInfoPtr_add_OnGameServerChangeRequested_Public_Static_add_Void_Action_2_String_String_0;

		// Token: 0x04000FF5 RID: 4085
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnGameServerChangeRequested_Public_Static_rem_Void_Action_2_String_String_0;

		// Token: 0x04000FF6 RID: 4086
		private static readonly IntPtr NativeMethodInfoPtr_add_OnGameLobbyJoinRequested_Public_Static_add_Void_Action_2_Lobby_SteamId_0;

		// Token: 0x04000FF7 RID: 4087
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnGameLobbyJoinRequested_Public_Static_rem_Void_Action_2_Lobby_SteamId_0;

		// Token: 0x04000FF8 RID: 4088
		private static readonly IntPtr NativeMethodInfoPtr_add_OnFriendRichPresenceUpdate_Public_Static_add_Void_Action_1_Friend_0;

		// Token: 0x04000FF9 RID: 4089
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnFriendRichPresenceUpdate_Public_Static_rem_Void_Action_1_Friend_0;

		// Token: 0x04000FFA RID: 4090
		private static readonly IntPtr NativeMethodInfoPtr_add_OnOverlayBrowserProtocol_Public_Static_add_Void_Action_1_String_0;

		// Token: 0x04000FFB RID: 4091
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnOverlayBrowserProtocol_Public_Static_rem_Void_Action_1_String_0;

		// Token: 0x04000FFC RID: 4092
		private static readonly IntPtr NativeMethodInfoPtr_OnFriendChatMessage_Private_Static_Void_GameConnectedFriendChatMsg_t_0;

		// Token: 0x04000FFD RID: 4093
		private static readonly IntPtr NativeMethodInfoPtr_OnGameConnectedClanChatMessage_Private_Static_Void_GameConnectedClanChatMsg_t_0;

		// Token: 0x04000FFE RID: 4094
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendsWithFlag_Private_Static_IEnumerable_1_Friend_FriendFlags_0;

		// Token: 0x04000FFF RID: 4095
		private static readonly IntPtr NativeMethodInfoPtr_GetFriends_Public_Static_IEnumerable_1_Friend_0;

		// Token: 0x04001000 RID: 4096
		private static readonly IntPtr NativeMethodInfoPtr_GetBlocked_Public_Static_IEnumerable_1_Friend_0;

		// Token: 0x04001001 RID: 4097
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendsRequested_Public_Static_IEnumerable_1_Friend_0;

		// Token: 0x04001002 RID: 4098
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendsClanMembers_Public_Static_IEnumerable_1_Friend_0;

		// Token: 0x04001003 RID: 4099
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendsOnGameServer_Public_Static_IEnumerable_1_Friend_0;

		// Token: 0x04001004 RID: 4100
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendsRequestingFriendship_Public_Static_IEnumerable_1_Friend_0;

		// Token: 0x04001005 RID: 4101
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayedWith_Public_Static_IEnumerable_1_Friend_0;

		// Token: 0x04001006 RID: 4102
		private static readonly IntPtr NativeMethodInfoPtr_GetFromSource_Public_Static_IEnumerable_1_Friend_SteamId_0;

		// Token: 0x04001007 RID: 4103
		private static readonly IntPtr NativeMethodInfoPtr_GetClans_Public_Static_IEnumerable_1_Clan_0;

		// Token: 0x04001008 RID: 4104
		private static readonly IntPtr NativeMethodInfoPtr_OpenOverlay_Public_Static_Void_String_0;

		// Token: 0x04001009 RID: 4105
		private static readonly IntPtr NativeMethodInfoPtr_OpenUserOverlay_Public_Static_Void_SteamId_String_0;

		// Token: 0x0400100A RID: 4106
		private static readonly IntPtr NativeMethodInfoPtr_OpenStoreOverlay_Public_Static_Void_AppId_OverlayToStoreFlag_0;

		// Token: 0x0400100B RID: 4107
		private static readonly IntPtr NativeMethodInfoPtr_OpenWebOverlay_Public_Static_Void_String_Boolean_0;

		// Token: 0x0400100C RID: 4108
		private static readonly IntPtr NativeMethodInfoPtr_OpenGameInviteOverlay_Public_Static_Void_SteamId_0;

		// Token: 0x0400100D RID: 4109
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayedWith_Public_Static_Void_SteamId_0;

		// Token: 0x0400100E RID: 4110
		private static readonly IntPtr NativeMethodInfoPtr_RequestUserInformation_Public_Static_Boolean_SteamId_Boolean_0;

		// Token: 0x0400100F RID: 4111
		private static readonly IntPtr NativeMethodInfoPtr_CacheUserInformationAsync_Internal_Static_Task_SteamId_Boolean_0;

		// Token: 0x04001010 RID: 4112
		private static readonly IntPtr NativeMethodInfoPtr_GetSmallAvatarAsync_Public_Static_Task_1_Nullable_1_Image_SteamId_0;

		// Token: 0x04001011 RID: 4113
		private static readonly IntPtr NativeMethodInfoPtr_GetMediumAvatarAsync_Public_Static_Task_1_Nullable_1_Image_SteamId_0;

		// Token: 0x04001012 RID: 4114
		private static readonly IntPtr NativeMethodInfoPtr_GetLargeAvatarAsync_Public_Static_Task_1_Nullable_1_Image_SteamId_0;

		// Token: 0x04001013 RID: 4115
		private static readonly IntPtr NativeMethodInfoPtr_GetRichPresence_Public_Static_String_String_0;

		// Token: 0x04001014 RID: 4116
		private static readonly IntPtr NativeMethodInfoPtr_SetRichPresence_Public_Static_Boolean_String_String_0;

		// Token: 0x04001015 RID: 4117
		private static readonly IntPtr NativeMethodInfoPtr_ClearRichPresence_Public_Static_Void_0;

		// Token: 0x04001016 RID: 4118
		private static readonly IntPtr NativeMethodInfoPtr_get_ListenForFriendsMessages_Public_Static_get_Boolean_0;

		// Token: 0x04001017 RID: 4119
		private static readonly IntPtr NativeMethodInfoPtr_set_ListenForFriendsMessages_Public_Static_set_Void_Boolean_0;

		// Token: 0x04001018 RID: 4120
		private static readonly IntPtr NativeMethodInfoPtr_IsFollowing_Public_Static_Task_1_Boolean_SteamId_0;

		// Token: 0x04001019 RID: 4121
		private static readonly IntPtr NativeMethodInfoPtr_GetFollowerCount_Public_Static_Task_1_Int32_SteamId_0;

		// Token: 0x0400101A RID: 4122
		private static readonly IntPtr NativeMethodInfoPtr_GetFollowingList_Public_Static_Task_1_Il2CppStructArray_1_SteamId_0;

		// Token: 0x0400101B RID: 4123
		private static readonly IntPtr NativeMethodInfoPtr_RegisterProtocolInOverlayBrowser_Public_Static_Boolean_String_0;

		// Token: 0x0400101C RID: 4124
		private static readonly IntPtr NativeMethodInfoPtr_JoinClanChatRoom_Public_Static_Task_1_Boolean_SteamId_0;

		// Token: 0x0400101D RID: 4125
		private static readonly IntPtr NativeMethodInfoPtr_SendClanChatRoomMessage_Public_Static_Boolean_SteamId_String_0;

		// Token: 0x0400101E RID: 4126
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000222 RID: 546
		[ObfuscatedName("Steamworks.SteamFriends+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001B68 RID: 7016 RVA: 0x00081F1C File Offset: 0x0008011C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SteamFriends.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamFriends.__c>.NativeClassPtr);
				SteamFriends.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends.__c>.NativeClassPtr, "<>9");
				SteamFriends.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends.__c>.NativeClassPtr, "<>9__4_0");
				SteamFriends.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends.__c>.NativeClassPtr, "<>9__4_1");
				SteamFriends.__c.NativeFieldInfoPtr___9__4_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends.__c>.NativeClassPtr, "<>9__4_2");
				SteamFriends.__c.NativeFieldInfoPtr___9__4_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends.__c>.NativeClassPtr, "<>9__4_3");
				SteamFriends.__c.NativeFieldInfoPtr___9__4_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends.__c>.NativeClassPtr, "<>9__4_4");
				SteamFriends.__c.NativeFieldInfoPtr___9__4_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends.__c>.NativeClassPtr, "<>9__4_5");
				SteamFriends.__c.NativeFieldInfoPtr___9__4_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends.__c>.NativeClassPtr, "<>9__4_6");
				SteamFriends.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends.__c>.NativeClassPtr, 100665445);
				SteamFriends.__c.NativeMethodInfoPtr__InstallEvents_b__4_0_Internal_Void_PersonaStateChange_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends.__c>.NativeClassPtr, 100665446);
				SteamFriends.__c.NativeMethodInfoPtr__InstallEvents_b__4_1_Internal_Void_GameRichPresenceJoinRequested_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends.__c>.NativeClassPtr, 100665447);
				SteamFriends.__c.NativeMethodInfoPtr__InstallEvents_b__4_2_Internal_Void_GameOverlayActivated_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends.__c>.NativeClassPtr, 100665448);
				SteamFriends.__c.NativeMethodInfoPtr__InstallEvents_b__4_3_Internal_Void_GameServerChangeRequested_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends.__c>.NativeClassPtr, 100665449);
				SteamFriends.__c.NativeMethodInfoPtr__InstallEvents_b__4_4_Internal_Void_GameLobbyJoinRequested_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends.__c>.NativeClassPtr, 100665450);
				SteamFriends.__c.NativeMethodInfoPtr__InstallEvents_b__4_5_Internal_Void_FriendRichPresenceUpdate_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends.__c>.NativeClassPtr, 100665451);
				SteamFriends.__c.NativeMethodInfoPtr__InstallEvents_b__4_6_Internal_Void_OverlayBrowserProtocolNavigation_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends.__c>.NativeClassPtr, 100665452);
			}

			// Token: 0x06001B69 RID: 7017 RVA: 0x00082088 File Offset: 0x00080288
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamFriends.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B6A RID: 7018 RVA: 0x000820C4 File Offset: 0x000802C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937690, XrefRangeEnd = 937693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__4_0(PersonaStateChange_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.__c.NativeMethodInfoPtr__InstallEvents_b__4_0_Internal_Void_PersonaStateChange_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B6B RID: 7019 RVA: 0x00082104 File Offset: 0x00080304
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937693, XrefRangeEnd = 937700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__4_1(GameRichPresenceJoinRequested_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.__c.NativeMethodInfoPtr__InstallEvents_b__4_1_Internal_Void_GameRichPresenceJoinRequested_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B6C RID: 7020 RVA: 0x0008214C File Offset: 0x0008034C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937700, XrefRangeEnd = 937702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__4_2(GameOverlayActivated_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.__c.NativeMethodInfoPtr__InstallEvents_b__4_2_Internal_Void_GameOverlayActivated_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B6D RID: 7021 RVA: 0x0008218C File Offset: 0x0008038C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937702, XrefRangeEnd = 937709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__4_3(GameServerChangeRequested_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.__c.NativeMethodInfoPtr__InstallEvents_b__4_3_Internal_Void_GameServerChangeRequested_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B6E RID: 7022 RVA: 0x000821D4 File Offset: 0x000803D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937709, XrefRangeEnd = 937714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__4_4(GameLobbyJoinRequested_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.__c.NativeMethodInfoPtr__InstallEvents_b__4_4_Internal_Void_GameLobbyJoinRequested_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B6F RID: 7023 RVA: 0x00082214 File Offset: 0x00080414
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937714, XrefRangeEnd = 937717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__4_5(FriendRichPresenceUpdate_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.__c.NativeMethodInfoPtr__InstallEvents_b__4_5_Internal_Void_FriendRichPresenceUpdate_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B70 RID: 7024 RVA: 0x00082254 File Offset: 0x00080454
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937717, XrefRangeEnd = 937723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__4_6(OverlayBrowserProtocolNavigation_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.__c.NativeMethodInfoPtr__InstallEvents_b__4_6_Internal_Void_OverlayBrowserProtocolNavigation_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B71 RID: 7025 RVA: 0x000091DC File Offset: 0x000073DC
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006C4 RID: 1732
			// (get) Token: 0x06001B72 RID: 7026 RVA: 0x0008229C File Offset: 0x0008049C
			// (set) Token: 0x06001B73 RID: 7027 RVA: 0x000091E5 File Offset: 0x000073E5
			public unsafe static SteamFriends.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamFriends.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SteamFriends.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamFriends.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006C5 RID: 1733
			// (get) Token: 0x06001B74 RID: 7028 RVA: 0x000822C4 File Offset: 0x000804C4
			// (set) Token: 0x06001B75 RID: 7029 RVA: 0x000091F7 File Offset: 0x000073F7
			public unsafe static Action<PersonaStateChange_t> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamFriends.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<PersonaStateChange_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamFriends.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006C6 RID: 1734
			// (get) Token: 0x06001B76 RID: 7030 RVA: 0x000822EC File Offset: 0x000804EC
			// (set) Token: 0x06001B77 RID: 7031 RVA: 0x00009209 File Offset: 0x00007409
			public unsafe static Action<GameRichPresenceJoinRequested_t> __9__4_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamFriends.__c.NativeFieldInfoPtr___9__4_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GameRichPresenceJoinRequested_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamFriends.__c.NativeFieldInfoPtr___9__4_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006C7 RID: 1735
			// (get) Token: 0x06001B78 RID: 7032 RVA: 0x00082314 File Offset: 0x00080514
			// (set) Token: 0x06001B79 RID: 7033 RVA: 0x0000921B File Offset: 0x0000741B
			public unsafe static Action<GameOverlayActivated_t> __9__4_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamFriends.__c.NativeFieldInfoPtr___9__4_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GameOverlayActivated_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamFriends.__c.NativeFieldInfoPtr___9__4_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006C8 RID: 1736
			// (get) Token: 0x06001B7A RID: 7034 RVA: 0x0008233C File Offset: 0x0008053C
			// (set) Token: 0x06001B7B RID: 7035 RVA: 0x0000922D File Offset: 0x0000742D
			public unsafe static Action<GameServerChangeRequested_t> __9__4_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamFriends.__c.NativeFieldInfoPtr___9__4_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GameServerChangeRequested_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamFriends.__c.NativeFieldInfoPtr___9__4_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006C9 RID: 1737
			// (get) Token: 0x06001B7C RID: 7036 RVA: 0x00082364 File Offset: 0x00080564
			// (set) Token: 0x06001B7D RID: 7037 RVA: 0x0000923F File Offset: 0x0000743F
			public unsafe static Action<GameLobbyJoinRequested_t> __9__4_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamFriends.__c.NativeFieldInfoPtr___9__4_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GameLobbyJoinRequested_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamFriends.__c.NativeFieldInfoPtr___9__4_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006CA RID: 1738
			// (get) Token: 0x06001B7E RID: 7038 RVA: 0x0008238C File Offset: 0x0008058C
			// (set) Token: 0x06001B7F RID: 7039 RVA: 0x00009251 File Offset: 0x00007451
			public unsafe static Action<FriendRichPresenceUpdate_t> __9__4_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamFriends.__c.NativeFieldInfoPtr___9__4_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<FriendRichPresenceUpdate_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamFriends.__c.NativeFieldInfoPtr___9__4_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006CB RID: 1739
			// (get) Token: 0x06001B80 RID: 7040 RVA: 0x000823B4 File Offset: 0x000805B4
			// (set) Token: 0x06001B81 RID: 7041 RVA: 0x00009263 File Offset: 0x00007463
			public unsafe static Action<OverlayBrowserProtocolNavigation_t> __9__4_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamFriends.__c.NativeFieldInfoPtr___9__4_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<OverlayBrowserProtocolNavigation_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamFriends.__c.NativeFieldInfoPtr___9__4_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002013 RID: 8211
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002014 RID: 8212
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x04002015 RID: 8213
			private static readonly IntPtr NativeFieldInfoPtr___9__4_1;

			// Token: 0x04002016 RID: 8214
			private static readonly IntPtr NativeFieldInfoPtr___9__4_2;

			// Token: 0x04002017 RID: 8215
			private static readonly IntPtr NativeFieldInfoPtr___9__4_3;

			// Token: 0x04002018 RID: 8216
			private static readonly IntPtr NativeFieldInfoPtr___9__4_4;

			// Token: 0x04002019 RID: 8217
			private static readonly IntPtr NativeFieldInfoPtr___9__4_5;

			// Token: 0x0400201A RID: 8218
			private static readonly IntPtr NativeFieldInfoPtr___9__4_6;

			// Token: 0x0400201B RID: 8219
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400201C RID: 8220
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__4_0_Internal_Void_PersonaStateChange_t_0;

			// Token: 0x0400201D RID: 8221
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__4_1_Internal_Void_GameRichPresenceJoinRequested_t_0;

			// Token: 0x0400201E RID: 8222
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__4_2_Internal_Void_GameOverlayActivated_t_0;

			// Token: 0x0400201F RID: 8223
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__4_3_Internal_Void_GameServerChangeRequested_t_0;

			// Token: 0x04002020 RID: 8224
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__4_4_Internal_Void_GameLobbyJoinRequested_t_0;

			// Token: 0x04002021 RID: 8225
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__4_5_Internal_Void_FriendRichPresenceUpdate_t_0;

			// Token: 0x04002022 RID: 8226
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__4_6_Internal_Void_OverlayBrowserProtocolNavigation_t_0;
		}

		// Token: 0x02000223 RID: 547
		[ObfuscatedName("Steamworks.SteamFriends+<>c__DisplayClass64_0")]
		public sealed class __c__DisplayClass64_0 : Object
		{
			// Token: 0x06001B82 RID: 7042 RVA: 0x000823DC File Offset: 0x000805DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass64_0()
			{
				Il2CppClassPointerStore<SteamFriends.__c__DisplayClass64_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, "<>c__DisplayClass64_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamFriends.__c__DisplayClass64_0>.NativeClassPtr);
				SteamFriends.__c__DisplayClass64_0.NativeFieldInfoPtr_steamIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends.__c__DisplayClass64_0>.NativeClassPtr, "steamIds");
				SteamFriends.__c__DisplayClass64_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends.__c__DisplayClass64_0>.NativeClassPtr, 100665453);
				SteamFriends.__c__DisplayClass64_0.NativeMethodInfoPtr__GetFollowingList_b__0_Internal_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends.__c__DisplayClass64_0>.NativeClassPtr, 100665454);
			}

			// Token: 0x06001B83 RID: 7043 RVA: 0x00082444 File Offset: 0x00080644
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass64_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamFriends.__c__DisplayClass64_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.__c__DisplayClass64_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B84 RID: 7044 RVA: 0x00082480 File Offset: 0x00080680
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937723, XrefRangeEnd = 937727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetFollowingList_b__0(ulong id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref id;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.__c__DisplayClass64_0.NativeMethodInfoPtr__GetFollowingList_b__0_Internal_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B85 RID: 7045 RVA: 0x00009275 File Offset: 0x00007475
			public __c__DisplayClass64_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006CC RID: 1740
			// (get) Token: 0x06001B86 RID: 7046 RVA: 0x000824C0 File Offset: 0x000806C0
			// (set) Token: 0x06001B87 RID: 7047 RVA: 0x0000927E File Offset: 0x0000747E
			public unsafe List<SteamId> steamIds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends.__c__DisplayClass64_0.NativeFieldInfoPtr_steamIds);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SteamId>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends.__c__DisplayClass64_0.NativeFieldInfoPtr_steamIds), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002023 RID: 8227
			private static readonly IntPtr NativeFieldInfoPtr_steamIds;

			// Token: 0x04002024 RID: 8228
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002025 RID: 8229
			private static readonly IntPtr NativeMethodInfoPtr__GetFollowingList_b__0_Internal_Void_UInt64_0;
		}

		// Token: 0x02000224 RID: 548
		[ObfuscatedName("Steamworks.SteamFriends+<CacheUserInformationAsync>d__51")]
		public sealed class _CacheUserInformationAsync_d__51 : ValueType
		{
			// Token: 0x06001B88 RID: 7048 RVA: 0x000824F0 File Offset: 0x000806F0
			// Note: this type is marked as 'beforefieldinit'.
			static _CacheUserInformationAsync_d__51()
			{
				Il2CppClassPointerStore<SteamFriends._CacheUserInformationAsync_d__51>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, "<CacheUserInformationAsync>d__51");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamFriends._CacheUserInformationAsync_d__51>.NativeClassPtr);
				SteamFriends._CacheUserInformationAsync_d__51.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._CacheUserInformationAsync_d__51>.NativeClassPtr, "<>1__state");
				SteamFriends._CacheUserInformationAsync_d__51.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._CacheUserInformationAsync_d__51>.NativeClassPtr, "<>t__builder");
				SteamFriends._CacheUserInformationAsync_d__51.NativeFieldInfoPtr_steamid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._CacheUserInformationAsync_d__51>.NativeClassPtr, "steamid");
				SteamFriends._CacheUserInformationAsync_d__51.NativeFieldInfoPtr_nameonly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._CacheUserInformationAsync_d__51>.NativeClassPtr, "nameonly");
				SteamFriends._CacheUserInformationAsync_d__51.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._CacheUserInformationAsync_d__51>.NativeClassPtr, "<>u__1");
				SteamFriends._CacheUserInformationAsync_d__51.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._CacheUserInformationAsync_d__51>.NativeClassPtr, 100665455);
				SteamFriends._CacheUserInformationAsync_d__51.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._CacheUserInformationAsync_d__51>.NativeClassPtr, 100665456);
			}

			// Token: 0x06001B89 RID: 7049 RVA: 0x000825A8 File Offset: 0x000807A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937727, XrefRangeEnd = 937770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._CacheUserInformationAsync_d__51.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B8A RID: 7050 RVA: 0x000825E0 File Offset: 0x000807E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937770, XrefRangeEnd = 937774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._CacheUserInformationAsync_d__51.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B8B RID: 7051 RVA: 0x0000929D File Offset: 0x0000749D
			public _CacheUserInformationAsync_d__51(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001B8C RID: 7052 RVA: 0x000092A6 File Offset: 0x000074A6
			public _CacheUserInformationAsync_d__51()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamFriends._CacheUserInformationAsync_d__51>.NativeClassPtr))
			{
			}

			// Token: 0x170006CD RID: 1741
			// (get) Token: 0x06001B8D RID: 7053 RVA: 0x00082628 File Offset: 0x00080828
			// (set) Token: 0x06001B8E RID: 7054 RVA: 0x000092B8 File Offset: 0x000074B8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._CacheUserInformationAsync_d__51.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._CacheUserInformationAsync_d__51.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006CE RID: 1742
			// (get) Token: 0x06001B8F RID: 7055 RVA: 0x00082650 File Offset: 0x00080850
			// (set) Token: 0x06001B90 RID: 7056 RVA: 0x000092D3 File Offset: 0x000074D3
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._CacheUserInformationAsync_d__51.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._CacheUserInformationAsync_d__51.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006CF RID: 1743
			// (get) Token: 0x06001B91 RID: 7057 RVA: 0x00082680 File Offset: 0x00080880
			// (set) Token: 0x06001B92 RID: 7058 RVA: 0x00009301 File Offset: 0x00007501
			public unsafe SteamId steamid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._CacheUserInformationAsync_d__51.NativeFieldInfoPtr_steamid);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._CacheUserInformationAsync_d__51.NativeFieldInfoPtr_steamid)) = value;
				}
			}

			// Token: 0x170006D0 RID: 1744
			// (get) Token: 0x06001B93 RID: 7059 RVA: 0x000826A8 File Offset: 0x000808A8
			// (set) Token: 0x06001B94 RID: 7060 RVA: 0x0000931C File Offset: 0x0000751C
			public unsafe bool nameonly
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._CacheUserInformationAsync_d__51.NativeFieldInfoPtr_nameonly);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._CacheUserInformationAsync_d__51.NativeFieldInfoPtr_nameonly)) = value;
				}
			}

			// Token: 0x170006D1 RID: 1745
			// (get) Token: 0x06001B95 RID: 7061 RVA: 0x000826D0 File Offset: 0x000808D0
			// (set) Token: 0x06001B96 RID: 7062 RVA: 0x00009337 File Offset: 0x00007537
			public TaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._CacheUserInformationAsync_d__51.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._CacheUserInformationAsync_d__51.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002026 RID: 8230
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002027 RID: 8231
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002028 RID: 8232
			private static readonly IntPtr NativeFieldInfoPtr_steamid;

			// Token: 0x04002029 RID: 8233
			private static readonly IntPtr NativeFieldInfoPtr_nameonly;

			// Token: 0x0400202A RID: 8234
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400202B RID: 8235
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400202C RID: 8236
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000225 RID: 549
		[ObfuscatedName("Steamworks.SteamFriends+<GetClans>d__43")]
		public sealed class _GetClans_d__43 : Object
		{
			// Token: 0x06001B97 RID: 7063 RVA: 0x00082700 File Offset: 0x00080900
			// Note: this type is marked as 'beforefieldinit'.
			static _GetClans_d__43()
			{
				Il2CppClassPointerStore<SteamFriends._GetClans_d__43>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, "<GetClans>d__43");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamFriends._GetClans_d__43>.NativeClassPtr);
				SteamFriends._GetClans_d__43.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._GetClans_d__43>.NativeClassPtr, "<>1__state");
				SteamFriends._GetClans_d__43.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._GetClans_d__43>.NativeClassPtr, "<>2__current");
				SteamFriends._GetClans_d__43.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._GetClans_d__43>.NativeClassPtr, "<>l__initialThreadId");
				SteamFriends._GetClans_d__43.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._GetClans_d__43>.NativeClassPtr, "<i>5__2");
				SteamFriends._GetClans_d__43.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._GetClans_d__43>.NativeClassPtr, 100665457);
				SteamFriends._GetClans_d__43.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._GetClans_d__43>.NativeClassPtr, 100665458);
				SteamFriends._GetClans_d__43.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._GetClans_d__43>.NativeClassPtr, 100665459);
				SteamFriends._GetClans_d__43.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Steamworks_Clan__get_Current_Private_Virtual_Final_New_get_Clan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._GetClans_d__43>.NativeClassPtr, 100665460);
				SteamFriends._GetClans_d__43.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._GetClans_d__43>.NativeClassPtr, 100665461);
				SteamFriends._GetClans_d__43.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._GetClans_d__43>.NativeClassPtr, 100665462);
				SteamFriends._GetClans_d__43.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Steamworks_Clan__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Clan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._GetClans_d__43>.NativeClassPtr, 100665463);
				SteamFriends._GetClans_d__43.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._GetClans_d__43>.NativeClassPtr, 100665464);
			}

			// Token: 0x06001B98 RID: 7064 RVA: 0x0008281C File Offset: 0x00080A1C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetClans_d__43(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamFriends._GetClans_d__43>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._GetClans_d__43.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B99 RID: 7065 RVA: 0x00082864 File Offset: 0x00080A64
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._GetClans_d__43.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B9A RID: 7066 RVA: 0x00082898 File Offset: 0x00080A98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937774, XrefRangeEnd = 937779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._GetClans_d__43.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170006D6 RID: 1750
			// (get) Token: 0x06001B9B RID: 7067 RVA: 0x000828D4 File Offset: 0x00080AD4
			public unsafe Clan System.Collections.Generic.IEnumerator<Steamworks.Clan>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._GetClans_d__43.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Steamworks_Clan__get_Current_Private_Virtual_Final_New_get_Clan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001B9C RID: 7068 RVA: 0x00082910 File Offset: 0x00080B10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937779, XrefRangeEnd = 937784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._GetClans_d__43.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170006D7 RID: 1751
			// (get) Token: 0x06001B9D RID: 7069 RVA: 0x00082944 File Offset: 0x00080B44
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937784, XrefRangeEnd = 937787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._GetClans_d__43.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001B9E RID: 7070 RVA: 0x00082984 File Offset: 0x00080B84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937787, XrefRangeEnd = 937789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Clan> System_Collections_Generic_IEnumerable_Steamworks_Clan__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._GetClans_d__43.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Steamworks_Clan__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Clan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Clan>>(intPtr3) : null;
			}

			// Token: 0x06001B9F RID: 7071 RVA: 0x000829C4 File Offset: 0x00080BC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._GetClans_d__43.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001BA0 RID: 7072 RVA: 0x00009365 File Offset: 0x00007565
			public _GetClans_d__43(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006D2 RID: 1746
			// (get) Token: 0x06001BA1 RID: 7073 RVA: 0x00082A04 File Offset: 0x00080C04
			// (set) Token: 0x06001BA2 RID: 7074 RVA: 0x0000936E File Offset: 0x0000756E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetClans_d__43.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetClans_d__43.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006D3 RID: 1747
			// (get) Token: 0x06001BA3 RID: 7075 RVA: 0x00082A2C File Offset: 0x00080C2C
			// (set) Token: 0x06001BA4 RID: 7076 RVA: 0x00009389 File Offset: 0x00007589
			public unsafe Clan __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetClans_d__43.NativeFieldInfoPtr___2__current);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetClans_d__43.NativeFieldInfoPtr___2__current)) = value;
				}
			}

			// Token: 0x170006D4 RID: 1748
			// (get) Token: 0x06001BA5 RID: 7077 RVA: 0x00082A54 File Offset: 0x00080C54
			// (set) Token: 0x06001BA6 RID: 7078 RVA: 0x000093A4 File Offset: 0x000075A4
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetClans_d__43.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetClans_d__43.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170006D5 RID: 1749
			// (get) Token: 0x06001BA7 RID: 7079 RVA: 0x00082A7C File Offset: 0x00080C7C
			// (set) Token: 0x06001BA8 RID: 7080 RVA: 0x000093BF File Offset: 0x000075BF
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetClans_d__43.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetClans_d__43.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x0400202D RID: 8237
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400202E RID: 8238
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400202F RID: 8239
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002030 RID: 8240
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x04002031 RID: 8241
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002032 RID: 8242
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002033 RID: 8243
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002034 RID: 8244
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Steamworks_Clan__get_Current_Private_Virtual_Final_New_get_Clan_0;

			// Token: 0x04002035 RID: 8245
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002036 RID: 8246
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002037 RID: 8247
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Steamworks_Clan__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Clan_0;

			// Token: 0x04002038 RID: 8248
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000226 RID: 550
		[ObfuscatedName("Steamworks.SteamFriends+<GetFollowerCount>d__63")]
		public sealed class _GetFollowerCount_d__63 : ValueType
		{
			// Token: 0x06001BA9 RID: 7081 RVA: 0x00082AA4 File Offset: 0x00080CA4
			// Note: this type is marked as 'beforefieldinit'.
			static _GetFollowerCount_d__63()
			{
				Il2CppClassPointerStore<SteamFriends._GetFollowerCount_d__63>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, "<GetFollowerCount>d__63");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamFriends._GetFollowerCount_d__63>.NativeClassPtr);
				SteamFriends._GetFollowerCount_d__63.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._GetFollowerCount_d__63>.NativeClassPtr, "<>1__state");
				SteamFriends._GetFollowerCount_d__63.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._GetFollowerCount_d__63>.NativeClassPtr, "<>t__builder");
				SteamFriends._GetFollowerCount_d__63.NativeFieldInfoPtr_steamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._GetFollowerCount_d__63>.NativeClassPtr, "steamID");
				SteamFriends._GetFollowerCount_d__63.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._GetFollowerCount_d__63>.NativeClassPtr, "<>u__1");
				SteamFriends._GetFollowerCount_d__63.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._GetFollowerCount_d__63>.NativeClassPtr, 100665465);
				SteamFriends._GetFollowerCount_d__63.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._GetFollowerCount_d__63>.NativeClassPtr, 100665466);
			}

			// Token: 0x06001BAA RID: 7082 RVA: 0x00082B48 File Offset: 0x00080D48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937789, XrefRangeEnd = 937811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._GetFollowerCount_d__63.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BAB RID: 7083 RVA: 0x00082B80 File Offset: 0x00080D80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937811, XrefRangeEnd = 937817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._GetFollowerCount_d__63.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001BAC RID: 7084 RVA: 0x000093DA File Offset: 0x000075DA
			public _GetFollowerCount_d__63(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001BAD RID: 7085 RVA: 0x000093E3 File Offset: 0x000075E3
			public _GetFollowerCount_d__63()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamFriends._GetFollowerCount_d__63>.NativeClassPtr))
			{
			}

			// Token: 0x170006D8 RID: 1752
			// (get) Token: 0x06001BAE RID: 7086 RVA: 0x00082BC8 File Offset: 0x00080DC8
			// (set) Token: 0x06001BAF RID: 7087 RVA: 0x000093F5 File Offset: 0x000075F5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetFollowerCount_d__63.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetFollowerCount_d__63.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006D9 RID: 1753
			// (get) Token: 0x06001BB0 RID: 7088 RVA: 0x00082BF0 File Offset: 0x00080DF0
			// (set) Token: 0x06001BB1 RID: 7089 RVA: 0x00009410 File Offset: 0x00007610
			public AsyncTaskMethodBuilder<int> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetFollowerCount_d__63.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetFollowerCount_d__63.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006DA RID: 1754
			// (get) Token: 0x06001BB2 RID: 7090 RVA: 0x00082C20 File Offset: 0x00080E20
			// (set) Token: 0x06001BB3 RID: 7091 RVA: 0x0000943E File Offset: 0x0000763E
			public unsafe SteamId steamID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetFollowerCount_d__63.NativeFieldInfoPtr_steamID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetFollowerCount_d__63.NativeFieldInfoPtr_steamID)) = value;
				}
			}

			// Token: 0x170006DB RID: 1755
			// (get) Token: 0x06001BB4 RID: 7092 RVA: 0x00082C48 File Offset: 0x00080E48
			// (set) Token: 0x06001BB5 RID: 7093 RVA: 0x00009459 File Offset: 0x00007659
			public CallResult<FriendsGetFollowerCount_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetFollowerCount_d__63.NativeFieldInfoPtr___u__1);
					return new CallResult<FriendsGetFollowerCount_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<FriendsGetFollowerCount_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetFollowerCount_d__63.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<FriendsGetFollowerCount_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002039 RID: 8249
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400203A RID: 8250
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400203B RID: 8251
			private static readonly IntPtr NativeFieldInfoPtr_steamID;

			// Token: 0x0400203C RID: 8252
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400203D RID: 8253
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400203E RID: 8254
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000227 RID: 551
		[ObfuscatedName("Steamworks.SteamFriends+<GetFollowingList>d__64")]
		public sealed class _GetFollowingList_d__64 : ValueType
		{
			// Token: 0x06001BB6 RID: 7094 RVA: 0x00082C78 File Offset: 0x00080E78
			// Note: this type is marked as 'beforefieldinit'.
			static _GetFollowingList_d__64()
			{
				Il2CppClassPointerStore<SteamFriends._GetFollowingList_d__64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, "<GetFollowingList>d__64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamFriends._GetFollowingList_d__64>.NativeClassPtr);
				SteamFriends._GetFollowingList_d__64.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._GetFollowingList_d__64>.NativeClassPtr, "<>1__state");
				SteamFriends._GetFollowingList_d__64.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._GetFollowingList_d__64>.NativeClassPtr, "<>t__builder");
				SteamFriends._GetFollowingList_d__64.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._GetFollowingList_d__64>.NativeClassPtr, "<>8__1");
				SteamFriends._GetFollowingList_d__64.NativeFieldInfoPtr__resultCount_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._GetFollowingList_d__64>.NativeClassPtr, "<resultCount>5__2");
				SteamFriends._GetFollowingList_d__64.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._GetFollowingList_d__64>.NativeClassPtr, "<>u__1");
				SteamFriends._GetFollowingList_d__64.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._GetFollowingList_d__64>.NativeClassPtr, 100665467);
				SteamFriends._GetFollowingList_d__64.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._GetFollowingList_d__64>.NativeClassPtr, 100665468);
			}

			// Token: 0x06001BB7 RID: 7095 RVA: 0x00082D30 File Offset: 0x00080F30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937817, XrefRangeEnd = 937869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._GetFollowingList_d__64.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BB8 RID: 7096 RVA: 0x00082D68 File Offset: 0x00080F68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937869, XrefRangeEnd = 937875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._GetFollowingList_d__64.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001BB9 RID: 7097 RVA: 0x00009487 File Offset: 0x00007687
			public _GetFollowingList_d__64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001BBA RID: 7098 RVA: 0x00009490 File Offset: 0x00007690
			public _GetFollowingList_d__64()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamFriends._GetFollowingList_d__64>.NativeClassPtr))
			{
			}

			// Token: 0x170006DC RID: 1756
			// (get) Token: 0x06001BBB RID: 7099 RVA: 0x00082DB0 File Offset: 0x00080FB0
			// (set) Token: 0x06001BBC RID: 7100 RVA: 0x000094A2 File Offset: 0x000076A2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetFollowingList_d__64.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetFollowingList_d__64.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006DD RID: 1757
			// (get) Token: 0x06001BBD RID: 7101 RVA: 0x00082DD8 File Offset: 0x00080FD8
			// (set) Token: 0x06001BBE RID: 7102 RVA: 0x000094BD File Offset: 0x000076BD
			public AsyncTaskMethodBuilder<Il2CppStructArray<SteamId>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetFollowingList_d__64.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Il2CppStructArray<SteamId>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppStructArray<SteamId>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetFollowingList_d__64.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppStructArray<SteamId>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006DE RID: 1758
			// (get) Token: 0x06001BBF RID: 7103 RVA: 0x00082E08 File Offset: 0x00081008
			// (set) Token: 0x06001BC0 RID: 7104 RVA: 0x000094EB File Offset: 0x000076EB
			public unsafe SteamFriends.__c__DisplayClass64_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetFollowingList_d__64.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SteamFriends.__c__DisplayClass64_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetFollowingList_d__64.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006DF RID: 1759
			// (get) Token: 0x06001BC1 RID: 7105 RVA: 0x00082E38 File Offset: 0x00081038
			// (set) Token: 0x06001BC2 RID: 7106 RVA: 0x0000950A File Offset: 0x0000770A
			public unsafe int _resultCount_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetFollowingList_d__64.NativeFieldInfoPtr__resultCount_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetFollowingList_d__64.NativeFieldInfoPtr__resultCount_5__2)) = value;
				}
			}

			// Token: 0x170006E0 RID: 1760
			// (get) Token: 0x06001BC3 RID: 7107 RVA: 0x00082E60 File Offset: 0x00081060
			// (set) Token: 0x06001BC4 RID: 7108 RVA: 0x00009525 File Offset: 0x00007725
			public CallResult<FriendsEnumerateFollowingList_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetFollowingList_d__64.NativeFieldInfoPtr___u__1);
					return new CallResult<FriendsEnumerateFollowingList_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<FriendsEnumerateFollowingList_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetFollowingList_d__64.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<FriendsEnumerateFollowingList_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400203F RID: 8255
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002040 RID: 8256
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002041 RID: 8257
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04002042 RID: 8258
			private static readonly IntPtr NativeFieldInfoPtr__resultCount_5__2;

			// Token: 0x04002043 RID: 8259
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002044 RID: 8260
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002045 RID: 8261
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000228 RID: 552
		[ObfuscatedName("Steamworks.SteamFriends+<GetFriendsWithFlag>d__34")]
		public sealed class _GetFriendsWithFlag_d__34 : Object
		{
			// Token: 0x06001BC5 RID: 7109 RVA: 0x00082E90 File Offset: 0x00081090
			// Note: this type is marked as 'beforefieldinit'.
			static _GetFriendsWithFlag_d__34()
			{
				Il2CppClassPointerStore<SteamFriends._GetFriendsWithFlag_d__34>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, "<GetFriendsWithFlag>d__34");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamFriends._GetFriendsWithFlag_d__34>.NativeClassPtr);
				SteamFriends._GetFriendsWithFlag_d__34.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._GetFriendsWithFlag_d__34>.NativeClassPtr, "<>1__state");
				SteamFriends._GetFriendsWithFlag_d__34.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._GetFriendsWithFlag_d__34>.NativeClassPtr, "<>2__current");
				SteamFriends._GetFriendsWithFlag_d__34.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._GetFriendsWithFlag_d__34>.NativeClassPtr, "<>l__initialThreadId");
				SteamFriends._GetFriendsWithFlag_d__34.NativeFieldInfoPtr_flag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._GetFriendsWithFlag_d__34>.NativeClassPtr, "flag");
				SteamFriends._GetFriendsWithFlag_d__34.NativeFieldInfoPtr___3__flag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._GetFriendsWithFlag_d__34>.NativeClassPtr, "<>3__flag");
				SteamFriends._GetFriendsWithFlag_d__34.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._GetFriendsWithFlag_d__34>.NativeClassPtr, "<i>5__2");
				SteamFriends._GetFriendsWithFlag_d__34.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._GetFriendsWithFlag_d__34>.NativeClassPtr, 100665469);
				SteamFriends._GetFriendsWithFlag_d__34.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._GetFriendsWithFlag_d__34>.NativeClassPtr, 100665470);
				SteamFriends._GetFriendsWithFlag_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._GetFriendsWithFlag_d__34>.NativeClassPtr, 100665471);
				SteamFriends._GetFriendsWithFlag_d__34.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Steamworks_Friend__get_Current_Private_Virtual_Final_New_get_Friend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._GetFriendsWithFlag_d__34>.NativeClassPtr, 100665472);
				SteamFriends._GetFriendsWithFlag_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._GetFriendsWithFlag_d__34>.NativeClassPtr, 100665473);
				SteamFriends._GetFriendsWithFlag_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._GetFriendsWithFlag_d__34>.NativeClassPtr, 100665474);
				SteamFriends._GetFriendsWithFlag_d__34.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Steamworks_Friend__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Friend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._GetFriendsWithFlag_d__34>.NativeClassPtr, 100665475);
				SteamFriends._GetFriendsWithFlag_d__34.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._GetFriendsWithFlag_d__34>.NativeClassPtr, 100665476);
			}

			// Token: 0x06001BC6 RID: 7110 RVA: 0x00082FD4 File Offset: 0x000811D4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetFriendsWithFlag_d__34(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamFriends._GetFriendsWithFlag_d__34>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._GetFriendsWithFlag_d__34.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001BC7 RID: 7111 RVA: 0x0008301C File Offset: 0x0008121C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._GetFriendsWithFlag_d__34.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BC8 RID: 7112 RVA: 0x00083050 File Offset: 0x00081250
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937875, XrefRangeEnd = 937880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._GetFriendsWithFlag_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170006E7 RID: 1767
			// (get) Token: 0x06001BC9 RID: 7113 RVA: 0x0008308C File Offset: 0x0008128C
			public unsafe Friend System.Collections.Generic.IEnumerator<Steamworks.Friend>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._GetFriendsWithFlag_d__34.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Steamworks_Friend__get_Current_Private_Virtual_Final_New_get_Friend_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001BCA RID: 7114 RVA: 0x000830C8 File Offset: 0x000812C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937880, XrefRangeEnd = 937885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._GetFriendsWithFlag_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170006E8 RID: 1768
			// (get) Token: 0x06001BCB RID: 7115 RVA: 0x000830FC File Offset: 0x000812FC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937885, XrefRangeEnd = 937888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._GetFriendsWithFlag_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001BCC RID: 7116 RVA: 0x0008313C File Offset: 0x0008133C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937888, XrefRangeEnd = 937895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Friend> System_Collections_Generic_IEnumerable_Steamworks_Friend__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._GetFriendsWithFlag_d__34.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Steamworks_Friend__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Friend_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Friend>>(intPtr3) : null;
			}

			// Token: 0x06001BCD RID: 7117 RVA: 0x0008317C File Offset: 0x0008137C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._GetFriendsWithFlag_d__34.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001BCE RID: 7118 RVA: 0x00009553 File Offset: 0x00007753
			public _GetFriendsWithFlag_d__34(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006E1 RID: 1761
			// (get) Token: 0x06001BCF RID: 7119 RVA: 0x000831BC File Offset: 0x000813BC
			// (set) Token: 0x06001BD0 RID: 7120 RVA: 0x0000955C File Offset: 0x0000775C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetFriendsWithFlag_d__34.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetFriendsWithFlag_d__34.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006E2 RID: 1762
			// (get) Token: 0x06001BD1 RID: 7121 RVA: 0x000831E4 File Offset: 0x000813E4
			// (set) Token: 0x06001BD2 RID: 7122 RVA: 0x00009577 File Offset: 0x00007777
			public unsafe Friend __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetFriendsWithFlag_d__34.NativeFieldInfoPtr___2__current);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetFriendsWithFlag_d__34.NativeFieldInfoPtr___2__current)) = value;
				}
			}

			// Token: 0x170006E3 RID: 1763
			// (get) Token: 0x06001BD3 RID: 7123 RVA: 0x0008320C File Offset: 0x0008140C
			// (set) Token: 0x06001BD4 RID: 7124 RVA: 0x00009592 File Offset: 0x00007792
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetFriendsWithFlag_d__34.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetFriendsWithFlag_d__34.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170006E4 RID: 1764
			// (get) Token: 0x06001BD5 RID: 7125 RVA: 0x00083234 File Offset: 0x00081434
			// (set) Token: 0x06001BD6 RID: 7126 RVA: 0x000095AD File Offset: 0x000077AD
			public unsafe FriendFlags flag
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetFriendsWithFlag_d__34.NativeFieldInfoPtr_flag);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetFriendsWithFlag_d__34.NativeFieldInfoPtr_flag)) = value;
				}
			}

			// Token: 0x170006E5 RID: 1765
			// (get) Token: 0x06001BD7 RID: 7127 RVA: 0x0008325C File Offset: 0x0008145C
			// (set) Token: 0x06001BD8 RID: 7128 RVA: 0x000095C8 File Offset: 0x000077C8
			public unsafe FriendFlags __3__flag
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetFriendsWithFlag_d__34.NativeFieldInfoPtr___3__flag);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetFriendsWithFlag_d__34.NativeFieldInfoPtr___3__flag)) = value;
				}
			}

			// Token: 0x170006E6 RID: 1766
			// (get) Token: 0x06001BD9 RID: 7129 RVA: 0x00083284 File Offset: 0x00081484
			// (set) Token: 0x06001BDA RID: 7130 RVA: 0x000095E3 File Offset: 0x000077E3
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetFriendsWithFlag_d__34.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetFriendsWithFlag_d__34.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x04002046 RID: 8262
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002047 RID: 8263
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002048 RID: 8264
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002049 RID: 8265
			private static readonly IntPtr NativeFieldInfoPtr_flag;

			// Token: 0x0400204A RID: 8266
			private static readonly IntPtr NativeFieldInfoPtr___3__flag;

			// Token: 0x0400204B RID: 8267
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x0400204C RID: 8268
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400204D RID: 8269
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400204E RID: 8270
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400204F RID: 8271
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Steamworks_Friend__get_Current_Private_Virtual_Final_New_get_Friend_0;

			// Token: 0x04002050 RID: 8272
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002051 RID: 8273
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002052 RID: 8274
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Steamworks_Friend__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Friend_0;

			// Token: 0x04002053 RID: 8275
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000229 RID: 553
		[ObfuscatedName("Steamworks.SteamFriends+<GetFromSource>d__42")]
		public sealed class _GetFromSource_d__42 : Object
		{
			// Token: 0x06001BDB RID: 7131 RVA: 0x000832AC File Offset: 0x000814AC
			// Note: this type is marked as 'beforefieldinit'.
			static _GetFromSource_d__42()
			{
				Il2CppClassPointerStore<SteamFriends._GetFromSource_d__42>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, "<GetFromSource>d__42");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamFriends._GetFromSource_d__42>.NativeClassPtr);
				SteamFriends._GetFromSource_d__42.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._GetFromSource_d__42>.NativeClassPtr, "<>1__state");
				SteamFriends._GetFromSource_d__42.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._GetFromSource_d__42>.NativeClassPtr, "<>2__current");
				SteamFriends._GetFromSource_d__42.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._GetFromSource_d__42>.NativeClassPtr, "<>l__initialThreadId");
				SteamFriends._GetFromSource_d__42.NativeFieldInfoPtr_steamid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._GetFromSource_d__42>.NativeClassPtr, "steamid");
				SteamFriends._GetFromSource_d__42.NativeFieldInfoPtr___3__steamid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._GetFromSource_d__42>.NativeClassPtr, "<>3__steamid");
				SteamFriends._GetFromSource_d__42.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._GetFromSource_d__42>.NativeClassPtr, "<i>5__2");
				SteamFriends._GetFromSource_d__42.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._GetFromSource_d__42>.NativeClassPtr, 100665477);
				SteamFriends._GetFromSource_d__42.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._GetFromSource_d__42>.NativeClassPtr, 100665478);
				SteamFriends._GetFromSource_d__42.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._GetFromSource_d__42>.NativeClassPtr, 100665479);
				SteamFriends._GetFromSource_d__42.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Steamworks_Friend__get_Current_Private_Virtual_Final_New_get_Friend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._GetFromSource_d__42>.NativeClassPtr, 100665480);
				SteamFriends._GetFromSource_d__42.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._GetFromSource_d__42>.NativeClassPtr, 100665481);
				SteamFriends._GetFromSource_d__42.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._GetFromSource_d__42>.NativeClassPtr, 100665482);
				SteamFriends._GetFromSource_d__42.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Steamworks_Friend__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Friend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._GetFromSource_d__42>.NativeClassPtr, 100665483);
				SteamFriends._GetFromSource_d__42.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._GetFromSource_d__42>.NativeClassPtr, 100665484);
			}

			// Token: 0x06001BDC RID: 7132 RVA: 0x000833F0 File Offset: 0x000815F0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetFromSource_d__42(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamFriends._GetFromSource_d__42>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._GetFromSource_d__42.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001BDD RID: 7133 RVA: 0x00083438 File Offset: 0x00081638
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._GetFromSource_d__42.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BDE RID: 7134 RVA: 0x0008346C File Offset: 0x0008166C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937895, XrefRangeEnd = 937900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._GetFromSource_d__42.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170006EF RID: 1775
			// (get) Token: 0x06001BDF RID: 7135 RVA: 0x000834A8 File Offset: 0x000816A8
			public unsafe Friend System.Collections.Generic.IEnumerator<Steamworks.Friend>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._GetFromSource_d__42.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Steamworks_Friend__get_Current_Private_Virtual_Final_New_get_Friend_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001BE0 RID: 7136 RVA: 0x000834E4 File Offset: 0x000816E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937900, XrefRangeEnd = 937905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._GetFromSource_d__42.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170006F0 RID: 1776
			// (get) Token: 0x06001BE1 RID: 7137 RVA: 0x00083518 File Offset: 0x00081718
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937905, XrefRangeEnd = 937908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._GetFromSource_d__42.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001BE2 RID: 7138 RVA: 0x00083558 File Offset: 0x00081758
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937908, XrefRangeEnd = 937915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Friend> System_Collections_Generic_IEnumerable_Steamworks_Friend__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._GetFromSource_d__42.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Steamworks_Friend__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Friend_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Friend>>(intPtr3) : null;
			}

			// Token: 0x06001BE3 RID: 7139 RVA: 0x00083598 File Offset: 0x00081798
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._GetFromSource_d__42.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001BE4 RID: 7140 RVA: 0x000095FE File Offset: 0x000077FE
			public _GetFromSource_d__42(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006E9 RID: 1769
			// (get) Token: 0x06001BE5 RID: 7141 RVA: 0x000835D8 File Offset: 0x000817D8
			// (set) Token: 0x06001BE6 RID: 7142 RVA: 0x00009607 File Offset: 0x00007807
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetFromSource_d__42.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetFromSource_d__42.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006EA RID: 1770
			// (get) Token: 0x06001BE7 RID: 7143 RVA: 0x00083600 File Offset: 0x00081800
			// (set) Token: 0x06001BE8 RID: 7144 RVA: 0x00009622 File Offset: 0x00007822
			public unsafe Friend __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetFromSource_d__42.NativeFieldInfoPtr___2__current);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetFromSource_d__42.NativeFieldInfoPtr___2__current)) = value;
				}
			}

			// Token: 0x170006EB RID: 1771
			// (get) Token: 0x06001BE9 RID: 7145 RVA: 0x00083628 File Offset: 0x00081828
			// (set) Token: 0x06001BEA RID: 7146 RVA: 0x0000963D File Offset: 0x0000783D
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetFromSource_d__42.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetFromSource_d__42.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170006EC RID: 1772
			// (get) Token: 0x06001BEB RID: 7147 RVA: 0x00083650 File Offset: 0x00081850
			// (set) Token: 0x06001BEC RID: 7148 RVA: 0x00009658 File Offset: 0x00007858
			public unsafe SteamId steamid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetFromSource_d__42.NativeFieldInfoPtr_steamid);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetFromSource_d__42.NativeFieldInfoPtr_steamid)) = value;
				}
			}

			// Token: 0x170006ED RID: 1773
			// (get) Token: 0x06001BED RID: 7149 RVA: 0x00083678 File Offset: 0x00081878
			// (set) Token: 0x06001BEE RID: 7150 RVA: 0x00009673 File Offset: 0x00007873
			public unsafe SteamId __3__steamid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetFromSource_d__42.NativeFieldInfoPtr___3__steamid);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetFromSource_d__42.NativeFieldInfoPtr___3__steamid)) = value;
				}
			}

			// Token: 0x170006EE RID: 1774
			// (get) Token: 0x06001BEF RID: 7151 RVA: 0x000836A0 File Offset: 0x000818A0
			// (set) Token: 0x06001BF0 RID: 7152 RVA: 0x0000968E File Offset: 0x0000788E
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetFromSource_d__42.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetFromSource_d__42.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x04002054 RID: 8276
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002055 RID: 8277
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002056 RID: 8278
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002057 RID: 8279
			private static readonly IntPtr NativeFieldInfoPtr_steamid;

			// Token: 0x04002058 RID: 8280
			private static readonly IntPtr NativeFieldInfoPtr___3__steamid;

			// Token: 0x04002059 RID: 8281
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x0400205A RID: 8282
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400205B RID: 8283
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400205C RID: 8284
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400205D RID: 8285
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Steamworks_Friend__get_Current_Private_Virtual_Final_New_get_Friend_0;

			// Token: 0x0400205E RID: 8286
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400205F RID: 8287
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002060 RID: 8288
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Steamworks_Friend__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Friend_0;

			// Token: 0x04002061 RID: 8289
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200022A RID: 554
		[ObfuscatedName("Steamworks.SteamFriends+<GetLargeAvatarAsync>d__54")]
		public sealed class _GetLargeAvatarAsync_d__54 : ValueType
		{
			// Token: 0x06001BF1 RID: 7153 RVA: 0x000836C8 File Offset: 0x000818C8
			// Note: this type is marked as 'beforefieldinit'.
			static _GetLargeAvatarAsync_d__54()
			{
				Il2CppClassPointerStore<SteamFriends._GetLargeAvatarAsync_d__54>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, "<GetLargeAvatarAsync>d__54");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamFriends._GetLargeAvatarAsync_d__54>.NativeClassPtr);
				SteamFriends._GetLargeAvatarAsync_d__54.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._GetLargeAvatarAsync_d__54>.NativeClassPtr, "<>1__state");
				SteamFriends._GetLargeAvatarAsync_d__54.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._GetLargeAvatarAsync_d__54>.NativeClassPtr, "<>t__builder");
				SteamFriends._GetLargeAvatarAsync_d__54.NativeFieldInfoPtr_steamid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._GetLargeAvatarAsync_d__54>.NativeClassPtr, "steamid");
				SteamFriends._GetLargeAvatarAsync_d__54.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._GetLargeAvatarAsync_d__54>.NativeClassPtr, "<>u__1");
				SteamFriends._GetLargeAvatarAsync_d__54.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._GetLargeAvatarAsync_d__54>.NativeClassPtr, 100665485);
				SteamFriends._GetLargeAvatarAsync_d__54.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._GetLargeAvatarAsync_d__54>.NativeClassPtr, 100665486);
			}

			// Token: 0x06001BF2 RID: 7154 RVA: 0x0008376C File Offset: 0x0008196C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937915, XrefRangeEnd = 937950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._GetLargeAvatarAsync_d__54.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BF3 RID: 7155 RVA: 0x000837A4 File Offset: 0x000819A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937950, XrefRangeEnd = 937956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._GetLargeAvatarAsync_d__54.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001BF4 RID: 7156 RVA: 0x000096A9 File Offset: 0x000078A9
			public _GetLargeAvatarAsync_d__54(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001BF5 RID: 7157 RVA: 0x000096B2 File Offset: 0x000078B2
			public _GetLargeAvatarAsync_d__54()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamFriends._GetLargeAvatarAsync_d__54>.NativeClassPtr))
			{
			}

			// Token: 0x170006F1 RID: 1777
			// (get) Token: 0x06001BF6 RID: 7158 RVA: 0x000837EC File Offset: 0x000819EC
			// (set) Token: 0x06001BF7 RID: 7159 RVA: 0x000096C4 File Offset: 0x000078C4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetLargeAvatarAsync_d__54.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetLargeAvatarAsync_d__54.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006F2 RID: 1778
			// (get) Token: 0x06001BF8 RID: 7160 RVA: 0x00083814 File Offset: 0x00081A14
			// (set) Token: 0x06001BF9 RID: 7161 RVA: 0x000096DF File Offset: 0x000078DF
			public AsyncTaskMethodBuilder<Nullable<Image>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetLargeAvatarAsync_d__54.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Nullable<Image>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<Image>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetLargeAvatarAsync_d__54.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<Image>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006F3 RID: 1779
			// (get) Token: 0x06001BFA RID: 7162 RVA: 0x00083844 File Offset: 0x00081A44
			// (set) Token: 0x06001BFB RID: 7163 RVA: 0x0000970D File Offset: 0x0000790D
			public unsafe SteamId steamid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetLargeAvatarAsync_d__54.NativeFieldInfoPtr_steamid);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetLargeAvatarAsync_d__54.NativeFieldInfoPtr_steamid)) = value;
				}
			}

			// Token: 0x170006F4 RID: 1780
			// (get) Token: 0x06001BFC RID: 7164 RVA: 0x0008386C File Offset: 0x00081A6C
			// (set) Token: 0x06001BFD RID: 7165 RVA: 0x00009728 File Offset: 0x00007928
			public TaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetLargeAvatarAsync_d__54.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetLargeAvatarAsync_d__54.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002062 RID: 8290
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002063 RID: 8291
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002064 RID: 8292
			private static readonly IntPtr NativeFieldInfoPtr_steamid;

			// Token: 0x04002065 RID: 8293
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002066 RID: 8294
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002067 RID: 8295
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200022B RID: 555
		[ObfuscatedName("Steamworks.SteamFriends+<GetMediumAvatarAsync>d__53")]
		public sealed class _GetMediumAvatarAsync_d__53 : ValueType
		{
			// Token: 0x06001BFE RID: 7166 RVA: 0x0008389C File Offset: 0x00081A9C
			// Note: this type is marked as 'beforefieldinit'.
			static _GetMediumAvatarAsync_d__53()
			{
				Il2CppClassPointerStore<SteamFriends._GetMediumAvatarAsync_d__53>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, "<GetMediumAvatarAsync>d__53");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamFriends._GetMediumAvatarAsync_d__53>.NativeClassPtr);
				SteamFriends._GetMediumAvatarAsync_d__53.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._GetMediumAvatarAsync_d__53>.NativeClassPtr, "<>1__state");
				SteamFriends._GetMediumAvatarAsync_d__53.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._GetMediumAvatarAsync_d__53>.NativeClassPtr, "<>t__builder");
				SteamFriends._GetMediumAvatarAsync_d__53.NativeFieldInfoPtr_steamid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._GetMediumAvatarAsync_d__53>.NativeClassPtr, "steamid");
				SteamFriends._GetMediumAvatarAsync_d__53.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._GetMediumAvatarAsync_d__53>.NativeClassPtr, "<>u__1");
				SteamFriends._GetMediumAvatarAsync_d__53.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._GetMediumAvatarAsync_d__53>.NativeClassPtr, 100665487);
				SteamFriends._GetMediumAvatarAsync_d__53.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._GetMediumAvatarAsync_d__53>.NativeClassPtr, 100665488);
			}

			// Token: 0x06001BFF RID: 7167 RVA: 0x00083940 File Offset: 0x00081B40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937956, XrefRangeEnd = 937974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._GetMediumAvatarAsync_d__53.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C00 RID: 7168 RVA: 0x00083978 File Offset: 0x00081B78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937974, XrefRangeEnd = 937980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._GetMediumAvatarAsync_d__53.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C01 RID: 7169 RVA: 0x00009756 File Offset: 0x00007956
			public _GetMediumAvatarAsync_d__53(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001C02 RID: 7170 RVA: 0x0000975F File Offset: 0x0000795F
			public _GetMediumAvatarAsync_d__53()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamFriends._GetMediumAvatarAsync_d__53>.NativeClassPtr))
			{
			}

			// Token: 0x170006F5 RID: 1781
			// (get) Token: 0x06001C03 RID: 7171 RVA: 0x000839C0 File Offset: 0x00081BC0
			// (set) Token: 0x06001C04 RID: 7172 RVA: 0x00009771 File Offset: 0x00007971
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetMediumAvatarAsync_d__53.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetMediumAvatarAsync_d__53.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006F6 RID: 1782
			// (get) Token: 0x06001C05 RID: 7173 RVA: 0x000839E8 File Offset: 0x00081BE8
			// (set) Token: 0x06001C06 RID: 7174 RVA: 0x0000978C File Offset: 0x0000798C
			public AsyncTaskMethodBuilder<Nullable<Image>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetMediumAvatarAsync_d__53.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Nullable<Image>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<Image>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetMediumAvatarAsync_d__53.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<Image>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006F7 RID: 1783
			// (get) Token: 0x06001C07 RID: 7175 RVA: 0x00083A18 File Offset: 0x00081C18
			// (set) Token: 0x06001C08 RID: 7176 RVA: 0x000097BA File Offset: 0x000079BA
			public unsafe SteamId steamid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetMediumAvatarAsync_d__53.NativeFieldInfoPtr_steamid);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetMediumAvatarAsync_d__53.NativeFieldInfoPtr_steamid)) = value;
				}
			}

			// Token: 0x170006F8 RID: 1784
			// (get) Token: 0x06001C09 RID: 7177 RVA: 0x00083A40 File Offset: 0x00081C40
			// (set) Token: 0x06001C0A RID: 7178 RVA: 0x000097D5 File Offset: 0x000079D5
			public TaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetMediumAvatarAsync_d__53.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetMediumAvatarAsync_d__53.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002068 RID: 8296
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002069 RID: 8297
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400206A RID: 8298
			private static readonly IntPtr NativeFieldInfoPtr_steamid;

			// Token: 0x0400206B RID: 8299
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400206C RID: 8300
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400206D RID: 8301
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200022C RID: 556
		[ObfuscatedName("Steamworks.SteamFriends+<GetPlayedWith>d__41")]
		public sealed class _GetPlayedWith_d__41 : Object
		{
			// Token: 0x06001C0B RID: 7179 RVA: 0x00083A70 File Offset: 0x00081C70
			// Note: this type is marked as 'beforefieldinit'.
			static _GetPlayedWith_d__41()
			{
				Il2CppClassPointerStore<SteamFriends._GetPlayedWith_d__41>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, "<GetPlayedWith>d__41");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamFriends._GetPlayedWith_d__41>.NativeClassPtr);
				SteamFriends._GetPlayedWith_d__41.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._GetPlayedWith_d__41>.NativeClassPtr, "<>1__state");
				SteamFriends._GetPlayedWith_d__41.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._GetPlayedWith_d__41>.NativeClassPtr, "<>2__current");
				SteamFriends._GetPlayedWith_d__41.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._GetPlayedWith_d__41>.NativeClassPtr, "<>l__initialThreadId");
				SteamFriends._GetPlayedWith_d__41.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._GetPlayedWith_d__41>.NativeClassPtr, "<i>5__2");
				SteamFriends._GetPlayedWith_d__41.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._GetPlayedWith_d__41>.NativeClassPtr, 100665489);
				SteamFriends._GetPlayedWith_d__41.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._GetPlayedWith_d__41>.NativeClassPtr, 100665490);
				SteamFriends._GetPlayedWith_d__41.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._GetPlayedWith_d__41>.NativeClassPtr, 100665491);
				SteamFriends._GetPlayedWith_d__41.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Steamworks_Friend__get_Current_Private_Virtual_Final_New_get_Friend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._GetPlayedWith_d__41>.NativeClassPtr, 100665492);
				SteamFriends._GetPlayedWith_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._GetPlayedWith_d__41>.NativeClassPtr, 100665493);
				SteamFriends._GetPlayedWith_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._GetPlayedWith_d__41>.NativeClassPtr, 100665494);
				SteamFriends._GetPlayedWith_d__41.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Steamworks_Friend__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Friend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._GetPlayedWith_d__41>.NativeClassPtr, 100665495);
				SteamFriends._GetPlayedWith_d__41.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._GetPlayedWith_d__41>.NativeClassPtr, 100665496);
			}

			// Token: 0x06001C0C RID: 7180 RVA: 0x00083B8C File Offset: 0x00081D8C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetPlayedWith_d__41(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamFriends._GetPlayedWith_d__41>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._GetPlayedWith_d__41.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C0D RID: 7181 RVA: 0x00083BD4 File Offset: 0x00081DD4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._GetPlayedWith_d__41.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C0E RID: 7182 RVA: 0x00083C08 File Offset: 0x00081E08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937980, XrefRangeEnd = 937985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._GetPlayedWith_d__41.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170006FD RID: 1789
			// (get) Token: 0x06001C0F RID: 7183 RVA: 0x00083C44 File Offset: 0x00081E44
			public unsafe Friend System.Collections.Generic.IEnumerator<Steamworks.Friend>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._GetPlayedWith_d__41.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Steamworks_Friend__get_Current_Private_Virtual_Final_New_get_Friend_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001C10 RID: 7184 RVA: 0x00083C80 File Offset: 0x00081E80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937985, XrefRangeEnd = 937990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._GetPlayedWith_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170006FE RID: 1790
			// (get) Token: 0x06001C11 RID: 7185 RVA: 0x00083CB4 File Offset: 0x00081EB4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937990, XrefRangeEnd = 937993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._GetPlayedWith_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001C12 RID: 7186 RVA: 0x00083CF4 File Offset: 0x00081EF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937993, XrefRangeEnd = 937995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Friend> System_Collections_Generic_IEnumerable_Steamworks_Friend__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._GetPlayedWith_d__41.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Steamworks_Friend__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Friend_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Friend>>(intPtr3) : null;
			}

			// Token: 0x06001C13 RID: 7187 RVA: 0x00083D34 File Offset: 0x00081F34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._GetPlayedWith_d__41.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001C14 RID: 7188 RVA: 0x00009803 File Offset: 0x00007A03
			public _GetPlayedWith_d__41(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006F9 RID: 1785
			// (get) Token: 0x06001C15 RID: 7189 RVA: 0x00083D74 File Offset: 0x00081F74
			// (set) Token: 0x06001C16 RID: 7190 RVA: 0x0000980C File Offset: 0x00007A0C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetPlayedWith_d__41.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetPlayedWith_d__41.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006FA RID: 1786
			// (get) Token: 0x06001C17 RID: 7191 RVA: 0x00083D9C File Offset: 0x00081F9C
			// (set) Token: 0x06001C18 RID: 7192 RVA: 0x00009827 File Offset: 0x00007A27
			public unsafe Friend __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetPlayedWith_d__41.NativeFieldInfoPtr___2__current);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetPlayedWith_d__41.NativeFieldInfoPtr___2__current)) = value;
				}
			}

			// Token: 0x170006FB RID: 1787
			// (get) Token: 0x06001C19 RID: 7193 RVA: 0x00083DC4 File Offset: 0x00081FC4
			// (set) Token: 0x06001C1A RID: 7194 RVA: 0x00009842 File Offset: 0x00007A42
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetPlayedWith_d__41.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetPlayedWith_d__41.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170006FC RID: 1788
			// (get) Token: 0x06001C1B RID: 7195 RVA: 0x00083DEC File Offset: 0x00081FEC
			// (set) Token: 0x06001C1C RID: 7196 RVA: 0x0000985D File Offset: 0x00007A5D
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetPlayedWith_d__41.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetPlayedWith_d__41.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x0400206E RID: 8302
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400206F RID: 8303
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002070 RID: 8304
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002071 RID: 8305
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x04002072 RID: 8306
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002073 RID: 8307
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002074 RID: 8308
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002075 RID: 8309
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Steamworks_Friend__get_Current_Private_Virtual_Final_New_get_Friend_0;

			// Token: 0x04002076 RID: 8310
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002077 RID: 8311
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002078 RID: 8312
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Steamworks_Friend__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Friend_0;

			// Token: 0x04002079 RID: 8313
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200022D RID: 557
		[ObfuscatedName("Steamworks.SteamFriends+<GetSmallAvatarAsync>d__52")]
		public sealed class _GetSmallAvatarAsync_d__52 : ValueType
		{
			// Token: 0x06001C1D RID: 7197 RVA: 0x00083E14 File Offset: 0x00082014
			// Note: this type is marked as 'beforefieldinit'.
			static _GetSmallAvatarAsync_d__52()
			{
				Il2CppClassPointerStore<SteamFriends._GetSmallAvatarAsync_d__52>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, "<GetSmallAvatarAsync>d__52");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamFriends._GetSmallAvatarAsync_d__52>.NativeClassPtr);
				SteamFriends._GetSmallAvatarAsync_d__52.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._GetSmallAvatarAsync_d__52>.NativeClassPtr, "<>1__state");
				SteamFriends._GetSmallAvatarAsync_d__52.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._GetSmallAvatarAsync_d__52>.NativeClassPtr, "<>t__builder");
				SteamFriends._GetSmallAvatarAsync_d__52.NativeFieldInfoPtr_steamid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._GetSmallAvatarAsync_d__52>.NativeClassPtr, "steamid");
				SteamFriends._GetSmallAvatarAsync_d__52.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._GetSmallAvatarAsync_d__52>.NativeClassPtr, "<>u__1");
				SteamFriends._GetSmallAvatarAsync_d__52.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._GetSmallAvatarAsync_d__52>.NativeClassPtr, 100665497);
				SteamFriends._GetSmallAvatarAsync_d__52.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._GetSmallAvatarAsync_d__52>.NativeClassPtr, 100665498);
			}

			// Token: 0x06001C1E RID: 7198 RVA: 0x00083EB8 File Offset: 0x000820B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937995, XrefRangeEnd = 938013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._GetSmallAvatarAsync_d__52.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C1F RID: 7199 RVA: 0x00083EF0 File Offset: 0x000820F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938013, XrefRangeEnd = 938019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._GetSmallAvatarAsync_d__52.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C20 RID: 7200 RVA: 0x00009878 File Offset: 0x00007A78
			public _GetSmallAvatarAsync_d__52(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001C21 RID: 7201 RVA: 0x00009881 File Offset: 0x00007A81
			public _GetSmallAvatarAsync_d__52()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamFriends._GetSmallAvatarAsync_d__52>.NativeClassPtr))
			{
			}

			// Token: 0x170006FF RID: 1791
			// (get) Token: 0x06001C22 RID: 7202 RVA: 0x00083F38 File Offset: 0x00082138
			// (set) Token: 0x06001C23 RID: 7203 RVA: 0x00009893 File Offset: 0x00007A93
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetSmallAvatarAsync_d__52.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetSmallAvatarAsync_d__52.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000700 RID: 1792
			// (get) Token: 0x06001C24 RID: 7204 RVA: 0x00083F60 File Offset: 0x00082160
			// (set) Token: 0x06001C25 RID: 7205 RVA: 0x000098AE File Offset: 0x00007AAE
			public AsyncTaskMethodBuilder<Nullable<Image>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetSmallAvatarAsync_d__52.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Nullable<Image>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<Image>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetSmallAvatarAsync_d__52.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<Image>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000701 RID: 1793
			// (get) Token: 0x06001C26 RID: 7206 RVA: 0x00083F90 File Offset: 0x00082190
			// (set) Token: 0x06001C27 RID: 7207 RVA: 0x000098DC File Offset: 0x00007ADC
			public unsafe SteamId steamid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetSmallAvatarAsync_d__52.NativeFieldInfoPtr_steamid);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetSmallAvatarAsync_d__52.NativeFieldInfoPtr_steamid)) = value;
				}
			}

			// Token: 0x17000702 RID: 1794
			// (get) Token: 0x06001C28 RID: 7208 RVA: 0x00083FB8 File Offset: 0x000821B8
			// (set) Token: 0x06001C29 RID: 7209 RVA: 0x000098F7 File Offset: 0x00007AF7
			public TaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetSmallAvatarAsync_d__52.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._GetSmallAvatarAsync_d__52.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400207A RID: 8314
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400207B RID: 8315
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400207C RID: 8316
			private static readonly IntPtr NativeFieldInfoPtr_steamid;

			// Token: 0x0400207D RID: 8317
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400207E RID: 8318
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400207F RID: 8319
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200022E RID: 558
		[ObfuscatedName("Steamworks.SteamFriends+<IsFollowing>d__62")]
		public sealed class _IsFollowing_d__62 : ValueType
		{
			// Token: 0x06001C2A RID: 7210 RVA: 0x00083FE8 File Offset: 0x000821E8
			// Note: this type is marked as 'beforefieldinit'.
			static _IsFollowing_d__62()
			{
				Il2CppClassPointerStore<SteamFriends._IsFollowing_d__62>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, "<IsFollowing>d__62");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamFriends._IsFollowing_d__62>.NativeClassPtr);
				SteamFriends._IsFollowing_d__62.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._IsFollowing_d__62>.NativeClassPtr, "<>1__state");
				SteamFriends._IsFollowing_d__62.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._IsFollowing_d__62>.NativeClassPtr, "<>t__builder");
				SteamFriends._IsFollowing_d__62.NativeFieldInfoPtr_steamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._IsFollowing_d__62>.NativeClassPtr, "steamID");
				SteamFriends._IsFollowing_d__62.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._IsFollowing_d__62>.NativeClassPtr, "<>u__1");
				SteamFriends._IsFollowing_d__62.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._IsFollowing_d__62>.NativeClassPtr, 100665499);
				SteamFriends._IsFollowing_d__62.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._IsFollowing_d__62>.NativeClassPtr, 100665500);
			}

			// Token: 0x06001C2B RID: 7211 RVA: 0x0008408C File Offset: 0x0008228C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938019, XrefRangeEnd = 938041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._IsFollowing_d__62.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C2C RID: 7212 RVA: 0x000840C4 File Offset: 0x000822C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938041, XrefRangeEnd = 938047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._IsFollowing_d__62.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C2D RID: 7213 RVA: 0x00009925 File Offset: 0x00007B25
			public _IsFollowing_d__62(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001C2E RID: 7214 RVA: 0x0000992E File Offset: 0x00007B2E
			public _IsFollowing_d__62()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamFriends._IsFollowing_d__62>.NativeClassPtr))
			{
			}

			// Token: 0x17000703 RID: 1795
			// (get) Token: 0x06001C2F RID: 7215 RVA: 0x0008410C File Offset: 0x0008230C
			// (set) Token: 0x06001C30 RID: 7216 RVA: 0x00009940 File Offset: 0x00007B40
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._IsFollowing_d__62.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._IsFollowing_d__62.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000704 RID: 1796
			// (get) Token: 0x06001C31 RID: 7217 RVA: 0x00084134 File Offset: 0x00082334
			// (set) Token: 0x06001C32 RID: 7218 RVA: 0x0000995B File Offset: 0x00007B5B
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._IsFollowing_d__62.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._IsFollowing_d__62.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000705 RID: 1797
			// (get) Token: 0x06001C33 RID: 7219 RVA: 0x00084164 File Offset: 0x00082364
			// (set) Token: 0x06001C34 RID: 7220 RVA: 0x00009989 File Offset: 0x00007B89
			public unsafe SteamId steamID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._IsFollowing_d__62.NativeFieldInfoPtr_steamID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._IsFollowing_d__62.NativeFieldInfoPtr_steamID)) = value;
				}
			}

			// Token: 0x17000706 RID: 1798
			// (get) Token: 0x06001C35 RID: 7221 RVA: 0x0008418C File Offset: 0x0008238C
			// (set) Token: 0x06001C36 RID: 7222 RVA: 0x000099A4 File Offset: 0x00007BA4
			public CallResult<FriendsIsFollowing_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._IsFollowing_d__62.NativeFieldInfoPtr___u__1);
					return new CallResult<FriendsIsFollowing_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<FriendsIsFollowing_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._IsFollowing_d__62.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<FriendsIsFollowing_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002080 RID: 8320
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002081 RID: 8321
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002082 RID: 8322
			private static readonly IntPtr NativeFieldInfoPtr_steamID;

			// Token: 0x04002083 RID: 8323
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002084 RID: 8324
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002085 RID: 8325
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200022F RID: 559
		[ObfuscatedName("Steamworks.SteamFriends+<JoinClanChatRoom>d__66")]
		public sealed class _JoinClanChatRoom_d__66 : ValueType
		{
			// Token: 0x06001C37 RID: 7223 RVA: 0x000841BC File Offset: 0x000823BC
			// Note: this type is marked as 'beforefieldinit'.
			static _JoinClanChatRoom_d__66()
			{
				Il2CppClassPointerStore<SteamFriends._JoinClanChatRoom_d__66>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, "<JoinClanChatRoom>d__66");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamFriends._JoinClanChatRoom_d__66>.NativeClassPtr);
				SteamFriends._JoinClanChatRoom_d__66.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._JoinClanChatRoom_d__66>.NativeClassPtr, "<>1__state");
				SteamFriends._JoinClanChatRoom_d__66.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._JoinClanChatRoom_d__66>.NativeClassPtr, "<>t__builder");
				SteamFriends._JoinClanChatRoom_d__66.NativeFieldInfoPtr_chatId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._JoinClanChatRoom_d__66>.NativeClassPtr, "chatId");
				SteamFriends._JoinClanChatRoom_d__66.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamFriends._JoinClanChatRoom_d__66>.NativeClassPtr, "<>u__1");
				SteamFriends._JoinClanChatRoom_d__66.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._JoinClanChatRoom_d__66>.NativeClassPtr, 100665501);
				SteamFriends._JoinClanChatRoom_d__66.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends._JoinClanChatRoom_d__66>.NativeClassPtr, 100665502);
			}

			// Token: 0x06001C38 RID: 7224 RVA: 0x00084260 File Offset: 0x00082460
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938047, XrefRangeEnd = 938071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._JoinClanChatRoom_d__66.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C39 RID: 7225 RVA: 0x00084298 File Offset: 0x00082498
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938071, XrefRangeEnd = 938077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends._JoinClanChatRoom_d__66.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C3A RID: 7226 RVA: 0x000099D2 File Offset: 0x00007BD2
			public _JoinClanChatRoom_d__66(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001C3B RID: 7227 RVA: 0x000099DB File Offset: 0x00007BDB
			public _JoinClanChatRoom_d__66()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamFriends._JoinClanChatRoom_d__66>.NativeClassPtr))
			{
			}

			// Token: 0x17000707 RID: 1799
			// (get) Token: 0x06001C3C RID: 7228 RVA: 0x000842E0 File Offset: 0x000824E0
			// (set) Token: 0x06001C3D RID: 7229 RVA: 0x000099ED File Offset: 0x00007BED
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._JoinClanChatRoom_d__66.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._JoinClanChatRoom_d__66.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000708 RID: 1800
			// (get) Token: 0x06001C3E RID: 7230 RVA: 0x00084308 File Offset: 0x00082508
			// (set) Token: 0x06001C3F RID: 7231 RVA: 0x00009A08 File Offset: 0x00007C08
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._JoinClanChatRoom_d__66.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._JoinClanChatRoom_d__66.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000709 RID: 1801
			// (get) Token: 0x06001C40 RID: 7232 RVA: 0x00084338 File Offset: 0x00082538
			// (set) Token: 0x06001C41 RID: 7233 RVA: 0x00009A36 File Offset: 0x00007C36
			public unsafe SteamId chatId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._JoinClanChatRoom_d__66.NativeFieldInfoPtr_chatId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._JoinClanChatRoom_d__66.NativeFieldInfoPtr_chatId)) = value;
				}
			}

			// Token: 0x1700070A RID: 1802
			// (get) Token: 0x06001C42 RID: 7234 RVA: 0x00084360 File Offset: 0x00082560
			// (set) Token: 0x06001C43 RID: 7235 RVA: 0x00009A51 File Offset: 0x00007C51
			public CallResult<JoinClanChatRoomCompletionResult_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._JoinClanChatRoom_d__66.NativeFieldInfoPtr___u__1);
					return new CallResult<JoinClanChatRoomCompletionResult_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<JoinClanChatRoomCompletionResult_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamFriends._JoinClanChatRoom_d__66.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<JoinClanChatRoomCompletionResult_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002086 RID: 8326
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002087 RID: 8327
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002088 RID: 8328
			private static readonly IntPtr NativeFieldInfoPtr_chatId;

			// Token: 0x04002089 RID: 8329
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400208A RID: 8330
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400208B RID: 8331
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
