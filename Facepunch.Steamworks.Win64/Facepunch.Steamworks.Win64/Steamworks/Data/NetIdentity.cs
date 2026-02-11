using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001BA RID: 442
	[StructLayout(2)]
	public struct NetIdentity
	{
		// Token: 0x06001658 RID: 5720 RVA: 0x0006E9AC File Offset: 0x0006CBAC
		// Note: this type is marked as 'beforefieldinit'.
		static NetIdentity()
		{
			Il2CppClassPointerStore<NetIdentity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "NetIdentity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetIdentity>.NativeClassPtr);
			NetIdentity.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetIdentity>.NativeClassPtr, "type");
			NetIdentity.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetIdentity>.NativeClassPtr, "size");
			NetIdentity.NativeFieldInfoPtr_steamid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetIdentity>.NativeClassPtr, "steamid");
			NetIdentity.NativeFieldInfoPtr_netaddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetIdentity>.NativeClassPtr, "netaddress");
			NetIdentity.NativeMethodInfoPtr_InternalClear_Internal_Static_Void_byref_NetIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetIdentity>.NativeClassPtr, 100667416);
			NetIdentity.NativeMethodInfoPtr_InternalIsInvalid_Internal_Static_Boolean_byref_NetIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetIdentity>.NativeClassPtr, 100667417);
			NetIdentity.NativeMethodInfoPtr_InternalSetSteamID_Internal_Static_Void_byref_NetIdentity_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetIdentity>.NativeClassPtr, 100667418);
			NetIdentity.NativeMethodInfoPtr_InternalGetSteamID_Internal_Static_SteamId_byref_NetIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetIdentity>.NativeClassPtr, 100667419);
			NetIdentity.NativeMethodInfoPtr_InternalSetSteamID64_Internal_Static_Void_byref_NetIdentity_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetIdentity>.NativeClassPtr, 100667420);
			NetIdentity.NativeMethodInfoPtr_InternalGetSteamID64_Internal_Static_UInt64_byref_NetIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetIdentity>.NativeClassPtr, 100667421);
			NetIdentity.NativeMethodInfoPtr_InternalSetXboxPairwiseID_Internal_Static_Boolean_byref_NetIdentity_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetIdentity>.NativeClassPtr, 100667422);
			NetIdentity.NativeMethodInfoPtr_InternalGetXboxPairwiseID_Internal_Static_Utf8StringPointer_byref_NetIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetIdentity>.NativeClassPtr, 100667423);
			NetIdentity.NativeMethodInfoPtr_InternalSetPSNID_Internal_Static_Void_byref_NetIdentity_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetIdentity>.NativeClassPtr, 100667424);
			NetIdentity.NativeMethodInfoPtr_InternalGetPSNID_Internal_Static_UInt64_byref_NetIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetIdentity>.NativeClassPtr, 100667425);
			NetIdentity.NativeMethodInfoPtr_InternalSetStadiaID_Internal_Static_Void_byref_NetIdentity_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetIdentity>.NativeClassPtr, 100667426);
			NetIdentity.NativeMethodInfoPtr_InternalGetStadiaID_Internal_Static_UInt64_byref_NetIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetIdentity>.NativeClassPtr, 100667427);
			NetIdentity.NativeMethodInfoPtr_InternalSetIPAddr_Internal_Static_Void_byref_NetIdentity_byref_NetAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetIdentity>.NativeClassPtr, 100667428);
			NetIdentity.NativeMethodInfoPtr_InternalGetIPAddr_Internal_Static_IntPtr_byref_NetIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetIdentity>.NativeClassPtr, 100667429);
			NetIdentity.NativeMethodInfoPtr_InternalSetIPv4Addr_Internal_Static_Void_byref_NetIdentity_UInt32_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetIdentity>.NativeClassPtr, 100667430);
			NetIdentity.NativeMethodInfoPtr_InternalGetIPv4_Internal_Static_UInt32_byref_NetIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetIdentity>.NativeClassPtr, 100667431);
			NetIdentity.NativeMethodInfoPtr_InternalGetFakeIPType_Internal_Static_SteamNetworkingFakeIPType_byref_NetIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetIdentity>.NativeClassPtr, 100667432);
			NetIdentity.NativeMethodInfoPtr_InternalIsFakeIP_Internal_Static_Boolean_byref_NetIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetIdentity>.NativeClassPtr, 100667433);
			NetIdentity.NativeMethodInfoPtr_InternalSetLocalHost_Internal_Static_Void_byref_NetIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetIdentity>.NativeClassPtr, 100667434);
			NetIdentity.NativeMethodInfoPtr_InternalIsLocalHost_Internal_Static_Boolean_byref_NetIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetIdentity>.NativeClassPtr, 100667435);
			NetIdentity.NativeMethodInfoPtr_InternalSetGenericString_Internal_Static_Boolean_byref_NetIdentity_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetIdentity>.NativeClassPtr, 100667436);
			NetIdentity.NativeMethodInfoPtr_InternalGetGenericString_Internal_Static_Utf8StringPointer_byref_NetIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetIdentity>.NativeClassPtr, 100667437);
			NetIdentity.NativeMethodInfoPtr_InternalSetGenericBytes_Internal_Static_Boolean_byref_NetIdentity_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetIdentity>.NativeClassPtr, 100667438);
			NetIdentity.NativeMethodInfoPtr_InternalGetGenericBytes_Internal_Static_Byte_byref_NetIdentity_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetIdentity>.NativeClassPtr, 100667439);
			NetIdentity.NativeMethodInfoPtr_InternalIsEqualTo_Internal_Static_Boolean_byref_NetIdentity_byref_NetIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetIdentity>.NativeClassPtr, 100667440);
			NetIdentity.NativeMethodInfoPtr_InternalToString_Internal_Static_Void_byref_NetIdentity_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetIdentity>.NativeClassPtr, 100667441);
			NetIdentity.NativeMethodInfoPtr_InternalParseString_Internal_Static_Boolean_byref_NetIdentity_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetIdentity>.NativeClassPtr, 100667442);
			NetIdentity.NativeMethodInfoPtr_get_LocalHost_Public_Static_get_NetIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetIdentity>.NativeClassPtr, 100667443);
			NetIdentity.NativeMethodInfoPtr_get_IsSteamId_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetIdentity>.NativeClassPtr, 100667444);
			NetIdentity.NativeMethodInfoPtr_get_IsIpAddress_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetIdentity>.NativeClassPtr, 100667445);
			NetIdentity.NativeMethodInfoPtr_get_IsLocalHost_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetIdentity>.NativeClassPtr, 100667446);
			NetIdentity.NativeMethodInfoPtr_op_Implicit_Public_Static_NetIdentity_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetIdentity>.NativeClassPtr, 100667447);
			NetIdentity.NativeMethodInfoPtr_op_Implicit_Public_Static_NetIdentity_NetAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetIdentity>.NativeClassPtr, 100667448);
			NetIdentity.NativeMethodInfoPtr_op_Implicit_Public_Static_SteamId_NetIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetIdentity>.NativeClassPtr, 100667449);
			NetIdentity.NativeMethodInfoPtr_get_SteamId_Public_get_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetIdentity>.NativeClassPtr, 100667450);
			NetIdentity.NativeMethodInfoPtr_get_Address_Public_get_NetAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetIdentity>.NativeClassPtr, 100667451);
			NetIdentity.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetIdentity>.NativeClassPtr, 100667452);
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x0006ED10 File Offset: 0x0006CF10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951196, XrefRangeEnd = 951198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalClear(ref NetIdentity self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetIdentity.NativeMethodInfoPtr_InternalClear_Internal_Static_Void_byref_NetIdentity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600165A RID: 5722 RVA: 0x0006ED44 File Offset: 0x0006CF44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951198, XrefRangeEnd = 951200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InternalIsInvalid(ref NetIdentity self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetIdentity.NativeMethodInfoPtr_InternalIsInvalid_Internal_Static_Boolean_byref_NetIdentity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x0006ED84 File Offset: 0x0006CF84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951200, XrefRangeEnd = 951202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalSetSteamID(ref NetIdentity self, SteamId steamID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetIdentity.NativeMethodInfoPtr_InternalSetSteamID_Internal_Static_Void_byref_NetIdentity_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x0006EDC4 File Offset: 0x0006CFC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951202, XrefRangeEnd = 951204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamId InternalGetSteamID(ref NetIdentity self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetIdentity.NativeMethodInfoPtr_InternalGetSteamID_Internal_Static_SteamId_byref_NetIdentity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x0006EE04 File Offset: 0x0006D004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951204, XrefRangeEnd = 951206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalSetSteamID64(ref NetIdentity self, ulong steamID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetIdentity.NativeMethodInfoPtr_InternalSetSteamID64_Internal_Static_Void_byref_NetIdentity_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x0006EE44 File Offset: 0x0006D044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951206, XrefRangeEnd = 951208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong InternalGetSteamID64(ref NetIdentity self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetIdentity.NativeMethodInfoPtr_InternalGetSteamID64_Internal_Static_UInt64_byref_NetIdentity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600165F RID: 5727 RVA: 0x0006EE84 File Offset: 0x0006D084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951208, XrefRangeEnd = 951211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InternalSetXboxPairwiseID(ref NetIdentity self, string pszString)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pszString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetIdentity.NativeMethodInfoPtr_InternalSetXboxPairwiseID_Internal_Static_Boolean_byref_NetIdentity_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x0006EED4 File Offset: 0x0006D0D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951211, XrefRangeEnd = 951213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Utf8StringPointer InternalGetXboxPairwiseID(ref NetIdentity self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetIdentity.NativeMethodInfoPtr_InternalGetXboxPairwiseID_Internal_Static_Utf8StringPointer_byref_NetIdentity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x0006EF14 File Offset: 0x0006D114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951213, XrefRangeEnd = 951215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalSetPSNID(ref NetIdentity self, ulong id)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetIdentity.NativeMethodInfoPtr_InternalSetPSNID_Internal_Static_Void_byref_NetIdentity_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x0006EF54 File Offset: 0x0006D154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951215, XrefRangeEnd = 951217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong InternalGetPSNID(ref NetIdentity self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetIdentity.NativeMethodInfoPtr_InternalGetPSNID_Internal_Static_UInt64_byref_NetIdentity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x0006EF94 File Offset: 0x0006D194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951217, XrefRangeEnd = 951219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalSetStadiaID(ref NetIdentity self, ulong id)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetIdentity.NativeMethodInfoPtr_InternalSetStadiaID_Internal_Static_Void_byref_NetIdentity_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x0006EFD4 File Offset: 0x0006D1D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951219, XrefRangeEnd = 951221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong InternalGetStadiaID(ref NetIdentity self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetIdentity.NativeMethodInfoPtr_InternalGetStadiaID_Internal_Static_UInt64_byref_NetIdentity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001665 RID: 5733 RVA: 0x0006F014 File Offset: 0x0006D214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951221, XrefRangeEnd = 951223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalSetIPAddr(ref NetIdentity self, ref NetAddress addr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &addr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetIdentity.NativeMethodInfoPtr_InternalSetIPAddr_Internal_Static_Void_byref_NetIdentity_byref_NetAddress_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x0006F054 File Offset: 0x0006D254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951223, XrefRangeEnd = 951225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr InternalGetIPAddr(ref NetIdentity self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetIdentity.NativeMethodInfoPtr_InternalGetIPAddr_Internal_Static_IntPtr_byref_NetIdentity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x0006F094 File Offset: 0x0006D294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951225, XrefRangeEnd = 951227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalSetIPv4Addr(ref NetIdentity self, uint nIPv4, ushort nPort)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nIPv4;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nPort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetIdentity.NativeMethodInfoPtr_InternalSetIPv4Addr_Internal_Static_Void_byref_NetIdentity_UInt32_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x0006F0E4 File Offset: 0x0006D2E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951227, XrefRangeEnd = 951229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint InternalGetIPv4(ref NetIdentity self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetIdentity.NativeMethodInfoPtr_InternalGetIPv4_Internal_Static_UInt32_byref_NetIdentity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001669 RID: 5737 RVA: 0x0006F124 File Offset: 0x0006D324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951229, XrefRangeEnd = 951231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamNetworkingFakeIPType InternalGetFakeIPType(ref NetIdentity self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetIdentity.NativeMethodInfoPtr_InternalGetFakeIPType_Internal_Static_SteamNetworkingFakeIPType_byref_NetIdentity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x0006F164 File Offset: 0x0006D364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951231, XrefRangeEnd = 951233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InternalIsFakeIP(ref NetIdentity self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetIdentity.NativeMethodInfoPtr_InternalIsFakeIP_Internal_Static_Boolean_byref_NetIdentity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x0006F1A4 File Offset: 0x0006D3A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951233, XrefRangeEnd = 951235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalSetLocalHost(ref NetIdentity self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetIdentity.NativeMethodInfoPtr_InternalSetLocalHost_Internal_Static_Void_byref_NetIdentity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x0006F1D8 File Offset: 0x0006D3D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951235, XrefRangeEnd = 951237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InternalIsLocalHost(ref NetIdentity self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetIdentity.NativeMethodInfoPtr_InternalIsLocalHost_Internal_Static_Boolean_byref_NetIdentity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600166D RID: 5741 RVA: 0x0006F218 File Offset: 0x0006D418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951237, XrefRangeEnd = 951240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InternalSetGenericString(ref NetIdentity self, string pszString)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pszString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetIdentity.NativeMethodInfoPtr_InternalSetGenericString_Internal_Static_Boolean_byref_NetIdentity_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600166E RID: 5742 RVA: 0x0006F268 File Offset: 0x0006D468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951240, XrefRangeEnd = 951242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Utf8StringPointer InternalGetGenericString(ref NetIdentity self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetIdentity.NativeMethodInfoPtr_InternalGetGenericString_Internal_Static_Utf8StringPointer_byref_NetIdentity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600166F RID: 5743 RVA: 0x0006F2A8 File Offset: 0x0006D4A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951242, XrefRangeEnd = 951244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InternalSetGenericBytes(ref NetIdentity self, IntPtr data, uint cbLen)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbLen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetIdentity.NativeMethodInfoPtr_InternalSetGenericBytes_Internal_Static_Boolean_byref_NetIdentity_IntPtr_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x0006F304 File Offset: 0x0006D504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951244, XrefRangeEnd = 951246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte InternalGetGenericBytes(ref NetIdentity self, ref int cbLen)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cbLen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetIdentity.NativeMethodInfoPtr_InternalGetGenericBytes_Internal_Static_Byte_byref_NetIdentity_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001671 RID: 5745 RVA: 0x0006F350 File Offset: 0x0006D550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951246, XrefRangeEnd = 951248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InternalIsEqualTo(ref NetIdentity self, ref NetIdentity x)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetIdentity.NativeMethodInfoPtr_InternalIsEqualTo_Internal_Static_Boolean_byref_NetIdentity_byref_NetIdentity_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x0006F39C File Offset: 0x0006D59C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951248, XrefRangeEnd = 951250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalToString(ref NetIdentity self, IntPtr buf, uint cbBuf)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buf;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbBuf;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetIdentity.NativeMethodInfoPtr_InternalToString_Internal_Static_Void_byref_NetIdentity_IntPtr_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x0006F3EC File Offset: 0x0006D5EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951250, XrefRangeEnd = 951253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InternalParseString(ref NetIdentity self, string pszStr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pszStr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetIdentity.NativeMethodInfoPtr_InternalParseString_Internal_Static_Boolean_byref_NetIdentity_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06001674 RID: 5748 RVA: 0x0006F43C File Offset: 0x0006D63C
		public unsafe static NetIdentity LocalHost
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951253, XrefRangeEnd = 951255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetIdentity.NativeMethodInfoPtr_get_LocalHost_Public_Static_get_NetIdentity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06001675 RID: 5749 RVA: 0x0006F46C File Offset: 0x0006D66C
		public unsafe bool IsSteamId
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetIdentity.NativeMethodInfoPtr_get_IsSteamId_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06001676 RID: 5750 RVA: 0x0006F49C File Offset: 0x0006D69C
		public unsafe bool IsIpAddress
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetIdentity.NativeMethodInfoPtr_get_IsIpAddress_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06001677 RID: 5751 RVA: 0x0006F4CC File Offset: 0x0006D6CC
		public unsafe bool IsLocalHost
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951255, XrefRangeEnd = 951257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetIdentity.NativeMethodInfoPtr_get_IsLocalHost_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001678 RID: 5752 RVA: 0x0006F4FC File Offset: 0x0006D6FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 951259, RefRangeEnd = 951261, XrefRangeStart = 951257, XrefRangeEnd = 951259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator NetIdentity(SteamId value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetIdentity.NativeMethodInfoPtr_op_Implicit_Public_Static_NetIdentity_SteamId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001679 RID: 5753 RVA: 0x0006F53C File Offset: 0x0006D73C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951261, XrefRangeEnd = 951263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator NetIdentity(NetAddress address)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref address;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetIdentity.NativeMethodInfoPtr_op_Implicit_Public_Static_NetIdentity_NetAddress_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600167A RID: 5754 RVA: 0x0006F57C File Offset: 0x0006D77C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951263, XrefRangeEnd = 951264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SteamId(NetIdentity value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetIdentity.NativeMethodInfoPtr_op_Implicit_Public_Static_SteamId_NetIdentity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x0600167B RID: 5755 RVA: 0x0006F5BC File Offset: 0x0006D7BC
		public unsafe SteamId SteamId
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 951266, RefRangeEnd = 951267, XrefRangeStart = 951264, XrefRangeEnd = 951266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetIdentity.NativeMethodInfoPtr_get_SteamId_Public_get_SteamId_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x0600167C RID: 5756 RVA: 0x0006F5EC File Offset: 0x0006D7EC
		public unsafe NetAddress Address
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951267, XrefRangeEnd = 951276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetIdentity.NativeMethodInfoPtr_get_Address_Public_get_NetAddress_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600167D RID: 5757 RVA: 0x0006F61C File Offset: 0x0006D81C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951276, XrefRangeEnd = 951281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetIdentity.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x00007724 File Offset: 0x00005924
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NetIdentity>.NativeClassPtr, ref this));
		}

		// Token: 0x04001BA2 RID: 7074
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04001BA3 RID: 7075
		private static readonly IntPtr NativeFieldInfoPtr_size;

		// Token: 0x04001BA4 RID: 7076
		private static readonly IntPtr NativeFieldInfoPtr_steamid;

		// Token: 0x04001BA5 RID: 7077
		private static readonly IntPtr NativeFieldInfoPtr_netaddress;

		// Token: 0x04001BA6 RID: 7078
		private static readonly IntPtr NativeMethodInfoPtr_InternalClear_Internal_Static_Void_byref_NetIdentity_0;

		// Token: 0x04001BA7 RID: 7079
		private static readonly IntPtr NativeMethodInfoPtr_InternalIsInvalid_Internal_Static_Boolean_byref_NetIdentity_0;

		// Token: 0x04001BA8 RID: 7080
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetSteamID_Internal_Static_Void_byref_NetIdentity_SteamId_0;

		// Token: 0x04001BA9 RID: 7081
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetSteamID_Internal_Static_SteamId_byref_NetIdentity_0;

		// Token: 0x04001BAA RID: 7082
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetSteamID64_Internal_Static_Void_byref_NetIdentity_UInt64_0;

		// Token: 0x04001BAB RID: 7083
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetSteamID64_Internal_Static_UInt64_byref_NetIdentity_0;

		// Token: 0x04001BAC RID: 7084
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetXboxPairwiseID_Internal_Static_Boolean_byref_NetIdentity_String_0;

		// Token: 0x04001BAD RID: 7085
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetXboxPairwiseID_Internal_Static_Utf8StringPointer_byref_NetIdentity_0;

		// Token: 0x04001BAE RID: 7086
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetPSNID_Internal_Static_Void_byref_NetIdentity_UInt64_0;

		// Token: 0x04001BAF RID: 7087
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetPSNID_Internal_Static_UInt64_byref_NetIdentity_0;

		// Token: 0x04001BB0 RID: 7088
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetStadiaID_Internal_Static_Void_byref_NetIdentity_UInt64_0;

		// Token: 0x04001BB1 RID: 7089
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetStadiaID_Internal_Static_UInt64_byref_NetIdentity_0;

		// Token: 0x04001BB2 RID: 7090
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetIPAddr_Internal_Static_Void_byref_NetIdentity_byref_NetAddress_0;

		// Token: 0x04001BB3 RID: 7091
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetIPAddr_Internal_Static_IntPtr_byref_NetIdentity_0;

		// Token: 0x04001BB4 RID: 7092
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetIPv4Addr_Internal_Static_Void_byref_NetIdentity_UInt32_UInt16_0;

		// Token: 0x04001BB5 RID: 7093
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetIPv4_Internal_Static_UInt32_byref_NetIdentity_0;

		// Token: 0x04001BB6 RID: 7094
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetFakeIPType_Internal_Static_SteamNetworkingFakeIPType_byref_NetIdentity_0;

		// Token: 0x04001BB7 RID: 7095
		private static readonly IntPtr NativeMethodInfoPtr_InternalIsFakeIP_Internal_Static_Boolean_byref_NetIdentity_0;

		// Token: 0x04001BB8 RID: 7096
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetLocalHost_Internal_Static_Void_byref_NetIdentity_0;

		// Token: 0x04001BB9 RID: 7097
		private static readonly IntPtr NativeMethodInfoPtr_InternalIsLocalHost_Internal_Static_Boolean_byref_NetIdentity_0;

		// Token: 0x04001BBA RID: 7098
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetGenericString_Internal_Static_Boolean_byref_NetIdentity_String_0;

		// Token: 0x04001BBB RID: 7099
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetGenericString_Internal_Static_Utf8StringPointer_byref_NetIdentity_0;

		// Token: 0x04001BBC RID: 7100
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetGenericBytes_Internal_Static_Boolean_byref_NetIdentity_IntPtr_UInt32_0;

		// Token: 0x04001BBD RID: 7101
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetGenericBytes_Internal_Static_Byte_byref_NetIdentity_byref_Int32_0;

		// Token: 0x04001BBE RID: 7102
		private static readonly IntPtr NativeMethodInfoPtr_InternalIsEqualTo_Internal_Static_Boolean_byref_NetIdentity_byref_NetIdentity_0;

		// Token: 0x04001BBF RID: 7103
		private static readonly IntPtr NativeMethodInfoPtr_InternalToString_Internal_Static_Void_byref_NetIdentity_IntPtr_UInt32_0;

		// Token: 0x04001BC0 RID: 7104
		private static readonly IntPtr NativeMethodInfoPtr_InternalParseString_Internal_Static_Boolean_byref_NetIdentity_String_0;

		// Token: 0x04001BC1 RID: 7105
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalHost_Public_Static_get_NetIdentity_0;

		// Token: 0x04001BC2 RID: 7106
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSteamId_Public_get_Boolean_0;

		// Token: 0x04001BC3 RID: 7107
		private static readonly IntPtr NativeMethodInfoPtr_get_IsIpAddress_Public_get_Boolean_0;

		// Token: 0x04001BC4 RID: 7108
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLocalHost_Public_get_Boolean_0;

		// Token: 0x04001BC5 RID: 7109
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_NetIdentity_SteamId_0;

		// Token: 0x04001BC6 RID: 7110
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_NetIdentity_NetAddress_0;

		// Token: 0x04001BC7 RID: 7111
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SteamId_NetIdentity_0;

		// Token: 0x04001BC8 RID: 7112
		private static readonly IntPtr NativeMethodInfoPtr_get_SteamId_Public_get_SteamId_0;

		// Token: 0x04001BC9 RID: 7113
		private static readonly IntPtr NativeMethodInfoPtr_get_Address_Public_get_NetAddress_0;

		// Token: 0x04001BCA RID: 7114
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001BCB RID: 7115
		[FieldOffset(0)]
		public NetIdentity.IdentityType type;

		// Token: 0x04001BCC RID: 7116
		[FieldOffset(4)]
		public int size;

		// Token: 0x04001BCD RID: 7117
		[FieldOffset(8)]
		public ulong steamid;

		// Token: 0x04001BCE RID: 7118
		[FieldOffset(8)]
		public NetAddress netaddress;

		// Token: 0x0200029D RID: 669
		public enum IdentityType
		{
			// Token: 0x04002393 RID: 9107
			Invalid,
			// Token: 0x04002394 RID: 9108
			IPAddress,
			// Token: 0x04002395 RID: 9109
			GenericString,
			// Token: 0x04002396 RID: 9110
			GenericBytes,
			// Token: 0x04002397 RID: 9111
			SteamID = 16
		}
	}
}
