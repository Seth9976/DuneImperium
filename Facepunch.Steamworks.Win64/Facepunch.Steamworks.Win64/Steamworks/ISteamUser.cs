using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x0200002C RID: 44
	public class ISteamUser : SteamInterface
	{
		// Token: 0x060006E3 RID: 1763 RVA: 0x0003A0E4 File Offset: 0x000382E4
		// Note: this type is marked as 'beforefieldinit'.
		static ISteamUser()
		{
			Il2CppClassPointerStore<ISteamUser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "ISteamUser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr);
			ISteamUser.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100664974);
			ISteamUser.NativeMethodInfoPtr_SteamAPI_SteamUser_v021_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100664975);
			ISteamUser.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100664976);
			ISteamUser.NativeMethodInfoPtr__GetHSteamUser_Private_Static_HSteamUser_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100664977);
			ISteamUser.NativeMethodInfoPtr_GetHSteamUser_Internal_HSteamUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100664978);
			ISteamUser.NativeMethodInfoPtr__BLoggedOn_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100664979);
			ISteamUser.NativeMethodInfoPtr_BLoggedOn_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100664980);
			ISteamUser.NativeMethodInfoPtr__GetSteamID_Private_Static_SteamId_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100664981);
			ISteamUser.NativeMethodInfoPtr_GetSteamID_Internal_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100664982);
			ISteamUser.NativeMethodInfoPtr__InitiateGameConnection_DEPRECATED_Private_Static_Int32_IntPtr_IntPtr_Int32_SteamId_UInt32_UInt16_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100664983);
			ISteamUser.NativeMethodInfoPtr_InitiateGameConnection_DEPRECATED_Internal_Int32_IntPtr_Int32_SteamId_UInt32_UInt16_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100664984);
			ISteamUser.NativeMethodInfoPtr__TerminateGameConnection_DEPRECATED_Private_Static_Void_IntPtr_UInt32_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100664985);
			ISteamUser.NativeMethodInfoPtr_TerminateGameConnection_DEPRECATED_Internal_Void_UInt32_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100664986);
			ISteamUser.NativeMethodInfoPtr__TrackAppUsageEvent_Private_Static_Void_IntPtr_GameId_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100664987);
			ISteamUser.NativeMethodInfoPtr_TrackAppUsageEvent_Internal_Void_GameId_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100664988);
			ISteamUser.NativeMethodInfoPtr__GetUserDataFolder_Private_Static_Boolean_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100664989);
			ISteamUser.NativeMethodInfoPtr_GetUserDataFolder_Internal_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100664990);
			ISteamUser.NativeMethodInfoPtr__StartVoiceRecording_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100664991);
			ISteamUser.NativeMethodInfoPtr_StartVoiceRecording_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100664992);
			ISteamUser.NativeMethodInfoPtr__StopVoiceRecording_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100664993);
			ISteamUser.NativeMethodInfoPtr_StopVoiceRecording_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100664994);
			ISteamUser.NativeMethodInfoPtr__GetAvailableVoice_Private_Static_VoiceResult_IntPtr_byref_UInt32_byref_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100664995);
			ISteamUser.NativeMethodInfoPtr_GetAvailableVoice_Internal_VoiceResult_byref_UInt32_byref_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100664996);
			ISteamUser.NativeMethodInfoPtr__GetVoice_Private_Static_VoiceResult_IntPtr_Boolean_IntPtr_UInt32_byref_UInt32_Boolean_IntPtr_UInt32_byref_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100664997);
			ISteamUser.NativeMethodInfoPtr_GetVoice_Internal_VoiceResult_Boolean_IntPtr_UInt32_byref_UInt32_Boolean_IntPtr_UInt32_byref_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100664998);
			ISteamUser.NativeMethodInfoPtr__DecompressVoice_Private_Static_VoiceResult_IntPtr_IntPtr_UInt32_IntPtr_UInt32_byref_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100664999);
			ISteamUser.NativeMethodInfoPtr_DecompressVoice_Internal_VoiceResult_IntPtr_UInt32_IntPtr_UInt32_byref_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100665000);
			ISteamUser.NativeMethodInfoPtr__GetVoiceOptimalSampleRate_Private_Static_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100665001);
			ISteamUser.NativeMethodInfoPtr_GetVoiceOptimalSampleRate_Internal_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100665002);
			ISteamUser.NativeMethodInfoPtr__GetAuthSessionTicket_Private_Static_HAuthTicket_IntPtr_IntPtr_Int32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100665003);
			ISteamUser.NativeMethodInfoPtr_GetAuthSessionTicket_Internal_HAuthTicket_IntPtr_Int32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100665004);
			ISteamUser.NativeMethodInfoPtr__BeginAuthSession_Private_Static_BeginAuthResult_IntPtr_IntPtr_Int32_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100665005);
			ISteamUser.NativeMethodInfoPtr_BeginAuthSession_Internal_BeginAuthResult_IntPtr_Int32_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100665006);
			ISteamUser.NativeMethodInfoPtr__EndAuthSession_Private_Static_Void_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100665007);
			ISteamUser.NativeMethodInfoPtr_EndAuthSession_Internal_Void_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100665008);
			ISteamUser.NativeMethodInfoPtr__CancelAuthTicket_Private_Static_Void_IntPtr_HAuthTicket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100665009);
			ISteamUser.NativeMethodInfoPtr_CancelAuthTicket_Internal_Void_HAuthTicket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100665010);
			ISteamUser.NativeMethodInfoPtr__UserHasLicenseForApp_Private_Static_UserHasLicenseForAppResult_IntPtr_SteamId_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100665011);
			ISteamUser.NativeMethodInfoPtr_UserHasLicenseForApp_Internal_UserHasLicenseForAppResult_SteamId_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100665012);
			ISteamUser.NativeMethodInfoPtr__BIsBehindNAT_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100665013);
			ISteamUser.NativeMethodInfoPtr_BIsBehindNAT_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100665014);
			ISteamUser.NativeMethodInfoPtr__AdvertiseGame_Private_Static_Void_IntPtr_SteamId_UInt32_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100665015);
			ISteamUser.NativeMethodInfoPtr_AdvertiseGame_Internal_Void_SteamId_UInt32_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100665016);
			ISteamUser.NativeMethodInfoPtr__RequestEncryptedAppTicket_Private_Static_SteamAPICall_t_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100665017);
			ISteamUser.NativeMethodInfoPtr_RequestEncryptedAppTicket_Internal_CallResult_1_EncryptedAppTicketResponse_t_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100665018);
			ISteamUser.NativeMethodInfoPtr__GetEncryptedAppTicket_Private_Static_Boolean_IntPtr_IntPtr_Int32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100665019);
			ISteamUser.NativeMethodInfoPtr_GetEncryptedAppTicket_Internal_Boolean_IntPtr_Int32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100665020);
			ISteamUser.NativeMethodInfoPtr__GetGameBadgeLevel_Private_Static_Int32_IntPtr_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100665021);
			ISteamUser.NativeMethodInfoPtr_GetGameBadgeLevel_Internal_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100665022);
			ISteamUser.NativeMethodInfoPtr__GetPlayerSteamLevel_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100665023);
			ISteamUser.NativeMethodInfoPtr_GetPlayerSteamLevel_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100665024);
			ISteamUser.NativeMethodInfoPtr__RequestStoreAuthURL_Private_Static_SteamAPICall_t_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100665025);
			ISteamUser.NativeMethodInfoPtr_RequestStoreAuthURL_Internal_CallResult_1_StoreAuthURLResponse_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100665026);
			ISteamUser.NativeMethodInfoPtr__BIsPhoneVerified_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100665027);
			ISteamUser.NativeMethodInfoPtr_BIsPhoneVerified_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100665028);
			ISteamUser.NativeMethodInfoPtr__BIsTwoFactorEnabled_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100665029);
			ISteamUser.NativeMethodInfoPtr_BIsTwoFactorEnabled_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100665030);
			ISteamUser.NativeMethodInfoPtr__BIsPhoneIdentifying_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100665031);
			ISteamUser.NativeMethodInfoPtr_BIsPhoneIdentifying_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100665032);
			ISteamUser.NativeMethodInfoPtr__BIsPhoneRequiringVerification_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100665033);
			ISteamUser.NativeMethodInfoPtr_BIsPhoneRequiringVerification_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100665034);
			ISteamUser.NativeMethodInfoPtr__GetMarketEligibility_Private_Static_SteamAPICall_t_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100665035);
			ISteamUser.NativeMethodInfoPtr_GetMarketEligibility_Internal_CallResult_1_MarketEligibilityResponse_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100665036);
			ISteamUser.NativeMethodInfoPtr__GetDurationControl_Private_Static_SteamAPICall_t_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100665037);
			ISteamUser.NativeMethodInfoPtr_GetDurationControl_Internal_CallResult_1_DurationControl_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100665038);
			ISteamUser.NativeMethodInfoPtr__BSetDurationControlOnlineState_Private_Static_Boolean_IntPtr_DurationControlOnlineState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100665039);
			ISteamUser.NativeMethodInfoPtr_BSetDurationControlOnlineState_Internal_Boolean_DurationControlOnlineState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr, 100665040);
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x0003A650 File Offset: 0x00038850
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 930944, RefRangeEnd = 930966, XrefRangeStart = 930944, XrefRangeEnd = 930966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISteamUser(bool IsGameServer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamUser>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref IsGameServer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x0003A698 File Offset: 0x00038898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935849, XrefRangeEnd = 935851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr SteamAPI_SteamUser_v021()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr_SteamAPI_SteamUser_v021_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x0003A6C8 File Offset: 0x000388C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IntPtr GetUserInterfacePointer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamUser.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x0003A710 File Offset: 0x00038910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935851, XrefRangeEnd = 935853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HSteamUser _GetHSteamUser(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr__GetHSteamUser_Private_Static_HSteamUser_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x0003A750 File Offset: 0x00038950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935853, XrefRangeEnd = 935855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HSteamUser GetHSteamUser()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr_GetHSteamUser_Internal_HSteamUser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x0003A78C File Offset: 0x0003898C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935855, XrefRangeEnd = 935857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _BLoggedOn(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr__BLoggedOn_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x0003A7CC File Offset: 0x000389CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 935859, RefRangeEnd = 935860, XrefRangeStart = 935857, XrefRangeEnd = 935859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BLoggedOn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr_BLoggedOn_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x0003A808 File Offset: 0x00038A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935860, XrefRangeEnd = 935862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamId _GetSteamID(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr__GetSteamID_Private_Static_SteamId_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x0003A848 File Offset: 0x00038A48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 935864, RefRangeEnd = 935865, XrefRangeStart = 935862, XrefRangeEnd = 935864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamId GetSteamID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr_GetSteamID_Internal_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x0003A884 File Offset: 0x00038A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935865, XrefRangeEnd = 935867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _InitiateGameConnection_DEPRECATED(IntPtr self, IntPtr pAuthBlob, int cbMaxAuthBlob, SteamId steamIDGameServer, uint unIPServer, ushort usPortServer, bool bSecure)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pAuthBlob;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbMaxAuthBlob;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDGameServer;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unIPServer;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usPortServer;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bSecure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr__InitiateGameConnection_DEPRECATED_Private_Static_Int32_IntPtr_IntPtr_Int32_SteamId_UInt32_UInt16_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x0003A918 File Offset: 0x00038B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935867, XrefRangeEnd = 935869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InitiateGameConnection_DEPRECATED(IntPtr pAuthBlob, int cbMaxAuthBlob, SteamId steamIDGameServer, uint unIPServer, ushort usPortServer, bool bSecure)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pAuthBlob;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbMaxAuthBlob;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDGameServer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unIPServer;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usPortServer;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bSecure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr_InitiateGameConnection_DEPRECATED_Internal_Int32_IntPtr_Int32_SteamId_UInt32_UInt16_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x0003A9A8 File Offset: 0x00038BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935869, XrefRangeEnd = 935871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _TerminateGameConnection_DEPRECATED(IntPtr self, uint unIPServer, ushort usPortServer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unIPServer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usPortServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr__TerminateGameConnection_DEPRECATED_Private_Static_Void_IntPtr_UInt32_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x0003A9F8 File Offset: 0x00038BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935871, XrefRangeEnd = 935873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TerminateGameConnection_DEPRECATED(uint unIPServer, ushort usPortServer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unIPServer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usPortServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr_TerminateGameConnection_DEPRECATED_Internal_Void_UInt32_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x0003AA44 File Offset: 0x00038C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935873, XrefRangeEnd = 935876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _TrackAppUsageEvent(IntPtr self, GameId gameID, int eAppUsageEvent, string pchExtraInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gameID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eAppUsageEvent;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchExtraInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr__TrackAppUsageEvent_Private_Static_Void_IntPtr_GameId_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x0003AAA4 File Offset: 0x00038CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935876, XrefRangeEnd = 935879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TrackAppUsageEvent(GameId gameID, int eAppUsageEvent, string pchExtraInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref gameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eAppUsageEvent;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchExtraInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr_TrackAppUsageEvent_Internal_Void_GameId_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x0003AB04 File Offset: 0x00038D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935879, XrefRangeEnd = 935881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetUserDataFolder(IntPtr self, IntPtr pchBuffer, int cubBuffer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pchBuffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubBuffer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr__GetUserDataFolder_Private_Static_Boolean_IntPtr_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x0003AB60 File Offset: 0x00038D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935881, XrefRangeEnd = 935903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetUserDataFolder(out string pchBuffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr_GetUserDataFolder_Internal_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				pchBuffer = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x0003ABB8 File Offset: 0x00038DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935903, XrefRangeEnd = 935905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _StartVoiceRecording(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr__StartVoiceRecording_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x0003ABEC File Offset: 0x00038DEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 935907, RefRangeEnd = 935908, XrefRangeStart = 935905, XrefRangeEnd = 935907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartVoiceRecording()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr_StartVoiceRecording_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x0003AC20 File Offset: 0x00038E20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935908, XrefRangeEnd = 935910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _StopVoiceRecording(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr__StopVoiceRecording_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x0003AC54 File Offset: 0x00038E54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 935912, RefRangeEnd = 935913, XrefRangeStart = 935910, XrefRangeEnd = 935912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopVoiceRecording()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr_StopVoiceRecording_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x0003AC88 File Offset: 0x00038E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935913, XrefRangeEnd = 935915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VoiceResult _GetAvailableVoice(IntPtr self, ref uint pcbCompressed, ref uint pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pcbCompressed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pcbUncompressed_Deprecated;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nUncompressedVoiceDesiredSampleRate_Deprecated;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr__GetAvailableVoice_Private_Static_VoiceResult_IntPtr_byref_UInt32_byref_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x0003ACF0 File Offset: 0x00038EF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 935917, RefRangeEnd = 935918, XrefRangeStart = 935915, XrefRangeEnd = 935917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VoiceResult GetAvailableVoice(ref uint pcbCompressed, ref uint pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pcbCompressed;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pcbUncompressed_Deprecated;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nUncompressedVoiceDesiredSampleRate_Deprecated;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr_GetAvailableVoice_Internal_VoiceResult_byref_UInt32_byref_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x0003AD58 File Offset: 0x00038F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935918, XrefRangeEnd = 935920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VoiceResult _GetVoice(IntPtr self, bool bWantCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, ref uint nBytesWritten, bool bWantUncompressed_Deprecated, IntPtr pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, ref uint nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bWantCompressed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pDestBuffer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbDestBufferSize;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &nBytesWritten;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bWantUncompressed_Deprecated;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pUncompressedDestBuffer_Deprecated;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbUncompressedDestBufferSize_Deprecated;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &nUncompressBytesWritten_Deprecated;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nUncompressedVoiceDesiredSampleRate_Deprecated;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr__GetVoice_Private_Static_VoiceResult_IntPtr_Boolean_IntPtr_UInt32_byref_UInt32_Boolean_IntPtr_UInt32_byref_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x0003AE18 File Offset: 0x00039018
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 935922, RefRangeEnd = 935924, XrefRangeStart = 935920, XrefRangeEnd = 935922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VoiceResult GetVoice(bool bWantCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, ref uint nBytesWritten, bool bWantUncompressed_Deprecated, IntPtr pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, ref uint nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bWantCompressed;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pDestBuffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbDestBufferSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &nBytesWritten;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bWantUncompressed_Deprecated;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pUncompressedDestBuffer_Deprecated;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbUncompressedDestBufferSize_Deprecated;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &nUncompressBytesWritten_Deprecated;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nUncompressedVoiceDesiredSampleRate_Deprecated;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr_GetVoice_Internal_VoiceResult_Boolean_IntPtr_UInt32_byref_UInt32_Boolean_IntPtr_UInt32_byref_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x0003AED4 File Offset: 0x000390D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935924, XrefRangeEnd = 935926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VoiceResult _DecompressVoice(IntPtr self, IntPtr pCompressed, uint cbCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, ref uint nBytesWritten, uint nDesiredSampleRate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pCompressed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbCompressed;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pDestBuffer;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbDestBufferSize;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &nBytesWritten;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nDesiredSampleRate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr__DecompressVoice_Private_Static_VoiceResult_IntPtr_IntPtr_UInt32_IntPtr_UInt32_byref_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x0003AF68 File Offset: 0x00039168
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 935928, RefRangeEnd = 935931, XrefRangeStart = 935926, XrefRangeEnd = 935928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VoiceResult DecompressVoice(IntPtr pCompressed, uint cbCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, ref uint nBytesWritten, uint nDesiredSampleRate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pCompressed;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbCompressed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pDestBuffer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbDestBufferSize;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &nBytesWritten;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nDesiredSampleRate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr_DecompressVoice_Internal_VoiceResult_IntPtr_UInt32_IntPtr_UInt32_byref_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x0003AFF8 File Offset: 0x000391F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935931, XrefRangeEnd = 935933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint _GetVoiceOptimalSampleRate(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr__GetVoiceOptimalSampleRate_Private_Static_UInt32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x0003B038 File Offset: 0x00039238
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 935935, RefRangeEnd = 935937, XrefRangeStart = 935933, XrefRangeEnd = 935935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetVoiceOptimalSampleRate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr_GetVoiceOptimalSampleRate_Internal_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x0003B074 File Offset: 0x00039274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935937, XrefRangeEnd = 935939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HAuthTicket _GetAuthSessionTicket(IntPtr self, IntPtr pTicket, int cbMaxTicket, ref uint pcbTicket)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pTicket;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbMaxTicket;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pcbTicket;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr__GetAuthSessionTicket_Private_Static_HAuthTicket_IntPtr_IntPtr_Int32_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x0003B0DC File Offset: 0x000392DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 935941, RefRangeEnd = 935943, XrefRangeStart = 935939, XrefRangeEnd = 935941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HAuthTicket GetAuthSessionTicket(IntPtr pTicket, int cbMaxTicket, ref uint pcbTicket)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pTicket;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbMaxTicket;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pcbTicket;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr_GetAuthSessionTicket_Internal_HAuthTicket_IntPtr_Int32_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x0003B144 File Offset: 0x00039344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935943, XrefRangeEnd = 935945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BeginAuthResult _BeginAuthSession(IntPtr self, IntPtr pAuthTicket, int cbAuthTicket, SteamId steamID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pAuthTicket;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbAuthTicket;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr__BeginAuthSession_Private_Static_BeginAuthResult_IntPtr_IntPtr_Int32_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x0003B1AC File Offset: 0x000393AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 935947, RefRangeEnd = 935948, XrefRangeStart = 935945, XrefRangeEnd = 935947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BeginAuthResult BeginAuthSession(IntPtr pAuthTicket, int cbAuthTicket, SteamId steamID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pAuthTicket;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbAuthTicket;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr_BeginAuthSession_Internal_BeginAuthResult_IntPtr_Int32_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x0003B214 File Offset: 0x00039414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935948, XrefRangeEnd = 935950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _EndAuthSession(IntPtr self, SteamId steamID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr__EndAuthSession_Private_Static_Void_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x0003B254 File Offset: 0x00039454
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 935952, RefRangeEnd = 935953, XrefRangeStart = 935950, XrefRangeEnd = 935952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndAuthSession(SteamId steamID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr_EndAuthSession_Internal_Void_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x0003B294 File Offset: 0x00039494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935953, XrefRangeEnd = 935955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _CancelAuthTicket(IntPtr self, HAuthTicket hAuthTicket)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hAuthTicket;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr__CancelAuthTicket_Private_Static_Void_IntPtr_HAuthTicket_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x0003B2D4 File Offset: 0x000394D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935955, XrefRangeEnd = 935957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelAuthTicket(HAuthTicket hAuthTicket)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hAuthTicket;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr_CancelAuthTicket_Internal_Void_HAuthTicket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x0003B314 File Offset: 0x00039514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935957, XrefRangeEnd = 935959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UserHasLicenseForAppResult _UserHasLicenseForApp(IntPtr self, SteamId steamID, AppId appID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr__UserHasLicenseForApp_Private_Static_UserHasLicenseForAppResult_IntPtr_SteamId_AppId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x0003B370 File Offset: 0x00039570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935959, XrefRangeEnd = 935961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UserHasLicenseForAppResult UserHasLicenseForApp(SteamId steamID, AppId appID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr_UserHasLicenseForApp_Internal_UserHasLicenseForAppResult_SteamId_AppId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x0003B3C8 File Offset: 0x000395C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935961, XrefRangeEnd = 935963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _BIsBehindNAT(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr__BIsBehindNAT_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x0003B408 File Offset: 0x00039608
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 935965, RefRangeEnd = 935966, XrefRangeStart = 935963, XrefRangeEnd = 935965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BIsBehindNAT()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr_BIsBehindNAT_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x0003B444 File Offset: 0x00039644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935966, XrefRangeEnd = 935968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _AdvertiseGame(IntPtr self, SteamId steamIDGameServer, uint unIPServer, ushort usPortServer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDGameServer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unIPServer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usPortServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr__AdvertiseGame_Private_Static_Void_IntPtr_SteamId_UInt32_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x0003B4A0 File Offset: 0x000396A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935968, XrefRangeEnd = 935970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AdvertiseGame(SteamId steamIDGameServer, uint unIPServer, ushort usPortServer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDGameServer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unIPServer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usPortServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr_AdvertiseGame_Internal_Void_SteamId_UInt32_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x0003B4FC File Offset: 0x000396FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935970, XrefRangeEnd = 935972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t _RequestEncryptedAppTicket(IntPtr self, IntPtr pDataToInclude, int cbDataToInclude)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pDataToInclude;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbDataToInclude;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr__RequestEncryptedAppTicket_Private_Static_SteamAPICall_t_IntPtr_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x0003B558 File Offset: 0x00039758
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 935977, RefRangeEnd = 935979, XrefRangeStart = 935972, XrefRangeEnd = 935977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<EncryptedAppTicketResponse_t> RequestEncryptedAppTicket(IntPtr pDataToInclude, int cbDataToInclude)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pDataToInclude;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbDataToInclude;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr_RequestEncryptedAppTicket_Internal_CallResult_1_EncryptedAppTicketResponse_t_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new CallResult<EncryptedAppTicketResponse_t>(intPtr);
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x0003B5AC File Offset: 0x000397AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935979, XrefRangeEnd = 935981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetEncryptedAppTicket(IntPtr self, IntPtr pTicket, int cbMaxTicket, ref uint pcbTicket)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pTicket;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbMaxTicket;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pcbTicket;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr__GetEncryptedAppTicket_Private_Static_Boolean_IntPtr_IntPtr_Int32_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x0003B614 File Offset: 0x00039814
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 935983, RefRangeEnd = 935985, XrefRangeStart = 935981, XrefRangeEnd = 935983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetEncryptedAppTicket(IntPtr pTicket, int cbMaxTicket, ref uint pcbTicket)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pTicket;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbMaxTicket;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pcbTicket;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr_GetEncryptedAppTicket_Internal_Boolean_IntPtr_Int32_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x0003B67C File Offset: 0x0003987C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935985, XrefRangeEnd = 935987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetGameBadgeLevel(IntPtr self, int nSeries, bool bFoil)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nSeries;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bFoil;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr__GetGameBadgeLevel_Private_Static_Int32_IntPtr_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x0003B6D8 File Offset: 0x000398D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935987, XrefRangeEnd = 935989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetGameBadgeLevel(int nSeries, bool bFoil)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nSeries;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bFoil;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr_GetGameBadgeLevel_Internal_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x0003B730 File Offset: 0x00039930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935989, XrefRangeEnd = 935991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetPlayerSteamLevel(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr__GetPlayerSteamLevel_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x0003B770 File Offset: 0x00039970
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 935993, RefRangeEnd = 935994, XrefRangeStart = 935991, XrefRangeEnd = 935993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPlayerSteamLevel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr_GetPlayerSteamLevel_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x0003B7AC File Offset: 0x000399AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935994, XrefRangeEnd = 935997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t _RequestStoreAuthURL(IntPtr self, string pchRedirectURL)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchRedirectURL);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr__RequestStoreAuthURL_Private_Static_SteamAPICall_t_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x0003B7FC File Offset: 0x000399FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936003, RefRangeEnd = 936004, XrefRangeStart = 935997, XrefRangeEnd = 936003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<StoreAuthURLResponse_t> RequestStoreAuthURL(string pchRedirectURL)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchRedirectURL);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr_RequestStoreAuthURL_Internal_CallResult_1_StoreAuthURLResponse_t_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CallResult<StoreAuthURLResponse_t>(intPtr);
			}
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x0003B844 File Offset: 0x00039A44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936004, XrefRangeEnd = 936006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _BIsPhoneVerified(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr__BIsPhoneVerified_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x0003B884 File Offset: 0x00039A84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936008, RefRangeEnd = 936009, XrefRangeStart = 936006, XrefRangeEnd = 936008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BIsPhoneVerified()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr_BIsPhoneVerified_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x0003B8C0 File Offset: 0x00039AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936009, XrefRangeEnd = 936011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _BIsTwoFactorEnabled(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr__BIsTwoFactorEnabled_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x0003B900 File Offset: 0x00039B00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936013, RefRangeEnd = 936014, XrefRangeStart = 936011, XrefRangeEnd = 936013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BIsTwoFactorEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr_BIsTwoFactorEnabled_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x0003B93C File Offset: 0x00039B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936014, XrefRangeEnd = 936016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _BIsPhoneIdentifying(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr__BIsPhoneIdentifying_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x0003B97C File Offset: 0x00039B7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936018, RefRangeEnd = 936019, XrefRangeStart = 936016, XrefRangeEnd = 936018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BIsPhoneIdentifying()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr_BIsPhoneIdentifying_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x0003B9B8 File Offset: 0x00039BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936019, XrefRangeEnd = 936021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _BIsPhoneRequiringVerification(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr__BIsPhoneRequiringVerification_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x0003B9F8 File Offset: 0x00039BF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936023, RefRangeEnd = 936024, XrefRangeStart = 936021, XrefRangeEnd = 936023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BIsPhoneRequiringVerification()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr_BIsPhoneRequiringVerification_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x0003BA34 File Offset: 0x00039C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936024, XrefRangeEnd = 936026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t _GetMarketEligibility(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr__GetMarketEligibility_Private_Static_SteamAPICall_t_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x0003BA74 File Offset: 0x00039C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936026, XrefRangeEnd = 936031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<MarketEligibilityResponse_t> GetMarketEligibility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr_GetMarketEligibility_Internal_CallResult_1_MarketEligibilityResponse_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new CallResult<MarketEligibilityResponse_t>(intPtr);
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x0003BAAC File Offset: 0x00039CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936031, XrefRangeEnd = 936033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t _GetDurationControl(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr__GetDurationControl_Private_Static_SteamAPICall_t_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x0003BAEC File Offset: 0x00039CEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936038, RefRangeEnd = 936039, XrefRangeStart = 936033, XrefRangeEnd = 936038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<DurationControl_t> GetDurationControl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr_GetDurationControl_Internal_CallResult_1_DurationControl_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new CallResult<DurationControl_t>(intPtr);
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x0003BB24 File Offset: 0x00039D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936039, XrefRangeEnd = 936041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _BSetDurationControlOnlineState(IntPtr self, DurationControlOnlineState eNewState)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eNewState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr__BSetDurationControlOnlineState_Private_Static_Boolean_IntPtr_DurationControlOnlineState_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x0003BB70 File Offset: 0x00039D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936041, XrefRangeEnd = 936043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BSetDurationControlOnlineState(DurationControlOnlineState eNewState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eNewState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUser.NativeMethodInfoPtr_BSetDurationControlOnlineState_Internal_Boolean_DurationControlOnlineState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x000023EA File Offset: 0x000005EA
		public ISteamUser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000754 RID: 1876
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x04000755 RID: 1877
		private static readonly IntPtr NativeMethodInfoPtr_SteamAPI_SteamUser_v021_Internal_Static_IntPtr_0;

		// Token: 0x04000756 RID: 1878
		private static readonly IntPtr NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0;

		// Token: 0x04000757 RID: 1879
		private static readonly IntPtr NativeMethodInfoPtr__GetHSteamUser_Private_Static_HSteamUser_IntPtr_0;

		// Token: 0x04000758 RID: 1880
		private static readonly IntPtr NativeMethodInfoPtr_GetHSteamUser_Internal_HSteamUser_0;

		// Token: 0x04000759 RID: 1881
		private static readonly IntPtr NativeMethodInfoPtr__BLoggedOn_Private_Static_Boolean_IntPtr_0;

		// Token: 0x0400075A RID: 1882
		private static readonly IntPtr NativeMethodInfoPtr_BLoggedOn_Internal_Boolean_0;

		// Token: 0x0400075B RID: 1883
		private static readonly IntPtr NativeMethodInfoPtr__GetSteamID_Private_Static_SteamId_IntPtr_0;

		// Token: 0x0400075C RID: 1884
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamID_Internal_SteamId_0;

		// Token: 0x0400075D RID: 1885
		private static readonly IntPtr NativeMethodInfoPtr__InitiateGameConnection_DEPRECATED_Private_Static_Int32_IntPtr_IntPtr_Int32_SteamId_UInt32_UInt16_Boolean_0;

		// Token: 0x0400075E RID: 1886
		private static readonly IntPtr NativeMethodInfoPtr_InitiateGameConnection_DEPRECATED_Internal_Int32_IntPtr_Int32_SteamId_UInt32_UInt16_Boolean_0;

		// Token: 0x0400075F RID: 1887
		private static readonly IntPtr NativeMethodInfoPtr__TerminateGameConnection_DEPRECATED_Private_Static_Void_IntPtr_UInt32_UInt16_0;

		// Token: 0x04000760 RID: 1888
		private static readonly IntPtr NativeMethodInfoPtr_TerminateGameConnection_DEPRECATED_Internal_Void_UInt32_UInt16_0;

		// Token: 0x04000761 RID: 1889
		private static readonly IntPtr NativeMethodInfoPtr__TrackAppUsageEvent_Private_Static_Void_IntPtr_GameId_Int32_String_0;

		// Token: 0x04000762 RID: 1890
		private static readonly IntPtr NativeMethodInfoPtr_TrackAppUsageEvent_Internal_Void_GameId_Int32_String_0;

		// Token: 0x04000763 RID: 1891
		private static readonly IntPtr NativeMethodInfoPtr__GetUserDataFolder_Private_Static_Boolean_IntPtr_IntPtr_Int32_0;

		// Token: 0x04000764 RID: 1892
		private static readonly IntPtr NativeMethodInfoPtr_GetUserDataFolder_Internal_Boolean_byref_String_0;

		// Token: 0x04000765 RID: 1893
		private static readonly IntPtr NativeMethodInfoPtr__StartVoiceRecording_Private_Static_Void_IntPtr_0;

		// Token: 0x04000766 RID: 1894
		private static readonly IntPtr NativeMethodInfoPtr_StartVoiceRecording_Internal_Void_0;

		// Token: 0x04000767 RID: 1895
		private static readonly IntPtr NativeMethodInfoPtr__StopVoiceRecording_Private_Static_Void_IntPtr_0;

		// Token: 0x04000768 RID: 1896
		private static readonly IntPtr NativeMethodInfoPtr_StopVoiceRecording_Internal_Void_0;

		// Token: 0x04000769 RID: 1897
		private static readonly IntPtr NativeMethodInfoPtr__GetAvailableVoice_Private_Static_VoiceResult_IntPtr_byref_UInt32_byref_UInt32_UInt32_0;

		// Token: 0x0400076A RID: 1898
		private static readonly IntPtr NativeMethodInfoPtr_GetAvailableVoice_Internal_VoiceResult_byref_UInt32_byref_UInt32_UInt32_0;

		// Token: 0x0400076B RID: 1899
		private static readonly IntPtr NativeMethodInfoPtr__GetVoice_Private_Static_VoiceResult_IntPtr_Boolean_IntPtr_UInt32_byref_UInt32_Boolean_IntPtr_UInt32_byref_UInt32_UInt32_0;

		// Token: 0x0400076C RID: 1900
		private static readonly IntPtr NativeMethodInfoPtr_GetVoice_Internal_VoiceResult_Boolean_IntPtr_UInt32_byref_UInt32_Boolean_IntPtr_UInt32_byref_UInt32_UInt32_0;

		// Token: 0x0400076D RID: 1901
		private static readonly IntPtr NativeMethodInfoPtr__DecompressVoice_Private_Static_VoiceResult_IntPtr_IntPtr_UInt32_IntPtr_UInt32_byref_UInt32_UInt32_0;

		// Token: 0x0400076E RID: 1902
		private static readonly IntPtr NativeMethodInfoPtr_DecompressVoice_Internal_VoiceResult_IntPtr_UInt32_IntPtr_UInt32_byref_UInt32_UInt32_0;

		// Token: 0x0400076F RID: 1903
		private static readonly IntPtr NativeMethodInfoPtr__GetVoiceOptimalSampleRate_Private_Static_UInt32_IntPtr_0;

		// Token: 0x04000770 RID: 1904
		private static readonly IntPtr NativeMethodInfoPtr_GetVoiceOptimalSampleRate_Internal_UInt32_0;

		// Token: 0x04000771 RID: 1905
		private static readonly IntPtr NativeMethodInfoPtr__GetAuthSessionTicket_Private_Static_HAuthTicket_IntPtr_IntPtr_Int32_byref_UInt32_0;

		// Token: 0x04000772 RID: 1906
		private static readonly IntPtr NativeMethodInfoPtr_GetAuthSessionTicket_Internal_HAuthTicket_IntPtr_Int32_byref_UInt32_0;

		// Token: 0x04000773 RID: 1907
		private static readonly IntPtr NativeMethodInfoPtr__BeginAuthSession_Private_Static_BeginAuthResult_IntPtr_IntPtr_Int32_SteamId_0;

		// Token: 0x04000774 RID: 1908
		private static readonly IntPtr NativeMethodInfoPtr_BeginAuthSession_Internal_BeginAuthResult_IntPtr_Int32_SteamId_0;

		// Token: 0x04000775 RID: 1909
		private static readonly IntPtr NativeMethodInfoPtr__EndAuthSession_Private_Static_Void_IntPtr_SteamId_0;

		// Token: 0x04000776 RID: 1910
		private static readonly IntPtr NativeMethodInfoPtr_EndAuthSession_Internal_Void_SteamId_0;

		// Token: 0x04000777 RID: 1911
		private static readonly IntPtr NativeMethodInfoPtr__CancelAuthTicket_Private_Static_Void_IntPtr_HAuthTicket_0;

		// Token: 0x04000778 RID: 1912
		private static readonly IntPtr NativeMethodInfoPtr_CancelAuthTicket_Internal_Void_HAuthTicket_0;

		// Token: 0x04000779 RID: 1913
		private static readonly IntPtr NativeMethodInfoPtr__UserHasLicenseForApp_Private_Static_UserHasLicenseForAppResult_IntPtr_SteamId_AppId_0;

		// Token: 0x0400077A RID: 1914
		private static readonly IntPtr NativeMethodInfoPtr_UserHasLicenseForApp_Internal_UserHasLicenseForAppResult_SteamId_AppId_0;

		// Token: 0x0400077B RID: 1915
		private static readonly IntPtr NativeMethodInfoPtr__BIsBehindNAT_Private_Static_Boolean_IntPtr_0;

		// Token: 0x0400077C RID: 1916
		private static readonly IntPtr NativeMethodInfoPtr_BIsBehindNAT_Internal_Boolean_0;

		// Token: 0x0400077D RID: 1917
		private static readonly IntPtr NativeMethodInfoPtr__AdvertiseGame_Private_Static_Void_IntPtr_SteamId_UInt32_UInt16_0;

		// Token: 0x0400077E RID: 1918
		private static readonly IntPtr NativeMethodInfoPtr_AdvertiseGame_Internal_Void_SteamId_UInt32_UInt16_0;

		// Token: 0x0400077F RID: 1919
		private static readonly IntPtr NativeMethodInfoPtr__RequestEncryptedAppTicket_Private_Static_SteamAPICall_t_IntPtr_IntPtr_Int32_0;

		// Token: 0x04000780 RID: 1920
		private static readonly IntPtr NativeMethodInfoPtr_RequestEncryptedAppTicket_Internal_CallResult_1_EncryptedAppTicketResponse_t_IntPtr_Int32_0;

		// Token: 0x04000781 RID: 1921
		private static readonly IntPtr NativeMethodInfoPtr__GetEncryptedAppTicket_Private_Static_Boolean_IntPtr_IntPtr_Int32_byref_UInt32_0;

		// Token: 0x04000782 RID: 1922
		private static readonly IntPtr NativeMethodInfoPtr_GetEncryptedAppTicket_Internal_Boolean_IntPtr_Int32_byref_UInt32_0;

		// Token: 0x04000783 RID: 1923
		private static readonly IntPtr NativeMethodInfoPtr__GetGameBadgeLevel_Private_Static_Int32_IntPtr_Int32_Boolean_0;

		// Token: 0x04000784 RID: 1924
		private static readonly IntPtr NativeMethodInfoPtr_GetGameBadgeLevel_Internal_Int32_Int32_Boolean_0;

		// Token: 0x04000785 RID: 1925
		private static readonly IntPtr NativeMethodInfoPtr__GetPlayerSteamLevel_Private_Static_Int32_IntPtr_0;

		// Token: 0x04000786 RID: 1926
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerSteamLevel_Internal_Int32_0;

		// Token: 0x04000787 RID: 1927
		private static readonly IntPtr NativeMethodInfoPtr__RequestStoreAuthURL_Private_Static_SteamAPICall_t_IntPtr_String_0;

		// Token: 0x04000788 RID: 1928
		private static readonly IntPtr NativeMethodInfoPtr_RequestStoreAuthURL_Internal_CallResult_1_StoreAuthURLResponse_t_String_0;

		// Token: 0x04000789 RID: 1929
		private static readonly IntPtr NativeMethodInfoPtr__BIsPhoneVerified_Private_Static_Boolean_IntPtr_0;

		// Token: 0x0400078A RID: 1930
		private static readonly IntPtr NativeMethodInfoPtr_BIsPhoneVerified_Internal_Boolean_0;

		// Token: 0x0400078B RID: 1931
		private static readonly IntPtr NativeMethodInfoPtr__BIsTwoFactorEnabled_Private_Static_Boolean_IntPtr_0;

		// Token: 0x0400078C RID: 1932
		private static readonly IntPtr NativeMethodInfoPtr_BIsTwoFactorEnabled_Internal_Boolean_0;

		// Token: 0x0400078D RID: 1933
		private static readonly IntPtr NativeMethodInfoPtr__BIsPhoneIdentifying_Private_Static_Boolean_IntPtr_0;

		// Token: 0x0400078E RID: 1934
		private static readonly IntPtr NativeMethodInfoPtr_BIsPhoneIdentifying_Internal_Boolean_0;

		// Token: 0x0400078F RID: 1935
		private static readonly IntPtr NativeMethodInfoPtr__BIsPhoneRequiringVerification_Private_Static_Boolean_IntPtr_0;

		// Token: 0x04000790 RID: 1936
		private static readonly IntPtr NativeMethodInfoPtr_BIsPhoneRequiringVerification_Internal_Boolean_0;

		// Token: 0x04000791 RID: 1937
		private static readonly IntPtr NativeMethodInfoPtr__GetMarketEligibility_Private_Static_SteamAPICall_t_IntPtr_0;

		// Token: 0x04000792 RID: 1938
		private static readonly IntPtr NativeMethodInfoPtr_GetMarketEligibility_Internal_CallResult_1_MarketEligibilityResponse_t_0;

		// Token: 0x04000793 RID: 1939
		private static readonly IntPtr NativeMethodInfoPtr__GetDurationControl_Private_Static_SteamAPICall_t_IntPtr_0;

		// Token: 0x04000794 RID: 1940
		private static readonly IntPtr NativeMethodInfoPtr_GetDurationControl_Internal_CallResult_1_DurationControl_t_0;

		// Token: 0x04000795 RID: 1941
		private static readonly IntPtr NativeMethodInfoPtr__BSetDurationControlOnlineState_Private_Static_Boolean_IntPtr_DurationControlOnlineState_0;

		// Token: 0x04000796 RID: 1942
		private static readonly IntPtr NativeMethodInfoPtr_BSetDurationControlOnlineState_Internal_Boolean_DurationControlOnlineState_0;
	}
}
