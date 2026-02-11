using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x020000A6 RID: 166
	public class SteamNetworkingSockets : SteamSharedClass<SteamNetworkingSockets>
	{
		// Token: 0x060009B9 RID: 2489 RVA: 0x00047C88 File Offset: 0x00045E88
		// Note: this type is marked as 'beforefieldinit'.
		static SteamNetworkingSockets()
		{
			Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "SteamNetworkingSockets");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr);
			SteamNetworkingSockets.NativeFieldInfoPtr_SocketInterfaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, "SocketInterfaces");
			SteamNetworkingSockets.NativeFieldInfoPtr_ConnectionInterfaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, "ConnectionInterfaces");
			SteamNetworkingSockets.NativeFieldInfoPtr_OnConnectionStatusChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, "OnConnectionStatusChanged");
			SteamNetworkingSockets.NativeFieldInfoPtr_OnFakeIPResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, "OnFakeIPResult");
			SteamNetworkingSockets.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamNetworkingSockets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100665694);
			SteamNetworkingSockets.NativeMethodInfoPtr_get_Identity_Public_Static_get_NetIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100665695);
			SteamNetworkingSockets.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100665696);
			SteamNetworkingSockets.NativeMethodInfoPtr_GetSocketManager_Internal_Static_SocketManager_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100665697);
			SteamNetworkingSockets.NativeMethodInfoPtr_SetSocketManager_Internal_Static_Void_UInt32_SocketManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100665698);
			SteamNetworkingSockets.NativeMethodInfoPtr_GetConnectionManager_Internal_Static_ConnectionManager_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100665699);
			SteamNetworkingSockets.NativeMethodInfoPtr_SetConnectionManager_Internal_Static_Void_UInt32_ConnectionManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100665700);
			SteamNetworkingSockets.NativeMethodInfoPtr_InstallEvents_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100665701);
			SteamNetworkingSockets.NativeMethodInfoPtr_ConnectionStatusChanged_Private_Static_Void_SteamNetConnectionStatusChangedCallback_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100665702);
			SteamNetworkingSockets.NativeMethodInfoPtr_add_OnConnectionStatusChanged_Public_Static_add_Void_Action_2_Connection_ConnectionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100665703);
			SteamNetworkingSockets.NativeMethodInfoPtr_remove_OnConnectionStatusChanged_Public_Static_rem_Void_Action_2_Connection_ConnectionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100665704);
			SteamNetworkingSockets.NativeMethodInfoPtr_FakeIPResult_Private_Static_Void_SteamNetworkingFakeIPResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100665705);
			SteamNetworkingSockets.NativeMethodInfoPtr_add_OnFakeIPResult_Public_Static_add_Void_Action_1_NetAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100665706);
			SteamNetworkingSockets.NativeMethodInfoPtr_remove_OnFakeIPResult_Public_Static_rem_Void_Action_1_NetAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100665707);
			SteamNetworkingSockets.NativeMethodInfoPtr_CreateNormalSocket_Public_Static_T_NetAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100665708);
			SteamNetworkingSockets.NativeMethodInfoPtr_CreateNormalSocket_Public_Static_SocketManager_NetAddress_ISocketManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100665709);
			SteamNetworkingSockets.NativeMethodInfoPtr_ConnectNormal_Public_Static_T_NetAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100665710);
			SteamNetworkingSockets.NativeMethodInfoPtr_ConnectNormal_Public_Static_ConnectionManager_NetAddress_IConnectionManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100665711);
			SteamNetworkingSockets.NativeMethodInfoPtr_CreateRelaySocket_Public_Static_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100665712);
			SteamNetworkingSockets.NativeMethodInfoPtr_CreateRelaySocket_Public_Static_SocketManager_Int32_ISocketManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100665713);
			SteamNetworkingSockets.NativeMethodInfoPtr_ConnectRelay_Public_Static_T_SteamId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100665714);
			SteamNetworkingSockets.NativeMethodInfoPtr_ConnectRelay_Public_Static_ConnectionManager_SteamId_Int32_IConnectionManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100665715);
			SteamNetworkingSockets.NativeMethodInfoPtr_RequestFakeIP_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100665716);
			SteamNetworkingSockets.NativeMethodInfoPtr_GetFakeIP_Public_Static_Result_Int32_byref_NetAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100665717);
			SteamNetworkingSockets.NativeMethodInfoPtr_CreateRelaySocketFakeIP_Public_Static_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100665718);
			SteamNetworkingSockets.NativeMethodInfoPtr_CreateRelaySocketFakeIP_Public_Static_SocketManager_Int32_ISocketManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100665719);
			SteamNetworkingSockets.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100665720);
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060009BA RID: 2490 RVA: 0x00047F24 File Offset: 0x00046124
		public unsafe static ISteamNetworkingSockets Internal
		{
			[CallerCount(35)]
			[CachedScanResults(RefRangeStart = 940917, RefRangeEnd = 940952, XrefRangeStart = 940913, XrefRangeEnd = 940917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamNetworkingSockets_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISteamNetworkingSockets>(intPtr3) : null;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060009BB RID: 2491 RVA: 0x00047F58 File Offset: 0x00046158
		public unsafe static NetIdentity Identity
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940952, XrefRangeEnd = 940957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_get_Identity_Public_Static_get_NetIdentity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x00047F88 File Offset: 0x00046188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940957, XrefRangeEnd = 940982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeInterface(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref server;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamNetworkingSockets.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x00047FD4 File Offset: 0x000461D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 940991, RefRangeEnd = 940992, XrefRangeStart = 940982, XrefRangeEnd = 940991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SocketManager GetSocketManager(uint id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_GetSocketManager_Internal_Static_SocketManager_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SocketManager>(intPtr3) : null;
			}
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x00048014 File Offset: 0x00046214
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 941025, RefRangeEnd = 941032, XrefRangeStart = 940992, XrefRangeEnd = 941025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetSocketManager(uint id, SocketManager manager)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_SetSocketManager_Internal_Static_Void_UInt32_SocketManager_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x00048058 File Offset: 0x00046258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941032, XrefRangeEnd = 941041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ConnectionManager GetConnectionManager(uint id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_GetConnectionManager_Internal_Static_ConnectionManager_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConnectionManager>(intPtr3) : null;
			}
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x00048098 File Offset: 0x00046298
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 941055, RefRangeEnd = 941059, XrefRangeStart = 941041, XrefRangeEnd = 941055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetConnectionManager(uint id, ConnectionManager manager)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_SetConnectionManager_Internal_Static_Void_UInt32_ConnectionManager_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x000480DC File Offset: 0x000462DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941059, XrefRangeEnd = 941080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InstallEvents(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref server;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_InstallEvents_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x0004811C File Offset: 0x0004631C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941080, XrefRangeEnd = 941096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ConnectionStatusChanged(SteamNetConnectionStatusChangedCallback_t data)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_ConnectionStatusChanged_Private_Static_Void_SteamNetConnectionStatusChangedCallback_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x00048158 File Offset: 0x00046358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941096, XrefRangeEnd = 941109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnConnectionStatusChanged(Action<Connection, ConnectionInfo> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_add_OnConnectionStatusChanged_Public_Static_add_Void_Action_2_Connection_ConnectionInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x00048190 File Offset: 0x00046390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941109, XrefRangeEnd = 941122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnConnectionStatusChanged(Action<Connection, ConnectionInfo> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_remove_OnConnectionStatusChanged_Public_Static_rem_Void_Action_2_Connection_ConnectionInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x000481C8 File Offset: 0x000463C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941122, XrefRangeEnd = 941132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FakeIPResult(SteamNetworkingFakeIPResult_t data)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_FakeIPResult_Private_Static_Void_SteamNetworkingFakeIPResult_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x00048204 File Offset: 0x00046404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941132, XrefRangeEnd = 941145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnFakeIPResult(Action<NetAddress> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_add_OnFakeIPResult_Public_Static_add_Void_Action_1_NetAddress_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x0004823C File Offset: 0x0004643C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941145, XrefRangeEnd = 941158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnFakeIPResult(Action<NetAddress> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_remove_OnFakeIPResult_Public_Static_rem_Void_Action_1_NetAddress_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x00048274 File Offset: 0x00046474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941158, XrefRangeEnd = 941170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T CreateNormalSocket<T>(NetAddress address) where T : SocketManager, new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref address;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.MethodInfoStoreGeneric_CreateNormalSocket_Public_Static_T_NetAddress_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x000482B0 File Offset: 0x000464B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941170, XrefRangeEnd = 941189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SocketManager CreateNormalSocket(NetAddress address, ISocketManager intrface)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref address;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(intrface);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_CreateNormalSocket_Public_Static_SocketManager_NetAddress_ISocketManager_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SocketManager>(intPtr3) : null;
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x00048304 File Offset: 0x00046504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941189, XrefRangeEnd = 941200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T ConnectNormal<T>(NetAddress address) where T : ConnectionManager, new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref address;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.MethodInfoStoreGeneric_ConnectNormal_Public_Static_T_NetAddress_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x00048340 File Offset: 0x00046540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941200, XrefRangeEnd = 941214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ConnectionManager ConnectNormal(NetAddress address, IConnectionManager iface)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref address;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(iface);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_ConnectNormal_Public_Static_ConnectionManager_NetAddress_IConnectionManager_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConnectionManager>(intPtr3) : null;
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x00048394 File Offset: 0x00046594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941214, XrefRangeEnd = 941226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T CreateRelaySocket<T>(int virtualport = 0) where T : SocketManager, new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref virtualport;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.MethodInfoStoreGeneric_CreateRelaySocket_Public_Static_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x000483D0 File Offset: 0x000465D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941226, XrefRangeEnd = 941245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SocketManager CreateRelaySocket(int virtualport, ISocketManager intrface)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref virtualport;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(intrface);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_CreateRelaySocket_Public_Static_SocketManager_Int32_ISocketManager_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SocketManager>(intPtr3) : null;
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x00048424 File Offset: 0x00046624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941245, XrefRangeEnd = 941257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T ConnectRelay<T>(SteamId serverId, int virtualport = 0) where T : ConnectionManager, new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref serverId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref virtualport;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.MethodInfoStoreGeneric_ConnectRelay_Public_Static_T_SteamId_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x0004846C File Offset: 0x0004666C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941257, XrefRangeEnd = 941272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ConnectionManager ConnectRelay(SteamId serverId, int virtualport, IConnectionManager iface)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref serverId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref virtualport;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(iface);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_ConnectRelay_Public_Static_ConnectionManager_SteamId_Int32_IConnectionManager_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConnectionManager>(intPtr3) : null;
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x000484CC File Offset: 0x000466CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941272, XrefRangeEnd = 941278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RequestFakeIP(int numFakePorts = 1)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref numFakePorts;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_RequestFakeIP_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x0004850C File Offset: 0x0004670C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941278, XrefRangeEnd = 941288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Result GetFakeIP(int fakePortIndex, out NetAddress address)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fakePortIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &address;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_GetFakeIP_Public_Static_Result_Int32_byref_NetAddress_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x00048558 File Offset: 0x00046758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941288, XrefRangeEnd = 941300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T CreateRelaySocketFakeIP<T>(int fakePortIndex = 0) where T : SocketManager, new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fakePortIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.MethodInfoStoreGeneric_CreateRelaySocketFakeIP_Public_Static_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x00048594 File Offset: 0x00046794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941300, XrefRangeEnd = 941319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SocketManager CreateRelaySocketFakeIP(int fakePortIndex, ISocketManager intrface)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fakePortIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(intrface);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_CreateRelaySocketFakeIP_Public_Static_SocketManager_Int32_ISocketManager_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SocketManager>(intPtr3) : null;
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x000485E8 File Offset: 0x000467E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941319, XrefRangeEnd = 941322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamNetworkingSockets()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x000029C3 File Offset: 0x00000BC3
		public SteamNetworkingSockets(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060009D6 RID: 2518 RVA: 0x00048624 File Offset: 0x00046824
		// (set) Token: 0x060009D7 RID: 2519 RVA: 0x000029CC File Offset: 0x00000BCC
		public unsafe static Dictionary<uint, SocketManager> SocketInterfaces
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamNetworkingSockets.NativeFieldInfoPtr_SocketInterfaces, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, SocketManager>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamNetworkingSockets.NativeFieldInfoPtr_SocketInterfaces, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060009D8 RID: 2520 RVA: 0x0004864C File Offset: 0x0004684C
		// (set) Token: 0x060009D9 RID: 2521 RVA: 0x000029DE File Offset: 0x00000BDE
		public unsafe static Dictionary<uint, ConnectionManager> ConnectionInterfaces
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamNetworkingSockets.NativeFieldInfoPtr_ConnectionInterfaces, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, ConnectionManager>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamNetworkingSockets.NativeFieldInfoPtr_ConnectionInterfaces, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060009DA RID: 2522 RVA: 0x00048674 File Offset: 0x00046874
		// (set) Token: 0x060009DB RID: 2523 RVA: 0x000029F0 File Offset: 0x00000BF0
		public unsafe static Action<Connection, ConnectionInfo> OnConnectionStatusChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamNetworkingSockets.NativeFieldInfoPtr_OnConnectionStatusChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Connection, ConnectionInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamNetworkingSockets.NativeFieldInfoPtr_OnConnectionStatusChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060009DC RID: 2524 RVA: 0x0004869C File Offset: 0x0004689C
		// (set) Token: 0x060009DD RID: 2525 RVA: 0x00002A02 File Offset: 0x00000C02
		public unsafe static Action<NetAddress> OnFakeIPResult
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamNetworkingSockets.NativeFieldInfoPtr_OnFakeIPResult, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<NetAddress>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamNetworkingSockets.NativeFieldInfoPtr_OnFakeIPResult, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010A9 RID: 4265
		private static readonly IntPtr NativeFieldInfoPtr_SocketInterfaces;

		// Token: 0x040010AA RID: 4266
		private static readonly IntPtr NativeFieldInfoPtr_ConnectionInterfaces;

		// Token: 0x040010AB RID: 4267
		private static readonly IntPtr NativeFieldInfoPtr_OnConnectionStatusChanged;

		// Token: 0x040010AC RID: 4268
		private static readonly IntPtr NativeFieldInfoPtr_OnFakeIPResult;

		// Token: 0x040010AD RID: 4269
		private static readonly IntPtr NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamNetworkingSockets_0;

		// Token: 0x040010AE RID: 4270
		private static readonly IntPtr NativeMethodInfoPtr_get_Identity_Public_Static_get_NetIdentity_0;

		// Token: 0x040010AF RID: 4271
		private static readonly IntPtr NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0;

		// Token: 0x040010B0 RID: 4272
		private static readonly IntPtr NativeMethodInfoPtr_GetSocketManager_Internal_Static_SocketManager_UInt32_0;

		// Token: 0x040010B1 RID: 4273
		private static readonly IntPtr NativeMethodInfoPtr_SetSocketManager_Internal_Static_Void_UInt32_SocketManager_0;

		// Token: 0x040010B2 RID: 4274
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectionManager_Internal_Static_ConnectionManager_UInt32_0;

		// Token: 0x040010B3 RID: 4275
		private static readonly IntPtr NativeMethodInfoPtr_SetConnectionManager_Internal_Static_Void_UInt32_ConnectionManager_0;

		// Token: 0x040010B4 RID: 4276
		private static readonly IntPtr NativeMethodInfoPtr_InstallEvents_Internal_Void_Boolean_0;

		// Token: 0x040010B5 RID: 4277
		private static readonly IntPtr NativeMethodInfoPtr_ConnectionStatusChanged_Private_Static_Void_SteamNetConnectionStatusChangedCallback_t_0;

		// Token: 0x040010B6 RID: 4278
		private static readonly IntPtr NativeMethodInfoPtr_add_OnConnectionStatusChanged_Public_Static_add_Void_Action_2_Connection_ConnectionInfo_0;

		// Token: 0x040010B7 RID: 4279
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnConnectionStatusChanged_Public_Static_rem_Void_Action_2_Connection_ConnectionInfo_0;

		// Token: 0x040010B8 RID: 4280
		private static readonly IntPtr NativeMethodInfoPtr_FakeIPResult_Private_Static_Void_SteamNetworkingFakeIPResult_t_0;

		// Token: 0x040010B9 RID: 4281
		private static readonly IntPtr NativeMethodInfoPtr_add_OnFakeIPResult_Public_Static_add_Void_Action_1_NetAddress_0;

		// Token: 0x040010BA RID: 4282
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnFakeIPResult_Public_Static_rem_Void_Action_1_NetAddress_0;

		// Token: 0x040010BB RID: 4283
		private static readonly IntPtr NativeMethodInfoPtr_CreateNormalSocket_Public_Static_T_NetAddress_0;

		// Token: 0x040010BC RID: 4284
		private static readonly IntPtr NativeMethodInfoPtr_CreateNormalSocket_Public_Static_SocketManager_NetAddress_ISocketManager_0;

		// Token: 0x040010BD RID: 4285
		private static readonly IntPtr NativeMethodInfoPtr_ConnectNormal_Public_Static_T_NetAddress_0;

		// Token: 0x040010BE RID: 4286
		private static readonly IntPtr NativeMethodInfoPtr_ConnectNormal_Public_Static_ConnectionManager_NetAddress_IConnectionManager_0;

		// Token: 0x040010BF RID: 4287
		private static readonly IntPtr NativeMethodInfoPtr_CreateRelaySocket_Public_Static_T_Int32_0;

		// Token: 0x040010C0 RID: 4288
		private static readonly IntPtr NativeMethodInfoPtr_CreateRelaySocket_Public_Static_SocketManager_Int32_ISocketManager_0;

		// Token: 0x040010C1 RID: 4289
		private static readonly IntPtr NativeMethodInfoPtr_ConnectRelay_Public_Static_T_SteamId_Int32_0;

		// Token: 0x040010C2 RID: 4290
		private static readonly IntPtr NativeMethodInfoPtr_ConnectRelay_Public_Static_ConnectionManager_SteamId_Int32_IConnectionManager_0;

		// Token: 0x040010C3 RID: 4291
		private static readonly IntPtr NativeMethodInfoPtr_RequestFakeIP_Public_Static_Boolean_Int32_0;

		// Token: 0x040010C4 RID: 4292
		private static readonly IntPtr NativeMethodInfoPtr_GetFakeIP_Public_Static_Result_Int32_byref_NetAddress_0;

		// Token: 0x040010C5 RID: 4293
		private static readonly IntPtr NativeMethodInfoPtr_CreateRelaySocketFakeIP_Public_Static_T_Int32_0;

		// Token: 0x040010C6 RID: 4294
		private static readonly IntPtr NativeMethodInfoPtr_CreateRelaySocketFakeIP_Public_Static_SocketManager_Int32_ISocketManager_0;

		// Token: 0x040010C7 RID: 4295
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000244 RID: 580
		private sealed class MethodInfoStoreGeneric_CreateNormalSocket_Public_Static_T_NetAddress_0<T>
		{
			// Token: 0x04002136 RID: 8502
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SteamNetworkingSockets.NativeMethodInfoPtr_CreateNormalSocket_Public_Static_T_NetAddress_0, Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000245 RID: 581
		private sealed class MethodInfoStoreGeneric_ConnectNormal_Public_Static_T_NetAddress_0<T>
		{
			// Token: 0x04002137 RID: 8503
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SteamNetworkingSockets.NativeMethodInfoPtr_ConnectNormal_Public_Static_T_NetAddress_0, Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000246 RID: 582
		private sealed class MethodInfoStoreGeneric_CreateRelaySocket_Public_Static_T_Int32_0<T>
		{
			// Token: 0x04002138 RID: 8504
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SteamNetworkingSockets.NativeMethodInfoPtr_CreateRelaySocket_Public_Static_T_Int32_0, Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000247 RID: 583
		private sealed class MethodInfoStoreGeneric_ConnectRelay_Public_Static_T_SteamId_Int32_0<T>
		{
			// Token: 0x04002139 RID: 8505
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SteamNetworkingSockets.NativeMethodInfoPtr_ConnectRelay_Public_Static_T_SteamId_Int32_0, Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000248 RID: 584
		private sealed class MethodInfoStoreGeneric_CreateRelaySocketFakeIP_Public_Static_T_Int32_0<T>
		{
			// Token: 0x0400213A RID: 8506
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SteamNetworkingSockets.NativeMethodInfoPtr_CreateRelaySocketFakeIP_Public_Static_T_Int32_0, Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
