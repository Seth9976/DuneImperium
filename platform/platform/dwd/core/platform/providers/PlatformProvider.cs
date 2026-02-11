using System;
using dwd.core.platform.auth;
using dwd.core.platform.authentication;
using dwd.core.platform.websocket;
using dwd.core.platform.websocket.incoming;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Reflection;
using UnityEngine;
using UnityEngine.Networking;

namespace dwd.core.platform.providers
{
	// Token: 0x0200004A RID: 74
	public class PlatformProvider : MonoBehaviour
	{
		// Token: 0x060002AC RID: 684 RVA: 0x0000DD84 File Offset: 0x0000BF84
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformProvider()
		{
			Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.providers", "PlatformProvider");
			PlatformProvider.NativeFieldInfoPtr__Token_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, "<Token>k__BackingField");
			PlatformProvider.NativeFieldInfoPtr__LocalToken_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, "<LocalToken>k__BackingField");
			PlatformProvider.NativeFieldInfoPtr_chatHistoryPerUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, "chatHistoryPerUser");
			PlatformProvider.NativeFieldInfoPtr_loggingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, "loggingEnabled");
			PlatformProvider.NativeFieldInfoPtr_reconnectDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, "reconnectDelay");
			PlatformProvider.NativeFieldInfoPtr_platformSocket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, "platformSocket");
			PlatformProvider.NativeFieldInfoPtr_dispatchCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, "dispatchCoroutine");
			PlatformProvider.NativeFieldInfoPtr_reconnectCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, "reconnectCoroutine");
			PlatformProvider.NativeFieldInfoPtr__Friends_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, "<Friends>k__BackingField");
			PlatformProvider.NativeFieldInfoPtr__Invitations_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, "<Invitations>k__BackingField");
			PlatformProvider.NativeFieldInfoPtr__Blocked_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, "<Blocked>k__BackingField");
			PlatformProvider.NativeFieldInfoPtr__MaxRosterLimit_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, "<MaxRosterLimit>k__BackingField");
			PlatformProvider.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, "version");
			PlatformProvider.NativeMethodInfoPtr_get_Token_Public_Static_get_PlatformToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663696);
			PlatformProvider.NativeMethodInfoPtr_set_Token_Private_Static_set_Void_PlatformToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663697);
			PlatformProvider.NativeMethodInfoPtr_get_LocalToken_Public_Static_get_PlatformToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663698);
			PlatformProvider.NativeMethodInfoPtr_set_LocalToken_Private_Static_set_Void_PlatformToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663699);
			PlatformProvider.NativeMethodInfoPtr_get_LocalTokenString_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663700);
			PlatformProvider.NativeMethodInfoPtr_get_TokenString_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663701);
			PlatformProvider.NativeMethodInfoPtr_get_tokenPath_Private_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663702);
			PlatformProvider.NativeMethodInfoPtr_ClearToken_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663704);
			PlatformProvider.NativeMethodInfoPtr_SetToken_Public_Static_Void_PlatformToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663705);
			PlatformProvider.NativeMethodInfoPtr_get_Friends_Public_get_PlatformFriends_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663706);
			PlatformProvider.NativeMethodInfoPtr_set_Friends_Private_set_Void_PlatformFriends_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663707);
			PlatformProvider.NativeMethodInfoPtr_get_Invitations_Public_get_PlatformInvitations_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663708);
			PlatformProvider.NativeMethodInfoPtr_set_Invitations_Private_set_Void_PlatformInvitations_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663709);
			PlatformProvider.NativeMethodInfoPtr_get_Blocked_Public_get_PlatformBlockedAccounts_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663710);
			PlatformProvider.NativeMethodInfoPtr_set_Blocked_Private_set_Void_PlatformBlockedAccounts_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663711);
			PlatformProvider.NativeMethodInfoPtr_get_MaxRosterLimit_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663712);
			PlatformProvider.NativeMethodInfoPtr_set_MaxRosterLimit_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663713);
			PlatformProvider.NativeMethodInfoPtr_Awake_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663714);
			PlatformProvider.NativeMethodInfoPtr_OnDestroy_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663715);
			PlatformProvider.NativeMethodInfoPtr_onDestroy_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663716);
			PlatformProvider.NativeMethodInfoPtr_legacyCallbackProxy_Private_Static_IEnumerator_GetPlatformTokenBase_Action_2_ApiStatus_AuthResponseError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663717);
			PlatformProvider.NativeMethodInfoPtr_GetToken_Public_Coroutine_String_String_String_Action_2_ApiStatus_AuthResponseError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663718);
			PlatformProvider.NativeMethodInfoPtr_GetGuestToken_Public_Coroutine_String_String_Action_2_ApiStatus_AuthResponseError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663719);
			PlatformProvider.NativeMethodInfoPtr_GetSteamToken_Public_Coroutine_String_String_String_String_String_Action_2_ApiStatus_AuthResponseError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663720);
			PlatformProvider.NativeMethodInfoPtr_ChangePassword_Public_Coroutine_String_String_String_Action_2_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663721);
			PlatformProvider.NativeMethodInfoPtr_changePassword_Private_Static_IEnumerator_String_String_String_Action_2_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663722);
			PlatformProvider.NativeMethodInfoPtr_ForgotPassword_Public_Coroutine_String_Action_2_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663723);
			PlatformProvider.NativeMethodInfoPtr_sendForgotPasswordToServer_Private_IEnumerator_String_Action_2_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663724);
			PlatformProvider.NativeMethodInfoPtr_get_Connected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663725);
			PlatformProvider.NativeMethodInfoPtr_Connect_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663726);
			PlatformProvider.NativeMethodInfoPtr_Disconnect_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663727);
			PlatformProvider.NativeMethodInfoPtr_reconnect_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663728);
			PlatformProvider.NativeMethodInfoPtr_AddHandler_Public_Void_TypedHandler_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663729);
			PlatformProvider.NativeMethodInfoPtr_SetHandler_Public_Void_TypedHandler_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663730);
			PlatformProvider.NativeMethodInfoPtr_RemoveHandler_Public_Void_TypedHandler_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663731);
			PlatformProvider.NativeMethodInfoPtr_ClearUserData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663732);
			PlatformProvider.NativeMethodInfoPtr_IsAuthenticated_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663733);
			PlatformProvider.NativeMethodInfoPtr_handleAuthenticated_Private_Void_Authenticated_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663734);
			PlatformProvider.NativeMethodInfoPtr_handleError_Private_Void_ServerError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663735);
			PlatformProvider.NativeMethodInfoPtr_handleDisconnect_Private_Void_SocketDisconnected_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663736);
			PlatformProvider.NativeMethodInfoPtr_updateProfile_Private_Void_Profile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663737);
			PlatformProvider.NativeMethodInfoPtr_UpdateFriends_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663738);
			PlatformProvider.NativeMethodInfoPtr_UpdateInvitations_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663739);
			PlatformProvider.NativeMethodInfoPtr_UpdateBlocked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663740);
			PlatformProvider.NativeMethodInfoPtr_IsFriendOrPendingInvitation_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663741);
			PlatformProvider.NativeMethodInfoPtr_AddFriend_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663742);
			PlatformProvider.NativeMethodInfoPtr_AddFriendByAccountID_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663743);
			PlatformProvider.NativeMethodInfoPtr_DeclineFriendMatchInvitation_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663744);
			PlatformProvider.NativeMethodInfoPtr_CancelFriendInvite_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663745);
			PlatformProvider.NativeMethodInfoPtr_AcceptFriendInvite_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663746);
			PlatformProvider.NativeMethodInfoPtr_DeclineFriendInvite_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663747);
			PlatformProvider.NativeMethodInfoPtr_RemoveFriend_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663748);
			PlatformProvider.NativeMethodInfoPtr_GetFriendRequests_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663749);
			PlatformProvider.NativeMethodInfoPtr_BlockUser_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663750);
			PlatformProvider.NativeMethodInfoPtr_UnblockUser_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663751);
			PlatformProvider.NativeMethodInfoPtr_SetUserStatus_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663752);
			PlatformProvider.NativeMethodInfoPtr_SetUserStatus_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663753);
			PlatformProvider.NativeMethodInfoPtr_SendChatMessage_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663754);
			PlatformProvider.NativeMethodInfoPtr_GetFriendChats_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663755);
			PlatformProvider.NativeMethodInfoPtr_InviteFriendToMatch_Public_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663756);
			PlatformProvider.NativeMethodInfoPtr_write_Private_Void_OutgoingWebSocketMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663757);
			PlatformProvider.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663758);
			PlatformProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, 100663759);
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060002AD RID: 685 RVA: 0x0000E39C File Offset: 0x0000C59C
		// (set) Token: 0x060002AE RID: 686 RVA: 0x0000E3D0 File Offset: 0x0000C5D0
		public unsafe static PlatformToken Token
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168773, XrefRangeEnd = 1168777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_get_Token_Public_Static_get_PlatformToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlatformToken>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168777, XrefRangeEnd = 1168783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_set_Token_Private_Static_set_Void_PlatformToken_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060002AF RID: 687 RVA: 0x0000E408 File Offset: 0x0000C608
		// (set) Token: 0x060002B0 RID: 688 RVA: 0x0000E43C File Offset: 0x0000C63C
		public unsafe static PlatformToken LocalToken
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168783, XrefRangeEnd = 1168787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_get_LocalToken_Public_Static_get_PlatformToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlatformToken>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168787, XrefRangeEnd = 1168793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_set_LocalToken_Private_Static_set_Void_PlatformToken_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x0000E474 File Offset: 0x0000C674
		public unsafe static string LocalTokenString
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1168804, RefRangeEnd = 1168805, XrefRangeStart = 1168793, XrefRangeEnd = 1168804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_get_LocalTokenString_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x0000E4A0 File Offset: 0x0000C6A0
		public unsafe static string TokenString
		{
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 1168816, RefRangeEnd = 1168858, XrefRangeStart = 1168805, XrefRangeEnd = 1168816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_get_TokenString_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x0000E4CC File Offset: 0x0000C6CC
		public unsafe static string tokenPath
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168858, XrefRangeEnd = 1168862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_get_tokenPath_Private_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0000E4F8 File Offset: 0x0000C6F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168862, XrefRangeEnd = 1168866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearToken()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_ClearToken_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0000E520 File Offset: 0x0000C720
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1168932, RefRangeEnd = 1168937, XrefRangeStart = 1168866, XrefRangeEnd = 1168932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetToken(PlatformToken token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(token);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_SetToken_Public_Static_Void_PlatformToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x0000E558 File Offset: 0x0000C758
		// (set) Token: 0x060002B7 RID: 695 RVA: 0x0000E598 File Offset: 0x0000C798
		public unsafe PlatformFriends Friends
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_get_Friends_Public_get_PlatformFriends_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlatformFriends>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_set_Friends_Private_set_Void_PlatformFriends_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x0000E5DC File Offset: 0x0000C7DC
		// (set) Token: 0x060002B9 RID: 697 RVA: 0x0000E61C File Offset: 0x0000C81C
		public unsafe PlatformInvitations Invitations
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_get_Invitations_Public_get_PlatformInvitations_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlatformInvitations>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_set_Invitations_Private_set_Void_PlatformInvitations_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060002BA RID: 698 RVA: 0x0000E660 File Offset: 0x0000C860
		// (set) Token: 0x060002BB RID: 699 RVA: 0x0000E6A0 File Offset: 0x0000C8A0
		public unsafe PlatformBlockedAccounts Blocked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_get_Blocked_Public_get_PlatformBlockedAccounts_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlatformBlockedAccounts>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_set_Blocked_Private_set_Void_PlatformBlockedAccounts_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060002BC RID: 700 RVA: 0x0000E6E4 File Offset: 0x0000C8E4
		// (set) Token: 0x060002BD RID: 701 RVA: 0x0000E720 File Offset: 0x0000C920
		public unsafe int MaxRosterLimit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_get_MaxRosterLimit_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 312518, RefRangeEnd = 312534, XrefRangeStart = 312518, XrefRangeEnd = 312534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_set_MaxRosterLimit_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0000E760 File Offset: 0x0000C960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168937, XrefRangeEnd = 1169011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_Awake_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0000E794 File Offset: 0x0000C994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169011, XrefRangeEnd = 1169015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_OnDestroy_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0000E7C8 File Offset: 0x0000C9C8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void onDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformProvider.NativeMethodInfoPtr_onDestroy_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x0000E804 File Offset: 0x0000CA04
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1169021, RefRangeEnd = 1169024, XrefRangeStart = 1169015, XrefRangeEnd = 1169021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator legacyCallbackProxy(GetPlatformTokenBase baseAuth, Action<ApiStatus, AuthResponseError> callback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseAuth);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_legacyCallbackProxy_Private_Static_IEnumerator_GetPlatformTokenBase_Action_2_ApiStatus_AuthResponseError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0000E85C File Offset: 0x0000CA5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169024, XrefRangeEnd = 1169070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Coroutine GetToken(string authServerURL, string username, string password, Action<ApiStatus, AuthResponseError> callback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(authServerURL);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(username);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_GetToken_Public_Coroutine_String_String_String_Action_2_ApiStatus_AuthResponseError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0000E8E4 File Offset: 0x0000CAE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169070, XrefRangeEnd = 1169107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Coroutine GetGuestToken(string authServerURL, string uniqueDeviceIdentifier, Action<ApiStatus, AuthResponseError> callback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(authServerURL);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(uniqueDeviceIdentifier);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_GetGuestToken_Public_Coroutine_String_String_Action_2_ApiStatus_AuthResponseError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0000E958 File Offset: 0x0000CB58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169107, XrefRangeEnd = 1169153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Coroutine GetSteamToken(string authServerURL, string steamID, string steamToken, string steamName, string uniqueDeviceIdentifier, Action<ApiStatus, AuthResponseError> callback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(authServerURL);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(steamID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(steamToken);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(steamName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(uniqueDeviceIdentifier);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_GetSteamToken_Public_Coroutine_String_String_String_String_String_Action_2_ApiStatus_AuthResponseError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0000EA08 File Offset: 0x0000CC08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1169165, RefRangeEnd = 1169166, XrefRangeStart = 1169153, XrefRangeEnd = 1169165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Coroutine ChangePassword(string apiUrl, string oldPassword, string newPassword, Action<bool, string> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(apiUrl);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(oldPassword);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newPassword);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_ChangePassword_Public_Coroutine_String_String_String_Action_2_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0000EA90 File Offset: 0x0000CC90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169166, XrefRangeEnd = 1169174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator changePassword(string apiUrl, string oldPassword, string newPassword, Action<bool, string> callback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(apiUrl);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(oldPassword);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newPassword);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_changePassword_Private_Static_IEnumerator_String_String_String_Action_2_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0000EB0C File Offset: 0x0000CD0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1169181, RefRangeEnd = 1169182, XrefRangeStart = 1169174, XrefRangeEnd = 1169181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Coroutine ForgotPassword(string apiUrl, Action<bool, string> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(apiUrl);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_ForgotPassword_Public_Coroutine_String_Action_2_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0000EB70 File Offset: 0x0000CD70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169182, XrefRangeEnd = 1169188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator sendForgotPasswordToServer(string apiUrl, Action<bool, string> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(apiUrl);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_sendForgotPasswordToServer_Private_IEnumerator_String_Action_2_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x0000EBD4 File Offset: 0x0000CDD4
		public unsafe bool Connected
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1169188, RefRangeEnd = 1169190, XrefRangeStart = 1169188, XrefRangeEnd = 1169188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_get_Connected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0000EC10 File Offset: 0x0000CE10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1169381, RefRangeEnd = 1169382, XrefRangeStart = 1169190, XrefRangeEnd = 1169381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Connect(string platformServer, string client)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(platformServer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(client);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_Connect_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0000EC64 File Offset: 0x0000CE64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1169389, RefRangeEnd = 1169391, XrefRangeStart = 1169382, XrefRangeEnd = 1169389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Disconnect(bool clearToken = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clearToken;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_Disconnect_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0000ECA4 File Offset: 0x0000CEA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169391, XrefRangeEnd = 1169396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator reconnect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_reconnect_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0000ECE4 File Offset: 0x0000CEE4
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 1169399, RefRangeEnd = 1169424, XrefRangeStart = 1169396, XrefRangeEnd = 1169399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddHandler<T>(TypedHandler<T> Handler) where T : TypedMessage
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.MethodInfoStoreGeneric_AddHandler_Public_Void_TypedHandler_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0000ED28 File Offset: 0x0000CF28
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 1169399, RefRangeEnd = 1169424, XrefRangeStart = 1169399, XrefRangeEnd = 1169424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHandler<T>(TypedHandler<T> Handler) where T : TypedMessage
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.MethodInfoStoreGeneric_SetHandler_Public_Void_TypedHandler_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0000ED6C File Offset: 0x0000CF6C
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 1169399, RefRangeEnd = 1169424, XrefRangeStart = 1169399, XrefRangeEnd = 1169424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveHandler<T>(TypedHandler<T> Handler) where T : TypedMessage
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.MethodInfoStoreGeneric_RemoveHandler_Public_Void_TypedHandler_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0000EDB0 File Offset: 0x0000CFB0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1169430, RefRangeEnd = 1169434, XrefRangeStart = 1169424, XrefRangeEnd = 1169430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearUserData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_ClearUserData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0000EDE4 File Offset: 0x0000CFE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1169434, RefRangeEnd = 1169435, XrefRangeStart = 1169434, XrefRangeEnd = 1169434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAuthenticated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_IsAuthenticated_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0000EE20 File Offset: 0x0000D020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169435, XrefRangeEnd = 1169443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handleAuthenticated(Authenticated msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_handleAuthenticated_Private_Void_Authenticated_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0000EE64 File Offset: 0x0000D064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169443, XrefRangeEnd = 1169466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handleError(ServerError msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_handleError_Private_Void_ServerError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0000EEA8 File Offset: 0x0000D0A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169466, XrefRangeEnd = 1169479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handleDisconnect(SocketDisconnected msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_handleDisconnect_Private_Void_SocketDisconnected_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0000EEEC File Offset: 0x0000D0EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169479, XrefRangeEnd = 1169482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void updateProfile(Profile profile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(profile);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_updateProfile_Private_Void_Profile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0000EF30 File Offset: 0x0000D130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169482, XrefRangeEnd = 1169489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFriends()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_UpdateFriends_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000EF64 File Offset: 0x0000D164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169489, XrefRangeEnd = 1169498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInvitations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_UpdateInvitations_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0000EF98 File Offset: 0x0000D198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169498, XrefRangeEnd = 1169505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBlocked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_UpdateBlocked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0000EFCC File Offset: 0x0000D1CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169505, XrefRangeEnd = 1169536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsFriendOrPendingInvitation(string accountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_IsFriendOrPendingInvitation_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0000F01C File Offset: 0x0000D21C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1169549, RefRangeEnd = 1169550, XrefRangeStart = 1169536, XrefRangeEnd = 1169549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddFriend(string username)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(username);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_AddFriend_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0000F060 File Offset: 0x0000D260
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1169563, RefRangeEnd = 1169564, XrefRangeStart = 1169550, XrefRangeEnd = 1169563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddFriendByAccountID(string accountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_AddFriendByAccountID_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0000F0A4 File Offset: 0x0000D2A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1169581, RefRangeEnd = 1169582, XrefRangeStart = 1169564, XrefRangeEnd = 1169581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeclineFriendMatchInvitation(string accountID, string gameID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(accountID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(gameID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_DeclineFriendMatchInvitation_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0000F0F8 File Offset: 0x0000D2F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1169599, RefRangeEnd = 1169601, XrefRangeStart = 1169582, XrefRangeEnd = 1169599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelFriendInvite(string username, string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(username);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_CancelFriendInvite_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0000F14C File Offset: 0x0000D34C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1169614, RefRangeEnd = 1169615, XrefRangeStart = 1169601, XrefRangeEnd = 1169614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AcceptFriendInvite(string accountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_AcceptFriendInvite_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0000F190 File Offset: 0x0000D390
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1169628, RefRangeEnd = 1169630, XrefRangeStart = 1169615, XrefRangeEnd = 1169628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeclineFriendInvite(string accountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_DeclineFriendInvite_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0000F1D4 File Offset: 0x0000D3D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1169643, RefRangeEnd = 1169645, XrefRangeStart = 1169630, XrefRangeEnd = 1169643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveFriend(string accountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_RemoveFriend_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0000F218 File Offset: 0x0000D418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169645, XrefRangeEnd = 1169652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetFriendRequests()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_GetFriendRequests_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0000F24C File Offset: 0x0000D44C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169652, XrefRangeEnd = 1169665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BlockUser(string username)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(username);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_BlockUser_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0000F290 File Offset: 0x0000D490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169665, XrefRangeEnd = 1169678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnblockUser(string accountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_UnblockUser_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0000F2D4 File Offset: 0x0000D4D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169678, XrefRangeEnd = 1169683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUserStatus(string status)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(status);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_SetUserStatus_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0000F318 File Offset: 0x0000D518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169683, XrefRangeEnd = 1169689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUserStatus(global::Il2CppSystem.Object status)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(status);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_SetUserStatus_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0000F35C File Offset: 0x0000D55C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1169706, RefRangeEnd = 1169707, XrefRangeStart = 1169689, XrefRangeEnd = 1169706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendChatMessage(string accountID, string msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(accountID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(msg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_SendChatMessage_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0000F3B0 File Offset: 0x0000D5B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1169714, RefRangeEnd = 1169715, XrefRangeStart = 1169707, XrefRangeEnd = 1169714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetFriendChats()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_GetFriendChats_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0000F3E4 File Offset: 0x0000D5E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1169740, RefRangeEnd = 1169741, XrefRangeStart = 1169715, XrefRangeEnd = 1169740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InviteFriendToMatch(string accountID, string username, string gameID, string matchInitData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(accountID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(username);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(gameID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(matchInitData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_InviteFriendToMatch_Public_Void_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0000F460 File Offset: 0x0000D660
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 1169749, RefRangeEnd = 1169767, XrefRangeStart = 1169741, XrefRangeEnd = 1169749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void write(OutgoingWebSocketMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_write_Private_Void_OutgoingWebSocketMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060002EA RID: 746 RVA: 0x0000F4A4 File Offset: 0x0000D6A4
		public unsafe virtual ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169767, XrefRangeEnd = 1169771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0000F4E0 File Offset: 0x0000D6E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169771, XrefRangeEnd = 1169772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x000034E0 File Offset: 0x000016E0
		public PlatformProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060002ED RID: 749 RVA: 0x0000F51C File Offset: 0x0000D71C
		// (set) Token: 0x060002EE RID: 750 RVA: 0x000034E9 File Offset: 0x000016E9
		public unsafe static PlatformToken _Token_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlatformProvider.NativeFieldInfoPtr__Token_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformToken>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlatformProvider.NativeFieldInfoPtr__Token_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060002EF RID: 751 RVA: 0x0000F544 File Offset: 0x0000D744
		// (set) Token: 0x060002F0 RID: 752 RVA: 0x000034FB File Offset: 0x000016FB
		public unsafe static PlatformToken _LocalToken_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlatformProvider.NativeFieldInfoPtr__LocalToken_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformToken>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlatformProvider.NativeFieldInfoPtr__LocalToken_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x0000F56C File Offset: 0x0000D76C
		// (set) Token: 0x060002F2 RID: 754 RVA: 0x0000350D File Offset: 0x0000170D
		public unsafe int chatHistoryPerUser
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider.NativeFieldInfoPtr_chatHistoryPerUser);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider.NativeFieldInfoPtr_chatHistoryPerUser)) = value;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x0000F594 File Offset: 0x0000D794
		// (set) Token: 0x060002F4 RID: 756 RVA: 0x00003528 File Offset: 0x00001728
		public unsafe bool loggingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider.NativeFieldInfoPtr_loggingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider.NativeFieldInfoPtr_loggingEnabled)) = value;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x0000F5BC File Offset: 0x0000D7BC
		// (set) Token: 0x060002F6 RID: 758 RVA: 0x00003543 File Offset: 0x00001743
		public unsafe float reconnectDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider.NativeFieldInfoPtr_reconnectDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider.NativeFieldInfoPtr_reconnectDelay)) = value;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x0000F5E4 File Offset: 0x0000D7E4
		// (set) Token: 0x060002F8 RID: 760 RVA: 0x0000355E File Offset: 0x0000175E
		public unsafe PlatformWebSocket platformSocket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider.NativeFieldInfoPtr_platformSocket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformWebSocket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider.NativeFieldInfoPtr_platformSocket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x0000F614 File Offset: 0x0000D814
		// (set) Token: 0x060002FA RID: 762 RVA: 0x0000357D File Offset: 0x0000177D
		public unsafe Coroutine dispatchCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider.NativeFieldInfoPtr_dispatchCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider.NativeFieldInfoPtr_dispatchCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060002FB RID: 763 RVA: 0x0000F644 File Offset: 0x0000D844
		// (set) Token: 0x060002FC RID: 764 RVA: 0x0000359C File Offset: 0x0000179C
		public unsafe Coroutine reconnectCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider.NativeFieldInfoPtr_reconnectCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider.NativeFieldInfoPtr_reconnectCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060002FD RID: 765 RVA: 0x0000F674 File Offset: 0x0000D874
		// (set) Token: 0x060002FE RID: 766 RVA: 0x000035BB File Offset: 0x000017BB
		public unsafe PlatformFriends _Friends_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider.NativeFieldInfoPtr__Friends_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformFriends>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider.NativeFieldInfoPtr__Friends_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060002FF RID: 767 RVA: 0x0000F6A4 File Offset: 0x0000D8A4
		// (set) Token: 0x06000300 RID: 768 RVA: 0x000035DA File Offset: 0x000017DA
		public unsafe PlatformInvitations _Invitations_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider.NativeFieldInfoPtr__Invitations_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformInvitations>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider.NativeFieldInfoPtr__Invitations_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000301 RID: 769 RVA: 0x0000F6D4 File Offset: 0x0000D8D4
		// (set) Token: 0x06000302 RID: 770 RVA: 0x000035F9 File Offset: 0x000017F9
		public unsafe PlatformBlockedAccounts _Blocked_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider.NativeFieldInfoPtr__Blocked_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformBlockedAccounts>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider.NativeFieldInfoPtr__Blocked_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000303 RID: 771 RVA: 0x0000F704 File Offset: 0x0000D904
		// (set) Token: 0x06000304 RID: 772 RVA: 0x00003618 File Offset: 0x00001818
		public unsafe int _MaxRosterLimit_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider.NativeFieldInfoPtr__MaxRosterLimit_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider.NativeFieldInfoPtr__MaxRosterLimit_k__BackingField)) = value;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000305 RID: 773 RVA: 0x0000F72C File Offset: 0x0000D92C
		// (set) Token: 0x06000306 RID: 774 RVA: 0x00003633 File Offset: 0x00001833
		public unsafe static ulong version
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(PlatformProvider.NativeFieldInfoPtr_version, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlatformProvider.NativeFieldInfoPtr_version, (void*)(&value));
			}
		}

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeFieldInfoPtr__Token_k__BackingField;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeFieldInfoPtr__LocalToken_k__BackingField;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeFieldInfoPtr_chatHistoryPerUser;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeFieldInfoPtr_loggingEnabled;

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeFieldInfoPtr_reconnectDelay;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeFieldInfoPtr_platformSocket;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeFieldInfoPtr_dispatchCoroutine;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeFieldInfoPtr_reconnectCoroutine;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeFieldInfoPtr__Friends_k__BackingField;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeFieldInfoPtr__Invitations_k__BackingField;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeFieldInfoPtr__Blocked_k__BackingField;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeFieldInfoPtr__MaxRosterLimit_k__BackingField;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeMethodInfoPtr_get_Token_Public_Static_get_PlatformToken_0;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeMethodInfoPtr_set_Token_Private_Static_set_Void_PlatformToken_0;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalToken_Public_Static_get_PlatformToken_0;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalToken_Private_Static_set_Void_PlatformToken_0;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalTokenString_Public_Static_get_String_0;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeMethodInfoPtr_get_TokenString_Public_Static_get_String_0;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeMethodInfoPtr_get_tokenPath_Private_Static_get_String_0;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeMethodInfoPtr_ClearToken_Public_Static_Void_0;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeMethodInfoPtr_SetToken_Public_Static_Void_PlatformToken_0;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeMethodInfoPtr_get_Friends_Public_get_PlatformFriends_0;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeMethodInfoPtr_set_Friends_Private_set_Void_PlatformFriends_0;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeMethodInfoPtr_get_Invitations_Public_get_PlatformInvitations_0;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeMethodInfoPtr_set_Invitations_Private_set_Void_PlatformInvitations_0;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeMethodInfoPtr_get_Blocked_Public_get_PlatformBlockedAccounts_0;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeMethodInfoPtr_set_Blocked_Private_set_Void_PlatformBlockedAccounts_0;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxRosterLimit_Public_get_Int32_0;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxRosterLimit_Private_set_Void_Int32_0;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Void_0;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Void_0;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeMethodInfoPtr_onDestroy_Protected_Virtual_New_Void_0;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeMethodInfoPtr_legacyCallbackProxy_Private_Static_IEnumerator_GetPlatformTokenBase_Action_2_ApiStatus_AuthResponseError_0;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeMethodInfoPtr_GetToken_Public_Coroutine_String_String_String_Action_2_ApiStatus_AuthResponseError_0;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeMethodInfoPtr_GetGuestToken_Public_Coroutine_String_String_Action_2_ApiStatus_AuthResponseError_0;

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamToken_Public_Coroutine_String_String_String_String_String_Action_2_ApiStatus_AuthResponseError_0;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeMethodInfoPtr_ChangePassword_Public_Coroutine_String_String_String_Action_2_Boolean_String_0;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeMethodInfoPtr_changePassword_Private_Static_IEnumerator_String_String_String_Action_2_Boolean_String_0;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeMethodInfoPtr_ForgotPassword_Public_Coroutine_String_Action_2_Boolean_String_0;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeMethodInfoPtr_sendForgotPasswordToServer_Private_IEnumerator_String_Action_2_Boolean_String_0;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeMethodInfoPtr_get_Connected_Public_get_Boolean_0;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeMethodInfoPtr_Connect_Public_Void_String_String_0;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeMethodInfoPtr_Disconnect_Public_Void_Boolean_0;

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeMethodInfoPtr_reconnect_Private_IEnumerator_0;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeMethodInfoPtr_AddHandler_Public_Void_TypedHandler_1_T_0;

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeMethodInfoPtr_SetHandler_Public_Void_TypedHandler_1_T_0;

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeMethodInfoPtr_RemoveHandler_Public_Void_TypedHandler_1_T_0;

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeMethodInfoPtr_ClearUserData_Public_Void_0;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeMethodInfoPtr_IsAuthenticated_Public_Boolean_0;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeMethodInfoPtr_handleAuthenticated_Private_Void_Authenticated_0;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeMethodInfoPtr_handleError_Private_Void_ServerError_0;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeMethodInfoPtr_handleDisconnect_Private_Void_SocketDisconnected_0;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeMethodInfoPtr_updateProfile_Private_Void_Profile_0;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFriends_Public_Void_0;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInvitations_Public_Void_0;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBlocked_Public_Void_0;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeMethodInfoPtr_IsFriendOrPendingInvitation_Public_Boolean_String_0;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeMethodInfoPtr_AddFriend_Public_Void_String_0;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeMethodInfoPtr_AddFriendByAccountID_Public_Void_String_0;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeMethodInfoPtr_DeclineFriendMatchInvitation_Public_Void_String_String_0;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeMethodInfoPtr_CancelFriendInvite_Public_Void_String_String_0;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeMethodInfoPtr_AcceptFriendInvite_Public_Void_String_0;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeMethodInfoPtr_DeclineFriendInvite_Public_Void_String_0;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFriend_Public_Void_String_0;

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendRequests_Public_Void_0;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeMethodInfoPtr_BlockUser_Public_Void_String_0;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeMethodInfoPtr_UnblockUser_Public_Void_String_0;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeMethodInfoPtr_SetUserStatus_Public_Void_String_0;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeMethodInfoPtr_SetUserStatus_Public_Void_Object_0;

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeMethodInfoPtr_SendChatMessage_Public_Void_String_String_0;

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendChats_Public_Void_0;

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeMethodInfoPtr_InviteFriendToMatch_Public_Void_String_String_String_String_0;

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeMethodInfoPtr_write_Private_Void_OutgoingWebSocketMessage_0;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200007D RID: 125
		[ObfuscatedName("dwd.core.platform.providers.PlatformProvider+<changePassword>d__47")]
		public sealed class _changePassword_d__47 : global::Il2CppSystem.Object
		{
			// Token: 0x0600049C RID: 1180 RVA: 0x00014424 File Offset: 0x00012624
			// Note: this type is marked as 'beforefieldinit'.
			static _changePassword_d__47()
			{
				Il2CppClassPointerStore<PlatformProvider._changePassword_d__47>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, "<changePassword>d__47");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformProvider._changePassword_d__47>.NativeClassPtr);
				PlatformProvider._changePassword_d__47.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformProvider._changePassword_d__47>.NativeClassPtr, "<>1__state");
				PlatformProvider._changePassword_d__47.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformProvider._changePassword_d__47>.NativeClassPtr, "<>2__current");
				PlatformProvider._changePassword_d__47.NativeFieldInfoPtr_oldPassword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformProvider._changePassword_d__47>.NativeClassPtr, "oldPassword");
				PlatformProvider._changePassword_d__47.NativeFieldInfoPtr_newPassword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformProvider._changePassword_d__47>.NativeClassPtr, "newPassword");
				PlatformProvider._changePassword_d__47.NativeFieldInfoPtr_apiUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformProvider._changePassword_d__47>.NativeClassPtr, "apiUrl");
				PlatformProvider._changePassword_d__47.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformProvider._changePassword_d__47>.NativeClassPtr, "callback");
				PlatformProvider._changePassword_d__47.NativeFieldInfoPtr__request_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformProvider._changePassword_d__47>.NativeClassPtr, "<request>5__2");
				PlatformProvider._changePassword_d__47.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider._changePassword_d__47>.NativeClassPtr, 100663760);
				PlatformProvider._changePassword_d__47.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider._changePassword_d__47>.NativeClassPtr, 100663761);
				PlatformProvider._changePassword_d__47.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider._changePassword_d__47>.NativeClassPtr, 100663762);
				PlatformProvider._changePassword_d__47.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider._changePassword_d__47>.NativeClassPtr, 100663763);
				PlatformProvider._changePassword_d__47.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider._changePassword_d__47>.NativeClassPtr, 100663764);
				PlatformProvider._changePassword_d__47.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider._changePassword_d__47>.NativeClassPtr, 100663765);
				PlatformProvider._changePassword_d__47.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider._changePassword_d__47>.NativeClassPtr, 100663766);
			}

			// Token: 0x0600049D RID: 1181 RVA: 0x00014568 File Offset: 0x00012768
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _changePassword_d__47(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformProvider._changePassword_d__47>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider._changePassword_d__47.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600049E RID: 1182 RVA: 0x000145B0 File Offset: 0x000127B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168580, XrefRangeEnd = 1168585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider._changePassword_d__47.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600049F RID: 1183 RVA: 0x000145E4 File Offset: 0x000127E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168585, XrefRangeEnd = 1168679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider._changePassword_d__47.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060004A0 RID: 1184 RVA: 0x00014620 File Offset: 0x00012820
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168679, XrefRangeEnd = 1168682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider._changePassword_d__47.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000139 RID: 313
			// (get) Token: 0x060004A1 RID: 1185 RVA: 0x00014654 File Offset: 0x00012854
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider._changePassword_d__47.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060004A2 RID: 1186 RVA: 0x00014694 File Offset: 0x00012894
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168682, XrefRangeEnd = 1168687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider._changePassword_d__47.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700013A RID: 314
			// (get) Token: 0x060004A3 RID: 1187 RVA: 0x000146C8 File Offset: 0x000128C8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider._changePassword_d__47.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060004A4 RID: 1188 RVA: 0x000043A2 File Offset: 0x000025A2
			public _changePassword_d__47(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000132 RID: 306
			// (get) Token: 0x060004A5 RID: 1189 RVA: 0x00014708 File Offset: 0x00012908
			// (set) Token: 0x060004A6 RID: 1190 RVA: 0x000043AB File Offset: 0x000025AB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider._changePassword_d__47.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider._changePassword_d__47.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000133 RID: 307
			// (get) Token: 0x060004A7 RID: 1191 RVA: 0x00014730 File Offset: 0x00012930
			// (set) Token: 0x060004A8 RID: 1192 RVA: 0x000043C6 File Offset: 0x000025C6
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider._changePassword_d__47.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider._changePassword_d__47.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000134 RID: 308
			// (get) Token: 0x060004A9 RID: 1193 RVA: 0x00014760 File Offset: 0x00012960
			// (set) Token: 0x060004AA RID: 1194 RVA: 0x000043E5 File Offset: 0x000025E5
			public unsafe string oldPassword
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider._changePassword_d__47.NativeFieldInfoPtr_oldPassword);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider._changePassword_d__47.NativeFieldInfoPtr_oldPassword), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000135 RID: 309
			// (get) Token: 0x060004AB RID: 1195 RVA: 0x00014788 File Offset: 0x00012988
			// (set) Token: 0x060004AC RID: 1196 RVA: 0x00004404 File Offset: 0x00002604
			public unsafe string newPassword
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider._changePassword_d__47.NativeFieldInfoPtr_newPassword);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider._changePassword_d__47.NativeFieldInfoPtr_newPassword), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000136 RID: 310
			// (get) Token: 0x060004AD RID: 1197 RVA: 0x000147B0 File Offset: 0x000129B0
			// (set) Token: 0x060004AE RID: 1198 RVA: 0x00004423 File Offset: 0x00002623
			public unsafe string apiUrl
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider._changePassword_d__47.NativeFieldInfoPtr_apiUrl);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider._changePassword_d__47.NativeFieldInfoPtr_apiUrl), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000137 RID: 311
			// (get) Token: 0x060004AF RID: 1199 RVA: 0x000147D8 File Offset: 0x000129D8
			// (set) Token: 0x060004B0 RID: 1200 RVA: 0x00004442 File Offset: 0x00002642
			public unsafe Action<bool, string> callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider._changePassword_d__47.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider._changePassword_d__47.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000138 RID: 312
			// (get) Token: 0x060004B1 RID: 1201 RVA: 0x00014808 File Offset: 0x00012A08
			// (set) Token: 0x060004B2 RID: 1202 RVA: 0x00004461 File Offset: 0x00002661
			public unsafe UnityWebRequest _request_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider._changePassword_d__47.NativeFieldInfoPtr__request_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider._changePassword_d__47.NativeFieldInfoPtr__request_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040002E9 RID: 745
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040002EA RID: 746
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040002EB RID: 747
			private static readonly IntPtr NativeFieldInfoPtr_oldPassword;

			// Token: 0x040002EC RID: 748
			private static readonly IntPtr NativeFieldInfoPtr_newPassword;

			// Token: 0x040002ED RID: 749
			private static readonly IntPtr NativeFieldInfoPtr_apiUrl;

			// Token: 0x040002EE RID: 750
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x040002EF RID: 751
			private static readonly IntPtr NativeFieldInfoPtr__request_5__2;

			// Token: 0x040002F0 RID: 752
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040002F1 RID: 753
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002F2 RID: 754
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040002F3 RID: 755
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040002F4 RID: 756
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040002F5 RID: 757
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002F6 RID: 758
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200007E RID: 126
		[ObfuscatedName("dwd.core.platform.providers.PlatformProvider+<legacyCallbackProxy>d__42")]
		public sealed class _legacyCallbackProxy_d__42 : global::Il2CppSystem.Object
		{
			// Token: 0x060004B3 RID: 1203 RVA: 0x00014838 File Offset: 0x00012A38
			// Note: this type is marked as 'beforefieldinit'.
			static _legacyCallbackProxy_d__42()
			{
				Il2CppClassPointerStore<PlatformProvider._legacyCallbackProxy_d__42>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, "<legacyCallbackProxy>d__42");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformProvider._legacyCallbackProxy_d__42>.NativeClassPtr);
				PlatformProvider._legacyCallbackProxy_d__42.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformProvider._legacyCallbackProxy_d__42>.NativeClassPtr, "<>1__state");
				PlatformProvider._legacyCallbackProxy_d__42.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformProvider._legacyCallbackProxy_d__42>.NativeClassPtr, "<>2__current");
				PlatformProvider._legacyCallbackProxy_d__42.NativeFieldInfoPtr_baseAuth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformProvider._legacyCallbackProxy_d__42>.NativeClassPtr, "baseAuth");
				PlatformProvider._legacyCallbackProxy_d__42.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformProvider._legacyCallbackProxy_d__42>.NativeClassPtr, "callback");
				PlatformProvider._legacyCallbackProxy_d__42.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider._legacyCallbackProxy_d__42>.NativeClassPtr, 100663767);
				PlatformProvider._legacyCallbackProxy_d__42.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider._legacyCallbackProxy_d__42>.NativeClassPtr, 100663768);
				PlatformProvider._legacyCallbackProxy_d__42.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider._legacyCallbackProxy_d__42>.NativeClassPtr, 100663769);
				PlatformProvider._legacyCallbackProxy_d__42.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider._legacyCallbackProxy_d__42>.NativeClassPtr, 100663770);
				PlatformProvider._legacyCallbackProxy_d__42.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider._legacyCallbackProxy_d__42>.NativeClassPtr, 100663771);
				PlatformProvider._legacyCallbackProxy_d__42.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider._legacyCallbackProxy_d__42>.NativeClassPtr, 100663772);
			}

			// Token: 0x060004B4 RID: 1204 RVA: 0x0001492C File Offset: 0x00012B2C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _legacyCallbackProxy_d__42(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformProvider._legacyCallbackProxy_d__42>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider._legacyCallbackProxy_d__42.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060004B5 RID: 1205 RVA: 0x00014974 File Offset: 0x00012B74
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider._legacyCallbackProxy_d__42.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004B6 RID: 1206 RVA: 0x000149A8 File Offset: 0x00012BA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168687, XrefRangeEnd = 1168691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider._legacyCallbackProxy_d__42.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700013F RID: 319
			// (get) Token: 0x060004B7 RID: 1207 RVA: 0x000149E4 File Offset: 0x00012BE4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider._legacyCallbackProxy_d__42.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060004B8 RID: 1208 RVA: 0x00014A24 File Offset: 0x00012C24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168691, XrefRangeEnd = 1168696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider._legacyCallbackProxy_d__42.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000140 RID: 320
			// (get) Token: 0x060004B9 RID: 1209 RVA: 0x00014A58 File Offset: 0x00012C58
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider._legacyCallbackProxy_d__42.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060004BA RID: 1210 RVA: 0x00004480 File Offset: 0x00002680
			public _legacyCallbackProxy_d__42(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700013B RID: 315
			// (get) Token: 0x060004BB RID: 1211 RVA: 0x00014A98 File Offset: 0x00012C98
			// (set) Token: 0x060004BC RID: 1212 RVA: 0x00004489 File Offset: 0x00002689
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider._legacyCallbackProxy_d__42.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider._legacyCallbackProxy_d__42.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700013C RID: 316
			// (get) Token: 0x060004BD RID: 1213 RVA: 0x00014AC0 File Offset: 0x00012CC0
			// (set) Token: 0x060004BE RID: 1214 RVA: 0x000044A4 File Offset: 0x000026A4
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider._legacyCallbackProxy_d__42.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider._legacyCallbackProxy_d__42.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700013D RID: 317
			// (get) Token: 0x060004BF RID: 1215 RVA: 0x00014AF0 File Offset: 0x00012CF0
			// (set) Token: 0x060004C0 RID: 1216 RVA: 0x000044C3 File Offset: 0x000026C3
			public unsafe GetPlatformTokenBase baseAuth
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider._legacyCallbackProxy_d__42.NativeFieldInfoPtr_baseAuth);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GetPlatformTokenBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider._legacyCallbackProxy_d__42.NativeFieldInfoPtr_baseAuth), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700013E RID: 318
			// (get) Token: 0x060004C1 RID: 1217 RVA: 0x00014B20 File Offset: 0x00012D20
			// (set) Token: 0x060004C2 RID: 1218 RVA: 0x000044E2 File Offset: 0x000026E2
			public unsafe Action<ApiStatus, AuthResponseError> callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider._legacyCallbackProxy_d__42.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ApiStatus, AuthResponseError>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider._legacyCallbackProxy_d__42.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040002F7 RID: 759
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040002F8 RID: 760
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040002F9 RID: 761
			private static readonly IntPtr NativeFieldInfoPtr_baseAuth;

			// Token: 0x040002FA RID: 762
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x040002FB RID: 763
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040002FC RID: 764
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002FD RID: 765
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040002FE RID: 766
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040002FF RID: 767
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000300 RID: 768
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200007F RID: 127
		[ObfuscatedName("dwd.core.platform.providers.PlatformProvider+<reconnect>d__54")]
		public sealed class _reconnect_d__54 : global::Il2CppSystem.Object
		{
			// Token: 0x060004C3 RID: 1219 RVA: 0x00014B50 File Offset: 0x00012D50
			// Note: this type is marked as 'beforefieldinit'.
			static _reconnect_d__54()
			{
				Il2CppClassPointerStore<PlatformProvider._reconnect_d__54>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, "<reconnect>d__54");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformProvider._reconnect_d__54>.NativeClassPtr);
				PlatformProvider._reconnect_d__54.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformProvider._reconnect_d__54>.NativeClassPtr, "<>1__state");
				PlatformProvider._reconnect_d__54.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformProvider._reconnect_d__54>.NativeClassPtr, "<>2__current");
				PlatformProvider._reconnect_d__54.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformProvider._reconnect_d__54>.NativeClassPtr, "<>4__this");
				PlatformProvider._reconnect_d__54.NativeFieldInfoPtr__attempts_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformProvider._reconnect_d__54>.NativeClassPtr, "<attempts>5__2");
				PlatformProvider._reconnect_d__54.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider._reconnect_d__54>.NativeClassPtr, 100663773);
				PlatformProvider._reconnect_d__54.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider._reconnect_d__54>.NativeClassPtr, 100663774);
				PlatformProvider._reconnect_d__54.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider._reconnect_d__54>.NativeClassPtr, 100663775);
				PlatformProvider._reconnect_d__54.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider._reconnect_d__54>.NativeClassPtr, 100663776);
				PlatformProvider._reconnect_d__54.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider._reconnect_d__54>.NativeClassPtr, 100663777);
				PlatformProvider._reconnect_d__54.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider._reconnect_d__54>.NativeClassPtr, 100663778);
			}

			// Token: 0x060004C4 RID: 1220 RVA: 0x00014C44 File Offset: 0x00012E44
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _reconnect_d__54(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformProvider._reconnect_d__54>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider._reconnect_d__54.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060004C5 RID: 1221 RVA: 0x00014C8C File Offset: 0x00012E8C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider._reconnect_d__54.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004C6 RID: 1222 RVA: 0x00014CC0 File Offset: 0x00012EC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168696, XrefRangeEnd = 1168715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider._reconnect_d__54.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000145 RID: 325
			// (get) Token: 0x060004C7 RID: 1223 RVA: 0x00014CFC File Offset: 0x00012EFC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider._reconnect_d__54.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060004C8 RID: 1224 RVA: 0x00014D3C File Offset: 0x00012F3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168715, XrefRangeEnd = 1168720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider._reconnect_d__54.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000146 RID: 326
			// (get) Token: 0x060004C9 RID: 1225 RVA: 0x00014D70 File Offset: 0x00012F70
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider._reconnect_d__54.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060004CA RID: 1226 RVA: 0x00004501 File Offset: 0x00002701
			public _reconnect_d__54(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000141 RID: 321
			// (get) Token: 0x060004CB RID: 1227 RVA: 0x00014DB0 File Offset: 0x00012FB0
			// (set) Token: 0x060004CC RID: 1228 RVA: 0x0000450A File Offset: 0x0000270A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider._reconnect_d__54.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider._reconnect_d__54.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000142 RID: 322
			// (get) Token: 0x060004CD RID: 1229 RVA: 0x00014DD8 File Offset: 0x00012FD8
			// (set) Token: 0x060004CE RID: 1230 RVA: 0x00004525 File Offset: 0x00002725
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider._reconnect_d__54.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider._reconnect_d__54.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000143 RID: 323
			// (get) Token: 0x060004CF RID: 1231 RVA: 0x00014E08 File Offset: 0x00013008
			// (set) Token: 0x060004D0 RID: 1232 RVA: 0x00004544 File Offset: 0x00002744
			public unsafe PlatformProvider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider._reconnect_d__54.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider._reconnect_d__54.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000144 RID: 324
			// (get) Token: 0x060004D1 RID: 1233 RVA: 0x00014E38 File Offset: 0x00013038
			// (set) Token: 0x060004D2 RID: 1234 RVA: 0x00004563 File Offset: 0x00002763
			public unsafe int _attempts_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider._reconnect_d__54.NativeFieldInfoPtr__attempts_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider._reconnect_d__54.NativeFieldInfoPtr__attempts_5__2)) = value;
				}
			}

			// Token: 0x04000301 RID: 769
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000302 RID: 770
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000303 RID: 771
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000304 RID: 772
			private static readonly IntPtr NativeFieldInfoPtr__attempts_5__2;

			// Token: 0x04000305 RID: 773
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000306 RID: 774
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000307 RID: 775
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000308 RID: 776
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000309 RID: 777
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400030A RID: 778
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000080 RID: 128
		[ObfuscatedName("dwd.core.platform.providers.PlatformProvider+<sendForgotPasswordToServer>d__49")]
		public sealed class _sendForgotPasswordToServer_d__49 : global::Il2CppSystem.Object
		{
			// Token: 0x060004D3 RID: 1235 RVA: 0x00014E60 File Offset: 0x00013060
			// Note: this type is marked as 'beforefieldinit'.
			static _sendForgotPasswordToServer_d__49()
			{
				Il2CppClassPointerStore<PlatformProvider._sendForgotPasswordToServer_d__49>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr, "<sendForgotPasswordToServer>d__49");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformProvider._sendForgotPasswordToServer_d__49>.NativeClassPtr);
				PlatformProvider._sendForgotPasswordToServer_d__49.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformProvider._sendForgotPasswordToServer_d__49>.NativeClassPtr, "<>1__state");
				PlatformProvider._sendForgotPasswordToServer_d__49.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformProvider._sendForgotPasswordToServer_d__49>.NativeClassPtr, "<>2__current");
				PlatformProvider._sendForgotPasswordToServer_d__49.NativeFieldInfoPtr_apiUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformProvider._sendForgotPasswordToServer_d__49>.NativeClassPtr, "apiUrl");
				PlatformProvider._sendForgotPasswordToServer_d__49.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformProvider._sendForgotPasswordToServer_d__49>.NativeClassPtr, "callback");
				PlatformProvider._sendForgotPasswordToServer_d__49.NativeFieldInfoPtr__request_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformProvider._sendForgotPasswordToServer_d__49>.NativeClassPtr, "<request>5__2");
				PlatformProvider._sendForgotPasswordToServer_d__49.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider._sendForgotPasswordToServer_d__49>.NativeClassPtr, 100663779);
				PlatformProvider._sendForgotPasswordToServer_d__49.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider._sendForgotPasswordToServer_d__49>.NativeClassPtr, 100663780);
				PlatformProvider._sendForgotPasswordToServer_d__49.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider._sendForgotPasswordToServer_d__49>.NativeClassPtr, 100663781);
				PlatformProvider._sendForgotPasswordToServer_d__49.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider._sendForgotPasswordToServer_d__49>.NativeClassPtr, 100663782);
				PlatformProvider._sendForgotPasswordToServer_d__49.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider._sendForgotPasswordToServer_d__49>.NativeClassPtr, 100663783);
				PlatformProvider._sendForgotPasswordToServer_d__49.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider._sendForgotPasswordToServer_d__49>.NativeClassPtr, 100663784);
				PlatformProvider._sendForgotPasswordToServer_d__49.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformProvider._sendForgotPasswordToServer_d__49>.NativeClassPtr, 100663785);
			}

			// Token: 0x060004D4 RID: 1236 RVA: 0x00014F7C File Offset: 0x0001317C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _sendForgotPasswordToServer_d__49(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformProvider._sendForgotPasswordToServer_d__49>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider._sendForgotPasswordToServer_d__49.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060004D5 RID: 1237 RVA: 0x00014FC4 File Offset: 0x000131C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168720, XrefRangeEnd = 1168725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider._sendForgotPasswordToServer_d__49.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004D6 RID: 1238 RVA: 0x00014FF8 File Offset: 0x000131F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168725, XrefRangeEnd = 1168765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider._sendForgotPasswordToServer_d__49.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060004D7 RID: 1239 RVA: 0x00015034 File Offset: 0x00013234
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168765, XrefRangeEnd = 1168768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider._sendForgotPasswordToServer_d__49.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700014C RID: 332
			// (get) Token: 0x060004D8 RID: 1240 RVA: 0x00015068 File Offset: 0x00013268
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider._sendForgotPasswordToServer_d__49.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060004D9 RID: 1241 RVA: 0x000150A8 File Offset: 0x000132A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168768, XrefRangeEnd = 1168773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider._sendForgotPasswordToServer_d__49.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700014D RID: 333
			// (get) Token: 0x060004DA RID: 1242 RVA: 0x000150DC File Offset: 0x000132DC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformProvider._sendForgotPasswordToServer_d__49.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060004DB RID: 1243 RVA: 0x0000457E File Offset: 0x0000277E
			public _sendForgotPasswordToServer_d__49(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000147 RID: 327
			// (get) Token: 0x060004DC RID: 1244 RVA: 0x0001511C File Offset: 0x0001331C
			// (set) Token: 0x060004DD RID: 1245 RVA: 0x00004587 File Offset: 0x00002787
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider._sendForgotPasswordToServer_d__49.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider._sendForgotPasswordToServer_d__49.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000148 RID: 328
			// (get) Token: 0x060004DE RID: 1246 RVA: 0x00015144 File Offset: 0x00013344
			// (set) Token: 0x060004DF RID: 1247 RVA: 0x000045A2 File Offset: 0x000027A2
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider._sendForgotPasswordToServer_d__49.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider._sendForgotPasswordToServer_d__49.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000149 RID: 329
			// (get) Token: 0x060004E0 RID: 1248 RVA: 0x00015174 File Offset: 0x00013374
			// (set) Token: 0x060004E1 RID: 1249 RVA: 0x000045C1 File Offset: 0x000027C1
			public unsafe string apiUrl
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider._sendForgotPasswordToServer_d__49.NativeFieldInfoPtr_apiUrl);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider._sendForgotPasswordToServer_d__49.NativeFieldInfoPtr_apiUrl), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700014A RID: 330
			// (get) Token: 0x060004E2 RID: 1250 RVA: 0x0001519C File Offset: 0x0001339C
			// (set) Token: 0x060004E3 RID: 1251 RVA: 0x000045E0 File Offset: 0x000027E0
			public unsafe Action<bool, string> callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider._sendForgotPasswordToServer_d__49.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider._sendForgotPasswordToServer_d__49.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700014B RID: 331
			// (get) Token: 0x060004E4 RID: 1252 RVA: 0x000151CC File Offset: 0x000133CC
			// (set) Token: 0x060004E5 RID: 1253 RVA: 0x000045FF File Offset: 0x000027FF
			public unsafe UnityWebRequest _request_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider._sendForgotPasswordToServer_d__49.NativeFieldInfoPtr__request_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformProvider._sendForgotPasswordToServer_d__49.NativeFieldInfoPtr__request_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400030B RID: 779
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400030C RID: 780
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400030D RID: 781
			private static readonly IntPtr NativeFieldInfoPtr_apiUrl;

			// Token: 0x0400030E RID: 782
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x0400030F RID: 783
			private static readonly IntPtr NativeFieldInfoPtr__request_5__2;

			// Token: 0x04000310 RID: 784
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000311 RID: 785
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000312 RID: 786
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000313 RID: 787
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000314 RID: 788
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000315 RID: 789
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000316 RID: 790
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000081 RID: 129
		private sealed class MethodInfoStoreGeneric_AddHandler_Public_Void_TypedHandler_1_T_0<T>
		{
			// Token: 0x04000317 RID: 791
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlatformProvider.NativeMethodInfoPtr_AddHandler_Public_Void_TypedHandler_1_T_0, Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000082 RID: 130
		private sealed class MethodInfoStoreGeneric_SetHandler_Public_Void_TypedHandler_1_T_0<T>
		{
			// Token: 0x04000318 RID: 792
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlatformProvider.NativeMethodInfoPtr_SetHandler_Public_Void_TypedHandler_1_T_0, Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000083 RID: 131
		private sealed class MethodInfoStoreGeneric_RemoveHandler_Public_Void_TypedHandler_1_T_0<T>
		{
			// Token: 0x04000319 RID: 793
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlatformProvider.NativeMethodInfoPtr_RemoveHandler_Public_Void_TypedHandler_1_T_0, Il2CppClassPointerStore<PlatformProvider>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
