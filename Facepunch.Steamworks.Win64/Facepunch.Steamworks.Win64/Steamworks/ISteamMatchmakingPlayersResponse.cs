using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Steamworks
{
	// Token: 0x0200001B RID: 27
	public class ISteamMatchmakingPlayersResponse : SteamInterface
	{
		// Token: 0x060003FE RID: 1022 RVA: 0x00027300 File Offset: 0x00025500
		// Note: this type is marked as 'beforefieldinit'.
		static ISteamMatchmakingPlayersResponse()
		{
			Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "ISteamMatchmakingPlayersResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr);
			ISteamMatchmakingPlayersResponse.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, 100664267);
			ISteamMatchmakingPlayersResponse.NativeMethodInfoPtr__AddPlayerToList_Private_Static_Void_IntPtr_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, 100664268);
			ISteamMatchmakingPlayersResponse.NativeMethodInfoPtr_AddPlayerToList_Internal_Void_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, 100664269);
			ISteamMatchmakingPlayersResponse.NativeMethodInfoPtr__PlayersFailedToRespond_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, 100664270);
			ISteamMatchmakingPlayersResponse.NativeMethodInfoPtr_PlayersFailedToRespond_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, 100664271);
			ISteamMatchmakingPlayersResponse.NativeMethodInfoPtr__PlayersRefreshComplete_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, 100664272);
			ISteamMatchmakingPlayersResponse.NativeMethodInfoPtr_PlayersRefreshComplete_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr, 100664273);
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x000273BC File Offset: 0x000255BC
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 930944, RefRangeEnd = 930966, XrefRangeStart = 930944, XrefRangeEnd = 930966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISteamMatchmakingPlayersResponse(bool IsGameServer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingPlayersResponse>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref IsGameServer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00027404 File Offset: 0x00025604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933540, XrefRangeEnd = 933543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _AddPlayerToList(IntPtr self, string pchName, int nScore, float flTimePlayed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nScore;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flTimePlayed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.NativeMethodInfoPtr__AddPlayerToList_Private_Static_Void_IntPtr_String_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00027464 File Offset: 0x00025664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933543, XrefRangeEnd = 933546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPlayerToList(string pchName, int nScore, float flTimePlayed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nScore;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flTimePlayed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.NativeMethodInfoPtr_AddPlayerToList_Internal_Void_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x000274C4 File Offset: 0x000256C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933546, XrefRangeEnd = 933548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _PlayersFailedToRespond(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.NativeMethodInfoPtr__PlayersFailedToRespond_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x000274F8 File Offset: 0x000256F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933548, XrefRangeEnd = 933550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayersFailedToRespond()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.NativeMethodInfoPtr_PlayersFailedToRespond_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x0002752C File Offset: 0x0002572C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933550, XrefRangeEnd = 933552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _PlayersRefreshComplete(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.NativeMethodInfoPtr__PlayersRefreshComplete_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00027560 File Offset: 0x00025760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933552, XrefRangeEnd = 933554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayersRefreshComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingPlayersResponse.NativeMethodInfoPtr_PlayersRefreshComplete_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00002351 File Offset: 0x00000551
		public ISteamMatchmakingPlayersResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000491 RID: 1169
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x04000492 RID: 1170
		private static readonly IntPtr NativeMethodInfoPtr__AddPlayerToList_Private_Static_Void_IntPtr_String_Int32_Single_0;

		// Token: 0x04000493 RID: 1171
		private static readonly IntPtr NativeMethodInfoPtr_AddPlayerToList_Internal_Void_String_Int32_Single_0;

		// Token: 0x04000494 RID: 1172
		private static readonly IntPtr NativeMethodInfoPtr__PlayersFailedToRespond_Private_Static_Void_IntPtr_0;

		// Token: 0x04000495 RID: 1173
		private static readonly IntPtr NativeMethodInfoPtr_PlayersFailedToRespond_Internal_Void_0;

		// Token: 0x04000496 RID: 1174
		private static readonly IntPtr NativeMethodInfoPtr__PlayersRefreshComplete_Private_Static_Void_IntPtr_0;

		// Token: 0x04000497 RID: 1175
		private static readonly IntPtr NativeMethodInfoPtr_PlayersRefreshComplete_Internal_Void_0;
	}
}
