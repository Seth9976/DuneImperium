using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x0200009C RID: 156
	public class SocketManager : Object
	{
		// Token: 0x0600085E RID: 2142 RVA: 0x00042800 File Offset: 0x00040A00
		// Note: this type is marked as 'beforefieldinit'.
		static SocketManager()
		{
			Il2CppClassPointerStore<SocketManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "SocketManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocketManager>.NativeClassPtr);
			SocketManager.NativeFieldInfoPtr__Interface_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketManager>.NativeClassPtr, "<Interface>k__BackingField");
			SocketManager.NativeFieldInfoPtr_Connecting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketManager>.NativeClassPtr, "Connecting");
			SocketManager.NativeFieldInfoPtr_Connected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketManager>.NativeClassPtr, "Connected");
			SocketManager.NativeFieldInfoPtr__Socket_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketManager>.NativeClassPtr, "<Socket>k__BackingField");
			SocketManager.NativeFieldInfoPtr_pollGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketManager>.NativeClassPtr, "pollGroup");
			SocketManager.NativeMethodInfoPtr_get_Interface_Public_get_ISocketManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketManager>.NativeClassPtr, 100665300);
			SocketManager.NativeMethodInfoPtr_set_Interface_Public_set_Void_ISocketManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketManager>.NativeClassPtr, 100665301);
			SocketManager.NativeMethodInfoPtr_get_Socket_Public_get_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketManager>.NativeClassPtr, 100665302);
			SocketManager.NativeMethodInfoPtr_set_Socket_Internal_set_Void_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketManager>.NativeClassPtr, 100665303);
			SocketManager.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketManager>.NativeClassPtr, 100665304);
			SocketManager.NativeMethodInfoPtr_Initialize_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketManager>.NativeClassPtr, 100665305);
			SocketManager.NativeMethodInfoPtr_Close_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketManager>.NativeClassPtr, 100665306);
			SocketManager.NativeMethodInfoPtr_OnConnectionChanged_Public_Virtual_New_Void_Connection_ConnectionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketManager>.NativeClassPtr, 100665307);
			SocketManager.NativeMethodInfoPtr_OnConnecting_Public_Virtual_New_Void_Connection_ConnectionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketManager>.NativeClassPtr, 100665308);
			SocketManager.NativeMethodInfoPtr_OnConnected_Public_Virtual_New_Void_Connection_ConnectionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketManager>.NativeClassPtr, 100665309);
			SocketManager.NativeMethodInfoPtr_OnDisconnected_Public_Virtual_New_Void_Connection_ConnectionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketManager>.NativeClassPtr, 100665310);
			SocketManager.NativeMethodInfoPtr_Receive_Public_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketManager>.NativeClassPtr, 100665311);
			SocketManager.NativeMethodInfoPtr_ReceiveMessage_Internal_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketManager>.NativeClassPtr, 100665312);
			SocketManager.NativeMethodInfoPtr_OnMessage_Public_Virtual_New_Void_Connection_NetIdentity_IntPtr_Int32_Int64_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketManager>.NativeClassPtr, 100665313);
			SocketManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketManager>.NativeClassPtr, 100665314);
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600085F RID: 2143 RVA: 0x000429C0 File Offset: 0x00040BC0
		// (set) Token: 0x06000860 RID: 2144 RVA: 0x00042A00 File Offset: 0x00040C00
		public unsafe ISocketManager Interface
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketManager.NativeMethodInfoPtr_get_Interface_Public_get_ISocketManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISocketManager>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketManager.NativeMethodInfoPtr_set_Interface_Public_set_Void_ISocketManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x00042A44 File Offset: 0x00040C44
		// (set) Token: 0x06000862 RID: 2146 RVA: 0x00042A80 File Offset: 0x00040C80
		public unsafe Socket Socket
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketManager.NativeMethodInfoPtr_get_Socket_Public_get_Socket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketManager.NativeMethodInfoPtr_set_Socket_Internal_set_Void_Socket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x00042AC0 File Offset: 0x00040CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936981, XrefRangeEnd = 936982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SocketManager.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00042B04 File Offset: 0x00040D04
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 936987, RefRangeEnd = 936990, XrefRangeStart = 936982, XrefRangeEnd = 936987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketManager.NativeMethodInfoPtr_Initialize_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00042B38 File Offset: 0x00040D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936990, XrefRangeEnd = 937002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketManager.NativeMethodInfoPtr_Close_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x00042B74 File Offset: 0x00040D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937002, XrefRangeEnd = 937012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnConnectionChanged(Connection connection, ConnectionInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref connection;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SocketManager.NativeMethodInfoPtr_OnConnectionChanged_Public_Virtual_New_Void_Connection_ConnectionInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00042BD4 File Offset: 0x00040DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937012, XrefRangeEnd = 937014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnConnecting(Connection connection, ConnectionInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref connection;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SocketManager.NativeMethodInfoPtr_OnConnecting_Public_Virtual_New_Void_Connection_ConnectionInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x00042C34 File Offset: 0x00040E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937014, XrefRangeEnd = 937022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnConnected(Connection connection, ConnectionInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref connection;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SocketManager.NativeMethodInfoPtr_OnConnected_Public_Virtual_New_Void_Connection_ConnectionInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x00042C94 File Offset: 0x00040E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937022, XrefRangeEnd = 937026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDisconnected(Connection connection, ConnectionInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref connection;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SocketManager.NativeMethodInfoPtr_OnDisconnected_Public_Virtual_New_Void_Connection_ConnectionInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x00042CF4 File Offset: 0x00040EF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 937050, RefRangeEnd = 937051, XrefRangeStart = 937026, XrefRangeEnd = 937050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Receive(int bufferSize = 32, bool receiveToEnd = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bufferSize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref receiveToEnd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketManager.NativeMethodInfoPtr_Receive_Public_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x00042D4C File Offset: 0x00040F4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 937062, RefRangeEnd = 937063, XrefRangeStart = 937051, XrefRangeEnd = 937062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveMessage(IntPtr msgPtr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref msgPtr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketManager.NativeMethodInfoPtr_ReceiveMessage_Internal_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x00042D8C File Offset: 0x00040F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937063, XrefRangeEnd = 937066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnMessage(Connection connection, NetIdentity identity, IntPtr data, int size, long messageNum, long recvTime, int channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref connection;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref identity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref messageNum;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recvTime;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SocketManager.NativeMethodInfoPtr_OnMessage_Public_Virtual_New_Void_Connection_NetIdentity_IntPtr_Int32_Int64_Int64_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00042E2C File Offset: 0x0004102C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 937079, RefRangeEnd = 937082, XrefRangeStart = 937066, XrefRangeEnd = 937079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SocketManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x000025E0 File Offset: 0x000007E0
		public SocketManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600086F RID: 2159 RVA: 0x00042E68 File Offset: 0x00041068
		// (set) Token: 0x06000870 RID: 2160 RVA: 0x000025E9 File Offset: 0x000007E9
		public unsafe ISocketManager _Interface_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketManager.NativeFieldInfoPtr__Interface_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISocketManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketManager.NativeFieldInfoPtr__Interface_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x00042E98 File Offset: 0x00041098
		// (set) Token: 0x06000872 RID: 2162 RVA: 0x00002608 File Offset: 0x00000808
		public unsafe HashSet<Connection> Connecting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketManager.NativeFieldInfoPtr_Connecting);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<Connection>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketManager.NativeFieldInfoPtr_Connecting), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000873 RID: 2163 RVA: 0x00042EC8 File Offset: 0x000410C8
		// (set) Token: 0x06000874 RID: 2164 RVA: 0x00002627 File Offset: 0x00000827
		public unsafe HashSet<Connection> Connected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketManager.NativeFieldInfoPtr_Connected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<Connection>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketManager.NativeFieldInfoPtr_Connected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x00042EF8 File Offset: 0x000410F8
		// (set) Token: 0x06000876 RID: 2166 RVA: 0x00002646 File Offset: 0x00000846
		public unsafe Socket _Socket_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketManager.NativeFieldInfoPtr__Socket_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketManager.NativeFieldInfoPtr__Socket_k__BackingField)) = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x00042F20 File Offset: 0x00041120
		// (set) Token: 0x06000878 RID: 2168 RVA: 0x00002661 File Offset: 0x00000861
		public unsafe HSteamNetPollGroup pollGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketManager.NativeFieldInfoPtr_pollGroup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketManager.NativeFieldInfoPtr_pollGroup)) = value;
			}
		}

		// Token: 0x04000F92 RID: 3986
		private static readonly IntPtr NativeFieldInfoPtr__Interface_k__BackingField;

		// Token: 0x04000F93 RID: 3987
		private static readonly IntPtr NativeFieldInfoPtr_Connecting;

		// Token: 0x04000F94 RID: 3988
		private static readonly IntPtr NativeFieldInfoPtr_Connected;

		// Token: 0x04000F95 RID: 3989
		private static readonly IntPtr NativeFieldInfoPtr__Socket_k__BackingField;

		// Token: 0x04000F96 RID: 3990
		private static readonly IntPtr NativeFieldInfoPtr_pollGroup;

		// Token: 0x04000F97 RID: 3991
		private static readonly IntPtr NativeMethodInfoPtr_get_Interface_Public_get_ISocketManager_0;

		// Token: 0x04000F98 RID: 3992
		private static readonly IntPtr NativeMethodInfoPtr_set_Interface_Public_set_Void_ISocketManager_0;

		// Token: 0x04000F99 RID: 3993
		private static readonly IntPtr NativeMethodInfoPtr_get_Socket_Public_get_Socket_0;

		// Token: 0x04000F9A RID: 3994
		private static readonly IntPtr NativeMethodInfoPtr_set_Socket_Internal_set_Void_Socket_0;

		// Token: 0x04000F9B RID: 3995
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000F9C RID: 3996
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Internal_Void_0;

		// Token: 0x04000F9D RID: 3997
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Boolean_0;

		// Token: 0x04000F9E RID: 3998
		private static readonly IntPtr NativeMethodInfoPtr_OnConnectionChanged_Public_Virtual_New_Void_Connection_ConnectionInfo_0;

		// Token: 0x04000F9F RID: 3999
		private static readonly IntPtr NativeMethodInfoPtr_OnConnecting_Public_Virtual_New_Void_Connection_ConnectionInfo_0;

		// Token: 0x04000FA0 RID: 4000
		private static readonly IntPtr NativeMethodInfoPtr_OnConnected_Public_Virtual_New_Void_Connection_ConnectionInfo_0;

		// Token: 0x04000FA1 RID: 4001
		private static readonly IntPtr NativeMethodInfoPtr_OnDisconnected_Public_Virtual_New_Void_Connection_ConnectionInfo_0;

		// Token: 0x04000FA2 RID: 4002
		private static readonly IntPtr NativeMethodInfoPtr_Receive_Public_Int32_Int32_Boolean_0;

		// Token: 0x04000FA3 RID: 4003
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveMessage_Internal_Void_IntPtr_0;

		// Token: 0x04000FA4 RID: 4004
		private static readonly IntPtr NativeMethodInfoPtr_OnMessage_Public_Virtual_New_Void_Connection_NetIdentity_IntPtr_Int32_Int64_Int64_Int32_0;

		// Token: 0x04000FA5 RID: 4005
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
