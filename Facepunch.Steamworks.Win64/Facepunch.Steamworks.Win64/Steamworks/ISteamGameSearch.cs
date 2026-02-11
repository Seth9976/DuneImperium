using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Steamworks
{
	// Token: 0x02000012 RID: 18
	public class ISteamGameSearch : SteamInterface
	{
		// Token: 0x060001D9 RID: 473 RVA: 0x000191E0 File Offset: 0x000173E0
		// Note: this type is marked as 'beforefieldinit'.
		static ISteamGameSearch()
		{
			Il2CppClassPointerStore<ISteamGameSearch>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "ISteamGameSearch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamGameSearch>.NativeClassPtr);
			ISteamGameSearch.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameSearch>.NativeClassPtr, 100663736);
			ISteamGameSearch.NativeMethodInfoPtr_SteamAPI_SteamGameSearch_v001_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameSearch>.NativeClassPtr, 100663737);
			ISteamGameSearch.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameSearch>.NativeClassPtr, 100663738);
			ISteamGameSearch.NativeMethodInfoPtr__AddGameSearchParams_Private_Static_GameSearchErrorCode_t_IntPtr_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameSearch>.NativeClassPtr, 100663739);
			ISteamGameSearch.NativeMethodInfoPtr_AddGameSearchParams_Internal_GameSearchErrorCode_t_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameSearch>.NativeClassPtr, 100663740);
			ISteamGameSearch.NativeMethodInfoPtr__SearchForGameWithLobby_Private_Static_GameSearchErrorCode_t_IntPtr_SteamId_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameSearch>.NativeClassPtr, 100663741);
			ISteamGameSearch.NativeMethodInfoPtr_SearchForGameWithLobby_Internal_GameSearchErrorCode_t_SteamId_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameSearch>.NativeClassPtr, 100663742);
			ISteamGameSearch.NativeMethodInfoPtr__SearchForGameSolo_Private_Static_GameSearchErrorCode_t_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameSearch>.NativeClassPtr, 100663743);
			ISteamGameSearch.NativeMethodInfoPtr_SearchForGameSolo_Internal_GameSearchErrorCode_t_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameSearch>.NativeClassPtr, 100663744);
			ISteamGameSearch.NativeMethodInfoPtr__AcceptGame_Private_Static_GameSearchErrorCode_t_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameSearch>.NativeClassPtr, 100663745);
			ISteamGameSearch.NativeMethodInfoPtr_AcceptGame_Internal_GameSearchErrorCode_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameSearch>.NativeClassPtr, 100663746);
			ISteamGameSearch.NativeMethodInfoPtr__DeclineGame_Private_Static_GameSearchErrorCode_t_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameSearch>.NativeClassPtr, 100663747);
			ISteamGameSearch.NativeMethodInfoPtr_DeclineGame_Internal_GameSearchErrorCode_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameSearch>.NativeClassPtr, 100663748);
			ISteamGameSearch.NativeMethodInfoPtr__RetrieveConnectionDetails_Private_Static_GameSearchErrorCode_t_IntPtr_SteamId_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameSearch>.NativeClassPtr, 100663749);
			ISteamGameSearch.NativeMethodInfoPtr_RetrieveConnectionDetails_Internal_GameSearchErrorCode_t_SteamId_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameSearch>.NativeClassPtr, 100663750);
			ISteamGameSearch.NativeMethodInfoPtr__EndGameSearch_Private_Static_GameSearchErrorCode_t_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameSearch>.NativeClassPtr, 100663751);
			ISteamGameSearch.NativeMethodInfoPtr_EndGameSearch_Internal_GameSearchErrorCode_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameSearch>.NativeClassPtr, 100663752);
			ISteamGameSearch.NativeMethodInfoPtr__SetGameHostParams_Private_Static_GameSearchErrorCode_t_IntPtr_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameSearch>.NativeClassPtr, 100663753);
			ISteamGameSearch.NativeMethodInfoPtr_SetGameHostParams_Internal_GameSearchErrorCode_t_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameSearch>.NativeClassPtr, 100663754);
			ISteamGameSearch.NativeMethodInfoPtr__SetConnectionDetails_Private_Static_GameSearchErrorCode_t_IntPtr_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameSearch>.NativeClassPtr, 100663755);
			ISteamGameSearch.NativeMethodInfoPtr_SetConnectionDetails_Internal_GameSearchErrorCode_t_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameSearch>.NativeClassPtr, 100663756);
			ISteamGameSearch.NativeMethodInfoPtr__RequestPlayersForGame_Private_Static_GameSearchErrorCode_t_IntPtr_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameSearch>.NativeClassPtr, 100663757);
			ISteamGameSearch.NativeMethodInfoPtr_RequestPlayersForGame_Internal_GameSearchErrorCode_t_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameSearch>.NativeClassPtr, 100663758);
			ISteamGameSearch.NativeMethodInfoPtr__HostConfirmGameStart_Private_Static_GameSearchErrorCode_t_IntPtr_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameSearch>.NativeClassPtr, 100663759);
			ISteamGameSearch.NativeMethodInfoPtr_HostConfirmGameStart_Internal_GameSearchErrorCode_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameSearch>.NativeClassPtr, 100663760);
			ISteamGameSearch.NativeMethodInfoPtr__CancelRequestPlayersForGame_Private_Static_GameSearchErrorCode_t_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameSearch>.NativeClassPtr, 100663761);
			ISteamGameSearch.NativeMethodInfoPtr_CancelRequestPlayersForGame_Internal_GameSearchErrorCode_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameSearch>.NativeClassPtr, 100663762);
			ISteamGameSearch.NativeMethodInfoPtr__SubmitPlayerResult_Private_Static_GameSearchErrorCode_t_IntPtr_UInt64_SteamId_PlayerResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameSearch>.NativeClassPtr, 100663763);
			ISteamGameSearch.NativeMethodInfoPtr_SubmitPlayerResult_Internal_GameSearchErrorCode_t_UInt64_SteamId_PlayerResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameSearch>.NativeClassPtr, 100663764);
			ISteamGameSearch.NativeMethodInfoPtr__EndGame_Private_Static_GameSearchErrorCode_t_IntPtr_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameSearch>.NativeClassPtr, 100663765);
			ISteamGameSearch.NativeMethodInfoPtr_EndGame_Internal_GameSearchErrorCode_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamGameSearch>.NativeClassPtr, 100663766);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0001947C File Offset: 0x0001767C
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 930944, RefRangeEnd = 930966, XrefRangeStart = 930944, XrefRangeEnd = 930966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISteamGameSearch(bool IsGameServer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamGameSearch>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref IsGameServer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameSearch.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001DB RID: 475 RVA: 0x000194C4 File Offset: 0x000176C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932032, XrefRangeEnd = 932034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr SteamAPI_SteamGameSearch_v001()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameSearch.NativeMethodInfoPtr_SteamAPI_SteamGameSearch_v001_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000194F4 File Offset: 0x000176F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IntPtr GetUserInterfacePointer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamGameSearch.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0001953C File Offset: 0x0001773C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932034, XrefRangeEnd = 932039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameSearchErrorCode_t _AddGameSearchParams(IntPtr self, string pchKeyToFind, string pchValuesToFind)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchKeyToFind);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchValuesToFind);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameSearch.NativeMethodInfoPtr__AddGameSearchParams_Private_Static_GameSearchErrorCode_t_IntPtr_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x000195A0 File Offset: 0x000177A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932039, XrefRangeEnd = 932044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameSearchErrorCode_t AddGameSearchParams(string pchKeyToFind, string pchValuesToFind)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchKeyToFind);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchValuesToFind);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameSearch.NativeMethodInfoPtr_AddGameSearchParams_Internal_GameSearchErrorCode_t_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00019600 File Offset: 0x00017800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932044, XrefRangeEnd = 932046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameSearchErrorCode_t _SearchForGameWithLobby(IntPtr self, SteamId steamIDLobby, int nPlayerMin, int nPlayerMax)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDLobby;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nPlayerMin;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nPlayerMax;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameSearch.NativeMethodInfoPtr__SearchForGameWithLobby_Private_Static_GameSearchErrorCode_t_IntPtr_SteamId_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00019668 File Offset: 0x00017868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932046, XrefRangeEnd = 932048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameSearchErrorCode_t SearchForGameWithLobby(SteamId steamIDLobby, int nPlayerMin, int nPlayerMax)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nPlayerMin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nPlayerMax;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameSearch.NativeMethodInfoPtr_SearchForGameWithLobby_Internal_GameSearchErrorCode_t_SteamId_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x000196D0 File Offset: 0x000178D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932048, XrefRangeEnd = 932050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameSearchErrorCode_t _SearchForGameSolo(IntPtr self, int nPlayerMin, int nPlayerMax)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nPlayerMin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nPlayerMax;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameSearch.NativeMethodInfoPtr__SearchForGameSolo_Private_Static_GameSearchErrorCode_t_IntPtr_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0001972C File Offset: 0x0001792C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932050, XrefRangeEnd = 932052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameSearchErrorCode_t SearchForGameSolo(int nPlayerMin, int nPlayerMax)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nPlayerMin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nPlayerMax;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameSearch.NativeMethodInfoPtr_SearchForGameSolo_Internal_GameSearchErrorCode_t_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00019784 File Offset: 0x00017984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932052, XrefRangeEnd = 932054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameSearchErrorCode_t _AcceptGame(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameSearch.NativeMethodInfoPtr__AcceptGame_Private_Static_GameSearchErrorCode_t_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x000197C4 File Offset: 0x000179C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932054, XrefRangeEnd = 932056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameSearchErrorCode_t AcceptGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameSearch.NativeMethodInfoPtr_AcceptGame_Internal_GameSearchErrorCode_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00019800 File Offset: 0x00017A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932056, XrefRangeEnd = 932058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameSearchErrorCode_t _DeclineGame(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameSearch.NativeMethodInfoPtr__DeclineGame_Private_Static_GameSearchErrorCode_t_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00019840 File Offset: 0x00017A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932058, XrefRangeEnd = 932060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameSearchErrorCode_t DeclineGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameSearch.NativeMethodInfoPtr_DeclineGame_Internal_GameSearchErrorCode_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0001987C File Offset: 0x00017A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932060, XrefRangeEnd = 932062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameSearchErrorCode_t _RetrieveConnectionDetails(IntPtr self, SteamId steamIDHost, IntPtr pchConnectionDetails, int cubConnectionDetails)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDHost;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pchConnectionDetails;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubConnectionDetails;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameSearch.NativeMethodInfoPtr__RetrieveConnectionDetails_Private_Static_GameSearchErrorCode_t_IntPtr_SteamId_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x000198E4 File Offset: 0x00017AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932062, XrefRangeEnd = 932084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameSearchErrorCode_t RetrieveConnectionDetails(SteamId steamIDHost, out string pchConnectionDetails)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDHost;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamGameSearch.NativeMethodInfoPtr_RetrieveConnectionDetails_Internal_GameSearchErrorCode_t_SteamId_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchConnectionDetails = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00019948 File Offset: 0x00017B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932084, XrefRangeEnd = 932086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameSearchErrorCode_t _EndGameSearch(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameSearch.NativeMethodInfoPtr__EndGameSearch_Private_Static_GameSearchErrorCode_t_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00019988 File Offset: 0x00017B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932086, XrefRangeEnd = 932088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameSearchErrorCode_t EndGameSearch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameSearch.NativeMethodInfoPtr_EndGameSearch_Internal_GameSearchErrorCode_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x000199C4 File Offset: 0x00017BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932088, XrefRangeEnd = 932093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameSearchErrorCode_t _SetGameHostParams(IntPtr self, string pchKey, string pchValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameSearch.NativeMethodInfoPtr__SetGameHostParams_Private_Static_GameSearchErrorCode_t_IntPtr_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00019A28 File Offset: 0x00017C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932093, XrefRangeEnd = 932098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameSearchErrorCode_t SetGameHostParams(string pchKey, string pchValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameSearch.NativeMethodInfoPtr_SetGameHostParams_Internal_GameSearchErrorCode_t_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00019A88 File Offset: 0x00017C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932098, XrefRangeEnd = 932101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameSearchErrorCode_t _SetConnectionDetails(IntPtr self, string pchConnectionDetails, int cubConnectionDetails)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchConnectionDetails);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubConnectionDetails;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameSearch.NativeMethodInfoPtr__SetConnectionDetails_Private_Static_GameSearchErrorCode_t_IntPtr_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00019AE8 File Offset: 0x00017CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932101, XrefRangeEnd = 932104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameSearchErrorCode_t SetConnectionDetails(string pchConnectionDetails, int cubConnectionDetails)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchConnectionDetails);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubConnectionDetails;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameSearch.NativeMethodInfoPtr_SetConnectionDetails_Internal_GameSearchErrorCode_t_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00019B44 File Offset: 0x00017D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932104, XrefRangeEnd = 932106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameSearchErrorCode_t _RequestPlayersForGame(IntPtr self, int nPlayerMin, int nPlayerMax, int nMaxTeamSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nPlayerMin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nPlayerMax;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMaxTeamSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameSearch.NativeMethodInfoPtr__RequestPlayersForGame_Private_Static_GameSearchErrorCode_t_IntPtr_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00019BAC File Offset: 0x00017DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932106, XrefRangeEnd = 932108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameSearchErrorCode_t RequestPlayersForGame(int nPlayerMin, int nPlayerMax, int nMaxTeamSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nPlayerMin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nPlayerMax;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMaxTeamSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameSearch.NativeMethodInfoPtr_RequestPlayersForGame_Internal_GameSearchErrorCode_t_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00019C14 File Offset: 0x00017E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932108, XrefRangeEnd = 932110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameSearchErrorCode_t _HostConfirmGameStart(IntPtr self, ulong ullUniqueGameID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ullUniqueGameID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameSearch.NativeMethodInfoPtr__HostConfirmGameStart_Private_Static_GameSearchErrorCode_t_IntPtr_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00019C60 File Offset: 0x00017E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932110, XrefRangeEnd = 932112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameSearchErrorCode_t HostConfirmGameStart(ulong ullUniqueGameID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ullUniqueGameID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameSearch.NativeMethodInfoPtr_HostConfirmGameStart_Internal_GameSearchErrorCode_t_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00019CAC File Offset: 0x00017EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932112, XrefRangeEnd = 932114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameSearchErrorCode_t _CancelRequestPlayersForGame(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameSearch.NativeMethodInfoPtr__CancelRequestPlayersForGame_Private_Static_GameSearchErrorCode_t_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00019CEC File Offset: 0x00017EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932114, XrefRangeEnd = 932116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameSearchErrorCode_t CancelRequestPlayersForGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameSearch.NativeMethodInfoPtr_CancelRequestPlayersForGame_Internal_GameSearchErrorCode_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00019D28 File Offset: 0x00017F28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932116, XrefRangeEnd = 932118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameSearchErrorCode_t _SubmitPlayerResult(IntPtr self, ulong ullUniqueGameID, SteamId steamIDPlayer, PlayerResult_t EPlayerResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ullUniqueGameID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDPlayer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref EPlayerResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameSearch.NativeMethodInfoPtr__SubmitPlayerResult_Private_Static_GameSearchErrorCode_t_IntPtr_UInt64_SteamId_PlayerResult_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00019D90 File Offset: 0x00017F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932118, XrefRangeEnd = 932120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameSearchErrorCode_t SubmitPlayerResult(ulong ullUniqueGameID, SteamId steamIDPlayer, PlayerResult_t EPlayerResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ullUniqueGameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDPlayer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref EPlayerResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameSearch.NativeMethodInfoPtr_SubmitPlayerResult_Internal_GameSearchErrorCode_t_UInt64_SteamId_PlayerResult_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00019DF8 File Offset: 0x00017FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932120, XrefRangeEnd = 932122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameSearchErrorCode_t _EndGame(IntPtr self, ulong ullUniqueGameID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ullUniqueGameID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameSearch.NativeMethodInfoPtr__EndGame_Private_Static_GameSearchErrorCode_t_IntPtr_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00019E44 File Offset: 0x00018044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932122, XrefRangeEnd = 932124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameSearchErrorCode_t EndGame(ulong ullUniqueGameID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ullUniqueGameID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamGameSearch.NativeMethodInfoPtr_EndGame_Internal_GameSearchErrorCode_t_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00002300 File Offset: 0x00000500
		public ISteamGameSearch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeMethodInfoPtr_SteamAPI_SteamGameSearch_v001_Internal_Static_IntPtr_0;

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0;

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeMethodInfoPtr__AddGameSearchParams_Private_Static_GameSearchErrorCode_t_IntPtr_String_String_0;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeMethodInfoPtr_AddGameSearchParams_Internal_GameSearchErrorCode_t_String_String_0;

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeMethodInfoPtr__SearchForGameWithLobby_Private_Static_GameSearchErrorCode_t_IntPtr_SteamId_Int32_Int32_0;

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeMethodInfoPtr_SearchForGameWithLobby_Internal_GameSearchErrorCode_t_SteamId_Int32_Int32_0;

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeMethodInfoPtr__SearchForGameSolo_Private_Static_GameSearchErrorCode_t_IntPtr_Int32_Int32_0;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeMethodInfoPtr_SearchForGameSolo_Internal_GameSearchErrorCode_t_Int32_Int32_0;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeMethodInfoPtr__AcceptGame_Private_Static_GameSearchErrorCode_t_IntPtr_0;

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeMethodInfoPtr_AcceptGame_Internal_GameSearchErrorCode_t_0;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeMethodInfoPtr__DeclineGame_Private_Static_GameSearchErrorCode_t_IntPtr_0;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeMethodInfoPtr_DeclineGame_Internal_GameSearchErrorCode_t_0;

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeMethodInfoPtr__RetrieveConnectionDetails_Private_Static_GameSearchErrorCode_t_IntPtr_SteamId_IntPtr_Int32_0;

		// Token: 0x0400028C RID: 652
		private static readonly IntPtr NativeMethodInfoPtr_RetrieveConnectionDetails_Internal_GameSearchErrorCode_t_SteamId_byref_String_0;

		// Token: 0x0400028D RID: 653
		private static readonly IntPtr NativeMethodInfoPtr__EndGameSearch_Private_Static_GameSearchErrorCode_t_IntPtr_0;

		// Token: 0x0400028E RID: 654
		private static readonly IntPtr NativeMethodInfoPtr_EndGameSearch_Internal_GameSearchErrorCode_t_0;

		// Token: 0x0400028F RID: 655
		private static readonly IntPtr NativeMethodInfoPtr__SetGameHostParams_Private_Static_GameSearchErrorCode_t_IntPtr_String_String_0;

		// Token: 0x04000290 RID: 656
		private static readonly IntPtr NativeMethodInfoPtr_SetGameHostParams_Internal_GameSearchErrorCode_t_String_String_0;

		// Token: 0x04000291 RID: 657
		private static readonly IntPtr NativeMethodInfoPtr__SetConnectionDetails_Private_Static_GameSearchErrorCode_t_IntPtr_String_Int32_0;

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeMethodInfoPtr_SetConnectionDetails_Internal_GameSearchErrorCode_t_String_Int32_0;

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeMethodInfoPtr__RequestPlayersForGame_Private_Static_GameSearchErrorCode_t_IntPtr_Int32_Int32_Int32_0;

		// Token: 0x04000294 RID: 660
		private static readonly IntPtr NativeMethodInfoPtr_RequestPlayersForGame_Internal_GameSearchErrorCode_t_Int32_Int32_Int32_0;

		// Token: 0x04000295 RID: 661
		private static readonly IntPtr NativeMethodInfoPtr__HostConfirmGameStart_Private_Static_GameSearchErrorCode_t_IntPtr_UInt64_0;

		// Token: 0x04000296 RID: 662
		private static readonly IntPtr NativeMethodInfoPtr_HostConfirmGameStart_Internal_GameSearchErrorCode_t_UInt64_0;

		// Token: 0x04000297 RID: 663
		private static readonly IntPtr NativeMethodInfoPtr__CancelRequestPlayersForGame_Private_Static_GameSearchErrorCode_t_IntPtr_0;

		// Token: 0x04000298 RID: 664
		private static readonly IntPtr NativeMethodInfoPtr_CancelRequestPlayersForGame_Internal_GameSearchErrorCode_t_0;

		// Token: 0x04000299 RID: 665
		private static readonly IntPtr NativeMethodInfoPtr__SubmitPlayerResult_Private_Static_GameSearchErrorCode_t_IntPtr_UInt64_SteamId_PlayerResult_t_0;

		// Token: 0x0400029A RID: 666
		private static readonly IntPtr NativeMethodInfoPtr_SubmitPlayerResult_Internal_GameSearchErrorCode_t_UInt64_SteamId_PlayerResult_t_0;

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeMethodInfoPtr__EndGame_Private_Static_GameSearchErrorCode_t_IntPtr_UInt64_0;

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeMethodInfoPtr_EndGame_Internal_GameSearchErrorCode_t_UInt64_0;
	}
}
