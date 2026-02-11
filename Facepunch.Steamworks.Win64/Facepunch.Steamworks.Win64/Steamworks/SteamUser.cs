using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Diagnostics;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x020000B0 RID: 176
	public class SteamUser : SteamClientClass<SteamUser>
	{
		// Token: 0x06000AFE RID: 2814 RVA: 0x0004CDA0 File Offset: 0x0004AFA0
		// Note: this type is marked as 'beforefieldinit'.
		static SteamUser()
		{
			Il2CppClassPointerStore<SteamUser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "SteamUser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUser>.NativeClassPtr);
			SteamUser.NativeFieldInfoPtr_richPresence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, "richPresence");
			SteamUser.NativeFieldInfoPtr_OnSteamServersConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, "OnSteamServersConnected");
			SteamUser.NativeFieldInfoPtr_OnSteamServerConnectFailure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, "OnSteamServerConnectFailure");
			SteamUser.NativeFieldInfoPtr_OnSteamServersDisconnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, "OnSteamServersDisconnected");
			SteamUser.NativeFieldInfoPtr_OnClientGameServerDeny = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, "OnClientGameServerDeny");
			SteamUser.NativeFieldInfoPtr_OnLicensesUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, "OnLicensesUpdated");
			SteamUser.NativeFieldInfoPtr_OnValidateAuthTicketResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, "OnValidateAuthTicketResponse");
			SteamUser.NativeFieldInfoPtr_OnGetAuthSessionTicketResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, "OnGetAuthSessionTicketResponse");
			SteamUser.NativeFieldInfoPtr_OnMicroTxnAuthorizationResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, "OnMicroTxnAuthorizationResponse");
			SteamUser.NativeFieldInfoPtr_OnGameWebCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, "OnGameWebCallback");
			SteamUser.NativeFieldInfoPtr_OnDurationControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, "OnDurationControl");
			SteamUser.NativeFieldInfoPtr__recordingVoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, "_recordingVoice");
			SteamUser.NativeFieldInfoPtr_readBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, "readBuffer");
			SteamUser.NativeFieldInfoPtr_sampleRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, "sampleRate");
			SteamUser.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100665995);
			SteamUser.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100665996);
			SteamUser.NativeMethodInfoPtr_InstallEvents_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100665997);
			SteamUser.NativeMethodInfoPtr_add_OnSteamServersConnected_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100665998);
			SteamUser.NativeMethodInfoPtr_remove_OnSteamServersConnected_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100665999);
			SteamUser.NativeMethodInfoPtr_add_OnSteamServerConnectFailure_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666000);
			SteamUser.NativeMethodInfoPtr_remove_OnSteamServerConnectFailure_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666001);
			SteamUser.NativeMethodInfoPtr_add_OnSteamServersDisconnected_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666002);
			SteamUser.NativeMethodInfoPtr_remove_OnSteamServersDisconnected_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666003);
			SteamUser.NativeMethodInfoPtr_add_OnClientGameServerDeny_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666004);
			SteamUser.NativeMethodInfoPtr_remove_OnClientGameServerDeny_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666005);
			SteamUser.NativeMethodInfoPtr_add_OnLicensesUpdated_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666006);
			SteamUser.NativeMethodInfoPtr_remove_OnLicensesUpdated_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666007);
			SteamUser.NativeMethodInfoPtr_add_OnValidateAuthTicketResponse_Public_Static_add_Void_Action_3_SteamId_SteamId_AuthResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666008);
			SteamUser.NativeMethodInfoPtr_remove_OnValidateAuthTicketResponse_Public_Static_rem_Void_Action_3_SteamId_SteamId_AuthResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666009);
			SteamUser.NativeMethodInfoPtr_add_OnGetAuthSessionTicketResponse_Internal_Static_add_Void_Action_1_GetAuthSessionTicketResponse_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666010);
			SteamUser.NativeMethodInfoPtr_remove_OnGetAuthSessionTicketResponse_Internal_Static_rem_Void_Action_1_GetAuthSessionTicketResponse_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666011);
			SteamUser.NativeMethodInfoPtr_add_OnMicroTxnAuthorizationResponse_Public_Static_add_Void_Action_3_AppId_UInt64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666012);
			SteamUser.NativeMethodInfoPtr_remove_OnMicroTxnAuthorizationResponse_Public_Static_rem_Void_Action_3_AppId_UInt64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666013);
			SteamUser.NativeMethodInfoPtr_add_OnGameWebCallback_Public_Static_add_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666014);
			SteamUser.NativeMethodInfoPtr_remove_OnGameWebCallback_Public_Static_rem_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666015);
			SteamUser.NativeMethodInfoPtr_add_OnDurationControl_Public_Static_add_Void_Action_1_DurationControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666016);
			SteamUser.NativeMethodInfoPtr_remove_OnDurationControl_Public_Static_rem_Void_Action_1_DurationControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666017);
			SteamUser.NativeMethodInfoPtr_get_VoiceRecord_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666018);
			SteamUser.NativeMethodInfoPtr_set_VoiceRecord_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666019);
			SteamUser.NativeMethodInfoPtr_get_HasVoiceData_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666020);
			SteamUser.NativeMethodInfoPtr_ReadVoiceData_Public_Static_Int32_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666021);
			SteamUser.NativeMethodInfoPtr_ReadVoiceDataBytes_Public_Static_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666022);
			SteamUser.NativeMethodInfoPtr_get_SampleRate_Public_Static_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666023);
			SteamUser.NativeMethodInfoPtr_set_SampleRate_Public_Static_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666024);
			SteamUser.NativeMethodInfoPtr_get_OptimalSampleRate_Public_Static_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666025);
			SteamUser.NativeMethodInfoPtr_DecompressVoice_Public_Static_Int32_Stream_Int32_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666026);
			SteamUser.NativeMethodInfoPtr_DecompressVoice_Public_Static_Int32_Il2CppStructArray_1_Byte_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666027);
			SteamUser.NativeMethodInfoPtr_DecompressVoice_Public_Static_Int32_IntPtr_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666028);
			SteamUser.NativeMethodInfoPtr_GetAuthSessionTicket_Public_Static_AuthTicket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666029);
			SteamUser.NativeMethodInfoPtr_GetAuthSessionTicketAsync_Public_Static_Task_1_AuthTicket_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666030);
			SteamUser.NativeMethodInfoPtr_BeginAuthSession_Public_Static_BeginAuthResult_Il2CppStructArray_1_Byte_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666031);
			SteamUser.NativeMethodInfoPtr_EndAuthSession_Public_Static_Void_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666032);
			SteamUser.NativeMethodInfoPtr_get_IsBehindNAT_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666033);
			SteamUser.NativeMethodInfoPtr_get_SteamLevel_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666034);
			SteamUser.NativeMethodInfoPtr_GetStoreAuthUrlAsync_Public_Static_Task_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666035);
			SteamUser.NativeMethodInfoPtr_get_IsPhoneVerified_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666036);
			SteamUser.NativeMethodInfoPtr_get_IsTwoFactorEnabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666037);
			SteamUser.NativeMethodInfoPtr_get_IsPhoneIdentifying_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666038);
			SteamUser.NativeMethodInfoPtr_get_IsPhoneRequiringVerification_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666039);
			SteamUser.NativeMethodInfoPtr_RequestEncryptedAppTicketAsync_Public_Static_Task_1_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666040);
			SteamUser.NativeMethodInfoPtr_RequestEncryptedAppTicketAsync_Public_Static_Task_1_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666041);
			SteamUser.NativeMethodInfoPtr_GetDurationControl_Public_Static_Task_1_DurationControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666042);
			SteamUser.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100666043);
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000AFF RID: 2815 RVA: 0x0004D2BC File Offset: 0x0004B4BC
		public unsafe static ISteamUser Internal
		{
			[CallerCount(30)]
			[CachedScanResults(RefRangeStart = 944245, RefRangeEnd = 944275, XrefRangeStart = 944242, XrefRangeEnd = 944245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamUser_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISteamUser>(intPtr3) : null;
			}
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x0004D2F0 File Offset: 0x0004B4F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944275, XrefRangeEnd = 944313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeInterface(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref server;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamUser.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x0004D33C File Offset: 0x0004B53C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 944505, RefRangeEnd = 944506, XrefRangeStart = 944313, XrefRangeEnd = 944505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InstallEvents()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_InstallEvents_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x0004D364 File Offset: 0x0004B564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944506, XrefRangeEnd = 944517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnSteamServersConnected(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_add_OnSteamServersConnected_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x0004D39C File Offset: 0x0004B59C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944517, XrefRangeEnd = 944528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnSteamServersConnected(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_remove_OnSteamServersConnected_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x0004D3D4 File Offset: 0x0004B5D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944528, XrefRangeEnd = 944539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnSteamServerConnectFailure(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_add_OnSteamServerConnectFailure_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x0004D40C File Offset: 0x0004B60C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944539, XrefRangeEnd = 944550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnSteamServerConnectFailure(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_remove_OnSteamServerConnectFailure_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x0004D444 File Offset: 0x0004B644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944550, XrefRangeEnd = 944561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnSteamServersDisconnected(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_add_OnSteamServersDisconnected_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x0004D47C File Offset: 0x0004B67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944561, XrefRangeEnd = 944572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnSteamServersDisconnected(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_remove_OnSteamServersDisconnected_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x0004D4B4 File Offset: 0x0004B6B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944572, XrefRangeEnd = 944583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnClientGameServerDeny(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_add_OnClientGameServerDeny_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x0004D4EC File Offset: 0x0004B6EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944583, XrefRangeEnd = 944594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnClientGameServerDeny(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_remove_OnClientGameServerDeny_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x0004D524 File Offset: 0x0004B724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944594, XrefRangeEnd = 944605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnLicensesUpdated(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_add_OnLicensesUpdated_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x0004D55C File Offset: 0x0004B75C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944605, XrefRangeEnd = 944616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnLicensesUpdated(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_remove_OnLicensesUpdated_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x0004D594 File Offset: 0x0004B794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944616, XrefRangeEnd = 944629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnValidateAuthTicketResponse(Action<SteamId, SteamId, AuthResponse> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_add_OnValidateAuthTicketResponse_Public_Static_add_Void_Action_3_SteamId_SteamId_AuthResponse_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x0004D5CC File Offset: 0x0004B7CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944629, XrefRangeEnd = 944642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnValidateAuthTicketResponse(Action<SteamId, SteamId, AuthResponse> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_remove_OnValidateAuthTicketResponse_Public_Static_rem_Void_Action_3_SteamId_SteamId_AuthResponse_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x0004D604 File Offset: 0x0004B804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944642, XrefRangeEnd = 944655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnGetAuthSessionTicketResponse(Action<GetAuthSessionTicketResponse_t> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_add_OnGetAuthSessionTicketResponse_Internal_Static_add_Void_Action_1_GetAuthSessionTicketResponse_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x0004D63C File Offset: 0x0004B83C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944655, XrefRangeEnd = 944668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnGetAuthSessionTicketResponse(Action<GetAuthSessionTicketResponse_t> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_remove_OnGetAuthSessionTicketResponse_Internal_Static_rem_Void_Action_1_GetAuthSessionTicketResponse_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x0004D674 File Offset: 0x0004B874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944668, XrefRangeEnd = 944681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnMicroTxnAuthorizationResponse(Action<AppId, ulong, bool> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_add_OnMicroTxnAuthorizationResponse_Public_Static_add_Void_Action_3_AppId_UInt64_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x0004D6AC File Offset: 0x0004B8AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944681, XrefRangeEnd = 944694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnMicroTxnAuthorizationResponse(Action<AppId, ulong, bool> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_remove_OnMicroTxnAuthorizationResponse_Public_Static_rem_Void_Action_3_AppId_UInt64_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x0004D6E4 File Offset: 0x0004B8E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944694, XrefRangeEnd = 944707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnGameWebCallback(Action<string> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_add_OnGameWebCallback_Public_Static_add_Void_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x0004D71C File Offset: 0x0004B91C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944707, XrefRangeEnd = 944720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnGameWebCallback(Action<string> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_remove_OnGameWebCallback_Public_Static_rem_Void_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x0004D754 File Offset: 0x0004B954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944720, XrefRangeEnd = 944733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnDurationControl(Action<DurationControl> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_add_OnDurationControl_Public_Static_add_Void_Action_1_DurationControl_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x0004D78C File Offset: 0x0004B98C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944733, XrefRangeEnd = 944746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnDurationControl(Action<DurationControl> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_remove_OnDurationControl_Public_Static_rem_Void_Action_1_DurationControl_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000B16 RID: 2838 RVA: 0x0004D7C4 File Offset: 0x0004B9C4
		// (set) Token: 0x06000B17 RID: 2839 RVA: 0x0004D7F4 File Offset: 0x0004B9F4
		public unsafe static bool VoiceRecord
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944746, XrefRangeEnd = 944750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_get_VoiceRecord_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944750, XrefRangeEnd = 944762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_set_VoiceRecord_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000B18 RID: 2840 RVA: 0x0004D828 File Offset: 0x0004BA28
		public unsafe static bool HasVoiceData
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 944767, RefRangeEnd = 944769, XrefRangeStart = 944762, XrefRangeEnd = 944767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_get_HasVoiceData_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x0004D858 File Offset: 0x0004BA58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944769, XrefRangeEnd = 944786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ReadVoiceData(Stream stream)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_ReadVoiceData_Public_Static_Int32_Stream_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x0004D89C File Offset: 0x0004BA9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944786, XrefRangeEnd = 944807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> ReadVoiceDataBytes()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_ReadVoiceDataBytes_Public_Static_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x0004D8D0 File Offset: 0x0004BAD0
		// (set) Token: 0x06000B1C RID: 2844 RVA: 0x0004D900 File Offset: 0x0004BB00
		public unsafe static uint SampleRate
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944807, XrefRangeEnd = 944811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_get_SampleRate_Public_Static_get_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944811, XrefRangeEnd = 944827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_set_SampleRate_Public_Static_set_Void_UInt32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x0004D934 File Offset: 0x0004BB34
		public unsafe static uint OptimalSampleRate
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944827, XrefRangeEnd = 944833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_get_OptimalSampleRate_Public_Static_get_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x0004D964 File Offset: 0x0004BB64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944833, XrefRangeEnd = 944862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DecompressVoice(Stream input, int length, Stream output)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_DecompressVoice_Public_Static_Int32_Stream_Int32_Stream_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x0004D9C8 File Offset: 0x0004BBC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944862, XrefRangeEnd = 944879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DecompressVoice(Il2CppStructArray<byte> from, Stream output)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(from);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_DecompressVoice_Public_Static_Int32_Il2CppStructArray_1_Byte_Stream_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x0004DA1C File Offset: 0x0004BC1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944879, XrefRangeEnd = 944888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DecompressVoice(IntPtr from, int length, IntPtr to, int bufferSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_DecompressVoice_Public_Static_Int32_IntPtr_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x0004DA84 File Offset: 0x0004BC84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944888, XrefRangeEnd = 944910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AuthTicket GetAuthSessionTicket()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_GetAuthSessionTicket_Public_Static_AuthTicket_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AuthTicket>(intPtr3) : null;
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x0004DAB8 File Offset: 0x0004BCB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 944923, RefRangeEnd = 944924, XrefRangeStart = 944910, XrefRangeEnd = 944923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<AuthTicket> GetAuthSessionTicketAsync(double timeoutSeconds = 10.0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeoutSeconds;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_GetAuthSessionTicketAsync_Public_Static_Task_1_AuthTicket_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<AuthTicket>>(intPtr3) : null;
			}
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x0004DAF8 File Offset: 0x0004BCF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944924, XrefRangeEnd = 944931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BeginAuthResult BeginAuthSession(Il2CppStructArray<byte> ticketData, SteamId steamid)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ticketData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_BeginAuthSession_Public_Static_BeginAuthResult_Il2CppStructArray_1_Byte_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x0004DB48 File Offset: 0x0004BD48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944931, XrefRangeEnd = 944937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndAuthSession(SteamId steamid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_EndAuthSession_Public_Static_Void_SteamId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000B25 RID: 2853 RVA: 0x0004DB7C File Offset: 0x0004BD7C
		public unsafe static bool IsBehindNAT
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944937, XrefRangeEnd = 944943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_get_IsBehindNAT_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000B26 RID: 2854 RVA: 0x0004DBAC File Offset: 0x0004BDAC
		public unsafe static int SteamLevel
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944943, XrefRangeEnd = 944949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_get_SteamLevel_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x0004DBDC File Offset: 0x0004BDDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944949, XrefRangeEnd = 944963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<string> GetStoreAuthUrlAsync(string url)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_GetStoreAuthUrlAsync_Public_Static_Task_1_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<string>>(intPtr3) : null;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000B28 RID: 2856 RVA: 0x0004DC20 File Offset: 0x0004BE20
		public unsafe static bool IsPhoneVerified
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944963, XrefRangeEnd = 944969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_get_IsPhoneVerified_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000B29 RID: 2857 RVA: 0x0004DC50 File Offset: 0x0004BE50
		public unsafe static bool IsTwoFactorEnabled
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944969, XrefRangeEnd = 944975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_get_IsTwoFactorEnabled_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000B2A RID: 2858 RVA: 0x0004DC80 File Offset: 0x0004BE80
		public unsafe static bool IsPhoneIdentifying
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944975, XrefRangeEnd = 944981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_get_IsPhoneIdentifying_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000B2B RID: 2859 RVA: 0x0004DCB0 File Offset: 0x0004BEB0
		public unsafe static bool IsPhoneRequiringVerification
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944981, XrefRangeEnd = 944987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_get_IsPhoneRequiringVerification_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x0004DCE0 File Offset: 0x0004BEE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944987, XrefRangeEnd = 945001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Il2CppStructArray<byte>> RequestEncryptedAppTicketAsync(Il2CppStructArray<byte> dataToInclude)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataToInclude);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_RequestEncryptedAppTicketAsync_Public_Static_Task_1_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Il2CppStructArray<byte>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x0004DD24 File Offset: 0x0004BF24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945001, XrefRangeEnd = 945014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Il2CppStructArray<byte>> RequestEncryptedAppTicketAsync()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_RequestEncryptedAppTicketAsync_Public_Static_Task_1_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Il2CppStructArray<byte>>>(intPtr3) : null;
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x0004DD58 File Offset: 0x0004BF58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945014, XrefRangeEnd = 945027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<DurationControl> GetDurationControl()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_GetDurationControl_Public_Static_Task_1_DurationControl_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<DurationControl>>(intPtr3) : null;
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x0004DD8C File Offset: 0x0004BF8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945027, XrefRangeEnd = 945030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamUser()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamUser>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x00002CB1 File Offset: 0x00000EB1
		public SteamUser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000B31 RID: 2865 RVA: 0x0004DDC8 File Offset: 0x0004BFC8
		// (set) Token: 0x06000B32 RID: 2866 RVA: 0x00002CBA File Offset: 0x00000EBA
		public unsafe static Dictionary<string, string> richPresence
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamUser.NativeFieldInfoPtr_richPresence, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamUser.NativeFieldInfoPtr_richPresence, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000B33 RID: 2867 RVA: 0x0004DDF0 File Offset: 0x0004BFF0
		// (set) Token: 0x06000B34 RID: 2868 RVA: 0x00002CCC File Offset: 0x00000ECC
		public unsafe static Action OnSteamServersConnected
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamUser.NativeFieldInfoPtr_OnSteamServersConnected, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamUser.NativeFieldInfoPtr_OnSteamServersConnected, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000B35 RID: 2869 RVA: 0x0004DE18 File Offset: 0x0004C018
		// (set) Token: 0x06000B36 RID: 2870 RVA: 0x00002CDE File Offset: 0x00000EDE
		public unsafe static Action OnSteamServerConnectFailure
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamUser.NativeFieldInfoPtr_OnSteamServerConnectFailure, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamUser.NativeFieldInfoPtr_OnSteamServerConnectFailure, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000B37 RID: 2871 RVA: 0x0004DE40 File Offset: 0x0004C040
		// (set) Token: 0x06000B38 RID: 2872 RVA: 0x00002CF0 File Offset: 0x00000EF0
		public unsafe static Action OnSteamServersDisconnected
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamUser.NativeFieldInfoPtr_OnSteamServersDisconnected, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamUser.NativeFieldInfoPtr_OnSteamServersDisconnected, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000B39 RID: 2873 RVA: 0x0004DE68 File Offset: 0x0004C068
		// (set) Token: 0x06000B3A RID: 2874 RVA: 0x00002D02 File Offset: 0x00000F02
		public unsafe static Action OnClientGameServerDeny
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamUser.NativeFieldInfoPtr_OnClientGameServerDeny, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamUser.NativeFieldInfoPtr_OnClientGameServerDeny, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000B3B RID: 2875 RVA: 0x0004DE90 File Offset: 0x0004C090
		// (set) Token: 0x06000B3C RID: 2876 RVA: 0x00002D14 File Offset: 0x00000F14
		public unsafe static Action OnLicensesUpdated
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamUser.NativeFieldInfoPtr_OnLicensesUpdated, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamUser.NativeFieldInfoPtr_OnLicensesUpdated, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000B3D RID: 2877 RVA: 0x0004DEB8 File Offset: 0x0004C0B8
		// (set) Token: 0x06000B3E RID: 2878 RVA: 0x00002D26 File Offset: 0x00000F26
		public unsafe static Action<SteamId, SteamId, AuthResponse> OnValidateAuthTicketResponse
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamUser.NativeFieldInfoPtr_OnValidateAuthTicketResponse, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SteamId, SteamId, AuthResponse>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamUser.NativeFieldInfoPtr_OnValidateAuthTicketResponse, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000B3F RID: 2879 RVA: 0x0004DEE0 File Offset: 0x0004C0E0
		// (set) Token: 0x06000B40 RID: 2880 RVA: 0x00002D38 File Offset: 0x00000F38
		public unsafe static Action<GetAuthSessionTicketResponse_t> OnGetAuthSessionTicketResponse
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamUser.NativeFieldInfoPtr_OnGetAuthSessionTicketResponse, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GetAuthSessionTicketResponse_t>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamUser.NativeFieldInfoPtr_OnGetAuthSessionTicketResponse, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000B41 RID: 2881 RVA: 0x0004DF08 File Offset: 0x0004C108
		// (set) Token: 0x06000B42 RID: 2882 RVA: 0x00002D4A File Offset: 0x00000F4A
		public unsafe static Action<AppId, ulong, bool> OnMicroTxnAuthorizationResponse
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamUser.NativeFieldInfoPtr_OnMicroTxnAuthorizationResponse, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AppId, ulong, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamUser.NativeFieldInfoPtr_OnMicroTxnAuthorizationResponse, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000B43 RID: 2883 RVA: 0x0004DF30 File Offset: 0x0004C130
		// (set) Token: 0x06000B44 RID: 2884 RVA: 0x00002D5C File Offset: 0x00000F5C
		public unsafe static Action<string> OnGameWebCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamUser.NativeFieldInfoPtr_OnGameWebCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamUser.NativeFieldInfoPtr_OnGameWebCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000B45 RID: 2885 RVA: 0x0004DF58 File Offset: 0x0004C158
		// (set) Token: 0x06000B46 RID: 2886 RVA: 0x00002D6E File Offset: 0x00000F6E
		public unsafe static Action<DurationControl> OnDurationControl
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamUser.NativeFieldInfoPtr_OnDurationControl, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<DurationControl>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamUser.NativeFieldInfoPtr_OnDurationControl, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000B47 RID: 2887 RVA: 0x0004DF80 File Offset: 0x0004C180
		// (set) Token: 0x06000B48 RID: 2888 RVA: 0x00002D80 File Offset: 0x00000F80
		public unsafe static bool _recordingVoice
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(SteamUser.NativeFieldInfoPtr__recordingVoice, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamUser.NativeFieldInfoPtr__recordingVoice, (void*)(&value));
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000B49 RID: 2889 RVA: 0x0004DF9C File Offset: 0x0004C19C
		// (set) Token: 0x06000B4A RID: 2890 RVA: 0x00002D8E File Offset: 0x00000F8E
		public unsafe static Il2CppStructArray<byte> readBuffer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamUser.NativeFieldInfoPtr_readBuffer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamUser.NativeFieldInfoPtr_readBuffer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000B4B RID: 2891 RVA: 0x0004DFC4 File Offset: 0x0004C1C4
		// (set) Token: 0x06000B4C RID: 2892 RVA: 0x00002DA0 File Offset: 0x00000FA0
		public unsafe static uint sampleRate
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(SteamUser.NativeFieldInfoPtr_sampleRate, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamUser.NativeFieldInfoPtr_sampleRate, (void*)(&value));
			}
		}

		// Token: 0x040011B4 RID: 4532
		private static readonly IntPtr NativeFieldInfoPtr_richPresence;

		// Token: 0x040011B5 RID: 4533
		private static readonly IntPtr NativeFieldInfoPtr_OnSteamServersConnected;

		// Token: 0x040011B6 RID: 4534
		private static readonly IntPtr NativeFieldInfoPtr_OnSteamServerConnectFailure;

		// Token: 0x040011B7 RID: 4535
		private static readonly IntPtr NativeFieldInfoPtr_OnSteamServersDisconnected;

		// Token: 0x040011B8 RID: 4536
		private static readonly IntPtr NativeFieldInfoPtr_OnClientGameServerDeny;

		// Token: 0x040011B9 RID: 4537
		private static readonly IntPtr NativeFieldInfoPtr_OnLicensesUpdated;

		// Token: 0x040011BA RID: 4538
		private static readonly IntPtr NativeFieldInfoPtr_OnValidateAuthTicketResponse;

		// Token: 0x040011BB RID: 4539
		private static readonly IntPtr NativeFieldInfoPtr_OnGetAuthSessionTicketResponse;

		// Token: 0x040011BC RID: 4540
		private static readonly IntPtr NativeFieldInfoPtr_OnMicroTxnAuthorizationResponse;

		// Token: 0x040011BD RID: 4541
		private static readonly IntPtr NativeFieldInfoPtr_OnGameWebCallback;

		// Token: 0x040011BE RID: 4542
		private static readonly IntPtr NativeFieldInfoPtr_OnDurationControl;

		// Token: 0x040011BF RID: 4543
		private static readonly IntPtr NativeFieldInfoPtr__recordingVoice;

		// Token: 0x040011C0 RID: 4544
		private static readonly IntPtr NativeFieldInfoPtr_readBuffer;

		// Token: 0x040011C1 RID: 4545
		private static readonly IntPtr NativeFieldInfoPtr_sampleRate;

		// Token: 0x040011C2 RID: 4546
		private static readonly IntPtr NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamUser_0;

		// Token: 0x040011C3 RID: 4547
		private static readonly IntPtr NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0;

		// Token: 0x040011C4 RID: 4548
		private static readonly IntPtr NativeMethodInfoPtr_InstallEvents_Internal_Static_Void_0;

		// Token: 0x040011C5 RID: 4549
		private static readonly IntPtr NativeMethodInfoPtr_add_OnSteamServersConnected_Public_Static_add_Void_Action_0;

		// Token: 0x040011C6 RID: 4550
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnSteamServersConnected_Public_Static_rem_Void_Action_0;

		// Token: 0x040011C7 RID: 4551
		private static readonly IntPtr NativeMethodInfoPtr_add_OnSteamServerConnectFailure_Public_Static_add_Void_Action_0;

		// Token: 0x040011C8 RID: 4552
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnSteamServerConnectFailure_Public_Static_rem_Void_Action_0;

		// Token: 0x040011C9 RID: 4553
		private static readonly IntPtr NativeMethodInfoPtr_add_OnSteamServersDisconnected_Public_Static_add_Void_Action_0;

		// Token: 0x040011CA RID: 4554
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnSteamServersDisconnected_Public_Static_rem_Void_Action_0;

		// Token: 0x040011CB RID: 4555
		private static readonly IntPtr NativeMethodInfoPtr_add_OnClientGameServerDeny_Public_Static_add_Void_Action_0;

		// Token: 0x040011CC RID: 4556
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnClientGameServerDeny_Public_Static_rem_Void_Action_0;

		// Token: 0x040011CD RID: 4557
		private static readonly IntPtr NativeMethodInfoPtr_add_OnLicensesUpdated_Public_Static_add_Void_Action_0;

		// Token: 0x040011CE RID: 4558
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnLicensesUpdated_Public_Static_rem_Void_Action_0;

		// Token: 0x040011CF RID: 4559
		private static readonly IntPtr NativeMethodInfoPtr_add_OnValidateAuthTicketResponse_Public_Static_add_Void_Action_3_SteamId_SteamId_AuthResponse_0;

		// Token: 0x040011D0 RID: 4560
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnValidateAuthTicketResponse_Public_Static_rem_Void_Action_3_SteamId_SteamId_AuthResponse_0;

		// Token: 0x040011D1 RID: 4561
		private static readonly IntPtr NativeMethodInfoPtr_add_OnGetAuthSessionTicketResponse_Internal_Static_add_Void_Action_1_GetAuthSessionTicketResponse_t_0;

		// Token: 0x040011D2 RID: 4562
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnGetAuthSessionTicketResponse_Internal_Static_rem_Void_Action_1_GetAuthSessionTicketResponse_t_0;

		// Token: 0x040011D3 RID: 4563
		private static readonly IntPtr NativeMethodInfoPtr_add_OnMicroTxnAuthorizationResponse_Public_Static_add_Void_Action_3_AppId_UInt64_Boolean_0;

		// Token: 0x040011D4 RID: 4564
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnMicroTxnAuthorizationResponse_Public_Static_rem_Void_Action_3_AppId_UInt64_Boolean_0;

		// Token: 0x040011D5 RID: 4565
		private static readonly IntPtr NativeMethodInfoPtr_add_OnGameWebCallback_Public_Static_add_Void_Action_1_String_0;

		// Token: 0x040011D6 RID: 4566
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnGameWebCallback_Public_Static_rem_Void_Action_1_String_0;

		// Token: 0x040011D7 RID: 4567
		private static readonly IntPtr NativeMethodInfoPtr_add_OnDurationControl_Public_Static_add_Void_Action_1_DurationControl_0;

		// Token: 0x040011D8 RID: 4568
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnDurationControl_Public_Static_rem_Void_Action_1_DurationControl_0;

		// Token: 0x040011D9 RID: 4569
		private static readonly IntPtr NativeMethodInfoPtr_get_VoiceRecord_Public_Static_get_Boolean_0;

		// Token: 0x040011DA RID: 4570
		private static readonly IntPtr NativeMethodInfoPtr_set_VoiceRecord_Public_Static_set_Void_Boolean_0;

		// Token: 0x040011DB RID: 4571
		private static readonly IntPtr NativeMethodInfoPtr_get_HasVoiceData_Public_Static_get_Boolean_0;

		// Token: 0x040011DC RID: 4572
		private static readonly IntPtr NativeMethodInfoPtr_ReadVoiceData_Public_Static_Int32_Stream_0;

		// Token: 0x040011DD RID: 4573
		private static readonly IntPtr NativeMethodInfoPtr_ReadVoiceDataBytes_Public_Static_Il2CppStructArray_1_Byte_0;

		// Token: 0x040011DE RID: 4574
		private static readonly IntPtr NativeMethodInfoPtr_get_SampleRate_Public_Static_get_UInt32_0;

		// Token: 0x040011DF RID: 4575
		private static readonly IntPtr NativeMethodInfoPtr_set_SampleRate_Public_Static_set_Void_UInt32_0;

		// Token: 0x040011E0 RID: 4576
		private static readonly IntPtr NativeMethodInfoPtr_get_OptimalSampleRate_Public_Static_get_UInt32_0;

		// Token: 0x040011E1 RID: 4577
		private static readonly IntPtr NativeMethodInfoPtr_DecompressVoice_Public_Static_Int32_Stream_Int32_Stream_0;

		// Token: 0x040011E2 RID: 4578
		private static readonly IntPtr NativeMethodInfoPtr_DecompressVoice_Public_Static_Int32_Il2CppStructArray_1_Byte_Stream_0;

		// Token: 0x040011E3 RID: 4579
		private static readonly IntPtr NativeMethodInfoPtr_DecompressVoice_Public_Static_Int32_IntPtr_Int32_IntPtr_Int32_0;

		// Token: 0x040011E4 RID: 4580
		private static readonly IntPtr NativeMethodInfoPtr_GetAuthSessionTicket_Public_Static_AuthTicket_0;

		// Token: 0x040011E5 RID: 4581
		private static readonly IntPtr NativeMethodInfoPtr_GetAuthSessionTicketAsync_Public_Static_Task_1_AuthTicket_Double_0;

		// Token: 0x040011E6 RID: 4582
		private static readonly IntPtr NativeMethodInfoPtr_BeginAuthSession_Public_Static_BeginAuthResult_Il2CppStructArray_1_Byte_SteamId_0;

		// Token: 0x040011E7 RID: 4583
		private static readonly IntPtr NativeMethodInfoPtr_EndAuthSession_Public_Static_Void_SteamId_0;

		// Token: 0x040011E8 RID: 4584
		private static readonly IntPtr NativeMethodInfoPtr_get_IsBehindNAT_Public_Static_get_Boolean_0;

		// Token: 0x040011E9 RID: 4585
		private static readonly IntPtr NativeMethodInfoPtr_get_SteamLevel_Public_Static_get_Int32_0;

		// Token: 0x040011EA RID: 4586
		private static readonly IntPtr NativeMethodInfoPtr_GetStoreAuthUrlAsync_Public_Static_Task_1_String_String_0;

		// Token: 0x040011EB RID: 4587
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPhoneVerified_Public_Static_get_Boolean_0;

		// Token: 0x040011EC RID: 4588
		private static readonly IntPtr NativeMethodInfoPtr_get_IsTwoFactorEnabled_Public_Static_get_Boolean_0;

		// Token: 0x040011ED RID: 4589
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPhoneIdentifying_Public_Static_get_Boolean_0;

		// Token: 0x040011EE RID: 4590
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPhoneRequiringVerification_Public_Static_get_Boolean_0;

		// Token: 0x040011EF RID: 4591
		private static readonly IntPtr NativeMethodInfoPtr_RequestEncryptedAppTicketAsync_Public_Static_Task_1_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x040011F0 RID: 4592
		private static readonly IntPtr NativeMethodInfoPtr_RequestEncryptedAppTicketAsync_Public_Static_Task_1_Il2CppStructArray_1_Byte_0;

		// Token: 0x040011F1 RID: 4593
		private static readonly IntPtr NativeMethodInfoPtr_GetDurationControl_Public_Static_Task_1_DurationControl_0;

		// Token: 0x040011F2 RID: 4594
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200025F RID: 607
		[ObfuscatedName("Steamworks.SteamUser+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001E9D RID: 7837 RVA: 0x0008A4AC File Offset: 0x000886AC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SteamUser.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUser.__c>.NativeClassPtr);
				SteamUser.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser.__c>.NativeClassPtr, "<>9");
				SteamUser.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser.__c>.NativeClassPtr, "<>9__4_0");
				SteamUser.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser.__c>.NativeClassPtr, "<>9__4_1");
				SteamUser.__c.NativeFieldInfoPtr___9__4_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser.__c>.NativeClassPtr, "<>9__4_2");
				SteamUser.__c.NativeFieldInfoPtr___9__4_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser.__c>.NativeClassPtr, "<>9__4_3");
				SteamUser.__c.NativeFieldInfoPtr___9__4_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser.__c>.NativeClassPtr, "<>9__4_4");
				SteamUser.__c.NativeFieldInfoPtr___9__4_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser.__c>.NativeClassPtr, "<>9__4_5");
				SteamUser.__c.NativeFieldInfoPtr___9__4_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser.__c>.NativeClassPtr, "<>9__4_6");
				SteamUser.__c.NativeFieldInfoPtr___9__4_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser.__c>.NativeClassPtr, "<>9__4_7");
				SteamUser.__c.NativeFieldInfoPtr___9__4_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser.__c>.NativeClassPtr, "<>9__4_8");
				SteamUser.__c.NativeFieldInfoPtr___9__4_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser.__c>.NativeClassPtr, "<>9__4_9");
				SteamUser.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser.__c>.NativeClassPtr, 100666046);
				SteamUser.__c.NativeMethodInfoPtr__InstallEvents_b__4_0_Internal_Void_SteamServersConnected_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser.__c>.NativeClassPtr, 100666047);
				SteamUser.__c.NativeMethodInfoPtr__InstallEvents_b__4_1_Internal_Void_SteamServerConnectFailure_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser.__c>.NativeClassPtr, 100666048);
				SteamUser.__c.NativeMethodInfoPtr__InstallEvents_b__4_2_Internal_Void_SteamServersDisconnected_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser.__c>.NativeClassPtr, 100666049);
				SteamUser.__c.NativeMethodInfoPtr__InstallEvents_b__4_3_Internal_Void_ClientGameServerDeny_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser.__c>.NativeClassPtr, 100666050);
				SteamUser.__c.NativeMethodInfoPtr__InstallEvents_b__4_4_Internal_Void_LicensesUpdated_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser.__c>.NativeClassPtr, 100666051);
				SteamUser.__c.NativeMethodInfoPtr__InstallEvents_b__4_5_Internal_Void_ValidateAuthTicketResponse_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser.__c>.NativeClassPtr, 100666052);
				SteamUser.__c.NativeMethodInfoPtr__InstallEvents_b__4_6_Internal_Void_MicroTxnAuthorizationResponse_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser.__c>.NativeClassPtr, 100666053);
				SteamUser.__c.NativeMethodInfoPtr__InstallEvents_b__4_7_Internal_Void_GameWebCallback_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser.__c>.NativeClassPtr, 100666054);
				SteamUser.__c.NativeMethodInfoPtr__InstallEvents_b__4_8_Internal_Void_GetAuthSessionTicketResponse_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser.__c>.NativeClassPtr, 100666055);
				SteamUser.__c.NativeMethodInfoPtr__InstallEvents_b__4_9_Internal_Void_DurationControl_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser.__c>.NativeClassPtr, 100666056);
			}

			// Token: 0x06001E9E RID: 7838 RVA: 0x0008A690 File Offset: 0x00088890
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamUser.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E9F RID: 7839 RVA: 0x0008A6CC File Offset: 0x000888CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943915, XrefRangeEnd = 943919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__4_0(SteamServersConnected_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.__c.NativeMethodInfoPtr__InstallEvents_b__4_0_Internal_Void_SteamServersConnected_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001EA0 RID: 7840 RVA: 0x0008A70C File Offset: 0x0008890C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943919, XrefRangeEnd = 943923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__4_1(SteamServerConnectFailure_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.__c.NativeMethodInfoPtr__InstallEvents_b__4_1_Internal_Void_SteamServerConnectFailure_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001EA1 RID: 7841 RVA: 0x0008A74C File Offset: 0x0008894C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943923, XrefRangeEnd = 943927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__4_2(SteamServersDisconnected_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.__c.NativeMethodInfoPtr__InstallEvents_b__4_2_Internal_Void_SteamServersDisconnected_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001EA2 RID: 7842 RVA: 0x0008A78C File Offset: 0x0008898C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943927, XrefRangeEnd = 943931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__4_3(ClientGameServerDeny_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.__c.NativeMethodInfoPtr__InstallEvents_b__4_3_Internal_Void_ClientGameServerDeny_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001EA3 RID: 7843 RVA: 0x0008A7CC File Offset: 0x000889CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943931, XrefRangeEnd = 943935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__4_4(LicensesUpdated_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.__c.NativeMethodInfoPtr__InstallEvents_b__4_4_Internal_Void_LicensesUpdated_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001EA4 RID: 7844 RVA: 0x0008A80C File Offset: 0x00088A0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943935, XrefRangeEnd = 943939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__4_5(ValidateAuthTicketResponse_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.__c.NativeMethodInfoPtr__InstallEvents_b__4_5_Internal_Void_ValidateAuthTicketResponse_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001EA5 RID: 7845 RVA: 0x0008A84C File Offset: 0x00088A4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943939, XrefRangeEnd = 943943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__4_6(MicroTxnAuthorizationResponse_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.__c.NativeMethodInfoPtr__InstallEvents_b__4_6_Internal_Void_MicroTxnAuthorizationResponse_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001EA6 RID: 7846 RVA: 0x0008A88C File Offset: 0x00088A8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943943, XrefRangeEnd = 943951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__4_7(GameWebCallback_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.__c.NativeMethodInfoPtr__InstallEvents_b__4_7_Internal_Void_GameWebCallback_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001EA7 RID: 7847 RVA: 0x0008A8D4 File Offset: 0x00088AD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943951, XrefRangeEnd = 943955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__4_8(GetAuthSessionTicketResponse_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.__c.NativeMethodInfoPtr__InstallEvents_b__4_8_Internal_Void_GetAuthSessionTicketResponse_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001EA8 RID: 7848 RVA: 0x0008A914 File Offset: 0x00088B14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943955, XrefRangeEnd = 943959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__4_9(DurationControl_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.__c.NativeMethodInfoPtr__InstallEvents_b__4_9_Internal_Void_DurationControl_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001EA9 RID: 7849 RVA: 0x0000B274 File Offset: 0x00009474
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007C5 RID: 1989
			// (get) Token: 0x06001EAA RID: 7850 RVA: 0x0008A954 File Offset: 0x00088B54
			// (set) Token: 0x06001EAB RID: 7851 RVA: 0x0000B27D File Offset: 0x0000947D
			public unsafe static SteamUser.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamUser.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SteamUser.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamUser.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007C6 RID: 1990
			// (get) Token: 0x06001EAC RID: 7852 RVA: 0x0008A97C File Offset: 0x00088B7C
			// (set) Token: 0x06001EAD RID: 7853 RVA: 0x0000B28F File Offset: 0x0000948F
			public unsafe static Action<SteamServersConnected_t> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamUser.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SteamServersConnected_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamUser.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007C7 RID: 1991
			// (get) Token: 0x06001EAE RID: 7854 RVA: 0x0008A9A4 File Offset: 0x00088BA4
			// (set) Token: 0x06001EAF RID: 7855 RVA: 0x0000B2A1 File Offset: 0x000094A1
			public unsafe static Action<SteamServerConnectFailure_t> __9__4_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamUser.__c.NativeFieldInfoPtr___9__4_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SteamServerConnectFailure_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamUser.__c.NativeFieldInfoPtr___9__4_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007C8 RID: 1992
			// (get) Token: 0x06001EB0 RID: 7856 RVA: 0x0008A9CC File Offset: 0x00088BCC
			// (set) Token: 0x06001EB1 RID: 7857 RVA: 0x0000B2B3 File Offset: 0x000094B3
			public unsafe static Action<SteamServersDisconnected_t> __9__4_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamUser.__c.NativeFieldInfoPtr___9__4_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SteamServersDisconnected_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamUser.__c.NativeFieldInfoPtr___9__4_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007C9 RID: 1993
			// (get) Token: 0x06001EB2 RID: 7858 RVA: 0x0008A9F4 File Offset: 0x00088BF4
			// (set) Token: 0x06001EB3 RID: 7859 RVA: 0x0000B2C5 File Offset: 0x000094C5
			public unsafe static Action<ClientGameServerDeny_t> __9__4_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamUser.__c.NativeFieldInfoPtr___9__4_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ClientGameServerDeny_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamUser.__c.NativeFieldInfoPtr___9__4_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007CA RID: 1994
			// (get) Token: 0x06001EB4 RID: 7860 RVA: 0x0008AA1C File Offset: 0x00088C1C
			// (set) Token: 0x06001EB5 RID: 7861 RVA: 0x0000B2D7 File Offset: 0x000094D7
			public unsafe static Action<LicensesUpdated_t> __9__4_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamUser.__c.NativeFieldInfoPtr___9__4_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<LicensesUpdated_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamUser.__c.NativeFieldInfoPtr___9__4_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007CB RID: 1995
			// (get) Token: 0x06001EB6 RID: 7862 RVA: 0x0008AA44 File Offset: 0x00088C44
			// (set) Token: 0x06001EB7 RID: 7863 RVA: 0x0000B2E9 File Offset: 0x000094E9
			public unsafe static Action<ValidateAuthTicketResponse_t> __9__4_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamUser.__c.NativeFieldInfoPtr___9__4_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ValidateAuthTicketResponse_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamUser.__c.NativeFieldInfoPtr___9__4_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007CC RID: 1996
			// (get) Token: 0x06001EB8 RID: 7864 RVA: 0x0008AA6C File Offset: 0x00088C6C
			// (set) Token: 0x06001EB9 RID: 7865 RVA: 0x0000B2FB File Offset: 0x000094FB
			public unsafe static Action<MicroTxnAuthorizationResponse_t> __9__4_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamUser.__c.NativeFieldInfoPtr___9__4_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<MicroTxnAuthorizationResponse_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamUser.__c.NativeFieldInfoPtr___9__4_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007CD RID: 1997
			// (get) Token: 0x06001EBA RID: 7866 RVA: 0x0008AA94 File Offset: 0x00088C94
			// (set) Token: 0x06001EBB RID: 7867 RVA: 0x0000B30D File Offset: 0x0000950D
			public unsafe static Action<GameWebCallback_t> __9__4_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamUser.__c.NativeFieldInfoPtr___9__4_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GameWebCallback_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamUser.__c.NativeFieldInfoPtr___9__4_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007CE RID: 1998
			// (get) Token: 0x06001EBC RID: 7868 RVA: 0x0008AABC File Offset: 0x00088CBC
			// (set) Token: 0x06001EBD RID: 7869 RVA: 0x0000B31F File Offset: 0x0000951F
			public unsafe static Action<GetAuthSessionTicketResponse_t> __9__4_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamUser.__c.NativeFieldInfoPtr___9__4_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GetAuthSessionTicketResponse_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamUser.__c.NativeFieldInfoPtr___9__4_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007CF RID: 1999
			// (get) Token: 0x06001EBE RID: 7870 RVA: 0x0008AAE4 File Offset: 0x00088CE4
			// (set) Token: 0x06001EBF RID: 7871 RVA: 0x0000B331 File Offset: 0x00009531
			public unsafe static Action<DurationControl_t> __9__4_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamUser.__c.NativeFieldInfoPtr___9__4_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<DurationControl_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamUser.__c.NativeFieldInfoPtr___9__4_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040021CB RID: 8651
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040021CC RID: 8652
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x040021CD RID: 8653
			private static readonly IntPtr NativeFieldInfoPtr___9__4_1;

			// Token: 0x040021CE RID: 8654
			private static readonly IntPtr NativeFieldInfoPtr___9__4_2;

			// Token: 0x040021CF RID: 8655
			private static readonly IntPtr NativeFieldInfoPtr___9__4_3;

			// Token: 0x040021D0 RID: 8656
			private static readonly IntPtr NativeFieldInfoPtr___9__4_4;

			// Token: 0x040021D1 RID: 8657
			private static readonly IntPtr NativeFieldInfoPtr___9__4_5;

			// Token: 0x040021D2 RID: 8658
			private static readonly IntPtr NativeFieldInfoPtr___9__4_6;

			// Token: 0x040021D3 RID: 8659
			private static readonly IntPtr NativeFieldInfoPtr___9__4_7;

			// Token: 0x040021D4 RID: 8660
			private static readonly IntPtr NativeFieldInfoPtr___9__4_8;

			// Token: 0x040021D5 RID: 8661
			private static readonly IntPtr NativeFieldInfoPtr___9__4_9;

			// Token: 0x040021D6 RID: 8662
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040021D7 RID: 8663
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__4_0_Internal_Void_SteamServersConnected_t_0;

			// Token: 0x040021D8 RID: 8664
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__4_1_Internal_Void_SteamServerConnectFailure_t_0;

			// Token: 0x040021D9 RID: 8665
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__4_2_Internal_Void_SteamServersDisconnected_t_0;

			// Token: 0x040021DA RID: 8666
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__4_3_Internal_Void_ClientGameServerDeny_t_0;

			// Token: 0x040021DB RID: 8667
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__4_4_Internal_Void_LicensesUpdated_t_0;

			// Token: 0x040021DC RID: 8668
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__4_5_Internal_Void_ValidateAuthTicketResponse_t_0;

			// Token: 0x040021DD RID: 8669
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__4_6_Internal_Void_MicroTxnAuthorizationResponse_t_0;

			// Token: 0x040021DE RID: 8670
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__4_7_Internal_Void_GameWebCallback_t_0;

			// Token: 0x040021DF RID: 8671
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__4_8_Internal_Void_GetAuthSessionTicketResponse_t_0;

			// Token: 0x040021E0 RID: 8672
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__4_9_Internal_Void_DurationControl_t_0;
		}

		// Token: 0x02000260 RID: 608
		[ObfuscatedName("Steamworks.SteamUser+<>c__DisplayClass54_0")]
		public sealed class __c__DisplayClass54_0 : Object
		{
			// Token: 0x06001EC0 RID: 7872 RVA: 0x0008AB0C File Offset: 0x00088D0C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass54_0()
			{
				Il2CppClassPointerStore<SteamUser.__c__DisplayClass54_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, "<>c__DisplayClass54_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUser.__c__DisplayClass54_0>.NativeClassPtr);
				SteamUser.__c__DisplayClass54_0.NativeFieldInfoPtr_ticket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser.__c__DisplayClass54_0>.NativeClassPtr, "ticket");
				SteamUser.__c__DisplayClass54_0.NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser.__c__DisplayClass54_0>.NativeClassPtr, "result");
				SteamUser.__c__DisplayClass54_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser.__c__DisplayClass54_0>.NativeClassPtr, 100666057);
				SteamUser.__c__DisplayClass54_0.NativeMethodInfoPtr_Method_Internal_Void_GetAuthSessionTicketResponse_t_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser.__c__DisplayClass54_0>.NativeClassPtr, 100666058);
			}

			// Token: 0x06001EC1 RID: 7873 RVA: 0x0008AB88 File Offset: 0x00088D88
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass54_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamUser.__c__DisplayClass54_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.__c__DisplayClass54_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EC2 RID: 7874 RVA: 0x0008ABC4 File Offset: 0x00088DC4
			[CallerCount(0)]
			public unsafe void Method_Internal_Void_GetAuthSessionTicketResponse_t_PDM_0(GetAuthSessionTicketResponse_t t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref t;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.__c__DisplayClass54_0.NativeMethodInfoPtr_Method_Internal_Void_GetAuthSessionTicketResponse_t_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001EC3 RID: 7875 RVA: 0x0000B343 File Offset: 0x00009543
			public __c__DisplayClass54_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007D0 RID: 2000
			// (get) Token: 0x06001EC4 RID: 7876 RVA: 0x0008AC04 File Offset: 0x00088E04
			// (set) Token: 0x06001EC5 RID: 7877 RVA: 0x0000B34C File Offset: 0x0000954C
			public unsafe AuthTicket ticket
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser.__c__DisplayClass54_0.NativeFieldInfoPtr_ticket);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AuthTicket>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser.__c__DisplayClass54_0.NativeFieldInfoPtr_ticket), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007D1 RID: 2001
			// (get) Token: 0x06001EC6 RID: 7878 RVA: 0x0008AC34 File Offset: 0x00088E34
			// (set) Token: 0x06001EC7 RID: 7879 RVA: 0x0000B36B File Offset: 0x0000956B
			public unsafe Result result
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser.__c__DisplayClass54_0.NativeFieldInfoPtr_result);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser.__c__DisplayClass54_0.NativeFieldInfoPtr_result)) = value;
				}
			}

			// Token: 0x040021E1 RID: 8673
			private static readonly IntPtr NativeFieldInfoPtr_ticket;

			// Token: 0x040021E2 RID: 8674
			private static readonly IntPtr NativeFieldInfoPtr_result;

			// Token: 0x040021E3 RID: 8675
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040021E4 RID: 8676
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_GetAuthSessionTicketResponse_t_PDM_0;
		}

		// Token: 0x02000261 RID: 609
		[ObfuscatedName("Steamworks.SteamUser+<GetAuthSessionTicketAsync>d__54")]
		public sealed class _GetAuthSessionTicketAsync_d__54 : ValueType
		{
			// Token: 0x06001EC8 RID: 7880 RVA: 0x0008AC5C File Offset: 0x00088E5C
			// Note: this type is marked as 'beforefieldinit'.
			static _GetAuthSessionTicketAsync_d__54()
			{
				Il2CppClassPointerStore<SteamUser._GetAuthSessionTicketAsync_d__54>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, "<GetAuthSessionTicketAsync>d__54");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUser._GetAuthSessionTicketAsync_d__54>.NativeClassPtr);
				SteamUser._GetAuthSessionTicketAsync_d__54.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser._GetAuthSessionTicketAsync_d__54>.NativeClassPtr, "<>1__state");
				SteamUser._GetAuthSessionTicketAsync_d__54.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser._GetAuthSessionTicketAsync_d__54>.NativeClassPtr, "<>t__builder");
				SteamUser._GetAuthSessionTicketAsync_d__54.NativeFieldInfoPtr_timeoutSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser._GetAuthSessionTicketAsync_d__54>.NativeClassPtr, "timeoutSeconds");
				SteamUser._GetAuthSessionTicketAsync_d__54.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser._GetAuthSessionTicketAsync_d__54>.NativeClassPtr, "<>8__1");
				SteamUser._GetAuthSessionTicketAsync_d__54.NativeFieldInfoPtr__stopwatch_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser._GetAuthSessionTicketAsync_d__54>.NativeClassPtr, "<stopwatch>5__2");
				SteamUser._GetAuthSessionTicketAsync_d__54.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser._GetAuthSessionTicketAsync_d__54>.NativeClassPtr, "<>u__1");
				SteamUser._GetAuthSessionTicketAsync_d__54.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser._GetAuthSessionTicketAsync_d__54>.NativeClassPtr, 100666059);
				SteamUser._GetAuthSessionTicketAsync_d__54.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser._GetAuthSessionTicketAsync_d__54>.NativeClassPtr, 100666060);
			}

			// Token: 0x06001EC9 RID: 7881 RVA: 0x0008AD28 File Offset: 0x00088F28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943959, XrefRangeEnd = 944056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser._GetAuthSessionTicketAsync_d__54.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001ECA RID: 7882 RVA: 0x0008AD60 File Offset: 0x00088F60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944056, XrefRangeEnd = 944062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser._GetAuthSessionTicketAsync_d__54.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001ECB RID: 7883 RVA: 0x0000B386 File Offset: 0x00009586
			public _GetAuthSessionTicketAsync_d__54(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001ECC RID: 7884 RVA: 0x0000B38F File Offset: 0x0000958F
			public _GetAuthSessionTicketAsync_d__54()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamUser._GetAuthSessionTicketAsync_d__54>.NativeClassPtr))
			{
			}

			// Token: 0x170007D2 RID: 2002
			// (get) Token: 0x06001ECD RID: 7885 RVA: 0x0008ADA8 File Offset: 0x00088FA8
			// (set) Token: 0x06001ECE RID: 7886 RVA: 0x0000B3A1 File Offset: 0x000095A1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser._GetAuthSessionTicketAsync_d__54.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser._GetAuthSessionTicketAsync_d__54.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007D3 RID: 2003
			// (get) Token: 0x06001ECF RID: 7887 RVA: 0x0008ADD0 File Offset: 0x00088FD0
			// (set) Token: 0x06001ED0 RID: 7888 RVA: 0x0000B3BC File Offset: 0x000095BC
			public AsyncTaskMethodBuilder<AuthTicket> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser._GetAuthSessionTicketAsync_d__54.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<AuthTicket>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<AuthTicket>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser._GetAuthSessionTicketAsync_d__54.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<AuthTicket>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007D4 RID: 2004
			// (get) Token: 0x06001ED1 RID: 7889 RVA: 0x0008AE00 File Offset: 0x00089000
			// (set) Token: 0x06001ED2 RID: 7890 RVA: 0x0000B3EA File Offset: 0x000095EA
			public unsafe double timeoutSeconds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser._GetAuthSessionTicketAsync_d__54.NativeFieldInfoPtr_timeoutSeconds);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser._GetAuthSessionTicketAsync_d__54.NativeFieldInfoPtr_timeoutSeconds)) = value;
				}
			}

			// Token: 0x170007D5 RID: 2005
			// (get) Token: 0x06001ED3 RID: 7891 RVA: 0x0008AE28 File Offset: 0x00089028
			// (set) Token: 0x06001ED4 RID: 7892 RVA: 0x0000B405 File Offset: 0x00009605
			public unsafe SteamUser.__c__DisplayClass54_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser._GetAuthSessionTicketAsync_d__54.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SteamUser.__c__DisplayClass54_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser._GetAuthSessionTicketAsync_d__54.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007D6 RID: 2006
			// (get) Token: 0x06001ED5 RID: 7893 RVA: 0x0008AE58 File Offset: 0x00089058
			// (set) Token: 0x06001ED6 RID: 7894 RVA: 0x0000B424 File Offset: 0x00009624
			public unsafe Stopwatch _stopwatch_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser._GetAuthSessionTicketAsync_d__54.NativeFieldInfoPtr__stopwatch_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stopwatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser._GetAuthSessionTicketAsync_d__54.NativeFieldInfoPtr__stopwatch_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007D7 RID: 2007
			// (get) Token: 0x06001ED7 RID: 7895 RVA: 0x0008AE88 File Offset: 0x00089088
			// (set) Token: 0x06001ED8 RID: 7896 RVA: 0x0000B443 File Offset: 0x00009643
			public TaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser._GetAuthSessionTicketAsync_d__54.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser._GetAuthSessionTicketAsync_d__54.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040021E5 RID: 8677
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040021E6 RID: 8678
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040021E7 RID: 8679
			private static readonly IntPtr NativeFieldInfoPtr_timeoutSeconds;

			// Token: 0x040021E8 RID: 8680
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040021E9 RID: 8681
			private static readonly IntPtr NativeFieldInfoPtr__stopwatch_5__2;

			// Token: 0x040021EA RID: 8682
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040021EB RID: 8683
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040021EC RID: 8684
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000262 RID: 610
		[ObfuscatedName("Steamworks.SteamUser+<GetDurationControl>d__72")]
		public sealed class _GetDurationControl_d__72 : ValueType
		{
			// Token: 0x06001ED9 RID: 7897 RVA: 0x0008AEB8 File Offset: 0x000890B8
			// Note: this type is marked as 'beforefieldinit'.
			static _GetDurationControl_d__72()
			{
				Il2CppClassPointerStore<SteamUser._GetDurationControl_d__72>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, "<GetDurationControl>d__72");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUser._GetDurationControl_d__72>.NativeClassPtr);
				SteamUser._GetDurationControl_d__72.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser._GetDurationControl_d__72>.NativeClassPtr, "<>1__state");
				SteamUser._GetDurationControl_d__72.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser._GetDurationControl_d__72>.NativeClassPtr, "<>t__builder");
				SteamUser._GetDurationControl_d__72.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser._GetDurationControl_d__72>.NativeClassPtr, "<>u__1");
				SteamUser._GetDurationControl_d__72.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser._GetDurationControl_d__72>.NativeClassPtr, 100666061);
				SteamUser._GetDurationControl_d__72.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser._GetDurationControl_d__72>.NativeClassPtr, 100666062);
			}

			// Token: 0x06001EDA RID: 7898 RVA: 0x0008AF48 File Offset: 0x00089148
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944062, XrefRangeEnd = 944089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser._GetDurationControl_d__72.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EDB RID: 7899 RVA: 0x0008AF80 File Offset: 0x00089180
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944089, XrefRangeEnd = 944095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser._GetDurationControl_d__72.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001EDC RID: 7900 RVA: 0x0000B471 File Offset: 0x00009671
			public _GetDurationControl_d__72(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001EDD RID: 7901 RVA: 0x0000B47A File Offset: 0x0000967A
			public _GetDurationControl_d__72()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamUser._GetDurationControl_d__72>.NativeClassPtr))
			{
			}

			// Token: 0x170007D8 RID: 2008
			// (get) Token: 0x06001EDE RID: 7902 RVA: 0x0008AFC8 File Offset: 0x000891C8
			// (set) Token: 0x06001EDF RID: 7903 RVA: 0x0000B48C File Offset: 0x0000968C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser._GetDurationControl_d__72.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser._GetDurationControl_d__72.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007D9 RID: 2009
			// (get) Token: 0x06001EE0 RID: 7904 RVA: 0x0008AFF0 File Offset: 0x000891F0
			// (set) Token: 0x06001EE1 RID: 7905 RVA: 0x0000B4A7 File Offset: 0x000096A7
			public AsyncTaskMethodBuilder<DurationControl> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser._GetDurationControl_d__72.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<DurationControl>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<DurationControl>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser._GetDurationControl_d__72.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<DurationControl>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007DA RID: 2010
			// (get) Token: 0x06001EE2 RID: 7906 RVA: 0x0008B020 File Offset: 0x00089220
			// (set) Token: 0x06001EE3 RID: 7907 RVA: 0x0000B4D5 File Offset: 0x000096D5
			public CallResult<DurationControl_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser._GetDurationControl_d__72.NativeFieldInfoPtr___u__1);
					return new CallResult<DurationControl_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<DurationControl_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser._GetDurationControl_d__72.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<DurationControl_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040021ED RID: 8685
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040021EE RID: 8686
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040021EF RID: 8687
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040021F0 RID: 8688
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040021F1 RID: 8689
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000263 RID: 611
		[ObfuscatedName("Steamworks.SteamUser+<GetStoreAuthUrlAsync>d__61")]
		public sealed class _GetStoreAuthUrlAsync_d__61 : ValueType
		{
			// Token: 0x06001EE4 RID: 7908 RVA: 0x0008B050 File Offset: 0x00089250
			// Note: this type is marked as 'beforefieldinit'.
			static _GetStoreAuthUrlAsync_d__61()
			{
				Il2CppClassPointerStore<SteamUser._GetStoreAuthUrlAsync_d__61>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, "<GetStoreAuthUrlAsync>d__61");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUser._GetStoreAuthUrlAsync_d__61>.NativeClassPtr);
				SteamUser._GetStoreAuthUrlAsync_d__61.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser._GetStoreAuthUrlAsync_d__61>.NativeClassPtr, "<>1__state");
				SteamUser._GetStoreAuthUrlAsync_d__61.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser._GetStoreAuthUrlAsync_d__61>.NativeClassPtr, "<>t__builder");
				SteamUser._GetStoreAuthUrlAsync_d__61.NativeFieldInfoPtr_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser._GetStoreAuthUrlAsync_d__61>.NativeClassPtr, "url");
				SteamUser._GetStoreAuthUrlAsync_d__61.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser._GetStoreAuthUrlAsync_d__61>.NativeClassPtr, "<>u__1");
				SteamUser._GetStoreAuthUrlAsync_d__61.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser._GetStoreAuthUrlAsync_d__61>.NativeClassPtr, 100666063);
				SteamUser._GetStoreAuthUrlAsync_d__61.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser._GetStoreAuthUrlAsync_d__61>.NativeClassPtr, 100666064);
			}

			// Token: 0x06001EE5 RID: 7909 RVA: 0x0008B0F4 File Offset: 0x000892F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944095, XrefRangeEnd = 944126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser._GetStoreAuthUrlAsync_d__61.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EE6 RID: 7910 RVA: 0x0008B12C File Offset: 0x0008932C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944126, XrefRangeEnd = 944132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser._GetStoreAuthUrlAsync_d__61.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001EE7 RID: 7911 RVA: 0x0000B503 File Offset: 0x00009703
			public _GetStoreAuthUrlAsync_d__61(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001EE8 RID: 7912 RVA: 0x0000B50C File Offset: 0x0000970C
			public _GetStoreAuthUrlAsync_d__61()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamUser._GetStoreAuthUrlAsync_d__61>.NativeClassPtr))
			{
			}

			// Token: 0x170007DB RID: 2011
			// (get) Token: 0x06001EE9 RID: 7913 RVA: 0x0008B174 File Offset: 0x00089374
			// (set) Token: 0x06001EEA RID: 7914 RVA: 0x0000B51E File Offset: 0x0000971E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser._GetStoreAuthUrlAsync_d__61.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser._GetStoreAuthUrlAsync_d__61.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007DC RID: 2012
			// (get) Token: 0x06001EEB RID: 7915 RVA: 0x0008B19C File Offset: 0x0008939C
			// (set) Token: 0x06001EEC RID: 7916 RVA: 0x0000B539 File Offset: 0x00009739
			public AsyncTaskMethodBuilder<string> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser._GetStoreAuthUrlAsync_d__61.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<string>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<string>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser._GetStoreAuthUrlAsync_d__61.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<string>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007DD RID: 2013
			// (get) Token: 0x06001EED RID: 7917 RVA: 0x0008B1CC File Offset: 0x000893CC
			// (set) Token: 0x06001EEE RID: 7918 RVA: 0x0000B567 File Offset: 0x00009767
			public unsafe string url
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser._GetStoreAuthUrlAsync_d__61.NativeFieldInfoPtr_url);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser._GetStoreAuthUrlAsync_d__61.NativeFieldInfoPtr_url), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170007DE RID: 2014
			// (get) Token: 0x06001EEF RID: 7919 RVA: 0x0008B1F4 File Offset: 0x000893F4
			// (set) Token: 0x06001EF0 RID: 7920 RVA: 0x0000B586 File Offset: 0x00009786
			public CallResult<StoreAuthURLResponse_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser._GetStoreAuthUrlAsync_d__61.NativeFieldInfoPtr___u__1);
					return new CallResult<StoreAuthURLResponse_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<StoreAuthURLResponse_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser._GetStoreAuthUrlAsync_d__61.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<StoreAuthURLResponse_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040021F2 RID: 8690
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040021F3 RID: 8691
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040021F4 RID: 8692
			private static readonly IntPtr NativeFieldInfoPtr_url;

			// Token: 0x040021F5 RID: 8693
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040021F6 RID: 8694
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040021F7 RID: 8695
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000264 RID: 612
		[ObfuscatedName("Steamworks.SteamUser+<RequestEncryptedAppTicketAsync>d__70")]
		public sealed class _RequestEncryptedAppTicketAsync_d__70 : ValueType
		{
			// Token: 0x06001EF1 RID: 7921 RVA: 0x0008B224 File Offset: 0x00089424
			// Note: this type is marked as 'beforefieldinit'.
			static _RequestEncryptedAppTicketAsync_d__70()
			{
				Il2CppClassPointerStore<SteamUser._RequestEncryptedAppTicketAsync_d__70>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, "<RequestEncryptedAppTicketAsync>d__70");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUser._RequestEncryptedAppTicketAsync_d__70>.NativeClassPtr);
				SteamUser._RequestEncryptedAppTicketAsync_d__70.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser._RequestEncryptedAppTicketAsync_d__70>.NativeClassPtr, "<>1__state");
				SteamUser._RequestEncryptedAppTicketAsync_d__70.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser._RequestEncryptedAppTicketAsync_d__70>.NativeClassPtr, "<>t__builder");
				SteamUser._RequestEncryptedAppTicketAsync_d__70.NativeFieldInfoPtr_dataToInclude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser._RequestEncryptedAppTicketAsync_d__70>.NativeClassPtr, "dataToInclude");
				SteamUser._RequestEncryptedAppTicketAsync_d__70.NativeFieldInfoPtr__dataPtr_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser._RequestEncryptedAppTicketAsync_d__70>.NativeClassPtr, "<dataPtr>5__2");
				SteamUser._RequestEncryptedAppTicketAsync_d__70.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser._RequestEncryptedAppTicketAsync_d__70>.NativeClassPtr, "<>u__1");
				SteamUser._RequestEncryptedAppTicketAsync_d__70.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser._RequestEncryptedAppTicketAsync_d__70>.NativeClassPtr, 100666065);
				SteamUser._RequestEncryptedAppTicketAsync_d__70.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser._RequestEncryptedAppTicketAsync_d__70>.NativeClassPtr, 100666066);
			}

			// Token: 0x06001EF2 RID: 7922 RVA: 0x0008B2DC File Offset: 0x000894DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944132, XrefRangeEnd = 944186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser._RequestEncryptedAppTicketAsync_d__70.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EF3 RID: 7923 RVA: 0x0008B314 File Offset: 0x00089514
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944186, XrefRangeEnd = 944192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser._RequestEncryptedAppTicketAsync_d__70.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001EF4 RID: 7924 RVA: 0x0000B5B4 File Offset: 0x000097B4
			public _RequestEncryptedAppTicketAsync_d__70(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001EF5 RID: 7925 RVA: 0x0000B5BD File Offset: 0x000097BD
			public _RequestEncryptedAppTicketAsync_d__70()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamUser._RequestEncryptedAppTicketAsync_d__70>.NativeClassPtr))
			{
			}

			// Token: 0x170007DF RID: 2015
			// (get) Token: 0x06001EF6 RID: 7926 RVA: 0x0008B35C File Offset: 0x0008955C
			// (set) Token: 0x06001EF7 RID: 7927 RVA: 0x0000B5CF File Offset: 0x000097CF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser._RequestEncryptedAppTicketAsync_d__70.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser._RequestEncryptedAppTicketAsync_d__70.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007E0 RID: 2016
			// (get) Token: 0x06001EF8 RID: 7928 RVA: 0x0008B384 File Offset: 0x00089584
			// (set) Token: 0x06001EF9 RID: 7929 RVA: 0x0000B5EA File Offset: 0x000097EA
			public AsyncTaskMethodBuilder<Il2CppStructArray<byte>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser._RequestEncryptedAppTicketAsync_d__70.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Il2CppStructArray<byte>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppStructArray<byte>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser._RequestEncryptedAppTicketAsync_d__70.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppStructArray<byte>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007E1 RID: 2017
			// (get) Token: 0x06001EFA RID: 7930 RVA: 0x0008B3B4 File Offset: 0x000895B4
			// (set) Token: 0x06001EFB RID: 7931 RVA: 0x0000B618 File Offset: 0x00009818
			public unsafe Il2CppStructArray<byte> dataToInclude
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser._RequestEncryptedAppTicketAsync_d__70.NativeFieldInfoPtr_dataToInclude);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser._RequestEncryptedAppTicketAsync_d__70.NativeFieldInfoPtr_dataToInclude), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007E2 RID: 2018
			// (get) Token: 0x06001EFC RID: 7932 RVA: 0x0008B3E4 File Offset: 0x000895E4
			// (set) Token: 0x06001EFD RID: 7933 RVA: 0x0000B637 File Offset: 0x00009837
			public unsafe IntPtr _dataPtr_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser._RequestEncryptedAppTicketAsync_d__70.NativeFieldInfoPtr__dataPtr_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser._RequestEncryptedAppTicketAsync_d__70.NativeFieldInfoPtr__dataPtr_5__2)) = value;
				}
			}

			// Token: 0x170007E3 RID: 2019
			// (get) Token: 0x06001EFE RID: 7934 RVA: 0x0008B40C File Offset: 0x0008960C
			// (set) Token: 0x06001EFF RID: 7935 RVA: 0x0000B652 File Offset: 0x00009852
			public CallResult<EncryptedAppTicketResponse_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser._RequestEncryptedAppTicketAsync_d__70.NativeFieldInfoPtr___u__1);
					return new CallResult<EncryptedAppTicketResponse_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<EncryptedAppTicketResponse_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser._RequestEncryptedAppTicketAsync_d__70.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<EncryptedAppTicketResponse_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040021F8 RID: 8696
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040021F9 RID: 8697
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040021FA RID: 8698
			private static readonly IntPtr NativeFieldInfoPtr_dataToInclude;

			// Token: 0x040021FB RID: 8699
			private static readonly IntPtr NativeFieldInfoPtr__dataPtr_5__2;

			// Token: 0x040021FC RID: 8700
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040021FD RID: 8701
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040021FE RID: 8702
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000265 RID: 613
		[ObfuscatedName("Steamworks.SteamUser+<RequestEncryptedAppTicketAsync>d__71")]
		public sealed class _RequestEncryptedAppTicketAsync_d__71 : ValueType
		{
			// Token: 0x06001F00 RID: 7936 RVA: 0x0008B43C File Offset: 0x0008963C
			// Note: this type is marked as 'beforefieldinit'.
			static _RequestEncryptedAppTicketAsync_d__71()
			{
				Il2CppClassPointerStore<SteamUser._RequestEncryptedAppTicketAsync_d__71>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, "<RequestEncryptedAppTicketAsync>d__71");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUser._RequestEncryptedAppTicketAsync_d__71>.NativeClassPtr);
				SteamUser._RequestEncryptedAppTicketAsync_d__71.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser._RequestEncryptedAppTicketAsync_d__71>.NativeClassPtr, "<>1__state");
				SteamUser._RequestEncryptedAppTicketAsync_d__71.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser._RequestEncryptedAppTicketAsync_d__71>.NativeClassPtr, "<>t__builder");
				SteamUser._RequestEncryptedAppTicketAsync_d__71.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUser._RequestEncryptedAppTicketAsync_d__71>.NativeClassPtr, "<>u__1");
				SteamUser._RequestEncryptedAppTicketAsync_d__71.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser._RequestEncryptedAppTicketAsync_d__71>.NativeClassPtr, 100666067);
				SteamUser._RequestEncryptedAppTicketAsync_d__71.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser._RequestEncryptedAppTicketAsync_d__71>.NativeClassPtr, 100666068);
			}

			// Token: 0x06001F01 RID: 7937 RVA: 0x0008B4CC File Offset: 0x000896CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944192, XrefRangeEnd = 944236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser._RequestEncryptedAppTicketAsync_d__71.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F02 RID: 7938 RVA: 0x0008B504 File Offset: 0x00089704
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944236, XrefRangeEnd = 944242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser._RequestEncryptedAppTicketAsync_d__71.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F03 RID: 7939 RVA: 0x0000B680 File Offset: 0x00009880
			public _RequestEncryptedAppTicketAsync_d__71(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001F04 RID: 7940 RVA: 0x0000B689 File Offset: 0x00009889
			public _RequestEncryptedAppTicketAsync_d__71()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamUser._RequestEncryptedAppTicketAsync_d__71>.NativeClassPtr))
			{
			}

			// Token: 0x170007E4 RID: 2020
			// (get) Token: 0x06001F05 RID: 7941 RVA: 0x0008B54C File Offset: 0x0008974C
			// (set) Token: 0x06001F06 RID: 7942 RVA: 0x0000B69B File Offset: 0x0000989B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser._RequestEncryptedAppTicketAsync_d__71.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser._RequestEncryptedAppTicketAsync_d__71.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007E5 RID: 2021
			// (get) Token: 0x06001F07 RID: 7943 RVA: 0x0008B574 File Offset: 0x00089774
			// (set) Token: 0x06001F08 RID: 7944 RVA: 0x0000B6B6 File Offset: 0x000098B6
			public AsyncTaskMethodBuilder<Il2CppStructArray<byte>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser._RequestEncryptedAppTicketAsync_d__71.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Il2CppStructArray<byte>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppStructArray<byte>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser._RequestEncryptedAppTicketAsync_d__71.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppStructArray<byte>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007E6 RID: 2022
			// (get) Token: 0x06001F09 RID: 7945 RVA: 0x0008B5A4 File Offset: 0x000897A4
			// (set) Token: 0x06001F0A RID: 7946 RVA: 0x0000B6E4 File Offset: 0x000098E4
			public CallResult<EncryptedAppTicketResponse_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser._RequestEncryptedAppTicketAsync_d__71.NativeFieldInfoPtr___u__1);
					return new CallResult<EncryptedAppTicketResponse_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<EncryptedAppTicketResponse_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUser._RequestEncryptedAppTicketAsync_d__71.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<EncryptedAppTicketResponse_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040021FF RID: 8703
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002200 RID: 8704
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002201 RID: 8705
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002202 RID: 8706
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002203 RID: 8707
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
