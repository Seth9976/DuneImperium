using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Net;
using Il2CppSystem.Reflection;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x020000AD RID: 173
	public class SteamServer : SteamServerClass<SteamServer>
	{
		// Token: 0x06000A72 RID: 2674 RVA: 0x0004AC10 File Offset: 0x00048E10
		// Note: this type is marked as 'beforefieldinit'.
		static SteamServer()
		{
			Il2CppClassPointerStore<SteamServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "SteamServer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamServer>.NativeClassPtr);
			SteamServer.NativeFieldInfoPtr_OnValidateAuthTicketResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, "OnValidateAuthTicketResponse");
			SteamServer.NativeFieldInfoPtr_OnSteamServersConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, "OnSteamServersConnected");
			SteamServer.NativeFieldInfoPtr_OnSteamServerConnectFailure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, "OnSteamServerConnectFailure");
			SteamServer.NativeFieldInfoPtr_OnSteamServersDisconnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, "OnSteamServersDisconnected");
			SteamServer.NativeFieldInfoPtr_OnSteamNetAuthenticationStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, "OnSteamNetAuthenticationStatus");
			SteamServer.NativeFieldInfoPtr_openInterfaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, "openInterfaces");
			SteamServer.NativeFieldInfoPtr__dedicatedServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, "_dedicatedServer");
			SteamServer.NativeFieldInfoPtr__maxplayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, "_maxplayers");
			SteamServer.NativeFieldInfoPtr__botcount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, "_botcount");
			SteamServer.NativeFieldInfoPtr__mapname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, "_mapname");
			SteamServer.NativeFieldInfoPtr__modDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, "_modDir");
			SteamServer.NativeFieldInfoPtr__product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, "_product");
			SteamServer.NativeFieldInfoPtr__gameDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, "_gameDescription");
			SteamServer.NativeFieldInfoPtr__serverName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, "_serverName");
			SteamServer.NativeFieldInfoPtr__passworded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, "_passworded");
			SteamServer.NativeFieldInfoPtr__gametags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, "_gametags");
			SteamServer.NativeFieldInfoPtr_KeyValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, "KeyValue");
			SteamServer.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamGameServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665869);
			SteamServer.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665870);
			SteamServer.NativeMethodInfoPtr_get_IsValid_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665871);
			SteamServer.NativeMethodInfoPtr_InstallEvents_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665872);
			SteamServer.NativeMethodInfoPtr_add_OnValidateAuthTicketResponse_Public_Static_add_Void_Action_3_SteamId_SteamId_AuthResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665873);
			SteamServer.NativeMethodInfoPtr_remove_OnValidateAuthTicketResponse_Public_Static_rem_Void_Action_3_SteamId_SteamId_AuthResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665874);
			SteamServer.NativeMethodInfoPtr_add_OnSteamServersConnected_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665875);
			SteamServer.NativeMethodInfoPtr_remove_OnSteamServersConnected_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665876);
			SteamServer.NativeMethodInfoPtr_add_OnSteamServerConnectFailure_Public_Static_add_Void_Action_2_Result_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665877);
			SteamServer.NativeMethodInfoPtr_remove_OnSteamServerConnectFailure_Public_Static_rem_Void_Action_2_Result_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665878);
			SteamServer.NativeMethodInfoPtr_add_OnSteamServersDisconnected_Public_Static_add_Void_Action_1_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665879);
			SteamServer.NativeMethodInfoPtr_remove_OnSteamServersDisconnected_Public_Static_rem_Void_Action_1_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665880);
			SteamServer.NativeMethodInfoPtr_add_OnSteamNetAuthenticationStatus_Public_Static_add_Void_Action_1_SteamNetworkingAvailability_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665881);
			SteamServer.NativeMethodInfoPtr_remove_OnSteamNetAuthenticationStatus_Public_Static_rem_Void_Action_1_SteamNetworkingAvailability_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665882);
			SteamServer.NativeMethodInfoPtr_Init_Public_Static_Void_AppId_SteamServerInit_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665883);
			SteamServer.NativeMethodInfoPtr_AddInterface_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665884);
			SteamServer.NativeMethodInfoPtr_ShutdownInterfaces_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665885);
			SteamServer.NativeMethodInfoPtr_Shutdown_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665886);
			SteamServer.NativeMethodInfoPtr_RunCallbacks_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665887);
			SteamServer.NativeMethodInfoPtr_get_DedicatedServer_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665888);
			SteamServer.NativeMethodInfoPtr_set_DedicatedServer_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665889);
			SteamServer.NativeMethodInfoPtr_get_MaxPlayers_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665890);
			SteamServer.NativeMethodInfoPtr_set_MaxPlayers_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665891);
			SteamServer.NativeMethodInfoPtr_get_BotCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665892);
			SteamServer.NativeMethodInfoPtr_set_BotCount_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665893);
			SteamServer.NativeMethodInfoPtr_get_MapName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665894);
			SteamServer.NativeMethodInfoPtr_set_MapName_Public_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665895);
			SteamServer.NativeMethodInfoPtr_get_ModDir_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665896);
			SteamServer.NativeMethodInfoPtr_set_ModDir_Internal_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665897);
			SteamServer.NativeMethodInfoPtr_get_Product_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665898);
			SteamServer.NativeMethodInfoPtr_set_Product_Internal_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665899);
			SteamServer.NativeMethodInfoPtr_get_GameDescription_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665900);
			SteamServer.NativeMethodInfoPtr_set_GameDescription_Internal_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665901);
			SteamServer.NativeMethodInfoPtr_get_ServerName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665902);
			SteamServer.NativeMethodInfoPtr_set_ServerName_Public_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665903);
			SteamServer.NativeMethodInfoPtr_get_Passworded_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665904);
			SteamServer.NativeMethodInfoPtr_set_Passworded_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665905);
			SteamServer.NativeMethodInfoPtr_get_GameTags_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665906);
			SteamServer.NativeMethodInfoPtr_set_GameTags_Public_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665907);
			SteamServer.NativeMethodInfoPtr_get_SteamId_Public_Static_get_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665908);
			SteamServer.NativeMethodInfoPtr_LogOnAnonymous_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665909);
			SteamServer.NativeMethodInfoPtr_LogOff_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665910);
			SteamServer.NativeMethodInfoPtr_get_LoggedOn_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665911);
			SteamServer.NativeMethodInfoPtr_get_PublicIp_Public_Static_get_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665912);
			SteamServer.NativeMethodInfoPtr_set_AutomaticHeartbeats_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665913);
			SteamServer.NativeMethodInfoPtr_set_AdvertiseServer_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665914);
			SteamServer.NativeMethodInfoPtr_ForceHeartbeat_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665915);
			SteamServer.NativeMethodInfoPtr_UpdatePlayer_Public_Static_Void_SteamId_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665916);
			SteamServer.NativeMethodInfoPtr_SetKey_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665917);
			SteamServer.NativeMethodInfoPtr_ClearKeys_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665918);
			SteamServer.NativeMethodInfoPtr_BeginAuthSession_Public_Static_Boolean_Il2CppStructArray_1_Byte_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665919);
			SteamServer.NativeMethodInfoPtr_EndSession_Public_Static_Void_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665920);
			SteamServer.NativeMethodInfoPtr_GetOutgoingPacket_Public_Static_Boolean_byref_OutgoingPacket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665921);
			SteamServer.NativeMethodInfoPtr_HandleIncomingPacket_Public_Static_Void_Il2CppStructArray_1_Byte_Int32_UInt32_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665922);
			SteamServer.NativeMethodInfoPtr_HandleIncomingPacket_Public_Static_Void_IntPtr_Int32_UInt32_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665923);
			SteamServer.NativeMethodInfoPtr_UserHasLicenseForApp_Public_Static_UserHasLicenseForAppResult_SteamId_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665924);
			SteamServer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, 100665925);
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000A73 RID: 2675 RVA: 0x0004B208 File Offset: 0x00049408
		public unsafe static ISteamGameServer Internal
		{
			[CallerCount(37)]
			[CachedScanResults(RefRangeStart = 942316, RefRangeEnd = 942353, XrefRangeStart = 942313, XrefRangeEnd = 942316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamGameServer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISteamGameServer>(intPtr3) : null;
			}
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x0004B23C File Offset: 0x0004943C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942353, XrefRangeEnd = 942361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeInterface(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref server;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamServer.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000A75 RID: 2677 RVA: 0x0004B288 File Offset: 0x00049488
		public unsafe static bool IsValid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942361, XrefRangeEnd = 942365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_get_IsValid_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x0004B2B8 File Offset: 0x000494B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 942462, RefRangeEnd = 942463, XrefRangeStart = 942365, XrefRangeEnd = 942462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InstallEvents()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_InstallEvents_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x0004B2E0 File Offset: 0x000494E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942463, XrefRangeEnd = 942476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnValidateAuthTicketResponse(Action<SteamId, SteamId, AuthResponse> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_add_OnValidateAuthTicketResponse_Public_Static_add_Void_Action_3_SteamId_SteamId_AuthResponse_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x0004B318 File Offset: 0x00049518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942476, XrefRangeEnd = 942489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnValidateAuthTicketResponse(Action<SteamId, SteamId, AuthResponse> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_remove_OnValidateAuthTicketResponse_Public_Static_rem_Void_Action_3_SteamId_SteamId_AuthResponse_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x0004B350 File Offset: 0x00049550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942489, XrefRangeEnd = 942500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnSteamServersConnected(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_add_OnSteamServersConnected_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x0004B388 File Offset: 0x00049588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942500, XrefRangeEnd = 942511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnSteamServersConnected(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_remove_OnSteamServersConnected_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x0004B3C0 File Offset: 0x000495C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942511, XrefRangeEnd = 942524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnSteamServerConnectFailure(Action<Result, bool> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_add_OnSteamServerConnectFailure_Public_Static_add_Void_Action_2_Result_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x0004B3F8 File Offset: 0x000495F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942524, XrefRangeEnd = 942537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnSteamServerConnectFailure(Action<Result, bool> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_remove_OnSteamServerConnectFailure_Public_Static_rem_Void_Action_2_Result_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x0004B430 File Offset: 0x00049630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942537, XrefRangeEnd = 942550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnSteamServersDisconnected(Action<Result> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_add_OnSteamServersDisconnected_Public_Static_add_Void_Action_1_Result_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x0004B468 File Offset: 0x00049668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942550, XrefRangeEnd = 942563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnSteamServersDisconnected(Action<Result> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_remove_OnSteamServersDisconnected_Public_Static_rem_Void_Action_1_Result_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x0004B4A0 File Offset: 0x000496A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942563, XrefRangeEnd = 942576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnSteamNetAuthenticationStatus(Action<SteamNetworkingAvailability> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_add_OnSteamNetAuthenticationStatus_Public_Static_add_Void_Action_1_SteamNetworkingAvailability_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x0004B4D8 File Offset: 0x000496D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942576, XrefRangeEnd = 942589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnSteamNetAuthenticationStatus(Action<SteamNetworkingAvailability> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_remove_OnSteamNetAuthenticationStatus_Public_Static_rem_Void_Action_1_SteamNetworkingAvailability_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x0004B510 File Offset: 0x00049710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942589, XrefRangeEnd = 942735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Init(AppId appid, SteamServerInit init, bool asyncCallbacks = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref appid;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(init));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref asyncCallbacks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_Init_Public_Static_Void_AppId_SteamServerInit_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x0004B568 File Offset: 0x00049768
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 942747, RefRangeEnd = 942756, XrefRangeStart = 942735, XrefRangeEnd = 942747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddInterface<T>() where T : SteamClass, new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.MethodInfoStoreGeneric_AddInterface_Internal_Static_Void_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x0004B590 File Offset: 0x00049790
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 942779, RefRangeEnd = 942780, XrefRangeStart = 942756, XrefRangeEnd = 942779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ShutdownInterfaces()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_ShutdownInterfaces_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x0004B5B8 File Offset: 0x000497B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942780, XrefRangeEnd = 942789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Shutdown()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_Shutdown_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x0004B5E0 File Offset: 0x000497E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942789, XrefRangeEnd = 942805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RunCallbacks()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_RunCallbacks_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000A86 RID: 2694 RVA: 0x0004B608 File Offset: 0x00049808
		// (set) Token: 0x06000A87 RID: 2695 RVA: 0x0004B638 File Offset: 0x00049838
		public unsafe static bool DedicatedServer
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942805, XrefRangeEnd = 942809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_get_DedicatedServer_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942809, XrefRangeEnd = 942817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_set_DedicatedServer_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000A88 RID: 2696 RVA: 0x0004B66C File Offset: 0x0004986C
		// (set) Token: 0x06000A89 RID: 2697 RVA: 0x0004B69C File Offset: 0x0004989C
		public unsafe static int MaxPlayers
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942817, XrefRangeEnd = 942821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_get_MaxPlayers_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942821, XrefRangeEnd = 942829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_set_MaxPlayers_Public_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000A8A RID: 2698 RVA: 0x0004B6D0 File Offset: 0x000498D0
		// (set) Token: 0x06000A8B RID: 2699 RVA: 0x0004B700 File Offset: 0x00049900
		public unsafe static int BotCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942829, XrefRangeEnd = 942833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_get_BotCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942833, XrefRangeEnd = 942841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_set_BotCount_Public_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000A8C RID: 2700 RVA: 0x0004B734 File Offset: 0x00049934
		// (set) Token: 0x06000A8D RID: 2701 RVA: 0x0004B760 File Offset: 0x00049960
		public unsafe static string MapName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942841, XrefRangeEnd = 942845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_get_MapName_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942845, XrefRangeEnd = 942857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_set_MapName_Public_Static_set_Void_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000A8E RID: 2702 RVA: 0x0004B798 File Offset: 0x00049998
		// (set) Token: 0x06000A8F RID: 2703 RVA: 0x0004B7C4 File Offset: 0x000499C4
		public unsafe static string ModDir
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942857, XrefRangeEnd = 942861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_get_ModDir_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942861, XrefRangeEnd = 942873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_set_ModDir_Internal_Static_set_Void_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000A90 RID: 2704 RVA: 0x0004B7FC File Offset: 0x000499FC
		// (set) Token: 0x06000A91 RID: 2705 RVA: 0x0004B828 File Offset: 0x00049A28
		public unsafe static string Product
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942873, XrefRangeEnd = 942877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_get_Product_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942877, XrefRangeEnd = 942889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_set_Product_Internal_Static_set_Void_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000A92 RID: 2706 RVA: 0x0004B860 File Offset: 0x00049A60
		// (set) Token: 0x06000A93 RID: 2707 RVA: 0x0004B88C File Offset: 0x00049A8C
		public unsafe static string GameDescription
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942889, XrefRangeEnd = 942893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_get_GameDescription_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942893, XrefRangeEnd = 942905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_set_GameDescription_Internal_Static_set_Void_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000A94 RID: 2708 RVA: 0x0004B8C4 File Offset: 0x00049AC4
		// (set) Token: 0x06000A95 RID: 2709 RVA: 0x0004B8F0 File Offset: 0x00049AF0
		public unsafe static string ServerName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942905, XrefRangeEnd = 942909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_get_ServerName_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942909, XrefRangeEnd = 942921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_set_ServerName_Public_Static_set_Void_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000A96 RID: 2710 RVA: 0x0004B928 File Offset: 0x00049B28
		// (set) Token: 0x06000A97 RID: 2711 RVA: 0x0004B958 File Offset: 0x00049B58
		public unsafe static bool Passworded
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942921, XrefRangeEnd = 942925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_get_Passworded_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942925, XrefRangeEnd = 942933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_set_Passworded_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000A98 RID: 2712 RVA: 0x0004B98C File Offset: 0x00049B8C
		// (set) Token: 0x06000A99 RID: 2713 RVA: 0x0004B9B8 File Offset: 0x00049BB8
		public unsafe static string GameTags
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942933, XrefRangeEnd = 942937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_get_GameTags_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942937, XrefRangeEnd = 942949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_set_GameTags_Public_Static_set_Void_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000A9A RID: 2714 RVA: 0x0004B9F0 File Offset: 0x00049BF0
		public unsafe static SteamId SteamId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942949, XrefRangeEnd = 942955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_get_SteamId_Public_Static_get_SteamId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x0004BA20 File Offset: 0x00049C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942955, XrefRangeEnd = 942961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogOnAnonymous()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_LogOnAnonymous_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x0004BA48 File Offset: 0x00049C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942961, XrefRangeEnd = 942967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogOff()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_LogOff_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x0004BA70 File Offset: 0x00049C70
		public unsafe static bool LoggedOn
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942967, XrefRangeEnd = 942973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_get_LoggedOn_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000A9E RID: 2718 RVA: 0x0004BAA0 File Offset: 0x00049CA0
		public unsafe static IPAddress PublicIp
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942973, XrefRangeEnd = 942979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_get_PublicIp_Public_Static_get_IPAddress_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr3) : null;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (set) Token: 0x06000A9F RID: 2719 RVA: 0x0004BAD4 File Offset: 0x00049CD4
		public unsafe static bool AutomaticHeartbeats
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942979, XrefRangeEnd = 942985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_set_AutomaticHeartbeats_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000D4 RID: 212
		// (set) Token: 0x06000AA0 RID: 2720 RVA: 0x0004BB08 File Offset: 0x00049D08
		public unsafe static bool AdvertiseServer
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942985, XrefRangeEnd = 942991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_set_AdvertiseServer_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x0004BB3C File Offset: 0x00049D3C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ForceHeartbeat()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_ForceHeartbeat_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x0004BB64 File Offset: 0x00049D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942991, XrefRangeEnd = 942996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdatePlayer(SteamId steamid, string name, int score)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamid;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_UpdatePlayer_Public_Static_Void_SteamId_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x0004BBB8 File Offset: 0x00049DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942996, XrefRangeEnd = 943026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetKey(string Key, string Value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(Value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_SetKey_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x0004BC00 File Offset: 0x00049E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943026, XrefRangeEnd = 943036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearKeys()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_ClearKeys_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x0004BC28 File Offset: 0x00049E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943036, XrefRangeEnd = 943043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BeginAuthSession(Il2CppStructArray<byte> data, SteamId steamid)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_BeginAuthSession_Public_Static_Boolean_Il2CppStructArray_1_Byte_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x0004BC78 File Offset: 0x00049E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943043, XrefRangeEnd = 943049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndSession(SteamId steamid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_EndSession_Public_Static_Void_SteamId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x0004BCAC File Offset: 0x00049EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943049, XrefRangeEnd = 943061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetOutgoingPacket(out OutgoingPacket packet)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_GetOutgoingPacket_Public_Static_Boolean_byref_OutgoingPacket_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				packet = ((intPtr4 == 0) ? null : new OutgoingPacket(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x0004BD00 File Offset: 0x00049F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943061, XrefRangeEnd = 943071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void HandleIncomingPacket(Il2CppStructArray<byte> data, int size, uint address, ushort port)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref address;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_HandleIncomingPacket_Public_Static_Void_Il2CppStructArray_1_Byte_Int32_UInt32_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x0004BD60 File Offset: 0x00049F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943071, XrefRangeEnd = 943076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void HandleIncomingPacket(IntPtr ptr, int size, uint address, ushort port)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref address;
			ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_HandleIncomingPacket_Public_Static_Void_IntPtr_Int32_UInt32_UInt16_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x0004BDBC File Offset: 0x00049FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943076, XrefRangeEnd = 943129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UserHasLicenseForAppResult UserHasLicenseForApp(SteamId steamid, AppId appid)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamid;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr_UserHasLicenseForApp_Public_Static_UserHasLicenseForAppResult_SteamId_AppId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x0004BE08 File Offset: 0x0004A008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943129, XrefRangeEnd = 943132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamServer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamServer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x00002B2C File Offset: 0x00000D2C
		public SteamServer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000AAD RID: 2733 RVA: 0x0004BE44 File Offset: 0x0004A044
		// (set) Token: 0x06000AAE RID: 2734 RVA: 0x00002B35 File Offset: 0x00000D35
		public unsafe static Action<SteamId, SteamId, AuthResponse> OnValidateAuthTicketResponse
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamServer.NativeFieldInfoPtr_OnValidateAuthTicketResponse, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SteamId, SteamId, AuthResponse>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamServer.NativeFieldInfoPtr_OnValidateAuthTicketResponse, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000AAF RID: 2735 RVA: 0x0004BE6C File Offset: 0x0004A06C
		// (set) Token: 0x06000AB0 RID: 2736 RVA: 0x00002B47 File Offset: 0x00000D47
		public unsafe static Action OnSteamServersConnected
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamServer.NativeFieldInfoPtr_OnSteamServersConnected, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamServer.NativeFieldInfoPtr_OnSteamServersConnected, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000AB1 RID: 2737 RVA: 0x0004BE94 File Offset: 0x0004A094
		// (set) Token: 0x06000AB2 RID: 2738 RVA: 0x00002B59 File Offset: 0x00000D59
		public unsafe static Action<Result, bool> OnSteamServerConnectFailure
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamServer.NativeFieldInfoPtr_OnSteamServerConnectFailure, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Result, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamServer.NativeFieldInfoPtr_OnSteamServerConnectFailure, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x0004BEBC File Offset: 0x0004A0BC
		// (set) Token: 0x06000AB4 RID: 2740 RVA: 0x00002B6B File Offset: 0x00000D6B
		public unsafe static Action<Result> OnSteamServersDisconnected
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamServer.NativeFieldInfoPtr_OnSteamServersDisconnected, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Result>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamServer.NativeFieldInfoPtr_OnSteamServersDisconnected, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x0004BEE4 File Offset: 0x0004A0E4
		// (set) Token: 0x06000AB6 RID: 2742 RVA: 0x00002B7D File Offset: 0x00000D7D
		public unsafe static Action<SteamNetworkingAvailability> OnSteamNetAuthenticationStatus
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamServer.NativeFieldInfoPtr_OnSteamNetAuthenticationStatus, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SteamNetworkingAvailability>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamServer.NativeFieldInfoPtr_OnSteamNetAuthenticationStatus, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x0004BF0C File Offset: 0x0004A10C
		// (set) Token: 0x06000AB8 RID: 2744 RVA: 0x00002B8F File Offset: 0x00000D8F
		public unsafe static List<SteamClass> openInterfaces
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamServer.NativeFieldInfoPtr_openInterfaces, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SteamClass>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamServer.NativeFieldInfoPtr_openInterfaces, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x0004BF34 File Offset: 0x0004A134
		// (set) Token: 0x06000ABA RID: 2746 RVA: 0x00002BA1 File Offset: 0x00000DA1
		public unsafe static bool _dedicatedServer
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(SteamServer.NativeFieldInfoPtr__dedicatedServer, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamServer.NativeFieldInfoPtr__dedicatedServer, (void*)(&value));
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x0004BF50 File Offset: 0x0004A150
		// (set) Token: 0x06000ABC RID: 2748 RVA: 0x00002BAF File Offset: 0x00000DAF
		public unsafe static int _maxplayers
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamServer.NativeFieldInfoPtr__maxplayers, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamServer.NativeFieldInfoPtr__maxplayers, (void*)(&value));
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000ABD RID: 2749 RVA: 0x0004BF6C File Offset: 0x0004A16C
		// (set) Token: 0x06000ABE RID: 2750 RVA: 0x00002BBD File Offset: 0x00000DBD
		public unsafe static int _botcount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamServer.NativeFieldInfoPtr__botcount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamServer.NativeFieldInfoPtr__botcount, (void*)(&value));
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000ABF RID: 2751 RVA: 0x0004BF88 File Offset: 0x0004A188
		// (set) Token: 0x06000AC0 RID: 2752 RVA: 0x00002BCB File Offset: 0x00000DCB
		public unsafe static string _mapname
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamServer.NativeFieldInfoPtr__mapname, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamServer.NativeFieldInfoPtr__mapname, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x0004BFA8 File Offset: 0x0004A1A8
		// (set) Token: 0x06000AC2 RID: 2754 RVA: 0x00002BDD File Offset: 0x00000DDD
		public unsafe static string _modDir
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamServer.NativeFieldInfoPtr__modDir, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamServer.NativeFieldInfoPtr__modDir, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x0004BFC8 File Offset: 0x0004A1C8
		// (set) Token: 0x06000AC4 RID: 2756 RVA: 0x00002BEF File Offset: 0x00000DEF
		public unsafe static string _product
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamServer.NativeFieldInfoPtr__product, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamServer.NativeFieldInfoPtr__product, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x0004BFE8 File Offset: 0x0004A1E8
		// (set) Token: 0x06000AC6 RID: 2758 RVA: 0x00002C01 File Offset: 0x00000E01
		public unsafe static string _gameDescription
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamServer.NativeFieldInfoPtr__gameDescription, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamServer.NativeFieldInfoPtr__gameDescription, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000AC7 RID: 2759 RVA: 0x0004C008 File Offset: 0x0004A208
		// (set) Token: 0x06000AC8 RID: 2760 RVA: 0x00002C13 File Offset: 0x00000E13
		public unsafe static string _serverName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamServer.NativeFieldInfoPtr__serverName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamServer.NativeFieldInfoPtr__serverName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000AC9 RID: 2761 RVA: 0x0004C028 File Offset: 0x0004A228
		// (set) Token: 0x06000ACA RID: 2762 RVA: 0x00002C25 File Offset: 0x00000E25
		public unsafe static bool _passworded
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(SteamServer.NativeFieldInfoPtr__passworded, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamServer.NativeFieldInfoPtr__passworded, (void*)(&value));
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000ACB RID: 2763 RVA: 0x0004C044 File Offset: 0x0004A244
		// (set) Token: 0x06000ACC RID: 2764 RVA: 0x00002C33 File Offset: 0x00000E33
		public unsafe static string _gametags
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamServer.NativeFieldInfoPtr__gametags, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamServer.NativeFieldInfoPtr__gametags, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000ACD RID: 2765 RVA: 0x0004C064 File Offset: 0x0004A264
		// (set) Token: 0x06000ACE RID: 2766 RVA: 0x00002C45 File Offset: 0x00000E45
		public unsafe static Dictionary<string, string> KeyValue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamServer.NativeFieldInfoPtr_KeyValue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamServer.NativeFieldInfoPtr_KeyValue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001143 RID: 4419
		private static readonly IntPtr NativeFieldInfoPtr_OnValidateAuthTicketResponse;

		// Token: 0x04001144 RID: 4420
		private static readonly IntPtr NativeFieldInfoPtr_OnSteamServersConnected;

		// Token: 0x04001145 RID: 4421
		private static readonly IntPtr NativeFieldInfoPtr_OnSteamServerConnectFailure;

		// Token: 0x04001146 RID: 4422
		private static readonly IntPtr NativeFieldInfoPtr_OnSteamServersDisconnected;

		// Token: 0x04001147 RID: 4423
		private static readonly IntPtr NativeFieldInfoPtr_OnSteamNetAuthenticationStatus;

		// Token: 0x04001148 RID: 4424
		private static readonly IntPtr NativeFieldInfoPtr_openInterfaces;

		// Token: 0x04001149 RID: 4425
		private static readonly IntPtr NativeFieldInfoPtr__dedicatedServer;

		// Token: 0x0400114A RID: 4426
		private static readonly IntPtr NativeFieldInfoPtr__maxplayers;

		// Token: 0x0400114B RID: 4427
		private static readonly IntPtr NativeFieldInfoPtr__botcount;

		// Token: 0x0400114C RID: 4428
		private static readonly IntPtr NativeFieldInfoPtr__mapname;

		// Token: 0x0400114D RID: 4429
		private static readonly IntPtr NativeFieldInfoPtr__modDir;

		// Token: 0x0400114E RID: 4430
		private static readonly IntPtr NativeFieldInfoPtr__product;

		// Token: 0x0400114F RID: 4431
		private static readonly IntPtr NativeFieldInfoPtr__gameDescription;

		// Token: 0x04001150 RID: 4432
		private static readonly IntPtr NativeFieldInfoPtr__serverName;

		// Token: 0x04001151 RID: 4433
		private static readonly IntPtr NativeFieldInfoPtr__passworded;

		// Token: 0x04001152 RID: 4434
		private static readonly IntPtr NativeFieldInfoPtr__gametags;

		// Token: 0x04001153 RID: 4435
		private static readonly IntPtr NativeFieldInfoPtr_KeyValue;

		// Token: 0x04001154 RID: 4436
		private static readonly IntPtr NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamGameServer_0;

		// Token: 0x04001155 RID: 4437
		private static readonly IntPtr NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0;

		// Token: 0x04001156 RID: 4438
		private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Public_Static_get_Boolean_0;

		// Token: 0x04001157 RID: 4439
		private static readonly IntPtr NativeMethodInfoPtr_InstallEvents_Internal_Static_Void_0;

		// Token: 0x04001158 RID: 4440
		private static readonly IntPtr NativeMethodInfoPtr_add_OnValidateAuthTicketResponse_Public_Static_add_Void_Action_3_SteamId_SteamId_AuthResponse_0;

		// Token: 0x04001159 RID: 4441
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnValidateAuthTicketResponse_Public_Static_rem_Void_Action_3_SteamId_SteamId_AuthResponse_0;

		// Token: 0x0400115A RID: 4442
		private static readonly IntPtr NativeMethodInfoPtr_add_OnSteamServersConnected_Public_Static_add_Void_Action_0;

		// Token: 0x0400115B RID: 4443
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnSteamServersConnected_Public_Static_rem_Void_Action_0;

		// Token: 0x0400115C RID: 4444
		private static readonly IntPtr NativeMethodInfoPtr_add_OnSteamServerConnectFailure_Public_Static_add_Void_Action_2_Result_Boolean_0;

		// Token: 0x0400115D RID: 4445
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnSteamServerConnectFailure_Public_Static_rem_Void_Action_2_Result_Boolean_0;

		// Token: 0x0400115E RID: 4446
		private static readonly IntPtr NativeMethodInfoPtr_add_OnSteamServersDisconnected_Public_Static_add_Void_Action_1_Result_0;

		// Token: 0x0400115F RID: 4447
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnSteamServersDisconnected_Public_Static_rem_Void_Action_1_Result_0;

		// Token: 0x04001160 RID: 4448
		private static readonly IntPtr NativeMethodInfoPtr_add_OnSteamNetAuthenticationStatus_Public_Static_add_Void_Action_1_SteamNetworkingAvailability_0;

		// Token: 0x04001161 RID: 4449
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnSteamNetAuthenticationStatus_Public_Static_rem_Void_Action_1_SteamNetworkingAvailability_0;

		// Token: 0x04001162 RID: 4450
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Static_Void_AppId_SteamServerInit_Boolean_0;

		// Token: 0x04001163 RID: 4451
		private static readonly IntPtr NativeMethodInfoPtr_AddInterface_Internal_Static_Void_0;

		// Token: 0x04001164 RID: 4452
		private static readonly IntPtr NativeMethodInfoPtr_ShutdownInterfaces_Internal_Static_Void_0;

		// Token: 0x04001165 RID: 4453
		private static readonly IntPtr NativeMethodInfoPtr_Shutdown_Public_Static_Void_0;

		// Token: 0x04001166 RID: 4454
		private static readonly IntPtr NativeMethodInfoPtr_RunCallbacks_Public_Static_Void_0;

		// Token: 0x04001167 RID: 4455
		private static readonly IntPtr NativeMethodInfoPtr_get_DedicatedServer_Public_Static_get_Boolean_0;

		// Token: 0x04001168 RID: 4456
		private static readonly IntPtr NativeMethodInfoPtr_set_DedicatedServer_Public_Static_set_Void_Boolean_0;

		// Token: 0x04001169 RID: 4457
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxPlayers_Public_Static_get_Int32_0;

		// Token: 0x0400116A RID: 4458
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxPlayers_Public_Static_set_Void_Int32_0;

		// Token: 0x0400116B RID: 4459
		private static readonly IntPtr NativeMethodInfoPtr_get_BotCount_Public_Static_get_Int32_0;

		// Token: 0x0400116C RID: 4460
		private static readonly IntPtr NativeMethodInfoPtr_set_BotCount_Public_Static_set_Void_Int32_0;

		// Token: 0x0400116D RID: 4461
		private static readonly IntPtr NativeMethodInfoPtr_get_MapName_Public_Static_get_String_0;

		// Token: 0x0400116E RID: 4462
		private static readonly IntPtr NativeMethodInfoPtr_set_MapName_Public_Static_set_Void_String_0;

		// Token: 0x0400116F RID: 4463
		private static readonly IntPtr NativeMethodInfoPtr_get_ModDir_Public_Static_get_String_0;

		// Token: 0x04001170 RID: 4464
		private static readonly IntPtr NativeMethodInfoPtr_set_ModDir_Internal_Static_set_Void_String_0;

		// Token: 0x04001171 RID: 4465
		private static readonly IntPtr NativeMethodInfoPtr_get_Product_Public_Static_get_String_0;

		// Token: 0x04001172 RID: 4466
		private static readonly IntPtr NativeMethodInfoPtr_set_Product_Internal_Static_set_Void_String_0;

		// Token: 0x04001173 RID: 4467
		private static readonly IntPtr NativeMethodInfoPtr_get_GameDescription_Public_Static_get_String_0;

		// Token: 0x04001174 RID: 4468
		private static readonly IntPtr NativeMethodInfoPtr_set_GameDescription_Internal_Static_set_Void_String_0;

		// Token: 0x04001175 RID: 4469
		private static readonly IntPtr NativeMethodInfoPtr_get_ServerName_Public_Static_get_String_0;

		// Token: 0x04001176 RID: 4470
		private static readonly IntPtr NativeMethodInfoPtr_set_ServerName_Public_Static_set_Void_String_0;

		// Token: 0x04001177 RID: 4471
		private static readonly IntPtr NativeMethodInfoPtr_get_Passworded_Public_Static_get_Boolean_0;

		// Token: 0x04001178 RID: 4472
		private static readonly IntPtr NativeMethodInfoPtr_set_Passworded_Public_Static_set_Void_Boolean_0;

		// Token: 0x04001179 RID: 4473
		private static readonly IntPtr NativeMethodInfoPtr_get_GameTags_Public_Static_get_String_0;

		// Token: 0x0400117A RID: 4474
		private static readonly IntPtr NativeMethodInfoPtr_set_GameTags_Public_Static_set_Void_String_0;

		// Token: 0x0400117B RID: 4475
		private static readonly IntPtr NativeMethodInfoPtr_get_SteamId_Public_Static_get_SteamId_0;

		// Token: 0x0400117C RID: 4476
		private static readonly IntPtr NativeMethodInfoPtr_LogOnAnonymous_Public_Static_Void_0;

		// Token: 0x0400117D RID: 4477
		private static readonly IntPtr NativeMethodInfoPtr_LogOff_Public_Static_Void_0;

		// Token: 0x0400117E RID: 4478
		private static readonly IntPtr NativeMethodInfoPtr_get_LoggedOn_Public_Static_get_Boolean_0;

		// Token: 0x0400117F RID: 4479
		private static readonly IntPtr NativeMethodInfoPtr_get_PublicIp_Public_Static_get_IPAddress_0;

		// Token: 0x04001180 RID: 4480
		private static readonly IntPtr NativeMethodInfoPtr_set_AutomaticHeartbeats_Public_Static_set_Void_Boolean_0;

		// Token: 0x04001181 RID: 4481
		private static readonly IntPtr NativeMethodInfoPtr_set_AdvertiseServer_Public_Static_set_Void_Boolean_0;

		// Token: 0x04001182 RID: 4482
		private static readonly IntPtr NativeMethodInfoPtr_ForceHeartbeat_Public_Static_Void_0;

		// Token: 0x04001183 RID: 4483
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePlayer_Public_Static_Void_SteamId_String_Int32_0;

		// Token: 0x04001184 RID: 4484
		private static readonly IntPtr NativeMethodInfoPtr_SetKey_Public_Static_Void_String_String_0;

		// Token: 0x04001185 RID: 4485
		private static readonly IntPtr NativeMethodInfoPtr_ClearKeys_Public_Static_Void_0;

		// Token: 0x04001186 RID: 4486
		private static readonly IntPtr NativeMethodInfoPtr_BeginAuthSession_Public_Static_Boolean_Il2CppStructArray_1_Byte_SteamId_0;

		// Token: 0x04001187 RID: 4487
		private static readonly IntPtr NativeMethodInfoPtr_EndSession_Public_Static_Void_SteamId_0;

		// Token: 0x04001188 RID: 4488
		private static readonly IntPtr NativeMethodInfoPtr_GetOutgoingPacket_Public_Static_Boolean_byref_OutgoingPacket_0;

		// Token: 0x04001189 RID: 4489
		private static readonly IntPtr NativeMethodInfoPtr_HandleIncomingPacket_Public_Static_Void_Il2CppStructArray_1_Byte_Int32_UInt32_UInt16_0;

		// Token: 0x0400118A RID: 4490
		private static readonly IntPtr NativeMethodInfoPtr_HandleIncomingPacket_Public_Static_Void_IntPtr_Int32_UInt32_UInt16_0;

		// Token: 0x0400118B RID: 4491
		private static readonly IntPtr NativeMethodInfoPtr_UserHasLicenseForApp_Public_Static_UserHasLicenseForAppResult_SteamId_AppId_0;

		// Token: 0x0400118C RID: 4492
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000252 RID: 594
		[ObfuscatedName("Steamworks.SteamServer+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001DF4 RID: 7668 RVA: 0x00088B38 File Offset: 0x00086D38
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SteamServer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamServer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamServer.__c>.NativeClassPtr);
				SteamServer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServer.__c>.NativeClassPtr, "<>9");
				SteamServer.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServer.__c>.NativeClassPtr, "<>9__5_0");
				SteamServer.__c.NativeFieldInfoPtr___9__5_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServer.__c>.NativeClassPtr, "<>9__5_1");
				SteamServer.__c.NativeFieldInfoPtr___9__5_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServer.__c>.NativeClassPtr, "<>9__5_2");
				SteamServer.__c.NativeFieldInfoPtr___9__5_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServer.__c>.NativeClassPtr, "<>9__5_3");
				SteamServer.__c.NativeFieldInfoPtr___9__5_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServer.__c>.NativeClassPtr, "<>9__5_4");
				SteamServer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer.__c>.NativeClassPtr, 100665928);
				SteamServer.__c.NativeMethodInfoPtr__InstallEvents_b__5_0_Internal_Void_ValidateAuthTicketResponse_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer.__c>.NativeClassPtr, 100665929);
				SteamServer.__c.NativeMethodInfoPtr__InstallEvents_b__5_1_Internal_Void_SteamServersConnected_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer.__c>.NativeClassPtr, 100665930);
				SteamServer.__c.NativeMethodInfoPtr__InstallEvents_b__5_2_Internal_Void_SteamServerConnectFailure_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer.__c>.NativeClassPtr, 100665931);
				SteamServer.__c.NativeMethodInfoPtr__InstallEvents_b__5_3_Internal_Void_SteamServersDisconnected_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer.__c>.NativeClassPtr, 100665932);
				SteamServer.__c.NativeMethodInfoPtr__InstallEvents_b__5_4_Internal_Void_SteamNetAuthenticationStatus_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServer.__c>.NativeClassPtr, 100665933);
			}

			// Token: 0x06001DF5 RID: 7669 RVA: 0x00088C54 File Offset: 0x00086E54
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamServer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DF6 RID: 7670 RVA: 0x00088C90 File Offset: 0x00086E90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942293, XrefRangeEnd = 942297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__5_0(ValidateAuthTicketResponse_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.__c.NativeMethodInfoPtr__InstallEvents_b__5_0_Internal_Void_ValidateAuthTicketResponse_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001DF7 RID: 7671 RVA: 0x00088CD0 File Offset: 0x00086ED0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942297, XrefRangeEnd = 942301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__5_1(SteamServersConnected_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.__c.NativeMethodInfoPtr__InstallEvents_b__5_1_Internal_Void_SteamServersConnected_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001DF8 RID: 7672 RVA: 0x00088D10 File Offset: 0x00086F10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942301, XrefRangeEnd = 942305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__5_2(SteamServerConnectFailure_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.__c.NativeMethodInfoPtr__InstallEvents_b__5_2_Internal_Void_SteamServerConnectFailure_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001DF9 RID: 7673 RVA: 0x00088D50 File Offset: 0x00086F50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942305, XrefRangeEnd = 942309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__5_3(SteamServersDisconnected_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.__c.NativeMethodInfoPtr__InstallEvents_b__5_3_Internal_Void_SteamServersDisconnected_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001DFA RID: 7674 RVA: 0x00088D90 File Offset: 0x00086F90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942309, XrefRangeEnd = 942313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__5_4(SteamNetAuthenticationStatus_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServer.__c.NativeMethodInfoPtr__InstallEvents_b__5_4_Internal_Void_SteamNetAuthenticationStatus_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001DFB RID: 7675 RVA: 0x0000AAC5 File Offset: 0x00008CC5
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000791 RID: 1937
			// (get) Token: 0x06001DFC RID: 7676 RVA: 0x00088DD8 File Offset: 0x00086FD8
			// (set) Token: 0x06001DFD RID: 7677 RVA: 0x0000AACE File Offset: 0x00008CCE
			public unsafe static SteamServer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamServer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SteamServer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamServer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000792 RID: 1938
			// (get) Token: 0x06001DFE RID: 7678 RVA: 0x00088E00 File Offset: 0x00087000
			// (set) Token: 0x06001DFF RID: 7679 RVA: 0x0000AAE0 File Offset: 0x00008CE0
			public unsafe static Action<ValidateAuthTicketResponse_t> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamServer.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ValidateAuthTicketResponse_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamServer.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000793 RID: 1939
			// (get) Token: 0x06001E00 RID: 7680 RVA: 0x00088E28 File Offset: 0x00087028
			// (set) Token: 0x06001E01 RID: 7681 RVA: 0x0000AAF2 File Offset: 0x00008CF2
			public unsafe static Action<SteamServersConnected_t> __9__5_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamServer.__c.NativeFieldInfoPtr___9__5_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SteamServersConnected_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamServer.__c.NativeFieldInfoPtr___9__5_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000794 RID: 1940
			// (get) Token: 0x06001E02 RID: 7682 RVA: 0x00088E50 File Offset: 0x00087050
			// (set) Token: 0x06001E03 RID: 7683 RVA: 0x0000AB04 File Offset: 0x00008D04
			public unsafe static Action<SteamServerConnectFailure_t> __9__5_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamServer.__c.NativeFieldInfoPtr___9__5_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SteamServerConnectFailure_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamServer.__c.NativeFieldInfoPtr___9__5_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000795 RID: 1941
			// (get) Token: 0x06001E04 RID: 7684 RVA: 0x00088E78 File Offset: 0x00087078
			// (set) Token: 0x06001E05 RID: 7685 RVA: 0x0000AB16 File Offset: 0x00008D16
			public unsafe static Action<SteamServersDisconnected_t> __9__5_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamServer.__c.NativeFieldInfoPtr___9__5_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SteamServersDisconnected_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamServer.__c.NativeFieldInfoPtr___9__5_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000796 RID: 1942
			// (get) Token: 0x06001E06 RID: 7686 RVA: 0x00088EA0 File Offset: 0x000870A0
			// (set) Token: 0x06001E07 RID: 7687 RVA: 0x0000AB28 File Offset: 0x00008D28
			public unsafe static Action<SteamNetAuthenticationStatus_t> __9__5_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamServer.__c.NativeFieldInfoPtr___9__5_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SteamNetAuthenticationStatus_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamServer.__c.NativeFieldInfoPtr___9__5_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002177 RID: 8567
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002178 RID: 8568
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04002179 RID: 8569
			private static readonly IntPtr NativeFieldInfoPtr___9__5_1;

			// Token: 0x0400217A RID: 8570
			private static readonly IntPtr NativeFieldInfoPtr___9__5_2;

			// Token: 0x0400217B RID: 8571
			private static readonly IntPtr NativeFieldInfoPtr___9__5_3;

			// Token: 0x0400217C RID: 8572
			private static readonly IntPtr NativeFieldInfoPtr___9__5_4;

			// Token: 0x0400217D RID: 8573
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400217E RID: 8574
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__5_0_Internal_Void_ValidateAuthTicketResponse_t_0;

			// Token: 0x0400217F RID: 8575
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__5_1_Internal_Void_SteamServersConnected_t_0;

			// Token: 0x04002180 RID: 8576
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__5_2_Internal_Void_SteamServerConnectFailure_t_0;

			// Token: 0x04002181 RID: 8577
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__5_3_Internal_Void_SteamServersDisconnected_t_0;

			// Token: 0x04002182 RID: 8578
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__5_4_Internal_Void_SteamNetAuthenticationStatus_t_0;
		}

		// Token: 0x02000253 RID: 595
		private sealed class MethodInfoStoreGeneric_AddInterface_Internal_Static_Void_0<T>
		{
			// Token: 0x04002183 RID: 8579
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SteamServer.NativeMethodInfoPtr_AddInterface_Internal_Static_Void_0, Il2CppClassPointerStore<SteamServer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
