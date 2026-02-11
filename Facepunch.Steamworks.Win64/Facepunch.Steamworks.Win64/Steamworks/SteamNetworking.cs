using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x020000A5 RID: 165
	public class SteamNetworking : SteamSharedClass<SteamNetworking>
	{
		// Token: 0x060009A5 RID: 2469 RVA: 0x00047684 File Offset: 0x00045884
		// Note: this type is marked as 'beforefieldinit'.
		static SteamNetworking()
		{
			Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "SteamNetworking");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr);
			SteamNetworking.NativeFieldInfoPtr_OnP2PSessionRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr, "OnP2PSessionRequest");
			SteamNetworking.NativeFieldInfoPtr_OnP2PConnectionFailed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr, "OnP2PConnectionFailed");
			SteamNetworking.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamNetworking_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr, 100665676);
			SteamNetworking.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr, 100665677);
			SteamNetworking.NativeMethodInfoPtr_InstallEvents_Internal_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr, 100665678);
			SteamNetworking.NativeMethodInfoPtr_AcceptP2PSessionWithUser_Public_Static_Boolean_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr, 100665679);
			SteamNetworking.NativeMethodInfoPtr_AllowP2PPacketRelay_Public_Static_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr, 100665680);
			SteamNetworking.NativeMethodInfoPtr_CloseP2PSessionWithUser_Public_Static_Boolean_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr, 100665681);
			SteamNetworking.NativeMethodInfoPtr_IsP2PPacketAvailable_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr, 100665682);
			SteamNetworking.NativeMethodInfoPtr_IsP2PPacketAvailable_Public_Static_Boolean_byref_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr, 100665683);
			SteamNetworking.NativeMethodInfoPtr_ReadP2PPacket_Public_Static_Nullable_1_P2Packet_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr, 100665684);
			SteamNetworking.NativeMethodInfoPtr_ReadP2PPacket_Public_Static_Boolean_Il2CppStructArray_1_Byte_byref_UInt32_byref_SteamId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr, 100665685);
			SteamNetworking.NativeMethodInfoPtr_ReadP2PPacket_Public_Static_Boolean_ptr_Byte_UInt32_byref_UInt32_byref_SteamId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr, 100665686);
			SteamNetworking.NativeMethodInfoPtr_SendP2PPacket_Public_Static_Boolean_SteamId_Il2CppStructArray_1_Byte_Int32_Int32_P2PSend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr, 100665687);
			SteamNetworking.NativeMethodInfoPtr_SendP2PPacket_Public_Static_Boolean_SteamId_ptr_Byte_UInt32_Int32_P2PSend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr, 100665688);
			SteamNetworking.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr, 100665689);
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060009A6 RID: 2470 RVA: 0x000477F4 File Offset: 0x000459F4
		public unsafe static ISteamNetworking Internal
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 940802, RefRangeEnd = 940814, XrefRangeStart = 940798, XrefRangeEnd = 940802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworking.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamNetworking_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISteamNetworking>(intPtr3) : null;
			}
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x00047828 File Offset: 0x00045A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940814, XrefRangeEnd = 940819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeInterface(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref server;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamNetworking.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x00047874 File Offset: 0x00045A74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 940859, RefRangeEnd = 940860, XrefRangeStart = 940819, XrefRangeEnd = 940859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InstallEvents(bool server)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref server;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworking.NativeMethodInfoPtr_InstallEvents_Internal_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x000478A8 File Offset: 0x00045AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940860, XrefRangeEnd = 940863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AcceptP2PSessionWithUser(SteamId user)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref user;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworking.NativeMethodInfoPtr_AcceptP2PSessionWithUser_Public_Static_Boolean_SteamId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x000478E8 File Offset: 0x00045AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940863, XrefRangeEnd = 940866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AllowP2PPacketRelay(bool allow)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref allow;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworking.NativeMethodInfoPtr_AllowP2PPacketRelay_Public_Static_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x00047928 File Offset: 0x00045B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940866, XrefRangeEnd = 940869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CloseP2PSessionWithUser(SteamId user)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref user;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworking.NativeMethodInfoPtr_CloseP2PSessionWithUser_Public_Static_Boolean_SteamId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x00047968 File Offset: 0x00045B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940869, XrefRangeEnd = 940871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsP2PPacketAvailable(int channel = 0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworking.NativeMethodInfoPtr_IsP2PPacketAvailable_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x000479A8 File Offset: 0x00045BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940871, XrefRangeEnd = 940874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsP2PPacketAvailable(out uint msgSize, int channel = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &msgSize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworking.NativeMethodInfoPtr_IsP2PPacketAvailable_Public_Static_Boolean_byref_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x000479F4 File Offset: 0x00045BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940874, XrefRangeEnd = 940893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Nullable<P2Packet> ReadP2PPacket(int channel = 0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworking.NativeMethodInfoPtr_ReadP2PPacket_Public_Static_Nullable_1_P2Packet_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<P2Packet>(intPtr);
			}
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x00047A2C File Offset: 0x00045C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940893, XrefRangeEnd = 940899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ReadP2PPacket(Il2CppStructArray<byte> buffer, ref uint size, ref SteamId steamid, int channel = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &steamid;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworking.NativeMethodInfoPtr_ReadP2PPacket_Public_Static_Boolean_Il2CppStructArray_1_Byte_byref_UInt32_byref_SteamId_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x00047A98 File Offset: 0x00045C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940899, XrefRangeEnd = 940902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ReadP2PPacket(byte* buffer, uint cbuf, ref uint size, ref SteamId steamid, int channel = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbuf;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &steamid;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworking.NativeMethodInfoPtr_ReadP2PPacket_Public_Static_Boolean_ptr_Byte_UInt32_byref_UInt32_byref_SteamId_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x00047B0C File Offset: 0x00045D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940902, XrefRangeEnd = 940907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SendP2PPacket(SteamId steamid, Il2CppStructArray<byte> data, int length = -1, int nChannel = 0, P2PSend sendType = P2PSend.Reliable)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamid;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nChannel;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworking.NativeMethodInfoPtr_SendP2PPacket_Public_Static_Boolean_SteamId_Il2CppStructArray_1_Byte_Int32_Int32_P2PSend_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x00047B88 File Offset: 0x00045D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940907, XrefRangeEnd = 940910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SendP2PPacket(SteamId steamid, byte* data, uint length, int nChannel = 1, P2PSend sendType = P2PSend.Reliable)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamid;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nChannel;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworking.NativeMethodInfoPtr_SendP2PPacket_Public_Static_Boolean_SteamId_ptr_Byte_UInt32_Int32_P2PSend_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x00047BFC File Offset: 0x00045DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940910, XrefRangeEnd = 940913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamNetworking()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworking.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x00002996 File Offset: 0x00000B96
		public SteamNetworking(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060009B5 RID: 2485 RVA: 0x00047C38 File Offset: 0x00045E38
		// (set) Token: 0x060009B6 RID: 2486 RVA: 0x0000299F File Offset: 0x00000B9F
		public unsafe static Action<SteamId> OnP2PSessionRequest
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamNetworking.NativeFieldInfoPtr_OnP2PSessionRequest, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SteamId>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamNetworking.NativeFieldInfoPtr_OnP2PSessionRequest, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060009B7 RID: 2487 RVA: 0x00047C60 File Offset: 0x00045E60
		// (set) Token: 0x060009B8 RID: 2488 RVA: 0x000029B1 File Offset: 0x00000BB1
		public unsafe static Action<SteamId, P2PSessionError> OnP2PConnectionFailed
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamNetworking.NativeFieldInfoPtr_OnP2PConnectionFailed, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SteamId, P2PSessionError>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamNetworking.NativeFieldInfoPtr_OnP2PConnectionFailed, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001099 RID: 4249
		private static readonly IntPtr NativeFieldInfoPtr_OnP2PSessionRequest;

		// Token: 0x0400109A RID: 4250
		private static readonly IntPtr NativeFieldInfoPtr_OnP2PConnectionFailed;

		// Token: 0x0400109B RID: 4251
		private static readonly IntPtr NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamNetworking_0;

		// Token: 0x0400109C RID: 4252
		private static readonly IntPtr NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0;

		// Token: 0x0400109D RID: 4253
		private static readonly IntPtr NativeMethodInfoPtr_InstallEvents_Internal_Static_Void_Boolean_0;

		// Token: 0x0400109E RID: 4254
		private static readonly IntPtr NativeMethodInfoPtr_AcceptP2PSessionWithUser_Public_Static_Boolean_SteamId_0;

		// Token: 0x0400109F RID: 4255
		private static readonly IntPtr NativeMethodInfoPtr_AllowP2PPacketRelay_Public_Static_Boolean_Boolean_0;

		// Token: 0x040010A0 RID: 4256
		private static readonly IntPtr NativeMethodInfoPtr_CloseP2PSessionWithUser_Public_Static_Boolean_SteamId_0;

		// Token: 0x040010A1 RID: 4257
		private static readonly IntPtr NativeMethodInfoPtr_IsP2PPacketAvailable_Public_Static_Boolean_Int32_0;

		// Token: 0x040010A2 RID: 4258
		private static readonly IntPtr NativeMethodInfoPtr_IsP2PPacketAvailable_Public_Static_Boolean_byref_UInt32_Int32_0;

		// Token: 0x040010A3 RID: 4259
		private static readonly IntPtr NativeMethodInfoPtr_ReadP2PPacket_Public_Static_Nullable_1_P2Packet_Int32_0;

		// Token: 0x040010A4 RID: 4260
		private static readonly IntPtr NativeMethodInfoPtr_ReadP2PPacket_Public_Static_Boolean_Il2CppStructArray_1_Byte_byref_UInt32_byref_SteamId_Int32_0;

		// Token: 0x040010A5 RID: 4261
		private static readonly IntPtr NativeMethodInfoPtr_ReadP2PPacket_Public_Static_Boolean_ptr_Byte_UInt32_byref_UInt32_byref_SteamId_Int32_0;

		// Token: 0x040010A6 RID: 4262
		private static readonly IntPtr NativeMethodInfoPtr_SendP2PPacket_Public_Static_Boolean_SteamId_Il2CppStructArray_1_Byte_Int32_Int32_P2PSend_0;

		// Token: 0x040010A7 RID: 4263
		private static readonly IntPtr NativeMethodInfoPtr_SendP2PPacket_Public_Static_Boolean_SteamId_ptr_Byte_UInt32_Int32_P2PSend_0;

		// Token: 0x040010A8 RID: 4264
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000243 RID: 579
		[ObfuscatedName("Steamworks.SteamNetworking+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001D77 RID: 7543 RVA: 0x00087560 File Offset: 0x00085760
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SteamNetworking.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamNetworking>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamNetworking.__c>.NativeClassPtr);
				SteamNetworking.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworking.__c>.NativeClassPtr, "<>9");
				SteamNetworking.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworking.__c>.NativeClassPtr, "<>9__3_0");
				SteamNetworking.__c.NativeFieldInfoPtr___9__3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworking.__c>.NativeClassPtr, "<>9__3_1");
				SteamNetworking.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworking.__c>.NativeClassPtr, 100665691);
				SteamNetworking.__c.NativeMethodInfoPtr__InstallEvents_b__3_0_Internal_Void_P2PSessionRequest_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworking.__c>.NativeClassPtr, 100665692);
				SteamNetworking.__c.NativeMethodInfoPtr__InstallEvents_b__3_1_Internal_Void_P2PSessionConnectFail_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworking.__c>.NativeClassPtr, 100665693);
			}

			// Token: 0x06001D78 RID: 7544 RVA: 0x00087604 File Offset: 0x00085804
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamNetworking.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworking.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D79 RID: 7545 RVA: 0x00087640 File Offset: 0x00085840
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940792, XrefRangeEnd = 940795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__3_0(P2PSessionRequest_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworking.__c.NativeMethodInfoPtr__InstallEvents_b__3_0_Internal_Void_P2PSessionRequest_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D7A RID: 7546 RVA: 0x00087680 File Offset: 0x00085880
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940795, XrefRangeEnd = 940798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__3_1(P2PSessionConnectFail_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworking.__c.NativeMethodInfoPtr__InstallEvents_b__3_1_Internal_Void_P2PSessionConnectFail_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D7B RID: 7547 RVA: 0x0000A736 File Offset: 0x00008936
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700076D RID: 1901
			// (get) Token: 0x06001D7C RID: 7548 RVA: 0x000876C0 File Offset: 0x000858C0
			// (set) Token: 0x06001D7D RID: 7549 RVA: 0x0000A73F File Offset: 0x0000893F
			public unsafe static SteamNetworking.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamNetworking.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SteamNetworking.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamNetworking.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700076E RID: 1902
			// (get) Token: 0x06001D7E RID: 7550 RVA: 0x000876E8 File Offset: 0x000858E8
			// (set) Token: 0x06001D7F RID: 7551 RVA: 0x0000A751 File Offset: 0x00008951
			public unsafe static Action<P2PSessionRequest_t> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamNetworking.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<P2PSessionRequest_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamNetworking.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700076F RID: 1903
			// (get) Token: 0x06001D80 RID: 7552 RVA: 0x00087710 File Offset: 0x00085910
			// (set) Token: 0x06001D81 RID: 7553 RVA: 0x0000A763 File Offset: 0x00008963
			public unsafe static Action<P2PSessionConnectFail_t> __9__3_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamNetworking.__c.NativeFieldInfoPtr___9__3_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<P2PSessionConnectFail_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamNetworking.__c.NativeFieldInfoPtr___9__3_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002130 RID: 8496
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002131 RID: 8497
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04002132 RID: 8498
			private static readonly IntPtr NativeFieldInfoPtr___9__3_1;

			// Token: 0x04002133 RID: 8499
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002134 RID: 8500
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__3_0_Internal_Void_P2PSessionRequest_t_0;

			// Token: 0x04002135 RID: 8501
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__3_1_Internal_Void_P2PSessionConnectFail_t_0;
		}
	}
}
