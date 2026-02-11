using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x0200001E RID: 30
	public class ISteamMatchmakingServers : SteamInterface
	{
		// Token: 0x06000419 RID: 1049 RVA: 0x00027AEC File Offset: 0x00025CEC
		// Note: this type is marked as 'beforefieldinit'.
		static ISteamMatchmakingServers()
		{
			Il2CppClassPointerStore<ISteamMatchmakingServers>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "ISteamMatchmakingServers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamMatchmakingServers>.NativeClassPtr);
			ISteamMatchmakingServers.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServers>.NativeClassPtr, 100664288);
			ISteamMatchmakingServers.NativeMethodInfoPtr_SteamAPI_SteamMatchmakingServers_v002_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServers>.NativeClassPtr, 100664289);
			ISteamMatchmakingServers.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServers>.NativeClassPtr, 100664290);
			ISteamMatchmakingServers.NativeMethodInfoPtr__RequestInternetServerList_Private_Static_HServerListRequest_IntPtr_AppId_byref_Il2CppReferenceArray_1_MatchMakingKeyValuePair_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServers>.NativeClassPtr, 100664291);
			ISteamMatchmakingServers.NativeMethodInfoPtr_RequestInternetServerList_Internal_HServerListRequest_AppId_byref_Il2CppReferenceArray_1_MatchMakingKeyValuePair_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServers>.NativeClassPtr, 100664292);
			ISteamMatchmakingServers.NativeMethodInfoPtr__RequestLANServerList_Private_Static_HServerListRequest_IntPtr_AppId_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServers>.NativeClassPtr, 100664293);
			ISteamMatchmakingServers.NativeMethodInfoPtr_RequestLANServerList_Internal_HServerListRequest_AppId_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServers>.NativeClassPtr, 100664294);
			ISteamMatchmakingServers.NativeMethodInfoPtr__RequestFriendsServerList_Private_Static_HServerListRequest_IntPtr_AppId_byref_Il2CppReferenceArray_1_MatchMakingKeyValuePair_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServers>.NativeClassPtr, 100664295);
			ISteamMatchmakingServers.NativeMethodInfoPtr_RequestFriendsServerList_Internal_HServerListRequest_AppId_byref_Il2CppReferenceArray_1_MatchMakingKeyValuePair_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServers>.NativeClassPtr, 100664296);
			ISteamMatchmakingServers.NativeMethodInfoPtr__RequestFavoritesServerList_Private_Static_HServerListRequest_IntPtr_AppId_byref_Il2CppReferenceArray_1_MatchMakingKeyValuePair_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServers>.NativeClassPtr, 100664297);
			ISteamMatchmakingServers.NativeMethodInfoPtr_RequestFavoritesServerList_Internal_HServerListRequest_AppId_byref_Il2CppReferenceArray_1_MatchMakingKeyValuePair_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServers>.NativeClassPtr, 100664298);
			ISteamMatchmakingServers.NativeMethodInfoPtr__RequestHistoryServerList_Private_Static_HServerListRequest_IntPtr_AppId_byref_Il2CppReferenceArray_1_MatchMakingKeyValuePair_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServers>.NativeClassPtr, 100664299);
			ISteamMatchmakingServers.NativeMethodInfoPtr_RequestHistoryServerList_Internal_HServerListRequest_AppId_byref_Il2CppReferenceArray_1_MatchMakingKeyValuePair_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServers>.NativeClassPtr, 100664300);
			ISteamMatchmakingServers.NativeMethodInfoPtr__RequestSpectatorServerList_Private_Static_HServerListRequest_IntPtr_AppId_byref_Il2CppReferenceArray_1_MatchMakingKeyValuePair_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServers>.NativeClassPtr, 100664301);
			ISteamMatchmakingServers.NativeMethodInfoPtr_RequestSpectatorServerList_Internal_HServerListRequest_AppId_byref_Il2CppReferenceArray_1_MatchMakingKeyValuePair_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServers>.NativeClassPtr, 100664302);
			ISteamMatchmakingServers.NativeMethodInfoPtr__ReleaseRequest_Private_Static_Void_IntPtr_HServerListRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServers>.NativeClassPtr, 100664303);
			ISteamMatchmakingServers.NativeMethodInfoPtr_ReleaseRequest_Internal_Void_HServerListRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServers>.NativeClassPtr, 100664304);
			ISteamMatchmakingServers.NativeMethodInfoPtr__GetServerDetails_Private_Static_IntPtr_IntPtr_HServerListRequest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServers>.NativeClassPtr, 100664305);
			ISteamMatchmakingServers.NativeMethodInfoPtr_GetServerDetails_Internal_gameserveritem_t_HServerListRequest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServers>.NativeClassPtr, 100664306);
			ISteamMatchmakingServers.NativeMethodInfoPtr__CancelQuery_Private_Static_Void_IntPtr_HServerListRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServers>.NativeClassPtr, 100664307);
			ISteamMatchmakingServers.NativeMethodInfoPtr_CancelQuery_Internal_Void_HServerListRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServers>.NativeClassPtr, 100664308);
			ISteamMatchmakingServers.NativeMethodInfoPtr__RefreshQuery_Private_Static_Void_IntPtr_HServerListRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServers>.NativeClassPtr, 100664309);
			ISteamMatchmakingServers.NativeMethodInfoPtr_RefreshQuery_Internal_Void_HServerListRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServers>.NativeClassPtr, 100664310);
			ISteamMatchmakingServers.NativeMethodInfoPtr__IsRefreshing_Private_Static_Boolean_IntPtr_HServerListRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServers>.NativeClassPtr, 100664311);
			ISteamMatchmakingServers.NativeMethodInfoPtr_IsRefreshing_Internal_Boolean_HServerListRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServers>.NativeClassPtr, 100664312);
			ISteamMatchmakingServers.NativeMethodInfoPtr__GetServerCount_Private_Static_Int32_IntPtr_HServerListRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServers>.NativeClassPtr, 100664313);
			ISteamMatchmakingServers.NativeMethodInfoPtr_GetServerCount_Internal_Int32_HServerListRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServers>.NativeClassPtr, 100664314);
			ISteamMatchmakingServers.NativeMethodInfoPtr__RefreshServer_Private_Static_Void_IntPtr_HServerListRequest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServers>.NativeClassPtr, 100664315);
			ISteamMatchmakingServers.NativeMethodInfoPtr_RefreshServer_Internal_Void_HServerListRequest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServers>.NativeClassPtr, 100664316);
			ISteamMatchmakingServers.NativeMethodInfoPtr__PingServer_Private_Static_HServerQuery_IntPtr_UInt32_UInt16_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServers>.NativeClassPtr, 100664317);
			ISteamMatchmakingServers.NativeMethodInfoPtr_PingServer_Internal_HServerQuery_UInt32_UInt16_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServers>.NativeClassPtr, 100664318);
			ISteamMatchmakingServers.NativeMethodInfoPtr__PlayerDetails_Private_Static_HServerQuery_IntPtr_UInt32_UInt16_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServers>.NativeClassPtr, 100664319);
			ISteamMatchmakingServers.NativeMethodInfoPtr_PlayerDetails_Internal_HServerQuery_UInt32_UInt16_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServers>.NativeClassPtr, 100664320);
			ISteamMatchmakingServers.NativeMethodInfoPtr__ServerRules_Private_Static_HServerQuery_IntPtr_UInt32_UInt16_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServers>.NativeClassPtr, 100664321);
			ISteamMatchmakingServers.NativeMethodInfoPtr_ServerRules_Internal_HServerQuery_UInt32_UInt16_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServers>.NativeClassPtr, 100664322);
			ISteamMatchmakingServers.NativeMethodInfoPtr__CancelServerQuery_Private_Static_Void_IntPtr_HServerQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServers>.NativeClassPtr, 100664323);
			ISteamMatchmakingServers.NativeMethodInfoPtr_CancelServerQuery_Internal_Void_HServerQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServers>.NativeClassPtr, 100664324);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00027E00 File Offset: 0x00026000
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 930944, RefRangeEnd = 930966, XrefRangeStart = 930944, XrefRangeEnd = 930966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISteamMatchmakingServers(bool IsGameServer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingServers>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref IsGameServer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServers.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00027E48 File Offset: 0x00026048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933584, XrefRangeEnd = 933586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr SteamAPI_SteamMatchmakingServers_v002()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServers.NativeMethodInfoPtr_SteamAPI_SteamMatchmakingServers_v002_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00027E78 File Offset: 0x00026078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IntPtr GetUserInterfacePointer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamMatchmakingServers.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00027EC0 File Offset: 0x000260C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933586, XrefRangeEnd = 933596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HServerListRequest _RequestInternetServerList(IntPtr self, AppId iApp, [In] [Out] ref Il2CppReferenceArray<MatchMakingKeyValuePair> ppchFilters, uint nFilters, IntPtr pRequestServersResponse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iApp;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nFilters;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pRequestServersResponse;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServers.NativeMethodInfoPtr__RequestInternetServerList_Private_Static_HServerListRequest_IntPtr_AppId_byref_Il2CppReferenceArray_1_MatchMakingKeyValuePair_UInt32_IntPtr_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			ppchFilters = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<MatchMakingKeyValuePair>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00027F4C File Offset: 0x0002614C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933606, RefRangeEnd = 933607, XrefRangeStart = 933596, XrefRangeEnd = 933606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HServerListRequest RequestInternetServerList(AppId iApp, [In] [Out] ref Il2CppReferenceArray<MatchMakingKeyValuePair> ppchFilters, uint nFilters, IntPtr pRequestServersResponse)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iApp;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nFilters;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pRequestServersResponse;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServers.NativeMethodInfoPtr_RequestInternetServerList_Internal_HServerListRequest_AppId_byref_Il2CppReferenceArray_1_MatchMakingKeyValuePair_UInt32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			ppchFilters = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<MatchMakingKeyValuePair>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00027FD4 File Offset: 0x000261D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933607, XrefRangeEnd = 933609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HServerListRequest _RequestLANServerList(IntPtr self, AppId iApp, IntPtr pRequestServersResponse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iApp;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pRequestServersResponse;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServers.NativeMethodInfoPtr__RequestLANServerList_Private_Static_HServerListRequest_IntPtr_AppId_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00028030 File Offset: 0x00026230
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933611, RefRangeEnd = 933612, XrefRangeStart = 933609, XrefRangeEnd = 933611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HServerListRequest RequestLANServerList(AppId iApp, IntPtr pRequestServersResponse)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iApp;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pRequestServersResponse;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServers.NativeMethodInfoPtr_RequestLANServerList_Internal_HServerListRequest_AppId_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00028088 File Offset: 0x00026288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933612, XrefRangeEnd = 933622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HServerListRequest _RequestFriendsServerList(IntPtr self, AppId iApp, [In] [Out] ref Il2CppReferenceArray<MatchMakingKeyValuePair> ppchFilters, uint nFilters, IntPtr pRequestServersResponse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iApp;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nFilters;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pRequestServersResponse;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServers.NativeMethodInfoPtr__RequestFriendsServerList_Private_Static_HServerListRequest_IntPtr_AppId_byref_Il2CppReferenceArray_1_MatchMakingKeyValuePair_UInt32_IntPtr_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			ppchFilters = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<MatchMakingKeyValuePair>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00028114 File Offset: 0x00026314
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933632, RefRangeEnd = 933633, XrefRangeStart = 933622, XrefRangeEnd = 933632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HServerListRequest RequestFriendsServerList(AppId iApp, [In] [Out] ref Il2CppReferenceArray<MatchMakingKeyValuePair> ppchFilters, uint nFilters, IntPtr pRequestServersResponse)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iApp;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nFilters;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pRequestServersResponse;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServers.NativeMethodInfoPtr_RequestFriendsServerList_Internal_HServerListRequest_AppId_byref_Il2CppReferenceArray_1_MatchMakingKeyValuePair_UInt32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			ppchFilters = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<MatchMakingKeyValuePair>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x0002819C File Offset: 0x0002639C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933633, XrefRangeEnd = 933643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HServerListRequest _RequestFavoritesServerList(IntPtr self, AppId iApp, [In] [Out] ref Il2CppReferenceArray<MatchMakingKeyValuePair> ppchFilters, uint nFilters, IntPtr pRequestServersResponse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iApp;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nFilters;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pRequestServersResponse;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServers.NativeMethodInfoPtr__RequestFavoritesServerList_Private_Static_HServerListRequest_IntPtr_AppId_byref_Il2CppReferenceArray_1_MatchMakingKeyValuePair_UInt32_IntPtr_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			ppchFilters = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<MatchMakingKeyValuePair>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00028228 File Offset: 0x00026428
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933653, RefRangeEnd = 933654, XrefRangeStart = 933643, XrefRangeEnd = 933653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HServerListRequest RequestFavoritesServerList(AppId iApp, [In] [Out] ref Il2CppReferenceArray<MatchMakingKeyValuePair> ppchFilters, uint nFilters, IntPtr pRequestServersResponse)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iApp;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nFilters;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pRequestServersResponse;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServers.NativeMethodInfoPtr_RequestFavoritesServerList_Internal_HServerListRequest_AppId_byref_Il2CppReferenceArray_1_MatchMakingKeyValuePair_UInt32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			ppchFilters = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<MatchMakingKeyValuePair>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x000282B0 File Offset: 0x000264B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933654, XrefRangeEnd = 933664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HServerListRequest _RequestHistoryServerList(IntPtr self, AppId iApp, [In] [Out] ref Il2CppReferenceArray<MatchMakingKeyValuePair> ppchFilters, uint nFilters, IntPtr pRequestServersResponse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iApp;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nFilters;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pRequestServersResponse;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServers.NativeMethodInfoPtr__RequestHistoryServerList_Private_Static_HServerListRequest_IntPtr_AppId_byref_Il2CppReferenceArray_1_MatchMakingKeyValuePair_UInt32_IntPtr_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			ppchFilters = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<MatchMakingKeyValuePair>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0002833C File Offset: 0x0002653C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933674, RefRangeEnd = 933675, XrefRangeStart = 933664, XrefRangeEnd = 933674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HServerListRequest RequestHistoryServerList(AppId iApp, [In] [Out] ref Il2CppReferenceArray<MatchMakingKeyValuePair> ppchFilters, uint nFilters, IntPtr pRequestServersResponse)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iApp;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nFilters;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pRequestServersResponse;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServers.NativeMethodInfoPtr_RequestHistoryServerList_Internal_HServerListRequest_AppId_byref_Il2CppReferenceArray_1_MatchMakingKeyValuePair_UInt32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			ppchFilters = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<MatchMakingKeyValuePair>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x000283C4 File Offset: 0x000265C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933675, XrefRangeEnd = 933685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HServerListRequest _RequestSpectatorServerList(IntPtr self, AppId iApp, [In] [Out] ref Il2CppReferenceArray<MatchMakingKeyValuePair> ppchFilters, uint nFilters, IntPtr pRequestServersResponse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iApp;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nFilters;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pRequestServersResponse;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServers.NativeMethodInfoPtr__RequestSpectatorServerList_Private_Static_HServerListRequest_IntPtr_AppId_byref_Il2CppReferenceArray_1_MatchMakingKeyValuePair_UInt32_IntPtr_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			ppchFilters = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<MatchMakingKeyValuePair>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00028450 File Offset: 0x00026650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933685, XrefRangeEnd = 933695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HServerListRequest RequestSpectatorServerList(AppId iApp, [In] [Out] ref Il2CppReferenceArray<MatchMakingKeyValuePair> ppchFilters, uint nFilters, IntPtr pRequestServersResponse)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iApp;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nFilters;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pRequestServersResponse;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServers.NativeMethodInfoPtr_RequestSpectatorServerList_Internal_HServerListRequest_AppId_byref_Il2CppReferenceArray_1_MatchMakingKeyValuePair_UInt32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			ppchFilters = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<MatchMakingKeyValuePair>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x000284D8 File Offset: 0x000266D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933695, XrefRangeEnd = 933697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _ReleaseRequest(IntPtr self, HServerListRequest hServerListRequest)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hServerListRequest;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServers.NativeMethodInfoPtr__ReleaseRequest_Private_Static_Void_IntPtr_HServerListRequest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00028518 File Offset: 0x00026718
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 933699, RefRangeEnd = 933703, XrefRangeStart = 933697, XrefRangeEnd = 933699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseRequest(HServerListRequest hServerListRequest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hServerListRequest;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServers.NativeMethodInfoPtr_ReleaseRequest_Internal_Void_HServerListRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00028558 File Offset: 0x00026758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933703, XrefRangeEnd = 933705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr _GetServerDetails(IntPtr self, HServerListRequest hRequest, int iServer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServers.NativeMethodInfoPtr__GetServerDetails_Private_Static_IntPtr_IntPtr_HServerListRequest_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x000285B4 File Offset: 0x000267B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 933713, RefRangeEnd = 933715, XrefRangeStart = 933705, XrefRangeEnd = 933713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe gameserveritem_t GetServerDetails(HServerListRequest hRequest, int iServer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServers.NativeMethodInfoPtr_GetServerDetails_Internal_gameserveritem_t_HServerListRequest_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new gameserveritem_t(intPtr);
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00028608 File Offset: 0x00026808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933715, XrefRangeEnd = 933717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _CancelQuery(IntPtr self, HServerListRequest hRequest)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServers.NativeMethodInfoPtr__CancelQuery_Private_Static_Void_IntPtr_HServerListRequest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00028648 File Offset: 0x00026848
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933719, RefRangeEnd = 933720, XrefRangeStart = 933717, XrefRangeEnd = 933719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelQuery(HServerListRequest hRequest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServers.NativeMethodInfoPtr_CancelQuery_Internal_Void_HServerListRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00028688 File Offset: 0x00026888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933720, XrefRangeEnd = 933722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _RefreshQuery(IntPtr self, HServerListRequest hRequest)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServers.NativeMethodInfoPtr__RefreshQuery_Private_Static_Void_IntPtr_HServerListRequest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x000286C8 File Offset: 0x000268C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933722, XrefRangeEnd = 933724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshQuery(HServerListRequest hRequest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServers.NativeMethodInfoPtr_RefreshQuery_Internal_Void_HServerListRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00028708 File Offset: 0x00026908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933724, XrefRangeEnd = 933726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _IsRefreshing(IntPtr self, HServerListRequest hRequest)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServers.NativeMethodInfoPtr__IsRefreshing_Private_Static_Boolean_IntPtr_HServerListRequest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00028754 File Offset: 0x00026954
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933728, RefRangeEnd = 933729, XrefRangeStart = 933726, XrefRangeEnd = 933728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsRefreshing(HServerListRequest hRequest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServers.NativeMethodInfoPtr_IsRefreshing_Internal_Boolean_HServerListRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x000287A0 File Offset: 0x000269A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933729, XrefRangeEnd = 933731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetServerCount(IntPtr self, HServerListRequest hRequest)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServers.NativeMethodInfoPtr__GetServerCount_Private_Static_Int32_IntPtr_HServerListRequest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x000287EC File Offset: 0x000269EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 933733, RefRangeEnd = 933736, XrefRangeStart = 933731, XrefRangeEnd = 933733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetServerCount(HServerListRequest hRequest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServers.NativeMethodInfoPtr_GetServerCount_Internal_Int32_HServerListRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00028838 File Offset: 0x00026A38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933736, XrefRangeEnd = 933738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _RefreshServer(IntPtr self, HServerListRequest hRequest, int iServer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServers.NativeMethodInfoPtr__RefreshServer_Private_Static_Void_IntPtr_HServerListRequest_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00028888 File Offset: 0x00026A88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933738, XrefRangeEnd = 933740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshServer(HServerListRequest hRequest, int iServer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServers.NativeMethodInfoPtr_RefreshServer_Internal_Void_HServerListRequest_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x000288D4 File Offset: 0x00026AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933740, XrefRangeEnd = 933742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HServerQuery _PingServer(IntPtr self, uint unIP, ushort usPort, IntPtr pRequestServersResponse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unIP;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usPort;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pRequestServersResponse;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServers.NativeMethodInfoPtr__PingServer_Private_Static_HServerQuery_IntPtr_UInt32_UInt16_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x0002893C File Offset: 0x00026B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933742, XrefRangeEnd = 933744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HServerQuery PingServer(uint unIP, ushort usPort, IntPtr pRequestServersResponse)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unIP;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usPort;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pRequestServersResponse;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServers.NativeMethodInfoPtr_PingServer_Internal_HServerQuery_UInt32_UInt16_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x000289A4 File Offset: 0x00026BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933744, XrefRangeEnd = 933746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HServerQuery _PlayerDetails(IntPtr self, uint unIP, ushort usPort, IntPtr pRequestServersResponse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unIP;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usPort;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pRequestServersResponse;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServers.NativeMethodInfoPtr__PlayerDetails_Private_Static_HServerQuery_IntPtr_UInt32_UInt16_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00028A0C File Offset: 0x00026C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933746, XrefRangeEnd = 933748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HServerQuery PlayerDetails(uint unIP, ushort usPort, IntPtr pRequestServersResponse)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unIP;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usPort;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pRequestServersResponse;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServers.NativeMethodInfoPtr_PlayerDetails_Internal_HServerQuery_UInt32_UInt16_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00028A74 File Offset: 0x00026C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933748, XrefRangeEnd = 933750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HServerQuery _ServerRules(IntPtr self, uint unIP, ushort usPort, IntPtr pRequestServersResponse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unIP;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usPort;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pRequestServersResponse;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServers.NativeMethodInfoPtr__ServerRules_Private_Static_HServerQuery_IntPtr_UInt32_UInt16_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00028ADC File Offset: 0x00026CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933750, XrefRangeEnd = 933752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HServerQuery ServerRules(uint unIP, ushort usPort, IntPtr pRequestServersResponse)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unIP;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usPort;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pRequestServersResponse;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServers.NativeMethodInfoPtr_ServerRules_Internal_HServerQuery_UInt32_UInt16_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00028B44 File Offset: 0x00026D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933752, XrefRangeEnd = 933754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _CancelServerQuery(IntPtr self, HServerQuery hServerQuery)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hServerQuery;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServers.NativeMethodInfoPtr__CancelServerQuery_Private_Static_Void_IntPtr_HServerQuery_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00028B84 File Offset: 0x00026D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933754, XrefRangeEnd = 933756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelServerQuery(HServerQuery hServerQuery)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hServerQuery;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServers.NativeMethodInfoPtr_CancelServerQuery_Internal_Void_HServerQuery_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x0000236C File Offset: 0x0000056C
		public ISteamMatchmakingServers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004A6 RID: 1190
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x040004A7 RID: 1191
		private static readonly IntPtr NativeMethodInfoPtr_SteamAPI_SteamMatchmakingServers_v002_Internal_Static_IntPtr_0;

		// Token: 0x040004A8 RID: 1192
		private static readonly IntPtr NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0;

		// Token: 0x040004A9 RID: 1193
		private static readonly IntPtr NativeMethodInfoPtr__RequestInternetServerList_Private_Static_HServerListRequest_IntPtr_AppId_byref_Il2CppReferenceArray_1_MatchMakingKeyValuePair_UInt32_IntPtr_0;

		// Token: 0x040004AA RID: 1194
		private static readonly IntPtr NativeMethodInfoPtr_RequestInternetServerList_Internal_HServerListRequest_AppId_byref_Il2CppReferenceArray_1_MatchMakingKeyValuePair_UInt32_IntPtr_0;

		// Token: 0x040004AB RID: 1195
		private static readonly IntPtr NativeMethodInfoPtr__RequestLANServerList_Private_Static_HServerListRequest_IntPtr_AppId_IntPtr_0;

		// Token: 0x040004AC RID: 1196
		private static readonly IntPtr NativeMethodInfoPtr_RequestLANServerList_Internal_HServerListRequest_AppId_IntPtr_0;

		// Token: 0x040004AD RID: 1197
		private static readonly IntPtr NativeMethodInfoPtr__RequestFriendsServerList_Private_Static_HServerListRequest_IntPtr_AppId_byref_Il2CppReferenceArray_1_MatchMakingKeyValuePair_UInt32_IntPtr_0;

		// Token: 0x040004AE RID: 1198
		private static readonly IntPtr NativeMethodInfoPtr_RequestFriendsServerList_Internal_HServerListRequest_AppId_byref_Il2CppReferenceArray_1_MatchMakingKeyValuePair_UInt32_IntPtr_0;

		// Token: 0x040004AF RID: 1199
		private static readonly IntPtr NativeMethodInfoPtr__RequestFavoritesServerList_Private_Static_HServerListRequest_IntPtr_AppId_byref_Il2CppReferenceArray_1_MatchMakingKeyValuePair_UInt32_IntPtr_0;

		// Token: 0x040004B0 RID: 1200
		private static readonly IntPtr NativeMethodInfoPtr_RequestFavoritesServerList_Internal_HServerListRequest_AppId_byref_Il2CppReferenceArray_1_MatchMakingKeyValuePair_UInt32_IntPtr_0;

		// Token: 0x040004B1 RID: 1201
		private static readonly IntPtr NativeMethodInfoPtr__RequestHistoryServerList_Private_Static_HServerListRequest_IntPtr_AppId_byref_Il2CppReferenceArray_1_MatchMakingKeyValuePair_UInt32_IntPtr_0;

		// Token: 0x040004B2 RID: 1202
		private static readonly IntPtr NativeMethodInfoPtr_RequestHistoryServerList_Internal_HServerListRequest_AppId_byref_Il2CppReferenceArray_1_MatchMakingKeyValuePair_UInt32_IntPtr_0;

		// Token: 0x040004B3 RID: 1203
		private static readonly IntPtr NativeMethodInfoPtr__RequestSpectatorServerList_Private_Static_HServerListRequest_IntPtr_AppId_byref_Il2CppReferenceArray_1_MatchMakingKeyValuePair_UInt32_IntPtr_0;

		// Token: 0x040004B4 RID: 1204
		private static readonly IntPtr NativeMethodInfoPtr_RequestSpectatorServerList_Internal_HServerListRequest_AppId_byref_Il2CppReferenceArray_1_MatchMakingKeyValuePair_UInt32_IntPtr_0;

		// Token: 0x040004B5 RID: 1205
		private static readonly IntPtr NativeMethodInfoPtr__ReleaseRequest_Private_Static_Void_IntPtr_HServerListRequest_0;

		// Token: 0x040004B6 RID: 1206
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseRequest_Internal_Void_HServerListRequest_0;

		// Token: 0x040004B7 RID: 1207
		private static readonly IntPtr NativeMethodInfoPtr__GetServerDetails_Private_Static_IntPtr_IntPtr_HServerListRequest_Int32_0;

		// Token: 0x040004B8 RID: 1208
		private static readonly IntPtr NativeMethodInfoPtr_GetServerDetails_Internal_gameserveritem_t_HServerListRequest_Int32_0;

		// Token: 0x040004B9 RID: 1209
		private static readonly IntPtr NativeMethodInfoPtr__CancelQuery_Private_Static_Void_IntPtr_HServerListRequest_0;

		// Token: 0x040004BA RID: 1210
		private static readonly IntPtr NativeMethodInfoPtr_CancelQuery_Internal_Void_HServerListRequest_0;

		// Token: 0x040004BB RID: 1211
		private static readonly IntPtr NativeMethodInfoPtr__RefreshQuery_Private_Static_Void_IntPtr_HServerListRequest_0;

		// Token: 0x040004BC RID: 1212
		private static readonly IntPtr NativeMethodInfoPtr_RefreshQuery_Internal_Void_HServerListRequest_0;

		// Token: 0x040004BD RID: 1213
		private static readonly IntPtr NativeMethodInfoPtr__IsRefreshing_Private_Static_Boolean_IntPtr_HServerListRequest_0;

		// Token: 0x040004BE RID: 1214
		private static readonly IntPtr NativeMethodInfoPtr_IsRefreshing_Internal_Boolean_HServerListRequest_0;

		// Token: 0x040004BF RID: 1215
		private static readonly IntPtr NativeMethodInfoPtr__GetServerCount_Private_Static_Int32_IntPtr_HServerListRequest_0;

		// Token: 0x040004C0 RID: 1216
		private static readonly IntPtr NativeMethodInfoPtr_GetServerCount_Internal_Int32_HServerListRequest_0;

		// Token: 0x040004C1 RID: 1217
		private static readonly IntPtr NativeMethodInfoPtr__RefreshServer_Private_Static_Void_IntPtr_HServerListRequest_Int32_0;

		// Token: 0x040004C2 RID: 1218
		private static readonly IntPtr NativeMethodInfoPtr_RefreshServer_Internal_Void_HServerListRequest_Int32_0;

		// Token: 0x040004C3 RID: 1219
		private static readonly IntPtr NativeMethodInfoPtr__PingServer_Private_Static_HServerQuery_IntPtr_UInt32_UInt16_IntPtr_0;

		// Token: 0x040004C4 RID: 1220
		private static readonly IntPtr NativeMethodInfoPtr_PingServer_Internal_HServerQuery_UInt32_UInt16_IntPtr_0;

		// Token: 0x040004C5 RID: 1221
		private static readonly IntPtr NativeMethodInfoPtr__PlayerDetails_Private_Static_HServerQuery_IntPtr_UInt32_UInt16_IntPtr_0;

		// Token: 0x040004C6 RID: 1222
		private static readonly IntPtr NativeMethodInfoPtr_PlayerDetails_Internal_HServerQuery_UInt32_UInt16_IntPtr_0;

		// Token: 0x040004C7 RID: 1223
		private static readonly IntPtr NativeMethodInfoPtr__ServerRules_Private_Static_HServerQuery_IntPtr_UInt32_UInt16_IntPtr_0;

		// Token: 0x040004C8 RID: 1224
		private static readonly IntPtr NativeMethodInfoPtr_ServerRules_Internal_HServerQuery_UInt32_UInt16_IntPtr_0;

		// Token: 0x040004C9 RID: 1225
		private static readonly IntPtr NativeMethodInfoPtr__CancelServerQuery_Private_Static_Void_IntPtr_HServerQuery_0;

		// Token: 0x040004CA RID: 1226
		private static readonly IntPtr NativeMethodInfoPtr_CancelServerQuery_Internal_Void_HServerQuery_0;
	}
}
