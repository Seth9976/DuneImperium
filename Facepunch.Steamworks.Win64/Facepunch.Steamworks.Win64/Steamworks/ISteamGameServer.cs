using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x02000013 RID: 19
	public class ISteamGameServer : SteamInterface
	{
		// Token: 0x060001FA RID: 506 RVA: 0x00019E90 File Offset: 0x00018090
		// Note: this type is marked as 'beforefieldinit'.
		static ISteamGameServer()
		{
			Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "ISteamGameServer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr);
			ISteamGameServer.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663767);
			ISteamGameServer.NativeMethodInfoPtr_SteamAPI_SteamGameServer_v014_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663768);
			ISteamGameServer.NativeMethodInfoPtr_GetServerInterfacePointer_Public_Virtual_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663769);
			ISteamGameServer.NativeMethodInfoPtr__SetProduct_Private_Static_Void_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663770);
			ISteamGameServer.NativeMethodInfoPtr_SetProduct_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663771);
			ISteamGameServer.NativeMethodInfoPtr__SetGameDescription_Private_Static_Void_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663772);
			ISteamGameServer.NativeMethodInfoPtr_SetGameDescription_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663773);
			ISteamGameServer.NativeMethodInfoPtr__SetModDir_Private_Static_Void_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663774);
			ISteamGameServer.NativeMethodInfoPtr_SetModDir_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663775);
			ISteamGameServer.NativeMethodInfoPtr__SetDedicatedServer_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663776);
			ISteamGameServer.NativeMethodInfoPtr_SetDedicatedServer_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663777);
			ISteamGameServer.NativeMethodInfoPtr__LogOn_Private_Static_Void_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663778);
			ISteamGameServer.NativeMethodInfoPtr_LogOn_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663779);
			ISteamGameServer.NativeMethodInfoPtr__LogOnAnonymous_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663780);
			ISteamGameServer.NativeMethodInfoPtr_LogOnAnonymous_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663781);
			ISteamGameServer.NativeMethodInfoPtr__LogOff_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663782);
			ISteamGameServer.NativeMethodInfoPtr_LogOff_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663783);
			ISteamGameServer.NativeMethodInfoPtr__BLoggedOn_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663784);
			ISteamGameServer.NativeMethodInfoPtr_BLoggedOn_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663785);
			ISteamGameServer.NativeMethodInfoPtr__BSecure_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663786);
			ISteamGameServer.NativeMethodInfoPtr_BSecure_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663787);
			ISteamGameServer.NativeMethodInfoPtr__GetSteamID_Private_Static_SteamId_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663788);
			ISteamGameServer.NativeMethodInfoPtr_GetSteamID_Internal_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663789);
			ISteamGameServer.NativeMethodInfoPtr__WasRestartRequested_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663790);
			ISteamGameServer.NativeMethodInfoPtr_WasRestartRequested_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663791);
			ISteamGameServer.NativeMethodInfoPtr__SetMaxPlayerCount_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663792);
			ISteamGameServer.NativeMethodInfoPtr_SetMaxPlayerCount_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663793);
			ISteamGameServer.NativeMethodInfoPtr__SetBotPlayerCount_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663794);
			ISteamGameServer.NativeMethodInfoPtr_SetBotPlayerCount_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663795);
			ISteamGameServer.NativeMethodInfoPtr__SetServerName_Private_Static_Void_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663796);
			ISteamGameServer.NativeMethodInfoPtr_SetServerName_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663797);
			ISteamGameServer.NativeMethodInfoPtr__SetMapName_Private_Static_Void_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663798);
			ISteamGameServer.NativeMethodInfoPtr_SetMapName_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663799);
			ISteamGameServer.NativeMethodInfoPtr__SetPasswordProtected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663800);
			ISteamGameServer.NativeMethodInfoPtr_SetPasswordProtected_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663801);
			ISteamGameServer.NativeMethodInfoPtr__SetSpectatorPort_Private_Static_Void_IntPtr_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663802);
			ISteamGameServer.NativeMethodInfoPtr_SetSpectatorPort_Internal_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663803);
			ISteamGameServer.NativeMethodInfoPtr__SetSpectatorServerName_Private_Static_Void_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663804);
			ISteamGameServer.NativeMethodInfoPtr_SetSpectatorServerName_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663805);
			ISteamGameServer.NativeMethodInfoPtr__ClearAllKeyValues_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663806);
			ISteamGameServer.NativeMethodInfoPtr_ClearAllKeyValues_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663807);
			ISteamGameServer.NativeMethodInfoPtr__SetKeyValue_Private_Static_Void_IntPtr_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663808);
			ISteamGameServer.NativeMethodInfoPtr_SetKeyValue_Internal_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663809);
			ISteamGameServer.NativeMethodInfoPtr__SetGameTags_Private_Static_Void_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663810);
			ISteamGameServer.NativeMethodInfoPtr_SetGameTags_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663811);
			ISteamGameServer.NativeMethodInfoPtr__SetGameData_Private_Static_Void_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663812);
			ISteamGameServer.NativeMethodInfoPtr_SetGameData_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663813);
			ISteamGameServer.NativeMethodInfoPtr__SetRegion_Private_Static_Void_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663814);
			ISteamGameServer.NativeMethodInfoPtr_SetRegion_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663815);
			ISteamGameServer.NativeMethodInfoPtr__SetAdvertiseServerActive_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663816);
			ISteamGameServer.NativeMethodInfoPtr_SetAdvertiseServerActive_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663817);
			ISteamGameServer.NativeMethodInfoPtr__GetAuthSessionTicket_Private_Static_HAuthTicket_IntPtr_IntPtr_Int32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663818);
			ISteamGameServer.NativeMethodInfoPtr_GetAuthSessionTicket_Internal_HAuthTicket_IntPtr_Int32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663819);
			ISteamGameServer.NativeMethodInfoPtr__BeginAuthSession_Private_Static_BeginAuthResult_IntPtr_IntPtr_Int32_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663820);
			ISteamGameServer.NativeMethodInfoPtr_BeginAuthSession_Internal_BeginAuthResult_IntPtr_Int32_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663821);
			ISteamGameServer.NativeMethodInfoPtr__EndAuthSession_Private_Static_Void_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663822);
			ISteamGameServer.NativeMethodInfoPtr_EndAuthSession_Internal_Void_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663823);
			ISteamGameServer.NativeMethodInfoPtr__CancelAuthTicket_Private_Static_Void_IntPtr_HAuthTicket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663824);
			ISteamGameServer.NativeMethodInfoPtr_CancelAuthTicket_Internal_Void_HAuthTicket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663825);
			ISteamGameServer.NativeMethodInfoPtr__UserHasLicenseForApp_Private_Static_UserHasLicenseForAppResult_IntPtr_SteamId_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663826);
			ISteamGameServer.NativeMethodInfoPtr_UserHasLicenseForApp_Internal_UserHasLicenseForAppResult_SteamId_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663827);
			ISteamGameServer.NativeMethodInfoPtr__RequestUserGroupStatus_Private_Static_Boolean_IntPtr_SteamId_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663828);
			ISteamGameServer.NativeMethodInfoPtr_RequestUserGroupStatus_Internal_Boolean_SteamId_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663829);
			ISteamGameServer.NativeMethodInfoPtr__GetGameplayStats_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663830);
			ISteamGameServer.NativeMethodInfoPtr_GetGameplayStats_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663831);
			ISteamGameServer.NativeMethodInfoPtr__GetServerReputation_Private_Static_SteamAPICall_t_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663832);
			ISteamGameServer.NativeMethodInfoPtr_GetServerReputation_Internal_CallResult_1_GSReputation_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663833);
			ISteamGameServer.NativeMethodInfoPtr__GetPublicIP_Private_Static_SteamIPAddress_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663834);
			ISteamGameServer.NativeMethodInfoPtr_GetPublicIP_Internal_SteamIPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663835);
			ISteamGameServer.NativeMethodInfoPtr__HandleIncomingPacket_Private_Static_Boolean_IntPtr_IntPtr_Int32_UInt32_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663836);
			ISteamGameServer.NativeMethodInfoPtr_HandleIncomingPacket_Internal_Boolean_IntPtr_Int32_UInt32_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663837);
			ISteamGameServer.NativeMethodInfoPtr__GetNextOutgoingPacket_Private_Static_Int32_IntPtr_IntPtr_Int32_byref_UInt32_byref_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663838);
			ISteamGameServer.NativeMethodInfoPtr_GetNextOutgoingPacket_Internal_Int32_IntPtr_Int32_byref_UInt32_byref_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663839);
			ISteamGameServer.NativeMethodInfoPtr__AssociateWithClan_Private_Static_SteamAPICall_t_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663840);
			ISteamGameServer.NativeMethodInfoPtr_AssociateWithClan_Internal_CallResult_1_AssociateWithClanResult_t_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663841);
			ISteamGameServer.NativeMethodInfoPtr__ComputeNewPlayerCompatibility_Private_Static_SteamAPICall_t_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663842);
			ISteamGameServer.NativeMethodInfoPtr_ComputeNewPlayerCompatibility_Internal_CallResult_1_ComputeNewPlayerCompatibilityResult_t_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663843);
			ISteamGameServer.NativeMethodInfoPtr__SendUserConnectAndAuthenticate_DEPRECATED_Private_Static_Boolean_IntPtr_UInt32_IntPtr_UInt32_byref_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663844);
			ISteamGameServer.NativeMethodInfoPtr_SendUserConnectAndAuthenticate_DEPRECATED_Internal_Boolean_UInt32_IntPtr_UInt32_byref_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663845);
			ISteamGameServer.NativeMethodInfoPtr__CreateUnauthenticatedUserConnection_Private_Static_SteamId_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663846);
			ISteamGameServer.NativeMethodInfoPtr_CreateUnauthenticatedUserConnection_Internal_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663847);
			ISteamGameServer.NativeMethodInfoPtr__SendUserDisconnect_DEPRECATED_Private_Static_Void_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663848);
			ISteamGameServer.NativeMethodInfoPtr_SendUserDisconnect_DEPRECATED_Internal_Void_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663849);
			ISteamGameServer.NativeMethodInfoPtr__BUpdateUserData_Private_Static_Boolean_IntPtr_SteamId_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663850);
			ISteamGameServer.NativeMethodInfoPtr_BUpdateUserData_Internal_Boolean_SteamId_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr, 100663851);
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0001A564 File Offset: 0x00018764
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 930944, RefRangeEnd = 930966, XrefRangeStart = 930944, XrefRangeEnd = 930966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISteamGameServer(bool IsGameServer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamGameServer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref IsGameServer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0001A5AC File Offset: 0x000187AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932124, XrefRangeEnd = 932126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr SteamAPI_SteamGameServer_v014()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr_SteamAPI_SteamGameServer_v014_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0001A5DC File Offset: 0x000187DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IntPtr GetServerInterfacePointer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamGameServer.NativeMethodInfoPtr_GetServerInterfacePointer_Public_Virtual_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0001A624 File Offset: 0x00018824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932126, XrefRangeEnd = 932129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SetProduct(IntPtr self, string pszProduct)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pszProduct);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr__SetProduct_Private_Static_Void_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0001A668 File Offset: 0x00018868
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 932132, RefRangeEnd = 932134, XrefRangeStart = 932129, XrefRangeEnd = 932132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetProduct(string pszProduct)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pszProduct);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr_SetProduct_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0001A6AC File Offset: 0x000188AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932134, XrefRangeEnd = 932137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SetGameDescription(IntPtr self, string pszGameDescription)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pszGameDescription);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr__SetGameDescription_Private_Static_Void_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0001A6F0 File Offset: 0x000188F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 932140, RefRangeEnd = 932142, XrefRangeStart = 932137, XrefRangeEnd = 932140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGameDescription(string pszGameDescription)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pszGameDescription);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr_SetGameDescription_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0001A734 File Offset: 0x00018934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932142, XrefRangeEnd = 932145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SetModDir(IntPtr self, string pszModDir)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pszModDir);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr__SetModDir_Private_Static_Void_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0001A778 File Offset: 0x00018978
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 932148, RefRangeEnd = 932150, XrefRangeStart = 932145, XrefRangeEnd = 932148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetModDir(string pszModDir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pszModDir);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr_SetModDir_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0001A7BC File Offset: 0x000189BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932150, XrefRangeEnd = 932152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SetDedicatedServer(IntPtr self, bool bDedicated)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bDedicated;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr__SetDedicatedServer_Private_Static_Void_IntPtr_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0001A7FC File Offset: 0x000189FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 932154, RefRangeEnd = 932156, XrefRangeStart = 932152, XrefRangeEnd = 932154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDedicatedServer(bool bDedicated)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bDedicated;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr_SetDedicatedServer_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0001A83C File Offset: 0x00018A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932156, XrefRangeEnd = 932159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _LogOn(IntPtr self, string pszToken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pszToken);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr__LogOn_Private_Static_Void_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0001A880 File Offset: 0x00018A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932159, XrefRangeEnd = 932162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogOn(string pszToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pszToken);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr_LogOn_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0001A8C4 File Offset: 0x00018AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932162, XrefRangeEnd = 932164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _LogOnAnonymous(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr__LogOnAnonymous_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0001A8F8 File Offset: 0x00018AF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 932166, RefRangeEnd = 932167, XrefRangeStart = 932164, XrefRangeEnd = 932166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogOnAnonymous()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr_LogOnAnonymous_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0001A92C File Offset: 0x00018B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932167, XrefRangeEnd = 932169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _LogOff(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr__LogOff_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0001A960 File Offset: 0x00018B60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 932171, RefRangeEnd = 932172, XrefRangeStart = 932169, XrefRangeEnd = 932171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogOff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr_LogOff_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0001A994 File Offset: 0x00018B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932172, XrefRangeEnd = 932174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _BLoggedOn(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr__BLoggedOn_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0001A9D4 File Offset: 0x00018BD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 932176, RefRangeEnd = 932177, XrefRangeStart = 932174, XrefRangeEnd = 932176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BLoggedOn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr_BLoggedOn_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0001AA10 File Offset: 0x00018C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932177, XrefRangeEnd = 932179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _BSecure(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr__BSecure_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0001AA50 File Offset: 0x00018C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932179, XrefRangeEnd = 932181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BSecure()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr_BSecure_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0001AA8C File Offset: 0x00018C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932181, XrefRangeEnd = 932183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamId _GetSteamID(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr__GetSteamID_Private_Static_SteamId_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0001AACC File Offset: 0x00018CCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 932185, RefRangeEnd = 932186, XrefRangeStart = 932183, XrefRangeEnd = 932185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamId GetSteamID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr_GetSteamID_Internal_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0001AB08 File Offset: 0x00018D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932186, XrefRangeEnd = 932188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _WasRestartRequested(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr__WasRestartRequested_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0001AB48 File Offset: 0x00018D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932188, XrefRangeEnd = 932190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WasRestartRequested()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr_WasRestartRequested_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0001AB84 File Offset: 0x00018D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932190, XrefRangeEnd = 932192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SetMaxPlayerCount(IntPtr self, int cPlayersMax)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cPlayersMax;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr__SetMaxPlayerCount_Private_Static_Void_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0001ABC4 File Offset: 0x00018DC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 932194, RefRangeEnd = 932196, XrefRangeStart = 932192, XrefRangeEnd = 932194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaxPlayerCount(int cPlayersMax)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cPlayersMax;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr_SetMaxPlayerCount_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0001AC04 File Offset: 0x00018E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932196, XrefRangeEnd = 932198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SetBotPlayerCount(IntPtr self, int cBotplayers)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cBotplayers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr__SetBotPlayerCount_Private_Static_Void_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0001AC44 File Offset: 0x00018E44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 932200, RefRangeEnd = 932202, XrefRangeStart = 932198, XrefRangeEnd = 932200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBotPlayerCount(int cBotplayers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cBotplayers;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr_SetBotPlayerCount_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0001AC84 File Offset: 0x00018E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932202, XrefRangeEnd = 932205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SetServerName(IntPtr self, string pszServerName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pszServerName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr__SetServerName_Private_Static_Void_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0001ACC8 File Offset: 0x00018EC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 932208, RefRangeEnd = 932209, XrefRangeStart = 932205, XrefRangeEnd = 932208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetServerName(string pszServerName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pszServerName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr_SetServerName_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0001AD0C File Offset: 0x00018F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932209, XrefRangeEnd = 932212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SetMapName(IntPtr self, string pszMapName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pszMapName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr__SetMapName_Private_Static_Void_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0001AD50 File Offset: 0x00018F50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 932215, RefRangeEnd = 932216, XrefRangeStart = 932212, XrefRangeEnd = 932215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMapName(string pszMapName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pszMapName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr_SetMapName_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0001AD94 File Offset: 0x00018F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932216, XrefRangeEnd = 932218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SetPasswordProtected(IntPtr self, bool bPasswordProtected)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bPasswordProtected;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr__SetPasswordProtected_Private_Static_Void_IntPtr_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0001ADD4 File Offset: 0x00018FD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 932220, RefRangeEnd = 932222, XrefRangeStart = 932218, XrefRangeEnd = 932220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPasswordProtected(bool bPasswordProtected)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bPasswordProtected;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr_SetPasswordProtected_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0001AE14 File Offset: 0x00019014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932222, XrefRangeEnd = 932224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SetSpectatorPort(IntPtr self, ushort unSpectatorPort)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unSpectatorPort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr__SetSpectatorPort_Private_Static_Void_IntPtr_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0001AE54 File Offset: 0x00019054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932224, XrefRangeEnd = 932226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSpectatorPort(ushort unSpectatorPort)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unSpectatorPort;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr_SetSpectatorPort_Internal_Void_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0001AE94 File Offset: 0x00019094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932226, XrefRangeEnd = 932229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SetSpectatorServerName(IntPtr self, string pszSpectatorServerName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pszSpectatorServerName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr__SetSpectatorServerName_Private_Static_Void_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0001AED8 File Offset: 0x000190D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932229, XrefRangeEnd = 932232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSpectatorServerName(string pszSpectatorServerName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pszSpectatorServerName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr_SetSpectatorServerName_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0001AF1C File Offset: 0x0001911C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932232, XrefRangeEnd = 932234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _ClearAllKeyValues(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr__ClearAllKeyValues_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0001AF50 File Offset: 0x00019150
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 932236, RefRangeEnd = 932237, XrefRangeStart = 932234, XrefRangeEnd = 932236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearAllKeyValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr_ClearAllKeyValues_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0001AF84 File Offset: 0x00019184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932237, XrefRangeEnd = 932242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SetKeyValue(IntPtr self, string pKey, string pValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr__SetKeyValue_Private_Static_Void_IntPtr_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0001AFDC File Offset: 0x000191DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 932247, RefRangeEnd = 932248, XrefRangeStart = 932242, XrefRangeEnd = 932247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetKeyValue(string pKey, string pValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr_SetKeyValue_Internal_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0001B030 File Offset: 0x00019230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932248, XrefRangeEnd = 932251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SetGameTags(IntPtr self, string pchGameTags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchGameTags);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr__SetGameTags_Private_Static_Void_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0001B074 File Offset: 0x00019274
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 932254, RefRangeEnd = 932255, XrefRangeStart = 932251, XrefRangeEnd = 932254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGameTags(string pchGameTags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchGameTags);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr_SetGameTags_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0001B0B8 File Offset: 0x000192B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932255, XrefRangeEnd = 932258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SetGameData(IntPtr self, string pchGameData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchGameData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr__SetGameData_Private_Static_Void_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0001B0FC File Offset: 0x000192FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932258, XrefRangeEnd = 932261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGameData(string pchGameData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchGameData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr_SetGameData_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0001B140 File Offset: 0x00019340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932261, XrefRangeEnd = 932264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SetRegion(IntPtr self, string pszRegion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pszRegion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr__SetRegion_Private_Static_Void_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0001B184 File Offset: 0x00019384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932264, XrefRangeEnd = 932267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRegion(string pszRegion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pszRegion);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr_SetRegion_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0001B1C8 File Offset: 0x000193C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932267, XrefRangeEnd = 932269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SetAdvertiseServerActive(IntPtr self, bool bActive)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bActive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr__SetAdvertiseServerActive_Private_Static_Void_IntPtr_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0001B208 File Offset: 0x00019408
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 932271, RefRangeEnd = 932274, XrefRangeStart = 932269, XrefRangeEnd = 932271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAdvertiseServerActive(bool bActive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bActive;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr_SetAdvertiseServerActive_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0001B248 File Offset: 0x00019448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932274, XrefRangeEnd = 932276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr__GetAuthSessionTicket_Private_Static_HAuthTicket_IntPtr_IntPtr_Int32_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0001B2B0 File Offset: 0x000194B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932276, XrefRangeEnd = 932278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr_GetAuthSessionTicket_Internal_HAuthTicket_IntPtr_Int32_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0001B318 File Offset: 0x00019518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932278, XrefRangeEnd = 932280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr__BeginAuthSession_Private_Static_BeginAuthResult_IntPtr_IntPtr_Int32_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0001B380 File Offset: 0x00019580
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 932282, RefRangeEnd = 932283, XrefRangeStart = 932280, XrefRangeEnd = 932282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr_BeginAuthSession_Internal_BeginAuthResult_IntPtr_Int32_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0001B3E8 File Offset: 0x000195E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932283, XrefRangeEnd = 932285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr__EndAuthSession_Private_Static_Void_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0001B428 File Offset: 0x00019628
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 932287, RefRangeEnd = 932288, XrefRangeStart = 932285, XrefRangeEnd = 932287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndAuthSession(SteamId steamID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr_EndAuthSession_Internal_Void_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0001B468 File Offset: 0x00019668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932288, XrefRangeEnd = 932290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr__CancelAuthTicket_Private_Static_Void_IntPtr_HAuthTicket_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0001B4A8 File Offset: 0x000196A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932290, XrefRangeEnd = 932292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelAuthTicket(HAuthTicket hAuthTicket)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hAuthTicket;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr_CancelAuthTicket_Internal_Void_HAuthTicket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0001B4E8 File Offset: 0x000196E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932292, XrefRangeEnd = 932294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr__UserHasLicenseForApp_Private_Static_UserHasLicenseForAppResult_IntPtr_SteamId_AppId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0001B544 File Offset: 0x00019744
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 932296, RefRangeEnd = 932297, XrefRangeStart = 932294, XrefRangeEnd = 932296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr_UserHasLicenseForApp_Internal_UserHasLicenseForAppResult_SteamId_AppId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000238 RID: 568 RVA: 0x0001B59C File Offset: 0x0001979C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932297, XrefRangeEnd = 932299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _RequestUserGroupStatus(IntPtr self, SteamId steamIDUser, SteamId steamIDGroup)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDUser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDGroup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr__RequestUserGroupStatus_Private_Static_Boolean_IntPtr_SteamId_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0001B5F8 File Offset: 0x000197F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932299, XrefRangeEnd = 932301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RequestUserGroupStatus(SteamId steamIDUser, SteamId steamIDGroup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDGroup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr_RequestUserGroupStatus_Internal_Boolean_SteamId_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0001B650 File Offset: 0x00019850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932301, XrefRangeEnd = 932303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _GetGameplayStats(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr__GetGameplayStats_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0001B684 File Offset: 0x00019884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932303, XrefRangeEnd = 932305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetGameplayStats()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr_GetGameplayStats_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0001B6B8 File Offset: 0x000198B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932305, XrefRangeEnd = 932307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t _GetServerReputation(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr__GetServerReputation_Private_Static_SteamAPICall_t_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0001B6F8 File Offset: 0x000198F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932307, XrefRangeEnd = 932312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<GSReputation_t> GetServerReputation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr_GetServerReputation_Internal_CallResult_1_GSReputation_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new CallResult<GSReputation_t>(intPtr);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0001B730 File Offset: 0x00019930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932312, XrefRangeEnd = 932314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamIPAddress _GetPublicIP(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr__GetPublicIP_Private_Static_SteamIPAddress_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0001B770 File Offset: 0x00019970
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 932316, RefRangeEnd = 932317, XrefRangeStart = 932314, XrefRangeEnd = 932316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamIPAddress GetPublicIP()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr_GetPublicIP_Internal_SteamIPAddress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0001B7AC File Offset: 0x000199AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932317, XrefRangeEnd = 932319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _HandleIncomingPacket(IntPtr self, IntPtr pData, int cbData, uint srcIP, ushort srcPort)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pData;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbData;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcIP;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcPort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr__HandleIncomingPacket_Private_Static_Boolean_IntPtr_IntPtr_Int32_UInt32_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0001B824 File Offset: 0x00019A24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 932321, RefRangeEnd = 932323, XrefRangeStart = 932319, XrefRangeEnd = 932321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HandleIncomingPacket(IntPtr pData, int cbData, uint srcIP, ushort srcPort)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pData;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbData;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcIP;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcPort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr_HandleIncomingPacket_Internal_Boolean_IntPtr_Int32_UInt32_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0001B898 File Offset: 0x00019A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932323, XrefRangeEnd = 932325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetNextOutgoingPacket(IntPtr self, IntPtr pOut, int cbMaxOut, ref uint pNetAdr, ref ushort pPort)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pOut;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbMaxOut;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pNetAdr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pPort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr__GetNextOutgoingPacket_Private_Static_Int32_IntPtr_IntPtr_Int32_byref_UInt32_byref_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0001B910 File Offset: 0x00019B10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 932327, RefRangeEnd = 932328, XrefRangeStart = 932325, XrefRangeEnd = 932327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetNextOutgoingPacket(IntPtr pOut, int cbMaxOut, ref uint pNetAdr, ref ushort pPort)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pOut;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbMaxOut;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pNetAdr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pPort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr_GetNextOutgoingPacket_Internal_Int32_IntPtr_Int32_byref_UInt32_byref_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0001B984 File Offset: 0x00019B84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932328, XrefRangeEnd = 932330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t _AssociateWithClan(IntPtr self, SteamId steamIDClan)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDClan;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr__AssociateWithClan_Private_Static_SteamAPICall_t_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0001B9D0 File Offset: 0x00019BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932330, XrefRangeEnd = 932335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<AssociateWithClanResult_t> AssociateWithClan(SteamId steamIDClan)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDClan;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr_AssociateWithClan_Internal_CallResult_1_AssociateWithClanResult_t_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CallResult<AssociateWithClanResult_t>(intPtr);
			}
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0001BA14 File Offset: 0x00019C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932335, XrefRangeEnd = 932337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t _ComputeNewPlayerCompatibility(IntPtr self, SteamId steamIDNewPlayer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDNewPlayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr__ComputeNewPlayerCompatibility_Private_Static_SteamAPICall_t_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0001BA60 File Offset: 0x00019C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932337, XrefRangeEnd = 932342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<ComputeNewPlayerCompatibilityResult_t> ComputeNewPlayerCompatibility(SteamId steamIDNewPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDNewPlayer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr_ComputeNewPlayerCompatibility_Internal_CallResult_1_ComputeNewPlayerCompatibilityResult_t_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CallResult<ComputeNewPlayerCompatibilityResult_t>(intPtr);
			}
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0001BAA4 File Offset: 0x00019CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932342, XrefRangeEnd = 932344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SendUserConnectAndAuthenticate_DEPRECATED(IntPtr self, uint unIPClient, IntPtr pvAuthBlob, uint cubAuthBlobSize, ref SteamId pSteamIDUser)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unIPClient;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pvAuthBlob;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubAuthBlobSize;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pSteamIDUser;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr__SendUserConnectAndAuthenticate_DEPRECATED_Private_Static_Boolean_IntPtr_UInt32_IntPtr_UInt32_byref_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0001BB1C File Offset: 0x00019D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932344, XrefRangeEnd = 932346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SendUserConnectAndAuthenticate_DEPRECATED(uint unIPClient, IntPtr pvAuthBlob, uint cubAuthBlobSize, ref SteamId pSteamIDUser)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unIPClient;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pvAuthBlob;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubAuthBlobSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pSteamIDUser;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr_SendUserConnectAndAuthenticate_DEPRECATED_Internal_Boolean_UInt32_IntPtr_UInt32_byref_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0001BB90 File Offset: 0x00019D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932346, XrefRangeEnd = 932348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamId _CreateUnauthenticatedUserConnection(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr__CreateUnauthenticatedUserConnection_Private_Static_SteamId_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0001BBD0 File Offset: 0x00019DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932348, XrefRangeEnd = 932350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamId CreateUnauthenticatedUserConnection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr_CreateUnauthenticatedUserConnection_Internal_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0001BC0C File Offset: 0x00019E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932350, XrefRangeEnd = 932352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SendUserDisconnect_DEPRECATED(IntPtr self, SteamId steamIDUser)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDUser;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr__SendUserDisconnect_DEPRECATED_Private_Static_Void_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0001BC4C File Offset: 0x00019E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932352, XrefRangeEnd = 932354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendUserDisconnect_DEPRECATED(SteamId steamIDUser)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUser;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr_SendUserDisconnect_DEPRECATED_Internal_Void_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0001BC8C File Offset: 0x00019E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932354, XrefRangeEnd = 932357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _BUpdateUserData(IntPtr self, SteamId steamIDUser, string pchPlayerName, uint uScore)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDUser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPlayerName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uScore;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr__BUpdateUserData_Private_Static_Boolean_IntPtr_SteamId_String_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0001BCF8 File Offset: 0x00019EF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 932360, RefRangeEnd = 932361, XrefRangeStart = 932357, XrefRangeEnd = 932360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BUpdateUserData(SteamId steamIDUser, string pchPlayerName, uint uScore)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPlayerName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uScore;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameServer.NativeMethodInfoPtr_BUpdateUserData_Internal_Boolean_SteamId_String_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00002309 File Offset: 0x00000509
		public ISteamGameServer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x0400029E RID: 670
		private static readonly IntPtr NativeMethodInfoPtr_SteamAPI_SteamGameServer_v014_Internal_Static_IntPtr_0;

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeMethodInfoPtr_GetServerInterfacePointer_Public_Virtual_IntPtr_0;

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeMethodInfoPtr__SetProduct_Private_Static_Void_IntPtr_String_0;

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeMethodInfoPtr_SetProduct_Internal_Void_String_0;

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeMethodInfoPtr__SetGameDescription_Private_Static_Void_IntPtr_String_0;

		// Token: 0x040002A3 RID: 675
		private static readonly IntPtr NativeMethodInfoPtr_SetGameDescription_Internal_Void_String_0;

		// Token: 0x040002A4 RID: 676
		private static readonly IntPtr NativeMethodInfoPtr__SetModDir_Private_Static_Void_IntPtr_String_0;

		// Token: 0x040002A5 RID: 677
		private static readonly IntPtr NativeMethodInfoPtr_SetModDir_Internal_Void_String_0;

		// Token: 0x040002A6 RID: 678
		private static readonly IntPtr NativeMethodInfoPtr__SetDedicatedServer_Private_Static_Void_IntPtr_Boolean_0;

		// Token: 0x040002A7 RID: 679
		private static readonly IntPtr NativeMethodInfoPtr_SetDedicatedServer_Internal_Void_Boolean_0;

		// Token: 0x040002A8 RID: 680
		private static readonly IntPtr NativeMethodInfoPtr__LogOn_Private_Static_Void_IntPtr_String_0;

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeMethodInfoPtr_LogOn_Internal_Void_String_0;

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeMethodInfoPtr__LogOnAnonymous_Private_Static_Void_IntPtr_0;

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeMethodInfoPtr_LogOnAnonymous_Internal_Void_0;

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeMethodInfoPtr__LogOff_Private_Static_Void_IntPtr_0;

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeMethodInfoPtr_LogOff_Internal_Void_0;

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeMethodInfoPtr__BLoggedOn_Private_Static_Boolean_IntPtr_0;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeMethodInfoPtr_BLoggedOn_Internal_Boolean_0;

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeMethodInfoPtr__BSecure_Private_Static_Boolean_IntPtr_0;

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeMethodInfoPtr_BSecure_Internal_Boolean_0;

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeMethodInfoPtr__GetSteamID_Private_Static_SteamId_IntPtr_0;

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamID_Internal_SteamId_0;

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeMethodInfoPtr__WasRestartRequested_Private_Static_Boolean_IntPtr_0;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeMethodInfoPtr_WasRestartRequested_Internal_Boolean_0;

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeMethodInfoPtr__SetMaxPlayerCount_Private_Static_Void_IntPtr_Int32_0;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeMethodInfoPtr_SetMaxPlayerCount_Internal_Void_Int32_0;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeMethodInfoPtr__SetBotPlayerCount_Private_Static_Void_IntPtr_Int32_0;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeMethodInfoPtr_SetBotPlayerCount_Internal_Void_Int32_0;

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeMethodInfoPtr__SetServerName_Private_Static_Void_IntPtr_String_0;

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeMethodInfoPtr_SetServerName_Internal_Void_String_0;

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeMethodInfoPtr__SetMapName_Private_Static_Void_IntPtr_String_0;

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeMethodInfoPtr_SetMapName_Internal_Void_String_0;

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeMethodInfoPtr__SetPasswordProtected_Private_Static_Void_IntPtr_Boolean_0;

		// Token: 0x040002BF RID: 703
		private static readonly IntPtr NativeMethodInfoPtr_SetPasswordProtected_Internal_Void_Boolean_0;

		// Token: 0x040002C0 RID: 704
		private static readonly IntPtr NativeMethodInfoPtr__SetSpectatorPort_Private_Static_Void_IntPtr_UInt16_0;

		// Token: 0x040002C1 RID: 705
		private static readonly IntPtr NativeMethodInfoPtr_SetSpectatorPort_Internal_Void_UInt16_0;

		// Token: 0x040002C2 RID: 706
		private static readonly IntPtr NativeMethodInfoPtr__SetSpectatorServerName_Private_Static_Void_IntPtr_String_0;

		// Token: 0x040002C3 RID: 707
		private static readonly IntPtr NativeMethodInfoPtr_SetSpectatorServerName_Internal_Void_String_0;

		// Token: 0x040002C4 RID: 708
		private static readonly IntPtr NativeMethodInfoPtr__ClearAllKeyValues_Private_Static_Void_IntPtr_0;

		// Token: 0x040002C5 RID: 709
		private static readonly IntPtr NativeMethodInfoPtr_ClearAllKeyValues_Internal_Void_0;

		// Token: 0x040002C6 RID: 710
		private static readonly IntPtr NativeMethodInfoPtr__SetKeyValue_Private_Static_Void_IntPtr_String_String_0;

		// Token: 0x040002C7 RID: 711
		private static readonly IntPtr NativeMethodInfoPtr_SetKeyValue_Internal_Void_String_String_0;

		// Token: 0x040002C8 RID: 712
		private static readonly IntPtr NativeMethodInfoPtr__SetGameTags_Private_Static_Void_IntPtr_String_0;

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr NativeMethodInfoPtr_SetGameTags_Internal_Void_String_0;

		// Token: 0x040002CA RID: 714
		private static readonly IntPtr NativeMethodInfoPtr__SetGameData_Private_Static_Void_IntPtr_String_0;

		// Token: 0x040002CB RID: 715
		private static readonly IntPtr NativeMethodInfoPtr_SetGameData_Internal_Void_String_0;

		// Token: 0x040002CC RID: 716
		private static readonly IntPtr NativeMethodInfoPtr__SetRegion_Private_Static_Void_IntPtr_String_0;

		// Token: 0x040002CD RID: 717
		private static readonly IntPtr NativeMethodInfoPtr_SetRegion_Internal_Void_String_0;

		// Token: 0x040002CE RID: 718
		private static readonly IntPtr NativeMethodInfoPtr__SetAdvertiseServerActive_Private_Static_Void_IntPtr_Boolean_0;

		// Token: 0x040002CF RID: 719
		private static readonly IntPtr NativeMethodInfoPtr_SetAdvertiseServerActive_Internal_Void_Boolean_0;

		// Token: 0x040002D0 RID: 720
		private static readonly IntPtr NativeMethodInfoPtr__GetAuthSessionTicket_Private_Static_HAuthTicket_IntPtr_IntPtr_Int32_byref_UInt32_0;

		// Token: 0x040002D1 RID: 721
		private static readonly IntPtr NativeMethodInfoPtr_GetAuthSessionTicket_Internal_HAuthTicket_IntPtr_Int32_byref_UInt32_0;

		// Token: 0x040002D2 RID: 722
		private static readonly IntPtr NativeMethodInfoPtr__BeginAuthSession_Private_Static_BeginAuthResult_IntPtr_IntPtr_Int32_SteamId_0;

		// Token: 0x040002D3 RID: 723
		private static readonly IntPtr NativeMethodInfoPtr_BeginAuthSession_Internal_BeginAuthResult_IntPtr_Int32_SteamId_0;

		// Token: 0x040002D4 RID: 724
		private static readonly IntPtr NativeMethodInfoPtr__EndAuthSession_Private_Static_Void_IntPtr_SteamId_0;

		// Token: 0x040002D5 RID: 725
		private static readonly IntPtr NativeMethodInfoPtr_EndAuthSession_Internal_Void_SteamId_0;

		// Token: 0x040002D6 RID: 726
		private static readonly IntPtr NativeMethodInfoPtr__CancelAuthTicket_Private_Static_Void_IntPtr_HAuthTicket_0;

		// Token: 0x040002D7 RID: 727
		private static readonly IntPtr NativeMethodInfoPtr_CancelAuthTicket_Internal_Void_HAuthTicket_0;

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeMethodInfoPtr__UserHasLicenseForApp_Private_Static_UserHasLicenseForAppResult_IntPtr_SteamId_AppId_0;

		// Token: 0x040002D9 RID: 729
		private static readonly IntPtr NativeMethodInfoPtr_UserHasLicenseForApp_Internal_UserHasLicenseForAppResult_SteamId_AppId_0;

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeMethodInfoPtr__RequestUserGroupStatus_Private_Static_Boolean_IntPtr_SteamId_SteamId_0;

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeMethodInfoPtr_RequestUserGroupStatus_Internal_Boolean_SteamId_SteamId_0;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeMethodInfoPtr__GetGameplayStats_Private_Static_Void_IntPtr_0;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeMethodInfoPtr_GetGameplayStats_Internal_Void_0;

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeMethodInfoPtr__GetServerReputation_Private_Static_SteamAPICall_t_IntPtr_0;

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeMethodInfoPtr_GetServerReputation_Internal_CallResult_1_GSReputation_t_0;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeMethodInfoPtr__GetPublicIP_Private_Static_SteamIPAddress_IntPtr_0;

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeMethodInfoPtr_GetPublicIP_Internal_SteamIPAddress_0;

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeMethodInfoPtr__HandleIncomingPacket_Private_Static_Boolean_IntPtr_IntPtr_Int32_UInt32_UInt16_0;

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeMethodInfoPtr_HandleIncomingPacket_Internal_Boolean_IntPtr_Int32_UInt32_UInt16_0;

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeMethodInfoPtr__GetNextOutgoingPacket_Private_Static_Int32_IntPtr_IntPtr_Int32_byref_UInt32_byref_UInt16_0;

		// Token: 0x040002E5 RID: 741
		private static readonly IntPtr NativeMethodInfoPtr_GetNextOutgoingPacket_Internal_Int32_IntPtr_Int32_byref_UInt32_byref_UInt16_0;

		// Token: 0x040002E6 RID: 742
		private static readonly IntPtr NativeMethodInfoPtr__AssociateWithClan_Private_Static_SteamAPICall_t_IntPtr_SteamId_0;

		// Token: 0x040002E7 RID: 743
		private static readonly IntPtr NativeMethodInfoPtr_AssociateWithClan_Internal_CallResult_1_AssociateWithClanResult_t_SteamId_0;

		// Token: 0x040002E8 RID: 744
		private static readonly IntPtr NativeMethodInfoPtr__ComputeNewPlayerCompatibility_Private_Static_SteamAPICall_t_IntPtr_SteamId_0;

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeMethodInfoPtr_ComputeNewPlayerCompatibility_Internal_CallResult_1_ComputeNewPlayerCompatibilityResult_t_SteamId_0;

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeMethodInfoPtr__SendUserConnectAndAuthenticate_DEPRECATED_Private_Static_Boolean_IntPtr_UInt32_IntPtr_UInt32_byref_SteamId_0;

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeMethodInfoPtr_SendUserConnectAndAuthenticate_DEPRECATED_Internal_Boolean_UInt32_IntPtr_UInt32_byref_SteamId_0;

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeMethodInfoPtr__CreateUnauthenticatedUserConnection_Private_Static_SteamId_IntPtr_0;

		// Token: 0x040002ED RID: 749
		private static readonly IntPtr NativeMethodInfoPtr_CreateUnauthenticatedUserConnection_Internal_SteamId_0;

		// Token: 0x040002EE RID: 750
		private static readonly IntPtr NativeMethodInfoPtr__SendUserDisconnect_DEPRECATED_Private_Static_Void_IntPtr_SteamId_0;

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeMethodInfoPtr_SendUserDisconnect_DEPRECATED_Internal_Void_SteamId_0;

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeMethodInfoPtr__BUpdateUserData_Private_Static_Boolean_IntPtr_SteamId_String_UInt32_0;

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeMethodInfoPtr_BUpdateUserData_Internal_Boolean_SteamId_String_UInt32_0;
	}
}
