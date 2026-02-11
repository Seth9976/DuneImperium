using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x02000028 RID: 40
	public class ISteamRemotePlay : SteamInterface
	{
		// Token: 0x060005BD RID: 1469 RVA: 0x00032390 File Offset: 0x00030590
		// Note: this type is marked as 'beforefieldinit'.
		static ISteamRemotePlay()
		{
			Il2CppClassPointerStore<ISteamRemotePlay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "ISteamRemotePlay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamRemotePlay>.NativeClassPtr);
			ISteamRemotePlay.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemotePlay>.NativeClassPtr, 100664688);
			ISteamRemotePlay.NativeMethodInfoPtr_SteamAPI_SteamRemotePlay_v001_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemotePlay>.NativeClassPtr, 100664689);
			ISteamRemotePlay.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemotePlay>.NativeClassPtr, 100664690);
			ISteamRemotePlay.NativeMethodInfoPtr__GetSessionCount_Private_Static_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemotePlay>.NativeClassPtr, 100664691);
			ISteamRemotePlay.NativeMethodInfoPtr_GetSessionCount_Internal_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemotePlay>.NativeClassPtr, 100664692);
			ISteamRemotePlay.NativeMethodInfoPtr__GetSessionID_Private_Static_RemotePlaySessionID_t_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemotePlay>.NativeClassPtr, 100664693);
			ISteamRemotePlay.NativeMethodInfoPtr_GetSessionID_Internal_RemotePlaySessionID_t_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemotePlay>.NativeClassPtr, 100664694);
			ISteamRemotePlay.NativeMethodInfoPtr__GetSessionSteamID_Private_Static_SteamId_IntPtr_RemotePlaySessionID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemotePlay>.NativeClassPtr, 100664695);
			ISteamRemotePlay.NativeMethodInfoPtr_GetSessionSteamID_Internal_SteamId_RemotePlaySessionID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemotePlay>.NativeClassPtr, 100664696);
			ISteamRemotePlay.NativeMethodInfoPtr__GetSessionClientName_Private_Static_Utf8StringPointer_IntPtr_RemotePlaySessionID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemotePlay>.NativeClassPtr, 100664697);
			ISteamRemotePlay.NativeMethodInfoPtr_GetSessionClientName_Internal_String_RemotePlaySessionID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemotePlay>.NativeClassPtr, 100664698);
			ISteamRemotePlay.NativeMethodInfoPtr__GetSessionClientFormFactor_Private_Static_SteamDeviceFormFactor_IntPtr_RemotePlaySessionID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemotePlay>.NativeClassPtr, 100664699);
			ISteamRemotePlay.NativeMethodInfoPtr_GetSessionClientFormFactor_Internal_SteamDeviceFormFactor_RemotePlaySessionID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemotePlay>.NativeClassPtr, 100664700);
			ISteamRemotePlay.NativeMethodInfoPtr__BGetSessionClientResolution_Private_Static_Boolean_IntPtr_RemotePlaySessionID_t_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemotePlay>.NativeClassPtr, 100664701);
			ISteamRemotePlay.NativeMethodInfoPtr_BGetSessionClientResolution_Internal_Boolean_RemotePlaySessionID_t_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemotePlay>.NativeClassPtr, 100664702);
			ISteamRemotePlay.NativeMethodInfoPtr__BSendRemotePlayTogetherInvite_Private_Static_Boolean_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemotePlay>.NativeClassPtr, 100664703);
			ISteamRemotePlay.NativeMethodInfoPtr_BSendRemotePlayTogetherInvite_Internal_Boolean_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemotePlay>.NativeClassPtr, 100664704);
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00032514 File Offset: 0x00030714
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 930944, RefRangeEnd = 930966, XrefRangeStart = 930944, XrefRangeEnd = 930966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISteamRemotePlay(bool IsGameServer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamRemotePlay>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref IsGameServer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemotePlay.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x0003255C File Offset: 0x0003075C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934812, XrefRangeEnd = 934814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr SteamAPI_SteamRemotePlay_v001()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemotePlay.NativeMethodInfoPtr_SteamAPI_SteamRemotePlay_v001_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x0003258C File Offset: 0x0003078C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IntPtr GetUserInterfacePointer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamRemotePlay.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x000325D4 File Offset: 0x000307D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934814, XrefRangeEnd = 934816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint _GetSessionCount(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemotePlay.NativeMethodInfoPtr__GetSessionCount_Private_Static_UInt32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00032614 File Offset: 0x00030814
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934818, RefRangeEnd = 934819, XrefRangeStart = 934816, XrefRangeEnd = 934818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetSessionCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemotePlay.NativeMethodInfoPtr_GetSessionCount_Internal_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00032650 File Offset: 0x00030850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934819, XrefRangeEnd = 934821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RemotePlaySessionID_t _GetSessionID(IntPtr self, int iSessionIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iSessionIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemotePlay.NativeMethodInfoPtr__GetSessionID_Private_Static_RemotePlaySessionID_t_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x0003269C File Offset: 0x0003089C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934823, RefRangeEnd = 934824, XrefRangeStart = 934821, XrefRangeEnd = 934823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RemotePlaySessionID_t GetSessionID(int iSessionIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iSessionIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemotePlay.NativeMethodInfoPtr_GetSessionID_Internal_RemotePlaySessionID_t_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x000326E8 File Offset: 0x000308E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934824, XrefRangeEnd = 934826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamId _GetSessionSteamID(IntPtr self, RemotePlaySessionID_t unSessionID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unSessionID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemotePlay.NativeMethodInfoPtr__GetSessionSteamID_Private_Static_SteamId_IntPtr_RemotePlaySessionID_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00032734 File Offset: 0x00030934
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934828, RefRangeEnd = 934829, XrefRangeStart = 934826, XrefRangeEnd = 934828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamId GetSessionSteamID(RemotePlaySessionID_t unSessionID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unSessionID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemotePlay.NativeMethodInfoPtr_GetSessionSteamID_Internal_SteamId_RemotePlaySessionID_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00032780 File Offset: 0x00030980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934829, XrefRangeEnd = 934831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Utf8StringPointer _GetSessionClientName(IntPtr self, RemotePlaySessionID_t unSessionID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unSessionID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemotePlay.NativeMethodInfoPtr__GetSessionClientName_Private_Static_Utf8StringPointer_IntPtr_RemotePlaySessionID_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x000327CC File Offset: 0x000309CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934834, RefRangeEnd = 934835, XrefRangeStart = 934831, XrefRangeEnd = 934834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetSessionClientName(RemotePlaySessionID_t unSessionID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unSessionID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemotePlay.NativeMethodInfoPtr_GetSessionClientName_Internal_String_RemotePlaySessionID_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00032810 File Offset: 0x00030A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934835, XrefRangeEnd = 934837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamDeviceFormFactor _GetSessionClientFormFactor(IntPtr self, RemotePlaySessionID_t unSessionID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unSessionID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemotePlay.NativeMethodInfoPtr__GetSessionClientFormFactor_Private_Static_SteamDeviceFormFactor_IntPtr_RemotePlaySessionID_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x0003285C File Offset: 0x00030A5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934839, RefRangeEnd = 934840, XrefRangeStart = 934837, XrefRangeEnd = 934839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamDeviceFormFactor GetSessionClientFormFactor(RemotePlaySessionID_t unSessionID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unSessionID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemotePlay.NativeMethodInfoPtr_GetSessionClientFormFactor_Internal_SteamDeviceFormFactor_RemotePlaySessionID_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x000328A8 File Offset: 0x00030AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934840, XrefRangeEnd = 934842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _BGetSessionClientResolution(IntPtr self, RemotePlaySessionID_t unSessionID, ref int pnResolutionX, ref int pnResolutionY)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unSessionID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnResolutionX;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnResolutionY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemotePlay.NativeMethodInfoPtr__BGetSessionClientResolution_Private_Static_Boolean_IntPtr_RemotePlaySessionID_t_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00032910 File Offset: 0x00030B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934842, XrefRangeEnd = 934844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BGetSessionClientResolution(RemotePlaySessionID_t unSessionID, ref int pnResolutionX, ref int pnResolutionY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unSessionID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnResolutionX;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnResolutionY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemotePlay.NativeMethodInfoPtr_BGetSessionClientResolution_Internal_Boolean_RemotePlaySessionID_t_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00032978 File Offset: 0x00030B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934844, XrefRangeEnd = 934846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _BSendRemotePlayTogetherInvite(IntPtr self, SteamId steamIDFriend)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDFriend;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemotePlay.NativeMethodInfoPtr__BSendRemotePlayTogetherInvite_Private_Static_Boolean_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x000329C4 File Offset: 0x00030BC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934848, RefRangeEnd = 934849, XrefRangeStart = 934846, XrefRangeEnd = 934848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BSendRemotePlayTogetherInvite(SteamId steamIDFriend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDFriend;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemotePlay.NativeMethodInfoPtr_BSendRemotePlayTogetherInvite_Internal_Boolean_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x000023C6 File Offset: 0x000005C6
		public ISteamRemotePlay(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000636 RID: 1590
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x04000637 RID: 1591
		private static readonly IntPtr NativeMethodInfoPtr_SteamAPI_SteamRemotePlay_v001_Internal_Static_IntPtr_0;

		// Token: 0x04000638 RID: 1592
		private static readonly IntPtr NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0;

		// Token: 0x04000639 RID: 1593
		private static readonly IntPtr NativeMethodInfoPtr__GetSessionCount_Private_Static_UInt32_IntPtr_0;

		// Token: 0x0400063A RID: 1594
		private static readonly IntPtr NativeMethodInfoPtr_GetSessionCount_Internal_UInt32_0;

		// Token: 0x0400063B RID: 1595
		private static readonly IntPtr NativeMethodInfoPtr__GetSessionID_Private_Static_RemotePlaySessionID_t_IntPtr_Int32_0;

		// Token: 0x0400063C RID: 1596
		private static readonly IntPtr NativeMethodInfoPtr_GetSessionID_Internal_RemotePlaySessionID_t_Int32_0;

		// Token: 0x0400063D RID: 1597
		private static readonly IntPtr NativeMethodInfoPtr__GetSessionSteamID_Private_Static_SteamId_IntPtr_RemotePlaySessionID_t_0;

		// Token: 0x0400063E RID: 1598
		private static readonly IntPtr NativeMethodInfoPtr_GetSessionSteamID_Internal_SteamId_RemotePlaySessionID_t_0;

		// Token: 0x0400063F RID: 1599
		private static readonly IntPtr NativeMethodInfoPtr__GetSessionClientName_Private_Static_Utf8StringPointer_IntPtr_RemotePlaySessionID_t_0;

		// Token: 0x04000640 RID: 1600
		private static readonly IntPtr NativeMethodInfoPtr_GetSessionClientName_Internal_String_RemotePlaySessionID_t_0;

		// Token: 0x04000641 RID: 1601
		private static readonly IntPtr NativeMethodInfoPtr__GetSessionClientFormFactor_Private_Static_SteamDeviceFormFactor_IntPtr_RemotePlaySessionID_t_0;

		// Token: 0x04000642 RID: 1602
		private static readonly IntPtr NativeMethodInfoPtr_GetSessionClientFormFactor_Internal_SteamDeviceFormFactor_RemotePlaySessionID_t_0;

		// Token: 0x04000643 RID: 1603
		private static readonly IntPtr NativeMethodInfoPtr__BGetSessionClientResolution_Private_Static_Boolean_IntPtr_RemotePlaySessionID_t_byref_Int32_byref_Int32_0;

		// Token: 0x04000644 RID: 1604
		private static readonly IntPtr NativeMethodInfoPtr_BGetSessionClientResolution_Internal_Boolean_RemotePlaySessionID_t_byref_Int32_byref_Int32_0;

		// Token: 0x04000645 RID: 1605
		private static readonly IntPtr NativeMethodInfoPtr__BSendRemotePlayTogetherInvite_Private_Static_Boolean_IntPtr_SteamId_0;

		// Token: 0x04000646 RID: 1606
		private static readonly IntPtr NativeMethodInfoPtr_BSendRemotePlayTogetherInvite_Internal_Boolean_SteamId_0;
	}
}
