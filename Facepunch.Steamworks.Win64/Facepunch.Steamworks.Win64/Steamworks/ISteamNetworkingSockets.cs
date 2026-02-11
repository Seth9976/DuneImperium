using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x02000024 RID: 36
	public class ISteamNetworkingSockets : SteamInterface
	{
		// Token: 0x060004D3 RID: 1235 RVA: 0x0002C098 File Offset: 0x0002A298
		// Note: this type is marked as 'beforefieldinit'.
		static ISteamNetworkingSockets()
		{
			Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "ISteamNetworkingSockets");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr);
			ISteamNetworkingSockets.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664462);
			ISteamNetworkingSockets.NativeMethodInfoPtr_SteamAPI_SteamNetworkingSockets_SteamAPI_v012_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664463);
			ISteamNetworkingSockets.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664464);
			ISteamNetworkingSockets.NativeMethodInfoPtr_SteamAPI_SteamGameServerNetworkingSockets_SteamAPI_v012_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664465);
			ISteamNetworkingSockets.NativeMethodInfoPtr_GetServerInterfacePointer_Public_Virtual_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664466);
			ISteamNetworkingSockets.NativeMethodInfoPtr__CreateListenSocketIP_Private_Static_Socket_IntPtr_byref_NetAddress_Int32_Il2CppStructArray_1_NetKeyValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664467);
			ISteamNetworkingSockets.NativeMethodInfoPtr_CreateListenSocketIP_Internal_Socket_byref_NetAddress_Int32_Il2CppStructArray_1_NetKeyValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664468);
			ISteamNetworkingSockets.NativeMethodInfoPtr__ConnectByIPAddress_Private_Static_Connection_IntPtr_byref_NetAddress_Int32_Il2CppStructArray_1_NetKeyValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664469);
			ISteamNetworkingSockets.NativeMethodInfoPtr_ConnectByIPAddress_Internal_Connection_byref_NetAddress_Int32_Il2CppStructArray_1_NetKeyValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664470);
			ISteamNetworkingSockets.NativeMethodInfoPtr__CreateListenSocketP2P_Private_Static_Socket_IntPtr_Int32_Int32_Il2CppStructArray_1_NetKeyValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664471);
			ISteamNetworkingSockets.NativeMethodInfoPtr_CreateListenSocketP2P_Internal_Socket_Int32_Int32_Il2CppStructArray_1_NetKeyValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664472);
			ISteamNetworkingSockets.NativeMethodInfoPtr__ConnectP2P_Private_Static_Connection_IntPtr_byref_NetIdentity_Int32_Int32_Il2CppStructArray_1_NetKeyValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664473);
			ISteamNetworkingSockets.NativeMethodInfoPtr_ConnectP2P_Internal_Connection_byref_NetIdentity_Int32_Int32_Il2CppStructArray_1_NetKeyValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664474);
			ISteamNetworkingSockets.NativeMethodInfoPtr__AcceptConnection_Private_Static_Result_IntPtr_Connection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664475);
			ISteamNetworkingSockets.NativeMethodInfoPtr_AcceptConnection_Internal_Result_Connection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664476);
			ISteamNetworkingSockets.NativeMethodInfoPtr__CloseConnection_Private_Static_Boolean_IntPtr_Connection_Int32_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664477);
			ISteamNetworkingSockets.NativeMethodInfoPtr_CloseConnection_Internal_Boolean_Connection_Int32_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664478);
			ISteamNetworkingSockets.NativeMethodInfoPtr__CloseListenSocket_Private_Static_Boolean_IntPtr_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664479);
			ISteamNetworkingSockets.NativeMethodInfoPtr_CloseListenSocket_Internal_Boolean_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664480);
			ISteamNetworkingSockets.NativeMethodInfoPtr__SetConnectionUserData_Private_Static_Boolean_IntPtr_Connection_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664481);
			ISteamNetworkingSockets.NativeMethodInfoPtr_SetConnectionUserData_Internal_Boolean_Connection_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664482);
			ISteamNetworkingSockets.NativeMethodInfoPtr__GetConnectionUserData_Private_Static_Int64_IntPtr_Connection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664483);
			ISteamNetworkingSockets.NativeMethodInfoPtr_GetConnectionUserData_Internal_Int64_Connection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664484);
			ISteamNetworkingSockets.NativeMethodInfoPtr__SetConnectionName_Private_Static_Void_IntPtr_Connection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664485);
			ISteamNetworkingSockets.NativeMethodInfoPtr_SetConnectionName_Internal_Void_Connection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664486);
			ISteamNetworkingSockets.NativeMethodInfoPtr__GetConnectionName_Private_Static_Boolean_IntPtr_Connection_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664487);
			ISteamNetworkingSockets.NativeMethodInfoPtr_GetConnectionName_Internal_Boolean_Connection_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664488);
			ISteamNetworkingSockets.NativeMethodInfoPtr__SendMessageToConnection_Private_Static_Result_IntPtr_Connection_IntPtr_UInt32_Int32_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664489);
			ISteamNetworkingSockets.NativeMethodInfoPtr_SendMessageToConnection_Internal_Result_Connection_IntPtr_UInt32_Int32_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664490);
			ISteamNetworkingSockets.NativeMethodInfoPtr__SendMessages_Private_Static_Void_IntPtr_Int32_ptr_ptr_NetMsg_ptr_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664491);
			ISteamNetworkingSockets.NativeMethodInfoPtr_SendMessages_Internal_Void_Int32_ptr_ptr_NetMsg_ptr_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664492);
			ISteamNetworkingSockets.NativeMethodInfoPtr__FlushMessagesOnConnection_Private_Static_Result_IntPtr_Connection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664493);
			ISteamNetworkingSockets.NativeMethodInfoPtr_FlushMessagesOnConnection_Internal_Result_Connection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664494);
			ISteamNetworkingSockets.NativeMethodInfoPtr__ReceiveMessagesOnConnection_Private_Static_Int32_IntPtr_Connection_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664495);
			ISteamNetworkingSockets.NativeMethodInfoPtr_ReceiveMessagesOnConnection_Internal_Int32_Connection_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664496);
			ISteamNetworkingSockets.NativeMethodInfoPtr__GetConnectionInfo_Private_Static_Boolean_IntPtr_Connection_byref_ConnectionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664497);
			ISteamNetworkingSockets.NativeMethodInfoPtr_GetConnectionInfo_Internal_Boolean_Connection_byref_ConnectionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664498);
			ISteamNetworkingSockets.NativeMethodInfoPtr__GetConnectionRealTimeStatus_Private_Static_Result_IntPtr_Connection_byref_ConnectionStatus_Int32_Il2CppReferenceArray_1_ConnectionLaneStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664499);
			ISteamNetworkingSockets.NativeMethodInfoPtr_GetConnectionRealTimeStatus_Internal_Result_Connection_byref_ConnectionStatus_Int32_Il2CppReferenceArray_1_ConnectionLaneStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664500);
			ISteamNetworkingSockets.NativeMethodInfoPtr__GetDetailedConnectionStatus_Private_Static_Int32_IntPtr_Connection_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664501);
			ISteamNetworkingSockets.NativeMethodInfoPtr_GetDetailedConnectionStatus_Internal_Int32_Connection_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664502);
			ISteamNetworkingSockets.NativeMethodInfoPtr__GetListenSocketAddress_Private_Static_Boolean_IntPtr_Socket_byref_NetAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664503);
			ISteamNetworkingSockets.NativeMethodInfoPtr_GetListenSocketAddress_Internal_Boolean_Socket_byref_NetAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664504);
			ISteamNetworkingSockets.NativeMethodInfoPtr__CreateSocketPair_Private_Static_Boolean_IntPtr_Il2CppStructArray_1_Connection_Il2CppStructArray_1_Connection_Boolean_byref_NetIdentity_byref_NetIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664505);
			ISteamNetworkingSockets.NativeMethodInfoPtr_CreateSocketPair_Internal_Boolean_Il2CppStructArray_1_Connection_Il2CppStructArray_1_Connection_Boolean_byref_NetIdentity_byref_NetIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664506);
			ISteamNetworkingSockets.NativeMethodInfoPtr__ConfigureConnectionLanes_Private_Static_Result_IntPtr_Connection_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664507);
			ISteamNetworkingSockets.NativeMethodInfoPtr_ConfigureConnectionLanes_Internal_Result_Connection_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664508);
			ISteamNetworkingSockets.NativeMethodInfoPtr__GetIdentity_Private_Static_Boolean_IntPtr_byref_NetIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664509);
			ISteamNetworkingSockets.NativeMethodInfoPtr_GetIdentity_Internal_Boolean_byref_NetIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664510);
			ISteamNetworkingSockets.NativeMethodInfoPtr__InitAuthentication_Private_Static_SteamNetworkingAvailability_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664511);
			ISteamNetworkingSockets.NativeMethodInfoPtr_InitAuthentication_Internal_SteamNetworkingAvailability_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664512);
			ISteamNetworkingSockets.NativeMethodInfoPtr__GetAuthenticationStatus_Private_Static_SteamNetworkingAvailability_IntPtr_byref_SteamNetAuthenticationStatus_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664513);
			ISteamNetworkingSockets.NativeMethodInfoPtr_GetAuthenticationStatus_Internal_SteamNetworkingAvailability_byref_SteamNetAuthenticationStatus_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664514);
			ISteamNetworkingSockets.NativeMethodInfoPtr__CreatePollGroup_Private_Static_HSteamNetPollGroup_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664515);
			ISteamNetworkingSockets.NativeMethodInfoPtr_CreatePollGroup_Internal_HSteamNetPollGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664516);
			ISteamNetworkingSockets.NativeMethodInfoPtr__DestroyPollGroup_Private_Static_Boolean_IntPtr_HSteamNetPollGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664517);
			ISteamNetworkingSockets.NativeMethodInfoPtr_DestroyPollGroup_Internal_Boolean_HSteamNetPollGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664518);
			ISteamNetworkingSockets.NativeMethodInfoPtr__SetConnectionPollGroup_Private_Static_Boolean_IntPtr_Connection_HSteamNetPollGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664519);
			ISteamNetworkingSockets.NativeMethodInfoPtr_SetConnectionPollGroup_Internal_Boolean_Connection_HSteamNetPollGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664520);
			ISteamNetworkingSockets.NativeMethodInfoPtr__ReceiveMessagesOnPollGroup_Private_Static_Int32_IntPtr_HSteamNetPollGroup_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664521);
			ISteamNetworkingSockets.NativeMethodInfoPtr_ReceiveMessagesOnPollGroup_Internal_Int32_HSteamNetPollGroup_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664522);
			ISteamNetworkingSockets.NativeMethodInfoPtr__ReceivedRelayAuthTicket_Private_Static_Boolean_IntPtr_IntPtr_Int32_Il2CppStructArray_1_SteamDatagramRelayAuthTicket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664523);
			ISteamNetworkingSockets.NativeMethodInfoPtr_ReceivedRelayAuthTicket_Internal_Boolean_IntPtr_Int32_Il2CppStructArray_1_SteamDatagramRelayAuthTicket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664524);
			ISteamNetworkingSockets.NativeMethodInfoPtr__FindRelayAuthTicketForServer_Private_Static_Int32_IntPtr_byref_NetIdentity_Int32_Il2CppStructArray_1_SteamDatagramRelayAuthTicket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664525);
			ISteamNetworkingSockets.NativeMethodInfoPtr_FindRelayAuthTicketForServer_Internal_Int32_byref_NetIdentity_Int32_Il2CppStructArray_1_SteamDatagramRelayAuthTicket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664526);
			ISteamNetworkingSockets.NativeMethodInfoPtr__ConnectToHostedDedicatedServer_Private_Static_Connection_IntPtr_byref_NetIdentity_Int32_Int32_Il2CppStructArray_1_NetKeyValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664527);
			ISteamNetworkingSockets.NativeMethodInfoPtr_ConnectToHostedDedicatedServer_Internal_Connection_byref_NetIdentity_Int32_Int32_Il2CppStructArray_1_NetKeyValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664528);
			ISteamNetworkingSockets.NativeMethodInfoPtr__GetHostedDedicatedServerPort_Private_Static_UInt16_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664529);
			ISteamNetworkingSockets.NativeMethodInfoPtr_GetHostedDedicatedServerPort_Internal_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664530);
			ISteamNetworkingSockets.NativeMethodInfoPtr__GetHostedDedicatedServerPOPID_Private_Static_SteamNetworkingPOPID_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664531);
			ISteamNetworkingSockets.NativeMethodInfoPtr_GetHostedDedicatedServerPOPID_Internal_SteamNetworkingPOPID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664532);
			ISteamNetworkingSockets.NativeMethodInfoPtr__GetHostedDedicatedServerAddress_Private_Static_Result_IntPtr_byref_SteamDatagramHostedAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664533);
			ISteamNetworkingSockets.NativeMethodInfoPtr_GetHostedDedicatedServerAddress_Internal_Result_byref_SteamDatagramHostedAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664534);
			ISteamNetworkingSockets.NativeMethodInfoPtr__CreateHostedDedicatedServerListenSocket_Private_Static_Socket_IntPtr_Int32_Int32_Il2CppStructArray_1_NetKeyValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664535);
			ISteamNetworkingSockets.NativeMethodInfoPtr_CreateHostedDedicatedServerListenSocket_Internal_Socket_Int32_Int32_Il2CppStructArray_1_NetKeyValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664536);
			ISteamNetworkingSockets.NativeMethodInfoPtr__GetGameCoordinatorServerLogin_Private_Static_Result_IntPtr_byref_SteamDatagramGameCoordinatorServerLogin_byref_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664537);
			ISteamNetworkingSockets.NativeMethodInfoPtr_GetGameCoordinatorServerLogin_Internal_Result_byref_SteamDatagramGameCoordinatorServerLogin_byref_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664538);
			ISteamNetworkingSockets.NativeMethodInfoPtr__ConnectP2PCustomSignaling_Private_Static_Connection_IntPtr_IntPtr_byref_NetIdentity_Int32_Int32_Il2CppStructArray_1_NetKeyValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664539);
			ISteamNetworkingSockets.NativeMethodInfoPtr_ConnectP2PCustomSignaling_Internal_Connection_IntPtr_byref_NetIdentity_Int32_Int32_Il2CppStructArray_1_NetKeyValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664540);
			ISteamNetworkingSockets.NativeMethodInfoPtr__ReceivedP2PCustomSignal_Private_Static_Boolean_IntPtr_IntPtr_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664541);
			ISteamNetworkingSockets.NativeMethodInfoPtr_ReceivedP2PCustomSignal_Internal_Boolean_IntPtr_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664542);
			ISteamNetworkingSockets.NativeMethodInfoPtr__GetCertificateRequest_Private_Static_Boolean_IntPtr_byref_Int32_IntPtr_byref_NetErrorMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664543);
			ISteamNetworkingSockets.NativeMethodInfoPtr_GetCertificateRequest_Internal_Boolean_byref_Int32_IntPtr_byref_NetErrorMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664544);
			ISteamNetworkingSockets.NativeMethodInfoPtr__SetCertificate_Private_Static_Boolean_IntPtr_IntPtr_Int32_byref_NetErrorMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664545);
			ISteamNetworkingSockets.NativeMethodInfoPtr_SetCertificate_Internal_Boolean_IntPtr_Int32_byref_NetErrorMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664546);
			ISteamNetworkingSockets.NativeMethodInfoPtr__ResetIdentity_Private_Static_Void_IntPtr_byref_NetIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664547);
			ISteamNetworkingSockets.NativeMethodInfoPtr_ResetIdentity_Internal_Void_byref_NetIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664548);
			ISteamNetworkingSockets.NativeMethodInfoPtr__RunCallbacks_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664549);
			ISteamNetworkingSockets.NativeMethodInfoPtr_RunCallbacks_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664550);
			ISteamNetworkingSockets.NativeMethodInfoPtr__BeginAsyncRequestFakeIP_Private_Static_Boolean_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664551);
			ISteamNetworkingSockets.NativeMethodInfoPtr_BeginAsyncRequestFakeIP_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664552);
			ISteamNetworkingSockets.NativeMethodInfoPtr__GetFakeIP_Private_Static_Void_IntPtr_Int32_byref_SteamNetworkingFakeIPResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664553);
			ISteamNetworkingSockets.NativeMethodInfoPtr_GetFakeIP_Internal_Void_Int32_byref_SteamNetworkingFakeIPResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664554);
			ISteamNetworkingSockets.NativeMethodInfoPtr__CreateListenSocketP2PFakeIP_Private_Static_Socket_IntPtr_Int32_Int32_Il2CppStructArray_1_NetKeyValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664555);
			ISteamNetworkingSockets.NativeMethodInfoPtr_CreateListenSocketP2PFakeIP_Internal_Socket_Int32_Int32_Il2CppStructArray_1_NetKeyValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664556);
			ISteamNetworkingSockets.NativeMethodInfoPtr__GetRemoteFakeIPForConnection_Private_Static_Result_IntPtr_Connection_Il2CppStructArray_1_NetAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664557);
			ISteamNetworkingSockets.NativeMethodInfoPtr_GetRemoteFakeIPForConnection_Internal_Result_Connection_Il2CppStructArray_1_NetAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664558);
			ISteamNetworkingSockets.NativeMethodInfoPtr__CreateFakeUDPPort_Private_Static_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664559);
			ISteamNetworkingSockets.NativeMethodInfoPtr_CreateFakeUDPPort_Internal_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr, 100664560);
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x0002C884 File Offset: 0x0002AA84
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 930944, RefRangeEnd = 930966, XrefRangeStart = 930944, XrefRangeEnd = 930966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISteamNetworkingSockets(bool IsGameServer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamNetworkingSockets>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref IsGameServer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x0002C8CC File Offset: 0x0002AACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934056, XrefRangeEnd = 934058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr SteamAPI_SteamNetworkingSockets_SteamAPI_v012()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_SteamAPI_SteamNetworkingSockets_SteamAPI_v012_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x0002C8FC File Offset: 0x0002AAFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IntPtr GetUserInterfacePointer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamNetworkingSockets.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x0002C944 File Offset: 0x0002AB44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934058, XrefRangeEnd = 934060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr SteamAPI_SteamGameServerNetworkingSockets_SteamAPI_v012()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_SteamAPI_SteamGameServerNetworkingSockets_SteamAPI_v012_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x0002C974 File Offset: 0x0002AB74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IntPtr GetServerInterfacePointer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamNetworkingSockets.NativeMethodInfoPtr_GetServerInterfacePointer_Public_Virtual_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x0002C9BC File Offset: 0x0002ABBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934060, XrefRangeEnd = 934062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Socket _CreateListenSocketIP(IntPtr self, ref NetAddress localAddress, int nOptions, [In] [Out] Il2CppStructArray<NetKeyValue> pOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &localAddress;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nOptions;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__CreateListenSocketIP_Private_Static_Socket_IntPtr_byref_NetAddress_Int32_Il2CppStructArray_1_NetKeyValue_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pOptions = ((intPtr4 == 0) ? null : new Il2CppStructArray<NetKeyValue>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x0002CA38 File Offset: 0x0002AC38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 934064, RefRangeEnd = 934066, XrefRangeStart = 934062, XrefRangeEnd = 934064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Socket CreateListenSocketIP(ref NetAddress localAddress, int nOptions, [In] [Out] Il2CppStructArray<NetKeyValue> pOptions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &localAddress;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nOptions;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_CreateListenSocketIP_Internal_Socket_byref_NetAddress_Int32_Il2CppStructArray_1_NetKeyValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pOptions = ((intPtr4 == 0) ? null : new Il2CppStructArray<NetKeyValue>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x0002CAB4 File Offset: 0x0002ACB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934066, XrefRangeEnd = 934068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Connection _ConnectByIPAddress(IntPtr self, ref NetAddress address, int nOptions, [In] [Out] Il2CppStructArray<NetKeyValue> pOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &address;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nOptions;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__ConnectByIPAddress_Private_Static_Connection_IntPtr_byref_NetAddress_Int32_Il2CppStructArray_1_NetKeyValue_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pOptions = ((intPtr4 == 0) ? null : new Il2CppStructArray<NetKeyValue>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x0002CB30 File Offset: 0x0002AD30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 934070, RefRangeEnd = 934072, XrefRangeStart = 934068, XrefRangeEnd = 934070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Connection ConnectByIPAddress(ref NetAddress address, int nOptions, [In] [Out] Il2CppStructArray<NetKeyValue> pOptions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &address;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nOptions;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_ConnectByIPAddress_Internal_Connection_byref_NetAddress_Int32_Il2CppStructArray_1_NetKeyValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pOptions = ((intPtr4 == 0) ? null : new Il2CppStructArray<NetKeyValue>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x0002CBAC File Offset: 0x0002ADAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934072, XrefRangeEnd = 934074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Socket _CreateListenSocketP2P(IntPtr self, int nLocalVirtualPort, int nOptions, [In] [Out] Il2CppStructArray<NetKeyValue> pOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nLocalVirtualPort;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nOptions;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__CreateListenSocketP2P_Private_Static_Socket_IntPtr_Int32_Int32_Il2CppStructArray_1_NetKeyValue_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pOptions = ((intPtr4 == 0) ? null : new Il2CppStructArray<NetKeyValue>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x0002CC28 File Offset: 0x0002AE28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 934076, RefRangeEnd = 934078, XrefRangeStart = 934074, XrefRangeEnd = 934076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Socket CreateListenSocketP2P(int nLocalVirtualPort, int nOptions, [In] [Out] Il2CppStructArray<NetKeyValue> pOptions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nLocalVirtualPort;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nOptions;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_CreateListenSocketP2P_Internal_Socket_Int32_Int32_Il2CppStructArray_1_NetKeyValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pOptions = ((intPtr4 == 0) ? null : new Il2CppStructArray<NetKeyValue>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x0002CCA4 File Offset: 0x0002AEA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934078, XrefRangeEnd = 934080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Connection _ConnectP2P(IntPtr self, ref NetIdentity identityRemote, int nRemoteVirtualPort, int nOptions, [In] [Out] Il2CppStructArray<NetKeyValue> pOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &identityRemote;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nRemoteVirtualPort;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nOptions;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__ConnectP2P_Private_Static_Connection_IntPtr_byref_NetIdentity_Int32_Int32_Il2CppStructArray_1_NetKeyValue_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pOptions = ((intPtr4 == 0) ? null : new Il2CppStructArray<NetKeyValue>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x0002CD30 File Offset: 0x0002AF30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 934082, RefRangeEnd = 934084, XrefRangeStart = 934080, XrefRangeEnd = 934082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Connection ConnectP2P(ref NetIdentity identityRemote, int nRemoteVirtualPort, int nOptions, [In] [Out] Il2CppStructArray<NetKeyValue> pOptions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &identityRemote;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nRemoteVirtualPort;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nOptions;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_ConnectP2P_Internal_Connection_byref_NetIdentity_Int32_Int32_Il2CppStructArray_1_NetKeyValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pOptions = ((intPtr4 == 0) ? null : new Il2CppStructArray<NetKeyValue>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x0002CDBC File Offset: 0x0002AFBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934084, XrefRangeEnd = 934086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Result _AcceptConnection(IntPtr self, Connection hConn)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hConn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__AcceptConnection_Private_Static_Result_IntPtr_Connection_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x0002CE08 File Offset: 0x0002B008
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934088, RefRangeEnd = 934089, XrefRangeStart = 934086, XrefRangeEnd = 934088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Result AcceptConnection(Connection hConn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hConn;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_AcceptConnection_Internal_Result_Connection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x0002CE54 File Offset: 0x0002B054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934089, XrefRangeEnd = 934092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _CloseConnection(IntPtr self, Connection hPeer, int nReason, string pszDebug, bool bEnableLinger)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hPeer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nReason;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pszDebug);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bEnableLinger;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__CloseConnection_Private_Static_Boolean_IntPtr_Connection_Int32_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x0002CED0 File Offset: 0x0002B0D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934095, RefRangeEnd = 934096, XrefRangeStart = 934092, XrefRangeEnd = 934095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CloseConnection(Connection hPeer, int nReason, string pszDebug, bool bEnableLinger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hPeer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nReason;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pszDebug);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bEnableLinger;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_CloseConnection_Internal_Boolean_Connection_Int32_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x0002CF48 File Offset: 0x0002B148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934096, XrefRangeEnd = 934098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _CloseListenSocket(IntPtr self, Socket hSocket)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSocket;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__CloseListenSocket_Private_Static_Boolean_IntPtr_Socket_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x0002CF94 File Offset: 0x0002B194
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934100, RefRangeEnd = 934101, XrefRangeStart = 934098, XrefRangeEnd = 934100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CloseListenSocket(Socket hSocket)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSocket;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_CloseListenSocket_Internal_Boolean_Socket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x0002CFE0 File Offset: 0x0002B1E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934101, XrefRangeEnd = 934103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetConnectionUserData(IntPtr self, Connection hPeer, long nUserData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hPeer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nUserData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__SetConnectionUserData_Private_Static_Boolean_IntPtr_Connection_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x0002D03C File Offset: 0x0002B23C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934105, RefRangeEnd = 934106, XrefRangeStart = 934103, XrefRangeEnd = 934105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetConnectionUserData(Connection hPeer, long nUserData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hPeer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nUserData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_SetConnectionUserData_Internal_Boolean_Connection_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x0002D094 File Offset: 0x0002B294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934106, XrefRangeEnd = 934108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long _GetConnectionUserData(IntPtr self, Connection hPeer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hPeer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__GetConnectionUserData_Private_Static_Int64_IntPtr_Connection_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x0002D0E0 File Offset: 0x0002B2E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934110, RefRangeEnd = 934111, XrefRangeStart = 934108, XrefRangeEnd = 934110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long GetConnectionUserData(Connection hPeer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hPeer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_GetConnectionUserData_Internal_Int64_Connection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x0002D12C File Offset: 0x0002B32C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934111, XrefRangeEnd = 934114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SetConnectionName(IntPtr self, Connection hPeer, string pszName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hPeer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pszName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__SetConnectionName_Private_Static_Void_IntPtr_Connection_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x0002D180 File Offset: 0x0002B380
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934117, RefRangeEnd = 934118, XrefRangeStart = 934114, XrefRangeEnd = 934117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetConnectionName(Connection hPeer, string pszName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hPeer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pszName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_SetConnectionName_Internal_Void_Connection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x0002D1D0 File Offset: 0x0002B3D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934118, XrefRangeEnd = 934120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetConnectionName(IntPtr self, Connection hPeer, IntPtr pszName, int nMaxLen)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hPeer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pszName;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMaxLen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__GetConnectionName_Private_Static_Boolean_IntPtr_Connection_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x0002D238 File Offset: 0x0002B438
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934142, RefRangeEnd = 934143, XrefRangeStart = 934120, XrefRangeEnd = 934142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetConnectionName(Connection hPeer, out string pszName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hPeer;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_GetConnectionName_Internal_Boolean_Connection_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pszName = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x0002D29C File Offset: 0x0002B49C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934143, XrefRangeEnd = 934145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Result _SendMessageToConnection(IntPtr self, Connection hConn, IntPtr pData, uint cbData, int nSendFlags, ref long pOutMessageNumber)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hConn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pData;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbData;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nSendFlags;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pOutMessageNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__SendMessageToConnection_Private_Static_Result_IntPtr_Connection_IntPtr_UInt32_Int32_byref_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x0002D320 File Offset: 0x0002B520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934145, XrefRangeEnd = 934147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Result SendMessageToConnection(Connection hConn, IntPtr pData, uint cbData, int nSendFlags, ref long pOutMessageNumber)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hConn;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pData;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbData;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nSendFlags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pOutMessageNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_SendMessageToConnection_Internal_Result_Connection_IntPtr_UInt32_Int32_byref_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x0002D3A4 File Offset: 0x0002B5A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934147, XrefRangeEnd = 934149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SendMessages(IntPtr self, int nMessages, NetMsg** pMessages, long* pOutMessageNumberOrResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMessages;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pMessages;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pOutMessageNumberOrResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__SendMessages_Private_Static_Void_IntPtr_Int32_ptr_ptr_NetMsg_ptr_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x0002D400 File Offset: 0x0002B600
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 934151, RefRangeEnd = 934153, XrefRangeStart = 934149, XrefRangeEnd = 934151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendMessages(int nMessages, NetMsg** pMessages, long* pOutMessageNumberOrResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nMessages;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pMessages;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pOutMessageNumberOrResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_SendMessages_Internal_Void_Int32_ptr_ptr_NetMsg_ptr_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x0002D458 File Offset: 0x0002B658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934153, XrefRangeEnd = 934155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Result _FlushMessagesOnConnection(IntPtr self, Connection hConn)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hConn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__FlushMessagesOnConnection_Private_Static_Result_IntPtr_Connection_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x0002D4A4 File Offset: 0x0002B6A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934157, RefRangeEnd = 934158, XrefRangeStart = 934155, XrefRangeEnd = 934157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Result FlushMessagesOnConnection(Connection hConn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hConn;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_FlushMessagesOnConnection_Internal_Result_Connection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x0002D4F0 File Offset: 0x0002B6F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934158, XrefRangeEnd = 934160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _ReceiveMessagesOnConnection(IntPtr self, Connection hConn, IntPtr ppOutMessages, int nMaxMessages)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hConn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ppOutMessages;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMaxMessages;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__ReceiveMessagesOnConnection_Private_Static_Int32_IntPtr_Connection_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x0002D558 File Offset: 0x0002B758
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934162, RefRangeEnd = 934163, XrefRangeStart = 934160, XrefRangeEnd = 934162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReceiveMessagesOnConnection(Connection hConn, IntPtr ppOutMessages, int nMaxMessages)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hConn;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ppOutMessages;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMaxMessages;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_ReceiveMessagesOnConnection_Internal_Int32_Connection_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0002D5C0 File Offset: 0x0002B7C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934163, XrefRangeEnd = 934170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetConnectionInfo(IntPtr self, Connection hConn, ref ConnectionInfo pInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hConn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(pInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__GetConnectionInfo_Private_Static_Boolean_IntPtr_Connection_byref_ConnectionInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0002D620 File Offset: 0x0002B820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934170, XrefRangeEnd = 934177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetConnectionInfo(Connection hConn, ref ConnectionInfo pInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hConn;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(pInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_GetConnectionInfo_Internal_Boolean_Connection_byref_ConnectionInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x0002D67C File Offset: 0x0002B87C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934189, RefRangeEnd = 934190, XrefRangeStart = 934177, XrefRangeEnd = 934189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Result _GetConnectionRealTimeStatus(IntPtr self, Connection hConn, ref ConnectionStatus pStatus, int nLanes, [In] [Out] Il2CppReferenceArray<ConnectionLaneStatus> pLanes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hConn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(pStatus);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nLanes;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__GetConnectionRealTimeStatus_Private_Static_Result_IntPtr_Connection_byref_ConnectionStatus_Int32_Il2CppReferenceArray_1_ConnectionLaneStatus_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pLanes = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<ConnectionLaneStatus>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x0002D70C File Offset: 0x0002B90C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934191, RefRangeEnd = 934192, XrefRangeStart = 934190, XrefRangeEnd = 934191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Result GetConnectionRealTimeStatus(Connection hConn, ref ConnectionStatus pStatus, int nLanes, [In] [Out] Il2CppReferenceArray<ConnectionLaneStatus> pLanes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hConn;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(pStatus);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nLanes;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_GetConnectionRealTimeStatus_Internal_Result_Connection_byref_ConnectionStatus_Int32_Il2CppReferenceArray_1_ConnectionLaneStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pLanes = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<ConnectionLaneStatus>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x0002D79C File Offset: 0x0002B99C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934192, XrefRangeEnd = 934194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetDetailedConnectionStatus(IntPtr self, Connection hConn, IntPtr pszBuf, int cbBuf)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hConn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pszBuf;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbBuf;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__GetDetailedConnectionStatus_Private_Static_Int32_IntPtr_Connection_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0002D804 File Offset: 0x0002BA04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934216, RefRangeEnd = 934217, XrefRangeStart = 934194, XrefRangeEnd = 934216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetDetailedConnectionStatus(Connection hConn, out string pszBuf)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hConn;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_GetDetailedConnectionStatus_Internal_Int32_Connection_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pszBuf = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x0002D868 File Offset: 0x0002BA68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934217, XrefRangeEnd = 934219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetListenSocketAddress(IntPtr self, Socket hSocket, ref NetAddress address)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSocket;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &address;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__GetListenSocketAddress_Private_Static_Boolean_IntPtr_Socket_byref_NetAddress_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x0002D8C4 File Offset: 0x0002BAC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934219, XrefRangeEnd = 934221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetListenSocketAddress(Socket hSocket, ref NetAddress address)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSocket;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &address;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_GetListenSocketAddress_Internal_Boolean_Socket_byref_NetAddress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0002D91C File Offset: 0x0002BB1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934221, XrefRangeEnd = 934223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _CreateSocketPair(IntPtr self, [In] [Out] Il2CppStructArray<Connection> pOutConnection1, [In] [Out] Il2CppStructArray<Connection> pOutConnection2, bool bUseNetworkLoopback, ref NetIdentity pIdentity1, ref NetIdentity pIdentity2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bUseNetworkLoopback;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pIdentity1;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pIdentity2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__CreateSocketPair_Private_Static_Boolean_IntPtr_Il2CppStructArray_1_Connection_Il2CppStructArray_1_Connection_Boolean_byref_NetIdentity_byref_NetIdentity_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			*pOutConnection1 = ((intPtr5 == 0) ? null : new Il2CppStructArray<Connection>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			*pOutConnection2 = ((intPtr6 == 0) ? null : new Il2CppStructArray<Connection>(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0002D9CC File Offset: 0x0002BBCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934223, XrefRangeEnd = 934225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CreateSocketPair([In] [Out] Il2CppStructArray<Connection> pOutConnection1, [In] [Out] Il2CppStructArray<Connection> pOutConnection2, bool bUseNetworkLoopback, ref NetIdentity pIdentity1, ref NetIdentity pIdentity2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bUseNetworkLoopback;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pIdentity1;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pIdentity2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_CreateSocketPair_Internal_Boolean_Il2CppStructArray_1_Connection_Il2CppStructArray_1_Connection_Boolean_byref_NetIdentity_byref_NetIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			*pOutConnection1 = ((intPtr5 == 0) ? null : new Il2CppStructArray<Connection>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			*pOutConnection2 = ((intPtr6 == 0) ? null : new Il2CppStructArray<Connection>(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x0002DA7C File Offset: 0x0002BC7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934225, XrefRangeEnd = 934227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Result _ConfigureConnectionLanes(IntPtr self, Connection hConn, int nNumLanes, [In] [Out] Il2CppStructArray<int> pLanePriorities, [In] [Out] Il2CppStructArray<ushort> pLaneWeights)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hConn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nNumLanes;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__ConfigureConnectionLanes_Private_Static_Result_IntPtr_Connection_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt16_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			*pLanePriorities = ((intPtr5 == 0) ? null : new Il2CppStructArray<int>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			*pLaneWeights = ((intPtr6 == 0) ? null : new Il2CppStructArray<ushort>(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x0002DB1C File Offset: 0x0002BD1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934229, RefRangeEnd = 934230, XrefRangeStart = 934227, XrefRangeEnd = 934229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Result ConfigureConnectionLanes(Connection hConn, int nNumLanes, [In] [Out] Il2CppStructArray<int> pLanePriorities, [In] [Out] Il2CppStructArray<ushort> pLaneWeights)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hConn;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nNumLanes;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_ConfigureConnectionLanes_Internal_Result_Connection_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			*pLanePriorities = ((intPtr5 == 0) ? null : new Il2CppStructArray<int>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			*pLaneWeights = ((intPtr6 == 0) ? null : new Il2CppStructArray<ushort>(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0002DBBC File Offset: 0x0002BDBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934230, XrefRangeEnd = 934232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetIdentity(IntPtr self, ref NetIdentity pIdentity)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pIdentity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__GetIdentity_Private_Static_Boolean_IntPtr_byref_NetIdentity_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x0002DC08 File Offset: 0x0002BE08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934234, RefRangeEnd = 934235, XrefRangeStart = 934232, XrefRangeEnd = 934234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetIdentity(ref NetIdentity pIdentity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pIdentity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_GetIdentity_Internal_Boolean_byref_NetIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x0002DC54 File Offset: 0x0002BE54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934235, XrefRangeEnd = 934237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamNetworkingAvailability _InitAuthentication(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__InitAuthentication_Private_Static_SteamNetworkingAvailability_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x0002DC94 File Offset: 0x0002BE94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934237, XrefRangeEnd = 934239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamNetworkingAvailability InitAuthentication()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_InitAuthentication_Internal_SteamNetworkingAvailability_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x0002DCD0 File Offset: 0x0002BED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934239, XrefRangeEnd = 934245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamNetworkingAvailability _GetAuthenticationStatus(IntPtr self, ref SteamNetAuthenticationStatus_t pDetails)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(pDetails);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__GetAuthenticationStatus_Private_Static_SteamNetworkingAvailability_IntPtr_byref_SteamNetAuthenticationStatus_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x0002DD20 File Offset: 0x0002BF20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934245, XrefRangeEnd = 934251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamNetworkingAvailability GetAuthenticationStatus(ref SteamNetAuthenticationStatus_t pDetails)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(pDetails);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_GetAuthenticationStatus_Internal_SteamNetworkingAvailability_byref_SteamNetAuthenticationStatus_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x0002DD70 File Offset: 0x0002BF70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934251, XrefRangeEnd = 934253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HSteamNetPollGroup _CreatePollGroup(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__CreatePollGroup_Private_Static_HSteamNetPollGroup_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x0002DDB0 File Offset: 0x0002BFB0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 934255, RefRangeEnd = 934259, XrefRangeStart = 934253, XrefRangeEnd = 934255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HSteamNetPollGroup CreatePollGroup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_CreatePollGroup_Internal_HSteamNetPollGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x0002DDEC File Offset: 0x0002BFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934259, XrefRangeEnd = 934261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _DestroyPollGroup(IntPtr self, HSteamNetPollGroup hPollGroup)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hPollGroup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__DestroyPollGroup_Private_Static_Boolean_IntPtr_HSteamNetPollGroup_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x0002DE38 File Offset: 0x0002C038
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934263, RefRangeEnd = 934264, XrefRangeStart = 934261, XrefRangeEnd = 934263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DestroyPollGroup(HSteamNetPollGroup hPollGroup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hPollGroup;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_DestroyPollGroup_Internal_Boolean_HSteamNetPollGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x0002DE84 File Offset: 0x0002C084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934264, XrefRangeEnd = 934266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetConnectionPollGroup(IntPtr self, Connection hConn, HSteamNetPollGroup hPollGroup)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hConn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hPollGroup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__SetConnectionPollGroup_Private_Static_Boolean_IntPtr_Connection_HSteamNetPollGroup_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x0002DEE0 File Offset: 0x0002C0E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934268, RefRangeEnd = 934269, XrefRangeStart = 934266, XrefRangeEnd = 934268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetConnectionPollGroup(Connection hConn, HSteamNetPollGroup hPollGroup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hConn;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hPollGroup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_SetConnectionPollGroup_Internal_Boolean_Connection_HSteamNetPollGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x0002DF38 File Offset: 0x0002C138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934269, XrefRangeEnd = 934271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _ReceiveMessagesOnPollGroup(IntPtr self, HSteamNetPollGroup hPollGroup, IntPtr ppOutMessages, int nMaxMessages)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hPollGroup;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ppOutMessages;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMaxMessages;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__ReceiveMessagesOnPollGroup_Private_Static_Int32_IntPtr_HSteamNetPollGroup_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x0002DFA0 File Offset: 0x0002C1A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934273, RefRangeEnd = 934274, XrefRangeStart = 934271, XrefRangeEnd = 934273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReceiveMessagesOnPollGroup(HSteamNetPollGroup hPollGroup, IntPtr ppOutMessages, int nMaxMessages)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hPollGroup;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ppOutMessages;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMaxMessages;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_ReceiveMessagesOnPollGroup_Internal_Int32_HSteamNetPollGroup_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x0002E008 File Offset: 0x0002C208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934274, XrefRangeEnd = 934276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _ReceivedRelayAuthTicket(IntPtr self, IntPtr pvTicket, int cbTicket, [In] [Out] Il2CppStructArray<SteamDatagramRelayAuthTicket> pOutParsedTicket)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pvTicket;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbTicket;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__ReceivedRelayAuthTicket_Private_Static_Boolean_IntPtr_IntPtr_Int32_Il2CppStructArray_1_SteamDatagramRelayAuthTicket_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pOutParsedTicket = ((intPtr4 == 0) ? null : new Il2CppStructArray<SteamDatagramRelayAuthTicket>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x0002E084 File Offset: 0x0002C284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934276, XrefRangeEnd = 934278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReceivedRelayAuthTicket(IntPtr pvTicket, int cbTicket, [In] [Out] Il2CppStructArray<SteamDatagramRelayAuthTicket> pOutParsedTicket)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pvTicket;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbTicket;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_ReceivedRelayAuthTicket_Internal_Boolean_IntPtr_Int32_Il2CppStructArray_1_SteamDatagramRelayAuthTicket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pOutParsedTicket = ((intPtr4 == 0) ? null : new Il2CppStructArray<SteamDatagramRelayAuthTicket>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x0002E100 File Offset: 0x0002C300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934278, XrefRangeEnd = 934280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _FindRelayAuthTicketForServer(IntPtr self, ref NetIdentity identityGameServer, int nRemoteVirtualPort, [In] [Out] Il2CppStructArray<SteamDatagramRelayAuthTicket> pOutParsedTicket)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &identityGameServer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nRemoteVirtualPort;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__FindRelayAuthTicketForServer_Private_Static_Int32_IntPtr_byref_NetIdentity_Int32_Il2CppStructArray_1_SteamDatagramRelayAuthTicket_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pOutParsedTicket = ((intPtr4 == 0) ? null : new Il2CppStructArray<SteamDatagramRelayAuthTicket>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x0002E17C File Offset: 0x0002C37C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934280, XrefRangeEnd = 934282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindRelayAuthTicketForServer(ref NetIdentity identityGameServer, int nRemoteVirtualPort, [In] [Out] Il2CppStructArray<SteamDatagramRelayAuthTicket> pOutParsedTicket)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &identityGameServer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nRemoteVirtualPort;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_FindRelayAuthTicketForServer_Internal_Int32_byref_NetIdentity_Int32_Il2CppStructArray_1_SteamDatagramRelayAuthTicket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pOutParsedTicket = ((intPtr4 == 0) ? null : new Il2CppStructArray<SteamDatagramRelayAuthTicket>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x0002E1F8 File Offset: 0x0002C3F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934282, XrefRangeEnd = 934284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Connection _ConnectToHostedDedicatedServer(IntPtr self, ref NetIdentity identityTarget, int nRemoteVirtualPort, int nOptions, [In] [Out] Il2CppStructArray<NetKeyValue> pOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &identityTarget;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nRemoteVirtualPort;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nOptions;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__ConnectToHostedDedicatedServer_Private_Static_Connection_IntPtr_byref_NetIdentity_Int32_Int32_Il2CppStructArray_1_NetKeyValue_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pOptions = ((intPtr4 == 0) ? null : new Il2CppStructArray<NetKeyValue>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x0002E284 File Offset: 0x0002C484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934284, XrefRangeEnd = 934286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Connection ConnectToHostedDedicatedServer(ref NetIdentity identityTarget, int nRemoteVirtualPort, int nOptions, [In] [Out] Il2CppStructArray<NetKeyValue> pOptions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &identityTarget;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nRemoteVirtualPort;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nOptions;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_ConnectToHostedDedicatedServer_Internal_Connection_byref_NetIdentity_Int32_Int32_Il2CppStructArray_1_NetKeyValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pOptions = ((intPtr4 == 0) ? null : new Il2CppStructArray<NetKeyValue>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x0002E310 File Offset: 0x0002C510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934286, XrefRangeEnd = 934288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort _GetHostedDedicatedServerPort(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__GetHostedDedicatedServerPort_Private_Static_UInt16_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x0002E350 File Offset: 0x0002C550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934288, XrefRangeEnd = 934290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ushort GetHostedDedicatedServerPort()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_GetHostedDedicatedServerPort_Internal_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x0002E38C File Offset: 0x0002C58C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934290, XrefRangeEnd = 934292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamNetworkingPOPID _GetHostedDedicatedServerPOPID(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__GetHostedDedicatedServerPOPID_Private_Static_SteamNetworkingPOPID_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x0002E3CC File Offset: 0x0002C5CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934292, XrefRangeEnd = 934294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamNetworkingPOPID GetHostedDedicatedServerPOPID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_GetHostedDedicatedServerPOPID_Internal_SteamNetworkingPOPID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x0002E408 File Offset: 0x0002C608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934294, XrefRangeEnd = 934299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Result _GetHostedDedicatedServerAddress(IntPtr self, ref SteamDatagramHostedAddress pRouting)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(pRouting);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__GetHostedDedicatedServerAddress_Private_Static_Result_IntPtr_byref_SteamDatagramHostedAddress_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x0002E458 File Offset: 0x0002C658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934299, XrefRangeEnd = 934304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Result GetHostedDedicatedServerAddress(ref SteamDatagramHostedAddress pRouting)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(pRouting);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_GetHostedDedicatedServerAddress_Internal_Result_byref_SteamDatagramHostedAddress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x0002E4A8 File Offset: 0x0002C6A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934304, XrefRangeEnd = 934306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Socket _CreateHostedDedicatedServerListenSocket(IntPtr self, int nLocalVirtualPort, int nOptions, [In] [Out] Il2CppStructArray<NetKeyValue> pOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nLocalVirtualPort;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nOptions;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__CreateHostedDedicatedServerListenSocket_Private_Static_Socket_IntPtr_Int32_Int32_Il2CppStructArray_1_NetKeyValue_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pOptions = ((intPtr4 == 0) ? null : new Il2CppStructArray<NetKeyValue>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x0002E524 File Offset: 0x0002C724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934306, XrefRangeEnd = 934308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Socket CreateHostedDedicatedServerListenSocket(int nLocalVirtualPort, int nOptions, [In] [Out] Il2CppStructArray<NetKeyValue> pOptions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nLocalVirtualPort;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nOptions;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_CreateHostedDedicatedServerListenSocket_Internal_Socket_Int32_Int32_Il2CppStructArray_1_NetKeyValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pOptions = ((intPtr4 == 0) ? null : new Il2CppStructArray<NetKeyValue>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x0002E5A0 File Offset: 0x0002C7A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934308, XrefRangeEnd = 934315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Result _GetGameCoordinatorServerLogin(IntPtr self, ref SteamDatagramGameCoordinatorServerLogin pLoginInfo, ref int pcbSignedBlob, IntPtr pBlob)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(pLoginInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pcbSignedBlob;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pBlob;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__GetGameCoordinatorServerLogin_Private_Static_Result_IntPtr_byref_SteamDatagramGameCoordinatorServerLogin_byref_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x0002E60C File Offset: 0x0002C80C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934315, XrefRangeEnd = 934322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Result GetGameCoordinatorServerLogin(ref SteamDatagramGameCoordinatorServerLogin pLoginInfo, ref int pcbSignedBlob, IntPtr pBlob)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(pLoginInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pcbSignedBlob;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pBlob;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_GetGameCoordinatorServerLogin_Internal_Result_byref_SteamDatagramGameCoordinatorServerLogin_byref_Int32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x0002E678 File Offset: 0x0002C878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934322, XrefRangeEnd = 934324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Connection _ConnectP2PCustomSignaling(IntPtr self, IntPtr pSignaling, ref NetIdentity pPeerIdentity, int nRemoteVirtualPort, int nOptions, [In] [Out] Il2CppStructArray<NetKeyValue> pOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pSignaling;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pPeerIdentity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nRemoteVirtualPort;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nOptions;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__ConnectP2PCustomSignaling_Private_Static_Connection_IntPtr_IntPtr_byref_NetIdentity_Int32_Int32_Il2CppStructArray_1_NetKeyValue_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pOptions = ((intPtr4 == 0) ? null : new Il2CppStructArray<NetKeyValue>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0002E714 File Offset: 0x0002C914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934324, XrefRangeEnd = 934326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Connection ConnectP2PCustomSignaling(IntPtr pSignaling, ref NetIdentity pPeerIdentity, int nRemoteVirtualPort, int nOptions, [In] [Out] Il2CppStructArray<NetKeyValue> pOptions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pSignaling;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pPeerIdentity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nRemoteVirtualPort;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nOptions;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_ConnectP2PCustomSignaling_Internal_Connection_IntPtr_byref_NetIdentity_Int32_Int32_Il2CppStructArray_1_NetKeyValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pOptions = ((intPtr4 == 0) ? null : new Il2CppStructArray<NetKeyValue>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x0002E7AC File Offset: 0x0002C9AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934326, XrefRangeEnd = 934328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _ReceivedP2PCustomSignal(IntPtr self, IntPtr pMsg, int cbMsg, IntPtr pContext)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pMsg;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbMsg;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__ReceivedP2PCustomSignal_Private_Static_Boolean_IntPtr_IntPtr_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x0002E814 File Offset: 0x0002CA14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934328, XrefRangeEnd = 934330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReceivedP2PCustomSignal(IntPtr pMsg, int cbMsg, IntPtr pContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pMsg;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbMsg;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_ReceivedP2PCustomSignal_Internal_Boolean_IntPtr_Int32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x0002E87C File Offset: 0x0002CA7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934330, XrefRangeEnd = 934338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetCertificateRequest(IntPtr self, ref int pcbBlob, IntPtr pBlob, ref NetErrorMessage errMsg)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pcbBlob;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pBlob;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errMsg;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__GetCertificateRequest_Private_Static_Boolean_IntPtr_byref_Int32_IntPtr_byref_NetErrorMessage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x0002E8E4 File Offset: 0x0002CAE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934338, XrefRangeEnd = 934346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetCertificateRequest(ref int pcbBlob, IntPtr pBlob, ref NetErrorMessage errMsg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pcbBlob;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pBlob;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errMsg;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_GetCertificateRequest_Internal_Boolean_byref_Int32_IntPtr_byref_NetErrorMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x0002E94C File Offset: 0x0002CB4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934346, XrefRangeEnd = 934354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetCertificate(IntPtr self, IntPtr pCertificate, int cbCertificate, ref NetErrorMessage errMsg)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pCertificate;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbCertificate;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errMsg;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__SetCertificate_Private_Static_Boolean_IntPtr_IntPtr_Int32_byref_NetErrorMessage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x0002E9B4 File Offset: 0x0002CBB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934354, XrefRangeEnd = 934362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetCertificate(IntPtr pCertificate, int cbCertificate, ref NetErrorMessage errMsg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pCertificate;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbCertificate;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errMsg;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_SetCertificate_Internal_Boolean_IntPtr_Int32_byref_NetErrorMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x0002EA1C File Offset: 0x0002CC1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934362, XrefRangeEnd = 934364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _ResetIdentity(IntPtr self, ref NetIdentity pIdentity)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pIdentity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__ResetIdentity_Private_Static_Void_IntPtr_byref_NetIdentity_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x0002EA5C File Offset: 0x0002CC5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934364, XrefRangeEnd = 934366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetIdentity(ref NetIdentity pIdentity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pIdentity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_ResetIdentity_Internal_Void_byref_NetIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x0002EA9C File Offset: 0x0002CC9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934366, XrefRangeEnd = 934368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _RunCallbacks(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__RunCallbacks_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x0002EAD0 File Offset: 0x0002CCD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934368, XrefRangeEnd = 934370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunCallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_RunCallbacks_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x0002EB04 File Offset: 0x0002CD04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934370, XrefRangeEnd = 934372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _BeginAsyncRequestFakeIP(IntPtr self, int nNumPorts)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nNumPorts;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__BeginAsyncRequestFakeIP_Private_Static_Boolean_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x0002EB50 File Offset: 0x0002CD50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934374, RefRangeEnd = 934375, XrefRangeStart = 934372, XrefRangeEnd = 934374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BeginAsyncRequestFakeIP(int nNumPorts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nNumPorts;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_BeginAsyncRequestFakeIP_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x0002EB9C File Offset: 0x0002CD9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934375, XrefRangeEnd = 934381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _GetFakeIP(IntPtr self, int idxFirstPort, ref SteamNetworkingFakeIPResult_t pInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idxFirstPort;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(pInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__GetFakeIP_Private_Static_Void_IntPtr_Int32_byref_SteamNetworkingFakeIPResult_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x0002EBF0 File Offset: 0x0002CDF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934387, RefRangeEnd = 934388, XrefRangeStart = 934381, XrefRangeEnd = 934387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetFakeIP(int idxFirstPort, ref SteamNetworkingFakeIPResult_t pInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref idxFirstPort;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(pInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_GetFakeIP_Internal_Void_Int32_byref_SteamNetworkingFakeIPResult_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x0002EC44 File Offset: 0x0002CE44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934388, XrefRangeEnd = 934390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Socket _CreateListenSocketP2PFakeIP(IntPtr self, int idxFakePort, int nOptions, [In] [Out] Il2CppStructArray<NetKeyValue> pOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idxFakePort;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nOptions;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__CreateListenSocketP2PFakeIP_Private_Static_Socket_IntPtr_Int32_Int32_Il2CppStructArray_1_NetKeyValue_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pOptions = ((intPtr4 == 0) ? null : new Il2CppStructArray<NetKeyValue>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x0002ECC0 File Offset: 0x0002CEC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 934392, RefRangeEnd = 934394, XrefRangeStart = 934390, XrefRangeEnd = 934392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Socket CreateListenSocketP2PFakeIP(int idxFakePort, int nOptions, [In] [Out] Il2CppStructArray<NetKeyValue> pOptions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref idxFakePort;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nOptions;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_CreateListenSocketP2PFakeIP_Internal_Socket_Int32_Int32_Il2CppStructArray_1_NetKeyValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pOptions = ((intPtr4 == 0) ? null : new Il2CppStructArray<NetKeyValue>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x0002ED3C File Offset: 0x0002CF3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934394, XrefRangeEnd = 934396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Result _GetRemoteFakeIPForConnection(IntPtr self, Connection hConn, [In] [Out] Il2CppStructArray<NetAddress> pOutAddr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hConn;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__GetRemoteFakeIPForConnection_Private_Static_Result_IntPtr_Connection_Il2CppStructArray_1_NetAddress_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pOutAddr = ((intPtr4 == 0) ? null : new Il2CppStructArray<NetAddress>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x0002EDAC File Offset: 0x0002CFAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934396, XrefRangeEnd = 934398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Result GetRemoteFakeIPForConnection(Connection hConn, [In] [Out] Il2CppStructArray<NetAddress> pOutAddr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hConn;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_GetRemoteFakeIPForConnection_Internal_Result_Connection_Il2CppStructArray_1_NetAddress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pOutAddr = ((intPtr4 == 0) ? null : new Il2CppStructArray<NetAddress>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x0002EE18 File Offset: 0x0002D018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934398, XrefRangeEnd = 934400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr _CreateFakeUDPPort(IntPtr self, int idxFakeServerPort)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idxFakeServerPort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr__CreateFakeUDPPort_Private_Static_IntPtr_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x0002EE64 File Offset: 0x0002D064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934400, XrefRangeEnd = 934402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr CreateFakeUDPPort(int idxFakeServerPort)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref idxFakeServerPort;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingSockets.NativeMethodInfoPtr_CreateFakeUDPPort_Internal_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x000023A2 File Offset: 0x000005A2
		public ISteamNetworkingSockets(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000554 RID: 1364
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x04000555 RID: 1365
		private static readonly IntPtr NativeMethodInfoPtr_SteamAPI_SteamNetworkingSockets_SteamAPI_v012_Internal_Static_IntPtr_0;

		// Token: 0x04000556 RID: 1366
		private static readonly IntPtr NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0;

		// Token: 0x04000557 RID: 1367
		private static readonly IntPtr NativeMethodInfoPtr_SteamAPI_SteamGameServerNetworkingSockets_SteamAPI_v012_Internal_Static_IntPtr_0;

		// Token: 0x04000558 RID: 1368
		private static readonly IntPtr NativeMethodInfoPtr_GetServerInterfacePointer_Public_Virtual_IntPtr_0;

		// Token: 0x04000559 RID: 1369
		private static readonly IntPtr NativeMethodInfoPtr__CreateListenSocketIP_Private_Static_Socket_IntPtr_byref_NetAddress_Int32_Il2CppStructArray_1_NetKeyValue_0;

		// Token: 0x0400055A RID: 1370
		private static readonly IntPtr NativeMethodInfoPtr_CreateListenSocketIP_Internal_Socket_byref_NetAddress_Int32_Il2CppStructArray_1_NetKeyValue_0;

		// Token: 0x0400055B RID: 1371
		private static readonly IntPtr NativeMethodInfoPtr__ConnectByIPAddress_Private_Static_Connection_IntPtr_byref_NetAddress_Int32_Il2CppStructArray_1_NetKeyValue_0;

		// Token: 0x0400055C RID: 1372
		private static readonly IntPtr NativeMethodInfoPtr_ConnectByIPAddress_Internal_Connection_byref_NetAddress_Int32_Il2CppStructArray_1_NetKeyValue_0;

		// Token: 0x0400055D RID: 1373
		private static readonly IntPtr NativeMethodInfoPtr__CreateListenSocketP2P_Private_Static_Socket_IntPtr_Int32_Int32_Il2CppStructArray_1_NetKeyValue_0;

		// Token: 0x0400055E RID: 1374
		private static readonly IntPtr NativeMethodInfoPtr_CreateListenSocketP2P_Internal_Socket_Int32_Int32_Il2CppStructArray_1_NetKeyValue_0;

		// Token: 0x0400055F RID: 1375
		private static readonly IntPtr NativeMethodInfoPtr__ConnectP2P_Private_Static_Connection_IntPtr_byref_NetIdentity_Int32_Int32_Il2CppStructArray_1_NetKeyValue_0;

		// Token: 0x04000560 RID: 1376
		private static readonly IntPtr NativeMethodInfoPtr_ConnectP2P_Internal_Connection_byref_NetIdentity_Int32_Int32_Il2CppStructArray_1_NetKeyValue_0;

		// Token: 0x04000561 RID: 1377
		private static readonly IntPtr NativeMethodInfoPtr__AcceptConnection_Private_Static_Result_IntPtr_Connection_0;

		// Token: 0x04000562 RID: 1378
		private static readonly IntPtr NativeMethodInfoPtr_AcceptConnection_Internal_Result_Connection_0;

		// Token: 0x04000563 RID: 1379
		private static readonly IntPtr NativeMethodInfoPtr__CloseConnection_Private_Static_Boolean_IntPtr_Connection_Int32_String_Boolean_0;

		// Token: 0x04000564 RID: 1380
		private static readonly IntPtr NativeMethodInfoPtr_CloseConnection_Internal_Boolean_Connection_Int32_String_Boolean_0;

		// Token: 0x04000565 RID: 1381
		private static readonly IntPtr NativeMethodInfoPtr__CloseListenSocket_Private_Static_Boolean_IntPtr_Socket_0;

		// Token: 0x04000566 RID: 1382
		private static readonly IntPtr NativeMethodInfoPtr_CloseListenSocket_Internal_Boolean_Socket_0;

		// Token: 0x04000567 RID: 1383
		private static readonly IntPtr NativeMethodInfoPtr__SetConnectionUserData_Private_Static_Boolean_IntPtr_Connection_Int64_0;

		// Token: 0x04000568 RID: 1384
		private static readonly IntPtr NativeMethodInfoPtr_SetConnectionUserData_Internal_Boolean_Connection_Int64_0;

		// Token: 0x04000569 RID: 1385
		private static readonly IntPtr NativeMethodInfoPtr__GetConnectionUserData_Private_Static_Int64_IntPtr_Connection_0;

		// Token: 0x0400056A RID: 1386
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectionUserData_Internal_Int64_Connection_0;

		// Token: 0x0400056B RID: 1387
		private static readonly IntPtr NativeMethodInfoPtr__SetConnectionName_Private_Static_Void_IntPtr_Connection_String_0;

		// Token: 0x0400056C RID: 1388
		private static readonly IntPtr NativeMethodInfoPtr_SetConnectionName_Internal_Void_Connection_String_0;

		// Token: 0x0400056D RID: 1389
		private static readonly IntPtr NativeMethodInfoPtr__GetConnectionName_Private_Static_Boolean_IntPtr_Connection_IntPtr_Int32_0;

		// Token: 0x0400056E RID: 1390
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectionName_Internal_Boolean_Connection_byref_String_0;

		// Token: 0x0400056F RID: 1391
		private static readonly IntPtr NativeMethodInfoPtr__SendMessageToConnection_Private_Static_Result_IntPtr_Connection_IntPtr_UInt32_Int32_byref_Int64_0;

		// Token: 0x04000570 RID: 1392
		private static readonly IntPtr NativeMethodInfoPtr_SendMessageToConnection_Internal_Result_Connection_IntPtr_UInt32_Int32_byref_Int64_0;

		// Token: 0x04000571 RID: 1393
		private static readonly IntPtr NativeMethodInfoPtr__SendMessages_Private_Static_Void_IntPtr_Int32_ptr_ptr_NetMsg_ptr_Int64_0;

		// Token: 0x04000572 RID: 1394
		private static readonly IntPtr NativeMethodInfoPtr_SendMessages_Internal_Void_Int32_ptr_ptr_NetMsg_ptr_Int64_0;

		// Token: 0x04000573 RID: 1395
		private static readonly IntPtr NativeMethodInfoPtr__FlushMessagesOnConnection_Private_Static_Result_IntPtr_Connection_0;

		// Token: 0x04000574 RID: 1396
		private static readonly IntPtr NativeMethodInfoPtr_FlushMessagesOnConnection_Internal_Result_Connection_0;

		// Token: 0x04000575 RID: 1397
		private static readonly IntPtr NativeMethodInfoPtr__ReceiveMessagesOnConnection_Private_Static_Int32_IntPtr_Connection_IntPtr_Int32_0;

		// Token: 0x04000576 RID: 1398
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveMessagesOnConnection_Internal_Int32_Connection_IntPtr_Int32_0;

		// Token: 0x04000577 RID: 1399
		private static readonly IntPtr NativeMethodInfoPtr__GetConnectionInfo_Private_Static_Boolean_IntPtr_Connection_byref_ConnectionInfo_0;

		// Token: 0x04000578 RID: 1400
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectionInfo_Internal_Boolean_Connection_byref_ConnectionInfo_0;

		// Token: 0x04000579 RID: 1401
		private static readonly IntPtr NativeMethodInfoPtr__GetConnectionRealTimeStatus_Private_Static_Result_IntPtr_Connection_byref_ConnectionStatus_Int32_Il2CppReferenceArray_1_ConnectionLaneStatus_0;

		// Token: 0x0400057A RID: 1402
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectionRealTimeStatus_Internal_Result_Connection_byref_ConnectionStatus_Int32_Il2CppReferenceArray_1_ConnectionLaneStatus_0;

		// Token: 0x0400057B RID: 1403
		private static readonly IntPtr NativeMethodInfoPtr__GetDetailedConnectionStatus_Private_Static_Int32_IntPtr_Connection_IntPtr_Int32_0;

		// Token: 0x0400057C RID: 1404
		private static readonly IntPtr NativeMethodInfoPtr_GetDetailedConnectionStatus_Internal_Int32_Connection_byref_String_0;

		// Token: 0x0400057D RID: 1405
		private static readonly IntPtr NativeMethodInfoPtr__GetListenSocketAddress_Private_Static_Boolean_IntPtr_Socket_byref_NetAddress_0;

		// Token: 0x0400057E RID: 1406
		private static readonly IntPtr NativeMethodInfoPtr_GetListenSocketAddress_Internal_Boolean_Socket_byref_NetAddress_0;

		// Token: 0x0400057F RID: 1407
		private static readonly IntPtr NativeMethodInfoPtr__CreateSocketPair_Private_Static_Boolean_IntPtr_Il2CppStructArray_1_Connection_Il2CppStructArray_1_Connection_Boolean_byref_NetIdentity_byref_NetIdentity_0;

		// Token: 0x04000580 RID: 1408
		private static readonly IntPtr NativeMethodInfoPtr_CreateSocketPair_Internal_Boolean_Il2CppStructArray_1_Connection_Il2CppStructArray_1_Connection_Boolean_byref_NetIdentity_byref_NetIdentity_0;

		// Token: 0x04000581 RID: 1409
		private static readonly IntPtr NativeMethodInfoPtr__ConfigureConnectionLanes_Private_Static_Result_IntPtr_Connection_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt16_0;

		// Token: 0x04000582 RID: 1410
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureConnectionLanes_Internal_Result_Connection_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt16_0;

		// Token: 0x04000583 RID: 1411
		private static readonly IntPtr NativeMethodInfoPtr__GetIdentity_Private_Static_Boolean_IntPtr_byref_NetIdentity_0;

		// Token: 0x04000584 RID: 1412
		private static readonly IntPtr NativeMethodInfoPtr_GetIdentity_Internal_Boolean_byref_NetIdentity_0;

		// Token: 0x04000585 RID: 1413
		private static readonly IntPtr NativeMethodInfoPtr__InitAuthentication_Private_Static_SteamNetworkingAvailability_IntPtr_0;

		// Token: 0x04000586 RID: 1414
		private static readonly IntPtr NativeMethodInfoPtr_InitAuthentication_Internal_SteamNetworkingAvailability_0;

		// Token: 0x04000587 RID: 1415
		private static readonly IntPtr NativeMethodInfoPtr__GetAuthenticationStatus_Private_Static_SteamNetworkingAvailability_IntPtr_byref_SteamNetAuthenticationStatus_t_0;

		// Token: 0x04000588 RID: 1416
		private static readonly IntPtr NativeMethodInfoPtr_GetAuthenticationStatus_Internal_SteamNetworkingAvailability_byref_SteamNetAuthenticationStatus_t_0;

		// Token: 0x04000589 RID: 1417
		private static readonly IntPtr NativeMethodInfoPtr__CreatePollGroup_Private_Static_HSteamNetPollGroup_IntPtr_0;

		// Token: 0x0400058A RID: 1418
		private static readonly IntPtr NativeMethodInfoPtr_CreatePollGroup_Internal_HSteamNetPollGroup_0;

		// Token: 0x0400058B RID: 1419
		private static readonly IntPtr NativeMethodInfoPtr__DestroyPollGroup_Private_Static_Boolean_IntPtr_HSteamNetPollGroup_0;

		// Token: 0x0400058C RID: 1420
		private static readonly IntPtr NativeMethodInfoPtr_DestroyPollGroup_Internal_Boolean_HSteamNetPollGroup_0;

		// Token: 0x0400058D RID: 1421
		private static readonly IntPtr NativeMethodInfoPtr__SetConnectionPollGroup_Private_Static_Boolean_IntPtr_Connection_HSteamNetPollGroup_0;

		// Token: 0x0400058E RID: 1422
		private static readonly IntPtr NativeMethodInfoPtr_SetConnectionPollGroup_Internal_Boolean_Connection_HSteamNetPollGroup_0;

		// Token: 0x0400058F RID: 1423
		private static readonly IntPtr NativeMethodInfoPtr__ReceiveMessagesOnPollGroup_Private_Static_Int32_IntPtr_HSteamNetPollGroup_IntPtr_Int32_0;

		// Token: 0x04000590 RID: 1424
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveMessagesOnPollGroup_Internal_Int32_HSteamNetPollGroup_IntPtr_Int32_0;

		// Token: 0x04000591 RID: 1425
		private static readonly IntPtr NativeMethodInfoPtr__ReceivedRelayAuthTicket_Private_Static_Boolean_IntPtr_IntPtr_Int32_Il2CppStructArray_1_SteamDatagramRelayAuthTicket_0;

		// Token: 0x04000592 RID: 1426
		private static readonly IntPtr NativeMethodInfoPtr_ReceivedRelayAuthTicket_Internal_Boolean_IntPtr_Int32_Il2CppStructArray_1_SteamDatagramRelayAuthTicket_0;

		// Token: 0x04000593 RID: 1427
		private static readonly IntPtr NativeMethodInfoPtr__FindRelayAuthTicketForServer_Private_Static_Int32_IntPtr_byref_NetIdentity_Int32_Il2CppStructArray_1_SteamDatagramRelayAuthTicket_0;

		// Token: 0x04000594 RID: 1428
		private static readonly IntPtr NativeMethodInfoPtr_FindRelayAuthTicketForServer_Internal_Int32_byref_NetIdentity_Int32_Il2CppStructArray_1_SteamDatagramRelayAuthTicket_0;

		// Token: 0x04000595 RID: 1429
		private static readonly IntPtr NativeMethodInfoPtr__ConnectToHostedDedicatedServer_Private_Static_Connection_IntPtr_byref_NetIdentity_Int32_Int32_Il2CppStructArray_1_NetKeyValue_0;

		// Token: 0x04000596 RID: 1430
		private static readonly IntPtr NativeMethodInfoPtr_ConnectToHostedDedicatedServer_Internal_Connection_byref_NetIdentity_Int32_Int32_Il2CppStructArray_1_NetKeyValue_0;

		// Token: 0x04000597 RID: 1431
		private static readonly IntPtr NativeMethodInfoPtr__GetHostedDedicatedServerPort_Private_Static_UInt16_IntPtr_0;

		// Token: 0x04000598 RID: 1432
		private static readonly IntPtr NativeMethodInfoPtr_GetHostedDedicatedServerPort_Internal_UInt16_0;

		// Token: 0x04000599 RID: 1433
		private static readonly IntPtr NativeMethodInfoPtr__GetHostedDedicatedServerPOPID_Private_Static_SteamNetworkingPOPID_IntPtr_0;

		// Token: 0x0400059A RID: 1434
		private static readonly IntPtr NativeMethodInfoPtr_GetHostedDedicatedServerPOPID_Internal_SteamNetworkingPOPID_0;

		// Token: 0x0400059B RID: 1435
		private static readonly IntPtr NativeMethodInfoPtr__GetHostedDedicatedServerAddress_Private_Static_Result_IntPtr_byref_SteamDatagramHostedAddress_0;

		// Token: 0x0400059C RID: 1436
		private static readonly IntPtr NativeMethodInfoPtr_GetHostedDedicatedServerAddress_Internal_Result_byref_SteamDatagramHostedAddress_0;

		// Token: 0x0400059D RID: 1437
		private static readonly IntPtr NativeMethodInfoPtr__CreateHostedDedicatedServerListenSocket_Private_Static_Socket_IntPtr_Int32_Int32_Il2CppStructArray_1_NetKeyValue_0;

		// Token: 0x0400059E RID: 1438
		private static readonly IntPtr NativeMethodInfoPtr_CreateHostedDedicatedServerListenSocket_Internal_Socket_Int32_Int32_Il2CppStructArray_1_NetKeyValue_0;

		// Token: 0x0400059F RID: 1439
		private static readonly IntPtr NativeMethodInfoPtr__GetGameCoordinatorServerLogin_Private_Static_Result_IntPtr_byref_SteamDatagramGameCoordinatorServerLogin_byref_Int32_IntPtr_0;

		// Token: 0x040005A0 RID: 1440
		private static readonly IntPtr NativeMethodInfoPtr_GetGameCoordinatorServerLogin_Internal_Result_byref_SteamDatagramGameCoordinatorServerLogin_byref_Int32_IntPtr_0;

		// Token: 0x040005A1 RID: 1441
		private static readonly IntPtr NativeMethodInfoPtr__ConnectP2PCustomSignaling_Private_Static_Connection_IntPtr_IntPtr_byref_NetIdentity_Int32_Int32_Il2CppStructArray_1_NetKeyValue_0;

		// Token: 0x040005A2 RID: 1442
		private static readonly IntPtr NativeMethodInfoPtr_ConnectP2PCustomSignaling_Internal_Connection_IntPtr_byref_NetIdentity_Int32_Int32_Il2CppStructArray_1_NetKeyValue_0;

		// Token: 0x040005A3 RID: 1443
		private static readonly IntPtr NativeMethodInfoPtr__ReceivedP2PCustomSignal_Private_Static_Boolean_IntPtr_IntPtr_Int32_IntPtr_0;

		// Token: 0x040005A4 RID: 1444
		private static readonly IntPtr NativeMethodInfoPtr_ReceivedP2PCustomSignal_Internal_Boolean_IntPtr_Int32_IntPtr_0;

		// Token: 0x040005A5 RID: 1445
		private static readonly IntPtr NativeMethodInfoPtr__GetCertificateRequest_Private_Static_Boolean_IntPtr_byref_Int32_IntPtr_byref_NetErrorMessage_0;

		// Token: 0x040005A6 RID: 1446
		private static readonly IntPtr NativeMethodInfoPtr_GetCertificateRequest_Internal_Boolean_byref_Int32_IntPtr_byref_NetErrorMessage_0;

		// Token: 0x040005A7 RID: 1447
		private static readonly IntPtr NativeMethodInfoPtr__SetCertificate_Private_Static_Boolean_IntPtr_IntPtr_Int32_byref_NetErrorMessage_0;

		// Token: 0x040005A8 RID: 1448
		private static readonly IntPtr NativeMethodInfoPtr_SetCertificate_Internal_Boolean_IntPtr_Int32_byref_NetErrorMessage_0;

		// Token: 0x040005A9 RID: 1449
		private static readonly IntPtr NativeMethodInfoPtr__ResetIdentity_Private_Static_Void_IntPtr_byref_NetIdentity_0;

		// Token: 0x040005AA RID: 1450
		private static readonly IntPtr NativeMethodInfoPtr_ResetIdentity_Internal_Void_byref_NetIdentity_0;

		// Token: 0x040005AB RID: 1451
		private static readonly IntPtr NativeMethodInfoPtr__RunCallbacks_Private_Static_Void_IntPtr_0;

		// Token: 0x040005AC RID: 1452
		private static readonly IntPtr NativeMethodInfoPtr_RunCallbacks_Internal_Void_0;

		// Token: 0x040005AD RID: 1453
		private static readonly IntPtr NativeMethodInfoPtr__BeginAsyncRequestFakeIP_Private_Static_Boolean_IntPtr_Int32_0;

		// Token: 0x040005AE RID: 1454
		private static readonly IntPtr NativeMethodInfoPtr_BeginAsyncRequestFakeIP_Internal_Boolean_Int32_0;

		// Token: 0x040005AF RID: 1455
		private static readonly IntPtr NativeMethodInfoPtr__GetFakeIP_Private_Static_Void_IntPtr_Int32_byref_SteamNetworkingFakeIPResult_t_0;

		// Token: 0x040005B0 RID: 1456
		private static readonly IntPtr NativeMethodInfoPtr_GetFakeIP_Internal_Void_Int32_byref_SteamNetworkingFakeIPResult_t_0;

		// Token: 0x040005B1 RID: 1457
		private static readonly IntPtr NativeMethodInfoPtr__CreateListenSocketP2PFakeIP_Private_Static_Socket_IntPtr_Int32_Int32_Il2CppStructArray_1_NetKeyValue_0;

		// Token: 0x040005B2 RID: 1458
		private static readonly IntPtr NativeMethodInfoPtr_CreateListenSocketP2PFakeIP_Internal_Socket_Int32_Int32_Il2CppStructArray_1_NetKeyValue_0;

		// Token: 0x040005B3 RID: 1459
		private static readonly IntPtr NativeMethodInfoPtr__GetRemoteFakeIPForConnection_Private_Static_Result_IntPtr_Connection_Il2CppStructArray_1_NetAddress_0;

		// Token: 0x040005B4 RID: 1460
		private static readonly IntPtr NativeMethodInfoPtr_GetRemoteFakeIPForConnection_Internal_Result_Connection_Il2CppStructArray_1_NetAddress_0;

		// Token: 0x040005B5 RID: 1461
		private static readonly IntPtr NativeMethodInfoPtr__CreateFakeUDPPort_Private_Static_IntPtr_IntPtr_Int32_0;

		// Token: 0x040005B6 RID: 1462
		private static readonly IntPtr NativeMethodInfoPtr_CreateFakeUDPPort_Internal_IntPtr_Int32_0;
	}
}
