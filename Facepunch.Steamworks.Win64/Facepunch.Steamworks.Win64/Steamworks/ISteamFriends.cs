using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x02000011 RID: 17
	public class ISteamFriends : SteamInterface
	{
		// Token: 0x0600013C RID: 316 RVA: 0x00015594 File Offset: 0x00013794
		// Note: this type is marked as 'beforefieldinit'.
		static ISteamFriends()
		{
			Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "ISteamFriends");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr);
			ISteamFriends.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663581);
			ISteamFriends.NativeMethodInfoPtr_SteamAPI_SteamFriends_v017_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663582);
			ISteamFriends.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663583);
			ISteamFriends.NativeMethodInfoPtr__GetPersonaName_Private_Static_Utf8StringPointer_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663584);
			ISteamFriends.NativeMethodInfoPtr_GetPersonaName_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663585);
			ISteamFriends.NativeMethodInfoPtr__SetPersonaName_Private_Static_SteamAPICall_t_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663586);
			ISteamFriends.NativeMethodInfoPtr_SetPersonaName_Internal_CallResult_1_SetPersonaNameResponse_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663587);
			ISteamFriends.NativeMethodInfoPtr__GetPersonaState_Private_Static_FriendState_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663588);
			ISteamFriends.NativeMethodInfoPtr_GetPersonaState_Internal_FriendState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663589);
			ISteamFriends.NativeMethodInfoPtr__GetFriendCount_Private_Static_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663590);
			ISteamFriends.NativeMethodInfoPtr_GetFriendCount_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663591);
			ISteamFriends.NativeMethodInfoPtr__GetFriendByIndex_Private_Static_SteamId_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663592);
			ISteamFriends.NativeMethodInfoPtr_GetFriendByIndex_Internal_SteamId_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663593);
			ISteamFriends.NativeMethodInfoPtr__GetFriendRelationship_Private_Static_Relationship_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663594);
			ISteamFriends.NativeMethodInfoPtr_GetFriendRelationship_Internal_Relationship_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663595);
			ISteamFriends.NativeMethodInfoPtr__GetFriendPersonaState_Private_Static_FriendState_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663596);
			ISteamFriends.NativeMethodInfoPtr_GetFriendPersonaState_Internal_FriendState_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663597);
			ISteamFriends.NativeMethodInfoPtr__GetFriendPersonaName_Private_Static_Utf8StringPointer_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663598);
			ISteamFriends.NativeMethodInfoPtr_GetFriendPersonaName_Internal_String_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663599);
			ISteamFriends.NativeMethodInfoPtr__GetFriendGamePlayed_Private_Static_Boolean_IntPtr_SteamId_byref_FriendGameInfo_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663600);
			ISteamFriends.NativeMethodInfoPtr_GetFriendGamePlayed_Internal_Boolean_SteamId_byref_FriendGameInfo_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663601);
			ISteamFriends.NativeMethodInfoPtr__GetFriendPersonaNameHistory_Private_Static_Utf8StringPointer_IntPtr_SteamId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663602);
			ISteamFriends.NativeMethodInfoPtr_GetFriendPersonaNameHistory_Internal_String_SteamId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663603);
			ISteamFriends.NativeMethodInfoPtr__GetFriendSteamLevel_Private_Static_Int32_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663604);
			ISteamFriends.NativeMethodInfoPtr_GetFriendSteamLevel_Internal_Int32_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663605);
			ISteamFriends.NativeMethodInfoPtr__GetPlayerNickname_Private_Static_Utf8StringPointer_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663606);
			ISteamFriends.NativeMethodInfoPtr_GetPlayerNickname_Internal_String_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663607);
			ISteamFriends.NativeMethodInfoPtr__GetFriendsGroupCount_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663608);
			ISteamFriends.NativeMethodInfoPtr_GetFriendsGroupCount_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663609);
			ISteamFriends.NativeMethodInfoPtr__GetFriendsGroupIDByIndex_Private_Static_FriendsGroupID_t_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663610);
			ISteamFriends.NativeMethodInfoPtr_GetFriendsGroupIDByIndex_Internal_FriendsGroupID_t_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663611);
			ISteamFriends.NativeMethodInfoPtr__GetFriendsGroupName_Private_Static_Utf8StringPointer_IntPtr_FriendsGroupID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663612);
			ISteamFriends.NativeMethodInfoPtr_GetFriendsGroupName_Internal_String_FriendsGroupID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663613);
			ISteamFriends.NativeMethodInfoPtr__GetFriendsGroupMembersCount_Private_Static_Int32_IntPtr_FriendsGroupID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663614);
			ISteamFriends.NativeMethodInfoPtr_GetFriendsGroupMembersCount_Internal_Int32_FriendsGroupID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663615);
			ISteamFriends.NativeMethodInfoPtr__GetFriendsGroupMembersList_Private_Static_Void_IntPtr_FriendsGroupID_t_Il2CppStructArray_1_SteamId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663616);
			ISteamFriends.NativeMethodInfoPtr_GetFriendsGroupMembersList_Internal_Void_FriendsGroupID_t_Il2CppStructArray_1_SteamId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663617);
			ISteamFriends.NativeMethodInfoPtr__HasFriend_Private_Static_Boolean_IntPtr_SteamId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663618);
			ISteamFriends.NativeMethodInfoPtr_HasFriend_Internal_Boolean_SteamId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663619);
			ISteamFriends.NativeMethodInfoPtr__GetClanCount_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663620);
			ISteamFriends.NativeMethodInfoPtr_GetClanCount_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663621);
			ISteamFriends.NativeMethodInfoPtr__GetClanByIndex_Private_Static_SteamId_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663622);
			ISteamFriends.NativeMethodInfoPtr_GetClanByIndex_Internal_SteamId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663623);
			ISteamFriends.NativeMethodInfoPtr__GetClanName_Private_Static_Utf8StringPointer_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663624);
			ISteamFriends.NativeMethodInfoPtr_GetClanName_Internal_String_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663625);
			ISteamFriends.NativeMethodInfoPtr__GetClanTag_Private_Static_Utf8StringPointer_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663626);
			ISteamFriends.NativeMethodInfoPtr_GetClanTag_Internal_String_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663627);
			ISteamFriends.NativeMethodInfoPtr__GetClanActivityCounts_Private_Static_Boolean_IntPtr_SteamId_byref_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663628);
			ISteamFriends.NativeMethodInfoPtr_GetClanActivityCounts_Internal_Boolean_SteamId_byref_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663629);
			ISteamFriends.NativeMethodInfoPtr__DownloadClanActivityCounts_Private_Static_SteamAPICall_t_IntPtr_Il2CppStructArray_1_SteamId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663630);
			ISteamFriends.NativeMethodInfoPtr_DownloadClanActivityCounts_Internal_CallResult_1_DownloadClanActivityCountsResult_t_Il2CppStructArray_1_SteamId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663631);
			ISteamFriends.NativeMethodInfoPtr__GetFriendCountFromSource_Private_Static_Int32_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663632);
			ISteamFriends.NativeMethodInfoPtr_GetFriendCountFromSource_Internal_Int32_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663633);
			ISteamFriends.NativeMethodInfoPtr__GetFriendFromSourceByIndex_Private_Static_SteamId_IntPtr_SteamId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663634);
			ISteamFriends.NativeMethodInfoPtr_GetFriendFromSourceByIndex_Internal_SteamId_SteamId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663635);
			ISteamFriends.NativeMethodInfoPtr__IsUserInSource_Private_Static_Boolean_IntPtr_SteamId_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663636);
			ISteamFriends.NativeMethodInfoPtr_IsUserInSource_Internal_Boolean_SteamId_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663637);
			ISteamFriends.NativeMethodInfoPtr__SetInGameVoiceSpeaking_Private_Static_Void_IntPtr_SteamId_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663638);
			ISteamFriends.NativeMethodInfoPtr_SetInGameVoiceSpeaking_Internal_Void_SteamId_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663639);
			ISteamFriends.NativeMethodInfoPtr__ActivateGameOverlay_Private_Static_Void_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663640);
			ISteamFriends.NativeMethodInfoPtr_ActivateGameOverlay_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663641);
			ISteamFriends.NativeMethodInfoPtr__ActivateGameOverlayToUser_Private_Static_Void_IntPtr_String_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663642);
			ISteamFriends.NativeMethodInfoPtr_ActivateGameOverlayToUser_Internal_Void_String_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663643);
			ISteamFriends.NativeMethodInfoPtr__ActivateGameOverlayToWebPage_Private_Static_Void_IntPtr_String_ActivateGameOverlayToWebPageMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663644);
			ISteamFriends.NativeMethodInfoPtr_ActivateGameOverlayToWebPage_Internal_Void_String_ActivateGameOverlayToWebPageMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663645);
			ISteamFriends.NativeMethodInfoPtr__ActivateGameOverlayToStore_Private_Static_Void_IntPtr_AppId_OverlayToStoreFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663646);
			ISteamFriends.NativeMethodInfoPtr_ActivateGameOverlayToStore_Internal_Void_AppId_OverlayToStoreFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663647);
			ISteamFriends.NativeMethodInfoPtr__SetPlayedWith_Private_Static_Void_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663648);
			ISteamFriends.NativeMethodInfoPtr_SetPlayedWith_Internal_Void_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663649);
			ISteamFriends.NativeMethodInfoPtr__ActivateGameOverlayInviteDialog_Private_Static_Void_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663650);
			ISteamFriends.NativeMethodInfoPtr_ActivateGameOverlayInviteDialog_Internal_Void_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663651);
			ISteamFriends.NativeMethodInfoPtr__GetSmallFriendAvatar_Private_Static_Int32_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663652);
			ISteamFriends.NativeMethodInfoPtr_GetSmallFriendAvatar_Internal_Int32_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663653);
			ISteamFriends.NativeMethodInfoPtr__GetMediumFriendAvatar_Private_Static_Int32_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663654);
			ISteamFriends.NativeMethodInfoPtr_GetMediumFriendAvatar_Internal_Int32_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663655);
			ISteamFriends.NativeMethodInfoPtr__GetLargeFriendAvatar_Private_Static_Int32_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663656);
			ISteamFriends.NativeMethodInfoPtr_GetLargeFriendAvatar_Internal_Int32_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663657);
			ISteamFriends.NativeMethodInfoPtr__RequestUserInformation_Private_Static_Boolean_IntPtr_SteamId_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663658);
			ISteamFriends.NativeMethodInfoPtr_RequestUserInformation_Internal_Boolean_SteamId_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663659);
			ISteamFriends.NativeMethodInfoPtr__RequestClanOfficerList_Private_Static_SteamAPICall_t_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663660);
			ISteamFriends.NativeMethodInfoPtr_RequestClanOfficerList_Internal_CallResult_1_ClanOfficerListResponse_t_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663661);
			ISteamFriends.NativeMethodInfoPtr__GetClanOwner_Private_Static_SteamId_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663662);
			ISteamFriends.NativeMethodInfoPtr_GetClanOwner_Internal_SteamId_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663663);
			ISteamFriends.NativeMethodInfoPtr__GetClanOfficerCount_Private_Static_Int32_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663664);
			ISteamFriends.NativeMethodInfoPtr_GetClanOfficerCount_Internal_Int32_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663665);
			ISteamFriends.NativeMethodInfoPtr__GetClanOfficerByIndex_Private_Static_SteamId_IntPtr_SteamId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663666);
			ISteamFriends.NativeMethodInfoPtr_GetClanOfficerByIndex_Internal_SteamId_SteamId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663667);
			ISteamFriends.NativeMethodInfoPtr__GetUserRestrictions_Private_Static_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663668);
			ISteamFriends.NativeMethodInfoPtr_GetUserRestrictions_Internal_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663669);
			ISteamFriends.NativeMethodInfoPtr__SetRichPresence_Private_Static_Boolean_IntPtr_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663670);
			ISteamFriends.NativeMethodInfoPtr_SetRichPresence_Internal_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663671);
			ISteamFriends.NativeMethodInfoPtr__ClearRichPresence_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663672);
			ISteamFriends.NativeMethodInfoPtr_ClearRichPresence_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663673);
			ISteamFriends.NativeMethodInfoPtr__GetFriendRichPresence_Private_Static_Utf8StringPointer_IntPtr_SteamId_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663674);
			ISteamFriends.NativeMethodInfoPtr_GetFriendRichPresence_Internal_String_SteamId_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663675);
			ISteamFriends.NativeMethodInfoPtr__GetFriendRichPresenceKeyCount_Private_Static_Int32_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663676);
			ISteamFriends.NativeMethodInfoPtr_GetFriendRichPresenceKeyCount_Internal_Int32_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663677);
			ISteamFriends.NativeMethodInfoPtr__GetFriendRichPresenceKeyByIndex_Private_Static_Utf8StringPointer_IntPtr_SteamId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663678);
			ISteamFriends.NativeMethodInfoPtr_GetFriendRichPresenceKeyByIndex_Internal_String_SteamId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663679);
			ISteamFriends.NativeMethodInfoPtr__RequestFriendRichPresence_Private_Static_Void_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663680);
			ISteamFriends.NativeMethodInfoPtr_RequestFriendRichPresence_Internal_Void_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663681);
			ISteamFriends.NativeMethodInfoPtr__InviteUserToGame_Private_Static_Boolean_IntPtr_SteamId_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663682);
			ISteamFriends.NativeMethodInfoPtr_InviteUserToGame_Internal_Boolean_SteamId_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663683);
			ISteamFriends.NativeMethodInfoPtr__GetCoplayFriendCount_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663684);
			ISteamFriends.NativeMethodInfoPtr_GetCoplayFriendCount_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663685);
			ISteamFriends.NativeMethodInfoPtr__GetCoplayFriend_Private_Static_SteamId_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663686);
			ISteamFriends.NativeMethodInfoPtr_GetCoplayFriend_Internal_SteamId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663687);
			ISteamFriends.NativeMethodInfoPtr__GetFriendCoplayTime_Private_Static_Int32_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663688);
			ISteamFriends.NativeMethodInfoPtr_GetFriendCoplayTime_Internal_Int32_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663689);
			ISteamFriends.NativeMethodInfoPtr__GetFriendCoplayGame_Private_Static_AppId_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663690);
			ISteamFriends.NativeMethodInfoPtr_GetFriendCoplayGame_Internal_AppId_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663691);
			ISteamFriends.NativeMethodInfoPtr__JoinClanChatRoom_Private_Static_SteamAPICall_t_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663692);
			ISteamFriends.NativeMethodInfoPtr_JoinClanChatRoom_Internal_CallResult_1_JoinClanChatRoomCompletionResult_t_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663693);
			ISteamFriends.NativeMethodInfoPtr__LeaveClanChatRoom_Private_Static_Boolean_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663694);
			ISteamFriends.NativeMethodInfoPtr_LeaveClanChatRoom_Internal_Boolean_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663695);
			ISteamFriends.NativeMethodInfoPtr__GetClanChatMemberCount_Private_Static_Int32_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663696);
			ISteamFriends.NativeMethodInfoPtr_GetClanChatMemberCount_Internal_Int32_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663697);
			ISteamFriends.NativeMethodInfoPtr__GetChatMemberByIndex_Private_Static_SteamId_IntPtr_SteamId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663698);
			ISteamFriends.NativeMethodInfoPtr_GetChatMemberByIndex_Internal_SteamId_SteamId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663699);
			ISteamFriends.NativeMethodInfoPtr__SendClanChatMessage_Private_Static_Boolean_IntPtr_SteamId_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663700);
			ISteamFriends.NativeMethodInfoPtr_SendClanChatMessage_Internal_Boolean_SteamId_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663701);
			ISteamFriends.NativeMethodInfoPtr__GetClanChatMessage_Private_Static_Int32_IntPtr_SteamId_Int32_IntPtr_Int32_byref_ChatEntryType_byref_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663702);
			ISteamFriends.NativeMethodInfoPtr_GetClanChatMessage_Internal_Int32_SteamId_Int32_IntPtr_Int32_byref_ChatEntryType_byref_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663703);
			ISteamFriends.NativeMethodInfoPtr__IsClanChatAdmin_Private_Static_Boolean_IntPtr_SteamId_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663704);
			ISteamFriends.NativeMethodInfoPtr_IsClanChatAdmin_Internal_Boolean_SteamId_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663705);
			ISteamFriends.NativeMethodInfoPtr__IsClanChatWindowOpenInSteam_Private_Static_Boolean_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663706);
			ISteamFriends.NativeMethodInfoPtr_IsClanChatWindowOpenInSteam_Internal_Boolean_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663707);
			ISteamFriends.NativeMethodInfoPtr__OpenClanChatWindowInSteam_Private_Static_Boolean_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663708);
			ISteamFriends.NativeMethodInfoPtr_OpenClanChatWindowInSteam_Internal_Boolean_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663709);
			ISteamFriends.NativeMethodInfoPtr__CloseClanChatWindowInSteam_Private_Static_Boolean_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663710);
			ISteamFriends.NativeMethodInfoPtr_CloseClanChatWindowInSteam_Internal_Boolean_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663711);
			ISteamFriends.NativeMethodInfoPtr__SetListenForFriendsMessages_Private_Static_Boolean_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663712);
			ISteamFriends.NativeMethodInfoPtr_SetListenForFriendsMessages_Internal_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663713);
			ISteamFriends.NativeMethodInfoPtr__ReplyToFriendMessage_Private_Static_Boolean_IntPtr_SteamId_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663714);
			ISteamFriends.NativeMethodInfoPtr_ReplyToFriendMessage_Internal_Boolean_SteamId_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663715);
			ISteamFriends.NativeMethodInfoPtr__GetFriendMessage_Private_Static_Int32_IntPtr_SteamId_Int32_IntPtr_Int32_byref_ChatEntryType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663716);
			ISteamFriends.NativeMethodInfoPtr_GetFriendMessage_Internal_Int32_SteamId_Int32_IntPtr_Int32_byref_ChatEntryType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663717);
			ISteamFriends.NativeMethodInfoPtr__GetFollowerCount_Private_Static_SteamAPICall_t_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663718);
			ISteamFriends.NativeMethodInfoPtr_GetFollowerCount_Internal_CallResult_1_FriendsGetFollowerCount_t_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663719);
			ISteamFriends.NativeMethodInfoPtr__IsFollowing_Private_Static_SteamAPICall_t_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663720);
			ISteamFriends.NativeMethodInfoPtr_IsFollowing_Internal_CallResult_1_FriendsIsFollowing_t_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663721);
			ISteamFriends.NativeMethodInfoPtr__EnumerateFollowingList_Private_Static_SteamAPICall_t_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663722);
			ISteamFriends.NativeMethodInfoPtr_EnumerateFollowingList_Internal_CallResult_1_FriendsEnumerateFollowingList_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663723);
			ISteamFriends.NativeMethodInfoPtr__IsClanPublic_Private_Static_Boolean_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663724);
			ISteamFriends.NativeMethodInfoPtr_IsClanPublic_Internal_Boolean_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663725);
			ISteamFriends.NativeMethodInfoPtr__IsClanOfficialGameGroup_Private_Static_Boolean_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663726);
			ISteamFriends.NativeMethodInfoPtr_IsClanOfficialGameGroup_Internal_Boolean_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663727);
			ISteamFriends.NativeMethodInfoPtr__GetNumChatsWithUnreadPriorityMessages_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663728);
			ISteamFriends.NativeMethodInfoPtr_GetNumChatsWithUnreadPriorityMessages_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663729);
			ISteamFriends.NativeMethodInfoPtr__ActivateGameOverlayRemotePlayTogetherInviteDialog_Private_Static_Void_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663730);
			ISteamFriends.NativeMethodInfoPtr_ActivateGameOverlayRemotePlayTogetherInviteDialog_Internal_Void_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663731);
			ISteamFriends.NativeMethodInfoPtr__RegisterProtocolInOverlayBrowser_Private_Static_Boolean_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663732);
			ISteamFriends.NativeMethodInfoPtr_RegisterProtocolInOverlayBrowser_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663733);
			ISteamFriends.NativeMethodInfoPtr__ActivateGameOverlayInviteDialogConnectString_Private_Static_Void_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663734);
			ISteamFriends.NativeMethodInfoPtr_ActivateGameOverlayInviteDialogConnectString_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr, 100663735);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x000161E0 File Offset: 0x000143E0
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 930944, RefRangeEnd = 930966, XrefRangeStart = 930944, XrefRangeEnd = 930966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISteamFriends(bool IsGameServer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamFriends>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref IsGameServer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00016228 File Offset: 0x00014428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931609, XrefRangeEnd = 931611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr SteamAPI_SteamFriends_v017()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_SteamAPI_SteamFriends_v017_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00016258 File Offset: 0x00014458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IntPtr GetUserInterfacePointer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamFriends.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x000162A0 File Offset: 0x000144A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931611, XrefRangeEnd = 931613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Utf8StringPointer _GetPersonaName(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__GetPersonaName_Private_Static_Utf8StringPointer_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x000162E0 File Offset: 0x000144E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931616, RefRangeEnd = 931617, XrefRangeStart = 931613, XrefRangeEnd = 931616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetPersonaName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_GetPersonaName_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00016318 File Offset: 0x00014518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931617, XrefRangeEnd = 931620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t _SetPersonaName(IntPtr self, string pchPersonaName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPersonaName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__SetPersonaName_Private_Static_SteamAPICall_t_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00016368 File Offset: 0x00014568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931620, XrefRangeEnd = 931626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<SetPersonaNameResponse_t> SetPersonaName(string pchPersonaName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchPersonaName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_SetPersonaName_Internal_CallResult_1_SetPersonaNameResponse_t_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CallResult<SetPersonaNameResponse_t>(intPtr);
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x000163B0 File Offset: 0x000145B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931626, XrefRangeEnd = 931628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FriendState _GetPersonaState(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__GetPersonaState_Private_Static_FriendState_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000163F0 File Offset: 0x000145F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931630, RefRangeEnd = 931631, XrefRangeStart = 931628, XrefRangeEnd = 931630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FriendState GetPersonaState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_GetPersonaState_Internal_FriendState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0001642C File Offset: 0x0001462C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931631, XrefRangeEnd = 931633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetFriendCount(IntPtr self, int iFriendFlags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iFriendFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__GetFriendCount_Private_Static_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00016478 File Offset: 0x00014678
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931635, RefRangeEnd = 931636, XrefRangeStart = 931633, XrefRangeEnd = 931635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetFriendCount(int iFriendFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iFriendFlags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_GetFriendCount_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000164C4 File Offset: 0x000146C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931636, XrefRangeEnd = 931638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamId _GetFriendByIndex(IntPtr self, int iFriend, int iFriendFlags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iFriend;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iFriendFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__GetFriendByIndex_Private_Static_SteamId_IntPtr_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00016520 File Offset: 0x00014720
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931640, RefRangeEnd = 931641, XrefRangeStart = 931638, XrefRangeEnd = 931640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamId GetFriendByIndex(int iFriend, int iFriendFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iFriend;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iFriendFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_GetFriendByIndex_Internal_SteamId_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00016578 File Offset: 0x00014778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931641, XrefRangeEnd = 931643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Relationship _GetFriendRelationship(IntPtr self, SteamId steamIDFriend)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDFriend;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__GetFriendRelationship_Private_Static_Relationship_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x000165C4 File Offset: 0x000147C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 931645, RefRangeEnd = 931648, XrefRangeStart = 931643, XrefRangeEnd = 931645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Relationship GetFriendRelationship(SteamId steamIDFriend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDFriend;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_GetFriendRelationship_Internal_Relationship_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00016610 File Offset: 0x00014810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931648, XrefRangeEnd = 931650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FriendState _GetFriendPersonaState(IntPtr self, SteamId steamIDFriend)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDFriend;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__GetFriendPersonaState_Private_Static_FriendState_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0001665C File Offset: 0x0001485C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 931652, RefRangeEnd = 931657, XrefRangeStart = 931650, XrefRangeEnd = 931652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FriendState GetFriendPersonaState(SteamId steamIDFriend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDFriend;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_GetFriendPersonaState_Internal_FriendState_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x000166A8 File Offset: 0x000148A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931657, XrefRangeEnd = 931659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Utf8StringPointer _GetFriendPersonaName(IntPtr self, SteamId steamIDFriend)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDFriend;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__GetFriendPersonaName_Private_Static_Utf8StringPointer_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000166F4 File Offset: 0x000148F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 931662, RefRangeEnd = 931664, XrefRangeStart = 931659, XrefRangeEnd = 931662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetFriendPersonaName(SteamId steamIDFriend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDFriend;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_GetFriendPersonaName_Internal_String_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00016738 File Offset: 0x00014938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931664, XrefRangeEnd = 931666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetFriendGamePlayed(IntPtr self, SteamId steamIDFriend, ref FriendGameInfo_t pFriendGameInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDFriend;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pFriendGameInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__GetFriendGamePlayed_Private_Static_Boolean_IntPtr_SteamId_byref_FriendGameInfo_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00016794 File Offset: 0x00014994
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931668, RefRangeEnd = 931669, XrefRangeStart = 931666, XrefRangeEnd = 931668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetFriendGamePlayed(SteamId steamIDFriend, ref FriendGameInfo_t pFriendGameInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDFriend;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pFriendGameInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_GetFriendGamePlayed_Internal_Boolean_SteamId_byref_FriendGameInfo_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x000167EC File Offset: 0x000149EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931669, XrefRangeEnd = 931671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Utf8StringPointer _GetFriendPersonaNameHistory(IntPtr self, SteamId steamIDFriend, int iPersonaName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDFriend;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iPersonaName;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__GetFriendPersonaNameHistory_Private_Static_Utf8StringPointer_IntPtr_SteamId_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00016848 File Offset: 0x00014A48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931674, RefRangeEnd = 931675, XrefRangeStart = 931671, XrefRangeEnd = 931674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetFriendPersonaNameHistory(SteamId steamIDFriend, int iPersonaName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDFriend;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iPersonaName;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_GetFriendPersonaNameHistory_Internal_String_SteamId_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0001689C File Offset: 0x00014A9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931675, XrefRangeEnd = 931677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetFriendSteamLevel(IntPtr self, SteamId steamIDFriend)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDFriend;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__GetFriendSteamLevel_Private_Static_Int32_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000168E8 File Offset: 0x00014AE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931679, RefRangeEnd = 931680, XrefRangeStart = 931677, XrefRangeEnd = 931679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetFriendSteamLevel(SteamId steamIDFriend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDFriend;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_GetFriendSteamLevel_Internal_Int32_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00016934 File Offset: 0x00014B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931680, XrefRangeEnd = 931682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Utf8StringPointer _GetPlayerNickname(IntPtr self, SteamId steamIDPlayer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDPlayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__GetPlayerNickname_Private_Static_Utf8StringPointer_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00016980 File Offset: 0x00014B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931682, XrefRangeEnd = 931685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetPlayerNickname(SteamId steamIDPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDPlayer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_GetPlayerNickname_Internal_String_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x000169C4 File Offset: 0x00014BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931685, XrefRangeEnd = 931687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetFriendsGroupCount(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__GetFriendsGroupCount_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00016A04 File Offset: 0x00014C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931687, XrefRangeEnd = 931689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetFriendsGroupCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_GetFriendsGroupCount_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00016A40 File Offset: 0x00014C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931689, XrefRangeEnd = 931691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FriendsGroupID_t _GetFriendsGroupIDByIndex(IntPtr self, int iFG)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iFG;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__GetFriendsGroupIDByIndex_Private_Static_FriendsGroupID_t_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00016A8C File Offset: 0x00014C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931691, XrefRangeEnd = 931693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FriendsGroupID_t GetFriendsGroupIDByIndex(int iFG)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iFG;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_GetFriendsGroupIDByIndex_Internal_FriendsGroupID_t_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00016AD8 File Offset: 0x00014CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931693, XrefRangeEnd = 931695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Utf8StringPointer _GetFriendsGroupName(IntPtr self, FriendsGroupID_t friendsGroupID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref friendsGroupID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__GetFriendsGroupName_Private_Static_Utf8StringPointer_IntPtr_FriendsGroupID_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00016B24 File Offset: 0x00014D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931695, XrefRangeEnd = 931698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetFriendsGroupName(FriendsGroupID_t friendsGroupID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref friendsGroupID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_GetFriendsGroupName_Internal_String_FriendsGroupID_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00016B68 File Offset: 0x00014D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931698, XrefRangeEnd = 931700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetFriendsGroupMembersCount(IntPtr self, FriendsGroupID_t friendsGroupID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref friendsGroupID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__GetFriendsGroupMembersCount_Private_Static_Int32_IntPtr_FriendsGroupID_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00016BB4 File Offset: 0x00014DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931700, XrefRangeEnd = 931702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetFriendsGroupMembersCount(FriendsGroupID_t friendsGroupID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref friendsGroupID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_GetFriendsGroupMembersCount_Internal_Int32_FriendsGroupID_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00016C00 File Offset: 0x00014E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931702, XrefRangeEnd = 931704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _GetFriendsGroupMembersList(IntPtr self, FriendsGroupID_t friendsGroupID, [In] [Out] Il2CppStructArray<SteamId> pOutSteamIDMembers, int nMembersCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref friendsGroupID;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMembersCount;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__GetFriendsGroupMembersList_Private_Static_Void_IntPtr_FriendsGroupID_t_Il2CppStructArray_1_SteamId_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pOutSteamIDMembers = ((intPtr4 == 0) ? null : new Il2CppStructArray<SteamId>(intPtr4));
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00016C70 File Offset: 0x00014E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931704, XrefRangeEnd = 931706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetFriendsGroupMembersList(FriendsGroupID_t friendsGroupID, [In] [Out] Il2CppStructArray<SteamId> pOutSteamIDMembers, int nMembersCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref friendsGroupID;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMembersCount;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_GetFriendsGroupMembersList_Internal_Void_FriendsGroupID_t_Il2CppStructArray_1_SteamId_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pOutSteamIDMembers = ((intPtr4 == 0) ? null : new Il2CppStructArray<SteamId>(intPtr4));
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00016CE0 File Offset: 0x00014EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931706, XrefRangeEnd = 931708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _HasFriend(IntPtr self, SteamId steamIDFriend, int iFriendFlags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDFriend;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iFriendFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__HasFriend_Private_Static_Boolean_IntPtr_SteamId_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00016D3C File Offset: 0x00014F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931708, XrefRangeEnd = 931710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasFriend(SteamId steamIDFriend, int iFriendFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDFriend;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iFriendFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_HasFriend_Internal_Boolean_SteamId_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00016D94 File Offset: 0x00014F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931710, XrefRangeEnd = 931712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetClanCount(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__GetClanCount_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00016DD4 File Offset: 0x00014FD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931714, RefRangeEnd = 931715, XrefRangeStart = 931712, XrefRangeEnd = 931714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetClanCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_GetClanCount_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00016E10 File Offset: 0x00015010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931715, XrefRangeEnd = 931717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamId _GetClanByIndex(IntPtr self, int iClan)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iClan;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__GetClanByIndex_Private_Static_SteamId_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00016E5C File Offset: 0x0001505C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931719, RefRangeEnd = 931720, XrefRangeStart = 931717, XrefRangeEnd = 931719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamId GetClanByIndex(int iClan)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iClan;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_GetClanByIndex_Internal_SteamId_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00016EA8 File Offset: 0x000150A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931720, XrefRangeEnd = 931722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Utf8StringPointer _GetClanName(IntPtr self, SteamId steamIDClan)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDClan;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__GetClanName_Private_Static_Utf8StringPointer_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00016EF4 File Offset: 0x000150F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931725, RefRangeEnd = 931726, XrefRangeStart = 931722, XrefRangeEnd = 931725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetClanName(SteamId steamIDClan)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDClan;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_GetClanName_Internal_String_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00016F38 File Offset: 0x00015138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931726, XrefRangeEnd = 931728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Utf8StringPointer _GetClanTag(IntPtr self, SteamId steamIDClan)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDClan;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__GetClanTag_Private_Static_Utf8StringPointer_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00016F84 File Offset: 0x00015184
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931731, RefRangeEnd = 931732, XrefRangeStart = 931728, XrefRangeEnd = 931731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetClanTag(SteamId steamIDClan)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDClan;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_GetClanTag_Internal_String_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00016FC8 File Offset: 0x000151C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931732, XrefRangeEnd = 931734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetClanActivityCounts(IntPtr self, SteamId steamIDClan, ref int pnOnline, ref int pnInGame, ref int pnChatting)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDClan;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnOnline;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnInGame;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnChatting;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__GetClanActivityCounts_Private_Static_Boolean_IntPtr_SteamId_byref_Int32_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00017040 File Offset: 0x00015240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931734, XrefRangeEnd = 931736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetClanActivityCounts(SteamId steamIDClan, ref int pnOnline, ref int pnInGame, ref int pnChatting)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDClan;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnOnline;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnInGame;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnChatting;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_GetClanActivityCounts_Internal_Boolean_SteamId_byref_Int32_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x000170B4 File Offset: 0x000152B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931736, XrefRangeEnd = 931738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t _DownloadClanActivityCounts(IntPtr self, [In] [Out] Il2CppStructArray<SteamId> psteamIDClans, int cClansToRequest)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cClansToRequest;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__DownloadClanActivityCounts_Private_Static_SteamAPICall_t_IntPtr_Il2CppStructArray_1_SteamId_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*psteamIDClans = ((intPtr4 == 0) ? null : new Il2CppStructArray<SteamId>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00017124 File Offset: 0x00015324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931738, XrefRangeEnd = 931743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<DownloadClanActivityCountsResult_t> DownloadClanActivityCounts([In] [Out] Il2CppStructArray<SteamId> psteamIDClans, int cClansToRequest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cClansToRequest;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_DownloadClanActivityCounts_Internal_CallResult_1_DownloadClanActivityCountsResult_t_Il2CppStructArray_1_SteamId_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*psteamIDClans = ((intPtr4 == 0) ? null : new Il2CppStructArray<SteamId>(intPtr4));
			return new CallResult<DownloadClanActivityCountsResult_t>(intPtr2);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0001718C File Offset: 0x0001538C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931743, XrefRangeEnd = 931745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetFriendCountFromSource(IntPtr self, SteamId steamIDSource)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDSource;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__GetFriendCountFromSource_Private_Static_Int32_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x000171D8 File Offset: 0x000153D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931747, RefRangeEnd = 931748, XrefRangeStart = 931745, XrefRangeEnd = 931747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetFriendCountFromSource(SteamId steamIDSource)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDSource;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_GetFriendCountFromSource_Internal_Int32_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00017224 File Offset: 0x00015424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931748, XrefRangeEnd = 931750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamId _GetFriendFromSourceByIndex(IntPtr self, SteamId steamIDSource, int iFriend)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDSource;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iFriend;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__GetFriendFromSourceByIndex_Private_Static_SteamId_IntPtr_SteamId_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00017280 File Offset: 0x00015480
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931752, RefRangeEnd = 931753, XrefRangeStart = 931750, XrefRangeEnd = 931752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamId GetFriendFromSourceByIndex(SteamId steamIDSource, int iFriend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDSource;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iFriend;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_GetFriendFromSourceByIndex_Internal_SteamId_SteamId_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000174 RID: 372 RVA: 0x000172D8 File Offset: 0x000154D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931753, XrefRangeEnd = 931755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _IsUserInSource(IntPtr self, SteamId steamIDUser, SteamId steamIDSource)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDUser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDSource;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__IsUserInSource_Private_Static_Boolean_IntPtr_SteamId_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00017334 File Offset: 0x00015534
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931757, RefRangeEnd = 931758, XrefRangeStart = 931755, XrefRangeEnd = 931757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsUserInSource(SteamId steamIDUser, SteamId steamIDSource)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDSource;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_IsUserInSource_Internal_Boolean_SteamId_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0001738C File Offset: 0x0001558C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931758, XrefRangeEnd = 931760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SetInGameVoiceSpeaking(IntPtr self, SteamId steamIDUser, bool bSpeaking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDUser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bSpeaking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__SetInGameVoiceSpeaking_Private_Static_Void_IntPtr_SteamId_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x000173DC File Offset: 0x000155DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931760, XrefRangeEnd = 931762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInGameVoiceSpeaking(SteamId steamIDUser, bool bSpeaking)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bSpeaking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_SetInGameVoiceSpeaking_Internal_Void_SteamId_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00017428 File Offset: 0x00015628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931762, XrefRangeEnd = 931765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _ActivateGameOverlay(IntPtr self, string pchDialog)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchDialog);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__ActivateGameOverlay_Private_Static_Void_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0001746C File Offset: 0x0001566C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931768, RefRangeEnd = 931769, XrefRangeStart = 931765, XrefRangeEnd = 931768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateGameOverlay(string pchDialog)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchDialog);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_ActivateGameOverlay_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x000174B0 File Offset: 0x000156B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931769, XrefRangeEnd = 931772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _ActivateGameOverlayToUser(IntPtr self, string pchDialog, SteamId steamID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchDialog);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__ActivateGameOverlayToUser_Private_Static_Void_IntPtr_String_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00017504 File Offset: 0x00015704
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931775, RefRangeEnd = 931776, XrefRangeStart = 931772, XrefRangeEnd = 931775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateGameOverlayToUser(string pchDialog, SteamId steamID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchDialog);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_ActivateGameOverlayToUser_Internal_Void_String_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00017554 File Offset: 0x00015754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931776, XrefRangeEnd = 931779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _ActivateGameOverlayToWebPage(IntPtr self, string pchURL, ActivateGameOverlayToWebPageMode eMode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchURL);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__ActivateGameOverlayToWebPage_Private_Static_Void_IntPtr_String_ActivateGameOverlayToWebPageMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x000175A8 File Offset: 0x000157A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931782, RefRangeEnd = 931783, XrefRangeStart = 931779, XrefRangeEnd = 931782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateGameOverlayToWebPage(string pchURL, ActivateGameOverlayToWebPageMode eMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchURL);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_ActivateGameOverlayToWebPage_Internal_Void_String_ActivateGameOverlayToWebPageMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000175F8 File Offset: 0x000157F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931783, XrefRangeEnd = 931785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _ActivateGameOverlayToStore(IntPtr self, AppId nAppID, OverlayToStoreFlag eFlag)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nAppID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eFlag;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__ActivateGameOverlayToStore_Private_Static_Void_IntPtr_AppId_OverlayToStoreFlag_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00017648 File Offset: 0x00015848
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931787, RefRangeEnd = 931788, XrefRangeStart = 931785, XrefRangeEnd = 931787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateGameOverlayToStore(AppId nAppID, OverlayToStoreFlag eFlag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nAppID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eFlag;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_ActivateGameOverlayToStore_Internal_Void_AppId_OverlayToStoreFlag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00017694 File Offset: 0x00015894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931788, XrefRangeEnd = 931790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SetPlayedWith(IntPtr self, SteamId steamIDUserPlayedWith)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDUserPlayedWith;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__SetPlayedWith_Private_Static_Void_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000176D4 File Offset: 0x000158D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931792, RefRangeEnd = 931793, XrefRangeStart = 931790, XrefRangeEnd = 931792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlayedWith(SteamId steamIDUserPlayedWith)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUserPlayedWith;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_SetPlayedWith_Internal_Void_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00017714 File Offset: 0x00015914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931793, XrefRangeEnd = 931795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _ActivateGameOverlayInviteDialog(IntPtr self, SteamId steamIDLobby)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDLobby;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__ActivateGameOverlayInviteDialog_Private_Static_Void_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00017754 File Offset: 0x00015954
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931797, RefRangeEnd = 931798, XrefRangeStart = 931795, XrefRangeEnd = 931797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateGameOverlayInviteDialog(SteamId steamIDLobby)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_ActivateGameOverlayInviteDialog_Internal_Void_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00017794 File Offset: 0x00015994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931798, XrefRangeEnd = 931800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetSmallFriendAvatar(IntPtr self, SteamId steamIDFriend)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDFriend;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__GetSmallFriendAvatar_Private_Static_Int32_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x000177E0 File Offset: 0x000159E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931802, RefRangeEnd = 931803, XrefRangeStart = 931800, XrefRangeEnd = 931802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetSmallFriendAvatar(SteamId steamIDFriend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDFriend;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_GetSmallFriendAvatar_Internal_Int32_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0001782C File Offset: 0x00015A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931803, XrefRangeEnd = 931805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetMediumFriendAvatar(IntPtr self, SteamId steamIDFriend)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDFriend;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__GetMediumFriendAvatar_Private_Static_Int32_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00017878 File Offset: 0x00015A78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931807, RefRangeEnd = 931808, XrefRangeStart = 931805, XrefRangeEnd = 931807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetMediumFriendAvatar(SteamId steamIDFriend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDFriend;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_GetMediumFriendAvatar_Internal_Int32_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000188 RID: 392 RVA: 0x000178C4 File Offset: 0x00015AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931808, XrefRangeEnd = 931810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetLargeFriendAvatar(IntPtr self, SteamId steamIDFriend)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDFriend;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__GetLargeFriendAvatar_Private_Static_Int32_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00017910 File Offset: 0x00015B10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 931812, RefRangeEnd = 931814, XrefRangeStart = 931810, XrefRangeEnd = 931812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetLargeFriendAvatar(SteamId steamIDFriend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDFriend;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_GetLargeFriendAvatar_Internal_Int32_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0001795C File Offset: 0x00015B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931814, XrefRangeEnd = 931816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _RequestUserInformation(IntPtr self, SteamId steamIDUser, bool bRequireNameOnly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDUser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bRequireNameOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__RequestUserInformation_Private_Static_Boolean_IntPtr_SteamId_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x000179B8 File Offset: 0x00015BB8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 931818, RefRangeEnd = 931822, XrefRangeStart = 931816, XrefRangeEnd = 931818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RequestUserInformation(SteamId steamIDUser, bool bRequireNameOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bRequireNameOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_RequestUserInformation_Internal_Boolean_SteamId_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00017A10 File Offset: 0x00015C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931822, XrefRangeEnd = 931824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t _RequestClanOfficerList(IntPtr self, SteamId steamIDClan)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDClan;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__RequestClanOfficerList_Private_Static_SteamAPICall_t_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00017A5C File Offset: 0x00015C5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931829, RefRangeEnd = 931830, XrefRangeStart = 931824, XrefRangeEnd = 931829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<ClanOfficerListResponse_t> RequestClanOfficerList(SteamId steamIDClan)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDClan;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_RequestClanOfficerList_Internal_CallResult_1_ClanOfficerListResponse_t_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CallResult<ClanOfficerListResponse_t>(intPtr);
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00017AA0 File Offset: 0x00015CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931830, XrefRangeEnd = 931832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamId _GetClanOwner(IntPtr self, SteamId steamIDClan)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDClan;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__GetClanOwner_Private_Static_SteamId_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00017AEC File Offset: 0x00015CEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931834, RefRangeEnd = 931835, XrefRangeStart = 931832, XrefRangeEnd = 931834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamId GetClanOwner(SteamId steamIDClan)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDClan;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_GetClanOwner_Internal_SteamId_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00017B38 File Offset: 0x00015D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931835, XrefRangeEnd = 931837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetClanOfficerCount(IntPtr self, SteamId steamIDClan)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDClan;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__GetClanOfficerCount_Private_Static_Int32_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00017B84 File Offset: 0x00015D84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931839, RefRangeEnd = 931840, XrefRangeStart = 931837, XrefRangeEnd = 931839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetClanOfficerCount(SteamId steamIDClan)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDClan;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_GetClanOfficerCount_Internal_Int32_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00017BD0 File Offset: 0x00015DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931840, XrefRangeEnd = 931842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamId _GetClanOfficerByIndex(IntPtr self, SteamId steamIDClan, int iOfficer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDClan;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iOfficer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__GetClanOfficerByIndex_Private_Static_SteamId_IntPtr_SteamId_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00017C2C File Offset: 0x00015E2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931844, RefRangeEnd = 931845, XrefRangeStart = 931842, XrefRangeEnd = 931844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamId GetClanOfficerByIndex(SteamId steamIDClan, int iOfficer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDClan;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iOfficer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_GetClanOfficerByIndex_Internal_SteamId_SteamId_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00017C84 File Offset: 0x00015E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931845, XrefRangeEnd = 931847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint _GetUserRestrictions(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__GetUserRestrictions_Private_Static_UInt32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00017CC4 File Offset: 0x00015EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931847, XrefRangeEnd = 931849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetUserRestrictions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_GetUserRestrictions_Internal_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00017D00 File Offset: 0x00015F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931849, XrefRangeEnd = 931854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetRichPresence(IntPtr self, string pchKey, string pchValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__SetRichPresence_Private_Static_Boolean_IntPtr_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00017D64 File Offset: 0x00015F64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931859, RefRangeEnd = 931860, XrefRangeStart = 931854, XrefRangeEnd = 931859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetRichPresence(string pchKey, string pchValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_SetRichPresence_Internal_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00017DC4 File Offset: 0x00015FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931860, XrefRangeEnd = 931862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _ClearRichPresence(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__ClearRichPresence_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00017DF8 File Offset: 0x00015FF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931864, RefRangeEnd = 931865, XrefRangeStart = 931862, XrefRangeEnd = 931864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearRichPresence()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_ClearRichPresence_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00017E2C File Offset: 0x0001602C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931865, XrefRangeEnd = 931868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Utf8StringPointer _GetFriendRichPresence(IntPtr self, SteamId steamIDFriend, string pchKey)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDFriend;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__GetFriendRichPresence_Private_Static_Utf8StringPointer_IntPtr_SteamId_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00017E8C File Offset: 0x0001608C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931872, RefRangeEnd = 931873, XrefRangeStart = 931868, XrefRangeEnd = 931872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetFriendRichPresence(SteamId steamIDFriend, string pchKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDFriend;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_GetFriendRichPresence_Internal_String_SteamId_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00017EE4 File Offset: 0x000160E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931873, XrefRangeEnd = 931875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetFriendRichPresenceKeyCount(IntPtr self, SteamId steamIDFriend)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDFriend;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__GetFriendRichPresenceKeyCount_Private_Static_Int32_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00017F30 File Offset: 0x00016130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931875, XrefRangeEnd = 931877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetFriendRichPresenceKeyCount(SteamId steamIDFriend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDFriend;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_GetFriendRichPresenceKeyCount_Internal_Int32_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00017F7C File Offset: 0x0001617C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931877, XrefRangeEnd = 931879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Utf8StringPointer _GetFriendRichPresenceKeyByIndex(IntPtr self, SteamId steamIDFriend, int iKey)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDFriend;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iKey;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__GetFriendRichPresenceKeyByIndex_Private_Static_Utf8StringPointer_IntPtr_SteamId_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00017FD8 File Offset: 0x000161D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931879, XrefRangeEnd = 931882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetFriendRichPresenceKeyByIndex(SteamId steamIDFriend, int iKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDFriend;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iKey;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_GetFriendRichPresenceKeyByIndex_Internal_String_SteamId_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0001802C File Offset: 0x0001622C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931882, XrefRangeEnd = 931884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _RequestFriendRichPresence(IntPtr self, SteamId steamIDFriend)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDFriend;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__RequestFriendRichPresence_Private_Static_Void_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0001806C File Offset: 0x0001626C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931884, XrefRangeEnd = 931886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestFriendRichPresence(SteamId steamIDFriend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDFriend;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_RequestFriendRichPresence_Internal_Void_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000180AC File Offset: 0x000162AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931886, XrefRangeEnd = 931889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _InviteUserToGame(IntPtr self, SteamId steamIDFriend, string pchConnectString)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDFriend;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchConnectString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__InviteUserToGame_Private_Static_Boolean_IntPtr_SteamId_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0001810C File Offset: 0x0001630C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931892, RefRangeEnd = 931893, XrefRangeStart = 931889, XrefRangeEnd = 931892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InviteUserToGame(SteamId steamIDFriend, string pchConnectString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDFriend;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchConnectString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_InviteUserToGame_Internal_Boolean_SteamId_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00018168 File Offset: 0x00016368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931893, XrefRangeEnd = 931895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetCoplayFriendCount(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__GetCoplayFriendCount_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x000181A8 File Offset: 0x000163A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931897, RefRangeEnd = 931898, XrefRangeStart = 931895, XrefRangeEnd = 931897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCoplayFriendCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_GetCoplayFriendCount_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x000181E4 File Offset: 0x000163E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931898, XrefRangeEnd = 931900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamId _GetCoplayFriend(IntPtr self, int iCoplayFriend)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iCoplayFriend;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__GetCoplayFriend_Private_Static_SteamId_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00018230 File Offset: 0x00016430
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931902, RefRangeEnd = 931903, XrefRangeStart = 931900, XrefRangeEnd = 931902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamId GetCoplayFriend(int iCoplayFriend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iCoplayFriend;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_GetCoplayFriend_Internal_SteamId_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0001827C File Offset: 0x0001647C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931903, XrefRangeEnd = 931905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetFriendCoplayTime(IntPtr self, SteamId steamIDFriend)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDFriend;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__GetFriendCoplayTime_Private_Static_Int32_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x000182C8 File Offset: 0x000164C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931905, XrefRangeEnd = 931907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetFriendCoplayTime(SteamId steamIDFriend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDFriend;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_GetFriendCoplayTime_Internal_Int32_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00018314 File Offset: 0x00016514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931907, XrefRangeEnd = 931909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AppId _GetFriendCoplayGame(IntPtr self, SteamId steamIDFriend)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDFriend;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__GetFriendCoplayGame_Private_Static_AppId_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00018360 File Offset: 0x00016560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931909, XrefRangeEnd = 931911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AppId GetFriendCoplayGame(SteamId steamIDFriend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDFriend;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_GetFriendCoplayGame_Internal_AppId_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001AC RID: 428 RVA: 0x000183AC File Offset: 0x000165AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931911, XrefRangeEnd = 931913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t _JoinClanChatRoom(IntPtr self, SteamId steamIDClan)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDClan;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__JoinClanChatRoom_Private_Static_SteamAPICall_t_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000183F8 File Offset: 0x000165F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931918, RefRangeEnd = 931919, XrefRangeStart = 931913, XrefRangeEnd = 931918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<JoinClanChatRoomCompletionResult_t> JoinClanChatRoom(SteamId steamIDClan)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDClan;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_JoinClanChatRoom_Internal_CallResult_1_JoinClanChatRoomCompletionResult_t_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CallResult<JoinClanChatRoomCompletionResult_t>(intPtr);
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0001843C File Offset: 0x0001663C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931919, XrefRangeEnd = 931921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _LeaveClanChatRoom(IntPtr self, SteamId steamIDClan)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDClan;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__LeaveClanChatRoom_Private_Static_Boolean_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00018488 File Offset: 0x00016688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931921, XrefRangeEnd = 931923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool LeaveClanChatRoom(SteamId steamIDClan)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDClan;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_LeaveClanChatRoom_Internal_Boolean_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000184D4 File Offset: 0x000166D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931923, XrefRangeEnd = 931925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetClanChatMemberCount(IntPtr self, SteamId steamIDClan)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDClan;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__GetClanChatMemberCount_Private_Static_Int32_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00018520 File Offset: 0x00016720
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931927, RefRangeEnd = 931928, XrefRangeStart = 931925, XrefRangeEnd = 931927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetClanChatMemberCount(SteamId steamIDClan)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDClan;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_GetClanChatMemberCount_Internal_Int32_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0001856C File Offset: 0x0001676C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931928, XrefRangeEnd = 931930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamId _GetChatMemberByIndex(IntPtr self, SteamId steamIDClan, int iUser)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDClan;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iUser;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__GetChatMemberByIndex_Private_Static_SteamId_IntPtr_SteamId_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x000185C8 File Offset: 0x000167C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931930, XrefRangeEnd = 931932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamId GetChatMemberByIndex(SteamId steamIDClan, int iUser)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDClan;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iUser;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_GetChatMemberByIndex_Internal_SteamId_SteamId_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00018620 File Offset: 0x00016820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931932, XrefRangeEnd = 931935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SendClanChatMessage(IntPtr self, SteamId steamIDClanChat, string pchText)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDClanChat;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__SendClanChatMessage_Private_Static_Boolean_IntPtr_SteamId_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00018680 File Offset: 0x00016880
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931938, RefRangeEnd = 931939, XrefRangeStart = 931935, XrefRangeEnd = 931938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SendClanChatMessage(SteamId steamIDClanChat, string pchText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDClanChat;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_SendClanChatMessage_Internal_Boolean_SteamId_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x000186DC File Offset: 0x000168DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931939, XrefRangeEnd = 931941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetClanChatMessage(IntPtr self, SteamId steamIDClanChat, int iMessage, IntPtr prgchText, int cchTextMax, ref ChatEntryType peChatEntryType, ref SteamId psteamidChatter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDClanChat;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iMessage;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prgchText;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cchTextMax;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &peChatEntryType;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &psteamidChatter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__GetClanChatMessage_Private_Static_Int32_IntPtr_SteamId_Int32_IntPtr_Int32_byref_ChatEntryType_byref_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00018770 File Offset: 0x00016970
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931943, RefRangeEnd = 931944, XrefRangeStart = 931941, XrefRangeEnd = 931943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetClanChatMessage(SteamId steamIDClanChat, int iMessage, IntPtr prgchText, int cchTextMax, ref ChatEntryType peChatEntryType, ref SteamId psteamidChatter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDClanChat;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iMessage;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prgchText;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cchTextMax;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &peChatEntryType;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &psteamidChatter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_GetClanChatMessage_Internal_Int32_SteamId_Int32_IntPtr_Int32_byref_ChatEntryType_byref_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00018804 File Offset: 0x00016A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931944, XrefRangeEnd = 931946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _IsClanChatAdmin(IntPtr self, SteamId steamIDClanChat, SteamId steamIDUser)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDClanChat;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDUser;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__IsClanChatAdmin_Private_Static_Boolean_IntPtr_SteamId_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00018860 File Offset: 0x00016A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931946, XrefRangeEnd = 931948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsClanChatAdmin(SteamId steamIDClanChat, SteamId steamIDUser)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDClanChat;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDUser;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_IsClanChatAdmin_Internal_Boolean_SteamId_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x000188B8 File Offset: 0x00016AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931948, XrefRangeEnd = 931950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _IsClanChatWindowOpenInSteam(IntPtr self, SteamId steamIDClanChat)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDClanChat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__IsClanChatWindowOpenInSteam_Private_Static_Boolean_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00018904 File Offset: 0x00016B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931950, XrefRangeEnd = 931952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsClanChatWindowOpenInSteam(SteamId steamIDClanChat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDClanChat;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_IsClanChatWindowOpenInSteam_Internal_Boolean_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00018950 File Offset: 0x00016B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931952, XrefRangeEnd = 931954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _OpenClanChatWindowInSteam(IntPtr self, SteamId steamIDClanChat)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDClanChat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__OpenClanChatWindowInSteam_Private_Static_Boolean_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0001899C File Offset: 0x00016B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931954, XrefRangeEnd = 931956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OpenClanChatWindowInSteam(SteamId steamIDClanChat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDClanChat;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_OpenClanChatWindowInSteam_Internal_Boolean_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x000189E8 File Offset: 0x00016BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931956, XrefRangeEnd = 931958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _CloseClanChatWindowInSteam(IntPtr self, SteamId steamIDClanChat)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDClanChat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__CloseClanChatWindowInSteam_Private_Static_Boolean_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00018A34 File Offset: 0x00016C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931958, XrefRangeEnd = 931960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CloseClanChatWindowInSteam(SteamId steamIDClanChat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDClanChat;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_CloseClanChatWindowInSteam_Internal_Boolean_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00018A80 File Offset: 0x00016C80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931960, XrefRangeEnd = 931962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetListenForFriendsMessages(IntPtr self, bool bInterceptEnabled)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bInterceptEnabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__SetListenForFriendsMessages_Private_Static_Boolean_IntPtr_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00018ACC File Offset: 0x00016CCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931964, RefRangeEnd = 931965, XrefRangeStart = 931962, XrefRangeEnd = 931964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetListenForFriendsMessages(bool bInterceptEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bInterceptEnabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_SetListenForFriendsMessages_Internal_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00018B18 File Offset: 0x00016D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931965, XrefRangeEnd = 931968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _ReplyToFriendMessage(IntPtr self, SteamId steamIDFriend, string pchMsgToSend)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDFriend;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchMsgToSend);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__ReplyToFriendMessage_Private_Static_Boolean_IntPtr_SteamId_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00018B78 File Offset: 0x00016D78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931971, RefRangeEnd = 931972, XrefRangeStart = 931968, XrefRangeEnd = 931971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReplyToFriendMessage(SteamId steamIDFriend, string pchMsgToSend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDFriend;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchMsgToSend);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_ReplyToFriendMessage_Internal_Boolean_SteamId_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00018BD4 File Offset: 0x00016DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931972, XrefRangeEnd = 931974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetFriendMessage(IntPtr self, SteamId steamIDFriend, int iMessageID, IntPtr pvData, int cubData, ref ChatEntryType peChatEntryType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDFriend;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iMessageID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pvData;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubData;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &peChatEntryType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__GetFriendMessage_Private_Static_Int32_IntPtr_SteamId_Int32_IntPtr_Int32_byref_ChatEntryType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00018C58 File Offset: 0x00016E58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931976, RefRangeEnd = 931977, XrefRangeStart = 931974, XrefRangeEnd = 931976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetFriendMessage(SteamId steamIDFriend, int iMessageID, IntPtr pvData, int cubData, ref ChatEntryType peChatEntryType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDFriend;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iMessageID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pvData;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubData;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &peChatEntryType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_GetFriendMessage_Internal_Int32_SteamId_Int32_IntPtr_Int32_byref_ChatEntryType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00018CDC File Offset: 0x00016EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931977, XrefRangeEnd = 931979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t _GetFollowerCount(IntPtr self, SteamId steamID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__GetFollowerCount_Private_Static_SteamAPICall_t_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00018D28 File Offset: 0x00016F28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931984, RefRangeEnd = 931985, XrefRangeStart = 931979, XrefRangeEnd = 931984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<FriendsGetFollowerCount_t> GetFollowerCount(SteamId steamID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_GetFollowerCount_Internal_CallResult_1_FriendsGetFollowerCount_t_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CallResult<FriendsGetFollowerCount_t>(intPtr);
			}
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00018D6C File Offset: 0x00016F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931985, XrefRangeEnd = 931987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t _IsFollowing(IntPtr self, SteamId steamID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__IsFollowing_Private_Static_SteamAPICall_t_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00018DB8 File Offset: 0x00016FB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931992, RefRangeEnd = 931993, XrefRangeStart = 931987, XrefRangeEnd = 931992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<FriendsIsFollowing_t> IsFollowing(SteamId steamID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_IsFollowing_Internal_CallResult_1_FriendsIsFollowing_t_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CallResult<FriendsIsFollowing_t>(intPtr);
			}
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00018DFC File Offset: 0x00016FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931993, XrefRangeEnd = 931995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t _EnumerateFollowingList(IntPtr self, uint unStartIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unStartIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__EnumerateFollowingList_Private_Static_SteamAPICall_t_IntPtr_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00018E48 File Offset: 0x00017048
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 932000, RefRangeEnd = 932001, XrefRangeStart = 931995, XrefRangeEnd = 932000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<FriendsEnumerateFollowingList_t> EnumerateFollowingList(uint unStartIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unStartIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_EnumerateFollowingList_Internal_CallResult_1_FriendsEnumerateFollowingList_t_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CallResult<FriendsEnumerateFollowingList_t>(intPtr);
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00018E8C File Offset: 0x0001708C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932001, XrefRangeEnd = 932003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _IsClanPublic(IntPtr self, SteamId steamIDClan)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDClan;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__IsClanPublic_Private_Static_Boolean_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00018ED8 File Offset: 0x000170D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 932005, RefRangeEnd = 932006, XrefRangeStart = 932003, XrefRangeEnd = 932005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsClanPublic(SteamId steamIDClan)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDClan;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_IsClanPublic_Internal_Boolean_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00018F24 File Offset: 0x00017124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932006, XrefRangeEnd = 932008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _IsClanOfficialGameGroup(IntPtr self, SteamId steamIDClan)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDClan;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__IsClanOfficialGameGroup_Private_Static_Boolean_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00018F70 File Offset: 0x00017170
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 932010, RefRangeEnd = 932011, XrefRangeStart = 932008, XrefRangeEnd = 932010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsClanOfficialGameGroup(SteamId steamIDClan)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDClan;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_IsClanOfficialGameGroup_Internal_Boolean_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00018FBC File Offset: 0x000171BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932011, XrefRangeEnd = 932013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetNumChatsWithUnreadPriorityMessages(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__GetNumChatsWithUnreadPriorityMessages_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00018FFC File Offset: 0x000171FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932013, XrefRangeEnd = 932015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetNumChatsWithUnreadPriorityMessages()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_GetNumChatsWithUnreadPriorityMessages_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00019038 File Offset: 0x00017238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932015, XrefRangeEnd = 932017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _ActivateGameOverlayRemotePlayTogetherInviteDialog(IntPtr self, SteamId steamIDLobby)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDLobby;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__ActivateGameOverlayRemotePlayTogetherInviteDialog_Private_Static_Void_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00019078 File Offset: 0x00017278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932017, XrefRangeEnd = 932019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateGameOverlayRemotePlayTogetherInviteDialog(SteamId steamIDLobby)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_ActivateGameOverlayRemotePlayTogetherInviteDialog_Internal_Void_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x000190B8 File Offset: 0x000172B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932019, XrefRangeEnd = 932022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _RegisterProtocolInOverlayBrowser(IntPtr self, string pchProtocol)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchProtocol);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__RegisterProtocolInOverlayBrowser_Private_Static_Boolean_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00019108 File Offset: 0x00017308
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 932025, RefRangeEnd = 932026, XrefRangeStart = 932022, XrefRangeEnd = 932025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RegisterProtocolInOverlayBrowser(string pchProtocol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchProtocol);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_RegisterProtocolInOverlayBrowser_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00019158 File Offset: 0x00017358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932026, XrefRangeEnd = 932029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _ActivateGameOverlayInviteDialogConnectString(IntPtr self, string pchConnectString)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchConnectString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr__ActivateGameOverlayInviteDialogConnectString_Private_Static_Void_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0001919C File Offset: 0x0001739C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932029, XrefRangeEnd = 932032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateGameOverlayInviteDialogConnectString(string pchConnectString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchConnectString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamFriends.NativeMethodInfoPtr_ActivateGameOverlayInviteDialogConnectString_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x000022F7 File Offset: 0x000004F7
		public ISteamFriends(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeMethodInfoPtr_SteamAPI_SteamFriends_v017_Internal_Static_IntPtr_0;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeMethodInfoPtr__GetPersonaName_Private_Static_Utf8StringPointer_IntPtr_0;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeMethodInfoPtr_GetPersonaName_Internal_String_0;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeMethodInfoPtr__SetPersonaName_Private_Static_SteamAPICall_t_IntPtr_String_0;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeMethodInfoPtr_SetPersonaName_Internal_CallResult_1_SetPersonaNameResponse_t_String_0;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeMethodInfoPtr__GetPersonaState_Private_Static_FriendState_IntPtr_0;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeMethodInfoPtr_GetPersonaState_Internal_FriendState_0;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeMethodInfoPtr__GetFriendCount_Private_Static_Int32_IntPtr_Int32_0;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendCount_Internal_Int32_Int32_0;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeMethodInfoPtr__GetFriendByIndex_Private_Static_SteamId_IntPtr_Int32_Int32_0;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendByIndex_Internal_SteamId_Int32_Int32_0;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeMethodInfoPtr__GetFriendRelationship_Private_Static_Relationship_IntPtr_SteamId_0;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendRelationship_Internal_Relationship_SteamId_0;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeMethodInfoPtr__GetFriendPersonaState_Private_Static_FriendState_IntPtr_SteamId_0;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendPersonaState_Internal_FriendState_SteamId_0;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeMethodInfoPtr__GetFriendPersonaName_Private_Static_Utf8StringPointer_IntPtr_SteamId_0;

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendPersonaName_Internal_String_SteamId_0;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeMethodInfoPtr__GetFriendGamePlayed_Private_Static_Boolean_IntPtr_SteamId_byref_FriendGameInfo_t_0;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendGamePlayed_Internal_Boolean_SteamId_byref_FriendGameInfo_t_0;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeMethodInfoPtr__GetFriendPersonaNameHistory_Private_Static_Utf8StringPointer_IntPtr_SteamId_Int32_0;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendPersonaNameHistory_Internal_String_SteamId_Int32_0;

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeMethodInfoPtr__GetFriendSteamLevel_Private_Static_Int32_IntPtr_SteamId_0;

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendSteamLevel_Internal_Int32_SteamId_0;

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeMethodInfoPtr__GetPlayerNickname_Private_Static_Utf8StringPointer_IntPtr_SteamId_0;

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerNickname_Internal_String_SteamId_0;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeMethodInfoPtr__GetFriendsGroupCount_Private_Static_Int32_IntPtr_0;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendsGroupCount_Internal_Int32_0;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeMethodInfoPtr__GetFriendsGroupIDByIndex_Private_Static_FriendsGroupID_t_IntPtr_Int32_0;

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendsGroupIDByIndex_Internal_FriendsGroupID_t_Int32_0;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeMethodInfoPtr__GetFriendsGroupName_Private_Static_Utf8StringPointer_IntPtr_FriendsGroupID_t_0;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendsGroupName_Internal_String_FriendsGroupID_t_0;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeMethodInfoPtr__GetFriendsGroupMembersCount_Private_Static_Int32_IntPtr_FriendsGroupID_t_0;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendsGroupMembersCount_Internal_Int32_FriendsGroupID_t_0;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeMethodInfoPtr__GetFriendsGroupMembersList_Private_Static_Void_IntPtr_FriendsGroupID_t_Il2CppStructArray_1_SteamId_Int32_0;

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendsGroupMembersList_Internal_Void_FriendsGroupID_t_Il2CppStructArray_1_SteamId_Int32_0;

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeMethodInfoPtr__HasFriend_Private_Static_Boolean_IntPtr_SteamId_Int32_0;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeMethodInfoPtr_HasFriend_Internal_Boolean_SteamId_Int32_0;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeMethodInfoPtr__GetClanCount_Private_Static_Int32_IntPtr_0;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeMethodInfoPtr_GetClanCount_Internal_Int32_0;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeMethodInfoPtr__GetClanByIndex_Private_Static_SteamId_IntPtr_Int32_0;

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeMethodInfoPtr_GetClanByIndex_Internal_SteamId_Int32_0;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeMethodInfoPtr__GetClanName_Private_Static_Utf8StringPointer_IntPtr_SteamId_0;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeMethodInfoPtr_GetClanName_Internal_String_SteamId_0;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeMethodInfoPtr__GetClanTag_Private_Static_Utf8StringPointer_IntPtr_SteamId_0;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeMethodInfoPtr_GetClanTag_Internal_String_SteamId_0;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeMethodInfoPtr__GetClanActivityCounts_Private_Static_Boolean_IntPtr_SteamId_byref_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeMethodInfoPtr_GetClanActivityCounts_Internal_Boolean_SteamId_byref_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeMethodInfoPtr__DownloadClanActivityCounts_Private_Static_SteamAPICall_t_IntPtr_Il2CppStructArray_1_SteamId_Int32_0;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeMethodInfoPtr_DownloadClanActivityCounts_Internal_CallResult_1_DownloadClanActivityCountsResult_t_Il2CppStructArray_1_SteamId_Int32_0;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeMethodInfoPtr__GetFriendCountFromSource_Private_Static_Int32_IntPtr_SteamId_0;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendCountFromSource_Internal_Int32_SteamId_0;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeMethodInfoPtr__GetFriendFromSourceByIndex_Private_Static_SteamId_IntPtr_SteamId_Int32_0;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendFromSourceByIndex_Internal_SteamId_SteamId_Int32_0;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeMethodInfoPtr__IsUserInSource_Private_Static_Boolean_IntPtr_SteamId_SteamId_0;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeMethodInfoPtr_IsUserInSource_Internal_Boolean_SteamId_SteamId_0;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeMethodInfoPtr__SetInGameVoiceSpeaking_Private_Static_Void_IntPtr_SteamId_Boolean_0;

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeMethodInfoPtr_SetInGameVoiceSpeaking_Internal_Void_SteamId_Boolean_0;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeMethodInfoPtr__ActivateGameOverlay_Private_Static_Void_IntPtr_String_0;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeMethodInfoPtr_ActivateGameOverlay_Internal_Void_String_0;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeMethodInfoPtr__ActivateGameOverlayToUser_Private_Static_Void_IntPtr_String_SteamId_0;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeMethodInfoPtr_ActivateGameOverlayToUser_Internal_Void_String_SteamId_0;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeMethodInfoPtr__ActivateGameOverlayToWebPage_Private_Static_Void_IntPtr_String_ActivateGameOverlayToWebPageMode_0;

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeMethodInfoPtr_ActivateGameOverlayToWebPage_Internal_Void_String_ActivateGameOverlayToWebPageMode_0;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeMethodInfoPtr__ActivateGameOverlayToStore_Private_Static_Void_IntPtr_AppId_OverlayToStoreFlag_0;

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeMethodInfoPtr_ActivateGameOverlayToStore_Internal_Void_AppId_OverlayToStoreFlag_0;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeMethodInfoPtr__SetPlayedWith_Private_Static_Void_IntPtr_SteamId_0;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayedWith_Internal_Void_SteamId_0;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeMethodInfoPtr__ActivateGameOverlayInviteDialog_Private_Static_Void_IntPtr_SteamId_0;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeMethodInfoPtr_ActivateGameOverlayInviteDialog_Internal_Void_SteamId_0;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeMethodInfoPtr__GetSmallFriendAvatar_Private_Static_Int32_IntPtr_SteamId_0;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeMethodInfoPtr_GetSmallFriendAvatar_Internal_Int32_SteamId_0;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeMethodInfoPtr__GetMediumFriendAvatar_Private_Static_Int32_IntPtr_SteamId_0;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeMethodInfoPtr_GetMediumFriendAvatar_Internal_Int32_SteamId_0;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeMethodInfoPtr__GetLargeFriendAvatar_Private_Static_Int32_IntPtr_SteamId_0;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeMethodInfoPtr_GetLargeFriendAvatar_Internal_Int32_SteamId_0;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeMethodInfoPtr__RequestUserInformation_Private_Static_Boolean_IntPtr_SteamId_Boolean_0;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeMethodInfoPtr_RequestUserInformation_Internal_Boolean_SteamId_Boolean_0;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeMethodInfoPtr__RequestClanOfficerList_Private_Static_SteamAPICall_t_IntPtr_SteamId_0;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeMethodInfoPtr_RequestClanOfficerList_Internal_CallResult_1_ClanOfficerListResponse_t_SteamId_0;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeMethodInfoPtr__GetClanOwner_Private_Static_SteamId_IntPtr_SteamId_0;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeMethodInfoPtr_GetClanOwner_Internal_SteamId_SteamId_0;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeMethodInfoPtr__GetClanOfficerCount_Private_Static_Int32_IntPtr_SteamId_0;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeMethodInfoPtr_GetClanOfficerCount_Internal_Int32_SteamId_0;

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeMethodInfoPtr__GetClanOfficerByIndex_Private_Static_SteamId_IntPtr_SteamId_Int32_0;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeMethodInfoPtr_GetClanOfficerByIndex_Internal_SteamId_SteamId_Int32_0;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeMethodInfoPtr__GetUserRestrictions_Private_Static_UInt32_IntPtr_0;

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeMethodInfoPtr_GetUserRestrictions_Internal_UInt32_0;

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeMethodInfoPtr__SetRichPresence_Private_Static_Boolean_IntPtr_String_String_0;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeMethodInfoPtr_SetRichPresence_Internal_Boolean_String_String_0;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeMethodInfoPtr__ClearRichPresence_Private_Static_Void_IntPtr_0;

		// Token: 0x0400023F RID: 575
		private static readonly IntPtr NativeMethodInfoPtr_ClearRichPresence_Internal_Void_0;

		// Token: 0x04000240 RID: 576
		private static readonly IntPtr NativeMethodInfoPtr__GetFriendRichPresence_Private_Static_Utf8StringPointer_IntPtr_SteamId_String_0;

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendRichPresence_Internal_String_SteamId_String_0;

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeMethodInfoPtr__GetFriendRichPresenceKeyCount_Private_Static_Int32_IntPtr_SteamId_0;

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendRichPresenceKeyCount_Internal_Int32_SteamId_0;

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeMethodInfoPtr__GetFriendRichPresenceKeyByIndex_Private_Static_Utf8StringPointer_IntPtr_SteamId_Int32_0;

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendRichPresenceKeyByIndex_Internal_String_SteamId_Int32_0;

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeMethodInfoPtr__RequestFriendRichPresence_Private_Static_Void_IntPtr_SteamId_0;

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeMethodInfoPtr_RequestFriendRichPresence_Internal_Void_SteamId_0;

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeMethodInfoPtr__InviteUserToGame_Private_Static_Boolean_IntPtr_SteamId_String_0;

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeMethodInfoPtr_InviteUserToGame_Internal_Boolean_SteamId_String_0;

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeMethodInfoPtr__GetCoplayFriendCount_Private_Static_Int32_IntPtr_0;

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeMethodInfoPtr_GetCoplayFriendCount_Internal_Int32_0;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeMethodInfoPtr__GetCoplayFriend_Private_Static_SteamId_IntPtr_Int32_0;

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeMethodInfoPtr_GetCoplayFriend_Internal_SteamId_Int32_0;

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeMethodInfoPtr__GetFriendCoplayTime_Private_Static_Int32_IntPtr_SteamId_0;

		// Token: 0x0400024F RID: 591
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendCoplayTime_Internal_Int32_SteamId_0;

		// Token: 0x04000250 RID: 592
		private static readonly IntPtr NativeMethodInfoPtr__GetFriendCoplayGame_Private_Static_AppId_IntPtr_SteamId_0;

		// Token: 0x04000251 RID: 593
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendCoplayGame_Internal_AppId_SteamId_0;

		// Token: 0x04000252 RID: 594
		private static readonly IntPtr NativeMethodInfoPtr__JoinClanChatRoom_Private_Static_SteamAPICall_t_IntPtr_SteamId_0;

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeMethodInfoPtr_JoinClanChatRoom_Internal_CallResult_1_JoinClanChatRoomCompletionResult_t_SteamId_0;

		// Token: 0x04000254 RID: 596
		private static readonly IntPtr NativeMethodInfoPtr__LeaveClanChatRoom_Private_Static_Boolean_IntPtr_SteamId_0;

		// Token: 0x04000255 RID: 597
		private static readonly IntPtr NativeMethodInfoPtr_LeaveClanChatRoom_Internal_Boolean_SteamId_0;

		// Token: 0x04000256 RID: 598
		private static readonly IntPtr NativeMethodInfoPtr__GetClanChatMemberCount_Private_Static_Int32_IntPtr_SteamId_0;

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeMethodInfoPtr_GetClanChatMemberCount_Internal_Int32_SteamId_0;

		// Token: 0x04000258 RID: 600
		private static readonly IntPtr NativeMethodInfoPtr__GetChatMemberByIndex_Private_Static_SteamId_IntPtr_SteamId_Int32_0;

		// Token: 0x04000259 RID: 601
		private static readonly IntPtr NativeMethodInfoPtr_GetChatMemberByIndex_Internal_SteamId_SteamId_Int32_0;

		// Token: 0x0400025A RID: 602
		private static readonly IntPtr NativeMethodInfoPtr__SendClanChatMessage_Private_Static_Boolean_IntPtr_SteamId_String_0;

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeMethodInfoPtr_SendClanChatMessage_Internal_Boolean_SteamId_String_0;

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeMethodInfoPtr__GetClanChatMessage_Private_Static_Int32_IntPtr_SteamId_Int32_IntPtr_Int32_byref_ChatEntryType_byref_SteamId_0;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeMethodInfoPtr_GetClanChatMessage_Internal_Int32_SteamId_Int32_IntPtr_Int32_byref_ChatEntryType_byref_SteamId_0;

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeMethodInfoPtr__IsClanChatAdmin_Private_Static_Boolean_IntPtr_SteamId_SteamId_0;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeMethodInfoPtr_IsClanChatAdmin_Internal_Boolean_SteamId_SteamId_0;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeMethodInfoPtr__IsClanChatWindowOpenInSteam_Private_Static_Boolean_IntPtr_SteamId_0;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeMethodInfoPtr_IsClanChatWindowOpenInSteam_Internal_Boolean_SteamId_0;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeMethodInfoPtr__OpenClanChatWindowInSteam_Private_Static_Boolean_IntPtr_SteamId_0;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeMethodInfoPtr_OpenClanChatWindowInSteam_Internal_Boolean_SteamId_0;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeMethodInfoPtr__CloseClanChatWindowInSteam_Private_Static_Boolean_IntPtr_SteamId_0;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeMethodInfoPtr_CloseClanChatWindowInSteam_Internal_Boolean_SteamId_0;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeMethodInfoPtr__SetListenForFriendsMessages_Private_Static_Boolean_IntPtr_Boolean_0;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeMethodInfoPtr_SetListenForFriendsMessages_Internal_Boolean_Boolean_0;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeMethodInfoPtr__ReplyToFriendMessage_Private_Static_Boolean_IntPtr_SteamId_String_0;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeMethodInfoPtr_ReplyToFriendMessage_Internal_Boolean_SteamId_String_0;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeMethodInfoPtr__GetFriendMessage_Private_Static_Int32_IntPtr_SteamId_Int32_IntPtr_Int32_byref_ChatEntryType_0;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendMessage_Internal_Int32_SteamId_Int32_IntPtr_Int32_byref_ChatEntryType_0;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeMethodInfoPtr__GetFollowerCount_Private_Static_SteamAPICall_t_IntPtr_SteamId_0;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeMethodInfoPtr_GetFollowerCount_Internal_CallResult_1_FriendsGetFollowerCount_t_SteamId_0;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeMethodInfoPtr__IsFollowing_Private_Static_SteamAPICall_t_IntPtr_SteamId_0;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeMethodInfoPtr_IsFollowing_Internal_CallResult_1_FriendsIsFollowing_t_SteamId_0;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeMethodInfoPtr__EnumerateFollowingList_Private_Static_SteamAPICall_t_IntPtr_UInt32_0;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeMethodInfoPtr_EnumerateFollowingList_Internal_CallResult_1_FriendsEnumerateFollowingList_t_UInt32_0;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeMethodInfoPtr__IsClanPublic_Private_Static_Boolean_IntPtr_SteamId_0;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeMethodInfoPtr_IsClanPublic_Internal_Boolean_SteamId_0;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeMethodInfoPtr__IsClanOfficialGameGroup_Private_Static_Boolean_IntPtr_SteamId_0;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeMethodInfoPtr_IsClanOfficialGameGroup_Internal_Boolean_SteamId_0;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeMethodInfoPtr__GetNumChatsWithUnreadPriorityMessages_Private_Static_Int32_IntPtr_0;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeMethodInfoPtr_GetNumChatsWithUnreadPriorityMessages_Internal_Int32_0;

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeMethodInfoPtr__ActivateGameOverlayRemotePlayTogetherInviteDialog_Private_Static_Void_IntPtr_SteamId_0;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeMethodInfoPtr_ActivateGameOverlayRemotePlayTogetherInviteDialog_Internal_Void_SteamId_0;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeMethodInfoPtr__RegisterProtocolInOverlayBrowser_Private_Static_Boolean_IntPtr_String_0;

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeMethodInfoPtr_RegisterProtocolInOverlayBrowser_Internal_Boolean_String_0;

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeMethodInfoPtr__ActivateGameOverlayInviteDialogConnectString_Private_Static_Void_IntPtr_String_0;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeMethodInfoPtr_ActivateGameOverlayInviteDialogConnectString_Internal_Void_String_0;
	}
}
