using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x02000019 RID: 25
	public class ISteamMatchmaking : SteamInterface
	{
		// Token: 0x060003A6 RID: 934 RVA: 0x00024E80 File Offset: 0x00023080
		// Note: this type is marked as 'beforefieldinit'.
		static ISteamMatchmaking()
		{
			Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "ISteamMatchmaking");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr);
			ISteamMatchmaking.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664183);
			ISteamMatchmaking.NativeMethodInfoPtr_SteamAPI_SteamMatchmaking_v009_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664184);
			ISteamMatchmaking.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664185);
			ISteamMatchmaking.NativeMethodInfoPtr__GetFavoriteGameCount_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664186);
			ISteamMatchmaking.NativeMethodInfoPtr_GetFavoriteGameCount_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664187);
			ISteamMatchmaking.NativeMethodInfoPtr__GetFavoriteGame_Private_Static_Boolean_IntPtr_Int32_byref_AppId_byref_UInt32_byref_UInt16_byref_UInt16_byref_UInt32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664188);
			ISteamMatchmaking.NativeMethodInfoPtr_GetFavoriteGame_Internal_Boolean_Int32_byref_AppId_byref_UInt32_byref_UInt16_byref_UInt16_byref_UInt32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664189);
			ISteamMatchmaking.NativeMethodInfoPtr__AddFavoriteGame_Private_Static_Int32_IntPtr_AppId_UInt32_UInt16_UInt16_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664190);
			ISteamMatchmaking.NativeMethodInfoPtr_AddFavoriteGame_Internal_Int32_AppId_UInt32_UInt16_UInt16_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664191);
			ISteamMatchmaking.NativeMethodInfoPtr__RemoveFavoriteGame_Private_Static_Boolean_IntPtr_AppId_UInt32_UInt16_UInt16_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664192);
			ISteamMatchmaking.NativeMethodInfoPtr_RemoveFavoriteGame_Internal_Boolean_AppId_UInt32_UInt16_UInt16_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664193);
			ISteamMatchmaking.NativeMethodInfoPtr__RequestLobbyList_Private_Static_SteamAPICall_t_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664194);
			ISteamMatchmaking.NativeMethodInfoPtr_RequestLobbyList_Internal_CallResult_1_LobbyMatchList_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664195);
			ISteamMatchmaking.NativeMethodInfoPtr__AddRequestLobbyListStringFilter_Private_Static_Void_IntPtr_String_String_LobbyComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664196);
			ISteamMatchmaking.NativeMethodInfoPtr_AddRequestLobbyListStringFilter_Internal_Void_String_String_LobbyComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664197);
			ISteamMatchmaking.NativeMethodInfoPtr__AddRequestLobbyListNumericalFilter_Private_Static_Void_IntPtr_String_Int32_LobbyComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664198);
			ISteamMatchmaking.NativeMethodInfoPtr_AddRequestLobbyListNumericalFilter_Internal_Void_String_Int32_LobbyComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664199);
			ISteamMatchmaking.NativeMethodInfoPtr__AddRequestLobbyListNearValueFilter_Private_Static_Void_IntPtr_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664200);
			ISteamMatchmaking.NativeMethodInfoPtr_AddRequestLobbyListNearValueFilter_Internal_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664201);
			ISteamMatchmaking.NativeMethodInfoPtr__AddRequestLobbyListFilterSlotsAvailable_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664202);
			ISteamMatchmaking.NativeMethodInfoPtr_AddRequestLobbyListFilterSlotsAvailable_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664203);
			ISteamMatchmaking.NativeMethodInfoPtr__AddRequestLobbyListDistanceFilter_Private_Static_Void_IntPtr_LobbyDistanceFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664204);
			ISteamMatchmaking.NativeMethodInfoPtr_AddRequestLobbyListDistanceFilter_Internal_Void_LobbyDistanceFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664205);
			ISteamMatchmaking.NativeMethodInfoPtr__AddRequestLobbyListResultCountFilter_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664206);
			ISteamMatchmaking.NativeMethodInfoPtr_AddRequestLobbyListResultCountFilter_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664207);
			ISteamMatchmaking.NativeMethodInfoPtr__AddRequestLobbyListCompatibleMembersFilter_Private_Static_Void_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664208);
			ISteamMatchmaking.NativeMethodInfoPtr_AddRequestLobbyListCompatibleMembersFilter_Internal_Void_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664209);
			ISteamMatchmaking.NativeMethodInfoPtr__GetLobbyByIndex_Private_Static_SteamId_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664210);
			ISteamMatchmaking.NativeMethodInfoPtr_GetLobbyByIndex_Internal_SteamId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664211);
			ISteamMatchmaking.NativeMethodInfoPtr__CreateLobby_Private_Static_SteamAPICall_t_IntPtr_LobbyType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664212);
			ISteamMatchmaking.NativeMethodInfoPtr_CreateLobby_Internal_CallResult_1_LobbyCreated_t_LobbyType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664213);
			ISteamMatchmaking.NativeMethodInfoPtr__JoinLobby_Private_Static_SteamAPICall_t_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664214);
			ISteamMatchmaking.NativeMethodInfoPtr_JoinLobby_Internal_CallResult_1_LobbyEnter_t_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664215);
			ISteamMatchmaking.NativeMethodInfoPtr__LeaveLobby_Private_Static_Void_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664216);
			ISteamMatchmaking.NativeMethodInfoPtr_LeaveLobby_Internal_Void_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664217);
			ISteamMatchmaking.NativeMethodInfoPtr__InviteUserToLobby_Private_Static_Boolean_IntPtr_SteamId_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664218);
			ISteamMatchmaking.NativeMethodInfoPtr_InviteUserToLobby_Internal_Boolean_SteamId_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664219);
			ISteamMatchmaking.NativeMethodInfoPtr__GetNumLobbyMembers_Private_Static_Int32_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664220);
			ISteamMatchmaking.NativeMethodInfoPtr_GetNumLobbyMembers_Internal_Int32_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664221);
			ISteamMatchmaking.NativeMethodInfoPtr__GetLobbyMemberByIndex_Private_Static_SteamId_IntPtr_SteamId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664222);
			ISteamMatchmaking.NativeMethodInfoPtr_GetLobbyMemberByIndex_Internal_SteamId_SteamId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664223);
			ISteamMatchmaking.NativeMethodInfoPtr__GetLobbyData_Private_Static_Utf8StringPointer_IntPtr_SteamId_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664224);
			ISteamMatchmaking.NativeMethodInfoPtr_GetLobbyData_Internal_String_SteamId_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664225);
			ISteamMatchmaking.NativeMethodInfoPtr__SetLobbyData_Private_Static_Boolean_IntPtr_SteamId_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664226);
			ISteamMatchmaking.NativeMethodInfoPtr_SetLobbyData_Internal_Boolean_SteamId_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664227);
			ISteamMatchmaking.NativeMethodInfoPtr__GetLobbyDataCount_Private_Static_Int32_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664228);
			ISteamMatchmaking.NativeMethodInfoPtr_GetLobbyDataCount_Internal_Int32_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664229);
			ISteamMatchmaking.NativeMethodInfoPtr__GetLobbyDataByIndex_Private_Static_Boolean_IntPtr_SteamId_Int32_IntPtr_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664230);
			ISteamMatchmaking.NativeMethodInfoPtr_GetLobbyDataByIndex_Internal_Boolean_SteamId_Int32_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664231);
			ISteamMatchmaking.NativeMethodInfoPtr__DeleteLobbyData_Private_Static_Boolean_IntPtr_SteamId_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664232);
			ISteamMatchmaking.NativeMethodInfoPtr_DeleteLobbyData_Internal_Boolean_SteamId_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664233);
			ISteamMatchmaking.NativeMethodInfoPtr__GetLobbyMemberData_Private_Static_Utf8StringPointer_IntPtr_SteamId_SteamId_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664234);
			ISteamMatchmaking.NativeMethodInfoPtr_GetLobbyMemberData_Internal_String_SteamId_SteamId_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664235);
			ISteamMatchmaking.NativeMethodInfoPtr__SetLobbyMemberData_Private_Static_Void_IntPtr_SteamId_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664236);
			ISteamMatchmaking.NativeMethodInfoPtr_SetLobbyMemberData_Internal_Void_SteamId_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664237);
			ISteamMatchmaking.NativeMethodInfoPtr__SendLobbyChatMsg_Private_Static_Boolean_IntPtr_SteamId_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664238);
			ISteamMatchmaking.NativeMethodInfoPtr_SendLobbyChatMsg_Internal_Boolean_SteamId_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664239);
			ISteamMatchmaking.NativeMethodInfoPtr__GetLobbyChatEntry_Private_Static_Int32_IntPtr_SteamId_Int32_byref_SteamId_IntPtr_Int32_byref_ChatEntryType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664240);
			ISteamMatchmaking.NativeMethodInfoPtr_GetLobbyChatEntry_Internal_Int32_SteamId_Int32_byref_SteamId_IntPtr_Int32_byref_ChatEntryType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664241);
			ISteamMatchmaking.NativeMethodInfoPtr__RequestLobbyData_Private_Static_Boolean_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664242);
			ISteamMatchmaking.NativeMethodInfoPtr_RequestLobbyData_Internal_Boolean_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664243);
			ISteamMatchmaking.NativeMethodInfoPtr__SetLobbyGameServer_Private_Static_Void_IntPtr_SteamId_UInt32_UInt16_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664244);
			ISteamMatchmaking.NativeMethodInfoPtr_SetLobbyGameServer_Internal_Void_SteamId_UInt32_UInt16_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664245);
			ISteamMatchmaking.NativeMethodInfoPtr__GetLobbyGameServer_Private_Static_Boolean_IntPtr_SteamId_byref_UInt32_byref_UInt16_byref_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664246);
			ISteamMatchmaking.NativeMethodInfoPtr_GetLobbyGameServer_Internal_Boolean_SteamId_byref_UInt32_byref_UInt16_byref_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664247);
			ISteamMatchmaking.NativeMethodInfoPtr__SetLobbyMemberLimit_Private_Static_Boolean_IntPtr_SteamId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664248);
			ISteamMatchmaking.NativeMethodInfoPtr_SetLobbyMemberLimit_Internal_Boolean_SteamId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664249);
			ISteamMatchmaking.NativeMethodInfoPtr__GetLobbyMemberLimit_Private_Static_Int32_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664250);
			ISteamMatchmaking.NativeMethodInfoPtr_GetLobbyMemberLimit_Internal_Int32_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664251);
			ISteamMatchmaking.NativeMethodInfoPtr__SetLobbyType_Private_Static_Boolean_IntPtr_SteamId_LobbyType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664252);
			ISteamMatchmaking.NativeMethodInfoPtr_SetLobbyType_Internal_Boolean_SteamId_LobbyType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664253);
			ISteamMatchmaking.NativeMethodInfoPtr__SetLobbyJoinable_Private_Static_Boolean_IntPtr_SteamId_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664254);
			ISteamMatchmaking.NativeMethodInfoPtr_SetLobbyJoinable_Internal_Boolean_SteamId_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664255);
			ISteamMatchmaking.NativeMethodInfoPtr__GetLobbyOwner_Private_Static_SteamId_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664256);
			ISteamMatchmaking.NativeMethodInfoPtr_GetLobbyOwner_Internal_SteamId_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664257);
			ISteamMatchmaking.NativeMethodInfoPtr__SetLobbyOwner_Private_Static_Boolean_IntPtr_SteamId_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664258);
			ISteamMatchmaking.NativeMethodInfoPtr_SetLobbyOwner_Internal_Boolean_SteamId_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664259);
			ISteamMatchmaking.NativeMethodInfoPtr__SetLinkedLobby_Private_Static_Boolean_IntPtr_SteamId_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664260);
			ISteamMatchmaking.NativeMethodInfoPtr_SetLinkedLobby_Internal_Boolean_SteamId_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr, 100664261);
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x000254DC File Offset: 0x000236DC
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 930944, RefRangeEnd = 930966, XrefRangeStart = 930944, XrefRangeEnd = 930966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISteamMatchmaking(bool IsGameServer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmaking>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref IsGameServer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00025524 File Offset: 0x00023724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933249, XrefRangeEnd = 933251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr SteamAPI_SteamMatchmaking_v009()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr_SteamAPI_SteamMatchmaking_v009_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00025554 File Offset: 0x00023754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IntPtr GetUserInterfacePointer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamMatchmaking.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0002559C File Offset: 0x0002379C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933251, XrefRangeEnd = 933253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetFavoriteGameCount(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr__GetFavoriteGameCount_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003AB RID: 939 RVA: 0x000255DC File Offset: 0x000237DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 933255, RefRangeEnd = 933257, XrefRangeStart = 933253, XrefRangeEnd = 933255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetFavoriteGameCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr_GetFavoriteGameCount_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00025618 File Offset: 0x00023818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933257, XrefRangeEnd = 933259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetFavoriteGame(IntPtr self, int iGame, ref AppId pnAppID, ref uint pnIP, ref ushort pnConnPort, ref ushort pnQueryPort, ref uint punFlags, ref uint pRTime32LastPlayedOnServer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iGame;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnAppID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnIP;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnConnPort;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnQueryPort;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punFlags;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pRTime32LastPlayedOnServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr__GetFavoriteGame_Private_Static_Boolean_IntPtr_Int32_byref_AppId_byref_UInt32_byref_UInt16_byref_UInt16_byref_UInt32_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003AD RID: 941 RVA: 0x000256BC File Offset: 0x000238BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 933261, RefRangeEnd = 933263, XrefRangeStart = 933259, XrefRangeEnd = 933261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetFavoriteGame(int iGame, ref AppId pnAppID, ref uint pnIP, ref ushort pnConnPort, ref ushort pnQueryPort, ref uint punFlags, ref uint pRTime32LastPlayedOnServer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iGame;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnAppID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnIP;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnConnPort;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnQueryPort;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punFlags;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pRTime32LastPlayedOnServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr_GetFavoriteGame_Internal_Boolean_Int32_byref_AppId_byref_UInt32_byref_UInt16_byref_UInt16_byref_UInt32_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00025760 File Offset: 0x00023960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933263, XrefRangeEnd = 933265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _AddFavoriteGame(IntPtr self, AppId nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nAppID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nIP;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nConnPort;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nQueryPort;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unFlags;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rTime32LastPlayedOnServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr__AddFavoriteGame_Private_Static_Int32_IntPtr_AppId_UInt32_UInt16_UInt16_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003AF RID: 943 RVA: 0x000257F4 File Offset: 0x000239F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 933267, RefRangeEnd = 933269, XrefRangeStart = 933265, XrefRangeEnd = 933267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int AddFavoriteGame(AppId nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nAppID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nIP;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nConnPort;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nQueryPort;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unFlags;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rTime32LastPlayedOnServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr_AddFavoriteGame_Internal_Int32_AppId_UInt32_UInt16_UInt16_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00025884 File Offset: 0x00023A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933269, XrefRangeEnd = 933271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _RemoveFavoriteGame(IntPtr self, AppId nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nAppID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nIP;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nConnPort;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nQueryPort;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr__RemoveFavoriteGame_Private_Static_Boolean_IntPtr_AppId_UInt32_UInt16_UInt16_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00025908 File Offset: 0x00023B08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 933273, RefRangeEnd = 933275, XrefRangeStart = 933271, XrefRangeEnd = 933273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RemoveFavoriteGame(AppId nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nAppID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nIP;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nConnPort;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nQueryPort;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr_RemoveFavoriteGame_Internal_Boolean_AppId_UInt32_UInt16_UInt16_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0002598C File Offset: 0x00023B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933275, XrefRangeEnd = 933277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t _RequestLobbyList(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr__RequestLobbyList_Private_Static_SteamAPICall_t_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x000259CC File Offset: 0x00023BCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933282, RefRangeEnd = 933283, XrefRangeStart = 933277, XrefRangeEnd = 933282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<LobbyMatchList_t> RequestLobbyList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr_RequestLobbyList_Internal_CallResult_1_LobbyMatchList_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new CallResult<LobbyMatchList_t>(intPtr);
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00025A04 File Offset: 0x00023C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933283, XrefRangeEnd = 933288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _AddRequestLobbyListStringFilter(IntPtr self, string pchKeyToMatch, string pchValueToMatch, LobbyComparison eComparisonType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchKeyToMatch);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchValueToMatch);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eComparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr__AddRequestLobbyListStringFilter_Private_Static_Void_IntPtr_String_String_LobbyComparison_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00025A68 File Offset: 0x00023C68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933293, RefRangeEnd = 933294, XrefRangeStart = 933288, XrefRangeEnd = 933293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRequestLobbyListStringFilter(string pchKeyToMatch, string pchValueToMatch, LobbyComparison eComparisonType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchKeyToMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchValueToMatch);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eComparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr_AddRequestLobbyListStringFilter_Internal_Void_String_String_LobbyComparison_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00025ACC File Offset: 0x00023CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933294, XrefRangeEnd = 933297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _AddRequestLobbyListNumericalFilter(IntPtr self, string pchKeyToMatch, int nValueToMatch, LobbyComparison eComparisonType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchKeyToMatch);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nValueToMatch;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eComparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr__AddRequestLobbyListNumericalFilter_Private_Static_Void_IntPtr_String_Int32_LobbyComparison_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00025B2C File Offset: 0x00023D2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933300, RefRangeEnd = 933301, XrefRangeStart = 933297, XrefRangeEnd = 933300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRequestLobbyListNumericalFilter(string pchKeyToMatch, int nValueToMatch, LobbyComparison eComparisonType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchKeyToMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nValueToMatch;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eComparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr_AddRequestLobbyListNumericalFilter_Internal_Void_String_Int32_LobbyComparison_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00025B8C File Offset: 0x00023D8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933301, XrefRangeEnd = 933304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _AddRequestLobbyListNearValueFilter(IntPtr self, string pchKeyToMatch, int nValueToBeCloseTo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchKeyToMatch);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nValueToBeCloseTo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr__AddRequestLobbyListNearValueFilter_Private_Static_Void_IntPtr_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00025BE0 File Offset: 0x00023DE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933307, RefRangeEnd = 933308, XrefRangeStart = 933304, XrefRangeEnd = 933307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRequestLobbyListNearValueFilter(string pchKeyToMatch, int nValueToBeCloseTo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchKeyToMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nValueToBeCloseTo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr_AddRequestLobbyListNearValueFilter_Internal_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00025C30 File Offset: 0x00023E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933308, XrefRangeEnd = 933310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _AddRequestLobbyListFilterSlotsAvailable(IntPtr self, int nSlotsAvailable)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nSlotsAvailable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr__AddRequestLobbyListFilterSlotsAvailable_Private_Static_Void_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00025C70 File Offset: 0x00023E70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933312, RefRangeEnd = 933313, XrefRangeStart = 933310, XrefRangeEnd = 933312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRequestLobbyListFilterSlotsAvailable(int nSlotsAvailable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nSlotsAvailable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr_AddRequestLobbyListFilterSlotsAvailable_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00025CB0 File Offset: 0x00023EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933313, XrefRangeEnd = 933315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _AddRequestLobbyListDistanceFilter(IntPtr self, LobbyDistanceFilter eLobbyDistanceFilter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eLobbyDistanceFilter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr__AddRequestLobbyListDistanceFilter_Private_Static_Void_IntPtr_LobbyDistanceFilter_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00025CF0 File Offset: 0x00023EF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933317, RefRangeEnd = 933318, XrefRangeStart = 933315, XrefRangeEnd = 933317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRequestLobbyListDistanceFilter(LobbyDistanceFilter eLobbyDistanceFilter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eLobbyDistanceFilter;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr_AddRequestLobbyListDistanceFilter_Internal_Void_LobbyDistanceFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00025D30 File Offset: 0x00023F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933318, XrefRangeEnd = 933320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _AddRequestLobbyListResultCountFilter(IntPtr self, int cMaxResults)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cMaxResults;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr__AddRequestLobbyListResultCountFilter_Private_Static_Void_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00025D70 File Offset: 0x00023F70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933322, RefRangeEnd = 933323, XrefRangeStart = 933320, XrefRangeEnd = 933322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRequestLobbyListResultCountFilter(int cMaxResults)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cMaxResults;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr_AddRequestLobbyListResultCountFilter_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00025DB0 File Offset: 0x00023FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933323, XrefRangeEnd = 933325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _AddRequestLobbyListCompatibleMembersFilter(IntPtr self, SteamId steamIDLobby)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDLobby;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr__AddRequestLobbyListCompatibleMembersFilter_Private_Static_Void_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00025DF0 File Offset: 0x00023FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933325, XrefRangeEnd = 933327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRequestLobbyListCompatibleMembersFilter(SteamId steamIDLobby)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr_AddRequestLobbyListCompatibleMembersFilter_Internal_Void_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00025E30 File Offset: 0x00024030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933327, XrefRangeEnd = 933329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamId _GetLobbyByIndex(IntPtr self, int iLobby)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iLobby;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr__GetLobbyByIndex_Private_Static_SteamId_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00025E7C File Offset: 0x0002407C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933331, RefRangeEnd = 933332, XrefRangeStart = 933329, XrefRangeEnd = 933331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamId GetLobbyByIndex(int iLobby)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iLobby;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr_GetLobbyByIndex_Internal_SteamId_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00025EC8 File Offset: 0x000240C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933332, XrefRangeEnd = 933334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t _CreateLobby(IntPtr self, LobbyType eLobbyType, int cMaxMembers)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eLobbyType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cMaxMembers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr__CreateLobby_Private_Static_SteamAPICall_t_IntPtr_LobbyType_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00025F24 File Offset: 0x00024124
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933339, RefRangeEnd = 933340, XrefRangeStart = 933334, XrefRangeEnd = 933339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<LobbyCreated_t> CreateLobby(LobbyType eLobbyType, int cMaxMembers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eLobbyType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cMaxMembers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr_CreateLobby_Internal_CallResult_1_LobbyCreated_t_LobbyType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new CallResult<LobbyCreated_t>(intPtr);
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00025F78 File Offset: 0x00024178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933340, XrefRangeEnd = 933342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t _JoinLobby(IntPtr self, SteamId steamIDLobby)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDLobby;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr__JoinLobby_Private_Static_SteamAPICall_t_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00025FC4 File Offset: 0x000241C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 933347, RefRangeEnd = 933349, XrefRangeStart = 933342, XrefRangeEnd = 933347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<LobbyEnter_t> JoinLobby(SteamId steamIDLobby)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr_JoinLobby_Internal_CallResult_1_LobbyEnter_t_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CallResult<LobbyEnter_t>(intPtr);
			}
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00026008 File Offset: 0x00024208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933349, XrefRangeEnd = 933351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _LeaveLobby(IntPtr self, SteamId steamIDLobby)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDLobby;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr__LeaveLobby_Private_Static_Void_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00026048 File Offset: 0x00024248
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933353, RefRangeEnd = 933354, XrefRangeStart = 933351, XrefRangeEnd = 933353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LeaveLobby(SteamId steamIDLobby)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr_LeaveLobby_Internal_Void_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00026088 File Offset: 0x00024288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933354, XrefRangeEnd = 933356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _InviteUserToLobby(IntPtr self, SteamId steamIDLobby, SteamId steamIDInvitee)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDLobby;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDInvitee;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr__InviteUserToLobby_Private_Static_Boolean_IntPtr_SteamId_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003CB RID: 971 RVA: 0x000260E4 File Offset: 0x000242E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933358, RefRangeEnd = 933359, XrefRangeStart = 933356, XrefRangeEnd = 933358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InviteUserToLobby(SteamId steamIDLobby, SteamId steamIDInvitee)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDInvitee;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr_InviteUserToLobby_Internal_Boolean_SteamId_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003CC RID: 972 RVA: 0x0002613C File Offset: 0x0002433C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933359, XrefRangeEnd = 933361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetNumLobbyMembers(IntPtr self, SteamId steamIDLobby)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDLobby;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr__GetNumLobbyMembers_Private_Static_Int32_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00026188 File Offset: 0x00024388
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 933363, RefRangeEnd = 933365, XrefRangeStart = 933361, XrefRangeEnd = 933363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetNumLobbyMembers(SteamId steamIDLobby)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr_GetNumLobbyMembers_Internal_Int32_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003CE RID: 974 RVA: 0x000261D4 File Offset: 0x000243D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933365, XrefRangeEnd = 933367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamId _GetLobbyMemberByIndex(IntPtr self, SteamId steamIDLobby, int iMember)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDLobby;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iMember;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr__GetLobbyMemberByIndex_Private_Static_SteamId_IntPtr_SteamId_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00026230 File Offset: 0x00024430
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933369, RefRangeEnd = 933370, XrefRangeStart = 933367, XrefRangeEnd = 933369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamId GetLobbyMemberByIndex(SteamId steamIDLobby, int iMember)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iMember;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr_GetLobbyMemberByIndex_Internal_SteamId_SteamId_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00026288 File Offset: 0x00024488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933370, XrefRangeEnd = 933373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Utf8StringPointer _GetLobbyData(IntPtr self, SteamId steamIDLobby, string pchKey)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDLobby;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr__GetLobbyData_Private_Static_Utf8StringPointer_IntPtr_SteamId_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x000262E8 File Offset: 0x000244E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933377, RefRangeEnd = 933378, XrefRangeStart = 933373, XrefRangeEnd = 933377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLobbyData(SteamId steamIDLobby, string pchKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr_GetLobbyData_Internal_String_SteamId_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00026340 File Offset: 0x00024540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933378, XrefRangeEnd = 933383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetLobbyData(IntPtr self, SteamId steamIDLobby, string pchKey, string pchValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDLobby;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchKey);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr__SetLobbyData_Private_Static_Boolean_IntPtr_SteamId_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x000263B0 File Offset: 0x000245B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933388, RefRangeEnd = 933389, XrefRangeStart = 933383, XrefRangeEnd = 933388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetLobbyData(SteamId steamIDLobby, string pchKey, string pchValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr_SetLobbyData_Internal_Boolean_SteamId_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00026420 File Offset: 0x00024620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933389, XrefRangeEnd = 933391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetLobbyDataCount(IntPtr self, SteamId steamIDLobby)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDLobby;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr__GetLobbyDataCount_Private_Static_Int32_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0002646C File Offset: 0x0002466C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933393, RefRangeEnd = 933394, XrefRangeStart = 933391, XrefRangeEnd = 933393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetLobbyDataCount(SteamId steamIDLobby)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr_GetLobbyDataCount_Internal_Int32_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x000264B8 File Offset: 0x000246B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933394, XrefRangeEnd = 933396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetLobbyDataByIndex(IntPtr self, SteamId steamIDLobby, int iLobbyData, IntPtr pchKey, int cchKeyBufferSize, IntPtr pchValue, int cchValueBufferSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDLobby;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iLobbyData;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pchKey;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cchKeyBufferSize;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pchValue;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cchValueBufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr__GetLobbyDataByIndex_Private_Static_Boolean_IntPtr_SteamId_Int32_IntPtr_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0002654C File Offset: 0x0002474C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933431, RefRangeEnd = 933432, XrefRangeStart = 933396, XrefRangeEnd = 933431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetLobbyDataByIndex(SteamId steamIDLobby, int iLobbyData, out string pchKey, out string pchValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iLobbyData;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr_GetLobbyDataByIndex_Internal_Boolean_SteamId_Int32_byref_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			pchKey = IL2CPP.Il2CppStringToManaged(intPtr);
			pchValue = IL2CPP.Il2CppStringToManaged(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x000265DC File Offset: 0x000247DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933432, XrefRangeEnd = 933435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _DeleteLobbyData(IntPtr self, SteamId steamIDLobby, string pchKey)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDLobby;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr__DeleteLobbyData_Private_Static_Boolean_IntPtr_SteamId_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x0002663C File Offset: 0x0002483C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933438, RefRangeEnd = 933439, XrefRangeStart = 933435, XrefRangeEnd = 933438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DeleteLobbyData(SteamId steamIDLobby, string pchKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr_DeleteLobbyData_Internal_Boolean_SteamId_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00026698 File Offset: 0x00024898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933439, XrefRangeEnd = 933442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Utf8StringPointer _GetLobbyMemberData(IntPtr self, SteamId steamIDLobby, SteamId steamIDUser, string pchKey)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDLobby;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDUser;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr__GetLobbyMemberData_Private_Static_Utf8StringPointer_IntPtr_SteamId_SteamId_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00026704 File Offset: 0x00024904
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933446, RefRangeEnd = 933447, XrefRangeStart = 933442, XrefRangeEnd = 933446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLobbyMemberData(SteamId steamIDLobby, SteamId steamIDUser, string pchKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDUser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr_GetLobbyMemberData_Internal_String_SteamId_SteamId_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00026768 File Offset: 0x00024968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933447, XrefRangeEnd = 933452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SetLobbyMemberData(IntPtr self, SteamId steamIDLobby, string pchKey, string pchValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDLobby;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchKey);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr__SetLobbyMemberData_Private_Static_Void_IntPtr_SteamId_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003DD RID: 989 RVA: 0x000267CC File Offset: 0x000249CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933457, RefRangeEnd = 933458, XrefRangeStart = 933452, XrefRangeEnd = 933457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLobbyMemberData(SteamId steamIDLobby, string pchKey, string pchValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr_SetLobbyMemberData_Internal_Void_SteamId_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00026830 File Offset: 0x00024A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933458, XrefRangeEnd = 933460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SendLobbyChatMsg(IntPtr self, SteamId steamIDLobby, IntPtr pvMsgBody, int cubMsgBody)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDLobby;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pvMsgBody;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubMsgBody;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr__SendLobbyChatMsg_Private_Static_Boolean_IntPtr_SteamId_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00026898 File Offset: 0x00024A98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 933462, RefRangeEnd = 933465, XrefRangeStart = 933460, XrefRangeEnd = 933462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SendLobbyChatMsg(SteamId steamIDLobby, IntPtr pvMsgBody, int cubMsgBody)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pvMsgBody;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubMsgBody;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr_SendLobbyChatMsg_Internal_Boolean_SteamId_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00026900 File Offset: 0x00024B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933465, XrefRangeEnd = 933467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetLobbyChatEntry(IntPtr self, SteamId steamIDLobby, int iChatID, ref SteamId pSteamIDUser, IntPtr pvData, int cubData, ref ChatEntryType peChatEntryType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDLobby;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iChatID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pSteamIDUser;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pvData;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubData;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &peChatEntryType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr__GetLobbyChatEntry_Private_Static_Int32_IntPtr_SteamId_Int32_byref_SteamId_IntPtr_Int32_byref_ChatEntryType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00026994 File Offset: 0x00024B94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933469, RefRangeEnd = 933470, XrefRangeStart = 933467, XrefRangeEnd = 933469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetLobbyChatEntry(SteamId steamIDLobby, int iChatID, ref SteamId pSteamIDUser, IntPtr pvData, int cubData, ref ChatEntryType peChatEntryType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iChatID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pSteamIDUser;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pvData;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubData;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &peChatEntryType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr_GetLobbyChatEntry_Internal_Int32_SteamId_Int32_byref_SteamId_IntPtr_Int32_byref_ChatEntryType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00026A24 File Offset: 0x00024C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933470, XrefRangeEnd = 933472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _RequestLobbyData(IntPtr self, SteamId steamIDLobby)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDLobby;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr__RequestLobbyData_Private_Static_Boolean_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00026A70 File Offset: 0x00024C70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933474, RefRangeEnd = 933475, XrefRangeStart = 933472, XrefRangeEnd = 933474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RequestLobbyData(SteamId steamIDLobby)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr_RequestLobbyData_Internal_Boolean_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00026ABC File Offset: 0x00024CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933475, XrefRangeEnd = 933477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SetLobbyGameServer(IntPtr self, SteamId steamIDLobby, uint unGameServerIP, ushort unGameServerPort, SteamId steamIDGameServer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDLobby;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unGameServerIP;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unGameServerPort;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDGameServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr__SetLobbyGameServer_Private_Static_Void_IntPtr_SteamId_UInt32_UInt16_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00026B28 File Offset: 0x00024D28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 933479, RefRangeEnd = 933481, XrefRangeStart = 933477, XrefRangeEnd = 933479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLobbyGameServer(SteamId steamIDLobby, uint unGameServerIP, ushort unGameServerPort, SteamId steamIDGameServer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unGameServerIP;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unGameServerPort;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDGameServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr_SetLobbyGameServer_Internal_Void_SteamId_UInt32_UInt16_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00026B90 File Offset: 0x00024D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933481, XrefRangeEnd = 933483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetLobbyGameServer(IntPtr self, SteamId steamIDLobby, ref uint punGameServerIP, ref ushort punGameServerPort, ref SteamId psteamIDGameServer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDLobby;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punGameServerIP;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punGameServerPort;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &psteamIDGameServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr__GetLobbyGameServer_Private_Static_Boolean_IntPtr_SteamId_byref_UInt32_byref_UInt16_byref_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00026C08 File Offset: 0x00024E08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933485, RefRangeEnd = 933486, XrefRangeStart = 933483, XrefRangeEnd = 933485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetLobbyGameServer(SteamId steamIDLobby, ref uint punGameServerIP, ref ushort punGameServerPort, ref SteamId psteamIDGameServer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punGameServerIP;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punGameServerPort;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &psteamIDGameServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr_GetLobbyGameServer_Internal_Boolean_SteamId_byref_UInt32_byref_UInt16_byref_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00026C7C File Offset: 0x00024E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933486, XrefRangeEnd = 933488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetLobbyMemberLimit(IntPtr self, SteamId steamIDLobby, int cMaxMembers)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDLobby;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cMaxMembers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr__SetLobbyMemberLimit_Private_Static_Boolean_IntPtr_SteamId_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00026CD8 File Offset: 0x00024ED8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933490, RefRangeEnd = 933491, XrefRangeStart = 933488, XrefRangeEnd = 933490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetLobbyMemberLimit(SteamId steamIDLobby, int cMaxMembers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cMaxMembers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr_SetLobbyMemberLimit_Internal_Boolean_SteamId_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00026D30 File Offset: 0x00024F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933491, XrefRangeEnd = 933493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetLobbyMemberLimit(IntPtr self, SteamId steamIDLobby)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDLobby;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr__GetLobbyMemberLimit_Private_Static_Int32_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00026D7C File Offset: 0x00024F7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933495, RefRangeEnd = 933496, XrefRangeStart = 933493, XrefRangeEnd = 933495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetLobbyMemberLimit(SteamId steamIDLobby)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr_GetLobbyMemberLimit_Internal_Int32_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00026DC8 File Offset: 0x00024FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933496, XrefRangeEnd = 933498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetLobbyType(IntPtr self, SteamId steamIDLobby, LobbyType eLobbyType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDLobby;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eLobbyType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr__SetLobbyType_Private_Static_Boolean_IntPtr_SteamId_LobbyType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00026E24 File Offset: 0x00025024
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 933500, RefRangeEnd = 933504, XrefRangeStart = 933498, XrefRangeEnd = 933500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetLobbyType(SteamId steamIDLobby, LobbyType eLobbyType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eLobbyType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr_SetLobbyType_Internal_Boolean_SteamId_LobbyType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00026E7C File Offset: 0x0002507C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933504, XrefRangeEnd = 933506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetLobbyJoinable(IntPtr self, SteamId steamIDLobby, bool bLobbyJoinable)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDLobby;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bLobbyJoinable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr__SetLobbyJoinable_Private_Static_Boolean_IntPtr_SteamId_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00026ED8 File Offset: 0x000250D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933508, RefRangeEnd = 933509, XrefRangeStart = 933506, XrefRangeEnd = 933508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetLobbyJoinable(SteamId steamIDLobby, bool bLobbyJoinable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bLobbyJoinable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr_SetLobbyJoinable_Internal_Boolean_SteamId_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00026F30 File Offset: 0x00025130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933509, XrefRangeEnd = 933511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamId _GetLobbyOwner(IntPtr self, SteamId steamIDLobby)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDLobby;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr__GetLobbyOwner_Private_Static_SteamId_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00026F7C File Offset: 0x0002517C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 933513, RefRangeEnd = 933515, XrefRangeStart = 933511, XrefRangeEnd = 933513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamId GetLobbyOwner(SteamId steamIDLobby)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr_GetLobbyOwner_Internal_SteamId_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00026FC8 File Offset: 0x000251C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933515, XrefRangeEnd = 933517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetLobbyOwner(IntPtr self, SteamId steamIDLobby, SteamId steamIDNewOwner)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDLobby;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDNewOwner;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr__SetLobbyOwner_Private_Static_Boolean_IntPtr_SteamId_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00027024 File Offset: 0x00025224
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933519, RefRangeEnd = 933520, XrefRangeStart = 933517, XrefRangeEnd = 933519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetLobbyOwner(SteamId steamIDLobby, SteamId steamIDNewOwner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDNewOwner;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr_SetLobbyOwner_Internal_Boolean_SteamId_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x0002707C File Offset: 0x0002527C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933520, XrefRangeEnd = 933522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetLinkedLobby(IntPtr self, SteamId steamIDLobby, SteamId steamIDLobbyDependent)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDLobby;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDLobbyDependent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr__SetLinkedLobby_Private_Static_Boolean_IntPtr_SteamId_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x000270D8 File Offset: 0x000252D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933522, XrefRangeEnd = 933524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetLinkedLobby(SteamId steamIDLobby, SteamId steamIDLobbyDependent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDLobbyDependent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmaking.NativeMethodInfoPtr_SetLinkedLobby_Internal_Boolean_SteamId_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0000233F File Offset: 0x0000053F
		public ISteamMatchmaking(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400043D RID: 1085
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x0400043E RID: 1086
		private static readonly IntPtr NativeMethodInfoPtr_SteamAPI_SteamMatchmaking_v009_Internal_Static_IntPtr_0;

		// Token: 0x0400043F RID: 1087
		private static readonly IntPtr NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0;

		// Token: 0x04000440 RID: 1088
		private static readonly IntPtr NativeMethodInfoPtr__GetFavoriteGameCount_Private_Static_Int32_IntPtr_0;

		// Token: 0x04000441 RID: 1089
		private static readonly IntPtr NativeMethodInfoPtr_GetFavoriteGameCount_Internal_Int32_0;

		// Token: 0x04000442 RID: 1090
		private static readonly IntPtr NativeMethodInfoPtr__GetFavoriteGame_Private_Static_Boolean_IntPtr_Int32_byref_AppId_byref_UInt32_byref_UInt16_byref_UInt16_byref_UInt32_byref_UInt32_0;

		// Token: 0x04000443 RID: 1091
		private static readonly IntPtr NativeMethodInfoPtr_GetFavoriteGame_Internal_Boolean_Int32_byref_AppId_byref_UInt32_byref_UInt16_byref_UInt16_byref_UInt32_byref_UInt32_0;

		// Token: 0x04000444 RID: 1092
		private static readonly IntPtr NativeMethodInfoPtr__AddFavoriteGame_Private_Static_Int32_IntPtr_AppId_UInt32_UInt16_UInt16_UInt32_UInt32_0;

		// Token: 0x04000445 RID: 1093
		private static readonly IntPtr NativeMethodInfoPtr_AddFavoriteGame_Internal_Int32_AppId_UInt32_UInt16_UInt16_UInt32_UInt32_0;

		// Token: 0x04000446 RID: 1094
		private static readonly IntPtr NativeMethodInfoPtr__RemoveFavoriteGame_Private_Static_Boolean_IntPtr_AppId_UInt32_UInt16_UInt16_UInt32_0;

		// Token: 0x04000447 RID: 1095
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFavoriteGame_Internal_Boolean_AppId_UInt32_UInt16_UInt16_UInt32_0;

		// Token: 0x04000448 RID: 1096
		private static readonly IntPtr NativeMethodInfoPtr__RequestLobbyList_Private_Static_SteamAPICall_t_IntPtr_0;

		// Token: 0x04000449 RID: 1097
		private static readonly IntPtr NativeMethodInfoPtr_RequestLobbyList_Internal_CallResult_1_LobbyMatchList_t_0;

		// Token: 0x0400044A RID: 1098
		private static readonly IntPtr NativeMethodInfoPtr__AddRequestLobbyListStringFilter_Private_Static_Void_IntPtr_String_String_LobbyComparison_0;

		// Token: 0x0400044B RID: 1099
		private static readonly IntPtr NativeMethodInfoPtr_AddRequestLobbyListStringFilter_Internal_Void_String_String_LobbyComparison_0;

		// Token: 0x0400044C RID: 1100
		private static readonly IntPtr NativeMethodInfoPtr__AddRequestLobbyListNumericalFilter_Private_Static_Void_IntPtr_String_Int32_LobbyComparison_0;

		// Token: 0x0400044D RID: 1101
		private static readonly IntPtr NativeMethodInfoPtr_AddRequestLobbyListNumericalFilter_Internal_Void_String_Int32_LobbyComparison_0;

		// Token: 0x0400044E RID: 1102
		private static readonly IntPtr NativeMethodInfoPtr__AddRequestLobbyListNearValueFilter_Private_Static_Void_IntPtr_String_Int32_0;

		// Token: 0x0400044F RID: 1103
		private static readonly IntPtr NativeMethodInfoPtr_AddRequestLobbyListNearValueFilter_Internal_Void_String_Int32_0;

		// Token: 0x04000450 RID: 1104
		private static readonly IntPtr NativeMethodInfoPtr__AddRequestLobbyListFilterSlotsAvailable_Private_Static_Void_IntPtr_Int32_0;

		// Token: 0x04000451 RID: 1105
		private static readonly IntPtr NativeMethodInfoPtr_AddRequestLobbyListFilterSlotsAvailable_Internal_Void_Int32_0;

		// Token: 0x04000452 RID: 1106
		private static readonly IntPtr NativeMethodInfoPtr__AddRequestLobbyListDistanceFilter_Private_Static_Void_IntPtr_LobbyDistanceFilter_0;

		// Token: 0x04000453 RID: 1107
		private static readonly IntPtr NativeMethodInfoPtr_AddRequestLobbyListDistanceFilter_Internal_Void_LobbyDistanceFilter_0;

		// Token: 0x04000454 RID: 1108
		private static readonly IntPtr NativeMethodInfoPtr__AddRequestLobbyListResultCountFilter_Private_Static_Void_IntPtr_Int32_0;

		// Token: 0x04000455 RID: 1109
		private static readonly IntPtr NativeMethodInfoPtr_AddRequestLobbyListResultCountFilter_Internal_Void_Int32_0;

		// Token: 0x04000456 RID: 1110
		private static readonly IntPtr NativeMethodInfoPtr__AddRequestLobbyListCompatibleMembersFilter_Private_Static_Void_IntPtr_SteamId_0;

		// Token: 0x04000457 RID: 1111
		private static readonly IntPtr NativeMethodInfoPtr_AddRequestLobbyListCompatibleMembersFilter_Internal_Void_SteamId_0;

		// Token: 0x04000458 RID: 1112
		private static readonly IntPtr NativeMethodInfoPtr__GetLobbyByIndex_Private_Static_SteamId_IntPtr_Int32_0;

		// Token: 0x04000459 RID: 1113
		private static readonly IntPtr NativeMethodInfoPtr_GetLobbyByIndex_Internal_SteamId_Int32_0;

		// Token: 0x0400045A RID: 1114
		private static readonly IntPtr NativeMethodInfoPtr__CreateLobby_Private_Static_SteamAPICall_t_IntPtr_LobbyType_Int32_0;

		// Token: 0x0400045B RID: 1115
		private static readonly IntPtr NativeMethodInfoPtr_CreateLobby_Internal_CallResult_1_LobbyCreated_t_LobbyType_Int32_0;

		// Token: 0x0400045C RID: 1116
		private static readonly IntPtr NativeMethodInfoPtr__JoinLobby_Private_Static_SteamAPICall_t_IntPtr_SteamId_0;

		// Token: 0x0400045D RID: 1117
		private static readonly IntPtr NativeMethodInfoPtr_JoinLobby_Internal_CallResult_1_LobbyEnter_t_SteamId_0;

		// Token: 0x0400045E RID: 1118
		private static readonly IntPtr NativeMethodInfoPtr__LeaveLobby_Private_Static_Void_IntPtr_SteamId_0;

		// Token: 0x0400045F RID: 1119
		private static readonly IntPtr NativeMethodInfoPtr_LeaveLobby_Internal_Void_SteamId_0;

		// Token: 0x04000460 RID: 1120
		private static readonly IntPtr NativeMethodInfoPtr__InviteUserToLobby_Private_Static_Boolean_IntPtr_SteamId_SteamId_0;

		// Token: 0x04000461 RID: 1121
		private static readonly IntPtr NativeMethodInfoPtr_InviteUserToLobby_Internal_Boolean_SteamId_SteamId_0;

		// Token: 0x04000462 RID: 1122
		private static readonly IntPtr NativeMethodInfoPtr__GetNumLobbyMembers_Private_Static_Int32_IntPtr_SteamId_0;

		// Token: 0x04000463 RID: 1123
		private static readonly IntPtr NativeMethodInfoPtr_GetNumLobbyMembers_Internal_Int32_SteamId_0;

		// Token: 0x04000464 RID: 1124
		private static readonly IntPtr NativeMethodInfoPtr__GetLobbyMemberByIndex_Private_Static_SteamId_IntPtr_SteamId_Int32_0;

		// Token: 0x04000465 RID: 1125
		private static readonly IntPtr NativeMethodInfoPtr_GetLobbyMemberByIndex_Internal_SteamId_SteamId_Int32_0;

		// Token: 0x04000466 RID: 1126
		private static readonly IntPtr NativeMethodInfoPtr__GetLobbyData_Private_Static_Utf8StringPointer_IntPtr_SteamId_String_0;

		// Token: 0x04000467 RID: 1127
		private static readonly IntPtr NativeMethodInfoPtr_GetLobbyData_Internal_String_SteamId_String_0;

		// Token: 0x04000468 RID: 1128
		private static readonly IntPtr NativeMethodInfoPtr__SetLobbyData_Private_Static_Boolean_IntPtr_SteamId_String_String_0;

		// Token: 0x04000469 RID: 1129
		private static readonly IntPtr NativeMethodInfoPtr_SetLobbyData_Internal_Boolean_SteamId_String_String_0;

		// Token: 0x0400046A RID: 1130
		private static readonly IntPtr NativeMethodInfoPtr__GetLobbyDataCount_Private_Static_Int32_IntPtr_SteamId_0;

		// Token: 0x0400046B RID: 1131
		private static readonly IntPtr NativeMethodInfoPtr_GetLobbyDataCount_Internal_Int32_SteamId_0;

		// Token: 0x0400046C RID: 1132
		private static readonly IntPtr NativeMethodInfoPtr__GetLobbyDataByIndex_Private_Static_Boolean_IntPtr_SteamId_Int32_IntPtr_Int32_IntPtr_Int32_0;

		// Token: 0x0400046D RID: 1133
		private static readonly IntPtr NativeMethodInfoPtr_GetLobbyDataByIndex_Internal_Boolean_SteamId_Int32_byref_String_byref_String_0;

		// Token: 0x0400046E RID: 1134
		private static readonly IntPtr NativeMethodInfoPtr__DeleteLobbyData_Private_Static_Boolean_IntPtr_SteamId_String_0;

		// Token: 0x0400046F RID: 1135
		private static readonly IntPtr NativeMethodInfoPtr_DeleteLobbyData_Internal_Boolean_SteamId_String_0;

		// Token: 0x04000470 RID: 1136
		private static readonly IntPtr NativeMethodInfoPtr__GetLobbyMemberData_Private_Static_Utf8StringPointer_IntPtr_SteamId_SteamId_String_0;

		// Token: 0x04000471 RID: 1137
		private static readonly IntPtr NativeMethodInfoPtr_GetLobbyMemberData_Internal_String_SteamId_SteamId_String_0;

		// Token: 0x04000472 RID: 1138
		private static readonly IntPtr NativeMethodInfoPtr__SetLobbyMemberData_Private_Static_Void_IntPtr_SteamId_String_String_0;

		// Token: 0x04000473 RID: 1139
		private static readonly IntPtr NativeMethodInfoPtr_SetLobbyMemberData_Internal_Void_SteamId_String_String_0;

		// Token: 0x04000474 RID: 1140
		private static readonly IntPtr NativeMethodInfoPtr__SendLobbyChatMsg_Private_Static_Boolean_IntPtr_SteamId_IntPtr_Int32_0;

		// Token: 0x04000475 RID: 1141
		private static readonly IntPtr NativeMethodInfoPtr_SendLobbyChatMsg_Internal_Boolean_SteamId_IntPtr_Int32_0;

		// Token: 0x04000476 RID: 1142
		private static readonly IntPtr NativeMethodInfoPtr__GetLobbyChatEntry_Private_Static_Int32_IntPtr_SteamId_Int32_byref_SteamId_IntPtr_Int32_byref_ChatEntryType_0;

		// Token: 0x04000477 RID: 1143
		private static readonly IntPtr NativeMethodInfoPtr_GetLobbyChatEntry_Internal_Int32_SteamId_Int32_byref_SteamId_IntPtr_Int32_byref_ChatEntryType_0;

		// Token: 0x04000478 RID: 1144
		private static readonly IntPtr NativeMethodInfoPtr__RequestLobbyData_Private_Static_Boolean_IntPtr_SteamId_0;

		// Token: 0x04000479 RID: 1145
		private static readonly IntPtr NativeMethodInfoPtr_RequestLobbyData_Internal_Boolean_SteamId_0;

		// Token: 0x0400047A RID: 1146
		private static readonly IntPtr NativeMethodInfoPtr__SetLobbyGameServer_Private_Static_Void_IntPtr_SteamId_UInt32_UInt16_SteamId_0;

		// Token: 0x0400047B RID: 1147
		private static readonly IntPtr NativeMethodInfoPtr_SetLobbyGameServer_Internal_Void_SteamId_UInt32_UInt16_SteamId_0;

		// Token: 0x0400047C RID: 1148
		private static readonly IntPtr NativeMethodInfoPtr__GetLobbyGameServer_Private_Static_Boolean_IntPtr_SteamId_byref_UInt32_byref_UInt16_byref_SteamId_0;

		// Token: 0x0400047D RID: 1149
		private static readonly IntPtr NativeMethodInfoPtr_GetLobbyGameServer_Internal_Boolean_SteamId_byref_UInt32_byref_UInt16_byref_SteamId_0;

		// Token: 0x0400047E RID: 1150
		private static readonly IntPtr NativeMethodInfoPtr__SetLobbyMemberLimit_Private_Static_Boolean_IntPtr_SteamId_Int32_0;

		// Token: 0x0400047F RID: 1151
		private static readonly IntPtr NativeMethodInfoPtr_SetLobbyMemberLimit_Internal_Boolean_SteamId_Int32_0;

		// Token: 0x04000480 RID: 1152
		private static readonly IntPtr NativeMethodInfoPtr__GetLobbyMemberLimit_Private_Static_Int32_IntPtr_SteamId_0;

		// Token: 0x04000481 RID: 1153
		private static readonly IntPtr NativeMethodInfoPtr_GetLobbyMemberLimit_Internal_Int32_SteamId_0;

		// Token: 0x04000482 RID: 1154
		private static readonly IntPtr NativeMethodInfoPtr__SetLobbyType_Private_Static_Boolean_IntPtr_SteamId_LobbyType_0;

		// Token: 0x04000483 RID: 1155
		private static readonly IntPtr NativeMethodInfoPtr_SetLobbyType_Internal_Boolean_SteamId_LobbyType_0;

		// Token: 0x04000484 RID: 1156
		private static readonly IntPtr NativeMethodInfoPtr__SetLobbyJoinable_Private_Static_Boolean_IntPtr_SteamId_Boolean_0;

		// Token: 0x04000485 RID: 1157
		private static readonly IntPtr NativeMethodInfoPtr_SetLobbyJoinable_Internal_Boolean_SteamId_Boolean_0;

		// Token: 0x04000486 RID: 1158
		private static readonly IntPtr NativeMethodInfoPtr__GetLobbyOwner_Private_Static_SteamId_IntPtr_SteamId_0;

		// Token: 0x04000487 RID: 1159
		private static readonly IntPtr NativeMethodInfoPtr_GetLobbyOwner_Internal_SteamId_SteamId_0;

		// Token: 0x04000488 RID: 1160
		private static readonly IntPtr NativeMethodInfoPtr__SetLobbyOwner_Private_Static_Boolean_IntPtr_SteamId_SteamId_0;

		// Token: 0x04000489 RID: 1161
		private static readonly IntPtr NativeMethodInfoPtr_SetLobbyOwner_Internal_Boolean_SteamId_SteamId_0;

		// Token: 0x0400048A RID: 1162
		private static readonly IntPtr NativeMethodInfoPtr__SetLinkedLobby_Private_Static_Boolean_IntPtr_SteamId_SteamId_0;

		// Token: 0x0400048B RID: 1163
		private static readonly IntPtr NativeMethodInfoPtr_SetLinkedLobby_Internal_Boolean_SteamId_SteamId_0;
	}
}
