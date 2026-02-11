using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Net;

namespace Steamworks.Data
{
	// Token: 0x020001BB RID: 443
	[StructLayout(2)]
	public struct NetAddress
	{
		// Token: 0x0600167F RID: 5759 RVA: 0x0006F648 File Offset: 0x0006D848
		// Note: this type is marked as 'beforefieldinit'.
		static NetAddress()
		{
			Il2CppClassPointerStore<NetAddress>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "NetAddress");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetAddress>.NativeClassPtr);
			NetAddress.NativeFieldInfoPtr_ip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetAddress>.NativeClassPtr, "ip");
			NetAddress.NativeFieldInfoPtr_port = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetAddress>.NativeClassPtr, "port");
			NetAddress.NativeMethodInfoPtr_InternalClear_Internal_Static_Void_byref_NetAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetAddress>.NativeClassPtr, 100667453);
			NetAddress.NativeMethodInfoPtr_InternalIsIPv6AllZeros_Internal_Static_Boolean_byref_NetAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetAddress>.NativeClassPtr, 100667454);
			NetAddress.NativeMethodInfoPtr_InternalSetIPv6_Internal_Static_Void_byref_NetAddress_byref_Byte_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetAddress>.NativeClassPtr, 100667455);
			NetAddress.NativeMethodInfoPtr_InternalSetIPv4_Internal_Static_Void_byref_NetAddress_UInt32_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetAddress>.NativeClassPtr, 100667456);
			NetAddress.NativeMethodInfoPtr_InternalIsIPv4_Internal_Static_Boolean_byref_NetAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetAddress>.NativeClassPtr, 100667457);
			NetAddress.NativeMethodInfoPtr_InternalGetIPv4_Internal_Static_UInt32_byref_NetAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetAddress>.NativeClassPtr, 100667458);
			NetAddress.NativeMethodInfoPtr_InternalSetIPv6LocalHost_Internal_Static_Void_byref_NetAddress_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetAddress>.NativeClassPtr, 100667459);
			NetAddress.NativeMethodInfoPtr_InternalIsLocalHost_Internal_Static_Boolean_byref_NetAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetAddress>.NativeClassPtr, 100667460);
			NetAddress.NativeMethodInfoPtr_InternalToString_Internal_Static_Void_byref_NetAddress_IntPtr_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetAddress>.NativeClassPtr, 100667461);
			NetAddress.NativeMethodInfoPtr_InternalParseString_Internal_Static_Boolean_byref_NetAddress_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetAddress>.NativeClassPtr, 100667462);
			NetAddress.NativeMethodInfoPtr_InternalIsEqualTo_Internal_Static_Boolean_byref_NetAddress_byref_NetAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetAddress>.NativeClassPtr, 100667463);
			NetAddress.NativeMethodInfoPtr_InternalGetFakeIPType_Internal_Static_SteamNetworkingFakeIPType_byref_NetAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetAddress>.NativeClassPtr, 100667464);
			NetAddress.NativeMethodInfoPtr_InternalIsFakeIP_Internal_Static_Boolean_byref_NetAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetAddress>.NativeClassPtr, 100667465);
			NetAddress.NativeMethodInfoPtr_get_Port_Public_get_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetAddress>.NativeClassPtr, 100667466);
			NetAddress.NativeMethodInfoPtr_AnyIp_Public_Static_NetAddress_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetAddress>.NativeClassPtr, 100667467);
			NetAddress.NativeMethodInfoPtr_LocalHost_Public_Static_NetAddress_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetAddress>.NativeClassPtr, 100667468);
			NetAddress.NativeMethodInfoPtr_From_Public_Static_NetAddress_String_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetAddress>.NativeClassPtr, 100667469);
			NetAddress.NativeMethodInfoPtr_From_Public_Static_NetAddress_IPAddress_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetAddress>.NativeClassPtr, 100667470);
			NetAddress.NativeMethodInfoPtr_get_Cleared_Public_Static_get_NetAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetAddress>.NativeClassPtr, 100667471);
			NetAddress.NativeMethodInfoPtr_get_IsIPv6AllZeros_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetAddress>.NativeClassPtr, 100667472);
			NetAddress.NativeMethodInfoPtr_get_IsIPv4_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetAddress>.NativeClassPtr, 100667473);
			NetAddress.NativeMethodInfoPtr_get_IsFakeIPv4_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetAddress>.NativeClassPtr, 100667474);
			NetAddress.NativeMethodInfoPtr_get_IsLocalHost_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetAddress>.NativeClassPtr, 100667475);
			NetAddress.NativeMethodInfoPtr_get_Address_Public_get_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetAddress>.NativeClassPtr, 100667476);
			NetAddress.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetAddress>.NativeClassPtr, 100667477);
		}

		// Token: 0x06001680 RID: 5760 RVA: 0x0006F894 File Offset: 0x0006DA94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951281, XrefRangeEnd = 951283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalClear(ref NetAddress self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetAddress.NativeMethodInfoPtr_InternalClear_Internal_Static_Void_byref_NetAddress_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001681 RID: 5761 RVA: 0x0006F8C8 File Offset: 0x0006DAC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951283, XrefRangeEnd = 951285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InternalIsIPv6AllZeros(ref NetAddress self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetAddress.NativeMethodInfoPtr_InternalIsIPv6AllZeros_Internal_Static_Boolean_byref_NetAddress_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x0006F908 File Offset: 0x0006DB08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951285, XrefRangeEnd = 951287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalSetIPv6(ref NetAddress self, ref byte ipv6, ushort nPort)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ipv6;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nPort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetAddress.NativeMethodInfoPtr_InternalSetIPv6_Internal_Static_Void_byref_NetAddress_byref_Byte_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x0006F958 File Offset: 0x0006DB58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951287, XrefRangeEnd = 951289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalSetIPv4(ref NetAddress self, uint nIP, ushort nPort)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nIP;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nPort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetAddress.NativeMethodInfoPtr_InternalSetIPv4_Internal_Static_Void_byref_NetAddress_UInt32_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x0006F9A8 File Offset: 0x0006DBA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951289, XrefRangeEnd = 951291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InternalIsIPv4(ref NetAddress self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetAddress.NativeMethodInfoPtr_InternalIsIPv4_Internal_Static_Boolean_byref_NetAddress_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x0006F9E8 File Offset: 0x0006DBE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951291, XrefRangeEnd = 951293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint InternalGetIPv4(ref NetAddress self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetAddress.NativeMethodInfoPtr_InternalGetIPv4_Internal_Static_UInt32_byref_NetAddress_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001686 RID: 5766 RVA: 0x0006FA28 File Offset: 0x0006DC28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951293, XrefRangeEnd = 951295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalSetIPv6LocalHost(ref NetAddress self, ushort nPort)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nPort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetAddress.NativeMethodInfoPtr_InternalSetIPv6LocalHost_Internal_Static_Void_byref_NetAddress_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001687 RID: 5767 RVA: 0x0006FA68 File Offset: 0x0006DC68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951295, XrefRangeEnd = 951297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InternalIsLocalHost(ref NetAddress self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetAddress.NativeMethodInfoPtr_InternalIsLocalHost_Internal_Static_Boolean_byref_NetAddress_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x0006FAA8 File Offset: 0x0006DCA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951297, XrefRangeEnd = 951299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalToString(ref NetAddress self, IntPtr buf, uint cbBuf, bool bWithPort)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buf;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbBuf;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bWithPort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetAddress.NativeMethodInfoPtr_InternalToString_Internal_Static_Void_byref_NetAddress_IntPtr_UInt32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001689 RID: 5769 RVA: 0x0006FB04 File Offset: 0x0006DD04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951299, XrefRangeEnd = 951302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InternalParseString(ref NetAddress self, string pszStr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pszStr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetAddress.NativeMethodInfoPtr_InternalParseString_Internal_Static_Boolean_byref_NetAddress_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600168A RID: 5770 RVA: 0x0006FB54 File Offset: 0x0006DD54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951302, XrefRangeEnd = 951304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InternalIsEqualTo(ref NetAddress self, ref NetAddress x)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetAddress.NativeMethodInfoPtr_InternalIsEqualTo_Internal_Static_Boolean_byref_NetAddress_byref_NetAddress_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x0006FBA0 File Offset: 0x0006DDA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951304, XrefRangeEnd = 951306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamNetworkingFakeIPType InternalGetFakeIPType(ref NetAddress self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetAddress.NativeMethodInfoPtr_InternalGetFakeIPType_Internal_Static_SteamNetworkingFakeIPType_byref_NetAddress_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x0006FBE0 File Offset: 0x0006DDE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951306, XrefRangeEnd = 951308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InternalIsFakeIP(ref NetAddress self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetAddress.NativeMethodInfoPtr_InternalIsFakeIP_Internal_Static_Boolean_byref_NetAddress_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x0600168D RID: 5773 RVA: 0x0006FC20 File Offset: 0x0006DE20
		public unsafe ushort Port
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetAddress.NativeMethodInfoPtr_get_Port_Public_get_UInt16_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x0006FC50 File Offset: 0x0006DE50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951308, XrefRangeEnd = 951310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NetAddress AnyIp(ushort port)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref port;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetAddress.NativeMethodInfoPtr_AnyIp_Public_Static_NetAddress_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600168F RID: 5775 RVA: 0x0006FC90 File Offset: 0x0006DE90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951310, XrefRangeEnd = 951314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NetAddress LocalHost(ushort port)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref port;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetAddress.NativeMethodInfoPtr_LocalHost_Public_Static_NetAddress_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x0006FCD0 File Offset: 0x0006DED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951314, XrefRangeEnd = 951328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NetAddress From(string addrStr, ushort port)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(addrStr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetAddress.NativeMethodInfoPtr_From_Public_Static_NetAddress_String_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001691 RID: 5777 RVA: 0x0006FD20 File Offset: 0x0006DF20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 951338, RefRangeEnd = 951340, XrefRangeStart = 951328, XrefRangeEnd = 951338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NetAddress From(IPAddress address, ushort port)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(address);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetAddress.NativeMethodInfoPtr_From_Public_Static_NetAddress_IPAddress_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06001692 RID: 5778 RVA: 0x0006FD70 File Offset: 0x0006DF70
		public unsafe static NetAddress Cleared
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951340, XrefRangeEnd = 951342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetAddress.NativeMethodInfoPtr_get_Cleared_Public_Static_get_NetAddress_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06001693 RID: 5779 RVA: 0x0006FDA0 File Offset: 0x0006DFA0
		public unsafe bool IsIPv6AllZeros
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 951344, RefRangeEnd = 951345, XrefRangeStart = 951342, XrefRangeEnd = 951344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetAddress.NativeMethodInfoPtr_get_IsIPv6AllZeros_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06001694 RID: 5780 RVA: 0x0006FDD0 File Offset: 0x0006DFD0
		public unsafe bool IsIPv4
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 951347, RefRangeEnd = 951348, XrefRangeStart = 951345, XrefRangeEnd = 951347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetAddress.NativeMethodInfoPtr_get_IsIPv4_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06001695 RID: 5781 RVA: 0x0006FE00 File Offset: 0x0006E000
		public unsafe bool IsFakeIPv4
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951348, XrefRangeEnd = 951355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetAddress.NativeMethodInfoPtr_get_IsFakeIPv4_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06001696 RID: 5782 RVA: 0x0006FE30 File Offset: 0x0006E030
		public unsafe bool IsLocalHost
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951355, XrefRangeEnd = 951357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetAddress.NativeMethodInfoPtr_get_IsLocalHost_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06001697 RID: 5783 RVA: 0x0006FE60 File Offset: 0x0006E060
		public unsafe IPAddress Address
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951357, XrefRangeEnd = 951364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetAddress.NativeMethodInfoPtr_get_Address_Public_get_IPAddress_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr3) : null;
			}
		}

		// Token: 0x06001698 RID: 5784 RVA: 0x0006FE94 File Offset: 0x0006E094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951364, XrefRangeEnd = 951385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetAddress.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x00007736 File Offset: 0x00005936
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NetAddress>.NativeClassPtr, ref this));
		}

		// Token: 0x04001BCF RID: 7119
		private static readonly IntPtr NativeFieldInfoPtr_ip;

		// Token: 0x04001BD0 RID: 7120
		private static readonly IntPtr NativeFieldInfoPtr_port;

		// Token: 0x04001BD1 RID: 7121
		private static readonly IntPtr NativeMethodInfoPtr_InternalClear_Internal_Static_Void_byref_NetAddress_0;

		// Token: 0x04001BD2 RID: 7122
		private static readonly IntPtr NativeMethodInfoPtr_InternalIsIPv6AllZeros_Internal_Static_Boolean_byref_NetAddress_0;

		// Token: 0x04001BD3 RID: 7123
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetIPv6_Internal_Static_Void_byref_NetAddress_byref_Byte_UInt16_0;

		// Token: 0x04001BD4 RID: 7124
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetIPv4_Internal_Static_Void_byref_NetAddress_UInt32_UInt16_0;

		// Token: 0x04001BD5 RID: 7125
		private static readonly IntPtr NativeMethodInfoPtr_InternalIsIPv4_Internal_Static_Boolean_byref_NetAddress_0;

		// Token: 0x04001BD6 RID: 7126
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetIPv4_Internal_Static_UInt32_byref_NetAddress_0;

		// Token: 0x04001BD7 RID: 7127
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetIPv6LocalHost_Internal_Static_Void_byref_NetAddress_UInt16_0;

		// Token: 0x04001BD8 RID: 7128
		private static readonly IntPtr NativeMethodInfoPtr_InternalIsLocalHost_Internal_Static_Boolean_byref_NetAddress_0;

		// Token: 0x04001BD9 RID: 7129
		private static readonly IntPtr NativeMethodInfoPtr_InternalToString_Internal_Static_Void_byref_NetAddress_IntPtr_UInt32_Boolean_0;

		// Token: 0x04001BDA RID: 7130
		private static readonly IntPtr NativeMethodInfoPtr_InternalParseString_Internal_Static_Boolean_byref_NetAddress_String_0;

		// Token: 0x04001BDB RID: 7131
		private static readonly IntPtr NativeMethodInfoPtr_InternalIsEqualTo_Internal_Static_Boolean_byref_NetAddress_byref_NetAddress_0;

		// Token: 0x04001BDC RID: 7132
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetFakeIPType_Internal_Static_SteamNetworkingFakeIPType_byref_NetAddress_0;

		// Token: 0x04001BDD RID: 7133
		private static readonly IntPtr NativeMethodInfoPtr_InternalIsFakeIP_Internal_Static_Boolean_byref_NetAddress_0;

		// Token: 0x04001BDE RID: 7134
		private static readonly IntPtr NativeMethodInfoPtr_get_Port_Public_get_UInt16_0;

		// Token: 0x04001BDF RID: 7135
		private static readonly IntPtr NativeMethodInfoPtr_AnyIp_Public_Static_NetAddress_UInt16_0;

		// Token: 0x04001BE0 RID: 7136
		private static readonly IntPtr NativeMethodInfoPtr_LocalHost_Public_Static_NetAddress_UInt16_0;

		// Token: 0x04001BE1 RID: 7137
		private static readonly IntPtr NativeMethodInfoPtr_From_Public_Static_NetAddress_String_UInt16_0;

		// Token: 0x04001BE2 RID: 7138
		private static readonly IntPtr NativeMethodInfoPtr_From_Public_Static_NetAddress_IPAddress_UInt16_0;

		// Token: 0x04001BE3 RID: 7139
		private static readonly IntPtr NativeMethodInfoPtr_get_Cleared_Public_Static_get_NetAddress_0;

		// Token: 0x04001BE4 RID: 7140
		private static readonly IntPtr NativeMethodInfoPtr_get_IsIPv6AllZeros_Public_get_Boolean_0;

		// Token: 0x04001BE5 RID: 7141
		private static readonly IntPtr NativeMethodInfoPtr_get_IsIPv4_Public_get_Boolean_0;

		// Token: 0x04001BE6 RID: 7142
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFakeIPv4_Public_get_Boolean_0;

		// Token: 0x04001BE7 RID: 7143
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLocalHost_Public_get_Boolean_0;

		// Token: 0x04001BE8 RID: 7144
		private static readonly IntPtr NativeMethodInfoPtr_get_Address_Public_get_IPAddress_0;

		// Token: 0x04001BE9 RID: 7145
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001BEA RID: 7146
		[FieldOffset(0)]
		public NetAddress.IPV4 ip;

		// Token: 0x04001BEB RID: 7147
		[FieldOffset(16)]
		public ushort port;

		// Token: 0x0200029E RID: 670
		[StructLayout(2)]
		public struct IPV4
		{
			// Token: 0x060021F9 RID: 8697 RVA: 0x000928CC File Offset: 0x00090ACC
			// Note: this type is marked as 'beforefieldinit'.
			static IPV4()
			{
				Il2CppClassPointerStore<NetAddress.IPV4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NetAddress>.NativeClassPtr, "IPV4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetAddress.IPV4>.NativeClassPtr);
				NetAddress.IPV4.NativeFieldInfoPtr_m_8zeros = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetAddress.IPV4>.NativeClassPtr, "m_8zeros");
				NetAddress.IPV4.NativeFieldInfoPtr_m_0000 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetAddress.IPV4>.NativeClassPtr, "m_0000");
				NetAddress.IPV4.NativeFieldInfoPtr_m_ffff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetAddress.IPV4>.NativeClassPtr, "m_ffff");
				NetAddress.IPV4.NativeFieldInfoPtr_ip0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetAddress.IPV4>.NativeClassPtr, "ip0");
				NetAddress.IPV4.NativeFieldInfoPtr_ip1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetAddress.IPV4>.NativeClassPtr, "ip1");
				NetAddress.IPV4.NativeFieldInfoPtr_ip2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetAddress.IPV4>.NativeClassPtr, "ip2");
				NetAddress.IPV4.NativeFieldInfoPtr_ip3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetAddress.IPV4>.NativeClassPtr, "ip3");
			}

			// Token: 0x060021FA RID: 8698 RVA: 0x0000DAA3 File Offset: 0x0000BCA3
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NetAddress.IPV4>.NativeClassPtr, ref this));
			}

			// Token: 0x04002398 RID: 9112
			private static readonly IntPtr NativeFieldInfoPtr_m_8zeros;

			// Token: 0x04002399 RID: 9113
			private static readonly IntPtr NativeFieldInfoPtr_m_0000;

			// Token: 0x0400239A RID: 9114
			private static readonly IntPtr NativeFieldInfoPtr_m_ffff;

			// Token: 0x0400239B RID: 9115
			private static readonly IntPtr NativeFieldInfoPtr_ip0;

			// Token: 0x0400239C RID: 9116
			private static readonly IntPtr NativeFieldInfoPtr_ip1;

			// Token: 0x0400239D RID: 9117
			private static readonly IntPtr NativeFieldInfoPtr_ip2;

			// Token: 0x0400239E RID: 9118
			private static readonly IntPtr NativeFieldInfoPtr_ip3;

			// Token: 0x0400239F RID: 9119
			[FieldOffset(0)]
			public ulong m_8zeros;

			// Token: 0x040023A0 RID: 9120
			[FieldOffset(8)]
			public ushort m_0000;

			// Token: 0x040023A1 RID: 9121
			[FieldOffset(10)]
			public ushort m_ffff;

			// Token: 0x040023A2 RID: 9122
			[FieldOffset(12)]
			public byte ip0;

			// Token: 0x040023A3 RID: 9123
			[FieldOffset(13)]
			public byte ip1;

			// Token: 0x040023A4 RID: 9124
			[FieldOffset(14)]
			public byte ip2;

			// Token: 0x040023A5 RID: 9125
			[FieldOffset(15)]
			public byte ip3;
		}
	}
}
