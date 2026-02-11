using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x0200000F RID: 15
	public class ISteamClient : SteamInterface
	{
		// Token: 0x060000A8 RID: 168 RVA: 0x000116B0 File Offset: 0x0000F8B0
		// Note: this type is marked as 'beforefieldinit'.
		static ISteamClient()
		{
			Il2CppClassPointerStore<ISteamClient>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "ISteamClient");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr);
			ISteamClient.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663437);
			ISteamClient.NativeMethodInfoPtr__CreateSteamPipe_Private_Static_HSteamPipe_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663438);
			ISteamClient.NativeMethodInfoPtr_CreateSteamPipe_Internal_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663439);
			ISteamClient.NativeMethodInfoPtr__BReleaseSteamPipe_Private_Static_Boolean_IntPtr_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663440);
			ISteamClient.NativeMethodInfoPtr_BReleaseSteamPipe_Internal_Boolean_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663441);
			ISteamClient.NativeMethodInfoPtr__ConnectToGlobalUser_Private_Static_HSteamUser_IntPtr_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663442);
			ISteamClient.NativeMethodInfoPtr_ConnectToGlobalUser_Internal_HSteamUser_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663443);
			ISteamClient.NativeMethodInfoPtr__CreateLocalUser_Private_Static_HSteamUser_IntPtr_byref_HSteamPipe_AccountType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663444);
			ISteamClient.NativeMethodInfoPtr_CreateLocalUser_Internal_HSteamUser_byref_HSteamPipe_AccountType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663445);
			ISteamClient.NativeMethodInfoPtr__ReleaseUser_Private_Static_Void_IntPtr_HSteamPipe_HSteamUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663446);
			ISteamClient.NativeMethodInfoPtr_ReleaseUser_Internal_Void_HSteamPipe_HSteamUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663447);
			ISteamClient.NativeMethodInfoPtr__GetISteamUser_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663448);
			ISteamClient.NativeMethodInfoPtr_GetISteamUser_Internal_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663449);
			ISteamClient.NativeMethodInfoPtr__GetISteamGameServer_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663450);
			ISteamClient.NativeMethodInfoPtr_GetISteamGameServer_Internal_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663451);
			ISteamClient.NativeMethodInfoPtr__SetLocalIPBinding_Private_Static_Void_IntPtr_byref_SteamIPAddress_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663452);
			ISteamClient.NativeMethodInfoPtr_SetLocalIPBinding_Internal_Void_byref_SteamIPAddress_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663453);
			ISteamClient.NativeMethodInfoPtr__GetISteamFriends_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663454);
			ISteamClient.NativeMethodInfoPtr_GetISteamFriends_Internal_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663455);
			ISteamClient.NativeMethodInfoPtr__GetISteamUtils_Private_Static_IntPtr_IntPtr_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663456);
			ISteamClient.NativeMethodInfoPtr_GetISteamUtils_Internal_IntPtr_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663457);
			ISteamClient.NativeMethodInfoPtr__GetISteamMatchmaking_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663458);
			ISteamClient.NativeMethodInfoPtr_GetISteamMatchmaking_Internal_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663459);
			ISteamClient.NativeMethodInfoPtr__GetISteamMatchmakingServers_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663460);
			ISteamClient.NativeMethodInfoPtr_GetISteamMatchmakingServers_Internal_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663461);
			ISteamClient.NativeMethodInfoPtr__GetISteamGenericInterface_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663462);
			ISteamClient.NativeMethodInfoPtr_GetISteamGenericInterface_Internal_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663463);
			ISteamClient.NativeMethodInfoPtr__GetISteamUserStats_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663464);
			ISteamClient.NativeMethodInfoPtr_GetISteamUserStats_Internal_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663465);
			ISteamClient.NativeMethodInfoPtr__GetISteamGameServerStats_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663466);
			ISteamClient.NativeMethodInfoPtr_GetISteamGameServerStats_Internal_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663467);
			ISteamClient.NativeMethodInfoPtr__GetISteamApps_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663468);
			ISteamClient.NativeMethodInfoPtr_GetISteamApps_Internal_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663469);
			ISteamClient.NativeMethodInfoPtr__GetISteamNetworking_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663470);
			ISteamClient.NativeMethodInfoPtr_GetISteamNetworking_Internal_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663471);
			ISteamClient.NativeMethodInfoPtr__GetISteamRemoteStorage_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663472);
			ISteamClient.NativeMethodInfoPtr_GetISteamRemoteStorage_Internal_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663473);
			ISteamClient.NativeMethodInfoPtr__GetISteamScreenshots_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663474);
			ISteamClient.NativeMethodInfoPtr_GetISteamScreenshots_Internal_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663475);
			ISteamClient.NativeMethodInfoPtr__GetISteamGameSearch_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663476);
			ISteamClient.NativeMethodInfoPtr_GetISteamGameSearch_Internal_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663477);
			ISteamClient.NativeMethodInfoPtr__GetIPCCallCount_Private_Static_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663478);
			ISteamClient.NativeMethodInfoPtr_GetIPCCallCount_Internal_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663479);
			ISteamClient.NativeMethodInfoPtr__SetWarningMessageHook_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663480);
			ISteamClient.NativeMethodInfoPtr_SetWarningMessageHook_Internal_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663481);
			ISteamClient.NativeMethodInfoPtr__BShutdownIfAllPipesClosed_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663482);
			ISteamClient.NativeMethodInfoPtr_BShutdownIfAllPipesClosed_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663483);
			ISteamClient.NativeMethodInfoPtr__GetISteamHTTP_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663484);
			ISteamClient.NativeMethodInfoPtr_GetISteamHTTP_Internal_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663485);
			ISteamClient.NativeMethodInfoPtr__GetISteamController_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663486);
			ISteamClient.NativeMethodInfoPtr_GetISteamController_Internal_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663487);
			ISteamClient.NativeMethodInfoPtr__GetISteamUGC_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663488);
			ISteamClient.NativeMethodInfoPtr_GetISteamUGC_Internal_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663489);
			ISteamClient.NativeMethodInfoPtr__GetISteamAppList_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663490);
			ISteamClient.NativeMethodInfoPtr_GetISteamAppList_Internal_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663491);
			ISteamClient.NativeMethodInfoPtr__GetISteamMusic_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663492);
			ISteamClient.NativeMethodInfoPtr_GetISteamMusic_Internal_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663493);
			ISteamClient.NativeMethodInfoPtr__GetISteamMusicRemote_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663494);
			ISteamClient.NativeMethodInfoPtr_GetISteamMusicRemote_Internal_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663495);
			ISteamClient.NativeMethodInfoPtr__GetISteamHTMLSurface_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663496);
			ISteamClient.NativeMethodInfoPtr_GetISteamHTMLSurface_Internal_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663497);
			ISteamClient.NativeMethodInfoPtr__GetISteamInventory_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663498);
			ISteamClient.NativeMethodInfoPtr_GetISteamInventory_Internal_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663499);
			ISteamClient.NativeMethodInfoPtr__GetISteamVideo_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663500);
			ISteamClient.NativeMethodInfoPtr_GetISteamVideo_Internal_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663501);
			ISteamClient.NativeMethodInfoPtr__GetISteamParentalSettings_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663502);
			ISteamClient.NativeMethodInfoPtr_GetISteamParentalSettings_Internal_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663503);
			ISteamClient.NativeMethodInfoPtr__GetISteamInput_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663504);
			ISteamClient.NativeMethodInfoPtr_GetISteamInput_Internal_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663505);
			ISteamClient.NativeMethodInfoPtr__GetISteamParties_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663506);
			ISteamClient.NativeMethodInfoPtr_GetISteamParties_Internal_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663507);
			ISteamClient.NativeMethodInfoPtr__GetISteamRemotePlay_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663508);
			ISteamClient.NativeMethodInfoPtr_GetISteamRemotePlay_Internal_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr, 100663509);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00011C94 File Offset: 0x0000FE94
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 930944, RefRangeEnd = 930966, XrefRangeStart = 930944, XrefRangeEnd = 930966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISteamClient(bool IsGameServer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamClient>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref IsGameServer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00011CDC File Offset: 0x0000FEDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931263, XrefRangeEnd = 931265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HSteamPipe _CreateSteamPipe(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr__CreateSteamPipe_Private_Static_HSteamPipe_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00011D1C File Offset: 0x0000FF1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931265, XrefRangeEnd = 931267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HSteamPipe CreateSteamPipe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr_CreateSteamPipe_Internal_HSteamPipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00011D58 File Offset: 0x0000FF58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931267, XrefRangeEnd = 931269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _BReleaseSteamPipe(IntPtr self, HSteamPipe hSteamPipe)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr__BReleaseSteamPipe_Private_Static_Boolean_IntPtr_HSteamPipe_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00011DA4 File Offset: 0x0000FFA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931269, XrefRangeEnd = 931271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BReleaseSteamPipe(HSteamPipe hSteamPipe)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamPipe;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr_BReleaseSteamPipe_Internal_Boolean_HSteamPipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00011DF0 File Offset: 0x0000FFF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931271, XrefRangeEnd = 931273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HSteamUser _ConnectToGlobalUser(IntPtr self, HSteamPipe hSteamPipe)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr__ConnectToGlobalUser_Private_Static_HSteamUser_IntPtr_HSteamPipe_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00011E3C File Offset: 0x0001003C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931273, XrefRangeEnd = 931275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HSteamUser ConnectToGlobalUser(HSteamPipe hSteamPipe)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamPipe;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr_ConnectToGlobalUser_Internal_HSteamUser_HSteamPipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00011E88 File Offset: 0x00010088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931275, XrefRangeEnd = 931277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HSteamUser _CreateLocalUser(IntPtr self, ref HSteamPipe phSteamPipe, AccountType eAccountType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &phSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eAccountType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr__CreateLocalUser_Private_Static_HSteamUser_IntPtr_byref_HSteamPipe_AccountType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00011EE4 File Offset: 0x000100E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931277, XrefRangeEnd = 931279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HSteamUser CreateLocalUser(ref HSteamPipe phSteamPipe, AccountType eAccountType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &phSteamPipe;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eAccountType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr_CreateLocalUser_Internal_HSteamUser_byref_HSteamPipe_AccountType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00011F3C File Offset: 0x0001013C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931279, XrefRangeEnd = 931281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _ReleaseUser(IntPtr self, HSteamPipe hSteamPipe, HSteamUser hUser)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hUser;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr__ReleaseUser_Private_Static_Void_IntPtr_HSteamPipe_HSteamUser_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00011F8C File Offset: 0x0001018C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931281, XrefRangeEnd = 931283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseUser(HSteamPipe hSteamPipe, HSteamUser hUser)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamPipe;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hUser;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr_ReleaseUser_Internal_Void_HSteamPipe_HSteamUser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00011FD8 File Offset: 0x000101D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931283, XrefRangeEnd = 931286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr _GetISteamUser(IntPtr self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamUser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr__GetISteamUser_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00012044 File Offset: 0x00010244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931286, XrefRangeEnd = 931289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetISteamUser(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr_GetISteamUser_Internal_IntPtr_HSteamUser_HSteamPipe_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000120B0 File Offset: 0x000102B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931289, XrefRangeEnd = 931292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr _GetISteamGameServer(IntPtr self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamUser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr__GetISteamGameServer_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0001211C File Offset: 0x0001031C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931292, XrefRangeEnd = 931295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetISteamGameServer(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr_GetISteamGameServer_Internal_IntPtr_HSteamUser_HSteamPipe_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00012188 File Offset: 0x00010388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931295, XrefRangeEnd = 931297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SetLocalIPBinding(IntPtr self, ref SteamIPAddress unIP, ushort usPort)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &unIP;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usPort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr__SetLocalIPBinding_Private_Static_Void_IntPtr_byref_SteamIPAddress_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000121D8 File Offset: 0x000103D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931297, XrefRangeEnd = 931299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLocalIPBinding(ref SteamIPAddress unIP, ushort usPort)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &unIP;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usPort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr_SetLocalIPBinding_Internal_Void_byref_SteamIPAddress_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00012224 File Offset: 0x00010424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931299, XrefRangeEnd = 931302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr _GetISteamFriends(IntPtr self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamUser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr__GetISteamFriends_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00012290 File Offset: 0x00010490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931302, XrefRangeEnd = 931305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetISteamFriends(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr_GetISteamFriends_Internal_IntPtr_HSteamUser_HSteamPipe_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000122FC File Offset: 0x000104FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931305, XrefRangeEnd = 931308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr _GetISteamUtils(IntPtr self, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr__GetISteamUtils_Private_Static_IntPtr_IntPtr_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0001235C File Offset: 0x0001055C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931308, XrefRangeEnd = 931311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetISteamUtils(HSteamPipe hSteamPipe, string pchVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamPipe;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr_GetISteamUtils_Internal_IntPtr_HSteamPipe_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000123B8 File Offset: 0x000105B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931311, XrefRangeEnd = 931314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr _GetISteamMatchmaking(IntPtr self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamUser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr__GetISteamMatchmaking_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00012424 File Offset: 0x00010624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931314, XrefRangeEnd = 931317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetISteamMatchmaking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr_GetISteamMatchmaking_Internal_IntPtr_HSteamUser_HSteamPipe_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00012490 File Offset: 0x00010690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931317, XrefRangeEnd = 931320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr _GetISteamMatchmakingServers(IntPtr self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamUser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr__GetISteamMatchmakingServers_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000124FC File Offset: 0x000106FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931320, XrefRangeEnd = 931323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetISteamMatchmakingServers(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr_GetISteamMatchmakingServers_Internal_IntPtr_HSteamUser_HSteamPipe_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00012568 File Offset: 0x00010768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931323, XrefRangeEnd = 931326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr _GetISteamGenericInterface(IntPtr self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamUser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr__GetISteamGenericInterface_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000125D4 File Offset: 0x000107D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931326, XrefRangeEnd = 931329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetISteamGenericInterface(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr_GetISteamGenericInterface_Internal_IntPtr_HSteamUser_HSteamPipe_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00012640 File Offset: 0x00010840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931329, XrefRangeEnd = 931332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr _GetISteamUserStats(IntPtr self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamUser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr__GetISteamUserStats_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000126AC File Offset: 0x000108AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931332, XrefRangeEnd = 931335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetISteamUserStats(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr_GetISteamUserStats_Internal_IntPtr_HSteamUser_HSteamPipe_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00012718 File Offset: 0x00010918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931335, XrefRangeEnd = 931338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr _GetISteamGameServerStats(IntPtr self, HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamuser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr__GetISteamGameServerStats_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00012784 File Offset: 0x00010984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931338, XrefRangeEnd = 931341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetISteamGameServerStats(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamuser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr_GetISteamGameServerStats_Internal_IntPtr_HSteamUser_HSteamPipe_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000127F0 File Offset: 0x000109F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931341, XrefRangeEnd = 931344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr _GetISteamApps(IntPtr self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamUser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr__GetISteamApps_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0001285C File Offset: 0x00010A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931344, XrefRangeEnd = 931347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetISteamApps(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr_GetISteamApps_Internal_IntPtr_HSteamUser_HSteamPipe_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000128C8 File Offset: 0x00010AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931347, XrefRangeEnd = 931350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr _GetISteamNetworking(IntPtr self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamUser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr__GetISteamNetworking_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00012934 File Offset: 0x00010B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931350, XrefRangeEnd = 931353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetISteamNetworking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr_GetISteamNetworking_Internal_IntPtr_HSteamUser_HSteamPipe_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000129A0 File Offset: 0x00010BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931353, XrefRangeEnd = 931356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr _GetISteamRemoteStorage(IntPtr self, HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamuser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr__GetISteamRemoteStorage_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00012A0C File Offset: 0x00010C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931356, XrefRangeEnd = 931359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetISteamRemoteStorage(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamuser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr_GetISteamRemoteStorage_Internal_IntPtr_HSteamUser_HSteamPipe_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00012A78 File Offset: 0x00010C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931359, XrefRangeEnd = 931362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr _GetISteamScreenshots(IntPtr self, HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamuser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr__GetISteamScreenshots_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00012AE4 File Offset: 0x00010CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931362, XrefRangeEnd = 931365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetISteamScreenshots(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamuser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr_GetISteamScreenshots_Internal_IntPtr_HSteamUser_HSteamPipe_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00012B50 File Offset: 0x00010D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931365, XrefRangeEnd = 931368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr _GetISteamGameSearch(IntPtr self, HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamuser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr__GetISteamGameSearch_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00012BBC File Offset: 0x00010DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931368, XrefRangeEnd = 931371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetISteamGameSearch(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamuser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr_GetISteamGameSearch_Internal_IntPtr_HSteamUser_HSteamPipe_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00012C28 File Offset: 0x00010E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931371, XrefRangeEnd = 931373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint _GetIPCCallCount(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr__GetIPCCallCount_Private_Static_UInt32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00012C68 File Offset: 0x00010E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931373, XrefRangeEnd = 931375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetIPCCallCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr_GetIPCCallCount_Internal_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00012CA4 File Offset: 0x00010EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931375, XrefRangeEnd = 931377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SetWarningMessageHook(IntPtr self, IntPtr pFunction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pFunction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr__SetWarningMessageHook_Private_Static_Void_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00012CE4 File Offset: 0x00010EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931377, XrefRangeEnd = 931379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWarningMessageHook(IntPtr pFunction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pFunction;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr_SetWarningMessageHook_Internal_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00012D24 File Offset: 0x00010F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931379, XrefRangeEnd = 931381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _BShutdownIfAllPipesClosed(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr__BShutdownIfAllPipesClosed_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00012D64 File Offset: 0x00010F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931381, XrefRangeEnd = 931383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BShutdownIfAllPipesClosed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr_BShutdownIfAllPipesClosed_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00012DA0 File Offset: 0x00010FA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931383, XrefRangeEnd = 931386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr _GetISteamHTTP(IntPtr self, HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamuser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr__GetISteamHTTP_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00012E0C File Offset: 0x0001100C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931386, XrefRangeEnd = 931389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetISteamHTTP(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamuser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr_GetISteamHTTP_Internal_IntPtr_HSteamUser_HSteamPipe_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00012E78 File Offset: 0x00011078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931389, XrefRangeEnd = 931392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr _GetISteamController(IntPtr self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamUser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr__GetISteamController_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00012EE4 File Offset: 0x000110E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931392, XrefRangeEnd = 931395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetISteamController(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr_GetISteamController_Internal_IntPtr_HSteamUser_HSteamPipe_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00012F50 File Offset: 0x00011150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931395, XrefRangeEnd = 931398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr _GetISteamUGC(IntPtr self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamUser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr__GetISteamUGC_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00012FBC File Offset: 0x000111BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931398, XrefRangeEnd = 931401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetISteamUGC(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr_GetISteamUGC_Internal_IntPtr_HSteamUser_HSteamPipe_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00013028 File Offset: 0x00011228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931401, XrefRangeEnd = 931404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr _GetISteamAppList(IntPtr self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamUser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr__GetISteamAppList_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00013094 File Offset: 0x00011294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931404, XrefRangeEnd = 931407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetISteamAppList(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr_GetISteamAppList_Internal_IntPtr_HSteamUser_HSteamPipe_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00013100 File Offset: 0x00011300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931407, XrefRangeEnd = 931410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr _GetISteamMusic(IntPtr self, HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamuser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr__GetISteamMusic_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0001316C File Offset: 0x0001136C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931410, XrefRangeEnd = 931413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetISteamMusic(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamuser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr_GetISteamMusic_Internal_IntPtr_HSteamUser_HSteamPipe_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000131D8 File Offset: 0x000113D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931413, XrefRangeEnd = 931416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr _GetISteamMusicRemote(IntPtr self, HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamuser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr__GetISteamMusicRemote_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00013244 File Offset: 0x00011444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931416, XrefRangeEnd = 931419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetISteamMusicRemote(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamuser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr_GetISteamMusicRemote_Internal_IntPtr_HSteamUser_HSteamPipe_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000132B0 File Offset: 0x000114B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931419, XrefRangeEnd = 931422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr _GetISteamHTMLSurface(IntPtr self, HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamuser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr__GetISteamHTMLSurface_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0001331C File Offset: 0x0001151C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931422, XrefRangeEnd = 931425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetISteamHTMLSurface(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamuser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr_GetISteamHTMLSurface_Internal_IntPtr_HSteamUser_HSteamPipe_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00013388 File Offset: 0x00011588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931425, XrefRangeEnd = 931428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr _GetISteamInventory(IntPtr self, HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamuser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr__GetISteamInventory_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000133F4 File Offset: 0x000115F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931428, XrefRangeEnd = 931431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetISteamInventory(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamuser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr_GetISteamInventory_Internal_IntPtr_HSteamUser_HSteamPipe_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00013460 File Offset: 0x00011660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931431, XrefRangeEnd = 931434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr _GetISteamVideo(IntPtr self, HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamuser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr__GetISteamVideo_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000134CC File Offset: 0x000116CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931434, XrefRangeEnd = 931437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetISteamVideo(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamuser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr_GetISteamVideo_Internal_IntPtr_HSteamUser_HSteamPipe_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00013538 File Offset: 0x00011738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931437, XrefRangeEnd = 931440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr _GetISteamParentalSettings(IntPtr self, HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamuser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr__GetISteamParentalSettings_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000135A4 File Offset: 0x000117A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931440, XrefRangeEnd = 931443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetISteamParentalSettings(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamuser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr_GetISteamParentalSettings_Internal_IntPtr_HSteamUser_HSteamPipe_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00013610 File Offset: 0x00011810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931443, XrefRangeEnd = 931446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr _GetISteamInput(IntPtr self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamUser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr__GetISteamInput_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0001367C File Offset: 0x0001187C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931446, XrefRangeEnd = 931449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetISteamInput(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr_GetISteamInput_Internal_IntPtr_HSteamUser_HSteamPipe_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000136E8 File Offset: 0x000118E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931449, XrefRangeEnd = 931452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr _GetISteamParties(IntPtr self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamUser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr__GetISteamParties_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00013754 File Offset: 0x00011954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931452, XrefRangeEnd = 931455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetISteamParties(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr_GetISteamParties_Internal_IntPtr_HSteamUser_HSteamPipe_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000137C0 File Offset: 0x000119C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931455, XrefRangeEnd = 931458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr _GetISteamRemotePlay(IntPtr self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamUser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr__GetISteamRemotePlay_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0001382C File Offset: 0x00011A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931458, XrefRangeEnd = 931461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetISteamRemotePlay(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamClient.NativeMethodInfoPtr_GetISteamRemotePlay_Internal_IntPtr_HSteamUser_HSteamPipe_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000022E5 File Offset: 0x000004E5
		public ISteamClient(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeMethodInfoPtr__CreateSteamPipe_Private_Static_HSteamPipe_IntPtr_0;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeMethodInfoPtr_CreateSteamPipe_Internal_HSteamPipe_0;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr__BReleaseSteamPipe_Private_Static_Boolean_IntPtr_HSteamPipe_0;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr_BReleaseSteamPipe_Internal_Boolean_HSteamPipe_0;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr__ConnectToGlobalUser_Private_Static_HSteamUser_IntPtr_HSteamPipe_0;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr_ConnectToGlobalUser_Internal_HSteamUser_HSteamPipe_0;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeMethodInfoPtr__CreateLocalUser_Private_Static_HSteamUser_IntPtr_byref_HSteamPipe_AccountType_0;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr_CreateLocalUser_Internal_HSteamUser_byref_HSteamPipe_AccountType_0;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr__ReleaseUser_Private_Static_Void_IntPtr_HSteamPipe_HSteamUser_0;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseUser_Internal_Void_HSteamPipe_HSteamUser_0;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeMethodInfoPtr__GetISteamUser_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamUser_Internal_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeMethodInfoPtr__GetISteamGameServer_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamGameServer_Internal_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeMethodInfoPtr__SetLocalIPBinding_Private_Static_Void_IntPtr_byref_SteamIPAddress_UInt16_0;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeMethodInfoPtr_SetLocalIPBinding_Internal_Void_byref_SteamIPAddress_UInt16_0;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeMethodInfoPtr__GetISteamFriends_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamFriends_Internal_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeMethodInfoPtr__GetISteamUtils_Private_Static_IntPtr_IntPtr_HSteamPipe_String_0;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamUtils_Internal_IntPtr_HSteamPipe_String_0;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeMethodInfoPtr__GetISteamMatchmaking_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamMatchmaking_Internal_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeMethodInfoPtr__GetISteamMatchmakingServers_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamMatchmakingServers_Internal_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeMethodInfoPtr__GetISteamGenericInterface_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamGenericInterface_Internal_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeMethodInfoPtr__GetISteamUserStats_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamUserStats_Internal_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeMethodInfoPtr__GetISteamGameServerStats_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamGameServerStats_Internal_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeMethodInfoPtr__GetISteamApps_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamApps_Internal_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeMethodInfoPtr__GetISteamNetworking_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamNetworking_Internal_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeMethodInfoPtr__GetISteamRemoteStorage_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamRemoteStorage_Internal_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeMethodInfoPtr__GetISteamScreenshots_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamScreenshots_Internal_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeMethodInfoPtr__GetISteamGameSearch_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamGameSearch_Internal_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeMethodInfoPtr__GetIPCCallCount_Private_Static_UInt32_IntPtr_0;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeMethodInfoPtr_GetIPCCallCount_Internal_UInt32_0;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeMethodInfoPtr__SetWarningMessageHook_Private_Static_Void_IntPtr_IntPtr_0;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeMethodInfoPtr_SetWarningMessageHook_Internal_Void_IntPtr_0;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeMethodInfoPtr__BShutdownIfAllPipesClosed_Private_Static_Boolean_IntPtr_0;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeMethodInfoPtr_BShutdownIfAllPipesClosed_Internal_Boolean_0;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeMethodInfoPtr__GetISteamHTTP_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamHTTP_Internal_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeMethodInfoPtr__GetISteamController_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamController_Internal_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeMethodInfoPtr__GetISteamUGC_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamUGC_Internal_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeMethodInfoPtr__GetISteamAppList_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamAppList_Internal_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeMethodInfoPtr__GetISteamMusic_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamMusic_Internal_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeMethodInfoPtr__GetISteamMusicRemote_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamMusicRemote_Internal_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeMethodInfoPtr__GetISteamHTMLSurface_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamHTMLSurface_Internal_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeMethodInfoPtr__GetISteamInventory_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamInventory_Internal_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeMethodInfoPtr__GetISteamVideo_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamVideo_Internal_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeMethodInfoPtr__GetISteamParentalSettings_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamParentalSettings_Internal_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeMethodInfoPtr__GetISteamInput_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamInput_Internal_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeMethodInfoPtr__GetISteamParties_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamParties_Internal_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeMethodInfoPtr__GetISteamRemotePlay_Private_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamRemotePlay_Internal_IntPtr_HSteamUser_HSteamPipe_String_0;
	}
}
