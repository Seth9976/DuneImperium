using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x02000027 RID: 39
	public class ISteamParties : SteamInterface
	{
		// Token: 0x060005A0 RID: 1440 RVA: 0x00031828 File Offset: 0x0002FA28
		// Note: this type is marked as 'beforefieldinit'.
		static ISteamParties()
		{
			Il2CppClassPointerStore<ISteamParties>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "ISteamParties");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamParties>.NativeClassPtr);
			ISteamParties.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamParties>.NativeClassPtr, 100664661);
			ISteamParties.NativeMethodInfoPtr_SteamAPI_SteamParties_v002_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamParties>.NativeClassPtr, 100664662);
			ISteamParties.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamParties>.NativeClassPtr, 100664663);
			ISteamParties.NativeMethodInfoPtr__GetNumActiveBeacons_Private_Static_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamParties>.NativeClassPtr, 100664664);
			ISteamParties.NativeMethodInfoPtr_GetNumActiveBeacons_Internal_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamParties>.NativeClassPtr, 100664665);
			ISteamParties.NativeMethodInfoPtr__GetBeaconByIndex_Private_Static_PartyBeaconID_t_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamParties>.NativeClassPtr, 100664666);
			ISteamParties.NativeMethodInfoPtr_GetBeaconByIndex_Internal_PartyBeaconID_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamParties>.NativeClassPtr, 100664667);
			ISteamParties.NativeMethodInfoPtr__GetBeaconDetails_Private_Static_Boolean_IntPtr_PartyBeaconID_t_byref_SteamId_byref_SteamPartyBeaconLocation_t_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamParties>.NativeClassPtr, 100664668);
			ISteamParties.NativeMethodInfoPtr_GetBeaconDetails_Internal_Boolean_PartyBeaconID_t_byref_SteamId_byref_SteamPartyBeaconLocation_t_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamParties>.NativeClassPtr, 100664669);
			ISteamParties.NativeMethodInfoPtr__JoinParty_Private_Static_SteamAPICall_t_IntPtr_PartyBeaconID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamParties>.NativeClassPtr, 100664670);
			ISteamParties.NativeMethodInfoPtr_JoinParty_Internal_CallResult_1_JoinPartyCallback_t_PartyBeaconID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamParties>.NativeClassPtr, 100664671);
			ISteamParties.NativeMethodInfoPtr__GetNumAvailableBeaconLocations_Private_Static_Boolean_IntPtr_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamParties>.NativeClassPtr, 100664672);
			ISteamParties.NativeMethodInfoPtr_GetNumAvailableBeaconLocations_Internal_Boolean_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamParties>.NativeClassPtr, 100664673);
			ISteamParties.NativeMethodInfoPtr__GetAvailableBeaconLocations_Private_Static_Boolean_IntPtr_byref_SteamPartyBeaconLocation_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamParties>.NativeClassPtr, 100664674);
			ISteamParties.NativeMethodInfoPtr_GetAvailableBeaconLocations_Internal_Boolean_byref_SteamPartyBeaconLocation_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamParties>.NativeClassPtr, 100664675);
			ISteamParties.NativeMethodInfoPtr__CreateBeacon_Private_Static_SteamAPICall_t_IntPtr_UInt32_byref_SteamPartyBeaconLocation_t_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamParties>.NativeClassPtr, 100664676);
			ISteamParties.NativeMethodInfoPtr_CreateBeacon_Internal_CallResult_1_CreateBeaconCallback_t_UInt32_SteamPartyBeaconLocation_t_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamParties>.NativeClassPtr, 100664677);
			ISteamParties.NativeMethodInfoPtr__OnReservationCompleted_Private_Static_Void_IntPtr_PartyBeaconID_t_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamParties>.NativeClassPtr, 100664678);
			ISteamParties.NativeMethodInfoPtr_OnReservationCompleted_Internal_Void_PartyBeaconID_t_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamParties>.NativeClassPtr, 100664679);
			ISteamParties.NativeMethodInfoPtr__CancelReservation_Private_Static_Void_IntPtr_PartyBeaconID_t_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamParties>.NativeClassPtr, 100664680);
			ISteamParties.NativeMethodInfoPtr_CancelReservation_Internal_Void_PartyBeaconID_t_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamParties>.NativeClassPtr, 100664681);
			ISteamParties.NativeMethodInfoPtr__ChangeNumOpenSlots_Private_Static_SteamAPICall_t_IntPtr_PartyBeaconID_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamParties>.NativeClassPtr, 100664682);
			ISteamParties.NativeMethodInfoPtr_ChangeNumOpenSlots_Internal_CallResult_1_ChangeNumOpenSlotsCallback_t_PartyBeaconID_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamParties>.NativeClassPtr, 100664683);
			ISteamParties.NativeMethodInfoPtr__DestroyBeacon_Private_Static_Boolean_IntPtr_PartyBeaconID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamParties>.NativeClassPtr, 100664684);
			ISteamParties.NativeMethodInfoPtr_DestroyBeacon_Internal_Boolean_PartyBeaconID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamParties>.NativeClassPtr, 100664685);
			ISteamParties.NativeMethodInfoPtr__GetBeaconLocationData_Private_Static_Boolean_IntPtr_SteamPartyBeaconLocation_t_SteamPartyBeaconLocationData_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamParties>.NativeClassPtr, 100664686);
			ISteamParties.NativeMethodInfoPtr_GetBeaconLocationData_Internal_Boolean_SteamPartyBeaconLocation_t_SteamPartyBeaconLocationData_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamParties>.NativeClassPtr, 100664687);
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00031A74 File Offset: 0x0002FC74
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 930944, RefRangeEnd = 930966, XrefRangeStart = 930944, XrefRangeEnd = 930966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISteamParties(bool IsGameServer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamParties>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref IsGameServer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamParties.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00031ABC File Offset: 0x0002FCBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934698, XrefRangeEnd = 934700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr SteamAPI_SteamParties_v002()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamParties.NativeMethodInfoPtr_SteamAPI_SteamParties_v002_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00031AEC File Offset: 0x0002FCEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IntPtr GetUserInterfacePointer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamParties.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00031B34 File Offset: 0x0002FD34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934700, XrefRangeEnd = 934702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint _GetNumActiveBeacons(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamParties.NativeMethodInfoPtr__GetNumActiveBeacons_Private_Static_UInt32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00031B74 File Offset: 0x0002FD74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 934704, RefRangeEnd = 934706, XrefRangeStart = 934702, XrefRangeEnd = 934704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetNumActiveBeacons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamParties.NativeMethodInfoPtr_GetNumActiveBeacons_Internal_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00031BB0 File Offset: 0x0002FDB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934706, XrefRangeEnd = 934708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PartyBeaconID_t _GetBeaconByIndex(IntPtr self, uint unIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamParties.NativeMethodInfoPtr__GetBeaconByIndex_Private_Static_PartyBeaconID_t_IntPtr_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00031BFC File Offset: 0x0002FDFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934710, RefRangeEnd = 934711, XrefRangeStart = 934708, XrefRangeEnd = 934710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PartyBeaconID_t GetBeaconByIndex(uint unIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamParties.NativeMethodInfoPtr_GetBeaconByIndex_Internal_PartyBeaconID_t_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00031C48 File Offset: 0x0002FE48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934711, XrefRangeEnd = 934713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetBeaconDetails(IntPtr self, PartyBeaconID_t ulBeaconID, ref SteamId pSteamIDBeaconOwner, ref SteamPartyBeaconLocation_t pLocation, IntPtr pchMetadata, int cchMetadata)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ulBeaconID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pSteamIDBeaconOwner;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pLocation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pchMetadata;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cchMetadata;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamParties.NativeMethodInfoPtr__GetBeaconDetails_Private_Static_Boolean_IntPtr_PartyBeaconID_t_byref_SteamId_byref_SteamPartyBeaconLocation_t_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00031CCC File Offset: 0x0002FECC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 934735, RefRangeEnd = 934737, XrefRangeStart = 934713, XrefRangeEnd = 934735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetBeaconDetails(PartyBeaconID_t ulBeaconID, ref SteamId pSteamIDBeaconOwner, ref SteamPartyBeaconLocation_t pLocation, out string pchMetadata)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ulBeaconID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pSteamIDBeaconOwner;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pLocation;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamParties.NativeMethodInfoPtr_GetBeaconDetails_Internal_Boolean_PartyBeaconID_t_byref_SteamId_byref_SteamPartyBeaconLocation_t_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchMetadata = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00031D50 File Offset: 0x0002FF50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934737, XrefRangeEnd = 934739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t _JoinParty(IntPtr self, PartyBeaconID_t ulBeaconID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ulBeaconID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamParties.NativeMethodInfoPtr__JoinParty_Private_Static_SteamAPICall_t_IntPtr_PartyBeaconID_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00031D9C File Offset: 0x0002FF9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934744, RefRangeEnd = 934745, XrefRangeStart = 934739, XrefRangeEnd = 934744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<JoinPartyCallback_t> JoinParty(PartyBeaconID_t ulBeaconID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ulBeaconID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamParties.NativeMethodInfoPtr_JoinParty_Internal_CallResult_1_JoinPartyCallback_t_PartyBeaconID_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CallResult<JoinPartyCallback_t>(intPtr);
			}
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00031DE0 File Offset: 0x0002FFE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934745, XrefRangeEnd = 934747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetNumAvailableBeaconLocations(IntPtr self, ref uint puNumLocations)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &puNumLocations;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamParties.NativeMethodInfoPtr__GetNumAvailableBeaconLocations_Private_Static_Boolean_IntPtr_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00031E2C File Offset: 0x0003002C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934747, XrefRangeEnd = 934749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetNumAvailableBeaconLocations(ref uint puNumLocations)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &puNumLocations;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamParties.NativeMethodInfoPtr_GetNumAvailableBeaconLocations_Internal_Boolean_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00031E78 File Offset: 0x00030078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934749, XrefRangeEnd = 934751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetAvailableBeaconLocations(IntPtr self, ref SteamPartyBeaconLocation_t pLocationList, uint uMaxNumLocations)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pLocationList;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uMaxNumLocations;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamParties.NativeMethodInfoPtr__GetAvailableBeaconLocations_Private_Static_Boolean_IntPtr_byref_SteamPartyBeaconLocation_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00031ED4 File Offset: 0x000300D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934751, XrefRangeEnd = 934753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetAvailableBeaconLocations(ref SteamPartyBeaconLocation_t pLocationList, uint uMaxNumLocations)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pLocationList;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uMaxNumLocations;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamParties.NativeMethodInfoPtr_GetAvailableBeaconLocations_Internal_Boolean_byref_SteamPartyBeaconLocation_t_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00031F2C File Offset: 0x0003012C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934753, XrefRangeEnd = 934758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t _CreateBeacon(IntPtr self, uint unOpenSlots, ref SteamPartyBeaconLocation_t pBeaconLocation, string pchConnectString, string pchMetadata)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unOpenSlots;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pBeaconLocation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchConnectString);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchMetadata);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamParties.NativeMethodInfoPtr__CreateBeacon_Private_Static_SteamAPICall_t_IntPtr_UInt32_byref_SteamPartyBeaconLocation_t_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00031FAC File Offset: 0x000301AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934758, XrefRangeEnd = 934766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<CreateBeaconCallback_t> CreateBeacon(uint unOpenSlots, SteamPartyBeaconLocation_t pBeaconLocation, string pchConnectString, string pchMetadata)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unOpenSlots;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pBeaconLocation;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchConnectString);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchMetadata);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamParties.NativeMethodInfoPtr_CreateBeacon_Internal_CallResult_1_CreateBeaconCallback_t_UInt32_SteamPartyBeaconLocation_t_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new CallResult<CreateBeaconCallback_t>(intPtr);
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00032024 File Offset: 0x00030224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934766, XrefRangeEnd = 934768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _OnReservationCompleted(IntPtr self, PartyBeaconID_t ulBeacon, SteamId steamIDUser)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ulBeacon;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDUser;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamParties.NativeMethodInfoPtr__OnReservationCompleted_Private_Static_Void_IntPtr_PartyBeaconID_t_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00032074 File Offset: 0x00030274
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934770, RefRangeEnd = 934771, XrefRangeStart = 934768, XrefRangeEnd = 934770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnReservationCompleted(PartyBeaconID_t ulBeacon, SteamId steamIDUser)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ulBeacon;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDUser;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamParties.NativeMethodInfoPtr_OnReservationCompleted_Internal_Void_PartyBeaconID_t_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x000320C0 File Offset: 0x000302C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934771, XrefRangeEnd = 934773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _CancelReservation(IntPtr self, PartyBeaconID_t ulBeacon, SteamId steamIDUser)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ulBeacon;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDUser;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamParties.NativeMethodInfoPtr__CancelReservation_Private_Static_Void_IntPtr_PartyBeaconID_t_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00032110 File Offset: 0x00030310
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934775, RefRangeEnd = 934776, XrefRangeStart = 934773, XrefRangeEnd = 934775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelReservation(PartyBeaconID_t ulBeacon, SteamId steamIDUser)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ulBeacon;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDUser;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamParties.NativeMethodInfoPtr_CancelReservation_Internal_Void_PartyBeaconID_t_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x0003215C File Offset: 0x0003035C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934776, XrefRangeEnd = 934778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t _ChangeNumOpenSlots(IntPtr self, PartyBeaconID_t ulBeacon, uint unOpenSlots)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ulBeacon;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unOpenSlots;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamParties.NativeMethodInfoPtr__ChangeNumOpenSlots_Private_Static_SteamAPICall_t_IntPtr_PartyBeaconID_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x000321B8 File Offset: 0x000303B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934778, XrefRangeEnd = 934783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<ChangeNumOpenSlotsCallback_t> ChangeNumOpenSlots(PartyBeaconID_t ulBeacon, uint unOpenSlots)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ulBeacon;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unOpenSlots;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamParties.NativeMethodInfoPtr_ChangeNumOpenSlots_Internal_CallResult_1_ChangeNumOpenSlotsCallback_t_PartyBeaconID_t_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new CallResult<ChangeNumOpenSlotsCallback_t>(intPtr);
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x0003220C File Offset: 0x0003040C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934783, XrefRangeEnd = 934785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _DestroyBeacon(IntPtr self, PartyBeaconID_t ulBeacon)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ulBeacon;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamParties.NativeMethodInfoPtr__DestroyBeacon_Private_Static_Boolean_IntPtr_PartyBeaconID_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00032258 File Offset: 0x00030458
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934787, RefRangeEnd = 934788, XrefRangeStart = 934785, XrefRangeEnd = 934787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DestroyBeacon(PartyBeaconID_t ulBeacon)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ulBeacon;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamParties.NativeMethodInfoPtr_DestroyBeacon_Internal_Boolean_PartyBeaconID_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x000322A4 File Offset: 0x000304A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934788, XrefRangeEnd = 934790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetBeaconLocationData(IntPtr self, SteamPartyBeaconLocation_t BeaconLocation, SteamPartyBeaconLocationData eData, IntPtr pchDataStringOut, int cchDataStringOut)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref BeaconLocation;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eData;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pchDataStringOut;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cchDataStringOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamParties.NativeMethodInfoPtr__GetBeaconLocationData_Private_Static_Boolean_IntPtr_SteamPartyBeaconLocation_t_SteamPartyBeaconLocationData_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x0003231C File Offset: 0x0003051C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934790, XrefRangeEnd = 934812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetBeaconLocationData(SteamPartyBeaconLocation_t BeaconLocation, SteamPartyBeaconLocationData eData, out string pchDataStringOut)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref BeaconLocation;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eData;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamParties.NativeMethodInfoPtr_GetBeaconLocationData_Internal_Boolean_SteamPartyBeaconLocation_t_SteamPartyBeaconLocationData_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchDataStringOut = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x000023BD File Offset: 0x000005BD
		public ISteamParties(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400061B RID: 1563
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x0400061C RID: 1564
		private static readonly IntPtr NativeMethodInfoPtr_SteamAPI_SteamParties_v002_Internal_Static_IntPtr_0;

		// Token: 0x0400061D RID: 1565
		private static readonly IntPtr NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0;

		// Token: 0x0400061E RID: 1566
		private static readonly IntPtr NativeMethodInfoPtr__GetNumActiveBeacons_Private_Static_UInt32_IntPtr_0;

		// Token: 0x0400061F RID: 1567
		private static readonly IntPtr NativeMethodInfoPtr_GetNumActiveBeacons_Internal_UInt32_0;

		// Token: 0x04000620 RID: 1568
		private static readonly IntPtr NativeMethodInfoPtr__GetBeaconByIndex_Private_Static_PartyBeaconID_t_IntPtr_UInt32_0;

		// Token: 0x04000621 RID: 1569
		private static readonly IntPtr NativeMethodInfoPtr_GetBeaconByIndex_Internal_PartyBeaconID_t_UInt32_0;

		// Token: 0x04000622 RID: 1570
		private static readonly IntPtr NativeMethodInfoPtr__GetBeaconDetails_Private_Static_Boolean_IntPtr_PartyBeaconID_t_byref_SteamId_byref_SteamPartyBeaconLocation_t_IntPtr_Int32_0;

		// Token: 0x04000623 RID: 1571
		private static readonly IntPtr NativeMethodInfoPtr_GetBeaconDetails_Internal_Boolean_PartyBeaconID_t_byref_SteamId_byref_SteamPartyBeaconLocation_t_byref_String_0;

		// Token: 0x04000624 RID: 1572
		private static readonly IntPtr NativeMethodInfoPtr__JoinParty_Private_Static_SteamAPICall_t_IntPtr_PartyBeaconID_t_0;

		// Token: 0x04000625 RID: 1573
		private static readonly IntPtr NativeMethodInfoPtr_JoinParty_Internal_CallResult_1_JoinPartyCallback_t_PartyBeaconID_t_0;

		// Token: 0x04000626 RID: 1574
		private static readonly IntPtr NativeMethodInfoPtr__GetNumAvailableBeaconLocations_Private_Static_Boolean_IntPtr_byref_UInt32_0;

		// Token: 0x04000627 RID: 1575
		private static readonly IntPtr NativeMethodInfoPtr_GetNumAvailableBeaconLocations_Internal_Boolean_byref_UInt32_0;

		// Token: 0x04000628 RID: 1576
		private static readonly IntPtr NativeMethodInfoPtr__GetAvailableBeaconLocations_Private_Static_Boolean_IntPtr_byref_SteamPartyBeaconLocation_t_UInt32_0;

		// Token: 0x04000629 RID: 1577
		private static readonly IntPtr NativeMethodInfoPtr_GetAvailableBeaconLocations_Internal_Boolean_byref_SteamPartyBeaconLocation_t_UInt32_0;

		// Token: 0x0400062A RID: 1578
		private static readonly IntPtr NativeMethodInfoPtr__CreateBeacon_Private_Static_SteamAPICall_t_IntPtr_UInt32_byref_SteamPartyBeaconLocation_t_String_String_0;

		// Token: 0x0400062B RID: 1579
		private static readonly IntPtr NativeMethodInfoPtr_CreateBeacon_Internal_CallResult_1_CreateBeaconCallback_t_UInt32_SteamPartyBeaconLocation_t_String_String_0;

		// Token: 0x0400062C RID: 1580
		private static readonly IntPtr NativeMethodInfoPtr__OnReservationCompleted_Private_Static_Void_IntPtr_PartyBeaconID_t_SteamId_0;

		// Token: 0x0400062D RID: 1581
		private static readonly IntPtr NativeMethodInfoPtr_OnReservationCompleted_Internal_Void_PartyBeaconID_t_SteamId_0;

		// Token: 0x0400062E RID: 1582
		private static readonly IntPtr NativeMethodInfoPtr__CancelReservation_Private_Static_Void_IntPtr_PartyBeaconID_t_SteamId_0;

		// Token: 0x0400062F RID: 1583
		private static readonly IntPtr NativeMethodInfoPtr_CancelReservation_Internal_Void_PartyBeaconID_t_SteamId_0;

		// Token: 0x04000630 RID: 1584
		private static readonly IntPtr NativeMethodInfoPtr__ChangeNumOpenSlots_Private_Static_SteamAPICall_t_IntPtr_PartyBeaconID_t_UInt32_0;

		// Token: 0x04000631 RID: 1585
		private static readonly IntPtr NativeMethodInfoPtr_ChangeNumOpenSlots_Internal_CallResult_1_ChangeNumOpenSlotsCallback_t_PartyBeaconID_t_UInt32_0;

		// Token: 0x04000632 RID: 1586
		private static readonly IntPtr NativeMethodInfoPtr__DestroyBeacon_Private_Static_Boolean_IntPtr_PartyBeaconID_t_0;

		// Token: 0x04000633 RID: 1587
		private static readonly IntPtr NativeMethodInfoPtr_DestroyBeacon_Internal_Boolean_PartyBeaconID_t_0;

		// Token: 0x04000634 RID: 1588
		private static readonly IntPtr NativeMethodInfoPtr__GetBeaconLocationData_Private_Static_Boolean_IntPtr_SteamPartyBeaconLocation_t_SteamPartyBeaconLocationData_IntPtr_Int32_0;

		// Token: 0x04000635 RID: 1589
		private static readonly IntPtr NativeMethodInfoPtr_GetBeaconLocationData_Internal_Boolean_SteamPartyBeaconLocation_t_SteamPartyBeaconLocationData_byref_String_0;
	}
}
