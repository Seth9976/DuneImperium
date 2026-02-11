using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x02000092 RID: 146
	public class ConnectionManager : Object
	{
		// Token: 0x06000803 RID: 2051 RVA: 0x00040BD4 File Offset: 0x0003EDD4
		// Note: this type is marked as 'beforefieldinit'.
		static ConnectionManager()
		{
			Il2CppClassPointerStore<ConnectionManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "ConnectionManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConnectionManager>.NativeClassPtr);
			ConnectionManager.NativeFieldInfoPtr__Interface_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionManager>.NativeClassPtr, "<Interface>k__BackingField");
			ConnectionManager.NativeFieldInfoPtr_Connection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionManager>.NativeClassPtr, "Connection");
			ConnectionManager.NativeFieldInfoPtr__ConnectionInfo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionManager>.NativeClassPtr, "<ConnectionInfo>k__BackingField");
			ConnectionManager.NativeFieldInfoPtr_Connected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionManager>.NativeClassPtr, "Connected");
			ConnectionManager.NativeFieldInfoPtr_Connecting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionManager>.NativeClassPtr, "Connecting");
			ConnectionManager.NativeMethodInfoPtr_get_Interface_Public_get_IConnectionManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionManager>.NativeClassPtr, 100665242);
			ConnectionManager.NativeMethodInfoPtr_set_Interface_Public_set_Void_IConnectionManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionManager>.NativeClassPtr, 100665243);
			ConnectionManager.NativeMethodInfoPtr_get_ConnectionInfo_Public_get_ConnectionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionManager>.NativeClassPtr, 100665244);
			ConnectionManager.NativeMethodInfoPtr_set_ConnectionInfo_Internal_set_Void_ConnectionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionManager>.NativeClassPtr, 100665245);
			ConnectionManager.NativeMethodInfoPtr_get_ConnectionName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionManager>.NativeClassPtr, 100665246);
			ConnectionManager.NativeMethodInfoPtr_set_ConnectionName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionManager>.NativeClassPtr, 100665247);
			ConnectionManager.NativeMethodInfoPtr_get_UserData_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionManager>.NativeClassPtr, 100665248);
			ConnectionManager.NativeMethodInfoPtr_set_UserData_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionManager>.NativeClassPtr, 100665249);
			ConnectionManager.NativeMethodInfoPtr_Close_Public_Void_Boolean_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionManager>.NativeClassPtr, 100665250);
			ConnectionManager.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionManager>.NativeClassPtr, 100665251);
			ConnectionManager.NativeMethodInfoPtr_OnConnectionChanged_Public_Virtual_New_Void_ConnectionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionManager>.NativeClassPtr, 100665252);
			ConnectionManager.NativeMethodInfoPtr_OnConnecting_Public_Virtual_New_Void_ConnectionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionManager>.NativeClassPtr, 100665253);
			ConnectionManager.NativeMethodInfoPtr_OnConnected_Public_Virtual_New_Void_ConnectionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionManager>.NativeClassPtr, 100665254);
			ConnectionManager.NativeMethodInfoPtr_OnDisconnected_Public_Virtual_New_Void_ConnectionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionManager>.NativeClassPtr, 100665255);
			ConnectionManager.NativeMethodInfoPtr_Receive_Public_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionManager>.NativeClassPtr, 100665256);
			ConnectionManager.NativeMethodInfoPtr_SendMessages_Public_Void_Il2CppStructArray_1_Connection_Int32_IntPtr_Int32_SendType_Il2CppStructArray_1_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionManager>.NativeClassPtr, 100665257);
			ConnectionManager.NativeMethodInfoPtr_SendMessages_Public_Void_Il2CppStructArray_1_Connection_Int32_Il2CppStructArray_1_Byte_SendType_Il2CppStructArray_1_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionManager>.NativeClassPtr, 100665258);
			ConnectionManager.NativeMethodInfoPtr_SendMessages_Public_Void_Il2CppStructArray_1_Connection_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SendType_Il2CppStructArray_1_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionManager>.NativeClassPtr, 100665259);
			ConnectionManager.NativeMethodInfoPtr_SendMessages_Public_Void_Il2CppStructArray_1_Connection_Int32_String_SendType_Il2CppStructArray_1_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionManager>.NativeClassPtr, 100665260);
			ConnectionManager.NativeMethodInfoPtr_ReceiveMessage_Internal_Void_byref_ptr_NetMsg_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionManager>.NativeClassPtr, 100665261);
			ConnectionManager.NativeMethodInfoPtr_OnMessage_Public_Virtual_New_Void_IntPtr_Int32_Int64_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionManager>.NativeClassPtr, 100665262);
			ConnectionManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionManager>.NativeClassPtr, 100665263);
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x00040E20 File Offset: 0x0003F020
		// (set) Token: 0x06000805 RID: 2053 RVA: 0x00040E60 File Offset: 0x0003F060
		public unsafe IConnectionManager Interface
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionManager.NativeMethodInfoPtr_get_Interface_Public_get_IConnectionManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IConnectionManager>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionManager.NativeMethodInfoPtr_set_Interface_Public_set_Void_IConnectionManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000806 RID: 2054 RVA: 0x00040EA4 File Offset: 0x0003F0A4
		// (set) Token: 0x06000807 RID: 2055 RVA: 0x00040EDC File Offset: 0x0003F0DC
		public unsafe ConnectionInfo ConnectionInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionManager.NativeMethodInfoPtr_get_ConnectionInfo_Public_get_ConnectionInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ConnectionInfo(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936858, XrefRangeEnd = 936859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionManager.NativeMethodInfoPtr_set_ConnectionInfo_Internal_set_Void_ConnectionInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000808 RID: 2056 RVA: 0x00040F24 File Offset: 0x0003F124
		// (set) Token: 0x06000809 RID: 2057 RVA: 0x00040F5C File Offset: 0x0003F15C
		public unsafe string ConnectionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936859, XrefRangeEnd = 936860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionManager.NativeMethodInfoPtr_get_ConnectionName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936860, XrefRangeEnd = 936861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionManager.NativeMethodInfoPtr_set_ConnectionName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600080A RID: 2058 RVA: 0x00040FA0 File Offset: 0x0003F1A0
		// (set) Token: 0x0600080B RID: 2059 RVA: 0x00040FDC File Offset: 0x0003F1DC
		public unsafe long UserData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936861, XrefRangeEnd = 936862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionManager.NativeMethodInfoPtr_get_UserData_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936862, XrefRangeEnd = 936863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionManager.NativeMethodInfoPtr_set_UserData_Public_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x0004101C File Offset: 0x0003F21C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936863, XrefRangeEnd = 936864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(bool linger = false, int reasonCode = 0, string debugString = "Closing Connection")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref linger;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reasonCode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(debugString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionManager.NativeMethodInfoPtr_Close_Public_Void_Boolean_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x0004107C File Offset: 0x0003F27C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936864, XrefRangeEnd = 936865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConnectionManager.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x000410C0 File Offset: 0x0003F2C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936865, XrefRangeEnd = 936869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnConnectionChanged(ConnectionInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConnectionManager.NativeMethodInfoPtr_OnConnectionChanged_Public_Virtual_New_Void_ConnectionInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00041114 File Offset: 0x0003F314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936869, XrefRangeEnd = 936872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnConnecting(ConnectionInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConnectionManager.NativeMethodInfoPtr_OnConnecting_Public_Virtual_New_Void_ConnectionInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00041168 File Offset: 0x0003F368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936872, XrefRangeEnd = 936875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnConnected(ConnectionInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConnectionManager.NativeMethodInfoPtr_OnConnected_Public_Virtual_New_Void_ConnectionInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x000411BC File Offset: 0x0003F3BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936875, XrefRangeEnd = 936878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDisconnected(ConnectionInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConnectionManager.NativeMethodInfoPtr_OnDisconnected_Public_Virtual_New_Void_ConnectionInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00041210 File Offset: 0x0003F410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936878, XrefRangeEnd = 936889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionManager.NativeMethodInfoPtr_Receive_Public_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00041268 File Offset: 0x0003F468
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 936921, RefRangeEnd = 936924, XrefRangeStart = 936889, XrefRangeEnd = 936921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendMessages(Il2CppStructArray<Connection> connections, int connectionCount, IntPtr ptr, int size, SendType sendType = SendType.Reliable, Il2CppStructArray<Result> results = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = IL2CPP.Il2CppObjectBaseToPtr(connections);
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref connectionCount;
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ptr;
			ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr2[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendType;
			ptr2[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionManager.NativeMethodInfoPtr_SendMessages_Public_Void_Il2CppStructArray_1_Connection_Int32_IntPtr_Int32_SendType_Il2CppStructArray_1_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x000412F8 File Offset: 0x0003F4F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936924, XrefRangeEnd = 936928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendMessages(Il2CppStructArray<Connection> connections, int connectionCount, Il2CppStructArray<byte> data, SendType sendType = SendType.Reliable, Il2CppStructArray<Result> results = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(connections);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref connectionCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionManager.NativeMethodInfoPtr_SendMessages_Public_Void_Il2CppStructArray_1_Connection_Int32_Il2CppStructArray_1_Byte_SendType_Il2CppStructArray_1_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x0004137C File Offset: 0x0003F57C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936928, XrefRangeEnd = 936932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendMessages(Il2CppStructArray<Connection> connections, int connectionCount, Il2CppStructArray<byte> data, int offset, int length, SendType sendType = SendType.Reliable, Il2CppStructArray<Result> results = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(connections);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref connectionCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendType;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionManager.NativeMethodInfoPtr_SendMessages_Public_Void_Il2CppStructArray_1_Connection_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SendType_Il2CppStructArray_1_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x0004141C File Offset: 0x0003F61C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936932, XrefRangeEnd = 936937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendMessages(Il2CppStructArray<Connection> connections, int connectionCount, string str, SendType sendType = SendType.Reliable, Il2CppStructArray<Result> results = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(connections);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref connectionCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionManager.NativeMethodInfoPtr_SendMessages_Public_Void_Il2CppStructArray_1_Connection_Int32_String_SendType_Il2CppStructArray_1_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x000414A0 File Offset: 0x0003F6A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936940, RefRangeEnd = 936941, XrefRangeStart = 936937, XrefRangeEnd = 936940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveMessage(ref NetMsg* msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConnectionManager.NativeMethodInfoPtr_ReceiveMessage_Internal_Void_byref_ptr_NetMsg_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				msg = ((intPtr4 == 0) ? null : new NetMsg*(intPtr4));
			}
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x000414F8 File Offset: 0x0003F6F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936941, XrefRangeEnd = 936944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnMessage(IntPtr data, int size, long messageNum, long recvTime, int channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref data;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref messageNum;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recvTime;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConnectionManager.NativeMethodInfoPtr_OnMessage_Public_Virtual_New_Void_IntPtr_Int32_Int64_Int64_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x0004157C File Offset: 0x0003F77C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936944, XrefRangeEnd = 936945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConnectionManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConnectionManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x000024C1 File Offset: 0x000006C1
		public ConnectionManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600081B RID: 2075 RVA: 0x000415B8 File Offset: 0x0003F7B8
		// (set) Token: 0x0600081C RID: 2076 RVA: 0x000024CA File Offset: 0x000006CA
		public unsafe IConnectionManager _Interface_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionManager.NativeFieldInfoPtr__Interface_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IConnectionManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionManager.NativeFieldInfoPtr__Interface_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600081D RID: 2077 RVA: 0x000415E8 File Offset: 0x0003F7E8
		// (set) Token: 0x0600081E RID: 2078 RVA: 0x000024E9 File Offset: 0x000006E9
		public unsafe Connection Connection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionManager.NativeFieldInfoPtr_Connection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionManager.NativeFieldInfoPtr_Connection)) = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600081F RID: 2079 RVA: 0x00041610 File Offset: 0x0003F810
		// (set) Token: 0x06000820 RID: 2080 RVA: 0x00002504 File Offset: 0x00000704
		public ConnectionInfo _ConnectionInfo_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionManager.NativeFieldInfoPtr__ConnectionInfo_k__BackingField);
				return new ConnectionInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConnectionInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionManager.NativeFieldInfoPtr__ConnectionInfo_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConnectionInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x00041640 File Offset: 0x0003F840
		// (set) Token: 0x06000822 RID: 2082 RVA: 0x00002532 File Offset: 0x00000732
		public unsafe bool Connected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionManager.NativeFieldInfoPtr_Connected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionManager.NativeFieldInfoPtr_Connected)) = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000823 RID: 2083 RVA: 0x00041668 File Offset: 0x0003F868
		// (set) Token: 0x06000824 RID: 2084 RVA: 0x0000254D File Offset: 0x0000074D
		public unsafe bool Connecting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionManager.NativeFieldInfoPtr_Connecting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionManager.NativeFieldInfoPtr_Connecting)) = value;
			}
		}

		// Token: 0x04000F53 RID: 3923
		private static readonly IntPtr NativeFieldInfoPtr__Interface_k__BackingField;

		// Token: 0x04000F54 RID: 3924
		private static readonly IntPtr NativeFieldInfoPtr_Connection;

		// Token: 0x04000F55 RID: 3925
		private static readonly IntPtr NativeFieldInfoPtr__ConnectionInfo_k__BackingField;

		// Token: 0x04000F56 RID: 3926
		private static readonly IntPtr NativeFieldInfoPtr_Connected;

		// Token: 0x04000F57 RID: 3927
		private static readonly IntPtr NativeFieldInfoPtr_Connecting;

		// Token: 0x04000F58 RID: 3928
		private static readonly IntPtr NativeMethodInfoPtr_get_Interface_Public_get_IConnectionManager_0;

		// Token: 0x04000F59 RID: 3929
		private static readonly IntPtr NativeMethodInfoPtr_set_Interface_Public_set_Void_IConnectionManager_0;

		// Token: 0x04000F5A RID: 3930
		private static readonly IntPtr NativeMethodInfoPtr_get_ConnectionInfo_Public_get_ConnectionInfo_0;

		// Token: 0x04000F5B RID: 3931
		private static readonly IntPtr NativeMethodInfoPtr_set_ConnectionInfo_Internal_set_Void_ConnectionInfo_0;

		// Token: 0x04000F5C RID: 3932
		private static readonly IntPtr NativeMethodInfoPtr_get_ConnectionName_Public_get_String_0;

		// Token: 0x04000F5D RID: 3933
		private static readonly IntPtr NativeMethodInfoPtr_set_ConnectionName_Public_set_Void_String_0;

		// Token: 0x04000F5E RID: 3934
		private static readonly IntPtr NativeMethodInfoPtr_get_UserData_Public_get_Int64_0;

		// Token: 0x04000F5F RID: 3935
		private static readonly IntPtr NativeMethodInfoPtr_set_UserData_Public_set_Void_Int64_0;

		// Token: 0x04000F60 RID: 3936
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_Boolean_Int32_String_0;

		// Token: 0x04000F61 RID: 3937
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000F62 RID: 3938
		private static readonly IntPtr NativeMethodInfoPtr_OnConnectionChanged_Public_Virtual_New_Void_ConnectionInfo_0;

		// Token: 0x04000F63 RID: 3939
		private static readonly IntPtr NativeMethodInfoPtr_OnConnecting_Public_Virtual_New_Void_ConnectionInfo_0;

		// Token: 0x04000F64 RID: 3940
		private static readonly IntPtr NativeMethodInfoPtr_OnConnected_Public_Virtual_New_Void_ConnectionInfo_0;

		// Token: 0x04000F65 RID: 3941
		private static readonly IntPtr NativeMethodInfoPtr_OnDisconnected_Public_Virtual_New_Void_ConnectionInfo_0;

		// Token: 0x04000F66 RID: 3942
		private static readonly IntPtr NativeMethodInfoPtr_Receive_Public_Int32_Int32_Boolean_0;

		// Token: 0x04000F67 RID: 3943
		private static readonly IntPtr NativeMethodInfoPtr_SendMessages_Public_Void_Il2CppStructArray_1_Connection_Int32_IntPtr_Int32_SendType_Il2CppStructArray_1_Result_0;

		// Token: 0x04000F68 RID: 3944
		private static readonly IntPtr NativeMethodInfoPtr_SendMessages_Public_Void_Il2CppStructArray_1_Connection_Int32_Il2CppStructArray_1_Byte_SendType_Il2CppStructArray_1_Result_0;

		// Token: 0x04000F69 RID: 3945
		private static readonly IntPtr NativeMethodInfoPtr_SendMessages_Public_Void_Il2CppStructArray_1_Connection_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SendType_Il2CppStructArray_1_Result_0;

		// Token: 0x04000F6A RID: 3946
		private static readonly IntPtr NativeMethodInfoPtr_SendMessages_Public_Void_Il2CppStructArray_1_Connection_Int32_String_SendType_Il2CppStructArray_1_Result_0;

		// Token: 0x04000F6B RID: 3947
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveMessage_Internal_Void_byref_ptr_NetMsg_0;

		// Token: 0x04000F6C RID: 3948
		private static readonly IntPtr NativeMethodInfoPtr_OnMessage_Public_Virtual_New_Void_IntPtr_Int32_Int64_Int64_Int32_0;

		// Token: 0x04000F6D RID: 3949
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
