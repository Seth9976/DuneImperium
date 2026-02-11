using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x020000A2 RID: 162
	public class SteamMatchmaking : SteamClientClass<SteamMatchmaking>
	{
		// Token: 0x0600094C RID: 2380 RVA: 0x000462B0 File Offset: 0x000444B0
		// Note: this type is marked as 'beforefieldinit'.
		static SteamMatchmaking()
		{
			Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "SteamMatchmaking");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr);
			SteamMatchmaking.NativeFieldInfoPtr_OnLobbyInvite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, "OnLobbyInvite");
			SteamMatchmaking.NativeFieldInfoPtr_OnLobbyEntered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, "OnLobbyEntered");
			SteamMatchmaking.NativeFieldInfoPtr_OnLobbyCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, "OnLobbyCreated");
			SteamMatchmaking.NativeFieldInfoPtr_OnLobbyGameCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, "OnLobbyGameCreated");
			SteamMatchmaking.NativeFieldInfoPtr_OnLobbyDataChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, "OnLobbyDataChanged");
			SteamMatchmaking.NativeFieldInfoPtr_OnLobbyMemberDataChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, "OnLobbyMemberDataChanged");
			SteamMatchmaking.NativeFieldInfoPtr_OnLobbyMemberJoined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, "OnLobbyMemberJoined");
			SteamMatchmaking.NativeFieldInfoPtr_OnLobbyMemberLeave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, "OnLobbyMemberLeave");
			SteamMatchmaking.NativeFieldInfoPtr_OnLobbyMemberDisconnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, "OnLobbyMemberDisconnected");
			SteamMatchmaking.NativeFieldInfoPtr_OnLobbyMemberKicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, "OnLobbyMemberKicked");
			SteamMatchmaking.NativeFieldInfoPtr_OnLobbyMemberBanned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, "OnLobbyMemberBanned");
			SteamMatchmaking.NativeFieldInfoPtr_OnChatMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, "OnChatMessage");
			SteamMatchmaking.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamMatchmaking_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100665589);
			SteamMatchmaking.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100665590);
			SteamMatchmaking.NativeMethodInfoPtr_get_MaxLobbyKeyLength_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100665591);
			SteamMatchmaking.NativeMethodInfoPtr_InstallEvents_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100665592);
			SteamMatchmaking.NativeMethodInfoPtr_OnLobbyChatMessageRecievedAPI_Private_Static_Void_LobbyChatMsg_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100665593);
			SteamMatchmaking.NativeMethodInfoPtr_add_OnLobbyInvite_Public_Static_add_Void_Action_2_Friend_Lobby_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100665594);
			SteamMatchmaking.NativeMethodInfoPtr_remove_OnLobbyInvite_Public_Static_rem_Void_Action_2_Friend_Lobby_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100665595);
			SteamMatchmaking.NativeMethodInfoPtr_add_OnLobbyEntered_Public_Static_add_Void_Action_1_Lobby_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100665596);
			SteamMatchmaking.NativeMethodInfoPtr_remove_OnLobbyEntered_Public_Static_rem_Void_Action_1_Lobby_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100665597);
			SteamMatchmaking.NativeMethodInfoPtr_add_OnLobbyCreated_Public_Static_add_Void_Action_2_Result_Lobby_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100665598);
			SteamMatchmaking.NativeMethodInfoPtr_remove_OnLobbyCreated_Public_Static_rem_Void_Action_2_Result_Lobby_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100665599);
			SteamMatchmaking.NativeMethodInfoPtr_add_OnLobbyGameCreated_Public_Static_add_Void_Action_4_Lobby_UInt32_UInt16_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100665600);
			SteamMatchmaking.NativeMethodInfoPtr_remove_OnLobbyGameCreated_Public_Static_rem_Void_Action_4_Lobby_UInt32_UInt16_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100665601);
			SteamMatchmaking.NativeMethodInfoPtr_add_OnLobbyDataChanged_Public_Static_add_Void_Action_1_Lobby_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100665602);
			SteamMatchmaking.NativeMethodInfoPtr_remove_OnLobbyDataChanged_Public_Static_rem_Void_Action_1_Lobby_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100665603);
			SteamMatchmaking.NativeMethodInfoPtr_add_OnLobbyMemberDataChanged_Public_Static_add_Void_Action_2_Lobby_Friend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100665604);
			SteamMatchmaking.NativeMethodInfoPtr_remove_OnLobbyMemberDataChanged_Public_Static_rem_Void_Action_2_Lobby_Friend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100665605);
			SteamMatchmaking.NativeMethodInfoPtr_add_OnLobbyMemberJoined_Public_Static_add_Void_Action_2_Lobby_Friend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100665606);
			SteamMatchmaking.NativeMethodInfoPtr_remove_OnLobbyMemberJoined_Public_Static_rem_Void_Action_2_Lobby_Friend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100665607);
			SteamMatchmaking.NativeMethodInfoPtr_add_OnLobbyMemberLeave_Public_Static_add_Void_Action_2_Lobby_Friend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100665608);
			SteamMatchmaking.NativeMethodInfoPtr_remove_OnLobbyMemberLeave_Public_Static_rem_Void_Action_2_Lobby_Friend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100665609);
			SteamMatchmaking.NativeMethodInfoPtr_add_OnLobbyMemberDisconnected_Public_Static_add_Void_Action_2_Lobby_Friend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100665610);
			SteamMatchmaking.NativeMethodInfoPtr_remove_OnLobbyMemberDisconnected_Public_Static_rem_Void_Action_2_Lobby_Friend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100665611);
			SteamMatchmaking.NativeMethodInfoPtr_add_OnLobbyMemberKicked_Public_Static_add_Void_Action_3_Lobby_Friend_Friend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100665612);
			SteamMatchmaking.NativeMethodInfoPtr_remove_OnLobbyMemberKicked_Public_Static_rem_Void_Action_3_Lobby_Friend_Friend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100665613);
			SteamMatchmaking.NativeMethodInfoPtr_add_OnLobbyMemberBanned_Public_Static_add_Void_Action_3_Lobby_Friend_Friend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100665614);
			SteamMatchmaking.NativeMethodInfoPtr_remove_OnLobbyMemberBanned_Public_Static_rem_Void_Action_3_Lobby_Friend_Friend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100665615);
			SteamMatchmaking.NativeMethodInfoPtr_add_OnChatMessage_Public_Static_add_Void_Action_3_Lobby_Friend_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100665616);
			SteamMatchmaking.NativeMethodInfoPtr_remove_OnChatMessage_Public_Static_rem_Void_Action_3_Lobby_Friend_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100665617);
			SteamMatchmaking.NativeMethodInfoPtr_get_LobbyList_Public_Static_get_LobbyQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100665618);
			SteamMatchmaking.NativeMethodInfoPtr_CreateLobbyAsync_Public_Static_Task_1_Nullable_1_Lobby_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100665619);
			SteamMatchmaking.NativeMethodInfoPtr_JoinLobbyAsync_Public_Static_Task_1_Nullable_1_Lobby_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100665620);
			SteamMatchmaking.NativeMethodInfoPtr_GetFavoriteServers_Public_Static_IEnumerable_1_ServerInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100665621);
			SteamMatchmaking.NativeMethodInfoPtr_GetHistoryServers_Public_Static_IEnumerable_1_ServerInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100665622);
			SteamMatchmaking.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100665623);
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600094D RID: 2381 RVA: 0x0004668C File Offset: 0x0004488C
		public unsafe static ISteamMatchmaking Internal
		{
			[CallerCount(49)]
			[CachedScanResults(RefRangeStart = 940170, RefRangeEnd = 940219, XrefRangeStart = 940167, XrefRangeEnd = 940170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamMatchmaking_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISteamMatchmaking>(intPtr3) : null;
			}
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x000466C0 File Offset: 0x000448C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940219, XrefRangeEnd = 940224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeInterface(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref server;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamMatchmaking.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600094F RID: 2383 RVA: 0x0004670C File Offset: 0x0004490C
		public unsafe static int MaxLobbyKeyLength
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 940224, RefRangeEnd = 940227, XrefRangeStart = 940224, XrefRangeEnd = 940224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_get_MaxLobbyKeyLength_Internal_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x0004673C File Offset: 0x0004493C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 940352, RefRangeEnd = 940353, XrefRangeStart = 940227, XrefRangeEnd = 940352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InstallEvents()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_InstallEvents_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00046764 File Offset: 0x00044964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940353, XrefRangeEnd = 940386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnLobbyChatMessageRecievedAPI(LobbyChatMsg_t callback)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref callback;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_OnLobbyChatMessageRecievedAPI_Private_Static_Void_LobbyChatMsg_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x00046798 File Offset: 0x00044998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940386, XrefRangeEnd = 940395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnLobbyInvite(Action<Friend, Lobby> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_add_OnLobbyInvite_Public_Static_add_Void_Action_2_Friend_Lobby_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x000467D0 File Offset: 0x000449D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940395, XrefRangeEnd = 940404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnLobbyInvite(Action<Friend, Lobby> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_remove_OnLobbyInvite_Public_Static_rem_Void_Action_2_Friend_Lobby_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x00046808 File Offset: 0x00044A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940404, XrefRangeEnd = 940413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnLobbyEntered(Action<Lobby> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_add_OnLobbyEntered_Public_Static_add_Void_Action_1_Lobby_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x00046840 File Offset: 0x00044A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940413, XrefRangeEnd = 940422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnLobbyEntered(Action<Lobby> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_remove_OnLobbyEntered_Public_Static_rem_Void_Action_1_Lobby_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x00046878 File Offset: 0x00044A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940422, XrefRangeEnd = 940431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnLobbyCreated(Action<Result, Lobby> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_add_OnLobbyCreated_Public_Static_add_Void_Action_2_Result_Lobby_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x000468B0 File Offset: 0x00044AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940431, XrefRangeEnd = 940440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnLobbyCreated(Action<Result, Lobby> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_remove_OnLobbyCreated_Public_Static_rem_Void_Action_2_Result_Lobby_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x000468E8 File Offset: 0x00044AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940440, XrefRangeEnd = 940449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnLobbyGameCreated(Action<Lobby, uint, ushort, SteamId> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_add_OnLobbyGameCreated_Public_Static_add_Void_Action_4_Lobby_UInt32_UInt16_SteamId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x00046920 File Offset: 0x00044B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940449, XrefRangeEnd = 940458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnLobbyGameCreated(Action<Lobby, uint, ushort, SteamId> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_remove_OnLobbyGameCreated_Public_Static_rem_Void_Action_4_Lobby_UInt32_UInt16_SteamId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00046958 File Offset: 0x00044B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940458, XrefRangeEnd = 940467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnLobbyDataChanged(Action<Lobby> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_add_OnLobbyDataChanged_Public_Static_add_Void_Action_1_Lobby_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x00046990 File Offset: 0x00044B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940467, XrefRangeEnd = 940476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnLobbyDataChanged(Action<Lobby> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_remove_OnLobbyDataChanged_Public_Static_rem_Void_Action_1_Lobby_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x000469C8 File Offset: 0x00044BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940476, XrefRangeEnd = 940485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnLobbyMemberDataChanged(Action<Lobby, Friend> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_add_OnLobbyMemberDataChanged_Public_Static_add_Void_Action_2_Lobby_Friend_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x00046A00 File Offset: 0x00044C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940485, XrefRangeEnd = 940494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnLobbyMemberDataChanged(Action<Lobby, Friend> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_remove_OnLobbyMemberDataChanged_Public_Static_rem_Void_Action_2_Lobby_Friend_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x00046A38 File Offset: 0x00044C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940494, XrefRangeEnd = 940503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnLobbyMemberJoined(Action<Lobby, Friend> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_add_OnLobbyMemberJoined_Public_Static_add_Void_Action_2_Lobby_Friend_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x00046A70 File Offset: 0x00044C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940503, XrefRangeEnd = 940512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnLobbyMemberJoined(Action<Lobby, Friend> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_remove_OnLobbyMemberJoined_Public_Static_rem_Void_Action_2_Lobby_Friend_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x00046AA8 File Offset: 0x00044CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940512, XrefRangeEnd = 940521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnLobbyMemberLeave(Action<Lobby, Friend> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_add_OnLobbyMemberLeave_Public_Static_add_Void_Action_2_Lobby_Friend_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x00046AE0 File Offset: 0x00044CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940521, XrefRangeEnd = 940530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnLobbyMemberLeave(Action<Lobby, Friend> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_remove_OnLobbyMemberLeave_Public_Static_rem_Void_Action_2_Lobby_Friend_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x00046B18 File Offset: 0x00044D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940530, XrefRangeEnd = 940539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnLobbyMemberDisconnected(Action<Lobby, Friend> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_add_OnLobbyMemberDisconnected_Public_Static_add_Void_Action_2_Lobby_Friend_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x00046B50 File Offset: 0x00044D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940539, XrefRangeEnd = 940548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnLobbyMemberDisconnected(Action<Lobby, Friend> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_remove_OnLobbyMemberDisconnected_Public_Static_rem_Void_Action_2_Lobby_Friend_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x00046B88 File Offset: 0x00044D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940548, XrefRangeEnd = 940557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnLobbyMemberKicked(Action<Lobby, Friend, Friend> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_add_OnLobbyMemberKicked_Public_Static_add_Void_Action_3_Lobby_Friend_Friend_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x00046BC0 File Offset: 0x00044DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940557, XrefRangeEnd = 940566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnLobbyMemberKicked(Action<Lobby, Friend, Friend> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_remove_OnLobbyMemberKicked_Public_Static_rem_Void_Action_3_Lobby_Friend_Friend_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x00046BF8 File Offset: 0x00044DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940566, XrefRangeEnd = 940575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnLobbyMemberBanned(Action<Lobby, Friend, Friend> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_add_OnLobbyMemberBanned_Public_Static_add_Void_Action_3_Lobby_Friend_Friend_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x00046C30 File Offset: 0x00044E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940575, XrefRangeEnd = 940584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnLobbyMemberBanned(Action<Lobby, Friend, Friend> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_remove_OnLobbyMemberBanned_Public_Static_rem_Void_Action_3_Lobby_Friend_Friend_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x00046C68 File Offset: 0x00044E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940584, XrefRangeEnd = 940593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnChatMessage(Action<Lobby, Friend, string> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_add_OnChatMessage_Public_Static_add_Void_Action_3_Lobby_Friend_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x00046CA0 File Offset: 0x00044EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940593, XrefRangeEnd = 940602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnChatMessage(Action<Lobby, Friend, string> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_remove_OnChatMessage_Public_Static_rem_Void_Action_3_Lobby_Friend_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600096A RID: 2410 RVA: 0x00046CD8 File Offset: 0x00044ED8
		public unsafe static LobbyQuery LobbyList
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_get_LobbyList_Public_Static_get_LobbyQuery_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new LobbyQuery(intPtr);
			}
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x00046D04 File Offset: 0x00044F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940602, XrefRangeEnd = 940615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Nullable<Lobby>> CreateLobbyAsync(int maxMembers = 100)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxMembers;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_CreateLobbyAsync_Public_Static_Task_1_Nullable_1_Lobby_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<Lobby>>>(intPtr3) : null;
			}
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x00046D44 File Offset: 0x00044F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940615, XrefRangeEnd = 940628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Nullable<Lobby>> JoinLobbyAsync(SteamId lobbyId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lobbyId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_JoinLobbyAsync_Public_Static_Task_1_Nullable_1_Lobby_SteamId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<Lobby>>>(intPtr3) : null;
			}
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x00046D84 File Offset: 0x00044F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940628, XrefRangeEnd = 940633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<ServerInfo> GetFavoriteServers()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_GetFavoriteServers_Public_Static_IEnumerable_1_ServerInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ServerInfo>>(intPtr3) : null;
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x00046DB8 File Offset: 0x00044FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940633, XrefRangeEnd = 940638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<ServerInfo> GetHistoryServers()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_GetHistoryServers_Public_Static_IEnumerable_1_ServerInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ServerInfo>>(intPtr3) : null;
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x00046DEC File Offset: 0x00044FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940638, XrefRangeEnd = 940641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamMatchmaking()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x0000287F File Offset: 0x00000A7F
		public SteamMatchmaking(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000971 RID: 2417 RVA: 0x00046E28 File Offset: 0x00045028
		// (set) Token: 0x06000972 RID: 2418 RVA: 0x00002888 File Offset: 0x00000A88
		public unsafe static Action<Friend, Lobby> OnLobbyInvite
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamMatchmaking.NativeFieldInfoPtr_OnLobbyInvite, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Friend, Lobby>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamMatchmaking.NativeFieldInfoPtr_OnLobbyInvite, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000973 RID: 2419 RVA: 0x00046E50 File Offset: 0x00045050
		// (set) Token: 0x06000974 RID: 2420 RVA: 0x0000289A File Offset: 0x00000A9A
		public unsafe static Action<Lobby> OnLobbyEntered
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamMatchmaking.NativeFieldInfoPtr_OnLobbyEntered, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Lobby>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamMatchmaking.NativeFieldInfoPtr_OnLobbyEntered, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000975 RID: 2421 RVA: 0x00046E78 File Offset: 0x00045078
		// (set) Token: 0x06000976 RID: 2422 RVA: 0x000028AC File Offset: 0x00000AAC
		public unsafe static Action<Result, Lobby> OnLobbyCreated
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamMatchmaking.NativeFieldInfoPtr_OnLobbyCreated, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Result, Lobby>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamMatchmaking.NativeFieldInfoPtr_OnLobbyCreated, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000977 RID: 2423 RVA: 0x00046EA0 File Offset: 0x000450A0
		// (set) Token: 0x06000978 RID: 2424 RVA: 0x000028BE File Offset: 0x00000ABE
		public unsafe static Action<Lobby, uint, ushort, SteamId> OnLobbyGameCreated
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamMatchmaking.NativeFieldInfoPtr_OnLobbyGameCreated, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Lobby, uint, ushort, SteamId>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamMatchmaking.NativeFieldInfoPtr_OnLobbyGameCreated, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000979 RID: 2425 RVA: 0x00046EC8 File Offset: 0x000450C8
		// (set) Token: 0x0600097A RID: 2426 RVA: 0x000028D0 File Offset: 0x00000AD0
		public unsafe static Action<Lobby> OnLobbyDataChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamMatchmaking.NativeFieldInfoPtr_OnLobbyDataChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Lobby>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamMatchmaking.NativeFieldInfoPtr_OnLobbyDataChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600097B RID: 2427 RVA: 0x00046EF0 File Offset: 0x000450F0
		// (set) Token: 0x0600097C RID: 2428 RVA: 0x000028E2 File Offset: 0x00000AE2
		public unsafe static Action<Lobby, Friend> OnLobbyMemberDataChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamMatchmaking.NativeFieldInfoPtr_OnLobbyMemberDataChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Lobby, Friend>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamMatchmaking.NativeFieldInfoPtr_OnLobbyMemberDataChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600097D RID: 2429 RVA: 0x00046F18 File Offset: 0x00045118
		// (set) Token: 0x0600097E RID: 2430 RVA: 0x000028F4 File Offset: 0x00000AF4
		public unsafe static Action<Lobby, Friend> OnLobbyMemberJoined
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamMatchmaking.NativeFieldInfoPtr_OnLobbyMemberJoined, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Lobby, Friend>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamMatchmaking.NativeFieldInfoPtr_OnLobbyMemberJoined, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600097F RID: 2431 RVA: 0x00046F40 File Offset: 0x00045140
		// (set) Token: 0x06000980 RID: 2432 RVA: 0x00002906 File Offset: 0x00000B06
		public unsafe static Action<Lobby, Friend> OnLobbyMemberLeave
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamMatchmaking.NativeFieldInfoPtr_OnLobbyMemberLeave, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Lobby, Friend>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamMatchmaking.NativeFieldInfoPtr_OnLobbyMemberLeave, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000981 RID: 2433 RVA: 0x00046F68 File Offset: 0x00045168
		// (set) Token: 0x06000982 RID: 2434 RVA: 0x00002918 File Offset: 0x00000B18
		public unsafe static Action<Lobby, Friend> OnLobbyMemberDisconnected
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamMatchmaking.NativeFieldInfoPtr_OnLobbyMemberDisconnected, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Lobby, Friend>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamMatchmaking.NativeFieldInfoPtr_OnLobbyMemberDisconnected, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000983 RID: 2435 RVA: 0x00046F90 File Offset: 0x00045190
		// (set) Token: 0x06000984 RID: 2436 RVA: 0x0000292A File Offset: 0x00000B2A
		public unsafe static Action<Lobby, Friend, Friend> OnLobbyMemberKicked
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamMatchmaking.NativeFieldInfoPtr_OnLobbyMemberKicked, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Lobby, Friend, Friend>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamMatchmaking.NativeFieldInfoPtr_OnLobbyMemberKicked, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000985 RID: 2437 RVA: 0x00046FB8 File Offset: 0x000451B8
		// (set) Token: 0x06000986 RID: 2438 RVA: 0x0000293C File Offset: 0x00000B3C
		public unsafe static Action<Lobby, Friend, Friend> OnLobbyMemberBanned
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamMatchmaking.NativeFieldInfoPtr_OnLobbyMemberBanned, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Lobby, Friend, Friend>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamMatchmaking.NativeFieldInfoPtr_OnLobbyMemberBanned, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000987 RID: 2439 RVA: 0x00046FE0 File Offset: 0x000451E0
		// (set) Token: 0x06000988 RID: 2440 RVA: 0x0000294E File Offset: 0x00000B4E
		public unsafe static Action<Lobby, Friend, string> OnChatMessage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamMatchmaking.NativeFieldInfoPtr_OnChatMessage, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Lobby, Friend, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamMatchmaking.NativeFieldInfoPtr_OnChatMessage, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001054 RID: 4180
		private static readonly IntPtr NativeFieldInfoPtr_OnLobbyInvite;

		// Token: 0x04001055 RID: 4181
		private static readonly IntPtr NativeFieldInfoPtr_OnLobbyEntered;

		// Token: 0x04001056 RID: 4182
		private static readonly IntPtr NativeFieldInfoPtr_OnLobbyCreated;

		// Token: 0x04001057 RID: 4183
		private static readonly IntPtr NativeFieldInfoPtr_OnLobbyGameCreated;

		// Token: 0x04001058 RID: 4184
		private static readonly IntPtr NativeFieldInfoPtr_OnLobbyDataChanged;

		// Token: 0x04001059 RID: 4185
		private static readonly IntPtr NativeFieldInfoPtr_OnLobbyMemberDataChanged;

		// Token: 0x0400105A RID: 4186
		private static readonly IntPtr NativeFieldInfoPtr_OnLobbyMemberJoined;

		// Token: 0x0400105B RID: 4187
		private static readonly IntPtr NativeFieldInfoPtr_OnLobbyMemberLeave;

		// Token: 0x0400105C RID: 4188
		private static readonly IntPtr NativeFieldInfoPtr_OnLobbyMemberDisconnected;

		// Token: 0x0400105D RID: 4189
		private static readonly IntPtr NativeFieldInfoPtr_OnLobbyMemberKicked;

		// Token: 0x0400105E RID: 4190
		private static readonly IntPtr NativeFieldInfoPtr_OnLobbyMemberBanned;

		// Token: 0x0400105F RID: 4191
		private static readonly IntPtr NativeFieldInfoPtr_OnChatMessage;

		// Token: 0x04001060 RID: 4192
		private static readonly IntPtr NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamMatchmaking_0;

		// Token: 0x04001061 RID: 4193
		private static readonly IntPtr NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0;

		// Token: 0x04001062 RID: 4194
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxLobbyKeyLength_Internal_Static_get_Int32_0;

		// Token: 0x04001063 RID: 4195
		private static readonly IntPtr NativeMethodInfoPtr_InstallEvents_Internal_Static_Void_0;

		// Token: 0x04001064 RID: 4196
		private static readonly IntPtr NativeMethodInfoPtr_OnLobbyChatMessageRecievedAPI_Private_Static_Void_LobbyChatMsg_t_0;

		// Token: 0x04001065 RID: 4197
		private static readonly IntPtr NativeMethodInfoPtr_add_OnLobbyInvite_Public_Static_add_Void_Action_2_Friend_Lobby_0;

		// Token: 0x04001066 RID: 4198
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnLobbyInvite_Public_Static_rem_Void_Action_2_Friend_Lobby_0;

		// Token: 0x04001067 RID: 4199
		private static readonly IntPtr NativeMethodInfoPtr_add_OnLobbyEntered_Public_Static_add_Void_Action_1_Lobby_0;

		// Token: 0x04001068 RID: 4200
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnLobbyEntered_Public_Static_rem_Void_Action_1_Lobby_0;

		// Token: 0x04001069 RID: 4201
		private static readonly IntPtr NativeMethodInfoPtr_add_OnLobbyCreated_Public_Static_add_Void_Action_2_Result_Lobby_0;

		// Token: 0x0400106A RID: 4202
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnLobbyCreated_Public_Static_rem_Void_Action_2_Result_Lobby_0;

		// Token: 0x0400106B RID: 4203
		private static readonly IntPtr NativeMethodInfoPtr_add_OnLobbyGameCreated_Public_Static_add_Void_Action_4_Lobby_UInt32_UInt16_SteamId_0;

		// Token: 0x0400106C RID: 4204
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnLobbyGameCreated_Public_Static_rem_Void_Action_4_Lobby_UInt32_UInt16_SteamId_0;

		// Token: 0x0400106D RID: 4205
		private static readonly IntPtr NativeMethodInfoPtr_add_OnLobbyDataChanged_Public_Static_add_Void_Action_1_Lobby_0;

		// Token: 0x0400106E RID: 4206
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnLobbyDataChanged_Public_Static_rem_Void_Action_1_Lobby_0;

		// Token: 0x0400106F RID: 4207
		private static readonly IntPtr NativeMethodInfoPtr_add_OnLobbyMemberDataChanged_Public_Static_add_Void_Action_2_Lobby_Friend_0;

		// Token: 0x04001070 RID: 4208
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnLobbyMemberDataChanged_Public_Static_rem_Void_Action_2_Lobby_Friend_0;

		// Token: 0x04001071 RID: 4209
		private static readonly IntPtr NativeMethodInfoPtr_add_OnLobbyMemberJoined_Public_Static_add_Void_Action_2_Lobby_Friend_0;

		// Token: 0x04001072 RID: 4210
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnLobbyMemberJoined_Public_Static_rem_Void_Action_2_Lobby_Friend_0;

		// Token: 0x04001073 RID: 4211
		private static readonly IntPtr NativeMethodInfoPtr_add_OnLobbyMemberLeave_Public_Static_add_Void_Action_2_Lobby_Friend_0;

		// Token: 0x04001074 RID: 4212
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnLobbyMemberLeave_Public_Static_rem_Void_Action_2_Lobby_Friend_0;

		// Token: 0x04001075 RID: 4213
		private static readonly IntPtr NativeMethodInfoPtr_add_OnLobbyMemberDisconnected_Public_Static_add_Void_Action_2_Lobby_Friend_0;

		// Token: 0x04001076 RID: 4214
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnLobbyMemberDisconnected_Public_Static_rem_Void_Action_2_Lobby_Friend_0;

		// Token: 0x04001077 RID: 4215
		private static readonly IntPtr NativeMethodInfoPtr_add_OnLobbyMemberKicked_Public_Static_add_Void_Action_3_Lobby_Friend_Friend_0;

		// Token: 0x04001078 RID: 4216
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnLobbyMemberKicked_Public_Static_rem_Void_Action_3_Lobby_Friend_Friend_0;

		// Token: 0x04001079 RID: 4217
		private static readonly IntPtr NativeMethodInfoPtr_add_OnLobbyMemberBanned_Public_Static_add_Void_Action_3_Lobby_Friend_Friend_0;

		// Token: 0x0400107A RID: 4218
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnLobbyMemberBanned_Public_Static_rem_Void_Action_3_Lobby_Friend_Friend_0;

		// Token: 0x0400107B RID: 4219
		private static readonly IntPtr NativeMethodInfoPtr_add_OnChatMessage_Public_Static_add_Void_Action_3_Lobby_Friend_String_0;

		// Token: 0x0400107C RID: 4220
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnChatMessage_Public_Static_rem_Void_Action_3_Lobby_Friend_String_0;

		// Token: 0x0400107D RID: 4221
		private static readonly IntPtr NativeMethodInfoPtr_get_LobbyList_Public_Static_get_LobbyQuery_0;

		// Token: 0x0400107E RID: 4222
		private static readonly IntPtr NativeMethodInfoPtr_CreateLobbyAsync_Public_Static_Task_1_Nullable_1_Lobby_Int32_0;

		// Token: 0x0400107F RID: 4223
		private static readonly IntPtr NativeMethodInfoPtr_JoinLobbyAsync_Public_Static_Task_1_Nullable_1_Lobby_SteamId_0;

		// Token: 0x04001080 RID: 4224
		private static readonly IntPtr NativeMethodInfoPtr_GetFavoriteServers_Public_Static_IEnumerable_1_ServerInfo_0;

		// Token: 0x04001081 RID: 4225
		private static readonly IntPtr NativeMethodInfoPtr_GetHistoryServers_Public_Static_IEnumerable_1_ServerInfo_0;

		// Token: 0x04001082 RID: 4226
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200023D RID: 573
		[ObfuscatedName("Steamworks.SteamMatchmaking+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001D13 RID: 7443 RVA: 0x00086400 File Offset: 0x00084600
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SteamMatchmaking.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamMatchmaking.__c>.NativeClassPtr);
				SteamMatchmaking.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMatchmaking.__c>.NativeClassPtr, "<>9");
				SteamMatchmaking.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMatchmaking.__c>.NativeClassPtr, "<>9__5_0");
				SteamMatchmaking.__c.NativeFieldInfoPtr___9__5_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMatchmaking.__c>.NativeClassPtr, "<>9__5_1");
				SteamMatchmaking.__c.NativeFieldInfoPtr___9__5_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMatchmaking.__c>.NativeClassPtr, "<>9__5_2");
				SteamMatchmaking.__c.NativeFieldInfoPtr___9__5_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMatchmaking.__c>.NativeClassPtr, "<>9__5_3");
				SteamMatchmaking.__c.NativeFieldInfoPtr___9__5_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMatchmaking.__c>.NativeClassPtr, "<>9__5_4");
				SteamMatchmaking.__c.NativeFieldInfoPtr___9__5_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMatchmaking.__c>.NativeClassPtr, "<>9__5_5");
				SteamMatchmaking.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking.__c>.NativeClassPtr, 100665625);
				SteamMatchmaking.__c.NativeMethodInfoPtr__InstallEvents_b__5_0_Internal_Void_LobbyInvite_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking.__c>.NativeClassPtr, 100665626);
				SteamMatchmaking.__c.NativeMethodInfoPtr__InstallEvents_b__5_1_Internal_Void_LobbyEnter_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking.__c>.NativeClassPtr, 100665627);
				SteamMatchmaking.__c.NativeMethodInfoPtr__InstallEvents_b__5_2_Internal_Void_LobbyCreated_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking.__c>.NativeClassPtr, 100665628);
				SteamMatchmaking.__c.NativeMethodInfoPtr__InstallEvents_b__5_3_Internal_Void_LobbyGameCreated_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking.__c>.NativeClassPtr, 100665629);
				SteamMatchmaking.__c.NativeMethodInfoPtr__InstallEvents_b__5_4_Internal_Void_LobbyDataUpdate_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking.__c>.NativeClassPtr, 100665630);
				SteamMatchmaking.__c.NativeMethodInfoPtr__InstallEvents_b__5_5_Internal_Void_LobbyChatUpdate_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking.__c>.NativeClassPtr, 100665631);
			}

			// Token: 0x06001D14 RID: 7444 RVA: 0x00086544 File Offset: 0x00084744
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamMatchmaking.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D15 RID: 7445 RVA: 0x00086580 File Offset: 0x00084780
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940015, XrefRangeEnd = 940020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__5_0(LobbyInvite_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.__c.NativeMethodInfoPtr__InstallEvents_b__5_0_Internal_Void_LobbyInvite_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D16 RID: 7446 RVA: 0x000865C0 File Offset: 0x000847C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940020, XrefRangeEnd = 940024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__5_1(LobbyEnter_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.__c.NativeMethodInfoPtr__InstallEvents_b__5_1_Internal_Void_LobbyEnter_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D17 RID: 7447 RVA: 0x00086600 File Offset: 0x00084800
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940024, XrefRangeEnd = 940028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__5_2(LobbyCreated_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.__c.NativeMethodInfoPtr__InstallEvents_b__5_2_Internal_Void_LobbyCreated_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D18 RID: 7448 RVA: 0x00086640 File Offset: 0x00084840
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940028, XrefRangeEnd = 940033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__5_3(LobbyGameCreated_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.__c.NativeMethodInfoPtr__InstallEvents_b__5_3_Internal_Void_LobbyGameCreated_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D19 RID: 7449 RVA: 0x00086680 File Offset: 0x00084880
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940033, XrefRangeEnd = 940038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__5_4(LobbyDataUpdate_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.__c.NativeMethodInfoPtr__InstallEvents_b__5_4_Internal_Void_LobbyDataUpdate_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D1A RID: 7450 RVA: 0x000866C0 File Offset: 0x000848C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940038, XrefRangeEnd = 940061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__5_5(LobbyChatUpdate_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.__c.NativeMethodInfoPtr__InstallEvents_b__5_5_Internal_Void_LobbyChatUpdate_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D1B RID: 7451 RVA: 0x0000A3D0 File Offset: 0x000085D0
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700074D RID: 1869
			// (get) Token: 0x06001D1C RID: 7452 RVA: 0x00086700 File Offset: 0x00084900
			// (set) Token: 0x06001D1D RID: 7453 RVA: 0x0000A3D9 File Offset: 0x000085D9
			public unsafe static SteamMatchmaking.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamMatchmaking.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SteamMatchmaking.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamMatchmaking.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700074E RID: 1870
			// (get) Token: 0x06001D1E RID: 7454 RVA: 0x00086728 File Offset: 0x00084928
			// (set) Token: 0x06001D1F RID: 7455 RVA: 0x0000A3EB File Offset: 0x000085EB
			public unsafe static Action<LobbyInvite_t> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamMatchmaking.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<LobbyInvite_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamMatchmaking.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700074F RID: 1871
			// (get) Token: 0x06001D20 RID: 7456 RVA: 0x00086750 File Offset: 0x00084950
			// (set) Token: 0x06001D21 RID: 7457 RVA: 0x0000A3FD File Offset: 0x000085FD
			public unsafe static Action<LobbyEnter_t> __9__5_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamMatchmaking.__c.NativeFieldInfoPtr___9__5_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<LobbyEnter_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamMatchmaking.__c.NativeFieldInfoPtr___9__5_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000750 RID: 1872
			// (get) Token: 0x06001D22 RID: 7458 RVA: 0x00086778 File Offset: 0x00084978
			// (set) Token: 0x06001D23 RID: 7459 RVA: 0x0000A40F File Offset: 0x0000860F
			public unsafe static Action<LobbyCreated_t> __9__5_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamMatchmaking.__c.NativeFieldInfoPtr___9__5_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<LobbyCreated_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamMatchmaking.__c.NativeFieldInfoPtr___9__5_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000751 RID: 1873
			// (get) Token: 0x06001D24 RID: 7460 RVA: 0x000867A0 File Offset: 0x000849A0
			// (set) Token: 0x06001D25 RID: 7461 RVA: 0x0000A421 File Offset: 0x00008621
			public unsafe static Action<LobbyGameCreated_t> __9__5_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamMatchmaking.__c.NativeFieldInfoPtr___9__5_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<LobbyGameCreated_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamMatchmaking.__c.NativeFieldInfoPtr___9__5_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000752 RID: 1874
			// (get) Token: 0x06001D26 RID: 7462 RVA: 0x000867C8 File Offset: 0x000849C8
			// (set) Token: 0x06001D27 RID: 7463 RVA: 0x0000A433 File Offset: 0x00008633
			public unsafe static Action<LobbyDataUpdate_t> __9__5_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamMatchmaking.__c.NativeFieldInfoPtr___9__5_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<LobbyDataUpdate_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamMatchmaking.__c.NativeFieldInfoPtr___9__5_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000753 RID: 1875
			// (get) Token: 0x06001D28 RID: 7464 RVA: 0x000867F0 File Offset: 0x000849F0
			// (set) Token: 0x06001D29 RID: 7465 RVA: 0x0000A445 File Offset: 0x00008645
			public unsafe static Action<LobbyChatUpdate_t> __9__5_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamMatchmaking.__c.NativeFieldInfoPtr___9__5_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<LobbyChatUpdate_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamMatchmaking.__c.NativeFieldInfoPtr___9__5_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040020F6 RID: 8438
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040020F7 RID: 8439
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x040020F8 RID: 8440
			private static readonly IntPtr NativeFieldInfoPtr___9__5_1;

			// Token: 0x040020F9 RID: 8441
			private static readonly IntPtr NativeFieldInfoPtr___9__5_2;

			// Token: 0x040020FA RID: 8442
			private static readonly IntPtr NativeFieldInfoPtr___9__5_3;

			// Token: 0x040020FB RID: 8443
			private static readonly IntPtr NativeFieldInfoPtr___9__5_4;

			// Token: 0x040020FC RID: 8444
			private static readonly IntPtr NativeFieldInfoPtr___9__5_5;

			// Token: 0x040020FD RID: 8445
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040020FE RID: 8446
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__5_0_Internal_Void_LobbyInvite_t_0;

			// Token: 0x040020FF RID: 8447
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__5_1_Internal_Void_LobbyEnter_t_0;

			// Token: 0x04002100 RID: 8448
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__5_2_Internal_Void_LobbyCreated_t_0;

			// Token: 0x04002101 RID: 8449
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__5_3_Internal_Void_LobbyGameCreated_t_0;

			// Token: 0x04002102 RID: 8450
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__5_4_Internal_Void_LobbyDataUpdate_t_0;

			// Token: 0x04002103 RID: 8451
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__5_5_Internal_Void_LobbyChatUpdate_t_0;
		}

		// Token: 0x0200023E RID: 574
		[ObfuscatedName("Steamworks.SteamMatchmaking+<CreateLobbyAsync>d__45")]
		public sealed class _CreateLobbyAsync_d__45 : ValueType
		{
			// Token: 0x06001D2A RID: 7466 RVA: 0x00086818 File Offset: 0x00084A18
			// Note: this type is marked as 'beforefieldinit'.
			static _CreateLobbyAsync_d__45()
			{
				Il2CppClassPointerStore<SteamMatchmaking._CreateLobbyAsync_d__45>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, "<CreateLobbyAsync>d__45");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamMatchmaking._CreateLobbyAsync_d__45>.NativeClassPtr);
				SteamMatchmaking._CreateLobbyAsync_d__45.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMatchmaking._CreateLobbyAsync_d__45>.NativeClassPtr, "<>1__state");
				SteamMatchmaking._CreateLobbyAsync_d__45.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMatchmaking._CreateLobbyAsync_d__45>.NativeClassPtr, "<>t__builder");
				SteamMatchmaking._CreateLobbyAsync_d__45.NativeFieldInfoPtr_maxMembers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMatchmaking._CreateLobbyAsync_d__45>.NativeClassPtr, "maxMembers");
				SteamMatchmaking._CreateLobbyAsync_d__45.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMatchmaking._CreateLobbyAsync_d__45>.NativeClassPtr, "<>u__1");
				SteamMatchmaking._CreateLobbyAsync_d__45.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking._CreateLobbyAsync_d__45>.NativeClassPtr, 100665632);
				SteamMatchmaking._CreateLobbyAsync_d__45.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking._CreateLobbyAsync_d__45>.NativeClassPtr, 100665633);
			}

			// Token: 0x06001D2B RID: 7467 RVA: 0x000868BC File Offset: 0x00084ABC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940061, XrefRangeEnd = 940091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking._CreateLobbyAsync_d__45.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D2C RID: 7468 RVA: 0x000868F4 File Offset: 0x00084AF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940091, XrefRangeEnd = 940097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking._CreateLobbyAsync_d__45.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D2D RID: 7469 RVA: 0x0000A457 File Offset: 0x00008657
			public _CreateLobbyAsync_d__45(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001D2E RID: 7470 RVA: 0x0000A460 File Offset: 0x00008660
			public _CreateLobbyAsync_d__45()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamMatchmaking._CreateLobbyAsync_d__45>.NativeClassPtr))
			{
			}

			// Token: 0x17000754 RID: 1876
			// (get) Token: 0x06001D2F RID: 7471 RVA: 0x0008693C File Offset: 0x00084B3C
			// (set) Token: 0x06001D30 RID: 7472 RVA: 0x0000A472 File Offset: 0x00008672
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamMatchmaking._CreateLobbyAsync_d__45.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamMatchmaking._CreateLobbyAsync_d__45.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000755 RID: 1877
			// (get) Token: 0x06001D31 RID: 7473 RVA: 0x00086964 File Offset: 0x00084B64
			// (set) Token: 0x06001D32 RID: 7474 RVA: 0x0000A48D File Offset: 0x0000868D
			public AsyncTaskMethodBuilder<Nullable<Lobby>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamMatchmaking._CreateLobbyAsync_d__45.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Nullable<Lobby>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<Lobby>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamMatchmaking._CreateLobbyAsync_d__45.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<Lobby>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000756 RID: 1878
			// (get) Token: 0x06001D33 RID: 7475 RVA: 0x00086994 File Offset: 0x00084B94
			// (set) Token: 0x06001D34 RID: 7476 RVA: 0x0000A4BB File Offset: 0x000086BB
			public unsafe int maxMembers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamMatchmaking._CreateLobbyAsync_d__45.NativeFieldInfoPtr_maxMembers);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamMatchmaking._CreateLobbyAsync_d__45.NativeFieldInfoPtr_maxMembers)) = value;
				}
			}

			// Token: 0x17000757 RID: 1879
			// (get) Token: 0x06001D35 RID: 7477 RVA: 0x000869BC File Offset: 0x00084BBC
			// (set) Token: 0x06001D36 RID: 7478 RVA: 0x0000A4D6 File Offset: 0x000086D6
			public CallResult<LobbyCreated_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamMatchmaking._CreateLobbyAsync_d__45.NativeFieldInfoPtr___u__1);
					return new CallResult<LobbyCreated_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<LobbyCreated_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamMatchmaking._CreateLobbyAsync_d__45.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<LobbyCreated_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002104 RID: 8452
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002105 RID: 8453
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002106 RID: 8454
			private static readonly IntPtr NativeFieldInfoPtr_maxMembers;

			// Token: 0x04002107 RID: 8455
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002108 RID: 8456
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002109 RID: 8457
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200023F RID: 575
		[ObfuscatedName("Steamworks.SteamMatchmaking+<GetFavoriteServers>d__47")]
		public sealed class _GetFavoriteServers_d__47 : Object
		{
			// Token: 0x06001D37 RID: 7479 RVA: 0x000869EC File Offset: 0x00084BEC
			// Note: this type is marked as 'beforefieldinit'.
			static _GetFavoriteServers_d__47()
			{
				Il2CppClassPointerStore<SteamMatchmaking._GetFavoriteServers_d__47>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, "<GetFavoriteServers>d__47");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamMatchmaking._GetFavoriteServers_d__47>.NativeClassPtr);
				SteamMatchmaking._GetFavoriteServers_d__47.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMatchmaking._GetFavoriteServers_d__47>.NativeClassPtr, "<>1__state");
				SteamMatchmaking._GetFavoriteServers_d__47.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMatchmaking._GetFavoriteServers_d__47>.NativeClassPtr, "<>2__current");
				SteamMatchmaking._GetFavoriteServers_d__47.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMatchmaking._GetFavoriteServers_d__47>.NativeClassPtr, "<>l__initialThreadId");
				SteamMatchmaking._GetFavoriteServers_d__47.NativeFieldInfoPtr__count_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMatchmaking._GetFavoriteServers_d__47>.NativeClassPtr, "<count>5__2");
				SteamMatchmaking._GetFavoriteServers_d__47.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMatchmaking._GetFavoriteServers_d__47>.NativeClassPtr, "<i>5__3");
				SteamMatchmaking._GetFavoriteServers_d__47.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking._GetFavoriteServers_d__47>.NativeClassPtr, 100665634);
				SteamMatchmaking._GetFavoriteServers_d__47.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking._GetFavoriteServers_d__47>.NativeClassPtr, 100665635);
				SteamMatchmaking._GetFavoriteServers_d__47.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking._GetFavoriteServers_d__47>.NativeClassPtr, 100665636);
				SteamMatchmaking._GetFavoriteServers_d__47.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Steamworks_Data_ServerInfo__get_Current_Private_Virtual_Final_New_get_ServerInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking._GetFavoriteServers_d__47>.NativeClassPtr, 100665637);
				SteamMatchmaking._GetFavoriteServers_d__47.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking._GetFavoriteServers_d__47>.NativeClassPtr, 100665638);
				SteamMatchmaking._GetFavoriteServers_d__47.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking._GetFavoriteServers_d__47>.NativeClassPtr, 100665639);
				SteamMatchmaking._GetFavoriteServers_d__47.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Steamworks_Data_ServerInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ServerInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking._GetFavoriteServers_d__47>.NativeClassPtr, 100665640);
				SteamMatchmaking._GetFavoriteServers_d__47.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking._GetFavoriteServers_d__47>.NativeClassPtr, 100665641);
			}

			// Token: 0x06001D38 RID: 7480 RVA: 0x00086B1C File Offset: 0x00084D1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940097, XrefRangeEnd = 940099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetFavoriteServers_d__47(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamMatchmaking._GetFavoriteServers_d__47>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking._GetFavoriteServers_d__47.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D39 RID: 7481 RVA: 0x00086B64 File Offset: 0x00084D64
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking._GetFavoriteServers_d__47.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D3A RID: 7482 RVA: 0x00086B98 File Offset: 0x00084D98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940099, XrefRangeEnd = 940106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking._GetFavoriteServers_d__47.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700075D RID: 1885
			// (get) Token: 0x06001D3B RID: 7483 RVA: 0x00086BD4 File Offset: 0x00084DD4
			public unsafe ServerInfo System.Collections.Generic.IEnumerator<Steamworks.Data.ServerInfo>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking._GetFavoriteServers_d__47.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Steamworks_Data_ServerInfo__get_Current_Private_Virtual_Final_New_get_ServerInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ServerInfo(intPtr);
				}
			}

			// Token: 0x06001D3C RID: 7484 RVA: 0x00086C0C File Offset: 0x00084E0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940106, XrefRangeEnd = 940111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking._GetFavoriteServers_d__47.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700075E RID: 1886
			// (get) Token: 0x06001D3D RID: 7485 RVA: 0x00086C40 File Offset: 0x00084E40
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940111, XrefRangeEnd = 940114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking._GetFavoriteServers_d__47.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001D3E RID: 7486 RVA: 0x00086C80 File Offset: 0x00084E80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940114, XrefRangeEnd = 940116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ServerInfo> System_Collections_Generic_IEnumerable_Steamworks_Data_ServerInfo__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking._GetFavoriteServers_d__47.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Steamworks_Data_ServerInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ServerInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ServerInfo>>(intPtr3) : null;
			}

			// Token: 0x06001D3F RID: 7487 RVA: 0x00086CC0 File Offset: 0x00084EC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking._GetFavoriteServers_d__47.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001D40 RID: 7488 RVA: 0x0000A504 File Offset: 0x00008704
			public _GetFavoriteServers_d__47(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000758 RID: 1880
			// (get) Token: 0x06001D41 RID: 7489 RVA: 0x00086D00 File Offset: 0x00084F00
			// (set) Token: 0x06001D42 RID: 7490 RVA: 0x0000A50D File Offset: 0x0000870D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamMatchmaking._GetFavoriteServers_d__47.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamMatchmaking._GetFavoriteServers_d__47.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000759 RID: 1881
			// (get) Token: 0x06001D43 RID: 7491 RVA: 0x00086D28 File Offset: 0x00084F28
			// (set) Token: 0x06001D44 RID: 7492 RVA: 0x0000A528 File Offset: 0x00008728
			public ServerInfo __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamMatchmaking._GetFavoriteServers_d__47.NativeFieldInfoPtr___2__current);
					return new ServerInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamMatchmaking._GetFavoriteServers_d__47.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700075A RID: 1882
			// (get) Token: 0x06001D45 RID: 7493 RVA: 0x00086D58 File Offset: 0x00084F58
			// (set) Token: 0x06001D46 RID: 7494 RVA: 0x0000A556 File Offset: 0x00008756
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamMatchmaking._GetFavoriteServers_d__47.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamMatchmaking._GetFavoriteServers_d__47.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700075B RID: 1883
			// (get) Token: 0x06001D47 RID: 7495 RVA: 0x00086D80 File Offset: 0x00084F80
			// (set) Token: 0x06001D48 RID: 7496 RVA: 0x0000A571 File Offset: 0x00008771
			public unsafe int _count_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamMatchmaking._GetFavoriteServers_d__47.NativeFieldInfoPtr__count_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamMatchmaking._GetFavoriteServers_d__47.NativeFieldInfoPtr__count_5__2)) = value;
				}
			}

			// Token: 0x1700075C RID: 1884
			// (get) Token: 0x06001D49 RID: 7497 RVA: 0x00086DA8 File Offset: 0x00084FA8
			// (set) Token: 0x06001D4A RID: 7498 RVA: 0x0000A58C File Offset: 0x0000878C
			public unsafe int _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamMatchmaking._GetFavoriteServers_d__47.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamMatchmaking._GetFavoriteServers_d__47.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x0400210A RID: 8458
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400210B RID: 8459
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400210C RID: 8460
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400210D RID: 8461
			private static readonly IntPtr NativeFieldInfoPtr__count_5__2;

			// Token: 0x0400210E RID: 8462
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x0400210F RID: 8463
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002110 RID: 8464
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002111 RID: 8465
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002112 RID: 8466
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Steamworks_Data_ServerInfo__get_Current_Private_Virtual_Final_New_get_ServerInfo_0;

			// Token: 0x04002113 RID: 8467
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002114 RID: 8468
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002115 RID: 8469
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Steamworks_Data_ServerInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ServerInfo_0;

			// Token: 0x04002116 RID: 8470
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000240 RID: 576
		[ObfuscatedName("Steamworks.SteamMatchmaking+<GetHistoryServers>d__48")]
		public sealed class _GetHistoryServers_d__48 : Object
		{
			// Token: 0x06001D4B RID: 7499 RVA: 0x00086DD0 File Offset: 0x00084FD0
			// Note: this type is marked as 'beforefieldinit'.
			static _GetHistoryServers_d__48()
			{
				Il2CppClassPointerStore<SteamMatchmaking._GetHistoryServers_d__48>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, "<GetHistoryServers>d__48");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamMatchmaking._GetHistoryServers_d__48>.NativeClassPtr);
				SteamMatchmaking._GetHistoryServers_d__48.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMatchmaking._GetHistoryServers_d__48>.NativeClassPtr, "<>1__state");
				SteamMatchmaking._GetHistoryServers_d__48.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMatchmaking._GetHistoryServers_d__48>.NativeClassPtr, "<>2__current");
				SteamMatchmaking._GetHistoryServers_d__48.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMatchmaking._GetHistoryServers_d__48>.NativeClassPtr, "<>l__initialThreadId");
				SteamMatchmaking._GetHistoryServers_d__48.NativeFieldInfoPtr__count_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMatchmaking._GetHistoryServers_d__48>.NativeClassPtr, "<count>5__2");
				SteamMatchmaking._GetHistoryServers_d__48.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMatchmaking._GetHistoryServers_d__48>.NativeClassPtr, "<i>5__3");
				SteamMatchmaking._GetHistoryServers_d__48.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking._GetHistoryServers_d__48>.NativeClassPtr, 100665642);
				SteamMatchmaking._GetHistoryServers_d__48.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking._GetHistoryServers_d__48>.NativeClassPtr, 100665643);
				SteamMatchmaking._GetHistoryServers_d__48.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking._GetHistoryServers_d__48>.NativeClassPtr, 100665644);
				SteamMatchmaking._GetHistoryServers_d__48.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Steamworks_Data_ServerInfo__get_Current_Private_Virtual_Final_New_get_ServerInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking._GetHistoryServers_d__48>.NativeClassPtr, 100665645);
				SteamMatchmaking._GetHistoryServers_d__48.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking._GetHistoryServers_d__48>.NativeClassPtr, 100665646);
				SteamMatchmaking._GetHistoryServers_d__48.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking._GetHistoryServers_d__48>.NativeClassPtr, 100665647);
				SteamMatchmaking._GetHistoryServers_d__48.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Steamworks_Data_ServerInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ServerInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking._GetHistoryServers_d__48>.NativeClassPtr, 100665648);
				SteamMatchmaking._GetHistoryServers_d__48.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking._GetHistoryServers_d__48>.NativeClassPtr, 100665649);
			}

			// Token: 0x06001D4C RID: 7500 RVA: 0x00086F00 File Offset: 0x00085100
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetHistoryServers_d__48(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamMatchmaking._GetHistoryServers_d__48>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking._GetHistoryServers_d__48.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D4D RID: 7501 RVA: 0x00086F48 File Offset: 0x00085148
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking._GetHistoryServers_d__48.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D4E RID: 7502 RVA: 0x00086F7C File Offset: 0x0008517C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940116, XrefRangeEnd = 940123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking._GetHistoryServers_d__48.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000764 RID: 1892
			// (get) Token: 0x06001D4F RID: 7503 RVA: 0x00086FB8 File Offset: 0x000851B8
			public unsafe ServerInfo System.Collections.Generic.IEnumerator<Steamworks.Data.ServerInfo>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking._GetHistoryServers_d__48.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Steamworks_Data_ServerInfo__get_Current_Private_Virtual_Final_New_get_ServerInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ServerInfo(intPtr);
				}
			}

			// Token: 0x06001D50 RID: 7504 RVA: 0x00086FF0 File Offset: 0x000851F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940123, XrefRangeEnd = 940128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking._GetHistoryServers_d__48.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000765 RID: 1893
			// (get) Token: 0x06001D51 RID: 7505 RVA: 0x00087024 File Offset: 0x00085224
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940128, XrefRangeEnd = 940131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking._GetHistoryServers_d__48.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001D52 RID: 7506 RVA: 0x00087064 File Offset: 0x00085264
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940131, XrefRangeEnd = 940133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ServerInfo> System_Collections_Generic_IEnumerable_Steamworks_Data_ServerInfo__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking._GetHistoryServers_d__48.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Steamworks_Data_ServerInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ServerInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ServerInfo>>(intPtr3) : null;
			}

			// Token: 0x06001D53 RID: 7507 RVA: 0x000870A4 File Offset: 0x000852A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking._GetHistoryServers_d__48.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001D54 RID: 7508 RVA: 0x0000A5A7 File Offset: 0x000087A7
			public _GetHistoryServers_d__48(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700075F RID: 1887
			// (get) Token: 0x06001D55 RID: 7509 RVA: 0x000870E4 File Offset: 0x000852E4
			// (set) Token: 0x06001D56 RID: 7510 RVA: 0x0000A5B0 File Offset: 0x000087B0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamMatchmaking._GetHistoryServers_d__48.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamMatchmaking._GetHistoryServers_d__48.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000760 RID: 1888
			// (get) Token: 0x06001D57 RID: 7511 RVA: 0x0008710C File Offset: 0x0008530C
			// (set) Token: 0x06001D58 RID: 7512 RVA: 0x0000A5CB File Offset: 0x000087CB
			public ServerInfo __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamMatchmaking._GetHistoryServers_d__48.NativeFieldInfoPtr___2__current);
					return new ServerInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamMatchmaking._GetHistoryServers_d__48.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServerInfo>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000761 RID: 1889
			// (get) Token: 0x06001D59 RID: 7513 RVA: 0x0008713C File Offset: 0x0008533C
			// (set) Token: 0x06001D5A RID: 7514 RVA: 0x0000A5F9 File Offset: 0x000087F9
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamMatchmaking._GetHistoryServers_d__48.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamMatchmaking._GetHistoryServers_d__48.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000762 RID: 1890
			// (get) Token: 0x06001D5B RID: 7515 RVA: 0x00087164 File Offset: 0x00085364
			// (set) Token: 0x06001D5C RID: 7516 RVA: 0x0000A614 File Offset: 0x00008814
			public unsafe int _count_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamMatchmaking._GetHistoryServers_d__48.NativeFieldInfoPtr__count_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamMatchmaking._GetHistoryServers_d__48.NativeFieldInfoPtr__count_5__2)) = value;
				}
			}

			// Token: 0x17000763 RID: 1891
			// (get) Token: 0x06001D5D RID: 7517 RVA: 0x0008718C File Offset: 0x0008538C
			// (set) Token: 0x06001D5E RID: 7518 RVA: 0x0000A62F File Offset: 0x0000882F
			public unsafe int _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamMatchmaking._GetHistoryServers_d__48.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamMatchmaking._GetHistoryServers_d__48.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x04002117 RID: 8471
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002118 RID: 8472
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002119 RID: 8473
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400211A RID: 8474
			private static readonly IntPtr NativeFieldInfoPtr__count_5__2;

			// Token: 0x0400211B RID: 8475
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x0400211C RID: 8476
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400211D RID: 8477
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400211E RID: 8478
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400211F RID: 8479
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Steamworks_Data_ServerInfo__get_Current_Private_Virtual_Final_New_get_ServerInfo_0;

			// Token: 0x04002120 RID: 8480
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002121 RID: 8481
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002122 RID: 8482
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Steamworks_Data_ServerInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ServerInfo_0;

			// Token: 0x04002123 RID: 8483
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000241 RID: 577
		[ObfuscatedName("Steamworks.SteamMatchmaking+<JoinLobbyAsync>d__46")]
		public sealed class _JoinLobbyAsync_d__46 : ValueType
		{
			// Token: 0x06001D5F RID: 7519 RVA: 0x000871B4 File Offset: 0x000853B4
			// Note: this type is marked as 'beforefieldinit'.
			static _JoinLobbyAsync_d__46()
			{
				Il2CppClassPointerStore<SteamMatchmaking._JoinLobbyAsync_d__46>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, "<JoinLobbyAsync>d__46");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamMatchmaking._JoinLobbyAsync_d__46>.NativeClassPtr);
				SteamMatchmaking._JoinLobbyAsync_d__46.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMatchmaking._JoinLobbyAsync_d__46>.NativeClassPtr, "<>1__state");
				SteamMatchmaking._JoinLobbyAsync_d__46.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMatchmaking._JoinLobbyAsync_d__46>.NativeClassPtr, "<>t__builder");
				SteamMatchmaking._JoinLobbyAsync_d__46.NativeFieldInfoPtr_lobbyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMatchmaking._JoinLobbyAsync_d__46>.NativeClassPtr, "lobbyId");
				SteamMatchmaking._JoinLobbyAsync_d__46.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMatchmaking._JoinLobbyAsync_d__46>.NativeClassPtr, "<>u__1");
				SteamMatchmaking._JoinLobbyAsync_d__46.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking._JoinLobbyAsync_d__46>.NativeClassPtr, 100665650);
				SteamMatchmaking._JoinLobbyAsync_d__46.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking._JoinLobbyAsync_d__46>.NativeClassPtr, 100665651);
			}

			// Token: 0x06001D60 RID: 7520 RVA: 0x00087258 File Offset: 0x00085458
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940133, XrefRangeEnd = 940161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking._JoinLobbyAsync_d__46.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D61 RID: 7521 RVA: 0x00087290 File Offset: 0x00085490
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940161, XrefRangeEnd = 940167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking._JoinLobbyAsync_d__46.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D62 RID: 7522 RVA: 0x0000A64A File Offset: 0x0000884A
			public _JoinLobbyAsync_d__46(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001D63 RID: 7523 RVA: 0x0000A653 File Offset: 0x00008853
			public _JoinLobbyAsync_d__46()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamMatchmaking._JoinLobbyAsync_d__46>.NativeClassPtr))
			{
			}

			// Token: 0x17000766 RID: 1894
			// (get) Token: 0x06001D64 RID: 7524 RVA: 0x000872D8 File Offset: 0x000854D8
			// (set) Token: 0x06001D65 RID: 7525 RVA: 0x0000A665 File Offset: 0x00008865
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamMatchmaking._JoinLobbyAsync_d__46.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamMatchmaking._JoinLobbyAsync_d__46.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000767 RID: 1895
			// (get) Token: 0x06001D66 RID: 7526 RVA: 0x00087300 File Offset: 0x00085500
			// (set) Token: 0x06001D67 RID: 7527 RVA: 0x0000A680 File Offset: 0x00008880
			public AsyncTaskMethodBuilder<Nullable<Lobby>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamMatchmaking._JoinLobbyAsync_d__46.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Nullable<Lobby>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<Lobby>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamMatchmaking._JoinLobbyAsync_d__46.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<Lobby>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000768 RID: 1896
			// (get) Token: 0x06001D68 RID: 7528 RVA: 0x00087330 File Offset: 0x00085530
			// (set) Token: 0x06001D69 RID: 7529 RVA: 0x0000A6AE File Offset: 0x000088AE
			public unsafe SteamId lobbyId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamMatchmaking._JoinLobbyAsync_d__46.NativeFieldInfoPtr_lobbyId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamMatchmaking._JoinLobbyAsync_d__46.NativeFieldInfoPtr_lobbyId)) = value;
				}
			}

			// Token: 0x17000769 RID: 1897
			// (get) Token: 0x06001D6A RID: 7530 RVA: 0x00087358 File Offset: 0x00085558
			// (set) Token: 0x06001D6B RID: 7531 RVA: 0x0000A6C9 File Offset: 0x000088C9
			public CallResult<LobbyEnter_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamMatchmaking._JoinLobbyAsync_d__46.NativeFieldInfoPtr___u__1);
					return new CallResult<LobbyEnter_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<LobbyEnter_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamMatchmaking._JoinLobbyAsync_d__46.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<LobbyEnter_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002124 RID: 8484
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002125 RID: 8485
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002126 RID: 8486
			private static readonly IntPtr NativeFieldInfoPtr_lobbyId;

			// Token: 0x04002127 RID: 8487
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002128 RID: 8488
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002129 RID: 8489
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
