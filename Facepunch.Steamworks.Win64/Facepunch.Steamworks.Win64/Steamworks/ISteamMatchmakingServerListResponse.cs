using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x0200001D RID: 29
	public class ISteamMatchmakingServerListResponse : SteamInterface
	{
		// Token: 0x06000410 RID: 1040 RVA: 0x00027814 File Offset: 0x00025A14
		// Note: this type is marked as 'beforefieldinit'.
		static ISteamMatchmakingServerListResponse()
		{
			Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "ISteamMatchmakingServerListResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr);
			ISteamMatchmakingServerListResponse.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, 100664281);
			ISteamMatchmakingServerListResponse.NativeMethodInfoPtr__ServerResponded_Private_Static_Void_IntPtr_HServerListRequest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, 100664282);
			ISteamMatchmakingServerListResponse.NativeMethodInfoPtr_ServerResponded_Internal_Void_HServerListRequest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, 100664283);
			ISteamMatchmakingServerListResponse.NativeMethodInfoPtr__ServerFailedToRespond_Private_Static_Void_IntPtr_HServerListRequest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, 100664284);
			ISteamMatchmakingServerListResponse.NativeMethodInfoPtr_ServerFailedToRespond_Internal_Void_HServerListRequest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, 100664285);
			ISteamMatchmakingServerListResponse.NativeMethodInfoPtr__RefreshComplete_Private_Static_Void_IntPtr_HServerListRequest_MatchMakingServerResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, 100664286);
			ISteamMatchmakingServerListResponse.NativeMethodInfoPtr_RefreshComplete_Internal_Void_HServerListRequest_MatchMakingServerResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr, 100664287);
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x000278D0 File Offset: 0x00025AD0
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 930944, RefRangeEnd = 930966, XrefRangeStart = 930944, XrefRangeEnd = 930966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISteamMatchmakingServerListResponse(bool IsGameServer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingServerListResponse>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref IsGameServer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00027918 File Offset: 0x00025B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933572, XrefRangeEnd = 933574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _ServerResponded(IntPtr self, HServerListRequest hRequest, int iServer)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.NativeMethodInfoPtr__ServerResponded_Private_Static_Void_IntPtr_HServerListRequest_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00027968 File Offset: 0x00025B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933574, XrefRangeEnd = 933576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ServerResponded(HServerListRequest hRequest, int iServer)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.NativeMethodInfoPtr_ServerResponded_Internal_Void_HServerListRequest_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x000279B4 File Offset: 0x00025BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933576, XrefRangeEnd = 933578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _ServerFailedToRespond(IntPtr self, HServerListRequest hRequest, int iServer)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.NativeMethodInfoPtr__ServerFailedToRespond_Private_Static_Void_IntPtr_HServerListRequest_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00027A04 File Offset: 0x00025C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933578, XrefRangeEnd = 933580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ServerFailedToRespond(HServerListRequest hRequest, int iServer)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.NativeMethodInfoPtr_ServerFailedToRespond_Internal_Void_HServerListRequest_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00027A50 File Offset: 0x00025C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933580, XrefRangeEnd = 933582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _RefreshComplete(IntPtr self, HServerListRequest hRequest, MatchMakingServerResponse response)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref response;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.NativeMethodInfoPtr__RefreshComplete_Private_Static_Void_IntPtr_HServerListRequest_MatchMakingServerResponse_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00027AA0 File Offset: 0x00025CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933582, XrefRangeEnd = 933584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshComplete(HServerListRequest hRequest, MatchMakingServerResponse response)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref response;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingServerListResponse.NativeMethodInfoPtr_RefreshComplete_Internal_Void_HServerListRequest_MatchMakingServerResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00002363 File Offset: 0x00000563
		public ISteamMatchmakingServerListResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400049F RID: 1183
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x040004A0 RID: 1184
		private static readonly IntPtr NativeMethodInfoPtr__ServerResponded_Private_Static_Void_IntPtr_HServerListRequest_Int32_0;

		// Token: 0x040004A1 RID: 1185
		private static readonly IntPtr NativeMethodInfoPtr_ServerResponded_Internal_Void_HServerListRequest_Int32_0;

		// Token: 0x040004A2 RID: 1186
		private static readonly IntPtr NativeMethodInfoPtr__ServerFailedToRespond_Private_Static_Void_IntPtr_HServerListRequest_Int32_0;

		// Token: 0x040004A3 RID: 1187
		private static readonly IntPtr NativeMethodInfoPtr_ServerFailedToRespond_Internal_Void_HServerListRequest_Int32_0;

		// Token: 0x040004A4 RID: 1188
		private static readonly IntPtr NativeMethodInfoPtr__RefreshComplete_Private_Static_Void_IntPtr_HServerListRequest_MatchMakingServerResponse_0;

		// Token: 0x040004A5 RID: 1189
		private static readonly IntPtr NativeMethodInfoPtr_RefreshComplete_Internal_Void_HServerListRequest_MatchMakingServerResponse_0;
	}
}
