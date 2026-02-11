using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Net.NetworkInformation;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;
using Il2CppSystem.Threading.Tasks.Sources;

namespace Il2CppSystem.Net.Sockets
{
	// Token: 0x02000231 RID: 561
	public class Socket : Object
	{
		// Token: 0x06002531 RID: 9521 RVA: 0x000AAF8C File Offset: 0x000A918C
		// Note: this type is marked as 'beforefieldinit'.
		static Socket()
		{
			Il2CppClassPointerStore<Socket>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Sockets", "Socket");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Socket>.NativeClassPtr);
			Socket.NativeFieldInfoPtr_AcceptCompletedHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "AcceptCompletedHandler");
			Socket.NativeFieldInfoPtr_ReceiveCompletedHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "ReceiveCompletedHandler");
			Socket.NativeFieldInfoPtr_SendCompletedHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "SendCompletedHandler");
			Socket.NativeFieldInfoPtr_s_rentedSocketSentinel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "s_rentedSocketSentinel");
			Socket.NativeFieldInfoPtr_s_rentedInt32Sentinel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "s_rentedInt32Sentinel");
			Socket.NativeFieldInfoPtr_s_zeroTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "s_zeroTask");
			Socket.NativeFieldInfoPtr__cachedTaskEventArgs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "_cachedTaskEventArgs");
			Socket.NativeFieldInfoPtr_s_InternalSyncObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "s_InternalSyncObject");
			Socket.NativeFieldInfoPtr_s_SupportsIPv4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "s_SupportsIPv4");
			Socket.NativeFieldInfoPtr_s_SupportsIPv6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "s_SupportsIPv6");
			Socket.NativeFieldInfoPtr_s_OSSupportsIPv6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "s_OSSupportsIPv6");
			Socket.NativeFieldInfoPtr_s_Initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "s_Initialized");
			Socket.NativeFieldInfoPtr_s_LoggingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "s_LoggingEnabled");
			Socket.NativeFieldInfoPtr_is_closed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "is_closed");
			Socket.NativeFieldInfoPtr_is_listening = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "is_listening");
			Socket.NativeFieldInfoPtr_linger_timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "linger_timeout");
			Socket.NativeFieldInfoPtr_addressFamily = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "addressFamily");
			Socket.NativeFieldInfoPtr_socketType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "socketType");
			Socket.NativeFieldInfoPtr_protocolType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "protocolType");
			Socket.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "m_Handle");
			Socket.NativeFieldInfoPtr_seed_endpoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "seed_endpoint");
			Socket.NativeFieldInfoPtr_ReadSem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "ReadSem");
			Socket.NativeFieldInfoPtr_WriteSem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "WriteSem");
			Socket.NativeFieldInfoPtr_is_blocking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "is_blocking");
			Socket.NativeFieldInfoPtr_is_bound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "is_bound");
			Socket.NativeFieldInfoPtr_is_connected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "is_connected");
			Socket.NativeFieldInfoPtr_m_IntCleanedUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "m_IntCleanedUp");
			Socket.NativeFieldInfoPtr_connect_in_progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "connect_in_progress");
			Socket.NativeFieldInfoPtr_AcceptAsyncCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "AcceptAsyncCallback");
			Socket.NativeFieldInfoPtr_BeginAcceptCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "BeginAcceptCallback");
			Socket.NativeFieldInfoPtr_BeginAcceptReceiveCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "BeginAcceptReceiveCallback");
			Socket.NativeFieldInfoPtr_ConnectAsyncCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "ConnectAsyncCallback");
			Socket.NativeFieldInfoPtr_BeginConnectCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "BeginConnectCallback");
			Socket.NativeFieldInfoPtr_DisconnectAsyncCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "DisconnectAsyncCallback");
			Socket.NativeFieldInfoPtr_BeginDisconnectCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "BeginDisconnectCallback");
			Socket.NativeFieldInfoPtr_ReceiveAsyncCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "ReceiveAsyncCallback");
			Socket.NativeFieldInfoPtr_BeginReceiveCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "BeginReceiveCallback");
			Socket.NativeFieldInfoPtr_BeginReceiveGenericCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "BeginReceiveGenericCallback");
			Socket.NativeFieldInfoPtr_ReceiveFromAsyncCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "ReceiveFromAsyncCallback");
			Socket.NativeFieldInfoPtr_BeginReceiveFromCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "BeginReceiveFromCallback");
			Socket.NativeFieldInfoPtr_SendAsyncCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "SendAsyncCallback");
			Socket.NativeFieldInfoPtr_BeginSendGenericCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "BeginSendGenericCallback");
			Socket.NativeFieldInfoPtr_SendToAsyncCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "SendToAsyncCallback");
			Socket.NativeMethodInfoPtr_ConnectAsync_Internal_Task_IPAddress_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668803);
			Socket.NativeMethodInfoPtr_ReceiveAsync_Internal_ValueTask_1_Int32_Memory_1_Byte_SocketFlags_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668804);
			Socket.NativeMethodInfoPtr_ReceiveAsyncApm_Private_Task_1_Int32_Memory_1_Byte_SocketFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668805);
			Socket.NativeMethodInfoPtr_SendAsyncForNetworkStream_Internal_ValueTask_ReadOnlyMemory_1_Byte_SocketFlags_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668806);
			Socket.NativeMethodInfoPtr_SendAsyncApm_Private_Task_1_Int32_ReadOnlyMemory_1_Byte_SocketFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668807);
			Socket.NativeMethodInfoPtr_CompleteAccept_Private_Static_Void_Socket_TaskSocketAsyncEventArgs_1_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668808);
			Socket.NativeMethodInfoPtr_CompleteSendReceive_Private_Static_Void_Socket_Int32TaskSocketAsyncEventArgs_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668809);
			Socket.NativeMethodInfoPtr_GetException_Private_Static_Exception_SocketError_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668810);
			Socket.NativeMethodInfoPtr_ReturnSocketAsyncEventArgs_Private_Void_Int32TaskSocketAsyncEventArgs_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668811);
			Socket.NativeMethodInfoPtr_ReturnSocketAsyncEventArgs_Private_Void_TaskSocketAsyncEventArgs_1_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668812);
			Socket.NativeMethodInfoPtr__ctor_Public_Void_AddressFamily_SocketType_ProtocolType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668813);
			Socket.NativeMethodInfoPtr_get_OSSupportsIPv4_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668814);
			Socket.NativeMethodInfoPtr_get_OSSupportsIPv6_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668815);
			Socket.NativeMethodInfoPtr_get_Handle_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668816);
			Socket.NativeMethodInfoPtr_get_AddressFamily_Public_get_AddressFamily_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668817);
			Socket.NativeMethodInfoPtr_get_SocketType_Public_get_SocketType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668818);
			Socket.NativeMethodInfoPtr_get_ProtocolType_Public_get_ProtocolType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668819);
			Socket.NativeMethodInfoPtr_set_ExclusiveAddressUse_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668820);
			Socket.NativeMethodInfoPtr_set_ReceiveTimeout_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668821);
			Socket.NativeMethodInfoPtr_set_SendTimeout_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668822);
			Socket.NativeMethodInfoPtr_set_DontFragment_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668823);
			Socket.NativeMethodInfoPtr_get_DualMode_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668824);
			Socket.NativeMethodInfoPtr_set_DualMode_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668825);
			Socket.NativeMethodInfoPtr_get_IsDualMode_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668826);
			Socket.NativeMethodInfoPtr_CanTryAddressFamily_Internal_Boolean_AddressFamily_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668827);
			Socket.NativeMethodInfoPtr_Send_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668828);
			Socket.NativeMethodInfoPtr_Send_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668829);
			Socket.NativeMethodInfoPtr_Receive_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668830);
			Socket.NativeMethodInfoPtr_Receive_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668831);
			Socket.NativeMethodInfoPtr_IOControl_Public_Int32_IOControlCode_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668832);
			Socket.NativeMethodInfoPtr_SetIPProtectionLevel_Public_Void_IPProtectionLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668833);
			Socket.NativeMethodInfoPtr_BeginConnect_Public_IAsyncResult_IPAddress_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668834);
			Socket.NativeMethodInfoPtr_BeginSend_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668835);
			Socket.NativeMethodInfoPtr_EndSend_Public_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668836);
			Socket.NativeMethodInfoPtr_BeginReceive_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668837);
			Socket.NativeMethodInfoPtr_EndReceive_Public_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668838);
			Socket.NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668839);
			Socket.NativeMethodInfoPtr_get_CleanedUp_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668840);
			Socket.NativeMethodInfoPtr_InitializeSockets_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668841);
			Socket.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668842);
			Socket.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668843);
			Socket.NativeMethodInfoPtr_InternalShutdown_Internal_Void_SocketShutdown_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668844);
			Socket.NativeMethodInfoPtr_SetSocketOption_Internal_Void_SocketOptionLevel_SocketOptionName_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668845);
			Socket.NativeMethodInfoPtr__ctor_Internal_Void_AddressFamily_SocketType_ProtocolType_SafeSocketHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668846);
			Socket.NativeMethodInfoPtr_SocketDefaults_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668847);
			Socket.NativeMethodInfoPtr_Socket_icall_Private_Static_IntPtr_AddressFamily_SocketType_ProtocolType_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668848);
			Socket.NativeMethodInfoPtr_get_IsBound_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668849);
			Socket.NativeMethodInfoPtr_get_LocalEndPoint_Public_get_EndPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668850);
			Socket.NativeMethodInfoPtr_LocalEndPoint_internal_Private_Static_SocketAddress_SafeSocketHandle_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668851);
			Socket.NativeMethodInfoPtr_LocalEndPoint_icall_Private_Static_SocketAddress_IntPtr_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668852);
			Socket.NativeMethodInfoPtr_get_Blocking_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668853);
			Socket.NativeMethodInfoPtr_set_Blocking_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668854);
			Socket.NativeMethodInfoPtr_Blocking_internal_Private_Static_Void_SafeSocketHandle_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668855);
			Socket.NativeMethodInfoPtr_Blocking_icall_Internal_Static_Void_IntPtr_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668856);
			Socket.NativeMethodInfoPtr_get_Connected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668857);
			Socket.NativeMethodInfoPtr_set_NoDelay_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668858);
			Socket.NativeMethodInfoPtr_get_RemoteEndPoint_Public_get_EndPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668859);
			Socket.NativeMethodInfoPtr_RemoteEndPoint_internal_Private_Static_SocketAddress_SafeSocketHandle_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668860);
			Socket.NativeMethodInfoPtr_RemoteEndPoint_icall_Private_Static_SocketAddress_IntPtr_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668861);
			Socket.NativeMethodInfoPtr_Poll_Public_Boolean_Int32_SelectMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668862);
			Socket.NativeMethodInfoPtr_Poll_internal_Private_Static_Boolean_SafeSocketHandle_SelectMode_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668863);
			Socket.NativeMethodInfoPtr_Poll_icall_Private_Static_Boolean_IntPtr_SelectMode_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668864);
			Socket.NativeMethodInfoPtr_Accept_Public_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668865);
			Socket.NativeMethodInfoPtr_Accept_Internal_Void_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668866);
			Socket.NativeMethodInfoPtr_AcceptAsync_Public_Boolean_SocketAsyncEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668867);
			Socket.NativeMethodInfoPtr_BeginAccept_Public_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668868);
			Socket.NativeMethodInfoPtr_EndAccept_Public_Socket_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668869);
			Socket.NativeMethodInfoPtr_EndAccept_Public_Socket_byref_Il2CppStructArray_1_Byte_byref_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668870);
			Socket.NativeMethodInfoPtr_Accept_internal_Private_Static_SafeSocketHandle_SafeSocketHandle_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668871);
			Socket.NativeMethodInfoPtr_Accept_icall_Private_Static_IntPtr_IntPtr_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668872);
			Socket.NativeMethodInfoPtr_Bind_Public_Void_EndPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668873);
			Socket.NativeMethodInfoPtr_Bind_internal_Private_Static_Void_SafeSocketHandle_SocketAddress_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668874);
			Socket.NativeMethodInfoPtr_Bind_icall_Private_Static_Void_IntPtr_SocketAddress_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668875);
			Socket.NativeMethodInfoPtr_Listen_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668876);
			Socket.NativeMethodInfoPtr_Listen_internal_Private_Static_Void_SafeSocketHandle_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668877);
			Socket.NativeMethodInfoPtr_Listen_icall_Private_Static_Void_IntPtr_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668878);
			Socket.NativeMethodInfoPtr_Connect_Public_Void_IPAddress_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668879);
			Socket.NativeMethodInfoPtr_Connect_Public_Void_EndPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668880);
			Socket.NativeMethodInfoPtr_BeginConnect_Public_IAsyncResult_String_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668881);
			Socket.NativeMethodInfoPtr_BeginConnect_Public_IAsyncResult_EndPoint_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668882);
			Socket.NativeMethodInfoPtr_BeginMConnect_Private_Static_Boolean_SocketAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668883);
			Socket.NativeMethodInfoPtr_BeginSConnect_Private_Static_Boolean_SocketAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668884);
			Socket.NativeMethodInfoPtr_EndConnect_Public_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668885);
			Socket.NativeMethodInfoPtr_Connect_internal_Private_Static_Void_SafeSocketHandle_SocketAddress_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668886);
			Socket.NativeMethodInfoPtr_Connect_icall_Private_Static_Void_IntPtr_SocketAddress_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668887);
			Socket.NativeMethodInfoPtr_Disconnect_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668888);
			Socket.NativeMethodInfoPtr_EndDisconnect_Public_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668889);
			Socket.NativeMethodInfoPtr_Disconnect_internal_Private_Static_Void_SafeSocketHandle_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668890);
			Socket.NativeMethodInfoPtr_Disconnect_icall_Private_Static_Void_IntPtr_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668891);
			Socket.NativeMethodInfoPtr_Receive_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668892);
			Socket.NativeMethodInfoPtr_Receive_Private_Int32_Memory_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668893);
			Socket.NativeMethodInfoPtr_Receive_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_byref_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668894);
			Socket.NativeMethodInfoPtr_Receive_Public_Int32_Span_1_Byte_SocketFlags_byref_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668895);
			Socket.NativeMethodInfoPtr_Send_Public_Int32_ReadOnlySpan_1_Byte_SocketFlags_byref_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668896);
			Socket.NativeMethodInfoPtr_ReceiveAsync_Public_Boolean_SocketAsyncEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668897);
			Socket.NativeMethodInfoPtr_BeginReceive_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668898);
			Socket.NativeMethodInfoPtr_EndReceive_Public_Int32_IAsyncResult_byref_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668899);
			Socket.NativeMethodInfoPtr_Receive_internal_Private_Static_Int32_SafeSocketHandle_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668900);
			Socket.NativeMethodInfoPtr_Receive_array_icall_Private_Static_Int32_IntPtr_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668901);
			Socket.NativeMethodInfoPtr_Receive_internal_Private_Static_Int32_SafeSocketHandle_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668902);
			Socket.NativeMethodInfoPtr_Receive_icall_Private_Static_Int32_IntPtr_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668903);
			Socket.NativeMethodInfoPtr_ReceiveFrom_Private_Int32_Memory_1_Byte_Int32_Int32_SocketFlags_byref_EndPoint_byref_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668904);
			Socket.NativeMethodInfoPtr_BeginReceiveFrom_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_EndPoint_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668905);
			Socket.NativeMethodInfoPtr_EndReceiveFrom_Public_Int32_IAsyncResult_byref_EndPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668906);
			Socket.NativeMethodInfoPtr_EndReceiveFrom_internal_Private_Int32_SocketAsyncResult_SocketAsyncEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668907);
			Socket.NativeMethodInfoPtr_ReceiveFrom_internal_Private_Static_Int32_SafeSocketHandle_ptr_Byte_Int32_SocketFlags_byref_SocketAddress_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668908);
			Socket.NativeMethodInfoPtr_ReceiveFrom_icall_Private_Static_Int32_IntPtr_ptr_Byte_Int32_SocketFlags_byref_SocketAddress_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668909);
			Socket.NativeMethodInfoPtr_Send_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668910);
			Socket.NativeMethodInfoPtr_Send_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_byref_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668911);
			Socket.NativeMethodInfoPtr_SendAsync_Public_Boolean_SocketAsyncEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668912);
			Socket.NativeMethodInfoPtr_BeginSend_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668913);
			Socket.NativeMethodInfoPtr_BeginSendCallback_Private_Static_Void_SocketAsyncResult_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668914);
			Socket.NativeMethodInfoPtr_EndSend_Public_Int32_IAsyncResult_byref_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668915);
			Socket.NativeMethodInfoPtr_Send_internal_Private_Static_Int32_SafeSocketHandle_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668916);
			Socket.NativeMethodInfoPtr_Send_array_icall_Private_Static_Int32_IntPtr_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668917);
			Socket.NativeMethodInfoPtr_Send_internal_Private_Static_Int32_SafeSocketHandle_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668918);
			Socket.NativeMethodInfoPtr_Send_icall_Private_Static_Int32_IntPtr_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668919);
			Socket.NativeMethodInfoPtr_SendTo_Private_Int32_Memory_1_Byte_Int32_Int32_SocketFlags_EndPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668920);
			Socket.NativeMethodInfoPtr_BeginSendTo_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_EndPoint_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668921);
			Socket.NativeMethodInfoPtr_BeginSendToCallback_Private_Static_Void_SocketAsyncResult_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668922);
			Socket.NativeMethodInfoPtr_EndSendTo_Public_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668923);
			Socket.NativeMethodInfoPtr_SendTo_internal_Private_Static_Int32_SafeSocketHandle_ptr_Byte_Int32_SocketFlags_SocketAddress_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668924);
			Socket.NativeMethodInfoPtr_SendTo_icall_Private_Static_Int32_IntPtr_ptr_Byte_Int32_SocketFlags_SocketAddress_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668925);
			Socket.NativeMethodInfoPtr_GetSocketOption_Public_Object_SocketOptionLevel_SocketOptionName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668926);
			Socket.NativeMethodInfoPtr_GetSocketOption_obj_internal_Private_Static_Void_SafeSocketHandle_SocketOptionLevel_SocketOptionName_byref_Object_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668927);
			Socket.NativeMethodInfoPtr_GetSocketOption_obj_icall_Private_Static_Void_IntPtr_SocketOptionLevel_SocketOptionName_byref_Object_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668928);
			Socket.NativeMethodInfoPtr_SetSocketOption_Public_Void_SocketOptionLevel_SocketOptionName_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668929);
			Socket.NativeMethodInfoPtr_SetSocketOption_internal_Private_Static_Void_SafeSocketHandle_SocketOptionLevel_SocketOptionName_Object_Il2CppStructArray_1_Byte_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668930);
			Socket.NativeMethodInfoPtr_SetSocketOption_icall_Private_Static_Void_IntPtr_SocketOptionLevel_SocketOptionName_Object_Il2CppStructArray_1_Byte_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668931);
			Socket.NativeMethodInfoPtr_IOControl_Public_Int32_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668932);
			Socket.NativeMethodInfoPtr_IOControl_internal_Private_Static_Int32_SafeSocketHandle_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668933);
			Socket.NativeMethodInfoPtr_IOControl_icall_Private_Static_Int32_IntPtr_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668934);
			Socket.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668935);
			Socket.NativeMethodInfoPtr_Close_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668936);
			Socket.NativeMethodInfoPtr_Close_icall_Internal_Static_Void_IntPtr_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668937);
			Socket.NativeMethodInfoPtr_Shutdown_Public_Void_SocketShutdown_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668938);
			Socket.NativeMethodInfoPtr_Shutdown_internal_Private_Static_Void_SafeSocketHandle_SocketShutdown_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668939);
			Socket.NativeMethodInfoPtr_Shutdown_icall_Internal_Static_Void_IntPtr_SocketShutdown_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668940);
			Socket.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668941);
			Socket.NativeMethodInfoPtr_Linger_Private_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668942);
			Socket.NativeMethodInfoPtr_ThrowIfDisposedAndClosed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668943);
			Socket.NativeMethodInfoPtr_ThrowIfBufferNull_Private_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668944);
			Socket.NativeMethodInfoPtr_ThrowIfBufferOutOfRange_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668945);
			Socket.NativeMethodInfoPtr_ThrowIfUdp_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668946);
			Socket.NativeMethodInfoPtr_ValidateEndIAsyncResult_Private_SocketAsyncResult_IAsyncResult_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668947);
			Socket.NativeMethodInfoPtr_QueueIOSelectorJob_Private_Void_SemaphoreSlim_IntPtr_IOSelectorJob_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668948);
			Socket.NativeMethodInfoPtr_InitSocketAsyncEventArgs_Private_Void_SocketAsyncEventArgs_AsyncCallback_Object_SocketOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668949);
			Socket.NativeMethodInfoPtr_SocketOperationToSocketAsyncOperation_Private_SocketAsyncOperation_SocketOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668950);
			Socket.NativeMethodInfoPtr_RemapIPEndPoint_Private_IPEndPoint_IPEndPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668951);
			Socket.NativeMethodInfoPtr_cancel_blocking_socket_operation_Internal_Static_Void_Thread_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668952);
			Socket.NativeMethodInfoPtr_get_FamilyHint_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668953);
			Socket.NativeMethodInfoPtr_IsProtocolSupported_internal_Private_Static_Boolean_NetworkInterfaceComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668954);
			Socket.NativeMethodInfoPtr_IsProtocolSupported_Private_Static_Boolean_NetworkInterfaceComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100668955);
		}

		// Token: 0x06002532 RID: 9522 RVA: 0x000ABF0C File Offset: 0x000AA10C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 488107, RefRangeEnd = 488108, XrefRangeStart = 488084, XrefRangeEnd = 488107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ConnectAsync(IPAddress address, int port)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(address);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_ConnectAsync_Internal_Task_IPAddress_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06002533 RID: 9523 RVA: 0x000ABF6C File Offset: 0x000AA16C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 488154, RefRangeEnd = 488156, XrefRangeStart = 488108, XrefRangeEnd = 488154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTask<int> ReceiveAsync(Memory<byte> buffer, SocketFlags socketFlags, bool fromNetworkStream, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buffer));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromNetworkStream;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_ReceiveAsync_Internal_ValueTask_1_Int32_Memory_1_Byte_SocketFlags_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTask<int>(intPtr);
		}

		// Token: 0x06002534 RID: 9524 RVA: 0x000ABFF0 File Offset: 0x000AA1F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 488204, RefRangeEnd = 488205, XrefRangeStart = 488156, XrefRangeEnd = 488204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<int> ReceiveAsyncApm(Memory<byte> buffer, SocketFlags socketFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buffer));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_ReceiveAsyncApm_Private_Task_1_Int32_Memory_1_Byte_SocketFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x06002535 RID: 9525 RVA: 0x000AC054 File Offset: 0x000AA254
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 488250, RefRangeEnd = 488252, XrefRangeStart = 488205, XrefRangeEnd = 488250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTask SendAsyncForNetworkStream(ReadOnlyMemory<byte> buffer, SocketFlags socketFlags, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buffer));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_SendAsyncForNetworkStream_Internal_ValueTask_ReadOnlyMemory_1_Byte_SocketFlags_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTask(intPtr);
		}

		// Token: 0x06002536 RID: 9526 RVA: 0x000AC0C8 File Offset: 0x000AA2C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 488306, RefRangeEnd = 488307, XrefRangeStart = 488252, XrefRangeEnd = 488306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<int> SendAsyncApm(ReadOnlyMemory<byte> buffer, SocketFlags socketFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buffer));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_SendAsyncApm_Private_Task_1_Int32_ReadOnlyMemory_1_Byte_SocketFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x06002537 RID: 9527 RVA: 0x000AC12C File Offset: 0x000AA32C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488307, XrefRangeEnd = 488329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CompleteAccept(Socket s, Socket.TaskSocketAsyncEventArgs<Socket> saea)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(saea);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_CompleteAccept_Private_Static_Void_Socket_TaskSocketAsyncEventArgs_1_Socket_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002538 RID: 9528 RVA: 0x000AC174 File Offset: 0x000AA374
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 488347, RefRangeEnd = 488349, XrefRangeStart = 488329, XrefRangeEnd = 488347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CompleteSendReceive(Socket s, Socket.Int32TaskSocketAsyncEventArgs saea, bool isReceive)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(saea);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isReceive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_CompleteSendReceive_Private_Static_Void_Socket_Int32TaskSocketAsyncEventArgs_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002539 RID: 9529 RVA: 0x000AC1CC File Offset: 0x000AA3CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 488360, RefRangeEnd = 488361, XrefRangeStart = 488349, XrefRangeEnd = 488360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception GetException(SocketError error, bool wrapExceptionsInIOExceptions = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref error;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wrapExceptionsInIOExceptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_GetException_Private_Static_Exception_SocketError_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x000AC21C File Offset: 0x000AA41C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488361, XrefRangeEnd = 488366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReturnSocketAsyncEventArgs(Socket.Int32TaskSocketAsyncEventArgs saea, bool isReceive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(saea);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isReceive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_ReturnSocketAsyncEventArgs_Private_Void_Int32TaskSocketAsyncEventArgs_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600253B RID: 9531 RVA: 0x000AC26C File Offset: 0x000AA46C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488366, XrefRangeEnd = 488370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReturnSocketAsyncEventArgs(Socket.TaskSocketAsyncEventArgs<Socket> saea)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(saea);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_ReturnSocketAsyncEventArgs_Private_Void_TaskSocketAsyncEventArgs_1_Socket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600253C RID: 9532 RVA: 0x000AC2B0 File Offset: 0x000AA4B0
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 488407, RefRangeEnd = 488421, XrefRangeStart = 488370, XrefRangeEnd = 488407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Socket(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Socket>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref addressFamily;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref protocolType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr__ctor_Public_Void_AddressFamily_SocketType_ProtocolType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x0600253D RID: 9533 RVA: 0x000AC314 File Offset: 0x000AA514
		public unsafe static bool OSSupportsIPv4
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 488427, RefRangeEnd = 488429, XrefRangeStart = 488421, XrefRangeEnd = 488427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_OSSupportsIPv4_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x0600253E RID: 9534 RVA: 0x000AC344 File Offset: 0x000AA544
		public unsafe static bool OSSupportsIPv6
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 488435, RefRangeEnd = 488437, XrefRangeStart = 488429, XrefRangeEnd = 488435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_OSSupportsIPv6_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x0600253F RID: 9535 RVA: 0x000AC374 File Offset: 0x000AA574
		public unsafe IntPtr Handle
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 372752, RefRangeEnd = 372755, XrefRangeStart = 372752, XrefRangeEnd = 372755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_Handle_Public_get_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x06002540 RID: 9536 RVA: 0x000AC3B0 File Offset: 0x000AA5B0
		public unsafe AddressFamily AddressFamily
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_AddressFamily_Public_get_AddressFamily_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x06002541 RID: 9537 RVA: 0x000AC3EC File Offset: 0x000AA5EC
		public unsafe SocketType SocketType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_SocketType_Public_get_SocketType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x06002542 RID: 9538 RVA: 0x000AC428 File Offset: 0x000AA628
		public unsafe ProtocolType ProtocolType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_ProtocolType_Public_get_ProtocolType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C03 RID: 3075
		// (set) Token: 0x06002543 RID: 9539 RVA: 0x000AC464 File Offset: 0x000AA664
		public unsafe bool ExclusiveAddressUse
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488437, XrefRangeEnd = 488438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_set_ExclusiveAddressUse_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C04 RID: 3076
		// (set) Token: 0x06002544 RID: 9540 RVA: 0x000AC4A4 File Offset: 0x000AA6A4
		public unsafe int ReceiveTimeout
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 488439, RefRangeEnd = 488440, XrefRangeStart = 488438, XrefRangeEnd = 488439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_set_ReceiveTimeout_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C05 RID: 3077
		// (set) Token: 0x06002545 RID: 9541 RVA: 0x000AC4E4 File Offset: 0x000AA6E4
		public unsafe int SendTimeout
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 488441, RefRangeEnd = 488442, XrefRangeStart = 488440, XrefRangeEnd = 488441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_set_SendTimeout_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C06 RID: 3078
		// (set) Token: 0x06002546 RID: 9542 RVA: 0x000AC524 File Offset: 0x000AA724
		public unsafe bool DontFragment
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488442, XrefRangeEnd = 488443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_set_DontFragment_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x06002547 RID: 9543 RVA: 0x000AC564 File Offset: 0x000AA764
		// (set) Token: 0x06002548 RID: 9544 RVA: 0x000AC5A0 File Offset: 0x000AA7A0
		public unsafe bool DualMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488443, XrefRangeEnd = 488447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_DualMode_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488447, XrefRangeEnd = 488448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_set_DualMode_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x06002549 RID: 9545 RVA: 0x000AC5E0 File Offset: 0x000AA7E0
		public unsafe bool IsDualMode
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 488448, RefRangeEnd = 488452, XrefRangeStart = 488448, XrefRangeEnd = 488448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_IsDualMode_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600254A RID: 9546 RVA: 0x000AC61C File Offset: 0x000AA81C
		[CallerCount(0)]
		public unsafe bool CanTryAddressFamily(AddressFamily family)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref family;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_CanTryAddressFamily_Internal_Boolean_AddressFamily_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600254B RID: 9547 RVA: 0x000AC668 File Offset: 0x000AA868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488452, XrefRangeEnd = 488453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffers);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Send_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600254C RID: 9548 RVA: 0x000AC6C4 File Offset: 0x000AA8C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488453, XrefRangeEnd = 488454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Send(Il2CppStructArray<byte> buffer, int offset, int size, SocketFlags socketFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Send_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600254D RID: 9549 RVA: 0x000AC73C File Offset: 0x000AA93C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488454, XrefRangeEnd = 488455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Receive(Il2CppStructArray<byte> buffer, int offset, int size, SocketFlags socketFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Receive_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600254E RID: 9550 RVA: 0x000AC7B4 File Offset: 0x000AA9B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488455, XrefRangeEnd = 488456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffers);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Receive_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600254F RID: 9551 RVA: 0x000AC810 File Offset: 0x000AAA10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 488460, RefRangeEnd = 488461, XrefRangeStart = 488456, XrefRangeEnd = 488460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IOControl(IOControlCode ioControlCode, Il2CppStructArray<byte> optionInValue, Il2CppStructArray<byte> optionOutValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ioControlCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(optionInValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(optionOutValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_IOControl_Public_Int32_IOControlCode_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002550 RID: 9552 RVA: 0x000AC880 File Offset: 0x000AAA80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488461, XrefRangeEnd = 488462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIPProtectionLevel(IPProtectionLevel level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref level;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_SetIPProtectionLevel_Public_Void_IPProtectionLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002551 RID: 9553 RVA: 0x000AC8C0 File Offset: 0x000AAAC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 488489, RefRangeEnd = 488490, XrefRangeStart = 488462, XrefRangeEnd = 488489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginConnect(IPAddress address, int port, AsyncCallback requestCallback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(address);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(requestCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_BeginConnect_Public_IAsyncResult_IPAddress_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06002552 RID: 9554 RVA: 0x000AC944 File Offset: 0x000AAB44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 488491, RefRangeEnd = 488493, XrefRangeStart = 488490, XrefRangeEnd = 488491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginSend(Il2CppStructArray<byte> buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_BeginSend_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06002553 RID: 9555 RVA: 0x000AC9E4 File Offset: 0x000AABE4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 488502, RefRangeEnd = 488507, XrefRangeStart = 488493, XrefRangeEnd = 488502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int EndSend(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_EndSend_Public_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002554 RID: 9556 RVA: 0x000ACA34 File Offset: 0x000AAC34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 488527, RefRangeEnd = 488529, XrefRangeStart = 488507, XrefRangeEnd = 488527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginReceive(Il2CppStructArray<byte> buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_BeginReceive_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06002555 RID: 9557 RVA: 0x000ACAD4 File Offset: 0x000AACD4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 488538, RefRangeEnd = 488542, XrefRangeStart = 488529, XrefRangeEnd = 488538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int EndReceive(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_EndReceive_Public_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x06002556 RID: 9558 RVA: 0x000ACB24 File Offset: 0x000AAD24
		public unsafe static Object InternalSyncObject
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488542, XrefRangeEnd = 488557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x06002557 RID: 9559 RVA: 0x000ACB58 File Offset: 0x000AAD58
		public unsafe bool CleanedUp
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 488557, RefRangeEnd = 488558, XrefRangeStart = 488557, XrefRangeEnd = 488557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_CleanedUp_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002558 RID: 9560 RVA: 0x000ACB94 File Offset: 0x000AAD94
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 488614, RefRangeEnd = 488620, XrefRangeStart = 488558, XrefRangeEnd = 488614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeSockets()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_InitializeSockets_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002559 RID: 9561 RVA: 0x000ACBBC File Offset: 0x000AADBC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 488624, RefRangeEnd = 488627, XrefRangeStart = 488620, XrefRangeEnd = 488624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600255A RID: 9562 RVA: 0x000ACBF0 File Offset: 0x000AADF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Socket.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600255B RID: 9563 RVA: 0x000ACC2C File Offset: 0x000AAE2C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 488631, RefRangeEnd = 488635, XrefRangeStart = 488627, XrefRangeEnd = 488631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalShutdown(SocketShutdown how)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref how;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_InternalShutdown_Internal_Void_SocketShutdown_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600255C RID: 9564 RVA: 0x000ACC6C File Offset: 0x000AAE6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 488640, RefRangeEnd = 488642, XrefRangeStart = 488635, XrefRangeEnd = 488640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue, bool silent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref optionLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref optionName;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref optionValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref silent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_SetSocketOption_Internal_Void_SocketOptionLevel_SocketOptionName_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600255D RID: 9565 RVA: 0x000ACCD4 File Offset: 0x000AAED4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 488657, RefRangeEnd = 488658, XrefRangeStart = 488642, XrefRangeEnd = 488657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Socket(AddressFamily family, SocketType type, ProtocolType proto, SafeSocketHandle safe_handle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Socket>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref family;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref proto;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(safe_handle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr__ctor_Internal_Void_AddressFamily_SocketType_ProtocolType_SafeSocketHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600255E RID: 9566 RVA: 0x000ACD4C File Offset: 0x000AAF4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 488660, RefRangeEnd = 488661, XrefRangeStart = 488658, XrefRangeEnd = 488660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SocketDefaults()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_SocketDefaults_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600255F RID: 9567 RVA: 0x000ACD80 File Offset: 0x000AAF80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488661, XrefRangeEnd = 488662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Socket_icall(AddressFamily family, SocketType type, ProtocolType proto, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref family;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref proto;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Socket_icall_Private_Static_IntPtr_AddressFamily_SocketType_ProtocolType_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x06002560 RID: 9568 RVA: 0x000ACDE8 File Offset: 0x000AAFE8
		public unsafe bool IsBound
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_IsBound_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x06002561 RID: 9569 RVA: 0x000ACE24 File Offset: 0x000AB024
		public unsafe EndPoint LocalEndPoint
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 488667, RefRangeEnd = 488672, XrefRangeStart = 488662, XrefRangeEnd = 488667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_LocalEndPoint_Public_get_EndPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EndPoint>(intPtr3) : null;
			}
		}

		// Token: 0x06002562 RID: 9570 RVA: 0x000ACE64 File Offset: 0x000AB064
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 488680, RefRangeEnd = 488682, XrefRangeStart = 488672, XrefRangeEnd = 488680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SocketAddress LocalEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref family;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_LocalEndPoint_internal_Private_Static_SocketAddress_SafeSocketHandle_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SocketAddress>(intPtr3) : null;
		}

		// Token: 0x06002563 RID: 9571 RVA: 0x000ACEC4 File Offset: 0x000AB0C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488682, XrefRangeEnd = 488683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SocketAddress LocalEndPoint_icall(IntPtr socket, int family, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref socket;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref family;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_LocalEndPoint_icall_Private_Static_SocketAddress_IntPtr_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SocketAddress>(intPtr3) : null;
		}

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x06002564 RID: 9572 RVA: 0x000ACF20 File Offset: 0x000AB120
		// (set) Token: 0x06002565 RID: 9573 RVA: 0x000ACF5C File Offset: 0x000AB15C
		public unsafe bool Blocking
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_Blocking_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 488688, RefRangeEnd = 488690, XrefRangeStart = 488683, XrefRangeEnd = 488688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_set_Blocking_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002566 RID: 9574 RVA: 0x000ACF9C File Offset: 0x000AB19C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 488698, RefRangeEnd = 488699, XrefRangeStart = 488690, XrefRangeEnd = 488698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Blocking_internal(SafeSocketHandle safeHandle, bool block, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref block;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Blocking_internal_Private_Static_Void_SafeSocketHandle_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002567 RID: 9575 RVA: 0x000ACFF0 File Offset: 0x000AB1F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 488700, RefRangeEnd = 488701, XrefRangeStart = 488699, XrefRangeEnd = 488700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Blocking_icall(IntPtr socket, bool block, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref socket;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref block;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Blocking_icall_Internal_Static_Void_IntPtr_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x06002568 RID: 9576 RVA: 0x000AD040 File Offset: 0x000AB240
		public unsafe bool Connected
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_Connected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C0F RID: 3087
		// (set) Token: 0x06002569 RID: 9577 RVA: 0x000AD07C File Offset: 0x000AB27C
		public unsafe bool NoDelay
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488701, XrefRangeEnd = 488703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_set_NoDelay_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x0600256A RID: 9578 RVA: 0x000AD0BC File Offset: 0x000AB2BC
		public unsafe EndPoint RemoteEndPoint
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 488708, RefRangeEnd = 488711, XrefRangeStart = 488703, XrefRangeEnd = 488708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_RemoteEndPoint_Public_get_EndPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EndPoint>(intPtr3) : null;
			}
		}

		// Token: 0x0600256B RID: 9579 RVA: 0x000AD0FC File Offset: 0x000AB2FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 488719, RefRangeEnd = 488720, XrefRangeStart = 488711, XrefRangeEnd = 488719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SocketAddress RemoteEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref family;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_RemoteEndPoint_internal_Private_Static_SocketAddress_SafeSocketHandle_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SocketAddress>(intPtr3) : null;
		}

		// Token: 0x0600256C RID: 9580 RVA: 0x000AD15C File Offset: 0x000AB35C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488720, XrefRangeEnd = 488721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SocketAddress RemoteEndPoint_icall(IntPtr socket, int family, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref socket;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref family;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_RemoteEndPoint_icall_Private_Static_SocketAddress_IntPtr_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SocketAddress>(intPtr3) : null;
		}

		// Token: 0x0600256D RID: 9581 RVA: 0x000AD1B8 File Offset: 0x000AB3B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 488730, RefRangeEnd = 488732, XrefRangeStart = 488721, XrefRangeEnd = 488730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Poll(int microSeconds, SelectMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref microSeconds;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Poll_Public_Boolean_Int32_SelectMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600256E RID: 9582 RVA: 0x000AD210 File Offset: 0x000AB410
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 488740, RefRangeEnd = 488741, XrefRangeStart = 488732, XrefRangeEnd = 488740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Poll_internal(SafeSocketHandle safeHandle, SelectMode mode, int timeout, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeout;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Poll_internal_Private_Static_Boolean_SafeSocketHandle_SelectMode_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600256F RID: 9583 RVA: 0x000AD27C File Offset: 0x000AB47C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488741, XrefRangeEnd = 488742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Poll_icall(IntPtr socket, SelectMode mode, int timeout, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref socket;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeout;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Poll_icall_Private_Static_Boolean_IntPtr_SelectMode_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002570 RID: 9584 RVA: 0x000AD2E4 File Offset: 0x000AB4E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 488752, RefRangeEnd = 488755, XrefRangeStart = 488742, XrefRangeEnd = 488752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Socket Accept()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Accept_Public_Socket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr3) : null;
		}

		// Token: 0x06002571 RID: 9585 RVA: 0x000AD324 File Offset: 0x000AB524
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 488763, RefRangeEnd = 488765, XrefRangeStart = 488755, XrefRangeEnd = 488763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Accept(Socket acceptSocket)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(acceptSocket);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Accept_Internal_Void_Socket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002572 RID: 9586 RVA: 0x000AD368 File Offset: 0x000AB568
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 488778, RefRangeEnd = 488779, XrefRangeStart = 488765, XrefRangeEnd = 488778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AcceptAsync(SocketAsyncEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_AcceptAsync_Public_Boolean_SocketAsyncEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002573 RID: 9587 RVA: 0x000AD3B8 File Offset: 0x000AB5B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 488794, RefRangeEnd = 488795, XrefRangeStart = 488779, XrefRangeEnd = 488794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginAccept(AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_BeginAccept_Public_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06002574 RID: 9588 RVA: 0x000AD41C File Offset: 0x000AB61C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 488807, RefRangeEnd = 488810, XrefRangeStart = 488795, XrefRangeEnd = 488807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Socket EndAccept(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_EndAccept_Public_Socket_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr3) : null;
			}
		}

		// Token: 0x06002575 RID: 9589 RVA: 0x000AD46C File Offset: 0x000AB66C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488810, XrefRangeEnd = 488822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Socket EndAccept(out Il2CppStructArray<byte> buffer, out int bytesTransferred, IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bytesTransferred;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_EndAccept_Public_Socket_byref_Il2CppStructArray_1_Byte_byref_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			buffer = ((intPtr4 == 0) ? null : new Il2CppStructArray<byte>(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr5) : null;
		}

		// Token: 0x06002576 RID: 9590 RVA: 0x000AD4F0 File Offset: 0x000AB6F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 488834, RefRangeEnd = 488836, XrefRangeStart = 488822, XrefRangeEnd = 488834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SafeSocketHandle Accept_internal(SafeSocketHandle safeHandle, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Accept_internal_Private_Static_SafeSocketHandle_SafeSocketHandle_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SafeSocketHandle>(intPtr3) : null;
		}

		// Token: 0x06002577 RID: 9591 RVA: 0x000AD550 File Offset: 0x000AB750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488836, XrefRangeEnd = 488837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Accept_icall(IntPtr sock, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sock;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Accept_icall_Private_Static_IntPtr_IntPtr_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002578 RID: 9592 RVA: 0x000AD5AC File Offset: 0x000AB7AC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 488847, RefRangeEnd = 488851, XrefRangeStart = 488837, XrefRangeEnd = 488847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bind(EndPoint localEP)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(localEP);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Bind_Public_Void_EndPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002579 RID: 9593 RVA: 0x000AD5F0 File Offset: 0x000AB7F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 488859, RefRangeEnd = 488861, XrefRangeStart = 488851, XrefRangeEnd = 488859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Bind_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sa);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Bind_internal_Private_Static_Void_SafeSocketHandle_SocketAddress_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600257A RID: 9594 RVA: 0x000AD648 File Offset: 0x000AB848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488861, XrefRangeEnd = 488862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Bind_icall(IntPtr sock, SocketAddress sa, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sock;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sa);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Bind_icall_Private_Static_Void_IntPtr_SocketAddress_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600257B RID: 9595 RVA: 0x000AD69C File Offset: 0x000AB89C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 488867, RefRangeEnd = 488869, XrefRangeStart = 488862, XrefRangeEnd = 488867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Listen(int backlog)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref backlog;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Listen_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600257C RID: 9596 RVA: 0x000AD6DC File Offset: 0x000AB8DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 488877, RefRangeEnd = 488879, XrefRangeStart = 488869, XrefRangeEnd = 488877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Listen_internal(SafeSocketHandle safeHandle, int backlog, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref backlog;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Listen_internal_Private_Static_Void_SafeSocketHandle_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600257D RID: 9597 RVA: 0x000AD730 File Offset: 0x000AB930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488879, XrefRangeEnd = 488880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Listen_icall(IntPtr sock, int backlog, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sock;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref backlog;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Listen_icall_Private_Static_Void_IntPtr_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600257E RID: 9598 RVA: 0x000AD780 File Offset: 0x000AB980
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 488885, RefRangeEnd = 488887, XrefRangeStart = 488880, XrefRangeEnd = 488885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Connect(IPAddress address, int port)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(address);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Connect_Public_Void_IPAddress_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600257F RID: 9599 RVA: 0x000AD7D0 File Offset: 0x000AB9D0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 488911, RefRangeEnd = 488915, XrefRangeStart = 488887, XrefRangeEnd = 488911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Connect(EndPoint remoteEP)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(remoteEP);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Connect_Public_Void_EndPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002580 RID: 9600 RVA: 0x000AD814 File Offset: 0x000ABA14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 488939, RefRangeEnd = 488940, XrefRangeStart = 488915, XrefRangeEnd = 488939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginConnect(string host, int port, AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(host);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_BeginConnect_Public_IAsyncResult_String_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06002581 RID: 9601 RVA: 0x000AD898 File Offset: 0x000ABA98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 488950, RefRangeEnd = 488952, XrefRangeStart = 488940, XrefRangeEnd = 488950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginConnect(EndPoint remoteEP, AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(remoteEP);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_BeginConnect_Public_IAsyncResult_EndPoint_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06002582 RID: 9602 RVA: 0x000AD90C File Offset: 0x000ABB0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 488963, RefRangeEnd = 488965, XrefRangeStart = 488952, XrefRangeEnd = 488963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BeginMConnect(SocketAsyncResult sockares)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sockares);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_BeginMConnect_Private_Static_Boolean_SocketAsyncResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002583 RID: 9603 RVA: 0x000AD950 File Offset: 0x000ABB50
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 488992, RefRangeEnd = 488995, XrefRangeStart = 488965, XrefRangeEnd = 488992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BeginSConnect(SocketAsyncResult sockares)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sockares);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_BeginSConnect_Private_Static_Boolean_SocketAsyncResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002584 RID: 9604 RVA: 0x000AD994 File Offset: 0x000ABB94
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 489004, RefRangeEnd = 489009, XrefRangeStart = 488995, XrefRangeEnd = 489004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndConnect(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_EndConnect_Public_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002585 RID: 9605 RVA: 0x000AD9D8 File Offset: 0x000ABBD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 489017, RefRangeEnd = 489018, XrefRangeStart = 489009, XrefRangeEnd = 489017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Connect_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sa);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Connect_internal_Private_Static_Void_SafeSocketHandle_SocketAddress_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002586 RID: 9606 RVA: 0x000ADA3C File Offset: 0x000ABC3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489018, XrefRangeEnd = 489019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Connect_icall(IntPtr sock, SocketAddress sa, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sock;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sa);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Connect_icall_Private_Static_Void_IntPtr_SocketAddress_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002587 RID: 9607 RVA: 0x000ADA9C File Offset: 0x000ABC9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489019, XrefRangeEnd = 489024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Disconnect(bool reuseSocket)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref reuseSocket;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Disconnect_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002588 RID: 9608 RVA: 0x000ADADC File Offset: 0x000ABCDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489024, XrefRangeEnd = 489033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndDisconnect(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_EndDisconnect_Public_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002589 RID: 9609 RVA: 0x000ADB20 File Offset: 0x000ABD20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 489041, RefRangeEnd = 489043, XrefRangeStart = 489033, XrefRangeEnd = 489041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Disconnect_internal(SafeSocketHandle safeHandle, bool reuse, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reuse;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Disconnect_internal_Private_Static_Void_SafeSocketHandle_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600258A RID: 9610 RVA: 0x000ADB74 File Offset: 0x000ABD74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489043, XrefRangeEnd = 489044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Disconnect_icall(IntPtr sock, bool reuse, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sock;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reuse;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Disconnect_icall_Private_Static_Void_IntPtr_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600258B RID: 9611 RVA: 0x000ADBC4 File Offset: 0x000ABDC4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 489051, RefRangeEnd = 489055, XrefRangeStart = 489044, XrefRangeEnd = 489051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Receive(Il2CppStructArray<byte> buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errorCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Receive_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600258C RID: 9612 RVA: 0x000ADC4C File Offset: 0x000ABE4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 489072, RefRangeEnd = 489073, XrefRangeStart = 489055, XrefRangeEnd = 489072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Receive(Memory<byte> buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buffer));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errorCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Receive_Private_Int32_Memory_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600258D RID: 9613 RVA: 0x000ADCD8 File Offset: 0x000ABED8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 489119, RefRangeEnd = 489121, XrefRangeStart = 489073, XrefRangeEnd = 489119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffers);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errorCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Receive_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_byref_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600258E RID: 9614 RVA: 0x000ADD44 File Offset: 0x000ABF44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489121, XrefRangeEnd = 489130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Receive(Span<byte> buffer, SocketFlags socketFlags, out SocketError errorCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buffer));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errorCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Receive_Public_Int32_Span_1_Byte_SocketFlags_byref_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600258F RID: 9615 RVA: 0x000ADDB4 File Offset: 0x000ABFB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489130, XrefRangeEnd = 489134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Send(ReadOnlySpan<byte> buffer, SocketFlags socketFlags, out SocketError errorCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buffer));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errorCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Send_Public_Int32_ReadOnlySpan_1_Byte_SocketFlags_byref_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002590 RID: 9616 RVA: 0x000ADE24 File Offset: 0x000AC024
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 489168, RefRangeEnd = 489169, XrefRangeStart = 489134, XrefRangeEnd = 489168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReceiveAsync(SocketAsyncEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_ReceiveAsync_Public_Boolean_SocketAsyncEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002591 RID: 9617 RVA: 0x000ADE74 File Offset: 0x000AC074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489169, XrefRangeEnd = 489189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginReceive(Il2CppStructArray<byte> buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errorCode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_BeginReceive_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06002592 RID: 9618 RVA: 0x000ADF24 File Offset: 0x000AC124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489189, XrefRangeEnd = 489198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int EndReceive(IAsyncResult asyncResult, out SocketError errorCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errorCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_EndReceive_Public_Int32_IAsyncResult_byref_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002593 RID: 9619 RVA: 0x000ADF80 File Offset: 0x000AC180
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 489206, RefRangeEnd = 489207, XrefRangeStart = 489198, XrefRangeEnd = 489206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Receive_internal(SafeSocketHandle safeHandle, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = bufarray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Receive_internal_Private_Static_Int32_SafeSocketHandle_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002594 RID: 9620 RVA: 0x000AE008 File Offset: 0x000AC208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489207, XrefRangeEnd = 489208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Receive_array_icall(IntPtr sock, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sock;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = bufarray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Receive_array_icall_Private_Static_Int32_IntPtr_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002595 RID: 9621 RVA: 0x000AE08C File Offset: 0x000AC28C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 489216, RefRangeEnd = 489219, XrefRangeStart = 489208, XrefRangeEnd = 489216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Receive_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Receive_internal_Private_Static_Int32_SafeSocketHandle_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002596 RID: 9622 RVA: 0x000AE114 File Offset: 0x000AC314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489219, XrefRangeEnd = 489220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Receive_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sock;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Receive_icall_Private_Static_Int32_IntPtr_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002597 RID: 9623 RVA: 0x000AE198 File Offset: 0x000AC398
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 489237, RefRangeEnd = 489238, XrefRangeStart = 489220, XrefRangeEnd = 489237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReceiveFrom(Memory<byte> buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, out SocketError errorCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buffer));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(remoteEP);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errorCode;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_ReceiveFrom_Private_Int32_Memory_1_Byte_Int32_Int32_SocketFlags_byref_EndPoint_byref_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			remoteEP = ((intPtr4 == 0) ? null : new EndPoint(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002598 RID: 9624 RVA: 0x000AE250 File Offset: 0x000AC450
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 489259, RefRangeEnd = 489261, XrefRangeStart = 489238, XrefRangeEnd = 489259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginReceiveFrom(Il2CppStructArray<byte> buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(remoteEP);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_BeginReceiveFrom_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_EndPoint_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			remoteEP = ((intPtr4 == 0) ? null : new EndPoint(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr5) : null;
		}

		// Token: 0x06002599 RID: 9625 RVA: 0x000AE31C File Offset: 0x000AC51C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489261, XrefRangeEnd = 489270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int EndReceiveFrom(IAsyncResult asyncResult, ref EndPoint endPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(endPoint);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_EndReceiveFrom_Public_Int32_IAsyncResult_byref_EndPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			endPoint = ((intPtr4 == 0) ? null : new EndPoint(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600259A RID: 9626 RVA: 0x000AE394 File Offset: 0x000AC594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489270, XrefRangeEnd = 489275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int EndReceiveFrom_internal(SocketAsyncResult sockares, SocketAsyncEventArgs ares)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sockares);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ares);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_EndReceiveFrom_internal_Private_Int32_SocketAsyncResult_SocketAsyncEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600259B RID: 9627 RVA: 0x000AE3F4 File Offset: 0x000AC5F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 489283, RefRangeEnd = 489284, XrefRangeStart = 489275, XrefRangeEnd = 489283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ReceiveFrom_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(sockaddr);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_ReceiveFrom_internal_Private_Static_Int32_SafeSocketHandle_ptr_Byte_Int32_SocketFlags_byref_SocketAddress_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			sockaddr = ((intPtr4 == 0) ? null : new SocketAddress(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600259C RID: 9628 RVA: 0x000AE4A8 File Offset: 0x000AC6A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489284, XrefRangeEnd = 489285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ReceiveFrom_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sock;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(sockaddr);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_ReceiveFrom_icall_Private_Static_Int32_IntPtr_ptr_Byte_Int32_SocketFlags_byref_SocketAddress_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			sockaddr = ((intPtr4 == 0) ? null : new SocketAddress(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600259D RID: 9629 RVA: 0x000AE558 File Offset: 0x000AC758
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 489292, RefRangeEnd = 489296, XrefRangeStart = 489285, XrefRangeEnd = 489292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Send(Il2CppStructArray<byte> buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errorCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Send_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600259E RID: 9630 RVA: 0x000AE5E0 File Offset: 0x000AC7E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 489342, RefRangeEnd = 489344, XrefRangeStart = 489296, XrefRangeEnd = 489342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffers);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errorCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Send_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_byref_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600259F RID: 9631 RVA: 0x000AE64C File Offset: 0x000AC84C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 489392, RefRangeEnd = 489393, XrefRangeStart = 489344, XrefRangeEnd = 489392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SendAsync(SocketAsyncEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_SendAsync_Public_Boolean_SocketAsyncEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025A0 RID: 9632 RVA: 0x000AE69C File Offset: 0x000AC89C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 489424, RefRangeEnd = 489425, XrefRangeStart = 489393, XrefRangeEnd = 489424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginSend(Il2CppStructArray<byte> buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errorCode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_BeginSend_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060025A1 RID: 9633 RVA: 0x000AE74C File Offset: 0x000AC94C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 489448, RefRangeEnd = 489451, XrefRangeStart = 489425, XrefRangeEnd = 489448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginSendCallback(SocketAsyncResult sockares, int sent_so_far)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sockares);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sent_so_far;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_BeginSendCallback_Private_Static_Void_SocketAsyncResult_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025A2 RID: 9634 RVA: 0x000AE790 File Offset: 0x000AC990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489451, XrefRangeEnd = 489460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int EndSend(IAsyncResult asyncResult, out SocketError errorCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errorCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_EndSend_Public_Int32_IAsyncResult_byref_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025A3 RID: 9635 RVA: 0x000AE7EC File Offset: 0x000AC9EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 489468, RefRangeEnd = 489469, XrefRangeStart = 489460, XrefRangeEnd = 489468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Send_internal(SafeSocketHandle safeHandle, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = bufarray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Send_internal_Private_Static_Int32_SafeSocketHandle_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025A4 RID: 9636 RVA: 0x000AE874 File Offset: 0x000ACA74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489469, XrefRangeEnd = 489470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Send_array_icall(IntPtr sock, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sock;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = bufarray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Send_array_icall_Private_Static_Int32_IntPtr_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025A5 RID: 9637 RVA: 0x000AE8F8 File Offset: 0x000ACAF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 489478, RefRangeEnd = 489480, XrefRangeStart = 489470, XrefRangeEnd = 489478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Send_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Send_internal_Private_Static_Int32_SafeSocketHandle_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025A6 RID: 9638 RVA: 0x000AE980 File Offset: 0x000ACB80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489480, XrefRangeEnd = 489481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Send_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sock;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Send_icall_Private_Static_Int32_IntPtr_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025A7 RID: 9639 RVA: 0x000AEA04 File Offset: 0x000ACC04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 489498, RefRangeEnd = 489499, XrefRangeStart = 489481, XrefRangeEnd = 489498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int SendTo(Memory<byte> buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buffer));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remoteEP);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_SendTo_Private_Int32_Memory_1_Byte_Int32_Int32_SocketFlags_EndPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025A8 RID: 9640 RVA: 0x000AEA94 File Offset: 0x000ACC94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 489531, RefRangeEnd = 489532, XrefRangeStart = 489499, XrefRangeEnd = 489531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginSendTo(Il2CppStructArray<byte> buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP, AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socketFlags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remoteEP);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_BeginSendTo_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_EndPoint_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060025A9 RID: 9641 RVA: 0x000AEB48 File Offset: 0x000ACD48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 489541, RefRangeEnd = 489543, XrefRangeStart = 489532, XrefRangeEnd = 489541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginSendToCallback(SocketAsyncResult sockares, int sent_so_far)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sockares);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sent_so_far;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_BeginSendToCallback_Private_Static_Void_SocketAsyncResult_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025AA RID: 9642 RVA: 0x000AEB8C File Offset: 0x000ACD8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 489551, RefRangeEnd = 489553, XrefRangeStart = 489543, XrefRangeEnd = 489551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int EndSendTo(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_EndSendTo_Public_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025AB RID: 9643 RVA: 0x000AEBDC File Offset: 0x000ACDDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 489561, RefRangeEnd = 489562, XrefRangeStart = 489553, XrefRangeEnd = 489561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SendTo_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, SocketAddress sa, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sa);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_SendTo_internal_Private_Static_Int32_SafeSocketHandle_ptr_Byte_Int32_SocketFlags_SocketAddress_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025AC RID: 9644 RVA: 0x000AEC78 File Offset: 0x000ACE78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489562, XrefRangeEnd = 489563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SendTo_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, SocketAddress sa, out int error, bool blocking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sock;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sa);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_SendTo_icall_Private_Static_Int32_IntPtr_ptr_Byte_Int32_SocketFlags_SocketAddress_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025AD RID: 9645 RVA: 0x000AED10 File Offset: 0x000ACF10
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 489575, RefRangeEnd = 489580, XrefRangeStart = 489563, XrefRangeEnd = 489575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref optionLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref optionName;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_GetSocketOption_Public_Object_SocketOptionLevel_SocketOptionName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060025AE RID: 9646 RVA: 0x000AED6C File Offset: 0x000ACF6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 489588, RefRangeEnd = 489589, XrefRangeStart = 489580, XrefRangeEnd = 489588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSocketOption_obj_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, out Object obj_val, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref name;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_GetSocketOption_obj_internal_Private_Static_Void_SafeSocketHandle_SocketOptionLevel_SocketOptionName_byref_Object_byref_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			obj_val = ((intPtr4 == 0) ? null : new Object(intPtr4));
		}

		// Token: 0x060025AF RID: 9647 RVA: 0x000AEDF0 File Offset: 0x000ACFF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489589, XrefRangeEnd = 489590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSocketOption_obj_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, out Object obj_val, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref socket;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref name;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_GetSocketOption_obj_icall_Private_Static_Void_IntPtr_SocketOptionLevel_SocketOptionName_byref_Object_byref_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			obj_val = ((intPtr4 == 0) ? null : new Object(intPtr4));
		}

		// Token: 0x060025B0 RID: 9648 RVA: 0x000AEE70 File Offset: 0x000AD070
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 489596, RefRangeEnd = 489607, XrefRangeStart = 489590, XrefRangeEnd = 489596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref optionLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref optionName;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref optionValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_SetSocketOption_Public_Void_SocketOptionLevel_SocketOptionName_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025B1 RID: 9649 RVA: 0x000AEECC File Offset: 0x000AD0CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 489615, RefRangeEnd = 489617, XrefRangeStart = 489607, XrefRangeEnd = 489615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetSocketOption_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, Object obj_val, Il2CppStructArray<byte> byte_val, int int_val, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref name;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj_val);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(byte_val);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref int_val;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_SetSocketOption_internal_Private_Static_Void_SafeSocketHandle_SocketOptionLevel_SocketOptionName_Object_Il2CppStructArray_1_Byte_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025B2 RID: 9650 RVA: 0x000AEF60 File Offset: 0x000AD160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489617, XrefRangeEnd = 489618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetSocketOption_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, Object obj_val, Il2CppStructArray<byte> byte_val, int int_val, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref socket;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref name;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj_val);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(byte_val);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref int_val;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_SetSocketOption_icall_Private_Static_Void_IntPtr_SocketOptionLevel_SocketOptionName_Object_Il2CppStructArray_1_Byte_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025B3 RID: 9651 RVA: 0x000AEFF0 File Offset: 0x000AD1F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489618, XrefRangeEnd = 489622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IOControl(int ioControlCode, Il2CppStructArray<byte> optionInValue, Il2CppStructArray<byte> optionOutValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ioControlCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(optionInValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(optionOutValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_IOControl_Public_Int32_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025B4 RID: 9652 RVA: 0x000AF060 File Offset: 0x000AD260
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 489630, RefRangeEnd = 489632, XrefRangeStart = 489622, XrefRangeEnd = 489630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IOControl_internal(SafeSocketHandle safeHandle, int ioctl_code, Il2CppStructArray<byte> input, Il2CppStructArray<byte> output, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ioctl_code;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(input);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_IOControl_internal_Private_Static_Int32_SafeSocketHandle_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025B5 RID: 9653 RVA: 0x000AF0E4 File Offset: 0x000AD2E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489632, XrefRangeEnd = 489633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IOControl_icall(IntPtr sock, int ioctl_code, Il2CppStructArray<byte> input, Il2CppStructArray<byte> output, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sock;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ioctl_code;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(input);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_IOControl_icall_Private_Static_Int32_IntPtr_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025B6 RID: 9654 RVA: 0x000AF164 File Offset: 0x000AD364
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 489637, RefRangeEnd = 489649, XrefRangeStart = 489633, XrefRangeEnd = 489637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025B7 RID: 9655 RVA: 0x000AF198 File Offset: 0x000AD398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489649, XrefRangeEnd = 489653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(int timeout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Close_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060025B8 RID: 9656 RVA: 0x000AF1D8 File Offset: 0x000AD3D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 489654, RefRangeEnd = 489655, XrefRangeStart = 489653, XrefRangeEnd = 489654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Close_icall(IntPtr socket, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref socket;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Close_icall_Internal_Static_Void_IntPtr_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025B9 RID: 9657 RVA: 0x000AF218 File Offset: 0x000AD418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489655, XrefRangeEnd = 489660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Shutdown(SocketShutdown how)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref how;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Shutdown_Public_Void_SocketShutdown_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060025BA RID: 9658 RVA: 0x000AF258 File Offset: 0x000AD458
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 489668, RefRangeEnd = 489670, XrefRangeStart = 489660, XrefRangeEnd = 489668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Shutdown_internal(SafeSocketHandle safeHandle, SocketShutdown how, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref how;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Shutdown_internal_Private_Static_Void_SafeSocketHandle_SocketShutdown_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025BB RID: 9659 RVA: 0x000AF2AC File Offset: 0x000AD4AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 489671, RefRangeEnd = 489672, XrefRangeStart = 489670, XrefRangeEnd = 489671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Shutdown_icall(IntPtr socket, SocketShutdown how, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref socket;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref how;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Shutdown_icall_Internal_Static_Void_IntPtr_SocketShutdown_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025BC RID: 9660 RVA: 0x000AF2FC File Offset: 0x000AD4FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489672, XrefRangeEnd = 489687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Socket.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060025BD RID: 9661 RVA: 0x000AF348 File Offset: 0x000AD548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489687, XrefRangeEnd = 489701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Linger(IntPtr handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Linger_Private_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060025BE RID: 9662 RVA: 0x000AF388 File Offset: 0x000AD588
		[CallerCount(51)]
		[CachedScanResults(RefRangeStart = 489701, RefRangeEnd = 489752, XrefRangeStart = 489701, XrefRangeEnd = 489701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowIfDisposedAndClosed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_ThrowIfDisposedAndClosed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025BF RID: 9663 RVA: 0x000AF3BC File Offset: 0x000AD5BC
		[CallerCount(0)]
		public unsafe void ThrowIfBufferNull(Il2CppStructArray<byte> buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_ThrowIfBufferNull_Private_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060025C0 RID: 9664 RVA: 0x000AF400 File Offset: 0x000AD600
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 489752, RefRangeEnd = 489759, XrefRangeStart = 489752, XrefRangeEnd = 489752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowIfBufferOutOfRange(Il2CppStructArray<byte> buffer, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_ThrowIfBufferOutOfRange_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025C1 RID: 9665 RVA: 0x000AF460 File Offset: 0x000AD660
		[CallerCount(0)]
		public unsafe void ThrowIfUdp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_ThrowIfUdp_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025C2 RID: 9666 RVA: 0x000AF494 File Offset: 0x000AD694
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 489762, RefRangeEnd = 489774, XrefRangeStart = 489759, XrefRangeEnd = 489762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SocketAsyncResult ValidateEndIAsyncResult(IAsyncResult ares, string methodName, string argName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(argName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_ValidateEndIAsyncResult_Private_SocketAsyncResult_IAsyncResult_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SocketAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060025C3 RID: 9667 RVA: 0x000AF508 File Offset: 0x000AD708
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 489789, RefRangeEnd = 489799, XrefRangeStart = 489774, XrefRangeEnd = 489789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueIOSelectorJob(SemaphoreSlim sem, IntPtr handle, IOSelectorJob job)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(job);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_QueueIOSelectorJob_Private_Void_SemaphoreSlim_IntPtr_IOSelectorJob_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025C4 RID: 9668 RVA: 0x000AF56C File Offset: 0x000AD76C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 489820, RefRangeEnd = 489821, XrefRangeStart = 489799, XrefRangeEnd = 489820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitSocketAsyncEventArgs(SocketAsyncEventArgs e, AsyncCallback callback, Object state, SocketOperation operation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref operation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_InitSocketAsyncEventArgs_Private_Void_SocketAsyncEventArgs_AsyncCallback_Object_SocketOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025C5 RID: 9669 RVA: 0x000AF5E0 File Offset: 0x000AD7E0
		[CallerCount(0)]
		public unsafe SocketAsyncOperation SocketOperationToSocketAsyncOperation(SocketOperation op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref op;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_SocketOperationToSocketAsyncOperation_Private_SocketAsyncOperation_SocketOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025C6 RID: 9670 RVA: 0x000AF62C File Offset: 0x000AD82C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 489827, RefRangeEnd = 489831, XrefRangeStart = 489821, XrefRangeEnd = 489827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPEndPoint RemapIPEndPoint(IPEndPoint input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_RemapIPEndPoint_Private_IPEndPoint_IPEndPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPEndPoint>(intPtr3) : null;
			}
		}

		// Token: 0x060025C7 RID: 9671 RVA: 0x000AF67C File Offset: 0x000AD87C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 489832, RefRangeEnd = 489833, XrefRangeStart = 489831, XrefRangeEnd = 489832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void cancel_blocking_socket_operation(Thread thread)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thread);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_cancel_blocking_socket_operation_Internal_Static_Void_Thread_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x060025C8 RID: 9672 RVA: 0x000AF6B4 File Offset: 0x000AD8B4
		public unsafe static int FamilyHint
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 489851, RefRangeEnd = 489855, XrefRangeStart = 489833, XrefRangeEnd = 489851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_FamilyHint_Internal_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025C9 RID: 9673 RVA: 0x000AF6E4 File Offset: 0x000AD8E4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 489856, RefRangeEnd = 489860, XrefRangeStart = 489855, XrefRangeEnd = 489856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsProtocolSupported_internal(NetworkInterfaceComponent networkInterface)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref networkInterface;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_IsProtocolSupported_internal_Private_Static_Boolean_NetworkInterfaceComponent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025CA RID: 9674 RVA: 0x000AF724 File Offset: 0x000AD924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489860, XrefRangeEnd = 489864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsProtocolSupported(NetworkInterfaceComponent networkInterface)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref networkInterface;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_IsProtocolSupported_Private_Static_Boolean_NetworkInterfaceComponent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025CB RID: 9675 RVA: 0x000102CF File Offset: 0x0000E4CF
		public Socket(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x060025CC RID: 9676 RVA: 0x000AF764 File Offset: 0x000AD964
		// (set) Token: 0x060025CD RID: 9677 RVA: 0x000102D8 File Offset: 0x0000E4D8
		public unsafe static EventHandler<SocketAsyncEventArgs> AcceptCompletedHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_AcceptCompletedHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<SocketAsyncEventArgs>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_AcceptCompletedHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x060025CE RID: 9678 RVA: 0x000AF78C File Offset: 0x000AD98C
		// (set) Token: 0x060025CF RID: 9679 RVA: 0x000102EA File Offset: 0x0000E4EA
		public unsafe static EventHandler<SocketAsyncEventArgs> ReceiveCompletedHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_ReceiveCompletedHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<SocketAsyncEventArgs>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_ReceiveCompletedHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x060025D0 RID: 9680 RVA: 0x000AF7B4 File Offset: 0x000AD9B4
		// (set) Token: 0x060025D1 RID: 9681 RVA: 0x000102FC File Offset: 0x0000E4FC
		public unsafe static EventHandler<SocketAsyncEventArgs> SendCompletedHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_SendCompletedHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<SocketAsyncEventArgs>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_SendCompletedHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x060025D2 RID: 9682 RVA: 0x000AF7DC File Offset: 0x000AD9DC
		// (set) Token: 0x060025D3 RID: 9683 RVA: 0x0001030E File Offset: 0x0000E50E
		public unsafe static Socket.TaskSocketAsyncEventArgs<Socket> s_rentedSocketSentinel
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_s_rentedSocketSentinel, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket.TaskSocketAsyncEventArgs<Socket>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_s_rentedSocketSentinel, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x060025D4 RID: 9684 RVA: 0x000AF804 File Offset: 0x000ADA04
		// (set) Token: 0x060025D5 RID: 9685 RVA: 0x00010320 File Offset: 0x0000E520
		public unsafe static Socket.Int32TaskSocketAsyncEventArgs s_rentedInt32Sentinel
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_s_rentedInt32Sentinel, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket.Int32TaskSocketAsyncEventArgs>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_s_rentedInt32Sentinel, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x060025D6 RID: 9686 RVA: 0x000AF82C File Offset: 0x000ADA2C
		// (set) Token: 0x060025D7 RID: 9687 RVA: 0x00010332 File Offset: 0x0000E532
		public unsafe static Task<int> s_zeroTask
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_s_zeroTask, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_s_zeroTask, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x060025D8 RID: 9688 RVA: 0x000AF854 File Offset: 0x000ADA54
		// (set) Token: 0x060025D9 RID: 9689 RVA: 0x00010344 File Offset: 0x0000E544
		public unsafe Socket.CachedEventArgs _cachedTaskEventArgs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr__cachedTaskEventArgs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket.CachedEventArgs>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr__cachedTaskEventArgs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x060025DA RID: 9690 RVA: 0x000AF884 File Offset: 0x000ADA84
		// (set) Token: 0x060025DB RID: 9691 RVA: 0x00010363 File Offset: 0x0000E563
		public unsafe static Object s_InternalSyncObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_s_InternalSyncObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_s_InternalSyncObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x060025DC RID: 9692 RVA: 0x000AF8AC File Offset: 0x000ADAAC
		// (set) Token: 0x060025DD RID: 9693 RVA: 0x00010375 File Offset: 0x0000E575
		public unsafe static bool s_SupportsIPv4
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_s_SupportsIPv4, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_s_SupportsIPv4, (void*)(&value));
			}
		}

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x060025DE RID: 9694 RVA: 0x000AF8C8 File Offset: 0x000ADAC8
		// (set) Token: 0x060025DF RID: 9695 RVA: 0x00010383 File Offset: 0x0000E583
		public unsafe static bool s_SupportsIPv6
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_s_SupportsIPv6, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_s_SupportsIPv6, (void*)(&value));
			}
		}

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x060025E0 RID: 9696 RVA: 0x000AF8E4 File Offset: 0x000ADAE4
		// (set) Token: 0x060025E1 RID: 9697 RVA: 0x00010391 File Offset: 0x0000E591
		public unsafe static bool s_OSSupportsIPv6
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_s_OSSupportsIPv6, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_s_OSSupportsIPv6, (void*)(&value));
			}
		}

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x060025E2 RID: 9698 RVA: 0x000AF900 File Offset: 0x000ADB00
		// (set) Token: 0x060025E3 RID: 9699 RVA: 0x0001039F File Offset: 0x0000E59F
		public unsafe static bool s_Initialized
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_s_Initialized, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_s_Initialized, (void*)(&value));
			}
		}

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x060025E4 RID: 9700 RVA: 0x000AF91C File Offset: 0x000ADB1C
		// (set) Token: 0x060025E5 RID: 9701 RVA: 0x000103AD File Offset: 0x0000E5AD
		public unsafe static bool s_LoggingEnabled
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_s_LoggingEnabled, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_s_LoggingEnabled, (void*)(&value));
			}
		}

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x060025E6 RID: 9702 RVA: 0x000AF938 File Offset: 0x000ADB38
		// (set) Token: 0x060025E7 RID: 9703 RVA: 0x000103BB File Offset: 0x0000E5BB
		public unsafe bool is_closed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_is_closed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_is_closed)) = value;
			}
		}

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x060025E8 RID: 9704 RVA: 0x000AF960 File Offset: 0x000ADB60
		// (set) Token: 0x060025E9 RID: 9705 RVA: 0x000103D6 File Offset: 0x0000E5D6
		public unsafe bool is_listening
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_is_listening);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_is_listening)) = value;
			}
		}

		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x060025EA RID: 9706 RVA: 0x000AF988 File Offset: 0x000ADB88
		// (set) Token: 0x060025EB RID: 9707 RVA: 0x000103F1 File Offset: 0x0000E5F1
		public unsafe int linger_timeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_linger_timeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_linger_timeout)) = value;
			}
		}

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x060025EC RID: 9708 RVA: 0x000AF9B0 File Offset: 0x000ADBB0
		// (set) Token: 0x060025ED RID: 9709 RVA: 0x0001040C File Offset: 0x0000E60C
		public unsafe AddressFamily addressFamily
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_addressFamily);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_addressFamily)) = value;
			}
		}

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x060025EE RID: 9710 RVA: 0x000AF9D8 File Offset: 0x000ADBD8
		// (set) Token: 0x060025EF RID: 9711 RVA: 0x00010427 File Offset: 0x0000E627
		public unsafe SocketType socketType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_socketType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_socketType)) = value;
			}
		}

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x060025F0 RID: 9712 RVA: 0x000AFA00 File Offset: 0x000ADC00
		// (set) Token: 0x060025F1 RID: 9713 RVA: 0x00010442 File Offset: 0x0000E642
		public unsafe ProtocolType protocolType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_protocolType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_protocolType)) = value;
			}
		}

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x060025F2 RID: 9714 RVA: 0x000AFA28 File Offset: 0x000ADC28
		// (set) Token: 0x060025F3 RID: 9715 RVA: 0x0001045D File Offset: 0x0000E65D
		public unsafe SafeSocketHandle m_Handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_m_Handle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SafeSocketHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_m_Handle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x060025F4 RID: 9716 RVA: 0x000AFA58 File Offset: 0x000ADC58
		// (set) Token: 0x060025F5 RID: 9717 RVA: 0x0001047C File Offset: 0x0000E67C
		public unsafe EndPoint seed_endpoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_seed_endpoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EndPoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_seed_endpoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x060025F6 RID: 9718 RVA: 0x000AFA88 File Offset: 0x000ADC88
		// (set) Token: 0x060025F7 RID: 9719 RVA: 0x0001049B File Offset: 0x0000E69B
		public unsafe SemaphoreSlim ReadSem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_ReadSem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_ReadSem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x060025F8 RID: 9720 RVA: 0x000AFAB8 File Offset: 0x000ADCB8
		// (set) Token: 0x060025F9 RID: 9721 RVA: 0x000104BA File Offset: 0x0000E6BA
		public unsafe SemaphoreSlim WriteSem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_WriteSem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_WriteSem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x060025FA RID: 9722 RVA: 0x000AFAE8 File Offset: 0x000ADCE8
		// (set) Token: 0x060025FB RID: 9723 RVA: 0x000104D9 File Offset: 0x0000E6D9
		public unsafe bool is_blocking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_is_blocking);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_is_blocking)) = value;
			}
		}

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x060025FC RID: 9724 RVA: 0x000AFB10 File Offset: 0x000ADD10
		// (set) Token: 0x060025FD RID: 9725 RVA: 0x000104F4 File Offset: 0x0000E6F4
		public unsafe bool is_bound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_is_bound);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_is_bound)) = value;
			}
		}

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x060025FE RID: 9726 RVA: 0x000AFB38 File Offset: 0x000ADD38
		// (set) Token: 0x060025FF RID: 9727 RVA: 0x0001050F File Offset: 0x0000E70F
		public unsafe bool is_connected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_is_connected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_is_connected)) = value;
			}
		}

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x06002600 RID: 9728 RVA: 0x000AFB60 File Offset: 0x000ADD60
		// (set) Token: 0x06002601 RID: 9729 RVA: 0x0001052A File Offset: 0x0000E72A
		public unsafe int m_IntCleanedUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_m_IntCleanedUp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_m_IntCleanedUp)) = value;
			}
		}

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x06002602 RID: 9730 RVA: 0x000AFB88 File Offset: 0x000ADD88
		// (set) Token: 0x06002603 RID: 9731 RVA: 0x00010545 File Offset: 0x0000E745
		public unsafe bool connect_in_progress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_connect_in_progress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.NativeFieldInfoPtr_connect_in_progress)) = value;
			}
		}

		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x06002604 RID: 9732 RVA: 0x000AFBB0 File Offset: 0x000ADDB0
		// (set) Token: 0x06002605 RID: 9733 RVA: 0x00010560 File Offset: 0x0000E760
		public unsafe static AsyncCallback AcceptAsyncCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_AcceptAsyncCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_AcceptAsyncCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x06002606 RID: 9734 RVA: 0x000AFBD8 File Offset: 0x000ADDD8
		// (set) Token: 0x06002607 RID: 9735 RVA: 0x00010572 File Offset: 0x0000E772
		public unsafe static IOAsyncCallback BeginAcceptCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_BeginAcceptCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOAsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_BeginAcceptCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x06002608 RID: 9736 RVA: 0x000AFC00 File Offset: 0x000ADE00
		// (set) Token: 0x06002609 RID: 9737 RVA: 0x00010584 File Offset: 0x0000E784
		public unsafe static IOAsyncCallback BeginAcceptReceiveCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_BeginAcceptReceiveCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOAsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_BeginAcceptReceiveCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x0600260A RID: 9738 RVA: 0x000AFC28 File Offset: 0x000ADE28
		// (set) Token: 0x0600260B RID: 9739 RVA: 0x00010596 File Offset: 0x0000E796
		public unsafe static AsyncCallback ConnectAsyncCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_ConnectAsyncCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_ConnectAsyncCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x0600260C RID: 9740 RVA: 0x000AFC50 File Offset: 0x000ADE50
		// (set) Token: 0x0600260D RID: 9741 RVA: 0x000105A8 File Offset: 0x0000E7A8
		public unsafe static IOAsyncCallback BeginConnectCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_BeginConnectCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOAsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_BeginConnectCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x0600260E RID: 9742 RVA: 0x000AFC78 File Offset: 0x000ADE78
		// (set) Token: 0x0600260F RID: 9743 RVA: 0x000105BA File Offset: 0x0000E7BA
		public unsafe static AsyncCallback DisconnectAsyncCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_DisconnectAsyncCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_DisconnectAsyncCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x06002610 RID: 9744 RVA: 0x000AFCA0 File Offset: 0x000ADEA0
		// (set) Token: 0x06002611 RID: 9745 RVA: 0x000105CC File Offset: 0x0000E7CC
		public unsafe static IOAsyncCallback BeginDisconnectCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_BeginDisconnectCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOAsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_BeginDisconnectCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x06002612 RID: 9746 RVA: 0x000AFCC8 File Offset: 0x000ADEC8
		// (set) Token: 0x06002613 RID: 9747 RVA: 0x000105DE File Offset: 0x0000E7DE
		public unsafe static AsyncCallback ReceiveAsyncCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_ReceiveAsyncCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_ReceiveAsyncCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x06002614 RID: 9748 RVA: 0x000AFCF0 File Offset: 0x000ADEF0
		// (set) Token: 0x06002615 RID: 9749 RVA: 0x000105F0 File Offset: 0x0000E7F0
		public unsafe static IOAsyncCallback BeginReceiveCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_BeginReceiveCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOAsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_BeginReceiveCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x06002616 RID: 9750 RVA: 0x000AFD18 File Offset: 0x000ADF18
		// (set) Token: 0x06002617 RID: 9751 RVA: 0x00010602 File Offset: 0x0000E802
		public unsafe static IOAsyncCallback BeginReceiveGenericCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_BeginReceiveGenericCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOAsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_BeginReceiveGenericCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x06002618 RID: 9752 RVA: 0x000AFD40 File Offset: 0x000ADF40
		// (set) Token: 0x06002619 RID: 9753 RVA: 0x00010614 File Offset: 0x0000E814
		public unsafe static AsyncCallback ReceiveFromAsyncCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_ReceiveFromAsyncCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_ReceiveFromAsyncCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x0600261A RID: 9754 RVA: 0x000AFD68 File Offset: 0x000ADF68
		// (set) Token: 0x0600261B RID: 9755 RVA: 0x00010626 File Offset: 0x0000E826
		public unsafe static IOAsyncCallback BeginReceiveFromCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_BeginReceiveFromCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOAsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_BeginReceiveFromCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x0600261C RID: 9756 RVA: 0x000AFD90 File Offset: 0x000ADF90
		// (set) Token: 0x0600261D RID: 9757 RVA: 0x00010638 File Offset: 0x0000E838
		public unsafe static AsyncCallback SendAsyncCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_SendAsyncCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_SendAsyncCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x0600261E RID: 9758 RVA: 0x000AFDB8 File Offset: 0x000ADFB8
		// (set) Token: 0x0600261F RID: 9759 RVA: 0x0001064A File Offset: 0x0000E84A
		public unsafe static IOAsyncCallback BeginSendGenericCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_BeginSendGenericCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOAsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_BeginSendGenericCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x06002620 RID: 9760 RVA: 0x000AFDE0 File Offset: 0x000ADFE0
		// (set) Token: 0x06002621 RID: 9761 RVA: 0x0001065C File Offset: 0x0000E85C
		public unsafe static AsyncCallback SendToAsyncCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Socket.NativeFieldInfoPtr_SendToAsyncCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Socket.NativeFieldInfoPtr_SendToAsyncCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001CC7 RID: 7367
		private static readonly IntPtr NativeFieldInfoPtr_AcceptCompletedHandler;

		// Token: 0x04001CC8 RID: 7368
		private static readonly IntPtr NativeFieldInfoPtr_ReceiveCompletedHandler;

		// Token: 0x04001CC9 RID: 7369
		private static readonly IntPtr NativeFieldInfoPtr_SendCompletedHandler;

		// Token: 0x04001CCA RID: 7370
		private static readonly IntPtr NativeFieldInfoPtr_s_rentedSocketSentinel;

		// Token: 0x04001CCB RID: 7371
		private static readonly IntPtr NativeFieldInfoPtr_s_rentedInt32Sentinel;

		// Token: 0x04001CCC RID: 7372
		private static readonly IntPtr NativeFieldInfoPtr_s_zeroTask;

		// Token: 0x04001CCD RID: 7373
		private static readonly IntPtr NativeFieldInfoPtr__cachedTaskEventArgs;

		// Token: 0x04001CCE RID: 7374
		private static readonly IntPtr NativeFieldInfoPtr_s_InternalSyncObject;

		// Token: 0x04001CCF RID: 7375
		private static readonly IntPtr NativeFieldInfoPtr_s_SupportsIPv4;

		// Token: 0x04001CD0 RID: 7376
		private static readonly IntPtr NativeFieldInfoPtr_s_SupportsIPv6;

		// Token: 0x04001CD1 RID: 7377
		private static readonly IntPtr NativeFieldInfoPtr_s_OSSupportsIPv6;

		// Token: 0x04001CD2 RID: 7378
		private static readonly IntPtr NativeFieldInfoPtr_s_Initialized;

		// Token: 0x04001CD3 RID: 7379
		private static readonly IntPtr NativeFieldInfoPtr_s_LoggingEnabled;

		// Token: 0x04001CD4 RID: 7380
		private static readonly IntPtr NativeFieldInfoPtr_is_closed;

		// Token: 0x04001CD5 RID: 7381
		private static readonly IntPtr NativeFieldInfoPtr_is_listening;

		// Token: 0x04001CD6 RID: 7382
		private static readonly IntPtr NativeFieldInfoPtr_linger_timeout;

		// Token: 0x04001CD7 RID: 7383
		private static readonly IntPtr NativeFieldInfoPtr_addressFamily;

		// Token: 0x04001CD8 RID: 7384
		private static readonly IntPtr NativeFieldInfoPtr_socketType;

		// Token: 0x04001CD9 RID: 7385
		private static readonly IntPtr NativeFieldInfoPtr_protocolType;

		// Token: 0x04001CDA RID: 7386
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04001CDB RID: 7387
		private static readonly IntPtr NativeFieldInfoPtr_seed_endpoint;

		// Token: 0x04001CDC RID: 7388
		private static readonly IntPtr NativeFieldInfoPtr_ReadSem;

		// Token: 0x04001CDD RID: 7389
		private static readonly IntPtr NativeFieldInfoPtr_WriteSem;

		// Token: 0x04001CDE RID: 7390
		private static readonly IntPtr NativeFieldInfoPtr_is_blocking;

		// Token: 0x04001CDF RID: 7391
		private static readonly IntPtr NativeFieldInfoPtr_is_bound;

		// Token: 0x04001CE0 RID: 7392
		private static readonly IntPtr NativeFieldInfoPtr_is_connected;

		// Token: 0x04001CE1 RID: 7393
		private static readonly IntPtr NativeFieldInfoPtr_m_IntCleanedUp;

		// Token: 0x04001CE2 RID: 7394
		private static readonly IntPtr NativeFieldInfoPtr_connect_in_progress;

		// Token: 0x04001CE3 RID: 7395
		private static readonly IntPtr NativeFieldInfoPtr_AcceptAsyncCallback;

		// Token: 0x04001CE4 RID: 7396
		private static readonly IntPtr NativeFieldInfoPtr_BeginAcceptCallback;

		// Token: 0x04001CE5 RID: 7397
		private static readonly IntPtr NativeFieldInfoPtr_BeginAcceptReceiveCallback;

		// Token: 0x04001CE6 RID: 7398
		private static readonly IntPtr NativeFieldInfoPtr_ConnectAsyncCallback;

		// Token: 0x04001CE7 RID: 7399
		private static readonly IntPtr NativeFieldInfoPtr_BeginConnectCallback;

		// Token: 0x04001CE8 RID: 7400
		private static readonly IntPtr NativeFieldInfoPtr_DisconnectAsyncCallback;

		// Token: 0x04001CE9 RID: 7401
		private static readonly IntPtr NativeFieldInfoPtr_BeginDisconnectCallback;

		// Token: 0x04001CEA RID: 7402
		private static readonly IntPtr NativeFieldInfoPtr_ReceiveAsyncCallback;

		// Token: 0x04001CEB RID: 7403
		private static readonly IntPtr NativeFieldInfoPtr_BeginReceiveCallback;

		// Token: 0x04001CEC RID: 7404
		private static readonly IntPtr NativeFieldInfoPtr_BeginReceiveGenericCallback;

		// Token: 0x04001CED RID: 7405
		private static readonly IntPtr NativeFieldInfoPtr_ReceiveFromAsyncCallback;

		// Token: 0x04001CEE RID: 7406
		private static readonly IntPtr NativeFieldInfoPtr_BeginReceiveFromCallback;

		// Token: 0x04001CEF RID: 7407
		private static readonly IntPtr NativeFieldInfoPtr_SendAsyncCallback;

		// Token: 0x04001CF0 RID: 7408
		private static readonly IntPtr NativeFieldInfoPtr_BeginSendGenericCallback;

		// Token: 0x04001CF1 RID: 7409
		private static readonly IntPtr NativeFieldInfoPtr_SendToAsyncCallback;

		// Token: 0x04001CF2 RID: 7410
		private static readonly IntPtr NativeMethodInfoPtr_ConnectAsync_Internal_Task_IPAddress_Int32_0;

		// Token: 0x04001CF3 RID: 7411
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveAsync_Internal_ValueTask_1_Int32_Memory_1_Byte_SocketFlags_Boolean_CancellationToken_0;

		// Token: 0x04001CF4 RID: 7412
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveAsyncApm_Private_Task_1_Int32_Memory_1_Byte_SocketFlags_0;

		// Token: 0x04001CF5 RID: 7413
		private static readonly IntPtr NativeMethodInfoPtr_SendAsyncForNetworkStream_Internal_ValueTask_ReadOnlyMemory_1_Byte_SocketFlags_CancellationToken_0;

		// Token: 0x04001CF6 RID: 7414
		private static readonly IntPtr NativeMethodInfoPtr_SendAsyncApm_Private_Task_1_Int32_ReadOnlyMemory_1_Byte_SocketFlags_0;

		// Token: 0x04001CF7 RID: 7415
		private static readonly IntPtr NativeMethodInfoPtr_CompleteAccept_Private_Static_Void_Socket_TaskSocketAsyncEventArgs_1_Socket_0;

		// Token: 0x04001CF8 RID: 7416
		private static readonly IntPtr NativeMethodInfoPtr_CompleteSendReceive_Private_Static_Void_Socket_Int32TaskSocketAsyncEventArgs_Boolean_0;

		// Token: 0x04001CF9 RID: 7417
		private static readonly IntPtr NativeMethodInfoPtr_GetException_Private_Static_Exception_SocketError_Boolean_0;

		// Token: 0x04001CFA RID: 7418
		private static readonly IntPtr NativeMethodInfoPtr_ReturnSocketAsyncEventArgs_Private_Void_Int32TaskSocketAsyncEventArgs_Boolean_0;

		// Token: 0x04001CFB RID: 7419
		private static readonly IntPtr NativeMethodInfoPtr_ReturnSocketAsyncEventArgs_Private_Void_TaskSocketAsyncEventArgs_1_Socket_0;

		// Token: 0x04001CFC RID: 7420
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AddressFamily_SocketType_ProtocolType_0;

		// Token: 0x04001CFD RID: 7421
		private static readonly IntPtr NativeMethodInfoPtr_get_OSSupportsIPv4_Public_Static_get_Boolean_0;

		// Token: 0x04001CFE RID: 7422
		private static readonly IntPtr NativeMethodInfoPtr_get_OSSupportsIPv6_Public_Static_get_Boolean_0;

		// Token: 0x04001CFF RID: 7423
		private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Public_get_IntPtr_0;

		// Token: 0x04001D00 RID: 7424
		private static readonly IntPtr NativeMethodInfoPtr_get_AddressFamily_Public_get_AddressFamily_0;

		// Token: 0x04001D01 RID: 7425
		private static readonly IntPtr NativeMethodInfoPtr_get_SocketType_Public_get_SocketType_0;

		// Token: 0x04001D02 RID: 7426
		private static readonly IntPtr NativeMethodInfoPtr_get_ProtocolType_Public_get_ProtocolType_0;

		// Token: 0x04001D03 RID: 7427
		private static readonly IntPtr NativeMethodInfoPtr_set_ExclusiveAddressUse_Public_set_Void_Boolean_0;

		// Token: 0x04001D04 RID: 7428
		private static readonly IntPtr NativeMethodInfoPtr_set_ReceiveTimeout_Public_set_Void_Int32_0;

		// Token: 0x04001D05 RID: 7429
		private static readonly IntPtr NativeMethodInfoPtr_set_SendTimeout_Public_set_Void_Int32_0;

		// Token: 0x04001D06 RID: 7430
		private static readonly IntPtr NativeMethodInfoPtr_set_DontFragment_Public_set_Void_Boolean_0;

		// Token: 0x04001D07 RID: 7431
		private static readonly IntPtr NativeMethodInfoPtr_get_DualMode_Public_get_Boolean_0;

		// Token: 0x04001D08 RID: 7432
		private static readonly IntPtr NativeMethodInfoPtr_set_DualMode_Public_set_Void_Boolean_0;

		// Token: 0x04001D09 RID: 7433
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDualMode_Private_get_Boolean_0;

		// Token: 0x04001D0A RID: 7434
		private static readonly IntPtr NativeMethodInfoPtr_CanTryAddressFamily_Internal_Boolean_AddressFamily_0;

		// Token: 0x04001D0B RID: 7435
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_0;

		// Token: 0x04001D0C RID: 7436
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_0;

		// Token: 0x04001D0D RID: 7437
		private static readonly IntPtr NativeMethodInfoPtr_Receive_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_0;

		// Token: 0x04001D0E RID: 7438
		private static readonly IntPtr NativeMethodInfoPtr_Receive_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_0;

		// Token: 0x04001D0F RID: 7439
		private static readonly IntPtr NativeMethodInfoPtr_IOControl_Public_Int32_IOControlCode_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001D10 RID: 7440
		private static readonly IntPtr NativeMethodInfoPtr_SetIPProtectionLevel_Public_Void_IPProtectionLevel_0;

		// Token: 0x04001D11 RID: 7441
		private static readonly IntPtr NativeMethodInfoPtr_BeginConnect_Public_IAsyncResult_IPAddress_Int32_AsyncCallback_Object_0;

		// Token: 0x04001D12 RID: 7442
		private static readonly IntPtr NativeMethodInfoPtr_BeginSend_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_AsyncCallback_Object_0;

		// Token: 0x04001D13 RID: 7443
		private static readonly IntPtr NativeMethodInfoPtr_EndSend_Public_Int32_IAsyncResult_0;

		// Token: 0x04001D14 RID: 7444
		private static readonly IntPtr NativeMethodInfoPtr_BeginReceive_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_AsyncCallback_Object_0;

		// Token: 0x04001D15 RID: 7445
		private static readonly IntPtr NativeMethodInfoPtr_EndReceive_Public_Int32_IAsyncResult_0;

		// Token: 0x04001D16 RID: 7446
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0;

		// Token: 0x04001D17 RID: 7447
		private static readonly IntPtr NativeMethodInfoPtr_get_CleanedUp_Internal_get_Boolean_0;

		// Token: 0x04001D18 RID: 7448
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSockets_Internal_Static_Void_0;

		// Token: 0x04001D19 RID: 7449
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001D1A RID: 7450
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04001D1B RID: 7451
		private static readonly IntPtr NativeMethodInfoPtr_InternalShutdown_Internal_Void_SocketShutdown_0;

		// Token: 0x04001D1C RID: 7452
		private static readonly IntPtr NativeMethodInfoPtr_SetSocketOption_Internal_Void_SocketOptionLevel_SocketOptionName_Int32_Boolean_0;

		// Token: 0x04001D1D RID: 7453
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_AddressFamily_SocketType_ProtocolType_SafeSocketHandle_0;

		// Token: 0x04001D1E RID: 7454
		private static readonly IntPtr NativeMethodInfoPtr_SocketDefaults_Private_Void_0;

		// Token: 0x04001D1F RID: 7455
		private static readonly IntPtr NativeMethodInfoPtr_Socket_icall_Private_Static_IntPtr_AddressFamily_SocketType_ProtocolType_byref_Int32_0;

		// Token: 0x04001D20 RID: 7456
		private static readonly IntPtr NativeMethodInfoPtr_get_IsBound_Public_get_Boolean_0;

		// Token: 0x04001D21 RID: 7457
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalEndPoint_Public_get_EndPoint_0;

		// Token: 0x04001D22 RID: 7458
		private static readonly IntPtr NativeMethodInfoPtr_LocalEndPoint_internal_Private_Static_SocketAddress_SafeSocketHandle_Int32_byref_Int32_0;

		// Token: 0x04001D23 RID: 7459
		private static readonly IntPtr NativeMethodInfoPtr_LocalEndPoint_icall_Private_Static_SocketAddress_IntPtr_Int32_byref_Int32_0;

		// Token: 0x04001D24 RID: 7460
		private static readonly IntPtr NativeMethodInfoPtr_get_Blocking_Public_get_Boolean_0;

		// Token: 0x04001D25 RID: 7461
		private static readonly IntPtr NativeMethodInfoPtr_set_Blocking_Public_set_Void_Boolean_0;

		// Token: 0x04001D26 RID: 7462
		private static readonly IntPtr NativeMethodInfoPtr_Blocking_internal_Private_Static_Void_SafeSocketHandle_Boolean_byref_Int32_0;

		// Token: 0x04001D27 RID: 7463
		private static readonly IntPtr NativeMethodInfoPtr_Blocking_icall_Internal_Static_Void_IntPtr_Boolean_byref_Int32_0;

		// Token: 0x04001D28 RID: 7464
		private static readonly IntPtr NativeMethodInfoPtr_get_Connected_Public_get_Boolean_0;

		// Token: 0x04001D29 RID: 7465
		private static readonly IntPtr NativeMethodInfoPtr_set_NoDelay_Public_set_Void_Boolean_0;

		// Token: 0x04001D2A RID: 7466
		private static readonly IntPtr NativeMethodInfoPtr_get_RemoteEndPoint_Public_get_EndPoint_0;

		// Token: 0x04001D2B RID: 7467
		private static readonly IntPtr NativeMethodInfoPtr_RemoteEndPoint_internal_Private_Static_SocketAddress_SafeSocketHandle_Int32_byref_Int32_0;

		// Token: 0x04001D2C RID: 7468
		private static readonly IntPtr NativeMethodInfoPtr_RemoteEndPoint_icall_Private_Static_SocketAddress_IntPtr_Int32_byref_Int32_0;

		// Token: 0x04001D2D RID: 7469
		private static readonly IntPtr NativeMethodInfoPtr_Poll_Public_Boolean_Int32_SelectMode_0;

		// Token: 0x04001D2E RID: 7470
		private static readonly IntPtr NativeMethodInfoPtr_Poll_internal_Private_Static_Boolean_SafeSocketHandle_SelectMode_Int32_byref_Int32_0;

		// Token: 0x04001D2F RID: 7471
		private static readonly IntPtr NativeMethodInfoPtr_Poll_icall_Private_Static_Boolean_IntPtr_SelectMode_Int32_byref_Int32_0;

		// Token: 0x04001D30 RID: 7472
		private static readonly IntPtr NativeMethodInfoPtr_Accept_Public_Socket_0;

		// Token: 0x04001D31 RID: 7473
		private static readonly IntPtr NativeMethodInfoPtr_Accept_Internal_Void_Socket_0;

		// Token: 0x04001D32 RID: 7474
		private static readonly IntPtr NativeMethodInfoPtr_AcceptAsync_Public_Boolean_SocketAsyncEventArgs_0;

		// Token: 0x04001D33 RID: 7475
		private static readonly IntPtr NativeMethodInfoPtr_BeginAccept_Public_IAsyncResult_AsyncCallback_Object_0;

		// Token: 0x04001D34 RID: 7476
		private static readonly IntPtr NativeMethodInfoPtr_EndAccept_Public_Socket_IAsyncResult_0;

		// Token: 0x04001D35 RID: 7477
		private static readonly IntPtr NativeMethodInfoPtr_EndAccept_Public_Socket_byref_Il2CppStructArray_1_Byte_byref_Int32_IAsyncResult_0;

		// Token: 0x04001D36 RID: 7478
		private static readonly IntPtr NativeMethodInfoPtr_Accept_internal_Private_Static_SafeSocketHandle_SafeSocketHandle_byref_Int32_Boolean_0;

		// Token: 0x04001D37 RID: 7479
		private static readonly IntPtr NativeMethodInfoPtr_Accept_icall_Private_Static_IntPtr_IntPtr_byref_Int32_Boolean_0;

		// Token: 0x04001D38 RID: 7480
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Void_EndPoint_0;

		// Token: 0x04001D39 RID: 7481
		private static readonly IntPtr NativeMethodInfoPtr_Bind_internal_Private_Static_Void_SafeSocketHandle_SocketAddress_byref_Int32_0;

		// Token: 0x04001D3A RID: 7482
		private static readonly IntPtr NativeMethodInfoPtr_Bind_icall_Private_Static_Void_IntPtr_SocketAddress_byref_Int32_0;

		// Token: 0x04001D3B RID: 7483
		private static readonly IntPtr NativeMethodInfoPtr_Listen_Public_Void_Int32_0;

		// Token: 0x04001D3C RID: 7484
		private static readonly IntPtr NativeMethodInfoPtr_Listen_internal_Private_Static_Void_SafeSocketHandle_Int32_byref_Int32_0;

		// Token: 0x04001D3D RID: 7485
		private static readonly IntPtr NativeMethodInfoPtr_Listen_icall_Private_Static_Void_IntPtr_Int32_byref_Int32_0;

		// Token: 0x04001D3E RID: 7486
		private static readonly IntPtr NativeMethodInfoPtr_Connect_Public_Void_IPAddress_Int32_0;

		// Token: 0x04001D3F RID: 7487
		private static readonly IntPtr NativeMethodInfoPtr_Connect_Public_Void_EndPoint_0;

		// Token: 0x04001D40 RID: 7488
		private static readonly IntPtr NativeMethodInfoPtr_BeginConnect_Public_IAsyncResult_String_Int32_AsyncCallback_Object_0;

		// Token: 0x04001D41 RID: 7489
		private static readonly IntPtr NativeMethodInfoPtr_BeginConnect_Public_IAsyncResult_EndPoint_AsyncCallback_Object_0;

		// Token: 0x04001D42 RID: 7490
		private static readonly IntPtr NativeMethodInfoPtr_BeginMConnect_Private_Static_Boolean_SocketAsyncResult_0;

		// Token: 0x04001D43 RID: 7491
		private static readonly IntPtr NativeMethodInfoPtr_BeginSConnect_Private_Static_Boolean_SocketAsyncResult_0;

		// Token: 0x04001D44 RID: 7492
		private static readonly IntPtr NativeMethodInfoPtr_EndConnect_Public_Void_IAsyncResult_0;

		// Token: 0x04001D45 RID: 7493
		private static readonly IntPtr NativeMethodInfoPtr_Connect_internal_Private_Static_Void_SafeSocketHandle_SocketAddress_byref_Int32_Boolean_0;

		// Token: 0x04001D46 RID: 7494
		private static readonly IntPtr NativeMethodInfoPtr_Connect_icall_Private_Static_Void_IntPtr_SocketAddress_byref_Int32_Boolean_0;

		// Token: 0x04001D47 RID: 7495
		private static readonly IntPtr NativeMethodInfoPtr_Disconnect_Public_Void_Boolean_0;

		// Token: 0x04001D48 RID: 7496
		private static readonly IntPtr NativeMethodInfoPtr_EndDisconnect_Public_Void_IAsyncResult_0;

		// Token: 0x04001D49 RID: 7497
		private static readonly IntPtr NativeMethodInfoPtr_Disconnect_internal_Private_Static_Void_SafeSocketHandle_Boolean_byref_Int32_0;

		// Token: 0x04001D4A RID: 7498
		private static readonly IntPtr NativeMethodInfoPtr_Disconnect_icall_Private_Static_Void_IntPtr_Boolean_byref_Int32_0;

		// Token: 0x04001D4B RID: 7499
		private static readonly IntPtr NativeMethodInfoPtr_Receive_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_0;

		// Token: 0x04001D4C RID: 7500
		private static readonly IntPtr NativeMethodInfoPtr_Receive_Private_Int32_Memory_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_0;

		// Token: 0x04001D4D RID: 7501
		private static readonly IntPtr NativeMethodInfoPtr_Receive_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_byref_SocketError_0;

		// Token: 0x04001D4E RID: 7502
		private static readonly IntPtr NativeMethodInfoPtr_Receive_Public_Int32_Span_1_Byte_SocketFlags_byref_SocketError_0;

		// Token: 0x04001D4F RID: 7503
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Int32_ReadOnlySpan_1_Byte_SocketFlags_byref_SocketError_0;

		// Token: 0x04001D50 RID: 7504
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveAsync_Public_Boolean_SocketAsyncEventArgs_0;

		// Token: 0x04001D51 RID: 7505
		private static readonly IntPtr NativeMethodInfoPtr_BeginReceive_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_AsyncCallback_Object_0;

		// Token: 0x04001D52 RID: 7506
		private static readonly IntPtr NativeMethodInfoPtr_EndReceive_Public_Int32_IAsyncResult_byref_SocketError_0;

		// Token: 0x04001D53 RID: 7507
		private static readonly IntPtr NativeMethodInfoPtr_Receive_internal_Private_Static_Int32_SafeSocketHandle_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0;

		// Token: 0x04001D54 RID: 7508
		private static readonly IntPtr NativeMethodInfoPtr_Receive_array_icall_Private_Static_Int32_IntPtr_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0;

		// Token: 0x04001D55 RID: 7509
		private static readonly IntPtr NativeMethodInfoPtr_Receive_internal_Private_Static_Int32_SafeSocketHandle_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0;

		// Token: 0x04001D56 RID: 7510
		private static readonly IntPtr NativeMethodInfoPtr_Receive_icall_Private_Static_Int32_IntPtr_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0;

		// Token: 0x04001D57 RID: 7511
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveFrom_Private_Int32_Memory_1_Byte_Int32_Int32_SocketFlags_byref_EndPoint_byref_SocketError_0;

		// Token: 0x04001D58 RID: 7512
		private static readonly IntPtr NativeMethodInfoPtr_BeginReceiveFrom_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_EndPoint_AsyncCallback_Object_0;

		// Token: 0x04001D59 RID: 7513
		private static readonly IntPtr NativeMethodInfoPtr_EndReceiveFrom_Public_Int32_IAsyncResult_byref_EndPoint_0;

		// Token: 0x04001D5A RID: 7514
		private static readonly IntPtr NativeMethodInfoPtr_EndReceiveFrom_internal_Private_Int32_SocketAsyncResult_SocketAsyncEventArgs_0;

		// Token: 0x04001D5B RID: 7515
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveFrom_internal_Private_Static_Int32_SafeSocketHandle_ptr_Byte_Int32_SocketFlags_byref_SocketAddress_byref_Int32_Boolean_0;

		// Token: 0x04001D5C RID: 7516
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveFrom_icall_Private_Static_Int32_IntPtr_ptr_Byte_Int32_SocketFlags_byref_SocketAddress_byref_Int32_Boolean_0;

		// Token: 0x04001D5D RID: 7517
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_0;

		// Token: 0x04001D5E RID: 7518
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_byref_SocketError_0;

		// Token: 0x04001D5F RID: 7519
		private static readonly IntPtr NativeMethodInfoPtr_SendAsync_Public_Boolean_SocketAsyncEventArgs_0;

		// Token: 0x04001D60 RID: 7520
		private static readonly IntPtr NativeMethodInfoPtr_BeginSend_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_AsyncCallback_Object_0;

		// Token: 0x04001D61 RID: 7521
		private static readonly IntPtr NativeMethodInfoPtr_BeginSendCallback_Private_Static_Void_SocketAsyncResult_Int32_0;

		// Token: 0x04001D62 RID: 7522
		private static readonly IntPtr NativeMethodInfoPtr_EndSend_Public_Int32_IAsyncResult_byref_SocketError_0;

		// Token: 0x04001D63 RID: 7523
		private static readonly IntPtr NativeMethodInfoPtr_Send_internal_Private_Static_Int32_SafeSocketHandle_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0;

		// Token: 0x04001D64 RID: 7524
		private static readonly IntPtr NativeMethodInfoPtr_Send_array_icall_Private_Static_Int32_IntPtr_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0;

		// Token: 0x04001D65 RID: 7525
		private static readonly IntPtr NativeMethodInfoPtr_Send_internal_Private_Static_Int32_SafeSocketHandle_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0;

		// Token: 0x04001D66 RID: 7526
		private static readonly IntPtr NativeMethodInfoPtr_Send_icall_Private_Static_Int32_IntPtr_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0;

		// Token: 0x04001D67 RID: 7527
		private static readonly IntPtr NativeMethodInfoPtr_SendTo_Private_Int32_Memory_1_Byte_Int32_Int32_SocketFlags_EndPoint_0;

		// Token: 0x04001D68 RID: 7528
		private static readonly IntPtr NativeMethodInfoPtr_BeginSendTo_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_EndPoint_AsyncCallback_Object_0;

		// Token: 0x04001D69 RID: 7529
		private static readonly IntPtr NativeMethodInfoPtr_BeginSendToCallback_Private_Static_Void_SocketAsyncResult_Int32_0;

		// Token: 0x04001D6A RID: 7530
		private static readonly IntPtr NativeMethodInfoPtr_EndSendTo_Public_Int32_IAsyncResult_0;

		// Token: 0x04001D6B RID: 7531
		private static readonly IntPtr NativeMethodInfoPtr_SendTo_internal_Private_Static_Int32_SafeSocketHandle_ptr_Byte_Int32_SocketFlags_SocketAddress_byref_Int32_Boolean_0;

		// Token: 0x04001D6C RID: 7532
		private static readonly IntPtr NativeMethodInfoPtr_SendTo_icall_Private_Static_Int32_IntPtr_ptr_Byte_Int32_SocketFlags_SocketAddress_byref_Int32_Boolean_0;

		// Token: 0x04001D6D RID: 7533
		private static readonly IntPtr NativeMethodInfoPtr_GetSocketOption_Public_Object_SocketOptionLevel_SocketOptionName_0;

		// Token: 0x04001D6E RID: 7534
		private static readonly IntPtr NativeMethodInfoPtr_GetSocketOption_obj_internal_Private_Static_Void_SafeSocketHandle_SocketOptionLevel_SocketOptionName_byref_Object_byref_Int32_0;

		// Token: 0x04001D6F RID: 7535
		private static readonly IntPtr NativeMethodInfoPtr_GetSocketOption_obj_icall_Private_Static_Void_IntPtr_SocketOptionLevel_SocketOptionName_byref_Object_byref_Int32_0;

		// Token: 0x04001D70 RID: 7536
		private static readonly IntPtr NativeMethodInfoPtr_SetSocketOption_Public_Void_SocketOptionLevel_SocketOptionName_Int32_0;

		// Token: 0x04001D71 RID: 7537
		private static readonly IntPtr NativeMethodInfoPtr_SetSocketOption_internal_Private_Static_Void_SafeSocketHandle_SocketOptionLevel_SocketOptionName_Object_Il2CppStructArray_1_Byte_Int32_byref_Int32_0;

		// Token: 0x04001D72 RID: 7538
		private static readonly IntPtr NativeMethodInfoPtr_SetSocketOption_icall_Private_Static_Void_IntPtr_SocketOptionLevel_SocketOptionName_Object_Il2CppStructArray_1_Byte_Int32_byref_Int32_0;

		// Token: 0x04001D73 RID: 7539
		private static readonly IntPtr NativeMethodInfoPtr_IOControl_Public_Int32_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001D74 RID: 7540
		private static readonly IntPtr NativeMethodInfoPtr_IOControl_internal_Private_Static_Int32_SafeSocketHandle_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_byref_Int32_0;

		// Token: 0x04001D75 RID: 7541
		private static readonly IntPtr NativeMethodInfoPtr_IOControl_icall_Private_Static_Int32_IntPtr_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_byref_Int32_0;

		// Token: 0x04001D76 RID: 7542
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04001D77 RID: 7543
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_Int32_0;

		// Token: 0x04001D78 RID: 7544
		private static readonly IntPtr NativeMethodInfoPtr_Close_icall_Internal_Static_Void_IntPtr_byref_Int32_0;

		// Token: 0x04001D79 RID: 7545
		private static readonly IntPtr NativeMethodInfoPtr_Shutdown_Public_Void_SocketShutdown_0;

		// Token: 0x04001D7A RID: 7546
		private static readonly IntPtr NativeMethodInfoPtr_Shutdown_internal_Private_Static_Void_SafeSocketHandle_SocketShutdown_byref_Int32_0;

		// Token: 0x04001D7B RID: 7547
		private static readonly IntPtr NativeMethodInfoPtr_Shutdown_icall_Internal_Static_Void_IntPtr_SocketShutdown_byref_Int32_0;

		// Token: 0x04001D7C RID: 7548
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04001D7D RID: 7549
		private static readonly IntPtr NativeMethodInfoPtr_Linger_Private_Void_IntPtr_0;

		// Token: 0x04001D7E RID: 7550
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfDisposedAndClosed_Private_Void_0;

		// Token: 0x04001D7F RID: 7551
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfBufferNull_Private_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001D80 RID: 7552
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfBufferOutOfRange_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001D81 RID: 7553
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfUdp_Private_Void_0;

		// Token: 0x04001D82 RID: 7554
		private static readonly IntPtr NativeMethodInfoPtr_ValidateEndIAsyncResult_Private_SocketAsyncResult_IAsyncResult_String_String_0;

		// Token: 0x04001D83 RID: 7555
		private static readonly IntPtr NativeMethodInfoPtr_QueueIOSelectorJob_Private_Void_SemaphoreSlim_IntPtr_IOSelectorJob_0;

		// Token: 0x04001D84 RID: 7556
		private static readonly IntPtr NativeMethodInfoPtr_InitSocketAsyncEventArgs_Private_Void_SocketAsyncEventArgs_AsyncCallback_Object_SocketOperation_0;

		// Token: 0x04001D85 RID: 7557
		private static readonly IntPtr NativeMethodInfoPtr_SocketOperationToSocketAsyncOperation_Private_SocketAsyncOperation_SocketOperation_0;

		// Token: 0x04001D86 RID: 7558
		private static readonly IntPtr NativeMethodInfoPtr_RemapIPEndPoint_Private_IPEndPoint_IPEndPoint_0;

		// Token: 0x04001D87 RID: 7559
		private static readonly IntPtr NativeMethodInfoPtr_cancel_blocking_socket_operation_Internal_Static_Void_Thread_0;

		// Token: 0x04001D88 RID: 7560
		private static readonly IntPtr NativeMethodInfoPtr_get_FamilyHint_Internal_Static_get_Int32_0;

		// Token: 0x04001D89 RID: 7561
		private static readonly IntPtr NativeMethodInfoPtr_IsProtocolSupported_internal_Private_Static_Boolean_NetworkInterfaceComponent_0;

		// Token: 0x04001D8A RID: 7562
		private static readonly IntPtr NativeMethodInfoPtr_IsProtocolSupported_Private_Static_Boolean_NetworkInterfaceComponent_0;

		// Token: 0x0200036A RID: 874
		public sealed class CachedEventArgs : Object
		{
			// Token: 0x06003284 RID: 12932 RVA: 0x000D5F50 File Offset: 0x000D4150
			// Note: this type is marked as 'beforefieldinit'.
			static CachedEventArgs()
			{
				Il2CppClassPointerStore<Socket.CachedEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Socket>.NativeClassPtr, "CachedEventArgs");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Socket.CachedEventArgs>.NativeClassPtr);
				Socket.CachedEventArgs.NativeFieldInfoPtr_TaskAccept = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.CachedEventArgs>.NativeClassPtr, "TaskAccept");
				Socket.CachedEventArgs.NativeFieldInfoPtr_TaskReceive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.CachedEventArgs>.NativeClassPtr, "TaskReceive");
				Socket.CachedEventArgs.NativeFieldInfoPtr_TaskSend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.CachedEventArgs>.NativeClassPtr, "TaskSend");
				Socket.CachedEventArgs.NativeFieldInfoPtr_ValueTaskReceive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.CachedEventArgs>.NativeClassPtr, "ValueTaskReceive");
				Socket.CachedEventArgs.NativeFieldInfoPtr_ValueTaskSend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.CachedEventArgs>.NativeClassPtr, "ValueTaskSend");
				Socket.CachedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.CachedEventArgs>.NativeClassPtr, 100668957);
			}

			// Token: 0x06003285 RID: 12933 RVA: 0x000D5FF4 File Offset: 0x000D41F4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CachedEventArgs()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Socket.CachedEventArgs>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.CachedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003286 RID: 12934 RVA: 0x00017F3A File Offset: 0x0001613A
			public CachedEventArgs(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FF2 RID: 4082
			// (get) Token: 0x06003287 RID: 12935 RVA: 0x000D6030 File Offset: 0x000D4230
			// (set) Token: 0x06003288 RID: 12936 RVA: 0x00017F43 File Offset: 0x00016143
			public unsafe Socket.TaskSocketAsyncEventArgs<Socket> TaskAccept
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.CachedEventArgs.NativeFieldInfoPtr_TaskAccept);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket.TaskSocketAsyncEventArgs<Socket>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.CachedEventArgs.NativeFieldInfoPtr_TaskAccept), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FF3 RID: 4083
			// (get) Token: 0x06003289 RID: 12937 RVA: 0x000D6060 File Offset: 0x000D4260
			// (set) Token: 0x0600328A RID: 12938 RVA: 0x00017F62 File Offset: 0x00016162
			public unsafe Socket.Int32TaskSocketAsyncEventArgs TaskReceive
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.CachedEventArgs.NativeFieldInfoPtr_TaskReceive);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket.Int32TaskSocketAsyncEventArgs>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.CachedEventArgs.NativeFieldInfoPtr_TaskReceive), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FF4 RID: 4084
			// (get) Token: 0x0600328B RID: 12939 RVA: 0x000D6090 File Offset: 0x000D4290
			// (set) Token: 0x0600328C RID: 12940 RVA: 0x00017F81 File Offset: 0x00016181
			public unsafe Socket.Int32TaskSocketAsyncEventArgs TaskSend
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.CachedEventArgs.NativeFieldInfoPtr_TaskSend);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket.Int32TaskSocketAsyncEventArgs>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.CachedEventArgs.NativeFieldInfoPtr_TaskSend), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FF5 RID: 4085
			// (get) Token: 0x0600328D RID: 12941 RVA: 0x000D60C0 File Offset: 0x000D42C0
			// (set) Token: 0x0600328E RID: 12942 RVA: 0x00017FA0 File Offset: 0x000161A0
			public unsafe Socket.AwaitableSocketAsyncEventArgs ValueTaskReceive
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.CachedEventArgs.NativeFieldInfoPtr_ValueTaskReceive);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket.AwaitableSocketAsyncEventArgs>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.CachedEventArgs.NativeFieldInfoPtr_ValueTaskReceive), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FF6 RID: 4086
			// (get) Token: 0x0600328F RID: 12943 RVA: 0x000D60F0 File Offset: 0x000D42F0
			// (set) Token: 0x06003290 RID: 12944 RVA: 0x00017FBF File Offset: 0x000161BF
			public unsafe Socket.AwaitableSocketAsyncEventArgs ValueTaskSend
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.CachedEventArgs.NativeFieldInfoPtr_ValueTaskSend);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket.AwaitableSocketAsyncEventArgs>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.CachedEventArgs.NativeFieldInfoPtr_ValueTaskSend), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040026CA RID: 9930
			private static readonly IntPtr NativeFieldInfoPtr_TaskAccept;

			// Token: 0x040026CB RID: 9931
			private static readonly IntPtr NativeFieldInfoPtr_TaskReceive;

			// Token: 0x040026CC RID: 9932
			private static readonly IntPtr NativeFieldInfoPtr_TaskSend;

			// Token: 0x040026CD RID: 9933
			private static readonly IntPtr NativeFieldInfoPtr_ValueTaskReceive;

			// Token: 0x040026CE RID: 9934
			private static readonly IntPtr NativeFieldInfoPtr_ValueTaskSend;

			// Token: 0x040026CF RID: 9935
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200036B RID: 875
		public class TaskSocketAsyncEventArgs<TResult> : SocketAsyncEventArgs
		{
			// Token: 0x06003291 RID: 12945 RVA: 0x000D6120 File Offset: 0x000D4320
			// Note: this type is marked as 'beforefieldinit'.
			static TaskSocketAsyncEventArgs()
			{
				Il2CppClassPointerStore<Socket.TaskSocketAsyncEventArgs<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Socket>.NativeClassPtr, "TaskSocketAsyncEventArgs`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Socket.TaskSocketAsyncEventArgs<TResult>>.NativeClassPtr);
				Socket.TaskSocketAsyncEventArgs<TResult>.NativeFieldInfoPtr__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.TaskSocketAsyncEventArgs<TResult>>.NativeClassPtr, "_builder");
				Socket.TaskSocketAsyncEventArgs<TResult>.NativeFieldInfoPtr__accessed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.TaskSocketAsyncEventArgs<TResult>>.NativeClassPtr, "_accessed");
				Socket.TaskSocketAsyncEventArgs<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.TaskSocketAsyncEventArgs<TResult>>.NativeClassPtr, 100668958);
				Socket.TaskSocketAsyncEventArgs<TResult>.NativeMethodInfoPtr_GetCompletionResponsibility_Internal_AsyncTaskMethodBuilder_1_TResult_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.TaskSocketAsyncEventArgs<TResult>>.NativeClassPtr, 100668959);
			}

			// Token: 0x06003292 RID: 12946 RVA: 0x000D61D8 File Offset: 0x000D43D8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 487431, RefRangeEnd = 487432, XrefRangeStart = 487430, XrefRangeEnd = 487431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TaskSocketAsyncEventArgs()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Socket.TaskSocketAsyncEventArgs<TResult>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.TaskSocketAsyncEventArgs<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003293 RID: 12947 RVA: 0x000D6214 File Offset: 0x000D4414
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 487439, RefRangeEnd = 487440, XrefRangeStart = 487432, XrefRangeEnd = 487439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AsyncTaskMethodBuilder<TResult> GetCompletionResponsibility(out bool responsibleForReturningToPool)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &responsibleForReturningToPool;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.TaskSocketAsyncEventArgs<TResult>.NativeMethodInfoPtr_GetCompletionResponsibility_Internal_AsyncTaskMethodBuilder_1_TResult_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new AsyncTaskMethodBuilder<TResult>(intPtr);
				}
			}

			// Token: 0x06003294 RID: 12948 RVA: 0x00017FDE File Offset: 0x000161DE
			public TaskSocketAsyncEventArgs(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FF7 RID: 4087
			// (get) Token: 0x06003295 RID: 12949 RVA: 0x000D6258 File Offset: 0x000D4458
			// (set) Token: 0x06003296 RID: 12950 RVA: 0x00017FE7 File Offset: 0x000161E7
			public AsyncTaskMethodBuilder<TResult> _builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.TaskSocketAsyncEventArgs<TResult>.NativeFieldInfoPtr__builder);
					return new AsyncTaskMethodBuilder<TResult>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResult>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.TaskSocketAsyncEventArgs<TResult>.NativeFieldInfoPtr__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResult>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000FF8 RID: 4088
			// (get) Token: 0x06003297 RID: 12951 RVA: 0x000D6288 File Offset: 0x000D4488
			// (set) Token: 0x06003298 RID: 12952 RVA: 0x00018015 File Offset: 0x00016215
			public unsafe bool _accessed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.TaskSocketAsyncEventArgs<TResult>.NativeFieldInfoPtr__accessed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.TaskSocketAsyncEventArgs<TResult>.NativeFieldInfoPtr__accessed)) = value;
				}
			}

			// Token: 0x040026D0 RID: 9936
			private static readonly IntPtr NativeFieldInfoPtr__builder;

			// Token: 0x040026D1 RID: 9937
			private static readonly IntPtr NativeFieldInfoPtr__accessed;

			// Token: 0x040026D2 RID: 9938
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

			// Token: 0x040026D3 RID: 9939
			private static readonly IntPtr NativeMethodInfoPtr_GetCompletionResponsibility_Internal_AsyncTaskMethodBuilder_1_TResult_byref_Boolean_0;
		}

		// Token: 0x0200036C RID: 876
		public sealed class Int32TaskSocketAsyncEventArgs : Socket.TaskSocketAsyncEventArgs<int>
		{
			// Token: 0x06003299 RID: 12953 RVA: 0x000D62B0 File Offset: 0x000D44B0
			// Note: this type is marked as 'beforefieldinit'.
			static Int32TaskSocketAsyncEventArgs()
			{
				Il2CppClassPointerStore<Socket.Int32TaskSocketAsyncEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Socket>.NativeClassPtr, "Int32TaskSocketAsyncEventArgs");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Socket.Int32TaskSocketAsyncEventArgs>.NativeClassPtr);
				Socket.Int32TaskSocketAsyncEventArgs.NativeFieldInfoPtr__wrapExceptionsInIOExceptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.Int32TaskSocketAsyncEventArgs>.NativeClassPtr, "_wrapExceptionsInIOExceptions");
				Socket.Int32TaskSocketAsyncEventArgs.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.Int32TaskSocketAsyncEventArgs>.NativeClassPtr, 100668960);
			}

			// Token: 0x0600329A RID: 12954 RVA: 0x000D6304 File Offset: 0x000D4504
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487440, XrefRangeEnd = 487443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Int32TaskSocketAsyncEventArgs()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Socket.Int32TaskSocketAsyncEventArgs>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.Int32TaskSocketAsyncEventArgs.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600329B RID: 12955 RVA: 0x00018030 File Offset: 0x00016230
			public Int32TaskSocketAsyncEventArgs(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FF9 RID: 4089
			// (get) Token: 0x0600329C RID: 12956 RVA: 0x000D6340 File Offset: 0x000D4540
			// (set) Token: 0x0600329D RID: 12957 RVA: 0x00018039 File Offset: 0x00016239
			public unsafe bool _wrapExceptionsInIOExceptions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.Int32TaskSocketAsyncEventArgs.NativeFieldInfoPtr__wrapExceptionsInIOExceptions);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.Int32TaskSocketAsyncEventArgs.NativeFieldInfoPtr__wrapExceptionsInIOExceptions)) = value;
				}
			}

			// Token: 0x040026D4 RID: 9940
			private static readonly IntPtr NativeFieldInfoPtr__wrapExceptionsInIOExceptions;

			// Token: 0x040026D5 RID: 9941
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200036D RID: 877
		public sealed class AwaitableSocketAsyncEventArgs : SocketAsyncEventArgs
		{
			// Token: 0x0600329E RID: 12958 RVA: 0x000D6368 File Offset: 0x000D4568
			// Note: this type is marked as 'beforefieldinit'.
			static AwaitableSocketAsyncEventArgs()
			{
				Il2CppClassPointerStore<Socket.AwaitableSocketAsyncEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Socket>.NativeClassPtr, "AwaitableSocketAsyncEventArgs");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Socket.AwaitableSocketAsyncEventArgs>.NativeClassPtr);
				Socket.AwaitableSocketAsyncEventArgs.NativeFieldInfoPtr_Reserved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.AwaitableSocketAsyncEventArgs>.NativeClassPtr, "Reserved");
				Socket.AwaitableSocketAsyncEventArgs.NativeFieldInfoPtr_s_completedSentinel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.AwaitableSocketAsyncEventArgs>.NativeClassPtr, "s_completedSentinel");
				Socket.AwaitableSocketAsyncEventArgs.NativeFieldInfoPtr_s_availableSentinel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.AwaitableSocketAsyncEventArgs>.NativeClassPtr, "s_availableSentinel");
				Socket.AwaitableSocketAsyncEventArgs.NativeFieldInfoPtr__continuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.AwaitableSocketAsyncEventArgs>.NativeClassPtr, "_continuation");
				Socket.AwaitableSocketAsyncEventArgs.NativeFieldInfoPtr__executionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.AwaitableSocketAsyncEventArgs>.NativeClassPtr, "_executionContext");
				Socket.AwaitableSocketAsyncEventArgs.NativeFieldInfoPtr__scheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.AwaitableSocketAsyncEventArgs>.NativeClassPtr, "_scheduler");
				Socket.AwaitableSocketAsyncEventArgs.NativeFieldInfoPtr__token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.AwaitableSocketAsyncEventArgs>.NativeClassPtr, "_token");
				Socket.AwaitableSocketAsyncEventArgs.NativeFieldInfoPtr__WrapExceptionsInIOExceptions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.AwaitableSocketAsyncEventArgs>.NativeClassPtr, "<WrapExceptionsInIOExceptions>k__BackingField");
				Socket.AwaitableSocketAsyncEventArgs.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.AwaitableSocketAsyncEventArgs>.NativeClassPtr, 100668961);
				Socket.AwaitableSocketAsyncEventArgs.NativeMethodInfoPtr_get_WrapExceptionsInIOExceptions_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.AwaitableSocketAsyncEventArgs>.NativeClassPtr, 100668962);
				Socket.AwaitableSocketAsyncEventArgs.NativeMethodInfoPtr_set_WrapExceptionsInIOExceptions_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.AwaitableSocketAsyncEventArgs>.NativeClassPtr, 100668963);
				Socket.AwaitableSocketAsyncEventArgs.NativeMethodInfoPtr_Reserve_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.AwaitableSocketAsyncEventArgs>.NativeClassPtr, 100668964);
				Socket.AwaitableSocketAsyncEventArgs.NativeMethodInfoPtr_Release_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.AwaitableSocketAsyncEventArgs>.NativeClassPtr, 100668965);
				Socket.AwaitableSocketAsyncEventArgs.NativeMethodInfoPtr_OnCompleted_Protected_Virtual_Void_SocketAsyncEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.AwaitableSocketAsyncEventArgs>.NativeClassPtr, 100668966);
				Socket.AwaitableSocketAsyncEventArgs.NativeMethodInfoPtr_ReceiveAsync_Public_ValueTask_1_Int32_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.AwaitableSocketAsyncEventArgs>.NativeClassPtr, 100668967);
				Socket.AwaitableSocketAsyncEventArgs.NativeMethodInfoPtr_SendAsyncForNetworkStream_Public_ValueTask_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.AwaitableSocketAsyncEventArgs>.NativeClassPtr, 100668968);
				Socket.AwaitableSocketAsyncEventArgs.NativeMethodInfoPtr_GetStatus_Public_Virtual_Final_New_ValueTaskSourceStatus_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.AwaitableSocketAsyncEventArgs>.NativeClassPtr, 100668969);
				Socket.AwaitableSocketAsyncEventArgs.NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_1_Object_Object_Int16_ValueTaskSourceOnCompletedFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.AwaitableSocketAsyncEventArgs>.NativeClassPtr, 100668970);
				Socket.AwaitableSocketAsyncEventArgs.NativeMethodInfoPtr_InvokeContinuation_Private_Void_Action_1_Object_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.AwaitableSocketAsyncEventArgs>.NativeClassPtr, 100668971);
				Socket.AwaitableSocketAsyncEventArgs.NativeMethodInfoPtr_GetResult_Public_Virtual_Final_New_Int32_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.AwaitableSocketAsyncEventArgs>.NativeClassPtr, 100668972);
				Socket.AwaitableSocketAsyncEventArgs.NativeMethodInfoPtr_System_Threading_Tasks_Sources_IValueTaskSource_GetResult_Private_Virtual_Final_New_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.AwaitableSocketAsyncEventArgs>.NativeClassPtr, 100668973);
				Socket.AwaitableSocketAsyncEventArgs.NativeMethodInfoPtr_ThrowIncorrectTokenException_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.AwaitableSocketAsyncEventArgs>.NativeClassPtr, 100668974);
				Socket.AwaitableSocketAsyncEventArgs.NativeMethodInfoPtr_ThrowMultipleContinuationsException_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.AwaitableSocketAsyncEventArgs>.NativeClassPtr, 100668975);
				Socket.AwaitableSocketAsyncEventArgs.NativeMethodInfoPtr_ThrowException_Private_Void_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.AwaitableSocketAsyncEventArgs>.NativeClassPtr, 100668976);
				Socket.AwaitableSocketAsyncEventArgs.NativeMethodInfoPtr_CreateException_Private_Exception_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.AwaitableSocketAsyncEventArgs>.NativeClassPtr, 100668977);
			}

			// Token: 0x0600329F RID: 12959 RVA: 0x000D6588 File Offset: 0x000D4788
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 487473, RefRangeEnd = 487476, XrefRangeStart = 487467, XrefRangeEnd = 487473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AwaitableSocketAsyncEventArgs()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Socket.AwaitableSocketAsyncEventArgs>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.AwaitableSocketAsyncEventArgs.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001002 RID: 4098
			// (get) Token: 0x060032A0 RID: 12960 RVA: 0x000D65C4 File Offset: 0x000D47C4
			// (set) Token: 0x060032A1 RID: 12961 RVA: 0x000D6600 File Offset: 0x000D4800
			public unsafe bool WrapExceptionsInIOExceptions
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.AwaitableSocketAsyncEventArgs.NativeMethodInfoPtr_get_WrapExceptionsInIOExceptions_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.AwaitableSocketAsyncEventArgs.NativeMethodInfoPtr_set_WrapExceptionsInIOExceptions_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060032A2 RID: 12962 RVA: 0x000D6640 File Offset: 0x000D4840
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 487482, RefRangeEnd = 487484, XrefRangeStart = 487476, XrefRangeEnd = 487482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Reserve()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.AwaitableSocketAsyncEventArgs.NativeMethodInfoPtr_Reserve_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060032A3 RID: 12963 RVA: 0x000D667C File Offset: 0x000D487C
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 487490, RefRangeEnd = 487494, XrefRangeStart = 487484, XrefRangeEnd = 487490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Release()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.AwaitableSocketAsyncEventArgs.NativeMethodInfoPtr_Release_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060032A4 RID: 12964 RVA: 0x000D66B0 File Offset: 0x000D48B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487494, XrefRangeEnd = 487529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void OnCompleted(SocketAsyncEventArgs _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.AwaitableSocketAsyncEventArgs.NativeMethodInfoPtr_OnCompleted_Protected_Virtual_Void_SocketAsyncEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060032A5 RID: 12965 RVA: 0x000D66F4 File Offset: 0x000D48F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487529, XrefRangeEnd = 487537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTask<int> ReceiveAsync(Socket socket)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(socket);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.AwaitableSocketAsyncEventArgs.NativeMethodInfoPtr_ReceiveAsync_Public_ValueTask_1_Int32_Socket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTask<int>(intPtr);
				}
			}

			// Token: 0x060032A6 RID: 12966 RVA: 0x000D673C File Offset: 0x000D493C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487537, XrefRangeEnd = 487547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTask SendAsyncForNetworkStream(Socket socket)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(socket);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.AwaitableSocketAsyncEventArgs.NativeMethodInfoPtr_SendAsyncForNetworkStream_Public_ValueTask_Socket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTask(intPtr);
				}
			}

			// Token: 0x060032A7 RID: 12967 RVA: 0x000D6784 File Offset: 0x000D4984
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487547, XrefRangeEnd = 487551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTaskSourceStatus GetStatus(short token)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref token;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.AwaitableSocketAsyncEventArgs.NativeMethodInfoPtr_GetStatus_Public_Virtual_Final_New_ValueTaskSourceStatus_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060032A8 RID: 12968 RVA: 0x000D67D0 File Offset: 0x000D49D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487551, XrefRangeEnd = 487582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OnCompleted(Action<Object> continuation, Object state, short token, ValueTaskSourceOnCompletedFlags flags)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref token;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.AwaitableSocketAsyncEventArgs.NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_1_Object_Object_Int16_ValueTaskSourceOnCompletedFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060032A9 RID: 12969 RVA: 0x000D6840 File Offset: 0x000D4A40
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 487592, RefRangeEnd = 487595, XrefRangeStart = 487582, XrefRangeEnd = 487592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void InvokeContinuation(Action<Object> continuation, Object state, bool forceAsync)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceAsync;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.AwaitableSocketAsyncEventArgs.NativeMethodInfoPtr_InvokeContinuation_Private_Void_Action_1_Object_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060032AA RID: 12970 RVA: 0x000D68A4 File Offset: 0x000D4AA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487595, XrefRangeEnd = 487596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int GetResult(short token)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref token;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.AwaitableSocketAsyncEventArgs.NativeMethodInfoPtr_GetResult_Public_Virtual_Final_New_Int32_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060032AB RID: 12971 RVA: 0x000D68F0 File Offset: 0x000D4AF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487596, XrefRangeEnd = 487597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Threading_Tasks_Sources_IValueTaskSource_GetResult(short token)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref token;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.AwaitableSocketAsyncEventArgs.NativeMethodInfoPtr_System_Threading_Tasks_Sources_IValueTaskSource_GetResult_Private_Virtual_Final_New_Void_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060032AC RID: 12972 RVA: 0x000D6930 File Offset: 0x000D4B30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487597, XrefRangeEnd = 487603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ThrowIncorrectTokenException()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.AwaitableSocketAsyncEventArgs.NativeMethodInfoPtr_ThrowIncorrectTokenException_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060032AD RID: 12973 RVA: 0x000D6964 File Offset: 0x000D4B64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487603, XrefRangeEnd = 487640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ThrowMultipleContinuationsException()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.AwaitableSocketAsyncEventArgs.NativeMethodInfoPtr_ThrowMultipleContinuationsException_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060032AE RID: 12974 RVA: 0x000D6998 File Offset: 0x000D4B98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487640, XrefRangeEnd = 487643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ThrowException(SocketError error)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref error;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.AwaitableSocketAsyncEventArgs.NativeMethodInfoPtr_ThrowException_Private_Void_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060032AF RID: 12975 RVA: 0x000D69D8 File Offset: 0x000D4BD8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 487654, RefRangeEnd = 487656, XrefRangeStart = 487643, XrefRangeEnd = 487654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Exception CreateException(SocketError error)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref error;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.AwaitableSocketAsyncEventArgs.NativeMethodInfoPtr_CreateException_Private_Exception_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
				}
			}

			// Token: 0x060032B0 RID: 12976 RVA: 0x00018054 File Offset: 0x00016254
			public AwaitableSocketAsyncEventArgs(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FFA RID: 4090
			// (get) Token: 0x060032B1 RID: 12977 RVA: 0x000D6A24 File Offset: 0x000D4C24
			// (set) Token: 0x060032B2 RID: 12978 RVA: 0x0001805D File Offset: 0x0001625D
			public unsafe static Socket.AwaitableSocketAsyncEventArgs Reserved
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Socket.AwaitableSocketAsyncEventArgs.NativeFieldInfoPtr_Reserved, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket.AwaitableSocketAsyncEventArgs>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Socket.AwaitableSocketAsyncEventArgs.NativeFieldInfoPtr_Reserved, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FFB RID: 4091
			// (get) Token: 0x060032B3 RID: 12979 RVA: 0x000D6A4C File Offset: 0x000D4C4C
			// (set) Token: 0x060032B4 RID: 12980 RVA: 0x0001806F File Offset: 0x0001626F
			public unsafe static Action<Object> s_completedSentinel
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Socket.AwaitableSocketAsyncEventArgs.NativeFieldInfoPtr_s_completedSentinel, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Socket.AwaitableSocketAsyncEventArgs.NativeFieldInfoPtr_s_completedSentinel, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FFC RID: 4092
			// (get) Token: 0x060032B5 RID: 12981 RVA: 0x000D6A74 File Offset: 0x000D4C74
			// (set) Token: 0x060032B6 RID: 12982 RVA: 0x00018081 File Offset: 0x00016281
			public unsafe static Action<Object> s_availableSentinel
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Socket.AwaitableSocketAsyncEventArgs.NativeFieldInfoPtr_s_availableSentinel, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Socket.AwaitableSocketAsyncEventArgs.NativeFieldInfoPtr_s_availableSentinel, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FFD RID: 4093
			// (get) Token: 0x060032B7 RID: 12983 RVA: 0x000D6A9C File Offset: 0x000D4C9C
			// (set) Token: 0x060032B8 RID: 12984 RVA: 0x00018093 File Offset: 0x00016293
			public unsafe Action<Object> _continuation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.AwaitableSocketAsyncEventArgs.NativeFieldInfoPtr__continuation);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.AwaitableSocketAsyncEventArgs.NativeFieldInfoPtr__continuation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FFE RID: 4094
			// (get) Token: 0x060032B9 RID: 12985 RVA: 0x000D6ACC File Offset: 0x000D4CCC
			// (set) Token: 0x060032BA RID: 12986 RVA: 0x000180B2 File Offset: 0x000162B2
			public unsafe ExecutionContext _executionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.AwaitableSocketAsyncEventArgs.NativeFieldInfoPtr__executionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.AwaitableSocketAsyncEventArgs.NativeFieldInfoPtr__executionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FFF RID: 4095
			// (get) Token: 0x060032BB RID: 12987 RVA: 0x000D6AFC File Offset: 0x000D4CFC
			// (set) Token: 0x060032BC RID: 12988 RVA: 0x000180D1 File Offset: 0x000162D1
			public unsafe Object _scheduler
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.AwaitableSocketAsyncEventArgs.NativeFieldInfoPtr__scheduler);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.AwaitableSocketAsyncEventArgs.NativeFieldInfoPtr__scheduler), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001000 RID: 4096
			// (get) Token: 0x060032BD RID: 12989 RVA: 0x000D6B2C File Offset: 0x000D4D2C
			// (set) Token: 0x060032BE RID: 12990 RVA: 0x000180F0 File Offset: 0x000162F0
			public unsafe short _token
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.AwaitableSocketAsyncEventArgs.NativeFieldInfoPtr__token);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.AwaitableSocketAsyncEventArgs.NativeFieldInfoPtr__token)) = value;
				}
			}

			// Token: 0x17001001 RID: 4097
			// (get) Token: 0x060032BF RID: 12991 RVA: 0x000D6B54 File Offset: 0x000D4D54
			// (set) Token: 0x060032C0 RID: 12992 RVA: 0x0001810B File Offset: 0x0001630B
			public unsafe bool _WrapExceptionsInIOExceptions_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.AwaitableSocketAsyncEventArgs.NativeFieldInfoPtr__WrapExceptionsInIOExceptions_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.AwaitableSocketAsyncEventArgs.NativeFieldInfoPtr__WrapExceptionsInIOExceptions_k__BackingField)) = value;
				}
			}

			// Token: 0x040026D6 RID: 9942
			private static readonly IntPtr NativeFieldInfoPtr_Reserved;

			// Token: 0x040026D7 RID: 9943
			private static readonly IntPtr NativeFieldInfoPtr_s_completedSentinel;

			// Token: 0x040026D8 RID: 9944
			private static readonly IntPtr NativeFieldInfoPtr_s_availableSentinel;

			// Token: 0x040026D9 RID: 9945
			private static readonly IntPtr NativeFieldInfoPtr__continuation;

			// Token: 0x040026DA RID: 9946
			private static readonly IntPtr NativeFieldInfoPtr__executionContext;

			// Token: 0x040026DB RID: 9947
			private static readonly IntPtr NativeFieldInfoPtr__scheduler;

			// Token: 0x040026DC RID: 9948
			private static readonly IntPtr NativeFieldInfoPtr__token;

			// Token: 0x040026DD RID: 9949
			private static readonly IntPtr NativeFieldInfoPtr__WrapExceptionsInIOExceptions_k__BackingField;

			// Token: 0x040026DE RID: 9950
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040026DF RID: 9951
			private static readonly IntPtr NativeMethodInfoPtr_get_WrapExceptionsInIOExceptions_Public_get_Boolean_0;

			// Token: 0x040026E0 RID: 9952
			private static readonly IntPtr NativeMethodInfoPtr_set_WrapExceptionsInIOExceptions_Public_set_Void_Boolean_0;

			// Token: 0x040026E1 RID: 9953
			private static readonly IntPtr NativeMethodInfoPtr_Reserve_Public_Boolean_0;

			// Token: 0x040026E2 RID: 9954
			private static readonly IntPtr NativeMethodInfoPtr_Release_Private_Void_0;

			// Token: 0x040026E3 RID: 9955
			private static readonly IntPtr NativeMethodInfoPtr_OnCompleted_Protected_Virtual_Void_SocketAsyncEventArgs_0;

			// Token: 0x040026E4 RID: 9956
			private static readonly IntPtr NativeMethodInfoPtr_ReceiveAsync_Public_ValueTask_1_Int32_Socket_0;

			// Token: 0x040026E5 RID: 9957
			private static readonly IntPtr NativeMethodInfoPtr_SendAsyncForNetworkStream_Public_ValueTask_Socket_0;

			// Token: 0x040026E6 RID: 9958
			private static readonly IntPtr NativeMethodInfoPtr_GetStatus_Public_Virtual_Final_New_ValueTaskSourceStatus_Int16_0;

			// Token: 0x040026E7 RID: 9959
			private static readonly IntPtr NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_1_Object_Object_Int16_ValueTaskSourceOnCompletedFlags_0;

			// Token: 0x040026E8 RID: 9960
			private static readonly IntPtr NativeMethodInfoPtr_InvokeContinuation_Private_Void_Action_1_Object_Object_Boolean_0;

			// Token: 0x040026E9 RID: 9961
			private static readonly IntPtr NativeMethodInfoPtr_GetResult_Public_Virtual_Final_New_Int32_Int16_0;

			// Token: 0x040026EA RID: 9962
			private static readonly IntPtr NativeMethodInfoPtr_System_Threading_Tasks_Sources_IValueTaskSource_GetResult_Private_Virtual_Final_New_Void_Int16_0;

			// Token: 0x040026EB RID: 9963
			private static readonly IntPtr NativeMethodInfoPtr_ThrowIncorrectTokenException_Private_Void_0;

			// Token: 0x040026EC RID: 9964
			private static readonly IntPtr NativeMethodInfoPtr_ThrowMultipleContinuationsException_Private_Void_0;

			// Token: 0x040026ED RID: 9965
			private static readonly IntPtr NativeMethodInfoPtr_ThrowException_Private_Void_SocketError_0;

			// Token: 0x040026EE RID: 9966
			private static readonly IntPtr NativeMethodInfoPtr_CreateException_Private_Exception_SocketError_0;

			// Token: 0x020003C6 RID: 966
			[ObfuscatedName("System.Net.Sockets.Socket+AwaitableSocketAsyncEventArgs+<>c")]
			[Serializable]
			public sealed class __c : Object
			{
				// Token: 0x060035ED RID: 13805 RVA: 0x000DF9F8 File Offset: 0x000DDBF8
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<Socket.AwaitableSocketAsyncEventArgs.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Socket.AwaitableSocketAsyncEventArgs>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Socket.AwaitableSocketAsyncEventArgs.__c>.NativeClassPtr);
					Socket.AwaitableSocketAsyncEventArgs.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.AwaitableSocketAsyncEventArgs.__c>.NativeClassPtr, "<>9");
					Socket.AwaitableSocketAsyncEventArgs.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.AwaitableSocketAsyncEventArgs.__c>.NativeClassPtr, "<>9__14_0");
					Socket.AwaitableSocketAsyncEventArgs.__c.NativeFieldInfoPtr___9__20_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.AwaitableSocketAsyncEventArgs.__c>.NativeClassPtr, "<>9__20_0");
					Socket.AwaitableSocketAsyncEventArgs.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.AwaitableSocketAsyncEventArgs.__c>.NativeClassPtr, 100668980);
					Socket.AwaitableSocketAsyncEventArgs.__c.NativeMethodInfoPtr__OnCompleted_b__14_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.AwaitableSocketAsyncEventArgs.__c>.NativeClassPtr, 100668981);
					Socket.AwaitableSocketAsyncEventArgs.__c.NativeMethodInfoPtr__InvokeContinuation_b__20_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.AwaitableSocketAsyncEventArgs.__c>.NativeClassPtr, 100668982);
					Socket.AwaitableSocketAsyncEventArgs.__c.NativeMethodInfoPtr___cctor_b__27_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.AwaitableSocketAsyncEventArgs.__c>.NativeClassPtr, 100668983);
					Socket.AwaitableSocketAsyncEventArgs.__c.NativeMethodInfoPtr___cctor_b__27_1_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.AwaitableSocketAsyncEventArgs.__c>.NativeClassPtr, 100668984);
				}

				// Token: 0x060035EE RID: 13806 RVA: 0x000DFAC4 File Offset: 0x000DDCC4
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Socket.AwaitableSocketAsyncEventArgs.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.AwaitableSocketAsyncEventArgs.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060035EF RID: 13807 RVA: 0x000DFB00 File Offset: 0x000DDD00
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487443, XrefRangeEnd = 487449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _OnCompleted_b__14_0(Object runState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(runState);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.AwaitableSocketAsyncEventArgs.__c.NativeMethodInfoPtr__OnCompleted_b__14_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060035F0 RID: 13808 RVA: 0x000DFB44 File Offset: 0x000DDD44
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487449, XrefRangeEnd = 487455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _InvokeContinuation_b__20_0(Object s)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.AwaitableSocketAsyncEventArgs.__c.NativeMethodInfoPtr__InvokeContinuation_b__20_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060035F1 RID: 13809 RVA: 0x000DFB88 File Offset: 0x000DDD88
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487455, XrefRangeEnd = 487461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void __cctor_b__27_0(Object state)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.AwaitableSocketAsyncEventArgs.__c.NativeMethodInfoPtr___cctor_b__27_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060035F2 RID: 13810 RVA: 0x000DFBCC File Offset: 0x000DDDCC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487461, XrefRangeEnd = 487467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void __cctor_b__27_1(Object state)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.AwaitableSocketAsyncEventArgs.__c.NativeMethodInfoPtr___cctor_b__27_1_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060035F3 RID: 13811 RVA: 0x0001A74C File Offset: 0x0001894C
				public __c(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170010D6 RID: 4310
				// (get) Token: 0x060035F4 RID: 13812 RVA: 0x000DFC10 File Offset: 0x000DDE10
				// (set) Token: 0x060035F5 RID: 13813 RVA: 0x0001A755 File Offset: 0x00018955
				public unsafe static Socket.AwaitableSocketAsyncEventArgs.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(Socket.AwaitableSocketAsyncEventArgs.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket.AwaitableSocketAsyncEventArgs.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Socket.AwaitableSocketAsyncEventArgs.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170010D7 RID: 4311
				// (get) Token: 0x060035F6 RID: 13814 RVA: 0x000DFC38 File Offset: 0x000DDE38
				// (set) Token: 0x060035F7 RID: 13815 RVA: 0x0001A767 File Offset: 0x00018967
				public unsafe static ContextCallback __9__14_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(Socket.AwaitableSocketAsyncEventArgs.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextCallback>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Socket.AwaitableSocketAsyncEventArgs.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170010D8 RID: 4312
				// (get) Token: 0x060035F8 RID: 13816 RVA: 0x000DFC60 File Offset: 0x000DDE60
				// (set) Token: 0x060035F9 RID: 13817 RVA: 0x0001A779 File Offset: 0x00018979
				public unsafe static SendOrPostCallback __9__20_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(Socket.AwaitableSocketAsyncEventArgs.__c.NativeFieldInfoPtr___9__20_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SendOrPostCallback>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Socket.AwaitableSocketAsyncEventArgs.__c.NativeFieldInfoPtr___9__20_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040028B5 RID: 10421
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x040028B6 RID: 10422
				private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

				// Token: 0x040028B7 RID: 10423
				private static readonly IntPtr NativeFieldInfoPtr___9__20_0;

				// Token: 0x040028B8 RID: 10424
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x040028B9 RID: 10425
				private static readonly IntPtr NativeMethodInfoPtr__OnCompleted_b__14_0_Internal_Void_Object_0;

				// Token: 0x040028BA RID: 10426
				private static readonly IntPtr NativeMethodInfoPtr__InvokeContinuation_b__20_0_Internal_Void_Object_0;

				// Token: 0x040028BB RID: 10427
				private static readonly IntPtr NativeMethodInfoPtr___cctor_b__27_0_Internal_Void_Object_0;

				// Token: 0x040028BC RID: 10428
				private static readonly IntPtr NativeMethodInfoPtr___cctor_b__27_1_Internal_Void_Object_0;
			}
		}

		// Token: 0x0200036E RID: 878
		[StructLayout(2)]
		public struct WSABUF
		{
			// Token: 0x060032C1 RID: 12993 RVA: 0x000D6B7C File Offset: 0x000D4D7C
			// Note: this type is marked as 'beforefieldinit'.
			static WSABUF()
			{
				Il2CppClassPointerStore<Socket.WSABUF>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Socket>.NativeClassPtr, "WSABUF");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Socket.WSABUF>.NativeClassPtr);
				Socket.WSABUF.NativeFieldInfoPtr_len = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.WSABUF>.NativeClassPtr, "len");
				Socket.WSABUF.NativeFieldInfoPtr_buf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.WSABUF>.NativeClassPtr, "buf");
			}

			// Token: 0x060032C2 RID: 12994 RVA: 0x00018126 File Offset: 0x00016326
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Socket.WSABUF>.NativeClassPtr, ref this));
			}

			// Token: 0x040026EF RID: 9967
			private static readonly IntPtr NativeFieldInfoPtr_len;

			// Token: 0x040026F0 RID: 9968
			private static readonly IntPtr NativeFieldInfoPtr_buf;

			// Token: 0x040026F1 RID: 9969
			[FieldOffset(0)]
			public int len;

			// Token: 0x040026F2 RID: 9970
			[FieldOffset(8)]
			public IntPtr buf;
		}

		// Token: 0x0200036F RID: 879
		[ObfuscatedName("System.Net.Sockets.Socket+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060032C3 RID: 12995 RVA: 0x000D6BD0 File Offset: 0x000D4DD0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Socket.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Socket>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr);
				Socket.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, "<>9");
				Socket.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, "<>9__10_0");
				Socket.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, "<>9__14_0");
				Socket.__c.NativeFieldInfoPtr___9__14_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, "<>9__14_1");
				Socket.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, "<>9__15_0");
				Socket.__c.NativeFieldInfoPtr___9__15_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, "<>9__15_1");
				Socket.__c.NativeFieldInfoPtr___9__22_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, "<>9__22_0");
				Socket.__c.NativeFieldInfoPtr___9__22_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, "<>9__22_1");
				Socket.__c.NativeFieldInfoPtr___9__23_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, "<>9__23_0");
				Socket.__c.NativeFieldInfoPtr___9__23_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, "<>9__23_1");
				Socket.__c.NativeFieldInfoPtr___9__295_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, "<>9__295_0");
				Socket.__c.NativeFieldInfoPtr___9__297_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, "<>9__297_0");
				Socket.__c.NativeFieldInfoPtr___9__310_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, "<>9__310_0");
				Socket.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100668986);
				Socket.__c.NativeMethodInfoPtr__ConnectAsync_b__10_0_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100668987);
				Socket.__c.NativeMethodInfoPtr__ReceiveAsync_b__14_0_Internal_CachedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100668988);
				Socket.__c.NativeMethodInfoPtr__ReceiveAsync_b__14_1_Internal_AwaitableSocketAsyncEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100668989);
				Socket.__c.NativeMethodInfoPtr__ReceiveAsyncApm_b__15_0_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100668990);
				Socket.__c.NativeMethodInfoPtr__ReceiveAsyncApm_b__15_1_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100668991);
				Socket.__c.NativeMethodInfoPtr__SendAsyncForNetworkStream_b__22_0_Internal_CachedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100668992);
				Socket.__c.NativeMethodInfoPtr__SendAsyncForNetworkStream_b__22_1_Internal_AwaitableSocketAsyncEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100668993);
				Socket.__c.NativeMethodInfoPtr__SendAsyncApm_b__23_0_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100668994);
				Socket.__c.NativeMethodInfoPtr__SendAsyncApm_b__23_1_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100668995);
				Socket.__c.NativeMethodInfoPtr__SendAsync_b__295_0_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100668996);
				Socket.__c.NativeMethodInfoPtr__BeginSend_b__297_0_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100668997);
				Socket.__c.NativeMethodInfoPtr__BeginSendTo_b__310_0_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100668998);
				Socket.__c.NativeMethodInfoPtr___cctor_b__367_0_Internal_Void_Object_SocketAsyncEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100668999);
				Socket.__c.NativeMethodInfoPtr___cctor_b__367_1_Internal_Void_Object_SocketAsyncEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100669000);
				Socket.__c.NativeMethodInfoPtr___cctor_b__367_2_Internal_Void_Object_SocketAsyncEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100669001);
				Socket.__c.NativeMethodInfoPtr___cctor_b__367_3_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100669002);
				Socket.__c.NativeMethodInfoPtr___cctor_b__367_4_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100669003);
				Socket.__c.NativeMethodInfoPtr___cctor_b__367_5_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100669004);
				Socket.__c.NativeMethodInfoPtr___cctor_b__367_6_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100669005);
				Socket.__c.NativeMethodInfoPtr___cctor_b__367_7_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100669006);
				Socket.__c.NativeMethodInfoPtr___cctor_b__367_8_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100669007);
				Socket.__c.NativeMethodInfoPtr___cctor_b__367_9_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100669008);
				Socket.__c.NativeMethodInfoPtr___cctor_b__367_10_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100669009);
				Socket.__c.NativeMethodInfoPtr___cctor_b__367_11_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100669010);
				Socket.__c.NativeMethodInfoPtr___cctor_b__367_12_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100669011);
				Socket.__c.NativeMethodInfoPtr___cctor_b__367_13_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100669012);
				Socket.__c.NativeMethodInfoPtr___cctor_b__367_14_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100669013);
				Socket.__c.NativeMethodInfoPtr___cctor_b__367_15_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100669014);
				Socket.__c.NativeMethodInfoPtr___cctor_b__367_16_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100669015);
				Socket.__c.NativeMethodInfoPtr___cctor_b__367_17_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr, 100669016);
			}

			// Token: 0x060032C4 RID: 12996 RVA: 0x000D6F6C File Offset: 0x000D516C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Socket.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060032C5 RID: 12997 RVA: 0x000D6FA8 File Offset: 0x000D51A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487656, XrefRangeEnd = 487671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ConnectAsync_b__10_0(IAsyncResult iar)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(iar);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr__ConnectAsync_b__10_0_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060032C6 RID: 12998 RVA: 0x000D6FEC File Offset: 0x000D51EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487671, XrefRangeEnd = 487675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Socket.CachedEventArgs _ReceiveAsync_b__14_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr__ReceiveAsync_b__14_0_Internal_CachedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Socket.CachedEventArgs>(intPtr3) : null;
			}

			// Token: 0x060032C7 RID: 12999 RVA: 0x000D702C File Offset: 0x000D522C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487675, XrefRangeEnd = 487679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Socket.AwaitableSocketAsyncEventArgs _ReceiveAsync_b__14_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr__ReceiveAsync_b__14_1_Internal_AwaitableSocketAsyncEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Socket.AwaitableSocketAsyncEventArgs>(intPtr3) : null;
			}

			// Token: 0x060032C8 RID: 13000 RVA: 0x000D706C File Offset: 0x000D526C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487679, XrefRangeEnd = 487694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ReceiveAsyncApm_b__15_0(IAsyncResult iar)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(iar);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr__ReceiveAsyncApm_b__15_0_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060032C9 RID: 13001 RVA: 0x000D70B0 File Offset: 0x000D52B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487694, XrefRangeEnd = 487734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ReceiveAsyncApm_b__15_1(IAsyncResult iar)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(iar);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr__ReceiveAsyncApm_b__15_1_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060032CA RID: 13002 RVA: 0x000D70F4 File Offset: 0x000D52F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487734, XrefRangeEnd = 487738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Socket.CachedEventArgs _SendAsyncForNetworkStream_b__22_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr__SendAsyncForNetworkStream_b__22_0_Internal_CachedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Socket.CachedEventArgs>(intPtr3) : null;
			}

			// Token: 0x060032CB RID: 13003 RVA: 0x000D7134 File Offset: 0x000D5334
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487738, XrefRangeEnd = 487742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Socket.AwaitableSocketAsyncEventArgs _SendAsyncForNetworkStream_b__22_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr__SendAsyncForNetworkStream_b__22_1_Internal_AwaitableSocketAsyncEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Socket.AwaitableSocketAsyncEventArgs>(intPtr3) : null;
			}

			// Token: 0x060032CC RID: 13004 RVA: 0x000D7174 File Offset: 0x000D5374
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487742, XrefRangeEnd = 487757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SendAsyncApm_b__23_0(IAsyncResult iar)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(iar);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr__SendAsyncApm_b__23_0_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060032CD RID: 13005 RVA: 0x000D71B8 File Offset: 0x000D53B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487757, XrefRangeEnd = 487781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SendAsyncApm_b__23_1(IAsyncResult iar)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(iar);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr__SendAsyncApm_b__23_1_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060032CE RID: 13006 RVA: 0x000D71FC File Offset: 0x000D53FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487781, XrefRangeEnd = 487788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SendAsync_b__295_0(IOAsyncResult s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr__SendAsync_b__295_0_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060032CF RID: 13007 RVA: 0x000D7240 File Offset: 0x000D5440
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487788, XrefRangeEnd = 487795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _BeginSend_b__297_0(IOAsyncResult s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr__BeginSend_b__297_0_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060032D0 RID: 13008 RVA: 0x000D7284 File Offset: 0x000D5484
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487795, XrefRangeEnd = 487802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _BeginSendTo_b__310_0(IOAsyncResult s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr__BeginSendTo_b__310_0_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060032D1 RID: 13009 RVA: 0x000D72C8 File Offset: 0x000D54C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487802, XrefRangeEnd = 487830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__367_0(Object s, SocketAsyncEventArgs e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__367_0_Internal_Void_Object_SocketAsyncEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060032D2 RID: 13010 RVA: 0x000D731C File Offset: 0x000D551C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487830, XrefRangeEnd = 487839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__367_1(Object s, SocketAsyncEventArgs e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__367_1_Internal_Void_Object_SocketAsyncEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060032D3 RID: 13011 RVA: 0x000D7370 File Offset: 0x000D5570
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487839, XrefRangeEnd = 487848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__367_2(Object s, SocketAsyncEventArgs e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__367_2_Internal_Void_Object_SocketAsyncEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060032D4 RID: 13012 RVA: 0x000D73C4 File Offset: 0x000D55C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487848, XrefRangeEnd = 487864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__367_3(IAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__367_3_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060032D5 RID: 13013 RVA: 0x000D7408 File Offset: 0x000D5608
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487864, XrefRangeEnd = 487870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__367_4(IOAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__367_4_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060032D6 RID: 13014 RVA: 0x000D744C File Offset: 0x000D564C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487870, XrefRangeEnd = 487884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__367_5(IOAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__367_5_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060032D7 RID: 13015 RVA: 0x000D7490 File Offset: 0x000D5690
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487884, XrefRangeEnd = 487898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__367_6(IAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__367_6_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060032D8 RID: 13016 RVA: 0x000D74D4 File Offset: 0x000D56D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487898, XrefRangeEnd = 487924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__367_7(IOAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__367_7_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060032D9 RID: 13017 RVA: 0x000D7518 File Offset: 0x000D5718
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487924, XrefRangeEnd = 487945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__367_8(IAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__367_8_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060032DA RID: 13018 RVA: 0x000D755C File Offset: 0x000D575C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487945, XrefRangeEnd = 487953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__367_9(IOAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__367_9_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060032DB RID: 13019 RVA: 0x000D75A0 File Offset: 0x000D57A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487953, XrefRangeEnd = 487968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__367_10(IAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__367_10_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060032DC RID: 13020 RVA: 0x000D75E4 File Offset: 0x000D57E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487968, XrefRangeEnd = 487986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__367_11(IOAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__367_11_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060032DD RID: 13021 RVA: 0x000D7628 File Offset: 0x000D5828
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487986, XrefRangeEnd = 487990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__367_12(IOAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__367_12_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060032DE RID: 13022 RVA: 0x000D766C File Offset: 0x000D586C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487990, XrefRangeEnd = 488010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__367_13(IAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__367_13_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060032DF RID: 13023 RVA: 0x000D76B0 File Offset: 0x000D58B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488010, XrefRangeEnd = 488015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__367_14(IOAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__367_14_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060032E0 RID: 13024 RVA: 0x000D76F4 File Offset: 0x000D58F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488015, XrefRangeEnd = 488030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__367_15(IAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__367_15_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060032E1 RID: 13025 RVA: 0x000D7738 File Offset: 0x000D5938
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488030, XrefRangeEnd = 488034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__367_16(IOAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__367_16_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060032E2 RID: 13026 RVA: 0x000D777C File Offset: 0x000D597C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488034, XrefRangeEnd = 488049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__367_17(IAsyncResult ares)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c.NativeMethodInfoPtr___cctor_b__367_17_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060032E3 RID: 13027 RVA: 0x00018138 File Offset: 0x00016338
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001003 RID: 4099
			// (get) Token: 0x060032E4 RID: 13028 RVA: 0x000D77C0 File Offset: 0x000D59C0
			// (set) Token: 0x060032E5 RID: 13029 RVA: 0x00018141 File Offset: 0x00016341
			public unsafe static Socket.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Socket.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Socket.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001004 RID: 4100
			// (get) Token: 0x060032E6 RID: 13030 RVA: 0x000D77E8 File Offset: 0x000D59E8
			// (set) Token: 0x060032E7 RID: 13031 RVA: 0x00018153 File Offset: 0x00016353
			public unsafe static AsyncCallback __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Socket.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Socket.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001005 RID: 4101
			// (get) Token: 0x060032E8 RID: 13032 RVA: 0x000D7810 File Offset: 0x000D5A10
			// (set) Token: 0x060032E9 RID: 13033 RVA: 0x00018165 File Offset: 0x00016365
			public unsafe static Func<Socket.CachedEventArgs> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Socket.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Socket.CachedEventArgs>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Socket.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001006 RID: 4102
			// (get) Token: 0x060032EA RID: 13034 RVA: 0x000D7838 File Offset: 0x000D5A38
			// (set) Token: 0x060032EB RID: 13035 RVA: 0x00018177 File Offset: 0x00016377
			public unsafe static Func<Socket.AwaitableSocketAsyncEventArgs> __9__14_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Socket.__c.NativeFieldInfoPtr___9__14_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Socket.AwaitableSocketAsyncEventArgs>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Socket.__c.NativeFieldInfoPtr___9__14_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001007 RID: 4103
			// (get) Token: 0x060032EC RID: 13036 RVA: 0x000D7860 File Offset: 0x000D5A60
			// (set) Token: 0x060032ED RID: 13037 RVA: 0x00018189 File Offset: 0x00016389
			public unsafe static AsyncCallback __9__15_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Socket.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Socket.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001008 RID: 4104
			// (get) Token: 0x060032EE RID: 13038 RVA: 0x000D7888 File Offset: 0x000D5A88
			// (set) Token: 0x060032EF RID: 13039 RVA: 0x0001819B File Offset: 0x0001639B
			public unsafe static AsyncCallback __9__15_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Socket.__c.NativeFieldInfoPtr___9__15_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Socket.__c.NativeFieldInfoPtr___9__15_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001009 RID: 4105
			// (get) Token: 0x060032F0 RID: 13040 RVA: 0x000D78B0 File Offset: 0x000D5AB0
			// (set) Token: 0x060032F1 RID: 13041 RVA: 0x000181AD File Offset: 0x000163AD
			public unsafe static Func<Socket.CachedEventArgs> __9__22_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Socket.__c.NativeFieldInfoPtr___9__22_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Socket.CachedEventArgs>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Socket.__c.NativeFieldInfoPtr___9__22_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700100A RID: 4106
			// (get) Token: 0x060032F2 RID: 13042 RVA: 0x000D78D8 File Offset: 0x000D5AD8
			// (set) Token: 0x060032F3 RID: 13043 RVA: 0x000181BF File Offset: 0x000163BF
			public unsafe static Func<Socket.AwaitableSocketAsyncEventArgs> __9__22_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Socket.__c.NativeFieldInfoPtr___9__22_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Socket.AwaitableSocketAsyncEventArgs>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Socket.__c.NativeFieldInfoPtr___9__22_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700100B RID: 4107
			// (get) Token: 0x060032F4 RID: 13044 RVA: 0x000D7900 File Offset: 0x000D5B00
			// (set) Token: 0x060032F5 RID: 13045 RVA: 0x000181D1 File Offset: 0x000163D1
			public unsafe static AsyncCallback __9__23_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Socket.__c.NativeFieldInfoPtr___9__23_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Socket.__c.NativeFieldInfoPtr___9__23_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700100C RID: 4108
			// (get) Token: 0x060032F6 RID: 13046 RVA: 0x000D7928 File Offset: 0x000D5B28
			// (set) Token: 0x060032F7 RID: 13047 RVA: 0x000181E3 File Offset: 0x000163E3
			public unsafe static AsyncCallback __9__23_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Socket.__c.NativeFieldInfoPtr___9__23_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Socket.__c.NativeFieldInfoPtr___9__23_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700100D RID: 4109
			// (get) Token: 0x060032F8 RID: 13048 RVA: 0x000D7950 File Offset: 0x000D5B50
			// (set) Token: 0x060032F9 RID: 13049 RVA: 0x000181F5 File Offset: 0x000163F5
			public unsafe static IOAsyncCallback __9__295_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Socket.__c.NativeFieldInfoPtr___9__295_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOAsyncCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Socket.__c.NativeFieldInfoPtr___9__295_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700100E RID: 4110
			// (get) Token: 0x060032FA RID: 13050 RVA: 0x000D7978 File Offset: 0x000D5B78
			// (set) Token: 0x060032FB RID: 13051 RVA: 0x00018207 File Offset: 0x00016407
			public unsafe static IOAsyncCallback __9__297_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Socket.__c.NativeFieldInfoPtr___9__297_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOAsyncCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Socket.__c.NativeFieldInfoPtr___9__297_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700100F RID: 4111
			// (get) Token: 0x060032FC RID: 13052 RVA: 0x000D79A0 File Offset: 0x000D5BA0
			// (set) Token: 0x060032FD RID: 13053 RVA: 0x00018219 File Offset: 0x00016419
			public unsafe static IOAsyncCallback __9__310_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Socket.__c.NativeFieldInfoPtr___9__310_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOAsyncCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Socket.__c.NativeFieldInfoPtr___9__310_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040026F3 RID: 9971
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040026F4 RID: 9972
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x040026F5 RID: 9973
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x040026F6 RID: 9974
			private static readonly IntPtr NativeFieldInfoPtr___9__14_1;

			// Token: 0x040026F7 RID: 9975
			private static readonly IntPtr NativeFieldInfoPtr___9__15_0;

			// Token: 0x040026F8 RID: 9976
			private static readonly IntPtr NativeFieldInfoPtr___9__15_1;

			// Token: 0x040026F9 RID: 9977
			private static readonly IntPtr NativeFieldInfoPtr___9__22_0;

			// Token: 0x040026FA RID: 9978
			private static readonly IntPtr NativeFieldInfoPtr___9__22_1;

			// Token: 0x040026FB RID: 9979
			private static readonly IntPtr NativeFieldInfoPtr___9__23_0;

			// Token: 0x040026FC RID: 9980
			private static readonly IntPtr NativeFieldInfoPtr___9__23_1;

			// Token: 0x040026FD RID: 9981
			private static readonly IntPtr NativeFieldInfoPtr___9__295_0;

			// Token: 0x040026FE RID: 9982
			private static readonly IntPtr NativeFieldInfoPtr___9__297_0;

			// Token: 0x040026FF RID: 9983
			private static readonly IntPtr NativeFieldInfoPtr___9__310_0;

			// Token: 0x04002700 RID: 9984
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002701 RID: 9985
			private static readonly IntPtr NativeMethodInfoPtr__ConnectAsync_b__10_0_Internal_Void_IAsyncResult_0;

			// Token: 0x04002702 RID: 9986
			private static readonly IntPtr NativeMethodInfoPtr__ReceiveAsync_b__14_0_Internal_CachedEventArgs_0;

			// Token: 0x04002703 RID: 9987
			private static readonly IntPtr NativeMethodInfoPtr__ReceiveAsync_b__14_1_Internal_AwaitableSocketAsyncEventArgs_0;

			// Token: 0x04002704 RID: 9988
			private static readonly IntPtr NativeMethodInfoPtr__ReceiveAsyncApm_b__15_0_Internal_Void_IAsyncResult_0;

			// Token: 0x04002705 RID: 9989
			private static readonly IntPtr NativeMethodInfoPtr__ReceiveAsyncApm_b__15_1_Internal_Void_IAsyncResult_0;

			// Token: 0x04002706 RID: 9990
			private static readonly IntPtr NativeMethodInfoPtr__SendAsyncForNetworkStream_b__22_0_Internal_CachedEventArgs_0;

			// Token: 0x04002707 RID: 9991
			private static readonly IntPtr NativeMethodInfoPtr__SendAsyncForNetworkStream_b__22_1_Internal_AwaitableSocketAsyncEventArgs_0;

			// Token: 0x04002708 RID: 9992
			private static readonly IntPtr NativeMethodInfoPtr__SendAsyncApm_b__23_0_Internal_Void_IAsyncResult_0;

			// Token: 0x04002709 RID: 9993
			private static readonly IntPtr NativeMethodInfoPtr__SendAsyncApm_b__23_1_Internal_Void_IAsyncResult_0;

			// Token: 0x0400270A RID: 9994
			private static readonly IntPtr NativeMethodInfoPtr__SendAsync_b__295_0_Internal_Void_IOAsyncResult_0;

			// Token: 0x0400270B RID: 9995
			private static readonly IntPtr NativeMethodInfoPtr__BeginSend_b__297_0_Internal_Void_IOAsyncResult_0;

			// Token: 0x0400270C RID: 9996
			private static readonly IntPtr NativeMethodInfoPtr__BeginSendTo_b__310_0_Internal_Void_IOAsyncResult_0;

			// Token: 0x0400270D RID: 9997
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__367_0_Internal_Void_Object_SocketAsyncEventArgs_0;

			// Token: 0x0400270E RID: 9998
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__367_1_Internal_Void_Object_SocketAsyncEventArgs_0;

			// Token: 0x0400270F RID: 9999
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__367_2_Internal_Void_Object_SocketAsyncEventArgs_0;

			// Token: 0x04002710 RID: 10000
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__367_3_Internal_Void_IAsyncResult_0;

			// Token: 0x04002711 RID: 10001
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__367_4_Internal_Void_IOAsyncResult_0;

			// Token: 0x04002712 RID: 10002
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__367_5_Internal_Void_IOAsyncResult_0;

			// Token: 0x04002713 RID: 10003
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__367_6_Internal_Void_IAsyncResult_0;

			// Token: 0x04002714 RID: 10004
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__367_7_Internal_Void_IOAsyncResult_0;

			// Token: 0x04002715 RID: 10005
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__367_8_Internal_Void_IAsyncResult_0;

			// Token: 0x04002716 RID: 10006
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__367_9_Internal_Void_IOAsyncResult_0;

			// Token: 0x04002717 RID: 10007
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__367_10_Internal_Void_IAsyncResult_0;

			// Token: 0x04002718 RID: 10008
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__367_11_Internal_Void_IOAsyncResult_0;

			// Token: 0x04002719 RID: 10009
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__367_12_Internal_Void_IOAsyncResult_0;

			// Token: 0x0400271A RID: 10010
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__367_13_Internal_Void_IAsyncResult_0;

			// Token: 0x0400271B RID: 10011
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__367_14_Internal_Void_IOAsyncResult_0;

			// Token: 0x0400271C RID: 10012
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__367_15_Internal_Void_IAsyncResult_0;

			// Token: 0x0400271D RID: 10013
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__367_16_Internal_Void_IOAsyncResult_0;

			// Token: 0x0400271E RID: 10014
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__367_17_Internal_Void_IAsyncResult_0;
		}

		// Token: 0x02000370 RID: 880
		[ObfuscatedName("System.Net.Sockets.Socket+<>c__DisplayClass240_0")]
		public sealed class __c__DisplayClass240_0 : Object
		{
			// Token: 0x060032FE RID: 13054 RVA: 0x000D79C8 File Offset: 0x000D5BC8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass240_0()
			{
				Il2CppClassPointerStore<Socket.__c__DisplayClass240_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Socket>.NativeClassPtr, "<>c__DisplayClass240_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Socket.__c__DisplayClass240_0>.NativeClassPtr);
				Socket.__c__DisplayClass240_0.NativeFieldInfoPtr_sockares = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.__c__DisplayClass240_0>.NativeClassPtr, "sockares");
				Socket.__c__DisplayClass240_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c__DisplayClass240_0>.NativeClassPtr, 100669017);
				Socket.__c__DisplayClass240_0.NativeMethodInfoPtr__BeginConnect_b__0_Internal_Void_Task_1_Il2CppReferenceArray_1_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c__DisplayClass240_0>.NativeClassPtr, 100669018);
			}

			// Token: 0x060032FF RID: 13055 RVA: 0x000D7A30 File Offset: 0x000D5C30
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass240_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Socket.__c__DisplayClass240_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c__DisplayClass240_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003300 RID: 13056 RVA: 0x000D7A6C File Offset: 0x000D5C6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488049, XrefRangeEnd = 488067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _BeginConnect_b__0(Task<Il2CppReferenceArray<IPAddress>> t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c__DisplayClass240_0.NativeMethodInfoPtr__BeginConnect_b__0_Internal_Void_Task_1_Il2CppReferenceArray_1_IPAddress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003301 RID: 13057 RVA: 0x0001822B File Offset: 0x0001642B
			public __c__DisplayClass240_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001010 RID: 4112
			// (get) Token: 0x06003302 RID: 13058 RVA: 0x000D7AB0 File Offset: 0x000D5CB0
			// (set) Token: 0x06003303 RID: 13059 RVA: 0x00018234 File Offset: 0x00016434
			public unsafe SocketAsyncResult sockares
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.__c__DisplayClass240_0.NativeFieldInfoPtr_sockares);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SocketAsyncResult>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.__c__DisplayClass240_0.NativeFieldInfoPtr_sockares), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400271F RID: 10015
			private static readonly IntPtr NativeFieldInfoPtr_sockares;

			// Token: 0x04002720 RID: 10016
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002721 RID: 10017
			private static readonly IntPtr NativeMethodInfoPtr__BeginConnect_b__0_Internal_Void_Task_1_Il2CppReferenceArray_1_IPAddress_0;
		}

		// Token: 0x02000371 RID: 881
		[ObfuscatedName("System.Net.Sockets.Socket+<>c__DisplayClass298_0")]
		public sealed class __c__DisplayClass298_0 : Object
		{
			// Token: 0x06003304 RID: 13060 RVA: 0x000D7AE0 File Offset: 0x000D5CE0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass298_0()
			{
				Il2CppClassPointerStore<Socket.__c__DisplayClass298_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Socket>.NativeClassPtr, "<>c__DisplayClass298_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Socket.__c__DisplayClass298_0>.NativeClassPtr);
				Socket.__c__DisplayClass298_0.NativeFieldInfoPtr_sent_so_far = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.__c__DisplayClass298_0>.NativeClassPtr, "sent_so_far");
				Socket.__c__DisplayClass298_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c__DisplayClass298_0>.NativeClassPtr, 100669019);
				Socket.__c__DisplayClass298_0.NativeMethodInfoPtr__BeginSendCallback_b__0_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c__DisplayClass298_0>.NativeClassPtr, 100669020);
			}

			// Token: 0x06003305 RID: 13061 RVA: 0x000D7B48 File Offset: 0x000D5D48
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass298_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Socket.__c__DisplayClass298_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c__DisplayClass298_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003306 RID: 13062 RVA: 0x000D7B84 File Offset: 0x000D5D84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488067, XrefRangeEnd = 488074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _BeginSendCallback_b__0(IOAsyncResult s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c__DisplayClass298_0.NativeMethodInfoPtr__BeginSendCallback_b__0_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003307 RID: 13063 RVA: 0x00018253 File Offset: 0x00016453
			public __c__DisplayClass298_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001011 RID: 4113
			// (get) Token: 0x06003308 RID: 13064 RVA: 0x000D7BC8 File Offset: 0x000D5DC8
			// (set) Token: 0x06003309 RID: 13065 RVA: 0x0001825C File Offset: 0x0001645C
			public unsafe int sent_so_far
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.__c__DisplayClass298_0.NativeFieldInfoPtr_sent_so_far);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.__c__DisplayClass298_0.NativeFieldInfoPtr_sent_so_far)) = value;
				}
			}

			// Token: 0x04002722 RID: 10018
			private static readonly IntPtr NativeFieldInfoPtr_sent_so_far;

			// Token: 0x04002723 RID: 10019
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002724 RID: 10020
			private static readonly IntPtr NativeMethodInfoPtr__BeginSendCallback_b__0_Internal_Void_IOAsyncResult_0;
		}

		// Token: 0x02000372 RID: 882
		[ObfuscatedName("System.Net.Sockets.Socket+<>c__DisplayClass311_0")]
		public sealed class __c__DisplayClass311_0 : Object
		{
			// Token: 0x0600330A RID: 13066 RVA: 0x000D7BF0 File Offset: 0x000D5DF0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass311_0()
			{
				Il2CppClassPointerStore<Socket.__c__DisplayClass311_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Socket>.NativeClassPtr, "<>c__DisplayClass311_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Socket.__c__DisplayClass311_0>.NativeClassPtr);
				Socket.__c__DisplayClass311_0.NativeFieldInfoPtr_sent_so_far = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.__c__DisplayClass311_0>.NativeClassPtr, "sent_so_far");
				Socket.__c__DisplayClass311_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c__DisplayClass311_0>.NativeClassPtr, 100669021);
				Socket.__c__DisplayClass311_0.NativeMethodInfoPtr__BeginSendToCallback_b__0_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c__DisplayClass311_0>.NativeClassPtr, 100669022);
			}

			// Token: 0x0600330B RID: 13067 RVA: 0x000D7C58 File Offset: 0x000D5E58
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass311_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Socket.__c__DisplayClass311_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c__DisplayClass311_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600330C RID: 13068 RVA: 0x000D7C94 File Offset: 0x000D5E94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488074, XrefRangeEnd = 488081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _BeginSendToCallback_b__0(IOAsyncResult s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c__DisplayClass311_0.NativeMethodInfoPtr__BeginSendToCallback_b__0_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600330D RID: 13069 RVA: 0x00018277 File Offset: 0x00016477
			public __c__DisplayClass311_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001012 RID: 4114
			// (get) Token: 0x0600330E RID: 13070 RVA: 0x000D7CD8 File Offset: 0x000D5ED8
			// (set) Token: 0x0600330F RID: 13071 RVA: 0x00018280 File Offset: 0x00016480
			public unsafe int sent_so_far
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.__c__DisplayClass311_0.NativeFieldInfoPtr_sent_so_far);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.__c__DisplayClass311_0.NativeFieldInfoPtr_sent_so_far)) = value;
				}
			}

			// Token: 0x04002725 RID: 10021
			private static readonly IntPtr NativeFieldInfoPtr_sent_so_far;

			// Token: 0x04002726 RID: 10022
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002727 RID: 10023
			private static readonly IntPtr NativeMethodInfoPtr__BeginSendToCallback_b__0_Internal_Void_IOAsyncResult_0;
		}

		// Token: 0x02000373 RID: 883
		[ObfuscatedName("System.Net.Sockets.Socket+<>c__DisplayClass355_0")]
		public sealed class __c__DisplayClass355_0 : Object
		{
			// Token: 0x06003310 RID: 13072 RVA: 0x000D7D00 File Offset: 0x000D5F00
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass355_0()
			{
				Il2CppClassPointerStore<Socket.__c__DisplayClass355_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Socket>.NativeClassPtr, "<>c__DisplayClass355_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Socket.__c__DisplayClass355_0>.NativeClassPtr);
				Socket.__c__DisplayClass355_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.__c__DisplayClass355_0>.NativeClassPtr, "<>4__this");
				Socket.__c__DisplayClass355_0.NativeFieldInfoPtr_job = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.__c__DisplayClass355_0>.NativeClassPtr, "job");
				Socket.__c__DisplayClass355_0.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket.__c__DisplayClass355_0>.NativeClassPtr, "handle");
				Socket.__c__DisplayClass355_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c__DisplayClass355_0>.NativeClassPtr, 100669023);
				Socket.__c__DisplayClass355_0.NativeMethodInfoPtr__QueueIOSelectorJob_b__0_Internal_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket.__c__DisplayClass355_0>.NativeClassPtr, 100669024);
			}

			// Token: 0x06003311 RID: 13073 RVA: 0x000D7D90 File Offset: 0x000D5F90
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass355_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Socket.__c__DisplayClass355_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c__DisplayClass355_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003312 RID: 13074 RVA: 0x000D7DCC File Offset: 0x000D5FCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488081, XrefRangeEnd = 488084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _QueueIOSelectorJob_b__0(Task t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.__c__DisplayClass355_0.NativeMethodInfoPtr__QueueIOSelectorJob_b__0_Internal_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003313 RID: 13075 RVA: 0x0001829B File Offset: 0x0001649B
			public __c__DisplayClass355_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001013 RID: 4115
			// (get) Token: 0x06003314 RID: 13076 RVA: 0x000D7E10 File Offset: 0x000D6010
			// (set) Token: 0x06003315 RID: 13077 RVA: 0x000182A4 File Offset: 0x000164A4
			public unsafe Socket __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.__c__DisplayClass355_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.__c__DisplayClass355_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001014 RID: 4116
			// (get) Token: 0x06003316 RID: 13078 RVA: 0x000D7E40 File Offset: 0x000D6040
			// (set) Token: 0x06003317 RID: 13079 RVA: 0x000182C3 File Offset: 0x000164C3
			public unsafe IOSelectorJob job
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.__c__DisplayClass355_0.NativeFieldInfoPtr_job);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOSelectorJob>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.__c__DisplayClass355_0.NativeFieldInfoPtr_job), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001015 RID: 4117
			// (get) Token: 0x06003318 RID: 13080 RVA: 0x000D7E70 File Offset: 0x000D6070
			// (set) Token: 0x06003319 RID: 13081 RVA: 0x000182E2 File Offset: 0x000164E2
			public unsafe IntPtr handle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.__c__DisplayClass355_0.NativeFieldInfoPtr_handle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Socket.__c__DisplayClass355_0.NativeFieldInfoPtr_handle)) = value;
				}
			}

			// Token: 0x04002728 RID: 10024
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002729 RID: 10025
			private static readonly IntPtr NativeFieldInfoPtr_job;

			// Token: 0x0400272A RID: 10026
			private static readonly IntPtr NativeFieldInfoPtr_handle;

			// Token: 0x0400272B RID: 10027
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400272C RID: 10028
			private static readonly IntPtr NativeMethodInfoPtr__QueueIOSelectorJob_b__0_Internal_Void_Task_0;
		}
	}
}
