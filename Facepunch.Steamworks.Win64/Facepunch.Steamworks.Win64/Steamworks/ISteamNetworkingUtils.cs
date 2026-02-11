using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x02000025 RID: 37
	public class ISteamNetworkingUtils : SteamInterface
	{
		// Token: 0x06000538 RID: 1336 RVA: 0x0002EEB0 File Offset: 0x0002D0B0
		// Note: this type is marked as 'beforefieldinit'.
		static ISteamNetworkingUtils()
		{
			Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "ISteamNetworkingUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr);
			ISteamNetworkingUtils.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664561);
			ISteamNetworkingUtils.NativeMethodInfoPtr_SteamAPI_SteamNetworkingUtils_SteamAPI_v004_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664562);
			ISteamNetworkingUtils.NativeMethodInfoPtr_GetGlobalInterfacePointer_Public_Virtual_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664563);
			ISteamNetworkingUtils.NativeMethodInfoPtr__AllocateMessage_Private_Static_ptr_NetMsg_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664564);
			ISteamNetworkingUtils.NativeMethodInfoPtr_AllocateMessage_Internal_ptr_NetMsg_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664565);
			ISteamNetworkingUtils.NativeMethodInfoPtr__InitRelayNetworkAccess_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664566);
			ISteamNetworkingUtils.NativeMethodInfoPtr_InitRelayNetworkAccess_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664567);
			ISteamNetworkingUtils.NativeMethodInfoPtr__GetRelayNetworkStatus_Private_Static_SteamNetworkingAvailability_IntPtr_byref_SteamRelayNetworkStatus_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664568);
			ISteamNetworkingUtils.NativeMethodInfoPtr_GetRelayNetworkStatus_Internal_SteamNetworkingAvailability_byref_SteamRelayNetworkStatus_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664569);
			ISteamNetworkingUtils.NativeMethodInfoPtr__GetLocalPingLocation_Private_Static_Single_IntPtr_byref_NetPingLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664570);
			ISteamNetworkingUtils.NativeMethodInfoPtr_GetLocalPingLocation_Internal_Single_byref_NetPingLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664571);
			ISteamNetworkingUtils.NativeMethodInfoPtr__EstimatePingTimeBetweenTwoLocations_Private_Static_Int32_IntPtr_byref_NetPingLocation_byref_NetPingLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664572);
			ISteamNetworkingUtils.NativeMethodInfoPtr_EstimatePingTimeBetweenTwoLocations_Internal_Int32_byref_NetPingLocation_byref_NetPingLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664573);
			ISteamNetworkingUtils.NativeMethodInfoPtr__EstimatePingTimeFromLocalHost_Private_Static_Int32_IntPtr_byref_NetPingLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664574);
			ISteamNetworkingUtils.NativeMethodInfoPtr_EstimatePingTimeFromLocalHost_Internal_Int32_byref_NetPingLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664575);
			ISteamNetworkingUtils.NativeMethodInfoPtr__ConvertPingLocationToString_Private_Static_Void_IntPtr_byref_NetPingLocation_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664576);
			ISteamNetworkingUtils.NativeMethodInfoPtr_ConvertPingLocationToString_Internal_Void_byref_NetPingLocation_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664577);
			ISteamNetworkingUtils.NativeMethodInfoPtr__ParsePingLocationString_Private_Static_Boolean_IntPtr_String_byref_NetPingLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664578);
			ISteamNetworkingUtils.NativeMethodInfoPtr_ParsePingLocationString_Internal_Boolean_String_byref_NetPingLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664579);
			ISteamNetworkingUtils.NativeMethodInfoPtr__CheckPingDataUpToDate_Private_Static_Boolean_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664580);
			ISteamNetworkingUtils.NativeMethodInfoPtr_CheckPingDataUpToDate_Internal_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664581);
			ISteamNetworkingUtils.NativeMethodInfoPtr__GetPingToDataCenter_Private_Static_Int32_IntPtr_SteamNetworkingPOPID_byref_SteamNetworkingPOPID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664582);
			ISteamNetworkingUtils.NativeMethodInfoPtr_GetPingToDataCenter_Internal_Int32_SteamNetworkingPOPID_byref_SteamNetworkingPOPID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664583);
			ISteamNetworkingUtils.NativeMethodInfoPtr__GetDirectPingToPOP_Private_Static_Int32_IntPtr_SteamNetworkingPOPID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664584);
			ISteamNetworkingUtils.NativeMethodInfoPtr_GetDirectPingToPOP_Internal_Int32_SteamNetworkingPOPID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664585);
			ISteamNetworkingUtils.NativeMethodInfoPtr__GetPOPCount_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664586);
			ISteamNetworkingUtils.NativeMethodInfoPtr_GetPOPCount_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664587);
			ISteamNetworkingUtils.NativeMethodInfoPtr__GetPOPList_Private_Static_Int32_IntPtr_byref_SteamNetworkingPOPID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664588);
			ISteamNetworkingUtils.NativeMethodInfoPtr_GetPOPList_Internal_Int32_byref_SteamNetworkingPOPID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664589);
			ISteamNetworkingUtils.NativeMethodInfoPtr__GetLocalTimestamp_Private_Static_Int64_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664590);
			ISteamNetworkingUtils.NativeMethodInfoPtr_GetLocalTimestamp_Internal_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664591);
			ISteamNetworkingUtils.NativeMethodInfoPtr__SetDebugOutputFunction_Private_Static_Void_IntPtr_NetDebugOutput_NetDebugFunc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664592);
			ISteamNetworkingUtils.NativeMethodInfoPtr_SetDebugOutputFunction_Internal_Void_NetDebugOutput_NetDebugFunc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664593);
			ISteamNetworkingUtils.NativeMethodInfoPtr__IsFakeIPv4_Private_Static_Boolean_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664594);
			ISteamNetworkingUtils.NativeMethodInfoPtr_IsFakeIPv4_Internal_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664595);
			ISteamNetworkingUtils.NativeMethodInfoPtr__GetIPv4FakeIPType_Private_Static_SteamNetworkingFakeIPType_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664596);
			ISteamNetworkingUtils.NativeMethodInfoPtr_GetIPv4FakeIPType_Internal_SteamNetworkingFakeIPType_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664597);
			ISteamNetworkingUtils.NativeMethodInfoPtr__GetRealIdentityForFakeIP_Private_Static_Result_IntPtr_byref_NetAddress_Il2CppStructArray_1_NetIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664598);
			ISteamNetworkingUtils.NativeMethodInfoPtr_GetRealIdentityForFakeIP_Internal_Result_byref_NetAddress_Il2CppStructArray_1_NetIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664599);
			ISteamNetworkingUtils.NativeMethodInfoPtr__SetGlobalConfigValueInt32_Private_Static_Boolean_IntPtr_NetConfig_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664600);
			ISteamNetworkingUtils.NativeMethodInfoPtr_SetGlobalConfigValueInt32_Internal_Boolean_NetConfig_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664601);
			ISteamNetworkingUtils.NativeMethodInfoPtr__SetGlobalConfigValueFloat_Private_Static_Boolean_IntPtr_NetConfig_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664602);
			ISteamNetworkingUtils.NativeMethodInfoPtr_SetGlobalConfigValueFloat_Internal_Boolean_NetConfig_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664603);
			ISteamNetworkingUtils.NativeMethodInfoPtr__SetGlobalConfigValueString_Private_Static_Boolean_IntPtr_NetConfig_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664604);
			ISteamNetworkingUtils.NativeMethodInfoPtr_SetGlobalConfigValueString_Internal_Boolean_NetConfig_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664605);
			ISteamNetworkingUtils.NativeMethodInfoPtr__SetGlobalConfigValuePtr_Private_Static_Boolean_IntPtr_NetConfig_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664606);
			ISteamNetworkingUtils.NativeMethodInfoPtr_SetGlobalConfigValuePtr_Internal_Boolean_NetConfig_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664607);
			ISteamNetworkingUtils.NativeMethodInfoPtr__SetConnectionConfigValueInt32_Private_Static_Boolean_IntPtr_Connection_NetConfig_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664608);
			ISteamNetworkingUtils.NativeMethodInfoPtr_SetConnectionConfigValueInt32_Internal_Boolean_Connection_NetConfig_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664609);
			ISteamNetworkingUtils.NativeMethodInfoPtr__SetConnectionConfigValueFloat_Private_Static_Boolean_IntPtr_Connection_NetConfig_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664610);
			ISteamNetworkingUtils.NativeMethodInfoPtr_SetConnectionConfigValueFloat_Internal_Boolean_Connection_NetConfig_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664611);
			ISteamNetworkingUtils.NativeMethodInfoPtr__SetConnectionConfigValueString_Private_Static_Boolean_IntPtr_Connection_NetConfig_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664612);
			ISteamNetworkingUtils.NativeMethodInfoPtr_SetConnectionConfigValueString_Internal_Boolean_Connection_NetConfig_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664613);
			ISteamNetworkingUtils.NativeMethodInfoPtr__SetGlobalCallback_SteamNetConnectionStatusChanged_Private_Static_Boolean_IntPtr_FnSteamNetConnectionStatusChanged_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664614);
			ISteamNetworkingUtils.NativeMethodInfoPtr_SetGlobalCallback_SteamNetConnectionStatusChanged_Internal_Boolean_FnSteamNetConnectionStatusChanged_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664615);
			ISteamNetworkingUtils.NativeMethodInfoPtr__SetGlobalCallback_SteamNetAuthenticationStatusChanged_Private_Static_Boolean_IntPtr_FnSteamNetAuthenticationStatusChanged_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664616);
			ISteamNetworkingUtils.NativeMethodInfoPtr_SetGlobalCallback_SteamNetAuthenticationStatusChanged_Internal_Boolean_FnSteamNetAuthenticationStatusChanged_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664617);
			ISteamNetworkingUtils.NativeMethodInfoPtr__SetGlobalCallback_SteamRelayNetworkStatusChanged_Private_Static_Boolean_IntPtr_FnSteamRelayNetworkStatusChanged_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664618);
			ISteamNetworkingUtils.NativeMethodInfoPtr_SetGlobalCallback_SteamRelayNetworkStatusChanged_Internal_Boolean_FnSteamRelayNetworkStatusChanged_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664619);
			ISteamNetworkingUtils.NativeMethodInfoPtr__SetGlobalCallback_FakeIPResult_Private_Static_Boolean_IntPtr_FnSteamNetworkingFakeIPResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664620);
			ISteamNetworkingUtils.NativeMethodInfoPtr_SetGlobalCallback_FakeIPResult_Internal_Boolean_FnSteamNetworkingFakeIPResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664621);
			ISteamNetworkingUtils.NativeMethodInfoPtr__SetGlobalCallback_MessagesSessionRequest_Private_Static_Boolean_IntPtr_FnSteamNetworkingMessagesSessionRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664622);
			ISteamNetworkingUtils.NativeMethodInfoPtr_SetGlobalCallback_MessagesSessionRequest_Internal_Boolean_FnSteamNetworkingMessagesSessionRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664623);
			ISteamNetworkingUtils.NativeMethodInfoPtr__SetGlobalCallback_MessagesSessionFailed_Private_Static_Boolean_IntPtr_FnSteamNetworkingMessagesSessionFailed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664624);
			ISteamNetworkingUtils.NativeMethodInfoPtr_SetGlobalCallback_MessagesSessionFailed_Internal_Boolean_FnSteamNetworkingMessagesSessionFailed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664625);
			ISteamNetworkingUtils.NativeMethodInfoPtr__SetConfigValue_Private_Static_Boolean_IntPtr_NetConfig_NetConfigScope_IntPtr_NetConfigType_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664626);
			ISteamNetworkingUtils.NativeMethodInfoPtr_SetConfigValue_Internal_Boolean_NetConfig_NetConfigScope_IntPtr_NetConfigType_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664627);
			ISteamNetworkingUtils.NativeMethodInfoPtr__SetConfigValueStruct_Private_Static_Boolean_IntPtr_byref_NetKeyValue_NetConfigScope_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664628);
			ISteamNetworkingUtils.NativeMethodInfoPtr_SetConfigValueStruct_Internal_Boolean_byref_NetKeyValue_NetConfigScope_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664629);
			ISteamNetworkingUtils.NativeMethodInfoPtr__GetConfigValue_Private_Static_NetConfigResult_IntPtr_NetConfig_NetConfigScope_IntPtr_byref_NetConfigType_IntPtr_byref_UIntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664630);
			ISteamNetworkingUtils.NativeMethodInfoPtr_GetConfigValue_Internal_NetConfigResult_NetConfig_NetConfigScope_IntPtr_byref_NetConfigType_IntPtr_byref_UIntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664631);
			ISteamNetworkingUtils.NativeMethodInfoPtr__GetConfigValueInfo_Private_Static_Utf8StringPointer_IntPtr_NetConfig_byref_NetConfigType_Il2CppStructArray_1_NetConfigScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664632);
			ISteamNetworkingUtils.NativeMethodInfoPtr_GetConfigValueInfo_Internal_String_NetConfig_byref_NetConfigType_Il2CppStructArray_1_NetConfigScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664633);
			ISteamNetworkingUtils.NativeMethodInfoPtr__IterateGenericEditableConfigValues_Private_Static_NetConfig_IntPtr_NetConfig_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664634);
			ISteamNetworkingUtils.NativeMethodInfoPtr_IterateGenericEditableConfigValues_Internal_NetConfig_NetConfig_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664635);
			ISteamNetworkingUtils.NativeMethodInfoPtr__SteamNetworkingIPAddr_ToString_Private_Static_Void_IntPtr_byref_NetAddress_IntPtr_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664636);
			ISteamNetworkingUtils.NativeMethodInfoPtr_SteamNetworkingIPAddr_ToString_Internal_Void_byref_NetAddress_byref_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664637);
			ISteamNetworkingUtils.NativeMethodInfoPtr__SteamNetworkingIPAddr_ParseString_Private_Static_Boolean_IntPtr_byref_NetAddress_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664638);
			ISteamNetworkingUtils.NativeMethodInfoPtr_SteamNetworkingIPAddr_ParseString_Internal_Boolean_byref_NetAddress_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664639);
			ISteamNetworkingUtils.NativeMethodInfoPtr__SteamNetworkingIPAddr_GetFakeIPType_Private_Static_SteamNetworkingFakeIPType_IntPtr_byref_NetAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664640);
			ISteamNetworkingUtils.NativeMethodInfoPtr_SteamNetworkingIPAddr_GetFakeIPType_Internal_SteamNetworkingFakeIPType_byref_NetAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664641);
			ISteamNetworkingUtils.NativeMethodInfoPtr__SteamNetworkingIdentity_ToString_Private_Static_Void_IntPtr_byref_NetIdentity_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664642);
			ISteamNetworkingUtils.NativeMethodInfoPtr_SteamNetworkingIdentity_ToString_Internal_Void_byref_NetIdentity_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664643);
			ISteamNetworkingUtils.NativeMethodInfoPtr__SteamNetworkingIdentity_ParseString_Private_Static_Boolean_IntPtr_byref_NetIdentity_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664644);
			ISteamNetworkingUtils.NativeMethodInfoPtr_SteamNetworkingIdentity_ParseString_Internal_Boolean_byref_NetIdentity_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr, 100664645);
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x0002F584 File Offset: 0x0002D784
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 930944, RefRangeEnd = 930966, XrefRangeStart = 930944, XrefRangeEnd = 930966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISteamNetworkingUtils(bool IsGameServer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamNetworkingUtils>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref IsGameServer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x0002F5CC File Offset: 0x0002D7CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934402, XrefRangeEnd = 934404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr SteamAPI_SteamNetworkingUtils_SteamAPI_v004()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr_SteamAPI_SteamNetworkingUtils_SteamAPI_v004_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x0002F5FC File Offset: 0x0002D7FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IntPtr GetGlobalInterfacePointer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamNetworkingUtils.NativeMethodInfoPtr_GetGlobalInterfacePointer_Public_Virtual_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x0002F644 File Offset: 0x0002D844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934404, XrefRangeEnd = 934406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NetMsg* _AllocateMessage(IntPtr self, int cbAllocateBuffer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbAllocateBuffer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr__AllocateMessage_Private_Static_ptr_NetMsg_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x0002F688 File Offset: 0x0002D888
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 934408, RefRangeEnd = 934410, XrefRangeStart = 934406, XrefRangeEnd = 934408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NetMsg* AllocateMessage(int cbAllocateBuffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cbAllocateBuffer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr_AllocateMessage_Internal_ptr_NetMsg_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x0002F6C8 File Offset: 0x0002D8C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934410, XrefRangeEnd = 934412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _InitRelayNetworkAccess(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr__InitRelayNetworkAccess_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x0002F6FC File Offset: 0x0002D8FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934414, RefRangeEnd = 934415, XrefRangeStart = 934412, XrefRangeEnd = 934414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitRelayNetworkAccess()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr_InitRelayNetworkAccess_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x0002F730 File Offset: 0x0002D930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934415, XrefRangeEnd = 934421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamNetworkingAvailability _GetRelayNetworkStatus(IntPtr self, ref SteamRelayNetworkStatus_t pDetails)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(pDetails);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr__GetRelayNetworkStatus_Private_Static_SteamNetworkingAvailability_IntPtr_byref_SteamRelayNetworkStatus_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x0002F780 File Offset: 0x0002D980
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934427, RefRangeEnd = 934428, XrefRangeStart = 934421, XrefRangeEnd = 934427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamNetworkingAvailability GetRelayNetworkStatus(ref SteamRelayNetworkStatus_t pDetails)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(pDetails);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr_GetRelayNetworkStatus_Internal_SteamNetworkingAvailability_byref_SteamRelayNetworkStatus_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x0002F7D0 File Offset: 0x0002D9D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934428, XrefRangeEnd = 934430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float _GetLocalPingLocation(IntPtr self, ref NetPingLocation result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr__GetLocalPingLocation_Private_Static_Single_IntPtr_byref_NetPingLocation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x0002F81C File Offset: 0x0002DA1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934432, RefRangeEnd = 934433, XrefRangeStart = 934430, XrefRangeEnd = 934432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetLocalPingLocation(ref NetPingLocation result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr_GetLocalPingLocation_Internal_Single_byref_NetPingLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x0002F868 File Offset: 0x0002DA68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934433, XrefRangeEnd = 934435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _EstimatePingTimeBetweenTwoLocations(IntPtr self, ref NetPingLocation location1, ref NetPingLocation location2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &location1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &location2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr__EstimatePingTimeBetweenTwoLocations_Private_Static_Int32_IntPtr_byref_NetPingLocation_byref_NetPingLocation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x0002F8C4 File Offset: 0x0002DAC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934437, RefRangeEnd = 934438, XrefRangeStart = 934435, XrefRangeEnd = 934437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int EstimatePingTimeBetweenTwoLocations(ref NetPingLocation location1, ref NetPingLocation location2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &location2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr_EstimatePingTimeBetweenTwoLocations_Internal_Int32_byref_NetPingLocation_byref_NetPingLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x0002F91C File Offset: 0x0002DB1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934438, XrefRangeEnd = 934440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _EstimatePingTimeFromLocalHost(IntPtr self, ref NetPingLocation remoteLocation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &remoteLocation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr__EstimatePingTimeFromLocalHost_Private_Static_Int32_IntPtr_byref_NetPingLocation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x0002F968 File Offset: 0x0002DB68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934442, RefRangeEnd = 934443, XrefRangeStart = 934440, XrefRangeEnd = 934442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int EstimatePingTimeFromLocalHost(ref NetPingLocation remoteLocation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &remoteLocation;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr_EstimatePingTimeFromLocalHost_Internal_Int32_byref_NetPingLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x0002F9B4 File Offset: 0x0002DBB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934443, XrefRangeEnd = 934445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _ConvertPingLocationToString(IntPtr self, ref NetPingLocation location, IntPtr pszBuf, int cchBufSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &location;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pszBuf;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cchBufSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr__ConvertPingLocationToString_Private_Static_Void_IntPtr_byref_NetPingLocation_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x0002FA10 File Offset: 0x0002DC10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934467, RefRangeEnd = 934468, XrefRangeStart = 934445, XrefRangeEnd = 934467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConvertPingLocationToString(ref NetPingLocation location, out string pszBuf)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr_ConvertPingLocationToString_Internal_Void_byref_NetPingLocation_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pszBuf = IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x0002FA68 File Offset: 0x0002DC68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934468, XrefRangeEnd = 934471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _ParsePingLocationString(IntPtr self, string pszString, ref NetPingLocation result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pszString);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr__ParsePingLocationString_Private_Static_Boolean_IntPtr_String_byref_NetPingLocation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x0002FAC8 File Offset: 0x0002DCC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934474, RefRangeEnd = 934475, XrefRangeStart = 934471, XrefRangeEnd = 934474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParsePingLocationString(string pszString, ref NetPingLocation result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pszString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr_ParsePingLocationString_Internal_Boolean_String_byref_NetPingLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x0002FB24 File Offset: 0x0002DD24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934475, XrefRangeEnd = 934477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _CheckPingDataUpToDate(IntPtr self, float flMaxAgeSeconds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flMaxAgeSeconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr__CheckPingDataUpToDate_Private_Static_Boolean_IntPtr_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x0002FB70 File Offset: 0x0002DD70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934479, RefRangeEnd = 934480, XrefRangeStart = 934477, XrefRangeEnd = 934479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckPingDataUpToDate(float flMaxAgeSeconds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flMaxAgeSeconds;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr_CheckPingDataUpToDate_Internal_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x0002FBBC File Offset: 0x0002DDBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934480, XrefRangeEnd = 934482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetPingToDataCenter(IntPtr self, SteamNetworkingPOPID popID, ref SteamNetworkingPOPID pViaRelayPoP)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref popID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pViaRelayPoP;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr__GetPingToDataCenter_Private_Static_Int32_IntPtr_SteamNetworkingPOPID_byref_SteamNetworkingPOPID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x0002FC18 File Offset: 0x0002DE18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934482, XrefRangeEnd = 934484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPingToDataCenter(SteamNetworkingPOPID popID, ref SteamNetworkingPOPID pViaRelayPoP)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref popID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pViaRelayPoP;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr_GetPingToDataCenter_Internal_Int32_SteamNetworkingPOPID_byref_SteamNetworkingPOPID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x0002FC70 File Offset: 0x0002DE70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934484, XrefRangeEnd = 934486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetDirectPingToPOP(IntPtr self, SteamNetworkingPOPID popID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref popID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr__GetDirectPingToPOP_Private_Static_Int32_IntPtr_SteamNetworkingPOPID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x0002FCBC File Offset: 0x0002DEBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934486, XrefRangeEnd = 934488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetDirectPingToPOP(SteamNetworkingPOPID popID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref popID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr_GetDirectPingToPOP_Internal_Int32_SteamNetworkingPOPID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x0002FD08 File Offset: 0x0002DF08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934488, XrefRangeEnd = 934490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetPOPCount(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr__GetPOPCount_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x0002FD48 File Offset: 0x0002DF48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934490, XrefRangeEnd = 934492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPOPCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr_GetPOPCount_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x0002FD84 File Offset: 0x0002DF84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934492, XrefRangeEnd = 934494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetPOPList(IntPtr self, ref SteamNetworkingPOPID list, int nListSz)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &list;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nListSz;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr__GetPOPList_Private_Static_Int32_IntPtr_byref_SteamNetworkingPOPID_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x0002FDE0 File Offset: 0x0002DFE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934494, XrefRangeEnd = 934496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPOPList(ref SteamNetworkingPOPID list, int nListSz)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &list;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nListSz;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr_GetPOPList_Internal_Int32_byref_SteamNetworkingPOPID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x0002FE38 File Offset: 0x0002E038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934496, XrefRangeEnd = 934498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long _GetLocalTimestamp(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr__GetLocalTimestamp_Private_Static_Int64_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x0002FE78 File Offset: 0x0002E078
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934500, RefRangeEnd = 934501, XrefRangeStart = 934498, XrefRangeEnd = 934500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long GetLocalTimestamp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr_GetLocalTimestamp_Internal_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x0002FEB4 File Offset: 0x0002E0B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934501, XrefRangeEnd = 934503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SetDebugOutputFunction(IntPtr self, NetDebugOutput eDetailLevel, NetDebugFunc pfnFunc)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eDetailLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pfnFunc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr__SetDebugOutputFunction_Private_Static_Void_IntPtr_NetDebugOutput_NetDebugFunc_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x0002FF08 File Offset: 0x0002E108
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934505, RefRangeEnd = 934506, XrefRangeStart = 934503, XrefRangeEnd = 934505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDebugOutputFunction(NetDebugOutput eDetailLevel, NetDebugFunc pfnFunc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eDetailLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pfnFunc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr_SetDebugOutputFunction_Internal_Void_NetDebugOutput_NetDebugFunc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x0002FF58 File Offset: 0x0002E158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934506, XrefRangeEnd = 934508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _IsFakeIPv4(IntPtr self, uint nIPv4)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nIPv4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr__IsFakeIPv4_Private_Static_Boolean_IntPtr_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x0002FFA4 File Offset: 0x0002E1A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934510, RefRangeEnd = 934511, XrefRangeStart = 934508, XrefRangeEnd = 934510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsFakeIPv4(uint nIPv4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nIPv4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr_IsFakeIPv4_Internal_Boolean_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x0002FFF0 File Offset: 0x0002E1F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934511, XrefRangeEnd = 934513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamNetworkingFakeIPType _GetIPv4FakeIPType(IntPtr self, uint nIPv4)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nIPv4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr__GetIPv4FakeIPType_Private_Static_SteamNetworkingFakeIPType_IntPtr_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x0003003C File Offset: 0x0002E23C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934513, XrefRangeEnd = 934515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamNetworkingFakeIPType GetIPv4FakeIPType(uint nIPv4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nIPv4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr_GetIPv4FakeIPType_Internal_SteamNetworkingFakeIPType_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00030088 File Offset: 0x0002E288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934515, XrefRangeEnd = 934517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Result _GetRealIdentityForFakeIP(IntPtr self, ref NetAddress fakeIP, [In] [Out] Il2CppStructArray<NetIdentity> pOutRealIdentity)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &fakeIP;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr__GetRealIdentityForFakeIP_Private_Static_Result_IntPtr_byref_NetAddress_Il2CppStructArray_1_NetIdentity_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pOutRealIdentity = ((intPtr4 == 0) ? null : new Il2CppStructArray<NetIdentity>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x000300F8 File Offset: 0x0002E2F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934517, XrefRangeEnd = 934519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Result GetRealIdentityForFakeIP(ref NetAddress fakeIP, [In] [Out] Il2CppStructArray<NetIdentity> pOutRealIdentity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &fakeIP;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr_GetRealIdentityForFakeIP_Internal_Result_byref_NetAddress_Il2CppStructArray_1_NetIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pOutRealIdentity = ((intPtr4 == 0) ? null : new Il2CppStructArray<NetIdentity>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00030164 File Offset: 0x0002E364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934519, XrefRangeEnd = 934521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetGlobalConfigValueInt32(IntPtr self, NetConfig eValue, int val)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr__SetGlobalConfigValueInt32_Private_Static_Boolean_IntPtr_NetConfig_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x000301C0 File Offset: 0x0002E3C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934521, XrefRangeEnd = 934523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetGlobalConfigValueInt32(NetConfig eValue, int val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr_SetGlobalConfigValueInt32_Internal_Boolean_NetConfig_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00030218 File Offset: 0x0002E418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934523, XrefRangeEnd = 934525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetGlobalConfigValueFloat(IntPtr self, NetConfig eValue, float val)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr__SetGlobalConfigValueFloat_Private_Static_Boolean_IntPtr_NetConfig_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00030274 File Offset: 0x0002E474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934525, XrefRangeEnd = 934527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetGlobalConfigValueFloat(NetConfig eValue, float val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr_SetGlobalConfigValueFloat_Internal_Boolean_NetConfig_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x000302CC File Offset: 0x0002E4CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934527, XrefRangeEnd = 934530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetGlobalConfigValueString(IntPtr self, NetConfig eValue, string val)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(val);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr__SetGlobalConfigValueString_Private_Static_Boolean_IntPtr_NetConfig_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x0003032C File Offset: 0x0002E52C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934530, XrefRangeEnd = 934533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetGlobalConfigValueString(NetConfig eValue, string val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(val);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr_SetGlobalConfigValueString_Internal_Boolean_NetConfig_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00030388 File Offset: 0x0002E588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934533, XrefRangeEnd = 934535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetGlobalConfigValuePtr(IntPtr self, NetConfig eValue, IntPtr val)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr__SetGlobalConfigValuePtr_Private_Static_Boolean_IntPtr_NetConfig_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x000303E4 File Offset: 0x0002E5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934535, XrefRangeEnd = 934537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetGlobalConfigValuePtr(NetConfig eValue, IntPtr val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr_SetGlobalConfigValuePtr_Internal_Boolean_NetConfig_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x0003043C File Offset: 0x0002E63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934537, XrefRangeEnd = 934539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetConnectionConfigValueInt32(IntPtr self, Connection hConn, NetConfig eValue, int val)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hConn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr__SetConnectionConfigValueInt32_Private_Static_Boolean_IntPtr_Connection_NetConfig_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x000304A4 File Offset: 0x0002E6A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934539, XrefRangeEnd = 934541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetConnectionConfigValueInt32(Connection hConn, NetConfig eValue, int val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hConn;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr_SetConnectionConfigValueInt32_Internal_Boolean_Connection_NetConfig_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x0003050C File Offset: 0x0002E70C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934541, XrefRangeEnd = 934543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetConnectionConfigValueFloat(IntPtr self, Connection hConn, NetConfig eValue, float val)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hConn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr__SetConnectionConfigValueFloat_Private_Static_Boolean_IntPtr_Connection_NetConfig_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00030574 File Offset: 0x0002E774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934543, XrefRangeEnd = 934545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetConnectionConfigValueFloat(Connection hConn, NetConfig eValue, float val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hConn;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr_SetConnectionConfigValueFloat_Internal_Boolean_Connection_NetConfig_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x000305DC File Offset: 0x0002E7DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934545, XrefRangeEnd = 934548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetConnectionConfigValueString(IntPtr self, Connection hConn, NetConfig eValue, string val)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hConn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(val);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr__SetConnectionConfigValueString_Private_Static_Boolean_IntPtr_Connection_NetConfig_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00030648 File Offset: 0x0002E848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934548, XrefRangeEnd = 934551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetConnectionConfigValueString(Connection hConn, NetConfig eValue, string val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hConn;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(val);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr_SetConnectionConfigValueString_Internal_Boolean_Connection_NetConfig_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x000306B4 File Offset: 0x0002E8B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934551, XrefRangeEnd = 934553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetGlobalCallback_SteamNetConnectionStatusChanged(IntPtr self, FnSteamNetConnectionStatusChanged fnCallback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fnCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr__SetGlobalCallback_SteamNetConnectionStatusChanged_Private_Static_Boolean_IntPtr_FnSteamNetConnectionStatusChanged_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00030704 File Offset: 0x0002E904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934553, XrefRangeEnd = 934555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetGlobalCallback_SteamNetConnectionStatusChanged(FnSteamNetConnectionStatusChanged fnCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fnCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr_SetGlobalCallback_SteamNetConnectionStatusChanged_Internal_Boolean_FnSteamNetConnectionStatusChanged_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00030754 File Offset: 0x0002E954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934555, XrefRangeEnd = 934557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetGlobalCallback_SteamNetAuthenticationStatusChanged(IntPtr self, FnSteamNetAuthenticationStatusChanged fnCallback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fnCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr__SetGlobalCallback_SteamNetAuthenticationStatusChanged_Private_Static_Boolean_IntPtr_FnSteamNetAuthenticationStatusChanged_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x000307A4 File Offset: 0x0002E9A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934557, XrefRangeEnd = 934559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetGlobalCallback_SteamNetAuthenticationStatusChanged(FnSteamNetAuthenticationStatusChanged fnCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fnCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr_SetGlobalCallback_SteamNetAuthenticationStatusChanged_Internal_Boolean_FnSteamNetAuthenticationStatusChanged_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x000307F4 File Offset: 0x0002E9F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934559, XrefRangeEnd = 934561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetGlobalCallback_SteamRelayNetworkStatusChanged(IntPtr self, FnSteamRelayNetworkStatusChanged fnCallback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fnCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr__SetGlobalCallback_SteamRelayNetworkStatusChanged_Private_Static_Boolean_IntPtr_FnSteamRelayNetworkStatusChanged_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00030844 File Offset: 0x0002EA44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934561, XrefRangeEnd = 934563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetGlobalCallback_SteamRelayNetworkStatusChanged(FnSteamRelayNetworkStatusChanged fnCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fnCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr_SetGlobalCallback_SteamRelayNetworkStatusChanged_Internal_Boolean_FnSteamRelayNetworkStatusChanged_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00030894 File Offset: 0x0002EA94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934563, XrefRangeEnd = 934565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetGlobalCallback_FakeIPResult(IntPtr self, FnSteamNetworkingFakeIPResult fnCallback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fnCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr__SetGlobalCallback_FakeIPResult_Private_Static_Boolean_IntPtr_FnSteamNetworkingFakeIPResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x000308E4 File Offset: 0x0002EAE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934565, XrefRangeEnd = 934567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetGlobalCallback_FakeIPResult(FnSteamNetworkingFakeIPResult fnCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fnCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr_SetGlobalCallback_FakeIPResult_Internal_Boolean_FnSteamNetworkingFakeIPResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00030934 File Offset: 0x0002EB34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934567, XrefRangeEnd = 934569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetGlobalCallback_MessagesSessionRequest(IntPtr self, FnSteamNetworkingMessagesSessionRequest fnCallback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fnCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr__SetGlobalCallback_MessagesSessionRequest_Private_Static_Boolean_IntPtr_FnSteamNetworkingMessagesSessionRequest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00030984 File Offset: 0x0002EB84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934569, XrefRangeEnd = 934571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetGlobalCallback_MessagesSessionRequest(FnSteamNetworkingMessagesSessionRequest fnCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fnCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr_SetGlobalCallback_MessagesSessionRequest_Internal_Boolean_FnSteamNetworkingMessagesSessionRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x000309D4 File Offset: 0x0002EBD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934571, XrefRangeEnd = 934573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetGlobalCallback_MessagesSessionFailed(IntPtr self, FnSteamNetworkingMessagesSessionFailed fnCallback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fnCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr__SetGlobalCallback_MessagesSessionFailed_Private_Static_Boolean_IntPtr_FnSteamNetworkingMessagesSessionFailed_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00030A24 File Offset: 0x0002EC24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934573, XrefRangeEnd = 934575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetGlobalCallback_MessagesSessionFailed(FnSteamNetworkingMessagesSessionFailed fnCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fnCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr_SetGlobalCallback_MessagesSessionFailed_Internal_Boolean_FnSteamNetworkingMessagesSessionFailed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00030A74 File Offset: 0x0002EC74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934575, XrefRangeEnd = 934577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetConfigValue(IntPtr self, NetConfig eValue, NetConfigScope eScopeType, IntPtr scopeObj, NetConfigType eDataType, IntPtr pArg)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eScopeType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scopeObj;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eDataType;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pArg;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr__SetConfigValue_Private_Static_Boolean_IntPtr_NetConfig_NetConfigScope_IntPtr_NetConfigType_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00030AF8 File Offset: 0x0002ECF8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 934579, RefRangeEnd = 934582, XrefRangeStart = 934577, XrefRangeEnd = 934579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetConfigValue(NetConfig eValue, NetConfigScope eScopeType, IntPtr scopeObj, NetConfigType eDataType, IntPtr pArg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eScopeType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scopeObj;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eDataType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pArg;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr_SetConfigValue_Internal_Boolean_NetConfig_NetConfigScope_IntPtr_NetConfigType_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00030B7C File Offset: 0x0002ED7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934582, XrefRangeEnd = 934584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetConfigValueStruct(IntPtr self, ref NetKeyValue opt, NetConfigScope eScopeType, IntPtr scopeObj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &opt;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eScopeType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scopeObj;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr__SetConfigValueStruct_Private_Static_Boolean_IntPtr_byref_NetKeyValue_NetConfigScope_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00030BE4 File Offset: 0x0002EDE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934584, XrefRangeEnd = 934586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetConfigValueStruct(ref NetKeyValue opt, NetConfigScope eScopeType, IntPtr scopeObj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &opt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eScopeType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scopeObj;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr_SetConfigValueStruct_Internal_Boolean_byref_NetKeyValue_NetConfigScope_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x00030C4C File Offset: 0x0002EE4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934586, XrefRangeEnd = 934588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NetConfigResult _GetConfigValue(IntPtr self, NetConfig eValue, NetConfigScope eScopeType, IntPtr scopeObj, ref NetConfigType pOutDataType, IntPtr pResult, ref UIntPtr cbResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eScopeType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scopeObj;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pOutDataType;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pResult;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cbResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr__GetConfigValue_Private_Static_NetConfigResult_IntPtr_NetConfig_NetConfigScope_IntPtr_byref_NetConfigType_IntPtr_byref_UIntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00030CE0 File Offset: 0x0002EEE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 934590, RefRangeEnd = 934592, XrefRangeStart = 934588, XrefRangeEnd = 934590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NetConfigResult GetConfigValue(NetConfig eValue, NetConfigScope eScopeType, IntPtr scopeObj, ref NetConfigType pOutDataType, IntPtr pResult, ref UIntPtr cbResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eScopeType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scopeObj;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pOutDataType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pResult;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cbResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr_GetConfigValue_Internal_NetConfigResult_NetConfig_NetConfigScope_IntPtr_byref_NetConfigType_IntPtr_byref_UIntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00030D74 File Offset: 0x0002EF74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934592, XrefRangeEnd = 934594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Utf8StringPointer _GetConfigValueInfo(IntPtr self, NetConfig eValue, ref NetConfigType pOutDataType, [In] [Out] Il2CppStructArray<NetConfigScope> pOutScope)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pOutDataType;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr__GetConfigValueInfo_Private_Static_Utf8StringPointer_IntPtr_NetConfig_byref_NetConfigType_Il2CppStructArray_1_NetConfigScope_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pOutScope = ((intPtr4 == 0) ? null : new Il2CppStructArray<NetConfigScope>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00030DF0 File Offset: 0x0002EFF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934594, XrefRangeEnd = 934597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetConfigValueInfo(NetConfig eValue, ref NetConfigType pOutDataType, [In] [Out] Il2CppStructArray<NetConfigScope> pOutScope)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pOutDataType;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr_GetConfigValueInfo_Internal_String_NetConfig_byref_NetConfigType_Il2CppStructArray_1_NetConfigScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pOutScope = ((intPtr4 == 0) ? null : new Il2CppStructArray<NetConfigScope>(intPtr4));
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00030E68 File Offset: 0x0002F068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934597, XrefRangeEnd = 934599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NetConfig _IterateGenericEditableConfigValues(IntPtr self, NetConfig eCurrent, bool bEnumerateDevVars)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eCurrent;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bEnumerateDevVars;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr__IterateGenericEditableConfigValues_Private_Static_NetConfig_IntPtr_NetConfig_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00030EC4 File Offset: 0x0002F0C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934599, XrefRangeEnd = 934601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NetConfig IterateGenericEditableConfigValues(NetConfig eCurrent, bool bEnumerateDevVars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eCurrent;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bEnumerateDevVars;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr_IterateGenericEditableConfigValues_Internal_NetConfig_NetConfig_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00030F1C File Offset: 0x0002F11C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934601, XrefRangeEnd = 934603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SteamNetworkingIPAddr_ToString(IntPtr self, ref NetAddress addr, IntPtr buf, uint cbBuf, bool bWithPort)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &addr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buf;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbBuf;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bWithPort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr__SteamNetworkingIPAddr_ToString_Private_Static_Void_IntPtr_byref_NetAddress_IntPtr_UInt32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00030F88 File Offset: 0x0002F188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934603, XrefRangeEnd = 934625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SteamNetworkingIPAddr_ToString(ref NetAddress addr, out string buf, bool bWithPort)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &addr;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bWithPort;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr_SteamNetworkingIPAddr_ToString_Internal_Void_byref_NetAddress_byref_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			buf = IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00030FF0 File Offset: 0x0002F1F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934625, XrefRangeEnd = 934628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SteamNetworkingIPAddr_ParseString(IntPtr self, ref NetAddress pAddr, string pszStr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pAddr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pszStr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr__SteamNetworkingIPAddr_ParseString_Private_Static_Boolean_IntPtr_byref_NetAddress_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x00031050 File Offset: 0x0002F250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934628, XrefRangeEnd = 934631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SteamNetworkingIPAddr_ParseString(ref NetAddress pAddr, string pszStr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pAddr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pszStr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr_SteamNetworkingIPAddr_ParseString_Internal_Boolean_byref_NetAddress_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x000310AC File Offset: 0x0002F2AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934631, XrefRangeEnd = 934633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamNetworkingFakeIPType _SteamNetworkingIPAddr_GetFakeIPType(IntPtr self, ref NetAddress addr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &addr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr__SteamNetworkingIPAddr_GetFakeIPType_Private_Static_SteamNetworkingFakeIPType_IntPtr_byref_NetAddress_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x000310F8 File Offset: 0x0002F2F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934633, XrefRangeEnd = 934635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamNetworkingFakeIPType SteamNetworkingIPAddr_GetFakeIPType(ref NetAddress addr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &addr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr_SteamNetworkingIPAddr_GetFakeIPType_Internal_SteamNetworkingFakeIPType_byref_NetAddress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x00031144 File Offset: 0x0002F344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934635, XrefRangeEnd = 934637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SteamNetworkingIdentity_ToString(IntPtr self, ref NetIdentity identity, IntPtr buf, uint cbBuf)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &identity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buf;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbBuf;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr__SteamNetworkingIdentity_ToString_Private_Static_Void_IntPtr_byref_NetIdentity_IntPtr_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x000311A0 File Offset: 0x0002F3A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934659, RefRangeEnd = 934660, XrefRangeStart = 934637, XrefRangeEnd = 934659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SteamNetworkingIdentity_ToString(ref NetIdentity identity, out string buf)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &identity;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr_SteamNetworkingIdentity_ToString_Internal_Void_byref_NetIdentity_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			buf = IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x000311F8 File Offset: 0x0002F3F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934660, XrefRangeEnd = 934663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SteamNetworkingIdentity_ParseString(IntPtr self, ref NetIdentity pIdentity, string pszStr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pIdentity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pszStr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr__SteamNetworkingIdentity_ParseString_Private_Static_Boolean_IntPtr_byref_NetIdentity_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00031258 File Offset: 0x0002F458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934663, XrefRangeEnd = 934666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SteamNetworkingIdentity_ParseString(ref NetIdentity pIdentity, string pszStr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pIdentity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pszStr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamNetworkingUtils.NativeMethodInfoPtr_SteamNetworkingIdentity_ParseString_Internal_Boolean_byref_NetIdentity_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x000023AB File Offset: 0x000005AB
		public ISteamNetworkingUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005B7 RID: 1463
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x040005B8 RID: 1464
		private static readonly IntPtr NativeMethodInfoPtr_SteamAPI_SteamNetworkingUtils_SteamAPI_v004_Internal_Static_IntPtr_0;

		// Token: 0x040005B9 RID: 1465
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalInterfacePointer_Public_Virtual_IntPtr_0;

		// Token: 0x040005BA RID: 1466
		private static readonly IntPtr NativeMethodInfoPtr__AllocateMessage_Private_Static_ptr_NetMsg_IntPtr_Int32_0;

		// Token: 0x040005BB RID: 1467
		private static readonly IntPtr NativeMethodInfoPtr_AllocateMessage_Internal_ptr_NetMsg_Int32_0;

		// Token: 0x040005BC RID: 1468
		private static readonly IntPtr NativeMethodInfoPtr__InitRelayNetworkAccess_Private_Static_Void_IntPtr_0;

		// Token: 0x040005BD RID: 1469
		private static readonly IntPtr NativeMethodInfoPtr_InitRelayNetworkAccess_Internal_Void_0;

		// Token: 0x040005BE RID: 1470
		private static readonly IntPtr NativeMethodInfoPtr__GetRelayNetworkStatus_Private_Static_SteamNetworkingAvailability_IntPtr_byref_SteamRelayNetworkStatus_t_0;

		// Token: 0x040005BF RID: 1471
		private static readonly IntPtr NativeMethodInfoPtr_GetRelayNetworkStatus_Internal_SteamNetworkingAvailability_byref_SteamRelayNetworkStatus_t_0;

		// Token: 0x040005C0 RID: 1472
		private static readonly IntPtr NativeMethodInfoPtr__GetLocalPingLocation_Private_Static_Single_IntPtr_byref_NetPingLocation_0;

		// Token: 0x040005C1 RID: 1473
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalPingLocation_Internal_Single_byref_NetPingLocation_0;

		// Token: 0x040005C2 RID: 1474
		private static readonly IntPtr NativeMethodInfoPtr__EstimatePingTimeBetweenTwoLocations_Private_Static_Int32_IntPtr_byref_NetPingLocation_byref_NetPingLocation_0;

		// Token: 0x040005C3 RID: 1475
		private static readonly IntPtr NativeMethodInfoPtr_EstimatePingTimeBetweenTwoLocations_Internal_Int32_byref_NetPingLocation_byref_NetPingLocation_0;

		// Token: 0x040005C4 RID: 1476
		private static readonly IntPtr NativeMethodInfoPtr__EstimatePingTimeFromLocalHost_Private_Static_Int32_IntPtr_byref_NetPingLocation_0;

		// Token: 0x040005C5 RID: 1477
		private static readonly IntPtr NativeMethodInfoPtr_EstimatePingTimeFromLocalHost_Internal_Int32_byref_NetPingLocation_0;

		// Token: 0x040005C6 RID: 1478
		private static readonly IntPtr NativeMethodInfoPtr__ConvertPingLocationToString_Private_Static_Void_IntPtr_byref_NetPingLocation_IntPtr_Int32_0;

		// Token: 0x040005C7 RID: 1479
		private static readonly IntPtr NativeMethodInfoPtr_ConvertPingLocationToString_Internal_Void_byref_NetPingLocation_byref_String_0;

		// Token: 0x040005C8 RID: 1480
		private static readonly IntPtr NativeMethodInfoPtr__ParsePingLocationString_Private_Static_Boolean_IntPtr_String_byref_NetPingLocation_0;

		// Token: 0x040005C9 RID: 1481
		private static readonly IntPtr NativeMethodInfoPtr_ParsePingLocationString_Internal_Boolean_String_byref_NetPingLocation_0;

		// Token: 0x040005CA RID: 1482
		private static readonly IntPtr NativeMethodInfoPtr__CheckPingDataUpToDate_Private_Static_Boolean_IntPtr_Single_0;

		// Token: 0x040005CB RID: 1483
		private static readonly IntPtr NativeMethodInfoPtr_CheckPingDataUpToDate_Internal_Boolean_Single_0;

		// Token: 0x040005CC RID: 1484
		private static readonly IntPtr NativeMethodInfoPtr__GetPingToDataCenter_Private_Static_Int32_IntPtr_SteamNetworkingPOPID_byref_SteamNetworkingPOPID_0;

		// Token: 0x040005CD RID: 1485
		private static readonly IntPtr NativeMethodInfoPtr_GetPingToDataCenter_Internal_Int32_SteamNetworkingPOPID_byref_SteamNetworkingPOPID_0;

		// Token: 0x040005CE RID: 1486
		private static readonly IntPtr NativeMethodInfoPtr__GetDirectPingToPOP_Private_Static_Int32_IntPtr_SteamNetworkingPOPID_0;

		// Token: 0x040005CF RID: 1487
		private static readonly IntPtr NativeMethodInfoPtr_GetDirectPingToPOP_Internal_Int32_SteamNetworkingPOPID_0;

		// Token: 0x040005D0 RID: 1488
		private static readonly IntPtr NativeMethodInfoPtr__GetPOPCount_Private_Static_Int32_IntPtr_0;

		// Token: 0x040005D1 RID: 1489
		private static readonly IntPtr NativeMethodInfoPtr_GetPOPCount_Internal_Int32_0;

		// Token: 0x040005D2 RID: 1490
		private static readonly IntPtr NativeMethodInfoPtr__GetPOPList_Private_Static_Int32_IntPtr_byref_SteamNetworkingPOPID_Int32_0;

		// Token: 0x040005D3 RID: 1491
		private static readonly IntPtr NativeMethodInfoPtr_GetPOPList_Internal_Int32_byref_SteamNetworkingPOPID_Int32_0;

		// Token: 0x040005D4 RID: 1492
		private static readonly IntPtr NativeMethodInfoPtr__GetLocalTimestamp_Private_Static_Int64_IntPtr_0;

		// Token: 0x040005D5 RID: 1493
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalTimestamp_Internal_Int64_0;

		// Token: 0x040005D6 RID: 1494
		private static readonly IntPtr NativeMethodInfoPtr__SetDebugOutputFunction_Private_Static_Void_IntPtr_NetDebugOutput_NetDebugFunc_0;

		// Token: 0x040005D7 RID: 1495
		private static readonly IntPtr NativeMethodInfoPtr_SetDebugOutputFunction_Internal_Void_NetDebugOutput_NetDebugFunc_0;

		// Token: 0x040005D8 RID: 1496
		private static readonly IntPtr NativeMethodInfoPtr__IsFakeIPv4_Private_Static_Boolean_IntPtr_UInt32_0;

		// Token: 0x040005D9 RID: 1497
		private static readonly IntPtr NativeMethodInfoPtr_IsFakeIPv4_Internal_Boolean_UInt32_0;

		// Token: 0x040005DA RID: 1498
		private static readonly IntPtr NativeMethodInfoPtr__GetIPv4FakeIPType_Private_Static_SteamNetworkingFakeIPType_IntPtr_UInt32_0;

		// Token: 0x040005DB RID: 1499
		private static readonly IntPtr NativeMethodInfoPtr_GetIPv4FakeIPType_Internal_SteamNetworkingFakeIPType_UInt32_0;

		// Token: 0x040005DC RID: 1500
		private static readonly IntPtr NativeMethodInfoPtr__GetRealIdentityForFakeIP_Private_Static_Result_IntPtr_byref_NetAddress_Il2CppStructArray_1_NetIdentity_0;

		// Token: 0x040005DD RID: 1501
		private static readonly IntPtr NativeMethodInfoPtr_GetRealIdentityForFakeIP_Internal_Result_byref_NetAddress_Il2CppStructArray_1_NetIdentity_0;

		// Token: 0x040005DE RID: 1502
		private static readonly IntPtr NativeMethodInfoPtr__SetGlobalConfigValueInt32_Private_Static_Boolean_IntPtr_NetConfig_Int32_0;

		// Token: 0x040005DF RID: 1503
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalConfigValueInt32_Internal_Boolean_NetConfig_Int32_0;

		// Token: 0x040005E0 RID: 1504
		private static readonly IntPtr NativeMethodInfoPtr__SetGlobalConfigValueFloat_Private_Static_Boolean_IntPtr_NetConfig_Single_0;

		// Token: 0x040005E1 RID: 1505
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalConfigValueFloat_Internal_Boolean_NetConfig_Single_0;

		// Token: 0x040005E2 RID: 1506
		private static readonly IntPtr NativeMethodInfoPtr__SetGlobalConfigValueString_Private_Static_Boolean_IntPtr_NetConfig_String_0;

		// Token: 0x040005E3 RID: 1507
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalConfigValueString_Internal_Boolean_NetConfig_String_0;

		// Token: 0x040005E4 RID: 1508
		private static readonly IntPtr NativeMethodInfoPtr__SetGlobalConfigValuePtr_Private_Static_Boolean_IntPtr_NetConfig_IntPtr_0;

		// Token: 0x040005E5 RID: 1509
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalConfigValuePtr_Internal_Boolean_NetConfig_IntPtr_0;

		// Token: 0x040005E6 RID: 1510
		private static readonly IntPtr NativeMethodInfoPtr__SetConnectionConfigValueInt32_Private_Static_Boolean_IntPtr_Connection_NetConfig_Int32_0;

		// Token: 0x040005E7 RID: 1511
		private static readonly IntPtr NativeMethodInfoPtr_SetConnectionConfigValueInt32_Internal_Boolean_Connection_NetConfig_Int32_0;

		// Token: 0x040005E8 RID: 1512
		private static readonly IntPtr NativeMethodInfoPtr__SetConnectionConfigValueFloat_Private_Static_Boolean_IntPtr_Connection_NetConfig_Single_0;

		// Token: 0x040005E9 RID: 1513
		private static readonly IntPtr NativeMethodInfoPtr_SetConnectionConfigValueFloat_Internal_Boolean_Connection_NetConfig_Single_0;

		// Token: 0x040005EA RID: 1514
		private static readonly IntPtr NativeMethodInfoPtr__SetConnectionConfigValueString_Private_Static_Boolean_IntPtr_Connection_NetConfig_String_0;

		// Token: 0x040005EB RID: 1515
		private static readonly IntPtr NativeMethodInfoPtr_SetConnectionConfigValueString_Internal_Boolean_Connection_NetConfig_String_0;

		// Token: 0x040005EC RID: 1516
		private static readonly IntPtr NativeMethodInfoPtr__SetGlobalCallback_SteamNetConnectionStatusChanged_Private_Static_Boolean_IntPtr_FnSteamNetConnectionStatusChanged_0;

		// Token: 0x040005ED RID: 1517
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalCallback_SteamNetConnectionStatusChanged_Internal_Boolean_FnSteamNetConnectionStatusChanged_0;

		// Token: 0x040005EE RID: 1518
		private static readonly IntPtr NativeMethodInfoPtr__SetGlobalCallback_SteamNetAuthenticationStatusChanged_Private_Static_Boolean_IntPtr_FnSteamNetAuthenticationStatusChanged_0;

		// Token: 0x040005EF RID: 1519
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalCallback_SteamNetAuthenticationStatusChanged_Internal_Boolean_FnSteamNetAuthenticationStatusChanged_0;

		// Token: 0x040005F0 RID: 1520
		private static readonly IntPtr NativeMethodInfoPtr__SetGlobalCallback_SteamRelayNetworkStatusChanged_Private_Static_Boolean_IntPtr_FnSteamRelayNetworkStatusChanged_0;

		// Token: 0x040005F1 RID: 1521
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalCallback_SteamRelayNetworkStatusChanged_Internal_Boolean_FnSteamRelayNetworkStatusChanged_0;

		// Token: 0x040005F2 RID: 1522
		private static readonly IntPtr NativeMethodInfoPtr__SetGlobalCallback_FakeIPResult_Private_Static_Boolean_IntPtr_FnSteamNetworkingFakeIPResult_0;

		// Token: 0x040005F3 RID: 1523
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalCallback_FakeIPResult_Internal_Boolean_FnSteamNetworkingFakeIPResult_0;

		// Token: 0x040005F4 RID: 1524
		private static readonly IntPtr NativeMethodInfoPtr__SetGlobalCallback_MessagesSessionRequest_Private_Static_Boolean_IntPtr_FnSteamNetworkingMessagesSessionRequest_0;

		// Token: 0x040005F5 RID: 1525
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalCallback_MessagesSessionRequest_Internal_Boolean_FnSteamNetworkingMessagesSessionRequest_0;

		// Token: 0x040005F6 RID: 1526
		private static readonly IntPtr NativeMethodInfoPtr__SetGlobalCallback_MessagesSessionFailed_Private_Static_Boolean_IntPtr_FnSteamNetworkingMessagesSessionFailed_0;

		// Token: 0x040005F7 RID: 1527
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalCallback_MessagesSessionFailed_Internal_Boolean_FnSteamNetworkingMessagesSessionFailed_0;

		// Token: 0x040005F8 RID: 1528
		private static readonly IntPtr NativeMethodInfoPtr__SetConfigValue_Private_Static_Boolean_IntPtr_NetConfig_NetConfigScope_IntPtr_NetConfigType_IntPtr_0;

		// Token: 0x040005F9 RID: 1529
		private static readonly IntPtr NativeMethodInfoPtr_SetConfigValue_Internal_Boolean_NetConfig_NetConfigScope_IntPtr_NetConfigType_IntPtr_0;

		// Token: 0x040005FA RID: 1530
		private static readonly IntPtr NativeMethodInfoPtr__SetConfigValueStruct_Private_Static_Boolean_IntPtr_byref_NetKeyValue_NetConfigScope_IntPtr_0;

		// Token: 0x040005FB RID: 1531
		private static readonly IntPtr NativeMethodInfoPtr_SetConfigValueStruct_Internal_Boolean_byref_NetKeyValue_NetConfigScope_IntPtr_0;

		// Token: 0x040005FC RID: 1532
		private static readonly IntPtr NativeMethodInfoPtr__GetConfigValue_Private_Static_NetConfigResult_IntPtr_NetConfig_NetConfigScope_IntPtr_byref_NetConfigType_IntPtr_byref_UIntPtr_0;

		// Token: 0x040005FD RID: 1533
		private static readonly IntPtr NativeMethodInfoPtr_GetConfigValue_Internal_NetConfigResult_NetConfig_NetConfigScope_IntPtr_byref_NetConfigType_IntPtr_byref_UIntPtr_0;

		// Token: 0x040005FE RID: 1534
		private static readonly IntPtr NativeMethodInfoPtr__GetConfigValueInfo_Private_Static_Utf8StringPointer_IntPtr_NetConfig_byref_NetConfigType_Il2CppStructArray_1_NetConfigScope_0;

		// Token: 0x040005FF RID: 1535
		private static readonly IntPtr NativeMethodInfoPtr_GetConfigValueInfo_Internal_String_NetConfig_byref_NetConfigType_Il2CppStructArray_1_NetConfigScope_0;

		// Token: 0x04000600 RID: 1536
		private static readonly IntPtr NativeMethodInfoPtr__IterateGenericEditableConfigValues_Private_Static_NetConfig_IntPtr_NetConfig_Boolean_0;

		// Token: 0x04000601 RID: 1537
		private static readonly IntPtr NativeMethodInfoPtr_IterateGenericEditableConfigValues_Internal_NetConfig_NetConfig_Boolean_0;

		// Token: 0x04000602 RID: 1538
		private static readonly IntPtr NativeMethodInfoPtr__SteamNetworkingIPAddr_ToString_Private_Static_Void_IntPtr_byref_NetAddress_IntPtr_UInt32_Boolean_0;

		// Token: 0x04000603 RID: 1539
		private static readonly IntPtr NativeMethodInfoPtr_SteamNetworkingIPAddr_ToString_Internal_Void_byref_NetAddress_byref_String_Boolean_0;

		// Token: 0x04000604 RID: 1540
		private static readonly IntPtr NativeMethodInfoPtr__SteamNetworkingIPAddr_ParseString_Private_Static_Boolean_IntPtr_byref_NetAddress_String_0;

		// Token: 0x04000605 RID: 1541
		private static readonly IntPtr NativeMethodInfoPtr_SteamNetworkingIPAddr_ParseString_Internal_Boolean_byref_NetAddress_String_0;

		// Token: 0x04000606 RID: 1542
		private static readonly IntPtr NativeMethodInfoPtr__SteamNetworkingIPAddr_GetFakeIPType_Private_Static_SteamNetworkingFakeIPType_IntPtr_byref_NetAddress_0;

		// Token: 0x04000607 RID: 1543
		private static readonly IntPtr NativeMethodInfoPtr_SteamNetworkingIPAddr_GetFakeIPType_Internal_SteamNetworkingFakeIPType_byref_NetAddress_0;

		// Token: 0x04000608 RID: 1544
		private static readonly IntPtr NativeMethodInfoPtr__SteamNetworkingIdentity_ToString_Private_Static_Void_IntPtr_byref_NetIdentity_IntPtr_UInt32_0;

		// Token: 0x04000609 RID: 1545
		private static readonly IntPtr NativeMethodInfoPtr_SteamNetworkingIdentity_ToString_Internal_Void_byref_NetIdentity_byref_String_0;

		// Token: 0x0400060A RID: 1546
		private static readonly IntPtr NativeMethodInfoPtr__SteamNetworkingIdentity_ParseString_Private_Static_Boolean_IntPtr_byref_NetIdentity_String_0;

		// Token: 0x0400060B RID: 1547
		private static readonly IntPtr NativeMethodInfoPtr_SteamNetworkingIdentity_ParseString_Internal_Boolean_byref_NetIdentity_String_0;
	}
}
